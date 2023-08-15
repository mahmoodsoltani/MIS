Public Class Frm_Device_Sazande

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Device_SazandeTableAdapter.Fill(Me.Ds_Lab.Pm_Device_Sazande)
    End Sub

    Private Sub Frm_Device_Sazande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class