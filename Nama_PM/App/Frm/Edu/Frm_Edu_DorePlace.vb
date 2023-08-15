Public Class Frm_Edu_DorePlace

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_DorePlaceTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DorePlace)

    End Sub

    Private Sub Frm_Amo_MahaleBargozary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_DorePlace' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DorePlaceTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DorePlace)
    End Sub
End Class