Public Class Frm_SummaryRpStatusStatementExtraWork

    Private Sub Frm_RpExtraWork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chk_Group.Checked = True
        chk_Vahed.Checked = True
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Pm_Company' table. You can move, or remove it, as needed.
        Me.Pm_CompanyTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Company)
        Dim Month As Integer = CInt(Setting.TarikheJary.Substring(5, 2)) - 1
        Month = IIf(Month = 0, 12, Month)
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(5) + IIf(Month.ToString().Length = 1, "0" + Month.ToString(), Month.ToString()) + "/01"
        Me.txt_ToDate.Value = Setting.TarikheJary.Remove(5) + IIf(Month.ToString().Length = 1, "0" + Month.ToString(), Month.ToString()) + "/31"


        'If ComboBox1.ValueMember = "1" Then
        '    btn_Save.Visible = False
        '    btn_Fanavaran.Visible = True

        'ElseIf ComboBox1.ValueMember = "2" Then
        '    btn_Save.Visible = True
        '    btn_Fanavaran.Visible = False

        'End If



    End Sub




    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim srl_vahed = -1
        If Not chk_Vahed.Checked Then
            srl_vahed = cmb_Vahed.SelectedValue
        End If
        Dim srl_group = -1
        If Not chk_Group.Checked Then
            srl_group = cmb_Group.SelectedValue
        End If
        Dim rp As New Rp_SummaryExtraWork
        Me.Rp_SummaryStatusstatementExtraWorkTableAdapter.Fill(Me.Ds_Rp.Rp_SummaryStatusstatementExtraWork, srl_vahed, srl_group, txt_FromDate.Value, txt_ToDate.Value)

        rp.SetDataSource(Me.Ds_Rp.Rp_SummaryExtraWork.DataSet)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        rp.SetParameterValue(rp.Parameter_ToDate.ParameterFieldName, txt_ToDate.Value)
        rp.SetParameterValue(rp.Parameter_FromDate.ParameterFieldName, txt_FromDate.Value)
        Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Rp.Rp_SummaryExtraWork.DataSet.Tables("0"))
        frm_rp.ShowDialog()
    End Sub




    Private Sub btn_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Report.Click
        Dim srl_vahed = -1
        If Not chk_Vahed.Checked Then
            srl_vahed = cmb_Vahed.SelectedValue
        End If
        Dim srl_group = -1
        If Not chk_Group.Checked Then
            srl_group = cmb_Group.SelectedValue
        End If
        Dim rp1 As New Rp_SummaryStatusstatementExtraWork
        Me.Rp_SummaryStatusstatementExtraWorkTableAdapter.Fill(Me.Ds_Rp.Rp_SummaryStatusstatementExtraWork, srl_vahed.ToString(), srl_group.ToString(), txt_ToDate.Value, txt_FromDate.Value)
        rp1.SetDataSource(Me.Ds_Rp.Rp_SummaryExtraWorkFanavaran.DataSet)
        rp1.SetParameterValue(rp1.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        rp1.SetParameterValue(rp1.Parameter_ToDate.ParameterFieldName, txt_ToDate.Value)
        rp1.SetParameterValue(rp1.Parameter_FromDate.ParameterFieldName, txt_FromDate.Value)
        Dim frm_rp1 As New Frm_RpVw(rp1, Me.Ds_Rp.Rp_SummaryExtraWorkFanavaran.DataSet.Tables("0"))
        frm_rp1.ShowDialog()

    End Sub

    Private Sub chk_Vahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Vahed.CheckedChanged
        cmb_Vahed.Enabled = Not chk_Vahed.Checked
        If Not chk_Vahed.Checked Then
            Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, cmb_Vahed.SelectedValue)
        Else
            Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)

        End If

    End Sub

    Private Sub chk_Group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Group.CheckedChanged
        cmb_Group.Enabled = Not chk_Group.Checked
    End Sub

    Private Sub cmb_Vahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Vahed.SelectedIndexChanged
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, cmb_Vahed.SelectedValue)

    End Sub
End Class