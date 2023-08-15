<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Kala
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
        Me.StgKalaPricingMethodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Kala = New Nama_PM.Ds_Kala
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox2 = New VB_Component.ComboBox
        Me.StgSazandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmSazandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Name = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox5 = New CS_Component.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox6 = New CS_Component.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBox3 = New VB_Component.ComboBox
        Me.StgVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.btn_selectGroup = New System.Windows.Forms.Button
        Me.txt_KalaGroup = New CS_Component.TextBox
        Me.Txt_SrlKalaGroup = New CS_Component.TextBox
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.PmKalaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_DefultPrice = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_MojodiAvalie = New CS_Component.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.chk_AllAnbar = New System.Windows.Forms.CheckBox
        Me.cmb_Anbar = New VB_Component.ComboBox
        Me.StgAnbarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_KalaTableAdapter = New Nama_PM.Ds_KalaTableAdapters.Pm_KalaTableAdapter
        Me.Stg_VahedTableAdapter = New Nama_PM.Ds_KalaTableAdapters.Stg_VahedTableAdapter
        Me.Stg_AnbarTableAdapter = New Nama_PM.Ds_KalaTableAdapters.Stg_AnbarTableAdapter
        Me.Stg_KalaPricingMethodTableAdapter = New Nama_PM.Ds_KalaTableAdapters.Stg_KalaPricingMethodTableAdapter
        Me.Pm_SazandeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_SazandeTableAdapter
        Me.Stg_SazandeTableAdapter = New Nama_PM.Ds_KalaTableAdapters.Stg_SazandeTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.StgKalaPricingMethodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Kala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StgSazandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSazandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StgVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmKalaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.StgAnbarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(502, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(749, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(625, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(872, 356)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.GroupBox5)
        Me.gbx_Controls.Controls.Add(Me.btn_selectGroup)
        Me.gbx_Controls.Controls.Add(Me.Label8)
        Me.gbx_Controls.Controls.Add(Me.ComboBox3)
        Me.gbx_Controls.Controls.Add(Me.Label7)
        Me.gbx_Controls.Controls.Add(Me.txt_KalaGroup)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.TextBox6)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.Txt_SrlKalaGroup)
        Me.gbx_Controls.Controls.Add(Me.TextBox5)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.txt_Name)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.TextBox3)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.ComboBox2)
        Me.gbx_Controls.Location = New System.Drawing.Point(13, 456)
        Me.gbx_Controls.Size = New System.Drawing.Size(872, 232)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(13, 398)
        Me.gbx_Btn.Size = New System.Drawing.Size(872, 60)
        '
        'StgKalaPricingMethodBindingSource
        '
        Me.StgKalaPricingMethodBindingSource.DataMember = "Stg_KalaPricingMethod"
        Me.StgKalaPricingMethodBindingSource.DataSource = Me.Ds_Kala
        '
        'Ds_Kala
        '
        Me.Ds_Kala.DataSetName = "Ds_Kala"
        Me.Ds_Kala.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "کارخانه سازنده"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoComplete = True
        Me.ComboBox2.DataSource = Me.StgSazandeBindingSource
        Me.ComboBox2.DisplayMember = "نام"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.EnterStop = True
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.IsRequired = True
        Me.ComboBox2.LimitedToList = True
        Me.ComboBox2.Location = New System.Drawing.Point(299, 57)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.OpenOnFoucus = True
        Me.ComboBox2.Size = New System.Drawing.Size(138, 26)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.Tag = "Srl_Stg_Sazande"
        Me.ComboBox2.ValueMember = "Srl"
        '
        'StgSazandeBindingSource
        '
        Me.StgSazandeBindingSource.DataMember = "Stg_Sazande"
        Me.StgSazandeBindingSource.DataSource = Me.Ds_Kala
        '
        'PmSazandeBindingSource
        '
        Me.PmSazandeBindingSource.DataMember = "Pm_Sazande"
        Me.PmSazandeBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(745, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "کد کالا"
        '
        'TextBox3
        '
        Me.TextBox3.CheckExistValueInDb = True
        Me.TextBox3.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox3.CurrencyUnit = "ریال"
        Me.TextBox3.DefaultValue = ""
        Me.TextBox3.FillWithMaxInDb = False
        Me.TextBox3.IsRequired = True
        Me.TextBox3.Location = New System.Drawing.Point(557, 25)
        Me.TextBox3.MaxDecimalLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(181, 25)
        Me.TextBox3.SpellControl = Nothing
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Tag = "BarcodeCode"
        Me.TextBox3.Text = "0"
        Me.TextBox3.Title = Nothing
        Me.TextBox3.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.TextBox3.UseForData = True
        Me.TextBox3.ValidateCheckExistOnEdit = False
        Me.TextBox3.Value = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "نام کالا"
        '
        'txt_Name
        '
        Me.txt_Name.CheckExistValueInDb = True
        Me.txt_Name.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Name.CurrencyUnit = "ریال"
        Me.txt_Name.DefaultValue = ""
        Me.txt_Name.FillWithMaxInDb = False
        Me.txt_Name.IsRequired = True
        Me.txt_Name.Location = New System.Drawing.Point(10, 25)
        Me.txt_Name.MaxDecimalLength = 2
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Name.Size = New System.Drawing.Size(427, 25)
        Me.txt_Name.SpellControl = Nothing
        Me.txt_Name.TabIndex = 1
        Me.txt_Name.Tag = "Name"
        Me.txt_Name.Title = Nothing
        Me.txt_Name.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Name.UseForData = True
        Me.txt_Name.ValidateCheckExistOnEdit = False
        Me.txt_Name.Value = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "پایین ترین نقطه سفارش"
        '
        'TextBox5
        '
        Me.TextBox5.CheckExistValueInDb = False
        Me.TextBox5.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox5.CurrencyUnit = "ریال"
        Me.TextBox5.DefaultValue = "0"
        Me.TextBox5.FillWithMaxInDb = False
        Me.TextBox5.IsRequired = False
        Me.TextBox5.Location = New System.Drawing.Point(10, 58)
        Me.TextBox5.MaxDecimalLength = 2
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(114, 25)
        Me.TextBox5.SpellControl = Nothing
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Tag = "LowLevelOrderPoint"
        Me.TextBox5.Text = "0"
        Me.TextBox5.Title = Nothing
        Me.TextBox5.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox5.UseForData = True
        Me.TextBox5.ValidateCheckExistOnEdit = False
        Me.TextBox5.Value = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(745, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "نقطه سفارش"
        '
        'TextBox6
        '
        Me.TextBox6.CheckExistValueInDb = False
        Me.TextBox6.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox6.CurrencyUnit = "ریال"
        Me.TextBox6.DefaultValue = "0"
        Me.TextBox6.FillWithMaxInDb = False
        Me.TextBox6.IsRequired = False
        Me.TextBox6.Location = New System.Drawing.Point(557, 54)
        Me.TextBox6.MaxDecimalLength = 2
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(181, 25)
        Me.TextBox6.SpellControl = Nothing
        Me.TextBox6.TabIndex = 2
        Me.TextBox6.Tag = "OrderPoint"
        Me.TextBox6.Text = "0"
        Me.TextBox6.Title = Nothing
        Me.TextBox6.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox6.UseForData = True
        Me.TextBox6.ValidateCheckExistOnEdit = False
        Me.TextBox6.Value = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(445, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "واحد کالا"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoComplete = True
        Me.ComboBox3.DataSource = Me.StgVahedBindingSource
        Me.ComboBox3.DisplayMember = "واحد"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.EnterStop = True
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.IsRequired = True
        Me.ComboBox3.LimitedToList = True
        Me.ComboBox3.Location = New System.Drawing.Point(299, 91)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.OpenOnFoucus = True
        Me.ComboBox3.Size = New System.Drawing.Size(138, 26)
        Me.ComboBox3.TabIndex = 6
        Me.ComboBox3.Tag = "Srl_Stg_Vahed"
        Me.ComboBox3.ValueMember = "Srl"
        '
        'StgVahedBindingSource
        '
        Me.StgVahedBindingSource.DataMember = "Stg_Vahed"
        Me.StgVahedBindingSource.DataSource = Me.Ds_Kala
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(779, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "گروه کالا"
        '
        'btn_selectGroup
        '
        Me.btn_selectGroup.Location = New System.Drawing.Point(738, 88)
        Me.btn_selectGroup.Name = "btn_selectGroup"
        Me.btn_selectGroup.Size = New System.Drawing.Size(34, 26)
        Me.btn_selectGroup.TabIndex = 5
        Me.btn_selectGroup.Tag = ""
        Me.btn_selectGroup.Text = "..."
        Me.btn_selectGroup.UseVisualStyleBackColor = True
        '
        'txt_KalaGroup
        '
        Me.txt_KalaGroup.CheckExistValueInDb = False
        Me.txt_KalaGroup.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_KalaGroup.CurrencyUnit = "ریال"
        Me.txt_KalaGroup.DefaultValue = ""
        Me.txt_KalaGroup.FillWithMaxInDb = False
        Me.txt_KalaGroup.IsRequired = False
        Me.txt_KalaGroup.Location = New System.Drawing.Point(557, 89)
        Me.txt_KalaGroup.MaxDecimalLength = 2
        Me.txt_KalaGroup.Name = "txt_KalaGroup"
        Me.txt_KalaGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_KalaGroup.Size = New System.Drawing.Size(177, 25)
        Me.txt_KalaGroup.SpellControl = Nothing
        Me.txt_KalaGroup.TabIndex = 8
        Me.txt_KalaGroup.Title = Nothing
        Me.txt_KalaGroup.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_KalaGroup.UseForData = True
        Me.txt_KalaGroup.ValidateCheckExistOnEdit = False
        Me.txt_KalaGroup.Value = ""
        '
        'Txt_SrlKalaGroup
        '
        Me.Txt_SrlKalaGroup.CheckExistValueInDb = False
        Me.Txt_SrlKalaGroup.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_SrlKalaGroup.CurrencyUnit = "ریال"
        Me.Txt_SrlKalaGroup.DefaultValue = "0"
        Me.Txt_SrlKalaGroup.FillWithMaxInDb = False
        Me.Txt_SrlKalaGroup.IsRequired = True
        Me.Txt_SrlKalaGroup.Location = New System.Drawing.Point(559, 87)
        Me.Txt_SrlKalaGroup.MaxDecimalLength = 2
        Me.Txt_SrlKalaGroup.Name = "Txt_SrlKalaGroup"
        Me.Txt_SrlKalaGroup.Size = New System.Drawing.Size(213, 25)
        Me.Txt_SrlKalaGroup.SpellControl = Nothing
        Me.Txt_SrlKalaGroup.TabIndex = 4
        Me.Txt_SrlKalaGroup.Tag = "Srl_Stg_KalaGroup"
        Me.Txt_SrlKalaGroup.Text = "0"
        Me.Txt_SrlKalaGroup.Title = Nothing
        Me.Txt_SrlKalaGroup.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.Txt_SrlKalaGroup.UseForData = True
        Me.Txt_SrlKalaGroup.ValidateCheckExistOnEdit = False
        Me.Txt_SrlKalaGroup.Value = 0
        Me.Txt_SrlKalaGroup.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmKalaBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(11, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(850, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'PmKalaBindingSource
        '
        Me.PmKalaBindingSource.DataMember = "Pm_Kala"
        Me.PmKalaBindingSource.DataSource = Me.Ds_Kala
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(434, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "قیمت  اولیه"
        '
        'txt_DefultPrice
        '
        Me.txt_DefultPrice.CheckExistValueInDb = False
        Me.txt_DefultPrice.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DefultPrice.CurrencyUnit = "ریال"
        Me.txt_DefultPrice.DefaultValue = "0"
        Me.txt_DefultPrice.FillWithMaxInDb = False
        Me.txt_DefultPrice.IsRequired = False
        Me.txt_DefultPrice.Location = New System.Drawing.Point(289, 40)
        Me.txt_DefultPrice.MaxDecimalLength = 2
        Me.txt_DefultPrice.Name = "txt_DefultPrice"
        Me.txt_DefultPrice.Size = New System.Drawing.Size(138, 25)
        Me.txt_DefultPrice.SpellControl = Nothing
        Me.txt_DefultPrice.TabIndex = 2
        Me.txt_DefultPrice.Tag = ""
        Me.txt_DefultPrice.Text = "0"
        Me.txt_DefultPrice.Title = Nothing
        Me.txt_DefultPrice.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_DefultPrice.UseForData = True
        Me.txt_DefultPrice.ValidateCheckExistOnEdit = False
        Me.txt_DefultPrice.Value = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(121, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "موجودی اولیه"
        '
        'txt_MojodiAvalie
        '
        Me.txt_MojodiAvalie.CheckExistValueInDb = False
        Me.txt_MojodiAvalie.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_MojodiAvalie.CurrencyUnit = "ریال"
        Me.txt_MojodiAvalie.DefaultValue = ""
        Me.txt_MojodiAvalie.FillWithMaxInDb = False
        Me.txt_MojodiAvalie.IsRequired = False
        Me.txt_MojodiAvalie.Location = New System.Drawing.Point(7, 40)
        Me.txt_MojodiAvalie.MaxDecimalLength = 2
        Me.txt_MojodiAvalie.Name = "txt_MojodiAvalie"
        Me.txt_MojodiAvalie.Size = New System.Drawing.Size(106, 25)
        Me.txt_MojodiAvalie.SpellControl = Nothing
        Me.txt_MojodiAvalie.TabIndex = 3
        Me.txt_MojodiAvalie.Tag = ""
        Me.txt_MojodiAvalie.Text = "0"
        Me.txt_MojodiAvalie.Title = Nothing
        Me.txt_MojodiAvalie.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_MojodiAvalie.UseForData = True
        Me.txt_MojodiAvalie.ValidateCheckExistOnEdit = False
        Me.txt_MojodiAvalie.Value = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chk_AllAnbar)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.cmb_Anbar)
        Me.GroupBox5.Controls.Add(Me.txt_MojodiAvalie)
        Me.GroupBox5.Controls.Add(Me.txt_DefultPrice)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 125)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(853, 87)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = " ثبت موجودي اول دوره"
        '
        'chk_AllAnbar
        '
        Me.chk_AllAnbar.AutoSize = True
        Me.chk_AllAnbar.Location = New System.Drawing.Point(736, 47)
        Me.chk_AllAnbar.Name = "chk_AllAnbar"
        Me.chk_AllAnbar.Size = New System.Drawing.Size(96, 22)
        Me.chk_AllAnbar.TabIndex = 0
        Me.chk_AllAnbar.TabStop = False
        Me.chk_AllAnbar.Text = "همه انبارها"
        Me.chk_AllAnbar.UseVisualStyleBackColor = True
        '
        'cmb_Anbar
        '
        Me.cmb_Anbar.AutoComplete = True
        Me.cmb_Anbar.DataSource = Me.StgAnbarBindingSource
        Me.cmb_Anbar.DisplayMember = "Name"
        Me.cmb_Anbar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Anbar.EnterStop = True
        Me.cmb_Anbar.FormattingEnabled = True
        Me.cmb_Anbar.IsRequired = True
        Me.cmb_Anbar.LimitedToList = True
        Me.cmb_Anbar.Location = New System.Drawing.Point(557, 43)
        Me.cmb_Anbar.Name = "cmb_Anbar"
        Me.cmb_Anbar.OpenOnFoucus = True
        Me.cmb_Anbar.Size = New System.Drawing.Size(174, 26)
        Me.cmb_Anbar.TabIndex = 1
        Me.cmb_Anbar.Tag = ""
        Me.cmb_Anbar.ValueMember = "Srl"
        '
        'StgAnbarBindingSource
        '
        Me.StgAnbarBindingSource.DataMember = "Stg_Anbar"
        Me.StgAnbarBindingSource.DataSource = Me.Ds_Kala
        '
        'Pm_KalaTableAdapter
        '
        Me.Pm_KalaTableAdapter.ClearBeforeFill = True
        '
        'Stg_VahedTableAdapter
        '
        Me.Stg_VahedTableAdapter.ClearBeforeFill = True
        '
        'Stg_AnbarTableAdapter
        '
        Me.Stg_AnbarTableAdapter.ClearBeforeFill = True
        '
        'Stg_KalaPricingMethodTableAdapter
        '
        Me.Stg_KalaPricingMethodTableAdapter.ClearBeforeFill = True
        '
        'Pm_SazandeTableAdapter
        '
        Me.Pm_SazandeTableAdapter.ClearBeforeFill = True
        '
        'Stg_SazandeTableAdapter
        '
        Me.Stg_SazandeTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "کد کالا"
        Me.DataGridViewTextBoxColumn2.HeaderText = "کد کالا"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "نام کالا"
        Me.DataGridViewTextBoxColumn3.HeaderText = "نام کالا"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "گروه کالا"
        Me.DataGridViewTextBoxColumn4.HeaderText = "گروه کالا"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "سازنده"
        Me.DataGridViewTextBoxColumn5.HeaderText = "سازنده"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "واحد"
        Me.DataGridViewTextBoxColumn6.HeaderText = "واحد"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Frm_Kala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(899, 728)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Name = "Frm_Kala"
        Me.TableName = "Stg_Kala"
        Me.Text = "کالا"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.StgKalaPricingMethodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Kala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StgSazandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSazandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StgVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmKalaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.StgAnbarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As VB_Component.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As CS_Component.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Name As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As VB_Component.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_selectGroup As System.Windows.Forms.Button
    Friend WithEvents txt_KalaGroup As CS_Component.TextBox
    Friend WithEvents Txt_SrlKalaGroup As CS_Component.TextBox
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدکالاDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامکالاDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents گروهکالاDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سازندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_DefultPrice As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_MojodiAvalie As CS_Component.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_AllAnbar As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Anbar As VB_Component.ComboBox
    Friend WithEvents PmKalaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Kala As Nama_PM.Ds_Kala
    Friend WithEvents Pm_KalaTableAdapter As Nama_PM.Ds_KalaTableAdapters.Pm_KalaTableAdapter
    Friend WithEvents StgVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Stg_VahedTableAdapter As Nama_PM.Ds_KalaTableAdapters.Stg_VahedTableAdapter
    Friend WithEvents StgAnbarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Stg_AnbarTableAdapter As Nama_PM.Ds_KalaTableAdapters.Stg_AnbarTableAdapter
    Friend WithEvents StgKalaPricingMethodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Stg_KalaPricingMethodTableAdapter As Nama_PM.Ds_KalaTableAdapters.Stg_KalaPricingMethodTableAdapter
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmSazandeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_SazandeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_SazandeTableAdapter
    Friend WithEvents StgSazandeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Stg_SazandeTableAdapter As Nama_PM.Ds_KalaTableAdapters.Stg_SazandeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
