<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EibFormVw
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
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.chk_AllPost = New System.Windows.Forms.CheckBox
        Me.Chk_AllVahed = New System.Windows.Forms.CheckBox
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PMPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PM_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.chk_AllDate = New System.Windows.Forms.CheckBox
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.فرمنقصDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمنقصDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخفرمنقصDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرماصلیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخفرماصلیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامپستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخارجاعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامواحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.فرمنقصDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmEibFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_EibFormTableAdapter = New Nama_PM.Ds_PmTableAdapters.pm_EibFormTableAdapter
        Me.SrlDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.فرمنقصDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمنقصDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرماصلیDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخفرماصلیDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخفرمنقصDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامپستDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخارجاعDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامواحدDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخدریافتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخرفععیبDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شرحکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ثبتکنندهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEibFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(14, 472)
        Me.GroupBox1.Size = New System.Drawing.Size(956, 53)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(16, 16)
        Me.btn_Cancel.Size = New System.Drawing.Size(99, 29)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(630, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(101, 29)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(738, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(101, 29)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(845, 17)
        Me.btn_New.Size = New System.Drawing.Size(101, 29)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.txt_ToDate)
        Me.gbx_DataGridView.Controls.Add(Me.txt_FromDate)
        Me.gbx_DataGridView.Controls.Add(Me.Label2)
        Me.gbx_DataGridView.Controls.Add(Me.Label1)
        Me.gbx_DataGridView.Controls.Add(Me.cmb_Vahed)
        Me.gbx_DataGridView.Controls.Add(Me.cmb_Post)
        Me.gbx_DataGridView.Controls.Add(Me.Chk_AllVahed)
        Me.gbx_DataGridView.Controls.Add(Me.chk_AllDate)
        Me.gbx_DataGridView.Controls.Add(Me.chk_AllPost)
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Location = New System.Drawing.Point(14, 40)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(956, 429)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn2, Me.فرمنقصDataGridViewTextBoxColumn2, Me.شمارهفرمنقصDataGridViewTextBoxColumn2, Me.شمارهفرماصلیDataGridViewTextBoxColumn1, Me.تاریخفرماصلیDataGridViewTextBoxColumn1, Me.تاریخفرمنقصDataGridViewTextBoxColumn1, Me.نامپستDataGridViewTextBoxColumn1, Me.تاریخارجاعDataGridViewTextBoxColumn1, Me.نامواحدDataGridViewTextBoxColumn1, Me.نامگروهDataGridViewTextBoxColumn1, Me.تاریخدریافتDataGridViewTextBoxColumn, Me.شمارهفرمکارDataGridViewTextBoxColumn, Me.تاریخرفععیبDataGridViewTextBoxColumn, Me.شرحکارDataGridViewTextBoxColumn, Me.ثبتکنندهDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmEibFormBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(950, 318)
        Me.DataGridView1.TabIndex = 2
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_AllPost
        '
        Me.chk_AllPost.AutoSize = True
        Me.chk_AllPost.Location = New System.Drawing.Point(845, 20)
        Me.chk_AllPost.Name = "chk_AllPost"
        Me.chk_AllPost.Size = New System.Drawing.Size(95, 22)
        Me.chk_AllPost.TabIndex = 3
        Me.chk_AllPost.Text = "تمام پستها"
        Me.chk_AllPost.UseVisualStyleBackColor = True
        '
        'Chk_AllVahed
        '
        Me.Chk_AllVahed.AutoSize = True
        Me.Chk_AllVahed.Location = New System.Drawing.Point(840, 60)
        Me.Chk_AllVahed.Name = "Chk_AllVahed"
        Me.Chk_AllVahed.Size = New System.Drawing.Size(100, 22)
        Me.Chk_AllVahed.TabIndex = 3
        Me.Chk_AllVahed.Text = "تمام واحدها"
        Me.Chk_AllVahed.UseVisualStyleBackColor = True
        '
        'cmb_Post
        '
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PMPostBindingSource
        Me.cmb_Post.DisplayMember = "نام کامل"
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = True
        Me.cmb_Post.Location = New System.Drawing.Point(601, 20)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(225, 26)
        Me.cmb_Post.TabIndex = 4
        Me.cmb_Post.ValueMember = "Srl"
        '
        'PMPostBindingSource
        '
        Me.PMPostBindingSource.DataMember = "PM_Post"
        Me.PMPostBindingSource.DataSource = Me.Ds_Pm
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
        Me.cmb_Vahed.Location = New System.Drawing.Point(601, 56)
        Me.cmb_Vahed.Name = "cmb_Vahed"
        Me.cmb_Vahed.OpenOnFoucus = False
        Me.cmb_Vahed.Size = New System.Drawing.Size(225, 26)
        Me.cmb_Vahed.TabIndex = 4
        Me.cmb_Vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'PM_PostTableAdapter
        '
        Me.PM_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(392, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "فرم های ثبت شده از تاریخ"
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(255, 22)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(135, 25)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 6
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "تا"
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(96, 22)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(135, 25)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 6
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'chk_AllDate
        '
        Me.chk_AllDate.AutoSize = True
        Me.chk_AllDate.Location = New System.Drawing.Point(455, 58)
        Me.chk_AllDate.Name = "chk_AllDate"
        Me.chk_AllDate.Size = New System.Drawing.Size(105, 22)
        Me.chk_AllDate.TabIndex = 3
        Me.chk_AllDate.Text = "تمام تاریخ ها"
        Me.chk_AllDate.UseVisualStyleBackColor = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'فرمنقصDataGridViewTextBoxColumn
        '
        Me.فرمنقصDataGridViewTextBoxColumn.DataPropertyName = "فرم نقص"
        Me.فرمنقصDataGridViewTextBoxColumn.HeaderText = "فرم نقص"
        Me.فرمنقصDataGridViewTextBoxColumn.Name = "فرمنقصDataGridViewTextBoxColumn"
        '
        'شمارهفرمنقصDataGridViewTextBoxColumn
        '
        Me.شمارهفرمنقصDataGridViewTextBoxColumn.DataPropertyName = "شماره فرم نقص"
        Me.شمارهفرمنقصDataGridViewTextBoxColumn.HeaderText = "شماره فرم"
        Me.شمارهفرمنقصDataGridViewTextBoxColumn.Name = "شمارهفرمنقصDataGridViewTextBoxColumn"
        Me.شمارهفرمنقصDataGridViewTextBoxColumn.Width = 80
        '
        'تاریخفرمنقصDataGridViewTextBoxColumn
        '
        Me.تاریخفرمنقصDataGridViewTextBoxColumn.DataPropertyName = "تاریخ فرم نقص"
        Me.تاریخفرمنقصDataGridViewTextBoxColumn.HeaderText = "تاریخ فرم"
        Me.تاریخفرمنقصDataGridViewTextBoxColumn.Name = "تاریخفرمنقصDataGridViewTextBoxColumn"
        '
        'شمارهفرماصلیDataGridViewTextBoxColumn
        '
        Me.شمارهفرماصلیDataGridViewTextBoxColumn.DataPropertyName = "شماره فرم اصلی"
        Me.شمارهفرماصلیDataGridViewTextBoxColumn.HeaderText = "شماره فرم اصلی"
        Me.شمارهفرماصلیDataGridViewTextBoxColumn.Name = "شمارهفرماصلیDataGridViewTextBoxColumn"
        Me.شمارهفرماصلیDataGridViewTextBoxColumn.Width = 130
        '
        'تاریخفرماصلیDataGridViewTextBoxColumn
        '
        Me.تاریخفرماصلیDataGridViewTextBoxColumn.DataPropertyName = "تاریخ فرم اصلی"
        Me.تاریخفرماصلیDataGridViewTextBoxColumn.HeaderText = "تاریخ فرم اصلی"
        Me.تاریخفرماصلیDataGridViewTextBoxColumn.Name = "تاریخفرماصلیDataGridViewTextBoxColumn"
        Me.تاریخفرماصلیDataGridViewTextBoxColumn.Width = 120
        '
        'نامپستDataGridViewTextBoxColumn
        '
        Me.نامپستDataGridViewTextBoxColumn.DataPropertyName = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.HeaderText = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.Name = "نامپستDataGridViewTextBoxColumn"
        Me.نامپستDataGridViewTextBoxColumn.Width = 150
        '
        'تاریخارجاعDataGridViewTextBoxColumn
        '
        Me.تاریخارجاعDataGridViewTextBoxColumn.DataPropertyName = "تاریخ ارجاع"
        Me.تاریخارجاعDataGridViewTextBoxColumn.HeaderText = "تاریخ ارجاع"
        Me.تاریخارجاعDataGridViewTextBoxColumn.Name = "تاریخارجاعDataGridViewTextBoxColumn"
        '
        'نامواحدDataGridViewTextBoxColumn
        '
        Me.نامواحدDataGridViewTextBoxColumn.DataPropertyName = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.HeaderText = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.Name = "نامواحدDataGridViewTextBoxColumn"
        Me.نامواحدDataGridViewTextBoxColumn.Width = 150
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        Me.نامگروهDataGridViewTextBoxColumn.Width = 150
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.Visible = False
        '
        'فرمنقصDataGridViewTextBoxColumn1
        '
        Me.فرمنقصDataGridViewTextBoxColumn1.DataPropertyName = "فرم نقص"
        Me.فرمنقصDataGridViewTextBoxColumn1.HeaderText = "فرم نقص"
        Me.فرمنقصDataGridViewTextBoxColumn1.Name = "فرمنقصDataGridViewTextBoxColumn1"
        Me.فرمنقصDataGridViewTextBoxColumn1.Visible = False
        '
        'PmEibFormBindingSource
        '
        Me.PmEibFormBindingSource.DataMember = "pm_EibForm"
        Me.PmEibFormBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_EibFormTableAdapter
        '
        Me.Pm_EibFormTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn2
        '
        Me.SrlDataGridViewTextBoxColumn2.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.Name = "SrlDataGridViewTextBoxColumn2"
        Me.SrlDataGridViewTextBoxColumn2.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn2.Visible = False
        '
        'فرمنقصDataGridViewTextBoxColumn2
        '
        Me.فرمنقصDataGridViewTextBoxColumn2.DataPropertyName = "فرم نقص"
        Me.فرمنقصDataGridViewTextBoxColumn2.HeaderText = "فرم نقص"
        Me.فرمنقصDataGridViewTextBoxColumn2.Name = "فرمنقصDataGridViewTextBoxColumn2"
        Me.فرمنقصDataGridViewTextBoxColumn2.ReadOnly = True
        Me.فرمنقصDataGridViewTextBoxColumn2.Visible = False
        '
        'شمارهفرمنقصDataGridViewTextBoxColumn2
        '
        Me.شمارهفرمنقصDataGridViewTextBoxColumn2.DataPropertyName = "شماره فرم نقص"
        Me.شمارهفرمنقصDataGridViewTextBoxColumn2.HeaderText = "شماره فرم نقص"
        Me.شمارهفرمنقصDataGridViewTextBoxColumn2.Name = "شمارهفرمنقصDataGridViewTextBoxColumn2"
        Me.شمارهفرمنقصDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'شمارهفرماصلیDataGridViewTextBoxColumn1
        '
        Me.شمارهفرماصلیDataGridViewTextBoxColumn1.DataPropertyName = "شماره فرم اصلی"
        Me.شمارهفرماصلیDataGridViewTextBoxColumn1.HeaderText = "شماره فرم اصلی"
        Me.شمارهفرماصلیDataGridViewTextBoxColumn1.Name = "شمارهفرماصلیDataGridViewTextBoxColumn1"
        Me.شمارهفرماصلیDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'تاریخفرماصلیDataGridViewTextBoxColumn1
        '
        Me.تاریخفرماصلیDataGridViewTextBoxColumn1.DataPropertyName = "تاریخ فرم اصلی"
        Me.تاریخفرماصلیDataGridViewTextBoxColumn1.HeaderText = "تاریخ فرم اصلی"
        Me.تاریخفرماصلیDataGridViewTextBoxColumn1.Name = "تاریخفرماصلیDataGridViewTextBoxColumn1"
        Me.تاریخفرماصلیDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'تاریخفرمنقصDataGridViewTextBoxColumn1
        '
        Me.تاریخفرمنقصDataGridViewTextBoxColumn1.DataPropertyName = "تاریخ فرم نقص"
        Me.تاریخفرمنقصDataGridViewTextBoxColumn1.HeaderText = "تاریخ فرم نقص"
        Me.تاریخفرمنقصDataGridViewTextBoxColumn1.Name = "تاریخفرمنقصDataGridViewTextBoxColumn1"
        Me.تاریخفرمنقصDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامپستDataGridViewTextBoxColumn1
        '
        Me.نامپستDataGridViewTextBoxColumn1.DataPropertyName = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn1.HeaderText = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn1.Name = "نامپستDataGridViewTextBoxColumn1"
        Me.نامپستDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'تاریخارجاعDataGridViewTextBoxColumn1
        '
        Me.تاریخارجاعDataGridViewTextBoxColumn1.DataPropertyName = "تاریخ ارجاع"
        Me.تاریخارجاعDataGridViewTextBoxColumn1.HeaderText = "تاریخ ارجاع"
        Me.تاریخارجاعDataGridViewTextBoxColumn1.Name = "تاریخارجاعDataGridViewTextBoxColumn1"
        Me.تاریخارجاعDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامواحدDataGridViewTextBoxColumn1
        '
        Me.نامواحدDataGridViewTextBoxColumn1.DataPropertyName = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn1.HeaderText = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn1.Name = "نامواحدDataGridViewTextBoxColumn1"
        Me.نامواحدDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامگروهDataGridViewTextBoxColumn1
        '
        Me.نامگروهDataGridViewTextBoxColumn1.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn1.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn1.Name = "نامگروهDataGridViewTextBoxColumn1"
        Me.نامگروهDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'تاریخدریافتDataGridViewTextBoxColumn
        '
        Me.تاریخدریافتDataGridViewTextBoxColumn.DataPropertyName = "تاریخ دریافت"
        Me.تاریخدریافتDataGridViewTextBoxColumn.HeaderText = "تاریخ دریافت"
        Me.تاریخدریافتDataGridViewTextBoxColumn.Name = "تاریخدریافتDataGridViewTextBoxColumn"
        Me.تاریخدریافتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'شمارهفرمکارDataGridViewTextBoxColumn
        '
        Me.شمارهفرمکارDataGridViewTextBoxColumn.DataPropertyName = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.HeaderText = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.Name = "شمارهفرمکارDataGridViewTextBoxColumn"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخرفععیبDataGridViewTextBoxColumn
        '
        Me.تاریخرفععیبDataGridViewTextBoxColumn.DataPropertyName = "تاریخ رفع عیب"
        Me.تاریخرفععیبDataGridViewTextBoxColumn.HeaderText = "تاریخ رفع عیب"
        Me.تاریخرفععیبDataGridViewTextBoxColumn.Name = "تاریخرفععیبDataGridViewTextBoxColumn"
        Me.تاریخرفععیبDataGridViewTextBoxColumn.ReadOnly = True
        '
        'شرحکارDataGridViewTextBoxColumn
        '
        Me.شرحکارDataGridViewTextBoxColumn.DataPropertyName = "شرح کار"
        Me.شرحکارDataGridViewTextBoxColumn.HeaderText = "شرح کار"
        Me.شرحکارDataGridViewTextBoxColumn.Name = "شرحکارDataGridViewTextBoxColumn"
        Me.شرحکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ثبتکنندهDataGridViewTextBoxColumn
        '
        Me.ثبتکنندهDataGridViewTextBoxColumn.DataPropertyName = "ثبت کننده"
        Me.ثبتکنندهDataGridViewTextBoxColumn.HeaderText = "ثبت کننده"
        Me.ثبتکنندهDataGridViewTextBoxColumn.Name = "ثبتکنندهDataGridViewTextBoxColumn"
        Me.ثبتکنندهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_EibFormVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 565)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_EibFormVw"
        Me.Text = "نمایش فرم نقص"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.gbx_DataGridView.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEibFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents cmb_Vahed As VB_Component.ComboBox
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents Chk_AllVahed As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllPost As System.Windows.Forms.CheckBox
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PM_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.PM_PostTableAdapter
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_AllDate As System.Windows.Forms.CheckBox
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فرمنقصDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمنقصDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخفرمنقصDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرماصلیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخفرماصلیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخارجاعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمنقصDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فرمنقصDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمنقصDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرماصلیDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخفرماصلیDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخفرمنقصDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپستDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخارجاعDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخدریافتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخرفععیبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شرحکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ثبتکنندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmEibFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فرمنقصDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pm_EibFormTableAdapter As Nama_PM.Ds_PmTableAdapters.pm_EibFormTableAdapter
End Class
