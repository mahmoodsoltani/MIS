Public Class Frm_RpRecomendation
    Dim Srl_Device As Integer
    Private Sub Frm_RpEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Srl_Device = -1
        chk_AllDate.Checked = True
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Dim row As DataRow = Ds_Pm.Pm_Post.NewRow()
        row("نام پست") = "همه پستها"
        row("srl") = -1
        Ds_Pm.Pm_Post.Rows.InsertAt(row, 0)
        cmb_Post.SelectedIndex = 0
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        row = Ds_Pm.Pm_Vahed.NewRow
        row("نام واحد") = "همه واحدها"
        row("srl") = -1
        Ds_Pm.Pm_Vahed.Rows.InsertAt(row, 0)
        cmb_Vahde.SelectedIndex = 0
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Pm_Ashkhas' table. You can move, or remove it, as needed.
        Me.Pm_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Ashkhas)
        row = Ds_Ashkhas.Pm_Ashkhas.NewRow
        row("نام و نام خانوادگی") = "همه افراد"
        row("srl") = -1
        Ds_Ashkhas.Pm_Ashkhas.Rows.InsertAt(row, 0)
        cmb_Ashkhas.SelectedIndex = 0

        'TODO: This line of code loads data into the 'Ds_Pm.Pm_RecomendationSubject' table. You can move, or remove it, as needed.
        Me.Pm_RecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_RecomendationSubject)
        row = Ds_Pm.Pm_RecomendationSubject.NewRow
        row("نام") = "همه موضوع ها"
        row("srl") = -1
        Ds_Pm.Pm_RecomendationSubject.Rows.InsertAt(row, 0)
        cmb_RecomSubject.SelectedIndex = 0

    End Sub


    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        Dim srl_Post As Integer = cmb_Post.SelectedValue

        Dim srl_shakhs As Integer = cmb_Ashkhas.SelectedValue
        Dim srl_vahed As Integer = cmb_Vahde.SelectedValue
        Dim srl_recom As Integer = cmb_RecomSubject.SelectedValue
        Dim srl_subRecom As Integer = IIf(cmb_SubRecom.SelectedValue Is Nothing, -1, cmb_SubRecom.SelectedValue)
        Dim fromdate As String = IIf(chk_AllDate.Checked, "", txt_FromDate.Value)
        Dim todate As String = IIf(chk_AllDate.Checked, "", txt_ToDate.Value)
        Dim Recom As String = txt_Desc.Value

        Dim rp As New Rp_PostRecom
        Pm_Post_PishnahdTableAdapter.Fill(Ds_Pm.Pm_Post_Pishnahd, srl_Post, Srl_Device, fromdate, todate, srl_shakhs, srl_subRecom, srl_recom, Recom, srl_vahed)
        Dim dt As DataTable = Ds_Pm.Pm_Post_Pishnahd
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()

    End Sub

    Private Sub cmb_RecomSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_RecomSubject.SelectedIndexChanged
        If Not cmb_RecomSubject.SelectedValue Is Nothing Then
            If cmb_RecomSubject.SelectedValue <> -1 Then
                Me.Pm_SubRecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_SubRecomendationSubject, cmb_RecomSubject.SelectedValue)
                Dim row As DataRow = Ds_Pm.Pm_SubRecomendationSubject.NewRow
                row("نام") = "همه زیر موضوع ها"
                row("srl") = -1
                Ds_Pm.Pm_SubRecomendationSubject.Rows.InsertAt(row, 0)
                cmb_SubRecom.SelectedIndex = 0
            Else
                Ds_Pm.Pm_SubRecomendationSubject.Rows.Clear()
            End If
        Else
            Ds_Pm.Pm_SubRecomendationSubject.Rows.Clear()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Post.SelectedIndexChanged
        txt_TajhizNameForSave.Value = ""
        Srl_Device = -1
    End Sub


    Private Sub chk_AllDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllDate.CheckedChanged
        txt_FromDate.Enabled = Not chk_AllDate.Checked
        txt_ToDate.Enabled = Not chk_AllDate.Checked
    End Sub

    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        If cmb_Post.SelectedValue Is Nothing Or cmb_Post.SelectedValue = -1 Then
            MessageBoxFa.Show("لطفا پست را مشخص نمائید")
            cmb_Post.Focus()
            Return
        End If
        Dim s As New Frm_DeviceSelect(cmb_Post.SelectedValue)
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_TajhizNameForSave.Value = s.SelectedDevice.Text
            Srl_Device = s.SelectedDevice.Srl
        End If
    End Sub
End Class