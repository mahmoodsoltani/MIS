Public Class Frm_EibFormVw

    Public Sub New()
        InitializeComponent()
    End Sub

    Dim Srl_Post As Integer = -1

    Public Sub New(ByVal Srl_Post As Integer)
        InitializeComponent()
        Me.Srl_Post = Srl_Post
        'LoadDataGridView()
    End Sub

    Public Overrides Sub LoadDataGridView()
        Dim Srl_Post As Integer = -1
        Dim Srl_Vahed As Integer = -1
        Dim FromDate As String = ""
        Dim ToDate As String = ""

        If Not chk_AllDate.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If

        If Not chk_AllPost.Checked Then
            Srl_Post = cmb_Post.SelectedValue
        End If

        If Not Chk_AllVahed.Checked Then
            Srl_Vahed = cmb_Vahed.SelectedValue
        End If

        Me.Pm_EibFormTableAdapter.Fill(Me.Ds_Pm.pm_EibForm, Srl_Post, Srl_Vahed, -1, FromDate, ToDate)
        MyBase.LoadDataGridView()
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            btn_New_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btn_Edit_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            btn_Delete_Click(Nothing, Nothing)
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub

    Private Sub Frm_EibFormVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.StatusStrip1.Items.Add("F2 جدید")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("F3 ویرایش")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("F4 حذف")
        MyBase.StatusStrip1.Items.Add("-")

        chk_AllPost.Checked = True
        Chk_AllVahed.Checked = True
        chk_AllDate.Checked = False
        txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_ToDate.Value = Setting.TarikheJary
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)

        If Srl_Post <> -1 Then
            cmb_Post.SelectedValue = Srl_Post
            chk_AllPost.Checked = False
        End If
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_EibForm(-1)
        s.ShowDialog()
        LoadDataGridView()
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim s As New Frm_EibForm(srl)
        s.ShowDialog()
        LoadDataGridView()
    End Sub

    Public Overrides Function Delete() As Boolean
        If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
            If srl = -1 Then
                Return False
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then
                BaseDataObject.DataAccess.Delete("Pm_EibFormDetails", " Srl_Pm_EibFormMaster=" + srl.ToString())
                BaseDataObject.DataAccess.Delete("Pm_EibFormPeiro", " Srl_Pm_EibFormMaster=" + srl.ToString())
                BaseDataObject.DataAccess.Delete("Pm_EibFormMaster", srl)
                BaseDataObject.DataAccess.Delete("Pm_eibFormAttachment", " Srl_Pm_EibFormMaster=" + srl.ToString())

                If BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                    LoadDataGridView()
                    Return True
                End If
            End If
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            Return False
        End If
    End Function

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Delete()
    End Sub

    Private Sub txt_FromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ToDate.ValueChanged, txt_FromDate.ValueChanged
        LoadDataGridView()
    End Sub

    Private Sub chk_AllDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllVahed.CheckedChanged, chk_AllPost.CheckedChanged, chk_AllDate.CheckedChanged
        LoadDataGridView()
    End Sub

    Private Sub cmb_Post_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Vahed.SelectedIndexChanged, cmb_Post.SelectedIndexChanged
        LoadDataGridView()
    End Sub

End Class