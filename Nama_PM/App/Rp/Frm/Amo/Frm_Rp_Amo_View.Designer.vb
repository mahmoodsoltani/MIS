<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_Amo_View
    Inherits BaseForm

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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_PrintDore = New CS_Component.Btn
        Me.lbl_Record = New System.Windows.Forms.Label
        Me.Btn_print = New CS_Component.Btn
        Me.Btn_Search = New CS_Component.Btn
        Me.chk_Name = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Cmb_Name = New VB_Component.ComboBox
        Me.PmAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.txt_Modat = New CS_Component.TextBox
        Me.Cmb_MahalBArgozary = New VB_Component.ComboBox
        Me.PmAmoMahaleBargozaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Amozesh = New Nama_PM.Ds_Amozesh
        Me.cmb_Moasese = New VB_Component.ComboBox
        Me.PmAmoMoaseseAmozeshiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Type = New VB_Component.ComboBox
        Me.PmAmoDoreTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Zaman = New VB_Component.ComboBox
        Me.PmAmoZamanDoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_VAhed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.cmb_DoreName = New VB_Component.ComboBox
        Me.PmAmoDoreNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_Zaman = New System.Windows.Forms.CheckBox
        Me.chk_Type = New System.Windows.Forms.CheckBox
        Me.chk_Modat = New System.Windows.Forms.CheckBox
        Me.chk_MahalBArgozary = New System.Windows.Forms.CheckBox
        Me.chk_DoreName = New System.Windows.Forms.CheckBox
        Me.chk_Vahed = New System.Windows.Forms.CheckBox
        Me.chk_moasese = New System.Windows.Forms.CheckBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chk_allday = New System.Windows.Forms.CheckBox
        Me.Pm_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
        Me.Pm_Amo_DoreTypeTableAdapter = New Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_DoreTypeTableAdapter
        Me.Pm_Amo_DoreNameTableAdapter = New Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_DoreNameTableAdapter
        Me.Pm_Amo_ZamanDoreTableAdapter = New Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_ZamanDoreTableAdapter
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_Amo_MoaseseAmozeshiTableAdapter = New Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_MoaseseAmozeshiTableAdapter
        Me.Pm_Amo_MahaleBargozaryTableAdapter = New Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_MahaleBargozaryTableAdapter
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامونامخانوادگیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعدورهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامدورهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مدتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.زماندورهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلبرگزارریDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.موسسهآموزشیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmAmoDoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmAmoDoreNameBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Amo_DoreTableAdapter = New Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_DoreTableAdapter
        Me.Panel1.SuspendLayout()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAmoMahaleBargozaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Amozesh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAmoMoaseseAmozeshiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAmoDoreTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAmoZamanDoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAmoDoreNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAmoDoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAmoDoreNameBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Btn_PrintDore)
        Me.Panel1.Controls.Add(Me.lbl_Record)
        Me.Panel1.Controls.Add(Me.Btn_print)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Location = New System.Drawing.Point(11, 199)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 36)
        Me.Panel1.TabIndex = 178
        '
        'Btn_PrintDore
        '
        Me.Btn_PrintDore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_PrintDore.BackColor = System.Drawing.Color.Transparent
        Me.Btn_PrintDore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_PrintDore.HeaderText = "چاپ گزارش آموزش"
        Me.Btn_PrintDore.Location = New System.Drawing.Point(663, 4)
        Me.Btn_PrintDore.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_PrintDore.Name = "Btn_PrintDore"
        Me.Btn_PrintDore.Size = New System.Drawing.Size(141, 26)
        Me.Btn_PrintDore.TabIndex = 162
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
        Me.Btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_print.BackColor = System.Drawing.Color.Transparent
        Me.Btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_print.HeaderText = "چاپ"
        Me.Btn_print.Location = New System.Drawing.Point(514, 4)
        Me.Btn_print.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_print.Name = "Btn_print"
        Me.Btn_print.Size = New System.Drawing.Size(141, 26)
        Me.Btn_print.TabIndex = 160
        '
        'Btn_Search
        '
        Me.Btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.HeaderText = "جستجو"
        Me.Btn_Search.Location = New System.Drawing.Point(812, 4)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(141, 26)
        Me.Btn_Search.TabIndex = 0
        '
        'chk_Name
        '
        Me.chk_Name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Name.AutoSize = True
        Me.chk_Name.Checked = True
        Me.chk_Name.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Name.Location = New System.Drawing.Point(926, 65)
        Me.chk_Name.Name = "chk_Name"
        Me.chk_Name.Size = New System.Drawing.Size(49, 22)
        Me.chk_Name.TabIndex = 197
        Me.chk_Name.Text = "نام "
        Me.chk_Name.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(96, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 18)
        Me.Label11.TabIndex = 196
        Me.Label11.Text = "ساعت"
        '
        'Cmb_Name
        '
        Me.Cmb_Name.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmb_Name.AutoComplete = True
        Me.Cmb_Name.DataSource = Me.PmAshkhasBindingSource
        Me.Cmb_Name.DisplayMember = "نام و نام خانوادگی"
        Me.Cmb_Name.EnterStop = True
        Me.Cmb_Name.FormattingEnabled = True
        Me.Cmb_Name.IsRequired = True
        Me.Cmb_Name.LimitedToList = True
        Me.Cmb_Name.Location = New System.Drawing.Point(714, 62)
        Me.Cmb_Name.Name = "Cmb_Name"
        Me.Cmb_Name.OpenOnFoucus = False
        Me.Cmb_Name.Size = New System.Drawing.Size(178, 26)
        Me.Cmb_Name.TabIndex = 179
        Me.Cmb_Name.Tag = "Srl_Pm_Ashkhas"
        Me.Cmb_Name.ValueMember = "Srl"
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
        'txt_Modat
        '
        Me.txt_Modat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Modat.CheckExistValueInDb = False
        Me.txt_Modat.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Modat.CurrencyUnit = "ریال"
        Me.txt_Modat.DefaultValue = "0"
        Me.txt_Modat.FillWithMaxInDb = False
        Me.txt_Modat.IsRequired = True
        Me.txt_Modat.Location = New System.Drawing.Point(152, 128)
        Me.txt_Modat.MaxDecimalLength = 2
        Me.txt_Modat.Name = "txt_Modat"
        Me.txt_Modat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Modat.Size = New System.Drawing.Size(122, 26)
        Me.txt_Modat.SpellControl = Nothing
        Me.txt_Modat.TabIndex = 185
        Me.txt_Modat.Tag = ""
        Me.txt_Modat.Text = "0"
        Me.txt_Modat.Title = Nothing
        Me.txt_Modat.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_Modat.UseForData = True
        Me.txt_Modat.ValidateCheckExistOnEdit = False
        Me.txt_Modat.Value = 0.0!
        '
        'Cmb_MahalBArgozary
        '
        Me.Cmb_MahalBArgozary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmb_MahalBArgozary.AutoComplete = True
        Me.Cmb_MahalBArgozary.DataSource = Me.PmAmoMahaleBargozaryBindingSource
        Me.Cmb_MahalBArgozary.DisplayMember = "محل برگزاری دوره"
        Me.Cmb_MahalBArgozary.EnterStop = True
        Me.Cmb_MahalBArgozary.FormattingEnabled = True
        Me.Cmb_MahalBArgozary.IsRequired = True
        Me.Cmb_MahalBArgozary.LimitedToList = True
        Me.Cmb_MahalBArgozary.Location = New System.Drawing.Point(96, 63)
        Me.Cmb_MahalBArgozary.Name = "Cmb_MahalBArgozary"
        Me.Cmb_MahalBArgozary.OpenOnFoucus = False
        Me.Cmb_MahalBArgozary.Size = New System.Drawing.Size(178, 26)
        Me.Cmb_MahalBArgozary.TabIndex = 184
        Me.Cmb_MahalBArgozary.Tag = "Srl_Pm_Amo_MahaleBargozary"
        Me.Cmb_MahalBArgozary.ValueMember = "Srl"
        '
        'PmAmoMahaleBargozaryBindingSource
        '
        Me.PmAmoMahaleBargozaryBindingSource.DataMember = "Pm_Amo_MahaleBargozary"
        Me.PmAmoMahaleBargozaryBindingSource.DataSource = Me.Ds_Amozesh
        '
        'Ds_Amozesh
        '
        Me.Ds_Amozesh.DataSetName = "Ds_Amozesh"
        Me.Ds_Amozesh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_Moasese
        '
        Me.cmb_Moasese.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_Moasese.AutoComplete = True
        Me.cmb_Moasese.DataSource = Me.PmAmoMoaseseAmozeshiBindingSource
        Me.cmb_Moasese.DisplayMember = "موسسات آموزشی"
        Me.cmb_Moasese.EnterStop = True
        Me.cmb_Moasese.FormattingEnabled = True
        Me.cmb_Moasese.IsRequired = True
        Me.cmb_Moasese.LimitedToList = True
        Me.cmb_Moasese.Location = New System.Drawing.Point(96, 95)
        Me.cmb_Moasese.Name = "cmb_Moasese"
        Me.cmb_Moasese.OpenOnFoucus = False
        Me.cmb_Moasese.Size = New System.Drawing.Size(178, 26)
        Me.cmb_Moasese.TabIndex = 189
        Me.cmb_Moasese.Tag = ""
        Me.cmb_Moasese.ValueMember = "Srl"
        '
        'PmAmoMoaseseAmozeshiBindingSource
        '
        Me.PmAmoMoaseseAmozeshiBindingSource.DataMember = "Pm_Amo_MoaseseAmozeshi"
        Me.PmAmoMoaseseAmozeshiBindingSource.DataSource = Me.Ds_Amozesh
        '
        'cmb_Type
        '
        Me.cmb_Type.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_Type.AutoComplete = True
        Me.cmb_Type.DataSource = Me.PmAmoDoreTypeBindingSource
        Me.cmb_Type.DisplayMember = "نوع دوره"
        Me.cmb_Type.EnterStop = True
        Me.cmb_Type.FormattingEnabled = True
        Me.cmb_Type.IsRequired = True
        Me.cmb_Type.LimitedToList = True
        Me.cmb_Type.Location = New System.Drawing.Point(713, 95)
        Me.cmb_Type.Name = "cmb_Type"
        Me.cmb_Type.OpenOnFoucus = False
        Me.cmb_Type.Size = New System.Drawing.Size(179, 26)
        Me.cmb_Type.TabIndex = 182
        Me.cmb_Type.Tag = "Srl_Pm_Amo_DoreType"
        Me.cmb_Type.ValueMember = "Srl"
        '
        'PmAmoDoreTypeBindingSource
        '
        Me.PmAmoDoreTypeBindingSource.DataMember = "Pm_Amo_DoreType"
        Me.PmAmoDoreTypeBindingSource.DataSource = Me.Ds_Amozesh
        '
        'cmb_Zaman
        '
        Me.cmb_Zaman.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_Zaman.AutoComplete = True
        Me.cmb_Zaman.DataSource = Me.PmAmoZamanDoreBindingSource
        Me.cmb_Zaman.DisplayMember = "زمان دوره"
        Me.cmb_Zaman.EnterStop = True
        Me.cmb_Zaman.FormattingEnabled = True
        Me.cmb_Zaman.IsRequired = True
        Me.cmb_Zaman.LimitedToList = True
        Me.cmb_Zaman.Location = New System.Drawing.Point(432, 97)
        Me.cmb_Zaman.Name = "cmb_Zaman"
        Me.cmb_Zaman.OpenOnFoucus = False
        Me.cmb_Zaman.Size = New System.Drawing.Size(178, 26)
        Me.cmb_Zaman.TabIndex = 180
        Me.cmb_Zaman.Tag = "Srl_Pm_Amo_ZamanDore"
        Me.cmb_Zaman.ValueMember = "Srl"
        '
        'PmAmoZamanDoreBindingSource
        '
        Me.PmAmoZamanDoreBindingSource.DataMember = "Pm_Amo_ZamanDore"
        Me.PmAmoZamanDoreBindingSource.DataSource = Me.Ds_Amozesh
        '
        'cmb_VAhed
        '
        Me.cmb_VAhed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_VAhed.AutoComplete = True
        Me.cmb_VAhed.DataSource = Me.PmVahedBindingSource
        Me.cmb_VAhed.DisplayMember = "نام واحد"
        Me.cmb_VAhed.EnterStop = True
        Me.cmb_VAhed.FormattingEnabled = True
        Me.cmb_VAhed.IsRequired = True
        Me.cmb_VAhed.LimitedToList = True
        Me.cmb_VAhed.Location = New System.Drawing.Point(432, 63)
        Me.cmb_VAhed.Name = "cmb_VAhed"
        Me.cmb_VAhed.OpenOnFoucus = False
        Me.cmb_VAhed.Size = New System.Drawing.Size(179, 26)
        Me.cmb_VAhed.TabIndex = 186
        Me.cmb_VAhed.Tag = ""
        Me.cmb_VAhed.ValueMember = "Srl"
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
        'cmb_DoreName
        '
        Me.cmb_DoreName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_DoreName.AutoComplete = True
        Me.cmb_DoreName.DataSource = Me.PmAmoDoreNameBindingSource
        Me.cmb_DoreName.DisplayMember = "نام دوره"
        Me.cmb_DoreName.EnterStop = True
        Me.cmb_DoreName.FormattingEnabled = True
        Me.cmb_DoreName.IsRequired = True
        Me.cmb_DoreName.LimitedToList = True
        Me.cmb_DoreName.Location = New System.Drawing.Point(432, 128)
        Me.cmb_DoreName.Name = "cmb_DoreName"
        Me.cmb_DoreName.OpenOnFoucus = False
        Me.cmb_DoreName.Size = New System.Drawing.Size(460, 26)
        Me.cmb_DoreName.TabIndex = 183
        Me.cmb_DoreName.Tag = "Srl_Pm_Amo_DoreName"
        Me.cmb_DoreName.ValueMember = "Srl"
        '
        'PmAmoDoreNameBindingSource
        '
        Me.PmAmoDoreNameBindingSource.DataMember = "Pm_Amo_DoreName"
        Me.PmAmoDoreNameBindingSource.DataSource = Me.Ds_Amozesh
        '
        'chk_Zaman
        '
        Me.chk_Zaman.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Zaman.AutoSize = True
        Me.chk_Zaman.Checked = True
        Me.chk_Zaman.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Zaman.Location = New System.Drawing.Point(618, 102)
        Me.chk_Zaman.Name = "chk_Zaman"
        Me.chk_Zaman.Size = New System.Drawing.Size(84, 22)
        Me.chk_Zaman.TabIndex = 197
        Me.chk_Zaman.Text = "زمان دوره"
        Me.chk_Zaman.UseVisualStyleBackColor = True
        '
        'chk_Type
        '
        Me.chk_Type.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Type.AutoSize = True
        Me.chk_Type.Checked = True
        Me.chk_Type.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Type.Location = New System.Drawing.Point(898, 100)
        Me.chk_Type.Name = "chk_Type"
        Me.chk_Type.Size = New System.Drawing.Size(77, 22)
        Me.chk_Type.TabIndex = 197
        Me.chk_Type.Text = "نوع دوره"
        Me.chk_Type.UseVisualStyleBackColor = True
        '
        'chk_Modat
        '
        Me.chk_Modat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Modat.AutoSize = True
        Me.chk_Modat.Checked = True
        Me.chk_Modat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Modat.Location = New System.Drawing.Point(336, 130)
        Me.chk_Modat.Name = "chk_Modat"
        Me.chk_Modat.Size = New System.Drawing.Size(85, 22)
        Me.chk_Modat.TabIndex = 197
        Me.chk_Modat.Text = "مدت دوره"
        Me.chk_Modat.UseVisualStyleBackColor = True
        '
        'chk_MahalBArgozary
        '
        Me.chk_MahalBArgozary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_MahalBArgozary.AutoSize = True
        Me.chk_MahalBArgozary.Checked = True
        Me.chk_MahalBArgozary.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_MahalBArgozary.Location = New System.Drawing.Point(315, 65)
        Me.chk_MahalBArgozary.Name = "chk_MahalBArgozary"
        Me.chk_MahalBArgozary.Size = New System.Drawing.Size(106, 22)
        Me.chk_MahalBArgozary.TabIndex = 197
        Me.chk_MahalBArgozary.Text = "محل برگزاری"
        Me.chk_MahalBArgozary.UseVisualStyleBackColor = True
        '
        'chk_DoreName
        '
        Me.chk_DoreName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_DoreName.AutoSize = True
        Me.chk_DoreName.Checked = True
        Me.chk_DoreName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_DoreName.Location = New System.Drawing.Point(901, 133)
        Me.chk_DoreName.Name = "chk_DoreName"
        Me.chk_DoreName.Size = New System.Drawing.Size(74, 22)
        Me.chk_DoreName.TabIndex = 197
        Me.chk_DoreName.Text = "نام دوره"
        Me.chk_DoreName.UseVisualStyleBackColor = True
        '
        'chk_Vahed
        '
        Me.chk_Vahed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Vahed.AutoSize = True
        Me.chk_Vahed.Checked = True
        Me.chk_Vahed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Vahed.Location = New System.Drawing.Point(647, 65)
        Me.chk_Vahed.Name = "chk_Vahed"
        Me.chk_Vahed.Size = New System.Drawing.Size(55, 22)
        Me.chk_Vahed.TabIndex = 197
        Me.chk_Vahed.Text = "واحد"
        Me.chk_Vahed.UseVisualStyleBackColor = True
        '
        'chk_moasese
        '
        Me.chk_moasese.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_moasese.AutoSize = True
        Me.chk_moasese.Checked = True
        Me.chk_moasese.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_moasese.Location = New System.Drawing.Point(280, 97)
        Me.chk_moasese.Name = "chk_moasese"
        Me.chk_moasese.Size = New System.Drawing.Size(141, 22)
        Me.chk_moasese.TabIndex = 197
        Me.chk_moasese.Text = "موسسه آموزشی"
        Me.chk_moasese.UseVisualStyleBackColor = True
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
        Me.txt_ToDate.Location = New System.Drawing.Point(518, 163)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(154, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 200
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
        Me.txt_FromDate.Location = New System.Drawing.Point(737, 163)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(154, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 199
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
        Me.Label2.Location = New System.Drawing.Point(678, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "تا تاریخ"
        '
        'chk_allday
        '
        Me.chk_allday.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_allday.AutoSize = True
        Me.chk_allday.Checked = True
        Me.chk_allday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_allday.Location = New System.Drawing.Point(906, 167)
        Me.chk_allday.Name = "chk_allday"
        Me.chk_allday.Size = New System.Drawing.Size(69, 22)
        Me.chk_allday.TabIndex = 198
        Me.chk_allday.Text = "تاریخ از"
        Me.chk_allday.UseVisualStyleBackColor = True
        '
        'Pm_AshkhasTableAdapter
        '
        Me.Pm_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'Pm_Amo_DoreTypeTableAdapter
        '
        Me.Pm_Amo_DoreTypeTableAdapter.ClearBeforeFill = True
        '
        'Pm_Amo_DoreNameTableAdapter
        '
        Me.Pm_Amo_DoreNameTableAdapter.ClearBeforeFill = True
        '
        'Pm_Amo_ZamanDoreTableAdapter
        '
        Me.Pm_Amo_ZamanDoreTableAdapter.ClearBeforeFill = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_Amo_MoaseseAmozeshiTableAdapter
        '
        Me.Pm_Amo_MoaseseAmozeshiTableAdapter.ClearBeforeFill = True
        '
        'Pm_Amo_MahaleBargozaryTableAdapter
        '
        Me.Pm_Amo_MahaleBargozaryTableAdapter.ClearBeforeFill = True
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
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.نامونامخانوادگیDataGridViewTextBoxColumn, Me.نوعدورهDataGridViewTextBoxColumn, Me.نامدورهDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.مدتDataGridViewTextBoxColumn, Me.زماندورهDataGridViewTextBoxColumn, Me.محلبرگزارریDataGridViewTextBoxColumn, Me.موسسهآموزشیDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmAmoDoreBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(6, 241)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(986, 327)
        Me.DataGridView1.TabIndex = 202
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'نامونامخانوادگیDataGridViewTextBoxColumn
        '
        Me.نامونامخانوادگیDataGridViewTextBoxColumn.DataPropertyName = "نام و نام خانوادگی"
        Me.نامونامخانوادگیDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی"
        Me.نامونامخانوادگیDataGridViewTextBoxColumn.Name = "نامونامخانوادگیDataGridViewTextBoxColumn"
        Me.نامونامخانوادگیDataGridViewTextBoxColumn.ReadOnly = True
        Me.نامونامخانوادگیDataGridViewTextBoxColumn.Width = 145
        '
        'نوعدورهDataGridViewTextBoxColumn
        '
        Me.نوعدورهDataGridViewTextBoxColumn.DataPropertyName = "نوع دوره"
        Me.نوعدورهDataGridViewTextBoxColumn.HeaderText = "نوع دوره"
        Me.نوعدورهDataGridViewTextBoxColumn.Name = "نوعدورهDataGridViewTextBoxColumn"
        Me.نوعدورهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامدورهDataGridViewTextBoxColumn
        '
        Me.نامدورهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامدورهDataGridViewTextBoxColumn.DataPropertyName = "نام دوره"
        Me.نامدورهDataGridViewTextBoxColumn.HeaderText = "نام دوره"
        Me.نامدورهDataGridViewTextBoxColumn.Name = "نامدورهDataGridViewTextBoxColumn"
        Me.نامدورهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مدتDataGridViewTextBoxColumn
        '
        Me.مدتDataGridViewTextBoxColumn.DataPropertyName = "مدت"
        Me.مدتDataGridViewTextBoxColumn.HeaderText = "مدت"
        Me.مدتDataGridViewTextBoxColumn.Name = "مدتDataGridViewTextBoxColumn"
        Me.مدتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'زماندورهDataGridViewTextBoxColumn
        '
        Me.زماندورهDataGridViewTextBoxColumn.DataPropertyName = "زمان دوره"
        Me.زماندورهDataGridViewTextBoxColumn.HeaderText = "زمان دوره"
        Me.زماندورهDataGridViewTextBoxColumn.Name = "زماندورهDataGridViewTextBoxColumn"
        Me.زماندورهDataGridViewTextBoxColumn.ReadOnly = True
        Me.زماندورهDataGridViewTextBoxColumn.Width = 130
        '
        'محلبرگزارریDataGridViewTextBoxColumn
        '
        Me.محلبرگزارریDataGridViewTextBoxColumn.DataPropertyName = "محل برگزارری"
        Me.محلبرگزارریDataGridViewTextBoxColumn.HeaderText = "محل برگزارری"
        Me.محلبرگزارریDataGridViewTextBoxColumn.Name = "محلبرگزارریDataGridViewTextBoxColumn"
        Me.محلبرگزارریDataGridViewTextBoxColumn.ReadOnly = True
        '
        'موسسهآموزشیDataGridViewTextBoxColumn
        '
        Me.موسسهآموزشیDataGridViewTextBoxColumn.DataPropertyName = "موسسه آموزشی"
        Me.موسسهآموزشیDataGridViewTextBoxColumn.HeaderText = "موسسه آموزشی"
        Me.موسسهآموزشیDataGridViewTextBoxColumn.Name = "موسسهآموزشیDataGridViewTextBoxColumn"
        Me.موسسهآموزشیDataGridViewTextBoxColumn.ReadOnly = True
        Me.موسسهآموزشیDataGridViewTextBoxColumn.Width = 140
        '
        'PmAmoDoreBindingSource
        '
        Me.PmAmoDoreBindingSource.DataMember = "Pm_Amo_Dore"
        Me.PmAmoDoreBindingSource.DataSource = Me.Ds_Amozesh
        '
        'PmAmoDoreNameBindingSource1
        '
        Me.PmAmoDoreNameBindingSource1.DataMember = "Pm_Amo_DoreName"
        Me.PmAmoDoreNameBindingSource1.DataSource = Me.Ds_Amozesh
        '
        'Pm_Amo_DoreTableAdapter
        '
        Me.Pm_Amo_DoreTableAdapter.ClearBeforeFill = True
        '
        'Frm_Rp_Amo_View
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(999, 597)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_ToDate)
        Me.Controls.Add(Me.txt_FromDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_allday)
        Me.Controls.Add(Me.chk_MahalBArgozary)
        Me.Controls.Add(Me.chk_Modat)
        Me.Controls.Add(Me.chk_Type)
        Me.Controls.Add(Me.chk_Zaman)
        Me.Controls.Add(Me.chk_Name)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Cmb_Name)
        Me.Controls.Add(Me.txt_Modat)
        Me.Controls.Add(Me.Cmb_MahalBArgozary)
        Me.Controls.Add(Me.cmb_Type)
        Me.Controls.Add(Me.cmb_Zaman)
        Me.Controls.Add(Me.chk_DoreName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chk_Vahed)
        Me.Controls.Add(Me.cmb_Moasese)
        Me.Controls.Add(Me.cmb_DoreName)
        Me.Controls.Add(Me.cmb_VAhed)
        Me.Controls.Add(Me.chk_moasese)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Rp_Amo_View"
        Me.Text = "گزارش آموزشها"
        Me.Controls.SetChildIndex(Me.chk_moasese, 0)
        Me.Controls.SetChildIndex(Me.cmb_VAhed, 0)
        Me.Controls.SetChildIndex(Me.cmb_DoreName, 0)
        Me.Controls.SetChildIndex(Me.cmb_Moasese, 0)
        Me.Controls.SetChildIndex(Me.chk_Vahed, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.chk_DoreName, 0)
        Me.Controls.SetChildIndex(Me.cmb_Zaman, 0)
        Me.Controls.SetChildIndex(Me.cmb_Type, 0)
        Me.Controls.SetChildIndex(Me.Cmb_MahalBArgozary, 0)
        Me.Controls.SetChildIndex(Me.txt_Modat, 0)
        Me.Controls.SetChildIndex(Me.Cmb_Name, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.chk_Name, 0)
        Me.Controls.SetChildIndex(Me.chk_Zaman, 0)
        Me.Controls.SetChildIndex(Me.chk_Type, 0)
        Me.Controls.SetChildIndex(Me.chk_Modat, 0)
        Me.Controls.SetChildIndex(Me.chk_MahalBArgozary, 0)
        Me.Controls.SetChildIndex(Me.chk_allday, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txt_FromDate, 0)
        Me.Controls.SetChildIndex(Me.txt_ToDate, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAmoMahaleBargozaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Amozesh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAmoMoaseseAmozeshiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAmoDoreTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAmoZamanDoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAmoDoreNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAmoDoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAmoDoreNameBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Record As System.Windows.Forms.Label
    Friend WithEvents Btn_print As CS_Component.Btn
    Friend WithEvents Btn_Search As CS_Component.Btn
    Friend WithEvents chk_Name As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Name As VB_Component.ComboBox
    Friend WithEvents txt_Modat As CS_Component.TextBox
    Friend WithEvents Cmb_MahalBArgozary As VB_Component.ComboBox
    Friend WithEvents cmb_Moasese As VB_Component.ComboBox
    Friend WithEvents cmb_Type As VB_Component.ComboBox
    Friend WithEvents cmb_Zaman As VB_Component.ComboBox
    Friend WithEvents cmb_VAhed As VB_Component.ComboBox
    Friend WithEvents cmb_DoreName As VB_Component.ComboBox
    Friend WithEvents chk_Zaman As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Type As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Modat As System.Windows.Forms.CheckBox
    Friend WithEvents chk_MahalBArgozary As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DoreName As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Vahed As System.Windows.Forms.CheckBox
    Friend WithEvents chk_moasese As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_allday As System.Windows.Forms.CheckBox
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents PmAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents Ds_Amozesh As Nama_PM.Ds_Amozesh
    Friend WithEvents PmAmoDoreTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Amo_DoreTypeTableAdapter As Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_DoreTypeTableAdapter
    Friend WithEvents PmAmoDoreNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Amo_DoreNameTableAdapter As Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_DoreNameTableAdapter
    Friend WithEvents PmAmoZamanDoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Amo_ZamanDoreTableAdapter As Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_ZamanDoreTableAdapter
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmAmoMoaseseAmozeshiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Amo_MoaseseAmozeshiTableAdapter As Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_MoaseseAmozeshiTableAdapter
    Friend WithEvents PmAmoMahaleBargozaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Amo_MahaleBargozaryTableAdapter As Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_MahaleBargozaryTableAdapter
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents PmAmoDoreNameBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PmAmoDoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Amo_DoreTableAdapter As Nama_PM.Ds_AmozeshTableAdapters.Pm_Amo_DoreTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامونامخانوادگیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعدورهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامدورهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مدتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents زماندورهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلبرگزارریDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents موسسهآموزشیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_PrintDore As CS_Component.Btn
End Class
