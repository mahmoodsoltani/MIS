Public Class Frm_Con_Unit

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Con_UnitTableAdapter.Fill(Me.Ds_Con.Pm_Con_Unit)
    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

    End Sub
End Class