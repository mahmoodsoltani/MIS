<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpDevice
    Inherits BaseForm_Info_Single

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Tab_Tajhiz = New System.Windows.Forms.TabControl
        Me.All = New System.Windows.Forms.TabPage
        Me.cmb_TajhizName = New VB_Component.ComboBox
        Me.PmTajhizNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.chk_allOrderCode = New System.Windows.Forms.CheckBox
        Me.chk_AllName = New System.Windows.Forms.CheckBox
        Me.txt_OrderCode = New CS_Component.TextBox
        Me.chk_SubDevice = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Tab_Rele = New System.Windows.Forms.TabPage
        Me.chk_AllRVT = New System.Windows.Forms.CheckBox
        Me.chk_AllRCT = New System.Windows.Forms.CheckBox
        Me.chk_AllROrder = New System.Windows.Forms.CheckBox
        Me.Chk_AllRNme = New System.Windows.Forms.CheckBox
        Me.txt_ReleVT = New CS_Component.TextBox
        Me.txt_ReleCT = New CS_Component.TextBox
        Me.txt_ReleOrderCode = New CS_Component.TextBox
        Me.txt_ReleName = New CS_Component.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Tab_TG = New System.Windows.Forms.TabPage
        Me.txt_TGtapConvert = New CS_Component.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.chk_AllTGTapChange = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_TGBill = New CS_Component.TextBox
        Me.txt_TGFrequncy = New CS_Component.TextBox
        Me.txt_TGTapPlace = New CS_Component.TextBox
        Me.txt_TGJaryan = New CS_Component.TextBox
        Me.txt_TGVolume = New CS_Component.TextBox
        Me.txt_TGampedance = New CS_Component.TextBox
        Me.txt_TGVotaj = New CS_Component.TextBox
        Me.txt_TGColling = New CS_Component.TextBox
        Me.txt_TGName = New CS_Component.TextBox
        Me.txt_TGVectore = New CS_Component.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.chk_AllTGTapPlace = New System.Windows.Forms.CheckBox
        Me.chk_AllTGFerequenc = New System.Windows.Forms.CheckBox
        Me.chk_AllTGJaryanConvert = New System.Windows.Forms.CheckBox
        Me.chk_AllTGAmpedanse = New System.Windows.Forms.CheckBox
        Me.chk_AllTGBill = New System.Windows.Forms.CheckBox
        Me.chk_AllTGValume = New System.Windows.Forms.CheckBox
        Me.chk_AllTGVotajConvert = New System.Windows.Forms.CheckBox
        Me.chk_AllTGCooler = New System.Windows.Forms.CheckBox
        Me.chk_AllTgName = New System.Windows.Forms.CheckBox
        Me.chk_AllTGVectorGroup = New System.Windows.Forms.CheckBox
        Me.Tab_Barghgir = New System.Windows.Forms.TabPage
        Me.chk_AllBGName = New System.Windows.Forms.CheckBox
        Me.chk_AllBGVoltaj = New System.Windows.Forms.CheckBox
        Me.chk_AllBGClass = New System.Windows.Forms.CheckBox
        Me.chk_AllBGSC = New System.Windows.Forms.CheckBox
        Me.chk_AllBGJaryan = New System.Windows.Forms.CheckBox
        Me.chk_AllBGTavan = New System.Windows.Forms.CheckBox
        Me.txt_BGClass = New CS_Component.TextBox
        Me.txt_BGJaryan = New CS_Component.TextBox
        Me.txt_BGName = New CS_Component.TextBox
        Me.txt_BGJaryanSC = New CS_Component.TextBox
        Me.txt_BGVoltaj = New CS_Component.TextBox
        Me.txt_BGTavan = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Tab_Sexioner = New System.Windows.Forms.TabPage
        Me.chk_AllSexVoltaj = New System.Windows.Forms.CheckBox
        Me.chk_AllSexSC = New System.Windows.Forms.CheckBox
        Me.chk_AllsexUtiVoltaj = New System.Windows.Forms.CheckBox
        Me.chk_AllSexMaxJaryan = New System.Windows.Forms.CheckBox
        Me.chk_AllSexName = New System.Windows.Forms.CheckBox
        Me.chk_AllSexJaryan = New System.Windows.Forms.CheckBox
        Me.txt_sexUtilizationVoltaje = New CS_Component.TextBox
        Me.txt_SexName = New CS_Component.TextBox
        Me.txt_SexJaryan = New CS_Component.TextBox
        Me.txt_SexJaryanSC = New CS_Component.TextBox
        Me.txt_SexVoltage = New CS_Component.TextBox
        Me.txt_SexMaxJaryan = New CS_Component.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Tab_Breaker = New System.Windows.Forms.TabPage
        Me.chk_AllBRMaxJaryan = New System.Windows.Forms.CheckBox
        Me.chk_ALLBRName = New System.Windows.Forms.CheckBox
        Me.chk_AllBRTurnoff = New System.Windows.Forms.CheckBox
        Me.chk_AllBRBill = New System.Windows.Forms.CheckBox
        Me.chk_AllBRMekanizm = New System.Windows.Forms.CheckBox
        Me.chk_AllBRConnect = New System.Windows.Forms.CheckBox
        Me.chk_AllBRJaryanN = New System.Windows.Forms.CheckBox
        Me.chk_AllBRDisconnect = New System.Windows.Forms.CheckBox
        Me.chk_AllBRVoltajN = New System.Windows.Forms.CheckBox
        Me.chk_AllBRMaxVoltaj = New System.Windows.Forms.CheckBox
        Me.chk_AllBRSC = New System.Windows.Forms.CheckBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txt_BRDisconnect = New CS_Component.TextBox
        Me.txt_BRMaxJaryan = New CS_Component.TextBox
        Me.txt_BrConnect = New CS_Component.TextBox
        Me.txt_BRMaxVoltaje = New CS_Component.TextBox
        Me.txt_BrBill = New CS_Component.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.txt_BRJaryanN = New CS_Component.TextBox
        Me.txt_BRMekanism = New CS_Component.TextBox
        Me.txt_BRVotajN = New CS_Component.TextBox
        Me.txt_BrName = New CS_Component.TextBox
        Me.txt_BRTurnOff = New CS_Component.TextBox
        Me.txt_BRJaryanSC = New CS_Component.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Tab_TV = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Rb_TV = New System.Windows.Forms.RadioButton
        Me.Rb_Both = New System.Windows.Forms.RadioButton
        Me.RB_TJ = New System.Windows.Forms.RadioButton
        Me.chk_AllTVJMaxVoltaj = New System.Windows.Forms.CheckBox
        Me.chk_ALLTrCoreNumber = New System.Windows.Forms.CheckBox
        Me.chk_AllTVJBill = New System.Windows.Forms.CheckBox
        Me.chk_AllTVJClass = New System.Windows.Forms.CheckBox
        Me.chk_AllTrName = New System.Windows.Forms.CheckBox
        Me.chk_AllTVJCoreConvert = New System.Windows.Forms.CheckBox
        Me.chk_AllTVJMaxJaryan = New System.Windows.Forms.CheckBox
        Me.txt_TVJCoreClass = New CS_Component.TextBox
        Me.txt_TVJMaxJaryan = New CS_Component.TextBox
        Me.txt_TrCoreNumber = New CS_Component.TextBox
        Me.txt_TVJbill = New CS_Component.TextBox
        Me.txt_TrName = New CS_Component.TextBox
        Me.txt_TVJCoreConvert = New CS_Component.TextBox
        Me.txt_TVJMaxVoltage = New CS_Component.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Tab_Cable = New System.Windows.Forms.TabPage
        Me.chk_AllCSatheVoltaj = New System.Windows.Forms.CheckBox
        Me.chk_AllCMaghta = New System.Windows.Forms.CheckBox
        Me.chk_AllCAbleNAme = New System.Windows.Forms.CheckBox
        Me.chk_AllCJaryan = New System.Windows.Forms.CheckBox
        Me.txt_CVoltaj = New CS_Component.TextBox
        Me.txt_CableName = New CS_Component.TextBox
        Me.txt_CValidJaryan = New CS_Component.TextBox
        Me.txt_CMaghta = New CS_Component.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.cmb_Sazande = New VB_Component.ComboBox
        Me.PmDeviceSazandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.Label16 = New System.Windows.Forms.Label
        Me.chk_allSazande = New System.Windows.Forms.CheckBox
        Me.chk_AllDispatch = New System.Windows.Forms.CheckBox
        Me.chk_AllSerial = New System.Windows.Forms.CheckBox
        Me.chk_AllUtilizationDate = New System.Windows.Forms.CheckBox
        Me.chk_AllMadeDate = New System.Windows.Forms.CheckBox
        Me.txt_Serial = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_RozeHafte = New System.Windows.Forms.Label
        Me.txt_EndUti = New CS_Component.TextBox
        Me.txt_EndMade = New CS_Component.TextBox
        Me.txt_StartUti = New CS_Component.TextBox
        Me.txt_StartMade = New CS_Component.TextBox
        Me.Pm_TajhizNameTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_TajhizNameTableAdapter
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_DispatchCode = New CS_Component.TextBox
        Me.Pm_Device_SazandeTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Device_SazandeTableAdapter
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.cmb_Post = New VB_Component.ComboBox
        Me.chk_AllPost = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.chk_AllModel = New System.Windows.Forms.CheckBox
        Me.txt_Model = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.RpReleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_ReleTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_ReleTableAdapter
        Me.RpTranseGhodratBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_TranseGhodratTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_TranseGhodratTableAdapter
        Me.RpBarghgirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_BarghgirTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_BarghgirTableAdapter
        Me.RpSexionerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_SexionerTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_SexionerTableAdapter
        Me.RpBreakerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_BreakerTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_BreakerTableAdapter
        Me.RpTeranseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_TeranseTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_TeranseTableAdapter
        Me.RpTajhizBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_TajhizTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_TajhizTableAdapter
        Me.RpCableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_CableTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_CableTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.Tab_Tajhiz.SuspendLayout()
        Me.All.SuspendLayout()
        CType(Me.PmTajhizNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Rele.SuspendLayout()
        Me.Tab_TG.SuspendLayout()
        Me.Tab_Barghgir.SuspendLayout()
        Me.Tab_Sexioner.SuspendLayout()
        Me.Tab_Breaker.SuspendLayout()
        Me.Tab_TV.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Tab_Cable.SuspendLayout()
        CType(Me.PmDeviceSazandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpReleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpTranseGhodratBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpBarghgirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpSexionerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpBreakerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpTeranseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpTajhizBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpCableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 456)
        Me.gbx_Buttons.Size = New System.Drawing.Size(762, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(658, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.cmb_Sazande)
        Me.gbx_Fields.Controls.Add(Me.chk_AllModel)
        Me.gbx_Fields.Controls.Add(Me.Label16)
        Me.gbx_Fields.Controls.Add(Me.txt_Model)
        Me.gbx_Fields.Controls.Add(Me.chk_allSazande)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.cmb_Post)
        Me.gbx_Fields.Controls.Add(Me.chk_AllPost)
        Me.gbx_Fields.Controls.Add(Me.chk_AllDispatch)
        Me.gbx_Fields.Controls.Add(Me.chk_AllSerial)
        Me.gbx_Fields.Controls.Add(Me.Label18)
        Me.gbx_Fields.Controls.Add(Me.Tab_Tajhiz)
        Me.gbx_Fields.Controls.Add(Me.chk_AllMadeDate)
        Me.gbx_Fields.Controls.Add(Me.chk_AllUtilizationDate)
        Me.gbx_Fields.Controls.Add(Me.txt_DispatchCode)
        Me.gbx_Fields.Controls.Add(Me.txt_Serial)
        Me.gbx_Fields.Controls.Add(Me.txt_StartMade)
        Me.gbx_Fields.Controls.Add(Me.txt_StartUti)
        Me.gbx_Fields.Controls.Add(Me.txt_EndMade)
        Me.gbx_Fields.Controls.Add(Me.Label5)
        Me.gbx_Fields.Controls.Add(Me.txt_EndUti)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.lbl_RozeHafte)
        Me.gbx_Fields.Controls.Add(Me.Label10)
        Me.gbx_Fields.Controls.Add(Me.Label9)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(763, 416)
        '
        'Tab_Tajhiz
        '
        Me.Tab_Tajhiz.Controls.Add(Me.All)
        Me.Tab_Tajhiz.Controls.Add(Me.Tab_Rele)
        Me.Tab_Tajhiz.Controls.Add(Me.Tab_TG)
        Me.Tab_Tajhiz.Controls.Add(Me.Tab_Barghgir)
        Me.Tab_Tajhiz.Controls.Add(Me.Tab_Sexioner)
        Me.Tab_Tajhiz.Controls.Add(Me.Tab_Breaker)
        Me.Tab_Tajhiz.Controls.Add(Me.Tab_TV)
        Me.Tab_Tajhiz.Controls.Add(Me.Tab_Cable)
        Me.Tab_Tajhiz.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Tab_Tajhiz.Location = New System.Drawing.Point(3, 183)
        Me.Tab_Tajhiz.Name = "Tab_Tajhiz"
        Me.Tab_Tajhiz.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tab_Tajhiz.RightToLeftLayout = True
        Me.Tab_Tajhiz.SelectedIndex = 0
        Me.Tab_Tajhiz.Size = New System.Drawing.Size(757, 230)
        Me.Tab_Tajhiz.TabIndex = 0
        '
        'All
        '
        Me.All.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.All.Controls.Add(Me.cmb_TajhizName)
        Me.All.Controls.Add(Me.chk_allOrderCode)
        Me.All.Controls.Add(Me.chk_AllName)
        Me.All.Controls.Add(Me.txt_OrderCode)
        Me.All.Controls.Add(Me.chk_SubDevice)
        Me.All.Controls.Add(Me.Label12)
        Me.All.Controls.Add(Me.Label6)
        Me.All.Location = New System.Drawing.Point(4, 27)
        Me.All.Name = "All"
        Me.All.Padding = New System.Windows.Forms.Padding(3)
        Me.All.Size = New System.Drawing.Size(749, 199)
        Me.All.TabIndex = 0
        Me.All.Text = "تجهیزات"
        Me.All.UseVisualStyleBackColor = True
        '
        'cmb_TajhizName
        '
        Me.cmb_TajhizName.AllowDrop = True
        Me.cmb_TajhizName.AutoComplete = True
        Me.cmb_TajhizName.DataSource = Me.PmTajhizNameBindingSource
        Me.cmb_TajhizName.DisplayMember = "نام"
        Me.cmb_TajhizName.EnterStop = True
        Me.cmb_TajhizName.FormattingEnabled = True
        Me.cmb_TajhizName.IsRequired = False
        Me.cmb_TajhizName.LimitedToList = False
        Me.cmb_TajhizName.Location = New System.Drawing.Point(303, 21)
        Me.cmb_TajhizName.Name = "cmb_TajhizName"
        Me.cmb_TajhizName.OpenOnFoucus = False
        Me.cmb_TajhizName.Size = New System.Drawing.Size(342, 26)
        Me.cmb_TajhizName.TabIndex = 154
        Me.cmb_TajhizName.ValueMember = "Srl"
        '
        'PmTajhizNameBindingSource
        '
        Me.PmTajhizNameBindingSource.DataMember = "Pm_TajhizName"
        Me.PmTajhizNameBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_allOrderCode
        '
        Me.chk_allOrderCode.AutoSize = True
        Me.chk_allOrderCode.Location = New System.Drawing.Point(242, 53)
        Me.chk_allOrderCode.Name = "chk_allOrderCode"
        Me.chk_allOrderCode.Size = New System.Drawing.Size(55, 22)
        Me.chk_allOrderCode.TabIndex = 175
        Me.chk_allOrderCode.Text = "همه"
        Me.chk_allOrderCode.UseVisualStyleBackColor = True
        '
        'chk_AllName
        '
        Me.chk_AllName.AutoSize = True
        Me.chk_AllName.Location = New System.Drawing.Point(242, 25)
        Me.chk_AllName.Name = "chk_AllName"
        Me.chk_AllName.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllName.TabIndex = 173
        Me.chk_AllName.Text = "همه"
        Me.chk_AllName.UseVisualStyleBackColor = True
        '
        'txt_OrderCode
        '
        Me.txt_OrderCode.BackColor = System.Drawing.Color.Yellow
        Me.txt_OrderCode.CheckExistValueInDb = True
        Me.txt_OrderCode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_OrderCode.CurrencyUnit = "ریال"
        Me.txt_OrderCode.DefaultValue = ""
        Me.txt_OrderCode.FillWithMaxInDb = False
        Me.txt_OrderCode.IsRequired = True
        Me.txt_OrderCode.Location = New System.Drawing.Point(502, 53)
        Me.txt_OrderCode.MaxDecimalLength = 2
        Me.txt_OrderCode.Name = "txt_OrderCode"
        Me.txt_OrderCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_OrderCode.Size = New System.Drawing.Size(143, 25)
        Me.txt_OrderCode.SpellControl = Nothing
        Me.txt_OrderCode.TabIndex = 153
        Me.txt_OrderCode.Tag = ""
        Me.txt_OrderCode.Title = Nothing
        Me.txt_OrderCode.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_OrderCode.UseForData = True
        Me.txt_OrderCode.ValidateCheckExistOnEdit = False
        Me.txt_OrderCode.Value = ""
        '
        'chk_SubDevice
        '
        Me.chk_SubDevice.AutoSize = True
        Me.chk_SubDevice.Location = New System.Drawing.Point(60, 25)
        Me.chk_SubDevice.Name = "chk_SubDevice"
        Me.chk_SubDevice.Size = New System.Drawing.Size(144, 22)
        Me.chk_SubDevice.TabIndex = 175
        Me.chk_SubDevice.Text = "نمایش زیر مجموعه"
        Me.chk_SubDevice.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(651, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 18)
        Me.Label12.TabIndex = 169
        Me.Label12.Text = "نام تجهیزات"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(651, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "کد سفارش"
        '
        'Tab_Rele
        '
        Me.Tab_Rele.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Tab_Rele.Controls.Add(Me.chk_AllRVT)
        Me.Tab_Rele.Controls.Add(Me.chk_AllRCT)
        Me.Tab_Rele.Controls.Add(Me.chk_AllROrder)
        Me.Tab_Rele.Controls.Add(Me.Chk_AllRNme)
        Me.Tab_Rele.Controls.Add(Me.txt_ReleVT)
        Me.Tab_Rele.Controls.Add(Me.txt_ReleCT)
        Me.Tab_Rele.Controls.Add(Me.txt_ReleOrderCode)
        Me.Tab_Rele.Controls.Add(Me.txt_ReleName)
        Me.Tab_Rele.Controls.Add(Me.Label3)
        Me.Tab_Rele.Controls.Add(Me.Label7)
        Me.Tab_Rele.Controls.Add(Me.Label2)
        Me.Tab_Rele.Controls.Add(Me.Label8)
        Me.Tab_Rele.Location = New System.Drawing.Point(4, 27)
        Me.Tab_Rele.Name = "Tab_Rele"
        Me.Tab_Rele.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Rele.Size = New System.Drawing.Size(749, 199)
        Me.Tab_Rele.TabIndex = 1
        Me.Tab_Rele.Text = "رله"
        Me.Tab_Rele.UseVisualStyleBackColor = True
        '
        'chk_AllRVT
        '
        Me.chk_AllRVT.AutoSize = True
        Me.chk_AllRVT.Location = New System.Drawing.Point(431, 122)
        Me.chk_AllRVT.Name = "chk_AllRVT"
        Me.chk_AllRVT.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllRVT.TabIndex = 199
        Me.chk_AllRVT.Text = "همه"
        Me.chk_AllRVT.UseVisualStyleBackColor = True
        '
        'chk_AllRCT
        '
        Me.chk_AllRCT.AutoSize = True
        Me.chk_AllRCT.Location = New System.Drawing.Point(431, 91)
        Me.chk_AllRCT.Name = "chk_AllRCT"
        Me.chk_AllRCT.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllRCT.TabIndex = 199
        Me.chk_AllRCT.Text = "همه"
        Me.chk_AllRCT.UseVisualStyleBackColor = True
        '
        'chk_AllROrder
        '
        Me.chk_AllROrder.AutoSize = True
        Me.chk_AllROrder.Location = New System.Drawing.Point(431, 56)
        Me.chk_AllROrder.Name = "chk_AllROrder"
        Me.chk_AllROrder.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllROrder.TabIndex = 199
        Me.chk_AllROrder.Text = "همه"
        Me.chk_AllROrder.UseVisualStyleBackColor = True
        '
        'Chk_AllRNme
        '
        Me.Chk_AllRNme.AutoSize = True
        Me.Chk_AllRNme.Location = New System.Drawing.Point(432, 28)
        Me.Chk_AllRNme.Name = "Chk_AllRNme"
        Me.Chk_AllRNme.Size = New System.Drawing.Size(55, 22)
        Me.Chk_AllRNme.TabIndex = 198
        Me.Chk_AllRNme.Text = "همه"
        Me.Chk_AllRNme.UseVisualStyleBackColor = True
        '
        'txt_ReleVT
        '
        Me.txt_ReleVT.BackColor = System.Drawing.SystemColors.Window
        Me.txt_ReleVT.CheckExistValueInDb = True
        Me.txt_ReleVT.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ReleVT.CurrencyUnit = "ریال"
        Me.txt_ReleVT.DefaultValue = ""
        Me.txt_ReleVT.FillWithMaxInDb = False
        Me.txt_ReleVT.IsRequired = True
        Me.txt_ReleVT.Location = New System.Drawing.Point(506, 122)
        Me.txt_ReleVT.MaxDecimalLength = 2
        Me.txt_ReleVT.Name = "txt_ReleVT"
        Me.txt_ReleVT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ReleVT.Size = New System.Drawing.Size(143, 25)
        Me.txt_ReleVT.SpellControl = Nothing
        Me.txt_ReleVT.TabIndex = 186
        Me.txt_ReleVT.Tag = ""
        Me.txt_ReleVT.Title = Nothing
        Me.txt_ReleVT.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ReleVT.UseForData = True
        Me.txt_ReleVT.ValidateCheckExistOnEdit = False
        Me.txt_ReleVT.Value = ""
        '
        'txt_ReleCT
        '
        Me.txt_ReleCT.BackColor = System.Drawing.Color.White
        Me.txt_ReleCT.CheckExistValueInDb = True
        Me.txt_ReleCT.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ReleCT.CurrencyUnit = "ریال"
        Me.txt_ReleCT.DefaultValue = ""
        Me.txt_ReleCT.FillWithMaxInDb = False
        Me.txt_ReleCT.IsRequired = True
        Me.txt_ReleCT.Location = New System.Drawing.Point(506, 91)
        Me.txt_ReleCT.MaxDecimalLength = 2
        Me.txt_ReleCT.Name = "txt_ReleCT"
        Me.txt_ReleCT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ReleCT.Size = New System.Drawing.Size(143, 25)
        Me.txt_ReleCT.SpellControl = Nothing
        Me.txt_ReleCT.TabIndex = 186
        Me.txt_ReleCT.Tag = ""
        Me.txt_ReleCT.Title = Nothing
        Me.txt_ReleCT.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ReleCT.UseForData = True
        Me.txt_ReleCT.ValidateCheckExistOnEdit = False
        Me.txt_ReleCT.Value = ""
        '
        'txt_ReleOrderCode
        '
        Me.txt_ReleOrderCode.BackColor = System.Drawing.SystemColors.Window
        Me.txt_ReleOrderCode.CheckExistValueInDb = True
        Me.txt_ReleOrderCode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ReleOrderCode.CurrencyUnit = "ریال"
        Me.txt_ReleOrderCode.DefaultValue = ""
        Me.txt_ReleOrderCode.FillWithMaxInDb = False
        Me.txt_ReleOrderCode.IsRequired = True
        Me.txt_ReleOrderCode.Location = New System.Drawing.Point(506, 56)
        Me.txt_ReleOrderCode.MaxDecimalLength = 2
        Me.txt_ReleOrderCode.Name = "txt_ReleOrderCode"
        Me.txt_ReleOrderCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ReleOrderCode.Size = New System.Drawing.Size(143, 25)
        Me.txt_ReleOrderCode.SpellControl = Nothing
        Me.txt_ReleOrderCode.TabIndex = 186
        Me.txt_ReleOrderCode.Tag = ""
        Me.txt_ReleOrderCode.Title = Nothing
        Me.txt_ReleOrderCode.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ReleOrderCode.UseForData = True
        Me.txt_ReleOrderCode.ValidateCheckExistOnEdit = False
        Me.txt_ReleOrderCode.Value = ""
        '
        'txt_ReleName
        '
        Me.txt_ReleName.BackColor = System.Drawing.SystemColors.Window
        Me.txt_ReleName.CheckExistValueInDb = True
        Me.txt_ReleName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ReleName.CurrencyUnit = "ریال"
        Me.txt_ReleName.DefaultValue = ""
        Me.txt_ReleName.FillWithMaxInDb = False
        Me.txt_ReleName.IsRequired = True
        Me.txt_ReleName.Location = New System.Drawing.Point(507, 21)
        Me.txt_ReleName.MaxDecimalLength = 2
        Me.txt_ReleName.Name = "txt_ReleName"
        Me.txt_ReleName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ReleName.Size = New System.Drawing.Size(142, 25)
        Me.txt_ReleName.SpellControl = Nothing
        Me.txt_ReleName.TabIndex = 187
        Me.txt_ReleName.Tag = ""
        Me.txt_ReleName.Title = Nothing
        Me.txt_ReleName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ReleName.UseForData = True
        Me.txt_ReleName.ValidateCheckExistOnEdit = False
        Me.txt_ReleName.Value = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(655, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "نسبت VT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(656, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "نام رله"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(655, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "نسبت CT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(655, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "کد سفارش"
        '
        'Tab_TG
        '
        Me.Tab_TG.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Tab_TG.Controls.Add(Me.txt_TGtapConvert)
        Me.Tab_TG.Controls.Add(Me.Label23)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGTapChange)
        Me.Tab_TG.Controls.Add(Me.Label14)
        Me.Tab_TG.Controls.Add(Me.txt_TGBill)
        Me.Tab_TG.Controls.Add(Me.txt_TGFrequncy)
        Me.Tab_TG.Controls.Add(Me.txt_TGTapPlace)
        Me.Tab_TG.Controls.Add(Me.txt_TGJaryan)
        Me.Tab_TG.Controls.Add(Me.txt_TGVolume)
        Me.Tab_TG.Controls.Add(Me.txt_TGampedance)
        Me.Tab_TG.Controls.Add(Me.txt_TGVotaj)
        Me.Tab_TG.Controls.Add(Me.txt_TGColling)
        Me.Tab_TG.Controls.Add(Me.txt_TGName)
        Me.Tab_TG.Controls.Add(Me.txt_TGVectore)
        Me.Tab_TG.Controls.Add(Me.Label15)
        Me.Tab_TG.Controls.Add(Me.Label19)
        Me.Tab_TG.Controls.Add(Me.Label20)
        Me.Tab_TG.Controls.Add(Me.Label21)
        Me.Tab_TG.Controls.Add(Me.Label22)
        Me.Tab_TG.Controls.Add(Me.Label24)
        Me.Tab_TG.Controls.Add(Me.Label25)
        Me.Tab_TG.Controls.Add(Me.Label53)
        Me.Tab_TG.Controls.Add(Me.Label26)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGTapPlace)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGFerequenc)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGJaryanConvert)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGAmpedanse)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGBill)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGValume)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGVotajConvert)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGCooler)
        Me.Tab_TG.Controls.Add(Me.chk_AllTgName)
        Me.Tab_TG.Controls.Add(Me.chk_AllTGVectorGroup)
        Me.Tab_TG.Location = New System.Drawing.Point(4, 27)
        Me.Tab_TG.Name = "Tab_TG"
        Me.Tab_TG.Size = New System.Drawing.Size(749, 199)
        Me.Tab_TG.TabIndex = 2
        Me.Tab_TG.Text = "ترانس قدرت"
        Me.Tab_TG.UseVisualStyleBackColor = True
        '
        'txt_TGtapConvert
        '
        Me.txt_TGtapConvert.CheckExistValueInDb = False
        Me.txt_TGtapConvert.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGtapConvert.CurrencyUnit = "ریال"
        Me.txt_TGtapConvert.DefaultValue = ""
        Me.txt_TGtapConvert.FillWithMaxInDb = False
        Me.txt_TGtapConvert.IsRequired = False
        Me.txt_TGtapConvert.Location = New System.Drawing.Point(109, 117)
        Me.txt_TGtapConvert.MaxDecimalLength = 2
        Me.txt_TGtapConvert.Name = "txt_TGtapConvert"
        Me.txt_TGtapConvert.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGtapConvert.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGtapConvert.SpellControl = Nothing
        Me.txt_TGtapConvert.TabIndex = 230
        Me.txt_TGtapConvert.Tag = "OrderCode"
        Me.txt_TGtapConvert.Title = Nothing
        Me.txt_TGtapConvert.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGtapConvert.UseForData = True
        Me.txt_TGtapConvert.ValidateCheckExistOnEdit = False
        Me.txt_TGtapConvert.Value = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(264, 122)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(114, 18)
        Me.Label23.TabIndex = 229
        Me.Label23.Text = "سیستم تغییر تپ"
        '
        'chk_AllTGTapChange
        '
        Me.chk_AllTGTapChange.AutoSize = True
        Me.chk_AllTGTapChange.Location = New System.Drawing.Point(29, 118)
        Me.chk_AllTGTapChange.Name = "chk_AllTGTapChange"
        Me.chk_AllTGTapChange.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGTapChange.TabIndex = 228
        Me.chk_AllTGTapChange.Text = "همه"
        Me.chk_AllTGTapChange.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(266, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 18)
        Me.Label14.TabIndex = 227
        Me.Label14.Text = "Bil"
        '
        'txt_TGBill
        '
        Me.txt_TGBill.CheckExistValueInDb = False
        Me.txt_TGBill.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGBill.CurrencyUnit = "ریال"
        Me.txt_TGBill.DefaultValue = ""
        Me.txt_TGBill.FillWithMaxInDb = False
        Me.txt_TGBill.IsRequired = False
        Me.txt_TGBill.Location = New System.Drawing.Point(109, 88)
        Me.txt_TGBill.MaxDecimalLength = 2
        Me.txt_TGBill.Name = "txt_TGBill"
        Me.txt_TGBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGBill.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGBill.SpellControl = Nothing
        Me.txt_TGBill.TabIndex = 226
        Me.txt_TGBill.Tag = "SerialNumber"
        Me.txt_TGBill.Title = Nothing
        Me.txt_TGBill.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGBill.UseForData = True
        Me.txt_TGBill.ValidateCheckExistOnEdit = False
        Me.txt_TGBill.Value = ""
        '
        'txt_TGFrequncy
        '
        Me.txt_TGFrequncy.CheckExistValueInDb = False
        Me.txt_TGFrequncy.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGFrequncy.CurrencyUnit = "ریال"
        Me.txt_TGFrequncy.DefaultValue = ""
        Me.txt_TGFrequncy.FillWithMaxInDb = False
        Me.txt_TGFrequncy.IsRequired = False
        Me.txt_TGFrequncy.Location = New System.Drawing.Point(490, 162)
        Me.txt_TGFrequncy.MaxDecimalLength = 2
        Me.txt_TGFrequncy.Name = "txt_TGFrequncy"
        Me.txt_TGFrequncy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGFrequncy.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGFrequncy.SpellControl = Nothing
        Me.txt_TGFrequncy.TabIndex = 225
        Me.txt_TGFrequncy.Tag = "OrderCode"
        Me.txt_TGFrequncy.Title = Nothing
        Me.txt_TGFrequncy.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGFrequncy.UseForData = True
        Me.txt_TGFrequncy.ValidateCheckExistOnEdit = False
        Me.txt_TGFrequncy.Value = ""
        '
        'txt_TGTapPlace
        '
        Me.txt_TGTapPlace.CheckExistValueInDb = False
        Me.txt_TGTapPlace.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGTapPlace.CurrencyUnit = "ریال"
        Me.txt_TGTapPlace.DefaultValue = ""
        Me.txt_TGTapPlace.FillWithMaxInDb = False
        Me.txt_TGTapPlace.IsRequired = False
        Me.txt_TGTapPlace.Location = New System.Drawing.Point(110, 153)
        Me.txt_TGTapPlace.MaxDecimalLength = 2
        Me.txt_TGTapPlace.Name = "txt_TGTapPlace"
        Me.txt_TGTapPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGTapPlace.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGTapPlace.SpellControl = Nothing
        Me.txt_TGTapPlace.TabIndex = 223
        Me.txt_TGTapPlace.Tag = "OrderCode"
        Me.txt_TGTapPlace.Title = Nothing
        Me.txt_TGTapPlace.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGTapPlace.UseForData = True
        Me.txt_TGTapPlace.ValidateCheckExistOnEdit = False
        Me.txt_TGTapPlace.Value = ""
        '
        'txt_TGJaryan
        '
        Me.txt_TGJaryan.CheckExistValueInDb = False
        Me.txt_TGJaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGJaryan.CurrencyUnit = "ریال"
        Me.txt_TGJaryan.DefaultValue = ""
        Me.txt_TGJaryan.FillWithMaxInDb = False
        Me.txt_TGJaryan.IsRequired = False
        Me.txt_TGJaryan.Location = New System.Drawing.Point(490, 104)
        Me.txt_TGJaryan.MaxDecimalLength = 2
        Me.txt_TGJaryan.Name = "txt_TGJaryan"
        Me.txt_TGJaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGJaryan.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGJaryan.SpellControl = Nothing
        Me.txt_TGJaryan.TabIndex = 221
        Me.txt_TGJaryan.Tag = "OrderCode"
        Me.txt_TGJaryan.Title = Nothing
        Me.txt_TGJaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGJaryan.UseForData = True
        Me.txt_TGJaryan.ValidateCheckExistOnEdit = False
        Me.txt_TGJaryan.Value = ""
        '
        'txt_TGVolume
        '
        Me.txt_TGVolume.CheckExistValueInDb = False
        Me.txt_TGVolume.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGVolume.CurrencyUnit = "ریال"
        Me.txt_TGVolume.DefaultValue = ""
        Me.txt_TGVolume.FillWithMaxInDb = False
        Me.txt_TGVolume.IsRequired = False
        Me.txt_TGVolume.Location = New System.Drawing.Point(109, 54)
        Me.txt_TGVolume.MaxDecimalLength = 2
        Me.txt_TGVolume.Name = "txt_TGVolume"
        Me.txt_TGVolume.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGVolume.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGVolume.SpellControl = Nothing
        Me.txt_TGVolume.TabIndex = 217
        Me.txt_TGVolume.Tag = "OrderCode"
        Me.txt_TGVolume.Title = Nothing
        Me.txt_TGVolume.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGVolume.UseForData = True
        Me.txt_TGVolume.ValidateCheckExistOnEdit = False
        Me.txt_TGVolume.Value = ""
        '
        'txt_TGampedance
        '
        Me.txt_TGampedance.CheckExistValueInDb = False
        Me.txt_TGampedance.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGampedance.CurrencyUnit = "ریال"
        Me.txt_TGampedance.DefaultValue = ""
        Me.txt_TGampedance.FillWithMaxInDb = False
        Me.txt_TGampedance.IsRequired = False
        Me.txt_TGampedance.Location = New System.Drawing.Point(490, 133)
        Me.txt_TGampedance.MaxDecimalLength = 2
        Me.txt_TGampedance.Name = "txt_TGampedance"
        Me.txt_TGampedance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGampedance.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGampedance.SpellControl = Nothing
        Me.txt_TGampedance.TabIndex = 224
        Me.txt_TGampedance.Tag = "OrderCode"
        Me.txt_TGampedance.Title = Nothing
        Me.txt_TGampedance.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGampedance.UseForData = True
        Me.txt_TGampedance.ValidateCheckExistOnEdit = False
        Me.txt_TGampedance.Value = ""
        '
        'txt_TGVotaj
        '
        Me.txt_TGVotaj.CheckExistValueInDb = False
        Me.txt_TGVotaj.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGVotaj.CurrencyUnit = "ریال"
        Me.txt_TGVotaj.DefaultValue = ""
        Me.txt_TGVotaj.FillWithMaxInDb = False
        Me.txt_TGVotaj.IsRequired = False
        Me.txt_TGVotaj.Location = New System.Drawing.Point(490, 73)
        Me.txt_TGVotaj.MaxDecimalLength = 2
        Me.txt_TGVotaj.Name = "txt_TGVotaj"
        Me.txt_TGVotaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGVotaj.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGVotaj.SpellControl = Nothing
        Me.txt_TGVotaj.TabIndex = 220
        Me.txt_TGVotaj.Tag = "OrderCode"
        Me.txt_TGVotaj.Title = Nothing
        Me.txt_TGVotaj.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGVotaj.UseForData = True
        Me.txt_TGVotaj.ValidateCheckExistOnEdit = False
        Me.txt_TGVotaj.Value = ""
        '
        'txt_TGColling
        '
        Me.txt_TGColling.CheckExistValueInDb = False
        Me.txt_TGColling.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGColling.CurrencyUnit = "ریال"
        Me.txt_TGColling.DefaultValue = ""
        Me.txt_TGColling.FillWithMaxInDb = False
        Me.txt_TGColling.IsRequired = False
        Me.txt_TGColling.Location = New System.Drawing.Point(109, 20)
        Me.txt_TGColling.MaxDecimalLength = 2
        Me.txt_TGColling.Name = "txt_TGColling"
        Me.txt_TGColling.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGColling.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGColling.SpellControl = Nothing
        Me.txt_TGColling.TabIndex = 216
        Me.txt_TGColling.Tag = "OrderCode"
        Me.txt_TGColling.Title = Nothing
        Me.txt_TGColling.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGColling.UseForData = True
        Me.txt_TGColling.ValidateCheckExistOnEdit = False
        Me.txt_TGColling.Value = ""
        '
        'txt_TGName
        '
        Me.txt_TGName.CheckExistValueInDb = False
        Me.txt_TGName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGName.CurrencyUnit = "ریال"
        Me.txt_TGName.DefaultValue = ""
        Me.txt_TGName.FillWithMaxInDb = False
        Me.txt_TGName.IsRequired = False
        Me.txt_TGName.Location = New System.Drawing.Point(489, 12)
        Me.txt_TGName.MaxDecimalLength = 2
        Me.txt_TGName.Name = "txt_TGName"
        Me.txt_TGName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGName.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGName.SpellControl = Nothing
        Me.txt_TGName.TabIndex = 218
        Me.txt_TGName.Tag = "OrderCode"
        Me.txt_TGName.Title = Nothing
        Me.txt_TGName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGName.UseForData = True
        Me.txt_TGName.ValidateCheckExistOnEdit = False
        Me.txt_TGName.Value = ""
        '
        'txt_TGVectore
        '
        Me.txt_TGVectore.CheckExistValueInDb = False
        Me.txt_TGVectore.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TGVectore.CurrencyUnit = "ریال"
        Me.txt_TGVectore.DefaultValue = ""
        Me.txt_TGVectore.FillWithMaxInDb = False
        Me.txt_TGVectore.IsRequired = False
        Me.txt_TGVectore.Location = New System.Drawing.Point(489, 43)
        Me.txt_TGVectore.MaxDecimalLength = 2
        Me.txt_TGVectore.Name = "txt_TGVectore"
        Me.txt_TGVectore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TGVectore.Size = New System.Drawing.Size(145, 25)
        Me.txt_TGVectore.SpellControl = Nothing
        Me.txt_TGVectore.TabIndex = 218
        Me.txt_TGVectore.Tag = "OrderCode"
        Me.txt_TGVectore.Title = Nothing
        Me.txt_TGVectore.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TGVectore.UseForData = True
        Me.txt_TGVectore.ValidateCheckExistOnEdit = False
        Me.txt_TGVectore.Value = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(646, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 18)
        Me.Label15.TabIndex = 209
        Me.Label15.Text = "فرکانس"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(264, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 18)
        Me.Label19.TabIndex = 210
        Me.Label19.Text = "محل تپ"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(646, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 18)
        Me.Label20.TabIndex = 208
        Me.Label20.Text = "تبدیل جریان"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(264, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 18)
        Me.Label21.TabIndex = 206
        Me.Label21.Text = "ظرفیت نامی"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(646, 138)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 18)
        Me.Label22.TabIndex = 207
        Me.Label22.Text = "درصد امپدانس"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(646, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 18)
        Me.Label24.TabIndex = 214
        Me.Label24.Text = "تبدیل ولتاژ"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(264, 25)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 18)
        Me.Label25.TabIndex = 211
        Me.Label25.Text = "خنک کننده"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(646, 17)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(67, 18)
        Me.Label53.TabIndex = 212
        Me.Label53.Text = "نام ترانس"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(646, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(78, 18)
        Me.Label26.TabIndex = 212
        Me.Label26.Text = "گروه برداری"
        '
        'chk_AllTGTapPlace
        '
        Me.chk_AllTGTapPlace.AutoSize = True
        Me.chk_AllTGTapPlace.Location = New System.Drawing.Point(29, 152)
        Me.chk_AllTGTapPlace.Name = "chk_AllTGTapPlace"
        Me.chk_AllTGTapPlace.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGTapPlace.TabIndex = 205
        Me.chk_AllTGTapPlace.Text = "همه"
        Me.chk_AllTGTapPlace.UseVisualStyleBackColor = True
        '
        'chk_AllTGFerequenc
        '
        Me.chk_AllTGFerequenc.AutoSize = True
        Me.chk_AllTGFerequenc.Location = New System.Drawing.Point(415, 159)
        Me.chk_AllTGFerequenc.Name = "chk_AllTGFerequenc"
        Me.chk_AllTGFerequenc.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGFerequenc.TabIndex = 205
        Me.chk_AllTGFerequenc.Text = "همه"
        Me.chk_AllTGFerequenc.UseVisualStyleBackColor = True
        '
        'chk_AllTGJaryanConvert
        '
        Me.chk_AllTGJaryanConvert.AutoSize = True
        Me.chk_AllTGJaryanConvert.Location = New System.Drawing.Point(415, 104)
        Me.chk_AllTGJaryanConvert.Name = "chk_AllTGJaryanConvert"
        Me.chk_AllTGJaryanConvert.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGJaryanConvert.TabIndex = 205
        Me.chk_AllTGJaryanConvert.Text = "همه"
        Me.chk_AllTGJaryanConvert.UseVisualStyleBackColor = True
        '
        'chk_AllTGAmpedanse
        '
        Me.chk_AllTGAmpedanse.AutoSize = True
        Me.chk_AllTGAmpedanse.Location = New System.Drawing.Point(415, 137)
        Me.chk_AllTGAmpedanse.Name = "chk_AllTGAmpedanse"
        Me.chk_AllTGAmpedanse.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGAmpedanse.TabIndex = 205
        Me.chk_AllTGAmpedanse.Text = "همه"
        Me.chk_AllTGAmpedanse.UseVisualStyleBackColor = True
        '
        'chk_AllTGBill
        '
        Me.chk_AllTGBill.AutoSize = True
        Me.chk_AllTGBill.Location = New System.Drawing.Point(29, 87)
        Me.chk_AllTGBill.Name = "chk_AllTGBill"
        Me.chk_AllTGBill.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGBill.TabIndex = 205
        Me.chk_AllTGBill.Text = "همه"
        Me.chk_AllTGBill.UseVisualStyleBackColor = True
        '
        'chk_AllTGValume
        '
        Me.chk_AllTGValume.AutoSize = True
        Me.chk_AllTGValume.Location = New System.Drawing.Point(29, 54)
        Me.chk_AllTGValume.Name = "chk_AllTGValume"
        Me.chk_AllTGValume.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGValume.TabIndex = 205
        Me.chk_AllTGValume.Text = "همه"
        Me.chk_AllTGValume.UseVisualStyleBackColor = True
        '
        'chk_AllTGVotajConvert
        '
        Me.chk_AllTGVotajConvert.AutoSize = True
        Me.chk_AllTGVotajConvert.Location = New System.Drawing.Point(415, 72)
        Me.chk_AllTGVotajConvert.Name = "chk_AllTGVotajConvert"
        Me.chk_AllTGVotajConvert.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGVotajConvert.TabIndex = 205
        Me.chk_AllTGVotajConvert.Text = "همه"
        Me.chk_AllTGVotajConvert.UseVisualStyleBackColor = True
        '
        'chk_AllTGCooler
        '
        Me.chk_AllTGCooler.AutoSize = True
        Me.chk_AllTGCooler.Location = New System.Drawing.Point(29, 20)
        Me.chk_AllTGCooler.Name = "chk_AllTGCooler"
        Me.chk_AllTGCooler.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGCooler.TabIndex = 205
        Me.chk_AllTGCooler.Text = "همه"
        Me.chk_AllTGCooler.UseVisualStyleBackColor = True
        '
        'chk_AllTgName
        '
        Me.chk_AllTgName.AutoSize = True
        Me.chk_AllTgName.Location = New System.Drawing.Point(415, 10)
        Me.chk_AllTgName.Name = "chk_AllTgName"
        Me.chk_AllTgName.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTgName.TabIndex = 205
        Me.chk_AllTgName.Text = "همه"
        Me.chk_AllTgName.UseVisualStyleBackColor = True
        '
        'chk_AllTGVectorGroup
        '
        Me.chk_AllTGVectorGroup.AutoSize = True
        Me.chk_AllTGVectorGroup.Location = New System.Drawing.Point(415, 41)
        Me.chk_AllTGVectorGroup.Name = "chk_AllTGVectorGroup"
        Me.chk_AllTGVectorGroup.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTGVectorGroup.TabIndex = 205
        Me.chk_AllTGVectorGroup.Text = "همه"
        Me.chk_AllTGVectorGroup.UseVisualStyleBackColor = True
        '
        'Tab_Barghgir
        '
        Me.Tab_Barghgir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Tab_Barghgir.Controls.Add(Me.chk_AllBGName)
        Me.Tab_Barghgir.Controls.Add(Me.chk_AllBGVoltaj)
        Me.Tab_Barghgir.Controls.Add(Me.chk_AllBGClass)
        Me.Tab_Barghgir.Controls.Add(Me.chk_AllBGSC)
        Me.Tab_Barghgir.Controls.Add(Me.chk_AllBGJaryan)
        Me.Tab_Barghgir.Controls.Add(Me.chk_AllBGTavan)
        Me.Tab_Barghgir.Controls.Add(Me.txt_BGClass)
        Me.Tab_Barghgir.Controls.Add(Me.txt_BGJaryan)
        Me.Tab_Barghgir.Controls.Add(Me.txt_BGName)
        Me.Tab_Barghgir.Controls.Add(Me.txt_BGJaryanSC)
        Me.Tab_Barghgir.Controls.Add(Me.txt_BGVoltaj)
        Me.Tab_Barghgir.Controls.Add(Me.txt_BGTavan)
        Me.Tab_Barghgir.Controls.Add(Me.Label11)
        Me.Tab_Barghgir.Controls.Add(Me.Label13)
        Me.Tab_Barghgir.Controls.Add(Me.Label54)
        Me.Tab_Barghgir.Controls.Add(Me.Label27)
        Me.Tab_Barghgir.Controls.Add(Me.Label28)
        Me.Tab_Barghgir.Controls.Add(Me.Label29)
        Me.Tab_Barghgir.Location = New System.Drawing.Point(4, 27)
        Me.Tab_Barghgir.Name = "Tab_Barghgir"
        Me.Tab_Barghgir.Size = New System.Drawing.Size(749, 199)
        Me.Tab_Barghgir.TabIndex = 3
        Me.Tab_Barghgir.Text = "برقگیر"
        Me.Tab_Barghgir.UseVisualStyleBackColor = True
        '
        'chk_AllBGName
        '
        Me.chk_AllBGName.AutoSize = True
        Me.chk_AllBGName.Location = New System.Drawing.Point(416, 55)
        Me.chk_AllBGName.Name = "chk_AllBGName"
        Me.chk_AllBGName.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBGName.TabIndex = 206
        Me.chk_AllBGName.Text = "همه"
        Me.chk_AllBGName.UseVisualStyleBackColor = True
        '
        'chk_AllBGVoltaj
        '
        Me.chk_AllBGVoltaj.AutoSize = True
        Me.chk_AllBGVoltaj.Location = New System.Drawing.Point(416, 84)
        Me.chk_AllBGVoltaj.Name = "chk_AllBGVoltaj"
        Me.chk_AllBGVoltaj.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBGVoltaj.TabIndex = 206
        Me.chk_AllBGVoltaj.Text = "همه"
        Me.chk_AllBGVoltaj.UseVisualStyleBackColor = True
        '
        'chk_AllBGClass
        '
        Me.chk_AllBGClass.AutoSize = True
        Me.chk_AllBGClass.Location = New System.Drawing.Point(27, 115)
        Me.chk_AllBGClass.Name = "chk_AllBGClass"
        Me.chk_AllBGClass.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBGClass.TabIndex = 206
        Me.chk_AllBGClass.Text = "همه"
        Me.chk_AllBGClass.UseVisualStyleBackColor = True
        '
        'chk_AllBGSC
        '
        Me.chk_AllBGSC.AutoSize = True
        Me.chk_AllBGSC.Location = New System.Drawing.Point(27, 84)
        Me.chk_AllBGSC.Name = "chk_AllBGSC"
        Me.chk_AllBGSC.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBGSC.TabIndex = 206
        Me.chk_AllBGSC.Text = "همه"
        Me.chk_AllBGSC.UseVisualStyleBackColor = True
        '
        'chk_AllBGJaryan
        '
        Me.chk_AllBGJaryan.AutoSize = True
        Me.chk_AllBGJaryan.Location = New System.Drawing.Point(27, 53)
        Me.chk_AllBGJaryan.Name = "chk_AllBGJaryan"
        Me.chk_AllBGJaryan.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBGJaryan.TabIndex = 206
        Me.chk_AllBGJaryan.Text = "همه"
        Me.chk_AllBGJaryan.UseVisualStyleBackColor = True
        '
        'chk_AllBGTavan
        '
        Me.chk_AllBGTavan.AutoSize = True
        Me.chk_AllBGTavan.Location = New System.Drawing.Point(416, 118)
        Me.chk_AllBGTavan.Name = "chk_AllBGTavan"
        Me.chk_AllBGTavan.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBGTavan.TabIndex = 206
        Me.chk_AllBGTavan.Text = "همه"
        Me.chk_AllBGTavan.UseVisualStyleBackColor = True
        '
        'txt_BGClass
        '
        Me.txt_BGClass.CheckExistValueInDb = False
        Me.txt_BGClass.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BGClass.CurrencyUnit = "ریال"
        Me.txt_BGClass.DefaultValue = ""
        Me.txt_BGClass.FillWithMaxInDb = False
        Me.txt_BGClass.IsRequired = False
        Me.txt_BGClass.Location = New System.Drawing.Point(106, 115)
        Me.txt_BGClass.MaxDecimalLength = 2
        Me.txt_BGClass.Name = "txt_BGClass"
        Me.txt_BGClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BGClass.Size = New System.Drawing.Size(145, 25)
        Me.txt_BGClass.SpellControl = Nothing
        Me.txt_BGClass.TabIndex = 21
        Me.txt_BGClass.Tag = "OrderCode"
        Me.txt_BGClass.Title = Nothing
        Me.txt_BGClass.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BGClass.UseForData = True
        Me.txt_BGClass.ValidateCheckExistOnEdit = False
        Me.txt_BGClass.Value = ""
        '
        'txt_BGJaryan
        '
        Me.txt_BGJaryan.CheckExistValueInDb = False
        Me.txt_BGJaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BGJaryan.CurrencyUnit = "ریال"
        Me.txt_BGJaryan.DefaultValue = ""
        Me.txt_BGJaryan.FillWithMaxInDb = False
        Me.txt_BGJaryan.IsRequired = False
        Me.txt_BGJaryan.Location = New System.Drawing.Point(105, 53)
        Me.txt_BGJaryan.MaxDecimalLength = 2
        Me.txt_BGJaryan.Name = "txt_BGJaryan"
        Me.txt_BGJaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BGJaryan.Size = New System.Drawing.Size(145, 25)
        Me.txt_BGJaryan.SpellControl = Nothing
        Me.txt_BGJaryan.TabIndex = 18
        Me.txt_BGJaryan.Tag = "OrderCode"
        Me.txt_BGJaryan.Title = Nothing
        Me.txt_BGJaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BGJaryan.UseForData = True
        Me.txt_BGJaryan.ValidateCheckExistOnEdit = False
        Me.txt_BGJaryan.Value = ""
        '
        'txt_BGName
        '
        Me.txt_BGName.BackColor = System.Drawing.Color.Yellow
        Me.txt_BGName.CheckExistValueInDb = False
        Me.txt_BGName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BGName.CurrencyUnit = "ریال"
        Me.txt_BGName.DefaultValue = ""
        Me.txt_BGName.FillWithMaxInDb = False
        Me.txt_BGName.IsRequired = False
        Me.txt_BGName.Location = New System.Drawing.Point(495, 55)
        Me.txt_BGName.MaxDecimalLength = 2
        Me.txt_BGName.Name = "txt_BGName"
        Me.txt_BGName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BGName.Size = New System.Drawing.Size(145, 25)
        Me.txt_BGName.SpellControl = Nothing
        Me.txt_BGName.TabIndex = 17
        Me.txt_BGName.Tag = "OrderCode"
        Me.txt_BGName.Title = Nothing
        Me.txt_BGName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BGName.UseForData = True
        Me.txt_BGName.ValidateCheckExistOnEdit = False
        Me.txt_BGName.Value = ""
        '
        'txt_BGJaryanSC
        '
        Me.txt_BGJaryanSC.CheckExistValueInDb = False
        Me.txt_BGJaryanSC.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BGJaryanSC.CurrencyUnit = "ریال"
        Me.txt_BGJaryanSC.DefaultValue = ""
        Me.txt_BGJaryanSC.FillWithMaxInDb = False
        Me.txt_BGJaryanSC.IsRequired = False
        Me.txt_BGJaryanSC.Location = New System.Drawing.Point(106, 84)
        Me.txt_BGJaryanSC.MaxDecimalLength = 2
        Me.txt_BGJaryanSC.Name = "txt_BGJaryanSC"
        Me.txt_BGJaryanSC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BGJaryanSC.Size = New System.Drawing.Size(145, 25)
        Me.txt_BGJaryanSC.SpellControl = Nothing
        Me.txt_BGJaryanSC.TabIndex = 20
        Me.txt_BGJaryanSC.Tag = "OrderCode"
        Me.txt_BGJaryanSC.Title = Nothing
        Me.txt_BGJaryanSC.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BGJaryanSC.UseForData = True
        Me.txt_BGJaryanSC.ValidateCheckExistOnEdit = False
        Me.txt_BGJaryanSC.Value = ""
        '
        'txt_BGVoltaj
        '
        Me.txt_BGVoltaj.BackColor = System.Drawing.Color.Yellow
        Me.txt_BGVoltaj.CheckExistValueInDb = False
        Me.txt_BGVoltaj.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BGVoltaj.CurrencyUnit = "ریال"
        Me.txt_BGVoltaj.DefaultValue = ""
        Me.txt_BGVoltaj.FillWithMaxInDb = False
        Me.txt_BGVoltaj.IsRequired = False
        Me.txt_BGVoltaj.Location = New System.Drawing.Point(495, 84)
        Me.txt_BGVoltaj.MaxDecimalLength = 2
        Me.txt_BGVoltaj.Name = "txt_BGVoltaj"
        Me.txt_BGVoltaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BGVoltaj.Size = New System.Drawing.Size(145, 25)
        Me.txt_BGVoltaj.SpellControl = Nothing
        Me.txt_BGVoltaj.TabIndex = 17
        Me.txt_BGVoltaj.Tag = "OrderCode"
        Me.txt_BGVoltaj.Title = Nothing
        Me.txt_BGVoltaj.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BGVoltaj.UseForData = True
        Me.txt_BGVoltaj.ValidateCheckExistOnEdit = False
        Me.txt_BGVoltaj.Value = ""
        '
        'txt_BGTavan
        '
        Me.txt_BGTavan.CheckExistValueInDb = False
        Me.txt_BGTavan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BGTavan.CurrencyUnit = "ریال"
        Me.txt_BGTavan.DefaultValue = ""
        Me.txt_BGTavan.FillWithMaxInDb = False
        Me.txt_BGTavan.IsRequired = False
        Me.txt_BGTavan.Location = New System.Drawing.Point(495, 116)
        Me.txt_BGTavan.MaxDecimalLength = 2
        Me.txt_BGTavan.Name = "txt_BGTavan"
        Me.txt_BGTavan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BGTavan.Size = New System.Drawing.Size(145, 25)
        Me.txt_BGTavan.SpellControl = Nothing
        Me.txt_BGTavan.TabIndex = 19
        Me.txt_BGTavan.Tag = "OrderCode"
        Me.txt_BGTavan.Title = Nothing
        Me.txt_BGTavan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BGTavan.UseForData = True
        Me.txt_BGTavan.ValidateCheckExistOnEdit = False
        Me.txt_BGTavan.Value = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(262, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "کلاس"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(261, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "جریان نامی"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(651, 60)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(65, 18)
        Me.Label54.TabIndex = 16
        Me.Label54.Text = "نام برقگیر"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(262, 89)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(116, 18)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "جریان اتصال کوتاه"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(651, 89)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(68, 18)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "ولتاژ نامی"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(651, 121)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 18)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "توان نامی"
        '
        'Tab_Sexioner
        '
        Me.Tab_Sexioner.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Tab_Sexioner.Controls.Add(Me.chk_AllSexVoltaj)
        Me.Tab_Sexioner.Controls.Add(Me.chk_AllSexSC)
        Me.Tab_Sexioner.Controls.Add(Me.chk_AllsexUtiVoltaj)
        Me.Tab_Sexioner.Controls.Add(Me.chk_AllSexMaxJaryan)
        Me.Tab_Sexioner.Controls.Add(Me.chk_AllSexName)
        Me.Tab_Sexioner.Controls.Add(Me.chk_AllSexJaryan)
        Me.Tab_Sexioner.Controls.Add(Me.txt_sexUtilizationVoltaje)
        Me.Tab_Sexioner.Controls.Add(Me.txt_SexName)
        Me.Tab_Sexioner.Controls.Add(Me.txt_SexJaryan)
        Me.Tab_Sexioner.Controls.Add(Me.txt_SexJaryanSC)
        Me.Tab_Sexioner.Controls.Add(Me.txt_SexVoltage)
        Me.Tab_Sexioner.Controls.Add(Me.txt_SexMaxJaryan)
        Me.Tab_Sexioner.Controls.Add(Me.Label30)
        Me.Tab_Sexioner.Controls.Add(Me.Label55)
        Me.Tab_Sexioner.Controls.Add(Me.Label31)
        Me.Tab_Sexioner.Controls.Add(Me.Label32)
        Me.Tab_Sexioner.Controls.Add(Me.Label33)
        Me.Tab_Sexioner.Controls.Add(Me.Label34)
        Me.Tab_Sexioner.Location = New System.Drawing.Point(4, 27)
        Me.Tab_Sexioner.Name = "Tab_Sexioner"
        Me.Tab_Sexioner.Size = New System.Drawing.Size(749, 199)
        Me.Tab_Sexioner.TabIndex = 4
        Me.Tab_Sexioner.Text = "سکسیونر"
        Me.Tab_Sexioner.UseVisualStyleBackColor = True
        '
        'chk_AllSexVoltaj
        '
        Me.chk_AllSexVoltaj.AutoSize = True
        Me.chk_AllSexVoltaj.Location = New System.Drawing.Point(418, 89)
        Me.chk_AllSexVoltaj.Name = "chk_AllSexVoltaj"
        Me.chk_AllSexVoltaj.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllSexVoltaj.TabIndex = 210
        Me.chk_AllSexVoltaj.Text = "همه"
        Me.chk_AllSexVoltaj.UseVisualStyleBackColor = True
        '
        'chk_AllSexSC
        '
        Me.chk_AllSexSC.AutoSize = True
        Me.chk_AllSexSC.Location = New System.Drawing.Point(7, 120)
        Me.chk_AllSexSC.Name = "chk_AllSexSC"
        Me.chk_AllSexSC.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllSexSC.TabIndex = 211
        Me.chk_AllSexSC.Text = "همه"
        Me.chk_AllSexSC.UseVisualStyleBackColor = True
        '
        'chk_AllsexUtiVoltaj
        '
        Me.chk_AllsexUtiVoltaj.AutoSize = True
        Me.chk_AllsexUtiVoltaj.Location = New System.Drawing.Point(7, 89)
        Me.chk_AllsexUtiVoltaj.Name = "chk_AllsexUtiVoltaj"
        Me.chk_AllsexUtiVoltaj.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllsexUtiVoltaj.TabIndex = 209
        Me.chk_AllsexUtiVoltaj.Text = "همه"
        Me.chk_AllsexUtiVoltaj.UseVisualStyleBackColor = True
        '
        'chk_AllSexMaxJaryan
        '
        Me.chk_AllSexMaxJaryan.AutoSize = True
        Me.chk_AllSexMaxJaryan.Location = New System.Drawing.Point(7, 58)
        Me.chk_AllSexMaxJaryan.Name = "chk_AllSexMaxJaryan"
        Me.chk_AllSexMaxJaryan.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllSexMaxJaryan.TabIndex = 207
        Me.chk_AllSexMaxJaryan.Text = "همه"
        Me.chk_AllSexMaxJaryan.UseVisualStyleBackColor = True
        '
        'chk_AllSexName
        '
        Me.chk_AllSexName.AutoSize = True
        Me.chk_AllSexName.Location = New System.Drawing.Point(418, 62)
        Me.chk_AllSexName.Name = "chk_AllSexName"
        Me.chk_AllSexName.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllSexName.TabIndex = 208
        Me.chk_AllSexName.Text = "همه"
        Me.chk_AllSexName.UseVisualStyleBackColor = True
        '
        'chk_AllSexJaryan
        '
        Me.chk_AllSexJaryan.AutoSize = True
        Me.chk_AllSexJaryan.Location = New System.Drawing.Point(418, 123)
        Me.chk_AllSexJaryan.Name = "chk_AllSexJaryan"
        Me.chk_AllSexJaryan.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllSexJaryan.TabIndex = 208
        Me.chk_AllSexJaryan.Text = "همه"
        Me.chk_AllSexJaryan.UseVisualStyleBackColor = True
        '
        'txt_sexUtilizationVoltaje
        '
        Me.txt_sexUtilizationVoltaje.CheckExistValueInDb = False
        Me.txt_sexUtilizationVoltaje.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_sexUtilizationVoltaje.CurrencyUnit = "ریال"
        Me.txt_sexUtilizationVoltaje.DefaultValue = ""
        Me.txt_sexUtilizationVoltaje.FillWithMaxInDb = False
        Me.txt_sexUtilizationVoltaje.IsRequired = False
        Me.txt_sexUtilizationVoltaje.Location = New System.Drawing.Point(76, 86)
        Me.txt_sexUtilizationVoltaje.MaxDecimalLength = 2
        Me.txt_sexUtilizationVoltaje.Name = "txt_sexUtilizationVoltaje"
        Me.txt_sexUtilizationVoltaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_sexUtilizationVoltaje.Size = New System.Drawing.Size(145, 25)
        Me.txt_sexUtilizationVoltaje.SpellControl = Nothing
        Me.txt_sexUtilizationVoltaje.TabIndex = 21
        Me.txt_sexUtilizationVoltaje.Tag = "OrderCode"
        Me.txt_sexUtilizationVoltaje.Title = Nothing
        Me.txt_sexUtilizationVoltaje.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_sexUtilizationVoltaje.UseForData = True
        Me.txt_sexUtilizationVoltaje.ValidateCheckExistOnEdit = False
        Me.txt_sexUtilizationVoltaje.Value = ""
        '
        'txt_SexName
        '
        Me.txt_SexName.CheckExistValueInDb = False
        Me.txt_SexName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SexName.CurrencyUnit = "ریال"
        Me.txt_SexName.DefaultValue = ""
        Me.txt_SexName.FillWithMaxInDb = False
        Me.txt_SexName.IsRequired = False
        Me.txt_SexName.Location = New System.Drawing.Point(487, 57)
        Me.txt_SexName.MaxDecimalLength = 2
        Me.txt_SexName.Name = "txt_SexName"
        Me.txt_SexName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SexName.Size = New System.Drawing.Size(145, 25)
        Me.txt_SexName.SpellControl = Nothing
        Me.txt_SexName.TabIndex = 18
        Me.txt_SexName.Tag = "OrderCode"
        Me.txt_SexName.Title = Nothing
        Me.txt_SexName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SexName.UseForData = True
        Me.txt_SexName.ValidateCheckExistOnEdit = False
        Me.txt_SexName.Value = ""
        '
        'txt_SexJaryan
        '
        Me.txt_SexJaryan.CheckExistValueInDb = False
        Me.txt_SexJaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SexJaryan.CurrencyUnit = "ریال"
        Me.txt_SexJaryan.DefaultValue = ""
        Me.txt_SexJaryan.FillWithMaxInDb = False
        Me.txt_SexJaryan.IsRequired = False
        Me.txt_SexJaryan.Location = New System.Drawing.Point(487, 118)
        Me.txt_SexJaryan.MaxDecimalLength = 2
        Me.txt_SexJaryan.Name = "txt_SexJaryan"
        Me.txt_SexJaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SexJaryan.Size = New System.Drawing.Size(145, 25)
        Me.txt_SexJaryan.SpellControl = Nothing
        Me.txt_SexJaryan.TabIndex = 18
        Me.txt_SexJaryan.Tag = "OrderCode"
        Me.txt_SexJaryan.Title = Nothing
        Me.txt_SexJaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SexJaryan.UseForData = True
        Me.txt_SexJaryan.ValidateCheckExistOnEdit = False
        Me.txt_SexJaryan.Value = ""
        '
        'txt_SexJaryanSC
        '
        Me.txt_SexJaryanSC.CheckExistValueInDb = False
        Me.txt_SexJaryanSC.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SexJaryanSC.CurrencyUnit = "ریال"
        Me.txt_SexJaryanSC.DefaultValue = ""
        Me.txt_SexJaryanSC.FillWithMaxInDb = False
        Me.txt_SexJaryanSC.IsRequired = False
        Me.txt_SexJaryanSC.Location = New System.Drawing.Point(76, 119)
        Me.txt_SexJaryanSC.MaxDecimalLength = 2
        Me.txt_SexJaryanSC.Name = "txt_SexJaryanSC"
        Me.txt_SexJaryanSC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SexJaryanSC.Size = New System.Drawing.Size(145, 25)
        Me.txt_SexJaryanSC.SpellControl = Nothing
        Me.txt_SexJaryanSC.TabIndex = 20
        Me.txt_SexJaryanSC.Tag = "OrderCode"
        Me.txt_SexJaryanSC.Title = Nothing
        Me.txt_SexJaryanSC.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SexJaryanSC.UseForData = True
        Me.txt_SexJaryanSC.ValidateCheckExistOnEdit = False
        Me.txt_SexJaryanSC.Value = ""
        '
        'txt_SexVoltage
        '
        Me.txt_SexVoltage.BackColor = System.Drawing.Color.Yellow
        Me.txt_SexVoltage.CheckExistValueInDb = False
        Me.txt_SexVoltage.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SexVoltage.CurrencyUnit = "ریال"
        Me.txt_SexVoltage.DefaultValue = ""
        Me.txt_SexVoltage.FillWithMaxInDb = False
        Me.txt_SexVoltage.IsRequired = False
        Me.txt_SexVoltage.Location = New System.Drawing.Point(487, 86)
        Me.txt_SexVoltage.MaxDecimalLength = 2
        Me.txt_SexVoltage.Name = "txt_SexVoltage"
        Me.txt_SexVoltage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SexVoltage.Size = New System.Drawing.Size(145, 25)
        Me.txt_SexVoltage.SpellControl = Nothing
        Me.txt_SexVoltage.TabIndex = 17
        Me.txt_SexVoltage.Tag = "OrderCode"
        Me.txt_SexVoltage.Title = Nothing
        Me.txt_SexVoltage.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SexVoltage.UseForData = True
        Me.txt_SexVoltage.ValidateCheckExistOnEdit = False
        Me.txt_SexVoltage.Value = ""
        '
        'txt_SexMaxJaryan
        '
        Me.txt_SexMaxJaryan.CheckExistValueInDb = False
        Me.txt_SexMaxJaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SexMaxJaryan.CurrencyUnit = "ریال"
        Me.txt_SexMaxJaryan.DefaultValue = ""
        Me.txt_SexMaxJaryan.FillWithMaxInDb = False
        Me.txt_SexMaxJaryan.IsRequired = False
        Me.txt_SexMaxJaryan.Location = New System.Drawing.Point(76, 55)
        Me.txt_SexMaxJaryan.MaxDecimalLength = 2
        Me.txt_SexMaxJaryan.Name = "txt_SexMaxJaryan"
        Me.txt_SexMaxJaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SexMaxJaryan.Size = New System.Drawing.Size(145, 25)
        Me.txt_SexMaxJaryan.SpellControl = Nothing
        Me.txt_SexMaxJaryan.TabIndex = 19
        Me.txt_SexMaxJaryan.Tag = "OrderCode"
        Me.txt_SexMaxJaryan.Title = Nothing
        Me.txt_SexMaxJaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SexMaxJaryan.UseForData = True
        Me.txt_SexMaxJaryan.ValidateCheckExistOnEdit = False
        Me.txt_SexMaxJaryan.Value = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(232, 91)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(106, 18)
        Me.Label30.TabIndex = 14
        Me.Label30.Text = "ولتاژ بهره برداری"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(643, 62)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(91, 18)
        Me.Label55.TabIndex = 12
        Me.Label55.Text = "نام سکسیونر"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(643, 123)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(78, 18)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "جریان نامی"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(232, 124)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(116, 18)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "جریان اتصال کوتاه"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(643, 91)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 18)
        Me.Label33.TabIndex = 16
        Me.Label33.Text = "ولتاژ نامی"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(232, 60)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(161, 18)
        Me.Label34.TabIndex = 15
        Me.Label34.Text = "حداکثر جریان بهره برداری"
        '
        'Tab_Breaker
        '
        Me.Tab_Breaker.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRMaxJaryan)
        Me.Tab_Breaker.Controls.Add(Me.chk_ALLBRName)
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRTurnoff)
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRBill)
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRMekanizm)
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRConnect)
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRJaryanN)
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRDisconnect)
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRVoltajN)
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRMaxVoltaj)
        Me.Tab_Breaker.Controls.Add(Me.chk_AllBRSC)
        Me.Tab_Breaker.Controls.Add(Me.Label35)
        Me.Tab_Breaker.Controls.Add(Me.txt_BRDisconnect)
        Me.Tab_Breaker.Controls.Add(Me.txt_BRMaxJaryan)
        Me.Tab_Breaker.Controls.Add(Me.txt_BrConnect)
        Me.Tab_Breaker.Controls.Add(Me.txt_BRMaxVoltaje)
        Me.Tab_Breaker.Controls.Add(Me.txt_BrBill)
        Me.Tab_Breaker.Controls.Add(Me.Label41)
        Me.Tab_Breaker.Controls.Add(Me.Label42)
        Me.Tab_Breaker.Controls.Add(Me.Label43)
        Me.Tab_Breaker.Controls.Add(Me.Label44)
        Me.Tab_Breaker.Controls.Add(Me.txt_BRJaryanN)
        Me.Tab_Breaker.Controls.Add(Me.txt_BRMekanism)
        Me.Tab_Breaker.Controls.Add(Me.txt_BRVotajN)
        Me.Tab_Breaker.Controls.Add(Me.txt_BrName)
        Me.Tab_Breaker.Controls.Add(Me.txt_BRTurnOff)
        Me.Tab_Breaker.Controls.Add(Me.txt_BRJaryanSC)
        Me.Tab_Breaker.Controls.Add(Me.Label36)
        Me.Tab_Breaker.Controls.Add(Me.Label37)
        Me.Tab_Breaker.Controls.Add(Me.Label38)
        Me.Tab_Breaker.Controls.Add(Me.Label56)
        Me.Tab_Breaker.Controls.Add(Me.Label39)
        Me.Tab_Breaker.Controls.Add(Me.Label40)
        Me.Tab_Breaker.Location = New System.Drawing.Point(4, 27)
        Me.Tab_Breaker.Name = "Tab_Breaker"
        Me.Tab_Breaker.Size = New System.Drawing.Size(749, 199)
        Me.Tab_Breaker.TabIndex = 5
        Me.Tab_Breaker.Text = "بریکر"
        Me.Tab_Breaker.UseVisualStyleBackColor = True
        '
        'chk_AllBRMaxJaryan
        '
        Me.chk_AllBRMaxJaryan.AutoSize = True
        Me.chk_AllBRMaxJaryan.Location = New System.Drawing.Point(52, 15)
        Me.chk_AllBRMaxJaryan.Name = "chk_AllBRMaxJaryan"
        Me.chk_AllBRMaxJaryan.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRMaxJaryan.TabIndex = 215
        Me.chk_AllBRMaxJaryan.Text = "همه"
        Me.chk_AllBRMaxJaryan.UseVisualStyleBackColor = True
        '
        'chk_ALLBRName
        '
        Me.chk_ALLBRName.AutoSize = True
        Me.chk_ALLBRName.Location = New System.Drawing.Point(378, 16)
        Me.chk_ALLBRName.Name = "chk_ALLBRName"
        Me.chk_ALLBRName.Size = New System.Drawing.Size(55, 22)
        Me.chk_ALLBRName.TabIndex = 215
        Me.chk_ALLBRName.Text = "همه"
        Me.chk_ALLBRName.UseVisualStyleBackColor = True
        '
        'chk_AllBRTurnoff
        '
        Me.chk_AllBRTurnoff.AutoSize = True
        Me.chk_AllBRTurnoff.Location = New System.Drawing.Point(378, 43)
        Me.chk_AllBRTurnoff.Name = "chk_AllBRTurnoff"
        Me.chk_AllBRTurnoff.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRTurnoff.TabIndex = 215
        Me.chk_AllBRTurnoff.Text = "همه"
        Me.chk_AllBRTurnoff.UseVisualStyleBackColor = True
        '
        'chk_AllBRBill
        '
        Me.chk_AllBRBill.AutoSize = True
        Me.chk_AllBRBill.Location = New System.Drawing.Point(52, 139)
        Me.chk_AllBRBill.Name = "chk_AllBRBill"
        Me.chk_AllBRBill.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRBill.TabIndex = 216
        Me.chk_AllBRBill.Text = "همه"
        Me.chk_AllBRBill.UseVisualStyleBackColor = True
        '
        'chk_AllBRMekanizm
        '
        Me.chk_AllBRMekanizm.AutoSize = True
        Me.chk_AllBRMekanizm.Location = New System.Drawing.Point(378, 167)
        Me.chk_AllBRMekanizm.Name = "chk_AllBRMekanizm"
        Me.chk_AllBRMekanizm.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRMekanizm.TabIndex = 216
        Me.chk_AllBRMekanizm.Text = "همه"
        Me.chk_AllBRMekanizm.UseVisualStyleBackColor = True
        '
        'chk_AllBRConnect
        '
        Me.chk_AllBRConnect.AutoSize = True
        Me.chk_AllBRConnect.Location = New System.Drawing.Point(52, 108)
        Me.chk_AllBRConnect.Name = "chk_AllBRConnect"
        Me.chk_AllBRConnect.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRConnect.TabIndex = 214
        Me.chk_AllBRConnect.Text = "همه"
        Me.chk_AllBRConnect.UseVisualStyleBackColor = True
        '
        'chk_AllBRJaryanN
        '
        Me.chk_AllBRJaryanN.AutoSize = True
        Me.chk_AllBRJaryanN.Location = New System.Drawing.Point(378, 136)
        Me.chk_AllBRJaryanN.Name = "chk_AllBRJaryanN"
        Me.chk_AllBRJaryanN.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRJaryanN.TabIndex = 214
        Me.chk_AllBRJaryanN.Text = "همه"
        Me.chk_AllBRJaryanN.UseVisualStyleBackColor = True
        '
        'chk_AllBRDisconnect
        '
        Me.chk_AllBRDisconnect.AutoSize = True
        Me.chk_AllBRDisconnect.Location = New System.Drawing.Point(52, 77)
        Me.chk_AllBRDisconnect.Name = "chk_AllBRDisconnect"
        Me.chk_AllBRDisconnect.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRDisconnect.TabIndex = 212
        Me.chk_AllBRDisconnect.Text = "همه"
        Me.chk_AllBRDisconnect.UseVisualStyleBackColor = True
        '
        'chk_AllBRVoltajN
        '
        Me.chk_AllBRVoltajN.AutoSize = True
        Me.chk_AllBRVoltajN.Location = New System.Drawing.Point(378, 105)
        Me.chk_AllBRVoltajN.Name = "chk_AllBRVoltajN"
        Me.chk_AllBRVoltajN.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRVoltajN.TabIndex = 212
        Me.chk_AllBRVoltajN.Text = "همه"
        Me.chk_AllBRVoltajN.UseVisualStyleBackColor = True
        '
        'chk_AllBRMaxVoltaj
        '
        Me.chk_AllBRMaxVoltaj.AutoSize = True
        Me.chk_AllBRMaxVoltaj.Location = New System.Drawing.Point(52, 49)
        Me.chk_AllBRMaxVoltaj.Name = "chk_AllBRMaxVoltaj"
        Me.chk_AllBRMaxVoltaj.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRMaxVoltaj.TabIndex = 213
        Me.chk_AllBRMaxVoltaj.Text = "همه"
        Me.chk_AllBRMaxVoltaj.UseVisualStyleBackColor = True
        '
        'chk_AllBRSC
        '
        Me.chk_AllBRSC.AutoSize = True
        Me.chk_AllBRSC.Location = New System.Drawing.Point(378, 77)
        Me.chk_AllBRSC.Name = "chk_AllBRSC"
        Me.chk_AllBRSC.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllBRSC.TabIndex = 213
        Me.chk_AllBRSC.Text = "همه"
        Me.chk_AllBRSC.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(269, 143)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(21, 18)
        Me.Label35.TabIndex = 28
        Me.Label35.Text = "Bil"
        '
        'txt_BRDisconnect
        '
        Me.txt_BRDisconnect.CheckExistValueInDb = False
        Me.txt_BRDisconnect.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BRDisconnect.CurrencyUnit = "ریال"
        Me.txt_BRDisconnect.DefaultValue = ""
        Me.txt_BRDisconnect.FillWithMaxInDb = False
        Me.txt_BRDisconnect.IsRequired = False
        Me.txt_BRDisconnect.Location = New System.Drawing.Point(113, 76)
        Me.txt_BRDisconnect.MaxDecimalLength = 2
        Me.txt_BRDisconnect.Name = "txt_BRDisconnect"
        Me.txt_BRDisconnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BRDisconnect.Size = New System.Drawing.Size(145, 25)
        Me.txt_BRDisconnect.SpellControl = Nothing
        Me.txt_BRDisconnect.TabIndex = 32
        Me.txt_BRDisconnect.Tag = "OrderCode"
        Me.txt_BRDisconnect.Title = Nothing
        Me.txt_BRDisconnect.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BRDisconnect.UseForData = True
        Me.txt_BRDisconnect.ValidateCheckExistOnEdit = False
        Me.txt_BRDisconnect.Value = ""
        '
        'txt_BRMaxJaryan
        '
        Me.txt_BRMaxJaryan.CheckExistValueInDb = False
        Me.txt_BRMaxJaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BRMaxJaryan.CurrencyUnit = "ریال"
        Me.txt_BRMaxJaryan.DefaultValue = ""
        Me.txt_BRMaxJaryan.FillWithMaxInDb = False
        Me.txt_BRMaxJaryan.IsRequired = False
        Me.txt_BRMaxJaryan.Location = New System.Drawing.Point(113, 15)
        Me.txt_BRMaxJaryan.MaxDecimalLength = 2
        Me.txt_BRMaxJaryan.Name = "txt_BRMaxJaryan"
        Me.txt_BRMaxJaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BRMaxJaryan.Size = New System.Drawing.Size(145, 25)
        Me.txt_BRMaxJaryan.SpellControl = Nothing
        Me.txt_BRMaxJaryan.TabIndex = 30
        Me.txt_BRMaxJaryan.Tag = "OrderCode"
        Me.txt_BRMaxJaryan.Title = Nothing
        Me.txt_BRMaxJaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BRMaxJaryan.UseForData = True
        Me.txt_BRMaxJaryan.ValidateCheckExistOnEdit = False
        Me.txt_BRMaxJaryan.Value = ""
        '
        'txt_BrConnect
        '
        Me.txt_BrConnect.CheckExistValueInDb = False
        Me.txt_BrConnect.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BrConnect.CurrencyUnit = "ریال"
        Me.txt_BrConnect.DefaultValue = ""
        Me.txt_BrConnect.FillWithMaxInDb = False
        Me.txt_BrConnect.IsRequired = False
        Me.txt_BrConnect.Location = New System.Drawing.Point(113, 109)
        Me.txt_BrConnect.MaxDecimalLength = 2
        Me.txt_BrConnect.Name = "txt_BrConnect"
        Me.txt_BrConnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BrConnect.Size = New System.Drawing.Size(145, 25)
        Me.txt_BrConnect.SpellControl = Nothing
        Me.txt_BrConnect.TabIndex = 31
        Me.txt_BrConnect.Tag = "OrderCode"
        Me.txt_BrConnect.Title = Nothing
        Me.txt_BrConnect.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BrConnect.UseForData = True
        Me.txt_BrConnect.ValidateCheckExistOnEdit = False
        Me.txt_BrConnect.Value = ""
        '
        'txt_BRMaxVoltaje
        '
        Me.txt_BRMaxVoltaje.CheckExistValueInDb = False
        Me.txt_BRMaxVoltaje.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BRMaxVoltaje.CurrencyUnit = "ریال"
        Me.txt_BRMaxVoltaje.DefaultValue = ""
        Me.txt_BRMaxVoltaje.FillWithMaxInDb = False
        Me.txt_BRMaxVoltaje.IsRequired = False
        Me.txt_BRMaxVoltaje.Location = New System.Drawing.Point(113, 45)
        Me.txt_BRMaxVoltaje.MaxDecimalLength = 2
        Me.txt_BRMaxVoltaje.Name = "txt_BRMaxVoltaje"
        Me.txt_BRMaxVoltaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BRMaxVoltaje.Size = New System.Drawing.Size(145, 25)
        Me.txt_BRMaxVoltaje.SpellControl = Nothing
        Me.txt_BRMaxVoltaje.TabIndex = 29
        Me.txt_BRMaxVoltaje.Tag = "OrderCode"
        Me.txt_BRMaxVoltaje.Title = Nothing
        Me.txt_BRMaxVoltaje.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BRMaxVoltaje.UseForData = True
        Me.txt_BRMaxVoltaje.ValidateCheckExistOnEdit = False
        Me.txt_BRMaxVoltaje.Value = ""
        '
        'txt_BrBill
        '
        Me.txt_BrBill.CheckExistValueInDb = False
        Me.txt_BrBill.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BrBill.CurrencyUnit = "ریال"
        Me.txt_BrBill.DefaultValue = ""
        Me.txt_BrBill.FillWithMaxInDb = False
        Me.txt_BrBill.IsRequired = False
        Me.txt_BrBill.Location = New System.Drawing.Point(112, 140)
        Me.txt_BrBill.MaxDecimalLength = 2
        Me.txt_BrBill.Name = "txt_BrBill"
        Me.txt_BrBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BrBill.Size = New System.Drawing.Size(145, 25)
        Me.txt_BrBill.SpellControl = Nothing
        Me.txt_BrBill.TabIndex = 33
        Me.txt_BrBill.Tag = "SerialNumber"
        Me.txt_BrBill.Title = Nothing
        Me.txt_BrBill.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BrBill.UseForData = True
        Me.txt_BrBill.ValidateCheckExistOnEdit = False
        Me.txt_BrBill.Value = ""
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(269, 81)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(66, 18)
        Me.Label41.TabIndex = 25
        Me.Label41.Text = "زمان قطع"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(269, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(87, 18)
        Me.Label42.TabIndex = 24
        Me.Label42.Text = "حداکثر جریان"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(259, 114)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(69, 18)
        Me.Label43.TabIndex = 27
        Me.Label43.Text = "زمان وصل"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(260, 50)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(77, 18)
        Me.Label44.TabIndex = 26
        Me.Label44.Text = "حداکثر ولتاژ"
        '
        'txt_BRJaryanN
        '
        Me.txt_BRJaryanN.CheckExistValueInDb = False
        Me.txt_BRJaryanN.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BRJaryanN.CurrencyUnit = "ریال"
        Me.txt_BRJaryanN.DefaultValue = ""
        Me.txt_BRJaryanN.FillWithMaxInDb = False
        Me.txt_BRJaryanN.IsRequired = False
        Me.txt_BRJaryanN.Location = New System.Drawing.Point(439, 134)
        Me.txt_BRJaryanN.MaxDecimalLength = 2
        Me.txt_BRJaryanN.Name = "txt_BRJaryanN"
        Me.txt_BRJaryanN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BRJaryanN.Size = New System.Drawing.Size(145, 25)
        Me.txt_BRJaryanN.SpellControl = Nothing
        Me.txt_BRJaryanN.TabIndex = 23
        Me.txt_BRJaryanN.Tag = "OrderCode"
        Me.txt_BRJaryanN.Title = Nothing
        Me.txt_BRJaryanN.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BRJaryanN.UseForData = True
        Me.txt_BRJaryanN.ValidateCheckExistOnEdit = False
        Me.txt_BRJaryanN.Value = ""
        '
        'txt_BRMekanism
        '
        Me.txt_BRMekanism.CheckExistValueInDb = False
        Me.txt_BRMekanism.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BRMekanism.CurrencyUnit = "ریال"
        Me.txt_BRMekanism.DefaultValue = ""
        Me.txt_BRMekanism.FillWithMaxInDb = False
        Me.txt_BRMekanism.IsRequired = False
        Me.txt_BRMekanism.Location = New System.Drawing.Point(439, 165)
        Me.txt_BRMekanism.MaxDecimalLength = 2
        Me.txt_BRMekanism.Name = "txt_BRMekanism"
        Me.txt_BRMekanism.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BRMekanism.Size = New System.Drawing.Size(145, 25)
        Me.txt_BRMekanism.SpellControl = Nothing
        Me.txt_BRMekanism.TabIndex = 19
        Me.txt_BRMekanism.Tag = "OrderCode"
        Me.txt_BRMekanism.Title = Nothing
        Me.txt_BRMekanism.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BRMekanism.UseForData = True
        Me.txt_BRMekanism.ValidateCheckExistOnEdit = False
        Me.txt_BRMekanism.Value = ""
        '
        'txt_BRVotajN
        '
        Me.txt_BRVotajN.CheckExistValueInDb = False
        Me.txt_BRVotajN.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BRVotajN.CurrencyUnit = "ریال"
        Me.txt_BRVotajN.DefaultValue = ""
        Me.txt_BRVotajN.FillWithMaxInDb = False
        Me.txt_BRVotajN.IsRequired = False
        Me.txt_BRVotajN.Location = New System.Drawing.Point(439, 103)
        Me.txt_BRVotajN.MaxDecimalLength = 2
        Me.txt_BRVotajN.Name = "txt_BRVotajN"
        Me.txt_BRVotajN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BRVotajN.Size = New System.Drawing.Size(145, 25)
        Me.txt_BRVotajN.SpellControl = Nothing
        Me.txt_BRVotajN.TabIndex = 22
        Me.txt_BRVotajN.Tag = "OrderCode"
        Me.txt_BRVotajN.Title = Nothing
        Me.txt_BRVotajN.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BRVotajN.UseForData = True
        Me.txt_BRVotajN.ValidateCheckExistOnEdit = False
        Me.txt_BRVotajN.Value = ""
        '
        'txt_BrName
        '
        Me.txt_BrName.BackColor = System.Drawing.SystemColors.Window
        Me.txt_BrName.CheckExistValueInDb = False
        Me.txt_BrName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BrName.CurrencyUnit = "ریال"
        Me.txt_BrName.DefaultValue = ""
        Me.txt_BrName.FillWithMaxInDb = False
        Me.txt_BrName.IsRequired = False
        Me.txt_BrName.Location = New System.Drawing.Point(439, 14)
        Me.txt_BrName.MaxDecimalLength = 2
        Me.txt_BrName.Name = "txt_BrName"
        Me.txt_BrName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BrName.Size = New System.Drawing.Size(145, 25)
        Me.txt_BrName.SpellControl = Nothing
        Me.txt_BrName.TabIndex = 18
        Me.txt_BrName.Tag = "OrderCode"
        Me.txt_BrName.Title = Nothing
        Me.txt_BrName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BrName.UseForData = True
        Me.txt_BrName.ValidateCheckExistOnEdit = False
        Me.txt_BrName.Value = ""
        '
        'txt_BRTurnOff
        '
        Me.txt_BRTurnOff.BackColor = System.Drawing.Color.White
        Me.txt_BRTurnOff.CheckExistValueInDb = False
        Me.txt_BRTurnOff.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BRTurnOff.CurrencyUnit = "ریال"
        Me.txt_BRTurnOff.DefaultValue = ""
        Me.txt_BRTurnOff.FillWithMaxInDb = False
        Me.txt_BRTurnOff.IsRequired = False
        Me.txt_BRTurnOff.Location = New System.Drawing.Point(439, 41)
        Me.txt_BRTurnOff.MaxDecimalLength = 2
        Me.txt_BRTurnOff.Name = "txt_BRTurnOff"
        Me.txt_BRTurnOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BRTurnOff.Size = New System.Drawing.Size(145, 25)
        Me.txt_BRTurnOff.SpellControl = Nothing
        Me.txt_BRTurnOff.TabIndex = 18
        Me.txt_BRTurnOff.Tag = "OrderCode"
        Me.txt_BRTurnOff.Title = Nothing
        Me.txt_BRTurnOff.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BRTurnOff.UseForData = True
        Me.txt_BRTurnOff.ValidateCheckExistOnEdit = False
        Me.txt_BRTurnOff.Value = ""
        '
        'txt_BRJaryanSC
        '
        Me.txt_BRJaryanSC.CheckExistValueInDb = False
        Me.txt_BRJaryanSC.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BRJaryanSC.CurrencyUnit = "ریال"
        Me.txt_BRJaryanSC.DefaultValue = ""
        Me.txt_BRJaryanSC.FillWithMaxInDb = False
        Me.txt_BRJaryanSC.IsRequired = False
        Me.txt_BRJaryanSC.Location = New System.Drawing.Point(439, 72)
        Me.txt_BRJaryanSC.MaxDecimalLength = 2
        Me.txt_BRJaryanSC.Name = "txt_BRJaryanSC"
        Me.txt_BRJaryanSC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BRJaryanSC.Size = New System.Drawing.Size(145, 25)
        Me.txt_BRJaryanSC.SpellControl = Nothing
        Me.txt_BRJaryanSC.TabIndex = 20
        Me.txt_BRJaryanSC.Tag = "OrderCode"
        Me.txt_BRJaryanSC.Title = Nothing
        Me.txt_BRJaryanSC.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BRJaryanSC.UseForData = True
        Me.txt_BRJaryanSC.ValidateCheckExistOnEdit = False
        Me.txt_BRJaryanSC.Value = ""
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(595, 139)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(78, 18)
        Me.Label36.TabIndex = 14
        Me.Label36.Text = "جریان نامی"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(595, 170)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(77, 18)
        Me.Label37.TabIndex = 13
        Me.Label37.Text = "نوع مکانیزم"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(595, 108)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(68, 18)
        Me.Label38.TabIndex = 12
        Me.Label38.Text = "ولتاژ نامی"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(595, 19)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(58, 18)
        Me.Label56.TabIndex = 16
        Me.Label56.Text = "نام بریکر"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(595, 46)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(148, 18)
        Me.Label39.TabIndex = 16
        Me.Label39.Text = "سیستم خاموش کننده"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(595, 77)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(116, 18)
        Me.Label40.TabIndex = 15
        Me.Label40.Text = "جریان اتصال کوتاه"
        '
        'Tab_TV
        '
        Me.Tab_TV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Tab_TV.Controls.Add(Me.GroupBox1)
        Me.Tab_TV.Controls.Add(Me.chk_AllTVJMaxVoltaj)
        Me.Tab_TV.Controls.Add(Me.chk_ALLTrCoreNumber)
        Me.Tab_TV.Controls.Add(Me.chk_AllTVJBill)
        Me.Tab_TV.Controls.Add(Me.chk_AllTVJClass)
        Me.Tab_TV.Controls.Add(Me.chk_AllTrName)
        Me.Tab_TV.Controls.Add(Me.chk_AllTVJCoreConvert)
        Me.Tab_TV.Controls.Add(Me.chk_AllTVJMaxJaryan)
        Me.Tab_TV.Controls.Add(Me.txt_TVJCoreClass)
        Me.Tab_TV.Controls.Add(Me.txt_TVJMaxJaryan)
        Me.Tab_TV.Controls.Add(Me.txt_TrCoreNumber)
        Me.Tab_TV.Controls.Add(Me.txt_TVJbill)
        Me.Tab_TV.Controls.Add(Me.txt_TrName)
        Me.Tab_TV.Controls.Add(Me.txt_TVJCoreConvert)
        Me.Tab_TV.Controls.Add(Me.txt_TVJMaxVoltage)
        Me.Tab_TV.Controls.Add(Me.Label45)
        Me.Tab_TV.Controls.Add(Me.Label46)
        Me.Tab_TV.Controls.Add(Me.Label58)
        Me.Tab_TV.Controls.Add(Me.Label47)
        Me.Tab_TV.Controls.Add(Me.Label57)
        Me.Tab_TV.Controls.Add(Me.Label48)
        Me.Tab_TV.Controls.Add(Me.Label49)
        Me.Tab_TV.Location = New System.Drawing.Point(4, 27)
        Me.Tab_TV.Name = "Tab_TV"
        Me.Tab_TV.Size = New System.Drawing.Size(749, 199)
        Me.Tab_TV.TabIndex = 6
        Me.Tab_TV.Text = "ترانس ولتاژ و جریان"
        Me.Tab_TV.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rb_TV)
        Me.GroupBox1.Controls.Add(Me.Rb_Both)
        Me.GroupBox1.Controls.Add(Me.RB_TJ)
        Me.GroupBox1.Location = New System.Drawing.Point(392, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 50)
        Me.GroupBox1.TabIndex = 222
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "نوع ترانس"
        '
        'Rb_TV
        '
        Me.Rb_TV.AutoSize = True
        Me.Rb_TV.Location = New System.Drawing.Point(101, 21)
        Me.Rb_TV.Name = "Rb_TV"
        Me.Rb_TV.Size = New System.Drawing.Size(92, 22)
        Me.Rb_TV.TabIndex = 225
        Me.Rb_TV.Text = "ترانس ولتاژ"
        Me.Rb_TV.UseVisualStyleBackColor = True
        '
        'Rb_Both
        '
        Me.Rb_Both.AutoSize = True
        Me.Rb_Both.Location = New System.Drawing.Point(31, 21)
        Me.Rb_Both.Name = "Rb_Both"
        Me.Rb_Both.Size = New System.Drawing.Size(55, 22)
        Me.Rb_Both.TabIndex = 224
        Me.Rb_Both.Text = "هردو"
        Me.Rb_Both.UseVisualStyleBackColor = True
        '
        'RB_TJ
        '
        Me.RB_TJ.AutoSize = True
        Me.RB_TJ.Checked = True
        Me.RB_TJ.Location = New System.Drawing.Point(206, 21)
        Me.RB_TJ.Name = "RB_TJ"
        Me.RB_TJ.Size = New System.Drawing.Size(102, 22)
        Me.RB_TJ.TabIndex = 223
        Me.RB_TJ.TabStop = True
        Me.RB_TJ.Text = "ترانس جریان"
        Me.RB_TJ.UseVisualStyleBackColor = True
        '
        'chk_AllTVJMaxVoltaj
        '
        Me.chk_AllTVJMaxVoltaj.AutoSize = True
        Me.chk_AllTVJMaxVoltaj.Location = New System.Drawing.Point(61, 43)
        Me.chk_AllTVJMaxVoltaj.Name = "chk_AllTVJMaxVoltaj"
        Me.chk_AllTVJMaxVoltaj.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTVJMaxVoltaj.TabIndex = 220
        Me.chk_AllTVJMaxVoltaj.Text = "همه"
        Me.chk_AllTVJMaxVoltaj.UseVisualStyleBackColor = True
        '
        'chk_ALLTrCoreNumber
        '
        Me.chk_ALLTrCoreNumber.AutoSize = True
        Me.chk_ALLTrCoreNumber.Location = New System.Drawing.Point(61, 138)
        Me.chk_ALLTrCoreNumber.Name = "chk_ALLTrCoreNumber"
        Me.chk_ALLTrCoreNumber.Size = New System.Drawing.Size(55, 22)
        Me.chk_ALLTrCoreNumber.TabIndex = 221
        Me.chk_ALLTrCoreNumber.Text = "همه"
        Me.chk_ALLTrCoreNumber.UseVisualStyleBackColor = True
        '
        'chk_AllTVJBill
        '
        Me.chk_AllTVJBill.AutoSize = True
        Me.chk_AllTVJBill.Location = New System.Drawing.Point(61, 104)
        Me.chk_AllTVJBill.Name = "chk_AllTVJBill"
        Me.chk_AllTVJBill.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTVJBill.TabIndex = 221
        Me.chk_AllTVJBill.Text = "همه"
        Me.chk_AllTVJBill.UseVisualStyleBackColor = True
        '
        'chk_AllTVJClass
        '
        Me.chk_AllTVJClass.AutoSize = True
        Me.chk_AllTVJClass.Location = New System.Drawing.Point(381, 143)
        Me.chk_AllTVJClass.Name = "chk_AllTVJClass"
        Me.chk_AllTVJClass.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTVJClass.TabIndex = 219
        Me.chk_AllTVJClass.Text = "همه"
        Me.chk_AllTVJClass.UseVisualStyleBackColor = True
        '
        'chk_AllTrName
        '
        Me.chk_AllTrName.AutoSize = True
        Me.chk_AllTrName.Location = New System.Drawing.Point(381, 79)
        Me.chk_AllTrName.Name = "chk_AllTrName"
        Me.chk_AllTrName.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTrName.TabIndex = 217
        Me.chk_AllTrName.Text = "همه"
        Me.chk_AllTrName.UseVisualStyleBackColor = True
        '
        'chk_AllTVJCoreConvert
        '
        Me.chk_AllTVJCoreConvert.AutoSize = True
        Me.chk_AllTVJCoreConvert.Location = New System.Drawing.Point(381, 112)
        Me.chk_AllTVJCoreConvert.Name = "chk_AllTVJCoreConvert"
        Me.chk_AllTVJCoreConvert.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTVJCoreConvert.TabIndex = 217
        Me.chk_AllTVJCoreConvert.Text = "همه"
        Me.chk_AllTVJCoreConvert.UseVisualStyleBackColor = True
        '
        'chk_AllTVJMaxJaryan
        '
        Me.chk_AllTVJMaxJaryan.AutoSize = True
        Me.chk_AllTVJMaxJaryan.Location = New System.Drawing.Point(61, 77)
        Me.chk_AllTVJMaxJaryan.Name = "chk_AllTVJMaxJaryan"
        Me.chk_AllTVJMaxJaryan.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllTVJMaxJaryan.TabIndex = 218
        Me.chk_AllTVJMaxJaryan.Text = "همه"
        Me.chk_AllTVJMaxJaryan.UseVisualStyleBackColor = True
        '
        'txt_TVJCoreClass
        '
        Me.txt_TVJCoreClass.CheckExistValueInDb = False
        Me.txt_TVJCoreClass.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TVJCoreClass.CurrencyUnit = "ریال"
        Me.txt_TVJCoreClass.DefaultValue = ""
        Me.txt_TVJCoreClass.FillWithMaxInDb = False
        Me.txt_TVJCoreClass.IsRequired = False
        Me.txt_TVJCoreClass.Location = New System.Drawing.Point(442, 143)
        Me.txt_TVJCoreClass.MaxDecimalLength = 2
        Me.txt_TVJCoreClass.Name = "txt_TVJCoreClass"
        Me.txt_TVJCoreClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TVJCoreClass.Size = New System.Drawing.Size(145, 25)
        Me.txt_TVJCoreClass.SpellControl = Nothing
        Me.txt_TVJCoreClass.TabIndex = 21
        Me.txt_TVJCoreClass.Tag = "OrderCode"
        Me.txt_TVJCoreClass.Title = Nothing
        Me.txt_TVJCoreClass.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TVJCoreClass.UseForData = True
        Me.txt_TVJCoreClass.ValidateCheckExistOnEdit = False
        Me.txt_TVJCoreClass.Value = ""
        '
        'txt_TVJMaxJaryan
        '
        Me.txt_TVJMaxJaryan.CheckExistValueInDb = False
        Me.txt_TVJMaxJaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TVJMaxJaryan.CurrencyUnit = "ریال"
        Me.txt_TVJMaxJaryan.DefaultValue = ""
        Me.txt_TVJMaxJaryan.FillWithMaxInDb = False
        Me.txt_TVJMaxJaryan.IsRequired = False
        Me.txt_TVJMaxJaryan.Location = New System.Drawing.Point(122, 72)
        Me.txt_TVJMaxJaryan.MaxDecimalLength = 2
        Me.txt_TVJMaxJaryan.Name = "txt_TVJMaxJaryan"
        Me.txt_TVJMaxJaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TVJMaxJaryan.Size = New System.Drawing.Size(145, 25)
        Me.txt_TVJMaxJaryan.SpellControl = Nothing
        Me.txt_TVJMaxJaryan.TabIndex = 19
        Me.txt_TVJMaxJaryan.Tag = "OrderCode"
        Me.txt_TVJMaxJaryan.Title = Nothing
        Me.txt_TVJMaxJaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TVJMaxJaryan.UseForData = True
        Me.txt_TVJMaxJaryan.ValidateCheckExistOnEdit = False
        Me.txt_TVJMaxJaryan.Value = ""
        '
        'txt_TrCoreNumber
        '
        Me.txt_TrCoreNumber.CheckExistValueInDb = False
        Me.txt_TrCoreNumber.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TrCoreNumber.CurrencyUnit = "ریال"
        Me.txt_TrCoreNumber.DefaultValue = ""
        Me.txt_TrCoreNumber.FillWithMaxInDb = False
        Me.txt_TrCoreNumber.IsRequired = False
        Me.txt_TrCoreNumber.Location = New System.Drawing.Point(122, 138)
        Me.txt_TrCoreNumber.MaxDecimalLength = 2
        Me.txt_TrCoreNumber.Name = "txt_TrCoreNumber"
        Me.txt_TrCoreNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TrCoreNumber.Size = New System.Drawing.Size(145, 25)
        Me.txt_TrCoreNumber.SpellControl = Nothing
        Me.txt_TrCoreNumber.TabIndex = 22
        Me.txt_TrCoreNumber.Tag = "OrderCode"
        Me.txt_TrCoreNumber.Title = Nothing
        Me.txt_TrCoreNumber.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TrCoreNumber.UseForData = True
        Me.txt_TrCoreNumber.ValidateCheckExistOnEdit = False
        Me.txt_TrCoreNumber.Value = ""
        '
        'txt_TVJbill
        '
        Me.txt_TVJbill.CheckExistValueInDb = False
        Me.txt_TVJbill.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TVJbill.CurrencyUnit = "ریال"
        Me.txt_TVJbill.DefaultValue = ""
        Me.txt_TVJbill.FillWithMaxInDb = False
        Me.txt_TVJbill.IsRequired = False
        Me.txt_TVJbill.Location = New System.Drawing.Point(122, 104)
        Me.txt_TVJbill.MaxDecimalLength = 2
        Me.txt_TVJbill.Name = "txt_TVJbill"
        Me.txt_TVJbill.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TVJbill.Size = New System.Drawing.Size(145, 25)
        Me.txt_TVJbill.SpellControl = Nothing
        Me.txt_TVJbill.TabIndex = 22
        Me.txt_TVJbill.Tag = "OrderCode"
        Me.txt_TVJbill.Title = Nothing
        Me.txt_TVJbill.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TVJbill.UseForData = True
        Me.txt_TVJbill.ValidateCheckExistOnEdit = False
        Me.txt_TVJbill.Value = ""
        '
        'txt_TrName
        '
        Me.txt_TrName.CheckExistValueInDb = False
        Me.txt_TrName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TrName.CurrencyUnit = "ریال"
        Me.txt_TrName.DefaultValue = ""
        Me.txt_TrName.FillWithMaxInDb = False
        Me.txt_TrName.IsRequired = False
        Me.txt_TrName.Location = New System.Drawing.Point(442, 79)
        Me.txt_TrName.MaxDecimalLength = 2
        Me.txt_TrName.Name = "txt_TrName"
        Me.txt_TrName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TrName.Size = New System.Drawing.Size(145, 25)
        Me.txt_TrName.SpellControl = Nothing
        Me.txt_TrName.TabIndex = 20
        Me.txt_TrName.Tag = "OrderCode"
        Me.txt_TrName.Title = Nothing
        Me.txt_TrName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TrName.UseForData = True
        Me.txt_TrName.ValidateCheckExistOnEdit = False
        Me.txt_TrName.Value = ""
        '
        'txt_TVJCoreConvert
        '
        Me.txt_TVJCoreConvert.CheckExistValueInDb = False
        Me.txt_TVJCoreConvert.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TVJCoreConvert.CurrencyUnit = "ریال"
        Me.txt_TVJCoreConvert.DefaultValue = ""
        Me.txt_TVJCoreConvert.FillWithMaxInDb = False
        Me.txt_TVJCoreConvert.IsRequired = False
        Me.txt_TVJCoreConvert.Location = New System.Drawing.Point(442, 112)
        Me.txt_TVJCoreConvert.MaxDecimalLength = 2
        Me.txt_TVJCoreConvert.Name = "txt_TVJCoreConvert"
        Me.txt_TVJCoreConvert.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TVJCoreConvert.Size = New System.Drawing.Size(145, 25)
        Me.txt_TVJCoreConvert.SpellControl = Nothing
        Me.txt_TVJCoreConvert.TabIndex = 20
        Me.txt_TVJCoreConvert.Tag = "OrderCode"
        Me.txt_TVJCoreConvert.Title = Nothing
        Me.txt_TVJCoreConvert.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TVJCoreConvert.UseForData = True
        Me.txt_TVJCoreConvert.ValidateCheckExistOnEdit = False
        Me.txt_TVJCoreConvert.Value = ""
        '
        'txt_TVJMaxVoltage
        '
        Me.txt_TVJMaxVoltage.BackColor = System.Drawing.SystemColors.Window
        Me.txt_TVJMaxVoltage.CheckExistValueInDb = False
        Me.txt_TVJMaxVoltage.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TVJMaxVoltage.CurrencyUnit = "ریال"
        Me.txt_TVJMaxVoltage.DefaultValue = ""
        Me.txt_TVJMaxVoltage.FillWithMaxInDb = False
        Me.txt_TVJMaxVoltage.IsRequired = False
        Me.txt_TVJMaxVoltage.Location = New System.Drawing.Point(122, 41)
        Me.txt_TVJMaxVoltage.MaxDecimalLength = 2
        Me.txt_TVJMaxVoltage.Name = "txt_TVJMaxVoltage"
        Me.txt_TVJMaxVoltage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TVJMaxVoltage.Size = New System.Drawing.Size(145, 25)
        Me.txt_TVJMaxVoltage.SpellControl = Nothing
        Me.txt_TVJMaxVoltage.TabIndex = 18
        Me.txt_TVJMaxVoltage.Tag = "OrderCode"
        Me.txt_TVJMaxVoltage.Title = Nothing
        Me.txt_TVJMaxVoltage.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TVJMaxVoltage.UseForData = True
        Me.txt_TVJMaxVoltage.ValidateCheckExistOnEdit = False
        Me.txt_TVJMaxVoltage.Value = ""
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(592, 147)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(121, 18)
        Me.Label45.TabIndex = 14
        Me.Label45.Text = "کلاس دقت هسته"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(278, 77)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(87, 18)
        Me.Label46.TabIndex = 13
        Me.Label46.Text = "حداکثر جریان"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(278, 143)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(76, 18)
        Me.Label58.TabIndex = 15
        Me.Label58.Text = "تداد هسته"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(278, 109)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(23, 18)
        Me.Label47.TabIndex = 15
        Me.Label47.Text = "Bill"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(598, 84)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(67, 18)
        Me.Label57.TabIndex = 17
        Me.Label57.Text = "نام ترانس"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(598, 117)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(129, 18)
        Me.Label48.TabIndex = 17
        Me.Label48.Text = "نسبت تبدیل هسته"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(278, 46)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(77, 18)
        Me.Label49.TabIndex = 16
        Me.Label49.Text = "حداکثر ولتاژ"
        '
        'Tab_Cable
        '
        Me.Tab_Cable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Tab_Cable.Controls.Add(Me.chk_AllCSatheVoltaj)
        Me.Tab_Cable.Controls.Add(Me.chk_AllCMaghta)
        Me.Tab_Cable.Controls.Add(Me.chk_AllCAbleNAme)
        Me.Tab_Cable.Controls.Add(Me.chk_AllCJaryan)
        Me.Tab_Cable.Controls.Add(Me.txt_CVoltaj)
        Me.Tab_Cable.Controls.Add(Me.txt_CableName)
        Me.Tab_Cable.Controls.Add(Me.txt_CValidJaryan)
        Me.Tab_Cable.Controls.Add(Me.txt_CMaghta)
        Me.Tab_Cable.Controls.Add(Me.Label50)
        Me.Tab_Cable.Controls.Add(Me.Label59)
        Me.Tab_Cable.Controls.Add(Me.Label51)
        Me.Tab_Cable.Controls.Add(Me.Label52)
        Me.Tab_Cable.Location = New System.Drawing.Point(4, 27)
        Me.Tab_Cable.Name = "Tab_Cable"
        Me.Tab_Cable.Size = New System.Drawing.Size(749, 199)
        Me.Tab_Cable.TabIndex = 8
        Me.Tab_Cable.Text = "کابل و سر کابل"
        Me.Tab_Cable.UseVisualStyleBackColor = True
        '
        'chk_AllCSatheVoltaj
        '
        Me.chk_AllCSatheVoltaj.AutoSize = True
        Me.chk_AllCSatheVoltaj.Location = New System.Drawing.Point(433, 129)
        Me.chk_AllCSatheVoltaj.Name = "chk_AllCSatheVoltaj"
        Me.chk_AllCSatheVoltaj.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllCSatheVoltaj.TabIndex = 224
        Me.chk_AllCSatheVoltaj.Text = "همه"
        Me.chk_AllCSatheVoltaj.UseVisualStyleBackColor = True
        '
        'chk_AllCMaghta
        '
        Me.chk_AllCMaghta.AutoSize = True
        Me.chk_AllCMaghta.Location = New System.Drawing.Point(433, 98)
        Me.chk_AllCMaghta.Name = "chk_AllCMaghta"
        Me.chk_AllCMaghta.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllCMaghta.TabIndex = 223
        Me.chk_AllCMaghta.Text = "همه"
        Me.chk_AllCMaghta.UseVisualStyleBackColor = True
        '
        'chk_AllCAbleNAme
        '
        Me.chk_AllCAbleNAme.AutoSize = True
        Me.chk_AllCAbleNAme.Location = New System.Drawing.Point(434, 40)
        Me.chk_AllCAbleNAme.Name = "chk_AllCAbleNAme"
        Me.chk_AllCAbleNAme.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllCAbleNAme.TabIndex = 222
        Me.chk_AllCAbleNAme.Text = "همه"
        Me.chk_AllCAbleNAme.UseVisualStyleBackColor = True
        '
        'chk_AllCJaryan
        '
        Me.chk_AllCJaryan.AutoSize = True
        Me.chk_AllCJaryan.Location = New System.Drawing.Point(434, 70)
        Me.chk_AllCJaryan.Name = "chk_AllCJaryan"
        Me.chk_AllCJaryan.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllCJaryan.TabIndex = 222
        Me.chk_AllCJaryan.Text = "همه"
        Me.chk_AllCJaryan.UseVisualStyleBackColor = True
        '
        'txt_CVoltaj
        '
        Me.txt_CVoltaj.CheckExistValueInDb = False
        Me.txt_CVoltaj.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_CVoltaj.CurrencyUnit = "ریال"
        Me.txt_CVoltaj.DefaultValue = ""
        Me.txt_CVoltaj.FillWithMaxInDb = False
        Me.txt_CVoltaj.IsRequired = False
        Me.txt_CVoltaj.Location = New System.Drawing.Point(494, 129)
        Me.txt_CVoltaj.MaxDecimalLength = 2
        Me.txt_CVoltaj.Name = "txt_CVoltaj"
        Me.txt_CVoltaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_CVoltaj.Size = New System.Drawing.Size(145, 25)
        Me.txt_CVoltaj.SpellControl = Nothing
        Me.txt_CVoltaj.TabIndex = 12
        Me.txt_CVoltaj.Tag = "OrderCode"
        Me.txt_CVoltaj.Title = Nothing
        Me.txt_CVoltaj.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_CVoltaj.UseForData = True
        Me.txt_CVoltaj.ValidateCheckExistOnEdit = False
        Me.txt_CVoltaj.Value = ""
        '
        'txt_CableName
        '
        Me.txt_CableName.BackColor = System.Drawing.Color.White
        Me.txt_CableName.CheckExistValueInDb = False
        Me.txt_CableName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_CableName.CurrencyUnit = "ریال"
        Me.txt_CableName.DefaultValue = ""
        Me.txt_CableName.FillWithMaxInDb = False
        Me.txt_CableName.IsRequired = False
        Me.txt_CableName.Location = New System.Drawing.Point(495, 38)
        Me.txt_CableName.MaxDecimalLength = 2
        Me.txt_CableName.Name = "txt_CableName"
        Me.txt_CableName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_CableName.Size = New System.Drawing.Size(145, 25)
        Me.txt_CableName.SpellControl = Nothing
        Me.txt_CableName.TabIndex = 11
        Me.txt_CableName.Tag = "OrderCode"
        Me.txt_CableName.Title = Nothing
        Me.txt_CableName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_CableName.UseForData = True
        Me.txt_CableName.ValidateCheckExistOnEdit = False
        Me.txt_CableName.Value = ""
        '
        'txt_CValidJaryan
        '
        Me.txt_CValidJaryan.BackColor = System.Drawing.Color.White
        Me.txt_CValidJaryan.CheckExistValueInDb = False
        Me.txt_CValidJaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_CValidJaryan.CurrencyUnit = "ریال"
        Me.txt_CValidJaryan.DefaultValue = ""
        Me.txt_CValidJaryan.FillWithMaxInDb = False
        Me.txt_CValidJaryan.IsRequired = False
        Me.txt_CValidJaryan.Location = New System.Drawing.Point(495, 68)
        Me.txt_CValidJaryan.MaxDecimalLength = 2
        Me.txt_CValidJaryan.Name = "txt_CValidJaryan"
        Me.txt_CValidJaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_CValidJaryan.Size = New System.Drawing.Size(145, 25)
        Me.txt_CValidJaryan.SpellControl = Nothing
        Me.txt_CValidJaryan.TabIndex = 11
        Me.txt_CValidJaryan.Tag = "OrderCode"
        Me.txt_CValidJaryan.Title = Nothing
        Me.txt_CValidJaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_CValidJaryan.UseForData = True
        Me.txt_CValidJaryan.ValidateCheckExistOnEdit = False
        Me.txt_CValidJaryan.Value = ""
        '
        'txt_CMaghta
        '
        Me.txt_CMaghta.CheckExistValueInDb = False
        Me.txt_CMaghta.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_CMaghta.CurrencyUnit = "ریال"
        Me.txt_CMaghta.DefaultValue = ""
        Me.txt_CMaghta.FillWithMaxInDb = False
        Me.txt_CMaghta.IsRequired = False
        Me.txt_CMaghta.Location = New System.Drawing.Point(494, 98)
        Me.txt_CMaghta.MaxDecimalLength = 2
        Me.txt_CMaghta.Name = "txt_CMaghta"
        Me.txt_CMaghta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_CMaghta.Size = New System.Drawing.Size(145, 25)
        Me.txt_CMaghta.SpellControl = Nothing
        Me.txt_CMaghta.TabIndex = 13
        Me.txt_CMaghta.Tag = "OrderCode"
        Me.txt_CMaghta.Title = Nothing
        Me.txt_CMaghta.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_CMaghta.UseForData = True
        Me.txt_CMaghta.ValidateCheckExistOnEdit = False
        Me.txt_CMaghta.Value = ""
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(650, 134)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(74, 18)
        Me.Label50.TabIndex = 9
        Me.Label50.Text = "سطح ولتاژ"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(651, 43)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(74, 18)
        Me.Label59.TabIndex = 8
        Me.Label59.Text = "جریان مجاز"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(651, 73)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(74, 18)
        Me.Label51.TabIndex = 8
        Me.Label51.Text = "جریان مجاز"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(650, 103)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(75, 18)
        Me.Label52.TabIndex = 10
        Me.Label52.Text = "مقطع کابل"
        '
        'cmb_Sazande
        '
        Me.cmb_Sazande.AutoComplete = True
        Me.cmb_Sazande.DataSource = Me.PmDeviceSazandeBindingSource
        Me.cmb_Sazande.DisplayMember = "سازندگان"
        Me.cmb_Sazande.EnterStop = True
        Me.cmb_Sazande.FormattingEnabled = True
        Me.cmb_Sazande.IsRequired = False
        Me.cmb_Sazande.LimitedToList = True
        Me.cmb_Sazande.Location = New System.Drawing.Point(423, 151)
        Me.cmb_Sazande.Name = "cmb_Sazande"
        Me.cmb_Sazande.OpenOnFoucus = True
        Me.cmb_Sazande.Size = New System.Drawing.Size(198, 26)
        Me.cmb_Sazande.TabIndex = 182
        Me.cmb_Sazande.Tag = ""
        Me.cmb_Sazande.ValueMember = "Srl"
        '
        'PmDeviceSazandeBindingSource
        '
        Me.PmDeviceSazandeBindingSource.DataMember = "Pm_Device_Sazande"
        Me.PmDeviceSazandeBindingSource.DataSource = Me.Ds_Lab
        '
        'Ds_Lab
        '
        Me.Ds_Lab.DataSetName = "Ds_Lab"
        Me.Ds_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(634, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 18)
        Me.Label16.TabIndex = 183
        Me.Label16.Text = "سازنده/ تیپ"
        '
        'chk_allSazande
        '
        Me.chk_allSazande.AutoSize = True
        Me.chk_allSazande.Location = New System.Drawing.Point(220, 153)
        Me.chk_allSazande.Name = "chk_allSazande"
        Me.chk_allSazande.Size = New System.Drawing.Size(55, 22)
        Me.chk_allSazande.TabIndex = 175
        Me.chk_allSazande.Text = "همه"
        Me.chk_allSazande.UseVisualStyleBackColor = True
        '
        'chk_AllDispatch
        '
        Me.chk_AllDispatch.AutoSize = True
        Me.chk_AllDispatch.Location = New System.Drawing.Point(20, 55)
        Me.chk_AllDispatch.Name = "chk_AllDispatch"
        Me.chk_AllDispatch.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllDispatch.TabIndex = 175
        Me.chk_AllDispatch.Text = "همه"
        Me.chk_AllDispatch.UseVisualStyleBackColor = True
        '
        'chk_AllSerial
        '
        Me.chk_AllSerial.AutoSize = True
        Me.chk_AllSerial.Location = New System.Drawing.Point(20, 28)
        Me.chk_AllSerial.Name = "chk_AllSerial"
        Me.chk_AllSerial.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllSerial.TabIndex = 175
        Me.chk_AllSerial.Text = "همه"
        Me.chk_AllSerial.UseVisualStyleBackColor = True
        '
        'chk_AllUtilizationDate
        '
        Me.chk_AllUtilizationDate.AutoSize = True
        Me.chk_AllUtilizationDate.Location = New System.Drawing.Point(220, 93)
        Me.chk_AllUtilizationDate.Name = "chk_AllUtilizationDate"
        Me.chk_AllUtilizationDate.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllUtilizationDate.TabIndex = 173
        Me.chk_AllUtilizationDate.Text = "همه"
        Me.chk_AllUtilizationDate.UseVisualStyleBackColor = True
        '
        'chk_AllMadeDate
        '
        Me.chk_AllMadeDate.AutoSize = True
        Me.chk_AllMadeDate.Location = New System.Drawing.Point(220, 120)
        Me.chk_AllMadeDate.Name = "chk_AllMadeDate"
        Me.chk_AllMadeDate.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllMadeDate.TabIndex = 180
        Me.chk_AllMadeDate.Text = "همه"
        Me.chk_AllMadeDate.UseVisualStyleBackColor = True
        '
        'txt_Serial
        '
        Me.txt_Serial.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Serial.CheckExistValueInDb = True
        Me.txt_Serial.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Serial.CurrencyUnit = "ریال"
        Me.txt_Serial.DefaultValue = ""
        Me.txt_Serial.FillWithMaxInDb = False
        Me.txt_Serial.IsRequired = True
        Me.txt_Serial.Location = New System.Drawing.Point(81, 22)
        Me.txt_Serial.MaxDecimalLength = 2
        Me.txt_Serial.Name = "txt_Serial"
        Me.txt_Serial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Serial.Size = New System.Drawing.Size(143, 25)
        Me.txt_Serial.SpellControl = Nothing
        Me.txt_Serial.TabIndex = 153
        Me.txt_Serial.Tag = ""
        Me.txt_Serial.Title = Nothing
        Me.txt_Serial.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Serial.UseForData = True
        Me.txt_Serial.ValidateCheckExistOnEdit = False
        Me.txt_Serial.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(439, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 18)
        Me.Label10.TabIndex = 170
        Me.Label10.Text = "تا"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(439, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 18)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "تا"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "شماره سریال"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(627, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 18)
        Me.Label9.TabIndex = 165
        Me.Label9.Text = "تاریخ بهره برداری از"
        '
        'lbl_RozeHafte
        '
        Me.lbl_RozeHafte.AutoSize = True
        Me.lbl_RozeHafte.Location = New System.Drawing.Point(627, 125)
        Me.lbl_RozeHafte.Name = "lbl_RozeHafte"
        Me.lbl_RozeHafte.Size = New System.Drawing.Size(98, 18)
        Me.lbl_RozeHafte.TabIndex = 164
        Me.lbl_RozeHafte.Text = "تاریخ ساخت از"
        '
        'txt_EndUti
        '
        Me.txt_EndUti.CheckExistValueInDb = False
        Me.txt_EndUti.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EndUti.CurrencyUnit = "ریال"
        Me.txt_EndUti.DefaultValue = ""
        Me.txt_EndUti.FillWithMaxInDb = False
        Me.txt_EndUti.IsRequired = True
        Me.txt_EndUti.Location = New System.Drawing.Point(279, 87)
        Me.txt_EndUti.MaxDecimalLength = 2
        Me.txt_EndUti.Name = "txt_EndUti"
        Me.txt_EndUti.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_EndUti.Size = New System.Drawing.Size(143, 25)
        Me.txt_EndUti.SpellControl = Nothing
        Me.txt_EndUti.TabIndex = 148
        Me.txt_EndUti.TabStop = False
        Me.txt_EndUti.Tag = ""
        Me.txt_EndUti.Title = Nothing
        Me.txt_EndUti.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_EndUti.UseForData = True
        Me.txt_EndUti.ValidateCheckExistOnEdit = False
        Me.txt_EndUti.Value = ""
        '
        'txt_EndMade
        '
        Me.txt_EndMade.CheckExistValueInDb = False
        Me.txt_EndMade.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EndMade.CurrencyUnit = "ریال"
        Me.txt_EndMade.DefaultValue = ""
        Me.txt_EndMade.FillWithMaxInDb = False
        Me.txt_EndMade.IsRequired = True
        Me.txt_EndMade.Location = New System.Drawing.Point(279, 118)
        Me.txt_EndMade.MaxDecimalLength = 2
        Me.txt_EndMade.Name = "txt_EndMade"
        Me.txt_EndMade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_EndMade.Size = New System.Drawing.Size(143, 25)
        Me.txt_EndMade.SpellControl = Nothing
        Me.txt_EndMade.TabIndex = 150
        Me.txt_EndMade.TabStop = False
        Me.txt_EndMade.Tag = ""
        Me.txt_EndMade.Title = Nothing
        Me.txt_EndMade.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_EndMade.UseForData = True
        Me.txt_EndMade.ValidateCheckExistOnEdit = False
        Me.txt_EndMade.Value = ""
        '
        'txt_StartUti
        '
        Me.txt_StartUti.CheckExistValueInDb = False
        Me.txt_StartUti.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_StartUti.CurrencyUnit = "ریال"
        Me.txt_StartUti.DefaultValue = ""
        Me.txt_StartUti.FillWithMaxInDb = False
        Me.txt_StartUti.IsRequired = True
        Me.txt_StartUti.Location = New System.Drawing.Point(478, 87)
        Me.txt_StartUti.MaxDecimalLength = 2
        Me.txt_StartUti.Name = "txt_StartUti"
        Me.txt_StartUti.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_StartUti.Size = New System.Drawing.Size(143, 25)
        Me.txt_StartUti.SpellControl = Nothing
        Me.txt_StartUti.TabIndex = 147
        Me.txt_StartUti.TabStop = False
        Me.txt_StartUti.Tag = ""
        Me.txt_StartUti.Title = Nothing
        Me.txt_StartUti.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_StartUti.UseForData = True
        Me.txt_StartUti.ValidateCheckExistOnEdit = False
        Me.txt_StartUti.Value = ""
        '
        'txt_StartMade
        '
        Me.txt_StartMade.CheckExistValueInDb = False
        Me.txt_StartMade.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_StartMade.CurrencyUnit = "ریال"
        Me.txt_StartMade.DefaultValue = ""
        Me.txt_StartMade.FillWithMaxInDb = False
        Me.txt_StartMade.IsRequired = True
        Me.txt_StartMade.Location = New System.Drawing.Point(478, 118)
        Me.txt_StartMade.MaxDecimalLength = 2
        Me.txt_StartMade.Name = "txt_StartMade"
        Me.txt_StartMade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_StartMade.Size = New System.Drawing.Size(143, 25)
        Me.txt_StartMade.SpellControl = Nothing
        Me.txt_StartMade.TabIndex = 149
        Me.txt_StartMade.TabStop = False
        Me.txt_StartMade.Tag = ""
        Me.txt_StartMade.Title = Nothing
        Me.txt_StartMade.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_StartMade.UseForData = True
        Me.txt_StartMade.ValidateCheckExistOnEdit = False
        Me.txt_StartMade.Value = ""
        '
        'Pm_TajhizNameTableAdapter
        '
        Me.Pm_TajhizNameTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "کد دیسپاچینگ"
        '
        'txt_DispatchCode
        '
        Me.txt_DispatchCode.BackColor = System.Drawing.Color.White
        Me.txt_DispatchCode.CheckExistValueInDb = True
        Me.txt_DispatchCode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DispatchCode.CurrencyUnit = "ریال"
        Me.txt_DispatchCode.DefaultValue = ""
        Me.txt_DispatchCode.FillWithMaxInDb = False
        Me.txt_DispatchCode.IsRequired = True
        Me.txt_DispatchCode.Location = New System.Drawing.Point(81, 53)
        Me.txt_DispatchCode.MaxDecimalLength = 2
        Me.txt_DispatchCode.Name = "txt_DispatchCode"
        Me.txt_DispatchCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DispatchCode.Size = New System.Drawing.Size(143, 25)
        Me.txt_DispatchCode.SpellControl = Nothing
        Me.txt_DispatchCode.TabIndex = 153
        Me.txt_DispatchCode.Tag = ""
        Me.txt_DispatchCode.Title = Nothing
        Me.txt_DispatchCode.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DispatchCode.UseForData = True
        Me.txt_DispatchCode.ValidateCheckExistOnEdit = False
        Me.txt_DispatchCode.Value = ""
        '
        'Pm_Device_SazandeTableAdapter
        '
        Me.Pm_Device_SazandeTableAdapter.ClearBeforeFill = True
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "Pm_Post"
        Me.BindingSource3.DataSource = Me.Ds_Pm
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'cmb_Post
        '
        Me.cmb_Post.AllowDrop = True
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.BindingSource3
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = False
        Me.cmb_Post.Location = New System.Drawing.Point(423, 24)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(198, 26)
        Me.cmb_Post.TabIndex = 174
        Me.cmb_Post.ValueMember = "Srl"
        '
        'chk_AllPost
        '
        Me.chk_AllPost.AutoSize = True
        Me.chk_AllPost.Location = New System.Drawing.Point(362, 30)
        Me.chk_AllPost.Name = "chk_AllPost"
        Me.chk_AllPost.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllPost.TabIndex = 176
        Me.chk_AllPost.Text = "همه"
        Me.chk_AllPost.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(627, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 18)
        Me.Label18.TabIndex = 175
        Me.Label18.Text = "نام پست"
        '
        'chk_AllModel
        '
        Me.chk_AllModel.AutoSize = True
        Me.chk_AllModel.Location = New System.Drawing.Point(362, 58)
        Me.chk_AllModel.Name = "chk_AllModel"
        Me.chk_AllModel.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllModel.TabIndex = 179
        Me.chk_AllModel.Text = "همه"
        Me.chk_AllModel.UseVisualStyleBackColor = True
        '
        'txt_Model
        '
        Me.txt_Model.BackColor = System.Drawing.Color.White
        Me.txt_Model.CheckExistValueInDb = True
        Me.txt_Model.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Model.CurrencyUnit = "ریال"
        Me.txt_Model.DefaultValue = ""
        Me.txt_Model.FillWithMaxInDb = False
        Me.txt_Model.IsRequired = True
        Me.txt_Model.Location = New System.Drawing.Point(423, 56)
        Me.txt_Model.MaxDecimalLength = 2
        Me.txt_Model.Name = "txt_Model"
        Me.txt_Model.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Model.Size = New System.Drawing.Size(198, 25)
        Me.txt_Model.SpellControl = Nothing
        Me.txt_Model.TabIndex = 177
        Me.txt_Model.Tag = ""
        Me.txt_Model.Title = Nothing
        Me.txt_Model.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Model.UseForData = True
        Me.txt_Model.ValidateCheckExistOnEdit = False
        Me.txt_Model.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(627, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 18)
        Me.Label17.TabIndex = 178
        Me.Label17.Text = "مدل"
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RpReleBindingSource
        '
        Me.RpReleBindingSource.DataMember = "Rp_Rele"
        Me.RpReleBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_ReleTableAdapter
        '
        Me.Rp_ReleTableAdapter.ClearBeforeFill = True
        '
        'RpTranseGhodratBindingSource
        '
        Me.RpTranseGhodratBindingSource.DataMember = "Rp_TranseGhodrat"
        Me.RpTranseGhodratBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_TranseGhodratTableAdapter
        '
        Me.Rp_TranseGhodratTableAdapter.ClearBeforeFill = True
        '
        'RpBarghgirBindingSource
        '
        Me.RpBarghgirBindingSource.DataMember = "Rp_Barghgir"
        Me.RpBarghgirBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_BarghgirTableAdapter
        '
        Me.Rp_BarghgirTableAdapter.ClearBeforeFill = True
        '
        'RpSexionerBindingSource
        '
        Me.RpSexionerBindingSource.DataMember = "Rp_Sexioner"
        Me.RpSexionerBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_SexionerTableAdapter
        '
        Me.Rp_SexionerTableAdapter.ClearBeforeFill = True
        '
        'RpBreakerBindingSource
        '
        Me.RpBreakerBindingSource.DataMember = "Rp_Breaker"
        Me.RpBreakerBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_BreakerTableAdapter
        '
        Me.Rp_BreakerTableAdapter.ClearBeforeFill = True
        '
        'RpTeranseBindingSource
        '
        Me.RpTeranseBindingSource.DataMember = "Rp_Teranse"
        Me.RpTeranseBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_TeranseTableAdapter
        '
        Me.Rp_TeranseTableAdapter.ClearBeforeFill = True
        '
        'RpTajhizBindingSource
        '
        Me.RpTajhizBindingSource.DataMember = "Rp_Tajhiz"
        Me.RpTajhizBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_TajhizTableAdapter
        '
        Me.Rp_TajhizTableAdapter.ClearBeforeFill = True
        '
        'RpCableBindingSource
        '
        Me.RpCableBindingSource.DataMember = "Rp_Cable"
        Me.RpCableBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_CableTableAdapter
        '
        Me.Rp_CableTableAdapter.ClearBeforeFill = True
        '
        'Frm_RpDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(789, 544)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpDevice"
        Me.Text = "گزارش کامل تجهیزات پست ها"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        Me.Tab_Tajhiz.ResumeLayout(False)
        Me.All.ResumeLayout(False)
        Me.All.PerformLayout()
        CType(Me.PmTajhizNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Rele.ResumeLayout(False)
        Me.Tab_Rele.PerformLayout()
        Me.Tab_TG.ResumeLayout(False)
        Me.Tab_TG.PerformLayout()
        Me.Tab_Barghgir.ResumeLayout(False)
        Me.Tab_Barghgir.PerformLayout()
        Me.Tab_Sexioner.ResumeLayout(False)
        Me.Tab_Sexioner.PerformLayout()
        Me.Tab_Breaker.ResumeLayout(False)
        Me.Tab_Breaker.PerformLayout()
        Me.Tab_TV.ResumeLayout(False)
        Me.Tab_TV.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Tab_Cable.ResumeLayout(False)
        Me.Tab_Cable.PerformLayout()
        CType(Me.PmDeviceSazandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpReleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpTranseGhodratBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpBarghgirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpSexionerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpBreakerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpTeranseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpTajhizBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpCableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Names As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibFormMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibFormMasterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tab_Tajhiz As System.Windows.Forms.TabControl
    Friend WithEvents All As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Rele As System.Windows.Forms.TabPage
    Friend WithEvents Tab_TG As System.Windows.Forms.TabPage
    Friend WithEvents cmb_TajhizName As VB_Component.ComboBox
    Friend WithEvents chk_AllSerial As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllUtilizationDate As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllMadeDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Serial As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_RozeHafte As System.Windows.Forms.Label
    Friend WithEvents txt_EndUti As CS_Component.TextBox
    Friend WithEvents txt_EndMade As CS_Component.TextBox
    Friend WithEvents txt_StartUti As CS_Component.TextBox
    Friend WithEvents txt_StartMade As CS_Component.TextBox
    Friend WithEvents Tab_Barghgir As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Sexioner As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Breaker As System.Windows.Forms.TabPage
    Friend WithEvents Tab_TV As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Cable As System.Windows.Forms.TabPage
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmTajhizNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_TajhizNameTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_TajhizNameTableAdapter
    Friend WithEvents chk_AllName As System.Windows.Forms.CheckBox
    Friend WithEvents chk_allOrderCode As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllDispatch As System.Windows.Forms.CheckBox
    Friend WithEvents txt_OrderCode As CS_Component.TextBox
    Friend WithEvents txt_DispatchCode As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chk_AllROrder As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_AllRNme As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ReleOrderCode As CS_Component.TextBox
    Friend WithEvents txt_ReleName As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_Sazande As VB_Component.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents PmDeviceSazandeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Device_SazandeTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Device_SazandeTableAdapter
    Friend WithEvents chk_allSazande As System.Windows.Forms.CheckBox
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents chk_AllModel As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Model As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents chk_AllPost As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chk_AllRVT As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllRCT As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ReleVT As CS_Component.TextBox
    Friend WithEvents txt_ReleCT As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_AllTGVectorGroup As System.Windows.Forms.CheckBox
    Friend WithEvents txt_TGFrequncy As CS_Component.TextBox
    Friend WithEvents txt_TGTapPlace As CS_Component.TextBox
    Friend WithEvents txt_TGJaryan As CS_Component.TextBox
    Friend WithEvents txt_TGVolume As CS_Component.TextBox
    Friend WithEvents txt_TGampedance As CS_Component.TextBox
    Friend WithEvents txt_TGVotaj As CS_Component.TextBox
    Friend WithEvents txt_TGColling As CS_Component.TextBox
    Friend WithEvents txt_TGVectore As CS_Component.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_TGBill As CS_Component.TextBox
    Friend WithEvents chk_AllTGTapPlace As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTGFerequenc As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTGJaryanConvert As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTGAmpedanse As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTGBill As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTGValume As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTGVotajConvert As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTGCooler As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBGTavan As System.Windows.Forms.CheckBox
    Friend WithEvents txt_BGClass As CS_Component.TextBox
    Friend WithEvents txt_BGJaryan As CS_Component.TextBox
    Friend WithEvents txt_BGJaryanSC As CS_Component.TextBox
    Friend WithEvents txt_BGVoltaj As CS_Component.TextBox
    Friend WithEvents txt_BGTavan As CS_Component.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents chk_AllBGVoltaj As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBGClass As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBGSC As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBGJaryan As System.Windows.Forms.CheckBox
    Friend WithEvents txt_sexUtilizationVoltaje As CS_Component.TextBox
    Friend WithEvents txt_SexJaryan As CS_Component.TextBox
    Friend WithEvents txt_SexJaryanSC As CS_Component.TextBox
    Friend WithEvents txt_SexVoltage As CS_Component.TextBox
    Friend WithEvents txt_SexMaxJaryan As CS_Component.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents chk_AllSexVoltaj As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllSexSC As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllsexUtiVoltaj As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllSexMaxJaryan As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllSexJaryan As System.Windows.Forms.CheckBox
    Friend WithEvents txt_BRJaryanN As CS_Component.TextBox
    Friend WithEvents txt_BRMekanism As CS_Component.TextBox
    Friend WithEvents txt_BRVotajN As CS_Component.TextBox
    Friend WithEvents txt_BRTurnOff As CS_Component.TextBox
    Friend WithEvents txt_BRJaryanSC As CS_Component.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_BRDisconnect As CS_Component.TextBox
    Friend WithEvents txt_BRMaxJaryan As CS_Component.TextBox
    Friend WithEvents txt_BrConnect As CS_Component.TextBox
    Friend WithEvents txt_BRMaxVoltaje As CS_Component.TextBox
    Friend WithEvents txt_BrBill As CS_Component.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents chk_AllBRMaxJaryan As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBRTurnoff As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBRBill As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBRMekanizm As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBRConnect As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBRJaryanN As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBRDisconnect As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBRVoltajN As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBRMaxVoltaj As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBRSC As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTVJMaxVoltaj As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTVJBill As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTVJClass As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTVJCoreConvert As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllTVJMaxJaryan As System.Windows.Forms.CheckBox
    Friend WithEvents txt_TVJCoreClass As CS_Component.TextBox
    Friend WithEvents txt_TVJMaxJaryan As CS_Component.TextBox
    Friend WithEvents txt_TVJbill As CS_Component.TextBox
    Friend WithEvents txt_TVJCoreConvert As CS_Component.TextBox
    Friend WithEvents txt_TVJMaxVoltage As CS_Component.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_TV As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Both As System.Windows.Forms.RadioButton
    Friend WithEvents RB_TJ As System.Windows.Forms.RadioButton
    Friend WithEvents chk_AllCSatheVoltaj As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllCMaghta As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllCJaryan As System.Windows.Forms.CheckBox
    Friend WithEvents txt_CVoltaj As CS_Component.TextBox
    Friend WithEvents txt_CValidJaryan As CS_Component.TextBox
    Friend WithEvents txt_CMaghta As CS_Component.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents RpReleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_ReleTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_ReleTableAdapter
    Friend WithEvents RpTranseGhodratBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_TranseGhodratTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_TranseGhodratTableAdapter
    Friend WithEvents txt_TGtapConvert As CS_Component.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chk_AllTGTapChange As System.Windows.Forms.CheckBox
    Friend WithEvents txt_TGName As CS_Component.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents chk_AllTgName As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllBGName As System.Windows.Forms.CheckBox
    Friend WithEvents txt_BGName As CS_Component.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents RpBarghgirBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_BarghgirTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_BarghgirTableAdapter
    Friend WithEvents chk_AllSexName As System.Windows.Forms.CheckBox
    Friend WithEvents txt_SexName As CS_Component.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents RpSexionerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_SexionerTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_SexionerTableAdapter
    Friend WithEvents chk_ALLBRName As System.Windows.Forms.CheckBox
    Friend WithEvents txt_BrName As CS_Component.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents RpBreakerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_BreakerTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_BreakerTableAdapter
    Friend WithEvents chk_AllTrName As System.Windows.Forms.CheckBox
    Friend WithEvents txt_TrName As CS_Component.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents RpTeranseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_TeranseTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_TeranseTableAdapter
    Friend WithEvents chk_ALLTrCoreNumber As System.Windows.Forms.CheckBox
    Friend WithEvents txt_TrCoreNumber As CS_Component.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents RpTajhizBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_TajhizTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_TajhizTableAdapter
    Friend WithEvents chk_AllCAbleNAme As System.Windows.Forms.CheckBox
    Friend WithEvents txt_CableName As CS_Component.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents RpCableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_CableTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_CableTableAdapter
    Friend WithEvents chk_SubDevice As System.Windows.Forms.CheckBox
End Class
