Public Class Frm_Rp_Lab_TamirAlarm

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        getsearch()
    End Sub

    Sub getsearch()
        If rbtn_TahvilBound.Checked Then
            Me.Pm_Lab_Rol_TamiratViewTableAdapter.FillByTahvilDateBound(Me.Ds_Lab.Pm_Lab_Rol_TamiratView, Setting.TarikheJary)
        ElseIf rbtn_TahvilEmpty.Checked Then
            Me.Pm_Lab_Rol_TamiratViewTableAdapter.FillByTahvilDateEmpty(Me.Ds_Lab.Pm_Lab_Rol_TamiratView)
        ElseIf rbtn_TAmirBound.Checked Then
            Me.Pm_Lab_Rol_TamiratViewTableAdapter.FillByTamirDateBound(Me.Ds_Lab.Pm_Lab_Rol_TamiratView, Setting.TarikheJary)
        ElseIf rbtn_TamirEmpty.Checked Then
            Me.Pm_Lab_Rol_TamiratViewTableAdapter.FillByTamirDateEmpty(Me.Ds_Lab.Pm_Lab_Rol_TamiratView)
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim s As New Frm_Lab_Rol_Tamir(srl)
        s.ShowDialog()
        getsearch()
    End Sub

    Private Sub btn_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Report.Click
        Dim rp As New Rp_Lab_Rol_Search

        rp.SetDataSource(Ds_Lab.Pm_Lab_Rol_TamiratView.DataSet)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Lab.Pm_Lab_Rol_TamiratView.DataSet.Tables("0"))
        frm_rp.ShowDialog()
    End Sub
End Class