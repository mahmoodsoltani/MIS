Public Class Frm_RpCompareGroupEibForm

    Private Sub Frm_RpExtraWork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary
        Me.rb_Group.Checked = True
    End Sub


    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim Showp As Integer = IIf(chk_ShowPeiro.Checked, -1, 1)
        Dim rp As New Rp_CompareGroupEibForm
        Me.Rp_CompareGroupEibFormTableAdapter.Fill(Me.Ds_Rp.Rp_CompareGroupEibForm, txt_FromDate.Value, txt_ToDate.Value, Showp)
        If rb_NoFixed.Checked Then
            Ds_Rp.Rp_CompareGroupEibForm.DefaultView.Sort = "[رفع نشده] dESC"
        ElseIf rb_All.Checked Then
            Ds_Rp.Rp_CompareGroupEibForm.DefaultView.Sort = "[کل] dESC"
        ElseIf rb_Fixed.Checked Then
            Ds_Rp.Rp_CompareGroupEibForm.DefaultView.Sort = "[رفع شده] dESC"
        ElseIf rb_Group.Checked Then
            Ds_Rp.Rp_CompareGroupEibForm.DefaultView.Sort = "[نام گروه] dESC"
        ElseIf rb_Vahed.Checked Then
            Ds_Rp.Rp_CompareGroupEibForm.DefaultView.Sort = "[نام واحد] dESC"
        ElseIf rb_DarsadFixed.Checked Then
            Ds_Rp.Rp_CompareGroupEibForm.DefaultView.Sort = "[درصد رفع شده] dESC"
        ElseIf rb_DarsadNotFixed.Checked Then
            Ds_Rp.Rp_CompareGroupEibForm.DefaultView.Sort = "[درصد رفع نشده] dESC"
        End If
        rp.SetDataSource(Me.Ds_Rp.Rp_CompareGroupEibForm.DefaultView)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
        rp.SetParameterValue(rp.Parameter_FromDate.ParameterFieldName, txt_FromDate.Value)
        rp.SetParameterValue(rp.Parameter_ToDate.ParameterFieldName, txt_ToDate.Value)
        Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Rp.Rp_CompareGroupEibForm.DataSet.Tables("0"))
        frm_rp.ShowDialog()
    End Sub
End Class