Public Class Frm_RpKalaUse

    Private Sub Frm_RpKalaUse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)
        txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_ToDate.Value = Setting.TarikheJary
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim Post As Integer
        Dim Group As Integer
        Dim Kala As Integer
        Dim Fromdate As String
        Dim Todate As String
        Dim Workformno As String
        If KalaSelectManager2.Result Is Nothing Then
            Kala = -1
        Else
            Kala = KalaSelectManager2.Result(0)
        End If
        Post = IIf(chk_AllPost.Checked, -1, cmb_Post.SelectedValue)
        Group = IIf(chk_AllGroup.Checked, -1, cmb_Group.SelectedValue)
        Fromdate = IIf(chk_Date.Checked, "", txt_FromDate.Value)
        Todate = IIf(chk_Date.Checked, "", txt_ToDate.Value)
        Workformno = IIf(chk_AllWorkFormNo.Checked, "", txt_WorkFormNo.Value)
        Dim rp As New Rp_KalaUse
        Me.Rp_Pm_KalaUseTableAdapter.Fill(Me.Ds_Rp.Rp_Pm_KalaUse, Fromdate, Todate, Group, Post, Kala, Workformno)
        rp.SetDataSource(Me.Ds_Rp.Rp_Pm_KalaUse.DataSet)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        If Fromdate = "" Then
            rp.SetParameterValue(rp.Parameter_Tarikh.ParameterFieldName, "تمام تاریخ ها")
        Else
            rp.SetParameterValue(rp.Parameter_Tarikh.ParameterFieldName, "دوره " + Fromdate + " لغایت " + Todate)

        End If
        If Workformno = "" Then
            rp.SetParameterValue(rp.Parameter_WorkForm.ParameterFieldName, "تمام فرم کارها")
        Else
            rp.SetParameterValue(rp.Parameter_WorkForm.ParameterFieldName, "فرم کار شماره" + Workformno)
        End If
        If Post = -1 Then
            rp.SetParameterValue(rp.Parameter_Post.ParameterFieldName, "تمام پست ها")
        Else
            rp.SetParameterValue(rp.Parameter_Post.ParameterFieldName, "پست " + cmb_Post.Text)
        End If
        If group = -1 Then
            rp.SetParameterValue(rp.Parameter_Group.ParameterFieldName, "تمام گروه ها")
        Else
            rp.SetParameterValue(rp.Parameter_Group.ParameterFieldName, "گروه " + cmb_Group.Text)
        End If
        Dim frm_rp As New Frm_RpVw(rp, (Me.Ds_Rp.Rp_Pm_KalaUse.DataSet.Tables(0)))
        frm_rp.ShowDialog()
    End Sub

    Private Sub chk_Date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Date.CheckedChanged, chk_AllWorkFormNo.CheckedChanged, chk_AllPost.CheckedChanged, chk_AllKala.CheckedChanged, chk_AllGroup.CheckedChanged
        pl_Date.Enabled = IIf(chk_Date.Checked, False, True)
        KalaSelectManager2.Enabled = IIf(chk_AllKala.Checked, False, True)
        cmb_Group.Enabled = IIf(chk_AllGroup.Checked, False, True)
        cmb_Post.Enabled = IIf(chk_AllPost.Checked, False, True)
        txt_WorkFormNo.Enabled = IIf(chk_AllWorkFormNo.Checked, False, True)
    End Sub
End Class