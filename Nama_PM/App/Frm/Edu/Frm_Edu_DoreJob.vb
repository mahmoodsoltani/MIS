Public Class Frm_Edu_DoreJob
    Private srl_dore As Integer
    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_JobTitle' table. You can move, or remove it, as needed.
        Me.Pm_Edu_JobTitleTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_JobTitle)
        Me.Pm_Edu_DoreJobTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreJob, srl_dore)
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Dore' table. You can move, or remove it, as needed.
    End Sub
    Public Sub New(ByVal Srl_Dore As Integer)
        Me.srl_dore = Srl_Dore
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_DoreJobTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreJob, srl_dore)
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        For Each dr As DataGridViewRow In DataGridView1.Rows
            If dr.Cells(1).Value = cmb_TahvilePerson.SelectedValue Then
                MessageBox.Show("این عنوان شغلی قبلا انتخاب شده است")
                Return False
            End If
        Next

        DataObject.DataRow("srl_dore") = Me.srl_dore
        Return MyBase.Save(DoClearForm)
    End Function

End Class