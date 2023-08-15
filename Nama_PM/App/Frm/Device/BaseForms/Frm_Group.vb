Public Class Frm_Group

    Public Overrides Sub LoadDataGridView()
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If cmb_Vahed.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا واحد مربوطه را مشخص کنید")
            Return False
        End If
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_Group_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub
End Class