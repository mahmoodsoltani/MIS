Public Class Frm_Lal_Rol_GhatateMasrafi

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Lab_Rol_GhatatMasrafiTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_GhatatMasrafi)
    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

    End Sub

    Private Sub Frm_Lal_Rol_GhatateMasrafi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class