<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_StatusStatement
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Cmb_Vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.rb_pm = New System.Windows.Forms.RadioButton
        Me.rb_Mazad = New System.Windows.Forms.RadioButton
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.cmb_Contract = New VB_Component.ComboBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.Label2 = New System.Windows.Forms.Label
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.cmb_Line = New VB_Component.ComboBox
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.chk_Date = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rb_allPOrM = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rb_allWandNW = New System.Windows.Forms.RadioButton
        Me.rb_WorkForm = New System.Windows.Forms.RadioButton
        Me.rb_WithoutWorkForm = New System.Windows.Forms.RadioButton
        Me.PostOrKhat = New System.Windows.Forms.CheckBox
        Me.PmConRpRemainedItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_Rp_RemainedItemTableAdapter = New Nama_PM.Ds_ConTableAdapters.pm_Con_Rp_RemainedItemTableAdapter
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.ItemcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DoAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.rp = New System.Windows.Forms.Button
        Me.chkbx_Star = New System.Windows.Forms.CheckBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PmConRpRemainedItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Controls.Add(Me.rp)
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 173)
        Me.gbx_Buttons.Size = New System.Drawing.Size(850, 52)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.rp, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Save, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Cancel, 0)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 15)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(746, 15)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.chkbx_Star)
        Me.gbx_Fields.Controls.Add(Me.Panel2)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.cmb_Line)
        Me.gbx_Fields.Controls.Add(Me.Cmb_Post)
        Me.gbx_Fields.Controls.Add(Me.PostOrKhat)
        Me.gbx_Fields.Controls.Add(Me.chk_Date)
        Me.gbx_Fields.Controls.Add(Me.cmb_Contract)
        Me.gbx_Fields.Controls.Add(Me.Cmb_Vahed)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(850, 126)
        '
        'Cmb_Vahed
        '
        Me.Cmb_Vahed.AutoComplete = True
        Me.Cmb_Vahed.DataSource = Me.PmVahedBindingSource
        Me.Cmb_Vahed.DisplayMember = "نام واحد"
        Me.Cmb_Vahed.EnterStop = True
        Me.Cmb_Vahed.FormattingEnabled = True
        Me.Cmb_Vahed.IsRequired = False
        Me.Cmb_Vahed.LimitedToList = True
        Me.Cmb_Vahed.Location = New System.Drawing.Point(543, 50)
        Me.Cmb_Vahed.Name = "Cmb_Vahed"
        Me.Cmb_Vahed.OpenOnFoucus = True
        Me.Cmb_Vahed.Size = New System.Drawing.Size(214, 26)
        Me.Cmb_Vahed.TabIndex = 161
        Me.Cmb_Vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(542, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "تا تاریخ"
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(390, 87)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(139, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 153
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(598, 86)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(157, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 152
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'rb_pm
        '
        Me.rb_pm.AutoSize = True
        Me.rb_pm.Location = New System.Drawing.Point(140, 3)
        Me.rb_pm.Name = "rb_pm"
        Me.rb_pm.Size = New System.Drawing.Size(63, 22)
        Me.rb_pm.TabIndex = 163
        Me.rb_pm.Text = "پی ام"
        Me.rb_pm.UseVisualStyleBackColor = True
        '
        'rb_Mazad
        '
        Me.rb_Mazad.AutoSize = True
        Me.rb_Mazad.Location = New System.Drawing.Point(58, 3)
        Me.rb_Mazad.Name = "rb_Mazad"
        Me.rb_Mazad.Size = New System.Drawing.Size(75, 22)
        Me.rb_Mazad.TabIndex = 163
        Me.rb_Mazad.Text = "کار مازاد"
        Me.rb_Mazad.UseVisualStyleBackColor = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'cmb_Contract
        '
        Me.cmb_Contract.AutoComplete = True
        Me.cmb_Contract.DataSource = Me.PmConContractBindingSource
        Me.cmb_Contract.DisplayMember = "عنوان"
        Me.cmb_Contract.EnterStop = True
        Me.cmb_Contract.FormattingEnabled = True
        Me.cmb_Contract.IsRequired = False
        Me.cmb_Contract.LimitedToList = True
        Me.cmb_Contract.Location = New System.Drawing.Point(543, 20)
        Me.cmb_Contract.Name = "cmb_Contract"
        Me.cmb_Contract.OpenOnFoucus = True
        Me.cmb_Contract.Size = New System.Drawing.Size(214, 26)
        Me.cmb_Contract.TabIndex = 161
        Me.cmb_Contract.ValueMember = "Srl"
        '
        'PmConContractBindingSource
        '
        Me.PmConContractBindingSource.DataMember = "Pm_Con_Contract"
        Me.PmConContractBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(770, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "قرارداد"
        '
        'Pm_Con_ContractTableAdapter
        '
        Me.Pm_Con_ContractTableAdapter.ClearBeforeFill = True
        '
        'cmb_Line
        '
        Me.cmb_Line.AutoComplete = True
        Me.cmb_Line.DataSource = Me.PmLineBindingSource
        Me.cmb_Line.DisplayMember = "نام"
        Me.cmb_Line.EnterStop = True
        Me.cmb_Line.FormattingEnabled = True
        Me.cmb_Line.IsRequired = False
        Me.cmb_Line.LimitedToList = True
        Me.cmb_Line.Location = New System.Drawing.Point(292, 18)
        Me.cmb_Line.Name = "cmb_Line"
        Me.cmb_Line.OpenOnFoucus = True
        Me.cmb_Line.Size = New System.Drawing.Size(165, 26)
        Me.cmb_Line.TabIndex = 165
        Me.cmb_Line.ValueMember = "Srl"
        '
        'PmLineBindingSource
        '
        Me.PmLineBindingSource.DataMember = "Pm_Line"
        Me.PmLineBindingSource.DataSource = Me.Ds_Pm
        '
        'Cmb_Post
        '
        Me.Cmb_Post.AutoComplete = True
        Me.Cmb_Post.DataSource = Me.PmPostBindingSource
        Me.Cmb_Post.DisplayMember = "نام پست"
        Me.Cmb_Post.EnterStop = True
        Me.Cmb_Post.FormattingEnabled = True
        Me.Cmb_Post.IsRequired = False
        Me.Cmb_Post.LimitedToList = True
        Me.Cmb_Post.Location = New System.Drawing.Point(292, 18)
        Me.Cmb_Post.Name = "Cmb_Post"
        Me.Cmb_Post.OpenOnFoucus = True
        Me.Cmb_Post.Size = New System.Drawing.Size(165, 26)
        Me.Cmb_Post.TabIndex = 164
        Me.Cmb_Post.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'chk_Date
        '
        Me.chk_Date.AutoSize = True
        Me.chk_Date.Location = New System.Drawing.Point(761, 88)
        Me.chk_Date.Name = "chk_Date"
        Me.chk_Date.Size = New System.Drawing.Size(69, 22)
        Me.chk_Date.TabIndex = 162
        Me.chk_Date.Text = "از تاریخ"
        Me.chk_Date.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_allPOrM)
        Me.Panel1.Controls.Add(Me.rb_pm)
        Me.Panel1.Controls.Add(Me.rb_Mazad)
        Me.Panel1.Location = New System.Drawing.Point(12, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 28)
        Me.Panel1.TabIndex = 166
        '
        'rb_allPOrM
        '
        Me.rb_allPOrM.AutoSize = True
        Me.rb_allPOrM.Checked = True
        Me.rb_allPOrM.Location = New System.Drawing.Point(209, 3)
        Me.rb_allPOrM.Name = "rb_allPOrM"
        Me.rb_allPOrM.Size = New System.Drawing.Size(54, 22)
        Me.rb_allPOrM.TabIndex = 163
        Me.rb_allPOrM.TabStop = True
        Me.rb_allPOrM.Text = "همه"
        Me.rb_allPOrM.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_allWandNW)
        Me.Panel2.Controls.Add(Me.rb_WorkForm)
        Me.Panel2.Controls.Add(Me.rb_WithoutWorkForm)
        Me.Panel2.Location = New System.Drawing.Point(11, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(271, 28)
        Me.Panel2.TabIndex = 166
        '
        'rb_allWandNW
        '
        Me.rb_allWandNW.AutoSize = True
        Me.rb_allWandNW.Checked = True
        Me.rb_allWandNW.Location = New System.Drawing.Point(209, 2)
        Me.rb_allWandNW.Name = "rb_allWandNW"
        Me.rb_allWandNW.Size = New System.Drawing.Size(54, 22)
        Me.rb_allWandNW.TabIndex = 163
        Me.rb_allWandNW.TabStop = True
        Me.rb_allWandNW.Text = "همه"
        Me.rb_allWandNW.UseVisualStyleBackColor = True
        '
        'rb_WorkForm
        '
        Me.rb_WorkForm.AutoSize = True
        Me.rb_WorkForm.Location = New System.Drawing.Point(126, 2)
        Me.rb_WorkForm.Name = "rb_WorkForm"
        Me.rb_WorkForm.Size = New System.Drawing.Size(81, 22)
        Me.rb_WorkForm.TabIndex = 163
        Me.rb_WorkForm.Text = "با فرم کار"
        Me.rb_WorkForm.UseVisualStyleBackColor = True
        '
        'rb_WithoutWorkForm
        '
        Me.rb_WithoutWorkForm.AutoSize = True
        Me.rb_WithoutWorkForm.Location = New System.Drawing.Point(12, 2)
        Me.rb_WithoutWorkForm.Name = "rb_WithoutWorkForm"
        Me.rb_WithoutWorkForm.Size = New System.Drawing.Size(101, 22)
        Me.rb_WithoutWorkForm.TabIndex = 163
        Me.rb_WithoutWorkForm.Text = "بدون فرم کار"
        Me.rb_WithoutWorkForm.UseVisualStyleBackColor = True
        '
        'PostOrKhat
        '
        Me.PostOrKhat.AutoSize = True
        Me.PostOrKhat.Location = New System.Drawing.Point(462, 22)
        Me.PostOrKhat.Name = "PostOrKhat"
        Me.PostOrKhat.Size = New System.Drawing.Size(61, 22)
        Me.PostOrKhat.TabIndex = 162
        Me.PostOrKhat.Text = "پست"
        Me.PostOrKhat.UseVisualStyleBackColor = True
        '
        'PmConRpRemainedItemBindingSource
        '
        Me.PmConRpRemainedItemBindingSource.DataMember = "pm_Con_Rp_RemainedItem"
        Me.PmConRpRemainedItemBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_Rp_RemainedItemTableAdapter
        '
        Me.Pm_Con_Rp_RemainedItemTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemcodeDataGridViewTextBoxColumn, Me.ItemTitleDataGridViewTextBoxColumn, Me.AllamountDataGridViewTextBoxColumn, Me.DoAmountDataGridViewTextBoxColumn, Me.DiffDataGridViewTextBoxColumn, Me.price})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmConRpRemainedItemBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(6, 231)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(868, 295)
        Me.DataGridView1.TabIndex = 6
        '
        'ItemcodeDataGridViewTextBoxColumn
        '
        Me.ItemcodeDataGridViewTextBoxColumn.DataPropertyName = "itemcode"
        Me.ItemcodeDataGridViewTextBoxColumn.HeaderText = "کد آیتم"
        Me.ItemcodeDataGridViewTextBoxColumn.Name = "ItemcodeDataGridViewTextBoxColumn"
        '
        'ItemTitleDataGridViewTextBoxColumn
        '
        Me.ItemTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemTitleDataGridViewTextBoxColumn.DataPropertyName = "ItemTitle"
        Me.ItemTitleDataGridViewTextBoxColumn.HeaderText = "عنوان آیتم"
        Me.ItemTitleDataGridViewTextBoxColumn.Name = "ItemTitleDataGridViewTextBoxColumn"
        '
        'AllamountDataGridViewTextBoxColumn
        '
        Me.AllamountDataGridViewTextBoxColumn.DataPropertyName = "allamount"
        Me.AllamountDataGridViewTextBoxColumn.HeaderText = "تعداد کل"
        Me.AllamountDataGridViewTextBoxColumn.Name = "AllamountDataGridViewTextBoxColumn"
        Me.AllamountDataGridViewTextBoxColumn.ReadOnly = True
        Me.AllamountDataGridViewTextBoxColumn.Width = 75
        '
        'DoAmountDataGridViewTextBoxColumn
        '
        Me.DoAmountDataGridViewTextBoxColumn.DataPropertyName = "DoAmount"
        Me.DoAmountDataGridViewTextBoxColumn.HeaderText = "انجام شده"
        Me.DoAmountDataGridViewTextBoxColumn.Name = "DoAmountDataGridViewTextBoxColumn"
        Me.DoAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiffDataGridViewTextBoxColumn
        '
        Me.DiffDataGridViewTextBoxColumn.DataPropertyName = "diff"
        Me.DiffDataGridViewTextBoxColumn.HeaderText = "باقیمانده"
        Me.DiffDataGridViewTextBoxColumn.Name = "DiffDataGridViewTextBoxColumn"
        Me.DiffDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiffDataGridViewTextBoxColumn.Width = 75
        '
        'price
        '
        Me.price.DataPropertyName = "price"
        Me.price.HeaderText = "قیمت"
        Me.price.Name = "price"
        Me.price.Width = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(781, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 18)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "واحد"
        '
        'rp
        '
        Me.rp.Location = New System.Drawing.Point(636, 15)
        Me.rp.Name = "rp"
        Me.rp.Size = New System.Drawing.Size(104, 29)
        Me.rp.TabIndex = 2
        Me.rp.Text = "چاپ"
        Me.rp.UseVisualStyleBackColor = True
        '
        'chkbx_Star
        '
        Me.chkbx_Star.AutoSize = True
        Me.chkbx_Star.Location = New System.Drawing.Point(333, 52)
        Me.chkbx_Star.Name = "chkbx_Star"
        Me.chkbx_Star.Size = New System.Drawing.Size(189, 22)
        Me.chkbx_Star.TabIndex = 167
        Me.chkbx_Star.Text = "نمایش آیتم های ستاره دار"
        Me.chkbx_Star.UseVisualStyleBackColor = True
        '
        'Frm_Rp_StatusStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(881, 555)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Rp_StatusStatement"
        Me.Text = "گزارش صورت وضعیت"
        Me.Controls.SetChildIndex(Me.gbx_Buttons, 0)
        Me.Controls.SetChildIndex(Me.gbx_Fields, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PmConRpRemainedItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cmb_Vahed As VB_Component.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents rb_Mazad As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pm As System.Windows.Forms.RadioButton
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents cmb_Contract As VB_Component.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents cmb_Line As VB_Component.ComboBox
    Friend WithEvents Cmb_Post As VB_Component.ComboBox
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
    Friend WithEvents chk_Date As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_WorkForm As System.Windows.Forms.RadioButton
    Friend WithEvents rb_WithoutWorkForm As System.Windows.Forms.RadioButton
    Friend WithEvents rb_allWandNW As System.Windows.Forms.RadioButton
    Friend WithEvents rb_allPOrM As System.Windows.Forms.RadioButton
    Friend WithEvents PostOrKhat As System.Windows.Forms.CheckBox
    Friend WithEvents PmConRpRemainedItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_Rp_RemainedItemTableAdapter As Nama_PM.Ds_ConTableAdapters.pm_Con_Rp_RemainedItemTableAdapter
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ItemcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllamountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiffDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rp As System.Windows.Forms.Button
    Friend WithEvents chkbx_Star As System.Windows.Forms.CheckBox
End Class
