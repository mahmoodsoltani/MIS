<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_ContractItem
    Inherits BaseForm_Layer

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
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عنوانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مقدارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.قیمتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.دورهزمانیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmConContractItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.cmb_item = New VB_Component.ComboBox
        Me.PmConItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_amount = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PmConUnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_Con_UnitTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_UnitTableAdapter
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Rb_All = New System.Windows.Forms.RadioButton
        Me.Rb_PM = New System.Windows.Forms.RadioButton
        Me.Rb_Mazad = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.cmb_Contract = New VB_Component.ComboBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.Pm_Con_ContractItemsTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractItemsTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_code = New VB_Component.ComboBox
        Me.Pm_Con_ItemTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ItemTableAdapter
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_price = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_period = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConUnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(430, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(677, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(553, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.cmb_vahed)
        Me.gbx_GridViewList.Controls.Add(Me.Label5)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_Contract)
        Me.gbx_GridViewList.Controls.Add(Me.Label11)
        Me.gbx_GridViewList.Controls.Add(Me.Rb_Mazad)
        Me.gbx_GridViewList.Controls.Add(Me.Rb_PM)
        Me.gbx_GridViewList.Controls.Add(Me.Rb_All)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(800, 341)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.RadioButton2)
        Me.gbx_Controls.Controls.Add(Me.RadioButton1)
        Me.gbx_Controls.Controls.Add(Me.txt_period)
        Me.gbx_Controls.Controls.Add(Me.txt_price)
        Me.gbx_Controls.Controls.Add(Me.txt_amount)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.cmb_code)
        Me.gbx_Controls.Controls.Add(Me.cmb_item)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 453)
        Me.gbx_Controls.Size = New System.Drawing.Size(800, 122)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 387)
        Me.gbx_Btn.Size = New System.Drawing.Size(800, 60)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.کدDataGridViewTextBoxColumn, Me.عنوانDataGridViewTextBoxColumn, Me.مقدارDataGridViewTextBoxColumn, Me.قیمتDataGridViewTextBoxColumn, Me.دورهزمانیDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmConContractItemsBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(794, 278)
        Me.DataGridView1.TabIndex = 5
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'کدDataGridViewTextBoxColumn
        '
        Me.کدDataGridViewTextBoxColumn.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn.Name = "کدDataGridViewTextBoxColumn"
        Me.کدDataGridViewTextBoxColumn.ReadOnly = True
        '
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        Me.عنوانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مقدارDataGridViewTextBoxColumn
        '
        Me.مقدارDataGridViewTextBoxColumn.DataPropertyName = "مقدار"
        Me.مقدارDataGridViewTextBoxColumn.HeaderText = "مقدار"
        Me.مقدارDataGridViewTextBoxColumn.Name = "مقدارDataGridViewTextBoxColumn"
        Me.مقدارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'قیمتDataGridViewTextBoxColumn
        '
        Me.قیمتDataGridViewTextBoxColumn.DataPropertyName = "قیمت"
        Me.قیمتDataGridViewTextBoxColumn.HeaderText = "قیمت"
        Me.قیمتDataGridViewTextBoxColumn.Name = "قیمتDataGridViewTextBoxColumn"
        Me.قیمتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'دورهزمانیDataGridViewTextBoxColumn
        '
        Me.دورهزمانیDataGridViewTextBoxColumn.DataPropertyName = "دوره زمانی"
        Me.دورهزمانیDataGridViewTextBoxColumn.HeaderText = "دوره زمانی"
        Me.دورهزمانیDataGridViewTextBoxColumn.Name = "دورهزمانیDataGridViewTextBoxColumn"
        Me.دورهزمانیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmConContractItemsBindingSource
        '
        Me.PmConContractItemsBindingSource.DataMember = "Pm_Con_ContractItems"
        Me.PmConContractItemsBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_item
        '
        Me.cmb_item.AutoComplete = True
        Me.cmb_item.DataSource = Me.PmConItemBindingSource
        Me.cmb_item.DisplayMember = "عنوان"
        Me.cmb_item.EnterStop = True
        Me.cmb_item.FormattingEnabled = True
        Me.cmb_item.IsRequired = False
        Me.cmb_item.LimitedToList = True
        Me.cmb_item.Location = New System.Drawing.Point(251, 28)
        Me.cmb_item.Name = "cmb_item"
        Me.cmb_item.OpenOnFoucus = False
        Me.cmb_item.Size = New System.Drawing.Size(350, 26)
        Me.cmb_item.TabIndex = 1
        Me.cmb_item.Tag = "srl_item"
        Me.cmb_item.ValueMember = "Srl"
        '
        'PmConItemBindingSource
        '
        Me.PmConItemBindingSource.DataMember = "Pm_Con_Item"
        Me.PmConItemBindingSource.DataSource = Me.Ds_Con
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(751, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "تعداد"
        '
        'txt_amount
        '
        Me.txt_amount.CheckExistValueInDb = False
        Me.txt_amount.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_amount.CurrencyUnit = "ریال"
        Me.txt_amount.DefaultValue = ""
        Me.txt_amount.FillWithMaxInDb = False
        Me.txt_amount.IsRequired = True
        Me.txt_amount.Location = New System.Drawing.Point(661, 66)
        Me.txt_amount.MaxDecimalLength = 2
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_amount.Size = New System.Drawing.Size(84, 26)
        Me.txt_amount.SpellControl = Nothing
        Me.txt_amount.TabIndex = 2
        Me.txt_amount.Tag = "amount"
        Me.txt_amount.Text = "0"
        Me.txt_amount.Title = Nothing
        Me.txt_amount.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_amount.UseForData = True
        Me.txt_amount.ValidateCheckExistOnEdit = False
        Me.txt_amount.Value = 0.0!
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(766, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "کد"
        '
        'PmConUnitBindingSource
        '
        Me.PmConUnitBindingSource.DataMember = "Pm_Con_Unit"
        Me.PmConUnitBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_UnitTableAdapter
        '
        Me.Pm_Con_UnitTableAdapter.ClearBeforeFill = True
        '
        'Rb_All
        '
        Me.Rb_All.AutoSize = True
        Me.Rb_All.Checked = True
        Me.Rb_All.Location = New System.Drawing.Point(148, 28)
        Me.Rb_All.Name = "Rb_All"
        Me.Rb_All.Size = New System.Drawing.Size(54, 22)
        Me.Rb_All.TabIndex = 6
        Me.Rb_All.TabStop = True
        Me.Rb_All.Text = "همه"
        Me.Rb_All.UseVisualStyleBackColor = True
        '
        'Rb_PM
        '
        Me.Rb_PM.AutoSize = True
        Me.Rb_PM.Location = New System.Drawing.Point(88, 28)
        Me.Rb_PM.Name = "Rb_PM"
        Me.Rb_PM.Size = New System.Drawing.Size(46, 22)
        Me.Rb_PM.TabIndex = 6
        Me.Rb_PM.Text = "PM"
        Me.Rb_PM.UseVisualStyleBackColor = True
        '
        'Rb_Mazad
        '
        Me.Rb_Mazad.AutoSize = True
        Me.Rb_Mazad.Location = New System.Drawing.Point(7, 28)
        Me.Rb_Mazad.Name = "Rb_Mazad"
        Me.Rb_Mazad.Size = New System.Drawing.Size(75, 22)
        Me.Rb_Mazad.TabIndex = 6
        Me.Rb_Mazad.Text = "کار مازاد"
        Me.Rb_Mazad.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(586, -365)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 22)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.Text = "PM"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(505, -365)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 22)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.Text = "کار مازاد"
        Me.RadioButton2.UseVisualStyleBackColor = True
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
        Me.cmb_Contract.Location = New System.Drawing.Point(515, 24)
        Me.cmb_Contract.Name = "cmb_Contract"
        Me.cmb_Contract.OpenOnFoucus = False
        Me.cmb_Contract.Size = New System.Drawing.Size(215, 26)
        Me.cmb_Contract.TabIndex = 1013
        Me.cmb_Contract.Tag = ""
        Me.cmb_Contract.ValueMember = "Srl"
        '
        'PmConContractBindingSource
        '
        Me.PmConContractBindingSource.DataMember = "Pm_Con_Contract"
        Me.PmConContractBindingSource.DataSource = Me.Ds_Con
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(736, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 18)
        Me.Label11.TabIndex = 1014
        Me.Label11.Text = "قرارداد"
        '
        'Pm_Con_ContractTableAdapter
        '
        Me.Pm_Con_ContractTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_ContractItemsTableAdapter
        '
        Me.Pm_Con_ContractItemsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(607, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "عنوان"
        '
        'cmb_code
        '
        Me.cmb_code.AutoComplete = True
        Me.cmb_code.DataSource = Me.PmConItemBindingSource
        Me.cmb_code.DisplayMember = "کد"
        Me.cmb_code.EnterStop = True
        Me.cmb_code.FormattingEnabled = True
        Me.cmb_code.IsRequired = False
        Me.cmb_code.LimitedToList = True
        Me.cmb_code.Location = New System.Drawing.Point(661, 28)
        Me.cmb_code.Name = "cmb_code"
        Me.cmb_code.OpenOnFoucus = False
        Me.cmb_code.Size = New System.Drawing.Size(99, 26)
        Me.cmb_code.TabIndex = 0
        Me.cmb_code.Tag = "srl_vahed"
        Me.cmb_code.ValueMember = "Srl"
        '
        'Pm_Con_ItemTableAdapter
        '
        Me.Pm_Con_ItemTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(575, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "قیمت واحد"
        '
        'txt_price
        '
        Me.txt_price.CheckExistValueInDb = False
        Me.txt_price.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_price.CurrencyUnit = "ریال"
        Me.txt_price.DefaultValue = ""
        Me.txt_price.FillWithMaxInDb = False
        Me.txt_price.IsRequired = True
        Me.txt_price.Location = New System.Drawing.Point(485, 66)
        Me.txt_price.MaxDecimalLength = 2
        Me.txt_price.Name = "txt_price"
        Me.txt_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_price.Size = New System.Drawing.Size(84, 26)
        Me.txt_price.SpellControl = Nothing
        Me.txt_price.TabIndex = 3
        Me.txt_price.Tag = "price"
        Me.txt_price.Text = "0"
        Me.txt_price.Title = Nothing
        Me.txt_price.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_price.UseForData = True
        Me.txt_price.ValidateCheckExistOnEdit = False
        Me.txt_price.Value = 0.0!
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "دوره زمانی"
        '
        'txt_period
        '
        Me.txt_period.CheckExistValueInDb = False
        Me.txt_period.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_period.CurrencyUnit = "ریال"
        Me.txt_period.DefaultValue = ""
        Me.txt_period.FillWithMaxInDb = False
        Me.txt_period.IsRequired = True
        Me.txt_period.Location = New System.Drawing.Point(301, 66)
        Me.txt_period.MaxDecimalLength = 2
        Me.txt_period.Name = "txt_period"
        Me.txt_period.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_period.Size = New System.Drawing.Size(84, 26)
        Me.txt_period.SpellControl = Nothing
        Me.txt_period.TabIndex = 4
        Me.txt_period.Tag = "period"
        Me.txt_period.Text = "0"
        Me.txt_period.Title = Nothing
        Me.txt_period.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_period.UseForData = True
        Me.txt_period.ValidateCheckExistOnEdit = False
        Me.txt_period.Value = 0.0!
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(453, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 18)
        Me.Label5.TabIndex = 1014
        Me.Label5.Text = "واحد"
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
        Me.cmb_vahed.Location = New System.Drawing.Point(232, 24)
        Me.cmb_vahed.Name = "cmb_vahed"
        Me.cmb_vahed.OpenOnFoucus = False
        Me.cmb_vahed.Size = New System.Drawing.Size(215, 26)
        Me.cmb_vahed.TabIndex = 1013
        Me.cmb_vahed.Tag = ""
        Me.cmb_vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource1
        '
        Me.PmVahedBindingSource1.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource1.DataSource = Me.Ds_Pm
        '
        'Frm_Con_ContractItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(828, 614)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_ContractItem"
        Me.TableName = "pm_Con_ContractItems"
        Me.Text = "تعیین آیتم های قرارداد"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConUnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_item As VB_Component.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_amount As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmConUnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_UnitTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_UnitTableAdapter
    Friend WithEvents Rb_Mazad As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_PM As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_Contract As VB_Component.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مقدارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قیمتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents دورهزمانیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmConContractItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractItemsTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractItemsTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_period As CS_Component.TextBox
    Friend WithEvents txt_price As CS_Component.TextBox
    Friend WithEvents cmb_code As VB_Component.ComboBox
    Friend WithEvents PmConItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Pm_Con_ItemTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ItemTableAdapter
    Friend WithEvents cmb_vahed As VB_Component.ComboBox
    Friend WithEvents PmVahedBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
