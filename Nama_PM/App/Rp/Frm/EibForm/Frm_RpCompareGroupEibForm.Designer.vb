<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpCompareGroupEibForm
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rb_Group = New System.Windows.Forms.RadioButton
        Me.rb_Vahed = New System.Windows.Forms.RadioButton
        Me.rb_DarsadFixed = New System.Windows.Forms.RadioButton
        Me.rb_DarsadNotFixed = New System.Windows.Forms.RadioButton
        Me.rb_Fixed = New System.Windows.Forms.RadioButton
        Me.rb_NoFixed = New System.Windows.Forms.RadioButton
        Me.rb_All = New System.Windows.Forms.RadioButton
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.RpCompareGroupEibFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_CompareGroupEibFormTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_CompareGroupEibFormTableAdapter
        Me.chk_ShowPeiro = New System.Windows.Forms.CheckBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpCompareGroupEibFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 230)
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
        Me.gbx_Fields.Controls.Add(Me.chk_ShowPeiro)
        Me.gbx_Fields.Controls.Add(Me.Panel2)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(488, 187)
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(257, 22)
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
        Me.Label17.Location = New System.Drawing.Point(420, 25)
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
        Me.txt_ToDate.Location = New System.Drawing.Point(22, 22)
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
        Me.Label1.Location = New System.Drawing.Point(194, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "تا تاریخ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(327, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "مرتب سازی بر اساس:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.Controls.Add(Me.rb_Group)
        Me.Panel2.Controls.Add(Me.rb_Vahed)
        Me.Panel2.Controls.Add(Me.rb_DarsadFixed)
        Me.Panel2.Controls.Add(Me.rb_DarsadNotFixed)
        Me.Panel2.Controls.Add(Me.rb_Fixed)
        Me.Panel2.Controls.Add(Me.rb_NoFixed)
        Me.Panel2.Controls.Add(Me.rb_All)
        Me.Panel2.Location = New System.Drawing.Point(17, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 97)
        Me.Panel2.TabIndex = 10
        '
        'rb_Group
        '
        Me.rb_Group.AutoSize = True
        Me.rb_Group.Location = New System.Drawing.Point(383, 12)
        Me.rb_Group.Name = "rb_Group"
        Me.rb_Group.Size = New System.Drawing.Size(52, 22)
        Me.rb_Group.TabIndex = 9
        Me.rb_Group.TabStop = True
        Me.rb_Group.Text = "گروه"
        Me.rb_Group.UseVisualStyleBackColor = True
        '
        'rb_Vahed
        '
        Me.rb_Vahed.AutoSize = True
        Me.rb_Vahed.Location = New System.Drawing.Point(240, 12)
        Me.rb_Vahed.Name = "rb_Vahed"
        Me.rb_Vahed.Size = New System.Drawing.Size(54, 22)
        Me.rb_Vahed.TabIndex = 9
        Me.rb_Vahed.TabStop = True
        Me.rb_Vahed.Text = "واحد"
        Me.rb_Vahed.UseVisualStyleBackColor = True
        '
        'rb_DarsadFixed
        '
        Me.rb_DarsadFixed.AutoSize = True
        Me.rb_DarsadFixed.Location = New System.Drawing.Point(317, 68)
        Me.rb_DarsadFixed.Name = "rb_DarsadFixed"
        Me.rb_DarsadFixed.Size = New System.Drawing.Size(118, 22)
        Me.rb_DarsadFixed.TabIndex = 9
        Me.rb_DarsadFixed.TabStop = True
        Me.rb_DarsadFixed.Text = "درصد رفع شده"
        Me.rb_DarsadFixed.UseVisualStyleBackColor = True
        '
        'rb_DarsadNotFixed
        '
        Me.rb_DarsadNotFixed.AutoSize = True
        Me.rb_DarsadNotFixed.Location = New System.Drawing.Point(171, 68)
        Me.rb_DarsadNotFixed.Name = "rb_DarsadNotFixed"
        Me.rb_DarsadNotFixed.Size = New System.Drawing.Size(123, 22)
        Me.rb_DarsadNotFixed.TabIndex = 9
        Me.rb_DarsadNotFixed.TabStop = True
        Me.rb_DarsadNotFixed.Text = "درصد رفع نشده"
        Me.rb_DarsadNotFixed.UseVisualStyleBackColor = True
        '
        'rb_Fixed
        '
        Me.rb_Fixed.AutoSize = True
        Me.rb_Fixed.Location = New System.Drawing.Point(354, 40)
        Me.rb_Fixed.Name = "rb_Fixed"
        Me.rb_Fixed.Size = New System.Drawing.Size(81, 22)
        Me.rb_Fixed.TabIndex = 9
        Me.rb_Fixed.TabStop = True
        Me.rb_Fixed.Text = "رفع شده"
        Me.rb_Fixed.UseVisualStyleBackColor = True
        '
        'rb_NoFixed
        '
        Me.rb_NoFixed.AutoSize = True
        Me.rb_NoFixed.Location = New System.Drawing.Point(208, 40)
        Me.rb_NoFixed.Name = "rb_NoFixed"
        Me.rb_NoFixed.Size = New System.Drawing.Size(86, 22)
        Me.rb_NoFixed.TabIndex = 9
        Me.rb_NoFixed.TabStop = True
        Me.rb_NoFixed.Text = "رفع نشده"
        Me.rb_NoFixed.UseVisualStyleBackColor = True
        '
        'rb_All
        '
        Me.rb_All.AutoSize = True
        Me.rb_All.Location = New System.Drawing.Point(99, 40)
        Me.rb_All.Name = "rb_All"
        Me.rb_All.Size = New System.Drawing.Size(54, 22)
        Me.rb_All.TabIndex = 9
        Me.rb_All.TabStop = True
        Me.rb_All.Text = "همه"
        Me.rb_All.UseVisualStyleBackColor = True
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RpCompareGroupEibFormBindingSource
        '
        Me.RpCompareGroupEibFormBindingSource.DataMember = "Rp_CompareGroupEibForm"
        Me.RpCompareGroupEibFormBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_CompareGroupEibFormTableAdapter
        '
        Me.Rp_CompareGroupEibFormTableAdapter.ClearBeforeFill = True
        '
        'chk_ShowPeiro
        '
        Me.chk_ShowPeiro.AutoSize = True
        Me.chk_ShowPeiro.Location = New System.Drawing.Point(22, 55)
        Me.chk_ShowPeiro.Name = "chk_ShowPeiro"
        Me.chk_ShowPeiro.Size = New System.Drawing.Size(158, 22)
        Me.chk_ShowPeiro.TabIndex = 147
        Me.chk_ShowPeiro.Text = "با در نظر گرفتن پیروها"
        Me.chk_ShowPeiro.UseVisualStyleBackColor = True
        '
        'Frm_RpCompareGroupEibForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(513, 323)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpCompareGroupEibForm"
        Me.Text = "گزارش مقایسه ای گروه ها"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpCompareGroupEibFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rb_Fixed As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NoFixed As System.Windows.Forms.RadioButton
    Friend WithEvents rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rb_Group As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Vahed As System.Windows.Forms.RadioButton
    Friend WithEvents rb_DarsadFixed As System.Windows.Forms.RadioButton
    Friend WithEvents rb_DarsadNotFixed As System.Windows.Forms.RadioButton
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents RpCompareGroupEibFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_CompareGroupEibFormTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_CompareGroupEibFormTableAdapter
    Friend WithEvents chk_ShowPeiro As System.Windows.Forms.CheckBox
End Class
