Public Class Frm_RpMojodiAnbar

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim Less As Integer
        Dim Big As Integer
        Dim Kala As Integer
        If KalaSelectManager2.Result Is Nothing Then
            Kala = -1
        Else
            Kala = KalaSelectManager2.Result(0)
        End If
        Try
            Less = IIf(chk_LessAll.Checked, -1, txt_LessThan.Value)
            Big = IIf(chk_BigAll.Checked, -1, txt_BigerThan.Value)
        Catch
            Less = -1
            Big = -1
        End Try
        Dim rp As New Rp_MojodiAnbar
        Me.Rp_MojodiAnbarTableAdapter.Fill(Me.Ds_Rp.Rp_MojodiAnbar, Kala, Big, Less)
        rp.SetDataSource(Me.Ds_Rp.Rp_Pm_KalaUse.DataSet)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, (Me.Ds_Rp.Rp_Pm_KalaUse.DataSet.Tables(0)))
        frm_rp.ShowDialog()
    End Sub

    Private Sub chk_Date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_LessAll.CheckedChanged, chk_BigAll.CheckedChanged, chk_AllKala.CheckedChanged
        KalaSelectManager2.Enabled = IIf(chk_AllKala.Checked, False, True)
        txt_BigerThan.Enabled = IIf(chk_BigAll.Checked, False, True)
        txt_LessThan.Enabled = IIf(chk_LessAll.Checked, False, True)
    End Sub
End Class