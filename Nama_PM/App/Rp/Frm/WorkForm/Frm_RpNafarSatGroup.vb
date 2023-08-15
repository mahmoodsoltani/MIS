Public Class Frm_RpNafarSatGroup

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        'Dim rp As New Rp_NafarSatGroup
        'If chk_AllGroup.Checked Then
        '    Rp_NafarSatGroupTableAdapter.Fill(Me.Ds_Rp.Rp_NafarSatGroup, txt_FromDate.Value, txt_ToDate.Value, -1)
        'Else
        '    Rp_NafarSatGroupTableAdapter.Fill(Me.Ds_Rp.Rp_NafarSatGroup, txt_FromDate.Value, txt_ToDate.Value, Cmb_Group.SelectedValue)
        'End If

        'For Each dr As DataRow In Ds_Rp.Rp_NafarSatGroup
        '    dr("Time") = New TimeSpan(0, 0, Double.Parse(dr("SumS").ToString))
        'Next

        'rp.SetDataSource(Me.Ds_Rp.Rp_NafarSatProject.DataSet)
        'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
        'Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Rp.Rp_NafarSatGroup.DataSet.Tables("0"))
        'frm_rp.ShowDialog()

        Dim obj As Frm_RpNafarSatGroupGraph
        If chk_AllGroup.Checked Then
            obj = New Frm_RpNafarSatGroupGraph(txt_FromDate.Value, txt_ToDate.Value, Cmb_Group.SelectedValue)
        Else
            obj = New Frm_RpNafarSatGroupGraph(txt_FromDate.Value, txt_ToDate.Value, -1)
        End If
        obj.ShowDialog()
    End Sub

    Private Sub Frm_RpNafarSatGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, -1)
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary
    End Sub
End Class