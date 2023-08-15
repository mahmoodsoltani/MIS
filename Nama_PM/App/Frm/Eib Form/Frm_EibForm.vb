Imports GsmComm.PduConverter
Imports System.Threading
Imports GsmComm.PduConverter.SmartMessaging
Imports GsmComm.GsmCommunication
Public Class Frm_EibForm
    Dim Edit_CurrentIndex As Integer = -1
    Dim Srl_EditEibForm As Integer = -1
    Dim LoadAfterSave As Boolean = False
    Dim InsertedSRL As Integer = -1
    Dim Srl_Pm_Tajhiz_ForSave As Integer
    Dim Mobile As String = ""
    Dim SMS As String = ""
    Dim Srl_Sarparast As String = ""
    Dim SendSms As Boolean = False
    Dim Sarparast As String = ""


    Public Sub New(ByVal Srl_EibForm As Integer)
        InitializeComponent()
        If Srl_EibForm <> -1 Then
            Me.Srl_EditEibForm = Srl_EibForm
            Me.Pm_EibFormDetailsTableAdapter.Fill(Ds_Pm.pm_EibFormDetails, Srl_EibForm)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F6 Then
            Btn_Add_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F7 Then
            Btn_AddPeiro_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F2 Then
            btn_Save_Click(Nothing, Nothing)
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub

    Private Sub Frm_FixEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_ImportantPercentTableAdapter.Fill(Me.Ds_Pm.Pm_ImportantPercent)
        ReSortPeiroNumber()
        MyBase.StatusStrip1.Items.Add("F2 دخيره نهایی")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("F6 ثبت نقص")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("F7 ثبت پیرو")
        MyBase.StatusStrip1.Items.Add("-")
        Me.Pm_WorkSharhTableAdapter.Fill(Me.Ds_Pm.Pm_WorkSharh)
        Me.Pm_FixEibDisTableAdapter.Fill(Me.Ds_Pm.Pm_FixEibDis)
        Me.Pm_WorkDisTableAdapter.Fill(Me.Ds_Pm.Pm_WorkDis)
        txt_ReferenceDate.Value = Setting.TarikheJary
        txt_EibFormN.Value = BaseDataObject.DataAccess.FindMax("Pm_EibFormMaster", "EibFormNumber")
        'txt_EibFormN.Value = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(EibFormNumber),1) from Pm_EibFormMaster ")) + 1
        Me.Pm_EibFormTableAdapter.Fill(Me.Ds_Pm.pm_EibForm, -1, -1, -1, "", "")
        Me.Pm_EibTypeTableAdapter.Fill(Me.Ds_Pm.Pm_EibType)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, Cmb_SrlVahed.SelectedValue)
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_EibTypeTableAdapter.Fill(Me.Ds_Pm.Pm_EibType)
        chk_SendSms.Checked = False
        cmb_WorkDis.SelectedIndex = -1
        cmb_FixDis.SelectedIndex = -1
        If Srl_EditEibForm <> -1 Then
            Dim dr_Master As DataRow = BaseDataObject.DataAccess.GetRow("Pm_EibFormMaster", "Srl=" + Srl_EditEibForm.ToString)
            If (dr_Master Is Nothing) Then
                Return
                Me.Close()
            End If
            txt_EibFormN.Value = IIf(dr_Master("EibFormNumber") Is DBNull.Value, CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(EibFormNumber),1) from Pm_EibFormMaster ")) + 1, dr_Master("EibFormNumber"))
            txt_EibFormDate.Value = dr_Master("EibFormDate")
            txt_OrginalN.Value = dr_Master("OrginalEibFormNumber")
            txt_OrginalDate.Value = dr_Master("OriginalEibFormDate")
            Cmb_SrlPost.SelectedValue = dr_Master("Srl_Pm_Post")
            Pm_EibFormDetailsTableAdapter.Fill(Ds_Pm.pm_EibFormDetails, Srl_EditEibForm)
            Pm_EibFormPeiroTableAdapter.Fill(Ds_Pm.Pm_EibFormPeiro, Srl_EditEibForm)
            txt_ReferenceDate.Value = dr_Master("ReferenceDate")
            Cmb_SrlVahed.SelectedValue = dr_Master("Srl_Pm_Vahed")
            Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, Cmb_SrlVahed.SelectedValue)
            cmb_SrlGroup.SelectedValue = dr_Master("Srl_Pm_Group")
            txt_ReceptionDate.Value = dr_Master("ReceptionDate")
            txt_WorkFormN.Value = dr_Master("WorkFormNumber")
            txt_EibFixdate.Value = dr_Master("EibFixDate")
            cmb_WorkDis.Text = dr_Master("WorkDis")
            chk_IsUndecided.Checked = IIf(dr_Master("IsUnDecided") Is DBNull.Value, False, dr_Master("IsUnDecided"))

            Dim query As String = "select srl,WorkFormNo,WorkFormTarikh,No  from pm_workform_Master where srl in " & _
                                    "(select Srl_Pm_WorkForm_Master from Pm_WorkForm_EibForm   " & _
                                    " where EibFormNo = '" + txt_OrginalN.Value + "' and EibFormDate ='" + txt_OrginalDate.Value + "')"
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow(query)
            If Not dr Is Nothing Then
                txt_No.Value = dr(3).ToString()
            End If
        Else
            txt_EibFormDate.Value = Setting.TarikheJary
        End If
        cmb_EibType_SelectedIndexChanged(Nothing, Nothing)
        PublicFunction.CheckGSMModem()
        If Setting.Signal < 0 Then
            'MessageBoxFa.Show("مودم به سیستم متصل نمی باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lb_ModemNot.Text = "برای ارسال پیامک مودم غیر فعال است!"
            lb_ModemNot.ForeColor = Color.Red
            chk_SendSms.Checked = False
            chk_SendSms.Enabled = False
        Else
            lb_ModemNot.Text = "مودم فعال است"
            lb_ModemNot.ForeColor = Color.Green
            chk_SendSms.Checked = True
            chk_SendSms.Enabled = True
        End If
        UpdateLable()
    End Sub

    Private Sub Btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click

        If Edit_CurrentIndex <> -1 Then
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("SrlEibType") = cmb_EibType.SelectedValue
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("نوع عیب") = cmb_EibType.Text
            If Not cmb_ImportantPercent.SelectedValue Is Nothing Then
                DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
                , DataView).Table.Rows(Edit_CurrentIndex).Item("Srl_Pm_importantPercent") = cmb_ImportantPercent.SelectedValue
            End If
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("اهمیت") = cmb_ImportantPercent.Text
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("توضیحات") = cmb_FixDis.Text
            If Srl_Pm_Tajhiz_ForSave <> -1 Then
                DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
                , DataView).Table.Rows(Edit_CurrentIndex).Item("نام") = txt_TajhizNameForSave.Value
                DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
                , DataView).Table.Rows(Edit_CurrentIndex).Item("Srl_Tajhiz") = Srl_Pm_Tajhiz_ForSave
            End If
            Btn_Edit.Enabled = True
            DataGridView1.Enabled = True
            Btn_Del.Enabled = True
        Else
            Dim dr As DataRow = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.NewRow
            dr("توضیحات") = cmb_FixDis.Text
            dr("نوع عیب") = cmb_EibType.Text
            dr("SrlEibType") = cmb_EibType.SelectedValue
            dr("اهمیت") = cmb_ImportantPercent.Text
            dr("Srl_Pm_importantPercent") = cmb_ImportantPercent.SelectedValue
            dr("Srl_Tajhiz") = Srl_Pm_Tajhiz_ForSave
            dr("نام") = txt_TajhizNameForSave.Value
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.Rows.Add(dr)
        End If
        cmb_EibType.SelectedIndex = 0
        cmb_FixDis.Text = ""
        cmb_FixDis.SelectedIndex = -1
        txt_TajhizNameForSave.Value = ""
        Srl_Pm_Tajhiz_ForSave = -1
        cmb_EibType.Focus()

    End Sub

    Private Sub Btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click
        'Edit_CurrentIndex = FindSrl(DataGridView1, FindSerialPromtType.Edit, False, True, True)
        'If Edit_CurrentIndex = -1 Then
        '    Return
        'End If
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        Edit_CurrentIndex = DataGridView1.CurrentRow.Index
        cmb_EibType.SelectedValue = DataGridView1.CurrentRow.Cells(2).Value
        cmb_ImportantPercent.SelectedValue = IIf(DataGridView1.CurrentRow.Cells(6).Value Is DBNull.Value, -1, DataGridView1.CurrentRow.Cells(6).Value)
        cmb_FixDis.Text = DataGridView1.CurrentRow.Cells(4).Value
        Application.DoEvents()
        txt_TajhizNameForSave.Text = IIf(DataGridView1.CurrentRow.Cells(7).Value Is DBNull.Value, "", DataGridView1.CurrentRow.Cells(7).Value)
        Srl_Pm_Tajhiz_ForSave = IIf(DataGridView1.CurrentRow.Cells(8).Value Is DBNull.Value, -1, DataGridView1.CurrentRow.Cells(8).Value)
        Btn_Edit.Enabled = False
        DataGridView1.Enabled = False
        Btn_Del.Enabled = False
        cmb_EibType.Focus()
    End Sub

    Private Sub Btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Del.Click
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Delete( _
        DataGridView1.CurrentRow.Index)
        Edit_CurrentIndex = -1
    End Sub

    Function ExistPeiro(ByVal Srl As String) As Boolean
        For Each dr As DataGridViewRow In DataGridView2.Rows
            If dr.Cells(1).Value = Srl Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Btn_AddPeiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AddPeiro.Click
        Dim Srl As Integer = -1
        If txt_PeiroNo.Value <> "" Then
            For Each dr As DataGridViewRow In DataGridView2.Rows
                If dr.Cells(2).Value = txt_PeiroNo.Value Then
                    MessageBoxFa.Show("این فرم نقص قبلا انتخاب شده است", "", MessageBoxButtons.OK)
                    txt_PeiroNo.Focus()
                    Return
                End If
            Next
            Dim New_datarow As DataRow = BaseDataObject.DataAccess.GetRow("pm_EibFormMaster", "OrginalEibFormNumber='" + txt_PeiroNo.Value + "' AND OriginalEibFormDate='" + txt_PeiroDate.Value + "'")
            If Not New_datarow Is Nothing Then
                Dim dr As DataRow = DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table.NewRow
                dr("Srl_Pm_EibFormMasterPeiro") = New_datarow("Srl")
                dr("شماره فرم عیب") = New_datarow("OrginalEibFormNumber")
                dr("تاریخ فرم عیب") = New_datarow("OriginalEibFormDate")
                If Not ExistPeiro(New_datarow("Srl")) Then
                    DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table.Rows.Add(dr)
                End If
            Else
                If MessageBoxFa.Show("فرم نقص با این شماره و تاریخ وجود ندارد. آیا مایلید فرم نقص با این اطلاعات ثبت شود؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    Dim New_EibFormRow As DataRow = BaseDataObject.DataAccess.NewRow("pm_EibFormMaster")
                    New_EibFormRow("OrginalEibFormNumber") = txt_PeiroNo.Value
                    New_EibFormRow("EibFormNumber") = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(EibFormNumber),1) from Pm_EibFormMaster")) + 1
                    New_EibFormRow("OriginalEibFormDate") = txt_PeiroDate.Value
                    New_EibFormRow("EibFormDate") = Setting.TarikheJary
                    New_EibFormRow("ReferenceDate") = txt_ReferenceDate.Value
                    New_EibFormRow("Srl_Pm_Post") = Cmb_SrlPost.SelectedValue
                    New_EibFormRow("Srl_Pm_Vahed") = IIf(Cmb_SrlVahed.SelectedValue Is Nothing, DBNull.Value, Cmb_SrlVahed.SelectedValue)
                    New_EibFormRow("Srl_Pm_Group") = IIf(cmb_SrlGroup.SelectedValue Is Nothing, DBNull.Value, cmb_SrlGroup.SelectedValue)
                    Srl = BaseDataObject.DataAccess.InsertWithLastId(New_EibFormRow, False)
                    If Srl <> -1 Then
                        Dim dt_detail As DataTable = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table
                        Dim dr_EibFormDetail As DataRow = BaseDataObject.DataAccess.NewRow("Pm_EibFormDetails")
                        Dim dr_det As DataRow = dt_detail.NewRow
                        dr_EibFormDetail("Srl_Pm_EibFormMaster") = Srl
                        dr_EibFormDetail("Srl_SubmitUser") = Setting.Srl_User
                        dr_EibFormDetail("SubmitDate") = Setting.Now
                        For Each dr_det In dt_detail.Rows
                            Try
                                dr_EibFormDetail("Srl_Pm_EibType") = dr_det("SrlEibType")
                                dr_EibFormDetail("EibDis") = dr_det("توضیحات")
                                BaseDataObject.DataAccess.Insert(dr_EibFormDetail, False)
                            Catch
                            End Try
                        Next

                        New_EibFormRow = BaseDataObject.DataAccess.GetRow("pm_EibFormMaster", Srl)
                        Dim dr As DataRow = DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table.NewRow
                        dr("Srl_Pm_EibFormMasterPeiro") = Srl
                        dr("شماره فرم عیب") = New_EibFormRow("OrginalEibFormNumber")
                        dr("تاریخ فرم عیب") = New_EibFormRow("OriginalEibFormDate")
                        If Not ExistPeiro(Srl.ToString()) Then
                            DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table.Rows.Add(dr)
                        End If
                    End If
                End If
            End If
        ElseIf Not lk_Peiro.Result Is Nothing Then
            'For Each dr1 As DataGridViewRow In DataGridView2.Rows
            '    If dr1.Cells(1).Value = txt_PeiroNo.Value Then
            '        MessageBoxFa.Show("این فرم نقص قبلا انتخاب شده است", "", MessageBoxButtons.OK)
            '        txt_PeiroNo.Focus()
            '        Return
            '    End If
            'Next
            'Dim dr As DataRow = DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table.NewRow
            'dr("Srl_Pm_EibFormMasterPeiro") = lk_Peiro.Result(0)
            'dr("شماره فرم عیب") = lk_Peiro.Result(3)
            'dr("تاریخ فرم عیب") = lk_Peiro.Result(4)
            'If Not ExistPeiro(lk_Peiro.Result(3)) Then
            '    DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table.Rows.Add(dr)
            'End If
        End If
        txt_PeiroNo.Value = ""
        txt_PeiroDate.Clear()
        txt_PeiroNo.Focus()
        ReSortPeiroNumber()
        If Srl_EditEibForm = -1 Then
            txt_EibFormN.Value = BaseDataObject.DataAccess.FindMax("Pm_EibFormMaster", "EibFormNumber")
        End If
    End Sub

    Private Sub ReSortPeiroNumber()
        Dim dt_Peiro As DataTable = DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table
        Dim count As Integer = 1
        For Each dr As DataGridViewRow In DataGridView2.Rows
            dr.Cells("Number").Value = count
            count = count + 1
        Next
    End Sub

    Private Sub Btn_DelPeiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_DelPeiro.Click
        If DataGridView2.CurrentRow Is Nothing Then
            Return
        End If

        DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Delete( _
        DataGridView2.CurrentRow.Index)
        ReSortPeiroNumber()
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim tr As Thread = Nothing
        If txt_OrginalN.Value = "" Then
            MessageBox.Show("لطفا شماره فرم نقص را وارد کنید")
            txt_OrginalN.Focus()
            Return
        End If
        If txt_OrginalDate.Value = "" Then
            MessageBox.Show("لطفا تاریخ فرم نقص را وارد کنید")
            txt_OrginalDate.Focus()
            Return
        End If
        If Cmb_SrlPost.SelectedValue Is Nothing Then
            MessageBox.Show("لطفا پست را وارد کنید")
            Cmb_SrlPost.Focus()
            Return
        End If

        Dim tempdr As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_EibFormMaster where EibFormNumber=" + txt_EibFormN.Value)
        If Not tempdr Is Nothing And Srl_EditEibForm = -1 Then
            MessageBox.Show("شماره فرم تکراری است")
            txt_EibFormN.Focus()
            Return
        End If
        If Srl_EditEibForm <> -1 And txt_EibFormN.Value <> CInt(BaseDataObject.DataAccess.ExecScalar("select EibFormNumber from Pm_EibFormMaster where srl=" + Srl_EditEibForm.ToString())) Then
            MessageBox.Show("شماره فرم تکراری است")
            txt_EibFormN.Focus()
            Return
        End If
        Dim SetPeiro As Boolean = False
        If (txt_WorkFormN.Value <> "" Or txt_EibFixdate.Value <> "" Or cmb_WorkDis.Text <> "") And DataGridView2.RowCount > 0 Then
            If MessageBoxFa.Show("آیا مایلید اطلاعات رفع نقص در فرم نقص پیرو نیز ثبت شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                SetPeiro = True
            End If
        End If
        Dim Srl As Integer = -1
        Dim dr_PeiroForm As DataRow
        Dim dt_detail As DataTable = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table
        Dim dt_Peiro As DataTable = DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table
        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_EibFormMaster")
        If dr Is Nothing Then
            MessageBoxFa.Show("error in save data")
            Return
        End If
        If CBool(Setting.Use_Sms_Template.PropValue) Then
            SMS = Setting.Sms_Template.PropValue.ToString()
            SMS = SMS.Replace("@s", Sarparast).Replace("@S", Sarparast)
            SMS = SMS.Replace("@p", Cmb_SrlPost.Text).Replace("@P", Cmb_SrlPost.Text)
            SMS = SMS.Replace("@d", txt_OrginalDate.Value).Replace("@D", txt_OrginalDate.Value)
            If txt_TajhizNameForSave.Value <> "" Then
                SMS = SMS.Replace("@t", txt_TajhizNameForSave.Value).Replace("@T", txt_TajhizNameForSave.Value)
            End If
        Else
            SMS = "نقص در پست " + Cmb_SrlPost.Text + Environment.NewLine + "(" + txt_OrginalDate.Value + ") " + Environment.NewLine
            If txt_TajhizNameForSave.Value <> "" Then
                SMS = SMS + " در تجهیز : " + txt_TajhizNameForSave.Value + Environment.NewLine
            End If
        End If


        dr("EibFormNumber") = txt_EibFormN.Value
        dr("EibFormDate") = txt_EibFormDate.Value
        dr("OrginalEibFormNumber") = txt_OrginalN.Value
        dr("OriginalEibFormDate") = txt_OrginalDate.Value
        dr("Srl_Pm_Post") = Cmb_SrlPost.SelectedValue
        dr("ReferenceDate") = txt_ReferenceDate.Value
        dr("Srl_Pm_Vahed") = IIf(Cmb_SrlVahed.SelectedValue Is Nothing, DBNull.Value, Cmb_SrlVahed.SelectedValue)
        dr("Srl_Pm_Group") = IIf(cmb_SrlGroup.SelectedValue Is Nothing, DBNull.Value, cmb_SrlGroup.SelectedValue)
        dr("ReceptionDate") = txt_ReceptionDate.Value
        dr("WorkFormNumber") = txt_WorkFormN.Value
        dr("EibFixDate") = txt_EibFixdate.Value
        dr("WorkDis") = cmb_WorkDis.Text
        dr("IsUnDecided") = chk_IsUndecided.Checked
        dr("Srl_SubmitUser") = Setting.Srl_User
        dr("SubmitDate") = Setting.Now

        If Srl_EditEibForm <> -1 Then
            dr("Srl") = Srl_EditEibForm
            BaseDataObject.DataAccess.BeginTransaction()
            If BaseDataObject.DataAccess.Update(dr, 0) Then
                BaseDataObject.DataAccess.ExecQuery("DELETE FROM Pm_EibFormdetails where Srl_Pm_EibFormMaster=" + Srl_EditEibForm.ToString)

                Dim dr_EibFormDetail As DataRow = BaseDataObject.DataAccess.NewRow("Pm_EibFormDetails")
                Dim dr_det As DataRow = dt_detail.NewRow
                dr_EibFormDetail("Srl_Pm_EibFormMaster") = Srl_EditEibForm
                dr_EibFormDetail("Srl_SubmitUser") = Setting.Srl_User
                dr_EibFormDetail("SubmitDate") = Setting.Now
                If CBool(Setting.Use_Sms_Template.PropValue) Then
                Else
                    SMS = SMS + "نواقص:" + Environment.NewLine
                End If
                For Each dr_det In dt_detail.Rows
                    Try
                        dr_EibFormDetail("Srl_Pm_EibType") = dr_det("SrlEibType")
                        dr_EibFormDetail("Srl_Pm_ImportantPercent") = dr_det("Srl_Pm_ImportantPercent")
                        dr_EibFormDetail("EibDis") = dr_det("توضیحات")
                        dr_EibFormDetail("Srl_Pm_Hadese_KhesaratDevice") = dr_det("Srl_Tajhiz")
                        BaseDataObject.DataAccess.Insert(dr_EibFormDetail, False)
                        If CBool(Setting.Use_Sms_Template.PropValue) Then
                            SMS = SMS.Replace("@n", dr_det(2).ToString()).Replace("@N", dr_det(2).ToString())
                            SMS = SMS.Replace("@r", dr_det("توضیحات").ToString()).Replace("@R", dr_det("توضیحات").ToString())

                        Else
                            SMS = SMS + dr_det(2).ToString()
                            If dr_det(7).ToString() <> "" Then
                                SMS = SMS + "(" + dr_det(7).ToString() + ")"
                            End If
                            SMS = SMS + Environment.NewLine
                        End If
                    Catch
                    End Try
                Next

                BaseDataObject.DataAccess.ExecQuery("DELETE FROM Pm_EibFormPeiro where Srl_Pm_EibFormMaster=" + Srl_EditEibForm.ToString)
                Dim dr_EibFormPeiro As DataRow = BaseDataObject.DataAccess.NewRow("Pm_EibFormPeiro")
                Dim dr_Peiro As DataRow = dt_Peiro.NewRow
                dr_EibFormPeiro("Srl_Pm_EibFormMaster") = Srl_EditEibForm
                dr_EibFormPeiro("Srl_SubmitUser") = Setting.Srl_User
                dr_EibFormPeiro("SubmitDate") = Setting.Now
                For Each dr_Peiro In dt_Peiro.Rows
                    Try
                        dr_EibFormPeiro("Srl_Pm_EibFormMasterPeiro") = dr_Peiro("Srl_Pm_EibFormMasterPeiro")
                        BaseDataObject.DataAccess.Insert(dr_EibFormPeiro, False)
                        If SetPeiro Then
                            dr_PeiroForm = BaseDataObject.DataAccess.GetRow("PM_EibFormMaster", CInt(dr_Peiro("Srl_Pm_EibFormMasterPeiro")))
                            If Not dr_PeiroForm Is Nothing Then
                                dr_PeiroForm("WorkFormNumber") = txt_WorkFormN.Value
                                dr_PeiroForm("EibFixDate") = txt_EibFixdate.Value
                                dr_PeiroForm("WorkDis") = cmb_WorkDis.Text + "( بر اساس فرم نقص شماره" + txt_OrginalN.Value + ")"
                                BaseDataObject.DataAccess.Update(dr_PeiroForm, 0, False)
                            End If
                        End If
                    Catch
                    End Try
                Next
            End If

        Else
            BaseDataObject.DataAccess.BeginTransaction()
            Srl = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            If Srl = -1 Then
                MessageBoxFa.Show("error in save data")
                Return
            Else
                Dim dr_EibFormDetail As DataRow = BaseDataObject.DataAccess.NewRow("Pm_EibFormDetails")

                Dim dr_det As DataRow = dt_detail.NewRow
                dr_EibFormDetail("Srl_Pm_EibFormMaster") = Srl
                dr_EibFormDetail("Srl_SubmitUser") = Setting.Srl_User
                dr_EibFormDetail("SubmitDate") = Setting.Now
                If CBool(Setting.Use_Sms_Template.PropValue) Then
                Else
                    SMS = SMS + "نواقص:" + Environment.NewLine
                End If
                For Each dr_det In dt_detail.Rows
                    Try
                        dr_EibFormDetail("Srl_Pm_EibType") = dr_det("SrlEibType")
                        dr_EibFormDetail("EibDis") = dr_det("توضیحات")
                        dr_EibFormDetail("Srl_Pm_ImportantPercent") = dr_det("Srl_Pm_ImportantPercent")
                        dr_EibFormDetail("Srl_Pm_Hadese_KhesaratDevice") = dr_det("Srl_Tajhiz")
                        BaseDataObject.DataAccess.Insert(dr_EibFormDetail, False)
                        If CBool(Setting.Use_Sms_Template.PropValue) Then
                            SMS = SMS.Replace("@n", dr_det(2).ToString()).Replace("@N", dr_det(2).ToString())
                            SMS = SMS.Replace("@r", dr_det("توضیحات").ToString()).Replace("@R", dr_det("توضیحات").ToString())

                        Else
                            SMS = SMS + dr_det(2).ToString()
                            If dr_det(7).ToString() <> "" Then
                                SMS = SMS + "(" + dr_det(7).ToString() + ")"
                            End If
                            SMS = SMS + Environment.NewLine
                        End If
                    Catch
                    End Try
                Next

                Dim dr_EibFormPeiro As DataRow = BaseDataObject.DataAccess.NewRow("Pm_EibFormPeiro")
                Dim dr_Peiro As DataRow = dt_Peiro.NewRow
                dr_EibFormPeiro("Srl_Pm_EibFormMaster") = Srl
                dr_EibFormPeiro("Srl_SubmitUser") = Setting.Srl_User
                dr_EibFormPeiro("SubmitDate") = Setting.Now
                For Each dr_Peiro In dt_Peiro.Rows
                    Try
                        dr_EibFormPeiro("Srl_Pm_EibFormMasterPeiro") = dr_Peiro("Srl_Pm_EibFormMasterPeiro")
                        BaseDataObject.DataAccess.Insert(dr_EibFormPeiro, False)
                        If SetPeiro Then
                            dr_PeiroForm = BaseDataObject.DataAccess.GetRow("PM_EibFormMaster", CInt(dr_Peiro("Srl_Pm_EibFormMasterPeiro")))
                            If Not dr_PeiroForm Is Nothing Then
                                dr_PeiroForm("WorkFormNumber") = txt_WorkFormN.Value
                                dr_PeiroForm("EibFixDate") = txt_EibFixdate.Value
                                dr_PeiroForm("WorkDis") = cmb_WorkDis.Text + "( بر اساس فرم نقص شماره" + txt_OrginalN.Value + ")"
                                BaseDataObject.DataAccess.Update(dr_PeiroForm, 0, False)
                            End If
                        End If
                    Catch
                    End Try
                Next
            End If
            InsertedSRL = Srl


        End If
        If SendSms Then
            Try
                Dim param As String() = {SMS, Mobile, Srl, Srl_Sarparast}
                tr = New Thread(AddressOf PublicFunction.SendSMS)
                tr.Start(param)
                'Me.Cursor = Cursors.WaitCursor
                'SendSMS()
                'Me.Cursor = Cursors.Default
            Catch ex As Exception

            End Try
        End If
        If Not BaseDataObject.DataAccess.Commit Then
            MessageBoxFa.Show("ثبت اطلاعات با مشكل مواجه شد")
        Else
            MessageBoxFa.Show("اطلاعات با موفقیت ثبت شد")
            'If Srl_EditEibForm <> -1 Then
            '    Me.Close()
            'End If
        End If
        Clear()
    End Sub

    Private Sub Clear()
        Pm_EibFormDetailsTableAdapter.Fill(Ds_Pm.pm_EibFormDetails, -2)
        txt_EibFormN.Value = ""
        txt_EibFormDate.Value = Setting.TarikheJary
        txt_ReferenceDate.Value = Setting.TarikheJary
        txt_OrginalN.Clear()
        txt_OrginalDate.Clear()
        Cmb_SrlPost.SelectedValue = -1
        txt_ReferenceDate.Clear()
        Cmb_SrlVahed.SelectedValue = -1
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, Cmb_SrlVahed.SelectedValue)
        txt_ReceptionDate.Clear()
        txt_WorkFormN.Clear()
        cmb_WorkDis.SelectedIndex = -1
        txt_ReferenceDate.Clear()
        txt_EibFixdate.Clear()
        txt_WorkFormN.Clear()
        txt_No.Clear()
        cmb_WorkDis.Text = ""
        Pm_EibFormPeiroTableAdapter.Fill(Ds_Pm.Pm_EibFormPeiro, -2)
        txt_EibFormN.Value = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(EibFormNumber),1) from Pm_EibFormMaster ")) + 1
        txt_OrginalN.Focus()
        Srl_EditEibForm = -1
        Edit_CurrentIndex = -1
        lb_GroupBoss.Text = ""
        chk_IsUndecided.Checked = False
        lb_GroupBoss.Text = "'"
        chk_SendSms.Checked = False
    End Sub

    Private Sub Cmb_SrlVahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_SrlVahed.SelectedIndexChanged, Cmb_SrlPost.SelectedValueChanged
        Ds_Pm.Pm_FindGroup.Rows.Clear()
        Me.Ds_Pm.Pm_Group.Rows.Clear()
        If Cmb_SrlVahed.SelectedValue > -1 Then
            Pm_FindGroupTableAdapter.Fill(Me.Ds_Pm.Pm_FindGroup, Cmb_SrlPost.SelectedValue, Cmb_SrlVahed.SelectedValue)
            cmb_SrlGroup.DataSource = Me.Ds_Pm.Pm_FindGroup
            If Ds_Pm.Pm_FindGroup.Rows.Count <= 0 Then
                Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, Cmb_SrlVahed.SelectedValue)
                cmb_SrlGroup.DataSource = Me.Ds_Pm.Pm_Group
            End If
        End If
        UpdateLable()
    End Sub

    Private Sub txt_PeiroWibFormNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PeiroNo.TextChanged

    End Sub

    Private Sub FindEibForm(ByVal obj1 As Object, ByVal e As System.EventArgs) Handles txt_OrginalN.TextChanged, txt_OrginalDate.ValueChanged, txt_OrginalDate.Leave
        Try
            If Srl_EditEibForm = -1 And txt_OrginalN.Text <> "" And txt_OrginalDate.Value <> "" Then
                Dim dr As DataTable = BaseDataObject.DataAccess.GetDataTable("select * from Pm_EibFormMaster where OrginalEibFormNumber ='" + txt_OrginalN.Value + "' ANd OriginalEibFormDate ='" + txt_OrginalDate.Value + "' ")
                If Not dr Is Nothing And dr.Rows.Count > 0 Then
                    If MessageBoxFa.Show("این فرم نقص قبلا در سیستم ثبت شده است.آیا مایلید آنرا ویرایش کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        Srl_EditEibForm = CInt(dr.Rows(0)("Srl"))
                        Me.Frm_FixEibForm_Load(Nothing, Nothing)
                    Else
                        txt_OrginalN.Focus()
                    End If
                End If

            End If
            'If DataGridView1.Rows.Count > 0 And TypeOf (obj1) Is VB_Component.ComboBox Then
            '    If MessageBoxFa.Show("برای این پست نوع نقص وابسته به تجهیز ثبت شده است آیا مائلید آنها را حذف نمائید؟", , MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            '        For Each R In DataGridView1.Rows
            '            DataGridView1.Rows.Remove(R)
            '        Next
            '    Else
            '        Cmb_SrlPost.Focus()
            '    End If
            'End If
        Catch
        End Try
        FindWorkForm()
    End Sub

    Private Sub FindWorkForm()
        ' If txt_OrginalN.Text <> "" And Cmb_SrlPost.SelectedValue > 0 And txt_OrginalDate.Value <> "" Then
        If txt_OrginalN.Value <> "" And txt_OrginalDate.Value <> "" Then
            Dim query As String = "select srl,WorkFormNo,WorkFormTarikh,No  from pm_workform_Master where srl in " & _
                                    "(select Srl_Pm_WorkForm_Master from Pm_WorkForm_EibForm   " & _
                                    " where EibFormNo = '" + txt_OrginalN.Value + "' and EibFormDate ='" + txt_OrginalDate.Value + "')"
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow(query)
            If Not dr Is Nothing Then
                txt_WorkFormN.Value = dr(1).ToString()
                txt_EibFixdate.Value = dr(2).ToString()
                txt_No.Value = dr(3).ToString()
                'cmb_WorkDis.Text = dr(2).ToString()
            End If
        End If
    End Sub

    Private Sub Cmb_SrlPost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_SrlPost.TextChanged
        'If Cmb_SrlPost.Text <> "" Then
        '    Cmb_SrlPost.SelectedIndex = Cmb_SrlPost.FindString(Cmb_SrlPost.Text)
        'End If
    End Sub

    Private Sub lk_Peiro_Selected(ByVal sender As System.Object, ByVal e As System.Data.DataRow) Handles lk_Peiro.Selected
        If Not lk_Peiro.Result Is Nothing Then
            txt_PeiroNo.Value = lk_Peiro.Result(3)
            txt_PeiroDate.Value = lk_Peiro.Result(4)
            lk_Peiro.ResetResult()
        End If
        'For Each dr1 As DataGridViewRow In DataGridView2.Rows
        '    If dr1.Cells(1).Value = txt_PeiroNo.Value Then
        '        MessageBoxFa.Show("این فرم نقص قبلا انتخاب شده است", "", MessageBoxButtons.OK)
        '        txt_PeiroNo.Focus()
        '        Return
        '    End If
        'Next
        'Dim dr As DataRow = DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table.NewRow
        'dr("Srl_Pm_EibFormMasterPeiro") = lk_Peiro.Result(0)
        'dr("شماره فرم عیب") = 
        'dr("تاریخ فرم عیب") = 
        'If Not ExistPeiro(lk_Peiro.Result(3)) Then
        '    DirectCast(DirectCast(DataGridView2.DataSource, BindingSource).List, DataView).Table.Rows.Add(dr)
        'End If

    End Sub

    Private Sub btn_Before_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Before.Click
        If txt_EibFormN.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(False)
                End If
            Else

                NextOrBeforeForm(False)
            End If
        End If
    End Sub

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click
        If txt_EibFormN.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(True)
                End If
            Else
                NextOrBeforeForm(True)
            End If
        End If
    End Sub

    Public Sub NextOrBeforeForm(ByVal Flag As Boolean)
        Dim FrmNo As Integer
        If Flag Then
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_EibFormMaster where EibFormNumber >" + txt_EibFormN.Value + " Order by EibFormNumber"))
        Else
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_EibFormMaster where EibFormNumber <" + txt_EibFormN.Value + " Order by EibFormNumber desc"))
        End If
        If FrmNo > 0 Then
            Clear()
            Srl_EditEibForm = FrmNo
            Me.Frm_FixEibForm_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_SHow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SHow.Click

        Dim Number As String = txt_EibFormN.Value
        Clear()
        txt_EibFormN.Value = Number
        Srl_EditEibForm = CInt(BaseDataObject.DataAccess.ExecScalar("select srl from Pm_EibFormMaster where EibFormNumber =" + Number))
        If Srl_EditEibForm = 0 Then
            MessageBox.Show("موردي يافت نشد")
            Return
        End If
        Frm_FixEibForm_Load(Nothing, Nothing)
    End Sub

    Private Sub cmb_SrlGroup_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_SrlGroup.Leave
        btn_Save.Focus()
    End Sub

    Private Sub btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Refresh.Click
        txt_EibFormN.Value = BaseDataObject.DataAccess.FindMax("Pm_EibFormMaster", "EibFormNumber")
        Clear()
    End Sub

    Private Sub cmb_FixDis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_FixDis.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Btn_Add_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txt_EibFormN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_EibFormN.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_SHow_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmb_EibType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_EibType.SelectedIndexChanged
        If Not cmb_EibType.SelectedValue Is Nothing Then
            Dim temp As Object = BaseDataObject.DataAccess.ExecScalar("select srl_pm_ImportantPercent from Pm_Eibtype where Pm_EibType.srl=" + cmb_EibType.SelectedValue.ToString())
            If Not temp Is DBNull.Value Then
                cmb_ImportantPercent.SelectedValue = temp
            Else
                cmb_ImportantPercent.SelectedValue = -1
            End If
        End If
    End Sub

    Private Sub btn_Attachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Attachment.Click
        If Srl_EditEibForm = -1 Then
            If MessageBoxFa.Show("قبل از اضافه کردن مدارک برای فرم نقص باید آن را ذخیره نمائید. آیا مائلید فرم نقص ثبت شود؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                btn_Save_Click(Nothing, Nothing)
                Srl_EditEibForm = InsertedSRL
                Frm_FixEibForm_Load(Nothing, Nothing)
            Else
                Return
            End If
        End If
        Dim s As New Frm_EibFormAttachment(Srl_EditEibForm)
        s.ShowDialog()
        LoadAfterSave = False
    End Sub

    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        If Cmb_SrlPost.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا پست را مشخص نمائید")
            Cmb_SrlPost.Focus()
            Return
        End If
        Dim s As New Frm_DeviceSelect(Cmb_SrlPost.SelectedValue)
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_TajhizNameForSave.Value = s.SelectedDevice.Text
            Srl_Pm_Tajhiz_ForSave = s.SelectedDevice.Srl
            Btn_Add.Focus()
        End If
    End Sub

    Private Sub Cmb_SrlPost_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_SrlPost.SelectedIndexChanged
        Try
            UpdateLable()
            If Srl_EditEibForm = -1 And txt_OrginalN.Text <> "" And txt_OrginalDate.Value <> "" Then
                Dim dr As DataTable = BaseDataObject.DataAccess.GetDataTable("select * from Pm_EibFormMaster where OrginalEibFormNumber ='" + txt_OrginalN.Value + "' ANd OriginalEibFormDate ='" + txt_OrginalDate.Value + "' ")
                If Not dr Is Nothing And dr.Rows.Count > 0 Then
                    If MessageBoxFa.Show("این فرم نقص قبلا در سیستم ثبت شده است.آیا مایلید آنرا ویرایش کنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        Srl_EditEibForm = CInt(dr.Rows(0)("Srl"))
                        Me.Frm_FixEibForm_Load(Nothing, Nothing)
                    Else
                        txt_OrginalN.Focus()
                    End If
                End If

            End If
            If DataGridView1.Rows.Count > 0 And TypeOf (sender) Is VB_Component.ComboBox Then
                If MessageBoxFa.Show("برای این پست نوع نقص وابسته به تجهیز ثبت شده است آیا مائلید آنها را حذف نمائید؟", , MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    For Each R In DataGridView1.Rows
                        DataGridView1.Rows.Remove(R)
                    Next
                Else
                    Cmb_SrlPost.Focus()
                End If
            End If
        Catch
        End Try
        FindWorkForm()
        Dim temp As Object
        temp = BaseDataObject.DataAccess.ExecScalar("select name from Pm_PostDetails ,pm_posttype where pm_posttype.srl=srl_pm_posttype and Srl_Pm_Post =" + IIf(Cmb_SrlPost.SelectedValue Is Nothing, -1, Cmb_SrlPost.SelectedValue).ToString())
        If Not temp Is Nothing Then
            lb_PostType.Text = temp.ToString()
        Else
            lb_PostType.Text = ""
        End If
    End Sub

    Private Sub cmb_SrlGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_SrlGroup.SelectedIndexChanged
        UpdateLable()
    End Sub
    Public Sub UpdateLable()
        If Not cmb_SrlGroup.SelectedValue Is Nothing Then
            If cmb_SrlGroup.SelectedIndex > -1 Then
                Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select Pm_Ashkhas .Name+'_'+Pm_Ashkhas.Family as [نام و نام خانوادگی] ,Pm_Ashkhas.Telephone1 " & _
                                                    " ,Pm_Ashkhas.srl from pm_group left join Pm_GroupMember" & _
                                                    " on Pm_Group .Srl = Srl_Pm_Group Left Join Pm_Ashkhas on" & _
                                                    " Srl_Acc_Ashkhas = Pm_Ashkhas.Srl" & _
                                                    " where  IsPrimary =1 and  Srl_Pm_Group =" + cmb_SrlGroup.SelectedValue.ToString())
                If Not dr Is Nothing Then
                    lb_GroupBoss.Text = dr(0).ToString() + " - همراه:" + dr(1).ToString()
                    Mobile = dr(1).ToString()
                    Sarparast = dr(0).ToString()
                    Srl_Sarparast = dr(2).ToString()
                Else
                    lb_GroupBoss.Text = " سرپرست گروه مشخص نمی باشد "
                    Mobile = ""
                End If
            Else
                Mobile = ""
            End If
        Else
            Mobile = ""
        End If
    End Sub

    Private Sub chk_SendSms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SendSms.CheckedChanged
        SendSms = chk_SendSms.Checked
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub txt_OrginalN_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_OrginalN.Leave
        For Each language As InputLanguage In InputLanguage.InstalledInputLanguages
            If language.Culture.EnglishName.Contains("Persian") Or language.Culture.EnglishName.Contains("Farsi") Then
                InputLanguage.CurrentInputLanguage = language
                Return
            End If
        Next
        FindEibForm(Nothing, Nothing)
    End Sub

    Private Sub txt_OrginalN_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_OrginalN.Enter, txt_PeiroNo.Enter
        For Each language As InputLanguage In InputLanguage.InstalledInputLanguages
            If language.Culture.EnglishName.Contains("English") Or language.Culture.EnglishName.Contains("En") Then
                InputLanguage.CurrentInputLanguage = language
                Return
            End If
        Next
    End Sub

    Private Sub txt_PeiroNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PeiroNo.Leave
        For Each language As InputLanguage In InputLanguage.InstalledInputLanguages
            If language.Culture.EnglishName.Contains("Persian") Or language.Culture.EnglishName.Contains("Farsi") Then
                InputLanguage.CurrentInputLanguage = language
                Return
            End If
        Next
    End Sub
End Class