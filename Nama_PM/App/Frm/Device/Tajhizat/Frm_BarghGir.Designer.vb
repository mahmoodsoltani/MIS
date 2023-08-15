<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BarghGir
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
        Me.PmDescriptableTajhizBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Pm_DescriptableTajhizTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_DescriptableTajhizTableAdapter
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Utilization = New CS_Component.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_serial = New CS_Component.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_Tavan = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_Voltage = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_Jaryan = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_JaryanSC = New CS_Component.TextBox
        Me.txt_Class = New CS_Component.TextBox
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
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 279)
        Me.gbx_Buttons.Size = New System.Drawing.Size(560, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(456, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.cmb_Sazande)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.txt_Utilization)
        Me.gbx_Fields.Controls.Add(Me.txt_MadeDate)
        Me.gbx_Fields.Controls.Add(Me.Label7)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.txt_Class)
        Me.gbx_Fields.Controls.Add(Me.txt_Jaryan)
        Me.gbx_Fields.Controls.Add(Me.txt_Dispatching)
        Me.gbx_Fields.Controls.Add(Me.txt_JaryanSC)
        Me.gbx_Fields.Controls.Add(Me.txt_Voltage)
        Me.gbx_Fields.Controls.Add(Me.txt_Tavan)
        Me.gbx_Fields.Controls.Add(Me.txt_serial)
        Me.gbx_Fields.Controls.Add(Me.Label12)
        Me.gbx_Fields.Controls.Add(Me.Label10)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.Label11)
        Me.gbx_Fields.Controls.Add(Me.Label8)
        Me.gbx_Fields.Controls.Add(Me.Label9)
        Me.gbx_Fields.Controls.Add(Me.Label6)
        Me.gbx_Fields.Controls.Add(Me.txt_Model)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.txt_DeviceName)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(560, 236)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 99)
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
        Me.Label4.Location = New System.Drawing.Point(440, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "سازنده/ تیپ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(440, 24)
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
        Me.txt_DeviceName.Location = New System.Drawing.Point(11, 21)
        Me.txt_DeviceName.MaxDecimalLength = 2
        Me.txt_DeviceName.Name = "txt_DeviceName"
        Me.txt_DeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceName.Size = New System.Drawing.Size(416, 26)
        Me.txt_DeviceName.SpellControl = Nothing
        Me.txt_DeviceName.TabIndex = 0
        Me.txt_DeviceName.Tag = "Name"
        Me.txt_DeviceName.Title = Nothing
        Me.txt_DeviceName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeviceName.UseForData = True
        Me.txt_DeviceName.ValidateCheckExistOnEdit = True
        Me.txt_DeviceName.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 61)
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
        Me.Label7.Location = New System.Drawing.Point(165, 205)
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
        Me.txt_Utilization.Location = New System.Drawing.Point(11, 201)
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
        Me.Label6.Location = New System.Drawing.Point(165, 99)
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
        Me.txt_serial.Location = New System.Drawing.Point(11, 93)
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
        Me.Label9.Location = New System.Drawing.Point(169, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "توان نامی"
        '
        'txt_Tavan
        '
        Me.txt_Tavan.CheckExistValueInDb = False
        Me.txt_Tavan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Tavan.CurrencyUnit = "ریال"
        Me.txt_Tavan.DefaultValue = ""
        Me.txt_Tavan.FillWithMaxInDb = False
        Me.txt_Tavan.IsRequired = False
        Me.txt_Tavan.Location = New System.Drawing.Point(11, 239)
        Me.txt_Tavan.MaxDecimalLength = 2
        Me.txt_Tavan.Name = "txt_Tavan"
        Me.txt_Tavan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Tavan.Size = New System.Drawing.Size(145, 26)
        Me.txt_Tavan.SpellControl = Nothing
        Me.txt_Tavan.TabIndex = 8
        Me.txt_Tavan.Tag = "OrderCode"
        Me.txt_Tavan.Title = Nothing
        Me.txt_Tavan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Tavan.UseForData = True
        Me.txt_Tavan.ValidateCheckExistOnEdit = False
        Me.txt_Tavan.Value = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(440, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "ولتاژ نامی(KV)"
        '
        'txt_Voltage
        '
        Me.txt_Voltage.CheckExistValueInDb = False
        Me.txt_Voltage.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Voltage.CurrencyUnit = "ریال"
        Me.txt_Voltage.DefaultValue = ""
        Me.txt_Voltage.FillWithMaxInDb = False
        Me.txt_Voltage.IsRequired = False
        Me.txt_Voltage.Location = New System.Drawing.Point(282, 165)
        Me.txt_Voltage.MaxDecimalLength = 2
        Me.txt_Voltage.Name = "txt_Voltage"
        Me.txt_Voltage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Voltage.Size = New System.Drawing.Size(145, 26)
        Me.txt_Voltage.SpellControl = Nothing
        Me.txt_Voltage.TabIndex = 6
        Me.txt_Voltage.Tag = "OrderCode"
        Me.txt_Voltage.Title = Nothing
        Me.txt_Voltage.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Voltage.UseForData = True
        Me.txt_Voltage.ValidateCheckExistOnEdit = False
        Me.txt_Voltage.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(165, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "جریان نامی(KA)"
        '
        'txt_Jaryan
        '
        Me.txt_Jaryan.CheckExistValueInDb = False
        Me.txt_Jaryan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Jaryan.CurrencyUnit = "ریال"
        Me.txt_Jaryan.DefaultValue = ""
        Me.txt_Jaryan.FillWithMaxInDb = False
        Me.txt_Jaryan.IsRequired = False
        Me.txt_Jaryan.Location = New System.Drawing.Point(11, 165)
        Me.txt_Jaryan.MaxDecimalLength = 2
        Me.txt_Jaryan.Name = "txt_Jaryan"
        Me.txt_Jaryan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Jaryan.Size = New System.Drawing.Size(145, 26)
        Me.txt_Jaryan.SpellControl = Nothing
        Me.txt_Jaryan.TabIndex = 7
        Me.txt_Jaryan.Tag = "OrderCode"
        Me.txt_Jaryan.Title = Nothing
        Me.txt_Jaryan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Jaryan.UseForData = True
        Me.txt_Jaryan.ValidateCheckExistOnEdit = False
        Me.txt_Jaryan.Value = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(440, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "جریان اتصال کوتاه"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(436, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 18)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "کلاس"
        '
        'txt_JaryanSC
        '
        Me.txt_JaryanSC.CheckExistValueInDb = False
        Me.txt_JaryanSC.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_JaryanSC.CurrencyUnit = "ریال"
        Me.txt_JaryanSC.DefaultValue = ""
        Me.txt_JaryanSC.FillWithMaxInDb = False
        Me.txt_JaryanSC.IsRequired = False
        Me.txt_JaryanSC.Location = New System.Drawing.Point(282, 237)
        Me.txt_JaryanSC.MaxDecimalLength = 2
        Me.txt_JaryanSC.Name = "txt_JaryanSC"
        Me.txt_JaryanSC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_JaryanSC.Size = New System.Drawing.Size(145, 26)
        Me.txt_JaryanSC.SpellControl = Nothing
        Me.txt_JaryanSC.TabIndex = 10
        Me.txt_JaryanSC.Tag = "OrderCode"
        Me.txt_JaryanSC.Title = Nothing
        Me.txt_JaryanSC.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_JaryanSC.UseForData = True
        Me.txt_JaryanSC.ValidateCheckExistOnEdit = False
        Me.txt_JaryanSC.Value = ""
        '
        'txt_Class
        '
        Me.txt_Class.CheckExistValueInDb = False
        Me.txt_Class.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Class.CurrencyUnit = "ریال"
        Me.txt_Class.DefaultValue = ""
        Me.txt_Class.FillWithMaxInDb = False
        Me.txt_Class.IsRequired = False
        Me.txt_Class.Location = New System.Drawing.Point(282, 205)
        Me.txt_Class.MaxDecimalLength = 2
        Me.txt_Class.Name = "txt_Class"
        Me.txt_Class.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Class.Size = New System.Drawing.Size(145, 26)
        Me.txt_Class.SpellControl = Nothing
        Me.txt_Class.TabIndex = 11
        Me.txt_Class.Tag = "OrderCode"
        Me.txt_Class.Title = Nothing
        Me.txt_Class.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Class.UseForData = True
        Me.txt_Class.ValidateCheckExistOnEdit = False
        Me.txt_Class.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(165, 132)
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
        Me.txt_Dispatching.Location = New System.Drawing.Point(11, 129)
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
        'Frm_BarghGir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(587, 375)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_BarghGir"
        Me.Text = "تعریف برق گیر"
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
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmDescriptableTajhizBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_DescriptableTajhizTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_DescriptableTajhizTableAdapter
    Friend WithEvents txt_Utilization As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Tavan As CS_Component.TextBox
    Friend WithEvents txt_serial As CS_Component.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Jaryan As CS_Component.TextBox
    Friend WithEvents txt_Voltage As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Class As CS_Component.TextBox
    Friend WithEvents txt_JaryanSC As CS_Component.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Dispatching As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
