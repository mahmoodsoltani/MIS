Imports System.Drawing.Drawing2D
Imports GsmComm.GsmCommunication
Imports System.IO.Ports

Public Class Frm_Main
    Dim FirstX As Integer
    Dim FirstY As Integer
    Dim DoDrag As Boolean = False
    Dim FormBtnState As BtnState = BtnState.Non
    Dim _Left As Integer = 0
    Dim _Speed As Integer = 10

    Enum BtnState
        Non
        BaseInfo
        Action
        Report
        Setting
    End Enum

    Private Sub Frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Setting.ConnectionString = VB_Component.DataBase.getConnection(, )
            VB_Component.Windows.ChangeConnectionString(Setting.ConnectionString, )
            Application.DoEvents()
            BaseDataObject.DataAccess = New CS_Component.DataAccess(Setting.ConnectionString, True)
            If BaseDataObject.DataAccess.CloseOnAttach Then
                End
            End If
        Catch ex As Exception
            MessageBoxFa.Show("Error in load Connection String")
            End
        End Try

        'Updater.CheckForUpdate()
        Management.ConnectionString = Setting.ConnectionString
re:
        Dim ls As LoginStatus = Security.Login()
        Select Case ls
            Case LoginStatus.Abort
                End
                Return
            Case LoginStatus.GroupIsBlocked
                VB_Component.MessageBoxFa.Show("ورود گروه شما به سیستم مجاز نیست.")
                GoTo re
            Case LoginStatus.UserIsDisabled
                VB_Component.MessageBoxFa.Show("حساب کاربری شما غیر فعال می باشد.")
                GoTo re
            Case LoginStatus.UsernameOrPasswordIsInvalid
                VB_Component.MessageBoxFa.Show("نام کاربری یا رمز عبور صحیح نیست.")
                GoTo re
        End Select
        If Security.LoggedInUser("Srl_Acc_Ashkhas") Is DBNull.Value Then
            MessageBoxFa.Show("این کاربر جزء پرسنل نمی باشد. لطفا به مدیر سیستم مراجعه نمائید.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GoTo re
        End If
        Setting.Srl_User = Security.LoggedInUser("Srl_Acc_Ashkhas")
        Setting.UserName = Security.LoggedInUser("Username")

        Dim s As New SplashScreen1
        s.ShowDialog()
        Security.ApplyPermission(Me)
        Application.DoEvents()

        ToolStripManager.Renderer = New CS_Component.Office2007Renderer()
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Size = New Drawing.Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height)
        Me.BringToFront()
        Application.DoEvents()
        pic_Azaraksh_Click(Nothing, Nothing)
        BaseDataObject.DataAccess.Delete("pm_workform_noseq", "srl_pm_ashkhas=" + Setting.Srl_User.ToString)
        VAC.Location = New Point(Me.Location.X + Me.Width - 170, Me.Location.Y + 30)
        ScrollingText1.Size = New Size(850, ScrollingText1.Size.Height)
        ScrollingText1.Location = New Point(Panel1.Location.X + 0, ScrollingText1.Location.Y)
        ScrollingText1.ScrollText = Setting.ModirMesage.PropValue.ToString
        pic_Azaraksh.Image = Graphic.ByteToImage(Setting.MainLogo.PropImage)
        TaskPane_Report.UseCustomTheme("Alfa.dll")
        TaskPane_BaeInfo.UseCustomTheme("Alfa.dll")
        TaskPane_Action.UseCustomTheme("Alfa.dll")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        For Each Exp As XPExplorerBar.Expando In TaskPane_Action.Expandos
            Exp.TitleImage = CType(resources.GetObject("Exp_FomeKar.TitleImage"), System.Drawing.Image)
        Next
        For Each Exp As XPExplorerBar.Expando In TaskPane_Report.Expandos
            Exp.TitleImage = CType(resources.GetObject("Exp_FomeKar.TitleImage"), System.Drawing.Image)
        Next
        For Each Exp As XPExplorerBar.Expando In TaskPane_BaeInfo.Expandos
            Exp.TitleImage = CType(resources.GetObject("Exp_FomeKar.TitleImage"), System.Drawing.Image)
        Next
        UpdateSignal()
    End Sub
    Private Sub UpdateSignal()

        If Setting.Signal = -1 Then
            Me.pb_Signal.Image = Global.Nama_PM.My.Resources.Resources.NotConnect
            Me.Signal.SetToolTip(Me.pb_Signal, "عدم اتصال مودم")
        ElseIf Setting.Signal < 10 Then
            Me.pb_Signal.Image = Global.Nama_PM.My.Resources.Resources.NoSignal
            Me.Signal.SetToolTip(Me.pb_Signal, "بدون سیگنال")
        ElseIf Setting.Signal < 15 Then
            Me.pb_Signal.Image = Global.Nama_PM.My.Resources.Resources.WeakSignal
            Me.Signal.SetToolTip(Me.pb_Signal, "سیگنال ضعیف")
        ElseIf Setting.Signal < 20 Then
            Me.pb_Signal.Image = Global.Nama_PM.My.Resources.Resources.GoodSignal
            Me.Signal.SetToolTip(Me.pb_Signal, "سیگنال خوب")
        ElseIf Setting.Signal < 99 Then
            Me.pb_Signal.Image = Global.Nama_PM.My.Resources.Resources.FullSignal
            Me.Signal.SetToolTip(Me.pb_Signal, "سیگنال عالی")
        Else
            Me.pb_Signal.Image = Global.Nama_PM.My.Resources.Resources.NoSignal
            Me.Signal.SetToolTip(Me.pb_Signal, "بدون سیگنال")
        End If
    End Sub
    Private Sub Expando3_StateChanged(ByVal sender As System.Object, ByVal e As XPExplorerBar.ExpandoEventArgs) Handles Exp_FomeKar.StateChanged, Exp_FormeNaghs.StateChanged, Exp_Hadese.StateChanged, Exp_Amozesh.StateChanged, exp_LabROl_Action.StateChanged, Exp_Anbar_Action.StateChanged
        If e.Collapsed = False Then
            TaskPane_Action.CollapseAll()
            e.Expando.Expand()
        End If
    End Sub

    Private Sub Expando1_StateChanged(ByVal sender As System.Object, ByVal e As XPExplorerBar.ExpandoEventArgs) Handles exp_rp_Anbar.StateChanged, exp_rp_EibForm.StateChanged, exp_rp_WorkForm.StateChanged, exp_rp_Hadese.StateChanged, exp_rp_Lab_Rol.StateChanged, exp_rp_Amo.StateChanged, exp_rp_Device.StateChanged
        If e.Collapsed = False Then
            TaskPane_Report.CollapseAll()
            e.Expando.Expand()
        End If
    End Sub

    Private Sub Expando2_StateChanged(ByVal sender As System.Object, ByVal e As XPExplorerBar.ExpandoEventArgs) Handles Expando2.StateChanged, Expando7.StateChanged, Expando8.StateChanged, Expando9.StateChanged, Expando10.StateChanged, Exp_LabRol.StateChanged, Exp_Anbar_BaseInfo.StateChanged, Exp_Contract_BaseInfo.StateChanged
        If e.Collapsed = False Then
            TaskPane_BaeInfo.CollapseAll()
            e.Expando.Expand()
        End If
    End Sub

    Private Sub btn_Minimiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Minimiz.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        End
    End Sub

    Sub InitPanels()
        UnvisiblePAnels()

        Panel_Action.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)
        Panel_Setting.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)
        Panel_Report.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)
        Panel_BaseInfo.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)


        Panel_Action.Size = New Size(772, 482)
        Panel_Setting.Size = New Size(772, 482)
        Panel_Report.Size = New Size(772, 482)
        Panel_BaseInfo.Size = New Size(772, 482)

        Select Case FormBtnState
            Case BtnState.BaseInfo
                Panel_BaseInfo.Visible = True
            Case BtnState.Setting
                Panel_Setting.Visible = True
            Case BtnState.Action
                Panel_Action.Visible = True
            Case BtnState.Report
                Panel_Report.Visible = True
        End Select

        If Panel_BaseInfo.Visible = True Or Panel_Setting.Visible = True Or Panel_Action.Visible = True Or Panel_Report.Visible = True Then
            pic_Azaraksh.Location = New System.Drawing.Point(10, 30)
            pic_Azaraksh.Size = New Size(130, 100)
        End If
    End Sub

    Sub De3DAll()
        btn_BaseInfo.BorderStyle = BorderStyle.None
        btn_Action.BorderStyle = BorderStyle.None
        btn_Report.BorderStyle = BorderStyle.None
        Btn_Setting.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btn_BaseInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BaseInfo.Click
        FormBtnState = BtnState.BaseInfo
        InitPanels()
        De3DAll()
        btn_BaseInfo.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub btn_Action_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Action.Click
        FormBtnState = BtnState.Action
        InitPanels()
        De3DAll()
        btn_Action.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub btn_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Report.Click
        FormBtnState = BtnState.Report
        InitPanels()
        De3DAll()
        btn_Report.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub Btn_Setting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Setting.Click
        FormBtnState = BtnState.Setting
        InitPanels()
        De3DAll()
        Btn_Setting.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub btn_Ashkhas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ashkhas.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_Ashkhas_obj, Nothing)
    End Sub

    Private Sub btn_Vahed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Vahed.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_Vahed_obj, Nothing)
    End Sub

    Private Sub btn_Group_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Group.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_Group_obj, Nothing)
    End Sub

    Private Sub btn_GroupMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GroupMember.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_GroupMember_obj, Nothing)
    End Sub

    Private Sub btn_TipePost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TipePost.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_PostTip_obj, Nothing)
    End Sub

    Private Sub btn_Post_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Post.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_Post_obj, Nothing)
    End Sub

    Private Sub btn_Eib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eib.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_DeviceEib_obj, Nothing)
    End Sub

    Private Sub btn_FixEibDis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FixEibDis.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_FixEibDis_obj, Nothing)
    End Sub

    Private Sub Btn_PostModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PostModel.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_PostModel_obj, Nothing)
    End Sub

    Private Sub Btn_Distance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Distance.Click
        'VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_Distance_obj, Nothing)
        Dim s As New Frm_Distance()
        s.ShowDialog()
    End Sub

    Private Sub Btn_WorkDis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_WorkDis.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_WorkDis_obj, Nothing)
    End Sub

    Private Sub Btn_WorkForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_WorkForm.Click
        Dim s As New Frm_WorkForm(-1)
        s.ShowDialog()
    End Sub

    Private Sub Btn_WorkForm_Formula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_WorkForm_Formula.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_WorkForm_Formula_Normal_obj, New Object() {False})
    End Sub

    Private Sub btn_WorkForm_furmulaShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_WorkForm_furmulaShow.Click
        Dim s As New Frm_WorkForm_FormulaShow(False, 1)
        s.ShowDialog()
    End Sub

    Private Sub btn_EibForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EibForm.Click
        Dim s As New Frm_EibForm(-1)
        s.ShowDialog()
    End Sub

    Private Sub btn_EibFormVw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EibFormVw.Click
        Dim f As New Frm_EibFormVw
        f.ShowDialog()
    End Sub

    Private Sub btn_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_User.Click
        Security.Users(Me)
    End Sub

    Private Sub btn_GroupUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GroupUser.Click
        Security.Groups(Me)
    End Sub

    Private Sub btn_LimitTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimitTitle.Click
        Security.Roles(Me)
    End Sub

    Private Sub btn_GroupLimit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GroupLimit.Click
        Security.RoleGroups(Me)
    End Sub

    Private Sub btn_FormLimits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FormLimits.Click
        Security.Permission(Me, System.Reflection.Assembly.GetExecutingAssembly)
    End Sub

    Private Sub btn_FactorView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton1.Click
        Dim s As New Frm_FactorView
        s.ShowDialog()
    End Sub

    Private Sub VistaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NewAnbar.Click
        Dim s As New Frm_AnbarVw()
        s.ShowDialog()
    End Sub

    Private Sub btn_NewKala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NewKala.Click
        Dim s As New Frm_Kala
        s.ShowDialog()
    End Sub

    Private Sub btn_KalaGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KalaGroup.Click
        Dim s As New Frm_KalaGroup
        s.ShowDialog()
    End Sub

    Private Sub VistaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton2.Click
        Dim s As New Frm_RpEibForm()
        s.ShowDialog()
    End Sub

    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        If MessageBoxFa.Show("مايل به خروج از نرم افزار هستيد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Sub UnvisiblePAnels()
        Panel_Action.Visible = False
        Panel_Setting.Visible = False
        Panel_Report.Visible = False
        Panel_BaseInfo.Visible = False

    End Sub

    Private Sub pic_Azaraksh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Azaraksh.Click
        UnvisiblePAnels()
        pic_Azaraksh.Location = New System.Drawing.Point(Panel1.Location.X, Panel1.Location.Y - 520)
        pic_Azaraksh.Size = New Size(850, 520)
    End Sub

    Private Sub VAC_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VAC.MouseDown
        FirstX = e.Location.X
        FirstY = e.Location.Y
        DoDrag = True
    End Sub

    Private Sub VAC_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VAC.MouseUp
        DoDrag = False
    End Sub

    Private Sub VAC_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VAC.MouseMove
        If DoDrag Then
            VAC.Location = New Point(VAC.Location.X + e.Location.X - FirstX, VAC.Location.Y + e.Location.Y - FirstY)
        End If
    End Sub

    Private Sub btn_ReadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ReadFile.Click
        Dim s As New Frm_Hzg_OpenFile()
        s.ShowDialog()
    End Sub

    Private Sub btn_TimeCardEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TimeCardEdit.Click
        Dim s As New Frm_EditTimeCard()
        s.ShowDialog()
    End Sub

    Private Sub btn_CodeHazine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CodeHazine.Click
        Dim s As New Frm_CodeHazine()
        s.ShowDialog()
    End Sub

    Private Sub btn_Rp_ExtraWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_ExtraWork.Click
        Dim s As New Frm_RpExtraWork
        s.ShowDialog()
    End Sub

    Private Sub btn_Taghvim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Taghvim.Click
        Dim s As New Frm_Taghvim
        s.ShowDialog()
    End Sub

    Private Sub btn_AddAshkhas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddAshkhas.Click
        Dim s As New Frm_UserAshkhas()
        s.ShowDialog()
    End Sub

    Private Sub btn_WorkFormVw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_WorkFormVw.Click
        Dim s As New Frm_WorkFormVw
        s.ShowDialog()
    End Sub

    Private Sub btn_SharhKar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SharhKar.Click
        Dim s As New Frm_WorkForm_Sharh
        s.ShowDialog()
    End Sub

    Private Sub btn_PostToGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PostToGroup.Click
        Dim s As New Frm_PostToGroup
        s.ShowDialog()
    End Sub

    Private Sub btn_Formul_taradod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Formul_taradod.Click
        VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, Setting.Frm_WorkForm_Formula_Taradod_obj, New Object() {True})
    End Sub

    Private Sub btn_Sazande_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sazande.Click
        Dim s As New Frm_Sazande
        s.ShowDialog()
    End Sub

    Private Sub btn_Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Settings.Click
        Dim s As New Frm_setting
        s.ShowDialog()
        ScrollingText1.ScrollText = Setting.ModirMesage.PropValue
    End Sub

    Private Sub btn_Rp_SummaryExtraWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_SummaryExtraWork.Click
        Dim s As New Frm_SummaryRpStatusStatementExtraWork
        s.ShowDialog()
    End Sub

    Private Sub btn_Sherkat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sherkat.Click
        Dim s As New Frm_Sherkatha
        s.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim s As New Frm_About
        s.ShowDialog()
    End Sub

    Private Sub btn_KalaUse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KalaUse.Click
        Dim s As New Frm_RpKalaUse
        s.ShowDialog()
    End Sub

    Private Sub btn_FormulTaradod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FormulTaradod.Click
        Dim s As New Frm_WorkForm_FormulaShow(True, 1)
        s.ShowDialog()
    End Sub

    Private Sub btn_MojodiAnbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MojodiAnbar.Click
        Dim s As New Frm_RpMojodiAnbar
        s.ShowDialog()
    End Sub

    Private Sub btn_Rp_FromeKar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_FromeKar.Click
        Dim s As New Frm_RpWorkForm
        s.ShowDialog()
    End Sub

    Private Sub btn_RpGroupEibForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RpGroupEibForm.Click
        Dim s As New Frm_RpGeoupEibForm()
        s.ShowDialog()
    End Sub

    Private Sub btn_Rp_NafarSaatProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_NafarSaatProject.Click
        Dim s As New Frm_RpNafarSatProject
        s.ShowDialog()
    End Sub

    Private Sub btn_Rp_NafarsaGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_NafarsaGroup.Click
        Dim s As New Frm_RpNafarSatGroup
        s.ShowDialog()
    End Sub

    Private Sub btn_RpCompareGroupEibform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RpCompareGroupEibform.Click
        Dim s As New Frm_RpCompareGroupEibForm
        s.ShowDialog()
    End Sub

    Private Sub btn_ConvertDB_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ConvertDB.Click
        Dim s As New ConvertDB
        s.ShowDialog()
    End Sub

    Private Sub VistaButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btn_rp_saghfekar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rp_saghfekar.Click
        Dim s As New Frm_Rp_SaghfeKar
        s.ShowDialog()
    End Sub

    Private Sub btn_Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Backup.Click
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        Dim bl As New VB_Component.BackgroundLoading(AddressOf DoBackUp, "سیستم در حال پشتیبان گیری از پایگاه داده ")
        bl.Start()
        Me.BringToFront()
    End Sub

    Private Sub DoBackUp()
        Dim path As String = FolderBrowserDialog1.SelectedPath
        If path.Trim() = "" Then
            Return
        End If
        path = path + "\\" + Setting.TarikheJary.Replace("/", "") + "_Nama_PM.bak"
        DataBase.BackUp(Setting.ConnectionString, "Nama_MIS", path)
    End Sub

    Private Sub btn_HadeseSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HadeseSubmit.Click
        Dim s As New Frm_Hadese(-2)
        s.ShowDialog()
    End Sub

    Private Sub btn_Hadese_AmalkardSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hadese_AmalkardSystem.Click
        Dim s As New Frm_Hadese_Amalkard
        s.ShowDialog()
    End Sub

    Private Sub btn_Hadese_SharyaetBoroz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hadese_SharyaetBoroz.Click
        Dim s As New Frm_Hadese_SharayetBoroz
        s.ShowDialog()
    End Sub

    Private Sub btn_Hadese_ElatBoroz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hadese_ElatBoroz.Click
        Dim s As New Frm_Hadese_ElateBoroz
        s.ShowDialog()
    End Sub

    Private Sub btn_Hadese_NoeKhesarat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New Frm_Hadese_KhesaratType
        s.ShowDialog()
    End Sub

    Private Sub btn_Hadese_Device_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hadese_Device.Click
        Dim s As New Frm_Device
        s.ShowDialog()
    End Sub

    Private Sub btn_HadeseVw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HadeseVw.Click
        Dim s As New Frm_HadeseVw
        s.ShowDialog()
    End Sub

    Private Sub btn_Rp_Hadese_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_Hadese.Click
        Dim s As New Frm_Rp_HadeseVw
        s.ShowDialog()
    End Sub

    Private Sub btn_lab_Ghatat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New Frm_Lal_Rol_GhatateMasrafi
        s.ShowDialog()
    End Sub

    Private Sub btn_Lab_ElateVorod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New Frm_Lab_Rol_ElateVorod
        s.ShowDialog()
    End Sub

    Private Sub btn_Lab_SatheAhamit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New Frm_Lab_Rol_SatheAhamniat
        s.ShowDialog()
    End Sub

    'Private Sub btn_lab_VorodDastgah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lab_VorodDastgah.Click
    '    Dim s As New Frm_Lab_Rol_Tamir(-2)
    '    s.ShowDialog()
    'End Sub

    Private Sub btn_Device_Sazandegan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Device_Sazandegan.Click, VistaButton3.Click
        Dim s As New Frm_Device_Sazande
        s.ShowDialog()
    End Sub

    Private Sub btn_Lab_ViewTamirat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Lab_ViewTamirat.Click
        Dim s As New Frm_Lab_Rol_Master(-2)
        s.ShowDialog()
    End Sub

    Private Sub btn_Lab_Rp_TamirAlarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New Frm_Rp_Lab_TamirAlarm
        s.ShowDialog()
    End Sub

    Private Sub btn_Lab_Rp_Tamirat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New Frm_Rp_Lab_Tamir
        s.ShowDialog()
    End Sub

    Private Sub btn_DoreType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DoreType.Click
        Dim s As New Frm_Edu_DoreType
        s.ShowDialog()
    End Sub

    Private Sub btn_DoreName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DoreName.Click
        Dim s As New Frm_Edu_Dore
        s.ShowDialog()
    End Sub

    Private Sub btn_MakanBArgozare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MakanBArgozare.Click
        Dim s As New Frm_Edu_DorePlace()
        s.ShowDialog()
    End Sub

    Private Sub btn_MoasessatAMozeshi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MoasessatAMozeshi.Click
        Dim s As New Frm_Edu_DorePresenter
        s.ShowDialog()
    End Sub

    Private Sub btn_DoreSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DoreSubmit.Click
        Dim s As New Frm_Edu_DoreHolding
        s.ShowDialog()
    End Sub

    Private Sub btn_AmozeshView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AmozeshView.Click
        Dim s As New Frm_Rp_Amo_View
        s.ShowDialog()
    End Sub

    Private Sub btn_WrokForm_Furmul_Profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_WrokForm_Furmul_Profile.Click
        Dim s As New Frm_WorkForm_Formul_Profile
        s.ShowDialog()
    End Sub

    'Private Sub btn_PostTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PostTemplate.Click
    '    Dim s As New Frm_Template
    '    s.ShowDialog()
    'End Sub

    Private Sub btn_dexcriptableTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RecomendationSubject.Click
        Dim s As New Frm_RecomendationSubject
        s.ShowDialog()
    End Sub

    Private Sub btn_SubRecom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SubRecom.Click
        Dim s As New Frm_SubRecomendationSubject
        s.ShowDialog()
    End Sub

    Private Sub btn_CancelCause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelCause.Click
        Dim s As New Frm_CancelCause()
        s.ShowDialog()
    End Sub

    Private Sub btn_DeviceNAme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeviceNAme.Click
        Dim s As New Frm_DeviceName
        s.ShowDialog()
    End Sub

    Private Sub btn_DeviceReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeviceReport.Click
        Dim s As New Frm_RpDevice()
        s.ShowDialog()
    End Sub

    Private Sub btn_ANSICode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ANSICode.Click
        Dim s As New Frm_ANSI()
        s.ShowDialog()
    End Sub

    Private Sub btn_Important_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Important.Click
        Dim s As New Frm_ImportantPercent()
        s.ShowDialog()
    End Sub

    Private Sub btn_Pm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pm.Click
        Dim s As New Frm_PmTimeTableIMG
        s.ShowDialog()
    End Sub

    Private Sub btn_InsertPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_InsertPM.Click
        Dim s As New Frm_PmWithDevice()
        s.ShowDialog()
    End Sub

    Private Sub btn_Recomendation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recomendation.Click
        Dim s As New Frm_PishnahadView
        s.ShowDialog()
    End Sub

    Private Sub btn_Rp_Recom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_Recom.Click
        Dim s As New Frm_RpRecomendation()
        s.ShowDialog()
    End Sub

    Private Sub btn_Rp_postpm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_postpm.Click
        Dim s As New Frm_RpPostPm()
        s.ShowDialog()
    End Sub

    Private Sub btn_PmCancleCause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PmCancleCause.Click
        Dim s As New Frm_RpPmCancle
        s.ShowDialog()
    End Sub

    Private Sub pb_Signal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_Signal.Click
        PublicFunction.CheckGSMModem()
        UpdateSignal()
    End Sub

    Private Sub btn_Sms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sms.Click
        Dim s As New Frm_SmsVw()
        s.ShowDialog()
    End Sub

    Private Sub btn_SharhKar_WorkForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SharhKar_WorkForm.Click
        Dim s As New Pm_WorkSharh_WorkForm()
        s.ShowDialog()
    End Sub

    Private Sub VistaButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton5.Click
        Dim f As New Frm_RpPmMonth()
        f.ShowDialog()
    End Sub

    Private Sub Btn_PostType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PostType.Click
        Dim f As New Frm_Posttype()
        f.ShowDialog()
    End Sub

    Private Sub Btn_Kargozini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Kargozini.Click
        Dim f As New Frm_WorkForm_kargozini
        f.ShowDialog()
    End Sub

    Private Sub btn_UserTmeCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New Frm_EditTimeCardUser
        f.ShowDialog()
    End Sub

    Private Sub btn_AdminTimeCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AdminTimeCard.Click
        Dim f As New Frm_EditTimeCardAdmin
        f.ShowDialog()
    End Sub

   
    Private Sub VistaButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton4.Click
        Dim f As New Frm_Lab_Rol_MasooleTamir
        f.ShowDialog()
    End Sub



    Private Sub VistaButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton7.Click
        Dim f As New Frm_Pm_Lab_Rol_Tajhizat
        f.ShowDialog()
    End Sub

    Private Sub VistaButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton6.Click
        Dim f As New Frm_Lab_Rol_Mahal
        f.ShowDialog()
    End Sub

    Private Sub VistaButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton8.Click
        Dim f As New Frm_Lab_Rol_Master_Vw
        f.ShowDialog()
    End Sub

    Private Sub VistaButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton9.Click
        Dim f As New Frm_Rp_Tamirat
        f.ShowDialog()
    End Sub


    Private Sub VistaButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton10.Click
        Dim s As New Frm_Rp_Lab_TamirAlarm
        s.ShowDialog()
    End Sub

    Private Sub VistaButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton11.Click
        Dim s As New Frm_Rp_Lab_Tamir
        s.ShowDialog()
    End Sub

    Private Sub VistaButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton13.Click
        Dim s As New Frm_Pm_Company
        s.ShowDialog()
    End Sub

    Private Sub btn_DarkhasteKar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DarkhasteKar.Click
        Dim s As New Frm_DarkhasteKar(-2)
        s.ShowDialog()

    End Sub

    Private Sub btn_DarkhasteKarVw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DarkhasteKarVw.Click
        Dim s As New Frm_DarkhasteKarVw
        s.ShowDialog()
    End Sub

    Private Sub VistaButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Voltage.Click
        Dim s As New Frm_SatheVoltage
        s.ShowDialog()
    End Sub

    Private Sub btn_Con_Unit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Con_Unit.Click
        Dim s As New Frm_Con_Unit
        s.ShowDialog()
    End Sub

    Private Sub VistaButton14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton14.Click
        Dim s As New Frm_Con_Item
        s.ShowDialog()
    End Sub

    Private Sub btn_Contract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Contract.Click
        Dim s As New Frm_Con_Contract
        s.ShowDialog()
    End Sub

    Private Sub VistaButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton15.Click
        Dim s As New Frm_Status
        s.ShowDialog()

    End Sub

    Private Sub btn_Jobtitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Jobtitle.Click
        Dim s As New Frm_JobTitle
        s.ShowDialog()
    End Sub

    Private Sub btn_Teacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Teacher.Click
        Dim s As New Frm_Edu_Teacher
        s.ShowDialog()
    End Sub

    Private Sub btn_EvaluationItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EvaluationItem.Click
        Dim s As New Frm_Edu_EvaluationItem
        s.ShowDialog()
    End Sub

    Private Sub btn_Statusstatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Statusstatement.Click
        Dim s As New Frm_Con_StatusStatement(-1, -1)
        s.ShowDialog()
    End Sub

    Private Sub VistaButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_con_StatusStatement.Click
        Dim s As New Frm_Rp_StatusStatement()
        s.ShowDialog()
    End Sub


    Private Sub btn_Rp_Dore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_Dore.Click
        Dim s As New Frm_Rp_DoreVw()
        s.ShowDialog()
    End Sub

    Private Sub VistaButton16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton16.Click
        Dim s As New Frm_Rp_ٍEvaluationVw()
        s.ShowDialog()
    End Sub

    Private Sub btn_Line_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Line.Click
        Dim s As New Frm_Line()
        s.ShowDialog()
    End Sub

    Private Sub btn_StatusStatementVw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_StatusStatementVw.Click
        Dim s As New Frm_Con_StatusStatementVw()
        s.ShowDialog()
    End Sub

    Private Sub btn_AllStatusStatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New Frm_Con_AllStatusStatementVw()
        s.ShowDialog()
    End Sub

    Private Sub btn_Con_Item_convert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Con_Item_convert.Click
        Dim s As New Frm_Con_Convert(-1)
        s.ShowDialog()
    End Sub

    Private Sub btn_Source_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Source.Click
        Dim s As New Frm_Con_Source()
        s.ShowDialog()
    End Sub

    Private Sub btn_StatuStatementMazad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_StatuStatementMazad.Click
        Dim s As New Frm_Con_StatusStatementMazad(-1, -1)
        s.ShowDialog()
    End Sub

    Private Sub btn_StatusStatementMonthReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_StatusStatementMonthReport.Click
        Dim s As New Frm_Con_MonthReportVw()
        s.ShowDialog()
    End Sub

    Private Sub VistaButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton17.Click
        Dim s As New Frm_Con_MonthReport(-1)
        s.ShowDialog()
    End Sub

    Private Sub Btn_ContarctZarib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ContarctZarib.Click
        Dim s As New Frm_Con_Zarib()
        s.ShowDialog()
    End Sub

    Private Sub btn_ContractItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ContractItem.Click
        Dim s As New Frm_Con_ContractItem()
        s.ShowDialog()
    End Sub

    Private Sub btn_GroupWeigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GroupWeigh.Click
        Dim s As New Frm_Con_GroupWeight()
        s.ShowDialog()
    End Sub

    Private Sub btn_StatusStatementExtraWirk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_StatusStatementExtraWirk.Click
        Dim s As New Frm_RpStatusStatementExtraWork()
        s.ShowDialog()
    End Sub

    Private Sub btn_NavahiWeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NavahiWeight.Click
        Dim s As New Frm_Con_NavahiWeight()
        s.ShowDialog()
    End Sub

    Private Sub btn_vahedWeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vahedWeight.Click
        Dim s As New Frm_Con_VahedWeight()
        s.ShowDialog()
    End Sub

    Private Sub btn_SummarySS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SummarySS.Click
        Dim s As New Frm_Rp_MonthReport()
        s.ShowDialog()
    End Sub

    Private Sub btn_Rp_Summaryextrawor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rp_Summaryextrawor.Click
        Dim s As New Frm_SummaryRpExtraWork()
        s.ShowDialog()
    End Sub

    Private Sub rb_MonthReport_Detail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_MonthReport_Detail.Click
        Dim s As New Frm_Rp_MonthReportDetail()
        s.ShowDialog()
    End Sub

    Private Sub btn_SaveEzafekar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SaveEzafekar.Click
        Dim s As New Frm_Con_VahedSavedEzafeKar()
        s.ShowDialog()
    End Sub

    Private Sub btn_Hadese_ElatBoroz_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New Frm_Hadese_ElateBoroz()
        s.ShowDialog()
    End Sub

    Private Sub btn_Hadese_NoeKhesarat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hadese_NoeKhesarat.Click
        Dim s As New Frm_Hadese_KhesaratType()
        s.ShowDialog()
    End Sub

    Private Sub btn_MaghareType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MaghareType.Click
        Dim s As New Frm_Line_Magharetype()
        s.ShowDialog()
    End Sub

    Private Sub btn_pm_Dakaltype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pm_Dakaltype.Click
        Dim s As New Frm_Line_Dakaltype()
        s.ShowDialog()
    End Sub

    Private Sub btn_pm_DakalModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pm_DakalModel.Click
        Dim s As New Frm_Line_DakalStructure()
        s.ShowDialog()
    End Sub

    Private Sub btn_pm_GeoPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pm_GeoPosition.Click
        Dim s As New Frm_Line_GeoPosition()
        s.ShowDialog()

    End Sub

    Private Sub btn_pm_Voltage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pm_Voltage.Click
        Dim s As New Frm_Line_Voltage()
        s.ShowDialog()
    End Sub

    Private Sub btn_Magharechanin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Magharechanin.Click
        Dim s As New Frm_Line_MaghareChain()
        s.ShowDialog()
    End Sub

    Private Sub btn_Gardtype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Gardtype.Click
        Dim s As New Frm_Line_Gardtype()
        s.ShowDialog()
    End Sub

    Private Sub btn_haditype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_haditype.Click
        Dim s As New Frm_Line_HadiType()
        s.ShowDialog()
    End Sub

    Private Sub btn_dakalProvider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dakalProvider.Click
        Dim s As New Frm_Line_DakalProvider()
        s.ShowDialog()
    End Sub

    Private Sub btn_maghareProvider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_maghareProvider.Click
        Dim s As New Frm_Line_MaghareProvider()
        s.ShowDialog()
    End Sub

    
    Private Sub btn_pm_CableType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pm_CableType.Click
        Dim s As New Frm_Line_CableType()
        s.ShowDialog()
    End Sub

    Private Sub btn_dakalcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dakalcode.Click
        Dim s As New Frm_Line_DakalCode()
        s.ShowDialog()
    End Sub

    Private Sub VistaButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton18.Click
        Dim s As New Frm_Line_DakalModel()
        s.ShowDialog()
    End Sub

    Private Sub rb_Non_MonthReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Non_MonthReport.Click
        Dim s As New Frm_Con_Non_MonthReportVw()
        s.ShowDialog()
    End Sub

    Private Sub vb_KhatImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vb_KhatImport.Click
        Dim s As New Frm_Khat_Import()
        s.ShowDialog()
    End Sub

    Private Sub VistaButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton19.Click
        Dim s As New Frm_Pishnahad(-2)
        s.ShowDialog()
    End Sub

    Private Sub btn_Sender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sender.Click
        Dim s As New Frm_Sender
        s.ShowDialog()
    End Sub

    Private Sub VistaButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaButton21.Click
        Dim s As New Frm_RpPishnahad
        s.ShowDialog()
    End Sub
End Class
