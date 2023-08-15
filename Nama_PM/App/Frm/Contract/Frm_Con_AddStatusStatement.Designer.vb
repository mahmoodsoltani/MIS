<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_AddStatusStatement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Con_AddStatusStatement))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmb_Line = New VB_Component.ComboBox
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cmb_vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Group = New VB_Component.ComboBox
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cmb_Post = New VB_Component.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.PostOrKhat = New System.Windows.Forms.Label
        Me.txt_tarikh = New CS_Component.TextBox
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.Del_Person = New System.Windows.Forms.PictureBox
        Me.Add_Person = New System.Windows.Forms.PictureBox
        Me.DGV_Person = New CS_Component.DataGridView
        Me.Srl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmb_Ashkhas = New VB_Component.ComboBox
        Me.PmAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.Label4 = New System.Windows.Forms.Label
        Me.PmGroupMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_GroupMemberTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupMemberTableAdapter
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.PmconStatusStatementDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_con_StatusStatementDetailTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_con_StatusStatementDetailTableAdapter
        Me.Pm_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
        Me.txt_SSNumber = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Description = New CS_Component.TextBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.btn_SelectDEvice = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_DeviceName = New CS_Component.TextBox
        Me.Pl_Tajhiz = New System.Windows.Forms.Panel
        Me.txt_DeviceSrl = New CS_Component.TextBox
        Me.cmb_HazineCode = New VB_Component.ComboBox
        Me.PmHazineCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.Pm_HazineCodeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Number = New CS_Component.TextBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Del_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmconStatusStatementDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pl_Tajhiz.SuspendLayout()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 350)
        Me.gbx_Buttons.Size = New System.Drawing.Size(686, 52)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 15)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "ذخیره"
        Me.btn_Save.Location = New System.Drawing.Point(582, 15)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Pl_Tajhiz)
        Me.gbx_Fields.Controls.Add(Me.cmb_HazineCode)
        Me.gbx_Fields.Controls.Add(Me.txt_Description)
        Me.gbx_Fields.Controls.Add(Me.Label8)
        Me.gbx_Fields.Controls.Add(Me.txt_Number)
        Me.gbx_Fields.Controls.Add(Me.txt_SSNumber)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.Del_Person)
        Me.gbx_Fields.Controls.Add(Me.Add_Person)
        Me.gbx_Fields.Controls.Add(Me.DGV_Person)
        Me.gbx_Fields.Controls.Add(Me.cmb_Ashkhas)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.cmb_Line)
        Me.gbx_Fields.Controls.Add(Me.Cmb_vahed)
        Me.gbx_Fields.Controls.Add(Me.cmb_Group)
        Me.gbx_Fields.Controls.Add(Me.Cmb_Post)
        Me.gbx_Fields.Controls.Add(Me.Label10)
        Me.gbx_Fields.Controls.Add(Me.Label11)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label12)
        Me.gbx_Fields.Controls.Add(Me.PostOrKhat)
        Me.gbx_Fields.Controls.Add(Me.txt_tarikh)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(686, 307)
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
        Me.cmb_Line.Location = New System.Drawing.Point(303, 115)
        Me.cmb_Line.Name = "cmb_Line"
        Me.cmb_Line.OpenOnFoucus = True
        Me.cmb_Line.Size = New System.Drawing.Size(296, 26)
        Me.cmb_Line.TabIndex = 140
        Me.cmb_Line.ValueMember = "Srl"
        '
        'PmLineBindingSource
        '
        Me.PmLineBindingSource.DataMember = "Pm_Line"
        Me.PmLineBindingSource.DataSource = Me.Ds_Pm
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
        'Cmb_vahed
        '
        Me.Cmb_vahed.AutoComplete = True
        Me.Cmb_vahed.DataSource = Me.PmVahedBindingSource
        Me.Cmb_vahed.DisplayMember = "نام واحد"
        Me.Cmb_vahed.EnterStop = True
        Me.Cmb_vahed.FormattingEnabled = True
        Me.Cmb_vahed.IsRequired = False
        Me.Cmb_vahed.LimitedToList = True
        Me.Cmb_vahed.Location = New System.Drawing.Point(303, 83)
        Me.Cmb_vahed.Name = "Cmb_vahed"
        Me.Cmb_vahed.OpenOnFoucus = True
        Me.Cmb_vahed.Size = New System.Drawing.Size(296, 26)
        Me.Cmb_vahed.TabIndex = 137
        Me.Cmb_vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_Group
        '
        Me.cmb_Group.AutoComplete = True
        Me.cmb_Group.DataSource = Me.PmGroupBindingSource
        Me.cmb_Group.DisplayMember = "نام"
        Me.cmb_Group.EnterStop = True
        Me.cmb_Group.FormattingEnabled = True
        Me.cmb_Group.IsRequired = False
        Me.cmb_Group.LimitedToList = True
        Me.cmb_Group.Location = New System.Drawing.Point(303, 147)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.OpenOnFoucus = True
        Me.cmb_Group.Size = New System.Drawing.Size(296, 26)
        Me.cmb_Group.TabIndex = 138
        Me.cmb_Group.ValueMember = "Srl"
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
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
        Me.Cmb_Post.Location = New System.Drawing.Point(303, 115)
        Me.Cmb_Post.Name = "Cmb_Post"
        Me.Cmb_Post.OpenOnFoucus = True
        Me.Cmb_Post.Size = New System.Drawing.Size(296, 26)
        Me.Cmb_Post.TabIndex = 139
        Me.Cmb_Post.ValueMember = "Srl"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(644, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 18)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "واحد"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(451, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 18)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "تاریخ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(646, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 18)
        Me.Label12.TabIndex = 142
        Me.Label12.Text = "گروه"
        '
        'PostOrKhat
        '
        Me.PostOrKhat.AutoSize = True
        Me.PostOrKhat.Location = New System.Drawing.Point(638, 121)
        Me.PostOrKhat.Name = "PostOrKhat"
        Me.PostOrKhat.Size = New System.Drawing.Size(42, 18)
        Me.PostOrKhat.TabIndex = 143
        Me.PostOrKhat.Text = "پست"
        '
        'txt_tarikh
        '
        Me.txt_tarikh.CheckExistValueInDb = False
        Me.txt_tarikh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_tarikh.CurrencyUnit = "ریال"
        Me.txt_tarikh.DefaultValue = ""
        Me.txt_tarikh.FillWithMaxInDb = False
        Me.txt_tarikh.IsRequired = True
        Me.txt_tarikh.Location = New System.Drawing.Point(313, 19)
        Me.txt_tarikh.MaxDecimalLength = 2
        Me.txt_tarikh.Name = "txt_tarikh"
        Me.txt_tarikh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_tarikh.Size = New System.Drawing.Size(132, 26)
        Me.txt_tarikh.SpellControl = Nothing
        Me.txt_tarikh.TabIndex = 136
        Me.txt_tarikh.TabStop = False
        Me.txt_tarikh.Tag = "StartDate"
        Me.txt_tarikh.Title = Nothing
        Me.txt_tarikh.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_tarikh.UseForData = True
        Me.txt_tarikh.ValidateCheckExistOnEdit = False
        Me.txt_tarikh.Value = ""
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'Del_Person
        '
        Me.Del_Person.Image = CType(resources.GetObject("Del_Person.Image"), System.Drawing.Image)
        Me.Del_Person.Location = New System.Drawing.Point(11, 23)
        Me.Del_Person.Name = "Del_Person"
        Me.Del_Person.Size = New System.Drawing.Size(25, 25)
        Me.Del_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Del_Person.TabIndex = 156
        Me.Del_Person.TabStop = False
        '
        'Add_Person
        '
        Me.Add_Person.Image = CType(resources.GetObject("Add_Person.Image"), System.Drawing.Image)
        Me.Add_Person.Location = New System.Drawing.Point(42, 23)
        Me.Add_Person.Name = "Add_Person"
        Me.Add_Person.Size = New System.Drawing.Size(25, 25)
        Me.Add_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Add_Person.TabIndex = 157
        Me.Add_Person.TabStop = False
        '
        'DGV_Person
        '
        Me.DGV_Person.AllowUserToAddRows = False
        Me.DGV_Person.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Person.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Person.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Person.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Person.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Srl, Me.NameCol, Me.Column1})
        Me.DGV_Person.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Person.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Person.Location = New System.Drawing.Point(6, 55)
        Me.DGV_Person.MultiSelect = False
        Me.DGV_Person.Name = "DGV_Person"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_Person.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Person.RowHeadersWidth = 30
        Me.DGV_Person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_Person.Size = New System.Drawing.Size(291, 239)
        Me.DGV_Person.TabIndex = 154
        '
        'Srl
        '
        Me.Srl.HeaderText = "Srl"
        Me.Srl.Name = "Srl"
        Me.Srl.Visible = False
        '
        'NameCol
        '
        Me.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameCol.HeaderText = "نام فرد"
        Me.NameCol.Name = "NameCol"
        '
        'Column1
        '
        Me.Column1.HeaderText = "شاخص"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 60
        '
        'cmb_Ashkhas
        '
        Me.cmb_Ashkhas.AutoComplete = True
        Me.cmb_Ashkhas.DataSource = Me.PmAshkhasBindingSource
        Me.cmb_Ashkhas.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Ashkhas.EnterStop = True
        Me.cmb_Ashkhas.FormattingEnabled = True
        Me.cmb_Ashkhas.IsRequired = False
        Me.cmb_Ashkhas.LimitedToList = True
        Me.cmb_Ashkhas.Location = New System.Drawing.Point(76, 22)
        Me.cmb_Ashkhas.Name = "cmb_Ashkhas"
        Me.cmb_Ashkhas.OpenOnFoucus = False
        Me.cmb_Ashkhas.Size = New System.Drawing.Size(192, 26)
        Me.cmb_Ashkhas.TabIndex = 153
        Me.cmb_Ashkhas.ValueMember = "Srl"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 18)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "نام"
        '
        'PmGroupMemberBindingSource
        '
        Me.PmGroupMemberBindingSource.DataMember = "Pm_GroupMember"
        Me.PmGroupMemberBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_GroupMemberTableAdapter
        '
        Me.Pm_GroupMemberTableAdapter.ClearBeforeFill = True
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmconStatusStatementDetailBindingSource
        '
        Me.PmconStatusStatementDetailBindingSource.DataMember = "Pm_con_StatusStatementDetail"
        Me.PmconStatusStatementDetailBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_con_StatusStatementDetailTableAdapter
        '
        Me.Pm_con_StatusStatementDetailTableAdapter.ClearBeforeFill = True
        '
        'Pm_AshkhasTableAdapter
        '
        Me.Pm_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'txt_SSNumber
        '
        Me.txt_SSNumber.CheckExistValueInDb = True
        Me.txt_SSNumber.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SSNumber.CurrencyUnit = "ریال"
        Me.txt_SSNumber.DefaultValue = ""
        Me.txt_SSNumber.FillWithMaxInDb = False
        Me.txt_SSNumber.IsRequired = False
        Me.txt_SSNumber.Location = New System.Drawing.Point(518, 51)
        Me.txt_SSNumber.MaxDecimalLength = 2
        Me.txt_SSNumber.Name = "txt_SSNumber"
        Me.txt_SSNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SSNumber.Size = New System.Drawing.Size(81, 26)
        Me.txt_SSNumber.SpellControl = Nothing
        Me.txt_SSNumber.TabIndex = 158
        Me.txt_SSNumber.Tag = "code"
        Me.txt_SSNumber.Title = Nothing
        Me.txt_SSNumber.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SSNumber.UseForData = True
        Me.txt_SSNumber.ValidateCheckExistOnEdit = False
        Me.txt_SSNumber.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(632, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "شماره"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(618, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "توضیحات"
        '
        'txt_Description
        '
        Me.txt_Description.CheckExistValueInDb = True
        Me.txt_Description.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Description.CurrencyUnit = "ریال"
        Me.txt_Description.DefaultValue = ""
        Me.txt_Description.FillWithMaxInDb = False
        Me.txt_Description.IsRequired = True
        Me.txt_Description.Location = New System.Drawing.Point(303, 179)
        Me.txt_Description.MaxDecimalLength = 2
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Description.Size = New System.Drawing.Size(296, 72)
        Me.txt_Description.SpellControl = Nothing
        Me.txt_Description.TabIndex = 158
        Me.txt_Description.Tag = "Description"
        Me.txt_Description.Title = Nothing
        Me.txt_Description.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Description.UseForData = True
        Me.txt_Description.ValidateCheckExistOnEdit = False
        Me.txt_Description.Value = ""
        '
        'PmConContractBindingSource
        '
        Me.PmConContractBindingSource.DataMember = "Pm_Con_Contract"
        Me.PmConContractBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_ContractTableAdapter
        '
        Me.Pm_Con_ContractTableAdapter.ClearBeforeFill = True
        '
        'btn_SelectDEvice
        '
        Me.btn_SelectDEvice.Location = New System.Drawing.Point(8, 2)
        Me.btn_SelectDEvice.Name = "btn_SelectDEvice"
        Me.btn_SelectDEvice.Size = New System.Drawing.Size(31, 27)
        Me.btn_SelectDEvice.TabIndex = 217
        Me.btn_SelectDEvice.Text = "..."
        Me.btn_SelectDEvice.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(324, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 18)
        Me.Label21.TabIndex = 216
        Me.Label21.Text = "تجهیز"
        '
        'txt_DeviceName
        '
        Me.txt_DeviceName.BackColor = System.Drawing.SystemColors.Window
        Me.txt_DeviceName.CheckExistValueInDb = False
        Me.txt_DeviceName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeviceName.CurrencyUnit = "ریال"
        Me.txt_DeviceName.DefaultValue = ""
        Me.txt_DeviceName.FillWithMaxInDb = False
        Me.txt_DeviceName.IsRequired = True
        Me.txt_DeviceName.Location = New System.Drawing.Point(44, 3)
        Me.txt_DeviceName.MaxDecimalLength = 2
        Me.txt_DeviceName.Name = "txt_DeviceName"
        Me.txt_DeviceName.ReadOnly = True
        Me.txt_DeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceName.Size = New System.Drawing.Size(216, 26)
        Me.txt_DeviceName.SpellControl = Nothing
        Me.txt_DeviceName.TabIndex = 218
        Me.txt_DeviceName.Tag = ""
        Me.txt_DeviceName.Title = Nothing
        Me.txt_DeviceName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeviceName.UseForData = True
        Me.txt_DeviceName.ValidateCheckExistOnEdit = False
        Me.txt_DeviceName.Value = ""
        '
        'Pl_Tajhiz
        '
        Me.Pl_Tajhiz.Controls.Add(Me.btn_SelectDEvice)
        Me.Pl_Tajhiz.Controls.Add(Me.txt_DeviceSrl)
        Me.Pl_Tajhiz.Controls.Add(Me.txt_DeviceName)
        Me.Pl_Tajhiz.Controls.Add(Me.Label21)
        Me.Pl_Tajhiz.Location = New System.Drawing.Point(303, 255)
        Me.Pl_Tajhiz.Name = "Pl_Tajhiz"
        Me.Pl_Tajhiz.Size = New System.Drawing.Size(379, 39)
        Me.Pl_Tajhiz.TabIndex = 2
        '
        'txt_DeviceSrl
        '
        Me.txt_DeviceSrl.BackColor = System.Drawing.SystemColors.Window
        Me.txt_DeviceSrl.CheckExistValueInDb = False
        Me.txt_DeviceSrl.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeviceSrl.CurrencyUnit = "ریال"
        Me.txt_DeviceSrl.DefaultValue = ""
        Me.txt_DeviceSrl.FillWithMaxInDb = False
        Me.txt_DeviceSrl.IsRequired = True
        Me.txt_DeviceSrl.Location = New System.Drawing.Point(44, 4)
        Me.txt_DeviceSrl.MaxDecimalLength = 2
        Me.txt_DeviceSrl.Name = "txt_DeviceSrl"
        Me.txt_DeviceSrl.ReadOnly = True
        Me.txt_DeviceSrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceSrl.Size = New System.Drawing.Size(264, 26)
        Me.txt_DeviceSrl.SpellControl = Nothing
        Me.txt_DeviceSrl.TabIndex = 218
        Me.txt_DeviceSrl.Tag = ""
        Me.txt_DeviceSrl.Title = Nothing
        Me.txt_DeviceSrl.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeviceSrl.UseForData = True
        Me.txt_DeviceSrl.ValidateCheckExistOnEdit = False
        Me.txt_DeviceSrl.Value = ""
        Me.txt_DeviceSrl.Visible = False
        '
        'cmb_HazineCode
        '
        Me.cmb_HazineCode.AutoComplete = True
        Me.cmb_HazineCode.DataSource = Me.PmHazineCodeBindingSource
        Me.cmb_HazineCode.DisplayMember = "کد"
        Me.cmb_HazineCode.EnterStop = True
        Me.cmb_HazineCode.FormattingEnabled = True
        Me.cmb_HazineCode.IsRequired = False
        Me.cmb_HazineCode.LimitedToList = True
        Me.cmb_HazineCode.Location = New System.Drawing.Point(303, 51)
        Me.cmb_HazineCode.Name = "cmb_HazineCode"
        Me.cmb_HazineCode.OpenOnFoucus = True
        Me.cmb_HazineCode.Size = New System.Drawing.Size(142, 26)
        Me.cmb_HazineCode.TabIndex = 160
        Me.cmb_HazineCode.ValueMember = "Srl"
        '
        'PmHazineCodeBindingSource
        '
        Me.PmHazineCodeBindingSource.DataMember = "Pm_HazineCode"
        Me.PmHazineCodeBindingSource.DataSource = Me.Ds_Pm
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(451, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "کد هزینه"
        '
        'Pm_HazineCodeTableAdapter
        '
        Me.Pm_HazineCodeTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(598, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "شماره ثبتی"
        '
        'txt_Number
        '
        Me.txt_Number.CheckExistValueInDb = True
        Me.txt_Number.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Number.CurrencyUnit = "ریال"
        Me.txt_Number.DefaultValue = ""
        Me.txt_Number.Enabled = False
        Me.txt_Number.FillWithMaxInDb = False
        Me.txt_Number.IsRequired = True
        Me.txt_Number.Location = New System.Drawing.Point(518, 20)
        Me.txt_Number.MaxDecimalLength = 2
        Me.txt_Number.Name = "txt_Number"
        Me.txt_Number.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Number.Size = New System.Drawing.Size(81, 26)
        Me.txt_Number.SpellControl = Nothing
        Me.txt_Number.TabIndex = 158
        Me.txt_Number.Tag = "code"
        Me.txt_Number.Title = Nothing
        Me.txt_Number.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Number.UseForData = True
        Me.txt_Number.ValidateCheckExistOnEdit = False
        Me.txt_Number.Value = ""
        '
        'Frm_Con_AddStatusStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(717, 437)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_AddStatusStatement"
        Me.Text = "ثبت صورت وضعیت جدید"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Del_Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmconStatusStatementDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pl_Tajhiz.ResumeLayout(False)
        Me.Pl_Tajhiz.PerformLayout()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Line As VB_Component.ComboBox
    Friend WithEvents Cmb_vahed As VB_Component.ComboBox
    Friend WithEvents cmb_Group As VB_Component.ComboBox
    Friend WithEvents Cmb_Post As VB_Component.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PostOrKhat As System.Windows.Forms.Label
    Friend WithEvents txt_tarikh As CS_Component.TextBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
    Friend WithEvents Del_Person As System.Windows.Forms.PictureBox
    Friend WithEvents Add_Person As System.Windows.Forms.PictureBox
    Friend WithEvents DGV_Person As CS_Component.DataGridView
    Friend WithEvents cmb_Ashkhas As VB_Component.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PmGroupMemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupMemberTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupMemberTableAdapter
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmconStatusStatementDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_con_StatusStatementDetailTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_con_StatusStatementDetailTableAdapter
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents PmAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents txt_SSNumber As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Description As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Srl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents btn_SelectDEvice As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_DeviceName As CS_Component.TextBox
    Friend WithEvents Pl_Tajhiz As System.Windows.Forms.Panel
    Friend WithEvents txt_DeviceSrl As CS_Component.TextBox
    Friend WithEvents cmb_HazineCode As VB_Component.ComboBox
    Friend WithEvents PmHazineCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Pm_HazineCodeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
    Friend WithEvents txt_Number As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
