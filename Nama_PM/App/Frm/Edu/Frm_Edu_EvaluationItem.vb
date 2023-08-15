Public Class Frm_Edu_EvaluationItem

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_EvaluationItemTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_EvaluationItem)

    End Sub

    Private Sub Pm_Edu_DoreType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_EvaluationItem' table. You can move, or remove it, as needed.
        Me.Pm_Edu_EvaluationItemTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_EvaluationItem)

    End Sub
End Class