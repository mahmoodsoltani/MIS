Public Class Frm_Edu_JobDore
    Private srl_job As Integer
    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Dore' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DoreTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Dore)
        Me.Pm_Edu_JobDoreTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_JobDore, srl_job)
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Dore' table. You can move, or remove it, as needed.
    End Sub
    Public Sub New(ByVal Srl_Job As Integer)
        Me.srl_job = Srl_Job
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_JobDoreTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_JobDore, srl_job)
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        For Each dr As DataGridViewRow In DataGridView1.Rows
            If dr.Cells(1).Value = cmb_Dore.SelectedValue Then
                MessageBox.Show("این عنوان شغلی قبلا انتخاب شده است")
                Return False
            End If
        Next

        DataObject.DataRow("srl_job") = Me.srl_job
        Return MyBase.Save(DoClearForm)
    End Function

End Class