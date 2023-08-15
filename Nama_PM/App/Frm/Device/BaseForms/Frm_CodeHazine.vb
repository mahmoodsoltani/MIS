Public Class Frm_CodeHazine

    Public Overrides Sub LoadDataGridView()
        Me.Pm_HazineCodeTableAdapter.Fill(Me.Ds_Pm.Pm_HazineCode, -1)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_Vahed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chk_IsActive.Checked = True
    End Sub
End Class