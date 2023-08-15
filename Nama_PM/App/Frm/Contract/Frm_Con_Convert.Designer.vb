<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_Convert
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
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TarikhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامواحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.cmb_sheet = New VB_Component.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_code = New VB_Component.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmb_title = New VB_Component.ComboBox
        Me.cmb_unit = New VB_Component.ComboBox
        Me.cmb_amount = New VB_Component.ComboBox
        Me.cmb_price = New VB_Component.ComboBox
        Me.cmb_period = New VB_Component.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmb_voltage = New VB_Component.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmb_vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmb_IsStarred = New VB_Component.ComboBox
        Me.txt_unit = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Cmb_Contract = New VB_Component.ComboBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.Label11 = New System.Windows.Forms.Label
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmb_type = New VB_Component.ComboBox
        Me.PmConStatusStatementTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_StatusStatementTypeTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementTypeTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_Delete.Location = New System.Drawing.Point(462, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        Me.btn_Delete.TabIndex = 1
        Me.btn_Delete.Visible = False
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "F2 تبدیل"
        Me.btn_new.Location = New System.Drawing.Point(709, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(586, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.TabIndex = 0
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_GridViewList.Controls.Add(Me.Cmb_Contract)
        Me.gbx_GridViewList.Controls.Add(Me.txt_unit)
        Me.gbx_GridViewList.Controls.Add(Me.Label1)
        Me.gbx_GridViewList.Controls.Add(Me.Button1)
        Me.gbx_GridViewList.Controls.Add(Me.GroupBox1)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_vahed)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_type)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_sheet)
        Me.gbx_GridViewList.Controls.Add(Me.Label11)
        Me.gbx_GridViewList.Controls.Add(Me.Label13)
        Me.gbx_GridViewList.Controls.Add(Me.Label10)
        Me.gbx_GridViewList.Controls.Add(Me.Label2)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 37)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(833, 413)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Location = New System.Drawing.Point(11, 502)
        Me.gbx_Controls.Size = New System.Drawing.Size(833, 10)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(11, 450)
        Me.gbx_Btn.Size = New System.Drawing.Size(833, 57)
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
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 192)
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
        Me.DataGridView1.Size = New System.Drawing.Size(827, 218)
        Me.DataGridView1.TabIndex = 1
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
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        Me.OpenFile.Filter = "*.xls|*.xlsx"
        '
        'cmb_sheet
        '
        Me.cmb_sheet.AutoComplete = True
        Me.cmb_sheet.DisplayMember = "کد"
        Me.cmb_sheet.EnterStop = True
        Me.cmb_sheet.FormattingEnabled = True
        Me.cmb_sheet.IsRequired = False
        Me.cmb_sheet.LimitedToList = True
        Me.cmb_sheet.Location = New System.Drawing.Point(99, 47)
        Me.cmb_sheet.Name = "cmb_sheet"
        Me.cmb_sheet.OpenOnFoucus = False
        Me.cmb_sheet.Size = New System.Drawing.Size(149, 26)
        Me.cmb_sheet.TabIndex = 2
        Me.cmb_sheet.ValueMember = "Srl"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "شیت"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(749, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "کد:"
        '
        'cmb_code
        '
        Me.cmb_code.AutoComplete = True
        Me.cmb_code.DisplayMember = "کد"
        Me.cmb_code.EnterStop = True
        Me.cmb_code.FormattingEnabled = True
        Me.cmb_code.IsRequired = False
        Me.cmb_code.LimitedToList = True
        Me.cmb_code.Location = New System.Drawing.Point(557, 21)
        Me.cmb_code.Name = "cmb_code"
        Me.cmb_code.OpenOnFoucus = False
        Me.cmb_code.Size = New System.Drawing.Size(186, 26)
        Me.cmb_code.TabIndex = 2
        Me.cmb_code.ValueMember = "Srl"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(472, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "عنوان:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(749, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "واحد"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(472, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "تعداد:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "قیمت:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(749, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "دوره:"
        '
        'cmb_title
        '
        Me.cmb_title.AutoComplete = True
        Me.cmb_title.DisplayMember = "کد"
        Me.cmb_title.EnterStop = True
        Me.cmb_title.FormattingEnabled = True
        Me.cmb_title.IsRequired = False
        Me.cmb_title.LimitedToList = True
        Me.cmb_title.Location = New System.Drawing.Point(280, 21)
        Me.cmb_title.Name = "cmb_title"
        Me.cmb_title.OpenOnFoucus = False
        Me.cmb_title.Size = New System.Drawing.Size(186, 26)
        Me.cmb_title.TabIndex = 2
        Me.cmb_title.ValueMember = "Srl"
        '
        'cmb_unit
        '
        Me.cmb_unit.AutoComplete = True
        Me.cmb_unit.DisplayMember = "کد"
        Me.cmb_unit.EnterStop = True
        Me.cmb_unit.FormattingEnabled = True
        Me.cmb_unit.IsRequired = False
        Me.cmb_unit.LimitedToList = True
        Me.cmb_unit.Location = New System.Drawing.Point(557, 53)
        Me.cmb_unit.Name = "cmb_unit"
        Me.cmb_unit.OpenOnFoucus = False
        Me.cmb_unit.Size = New System.Drawing.Size(186, 26)
        Me.cmb_unit.TabIndex = 2
        Me.cmb_unit.ValueMember = "Srl"
        '
        'cmb_amount
        '
        Me.cmb_amount.AutoComplete = True
        Me.cmb_amount.DisplayMember = "کد"
        Me.cmb_amount.EnterStop = True
        Me.cmb_amount.FormattingEnabled = True
        Me.cmb_amount.IsRequired = False
        Me.cmb_amount.LimitedToList = True
        Me.cmb_amount.Location = New System.Drawing.Point(280, 53)
        Me.cmb_amount.Name = "cmb_amount"
        Me.cmb_amount.OpenOnFoucus = False
        Me.cmb_amount.Size = New System.Drawing.Size(186, 26)
        Me.cmb_amount.TabIndex = 2
        Me.cmb_amount.ValueMember = "Srl"
        '
        'cmb_price
        '
        Me.cmb_price.AutoComplete = True
        Me.cmb_price.DisplayMember = "کد"
        Me.cmb_price.EnterStop = True
        Me.cmb_price.FormattingEnabled = True
        Me.cmb_price.IsRequired = False
        Me.cmb_price.LimitedToList = True
        Me.cmb_price.Location = New System.Drawing.Point(7, 53)
        Me.cmb_price.Name = "cmb_price"
        Me.cmb_price.OpenOnFoucus = False
        Me.cmb_price.Size = New System.Drawing.Size(186, 26)
        Me.cmb_price.TabIndex = 2
        Me.cmb_price.ValueMember = "Srl"
        '
        'cmb_period
        '
        Me.cmb_period.AutoComplete = True
        Me.cmb_period.DisplayMember = "کد"
        Me.cmb_period.EnterStop = True
        Me.cmb_period.FormattingEnabled = True
        Me.cmb_period.IsRequired = False
        Me.cmb_period.LimitedToList = True
        Me.cmb_period.Location = New System.Drawing.Point(557, 85)
        Me.cmb_period.Name = "cmb_period"
        Me.cmb_period.OpenOnFoucus = False
        Me.cmb_period.Size = New System.Drawing.Size(186, 26)
        Me.cmb_period.TabIndex = 2
        Me.cmb_period.ValueMember = "Srl"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(199, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ولتاژ:"
        '
        'cmb_voltage
        '
        Me.cmb_voltage.AutoComplete = True
        Me.cmb_voltage.DisplayMember = "کد"
        Me.cmb_voltage.EnterStop = True
        Me.cmb_voltage.FormattingEnabled = True
        Me.cmb_voltage.IsRequired = False
        Me.cmb_voltage.LimitedToList = True
        Me.cmb_voltage.Location = New System.Drawing.Point(7, 21)
        Me.cmb_voltage.Name = "cmb_voltage"
        Me.cmb_voltage.OpenOnFoucus = False
        Me.cmb_voltage.Size = New System.Drawing.Size(186, 26)
        Me.cmb_voltage.TabIndex = 2
        Me.cmb_voltage.ValueMember = "Srl"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(787, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "واحد"
        '
        'cmb_vahed
        '
        Me.cmb_vahed.AutoComplete = True
        Me.cmb_vahed.DataSource = Me.PmVahedBindingSource
        Me.cmb_vahed.DisplayMember = "نام واحد"
        Me.cmb_vahed.EnterStop = True
        Me.cmb_vahed.FormattingEnabled = True
        Me.cmb_vahed.IsRequired = False
        Me.cmb_vahed.LimitedToList = True
        Me.cmb_vahed.Location = New System.Drawing.Point(577, 47)
        Me.cmb_vahed.Name = "cmb_vahed"
        Me.cmb_vahed.OpenOnFoucus = False
        Me.cmb_vahed.Size = New System.Drawing.Size(186, 26)
        Me.cmb_vahed.TabIndex = 2
        Me.cmb_vahed.ValueMember = "Srl"
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
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_code)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_amount)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmb_IsStarred)
        Me.GroupBox1.Controls.Add(Me.cmb_period)
        Me.GroupBox1.Controls.Add(Me.cmb_title)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmb_voltage)
        Me.GroupBox1.Controls.Add(Me.cmb_price)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmb_unit)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 119)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "انتخاب ستونها"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(472, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "ستاره دار"
        '
        'cmb_IsStarred
        '
        Me.cmb_IsStarred.AutoComplete = True
        Me.cmb_IsStarred.DisplayMember = "کد"
        Me.cmb_IsStarred.EnterStop = True
        Me.cmb_IsStarred.FormattingEnabled = True
        Me.cmb_IsStarred.IsRequired = False
        Me.cmb_IsStarred.LimitedToList = True
        Me.cmb_IsStarred.Location = New System.Drawing.Point(280, 85)
        Me.cmb_IsStarred.Name = "cmb_IsStarred"
        Me.cmb_IsStarred.OpenOnFoucus = False
        Me.cmb_IsStarred.Size = New System.Drawing.Size(186, 26)
        Me.cmb_IsStarred.TabIndex = 2
        Me.cmb_IsStarred.ValueMember = "Srl"
        '
        'txt_unit
        '
        Me.txt_unit.CheckExistValueInDb = True
        Me.txt_unit.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_unit.CurrencyUnit = "ریال"
        Me.txt_unit.DefaultValue = ""
        Me.txt_unit.Enabled = False
        Me.txt_unit.FillWithMaxInDb = False
        Me.txt_unit.IsRequired = True
        Me.txt_unit.Location = New System.Drawing.Point(335, 47)
        Me.txt_unit.MaxDecimalLength = 2
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_unit.Size = New System.Drawing.Size(186, 25)
        Me.txt_unit.SpellControl = Nothing
        Me.txt_unit.TabIndex = 8
        Me.txt_unit.Tag = ""
        Me.txt_unit.Title = Nothing
        Me.txt_unit.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_unit.UseForData = True
        Me.txt_unit.ValidateCheckExistOnEdit = False
        Me.txt_unit.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(527, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "مسیر"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(305, 46)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cmb_Contract
        '
        Me.Cmb_Contract.AutoComplete = True
        Me.Cmb_Contract.DataSource = Me.PmConContractBindingSource
        Me.Cmb_Contract.DisplayMember = "عنوان"
        Me.Cmb_Contract.EnterStop = True
        Me.Cmb_Contract.FormattingEnabled = True
        Me.Cmb_Contract.IsRequired = False
        Me.Cmb_Contract.LimitedToList = True
        Me.Cmb_Contract.Location = New System.Drawing.Point(577, 15)
        Me.Cmb_Contract.Name = "Cmb_Contract"
        Me.Cmb_Contract.OpenOnFoucus = False
        Me.Cmb_Contract.Size = New System.Drawing.Size(186, 26)
        Me.Cmb_Contract.TabIndex = 2
        Me.Cmb_Contract.ValueMember = "Srl"
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(776, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "قرارداد"
        '
        'Pm_Con_ContractTableAdapter
        '
        Me.Pm_Con_ContractTableAdapter.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(254, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 18)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "نوع"
        '
        'cmb_type
        '
        Me.cmb_type.AutoComplete = True
        Me.cmb_type.DataSource = Me.PmConStatusStatementTypeBindingSource
        Me.cmb_type.DisplayMember = "name"
        Me.cmb_type.EnterStop = True
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.IsRequired = False
        Me.cmb_type.LimitedToList = True
        Me.cmb_type.Location = New System.Drawing.Point(99, 15)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.OpenOnFoucus = False
        Me.cmb_type.Size = New System.Drawing.Size(149, 26)
        Me.cmb_type.TabIndex = 2
        Me.cmb_type.ValueMember = "Srl"
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
        'Frm_Con_Convert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(860, 544)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_Convert"
        Me.TableName = "Pm_Con_StatusStatement"
        Me.Text = "تعریف صورت وضعیت"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConStatusStatementTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarikhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmb_sheet As VB_Component.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_code As VB_Component.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_unit As VB_Component.ComboBox
    Friend WithEvents cmb_title As VB_Component.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_period As VB_Component.ComboBox
    Friend WithEvents cmb_price As VB_Component.ComboBox
    Friend WithEvents cmb_amount As VB_Component.ComboBox
    Friend WithEvents cmb_voltage As VB_Component.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_vahed As VB_Component.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_unit As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cmb_Contract As VB_Component.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_IsStarred As VB_Component.ComboBox
    Friend WithEvents cmb_type As VB_Component.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PmConStatusStatementTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_StatusStatementTypeTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementTypeTableAdapter
End Class
