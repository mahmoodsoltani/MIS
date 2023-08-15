Public Class Frm_Edu_DoreParticipate
    Private srl_doreholding = -1
    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_DorePresenter' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_DoreHoldingtitle' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DoreHoldingtitleTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreHoldingtitle)
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Dore' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DoreTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Dore)

        Me.Pm_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Ashkhas)
        Me.Pm_Edu_DoreParticipationTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreParticipation, srl_doreholding)
        Label9.Focus()
    End Sub
    Public Sub New(ByVal Srl_DoreHolding As Integer)
        Me.srl_doreholding = Srl_DoreHolding
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_DoreParticipationTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreParticipation, srl_doreholding)
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        For Each dr As DataGridViewRow In DataGridView1.Rows
            If FormState = FormStates.NewRecord And dr.Cells(6).Value = cmb_Ashkhas.SelectedValue Then
                MessageBox.Show("این فرد قبلا اضافه شده است")
                cmb_Ashkhas.Focus()
                Return False
            End If
        Next

        DataObject.DataRow("srl_doreholding") = Me.srl_doreholding

        MyBase.Save(DoClearForm)
        FormState = FormStates.NewRecord
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True
        DataGridView1.Enabled = True
    End Function

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 And e.ColumnIndex = 6 Then
            Dim frm As New Frm_Edu_Evaluation(DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer))
            frm.ShowDialog()
        End If
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 And e.ColumnIndex = 7 Then
            Dim frm As New Frm_Edu_DoreParticipatePresent(DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer))
            frm.ShowDialog()
        End If
    End Sub

    Public Overrides Function Delete() As Boolean
        Try
            If Not DataGridView1.SelectedRows Is Nothing Then
                BaseDataObject.DataAccess.BeginTransaction()
                Dim b As Boolean = MyBase.Delete()
                BaseDataObject.DataAccess.Delete("pm_edu_evaluation", "Srl_DoreParticipate=" + DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
                BaseDataObject.DataAccess.Commit()
                Return b
            Else
                MessageBoxFa.Show("خطا در حذف اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return False
            End If


        Catch ex As Exception
            MessageBoxFa.Show("خطا در حذف اطلاعات")
            BaseDataObject.DataAccess.RollBack()
            Return False
        End Try
    End Function

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim cell As DataGridViewCell = Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If e.ColumnIndex = 6 Then
            cell.ToolTipText = "ارزشیابی"
        End If
        If e.ColumnIndex = 7 Then
            cell.ToolTipText = "ثبت حضور"
        End If
    End Sub


End Class