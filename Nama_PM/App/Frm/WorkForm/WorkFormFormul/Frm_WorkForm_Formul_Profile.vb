Public Class Frm_WorkForm_Formul_Profile

    Public Overrides Sub LoadDataGridView()
        Me.Pm_WorkForm_Formula_ProfileTableAdapter.Fill(Me.Ds_Pm.Pm_WorkForm_Formula_Profile)
        MyBase.LoadDataGridView()
    End Sub
End Class