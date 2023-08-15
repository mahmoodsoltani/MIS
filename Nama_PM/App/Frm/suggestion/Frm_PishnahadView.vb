Public Class Frm_PishnahadView

    Private Sub Frm_PishnahadView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_PishnahadVw' table. You can move, or remove it, as needed.
        Me.Pm_PishnahadVwTableAdapter1.Fill(Me.Ds_Pm.Pm_PishnahadVw)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        'Me.Pm_PishnahadVwTableAdapter.Fill(Me.Ds_Pm.Pm_PishnahadVw)
        'Me.Pm_PishnahadVwTableAdapter.FillBySearch(Me.Ds_Pm.Pm_PishnahadVw, -1, -1, -1, "", "", -1, -1, "", -1)
        'LoadDataGridView()
    End Sub

    Private Sub chk_AllDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllDate.CheckedChanged
        txt_StartPmDate.Enabled = chk_AllDate.Checked
        txt_EndPmdate.Enabled = chk_AllDate.Checked
        'LoadDataGridView()
    End Sub

    Private Sub Chk_AllPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllPost.CheckedChanged
        cmb_Post.Enabled = Chk_AllPost.Checked
        'LoadDataGridView()
    End Sub


    Public Overrides Sub LoadDataGridView()
        Dim FromDate As String = ""
        If chk_AllDate.Checked Then
            FromDate = txt_StartPmDate.Value
        End If

        Dim ToDate As String = ""

        If chk_AllDate.Checked Then
            ToDate = txt_EndPmdate.Value
        End If

        Dim Srl_Post As Integer = -1
        If Chk_AllPost.Checked Then
            Srl_Post = cmb_Post.SelectedValue
        End If

        'Me.Pm_PishnahadVwTableAdapter1.Fill(Me.Ds_Pm.Pm_PishnahadVw)
        Me.Pm_PishnahadVwTableAdapter1.FillBySearch(Me.Ds_Pm.Pm_PishnahadVw, Srl_Post, -1, -1, FromDate, ToDate, -1, "", -1)
        MyBase.LoadDataGridView()
        If Not chk_AllDate.Checked And Not Chk_AllPost.Checked Then
            Me.Pm_PishnahadVwTableAdapter1.Fill(Me.Ds_Pm.Pm_PishnahadVw)
        End If
        lbl_Record.Text = "تعداد رکورد :"
        lbl_Record.Text += DataGridView1.Rows.Count().ToString()
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_Pishnahad(-2)
        s.ShowDialog()
        Me.Pm_PishnahadVwTableAdapter1.Fill(Me.Ds_Pm.Pm_PishnahadVw)
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        'Frm_Lab_Rol_Master.share = 5
        Dim s As New Frm_Pishnahad(srl)
        s.ShowDialog()
   Me.Pm_PishnahadVwTableAdapter1.Fill(Me.Ds_Pm.Pm_PishnahadVw)
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srlPishnahad As Integer = FindSrl(DataGridView1, FindSerialPromtType.Delete, False)
            If srlPishnahad = -1 Then
                Return
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then

                BaseDataObject.DataAccess.Delete("Pm_Post_Pishnahd", srlPishnahad)
                If BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                    Me.Pm_PishnahadVwTableAdapter1.Fill(Me.Ds_Pm.Pm_PishnahadVw)
                    Return

                End If
            End If
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            Return
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadDataGridView()
    End Sub
End Class