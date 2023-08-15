Public Class Frm_WorkFormVw

    Public Sub New()
        InitializeComponent()
        Me.WorkForm_MasterTableAdapter.Fill(Me.Ds_Pm.WorkForm_Master)
    End Sub

    Public Sub New(ByVal Srl_Post As Integer)
        InitializeComponent()
        Me.WorkForm_MasterTableAdapter.FillByPost(Me.Ds_Pm.WorkForm_Master, Srl_Post)
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_WorkForm(-1)
        s.ShowDialog()
        Me.WorkForm_MasterTableAdapter.Fill(Me.Ds_Pm.WorkForm_Master)
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim s As New Frm_WorkForm(srl)
        s.ShowDialog()
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
            If srl = -1 Then
                Return
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then
                BaseDataObject.DataAccess.Delete("Pm_WorkForm_EibForm", " Srl_Pm_WorkForm_Master=" + srl.ToString())
                BaseDataObject.DataAccess.Delete("Pm_WorkForm_KalaMasrafi", " Srl_Pm_WorkForm_Master=" + srl.ToString())
                BaseDataObject.DataAccess.Delete("Pm_WorkFrom_Detail", " Srl_Pm_WorkForm_Master=" + srl.ToString())
                BaseDataObject.DataAccess.Delete("Pm_ExecutePmProgram", " Srl_Pm_WorkForm=" + srl.ToString())
                BaseDataObject.DataAccess.Delete("Pm_WorkForm_Master", srl)
                If BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                    Me.WorkForm_MasterTableAdapter.Fill(Me.Ds_Pm.WorkForm_Master)
                    Return
                End If
            End If
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            Return
        End If
    End Sub

    Private Sub Frm_WorkFormVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.WorkForm_Master' table. You can move, or remove it, as needed.
        Me.WorkForm_MasterTableAdapter.Fill(Me.Ds_Pm.WorkForm_Master)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        Dim srl_WorkForm As Integer = -1
        srl_WorkForm = DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = 9 Then
                Dim frm As New Frm_Con_StatusStatement(srl_WorkForm, -1)
                frm.ShowDialog()
            Else
                Dim frm As New Frm_Con_StatusStatementMazad(srl_WorkForm, -1)
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If e.ColumnIndex = 9 Then
            cell.ToolTipText = "PM"
        ElseIf e.ColumnIndex = 10 Then
            cell.ToolTipText = "کار مازاد"
        End If
    End Sub
End Class