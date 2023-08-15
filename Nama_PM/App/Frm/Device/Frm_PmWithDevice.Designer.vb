<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PmWithDevice
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Description = New CS_Component.TextBox
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخانجامDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.توضیحاتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.دلیلکنسلیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامپستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Srl1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامواحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmPmProgramBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.cmb_cancelCause = New VB_Component.ComboBox
        Me.PmCancelCauseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Tarikh = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_ExecuteDate = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmHadeseKhesaratDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_Hadese_KhesaratDeviceTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
        Me.Pm_CancelCauseTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_CancelCauseTableAdapter
        Me.txt_TajhizName = New CS_Component.TextBox
        Me.btn_SelectDEvice = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Rb_Cancle = New System.Windows.Forms.RadioButton
        Me.Rb_NoExecute = New System.Windows.Forms.RadioButton
        Me.Rb_All = New System.Windows.Forms.RadioButton
        Me.rb_Execute = New System.Windows.Forms.RadioButton
        Me.chk_AllTajhiz = New System.Windows.Forms.CheckBox
        Me.Chk_AllPost = New System.Windows.Forms.CheckBox
        Me.chk_AllExecDate = New System.Windows.Forms.CheckBox
        Me.txt_EndExecDate = New CS_Component.TextBox
        Me.chk_AllPmDate = New System.Windows.Forms.CheckBox
        Me.txt_StartExeDate = New CS_Component.TextBox
        Me.txt_EndPmdate = New CS_Component.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_StartPmDate = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Cmb_Post_ForSave = New VB_Component.ComboBox
        Me.PmPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_SelectTajhiz = New System.Windows.Forms.Button
        Me.txt_TajhizNameForSave = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pm_PmProgramTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PmProgramTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPmProgramBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmCancelCauseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PmPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(623, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(870, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(746, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.GroupBox1)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 33)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(993, 421)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.Cmb_Post_ForSave)
        Me.gbx_Controls.Controls.Add(Me.btn_SelectTajhiz)
        Me.gbx_Controls.Controls.Add(Me.txt_TajhizNameForSave)
        Me.gbx_Controls.Controls.Add(Me.txt_ExecuteDate)
        Me.gbx_Controls.Controls.Add(Me.txt_Tarikh)
        Me.gbx_Controls.Controls.Add(Me.cmb_cancelCause)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.txt_Description)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 522)
        Me.gbx_Controls.Size = New System.Drawing.Size(993, 141)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 460)
        Me.gbx_Btn.Size = New System.Drawing.Size(993, 60)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(626, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "علت کنسلی"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(876, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "تاریخ پیشنهادی"
        '
        'txt_Description
        '
        Me.txt_Description.CheckExistValueInDb = False
        Me.txt_Description.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Description.CurrencyUnit = "ریال"
        Me.txt_Description.DefaultValue = ""
        Me.txt_Description.FillWithMaxInDb = False
        Me.txt_Description.IsRequired = False
        Me.txt_Description.Location = New System.Drawing.Point(268, 54)
        Me.txt_Description.MaxDecimalLength = 2
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Description.Size = New System.Drawing.Size(357, 47)
        Me.txt_Description.SpellControl = Nothing
        Me.txt_Description.TabIndex = 4
        Me.txt_Description.Tag = "Description"
        Me.txt_Description.Title = Nothing
        Me.txt_Description.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Description.UseForData = True
        Me.txt_Description.ValidateCheckExistOnEdit = False
        Me.txt_Description.Value = ""
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.تاریخDataGridViewTextBoxColumn, Me.تاریخانجامDataGridViewTextBoxColumn, Me.توضیحاتDataGridViewTextBoxColumn, Me.دلیلکنسلیDataGridViewTextBoxColumn, Me.نامپستDataGridViewTextBoxColumn, Me.Srl1DataGridViewTextBoxColumn, Me.نامگروهDataGridViewTextBoxColumn, Me.نامواحدDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmPmProgramBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 149)
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
        Me.DataGridView1.Size = New System.Drawing.Size(987, 269)
        Me.DataGridView1.TabIndex = 0
        '
        'SrlDataGridViewTextBoxColumn3
        '
        Me.SrlDataGridViewTextBoxColumn3.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn3.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn3.Name = "SrlDataGridViewTextBoxColumn3"
        Me.SrlDataGridViewTextBoxColumn3.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "نام تحهیز"
        Me.DataGridViewTextBoxColumn1.HeaderText = "نام تحهیز"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        Me.تاریخDataGridViewTextBoxColumn.Width = 90
        '
        'تاریخانجامDataGridViewTextBoxColumn
        '
        Me.تاریخانجامDataGridViewTextBoxColumn.DataPropertyName = "تاریخ انجام"
        Me.تاریخانجامDataGridViewTextBoxColumn.HeaderText = "تاریخ انجام"
        Me.تاریخانجامDataGridViewTextBoxColumn.Name = "تاریخانجامDataGridViewTextBoxColumn"
        Me.تاریخانجامDataGridViewTextBoxColumn.ReadOnly = True
        Me.تاریخانجامDataGridViewTextBoxColumn.Width = 90
        '
        'توضیحاتDataGridViewTextBoxColumn
        '
        Me.توضیحاتDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.توضیحاتDataGridViewTextBoxColumn.DataPropertyName = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.Name = "توضیحاتDataGridViewTextBoxColumn"
        Me.توضیحاتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'دلیلکنسلیDataGridViewTextBoxColumn
        '
        Me.دلیلکنسلیDataGridViewTextBoxColumn.DataPropertyName = "دلیل کنسلی"
        Me.دلیلکنسلیDataGridViewTextBoxColumn.HeaderText = "دلیل کنسلی"
        Me.دلیلکنسلیDataGridViewTextBoxColumn.Name = "دلیلکنسلیDataGridViewTextBoxColumn"
        Me.دلیلکنسلیDataGridViewTextBoxColumn.ReadOnly = True
        Me.دلیلکنسلیDataGridViewTextBoxColumn.Width = 150
        '
        'نامپستDataGridViewTextBoxColumn
        '
        Me.نامپستDataGridViewTextBoxColumn.DataPropertyName = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.HeaderText = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.Name = "نامپستDataGridViewTextBoxColumn"
        Me.نامپستDataGridViewTextBoxColumn.ReadOnly = True
        Me.نامپستDataGridViewTextBoxColumn.Width = 120
        '
        'Srl1DataGridViewTextBoxColumn
        '
        Me.Srl1DataGridViewTextBoxColumn.DataPropertyName = "srl1"
        Me.Srl1DataGridViewTextBoxColumn.HeaderText = "srl1"
        Me.Srl1DataGridViewTextBoxColumn.Name = "Srl1DataGridViewTextBoxColumn"
        Me.Srl1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Srl1DataGridViewTextBoxColumn.Visible = False
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        Me.نامگروهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامواحدDataGridViewTextBoxColumn
        '
        Me.نامواحدDataGridViewTextBoxColumn.DataPropertyName = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.HeaderText = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.Name = "نامواحدDataGridViewTextBoxColumn"
        Me.نامواحدDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmPmProgramBindingSource
        '
        Me.PmPmProgramBindingSource.DataMember = "Pm_PmProgram"
        Me.PmPmProgramBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_cancelCause
        '
        Me.cmb_cancelCause.AllowDrop = True
        Me.cmb_cancelCause.AutoComplete = True
        Me.cmb_cancelCause.DataSource = Me.PmCancelCauseBindingSource
        Me.cmb_cancelCause.DisplayMember = "نام"
        Me.cmb_cancelCause.EnterStop = True
        Me.cmb_cancelCause.FormattingEnabled = True
        Me.cmb_cancelCause.IsRequired = False
        Me.cmb_cancelCause.LimitedToList = False
        Me.cmb_cancelCause.Location = New System.Drawing.Point(356, 107)
        Me.cmb_cancelCause.Name = "cmb_cancelCause"
        Me.cmb_cancelCause.OpenOnFoucus = False
        Me.cmb_cancelCause.Size = New System.Drawing.Size(269, 26)
        Me.cmb_cancelCause.TabIndex = 6
        Me.cmb_cancelCause.Tag = "Srl_Pm_CancelCause"
        Me.cmb_cancelCause.ValueMember = "Srl"
        '
        'PmCancelCauseBindingSource
        '
        Me.PmCancelCauseBindingSource.DataMember = "Pm_CancelCause"
        Me.PmCancelCauseBindingSource.DataSource = Me.Ds_Pm
        '
        'txt_Tarikh
        '
        Me.txt_Tarikh.CheckExistValueInDb = False
        Me.txt_Tarikh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Tarikh.CurrencyUnit = "ریال"
        Me.txt_Tarikh.DefaultValue = ""
        Me.txt_Tarikh.FillWithMaxInDb = False
        Me.txt_Tarikh.IsRequired = True
        Me.txt_Tarikh.Location = New System.Drawing.Point(721, 54)
        Me.txt_Tarikh.MaxDecimalLength = 2
        Me.txt_Tarikh.Name = "txt_Tarikh"
        Me.txt_Tarikh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Tarikh.Size = New System.Drawing.Size(149, 25)
        Me.txt_Tarikh.SpellControl = Nothing
        Me.txt_Tarikh.TabIndex = 3
        Me.txt_Tarikh.TabStop = False
        Me.txt_Tarikh.Tag = "pm_Date"
        Me.txt_Tarikh.Title = Nothing
        Me.txt_Tarikh.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_Tarikh.UseForData = True
        Me.txt_Tarikh.ValidateCheckExistOnEdit = False
        Me.txt_Tarikh.Value = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(882, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "تاریخ انجام PM"
        '
        'txt_ExecuteDate
        '
        Me.txt_ExecuteDate.CheckExistValueInDb = False
        Me.txt_ExecuteDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ExecuteDate.CurrencyUnit = "ریال"
        Me.txt_ExecuteDate.DefaultValue = ""
        Me.txt_ExecuteDate.FillWithMaxInDb = False
        Me.txt_ExecuteDate.IsRequired = False
        Me.txt_ExecuteDate.Location = New System.Drawing.Point(721, 107)
        Me.txt_ExecuteDate.MaxDecimalLength = 2
        Me.txt_ExecuteDate.Name = "txt_ExecuteDate"
        Me.txt_ExecuteDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ExecuteDate.Size = New System.Drawing.Size(149, 25)
        Me.txt_ExecuteDate.SpellControl = Nothing
        Me.txt_ExecuteDate.TabIndex = 5
        Me.txt_ExecuteDate.TabStop = False
        Me.txt_ExecuteDate.Tag = "pm_ExecuteDate"
        Me.txt_ExecuteDate.Title = Nothing
        Me.txt_ExecuteDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ExecuteDate.UseForData = True
        Me.txt_ExecuteDate.ValidateCheckExistOnEdit = False
        Me.txt_ExecuteDate.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(631, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "توضیحات"
        '
        'cmb_Post
        '
        Me.cmb_Post.AllowDrop = True
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PmPostBindingSource
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = False
        Me.cmb_Post.Location = New System.Drawing.Point(635, 94)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(214, 26)
        Me.cmb_Post.TabIndex = 7
        Me.cmb_Post.Tag = ""
        Me.cmb_Post.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'PmHadeseKhesaratDeviceBindingSource
        '
        Me.PmHadeseKhesaratDeviceBindingSource.DataMember = "Pm_Hadese_KhesaratDevice"
        Me.PmHadeseKhesaratDeviceBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_KhesaratDeviceTableAdapter
        '
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.ClearBeforeFill = True
        '
        'Pm_CancelCauseTableAdapter
        '
        Me.Pm_CancelCauseTableAdapter.ClearBeforeFill = True
        '
        'txt_TajhizName
        '
        Me.txt_TajhizName.CheckExistValueInDb = False
        Me.txt_TajhizName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TajhizName.CurrencyUnit = "ریال"
        Me.txt_TajhizName.DefaultValue = ""
        Me.txt_TajhizName.Enabled = False
        Me.txt_TajhizName.FillWithMaxInDb = False
        Me.txt_TajhizName.IsRequired = False
        Me.txt_TajhizName.Location = New System.Drawing.Point(361, 97)
        Me.txt_TajhizName.MaxDecimalLength = 2
        Me.txt_TajhizName.Name = "txt_TajhizName"
        Me.txt_TajhizName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TajhizName.Size = New System.Drawing.Size(192, 25)
        Me.txt_TajhizName.SpellControl = Nothing
        Me.txt_TajhizName.TabIndex = 9
        Me.txt_TajhizName.Tag = ""
        Me.txt_TajhizName.Title = Nothing
        Me.txt_TajhizName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TajhizName.UseForData = True
        Me.txt_TajhizName.ValidateCheckExistOnEdit = False
        Me.txt_TajhizName.Value = ""
        '
        'btn_SelectDEvice
        '
        Me.btn_SelectDEvice.Location = New System.Drawing.Point(323, 98)
        Me.btn_SelectDEvice.Name = "btn_SelectDEvice"
        Me.btn_SelectDEvice.Size = New System.Drawing.Size(32, 25)
        Me.btn_SelectDEvice.TabIndex = 10
        Me.btn_SelectDEvice.Text = "..."
        Me.btn_SelectDEvice.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.chk_AllTajhiz)
        Me.GroupBox1.Controls.Add(Me.Chk_AllPost)
        Me.GroupBox1.Controls.Add(Me.chk_AllExecDate)
        Me.GroupBox1.Controls.Add(Me.cmb_Post)
        Me.GroupBox1.Controls.Add(Me.btn_SelectDEvice)
        Me.GroupBox1.Controls.Add(Me.txt_EndExecDate)
        Me.GroupBox1.Controls.Add(Me.txt_TajhizName)
        Me.GroupBox1.Controls.Add(Me.chk_AllPmDate)
        Me.GroupBox1.Controls.Add(Me.txt_StartExeDate)
        Me.GroupBox1.Controls.Add(Me.txt_EndPmdate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_StartPmDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 135)
        Me.GroupBox1.TabIndex = 216
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "فیلتر"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rb_Cancle)
        Me.GroupBox2.Controls.Add(Me.Rb_NoExecute)
        Me.GroupBox2.Controls.Add(Me.Rb_All)
        Me.GroupBox2.Controls.Add(Me.rb_Execute)
        Me.GroupBox2.Location = New System.Drawing.Point(48, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 121)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نمایش"
        '
        'Rb_Cancle
        '
        Me.Rb_Cancle.AutoSize = True
        Me.Rb_Cancle.Location = New System.Drawing.Point(71, 95)
        Me.Rb_Cancle.Name = "Rb_Cancle"
        Me.Rb_Cancle.Size = New System.Drawing.Size(105, 22)
        Me.Rb_Cancle.TabIndex = 0
        Me.Rb_Cancle.Text = "کنسل شده "
        Me.Rb_Cancle.UseVisualStyleBackColor = True
        '
        'Rb_NoExecute
        '
        Me.Rb_NoExecute.AutoSize = True
        Me.Rb_NoExecute.Location = New System.Drawing.Point(79, 69)
        Me.Rb_NoExecute.Name = "Rb_NoExecute"
        Me.Rb_NoExecute.Size = New System.Drawing.Size(97, 22)
        Me.Rb_NoExecute.TabIndex = 0
        Me.Rb_NoExecute.Text = "انجام نشده"
        Me.Rb_NoExecute.UseVisualStyleBackColor = True
        '
        'Rb_All
        '
        Me.Rb_All.AutoSize = True
        Me.Rb_All.Checked = True
        Me.Rb_All.Location = New System.Drawing.Point(122, 20)
        Me.Rb_All.Name = "Rb_All"
        Me.Rb_All.Size = New System.Drawing.Size(54, 22)
        Me.Rb_All.TabIndex = 0
        Me.Rb_All.TabStop = True
        Me.Rb_All.Text = "همه"
        Me.Rb_All.UseVisualStyleBackColor = True
        '
        'rb_Execute
        '
        Me.rb_Execute.AutoSize = True
        Me.rb_Execute.Location = New System.Drawing.Point(11, 43)
        Me.rb_Execute.Name = "rb_Execute"
        Me.rb_Execute.Size = New System.Drawing.Size(165, 22)
        Me.rb_Execute.TabIndex = 0
        Me.rb_Execute.Text = "انجام شده طبق برنامه"
        Me.rb_Execute.UseVisualStyleBackColor = True
        '
        'chk_AllTajhiz
        '
        Me.chk_AllTajhiz.AutoSize = True
        Me.chk_AllTajhiz.Location = New System.Drawing.Point(559, 100)
        Me.chk_AllTajhiz.Name = "chk_AllTajhiz"
        Me.chk_AllTajhiz.Size = New System.Drawing.Size(60, 22)
        Me.chk_AllTajhiz.TabIndex = 8
        Me.chk_AllTajhiz.Text = "تجهیز"
        Me.chk_AllTajhiz.UseVisualStyleBackColor = True
        '
        'Chk_AllPost
        '
        Me.Chk_AllPost.AutoSize = True
        Me.Chk_AllPost.Location = New System.Drawing.Point(873, 96)
        Me.Chk_AllPost.Name = "Chk_AllPost"
        Me.Chk_AllPost.Size = New System.Drawing.Size(61, 22)
        Me.Chk_AllPost.TabIndex = 6
        Me.Chk_AllPost.Text = "پست"
        Me.Chk_AllPost.UseVisualStyleBackColor = True
        '
        'chk_AllExecDate
        '
        Me.chk_AllExecDate.AutoSize = True
        Me.chk_AllExecDate.Location = New System.Drawing.Point(836, 61)
        Me.chk_AllExecDate.Name = "chk_AllExecDate"
        Me.chk_AllExecDate.Size = New System.Drawing.Size(98, 22)
        Me.chk_AllExecDate.TabIndex = 3
        Me.chk_AllExecDate.Text = "تاریخ اجرا از"
        Me.chk_AllExecDate.UseVisualStyleBackColor = True
        '
        'txt_EndExecDate
        '
        Me.txt_EndExecDate.CheckExistValueInDb = False
        Me.txt_EndExecDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EndExecDate.CurrencyUnit = "ریال"
        Me.txt_EndExecDate.DefaultValue = ""
        Me.txt_EndExecDate.FillWithMaxInDb = False
        Me.txt_EndExecDate.IsRequired = False
        Me.txt_EndExecDate.Location = New System.Drawing.Point(448, 59)
        Me.txt_EndExecDate.MaxDecimalLength = 2
        Me.txt_EndExecDate.Name = "txt_EndExecDate"
        Me.txt_EndExecDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_EndExecDate.Size = New System.Drawing.Size(149, 25)
        Me.txt_EndExecDate.SpellControl = Nothing
        Me.txt_EndExecDate.TabIndex = 5
        Me.txt_EndExecDate.TabStop = False
        Me.txt_EndExecDate.Tag = ""
        Me.txt_EndExecDate.Title = Nothing
        Me.txt_EndExecDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_EndExecDate.UseForData = True
        Me.txt_EndExecDate.ValidateCheckExistOnEdit = False
        Me.txt_EndExecDate.Value = ""
        '
        'chk_AllPmDate
        '
        Me.chk_AllPmDate.AutoSize = True
        Me.chk_AllPmDate.Location = New System.Drawing.Point(798, 29)
        Me.chk_AllPmDate.Name = "chk_AllPmDate"
        Me.chk_AllPmDate.Size = New System.Drawing.Size(136, 22)
        Me.chk_AllPmDate.TabIndex = 0
        Me.chk_AllPmDate.Text = "تاریخ پیشنهادی از"
        Me.chk_AllPmDate.UseVisualStyleBackColor = True
        '
        'txt_StartExeDate
        '
        Me.txt_StartExeDate.CheckExistValueInDb = False
        Me.txt_StartExeDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_StartExeDate.CurrencyUnit = "ریال"
        Me.txt_StartExeDate.DefaultValue = ""
        Me.txt_StartExeDate.FillWithMaxInDb = False
        Me.txt_StartExeDate.IsRequired = False
        Me.txt_StartExeDate.Location = New System.Drawing.Point(636, 59)
        Me.txt_StartExeDate.MaxDecimalLength = 2
        Me.txt_StartExeDate.Name = "txt_StartExeDate"
        Me.txt_StartExeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_StartExeDate.Size = New System.Drawing.Size(149, 25)
        Me.txt_StartExeDate.SpellControl = Nothing
        Me.txt_StartExeDate.TabIndex = 4
        Me.txt_StartExeDate.TabStop = False
        Me.txt_StartExeDate.Tag = ""
        Me.txt_StartExeDate.Title = Nothing
        Me.txt_StartExeDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_StartExeDate.UseForData = True
        Me.txt_StartExeDate.ValidateCheckExistOnEdit = False
        Me.txt_StartExeDate.Value = ""
        '
        'txt_EndPmdate
        '
        Me.txt_EndPmdate.CheckExistValueInDb = False
        Me.txt_EndPmdate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EndPmdate.CurrencyUnit = "ریال"
        Me.txt_EndPmdate.DefaultValue = ""
        Me.txt_EndPmdate.FillWithMaxInDb = False
        Me.txt_EndPmdate.IsRequired = False
        Me.txt_EndPmdate.Location = New System.Drawing.Point(448, 26)
        Me.txt_EndPmdate.MaxDecimalLength = 2
        Me.txt_EndPmdate.Name = "txt_EndPmdate"
        Me.txt_EndPmdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_EndPmdate.Size = New System.Drawing.Size(149, 25)
        Me.txt_EndPmdate.SpellControl = Nothing
        Me.txt_EndPmdate.TabIndex = 2
        Me.txt_EndPmdate.TabStop = False
        Me.txt_EndPmdate.Tag = ""
        Me.txt_EndPmdate.Title = Nothing
        Me.txt_EndPmdate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_EndPmdate.UseForData = True
        Me.txt_EndPmdate.ValidateCheckExistOnEdit = False
        Me.txt_EndPmdate.Value = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(603, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "تا"
        '
        'txt_StartPmDate
        '
        Me.txt_StartPmDate.CheckExistValueInDb = False
        Me.txt_StartPmDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_StartPmDate.CurrencyUnit = "ریال"
        Me.txt_StartPmDate.DefaultValue = ""
        Me.txt_StartPmDate.FillWithMaxInDb = False
        Me.txt_StartPmDate.IsRequired = False
        Me.txt_StartPmDate.Location = New System.Drawing.Point(636, 26)
        Me.txt_StartPmDate.MaxDecimalLength = 2
        Me.txt_StartPmDate.Name = "txt_StartPmDate"
        Me.txt_StartPmDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_StartPmDate.Size = New System.Drawing.Size(149, 25)
        Me.txt_StartPmDate.SpellControl = Nothing
        Me.txt_StartPmDate.TabIndex = 1
        Me.txt_StartPmDate.TabStop = False
        Me.txt_StartPmDate.Tag = ""
        Me.txt_StartPmDate.Title = Nothing
        Me.txt_StartPmDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_StartPmDate.UseForData = True
        Me.txt_StartPmDate.ValidateCheckExistOnEdit = False
        Me.txt_StartPmDate.Value = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(603, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "تا"
        '
        'Cmb_Post_ForSave
        '
        Me.Cmb_Post_ForSave.AllowDrop = True
        Me.Cmb_Post_ForSave.AutoComplete = True
        Me.Cmb_Post_ForSave.DataSource = Me.PmPostBindingSource1
        Me.Cmb_Post_ForSave.DisplayMember = "نام پست"
        Me.Cmb_Post_ForSave.EnterStop = True
        Me.Cmb_Post_ForSave.FormattingEnabled = True
        Me.Cmb_Post_ForSave.IsRequired = False
        Me.Cmb_Post_ForSave.LimitedToList = False
        Me.Cmb_Post_ForSave.Location = New System.Drawing.Point(721, 15)
        Me.Cmb_Post_ForSave.Name = "Cmb_Post_ForSave"
        Me.Cmb_Post_ForSave.OpenOnFoucus = False
        Me.Cmb_Post_ForSave.Size = New System.Drawing.Size(193, 26)
        Me.Cmb_Post_ForSave.TabIndex = 0
        Me.Cmb_Post_ForSave.Tag = ""
        Me.Cmb_Post_ForSave.ValueMember = "Srl"
        '
        'PmPostBindingSource1
        '
        Me.PmPostBindingSource1.DataMember = "Pm_Post"
        Me.PmPostBindingSource1.DataSource = Me.Ds_Pm
        '
        'btn_SelectTajhiz
        '
        Me.btn_SelectTajhiz.Location = New System.Drawing.Point(320, 19)
        Me.btn_SelectTajhiz.Name = "btn_SelectTajhiz"
        Me.btn_SelectTajhiz.Size = New System.Drawing.Size(38, 25)
        Me.btn_SelectTajhiz.TabIndex = 2
        Me.btn_SelectTajhiz.Text = "..."
        Me.btn_SelectTajhiz.UseVisualStyleBackColor = True
        '
        'txt_TajhizNameForSave
        '
        Me.txt_TajhizNameForSave.CheckExistValueInDb = False
        Me.txt_TajhizNameForSave.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TajhizNameForSave.CurrencyUnit = "ریال"
        Me.txt_TajhizNameForSave.DefaultValue = ""
        Me.txt_TajhizNameForSave.Enabled = False
        Me.txt_TajhizNameForSave.FillWithMaxInDb = False
        Me.txt_TajhizNameForSave.IsRequired = False
        Me.txt_TajhizNameForSave.Location = New System.Drawing.Point(364, 16)
        Me.txt_TajhizNameForSave.MaxDecimalLength = 2
        Me.txt_TajhizNameForSave.Name = "txt_TajhizNameForSave"
        Me.txt_TajhizNameForSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TajhizNameForSave.Size = New System.Drawing.Size(261, 25)
        Me.txt_TajhizNameForSave.SpellControl = Nothing
        Me.txt_TajhizNameForSave.TabIndex = 1
        Me.txt_TajhizNameForSave.Tag = ""
        Me.txt_TajhizNameForSave.Title = Nothing
        Me.txt_TajhizNameForSave.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TajhizNameForSave.UseForData = True
        Me.txt_TajhizNameForSave.ValidateCheckExistOnEdit = False
        Me.txt_TajhizNameForSave.Value = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(931, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "پست"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(631, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "تجهیز"
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.Visible = False
        '
        'SrlDataGridViewTextBoxColumn2
        '
        Me.SrlDataGridViewTextBoxColumn2.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn2.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn2.Name = "SrlDataGridViewTextBoxColumn2"
        Me.SrlDataGridViewTextBoxColumn2.Visible = False
        '
        'Pm_PmProgramTableAdapter
        '
        Me.Pm_PmProgramTableAdapter.ClearBeforeFill = True
        '
        'Frm_PmWithDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1021, 697)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_PmWithDevice"
        Me.TableName = "Pm_PmProgram"
        Me.Text = "برنامه PM"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPmProgramBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmCancelCauseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PmPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Description As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_cancelCause As VB_Component.ComboBox
    Friend WithEvents txt_Tarikh As CS_Component.TextBox
    Friend WithEvents txt_ExecuteDate As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents PmCancelCauseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_CancelCauseTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_CancelCauseTableAdapter
    Friend WithEvents txt_TajhizName As CS_Component.TextBox
    Friend WithEvents btn_SelectDEvice As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_AllExecDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_EndExecDate As CS_Component.TextBox
    Friend WithEvents chk_AllPmDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_StartExeDate As CS_Component.TextBox
    Friend WithEvents txt_EndPmdate As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_StartPmDate As CS_Component.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chk_AllTajhiz As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_AllPost As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_Post_ForSave As VB_Component.ComboBox
    Friend WithEvents PmPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btn_SelectTajhiz As System.Windows.Forms.Button
    Friend WithEvents txt_TajhizNameForSave As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_Cancle As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_NoExecute As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Execute As System.Windows.Forms.RadioButton
    Friend WithEvents نامتحهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmPmProgramBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SrlDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pm_PmProgramTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PmProgramTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخانجامDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents دلیلکنسلیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Srl1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
