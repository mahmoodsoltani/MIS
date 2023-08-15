<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpPostPm
    Inherits BaseForm_Info_Single

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RpPostPm))
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rb_Do = New System.Windows.Forms.RadioButton
        Me.rb_Cancle = New System.Windows.Forms.RadioButton
        Me.rb_all = New System.Windows.Forms.RadioButton
        Me.rb_donDo = New System.Windows.Forms.RadioButton
        Me.cmb_Filter = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm1 = New Nama_PM.Ds_Pm
        Me.Post_Del = New System.Windows.Forms.PictureBox
        Me.Post_Add = New System.Windows.Forms.PictureBox
        Me.chk_AllFilter = New System.Windows.Forms.CheckBox
        Me.DGV_Filter = New CS_Component.DataGridView
        Me.Srl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_Filter = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_Post = New System.Windows.Forms.RadioButton
        Me.rb_Tajhiz = New System.Windows.Forms.RadioButton
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.pl_Post = New System.Windows.Forms.Panel
        Me.pl_Tajhiz = New System.Windows.Forms.Panel
        Me.txt_TajhizNameForSave = New CS_Component.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.chk_allTajhiz = New System.Windows.Forms.CheckBox
        Me.btn_add = New System.Windows.Forms.PictureBox
        Me.btn_del = New System.Windows.Forms.PictureBox
        Me.btn_SelectTajhiz = New System.Windows.Forms.Button
        Me.Pm_PostTableAdapter1 = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.TestTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.testTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Post_Del, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Post_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_Post.SuspendLayout()
        Me.pl_Tajhiz.SuspendLayout()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_del, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 419)
        Me.gbx_Buttons.Size = New System.Drawing.Size(485, 56)
        Me.gbx_Buttons.TabIndex = 1
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(381, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.GroupBox1)
        Me.gbx_Fields.Controls.Add(Me.DGV_Filter)
        Me.gbx_Fields.Controls.Add(Me.Panel2)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Controls.Add(Me.pl_Tajhiz)
        Me.gbx_Fields.Controls.Add(Me.pl_Post)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(485, 376)
        Me.gbx_Fields.TabIndex = 0
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(257, 22)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(148, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 0
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(420, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 18)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "از تاریخ"
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(22, 22)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(148, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 1
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "تا تاریخ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "مرتب سازی بر اساس:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_Do)
        Me.Panel2.Controls.Add(Me.rb_Cancle)
        Me.Panel2.Controls.Add(Me.rb_all)
        Me.Panel2.Controls.Add(Me.rb_donDo)
        Me.Panel2.Location = New System.Drawing.Point(15, 330)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 36)
        Me.Panel2.TabIndex = 4
        '
        'rb_Do
        '
        Me.rb_Do.AutoSize = True
        Me.rb_Do.Location = New System.Drawing.Point(353, 8)
        Me.rb_Do.Name = "rb_Do"
        Me.rb_Do.Size = New System.Drawing.Size(92, 22)
        Me.rb_Do.TabIndex = 0
        Me.rb_Do.TabStop = True
        Me.rb_Do.Text = "انجام شده"
        Me.rb_Do.UseVisualStyleBackColor = True
        '
        'rb_Cancle
        '
        Me.rb_Cancle.AutoSize = True
        Me.rb_Cancle.Location = New System.Drawing.Point(240, 8)
        Me.rb_Cancle.Name = "rb_Cancle"
        Me.rb_Cancle.Size = New System.Drawing.Size(100, 22)
        Me.rb_Cancle.TabIndex = 1
        Me.rb_Cancle.TabStop = True
        Me.rb_Cancle.Text = "کنسل شده"
        Me.rb_Cancle.UseVisualStyleBackColor = True
        '
        'rb_all
        '
        Me.rb_all.AutoSize = True
        Me.rb_all.Location = New System.Drawing.Point(77, 8)
        Me.rb_all.Name = "rb_all"
        Me.rb_all.Size = New System.Drawing.Size(54, 22)
        Me.rb_all.TabIndex = 3
        Me.rb_all.TabStop = True
        Me.rb_all.Text = "همه"
        Me.rb_all.UseVisualStyleBackColor = True
        '
        'rb_donDo
        '
        Me.rb_donDo.AutoSize = True
        Me.rb_donDo.Location = New System.Drawing.Point(137, 8)
        Me.rb_donDo.Name = "rb_donDo"
        Me.rb_donDo.Size = New System.Drawing.Size(97, 22)
        Me.rb_donDo.TabIndex = 2
        Me.rb_donDo.TabStop = True
        Me.rb_donDo.Text = "انجام نشده"
        Me.rb_donDo.UseVisualStyleBackColor = True
        '
        'cmb_Filter
        '
        Me.cmb_Filter.AllowDrop = True
        Me.cmb_Filter.AutoComplete = True
        Me.cmb_Filter.DataSource = Me.PmPostBindingSource
        Me.cmb_Filter.DisplayMember = "نام پست"
        Me.cmb_Filter.EnterStop = True
        Me.cmb_Filter.FormattingEnabled = True
        Me.cmb_Filter.IsRequired = False
        Me.cmb_Filter.LimitedToList = False
        Me.cmb_Filter.Location = New System.Drawing.Point(205, 14)
        Me.cmb_Filter.Name = "cmb_Filter"
        Me.cmb_Filter.OpenOnFoucus = False
        Me.cmb_Filter.Size = New System.Drawing.Size(180, 26)
        Me.cmb_Filter.TabIndex = 148
        Me.cmb_Filter.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm1
        '
        'Ds_Pm1
        '
        Me.Ds_Pm1.DataSetName = "Ds_Pm"
        Me.Ds_Pm1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Post_Del
        '
        Me.Post_Del.Image = CType(resources.GetObject("Post_Del.Image"), System.Drawing.Image)
        Me.Post_Del.Location = New System.Drawing.Point(88, 4)
        Me.Post_Del.Name = "Post_Del"
        Me.Post_Del.Size = New System.Drawing.Size(47, 43)
        Me.Post_Del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Post_Del.TabIndex = 152
        Me.Post_Del.TabStop = False
        '
        'Post_Add
        '
        Me.Post_Add.Image = CType(resources.GetObject("Post_Add.Image"), System.Drawing.Image)
        Me.Post_Add.Location = New System.Drawing.Point(138, 4)
        Me.Post_Add.Name = "Post_Add"
        Me.Post_Add.Size = New System.Drawing.Size(47, 43)
        Me.Post_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Post_Add.TabIndex = 151
        Me.Post_Add.TabStop = False
        '
        'chk_AllFilter
        '
        Me.chk_AllFilter.AutoSize = True
        Me.chk_AllFilter.Location = New System.Drawing.Point(27, 14)
        Me.chk_AllFilter.Name = "chk_AllFilter"
        Me.chk_AllFilter.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllFilter.TabIndex = 150
        Me.chk_AllFilter.Text = "همه"
        Me.chk_AllFilter.UseVisualStyleBackColor = True
        '
        'DGV_Filter
        '
        Me.DGV_Filter.AllowUserToAddRows = False
        Me.DGV_Filter.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Filter.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Filter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Filter.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Filter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Filter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Srl, Me.NameCol})
        Me.DGV_Filter.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Filter.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Filter.Location = New System.Drawing.Point(20, 174)
        Me.DGV_Filter.MultiSelect = False
        Me.DGV_Filter.Name = "DGV_Filter"
        Me.DGV_Filter.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Filter.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Filter.RowHeadersWidth = 30
        Me.DGV_Filter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Filter.Size = New System.Drawing.Size(450, 129)
        Me.DGV_Filter.TabIndex = 149
        '
        'Srl
        '
        Me.Srl.HeaderText = "Srl"
        Me.Srl.Name = "Srl"
        Me.Srl.ReadOnly = True
        Me.Srl.Visible = False
        '
        'NameCol
        '
        Me.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameCol.HeaderText = "نام پست"
        Me.NameCol.Name = "NameCol"
        Me.NameCol.ReadOnly = True
        '
        'txt_Filter
        '
        Me.txt_Filter.AutoSize = True
        Me.txt_Filter.Location = New System.Drawing.Point(394, 18)
        Me.txt_Filter.Name = "txt_Filter"
        Me.txt_Filter.Size = New System.Drawing.Size(42, 18)
        Me.txt_Filter.TabIndex = 153
        Me.txt_Filter.Text = "پست"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_Post)
        Me.GroupBox1.Controls.Add(Me.rb_Tajhiz)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 58)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "گزارش بر اساس"
        '
        'rb_Post
        '
        Me.rb_Post.AutoSize = True
        Me.rb_Post.Checked = True
        Me.rb_Post.Location = New System.Drawing.Point(237, 25)
        Me.rb_Post.Name = "rb_Post"
        Me.rb_Post.Size = New System.Drawing.Size(60, 22)
        Me.rb_Post.TabIndex = 0
        Me.rb_Post.TabStop = True
        Me.rb_Post.Text = "پست"
        Me.rb_Post.UseVisualStyleBackColor = True
        '
        'rb_Tajhiz
        '
        Me.rb_Tajhiz.AutoSize = True
        Me.rb_Tajhiz.Location = New System.Drawing.Point(124, 25)
        Me.rb_Tajhiz.Name = "rb_Tajhiz"
        Me.rb_Tajhiz.Size = New System.Drawing.Size(59, 22)
        Me.rb_Tajhiz.TabIndex = 9
        Me.rb_Tajhiz.Text = "تجهیز"
        Me.rb_Tajhiz.UseVisualStyleBackColor = True
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataMember = "test"
        Me.TestBindingSource.DataSource = Me.Ds_Hadese
        '
        'Ds_Hadese
        '
        Me.Ds_Hadese.DataSetName = "Ds_Hadese"
        Me.Ds_Hadese.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pl_Post
        '
        Me.pl_Post.Controls.Add(Me.cmb_Filter)
        Me.pl_Post.Controls.Add(Me.chk_AllFilter)
        Me.pl_Post.Controls.Add(Me.txt_Filter)
        Me.pl_Post.Controls.Add(Me.Post_Add)
        Me.pl_Post.Controls.Add(Me.Post_Del)
        Me.pl_Post.Location = New System.Drawing.Point(20, 122)
        Me.pl_Post.Name = "pl_Post"
        Me.pl_Post.Size = New System.Drawing.Size(450, 50)
        Me.pl_Post.TabIndex = 155
        '
        'pl_Tajhiz
        '
        Me.pl_Tajhiz.Controls.Add(Me.txt_TajhizNameForSave)
        Me.pl_Tajhiz.Controls.Add(Me.Label20)
        Me.pl_Tajhiz.Controls.Add(Me.chk_allTajhiz)
        Me.pl_Tajhiz.Controls.Add(Me.btn_add)
        Me.pl_Tajhiz.Controls.Add(Me.btn_del)
        Me.pl_Tajhiz.Controls.Add(Me.btn_SelectTajhiz)
        Me.pl_Tajhiz.Location = New System.Drawing.Point(20, 122)
        Me.pl_Tajhiz.Name = "pl_Tajhiz"
        Me.pl_Tajhiz.Size = New System.Drawing.Size(450, 50)
        Me.pl_Tajhiz.TabIndex = 3
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
        Me.txt_TajhizNameForSave.Location = New System.Drawing.Point(241, 12)
        Me.txt_TajhizNameForSave.MaxDecimalLength = 2
        Me.txt_TajhizNameForSave.Name = "txt_TajhizNameForSave"
        Me.txt_TajhizNameForSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TajhizNameForSave.Size = New System.Drawing.Size(133, 26)
        Me.txt_TajhizNameForSave.SpellControl = Nothing
        Me.txt_TajhizNameForSave.TabIndex = 0
        Me.txt_TajhizNameForSave.Tag = ""
        Me.txt_TajhizNameForSave.Title = Nothing
        Me.txt_TajhizNameForSave.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TajhizNameForSave.UseForData = True
        Me.txt_TajhizNameForSave.ValidateCheckExistOnEdit = False
        Me.txt_TajhizNameForSave.Value = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(380, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 18)
        Me.Label20.TabIndex = 1006
        Me.Label20.Text = "تجهیز"
        '
        'chk_allTajhiz
        '
        Me.chk_allTajhiz.AutoSize = True
        Me.chk_allTajhiz.Location = New System.Drawing.Point(27, 14)
        Me.chk_allTajhiz.Name = "chk_allTajhiz"
        Me.chk_allTajhiz.Size = New System.Drawing.Size(55, 22)
        Me.chk_allTajhiz.TabIndex = 150
        Me.chk_allTajhiz.Text = "همه"
        Me.chk_allTajhiz.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(138, 4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(47, 43)
        Me.btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_add.TabIndex = 151
        Me.btn_add.TabStop = False
        '
        'btn_del
        '
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.Location = New System.Drawing.Point(88, 4)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(47, 43)
        Me.btn_del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_del.TabIndex = 152
        Me.btn_del.TabStop = False
        '
        'btn_SelectTajhiz
        '
        Me.btn_SelectTajhiz.Location = New System.Drawing.Point(207, 13)
        Me.btn_SelectTajhiz.Name = "btn_SelectTajhiz"
        Me.btn_SelectTajhiz.Size = New System.Drawing.Size(31, 25)
        Me.btn_SelectTajhiz.TabIndex = 1
        Me.btn_SelectTajhiz.Text = "..."
        Me.btn_SelectTajhiz.UseVisualStyleBackColor = True
        '
        'Pm_PostTableAdapter1
        '
        Me.Pm_PostTableAdapter1.ClearBeforeFill = True
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        'Frm_RpPostPm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(510, 512)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpPostPm"
        Me.Text = "گزارش نموداری برنامه های پی ام"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Post_Del, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Post_Add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Filter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_Post.ResumeLayout(False)
        Me.pl_Post.PerformLayout()
        Me.pl_Tajhiz.ResumeLayout(False)
        Me.pl_Tajhiz.PerformLayout()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_del, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents Rp_GroupEibFormTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_GroupEibFormTableAdapter
    Friend WithEvents Rp_VahedEibFormTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_VahedEibFormTableAdapter
    Friend WithEvents Rp_EibTypeEibFormTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_EibTypeEibFormTableAdapter
    Friend WithEvents Ds_Rp1 As Nama_PM.Ds_Rp
    Friend WithEvents Rp_PostEibformTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_PostEibformTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_Do As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Cancle As System.Windows.Forms.RadioButton
    Friend WithEvents rb_donDo As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Filter As VB_Component.ComboBox
    Friend WithEvents Post_Del As System.Windows.Forms.PictureBox
    Friend WithEvents Post_Add As System.Windows.Forms.PictureBox
    Friend WithEvents chk_AllFilter As System.Windows.Forms.CheckBox
    Friend WithEvents DGV_Filter As CS_Component.DataGridView
    Friend WithEvents Srl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_Filter As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents Pm_EibTypeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_EibTypeTableAdapter
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents rb_all As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Post As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Tajhiz As System.Windows.Forms.RadioButton
    Friend WithEvents pl_Tajhiz As System.Windows.Forms.Panel
    Friend WithEvents btn_SelectTajhiz As System.Windows.Forms.Button
    Friend WithEvents pl_Post As System.Windows.Forms.Panel
    Friend WithEvents txt_TajhizNameForSave As CS_Component.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chk_allTajhiz As System.Windows.Forms.CheckBox
    Friend WithEvents btn_add As System.Windows.Forms.PictureBox
    Friend WithEvents btn_del As System.Windows.Forms.PictureBox
    Friend WithEvents Ds_Pm1 As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter1 As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents TestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestTableAdapter As Nama_PM.Ds_HadeseTableAdapters.testTableAdapter
End Class
