Public Class Frm_RpExtraWork

    Private Sub Frm_RpExtraWork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim rp As New Rp_ExtraWork
        Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable("exec Rp_EzafeKar " + lk_Ashkhas.Result(0).ToString() + ",'" + txt_FromDate.Value + "','" + txt_ToDate.Value + "'")
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        rp.SetParameterValue(rp.Parameter_ToDate.ParameterFieldName, txt_ToDate.Value)
        rp.SetParameterValue(rp.Parameter_FromDate.ParameterFieldName, txt_FromDate.Value)
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()
    End Sub
End Class