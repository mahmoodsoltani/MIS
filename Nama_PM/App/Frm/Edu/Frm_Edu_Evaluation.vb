Public Class Frm_Edu_Evaluation
    Private srl_participate As Integer

    Public Sub New(ByVal srl_Participate As Integer)
        Me.srl_participate = srl_Participate
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Frm_Edu_Evaluation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False

        If CInt(BaseDataObject.DataAccess.ExecScalar("select count(*) from pm_edu_evaluation where srl_doreparticipate = " + srl_participate.ToString())) = 0 Then
            BaseDataObject.DataAccess.ExecQuery("insert into pm_edu_evaluation (Srl_DoreParticipate,Srl_EvaluationItem,Answer) select " + srl_participate.ToString() + ",srl,4 from pm_Edu_EvaluationItem")
        End If
        Me.Pm_Edu_EvaluationTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Evaluation, srl_participate)
        'Dim r As Integer = 1
        'For Each dr As DataRow In Me.Ds_Edu.Pm_Edu_Evaluation.Rows
        '    Dim l As Label = New Label()
        '    l.Text = dr("Title").ToString()
        '    l.RightToLeft = System.Windows.Forms.RightToLeft.Yes

        '    l.Size = New Size(300, 25)
        '    l.Location = New Point(Me.Size.Width - 320, 30 + (r * 40))
        '    r = r + 1
        '    Me.Controls.Add(l)

        'Next
        DataGridView1.Height = (DataGridView1.RowCount + 2) * DataGridView1.Rows(0).Height
        Me.Height = DataGridView1.Height + 60
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If Not DataGridView1.SelectedCells Is Nothing Then
            If e.ColumnIndex > 1 And e.ColumnIndex < 6 Then
             
                For i As Integer = 2 To 5
                    If i <> e.ColumnIndex Then
                        DataGridView1.Rows(e.RowIndex).Cells(i).Value = 0
                    End If
                Next
                DataGridView1.SelectedCells(0).Value = CInt(Not CBool(DataGridView1.SelectedCells(0).Value))
                BaseDataObject.DataAccess.ExecQuery("update pm_edu_evaluation set answer = " + (e.ColumnIndex - 1).ToString() + " where srl = " + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
            End If
        End If
    End Sub
End Class