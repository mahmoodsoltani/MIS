<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_Item
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
        Me.ولتاژ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.توضیحاتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.واحدکاریDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.واحدشمارشDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmConItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.cmb_TahvilePerson = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pm_Con_ItemTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ItemTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New VB_Component.ComboBox
        Me.PmConUnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New CS_Component.TextBox
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_Con_UnitTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_UnitTableAdapter
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox3 = New CS_Component.TextBox
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Rb_All = New System.Windows.Forms.RadioButton
        Me.Rb_PM = New System.Windows.Forms.RadioButton
        Me.Rb_Mazad = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.PmconAllItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_con_AllItemTableAdapter = New Nama_PM.Ds_ConTableAdapters.pm_con_AllItemTableAdapter
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_Type = New VB_Component.ComboBox
        Me.PmConStatusStatementTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_StatusStatementTypeTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementTypeTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConUnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmconAllItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConStatusStatementTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(347, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(594, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(470, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.Rb_Mazad)
        Me.gbx_GridViewList.Controls.Add(Me.Rb_PM)
        Me.gbx_GridViewList.Controls.Add(Me.Rb_All)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(717, 332)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.RadioButton2)
        Me.gbx_Controls.Controls.Add(Me.TextBox3)
        Me.gbx_Controls.Controls.Add(Me.RadioButton1)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.TextBox2)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.cmb_Type)
        Me.gbx_Controls.Controls.Add(Me.ComboBox1)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.cmb_TahvilePerson)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 444)
        Me.gbx_Controls.Size = New System.Drawing.Size(717, 122)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 378)
        Me.gbx_Btn.Size = New System.Drawing.Size(717, 60)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.کدDataGridViewTextBoxColumn, Me.عنوانDataGridViewTextBoxColumn, Me.ولتاژ, Me.توضیحاتDataGridViewTextBoxColumn, Me.واحدکاریDataGridViewTextBoxColumn, Me.واحدشمارشDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmConItemBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 51)
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
        Me.DataGridView1.Size = New System.Drawing.Size(711, 278)
        Me.DataGridView1.TabIndex = 5
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
        Me.کدDataGridViewTextBoxColumn.ReadOnly = True
        '
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.FillWeight = 250.0!
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        Me.عنوانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ولتاژ
        '
        Me.ولتاژ.DataPropertyName = "ولتاژ"
        Me.ولتاژ.HeaderText = "ولتاژ"
        Me.ولتاژ.Name = "ولتاژ"
        Me.ولتاژ.ReadOnly = True
        '
        'توضیحاتDataGridViewTextBoxColumn
        '
        Me.توضیحاتDataGridViewTextBoxColumn.DataPropertyName = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.Name = "توضیحاتDataGridViewTextBoxColumn"
        Me.توضیحاتDataGridViewTextBoxColumn.ReadOnly = True
        Me.توضیحاتDataGridViewTextBoxColumn.Visible = False
        '
        'واحدکاریDataGridViewTextBoxColumn
        '
        Me.واحدکاریDataGridViewTextBoxColumn.DataPropertyName = "واحد کاری"
        Me.واحدکاریDataGridViewTextBoxColumn.HeaderText = "واحد کاری"
        Me.واحدکاریDataGridViewTextBoxColumn.Name = "واحدکاریDataGridViewTextBoxColumn"
        Me.واحدکاریDataGridViewTextBoxColumn.ReadOnly = True
        '
        'واحدشمارشDataGridViewTextBoxColumn
        '
        Me.واحدشمارشDataGridViewTextBoxColumn.DataPropertyName = "واحد شمارش"
        Me.واحدشمارشDataGridViewTextBoxColumn.HeaderText = "واحد شمارش"
        Me.واحدشمارشDataGridViewTextBoxColumn.Name = "واحدشمارشDataGridViewTextBoxColumn"
        Me.واحدشمارشDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmConItemBindingSource
        '
        Me.PmConItemBindingSource.DataMember = "Pm_Con_Item"
        Me.PmConItemBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_TahvilePerson
        '
        Me.cmb_TahvilePerson.AutoComplete = True
        Me.cmb_TahvilePerson.DataSource = Me.PmVahedBindingSource
        Me.cmb_TahvilePerson.DisplayMember = "نام واحد"
        Me.cmb_TahvilePerson.EnterStop = True
        Me.cmb_TahvilePerson.FormattingEnabled = True
        Me.cmb_TahvilePerson.IsRequired = False
        Me.cmb_TahvilePerson.LimitedToList = True
        Me.cmb_TahvilePerson.Location = New System.Drawing.Point(470, 63)
        Me.cmb_TahvilePerson.Name = "cmb_TahvilePerson"
        Me.cmb_TahvilePerson.OpenOnFoucus = False
        Me.cmb_TahvilePerson.Size = New System.Drawing.Size(167, 26)
        Me.cmb_TahvilePerson.TabIndex = 2
        Me.cmb_TahvilePerson.Tag = "srl_vahed"
        Me.cmb_TahvilePerson.ValueMember = "Srl"
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
        Me.Label9.Location = New System.Drawing.Point(638, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "واحد کاری"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = True
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = True
        Me.TextBox1.Location = New System.Drawing.Point(542, 32)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(95, 26)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Tag = "code"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(643, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "کد"
        '
        'Pm_Con_ItemTableAdapter
        '
        Me.Pm_Con_ItemTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "واحد اندازه گیری"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoComplete = True
        Me.ComboBox1.DataSource = Me.PmConUnitBindingSource
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.EnterStop = True
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IsRequired = False
        Me.ComboBox1.LimitedToList = True
        Me.ComboBox1.Location = New System.Drawing.Point(246, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.OpenOnFoucus = False
        Me.ComboBox1.Size = New System.Drawing.Size(99, 26)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Tag = "srl_unit"
        Me.ComboBox1.ValueMember = "srl"
        '
        'PmConUnitBindingSource
        '
        Me.PmConUnitBindingSource.DataMember = "Pm_Con_Unit"
        Me.PmConUnitBindingSource.DataSource = Me.Ds_Con
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(493, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "عنوان"
        '
        'TextBox2
        '
        Me.TextBox2.CheckExistValueInDb = True
        Me.TextBox2.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox2.CurrencyUnit = "ریال"
        Me.TextBox2.DefaultValue = ""
        Me.TextBox2.FillWithMaxInDb = False
        Me.TextBox2.IsRequired = True
        Me.TextBox2.Location = New System.Drawing.Point(137, 32)
        Me.TextBox2.MaxDecimalLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(350, 26)
        Me.TextBox2.SpellControl = Nothing
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Tag = "title"
        Me.TextBox2.Title = Nothing
        Me.TextBox2.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox2.UseForData = True
        Me.TextBox2.ValidateCheckExistOnEdit = False
        Me.TextBox2.Value = ""
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_UnitTableAdapter
        '
        Me.Pm_Con_UnitTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ولتاژ"
        '
        'TextBox3
        '
        Me.TextBox3.CheckExistValueInDb = True
        Me.TextBox3.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox3.CurrencyUnit = "ریال"
        Me.TextBox3.DefaultValue = ""
        Me.TextBox3.FillWithMaxInDb = False
        Me.TextBox3.IsRequired = True
        Me.TextBox3.Location = New System.Drawing.Point(25, 33)
        Me.TextBox3.MaxDecimalLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(64, 26)
        Me.TextBox3.SpellControl = Nothing
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Tag = "voltage"
        Me.TextBox3.Title = Nothing
        Me.TextBox3.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox3.UseForData = True
        Me.TextBox3.ValidateCheckExistOnEdit = False
        Me.TextBox3.Value = ""
        '
        'Rb_All
        '
        Me.Rb_All.AutoSize = True
        Me.Rb_All.Checked = True
        Me.Rb_All.Location = New System.Drawing.Point(646, 20)
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
        Me.Rb_PM.Location = New System.Drawing.Point(586, 20)
        Me.Rb_PM.Name = "Rb_PM"
        Me.Rb_PM.Size = New System.Drawing.Size(46, 22)
        Me.Rb_PM.TabIndex = 6
        Me.Rb_PM.Text = "PM"
        Me.Rb_PM.UseVisualStyleBackColor = True
        '
        'Rb_Mazad
        '
        Me.Rb_Mazad.AutoSize = True
        Me.Rb_Mazad.Location = New System.Drawing.Point(505, 20)
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
        'PmconAllItemBindingSource
        '
        Me.PmconAllItemBindingSource.DataMember = "pm_con_AllItem"
        Me.PmconAllItemBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_con_AllItemTableAdapter
        '
        Me.Pm_con_AllItemTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "نوع"
        '
        'cmb_Type
        '
        Me.cmb_Type.AutoComplete = True
        Me.cmb_Type.DataSource = Me.PmConStatusStatementTypeBindingSource
        Me.cmb_Type.DisplayMember = "name"
        Me.cmb_Type.EnterStop = True
        Me.cmb_Type.FormattingEnabled = True
        Me.cmb_Type.IsRequired = False
        Me.cmb_Type.LimitedToList = True
        Me.cmb_Type.Location = New System.Drawing.Point(25, 65)
        Me.cmb_Type.Name = "cmb_Type"
        Me.cmb_Type.OpenOnFoucus = False
        Me.cmb_Type.Size = New System.Drawing.Size(166, 26)
        Me.cmb_Type.TabIndex = 3
        Me.cmb_Type.Tag = "sstype"
        Me.cmb_Type.ValueMember = "srl"
        '
        'PmConStatusStatementTypeBindingSource
        '
        Me.PmConStatusStatementTypeBindingSource.DataMember = "Pm_Con_StatusStatementType"
        Me.PmConStatusStatementTypeBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_StatusStatementTypeTableAdapter
        '
        Me.Pm_Con_StatusStatementTypeTableAdapter.ClearBeforeFill = True
        '
        'Frm_Con_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(745, 605)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_Item"
        Me.TableName = "pm_Con_Item"
        Me.Text = "آیتم های قرارداد"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConUnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmconAllItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConStatusStatementTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_TahvilePerson As VB_Component.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PmConItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents ComboBox1 As VB_Component.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pm_Con_ItemTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ItemTableAdapter
    Friend WithEvents TextBox2 As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmConUnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_UnitTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_UnitTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ولتاژ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدکاریDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدشمارشDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Rb_Mazad As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_PM As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents PmconAllItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_con_AllItemTableAdapter As Nama_PM.Ds_ConTableAdapters.pm_con_AllItemTableAdapter
    Friend WithEvents cmb_Type As VB_Component.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PmConStatusStatementTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_StatusStatementTypeTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementTypeTableAdapter
End Class
