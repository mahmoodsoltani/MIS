Public Class Frm_Con_Contract

    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Contract' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Unit' table. You can move, or remove it, as needed.

    End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)

    End Sub

    Private Sub gbx_Controls_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Controls.Enter

    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        MyBase.DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        MyBase.DataObject.DataRow("SubmitDate") = Setting.Now
        Return MyBase.Save(DoClearForm)
    End Function
 
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = 7 Then
                Dim frm As New Frm_Con_Convert(DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer))
                frm.ShowDialog()
            Else
                Dim frm As New Frm_Con_ContactItemsVw(DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer))
                frm.ShowDialog()
            End If
            
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If e.ColumnIndex = 6 Then
            cell.ToolTipText = "مشاهده آیتم ها"
        ElseIf e.ColumnIndex = 7 Then
            cell.ToolTipText = "انتقال از اکسل"
        End If
    End Sub
End Class