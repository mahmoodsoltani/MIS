<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DarkhasteKarVw
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Record = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rb_NoStatus = New System.Windows.Forms.RadioButton
        Me.Rb_Cancle = New System.Windows.Forms.RadioButton
        Me.Rb_NoExecute = New System.Windows.Forms.RadioButton
        Me.Rb_All = New System.Windows.Forms.RadioButton
        Me.rb_Execute = New System.Windows.Forms.RadioButton
        Me.Chk_AllPost = New System.Windows.Forms.CheckBox
        Me.chk_AllExecDate = New System.Windows.Forms.CheckBox
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm2 = New Nama_PM.Ds_Pm
        Me.txt_EndExecDate = New CS_Component.TextBox
        Me.chk_AllDate = New System.Windows.Forms.CheckBox
        Me.txt_StartExeDate = New CS_Component.TextBox
        Me.txt_EndPmdate = New CS_Component.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_StartPmDate = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.خاموشیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پیوستهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmDarkhasteKarVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_DarkhasteKarVwTableAdapter2 = New Nama_PM.Ds_PmTableAdapters.Pm_DarkhasteKarVwTableAdapter
        Me.Pm_PostTableAdapter1 = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.rp = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PmPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmDarkhasteKarVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.rp)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 694)
        Me.GroupBox1.Size = New System.Drawing.Size(1345, 47)
        Me.GroupBox1.Controls.SetChildIndex(Me.Button1, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_New, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Cancel, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.rp, 0)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(1060, 15)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(1154, 15)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(1248, 15)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Controls.Add(Me.GroupBox2)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(1345, 656)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_Record)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Chk_AllPost)
        Me.GroupBox2.Controls.Add(Me.chk_AllExecDate)
        Me.GroupBox2.Controls.Add(Me.cmb_Post)
        Me.GroupBox2.Controls.Add(Me.txt_EndExecDate)
        Me.GroupBox2.Controls.Add(Me.chk_AllDate)
        Me.GroupBox2.Controls.Add(Me.txt_StartExeDate)
        Me.GroupBox2.Controls.Add(Me.txt_EndPmdate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_StartPmDate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(198, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(937, 138)
        Me.GroupBox2.TabIndex = 217
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "فیلتر"
        '
        'lbl_Record
        '
        Me.lbl_Record.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.lbl_Record.AutoSize = True
        Me.lbl_Record.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Record.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_Record.Location = New System.Drawing.Point(466, 97)
        Me.lbl_Record.Name = "lbl_Record"
        Me.lbl_Record.Size = New System.Drawing.Size(86, 17)
        Me.lbl_Record.TabIndex = 12
        Me.lbl_Record.Text = "تعداد رکورد:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_NoStatus)
        Me.GroupBox3.Controls.Add(Me.Rb_Cancle)
        Me.GroupBox3.Controls.Add(Me.Rb_NoExecute)
        Me.GroupBox3.Controls.Add(Me.Rb_All)
        Me.GroupBox3.Controls.Add(Me.rb_Execute)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(112, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(161, 121)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "نمایش"
        '
        'rb_NoStatus
        '
        Me.rb_NoStatus.AutoSize = True
        Me.rb_NoStatus.Location = New System.Drawing.Point(22, 95)
        Me.rb_NoStatus.Name = "rb_NoStatus"
        Me.rb_NoStatus.Size = New System.Drawing.Size(121, 20)
        Me.rb_NoStatus.TabIndex = 1
        Me.rb_NoStatus.TabStop = True
        Me.rb_NoStatus.Text = "وضعیت نامشخص"
        Me.rb_NoStatus.UseVisualStyleBackColor = True
        '
        'Rb_Cancle
        '
        Me.Rb_Cancle.AutoSize = True
        Me.Rb_Cancle.Location = New System.Drawing.Point(59, 76)
        Me.Rb_Cancle.Name = "Rb_Cancle"
        Me.Rb_Cancle.Size = New System.Drawing.Size(84, 20)
        Me.Rb_Cancle.TabIndex = 0
        Me.Rb_Cancle.Text = "ابطال شده"
        Me.Rb_Cancle.UseVisualStyleBackColor = True
        '
        'Rb_NoExecute
        '
        Me.Rb_NoExecute.AutoSize = True
        Me.Rb_NoExecute.Location = New System.Drawing.Point(53, 56)
        Me.Rb_NoExecute.Name = "Rb_NoExecute"
        Me.Rb_NoExecute.Size = New System.Drawing.Size(90, 20)
        Me.Rb_NoExecute.TabIndex = 0
        Me.Rb_NoExecute.Text = "کنسل شده"
        Me.Rb_NoExecute.UseVisualStyleBackColor = True
        '
        'Rb_All
        '
        Me.Rb_All.AutoSize = True
        Me.Rb_All.Checked = True
        Me.Rb_All.Location = New System.Drawing.Point(91, 19)
        Me.Rb_All.Name = "Rb_All"
        Me.Rb_All.Size = New System.Drawing.Size(50, 20)
        Me.Rb_All.TabIndex = 0
        Me.Rb_All.TabStop = True
        Me.Rb_All.Text = "همه"
        Me.Rb_All.UseVisualStyleBackColor = True
        '
        'rb_Execute
        '
        Me.rb_Execute.AutoSize = True
        Me.rb_Execute.Location = New System.Drawing.Point(63, 38)
        Me.rb_Execute.Name = "rb_Execute"
        Me.rb_Execute.Size = New System.Drawing.Size(80, 20)
        Me.rb_Execute.TabIndex = 0
        Me.rb_Execute.Text = "تایید شده"
        Me.rb_Execute.UseVisualStyleBackColor = True
        '
        'Chk_AllPost
        '
        Me.Chk_AllPost.AutoSize = True
        Me.Chk_AllPost.Location = New System.Drawing.Point(842, 96)
        Me.Chk_AllPost.Name = "Chk_AllPost"
        Me.Chk_AllPost.Size = New System.Drawing.Size(57, 20)
        Me.Chk_AllPost.TabIndex = 6
        Me.Chk_AllPost.Text = "پست"
        Me.Chk_AllPost.UseVisualStyleBackColor = True
        '
        'chk_AllExecDate
        '
        Me.chk_AllExecDate.AutoSize = True
        Me.chk_AllExecDate.Location = New System.Drawing.Point(810, 61)
        Me.chk_AllExecDate.Name = "chk_AllExecDate"
        Me.chk_AllExecDate.Size = New System.Drawing.Size(89, 20)
        Me.chk_AllExecDate.TabIndex = 3
        Me.chk_AllExecDate.Text = "تاریخ اجرا از"
        Me.chk_AllExecDate.UseVisualStyleBackColor = True
        '
        'cmb_Post
        '
        Me.cmb_Post.AllowDrop = True
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PmPostBindingSource1
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.Enabled = False
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = False
        Me.cmb_Post.Location = New System.Drawing.Point(604, 94)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(214, 24)
        Me.cmb_Post.TabIndex = 7
        Me.cmb_Post.Tag = ""
        Me.cmb_Post.ValueMember = "Srl"
        '
        'PmPostBindingSource1
        '
        Me.PmPostBindingSource1.DataMember = "Pm_Post"
        Me.PmPostBindingSource1.DataSource = Me.Ds_Pm2
        '
        'Ds_Pm2
        '
        Me.Ds_Pm2.DataSetName = "Ds_Pm"
        Me.Ds_Pm2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_EndExecDate
        '
        Me.txt_EndExecDate.CheckExistValueInDb = False
        Me.txt_EndExecDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EndExecDate.CurrencyUnit = "ریال"
        Me.txt_EndExecDate.DefaultValue = ""
        Me.txt_EndExecDate.Enabled = False
        Me.txt_EndExecDate.FillWithMaxInDb = False
        Me.txt_EndExecDate.IsRequired = False
        Me.txt_EndExecDate.Location = New System.Drawing.Point(422, 59)
        Me.txt_EndExecDate.MaxDecimalLength = 2
        Me.txt_EndExecDate.Name = "txt_EndExecDate"
        Me.txt_EndExecDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_EndExecDate.Size = New System.Drawing.Size(149, 23)
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
        'chk_AllDate
        '
        Me.chk_AllDate.AutoSize = True
        Me.chk_AllDate.Location = New System.Drawing.Point(809, 31)
        Me.chk_AllDate.Name = "chk_AllDate"
        Me.chk_AllDate.Size = New System.Drawing.Size(90, 20)
        Me.chk_AllDate.TabIndex = 0
        Me.chk_AllDate.Text = "تاریخ ثبت از"
        Me.chk_AllDate.UseVisualStyleBackColor = True
        '
        'txt_StartExeDate
        '
        Me.txt_StartExeDate.CheckExistValueInDb = False
        Me.txt_StartExeDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_StartExeDate.CurrencyUnit = "ریال"
        Me.txt_StartExeDate.DefaultValue = ""
        Me.txt_StartExeDate.Enabled = False
        Me.txt_StartExeDate.FillWithMaxInDb = False
        Me.txt_StartExeDate.IsRequired = False
        Me.txt_StartExeDate.Location = New System.Drawing.Point(610, 59)
        Me.txt_StartExeDate.MaxDecimalLength = 2
        Me.txt_StartExeDate.Name = "txt_StartExeDate"
        Me.txt_StartExeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_StartExeDate.Size = New System.Drawing.Size(149, 23)
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
        Me.txt_EndPmdate.Enabled = False
        Me.txt_EndPmdate.FillWithMaxInDb = False
        Me.txt_EndPmdate.IsRequired = False
        Me.txt_EndPmdate.Location = New System.Drawing.Point(422, 26)
        Me.txt_EndPmdate.MaxDecimalLength = 2
        Me.txt_EndPmdate.Name = "txt_EndPmdate"
        Me.txt_EndPmdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_EndPmdate.Size = New System.Drawing.Size(149, 23)
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
        Me.Label7.Location = New System.Drawing.Point(577, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "تا"
        '
        'txt_StartPmDate
        '
        Me.txt_StartPmDate.CheckExistValueInDb = False
        Me.txt_StartPmDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_StartPmDate.CurrencyUnit = "ریال"
        Me.txt_StartPmDate.DefaultValue = ""
        Me.txt_StartPmDate.Enabled = False
        Me.txt_StartPmDate.FillWithMaxInDb = False
        Me.txt_StartPmDate.IsRequired = False
        Me.txt_StartPmDate.Location = New System.Drawing.Point(610, 26)
        Me.txt_StartPmDate.MaxDecimalLength = 2
        Me.txt_StartPmDate.Name = "txt_StartPmDate"
        Me.txt_StartPmDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_StartPmDate.Size = New System.Drawing.Size(149, 23)
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
        Me.Label8.Location = New System.Drawing.Point(577, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "تا"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.خاموشیDataGridViewTextBoxColumn, Me.پیوستهDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmDarkhasteKarVwBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1339, 461)
        Me.DataGridView1.TabIndex = 218
        '
        'Column1
        '
        Me.Column1.HeaderText = "ردیف"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 50
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Taeed_Cancel"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Taeed_Cancel"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Srl"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Srl"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "شماره"
        Me.DataGridViewTextBoxColumn39.HeaderText = "شماره"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Width = 50
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "شماره سامک"
        Me.DataGridViewTextBoxColumn41.HeaderText = "سامک"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Width = 55
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "تاریخ ثبت"
        Me.DataGridViewTextBoxColumn40.HeaderText = "تاریخ ثبت"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Width = 90
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "نام پست"
        Me.DataGridViewTextBoxColumn33.HeaderText = "نام پست"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "نام تحهیز"
        Me.DataGridViewTextBoxColumn32.HeaderText = "نام تحهیز"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Tarikh_From"
        Me.DataGridViewTextBoxColumn23.HeaderText = "از تاریخ"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 90
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Tarikh_To"
        Me.DataGridViewTextBoxColumn24.HeaderText = "تا تاریخ"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 90
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Time_From"
        Me.DataGridViewTextBoxColumn25.HeaderText = "از ساعت"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 50
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Time_To"
        Me.DataGridViewTextBoxColumn26.HeaderText = "تا ساعت"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 50
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "نام گروه"
        Me.DataGridViewTextBoxColumn34.HeaderText = "نام گروه"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "نام واحد"
        Me.DataGridViewTextBoxColumn35.HeaderText = "نام واحد"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "نام"
        Me.DataGridViewTextBoxColumn36.HeaderText = "سرپرست"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "شرح کار"
        Me.DataGridViewTextBoxColumn37.HeaderText = "شرح کار"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Width = 200
        '
        'خاموشیDataGridViewTextBoxColumn
        '
        Me.خاموشیDataGridViewTextBoxColumn.DataPropertyName = "خاموشی"
        Me.خاموشیDataGridViewTextBoxColumn.HeaderText = "خاموشی"
        Me.خاموشیDataGridViewTextBoxColumn.Name = "خاموشیDataGridViewTextBoxColumn"
        Me.خاموشیDataGridViewTextBoxColumn.ReadOnly = True
        Me.خاموشیDataGridViewTextBoxColumn.Width = 80
        '
        'پیوستهDataGridViewTextBoxColumn
        '
        Me.پیوستهDataGridViewTextBoxColumn.DataPropertyName = "پیوسته"
        Me.پیوستهDataGridViewTextBoxColumn.HeaderText = "پیوسته"
        Me.پیوستهDataGridViewTextBoxColumn.Name = "پیوستهDataGridViewTextBoxColumn"
        Me.پیوستهDataGridViewTextBoxColumn.ReadOnly = True
        Me.پیوستهDataGridViewTextBoxColumn.Width = 70
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "توضیحات"
        Me.DataGridViewTextBoxColumn38.HeaderText = "توضیحات"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Peyvaste"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Peyvaste"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Khamooshi"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Khamooshi"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Srl_SubmitUser"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Srl_SubmitUser"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'PmDarkhasteKarVwBindingSource
        '
        Me.PmDarkhasteKarVwBindingSource.DataMember = "Pm_DarkhasteKarVw"
        Me.PmDarkhasteKarVwBindingSource.DataSource = Me.Ds_Pm2
        '
        'Pm_DarkhasteKarVwTableAdapter2
        '
        Me.Pm_DarkhasteKarVwTableAdapter2.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter1
        '
        Me.Pm_PostTableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "خروجی اکسل"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rp
        '
        Me.rp.Location = New System.Drawing.Point(206, 15)
        Me.rp.Name = "rp"
        Me.rp.Size = New System.Drawing.Size(81, 26)
        Me.rp.TabIndex = 6
        Me.rp.Text = "گزارش"
        Me.rp.UseVisualStyleBackColor = True
        '
        'Frm_DarkhasteKarVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 777)
        Me.Name = "Frm_DarkhasteKarVw"
        Me.Text = "نمایش درخواست کار"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PmPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmDarkhasteKarVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_Cancle As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_NoExecute As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Execute As System.Windows.Forms.RadioButton
    Friend WithEvents Chk_AllPost As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllExecDate As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents txt_EndExecDate As CS_Component.TextBox
    Friend WithEvents chk_AllDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_StartExeDate As CS_Component.TextBox
    Friend WithEvents txt_EndPmdate As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_StartPmDate As CS_Component.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_DarkhasteKarVwTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_DarkhasteKarVwTableAdapter
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهسامکDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخثبتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامتحهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شرحکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarikhFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarikhToDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeToDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeyvasteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KhamooshiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaeedCancelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlSubmitUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ds_Pm1 As Nama_PM.Ds_Pm
    Friend WithEvents Pm_DarkhasteKarVwTableAdapter1 As Nama_PM.Ds_PmTableAdapters.Pm_DarkhasteKarVwTableAdapter
    Friend WithEvents rb_NoStatus As System.Windows.Forms.RadioButton
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlTajhizForKarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_Record As System.Windows.Forms.Label
    Friend WithEvents PmDarkhasteKarVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm2 As Nama_PM.Ds_Pm
    Friend WithEvents Pm_DarkhasteKarVwTableAdapter2 As Nama_PM.Ds_PmTableAdapters.Pm_DarkhasteKarVwTableAdapter
    Friend WithEvents PmPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter1 As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents خاموشیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پیوستهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rp As System.Windows.Forms.Button
End Class
