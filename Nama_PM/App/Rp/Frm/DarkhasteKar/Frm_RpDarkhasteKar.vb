Public Class Frm_RpDarkhasteKar

    
    Private Sub Frm_RpDarkhasteKar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)

    End Sub

    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        If cmb_Post.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا پست را مشخص نمائید")
            cmb_Post.Focus()
            Return
        End If

        Dim s As New Frm_DeviceSelect(cmb_Post.SelectedValue)
        s.ShowDialog()

        If Not s.SelectedDevice Is Nothing Then
            txt_Tajhiz.Value = s.SelectedDevice.Text
            txt_SrlTajhiz.Text = s.SelectedDevice.Srl
        End If

        'txt_Sharh.Focus()

        'Dim TreeV As New Frm_TajhizSelect

        'If TreeV.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    If Not TreeV.selectedSubject Is Nothing Then
        '        txt_Tajhiz.Value = TreeV.selectedSubject.Text
        '        srl_Device.Text = TreeV.selectedSubject.Srl
        '    End If
        'End If
    End Sub

    Private Sub chk_AllRegisterDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllRegisterDate.CheckedChanged
        txt_RegistreFromDate.Enabled = Not chk_AllRegisterDate.Checked
        txt_RegisterToDate.Enabled = Not chk_AllRegisterDate.Checked
    End Sub

    Private Sub chk_AllDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllDate.CheckedChanged
        txt_FromDate.Enabled = Not chk_AllDate.Checked
        txt_ToDate.Enabled = Not chk_AllDate.Checked
    End Sub

    Private Sub chk_AllNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllNo.CheckedChanged
        txt_No.Enabled = Not chk_AllNo.Checked
    End Sub

    Private Sub chk_AllVahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllVahed.CheckedChanged
        cmb_Vahed.Enabled = Not chk_AllVahed.Checked
        chk_AllGroup_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub chk_AllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllGroup.CheckedChanged
        cmb_Group.Enabled = Not chk_AllGroup.Checked
        If (Not chk_AllVahed.Checked And Not chk_AllGroup.Checked) Then
            Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, cmb_Vahed.SelectedValue)
        Else
            Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)
        End If
    End Sub

    Private Sub chk_AllPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllPost.CheckedChanged
        cmb_Post.Enabled = Not chk_AllPost.Checked

    End Sub

    Private Sub chk_AllSarparast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllSarparast.CheckedChanged
        cmb_Sarparast.Enabled = Not chk_AllSarparast.Checked

    End Sub

    Private Sub Chk_AllTajhiz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllTajhiz.CheckedChanged
        btn_SelectTajhiz.Enabled = Not Chk_AllTajhiz.Checked
    End Sub
End Class