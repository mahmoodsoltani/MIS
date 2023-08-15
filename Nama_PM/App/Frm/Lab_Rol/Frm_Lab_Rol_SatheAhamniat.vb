Public Class Frm_Lab_Rol_SatheAhamniat

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Lab_Rol_SatheAhamniatTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_SatheAhamniat)
    End Sub
End Class