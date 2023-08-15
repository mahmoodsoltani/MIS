Public Class Frm_Edu_DoreParticipatePresent
    Private srl_Participate As Integer
    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Pm_Edu_DoreParticipatePresentTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreParticipatePresent, srl_Participate)
    End Sub
    Public Sub New(ByVal Srl_Participate As Integer)
        Me.srl_Participate = Srl_Participate
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_DoreParticipatePresentTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreParticipatePresent, srl_Participate)
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        For Each dr As DataGridViewRow In DataGridView1.Rows
            If FormState = FormStates.NewRecord And dr.Cells(2).Value = txt_Date.Value Then
                MessageBox.Show("این تاریخ قبلا اضافه شده است")
                Return False
            End If
        Next
        DataObject.DataRow("Srl_Dore_Participate") = Me.srl_Participate
        MyBase.Save(DoClearForm)
        FormState = FormStates.NewRecord
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True
        DataGridView1.Enabled = True
    End Function


    Private Sub txt_Date_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Date.TextChanged

    End Sub

    Private Sub btn_Before_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Before.Click

    End Sub
End Class