Public Class Frm_Edu_DorePresenter

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_DorePresenterTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DorePresenter)

    End Sub

    Private Sub Frm_Edu_DorePresenter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_DorePresenter' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DorePresenterTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DorePresenter)

    End Sub
End Class