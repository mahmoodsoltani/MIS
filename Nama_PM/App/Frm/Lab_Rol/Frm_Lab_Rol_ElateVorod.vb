Public Class Frm_Lab_Rol_ElateVorod

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Lab_Rol_ElateVorodTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_ElateVorod)
    End Sub
End Class