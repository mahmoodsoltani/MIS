<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpMojodiAnbar
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
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PM_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.RpPmKalaUseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_Pm_KalaUseTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_Pm_KalaUseTableAdapter
        Me.RpMojodiAnbarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_MojodiAnbarTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_MojodiAnbarTableAdapter
        Me.txt_LessThan = New CS_Component.TextBox
        Me.txt_BigerThan = New CS_Component.TextBox
        Me.chk_BigAll = New System.Windows.Forms.CheckBox
        Me.chk_LessAll = New System.Windows.Forms.CheckBox
        Me.chk_AllKala = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.KalaSelectManager2 = New Nama_PM.KalaSelectManager
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpPmKalaUseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpMojodiAnbarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 190)
        Me.gbx_Buttons.Size = New System.Drawing.Size(533, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(429, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.txt_LessThan)
        Me.gbx_Fields.Controls.Add(Me.txt_BigerThan)
        Me.gbx_Fields.Controls.Add(Me.chk_BigAll)
        Me.gbx_Fields.Controls.Add(Me.chk_LessAll)
        Me.gbx_Fields.Controls.Add(Me.chk_AllKala)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.KalaSelectManager2)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(534, 150)
        Me.gbx_Fields.Text = "فیلتر بر اساس"
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "PM_Post"
        Me.BindingSource3.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "Pm_Group"
        Me.BindingSource4.DataSource = Me.Ds_Pm
        '
        'PM_PostTableAdapter
        '
        Me.PM_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RpPmKalaUseBindingSource
        '
        Me.RpPmKalaUseBindingSource.DataMember = "Rp_Pm_KalaUse"
        Me.RpPmKalaUseBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_Pm_KalaUseTableAdapter
        '
        Me.Rp_Pm_KalaUseTableAdapter.ClearBeforeFill = True
        '
        'RpMojodiAnbarBindingSource
        '
        Me.RpMojodiAnbarBindingSource.DataMember = "Rp_MojodiAnbar"
        Me.RpMojodiAnbarBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_MojodiAnbarTableAdapter
        '
        Me.Rp_MojodiAnbarTableAdapter.ClearBeforeFill = True
        '
        'txt_LessThan
        '
        Me.txt_LessThan.CheckExistValueInDb = True
        Me.txt_LessThan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_LessThan.CurrencyUnit = "ریال"
        Me.txt_LessThan.DefaultValue = ""
        Me.txt_LessThan.FillWithMaxInDb = False
        Me.txt_LessThan.IsRequired = True
        Me.txt_LessThan.Location = New System.Drawing.Point(290, 64)
        Me.txt_LessThan.MaxDecimalLength = 2
        Me.txt_LessThan.Name = "txt_LessThan"
        Me.txt_LessThan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_LessThan.Size = New System.Drawing.Size(108, 25)
        Me.txt_LessThan.SpellControl = Nothing
        Me.txt_LessThan.TabIndex = 158
        Me.txt_LessThan.Tag = ""
        Me.txt_LessThan.Title = Nothing
        Me.txt_LessThan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_LessThan.UseForData = True
        Me.txt_LessThan.ValidateCheckExistOnEdit = False
        Me.txt_LessThan.Value = ""
        '
        'txt_BigerThan
        '
        Me.txt_BigerThan.CheckExistValueInDb = True
        Me.txt_BigerThan.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BigerThan.CurrencyUnit = "ریال"
        Me.txt_BigerThan.DefaultValue = ""
        Me.txt_BigerThan.FillWithMaxInDb = False
        Me.txt_BigerThan.IsRequired = True
        Me.txt_BigerThan.Location = New System.Drawing.Point(290, 104)
        Me.txt_BigerThan.MaxDecimalLength = 2
        Me.txt_BigerThan.Name = "txt_BigerThan"
        Me.txt_BigerThan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_BigerThan.Size = New System.Drawing.Size(108, 25)
        Me.txt_BigerThan.SpellControl = Nothing
        Me.txt_BigerThan.TabIndex = 157
        Me.txt_BigerThan.Tag = ""
        Me.txt_BigerThan.Title = Nothing
        Me.txt_BigerThan.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_BigerThan.UseForData = True
        Me.txt_BigerThan.ValidateCheckExistOnEdit = False
        Me.txt_BigerThan.Value = ""
        '
        'chk_BigAll
        '
        Me.chk_BigAll.AutoSize = True
        Me.chk_BigAll.Checked = True
        Me.chk_BigAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_BigAll.Location = New System.Drawing.Point(10, 103)
        Me.chk_BigAll.Name = "chk_BigAll"
        Me.chk_BigAll.Size = New System.Drawing.Size(55, 22)
        Me.chk_BigAll.TabIndex = 155
        Me.chk_BigAll.Text = "همه"
        Me.chk_BigAll.UseVisualStyleBackColor = True
        '
        'chk_LessAll
        '
        Me.chk_LessAll.AutoSize = True
        Me.chk_LessAll.Checked = True
        Me.chk_LessAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_LessAll.Location = New System.Drawing.Point(10, 66)
        Me.chk_LessAll.Name = "chk_LessAll"
        Me.chk_LessAll.Size = New System.Drawing.Size(55, 22)
        Me.chk_LessAll.TabIndex = 154
        Me.chk_LessAll.Text = "همه"
        Me.chk_LessAll.UseVisualStyleBackColor = True
        '
        'chk_AllKala
        '
        Me.chk_AllKala.AutoSize = True
        Me.chk_AllKala.Checked = True
        Me.chk_AllKala.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_AllKala.Location = New System.Drawing.Point(10, 24)
        Me.chk_AllKala.Name = "chk_AllKala"
        Me.chk_AllKala.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllKala.TabIndex = 153
        Me.chk_AllKala.Text = "همه"
        Me.chk_AllKala.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(404, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 18)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "موجودی بیشتر از:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(404, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "موجودی کمتر از:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "کالا :"
        '
        'KalaSelectManager2
        '
        Me.KalaSelectManager2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KalaSelectManager2.Location = New System.Drawing.Point(78, 23)
        Me.KalaSelectManager2.Name = "KalaSelectManager2"
        Me.KalaSelectManager2.Result = Nothing
        Me.KalaSelectManager2.SelectQueryMode = Nama_PM.KalaSelectManager.QueryMode.SelectKala
        Me.KalaSelectManager2.Size = New System.Drawing.Size(320, 26)
        Me.KalaSelectManager2.TabIndex = 164
        '
        'Frm_RpMojodiAnbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(560, 278)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpMojodiAnbar"
        Me.Text = "گزارش موجودی انبار"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpPmKalaUseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpMojodiAnbarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Names As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibFormMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibFormMasterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PM_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.PM_PostTableAdapter
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents RpPmKalaUseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_Pm_KalaUseTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_Pm_KalaUseTableAdapter
    Friend WithEvents RpMojodiAnbarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_MojodiAnbarTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_MojodiAnbarTableAdapter
    Friend WithEvents txt_LessThan As CS_Component.TextBox
    Friend WithEvents txt_BigerThan As CS_Component.TextBox
    Friend WithEvents KalaSelectManager2 As KalaSelectManager
    Friend WithEvents chk_BigAll As System.Windows.Forms.CheckBox
    Friend WithEvents chk_LessAll As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllKala As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
