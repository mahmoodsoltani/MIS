<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpWorkForm
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
        Me.chk_WotkFormNo = New System.Windows.Forms.CheckBox
        Me.txt_WotkFormNo = New CS_Component.TextBox
        Me.txt_WorkDis = New CS_Component.TextBox
        Me.chk_Roz = New System.Windows.Forms.CheckBox
        Me.chk_MozoKar = New System.Windows.Forms.CheckBox
        Me.chk_WorkDis = New System.Windows.Forms.CheckBox
        Me.chk_HazineCode = New System.Windows.Forms.CheckBox
        Me.chk_Sarparast = New System.Windows.Forms.CheckBox
        Me.chk_Group = New System.Windows.Forms.CheckBox
        Me.cmb_mabdaHarkat = New VB_Component.ComboBox
        Me.PMPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.cmb_mahalFaliat = New VB_Component.ComboBox
        Me.PMPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_AllVahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_roz = New VB_Component.ComboBox
        Me.HafteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_MozoKar = New VB_Component.ComboBox
        Me.PmWorkDisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_HazineCode = New VB_Component.ComboBox
        Me.PmHazineCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_mabdaHarkat = New System.Windows.Forms.CheckBox
        Me.Cmb_Sarparast = New VB_Component.ComboBox
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.chk_MahalFaliat = New System.Windows.Forms.CheckBox
        Me.Cmb_Group = New VB_Component.ComboBox
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chk_AllVahed = New System.Windows.Forms.CheckBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chk_allday = New System.Windows.Forms.CheckBox
        Me.PM_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_Record = New System.Windows.Forms.Label
        Me.Btn_print = New CS_Component.Btn
        Me.Btn_Edit = New CS_Component.Btn
        Me.Btn_Rp_Kholase_FormKar = New CS_Component.Btn
        Me.Btn_Search = New CS_Component.Btn
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخفرمکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شرحکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سرپرستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مبداDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلفعالیتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اعضاDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.گروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.واحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.توضیحکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدهزینهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامپروژهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmAshkhasSarparastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RpWorkFormMasterSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Rp1 = New Nama_PM.Ds_Rp
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.Pm_WorkDisTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_WorkDisTableAdapter
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Pm_HazineCodeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
        Me.Acc_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
        Me.chk_Ozv = New System.Windows.Forms.CheckBox
        Me.cmb_ozv = New VB_Component.ComboBox
        Me.AccAshkhasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HafteTableAdapter = New Nama_PM.Ds_PmTableAdapters.HafteTableAdapter
        Me.RpKholaseWorkFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_KholaseWorkFormTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_KholaseWorkFormTableAdapter
        Me.Rp_WorkFormMasterSearchTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_WorkFormMasterSearchTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PMPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HafteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmWorkDisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpWorkFormMasterSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpKholaseWorkFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 572)
        Me.gbx_Buttons.Size = New System.Drawing.Size(10, 18)
        Me.gbx_Buttons.Visible = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, -12)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(-94, -12)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.chk_Ozv)
        Me.gbx_Fields.Controls.Add(Me.cmb_ozv)
        Me.gbx_Fields.Controls.Add(Me.DataGridView1)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.chk_WotkFormNo)
        Me.gbx_Fields.Controls.Add(Me.cmb_roz)
        Me.gbx_Fields.Controls.Add(Me.chk_Roz)
        Me.gbx_Fields.Controls.Add(Me.txt_WotkFormNo)
        Me.gbx_Fields.Controls.Add(Me.txt_WorkDis)
        Me.gbx_Fields.Controls.Add(Me.chk_MozoKar)
        Me.gbx_Fields.Controls.Add(Me.chk_WorkDis)
        Me.gbx_Fields.Controls.Add(Me.chk_HazineCode)
        Me.gbx_Fields.Controls.Add(Me.chk_Sarparast)
        Me.gbx_Fields.Controls.Add(Me.chk_Group)
        Me.gbx_Fields.Controls.Add(Me.cmb_mabdaHarkat)
        Me.gbx_Fields.Controls.Add(Me.cmb_mahalFaliat)
        Me.gbx_Fields.Controls.Add(Me.cmb_AllVahed)
        Me.gbx_Fields.Controls.Add(Me.cmb_MozoKar)
        Me.gbx_Fields.Controls.Add(Me.cmb_HazineCode)
        Me.gbx_Fields.Controls.Add(Me.chk_mabdaHarkat)
        Me.gbx_Fields.Controls.Add(Me.Cmb_Sarparast)
        Me.gbx_Fields.Controls.Add(Me.chk_MahalFaliat)
        Me.gbx_Fields.Controls.Add(Me.Cmb_Group)
        Me.gbx_Fields.Controls.Add(Me.Chk_AllVahed)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.chk_allday)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(958, 549)
        Me.gbx_Fields.TabIndex = 0
        '
        'chk_WotkFormNo
        '
        Me.chk_WotkFormNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_WotkFormNo.AutoSize = True
        Me.chk_WotkFormNo.Checked = True
        Me.chk_WotkFormNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_WotkFormNo.Location = New System.Drawing.Point(828, 99)
        Me.chk_WotkFormNo.Name = "chk_WotkFormNo"
        Me.chk_WotkFormNo.Size = New System.Drawing.Size(114, 22)
        Me.chk_WotkFormNo.TabIndex = 17
        Me.chk_WotkFormNo.Text = "شماره فرم کار"
        Me.chk_WotkFormNo.UseVisualStyleBackColor = True
        '
        'txt_WotkFormNo
        '
        Me.txt_WotkFormNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_WotkFormNo.CheckExistValueInDb = True
        Me.txt_WotkFormNo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_WotkFormNo.CurrencyUnit = "ریال"
        Me.txt_WotkFormNo.DefaultValue = ""
        Me.txt_WotkFormNo.Enabled = False
        Me.txt_WotkFormNo.FillWithMaxInDb = False
        Me.txt_WotkFormNo.IsRequired = True
        Me.txt_WotkFormNo.Location = New System.Drawing.Point(654, 97)
        Me.txt_WotkFormNo.MaxDecimalLength = 2
        Me.txt_WotkFormNo.Name = "txt_WotkFormNo"
        Me.txt_WotkFormNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_WotkFormNo.Size = New System.Drawing.Size(169, 26)
        Me.txt_WotkFormNo.SpellControl = Nothing
        Me.txt_WotkFormNo.TabIndex = 18
        Me.txt_WotkFormNo.Tag = ""
        Me.txt_WotkFormNo.Title = Nothing
        Me.txt_WotkFormNo.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_WotkFormNo.UseForData = True
        Me.txt_WotkFormNo.ValidateCheckExistOnEdit = False
        Me.txt_WotkFormNo.Value = ""
        '
        'txt_WorkDis
        '
        Me.txt_WorkDis.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_WorkDis.CheckExistValueInDb = True
        Me.txt_WorkDis.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_WorkDis.CurrencyUnit = "ریال"
        Me.txt_WorkDis.DefaultValue = ""
        Me.txt_WorkDis.Enabled = False
        Me.txt_WorkDis.FillWithMaxInDb = False
        Me.txt_WorkDis.IsRequired = True
        Me.txt_WorkDis.Location = New System.Drawing.Point(17, 132)
        Me.txt_WorkDis.MaxDecimalLength = 2
        Me.txt_WorkDis.Multiline = True
        Me.txt_WorkDis.Name = "txt_WorkDis"
        Me.txt_WorkDis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_WorkDis.Size = New System.Drawing.Size(510, 64)
        Me.txt_WorkDis.SpellControl = Nothing
        Me.txt_WorkDis.TabIndex = 20
        Me.txt_WorkDis.Tag = ""
        Me.txt_WorkDis.Title = Nothing
        Me.txt_WorkDis.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_WorkDis.UseForData = True
        Me.txt_WorkDis.ValidateCheckExistOnEdit = False
        Me.txt_WorkDis.Value = ""
        '
        'chk_Roz
        '
        Me.chk_Roz.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Roz.AutoSize = True
        Me.chk_Roz.Checked = True
        Me.chk_Roz.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Roz.Location = New System.Drawing.Point(857, 135)
        Me.chk_Roz.Name = "chk_Roz"
        Me.chk_Roz.Size = New System.Drawing.Size(85, 22)
        Me.chk_Roz.TabIndex = 146
        Me.chk_Roz.Text = "ایام هفته"
        Me.chk_Roz.UseVisualStyleBackColor = True
        '
        'chk_MozoKar
        '
        Me.chk_MozoKar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_MozoKar.AutoSize = True
        Me.chk_MozoKar.Checked = True
        Me.chk_MozoKar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_MozoKar.Location = New System.Drawing.Point(851, 65)
        Me.chk_MozoKar.Name = "chk_MozoKar"
        Me.chk_MozoKar.Size = New System.Drawing.Size(91, 22)
        Me.chk_MozoKar.TabIndex = 12
        Me.chk_MozoKar.Text = "موضوع کار"
        Me.chk_MozoKar.UseVisualStyleBackColor = True
        '
        'chk_WorkDis
        '
        Me.chk_WorkDis.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_WorkDis.AutoSize = True
        Me.chk_WorkDis.Checked = True
        Me.chk_WorkDis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_WorkDis.Location = New System.Drawing.Point(538, 134)
        Me.chk_WorkDis.Name = "chk_WorkDis"
        Me.chk_WorkDis.Size = New System.Drawing.Size(78, 22)
        Me.chk_WorkDis.TabIndex = 19
        Me.chk_WorkDis.Text = "شرح کار"
        Me.chk_WorkDis.UseVisualStyleBackColor = True
        '
        'chk_HazineCode
        '
        Me.chk_HazineCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_HazineCode.AutoSize = True
        Me.chk_HazineCode.Checked = True
        Me.chk_HazineCode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_HazineCode.Location = New System.Drawing.Point(195, 62)
        Me.chk_HazineCode.Name = "chk_HazineCode"
        Me.chk_HazineCode.Size = New System.Drawing.Size(81, 22)
        Me.chk_HazineCode.TabIndex = 10
        Me.chk_HazineCode.Text = "کد هزینه"
        Me.chk_HazineCode.UseVisualStyleBackColor = True
        '
        'chk_Sarparast
        '
        Me.chk_Sarparast.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Sarparast.AutoSize = True
        Me.chk_Sarparast.Checked = True
        Me.chk_Sarparast.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Sarparast.Location = New System.Drawing.Point(189, 32)
        Me.chk_Sarparast.Name = "chk_Sarparast"
        Me.chk_Sarparast.Size = New System.Drawing.Size(87, 22)
        Me.chk_Sarparast.TabIndex = 4
        Me.chk_Sarparast.Text = "سرپرست"
        Me.chk_Sarparast.UseVisualStyleBackColor = True
        '
        'chk_Group
        '
        Me.chk_Group.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Group.AutoSize = True
        Me.chk_Group.Checked = True
        Me.chk_Group.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Group.Location = New System.Drawing.Point(548, 64)
        Me.chk_Group.Name = "chk_Group"
        Me.chk_Group.Size = New System.Drawing.Size(68, 22)
        Me.chk_Group.TabIndex = 8
        Me.chk_Group.Text = "گروهها"
        Me.chk_Group.UseVisualStyleBackColor = True
        '
        'cmb_mabdaHarkat
        '
        Me.cmb_mabdaHarkat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_mabdaHarkat.AutoComplete = True
        Me.cmb_mabdaHarkat.DataSource = Me.PMPostBindingSource1
        Me.cmb_mabdaHarkat.DisplayMember = "نام پست"
        Me.cmb_mabdaHarkat.Enabled = False
        Me.cmb_mabdaHarkat.EnterStop = True
        Me.cmb_mabdaHarkat.FormattingEnabled = True
        Me.cmb_mabdaHarkat.IsRequired = False
        Me.cmb_mabdaHarkat.LimitedToList = True
        Me.cmb_mabdaHarkat.Location = New System.Drawing.Point(594, 62)
        Me.cmb_mabdaHarkat.Name = "cmb_mabdaHarkat"
        Me.cmb_mabdaHarkat.OpenOnFoucus = True
        Me.cmb_mabdaHarkat.Size = New System.Drawing.Size(170, 26)
        Me.cmb_mabdaHarkat.TabIndex = 7
        Me.cmb_mabdaHarkat.ValueMember = "Srl"
        Me.cmb_mabdaHarkat.Visible = False
        '
        'PMPostBindingSource1
        '
        Me.PMPostBindingSource1.DataMember = "PM_Post"
        Me.PMPostBindingSource1.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_mahalFaliat
        '
        Me.cmb_mahalFaliat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_mahalFaliat.AutoComplete = True
        Me.cmb_mahalFaliat.DataSource = Me.PMPostBindingSource
        Me.cmb_mahalFaliat.DisplayMember = "نام پست"
        Me.cmb_mahalFaliat.Enabled = False
        Me.cmb_mahalFaliat.EnterStop = True
        Me.cmb_mahalFaliat.FormattingEnabled = True
        Me.cmb_mahalFaliat.IsRequired = False
        Me.cmb_mahalFaliat.LimitedToList = True
        Me.cmb_mahalFaliat.Location = New System.Drawing.Point(653, 30)
        Me.cmb_mahalFaliat.Name = "cmb_mahalFaliat"
        Me.cmb_mahalFaliat.OpenOnFoucus = True
        Me.cmb_mahalFaliat.Size = New System.Drawing.Size(170, 26)
        Me.cmb_mahalFaliat.TabIndex = 1
        Me.cmb_mahalFaliat.ValueMember = "Srl"
        '
        'PMPostBindingSource
        '
        Me.PMPostBindingSource.DataMember = "PM_Post"
        Me.PMPostBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_AllVahed
        '
        Me.cmb_AllVahed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_AllVahed.AutoComplete = True
        Me.cmb_AllVahed.DataSource = Me.PmVahedBindingSource
        Me.cmb_AllVahed.DisplayMember = "نام واحد"
        Me.cmb_AllVahed.Enabled = False
        Me.cmb_AllVahed.EnterStop = True
        Me.cmb_AllVahed.FormattingEnabled = True
        Me.cmb_AllVahed.IsRequired = False
        Me.cmb_AllVahed.LimitedToList = True
        Me.cmb_AllVahed.Location = New System.Drawing.Point(357, 30)
        Me.cmb_AllVahed.Name = "cmb_AllVahed"
        Me.cmb_AllVahed.OpenOnFoucus = True
        Me.cmb_AllVahed.Size = New System.Drawing.Size(170, 26)
        Me.cmb_AllVahed.TabIndex = 3
        Me.cmb_AllVahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_roz
        '
        Me.cmb_roz.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_roz.AutoComplete = True
        Me.cmb_roz.DataSource = Me.HafteBindingSource
        Me.cmb_roz.DisplayMember = "Text"
        Me.cmb_roz.EnterStop = True
        Me.cmb_roz.FormattingEnabled = True
        Me.cmb_roz.IsRequired = False
        Me.cmb_roz.LimitedToList = True
        Me.cmb_roz.Location = New System.Drawing.Point(653, 133)
        Me.cmb_roz.Name = "cmb_roz"
        Me.cmb_roz.OpenOnFoucus = True
        Me.cmb_roz.Size = New System.Drawing.Size(170, 26)
        Me.cmb_roz.TabIndex = 158
        Me.cmb_roz.ValueMember = "Srl"
        '
        'HafteBindingSource
        '
        Me.HafteBindingSource.DataMember = "Hafte"
        Me.HafteBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_MozoKar
        '
        Me.cmb_MozoKar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_MozoKar.AutoComplete = True
        Me.cmb_MozoKar.DataSource = Me.PmWorkDisBindingSource
        Me.cmb_MozoKar.DisplayMember = "توضیح کار"
        Me.cmb_MozoKar.Enabled = False
        Me.cmb_MozoKar.EnterStop = True
        Me.cmb_MozoKar.FormattingEnabled = True
        Me.cmb_MozoKar.IsRequired = False
        Me.cmb_MozoKar.LimitedToList = True
        Me.cmb_MozoKar.Location = New System.Drawing.Point(653, 63)
        Me.cmb_MozoKar.Name = "cmb_MozoKar"
        Me.cmb_MozoKar.OpenOnFoucus = True
        Me.cmb_MozoKar.Size = New System.Drawing.Size(170, 26)
        Me.cmb_MozoKar.TabIndex = 13
        Me.cmb_MozoKar.ValueMember = "Srl"
        '
        'PmWorkDisBindingSource
        '
        Me.PmWorkDisBindingSource.DataMember = "Pm_WorkDis"
        Me.PmWorkDisBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_HazineCode
        '
        Me.cmb_HazineCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_HazineCode.AutoComplete = True
        Me.cmb_HazineCode.DataSource = Me.PmHazineCodeBindingSource
        Me.cmb_HazineCode.DisplayMember = "کد"
        Me.cmb_HazineCode.Enabled = False
        Me.cmb_HazineCode.EnterStop = True
        Me.cmb_HazineCode.FormattingEnabled = True
        Me.cmb_HazineCode.IsRequired = False
        Me.cmb_HazineCode.LimitedToList = True
        Me.cmb_HazineCode.Location = New System.Drawing.Point(17, 60)
        Me.cmb_HazineCode.Name = "cmb_HazineCode"
        Me.cmb_HazineCode.OpenOnFoucus = True
        Me.cmb_HazineCode.Size = New System.Drawing.Size(170, 26)
        Me.cmb_HazineCode.TabIndex = 11
        Me.cmb_HazineCode.ValueMember = "Srl"
        '
        'PmHazineCodeBindingSource
        '
        Me.PmHazineCodeBindingSource.DataMember = "Pm_HazineCode"
        Me.PmHazineCodeBindingSource.DataSource = Me.Ds_Pm
        '
        'chk_mabdaHarkat
        '
        Me.chk_mabdaHarkat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_mabdaHarkat.AutoSize = True
        Me.chk_mabdaHarkat.Checked = True
        Me.chk_mabdaHarkat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_mabdaHarkat.Location = New System.Drawing.Point(781, 66)
        Me.chk_mabdaHarkat.Name = "chk_mabdaHarkat"
        Me.chk_mabdaHarkat.Size = New System.Drawing.Size(94, 22)
        Me.chk_mabdaHarkat.TabIndex = 6
        Me.chk_mabdaHarkat.Text = "مبدا حرکت"
        Me.chk_mabdaHarkat.UseVisualStyleBackColor = True
        Me.chk_mabdaHarkat.Visible = False
        '
        'Cmb_Sarparast
        '
        Me.Cmb_Sarparast.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmb_Sarparast.AutoComplete = True
        Me.Cmb_Sarparast.DataSource = Me.AccAshkhasBindingSource
        Me.Cmb_Sarparast.DisplayMember = "نام و نام خانوادگی"
        Me.Cmb_Sarparast.Enabled = False
        Me.Cmb_Sarparast.EnterStop = True
        Me.Cmb_Sarparast.FormattingEnabled = True
        Me.Cmb_Sarparast.IsRequired = False
        Me.Cmb_Sarparast.LimitedToList = True
        Me.Cmb_Sarparast.Location = New System.Drawing.Point(17, 30)
        Me.Cmb_Sarparast.Name = "Cmb_Sarparast"
        Me.Cmb_Sarparast.OpenOnFoucus = True
        Me.Cmb_Sarparast.Size = New System.Drawing.Size(170, 26)
        Me.Cmb_Sarparast.TabIndex = 5
        Me.Cmb_Sarparast.ValueMember = "Srl"
        '
        'AccAshkhasBindingSource
        '
        Me.AccAshkhasBindingSource.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_MahalFaliat
        '
        Me.chk_MahalFaliat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_MahalFaliat.AutoSize = True
        Me.chk_MahalFaliat.Checked = True
        Me.chk_MahalFaliat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_MahalFaliat.Location = New System.Drawing.Point(841, 34)
        Me.chk_MahalFaliat.Name = "chk_MahalFaliat"
        Me.chk_MahalFaliat.Size = New System.Drawing.Size(101, 22)
        Me.chk_MahalFaliat.TabIndex = 0
        Me.chk_MahalFaliat.Text = "محل فعالیت"
        Me.chk_MahalFaliat.UseVisualStyleBackColor = True
        '
        'Cmb_Group
        '
        Me.Cmb_Group.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmb_Group.AutoComplete = True
        Me.Cmb_Group.DataSource = Me.PmGroupBindingSource
        Me.Cmb_Group.DisplayMember = "نام"
        Me.Cmb_Group.Enabled = False
        Me.Cmb_Group.EnterStop = True
        Me.Cmb_Group.FormattingEnabled = True
        Me.Cmb_Group.IsRequired = False
        Me.Cmb_Group.LimitedToList = True
        Me.Cmb_Group.Location = New System.Drawing.Point(357, 62)
        Me.Cmb_Group.Name = "Cmb_Group"
        Me.Cmb_Group.OpenOnFoucus = True
        Me.Cmb_Group.Size = New System.Drawing.Size(170, 26)
        Me.Cmb_Group.TabIndex = 9
        Me.Cmb_Group.ValueMember = "Srl"
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'Chk_AllVahed
        '
        Me.Chk_AllVahed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Chk_AllVahed.AutoSize = True
        Me.Chk_AllVahed.Checked = True
        Me.Chk_AllVahed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_AllVahed.Location = New System.Drawing.Point(547, 32)
        Me.Chk_AllVahed.Name = "Chk_AllVahed"
        Me.Chk_AllVahed.Size = New System.Drawing.Size(69, 22)
        Me.Chk_AllVahed.TabIndex = 2
        Me.Chk_AllVahed.Text = "واحدها"
        Me.Chk_AllVahed.UseVisualStyleBackColor = True
        '
        'txt_ToDate
        '
        Me.txt_ToDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.Enabled = False
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(189, 96)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(154, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 16
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
        Me.txt_FromDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.Enabled = False
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(371, 96)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(154, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 15
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
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 18)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "تا"
        '
        'chk_allday
        '
        Me.chk_allday.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_allday.AutoSize = True
        Me.chk_allday.Checked = True
        Me.chk_allday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_allday.Location = New System.Drawing.Point(547, 98)
        Me.chk_allday.Name = "chk_allday"
        Me.chk_allday.Size = New System.Drawing.Size(69, 22)
        Me.chk_allday.TabIndex = 14
        Me.chk_allday.Text = "تاریخ از"
        Me.chk_allday.UseVisualStyleBackColor = True
        '
        'PM_PostTableAdapter
        '
        Me.PM_PostTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_Record)
        Me.Panel1.Controls.Add(Me.Btn_print)
        Me.Panel1.Controls.Add(Me.Btn_Edit)
        Me.Panel1.Controls.Add(Me.Btn_Rp_Kholase_FormKar)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Location = New System.Drawing.Point(9, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 36)
        Me.Panel1.TabIndex = 21
        '
        'lbl_Record
        '
        Me.lbl_Record.AutoSize = True
        Me.lbl_Record.Location = New System.Drawing.Point(99, 8)
        Me.lbl_Record.Name = "lbl_Record"
        Me.lbl_Record.Size = New System.Drawing.Size(74, 18)
        Me.lbl_Record.TabIndex = 161
        Me.lbl_Record.Text = "تعداد رکورد"
        '
        'Btn_print
        '
        Me.Btn_print.BackColor = System.Drawing.Color.Transparent
        Me.Btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_print.HeaderText = "چاپ"
        Me.Btn_print.Location = New System.Drawing.Point(560, 4)
        Me.Btn_print.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_print.Name = "Btn_print"
        Me.Btn_print.Size = New System.Drawing.Size(114, 26)
        Me.Btn_print.TabIndex = 160
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Edit.HeaderText = "ویرایش فرم کار"
        Me.Btn_Edit.Location = New System.Drawing.Point(682, 4)
        Me.Btn_Edit.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(140, 26)
        Me.Btn_Edit.TabIndex = 159
        '
        'Btn_Rp_Kholase_FormKar
        '
        Me.Btn_Rp_Kholase_FormKar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Rp_Kholase_FormKar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Rp_Kholase_FormKar.HeaderText = "گزارش  خلاصه فرم کار"
        Me.Btn_Rp_Kholase_FormKar.Location = New System.Drawing.Point(388, 4)
        Me.Btn_Rp_Kholase_FormKar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Rp_Kholase_FormKar.Name = "Btn_Rp_Kholase_FormKar"
        Me.Btn_Rp_Kholase_FormKar.Size = New System.Drawing.Size(164, 26)
        Me.Btn_Rp_Kholase_FormKar.TabIndex = 1
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.HeaderText = "جستجو"
        Me.Btn_Search.Location = New System.Drawing.Point(830, 4)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(93, 26)
        Me.Btn_Search.TabIndex = 0
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
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.شمارهDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.شمارهفرمکارDataGridViewTextBoxColumn, Me.تاریخفرمکارDataGridViewTextBoxColumn, Me.شرحکارDataGridViewTextBoxColumn, Me.سرپرستDataGridViewTextBoxColumn, Me.مبداDataGridViewTextBoxColumn, Me.محلفعالیتDataGridViewTextBoxColumn, Me.اعضاDataGridViewTextBoxColumn, Me.گروهDataGridViewTextBoxColumn, Me.واحدDataGridViewTextBoxColumn, Me.توضیحکارDataGridViewTextBoxColumn, Me.کدهزینهDataGridViewTextBoxColumn, Me.نامپروژهDataGridViewTextBoxColumn, Me.SrlPmAshkhasSarparastDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.RpWorkFormMasterSearchBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(9, 279)
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
        Me.DataGridView1.Size = New System.Drawing.Size(941, 264)
        Me.DataGridView1.TabIndex = 167
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        Me.تاریخDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهفرمکارDataGridViewTextBoxColumn
        '
        Me.شمارهفرمکارDataGridViewTextBoxColumn.DataPropertyName = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.HeaderText = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.Name = "شمارهفرمکارDataGridViewTextBoxColumn"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.ReadOnly = True
        Me.شمارهفرمکارDataGridViewTextBoxColumn.Width = 110
        '
        'تاریخفرمکارDataGridViewTextBoxColumn
        '
        Me.تاریخفرمکارDataGridViewTextBoxColumn.DataPropertyName = "تاریخ فرم کار"
        Me.تاریخفرمکارDataGridViewTextBoxColumn.HeaderText = "تاریخ فرم کار"
        Me.تاریخفرمکارDataGridViewTextBoxColumn.Name = "تاریخفرمکارDataGridViewTextBoxColumn"
        Me.تاریخفرمکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'شرحکارDataGridViewTextBoxColumn
        '
        Me.شرحکارDataGridViewTextBoxColumn.DataPropertyName = "شرح کار"
        Me.شرحکارDataGridViewTextBoxColumn.HeaderText = "شرح کار"
        Me.شرحکارDataGridViewTextBoxColumn.Name = "شرحکارDataGridViewTextBoxColumn"
        Me.شرحکارDataGridViewTextBoxColumn.ReadOnly = True
        Me.شرحکارDataGridViewTextBoxColumn.Width = 350
        '
        'سرپرستDataGridViewTextBoxColumn
        '
        Me.سرپرستDataGridViewTextBoxColumn.DataPropertyName = "سرپرست"
        Me.سرپرستDataGridViewTextBoxColumn.HeaderText = "سرپرست"
        Me.سرپرستDataGridViewTextBoxColumn.Name = "سرپرستDataGridViewTextBoxColumn"
        Me.سرپرستDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مبداDataGridViewTextBoxColumn
        '
        Me.مبداDataGridViewTextBoxColumn.DataPropertyName = "مبدا"
        Me.مبداDataGridViewTextBoxColumn.HeaderText = "محل فعالیت"
        Me.مبداDataGridViewTextBoxColumn.Name = "مبداDataGridViewTextBoxColumn"
        Me.مبداDataGridViewTextBoxColumn.ReadOnly = True
        '
        'محلفعالیتDataGridViewTextBoxColumn
        '
        Me.محلفعالیتDataGridViewTextBoxColumn.DataPropertyName = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.HeaderText = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.Name = "محلفعالیتDataGridViewTextBoxColumn"
        Me.محلفعالیتDataGridViewTextBoxColumn.ReadOnly = True
        Me.محلفعالیتDataGridViewTextBoxColumn.Visible = False
        '
        'اعضاDataGridViewTextBoxColumn
        '
        Me.اعضاDataGridViewTextBoxColumn.DataPropertyName = "اعضا"
        Me.اعضاDataGridViewTextBoxColumn.HeaderText = "اعضا"
        Me.اعضاDataGridViewTextBoxColumn.Name = "اعضاDataGridViewTextBoxColumn"
        Me.اعضاDataGridViewTextBoxColumn.ReadOnly = True
        '
        'گروهDataGridViewTextBoxColumn
        '
        Me.گروهDataGridViewTextBoxColumn.DataPropertyName = "گروه"
        Me.گروهDataGridViewTextBoxColumn.HeaderText = "گروه"
        Me.گروهDataGridViewTextBoxColumn.Name = "گروهDataGridViewTextBoxColumn"
        Me.گروهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'واحدDataGridViewTextBoxColumn
        '
        Me.واحدDataGridViewTextBoxColumn.DataPropertyName = "واحد"
        Me.واحدDataGridViewTextBoxColumn.HeaderText = "واحد"
        Me.واحدDataGridViewTextBoxColumn.Name = "واحدDataGridViewTextBoxColumn"
        Me.واحدDataGridViewTextBoxColumn.ReadOnly = True
        '
        'توضیحکارDataGridViewTextBoxColumn
        '
        Me.توضیحکارDataGridViewTextBoxColumn.DataPropertyName = "توضیح کار"
        Me.توضیحکارDataGridViewTextBoxColumn.HeaderText = "توضیح کار"
        Me.توضیحکارDataGridViewTextBoxColumn.Name = "توضیحکارDataGridViewTextBoxColumn"
        Me.توضیحکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'کدهزینهDataGridViewTextBoxColumn
        '
        Me.کدهزینهDataGridViewTextBoxColumn.DataPropertyName = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.HeaderText = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.Name = "کدهزینهDataGridViewTextBoxColumn"
        Me.کدهزینهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامپروژهDataGridViewTextBoxColumn
        '
        Me.نامپروژهDataGridViewTextBoxColumn.DataPropertyName = "نام پروژه"
        Me.نامپروژهDataGridViewTextBoxColumn.HeaderText = "نام پروژه"
        Me.نامپروژهDataGridViewTextBoxColumn.Name = "نامپروژهDataGridViewTextBoxColumn"
        Me.نامپروژهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SrlPmAshkhasSarparastDataGridViewTextBoxColumn
        '
        Me.SrlPmAshkhasSarparastDataGridViewTextBoxColumn.DataPropertyName = "Srl_Pm_Ashkhas_Sarparast"
        Me.SrlPmAshkhasSarparastDataGridViewTextBoxColumn.HeaderText = "Srl_Pm_Ashkhas_Sarparast"
        Me.SrlPmAshkhasSarparastDataGridViewTextBoxColumn.Name = "SrlPmAshkhasSarparastDataGridViewTextBoxColumn"
        Me.SrlPmAshkhasSarparastDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlPmAshkhasSarparastDataGridViewTextBoxColumn.Visible = False
        '
        'RpWorkFormMasterSearchBindingSource
        '
        Me.RpWorkFormMasterSearchBindingSource.DataMember = "Rp_WorkFormMasterSearch"
        Me.RpWorkFormMasterSearchBindingSource.DataSource = Me.Ds_Rp1
        '
        'Ds_Rp1
        '
        Me.Ds_Rp1.DataSetName = "Ds_Rp"
        Me.Ds_Rp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_WorkDisTableAdapter
        '
        Me.Pm_WorkDisTableAdapter.ClearBeforeFill = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Pm_HazineCodeTableAdapter
        '
        Me.Pm_HazineCodeTableAdapter.ClearBeforeFill = True
        '
        'Acc_AshkhasTableAdapter
        '
        Me.Acc_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'chk_Ozv
        '
        Me.chk_Ozv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Ozv.AutoSize = True
        Me.chk_Ozv.Checked = True
        Me.chk_Ozv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Ozv.Location = New System.Drawing.Point(886, 170)
        Me.chk_Ozv.Name = "chk_Ozv"
        Me.chk_Ozv.Size = New System.Drawing.Size(56, 22)
        Me.chk_Ozv.TabIndex = 168
        Me.chk_Ozv.Text = "عضو"
        Me.chk_Ozv.UseVisualStyleBackColor = True
        '
        'cmb_ozv
        '
        Me.cmb_ozv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_ozv.AutoComplete = True
        Me.cmb_ozv.DataSource = Me.AccAshkhasBindingSource1
        Me.cmb_ozv.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_ozv.Enabled = False
        Me.cmb_ozv.EnterStop = True
        Me.cmb_ozv.FormattingEnabled = True
        Me.cmb_ozv.IsRequired = False
        Me.cmb_ozv.LimitedToList = True
        Me.cmb_ozv.Location = New System.Drawing.Point(654, 168)
        Me.cmb_ozv.Name = "cmb_ozv"
        Me.cmb_ozv.OpenOnFoucus = True
        Me.cmb_ozv.Size = New System.Drawing.Size(170, 26)
        Me.cmb_ozv.TabIndex = 169
        Me.cmb_ozv.ValueMember = "Srl"
        '
        'AccAshkhasBindingSource1
        '
        Me.AccAshkhasBindingSource1.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource1.DataSource = Me.Ds_Ashkhas
        '
        'HafteTableAdapter
        '
        Me.HafteTableAdapter.ClearBeforeFill = True
        '
        'RpKholaseWorkFormBindingSource
        '
        Me.RpKholaseWorkFormBindingSource.DataMember = "Rp_KholaseWorkForm"
        Me.RpKholaseWorkFormBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_KholaseWorkFormTableAdapter
        '
        Me.Rp_KholaseWorkFormTableAdapter.ClearBeforeFill = True
        '
        'Rp_WorkFormMasterSearchTableAdapter
        '
        Me.Rp_WorkFormMasterSearchTableAdapter.ClearBeforeFill = True
        '
        'Frm_RpWorkForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(987, 627)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpWorkForm"
        Me.Text = "گزارش هفتگی و فعالیت در فرم کار"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PMPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HafteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmWorkDisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpWorkFormMasterSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpKholaseWorkFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_WotkFormNo As System.Windows.Forms.CheckBox
    Friend WithEvents txt_WotkFormNo As CS_Component.TextBox
    Friend WithEvents txt_WorkDis As CS_Component.TextBox
    Friend WithEvents chk_Roz As System.Windows.Forms.CheckBox
    Friend WithEvents chk_MozoKar As System.Windows.Forms.CheckBox
    Friend WithEvents chk_WorkDis As System.Windows.Forms.CheckBox
    Friend WithEvents chk_HazineCode As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Sarparast As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Group As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_mabdaHarkat As VB_Component.ComboBox
    Friend WithEvents cmb_mahalFaliat As VB_Component.ComboBox
    Friend WithEvents cmb_AllVahed As VB_Component.ComboBox
    Friend WithEvents cmb_roz As VB_Component.ComboBox
    Friend WithEvents cmb_MozoKar As VB_Component.ComboBox
    Friend WithEvents cmb_HazineCode As VB_Component.ComboBox
    Friend WithEvents chk_mabdaHarkat As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_Sarparast As VB_Component.ComboBox
    Friend WithEvents chk_MahalFaliat As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_Group As VB_Component.ComboBox
    Friend WithEvents Chk_AllVahed As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_allday As System.Windows.Forms.CheckBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PM_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.PM_PostTableAdapter
    Friend WithEvents PMPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Btn_Rp_Kholase_FormKar As CS_Component.Btn
    Friend WithEvents Btn_Search As CS_Component.Btn
    Friend WithEvents PmWorkDisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_WorkDisTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_WorkDisTableAdapter
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents PmHazineCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_HazineCodeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents Btn_Edit As CS_Component.Btn
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents chk_Ozv As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_ozv As VB_Component.ComboBox
    Friend WithEvents Btn_print As CS_Component.Btn
    Friend WithEvents AccAshkhasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HafteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HafteTableAdapter As Nama_PM.Ds_PmTableAdapters.HafteTableAdapter
    Friend WithEvents تعدادنفراتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نفرساعتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_Record As System.Windows.Forms.Label
    Friend WithEvents RpKholaseWorkFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_KholaseWorkFormTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_KholaseWorkFormTableAdapter
    Friend WithEvents RpWorkFormMasterSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Rp1 As Nama_PM.Ds_Rp
    Friend WithEvents Rp_WorkFormMasterSearchTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_WorkFormMasterSearchTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخفرمکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شرحکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سرپرستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مبداDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلفعالیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اعضاDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents گروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدهزینهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپروژهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmAshkhasSarparastDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
