<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Line
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
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.کدDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ولتاژDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سالاحداثDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مدارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.طولDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.دکلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.برجآویزیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.برجکششیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعهادیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تعدادهادیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.گاردDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعگاردDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.دارایفیبرDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.نوعمقرهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مقرهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.برجلتیسDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.برجتلسکوپیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ساختاردکلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.گروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.امورDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.txt_Name = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Code = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_SaleBahrebardari = New CS_Component.TextBox
        Me.txt_Rele = New CS_Component.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmb_Group = New VB_Component.ComboBox
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامپستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تجهیزDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تیپDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سطحولتاژDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سالبهرهبرداریDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ترانسفورماتورDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اتوماسیونDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.رلهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ظرفیتMVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ظرفیتتعدادDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامکاملDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmPostTipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmPostModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsMission = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_Posttype = New VB_Component.ComboBox
        Me.PmPostTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New VB_Component.ComboBox
        Me.PmLineVoltageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Ds_Line_ = New Nama_PM._Ds_Line_
        Me.Pm_Line_VoltageTableAdapter = New Nama_PM._Ds_Line_TableAdapters.Pm_Line_VoltageTableAdapter
        Me.TextBox1 = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox2 = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComboBox2 = New VB_Component.ComboBox
        Me.PmLineHadiTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Line_HadiTypeTableAdapter = New Nama_PM._Ds_Line_TableAdapters.Pm_Line_HadiTypeTableAdapter
        Me.TextBox3 = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox4 = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ComboBox3 = New VB_Component.ComboBox
        Me.PmLineGardTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.ComboBox4 = New VB_Component.ComboBox
        Me.PmLineMaghareTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Line_MaghareTypeTableAdapter = New Nama_PM._Ds_Line_TableAdapters.Pm_Line_MaghareTypeTableAdapter
        Me.Pm_Line_GardTypeTableAdapter = New Nama_PM._Ds_Line_TableAdapters.Pm_Line_GardTypeTableAdapter
        Me.TextBox5 = New CS_Component.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBox6 = New CS_Component.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.ComboBox5 = New VB_Component.ComboBox
        Me.PmLineDakalStructureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Line_DakalStructureTableAdapter = New Nama_PM._Ds_Line_TableAdapters.Pm_Line_DakalStructureTableAdapter
        Me.TextBox7 = New CS_Component.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TextBox8 = New CS_Component.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBox9 = New CS_Component.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.Convert = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Pm_PostTypeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
        Me.TextBox10 = New CS_Component.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmb_fibrtype = New VB_Component.ComboBox
        Me.PmLineFibrTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Line_FibrTypeTableAdapter = New Nama_PM._Ds_Line_TableAdapters.Pm_Line_FibrTypeTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineVoltageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Ds_Line_, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineHadiTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineGardTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineMaghareTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineDakalStructureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineFibrTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(774, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        Me.btn_Delete.TabIndex = 1
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(1021, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(898, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.TabIndex = 0
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(1145, 285)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.Convert)
        Me.gbx_Controls.Controls.Add(Me.CheckBox1)
        Me.gbx_Controls.Controls.Add(Me.cmb_Posttype)
        Me.gbx_Controls.Controls.Add(Me.ComboBox4)
        Me.gbx_Controls.Controls.Add(Me.ComboBox5)
        Me.gbx_Controls.Controls.Add(Me.cmb_fibrtype)
        Me.gbx_Controls.Controls.Add(Me.ComboBox3)
        Me.gbx_Controls.Controls.Add(Me.ComboBox2)
        Me.gbx_Controls.Controls.Add(Me.ComboBox1)
        Me.gbx_Controls.Controls.Add(Me.cmb_Group)
        Me.gbx_Controls.Controls.Add(Me.Label13)
        Me.gbx_Controls.Controls.Add(Me.Label7)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label11)
        Me.gbx_Controls.Controls.Add(Me.Label8)
        Me.gbx_Controls.Controls.Add(Me.Label17)
        Me.gbx_Controls.Controls.Add(Me.Label22)
        Me.gbx_Controls.Controls.Add(Me.Label14)
        Me.gbx_Controls.Controls.Add(Me.Label12)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.Label20)
        Me.gbx_Controls.Controls.Add(Me.Label19)
        Me.gbx_Controls.Controls.Add(Me.Label18)
        Me.gbx_Controls.Controls.Add(Me.Label16)
        Me.gbx_Controls.Controls.Add(Me.Label21)
        Me.gbx_Controls.Controls.Add(Me.Label15)
        Me.gbx_Controls.Controls.Add(Me.Label10)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.TextBox9)
        Me.gbx_Controls.Controls.Add(Me.TextBox4)
        Me.gbx_Controls.Controls.Add(Me.TextBox8)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.TextBox7)
        Me.gbx_Controls.Controls.Add(Me.TextBox2)
        Me.gbx_Controls.Controls.Add(Me.TextBox6)
        Me.gbx_Controls.Controls.Add(Me.TextBox10)
        Me.gbx_Controls.Controls.Add(Me.txt_Code)
        Me.gbx_Controls.Controls.Add(Me.TextBox5)
        Me.gbx_Controls.Controls.Add(Me.txt_SaleBahrebardari)
        Me.gbx_Controls.Controls.Add(Me.TextBox3)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.txt_Rele)
        Me.gbx_Controls.Controls.Add(Me.txt_Name)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 386)
        Me.gbx_Controls.Size = New System.Drawing.Size(1145, 163)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 331)
        Me.gbx_Btn.Size = New System.Drawing.Size(1145, 57)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn1, Me.Column1, Me.کدDataGridViewTextBoxColumn1, Me.نامDataGridViewTextBoxColumn, Me.ولتاژDataGridViewTextBoxColumn, Me.سالاحداثDataGridViewTextBoxColumn, Me.مدارDataGridViewTextBoxColumn, Me.طولDataGridViewTextBoxColumn, Me.دکلDataGridViewTextBoxColumn, Me.برجآویزیDataGridViewTextBoxColumn, Me.برجکششیDataGridViewTextBoxColumn, Me.نوعهادیDataGridViewTextBoxColumn, Me.تعدادهادیDataGridViewTextBoxColumn, Me.گاردDataGridViewTextBoxColumn, Me.نوعگاردDataGridViewTextBoxColumn, Me.دارایفیبرDataGridViewCheckBoxColumn, Me.نوعمقرهDataGridViewTextBoxColumn, Me.مقرهDataGridViewTextBoxColumn, Me.برجلتیسDataGridViewTextBoxColumn, Me.برجتلسکوپیDataGridViewTextBoxColumn, Me.ساختاردکلDataGridViewTextBoxColumn, Me.گروهDataGridViewTextBoxColumn, Me.امورDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmLineBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1139, 261)
        Me.DataGridView1.TabIndex = 1
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn1.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "..."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 25
        '
        'کدDataGridViewTextBoxColumn1
        '
        Me.کدDataGridViewTextBoxColumn1.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn1.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn1.Name = "کدDataGridViewTextBoxColumn1"
        Me.کدDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامDataGridViewTextBoxColumn
        '
        Me.نامDataGridViewTextBoxColumn.DataPropertyName = "نام"
        Me.نامDataGridViewTextBoxColumn.HeaderText = "نام"
        Me.نامDataGridViewTextBoxColumn.Name = "نامDataGridViewTextBoxColumn"
        Me.نامDataGridViewTextBoxColumn.ReadOnly = True
        Me.نامDataGridViewTextBoxColumn.Width = 300
        '
        'ولتاژDataGridViewTextBoxColumn
        '
        Me.ولتاژDataGridViewTextBoxColumn.DataPropertyName = "ولتاژ"
        Me.ولتاژDataGridViewTextBoxColumn.HeaderText = "ولتاژ"
        Me.ولتاژDataGridViewTextBoxColumn.Name = "ولتاژDataGridViewTextBoxColumn"
        Me.ولتاژDataGridViewTextBoxColumn.ReadOnly = True
        '
        'سالاحداثDataGridViewTextBoxColumn
        '
        Me.سالاحداثDataGridViewTextBoxColumn.DataPropertyName = "سال احداث"
        Me.سالاحداثDataGridViewTextBoxColumn.HeaderText = "سال احداث"
        Me.سالاحداثDataGridViewTextBoxColumn.Name = "سالاحداثDataGridViewTextBoxColumn"
        Me.سالاحداثDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مدارDataGridViewTextBoxColumn
        '
        Me.مدارDataGridViewTextBoxColumn.DataPropertyName = "مدار"
        Me.مدارDataGridViewTextBoxColumn.HeaderText = "مدار"
        Me.مدارDataGridViewTextBoxColumn.Name = "مدارDataGridViewTextBoxColumn"
        Me.مدارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'طولDataGridViewTextBoxColumn
        '
        Me.طولDataGridViewTextBoxColumn.DataPropertyName = "طول"
        Me.طولDataGridViewTextBoxColumn.HeaderText = "طول"
        Me.طولDataGridViewTextBoxColumn.Name = "طولDataGridViewTextBoxColumn"
        Me.طولDataGridViewTextBoxColumn.ReadOnly = True
        '
        'دکلDataGridViewTextBoxColumn
        '
        Me.دکلDataGridViewTextBoxColumn.DataPropertyName = "دکل"
        Me.دکلDataGridViewTextBoxColumn.HeaderText = "دکل"
        Me.دکلDataGridViewTextBoxColumn.Name = "دکلDataGridViewTextBoxColumn"
        Me.دکلDataGridViewTextBoxColumn.ReadOnly = True
        '
        'برجآویزیDataGridViewTextBoxColumn
        '
        Me.برجآویزیDataGridViewTextBoxColumn.DataPropertyName = "برج آویزی"
        Me.برجآویزیDataGridViewTextBoxColumn.HeaderText = "برج آویزی"
        Me.برجآویزیDataGridViewTextBoxColumn.Name = "برجآویزیDataGridViewTextBoxColumn"
        Me.برجآویزیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'برجکششیDataGridViewTextBoxColumn
        '
        Me.برجکششیDataGridViewTextBoxColumn.DataPropertyName = "برج کششی"
        Me.برجکششیDataGridViewTextBoxColumn.HeaderText = "برج کششی"
        Me.برجکششیDataGridViewTextBoxColumn.Name = "برجکششیDataGridViewTextBoxColumn"
        Me.برجکششیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نوعهادیDataGridViewTextBoxColumn
        '
        Me.نوعهادیDataGridViewTextBoxColumn.DataPropertyName = "نوع هادی"
        Me.نوعهادیDataGridViewTextBoxColumn.HeaderText = "نوع هادی"
        Me.نوعهادیDataGridViewTextBoxColumn.Name = "نوعهادیDataGridViewTextBoxColumn"
        Me.نوعهادیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تعدادهادیDataGridViewTextBoxColumn
        '
        Me.تعدادهادیDataGridViewTextBoxColumn.DataPropertyName = "تعداد هادی"
        Me.تعدادهادیDataGridViewTextBoxColumn.HeaderText = "تعداد هادی"
        Me.تعدادهادیDataGridViewTextBoxColumn.Name = "تعدادهادیDataGridViewTextBoxColumn"
        Me.تعدادهادیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'گاردDataGridViewTextBoxColumn
        '
        Me.گاردDataGridViewTextBoxColumn.DataPropertyName = "گارد"
        Me.گاردDataGridViewTextBoxColumn.HeaderText = "گارد"
        Me.گاردDataGridViewTextBoxColumn.Name = "گاردDataGridViewTextBoxColumn"
        Me.گاردDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نوعگاردDataGridViewTextBoxColumn
        '
        Me.نوعگاردDataGridViewTextBoxColumn.DataPropertyName = "نوع گارد"
        Me.نوعگاردDataGridViewTextBoxColumn.HeaderText = "نوع گارد"
        Me.نوعگاردDataGridViewTextBoxColumn.Name = "نوعگاردDataGridViewTextBoxColumn"
        Me.نوعگاردDataGridViewTextBoxColumn.ReadOnly = True
        '
        'دارایفیبرDataGridViewCheckBoxColumn
        '
        Me.دارایفیبرDataGridViewCheckBoxColumn.DataPropertyName = "دارای فیبر"
        Me.دارایفیبرDataGridViewCheckBoxColumn.HeaderText = "دارای فیبر"
        Me.دارایفیبرDataGridViewCheckBoxColumn.Name = "دارایفیبرDataGridViewCheckBoxColumn"
        Me.دارایفیبرDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'نوعمقرهDataGridViewTextBoxColumn
        '
        Me.نوعمقرهDataGridViewTextBoxColumn.DataPropertyName = "نوع مقره"
        Me.نوعمقرهDataGridViewTextBoxColumn.HeaderText = "نوع مقره"
        Me.نوعمقرهDataGridViewTextBoxColumn.Name = "نوعمقرهDataGridViewTextBoxColumn"
        Me.نوعمقرهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مقرهDataGridViewTextBoxColumn
        '
        Me.مقرهDataGridViewTextBoxColumn.DataPropertyName = "مقره"
        Me.مقرهDataGridViewTextBoxColumn.HeaderText = "مقره"
        Me.مقرهDataGridViewTextBoxColumn.Name = "مقرهDataGridViewTextBoxColumn"
        Me.مقرهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'برجلتیسDataGridViewTextBoxColumn
        '
        Me.برجلتیسDataGridViewTextBoxColumn.DataPropertyName = "برج لتیس"
        Me.برجلتیسDataGridViewTextBoxColumn.HeaderText = "برج لتیس"
        Me.برجلتیسDataGridViewTextBoxColumn.Name = "برجلتیسDataGridViewTextBoxColumn"
        Me.برجلتیسDataGridViewTextBoxColumn.ReadOnly = True
        '
        'برجتلسکوپیDataGridViewTextBoxColumn
        '
        Me.برجتلسکوپیDataGridViewTextBoxColumn.DataPropertyName = "برج تلسکوپی"
        Me.برجتلسکوپیDataGridViewTextBoxColumn.HeaderText = "برج تلسکوپی"
        Me.برجتلسکوپیDataGridViewTextBoxColumn.Name = "برجتلسکوپیDataGridViewTextBoxColumn"
        Me.برجتلسکوپیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ساختاردکلDataGridViewTextBoxColumn
        '
        Me.ساختاردکلDataGridViewTextBoxColumn.DataPropertyName = "ساختار دکل"
        Me.ساختاردکلDataGridViewTextBoxColumn.HeaderText = "ساختار دکل"
        Me.ساختاردکلDataGridViewTextBoxColumn.Name = "ساختاردکلDataGridViewTextBoxColumn"
        Me.ساختاردکلDataGridViewTextBoxColumn.ReadOnly = True
        '
        'گروهDataGridViewTextBoxColumn
        '
        Me.گروهDataGridViewTextBoxColumn.DataPropertyName = "گروه"
        Me.گروهDataGridViewTextBoxColumn.HeaderText = "گروه"
        Me.گروهDataGridViewTextBoxColumn.Name = "گروهDataGridViewTextBoxColumn"
        Me.گروهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'امورDataGridViewTextBoxColumn
        '
        Me.امورDataGridViewTextBoxColumn.DataPropertyName = "امور"
        Me.امورDataGridViewTextBoxColumn.HeaderText = "امور"
        Me.امورDataGridViewTextBoxColumn.Name = "امورDataGridViewTextBoxColumn"
        Me.امورDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmLineBindingSource
        '
        Me.PmLineBindingSource.DataMember = "Pm_Line"
        Me.PmLineBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_Name
        '
        Me.txt_Name.CheckExistValueInDb = True
        Me.txt_Name.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Name.CurrencyUnit = "ریال"
        Me.txt_Name.DefaultValue = ""
        Me.txt_Name.FillWithMaxInDb = False
        Me.txt_Name.IsRequired = True
        Me.txt_Name.Location = New System.Drawing.Point(774, 20)
        Me.txt_Name.MaxDecimalLength = 2
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Name.Size = New System.Drawing.Size(234, 25)
        Me.txt_Name.SpellControl = Nothing
        Me.txt_Name.TabIndex = 1
        Me.txt_Name.Tag = "Name"
        Me.txt_Name.Title = Nothing
        Me.txt_Name.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Name.UseForData = True
        Me.txt_Name.ValidateCheckExistOnEdit = False
        Me.txt_Name.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1012, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "نام"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1116, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "کد"
        '
        'txt_Code
        '
        Me.txt_Code.CheckExistValueInDb = True
        Me.txt_Code.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Code.CurrencyUnit = "ریال"
        Me.txt_Code.DefaultValue = "0"
        Me.txt_Code.FillWithMaxInDb = False
        Me.txt_Code.IsRequired = False
        Me.txt_Code.Location = New System.Drawing.Point(1048, 20)
        Me.txt_Code.MaxDecimalLength = 2
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Code.Size = New System.Drawing.Size(61, 25)
        Me.txt_Code.SpellControl = Nothing
        Me.txt_Code.TabIndex = 0
        Me.txt_Code.Tag = "Code"
        Me.txt_Code.Text = "0"
        Me.txt_Code.Title = Nothing
        Me.txt_Code.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Code.UseForData = True
        Me.txt_Code.ValidateCheckExistOnEdit = False
        Me.txt_Code.Value = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "تعداد مدار"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "طول خط"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(727, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ولتاژ"
        '
        'txt_SaleBahrebardari
        '
        Me.txt_SaleBahrebardari.CheckExistValueInDb = False
        Me.txt_SaleBahrebardari.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SaleBahrebardari.CurrencyUnit = "ریال"
        Me.txt_SaleBahrebardari.DefaultValue = "0"
        Me.txt_SaleBahrebardari.FillWithMaxInDb = False
        Me.txt_SaleBahrebardari.IsRequired = False
        Me.txt_SaleBahrebardari.Location = New System.Drawing.Point(189, 20)
        Me.txt_SaleBahrebardari.MaxDecimalLength = 2
        Me.txt_SaleBahrebardari.Name = "txt_SaleBahrebardari"
        Me.txt_SaleBahrebardari.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SaleBahrebardari.Size = New System.Drawing.Size(61, 25)
        Me.txt_SaleBahrebardari.SpellControl = Nothing
        Me.txt_SaleBahrebardari.TabIndex = 5
        Me.txt_SaleBahrebardari.Tag = "LineLength"
        Me.txt_SaleBahrebardari.Text = "0"
        Me.txt_SaleBahrebardari.Title = Nothing
        Me.txt_SaleBahrebardari.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SaleBahrebardari.UseForData = True
        Me.txt_SaleBahrebardari.ValidateCheckExistOnEdit = False
        Me.txt_SaleBahrebardari.Value = "0"
        '
        'txt_Rele
        '
        Me.txt_Rele.CheckExistValueInDb = False
        Me.txt_Rele.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Rele.CurrencyUnit = "ریال"
        Me.txt_Rele.DefaultValue = "0"
        Me.txt_Rele.FillWithMaxInDb = False
        Me.txt_Rele.IsRequired = False
        Me.txt_Rele.Location = New System.Drawing.Point(317, 20)
        Me.txt_Rele.MaxDecimalLength = 2
        Me.txt_Rele.Name = "txt_Rele"
        Me.txt_Rele.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Rele.Size = New System.Drawing.Size(66, 25)
        Me.txt_Rele.SpellControl = Nothing
        Me.txt_Rele.TabIndex = 4
        Me.txt_Rele.Tag = "CycleCount"
        Me.txt_Rele.Text = "0"
        Me.txt_Rele.Title = Nothing
        Me.txt_Rele.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Rele.UseForData = True
        Me.txt_Rele.ValidateCheckExistOnEdit = False
        Me.txt_Rele.Value = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1072, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "نوع هادی"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(646, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 18)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "گروه"
        '
        'cmb_Group
        '
        Me.cmb_Group.AllowDrop = True
        Me.cmb_Group.AutoComplete = True
        Me.cmb_Group.DataSource = Me.PmGroupBindingSource
        Me.cmb_Group.DisplayMember = "نام"
        Me.cmb_Group.EnterStop = True
        Me.cmb_Group.FormattingEnabled = True
        Me.cmb_Group.IsRequired = False
        Me.cmb_Group.LimitedToList = False
        Me.cmb_Group.Location = New System.Drawing.Point(422, 129)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.OpenOnFoucus = False
        Me.cmb_Group.Size = New System.Drawing.Size(208, 26)
        Me.cmb_Group.TabIndex = 19
        Me.cmb_Group.Tag = "Srl_Group"
        Me.cmb_Group.ValueMember = "Srl"
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'کدDataGridViewTextBoxColumn
        '
        Me.کدDataGridViewTextBoxColumn.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn.Name = "کدDataGridViewTextBoxColumn"
        Me.کدDataGridViewTextBoxColumn.Width = 50
        '
        'نامپستDataGridViewTextBoxColumn
        '
        Me.نامپستDataGridViewTextBoxColumn.DataPropertyName = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.HeaderText = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.Name = "نامپستDataGridViewTextBoxColumn"
        '
        'تجهیزDataGridViewTextBoxColumn
        '
        Me.تجهیزDataGridViewTextBoxColumn.DataPropertyName = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn.HeaderText = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn.Name = "تجهیزDataGridViewTextBoxColumn"
        '
        'تیپDataGridViewTextBoxColumn
        '
        Me.تیپDataGridViewTextBoxColumn.DataPropertyName = "تیپ"
        Me.تیپDataGridViewTextBoxColumn.HeaderText = "تیپ"
        Me.تیپDataGridViewTextBoxColumn.Name = "تیپDataGridViewTextBoxColumn"
        '
        'سطحولتاژDataGridViewTextBoxColumn
        '
        Me.سطحولتاژDataGridViewTextBoxColumn.DataPropertyName = "سطح ولتاژ"
        Me.سطحولتاژDataGridViewTextBoxColumn.HeaderText = "سطح ولتاژ"
        Me.سطحولتاژDataGridViewTextBoxColumn.Name = "سطحولتاژDataGridViewTextBoxColumn"
        '
        'سالبهرهبرداریDataGridViewTextBoxColumn
        '
        Me.سالبهرهبرداریDataGridViewTextBoxColumn.DataPropertyName = "سال بهره برداری"
        Me.سالبهرهبرداریDataGridViewTextBoxColumn.HeaderText = "سال بهره برداری"
        Me.سالبهرهبرداریDataGridViewTextBoxColumn.Name = "سالبهرهبرداریDataGridViewTextBoxColumn"
        '
        'ترانسفورماتورDataGridViewTextBoxColumn
        '
        Me.ترانسفورماتورDataGridViewTextBoxColumn.DataPropertyName = "ترانسفورماتور"
        Me.ترانسفورماتورDataGridViewTextBoxColumn.HeaderText = "ترانسفورماتور"
        Me.ترانسفورماتورDataGridViewTextBoxColumn.Name = "ترانسفورماتورDataGridViewTextBoxColumn"
        '
        'اتوماسیونDataGridViewTextBoxColumn
        '
        Me.اتوماسیونDataGridViewTextBoxColumn.DataPropertyName = "اتوماسیون"
        Me.اتوماسیونDataGridViewTextBoxColumn.HeaderText = "اتوماسیون"
        Me.اتوماسیونDataGridViewTextBoxColumn.Name = "اتوماسیونDataGridViewTextBoxColumn"
        '
        'رلهDataGridViewTextBoxColumn
        '
        Me.رلهDataGridViewTextBoxColumn.DataPropertyName = "رله"
        Me.رلهDataGridViewTextBoxColumn.HeaderText = "رله"
        Me.رلهDataGridViewTextBoxColumn.Name = "رلهDataGridViewTextBoxColumn"
        '
        'ظرفیتMVADataGridViewTextBoxColumn
        '
        Me.ظرفیتMVADataGridViewTextBoxColumn.DataPropertyName = "ظرفیت-MVA"
        Me.ظرفیتMVADataGridViewTextBoxColumn.HeaderText = "ظرفیت-MVA"
        Me.ظرفیتMVADataGridViewTextBoxColumn.Name = "ظرفیتMVADataGridViewTextBoxColumn"
        '
        'ظرفیتتعدادDataGridViewTextBoxColumn
        '
        Me.ظرفیتتعدادDataGridViewTextBoxColumn.DataPropertyName = "ظرفیت-تعداد"
        Me.ظرفیتتعدادDataGridViewTextBoxColumn.HeaderText = "ظرفیت-تعداد"
        Me.ظرفیتتعدادDataGridViewTextBoxColumn.Name = "ظرفیتتعدادDataGridViewTextBoxColumn"
        '
        'نامکاملDataGridViewTextBoxColumn
        '
        Me.نامکاملDataGridViewTextBoxColumn.DataPropertyName = "نام کامل"
        Me.نامکاملDataGridViewTextBoxColumn.HeaderText = "نام کامل"
        Me.نامکاملDataGridViewTextBoxColumn.Name = "نامکاملDataGridViewTextBoxColumn"
        '
        'SrlPmPostTipDataGridViewTextBoxColumn
        '
        Me.SrlPmPostTipDataGridViewTextBoxColumn.DataPropertyName = "Srl_Pm_PostTip"
        Me.SrlPmPostTipDataGridViewTextBoxColumn.HeaderText = "Srl_Pm_PostTip"
        Me.SrlPmPostTipDataGridViewTextBoxColumn.Name = "SrlPmPostTipDataGridViewTextBoxColumn"
        Me.SrlPmPostTipDataGridViewTextBoxColumn.Visible = False
        '
        'SrlPmPostModelDataGridViewTextBoxColumn
        '
        Me.SrlPmPostModelDataGridViewTextBoxColumn.DataPropertyName = "Srl_Pm_PostModel"
        Me.SrlPmPostModelDataGridViewTextBoxColumn.HeaderText = "Srl_Pm_PostModel"
        Me.SrlPmPostModelDataGridViewTextBoxColumn.Name = "SrlPmPostModelDataGridViewTextBoxColumn"
        Me.SrlPmPostModelDataGridViewTextBoxColumn.Visible = False
        '
        'IsMission
        '
        Me.IsMission.DataPropertyName = "IsMission"
        Me.IsMission.HeaderText = "مامورتی"
        Me.IsMission.Name = "IsMission"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(382, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "امور"
        '
        'cmb_Posttype
        '
        Me.cmb_Posttype.AllowDrop = True
        Me.cmb_Posttype.AutoComplete = True
        Me.cmb_Posttype.DataSource = Me.PmPostTypeBindingSource
        Me.cmb_Posttype.DisplayMember = "نوع پست"
        Me.cmb_Posttype.EnterStop = True
        Me.cmb_Posttype.FormattingEnabled = True
        Me.cmb_Posttype.IsRequired = False
        Me.cmb_Posttype.LimitedToList = False
        Me.cmb_Posttype.Location = New System.Drawing.Point(168, 129)
        Me.cmb_Posttype.Name = "cmb_Posttype"
        Me.cmb_Posttype.OpenOnFoucus = False
        Me.cmb_Posttype.Size = New System.Drawing.Size(208, 26)
        Me.cmb_Posttype.TabIndex = 20
        Me.cmb_Posttype.Tag = "Srl_PM_PostType"
        Me.cmb_Posttype.ValueMember = "Srl"
        '
        'PmPostTypeBindingSource
        '
        Me.PmPostTypeBindingSource.DataMember = "Pm_PostType"
        Me.PmPostTypeBindingSource.DataSource = Me.Ds_Pm
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.AutoComplete = True
        Me.ComboBox1.DataSource = Me.PmLineVoltageBindingSource
        Me.ComboBox1.DisplayMember = "عنوان"
        Me.ComboBox1.EnterStop = True
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IsRequired = False
        Me.ComboBox1.LimitedToList = False
        Me.ComboBox1.Location = New System.Drawing.Point(630, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.OpenOnFoucus = False
        Me.ComboBox1.Size = New System.Drawing.Size(91, 26)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Tag = "Srl_Voltage"
        Me.ComboBox1.ValueMember = "Srl"
        '
        'PmLineVoltageBindingSource
        '
        Me.PmLineVoltageBindingSource.DataMember = "Pm_Line_Voltage"
        Me.PmLineVoltageBindingSource.DataSource = Me._Ds_Line_
        '
        '_Ds_Line_
        '
        Me._Ds_Line_.DataSetName = "Ds_Line]"
        Me._Ds_Line_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_Line_VoltageTableAdapter
        '
        Me.Pm_Line_VoltageTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = "0"
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(465, 20)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(66, 25)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Tag = "CreateDate"
        Me.TextBox1.Text = "0"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(537, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "سال احداث"
        '
        'TextBox2
        '
        Me.TextBox2.CheckExistValueInDb = False
        Me.TextBox2.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox2.CurrencyUnit = "ریال"
        Me.TextBox2.DefaultValue = "0"
        Me.TextBox2.FillWithMaxInDb = False
        Me.TextBox2.IsRequired = False
        Me.TextBox2.Location = New System.Drawing.Point(38, 20)
        Me.TextBox2.MaxDecimalLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(60, 25)
        Me.TextBox2.SpellControl = Nothing
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Tag = "DakalCount"
        Me.TextBox2.Text = "0"
        Me.TextBox2.Title = Nothing
        Me.TextBox2.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox2.UseForData = True
        Me.TextBox2.ValidateCheckExistOnEdit = False
        Me.TextBox2.Value = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(104, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "تعداد دکل"
        '
        'ComboBox2
        '
        Me.ComboBox2.AllowDrop = True
        Me.ComboBox2.AutoComplete = True
        Me.ComboBox2.DataSource = Me.PmLineHadiTypeBindingSource
        Me.ComboBox2.DisplayMember = "عنوان"
        Me.ComboBox2.EnterStop = True
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.IsRequired = False
        Me.ComboBox2.LimitedToList = False
        Me.ComboBox2.Location = New System.Drawing.Point(928, 57)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.OpenOnFoucus = False
        Me.ComboBox2.Size = New System.Drawing.Size(137, 26)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.Tag = "Srl_HadiType"
        Me.ComboBox2.ValueMember = "Srl"
        '
        'PmLineHadiTypeBindingSource
        '
        Me.PmLineHadiTypeBindingSource.DataMember = "Pm_Line_HadiType"
        Me.PmLineHadiTypeBindingSource.DataSource = Me._Ds_Line_
        '
        'Pm_Line_HadiTypeTableAdapter
        '
        Me.Pm_Line_HadiTypeTableAdapter.ClearBeforeFill = True
        '
        'TextBox3
        '
        Me.TextBox3.CheckExistValueInDb = False
        Me.TextBox3.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox3.CurrencyUnit = "ریال"
        Me.TextBox3.DefaultValue = "0"
        Me.TextBox3.FillWithMaxInDb = False
        Me.TextBox3.IsRequired = False
        Me.TextBox3.Location = New System.Drawing.Point(734, 57)
        Me.TextBox3.MaxDecimalLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(66, 25)
        Me.TextBox3.SpellControl = Nothing
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Tag = "HadiCount"
        Me.TextBox3.Text = "0"
        Me.TextBox3.Title = Nothing
        Me.TextBox3.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox3.UseForData = True
        Me.TextBox3.ValidateCheckExistOnEdit = False
        Me.TextBox3.Value = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(806, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "تعداد هادی هر فاز"
        '
        'TextBox4
        '
        Me.TextBox4.CheckExistValueInDb = False
        Me.TextBox4.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox4.CurrencyUnit = "ریال"
        Me.TextBox4.DefaultValue = "0"
        Me.TextBox4.FillWithMaxInDb = False
        Me.TextBox4.IsRequired = False
        Me.TextBox4.Location = New System.Drawing.Point(590, 57)
        Me.TextBox4.MaxDecimalLength = 2
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox4.Size = New System.Drawing.Size(60, 25)
        Me.TextBox4.SpellControl = Nothing
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Tag = "GardCount"
        Me.TextBox4.Text = "0"
        Me.TextBox4.Title = Nothing
        Me.TextBox4.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox4.UseForData = True
        Me.TextBox4.ValidateCheckExistOnEdit = False
        Me.TextBox4.Value = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(656, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 18)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "تعداد گارد"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(517, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 18)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "نوع گارد"
        '
        'ComboBox3
        '
        Me.ComboBox3.AllowDrop = True
        Me.ComboBox3.AutoComplete = True
        Me.ComboBox3.DataSource = Me.PmLineGardTypeBindingSource
        Me.ComboBox3.DisplayMember = "عنوان"
        Me.ComboBox3.EnterStop = True
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.IsRequired = False
        Me.ComboBox3.LimitedToList = False
        Me.ComboBox3.Location = New System.Drawing.Point(374, 57)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.OpenOnFoucus = False
        Me.ComboBox3.Size = New System.Drawing.Size(137, 26)
        Me.ComboBox3.TabIndex = 10
        Me.ComboBox3.Tag = "Srl_GardType"
        Me.ComboBox3.ValueMember = "Srl"
        '
        'PmLineGardTypeBindingSource
        '
        Me.PmLineGardTypeBindingSource.DataMember = "Pm_Line_GardType"
        Me.PmLineGardTypeBindingSource.DataSource = Me._Ds_Line_
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(998, 131)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 22)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Tag = "HasFibre"
        Me.CheckBox1.Text = "مجهز به فیبر نوری"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(312, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 18)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "نوع مقره"
        '
        'ComboBox4
        '
        Me.ComboBox4.AllowDrop = True
        Me.ComboBox4.AutoComplete = True
        Me.ComboBox4.DataSource = Me.PmLineMaghareTypeBindingSource
        Me.ComboBox4.DisplayMember = "عنوان"
        Me.ComboBox4.EnterStop = True
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.IsRequired = False
        Me.ComboBox4.LimitedToList = False
        Me.ComboBox4.Location = New System.Drawing.Point(169, 57)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.OpenOnFoucus = False
        Me.ComboBox4.Size = New System.Drawing.Size(137, 26)
        Me.ComboBox4.TabIndex = 11
        Me.ComboBox4.Tag = "Srl_MaghareType"
        Me.ComboBox4.ValueMember = "Srl"
        '
        'PmLineMaghareTypeBindingSource
        '
        Me.PmLineMaghareTypeBindingSource.DataMember = "Pm_Line_MaghareType"
        Me.PmLineMaghareTypeBindingSource.DataSource = Me._Ds_Line_
        '
        'Pm_Line_MaghareTypeTableAdapter
        '
        Me.Pm_Line_MaghareTypeTableAdapter.ClearBeforeFill = True
        '
        'Pm_Line_GardTypeTableAdapter
        '
        Me.Pm_Line_GardTypeTableAdapter.ClearBeforeFill = True
        '
        'TextBox5
        '
        Me.TextBox5.CheckExistValueInDb = False
        Me.TextBox5.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox5.CurrencyUnit = "ریال"
        Me.TextBox5.DefaultValue = "0"
        Me.TextBox5.FillWithMaxInDb = False
        Me.TextBox5.IsRequired = False
        Me.TextBox5.Location = New System.Drawing.Point(963, 94)
        Me.TextBox5.MaxDecimalLength = 2
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox5.Size = New System.Drawing.Size(66, 25)
        Me.TextBox5.SpellControl = Nothing
        Me.TextBox5.TabIndex = 13
        Me.TextBox5.Tag = "AviziTowerCount"
        Me.TextBox5.Text = "0"
        Me.TextBox5.Title = Nothing
        Me.TextBox5.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox5.UseForData = True
        Me.TextBox5.ValidateCheckExistOnEdit = False
        Me.TextBox5.Value = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1039, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 18)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "تعداد برج آویزی"
        '
        'TextBox6
        '
        Me.TextBox6.CheckExistValueInDb = False
        Me.TextBox6.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox6.CurrencyUnit = "ریال"
        Me.TextBox6.DefaultValue = "0"
        Me.TextBox6.FillWithMaxInDb = False
        Me.TextBox6.IsRequired = False
        Me.TextBox6.Location = New System.Drawing.Point(769, 94)
        Me.TextBox6.MaxDecimalLength = 2
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox6.Size = New System.Drawing.Size(66, 25)
        Me.TextBox6.SpellControl = Nothing
        Me.TextBox6.TabIndex = 14
        Me.TextBox6.Tag = "KesheshiTowerCount"
        Me.TextBox6.Text = "0"
        Me.TextBox6.Title = Nothing
        Me.TextBox6.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox6.UseForData = True
        Me.TextBox6.ValidateCheckExistOnEdit = False
        Me.TextBox6.Value = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(841, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 18)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "تعداد برج کششی"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(307, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 18)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "ساختار دکل"
        '
        'ComboBox5
        '
        Me.ComboBox5.AllowDrop = True
        Me.ComboBox5.AutoComplete = True
        Me.ComboBox5.DataSource = Me.PmLineDakalStructureBindingSource
        Me.ComboBox5.DisplayMember = "عنوان"
        Me.ComboBox5.EnterStop = True
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.IsRequired = False
        Me.ComboBox5.LimitedToList = False
        Me.ComboBox5.Location = New System.Drawing.Point(168, 94)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.OpenOnFoucus = False
        Me.ComboBox5.Size = New System.Drawing.Size(137, 26)
        Me.ComboBox5.TabIndex = 17
        Me.ComboBox5.Tag = "Srl_DakalStructure"
        Me.ComboBox5.ValueMember = "Srl"
        '
        'PmLineDakalStructureBindingSource
        '
        Me.PmLineDakalStructureBindingSource.DataMember = "Pm_Line_DakalStructure"
        Me.PmLineDakalStructureBindingSource.DataSource = Me._Ds_Line_
        '
        'Pm_Line_DakalStructureTableAdapter
        '
        Me.Pm_Line_DakalStructureTableAdapter.ClearBeforeFill = True
        '
        'TextBox7
        '
        Me.TextBox7.CheckExistValueInDb = False
        Me.TextBox7.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox7.CurrencyUnit = "ریال"
        Me.TextBox7.DefaultValue = "0"
        Me.TextBox7.FillWithMaxInDb = False
        Me.TextBox7.IsRequired = False
        Me.TextBox7.Location = New System.Drawing.Point(590, 94)
        Me.TextBox7.MaxDecimalLength = 2
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox7.Size = New System.Drawing.Size(66, 25)
        Me.TextBox7.SpellControl = Nothing
        Me.TextBox7.TabIndex = 15
        Me.TextBox7.Tag = "LatisTowerCount"
        Me.TextBox7.Text = "0"
        Me.TextBox7.Title = Nothing
        Me.TextBox7.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox7.UseForData = True
        Me.TextBox7.ValidateCheckExistOnEdit = False
        Me.TextBox7.Value = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(662, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 18)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "تعداد برج لتیس"
        '
        'TextBox8
        '
        Me.TextBox8.CheckExistValueInDb = False
        Me.TextBox8.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox8.CurrencyUnit = "ریال"
        Me.TextBox8.DefaultValue = "0"
        Me.TextBox8.FillWithMaxInDb = False
        Me.TextBox8.IsRequired = False
        Me.TextBox8.Location = New System.Drawing.Point(388, 94)
        Me.TextBox8.MaxDecimalLength = 2
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox8.Size = New System.Drawing.Size(66, 25)
        Me.TextBox8.SpellControl = Nothing
        Me.TextBox8.TabIndex = 16
        Me.TextBox8.Tag = "TelescopTowerCount"
        Me.TextBox8.Text = "0"
        Me.TextBox8.Title = Nothing
        Me.TextBox8.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox8.UseForData = True
        Me.TextBox8.ValidateCheckExistOnEdit = False
        Me.TextBox8.Value = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(460, 97)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 18)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "تعداد برج تلسکوپی"
        '
        'TextBox9
        '
        Me.TextBox9.CheckExistValueInDb = False
        Me.TextBox9.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox9.CurrencyUnit = "ریال"
        Me.TextBox9.DefaultValue = "0"
        Me.TextBox9.FillWithMaxInDb = False
        Me.TextBox9.IsRequired = False
        Me.TextBox9.Location = New System.Drawing.Point(19, 57)
        Me.TextBox9.MaxDecimalLength = 2
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox9.Size = New System.Drawing.Size(66, 25)
        Me.TextBox9.SpellControl = Nothing
        Me.TextBox9.TabIndex = 12
        Me.TextBox9.Tag = "MaghareCount"
        Me.TextBox9.Text = "0"
        Me.TextBox9.Title = Nothing
        Me.TextBox9.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox9.UseForData = True
        Me.TextBox9.ValidateCheckExistOnEdit = False
        Me.TextBox9.Value = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(91, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "تعداد مقره"
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'Convert
        '
        Me.Convert.Location = New System.Drawing.Point(24, 126)
        Me.Convert.Name = "Convert"
        Me.Convert.Size = New System.Drawing.Size(100, 31)
        Me.Convert.TabIndex = 21
        Me.Convert.Text = "انتقال خطوط"
        Me.Convert.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTypeTableAdapter
        '
        Me.Pm_PostTypeTableAdapter.ClearBeforeFill = True
        '
        'TextBox10
        '
        Me.TextBox10.CheckExistValueInDb = False
        Me.TextBox10.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox10.CurrencyUnit = "ریال"
        Me.TextBox10.DefaultValue = "0"
        Me.TextBox10.FillWithMaxInDb = False
        Me.TextBox10.IsRequired = False
        Me.TextBox10.Location = New System.Drawing.Point(19, 90)
        Me.TextBox10.MaxDecimalLength = 2
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox10.Size = New System.Drawing.Size(66, 25)
        Me.TextBox10.SpellControl = Nothing
        Me.TextBox10.TabIndex = 13
        Me.TextBox10.Tag = "tirCount"
        Me.TextBox10.Text = "0"
        Me.TextBox10.Title = Nothing
        Me.TextBox10.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox10.UseForData = True
        Me.TextBox10.ValidateCheckExistOnEdit = False
        Me.TextBox10.Value = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(95, 93)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 18)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "تعداد تیر"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(927, 132)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 18)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "نوع فیبر"
        '
        'cmb_fibrtype
        '
        Me.cmb_fibrtype.AllowDrop = True
        Me.cmb_fibrtype.AutoComplete = True
        Me.cmb_fibrtype.DataSource = Me.PmLineFibrTypeBindingSource
        Me.cmb_fibrtype.DisplayMember = "عنوان"
        Me.cmb_fibrtype.EnterStop = True
        Me.cmb_fibrtype.FormattingEnabled = True
        Me.cmb_fibrtype.IsRequired = False
        Me.cmb_fibrtype.LimitedToList = False
        Me.cmb_fibrtype.Location = New System.Drawing.Point(784, 129)
        Me.cmb_fibrtype.Name = "cmb_fibrtype"
        Me.cmb_fibrtype.OpenOnFoucus = False
        Me.cmb_fibrtype.Size = New System.Drawing.Size(137, 26)
        Me.cmb_fibrtype.TabIndex = 10
        Me.cmb_fibrtype.Tag = "Srl_fibrType"
        Me.cmb_fibrtype.ValueMember = "srl"
        '
        'PmLineFibrTypeBindingSource
        '
        Me.PmLineFibrTypeBindingSource.DataMember = "Pm_Line_FibrType"
        Me.PmLineFibrTypeBindingSource.DataSource = Me._Ds_Line_
        '
        'Pm_Line_FibrTypeTableAdapter
        '
        Me.Pm_Line_FibrTypeTableAdapter.ClearBeforeFill = True
        '
        'Frm_Line
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1172, 581)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Line"
        Me.TableName = "Pm_Line"
        Me.Text = "تعریف خط"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineVoltageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Ds_Line_, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineHadiTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineGardTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineMaghareTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineDakalStructureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineFibrTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents txt_Code As CS_Component.TextBox
    Friend WithEvents txt_Name As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_SaleBahrebardari As CS_Component.TextBox
    Friend WithEvents txt_Rele As CS_Component.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_Group As VB_Component.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تجهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تیپDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سطحولتاژDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سالبهرهبرداریDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ترانسفورماتورDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اتوماسیونDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents رلهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ظرفیتMVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ظرفیتتعدادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامکاملDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmPostTipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmPostModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsMission As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmb_Posttype As VB_Component.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As VB_Component.ComboBox
    Friend WithEvents _Ds_Line_ As Nama_PM._Ds_Line_
    Friend WithEvents PmLineVoltageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Line_VoltageTableAdapter As Nama_PM._Ds_Line_TableAdapters.Pm_Line_VoltageTableAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As CS_Component.TextBox
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents ComboBox2 As VB_Component.ComboBox
    Friend WithEvents PmLineHadiTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Line_HadiTypeTableAdapter As Nama_PM._Ds_Line_TableAdapters.Pm_Line_HadiTypeTableAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As CS_Component.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox3 As VB_Component.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As CS_Component.TextBox
    Friend WithEvents ComboBox4 As VB_Component.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PmLineMaghareTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Line_MaghareTypeTableAdapter As Nama_PM._Ds_Line_TableAdapters.Pm_Line_MaghareTypeTableAdapter
    Friend WithEvents PmLineGardTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Line_GardTypeTableAdapter As Nama_PM._Ds_Line_TableAdapters.Pm_Line_GardTypeTableAdapter
    Friend WithEvents ComboBox5 As VB_Component.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As CS_Component.TextBox
    Friend WithEvents TextBox5 As CS_Component.TextBox
    Friend WithEvents PmLineDakalStructureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Line_DakalStructureTableAdapter As Nama_PM._Ds_Line_TableAdapters.Pm_Line_DakalStructureTableAdapter
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As CS_Component.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As CS_Component.TextBox
    Friend WithEvents TextBox8 As CS_Component.TextBox
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents کدDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ولتاژDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سالاحداثDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مدارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents طولDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents دکلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents برجآویزیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents برجکششیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعهادیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعدادهادیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents گاردDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعگاردDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents دارایفیبرDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents نوعمقرهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مقرهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents برجلتیسDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents برجتلسکوپیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساختاردکلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents گروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents امورDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Convert As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents PmPostTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTypeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
    Friend WithEvents cmb_fibrtype As VB_Component.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As CS_Component.TextBox
    Friend WithEvents PmLineFibrTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Line_FibrTypeTableAdapter As Nama_PM._Ds_Line_TableAdapters.Pm_Line_FibrTypeTableAdapter
End Class
