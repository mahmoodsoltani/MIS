Public Class Frm_PostToGroup

    Public Overrides Sub LoadDataGridView()
        Me.Pm_PostToGroupTableAdapter.Fill(Me.Ds_Pm.Pm_PostToGroup, cmb_Group.SelectedValue)
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        For Each dr As DataRow In DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.Rows
            If dr("Srl_Pm_Post") = cmb_Post.SelectedValue Then
                MessageBoxFa.Show("این پست قبلا انتخاب شده است", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmb_Post.Focus()
                Return False
            End If
        Next
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(False)
    End Function

    Private Sub Frm_PostModel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)
        LoadDataGridView()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Group.SelectedIndexChanged
        Me.Pm_PostToGroupTableAdapter.Fill(Me.Ds_Pm.Pm_PostToGroup, cmb_Group.SelectedValue)
    End Sub
End Class