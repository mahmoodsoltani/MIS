<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Breaker
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_MadeDate = New CS_Component.TextBox
        Me.cmb_Sazande = New VB_Component.ComboBox
        Me.PmDeviceSazandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Lab1 = New Nama_PM.Ds_Lab
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_DeviceName = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Model = New CS_Component.TextBox
        Me.Pm_Device_SazandeTableAdapter1 = New Nama_PM.Ds_LabTableAdapters.Pm_Device_SazandeTableAdapter
        Me.Label5 = New System.Windows.Forms.Label
        Me.PmDescriptableTajhizBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Pm_DescriptableTajhizTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_DescriptableTajhizTableAdapter
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Utilization = New CS_Component.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_serial = New CS_Component.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_JaryanSC = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_TurnOff = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_Mekanism = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_VotajN = New CS_Component.TextBox
        Me.txt_JaryanN = New CS_Component.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_MaxVoltaje = New CS_Component.TextBox
        Me.txt_MaxJaryan = New CS_Component.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_Connect = New CS_Component.TextBox
        Me.txt_Disconnect = New CS_Component.TextBox
        Me.txt_Bill = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_Dispatching = New CS_Component.TextBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PmDeviceSazandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Lab1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmDescriptableTajhizBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 415)
        Me.gbx_Buttons.Size = New System.Drawing.Size(595, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(491, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.cmb_Sazande)
        Me.gbx_Fields.Controls.Add(Me.Label5)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.txt_Utilization)
        Me.gbx_Fields.Controls.Add(Me.txt_MadeDate)
        Me.gbx_Fields.Controls.Add(Me.Label7)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.txt_Disconnect)
        Me.gbx_Fields.Controls.Add(Me.txt_MaxJaryan)
        Me.gbx_Fields.Controls.Add(Me.txt_JaryanN)
        Me.gbx_Fields.Controls.Add(Me.txt_Mekanism)
        Me.gbx_Fields.Controls.Add(Me.txt_Dispatching)
        Me.gbx_Fields.Controls.Add(Me.txt_Connect)
        Me.gbx_Fields.Controls.Add(Me.txt_MaxVoltaje)
        Me.gbx_Fields.Controls.Add(Me.txt_VotajN)
        Me.gbx_Fields.Controls.Add(Me.txt_TurnOff)
        Me.gbx_Fields.Controls.Add(Me.txt_JaryanSC)
        Me.gbx_Fields.Controls.Add(Me.txt_Bill)
        Me.gbx_Fields.Controls.Add(Me.txt_serial)
        Me.gbx_Fields.Controls.Add(Me.Label16)
        Me.gbx_Fields.Controls.Add(Me.Label14)
        Me.gbx_Fields.Controls.Add(Me.Label12)
        Me.gbx_Fields.Controls.Add(Me.Label10)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.Label15)
        Me.gbx_Fields.Controls.Add(Me.Label13)
        Me.gbx_Fields.Controls.Add(Me.Label11)
        Me.gbx_Fields.Controls.Add(Me.Label8)
        Me.gbx_Fields.Controls.Add(Me.Label9)
        Me.gbx_Fields.Controls.Add(Me.Label6)
        Me.gbx_Fields.Controls.Add(Me.txt_Model)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.txt_DeviceName)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(595, 372)
        Me.gbx_Fields.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "تاریخ ساخت"
        '
        'txt_MadeDate
        '
        Me.txt_MadeDate.CheckExistValueInDb = False
        Me.txt_MadeDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_MadeDate.CurrencyUnit = "ریال"
        Me.txt_MadeDate.DefaultValue = ""
        Me.txt_MadeDate.FillWithMaxInDb = False
        Me.txt_MadeDate.IsRequired = False
        Me.txt_MadeDate.Location = New System.Drawing.Point(284, 91)
        Me.txt_MadeDate.MaxDecimalLength = 2
        Me.txt_MadeDate.Name = "txt_MadeDate"
        Me.txt_MadeDate.Size = New System.Drawing.Size(143, 26)
        Me.txt_MadeDate.SpellControl = Nothing
        Me.txt_MadeDate.TabIndex = 2
        Me.txt_MadeDate.TabStop = False
        Me.txt_MadeDate.Tag = "MadeDate"
        Me.txt_MadeDate.Title = Nothing
        Me.txt_MadeDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_MadeDate.UseForData = True
        Me.txt_MadeDate.ValidateCheckExistOnEdit = False
        Me.txt_MadeDate.Value = ""
        '
        'cmb_Sazande
        '
        Me.cmb_Sazande.AutoComplete = True
        Me.cmb_Sazande.DataSource = Me.PmDeviceSazandeBindingSource
        Me.cmb_Sazande.DisplayMember = "سازندگان"
        Me.cmb_Sazande.EnterStop = True
        Me.cmb_Sazande.FormattingEnabled = True
        Me.cmb_Sazande.IsRequired = False
        Me.cmb_Sazande.LimitedToList = True
        Me.cmb_Sazande.Location = New System.Drawing.Point(284, 126)
        Me.cmb_Sazande.Name = "cmb_Sazande"
        Me.cmb_Sazande.OpenOnFoucus = True
        Me.cmb_Sazande.Size = New System.Drawing.Size(143, 26)
        Me.cmb_Sazande.TabIndex = 4
        Me.cmb_Sazande.Tag = "Srl_Pm_Device_Sazande"
        Me.cmb_Sazande.ValueMember = "Srl"
        '
        'PmDeviceSazandeBindingSource
        '
        Me.PmDeviceSazandeBindingSource.DataMember = "Pm_Device_Sazande"
        Me.PmDeviceSazandeBindingSource.DataSource = Me.Ds_Lab1
        '
        'Ds_Lab1
        '
        Me.Ds_Lab1.DataSetName = "Ds_Lab"
        Me.Ds_Lab1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(440, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "سازنده/ تیپ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(440, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام کامل"
        '
        'txt_DeviceName
        '
        Me.txt_DeviceName.CheckExistValueInDb = False
        Me.txt_DeviceName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeviceName.CurrencyUnit = "ریال"
        Me.txt_DeviceName.DefaultValue = ""
        Me.txt_DeviceName.FillWithMaxInDb = False
        Me.txt_DeviceName.IsRequired = False
        Me.txt_DeviceName.Location = New System.Drawing.Point(10, 21)
        Me.txt_DeviceName.MaxDecimalLength = 2
        Me.txt_DeviceName.Name = "txt_DeviceName"
        Me.txt_DeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceName.Size = New System.Drawing.Size(417, 26)
        Me.txt_DeviceName.SpellControl = Nothing
        Me.txt_DeviceName.TabIndex = 0
        Me.txt_DeviceName.Tag = "Name"
        Me.txt_DeviceName.Title = Nothing
        Me.txt_DeviceName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeviceName.UseForData = True
        Me.txt_DeviceName.ValidateCheckExistOnEdit = False
        Me.txt_DeviceName.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "مدل"
        '
        'txt_Model
        '
        Me.txt_Model.CheckExistValueInDb = False
        Me.txt_Model.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Model.CurrencyUnit = "ریال"
        Me.txt_Model.DefaultValue = ""
        Me.txt_Model.FillWithMaxInDb = False
        Me.txt_Model.IsRequired = False
        Me.txt_Model.Location = New System.Drawing.Point(10, 57)
        Me.txt_Model.MaxDecimalLength = 2
        Me.txt_Model.Name = "txt_Model"
        Me.txt_Model.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Model.Size = New System.Drawing.Size(417, 26)
        Me.txt_Model.SpellControl = Nothing
        Me.txt_Model.TabIndex = 1
        Me.txt_Model.Tag = "Model"
        Me.txt_Model.Title = Nothing
        Me.txt_Model.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Model.UseForData = True
        Me.txt_Model.ValidateCheckExistOnEdit = False
        Me.txt_Model.Value = ""
        '
        'Pm_Device_SazandeTableAdapter1
        '
        Me.Pm_Device_SazandeTableAdapter1.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(440, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "بیل (Bill - KV)"
        '
        'PmDescriptableTajhizBindingSource
        '
        Me.PmDescriptableTajhizBindingSource.DataMember = "Pm_DescriptableTajhiz"
        Me.PmDescriptableTajhizBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_DescriptableTajhizTableAdapter
        '
        Me.Pm_DescriptableTajhizTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "بهره برداری"
        '
        'txt_Utilization
        '
        Me.txt_Utilization.CheckExistValueInDb = False
        Me.txt_Utilization.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Utilization.CurrencyUnit = "ریال"
        Me.txt_Utilization.DefaultValue = ""
        Me.txt_Utilization.FillWithMaxInDb = False
        Me.txt_Utilization.IsRequired = False
        Me.txt_Utilization.Location = New System.Drawing.Point(12, 201)
        Me.txt_Utilization.MaxDecimalLength = 2
        Me.txt_Utilization.Name = "txt_Utilization"
        Me.txt_Utilization.Size = New System.Drawing.Size(143, 26)
        Me.txt_Utilization.SpellControl = Nothing
        Me.txt_Utilization.TabIndex = 9
        Me.txt_Utilization.TabStop = False
        Me.txt_Utilization.Tag = "UtilizationDate"
        Me.txt_Utilization.Title = Nothing
        Me.txt_Utilization.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_Utilization.UseForData = True
        Me.txt_Utilization.ValidateCheckExistOnEdit = False
        Me.txt_Utilization.Value = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(164, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "شماره سریال"
        '
        'txt_serial
        '
        Me.txt_serial.CheckExistValueInDb = False
        Me.txt_serial.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_serial.CurrencyUnit = "ریال"
        Me.txt_serial.DefaultValue = ""
        Me.txt_serial.FillWithMaxInDb = False
        Me.txt_serial.IsRequired = False
        Me.txt_serial.Location = New System.Drawing.Point(9, 93)
        Me.txt_serial.MaxDecimalLength = 2
        Me.txt_serial.Name = "txt_serial"
        Me.txt_serial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_serial.Size = New System.Drawing.Size(145, 26)
        Me.txt_serial.SpellControl = Nothing
        Me.txt_serial.TabIndex = 3
        Me.txt_serial.Tag = "SerialNumber"
        Me.txt_serial.Title = Nothing
        Me.txt_serial.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_serial.UseForData = True
        Me.txt_serial.ValidateCheckExistOnEdit = False
        Me.txt_serial.Value = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(440, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "جریان اتصال کوتاه(KA)"
        '
        'txt_JaryanSC
        '
        Me.txt_JaryanSC.CheckExistValueInDb = False
        Me.txt_JaryanSC.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_JaryanSC.CurrencyUnit = "ریال"
        Me.txt_JaryanSC.DefaultValue = ""
        Me.txt_JaryanSC.FillWithMaxInDb = False
        Me.txt_JaryanSC.IsRequired = False
        Me.txt_JaryanSC.Location = New System.Drawing.Point(283, 196)
        Me.txt_JaryanSC.MaxDecimalLength = 2
        Me.txt_JaryanSC.Name = "txt_JaryanSC"
        Me.txt_JaryanSC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_JaryanSC.Size = New System.Drawing.Size(145, 26)
        Me.txt_JaryanSC.SpellControl = Nothing
        Me.txt_JaryanSC.TabIndex = 8
        Me.txt_JaryanSC.Tag = "OrderCode"
        Me.txt_JaryanSC.Title = Nothing
        Me.txt_JaryanSC.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_JaryanSC.UseForData = True
        Me.txt_JaryanSC.ValidateCheckExistOnEdit = False
        Me.txt_JaryanSC.Value = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(440, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "سیستم خاموش کننده"
        '
        'txt_TurnOff
        '
        Me.txt_TurnOff.CheckExistValueInDb = False
        Me.txt_TurnOff.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TurnOff.CurrencyUnit = "ریال"
        Me.txt_TurnOff.DefaultValue = ""
        Me.txt_TurnOff.FillWithMaxInDb = False
        Me.txt_TurnOff.IsRequired = False
        Me.txt_TurnOff.Location = New System.Drawing.Point(283, 161)
        Me.txt_TurnOff.MaxDecimalLength = 2
        Me.txt_TurnOff.Name = "txt_TurnOff"
        Me.txt_TurnOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TurnOff.Size = New System.Drawing.Size(145, 26)
        Me.txt_TurnOff.SpellControl = Nothing
        Me.txt_TurnOff.TabIndex = 6
        Me.txt_TurnOff.Tag = "OrderCode"
        Me.txt_TurnOff.Title = Nothing
        Me.txt_TurnOff.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TurnOff.UseForData = True
        Me.txt_TurnOff.ValidateCheckExistOnEdit = False
        Me.txt_TurnOff.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(164, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "نوع مکانیزم"
        '
        'txt_Mekanism
        '
        Me.txt_Mekanism.CheckExistValueInDb = False
        Me.txt_Mekanism.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Mekanism.CurrencyUnit = "ریال"
        Me.txt_Mekanism.DefaultValue = ""
        Me.txt_Mekanism.FillWithMaxInDb = False
        Me.txt_Mekanism.IsRequired = False
        Me.txt_Mekanism.Location = New System.Drawing.Point(9, 165)
        Me.txt_Mekanism.MaxDecimalLength = 2
        Me.txt_Mekanism.Name = "txt_Mekanism"
        Me.txt_Mekanism.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Mekanism.Size = New System.Drawing.Size(145, 26)
        Me.txt_Mekanism.SpellControl = Nothing
        Me.txt_Mekanism.TabIndex = 7
        Me.txt_Mekanism.Tag = "OrderCode"
        Me.txt_Mekanism.Title = Nothing
        Me.txt_Mekanism.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Mekanism.UseForData = True
        Me.txt_Mekanism.ValidateCheckExistOnEdit = False
        Me.txt_Mekanism.Value = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(440, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ولتاژ نامی(KV)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(164, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 18)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "جریان نامی(A)"
        '
        'txt_VotajN
        '
        Me.txt_VotajN.CheckExistValueInDb = False
        Me.txt_VotajN.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_VotajN.CurrencyUnit = "ریال"
        Me.txt_VotajN.DefaultValue = ""
        Me.txt_VotajN.FillWithMaxInDb = False
        Me.txt_VotajN.IsRequired = False
        Me.txt_VotajN.Location = New System.Drawing.Point(284, 231)
        Me.txt_VotajN.MaxDecimalLength = 2
        Me.txt_VotajN.Name = "txt_VotajN"
        Me.txt_VotajN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_VotajN.Size = New System.Drawing.Size(145, 26)
        Me.txt_VotajN.SpellControl = Nothing
        Me.txt_VotajN.TabIndex = 10
        Me.txt_VotajN.Tag = "OrderCode"
        Me.txt_VotajN.Title = Nothing
        Me.txt_VotajN.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_VotajN.UseForData = True
        Me.txt_VotajN.ValidateCheckExistOnEdit = False
        Me.txt_VotajN.Value = ""
        '
        'txt_JaryanN
        '
        Me.txt_JaryanN.CheckExistValueInDb = False
        Me.txt_JaryanN.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_JaryanN.CurrencyUnit = "ریال"
        Me.txt_JaryanN.DefaultValue = ""
        Me.txt_JaryanN.FillWithMaxInDb = False
        Me.txt_JaryanN.IsRequired = False
        Me.txt_JaryanN.Location = New System.Drawing.Point(10, 237)
        Me.txt_JaryanN.MaxDecimalLength = 2
        Me.txt_JaryanN.Name = "txt_JaryanN"
        Me.txt_JaryanN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_JaryanN.Size = New System.Drawing.Size(145, 26)
        Me.txt_JaryanN.SpellControl = Nothing
        Me.txt_JaryanN.TabIndex = 11
        Me.txt_JaryanN.Tag = "OrderCode"
        Me.txt_JaryanN.Title = Nothing
        Me.txt_JaryanN.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_JaryanN.UseForData = True
        Me.txt_JaryanN.ValidateCheckExistOnEdit = False
        Me.txt_JaryanN.Value = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(440, 275)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "حداکثر ولتاژ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(164, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 18)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "حداکثر جریان"
        '
        'txt_MaxVoltaje
        '
        Me.txt_MaxVoltaje.CheckExistValueInDb = False
        Me.txt_MaxVoltaje.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_MaxVoltaje.CurrencyUnit = "ریال"
        Me.txt_MaxVoltaje.DefaultValue = ""
        Me.txt_MaxVoltaje.FillWithMaxInDb = False
        Me.txt_MaxVoltaje.IsRequired = False
        Me.txt_MaxVoltaje.Location = New System.Drawing.Point(283, 266)
        Me.txt_MaxVoltaje.MaxDecimalLength = 2
        Me.txt_MaxVoltaje.Name = "txt_MaxVoltaje"
        Me.txt_MaxVoltaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_MaxVoltaje.Size = New System.Drawing.Size(145, 26)
        Me.txt_MaxVoltaje.SpellControl = Nothing
        Me.txt_MaxVoltaje.TabIndex = 12
        Me.txt_MaxVoltaje.Tag = "OrderCode"
        Me.txt_MaxVoltaje.Title = Nothing
        Me.txt_MaxVoltaje.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_MaxVoltaje.UseForData = True
        Me.txt_MaxVoltaje.ValidateCheckExistOnEdit = False
        Me.txt_MaxVoltaje.Value = ""
        '
        'txt_MaxJaryan
        '
        Me.txt_MaxJaryan.CheckExistValueInDb = False
        Me.txt_MaxJaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_MaxJaryan.CurrencyUnit = "ریال"
        Me.txt_MaxJaryan.DefaultValue = ""
        Me.txt_MaxJaryan.FillWithMaxInDb = False
        Me.txt_MaxJaryan.IsRequired = False
        Me.txt_MaxJaryan.Location = New System.Drawing.Point(9, 273)
        Me.txt_MaxJaryan.MaxDecimalLength = 2
        Me.txt_MaxJaryan.Name = "txt_MaxJaryan"
        Me.txt_MaxJaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_MaxJaryan.Size = New System.Drawing.Size(145, 26)
        Me.txt_MaxJaryan.SpellControl = Nothing
        Me.txt_MaxJaryan.TabIndex = 13
        Me.txt_MaxJaryan.Tag = "OrderCode"
        Me.txt_MaxJaryan.Title = Nothing
        Me.txt_MaxJaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_MaxJaryan.UseForData = True
        Me.txt_MaxJaryan.ValidateCheckExistOnEdit = False
        Me.txt_MaxJaryan.Value = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(440, 311)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "زمان وصل"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(164, 314)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 18)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "زمان قطع"
        '
        'txt_Connect
        '
        Me.txt_Connect.CheckExistValueInDb = False
        Me.txt_Connect.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Connect.CurrencyUnit = "ریال"
        Me.txt_Connect.DefaultValue = ""
        Me.txt_Connect.FillWithMaxInDb = False
        Me.txt_Connect.IsRequired = False
        Me.txt_Connect.Location = New System.Drawing.Point(283, 301)
        Me.txt_Connect.MaxDecimalLength = 2
        Me.txt_Connect.Name = "txt_Connect"
        Me.txt_Connect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Connect.Size = New System.Drawing.Size(145, 26)
        Me.txt_Connect.SpellControl = Nothing
        Me.txt_Connect.TabIndex = 14
        Me.txt_Connect.Tag = "OrderCode"
        Me.txt_Connect.Title = Nothing
        Me.txt_Connect.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Connect.UseForData = True
        Me.txt_Connect.ValidateCheckExistOnEdit = False
        Me.txt_Connect.Value = ""
        '
        'txt_Disconnect
        '
        Me.txt_Disconnect.CheckExistValueInDb = False
        Me.txt_Disconnect.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Disconnect.CurrencyUnit = "ریال"
        Me.txt_Disconnect.DefaultValue = ""
        Me.txt_Disconnect.FillWithMaxInDb = False
        Me.txt_Disconnect.IsRequired = False
        Me.txt_Disconnect.Location = New System.Drawing.Point(9, 309)
        Me.txt_Disconnect.MaxDecimalLength = 2
        Me.txt_Disconnect.Name = "txt_Disconnect"
        Me.txt_Disconnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Disconnect.Size = New System.Drawing.Size(145, 26)
        Me.txt_Disconnect.SpellControl = Nothing
        Me.txt_Disconnect.TabIndex = 15
        Me.txt_Disconnect.Tag = "OrderCode"
        Me.txt_Disconnect.Title = Nothing
        Me.txt_Disconnect.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Disconnect.UseForData = True
        Me.txt_Disconnect.ValidateCheckExistOnEdit = False
        Me.txt_Disconnect.Value = ""
        '
        'txt_Bill
        '
        Me.txt_Bill.CheckExistValueInDb = False
        Me.txt_Bill.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Bill.CurrencyUnit = "ریال"
        Me.txt_Bill.DefaultValue = ""
        Me.txt_Bill.FillWithMaxInDb = False
        Me.txt_Bill.IsRequired = False
        Me.txt_Bill.Location = New System.Drawing.Point(284, 336)
        Me.txt_Bill.MaxDecimalLength = 2
        Me.txt_Bill.Name = "txt_Bill"
        Me.txt_Bill.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Bill.Size = New System.Drawing.Size(145, 26)
        Me.txt_Bill.SpellControl = Nothing
        Me.txt_Bill.TabIndex = 16
        Me.txt_Bill.Tag = "SerialNumber"
        Me.txt_Bill.Title = Nothing
        Me.txt_Bill.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Bill.UseForData = True
        Me.txt_Bill.ValidateCheckExistOnEdit = False
        Me.txt_Bill.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(164, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 18)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "کد دیسپاچینگ"
        '
        'txt_Dispatching
        '
        Me.txt_Dispatching.CheckExistValueInDb = False
        Me.txt_Dispatching.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Dispatching.CurrencyUnit = "ریال"
        Me.txt_Dispatching.DefaultValue = ""
        Me.txt_Dispatching.FillWithMaxInDb = False
        Me.txt_Dispatching.IsRequired = False
        Me.txt_Dispatching.Location = New System.Drawing.Point(10, 129)
        Me.txt_Dispatching.MaxDecimalLength = 2
        Me.txt_Dispatching.Name = "txt_Dispatching"
        Me.txt_Dispatching.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Dispatching.Size = New System.Drawing.Size(145, 26)
        Me.txt_Dispatching.SpellControl = Nothing
        Me.txt_Dispatching.TabIndex = 5
        Me.txt_Dispatching.Tag = "OrderCode"
        Me.txt_Dispatching.Title = Nothing
        Me.txt_Dispatching.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Dispatching.UseForData = True
        Me.txt_Dispatching.ValidateCheckExistOnEdit = False
        Me.txt_Dispatching.Value = ""
        '
        'Frm_Breaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(622, 511)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Breaker"
        Me.Text = "تعریف بریکر"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PmDeviceSazandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Lab1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmDescriptableTajhizBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_MadeDate As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Sazande As VB_Component.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Model As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_DeviceName As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents Pm_Device_SazandeTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Device_SazandeTableAdapter
    Friend WithEvents Ds_Lab1 As Nama_PM.Ds_Lab
    Friend WithEvents PmDeviceSazandeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Device_SazandeTableAdapter1 As Nama_PM.Ds_LabTableAdapters.Pm_Device_SazandeTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmDescriptableTajhizBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_DescriptableTajhizTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_DescriptableTajhizTableAdapter
    Friend WithEvents txt_Utilization As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_JaryanSC As CS_Component.TextBox
    Friend WithEvents txt_serial As CS_Component.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Mekanism As CS_Component.TextBox
    Friend WithEvents txt_TurnOff As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Disconnect As CS_Component.TextBox
    Friend WithEvents txt_MaxJaryan As CS_Component.TextBox
    Friend WithEvents txt_JaryanN As CS_Component.TextBox
    Friend WithEvents txt_Connect As CS_Component.TextBox
    Friend WithEvents txt_MaxVoltaje As CS_Component.TextBox
    Friend WithEvents txt_VotajN As CS_Component.TextBox
    Friend WithEvents txt_Bill As CS_Component.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Dispatching As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
