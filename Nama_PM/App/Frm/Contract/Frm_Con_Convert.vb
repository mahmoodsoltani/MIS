Imports Microsoft.Office.Interop.Excel
Public Class Frm_Con_Convert
    Public ExlFile As Microsoft.Office.Interop.Excel.Application
    Private Srl_con As Integer
    Public Sub New(ByVal srl_con As Integer)
        InitializeComponent()
        Me.Srl_con = srl_con
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmb_sheet.Items.Clear()
        If OpenFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If OpenFile.FileName.Contains("~$") Then
                Return
            End If
            txt_unit.Text = OpenFile.FileName
            ExlFile = New Microsoft.Office.Interop.Excel.Application
            ExlFile.Visible = False
            ExlFile.Workbooks.Open(OpenFile.FileName)
            For i As Integer = 1 To ExlFile.Worksheets.Count
                cmb_sheet.Items.Add(CType(ExlFile.Worksheets(i), Microsoft.Office.Interop.Excel.Worksheet).Name)
            Next

        End If
    End Sub
    Private Sub ClearcmbItems()
        cmb_code.Items.Clear()
        cmb_title.Items.Clear()
        cmb_unit.Items.Clear()
        cmb_voltage.Items.Clear()
        cmb_amount.Items.Clear()
        cmb_price.Items.Clear()
        cmb_period.Items.Clear()
        cmb_IsStarred.Items.Clear()
    End Sub
    Private Sub AddcmbItems(ByVal txt As String)
        If Not txt Is Nothing Then
            cmb_code.Items.Add(txt)
            cmb_title.Items.Add(txt)
            cmb_unit.Items.Add(txt)
            cmb_voltage.Items.Add(txt)
            cmb_amount.Items.Add(txt)
            cmb_price.Items.Add(txt)
            cmb_period.Items.Add(txt)
            cmb_IsStarred.Items.Add(txt)
        End If
    End Sub

    Private Sub SetGridColumns(ByVal dgv As CS_Component.DataGridView, ByVal values As Object(,), ByVal max_row As Integer, ByVal max_col As Integer)
        DataGridView1.Columns.Clear()
        ClearcmbItems()
        Dim row As Integer = -1
        For row = 1 To max_row
            Dim row_values As Object() = New Object(max_col - 1) {}
            Try
                Dim i As Integer = CInt(values(row, 1))
                Exit For
            Catch ex As Exception
                Continue For
            End Try
        Next
        For col As Integer = 1 To max_col
            Dim title As String = CStr(values(row - 1, col))
            If Not title Is Nothing Then
                title = title.Replace(")", "_").Replace("(", "_")
                DataGridView1.Columns.Add(title, title)
                AddcmbItems(title)
            End If
        Next
    End Sub
    Private Sub SetcmbContents(ByVal cmb As VB_Component.ComboBox, ByVal values As Object(,), ByVal max_row As Integer, ByVal max_col As Integer)
        ' Copy the values into the grid.
        For col As Integer = 1 To max_col
            cmb.Items.Add(values(1, col))
        Next
    End Sub
    Private Sub SetGridContents(ByVal dgv As CS_Component.DataGridView, ByVal values As Object(,), ByVal max_row As Integer, ByVal max_col As Integer)
        ' Copy the values into the grid.

        For row As Integer = 2 To max_row
            Dim row_values As Object() = New Object(max_col - 1) {}
            Try
                Dim i As Integer = CInt(values(row, 1))
            Catch ex As Exception
                Continue For
            End Try
            For col As Integer = 1 To max_col
                row_values(col - 1) = values(row, col)
            Next

            dgv.Rows.Add(row_values)
        Next
    End Sub
    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Get the Excel application object.
       

    End Sub

    Private Sub cmb_sheet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_sheet.SelectedIndexChanged, cmb_vahed.SelectedIndexChanged, cmb_type.SelectedIndexChanged
        If cmb_sheet.SelectedIndex < 0 Then
            Return
        End If
        If cmb_sheet.SelectedItem = "" Then
            Return
        End If
        Dim sheet As Microsoft.Office.Interop.Excel.Worksheet = CType(ExlFile.Sheets(cmb_sheet.SelectedItem), Microsoft.Office.Interop.Excel.Worksheet)
        Dim used_range As Microsoft.Office.Interop.Excel.Range = sheet.UsedRange
        Dim max_row As Integer = used_range.Rows.Count
        Dim max_col As Integer = used_range.Columns.Count
        Dim values As Object(,) = CType(used_range.Value2, Object(,))
        SetGridColumns(DataGridView1, values, max_row, max_col)
        SetGridContents(DataGridView1, values, max_row, max_col)
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        Dim work As String

        Dim vahed As String = cmb_vahed.Text
        If MessageBoxFa.Show("شما می خواهید ایتم های مربوط به " + cmb_type.Text + " از واحد " + vahed + " را منتقل نمائید. آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then
            Return False
        End If
        If cmb_vahed.SelectedValue < 1 Then
            MessageBoxFa.Show("لطفا واحد را انتخاب نمائید")
            cmb_vahed.Focus()
            Return False
        End If
        If Cmb_Contract.SelectedValue < 1 Then
            MessageBoxFa.Show("لطفا قرارداد را انتخاب نمائید")
            Cmb_Contract.Focus()
            Return False
        End If
        If cmb_code.Text = "" Then
            MessageBoxFa.Show("ستون مشخص کننده کد را انتخاب نمائید")
            cmb_code.Focus()
            Return False
        End If
        If cmb_title.Text = "" Then
            MessageBoxFa.Show("ستون مشخص کننده عنوان را انتخاب نمائید")
            cmb_title.Focus()
            Return False
        End If
        If cmb_price.Text = "" Then
            MessageBoxFa.Show("ستون مشخص کننده هزینه را انتخاب نمائید")
            cmb_price.Focus()
            Return False
        End If
        Dim Inserted_Count As Integer = 0
        Dim Repeated_Item As Integer = 0
        Dim srl_unit As Integer = 0
        Dim srl_item As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            Try
                Dim i As Integer = CInt(row.Cells(0).Value.ToString())
                Dim j As Double = CDbl(row.Cells(cmb_price.Text).Value.ToString())
                'Dim k As Double = CDbl(row.Cells(cmb_code.Text).Value.ToString())
            Catch ex As Exception
                Exit For
            End Try
            srl_item = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(srl,0) from pm_con_item where code='" + row.Cells(cmb_code.Text).Value.ToString() + "' and title = '" + row.Cells(cmb_title.Text).Value.ToString() + "' and Srl_vahed=" + cmb_vahed.SelectedValue.ToString()))
            If srl_item < 1 Then
                If cmb_unit.Text <> "" AndAlso Not row.Cells(cmb_unit.Text).Value Is Nothing Then
                    If row.Cells(cmb_unit.Text).Value.ToString() <> "" Then
                        Dim unitname As String = row.Cells(cmb_unit.Text).Value.ToString().Replace("ي", "ی").Replace("ك", "ک")
                        srl_unit = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(srl,0) from pm_con_unit where name=N'" + unitname + "' "))
                        If srl_unit < 1 Then
                            Dim dr1 As DataRow = BaseDataObject.DataAccess.NewRow("pm_con_unit")
                            dr1("name") = unitname
                            srl_unit = BaseDataObject.DataAccess.InsertWithLastId(dr1, False)
                        End If
                    End If
                End If
                Dim dr2 As DataRow = BaseDataObject.DataAccess.NewRow("pm_con_item")
                dr2("code") = row.Cells(cmb_code.Text).Value.ToString()
                dr2("title") = row.Cells(cmb_title.Text).Value.ToString()
                dr2("srl_vahed") = cmb_vahed.SelectedValue
                dr2("srl_unit") = srl_unit
                dr2("sstype") = cmb_type.SelectedValue
                If cmb_voltage.Text <> "" Then
                    Try
                        dr2("Voltage") = row.Cells(cmb_voltage.Text).Value.ToString()
                    Catch ex As Exception
                    End Try
                End If
                If cmb_IsStarred.Text <> "" Then
                    Try
                        If (row.Cells(cmb_IsStarred.Text).Value.ToString() = "*") Then
                            dr2("Is_starred") = 1
                        Else
                            dr2("Is_starred") = 0
                        End If
                    Catch ex As Exception
                        dr2("Is_starred") = 0
                    End Try
                End If
                srl_item = BaseDataObject.DataAccess.InsertWithLastId(dr2, False)
            End If
            If CInt(BaseDataObject.DataAccess.ExecScalar("select count(*) from pm_con_contractitems where srl_contract =" + Cmb_Contract.SelectedValue.ToString() + " and srl_item=" + srl_item.ToString)) Then
                Repeated_Item += 1
                Continue For
            End If
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Con_ContractItems")
            dr("srl_contract") = Cmb_Contract.SelectedValue
            dr("srl_item") = srl_item
            If cmb_amount.Text = "" Then
                dr("amount") = 1
            Else
                dr("amount") = row.Cells(cmb_amount.Text).Value.ToString()
            End If

            dr("price") = CDbl(row.Cells(cmb_price.Text).Value.ToString())
            If cmb_period.Text <> "" Then
                dr("period") = row.Cells(cmb_period.Text).Value.ToString()
            End If
            If BaseDataObject.DataAccess.Insert(dr, False) Then
                Inserted_Count += 1
            End If
        Next
        Dim text As String = "تعداد " + Inserted_Count.ToString() + " ایتم به قرارداد اضاف گردید."
        If Repeated_Item > 1 Then
            text += "همچنین تعداد " + Repeated_Item.ToString() + " آیتم در قرارداد تکراری بود."
        End If
        MessageBoxFa.Show(text)
    End Function
    Private Sub cmb_change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cmb_sender As VB_Component.ComboBox = CType(sender, VB_Component.ComboBox)
        Dim array(50) As VB_Component.ComboBox
        Dim i As Integer = 0
        For Each obj As Object In DataGridView1.Controls
            If TypeOf (obj) Is VB_Component.ComboBox And CStr(obj IsNot cmb_sender) Then
                array(i) = CType(obj, VB_Component.ComboBox)
                i = i + 1
            End If
        Next
        If cmb_sender.Text <> "" Then
            For Each cmb As VB_Component.ComboBox In array
                If Not cmb Is Nothing Then
                    If cmb_sender.Text = cmb.Text Then
                        MessageBoxFa.Show("این ستون قبلا انتخاب شده است")
                        cmb_sender.SelectedIndex = -1
                        Return
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub cmb_title_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_voltage.SelectedIndexChanged, cmb_unit.SelectedIndexChanged, cmb_title.SelectedIndexChanged, cmb_price.SelectedIndexChanged, cmb_period.SelectedIndexChanged, cmb_code.SelectedIndexChanged, cmb_amount.SelectedIndexChanged, Cmb_Contract.SelectedIndexChanged, cmb_IsStarred.SelectedIndexChanged
        Dim cmb_sender As VB_Component.ComboBox = CType(sender, VB_Component.ComboBox)
        Dim array(50) As VB_Component.ComboBox
        Dim i As Integer = 0
        For Each obj As Object In gbx_GridViewList.Controls
            If TypeOf (obj) Is VB_Component.ComboBox And CStr(obj IsNot cmb_sender) Then
                array(i) = CType(obj, VB_Component.ComboBox)
                i = i + 1
            End If
        Next
        If cmb_sender.Text <> "" Then
            For Each cmb As VB_Component.ComboBox In array
                If Not cmb Is Nothing Then
                    If cmb_sender.Text = cmb.Text Then
                        MessageBoxFa.Show("این ستون قبلا انتخاب شده است")
                        cmb_sender.SelectedIndex = -1
                        Return
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Frm_Con_Convert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_StatusStatementType' table. You can move, or remove it, as needed.
        Me.Pm_Con_StatusStatementTypeTableAdapter.Fill(Me.Ds_Con.Pm_Con_StatusStatementType)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_StatusStatementVw' table. You can move, or remove it, as needed.
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        If Srl_con > 0 Then
            Cmb_Contract.SelectedValue = Srl_con
        End If
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Contract' table. You can move, or remove it, as needed.

    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

    End Sub
End Class