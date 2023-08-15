Public Class Frm_JobTitle
    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_JobTitleTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_JobTitle)

    End Sub
    Private Sub Frm_Pm_Company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_JobTitle' table. You can move, or remove it, as needed.
        Me.Pm_Edu_JobTitleTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_JobTitle)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim frm As New Frm_Edu_JobDore(DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer))
            frm.ShowDialog()
        End If
    End Sub
End Class