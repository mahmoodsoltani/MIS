<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PmProgram
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
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخانجامDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامتحهیزDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.توضیحاتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.دلیلکنسلیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmPmProgramBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.cmb_cancelCause = New VB_Component.ComboBox
        Me.PmCancelCauseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Tarikh = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Pm_PmProgramTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PmProgramTableAdapter
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Tajhiz = New VB_Component.ComboBox
        Me.PmHadeseKhesaratDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_Hadese_KhesaratDeviceTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
        Me.Pm_CancelCauseTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_CancelCauseTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPmProgramBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmCancelCauseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(215, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(462, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(338, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.cmb_Tajhiz)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_Post)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Controls.Add(Me.Label6)
        Me.gbx_GridViewList.Controls.Add(Me.Label5)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(585, 481)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.txt_Tarikh)
        Me.gbx_Controls.Controls.Add(Me.cmb_cancelCause)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.txt_Description)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 585)
        Me.gbx_Controls.Size = New System.Drawing.Size(585, 161)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 524)
        Me.gbx_Btn.Size = New System.Drawing.Size(585, 60)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(464, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "علت کنسلی"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 30)
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
        Me.txt_Description.Location = New System.Drawing.Point(30, 63)
        Me.txt_Description.MaxDecimalLength = 2
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Description.Size = New System.Drawing.Size(428, 47)
        Me.txt_Description.SpellControl = Nothing
        Me.txt_Description.TabIndex = 2
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.تاریخانجامDataGridViewTextBoxColumn, Me.نامتحهیزDataGridViewTextBoxColumn, Me.توضیحاتDataGridViewTextBoxColumn, Me.دلیلکنسلیDataGridViewTextBoxColumn})
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
        Me.DataGridView1.Location = New System.Drawing.Point(11, 53)
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
        Me.DataGridView1.Size = New System.Drawing.Size(565, 422)
        Me.DataGridView1.TabIndex = 0
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ PM"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخانجامDataGridViewTextBoxColumn
        '
        Me.تاریخانجامDataGridViewTextBoxColumn.DataPropertyName = "تاریخ انجام"
        Me.تاریخانجامDataGridViewTextBoxColumn.HeaderText = "تاریخ انجام"
        Me.تاریخانجامDataGridViewTextBoxColumn.Name = "تاریخانجامDataGridViewTextBoxColumn"
        Me.تاریخانجامDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامتحهیزDataGridViewTextBoxColumn
        '
        Me.نامتحهیزDataGridViewTextBoxColumn.DataPropertyName = "نام تحهیز"
        Me.نامتحهیزDataGridViewTextBoxColumn.HeaderText = "نام تحهیز"
        Me.نامتحهیزDataGridViewTextBoxColumn.Name = "نامتحهیزDataGridViewTextBoxColumn"
        Me.نامتحهیزDataGridViewTextBoxColumn.ReadOnly = True
        Me.نامتحهیزDataGridViewTextBoxColumn.Visible = False
        '
        'توضیحاتDataGridViewTextBoxColumn
        '
        Me.توضیحاتDataGridViewTextBoxColumn.DataPropertyName = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.Name = "توضیحاتDataGridViewTextBoxColumn"
        Me.توضیحاتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'دلیلکنسلیDataGridViewTextBoxColumn
        '
        Me.دلیلکنسلیDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.دلیلکنسلیDataGridViewTextBoxColumn.DataPropertyName = "دلیل کنسلی"
        Me.دلیلکنسلیDataGridViewTextBoxColumn.HeaderText = "دلیل کنسلی"
        Me.دلیلکنسلیDataGridViewTextBoxColumn.Name = "دلیلکنسلیDataGridViewTextBoxColumn"
        Me.دلیلکنسلیDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.cmb_cancelCause.Location = New System.Drawing.Point(189, 118)
        Me.cmb_cancelCause.Name = "cmb_cancelCause"
        Me.cmb_cancelCause.OpenOnFoucus = False
        Me.cmb_cancelCause.Size = New System.Drawing.Size(269, 26)
        Me.cmb_cancelCause.TabIndex = 3
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
        Me.txt_Tarikh.Location = New System.Drawing.Point(309, 27)
        Me.txt_Tarikh.MaxDecimalLength = 2
        Me.txt_Tarikh.Name = "txt_Tarikh"
        Me.txt_Tarikh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Tarikh.Size = New System.Drawing.Size(149, 25)
        Me.txt_Tarikh.SpellControl = Nothing
        Me.txt_Tarikh.TabIndex = 0
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
        Me.Label4.Location = New System.Drawing.Point(185, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "تاریخ انجام PM"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(30, 27)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(149, 25)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TabStop = False
        Me.TextBox1.Tag = "pm_ExecuteDate"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "توضیحات"
        '
        'Pm_PmProgramTableAdapter
        '
        Me.Pm_PmProgramTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "تجهیز"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(499, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "تجهیز پست"
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
        Me.cmb_Post.Location = New System.Drawing.Point(279, 21)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(214, 26)
        Me.cmb_Post.TabIndex = 5
        Me.cmb_Post.Tag = ""
        Me.cmb_Post.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_Tajhiz
        '
        Me.cmb_Tajhiz.AllowDrop = True
        Me.cmb_Tajhiz.AutoComplete = True
        Me.cmb_Tajhiz.DataSource = Me.PmHadeseKhesaratDeviceBindingSource
        Me.cmb_Tajhiz.DisplayMember = "نام"
        Me.cmb_Tajhiz.EnterStop = True
        Me.cmb_Tajhiz.FormattingEnabled = True
        Me.cmb_Tajhiz.IsRequired = False
        Me.cmb_Tajhiz.LimitedToList = False
        Me.cmb_Tajhiz.Location = New System.Drawing.Point(12, 21)
        Me.cmb_Tajhiz.Name = "cmb_Tajhiz"
        Me.cmb_Tajhiz.OpenOnFoucus = False
        Me.cmb_Tajhiz.Size = New System.Drawing.Size(214, 26)
        Me.cmb_Tajhiz.TabIndex = 5
        Me.cmb_Tajhiz.Tag = "Srl_Pm_Hadese_KhesaratDevice"
        Me.cmb_Tajhiz.ValueMember = "Srl"
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
        'Frm_PmProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(613, 780)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_PmProgram"
        Me.TableName = "Pm_PmProgram"
        Me.Text = "برنامه PM"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPmProgramBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmCancelCauseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Description As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_cancelCause As VB_Component.ComboBox
    Friend WithEvents txt_Tarikh As CS_Component.TextBox
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Tajhiz As VB_Component.ComboBox
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخانجامDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامتحهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents دلیلکنسلیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmPmProgramBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Pm_PmProgramTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PmProgramTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents PmCancelCauseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_CancelCauseTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_CancelCauseTableAdapter
End Class
