Imports Microsoft.Office.Interop.Excel
Public Class Frm_Con_MonthReportVw

    Public Sub New()
        InitializeComponent()
        'UpdateDGV()
    End Sub


    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_Con_MonthReport(-1)
        Dim rowindex As Integer = DataGridView1.SelectedRows(0).Index
        s.ShowDialog()
        UpdateDGV()
        DataGridView1.Rows(rowindex).Selected = True
        DataGridView1.FirstDisplayedScrollingRowIndex = rowindex
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim rowindex As Integer = DataGridView1.SelectedRows(0).Index
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim index As Integer = DataGridView1.SelectedRows(0).Index
        Dim s As New Frm_Con_MonthReport(srl)
        s.ShowDialog()
        UpdateDGV()
        DataGridView1.Rows(index).Selected = True
        DataGridView1.FirstDisplayedScrollingRowIndex = index
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Dim rowindex As Integer = DataGridView1.SelectedRows(0).Index
        If rowindex <> 0 Then
            rowindex = rowindex - 1
        End If
        If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
            If srl = -1 Then
                Return
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then
                If BaseDataObject.DataAccess.ExecQuery("Update pm_con_statusstatementitem set Srl_MonthReport=null where Srl_MonthReport= " + srl.ToString()) Then

                    If BaseDataObject.DataAccess.Delete("pm_con_monthReport", srl) Then
                        MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                        BaseDataObject.DataAccess.Commit()
                        UpdateDGV()
                        DataGridView1.Rows(rowindex).Selected = True
                        Return
                    End If
                End If
            End If
            BaseDataObject.DataAccess.RollBack()
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            Return
        End If
    End Sub

    Private Sub Frm_WorkFormVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_PostType' table. You can move, or remove it, as needed.
        Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Source' table. You can move, or remove it, as needed.
        Me.Pm_Con_SourceTableAdapter.Fill(Me.Ds_Con.Pm_Con_Source)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        txt_FromDate.Value = Setting.TarikheJary
        txt_ToDate.Value = Setting.TarikheJary
        chk_allday.Checked = True
        chk_Month.Checked = False
        chk_year.Checked = False
        chk_vahed.Checked = True
        chk_contract.Checked = True
        Me.Pm_MonthTableAdapter.Fill(Me.Ds_Con.Pm_Month)
        txt_year.Text = FarsiDateFun.Now.Substring(0, 4)
        txt_year1.Text = FarsiDateFun.Now.Substring(0, 4)
        Dim m As Integer = CInt(FarsiDateFun.Now.Substring(5, 2))
        If m = 0 Then
            txt_year.Text = (CInt(txt_year.Text) - 1).ToString()
            m = 12
        End If
        cmb_Month.SelectedValue = m
        cmb_month1.SelectedValue = m
        btn_Update_Click(Nothing, Nothing)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub CreatedExcelFile(ByVal path As String)
        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()
        wSheet.DisplayRightToLeft = True
        wSheet.Rows.Font.Name = "B Nazanin"
        wSheet.Range("A1:X500").Font.Name = "B Nazanin"
        wSheet.Range("A1:X500").Font.Size = "14"
        Dim rowindex As Integer = 1
        Dim colindex As Integer = 1
        For Each dc In Me.Ds_Con.Pm_Con_ExcelMonthReport.Columns
            excel.Cells(rowindex, colindex) = dc.columnname
            excel.Cells(rowindex, colindex).Interior.ColorIndex = 15
            colindex = colindex + 1
        Next

        For Each dr As DataRow In Me.Ds_Con.Pm_Con_ExcelMonthReport.Rows
            colindex = 1
            rowindex = rowindex + 1
            For Each dc In Me.Ds_Con.Pm_Con_ExcelMonthReport.Columns
                excel.Cells(rowindex, colindex) = dr(dc.columnname)
                colindex = colindex + 1
            Next
        Next
        excel.Range("A1:" + Chr(Asc("A") + colindex) + rowindex.ToString()).NumberFormat = "###,###"
        excel.Range("A1:" + Chr(Asc("A") + colindex - 2) + rowindex.ToString()).Cells.Borders.LineStyle = XlLineStyle.xlContinuous
        wSheet.Columns.AutoFit()
        wSheet.Columns.AutoFit()
        wBook.SaveAs(path)
        wBook.Close()
    End Sub

    Private Sub btn_MonthRp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MonthRp.Click
        If cmb_Month.SelectedValue > 0 And txt_year.Text <> "" Then
            Me.Pm_Con_ExcelMonthReportTableAdapter.Fill(Me.Ds_Con.Pm_Con_ExcelMonthReport, cmb_Month.SelectedValue, CInt(txt_year.Text))
            If Not Me.Ds_Con.Pm_Con_ExcelMonthReport Is Nothing Then
                If Me.Ds_Con.Pm_Con_ExcelMonthReport.Rows.Count > 0 Then
                    If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        CreatedExcelFile(FolderBrowserDialog1.SelectedPath + "\" + cmb_Month.Text + "_" + txt_year.Text + ".xlsx")
                    Else
                        Return
                    End If
                Else
                    MessageBoxFa.Show("اطلاعات برای این بازه زمانی وجود ندارد", "هشدار", MessageBoxButtons.OK)
                    Return
                End If
            Else
                MessageBoxFa.Show("اطلاعات برای این بازه زمانی وجود ندارد", "هشدار", MessageBoxButtons.OK)
                Return
            End If
        Else
            MessageBoxFa.Show("لطفا سال و تاریخ را مشخص نمائید", "هشدار", MessageBoxButtons.OK)
            Return
        End If
    End Sub


    Private Sub cmb_vahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_vahed.SelectedIndexChanged, cmb_contract.SelectedIndexChanged
        'UpdateDGV()
    End Sub

    Private Sub chk_allday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allday.CheckedChanged
        txt_FromDate.Enabled = Not chk_allday.Checked
        txt_ToDate.Enabled = Not chk_allday.Checked
        'UpdateDGV()
    End Sub
    Private Sub UpdateDGV()
        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If
        Dim Srl_contract As Integer = -1
        If Not chk_contract.Checked Then
            Srl_contract = cmb_contract.SelectedValue
        End If
        Dim srl_month As Integer = -1
        If Not chk_Month.Checked Then
            srl_month = cmb_month1.SelectedValue
        End If

        Dim Srl_Vahed As Integer = -1
        If Not chk_vahed.Checked Then
            Srl_Vahed = cmb_vahed.SelectedValue
        End If
        Dim year As Integer = -1
        If Not chk_year.Checked Then
            year = CInt(IIf(txt_year1.Text = "", -1, txt_year1.Text))
        End If
        Dim type As Integer = -1
        If rb_Mazad.Checked Then
            type = 2
        ElseIf rb_Pm.Checked Then
            type = 1
        End If
        Dim srl_source As Integer = -1
        If Not chk_source.Checked Then
            srl_source = cmb_source.SelectedValue
        End If
        Dim srl_omoor As Integer = -1
        If Not chk_Omoor.Checked Then
            srl_omoor = cmb_omoor.SelectedValue
        End If
        Me.Pm_MonthReportTableAdapter.Fill(Me.Ds_Con.Pm_MonthReport, srl_month, year, Srl_contract, Srl_Vahed, FromDate, ToDate, type, srl_source, srl_omoor)
        
    End Sub

    Private Sub chk_vahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_vahed.CheckedChanged
        cmb_vahed.Enabled = Not chk_vahed.Checked
        'UpdateDGV()
    End Sub

    Private Sub chk_contract_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_contract.CheckedChanged
        cmb_contract.Enabled = Not chk_contract.Checked
        ' UpdateDGV()
    End Sub

    Private Sub chk_Month_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Month.CheckedChanged
        cmb_month1.Enabled = Not chk_Month.Checked
        ' UpdateDGV()
    End Sub

    Private Sub chk_year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_year.CheckedChanged
        txt_year1.Enabled = Not chk_year.Checked
        ' UpdateDGV()
    End Sub

    Private Sub chk_source_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_source.CheckedChanged
        cmb_source.Enabled = Not chk_source.Checked
        'UpdateDGV()
    End Sub

    Private Sub chk_Omoor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Omoor.CheckedChanged, cmb_month1.SelectedIndexChanged
        cmb_omoor.Enabled = Not chk_Omoor.Checked
        ' UpdateDGV()
    End Sub


    Private Sub cmb_source_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_source.SelectedIndexChanged
        'UpdateDGV()
    End Sub

    Private Sub cmb_omoor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_omoor.SelectedIndexChanged
        ' UpdateDGV()
    End Sub


    Private Sub rb_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_all.CheckedChanged, rb_Pm.CheckedChanged, rb_Mazad.CheckedChanged
        'UpdateDGV()
    End Sub

    Private Sub txt_year1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_year1.TextChanged
        'UpdateDGV()
    End Sub

    Private Sub txt_FromDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FromDate.TextChanged
        'UpdateDGV()
    End Sub

    Private Sub txt_ToDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ToDate.TextChanged
        ' UpdateDGV()
    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        UpdateDGV()
        Try

            For i As Integer = 0 To DataGridView1.RowCount - 1
                Dim j As Long = Convert.ToInt64(DataGridView1.Rows(i).Cells(10).Value) - Convert.ToInt64(DataGridView1.Rows(i).Cells(11).Value)
                If j <> 0 Then
                    DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.Red
                Else
                    DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.Green

                End If
            Next
            'DataGridView1.Columns(8).DefaultCellStyle.Format = "N0"
        Catch ex As Exception

        End Try
    End Sub
End Class