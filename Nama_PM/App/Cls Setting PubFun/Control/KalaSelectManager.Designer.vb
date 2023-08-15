<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KalaSelectManager
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txt_KalaName = New CS_Component.TextBox
        Me.txt_Barcode = New CS_Component.TextBox
        Me.Btn_Select = New CS_Component.Btn
        Me.SuspendLayout()
        '
        'txt_KalaName
        '
        Me.txt_KalaName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_KalaName.CheckExistValueInDb = False
        Me.txt_KalaName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_KalaName.CurrencyUnit = "ریال"
        Me.txt_KalaName.DefaultValue = ""
        Me.txt_KalaName.FillWithMaxInDb = False
        Me.txt_KalaName.IsRequired = False
        Me.txt_KalaName.Location = New System.Drawing.Point(0, 3)
        Me.txt_KalaName.MaxDecimalLength = 2
        Me.txt_KalaName.Name = "txt_KalaName"
        Me.txt_KalaName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_KalaName.Size = New System.Drawing.Size(247, 21)
        Me.txt_KalaName.SpellControl = Nothing
        Me.txt_KalaName.TabIndex = 1
        Me.txt_KalaName.Title = Nothing
        Me.txt_KalaName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_KalaName.UseForData = True
        Me.txt_KalaName.ValidateCheckExistOnEdit = False
        Me.txt_KalaName.Value = ""
        '
        'txt_Barcode
        '
        Me.txt_Barcode.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txt_Barcode.CheckExistValueInDb = False
        Me.txt_Barcode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Barcode.CurrencyUnit = "ریال"
        Me.txt_Barcode.DefaultValue = ""
        Me.txt_Barcode.FillWithMaxInDb = False
        Me.txt_Barcode.IsRequired = False
        Me.txt_Barcode.Location = New System.Drawing.Point(247, 3)
        Me.txt_Barcode.MaxDecimalLength = 2
        Me.txt_Barcode.Name = "txt_Barcode"
        Me.txt_Barcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Barcode.Size = New System.Drawing.Size(123, 21)
        Me.txt_Barcode.SpellControl = Nothing
        Me.txt_Barcode.TabIndex = 0
        Me.txt_Barcode.Title = Nothing
        Me.txt_Barcode.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_Barcode.UseForData = True
        Me.txt_Barcode.ValidateCheckExistOnEdit = False
        Me.txt_Barcode.Value = ""
        '
        'Btn_Select
        '
        Me.Btn_Select.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Select.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Select.HeaderText = "انتخاب"
        Me.Btn_Select.Location = New System.Drawing.Point(371, 3)
        Me.Btn_Select.Name = "Btn_Select"
        Me.Btn_Select.Size = New System.Drawing.Size(50, 21)
        Me.Btn_Select.TabIndex = 2
        Me.Btn_Select.TabStop = False
        '
        'KalaSelectManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Btn_Select)
        Me.Controls.Add(Me.txt_Barcode)
        Me.Controls.Add(Me.txt_KalaName)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "KalaSelectManager"
        Me.Size = New System.Drawing.Size(421, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_KalaName As CS_Component.TextBox
    Friend WithEvents txt_Barcode As CS_Component.TextBox
    Friend WithEvents Btn_Select As CS_Component.Btn

End Class
