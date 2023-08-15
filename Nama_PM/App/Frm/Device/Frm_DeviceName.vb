Public Class Frm_DeviceName

    Public Overrides Sub LoadDataGridView()
        Me.Pm_TajhizNameTableAdapter.Fill(Me.Ds_Pm.Pm_TajhizName)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_PostTip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_TajhizNameTableAdapter.Fill(Me.Ds_Pm.Pm_TajhizName)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub
End Class