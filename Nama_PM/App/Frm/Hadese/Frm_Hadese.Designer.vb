<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Hadese
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Hadese))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txt_ReportNo = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ts_Sat = New VB_Component.TimeSelect
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Tarikh = New CS_Component.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBox1 = New VB_Component.ComboBox
        Me.PmHadeseSharayetBorozBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_Kelidi = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ComboBox3 = New VB_Component.ComboBox
        Me.PmHadeseElatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_SharhHadese = New CS_Component.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_EghdamatAvalie = New CS_Component.TextBox
        Me.txt_ElatGostareshHadese = New CS_Component.TextBox
        Me.chk_GostareshHadese = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmb_Pm_Hadese_Amalkard = New VB_Component.ComboBox
        Me.PmHadeseAmalkardSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_DastorModir = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_PishnahadEslahi = New CS_Component.TextBox
        Me.TextBox9 = New CS_Component.TextBox
        Me.DataGridView3 = New CS_Component.DataGridView
        Me.پیشنهاداصلاحیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmHadesePishnahadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Remove_Pishnahad = New System.Windows.Forms.PictureBox
        Me.btn_Add_Pishnahad = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_SelectDEvice = New System.Windows.Forms.Button
        Me.btn_Add_DEvice = New System.Windows.Forms.PictureBox
        Me.btn_Remove_Device = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.نامقطعهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعخسارتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مقدارخاموشیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مدتخروجDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Srl_Pm_Hadese_KhesaratDevice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Srl_Pm_Hadese_KhesaratType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmHadeseKhesaratBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Device = New VB_Component.ComboBox
        Me.PmHadeseKhesaratTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Hour = New CS_Component.TextBox
        Me.txt_Min = New CS_Component.TextBox
        Me.tbox_ZamaneKhamoshi = New CS_Component.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Srl_DeviceKhesarat = New CS_Component.TextBox
        Me.txt_DeviceKhesaratName = New CS_Component.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmb_PmPost = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmb_Pm_Group = New VB_Component.ComboBox
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_NatijeBarasi = New CS_Component.TextBox
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_Hadese_KhesaratTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratTableAdapter
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Pm_Hadese_PishnahadTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_PishnahadTableAdapter
        Me.PmHadeseKhesaratDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Hadese_KhesaratDeviceTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
        Me.Pm_Hadese_ElatTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_ElatTableAdapter
        Me.Pm_Hadese_SharayetBorozTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_SharayetBorozTableAdapter
        Me.Pm_Hadese_KhesaratTypeTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratTypeTableAdapter
        Me.Pm_Hadese_AmalkardSystemTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_AmalkardSystemTableAdapter
        Me.cmb_VAhed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_AllVahed = New System.Windows.Forms.CheckBox
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.PmFindGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_FindGroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_FindGroupTableAdapter
        Me.btn_SHow = New System.Windows.Forms.PictureBox
        Me.btn_Before = New System.Windows.Forms.PictureBox
        Me.btn_Next = New System.Windows.Forms.PictureBox
        Me.lb_Posttype = New System.Windows.Forms.Label
        Me.rbt_Line = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.cmb_Pm_Line = New VB_Component.ComboBox
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PmHadeseSharayetBorozBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseElatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseAmalkardSystemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadesePishnahadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Remove_Pishnahad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Add_Pishnahad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_Add_DEvice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Remove_Device, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmFindGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_SHow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 638)
        Me.gbx_Buttons.Size = New System.Drawing.Size(1072, 53)
        Me.gbx_Buttons.TabIndex = 1
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 18)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 27)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(968, 18)
        Me.btn_Save.Size = New System.Drawing.Size(91, 27)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.cmb_Pm_Line)
        Me.gbx_Fields.Controls.Add(Me.RadioButton1)
        Me.gbx_Fields.Controls.Add(Me.rbt_Line)
        Me.gbx_Fields.Controls.Add(Me.btn_SHow)
        Me.gbx_Fields.Controls.Add(Me.btn_Before)
        Me.gbx_Fields.Controls.Add(Me.btn_Next)
        Me.gbx_Fields.Controls.Add(Me.chk_AllVahed)
        Me.gbx_Fields.Controls.Add(Me.cmb_VAhed)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.btn_Add_Pishnahad)
        Me.gbx_Fields.Controls.Add(Me.btn_Remove_Pishnahad)
        Me.gbx_Fields.Controls.Add(Me.txt_Kelidi)
        Me.gbx_Fields.Controls.Add(Me.Label9)
        Me.gbx_Fields.Controls.Add(Me.cmb_PmPost)
        Me.gbx_Fields.Controls.Add(Me.DataGridView3)
        Me.gbx_Fields.Controls.Add(Me.chk_GostareshHadese)
        Me.gbx_Fields.Controls.Add(Me.cmb_Pm_Group)
        Me.gbx_Fields.Controls.Add(Me.cmb_Pm_Hadese_Amalkard)
        Me.gbx_Fields.Controls.Add(Me.ComboBox3)
        Me.gbx_Fields.Controls.Add(Me.ComboBox1)
        Me.gbx_Fields.Controls.Add(Me.lb_Posttype)
        Me.gbx_Fields.Controls.Add(Me.ts_Sat)
        Me.gbx_Fields.Controls.Add(Me.txt_ElatGostareshHadese)
        Me.gbx_Fields.Controls.Add(Me.Txt_ReportNo)
        Me.gbx_Fields.Controls.Add(Me.txt_PishnahadEslahi)
        Me.gbx_Fields.Controls.Add(Me.TextBox9)
        Me.gbx_Fields.Controls.Add(Me.txt_NatijeBarasi)
        Me.gbx_Fields.Controls.Add(Me.txt_DastorModir)
        Me.gbx_Fields.Controls.Add(Me.txt_EghdamatAvalie)
        Me.gbx_Fields.Controls.Add(Me.txt_SharhHadese)
        Me.gbx_Fields.Controls.Add(Me.Label13)
        Me.gbx_Fields.Controls.Add(Me.txt_Tarikh)
        Me.gbx_Fields.Controls.Add(Me.Label12)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.Label19)
        Me.gbx_Fields.Controls.Add(Me.Label18)
        Me.gbx_Fields.Controls.Add(Me.Label16)
        Me.gbx_Fields.Controls.Add(Me.Label14)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label11)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label7)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 38)
        Me.gbx_Fields.Size = New System.Drawing.Size(1072, 598)
        Me.gbx_Fields.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(961, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره گزارش"
        '
        'Txt_ReportNo
        '
        Me.Txt_ReportNo.CheckExistValueInDb = False
        Me.Txt_ReportNo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_ReportNo.CurrencyUnit = "ریال"
        Me.Txt_ReportNo.DefaultValue = ""
        Me.Txt_ReportNo.FillWithMaxInDb = False
        Me.Txt_ReportNo.IsRequired = True
        Me.Txt_ReportNo.Location = New System.Drawing.Point(871, 16)
        Me.Txt_ReportNo.MaxDecimalLength = 2
        Me.Txt_ReportNo.Name = "Txt_ReportNo"
        Me.Txt_ReportNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_ReportNo.Size = New System.Drawing.Size(88, 24)
        Me.Txt_ReportNo.SpellControl = Nothing
        Me.Txt_ReportNo.TabIndex = 0
        Me.Txt_ReportNo.Tag = "ReportNo"
        Me.Txt_ReportNo.Title = Nothing
        Me.Txt_ReportNo.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.Txt_ReportNo.UseForData = True
        Me.Txt_ReportNo.ValidateCheckExistOnEdit = False
        Me.Txt_ReportNo.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(680, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ساعت حادثه"
        '
        'ts_Sat
        '
        Me.ts_Sat.Hour = "0"
        Me.ts_Sat.HourMaxLen = 4
        Me.ts_Sat.Location = New System.Drawing.Point(576, 18)
        Me.ts_Sat.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.ts_Sat.Minutes = "0"
        Me.ts_Sat.Name = "ts_Sat"
        Me.ts_Sat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_Sat.Second = "00"
        Me.ts_Sat.Size = New System.Drawing.Size(102, 30)
        Me.ts_Sat.TabIndex = 1
        Me.ts_Sat.Tag = "Sat"
        Me.ts_Sat.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_Sat.Value = "0:0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "تاریخ حادثه"
        '
        'txt_Tarikh
        '
        Me.txt_Tarikh.CheckExistValueInDb = False
        Me.txt_Tarikh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Tarikh.CurrencyUnit = "ریال"
        Me.txt_Tarikh.DefaultValue = ""
        Me.txt_Tarikh.FillWithMaxInDb = False
        Me.txt_Tarikh.IsRequired = True
        Me.txt_Tarikh.Location = New System.Drawing.Point(283, 19)
        Me.txt_Tarikh.MaxDecimalLength = 2
        Me.txt_Tarikh.Name = "txt_Tarikh"
        Me.txt_Tarikh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Tarikh.Size = New System.Drawing.Size(149, 24)
        Me.txt_Tarikh.SpellControl = Nothing
        Me.txt_Tarikh.TabIndex = 2
        Me.txt_Tarikh.TabStop = False
        Me.txt_Tarikh.Tag = "Tarikh"
        Me.txt_Tarikh.Title = Nothing
        Me.txt_Tarikh.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_Tarikh.UseForData = True
        Me.txt_Tarikh.ValidateCheckExistOnEdit = False
        Me.txt_Tarikh.Value = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(961, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "شرایط بروز حادثه"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoComplete = True
        Me.ComboBox1.DataSource = Me.PmHadeseSharayetBorozBindingSource
        Me.ComboBox1.DisplayMember = "شرایط بروز حادثه"
        Me.ComboBox1.EnterStop = True
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IsRequired = False
        Me.ComboBox1.LimitedToList = True
        Me.ComboBox1.Location = New System.Drawing.Point(802, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.OpenOnFoucus = True
        Me.ComboBox1.Size = New System.Drawing.Size(157, 25)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Tag = "Srl_Pm_Hadese_SharayetBoroz"
        Me.ComboBox1.ValueMember = "Srl"
        '
        'PmHadeseSharayetBorozBindingSource
        '
        Me.PmHadeseSharayetBorozBindingSource.DataMember = "Pm_Hadese_SharayetBoroz"
        Me.PmHadeseSharayetBorozBindingSource.DataSource = Me.Ds_Hadese
        '
        'Ds_Hadese
        '
        Me.Ds_Hadese.DataSetName = "Ds_Hadese"
        Me.Ds_Hadese.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(431, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "کلمات کلیدی"
        '
        'txt_Kelidi
        '
        Me.txt_Kelidi.CheckExistValueInDb = False
        Me.txt_Kelidi.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Kelidi.CurrencyUnit = "ریال"
        Me.txt_Kelidi.DefaultValue = ""
        Me.txt_Kelidi.FillWithMaxInDb = False
        Me.txt_Kelidi.IsRequired = False
        Me.txt_Kelidi.Location = New System.Drawing.Point(283, 46)
        Me.txt_Kelidi.MaxDecimalLength = 2
        Me.txt_Kelidi.Name = "txt_Kelidi"
        Me.txt_Kelidi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Kelidi.Size = New System.Drawing.Size(149, 24)
        Me.txt_Kelidi.SpellControl = Nothing
        Me.txt_Kelidi.TabIndex = 5
        Me.txt_Kelidi.Tag = "Kelidi"
        Me.txt_Kelidi.Title = Nothing
        Me.txt_Kelidi.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Kelidi.UseForData = True
        Me.txt_Kelidi.ValidateCheckExistOnEdit = False
        Me.txt_Kelidi.Value = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(682, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "علت بروز حادثه"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoComplete = True
        Me.ComboBox3.DataSource = Me.PmHadeseElatBindingSource
        Me.ComboBox3.DisplayMember = "علت حادثه"
        Me.ComboBox3.EnterStop = True
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.IsRequired = False
        Me.ComboBox3.LimitedToList = True
        Me.ComboBox3.Location = New System.Drawing.Point(517, 46)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.OpenOnFoucus = True
        Me.ComboBox3.Size = New System.Drawing.Size(161, 25)
        Me.ComboBox3.TabIndex = 3
        Me.ComboBox3.Tag = "Srl_PM_Hadese_Elat"
        Me.ComboBox3.ValueMember = "Srl"
        '
        'PmHadeseElatBindingSource
        '
        Me.PmHadeseElatBindingSource.DataMember = "Pm_Hadese_Elat"
        Me.PmHadeseElatBindingSource.DataSource = Me.Ds_Hadese
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(950, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "شرح دقیق حادثه"
        '
        'txt_SharhHadese
        '
        Me.txt_SharhHadese.CheckExistValueInDb = False
        Me.txt_SharhHadese.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SharhHadese.CurrencyUnit = "ریال"
        Me.txt_SharhHadese.DefaultValue = ""
        Me.txt_SharhHadese.FillWithMaxInDb = False
        Me.txt_SharhHadese.IsRequired = True
        Me.txt_SharhHadese.Location = New System.Drawing.Point(11, 206)
        Me.txt_SharhHadese.MaxDecimalLength = 2
        Me.txt_SharhHadese.Multiline = True
        Me.txt_SharhHadese.Name = "txt_SharhHadese"
        Me.txt_SharhHadese.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SharhHadese.Size = New System.Drawing.Size(931, 75)
        Me.txt_SharhHadese.SpellControl = Nothing
        Me.txt_SharhHadese.TabIndex = 8
        Me.txt_SharhHadese.Tag = ""
        Me.txt_SharhHadese.Title = Nothing
        Me.txt_SharhHadese.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SharhHadese.UseForData = True
        Me.txt_SharhHadese.ValidateCheckExistOnEdit = False
        Me.txt_SharhHadese.Value = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(950, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(113, 34)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "اقدامات اولیه انجام" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "شده"
        '
        'txt_EghdamatAvalie
        '
        Me.txt_EghdamatAvalie.CheckExistValueInDb = False
        Me.txt_EghdamatAvalie.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EghdamatAvalie.CurrencyUnit = "ریال"
        Me.txt_EghdamatAvalie.DefaultValue = ""
        Me.txt_EghdamatAvalie.FillWithMaxInDb = False
        Me.txt_EghdamatAvalie.IsRequired = False
        Me.txt_EghdamatAvalie.Location = New System.Drawing.Point(11, 287)
        Me.txt_EghdamatAvalie.MaxDecimalLength = 2
        Me.txt_EghdamatAvalie.Multiline = True
        Me.txt_EghdamatAvalie.Name = "txt_EghdamatAvalie"
        Me.txt_EghdamatAvalie.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_EghdamatAvalie.Size = New System.Drawing.Size(931, 40)
        Me.txt_EghdamatAvalie.SpellControl = Nothing
        Me.txt_EghdamatAvalie.TabIndex = 9
        Me.txt_EghdamatAvalie.Tag = ""
        Me.txt_EghdamatAvalie.Title = Nothing
        Me.txt_EghdamatAvalie.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_EghdamatAvalie.UseForData = True
        Me.txt_EghdamatAvalie.ValidateCheckExistOnEdit = False
        Me.txt_EghdamatAvalie.Value = ""
        '
        'txt_ElatGostareshHadese
        '
        Me.txt_ElatGostareshHadese.CheckExistValueInDb = False
        Me.txt_ElatGostareshHadese.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ElatGostareshHadese.CurrencyUnit = "ریال"
        Me.txt_ElatGostareshHadese.DefaultValue = ""
        Me.txt_ElatGostareshHadese.FillWithMaxInDb = False
        Me.txt_ElatGostareshHadese.IsRequired = False
        Me.txt_ElatGostareshHadese.Location = New System.Drawing.Point(11, 333)
        Me.txt_ElatGostareshHadese.MaxDecimalLength = 2
        Me.txt_ElatGostareshHadese.Multiline = True
        Me.txt_ElatGostareshHadese.Name = "txt_ElatGostareshHadese"
        Me.txt_ElatGostareshHadese.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ElatGostareshHadese.Size = New System.Drawing.Size(778, 40)
        Me.txt_ElatGostareshHadese.SpellControl = Nothing
        Me.txt_ElatGostareshHadese.TabIndex = 10
        Me.txt_ElatGostareshHadese.Tag = ""
        Me.txt_ElatGostareshHadese.Title = Nothing
        Me.txt_ElatGostareshHadese.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ElatGostareshHadese.UseForData = True
        Me.txt_ElatGostareshHadese.ValidateCheckExistOnEdit = False
        Me.txt_ElatGostareshHadese.Value = ""
        '
        'chk_GostareshHadese
        '
        Me.chk_GostareshHadese.AutoSize = True
        Me.chk_GostareshHadese.Location = New System.Drawing.Point(793, 333)
        Me.chk_GostareshHadese.Name = "chk_GostareshHadese"
        Me.chk_GostareshHadese.Size = New System.Drawing.Size(251, 21)
        Me.chk_GostareshHadese.TabIndex = 18
        Me.chk_GostareshHadese.Tag = "GostareshHadese"
        Me.chk_GostareshHadese.Text = "آیا حادثه گسترش داشته است - علت :"
        Me.chk_GostareshHadese.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(798, 381)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(155, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "عملکرد سیستم حفاظتی"
        '
        'cmb_Pm_Hadese_Amalkard
        '
        Me.cmb_Pm_Hadese_Amalkard.AutoComplete = True
        Me.cmb_Pm_Hadese_Amalkard.DataSource = Me.PmHadeseAmalkardSystemBindingSource
        Me.cmb_Pm_Hadese_Amalkard.DisplayMember = "عملکرد سیستم"
        Me.cmb_Pm_Hadese_Amalkard.EnterStop = True
        Me.cmb_Pm_Hadese_Amalkard.FormattingEnabled = True
        Me.cmb_Pm_Hadese_Amalkard.IsRequired = False
        Me.cmb_Pm_Hadese_Amalkard.LimitedToList = True
        Me.cmb_Pm_Hadese_Amalkard.Location = New System.Drawing.Point(549, 379)
        Me.cmb_Pm_Hadese_Amalkard.Name = "cmb_Pm_Hadese_Amalkard"
        Me.cmb_Pm_Hadese_Amalkard.OpenOnFoucus = True
        Me.cmb_Pm_Hadese_Amalkard.Size = New System.Drawing.Size(242, 25)
        Me.cmb_Pm_Hadese_Amalkard.TabIndex = 11
        Me.cmb_Pm_Hadese_Amalkard.Tag = "Srl_Pm_Hadese_Amalkard"
        Me.cmb_Pm_Hadese_Amalkard.ValueMember = "Srl"
        '
        'PmHadeseAmalkardSystemBindingSource
        '
        Me.PmHadeseAmalkardSystemBindingSource.DataMember = "Pm_Hadese_AmalkardSystem"
        Me.PmHadeseAmalkardSystemBindingSource.DataSource = Me.Ds_Hadese
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(950, 475)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "دستور مدیر"
        '
        'txt_DastorModir
        '
        Me.txt_DastorModir.CheckExistValueInDb = False
        Me.txt_DastorModir.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DastorModir.CurrencyUnit = "ریال"
        Me.txt_DastorModir.DefaultValue = ""
        Me.txt_DastorModir.FillWithMaxInDb = False
        Me.txt_DastorModir.IsRequired = False
        Me.txt_DastorModir.Location = New System.Drawing.Point(11, 457)
        Me.txt_DastorModir.MaxDecimalLength = 2
        Me.txt_DastorModir.Multiline = True
        Me.txt_DastorModir.Name = "txt_DastorModir"
        Me.txt_DastorModir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DastorModir.Size = New System.Drawing.Size(931, 44)
        Me.txt_DastorModir.SpellControl = Nothing
        Me.txt_DastorModir.TabIndex = 14
        Me.txt_DastorModir.Tag = ""
        Me.txt_DastorModir.Title = Nothing
        Me.txt_DastorModir.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DastorModir.UseForData = True
        Me.txt_DastorModir.ValidateCheckExistOnEdit = False
        Me.txt_DastorModir.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(950, 519)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(85, 34)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "پیشنهاد های" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "اصلاحی"
        '
        'txt_PishnahadEslahi
        '
        Me.txt_PishnahadEslahi.CheckExistValueInDb = False
        Me.txt_PishnahadEslahi.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_PishnahadEslahi.CurrencyUnit = "ریال"
        Me.txt_PishnahadEslahi.DefaultValue = ""
        Me.txt_PishnahadEslahi.FillWithMaxInDb = False
        Me.txt_PishnahadEslahi.IsRequired = True
        Me.txt_PishnahadEslahi.Location = New System.Drawing.Point(517, 516)
        Me.txt_PishnahadEslahi.MaxDecimalLength = 2
        Me.txt_PishnahadEslahi.Multiline = True
        Me.txt_PishnahadEslahi.Name = "txt_PishnahadEslahi"
        Me.txt_PishnahadEslahi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_PishnahadEslahi.Size = New System.Drawing.Size(425, 53)
        Me.txt_PishnahadEslahi.SpellControl = Nothing
        Me.txt_PishnahadEslahi.TabIndex = 15
        Me.txt_PishnahadEslahi.Tag = ""
        Me.txt_PishnahadEslahi.Title = Nothing
        Me.txt_PishnahadEslahi.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_PishnahadEslahi.UseForData = True
        Me.txt_PishnahadEslahi.ValidateCheckExistOnEdit = False
        Me.txt_PishnahadEslahi.Value = ""
        '
        'TextBox9
        '
        Me.TextBox9.CheckExistValueInDb = False
        Me.TextBox9.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox9.CurrencyUnit = "ریال"
        Me.TextBox9.DefaultValue = ""
        Me.TextBox9.FillWithMaxInDb = False
        Me.TextBox9.IsRequired = True
        Me.TextBox9.Location = New System.Drawing.Point(480, 747)
        Me.TextBox9.MaxDecimalLength = 2
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox9.Size = New System.Drawing.Size(446, 24)
        Me.TextBox9.SpellControl = Nothing
        Me.TextBox9.TabIndex = 4
        Me.TextBox9.Tag = ""
        Me.TextBox9.Title = Nothing
        Me.TextBox9.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox9.UseForData = True
        Me.TextBox9.ValidateCheckExistOnEdit = False
        Me.TextBox9.Value = ""
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 10.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.پیشنهاداصلاحیDataGridViewTextBoxColumn})
        Me.DataGridView3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView3.DataSource = Me.PmHadesePishnahadBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 10.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView3.Location = New System.Drawing.Point(11, 507)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 10.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView3.RowHeadersWidth = 30
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(462, 85)
        Me.DataGridView3.TabIndex = 16
        '
        'پیشنهاداصلاحیDataGridViewTextBoxColumn
        '
        Me.پیشنهاداصلاحیDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.پیشنهاداصلاحیDataGridViewTextBoxColumn.DataPropertyName = "پیشنهاد اصلاحی"
        Me.پیشنهاداصلاحیDataGridViewTextBoxColumn.HeaderText = "پیشنهاد اصلاحی"
        Me.پیشنهاداصلاحیDataGridViewTextBoxColumn.Name = "پیشنهاداصلاحیDataGridViewTextBoxColumn"
        Me.پیشنهاداصلاحیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmHadesePishnahadBindingSource
        '
        Me.PmHadesePishnahadBindingSource.DataMember = "Pm_Hadese_Pishnahad"
        Me.PmHadesePishnahadBindingSource.DataSource = Me.Ds_Hadese
        '
        'btn_Remove_Pishnahad
        '
        Me.btn_Remove_Pishnahad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Remove_Pishnahad.Image = CType(resources.GetObject("btn_Remove_Pishnahad.Image"), System.Drawing.Image)
        Me.btn_Remove_Pishnahad.Location = New System.Drawing.Point(480, 547)
        Me.btn_Remove_Pishnahad.Name = "btn_Remove_Pishnahad"
        Me.btn_Remove_Pishnahad.Size = New System.Drawing.Size(25, 20)
        Me.btn_Remove_Pishnahad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Remove_Pishnahad.TabIndex = 121
        Me.btn_Remove_Pishnahad.TabStop = False
        '
        'btn_Add_Pishnahad
        '
        Me.btn_Add_Pishnahad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Add_Pishnahad.Image = CType(resources.GetObject("btn_Add_Pishnahad.Image"), System.Drawing.Image)
        Me.btn_Add_Pishnahad.Location = New System.Drawing.Point(480, 519)
        Me.btn_Add_Pishnahad.Name = "btn_Add_Pishnahad"
        Me.btn_Add_Pishnahad.Size = New System.Drawing.Size(25, 21)
        Me.btn_Add_Pishnahad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Add_Pishnahad.TabIndex = 122
        Me.btn_Add_Pishnahad.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_SelectDEvice)
        Me.Panel1.Controls.Add(Me.btn_Add_DEvice)
        Me.Panel1.Controls.Add(Me.btn_Remove_Device)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.cmb_Device)
        Me.Panel1.Controls.Add(Me.txt_Hour)
        Me.Panel1.Controls.Add(Me.txt_Min)
        Me.Panel1.Controls.Add(Me.tbox_ZamaneKhamoshi)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_Srl_DeviceKhesarat)
        Me.Panel1.Controls.Add(Me.txt_DeviceKhesaratName)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Location = New System.Drawing.Point(8, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1058, 125)
        Me.Panel1.TabIndex = 7
        '
        'btn_SelectDEvice
        '
        Me.btn_SelectDEvice.Location = New System.Drawing.Point(699, 51)
        Me.btn_SelectDEvice.Name = "btn_SelectDEvice"
        Me.btn_SelectDEvice.Size = New System.Drawing.Size(38, 25)
        Me.btn_SelectDEvice.TabIndex = 7
        Me.btn_SelectDEvice.Text = "..."
        Me.btn_SelectDEvice.UseVisualStyleBackColor = True
        '
        'btn_Add_DEvice
        '
        Me.btn_Add_DEvice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Add_DEvice.Image = CType(resources.GetObject("btn_Add_DEvice.Image"), System.Drawing.Image)
        Me.btn_Add_DEvice.Location = New System.Drawing.Point(707, 15)
        Me.btn_Add_DEvice.Name = "btn_Add_DEvice"
        Me.btn_Add_DEvice.Size = New System.Drawing.Size(25, 21)
        Me.btn_Add_DEvice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Add_DEvice.TabIndex = 135
        Me.btn_Add_DEvice.TabStop = False
        '
        'btn_Remove_Device
        '
        Me.btn_Remove_Device.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Remove_Device.Image = CType(resources.GetObject("btn_Remove_Device.Image"), System.Drawing.Image)
        Me.btn_Remove_Device.Location = New System.Drawing.Point(675, 15)
        Me.btn_Remove_Device.Name = "btn_Remove_Device"
        Me.btn_Remove_Device.Size = New System.Drawing.Size(25, 20)
        Me.btn_Remove_Device.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Remove_Device.TabIndex = 134
        Me.btn_Remove_Device.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.نامقطعهDataGridViewTextBoxColumn, Me.نوعخسارتDataGridViewTextBoxColumn, Me.مقدارخاموشیDataGridViewTextBoxColumn, Me.مدتخروجDataGridViewTextBoxColumn, Me.Srl_Pm_Hadese_KhesaratDevice, Me.Srl_Pm_Hadese_KhesaratType})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmHadeseKhesaratBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 10.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(7, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 10.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(662, 115)
        Me.DataGridView1.TabIndex = 7
        '
        'نامقطعهDataGridViewTextBoxColumn
        '
        Me.نامقطعهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامقطعهDataGridViewTextBoxColumn.DataPropertyName = "نام قطعه"
        Me.نامقطعهDataGridViewTextBoxColumn.HeaderText = "نام قطعه"
        Me.نامقطعهDataGridViewTextBoxColumn.Name = "نامقطعهDataGridViewTextBoxColumn"
        Me.نامقطعهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نوعخسارتDataGridViewTextBoxColumn
        '
        Me.نوعخسارتDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نوعخسارتDataGridViewTextBoxColumn.DataPropertyName = "نوع خسارت"
        Me.نوعخسارتDataGridViewTextBoxColumn.HeaderText = "نوع خسارت"
        Me.نوعخسارتDataGridViewTextBoxColumn.Name = "نوعخسارتDataGridViewTextBoxColumn"
        Me.نوعخسارتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مقدارخاموشیDataGridViewTextBoxColumn
        '
        Me.مقدارخاموشیDataGridViewTextBoxColumn.DataPropertyName = "مقدار خاموشی"
        Me.مقدارخاموشیDataGridViewTextBoxColumn.HeaderText = "مقدار خاموشی"
        Me.مقدارخاموشیDataGridViewTextBoxColumn.Name = "مقدارخاموشیDataGridViewTextBoxColumn"
        Me.مقدارخاموشیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مدتخروجDataGridViewTextBoxColumn
        '
        Me.مدتخروجDataGridViewTextBoxColumn.DataPropertyName = "مدت خروج"
        Me.مدتخروجDataGridViewTextBoxColumn.HeaderText = "مدت خروج"
        Me.مدتخروجDataGridViewTextBoxColumn.Name = "مدتخروجDataGridViewTextBoxColumn"
        Me.مدتخروجDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Srl_Pm_Hadese_KhesaratDevice
        '
        Me.Srl_Pm_Hadese_KhesaratDevice.DataPropertyName = "Srl_Pm_Hadese_KhesaratDevice"
        Me.Srl_Pm_Hadese_KhesaratDevice.HeaderText = "Srl_Pm_Hadese_KhesaratDevice"
        Me.Srl_Pm_Hadese_KhesaratDevice.Name = "Srl_Pm_Hadese_KhesaratDevice"
        Me.Srl_Pm_Hadese_KhesaratDevice.ReadOnly = True
        Me.Srl_Pm_Hadese_KhesaratDevice.Visible = False
        '
        'Srl_Pm_Hadese_KhesaratType
        '
        Me.Srl_Pm_Hadese_KhesaratType.DataPropertyName = "Srl_Pm_Hadese_KhesaratType"
        Me.Srl_Pm_Hadese_KhesaratType.HeaderText = "Srl_Pm_Hadese_KhesaratType"
        Me.Srl_Pm_Hadese_KhesaratType.Name = "Srl_Pm_Hadese_KhesaratType"
        Me.Srl_Pm_Hadese_KhesaratType.ReadOnly = True
        Me.Srl_Pm_Hadese_KhesaratType.Visible = False
        '
        'PmHadeseKhesaratBindingSource
        '
        Me.PmHadeseKhesaratBindingSource.DataMember = "Pm_Hadese_Khesarat"
        Me.PmHadeseKhesaratBindingSource.DataSource = Me.Ds_Hadese
        '
        'cmb_Device
        '
        Me.cmb_Device.AutoComplete = True
        Me.cmb_Device.DataSource = Me.PmHadeseKhesaratTypeBindingSource
        Me.cmb_Device.DisplayMember = "نوع خسارت"
        Me.cmb_Device.EnterStop = True
        Me.cmb_Device.FormattingEnabled = True
        Me.cmb_Device.IsRequired = False
        Me.cmb_Device.LimitedToList = True
        Me.cmb_Device.Location = New System.Drawing.Point(739, 10)
        Me.cmb_Device.Name = "cmb_Device"
        Me.cmb_Device.OpenOnFoucus = True
        Me.cmb_Device.Size = New System.Drawing.Size(202, 25)
        Me.cmb_Device.TabIndex = 0
        Me.cmb_Device.ValueMember = "Srl"
        '
        'PmHadeseKhesaratTypeBindingSource
        '
        Me.PmHadeseKhesaratTypeBindingSource.DataMember = "Pm_Hadese_KhesaratType"
        Me.PmHadeseKhesaratTypeBindingSource.DataSource = Me.Ds_Hadese
        '
        'txt_Hour
        '
        Me.txt_Hour.CheckExistValueInDb = False
        Me.txt_Hour.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Hour.CurrencyUnit = "ریال"
        Me.txt_Hour.DefaultValue = "0"
        Me.txt_Hour.FillWithMaxInDb = False
        Me.txt_Hour.IsRequired = True
        Me.txt_Hour.Location = New System.Drawing.Point(693, 84)
        Me.txt_Hour.MaxDecimalLength = 2
        Me.txt_Hour.Name = "txt_Hour"
        Me.txt_Hour.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Hour.Size = New System.Drawing.Size(39, 24)
        Me.txt_Hour.SpellControl = Nothing
        Me.txt_Hour.TabIndex = 2
        Me.txt_Hour.Tag = ""
        Me.txt_Hour.Text = "0"
        Me.txt_Hour.Title = Nothing
        Me.txt_Hour.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_Hour.UseForData = True
        Me.txt_Hour.ValidateCheckExistOnEdit = False
        Me.txt_Hour.Value = 0.0!
        '
        'txt_Min
        '
        Me.txt_Min.CheckExistValueInDb = False
        Me.txt_Min.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Min.CurrencyUnit = "ریال"
        Me.txt_Min.DefaultValue = "0"
        Me.txt_Min.FillWithMaxInDb = False
        Me.txt_Min.IsRequired = True
        Me.txt_Min.Location = New System.Drawing.Point(739, 84)
        Me.txt_Min.MaxDecimalLength = 2
        Me.txt_Min.Name = "txt_Min"
        Me.txt_Min.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Min.Size = New System.Drawing.Size(39, 24)
        Me.txt_Min.SpellControl = Nothing
        Me.txt_Min.TabIndex = 2
        Me.txt_Min.Tag = ""
        Me.txt_Min.Text = "0"
        Me.txt_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Min.Title = Nothing
        Me.txt_Min.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_Min.UseForData = True
        Me.txt_Min.ValidateCheckExistOnEdit = False
        Me.txt_Min.Value = 0.0!
        '
        'tbox_ZamaneKhamoshi
        '
        Me.tbox_ZamaneKhamoshi.CheckExistValueInDb = False
        Me.tbox_ZamaneKhamoshi.ColorOnFocus = System.Drawing.Color.Yellow
        Me.tbox_ZamaneKhamoshi.CurrencyUnit = "ریال"
        Me.tbox_ZamaneKhamoshi.DefaultValue = "0"
        Me.tbox_ZamaneKhamoshi.FillWithMaxInDb = False
        Me.tbox_ZamaneKhamoshi.IsRequired = True
        Me.tbox_ZamaneKhamoshi.Location = New System.Drawing.Point(902, 83)
        Me.tbox_ZamaneKhamoshi.MaxDecimalLength = 2
        Me.tbox_ZamaneKhamoshi.Name = "tbox_ZamaneKhamoshi"
        Me.tbox_ZamaneKhamoshi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbox_ZamaneKhamoshi.Size = New System.Drawing.Size(39, 24)
        Me.tbox_ZamaneKhamoshi.SpellControl = Nothing
        Me.tbox_ZamaneKhamoshi.TabIndex = 2
        Me.tbox_ZamaneKhamoshi.Tag = ""
        Me.tbox_ZamaneKhamoshi.Text = "0"
        Me.tbox_ZamaneKhamoshi.Title = Nothing
        Me.tbox_ZamaneKhamoshi.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.tbox_ZamaneKhamoshi.UseForData = True
        Me.tbox_ZamaneKhamoshi.ValidateCheckExistOnEdit = False
        Me.tbox_ZamaneKhamoshi.Value = 0.0!
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(788, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "مدت خروج"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(949, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 17)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "مقدار خاموشی"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(963, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "نوع خسارت"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(862, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 17)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "MWH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(969, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(70, 34)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "تجهیزات" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "حادثه دیده"
        '
        'txt_Srl_DeviceKhesarat
        '
        Me.txt_Srl_DeviceKhesarat.CheckExistValueInDb = False
        Me.txt_Srl_DeviceKhesarat.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Srl_DeviceKhesarat.CurrencyUnit = "ریال"
        Me.txt_Srl_DeviceKhesarat.DefaultValue = ""
        Me.txt_Srl_DeviceKhesarat.FillWithMaxInDb = False
        Me.txt_Srl_DeviceKhesarat.IsRequired = True
        Me.txt_Srl_DeviceKhesarat.Location = New System.Drawing.Point(951, 38)
        Me.txt_Srl_DeviceKhesarat.MaxDecimalLength = 2
        Me.txt_Srl_DeviceKhesarat.Name = "txt_Srl_DeviceKhesarat"
        Me.txt_Srl_DeviceKhesarat.ReadOnly = True
        Me.txt_Srl_DeviceKhesarat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Srl_DeviceKhesarat.Size = New System.Drawing.Size(102, 24)
        Me.txt_Srl_DeviceKhesarat.SpellControl = Nothing
        Me.txt_Srl_DeviceKhesarat.TabIndex = 4
        Me.txt_Srl_DeviceKhesarat.Tag = ""
        Me.txt_Srl_DeviceKhesarat.Title = Nothing
        Me.txt_Srl_DeviceKhesarat.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Srl_DeviceKhesarat.UseForData = True
        Me.txt_Srl_DeviceKhesarat.ValidateCheckExistOnEdit = False
        Me.txt_Srl_DeviceKhesarat.Value = ""
        Me.txt_Srl_DeviceKhesarat.Visible = False
        '
        'txt_DeviceKhesaratName
        '
        Me.txt_DeviceKhesaratName.CheckExistValueInDb = False
        Me.txt_DeviceKhesaratName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeviceKhesaratName.CurrencyUnit = "ریال"
        Me.txt_DeviceKhesaratName.DefaultValue = ""
        Me.txt_DeviceKhesaratName.FillWithMaxInDb = False
        Me.txt_DeviceKhesaratName.IsRequired = True
        Me.txt_DeviceKhesaratName.Location = New System.Drawing.Point(739, 51)
        Me.txt_DeviceKhesaratName.MaxDecimalLength = 2
        Me.txt_DeviceKhesaratName.Name = "txt_DeviceKhesaratName"
        Me.txt_DeviceKhesaratName.ReadOnly = True
        Me.txt_DeviceKhesaratName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceKhesaratName.Size = New System.Drawing.Size(202, 24)
        Me.txt_DeviceKhesaratName.SpellControl = Nothing
        Me.txt_DeviceKhesaratName.TabIndex = 1
        Me.txt_DeviceKhesaratName.Tag = ""
        Me.txt_DeviceKhesaratName.Title = Nothing
        Me.txt_DeviceKhesaratName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeviceKhesaratName.UseForData = True
        Me.txt_DeviceKhesaratName.ValidateCheckExistOnEdit = False
        Me.txt_DeviceKhesaratName.Value = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(729, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = ":"
        '
        'cmb_PmPost
        '
        Me.cmb_PmPost.AutoComplete = True
        Me.cmb_PmPost.DataSource = Me.PmPostBindingSource
        Me.cmb_PmPost.DisplayMember = "نام پست"
        Me.cmb_PmPost.EnterStop = True
        Me.cmb_PmPost.FormattingEnabled = True
        Me.cmb_PmPost.IsRequired = False
        Me.cmb_PmPost.LimitedToList = True
        Me.cmb_PmPost.Location = New System.Drawing.Point(8, 18)
        Me.cmb_PmPost.Name = "cmb_PmPost"
        Me.cmb_PmPost.OpenOnFoucus = True
        Me.cmb_PmPost.Size = New System.Drawing.Size(165, 25)
        Me.cmb_PmPost.TabIndex = 6
        Me.cmb_PmPost.Tag = "Srl_Pm_Post"
        Me.cmb_PmPost.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(179, 386)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "ارجاع به گروه"
        '
        'cmb_Pm_Group
        '
        Me.cmb_Pm_Group.AutoComplete = True
        Me.cmb_Pm_Group.DataSource = Me.PmGroupBindingSource
        Me.cmb_Pm_Group.DisplayMember = "نام"
        Me.cmb_Pm_Group.EnterStop = True
        Me.cmb_Pm_Group.FormattingEnabled = True
        Me.cmb_Pm_Group.IsRequired = False
        Me.cmb_Pm_Group.LimitedToList = True
        Me.cmb_Pm_Group.Location = New System.Drawing.Point(11, 379)
        Me.cmb_Pm_Group.Name = "cmb_Pm_Group"
        Me.cmb_Pm_Group.OpenOnFoucus = True
        Me.cmb_Pm_Group.Size = New System.Drawing.Size(162, 25)
        Me.cmb_Pm_Group.TabIndex = 12
        Me.cmb_Pm_Group.Tag = "Srl_Pm_Group"
        Me.cmb_Pm_Group.ValueMember = "Srl"
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(950, 411)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(116, 34)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "نتیجه بررسی های" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " انجام شده"
        '
        'txt_NatijeBarasi
        '
        Me.txt_NatijeBarasi.CheckExistValueInDb = False
        Me.txt_NatijeBarasi.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_NatijeBarasi.CurrencyUnit = "ریال"
        Me.txt_NatijeBarasi.DefaultValue = ""
        Me.txt_NatijeBarasi.FillWithMaxInDb = False
        Me.txt_NatijeBarasi.IsRequired = False
        Me.txt_NatijeBarasi.Location = New System.Drawing.Point(11, 409)
        Me.txt_NatijeBarasi.MaxDecimalLength = 2
        Me.txt_NatijeBarasi.Multiline = True
        Me.txt_NatijeBarasi.Name = "txt_NatijeBarasi"
        Me.txt_NatijeBarasi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_NatijeBarasi.Size = New System.Drawing.Size(931, 44)
        Me.txt_NatijeBarasi.SpellControl = Nothing
        Me.txt_NatijeBarasi.TabIndex = 13
        Me.txt_NatijeBarasi.Tag = "NatijeBarasi"
        Me.txt_NatijeBarasi.Title = Nothing
        Me.txt_NatijeBarasi.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_NatijeBarasi.UseForData = True
        Me.txt_NatijeBarasi.ValidateCheckExistOnEdit = False
        Me.txt_NatijeBarasi.Value = ""
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_KhesaratTableAdapter
        '
        Me.Pm_Hadese_KhesaratTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_PishnahadTableAdapter
        '
        Me.Pm_Hadese_PishnahadTableAdapter.ClearBeforeFill = True
        '
        'PmHadeseKhesaratDeviceBindingSource
        '
        Me.PmHadeseKhesaratDeviceBindingSource.DataMember = "Pm_Hadese_KhesaratDevice"
        Me.PmHadeseKhesaratDeviceBindingSource.DataSource = Me.Ds_Hadese
        '
        'Pm_Hadese_KhesaratDeviceTableAdapter
        '
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_ElatTableAdapter
        '
        Me.Pm_Hadese_ElatTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_SharayetBorozTableAdapter
        '
        Me.Pm_Hadese_SharayetBorozTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_KhesaratTypeTableAdapter
        '
        Me.Pm_Hadese_KhesaratTypeTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_AmalkardSystemTableAdapter
        '
        Me.Pm_Hadese_AmalkardSystemTableAdapter.ClearBeforeFill = True
        '
        'cmb_VAhed
        '
        Me.cmb_VAhed.AutoComplete = True
        Me.cmb_VAhed.DataSource = Me.PmVahedBindingSource
        Me.cmb_VAhed.DisplayMember = "نام واحد"
        Me.cmb_VAhed.EnterStop = True
        Me.cmb_VAhed.FormattingEnabled = True
        Me.cmb_VAhed.IsRequired = False
        Me.cmb_VAhed.LimitedToList = True
        Me.cmb_VAhed.Location = New System.Drawing.Point(273, 379)
        Me.cmb_VAhed.Name = "cmb_VAhed"
        Me.cmb_VAhed.OpenOnFoucus = True
        Me.cmb_VAhed.Size = New System.Drawing.Size(170, 25)
        Me.cmb_VAhed.TabIndex = 128
        Me.cmb_VAhed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'chk_AllVahed
        '
        Me.chk_AllVahed.AutoSize = True
        Me.chk_AllVahed.Location = New System.Drawing.Point(446, 382)
        Me.chk_AllVahed.Name = "chk_AllVahed"
        Me.chk_AllVahed.Size = New System.Drawing.Size(73, 21)
        Me.chk_AllVahed.TabIndex = 129
        Me.chk_AllVahed.Text = "نام واحد"
        Me.chk_AllVahed.UseVisualStyleBackColor = True
        Me.chk_AllVahed.Visible = False
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'PmFindGroupBindingSource
        '
        Me.PmFindGroupBindingSource.DataMember = "Pm_FindGroup"
        Me.PmFindGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_FindGroupTableAdapter
        '
        Me.Pm_FindGroupTableAdapter.ClearBeforeFill = True
        '
        'btn_SHow
        '
        Me.btn_SHow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SHow.Image = CType(resources.GetObject("btn_SHow.Image"), System.Drawing.Image)
        Me.btn_SHow.Location = New System.Drawing.Point(764, 14)
        Me.btn_SHow.Name = "btn_SHow"
        Me.btn_SHow.Size = New System.Drawing.Size(32, 30)
        Me.btn_SHow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SHow.TabIndex = 132
        Me.btn_SHow.TabStop = False
        '
        'btn_Before
        '
        Me.btn_Before.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Before.Image = CType(resources.GetObject("btn_Before.Image"), System.Drawing.Image)
        Me.btn_Before.Location = New System.Drawing.Point(840, 16)
        Me.btn_Before.Name = "btn_Before"
        Me.btn_Before.Size = New System.Drawing.Size(30, 28)
        Me.btn_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Before.TabIndex = 131
        Me.btn_Before.TabStop = False
        '
        'btn_Next
        '
        Me.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next.Image = CType(resources.GetObject("btn_Next.Image"), System.Drawing.Image)
        Me.btn_Next.Location = New System.Drawing.Point(802, 16)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(32, 28)
        Me.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Next.TabIndex = 130
        Me.btn_Next.TabStop = False
        '
        'lb_Posttype
        '
        Me.lb_Posttype.ForeColor = System.Drawing.Color.Green
        Me.lb_Posttype.Location = New System.Drawing.Point(8, 52)
        Me.lb_Posttype.Name = "lb_Posttype"
        Me.lb_Posttype.Size = New System.Drawing.Size(73, 18)
        Me.lb_Posttype.TabIndex = 126
        '
        'rbt_Line
        '
        Me.rbt_Line.AutoSize = True
        Me.rbt_Line.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_Line.Location = New System.Drawing.Point(172, 47)
        Me.rbt_Line.Name = "rbt_Line"
        Me.rbt_Line.Size = New System.Drawing.Size(105, 20)
        Me.rbt_Line.TabIndex = 225
        Me.rbt_Line.TabStop = True
        Me.rbt_Line.Text = "خط حادثه دیده"
        Me.rbt_Line.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(191, 25)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(85, 20)
        Me.RadioButton1.TabIndex = 226
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "محل حادثه"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cmb_Pm_Line
        '
        Me.cmb_Pm_Line.AutoComplete = True
        Me.cmb_Pm_Line.DataSource = Me.PmLineBindingSource
        Me.cmb_Pm_Line.DisplayMember = "نام"
        Me.cmb_Pm_Line.EnterStop = True
        Me.cmb_Pm_Line.FormattingEnabled = True
        Me.cmb_Pm_Line.IsRequired = False
        Me.cmb_Pm_Line.LimitedToList = True
        Me.cmb_Pm_Line.Location = New System.Drawing.Point(8, 45)
        Me.cmb_Pm_Line.Name = "cmb_Pm_Line"
        Me.cmb_Pm_Line.OpenOnFoucus = True
        Me.cmb_Pm_Line.Size = New System.Drawing.Size(165, 25)
        Me.cmb_Pm_Line.TabIndex = 227
        Me.cmb_Pm_Line.Tag = "Srl_Pm_Line"
        Me.cmb_Pm_Line.ValueMember = "Srl"
        '
        'PmLineBindingSource
        '
        Me.PmLineBindingSource.DataMember = "Pm_Line"
        Me.PmLineBindingSource.DataSource = Me.Ds_Pm
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(449, 383)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 228
        Me.Label4.Text = "نام واحد"
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'Frm_Hadese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1099, 730)
        Me.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Name = "Frm_Hadese"
        Me.TableName = "Pm_Hadese"
        Me.Text = "ثبت حادثه"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PmHadeseSharayetBorozBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseElatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseAmalkardSystemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadesePishnahadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Remove_Pishnahad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Add_Pishnahad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_Add_DEvice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Remove_Device, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmFindGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_SHow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_ReportNo As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ts_Sat As VB_Component.TimeSelect
    Friend WithEvents txt_Tarikh As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As VB_Component.ComboBox
    Friend WithEvents ComboBox1 As VB_Component.ComboBox
    Friend WithEvents txt_Kelidi As CS_Component.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chk_GostareshHadese As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Pm_Hadese_Amalkard As VB_Component.ComboBox
    Friend WithEvents txt_ElatGostareshHadese As CS_Component.TextBox
    Friend WithEvents txt_EghdamatAvalie As CS_Component.TextBox
    Friend WithEvents txt_SharhHadese As CS_Component.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_PishnahadEslahi As CS_Component.TextBox
    Friend WithEvents txt_DastorModir As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As CS_Component.TextBox
    Friend WithEvents DataGridView3 As CS_Component.DataGridView
    Friend WithEvents btn_Add_Pishnahad As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Remove_Pishnahad As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Add_DEvice As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Remove_Device As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_Device As VB_Component.ComboBox
    Friend WithEvents cmb_PmPost As VB_Component.ComboBox
    Friend WithEvents tbox_ZamaneKhamoshi As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_SelectDEvice As System.Windows.Forms.Button
    Friend WithEvents cmb_Pm_Group As VB_Component.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_DeviceKhesaratName As CS_Component.TextBox
    Friend WithEvents txt_NatijeBarasi As CS_Component.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmHadeseKhesaratBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_KhesaratTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratTableAdapter
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents پیشنهاداصلاحیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmHadesePishnahadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_PishnahadTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_PishnahadTableAdapter
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents txt_Srl_DeviceKhesarat As CS_Component.TextBox
    Friend WithEvents نامقطعهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعخسارتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مقدارخاموشیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مدتخروجDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Srl_Pm_Hadese_KhesaratDevice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Srl_Pm_Hadese_KhesaratType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmHadeseElatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_ElatTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_ElatTableAdapter
    Friend WithEvents PmHadeseSharayetBorozBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_SharayetBorozTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_SharayetBorozTableAdapter
    Friend WithEvents PmHadeseKhesaratTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_KhesaratTypeTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratTypeTableAdapter
    Friend WithEvents PmHadeseAmalkardSystemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_AmalkardSystemTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_AmalkardSystemTableAdapter
    Friend WithEvents cmb_VAhed As VB_Component.ComboBox
    Friend WithEvents chk_AllVahed As System.Windows.Forms.CheckBox
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmFindGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_FindGroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_FindGroupTableAdapter
    Friend WithEvents btn_SHow As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Before As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Next As System.Windows.Forms.PictureBox
    Friend WithEvents lb_Posttype As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_Hour As CS_Component.TextBox
    Friend WithEvents txt_Min As CS_Component.TextBox
    Private WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Line As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_Pm_Line As VB_Component.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
End Class
