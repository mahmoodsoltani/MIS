Public Class Frm_PmWithDevice

    Dim Srl_Pm_Tajhiz As Integer = -1
    Dim Srl_Pm_Tajhiz_ForSave As Integer = -1
    Dim srl_pm_Post As Integer = -1
    Dim srl_EditMaster As Integer = -1
    Dim srl_EditDetail As Integer = -1
    Dim srl_PostFromAnotherForm As Integer = -1
    Dim srl_tajhizFromAnotherForm As Integer = -1

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal srl_PostFromAnotherForm As Integer, ByVal srl_tajhizFromAnotherForm As Integer)
        InitializeComponent()
        Me.srl_PostFromAnotherForm = srl_PostFromAnotherForm
        Me.srl_tajhizFromAnotherForm = srl_tajhizFromAnotherForm
    End Sub

    Public Overrides Function Delete() As Boolean


    End Function
    Public Overrides Sub LoadDataGridView()
        ' Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Pm.Pm_Hadese_KhesaratDevice, srl_pm_Post)
        Dim startPmDate As String = IIf(chk_AllPmDate.Checked, txt_StartPmDate.Value, "")
        Dim EndPmDate As String = IIf(chk_AllPmDate.Checked, txt_EndPmdate.Value, "")
        Dim startexecDate As String = IIf(chk_AllExecDate.Checked, txt_StartExeDate.Value, "")
        Dim endexecDate As String = IIf(chk_AllExecDate.Checked, txt_EndExecDate.Value, "")
        Dim Tajhiz As Integer = IIf(chk_AllTajhiz.Checked, Srl_Pm_Tajhiz, -1)
        Dim post As Integer = IIf(Chk_AllPost.Checked, cmb_Post.SelectedValue, -1)
        Dim ShowWhat As Integer
        If Rb_All.Checked Then
            ShowWhat = 0
        ElseIf rb_Execute.Checked Then
            ShowWhat = 1
        ElseIf Rb_NoExecute.Checked Then
            ShowWhat = 2
        Else
            ShowWhat = 3
        End If
        Me.Pm_PmProgramTableAdapter.Fill(Me.Ds_Pm.Pm_PmProgram, Tajhiz, post, startPmDate, EndPmDate, startexecDate, endexecDate, ShowWhat)
        MyBase.LoadDataGridView()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(3).Value Is DBNull.Value Or DataGridView1.Rows(i).Cells(3).Value.ToString.Trim() = "" Then
                'DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            ElseIf DataGridView1.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(2).Value Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b5f5ad")
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f4a3a1")
            End If
        Next
    End Sub
    Public Overrides Function Edit() As Boolean
        Try
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select Pm_Hadese_KhesaratDevice.srl,srl_Pm_Post from Pm_Hadese_KhesaratDevice JOIN pm_pmProgram on Pm_Hadese_KhesaratDevice.srl = srl_Pm_Hadese_KhesaratDevice  where pm_pmProgram. srl=" + DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
            Cmb_Post_ForSave.SelectedValue = dr("Srl_Pm_Post")
            Srl_Pm_Tajhiz_ForSave = dr("srl")
            Dim dr2 As DataRow = BaseDataObject.DataAccess.GetRow("select Srl_Pm_CancelCause,ExecuteDate,WorkFormNo from pm_executePmprogram left join pm_workform_master on pm_workform_master.srl = Srl_Pm_WorkForm where pm_executePmprogram.srl = " + DataGridView1.SelectedRows(0).Cells(7).Value.ToString())
            txt_ExecuteDate.Value = dr2("executeDate")
            cmb_cancelCause.SelectedValue = IIf(Not dr2("Srl_Pm_CancelCause") Is DBNull.Value, dr2("Srl_Pm_CancelCause"), -1)
            srl_EditMaster = CInt(DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
            srl_EditDetail = CInt(DataGridView1.SelectedRows(0).Cells(7).Value.ToString())
            MyBase.Edit()
            txt_TajhizNameForSave.Text = DataGridView1.SelectedRows(0).Cells(2).Value
            Return True
        Catch
            Return False
        End Try
    End Function
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If Srl_Pm_Tajhiz_ForSave = -1 Then
            MessageBoxFa.Show("لطفا تجهیز را انتخاب نمائید")
            txt_TajhizNameForSave.Focus()
            Return False
        End If
        Try
            If srl_EditMaster = -1 Then
                BaseDataObject.DataAccess.BeginTransaction()
                Dim Pmmaster As DataRow = BaseDataObject.DataAccess.NewRow("Pm_PmProgram")
                Pmmaster("Srl_Pm_Hadese_KhesaratDevice") = Srl_Pm_Tajhiz_ForSave
                Pmmaster("Description") = txt_Description.Value
                Pmmaster("pm_date") = txt_Tarikh.Value
                Pmmaster("SubmitDate") = Setting.Now
                Pmmaster("Srl_SubmitUser") = Setting.Srl_User
                Dim srl As Integer = BaseDataObject.DataAccess.InsertWithLastId(Pmmaster, False)
                If srl = -1 Then
                    MessageBoxFa.Show("خطا در ذخیره سازی اطلاعات")
                    Return False
                Else
                    Dim pmdetail As DataRow = BaseDataObject.DataAccess.NewRow("Pm_ExecutePmProgram")
                    pmdetail("Srl_Pm_PmProgram") = srl
                    pmdetail("ExecuteDate") = txt_ExecuteDate.Value
                    pmdetail("Srl_Pm_CancelCause") = cmb_cancelCause.SelectedValue
                    BaseDataObject.DataAccess.InsertWithLastId(pmdetail, False)
                End If
                If BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد")
                Else
                    BaseDataObject.DataAccess.RollBack()
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                End If
            End If
            If srl_EditMaster <> -1 Then
                BaseDataObject.DataAccess.BeginTransaction()
                Dim Pmmaster As DataRow = BaseDataObject.DataAccess.GetRow("Pm_PmProgram", srl_EditMaster)
                Pmmaster("Srl_Pm_Hadese_KhesaratDevice") = Srl_Pm_Tajhiz_ForSave
                Pmmaster("Description") = txt_Description.Value
                Pmmaster("pm_date") = txt_Tarikh.Value
                Pmmaster("SubmitDate") = Setting.Now
                Pmmaster("Srl_SubmitUser") = Setting.Srl_User
                If Not BaseDataObject.DataAccess.Update(Pmmaster, 0) Then
                    BaseDataObject.DataAccess.RollBack()
                    MessageBoxFa.Show("خطا در ویرایش اطلاعات")
                    Return False
                End If

                Dim pmdetail As DataRow = BaseDataObject.DataAccess.GetRow("Pm_ExecutePmProgram", srl_EditDetail)
                pmdetail("ExecuteDate") = txt_ExecuteDate.Value
                pmdetail("Srl_Pm_CancelCause") = cmb_cancelCause.SelectedValue
                If BaseDataObject.DataAccess.Update(pmdetail, 0) Then
                    BaseDataObject.DataAccess.Commit()
                    MessageBoxFa.Show("ویرایش با موفقیت انجام شد")
                Else
                    BaseDataObject.DataAccess.RollBack()
                    MessageBoxFa.Show("خطا در ویرایش اطلاعات")
                End If
            End If
        Catch
            BaseDataObject.DataAccess.RollBack()
            MessageBoxFa.Show("خطا در ثبت اطلاعات")
            Return False
        End Try
        ' MyBase.Save(False)
        txt_TajhizNameForSave.Clear()
        Srl_Pm_Tajhiz_ForSave = -1
        txt_Tarikh.Clear()
        txt_ExecuteDate.Clear()
        txt_Description.Clear()
        cmb_cancelCause.SelectedValue = -1
        srl_EditDetail = -1
        srl_EditMaster = -1
        LoadDataGridView()
        cmb_Post.Focus()
        Return True
    End Function

    Private Sub Frm_Group_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_CancelCauseTableAdapter.Fill(Me.Ds_Pm.Pm_CancelCause)
        Dim row As DataRow = Ds_Pm.Pm_CancelCause.NewRow()
        row("نام") = "انتخاب دلیل کنسلی"
        Ds_Pm.Pm_CancelCause.Rows.InsertAt(row, 0)
        chk_AllExecDate.Checked = False
        chk_AllPmDate.Checked = False
        Chk_AllPost.Checked = False
        chk_AllTajhiz.Checked = False
        chk_AllExecDate_CheckedChanged(Nothing, Nothing)
        chk_AllPmDate_CheckedChanged(Nothing, Nothing)
        Chk_AllPost_CheckedChanged(Nothing, Nothing)
        chk_AllTajhiz_CheckedChanged(Nothing, Nothing)
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)

        cmb_cancelCause.SelectedValue = -1
        If srl_PostFromAnotherForm <> -1 And srl_tajhizFromAnotherForm <> -1 Then
            Chk_AllPost.Checked = True
            cmb_Post.SelectedValue = srl_PostFromAnotherForm
            chk_AllTajhiz.Checked = True
            Srl_Pm_Tajhiz = srl_tajhizFromAnotherForm
            txt_TajhizName.Value = BaseDataObject.DataAccess.ExecScalar("select case when Pm_Hadese_KhesaratDevice.Srl_pm_TajhizName   IS null then Pm_Hadese_KhesaratDevice.Name  else Pm_TajhizName .name   end from Pm_Hadese_KhesaratDevice LEFT JOIN Pm_TajhizName  ON Pm_TajhizName .Srl = Pm_Hadese_KhesaratDevice .Srl_pm_TajhizName where Pm_Hadese_KhesaratDevice.srl = " + srl_tajhizFromAnotherForm.ToString())
        End If
        LoadDataGridView()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Post.SelectedIndexChanged
        If cmb_Post.SelectedValue Is Nothing Then
            Return
        End If
        txt_TajhizName.Value = ""
        Srl_Pm_Tajhiz = -1
        LoadDataGridView()

        'If cmb_Post.SelectedValue Is Nothing Then
        '    Return
        'End If
        'If EnableCMB Then
        '    srl_pm_Post = cmb_Post.SelectedValue
        '    Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Pm.Pm_Hadese_KhesaratDevice, srl_pm_Post)
        '    Srl_Pm_Tajhiz = cmb_Tajhiz.SelectedValue
        '    Me.Pm_PmProgramTableAdapter.Fill(Me.Ds_Pm.Pm_PmProgram, Srl_Pm_Tajhiz, -1)
        'End If

    End Sub

    Private Sub cmb_Tajhiz_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btn_SelectDEvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectDEvice.Click
        If cmb_Post.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا پست را مشخص نمائید")
            cmb_Post.Focus()
            Return
        End If
        Dim s As New Frm_DeviceSelect(cmb_Post.SelectedValue)
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_TajhizName.Value = s.SelectedDevice.Text
            Srl_Pm_Tajhiz = s.SelectedDevice.Srl
            LoadDataGridView()
        End If
    End Sub

    Private Sub txt_ExecuteDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ExecuteDate.TextChanged

    End Sub

    Private Sub chk_AllExecDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllExecDate.CheckedChanged
        txt_StartExeDate.Enabled = chk_AllExecDate.Checked
        txt_EndExecDate.Enabled = chk_AllExecDate.Checked
        LoadDataGridView()
    End Sub

    Private Sub chk_AllPmDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllPmDate.CheckedChanged
        txt_StartPmDate.Enabled = chk_AllPmDate.Checked
        txt_EndPmdate.Enabled = chk_AllPmDate.Checked
        LoadDataGridView()
    End Sub

    Private Sub txt_StartPmDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_StartPmDate.TextChanged, txt_StartExeDate.TextChanged, txt_EndPmdate.TextChanged, txt_EndExecDate.TextChanged
    End Sub

    Private Sub txt_StartPmDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_StartPmDate.ValueChanged, txt_StartExeDate.ValueChanged, txt_EndPmdate.ValueChanged, txt_EndExecDate.ValueChanged
        LoadDataGridView()

    End Sub

    Private Sub Chk_AllPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllPost.CheckedChanged
        cmb_Post.Enabled = Chk_AllPost.Checked
        LoadDataGridView()
    End Sub

    Private Sub chk_AllTajhiz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllTajhiz.CheckedChanged
        'txt_TajhizName.Enabled = chk_AllTajhiz.Checked
        btn_SelectDEvice.Enabled = chk_AllTajhiz.Checked
        LoadDataGridView()
    End Sub

    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        If Cmb_Post_ForSave.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا پست را مشخص نمائید")
            Cmb_Post_ForSave.Focus()
            Return
        End If
        Dim s As New Frm_DeviceSelect(Cmb_Post_ForSave.SelectedValue)
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_TajhizNameForSave.Value = s.SelectedDevice.Text
            Srl_Pm_Tajhiz_ForSave = s.SelectedDevice.Srl
        End If
    End Sub

    Private Sub Cmb_Post_ForSave_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Post_ForSave.SelectedIndexChanged
        txt_TajhizNameForSave.Clear()
        Srl_Pm_Tajhiz_ForSave = -1
    End Sub

    Private Sub Rb_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_All.CheckedChanged, Rb_NoExecute.CheckedChanged, rb_Execute.CheckedChanged, Rb_Cancle.CheckedChanged
        LoadDataGridView()
    End Sub

    Private Sub txt_TajhizNameForSave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TajhizNameForSave.TextChanged

    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

    End Sub

    Private Sub DataGridView1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDown
        For i As Integer = 0 To DataGridView1.Rows.Count - 1

            If DataGridView1.Rows(i).Cells(3).Value Is DBNull.Value Or DataGridView1.Rows(i).Cells(3).Value.ToString.Trim() = "" Then
                'DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            ElseIf DataGridView1.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(2).Value Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b5f5ad")
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f4a3a1")
            End If

        Next
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Try
            If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
                If srl = -1 Then
                    Return
                End If
                If BaseDataObject.DataAccess.BeginTransaction() Then
                    Dim srl_exe As Integer = CInt(DataGridView1.SelectedRows(0).Cells(7).Value)
                    If CInt(BaseDataObject.DataAccess.ExecScalar("select count(*) from pm_executepmprogram where srl_pm_pmprogram=" + srl.ToString()) > 1) Then

                        BaseDataObject.DataAccess.Delete("pm_executepmprogram", srl_exe)
                    Else
                        BaseDataObject.DataAccess.Delete("pm_pmprogram", srl)
                        BaseDataObject.DataAccess.Delete("pm_executepmprogram", srl_exe)
                    End If
                    If BaseDataObject.DataAccess.Commit() Then
                        MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                        LoadDataGridView()
                        Return
                    End If
                End If
                MessageBoxFa.Show("اشکال در حذف اطلاعات")
                BaseDataObject.DataAccess.RollBack()
            End If
        Catch ex As Exception
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            BaseDataObject.DataAccess.RollBack()
        End Try

    End Sub

    
End Class