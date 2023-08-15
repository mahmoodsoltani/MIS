Public Class Frm_Post_Tip

    Public Overrides Sub LoadDataGridView()
        Me.Pm_PostTipTableAdapter.Fill(Me.Ds_Pm.Pm_PostTip)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        Me.Pm_PostTipTableAdapter.Fill(Me.Ds_Pm.Pm_PostTip)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_PostTip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

    End Sub
End Class