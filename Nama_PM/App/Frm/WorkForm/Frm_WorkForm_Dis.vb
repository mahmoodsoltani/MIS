Public Class Frm_WorkForm_Dis

    Public Overrides Sub LoadDataGridView()
        Me.Pm_WorkDisTableAdapter.Fill(Me.Ds_Pm.Pm_WorkDis)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        MyBase.Save(DoClearForm)
        MyBase.NewRecord()
    End Function

    Public Overrides Function Edit() As Boolean
        Return MyBase.Edit()
    End Function
    Private Sub Frm_WorkDis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub

End Class