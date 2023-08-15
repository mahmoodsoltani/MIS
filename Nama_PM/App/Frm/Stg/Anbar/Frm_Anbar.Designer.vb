<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Anbar
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txt_tel = New CS_Component.TextBox
        Me.Txt_Dis = New CS_Component.TextBox
        Me.Txt_Adress = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Txt_Name = New CS_Component.TextBox
        Me.Txt_Code = New CS_Component.TextBox
        Me.Chk_CanEdit = New System.Windows.Forms.CheckBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 245)
        Me.gbx_Buttons.Size = New System.Drawing.Size(547, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(443, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Chk_CanEdit)
        Me.gbx_Fields.Controls.Add(Me.Txt_Code)
        Me.gbx_Fields.Controls.Add(Me.Txt_Adress)
        Me.gbx_Fields.Controls.Add(Me.Txt_Dis)
        Me.gbx_Fields.Controls.Add(Me.Txt_tel)
        Me.gbx_Fields.Controls.Add(Me.Txt_Name)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label5)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(547, 202)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "کد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(459, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "توضیحات"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(481, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "آدرس"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(486, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "تلفن"
        '
        'Txt_tel
        '
        Me.Txt_tel.CheckExistValueInDb = False
        Me.Txt_tel.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_tel.CurrencyUnit = "ریال"
        Me.Txt_tel.DefaultValue = ""
        Me.Txt_tel.FillWithMaxInDb = False
        Me.Txt_tel.IsRequired = False
        Me.Txt_tel.Location = New System.Drawing.Point(315, 94)
        Me.Txt_tel.MaxDecimalLength = 2
        Me.Txt_tel.Name = "Txt_tel"
        Me.Txt_tel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_tel.Size = New System.Drawing.Size(131, 25)
        Me.Txt_tel.SpellControl = Nothing
        Me.Txt_tel.TabIndex = 4
        Me.Txt_tel.Tag = "Tel"
        Me.Txt_tel.Text = "0"
        Me.Txt_tel.Title = Nothing
        Me.Txt_tel.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.Txt_tel.UseForData = True
        Me.Txt_tel.ValidateCheckExistOnEdit = False
        Me.Txt_tel.Value = 0
        '
        'Txt_Dis
        '
        Me.Txt_Dis.CheckExistValueInDb = False
        Me.Txt_Dis.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Dis.CurrencyUnit = "ریال"
        Me.Txt_Dis.DefaultValue = ""
        Me.Txt_Dis.FillWithMaxInDb = False
        Me.Txt_Dis.IsRequired = False
        Me.Txt_Dis.Location = New System.Drawing.Point(33, 162)
        Me.Txt_Dis.MaxDecimalLength = 2
        Me.Txt_Dis.Name = "Txt_Dis"
        Me.Txt_Dis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Dis.Size = New System.Drawing.Size(413, 25)
        Me.Txt_Dis.SpellControl = Nothing
        Me.Txt_Dis.TabIndex = 6
        Me.Txt_Dis.Tag = "Dis"
        Me.Txt_Dis.Title = Nothing
        Me.Txt_Dis.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.Txt_Dis.UseForData = True
        Me.Txt_Dis.ValidateCheckExistOnEdit = False
        Me.Txt_Dis.Value = ""
        '
        'Txt_Adress
        '
        Me.Txt_Adress.CheckExistValueInDb = False
        Me.Txt_Adress.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Adress.CurrencyUnit = "ریال"
        Me.Txt_Adress.DefaultValue = ""
        Me.Txt_Adress.FillWithMaxInDb = False
        Me.Txt_Adress.IsRequired = False
        Me.Txt_Adress.Location = New System.Drawing.Point(34, 127)
        Me.Txt_Adress.MaxDecimalLength = 2
        Me.Txt_Adress.Name = "Txt_Adress"
        Me.Txt_Adress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Adress.Size = New System.Drawing.Size(413, 25)
        Me.Txt_Adress.SpellControl = Nothing
        Me.Txt_Adress.TabIndex = 5
        Me.Txt_Adress.Tag = "Adress"
        Me.Txt_Adress.Title = Nothing
        Me.Txt_Adress.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.Txt_Adress.UseForData = True
        Me.Txt_Adress.ValidateCheckExistOnEdit = False
        Me.Txt_Adress.Value = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(497, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "نام"
        '
        'Txt_Name
        '
        Me.Txt_Name.CheckExistValueInDb = False
        Me.Txt_Name.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Name.CurrencyUnit = "ریال"
        Me.Txt_Name.DefaultValue = ""
        Me.Txt_Name.FillWithMaxInDb = False
        Me.Txt_Name.IsRequired = True
        Me.Txt_Name.Location = New System.Drawing.Point(315, 62)
        Me.Txt_Name.MaxDecimalLength = 2
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Name.Size = New System.Drawing.Size(131, 25)
        Me.Txt_Name.SpellControl = Nothing
        Me.Txt_Name.TabIndex = 3
        Me.Txt_Name.Tag = "Name"
        Me.Txt_Name.Title = Nothing
        Me.Txt_Name.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.Txt_Name.UseForData = True
        Me.Txt_Name.ValidateCheckExistOnEdit = False
        Me.Txt_Name.Value = ""
        '
        'Txt_Code
        '
        Me.Txt_Code.CheckExistValueInDb = True
        Me.Txt_Code.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Code.CurrencyUnit = "ریال"
        Me.Txt_Code.DefaultValue = ""
        Me.Txt_Code.FillWithMaxInDb = False
        Me.Txt_Code.IsRequired = True
        Me.Txt_Code.Location = New System.Drawing.Point(315, 25)
        Me.Txt_Code.MaxDecimalLength = 2
        Me.Txt_Code.Name = "Txt_Code"
        Me.Txt_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Code.Size = New System.Drawing.Size(131, 25)
        Me.Txt_Code.SpellControl = Nothing
        Me.Txt_Code.TabIndex = 1
        Me.Txt_Code.Tag = "Code"
        Me.Txt_Code.Text = "0"
        Me.Txt_Code.Title = Nothing
        Me.Txt_Code.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.Txt_Code.UseForData = True
        Me.Txt_Code.ValidateCheckExistOnEdit = True
        Me.Txt_Code.Value = 0
        '
        'Chk_CanEdit
        '
        Me.Chk_CanEdit.AutoSize = True
        Me.Chk_CanEdit.Location = New System.Drawing.Point(160, 25)
        Me.Chk_CanEdit.Name = "Chk_CanEdit"
        Me.Chk_CanEdit.Size = New System.Drawing.Size(100, 22)
        Me.Chk_CanEdit.TabIndex = 2
        Me.Chk_CanEdit.Text = "قابل ویرایش"
        Me.Chk_CanEdit.UseVisualStyleBackColor = True
        '
        'Frm_Anbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(575, 342)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Name = "Frm_Anbar"
        Me.TableName = "Stg_Anbar"
        Me.Text = "افزودن انبار"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Adress As CS_Component.TextBox
    Friend WithEvents Txt_Dis As CS_Component.TextBox
    Friend WithEvents Txt_tel As CS_Component.TextBox
    Friend WithEvents Txt_Name As CS_Component.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_Code As CS_Component.TextBox
    Friend WithEvents Chk_CanEdit As System.Windows.Forms.CheckBox
End Class
