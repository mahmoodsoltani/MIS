<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_Non_MonthReportVw
    Inherits BaseForm_View
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
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.btn_Update = New System.Windows.Forms.PictureBox
        Me.DGV_Month = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DGV_Omoor = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعپستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmPostTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.DGV_Source = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DGV_Vahed = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ضریبDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_year = New CS_Component.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rb_allPOrM = New System.Windows.Forms.RadioButton
        Me.rb_pm = New System.Windows.Forms.RadioButton
        Me.rb_Mazad = New System.Windows.Forms.RadioButton
        Me.chk_Source = New System.Windows.Forms.CheckBox
        Me.chk_Month = New System.Windows.Forms.CheckBox
        Me.chk_Omoor = New System.Windows.Forms.CheckBox
        Me.chk_Vahed = New System.Windows.Forms.CheckBox
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_PostTypeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
        Me.chk_allContract = New System.Windows.Forms.CheckBox
        Me.DGV_Contract = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عنوانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmConSourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عنوانDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخشروعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخخاتمهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmConContractBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.عنوانآیتمDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تعدادDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.قیمتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.واحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ماهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سالDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.منبعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.امورDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmConNonMonthReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.Pm_Con_SourceTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
        Me.Pm_MonthTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_MonthTableAdapter
        Me.Pm_Con_Non_MonthReportTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_Non_MonthReportTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_sum = New CS_Component.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Month, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Omoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Source, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Vahed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_Contract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConNonMonthReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(14, 662)
        Me.GroupBox1.Size = New System.Drawing.Size(987, 53)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(16, 16)
        Me.btn_Cancel.Size = New System.Drawing.Size(99, 29)
        Me.btn_Cancel.Visible = False
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(661, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(101, 29)
        Me.btn_Delete.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(769, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(101, 29)
        Me.btn_Edit.Visible = False
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(876, 17)
        Me.btn_New.Size = New System.Drawing.Size(101, 29)
        Me.btn_New.Visible = False
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.DGV_Month)
        Me.gbx_DataGridView.Controls.Add(Me.DGV_Omoor)
        Me.gbx_DataGridView.Controls.Add(Me.DGV_Source)
        Me.gbx_DataGridView.Controls.Add(Me.DGV_Contract)
        Me.gbx_DataGridView.Controls.Add(Me.DGV_Vahed)
        Me.gbx_DataGridView.Controls.Add(Me.txt_sum)
        Me.gbx_DataGridView.Controls.Add(Me.Label1)
        Me.gbx_DataGridView.Controls.Add(Me.txt_year)
        Me.gbx_DataGridView.Controls.Add(Me.Label3)
        Me.gbx_DataGridView.Controls.Add(Me.Panel1)
        Me.gbx_DataGridView.Controls.Add(Me.chk_Source)
        Me.gbx_DataGridView.Controls.Add(Me.chk_Month)
        Me.gbx_DataGridView.Controls.Add(Me.chk_Omoor)
        Me.gbx_DataGridView.Controls.Add(Me.chk_allContract)
        Me.gbx_DataGridView.Controls.Add(Me.chk_Vahed)
        Me.gbx_DataGridView.Controls.Add(Me.btn_Update)
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Location = New System.Drawing.Point(14, 40)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(987, 619)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.عنوانآیتمDataGridViewTextBoxColumn, Me.تعدادDataGridViewTextBoxColumn, Me.قیمتDataGridViewTextBoxColumn, Me.واحدDataGridViewTextBoxColumn, Me.ماهDataGridViewTextBoxColumn, Me.سالDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn6, Me.منبعDataGridViewTextBoxColumn, Me.امورDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmConNonMonthReportBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(0, 298)
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
        Me.DataGridView1.Size = New System.Drawing.Size(981, 273)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_Update
        '
        Me.btn_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Update.Image = Global.Nama_PM.My.Resources.Resources.refresh
        Me.btn_Update.Location = New System.Drawing.Point(16, 25)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(32, 35)
        Me.btn_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Update.TabIndex = 220
        Me.btn_Update.TabStop = False
        '
        'DGV_Month
        '
        Me.DGV_Month.AutoGenerateColumns = False
        Me.DGV_Month.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Month.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.NameDataGridViewTextBoxColumn})
        Me.DGV_Month.DataSource = Me.PmMonthBindingSource
        Me.DGV_Month.Enabled = False
        Me.DGV_Month.Location = New System.Drawing.Point(10, 79)
        Me.DGV_Month.Name = "DGV_Month"
        Me.DGV_Month.RowHeadersVisible = False
        Me.DGV_Month.Size = New System.Drawing.Size(154, 213)
        Me.DGV_Month.TabIndex = 231
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.HeaderText = ""
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 25
        '
        'DGV_Omoor
        '
        Me.DGV_Omoor.AutoGenerateColumns = False
        Me.DGV_Omoor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Omoor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.کدDataGridViewTextBoxColumn1, Me.نوعپستDataGridViewTextBoxColumn, Me.DataGridViewCheckBoxColumn2})
        Me.DGV_Omoor.DataSource = Me.PmPostTypeBindingSource
        Me.DGV_Omoor.Enabled = False
        Me.DGV_Omoor.Location = New System.Drawing.Point(174, 79)
        Me.DGV_Omoor.Name = "DGV_Omoor"
        Me.DGV_Omoor.RowHeadersVisible = False
        Me.DGV_Omoor.Size = New System.Drawing.Size(154, 213)
        Me.DGV_Omoor.TabIndex = 230
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = ""
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 25
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Srl"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Srl"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
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
        'PmPostTypeBindingSource
        '
        Me.PmPostTypeBindingSource.DataMember = "Pm_PostType"
        Me.PmPostTypeBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGV_Source
        '
        Me.DGV_Source.AutoGenerateColumns = False
        Me.DGV_Source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Source.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.عنوانDataGridViewTextBoxColumn})
        Me.DGV_Source.DataSource = Me.PmConSourceBindingSource
        Me.DGV_Source.Enabled = False
        Me.DGV_Source.Location = New System.Drawing.Point(339, 79)
        Me.DGV_Source.Name = "DGV_Source"
        Me.DGV_Source.RowHeadersVisible = False
        Me.DGV_Source.Size = New System.Drawing.Size(193, 213)
        Me.DGV_Source.TabIndex = 233
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 25
        '
        'DGV_Vahed
        '
        Me.DGV_Vahed.AutoGenerateColumns = False
        Me.DGV_Vahed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Vahed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.کدDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.ضریبDataGridViewTextBoxColumn, Me.Column1})
        Me.DGV_Vahed.DataSource = Me.PmVahedBindingSource
        Me.DGV_Vahed.Enabled = False
        Me.DGV_Vahed.Location = New System.Drawing.Point(542, 79)
        Me.DGV_Vahed.MultiSelect = False
        Me.DGV_Vahed.Name = "DGV_Vahed"
        Me.DGV_Vahed.RowHeadersVisible = False
        Me.DGV_Vahed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Vahed.Size = New System.Drawing.Size(193, 213)
        Me.DGV_Vahed.TabIndex = 232
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'کدDataGridViewTextBoxColumn
        '
        Me.کدDataGridViewTextBoxColumn.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn.Name = "کدDataGridViewTextBoxColumn"
        Me.کدDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "نام واحد"
        Me.DataGridViewTextBoxColumn2.HeaderText = "نام واحد"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'ضریبDataGridViewTextBoxColumn
        '
        Me.ضریبDataGridViewTextBoxColumn.DataPropertyName = "ضریب"
        Me.ضریبDataGridViewTextBoxColumn.HeaderText = "ضریب"
        Me.ضریبDataGridViewTextBoxColumn.Name = "ضریبDataGridViewTextBoxColumn"
        Me.ضریبDataGridViewTextBoxColumn.Visible = False
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'txt_year
        '
        Me.txt_year.CheckExistValueInDb = False
        Me.txt_year.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_year.CurrencyUnit = "ریال"
        Me.txt_year.DefaultValue = ""
        Me.txt_year.FillWithMaxInDb = False
        Me.txt_year.IsRequired = True
        Me.txt_year.Location = New System.Drawing.Point(617, 18)
        Me.txt_year.MaxDecimalLength = 2
        Me.txt_year.Name = "txt_year"
        Me.txt_year.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_year.Size = New System.Drawing.Size(61, 26)
        Me.txt_year.SpellControl = Nothing
        Me.txt_year.TabIndex = 228
        Me.txt_year.Tag = "Year"
        Me.txt_year.Title = Nothing
        Me.txt_year.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_year.UseForData = True
        Me.txt_year.ValidateCheckExistOnEdit = False
        Me.txt_year.Value = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(684, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 18)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "سال"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_allPOrM)
        Me.Panel1.Controls.Add(Me.rb_pm)
        Me.Panel1.Controls.Add(Me.rb_Mazad)
        Me.Panel1.Location = New System.Drawing.Point(738, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 28)
        Me.Panel1.TabIndex = 227
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
        'chk_Source
        '
        Me.chk_Source.AutoSize = True
        Me.chk_Source.Checked = True
        Me.chk_Source.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Source.Location = New System.Drawing.Point(426, 52)
        Me.chk_Source.Name = "chk_Source"
        Me.chk_Source.Size = New System.Drawing.Size(106, 22)
        Me.chk_Source.TabIndex = 224
        Me.chk_Source.Text = "همه منبع ها"
        Me.chk_Source.UseVisualStyleBackColor = True
        '
        'chk_Month
        '
        Me.chk_Month.AutoSize = True
        Me.chk_Month.Checked = True
        Me.chk_Month.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Month.Location = New System.Drawing.Point(66, 52)
        Me.chk_Month.Name = "chk_Month"
        Me.chk_Month.Size = New System.Drawing.Size(98, 22)
        Me.chk_Month.TabIndex = 223
        Me.chk_Month.Text = "همه ماه ها"
        Me.chk_Month.UseVisualStyleBackColor = True
        '
        'chk_Omoor
        '
        Me.chk_Omoor.AutoSize = True
        Me.chk_Omoor.Checked = True
        Me.chk_Omoor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Omoor.Location = New System.Drawing.Point(244, 52)
        Me.chk_Omoor.Name = "chk_Omoor"
        Me.chk_Omoor.Size = New System.Drawing.Size(84, 22)
        Me.chk_Omoor.TabIndex = 226
        Me.chk_Omoor.Text = "همه امور"
        Me.chk_Omoor.UseVisualStyleBackColor = True
        '
        'chk_Vahed
        '
        Me.chk_Vahed.AutoSize = True
        Me.chk_Vahed.Checked = True
        Me.chk_Vahed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Vahed.Location = New System.Drawing.Point(633, 52)
        Me.chk_Vahed.Name = "chk_Vahed"
        Me.chk_Vahed.Size = New System.Drawing.Size(102, 22)
        Me.chk_Vahed.TabIndex = 225
        Me.chk_Vahed.Text = "همه واحدها"
        Me.chk_Vahed.UseVisualStyleBackColor = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTypeTableAdapter
        '
        Me.Pm_PostTypeTableAdapter.ClearBeforeFill = True
        '
        'chk_allContract
        '
        Me.chk_allContract.AutoSize = True
        Me.chk_allContract.Checked = True
        Me.chk_allContract.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_allContract.Location = New System.Drawing.Point(860, 51)
        Me.chk_allContract.Name = "chk_allContract"
        Me.chk_allContract.Size = New System.Drawing.Size(113, 22)
        Me.chk_allContract.TabIndex = 225
        Me.chk_allContract.Text = "همه قراردادها"
        Me.chk_allContract.UseVisualStyleBackColor = True
        '
        'DGV_Contract
        '
        Me.DGV_Contract.AutoGenerateColumns = False
        Me.DGV_Contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Contract.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.عنوانDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.تاریخشروعDataGridViewTextBoxColumn, Me.تاریخخاتمهDataGridViewTextBoxColumn, Me.کدDataGridViewTextBoxColumn2})
        Me.DGV_Contract.DataSource = Me.PmConContractBindingSource1
        Me.DGV_Contract.Enabled = False
        Me.DGV_Contract.Location = New System.Drawing.Point(738, 79)
        Me.DGV_Contract.MultiSelect = False
        Me.DGV_Contract.Name = "DGV_Contract"
        Me.DGV_Contract.RowHeadersVisible = False
        Me.DGV_Contract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Contract.Size = New System.Drawing.Size(224, 213)
        Me.DGV_Contract.TabIndex = 232
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.HeaderText = ""
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 25
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "srl"
        Me.DataGridViewTextBoxColumn5.HeaderText = "srl"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "ماه"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PmMonthBindingSource
        '
        Me.PmMonthBindingSource.DataMember = "Pm_Month"
        Me.PmMonthBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Srl"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Srl"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        '
        'PmConSourceBindingSource
        '
        Me.PmConSourceBindingSource.DataMember = "Pm_Con_Source"
        Me.PmConSourceBindingSource.DataSource = Me.Ds_Con
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "srl"
        Me.DataGridViewTextBoxColumn7.HeaderText = "srl"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'عنوانDataGridViewTextBoxColumn1
        '
        Me.عنوانDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.عنوانDataGridViewTextBoxColumn1.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn1.HeaderText = "قرارداد"
        Me.عنوانDataGridViewTextBoxColumn1.Name = "عنوانDataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "توضیحات"
        Me.DataGridViewTextBoxColumn8.HeaderText = "توضیحات"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'تاریخشروعDataGridViewTextBoxColumn
        '
        Me.تاریخشروعDataGridViewTextBoxColumn.DataPropertyName = "تاریخ شروع"
        Me.تاریخشروعDataGridViewTextBoxColumn.HeaderText = "تاریخ شروع"
        Me.تاریخشروعDataGridViewTextBoxColumn.Name = "تاریخشروعDataGridViewTextBoxColumn"
        Me.تاریخشروعDataGridViewTextBoxColumn.Visible = False
        '
        'تاریخخاتمهDataGridViewTextBoxColumn
        '
        Me.تاریخخاتمهDataGridViewTextBoxColumn.DataPropertyName = "تاریخ خاتمه"
        Me.تاریخخاتمهDataGridViewTextBoxColumn.HeaderText = "تاریخ خاتمه"
        Me.تاریخخاتمهDataGridViewTextBoxColumn.Name = "تاریخخاتمهDataGridViewTextBoxColumn"
        Me.تاریخخاتمهDataGridViewTextBoxColumn.Visible = False
        '
        'کدDataGridViewTextBoxColumn2
        '
        Me.کدDataGridViewTextBoxColumn2.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn2.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn2.Name = "کدDataGridViewTextBoxColumn2"
        Me.کدDataGridViewTextBoxColumn2.Visible = False
        '
        'PmConContractBindingSource1
        '
        Me.PmConContractBindingSource1.DataMember = "Pm_Con_Contract"
        Me.PmConContractBindingSource1.DataSource = Me.Ds_Con
        '
        'عنوانآیتمDataGridViewTextBoxColumn
        '
        Me.عنوانآیتمDataGridViewTextBoxColumn.DataPropertyName = "عنوان آیتم"
        Me.عنوانآیتمDataGridViewTextBoxColumn.HeaderText = "عنوان آیتم"
        Me.عنوانآیتمDataGridViewTextBoxColumn.Name = "عنوانآیتمDataGridViewTextBoxColumn"
        Me.عنوانآیتمDataGridViewTextBoxColumn.ReadOnly = True
        Me.عنوانآیتمDataGridViewTextBoxColumn.Width = 200
        '
        'تعدادDataGridViewTextBoxColumn
        '
        Me.تعدادDataGridViewTextBoxColumn.DataPropertyName = "تعداد"
        Me.تعدادDataGridViewTextBoxColumn.HeaderText = "تعداد"
        Me.تعدادDataGridViewTextBoxColumn.Name = "تعدادDataGridViewTextBoxColumn"
        Me.تعدادDataGridViewTextBoxColumn.ReadOnly = True
        Me.تعدادDataGridViewTextBoxColumn.Width = 50
        '
        'قیمتDataGridViewTextBoxColumn
        '
        Me.قیمتDataGridViewTextBoxColumn.DataPropertyName = "قیمت"
        Me.قیمتDataGridViewTextBoxColumn.HeaderText = "قیمت"
        Me.قیمتDataGridViewTextBoxColumn.Name = "قیمتDataGridViewTextBoxColumn"
        Me.قیمتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'واحدDataGridViewTextBoxColumn
        '
        Me.واحدDataGridViewTextBoxColumn.DataPropertyName = "واحد"
        Me.واحدDataGridViewTextBoxColumn.HeaderText = "واحد"
        Me.واحدDataGridViewTextBoxColumn.Name = "واحدDataGridViewTextBoxColumn"
        Me.واحدDataGridViewTextBoxColumn.ReadOnly = True
        Me.واحدDataGridViewTextBoxColumn.Width = 150
        '
        'ماهDataGridViewTextBoxColumn
        '
        Me.ماهDataGridViewTextBoxColumn.DataPropertyName = "ماه"
        Me.ماهDataGridViewTextBoxColumn.HeaderText = "ماه"
        Me.ماهDataGridViewTextBoxColumn.Name = "ماهDataGridViewTextBoxColumn"
        Me.ماهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'سالDataGridViewTextBoxColumn
        '
        Me.سالDataGridViewTextBoxColumn.DataPropertyName = "سال"
        Me.سالDataGridViewTextBoxColumn.HeaderText = "سال"
        Me.سالDataGridViewTextBoxColumn.Name = "سالDataGridViewTextBoxColumn"
        Me.سالDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "نوع"
        Me.DataGridViewTextBoxColumn6.HeaderText = "نوع"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'منبعDataGridViewTextBoxColumn
        '
        Me.منبعDataGridViewTextBoxColumn.DataPropertyName = "منبع"
        Me.منبعDataGridViewTextBoxColumn.HeaderText = "منبع"
        Me.منبعDataGridViewTextBoxColumn.Name = "منبعDataGridViewTextBoxColumn"
        Me.منبعDataGridViewTextBoxColumn.ReadOnly = True
        '
        'امورDataGridViewTextBoxColumn
        '
        Me.امورDataGridViewTextBoxColumn.DataPropertyName = "امور"
        Me.امورDataGridViewTextBoxColumn.HeaderText = "امور"
        Me.امورDataGridViewTextBoxColumn.Name = "امورDataGridViewTextBoxColumn"
        Me.امورDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmConNonMonthReportBindingSource
        '
        Me.PmConNonMonthReportBindingSource.DataMember = "Pm_Con_Non_MonthReport"
        Me.PmConNonMonthReportBindingSource.DataSource = Me.Ds_Con
        '
        'PmConContractBindingSource
        '
        Me.PmConContractBindingSource.DataMember = "Pm_Con_Contract"
        Me.PmConContractBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_ContractTableAdapter
        '
        Me.Pm_Con_ContractTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_SourceTableAdapter
        '
        Me.Pm_Con_SourceTableAdapter.ClearBeforeFill = True
        '
        'Pm_MonthTableAdapter
        '
        Me.Pm_MonthTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_Non_MonthReportTableAdapter
        '
        Me.Pm_Con_Non_MonthReportTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(769, 587)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 229
        Me.Label1.Text = "جمع کل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_sum
        '
        Me.txt_sum.CheckExistValueInDb = False
        Me.txt_sum.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_sum.CurrencyUnit = "ریال"
        Me.txt_sum.DefaultValue = ""
        Me.txt_sum.Enabled = False
        Me.txt_sum.FillWithMaxInDb = False
        Me.txt_sum.IsRequired = True
        Me.txt_sum.Location = New System.Drawing.Point(587, 585)
        Me.txt_sum.MaxDecimalLength = 2
        Me.txt_sum.Name = "txt_sum"
        Me.txt_sum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_sum.Size = New System.Drawing.Size(176, 26)
        Me.txt_sum.SpellControl = Nothing
        Me.txt_sum.TabIndex = 228
        Me.txt_sum.Tag = "Year"
        Me.txt_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_sum.Title = Nothing
        Me.txt_sum.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_sum.UseForData = True
        Me.txt_sum.ValidateCheckExistOnEdit = False
        Me.txt_sum.Value = 0
        '
        'Frm_Con_Non_MonthReportVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1014, 755)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_Non_MonthReportVw"
        Me.Text = "مشاهده صورت وضعیت های ارسال نشده"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.gbx_DataGridView.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Month, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Omoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Source, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Vahed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_Contract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConNonMonthReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents PmConMonthReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlConContractDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents دورهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmConsourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents گروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmPostTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmVahedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخارسالDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مبلغDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریختائیدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مبلغتائیدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخERPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهپیگیریDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهوضعیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهسندDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsCancleDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SrlSubmitUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubmitDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Update As System.Windows.Forms.PictureBox
    Friend WithEvents DGV_Month As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Omoor As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Source As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_Vahed As System.Windows.Forms.DataGridView
    Public WithEvents txt_year As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_allPOrM As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pm As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Mazad As System.Windows.Forms.RadioButton
    Friend WithEvents chk_Source As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Month As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Omoor As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Vahed As System.Windows.Forms.CheckBox
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ضریبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmConSourceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_SourceTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmPostTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTypeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_MonthTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_MonthTableAdapter
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmConNonMonthReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_Non_MonthReportTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_Non_MonthReportTableAdapter
    Friend WithEvents عنوانآیتمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعدادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قیمتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ماهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سالDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents منبعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents امورDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Contract As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخشروعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخخاتمهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmConContractBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents chk_allContract As System.Windows.Forms.CheckBox
    Public WithEvents txt_sum As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
