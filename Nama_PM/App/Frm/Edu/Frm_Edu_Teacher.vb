Public Class Frm_Edu_Teacher

    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Teacher' table. You can move, or remove it, as needed.
        Me.Pm_Edu_TeacherTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Teacher)
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Dore' table. You can move, or remove it, as needed.
      
    End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_TeacherTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Teacher)

    End Sub


End Class