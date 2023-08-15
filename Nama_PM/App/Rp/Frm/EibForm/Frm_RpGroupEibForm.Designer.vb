<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpGeoupEibForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RpGeoupEibForm))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rb_Group = New System.Windows.Forms.RadioButton
        Me.rb_Vahed = New System.Windows.Forms.RadioButton
        Me.rb_eib = New System.Windows.Forms.RadioButton
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.RpGroupEibFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_GroupEibFormTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_GroupEibFormTableAdapter
        Me.RpVahedEibFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_VahedEibFormTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_VahedEibFormTableAdapter
        Me.RpEibTypeEibFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_EibTypeEibFormTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_EibTypeEibFormTableAdapter
        Me.rb_Post = New System.Windows.Forms.RadioButton
        Me.Ds_Rp1 = New Nama_PM.Ds_Rp
        Me.RpPostEibformBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_PostEibformTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_PostEibformTableAdapter
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rb_Fixed = New System.Windows.Forms.RadioButton
        Me.rb_NoFixed = New System.Windows.Forms.RadioButton
        Me.rb_All = New System.Windows.Forms.RadioButton
        Me.cmb_Filter = New VB_Component.ComboBox
        Me.PmEibTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Post_Del = New System.Windows.Forms.PictureBox
        Me.Post_Add = New System.Windows.Forms.PictureBox
        Me.chk_AllFilter = New System.Windows.Forms.CheckBox
        Me.DGV_Filter = New CS_Component.DataGridView
        Me.Srl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_Filter = New System.Windows.Forms.Label
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_EibTypeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_EibTypeTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.chk_Peiro = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpGroupEibFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpVahedEibFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpEibTypeEibFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpPostEibformBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PmEibTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Post_Del, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Post_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Controls.Add(Me.Button1)
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 419)
        Me.gbx_Buttons.Size = New System.Drawing.Size(485, 56)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.Button1, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Save, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Cancel, 0)
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
        Me.gbx_Fields.Controls.Add(Me.txt_Filter)
        Me.gbx_Fields.Controls.Add(Me.cmb_Filter)
        Me.gbx_Fields.Controls.Add(Me.Post_Del)
        Me.gbx_Fields.Controls.Add(Me.Post_Add)
        Me.gbx_Fields.Controls.Add(Me.chk_Peiro)
        Me.gbx_Fields.Controls.Add(Me.chk_AllFilter)
        Me.gbx_Fields.Controls.Add(Me.DGV_Filter)
        Me.gbx_Fields.Controls.Add(Me.Panel2)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(485, 376)
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
        Me.txt_FromDate.TabIndex = 7
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
        Me.txt_ToDate.TabIndex = 7
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "گزارش بر اساس:"
        '
        'rb_Group
        '
        Me.rb_Group.AutoSize = True
        Me.rb_Group.Location = New System.Drawing.Point(367, 8)
        Me.rb_Group.Name = "rb_Group"
        Me.rb_Group.Size = New System.Drawing.Size(67, 22)
        Me.rb_Group.TabIndex = 9
        Me.rb_Group.TabStop = True
        Me.rb_Group.Text = "گروهها"
        Me.rb_Group.UseVisualStyleBackColor = True
        '
        'rb_Vahed
        '
        Me.rb_Vahed.AutoSize = True
        Me.rb_Vahed.Location = New System.Drawing.Point(257, 8)
        Me.rb_Vahed.Name = "rb_Vahed"
        Me.rb_Vahed.Size = New System.Drawing.Size(68, 22)
        Me.rb_Vahed.TabIndex = 9
        Me.rb_Vahed.TabStop = True
        Me.rb_Vahed.Text = "واحدها"
        Me.rb_Vahed.UseVisualStyleBackColor = True
        '
        'rb_eib
        '
        Me.rb_eib.AutoSize = True
        Me.rb_eib.Location = New System.Drawing.Point(149, 8)
        Me.rb_eib.Name = "rb_eib"
        Me.rb_eib.Size = New System.Drawing.Size(73, 22)
        Me.rb_eib.TabIndex = 9
        Me.rb_eib.TabStop = True
        Me.rb_eib.Text = "عیب ها"
        Me.rb_eib.UseVisualStyleBackColor = True
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RpGroupEibFormBindingSource
        '
        Me.RpGroupEibFormBindingSource.DataMember = "Rp_GroupEibForm"
        Me.RpGroupEibFormBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_GroupEibFormTableAdapter
        '
        Me.Rp_GroupEibFormTableAdapter.ClearBeforeFill = True
        '
        'RpVahedEibFormBindingSource
        '
        Me.RpVahedEibFormBindingSource.DataMember = "Rp_VahedEibForm"
        Me.RpVahedEibFormBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_VahedEibFormTableAdapter
        '
        Me.Rp_VahedEibFormTableAdapter.ClearBeforeFill = True
        '
        'RpEibTypeEibFormBindingSource
        '
        Me.RpEibTypeEibFormBindingSource.DataMember = "Rp_EibTypeEibForm"
        Me.RpEibTypeEibFormBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_EibTypeEibFormTableAdapter
        '
        Me.Rp_EibTypeEibFormTableAdapter.ClearBeforeFill = True
        '
        'rb_Post
        '
        Me.rb_Post.AutoSize = True
        Me.rb_Post.Location = New System.Drawing.Point(49, 8)
        Me.rb_Post.Name = "rb_Post"
        Me.rb_Post.Size = New System.Drawing.Size(79, 22)
        Me.rb_Post.TabIndex = 9
        Me.rb_Post.TabStop = True
        Me.rb_Post.Text = "پست ها"
        Me.rb_Post.UseVisualStyleBackColor = True
        '
        'Ds_Rp1
        '
        Me.Ds_Rp1.DataSetName = "Ds_Rp"
        Me.Ds_Rp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RpPostEibformBindingSource
        '
        Me.RpPostEibformBindingSource.DataMember = "Rp_PostEibform"
        Me.RpPostEibformBindingSource.DataSource = Me.Ds_Rp1
        '
        'Rp_PostEibformTableAdapter
        '
        Me.Rp_PostEibformTableAdapter.ClearBeforeFill = True
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_Group)
        Me.Panel1.Controls.Add(Me.rb_Post)
        Me.Panel1.Controls.Add(Me.rb_Vahed)
        Me.Panel1.Controls.Add(Me.rb_eib)
        Me.Panel1.Location = New System.Drawing.Point(17, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 36)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_Fixed)
        Me.Panel2.Controls.Add(Me.rb_NoFixed)
        Me.Panel2.Controls.Add(Me.rb_All)
        Me.Panel2.Location = New System.Drawing.Point(15, 330)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 36)
        Me.Panel2.TabIndex = 10
        '
        'rb_Fixed
        '
        Me.rb_Fixed.AutoSize = True
        Me.rb_Fixed.Location = New System.Drawing.Point(353, 8)
        Me.rb_Fixed.Name = "rb_Fixed"
        Me.rb_Fixed.Size = New System.Drawing.Size(81, 22)
        Me.rb_Fixed.TabIndex = 9
        Me.rb_Fixed.TabStop = True
        Me.rb_Fixed.Text = "رفع شده"
        Me.rb_Fixed.UseVisualStyleBackColor = True
        '
        'rb_NoFixed
        '
        Me.rb_NoFixed.AutoSize = True
        Me.rb_NoFixed.Location = New System.Drawing.Point(240, 8)
        Me.rb_NoFixed.Name = "rb_NoFixed"
        Me.rb_NoFixed.Size = New System.Drawing.Size(86, 22)
        Me.rb_NoFixed.TabIndex = 9
        Me.rb_NoFixed.TabStop = True
        Me.rb_NoFixed.Text = "رفع نشده"
        Me.rb_NoFixed.UseVisualStyleBackColor = True
        '
        'rb_All
        '
        Me.rb_All.AutoSize = True
        Me.rb_All.Location = New System.Drawing.Point(168, 8)
        Me.rb_All.Name = "rb_All"
        Me.rb_All.Size = New System.Drawing.Size(54, 22)
        Me.rb_All.TabIndex = 9
        Me.rb_All.TabStop = True
        Me.rb_All.Text = "همه"
        Me.rb_All.UseVisualStyleBackColor = True
        '
        'cmb_Filter
        '
        Me.cmb_Filter.AllowDrop = True
        Me.cmb_Filter.AutoComplete = True
        Me.cmb_Filter.DataSource = Me.PmEibTypeBindingSource
        Me.cmb_Filter.DisplayMember = "نام"
        Me.cmb_Filter.EnterStop = True
        Me.cmb_Filter.FormattingEnabled = True
        Me.cmb_Filter.IsRequired = False
        Me.cmb_Filter.LimitedToList = False
        Me.cmb_Filter.Location = New System.Drawing.Point(225, 136)
        Me.cmb_Filter.Name = "cmb_Filter"
        Me.cmb_Filter.OpenOnFoucus = False
        Me.cmb_Filter.Size = New System.Drawing.Size(180, 26)
        Me.cmb_Filter.TabIndex = 148
        Me.cmb_Filter.ValueMember = "Srl"
        '
        'PmEibTypeBindingSource
        '
        Me.PmEibTypeBindingSource.DataMember = "Pm_EibType"
        Me.PmEibTypeBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Post_Del
        '
        Me.Post_Del.Image = CType(resources.GetObject("Post_Del.Image"), System.Drawing.Image)
        Me.Post_Del.Location = New System.Drawing.Point(108, 126)
        Me.Post_Del.Name = "Post_Del"
        Me.Post_Del.Size = New System.Drawing.Size(47, 43)
        Me.Post_Del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Post_Del.TabIndex = 152
        Me.Post_Del.TabStop = False
        '
        'Post_Add
        '
        Me.Post_Add.Image = CType(resources.GetObject("Post_Add.Image"), System.Drawing.Image)
        Me.Post_Add.Location = New System.Drawing.Point(158, 126)
        Me.Post_Add.Name = "Post_Add"
        Me.Post_Add.Size = New System.Drawing.Size(47, 43)
        Me.Post_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Post_Add.TabIndex = 151
        Me.Post_Add.TabStop = False
        '
        'chk_AllFilter
        '
        Me.chk_AllFilter.AutoSize = True
        Me.chk_AllFilter.Location = New System.Drawing.Point(47, 136)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Filter.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Filter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Filter.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Filter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Filter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Srl, Me.NameCol})
        Me.DGV_Filter.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Filter.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Filter.Location = New System.Drawing.Point(17, 174)
        Me.DGV_Filter.MultiSelect = False
        Me.DGV_Filter.Name = "DGV_Filter"
        Me.DGV_Filter.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Filter.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
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
        Me.txt_Filter.Location = New System.Drawing.Point(414, 140)
        Me.txt_Filter.Name = "txt_Filter"
        Me.txt_Filter.Size = New System.Drawing.Size(34, 18)
        Me.txt_Filter.TabIndex = 153
        Me.txt_Filter.Text = "گروه"
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_EibTypeTableAdapter
        '
        Me.Pm_EibTypeTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'chk_Peiro
        '
        Me.chk_Peiro.AutoSize = True
        Me.chk_Peiro.Location = New System.Drawing.Point(22, 57)
        Me.chk_Peiro.Name = "chk_Peiro"
        Me.chk_Peiro.Size = New System.Drawing.Size(93, 22)
        Me.chk_Peiro.TabIndex = 150
        Me.chk_Peiro.Text = "نمایش پیرو"
        Me.chk_Peiro.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(260, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "خروجی اکسل"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_RpGeoupEibForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(510, 512)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpGeoupEibForm"
        Me.Text = "گزارش نموداری فرم نقص ها"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpGroupEibFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpVahedEibFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpEibTypeEibFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpPostEibformBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PmEibTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Post_Del, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Post_Add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Filter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents RpGroupEibFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_GroupEibFormTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_GroupEibFormTableAdapter
    Friend WithEvents rb_eib As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Vahed As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Group As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RpVahedEibFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_VahedEibFormTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_VahedEibFormTableAdapter
    Friend WithEvents RpEibTypeEibFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_EibTypeEibFormTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_EibTypeEibFormTableAdapter
    Friend WithEvents rb_Post As System.Windows.Forms.RadioButton
    Friend WithEvents Ds_Rp1 As Nama_PM.Ds_Rp
    Friend WithEvents RpPostEibformBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_PostEibformTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_PostEibformTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_Fixed As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NoFixed As System.Windows.Forms.RadioButton
    Friend WithEvents rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmEibTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_EibTypeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_EibTypeTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents chk_Peiro As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
