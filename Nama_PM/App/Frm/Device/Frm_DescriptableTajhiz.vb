Public Class Frm_DescriptableTajhiz

    Public Overrides Sub LoadDataGridView()
        Me.Pm_DescriptableTajhizTableAdapter.Fill(Me.Ds_Pm.Pm_DescriptableTajhiz)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_Vahed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_DescriptableTajhizTableAdapter.Fill(Me.Ds_Pm.Pm_DescriptableTajhiz)
    End Sub
End Class