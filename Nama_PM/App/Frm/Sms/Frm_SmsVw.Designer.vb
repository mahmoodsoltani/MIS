<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SmsVw
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
        Me.متنDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.دریافتکنندهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کاربرارسالکنندهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاربخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ساعتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.فرمنقصDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmSmsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.chk_AllReciever = New System.Windows.Forms.CheckBox
        Me.Chk_AllSender = New System.Windows.Forms.CheckBox
        Me.cmb_Reciever = New VB_Component.ComboBox
        Me.PmAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.cmb_Sender = New VB_Component.ComboBox
        Me.PmAshkhasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.chk_AllDate = New System.Windows.Forms.CheckBox
        Me.Pm_SmsTableAdapter = New Nama_PM.Ds_RpTableAdapters.Pm_SmsTableAdapter
        Me.Pm_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
        Me.Ds_Security = New Nama_PM.Ds_Security
        Me.SecUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sec_UserTableAdapter = New Nama_PM.Ds_SecurityTableAdapters.sec_UserTableAdapter
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.chk_allPost = New System.Windows.Forms.CheckBox
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSmsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Security, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_Delete.HeaderText = "چاپ"
        Me.btn_Delete.Location = New System.Drawing.Point(630, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(101, 29)
        Me.btn_Delete.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(738, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(101, 29)
        Me.btn_Edit.Visible = False
        '
        'btn_New
        '
        Me.btn_New.HeaderText = "چاپ"
        Me.btn_New.Location = New System.Drawing.Point(845, 17)
        Me.btn_New.Size = New System.Drawing.Size(101, 29)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.txt_ToDate)
        Me.gbx_DataGridView.Controls.Add(Me.txt_FromDate)
        Me.gbx_DataGridView.Controls.Add(Me.Label2)
        Me.gbx_DataGridView.Controls.Add(Me.cmb_Post)
        Me.gbx_DataGridView.Controls.Add(Me.cmb_Sender)
        Me.gbx_DataGridView.Controls.Add(Me.cmb_Reciever)
        Me.gbx_DataGridView.Controls.Add(Me.chk_allPost)
        Me.gbx_DataGridView.Controls.Add(Me.Chk_AllSender)
        Me.gbx_DataGridView.Controls.Add(Me.chk_AllDate)
        Me.gbx_DataGridView.Controls.Add(Me.chk_AllReciever)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.متنDataGridViewTextBoxColumn, Me.دریافتکنندهDataGridViewTextBoxColumn, Me.کاربرارسالکنندهDataGridViewTextBoxColumn, Me.تاربخDataGridViewTextBoxColumn, Me.ساعتDataGridViewTextBoxColumn, Me.فرمنقصDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmSmsBindingSource
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
        'متنDataGridViewTextBoxColumn
        '
        Me.متنDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.متنDataGridViewTextBoxColumn.DataPropertyName = "متن"
        Me.متنDataGridViewTextBoxColumn.HeaderText = "متن"
        Me.متنDataGridViewTextBoxColumn.Name = "متنDataGridViewTextBoxColumn"
        Me.متنDataGridViewTextBoxColumn.ReadOnly = True
        '
        'دریافتکنندهDataGridViewTextBoxColumn
        '
        Me.دریافتکنندهDataGridViewTextBoxColumn.DataPropertyName = "دریافت کننده"
        Me.دریافتکنندهDataGridViewTextBoxColumn.HeaderText = "دریافت کننده"
        Me.دریافتکنندهDataGridViewTextBoxColumn.Name = "دریافتکنندهDataGridViewTextBoxColumn"
        Me.دریافتکنندهDataGridViewTextBoxColumn.ReadOnly = True
        Me.دریافتکنندهDataGridViewTextBoxColumn.Width = 150
        '
        'کاربرارسالکنندهDataGridViewTextBoxColumn
        '
        Me.کاربرارسالکنندهDataGridViewTextBoxColumn.DataPropertyName = "کاربر ارسال کننده"
        Me.کاربرارسالکنندهDataGridViewTextBoxColumn.HeaderText = "کاربر ارسال کننده"
        Me.کاربرارسالکنندهDataGridViewTextBoxColumn.Name = "کاربرارسالکنندهDataGridViewTextBoxColumn"
        Me.کاربرارسالکنندهDataGridViewTextBoxColumn.ReadOnly = True
        Me.کاربرارسالکنندهDataGridViewTextBoxColumn.Width = 120
        '
        'تاربخDataGridViewTextBoxColumn
        '
        Me.تاربخDataGridViewTextBoxColumn.DataPropertyName = "تاربخ"
        Me.تاربخDataGridViewTextBoxColumn.HeaderText = "تاربخ"
        Me.تاربخDataGridViewTextBoxColumn.Name = "تاربخDataGridViewTextBoxColumn"
        Me.تاربخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ساعتDataGridViewTextBoxColumn
        '
        Me.ساعتDataGridViewTextBoxColumn.DataPropertyName = "ساعت"
        Me.ساعتDataGridViewTextBoxColumn.HeaderText = "ساعت"
        Me.ساعتDataGridViewTextBoxColumn.Name = "ساعتDataGridViewTextBoxColumn"
        Me.ساعتDataGridViewTextBoxColumn.ReadOnly = True
        Me.ساعتDataGridViewTextBoxColumn.Width = 80
        '
        'فرمنقصDataGridViewTextBoxColumn
        '
        Me.فرمنقصDataGridViewTextBoxColumn.DataPropertyName = "فرم نقص"
        Me.فرمنقصDataGridViewTextBoxColumn.HeaderText = "فرم نقص"
        Me.فرمنقصDataGridViewTextBoxColumn.Name = "فرمنقصDataGridViewTextBoxColumn"
        Me.فرمنقصDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmSmsBindingSource
        '
        Me.PmSmsBindingSource.DataMember = "Pm_Sms"
        Me.PmSmsBindingSource.DataSource = Me.Ds_Rp
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_AllReciever
        '
        Me.chk_AllReciever.AutoSize = True
        Me.chk_AllReciever.Location = New System.Drawing.Point(769, 28)
        Me.chk_AllReciever.Name = "chk_AllReciever"
        Me.chk_AllReciever.Size = New System.Drawing.Size(156, 22)
        Me.chk_AllReciever.TabIndex = 3
        Me.chk_AllReciever.Text = "همه دریافت کننده ها"
        Me.chk_AllReciever.UseVisualStyleBackColor = True
        '
        'Chk_AllSender
        '
        Me.Chk_AllSender.AutoSize = True
        Me.Chk_AllSender.Location = New System.Drawing.Point(771, 64)
        Me.Chk_AllSender.Name = "Chk_AllSender"
        Me.Chk_AllSender.Size = New System.Drawing.Size(154, 22)
        Me.Chk_AllSender.TabIndex = 3
        Me.Chk_AllSender.Text = "همه ارسال کننده ها"
        Me.Chk_AllSender.UseVisualStyleBackColor = True
        '
        'cmb_Reciever
        '
        Me.cmb_Reciever.AutoComplete = True
        Me.cmb_Reciever.DataSource = Me.PmAshkhasBindingSource
        Me.cmb_Reciever.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Reciever.EnterStop = True
        Me.cmb_Reciever.FormattingEnabled = True
        Me.cmb_Reciever.IsRequired = False
        Me.cmb_Reciever.LimitedToList = True
        Me.cmb_Reciever.Location = New System.Drawing.Point(532, 24)
        Me.cmb_Reciever.Name = "cmb_Reciever"
        Me.cmb_Reciever.OpenOnFoucus = False
        Me.cmb_Reciever.Size = New System.Drawing.Size(225, 26)
        Me.cmb_Reciever.TabIndex = 4
        Me.cmb_Reciever.ValueMember = "Srl"
        '
        'PmAshkhasBindingSource
        '
        Me.PmAshkhasBindingSource.DataMember = "Pm_Ashkhas"
        Me.PmAshkhasBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_Sender
        '
        Me.cmb_Sender.AutoComplete = True
        Me.cmb_Sender.DataSource = Me.PmAshkhasBindingSource1
        Me.cmb_Sender.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Sender.EnterStop = True
        Me.cmb_Sender.FormattingEnabled = True
        Me.cmb_Sender.IsRequired = False
        Me.cmb_Sender.LimitedToList = True
        Me.cmb_Sender.Location = New System.Drawing.Point(532, 60)
        Me.cmb_Sender.Name = "cmb_Sender"
        Me.cmb_Sender.OpenOnFoucus = False
        Me.cmb_Sender.Size = New System.Drawing.Size(225, 26)
        Me.cmb_Sender.TabIndex = 4
        Me.cmb_Sender.ValueMember = "Srl"
        '
        'PmAshkhasBindingSource1
        '
        Me.PmAshkhasBindingSource1.DataMember = "Pm_Ashkhas"
        Me.PmAshkhasBindingSource1.DataSource = Me.Ds_Ashkhas
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(192, 21)
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
        Me.Label2.Location = New System.Drawing.Point(172, 24)
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
        Me.txt_ToDate.Location = New System.Drawing.Point(33, 21)
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
        Me.chk_AllDate.Location = New System.Drawing.Point(343, 26)
        Me.chk_AllDate.Name = "chk_AllDate"
        Me.chk_AllDate.Size = New System.Drawing.Size(144, 22)
        Me.chk_AllDate.TabIndex = 3
        Me.chk_AllDate.Text = "تمام تاریخ ها      از"
        Me.chk_AllDate.UseVisualStyleBackColor = True
        '
        'Pm_SmsTableAdapter
        '
        Me.Pm_SmsTableAdapter.ClearBeforeFill = True
        '
        'Pm_AshkhasTableAdapter
        '
        Me.Pm_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'Ds_Security
        '
        Me.Ds_Security.DataSetName = "Ds_Security"
        Me.Ds_Security.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SecUserBindingSource
        '
        Me.SecUserBindingSource.DataMember = "sec_User"
        Me.SecUserBindingSource.DataSource = Me.Ds_Security
        '
        'Sec_UserTableAdapter
        '
        Me.Sec_UserTableAdapter.ClearBeforeFill = True
        '
        'cmb_Post
        '
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PmPostBindingSource
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = True
        Me.cmb_Post.Location = New System.Drawing.Point(102, 60)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(225, 26)
        Me.cmb_Post.TabIndex = 4
        Me.cmb_Post.ValueMember = "Srl"
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
        'chk_allPost
        '
        Me.chk_allPost.AutoSize = True
        Me.chk_allPost.Location = New System.Drawing.Point(374, 62)
        Me.chk_allPost.Name = "chk_allPost"
        Me.chk_allPost.Size = New System.Drawing.Size(113, 22)
        Me.chk_allPost.TabIndex = 3
        Me.chk_allPost.Text = "همه پست ها"
        Me.chk_allPost.UseVisualStyleBackColor = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Frm_SmsVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 565)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_SmsVw"
        Me.Text = "نمایش پیامک های ارسالی"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.gbx_DataGridView.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSmsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Security, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_Sender As VB_Component.ComboBox
    Friend WithEvents cmb_Reciever As VB_Component.ComboBox
    Friend WithEvents Chk_AllSender As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllReciever As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_AllDate As System.Windows.Forms.CheckBox
    Friend WithEvents PmSmsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents Pm_SmsTableAdapter As Nama_PM.Ds_RpTableAdapters.Pm_SmsTableAdapter
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents PmAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents Ds_Security As Nama_PM.Ds_Security
    Friend WithEvents SecUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sec_UserTableAdapter As Nama_PM.Ds_SecurityTableAdapters.sec_UserTableAdapter
    Friend WithEvents PmAshkhasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents متنDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents دریافتکنندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کاربرارسالکنندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاربخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساعتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فرمنقصDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents chk_allPost As System.Windows.Forms.CheckBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
End Class
