Public Class Frm_RpEibForm
    Dim Srl_Pm_Tajhiz_ForSave As Integer = -1
    Private Sub Frm_RpEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_PostType' table. You can move, or remove it, as needed.
        Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm1.Pm_PostType)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_EibType' table. You can move, or remove it, as needed.
        Me.Pm_EibTypeTableAdapter1.Fill(Me.Ds_Pm1.Pm_EibType)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter1.Fill(Me.Ds_Pm1.Pm_Post)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_WorkSharh' table. You can move, or remove it, as needed.
        Me.Pm_WorkSharhTableAdapter.Fill(Me.Ds_Pm1.Pm_WorkSharh)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_ImportantPercent' table. You can move, or remove it, as needed.
        Me.Pm_ImportantPercentTableAdapter1.Fill(Me.Ds_Pm1.Pm_ImportantPercent)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_PostTip' table. You can move, or remove it, as needed.
        Me.Pm_PostTipTableAdapter1.Fill(Me.Ds_Pm1.Pm_PostTip)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter1.Fill(Me.Ds_Pm1.Pm_Vahed)
        Me.Pm_GroupTableAdapter1.Fill(Me.Ds_Pm1.Pm_Group, -1)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_WorkSharh' table. You can move, or remove it, as needed.
        Me.Pm_WorkSharhTableAdapter.Fill(Me.Ds_Pm1.Pm_WorkSharh)


        txt_OrginalEibFormFromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_OrginalEibFormToDate.Value = Setting.TarikheJary
        txt_RegistreFromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_RegisterToDate.Value = Setting.TarikheJary
        txt_refFromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_refToDate.Value = Setting.TarikheJary
        For Each chk As System.Windows.Forms.Control In GroupBox2.Controls
            If TypeOf chk Is CheckBox Then
                DirectCast(chk, CheckBox).Checked = True
            End If
        Next
        chk_ShowPeiro.Checked = False
    End Sub

    Private Sub Post_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Add.Click
        For Each dr As DataGridViewRow In DGV_Post.Rows
            If dr.Cells(0).Value = cmb_Post.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DGV_Post.Rows.Add()
        DGV_Post.Rows(i).Cells(0).Value = cmb_Post.SelectedValue
        DGV_Post.Rows(i).Cells(1).Value = cmb_Post.Text
    End Sub

    Private Sub Eib_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eib_Add.Click
        For Each dr As DataGridViewRow In DGV_EibType.Rows
            If dr.Cells(0).Value = cmb_eibType.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DGV_EibType.Rows.Add()
        DGV_EibType.Rows(i).Cells(0).Value = cmb_eibType.SelectedValue
        DGV_EibType.Rows(i).Cells(1).Value = cmb_eibType.Text
    End Sub

    Private Sub Post_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Del.Click

        If Not DGV_Post.CurrentRow Is Nothing And DGV_Post.Rows.Count >= 1 Then
            DGV_Post.Rows.RemoveAt(DGV_Post.CurrentRow.Index)
        End If
    End Sub

    Private Sub Eib_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eib_Del.Click
        If Not DGV_EibType.CurrentRow Is Nothing And DGV_EibType.Rows.Count >= 1 Then
            DGV_EibType.Rows.RemoveAt(DGV_EibType.CurrentRow.Index)
        End If
    End Sub

    Private Sub chk_AllPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllPost.CheckedChanged
        cmb_Post.Enabled = Not chk_AllPost.Checked
        DGV_Post.Enabled = Not chk_AllPost.Checked
        Post_Del.Enabled = Not chk_AllPost.Checked
        Post_Add.Enabled = Not chk_AllPost.Checked
    End Sub

    Private Sub chk_AllEib_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllEib.CheckedChanged
        cmb_eibType.Enabled = Not chk_AllEib.Checked
        DGV_EibType.Enabled = Not chk_AllEib.Checked
        Eib_Del.Enabled = Not chk_AllEib.Checked
        Eib_Add.Enabled = Not chk_AllEib.Checked
    End Sub

    Private Sub chk_AllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllGroup.CheckedChanged
        cmb_Group.Enabled = Not chk_AllGroup.Checked
        If (Not chk_AllVahed.Checked And Not chk_AllGroup.Checked) Then
            Me.Pm_GroupTableAdapter1.Fill(Me.Ds_Pm1.Pm_Group, cmb_Vahed.SelectedValue)
        Else
            Me.Pm_GroupTableAdapter1.Fill(Me.Ds_Pm1.Pm_Group, -1)
        End If
    End Sub

    Private Sub chk_AllVahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllVahed.CheckedChanged, chk_ShowPeiro.CheckedChanged
        cmb_Vahed.Enabled = Not chk_AllVahed.Checked
        chk_AllGroup_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub chk_AllEibFormNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllEibFormNo.CheckedChanged
        txt_eibFormNo.Enabled = Not chk_AllEibFormNo.Checked
    End Sub

    Private Sub chk_AllRefDdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllRefDdate.CheckedChanged
        txt_refFromDate.Enabled = Not chk_AllRefDdate.Checked
        txt_refToDate.Enabled = Not chk_AllRefDdate.Checked
    End Sub

    Private Sub chk_AllEibFomDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllEibFomDate.CheckedChanged
        txt_OrginalEibFormFromDate.Enabled = Not chk_AllEibFomDate.Checked
        txt_OrginalEibFormToDate.Enabled = Not chk_AllEibFomDate.Checked
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim EibFormFromDate As String = ""
        Dim EibFormToDate As String = ""
        Dim OrginalEibFormFromDate As String = ""
        Dim OrginalEibFormToDate As String = ""
        Dim EibRefFromDate As String = ""
        Dim EibReftoDate As String = ""
        Dim EibFromNo As String = ""
        Dim EibFormState As Integer = 0
        Dim Vahed As Integer = -1
        Dim ShowPeiro As Integer = -1
        Dim Group As Integer = -1
        Dim Post As String = ""
        Dim Tajhiz As String = ""
        Dim EibType As String = ""
        Dim PostTip As Integer = -1
        Dim PostType As Integer = -1
        Dim important As Integer = -1
        Dim Is_Undecided As Integer = -1
        Dim WorkDis As String = ""


        If rb_NotFix.Checked Then
            EibFormState = -1
        ElseIf rb_Fix.Checked Then
            EibFormState = 1
        End If
        If chk_AllPost.Checked Then
            Post = "-1"
        Else
            For Each dr As DataGridViewRow In DGV_Post.Rows
                Try
                    Post = Post + dr.Cells(0).Value.ToString() + ","
                Catch
                End Try
            Next
            Post = Post + "-1"
        End If
        If chk_AllNoDecided.Checked Then
            WorkDis = ""
        Else
            For Each dr As DataGridViewRow In DGV_Belataklif.Rows
                Try
                    WorkDis = WorkDis + dr.Cells(1).Value.ToString() + ","
                Catch
                End Try
            Next
            WorkDis = WorkDis + "-1"
        End If
        If Chk_AllTajhiz.Checked Then
            Tajhiz = "-2"
        Else
            For Each dr As DataGridViewRow In DGV_Tajhiz.Rows
                Try
                    Tajhiz = Tajhiz + dr.Cells(0).Value.ToString() + ","
                Catch
                End Try
            Next
            Tajhiz = Tajhiz + "-2"
        End If

        If chk_AllEib.Checked Then
            EibType = "-1"
        Else
            For Each dr As DataGridViewRow In DGV_EibType.Rows
                Try
                    EibType = EibType + dr.Cells(0).Value.ToString() + ","
                Catch
                End Try
            Next
            EibType = EibType + "-1"
        End If

        OrginalEibFormFromDate = IIf(chk_AllEibFomDate.Checked, -1, txt_OrginalEibFormFromDate.Value)
        OrginalEibFormToDate = IIf(chk_AllEibFomDate.Checked, -1, txt_OrginalEibFormToDate.Value)

        EibFormFromDate = IIf(chk_AllRegisterDate.Checked, -1, txt_RegistreFromDate.Value)
        EibFormToDate = IIf(chk_AllRegisterDate.Checked, -1, txt_RegisterToDate.Value)

        EibRefFromDate = IIf(chk_AllRefDdate.Checked, -1, txt_refFromDate.Value)
        EibReftoDate = IIf(chk_AllRefDdate.Checked, -1, txt_refToDate.Value)

        important = IIf(chk_AllImportant.Checked, -1, cmb_Important.SelectedValue)
        Vahed = IIf(chk_AllVahed.Checked, -1, cmb_Vahed.SelectedValue)
        PostTip = IIf(chk_AllTip.Checked, -1, cmb_PostTip.SelectedValue)
        PostType = IIf(chk_AllType.Checked, -1, cmb_PostType.SelectedValue)
        Group = IIf(chk_AllGroup.Checked, -1, cmb_Group.SelectedValue)
        EibFromNo = IIf(chk_AllEibFormNo.Checked, -1, txt_eibFormNo.Value)
        ShowPeiro = IIf(chk_ShowPeiro.Checked, -1, 1)
        If rb_Fix.Checked And rb_Undecided.Checked Then
            Is_Undecided = 1
        ElseIf rb_Fix.Checked And rb_Decided.Checked Then
            Is_Undecided = 0
        End If

        Dim rp As New Rp_EibFom

        Dim f As New Frm_Wait
        Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)

        Try
            If t.IsAlive Then
                t.Abort()
            End If
            t.Start()
        Catch ex As Exception
            MessageBoxFa.Show("Please try again")
        End Try
        Rp_EibformTableAdapter1.Fill(Ds_Rp1.rp_eibform, WorkDis, Post, ShowPeiro, Group, Vahed, EibFormFromDate, EibFormToDate, OrginalEibFormFromDate, OrginalEibFormToDate, PostType, EibRefFromDate, EibReftoDate, EibType, Tajhiz, EibFormState, Is_Undecided, EibFromNo, PostTip, important)
        Dim dt As DataTable = Ds_Rp1.rp_Eibform
        IsExpire(dt)
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        rp.SetParameterValue(rp.Parameter_Vahed.ParameterFieldName, IIf(Vahed = -1, "-", cmb_Vahed.Text))
        rp.SetParameterValue(rp.Parameter_Group.ParameterFieldName, IIf(Group = -1, "-", cmb_Group.Text))
        If Post.Split(",").Length <> 2 Then
            rp.SetParameterValue(rp.Parameter_Post.ParameterFieldName, "-")
        Else
            rp.SetParameterValue(rp.Parameter_Post.ParameterFieldName, DGV_Post.Rows(0).Cells(1).Value)
        End If
        If EibType.Split(",").Length <> 2 Then
            rp.SetParameterValue(rp.Parameter_EibType.ParameterFieldName, "-")
        Else
            rp.SetParameterValue(rp.Parameter_EibType.ParameterFieldName, DGV_EibType.Rows(0).Cells(1).Value)
        End If
        Dim Fixed As Integer
        Dim All As Integer

        Distinctcount(dt, Fixed, All)
        Dim frm_rp As New Frm_RpVw(rp, dt)
        rp.SetParameterValue(rp.Parameter_Fiexed.ParameterFieldName, Fixed)
        rp.SetParameterValue(rp.Parameter_All.ParameterFieldName, All)
        rp.SetParameterValue(rp.Parameter_NotFixed.ParameterFieldName, All - Fixed)
        If t.IsAlive Then
            t.Abort()
        End If
        frm_rp.ShowDialog()

    End Sub
    Private Sub IsExpire(ByRef dt As DataTable)
        Dim FixDate As String = ""
        Dim RegDate As String = ""
        Dim Fixed As FarsiDateFun
        Dim Reged As FarsiDateFun



        Dim dif As Integer
        For Each dr As DataRow In dt.Rows
            'If Not dr(7) Is DBNull.Value Then
            '    enddate = dr(7).ToString()
            'Else
            '    Continue For
            'End If
            If Not dr(9) Is DBNull.Value Then
                FixDate = dr(9).ToString()
            End If
            If Not dr(7) Is DBNull.Value Then
                RegDate = dr(7).ToString()
            Else
                Continue For
            End If
            If Not FixDate Is DBNull.Value Then
                If FixDate <> "" Then
                    Fixed = New FarsiDateFun(FixDate.Substring(0, 4), FixDate.Substring(5, 2), FixDate.Substring(8))
                Else
                    Fixed = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
                End If
            Else
                Fixed = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
            End If
            Reged = New FarsiDateFun(RegDate.Substring(0, 4), RegDate.Substring(5, 2), RegDate.Substring(8))
            dif = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(Reged), VB_Component.FarsiDateFun.F2E(Fixed))
            If Not dr(20) Is DBNull.Value Then
                If Not dr(20).ToString() = "" And dr(7) <> "" Then
                    'dr(19) = dr(19).ToString() + "*" + (dif - dr(20)).ToString()
                    'If dif > dr(20).ToString() Then
                    dr(20) = dr(20).ToString() - dif
                    'Else
                    '  dr(20) = 0
                    ' End If
                Else
                    dr(20) = 0
                End If
         

            End If
        Next
    End Sub
    Private Sub Distinctcount(ByVal dt As DataTable, ByRef Fixed As Integer, ByRef All As Integer)
        Dim Allarray As New ArrayList()
        Fixed = 0
        For Each dr As DataRow In dt.Rows
            If Not Allarray.Contains(dr(0)) Then
                Allarray.Add(dr(0))
                If Not dr(21) Is DBNull.Value Then
                    If (dr(9).ToString() <> "" And Not dr(9) Is DBNull.Value) Or dr(21) = 1 Then
                        Fixed = Fixed + 1
                    End If
                Else
                    If (dr(9).ToString() <> "" And Not dr(9) Is DBNull.Value) Then
                        Fixed = Fixed + 1
                    End If
                End If

            End If

        Next
        All = Allarray.Count
    End Sub
    Private Sub chk_AllRegisterDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllRegisterDate.CheckedChanged
        txt_RegistreFromDate.Enabled = Not chk_AllRegisterDate.Checked
        txt_RegisterToDate.Enabled = Not chk_AllRegisterDate.Checked
    End Sub

    Private Sub chk_AllTip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllTip.CheckedChanged
        cmb_PostTip.Enabled = Not chk_AllTip.Checked

    End Sub

    Private Sub chk_AllImportant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllImportant.CheckedChanged
        cmb_Important.Enabled = Not chk_AllImportant.Checked
    End Sub
    Private Sub Belataklif_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Belataklif_add.Click
        For Each dr As DataGridViewRow In DGV_Belataklif.Rows
            If dr.Cells(1).Value = cmb_Belataklif.Text Then
                Return
            End If
        Next
        Dim i As Integer = DGV_Belataklif.Rows.Add()
        If Not cmb_Belataklif.SelectedValue Is Nothing Then
            DGV_Belataklif.Rows(i).Cells(0).Value = cmb_Belataklif.SelectedValue
        Else
            DGV_Belataklif.Rows(i).Cells(0).Value = -1
        End If
        DGV_Belataklif.Rows(i).Cells(1).Value = cmb_Belataklif.Text
    End Sub

    Private Sub Blataklif_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blataklif_Del.Click
        If Not DGV_Belataklif.CurrentRow Is Nothing And DGV_Belataklif.Rows.Count >= 1 Then
            DGV_Belataklif.Rows.RemoveAt(DGV_Belataklif.CurrentRow.Index)
        End If
    End Sub

    Private Sub chk_AllNoDecided_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllNoDecided.CheckedChanged
        cmb_Belataklif.Enabled = Not chk_AllNoDecided.Checked
        DGV_Belataklif.Enabled = Not chk_AllNoDecided.Checked
        Belataklif_add.Enabled = Not chk_AllNoDecided.Checked
        Blataklif_Del.Enabled = Not chk_AllNoDecided.Checked
    End Sub


    Private Sub rb_Fix_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Fix.CheckedChanged
        If rb_Fix.Checked Then
            rb_allFix.Checked = True
        End If
        pl_Decide.Enabled = rb_Fix.Checked
        chk_AllNoDecided.Checked = True

    End Sub

    Private Sub rb_Undecided_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Undecided.CheckedChanged
        chk_AllNoDecided.Checked = True
        chk_AllNoDecided.Enabled = rb_Undecided.Checked
        cmb_Belataklif.Enabled = rb_Undecided.Checked
    End Sub

    Private Sub chk_AllType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllType.CheckedChanged
        cmb_PostType.Enabled = Not chk_AllType.Checked
    End Sub

    Private Sub rb_Decided_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Decided.CheckedChanged

    End Sub

    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click

        Dim s As New Frm_DeviceSelectWithPost()
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_TajhizNameForSave.Value = s.SelectedDevice.Text
            Srl_Pm_Tajhiz_ForSave = s.SelectedDevice.Srl
            Tajhiz_Add.Focus()
        End If
    End Sub

    Private Sub Tajhiz_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tajhiz_Add.Click
        For Each dr As DataGridViewRow In DGV_Tajhiz.Rows
            If dr.Cells(1).Value = txt_TajhizNameForSave.Text Then
                Return
            End If
        Next
        Dim i As Integer = DGV_Tajhiz.Rows.Add()
        If txt_TajhizNameForSave.Text <> "" Then
            DGV_Tajhiz.Rows(i).Cells(0).Value = Srl_Pm_Tajhiz_ForSave
        Else
            DGV_Tajhiz.Rows(i).Cells(0).Value = -1
        End If
        DGV_Tajhiz.Rows(i).Cells(1).Value = txt_TajhizNameForSave.Text
    End Sub

    Private Sub Tajhiz_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tajhiz_Delete.Click
        If Not DGV_Tajhiz.CurrentRow Is Nothing And DGV_Tajhiz.Rows.Count >= 1 Then
            DGV_Tajhiz.Rows.RemoveAt(DGV_Tajhiz.CurrentRow.Index)
        End If
    End Sub

    Private Sub Chk_AllTajhiz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllTajhiz.CheckedChanged
        txt_TajhizNameForSave.Enabled = Not Chk_AllTajhiz.Checked
        DGV_Tajhiz.Enabled = Not Chk_AllTajhiz.Checked
        Tajhiz_Add.Enabled = Not Chk_AllTajhiz.Checked
        Tajhiz_Delete.Enabled = Not Chk_AllTajhiz.Checked
        btn_SelectTajhiz.Enabled = Not Chk_AllTajhiz.Checked
    End Sub

    Private Sub cmb_Vahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Vahed.SelectedIndexChanged
        chk_AllGroup_CheckedChanged(Nothing, Nothing)
    End Sub
End Class