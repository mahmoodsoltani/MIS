Public Class Frm_Rp_StatusStatement

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim srl_contract As Integer = cmb_Contract.SelectedValue
        Dim srl_vahed As Integer = Cmb_Vahed.SelectedValue

        Dim srl_post As Integer = -1
        If PostOrKhat.Checked Then
            If Cmb_Vahed.SelectedValue = 76 Or Cmb_Vahed.SelectedValue = 104 Or Cmb_Vahed.SelectedValue = 105 Then
                srl_post = cmb_Line.SelectedValue
            Else
                srl_post = Cmb_Post.SelectedValue
            End If
        End If
        Dim star As Integer = -1
        If chkbx_Star.Checked Then
            star = 1
        End If
        Dim sstype As Integer = -1
        If rb_pm.Checked Then
            sstype = 1
        ElseIf rb_Mazad.Checked Then
            sstype = 2
        End If
        Dim startdate As String = "-1"
        Dim EndDate As String = "-1"
        If chk_Date.Checked Then
            startdate = txt_FromDate.Value
            EndDate = txt_ToDate.Value
        End If
        Dim isworkform As Integer = 1
        Dim isnotworkform As Integer = 1
        If rb_WorkForm.Checked Then
            isworkform = 1
            isnotworkform = 0
        Else
            If rb_WithoutWorkForm.Checked Then
                isworkform = 0
                isnotworkform = 1
            End If
        End If
        Me.Pm_Con_Rp_RemainedItemTableAdapter.Fill(Me.Ds_Con.pm_Con_Rp_RemainedItem, srl_vahed, sstype, star, srl_post, startdate, EndDate, isworkform, isnotworkform, srl_contract)

    End Sub

    Private Sub Frm_RpNafarSatGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        PostOrKhat.Checked = False
        chk_Date.Checked = False
        If Me.Ds_Pm.Pm_Vahed.Rows.Count > 0 Then
            Cmb_Vahed.SelectedIndex = 0
        End If
        txt_FromDate.Enabled = chk_Date.Checked
        txt_ToDate.Enabled = chk_Date.Checked
        Cmb_Post.Enabled = PostOrKhat.Checked
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary.Remove(8) + "32"

    End Sub

    Private Sub Cmb_Vahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Vahed.SelectedIndexChanged, cmb_Contract.SelectedIndexChanged
        If Not Cmb_Vahed.SelectedValue Is Nothing Then
            Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, Cmb_Vahed.SelectedValue.ToString)
            If Cmb_Vahed.SelectedValue = 76 Or Cmb_Vahed.SelectedValue = 104 Or Cmb_Vahed.SelectedValue = 105 Then
                PostOrKhat.Text = "خط"
                Cmb_Post.Visible = False
                cmb_Line.Visible = True
            Else
                PostOrKhat.Text = "پست"
                Cmb_Post.Visible = True
                cmb_Line.Visible = False
            End If

        End If
    End Sub


    Private Sub chk_Date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Date.CheckedChanged
        txt_FromDate.Enabled = chk_Date.Checked
        txt_ToDate.Enabled = chk_Date.Checked
    End Sub

    Private Sub PostOrKhat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostOrKhat.CheckedChanged
        Cmb_Post.Enabled = PostOrKhat.Checked
        cmb_Line.Enabled = PostOrKhat.Checked
    End Sub

    Private Sub rp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp.Click
        Dim rpd As New Rp_StatusStatement

        Dim dt As New DataTable()

        rpd.SetDataSource(Ds_Con.pm_Con_Rp_RemainedItem.DataSet)
        rpd.SetParameterValue(rpd.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        'rpd.SetParameterValue(rpd.Parameter_status.ParameterFieldName, statusTC)
        Dim frm_rpd As New Frm_RpVw(rpd, Me.Ds_Con.pm_Con_Rp_RemainedItem.DataSet.Tables("0"))
        frm_rpd.ShowDialog()
    End Sub

  
End Class