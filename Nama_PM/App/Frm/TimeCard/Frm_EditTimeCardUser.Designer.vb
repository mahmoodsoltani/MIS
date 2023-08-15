<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EditTimeCardUser
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
        Me.PMPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lb_Name = New System.Windows.Forms.Label
        Me.txt_BeginDate = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_EndDate = New CS_Component.TextBox
        Me.PmHazineCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PM_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmashkhasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدهزینهDataGridViewTextBoxColumn = New VB_Component.ComboBoxColumn
        Me.محلفعالیتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ورودDataGridViewTextBoxColumn = New VB_Component.TimeColumn
        Me.خروجDataGridViewTextBoxColumn = New VB_Component.TimeColumn
        Me.کارکردDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn = New VB_Component.TimeColumn
        Me.مرخصیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ماموریتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاخیرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تعجیلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ورود1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.خروج1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ورود2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.خروج2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.وضعیتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تعطیلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ماموریتفرمکارDataGridViewTextBoxColumn = New VB_Component.TimeColumn
        Me.تعطیل = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmtimeCardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_TimeCard = New Nama_PM.Ds_TimeCard
        Me.PmPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_HazineCodeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
        Me.Pm_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
        Me.lb_Sum = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_ViewSave = New System.Windows.Forms.Button
        Me.lb_IsChanged = New System.Windows.Forms.Label
        Me.RpTimeCardBasedNumberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_TimeCardBasedNumberTableAdapter = New Nama_PM.Ds_TimeCardTableAdapters.Rp_TimeCardBasedNumberTableAdapter
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.Acc_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
        Me.AccAshkhasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_timeCardTableAdapter = New Nama_PM.Ds_TimeCardTableAdapters.Pm_timeCardTableAdapter
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.TimeCardWorkFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeCard_WorkFormTableAdapter = New Nama_PM.Ds_RpTableAdapters.TimeCard_WorkFormTableAdapter
        Me.btn_Save = New System.Windows.Forms.Button
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmtimeCardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_TimeCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RpTimeCardBasedNumberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeCardWorkFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(522, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        Me.btn_Delete.Visible = False
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "F2 ذخيره روز جدید"
        Me.btn_new.Location = New System.Drawing.Point(769, 17)
        Me.btn_new.Size = New System.Drawing.Size(154, 32)
        Me.btn_new.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(646, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.txt_EndDate)
        Me.gbx_GridViewList.Controls.Add(Me.txt_BeginDate)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Controls.Add(Me.lb_IsChanged)
        Me.gbx_GridViewList.Controls.Add(Me.Label7)
        Me.gbx_GridViewList.Controls.Add(Me.Label5)
        Me.gbx_GridViewList.Controls.Add(Me.lb_Name)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 60)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(929, 579)
        Me.gbx_GridViewList.TabIndex = 0
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.lb_Sum)
        Me.gbx_Controls.Controls.Add(Me.btn_Save)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 637)
        Me.gbx_Controls.Size = New System.Drawing.Size(929, 57)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Controls.Add(Me.Panel1)
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 424)
        Me.gbx_Btn.Size = New System.Drawing.Size(929, 57)
        Me.gbx_Btn.Visible = False
        Me.gbx_Btn.Controls.SetChildIndex(Me.Panel1, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_new, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Cancel, 0)
        '
        'PMPostBindingSource
        '
        Me.PMPostBindingSource.DataMember = "PM_Post"
        Me.PMPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmAshkhasBindingSource
        '
        Me.PmAshkhasBindingSource.DataMember = "Pm_Ashkhas"
        '
        'lb_Name
        '
        Me.lb_Name.Location = New System.Drawing.Point(624, 30)
        Me.lb_Name.Name = "lb_Name"
        Me.lb_Name.Size = New System.Drawing.Size(299, 18)
        Me.lb_Name.TabIndex = 3
        Me.lb_Name.Text = "نام"
        '
        'txt_BeginDate
        '
        Me.txt_BeginDate.CheckExistValueInDb = False
        Me.txt_BeginDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BeginDate.CurrencyUnit = "ریال"
        Me.txt_BeginDate.DefaultValue = ""
        Me.txt_BeginDate.Enabled = False
        Me.txt_BeginDate.FillWithMaxInDb = False
        Me.txt_BeginDate.IsRequired = True
        Me.txt_BeginDate.Location = New System.Drawing.Point(375, 26)
        Me.txt_BeginDate.MaxDecimalLength = 2
        Me.txt_BeginDate.Name = "txt_BeginDate"
        Me.txt_BeginDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_BeginDate.Size = New System.Drawing.Size(135, 25)
        Me.txt_BeginDate.SpellControl = Nothing
        Me.txt_BeginDate.TabIndex = 4
        Me.txt_BeginDate.TabStop = False
        Me.txt_BeginDate.Tag = ""
        Me.txt_BeginDate.Title = Nothing
        Me.txt_BeginDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_BeginDate.UseForData = True
        Me.txt_BeginDate.ValidateCheckExistOnEdit = False
        Me.txt_BeginDate.Value = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(516, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "از تاریخ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "تا"
        '
        'txt_EndDate
        '
        Me.txt_EndDate.CheckExistValueInDb = False
        Me.txt_EndDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EndDate.CurrencyUnit = "ریال"
        Me.txt_EndDate.DefaultValue = ""
        Me.txt_EndDate.Enabled = False
        Me.txt_EndDate.FillWithMaxInDb = False
        Me.txt_EndDate.IsRequired = True
        Me.txt_EndDate.Location = New System.Drawing.Point(222, 26)
        Me.txt_EndDate.MaxDecimalLength = 2
        Me.txt_EndDate.Name = "txt_EndDate"
        Me.txt_EndDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_EndDate.Size = New System.Drawing.Size(135, 25)
        Me.txt_EndDate.SpellControl = Nothing
        Me.txt_EndDate.TabIndex = 5
        Me.txt_EndDate.TabStop = False
        Me.txt_EndDate.Tag = ""
        Me.txt_EndDate.Title = Nothing
        Me.txt_EndDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_EndDate.UseForData = True
        Me.txt_EndDate.ValidateCheckExistOnEdit = False
        Me.txt_EndDate.Value = ""
        '
        'PmHazineCodeBindingSource
        '
        Me.PmHazineCodeBindingSource.DataMember = "Pm_HazineCode"
        Me.PmHazineCodeBindingSource.DataSource = Me.Ds_Pm
        '
        'PM_PostTableAdapter
        '
        Me.PM_PostTableAdapter.ClearBeforeFill = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.SrlPmashkhasDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.کدهزینهDataGridViewTextBoxColumn, Me.محلفعالیتDataGridViewTextBoxColumn, Me.ورودDataGridViewTextBoxColumn, Me.خروجDataGridViewTextBoxColumn, Me.کارکردDataGridViewTextBoxColumn, Me.اضافهکاراولوقتDataGridViewTextBoxColumn, Me.اضافهکارآخروقتDataGridViewTextBoxColumn, Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn, Me.مرخصیDataGridViewTextBoxColumn, Me.ماموریتDataGridViewTextBoxColumn, Me.تاخیرDataGridViewTextBoxColumn, Me.تعجیلDataGridViewTextBoxColumn, Me.ورود1DataGridViewTextBoxColumn, Me.خروج1DataGridViewTextBoxColumn, Me.ورود2DataGridViewTextBoxColumn, Me.خروج2DataGridViewTextBoxColumn, Me.وضعیتDataGridViewTextBoxColumn, Me.تعطیلDataGridViewTextBoxColumn, Me.ماموریتفرمکارDataGridViewTextBoxColumn, Me.تعطیل})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmtimeCardBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 77)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(923, 499)
        Me.DataGridView1.TabIndex = 6
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'SrlPmashkhasDataGridViewTextBoxColumn
        '
        Me.SrlPmashkhasDataGridViewTextBoxColumn.DataPropertyName = "Srl_Pm_ashkhas"
        Me.SrlPmashkhasDataGridViewTextBoxColumn.HeaderText = "Srl_Pm_ashkhas"
        Me.SrlPmashkhasDataGridViewTextBoxColumn.Name = "SrlPmashkhasDataGridViewTextBoxColumn"
        Me.SrlPmashkhasDataGridViewTextBoxColumn.Visible = False
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'کدهزینهDataGridViewTextBoxColumn
        '
        Me.کدهزینهDataGridViewTextBoxColumn.DataPropertyName = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.DataSource = Me.PmHazineCodeBindingSource
        Me.کدهزینهDataGridViewTextBoxColumn.DisplayMember = "کد"
        Me.کدهزینهDataGridViewTextBoxColumn.HeaderText = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.Name = "کدهزینهDataGridViewTextBoxColumn"
        Me.کدهزینهDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.کدهزینهDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.کدهزینهDataGridViewTextBoxColumn.ValueMember = "کد"
        Me.کدهزینهDataGridViewTextBoxColumn.Width = 120
        '
        'محلفعالیتDataGridViewTextBoxColumn
        '
        Me.محلفعالیتDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.محلفعالیتDataGridViewTextBoxColumn.DataPropertyName = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.HeaderText = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.Name = "محلفعالیتDataGridViewTextBoxColumn"
        Me.محلفعالیتDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ورودDataGridViewTextBoxColumn
        '
        Me.ورودDataGridViewTextBoxColumn.DataPropertyName = "ورود"
        Me.ورودDataGridViewTextBoxColumn.HeaderText = "ورود"
        Me.ورودDataGridViewTextBoxColumn.Name = "ورودDataGridViewTextBoxColumn"
        Me.ورودDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ورودDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'خروجDataGridViewTextBoxColumn
        '
        Me.خروجDataGridViewTextBoxColumn.DataPropertyName = "خروج"
        Me.خروجDataGridViewTextBoxColumn.HeaderText = "خروج"
        Me.خروجDataGridViewTextBoxColumn.Name = "خروجDataGridViewTextBoxColumn"
        Me.خروجDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.خروجDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'کارکردDataGridViewTextBoxColumn
        '
        Me.کارکردDataGridViewTextBoxColumn.DataPropertyName = "کارکرد"
        Me.کارکردDataGridViewTextBoxColumn.HeaderText = "کارکرد"
        Me.کارکردDataGridViewTextBoxColumn.Name = "کارکردDataGridViewTextBoxColumn"
        Me.کارکردDataGridViewTextBoxColumn.Visible = False
        '
        'اضافهکاراولوقتDataGridViewTextBoxColumn
        '
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار اول وقت"
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn.HeaderText = "اضافه کار اول وقت"
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn.Name = "اضافهکاراولوقتDataGridViewTextBoxColumn"
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn.Visible = False
        '
        'اضافهکارآخروقتDataGridViewTextBoxColumn
        '
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار آخر وقت"
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn.HeaderText = "اضافه کار آخر وقت"
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn.Name = "اضافهکارآخروقتDataGridViewTextBoxColumn"
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn.Visible = False
        '
        'اضافهکارروزتعطیلDataGridViewTextBoxColumn
        '
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار روز تعطیل"
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.HeaderText = "اضافه کار"
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.Name = "اضافهکارروزتعطیلDataGridViewTextBoxColumn"
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'مرخصیDataGridViewTextBoxColumn
        '
        Me.مرخصیDataGridViewTextBoxColumn.DataPropertyName = "مرخصی"
        Me.مرخصیDataGridViewTextBoxColumn.HeaderText = "مرخصی"
        Me.مرخصیDataGridViewTextBoxColumn.Name = "مرخصیDataGridViewTextBoxColumn"
        Me.مرخصیDataGridViewTextBoxColumn.Visible = False
        '
        'ماموریتDataGridViewTextBoxColumn
        '
        Me.ماموریتDataGridViewTextBoxColumn.DataPropertyName = "ماموریت"
        Me.ماموریتDataGridViewTextBoxColumn.HeaderText = "ماموریت"
        Me.ماموریتDataGridViewTextBoxColumn.Name = "ماموریتDataGridViewTextBoxColumn"
        Me.ماموریتDataGridViewTextBoxColumn.Visible = False
        '
        'تاخیرDataGridViewTextBoxColumn
        '
        Me.تاخیرDataGridViewTextBoxColumn.DataPropertyName = "تاخیر"
        Me.تاخیرDataGridViewTextBoxColumn.HeaderText = "تاخیر"
        Me.تاخیرDataGridViewTextBoxColumn.Name = "تاخیرDataGridViewTextBoxColumn"
        Me.تاخیرDataGridViewTextBoxColumn.Visible = False
        '
        'تعجیلDataGridViewTextBoxColumn
        '
        Me.تعجیلDataGridViewTextBoxColumn.DataPropertyName = "تعجیل"
        Me.تعجیلDataGridViewTextBoxColumn.HeaderText = "تعجیل"
        Me.تعجیلDataGridViewTextBoxColumn.Name = "تعجیلDataGridViewTextBoxColumn"
        Me.تعجیلDataGridViewTextBoxColumn.Visible = False
        '
        'ورود1DataGridViewTextBoxColumn
        '
        Me.ورود1DataGridViewTextBoxColumn.DataPropertyName = "ورود1"
        Me.ورود1DataGridViewTextBoxColumn.HeaderText = "ورود1"
        Me.ورود1DataGridViewTextBoxColumn.Name = "ورود1DataGridViewTextBoxColumn"
        Me.ورود1DataGridViewTextBoxColumn.Visible = False
        '
        'خروج1DataGridViewTextBoxColumn
        '
        Me.خروج1DataGridViewTextBoxColumn.DataPropertyName = "خروج1"
        Me.خروج1DataGridViewTextBoxColumn.HeaderText = "خروج1"
        Me.خروج1DataGridViewTextBoxColumn.Name = "خروج1DataGridViewTextBoxColumn"
        Me.خروج1DataGridViewTextBoxColumn.Visible = False
        '
        'ورود2DataGridViewTextBoxColumn
        '
        Me.ورود2DataGridViewTextBoxColumn.DataPropertyName = "ورود2"
        Me.ورود2DataGridViewTextBoxColumn.HeaderText = "ورود2"
        Me.ورود2DataGridViewTextBoxColumn.Name = "ورود2DataGridViewTextBoxColumn"
        Me.ورود2DataGridViewTextBoxColumn.Visible = False
        '
        'خروج2DataGridViewTextBoxColumn
        '
        Me.خروج2DataGridViewTextBoxColumn.DataPropertyName = "خروج2"
        Me.خروج2DataGridViewTextBoxColumn.HeaderText = "خروج2"
        Me.خروج2DataGridViewTextBoxColumn.Name = "خروج2DataGridViewTextBoxColumn"
        Me.خروج2DataGridViewTextBoxColumn.Visible = False
        '
        'وضعیتDataGridViewTextBoxColumn
        '
        Me.وضعیتDataGridViewTextBoxColumn.DataPropertyName = "وضعیت"
        Me.وضعیتDataGridViewTextBoxColumn.HeaderText = "وضعیت"
        Me.وضعیتDataGridViewTextBoxColumn.Name = "وضعیتDataGridViewTextBoxColumn"
        Me.وضعیتDataGridViewTextBoxColumn.Visible = False
        '
        'تعطیلDataGridViewTextBoxColumn
        '
        Me.تعطیلDataGridViewTextBoxColumn.DataPropertyName = "تعطیل"
        Me.تعطیلDataGridViewTextBoxColumn.HeaderText = "تعطیل"
        Me.تعطیلDataGridViewTextBoxColumn.Name = "تعطیلDataGridViewTextBoxColumn"
        Me.تعطیلDataGridViewTextBoxColumn.ReadOnly = True
        Me.تعطیلDataGridViewTextBoxColumn.Visible = False
        '
        'ماموریتفرمکارDataGridViewTextBoxColumn
        '
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.DataPropertyName = "ماموریت فرم کار"
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.HeaderText = "ماموریت"
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.Name = "ماموریتفرمکارDataGridViewTextBoxColumn"
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'تعطیل
        '
        Me.تعطیل.DataPropertyName = "تعطیل"
        Me.تعطیل.HeaderText = "ت"
        Me.تعطیل.Name = "تعطیل"
        Me.تعطیل.ReadOnly = True
        Me.تعطیل.Width = 30
        '
        'PmtimeCardBindingSource
        '
        Me.PmtimeCardBindingSource.DataMember = "Pm_timeCard"
        Me.PmtimeCardBindingSource.DataSource = Me.Ds_TimeCard
        '
        'Ds_TimeCard
        '
        Me.Ds_TimeCard.DataSetName = "Ds_TimeCard"
        Me.Ds_TimeCard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmPostBindingSource1
        '
        Me.PmPostBindingSource1.DataMember = "Pm_Post"
        Me.PmPostBindingSource1.DataSource = Me.Ds_Pm
        '
        'Pm_HazineCodeTableAdapter
        '
        Me.Pm_HazineCodeTableAdapter.ClearBeforeFill = True
        '
        'Pm_AshkhasTableAdapter
        '
        Me.Pm_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'lb_Sum
        '
        Me.lb_Sum.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lb_Sum.ForeColor = System.Drawing.Color.Green
        Me.lb_Sum.Location = New System.Drawing.Point(147, 21)
        Me.lb_Sum.Name = "lb_Sum"
        Me.lb_Sum.Size = New System.Drawing.Size(71, 30)
        Me.lb_Sum.TabIndex = 3
        Me.lb_Sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Btn_ViewSave)
        Me.Panel1.Location = New System.Drawing.Point(385, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(134, 33)
        Me.Panel1.TabIndex = 4
        Me.Panel1.Visible = False
        '
        'Btn_ViewSave
        '
        Me.Btn_ViewSave.Location = New System.Drawing.Point(3, 3)
        Me.Btn_ViewSave.Name = "Btn_ViewSave"
        Me.Btn_ViewSave.Size = New System.Drawing.Size(127, 30)
        Me.Btn_ViewSave.TabIndex = 0
        Me.Btn_ViewSave.Text = "محاسبه مجدد"
        Me.Btn_ViewSave.UseVisualStyleBackColor = True
        '
        'lb_IsChanged
        '
        Me.lb_IsChanged.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_IsChanged.Location = New System.Drawing.Point(10, 30)
        Me.lb_IsChanged.Name = "lb_IsChanged"
        Me.lb_IsChanged.Size = New System.Drawing.Size(208, 18)
        Me.lb_IsChanged.TabIndex = 3
        '
        'RpTimeCardBasedNumberBindingSource
        '
        Me.RpTimeCardBasedNumberBindingSource.DataMember = "Rp_TimeCardBasedNumber"
        Me.RpTimeCardBasedNumberBindingSource.DataSource = Me.Ds_TimeCard
        '
        'Rp_TimeCardBasedNumberTableAdapter
        '
        Me.Rp_TimeCardBasedNumberTableAdapter.ClearBeforeFill = True
        '
        'AccAshkhasBindingSource
        '
        Me.AccAshkhasBindingSource.DataMember = "Acc_Ashkhas"
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Acc_AshkhasTableAdapter
        '
        Me.Acc_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'AccAshkhasBindingSource1
        '
        Me.AccAshkhasBindingSource1.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource1.DataSource = Me.Ds_Ashkhas
        '
        'Pm_timeCardTableAdapter
        '
        Me.Pm_timeCardTableAdapter.ClearBeforeFill = True
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimeCardWorkFormBindingSource
        '
        Me.TimeCardWorkFormBindingSource.DataMember = "TimeCard_WorkForm"
        Me.TimeCardWorkFormBindingSource.DataSource = Me.Ds_Rp
        '
        'TimeCard_WorkFormTableAdapter
        '
        Me.TimeCard_WorkFormTableAdapter.ClearBeforeFill = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(414, 15)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(101, 36)
        Me.btn_Save.TabIndex = 5
        Me.btn_Save.Text = "ذخیره جدول"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Frm_EditTimeCardUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 726)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_EditTimeCardUser"
        Me.TableName = "Pm_TimeCard"
        Me.Text = "ویرایش اطلاعات تایم کارت"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmtimeCardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_TimeCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RpTimeCardBasedNumberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeCardWorkFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_Name As System.Windows.Forms.Label
    Friend WithEvents txt_BeginDate As CS_Component.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_EndDate As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Ds_TimeCard As Nama_PM.Ds_TimeCard
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents PmHazineCodeBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents اضافهکارآخروقتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TsCol As New VB_Component.TimeColumn
    Friend WithEvents PmAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents lb_Sum As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_ViewSave As System.Windows.Forms.Button
    Friend WithEvents lb_IsChanged As System.Windows.Forms.Label
    Friend WithEvents RpTimeCardBasedNumberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_TimeCardBasedNumberTableAdapter As Nama_PM.Ds_TimeCardTableAdapters.Rp_TimeCardBasedNumberTableAdapter
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents AccAshkhasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PmtimeCardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_timeCardTableAdapter As Nama_PM.Ds_TimeCardTableAdapters.Pm_timeCardTableAdapter
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents TimeCardWorkFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TimeCard_WorkFormTableAdapter As Nama_PM.Ds_RpTableAdapters.TimeCard_WorkFormTableAdapter
    Private WithEvents PM_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Private WithEvents Pm_HazineCodeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
    Friend WithEvents PmPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmashkhasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدهزینهDataGridViewTextBoxColumn As VB_Component.ComboBoxColumn
    Friend WithEvents محلفعالیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ورودDataGridViewTextBoxColumn As VB_Component.TimeColumn
    Friend WithEvents خروجDataGridViewTextBoxColumn As VB_Component.TimeColumn
    Friend WithEvents کارکردDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکاراولوقتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکارآخروقتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکارروزتعطیلDataGridViewTextBoxColumn As VB_Component.TimeColumn
    Friend WithEvents مرخصیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ماموریتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاخیرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعجیلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ورود1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents خروج1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ورود2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents خروج2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents وضعیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعطیلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ماموریتفرمکارDataGridViewTextBoxColumn As VB_Component.TimeColumn
    Friend WithEvents تعطیل As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
