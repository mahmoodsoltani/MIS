Public Class Frm_Con_AllStatusStatementVw

    Private Sub Frm_WorkFormVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_AllStatusStatement' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Ds_Pm.WorkForm_Master' table. You can move, or remove it, as needed.

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If senderGrid.Rows(e.RowIndex).Cells(7).Value = "موردي" Then
                Dim frm As New Frm_Con_StatusStatement(-1, DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer))
                frm.ShowDialog()
            Else
                Dim frm As New Frm_Con_StatusStatement(DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer), -1)
                frm.ShowDialog()
            End If
        End If
    End Sub
End Class