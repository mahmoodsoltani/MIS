<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rele
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
        Me.txt_Order = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_CT = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_VT = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_ANSICode = New VB_Component.ComboBox
        Me.PmANSIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_ANSITableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_ANSITableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PmDeviceSazandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Lab1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmDescriptableTajhizBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmANSIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 292)
        Me.gbx_Buttons.Size = New System.Drawing.Size(541, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(437, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.cmb_ANSICode)
        Me.gbx_Fields.Controls.Add(Me.cmb_Sazande)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.txt_Utilization)
        Me.gbx_Fields.Controls.Add(Me.txt_MadeDate)
        Me.gbx_Fields.Controls.Add(Me.Label7)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.txt_VT)
        Me.gbx_Fields.Controls.Add(Me.txt_CT)
        Me.gbx_Fields.Controls.Add(Me.txt_Order)
        Me.gbx_Fields.Controls.Add(Me.txt_serial)
        Me.gbx_Fields.Controls.Add(Me.Label5)
        Me.gbx_Fields.Controls.Add(Me.Label10)
        Me.gbx_Fields.Controls.Add(Me.Label8)
        Me.gbx_Fields.Controls.Add(Me.Label9)
        Me.gbx_Fields.Controls.Add(Me.Label6)
        Me.gbx_Fields.Controls.Add(Me.txt_Model)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.txt_DeviceName)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(541, 249)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 94)
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
        Me.txt_MadeDate.Location = New System.Drawing.Point(283, 94)
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
        Me.cmb_Sazande.Location = New System.Drawing.Point(283, 133)
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
        Me.Label4.Location = New System.Drawing.Point(440, 133)
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
        Me.txt_DeviceName.Location = New System.Drawing.Point(9, 21)
        Me.txt_DeviceName.MaxDecimalLength = 2
        Me.txt_DeviceName.Name = "txt_DeviceName"
        Me.txt_DeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceName.Size = New System.Drawing.Size(418, 26)
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
        Me.txt_Model.Location = New System.Drawing.Point(9, 58)
        Me.txt_Model.MaxDecimalLength = 2
        Me.txt_Model.Name = "txt_Model"
        Me.txt_Model.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Model.Size = New System.Drawing.Size(418, 26)
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
        Me.txt_Utilization.Location = New System.Drawing.Point(11, 206)
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
        Me.Label6.Location = New System.Drawing.Point(165, 97)
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
        Me.txt_serial.Location = New System.Drawing.Point(9, 92)
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
        Me.Label9.Location = New System.Drawing.Point(440, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "کد سفارش"
        '
        'txt_Order
        '
        Me.txt_Order.CheckExistValueInDb = False
        Me.txt_Order.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Order.CurrencyUnit = "ریال"
        Me.txt_Order.DefaultValue = ""
        Me.txt_Order.FillWithMaxInDb = False
        Me.txt_Order.IsRequired = False
        Me.txt_Order.Location = New System.Drawing.Point(283, 206)
        Me.txt_Order.MaxDecimalLength = 2
        Me.txt_Order.Name = "txt_Order"
        Me.txt_Order.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Order.Size = New System.Drawing.Size(145, 26)
        Me.txt_Order.SpellControl = Nothing
        Me.txt_Order.TabIndex = 8
        Me.txt_Order.Tag = "OrderCode"
        Me.txt_Order.Title = Nothing
        Me.txt_Order.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Order.UseForData = True
        Me.txt_Order.ValidateCheckExistOnEdit = False
        Me.txt_Order.Value = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(440, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "نسبت CT"
        '
        'txt_CT
        '
        Me.txt_CT.CheckExistValueInDb = False
        Me.txt_CT.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_CT.CurrencyUnit = "ریال"
        Me.txt_CT.DefaultValue = ""
        Me.txt_CT.FillWithMaxInDb = False
        Me.txt_CT.IsRequired = False
        Me.txt_CT.Location = New System.Drawing.Point(283, 169)
        Me.txt_CT.MaxDecimalLength = 2
        Me.txt_CT.Name = "txt_CT"
        Me.txt_CT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_CT.Size = New System.Drawing.Size(145, 26)
        Me.txt_CT.SpellControl = Nothing
        Me.txt_CT.TabIndex = 6
        Me.txt_CT.Tag = "OrderCode"
        Me.txt_CT.Title = Nothing
        Me.txt_CT.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_CT.UseForData = True
        Me.txt_CT.ValidateCheckExistOnEdit = False
        Me.txt_CT.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(165, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "نسبت VT"
        '
        'txt_VT
        '
        Me.txt_VT.CheckExistValueInDb = False
        Me.txt_VT.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_VT.CurrencyUnit = "ریال"
        Me.txt_VT.DefaultValue = ""
        Me.txt_VT.FillWithMaxInDb = False
        Me.txt_VT.IsRequired = False
        Me.txt_VT.Location = New System.Drawing.Point(9, 169)
        Me.txt_VT.MaxDecimalLength = 2
        Me.txt_VT.Name = "txt_VT"
        Me.txt_VT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_VT.Size = New System.Drawing.Size(145, 26)
        Me.txt_VT.SpellControl = Nothing
        Me.txt_VT.TabIndex = 7
        Me.txt_VT.Tag = "OrderCode"
        Me.txt_VT.Title = Nothing
        Me.txt_VT.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_VT.UseForData = True
        Me.txt_VT.ValidateCheckExistOnEdit = False
        Me.txt_VT.Value = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "کد ANSI"
        '
        'cmb_ANSICode
        '
        Me.cmb_ANSICode.AllowDrop = True
        Me.cmb_ANSICode.AutoComplete = True
        Me.cmb_ANSICode.DataSource = Me.PmANSIBindingSource
        Me.cmb_ANSICode.DisplayMember = "نام"
        Me.cmb_ANSICode.EnterStop = True
        Me.cmb_ANSICode.FormattingEnabled = True
        Me.cmb_ANSICode.IsRequired = False
        Me.cmb_ANSICode.LimitedToList = False
        Me.cmb_ANSICode.Location = New System.Drawing.Point(6, 130)
        Me.cmb_ANSICode.Name = "cmb_ANSICode"
        Me.cmb_ANSICode.OpenOnFoucus = False
        Me.cmb_ANSICode.Size = New System.Drawing.Size(146, 26)
        Me.cmb_ANSICode.TabIndex = 5
        Me.cmb_ANSICode.ValueMember = "Srl"
        '
        'PmANSIBindingSource
        '
        Me.PmANSIBindingSource.DataMember = "Pm_ANSI"
        Me.PmANSIBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_ANSITableAdapter
        '
        Me.Pm_ANSITableAdapter.ClearBeforeFill = True
        '
        'Frm_Rele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 388)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Rele"
        Me.Text = "تعریف رله جدید"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PmDeviceSazandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Lab1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmDescriptableTajhizBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmANSIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_Order As CS_Component.TextBox
    Friend WithEvents txt_serial As CS_Component.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_VT As CS_Component.TextBox
    Friend WithEvents txt_CT As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_ANSICode As VB_Component.ComboBox
    Friend WithEvents PmANSIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_ANSITableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_ANSITableAdapter
End Class
