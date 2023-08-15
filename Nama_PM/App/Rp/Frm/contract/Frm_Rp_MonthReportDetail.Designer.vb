<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_MonthReportDetail
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
        Me.rb_pm = New System.Windows.Forms.RadioButton
        Me.rb_Mazad = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rb_allPOrM = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_omoor = New VB_Component.ComboBox
        Me.PmPostTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.cmb_source = New VB_Component.ComboBox
        Me.PmConSourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.chk_contract = New System.Windows.Forms.CheckBox
        Me.cmb_Contract = New VB_Component.ComboBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_Omoor = New System.Windows.Forms.CheckBox
        Me.chk_source = New System.Windows.Forms.CheckBox
        Me.chk_vahed = New System.Windows.Forms.CheckBox
        Me.cmb_vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_year = New CS_Component.TextBox
        Me.cmb_month = New VB_Component.ComboBox
        Me.PmMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_Month = New System.Windows.Forms.CheckBox
        Me.chk_year = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rb_AllStatus = New System.Windows.Forms.RadioButton
        Me.rb_NoConfirm = New System.Windows.Forms.RadioButton
        Me.rb_ERP = New System.Windows.Forms.RadioButton
        Me.rb_NoErp = New System.Windows.Forms.RadioButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rb_NoGroup = New System.Windows.Forms.RadioButton
        Me.rb_VahedGroup = New System.Windows.Forms.RadioButton
        Me.rb_MonthGroup = New System.Windows.Forms.RadioButton
        Me.rb_omoorGroup = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_Sort1 = New VB_Component.ComboBox
        Me.cmb_sort2 = New VB_Component.ComboBox
        Me.cmb_sort3 = New VB_Component.ComboBox
        Me.PmConMonthReportDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.Pm_Con_SourceTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_PostTypeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
        Me.Pm_MonthTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_MonthTableAdapter
        Me.Pm_Con_MonthReport_DetailTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_MonthReport_DetailTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PmConMonthReportDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(9, 330)
        Me.gbx_Buttons.Size = New System.Drawing.Size(577, 52)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 15)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(473, 15)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.txt_year)
        Me.gbx_Fields.Controls.Add(Me.cmb_sort3)
        Me.gbx_Fields.Controls.Add(Me.cmb_sort2)
        Me.gbx_Fields.Controls.Add(Me.cmb_Sort1)
        Me.gbx_Fields.Controls.Add(Me.cmb_month)
        Me.gbx_Fields.Controls.Add(Me.chk_Month)
        Me.gbx_Fields.Controls.Add(Me.chk_year)
        Me.gbx_Fields.Controls.Add(Me.cmb_omoor)
        Me.gbx_Fields.Controls.Add(Me.cmb_source)
        Me.gbx_Fields.Controls.Add(Me.chk_contract)
        Me.gbx_Fields.Controls.Add(Me.cmb_Contract)
        Me.gbx_Fields.Controls.Add(Me.chk_Omoor)
        Me.gbx_Fields.Controls.Add(Me.chk_source)
        Me.gbx_Fields.Controls.Add(Me.chk_vahed)
        Me.gbx_Fields.Controls.Add(Me.cmb_vahed)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.Panel3)
        Me.gbx_Fields.Controls.Add(Me.Panel2)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Location = New System.Drawing.Point(9, 60)
        Me.gbx_Fields.Size = New System.Drawing.Size(573, 271)
        '
        'rb_pm
        '
        Me.rb_pm.AutoSize = True
        Me.rb_pm.Location = New System.Drawing.Point(83, 3)
        Me.rb_pm.Name = "rb_pm"
        Me.rb_pm.Size = New System.Drawing.Size(63, 22)
        Me.rb_pm.TabIndex = 163
        Me.rb_pm.Text = "پی ام"
        Me.rb_pm.UseVisualStyleBackColor = True
        '
        'rb_Mazad
        '
        Me.rb_Mazad.AutoSize = True
        Me.rb_Mazad.Location = New System.Drawing.Point(1, 3)
        Me.rb_Mazad.Name = "rb_Mazad"
        Me.rb_Mazad.Size = New System.Drawing.Size(75, 22)
        Me.rb_Mazad.TabIndex = 163
        Me.rb_Mazad.Text = "کار مازاد"
        Me.rb_Mazad.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_allPOrM)
        Me.Panel1.Controls.Add(Me.rb_pm)
        Me.Panel1.Controls.Add(Me.rb_Mazad)
        Me.Panel1.Location = New System.Drawing.Point(265, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 28)
        Me.Panel1.TabIndex = 166
        '
        'rb_allPOrM
        '
        Me.rb_allPOrM.AutoSize = True
        Me.rb_allPOrM.Checked = True
        Me.rb_allPOrM.Location = New System.Drawing.Point(152, 3)
        Me.rb_allPOrM.Name = "rb_allPOrM"
        Me.rb_allPOrM.Size = New System.Drawing.Size(54, 22)
        Me.rb_allPOrM.TabIndex = 163
        Me.rb_allPOrM.TabStop = True
        Me.rb_allPOrM.Text = "همه"
        Me.rb_allPOrM.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(492, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "گروه بندی:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_omoor
        '
        Me.cmb_omoor.AutoComplete = True
        Me.cmb_omoor.DataSource = Me.PmPostTypeBindingSource
        Me.cmb_omoor.DisplayMember = "نوع پست"
        Me.cmb_omoor.EnterStop = True
        Me.cmb_omoor.FormattingEnabled = True
        Me.cmb_omoor.IsRequired = False
        Me.cmb_omoor.LimitedToList = True
        Me.cmb_omoor.Location = New System.Drawing.Point(5, 45)
        Me.cmb_omoor.Name = "cmb_omoor"
        Me.cmb_omoor.OpenOnFoucus = False
        Me.cmb_omoor.Size = New System.Drawing.Size(159, 26)
        Me.cmb_omoor.TabIndex = 226
        Me.cmb_omoor.Tag = "Month"
        Me.cmb_omoor.ValueMember = "Srl"
        '
        'PmPostTypeBindingSource
        '
        Me.PmPostTypeBindingSource.DataMember = "Pm_PostType"
        Me.PmPostTypeBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_source
        '
        Me.cmb_source.AutoComplete = True
        Me.cmb_source.DataSource = Me.PmConSourceBindingSource
        Me.cmb_source.DisplayMember = "عنوان"
        Me.cmb_source.EnterStop = True
        Me.cmb_source.FormattingEnabled = True
        Me.cmb_source.IsRequired = False
        Me.cmb_source.LimitedToList = True
        Me.cmb_source.Location = New System.Drawing.Point(5, 15)
        Me.cmb_source.Name = "cmb_source"
        Me.cmb_source.OpenOnFoucus = False
        Me.cmb_source.Size = New System.Drawing.Size(159, 26)
        Me.cmb_source.TabIndex = 227
        Me.cmb_source.Tag = "Month"
        Me.cmb_source.ValueMember = "Srl"
        '
        'PmConSourceBindingSource
        '
        Me.PmConSourceBindingSource.DataMember = "Pm_Con_Source"
        Me.PmConSourceBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_contract
        '
        Me.chk_contract.AutoSize = True
        Me.chk_contract.Checked = True
        Me.chk_contract.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_contract.Location = New System.Drawing.Point(499, 17)
        Me.chk_contract.Name = "chk_contract"
        Me.chk_contract.Size = New System.Drawing.Size(66, 22)
        Me.chk_contract.TabIndex = 224
        Me.chk_contract.Text = "قرارداد"
        Me.chk_contract.UseVisualStyleBackColor = True
        '
        'cmb_Contract
        '
        Me.cmb_Contract.AutoComplete = True
        Me.cmb_Contract.DataSource = Me.PmConContractBindingSource
        Me.cmb_Contract.DisplayMember = "عنوان"
        Me.cmb_Contract.Enabled = False
        Me.cmb_Contract.EnterStop = True
        Me.cmb_Contract.FormattingEnabled = True
        Me.cmb_Contract.IsRequired = False
        Me.cmb_Contract.LimitedToList = True
        Me.cmb_Contract.Location = New System.Drawing.Point(231, 15)
        Me.cmb_Contract.Name = "cmb_Contract"
        Me.cmb_Contract.OpenOnFoucus = True
        Me.cmb_Contract.Size = New System.Drawing.Size(257, 26)
        Me.cmb_Contract.TabIndex = 221
        Me.cmb_Contract.ValueMember = "Srl"
        '
        'PmConContractBindingSource
        '
        Me.PmConContractBindingSource.DataMember = "Pm_Con_Contract"
        Me.PmConContractBindingSource.DataSource = Me.Ds_Con
        '
        'chk_Omoor
        '
        Me.chk_Omoor.AutoSize = True
        Me.chk_Omoor.Checked = True
        Me.chk_Omoor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Omoor.Location = New System.Drawing.Point(170, 47)
        Me.chk_Omoor.Name = "chk_Omoor"
        Me.chk_Omoor.Size = New System.Drawing.Size(51, 22)
        Me.chk_Omoor.TabIndex = 225
        Me.chk_Omoor.Text = "امور"
        Me.chk_Omoor.UseVisualStyleBackColor = True
        '
        'chk_source
        '
        Me.chk_source.AutoSize = True
        Me.chk_source.Checked = True
        Me.chk_source.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_source.Location = New System.Drawing.Point(167, 17)
        Me.chk_source.Name = "chk_source"
        Me.chk_source.Size = New System.Drawing.Size(54, 22)
        Me.chk_source.TabIndex = 222
        Me.chk_source.Text = "منبع"
        Me.chk_source.UseVisualStyleBackColor = True
        '
        'chk_vahed
        '
        Me.chk_vahed.AutoSize = True
        Me.chk_vahed.Checked = True
        Me.chk_vahed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_vahed.Location = New System.Drawing.Point(510, 47)
        Me.chk_vahed.Name = "chk_vahed"
        Me.chk_vahed.Size = New System.Drawing.Size(55, 22)
        Me.chk_vahed.TabIndex = 223
        Me.chk_vahed.Text = "واحد"
        Me.chk_vahed.UseVisualStyleBackColor = True
        '
        'cmb_vahed
        '
        Me.cmb_vahed.AutoComplete = True
        Me.cmb_vahed.DataSource = Me.PmVahedBindingSource
        Me.cmb_vahed.DisplayMember = "نام واحد"
        Me.cmb_vahed.Enabled = False
        Me.cmb_vahed.EnterStop = True
        Me.cmb_vahed.FormattingEnabled = True
        Me.cmb_vahed.IsRequired = False
        Me.cmb_vahed.LimitedToList = True
        Me.cmb_vahed.Location = New System.Drawing.Point(231, 45)
        Me.cmb_vahed.Name = "cmb_vahed"
        Me.cmb_vahed.OpenOnFoucus = True
        Me.cmb_vahed.Size = New System.Drawing.Size(258, 26)
        Me.cmb_vahed.TabIndex = 220
        Me.cmb_vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'txt_year
        '
        Me.txt_year.CheckExistValueInDb = False
        Me.txt_year.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_year.CurrencyUnit = "ریال"
        Me.txt_year.DefaultValue = ""
        Me.txt_year.FillWithMaxInDb = False
        Me.txt_year.IsRequired = True
        Me.txt_year.Location = New System.Drawing.Point(434, 78)
        Me.txt_year.MaxDecimalLength = 2
        Me.txt_year.Name = "txt_year"
        Me.txt_year.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_year.Size = New System.Drawing.Size(56, 26)
        Me.txt_year.SpellControl = Nothing
        Me.txt_year.TabIndex = 230
        Me.txt_year.Tag = "Year"
        Me.txt_year.Text = "0"
        Me.txt_year.Title = Nothing
        Me.txt_year.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_year.UseForData = True
        Me.txt_year.ValidateCheckExistOnEdit = False
        Me.txt_year.Value = 0
        '
        'cmb_month
        '
        Me.cmb_month.AutoComplete = True
        Me.cmb_month.DataSource = Me.PmMonthBindingSource
        Me.cmb_month.DisplayMember = "name"
        Me.cmb_month.EnterStop = True
        Me.cmb_month.FormattingEnabled = True
        Me.cmb_month.IsRequired = False
        Me.cmb_month.LimitedToList = True
        Me.cmb_month.Location = New System.Drawing.Point(231, 78)
        Me.cmb_month.Name = "cmb_month"
        Me.cmb_month.OpenOnFoucus = False
        Me.cmb_month.Size = New System.Drawing.Size(117, 26)
        Me.cmb_month.TabIndex = 231
        Me.cmb_month.Tag = "Month"
        Me.cmb_month.ValueMember = "Srl"
        '
        'PmMonthBindingSource
        '
        Me.PmMonthBindingSource.DataMember = "Pm_Month"
        Me.PmMonthBindingSource.DataSource = Me.Ds_Con
        '
        'chk_Month
        '
        Me.chk_Month.AutoSize = True
        Me.chk_Month.Checked = True
        Me.chk_Month.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Month.Location = New System.Drawing.Point(354, 80)
        Me.chk_Month.Name = "chk_Month"
        Me.chk_Month.Size = New System.Drawing.Size(46, 22)
        Me.chk_Month.TabIndex = 228
        Me.chk_Month.Text = "ماه"
        Me.chk_Month.UseVisualStyleBackColor = True
        '
        'chk_year
        '
        Me.chk_year.AutoSize = True
        Me.chk_year.Checked = True
        Me.chk_year.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_year.Location = New System.Drawing.Point(509, 80)
        Me.chk_year.Name = "chk_year"
        Me.chk_year.Size = New System.Drawing.Size(56, 22)
        Me.chk_year.TabIndex = 229
        Me.chk_year.Text = "سال"
        Me.chk_year.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(494, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "نوع :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(492, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 170
        Me.Label3.Text = "وضعیت:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_AllStatus)
        Me.Panel2.Controls.Add(Me.rb_NoConfirm)
        Me.Panel2.Controls.Add(Me.rb_ERP)
        Me.Panel2.Controls.Add(Me.rb_NoErp)
        Me.Panel2.Location = New System.Drawing.Point(99, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 28)
        Me.Panel2.TabIndex = 166
        '
        'rb_AllStatus
        '
        Me.rb_AllStatus.AutoSize = True
        Me.rb_AllStatus.Checked = True
        Me.rb_AllStatus.Location = New System.Drawing.Point(319, 1)
        Me.rb_AllStatus.Name = "rb_AllStatus"
        Me.rb_AllStatus.Size = New System.Drawing.Size(54, 22)
        Me.rb_AllStatus.TabIndex = 163
        Me.rb_AllStatus.TabStop = True
        Me.rb_AllStatus.Text = "همه"
        Me.rb_AllStatus.UseVisualStyleBackColor = True
        '
        'rb_NoConfirm
        '
        Me.rb_NoConfirm.AutoSize = True
        Me.rb_NoConfirm.Location = New System.Drawing.Point(222, 1)
        Me.rb_NoConfirm.Name = "rb_NoConfirm"
        Me.rb_NoConfirm.Size = New System.Drawing.Size(91, 22)
        Me.rb_NoConfirm.TabIndex = 163
        Me.rb_NoConfirm.Text = "تائید نشده"
        Me.rb_NoConfirm.UseVisualStyleBackColor = True
        '
        'rb_ERP
        '
        Me.rb_ERP.AutoSize = True
        Me.rb_ERP.Location = New System.Drawing.Point(7, 2)
        Me.rb_ERP.Name = "rb_ERP"
        Me.rb_ERP.Size = New System.Drawing.Size(89, 22)
        Me.rb_ERP.TabIndex = 163
        Me.rb_ERP.Text = "دارای ERP"
        Me.rb_ERP.UseVisualStyleBackColor = True
        '
        'rb_NoErp
        '
        Me.rb_NoErp.AutoSize = True
        Me.rb_NoErp.Location = New System.Drawing.Point(102, 2)
        Me.rb_NoErp.Name = "rb_NoErp"
        Me.rb_NoErp.Size = New System.Drawing.Size(114, 22)
        Me.rb_NoErp.TabIndex = 163
        Me.rb_NoErp.Text = "تائید بدون ERP"
        Me.rb_NoErp.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rb_NoGroup)
        Me.Panel3.Controls.Add(Me.rb_VahedGroup)
        Me.Panel3.Controls.Add(Me.rb_MonthGroup)
        Me.Panel3.Controls.Add(Me.rb_omoorGroup)
        Me.Panel3.Location = New System.Drawing.Point(119, 180)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 28)
        Me.Panel3.TabIndex = 166
        '
        'rb_NoGroup
        '
        Me.rb_NoGroup.AutoSize = True
        Me.rb_NoGroup.Checked = True
        Me.rb_NoGroup.Location = New System.Drawing.Point(232, 3)
        Me.rb_NoGroup.Name = "rb_NoGroup"
        Me.rb_NoGroup.Size = New System.Drawing.Size(120, 22)
        Me.rb_NoGroup.TabIndex = 163
        Me.rb_NoGroup.TabStop = True
        Me.rb_NoGroup.Text = "بدون گروه بندی"
        Me.rb_NoGroup.UseVisualStyleBackColor = True
        '
        'rb_VahedGroup
        '
        Me.rb_VahedGroup.AutoSize = True
        Me.rb_VahedGroup.Location = New System.Drawing.Point(172, 3)
        Me.rb_VahedGroup.Name = "rb_VahedGroup"
        Me.rb_VahedGroup.Size = New System.Drawing.Size(54, 22)
        Me.rb_VahedGroup.TabIndex = 163
        Me.rb_VahedGroup.Text = "واحد"
        Me.rb_VahedGroup.UseVisualStyleBackColor = True
        '
        'rb_MonthGroup
        '
        Me.rb_MonthGroup.AutoSize = True
        Me.rb_MonthGroup.Location = New System.Drawing.Point(6, 3)
        Me.rb_MonthGroup.Name = "rb_MonthGroup"
        Me.rb_MonthGroup.Size = New System.Drawing.Size(45, 22)
        Me.rb_MonthGroup.TabIndex = 163
        Me.rb_MonthGroup.Text = "ماه"
        Me.rb_MonthGroup.UseVisualStyleBackColor = True
        '
        'rb_omoorGroup
        '
        Me.rb_omoorGroup.AutoSize = True
        Me.rb_omoorGroup.Location = New System.Drawing.Point(67, 3)
        Me.rb_omoorGroup.Name = "rb_omoorGroup"
        Me.rb_omoorGroup.Size = New System.Drawing.Size(93, 22)
        Me.rb_omoorGroup.TabIndex = 163
        Me.rb_omoorGroup.Text = "منبع و امور"
        Me.rb_omoorGroup.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(484, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "مرتب سازی:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Sort1
        '
        Me.cmb_Sort1.AutoComplete = True
        Me.cmb_Sort1.EnterStop = True
        Me.cmb_Sort1.FormattingEnabled = True
        Me.cmb_Sort1.IsRequired = False
        Me.cmb_Sort1.Items.AddRange(New Object() {"نام واحد", "گروه", "دوره"})
        Me.cmb_Sort1.LimitedToList = True
        Me.cmb_Sort1.Location = New System.Drawing.Point(396, 217)
        Me.cmb_Sort1.Name = "cmb_Sort1"
        Me.cmb_Sort1.OpenOnFoucus = False
        Me.cmb_Sort1.Size = New System.Drawing.Size(83, 26)
        Me.cmb_Sort1.TabIndex = 231
        Me.cmb_Sort1.Tag = "Month"
        '
        'cmb_sort2
        '
        Me.cmb_sort2.AutoComplete = True
        Me.cmb_sort2.DisplayMember = "name"
        Me.cmb_sort2.EnterStop = True
        Me.cmb_sort2.FormattingEnabled = True
        Me.cmb_sort2.IsRequired = False
        Me.cmb_sort2.Items.AddRange(New Object() {"نام واحد", "گروه", "دوره"})
        Me.cmb_sort2.LimitedToList = True
        Me.cmb_sort2.Location = New System.Drawing.Point(307, 217)
        Me.cmb_sort2.Name = "cmb_sort2"
        Me.cmb_sort2.OpenOnFoucus = False
        Me.cmb_sort2.Size = New System.Drawing.Size(83, 26)
        Me.cmb_sort2.TabIndex = 231
        Me.cmb_sort2.Tag = "Month"
        Me.cmb_sort2.ValueMember = "Srl"
        '
        'cmb_sort3
        '
        Me.cmb_sort3.AutoComplete = True
        Me.cmb_sort3.DisplayMember = "name"
        Me.cmb_sort3.EnterStop = True
        Me.cmb_sort3.FormattingEnabled = True
        Me.cmb_sort3.IsRequired = False
        Me.cmb_sort3.Items.AddRange(New Object() {"نام واحد", "گروه", "دوره"})
        Me.cmb_sort3.LimitedToList = True
        Me.cmb_sort3.Location = New System.Drawing.Point(218, 217)
        Me.cmb_sort3.Name = "cmb_sort3"
        Me.cmb_sort3.OpenOnFoucus = False
        Me.cmb_sort3.Size = New System.Drawing.Size(83, 26)
        Me.cmb_sort3.TabIndex = 231
        Me.cmb_sort3.Tag = "Month"
        Me.cmb_sort3.ValueMember = "Srl"
        '
        'PmConMonthReportDetailBindingSource
        '
        Me.PmConMonthReportDetailBindingSource.DataMember = "Pm_Con_MonthReport_Detail"
        Me.PmConMonthReportDetailBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_ContractTableAdapter
        '
        Me.Pm_Con_ContractTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_SourceTableAdapter
        '
        Me.Pm_Con_SourceTableAdapter.ClearBeforeFill = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTypeTableAdapter
        '
        Me.Pm_PostTypeTableAdapter.ClearBeforeFill = True
        '
        'Pm_MonthTableAdapter
        '
        Me.Pm_MonthTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_MonthReport_DetailTableAdapter
        '
        Me.Pm_Con_MonthReport_DetailTableAdapter.ClearBeforeFill = True
        '
        'Frm_Rp_MonthReportDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(596, 414)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Rp_MonthReportDetail"
        Me.Text = "گزارش صورت وضعیت"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PmConMonthReportDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rb_Mazad As System.Windows.Forms.RadioButton
    Friend WithEvents rb_pm As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_allPOrM As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_omoor As VB_Component.ComboBox
    Friend WithEvents cmb_source As VB_Component.ComboBox
    Friend WithEvents chk_contract As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Contract As VB_Component.ComboBox
    Friend WithEvents chk_Omoor As System.Windows.Forms.CheckBox
    Friend WithEvents chk_source As System.Windows.Forms.CheckBox
    Friend WithEvents chk_vahed As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_vahed As VB_Component.ComboBox
    Public WithEvents txt_year As CS_Component.TextBox
    Friend WithEvents cmb_month As VB_Component.ComboBox
    Friend WithEvents chk_Month As System.Windows.Forms.CheckBox
    Friend WithEvents chk_year As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rb_NoGroup As System.Windows.Forms.RadioButton
    Friend WithEvents rb_VahedGroup As System.Windows.Forms.RadioButton
    Friend WithEvents rb_omoorGroup As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_AllStatus As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NoConfirm As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ERP As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NoErp As System.Windows.Forms.RadioButton
    Friend WithEvents rb_MonthGroup As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_sort3 As VB_Component.ComboBox
    Friend WithEvents cmb_sort2 As VB_Component.ComboBox
    Friend WithEvents cmb_Sort1 As VB_Component.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents PmConSourceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_SourceTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmPostTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTypeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
    Friend WithEvents PmMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_MonthTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_MonthTableAdapter
    Friend WithEvents PmConMonthReportDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_MonthReport_DetailTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_MonthReport_DetailTableAdapter
End Class
