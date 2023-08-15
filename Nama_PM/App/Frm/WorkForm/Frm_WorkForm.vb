Imports System.Windows.Forms
Public Class Frm_WorkForm
    Dim BeginWrokOnThisDaye As New TimeSpan
    Dim EndWrokOnThisDaye As New TimeSpan
    Dim ZaribWrokOnThisDaye As Double = 0

    Dim BeginEzafekarOnThisDaye As New TimeSpan
    Dim EndEzafekarOnThisDaye As New TimeSpan
    Dim ZaribEzafekarOnThisDaye As Double = 0

    Dim ZaribGhablMovazafOnThisDaye As Double = 0

    Dim BeginEzafekarGheirMovaafOnThisDaye As New TimeSpan
    Dim EndEzafekarGheirMovaafOnThisDaye As New TimeSpan
    Dim ZaribEzafekarGheirMovaafOnThisDaye As Double = 0

    Dim Srl_Master As Integer = -1
    Dim _Ts_Sum_NafarSat As New TimeSpan
    Dim _Ts_Sum_EzafeKareFormKar As New TimeSpan
    Dim _Ts_Sum_EzafeKarTaradod As New TimeSpan
    Dim dr_NoSeq As DataRow
    Dim WrorkWithNoSeq As Boolean = True
    Dim dt_Workform_EibForm As New Ds_Pm.Pm_WorkForm_EibFormDataTable
    Dim dt_Workform_Kala As New Ds_Pm.Pm_WorkForm_KalaDataTable
    Dim fromload As Boolean = False
    Dim isTatil As Boolean = False
    Dim isExtraTatil As Boolean = False
    Dim Srl_WorkForm_Profile As Integer = 1
    Dim InsertNewPMExecute = -1

    Public Sub New(ByVal Srl_Master As Integer)
        InitializeComponent()
        initialForm(Srl_Master)
    End Sub

    Public Sub initialForm(ByVal Srl_Master As Integer)
        Me.Srl_Master = Srl_Master
        'cmb_PmWorkDis_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Frm_WorkForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_WorkSharh_WorkForm' table. You can move, or remove it, as needed.
        Me.Pm_WorkSharh_WorkFormTableAdapter.Fill(Me.Ds_Pm.Pm_WorkSharh_WorkForm)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        Me.Pm_CancelCauseTableAdapter.Fill(Me.Ds_Pm.Pm_CancelCause)
      
        Dim row As DataRow = Ds_Pm.Pm_CancelCause.NewRow()
        row("نام") = "انتخاب دلیل کنسلی"
        Ds_Pm.Pm_CancelCause.Rows.InsertAt(row, 0)
        cmb_cancelCuse.SelectedValue = -1
        Try
            Me.Pm_HazineCodeTableAdapter.Fill(Me.Ds_Pm.Pm_HazineCode, 1)
            Me.Pm_WorkDisTableAdapter.Fill(Me.Ds_Pm.Pm_WorkDis)
            Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
            Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
            Me.Pm_GroupMemberTableAdapter.Fill(Ds_Pm.Pm_GroupMember, -2, True)
            'chk_AllGroup.Checked = True
            ' اردهای نوید برای مقادیر پیش فرض
            Try
                cmb_HazineCode.SelectedValue = Setting.Default_Code_Hazine.PropValue
                Cmb_PostTo.SelectedValue = 574
                Cmb_PostFrom.SelectedValue = 574
                cmb_PmWorkDis.SelectedValue = 16843
            Catch ex As Exception

            End Try
           

            If Srl_Master = -1 Then
                chk_AllGroup_CheckedChanged(Nothing, Nothing)
                txt_Date.Value = Setting.TarikheJary
                Cmb_Group_SelectedIndexChanged(Nothing, Nothing)
            Else
               
                Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_WorkForm_Master", Srl_Master)
                Cmb_PostFrom.SelectedValue = dr("Srl_Pm_Post_From")
                Cmb_PostTo.SelectedValue = dr("Srl_Pm_Post_To")

                RemoveHandler chk_AllGroup.CheckedChanged, AddressOf chk_AllGroup_CheckedChanged
                RemoveHandler cmb_VAhed.SelectedIndexChanged, AddressOf cmb_VAhed_SelectedIndexChanged
                cmb_VAhed.SelectedValue = dr("Srl_Pm_Vahed")
                AddHandler cmb_VAhed.SelectedIndexChanged, AddressOf cmb_VAhed_SelectedIndexChanged
                AddHandler chk_AllGroup.CheckedChanged, AddressOf chk_AllGroup_CheckedChanged

                RemoveHandler Cmb_Group.SelectedIndexChanged, AddressOf Cmb_Group_SelectedIndexChanged
                Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, -1)

                Cmb_Group.SelectedValue = dr("Srl_Pm_Group").ToString
                Pm_GroupMemberTableAdapter.Fill(Ds_Pm.Pm_GroupMember, Cmb_Group.SelectedValue.ToString, Nothing)
                AddHandler Cmb_Group.SelectedIndexChanged, AddressOf Cmb_Group_SelectedIndexChanged

                '  chk_AllPerson.Checked = True
                Cmb_Sarparast.SelectedValue = dr("Srl_Pm_Ashkhas_Sarparast")

                'If Cmb_Sarparast.SelectedValue Is Nothing Then
                '    Dim Addedrow As DataRow = Ds_Pm.Pm_GroupMember.NewRow()
                '    Addedrow("نام") = BaseDataObject.DataAccess.ExecScalar("select  Family + '-' +Name from Pm_Ashkhas where srl=" + dr("Srl_Pm_Ashkhas_Sarparast").ToString())
                '    Addedrow("srl") = BaseDataObject.DataAccess.ExecScalar("select  srl_pm_ashkhas from Pm_Ashkhas where srl=" + dr("Srl_Pm_Ashkhas_Sarparast").ToString())
                '    Ds_Pm.Pm_GroupMember.Rows.InsertAt(Addedrow, Ds_Pm.Pm_GroupMember.Rows.Count)
                'End If
                Cmb_Sarparast.SelectedValue = dr("Srl_Pm_Ashkhas_Sarparast")
                cmb_PmWorkDis.SelectedValue = dr("Srl_Pm_WorkDis")
                cmb_HazineCode.SelectedValue = dr("Srl_HazineCode")
                txt_no.Value = dr("No")
                txt_Date.Value = dr("Tarikh")
                txt_FromKarNo.Value = dr("WorkFormNo")
                txt_WorkDis.Value = dr("WorkFormDis")
                txt_dis.Value = dr("Dis")
                txt_FormKarTarikh.Value = dr("WorkFormTarikh")
                ts_BeginWork.Value = dr("BeginWorkSat")
                ts_EndWork.Value = dr("EndWorkSat")
                ts_ZamaneKhroj.Value = dr("KhorojSat")
                'added by iman For load pm
                chk_IsMission.Checked = (IIf(dr("IsMission") Is DBNull.Value, False, dr("isMission")))
                Dim dt_PmProgram As DataTable = BaseDataObject.DataAccess.GetDataTable("select case when Pm_Hadese_KhesaratDevice.Srl_pm_TajhizName  IS null then" & _
                                                                               " Pm_Hadese_KhesaratDevice.Name else Pm_TajhizName.name   end as [نام تحهیز],Srl_Pm_Hadese_KhesaratDevice " & _
                                                                               " ,Pm_PmProgram .Srl,Srl_Pm_CancelCause from pm_PmProgram Join Pm_Hadese_KhesaratDevice On" & _
                                                                                " Pm_Hadese_KhesaratDevice .srl = Srl_Pm_Hadese_KhesaratDevice left JOIN Pm_ExecutePmProgram" & _
                                                                                " On Pm_ExecutePmProgram.Srl_Pm_PmProgram = Pm_PmProgram .Srl   Left JOIN" & _
                                                                                " Pm_TajhizName on Pm_TajhizName.Srl = Srl_pm_TajhizName " & _
                                                                                " where Srl_Pm_WorkForm = " + Srl_Master.ToString())
                If dt_PmProgram.Rows.Count > 0 Then
                    txt_DeviceKhesaratName.Value = dt_PmProgram.Rows(0)(0).ToString()
                    txt_Srl_DeviceKhesarat.Text = dt_PmProgram.Rows(0)(1).ToString()
                    Srl_PmProgramTpEdit = CInt(dt_PmProgram.Rows(0)(2))
                    Try
                        cmb_cancelCuse.SelectedValue = dt_PmProgram(0)(3).ToString
                    Catch
                    End Try
                    VAlidatePMProgramToSave = True
                End If

                If dr("TardodeDotarfe") = 1 Then
                    Rbtn_Yektarafe.Checked = True
                ElseIf dr("TardodeDotarfe") = 2 Then
                    rbtn_Dotarafe.Checked = True
                Else
                    rbtn_taradodBargasht.Checked = True
                End If

                rbtn_HamanRoz.Checked = CType(dr("HarkatHamanRoz"), Boolean)
                Pm_WorkFrom_DetailTableAdapter.Fill(Ds_Pm.Pm_WorkFrom_Detail, Srl_Master)
                btn_Cal_Click(Nothing, Nothing)
                If Not setlablecancle() Then
                    lb_MatchPM.ForeColor = Color.Red
                    lb_MatchPM.Text = "کنسل شده"
                    Chk_SabtBaTakhir.Checked = True
                End If
                If setlableExe() Then
                    lb_MatchPM.ForeColor = Color.Green
                    lb_MatchPM.Text = "طبق برنامه"
                End If
            End If
            SetDistance()
            Pm_WorkForm_KalaTableAdapter.Fill(dt_Workform_Kala, Srl_Master)
            Pm_WorkForm_EibFormTableAdapter.Fill(dt_Workform_EibForm, Srl_Master)
            MyBase.StatusStrip1.Items.Clear()
            MyBase.StatusStrip1.Items.Add("F7 اضافه نمودن اعضاي گروه")
            MyBase.StatusStrip1.Items.Add("-")
            MyBase.StatusStrip1.Items.Add("F2 ذخيره")
            MyBase.StatusStrip1.Items.Add("-")
            MyBase.StatusStrip1.Items.Add("F3 ثبت اقلام مصرفي")
            MyBase.StatusStrip1.Items.Add("-")
            MyBase.StatusStrip1.Items.Add("F4 فرم نقص")
            MyBase.StatusStrip1.Items.Add("-")
            MyBase.StatusStrip1.Items.Add("F5 پروژها")

            cmb_PmWorkDis_SelectedIndexChanged(Nothing, Nothing)
            txt_FromKarNo.Focus()
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
        End Try
        If CheckForEdit() Then
            btn_Save.Enabled = False

        End If
    End Sub
    Private Function setlableExe() As Boolean
        Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable("select * from Pm_WorkDis join Pm_WorkForm_Master " & _
" on Pm_WorkForm_Master .Srl_Pm_WorkDis =Pm_WorkDis .Srl " & _
" join Pm_ExecutePmProgram on Pm_ExecutePmProgram .Srl_Pm_WorkForm = Pm_WorkForm_Master.srl join Pm_PmProgram on Pm_PmProgram.Srl = Pm_ExecutePmProgram .Srl_Pm_PmProgram " & _
" where Pm_WorkForm_Master .Srl =" + Srl_Master.ToString() & _
" and ExecuteDate =Pm_PmProgram .Pm_Date ")
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function setlablecancle() As Boolean
        Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable("select * from Pm_WorkDis join Pm_WorkForm_Master " & _
" on Pm_WorkForm_Master .Srl_Pm_WorkDis =Pm_WorkDis .Srl " & _
" join Pm_ExecutePmProgram on Pm_ExecutePmProgram .Srl_Pm_WorkForm = Pm_WorkForm_Master.srl" & _
" where Pm_WorkForm_Master .Srl =" + Srl_Master.ToString() & _
" and Srl_Pm_CancelCause >0")
        If dt.Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.ControlKey Then
            Return
        End If
        MyBase.OnKeyUp(e)


    End Sub
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        'If e.KeyChar = Keys.ControlKey Then
        '    Return
        'End If
        MyBase.OnKeyPress(e)
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 18 Then
            Return
        End If
        If e.KeyCode = 17 Then
            'ElseIf e.KeyCode = 17 And e.Modifiers = Keys.Control Then

            '    'ElseIf e.KeyCode = Keys.C And e.Modifiers = Keys.Control Then
            '    '    If txt_WorkDis Is Me.ActiveControl Then
            '    '        Clipboard.SetText(txt_WorkDis.SelectedText)

            '    '    End If

            '    'ElseIf e.KeyCode = Keys.V And e.Modifiers = Keys.Control Then
            '    '    If Clipboard.ContainsText() Then
            '    '        txt_WorkDis.Text.Insert(txt_WorkDis.SelectionStart, Clipboard.GetText())
            '    '    End If

        ElseIf e.KeyCode = Keys.F7 Then
            btn_Add_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F2 Then
            btn_Save_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            Btn_KalaMasrafi_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            Btn_FormNaghs_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            Dim f As New Frm_CodeHazine
            f.ShowDialog()
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub
    Function getDistance() As DataRow
        Try
            Return BaseDataObject.DataAccess.GetRow("select Srl,Distance from Pm_Distance where Srl_Post1=" _
                                                                          + Cmb_PostFrom.SelectedValue.ToString + " and Srl_Post2=" + Cmb_PostTo.SelectedValue.ToString)
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function
    Sub SetDistance()
        Try
            If Cmb_PostFrom.SelectedValue Is Nothing Or Cmb_PostTo.SelectedValue Is Nothing Then
                Return
            End If
        Catch ex As Exception
            Return
        End Try

        Dim obj As DataRow = getDistance()
        If obj Is Nothing Then
            txt_Distance.Value = 0
        Else
            txt_Distance.Value = obj("Distance")
        End If
    End Sub
    Private Sub Cmb_PostFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_PostFrom.SelectedIndexChanged
        chk_IsMission.Checked = BaseDataObject.DataAccess.ExecScalar("select isnull(ismission,0) from pm_Postdetails where srl_Pm_Post = " + IIf(Cmb_PostFrom.SelectedValue Is Nothing, -1, Cmb_PostFrom.SelectedValue).ToString())
        SetDistance()
        cmb_PmWorkDis_SelectedIndexChanged(Nothing, Nothing)
        VAlidatePMProgramToSave = False
        lb_MatchPM.Text = ""
        txt_DeviceKhesaratName.Value = ""
        Srl_PmProgramTpEdit = -1
        Dim temp As Object
        temp = BaseDataObject.DataAccess.ExecScalar("select name from Pm_PostDetails ,pm_posttype where pm_posttype.srl=srl_pm_posttype and Srl_Pm_Post =" + IIf(Cmb_PostFrom.SelectedValue Is Nothing, -1, Cmb_PostFrom.SelectedValue).ToString())
        If Not temp Is Nothing Then
            lb_Posttype.Text = temp.ToString()
        Else
            lb_Posttype.Text = ""
        End If
    End Sub
    Private Sub Cmb_PostTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_PostTo.SelectedIndexChanged
        If CheckForRepeat() Then
            MessageBoxFa.Show("با این شماره فرم کار و تاریخ قبلا ثبت شده است ")
            txt_FromKarNo.Focus()
        End If
        SetDistance()
    End Sub
    Private Sub txt_Distance_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Distance.Leave
        Try
            'If txt_Distance.Value = 0 Then
            '    MessageBoxFa.Show("لطفا فاصله را بدرستي وارد کنيد")
            '    Return
            'End If
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Distance")
            dr("Srl_Post1") = Cmb_PostFrom.SelectedValue
            dr("Srl_Post2") = Cmb_PostTo.SelectedValue
            dr("Srl_Post2") = Cmb_PostTo.SelectedValue
            dr("Distance") = txt_Distance.Value
            dr("SubmitDate") = Setting.Now
            dr("Srl_SubmitUser") = Setting.Srl_User

            Dim obj As DataRow = getDistance()
            If obj Is Nothing Then
                BaseDataObject.DataAccess.Insert(dr, False)
            ElseIf obj("Distance") <> txt_Distance.Value Then
                'dr.Table.Columns.Remove(dr.Table.Columns(0).Caption)
                dr("Srl") = obj("Srl")
                BaseDataObject.DataAccess.Update(dr, 0)
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub chk_AllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllGroup.CheckedChanged
        Try
            If chk_AllGroup.Checked Then
                Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, -1)
            Else
                Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, cmb_VAhed.SelectedValue.ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmb_VAhed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_VAhed.SelectedIndexChanged
        chk_AllGroup_CheckedChanged(Nothing, Nothing)

        Cmb_Group_SelectedIndexChanged(Nothing, Nothing)
    End Sub
    Function GetDayeOfWeek(ByVal i As Integer) As Integer
        Select Case i
            Case 0 'yeshanbe
                Return 2
            Case 1 ' 2shanbe
                Return 3
            Case 2 ' 3 shanbe
                Return 4
            Case 3 '4 shanbe
                Return 5
            Case 4 '5 shanbe
                Return 6
            Case 5 'jome
                Return 7
            Case 6 'shanbe
                Return 1
        End Select
    End Function
    Sub GetWrokFormula()
        If txt_FormKarTarikh.Value.ToString.Length <> 10 Then
            Return
        End If

        If Cmb_PostFrom.SelectedValue Is Nothing Then
            Return
        End If

        Dim srl_dayOfWeek As Integer = GetDayeOfWeek(CInt(PublicFunction.GetDAte(txt_FormKarTarikh.Value.ToString).DayOfWeek))
        Dim query As String = "SELECT * FROM  dbo.Pm_WorkForm_Formula " & _
        "WHERE   (Srl_DayOfWeak = " + srl_dayOfWeek.ToString & _
        ") AND  (Srl_Pm_WorkType=@Srl_Pm_WorkType)" + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString

        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow(query.Replace("@Srl_Pm_WorkType", 1))
        If dr Is Nothing Then
            MessageBoxFa.Show("در اين روز فرمول تعريف نشده" - "معمولی")
            Return
        End If

        Dim tmp_togetHour As New TimeSelect
        tmp_togetHour.Value = dr("FromSat").ToString
        BeginWrokOnThisDaye = New TimeSpan(tmp_togetHour.Hour, tmp_togetHour.Minutes, 0)
        tmp_togetHour.Value = dr("ToSat").ToString
        EndWrokOnThisDaye = New TimeSpan(tmp_togetHour.Hour, tmp_togetHour.Minutes, 0)
        ZaribWrokOnThisDaye = dr("Zarib").ToString

        dr = BaseDataObject.DataAccess.GetRow(query.Replace("@Srl_Pm_WorkType", 2))
        If dr Is Nothing Then
            MessageBoxFa.Show("در اين روز فرمول تعريف نشده" + "-اضافه کار آخر وقت")
            Return
        End If
        tmp_togetHour = New TimeSelect
        tmp_togetHour.Value = dr("FromSat").ToString
        BeginEzafekarOnThisDaye = New TimeSpan(tmp_togetHour.Hour, tmp_togetHour.Minutes, 0)
        tmp_togetHour.Value = dr("ToSat").ToString
        EndEzafekarOnThisDaye = New TimeSpan(tmp_togetHour.Hour, tmp_togetHour.Minutes, 0)
        ZaribEzafekarOnThisDaye = dr("Zarib").ToString

        dr = BaseDataObject.DataAccess.GetRow(query.Replace("@Srl_Pm_WorkType", 3))
        If dr Is Nothing Then
            MessageBoxFa.Show("در اين روز فرمول تعريف نشده" + "-اضافه کار اول وقت")
            Return
        End If

        ZaribEzafekarOnThisDaye = dr("Zarib").ToString

        dr = BaseDataObject.DataAccess.GetRow(query.Replace("@Srl_Pm_WorkType", 4))
        If dr Is Nothing Then
            MessageBoxFa.Show("در اين روز فرمول تعريف نشده" + "- اضافه کار غیرموظف")
            Return
        End If
        tmp_togetHour = New TimeSelect
        tmp_togetHour.Value = dr("FromSat").ToString
        BeginEzafekarGheirMovaafOnThisDaye = New TimeSpan(tmp_togetHour.Hour, tmp_togetHour.Minutes, 0)
        tmp_togetHour.Value = dr("ToSat").ToString
        EndEzafekarGheirMovaafOnThisDaye = New TimeSpan(tmp_togetHour.Hour, tmp_togetHour.Minutes, 0)
        ZaribEzafekarGheirMovaafOnThisDaye = dr("Zarib").ToString
    End Sub
    Private Sub Btn_ReLoadFormul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetWrokFormula()
    End Sub
    Private Sub txt_Tarikh_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FormKarTarikh.ValueChanged
        If CheckForRepeat() Then
            MessageBoxFa.Show("با این شماره فرم کار و تاریخ قبلا ثبت شده است ")
            txt_FromKarNo.Focus()
        End If
        If txt_FormKarTarikh.Value.ToString.Length = 10 Then
            lbl_RozeHafte.Text = PublicFunction.GetDeyOfWeek(txt_FormKarTarikh.Value.ToString)
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_WorkForm_Formula_Profile", _
            "BeginDate<='" + txt_FormKarTarikh.Value.ToString + "' and EndDate>='" & _
                    txt_FormKarTarikh.Value.ToString + "' and Active=1 and Srl<>1")
            If dr Is Nothing Then
                txt_ProfileTarikh.Text = "در اين بازه زماني پروفايلي تعريف نشده"
                Srl_WorkForm_Profile = 1
            Else
                txt_ProfileTarikh.Text = dr("Name").ToString
                Srl_WorkForm_Profile = dr("Srl")
            End If
        End If
        ' VAlidatePMProgramToSave = False
        lb_MatchPM.Text = ""
        txt_DeviceKhesaratName.Value = ""
        Srl_PmProgramTpEdit = -1
        If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", txt_FormKarTarikh.Value) > 0) Then
            lbl_RozeHafte.BackColor = Color.Red
            lbl_RozeHafte.ForeColor = Color.White
        Else
            lbl_RozeHafte.BackColor = Color.White
            lbl_RozeHafte.ForeColor = Color.Black
        End If

        'baze mojaz ***********************************************************

        'Dim TaikhFormDate As String = ""
        'Dim jari As FarsiDateFun
        'Dim TaikhForm As FarsiDateFun
        'Dim dif As Integer
        'If Not txt_FormKarTarikh.Value Is DBNull.Value Then
        '    TaikhFormDate = txt_FormKarTarikh.Value.ToString()
        '    TaikhFormDate = txt_Date.Value.ToString()
        'End If
        ''TaikhForm = New FarsiDateFun(TaikhFormDate.Substring(0, 4), TaikhFormDate.Substring(5, 2), TaikhFormDate.Substring(8))

        'If TaikhFormDate <> "" Then
        '    TaikhForm = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))

        'Else
        '    TaikhForm = New FarsiDateFun(txt_FormKarTarikh.Value.ToString().Substring(0, 4), txt_FormKarTarikh.Value.ToString().Substring(5, 2), txt_FormKarTarikh.Value.ToString().Substring(8))

        'End If
        'jari = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
        'dif = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(TaikhForm), VB_Component.FarsiDateFun.F2E(jari))
        'If Setting.Mojaz_Date.PropValue < dif Then
        '    MessageBoxFa.Show("تست ")
        'End If


    End Sub
    Private Sub ts_EndWork_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ts_BeginWork.Value = "00:00" Then
            Return
        End If
    End Sub
    Private Sub Cmb_Group_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Group.SelectedIndexChanged
        Try
            If Cmb_Group.SelectedValue Is Nothing Then
                Return
            End If
            Pm_WorkFrom_DetailTableAdapter.Fill(Ds_Pm.Pm_WorkFrom_Detail, -1)

            Pm_GroupMemberTableAdapter.Fill(Ds_Pm.Pm_GroupMember, Cmb_Group.SelectedValue.ToString, Nothing)

            If Srl_Master = -1 Then
                For Each dr As DataRow In Ds_Pm.Pm_GroupMember
                    Dim drInsert As DataRow = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.NewRow

                    drInsert(0) = dr(2)
                    drInsert(1) = PublicFunction.GetSaat(_Ts_Sum_NafarSat)
                    drInsert(2) = PublicFunction.GetSaat(_Ts_Sum_EzafeKareFormKar)
                    drInsert(3) = PublicFunction.GetSaat(_Ts_Sum_EzafeKarTaradod)
                    drInsert(5) = dr(5) 'srl_Ashkhas
                    drInsert(23) = dr(6) 'srl_Ashkhas
                    drInsert.Item("تغییر توسط کاربر") = False
                    DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.Rows.Add(drInsert)
                    DataGridView1.Refresh()
                Next
            End If
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
        End Try
    End Sub
    Private Function CheckForRepeat() As Boolean
        If txt_FormKarTarikh.Value <> "" And txt_FromKarNo.Value <> "" And Not Cmb_PostTo.SelectedValue Is Nothing Then
            If BaseDataObject.DataAccess.ExecScalar("select isnull(count(*),0) from Pm_WorkForm_Master where WorkFormTarikh ='" + txt_FormKarTarikh.Value + "' and WorkFormNo ='" + txt_FromKarNo.Value + "' and Srl_Pm_Post_To=" + Cmb_PostTo.SelectedValue.ToString()) > 0 Then
                If Not Srl_Master <> -1 Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function
    Private Function Check() As Boolean

        Dim TaikhFormDate As String = ""
        Dim jari As FarsiDateFun
        Dim TaikhForm As FarsiDateFun
        Dim dif As Integer
        If Not txt_FormKarTarikh.Value Is DBNull.Value Then
            TaikhFormDate = txt_FormKarTarikh.Value.ToString()

        End If
       
        If TaikhFormDate <> "" Then
            TaikhForm = New FarsiDateFun(txt_FormKarTarikh.Value.ToString().Substring(0, 4), txt_FormKarTarikh.Value.ToString().Substring(5, 2), txt_FormKarTarikh.Value.ToString().Substring(8))

        Else
            TaikhForm = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))

        End If
        jari = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
        dif = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(TaikhForm), VB_Component.FarsiDateFun.F2E(jari))
        If Setting.Mojaz_Date.PropValue < dif Then
            Return True
            txt_FromKarNo.Focus()
        End If
        Return False
    End Function
    Private Function CheckForEdit() As Boolean

        Dim TaikhSabt As String = ""
        Dim jari As FarsiDateFun
        Dim TaikhSabtForm As FarsiDateFun
        Dim diff As Integer
        If Not txt_Date.Value Is DBNull.Value Then
            TaikhSabt = txt_Date.Value.ToString()

        End If

        If TaikhSabt <> "" Then
            TaikhSabtForm = New FarsiDateFun(txt_Date.Value.ToString().Substring(0, 4), txt_Date.Value.ToString().Substring(5, 2), txt_Date.Value.ToString().Substring(8))

        Else
            TaikhSabtForm = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))

        End If
        jari = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
        diff = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(TaikhSabtForm), VB_Component.FarsiDateFun.F2E(jari))
        If Setting.Mojaz_Date_Edit.PropValue < diff Then
            Return True
            txt_FromKarNo.Focus()
        End If
        Return False
    End Function

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim Hour24 As New TimeSpan(24, 0, 0)

        If Check() Then
            MessageBoxFa.Show("خارج از بازه مجاز برای ثبت")
            Return
        End If
        For Each dtg As DataGridViewRow In DataGridView1.Rows
            Try
                Dim temp As New TimeSpan(dtg.Cells(2).Value.ToString.Substring(0, dtg.Cells(3).Value.ToString.IndexOf(":")), dtg.Cells(2).Value.ToString.Substring(dtg.Cells(2).Value.ToString.IndexOf(":") + 1), 0)
                If (temp > Hour24) Then
                    MessageBoxFa.Show("اضافه کار نمی تواند بیشتر از 24 ساعت باشد!")
                    Return
                End If
            Catch
            End Try
        Next
        If chk_ForceCancle.Checked And cmb_cancelCuse.SelectedValue < 1 Then
            MessageBoxFa.Show("لطفا دلیل کنسلی را انتخاب نمائید")
            cmb_cancelCuse.Focus()
            Return
        End If
        If Chk_SabtBaTakhir.Checked And cmb_cancelCuse.SelectedValue < 1 Then
            MessageBoxFa.Show("لطفا دلیل کنسلی را انتخاب نمائید")
            cmb_cancelCuse.Focus()
            Return
        End If
        If CheckForRepeat() Then
            MessageBoxFa.Show("با این شماره فرم کار و تاریخ قبلا ثبت شده است ")
            txt_FromKarNo.Focus()
            Return
        End If

        If Not VAlidatePMProgramToSave Then
            MessageBoxFa.Show("برنامه PM اين دستگاه ثبت نشده ...شما قادر به ذخيره سازي اين فرم کار نيستيد")
            Return
        End If

        If txt_FromKarNo.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا شماره فرم کار را پر کنيد")
            txt_FromKarNo.Focus()
            Return
        End If

        If cmb_PmWorkDis.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا يک شرح کار را انتخاب کنيد")
            txt_FromKarNo.Focus()
            Return
        End If

        'If Srl_Master <> -1 Then
        '    If (BaseDataObject.DataAccess.ExistNum("Pm_WorkForm_Master", "No", txt_no.Value _
        '         , "Srl<>" + Srl_Master.ToString) > 0) Then
        '        MessageBoxFa.Show("شماره فرم کار تکراري است")
        '        txt_no.Focus()
        '        Return
        '    End If
        'Else
        '    If (BaseDataObject.DataAccess.ExistNum("Pm_WorkForm_Master", "No", txt_no.Value) > 0) Then
        '        MessageBoxFa.Show("شماره فرم کار تکراري است")
        '        txt_no.Focus()
        '        Return
        '    End If
        'End If

        If DataGridView1.Rows.Count = 0 Then
            MessageBoxFa.Show("براي ثبت فرم کار حداقل يک شخص را انتخاب کنيد")
            BaseDataObject.DataAccess.RollBack()
            Return
            'Else
            'For Each dtgv As DataGridViewRow In DataGridView1.Rows
            '        'MessageBoxFa.Show(txt_FormKarTarikh.Value.ToString())
            '        'Dim dt0 As DataTable = BaseDataObject.DataAccess.GetDataTable("select dbo.Pm_WorkForm_Master.[No] As [شماره] , dbo.Pm_Ashkhas.[Name] As [نام] , dbo.Pm_Ashkhas.[Family] As [فامیل]" & _
            '        '                                                              "from Pm_WorkForm_Master Inner join dbo.Pm_WorkFrom_Detail on Pm_WorkForm_Master.Srl = Pm_WorkFrom_Detail.Srl_Pm_WorkForm_Master Inner join Pm_Ashkhas on Pm_Ashkhas.Srl=Pm_WorkFrom_Detail.Srl_Pm_Ashkhas" & _
            '        '                                              "where Pm_WorkFrom_Detail.WorkFormTarikh='" + txt_FormKarTarikh.Value.ToString() + "' and Pm_WorkFrom_Detail.Srl_Pm_Ashkhas=" + dtgv.Cells(5).Value)

            '        'txt_FormKarTarikh.Value.ToString()
            '        'dtgv.Cells(5).Value
            '        Dim dr_m As DataRow = dt0.NewRow
            '        For Each dr_m In dt0.Rows
            '            Try
            '                MessageBoxFa.Show("برای " + dr_m("نام") + dr_m("فامیل") + "در این تاریخ فرم کار دیگری با شماره فرم" + dr_m("شماره") + "ثبت شده است")
            '            Catch

            '            End Try
            '        Next

            '    Next

        End If

        If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", txt_FormKarTarikh.Value) > 0) Then
            isTatil = True
        End If

        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_WorkForm_Master")
        dr("Srl_Pm_Post_From") = Cmb_PostFrom.SelectedValue
        dr("Srl_Pm_Post_To") = Cmb_PostTo.SelectedValue
        dr("Srl_Pm_Group") = Cmb_Group.SelectedValue
        dr("Srl_Pm_Vahed") = cmb_VAhed.SelectedValue
        dr("Srl_Pm_WorkDis") = cmb_PmWorkDis.SelectedValue
        dr("Srl_HazineCode") = cmb_HazineCode.SelectedValue
        dr("Srl_Pm_Ashkhas_Sarparast") = IIf(Cmb_Sarparast.SelectedValue Is Nothing, DBNull.Value, Cmb_Sarparast.SelectedValue)
        dr("No") = IIf(txt_no.Text <> "", txt_no.Value, 0)
        dr("Tarikh") = txt_Date.Value
        dr("WorkFormNo") = txt_FromKarNo.Value
        dr("WorkFormDis") = txt_WorkDis.Value
        dr("Dis") = txt_dis.Value
        dr("WorkFormTarikh") = txt_FormKarTarikh.Value
        dr("BeginWorkSat") = PublicFunction.GetSaat(ts_BeginWork.time)
        dr("EndWorkSat") = PublicFunction.GetSaat(ts_EndWork.time)
        dr("KhorojSat") = PublicFunction.GetSaat(ts_ZamaneKhroj.time)
        dr("IsMission") = chk_IsMission.Checked
        If txt_DeviceKhesaratName.Text <> "" Then
            dr("Devicename") = txt_DeviceKhesaratName.Value
        End If
        If Rbtn_Yektarafe.Checked Then
            dr("TardodeDotarfe") = 1
        ElseIf rbtn_Dotarafe.Checked Then
            dr("TardodeDotarfe") = 2
        Else
            dr("TardodeDotarfe") = 3
        End If
        dr("HarkatHamanRoz") = rbtn_HamanRoz.Checked
        dr("Srl_SubmitUser") = Setting.Srl_User
        dr("SubmitDate") = Setting.Now
        dr("srl_DayOfWeek") = GetDayeOfWeek(CInt(PublicFunction.GetDAte(txt_FormKarTarikh.Value.ToString).DayOfWeek))
        BaseDataObject.DataAccess.BeginTransaction()
        If Srl_Master = -1 Then
            dr("No") = BaseDataObject.DataAccess.ExecScalar("select isnull(max(No),0)+1 from Pm_WorkForm_Master")
        End If
        If Srl_Master <> -1 Then

            dr("srl") = Srl_Master

            If Not BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If

            If Not BaseDataObject.DataAccess.Delete("Pm_WorkForm_EibForm", " Srl_Pm_WorkForm_Master=" + Srl_Master.ToString) Or _
                 Not BaseDataObject.DataAccess.Delete("Pm_WorkForm_KalaMasrafi", " Srl_Pm_WorkForm_Master=" + Srl_Master.ToString) Or _
                 Not BaseDataObject.DataAccess.Delete("Pm_WorkFrom_Detail", " Srl_Pm_WorkForm_Master=" + Srl_Master.ToString) Or _
                 Not BaseDataObject.DataAccess.Delete("Pm_ExecutePmProgram", "(srl_Pm_WorkForm = " + Srl_Master.ToString + ")OR(Srl_Pm_PmProgram =" + Srl_PmProgramTpEdit.ToString() + " and Srl_Pm_WorkForm is null)") Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If
            'Edit pm_program
            Dim dr_Pm_PmProgram As DataRow = BaseDataObject.DataAccess.NewRow("Pm_ExecutePmProgram")
            dr_Pm_PmProgram("Srl_Pm_PmProgram") = Srl_PmProgramTpEdit
            dr_Pm_PmProgram("Srl_Pm_WorkForm") = Srl_Master
            dr_Pm_PmProgram("ExecuteDate") = txt_FormKarTarikh.Value
            If Chk_SabtBaTakhir.Checked Then
                dr_Pm_PmProgram("Srl_Pm_CancelCause") = cmb_cancelCuse.SelectedValue.ToString()
            Else
                dr_Pm_PmProgram("Srl_Pm_CancelCause") = DBNull.Value
            End If

            If Not BaseDataObject.DataAccess.Insert(dr_Pm_PmProgram, 0) Then
                MessageBoxFa.Show("خطا در ثبت برنامه pm")
                BaseDataObject.DataAccess.RollBack()

            End If



            For Each dtg As DataGridViewRow In DataGridView1.Rows
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_WorkFrom_Detail")
                dr_details("Srl_Pm_WorkForm_Master") = Srl_Master
                dr_details("Srl_SubmitUser") = Setting.Srl_User
                dr_details("SubmitDate") = Setting.Now
                dr_details("Srl_Pm_Ashkhas") = dtg.Cells("Srl_Pm_Ashkhas").Value
                dr_details("WorkFormTarikh") = txt_FormKarTarikh.Value
                dr_details("WorkFormNo") = txt_FromKarNo.Value
                dr_details("UserChanged") = dtg.Cells("UserChanged").Value
                dr_details("Srl_Pm_Group") = Cmb_Group.SelectedValue
                dr_details("MazadEzafeKar") = dtg.Cells("MazadEzafeKar").Value
                dr_details("Weight") = IIf(dtg.Cells("Weight").Value Is DBNull.Value, 1, dtg.Cells("Weight").Value)


                If CType(dtg.Cells("UserChanged").Value, Boolean) = True Then
                    dr_details("Srl_Pm_Post_From") = dtg.Cells("Srl_Pm_Post_From").Value
                    dr_details("Srl_Pm_Post_To") = dtg.Cells("Srl_Pm_Post_To").Value
                    dr_details("Srl_Pm_Vahed") = dtg.Cells("Srl_Pm_Vahed").Value
                    dr_details("Srl_Pm_WorkDis") = dtg.Cells("Srl_Pm_WorkDis").Value
                    dr_details("Srl_HazineCode") = dtg.Cells("Srl_HazineCode").Value
                    dr_details("WorkFormDis") = dtg.Cells("WorkFormDis").Value
                    dr_details("Dis") = dtg.Cells("Dis").Value
                    dr_details("SatKAr") = CurrectTime(dtg.Cells("SatKar").Value)

                    '============================================================================================
                    dr_details("EzafeKarTaradod") = dtg.Cells("EzafeKarTaradod").Value
                    'Dim ts_temp_MazadEzafeKar As New TimeSelect
                    'ts_temp_MazadEzafeKar.Value = dr_details("MazadEzafeKar")
                    'Dim ts_temp_EzafeKAr As New TimeSelect
                    'ts_temp_EzafeKAr.Value = dtg.Cells("EzafeKAr").Value
                    'Dim ts_temp_taradod As New TimeSelect
                    'ts_temp_taradod.Value = dr_details("EzafeKarTaradod")
                    'dr_details("EzafeKAr") = GetEzafeKarValue(ts_temp_EzafeKAr.time, ts_temp_taradod.time, ts_temp_MazadEzafeKar.time)
                    dr_details("EzafeKAr") = dtg.Cells("EzafeKAr").Value
                    '============================================================================================

                    dr_details("HarkatHamanRoz") = dtg.Cells("HarkatHamanRoz").Value
                    If Rbtn_Yektarafe.Checked Then
                        dr_details("TardodeDotarfe") = 1
                    ElseIf rbtn_Dotarafe.Checked Then
                        dr_details("TardodeDotarfe") = 2
                    Else
                        dr_details("TardodeDotarfe") = 3
                    End If
                    dr_details("BeginWorkSat") = dtg.Cells("BeginWorkSat").Value.ToString
                    dr_details("EndWorkSat") = dtg.Cells("EndWorkSat").Value.ToString
                    dr_details("KhorojSat") = dtg.Cells("KhorojSat").Value.ToString
                Else
                    dr_details("Srl_Pm_Post_From") = Cmb_PostFrom.SelectedValue
                    dr_details("Srl_Pm_Post_To") = Cmb_PostTo.SelectedValue
                    dr_details("Srl_Pm_Vahed") = cmb_VAhed.SelectedValue
                    dr_details("Srl_Pm_WorkDis") = cmb_PmWorkDis.SelectedValue
                    dr_details("Srl_HazineCode") = cmb_HazineCode.SelectedValue
                    dr_details("WorkFormDis") = txt_WorkDis.Value
                    dr_details("Dis") = txt_dis.Value
                    dr_details("SatKAr") = CurrectTime(PublicFunction.GetSaat(_Ts_Sum_NafarSat))

                    '============================================================================================
                    'Dim ts_temp_MazadEzafeKar As New TimeSelect
                    'ts_temp_MazadEzafeKar.Value = dr_details("MazadEzafeKar")
                    'dr_details("EzafeKAr") = GetEzafeKarValue(_Ts_Sum_EzafeKareFormKar, _Ts_Sum_EzafeKarTaradod, ts_temp_MazadEzafeKar.time)
                    dr_details("EzafeKAr") = PublicFunction.GetSaat(_Ts_Sum_EzafeKareFormKar)
                    dr_details("EzafeKarTaradod") = PublicFunction.GetSaat(_Ts_Sum_EzafeKarTaradod)
                    '============================================================================================

                    dr_details("HarkatHamanRoz") = rbtn_HamanRoz.Checked
                    If Rbtn_Yektarafe.Checked Then
                        dr_details("TardodeDotarfe") = 1
                    ElseIf rbtn_Dotarafe.Checked Then
                        dr_details("TardodeDotarfe") = 2
                    Else
                        dr_details("TardodeDotarfe") = 3
                    End If
                    dr_details("BeginWorkSat") = PublicFunction.GetSaat(ts_BeginWork.time)
                    dr_details("EndWorkSat") = PublicFunction.GetSaat(ts_EndWork.time)
                    dr_details("KhorojSat") = PublicFunction.GetSaat(ts_ZamaneKhroj.time)
                End If

                If Not BaseDataObject.DataAccess.Insert(dr_details, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next

            If Not BaseDataObject.DataAccess.Delete("Pm_WorkForm_KalaMasrafi", "Srl_Pm_WorkForm_Master=" + Srl_Master.ToString()) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If

            BaseDataObject.DataAccess.Delete("Pm_WorkForm_KalaMasrafi", "Srl_Pm_WorkForm_Master=" + Srl_Master.ToString())
            For Each row As DataRow In dt_Workform_Kala
                Dim dr_de As DataRow = BaseDataObject.DataAccess.NewRow("Pm_WorkForm_KalaMasrafi")
                dr_de("Srl_Pm_WorkForm_Master") = Srl_Master
                dr_de("Srl_Kala") = row(1)
                dr_de("Tedad") = row(3)
                dr_de("Srl_SubmitUser") = Setting.Srl_User
                dr_de("SubmitDate") = Setting.Now

                If Not BaseDataObject.DataAccess.Insert(dr_de, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next

            BaseDataObject.DataAccess.Delete("Pm_workform_EibForm", "Srl_Pm_WorkForm_Master=" + Srl_Master.ToString())

            For Each row As DataRow In dt_Workform_EibForm
                If row.RowState = DataRowState.Deleted Then
                    Continue For
                End If
                Dim dr_Eib As DataRow = BaseDataObject.DataAccess.GetRow("pm_EibFormMaster", "OrginalEibFormNumber='" + row(1).ToString() + "' AND OriginalEibFormDate='" + row(2).ToString() + "'")
                If Not dr_Eib Is Nothing Then
                    dr_Eib("WorkFormNumber") = txt_FromKarNo.Value
                    dr_Eib("WorkDis") = dr_Eib("WorkDis") + "-- رفع شده بر اساس فرم کار شماره" + txt_FromKarNo.Value
                    dr_Eib("EibFixDate") = txt_FormKarTarikh.Value

                    If Not BaseDataObject.DataAccess.Update(dr_Eib, 0) Then
                        MessageBoxFa.Show("خطا در ثبت اطلاعات")
                        BaseDataObject.DataAccess.RollBack()
                        Return
                    End If
                Else
                    dr_Eib = BaseDataObject.DataAccess.NewRow("pm_eibFormMaster")
                    dr_Eib("OrginalEibFormNumber") = row(1).ToString()
                    dr_Eib("OriginalEibFormDate") = row(2).ToString()
                    dr_Eib("EibFormNumber") = BaseDataObject.DataAccess.FindMax("Pm_EibFormMaster", "EibFormNumber")
                    dr_Eib("EibFormDate") = txt_Date.Value
                    dr_Eib("WorkFormNumber") = txt_FromKarNo.Value
                    dr_Eib("WorkDis") = dr_Eib("WorkDis") + "-- رفع شده بر اساس فرم کار شماره" + txt_FromKarNo.Value
                    dr_Eib("EibFixDate") = txt_FormKarTarikh.Value
                    dr_Eib("Srl_Pm_Post") = Cmb_PostFrom.SelectedValue
                    dr_Eib("Srl_Pm_Vahed") = cmb_VAhed.SelectedValue
                    dr_Eib("Srl_Pm_Group") = Cmb_Group.SelectedValue

                    If Not BaseDataObject.DataAccess.Insert(dr_Eib, False) Then
                        MessageBoxFa.Show("خطا در ثبت اطلاعات")
                        BaseDataObject.DataAccess.RollBack()
                        Return
                    End If
                End If

                Dim dr_de As DataRow = BaseDataObject.DataAccess.NewRow("Pm_workform_EibForm")
                dr_de("Srl_Pm_WorkForm_Master") = Srl_Master
                dr_de("EibFormNo") = row(1)
                dr_de("EibFormDate") = row(2)
                dr_de("Srl_SubmitUser") = Setting.Srl_User
                dr_de("SubmitDate") = Setting.Now

                If Not BaseDataObject.DataAccess.Insert(dr_de, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next

            If Not BaseDataObject.DataAccess.Commit Then
                MessageBoxFa.Show("ثبت اطلاعات با مشكل مواجه شد")
            Else
                MessageBoxFa.Show("اطلاعات با موفقیت ثبت شد")
            End If

            Close()
        Else
            Dim Srl_Maseter As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)

            If Srl_Maseter = -1 Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If

            For Each dtg As DataGridViewRow In DataGridView1.Rows
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_WorkFrom_Detail")
                dr_details("Srl_Pm_WorkForm_Master") = Srl_Maseter
                dr_details("Srl_SubmitUser") = Setting.Srl_User
                dr_details("SubmitDate") = Setting.Now
                dr_details("Srl_Pm_Ashkhas") = dtg.Cells("Srl_Pm_Ashkhas").Value
                dr_details("WorkFormTarikh") = txt_FormKarTarikh.Value
                dr_details("WorkFormNo") = txt_FromKarNo.Value
                dr_details("UserChanged") = dtg.Cells("UserChanged").Value
                dr_details("Srl_Pm_Group") = Cmb_Group.SelectedValue
                dr_details("MazadEzafeKar") = dtg.Cells("MazadEzafeKar").Value
                dr_details("Weight") = IIf(dtg.Cells("Weight").Value Is DBNull.Value, 1, dtg.Cells("Weight").Value)

                If CType(dtg.Cells("UserChanged").Value, Boolean) = True Then
                    dr_details("Srl_Pm_Post_From") = dtg.Cells("Srl_Pm_Post_From").Value
                    dr_details("Srl_Pm_Post_To") = dtg.Cells("Srl_Pm_Post_To").Value
                    dr_details("Srl_Pm_Vahed") = dtg.Cells("Srl_Pm_Vahed").Value
                    dr_details("Srl_Pm_WorkDis") = dtg.Cells("Srl_Pm_WorkDis").Value
                    dr_details("Srl_HazineCode") = dtg.Cells("Srl_HazineCode").Value
                    dr_details("WorkFormDis") = dtg.Cells("WorkFormDis").Value
                    dr_details("Dis") = dtg.Cells("Dis").Value
                    dr_details("SatKAr") = CurrectTime(dtg.Cells("SatKar").Value)

                    '============================================================================================
                    dr_details("EzafeKarTaradod") = dtg.Cells("EzafeKarTaradod").Value

                    'Dim ts_temp_MazadEzafeKar As New TimeSelect
                    'ts_temp_MazadEzafeKar.Value = dr_details("MazadEzafeKar")

                    'Dim ts_temp_EzafeKAr As New TimeSelect
                    'ts_temp_EzafeKAr.Value = dtg.Cells("EzafeKAr").Value

                    'Dim ts_temp_taradod As New TimeSelect
                    'ts_temp_taradod.Value = dr_details("EzafeKarTaradod")

                    'dr_details("EzafeKAr") = GetEzafeKarValue(ts_temp_EzafeKAr.time, ts_temp_taradod.time, ts_temp_MazadEzafeKar.time)
                    dr_details("EzafeKAr") = dtg.Cells("EzafeKAr").Value
                    '============================================================================================

                    dr_details("HarkatHamanRoz") = dtg.Cells("HarkatHamanRoz").Value
                    dr_details("TardodeDotarfe") = dtg.Cells("TardodeDotarfe").Value
                    dr_details("BeginWorkSat") = dtg.Cells("BeginWorkSat").Value.ToString
                    dr_details("EndWorkSat") = dtg.Cells("EndWorkSat").Value.ToString
                    dr_details("KhorojSat") = dtg.Cells("KhorojSat").Value.ToString
                Else
                    dr_details("Srl_Pm_Post_From") = Cmb_PostFrom.SelectedValue
                    dr_details("Srl_Pm_Post_To") = Cmb_PostTo.SelectedValue
                    dr_details("Srl_Pm_Vahed") = cmb_VAhed.SelectedValue
                    dr_details("Srl_Pm_WorkDis") = cmb_PmWorkDis.SelectedValue
                    dr_details("Srl_HazineCode") = cmb_HazineCode.SelectedValue
                    dr_details("WorkFormDis") = txt_WorkDis.Value
                    dr_details("Dis") = txt_dis.Value
                    dr_details("SatKAr") = CurrectTime(PublicFunction.GetSaat(_Ts_Sum_NafarSat))
                    '============================================================================================
                    Dim ts_temp_MazadEzafeKar As New TimeSelect
                    ts_temp_MazadEzafeKar.Value = IIf(dr_details("MazadEzafeKar") Is DBNull.Value, "", dr_details("MazadEzafeKar"))

                    'dr_details("EzafeKAr") = GetEzafeKarValue(_Ts_Sum_EzafeKareFormKar, _Ts_Sum_EzafeKarTaradod, ts_temp_MazadEzafeKar.time)
                    dr_details("EzafeKAr") = PublicFunction.GetSaat(_Ts_Sum_EzafeKareFormKar)
                    dr_details("EzafeKarTaradod") = PublicFunction.GetSaat(_Ts_Sum_EzafeKarTaradod)
                    '============================================================================================

                    dr_details("HarkatHamanRoz") = rbtn_HamanRoz.Checked
                    If Rbtn_Yektarafe.Checked Then
                        dr_details("TardodeDotarfe") = 1
                    ElseIf rbtn_Dotarafe.Checked Then
                        dr_details("TardodeDotarfe") = 2
                    Else
                        dr_details("TardodeDotarfe") = 3
                    End If
                    dr_details("BeginWorkSat") = PublicFunction.GetSaat(ts_BeginWork.time)
                    dr_details("EndWorkSat") = PublicFunction.GetSaat(ts_EndWork.time)
                    dr_details("KhorojSat") = PublicFunction.GetSaat(ts_ZamaneKhroj.time)
                End If

                If Not BaseDataObject.DataAccess.Insert(dr_details, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next

            For Each row As DataRow In dt_Workform_EibForm
                If row.RowState = DataRowState.Deleted Then
                    Continue For
                End If

                Dim dr_Eib As DataRow = BaseDataObject.DataAccess.GetRow("pm_EibFormMaster", "OrginalEibFormNumber='" + row(1).ToString() + "' AND OriginalEibFormDate='" + row(2).ToString() + "'")
                If Not dr_Eib Is Nothing Then

                    dr_Eib("WorkFormNumber") = txt_FromKarNo.Value
                    dr_Eib("WorkDis") = dr_Eib("WorkDis") + "-- رفع شده بر اساس فرم کار شماره" + txt_FromKarNo.Value
                    dr_Eib("EibFixDate") = txt_FormKarTarikh.Value

                    If Not BaseDataObject.DataAccess.Update(dr_Eib, 0) Then
                        MessageBoxFa.Show("خطا در ثبت اطلاعات")
                        BaseDataObject.DataAccess.RollBack()
                        Return
                    End If
                Else
                    dr_Eib = BaseDataObject.DataAccess.NewRow("pm_eibFormMaster")
                    dr_Eib("OrginalEibFormNumber") = row(1).ToString()
                    dr_Eib("OriginalEibFormDate") = row(2).ToString()
                    dr_Eib("EibFormNumber") = BaseDataObject.DataAccess.FindMax("Pm_EibFormMaster", "EibFormNumber")
                    dr_Eib("EibFormDate") = txt_Date.Value
                    dr_Eib("WorkFormNumber") = txt_FromKarNo.Value
                    dr_Eib("WorkDis") = dr_Eib("WorkDis") + "-- رفع شده بر اساس فرم کار شماره" + txt_FromKarNo.Value
                    dr_Eib("EibFixDate") = txt_FormKarTarikh.Value
                    dr_Eib("Srl_Pm_Post") = Cmb_PostFrom.SelectedValue
                    dr_Eib("Srl_Pm_Vahed") = cmb_VAhed.SelectedValue
                    dr_Eib("Srl_Pm_Group") = Cmb_Group.SelectedValue

                    If Not BaseDataObject.DataAccess.Insert(dr_Eib, False) Then
                        MessageBoxFa.Show("خطا در ثبت اطلاعات")
                        BaseDataObject.DataAccess.RollBack()
                        Return
                    End If
                End If

                Dim dr_de As DataRow = BaseDataObject.DataAccess.NewRow("Pm_workform_EibForm")
                dr_de("Srl_Pm_WorkForm_Master") = Srl_Maseter
                dr_de("EibFormNo") = row(1)
                dr_de("EibFormDate") = row(2)
                dr_de("Srl_SubmitUser") = Setting.Srl_User
                dr_de("SubmitDate") = Setting.Now

                If Not BaseDataObject.DataAccess.Insert(dr_de, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next

            For Each row As DataRow In dt_Workform_Kala
                Dim dr_de As DataRow = BaseDataObject.DataAccess.NewRow("Pm_WorkForm_KalaMasrafi")
                dr_de("Srl_Pm_WorkForm_Master") = Srl_Maseter
                dr_de("Srl_Kala") = row(1)
                dr_de("Tedad") = row(3)
                dr_de("Srl_SubmitUser") = Setting.Srl_User
                dr_de("SubmitDate") = Setting.Now

                If Not BaseDataObject.DataAccess.Insert(dr_de, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next


            'ثبت برنامه پي ام
            Dim dr_Pm_PmProgram As DataRow = BaseDataObject.DataAccess.NewRow("Pm_ExecutePmProgram")
            dr_Pm_PmProgram("Srl_Pm_PmProgram") = Srl_PmProgramTpEdit
            dr_Pm_PmProgram("Srl_Pm_WorkForm") = Srl_Maseter
            dr_Pm_PmProgram("ExecuteDate") = txt_FormKarTarikh.Value
            dr_Pm_PmProgram("Srl_Pm_CancelCause") = IIf(Chk_SabtBaTakhir.Checked Or chk_ForceCancle.Checked, cmb_cancelCuse.SelectedValue.ToString, DBNull.Value)
            If InsertNewPMExecute = -1 Then
                If Srl_PmProgramTpEdit <> -1 Then
                    dr_Pm_PmProgram("srl") = BaseDataObject.DataAccess.ExecScalar("select srl from Pm_ExecutePmProgram where Srl_Pm_PmProgram =" + Srl_PmProgramTpEdit.ToString + " and Srl_Pm_WorkForm is null  ")
                    'BaseDataObject.DataAccess.RollBack()
                    If Not BaseDataObject.DataAccess.Update(dr_Pm_PmProgram, 0) Then
                        MessageBoxFa.Show("خطا در ثبت برنامه pm")
                        BaseDataObject.DataAccess.RollBack()
                    Else
                        VAlidatePMProgramToSave = False
                        Srl_PmProgramTpEdit = -1
                    End If
                End If
            Else
                If Not BaseDataObject.DataAccess.Insert(dr_Pm_PmProgram, False) Then
                    MessageBoxFa.Show("خطا در ثبت برنامه pm")
                    BaseDataObject.DataAccess.RollBack()
                Else
                    VAlidatePMProgramToSave = False
                    Srl_PmProgramTpEdit = -1
                    InsertNewPMExecute = -1
                End If
            End If

            If Not BaseDataObject.DataAccess.Commit Then
                MessageBoxFa.Show("ثبت اطلاعات با مشكل مواجه شد")
                'BaseDataObject.DataAccess.RollBack()
            Else

                If MessageBoxFa.Show("اطلاعات با موفقیت ثبت شد.شماره فرم" + dr("no").ToString() + ". آیا می خواهید صورت وضعیت ثبت نمائید؟", "عملیات موفق", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    If MessageBoxFa.Show("آیا می خواهید صورت وضعیت کار مازاد ثبت نمائید؟", "انتخاب نوع صورت وضعیت", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                        Dim f As Frm_Con_StatusStatementMazad = New Frm_Con_StatusStatementMazad(Srl_Maseter, -1)
                        f.ShowDialog()
                    Else
                        Dim f As Frm_Con_StatusStatement = New Frm_Con_StatusStatement(Srl_Maseter, -1)
                        f.ShowDialog()
                    End If

                End If
                ClearForm()
                ' اردهای نوید برای مقادیر پیش فرض
                Try
                    cmb_HazineCode.SelectedValue = Setting.Default_Code_Hazine.PropValue
                    Cmb_PostTo.SelectedValue = 574
                    Cmb_PostFrom.SelectedValue = 574
                    cmb_PmWorkDis.SelectedValue = 16843
                Catch ex As Exception

                End Try
                _Ts_Sum_NafarSat = New TimeSpan
                _Ts_Sum_EzafeKareFormKar = New TimeSpan
                _Ts_Sum_EzafeKarTaradod = New TimeSpan
                Cmb_Group_SelectedIndexChanged(Nothing, Nothing)
                dt_Workform_EibForm.Clear()
                dt_Workform_Kala.Clear()
                lbl_RozeHafte.Text = "روز هفته"
                lb_MatchPM.Text = ""
                txt_Date.Value = Setting.TarikheJary
                isTatil = False

                txt_FromKarNo.Focus()
                chk_ForceCancle.Checked = False
            End If
        End If
    End Sub
    Public Function CurrectTime(ByVal st As String) As String
        If Not st.Contains(":") Then
            Return "00:00"
        Else
            Dim hour As String = st.Substring(0, st.IndexOf(":"))
            Dim min As String = st.Substring(st.IndexOf(":") + 1)
            If hour.Length = 1 Then
                hour = "0" + hour
            End If
            If min.Length = 1 Then
                min = "0" + min
            End If
            Return hour + ":" + min
        End If
    End Function

    Function GetMazadEzafeKar() As String
        Dim sampleTimspan As New TimeSpan(0, 0, 0)

        If isTatil Then
            Dim tstemp_total As New TimeSpan( _
            Integer.Parse(PublicFunction.GetHour(Setting.MazadEzafekar_HolyDay.PropValue.ToString())), _
            Integer.Parse(PublicFunction.GetMin(Setting.MazadEzafekar_HolyDay.PropValue.ToString())), 0)

            Dim MazadEzafekar_HolyDay As TimeSpan = _Ts_Sum_EzafeKareFormKar.Subtract(tstemp_total)
            If MazadEzafekar_HolyDay > sampleTimspan Then
                Return PublicFunction.GetSaat(MazadEzafekar_HolyDay)
            End If
        Else
            Dim tstemp_total As New TimeSpan( _
            Integer.Parse(PublicFunction.GetHour(Setting.MazadEzafekar_Normal.PropValue.ToString())), _
            Integer.Parse(PublicFunction.GetMin(Setting.MazadEzafekar_Normal.PropValue.ToString())), 0)

            Dim MazadEzafekar_Normal As TimeSpan = _Ts_Sum_EzafeKareFormKar.Subtract(tstemp_total)
            If MazadEzafekar_Normal > sampleTimspan Then
                Return PublicFunction.GetSaat(MazadEzafekar_Normal)
            End If
        End If
        Return "00:00"
    End Function

    Function GetEzafeKarValue(ByVal _Ezafekar As TimeSpan, ByVal _EzafekarTaradod As TimeSpan, ByVal _SaghfeKar As TimeSpan) As String
        'Dim sampleTimspan As New TimeSpan(0, 0, 0)
        Dim tstemp_total As TimeSpan
        'Dim result As TimeSpan = _Ezafekar.Add(_EzafekarTaradod).Subtract(_SaghfeKar)
        Dim result As TimeSpan = _Ezafekar.Add(_EzafekarTaradod)
        If isTatil Then
            tstemp_total = New TimeSpan( _
            Integer.Parse(PublicFunction.GetHour(Setting.MazadEzafekar_HolyDay.PropValue.ToString())), _
            Integer.Parse(PublicFunction.GetMin(Setting.MazadEzafekar_HolyDay.PropValue.ToString())), 0)
        Else
            tstemp_total = New TimeSpan( _
            Integer.Parse(PublicFunction.GetHour(Setting.MazadEzafekar_Normal.PropValue.ToString())), _
            Integer.Parse(PublicFunction.GetMin(Setting.MazadEzafekar_Normal.PropValue.ToString())), 0)
        End If

        If result > tstemp_total Then
            result = _Ezafekar.Add(_EzafekarTaradod).Subtract(_SaghfeKar)
            Return PublicFunction.GetSaat(result)
        Else
            Return PublicFunction.GetSaat(_Ezafekar)
        End If
    End Function

    Sub CalSumOfNafarSat()
        'Ts_NafarSat.ResetResult()
        Dim t As TimeSpan
        For Each dtg As DataGridViewRow In DataGridView1.Rows
            Dim temp As New TimeSpan(dtg.Cells(1).Value.ToString.Substring(0, dtg.Cells(1).Value.ToString.IndexOf(":")), dtg.Cells(1).Value.ToString.Substring(dtg.Cells(1).Value.ToString.IndexOf(":") + 1), 0)
            'temp.Value = dtg.Cells(1).Value
            t = t.Add(temp)
            ' Ts_NafarSat.time = Ts_NafarSat.time.Add(temp.time)
        Next
        Sum_SaatKar.Text = PublicFunction.GetSaat(t)
    End Sub

    Sub CalSumOfEzafeKareFormKar()
        'ts_EzafeKareFormKar.ResetResult()
        'For Each dtg As DataGridViewRow In DataGridView1.Rows
        '    Dim temp As New TimeSelect
        '    temp.Value = dtg.Cells(2).Value
        '    ts_EzafeKareFormKar.time = ts_EzafeKareFormKar.time.Add(temp.time)
        'Next
        Dim t As TimeSpan
        For Each dtg As DataGridViewRow In DataGridView1.Rows
            Dim temp As New TimeSpan(dtg.Cells(2).Value.ToString.Substring(0, dtg.Cells(2).Value.ToString.IndexOf(":")), dtg.Cells(2).Value.ToString.Substring(dtg.Cells(2).Value.ToString.IndexOf(":") + 1), 0)
            'temp.Value = dtg.Cells(1).Value
            t = t.Add(temp)
            ' Ts_NafarSat.time = Ts_NafarSat.time.Add(temp.time)
        Next
        Sum_EzafeKar.Text = PublicFunction.GetSaat(t)
    End Sub

    Sub CalSumOfEzafeKarTaradod()
        'ts_EzafeKarTaradod.ResetResult()
        'For Each dtg As DataGridViewRow In DataGridView1.Rows
        '    Dim temp As New TimeSelect
        '    temp.Value = dtg.Cells(3).Value
        '    ts_EzafeKarTaradod.time = ts_EzafeKarTaradod.time.Add(temp.time)
        'Next
        Dim t As TimeSpan
        For Each dtg As DataGridViewRow In DataGridView1.Rows
            Dim temp As New TimeSpan(dtg.Cells(3).Value.ToString.Substring(0, dtg.Cells(3).Value.ToString.IndexOf(":")), dtg.Cells(3).Value.ToString.Substring(dtg.Cells(3).Value.ToString.IndexOf(":") + 1), 0)
            'temp.Value = dtg.Cells(1).Value
            t = t.Add(temp)
            ' Ts_NafarSat.time = Ts_NafarSat.time.Add(temp.time)
        Next
        Sum_EzafeKarTaradod.Text = PublicFunction.GetSaat(t)
    End Sub

    Sub Add_Sum_NafarSat(ByVal t As TimeSpan)
        _Ts_Sum_NafarSat = _Ts_Sum_NafarSat.Add(t)
        SetValueToGride(_Ts_Sum_NafarSat, 1)
        CalSumOfNafarSat()
    End Sub

    Sub Add_Sum_EzafeKarTaradod(ByVal t As TimeSpan)
        _Ts_Sum_EzafeKarTaradod = _Ts_Sum_EzafeKarTaradod.Add(t)
        SetValueToGride(_Ts_Sum_EzafeKarTaradod, 3)
        CalSumOfEzafeKarTaradod()
    End Sub

    Sub Add_EzafeKareFormKar(ByVal t As TimeSpan)
        _Ts_Sum_EzafeKareFormKar = _Ts_Sum_EzafeKareFormKar.Add(t)
        SetValueToGride(_Ts_Sum_EzafeKareFormKar, 2)
        CalSumOfEzafeKareFormKar()
    End Sub

    Sub SetValueToGride(ByVal t As TimeSpan, ByVal index As Integer)
        If DataGridView1.Rows.Count = 0 Then
            Return
        End If

        For Each dtg As DataGridViewRow In DataGridView1.Rows
            If CType(dtg.Cells("UserChanged").Value, Boolean) = False Or dtg.Cells("UserChanged").Value Is DBNull.Value Then
                dtg.Cells(index).Value = CurrectTime(PublicFunction.GetSaat(t))
            End If
        Next
    End Sub

    Sub SetSumOfEzafeKarAndTaradodToGride()
        If DataGridView1.Rows.Count = 0 Then
            Return
        End If

        For Each dtg As DataGridViewRow In DataGridView1.Rows 'EzafeKarTaradod
            'set saghfe kar value
            Dim st As String = GetMazadEzafeKar()
            ' If CType(dtg.Cells("UserChanged").Value, Boolean) = False Or dtg.Cells("UserChanged").Value Is DBNull.Value Then
            dtg.Cells("MazadEzafeKar").Value = CurrectTime(st)
            ' End If

            Try
                Dim Tradod As Integer = CInt(dtg.Cells("EzafeKarTaradod").Value.ToString.Substring(0, dtg.Cells("EzafeKarTaradod").Value.ToString.IndexOf(":"))) * 60 + CInt(dtg.Cells("EzafeKarTaradod").Value.ToString.Substring(dtg.Cells("EzafeKarTaradod").Value.ToString.IndexOf(":") + 1))
                Dim Ezafe As Integer = CInt(dtg.Cells("EzafeKar").Value.ToString.Substring(0, dtg.Cells("EzafeKar").Value.ToString.IndexOf(":"))) * 60 + CInt(dtg.Cells("EzafeKar").Value.ToString.Substring(dtg.Cells("EzafeKar").Value.ToString.IndexOf(":") + 1))
                Dim Kasr As Integer = CInt(dtg.Cells("MazadEzafeKar").Value.ToString.Substring(0, dtg.Cells("MazadEzafeKar").Value.ToString.IndexOf(":"))) * 60 + CInt(dtg.Cells("MazadEzafeKar").Value.ToString.Substring(dtg.Cells("MazadEzafeKar").Value.ToString.IndexOf(":") + 1))
                Dim Jam As Integer = Tradod + Ezafe - Kasr
                dtg.Cells("SumEzafeKarAndTaradod").Value = (CInt(Jam \ 60)).ToString() + ":" + (Jam Mod 60).ToString()
            Catch ex As Exception
                dtg.Cells("SumEzafeKarAndTaradod").Value = "00:00"
            End Try
            'Dim ts_taradod As New TimeSelect
            'ts_taradod.Value = dtg.Cells("EzafeKarTaradod").Value.ToString
            'Dim ts_Ezafe As New TimeSelect
            'ts_Ezafe.Value = dtg.Cells("EzafeKar").Value.ToString
            'Dim ts_saghfekar As New TimeSelect
            'ts_saghfekar.Value = dtg.Cells("MazadEzafeKar").Value.ToString

            'dtg.Cells("SumEzafeKarAndTaradod").Value = CurrectTime(PublicFunction.GetSaat(ts_taradod.time.Add(ts_Ezafe.time.Subtract(ts_saghfekar.time))))

        Next
    End Sub

    Sub getLastNoSeq()
        dr_NoSeq = BaseDataObject.DataAccess.GetRow("select * from Pm_WorkForm_NoSeq where srl_pm_ashkhas=" + Setting.Srl_User.ToString)
    End Sub

    Function ShallReserveWorkFormNumber(ByVal No As Integer) As Boolean
        Dim inSeq As Integer = BaseDataObject.DataAccess.ExecScalar("select COUNT(srl) from Pm_WorkForm_NoSeq where FromNo<=" + No.ToString + " and ToNo>=" + No.ToString + " and Srl_Pm_Ashkhas<>" + Setting.Srl_User.ToString)
        Dim inNorm As Integer = BaseDataObject.DataAccess.ExecScalar("select COUNT(srl) from Pm_WorkForm_Master where No=" + No.ToString)
        If inSeq = 0 And inNorm = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Cmb_PostFrom_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_PostFrom.Leave, Cmb_PostTo.Leave, Cmb_PostFrom.Enter, Cmb_PostTo.Enter
        Dim obj As Object = getDistance()
        If obj Is Nothing Then
            txt_Distance.Value = 0
        Else
            txt_Distance.Value = obj("Distance")
        End If
    End Sub

    Private Sub Btn_FormNaghs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_FormNaghs.Click
        Dim frm As New Frm_WorkForm_EibForm(dt_Workform_EibForm, Srl_Master)
        frm.ShowDialog()
        dt_Workform_EibForm = frm.GetDataTable()
    End Sub

    Private Sub Btn_KalaMasrafi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_KalaMasrafi.Click
        Dim frm As New Frm_WorkForm_Kala(dt_Workform_Kala)
        frm.ShowDialog()
        dt_Workform_Kala = frm.GetDataTable()
    End Sub

    Private Sub btn_Cal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cal.Click
        _Ts_Sum_EzafeKareFormKar = New TimeSpan(0)
        Dim temStartmin As Integer = CInt(ts_BeginWork.Minutes)
        Dim temEndmin As Integer = CInt(ts_EndWork.Minutes)
        Dim temStartHour As Integer = CInt(ts_BeginWork.Hour)
        Dim temEndHour As Integer = CInt(ts_EndWork.Hour)

        If temStartHour > temEndHour Or (temStartHour = temEndHour And temStartmin > temEndmin) Then
            MessageBoxFa.Show("ساعت شروع باید کمتر از ساعت خاتمه باشد")
            ts_BeginWork.Focus()
            Return
        End If
        If txt_FormKarTarikh.Value = "" Then
            MessageBoxFa.Show("لطفا تاریخ را انتخاب نمائید")
            txt_FormKarTarikh.Focus()
            Return
        End If
        _Ts_Sum_NafarSat = New TimeSpan
        _Ts_Sum_EzafeKareFormKar = New TimeSpan
        _Ts_Sum_EzafeKarTaradod = New TimeSpan
        isExtraTatil = False

        If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", txt_FormKarTarikh.Value) > 0) Then
            isTatil = True
            Dim temp As String = PublicFunction.GetDeyOfWeek(txt_FormKarTarikh.Value.ToString)
            If Not temp.Contains("جمع") And Not temp.Contains("پنج") Then
                isExtraTatil = True
            End If
            NewCalcHolyDay(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0))
            calcTaradod(True)
        Else
            isTatil = False
            If cmb_PmWorkDis.SelectedValue Is Nothing Then
                Return
            End If

            Dim dr_WorkForm_Dis As DataRow = BaseDataObject.DataAccess.GetRow("select * from pm_workdis where srl=" + cmb_PmWorkDis.SelectedValue.ToString)
            If CType(dr_WorkForm_Dis("IsPm"), Boolean) = True Then

                Dim begin_Temp As New TimeSelect
                begin_Temp.Value = dr_WorkForm_Dis("FromSat").ToString

                Dim Duration_Temp As New TimeSelect
                Duration_Temp.Value = dr_WorkForm_Dis("Duration").ToString

                If ts_BeginWork.time.ToString < begin_Temp.Value Then
                    Add_EzafeKareFormKar(New TimeSpan(Duration_Temp.Hour, Duration_Temp.Minutes, 0))
                End If
            End If
            If CType(dr_WorkForm_Dis("IsPmmain"), Boolean) = True Then
                Dim temp As New TimeSpan
                temp = ts_EndWork.time.Subtract(ts_BeginWork.time)
                Dim t As Integer = temp.Hours * 60 + temp.Minutes
                If 360 <= t Then
                    NewCalc(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0), False)
                Else
                    NewCalc(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0), False)
                End If
            Else
                NewCalc(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0), False)
            End If
            calcTaradod(False)
        End If

        'calc nafar sa@
        Dim result1 As New TimeSpan
        result1 = ts_EndWork.time.Subtract(ts_BeginWork.time)
        Add_Sum_NafarSat(result1)

        btn_Save.Focus()
        Application.DoEvents()
        btn_Save.Focus()
        Application.DoEvents()
        btn_Save.Focus()
        Application.DoEvents()
        btn_Save.Focus()
        Application.DoEvents()


        Dim ts_temp_MazadEzafeKar As New TimeSelect
        ts_temp_MazadEzafeKar.Value = GetMazadEzafeKar()

        'Dim ts_temp_EzafeKAr As New TimeSelect
        'ts_temp_EzafeKAr.Value = PublicFunction.GetSaat(_Ts_Sum_EzafeKareFormKar)

        If ts_temp_MazadEzafeKar.time.ToString > "00:00:00" Then
            MessageBoxFa.Show("اين فرم کار داراي سقف کار ميباشد")
        End If
        SetSumOfEzafeKarAndTaradodToGride()
    End Sub

    Sub calcTaradod(ByVal IsHollyDay As Boolean)
        Dim h As Double = CDbl((txt_Distance.Value) * 60 / Setting.EzafeKarTaradodBound.PropValue)

        'If txt_Distance.Value <> 0 And _
        '   txt_Distance.Value > (Setting.MaxTaradodBound.PropValue) Then
        If txt_Distance.Value > (Setting.MaxTaradodBound.PropValue) Then
            Dim srl_DayOfWeek As Integer = GetDayeOfWeek(CInt(PublicFunction.GetDAte(txt_FormKarTarikh.Value.ToString).DayOfWeek))

            Dim Ts_beginWorkOnThisDAte As New TimeSelect

            Dim obj As Object = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(fromsat,'00:00:00')  FROM dbo.Pm_WorkForm_Formula " & _
    " WHERE  Srl_DayOfWeak=" + srl_DayOfWeek.ToString + " and IsTaradod=1 and ImportantSat=1 " + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString)

            If obj Is Nothing Then
                Ts_beginWorkOnThisDAte.Value = "00:00:00"
            Else
                Ts_beginWorkOnThisDAte.Value = obj.ToString
            End If

            Dim tmp_ordeJadid As TimeSpan = ts_BeginWork.time.Subtract(New TimeSpan(0, CInt(h), 0))

            If Ts_beginWorkOnThisDAte.time < tmp_ordeJadid Then
                'etefaghi dar in halat nemiofte
                ts_ZamaneKhroj.Value = tmp_ordeJadid.ToString
                If rbtn_taradodBargasht.Checked Then
                    ts_ZamaneKhroj.Value = ts_EndWork.Value
                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                ElseIf rbtn_Dotarafe.Checked Then
                    'ts_ZamaneKhroj.Value = ts_EndWork.Value
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_ZamaneKhroj.time, ts_BeginWork.time)
                    Else
                        NewCalc(True, ts_ZamaneKhroj.time, ts_BeginWork.time, False)
                    End If

                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    If tmp.Days > 0 Then
                        tmp = New TimeSpan(23, 59, 0)
                    End If
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                ElseIf Rbtn_Yektarafe.Checked Then
                    'ts_ZamaneKhroj.Value = "16:00:00"
                    'Dim prevDate As String = FindPreviosDate()

                    If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", txt_FormKarTarikh.Value) > 0) Then
                        NewCalcHolyDay(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)), txt_FormKarTarikh.Value)
                    Else
                        NewCalc(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)), False)
                    End If
                    ''az zaman khoroj ta shoro to formol 

                    ''ts_ZamaneKhroj.Value = ts_EndWork.Value
                    ''Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    ''If IsHollyDay Then
                    ''    NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    ''Else
                    ''    NewCalc(True, ts_EndWork.time, tmp)
                    ''End If
                    '_Ts_Sum_EzafeKarTaradod = New TimeSpan(0, 0, 0)
                    'Add_Sum_EzafeKarTaradod(_Ts_Sum_EzafeKarTaradod)
                End If
            Else
                'dar in halat sate ezafe kar dar sa@ ghanonie kar nist 
                rbtn_RozeGhabl.Checked = True

                If rbtn_Dotarafe.Checked Then
                    ts_ZamaneKhroj.Value = "16:00:00"

                    'chon 16 roze ghable bayad tarikh roze ghabl dar biad va ba oon mohasebe taradod anjam beshe
                    Dim prevDate As String = FindPreviosDate()

                    'mohasebe az zamane khoroj
                    Dim tmp2 As TimeSpan = ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0))
                    If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", prevDate) > 0) Then
                        NewCalcHolyDay(True, ts_ZamaneKhroj.time, tmp2, prevDate)
                    Else
                        NewCalc(True, ts_ZamaneKhroj.time, tmp2, True, prevDate)
                    End If

                    'mohasebe az zamane payane kar
                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                ElseIf Rbtn_Yektarafe.Checked Then
                    ts_ZamaneKhroj.Value = "16:00:00"
                    'Dim tmp As TimeSpan = ts_EndWork.time.Add(New TinemimeSpan(0, CInt(h), 0))
                    'NewCalc(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)))

                    'chon 16 roze ghable bayad tarikh roze ghabl dar biad va ba oon mohasebe taradod anjam beshe
                    Dim prevDate As String = FindPreviosDate()

                    If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", prevDate) > 0) Then
                        NewCalcHolyDay(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)), prevDate)
                    Else
                        NewCalc(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)), False, prevDate)
                    End If

                ElseIf rbtn_taradodBargasht.Checked Then
                    ts_ZamaneKhroj.Value = ts_EndWork.Value
                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                End If
            End If
        Else
            If rbtn_Dotarafe.Checked Or Rbtn_Yektarafe.Checked Then
                ts_ZamaneKhroj.time = ts_BeginWork.time.Subtract(New TimeSpan(0, CInt(h), 0))
                If IsHollyDay Then
                    NewCalcHolyDay(True, ts_ZamaneKhroj.time, ts_BeginWork.time)
                Else
                    NewCalc(True, ts_ZamaneKhroj.time, ts_BeginWork.time, False)
                End If

                If rbtn_Dotarafe.Checked Then
                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))

                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                End If
            ElseIf rbtn_taradodBargasht.Checked Then
                ts_ZamaneKhroj.Value = ts_EndWork.Value
                Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                If IsHollyDay Then
                    NewCalcHolyDay(True, ts_EndWork.time, tmp)
                Else
                    NewCalc(True, ts_EndWork.time, tmp, False)
                End If
            End If
        End If
    End Sub

    Function FindPreviosDate() As String
        Dim tmp_roze_ghable_tarikh As String = txt_FormKarTarikh.Value
        Dim tmp_roz As String = tmp_roze_ghable_tarikh.Remove(0, tmp_roze_ghable_tarikh.Length - 2)
        Dim tmp_Mah As String = tmp_roze_ghable_tarikh.Remove(0, tmp_roze_ghable_tarikh.Length - 5)
        Dim tmp_sal As String = tmp_roze_ghable_tarikh.Remove(4, tmp_roze_ghable_tarikh.Length - 4)
        tmp_Mah = tmp_Mah.Remove(2, 3)
        Dim roz_int As Integer = CType(tmp_roz, Integer) - 1
        If roz_int = 0 Then
            If CType(tmp_Mah, Integer) = 1 Then
                roz_int = 29
                tmp_Mah = "12"
                tmp_sal = CType(tmp_sal, Integer)
            ElseIf CType(tmp_Mah, Integer) < 7 Then
                tmp_Mah = CType(tmp_Mah, Integer) - 1
                tmp_Mah = tmp_Mah.PadLeft(2, "0")
                roz_int = 31
            ElseIf CType(tmp_Mah, Integer) > 6 Then
                tmp_Mah = CType(tmp_Mah, Integer) - 1
                tmp_Mah = tmp_Mah.PadLeft(2, "0")
                roz_int = 30
            End If
        End If
        Dim result_tarikh As String = tmp_sal + "/" + tmp_Mah + "/" + roz_int.ToString.PadLeft(2, "0")
        Return result_tarikh
    End Function

    Sub NewCalc(ByVal IsTaradod As Boolean, ByVal _BeginWork As TimeSpan, ByVal _EndWork As TimeSpan, ByVal IsNoPm As Boolean, Optional ByVal tarikh As String = "")

        Dim BeginWork As New TimeSpan
        Dim EndWork As New TimeSpan
        Dim WorkOnThisTarikh As String = ""

        If tarikh = "" Then
            WorkOnThisTarikh = txt_FormKarTarikh.Value
        Else
            WorkOnThisTarikh = tarikh
        End If

        If _BeginWork.ToString <> "00:00:00" And _EndWork.ToString <> "00:00:00" Then
            BeginWork = _BeginWork
            EndWork = _EndWork
        Else
            BeginWork = ts_BeginWork.time
            EndWork = ts_EndWork.time
        End If

        Dim tmp_Ezafekar As New TimeSpan
        Dim srl_DayOfWeek As Integer = GetDayeOfWeek(CInt(PublicFunction.GetDAte(WorkOnThisTarikh).DayOfWeek))

        Dim S_Taradod As String = 0

        If IsTaradod Then
            S_Taradod = "1"
        Else
            S_Taradod = "0"
        End If

        Dim MaxEndOfWorkOnThisDayeTmp As String = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(Max(tosat),'00:00:00') FROM dbo.Pm_WorkForm_Formula " & _
            " WHERE  Srl_DayOfWeak=" + srl_DayOfWeek.ToString + " and IsTaradod=" + S_Taradod & _
            " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString)
        If MaxEndOfWorkOnThisDayeTmp = "00:00:00" Then
            If IsTaradod Then
                MessageBoxFa.Show("براي اين روز فرمول تردد تعريف نشده")
            Else
                MessageBoxFa.Show("براي اين روز فرمول اضافه کار تعريف نشده")
            End If
            Return
        End If

        Dim ts As New TimeSelect
        ts.Value = MaxEndOfWorkOnThisDayeTmp
        Dim MaxEndOfWorkOnThisDaye As TimeSpan = ts.time

        Dim drOnThisDaye As DataRow = BaseDataObject.DataAccess.GetRow("SELECT * FROM dbo.Pm_WorkForm_Formula " & _
" WHERE    (toSat > '" + BeginWork.ToString + "' and Srl_DayOfWeak=" + srl_DayOfWeek.ToString & _
 " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString + ") ORDER BY FromSat")

        If drOnThisDaye Is Nothing Then
            If IsTaradod Then
                MessageBoxFa.Show("براي ساعت شروع اين روز فرمول تردد تعريف نشده")
            Else
                MessageBoxFa.Show("براي ساعت شروع اين روز فرمول اضافه کار تعريف نشده")
            End If
            Return
        End If

        Do
            Dim ts_endThisRow As New TimeSelect
            ts_endThisRow.Value = drOnThisDaye("toSat").ToString
            Dim tmp_Sub As New TimeSpan

            If ts_endThisRow.Value.ToString > EndWork.ToString Then
                tmp_Sub = EndWork.Subtract(BeginWork)
            Else
                tmp_Sub = ts_endThisRow.time.Subtract(BeginWork)
            End If

            Dim result As New TimeSpan
            Dim tmp_min As Integer = (tmp_Sub.Minutes * CDbl(drOnThisDaye("Zarib").ToString))
            result = result.Add(New TimeSpan(0, tmp_min, 0))
            tmp_min = (tmp_Sub.Hours * 60 * CDbl(drOnThisDaye("Zarib").ToString))
            result = result.Add(New TimeSpan(0, tmp_min, 0))


            Dim result1 As New TimeSpan
            Dim tmp_min1 As Integer = (tmp_Sub.Minutes)
            result1 = result1.Add(New TimeSpan(0, tmp_min1, 0))
            tmp_min1 = (tmp_Sub.Hours * 60)
            result1 = result1.Add(New TimeSpan(0, tmp_min1, 0))

            If IsTaradod Then
                Add_Sum_EzafeKarTaradod(result)
                'ElseIf (Not IsNoPm Or (IsNoPm And Not CType(drOnThisDaye("ImportantSat"), Boolean))) Then
            ElseIf (Not IsNoPm) Then
                Add_EzafeKareFormKar(result)
            Else

                Add_EzafeKareFormKar(New TimeSpan(0))
                'ghable ezafekare PM
            End If

            BeginWork = ts_endThisRow.time

            If (drOnThisDaye("ToSat").ToString >= EndWork.ToString) Then
                Exit Do
            End If

            drOnThisDaye = BaseDataObject.DataAccess.GetRow("SELECT * FROM dbo.Pm_WorkForm_Formula " & _
" WHERE    (toSat > '" + BeginWork.ToString + "' and Srl_DayOfWeak=" + srl_DayOfWeek.ToString & _
 " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString + ") ORDER BY FromSat")

        Loop While True
    End Sub

    Sub NewCalcHolyDay(ByVal IsTaradod As Boolean, ByVal _BeginWork As TimeSpan, ByVal _EndWork As TimeSpan, Optional ByVal tarikh As String = "")
        'If cmb_cancelCuse.SelectedValue > 0 Then
        '    Dim temp As New TimeSpan(8, 0, 0)
        '    Add_EzafeKareFormKar(temp)
        '    Return
        'End If
        If tarikh <> "" Then
            Dim temp As String = PublicFunction.GetDeyOfWeek(tarikh)
            If Not temp.Contains("جمع") And Not temp.Contains("پنج") Then
                isExtraTatil = True
            End If
        End If

        Dim BeginWork As New TimeSpan
        Dim EndWork As New TimeSpan

        Dim WorkOnThisTarikh As String = ""

        If tarikh = "" Then
            WorkOnThisTarikh = txt_FormKarTarikh.Value
        Else
            WorkOnThisTarikh = tarikh
        End If

        If _BeginWork.ToString <> "00:00:00" And _EndWork.ToString <> "00:00:00" Then
            BeginWork = _BeginWork
            EndWork = _EndWork
        Else
            BeginWork = ts_BeginWork.time
            EndWork = ts_EndWork.time
        End If

        Dim tmp_Ezafekar As New TimeSpan
        Dim srl_DayOfWeek As Integer = GetDayeOfWeek(CInt(PublicFunction.GetDAte(WorkOnThisTarikh).DayOfWeek))

        Dim S_Taradod As String = 0

        If IsTaradod Then
            S_Taradod = "1"
        Else
            S_Taradod = "0"
        End If

        Dim MaxEndOfWorkOnThisDayeTmp As String = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(Max(tosat),'00:00:00') FROM dbo.Pm_WorkForm_Formula " & _
" WHERE  Srl_DayOfWeak=" + srl_DayOfWeek.ToString + " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString)
        If MaxEndOfWorkOnThisDayeTmp = "00:00:00" Then
            If IsTaradod Then
                MessageBoxFa.Show("براي اين روز فرمول تردد تعريف نشده")
            Else
                MessageBoxFa.Show("براي اين روز فرمول اضافه کار تعريف نشده")
            End If
            Return
        End If

        Dim ts As New TimeSelect
        ts.Value = MaxEndOfWorkOnThisDayeTmp
        Dim MaxEndOfWorkOnThisDaye As TimeSpan = ts.time

        Dim drOnThisDaye As DataRow = BaseDataObject.DataAccess.GetRow("SELECT * FROM dbo.Pm_WorkForm_Formula " & _
" WHERE    (toSat > '" + BeginWork.ToString + "' and Srl_DayOfWeak=" + srl_DayOfWeek.ToString & _
 " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString + ") ORDER BY FromSat")

        If drOnThisDaye Is Nothing Then
            If IsTaradod Then
                MessageBoxFa.Show("براي ساعت شروع اين روز فرمول تردد تعريف نشده")
            Else
                MessageBoxFa.Show("براي ساعت شروع اين روز فرمول اضافه کار تعريف نشده")
            End If
            Return
        End If

        Do
            Dim ts_endThisRow As New TimeSelect
            ts_endThisRow.Value = drOnThisDaye("toSat").ToString
            Dim tmp_Sub As New TimeSpan

            If ts_endThisRow.Value.ToString > EndWork.ToString Then
                tmp_Sub = EndWork.Subtract(BeginWork)
            Else
                tmp_Sub = ts_endThisRow.time.Subtract(BeginWork)
            End If

            Dim result As New TimeSpan

            If Not isExtraTatil Then
                Dim tmp_min As Integer = (tmp_Sub.Minutes * CDbl(drOnThisDaye("Zarib").ToString))
                result = result.Add(New TimeSpan(0, tmp_min, 0))
                tmp_min = (tmp_Sub.Hours * 60 * CDbl(drOnThisDaye("Zarib").ToString))
                result = result.Add(New TimeSpan(0, tmp_min, 0))
            Else
                Dim tmp_min As Integer = (tmp_Sub.Minutes * Setting.HolidayZarib.PropValue)
                result = result.Add(New TimeSpan(0, tmp_min, 0))
                tmp_min = (tmp_Sub.Hours * 60 * Setting.HolidayZarib.PropValue)
                result = result.Add(New TimeSpan(0, tmp_min, 0))
            End If
            If IsTaradod Then
                Add_Sum_EzafeKarTaradod(result)
            Else
                Add_EzafeKareFormKar(result)
            End If

            BeginWork = ts_endThisRow.time

            If (drOnThisDaye("ToSat").ToString >= EndWork.ToString) Then
                Exit Do
            End If

            drOnThisDaye = BaseDataObject.DataAccess.GetRow("SELECT * FROM dbo.Pm_WorkForm_Formula " & _
" WHERE    (toSat > '" + BeginWork.ToString + "' and Srl_DayOfWeak=" + srl_DayOfWeek.ToString & _
 " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString + ") ORDER BY FromSat")

        Loop While True
    End Sub

    Sub oldCalc()
        GetWrokFormula()

        _Ts_Sum_NafarSat = New TimeSpan
        _Ts_Sum_EzafeKareFormKar = New TimeSpan
        _Ts_Sum_EzafeKarTaradod = New TimeSpan

        'Ts_NafarSat.time = New TimeSpan
        'ts_EzafeKareFormKar.time = New TimeSpan
        'ts_EzafeKarTaradod.time = New TimeSpan

        If Cbox_IsPm.Checked Then
            If ts_BeginWork.time.Hours < 8 Then
                Add_EzafeKareFormKar(New TimeSpan(1, 0, 0))
            End If
        End If

        '*********************************************************************************************
        'Ezafe kar Taradod
        '*********************************************************************************************
        'fasele bishatar az 70
        If ts_ZamaneKhroj.time.Hours < BeginWrokOnThisDaye.Hours Then
            calWithNim(True)
        ElseIf ts_ZamaneKhroj.time.Hours = BeginWrokOnThisDaye.Hours Then
            If ts_ZamaneKhroj.time.Minutes < BeginWrokOnThisDaye.Minutes Then
                calWithNim(True)
            End If
        End If


        If rbtn_Dotarafe.Checked And txt_Distance.Value <> 0 Then
            If txt_Distance.Value > (Setting.MaxTaradodBound.PropValue) Then
                rbtn_RozeGhabl.Checked = True
                ts_ZamaneKhroj.Value = "16:00:00"
                Add_Sum_EzafeKarTaradod(New TimeSpan(2, 0, 0))
            Else
                'If CDbl(txt_Distance.Value) > Setting.EzafeKarTaradodBound Then
                '    Dim h As Integer = CInt(txt_Distance.Value) / Setting.EzafeKarTaradodBound
                '    Add_Sum_EzafeKarTaradod(New TimeSpan(h, 0, 0))
                'End If
            End If
        End If

        '*********************************************************************************************
        'Ezafe Movazaf      kare pm * 0.3
        '*********************************************************************************************
        Dim tmp_Sub1 As TimeSpan = ts_EndWork.time.Subtract(ts_BeginWork.time)

        Dim result1 As New TimeSpan
        Dim tmp_min1 As Integer = (tmp_Sub1.Minutes * ZaribWrokOnThisDaye)
        result1 = result1.Add(New TimeSpan(0, tmp_min1, 0))
        tmp_min1 = (tmp_Sub1.Hours * 60 * ZaribWrokOnThisDaye)
        result1 = result1.Add(New TimeSpan(0, tmp_min1, 0))

        Add_EzafeKareFormKar(result1)

        '*********************************************************************************************
        'Ezafe ghable az Movazaf     shoro kar ghable az 7.15
        '*********************************************************************************************
        If ts_ZamaneKhroj.time.Hours < BeginWrokOnThisDaye.Hours Then
            calWithNim(False)
        ElseIf ts_ZamaneKhroj.time.Hours = BeginWrokOnThisDaye.Hours Then
            If ts_ZamaneKhroj.time.Minutes < BeginWrokOnThisDaye.Minutes Then
                calWithNim(False)
            End If
        End If

        If ts_EndWork.time.ToString > BeginEzafekarOnThisDaye.ToString Then
            Add_EzafeKareFormKar(ts_EndWork.time.Subtract(BeginEzafekarOnThisDaye))
        End If

        '*********************************************************************************************
        'Ezafe Kar 
        '*********************************************************************************************
        If ts_EndWork.time.Hours > BeginEzafekarOnThisDaye.Hours Then
            CalAfter16()
        ElseIf ts_EndWork.time.Hours = BeginEzafekarOnThisDaye.Hours Then
            If ts_EndWork.time.Minutes < BeginEzafekarOnThisDaye.Minutes Then
                CalAfter16()
            End If
        End If

        'If duration_movazaf < temp_time_Sum Then
        '    MessageBoxFa.Show("ساعات کار از ساعت استاندارد کمتر است")
        '    Dim KasreKarDuration As TimeSpan = duration_movazaf.Subtract(temp_time_Sum)
        'End If
    End Sub

    Sub CalAfter16()
        Dim tmp_Sub As TimeSpan = ts_EndWork.time.Subtract(BeginEzafekarOnThisDaye)

        Dim result As New TimeSpan
        result = result.Add(New TimeSpan(0, tmp_Sub.Minutes, 0))
        result = result.Add(New TimeSpan(0, tmp_Sub.Hours * 60, 0))
        Add_EzafeKareFormKar(result)
    End Sub

    Sub calWithNim(ByVal toTaradod As Boolean)
        Dim tmp_Sub As TimeSpan = ts_BeginWork.time.Subtract(ts_ZamaneKhroj.time)

        Dim result As New TimeSpan
        Dim tmp_min As Integer = (tmp_Sub.Minutes * ZaribGhablMovazafOnThisDaye)
        result = result.Add(New TimeSpan(0, tmp_min, 0))
        tmp_min = (tmp_Sub.Hours * 60 * ZaribGhablMovazafOnThisDaye)
        result = result.Add(New TimeSpan(0, tmp_min, 0))
        result = result.Add(tmp_Sub)

        If toTaradod Then
            Add_Sum_EzafeKarTaradod(result)
        Else
            Add_EzafeKareFormKar(result)
        End If
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        Dim s As New Frm_WorkForm_Edit(txt_Date.Value, txt_FromKarNo.Value, txt_FormKarTarikh.Value, "-1", _
                                       cmb_HazineCode.SelectedValue, Cmb_PostFrom.SelectedValue, Cmb_PostTo.SelectedValue, _
                                       cmb_VAhed.SelectedValue, Nothing, False, ts_BeginWork.time, ts_EndWork.time, txt_WorkDis.Value, Rbtn_Yektarafe.Checked, _
                                       rbtn_Dotarafe.Checked, rbtn_taradodBargasht.Checked)
        s.ShowDialog()
        If Not s.dr_details Is Nothing Then
            Dim drInsert As DataRow = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.NewRow

            drInsert(0) = s.cmb_Ashkhas.Text
            drInsert(1) = PublicFunction.GetSaat(_Ts_Sum_NafarSat)
            drInsert(2) = PublicFunction.GetSaat(_Ts_Sum_EzafeKareFormKar)
            drInsert(3) = PublicFunction.GetSaat(_Ts_Sum_EzafeKarTaradod)
            drInsert(5) = s.cmb_Ashkhas.SelectedValue
            drInsert.Item("تغییر توسط کاربر") = False
            drInsert(23) = BaseDataObject.DataAccess.ExecScalar("select isnull(weight,0) from pm_ashkhas where srl=" + s.cmb_Ashkhas.SelectedValue.ToString())

            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.Rows.Add(drInsert)
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub Btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Delete.Click
        Try
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Delete( _
        DataGridView1.CurrentRow.Index)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Frm_WorkForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        BaseDataObject.DataAccess.Delete("pm_workform_noseq", "srl_pm_ashkhas=" + Setting.Srl_User.ToString)
    End Sub

    Private Sub Btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click
        Dim s As Frm_WorkForm_Edit
        If CType(DataGridView1.CurrentRow.Cells("UserChanged").Value, Boolean) = True Then
            Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_WorkFrom_Detail")
            dr_details("Srl_Pm_Post_From") = DataGridView1.CurrentRow.Cells("Srl_Pm_Post_From").Value
            dr_details("Srl_Pm_Post_To") = DataGridView1.CurrentRow.Cells("Srl_Pm_Post_To").Value
            dr_details("Srl_Pm_Vahed") = DataGridView1.CurrentRow.Cells("Srl_Pm_Vahed").Value
            dr_details("Srl_Pm_WorkDis") = DataGridView1.CurrentRow.Cells("Srl_Pm_WorkDis").Value
            dr_details("Srl_HazineCode") = DataGridView1.CurrentRow.Cells("Srl_HazineCode").Value
            dr_details("WorkFormDis") = DataGridView1.CurrentRow.Cells("WorkFormDis").Value
            dr_details("Dis") = DataGridView1.CurrentRow.Cells("Dis").Value
            dr_details("SatKAr") = CurrectTime(DataGridView1.CurrentRow.Cells("SatKar").Value)
            dr_details("EzafeKAr") = DataGridView1.CurrentRow.Cells("EzafeKAr").Value
            dr_details("EzafeKarTaradod") = DataGridView1.CurrentRow.Cells("EzafeKarTaradod").Value
            dr_details("HarkatHamanRoz") = DataGridView1.CurrentRow.Cells("HarkatHamanRoz").Value
            dr_details("TardodeDotarfe") = DataGridView1.CurrentRow.Cells("TardodeDotarfe").Value
            dr_details("BeginWorkSat") = DataGridView1.CurrentRow.Cells("BeginWorkSat").Value
            dr_details("EndWorkSat") = DataGridView1.CurrentRow.Cells("EndWorkSat").Value
            dr_details("KhorojSat") = DataGridView1.CurrentRow.Cells("KhorojSat").Value
            dr_details("WorkFormDis") = DataGridView1.CurrentRow.Cells("WorkFormDis").Value
            dr_details("Dis") = DataGridView1.CurrentRow.Cells("Dis").Value

            s = New Frm_WorkForm_Edit(txt_Date.Value, txt_FromKarNo.Value, txt_FormKarTarikh.Value, _
                                           DataGridView1.CurrentRow.Cells("Srl_Pm_Ashkhas").Value.ToString, cmb_HazineCode.SelectedValue, _
                                           Cmb_PostFrom.SelectedValue, Cmb_PostTo.SelectedValue, cmb_VAhed.SelectedValue, _
                                           dr_details, True, Nothing, Nothing, txt_WorkDis.Value, Rbtn_Yektarafe.Checked, _
                                       rbtn_Dotarafe.Checked, rbtn_taradodBargasht.Checked)
            s.ShowDialog()
        Else
            s = New Frm_WorkForm_Edit(txt_Date.Value, txt_FromKarNo.Value, txt_FormKarTarikh.Value, _
                                           DataGridView1.CurrentRow.Cells("Srl_Pm_Ashkhas").Value.ToString, _
                                       cmb_HazineCode.SelectedValue, Cmb_PostFrom.SelectedValue, Cmb_PostTo.SelectedValue, _
                                       cmb_VAhed.SelectedValue, Nothing, False, ts_BeginWork.time, ts_EndWork.time, txt_WorkDis.Value, Rbtn_Yektarafe.Checked, _
                                       rbtn_Dotarafe.Checked, rbtn_taradodBargasht.Checked)
            s.ShowDialog()
        End If

        If Not s.dr_details Is Nothing Then
            DataGridView1.CurrentRow.Cells("UserChanged").Value = True
            DataGridView1.CurrentRow.Cells("Srl_Pm_Post_From").Value = s.dr_details("Srl_Pm_Post_From")
            DataGridView1.CurrentRow.Cells("Srl_Pm_Post_To").Value = s.dr_details("Srl_Pm_Post_To")
            DataGridView1.CurrentRow.Cells("Srl_Pm_Vahed").Value = s.dr_details("Srl_Pm_Vahed")
            DataGridView1.CurrentRow.Cells("Srl_Pm_WorkDis").Value = s.dr_details("Srl_Pm_WorkDis")
            DataGridView1.CurrentRow.Cells("Srl_HazineCode").Value = s.dr_details("Srl_HazineCode")
            DataGridView1.CurrentRow.Cells("WorkFormDis").Value = s.dr_details("WorkFormDis")
            DataGridView1.CurrentRow.Cells("Dis").Value = s.dr_details("Dis")
            DataGridView1.CurrentRow.Cells("SatKar").Value = s.dr_details("SatKAr")

            'Dim ts_temp_MazadEzafeKar As New TimeSelect
            'ts_temp_MazadEzafeKar.Value = s.dr_details("MazadEzafeKar")
            'Dim ts_temp_EzafeKAr As New TimeSelect
            'ts_temp_EzafeKAr.Value = s.dr_details("EzafeKAr")
            'Dim ts_temp_taradod As New TimeSelect
            'ts_temp_taradod.Value = s.dr_details("EzafeKarTaradod")
            'DataGridView1.CurrentRow.Cells("EzafeKAr").Value = GetEzafeKarValue(ts_temp_EzafeKAr.time, ts_temp_taradod.time, ts_temp_MazadEzafeKar.time)
            'DataGridView1.CurrentRow.Cells("EzafeKAr").Value = PublicFunction.GetSaat(ts_temp_EzafeKAr.time.Add(ts_temp_taradod.time).Subtract(ts_temp_MazadEzafeKar.time))

            DataGridView1.CurrentRow.Cells("EzafeKAr").Value = s.dr_details("EzafeKAr")
            DataGridView1.CurrentRow.Cells("MazadEzafeKar").Value = s.dr_details("MazadEzafeKar")
            DataGridView1.CurrentRow.Cells("EzafeKarTaradod").Value = s.dr_details("EzafeKarTaradod")

            DataGridView1.CurrentRow.Cells("HarkatHamanRoz").Value = s.dr_details("HarkatHamanRoz")
            DataGridView1.CurrentRow.Cells("TardodeDotarfe").Value = s.dr_details("TardodeDotarfe")
            If s.dr_details("BeginWorkSat").ToString.Length > 5 Then
                DataGridView1.CurrentRow.Cells("BeginWorkSat").Value = s.dr_details("BeginWorkSat").ToString.Remove(5, 3)
            Else
                DataGridView1.CurrentRow.Cells("BeginWorkSat").Value = s.dr_details("BeginWorkSat")
            End If

            If s.dr_details("EndWorkSat").ToString.Length > 5 Then
                DataGridView1.CurrentRow.Cells("EndWorkSat").Value = s.dr_details("EndWorkSat").ToString.Remove(5, 3)
            Else
                DataGridView1.CurrentRow.Cells("EndWorkSat").Value = s.dr_details("EndWorkSat")
            End If

            If s.dr_details("KhorojSat").ToString.Length > 5 Then
                DataGridView1.CurrentRow.Cells("KhorojSat").Value = s.dr_details("KhorojSat").ToString.Remove(5, 3)
            Else
                DataGridView1.CurrentRow.Cells("KhorojSat").Value = s.dr_details("KhorojSat")
            End If
        End If
        SetSumOfEzafeKarAndTaradodToGride()
    End Sub

    Private Sub btn_Before_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Before.Click
        If txt_no.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(False)
                End If
            Else
                NextOrBeforeForm(False)
            End If
        Else
            MessageBox.Show("شماره فرم کار را وارد نمائید")
            txt_no.Focus()
        End If
    End Sub

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click
        If txt_no.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(True)
                End If
            Else
                NextOrBeforeForm(True)
            End If
        Else

            MessageBox.Show("شماره فرم کار را وارد نمائید")
            txt_no.Focus()
        End If
    End Sub

    Public Sub NextOrBeforeForm(ByVal Flag As Boolean)
        Dim FrmNo As Integer
        If Flag Then
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_WorkForm_Master where No >" + txt_no.Value + " Order by no"))
        Else
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_WorkForm_Master where No <" + txt_no.Value + " Order by no desc"))
        End If
        If FrmNo > 0 Then
            ClearForm()
            Srl_Master = FrmNo
            initialForm(Srl_Master)
            Frm_WorkForm_Load(Nothing, Nothing)
        Else
            MessageBox.Show("موردي يافت نشد")
        End If
    End Sub

    Private Sub btn_SHow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SHow.Click
        If txt_no.Text = "" Then
            MessageBox.Show("شماره فرم کار را وارد نمائید")
            txt_no.Focus()
        Else
          
            Srl_Master = CInt(BaseDataObject.DataAccess.ExecScalar("select srl from Pm_WorkForm_Master where No =" + txt_no.Value))
            If Srl_Master = 0 Then
                MessageBox.Show("موردي يافت نشد")
                Return
            End If
            ClearForm()
            initialForm(Srl_Master)
            Frm_WorkForm_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub rbtn_HamanRoz_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_HamanRoz.Enter, Rbtn_Yektarafe.Enter, rbtn_RozeGhabl.Enter, rbtn_Dotarafe.Enter, rbtn_taradodBargasht.Enter
        DirectCast(sender, RadioButton).Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    End Sub

    Private Sub rbtn_HamanRoz_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_HamanRoz.Leave, Rbtn_Yektarafe.Leave, rbtn_RozeGhabl.Leave, rbtn_Dotarafe.Leave, rbtn_taradodBargasht.Enter
        DirectCast(sender, RadioButton).Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
    End Sub

    Private Sub chk_AllPerson_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllPerson.CheckedChanged, chk_IsMission.CheckedChanged
        If chk_AllPerson.Checked Then
            Me.Cmb_Sarparast.DataSource = Me.AccAshkhasBindingSource
            Me.Cmb_Sarparast.DisplayMember = "نام و نام خانوادگی"
            Me.Cmb_Sarparast.ValueMember = "Srl"
        Else
            Me.Cmb_Sarparast.DataSource = Me.PmGroupMemberBindingSource
            Me.Cmb_Sarparast.DisplayMember = "نام"
            Me.Cmb_Sarparast.ValueMember = "Srl"
        End If
    End Sub

    Private Sub btn_LAstWorkForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LAstWorkForm.Click
        Dim FrmNo As Integer = CInt(BaseDataObject.DataAccess.ExecScalar("select max(srl) from Pm_WorkForm_Master"))
        If FrmNo > 0 Then
            ClearForm()
            Srl_Master = FrmNo
            initialForm(Srl_Master)
            Frm_WorkForm_Load(Nothing, Nothing)
        Else
            MessageBox.Show("موردي يافت نشد")
        End If
    End Sub

    'Private Sub txt_no_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_no.Leave
    '    If Srl_Master <> -1 Then
    '        If (BaseDataObject.DataAccess.ExistNum("Pm_WorkForm_Master", "No", txt_no.Value _
    '             , "Srl<>" + Srl_Master.ToString) > 0) Then
    '            MessageBoxFa.Show("شماره فرم کار تکراري است")
    '            txt_no.Focus()
    '            Return
    '        End If
    '    Else
    '        If (BaseDataObject.DataAccess.ExistNum("Pm_WorkForm_Master", "No", txt_no.Value) > 0) Then
    '            MessageBoxFa.Show("شماره فرم کار تکراري است")
    '            txt_no.Focus()
    '            Return
    '        End If
    '    End If
    'End Sub

    Private Sub cmb_PmWorkDis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PmWorkDis.SelectedIndexChanged, txt_FormKarTarikh.TextChanged
        If Not cmb_PmWorkDis.SelectedValue Is Nothing Then
            Dim dr_WorkForm_Dis As DataRow = BaseDataObject.DataAccess.GetRow("select * from pm_workdis where srl=" + cmb_PmWorkDis.SelectedValue.ToString)
            Try
                If CType(dr_WorkForm_Dis("IsPmmain"), Boolean) = True Or cmb_PmWorkDis.Text = "عدم موافقت" Then
                    pnl_Work_Pm.Enabled = True
                    Me.pnl_Work_Pm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                Else
                    VAlidatePMProgramToSave = True
                    pnl_Work_Pm.Enabled = False
                    Me.pnl_Work_Pm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                End If
            Catch
                VAlidatePMProgramToSave = True
                pnl_Work_Pm.Enabled = False
                Me.pnl_Work_Pm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            End Try
        End If
        'Dim dr_WorkForm_Dis As DataRow = BaseDataObject.DataAccess.GetRow("select * from pm_workdis where srl=" + cmb_PmWorkDis.SelectedValue.ToString)

        'If CType(dr_WorkForm_Dis("IsPm"), Boolean) = True Then
        '    cmb_Pm_Tajhiz_Select.Enabled = True
        '    Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Pm.Pm_Hadese_KhesaratDevice, Cmb_PostFrom.SelectedValue)
        'Else
        '    cmb_Pm_Tajhiz_Select.Enabled = False
        'End If
    End Sub

    Dim VAlidatePMProgramToSave As Boolean = False
    Dim Srl_PmProgramTpEdit As Integer = -1

    Private Sub btn_SelectDEvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectDEvice.Click
        If txt_FormKarTarikh.Value = "" Then
            MessageBoxFa.Show("لطفا تاريخ فرم کار را وارد کنيد")
            txt_FormKarTarikh.Focus()
            Return
        End If

        Dim s As New Frm_DeviceSelect(Cmb_PostFrom.SelectedValue)
        If s.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

        If Not s.SelectedDevice Is Nothing Then
            txt_DeviceKhesaratName.Value = s.SelectedDevice.Text
            txt_Srl_DeviceKhesarat.Text = s.SelectedDevice.Srl
        End If

        'Dim dr_WorkForm_Dis As DataRow = BaseDataObject.DataAccess.GetRow("select * from pm_workdis where srl=" + cmb_PmWorkDis.SelectedValue.ToString)
        'If CType(dr_WorkForm_Dis("IsPmMain"), Boolean) = True Then
        '    VAlidatePMProgramToSave = True
        'Else

        If txt_Srl_DeviceKhesarat.Text <> "" Then
            Dim f As DataTable = BaseDataObject.DataAccess.GetDataTable("SELECT     TOP (100) PERCENT  dbo.Pm_PmProgram.srl,Pm_date as تاریخ,dbo.Pm_PmProgram.description as توضیحات  FROM dbo.Pm_PmProgram " & _
                                                                   " WHERE     (Srl_Pm_Hadese_KhesaratDevice = " + txt_Srl_DeviceKhesarat.Text + ") " & _
                                                                   " AND (SUBSTRING(Pm_Date, 0, 5) = " + txt_FormKarTarikh.Value.ToString().Substring(0, 4) + ")" & _
                                                                   "  ORDER BY Srl")
            If f.Rows.Count = 0 Then
                lb_MatchPM.ForeColor = Color.Red
                lb_MatchPM.Text = "عدم وجود برنامه pm"
                MessageBoxFa.Show("برنامه PM اين دستگاه ثبت نشده ...شما قادر به ذخيره سازي اين فرم کار نيستيد")
                VAlidatePMProgramToSave = False
            ElseIf f.Rows.Count = 1 Then
                Dim f1 As DataTable = BaseDataObject.DataAccess.GetDataTable("SELECT     TOP (100) PERCENT dbo.Pm_PmProgram.srl,Pm_date as تاریخ,dbo.Pm_PmProgram.description as توضیحات FROM dbo.Pm_PmProgram  left JOIN Pm_ExecutePmProgram" & _
                                                                                   " On Pm_ExecutePmProgram.Srl_Pm_PmProgram = Pm_PmProgram .Srl   " & _
                                                                  " WHERE     (Srl_Pm_Hadese_KhesaratDevice = " + txt_Srl_DeviceKhesarat.Text + ") " & _
                                                                  " AND (SUBSTRING(Pm_Date, 0, 5) = " + txt_FormKarTarikh.Value.ToString().Substring(0, 4) + ")" & _
                                                                  "  AND (ExecuteDate is null  or ExecuteDate ='')AND (Srl_Pm_workForm is null) ORDER BY Pm_Date ")

                If f1.Rows.Count = 0 Then
                    If MessageBoxFa.Show("تمام برنامه های پیشنهادی این تجهیز قبلا تاریخ انجام خورده اند آیا مایلی فرم کار دیگری برای آن ثبت شود؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                        InsertNewPMExecute = 1
                        Dim selectpm As Frm_SelectPmProgram = New Frm_SelectPmProgram(f)
                        selectpm.ShowDialog()
                        If selectpm.Selected_Srl <> -1 Then
                            Srl_PmProgramTpEdit = selectpm.Selected_Srl
                            VAlidatePMProgramToSave = True
                            If txt_FormKarTarikh.Value = selectpm.pm_date Then
                                lb_MatchPM.ForeColor = Color.Green
                                Chk_SabtBaTakhir.Checked = False
                                lb_MatchPM.Text = "منطبق بر برنامه pm"
                            Else
                                Chk_SabtBaTakhir.Checked = True
                                cmb_cancelCuse.Enabled = True
                                'lb_MatchPM.Visible = False
                                lb_MatchPM.ForeColor = Color.Red
                                lb_MatchPM.Text = "ثبت PM با تاخیر"
                                MessageBoxFa.Show("تاريخ پيشنهادي PM با تاريخ انجام آن مغايرت دارد...لطفا دليل کنسلي را لحاظ کنيد در غير اين صورت دليل پيش فرض لحاظ خواهد شد")
                                Return
                            End If
                        End If
                    Else
                        lb_MatchPM.ForeColor = Color.Red
                        lb_MatchPM.Text = "عدم وجود برنامه pm"
                        MessageBoxFa.Show("برنامه PM اين دستگاه ثبت نشده ...شما قادر به ذخيره سازي اين فرم کار نيستيد")
                        VAlidatePMProgramToSave = False
                    End If
                ElseIf f1.Rows.Count = 1 Then
                    VAlidatePMProgramToSave = True
                    Srl_PmProgramTpEdit = f1.Rows(0)("srl").ToString
                    Dim TarikhAnjamVaghee As String = f1.Rows(0)("تاریخ").ToString

                    If TarikhAnjamVaghee <> txt_FormKarTarikh.Value Then
                        Chk_SabtBaTakhir.Checked = True
                        cmb_cancelCuse.Enabled = True
                        'lb_MatchPM.Visible = False
                        lb_MatchPM.ForeColor = Color.Red
                        lb_MatchPM.Text = "ثبت PM با تاخیر"
                        MessageBoxFa.Show("تاريخ پيشنهادي PM با تاريخ انجام آن مغايرت دارد...لطفا دليل کنسلي را لحاظ کنيد در غير اين صورت دليل پيش فرض لحاظ خواهد شد")
                    Else
                        lb_MatchPM.ForeColor = Color.Green
                        Chk_SabtBaTakhir.Checked = False
                        lb_MatchPM.Text = "منطبق بر برنامه pm"
                    End If
                Else
                    For i As Integer = 0 To f1.Rows.Count - 1
                        Dim TarikhAnjamVaghee As String = f1.Rows(i)("تاریخ").ToString
                        If TarikhAnjamVaghee = txt_FormKarTarikh.Value Then
                            VAlidatePMProgramToSave = True
                            Srl_PmProgramTpEdit = f.Rows(i)("srl").ToString
                            lb_MatchPM.ForeColor = Color.Green
                            lb_MatchPM.Text = "منطبق بر برنامه pm"
                            Return
                        End If
                    Next
                    MessageBoxFa.Show("برای این تجهیز بیشتر از یک برنامه پی ام ثبت شده است .لطفا یکی را انتخاب نمائید")
                    Dim selectpm As Frm_SelectPmProgram = New Frm_SelectPmProgram(f1)
                    selectpm.ShowDialog()
                    If selectpm.Selected_Srl <> -1 Then
                        VAlidatePMProgramToSave = True
                        Chk_SabtBaTakhir.Checked = True
                        cmb_cancelCuse.Enabled = True
                        'lb_MatchPM.Visible = False
                        Srl_PmProgramTpEdit = selectpm.Selected_Srl

                        lb_MatchPM.ForeColor = Color.Red
                        lb_MatchPM.Text = "ثبت PM با تاخیر"
                        MessageBoxFa.Show("تاريخ پيشنهادي PM با تاريخ انجام آن مغايرت دارد...لطفا دليل کنسلي را لحاظ کنيد در غير اين صورت دليل پيش فرض لحاظ خواهد شد")
                        Return
                    End If
                End If
            Else
                Dim selectpm As Frm_SelectPmProgram = New Frm_SelectPmProgram(f)
                selectpm.ShowDialog()
                If selectpm.Selected_Srl <> -1 Then
                    If BaseDataObject.DataAccess.ExecScalar("select count(*) from Pm_ExecutePmProgram where ExecuteDate<>'' and not ExecuteDate is null and Srl_Pm_PmProgram=" + selectpm.Selected_Srl.ToString()) > 0 Then
                        If MessageBoxFa.Show("این برنامه قبلا تاریخ انجام خورده است آیا مایلی فرم کار دیگری برای آن ثبت شود؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                            InsertNewPMExecute = 1
                            Srl_PmProgramTpEdit = selectpm.Selected_Srl
                            VAlidatePMProgramToSave = True
                            If txt_FormKarTarikh.Value = selectpm.pm_date Then
                                lb_MatchPM.ForeColor = Color.Green
                                Chk_SabtBaTakhir.Checked = False
                                lb_MatchPM.Text = "منطبق بر برنامه pm"
                            Else
                                Chk_SabtBaTakhir.Checked = True
                                cmb_cancelCuse.Enabled = True
                                'lb_MatchPM.Visible = False
                                lb_MatchPM.ForeColor = Color.Red
                                lb_MatchPM.Text = "ثبت PM با تاخیر"
                                MessageBoxFa.Show("تاريخ پيشنهادي PM با تاريخ انجام آن مغايرت دارد...لطفا دليل کنسلي را لحاظ کنيد در غير اين صورت دليل پيش فرض لحاظ خواهد شد")
                                Return
                            End If
                        End If
                    Else
                        Srl_PmProgramTpEdit = selectpm.Selected_Srl
                        VAlidatePMProgramToSave = True
                        If txt_FormKarTarikh.Value = selectpm.pm_date Then
                            lb_MatchPM.ForeColor = Color.Green
                            Chk_SabtBaTakhir.Checked = False
                            lb_MatchPM.Text = "منطبق بر برنامه pm"
                        Else
                            Chk_SabtBaTakhir.Checked = True
                            cmb_cancelCuse.Enabled = True
                            'lb_MatchPM.Visible = False
                            lb_MatchPM.ForeColor = Color.Red
                            lb_MatchPM.Text = "ثبت PM با تاخیر"
                            MessageBoxFa.Show("تاريخ پيشنهادي PM با تاريخ انجام آن مغايرت دارد...لطفا دليل کنسلي را لحاظ کنيد در غير اين صورت دليل پيش فرض لحاظ خواهد شد")
                            Return
                        End If
                    End If
                End If
            End If
        End If
        'End If
    End Sub

    Private Sub txt_FormKarTarikh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txt_FromKarNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FromKarNo.TextChanged
        If CheckForRepeat() Then
            MessageBoxFa.Show("با این شماره فرم کار و تاریخ قبلا ثبت شده است ")
            txt_FromKarNo.Focus()
        End If
    End Sub

    Private Sub txt_FromKarNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FromKarNo.Leave
        For Each language As InputLanguage In InputLanguage.InstalledInputLanguages
            If language.Culture.EnglishName.Contains("Persian") Or language.Culture.EnglishName.Contains("Farsi") Then
                InputLanguage.CurrentInputLanguage = language
                Return
            End If
        Next
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, lb_Posttype.Click

    End Sub

    Private Sub Btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_New.Click
        If (FormState = FormStates.Edit) Then
            If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.No) Then
                Return
            End If
        End If
        ClearForm()
        _Ts_Sum_NafarSat = New TimeSpan
        _Ts_Sum_EzafeKareFormKar = New TimeSpan
        _Ts_Sum_EzafeKarTaradod = New TimeSpan
        Cmb_Group_SelectedIndexChanged(Nothing, Nothing)
        dt_Workform_EibForm.Clear()
        dt_Workform_Kala.Clear()
        lbl_RozeHafte.Text = "روز هفته"
        txt_Date.Value = Setting.TarikheJary
        isTatil = False
        Try
            cmb_HazineCode.SelectedValue = Setting.Default_Code_Hazine.PropValue
            Cmb_PostTo.SelectedValue = 574
            Cmb_PostFrom.SelectedValue = 574
            cmb_PmWorkDis.SelectedValue = 16843
        Catch ex As Exception

        End Try
        txt_FromKarNo.Focus()
        Srl_Master = -1
    End Sub

    'Private Sub txt_FormKarTarikh_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FormKarTarikh.Leave
    '    Dim TaikhFormDate As String = ""
    '    Dim jari As FarsiDateFun
    '    Dim TaikhForm As FarsiDateFun
    '    Dim dif As Integer
    '    If Not txt_FormKarTarikh.Value Is DBNull.Value Then
    '        TaikhFormDate = txt_FormKarTarikh.Value.ToString()
    '        TaikhFormDate = txt_Date.Value.ToString()
    '    End If
    '    'TaikhForm = New FarsiDateFun(TaikhFormDate.Substring(0, 4), TaikhFormDate.Substring(5, 2), TaikhFormDate.Substring(8))

    '    If TaikhFormDate <> "" Then
    '        TaikhForm = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))

    '    Else
    '        TaikhForm = New FarsiDateFun(txt_FormKarTarikh.Value.ToString().Substring(0, 4), txt_FormKarTarikh.Value.ToString().Substring(5, 2), txt_FormKarTarikh.Value.ToString().Substring(8))

    '    End If
    '    jari = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
    '    dif = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(jari), VB_Component.FarsiDateFun.F2E(TaikhForm))
    '    If Setting.Mojaz_Date.PropValue < dif Then
    '        MessageBoxFa.Show("تست ")
    '    End If

    'End Sub


    'Private Sub txt_FormKarTarikh_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FormKarTarikh.Enter
    '    Dim TaikhFormDate As String = ""
    '    Dim jari As FarsiDateFun
    '    Dim TaikhForm As FarsiDateFun
    '    Dim dif As Integer
    '    If Not txt_FormKarTarikh.Value Is DBNull.Value Then
    '        TaikhFormDate = txt_FormKarTarikh.Value.ToString()
    '        TaikhFormDate = txt_Date.Value.ToString()
    '    End If
    '    'TaikhForm = New FarsiDateFun(TaikhFormDate.Substring(0, 4), TaikhFormDate.Substring(5, 2), TaikhFormDate.Substring(8))

    '    If TaikhFormDate <> "" Then
    '        TaikhForm = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))

    '    Else
    '        TaikhForm = New FarsiDateFun(txt_FormKarTarikh.Value.ToString().Substring(0, 4), txt_FormKarTarikh.Value.ToString().Substring(5, 2), txt_FormKarTarikh.Value.ToString().Substring(8))

    '    End If
    '    jari = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
    '    dif = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(TaikhForm), VB_Component.FarsiDateFun.F2E(jari))
    '    If Setting.Mojaz_Date.PropValue < dif Then
    '        MessageBoxFa.Show("تست ")
    '    End If

    'End Sub

    Private Sub cmb_HazineCode_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_HazineCode.Enter
        Dim TaikhFormDate As String = ""
        Dim jari As FarsiDateFun
        Dim TaikhForm As FarsiDateFun
        Dim dif As Integer
        If Not txt_FormKarTarikh.Value Is DBNull.Value Then
            TaikhFormDate = txt_FormKarTarikh.Value.ToString()
            'TaikhFormDate = txt_Date.Value.ToString()
        End If
        'TaikhForm = New FarsiDateFun(TaikhFormDate.Substring(0, 4), TaikhFormDate.Substring(5, 2), TaikhFormDate.Substring(8))

        If TaikhFormDate <> "" Then
            TaikhForm = New FarsiDateFun(txt_FormKarTarikh.Value.ToString().Substring(0, 4), txt_FormKarTarikh.Value.ToString().Substring(5, 2), txt_FormKarTarikh.Value.ToString().Substring(8))

        Else
            TaikhForm = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))

        End If
        jari = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
        dif = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(TaikhForm), VB_Component.FarsiDateFun.F2E(jari))
        If Setting.Mojaz_Date.PropValue < dif Then
            MessageBoxFa.Show("خارج از بازه زمانی برای ثبت ")
            txt_FromKarNo.Focus()
        End If

    End Sub

End Class