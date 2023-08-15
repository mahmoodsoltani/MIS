<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_setting
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
        Me.TB_1 = New System.Windows.Forms.TabPage
        Me.txt_MojazDateEdit = New CS_Component.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_MojazDate = New CS_Component.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_AdminEnd = New CS_Component.TextBox
        Me.txt_PersonelEnd = New CS_Component.TextBox
        Me.txt_EndReport = New CS_Component.TextBox
        Me.txt_AdminStart = New CS_Component.TextBox
        Me.txt_PeronelStart = New CS_Component.TextBox
        Me.txt_StartReport = New CS_Component.TextBox
        Me.cmb_HazineCode = New VB_Component.ComboBox
        Me.PmHazineCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.txt_MaxTaradodBound = New CS_Component.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ts_SAghfeEzafekarHolyDAy = New VB_Component.TimeSelect
        Me.ts_SAghfeEzafekarNormal = New VB_Component.TimeSelect
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_ModirMessage = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ZaribeMasafat = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_HolidayZarib = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Tab_Control = New System.Windows.Forms.TabControl
        Me.TB_2 = New System.Windows.Forms.TabPage
        Me.pg_MainLogo = New VB_Component.PictureGetter
        Me.Label3 = New System.Windows.Forms.Label
        Me.TB_3 = New System.Windows.Forms.TabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chk_UseTemplate = New System.Windows.Forms.CheckBox
        Me.txt_SmsTemplate = New CS_Component.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lb_Sharj = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lb_Info = New System.Windows.Forms.Label
        Me.Pm_HazineCodeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_ZaribAlal = New CS_Component.TextBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.TB_1.SuspendLayout()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Control.SuspendLayout()
        Me.TB_2.SuspendLayout()
        Me.TB_3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(13, 587)
        Me.gbx_Buttons.Size = New System.Drawing.Size(599, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.HeaderText = "خروج"
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(495, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Tab_Control)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(599, 543)
        '
        'TB_1
        '
        Me.TB_1.BackColor = System.Drawing.Color.Transparent
        Me.TB_1.Controls.Add(Me.txt_MojazDateEdit)
        Me.TB_1.Controls.Add(Me.Label13)
        Me.TB_1.Controls.Add(Me.txt_MojazDate)
        Me.TB_1.Controls.Add(Me.Label12)
        Me.TB_1.Controls.Add(Me.txt_AdminEnd)
        Me.TB_1.Controls.Add(Me.txt_PersonelEnd)
        Me.TB_1.Controls.Add(Me.txt_EndReport)
        Me.TB_1.Controls.Add(Me.txt_AdminStart)
        Me.TB_1.Controls.Add(Me.txt_PeronelStart)
        Me.TB_1.Controls.Add(Me.txt_StartReport)
        Me.TB_1.Controls.Add(Me.cmb_HazineCode)
        Me.TB_1.Controls.Add(Me.txt_MaxTaradodBound)
        Me.TB_1.Controls.Add(Me.Label7)
        Me.TB_1.Controls.Add(Me.ts_SAghfeEzafekarHolyDAy)
        Me.TB_1.Controls.Add(Me.ts_SAghfeEzafekarNormal)
        Me.TB_1.Controls.Add(Me.Label6)
        Me.TB_1.Controls.Add(Me.Label18)
        Me.TB_1.Controls.Add(Me.Label11)
        Me.TB_1.Controls.Add(Me.Label10)
        Me.TB_1.Controls.Add(Me.Label9)
        Me.TB_1.Controls.Add(Me.Label5)
        Me.TB_1.Controls.Add(Me.txt_ModirMessage)
        Me.TB_1.Controls.Add(Me.Label2)
        Me.TB_1.Controls.Add(Me.txt_ZaribeMasafat)
        Me.TB_1.Controls.Add(Me.Label1)
        Me.TB_1.Controls.Add(Me.txt_ZaribAlal)
        Me.TB_1.Controls.Add(Me.txt_HolidayZarib)
        Me.TB_1.Controls.Add(Me.Label8)
        Me.TB_1.Controls.Add(Me.Label19)
        Me.TB_1.Location = New System.Drawing.Point(4, 27)
        Me.TB_1.Name = "TB_1"
        Me.TB_1.Padding = New System.Windows.Forms.Padding(3)
        Me.TB_1.Size = New System.Drawing.Size(585, 488)
        Me.TB_1.TabIndex = 0
        Me.TB_1.Text = "تنظیمات"
        Me.TB_1.UseVisualStyleBackColor = True
        '
        'txt_MojazDateEdit
        '
        Me.txt_MojazDateEdit.BackColor = System.Drawing.SystemColors.Window
        Me.txt_MojazDateEdit.CheckExistValueInDb = False
        Me.txt_MojazDateEdit.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_MojazDateEdit.CurrencyUnit = "ریال"
        Me.txt_MojazDateEdit.DefaultValue = ""
        Me.txt_MojazDateEdit.FillWithMaxInDb = False
        Me.txt_MojazDateEdit.IsRequired = False
        Me.txt_MojazDateEdit.Location = New System.Drawing.Point(21, 125)
        Me.txt_MojazDateEdit.MaxDecimalLength = 2
        Me.txt_MojazDateEdit.Name = "txt_MojazDateEdit"
        Me.txt_MojazDateEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_MojazDateEdit.Size = New System.Drawing.Size(43, 25)
        Me.txt_MojazDateEdit.SpellControl = Nothing
        Me.txt_MojazDateEdit.TabIndex = 35
        Me.txt_MojazDateEdit.Tag = "Status"
        Me.txt_MojazDateEdit.Text = "0"
        Me.txt_MojazDateEdit.Title = Nothing
        Me.txt_MojazDateEdit.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_MojazDateEdit.UseForData = True
        Me.txt_MojazDateEdit.ValidateCheckExistOnEdit = False
        Me.txt_MojazDateEdit.Value = 0.0!
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(60, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(228, 18)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "حداکثر روزهای مجاز ویرایش فرم کار:"
        '
        'txt_MojazDate
        '
        Me.txt_MojazDate.BackColor = System.Drawing.SystemColors.Window
        Me.txt_MojazDate.CheckExistValueInDb = False
        Me.txt_MojazDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_MojazDate.CurrencyUnit = "ریال"
        Me.txt_MojazDate.DefaultValue = ""
        Me.txt_MojazDate.FillWithMaxInDb = False
        Me.txt_MojazDate.IsRequired = False
        Me.txt_MojazDate.Location = New System.Drawing.Point(307, 126)
        Me.txt_MojazDate.MaxDecimalLength = 2
        Me.txt_MojazDate.Name = "txt_MojazDate"
        Me.txt_MojazDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_MojazDate.Size = New System.Drawing.Size(58, 25)
        Me.txt_MojazDate.SpellControl = Nothing
        Me.txt_MojazDate.TabIndex = 33
        Me.txt_MojazDate.Tag = "Status"
        Me.txt_MojazDate.Text = "0"
        Me.txt_MojazDate.Title = Nothing
        Me.txt_MojazDate.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_MojazDate.UseForData = True
        Me.txt_MojazDate.ValidateCheckExistOnEdit = False
        Me.txt_MojazDate.Value = 0.0!
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(371, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 18)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "حداکثر روزهای مجاز ثبت فرم کار:"
        '
        'txt_AdminEnd
        '
        Me.txt_AdminEnd.CheckExistValueInDb = False
        Me.txt_AdminEnd.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_AdminEnd.CurrencyUnit = "ریال"
        Me.txt_AdminEnd.DefaultValue = ""
        Me.txt_AdminEnd.FillWithMaxInDb = False
        Me.txt_AdminEnd.IsRequired = False
        Me.txt_AdminEnd.Location = New System.Drawing.Point(102, 228)
        Me.txt_AdminEnd.MaxDecimalLength = 2
        Me.txt_AdminEnd.Name = "txt_AdminEnd"
        Me.txt_AdminEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_AdminEnd.Size = New System.Drawing.Size(149, 25)
        Me.txt_AdminEnd.SpellControl = Nothing
        Me.txt_AdminEnd.TabIndex = 31
        Me.txt_AdminEnd.TabStop = False
        Me.txt_AdminEnd.Tag = "tavalod"
        Me.txt_AdminEnd.Title = Nothing
        Me.txt_AdminEnd.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_AdminEnd.UseForData = True
        Me.txt_AdminEnd.ValidateCheckExistOnEdit = False
        Me.txt_AdminEnd.Value = ""
        '
        'txt_PersonelEnd
        '
        Me.txt_PersonelEnd.CheckExistValueInDb = False
        Me.txt_PersonelEnd.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_PersonelEnd.CurrencyUnit = "ریال"
        Me.txt_PersonelEnd.DefaultValue = ""
        Me.txt_PersonelEnd.FillWithMaxInDb = False
        Me.txt_PersonelEnd.IsRequired = False
        Me.txt_PersonelEnd.Location = New System.Drawing.Point(102, 195)
        Me.txt_PersonelEnd.MaxDecimalLength = 2
        Me.txt_PersonelEnd.Name = "txt_PersonelEnd"
        Me.txt_PersonelEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_PersonelEnd.Size = New System.Drawing.Size(149, 25)
        Me.txt_PersonelEnd.SpellControl = Nothing
        Me.txt_PersonelEnd.TabIndex = 31
        Me.txt_PersonelEnd.TabStop = False
        Me.txt_PersonelEnd.Tag = "tavalod"
        Me.txt_PersonelEnd.Title = Nothing
        Me.txt_PersonelEnd.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_PersonelEnd.UseForData = True
        Me.txt_PersonelEnd.ValidateCheckExistOnEdit = False
        Me.txt_PersonelEnd.Value = ""
        '
        'txt_EndReport
        '
        Me.txt_EndReport.CheckExistValueInDb = False
        Me.txt_EndReport.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EndReport.CurrencyUnit = "ریال"
        Me.txt_EndReport.DefaultValue = ""
        Me.txt_EndReport.FillWithMaxInDb = False
        Me.txt_EndReport.IsRequired = False
        Me.txt_EndReport.Location = New System.Drawing.Point(102, 161)
        Me.txt_EndReport.MaxDecimalLength = 2
        Me.txt_EndReport.Name = "txt_EndReport"
        Me.txt_EndReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_EndReport.Size = New System.Drawing.Size(149, 25)
        Me.txt_EndReport.SpellControl = Nothing
        Me.txt_EndReport.TabIndex = 31
        Me.txt_EndReport.TabStop = False
        Me.txt_EndReport.Tag = "tavalod"
        Me.txt_EndReport.Title = Nothing
        Me.txt_EndReport.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_EndReport.UseForData = True
        Me.txt_EndReport.ValidateCheckExistOnEdit = False
        Me.txt_EndReport.Value = ""
        '
        'txt_AdminStart
        '
        Me.txt_AdminStart.CheckExistValueInDb = False
        Me.txt_AdminStart.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_AdminStart.CurrencyUnit = "ریال"
        Me.txt_AdminStart.DefaultValue = ""
        Me.txt_AdminStart.FillWithMaxInDb = False
        Me.txt_AdminStart.IsRequired = False
        Me.txt_AdminStart.Location = New System.Drawing.Point(283, 228)
        Me.txt_AdminStart.MaxDecimalLength = 2
        Me.txt_AdminStart.Name = "txt_AdminStart"
        Me.txt_AdminStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_AdminStart.Size = New System.Drawing.Size(149, 25)
        Me.txt_AdminStart.SpellControl = Nothing
        Me.txt_AdminStart.TabIndex = 31
        Me.txt_AdminStart.TabStop = False
        Me.txt_AdminStart.Tag = "tavalod"
        Me.txt_AdminStart.Title = Nothing
        Me.txt_AdminStart.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_AdminStart.UseForData = True
        Me.txt_AdminStart.ValidateCheckExistOnEdit = False
        Me.txt_AdminStart.Value = ""
        '
        'txt_PeronelStart
        '
        Me.txt_PeronelStart.CheckExistValueInDb = False
        Me.txt_PeronelStart.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_PeronelStart.CurrencyUnit = "ریال"
        Me.txt_PeronelStart.DefaultValue = ""
        Me.txt_PeronelStart.FillWithMaxInDb = False
        Me.txt_PeronelStart.IsRequired = False
        Me.txt_PeronelStart.Location = New System.Drawing.Point(283, 195)
        Me.txt_PeronelStart.MaxDecimalLength = 2
        Me.txt_PeronelStart.Name = "txt_PeronelStart"
        Me.txt_PeronelStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_PeronelStart.Size = New System.Drawing.Size(149, 25)
        Me.txt_PeronelStart.SpellControl = Nothing
        Me.txt_PeronelStart.TabIndex = 31
        Me.txt_PeronelStart.TabStop = False
        Me.txt_PeronelStart.Tag = "tavalod"
        Me.txt_PeronelStart.Title = Nothing
        Me.txt_PeronelStart.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_PeronelStart.UseForData = True
        Me.txt_PeronelStart.ValidateCheckExistOnEdit = False
        Me.txt_PeronelStart.Value = ""
        '
        'txt_StartReport
        '
        Me.txt_StartReport.CheckExistValueInDb = False
        Me.txt_StartReport.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_StartReport.CurrencyUnit = "ریال"
        Me.txt_StartReport.DefaultValue = ""
        Me.txt_StartReport.FillWithMaxInDb = False
        Me.txt_StartReport.IsRequired = False
        Me.txt_StartReport.Location = New System.Drawing.Point(283, 161)
        Me.txt_StartReport.MaxDecimalLength = 2
        Me.txt_StartReport.Name = "txt_StartReport"
        Me.txt_StartReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_StartReport.Size = New System.Drawing.Size(149, 25)
        Me.txt_StartReport.SpellControl = Nothing
        Me.txt_StartReport.TabIndex = 31
        Me.txt_StartReport.TabStop = False
        Me.txt_StartReport.Tag = "tavalod"
        Me.txt_StartReport.Title = Nothing
        Me.txt_StartReport.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_StartReport.UseForData = True
        Me.txt_StartReport.ValidateCheckExistOnEdit = False
        Me.txt_StartReport.Value = ""
        '
        'cmb_HazineCode
        '
        Me.cmb_HazineCode.AutoComplete = True
        Me.cmb_HazineCode.DataSource = Me.PmHazineCodeBindingSource
        Me.cmb_HazineCode.DisplayMember = "کد"
        Me.cmb_HazineCode.EnterStop = True
        Me.cmb_HazineCode.FormattingEnabled = True
        Me.cmb_HazineCode.IsRequired = False
        Me.cmb_HazineCode.LimitedToList = True
        Me.cmb_HazineCode.Location = New System.Drawing.Point(186, 37)
        Me.cmb_HazineCode.Name = "cmb_HazineCode"
        Me.cmb_HazineCode.OpenOnFoucus = True
        Me.cmb_HazineCode.Size = New System.Drawing.Size(170, 26)
        Me.cmb_HazineCode.TabIndex = 30
        Me.cmb_HazineCode.ValueMember = "Srl"
        '
        'PmHazineCodeBindingSource
        '
        Me.PmHazineCodeBindingSource.DataMember = "Pm_HazineCode"
        Me.PmHazineCodeBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_MaxTaradodBound
        '
        Me.txt_MaxTaradodBound.BackColor = System.Drawing.SystemColors.Window
        Me.txt_MaxTaradodBound.CheckExistValueInDb = False
        Me.txt_MaxTaradodBound.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_MaxTaradodBound.CurrencyUnit = "ریال"
        Me.txt_MaxTaradodBound.DefaultValue = ""
        Me.txt_MaxTaradodBound.FillWithMaxInDb = False
        Me.txt_MaxTaradodBound.IsRequired = False
        Me.txt_MaxTaradodBound.Location = New System.Drawing.Point(201, 66)
        Me.txt_MaxTaradodBound.MaxDecimalLength = 2
        Me.txt_MaxTaradodBound.Name = "txt_MaxTaradodBound"
        Me.txt_MaxTaradodBound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_MaxTaradodBound.Size = New System.Drawing.Size(60, 25)
        Me.txt_MaxTaradodBound.SpellControl = Nothing
        Me.txt_MaxTaradodBound.TabIndex = 29
        Me.txt_MaxTaradodBound.Tag = "Status"
        Me.txt_MaxTaradodBound.Text = "0"
        Me.txt_MaxTaradodBound.Title = Nothing
        Me.txt_MaxTaradodBound.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_MaxTaradodBound.UseForData = True
        Me.txt_MaxTaradodBound.ValidateCheckExistOnEdit = False
        Me.txt_MaxTaradodBound.Value = 0.0!
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(309, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "حداکثر مسافت در مسیر های یک طرفه - دوطرفه"
        '
        'ts_SAghfeEzafekarHolyDAy
        '
        Me.ts_SAghfeEzafekarHolyDAy.Hour = "0"
        Me.ts_SAghfeEzafekarHolyDAy.HourMaxLen = 4
        Me.ts_SAghfeEzafekarHolyDAy.Location = New System.Drawing.Point(21, 97)
        Me.ts_SAghfeEzafekarHolyDAy.Minutes = "0"
        Me.ts_SAghfeEzafekarHolyDAy.Name = "ts_SAghfeEzafekarHolyDAy"
        Me.ts_SAghfeEzafekarHolyDAy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_SAghfeEzafekarHolyDAy.Second = "00"
        Me.ts_SAghfeEzafekarHolyDAy.Size = New System.Drawing.Size(81, 23)
        Me.ts_SAghfeEzafekarHolyDAy.TabIndex = 27
        Me.ts_SAghfeEzafekarHolyDAy.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_SAghfeEzafekarHolyDAy.Value = "0:0"
        '
        'ts_SAghfeEzafekarNormal
        '
        Me.ts_SAghfeEzafekarNormal.Hour = "0"
        Me.ts_SAghfeEzafekarNormal.HourMaxLen = 4
        Me.ts_SAghfeEzafekarNormal.Location = New System.Drawing.Point(307, 97)
        Me.ts_SAghfeEzafekarNormal.Minutes = "0"
        Me.ts_SAghfeEzafekarNormal.Name = "ts_SAghfeEzafekarNormal"
        Me.ts_SAghfeEzafekarNormal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_SAghfeEzafekarNormal.Second = "00"
        Me.ts_SAghfeEzafekarNormal.Size = New System.Drawing.Size(81, 23)
        Me.ts_SAghfeEzafekarNormal.TabIndex = 26
        Me.ts_SAghfeEzafekarNormal.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_SAghfeEzafekarNormal.Value = "0:0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "سقف اضافه کار روز تعطیل"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(450, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "تاریخ ویرایش مدیران"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(449, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "تاریخ ویرایش پرسنل"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(438, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 18)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "تاریخ گزارش تایم کارت"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(397, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 18)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "سقف اضافه کار روز معمولی"
        '
        'txt_ModirMessage
        '
        Me.txt_ModirMessage.BackColor = System.Drawing.SystemColors.Window
        Me.txt_ModirMessage.CheckExistValueInDb = False
        Me.txt_ModirMessage.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ModirMessage.CurrencyUnit = "ریال"
        Me.txt_ModirMessage.DefaultValue = ""
        Me.txt_ModirMessage.FillWithMaxInDb = False
        Me.txt_ModirMessage.IsRequired = False
        Me.txt_ModirMessage.Location = New System.Drawing.Point(9, 402)
        Me.txt_ModirMessage.MaxDecimalLength = 2
        Me.txt_ModirMessage.Multiline = True
        Me.txt_ModirMessage.Name = "txt_ModirMessage"
        Me.txt_ModirMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ModirMessage.Size = New System.Drawing.Size(454, 77)
        Me.txt_ModirMessage.SpellControl = Nothing
        Me.txt_ModirMessage.TabIndex = 22
        Me.txt_ModirMessage.Tag = "Status"
        Me.txt_ModirMessage.Title = Nothing
        Me.txt_ModirMessage.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ModirMessage.UseForData = True
        Me.txt_ModirMessage.ValidateCheckExistOnEdit = False
        Me.txt_ModirMessage.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(482, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "متن پیغام مدیر"
        '
        'txt_ZaribeMasafat
        '
        Me.txt_ZaribeMasafat.BackColor = System.Drawing.SystemColors.Window
        Me.txt_ZaribeMasafat.CheckExistValueInDb = False
        Me.txt_ZaribeMasafat.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ZaribeMasafat.CurrencyUnit = "ریال"
        Me.txt_ZaribeMasafat.DefaultValue = ""
        Me.txt_ZaribeMasafat.FillWithMaxInDb = False
        Me.txt_ZaribeMasafat.IsRequired = False
        Me.txt_ZaribeMasafat.Location = New System.Drawing.Point(60, 8)
        Me.txt_ZaribeMasafat.MaxDecimalLength = 2
        Me.txt_ZaribeMasafat.Name = "txt_ZaribeMasafat"
        Me.txt_ZaribeMasafat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ZaribeMasafat.Size = New System.Drawing.Size(60, 25)
        Me.txt_ZaribeMasafat.SpellControl = Nothing
        Me.txt_ZaribeMasafat.TabIndex = 22
        Me.txt_ZaribeMasafat.Tag = "Status"
        Me.txt_ZaribeMasafat.Text = "0"
        Me.txt_ZaribeMasafat.Title = Nothing
        Me.txt_ZaribeMasafat.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_ZaribeMasafat.UseForData = True
        Me.txt_ZaribeMasafat.ValidateCheckExistOnEdit = False
        Me.txt_ZaribeMasafat.Value = 0.0!
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ضریب مسافت در فرم کار"
        '
        'txt_HolidayZarib
        '
        Me.txt_HolidayZarib.BackColor = System.Drawing.Color.Yellow
        Me.txt_HolidayZarib.CheckExistValueInDb = False
        Me.txt_HolidayZarib.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_HolidayZarib.CurrencyUnit = "ریال"
        Me.txt_HolidayZarib.DefaultValue = ""
        Me.txt_HolidayZarib.FillWithMaxInDb = False
        Me.txt_HolidayZarib.IsRequired = False
        Me.txt_HolidayZarib.Location = New System.Drawing.Point(296, 8)
        Me.txt_HolidayZarib.MaxDecimalLength = 2
        Me.txt_HolidayZarib.Name = "txt_HolidayZarib"
        Me.txt_HolidayZarib.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_HolidayZarib.Size = New System.Drawing.Size(60, 25)
        Me.txt_HolidayZarib.SpellControl = Nothing
        Me.txt_HolidayZarib.TabIndex = 20
        Me.txt_HolidayZarib.Tag = "Status"
        Me.txt_HolidayZarib.Text = "0"
        Me.txt_HolidayZarib.Title = Nothing
        Me.txt_HolidayZarib.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_HolidayZarib.UseForData = True
        Me.txt_HolidayZarib.ValidateCheckExistOnEdit = False
        Me.txt_HolidayZarib.Value = 0.0!
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "کد هزینه پیش فرض در فرم کار"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(401, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(178, 18)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "ضریب اضافه کار روز تعطیلی"
        '
        'Tab_Control
        '
        Me.Tab_Control.Controls.Add(Me.TB_1)
        Me.Tab_Control.Controls.Add(Me.TB_2)
        Me.Tab_Control.Controls.Add(Me.TB_3)
        Me.Tab_Control.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Control.Location = New System.Drawing.Point(3, 21)
        Me.Tab_Control.Name = "Tab_Control"
        Me.Tab_Control.RightToLeftLayout = True
        Me.Tab_Control.SelectedIndex = 0
        Me.Tab_Control.Size = New System.Drawing.Size(593, 519)
        Me.Tab_Control.TabIndex = 5
        '
        'TB_2
        '
        Me.TB_2.Controls.Add(Me.pg_MainLogo)
        Me.TB_2.Controls.Add(Me.Label3)
        Me.TB_2.Location = New System.Drawing.Point(4, 27)
        Me.TB_2.Name = "TB_2"
        Me.TB_2.Padding = New System.Windows.Forms.Padding(3)
        Me.TB_2.Size = New System.Drawing.Size(585, 488)
        Me.TB_2.TabIndex = 1
        Me.TB_2.Text = "تصاویر"
        Me.TB_2.UseVisualStyleBackColor = True
        '
        'pg_MainLogo
        '
        Me.pg_MainLogo.BackColor = System.Drawing.Color.Transparent
        Me.pg_MainLogo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))

        Me.pg_MainLogo.Location = New System.Drawing.Point(265, 16)
        Me.pg_MainLogo.Name = "pg_MainLogo"
        Me.pg_MainLogo.Size = New System.Drawing.Size(116, 144)
        Me.pg_MainLogo.SizeOfImage = 0
        Me.pg_MainLogo.TabIndex = 13
        Me.pg_MainLogo.Tag = "Image"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(396, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "تصویر لوگوی صفحه اصلی"
        '
        'TB_3
        '
        Me.TB_3.Controls.Add(Me.Label4)
        Me.TB_3.Controls.Add(Me.GroupBox3)
        Me.TB_3.Controls.Add(Me.GroupBox2)
        Me.TB_3.Controls.Add(Me.GroupBox1)
        Me.TB_3.Location = New System.Drawing.Point(4, 27)
        Me.TB_3.Name = "TB_3"
        Me.TB_3.Size = New System.Drawing.Size(585, 488)
        Me.TB_3.TabIndex = 2
        Me.TB_3.Text = "مودم"
        Me.TB_3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(541, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = " (نام سرپرست=@S و  نام پست=@p و نام نقص=@n و نام تجهیز=@t و شرح=@r و تاریخ=@d)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk_UseTemplate)
        Me.GroupBox3.Controls.Add(Me.txt_SmsTemplate)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(558, 192)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "تعریف قالب پیامک"
        '
        'chk_UseTemplate
        '
        Me.chk_UseTemplate.AutoSize = True
        Me.chk_UseTemplate.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.chk_UseTemplate.Location = New System.Drawing.Point(246, 23)
        Me.chk_UseTemplate.Name = "chk_UseTemplate"
        Me.chk_UseTemplate.Size = New System.Drawing.Size(294, 21)
        Me.chk_UseTemplate.TabIndex = 24
        Me.chk_UseTemplate.Text = "استفاده از قالب پیامک برای ارسال در فرم نقص"
        Me.chk_UseTemplate.UseVisualStyleBackColor = True
        '
        'txt_SmsTemplate
        '
        Me.txt_SmsTemplate.BackColor = System.Drawing.SystemColors.Window
        Me.txt_SmsTemplate.CheckExistValueInDb = False
        Me.txt_SmsTemplate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SmsTemplate.CurrencyUnit = "ریال"
        Me.txt_SmsTemplate.DefaultValue = ""
        Me.txt_SmsTemplate.FillWithMaxInDb = False
        Me.txt_SmsTemplate.IsRequired = False
        Me.txt_SmsTemplate.Location = New System.Drawing.Point(11, 88)
        Me.txt_SmsTemplate.MaxDecimalLength = 2
        Me.txt_SmsTemplate.Multiline = True
        Me.txt_SmsTemplate.Name = "txt_SmsTemplate"
        Me.txt_SmsTemplate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SmsTemplate.Size = New System.Drawing.Size(533, 98)
        Me.txt_SmsTemplate.SpellControl = Nothing
        Me.txt_SmsTemplate.TabIndex = 23
        Me.txt_SmsTemplate.Tag = "Status"
        Me.txt_SmsTemplate.Title = Nothing
        Me.txt_SmsTemplate.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SmsTemplate.UseForData = True
        Me.txt_SmsTemplate.ValidateCheckExistOnEdit = False
        Me.txt_SmsTemplate.Value = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lb_Sharj)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 69)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "اطلاعات میزان شارژ"
        '
        'lb_Sharj
        '
        Me.lb_Sharj.Location = New System.Drawing.Point(11, 26)
        Me.lb_Sharj.Name = "lb_Sharj"
        Me.lb_Sharj.Size = New System.Drawing.Size(525, 32)
        Me.lb_Sharj.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_Info)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 71)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطلاعات اتصال"
        '
        'lb_Info
        '
        Me.lb_Info.Location = New System.Drawing.Point(11, 24)
        Me.lb_Info.Name = "lb_Info"
        Me.lb_Info.Size = New System.Drawing.Size(528, 36)
        Me.lb_Info.TabIndex = 0
        '
        'Pm_HazineCodeTableAdapter
        '
        Me.Pm_HazineCodeTableAdapter.ClearBeforeFill = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(323, 278)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(256, 18)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "در صد محاسبه اضافه کار علی الحساب "
        '
        'txt_ZaribAlal
        '
        Me.txt_ZaribAlal.BackColor = System.Drawing.Color.Yellow
        Me.txt_ZaribAlal.CheckExistValueInDb = False
        Me.txt_ZaribAlal.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ZaribAlal.CurrencyUnit = "ریال"
        Me.txt_ZaribAlal.DefaultValue = ""
        Me.txt_ZaribAlal.FillWithMaxInDb = False
        Me.txt_ZaribAlal.IsRequired = False
        Me.txt_ZaribAlal.Location = New System.Drawing.Point(257, 275)
        Me.txt_ZaribAlal.MaxDecimalLength = 2
        Me.txt_ZaribAlal.Name = "txt_ZaribAlal"
        Me.txt_ZaribAlal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ZaribAlal.Size = New System.Drawing.Size(60, 25)
        Me.txt_ZaribAlal.SpellControl = Nothing
        Me.txt_ZaribAlal.TabIndex = 20
        Me.txt_ZaribAlal.Tag = "Status"
        Me.txt_ZaribAlal.Text = "0"
        Me.txt_ZaribAlal.Title = Nothing
        Me.txt_ZaribAlal.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_ZaribAlal.UseForData = True
        Me.txt_ZaribAlal.ValidateCheckExistOnEdit = False
        Me.txt_ZaribAlal.Value = 0.0!
        '
        'Frm_setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(625, 680)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_setting"
        Me.Text = "تنظیمات"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.TB_1.ResumeLayout(False)
        Me.TB_1.PerformLayout()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Control.ResumeLayout(False)
        Me.TB_2.ResumeLayout(False)
        Me.TB_2.PerformLayout()
        Me.TB_3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_1 As System.Windows.Forms.TabPage
    Friend WithEvents txt_HolidayZarib As CS_Component.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Tab_Control As System.Windows.Forms.TabControl
    Friend WithEvents txt_ZaribeMasafat As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ModirMessage As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pg_MainLogo As VB_Component.PictureGetter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ts_SAghfeEzafekarHolyDAy As VB_Component.TimeSelect
    Friend WithEvents ts_SAghfeEzafekarNormal As VB_Component.TimeSelect
    Friend WithEvents txt_MaxTaradodBound As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_3 As System.Windows.Forms.TabPage
    Friend WithEvents lb_Sharj As System.Windows.Forms.Label
    Friend WithEvents lb_Info As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_SmsTemplate As CS_Component.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_UseTemplate As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_HazineCode As VB_Component.ComboBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmHazineCodeBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents Pm_HazineCodeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_AdminEnd As CS_Component.TextBox
    Friend WithEvents txt_PersonelEnd As CS_Component.TextBox
    Friend WithEvents txt_EndReport As CS_Component.TextBox
    Friend WithEvents txt_AdminStart As CS_Component.TextBox
    Friend WithEvents txt_PeronelStart As CS_Component.TextBox
    Friend WithEvents txt_StartReport As CS_Component.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_MojazDate As CS_Component.TextBox
    Friend WithEvents txt_MojazDateEdit As CS_Component.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_ZaribAlal As CS_Component.TextBox
End Class
