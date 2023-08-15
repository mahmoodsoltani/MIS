<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Post
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
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامپستDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تجهیزDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تیپDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سطحولتاژDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سالبهرهبرداریDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ترانسفورماتورDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اتوماسیونDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.رلهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ظرفیتMVADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ظرفیتتعدادDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامکاملDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmPostTipDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmPostModelDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsMissionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.نوعپستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmPostTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.txt_Name = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Code = New CS_Component.TextBox
        Me.PmPostmodelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.PmPostTipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_Transformator = New CS_Component.TextBox
        Me.txt_SaleBahrebardari = New CS_Component.TextBox
        Me.txt_Rele = New CS_Component.TextBox
        Me.txt_SathVoltaj = New CS_Component.TextBox
        Me.txt_Otomasion = New CS_Component.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_ZMVA = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_ZCount = New CS_Component.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Pm_PostTipTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTipTableAdapter
        Me.Pm_PostmodelTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostmodelTableAdapter
        Me.lkb_Tajhiz = New VB_Component.ComboBox
        Me.lkb_Tip = New VB_Component.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_Report = New CS_Component.Btn
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Chk_IsMission = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lkb_Type = New VB_Component.ComboBox
        Me.PmPostTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_PostTypeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
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
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostmodelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostTipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(489, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        Me.btn_Delete.TabIndex = 1
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(736, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(613, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.TabIndex = 0
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 37)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(860, 261)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.Chk_IsMission)
        Me.gbx_Controls.Controls.Add(Me.lkb_Tip)
        Me.gbx_Controls.Controls.Add(Me.lkb_Type)
        Me.gbx_Controls.Controls.Add(Me.lkb_Tajhiz)
        Me.gbx_Controls.Controls.Add(Me.Label13)
        Me.gbx_Controls.Controls.Add(Me.Label8)
        Me.gbx_Controls.Controls.Add(Me.Label12)
        Me.gbx_Controls.Controls.Add(Me.Label11)
        Me.gbx_Controls.Controls.Add(Me.Label10)
        Me.gbx_Controls.Controls.Add(Me.Label7)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.txt_ZCount)
        Me.gbx_Controls.Controls.Add(Me.txt_ZMVA)
        Me.gbx_Controls.Controls.Add(Me.txt_Code)
        Me.gbx_Controls.Controls.Add(Me.txt_SathVoltaj)
        Me.gbx_Controls.Controls.Add(Me.txt_Otomasion)
        Me.gbx_Controls.Controls.Add(Me.txt_SaleBahrebardari)
        Me.gbx_Controls.Controls.Add(Me.txt_Rele)
        Me.gbx_Controls.Controls.Add(Me.txt_Transformator)
        Me.gbx_Controls.Controls.Add(Me.txt_Name)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 354)
        Me.gbx_Controls.Size = New System.Drawing.Size(860, 185)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Controls.Add(Me.Panel1)
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 295)
        Me.gbx_Btn.Size = New System.Drawing.Size(860, 57)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Panel1, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_new, 0)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn1, Me.کدDataGridViewTextBoxColumn1, Me.نامپستDataGridViewTextBoxColumn1, Me.تجهیزDataGridViewTextBoxColumn1, Me.تیپDataGridViewTextBoxColumn1, Me.سطحولتاژDataGridViewTextBoxColumn1, Me.سالبهرهبرداریDataGridViewTextBoxColumn1, Me.ترانسفورماتورDataGridViewTextBoxColumn1, Me.اتوماسیونDataGridViewTextBoxColumn1, Me.رلهDataGridViewTextBoxColumn1, Me.ظرفیتMVADataGridViewTextBoxColumn1, Me.ظرفیتتعدادDataGridViewTextBoxColumn1, Me.نامکاملDataGridViewTextBoxColumn1, Me.SrlPmPostTipDataGridViewTextBoxColumn1, Me.SrlPmPostModelDataGridViewTextBoxColumn1, Me.IsMissionDataGridViewCheckBoxColumn, Me.نوعپستDataGridViewTextBoxColumn, Me.SrlPmPostTypeDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmPostBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 21)
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
        Me.DataGridView1.Size = New System.Drawing.Size(854, 237)
        Me.DataGridView1.TabIndex = 1
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'کدDataGridViewTextBoxColumn1
        '
        Me.کدDataGridViewTextBoxColumn1.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn1.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn1.Name = "کدDataGridViewTextBoxColumn1"
        Me.کدDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامپستDataGridViewTextBoxColumn1
        '
        Me.نامپستDataGridViewTextBoxColumn1.DataPropertyName = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn1.HeaderText = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn1.Name = "نامپستDataGridViewTextBoxColumn1"
        Me.نامپستDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'تجهیزDataGridViewTextBoxColumn1
        '
        Me.تجهیزDataGridViewTextBoxColumn1.DataPropertyName = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn1.HeaderText = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn1.Name = "تجهیزDataGridViewTextBoxColumn1"
        Me.تجهیزDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'تیپDataGridViewTextBoxColumn1
        '
        Me.تیپDataGridViewTextBoxColumn1.DataPropertyName = "تیپ"
        Me.تیپDataGridViewTextBoxColumn1.HeaderText = "تیپ"
        Me.تیپDataGridViewTextBoxColumn1.Name = "تیپDataGridViewTextBoxColumn1"
        Me.تیپDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'سطحولتاژDataGridViewTextBoxColumn1
        '
        Me.سطحولتاژDataGridViewTextBoxColumn1.DataPropertyName = "سطح ولتاژ"
        Me.سطحولتاژDataGridViewTextBoxColumn1.HeaderText = "سطح ولتاژ"
        Me.سطحولتاژDataGridViewTextBoxColumn1.Name = "سطحولتاژDataGridViewTextBoxColumn1"
        Me.سطحولتاژDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'سالبهرهبرداریDataGridViewTextBoxColumn1
        '
        Me.سالبهرهبرداریDataGridViewTextBoxColumn1.DataPropertyName = "سال بهره برداری"
        Me.سالبهرهبرداریDataGridViewTextBoxColumn1.HeaderText = "سال بهره برداری"
        Me.سالبهرهبرداریDataGridViewTextBoxColumn1.Name = "سالبهرهبرداریDataGridViewTextBoxColumn1"
        Me.سالبهرهبرداریDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ترانسفورماتورDataGridViewTextBoxColumn1
        '
        Me.ترانسفورماتورDataGridViewTextBoxColumn1.DataPropertyName = "ترانسفورماتور"
        Me.ترانسفورماتورDataGridViewTextBoxColumn1.HeaderText = "ترانسفورماتور"
        Me.ترانسفورماتورDataGridViewTextBoxColumn1.Name = "ترانسفورماتورDataGridViewTextBoxColumn1"
        Me.ترانسفورماتورDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'اتوماسیونDataGridViewTextBoxColumn1
        '
        Me.اتوماسیونDataGridViewTextBoxColumn1.DataPropertyName = "اتوماسیون"
        Me.اتوماسیونDataGridViewTextBoxColumn1.HeaderText = "اتوماسیون"
        Me.اتوماسیونDataGridViewTextBoxColumn1.Name = "اتوماسیونDataGridViewTextBoxColumn1"
        Me.اتوماسیونDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'رلهDataGridViewTextBoxColumn1
        '
        Me.رلهDataGridViewTextBoxColumn1.DataPropertyName = "رله"
        Me.رلهDataGridViewTextBoxColumn1.HeaderText = "رله"
        Me.رلهDataGridViewTextBoxColumn1.Name = "رلهDataGridViewTextBoxColumn1"
        Me.رلهDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ظرفیتMVADataGridViewTextBoxColumn1
        '
        Me.ظرفیتMVADataGridViewTextBoxColumn1.DataPropertyName = "ظرفیت-MVA"
        Me.ظرفیتMVADataGridViewTextBoxColumn1.HeaderText = "ظرفیت-MVA"
        Me.ظرفیتMVADataGridViewTextBoxColumn1.Name = "ظرفیتMVADataGridViewTextBoxColumn1"
        Me.ظرفیتMVADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ظرفیتتعدادDataGridViewTextBoxColumn1
        '
        Me.ظرفیتتعدادDataGridViewTextBoxColumn1.DataPropertyName = "ظرفیت-تعداد"
        Me.ظرفیتتعدادDataGridViewTextBoxColumn1.HeaderText = "ظرفیت-تعداد"
        Me.ظرفیتتعدادDataGridViewTextBoxColumn1.Name = "ظرفیتتعدادDataGridViewTextBoxColumn1"
        Me.ظرفیتتعدادDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامکاملDataGridViewTextBoxColumn1
        '
        Me.نامکاملDataGridViewTextBoxColumn1.DataPropertyName = "نام کامل"
        Me.نامکاملDataGridViewTextBoxColumn1.HeaderText = "نام کامل"
        Me.نامکاملDataGridViewTextBoxColumn1.Name = "نامکاملDataGridViewTextBoxColumn1"
        Me.نامکاملDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SrlPmPostTipDataGridViewTextBoxColumn1
        '
        Me.SrlPmPostTipDataGridViewTextBoxColumn1.DataPropertyName = "Srl_Pm_PostTip"
        Me.SrlPmPostTipDataGridViewTextBoxColumn1.HeaderText = "Srl_Pm_PostTip"
        Me.SrlPmPostTipDataGridViewTextBoxColumn1.Name = "SrlPmPostTipDataGridViewTextBoxColumn1"
        Me.SrlPmPostTipDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SrlPmPostTipDataGridViewTextBoxColumn1.Visible = False
        '
        'SrlPmPostModelDataGridViewTextBoxColumn1
        '
        Me.SrlPmPostModelDataGridViewTextBoxColumn1.DataPropertyName = "Srl_Pm_PostModel"
        Me.SrlPmPostModelDataGridViewTextBoxColumn1.HeaderText = "Srl_Pm_PostModel"
        Me.SrlPmPostModelDataGridViewTextBoxColumn1.Name = "SrlPmPostModelDataGridViewTextBoxColumn1"
        Me.SrlPmPostModelDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SrlPmPostModelDataGridViewTextBoxColumn1.Visible = False
        '
        'IsMissionDataGridViewCheckBoxColumn
        '
        Me.IsMissionDataGridViewCheckBoxColumn.DataPropertyName = "IsMission"
        Me.IsMissionDataGridViewCheckBoxColumn.HeaderText = "IsMission"
        Me.IsMissionDataGridViewCheckBoxColumn.Name = "IsMissionDataGridViewCheckBoxColumn"
        Me.IsMissionDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'نوعپستDataGridViewTextBoxColumn
        '
        Me.نوعپستDataGridViewTextBoxColumn.DataPropertyName = "نوع پست"
        Me.نوعپستDataGridViewTextBoxColumn.HeaderText = "نوع پست"
        Me.نوعپستDataGridViewTextBoxColumn.Name = "نوعپستDataGridViewTextBoxColumn"
        Me.نوعپستDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SrlPmPostTypeDataGridViewTextBoxColumn
        '
        Me.SrlPmPostTypeDataGridViewTextBoxColumn.DataPropertyName = "Srl_Pm_PostType"
        Me.SrlPmPostTypeDataGridViewTextBoxColumn.HeaderText = "Srl_Pm_PostType"
        Me.SrlPmPostTypeDataGridViewTextBoxColumn.Name = "SrlPmPostTypeDataGridViewTextBoxColumn"
        Me.SrlPmPostTypeDataGridViewTextBoxColumn.ReadOnly = True
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
        'txt_Name
        '
        Me.txt_Name.CheckExistValueInDb = False
        Me.txt_Name.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Name.CurrencyUnit = "ریال"
        Me.txt_Name.DefaultValue = ""
        Me.txt_Name.FillWithMaxInDb = False
        Me.txt_Name.IsRequired = False
        Me.txt_Name.Location = New System.Drawing.Point(465, 22)
        Me.txt_Name.MaxDecimalLength = 2
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Name.Size = New System.Drawing.Size(316, 25)
        Me.txt_Name.SpellControl = Nothing
        Me.txt_Name.TabIndex = 0
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
        Me.Label1.Location = New System.Drawing.Point(785, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "نام پست"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "کد"
        '
        'txt_Code
        '
        Me.txt_Code.CheckExistValueInDb = False
        Me.txt_Code.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Code.CurrencyUnit = "ریال"
        Me.txt_Code.DefaultValue = ""
        Me.txt_Code.Enabled = False
        Me.txt_Code.FillWithMaxInDb = False
        Me.txt_Code.IsRequired = True
        Me.txt_Code.Location = New System.Drawing.Point(275, 25)
        Me.txt_Code.MaxDecimalLength = 2
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Code.Size = New System.Drawing.Size(90, 25)
        Me.txt_Code.SpellControl = Nothing
        Me.txt_Code.TabIndex = 1
        Me.txt_Code.Tag = "Code"
        Me.txt_Code.Text = "0"
        Me.txt_Code.Title = Nothing
        Me.txt_Code.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Code.UseForData = True
        Me.txt_Code.ValidateCheckExistOnEdit = False
        Me.txt_Code.Value = 0
        '
        'PmPostmodelBindingSource
        '
        Me.PmPostmodelBindingSource.DataMember = "Pm_Postmodel"
        Me.PmPostmodelBindingSource.DataSource = Me.Ds_Pm
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(785, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "تیپ"
        '
        'PmPostTipBindingSource
        '
        Me.PmPostTipBindingSource.DataMember = "Pm_PostTip"
        Me.PmPostTipBindingSource.DataSource = Me.Ds_Pm
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(472, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "تجهیز"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(787, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "رله"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(479, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "سال بهره برداری"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "سطح ولتاژ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(179, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "ترانسفورماتور"
        '
        'txt_Transformator
        '
        Me.txt_Transformator.CheckExistValueInDb = False
        Me.txt_Transformator.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Transformator.CurrencyUnit = "ریال"
        Me.txt_Transformator.DefaultValue = ""
        Me.txt_Transformator.FillWithMaxInDb = False
        Me.txt_Transformator.IsRequired = False
        Me.txt_Transformator.Location = New System.Drawing.Point(12, 100)
        Me.txt_Transformator.MaxDecimalLength = 2
        Me.txt_Transformator.Name = "txt_Transformator"
        Me.txt_Transformator.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Transformator.Size = New System.Drawing.Size(161, 25)
        Me.txt_Transformator.SpellControl = Nothing
        Me.txt_Transformator.TabIndex = 6
        Me.txt_Transformator.Tag = "Transformator"
        Me.txt_Transformator.Title = Nothing
        Me.txt_Transformator.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Transformator.UseForData = True
        Me.txt_Transformator.ValidateCheckExistOnEdit = False
        Me.txt_Transformator.Value = ""
        '
        'txt_SaleBahrebardari
        '
        Me.txt_SaleBahrebardari.CheckExistValueInDb = False
        Me.txt_SaleBahrebardari.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SaleBahrebardari.CurrencyUnit = "ریال"
        Me.txt_SaleBahrebardari.DefaultValue = ""
        Me.txt_SaleBahrebardari.FillWithMaxInDb = False
        Me.txt_SaleBahrebardari.IsRequired = False
        Me.txt_SaleBahrebardari.Location = New System.Drawing.Point(364, 101)
        Me.txt_SaleBahrebardari.MaxDecimalLength = 2
        Me.txt_SaleBahrebardari.Name = "txt_SaleBahrebardari"
        Me.txt_SaleBahrebardari.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SaleBahrebardari.Size = New System.Drawing.Size(104, 25)
        Me.txt_SaleBahrebardari.SpellControl = Nothing
        Me.txt_SaleBahrebardari.TabIndex = 5
        Me.txt_SaleBahrebardari.Tag = "SalBahrebardari"
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
        Me.txt_Rele.DefaultValue = ""
        Me.txt_Rele.FillWithMaxInDb = False
        Me.txt_Rele.IsRequired = False
        Me.txt_Rele.Location = New System.Drawing.Point(634, 99)
        Me.txt_Rele.MaxDecimalLength = 2
        Me.txt_Rele.Name = "txt_Rele"
        Me.txt_Rele.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Rele.Size = New System.Drawing.Size(147, 25)
        Me.txt_Rele.SpellControl = Nothing
        Me.txt_Rele.TabIndex = 4
        Me.txt_Rele.Tag = "Rele"
        Me.txt_Rele.Title = Nothing
        Me.txt_Rele.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Rele.UseForData = True
        Me.txt_Rele.ValidateCheckExistOnEdit = False
        Me.txt_Rele.Value = ""
        '
        'txt_SathVoltaj
        '
        Me.txt_SathVoltaj.CheckExistValueInDb = False
        Me.txt_SathVoltaj.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SathVoltaj.CurrencyUnit = "ریال"
        Me.txt_SathVoltaj.DefaultValue = ""
        Me.txt_SathVoltaj.FillWithMaxInDb = False
        Me.txt_SathVoltaj.IsRequired = False
        Me.txt_SathVoltaj.Location = New System.Drawing.Point(364, 132)
        Me.txt_SathVoltaj.MaxDecimalLength = 2
        Me.txt_SathVoltaj.Name = "txt_SathVoltaj"
        Me.txt_SathVoltaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SathVoltaj.Size = New System.Drawing.Size(104, 25)
        Me.txt_SathVoltaj.SpellControl = Nothing
        Me.txt_SathVoltaj.TabIndex = 8
        Me.txt_SathVoltaj.Tag = "SatheVoltaj"
        Me.txt_SathVoltaj.Text = "0"
        Me.txt_SathVoltaj.Title = Nothing
        Me.txt_SathVoltaj.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SathVoltaj.UseForData = True
        Me.txt_SathVoltaj.ValidateCheckExistOnEdit = False
        Me.txt_SathVoltaj.Value = "0"
        '
        'txt_Otomasion
        '
        Me.txt_Otomasion.CheckExistValueInDb = False
        Me.txt_Otomasion.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Otomasion.CurrencyUnit = "ریال"
        Me.txt_Otomasion.DefaultValue = ""
        Me.txt_Otomasion.FillWithMaxInDb = False
        Me.txt_Otomasion.IsRequired = False
        Me.txt_Otomasion.Location = New System.Drawing.Point(634, 130)
        Me.txt_Otomasion.MaxDecimalLength = 2
        Me.txt_Otomasion.Name = "txt_Otomasion"
        Me.txt_Otomasion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Otomasion.Size = New System.Drawing.Size(147, 25)
        Me.txt_Otomasion.SpellControl = Nothing
        Me.txt_Otomasion.TabIndex = 7
        Me.txt_Otomasion.Tag = "Automasion"
        Me.txt_Otomasion.Title = Nothing
        Me.txt_Otomasion.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Otomasion.UseForData = True
        Me.txt_Otomasion.ValidateCheckExistOnEdit = False
        Me.txt_Otomasion.Value = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(788, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "اتوماسیون"
        '
        'txt_ZMVA
        '
        Me.txt_ZMVA.CheckExistValueInDb = False
        Me.txt_ZMVA.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ZMVA.CurrencyUnit = "ریال"
        Me.txt_ZMVA.DefaultValue = ""
        Me.txt_ZMVA.FillWithMaxInDb = False
        Me.txt_ZMVA.IsRequired = False
        Me.txt_ZMVA.Location = New System.Drawing.Point(121, 132)
        Me.txt_ZMVA.MaxDecimalLength = 2
        Me.txt_ZMVA.Name = "txt_ZMVA"
        Me.txt_ZMVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ZMVA.Size = New System.Drawing.Size(52, 25)
        Me.txt_ZMVA.SpellControl = Nothing
        Me.txt_ZMVA.TabIndex = 9
        Me.txt_ZMVA.Tag = "Zarfiyat_MVA"
        Me.txt_ZMVA.Text = "0"
        Me.txt_ZMVA.Title = Nothing
        Me.txt_ZMVA.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ZMVA.UseForData = True
        Me.txt_ZMVA.ValidateCheckExistOnEdit = False
        Me.txt_ZMVA.Value = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(237, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "ظرفیت:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(179, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 18)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "MVA"
        '
        'txt_ZCount
        '
        Me.txt_ZCount.CheckExistValueInDb = False
        Me.txt_ZCount.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ZCount.CurrencyUnit = "ریال"
        Me.txt_ZCount.DefaultValue = ""
        Me.txt_ZCount.FillWithMaxInDb = False
        Me.txt_ZCount.IsRequired = False
        Me.txt_ZCount.Location = New System.Drawing.Point(11, 132)
        Me.txt_ZCount.MaxDecimalLength = 2
        Me.txt_ZCount.Name = "txt_ZCount"
        Me.txt_ZCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ZCount.Size = New System.Drawing.Size(52, 25)
        Me.txt_ZCount.SpellControl = Nothing
        Me.txt_ZCount.TabIndex = 10
        Me.txt_ZCount.Tag = "Zarfiyat_Count"
        Me.txt_ZCount.Text = "0"
        Me.txt_ZCount.Title = Nothing
        Me.txt_ZCount.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ZCount.UseForData = True
        Me.txt_ZCount.ValidateCheckExistOnEdit = False
        Me.txt_ZCount.Value = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 18)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "تعداد"
        '
        'Pm_PostTipTableAdapter
        '
        Me.Pm_PostTipTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostmodelTableAdapter
        '
        Me.Pm_PostmodelTableAdapter.ClearBeforeFill = True
        '
        'lkb_Tajhiz
        '
        Me.lkb_Tajhiz.AllowDrop = True
        Me.lkb_Tajhiz.AutoComplete = True
        Me.lkb_Tajhiz.DataSource = Me.PmPostmodelBindingSource
        Me.lkb_Tajhiz.DisplayMember = "تجهیز"
        Me.lkb_Tajhiz.EnterStop = True
        Me.lkb_Tajhiz.FormattingEnabled = True
        Me.lkb_Tajhiz.IsRequired = False
        Me.lkb_Tajhiz.LimitedToList = False
        Me.lkb_Tajhiz.Location = New System.Drawing.Point(275, 69)
        Me.lkb_Tajhiz.Name = "lkb_Tajhiz"
        Me.lkb_Tajhiz.OpenOnFoucus = False
        Me.lkb_Tajhiz.Size = New System.Drawing.Size(193, 26)
        Me.lkb_Tajhiz.TabIndex = 3
        Me.lkb_Tajhiz.ValueMember = "Srl"
        '
        'lkb_Tip
        '
        Me.lkb_Tip.AllowDrop = True
        Me.lkb_Tip.AutoComplete = True
        Me.lkb_Tip.DataSource = Me.PmPostTipBindingSource
        Me.lkb_Tip.DisplayMember = "نام تیپ"
        Me.lkb_Tip.EnterStop = True
        Me.lkb_Tip.FormattingEnabled = True
        Me.lkb_Tip.IsRequired = False
        Me.lkb_Tip.LimitedToList = False
        Me.lkb_Tip.Location = New System.Drawing.Point(593, 61)
        Me.lkb_Tip.Name = "lkb_Tip"
        Me.lkb_Tip.OpenOnFoucus = False
        Me.lkb_Tip.Size = New System.Drawing.Size(188, 26)
        Me.lkb_Tip.TabIndex = 2
        Me.lkb_Tip.ValueMember = "Srl"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_Report)
        Me.Panel1.Location = New System.Drawing.Point(366, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(117, 41)
        Me.Panel1.TabIndex = 2
        '
        'Btn_Report
        '
        Me.Btn_Report.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Report.HeaderText = "گزارش"
        Me.Btn_Report.Location = New System.Drawing.Point(11, 6)
        Me.Btn_Report.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Report.Name = "Btn_Report"
        Me.Btn_Report.Size = New System.Drawing.Size(102, 31)
        Me.Btn_Report.TabIndex = 0
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Chk_IsMission
        '
        Me.Chk_IsMission.AutoSize = True
        Me.Chk_IsMission.Location = New System.Drawing.Point(159, 25)
        Me.Chk_IsMission.Name = "Chk_IsMission"
        Me.Chk_IsMission.Size = New System.Drawing.Size(83, 22)
        Me.Chk_IsMission.TabIndex = 11
        Me.Chk_IsMission.Text = "ماموریتی"
        Me.Chk_IsMission.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(179, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 18)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "نوع"
        '
        'lkb_Type
        '
        Me.lkb_Type.AllowDrop = True
        Me.lkb_Type.AutoComplete = True
        Me.lkb_Type.DataSource = Me.PmPostTypeBindingSource
        Me.lkb_Type.DisplayMember = "نوع پست"
        Me.lkb_Type.EnterStop = True
        Me.lkb_Type.FormattingEnabled = True
        Me.lkb_Type.IsRequired = False
        Me.lkb_Type.LimitedToList = False
        Me.lkb_Type.Location = New System.Drawing.Point(12, 68)
        Me.lkb_Type.Name = "lkb_Type"
        Me.lkb_Type.OpenOnFoucus = False
        Me.lkb_Type.Size = New System.Drawing.Size(161, 26)
        Me.lkb_Type.TabIndex = 3
        Me.lkb_Type.ValueMember = "Srl"
        '
        'PmPostTypeBindingSource
        '
        Me.PmPostTypeBindingSource.DataMember = "Pm_PostType"
        Me.PmPostTypeBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_PostTypeTableAdapter
        '
        Me.Pm_PostTypeTableAdapter.ClearBeforeFill = True
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
        'Frm_Post
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(887, 575)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Post"
        Me.TableName = "Pm_Post"
        Me.Text = "تعریف پست"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostmodelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostTipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents txt_Code As CS_Component.TextBox
    Friend WithEvents txt_Name As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostTipBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTipTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTipTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PmPostmodelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostmodelTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostmodelTableAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_SathVoltaj As CS_Component.TextBox
    Friend WithEvents txt_SaleBahrebardari As CS_Component.TextBox
    Friend WithEvents txt_Rele As CS_Component.TextBox
    Friend WithEvents txt_Transformator As CS_Component.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Otomasion As CS_Component.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_ZCount As CS_Component.TextBox
    Friend WithEvents txt_ZMVA As CS_Component.TextBox
    Friend WithEvents lkb_Tip As VB_Component.ComboBox
    Friend WithEvents lkb_Tajhiz As VB_Component.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents Btn_Report As CS_Component.Btn
    Friend WithEvents Chk_IsMission As System.Windows.Forms.CheckBox
    Friend WithEvents lkb_Type As VB_Component.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PmPostTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTypeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
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
    Friend WithEvents کدDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپستDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تجهیزDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تیپDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سطحولتاژDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سالبهرهبرداریDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ترانسفورماتورDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اتوماسیونDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents رلهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ظرفیتMVADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ظرفیتتعدادDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامکاملDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmPostTipDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmPostModelDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsMissionDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents نوعپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmPostTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
