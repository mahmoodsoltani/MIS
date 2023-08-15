Public Class Frm_Edu_DoreType

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_DoreTypeTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreType)
    End Sub

    Private Sub Pm_Edu_DoreType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_Edu_DoreTypeTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreType)

    End Sub
End Class