<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpNafarSatGroup
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
        Me.Cmb_Group = New VB_Component.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_FromDate = New CS_Component.TextBox
        Me.chk_AllGroup = New System.Windows.Forms.CheckBox
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.RpNafarSatGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_NafarSatGroupTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_NafarSatGroupTableAdapter
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpNafarSatGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 157)
        Me.gbx_Buttons.Size = New System.Drawing.Size(514, 52)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 15)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(410, 15)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.chk_AllGroup)
        Me.gbx_Fields.Controls.Add(Me.Cmb_Group)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(514, 114)
        '
        'Cmb_Group
        '
        Me.Cmb_Group.AutoComplete = True
        Me.Cmb_Group.DataSource = Me.PmGroupBindingSource
        Me.Cmb_Group.DisplayMember = "نام"
        Me.Cmb_Group.EnterStop = True
        Me.Cmb_Group.FormattingEnabled = True
        Me.Cmb_Group.IsRequired = False
        Me.Cmb_Group.LimitedToList = True
        Me.Cmb_Group.Location = New System.Drawing.Point(267, 67)
        Me.Cmb_Group.Name = "Cmb_Group"
        Me.Cmb_Group.OpenOnFoucus = True
        Me.Cmb_Group.Size = New System.Drawing.Size(170, 26)
        Me.Cmb_Group.TabIndex = 161
        Me.Cmb_Group.ValueMember = "Srl"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "تا تاریخ"
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(11, 25)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(169, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 153
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(447, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 18)
        Me.Label17.TabIndex = 157
        Me.Label17.Text = "از تاریخ"
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(268, 25)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(169, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 152
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'chk_AllGroup
        '
        Me.chk_AllGroup.AutoSize = True
        Me.chk_AllGroup.Location = New System.Drawing.Point(440, 71)
        Me.chk_AllGroup.Name = "chk_AllGroup"
        Me.chk_AllGroup.Size = New System.Drawing.Size(68, 22)
        Me.chk_AllGroup.TabIndex = 162
        Me.chk_AllGroup.Text = "گروهها"
        Me.chk_AllGroup.UseVisualStyleBackColor = True
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RpNafarSatGroupBindingSource
        '
        Me.RpNafarSatGroupBindingSource.DataMember = "Rp_NafarSatGroup"
        Me.RpNafarSatGroupBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_NafarSatGroupTableAdapter
        '
        Me.Rp_NafarSatGroupTableAdapter.ClearBeforeFill = True
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Frm_RpNafarSatGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(545, 244)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpNafarSatGroup"
        Me.Text = "نفر ساعت کار گروه ها"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpNafarSatGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cmb_Group As VB_Component.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents RpNafarSatGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_NafarSatGroupTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_NafarSatGroupTableAdapter
    Friend WithEvents chk_AllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
End Class
