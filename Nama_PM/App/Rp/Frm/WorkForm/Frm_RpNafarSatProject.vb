Public Class Frm_RpNafarSatProject

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim obj As Frm_RpNafarSatProjectGraph
        If CheckBox7.Checked Then
            obj = New Frm_RpNafarSatProjectGraph(txt_FromDate.Value, txt_ToDate.Value, ComboBox6.SelectedValue)
        Else
            obj = New Frm_RpNafarSatProjectGraph(txt_FromDate.Value, txt_ToDate.Value, -1)
        End If
        obj.ShowDialog()
    End Sub

    Private Sub Frm_RpNafarSatProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_HazineCodeTableAdapter.Fill(Me.Ds_Pm.Pm_HazineCode, -1)
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary
    End Sub
End Class