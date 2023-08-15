Public Class Pm_WorkSharh_WorkForm

    Public Overrides Sub LoadDataGridView()
        Me.Pm_WorkSharh_WorkFormTableAdapter.Fill(Me.Ds_Pm.Pm_WorkSharh_WorkForm)

        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_WorkDis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_WorkSharh_WorkForm' table. You can move, or remove it, as needed.
        Me.Pm_WorkSharh_WorkFormTableAdapter.Fill(Me.Ds_Pm.Pm_WorkSharh_WorkForm)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub
End Class