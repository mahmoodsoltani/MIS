<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_MonthReport
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
        Me.Pl_WorkForm = New System.Windows.Forms.Panel
        Me.txt_year = New CS_Component.TextBox
        Me.cmb_Type = New VB_Component.ComboBox
        Me.PmConStatusStatementTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.cmb_Vahed = New VB_Component.ComboBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.cmb_Omor = New VB_Component.ComboBox
        Me.PmPostTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Source = New VB_Component.ComboBox
        Me.PmConSourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Month = New VB_Component.ComboBox
        Me.PmMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lb_omoor = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_sendDate = New CS_Component.TextBox
        Me.lb_number = New System.Windows.Forms.Label
        Me.txt_Number = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_LetterNumber = New CS_Component.TextBox
        Me.Pm_MonthTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_MonthTableAdapter
        Me.Pm_Con_SourceTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
        Me.Pm_PostTypeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_Excel = New System.Windows.Forms.PictureBox
        Me.btn_ConfirmGroup = New System.Windows.Forms.PictureBox
        Me.btn_ShowItem = New System.Windows.Forms.PictureBox
        Me.btn_Summary = New System.Windows.Forms.PictureBox
        Me.btn_Update = New System.Windows.Forms.PictureBox
        Me.txt_ConfirmPrice = New CS_Component.TextBox
        Me.txt_Price = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_ConfirmDate = New CS_Component.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.chk_Iscancle = New System.Windows.Forms.CheckBox
        Me.txt_Discription = New CS_Component.TextBox
        Me.txt_DocumentNumber = New CS_Component.TextBox
        Me.txt_statementNumber = New CS_Component.TextBox
        Me.txt_ErpDate = New CS_Component.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_DeliveryNumber = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Pm_Con_StatusStatementTypeTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementTypeTableAdapter
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmb_Contract = New VB_Component.ComboBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.PmConMonthReportAmountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_MonthReportAmount = New Nama_PM.Ds_ConTableAdapters.Pm_Con_MonthReportAmount
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        Me.Pl_WorkForm.SuspendLayout()
        CType(Me.PmConStatusStatementTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_Excel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_ConfirmGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_ShowItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Summary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConMonthReportAmountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 16)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(531, 16)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(654, 15)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(1251, 12)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_GridViewList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_GridViewList.Location = New System.Drawing.Point(6, 57)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(780, 380)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controls.Controls.Add(Me.DataGridView1)
        Me.gbx_Controls.Controls.Add(Me.cmb_Contract)
        Me.gbx_Controls.Controls.Add(Me.Panel2)
        Me.gbx_Controls.Controls.Add(Me.Panel1)
        Me.gbx_Controls.Controls.Add(Me.Pl_WorkForm)
        Me.gbx_Controls.Controls.Add(Me.txt_Number)
        Me.gbx_Controls.Controls.Add(Me.txt_LetterNumber)
        Me.gbx_Controls.Controls.Add(Me.Label19)
        Me.gbx_Controls.Controls.Add(Me.lb_number)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbx_Controls.Location = New System.Drawing.Point(6, 57)
        Me.gbx_Controls.Size = New System.Drawing.Size(780, 335)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbx_Btn.Location = New System.Drawing.Point(6, 386)
        Me.gbx_Btn.Size = New System.Drawing.Size(780, 51)
        '
        'Pl_WorkForm
        '
        Me.Pl_WorkForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pl_WorkForm.Controls.Add(Me.txt_year)
        Me.Pl_WorkForm.Controls.Add(Me.cmb_Type)
        Me.Pl_WorkForm.Controls.Add(Me.cmb_Vahed)
        Me.Pl_WorkForm.Controls.Add(Me.cmb_Omor)
        Me.Pl_WorkForm.Controls.Add(Me.cmb_Source)
        Me.Pl_WorkForm.Controls.Add(Me.cmb_Month)
        Me.Pl_WorkForm.Controls.Add(Me.Label7)
        Me.Pl_WorkForm.Controls.Add(Me.Label6)
        Me.Pl_WorkForm.Controls.Add(Me.Label8)
        Me.Pl_WorkForm.Controls.Add(Me.Label3)
        Me.Pl_WorkForm.Controls.Add(Me.Label5)
        Me.Pl_WorkForm.Controls.Add(Me.Label2)
        Me.Pl_WorkForm.Controls.Add(Me.lb_omoor)
        Me.Pl_WorkForm.Location = New System.Drawing.Point(4, 53)
        Me.Pl_WorkForm.Name = "Pl_WorkForm"
        Me.Pl_WorkForm.Size = New System.Drawing.Size(772, 73)
        Me.Pl_WorkForm.TabIndex = 2
        '
        'txt_year
        '
        Me.txt_year.CheckExistValueInDb = False
        Me.txt_year.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_year.CurrencyUnit = "ریال"
        Me.txt_year.DefaultValue = ""
        Me.txt_year.FillWithMaxInDb = False
        Me.txt_year.IsRequired = True
        Me.txt_year.Location = New System.Drawing.Point(621, 3)
        Me.txt_year.MaxDecimalLength = 2
        Me.txt_year.Name = "txt_year"
        Me.txt_year.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_year.Size = New System.Drawing.Size(61, 26)
        Me.txt_year.SpellControl = Nothing
        Me.txt_year.TabIndex = 0
        Me.txt_year.Tag = "Year"
        Me.txt_year.Title = Nothing
        Me.txt_year.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_year.UseForData = True
        Me.txt_year.ValidateCheckExistOnEdit = False
        Me.txt_year.Value = ""
        '
        'cmb_Type
        '
        Me.cmb_Type.AutoComplete = True
        Me.cmb_Type.DataSource = Me.PmConStatusStatementTypeBindingSource
        Me.cmb_Type.DisplayMember = "name"
        Me.cmb_Type.EnterStop = True
        Me.cmb_Type.FormattingEnabled = True
        Me.cmb_Type.IsRequired = False
        Me.cmb_Type.LimitedToList = True
        Me.cmb_Type.Location = New System.Drawing.Point(44, 5)
        Me.cmb_Type.Name = "cmb_Type"
        Me.cmb_Type.OpenOnFoucus = False
        Me.cmb_Type.Size = New System.Drawing.Size(136, 26)
        Me.cmb_Type.TabIndex = 2
        Me.cmb_Type.Tag = "srl_Statusstatementtype"
        Me.cmb_Type.ValueMember = "Srl"
        '
        'PmConStatusStatementTypeBindingSource
        '
        Me.PmConStatusStatementTypeBindingSource.DataMember = "Pm_Con_StatusStatementType"
        Me.PmConStatusStatementTypeBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_Vahed
        '
        Me.cmb_Vahed.AutoComplete = True
        Me.cmb_Vahed.DataSource = Me.BindingSource1
        Me.cmb_Vahed.DisplayMember = "نام واحد"
        Me.cmb_Vahed.EnterStop = True
        Me.cmb_Vahed.FormattingEnabled = True
        Me.cmb_Vahed.IsRequired = False
        Me.cmb_Vahed.LimitedToList = True
        Me.cmb_Vahed.Location = New System.Drawing.Point(513, 38)
        Me.cmb_Vahed.Name = "cmb_Vahed"
        Me.cmb_Vahed.OpenOnFoucus = False
        Me.cmb_Vahed.Size = New System.Drawing.Size(171, 26)
        Me.cmb_Vahed.TabIndex = 3
        Me.cmb_Vahed.Tag = "Srl_Pm_Vahed"
        Me.cmb_Vahed.ValueMember = "Srl"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Pm_Vahed"
        Me.BindingSource1.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_Omor
        '
        Me.cmb_Omor.AutoComplete = True
        Me.cmb_Omor.DataSource = Me.PmPostTypeBindingSource
        Me.cmb_Omor.DisplayMember = "نوع پست"
        Me.cmb_Omor.EnterStop = True
        Me.cmb_Omor.FormattingEnabled = True
        Me.cmb_Omor.IsRequired = False
        Me.cmb_Omor.LimitedToList = True
        Me.cmb_Omor.Location = New System.Drawing.Point(327, 37)
        Me.cmb_Omor.Name = "cmb_Omor"
        Me.cmb_Omor.OpenOnFoucus = False
        Me.cmb_Omor.Size = New System.Drawing.Size(117, 26)
        Me.cmb_Omor.TabIndex = 4
        Me.cmb_Omor.Tag = "Srl_Pm_PostType"
        Me.cmb_Omor.ValueMember = "Srl"
        '
        'PmPostTypeBindingSource
        '
        Me.PmPostTypeBindingSource.DataMember = "Pm_PostType"
        Me.PmPostTypeBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_Source
        '
        Me.cmb_Source.AutoComplete = True
        Me.cmb_Source.DataSource = Me.PmConSourceBindingSource
        Me.cmb_Source.DisplayMember = "عنوان"
        Me.cmb_Source.EnterStop = True
        Me.cmb_Source.FormattingEnabled = True
        Me.cmb_Source.IsRequired = False
        Me.cmb_Source.LimitedToList = True
        Me.cmb_Source.Location = New System.Drawing.Point(11, 39)
        Me.cmb_Source.Name = "cmb_Source"
        Me.cmb_Source.OpenOnFoucus = False
        Me.cmb_Source.Size = New System.Drawing.Size(169, 26)
        Me.cmb_Source.TabIndex = 5
        Me.cmb_Source.Tag = "Srl_Pm_Con_source"
        Me.cmb_Source.ValueMember = "Srl"
        '
        'PmConSourceBindingSource
        '
        Me.PmConSourceBindingSource.DataMember = "Pm_Con_Source"
        Me.PmConSourceBindingSource.DataSource = Me.Ds_Con
        '
        'cmb_Month
        '
        Me.cmb_Month.AutoComplete = True
        Me.cmb_Month.DataSource = Me.PmMonthBindingSource
        Me.cmb_Month.DisplayMember = "name"
        Me.cmb_Month.EnterStop = True
        Me.cmb_Month.FormattingEnabled = True
        Me.cmb_Month.IsRequired = False
        Me.cmb_Month.LimitedToList = True
        Me.cmb_Month.Location = New System.Drawing.Point(327, 5)
        Me.cmb_Month.Name = "cmb_Month"
        Me.cmb_Month.OpenOnFoucus = False
        Me.cmb_Month.Size = New System.Drawing.Size(117, 26)
        Me.cmb_Month.TabIndex = 1
        Me.cmb_Month.Tag = "Month"
        Me.cmb_Month.ValueMember = "Srl"
        '
        'PmMonthBindingSource
        '
        Me.PmMonthBindingSource.DataMember = "Pm_Month"
        Me.PmMonthBindingSource.DataSource = Me.Ds_Con
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(186, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 18)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "نوع صورت وضعیت"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 18)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "ماه"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(690, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 18)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "واحد"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(450, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 18)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "امور"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(686, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 18)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "سال"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 18)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "منبع"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_omoor
        '
        Me.lb_omoor.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lb_omoor.ForeColor = System.Drawing.Color.Green
        Me.lb_omoor.Location = New System.Drawing.Point(23, 73)
        Me.lb_omoor.Name = "lb_omoor"
        Me.lb_omoor.Size = New System.Drawing.Size(144, 18)
        Me.lb_omoor.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(690, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "تاریخ ارسال"
        '
        'txt_sendDate
        '
        Me.txt_sendDate.CheckExistValueInDb = False
        Me.txt_sendDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_sendDate.CurrencyUnit = "ریال"
        Me.txt_sendDate.DefaultValue = ""
        Me.txt_sendDate.FillWithMaxInDb = False
        Me.txt_sendDate.IsRequired = False
        Me.txt_sendDate.Location = New System.Drawing.Point(552, 10)
        Me.txt_sendDate.MaxDecimalLength = 2
        Me.txt_sendDate.Name = "txt_sendDate"
        Me.txt_sendDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_sendDate.Size = New System.Drawing.Size(132, 26)
        Me.txt_sendDate.SpellControl = Nothing
        Me.txt_sendDate.TabIndex = 0
        Me.txt_sendDate.TabStop = False
        Me.txt_sendDate.Tag = "SendDate"
        Me.txt_sendDate.Title = Nothing
        Me.txt_sendDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_sendDate.UseForData = True
        Me.txt_sendDate.ValidateCheckExistOnEdit = False
        Me.txt_sendDate.Value = ""
        '
        'lb_number
        '
        Me.lb_number.AutoSize = True
        Me.lb_number.Location = New System.Drawing.Point(693, 22)
        Me.lb_number.Name = "lb_number"
        Me.lb_number.Size = New System.Drawing.Size(48, 18)
        Me.lb_number.TabIndex = 129
        Me.lb_number.Text = "شماره"
        Me.lb_number.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Number
        '
        Me.txt_Number.CheckExistValueInDb = True
        Me.txt_Number.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Number.CurrencyUnit = "ریال"
        Me.txt_Number.DefaultValue = ""
        Me.txt_Number.FillWithMaxInDb = False
        Me.txt_Number.IsRequired = True
        Me.txt_Number.Location = New System.Drawing.Point(579, 19)
        Me.txt_Number.MaxDecimalLength = 2
        Me.txt_Number.Name = "txt_Number"
        Me.txt_Number.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Number.Size = New System.Drawing.Size(108, 26)
        Me.txt_Number.SpellControl = Nothing
        Me.txt_Number.TabIndex = 0
        Me.txt_Number.Tag = "Number"
        Me.txt_Number.Title = Nothing
        Me.txt_Number.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Number.UseForData = True
        Me.txt_Number.ValidateCheckExistOnEdit = False
        Me.txt_Number.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "شماره نامه"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_LetterNumber
        '
        Me.txt_LetterNumber.CheckExistValueInDb = False
        Me.txt_LetterNumber.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_LetterNumber.CurrencyUnit = "ریال"
        Me.txt_LetterNumber.DefaultValue = ""
        Me.txt_LetterNumber.FillWithMaxInDb = False
        Me.txt_LetterNumber.IsRequired = False
        Me.txt_LetterNumber.Location = New System.Drawing.Point(357, 20)
        Me.txt_LetterNumber.MaxDecimalLength = 2
        Me.txt_LetterNumber.Name = "txt_LetterNumber"
        Me.txt_LetterNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_LetterNumber.Size = New System.Drawing.Size(117, 26)
        Me.txt_LetterNumber.SpellControl = Nothing
        Me.txt_LetterNumber.TabIndex = 1
        Me.txt_LetterNumber.Tag = "LetterNumber"
        Me.txt_LetterNumber.Title = Nothing
        Me.txt_LetterNumber.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_LetterNumber.UseForData = True
        Me.txt_LetterNumber.ValidateCheckExistOnEdit = False
        Me.txt_LetterNumber.Value = ""
        '
        'Pm_MonthTableAdapter
        '
        Me.Pm_MonthTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_SourceTableAdapter
        '
        Me.Pm_Con_SourceTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTypeTableAdapter
        '
        Me.Pm_PostTypeTableAdapter.ClearBeforeFill = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_Excel)
        Me.Panel1.Controls.Add(Me.btn_ConfirmGroup)
        Me.Panel1.Controls.Add(Me.btn_ShowItem)
        Me.Panel1.Controls.Add(Me.btn_Summary)
        Me.Panel1.Controls.Add(Me.btn_Update)
        Me.Panel1.Controls.Add(Me.txt_ConfirmPrice)
        Me.Panel1.Controls.Add(Me.txt_Price)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txt_ConfirmDate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_sendDate)
        Me.Panel1.Location = New System.Drawing.Point(4, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 81)
        Me.Panel1.TabIndex = 3
        '
        'btn_Excel
        '
        Me.btn_Excel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Excel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Excel.Image = Global.Nama_PM.My.Resources.Resources.Excel_icon_png
        Me.btn_Excel.Location = New System.Drawing.Point(116, 11)
        Me.btn_Excel.Name = "btn_Excel"
        Me.btn_Excel.Size = New System.Drawing.Size(26, 25)
        Me.btn_Excel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Excel.TabIndex = 134
        Me.btn_Excel.TabStop = False
        '
        'btn_ConfirmGroup
        '
        Me.btn_ConfirmGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_ConfirmGroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ConfirmGroup.Image = Global.Nama_PM.My.Resources.Resources.write
        Me.btn_ConfirmGroup.Location = New System.Drawing.Point(192, 41)
        Me.btn_ConfirmGroup.Name = "btn_ConfirmGroup"
        Me.btn_ConfirmGroup.Size = New System.Drawing.Size(26, 25)
        Me.btn_ConfirmGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_ConfirmGroup.TabIndex = 134
        Me.btn_ConfirmGroup.TabStop = False
        '
        'btn_ShowItem
        '
        Me.btn_ShowItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_ShowItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ShowItem.Image = Global.Nama_PM.My.Resources.Resources.write
        Me.btn_ShowItem.Location = New System.Drawing.Point(154, 11)
        Me.btn_ShowItem.Name = "btn_ShowItem"
        Me.btn_ShowItem.Size = New System.Drawing.Size(26, 25)
        Me.btn_ShowItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_ShowItem.TabIndex = 134
        Me.btn_ShowItem.TabStop = False
        '
        'btn_Summary
        '
        Me.btn_Summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Summary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Summary.Image = Global.Nama_PM.My.Resources.Resources.paste
        Me.btn_Summary.Location = New System.Drawing.Point(75, 11)
        Me.btn_Summary.Name = "btn_Summary"
        Me.btn_Summary.Size = New System.Drawing.Size(26, 25)
        Me.btn_Summary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Summary.TabIndex = 134
        Me.btn_Summary.TabStop = False
        '
        'btn_Update
        '
        Me.btn_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Update.Image = Global.Nama_PM.My.Resources.Resources.refresh
        Me.btn_Update.Location = New System.Drawing.Point(192, 11)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(26, 25)
        Me.btn_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Update.TabIndex = 134
        Me.btn_Update.TabStop = False
        '
        'txt_ConfirmPrice
        '
        Me.txt_ConfirmPrice.CheckExistValueInDb = False
        Me.txt_ConfirmPrice.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ConfirmPrice.CurrencyUnit = "ریال"
        Me.txt_ConfirmPrice.DefaultValue = ""
        Me.txt_ConfirmPrice.FillWithMaxInDb = False
        Me.txt_ConfirmPrice.IsRequired = False
        Me.txt_ConfirmPrice.Location = New System.Drawing.Point(230, 41)
        Me.txt_ConfirmPrice.MaxDecimalLength = 2
        Me.txt_ConfirmPrice.Name = "txt_ConfirmPrice"
        Me.txt_ConfirmPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ConfirmPrice.Size = New System.Drawing.Size(138, 26)
        Me.txt_ConfirmPrice.SpellControl = Nothing
        Me.txt_ConfirmPrice.TabIndex = 3
        Me.txt_ConfirmPrice.Tag = "ConfirmPrice"
        Me.txt_ConfirmPrice.Text = "0"
        Me.txt_ConfirmPrice.Title = Nothing
        Me.txt_ConfirmPrice.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_ConfirmPrice.UseForData = True
        Me.txt_ConfirmPrice.ValidateCheckExistOnEdit = False
        Me.txt_ConfirmPrice.Value = 0
        '
        'txt_Price
        '
        Me.txt_Price.CheckExistValueInDb = False
        Me.txt_Price.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Price.CurrencyUnit = "ریال"
        Me.txt_Price.DefaultValue = ""
        Me.txt_Price.Enabled = False
        Me.txt_Price.FillWithMaxInDb = False
        Me.txt_Price.IsRequired = False
        Me.txt_Price.Location = New System.Drawing.Point(230, 11)
        Me.txt_Price.MaxDecimalLength = 2
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Price.Size = New System.Drawing.Size(138, 26)
        Me.txt_Price.SpellControl = Nothing
        Me.txt_Price.TabIndex = 1
        Me.txt_Price.Tag = "Price"
        Me.txt_Price.Text = "0"
        Me.txt_Price.Title = Nothing
        Me.txt_Price.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_Price.UseForData = True
        Me.txt_Price.ValidateCheckExistOnEdit = False
        Me.txt_Price.Value = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(372, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 18)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "مبلغ تائید"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(372, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 18)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "مبلغ ارسال"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Green
        Me.Label16.Location = New System.Drawing.Point(23, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 18)
        Me.Label16.TabIndex = 127
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(690, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "تاریخ تائید"
        '
        'txt_ConfirmDate
        '
        Me.txt_ConfirmDate.CheckExistValueInDb = False
        Me.txt_ConfirmDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ConfirmDate.CurrencyUnit = "ریال"
        Me.txt_ConfirmDate.DefaultValue = ""
        Me.txt_ConfirmDate.FillWithMaxInDb = False
        Me.txt_ConfirmDate.IsRequired = False
        Me.txt_ConfirmDate.Location = New System.Drawing.Point(552, 43)
        Me.txt_ConfirmDate.MaxDecimalLength = 2
        Me.txt_ConfirmDate.Name = "txt_ConfirmDate"
        Me.txt_ConfirmDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ConfirmDate.Size = New System.Drawing.Size(132, 26)
        Me.txt_ConfirmDate.SpellControl = Nothing
        Me.txt_ConfirmDate.TabIndex = 2
        Me.txt_ConfirmDate.TabStop = False
        Me.txt_ConfirmDate.Tag = "ConfirmDate"
        Me.txt_ConfirmDate.Title = Nothing
        Me.txt_ConfirmDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ConfirmDate.UseForData = True
        Me.txt_ConfirmDate.ValidateCheckExistOnEdit = False
        Me.txt_ConfirmDate.Value = ""
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.chk_Iscancle)
        Me.Panel2.Controls.Add(Me.txt_Discription)
        Me.Panel2.Controls.Add(Me.txt_DocumentNumber)
        Me.Panel2.Controls.Add(Me.txt_statementNumber)
        Me.Panel2.Controls.Add(Me.txt_ErpDate)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txt_DeliveryNumber)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(4, 220)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 109)
        Me.Panel2.TabIndex = 4
        '
        'chk_Iscancle
        '
        Me.chk_Iscancle.AutoSize = True
        Me.chk_Iscancle.Location = New System.Drawing.Point(693, 75)
        Me.chk_Iscancle.Name = "chk_Iscancle"
        Me.chk_Iscancle.Size = New System.Drawing.Size(60, 22)
        Me.chk_Iscancle.TabIndex = 5
        Me.chk_Iscancle.Tag = "isCancle"
        Me.chk_Iscancle.Text = "ابطال"
        Me.chk_Iscancle.UseVisualStyleBackColor = True
        '
        'txt_Discription
        '
        Me.txt_Discription.CheckExistValueInDb = False
        Me.txt_Discription.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Discription.CurrencyUnit = "ریال"
        Me.txt_Discription.DefaultValue = ""
        Me.txt_Discription.FillWithMaxInDb = False
        Me.txt_Discription.IsRequired = False
        Me.txt_Discription.Location = New System.Drawing.Point(23, 40)
        Me.txt_Discription.MaxDecimalLength = 2
        Me.txt_Discription.Multiline = True
        Me.txt_Discription.Name = "txt_Discription"
        Me.txt_Discription.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Discription.Size = New System.Drawing.Size(424, 57)
        Me.txt_Discription.SpellControl = Nothing
        Me.txt_Discription.TabIndex = 4
        Me.txt_Discription.Tag = "Description"
        Me.txt_Discription.Title = Nothing
        Me.txt_Discription.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Discription.UseForData = True
        Me.txt_Discription.ValidateCheckExistOnEdit = False
        Me.txt_Discription.Value = ""
        '
        'txt_DocumentNumber
        '
        Me.txt_DocumentNumber.CheckExistValueInDb = False
        Me.txt_DocumentNumber.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DocumentNumber.CurrencyUnit = "ریال"
        Me.txt_DocumentNumber.DefaultValue = ""
        Me.txt_DocumentNumber.FillWithMaxInDb = False
        Me.txt_DocumentNumber.IsRequired = False
        Me.txt_DocumentNumber.Location = New System.Drawing.Point(23, 8)
        Me.txt_DocumentNumber.MaxDecimalLength = 2
        Me.txt_DocumentNumber.Name = "txt_DocumentNumber"
        Me.txt_DocumentNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DocumentNumber.Size = New System.Drawing.Size(130, 26)
        Me.txt_DocumentNumber.SpellControl = Nothing
        Me.txt_DocumentNumber.TabIndex = 2
        Me.txt_DocumentNumber.Tag = "DocumentNumber"
        Me.txt_DocumentNumber.Title = Nothing
        Me.txt_DocumentNumber.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DocumentNumber.UseForData = True
        Me.txt_DocumentNumber.ValidateCheckExistOnEdit = False
        Me.txt_DocumentNumber.Value = ""
        '
        'txt_statementNumber
        '
        Me.txt_statementNumber.CheckExistValueInDb = False
        Me.txt_statementNumber.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_statementNumber.CurrencyUnit = "ریال"
        Me.txt_statementNumber.DefaultValue = ""
        Me.txt_statementNumber.FillWithMaxInDb = False
        Me.txt_statementNumber.IsRequired = False
        Me.txt_statementNumber.Location = New System.Drawing.Point(257, 8)
        Me.txt_statementNumber.MaxDecimalLength = 2
        Me.txt_statementNumber.Name = "txt_statementNumber"
        Me.txt_statementNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_statementNumber.Size = New System.Drawing.Size(138, 26)
        Me.txt_statementNumber.SpellControl = Nothing
        Me.txt_statementNumber.TabIndex = 1
        Me.txt_statementNumber.Tag = "StatusNumber"
        Me.txt_statementNumber.Title = Nothing
        Me.txt_statementNumber.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_statementNumber.UseForData = True
        Me.txt_statementNumber.ValidateCheckExistOnEdit = False
        Me.txt_statementNumber.Value = ""
        '
        'txt_ErpDate
        '
        Me.txt_ErpDate.CheckExistValueInDb = False
        Me.txt_ErpDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ErpDate.CurrencyUnit = "ریال"
        Me.txt_ErpDate.DefaultValue = ""
        Me.txt_ErpDate.FillWithMaxInDb = False
        Me.txt_ErpDate.IsRequired = False
        Me.txt_ErpDate.Location = New System.Drawing.Point(544, 40)
        Me.txt_ErpDate.MaxDecimalLength = 2
        Me.txt_ErpDate.Name = "txt_ErpDate"
        Me.txt_ErpDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ErpDate.Size = New System.Drawing.Size(140, 26)
        Me.txt_ErpDate.SpellControl = Nothing
        Me.txt_ErpDate.TabIndex = 3
        Me.txt_ErpDate.TabStop = False
        Me.txt_ErpDate.Tag = "ERPDate"
        Me.txt_ErpDate.Title = Nothing
        Me.txt_ErpDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ErpDate.UseForData = True
        Me.txt_ErpDate.ValidateCheckExistOnEdit = False
        Me.txt_ErpDate.Value = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(690, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 18)
        Me.Label18.TabIndex = 131
        Me.Label18.Text = "تاریخ ERP"
        '
        'txt_DeliveryNumber
        '
        Me.txt_DeliveryNumber.CheckExistValueInDb = False
        Me.txt_DeliveryNumber.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeliveryNumber.CurrencyUnit = "ریال"
        Me.txt_DeliveryNumber.DefaultValue = ""
        Me.txt_DeliveryNumber.FillWithMaxInDb = False
        Me.txt_DeliveryNumber.IsRequired = False
        Me.txt_DeliveryNumber.Location = New System.Drawing.Point(544, 8)
        Me.txt_DeliveryNumber.MaxDecimalLength = 2
        Me.txt_DeliveryNumber.Name = "txt_DeliveryNumber"
        Me.txt_DeliveryNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeliveryNumber.Size = New System.Drawing.Size(138, 26)
        Me.txt_DeliveryNumber.SpellControl = Nothing
        Me.txt_DeliveryNumber.TabIndex = 0
        Me.txt_DeliveryNumber.Tag = "DeliveryNumber"
        Me.txt_DeliveryNumber.Title = Nothing
        Me.txt_DeliveryNumber.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeliveryNumber.UseForData = True
        Me.txt_DeliveryNumber.ValidateCheckExistOnEdit = False
        Me.txt_DeliveryNumber.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(453, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "توضیحات"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(157, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 18)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "شماره سند"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(399, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 18)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "شماره صورت وضعیت"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(686, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 18)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "کد رهگیری"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(23, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 18)
        Me.Label14.TabIndex = 127
        '
        'DataGridView1
        '
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
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(-153, 19)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(0, 0)
        Me.DataGridView1.TabIndex = 130
        Me.DataGridView1.Visible = False
        '
        'Pm_Con_StatusStatementTypeTableAdapter
        '
        Me.Pm_Con_StatusStatementTypeTableAdapter.ClearBeforeFill = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(222, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 18)
        Me.Label19.TabIndex = 129
        Me.Label19.Text = "قرارداد"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.cmb_Contract.Location = New System.Drawing.Point(8, 20)
        Me.cmb_Contract.Name = "cmb_Contract"
        Me.cmb_Contract.OpenOnFoucus = False
        Me.cmb_Contract.Size = New System.Drawing.Size(208, 26)
        Me.cmb_Contract.TabIndex = 2
        Me.cmb_Contract.Tag = "srl_Con_Contract"
        Me.cmb_Contract.ValueMember = "Srl"
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
        'PmConMonthReportAmountBindingSource
        '
        Me.PmConMonthReportAmountBindingSource.DataMember = "Pm_Con_MonthReportAmount"
        Me.PmConMonthReportAmountBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_MonthReportAmount
        '
        Me.Pm_Con_MonthReportAmount.ClearBeforeFill = True
        '
        'Frm_Con_MonthReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(793, 466)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_MonthReport"
        Me.TableName = "pm_con_monthReport"
        Me.Text = "ثبت گزارش ماهیانه صورت وضعیت ها"
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        Me.Pl_WorkForm.ResumeLayout(False)
        Me.Pl_WorkForm.PerformLayout()
        CType(Me.PmConStatusStatementTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_Excel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_ConfirmGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_ShowItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Summary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConMonthReportAmountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PmconstatusStatementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmconContractItemsTarikhBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmconWorkformBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعدادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قیمتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تائیدDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Pl_WorkForm As System.Windows.Forms.Panel
    Friend WithEvents lb_number As System.Windows.Forms.Label
    Public WithEvents txt_Number As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_sendDate As CS_Component.TextBox
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lb_omoor As System.Windows.Forms.Label
    Public WithEvents txt_year As CS_Component.TextBox
    Friend WithEvents cmb_Month As VB_Component.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txt_LetterNumber As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_MonthTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_MonthTableAdapter
    Friend WithEvents cmb_Type As VB_Component.ComboBox
    Friend WithEvents cmb_Source As VB_Component.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PmConSourceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_SourceTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
    Friend WithEvents cmb_Omor As VB_Component.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTypeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTypeTableAdapter
    Friend WithEvents cmb_Vahed As VB_Component.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents txt_Price As CS_Component.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_ConfirmDate As CS_Component.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents txt_DocumentNumber As CS_Component.TextBox
    Public WithEvents txt_statementNumber As CS_Component.TextBox
    Public WithEvents txt_DeliveryNumber As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_ErpDate As CS_Component.TextBox
    Public WithEvents txt_ConfirmPrice As CS_Component.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chk_Iscancle As System.Windows.Forms.CheckBox
    Public WithEvents txt_Discription As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents PmConStatusStatementTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_StatusStatementTypeTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementTypeTableAdapter
    Friend WithEvents cmb_Contract As VB_Component.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents btn_Update As System.Windows.Forms.PictureBox
    Friend WithEvents btn_ShowItem As System.Windows.Forms.PictureBox
    Friend WithEvents PmConMonthReportAmountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_MonthReportAmount As Nama_PM.Ds_ConTableAdapters.Pm_Con_MonthReportAmount
    Friend WithEvents btn_Excel As System.Windows.Forms.PictureBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_ConfirmGroup As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Summary As System.Windows.Forms.PictureBox
End Class
