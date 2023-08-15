Public Class Frm_Con_StatusStatementVw
    Private Edit_CurrentIndex As Integer

    'Public Overrides Sub LoadDataGridView()
    '    Me.Pm_Con_StatusStatementVwTableAdapter.Fill(Me.Ds_Con.Pm_Con_StatusStatementVw)
    '    DataGridViewColoring()
    '    Me.Pm_LineTableAdapter.Fill(Ds_Pm.Pm_Line, -1)
    '    MyBase.LoadDataGridView()
    'End Sub



    Private Sub Frm_Post_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_StatusStatementVw' table. You can move, or remove it, as needed.
        txt_FromDate.Value = Setting.TarikheJary
        txt_ToDate.Value = Setting.TarikheJary
        chk_allday.Checked = False
        chk_Group.Checked = True
        chk_Post.Checked = True
        chk_vahed.Checked = True
        cmb_line.Visible = False
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, cmb_vahed.SelectedValue)
        UpdateDGV()
    End Sub

    Public Overrides Function Edit() As Boolean
        If DataGridView1.SelectedRows.Count > 0 Then
            If DataGridView1.SelectedRows(0).Cells(6).Value = "فرم کار" Then
                MessageBoxFa.Show("اطلاعات فرم کار از این مسیر قابل ویرایش نمی باشد")
                Return False
            Else
                Dim s As New Frm_Con_AddStatusStatement(CInt(DataGridView1.SelectedRows(0).Cells(9).Value))
                s.ShowDialog()
                LoadDataGridView()
            End If
        End If
        'Return MyBase.Edit()
    End Function
    Private Sub txt_SathVoltaj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PmLineBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        Dim srl_WorkForm As Integer = -1
        Dim srl_stausStatement As Integer = -1
        If e.RowIndex = -1 Then
            Return
        End If
        If senderGrid.Rows(e.RowIndex).Cells(6).Value = "فرم کار" Then
            srl_WorkForm = DirectCast(senderGrid.Rows(e.RowIndex).Cells(9).Value, Integer)
        Else
            srl_stausStatement = senderGrid.Rows(e.RowIndex).Cells(9).Value
        End If
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = 7 Then
                Dim frm As New Frm_Con_StatusStatement(srl_WorkForm, srl_stausStatement)
                frm.ShowDialog()
            Else
                Dim frm As New Frm_Con_StatusStatementMazad(srl_WorkForm, srl_stausStatement)
                frm.ShowDialog()
            End If
            Dim DGVselectedRow As Integer
            If DataGridView1.SelectedRows.Count > 0 Then
                DGVselectedRow = DataGridView1.SelectedRows(0).Index
            End If
            UpdateDGV()
            DataGridViewColoring()
            DataGridView1.Rows(DGVselectedRow).Selected = True
            DataGridView1.FirstDisplayedScrollingRowIndex = DGVselectedRow

        End If
    End Sub


    Private Sub DataGridView1_ColumnHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseDoubleClick
        Dim i As Integer
        i = 10
    End Sub

    Private Sub DataGridViewColoring()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(15).Value.ToString() = "True" Then
                Dim Btn As DataGridViewButtonCell = DirectCast(DataGridView1.Rows(i).Cells(7), DataGridViewButtonCell)
                Btn.Style.BackColor = Color.YellowGreen
                Btn.FlatStyle = FlatStyle.Flat

            End If
            If DataGridView1.Rows(i).Cells(14).Value.ToString() = "True" Then
                Dim Btn As DataGridViewButtonCell = DirectCast(DataGridView1.Rows(i).Cells(7), DataGridViewButtonCell)
                Btn.Style.BackColor = Color.Yellow
                Btn.FlatStyle = FlatStyle.Flat

            End If
            If DataGridView1.Rows(i).Cells(13).Value.ToString() = "True" Then
                Dim Btn As DataGridViewButtonCell = DirectCast(DataGridView1.Rows(i).Cells(7), DataGridViewButtonCell)
                Btn.Style.BackColor = Color.Red
                Btn.FlatStyle = FlatStyle.Flat

            End If
        Next
    End Sub


    Private Sub DataGridView1_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Sorted
        DataGridViewColoring()

    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        Dim f As New Frm_Con_AddStatusStatement()
        f.ShowDialog()
        LoadDataGridView()
    End Function

    Public Overrides Function Delete() As Boolean
        Try
            If MessageBoxFa.Show("آیا از حذف صورت وضعیت مطمئنید؟", "هشدار", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                If DataGridView1.SelectedRows(0).Cells(6).Value = "فرم کار" Then
                    BaseDataObject.DataAccess.Delete("Pm_con_statusstatementitem", "srl_workform_master=" + DataGridView1.SelectedRows(0).Cells(8).Value.ToString())
                    MessageBoxFa.Show("حذف با موفقیت انجام شد")
                Else
                    BaseDataObject.DataAccess.BeginTransaction()
                    BaseDataObject.DataAccess.Delete("pm_con_statusstatement", DirectCast(DataGridView1.SelectedRows(0).Cells(9).Value, Integer))
                    BaseDataObject.DataAccess.Delete("Pm_con_statusstatementitem", "srl_statusstatement=" + DataGridView1.SelectedRows(0).Cells(9).Value.ToString())
                    BaseDataObject.DataAccess.Delete("Pm_con_statusstatementdetail", "srl_statusstatement=" + DataGridView1.SelectedRows(0).Cells(9).Value.ToString())
                    If BaseDataObject.DataAccess.Commit Then
                        MessageBoxFa.Show("حذف با موفقیت انجام شد")
                    Else
                        BaseDataObject.DataAccess.RollBack()
                        MessageBoxFa.Show("خطا در حذف اطلاعات")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBoxFa.Show("خطا در حذف اطلاعات")
            BaseDataObject.DataAccess.RollBack()
        End Try
        Return True
    End Function

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If e.ColumnIndex = 7 Then
            cell.ToolTipText = "PM"
        ElseIf e.ColumnIndex = 8 Then
            cell.ToolTipText = "کار مازاد"
        End If
    End Sub

    Private Sub txt_FromDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FromDate.TextChanged, txt_ToDate.TextChanged, txt_ToDate.ValueChanged, txt_FromDate.ValueChanged
        'UpdateDGV()
    End Sub
    Private Sub UpdateDGV()
       


        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If
        Dim Srl_Post As Integer = -1
        If Not chk_Post.Checked And chk_Post.Text = "پست" Then
            Srl_Post = cmb_Post.SelectedValue
        End If
        Dim srl_Group As Integer = -1
        If Not chk_Group.Checked Then
            srl_Group = cmb_Group.SelectedValue
        End If

        Dim Srl_Vahed As Integer = -1
        If Not chk_vahed.Checked Then
            Srl_Vahed = cmb_vahed.SelectedValue
        End If
        Dim Srl_Line As Integer = -1
        If Not chk_Post.Checked And chk_Post.Text = "خط" Then
            Srl_Line = cmb_line.SelectedValue
        End If
        Me.Pm_Con_StatusStatementVwTableAdapter.Fill(Me.Ds_Con.Pm_Con_StatusStatementVw, Srl_Vahed, srl_Group, Srl_Line, Srl_Post, FromDate, ToDate)
        DataGridViewColoring()
       
       
    End Sub


    Private Sub cmb_line_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_line.SelectedIndexChanged
        'UpdateDGV()
    End Sub

    Private Sub cmb_vahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_vahed.SelectedIndexChanged
        If Not cmb_vahed.SelectedValue Is Nothing Then
            Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, cmb_vahed.SelectedValue.ToString)
            If cmb_vahed.SelectedValue = 76 Or cmb_vahed.SelectedValue = 104 Or cmb_vahed.SelectedValue = 105 Then
                chk_Post.Text = "خط"
                cmb_Post.Visible = False
                cmb_line.Visible = True
                Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
            Else
                chk_Post.Text = "پست"
                cmb_Post.Visible = True
                cmb_line.Visible = False
            End If

        End If
        ' UpdateDGV()
    End Sub

    Private Sub cmb_Group_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Group.SelectedIndexChanged
        ' UpdateDGV()
    End Sub

    Private Sub cmb_Post_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Post.SelectedIndexChanged
        'UpdateDGV()
    End Sub

    Private Sub chk_allday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allday.CheckedChanged
        txt_FromDate.Enabled = Not chk_allday.Checked
        txt_ToDate.Enabled = Not chk_allday.Checked
        'UpdateDGV()
    End Sub

    Private Sub chk_vahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_vahed.CheckedChanged
        cmb_vahed.Enabled = Not chk_vahed.Checked
        ' UpdateDGV()
    End Sub

    Private Sub chk_Post_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Post.CheckedChanged
        cmb_Post.Enabled = Not chk_Post.Checked
        cmb_line.Enabled = Not chk_Post.Checked

        ' UpdateDGV()
    End Sub

    Private Sub chk_Group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Group.CheckedChanged
        cmb_Group.Enabled = Not chk_Group.Checked

    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        UpdateDGV()
    End Sub
End Class