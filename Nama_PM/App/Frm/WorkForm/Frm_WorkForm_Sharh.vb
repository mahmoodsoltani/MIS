Public Class Frm_WorkForm_Sharh

    Public Overrides Sub LoadDataGridView()
        Me.Pm_WorkSharhTableAdapter.Fill(Me.Ds_Pm.Pm_WorkSharh)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_WorkDis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_WorkSharhTableAdapter.Fill(Me.Ds_Pm.Pm_WorkSharh)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub
End Class