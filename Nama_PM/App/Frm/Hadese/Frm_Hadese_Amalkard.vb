Public Class Frm_Hadese_Amalkard

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Hadese_AmalkardSystemTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_AmalkardSystem)
    End Sub

    Private Sub Frm_Hadese_Amalkard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_Hadese_AmalkardSystemTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_AmalkardSystem)
    End Sub
End Class