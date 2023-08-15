Public Class Frm_SubRecomendationSubject

    Public Overrides Sub LoadDataGridView()

        Me.Pm_RecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_RecomendationSubject)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        MyBase.LoadDataGridView()
        If chk_All.Checked Then
            Me.Pm_SubRecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_SubRecomendationSubject, -1)
        Else
            Me.Pm_SubRecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_SubRecomendationSubject, cmb_RecomSubject.SelectedValue)
        End If
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_PostTip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chk_All.Checked = True
        Me.Pm_RecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_RecomendationSubject)
        LoadDataGridView()
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_All.CheckedChanged
        LoadDataGridView()
    End Sub
End Class