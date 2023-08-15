<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_FactorSubmit
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lk_Sherkat = New CS_Component.LookupBox
        Me.PmSherkatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.txt_FactorNo = New CS_Component.TextBox
        Me.txt_FatorDate = New CS_Component.TextBox
        Me.txt_FActorNoKhaird = New CS_Component.TextBox
        Me.lbl_FacNoKharid = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.StgAnbarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Kala = New Nama_PM.Ds_Kala
        Me.Cmb_Anbar = New VB_Component.ComboBox
        Me.Pnl_Kala_Kharid = New System.Windows.Forms.Panel
        Me.Panel_Kharid = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_TakhfifDarsad = New CS_Component.TextBox
        Me.txt_Jam = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_Takhfif = New CS_Component.TextBox
        Me.txt_TolidDate = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_ExpDate = New CS_Component.TextBox
        Me.KalaSelectManager1 = New KalaSelectManager
        Me.txt_Vahed = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Gheimat = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Lbl_Anbar = New System.Windows.Forms.Label
        Me.txt_KalaNo = New CS_Component.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.ردیف = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدکالاDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامکالاDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تعدادDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.واحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.قیمتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.جمعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تولیدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.انقضاءDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.انقضاء = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تولید = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.توضیحاتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تخفیفDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.انبارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مالیاتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عوارضDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlStgFactorMasterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlStgKalaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlStgAnbarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrStgVahedFareeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StgFactorDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Dis = New CS_Component.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_JamKol = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Btn_Setting = New CS_Component.Btn
        Me.Btn_Del = New CS_Component.Btn
        Me.Btn_Edit = New CS_Component.Btn
        Me.Btn_Add = New CS_Component.Btn
        Me.Stg_FactorDetailsTableAdapter = New Nama_PM.Ds_KalaTableAdapters.Stg_FactorDetailsTableAdapter
        Me.Pm_SherkatTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_SherkatTableAdapter
        Me.Stg_AnbarTableAdapter = New Nama_PM.Ds_KalaTableAdapters.Stg_AnbarTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PmSherkatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StgAnbarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Kala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Kala_Kharid.SuspendLayout()
        Me.Panel_Kharid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StgFactorDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(12, 546)
        Me.gbx_Buttons.Size = New System.Drawing.Size(933, 50)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(842, 17)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Panel3)
        Me.gbx_Fields.Controls.Add(Me.txt_JamKol)
        Me.gbx_Fields.Controls.Add(Me.Label10)
        Me.gbx_Fields.Controls.Add(Me.Label9)
        Me.gbx_Fields.Controls.Add(Me.txt_Dis)
        Me.gbx_Fields.Controls.Add(Me.DataGridView1)
        Me.gbx_Fields.Controls.Add(Me.Pnl_Kala_Kharid)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Size = New System.Drawing.Size(933, 508)
        Me.gbx_Fields.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lk_Sherkat)
        Me.Panel1.Controls.Add(Me.txt_FactorNo)
        Me.Panel1.Controls.Add(Me.txt_FatorDate)
        Me.Panel1.Controls.Add(Me.txt_FActorNoKhaird)
        Me.Panel1.Controls.Add(Me.lbl_FacNoKharid)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(5, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 48)
        Me.Panel1.TabIndex = 0
        '
        'lk_Sherkat
        '
        Me.lk_Sherkat.CodeBoxWidth = 0
        Me.lk_Sherkat.CodeField = "کد"
        Me.lk_Sherkat.DataAccess = Nothing
        Me.lk_Sherkat.DataFields = Nothing
        Me.lk_Sherkat.DataMode = CS_Component.LookupDataMode.UseDataTable
        Me.lk_Sherkat.DataSource = Me.PmSherkatBindingSource
        Me.lk_Sherkat.DefaultSearchField = "Srl"
        Me.lk_Sherkat.DisplayCodeBox = False
        Me.lk_Sherkat.DisplayField = "نام"
        Me.lk_Sherkat.Filter = ""
        Me.lk_Sherkat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lk_Sherkat.HiddenFields = Nothing
        Me.lk_Sherkat.Location = New System.Drawing.Point(553, 10)
        Me.lk_Sherkat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lk_Sherkat.Name = "lk_Sherkat"
        Me.lk_Sherkat.Result = Nothing
        Me.lk_Sherkat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lk_Sherkat.Size = New System.Drawing.Size(304, 26)
        Me.lk_Sherkat.TabIndex = 73
        Me.lk_Sherkat.TableName = Nothing
        Me.lk_Sherkat.ValueField = "Srl"
        '
        'PmSherkatBindingSource
        '
        Me.PmSherkatBindingSource.DataMember = "Pm_Sherkat"
        Me.PmSherkatBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_FactorNo
        '
        Me.txt_FactorNo.CheckExistValueInDb = True
        Me.txt_FactorNo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FactorNo.CurrencyUnit = "ریال"
        Me.txt_FactorNo.DefaultValue = "1"
        Me.txt_FactorNo.FillWithMaxInDb = False
        Me.txt_FactorNo.IsRequired = True
        Me.txt_FactorNo.Location = New System.Drawing.Point(381, 12)
        Me.txt_FactorNo.MaxDecimalLength = 2
        Me.txt_FactorNo.Name = "txt_FactorNo"
        Me.txt_FactorNo.Size = New System.Drawing.Size(77, 23)
        Me.txt_FactorNo.SpellControl = Nothing
        Me.txt_FactorNo.TabIndex = 1
        Me.txt_FactorNo.Tag = "FactorNo"
        Me.txt_FactorNo.Text = "1"
        Me.txt_FactorNo.Title = Nothing
        Me.txt_FactorNo.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_FactorNo.UseForData = True
        Me.txt_FactorNo.ValidateCheckExistOnEdit = False
        Me.txt_FactorNo.Value = 1
        '
        'txt_FatorDate
        '
        Me.txt_FatorDate.CheckExistValueInDb = False
        Me.txt_FatorDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FatorDate.CurrencyUnit = "ریال"
        Me.txt_FatorDate.DefaultValue = ""
        Me.txt_FatorDate.FillWithMaxInDb = False
        Me.txt_FatorDate.IsRequired = True
        Me.txt_FatorDate.Location = New System.Drawing.Point(182, 12)
        Me.txt_FatorDate.MaxDecimalLength = 2
        Me.txt_FatorDate.Name = "txt_FatorDate"
        Me.txt_FatorDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FatorDate.Size = New System.Drawing.Size(132, 23)
        Me.txt_FatorDate.SpellControl = Nothing
        Me.txt_FatorDate.TabIndex = 2
        Me.txt_FatorDate.TabStop = False
        Me.txt_FatorDate.Tag = "FactorDate"
        Me.txt_FatorDate.Title = Nothing
        Me.txt_FatorDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FatorDate.UseForData = True
        Me.txt_FatorDate.ValidateCheckExistOnEdit = False
        Me.txt_FatorDate.Value = ""
        '
        'txt_FActorNoKhaird
        '
        Me.txt_FActorNoKhaird.CheckExistValueInDb = False
        Me.txt_FActorNoKhaird.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FActorNoKhaird.CurrencyUnit = "ریال"
        Me.txt_FActorNoKhaird.DefaultValue = "0"
        Me.txt_FActorNoKhaird.FillWithMaxInDb = False
        Me.txt_FActorNoKhaird.IsRequired = False
        Me.txt_FActorNoKhaird.Location = New System.Drawing.Point(6, 12)
        Me.txt_FActorNoKhaird.MaxDecimalLength = 2
        Me.txt_FActorNoKhaird.Name = "txt_FActorNoKhaird"
        Me.txt_FActorNoKhaird.Size = New System.Drawing.Size(74, 23)
        Me.txt_FActorNoKhaird.SpellControl = Nothing
        Me.txt_FActorNoKhaird.TabIndex = 3
        Me.txt_FActorNoKhaird.Tag = "FacNoKharid"
        Me.txt_FActorNoKhaird.Text = "0"
        Me.txt_FActorNoKhaird.Title = Nothing
        Me.txt_FActorNoKhaird.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_FActorNoKhaird.UseForData = True
        Me.txt_FActorNoKhaird.ValidateCheckExistOnEdit = False
        Me.txt_FActorNoKhaird.Value = 0
        '
        'lbl_FacNoKharid
        '
        Me.lbl_FacNoKharid.AutoSize = True
        Me.lbl_FacNoKharid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_FacNoKharid.Location = New System.Drawing.Point(82, 16)
        Me.lbl_FacNoKharid.Name = "lbl_FacNoKharid"
        Me.lbl_FacNoKharid.Size = New System.Drawing.Size(99, 14)
        Me.lbl_FacNoKharid.TabIndex = 72
        Me.lbl_FacNoKharid.Text = "شماره فاكتور خريد"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label22.Location = New System.Drawing.Point(864, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 14)
        Me.Label22.TabIndex = 67
        Me.Label22.Text = "مشتری"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 14)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "تاریخ فاکتور"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(468, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 14)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "شماره"
        '
        'StgAnbarBindingSource
        '
        Me.StgAnbarBindingSource.DataMember = "Stg_Anbar"
        Me.StgAnbarBindingSource.DataSource = Me.Ds_Kala
        '
        'Ds_Kala
        '
        Me.Ds_Kala.DataSetName = "Ds_Kala"
        Me.Ds_Kala.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cmb_Anbar
        '
        Me.Cmb_Anbar.AutoComplete = True
        Me.Cmb_Anbar.DataSource = Me.StgAnbarBindingSource
        Me.Cmb_Anbar.DisplayMember = "Name"
        Me.Cmb_Anbar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Anbar.EnterStop = True
        Me.Cmb_Anbar.FormattingEnabled = True
        Me.Cmb_Anbar.IsRequired = False
        Me.Cmb_Anbar.LimitedToList = True
        Me.Cmb_Anbar.Location = New System.Drawing.Point(3, 46)
        Me.Cmb_Anbar.Name = "Cmb_Anbar"
        Me.Cmb_Anbar.OpenOnFoucus = True
        Me.Cmb_Anbar.Size = New System.Drawing.Size(152, 24)
        Me.Cmb_Anbar.TabIndex = 6
        Me.Cmb_Anbar.Tag = "Srl_Stg_Anbar"
        Me.Cmb_Anbar.ValueMember = "Srl"
        '
        'KalaSelectManager1
        '
        Me.KalaSelectManager1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KalaSelectManager1.Location = New System.Drawing.Point(363, 12)
        Me.KalaSelectManager1.Name = "KalaSelectManager1"
        Me.KalaSelectManager1.Result = Nothing
        Me.KalaSelectManager1.SelectQueryMode = KalaSelectManager.QueryMode.SelectKala
        Me.KalaSelectManager1.Size = New System.Drawing.Size(507, 26)
        Me.KalaSelectManager1.TabIndex = 0
        '
        'Pnl_Kala_Kharid
        '
        Me.Pnl_Kala_Kharid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Kala_Kharid.Controls.Add(Me.Panel_Kharid)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.Cmb_Anbar)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.KalaSelectManager1)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.txt_Vahed)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.Label1)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.txt_Gheimat)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.Label5)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.Lbl_Anbar)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.txt_KalaNo)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.Label3)
        Me.Pnl_Kala_Kharid.Controls.Add(Me.Label2)
        Me.Pnl_Kala_Kharid.Location = New System.Drawing.Point(5, 68)
        Me.Pnl_Kala_Kharid.Name = "Pnl_Kala_Kharid"
        Me.Pnl_Kala_Kharid.Size = New System.Drawing.Size(920, 79)
        Me.Pnl_Kala_Kharid.TabIndex = 1
        '
        'Panel_Kharid
        '
        Me.Panel_Kharid.Controls.Add(Me.Label12)
        Me.Panel_Kharid.Controls.Add(Me.txt_TakhfifDarsad)
        Me.Panel_Kharid.Controls.Add(Me.txt_Jam)
        Me.Panel_Kharid.Controls.Add(Me.Label8)
        Me.Panel_Kharid.Controls.Add(Me.Label6)
        Me.Panel_Kharid.Controls.Add(Me.txt_Takhfif)
        Me.Panel_Kharid.Controls.Add(Me.txt_TolidDate)
        Me.Panel_Kharid.Controls.Add(Me.Label11)
        Me.Panel_Kharid.Controls.Add(Me.txt_ExpDate)
        Me.Panel_Kharid.Location = New System.Drawing.Point(196, 41)
        Me.Panel_Kharid.Name = "Panel_Kharid"
        Me.Panel_Kharid.Size = New System.Drawing.Size(713, 32)
        Me.Panel_Kharid.TabIndex = 96
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(319, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 14)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "تولید"
        '
        'txt_TakhfifDarsad
        '
        Me.txt_TakhfifDarsad.CheckExistValueInDb = False
        Me.txt_TakhfifDarsad.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TakhfifDarsad.CurrencyUnit = "ریال"
        Me.txt_TakhfifDarsad.DefaultValue = "0"
        Me.txt_TakhfifDarsad.FillWithMaxInDb = False
        Me.txt_TakhfifDarsad.IsRequired = False
        Me.txt_TakhfifDarsad.Location = New System.Drawing.Point(606, 5)
        Me.txt_TakhfifDarsad.MaxDecimalLength = 2
        Me.txt_TakhfifDarsad.Name = "txt_TakhfifDarsad"
        Me.txt_TakhfifDarsad.Size = New System.Drawing.Size(28, 23)
        Me.txt_TakhfifDarsad.SpellControl = Nothing
        Me.txt_TakhfifDarsad.TabIndex = 3
        Me.txt_TakhfifDarsad.Tag = "Takhfif"
        Me.txt_TakhfifDarsad.Text = "0"
        Me.txt_TakhfifDarsad.Title = Nothing
        Me.txt_TakhfifDarsad.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_TakhfifDarsad.UseForData = True
        Me.txt_TakhfifDarsad.ValidateCheckExistOnEdit = False
        Me.txt_TakhfifDarsad.Value = 0
        '
        'txt_Jam
        '
        Me.txt_Jam.CheckExistValueInDb = False
        Me.txt_Jam.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Jam.CurrencyUnit = "ریال"
        Me.txt_Jam.DefaultValue = "0"
        Me.txt_Jam.FillWithMaxInDb = False
        Me.txt_Jam.IsRequired = False
        Me.txt_Jam.Location = New System.Drawing.Point(357, 4)
        Me.txt_Jam.MaxDecimalLength = 2
        Me.txt_Jam.Name = "txt_Jam"
        Me.txt_Jam.Size = New System.Drawing.Size(130, 23)
        Me.txt_Jam.SpellControl = Nothing
        Me.txt_Jam.TabIndex = 5
        Me.txt_Jam.Text = "0"
        Me.txt_Jam.Title = Nothing
        Me.txt_Jam.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_Jam.UseForData = True
        Me.txt_Jam.ValidateCheckExistOnEdit = False
        Me.txt_Jam.Value = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(640, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 14)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "تخفیف درصد"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(493, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 14)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "جمع"
        '
        'txt_Takhfif
        '
        Me.txt_Takhfif.CheckExistValueInDb = False
        Me.txt_Takhfif.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Takhfif.CurrencyUnit = "ریال"
        Me.txt_Takhfif.DefaultValue = "0"
        Me.txt_Takhfif.FillWithMaxInDb = False
        Me.txt_Takhfif.IsRequired = False
        Me.txt_Takhfif.Location = New System.Drawing.Point(528, 4)
        Me.txt_Takhfif.MaxDecimalLength = 2
        Me.txt_Takhfif.Name = "txt_Takhfif"
        Me.txt_Takhfif.Size = New System.Drawing.Size(72, 23)
        Me.txt_Takhfif.SpellControl = Nothing
        Me.txt_Takhfif.TabIndex = 4
        Me.txt_Takhfif.Tag = "Takhfif"
        Me.txt_Takhfif.Text = "0"
        Me.txt_Takhfif.Title = Nothing
        Me.txt_Takhfif.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_Takhfif.UseForData = True
        Me.txt_Takhfif.ValidateCheckExistOnEdit = False
        Me.txt_Takhfif.Value = 0
        '
        'txt_TolidDate
        '
        Me.txt_TolidDate.CheckExistValueInDb = False
        Me.txt_TolidDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TolidDate.CurrencyUnit = "ریال"
        Me.txt_TolidDate.DefaultValue = ""
        Me.txt_TolidDate.FillWithMaxInDb = False
        Me.txt_TolidDate.IsRequired = True
        Me.txt_TolidDate.Location = New System.Drawing.Point(180, 5)
        Me.txt_TolidDate.MaxDecimalLength = 2
        Me.txt_TolidDate.Name = "txt_TolidDate"
        Me.txt_TolidDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TolidDate.Size = New System.Drawing.Size(132, 23)
        Me.txt_TolidDate.SpellControl = Nothing
        Me.txt_TolidDate.TabIndex = 7
        Me.txt_TolidDate.TabStop = False
        Me.txt_TolidDate.Tag = "FactorDate"
        Me.txt_TolidDate.Title = Nothing
        Me.txt_TolidDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TolidDate.UseForData = True
        Me.txt_TolidDate.ValidateCheckExistOnEdit = False
        Me.txt_TolidDate.Value = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(142, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 14)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "انقضاء"
        '
        'txt_ExpDate
        '
        Me.txt_ExpDate.CheckExistValueInDb = False
        Me.txt_ExpDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ExpDate.CurrencyUnit = "ریال"
        Me.txt_ExpDate.DefaultValue = ""
        Me.txt_ExpDate.FillWithMaxInDb = False
        Me.txt_ExpDate.IsRequired = True
        Me.txt_ExpDate.Location = New System.Drawing.Point(6, 6)
        Me.txt_ExpDate.MaxDecimalLength = 2
        Me.txt_ExpDate.Name = "txt_ExpDate"
        Me.txt_ExpDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ExpDate.Size = New System.Drawing.Size(132, 23)
        Me.txt_ExpDate.SpellControl = Nothing
        Me.txt_ExpDate.TabIndex = 8
        Me.txt_ExpDate.TabStop = False
        Me.txt_ExpDate.Tag = "FactorDate"
        Me.txt_ExpDate.Title = Nothing
        Me.txt_ExpDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ExpDate.UseForData = True
        Me.txt_ExpDate.ValidateCheckExistOnEdit = False
        Me.txt_ExpDate.Value = ""
     
        '
        'txt_Vahed
        '
        Me.txt_Vahed.BackColor = System.Drawing.SystemColors.Info
        Me.txt_Vahed.CheckExistValueInDb = False
        Me.txt_Vahed.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Vahed.CurrencyUnit = "ریال"
        Me.txt_Vahed.DefaultValue = ""
        Me.txt_Vahed.Enabled = False
        Me.txt_Vahed.FillWithMaxInDb = False
        Me.txt_Vahed.IsRequired = False
        Me.txt_Vahed.Location = New System.Drawing.Point(217, 11)
        Me.txt_Vahed.MaxDecimalLength = 2
        Me.txt_Vahed.Name = "txt_Vahed"
        Me.txt_Vahed.ReadOnly = True
        Me.txt_Vahed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Vahed.Size = New System.Drawing.Size(94, 23)
        Me.txt_Vahed.SpellControl = Nothing
        Me.txt_Vahed.TabIndex = 92
        Me.txt_Vahed.Title = Nothing
        Me.txt_Vahed.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Vahed.UseForData = True
        Me.txt_Vahed.ValidateCheckExistOnEdit = False
        Me.txt_Vahed.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 14)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "واحد"
        '
        'txt_Gheimat
        '
        Me.txt_Gheimat.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Gheimat.CheckExistValueInDb = False
        Me.txt_Gheimat.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Gheimat.CurrencyUnit = "ریال"
        Me.txt_Gheimat.DefaultValue = "0"
        Me.txt_Gheimat.FillWithMaxInDb = False
        Me.txt_Gheimat.IsRequired = False
        Me.txt_Gheimat.Location = New System.Drawing.Point(4, 13)
        Me.txt_Gheimat.MaxDecimalLength = 2
        Me.txt_Gheimat.Name = "txt_Gheimat"
        Me.txt_Gheimat.Size = New System.Drawing.Size(87, 23)
        Me.txt_Gheimat.SpellControl = Nothing
        Me.txt_Gheimat.TabIndex = 2
        Me.txt_Gheimat.Tag = "Price"
        Me.txt_Gheimat.Text = "0"
        Me.txt_Gheimat.Title = Nothing
        Me.txt_Gheimat.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_Gheimat.UseForData = True
        Me.txt_Gheimat.ValidateCheckExistOnEdit = False
        Me.txt_Gheimat.Value = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "قیمت"
        '
        'Lbl_Anbar
        '
        Me.Lbl_Anbar.AutoSize = True
        Me.Lbl_Anbar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Lbl_Anbar.Location = New System.Drawing.Point(161, 50)
        Me.Lbl_Anbar.Name = "Lbl_Anbar"
        Me.Lbl_Anbar.Size = New System.Drawing.Size(25, 14)
        Me.Lbl_Anbar.TabIndex = 90
        Me.Lbl_Anbar.Text = "انبار"
        '
        'txt_KalaNo
        '
        Me.txt_KalaNo.CheckExistValueInDb = False
        Me.txt_KalaNo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_KalaNo.CurrencyUnit = "ریال"
        Me.txt_KalaNo.DefaultValue = "1"
        Me.txt_KalaNo.FillWithMaxInDb = False
        Me.txt_KalaNo.IsRequired = False
        Me.txt_KalaNo.Location = New System.Drawing.Point(137, 13)
        Me.txt_KalaNo.MaxDecimalLength = 2
        Me.txt_KalaNo.Name = "txt_KalaNo"
        Me.txt_KalaNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_KalaNo.Size = New System.Drawing.Size(38, 23)
        Me.txt_KalaNo.SpellControl = Nothing
        Me.txt_KalaNo.TabIndex = 1
        Me.txt_KalaNo.Tag = "Count"
        Me.txt_KalaNo.Text = "1"
        Me.txt_KalaNo.Title = Nothing
        Me.txt_KalaNo.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_KalaNo.UseForData = True
        Me.txt_KalaNo.ValidateCheckExistOnEdit = False
        Me.txt_KalaNo.Value = 1.0!
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 14)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "تعداد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(882, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 14)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "کالا"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ردیف, Me.کدکالاDataGridViewTextBoxColumn, Me.نامکالاDataGridViewTextBoxColumn, Me.تعدادDataGridViewTextBoxColumn, Me.واحدDataGridViewTextBoxColumn, Me.قیمتDataGridViewTextBoxColumn, Me.جمعDataGridViewTextBoxColumn, Me.تولیدDataGridViewTextBoxColumn, Me.انقضاءDataGridViewTextBoxColumn, Me.انقضاء, Me.تولید, Me.توضیحاتDataGridViewTextBoxColumn, Me.تخفیفDataGridViewTextBoxColumn, Me.انبارDataGridViewTextBoxColumn, Me.مالیاتDataGridViewTextBoxColumn, Me.عوارضDataGridViewTextBoxColumn, Me.SrlStgFactorMasterDataGridViewTextBoxColumn, Me.SrlStgKalaDataGridViewTextBoxColumn, Me.SrlStgAnbarDataGridViewTextBoxColumn, Me.SrStgVahedFareeDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.StgFactorDetailsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(96, 153)
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
        Me.DataGridView1.Size = New System.Drawing.Size(827, 315)
        Me.DataGridView1.TabIndex = 2
        '
        'ردیف
        '
        Me.ردیف.DataPropertyName = "ردیف"
        Me.ردیف.HeaderText = "ردیف"
        Me.ردیف.Name = "ردیف"
        Me.ردیف.ReadOnly = True
        Me.ردیف.Width = 70
        '
        'کدکالاDataGridViewTextBoxColumn
        '
        Me.کدکالاDataGridViewTextBoxColumn.DataPropertyName = "کد کالا"
        Me.کدکالاDataGridViewTextBoxColumn.HeaderText = "کد کالا"
        Me.کدکالاDataGridViewTextBoxColumn.Name = "کدکالاDataGridViewTextBoxColumn"
        Me.کدکالاDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامکالاDataGridViewTextBoxColumn
        '
        Me.نامکالاDataGridViewTextBoxColumn.DataPropertyName = "نام کالا"
        Me.نامکالاDataGridViewTextBoxColumn.HeaderText = "نام کالا"
        Me.نامکالاDataGridViewTextBoxColumn.Name = "نامکالاDataGridViewTextBoxColumn"
        Me.نامکالاDataGridViewTextBoxColumn.ReadOnly = True
        Me.نامکالاDataGridViewTextBoxColumn.Width = 200
        '
        'تعدادDataGridViewTextBoxColumn
        '
        Me.تعدادDataGridViewTextBoxColumn.DataPropertyName = "تعداد"
        Me.تعدادDataGridViewTextBoxColumn.HeaderText = "تعداد"
        Me.تعدادDataGridViewTextBoxColumn.Name = "تعدادDataGridViewTextBoxColumn"
        Me.تعدادDataGridViewTextBoxColumn.ReadOnly = True
        '
        'واحدDataGridViewTextBoxColumn
        '
        Me.واحدDataGridViewTextBoxColumn.DataPropertyName = "واحد"
        Me.واحدDataGridViewTextBoxColumn.HeaderText = "واحد"
        Me.واحدDataGridViewTextBoxColumn.Name = "واحدDataGridViewTextBoxColumn"
        Me.واحدDataGridViewTextBoxColumn.ReadOnly = True
        '
        'قیمتDataGridViewTextBoxColumn
        '
        Me.قیمتDataGridViewTextBoxColumn.DataPropertyName = "قیمت"
        Me.قیمتDataGridViewTextBoxColumn.HeaderText = "قیمت"
        Me.قیمتDataGridViewTextBoxColumn.Name = "قیمتDataGridViewTextBoxColumn"
        Me.قیمتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'جمعDataGridViewTextBoxColumn
        '
        Me.جمعDataGridViewTextBoxColumn.DataPropertyName = "جمع"
        Me.جمعDataGridViewTextBoxColumn.HeaderText = "جمع"
        Me.جمعDataGridViewTextBoxColumn.Name = "جمعDataGridViewTextBoxColumn"
        Me.جمعDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تولیدDataGridViewTextBoxColumn
        '
        Me.تولیدDataGridViewTextBoxColumn.DataPropertyName = "تولید"
        Me.تولیدDataGridViewTextBoxColumn.HeaderText = "تولید"
        Me.تولیدDataGridViewTextBoxColumn.Name = "تولیدDataGridViewTextBoxColumn"
        Me.تولیدDataGridViewTextBoxColumn.ReadOnly = True
        Me.تولیدDataGridViewTextBoxColumn.Visible = False
        '
        'انقضاءDataGridViewTextBoxColumn
        '
        Me.انقضاءDataGridViewTextBoxColumn.DataPropertyName = "انقضاء"
        Me.انقضاءDataGridViewTextBoxColumn.HeaderText = "انقضاء"
        Me.انقضاءDataGridViewTextBoxColumn.Name = "انقضاءDataGridViewTextBoxColumn"
        Me.انقضاءDataGridViewTextBoxColumn.ReadOnly = True
        Me.انقضاءDataGridViewTextBoxColumn.Visible = False
        '
        'انقضاء
        '
        Me.انقضاء.DataPropertyName = "انقضاء"
        Me.انقضاء.HeaderText = "انقضاء"
        Me.انقضاء.Name = "انقضاء"
        Me.انقضاء.ReadOnly = True
        Me.انقضاء.Visible = False
        '
        'تولید
        '
        Me.تولید.DataPropertyName = "تولید"
        Me.تولید.HeaderText = "تولید"
        Me.تولید.Name = "تولید"
        Me.تولید.ReadOnly = True
        Me.تولید.Visible = False
        '
        'توضیحاتDataGridViewTextBoxColumn
        '
        Me.توضیحاتDataGridViewTextBoxColumn.DataPropertyName = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.Name = "توضیحاتDataGridViewTextBoxColumn"
        Me.توضیحاتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تخفیفDataGridViewTextBoxColumn
        '
        Me.تخفیفDataGridViewTextBoxColumn.DataPropertyName = "تخفیف"
        Me.تخفیفDataGridViewTextBoxColumn.HeaderText = "تخفیف"
        Me.تخفیفDataGridViewTextBoxColumn.Name = "تخفیفDataGridViewTextBoxColumn"
        Me.تخفیفDataGridViewTextBoxColumn.ReadOnly = True
        Me.تخفیفDataGridViewTextBoxColumn.Visible = False
        '
        'انبارDataGridViewTextBoxColumn
        '
        Me.انبارDataGridViewTextBoxColumn.DataPropertyName = "انبار"
        Me.انبارDataGridViewTextBoxColumn.HeaderText = "انبار"
        Me.انبارDataGridViewTextBoxColumn.Name = "انبارDataGridViewTextBoxColumn"
        Me.انبارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مالیاتDataGridViewTextBoxColumn
        '
        Me.مالیاتDataGridViewTextBoxColumn.DataPropertyName = "مالیات"
        Me.مالیاتDataGridViewTextBoxColumn.HeaderText = "مالیات"
        Me.مالیاتDataGridViewTextBoxColumn.Name = "مالیاتDataGridViewTextBoxColumn"
        Me.مالیاتDataGridViewTextBoxColumn.ReadOnly = True
        Me.مالیاتDataGridViewTextBoxColumn.Visible = False
        '
        'عوارضDataGridViewTextBoxColumn
        '
        Me.عوارضDataGridViewTextBoxColumn.DataPropertyName = "عوارض"
        Me.عوارضDataGridViewTextBoxColumn.HeaderText = "عوارض"
        Me.عوارضDataGridViewTextBoxColumn.Name = "عوارضDataGridViewTextBoxColumn"
        Me.عوارضDataGridViewTextBoxColumn.ReadOnly = True
        Me.عوارضDataGridViewTextBoxColumn.Visible = False
        '
        'SrlStgFactorMasterDataGridViewTextBoxColumn
        '
        Me.SrlStgFactorMasterDataGridViewTextBoxColumn.DataPropertyName = "Srl_Stg_FactorMaster"
        Me.SrlStgFactorMasterDataGridViewTextBoxColumn.HeaderText = "Srl_Stg_FactorMaster"
        Me.SrlStgFactorMasterDataGridViewTextBoxColumn.Name = "SrlStgFactorMasterDataGridViewTextBoxColumn"
        Me.SrlStgFactorMasterDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlStgFactorMasterDataGridViewTextBoxColumn.Visible = False
        '
        'SrlStgKalaDataGridViewTextBoxColumn
        '
        Me.SrlStgKalaDataGridViewTextBoxColumn.DataPropertyName = "Srl_Stg_Kala"
        Me.SrlStgKalaDataGridViewTextBoxColumn.HeaderText = "Srl_Stg_Kala"
        Me.SrlStgKalaDataGridViewTextBoxColumn.Name = "SrlStgKalaDataGridViewTextBoxColumn"
        Me.SrlStgKalaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlStgKalaDataGridViewTextBoxColumn.Visible = False
        '
        'SrlStgAnbarDataGridViewTextBoxColumn
        '
        Me.SrlStgAnbarDataGridViewTextBoxColumn.DataPropertyName = "Srl_Stg_Anbar"
        Me.SrlStgAnbarDataGridViewTextBoxColumn.HeaderText = "Srl_Stg_Anbar"
        Me.SrlStgAnbarDataGridViewTextBoxColumn.Name = "SrlStgAnbarDataGridViewTextBoxColumn"
        Me.SrlStgAnbarDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlStgAnbarDataGridViewTextBoxColumn.Visible = False
        '
        'SrStgVahedFareeDataGridViewTextBoxColumn
        '
        Me.SrStgVahedFareeDataGridViewTextBoxColumn.DataPropertyName = "Sr_Stg_Vahed_Faree"
        Me.SrStgVahedFareeDataGridViewTextBoxColumn.HeaderText = "Sr_Stg_Vahed_Faree"
        Me.SrStgVahedFareeDataGridViewTextBoxColumn.Name = "SrStgVahedFareeDataGridViewTextBoxColumn"
        Me.SrStgVahedFareeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrStgVahedFareeDataGridViewTextBoxColumn.Visible = False
        '
        'StgFactorDetailsBindingSource
        '
        Me.StgFactorDetailsBindingSource.DataMember = "Stg_FactorDetails"
        Me.StgFactorDetailsBindingSource.DataSource = Me.Ds_Kala
        '
        'txt_Dis
        '
        Me.txt_Dis.CheckExistValueInDb = False
        Me.txt_Dis.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Dis.CurrencyUnit = "ریال"
        Me.txt_Dis.DefaultValue = ""
        Me.txt_Dis.FillWithMaxInDb = False
        Me.txt_Dis.IsRequired = False
        Me.txt_Dis.Location = New System.Drawing.Point(259, 477)
        Me.txt_Dis.MaxDecimalLength = 2
        Me.txt_Dis.Name = "txt_Dis"
        Me.txt_Dis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Dis.Size = New System.Drawing.Size(610, 23)
        Me.txt_Dis.SpellControl = Nothing
        Me.txt_Dis.TabIndex = 3
        Me.txt_Dis.Title = Nothing
        Me.txt_Dis.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Dis.UseForData = True
        Me.txt_Dis.ValidateCheckExistOnEdit = False
        Me.txt_Dis.Value = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(895, 483)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 14)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "شرح"
        '
        'txt_JamKol
        '
        Me.txt_JamKol.BackColor = System.Drawing.SystemColors.Window
        Me.txt_JamKol.CheckExistValueInDb = False
        Me.txt_JamKol.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_JamKol.CurrencyUnit = "ریال"
        Me.txt_JamKol.DefaultValue = "0"
        Me.txt_JamKol.Enabled = False
        Me.txt_JamKol.FillWithMaxInDb = False
        Me.txt_JamKol.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_JamKol.IsRequired = False
        Me.txt_JamKol.Location = New System.Drawing.Point(96, 475)
        Me.txt_JamKol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_JamKol.MaxDecimalLength = 2
        Me.txt_JamKol.Name = "txt_JamKol"
        Me.txt_JamKol.ReadOnly = True
        Me.txt_JamKol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_JamKol.Size = New System.Drawing.Size(109, 23)
        Me.txt_JamKol.SpellControl = Nothing
        Me.txt_JamKol.TabIndex = 90
        Me.txt_JamKol.Text = "0"
        Me.txt_JamKol.Title = Nothing
        Me.txt_JamKol.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_JamKol.UseForData = True
        Me.txt_JamKol.ValidateCheckExistOnEdit = False
        Me.txt_JamKol.Value = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(205, 481)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 14)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "جمع کل"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Btn_Setting)
        Me.Panel3.Controls.Add(Me.Btn_Del)
        Me.Panel3.Controls.Add(Me.Btn_Edit)
        Me.Panel3.Controls.Add(Me.Btn_Add)
        Me.Panel3.Location = New System.Drawing.Point(5, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(85, 349)
        Me.Panel3.TabIndex = 2
        '
        'Btn_Setting
        '
        Me.Btn_Setting.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Setting.HeaderText = "تنظیمات"
        Me.Btn_Setting.Location = New System.Drawing.Point(5, 311)
        Me.Btn_Setting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Setting.Name = "Btn_Setting"
        Me.Btn_Setting.Size = New System.Drawing.Size(72, 26)
        Me.Btn_Setting.TabIndex = 4
        Me.Btn_Setting.Visible = False
        '
        'Btn_Del
        '
        Me.Btn_Del.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Del.HeaderText = "حذف"
        Me.Btn_Del.Location = New System.Drawing.Point(5, 71)
        Me.Btn_Del.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Del.Name = "Btn_Del"
        Me.Btn_Del.Size = New System.Drawing.Size(73, 26)
        Me.Btn_Del.TabIndex = 2
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Edit.HeaderText = "ویرایش"
        Me.Btn_Edit.Location = New System.Drawing.Point(5, 38)
        Me.Btn_Edit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(73, 26)
        Me.Btn_Edit.TabIndex = 1
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Add.HeaderText = "اضافه"
        Me.Btn_Add.Location = New System.Drawing.Point(5, 4)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(73, 26)
        Me.Btn_Add.TabIndex = 0
        '
        'Stg_FactorDetailsTableAdapter
        '
        Me.Stg_FactorDetailsTableAdapter.ClearBeforeFill = True
        '
        'Pm_SherkatTableAdapter
        '
        Me.Pm_SherkatTableAdapter.ClearBeforeFill = True
        '
        'Stg_AnbarTableAdapter
        '
        Me.Stg_AnbarTableAdapter.ClearBeforeFill = True
        '
        'Frm_FactorSubmit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 632)
        Me.Name = "Frm_FactorSubmit"
        Me.PromptOnExit = True
        Me.Text = "ثبت فاکتور"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PmSherkatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StgAnbarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Kala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Kala_Kharid.ResumeLayout(False)
        Me.Pnl_Kala_Kharid.PerformLayout()
        Me.Panel_Kharid.ResumeLayout(False)
        Me.Panel_Kharid.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StgFactorDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_FacNoKharid As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Anbar As VB_Component.ComboBox
    Friend WithEvents txt_FActorNoKhaird As CS_Component.TextBox
    Friend WithEvents txt_FactorNo As CS_Component.TextBox
    Friend WithEvents txt_FatorDate As CS_Component.TextBox
    Friend WithEvents Pnl_Kala_Kharid As System.Windows.Forms.Panel
    Friend WithEvents txt_KalaNo As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Takhfif As CS_Component.TextBox
    Friend WithEvents txt_Gheimat As CS_Component.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_JamKol As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Dis As CS_Component.TextBox
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Add As CS_Component.Btn
    Friend WithEvents Btn_Del As CS_Component.Btn
    Friend WithEvents Btn_Edit As CS_Component.Btn
    Friend WithEvents Lbl_Anbar As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_Setting As CS_Component.Btn
    Friend WithEvents txt_Vahed As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ExpDate As CS_Component.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents radif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_TakhfifDarsad As CS_Component.TextBox
    Friend WithEvents txt_Jam As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_TolidDate As CS_Component.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents KalaSelectManager1 As KalaSelectManager
    Friend WithEvents Panel_Kharid As System.Windows.Forms.Panel
    Friend WithEvents ردیف As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدکالاDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامکالاDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعدادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قیمتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents جمعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تولیدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents انقضاءDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents انقضاء As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تولید As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تخفیفDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents انبارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مالیاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عوارضDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlStgFactorMasterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlStgKalaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlStgAnbarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrStgVahedFareeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StgFactorDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Kala As Nama_PM.Ds_Kala
    Friend WithEvents Stg_FactorDetailsTableAdapter As Nama_PM.Ds_KalaTableAdapters.Stg_FactorDetailsTableAdapter
    Friend WithEvents lk_Sherkat As CS_Component.LookupBox
    Friend WithEvents PmSherkatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents Pm_SherkatTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_SherkatTableAdapter
    Friend WithEvents StgAnbarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Stg_AnbarTableAdapter As Nama_PM.Ds_KalaTableAdapters.Stg_AnbarTableAdapter
End Class
