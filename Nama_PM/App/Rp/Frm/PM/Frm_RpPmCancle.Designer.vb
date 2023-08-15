<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpPmCancle
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RpPmCancle))
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm1 = New Nama_PM.Ds_Pm
        Me.Post_Del = New System.Windows.Forms.PictureBox
        Me.Post_Add = New System.Windows.Forms.PictureBox
        Me.chk_AllFilter = New System.Windows.Forms.CheckBox
        Me.DGV_Filter = New CS_Component.DataGridView
        Me.Srl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_Filter = New System.Windows.Forms.Label
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.pl_Post = New System.Windows.Forms.Panel
        Me.pl_Tajhiz = New System.Windows.Forms.Panel
        Me.txt_TajhizNameForSave = New CS_Component.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.chk_allTajhiz = New System.Windows.Forms.CheckBox
        Me.btn_addTajhiz = New System.Windows.Forms.PictureBox
        Me.btn_delTajhiz = New System.Windows.Forms.PictureBox
        Me.btn_SelectTajhiz = New System.Windows.Forms.Button
        Me.Pm_PostTableAdapter1 = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.TestTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.testTableAdapter
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView2 = New CS_Component.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmb_CancleCause = New VB_Component.ComboBox
        Me.PmCancelCauseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_allCanlce = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_AddCancle = New System.Windows.Forms.PictureBox
        Me.btn_DelCancle = New System.Windows.Forms.PictureBox
        Me.Ds_Rp2 = New Nama_PM.Ds_Rp
        Me.RpPmCancleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_PmCancleTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_PmCancleTableAdapter
        Me.Pm_CancelCauseTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_CancelCauseTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Post_Del, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Post_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_Post.SuspendLayout()
        Me.pl_Tajhiz.SuspendLayout()
        CType(Me.btn_addTajhiz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delTajhiz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PmCancelCauseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_AddCancle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_DelCancle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpPmCancleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 436)
        Me.gbx_Buttons.Size = New System.Drawing.Size(775, 56)
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
        Me.btn_Save.Location = New System.Drawing.Point(671, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.pl_Post)
        Me.gbx_Fields.Controls.Add(Me.DataGridView1)
        Me.gbx_Fields.Controls.Add(Me.DataGridView2)
        Me.gbx_Fields.Controls.Add(Me.DGV_Filter)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Controls.Add(Me.pl_Tajhiz)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(775, 393)
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
        Me.txt_FromDate.Location = New System.Drawing.Point(508, 43)
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
        Me.Label17.Location = New System.Drawing.Point(671, 46)
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
        Me.txt_ToDate.Location = New System.Drawing.Point(509, 85)
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
        Me.Label1.Location = New System.Drawing.Point(673, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "تا تاریخ"
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
        Me.cmb_Post.Location = New System.Drawing.Point(135, 10)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(180, 26)
        Me.cmb_Post.TabIndex = 0
        Me.cmb_Post.ValueMember = "Srl"
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
        Me.Post_Del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Post_Del.Image = CType(resources.GetObject("Post_Del.Image"), System.Drawing.Image)
        Me.Post_Del.Location = New System.Drawing.Point(64, 8)
        Me.Post_Del.Name = "Post_Del"
        Me.Post_Del.Size = New System.Drawing.Size(33, 32)
        Me.Post_Del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Post_Del.TabIndex = 152
        Me.Post_Del.TabStop = False
        '
        'Post_Add
        '
        Me.Post_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Post_Add.Image = CType(resources.GetObject("Post_Add.Image"), System.Drawing.Image)
        Me.Post_Add.Location = New System.Drawing.Point(100, 8)
        Me.Post_Add.Name = "Post_Add"
        Me.Post_Add.Size = New System.Drawing.Size(30, 32)
        Me.Post_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Post_Add.TabIndex = 151
        Me.Post_Add.TabStop = False
        '
        'chk_AllFilter
        '
        Me.chk_AllFilter.AutoSize = True
        Me.chk_AllFilter.Location = New System.Drawing.Point(3, 16)
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Filter.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Filter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Filter.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Filter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Filter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Srl, Me.NameCol})
        Me.DGV_Filter.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Filter.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Filter.Location = New System.Drawing.Point(9, 257)
        Me.DGV_Filter.MultiSelect = False
        Me.DGV_Filter.Name = "DGV_Filter"
        Me.DGV_Filter.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Filter.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_Filter.RowHeadersWidth = 30
        Me.DGV_Filter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Filter.Size = New System.Drawing.Size(374, 128)
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
        Me.txt_Filter.Location = New System.Drawing.Point(321, 13)
        Me.txt_Filter.Name = "txt_Filter"
        Me.txt_Filter.Size = New System.Drawing.Size(42, 18)
        Me.txt_Filter.TabIndex = 153
        Me.txt_Filter.Text = "پست"
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
        Me.pl_Post.Controls.Add(Me.cmb_Post)
        Me.pl_Post.Controls.Add(Me.chk_AllFilter)
        Me.pl_Post.Controls.Add(Me.txt_Filter)
        Me.pl_Post.Controls.Add(Me.Post_Add)
        Me.pl_Post.Controls.Add(Me.Post_Del)
        Me.pl_Post.Location = New System.Drawing.Point(7, 201)
        Me.pl_Post.Name = "pl_Post"
        Me.pl_Post.Size = New System.Drawing.Size(374, 50)
        Me.pl_Post.TabIndex = 4
        '
        'pl_Tajhiz
        '
        Me.pl_Tajhiz.Controls.Add(Me.txt_TajhizNameForSave)
        Me.pl_Tajhiz.Controls.Add(Me.Label20)
        Me.pl_Tajhiz.Controls.Add(Me.chk_allTajhiz)
        Me.pl_Tajhiz.Controls.Add(Me.btn_addTajhiz)
        Me.pl_Tajhiz.Controls.Add(Me.btn_delTajhiz)
        Me.pl_Tajhiz.Controls.Add(Me.btn_SelectTajhiz)
        Me.pl_Tajhiz.Location = New System.Drawing.Point(387, 201)
        Me.pl_Tajhiz.Name = "pl_Tajhiz"
        Me.pl_Tajhiz.Size = New System.Drawing.Size(378, 50)
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
        Me.txt_TajhizNameForSave.Location = New System.Drawing.Point(173, 13)
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
        Me.Label20.Location = New System.Drawing.Point(312, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 18)
        Me.Label20.TabIndex = 1006
        Me.Label20.Text = "تجهیز"
        '
        'chk_allTajhiz
        '
        Me.chk_allTajhiz.AutoSize = True
        Me.chk_allTajhiz.Location = New System.Drawing.Point(4, 14)
        Me.chk_allTajhiz.Name = "chk_allTajhiz"
        Me.chk_allTajhiz.Size = New System.Drawing.Size(55, 22)
        Me.chk_allTajhiz.TabIndex = 150
        Me.chk_allTajhiz.Text = "همه"
        Me.chk_allTajhiz.UseVisualStyleBackColor = True
        '
        'btn_addTajhiz
        '
        Me.btn_addTajhiz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addTajhiz.Image = CType(resources.GetObject("btn_addTajhiz.Image"), System.Drawing.Image)
        Me.btn_addTajhiz.Location = New System.Drawing.Point(102, 7)
        Me.btn_addTajhiz.Name = "btn_addTajhiz"
        Me.btn_addTajhiz.Size = New System.Drawing.Size(32, 32)
        Me.btn_addTajhiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_addTajhiz.TabIndex = 151
        Me.btn_addTajhiz.TabStop = False
        '
        'btn_delTajhiz
        '
        Me.btn_delTajhiz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delTajhiz.Image = CType(resources.GetObject("btn_delTajhiz.Image"), System.Drawing.Image)
        Me.btn_delTajhiz.Location = New System.Drawing.Point(63, 7)
        Me.btn_delTajhiz.Name = "btn_delTajhiz"
        Me.btn_delTajhiz.Size = New System.Drawing.Size(33, 32)
        Me.btn_delTajhiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_delTajhiz.TabIndex = 152
        Me.btn_delTajhiz.TabStop = False
        '
        'btn_SelectTajhiz
        '
        Me.btn_SelectTajhiz.Location = New System.Drawing.Point(139, 14)
        Me.btn_SelectTajhiz.Name = "btn_SelectTajhiz"
        Me.btn_SelectTajhiz.Size = New System.Drawing.Size(31, 25)
        Me.btn_SelectTajhiz.TabIndex = 1004
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(391, 257)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(374, 128)
        Me.DataGridView1.TabIndex = 149
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "نام تجهیز"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Location = New System.Drawing.Point(2, 68)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.RowHeadersWidth = 30
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(374, 128)
        Me.DataGridView2.TabIndex = 149
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Srl"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "دلیل کنسلی"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_CancleCause)
        Me.Panel1.Controls.Add(Me.chk_allCanlce)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_AddCancle)
        Me.Panel1.Controls.Add(Me.btn_DelCancle)
        Me.Panel1.Location = New System.Drawing.Point(8, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 50)
        Me.Panel1.TabIndex = 2
        '
        'cmb_CancleCause
        '
        Me.cmb_CancleCause.AllowDrop = True
        Me.cmb_CancleCause.AutoComplete = True
        Me.cmb_CancleCause.DataSource = Me.PmCancelCauseBindingSource
        Me.cmb_CancleCause.DisplayMember = "نام"
        Me.cmb_CancleCause.EnterStop = True
        Me.cmb_CancleCause.FormattingEnabled = True
        Me.cmb_CancleCause.IsRequired = False
        Me.cmb_CancleCause.LimitedToList = False
        Me.cmb_CancleCause.Location = New System.Drawing.Point(135, 10)
        Me.cmb_CancleCause.Name = "cmb_CancleCause"
        Me.cmb_CancleCause.OpenOnFoucus = False
        Me.cmb_CancleCause.Size = New System.Drawing.Size(180, 26)
        Me.cmb_CancleCause.TabIndex = 0
        Me.cmb_CancleCause.ValueMember = "Srl"
        '
        'PmCancelCauseBindingSource
        '
        Me.PmCancelCauseBindingSource.DataMember = "Pm_CancelCause"
        Me.PmCancelCauseBindingSource.DataSource = Me.Ds_Pm1
        '
        'chk_allCanlce
        '
        Me.chk_allCanlce.AutoSize = True
        Me.chk_allCanlce.Location = New System.Drawing.Point(3, 16)
        Me.chk_allCanlce.Name = "chk_allCanlce"
        Me.chk_allCanlce.Size = New System.Drawing.Size(55, 22)
        Me.chk_allCanlce.TabIndex = 150
        Me.chk_allCanlce.Text = "همه"
        Me.chk_allCanlce.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "دلیل کنسلی"
        '
        'btn_AddCancle
        '
        Me.btn_AddCancle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AddCancle.Image = CType(resources.GetObject("btn_AddCancle.Image"), System.Drawing.Image)
        Me.btn_AddCancle.Location = New System.Drawing.Point(100, 8)
        Me.btn_AddCancle.Name = "btn_AddCancle"
        Me.btn_AddCancle.Size = New System.Drawing.Size(30, 32)
        Me.btn_AddCancle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_AddCancle.TabIndex = 151
        Me.btn_AddCancle.TabStop = False
        '
        'btn_DelCancle
        '
        Me.btn_DelCancle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_DelCancle.Image = CType(resources.GetObject("btn_DelCancle.Image"), System.Drawing.Image)
        Me.btn_DelCancle.Location = New System.Drawing.Point(64, 8)
        Me.btn_DelCancle.Name = "btn_DelCancle"
        Me.btn_DelCancle.Size = New System.Drawing.Size(33, 32)
        Me.btn_DelCancle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_DelCancle.TabIndex = 152
        Me.btn_DelCancle.TabStop = False
        '
        'Ds_Rp2
        '
        Me.Ds_Rp2.DataSetName = "Ds_Rp"
        Me.Ds_Rp2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RpPmCancleBindingSource
        '
        Me.RpPmCancleBindingSource.DataMember = "Rp_PmCancle"
        Me.RpPmCancleBindingSource.DataSource = Me.Ds_Rp2
        '
        'Rp_PmCancleTableAdapter
        '
        Me.Rp_PmCancleTableAdapter.ClearBeforeFill = True
        '
        'Pm_CancelCauseTableAdapter
        '
        Me.Pm_CancelCauseTableAdapter.ClearBeforeFill = True
        '
        'Frm_RpPmCancle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpPmCancle"
        Me.Text = "گزارش نموداری برنامه های پی ام"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Post_Del, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Post_Add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Filter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_Post.ResumeLayout(False)
        Me.pl_Post.PerformLayout()
        Me.pl_Tajhiz.ResumeLayout(False)
        Me.pl_Tajhiz.PerformLayout()
        CType(Me.btn_addTajhiz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delTajhiz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PmCancelCauseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_AddCancle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_DelCancle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpPmCancleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmb_Post As VB_Component.ComboBox
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
    Friend WithEvents pl_Tajhiz As System.Windows.Forms.Panel
    Friend WithEvents btn_SelectTajhiz As System.Windows.Forms.Button
    Friend WithEvents pl_Post As System.Windows.Forms.Panel
    Friend WithEvents txt_TajhizNameForSave As CS_Component.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chk_allTajhiz As System.Windows.Forms.CheckBox
    Friend WithEvents btn_addTajhiz As System.Windows.Forms.PictureBox
    Friend WithEvents btn_delTajhiz As System.Windows.Forms.PictureBox
    Friend WithEvents Ds_Pm1 As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter1 As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents TestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestTableAdapter As Nama_PM.Ds_HadeseTableAdapters.testTableAdapter
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_CancleCause As VB_Component.ComboBox
    Friend WithEvents chk_allCanlce As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_AddCancle As System.Windows.Forms.PictureBox
    Friend WithEvents btn_DelCancle As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As CS_Component.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ds_Rp2 As Nama_PM.Ds_Rp

    Friend WithEvents RpPmCancleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_PmCancleTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_PmCancleTableAdapter
    Friend WithEvents PmCancelCauseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_CancelCauseTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_CancelCauseTableAdapter
End Class
