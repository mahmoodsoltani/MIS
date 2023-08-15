<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_StatusStatementVw
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامواحدDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامپستDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامخطDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.SrlDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlvahedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlpostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrllineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IscancleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IsnightDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IsholidayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PmConStatusStatementVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
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
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TarikhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامواحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pm_Con_StatusStatementVwTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementVwTableAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.chk_vahed = New System.Windows.Forms.CheckBox
        Me.cmb_vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Group = New VB_Component.ComboBox
        Me.cmb_Post = New VB_Component.ComboBox
        Me.chk_Group = New System.Windows.Forms.CheckBox
        Me.chk_Post = New System.Windows.Forms.CheckBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chk_allday = New System.Windows.Forms.CheckBox
        Me.cmb_line = New VB_Component.ComboBox
        Me.PmLineBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Update = New System.Windows.Forms.PictureBox
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConStatusStatementVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(587, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        Me.btn_Delete.TabIndex = 1
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "F2 جدید "
        Me.btn_new.Location = New System.Drawing.Point(834, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(711, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.TabIndex = 0
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.btn_Update)
        Me.gbx_GridViewList.Controls.Add(Me.chk_vahed)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_vahed)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_Group)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_line)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_Post)
        Me.gbx_GridViewList.Controls.Add(Me.chk_Group)
        Me.gbx_GridViewList.Controls.Add(Me.chk_Post)
        Me.gbx_GridViewList.Controls.Add(Me.txt_ToDate)
        Me.gbx_GridViewList.Controls.Add(Me.txt_FromDate)
        Me.gbx_GridViewList.Controls.Add(Me.Label4)
        Me.gbx_GridViewList.Controls.Add(Me.chk_allday)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 60)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(958, 395)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 524)
        Me.gbx_Controls.Size = New System.Drawing.Size(958, 10)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Controls.Add(Me.Panel1)
        Me.gbx_Btn.Controls.Add(Me.Panel3)
        Me.gbx_Btn.Controls.Add(Me.Panel2)
        Me.gbx_Btn.Controls.Add(Me.Label1)
        Me.gbx_Btn.Controls.Add(Me.Label2)
        Me.gbx_Btn.Controls.Add(Me.Label3)
        Me.gbx_Btn.Location = New System.Drawing.Point(11, 461)
        Me.gbx_Btn.Size = New System.Drawing.Size(958, 57)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Label3, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Label2, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Label1, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Panel2, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Panel3, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Panel1, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_new, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Cancel, 0)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.شمارهDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn1, Me.نامواحدDataGridViewTextBoxColumn1, Me.نامگروهDataGridViewTextBoxColumn1, Me.نامپستDataGridViewTextBoxColumn1, Me.نامخطDataGridViewTextBoxColumn, Me.نوعDataGridViewTextBoxColumn, Me.Column1, Me.Column2, Me.SrlDataGridViewTextBoxColumn2, Me.SrlvahedDataGridViewTextBoxColumn, Me.SrlgroupDataGridViewTextBoxColumn, Me.SrlpostDataGridViewTextBoxColumn, Me.SrllineDataGridViewTextBoxColumn, Me.IscancleDataGridViewCheckBoxColumn, Me.IsnightDataGridViewCheckBoxColumn, Me.IsholidayDataGridViewCheckBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmConStatusStatementVwBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 105)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(952, 287)
        Me.DataGridView1.TabIndex = 1
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخDataGridViewTextBoxColumn1
        '
        Me.تاریخDataGridViewTextBoxColumn1.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn1.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn1.Name = "تاریخDataGridViewTextBoxColumn1"
        Me.تاریخDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامواحدDataGridViewTextBoxColumn1
        '
        Me.نامواحدDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
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
        'نامپستDataGridViewTextBoxColumn1
        '
        Me.نامپستDataGridViewTextBoxColumn1.DataPropertyName = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn1.HeaderText = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn1.Name = "نامپستDataGridViewTextBoxColumn1"
        Me.نامپستDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامخطDataGridViewTextBoxColumn
        '
        Me.نامخطDataGridViewTextBoxColumn.DataPropertyName = "نام خط"
        Me.نامخطDataGridViewTextBoxColumn.HeaderText = "نام خط"
        Me.نامخطDataGridViewTextBoxColumn.Name = "نامخطDataGridViewTextBoxColumn"
        Me.نامخطDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نوعDataGridViewTextBoxColumn
        '
        Me.نوعDataGridViewTextBoxColumn.DataPropertyName = "نوع"
        Me.نوعDataGridViewTextBoxColumn.HeaderText = "نوع"
        Me.نوعDataGridViewTextBoxColumn.Name = "نوعDataGridViewTextBoxColumn"
        Me.نوعDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 25
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 25
        '
        'SrlDataGridViewTextBoxColumn2
        '
        Me.SrlDataGridViewTextBoxColumn2.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.Name = "SrlDataGridViewTextBoxColumn2"
        Me.SrlDataGridViewTextBoxColumn2.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn2.Visible = False
        '
        'SrlvahedDataGridViewTextBoxColumn
        '
        Me.SrlvahedDataGridViewTextBoxColumn.DataPropertyName = "Srl_vahed"
        Me.SrlvahedDataGridViewTextBoxColumn.HeaderText = "Srl_vahed"
        Me.SrlvahedDataGridViewTextBoxColumn.Name = "SrlvahedDataGridViewTextBoxColumn"
        Me.SrlvahedDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlvahedDataGridViewTextBoxColumn.Visible = False
        '
        'SrlgroupDataGridViewTextBoxColumn
        '
        Me.SrlgroupDataGridViewTextBoxColumn.DataPropertyName = "Srl_group"
        Me.SrlgroupDataGridViewTextBoxColumn.HeaderText = "Srl_group"
        Me.SrlgroupDataGridViewTextBoxColumn.Name = "SrlgroupDataGridViewTextBoxColumn"
        Me.SrlgroupDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlgroupDataGridViewTextBoxColumn.Visible = False
        '
        'SrlpostDataGridViewTextBoxColumn
        '
        Me.SrlpostDataGridViewTextBoxColumn.DataPropertyName = "srl_post"
        Me.SrlpostDataGridViewTextBoxColumn.HeaderText = "srl_post"
        Me.SrlpostDataGridViewTextBoxColumn.Name = "SrlpostDataGridViewTextBoxColumn"
        Me.SrlpostDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlpostDataGridViewTextBoxColumn.Visible = False
        '
        'SrllineDataGridViewTextBoxColumn
        '
        Me.SrllineDataGridViewTextBoxColumn.DataPropertyName = "srl_line"
        Me.SrllineDataGridViewTextBoxColumn.HeaderText = "srl_line"
        Me.SrllineDataGridViewTextBoxColumn.Name = "SrllineDataGridViewTextBoxColumn"
        Me.SrllineDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrllineDataGridViewTextBoxColumn.Visible = False
        '
        'IscancleDataGridViewCheckBoxColumn
        '
        Me.IscancleDataGridViewCheckBoxColumn.DataPropertyName = "is_cancle"
        Me.IscancleDataGridViewCheckBoxColumn.HeaderText = "is_cancle"
        Me.IscancleDataGridViewCheckBoxColumn.Name = "IscancleDataGridViewCheckBoxColumn"
        Me.IscancleDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IscancleDataGridViewCheckBoxColumn.Visible = False
        '
        'IsnightDataGridViewCheckBoxColumn
        '
        Me.IsnightDataGridViewCheckBoxColumn.DataPropertyName = "is_night"
        Me.IsnightDataGridViewCheckBoxColumn.HeaderText = "is_night"
        Me.IsnightDataGridViewCheckBoxColumn.Name = "IsnightDataGridViewCheckBoxColumn"
        Me.IsnightDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsnightDataGridViewCheckBoxColumn.Visible = False
        '
        'IsholidayDataGridViewCheckBoxColumn
        '
        Me.IsholidayDataGridViewCheckBoxColumn.DataPropertyName = "is_holiday"
        Me.IsholidayDataGridViewCheckBoxColumn.HeaderText = "is_holiday"
        Me.IsholidayDataGridViewCheckBoxColumn.Name = "IsholidayDataGridViewCheckBoxColumn"
        Me.IsholidayDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsholidayDataGridViewCheckBoxColumn.Visible = False
        '
        'PmConStatusStatementVwBindingSource
        '
        Me.PmConStatusStatementVwBindingSource.DataMember = "Pm_Con_StatusStatementVw"
        Me.PmConStatusStatementVwBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        '
        'NumberDataGridViewTextBoxColumn
        '
        Me.NumberDataGridViewTextBoxColumn.DataPropertyName = "Number"
        Me.NumberDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.NumberDataGridViewTextBoxColumn.Name = "NumberDataGridViewTextBoxColumn"
        '
        'TarikhDataGridViewTextBoxColumn
        '
        Me.TarikhDataGridViewTextBoxColumn.DataPropertyName = "Tarikh"
        Me.TarikhDataGridViewTextBoxColumn.HeaderText = "Tarikh"
        Me.TarikhDataGridViewTextBoxColumn.Name = "TarikhDataGridViewTextBoxColumn"
        Me.TarikhDataGridViewTextBoxColumn.Visible = False
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        '
        'نامواحدDataGridViewTextBoxColumn
        '
        Me.نامواحدDataGridViewTextBoxColumn.DataPropertyName = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.HeaderText = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.Name = "نامواحدDataGridViewTextBoxColumn"
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        '
        'Pm_Con_StatusStatementVwTableAdapter
        '
        Me.Pm_Con_StatusStatementVwTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel1.Location = New System.Drawing.Point(511, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(20, 20)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(384, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(20, 20)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.Location = New System.Drawing.Point(244, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(20, 20)
        Me.Panel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(464, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "تعطیل"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "کنسلی"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "کار شبانه"
        '
        'chk_vahed
        '
        Me.chk_vahed.AutoSize = True
        Me.chk_vahed.Checked = True
        Me.chk_vahed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_vahed.Location = New System.Drawing.Point(438, 23)
        Me.chk_vahed.Name = "chk_vahed"
        Me.chk_vahed.Size = New System.Drawing.Size(55, 22)
        Me.chk_vahed.TabIndex = 205
        Me.chk_vahed.Text = "واحد"
        Me.chk_vahed.UseVisualStyleBackColor = True
        '
        'cmb_vahed
        '
        Me.cmb_vahed.AutoComplete = True
        Me.cmb_vahed.DataSource = Me.PmVahedBindingSource1
        Me.cmb_vahed.DisplayMember = "نام واحد"
        Me.cmb_vahed.Enabled = False
        Me.cmb_vahed.EnterStop = True
        Me.cmb_vahed.FormattingEnabled = True
        Me.cmb_vahed.IsRequired = False
        Me.cmb_vahed.LimitedToList = True
        Me.cmb_vahed.Location = New System.Drawing.Point(170, 21)
        Me.cmb_vahed.Name = "cmb_vahed"
        Me.cmb_vahed.OpenOnFoucus = True
        Me.cmb_vahed.Size = New System.Drawing.Size(264, 26)
        Me.cmb_vahed.TabIndex = 204
        Me.cmb_vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource1
        '
        Me.PmVahedBindingSource1.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource1.DataSource = Me.Ds_Pm
        '
        'cmb_Group
        '
        Me.cmb_Group.AutoComplete = True
        Me.cmb_Group.DataSource = Me.PmGroupBindingSource
        Me.cmb_Group.DisplayMember = "نام"
        Me.cmb_Group.Enabled = False
        Me.cmb_Group.EnterStop = True
        Me.cmb_Group.FormattingEnabled = True
        Me.cmb_Group.IsRequired = False
        Me.cmb_Group.LimitedToList = True
        Me.cmb_Group.Location = New System.Drawing.Point(170, 51)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.OpenOnFoucus = True
        Me.cmb_Group.Size = New System.Drawing.Size(264, 26)
        Me.cmb_Group.TabIndex = 202
        Me.cmb_Group.ValueMember = "Srl"
        '
        'cmb_Post
        '
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PmPostBindingSource
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.Enabled = False
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = True
        Me.cmb_Post.Location = New System.Drawing.Point(561, 51)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = True
        Me.cmb_Post.Size = New System.Drawing.Size(318, 26)
        Me.cmb_Post.TabIndex = 203
        Me.cmb_Post.ValueMember = "Srl"
        '
        'chk_Group
        '
        Me.chk_Group.AutoSize = True
        Me.chk_Group.Checked = True
        Me.chk_Group.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Group.Location = New System.Drawing.Point(440, 53)
        Me.chk_Group.Name = "chk_Group"
        Me.chk_Group.Size = New System.Drawing.Size(53, 22)
        Me.chk_Group.TabIndex = 201
        Me.chk_Group.Text = "گروه"
        Me.chk_Group.UseVisualStyleBackColor = True
        '
        'chk_Post
        '
        Me.chk_Post.AutoSize = True
        Me.chk_Post.Checked = True
        Me.chk_Post.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Post.Location = New System.Drawing.Point(889, 53)
        Me.chk_Post.Name = "chk_Post"
        Me.chk_Post.Size = New System.Drawing.Size(61, 22)
        Me.chk_Post.TabIndex = 200
        Me.chk_Post.Text = "پست"
        Me.chk_Post.UseVisualStyleBackColor = True
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.Enabled = False
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(561, 21)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(144, 25)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 198
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.Enabled = False
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(733, 20)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(146, 25)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 197
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(711, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 18)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "تا"
        '
        'chk_allday
        '
        Me.chk_allday.AutoSize = True
        Me.chk_allday.Checked = True
        Me.chk_allday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_allday.Location = New System.Drawing.Point(881, 20)
        Me.chk_allday.Name = "chk_allday"
        Me.chk_allday.Size = New System.Drawing.Size(69, 22)
        Me.chk_allday.TabIndex = 196
        Me.chk_allday.Text = "تاریخ از"
        Me.chk_allday.UseVisualStyleBackColor = True
        '
        'cmb_line
        '
        Me.cmb_line.AutoComplete = True
        Me.cmb_line.DataSource = Me.PmLineBindingSource1
        Me.cmb_line.DisplayMember = "نام"
        Me.cmb_line.Enabled = False
        Me.cmb_line.EnterStop = True
        Me.cmb_line.FormattingEnabled = True
        Me.cmb_line.IsRequired = False
        Me.cmb_line.LimitedToList = True
        Me.cmb_line.Location = New System.Drawing.Point(561, 51)
        Me.cmb_line.Name = "cmb_line"
        Me.cmb_line.OpenOnFoucus = True
        Me.cmb_line.Size = New System.Drawing.Size(318, 26)
        Me.cmb_line.TabIndex = 203
        Me.cmb_line.ValueMember = "Srl"
        '
        'PmLineBindingSource1
        '
        Me.PmLineBindingSource1.DataMember = "Pm_Line"
        Me.PmLineBindingSource1.DataSource = Me.Ds_Pm
        '
        'btn_Update
        '
        Me.btn_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Update.Image = Global.Nama_PM.My.Resources.Resources.refresh
        Me.btn_Update.Location = New System.Drawing.Point(31, 36)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(36, 39)
        Me.btn_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Update.TabIndex = 221
        Me.btn_Update.TabStop = False
        '
        'Frm_Con_StatusStatementVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(985, 570)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_StatusStatementVw"
        Me.TableName = "Pm_Con_StatusStatement"
        Me.Text = "مشاهده صورت وضعیت های ثبت شده"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        Me.gbx_Btn.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConStatusStatementVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
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
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarikhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConStatusStatementVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_StatusStatementVwTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementVwTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپستDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامخطDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlvahedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlgroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlpostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrllineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IscancleDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsnightDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsholidayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chk_vahed As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_vahed As VB_Component.ComboBox
    Friend WithEvents cmb_Group As VB_Component.ComboBox
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents chk_Group As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Post As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chk_allday As System.Windows.Forms.CheckBox
    Friend WithEvents PmVahedBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cmb_line As VB_Component.ComboBox
    Friend WithEvents PmLineBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btn_Update As System.Windows.Forms.PictureBox
End Class
