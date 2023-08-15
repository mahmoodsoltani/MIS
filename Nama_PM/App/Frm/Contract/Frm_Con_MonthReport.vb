Imports Microsoft.Office.Interop.Excel

Public Class Frm_Con_MonthReport
    Private Srl_MonthReport As Integer
    Private dt As Ds_Con.Pm_Con_MonthReportAmountDataTable

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean

        If txt_Price.Text = "0" Or txt_Price.Text = "" Then
            MessageBoxFa.Show("مبلغ صورت وضعیت را مشخص نمائید", "هشدار")
            btn_Update.Focus()
            Return False

        End If
        If (txt_ConfirmPrice.Value <> 0 And txt_ConfirmDate.Value = "") Or (txt_ConfirmPrice.Value = 0 And txt_ConfirmDate.Value <> "") Then
            MessageBoxFa.Show("مبلغ و یا تاریخ تائید نیاز است", "هشدار")
            txt_ConfirmDate.Focus()
            Return False
        End If
        Dim srl_contract As Integer = cmb_Contract.SelectedValue
        Dim srl_posttype As Integer = -1
        If Not cmb_Omor.SelectedValue Is Nothing Then
            srl_posttype = cmb_Omor.SelectedValue
        End If
        Dim srl_source As Integer = cmb_Source.SelectedValue
        Dim month As Integer = cmb_Month.SelectedValue
        Dim year As Integer = txt_year.Text
        Dim srl_vahed As Integer = cmb_Vahed.SelectedValue
        Dim sstype As Integer = cmb_Type.SelectedValue
        Try
            If Srl_MonthReport = -1 Then
                Dim query As String = "select * from Pm_Con_MonthReport " & _
                      "where Srl_Con_Contract =" + srl_contract.ToString() + " and Srl_Pm_Con_source =" + srl_source.ToString() + " and Srl_Pm_PostType =" + srl_posttype.ToString() + "" & _
                      " and [year]=" + year.ToString() + " and [month]=" + month.ToString() + " and Srl_Pm_Vahed = " + srl_vahed.ToString() + " and srl_Statusstatementtype =" + sstype.ToString()
                If CInt(BaseDataObject.DataAccess.ExecScalar(query)) > 0 Then
                    MessageBoxFa.Show("با این مشخصات قبلا گزارش ماهیانه ثبت شده است")
                    Return False
                End If

                Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Con_MonthReport")
                BaseDataObject.DataAccess.BeginTransaction()
                'Dim n As String = BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(number),0) from Pm_Con_StatusStatement")
                'dr("Number") = (CInt(n) + 1).ToString()
                dr("Number") = txt_Number.Text
                dr("LetterNumber") = txt_LetterNumber.Text
                dr("Srl_Con_Contract") = cmb_Contract.SelectedValue
                dr("Year") = txt_year.Text
                dr("Month") = cmb_Month.SelectedValue
                dr("Srl_Pm_Con_source") = cmb_Source.SelectedValue
                If Not cmb_Omor.SelectedValue Is Nothing Then
                    dr("Srl_Pm_PostType") = cmb_Omor.SelectedValue
                End If
                dr("Srl_Pm_Vahed") = cmb_Vahed.SelectedValue
                dr("srl_Statusstatementtype") = cmb_Type.SelectedValue
                dr("SendDate") = txt_sendDate.Value
                dr("Price") = txt_Price.Value
                dr("ConfirmDate") = txt_ConfirmDate.Value
                dr("ConfirmPrice") = txt_ConfirmPrice.Value
                dr("ERPDate") = txt_ErpDate.Value
                dr("DeliveryNumber") = txt_DeliveryNumber.Text
                dr("StatusNumber") = txt_statementNumber.Text
                dr("DocumentNumber") = txt_DocumentNumber.Text
                dr("Description") = txt_Discription.Text
                dr("IsCancle") = chk_Iscancle.Checked
                dr("Srl_SubmitUser") = Setting.Srl_User
                dr("SubmitDate") = DateTime.Now
                Dim Srl_MonthReport As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)

                If Srl_MonthReport > 0 Then
                    Dim srl_omoor = -1
                    If Not cmb_Omor.SelectedValue Is Nothing Then
                        srl_omoor = cmb_Omor.SelectedValue
                    End If
                    If BaseDataObject.DataAccess.ExecQuery("exec [Pm_con_UpdateStatustatementReport] " + cmb_Vahed.SelectedValue.ToString() + "," + cmb_Source.SelectedValue.ToString() + "," + srl_omoor.ToString() + "," + txt_year.Text + "," + cmb_Month.SelectedValue.ToString() + "," + cmb_Type.SelectedValue.ToString() + ",'-1','-1',-1,-1,-1," + cmb_Contract.SelectedValue.ToString() + "," + Srl_MonthReport.ToString()) Then
                        BaseDataObject.DataAccess.Commit()
                        MessageBoxFa.Show("ذخیره سازی با موفقیت انجام گردید")
                        ClearFormData()
                    Else
                        BaseDataObject.DataAccess.RollBack()
                        MessageBoxFa.Show("خطا در ذخیره سازی اطلاعات", "هشدار", MessageBoxButtons.OK)
                    End If
                Else
                    BaseDataObject.DataAccess.RollBack()
                    MessageBoxFa.Show("خطا در ذخیره سازی اطلاعات", "هشدار", MessageBoxButtons.OK)
                End If
            Else

                Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_con_MonthReport", Srl_MonthReport)
                If Not dr Is Nothing Then
                    BaseDataObject.DataAccess.BeginTransaction()
                    BaseDataObject.DataAccess.ExecQuery("Update pm_con_statusstatementitem set Srl_MonthReport=null where Srl_MonthReport= " + Srl_MonthReport.ToString())
                    Dim srl_omoor = -1
                    If Not cmb_Omor.SelectedValue Is Nothing Then
                        srl_omoor = cmb_Omor.SelectedValue
                    End If
                    BaseDataObject.DataAccess.ExecQuery("exec [Pm_con_UpdateStatustatementReport] " + cmb_Vahed.SelectedValue.ToString() + "," + cmb_Source.SelectedValue.ToString() + "," + srl_omoor.ToString() + "," + txt_year.Text + "," + cmb_Month.SelectedValue.ToString() + "," + cmb_Type.SelectedValue.ToString() + ",'-1','-1',-1,-1,-1," + cmb_Contract.SelectedValue.ToString() + "," + Srl_MonthReport.ToString())
                    dr("LetterNumber") = txt_LetterNumber.Text
                    dr("Srl_Con_Contract") = cmb_Contract.SelectedValue
                    dr("Year") = txt_year.Text
                    dr("Month") = cmb_Month.SelectedValue
                    dr("Srl_Pm_Con_source") = cmb_Source.SelectedValue
                    If Not cmb_Omor.SelectedValue Is Nothing Then
                        dr("Srl_Pm_PostType") = cmb_Omor.SelectedValue
                    End If
                    dr("Srl_Pm_Vahed") = cmb_Vahed.SelectedValue
                    dr("srl_Statusstatementtype") = cmb_Type.SelectedValue
                    dr("SendDate") = txt_sendDate.Value
                    dr("Price") = txt_Price.Value
                    dr("ConfirmDate") = txt_ConfirmDate.Value
                    dr("ConfirmPrice") = txt_ConfirmPrice.Value
                    dr("ERPDate") = txt_ErpDate.Value
                    dr("DeliveryNumber") = txt_DeliveryNumber.Text
                    dr("StatusNumber") = txt_statementNumber.Text
                    dr("DocumentNumber") = txt_DocumentNumber.Text
                    dr("Description") = txt_Discription.Text
                    dr("IsCancle") = chk_Iscancle.Checked
                    dr("Srl_SubmitUser") = Setting.Srl_User
                    dr("SubmitDate") = DateTime.Now
                    If BaseDataObject.DataAccess.Update(dr, 0) Then
                        BaseDataObject.DataAccess.Commit()
                        MessageBoxFa.Show("ویرایش با موفقیت انجام گردید")
                        Me.Close()
                        Me.Close()
                    End If
                End If
                DataObject.DataRow("Srl") = Srl_MonthReport
            End If

        Catch
            BaseDataObject.DataAccess.RollBack()
            MessageBoxFa.Show("خطا در ذخیره سازی اطلاعات", "هشدار", MessageBoxButtons.OK)
        End Try
    End Function
    Public Sub New(ByVal srl As Integer)
        Srl_MonthReport = srl
        If srl <> -1 Then
            Me.FormState = FormStates.Edit
        Else
            Me.FormState = FormStates.NewRecord
        End If
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub ClearFormData()
        setnumber()
        txt_LetterNumber.Text = ""
        txt_year.Text = FarsiDateFun.Now.Substring(0, 4)
        Dim m As Integer = CInt(FarsiDateFun.Now.Substring(5, 2)) - 1
        If m = 0 Then
            txt_year.Text = (CInt(txt_year.Text) - 1).ToString()
            m = 12
        End If
        cmb_Month.SelectedValue = m
        'Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        ' Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        'Me.Pm_Con_SourceTableAdapter.Fill(Me.Ds_Con.Pm_Con_Source)
        'Me.Pm_Con_StatusStatementTypeTableAdapter.Fill(Me.Ds_Con.Pm_Con_StatusStatementType)
        txt_ConfirmDate.Value = ""
        txt_ErpDate.Value = ""
        txt_sendDate.Value = FarsiDateFun.Now
        txt_Price.Text = "0"
        txt_ConfirmPrice.Text = "0"
        txt_DeliveryNumber.Text = "0"
        txt_DocumentNumber.Text = ""
        txt_statementNumber.Text = ""
        txt_Discription.Text = ""
        chk_Iscancle.Checked = False

    End Sub

    Public Sub setnumber()

        Dim Num As Integer
        Num = BaseDataObject.DataAccess.ExecScalar("select isnull(max(number),0) from pm_con_MonthReport where srl_con_contract=" + cmb_Contract.SelectedValue.ToString())
        txt_Number.Text = (Num + 1).ToString()
        txt_Number.Enabled = False
    End Sub
    Private Sub Frm_Con_StatusStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Contract' table. You can move, or remove it, as needed.
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_StatusStatementType' table. You can move, or remove it, as needed.
        Me.Pm_Con_StatusStatementTypeTableAdapter.Fill(Me.Ds_Con.Pm_Con_StatusStatementType)
        setnumber()
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        Me.Pm_Con_SourceTableAdapter.Fill(Me.Ds_Con.Pm_Con_Source)
        Me.Pm_MonthTableAdapter.Fill(Me.Ds_Con.Pm_Month)
        If Srl_MonthReport = -1 Then
            txt_ConfirmDate.Value = ""
            txt_ErpDate.Value = ""
            txt_sendDate.Value = FarsiDateFun.Now
            txt_year.Text = FarsiDateFun.Now.Substring(0, 4)
            Dim m As Integer = CInt(FarsiDateFun.Now.Substring(5, 2)) - 1
            If m = 0 Then
                m = 12
                txt_year.Text = (CInt(txt_year.Text) - 1).ToString()
            End If
            cmb_Month.SelectedValue = m
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("pm_con_monthreport", Srl_MonthReport)
            If Not dr Is Nothing Then
                txt_Number.Text = dr("Number")
                txt_LetterNumber.Text = dr("LetterNumber")
                txt_year.Text = dr("Year")
                cmb_Month.SelectedValue = dr("Month")
                cmb_Type.SelectedValue = dr("srl_Statusstatementtype")
                cmb_Source.SelectedValue = dr("Srl_Pm_con_Source")
                cmb_Contract.SelectedValue = dr("Srl_Con_Contract")
                If cmb_Source.SelectedIndex = 0 Then
                    cmb_Omor.Enabled = True
                    cmb_Omor.SelectedValue = dr("Srl_Pm_PostType")
                Else
                    cmb_Omor.Enabled = False
                End If
                cmb_Vahed.SelectedValue = dr("srl_pm_vahed")
                txt_sendDate.Value = dr("Senddate")
                txt_Price.Text = dr("Price")
                CalculatePrice()
                txt_ConfirmDate.Value = dr("Confirmdate")
                txt_ConfirmPrice.Text = dr("ConfirmPrice")
                txt_ErpDate.Value = dr("ERPDate")
                txt_DeliveryNumber.Text = dr("DeliveryNumber")
                txt_DocumentNumber.Text = dr("DocumentNumber")
                txt_Discription.Text = dr("Description")
                txt_statementNumber.Text = dr("StatusNumber")
                chk_Iscancle.Checked = dr("IsCancle")
                CalculatePrice()
            End If

        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Source.SelectedIndexChanged
        If cmb_Source.SelectedIndex >= 0 Then
            If cmb_Source.SelectedIndex = 0 Then
                cmb_Omor.Enabled = True
                cmb_Omor.SelectedIndex = 0
            Else
                cmb_Omor.Enabled = False
                cmb_Omor.SelectedIndex = -1
            End If
        End If
        txt_Price.Text = "0"

    End Sub

    'Private Sub cmb_Contract_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Contract.SelectedIndexChanged
    '    If Not checkContract() Then
    '        MessageBoxFa.Show("بازه انتخاب شده با تاریخ قرارداد تطابق ندارد")
    '        cmb_Contract.Focus()
    '    End If
    'End Sub
    Private Function checkContract() As Boolean
        If txt_year.Text = "" Then
            Return True
        End If
        Dim month As String = ""
        If cmb_Month.SelectedValue < 10 Then
            month = "0" + cmb_Month.SelectedValue.ToString()
        Else
            month = cmb_Month.SelectedValue.ToString()
        End If
        Dim start As String = txt_year.Text + "/" + month + "/01"
        Dim srl As Integer = BaseDataObject.DataAccess.ExecScalar("select ISNULL( srl,-1)as srl from pm_con_contract where StartDate<='" + start + "' and EndDate>='" + start + "'")
        If srl < 1 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Private Sub txt_year_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_year.Leave
    '    If Not checkContract() Then
    '        MessageBoxFa.Show("بازه انتخاب شده با تاریخ قرارداد تطابق ندارد")
    '        txt_year.Focus()
    '    End If
    'End Sub

    'Private Sub cmb_Month_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Month.SelectedIndexChanged
    '    If Not checkContract() Then
    '        MessageBoxFa.Show("بازه انتخاب شده با تاریخ قرارداد تطابق ندارد")
    '        cmb_Month.Focus()
    '        Return
    '    End If
    '    CalculatePrice()
    'End Sub
    Private Sub CalculatePrice()
        Try
            If Not checkContract() Then
                MessageBoxFa.Show("بازه انتخاب شده با تاریخ قرارداد تطابق ندارد")
                txt_year.Focus()
                Return
            Else
                If txt_year.Text = "" Then
                    MessageBoxFa.Show("لطفا سال را انتخاب نمائید")
                    txt_year.Focus()
                    Return
                End If
            End If
            Dim srl_omoor As Integer = -1
            If Not cmb_Omor.SelectedValue Is Nothing Then
                srl_omoor = cmb_Omor.SelectedValue
            End If
            Me.Pm_Con_MonthReportAmount.Fill(Me.Ds_Con.Pm_Con_MonthReportAmount, srl_omoor, cmb_Vahed.SelectedValue, cmb_Source.SelectedValue, CInt(txt_year.Text), cmb_Month.SelectedValue, cmb_Type.SelectedValue, cmb_Contract.SelectedValue)
            If Me.Ds_Con.Pm_Con_MonthReportAmount Is Nothing Then
                txt_Price.Text = "0"
            ElseIf Me.Ds_Con.Pm_Con_MonthReportAmount.Rows.Count > 0 Then
                dt = Me.Ds_Con.Pm_Con_MonthReportAmount
                Dim sum As Long = 0
                For Each dr As DataRow In Me.Ds_Con.Pm_Con_MonthReportAmount.Rows
                    sum += Convert.ToInt64(dr(0).ToString())
                Next
                txt_Price.Text = sum.ToString()
            Else
                txt_Price.Text = 0
            End If
            'MessageBoxFa.Show("بروزرسانی مبلغ انجام گردید")
        Catch
            txt_Price.Text = "0"
            MessageBoxFa.Show("خطا در بروزرسانی مبلغ")

        End Try


    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        'Dim f As New Frm_Wait
        'Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)
        'Try
        '    t.Start()
        '    CalculatePrice()
        '    If t.IsAlive Then
        '        t.Abort()
        '    End If
        'Catch ex As Exception
        '    If t.IsAlive Then
        '        t.Abort()
        '    End If
        'End Try
        CalculatePrice()
    End Sub

    Private Sub btn_ShowItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ShowItem.Click
        Dim f As New Frm_Con_StatusstatementItemVw(cmb_Omor.SelectedValue, cmb_Source.SelectedValue, cmb_Vahed.SelectedValue, CInt(txt_year.Text), cmb_Month.SelectedValue, cmb_Type.SelectedValue, cmb_Contract.SelectedValue)
        f.ShowDialog()
    End Sub

    Function IsXLBookOpen(ByVal strName As String) As Boolean
        Dim i As Long
        Dim XLAppFx As Microsoft.Office.Interop.Excel.Application
        Dim NotOpen As Boolean
        On Error Resume Next
        XLAppFx = GetObject(, "Excel.Application")
        If Err.Number = 429 Then
            NotOpen = True
            XLAppFx = CreateObject("Excel.Application")
            Err.Clear()
        End If
        For i = XLAppFx.Workbooks.Count To 1 Step -1
            If XLAppFx.Workbooks(i).name = strName Then Exit For
        Next i
        IsXLBookOpen = False
        If i <> 0 Then IsXLBookOpen = True
        If NotOpen Then XLAppFx.Quit()
        XLAppFx = Nothing

    End Function

    Private Sub btn_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Excel.Click
        Dim f As New Frm_Wait
        Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)

        Try
            Dim srl_source As Integer = -1
            If Not cmb_Source.SelectedValue Is Nothing Then
                srl_source = cmb_Source.SelectedValue
            End If
            Dim srl_omoor As Integer = -1
            If Not cmb_Omor.SelectedValue Is Nothing Then
                srl_omoor = cmb_Omor.SelectedValue
            End If
            Dim srl_type As Integer = -1
            If Not cmb_Type Is Nothing Then
                srl_type = cmb_Type.SelectedValue
            End If
            Dim ResultDT As New System.Data.DataTable
            Dim Lan As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            ResultDT.Columns.Add("نام گروه")
            ResultDT.Columns.Add("مبلغ ارسالی")
            ResultDT.Columns.Add("مبلغ مورد تائید")

            Dim W_CancleZarib As Double = 0
            Dim W_BeforCancleZarib As Double = 0
            Dim NW_CancleZarib As Double = 0
            Dim NW_BeforCancleZarib As Double = 0
            Dim Holiday As Double = 1
            Dim NightWork As Double = 1
            Dim AllAllSum As Long = 0
            Dim FolderName As String = ""
            Dim query As String = "select pm_con_contractzarib.* from pm_con_contractzarib where srl_contract=" + cmb_Contract.SelectedValue.ToString()
            Dim dr1 As DataRow = BaseDataObject.DataAccess.GetRow(query)
            If dr1 Is Nothing Then
                MessageBoxFa.Show("برای این قرارداد ضریب های مناسب تعریف نشده است.بصورت پیش فرض برای ضرایب کنسلی صفر و مابقی یک است", "هشدار", MessageBoxButtons.OK)
            Else
                W_CancleZarib = CDbl(dr1("WorkForm_Cancle"))
                NW_CancleZarib = CDbl(dr1("nonworkform_cancle"))
                W_BeforCancleZarib = CDbl(dr1("WorkForm_Cancle_BeforDay"))
                NW_BeforCancleZarib = CDbl(dr1("NonWorkForm_Cancle_BeforeDay"))
                Holiday = CDbl(dr1("Holiday"))
                NightWork = CDbl(dr1("NightWork"))
            End If

            If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                FolderName = FolderBrowserDialog1.SelectedPath
            Else
                
                Return
            End If


            Dim rowIndex As Integer = 1
            Dim StartRowindex As Integer = 1
            Dim strFile As String = FolderName + "\DetailReport(" + cmb_Vahed.Text + "-" + cmb_Month.Text + " ماه " + txt_year.Text + " ).xlsx"
            Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
            If IsXLBookOpen("DetailReport(" + cmb_Vahed.Text + "-" + cmb_Month.Text + " ماه " + txt_year.Text + " ).xlsx") Then
                MessageBoxFa.Show("فایل زیر باز است. ابتدا آن را ببندید" + vbNewLine + strFile)
                Return
            End If
            If t.IsAlive Then
                t.Abort()
            End If
            t.Start()

            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()
            wSheet.DisplayRightToLeft = True
            wSheet.Rows.Font.Name = "B Titr"
            wSheet.Columns(2).WrapText = True
            wSheet.Columns(2).ColumnWidth = 30
            wSheet.Range("A1:X500").Font.Name = "B Titr"
            wSheet.Range("A1:X500").Font.Size = "9"
            wSheet.Range("c5:c100").NumberFormat = "000,000"
            wSheet.Range("A1:X500").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            wSheet.Range("A1:X500").Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            Dim groups As System.Data.DataTable = BaseDataObject.DataAccess.GetDataTable("Pm_group", "Srl_pm_vahed=" + cmb_Vahed.SelectedValue.ToString() + " Order by name")
            If Not groups Is Nothing Then
                For Each Groupdr In groups.Rows
                    Try
                        Dim StartIdex As Integer = 1
                        Dim Groupsum As Long = 0
                        Dim EndIndex As Integer = 9
                        If Groupdr("srl").ToString() = "158" Then
                            StartIdex = 1
                        End If
                        Dim dt As System.Data.DataTable = BaseDataObject.DataAccess.GetDataTable("exec pm_con_Excelrp_SSPM " + cmb_Vahed.SelectedValue.ToString() + "," + srl_source.ToString() + "," + srl_omoor.ToString() + "," + txt_year.Text + "," + cmb_Month.SelectedValue.ToString() + "," + srl_type.ToString() + ",'-1','-1',-1," + Groupdr("srl").ToString() + ",-1," + cmb_Contract.SelectedValue.ToString() + "," + StartIdex.ToString() + "," + EndIndex.ToString())
                        While dt.Rows.Count > 0
                            Dim RowCount As Integer = 0
                            'StartRowindex = rowIndex
                            If dt Is Nothing Or dt.Rows.Count < 1 Then
                                Continue For
                            End If


                            Dim dc As System.Data.DataColumn
                            Dim dr As System.Data.DataRow
                            Dim colIndex As Integer = 0

                            rowIndex = rowIndex + 4
                            excel.Cells(StartRowindex, 1) = "صورت وضعیت گروه ( " + Groupdr("Name").ToString() + ") " + cmb_Month.Text + " ماه " + txt_year.Text
                            wSheet.Range("A" + (StartRowindex).ToString() + ":C" + (StartRowindex + 2).ToString() + "").Merge()
                            wSheet.Range("A" + (StartRowindex).ToString() + ":C" + (StartRowindex + 2).ToString() + "").Interior.ColorIndex = 15
                            wSheet.Range("A" + (StartRowindex).ToString() + ":C" + (StartRowindex + 2).ToString() + "").Font.Bold = True
                            wSheet.Range("A" + (StartRowindex).ToString() + ":C" + (StartRowindex + 2).ToString() + "").Font.Size = 12

                            For Each dc In dt.Columns
                                colIndex = colIndex + 1
                                If dc.ColumnName.Contains("__") Then
                                    Dim s As String = dc.ColumnName
                                    Dim s1 = New List(Of String)
                                    s1.AddRange(s.Split("__"))
                                    s1.RemoveAll(Function(str) String.IsNullOrEmpty(str))
                                    excel.Cells(StartRowindex, colIndex) = s1(0)
                                    If s1(2) = "1" Or s1(4) = "1" Then
                                        excel.Cells(StartRowindex + 2, colIndex) = "کنسلی 50%"
                                        excel.Cells(StartRowindex + 2, colIndex).Interior.ColorIndex = 3
                                        excel.Cells(StartRowindex + 2, colIndex).font.colorindex = 2

                                    ElseIf s1(3) = "1" Or s1(5) = "1" Then
                                        excel.Cells(StartRowindex + 2, colIndex) = "کنسلی 20%"
                                        excel.Cells(StartRowindex + 2, colIndex).Interior.ColorIndex = 3
                                        excel.Cells(StartRowindex + 2, colIndex).font.colorindex = 2

                                    ElseIf s1(6) = "1" Then
                                        excel.Cells(StartRowindex + 2, colIndex) = "تعطیلی"
                                        excel.Cells(StartRowindex + 2, colIndex).Interior.ColorIndex = 46
                                    ElseIf s1(7) = "1" Then
                                        excel.Cells(StartRowindex + 2, colIndex) = "کارشبانه"
                                        excel.Cells(StartRowindex + 2, colIndex).Interior.ColorIndex = 28

                                    Else
                                        excel.Cells(StartRowindex + 2, colIndex) = ""
                                    End If
                                    excel.Cells(StartRowindex + 1, colIndex) = s1(1)
                                    Try
                                        excel.Cells(StartRowindex + 3, colIndex) = s1(8) + "_" + s1(9)
                                    Catch
                                        excel.Cells(StartRowindex + 3, colIndex) = ""

                                    End Try

                                Else

                                    excel.Cells(rowIndex - 1, colIndex) = dc.ColumnName
                                End If
                            Next
                            rowIndex = rowIndex - 1

                            For i As Integer = 0 To dt.Rows.Count - 1
                                Dim formula As String = ""
                                Dim zarib As Double = 1
                                Dim dr2 As DataRow = dt.Rows(i)
                                rowIndex = rowIndex + 1
                                colIndex = 0
                                Dim sum As Double = 0
                                Dim SumPrice As Integer = 0
                                formula = "="
                                For Each dc In dt.Columns
                                    colIndex = colIndex + 1
                                    If dc.ColumnName.Contains("__") And (Not TypeOf (dr2(dc.ColumnName)) Is DBNull) Then
                                        Dim s As String = dc.ColumnName
                                        Dim s1 = New List(Of String)
                                        s1.AddRange(s.Split("__"))
                                        s1.RemoveAll(Function(str) String.IsNullOrEmpty(str))
                                        If s1(2) = "1" Then
                                            sum += Int(CDbl(dr2(dc.ColumnName)) * (W_CancleZarib) * CInt(dr2(2)))
                                            zarib = W_CancleZarib
                                        ElseIf s1(4) = "1" Then
                                            sum += Int(CDbl(dr2(dc.ColumnName)) * (NW_CancleZarib) * CInt(dr2(2)))
                                            zarib = NW_CancleZarib
                                        ElseIf s1(3) = "1" Then
                                            sum += Int(CDbl(dr2(dc.ColumnName)) * (W_BeforCancleZarib) * CInt(dr2(2)))
                                            zarib = W_BeforCancleZarib
                                        ElseIf s1(5) = "1" Then
                                            sum += Int(CDbl(dr2(dc.ColumnName)) * (NW_BeforCancleZarib) * CInt(dr2(2)))
                                            zarib = NW_BeforCancleZarib
                                        ElseIf s1(6) = "1" Then
                                            sum += Int(CDbl(dr2(dc.ColumnName)) * (Holiday) * CInt(dr2(2)))
                                            zarib = Holiday
                                        ElseIf s1(7) = "1" Then
                                            sum += Int(CDbl(dr2(dc.ColumnName)) * (NightWork) * CInt(dr2(2)))
                                            zarib = NightWork
                                        Else
                                            sum += Int(CDbl(dr2(dc.ColumnName)) * CInt(dr2(2)))
                                            zarib = 1
                                        End If
                                        formula = formula + Chr(Asc("A") + colIndex - 1) + rowIndex.ToString() + "*" + zarib.ToString() + "*c" + rowIndex.ToString() + "+"
                                        excel.Cells(rowIndex, colIndex).Font.Name = "B Titr"
                                        'excel.Cells(rowIndex, colIndex).Font.Size = "14"
                                        excel.Cells(rowIndex, colIndex).Font.bold = True

                                    End If
                                    If colIndex = 1 Then
                                        excel.Cells(rowIndex, colIndex).NumberFormat = "0"
                                    End If
                                    excel.Cells(rowIndex, colIndex) = dr2(dc.ColumnName)
                                Next
                                If sum <> 0 Then
                                    excel.Cells(rowIndex, colIndex + 1).Font.Name = "B Titr"
                                    formula = formula + "0"
                                    RowCount = RowCount + 1
                                    'excel.Cells(rowIndex, colIndex + 1).Font.Size = "14"
                                    excel.Cells(rowIndex, colIndex + 1).Font.bold = True
                                    excel.Cells(rowIndex, colIndex + 1).NumberFormat = "###,###"
                                    '                                    excel.Cells(rowIndex, colIndex + 1) = sum
                                    'excel.Cells(rowIndex, colIndex + 1) = "=SUM(D" + rowIndex.ToString() + ":" + Chr(Asc("A") + colIndex - 1).ToString() + rowIndex.ToString() + ")*c" + rowIndex.ToString() + "*" + zarib.ToString()
                                    excel.Cells(rowIndex, colIndex + 1) = formula
                                    ' excel.Range(Chr(Asc("A") + colIndex + 1) + rowIndex.ToString() + ":" + Chr(Asc("A") + colIndex + 1) + rowIndex.ToString()).Formula = "=SUM(excel!$" + Chr(Asc("A") + ColFormula).ToString() + "$" + rowIndex.ToString() + ":" + Chr(Asc("A") + colIndex).ToString() + "$" + rowIndex.ToString() + ")"
                                    ' excel.Range(Chr(Asc("A") + colIndex + 1) + rowIndex.ToString() + ":" + Chr(Asc("A") + colIndex + 1) + "500").NumberFormat = "###,###"
                                Else
                                    If i = dt.Rows.Count - 1 Then
                                        For j As Integer = 1 To colIndex
                                            excel.Cells(rowIndex, j) = ""
                                        Next
                                    End If
                                    rowIndex = rowIndex - 1
                                End If
                            Next
                            excel.Cells(StartRowindex, colIndex + 1) = "جمع کل"
                            rowIndex = rowIndex + 1
                            excel.Cells(rowIndex, 1) = "جمع کل"
                            excel.Range("A" + rowIndex.ToString() + ":" + "c" + rowIndex.ToString()).Merge()
                            colIndex = 3
                            Dim allsum As Long = 0
                            For Each dc In dt.Columns
                                Dim Sumrow = rowIndex - RowCount
                                Dim formula As String = "="
                                Dim sum As Double = 0
                                If dc.ColumnName.Contains("__") Then
                                    colIndex = colIndex + 1
                                    Dim zarib As Double = 1
                                    Dim s As String = dc.ColumnName
                                    Dim s1 = New List(Of String)
                                    s1.AddRange(s.Split("__"))
                                    s1.RemoveAll(Function(str) String.IsNullOrEmpty(str))
                                    If s1(2) = "1" Then
                                        zarib = W_CancleZarib
                                    ElseIf s1(3) = "1" Then
                                        zarib = W_BeforCancleZarib
                                    ElseIf s1(4) = "1" Then
                                        zarib = NW_CancleZarib
                                    ElseIf s1(5) = "1" Then
                                        zarib = NW_BeforCancleZarib
                                    ElseIf s1(6) = "1" Then
                                        zarib = Holiday
                                    ElseIf s1(7) = "1" Then
                                        zarib = NightWork
                                    Else
                                        zarib = 1
                                    End If
                                    For Each dr In dt.Rows
                                        If Not TypeOf (dr(dc.ColumnName)) Is DBNull Then
                                            sum += Int(CDbl(dr(dc.ColumnName)) * CInt(dr(2)) * zarib)
                                        End If
                                    Next
                                    formula = "=SUMPRODUCT(" + Chr(Asc("A") + colIndex - 1) + Sumrow.ToString() + ":" + Chr(Asc("A") + colIndex - 1) + (rowIndex - 1).ToString() + ",C" + Sumrow.ToString() + ":C" + (rowIndex - 1).ToString() + ")*" + zarib.ToString()
                                    excel.Cells(rowIndex, colIndex).Font.Name = "B Titr"
                                    excel.Cells(rowIndex, colIndex).Font.bold = True
                                    excel.Cells(rowIndex, colIndex) = formula
                                    Groupsum += sum
                                    allsum += sum
                                End If
                            Next
                            excel.Cells(rowIndex, colIndex + 1).Font.Name = "B Titr"
                            excel.Cells(rowIndex, colIndex + 1).Font.bold = True
                            excel.Cells(rowIndex, colIndex + 1).NumberFormat = "###,###"
                            excel.Cells(rowIndex, colIndex + 1).formula = "=sum(D" + rowIndex.ToString() + ":" + Chr(Asc("A") + colIndex - 1) + rowIndex.ToString()
                            AllAllSum += allsum
                            excel.Range(Chr(Asc("A") + colIndex) + StartRowindex.ToString() + ":" + Chr(Asc("A") + colIndex) + (StartRowindex + 2).ToString()).Merge()
                            excel.Range("A" + StartRowindex.ToString() + ":" + Chr(Asc("A") + colIndex) + rowIndex.ToString()).Cells.Borders.LineStyle = XlLineStyle.xlContinuous
                            excel.Range("A" + rowIndex.ToString() + ":" + Chr(Asc("A") + colIndex + 1) + rowIndex.ToString()).NumberFormat = "###,###"
                            rowIndex = rowIndex + 2
                            StartRowindex = rowIndex
                            StartIdex = StartIdex + 9
                            EndIndex = EndIndex + 9
                            dt = BaseDataObject.DataAccess.GetDataTable("exec pm_con_Excelrp_SSPM " + cmb_Vahed.SelectedValue.ToString() + "," + cmb_Source.SelectedValue.ToString() + "," + srl_omoor.ToString() + "," + txt_year.Text + "," + cmb_Month.SelectedValue.ToString() + "," + cmb_Type.SelectedValue.ToString() + ",'-1','-1',-1," + Groupdr("srl").ToString() + ",-1," + cmb_Contract.SelectedValue.ToString() + "," + StartIdex.ToString() + "," + EndIndex.ToString())
                        End While
                        ResultDT.Rows.Add(Groupdr("name").ToString(), Groupsum.ToString(), "")
                    Catch
                        Continue For
                    End Try
                Next
            End If
            ResultDT.Rows.Add("جمع کل", AllAllSum.ToString(), "")
            StartRowindex = StartRowindex + 5
            Dim Lasttablestartindex = StartRowindex
            Dim colindex1 As Integer = 2


            excel.Cells(StartRowindex, 2) = "نام گروه"
            excel.Cells(StartRowindex, 3) = "مبلغ ارسالی"
            wSheet.Range("c" + (StartRowindex).ToString() + ":d" + (StartRowindex).ToString() + "").Merge()
            wSheet.Range("e" + (StartRowindex).ToString() + ":F" + (StartRowindex).ToString() + "").Merge()
            excel.Cells(StartRowindex, 5) = "مبلغ تائید شده"
            wSheet.Range("b" + (Lasttablestartindex).ToString() + ":F" + (Lasttablestartindex).ToString() + "").Interior.ColorIndex = 15
            For Each dr As DataRow In ResultDT.Rows
                If dr(1) <> "0" Then
                    StartRowindex = StartRowindex + 1
                    excel.Cells(StartRowindex, 2) = dr(0)
                    excel.Cells(StartRowindex, 3) = dr(1)
                    wSheet.Range("c" + (StartRowindex).ToString() + ":d" + (StartRowindex).ToString() + "").Merge()
                    wSheet.Range("E" + (StartRowindex).ToString() + ":F" + (StartRowindex).ToString() + "").Merge()
                    excel.Cells(StartRowindex, 3).NumberFormat = "###,###"
                    excel.Cells(StartRowindex, 5) = dr(2)
                End If
            Next
            excel.Range("B" + Lasttablestartindex.ToString() + ":" + "F" + StartRowindex.ToString()).Cells.Borders.LineStyle = XlLineStyle.xlContinuous
            excel.Range("B" + Lasttablestartindex.ToString() + ":" + "F" + StartRowindex.ToString()).Font.Size = 12

            wSheet.Columns.AutoFit()
            wSheet.PageSetup.Zoom = False
            wSheet.PageSetup.FitToPagesWide = 1
            wSheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4
            wSheet.PageSetup.FitToPagesTall = False

            'wSheet.Columns.AutoFit()
            wBook.SaveAs(strFile)
            wBook.Close()
            System.Threading.Thread.CurrentThread.CurrentCulture = Lan
            If t.IsAlive Then
                t.Abort()
            End If
        Catch ex As Exception
            If t.IsAlive Then
                t.Abort()
            End If
            MessageBox.Show("there was an issue Exporting to Excel" & ex.ToString)
        End Try

    End Sub


    Private Sub cmb_Contract_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Contract.SelectedIndexChanged
        setnumber()
        txt_Price.Text = "0"


    End Sub

    Private Sub txt_year_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_year.TextChanged
        txt_Price.Text = "0"

    End Sub

    Private Sub cmb_Month_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Month.SelectedIndexChanged
        txt_Price.Text = "0"

    End Sub

    Private Sub cmb_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Type.SelectedIndexChanged
        txt_Price.Text = "0"


    End Sub

    Private Sub cmb_Vahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Vahed.SelectedIndexChanged
        txt_Price.Text = "0"


    End Sub

    Private Sub cmb_Omor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Omor.SelectedIndexChanged
        txt_Price.Text = "0"


    End Sub

    Private Sub btn_ConfirmGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ConfirmGroup.Click
        If Srl_MonthReport < 1 Then
            MessageBoxFa.Show("برای مشخص کردن مبلغ تائید شده هر گروه باید در حالت ویرایش باشید")
            Return
        End If
        If dt Is Nothing Then
            MessageBoxFa.Show("مبلغ صورت وضعیت مشخص نیست")
            Return
        ElseIf dt.Rows.Count < 1 Then
            MessageBoxFa.Show("مبلغ صورت وضعیت مشخص نیست")
            Return
        Else
            For Each dr As DataRow In dt.Rows
                If CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(count(*),0) as t from pm_con_monthreportgroupconfirmprice where srl_monthreport=" + Srl_MonthReport.ToString() + " and srl_group = " + dr("Srl_group").ToString())) < 1 Then
                    BaseDataObject.DataAccess.ExecQuery("insert into pm_con_monthreportgroupconfirmprice values (" + dr("Srl_Group").ToString() + "," + Srl_MonthReport.ToString() + "," + dr(0).ToString() + ",0)")
                End If
            Next
            Dim f As New Frm_Con_MonthReportConfirmPrice(Srl_MonthReport, Me)
            f.ShowDialog()
        End If
    End Sub


    Private Sub btn_Summary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Summary.Click
        Dim f As New Frm_Wait
        Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)

        Try
            
            If Not checkContract() Then
                MessageBoxFa.Show("بازه انتخاب شده با تاریخ قرارداد تطابق ندارد")
                txt_year.Focus()
                Return
            Else
                If txt_year.Text = "" Then
                    MessageBoxFa.Show("لطفا سال را انتخاب نمائید")
                    txt_year.Focus()
                    Return
                End If
            End If
            Dim srl_source As Integer = -1
            If Not cmb_Source.SelectedValue Is Nothing Then
                srl_source = cmb_Source.SelectedValue
            End If
            Dim srl_omoor As Integer = -1
            If Not cmb_Omor.SelectedValue Is Nothing Then
                srl_omoor = cmb_Omor.SelectedValue
            End If
            Dim srl_type As Integer = -1
            If Not cmb_Type Is Nothing Then
                srl_type = cmb_Type.SelectedValue
            End If
            Dim FolderName = ""
            If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                FolderName = FolderBrowserDialog1.SelectedPath
            Else

                Return
            End If

            Dim rowIndex As Integer = 1
            Dim strFile As String = FolderName + "\SummaryReport(" + cmb_Vahed.Text + "-" + cmb_Month.Text + " ماه " + txt_year.Text + " ).xlsx"
            Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
            If IsXLBookOpen("SummaryReport(" + cmb_Vahed.Text + "-" + cmb_Month.Text + " ماه " + txt_year.Text + " ).xlsx") Then
                MessageBoxFa.Show("فایل زیر باز است. ابتدا آن را ببندید" + vbNewLine + strFile)
                Return
            End If
            If t.IsAlive Then
                t.Abort()
            End If
            t.Start()
            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()
            wSheet.DisplayRightToLeft = True
            wSheet.Rows.Font.Name = "B Titr"
            wSheet.Columns(2).WrapText = True
            wSheet.Columns(2).ColumnWidth = 30
            wSheet.Range("A1:X500").Font.Name = "B Titr"
            wSheet.Range("A1:X500").Font.Size = "9"
            'wSheet.Range("c5:c100").NumberFormat = "000,000"
            wSheet.Range("A1:X500").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            wSheet.Range("A1:X500").Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            Dim groups As System.Data.DataTable = BaseDataObject.DataAccess.GetDataTable("Pm_group", "Srl_pm_vahed=" + cmb_Vahed.SelectedValue.ToString() + " Order by name")
            If Not groups Is Nothing Then
                For Each Groupdr In groups.Rows
                    Try
                        Dim Groupsum As Long = 0
                        Dim dt As System.Data.DataTable = BaseDataObject.DataAccess.GetDataTable("exec [Pm_con_ExcelRP_Summary] " + cmb_Vahed.SelectedValue.ToString() + "," + srl_source.ToString() + "," + srl_omoor.ToString() + "," + txt_year.Text + "," + cmb_Month.SelectedValue.ToString() + "," + srl_type.ToString() + "," + Groupdr("srl").ToString() + "," + cmb_Contract.SelectedValue.ToString())

                        'Dim dt As DataTable = Me.Ds_Con.Pm_Con_MonthReport_Summary
                        Dim RowCount As Integer = 0
                        'StartRowindex = rowIndex
                        If dt Is Nothing Or dt.Rows.Count < 1 Then
                            Continue For
                        End If


                        Dim dc As System.Data.DataColumn
                        Dim dr As System.Data.DataRow
                        Dim colIndex As Integer = 0
                        excel.Cells(rowIndex, 1) = "صورت وضعیت گروه ( " + Groupdr("Name").ToString() + ") " + cmb_Month.Text + " ماه " + txt_year.Text
                        wSheet.Range("A" + (rowIndex).ToString() + ":E" + (rowIndex + 2).ToString() + "").Merge()
                        wSheet.Range("A" + (rowIndex).ToString() + ":E" + (rowIndex + 2).ToString() + "").Interior.ColorIndex = 15
                        wSheet.Range("A" + (rowIndex).ToString() + ":E" + (rowIndex + 2).ToString() + "").Font.Bold = True
                        wSheet.Range("A" + (rowIndex).ToString() + ":E" + (rowIndex + 2).ToString() + "").Font.Size = 12
                        rowIndex = rowIndex + 4

                        colIndex = colIndex + 1
                        excel.Cells(rowIndex - 1, colIndex) = "کد سرویس"
                        colIndex = colIndex + 1
                        excel.Cells(rowIndex - 1, colIndex) = "موضوع سرویس"
                        colIndex = colIndex + 1
                        excel.Cells(rowIndex - 1, colIndex) = "مبلغ"
                        colIndex = colIndex + 1
                        excel.Cells(rowIndex - 1, colIndex) = "تعداد"
                        colIndex = colIndex + 1
                        excel.Cells(rowIndex - 1, colIndex) = "مبلغ کل"
                        rowIndex = rowIndex - 1

                        For i As Integer = 0 To dt.Rows.Count - 1
                            Dim formula As String = ""
                            Dim zarib As Double = 1
                            Dim dr2 As DataRow = dt.Rows(i)
                            rowIndex = rowIndex + 1
                            colIndex = 0
                            Dim sum As Double = 0
                            Dim SumPrice As Integer = 0
                            formula = "="
                            colIndex = colIndex + 1
                            excel.Cells(rowIndex, colIndex) = dr2("code")
                            colIndex = colIndex + 1
                            excel.Cells(rowIndex, colIndex) = dr2("title")
                            colIndex = colIndex + 1
                            excel.Cells(rowIndex, colIndex) = dr2("base_Price")
                            colIndex = colIndex + 1
                            excel.Cells(rowIndex, colIndex) = dr2("amount")
                            colIndex = colIndex + 1
                            excel.Cells(rowIndex, colIndex) = dr2("price")
                            Groupsum = Groupsum + CInt(dr2("price"))
                        Next
                        rowIndex = rowIndex + 1
                        excel.Cells(rowIndex, 1) = "جمع کل"
                        excel.Range("A" + rowIndex.ToString() + ":" + "d" + rowIndex.ToString()).Merge()
                        excel.Cells(rowIndex, 5) = Groupsum
                        colIndex = 3
                        rowIndex = rowIndex + 1

                    Catch
                    End Try
                Next
                rowIndex = rowIndex - 1
                excel.Range("A1:E" + rowIndex.ToString()).Cells.Borders.LineStyle = XlLineStyle.xlContinuous
                wSheet.Range("c1:c" + rowIndex.ToString()).NumberFormat = "000,000"
                wSheet.Range("e1:e" + rowIndex.ToString()).NumberFormat = "000,000"

                excel.Range("A1:" + "E" + rowIndex.ToString()).Cells.Borders.LineStyle = XlLineStyle.xlContinuous

            End If
            wSheet.Columns.AutoFit()
            wSheet.PageSetup.Zoom = False
            wSheet.PageSetup.FitToPagesWide = 1
            wSheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4
            wSheet.PageSetup.FitToPagesTall = False

            'wSheet.Columns.AutoFit()
            wBook.SaveAs(strFile)
            wBook.Close()
            If t.IsAlive Then
                t.Abort()
            End If
        Catch ex As Exception
            If t.IsAlive Then
                t.Abort()
            End If
            MessageBox.Show("خطا در استخراج اطلاعات " & ex.ToString)
        End Try
        
    End Sub
End Class