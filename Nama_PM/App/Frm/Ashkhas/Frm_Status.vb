Public Class Frm_Status
    Public Overrides Sub LoadDataGridView()
        Me.Pm_StatusTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Status)
    End Sub
    Private Sub Frm_Pm_Company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_StatusTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Status)
    End Sub
End Class