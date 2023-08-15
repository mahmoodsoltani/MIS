<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpStatusStatementExtraWork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RpStatusStatementExtraWork))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RpExtraWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rb_Accounting = New System.Windows.Forms.RadioButton
        Me.rb_Mashroh = New System.Windows.Forms.RadioButton
        Me.cmb_Ashkhas = New VB_Component.ComboBox
        Me.PmAshkhasWithCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas1 = New Nama_PM.Ds_Ashkhas
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RpExtraWorkAzarakhshBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Del_Person = New System.Windows.Forms.PictureBox
        Me.Add_Person = New System.Windows.Forms.PictureBox
        Me.chk_AllPerson = New System.Windows.Forms.CheckBox
        Me.DGV_Person = New CS_Component.DataGridView
        Me.Srl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_File = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmAshkhasAzarakhshBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_AshkhasAzarakhshTableAdapter1 = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasAzarakhshTableAdapter
        Me.Acc_AshkhasTableAdapter1 = New Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cmb_Company = New VB_Component.ComboBox
        Me.PmCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Chk_AllCompany = New System.Windows.Forms.CheckBox
        Me.Pm_AshkhasWithCompanyTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasWithCompanyTableAdapter
        Me.Pm_CompanyTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_CompanyTableAdapter
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_vahed = New VB_Component.ComboBox
        Me.chk_AllVahed = New System.Windows.Forms.CheckBox
        Me.Ds_Pm1 = New Nama_PM.Ds_Pm
        Me.PmVahedBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_VahedTableAdapter1 = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.RpExtraWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasWithCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpExtraWorkAzarakhshBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Del_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasAzarakhshBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Controls.Add(Me.btn_File)
        Me.gbx_Buttons.Location = New System.Drawing.Point(15, 424)
        Me.gbx_Buttons.Size = New System.Drawing.Size(487, 50)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Cancel, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Save, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_File, 0)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(6, 15)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        Me.btn_Cancel.Visible = False
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Image = Nothing
        Me.btn_Save.Location = New System.Drawing.Point(388, 15)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Del_Person)
        Me.gbx_Fields.Controls.Add(Me.Add_Person)
        Me.gbx_Fields.Controls.Add(Me.chk_AllVahed)
        Me.gbx_Fields.Controls.Add(Me.Chk_AllCompany)
        Me.gbx_Fields.Controls.Add(Me.chk_AllPerson)
        Me.gbx_Fields.Controls.Add(Me.DGV_Person)
        Me.gbx_Fields.Controls.Add(Me.cmb_vahed)
        Me.gbx_Fields.Controls.Add(Me.Cmb_Company)
        Me.gbx_Fields.Controls.Add(Me.cmb_Ashkhas)
        Me.gbx_Fields.Controls.Add(Me.rb_Mashroh)
        Me.gbx_Fields.Controls.Add(Me.rb_Accounting)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label5)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Font = New System.Drawing.Font("B Yekan", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 52)
        Me.gbx_Fields.Size = New System.Drawing.Size(487, 366)
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(273, 20)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(151, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 2
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(433, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 18)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "از تاریخ"
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(43, 20)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(151, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 3
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "تا تاریخ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(433, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "نام"
        '
        'RpExtraWorkBindingSource
        '
        Me.RpExtraWorkBindingSource.DataMember = "Rp_ExtraWork"
        '
        'rb_Accounting
        '
        Me.rb_Accounting.AutoSize = True
        Me.rb_Accounting.Location = New System.Drawing.Point(89, 52)
        Me.rb_Accounting.Name = "rb_Accounting"
        Me.rb_Accounting.Size = New System.Drawing.Size(104, 22)
        Me.rb_Accounting.TabIndex = 11
        Me.rb_Accounting.TabStop = True
        Me.rb_Accounting.Text = "گزارش حسابداری"
        Me.rb_Accounting.UseVisualStyleBackColor = True
        '
        'rb_Mashroh
        '
        Me.rb_Mashroh.AutoSize = True
        Me.rb_Mashroh.Location = New System.Drawing.Point(334, 52)
        Me.rb_Mashroh.Name = "rb_Mashroh"
        Me.rb_Mashroh.Size = New System.Drawing.Size(90, 22)
        Me.rb_Mashroh.TabIndex = 11
        Me.rb_Mashroh.TabStop = True
        Me.rb_Mashroh.Text = "گزارش مشروح"
        Me.rb_Mashroh.UseVisualStyleBackColor = True
        '
        'cmb_Ashkhas
        '
        Me.cmb_Ashkhas.AutoComplete = True
        Me.cmb_Ashkhas.DataSource = Me.PmAshkhasWithCompanyBindingSource
        Me.cmb_Ashkhas.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Ashkhas.EnterStop = True
        Me.cmb_Ashkhas.FormattingEnabled = True
        Me.cmb_Ashkhas.IsRequired = False
        Me.cmb_Ashkhas.LimitedToList = True
        Me.cmb_Ashkhas.Location = New System.Drawing.Point(254, 157)
        Me.cmb_Ashkhas.Name = "cmb_Ashkhas"
        Me.cmb_Ashkhas.OpenOnFoucus = False
        Me.cmb_Ashkhas.Size = New System.Drawing.Size(170, 26)
        Me.cmb_Ashkhas.TabIndex = 12
        Me.cmb_Ashkhas.ValueMember = "Srl"
        '
        'PmAshkhasWithCompanyBindingSource
        '
        Me.PmAshkhasWithCompanyBindingSource.DataMember = "Pm_AshkhasWithCompany"
        Me.PmAshkhasWithCompanyBindingSource.DataSource = Me.Ds_Ashkhas1
        '
        'Ds_Ashkhas1
        '
        Me.Ds_Ashkhas1.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccAshkhasBindingSource
        '
        Me.AccAshkhasBindingSource.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource.DataSource = Me.Ds_Ashkhas1
        '
        'RpExtraWorkAzarakhshBindingSource
        '
        Me.RpExtraWorkAzarakhshBindingSource.DataMember = "Rp_ExtraWorkAzarakhsh"
        '
        'Del_Person
        '
        Me.Del_Person.Image = CType(resources.GetObject("Del_Person.Image"), System.Drawing.Image)
        Me.Del_Person.Location = New System.Drawing.Point(98, 152)
        Me.Del_Person.Name = "Del_Person"
        Me.Del_Person.Size = New System.Drawing.Size(44, 32)
        Me.Del_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Del_Person.TabIndex = 150
        Me.Del_Person.TabStop = False
        '
        'Add_Person
        '
        Me.Add_Person.Image = CType(resources.GetObject("Add_Person.Image"), System.Drawing.Image)
        Me.Add_Person.Location = New System.Drawing.Point(150, 152)
        Me.Add_Person.Name = "Add_Person"
        Me.Add_Person.Size = New System.Drawing.Size(40, 32)
        Me.Add_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Add_Person.TabIndex = 151
        Me.Add_Person.TabStop = False
        '
        'chk_AllPerson
        '
        Me.chk_AllPerson.AutoSize = True
        Me.chk_AllPerson.Location = New System.Drawing.Point(47, 160)
        Me.chk_AllPerson.Name = "chk_AllPerson"
        Me.chk_AllPerson.Size = New System.Drawing.Size(45, 22)
        Me.chk_AllPerson.TabIndex = 149
        Me.chk_AllPerson.Text = "همه"
        Me.chk_AllPerson.UseVisualStyleBackColor = True
        '
        'DGV_Person
        '
        Me.DGV_Person.AllowUserToAddRows = False
        Me.DGV_Person.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("B Yekan", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Person.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Person.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Person.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Person.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Srl, Me.NameCol})
        Me.DGV_Person.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("B Yekan", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Person.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Person.Location = New System.Drawing.Point(42, 194)
        Me.DGV_Person.MultiSelect = False
        Me.DGV_Person.Name = "DGV_Person"
        Me.DGV_Person.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("B Yekan", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Person.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Person.RowHeadersWidth = 30
        Me.DGV_Person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Person.Size = New System.Drawing.Size(382, 166)
        Me.DGV_Person.TabIndex = 148
        '
        'Srl
        '
        Me.Srl.HeaderText = "Srl"
        Me.Srl.Name = "Srl"
        Me.Srl.ReadOnly = True
        Me.Srl.Visible = False
        '
        'NameCol
        '
        Me.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameCol.HeaderText = "نام فرد"
        Me.NameCol.Name = "NameCol"
        Me.NameCol.ReadOnly = True
        '
        'btn_File
        '
        Me.btn_File.Location = New System.Drawing.Point(278, 15)
        Me.btn_File.Name = "btn_File"
        Me.btn_File.Size = New System.Drawing.Size(104, 29)
        Me.btn_File.TabIndex = 2
        Me.btn_File.Text = "خروجی فایل"
        Me.btn_File.UseVisualStyleBackColor = True
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        '
        'PmAshkhasAzarakhshBindingSource
        '
        Me.PmAshkhasAzarakhshBindingSource.DataMember = "Pm_AshkhasAzarakhsh"
        Me.PmAshkhasAzarakhshBindingSource.DataSource = Me.Ds_Ashkhas1
        '
        'Pm_AshkhasAzarakhshTableAdapter1
        '
        Me.Pm_AshkhasAzarakhshTableAdapter1.ClearBeforeFill = True
        '
        'Acc_AshkhasTableAdapter1
        '
        Me.Acc_AshkhasTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "نام شرکت"
        '
        'Cmb_Company
        '
        Me.Cmb_Company.AutoComplete = True
        Me.Cmb_Company.DataSource = Me.PmCompanyBindingSource
        Me.Cmb_Company.DisplayMember = "شرکت"
        Me.Cmb_Company.EnterStop = True
        Me.Cmb_Company.FormattingEnabled = True
        Me.Cmb_Company.IsRequired = False
        Me.Cmb_Company.LimitedToList = True
        Me.Cmb_Company.Location = New System.Drawing.Point(254, 121)
        Me.Cmb_Company.Name = "Cmb_Company"
        Me.Cmb_Company.OpenOnFoucus = False
        Me.Cmb_Company.Size = New System.Drawing.Size(170, 26)
        Me.Cmb_Company.TabIndex = 12
        Me.Cmb_Company.ValueMember = "کد"
        '
        'PmCompanyBindingSource
        '
        Me.PmCompanyBindingSource.DataMember = "Pm_Company"
        Me.PmCompanyBindingSource.DataSource = Me.Ds_Ashkhas1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "نام شرکت"
        '
        'Chk_AllCompany
        '
        Me.Chk_AllCompany.AutoSize = True
        Me.Chk_AllCompany.Location = New System.Drawing.Point(200, 123)
        Me.Chk_AllCompany.Name = "Chk_AllCompany"
        Me.Chk_AllCompany.Size = New System.Drawing.Size(45, 22)
        Me.Chk_AllCompany.TabIndex = 149
        Me.Chk_AllCompany.Text = "همه"
        Me.Chk_AllCompany.UseVisualStyleBackColor = True
        Me.Chk_AllCompany.Visible = False
        '
        'Pm_AshkhasWithCompanyTableAdapter
        '
        Me.Pm_AshkhasWithCompanyTableAdapter.ClearBeforeFill = True
        '
        'Pm_CompanyTableAdapter
        '
        Me.Pm_CompanyTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(430, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "نام واحد"
        '
        'cmb_vahed
        '
        Me.cmb_vahed.AutoComplete = True
        Me.cmb_vahed.DataSource = Me.PmVahedBindingSource1
        Me.cmb_vahed.DisplayMember = "نام واحد"
        Me.cmb_vahed.EnterStop = True
        Me.cmb_vahed.FormattingEnabled = True
        Me.cmb_vahed.IsRequired = False
        Me.cmb_vahed.LimitedToList = True
        Me.cmb_vahed.Location = New System.Drawing.Point(254, 86)
        Me.cmb_vahed.Name = "cmb_vahed"
        Me.cmb_vahed.OpenOnFoucus = False
        Me.cmb_vahed.Size = New System.Drawing.Size(170, 26)
        Me.cmb_vahed.TabIndex = 12
        Me.cmb_vahed.ValueMember = "Srl"
        '
        'chk_AllVahed
        '
        Me.chk_AllVahed.AutoSize = True
        Me.chk_AllVahed.Checked = True
        Me.chk_AllVahed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_AllVahed.Location = New System.Drawing.Point(200, 88)
        Me.chk_AllVahed.Name = "chk_AllVahed"
        Me.chk_AllVahed.Size = New System.Drawing.Size(45, 22)
        Me.chk_AllVahed.TabIndex = 149
        Me.chk_AllVahed.Text = "همه"
        Me.chk_AllVahed.UseVisualStyleBackColor = True
        '
        'Ds_Pm1
        '
        Me.Ds_Pm1.DataSetName = "Ds_Pm"
        Me.Ds_Pm1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmVahedBindingSource1
        '
        Me.PmVahedBindingSource1.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource1.DataSource = Me.Ds_Pm1
        '
        'Pm_VahedTableAdapter1
        '
        Me.Pm_VahedTableAdapter1.ClearBeforeFill = True
        '
        'Frm_RpStatusStatementExtraWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(512, 508)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpStatusStatementExtraWork"
        Me.Text = "گزارش مشروح اضافه کار بر مبنای کارمزدی"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.RpExtraWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasWithCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpExtraWorkAzarakhshBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Del_Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasAzarakhshBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents RpExtraWorkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_ExtraWorkTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_ExtraWorkTableAdapter
    Friend WithEvents rb_Mashroh As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Accounting As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_Ashkhas As VB_Component.ComboBox
    Friend WithEvents Del_Person As System.Windows.Forms.PictureBox
    Friend WithEvents Add_Person As System.Windows.Forms.PictureBox
    Friend WithEvents chk_AllPerson As System.Windows.Forms.CheckBox
    Friend WithEvents DGV_Person As CS_Component.DataGridView
    Friend WithEvents Srl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_File As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents RpExtraWorkAzarakhshBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_ExtraWorkAzarakhshTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_ExtraWorkAzarakhshTableAdapter
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents Pm_AshkhasAzarakhshTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasAzarakhshTableAdapter
    Friend WithEvents Ds_Ashkhas1 As Nama_PM.Ds_Ashkhas
    Friend WithEvents PmAshkhasAzarakhshBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasAzarakhshTableAdapter1 As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasAzarakhshTableAdapter
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc_AshkhasTableAdapter1 As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents Chk_AllCompany As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_Company As VB_Component.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PmAshkhasWithCompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasWithCompanyTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasWithCompanyTableAdapter
    Friend WithEvents PmCompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_CompanyTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_CompanyTableAdapter
    Friend WithEvents chk_AllVahed As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_vahed As VB_Component.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm1 As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter1 As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
End Class
