<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PishnahadView
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbl_Record = New System.Windows.Forms.Label
        Me.Chk_AllPost = New System.Windows.Forms.CheckBox
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.chk_AllDate = New System.Windows.Forms.CheckBox
        Me.txt_EndPmdate = New CS_Component.TextBox
        Me.txt_StartPmDate = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.PmPishnahadVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Pm_PishnahadVwTableAdapter1 = New Nama_PM.Ds_PmTableAdapters.Pm_PishnahadVwTableAdapter
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.واحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.خطDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تجهیزDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.موضوعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.بازه = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پیشنهادDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPishnahadVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 511)
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 47)
        Me.GroupBox1.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_New, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Cancel, 0)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(750, 15)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(844, 15)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(938, 15)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Controls.Add(Me.GroupBox2)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(1035, 473)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lbl_Record)
        Me.GroupBox2.Controls.Add(Me.Chk_AllPost)
        Me.GroupBox2.Controls.Add(Me.cmb_Post)
        Me.GroupBox2.Controls.Add(Me.chk_AllDate)
        Me.GroupBox2.Controls.Add(Me.txt_EndPmdate)
        Me.GroupBox2.Controls.Add(Me.txt_StartPmDate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(194, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(738, 124)
        Me.GroupBox2.TabIndex = 218
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "فیلتر"
        '
        'Button1
        '
        Me.Button1.Image = Global.Nama_PM.My.Resources.Resources.refresh
        Me.Button1.Location = New System.Drawing.Point(64, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 43)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_Record
        '
        Me.lbl_Record.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.lbl_Record.AutoSize = True
        Me.lbl_Record.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Record.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_Record.Location = New System.Drawing.Point(263, 77)
        Me.lbl_Record.Name = "lbl_Record"
        Me.lbl_Record.Size = New System.Drawing.Size(86, 17)
        Me.lbl_Record.TabIndex = 12
        Me.lbl_Record.Text = "تعداد رکورد:"
        '
        'Chk_AllPost
        '
        Me.Chk_AllPost.AutoSize = True
        Me.Chk_AllPost.Location = New System.Drawing.Point(639, 72)
        Me.Chk_AllPost.Name = "Chk_AllPost"
        Me.Chk_AllPost.Size = New System.Drawing.Size(57, 20)
        Me.Chk_AllPost.TabIndex = 6
        Me.Chk_AllPost.Text = "پست"
        Me.Chk_AllPost.UseVisualStyleBackColor = True
        '
        'cmb_Post
        '
        Me.cmb_Post.AllowDrop = True
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PmPostBindingSource
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.Enabled = False
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = False
        Me.cmb_Post.Location = New System.Drawing.Point(451, 70)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(182, 24)
        Me.cmb_Post.TabIndex = 7
        Me.cmb_Post.Tag = ""
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
        'chk_AllDate
        '
        Me.chk_AllDate.AutoSize = True
        Me.chk_AllDate.Location = New System.Drawing.Point(606, 39)
        Me.chk_AllDate.Name = "chk_AllDate"
        Me.chk_AllDate.Size = New System.Drawing.Size(90, 20)
        Me.chk_AllDate.TabIndex = 0
        Me.chk_AllDate.Text = "تاریخ ثبت از"
        Me.chk_AllDate.UseVisualStyleBackColor = True
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
        Me.txt_EndPmdate.Location = New System.Drawing.Point(263, 36)
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
        'txt_StartPmDate
        '
        Me.txt_StartPmDate.CheckExistValueInDb = False
        Me.txt_StartPmDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_StartPmDate.CurrencyUnit = "ریال"
        Me.txt_StartPmDate.DefaultValue = ""
        Me.txt_StartPmDate.Enabled = False
        Me.txt_StartPmDate.FillWithMaxInDb = False
        Me.txt_StartPmDate.IsRequired = False
        Me.txt_StartPmDate.Location = New System.Drawing.Point(451, 36)
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
        Me.Label8.Location = New System.Drawing.Point(418, 40)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.شمارهDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.شمارهفرمDataGridViewTextBoxColumn, Me.واحدDataGridViewTextBoxColumn, Me.پستDataGridViewTextBoxColumn, Me.خطDataGridViewTextBoxColumn, Me.تجهیزDataGridViewTextBoxColumn, Me.موضوعDataGridViewTextBoxColumn, Me.بازه, Me.پیشنهادDataGridViewTextBoxColumn, Me.SrlDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmPishnahadVwBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 154)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1029, 316)
        Me.DataGridView1.TabIndex = 219
        '
        'PmPishnahadVwBindingSource
        '
        Me.PmPishnahadVwBindingSource.DataMember = "Pm_PishnahadVw"
        Me.PmPishnahadVwBindingSource.DataSource = Me.Ds_Pm
        '
        'DsPmBindingSource
        '
        Me.DsPmBindingSource.DataSource = Me.Ds_Pm
        Me.DsPmBindingSource.Position = 0
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PmPishnahadVwBindingSource
        Me.ComboBox1.DisplayMember = "شماره"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(536, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(8, 24)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "Srl"
        Me.ComboBox1.Visible = False
        '
        'Pm_PishnahadVwTableAdapter1
        '
        Me.Pm_PishnahadVwTableAdapter1.ClearBeforeFill = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ردیف"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 50
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.ReadOnly = True
        Me.شمارهDataGridViewTextBoxColumn.Width = 60
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        Me.تاریخDataGridViewTextBoxColumn.Width = 90
        '
        'شمارهفرمDataGridViewTextBoxColumn
        '
        Me.شمارهفرمDataGridViewTextBoxColumn.DataPropertyName = "شماره فرم"
        Me.شمارهفرمDataGridViewTextBoxColumn.HeaderText = "شماره فرم"
        Me.شمارهفرمDataGridViewTextBoxColumn.Name = "شمارهفرمDataGridViewTextBoxColumn"
        Me.شمارهفرمDataGridViewTextBoxColumn.ReadOnly = True
        Me.شمارهفرمDataGridViewTextBoxColumn.Width = 80
        '
        'واحدDataGridViewTextBoxColumn
        '
        Me.واحدDataGridViewTextBoxColumn.DataPropertyName = "واحد"
        Me.واحدDataGridViewTextBoxColumn.HeaderText = "واحد"
        Me.واحدDataGridViewTextBoxColumn.Name = "واحدDataGridViewTextBoxColumn"
        Me.واحدDataGridViewTextBoxColumn.ReadOnly = True
        Me.واحدDataGridViewTextBoxColumn.Width = 90
        '
        'پستDataGridViewTextBoxColumn
        '
        Me.پستDataGridViewTextBoxColumn.DataPropertyName = "پست"
        Me.پستDataGridViewTextBoxColumn.HeaderText = "پست"
        Me.پستDataGridViewTextBoxColumn.Name = "پستDataGridViewTextBoxColumn"
        Me.پستDataGridViewTextBoxColumn.ReadOnly = True
        '
        'خطDataGridViewTextBoxColumn
        '
        Me.خطDataGridViewTextBoxColumn.DataPropertyName = "خط"
        Me.خطDataGridViewTextBoxColumn.HeaderText = "خط"
        Me.خطDataGridViewTextBoxColumn.Name = "خطDataGridViewTextBoxColumn"
        Me.خطDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تجهیزDataGridViewTextBoxColumn
        '
        Me.تجهیزDataGridViewTextBoxColumn.DataPropertyName = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn.HeaderText = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn.Name = "تجهیزDataGridViewTextBoxColumn"
        Me.تجهیزDataGridViewTextBoxColumn.ReadOnly = True
        Me.تجهیزDataGridViewTextBoxColumn.Width = 90
        '
        'موضوعDataGridViewTextBoxColumn
        '
        Me.موضوعDataGridViewTextBoxColumn.DataPropertyName = "موضوع"
        Me.موضوعDataGridViewTextBoxColumn.HeaderText = "موضوع"
        Me.موضوعDataGridViewTextBoxColumn.Name = "موضوعDataGridViewTextBoxColumn"
        Me.موضوعDataGridViewTextBoxColumn.ReadOnly = True
        Me.موضوعDataGridViewTextBoxColumn.Width = 90
        '
        'بازه
        '
        Me.بازه.DataPropertyName = "بازه"
        Me.بازه.HeaderText = "بازه"
        Me.بازه.Name = "بازه"
        Me.بازه.ReadOnly = True
        Me.بازه.Width = 60
        '
        'پیشنهادDataGridViewTextBoxColumn
        '
        Me.پیشنهادDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.پیشنهادDataGridViewTextBoxColumn.DataPropertyName = "پیشنهاد"
        Me.پیشنهادDataGridViewTextBoxColumn.HeaderText = "پیشنهاد"
        Me.پیشنهادDataGridViewTextBoxColumn.Name = "پیشنهادDataGridViewTextBoxColumn"
        Me.پیشنهادDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'Frm_PishnahadView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 594)
        Me.Name = "Frm_PishnahadView"
        Me.Text = "نمایش پیشنهادات"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPishnahadVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Record As System.Windows.Forms.Label
    Friend WithEvents Chk_AllPost As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents chk_AllDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_EndPmdate As CS_Component.TextBox
    Friend WithEvents txt_StartPmDate As CS_Component.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_PishnahadVwTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PishnahadVwTableAdapter
    Friend WithEvents DsPmBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PmPishnahadVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PishnahadVwTableAdapter1 As Nama_PM.Ds_PmTableAdapters.Pm_PishnahadVwTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents خطDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تجهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents موضوعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents بازه As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پیشنهادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
