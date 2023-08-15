Public Class Frm_Rp_MonthReport

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim srl_contract As Integer = cmb_Contract.SelectedValue
        Dim srl_vahed As String = "-1"
        Dim srl_Source As String = "-1"
        Dim srl_omoor As String = "-1"
        Dim srl_Month As String = "-1"
        Dim sstype As Integer = -1
        If rb_pm.Checked Then
            sstype = 1
        ElseIf rb_Mazad.Checked Then
            sstype = 2
        End If
        If Not chk_Vahed.Checked Then
            For Each dr As DataGridViewRow In DGV_Vahed.Rows
                If dr.Cells(0).Value Then
                    srl_vahed = srl_vahed + "," + dr.Cells(1).Value.ToString()
                End If
            Next
            srl_vahed = srl_vahed + ",-1"
        End If
        If Not chk_Omoor.Checked Then
            For Each dr As DataGridViewRow In DGV_Omoor.Rows
                If dr.Cells(0).Value Then
                    srl_omoor = srl_omoor + "," + dr.Cells(1).Value.ToString()
                End If
            Next
            srl_omoor = srl_omoor + ",-1"
        End If
        If Not chk_Source.Checked Then
            For Each dr As DataGridViewRow In DGV_Source.Rows
                If dr.Cells(0).Value Then
                    srl_Source = srl_Source + "," + dr.Cells(1).Value.ToString()
                End If
            Next
            srl_Source = srl_Source + ",-1"
        End If
        If Not chk_Month.Checked Then
            For Each dr As DataGridViewRow In DGV_Month.Rows
                If dr.Cells(0).Value Then
                    srl_Month = srl_Month + "," + dr.Cells(1).Value.ToString()
                End If
            Next
            srl_Month = srl_Month + ",-1"
        End If
        If cmb_GroupByName.SelectedIndex = 0 Then
            Me.Rp_Pm_MonthReport_OmoorTableAdapter.Fill(Ds_Con.Rp_Pm_MonthReport_Omoor, srl_contract, CInt(txt_year.Text), sstype, srl_Month, srl_omoor, srl_vahed, srl_Source)
        End If
        Dim rp As New Rp_MonthReport()
        Dim dt As DataTable = Ds_Con.Rp_Pm_MonthReport_Omoor
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        rp.SetParameterValue(rp.Parameter_ContractName.ParameterFieldName, cmb_Contract.Text)
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()

    End Sub

    Private Sub Frm_RpNafarSatGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_MonthTableAdapter.Fill(Me.Ds_Con.Pm_Month)
        Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        Me.Pm_Con_SourceTableAdapter.Fill(Me.Ds_Con.Pm_Con_Source)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        txt_year.Text = Setting.TarikheJary.Substring(0, 4)
        cmb_GroupByName.SelectedIndex = 0
    End Sub

    Private Sub PostOrKhat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Vahed.CheckedChanged, chk_Source.CheckedChanged
        DGV_Vahed.Enabled = Not chk_Vahed.Checked
    End Sub
    Private Sub chk_Omoor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Omoor.CheckedChanged, chk_Month.CheckedChanged
        DGV_Omoor.Enabled = Not chk_Omoor.Checked
    End Sub
    Private Sub chk_Source_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Source.CheckedChanged
        DGV_Source.Enabled = Not chk_Source.Checked
    End Sub

    Private Sub chk_Month_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Month.CheckedChanged
        DGV_Month.Enabled = Not chk_Month.Checked
    End Sub
End Class