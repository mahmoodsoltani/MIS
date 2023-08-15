<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpExtraWork
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
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lk_Ashkhas = New CS_Component.LookupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Acc_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.RpExtraWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_ExtraWorkTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_ExtraWorkTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpExtraWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 178)
        Me.gbx_Buttons.Size = New System.Drawing.Size(488, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(384, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.lk_Ashkhas)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(488, 138)
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(265, 75)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(148, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 7
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(428, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 18)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "از تاریخ"
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(22, 75)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(148, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 7
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "تا تاریخ"
        '
        'lk_Ashkhas
        '
        Me.lk_Ashkhas.CodeBoxWidth = 0
        Me.lk_Ashkhas.CodeField = "کد"
        Me.lk_Ashkhas.DataAccess = Nothing
        Me.lk_Ashkhas.DataFields = Nothing
        Me.lk_Ashkhas.DataMode = CS_Component.LookupDataMode.UseDataTable
        Me.lk_Ashkhas.DataSource = Me.AccAshkhasBindingSource
        Me.lk_Ashkhas.DefaultSearchField = Nothing
        Me.lk_Ashkhas.DisplayCodeBox = False
        Me.lk_Ashkhas.DisplayField = "نام و نام خانوادگی"
        Me.lk_Ashkhas.Filter = ""
        Me.lk_Ashkhas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lk_Ashkhas.HiddenFields = Nothing
        Me.lk_Ashkhas.Location = New System.Drawing.Point(95, 21)
        Me.lk_Ashkhas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lk_Ashkhas.Name = "lk_Ashkhas"
        Me.lk_Ashkhas.Result = Nothing
        Me.lk_Ashkhas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lk_Ashkhas.Size = New System.Drawing.Size(318, 26)
        Me.lk_Ashkhas.TabIndex = 9
        Me.lk_Ashkhas.TableName = Nothing
        Me.lk_Ashkhas.ValueField = "Srl"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(423, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "نام"
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccAshkhasBindingSource
        '
        Me.AccAshkhasBindingSource.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Acc_AshkhasTableAdapter
        '
        Me.Acc_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RpExtraWorkBindingSource
        '
        Me.RpExtraWorkBindingSource.DataMember = "Rp_ExtraWork"
        Me.RpExtraWorkBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_ExtraWorkTableAdapter
        '
        Me.Rp_ExtraWorkTableAdapter.ClearBeforeFill = True
        '
        'Frm_RpExtraWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 249)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpExtraWork"
        Me.Text = "گزارش اضافه کار"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpExtraWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lk_Ashkhas As CS_Component.LookupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents RpExtraWorkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_ExtraWorkTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_ExtraWorkTableAdapter
End Class
