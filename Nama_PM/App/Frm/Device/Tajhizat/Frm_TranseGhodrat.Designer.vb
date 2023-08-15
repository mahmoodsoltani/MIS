<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TranseGhodrat
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
        Me.txt_Vectore = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_Colling = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_Volume = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_Votaj = New CS_Component.TextBox
        Me.txt_Jaryan = New CS_Component.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_tapConvert = New CS_Component.TextBox
        Me.txt_TapPlace = New CS_Component.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_ampedance = New CS_Component.TextBox
        Me.txt_Frequncy = New CS_Component.TextBox
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
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 431)
        Me.gbx_Buttons.Size = New System.Drawing.Size(557, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(453, 19)
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
        Me.gbx_Fields.Controls.Add(Me.txt_Frequncy)
        Me.gbx_Fields.Controls.Add(Me.txt_TapPlace)
        Me.gbx_Fields.Controls.Add(Me.txt_Jaryan)
        Me.gbx_Fields.Controls.Add(Me.txt_Volume)
        Me.gbx_Fields.Controls.Add(Me.txt_Dispatching)
        Me.gbx_Fields.Controls.Add(Me.txt_ampedance)
        Me.gbx_Fields.Controls.Add(Me.txt_tapConvert)
        Me.gbx_Fields.Controls.Add(Me.txt_Votaj)
        Me.gbx_Fields.Controls.Add(Me.txt_Colling)
        Me.gbx_Fields.Controls.Add(Me.txt_Vectore)
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
        Me.gbx_Fields.Size = New System.Drawing.Size(557, 388)
        Me.gbx_Fields.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(436, 97)
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
        Me.txt_MadeDate.Location = New System.Drawing.Point(284, 93)
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
        Me.cmb_Sazande.Location = New System.Drawing.Point(284, 129)
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
        Me.Label4.Location = New System.Drawing.Point(436, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "سازنده/ تیپ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(436, 27)
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
        Me.Label2.Location = New System.Drawing.Point(436, 62)
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
        Me.Label5.Location = New System.Drawing.Point(166, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Bil"
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
        Me.Label7.Location = New System.Drawing.Point(165, 209)
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
        Me.Label6.Location = New System.Drawing.Point(165, 102)
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
        Me.Label9.Location = New System.Drawing.Point(436, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "گروه برداری"
        '
        'txt_Vectore
        '
        Me.txt_Vectore.CheckExistValueInDb = False
        Me.txt_Vectore.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Vectore.CurrencyUnit = "ریال"
        Me.txt_Vectore.DefaultValue = ""
        Me.txt_Vectore.FillWithMaxInDb = False
        Me.txt_Vectore.IsRequired = False
        Me.txt_Vectore.Location = New System.Drawing.Point(283, 201)
        Me.txt_Vectore.MaxDecimalLength = 2
        Me.txt_Vectore.Name = "txt_Vectore"
        Me.txt_Vectore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Vectore.Size = New System.Drawing.Size(145, 26)
        Me.txt_Vectore.SpellControl = Nothing
        Me.txt_Vectore.TabIndex = 8
        Me.txt_Vectore.Tag = "OrderCode"
        Me.txt_Vectore.Title = Nothing
        Me.txt_Vectore.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Vectore.UseForData = True
        Me.txt_Vectore.ValidateCheckExistOnEdit = False
        Me.txt_Vectore.Value = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(436, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "خنک کننده"
        '
        'txt_Colling
        '
        Me.txt_Colling.CheckExistValueInDb = False
        Me.txt_Colling.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Colling.CurrencyUnit = "ریال"
        Me.txt_Colling.DefaultValue = ""
        Me.txt_Colling.FillWithMaxInDb = False
        Me.txt_Colling.IsRequired = False
        Me.txt_Colling.Location = New System.Drawing.Point(283, 165)
        Me.txt_Colling.MaxDecimalLength = 2
        Me.txt_Colling.Name = "txt_Colling"
        Me.txt_Colling.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Colling.Size = New System.Drawing.Size(145, 26)
        Me.txt_Colling.SpellControl = Nothing
        Me.txt_Colling.TabIndex = 6
        Me.txt_Colling.Tag = "OrderCode"
        Me.txt_Colling.Title = Nothing
        Me.txt_Colling.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Colling.UseForData = True
        Me.txt_Colling.ValidateCheckExistOnEdit = False
        Me.txt_Colling.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(156, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "ظرفیت نامی(MVA)"
        '
        'txt_Volume
        '
        Me.txt_Volume.CheckExistValueInDb = False
        Me.txt_Volume.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Volume.CurrencyUnit = "ریال"
        Me.txt_Volume.DefaultValue = ""
        Me.txt_Volume.FillWithMaxInDb = False
        Me.txt_Volume.IsRequired = False
        Me.txt_Volume.Location = New System.Drawing.Point(9, 165)
        Me.txt_Volume.MaxDecimalLength = 2
        Me.txt_Volume.Name = "txt_Volume"
        Me.txt_Volume.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Volume.Size = New System.Drawing.Size(145, 26)
        Me.txt_Volume.SpellControl = Nothing
        Me.txt_Volume.TabIndex = 7
        Me.txt_Volume.Tag = "OrderCode"
        Me.txt_Volume.Title = Nothing
        Me.txt_Volume.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Volume.UseForData = True
        Me.txt_Volume.ValidateCheckExistOnEdit = False
        Me.txt_Volume.Value = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(436, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "تبدیل ولتاژ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(166, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 18)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "تبدیل جریان"
        '
        'txt_Votaj
        '
        Me.txt_Votaj.CheckExistValueInDb = False
        Me.txt_Votaj.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Votaj.CurrencyUnit = "ریال"
        Me.txt_Votaj.DefaultValue = ""
        Me.txt_Votaj.FillWithMaxInDb = False
        Me.txt_Votaj.IsRequired = False
        Me.txt_Votaj.Location = New System.Drawing.Point(284, 237)
        Me.txt_Votaj.MaxDecimalLength = 2
        Me.txt_Votaj.Name = "txt_Votaj"
        Me.txt_Votaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Votaj.Size = New System.Drawing.Size(145, 26)
        Me.txt_Votaj.SpellControl = Nothing
        Me.txt_Votaj.TabIndex = 10
        Me.txt_Votaj.Tag = "OrderCode"
        Me.txt_Votaj.Title = Nothing
        Me.txt_Votaj.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Votaj.UseForData = True
        Me.txt_Votaj.ValidateCheckExistOnEdit = False
        Me.txt_Votaj.Value = ""
        '
        'txt_Jaryan
        '
        Me.txt_Jaryan.CheckExistValueInDb = False
        Me.txt_Jaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Jaryan.CurrencyUnit = "ریال"
        Me.txt_Jaryan.DefaultValue = ""
        Me.txt_Jaryan.FillWithMaxInDb = False
        Me.txt_Jaryan.IsRequired = False
        Me.txt_Jaryan.Location = New System.Drawing.Point(10, 237)
        Me.txt_Jaryan.MaxDecimalLength = 2
        Me.txt_Jaryan.Name = "txt_Jaryan"
        Me.txt_Jaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Jaryan.Size = New System.Drawing.Size(145, 26)
        Me.txt_Jaryan.SpellControl = Nothing
        Me.txt_Jaryan.TabIndex = 11
        Me.txt_Jaryan.Tag = "OrderCode"
        Me.txt_Jaryan.Title = Nothing
        Me.txt_Jaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Jaryan.UseForData = True
        Me.txt_Jaryan.ValidateCheckExistOnEdit = False
        Me.txt_Jaryan.Value = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(436, 279)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "سیستم تغییر تپ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(165, 281)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 18)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "محل تپ"
        '
        'txt_tapConvert
        '
        Me.txt_tapConvert.CheckExistValueInDb = False
        Me.txt_tapConvert.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_tapConvert.CurrencyUnit = "ریال"
        Me.txt_tapConvert.DefaultValue = ""
        Me.txt_tapConvert.FillWithMaxInDb = False
        Me.txt_tapConvert.IsRequired = False
        Me.txt_tapConvert.Location = New System.Drawing.Point(283, 273)
        Me.txt_tapConvert.MaxDecimalLength = 2
        Me.txt_tapConvert.Name = "txt_tapConvert"
        Me.txt_tapConvert.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_tapConvert.Size = New System.Drawing.Size(145, 26)
        Me.txt_tapConvert.SpellControl = Nothing
        Me.txt_tapConvert.TabIndex = 12
        Me.txt_tapConvert.Tag = "OrderCode"
        Me.txt_tapConvert.Title = Nothing
        Me.txt_tapConvert.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_tapConvert.UseForData = True
        Me.txt_tapConvert.ValidateCheckExistOnEdit = False
        Me.txt_tapConvert.Value = ""
        '
        'txt_TapPlace
        '
        Me.txt_TapPlace.CheckExistValueInDb = False
        Me.txt_TapPlace.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TapPlace.CurrencyUnit = "ریال"
        Me.txt_TapPlace.DefaultValue = ""
        Me.txt_TapPlace.FillWithMaxInDb = False
        Me.txt_TapPlace.IsRequired = False
        Me.txt_TapPlace.Location = New System.Drawing.Point(9, 273)
        Me.txt_TapPlace.MaxDecimalLength = 2
        Me.txt_TapPlace.Name = "txt_TapPlace"
        Me.txt_TapPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TapPlace.Size = New System.Drawing.Size(145, 26)
        Me.txt_TapPlace.SpellControl = Nothing
        Me.txt_TapPlace.TabIndex = 13
        Me.txt_TapPlace.Tag = "OrderCode"
        Me.txt_TapPlace.Title = Nothing
        Me.txt_TapPlace.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TapPlace.UseForData = True
        Me.txt_TapPlace.ValidateCheckExistOnEdit = False
        Me.txt_TapPlace.Value = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(436, 314)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "درصد امپدانس"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(165, 312)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 18)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "فرکانس(HZ)"
        '
        'txt_ampedance
        '
        Me.txt_ampedance.CheckExistValueInDb = False
        Me.txt_ampedance.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ampedance.CurrencyUnit = "ریال"
        Me.txt_ampedance.DefaultValue = ""
        Me.txt_ampedance.FillWithMaxInDb = False
        Me.txt_ampedance.IsRequired = False
        Me.txt_ampedance.Location = New System.Drawing.Point(283, 309)
        Me.txt_ampedance.MaxDecimalLength = 2
        Me.txt_ampedance.Name = "txt_ampedance"
        Me.txt_ampedance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ampedance.Size = New System.Drawing.Size(145, 26)
        Me.txt_ampedance.SpellControl = Nothing
        Me.txt_ampedance.TabIndex = 14
        Me.txt_ampedance.Tag = "OrderCode"
        Me.txt_ampedance.Title = Nothing
        Me.txt_ampedance.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ampedance.UseForData = True
        Me.txt_ampedance.ValidateCheckExistOnEdit = False
        Me.txt_ampedance.Value = ""
        '
        'txt_Frequncy
        '
        Me.txt_Frequncy.CheckExistValueInDb = False
        Me.txt_Frequncy.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Frequncy.CurrencyUnit = "ریال"
        Me.txt_Frequncy.DefaultValue = ""
        Me.txt_Frequncy.FillWithMaxInDb = False
        Me.txt_Frequncy.IsRequired = False
        Me.txt_Frequncy.Location = New System.Drawing.Point(9, 309)
        Me.txt_Frequncy.MaxDecimalLength = 2
        Me.txt_Frequncy.Name = "txt_Frequncy"
        Me.txt_Frequncy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Frequncy.Size = New System.Drawing.Size(145, 26)
        Me.txt_Frequncy.SpellControl = Nothing
        Me.txt_Frequncy.TabIndex = 15
        Me.txt_Frequncy.Tag = "OrderCode"
        Me.txt_Frequncy.Title = Nothing
        Me.txt_Frequncy.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Frequncy.UseForData = True
        Me.txt_Frequncy.ValidateCheckExistOnEdit = False
        Me.txt_Frequncy.Value = ""
        '
        'txt_Bill
        '
        Me.txt_Bill.CheckExistValueInDb = False
        Me.txt_Bill.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Bill.CurrencyUnit = "ریال"
        Me.txt_Bill.DefaultValue = ""
        Me.txt_Bill.FillWithMaxInDb = False
        Me.txt_Bill.IsRequired = False
        Me.txt_Bill.Location = New System.Drawing.Point(9, 129)
        Me.txt_Bill.MaxDecimalLength = 2
        Me.txt_Bill.Name = "txt_Bill"
        Me.txt_Bill.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Bill.Size = New System.Drawing.Size(145, 26)
        Me.txt_Bill.SpellControl = Nothing
        Me.txt_Bill.TabIndex = 5
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
        Me.Label17.Location = New System.Drawing.Point(436, 352)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 18)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "دیسپاچینگ"
        '
        'txt_Dispatching
        '
        Me.txt_Dispatching.CheckExistValueInDb = False
        Me.txt_Dispatching.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Dispatching.CurrencyUnit = "ریال"
        Me.txt_Dispatching.DefaultValue = ""
        Me.txt_Dispatching.FillWithMaxInDb = False
        Me.txt_Dispatching.IsRequired = False
        Me.txt_Dispatching.Location = New System.Drawing.Point(283, 345)
        Me.txt_Dispatching.MaxDecimalLength = 2
        Me.txt_Dispatching.Name = "txt_Dispatching"
        Me.txt_Dispatching.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Dispatching.Size = New System.Drawing.Size(145, 26)
        Me.txt_Dispatching.SpellControl = Nothing
        Me.txt_Dispatching.TabIndex = 16
        Me.txt_Dispatching.Tag = "OrderCode"
        Me.txt_Dispatching.Title = Nothing
        Me.txt_Dispatching.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Dispatching.UseForData = True
        Me.txt_Dispatching.ValidateCheckExistOnEdit = False
        Me.txt_Dispatching.Value = ""
        '
        'Frm_TranseGhodrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(584, 527)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_TranseGhodrat"
        Me.Text = "تعریف ترانس قدرت"
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
    Friend WithEvents txt_Vectore As CS_Component.TextBox
    Friend WithEvents txt_serial As CS_Component.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Volume As CS_Component.TextBox
    Friend WithEvents txt_Colling As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Frequncy As CS_Component.TextBox
    Friend WithEvents txt_TapPlace As CS_Component.TextBox
    Friend WithEvents txt_Jaryan As CS_Component.TextBox
    Friend WithEvents txt_ampedance As CS_Component.TextBox
    Friend WithEvents txt_tapConvert As CS_Component.TextBox
    Friend WithEvents txt_Votaj As CS_Component.TextBox
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
