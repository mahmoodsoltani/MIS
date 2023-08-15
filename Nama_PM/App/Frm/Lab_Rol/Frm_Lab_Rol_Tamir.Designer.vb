<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Lab_Rol_Tamir
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Lab_Rol_Tamir))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_TarikhVorod = New CS_Component.TextBox
        Me.txt_TarikhTamir = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_TarikhTahvil = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_Tavasot = New VB_Component.ComboBox
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.cmb_Elat = New VB_Component.ComboBox
        Me.PmLabRolElateVorodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tbox_Tedad = New CS_Component.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.btn_Add_DEvice = New System.Windows.Forms.PictureBox
        Me.btn_Remove_Device = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.PmLabRolGhatatMasrafiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.قطعهمصرفیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تعدادDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmLabRolTamiratGhateMasrafiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Device = New VB_Component.ComboBox
        Me.PmLabRolGhatatMasrafiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_Dis = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_NafarSat = New CS_Component.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmb_TahvilePerson = New VB_Component.ComboBox
        Me.AccAshkhasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_tarikhTamirBaze = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_TarikhVorodBaze = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_No = New CS_Component.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_DeviceKhesaratName = New CS_Component.TextBox
        Me.txt_TarikhSabt = New CS_Component.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_SatheaAhamiat = New VB_Component.ComboBox
        Me.PmLabRolSatheAhamniatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label
        Me.PmHadeseKhesaratDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.Pm_Hadese_KhesaratDeviceTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
        Me.txt_Srl_DeviceKhesarat = New CS_Component.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_SHow = New System.Windows.Forms.PictureBox
        Me.btn_Before = New System.Windows.Forms.PictureBox
        Me.btn_Next = New System.Windows.Forms.PictureBox
        Me.cmb_PmPost = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label15 = New System.Windows.Forms.Label
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Acc_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_SelectDEvice = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Pm_Lab_Rol_SatheAhamniatTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_SatheAhamniatTableAdapter
        Me.Pm_Lab_Rol_ElateVorodTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_ElateVorodTableAdapter
        Me.Pm_Lab_Rol_GhatatMasrafiTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_GhatatMasrafiTableAdapter
        Me.Pm_Lab_Rol_Tamirat_GhateMasrafiTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_Tamirat_GhateMasrafiTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolElateVorodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_Add_DEvice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Remove_Device, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolTamiratGhateMasrafiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolGhatatMasrafiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolSatheAhamniatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_SHow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 552)
        Me.gbx_Buttons.Size = New System.Drawing.Size(828, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(724, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Panel4)
        Me.gbx_Fields.Controls.Add(Me.Panel3)
        Me.gbx_Fields.Controls.Add(Me.Panel2)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 41)
        Me.gbx_Fields.Size = New System.Drawing.Size(828, 509)
        Me.gbx_Fields.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(688, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "توسط"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "تاریخ ورود"
        '
        'txt_TarikhVorod
        '
        Me.txt_TarikhVorod.CheckExistValueInDb = False
        Me.txt_TarikhVorod.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhVorod.CurrencyUnit = "ریال"
        Me.txt_TarikhVorod.DefaultValue = ""
        Me.txt_TarikhVorod.FillWithMaxInDb = False
        Me.txt_TarikhVorod.IsRequired = True
        Me.txt_TarikhVorod.Location = New System.Drawing.Point(244, 64)
        Me.txt_TarikhVorod.MaxDecimalLength = 2
        Me.txt_TarikhVorod.Name = "txt_TarikhVorod"
        Me.txt_TarikhVorod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhVorod.Size = New System.Drawing.Size(150, 26)
        Me.txt_TarikhVorod.SpellControl = Nothing
        Me.txt_TarikhVorod.TabIndex = 6
        Me.txt_TarikhVorod.TabStop = False
        Me.txt_TarikhVorod.Tag = ""
        Me.txt_TarikhVorod.Title = Nothing
        Me.txt_TarikhVorod.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhVorod.UseForData = True
        Me.txt_TarikhVorod.ValidateCheckExistOnEdit = False
        Me.txt_TarikhVorod.Value = ""
        '
        'txt_TarikhTamir
        '
        Me.txt_TarikhTamir.CheckExistValueInDb = False
        Me.txt_TarikhTamir.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhTamir.CurrencyUnit = "ریال"
        Me.txt_TarikhTamir.DefaultValue = ""
        Me.txt_TarikhTamir.FillWithMaxInDb = False
        Me.txt_TarikhTamir.IsRequired = True
        Me.txt_TarikhTamir.Location = New System.Drawing.Point(244, 96)
        Me.txt_TarikhTamir.MaxDecimalLength = 2
        Me.txt_TarikhTamir.Name = "txt_TarikhTamir"
        Me.txt_TarikhTamir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhTamir.Size = New System.Drawing.Size(150, 26)
        Me.txt_TarikhTamir.SpellControl = Nothing
        Me.txt_TarikhTamir.TabIndex = 7
        Me.txt_TarikhTamir.TabStop = False
        Me.txt_TarikhTamir.Tag = ""
        Me.txt_TarikhTamir.Title = Nothing
        Me.txt_TarikhTamir.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhTamir.UseForData = True
        Me.txt_TarikhTamir.ValidateCheckExistOnEdit = False
        Me.txt_TarikhTamir.Value = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "تاریخ تعمیر"
        '
        'txt_TarikhTahvil
        '
        Me.txt_TarikhTahvil.CheckExistValueInDb = False
        Me.txt_TarikhTahvil.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhTahvil.CurrencyUnit = "ریال"
        Me.txt_TarikhTahvil.DefaultValue = ""
        Me.txt_TarikhTahvil.FillWithMaxInDb = False
        Me.txt_TarikhTahvil.IsRequired = True
        Me.txt_TarikhTahvil.Location = New System.Drawing.Point(244, 128)
        Me.txt_TarikhTahvil.MaxDecimalLength = 2
        Me.txt_TarikhTahvil.Name = "txt_TarikhTahvil"
        Me.txt_TarikhTahvil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhTahvil.Size = New System.Drawing.Size(150, 26)
        Me.txt_TarikhTahvil.SpellControl = Nothing
        Me.txt_TarikhTahvil.TabIndex = 8
        Me.txt_TarikhTahvil.TabStop = False
        Me.txt_TarikhTahvil.Tag = ""
        Me.txt_TarikhTahvil.Title = Nothing
        Me.txt_TarikhTahvil.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhTahvil.UseForData = True
        Me.txt_TarikhTahvil.ValidateCheckExistOnEdit = False
        Me.txt_TarikhTahvil.Value = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(400, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "تاریخ تحویل"
        '
        'cmb_Tavasot
        '
        Me.cmb_Tavasot.AutoComplete = True
        Me.cmb_Tavasot.DataSource = Me.AccAshkhasBindingSource
        Me.cmb_Tavasot.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Tavasot.EnterStop = True
        Me.cmb_Tavasot.FormattingEnabled = True
        Me.cmb_Tavasot.IsRequired = False
        Me.cmb_Tavasot.LimitedToList = True
        Me.cmb_Tavasot.Location = New System.Drawing.Point(486, 64)
        Me.cmb_Tavasot.Name = "cmb_Tavasot"
        Me.cmb_Tavasot.OpenOnFoucus = True
        Me.cmb_Tavasot.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Tavasot.TabIndex = 3
        Me.cmb_Tavasot.ValueMember = "Srl"
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
        'cmb_Elat
        '
        Me.cmb_Elat.AutoComplete = True
        Me.cmb_Elat.DataSource = Me.PmLabRolElateVorodBindingSource
        Me.cmb_Elat.DisplayMember = "علت ورود"
        Me.cmb_Elat.EnterStop = True
        Me.cmb_Elat.FormattingEnabled = True
        Me.cmb_Elat.IsRequired = False
        Me.cmb_Elat.LimitedToList = True
        Me.cmb_Elat.Location = New System.Drawing.Point(486, 96)
        Me.cmb_Elat.Name = "cmb_Elat"
        Me.cmb_Elat.OpenOnFoucus = True
        Me.cmb_Elat.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Elat.TabIndex = 4
        Me.cmb_Elat.ValueMember = "Srl"
        '
        'PmLabRolElateVorodBindingSource
        '
        Me.PmLabRolElateVorodBindingSource.DataMember = "Pm_Lab_Rol_ElateVorod"
        Me.PmLabRolElateVorodBindingSource.DataSource = Me.Ds_Lab
        '
        'Ds_Lab
        '
        Me.Ds_Lab.DataSetName = "Ds_Lab"
        Me.Ds_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(688, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "علت ورود"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tbox_Tedad)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.btn_Add_DEvice)
        Me.Panel1.Controls.Add(Me.btn_Remove_Device)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.cmb_Device)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(9, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 169)
        Me.Panel1.TabIndex = 2
        '
        'tbox_Tedad
        '
        Me.tbox_Tedad.CheckExistValueInDb = False
        Me.tbox_Tedad.ColorOnFocus = System.Drawing.Color.Yellow
        Me.tbox_Tedad.CurrencyUnit = "ریال"
        Me.tbox_Tedad.DefaultValue = "0"
        Me.tbox_Tedad.FillWithMaxInDb = False
        Me.tbox_Tedad.IsRequired = True
        Me.tbox_Tedad.Location = New System.Drawing.Point(637, 51)
        Me.tbox_Tedad.MaxDecimalLength = 2
        Me.tbox_Tedad.Name = "tbox_Tedad"
        Me.tbox_Tedad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbox_Tedad.Size = New System.Drawing.Size(39, 26)
        Me.tbox_Tedad.SpellControl = Nothing
        Me.tbox_Tedad.TabIndex = 1
        Me.tbox_Tedad.Tag = ""
        Me.tbox_Tedad.Text = "0"
        Me.tbox_Tedad.Title = Nothing
        Me.tbox_Tedad.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.tbox_Tedad.UseForData = True
        Me.tbox_Tedad.ValidateCheckExistOnEdit = False
        Me.tbox_Tedad.Value = 0.0!
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(684, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 18)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "تعداد"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(591, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 18)
        Me.Label18.TabIndex = 138
        Me.Label18.Text = "واحد"
        '
        'btn_Add_DEvice
        '
        Me.btn_Add_DEvice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Add_DEvice.Image = CType(resources.GetObject("btn_Add_DEvice.Image"), System.Drawing.Image)
        Me.btn_Add_DEvice.Location = New System.Drawing.Point(440, 13)
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
        Me.btn_Remove_Device.Location = New System.Drawing.Point(409, 14)
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PmLabRolGhatatMasrafiDataGridViewTextBoxColumn, Me.قطعهمصرفیDataGridViewTextBoxColumn, Me.تعدادDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmLabRolTamiratGhateMasrafiBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(8, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(382, 148)
        Me.DataGridView1.TabIndex = 4
        '
        'PmLabRolGhatatMasrafiDataGridViewTextBoxColumn
        '
        Me.PmLabRolGhatatMasrafiDataGridViewTextBoxColumn.DataPropertyName = "Pm_Lab_Rol_GhatatMasrafi"
        Me.PmLabRolGhatatMasrafiDataGridViewTextBoxColumn.HeaderText = "Pm_Lab_Rol_GhatatMasrafi"
        Me.PmLabRolGhatatMasrafiDataGridViewTextBoxColumn.Name = "PmLabRolGhatatMasrafiDataGridViewTextBoxColumn"
        Me.PmLabRolGhatatMasrafiDataGridViewTextBoxColumn.ReadOnly = True
        Me.PmLabRolGhatatMasrafiDataGridViewTextBoxColumn.Visible = False
        '
        'قطعهمصرفیDataGridViewTextBoxColumn
        '
        Me.قطعهمصرفیDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.قطعهمصرفیDataGridViewTextBoxColumn.DataPropertyName = "قطعه مصرفی"
        Me.قطعهمصرفیDataGridViewTextBoxColumn.HeaderText = "قطعه مصرفی"
        Me.قطعهمصرفیDataGridViewTextBoxColumn.Name = "قطعهمصرفیDataGridViewTextBoxColumn"
        Me.قطعهمصرفیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تعدادDataGridViewTextBoxColumn
        '
        Me.تعدادDataGridViewTextBoxColumn.DataPropertyName = "تعداد"
        Me.تعدادDataGridViewTextBoxColumn.HeaderText = "تعداد"
        Me.تعدادDataGridViewTextBoxColumn.Name = "تعدادDataGridViewTextBoxColumn"
        Me.تعدادDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmLabRolTamiratGhateMasrafiBindingSource
        '
        Me.PmLabRolTamiratGhateMasrafiBindingSource.DataMember = "Pm_Lab_Rol_Tamirat_GhateMasrafi"
        Me.PmLabRolTamiratGhateMasrafiBindingSource.DataSource = Me.Ds_Lab
        '
        'cmb_Device
        '
        Me.cmb_Device.AutoComplete = True
        Me.cmb_Device.DataSource = Me.PmLabRolGhatatMasrafiBindingSource
        Me.cmb_Device.DisplayMember = "قطعات مصرفی"
        Me.cmb_Device.EnterStop = True
        Me.cmb_Device.FormattingEnabled = True
        Me.cmb_Device.IsRequired = False
        Me.cmb_Device.LimitedToList = True
        Me.cmb_Device.Location = New System.Drawing.Point(482, 13)
        Me.cmb_Device.Name = "cmb_Device"
        Me.cmb_Device.OpenOnFoucus = True
        Me.cmb_Device.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Device.TabIndex = 0
        Me.cmb_Device.ValueMember = "Srl"
        '
        'PmLabRolGhatatMasrafiBindingSource
        '
        Me.PmLabRolGhatatMasrafiBindingSource.DataMember = "Pm_Lab_Rol_GhatatMasrafi"
        Me.PmLabRolGhatatMasrafiBindingSource.DataSource = Me.Ds_Lab
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(684, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 18)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "قطعه مصرفی"
        '
        'txt_Dis
        '
        Me.txt_Dis.CheckExistValueInDb = False
        Me.txt_Dis.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Dis.CurrencyUnit = "ریال"
        Me.txt_Dis.DefaultValue = ""
        Me.txt_Dis.FillWithMaxInDb = False
        Me.txt_Dis.IsRequired = True
        Me.txt_Dis.Location = New System.Drawing.Point(4, 6)
        Me.txt_Dis.MaxDecimalLength = 2
        Me.txt_Dis.Multiline = True
        Me.txt_Dis.Name = "txt_Dis"
        Me.txt_Dis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Dis.Size = New System.Drawing.Size(677, 53)
        Me.txt_Dis.SpellControl = Nothing
        Me.txt_Dis.TabIndex = 3
        Me.txt_Dis.Tag = ""
        Me.txt_Dis.Title = Nothing
        Me.txt_Dis.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Dis.UseForData = True
        Me.txt_Dis.ValidateCheckExistOnEdit = False
        Me.txt_Dis.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(686, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(62, 18)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "توضیحات"
        '
        'txt_NafarSat
        '
        Me.txt_NafarSat.CheckExistValueInDb = False
        Me.txt_NafarSat.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_NafarSat.CurrencyUnit = "ریال"
        Me.txt_NafarSat.DefaultValue = "0"
        Me.txt_NafarSat.FillWithMaxInDb = False
        Me.txt_NafarSat.IsRequired = True
        Me.txt_NafarSat.Location = New System.Drawing.Point(486, 128)
        Me.txt_NafarSat.MaxDecimalLength = 2
        Me.txt_NafarSat.Name = "txt_NafarSat"
        Me.txt_NafarSat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_NafarSat.Size = New System.Drawing.Size(194, 26)
        Me.txt_NafarSat.SpellControl = Nothing
        Me.txt_NafarSat.TabIndex = 5
        Me.txt_NafarSat.Tag = ""
        Me.txt_NafarSat.Text = "0"
        Me.txt_NafarSat.Title = Nothing
        Me.txt_NafarSat.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_NafarSat.UseForData = True
        Me.txt_NafarSat.ValidateCheckExistOnEdit = False
        Me.txt_NafarSat.Value = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(688, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "نفر ساعت"
        '
        'cmb_TahvilePerson
        '
        Me.cmb_TahvilePerson.AutoComplete = True
        Me.cmb_TahvilePerson.DataSource = Me.AccAshkhasBindingSource1
        Me.cmb_TahvilePerson.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_TahvilePerson.EnterStop = True
        Me.cmb_TahvilePerson.FormattingEnabled = True
        Me.cmb_TahvilePerson.IsRequired = False
        Me.cmb_TahvilePerson.LimitedToList = True
        Me.cmb_TahvilePerson.Location = New System.Drawing.Point(474, 65)
        Me.cmb_TahvilePerson.Name = "cmb_TahvilePerson"
        Me.cmb_TahvilePerson.OpenOnFoucus = True
        Me.cmb_TahvilePerson.Size = New System.Drawing.Size(209, 26)
        Me.cmb_TahvilePerson.TabIndex = 2
        Me.cmb_TahvilePerson.ValueMember = "Srl"
        '
        'AccAshkhasBindingSource1
        '
        Me.AccAshkhasBindingSource1.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource1.DataSource = Me.Ds_Ashkhas
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(684, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "تحویل شده به"
        '
        'txt_tarikhTamirBaze
        '
        Me.txt_tarikhTamirBaze.CheckExistValueInDb = False
        Me.txt_tarikhTamirBaze.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_tarikhTamirBaze.CurrencyUnit = "ریال"
        Me.txt_tarikhTamirBaze.DefaultValue = ""
        Me.txt_tarikhTamirBaze.FillWithMaxInDb = False
        Me.txt_tarikhTamirBaze.IsRequired = True
        Me.txt_tarikhTamirBaze.Location = New System.Drawing.Point(16, 99)
        Me.txt_tarikhTamirBaze.MaxDecimalLength = 2
        Me.txt_tarikhTamirBaze.Name = "txt_tarikhTamirBaze"
        Me.txt_tarikhTamirBaze.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_tarikhTamirBaze.Size = New System.Drawing.Size(150, 26)
        Me.txt_tarikhTamirBaze.SpellControl = Nothing
        Me.txt_tarikhTamirBaze.TabIndex = 10
        Me.txt_tarikhTamirBaze.TabStop = False
        Me.txt_tarikhTamirBaze.Tag = ""
        Me.txt_tarikhTamirBaze.Title = Nothing
        Me.txt_tarikhTamirBaze.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_tarikhTamirBaze.UseForData = True
        Me.txt_tarikhTamirBaze.ValidateCheckExistOnEdit = False
        Me.txt_tarikhTamirBaze.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(172, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 18)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "بازه زمانی"
        '
        'txt_TarikhVorodBaze
        '
        Me.txt_TarikhVorodBaze.CheckExistValueInDb = False
        Me.txt_TarikhVorodBaze.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhVorodBaze.CurrencyUnit = "ریال"
        Me.txt_TarikhVorodBaze.DefaultValue = ""
        Me.txt_TarikhVorodBaze.FillWithMaxInDb = False
        Me.txt_TarikhVorodBaze.IsRequired = True
        Me.txt_TarikhVorodBaze.Location = New System.Drawing.Point(16, 67)
        Me.txt_TarikhVorodBaze.MaxDecimalLength = 2
        Me.txt_TarikhVorodBaze.Name = "txt_TarikhVorodBaze"
        Me.txt_TarikhVorodBaze.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhVorodBaze.Size = New System.Drawing.Size(150, 26)
        Me.txt_TarikhVorodBaze.SpellControl = Nothing
        Me.txt_TarikhVorodBaze.TabIndex = 9
        Me.txt_TarikhVorodBaze.TabStop = False
        Me.txt_TarikhVorodBaze.Tag = ""
        Me.txt_TarikhVorodBaze.Title = Nothing
        Me.txt_TarikhVorodBaze.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhVorodBaze.UseForData = True
        Me.txt_TarikhVorodBaze.ValidateCheckExistOnEdit = False
        Me.txt_TarikhVorodBaze.Value = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(172, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 18)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "بازه زمانی"
        '
        'txt_No
        '
        Me.txt_No.CheckExistValueInDb = False
        Me.txt_No.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_No.CurrencyUnit = "ریال"
        Me.txt_No.DefaultValue = ""
        Me.txt_No.FillWithMaxInDb = False
        Me.txt_No.IsRequired = True
        Me.txt_No.Location = New System.Drawing.Point(590, 11)
        Me.txt_No.MaxDecimalLength = 2
        Me.txt_No.Name = "txt_No"
        Me.txt_No.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_No.Size = New System.Drawing.Size(150, 26)
        Me.txt_No.SpellControl = Nothing
        Me.txt_No.TabIndex = 0
        Me.txt_No.Tag = ""
        Me.txt_No.Title = Nothing
        Me.txt_No.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_No.UseForData = True
        Me.txt_No.ValidateCheckExistOnEdit = False
        Me.txt_No.Value = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(744, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 18)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = "شماره"
        '
        'txt_DeviceKhesaratName
        '
        Me.txt_DeviceKhesaratName.CheckExistValueInDb = False
        Me.txt_DeviceKhesaratName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeviceKhesaratName.CurrencyUnit = "ریال"
        Me.txt_DeviceKhesaratName.DefaultValue = ""
        Me.txt_DeviceKhesaratName.Enabled = False
        Me.txt_DeviceKhesaratName.FillWithMaxInDb = False
        Me.txt_DeviceKhesaratName.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_DeviceKhesaratName.IsRequired = True
        Me.txt_DeviceKhesaratName.Location = New System.Drawing.Point(60, 3)
        Me.txt_DeviceKhesaratName.MaxDecimalLength = 2
        Me.txt_DeviceKhesaratName.Name = "txt_DeviceKhesaratName"
        Me.txt_DeviceKhesaratName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceKhesaratName.Size = New System.Drawing.Size(334, 26)
        Me.txt_DeviceKhesaratName.SpellControl = Nothing
        Me.txt_DeviceKhesaratName.TabIndex = 2
        Me.txt_DeviceKhesaratName.Tag = ""
        Me.txt_DeviceKhesaratName.Title = Nothing
        Me.txt_DeviceKhesaratName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeviceKhesaratName.UseForData = True
        Me.txt_DeviceKhesaratName.ValidateCheckExistOnEdit = False
        Me.txt_DeviceKhesaratName.Value = ""
        '
        'txt_TarikhSabt
        '
        Me.txt_TarikhSabt.CheckExistValueInDb = False
        Me.txt_TarikhSabt.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhSabt.CurrencyUnit = "ریال"
        Me.txt_TarikhSabt.DefaultValue = ""
        Me.txt_TarikhSabt.FillWithMaxInDb = False
        Me.txt_TarikhSabt.IsRequired = True
        Me.txt_TarikhSabt.Location = New System.Drawing.Point(11, 6)
        Me.txt_TarikhSabt.MaxDecimalLength = 2
        Me.txt_TarikhSabt.Name = "txt_TarikhSabt"
        Me.txt_TarikhSabt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhSabt.Size = New System.Drawing.Size(150, 26)
        Me.txt_TarikhSabt.SpellControl = Nothing
        Me.txt_TarikhSabt.TabIndex = 1
        Me.txt_TarikhSabt.TabStop = False
        Me.txt_TarikhSabt.Tag = ""
        Me.txt_TarikhSabt.Title = Nothing
        Me.txt_TarikhSabt.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhSabt.UseForData = True
        Me.txt_TarikhSabt.ValidateCheckExistOnEdit = False
        Me.txt_TarikhSabt.Value = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(167, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 18)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "تاریخ ثبت"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(397, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "دستگاه"
        '
        'cmb_SatheaAhamiat
        '
        Me.cmb_SatheaAhamiat.AutoComplete = True
        Me.cmb_SatheaAhamiat.DataSource = Me.PmLabRolSatheAhamniatBindingSource
        Me.cmb_SatheaAhamiat.DisplayMember = "سطح اهمیت"
        Me.cmb_SatheaAhamiat.EnterStop = True
        Me.cmb_SatheaAhamiat.FormattingEnabled = True
        Me.cmb_SatheaAhamiat.IsRequired = False
        Me.cmb_SatheaAhamiat.LimitedToList = True
        Me.cmb_SatheaAhamiat.Location = New System.Drawing.Point(486, 32)
        Me.cmb_SatheaAhamiat.Name = "cmb_SatheaAhamiat"
        Me.cmb_SatheaAhamiat.OpenOnFoucus = True
        Me.cmb_SatheaAhamiat.Size = New System.Drawing.Size(194, 26)
        Me.cmb_SatheaAhamiat.TabIndex = 2
        Me.cmb_SatheaAhamiat.ValueMember = "Srl"
        '
        'PmLabRolSatheAhamniatBindingSource
        '
        Me.PmLabRolSatheAhamniatBindingSource.DataMember = "Pm_Lab_Rol_SatheAhamniat"
        Me.PmLabRolSatheAhamniatBindingSource.DataSource = Me.Ds_Lab
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(688, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 18)
        Me.Label14.TabIndex = 143
        Me.Label14.Text = "سطح اهمیت"
        '
        'PmHadeseKhesaratDeviceBindingSource
        '
        Me.PmHadeseKhesaratDeviceBindingSource.DataMember = "Pm_Hadese_KhesaratDevice"
        Me.PmHadeseKhesaratDeviceBindingSource.DataSource = Me.Ds_Hadese
        '
        'Ds_Hadese
        '
        Me.Ds_Hadese.DataSetName = "Ds_Hadese"
        Me.Ds_Hadese.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_Hadese_KhesaratDeviceTableAdapter
        '
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.ClearBeforeFill = True
        '
        'txt_Srl_DeviceKhesarat
        '
        Me.txt_Srl_DeviceKhesarat.CheckExistValueInDb = False
        Me.txt_Srl_DeviceKhesarat.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Srl_DeviceKhesarat.CurrencyUnit = "ریال"
        Me.txt_Srl_DeviceKhesarat.DefaultValue = ""
        Me.txt_Srl_DeviceKhesarat.FillWithMaxInDb = False
        Me.txt_Srl_DeviceKhesarat.IsRequired = True
        Me.txt_Srl_DeviceKhesarat.Location = New System.Drawing.Point(43, 131)
        Me.txt_Srl_DeviceKhesarat.MaxDecimalLength = 2
        Me.txt_Srl_DeviceKhesarat.Name = "txt_Srl_DeviceKhesarat"
        Me.txt_Srl_DeviceKhesarat.ReadOnly = True
        Me.txt_Srl_DeviceKhesarat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Srl_DeviceKhesarat.Size = New System.Drawing.Size(102, 26)
        Me.txt_Srl_DeviceKhesarat.SpellControl = Nothing
        Me.txt_Srl_DeviceKhesarat.TabIndex = 144
        Me.txt_Srl_DeviceKhesarat.Tag = ""
        Me.txt_Srl_DeviceKhesarat.Title = Nothing
        Me.txt_Srl_DeviceKhesarat.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Srl_DeviceKhesarat.UseForData = True
        Me.txt_Srl_DeviceKhesarat.ValidateCheckExistOnEdit = False
        Me.txt_Srl_DeviceKhesarat.Value = ""
        Me.txt_Srl_DeviceKhesarat.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_SHow)
        Me.Panel2.Controls.Add(Me.btn_Before)
        Me.Panel2.Controls.Add(Me.btn_Next)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txt_TarikhSabt)
        Me.Panel2.Controls.Add(Me.txt_No)
        Me.Panel2.Location = New System.Drawing.Point(10, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 45)
        Me.Panel2.TabIndex = 0
        '
        'btn_SHow
        '
        Me.btn_SHow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SHow.Image = CType(resources.GetObject("btn_SHow.Image"), System.Drawing.Image)
        Me.btn_SHow.Location = New System.Drawing.Point(552, 8)
        Me.btn_SHow.Name = "btn_SHow"
        Me.btn_SHow.Size = New System.Drawing.Size(32, 30)
        Me.btn_SHow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SHow.TabIndex = 144
        Me.btn_SHow.TabStop = False
        '
        'btn_Before
        '
        Me.btn_Before.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Before.Image = CType(resources.GetObject("btn_Before.Image"), System.Drawing.Image)
        Me.btn_Before.Location = New System.Drawing.Point(520, 8)
        Me.btn_Before.Name = "btn_Before"
        Me.btn_Before.Size = New System.Drawing.Size(30, 29)
        Me.btn_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Before.TabIndex = 143
        Me.btn_Before.TabStop = False
        Me.btn_Before.Visible = False
        '
        'btn_Next
        '
        Me.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next.Image = CType(resources.GetObject("btn_Next.Image"), System.Drawing.Image)
        Me.btn_Next.Location = New System.Drawing.Point(482, 9)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(32, 28)
        Me.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Next.TabIndex = 142
        Me.btn_Next.TabStop = False
        Me.btn_Next.Visible = False
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
        Me.cmb_PmPost.Location = New System.Drawing.Point(486, 1)
        Me.cmb_PmPost.Name = "cmb_PmPost"
        Me.cmb_PmPost.OpenOnFoucus = True
        Me.cmb_PmPost.Size = New System.Drawing.Size(194, 26)
        Me.cmb_PmPost.TabIndex = 0
        Me.cmb_PmPost.Tag = ""
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(687, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 18)
        Me.Label15.TabIndex = 142
        Me.Label15.Text = "از"
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Acc_AshkhasTableAdapter
        '
        Me.Acc_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_Srl_DeviceKhesarat)
        Me.Panel3.Controls.Add(Me.cmb_PmPost)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.txt_TarikhVorod)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btn_SelectDEvice)
        Me.Panel3.Controls.Add(Me.txt_TarikhTamir)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cmb_SatheaAhamiat)
        Me.Panel3.Controls.Add(Me.txt_TarikhTahvil)
        Me.Panel3.Controls.Add(Me.txt_DeviceKhesaratName)
        Me.Panel3.Controls.Add(Me.cmb_Tavasot)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txt_tarikhTamirBaze)
        Me.Panel3.Controls.Add(Me.cmb_Elat)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txt_TarikhVorodBaze)
        Me.Panel3.Controls.Add(Me.txt_NafarSat)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(11, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(798, 169)
        Me.Panel3.TabIndex = 1
        '
        'btn_SelectDEvice
        '
        Me.btn_SelectDEvice.Location = New System.Drawing.Point(16, 4)
        Me.btn_SelectDEvice.Name = "btn_SelectDEvice"
        Me.btn_SelectDEvice.Size = New System.Drawing.Size(38, 25)
        Me.btn_SelectDEvice.TabIndex = 1
        Me.btn_SelectDEvice.Text = "..."
        Me.btn_SelectDEvice.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_Dis)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.cmb_TahvilePerson)
        Me.Panel4.Location = New System.Drawing.Point(11, 411)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(798, 93)
        Me.Panel4.TabIndex = 3
        '
        'Pm_Lab_Rol_SatheAhamniatTableAdapter
        '
        Me.Pm_Lab_Rol_SatheAhamniatTableAdapter.ClearBeforeFill = True
        '
        'Pm_Lab_Rol_ElateVorodTableAdapter
        '
        Me.Pm_Lab_Rol_ElateVorodTableAdapter.ClearBeforeFill = True
        '
        'Pm_Lab_Rol_GhatatMasrafiTableAdapter
        '
        Me.Pm_Lab_Rol_GhatatMasrafiTableAdapter.ClearBeforeFill = True
        '
        'Pm_Lab_Rol_Tamirat_GhateMasrafiTableAdapter
        '
        Me.Pm_Lab_Rol_Tamirat_GhateMasrafiTableAdapter.ClearBeforeFill = True
        '
        'Frm_Lab_Rol_Tamir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(856, 649)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Lab_Rol_Tamir"
        Me.TableName = "Pm_Lab_Rol_Tamirat"
        Me.Text = "فرم ثبت تعمیرات انجام شده"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolElateVorodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_Add_DEvice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Remove_Device, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolTamiratGhateMasrafiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolGhatatMasrafiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolSatheAhamniatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_SHow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_TarikhVorod As CS_Component.TextBox
    Friend WithEvents txt_TarikhTahvil As CS_Component.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_TarikhTamir As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_Elat As VB_Component.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_Tavasot As VB_Component.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Add_DEvice As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Remove_Device As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_Device As VB_Component.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Dis As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_NafarSat As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_TahvilePerson As VB_Component.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_tarikhTamirBaze As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_TarikhVorodBaze As CS_Component.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_No As CS_Component.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_DeviceKhesaratName As CS_Component.TextBox
    Friend WithEvents txt_TarikhSabt As CS_Component.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_SatheaAhamiat As VB_Component.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents txt_Srl_DeviceKhesarat As CS_Component.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmb_PmPost As VB_Component.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmLabRolSatheAhamniatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_SatheAhamniatTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_SatheAhamniatTableAdapter
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents PmLabRolElateVorodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_ElateVorodTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_ElateVorodTableAdapter
    Friend WithEvents AccAshkhasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents tbox_Tedad As CS_Component.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PmLabRolGhatatMasrafiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_GhatatMasrafiTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_GhatatMasrafiTableAdapter
    Friend WithEvents PmLabRolGhatatMasrafiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قطعهمصرفیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعدادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmLabRolTamiratGhateMasrafiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_Tamirat_GhateMasrafiTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_Tamirat_GhateMasrafiTableAdapter
    Friend WithEvents btn_SHow As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Before As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Next As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_SelectDEvice As System.Windows.Forms.Button
End Class
