<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WorkForm_Edit
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
        Me.Label9 = New System.Windows.Forms.Label
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.cmb_HazineCode = New VB_Component.ComboBox
        Me.PmHazineCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Cmb_PostTo = New VB_Component.ComboBox
        Me.PMPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cmb_PostFrom = New VB_Component.ComboBox
        Me.PMPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Distance = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ts_EndWork = New VB_Component.TimeSelect
        Me.ts_BeginWork = New VB_Component.TimeSelect
        Me.ts_ZamaneKhroj = New VB_Component.TimeSelect
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.rbtn_taradodBargasht = New System.Windows.Forms.RadioButton
        Me.Rbtn_Yektarafe = New System.Windows.Forms.RadioButton
        Me.rbtn_Dotarafe = New System.Windows.Forms.RadioButton
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.rbtn_RozeGhabl = New System.Windows.Forms.RadioButton
        Me.rbtn_HamanRoz = New System.Windows.Forms.RadioButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_dis = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_WorkDis = New CS_Component.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmb_PmWorkDis = New VB_Component.ComboBox
        Me.PmWorkDisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label15 = New System.Windows.Forms.Label
        Me.Ts_NafarSat = New VB_Component.TimeSelect
        Me.ts_EzafeKareFormKar = New VB_Component.TimeSelect
        Me.ts_EzafeKarTaradod = New VB_Component.TimeSelect
        Me.Label22 = New System.Windows.Forms.Label
        Me.btn_Cal = New System.Windows.Forms.Button
        Me.Pm_HazineCodeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
        Me.PM_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_WorkDisTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_WorkDisTableAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txt_ProfileTarikh = New System.Windows.Forms.TextBox
        Me.lbl_RozeHafte = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_FormKarTarikh = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_FromKarNo = New CS_Component.TextBox
        Me.txt_Tarikh = New CS_Component.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cbox_IsPm = New System.Windows.Forms.CheckBox
        Me.Acc_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
        Me.cmb_Ashkhas = New VB_Component.ComboBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PmWorkDisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 459)
        Me.gbx_Buttons.Size = New System.Drawing.Size(1049, 56)
        Me.gbx_Buttons.TabIndex = 1
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(945, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.cmb_Ashkhas)
        Me.gbx_Fields.Controls.Add(Me.Cbox_IsPm)
        Me.gbx_Fields.Controls.Add(Me.Panel2)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.btn_Cal)
        Me.gbx_Fields.Controls.Add(Me.ts_EndWork)
        Me.gbx_Fields.Controls.Add(Me.ts_BeginWork)
        Me.gbx_Fields.Controls.Add(Me.ts_ZamaneKhroj)
        Me.gbx_Fields.Controls.Add(Me.Panel12)
        Me.gbx_Fields.Controls.Add(Me.Panel11)
        Me.gbx_Fields.Controls.Add(Me.Label19)
        Me.gbx_Fields.Controls.Add(Me.Label20)
        Me.gbx_Fields.Controls.Add(Me.Label18)
        Me.gbx_Fields.Controls.Add(Me.txt_dis)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_WorkDis)
        Me.gbx_Fields.Controls.Add(Me.Label16)
        Me.gbx_Fields.Controls.Add(Me.cmb_PmWorkDis)
        Me.gbx_Fields.Controls.Add(Me.Label15)
        Me.gbx_Fields.Controls.Add(Me.cmb_HazineCode)
        Me.gbx_Fields.Controls.Add(Me.Cmb_PostTo)
        Me.gbx_Fields.Controls.Add(Me.cmb_Vahed)
        Me.gbx_Fields.Controls.Add(Me.Cmb_PostFrom)
        Me.gbx_Fields.Controls.Add(Me.txt_Distance)
        Me.gbx_Fields.Controls.Add(Me.Label8)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.Label9)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(1049, 416)
        Me.gbx_Fields.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(974, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 18)
        Me.Label9.TabIndex = 181
        Me.Label9.Text = "نام عضو"
        '
        'AccAshkhasBindingSource
        '
        Me.AccAshkhasBindingSource.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.cmb_HazineCode.Location = New System.Drawing.Point(315, 122)
        Me.cmb_HazineCode.Name = "cmb_HazineCode"
        Me.cmb_HazineCode.OpenOnFoucus = True
        Me.cmb_HazineCode.Size = New System.Drawing.Size(194, 26)
        Me.cmb_HazineCode.TabIndex = 2
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
        'Cmb_PostTo
        '
        Me.Cmb_PostTo.AutoComplete = True
        Me.Cmb_PostTo.DataSource = Me.PMPostBindingSource1
        Me.Cmb_PostTo.DisplayMember = "نام پست"
        Me.Cmb_PostTo.EnterStop = True
        Me.Cmb_PostTo.FormattingEnabled = True
        Me.Cmb_PostTo.IsRequired = False
        Me.Cmb_PostTo.LimitedToList = True
        Me.Cmb_PostTo.Location = New System.Drawing.Point(760, 159)
        Me.Cmb_PostTo.Name = "Cmb_PostTo"
        Me.Cmb_PostTo.OpenOnFoucus = True
        Me.Cmb_PostTo.Size = New System.Drawing.Size(194, 26)
        Me.Cmb_PostTo.TabIndex = 4
        Me.Cmb_PostTo.ValueMember = "Srl"
        '
        'PMPostBindingSource1
        '
        Me.PMPostBindingSource1.DataMember = "PM_Post"
        Me.PMPostBindingSource1.DataSource = Me.Ds_Pm
        '
        'cmb_Vahed
        '
        Me.cmb_Vahed.AutoComplete = True
        Me.cmb_Vahed.DataSource = Me.PmVahedBindingSource
        Me.cmb_Vahed.DisplayMember = "نام واحد"
        Me.cmb_Vahed.EnterStop = True
        Me.cmb_Vahed.FormattingEnabled = True
        Me.cmb_Vahed.IsRequired = False
        Me.cmb_Vahed.LimitedToList = True
        Me.cmb_Vahed.Location = New System.Drawing.Point(315, 159)
        Me.cmb_Vahed.Name = "cmb_Vahed"
        Me.cmb_Vahed.OpenOnFoucus = True
        Me.cmb_Vahed.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Vahed.TabIndex = 6
        Me.cmb_Vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'Cmb_PostFrom
        '
        Me.Cmb_PostFrom.AutoComplete = True
        Me.Cmb_PostFrom.DataSource = Me.PMPostBindingSource
        Me.Cmb_PostFrom.DisplayMember = "نام پست"
        Me.Cmb_PostFrom.EnterStop = True
        Me.Cmb_PostFrom.FormattingEnabled = True
        Me.Cmb_PostFrom.IsRequired = False
        Me.Cmb_PostFrom.LimitedToList = True
        Me.Cmb_PostFrom.Location = New System.Drawing.Point(11, 119)
        Me.Cmb_PostFrom.Name = "Cmb_PostFrom"
        Me.Cmb_PostFrom.OpenOnFoucus = True
        Me.Cmb_PostFrom.Size = New System.Drawing.Size(194, 26)
        Me.Cmb_PostFrom.TabIndex = 3
        Me.Cmb_PostFrom.ValueMember = "Srl"
        '
        'PMPostBindingSource
        '
        Me.PMPostBindingSource.DataMember = "PM_Post"
        Me.PMPostBindingSource.DataSource = Me.Ds_Pm
        '
        'txt_Distance
        '
        Me.txt_Distance.CheckExistValueInDb = True
        Me.txt_Distance.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Distance.CurrencyUnit = "ریال"
        Me.txt_Distance.DefaultValue = "0"
        Me.txt_Distance.FillWithMaxInDb = False
        Me.txt_Distance.IsRequired = True
        Me.txt_Distance.Location = New System.Drawing.Point(587, 159)
        Me.txt_Distance.MaxDecimalLength = 2
        Me.txt_Distance.Name = "txt_Distance"
        Me.txt_Distance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Distance.Size = New System.Drawing.Size(67, 26)
        Me.txt_Distance.SpellControl = Nothing
        Me.txt_Distance.TabIndex = 5
        Me.txt_Distance.Tag = "Name"
        Me.txt_Distance.Text = "0"
        Me.txt_Distance.Title = Nothing
        Me.txt_Distance.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Distance.UseForData = True
        Me.txt_Distance.ValidateCheckExistOnEdit = False
        Me.txt_Distance.Value = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(518, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "کد هزینه"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(517, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 186
        Me.Label1.Text = "نام واحد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "محل فعالیت"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(661, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 187
        Me.Label3.Text = "فاصله"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(956, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 189
        Me.Label4.Text = "مبدا حرکت"
        '
        'ts_EndWork
        '
        Me.ts_EndWork.Hour = "00"
        Me.ts_EndWork.HourMaxLen = 4
        Me.ts_EndWork.Location = New System.Drawing.Point(287, 319)
        Me.ts_EndWork.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.ts_EndWork.Minutes = "00"
        Me.ts_EndWork.Name = "ts_EndWork"
        Me.ts_EndWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_EndWork.Second = "00"
        Me.ts_EndWork.Size = New System.Drawing.Size(77, 28)
        Me.ts_EndWork.TabIndex = 13
        Me.ts_EndWork.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_EndWork.Value = "00:00:00"
        '
        'ts_BeginWork
        '
        Me.ts_BeginWork.Hour = "00"
        Me.ts_BeginWork.HourMaxLen = 4
        Me.ts_BeginWork.Location = New System.Drawing.Point(433, 319)
        Me.ts_BeginWork.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ts_BeginWork.Minutes = "00"
        Me.ts_BeginWork.Name = "ts_BeginWork"
        Me.ts_BeginWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_BeginWork.Second = "00"
        Me.ts_BeginWork.Size = New System.Drawing.Size(75, 28)
        Me.ts_BeginWork.TabIndex = 12
        Me.ts_BeginWork.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_BeginWork.Value = "00:00:00"
        '
        'ts_ZamaneKhroj
        '
        Me.ts_ZamaneKhroj.Hour = "00"
        Me.ts_ZamaneKhroj.HourMaxLen = 4
        Me.ts_ZamaneKhroj.Location = New System.Drawing.Point(730, 319)
        Me.ts_ZamaneKhroj.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ts_ZamaneKhroj.Minutes = "00"
        Me.ts_ZamaneKhroj.Name = "ts_ZamaneKhroj"
        Me.ts_ZamaneKhroj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_ZamaneKhroj.Second = "00"
        Me.ts_ZamaneKhroj.Size = New System.Drawing.Size(76, 28)
        Me.ts_ZamaneKhroj.TabIndex = 11
        Me.ts_ZamaneKhroj.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_ZamaneKhroj.Value = "00:00:00"
        '
        'Panel12
        '
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.rbtn_taradodBargasht)
        Me.Panel12.Controls.Add(Me.Rbtn_Yektarafe)
        Me.Panel12.Controls.Add(Me.rbtn_Dotarafe)
        Me.Panel12.Location = New System.Drawing.Point(134, 303)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(144, 87)
        Me.Panel12.TabIndex = 14
        '
        'rbtn_taradodBargasht
        '
        Me.rbtn_taradodBargasht.AutoSize = True
        Me.rbtn_taradodBargasht.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtn_taradodBargasht.Location = New System.Drawing.Point(21, 60)
        Me.rbtn_taradodBargasht.Name = "rbtn_taradodBargasht"
        Me.rbtn_taradodBargasht.Size = New System.Drawing.Size(102, 22)
        Me.rbtn_taradodBargasht.TabIndex = 3
        Me.rbtn_taradodBargasht.Text = "تردد برگشت"
        Me.rbtn_taradodBargasht.UseVisualStyleBackColor = True
        '
        'Rbtn_Yektarafe
        '
        Me.Rbtn_Yektarafe.AutoSize = True
        Me.Rbtn_Yektarafe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rbtn_Yektarafe.Location = New System.Drawing.Point(13, 32)
        Me.Rbtn_Yektarafe.Name = "Rbtn_Yektarafe"
        Me.Rbtn_Yektarafe.Size = New System.Drawing.Size(110, 22)
        Me.Rbtn_Yektarafe.TabIndex = 1
        Me.Rbtn_Yektarafe.Text = "تردد یک طرفه"
        Me.Rbtn_Yektarafe.UseVisualStyleBackColor = True
        '
        'rbtn_Dotarafe
        '
        Me.rbtn_Dotarafe.AutoSize = True
        Me.rbtn_Dotarafe.Checked = True
        Me.rbtn_Dotarafe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtn_Dotarafe.Location = New System.Drawing.Point(19, 3)
        Me.rbtn_Dotarafe.Name = "rbtn_Dotarafe"
        Me.rbtn_Dotarafe.Size = New System.Drawing.Size(104, 22)
        Me.rbtn_Dotarafe.TabIndex = 0
        Me.rbtn_Dotarafe.TabStop = True
        Me.rbtn_Dotarafe.Text = "تردد دو طرفه"
        Me.rbtn_Dotarafe.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.rbtn_RozeGhabl)
        Me.Panel11.Controls.Add(Me.rbtn_HamanRoz)
        Me.Panel11.Location = New System.Drawing.Point(814, 303)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(144, 62)
        Me.Panel11.TabIndex = 10
        '
        'rbtn_RozeGhabl
        '
        Me.rbtn_RozeGhabl.AutoSize = True
        Me.rbtn_RozeGhabl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtn_RozeGhabl.Location = New System.Drawing.Point(39, 32)
        Me.rbtn_RozeGhabl.Name = "rbtn_RozeGhabl"
        Me.rbtn_RozeGhabl.Size = New System.Drawing.Size(69, 22)
        Me.rbtn_RozeGhabl.TabIndex = 1
        Me.rbtn_RozeGhabl.TabStop = True
        Me.rbtn_RozeGhabl.Text = "روز قبل"
        Me.rbtn_RozeGhabl.UseVisualStyleBackColor = True
        '
        'rbtn_HamanRoz
        '
        Me.rbtn_HamanRoz.AutoSize = True
        Me.rbtn_HamanRoz.Checked = True
        Me.rbtn_HamanRoz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtn_HamanRoz.Location = New System.Drawing.Point(26, 2)
        Me.rbtn_HamanRoz.Name = "rbtn_HamanRoz"
        Me.rbtn_HamanRoz.Size = New System.Drawing.Size(80, 22)
        Me.rbtn_HamanRoz.TabIndex = 0
        Me.rbtn_HamanRoz.TabStop = True
        Me.rbtn_HamanRoz.Text = "همان روز"
        Me.rbtn_HamanRoz.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(373, 325)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 18)
        Me.Label19.TabIndex = 205
        Me.Label19.Text = "پایان کار"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(965, 319)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 18)
        Me.Label20.TabIndex = 204
        Me.Label20.Text = "زمان خروج"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(515, 325)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 18)
        Me.Label18.TabIndex = 206
        Me.Label18.Text = "شروع کار"
        '
        'txt_dis
        '
        Me.txt_dis.CheckExistValueInDb = True
        Me.txt_dis.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_dis.CurrencyUnit = "ریال"
        Me.txt_dis.DefaultValue = ""
        Me.txt_dis.FillWithMaxInDb = False
        Me.txt_dis.IsRequired = True
        Me.txt_dis.Location = New System.Drawing.Point(587, 232)
        Me.txt_dis.MaxDecimalLength = 2
        Me.txt_dis.Multiline = True
        Me.txt_dis.Name = "txt_dis"
        Me.txt_dis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_dis.Size = New System.Drawing.Size(369, 64)
        Me.txt_dis.SpellControl = Nothing
        Me.txt_dis.TabIndex = 8
        Me.txt_dis.Tag = ""
        Me.txt_dis.Title = Nothing
        Me.txt_dis.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_dis.UseForData = True
        Me.txt_dis.ValidateCheckExistOnEdit = False
        Me.txt_dis.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(963, 236)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 18)
        Me.Label17.TabIndex = 203
        Me.Label17.Text = "ملاحظات"
        '
        'txt_WorkDis
        '
        Me.txt_WorkDis.CheckExistValueInDb = True
        Me.txt_WorkDis.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_WorkDis.CurrencyUnit = "ریال"
        Me.txt_WorkDis.DefaultValue = ""
        Me.txt_WorkDis.FillWithMaxInDb = False
        Me.txt_WorkDis.IsRequired = True
        Me.txt_WorkDis.Location = New System.Drawing.Point(11, 197)
        Me.txt_WorkDis.MaxDecimalLength = 2
        Me.txt_WorkDis.Multiline = True
        Me.txt_WorkDis.Name = "txt_WorkDis"
        Me.txt_WorkDis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_WorkDis.Size = New System.Drawing.Size(498, 98)
        Me.txt_WorkDis.SpellControl = Nothing
        Me.txt_WorkDis.TabIndex = 9
        Me.txt_WorkDis.Tag = ""
        Me.txt_WorkDis.Title = Nothing
        Me.txt_WorkDis.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_WorkDis.UseForData = True
        Me.txt_WorkDis.ValidateCheckExistOnEdit = False
        Me.txt_WorkDis.Value = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(517, 201)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 18)
        Me.Label16.TabIndex = 202
        Me.Label16.Text = "شرح کار"
        '
        'cmb_PmWorkDis
        '
        Me.cmb_PmWorkDis.AutoComplete = True
        Me.cmb_PmWorkDis.DataSource = Me.PmWorkDisBindingSource
        Me.cmb_PmWorkDis.DisplayMember = "توضیح کار"
        Me.cmb_PmWorkDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PmWorkDis.EnterStop = True
        Me.cmb_PmWorkDis.FormattingEnabled = True
        Me.cmb_PmWorkDis.IsRequired = False
        Me.cmb_PmWorkDis.LimitedToList = True
        Me.cmb_PmWorkDis.Location = New System.Drawing.Point(587, 196)
        Me.cmb_PmWorkDis.Name = "cmb_PmWorkDis"
        Me.cmb_PmWorkDis.OpenOnFoucus = True
        Me.cmb_PmWorkDis.Size = New System.Drawing.Size(367, 26)
        Me.cmb_PmWorkDis.TabIndex = 7
        Me.cmb_PmWorkDis.ValueMember = "Srl"
        '
        'PmWorkDisBindingSource
        '
        Me.PmWorkDisBindingSource.DataMember = "Pm_WorkDis"
        Me.PmWorkDisBindingSource.DataSource = Me.Ds_Pm
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(963, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 201
        Me.Label15.Text = "موضوع کار"
        '
        'Ts_NafarSat
        '
        Me.Ts_NafarSat.Enabled = False
        Me.Ts_NafarSat.Hour = "00"
        Me.Ts_NafarSat.HourMaxLen = 4
        Me.Ts_NafarSat.Location = New System.Drawing.Point(249, 6)
        Me.Ts_NafarSat.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Ts_NafarSat.Minutes = "00"
        Me.Ts_NafarSat.Name = "Ts_NafarSat"
        Me.Ts_NafarSat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Ts_NafarSat.Second = "00"
        Me.Ts_NafarSat.Size = New System.Drawing.Size(88, 28)
        Me.Ts_NafarSat.TabIndex = 209
        Me.Ts_NafarSat.TabStop = False
        Me.Ts_NafarSat.time = System.TimeSpan.Parse("00:00:00")
        Me.Ts_NafarSat.Value = "00:00:00"
        '
        'ts_EzafeKareFormKar
        '
        Me.ts_EzafeKareFormKar.Enabled = False
        Me.ts_EzafeKareFormKar.Hour = "00"
        Me.ts_EzafeKareFormKar.HourMaxLen = 4
        Me.ts_EzafeKareFormKar.Location = New System.Drawing.Point(134, 6)
        Me.ts_EzafeKareFormKar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ts_EzafeKareFormKar.Minutes = "00"
        Me.ts_EzafeKareFormKar.Name = "ts_EzafeKareFormKar"
        Me.ts_EzafeKareFormKar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_EzafeKareFormKar.Second = "00"
        Me.ts_EzafeKareFormKar.Size = New System.Drawing.Size(88, 28)
        Me.ts_EzafeKareFormKar.TabIndex = 208
        Me.ts_EzafeKareFormKar.TabStop = False
        Me.ts_EzafeKareFormKar.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_EzafeKareFormKar.Value = "00:00:00"
        '
        'ts_EzafeKarTaradod
        '
        Me.ts_EzafeKarTaradod.Enabled = False
        Me.ts_EzafeKarTaradod.Hour = "00"
        Me.ts_EzafeKarTaradod.HourMaxLen = 4
        Me.ts_EzafeKarTaradod.Location = New System.Drawing.Point(20, 6)
        Me.ts_EzafeKarTaradod.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ts_EzafeKarTaradod.Minutes = "00"
        Me.ts_EzafeKarTaradod.Name = "ts_EzafeKarTaradod"
        Me.ts_EzafeKarTaradod.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_EzafeKarTaradod.Second = "00"
        Me.ts_EzafeKarTaradod.Size = New System.Drawing.Size(87, 28)
        Me.ts_EzafeKarTaradod.TabIndex = 207
        Me.ts_EzafeKarTaradod.TabStop = False
        Me.ts_EzafeKarTaradod.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_EzafeKarTaradod.Value = "00:00:00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(373, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 18)
        Me.Label22.TabIndex = 210
        Me.Label22.Text = "جمع"
        '
        'btn_Cal
        '
        Me.btn_Cal.Location = New System.Drawing.Point(29, 332)
        Me.btn_Cal.Name = "btn_Cal"
        Me.btn_Cal.Size = New System.Drawing.Size(86, 30)
        Me.btn_Cal.TabIndex = 15
        Me.btn_Cal.Text = "محاسبه"
        Me.btn_Cal.UseVisualStyleBackColor = True
        '
        'Pm_HazineCodeTableAdapter
        '
        Me.Pm_HazineCodeTableAdapter.ClearBeforeFill = True
        '
        'PM_PostTableAdapter
        '
        Me.PM_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_WorkDisTableAdapter
        '
        Me.Pm_WorkDisTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ts_EzafeKarTaradod)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Ts_NafarSat)
        Me.Panel1.Controls.Add(Me.ts_EzafeKareFormKar)
        Me.Panel1.Location = New System.Drawing.Point(313, 364)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 41)
        Me.Panel1.TabIndex = 212
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_ProfileTarikh)
        Me.Panel2.Controls.Add(Me.lbl_RozeHafte)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_FormKarTarikh)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_FromKarNo)
        Me.Panel2.Controls.Add(Me.txt_Tarikh)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(29, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(990, 82)
        Me.Panel2.TabIndex = 0
        '
        'txt_ProfileTarikh
        '
        Me.txt_ProfileTarikh.Enabled = False
        Me.txt_ProfileTarikh.Location = New System.Drawing.Point(15, 6)
        Me.txt_ProfileTarikh.Name = "txt_ProfileTarikh"
        Me.txt_ProfileTarikh.ReadOnly = True
        Me.txt_ProfileTarikh.Size = New System.Drawing.Size(344, 26)
        Me.txt_ProfileTarikh.TabIndex = 214
        Me.txt_ProfileTarikh.Text = "پروفایل تاریخ فرم کار"
        '
        'lbl_RozeHafte
        '
        Me.lbl_RozeHafte.Enabled = False
        Me.lbl_RozeHafte.Location = New System.Drawing.Point(365, 6)
        Me.lbl_RozeHafte.Name = "lbl_RozeHafte"
        Me.lbl_RozeHafte.ReadOnly = True
        Me.lbl_RozeHafte.Size = New System.Drawing.Size(99, 26)
        Me.lbl_RozeHafte.TabIndex = 213
        Me.lbl_RozeHafte.Text = "روز هفته"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(890, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "شماره فرم کار"
        '
        'txt_FormKarTarikh
        '
        Me.txt_FormKarTarikh.CheckExistValueInDb = False
        Me.txt_FormKarTarikh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FormKarTarikh.CurrencyUnit = "ریال"
        Me.txt_FormKarTarikh.DefaultValue = ""
        Me.txt_FormKarTarikh.FillWithMaxInDb = False
        Me.txt_FormKarTarikh.IsRequired = True
        Me.txt_FormKarTarikh.Location = New System.Drawing.Point(474, 44)
        Me.txt_FormKarTarikh.MaxDecimalLength = 2
        Me.txt_FormKarTarikh.Name = "txt_FormKarTarikh"
        Me.txt_FormKarTarikh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FormKarTarikh.Size = New System.Drawing.Size(150, 26)
        Me.txt_FormKarTarikh.SpellControl = Nothing
        Me.txt_FormKarTarikh.TabIndex = 3
        Me.txt_FormKarTarikh.TabStop = False
        Me.txt_FormKarTarikh.Tag = ""
        Me.txt_FormKarTarikh.Title = Nothing
        Me.txt_FormKarTarikh.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FormKarTarikh.UseForData = True
        Me.txt_FormKarTarikh.ValidateCheckExistOnEdit = False
        Me.txt_FormKarTarikh.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(631, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "تاریخ فرم کار"
        '
        'txt_FromKarNo
        '
        Me.txt_FromKarNo.CheckExistValueInDb = True
        Me.txt_FromKarNo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromKarNo.CurrencyUnit = "ریال"
        Me.txt_FromKarNo.DefaultValue = ""
        Me.txt_FromKarNo.FillWithMaxInDb = False
        Me.txt_FromKarNo.IsRequired = True
        Me.txt_FromKarNo.Location = New System.Drawing.Point(725, 10)
        Me.txt_FromKarNo.MaxDecimalLength = 2
        Me.txt_FromKarNo.Name = "txt_FromKarNo"
        Me.txt_FromKarNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_FromKarNo.Size = New System.Drawing.Size(157, 26)
        Me.txt_FromKarNo.SpellControl = Nothing
        Me.txt_FromKarNo.TabIndex = 2
        Me.txt_FromKarNo.Tag = ""
        Me.txt_FromKarNo.Title = Nothing
        Me.txt_FromKarNo.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_FromKarNo.UseForData = True
        Me.txt_FromKarNo.ValidateCheckExistOnEdit = False
        Me.txt_FromKarNo.Value = ""
        '
        'txt_Tarikh
        '
        Me.txt_Tarikh.CheckExistValueInDb = False
        Me.txt_Tarikh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Tarikh.CurrencyUnit = "ریال"
        Me.txt_Tarikh.DefaultValue = ""
        Me.txt_Tarikh.FillWithMaxInDb = False
        Me.txt_Tarikh.IsRequired = True
        Me.txt_Tarikh.Location = New System.Drawing.Point(474, 6)
        Me.txt_Tarikh.MaxDecimalLength = 2
        Me.txt_Tarikh.Name = "txt_Tarikh"
        Me.txt_Tarikh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Tarikh.Size = New System.Drawing.Size(150, 26)
        Me.txt_Tarikh.SpellControl = Nothing
        Me.txt_Tarikh.TabIndex = 1
        Me.txt_Tarikh.TabStop = False
        Me.txt_Tarikh.Tag = ""
        Me.txt_Tarikh.Title = Nothing
        Me.txt_Tarikh.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_Tarikh.UseForData = True
        Me.txt_Tarikh.ValidateCheckExistOnEdit = False
        Me.txt_Tarikh.Value = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(631, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "تاریخ ثبت"
        '
        'Cbox_IsPm
        '
        Me.Cbox_IsPm.AutoSize = True
        Me.Cbox_IsPm.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PmWorkDisBindingSource, "IsPm", True))
        Me.Cbox_IsPm.Location = New System.Drawing.Point(1133, 342)
        Me.Cbox_IsPm.Name = "Cbox_IsPm"
        Me.Cbox_IsPm.Size = New System.Drawing.Size(15, 14)
        Me.Cbox_IsPm.TabIndex = 214
        Me.Cbox_IsPm.UseVisualStyleBackColor = True
        '
        'Acc_AshkhasTableAdapter
        '
        Me.Acc_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'cmb_Ashkhas
        '
        Me.cmb_Ashkhas.AutoComplete = True
        Me.cmb_Ashkhas.DataSource = Me.AccAshkhasBindingSource
        Me.cmb_Ashkhas.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Ashkhas.EnterStop = True
        Me.cmb_Ashkhas.FormattingEnabled = True
        Me.cmb_Ashkhas.IsRequired = False
        Me.cmb_Ashkhas.LimitedToList = True
        Me.cmb_Ashkhas.Location = New System.Drawing.Point(760, 122)
        Me.cmb_Ashkhas.Name = "cmb_Ashkhas"
        Me.cmb_Ashkhas.OpenOnFoucus = False
        Me.cmb_Ashkhas.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Ashkhas.TabIndex = 215
        Me.cmb_Ashkhas.ValueMember = "Srl"
        '
        'Frm_WorkForm_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1076, 555)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_WorkForm_Edit"
        Me.Text = "ویرایش فردی اطلاعات فرم کار"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PmWorkDisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_HazineCode As VB_Component.ComboBox
    Friend WithEvents Cmb_PostTo As VB_Component.ComboBox
    Friend WithEvents cmb_Vahed As VB_Component.ComboBox
    Friend WithEvents Cmb_PostFrom As VB_Component.ComboBox
    Friend WithEvents txt_Distance As CS_Component.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ts_EndWork As VB_Component.TimeSelect
    Friend WithEvents ts_BeginWork As VB_Component.TimeSelect
    Friend WithEvents ts_ZamaneKhroj As VB_Component.TimeSelect
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Rbtn_Yektarafe As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Dotarafe As System.Windows.Forms.RadioButton
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents rbtn_RozeGhabl As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_HamanRoz As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_dis As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_WorkDis As CS_Component.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmb_PmWorkDis As VB_Component.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Ts_NafarSat As VB_Component.TimeSelect
    Friend WithEvents ts_EzafeKareFormKar As VB_Component.TimeSelect
    Friend WithEvents ts_EzafeKarTaradod As VB_Component.TimeSelect
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btn_Cal As System.Windows.Forms.Button
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmHazineCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_HazineCodeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PM_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.PM_PostTableAdapter
    Friend WithEvents PMPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmWorkDisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_WorkDisTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_WorkDisTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_Tarikh As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_FormKarTarikh As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_FromKarNo As CS_Component.TextBox
    Friend WithEvents Cbox_IsPm As System.Windows.Forms.CheckBox
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents cmb_Ashkhas As VB_Component.ComboBox
    Friend WithEvents rbtn_taradodBargasht As System.Windows.Forms.RadioButton
    Friend WithEvents txt_ProfileTarikh As System.Windows.Forms.TextBox
    Friend WithEvents lbl_RozeHafte As System.Windows.Forms.TextBox
End Class
