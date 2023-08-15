<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_MonthReport
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
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.rb_pm = New System.Windows.Forms.RadioButton
        Me.rb_Mazad = New System.Windows.Forms.RadioButton
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.cmb_Contract = New VB_Component.ComboBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.Label2 = New System.Windows.Forms.Label
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rb_allPOrM = New System.Windows.Forms.RadioButton
        Me.PmConRpRemainedItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_Rp_RemainedItemTableAdapter = New Nama_PM.Ds_ConTableAdapters.pm_Con_Rp_RemainedItemTableAdapter
        Me.chk_Vahed = New System.Windows.Forms.CheckBox
        Me.PmPostTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmConSourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_SourceTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
        Me.Pm_PostTypeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
        Me.txt_year = New CS_Component.TextBox
        Me.PmMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Pm_MonthTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_MonthTableAdapter
        Me.cmb_GroupByName = New VB_Component.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chk_Omoor = New System.Windows.Forms.CheckBox
        Me.chk_Source = New System.Windows.Forms.CheckBox
        Me.RpPmMonthReportOmoorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_Pm_MonthReport_OmoorTableAdapter = New Nama_PM.Ds_ConTableAdapters.Rp_Pm_MonthReport_OmoorTableAdapter
        Me.DGV_Vahed = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامواحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ضریبDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGV_Source = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عنوانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGV_Omoor = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SrlDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعپستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chk_Month = New System.Windows.Forms.CheckBox
        Me.DGV_Month = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SrlDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PmConRpRemainedItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpPmMonthReportOmoorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Vahed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Source, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Omoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Month, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(9, 407)
        Me.gbx_Buttons.Size = New System.Drawing.Size(747, 52)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 15)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(643, 15)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.DGV_Month)
        Me.gbx_Fields.Controls.Add(Me.DGV_Omoor)
        Me.gbx_Fields.Controls.Add(Me.DGV_Source)
        Me.gbx_Fields.Controls.Add(Me.DGV_Vahed)
        Me.gbx_Fields.Controls.Add(Me.txt_year)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.cmb_GroupByName)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.chk_Source)
        Me.gbx_Fields.Controls.Add(Me.chk_Month)
        Me.gbx_Fields.Controls.Add(Me.chk_Omoor)
        Me.gbx_Fields.Controls.Add(Me.chk_Vahed)
        Me.gbx_Fields.Controls.Add(Me.cmb_Contract)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Location = New System.Drawing.Point(9, 60)
        Me.gbx_Fields.Size = New System.Drawing.Size(743, 348)
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'rb_pm
        '
        Me.rb_pm.AutoSize = True
        Me.rb_pm.Location = New System.Drawing.Point(107, 3)
        Me.rb_pm.Name = "rb_pm"
        Me.rb_pm.Size = New System.Drawing.Size(63, 22)
        Me.rb_pm.TabIndex = 163
        Me.rb_pm.Text = "پی ام"
        Me.rb_pm.UseVisualStyleBackColor = True
        '
        'rb_Mazad
        '
        Me.rb_Mazad.AutoSize = True
        Me.rb_Mazad.Location = New System.Drawing.Point(25, 3)
        Me.rb_Mazad.Name = "rb_Mazad"
        Me.rb_Mazad.Size = New System.Drawing.Size(75, 22)
        Me.rb_Mazad.TabIndex = 163
        Me.rb_Mazad.Text = "کار مازاد"
        Me.rb_Mazad.UseVisualStyleBackColor = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'cmb_Contract
        '
        Me.cmb_Contract.AutoComplete = True
        Me.cmb_Contract.DataSource = Me.PmConContractBindingSource
        Me.cmb_Contract.DisplayMember = "عنوان"
        Me.cmb_Contract.EnterStop = True
        Me.cmb_Contract.FormattingEnabled = True
        Me.cmb_Contract.IsRequired = False
        Me.cmb_Contract.LimitedToList = True
        Me.cmb_Contract.Location = New System.Drawing.Point(467, 13)
        Me.cmb_Contract.Name = "cmb_Contract"
        Me.cmb_Contract.OpenOnFoucus = True
        Me.cmb_Contract.Size = New System.Drawing.Size(214, 26)
        Me.cmb_Contract.TabIndex = 161
        Me.cmb_Contract.ValueMember = "Srl"
        '
        'PmConContractBindingSource
        '
        Me.PmConContractBindingSource.DataMember = "Pm_Con_Contract"
        Me.PmConContractBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(687, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "قرارداد"
        '
        'Pm_Con_ContractTableAdapter
        '
        Me.Pm_Con_ContractTableAdapter.ClearBeforeFill = True
        '
        'PmLineBindingSource
        '
        Me.PmLineBindingSource.DataMember = "Pm_Line"
        Me.PmLineBindingSource.DataSource = Me.Ds_Pm
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_allPOrM)
        Me.Panel1.Controls.Add(Me.rb_pm)
        Me.Panel1.Controls.Add(Me.rb_Mazad)
        Me.Panel1.Location = New System.Drawing.Point(202, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 28)
        Me.Panel1.TabIndex = 166
        '
        'rb_allPOrM
        '
        Me.rb_allPOrM.AutoSize = True
        Me.rb_allPOrM.Checked = True
        Me.rb_allPOrM.Location = New System.Drawing.Point(176, 3)
        Me.rb_allPOrM.Name = "rb_allPOrM"
        Me.rb_allPOrM.Size = New System.Drawing.Size(54, 22)
        Me.rb_allPOrM.TabIndex = 163
        Me.rb_allPOrM.TabStop = True
        Me.rb_allPOrM.Text = "همه"
        Me.rb_allPOrM.UseVisualStyleBackColor = True
        '
        'PmConRpRemainedItemBindingSource
        '
        Me.PmConRpRemainedItemBindingSource.DataMember = "pm_Con_Rp_RemainedItem"
        Me.PmConRpRemainedItemBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_Rp_RemainedItemTableAdapter
        '
        Me.Pm_Con_Rp_RemainedItemTableAdapter.ClearBeforeFill = True
        '
        'chk_Vahed
        '
        Me.chk_Vahed.AutoSize = True
        Me.chk_Vahed.Checked = True
        Me.chk_Vahed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Vahed.Location = New System.Drawing.Point(681, 44)
        Me.chk_Vahed.Name = "chk_Vahed"
        Me.chk_Vahed.Size = New System.Drawing.Size(55, 22)
        Me.chk_Vahed.TabIndex = 162
        Me.chk_Vahed.Text = "واحد"
        Me.chk_Vahed.UseVisualStyleBackColor = True
        '
        'PmPostTypeBindingSource
        '
        Me.PmPostTypeBindingSource.DataMember = "Pm_PostType"
        Me.PmPostTypeBindingSource.DataSource = Me.Ds_Pm
        '
        'PmConSourceBindingSource
        '
        Me.PmConSourceBindingSource.DataMember = "Pm_Con_Source"
        Me.PmConSourceBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_SourceTableAdapter
        '
        Me.Pm_Con_SourceTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTypeTableAdapter
        '
        Me.Pm_PostTypeTableAdapter.ClearBeforeFill = True
        '
        'txt_year
        '
        Me.txt_year.CheckExistValueInDb = False
        Me.txt_year.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_year.CurrencyUnit = "ریال"
        Me.txt_year.DefaultValue = ""
        Me.txt_year.FillWithMaxInDb = False
        Me.txt_year.IsRequired = True
        Me.txt_year.Location = New System.Drawing.Point(14, 13)
        Me.txt_year.MaxDecimalLength = 2
        Me.txt_year.Name = "txt_year"
        Me.txt_year.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_year.Size = New System.Drawing.Size(61, 26)
        Me.txt_year.SpellControl = Nothing
        Me.txt_year.TabIndex = 171
        Me.txt_year.Tag = "Year"
        Me.txt_year.Title = Nothing
        Me.txt_year.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_year.UseForData = True
        Me.txt_year.ValidateCheckExistOnEdit = False
        Me.txt_year.Value = ""
        '
        'PmMonthBindingSource
        '
        Me.PmMonthBindingSource.DataMember = "Pm_Month"
        Me.PmMonthBindingSource.DataSource = Me.Ds_Con
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 18)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "سال"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Pm_MonthTableAdapter
        '
        Me.Pm_MonthTableAdapter.ClearBeforeFill = True
        '
        'cmb_GroupByName
        '
        Me.cmb_GroupByName.AutoComplete = True
        Me.cmb_GroupByName.DisplayMember = "نوع پست"
        Me.cmb_GroupByName.EnterStop = True
        Me.cmb_GroupByName.FormattingEnabled = True
        Me.cmb_GroupByName.IsRequired = False
        Me.cmb_GroupByName.Items.AddRange(New Object() {"امور و منبع", "واحد", "ماه"})
        Me.cmb_GroupByName.LimitedToList = True
        Me.cmb_GroupByName.Location = New System.Drawing.Point(14, 306)
        Me.cmb_GroupByName.Name = "cmb_GroupByName"
        Me.cmb_GroupByName.OpenOnFoucus = False
        Me.cmb_GroupByName.Size = New System.Drawing.Size(214, 26)
        Me.cmb_GroupByName.TabIndex = 168
        Me.cmb_GroupByName.Tag = "Srl_Pm_PostType"
        Me.cmb_GroupByName.ValueMember = "Srl"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "گروه بندی"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_Omoor
        '
        Me.chk_Omoor.AutoSize = True
        Me.chk_Omoor.Checked = True
        Me.chk_Omoor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Omoor.Location = New System.Drawing.Point(278, 44)
        Me.chk_Omoor.Name = "chk_Omoor"
        Me.chk_Omoor.Size = New System.Drawing.Size(51, 22)
        Me.chk_Omoor.TabIndex = 162
        Me.chk_Omoor.Text = "امور"
        Me.chk_Omoor.UseVisualStyleBackColor = True
        '
        'chk_Source
        '
        Me.chk_Source.AutoSize = True
        Me.chk_Source.Checked = True
        Me.chk_Source.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Source.Location = New System.Drawing.Point(479, 44)
        Me.chk_Source.Name = "chk_Source"
        Me.chk_Source.Size = New System.Drawing.Size(54, 22)
        Me.chk_Source.TabIndex = 162
        Me.chk_Source.Text = "منبع"
        Me.chk_Source.UseVisualStyleBackColor = True
        '
        'RpPmMonthReportOmoorBindingSource
        '
        Me.RpPmMonthReportOmoorBindingSource.DataMember = "Rp_Pm_MonthReport_Omoor"
        Me.RpPmMonthReportOmoorBindingSource.DataSource = Me.Ds_Con
        '
        'Rp_Pm_MonthReport_OmoorTableAdapter
        '
        Me.Rp_Pm_MonthReport_OmoorTableAdapter.ClearBeforeFill = True
        '
        'DGV_Vahed
        '
        Me.DGV_Vahed.AutoGenerateColumns = False
        Me.DGV_Vahed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Vahed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.SrlDataGridViewTextBoxColumn, Me.کدDataGridViewTextBoxColumn, Me.نامواحدDataGridViewTextBoxColumn, Me.ضریبDataGridViewTextBoxColumn})
        Me.DGV_Vahed.DataSource = Me.PmVahedBindingSource
        Me.DGV_Vahed.Enabled = False
        Me.DGV_Vahed.Location = New System.Drawing.Point(543, 72)
        Me.DGV_Vahed.Name = "DGV_Vahed"
        Me.DGV_Vahed.RowHeadersVisible = False
        Me.DGV_Vahed.Size = New System.Drawing.Size(193, 213)
        Me.DGV_Vahed.TabIndex = 175
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 25
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'کدDataGridViewTextBoxColumn
        '
        Me.کدDataGridViewTextBoxColumn.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn.Name = "کدDataGridViewTextBoxColumn"
        Me.کدDataGridViewTextBoxColumn.Visible = False
        '
        'نامواحدDataGridViewTextBoxColumn
        '
        Me.نامواحدDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامواحدDataGridViewTextBoxColumn.DataPropertyName = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.HeaderText = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.Name = "نامواحدDataGridViewTextBoxColumn"
        '
        'ضریبDataGridViewTextBoxColumn
        '
        Me.ضریبDataGridViewTextBoxColumn.DataPropertyName = "ضریب"
        Me.ضریبDataGridViewTextBoxColumn.HeaderText = "ضریب"
        Me.ضریبDataGridViewTextBoxColumn.Name = "ضریبDataGridViewTextBoxColumn"
        Me.ضریبDataGridViewTextBoxColumn.Visible = False
        '
        'DGV_Source
        '
        Me.DGV_Source.AutoGenerateColumns = False
        Me.DGV_Source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Source.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.SrlDataGridViewTextBoxColumn1, Me.عنوانDataGridViewTextBoxColumn})
        Me.DGV_Source.DataSource = Me.PmConSourceBindingSource
        Me.DGV_Source.Enabled = False
        Me.DGV_Source.Location = New System.Drawing.Point(340, 72)
        Me.DGV_Source.Name = "DGV_Source"
        Me.DGV_Source.RowHeadersVisible = False
        Me.DGV_Source.Size = New System.Drawing.Size(193, 213)
        Me.DGV_Source.TabIndex = 175
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 25
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn1.Visible = False
        '
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        '
        'DGV_Omoor
        '
        Me.DGV_Omoor.AutoGenerateColumns = False
        Me.DGV_Omoor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Omoor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.SrlDataGridViewTextBoxColumn2, Me.کدDataGridViewTextBoxColumn1, Me.نوعپستDataGridViewTextBoxColumn})
        Me.DGV_Omoor.DataSource = Me.PmPostTypeBindingSource
        Me.DGV_Omoor.Enabled = False
        Me.DGV_Omoor.Location = New System.Drawing.Point(175, 72)
        Me.DGV_Omoor.Name = "DGV_Omoor"
        Me.DGV_Omoor.RowHeadersVisible = False
        Me.DGV_Omoor.Size = New System.Drawing.Size(154, 213)
        Me.DGV_Omoor.TabIndex = 175
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = ""
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 25
        '
        'SrlDataGridViewTextBoxColumn2
        '
        Me.SrlDataGridViewTextBoxColumn2.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.Name = "SrlDataGridViewTextBoxColumn2"
        Me.SrlDataGridViewTextBoxColumn2.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn2.Visible = False
        '
        'کدDataGridViewTextBoxColumn1
        '
        Me.کدDataGridViewTextBoxColumn1.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn1.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn1.Name = "کدDataGridViewTextBoxColumn1"
        Me.کدDataGridViewTextBoxColumn1.Visible = False
        '
        'نوعپستDataGridViewTextBoxColumn
        '
        Me.نوعپستDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نوعپستDataGridViewTextBoxColumn.DataPropertyName = "نوع پست"
        Me.نوعپستDataGridViewTextBoxColumn.HeaderText = "امور"
        Me.نوعپستDataGridViewTextBoxColumn.Name = "نوعپستDataGridViewTextBoxColumn"
        '
        'chk_Month
        '
        Me.chk_Month.AutoSize = True
        Me.chk_Month.Checked = True
        Me.chk_Month.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Month.Location = New System.Drawing.Point(119, 44)
        Me.chk_Month.Name = "chk_Month"
        Me.chk_Month.Size = New System.Drawing.Size(46, 22)
        Me.chk_Month.TabIndex = 162
        Me.chk_Month.Text = "ماه"
        Me.chk_Month.UseVisualStyleBackColor = True
        '
        'DGV_Month
        '
        Me.DGV_Month.AutoGenerateColumns = False
        Me.DGV_Month.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Month.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn3, Me.SrlDataGridViewTextBoxColumn3, Me.NameDataGridViewTextBoxColumn})
        Me.DGV_Month.DataSource = Me.PmMonthBindingSource
        Me.DGV_Month.Enabled = False
        Me.DGV_Month.Location = New System.Drawing.Point(11, 72)
        Me.DGV_Month.Name = "DGV_Month"
        Me.DGV_Month.RowHeadersVisible = False
        Me.DGV_Month.Size = New System.Drawing.Size(154, 213)
        Me.DGV_Month.TabIndex = 175
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.HeaderText = ""
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 25
        '
        'SrlDataGridViewTextBoxColumn3
        '
        Me.SrlDataGridViewTextBoxColumn3.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn3.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn3.Name = "SrlDataGridViewTextBoxColumn3"
        Me.SrlDataGridViewTextBoxColumn3.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn3.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "نام"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'Frm_Rp_MonthReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(766, 491)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Rp_MonthReport"
        Me.Text = "گزارش صورت وضعیت"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PmConRpRemainedItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpPmMonthReportOmoorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Vahed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Source, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Omoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Month, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents rb_Mazad As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pm As System.Windows.Forms.RadioButton
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents cmb_Contract As VB_Component.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_allPOrM As System.Windows.Forms.RadioButton
    Friend WithEvents PmConRpRemainedItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_Rp_RemainedItemTableAdapter As Nama_PM.Ds_ConTableAdapters.pm_Con_Rp_RemainedItemTableAdapter
    Friend WithEvents chk_Vahed As System.Windows.Forms.CheckBox
    Friend WithEvents PmConSourceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_SourceTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
    Friend WithEvents PmPostTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTypeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
    Public WithEvents txt_year As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PmMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_MonthTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_MonthTableAdapter
    Friend WithEvents cmb_GroupByName As VB_Component.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_Source As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Omoor As System.Windows.Forms.CheckBox
    Friend WithEvents RpPmMonthReportOmoorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_Pm_MonthReport_OmoorTableAdapter As Nama_PM.Ds_ConTableAdapters.Rp_Pm_MonthReport_OmoorTableAdapter
    Friend WithEvents DGV_Vahed As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Omoor As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Source As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ضریبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Month As System.Windows.Forms.DataGridView
    Friend WithEvents chk_Month As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
