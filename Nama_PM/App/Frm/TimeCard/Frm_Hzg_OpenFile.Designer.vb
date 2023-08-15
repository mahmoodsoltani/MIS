<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Hzg_OpenFile
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
        Me.txt_Addres = New CS_Component.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_OpenFile = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.txt_Log = New System.Windows.Forms.ListBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(12, 322)
        Me.gbx_Buttons.Size = New System.Drawing.Size(572, 50)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.HeaderText = "خروج"
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(481, 17)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.txt_Log)
        Me.gbx_Fields.Controls.Add(Me.ProgressBar1)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.txt_Addres)
        Me.gbx_Fields.Size = New System.Drawing.Size(572, 284)
        '
        'txt_Addres
        '
        Me.txt_Addres.BackColor = System.Drawing.SystemColors.Info
        Me.txt_Addres.CheckExistValueInDb = False
        Me.txt_Addres.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Addres.CurrencyUnit = "ریال"
        Me.txt_Addres.DefaultValue = ""
        Me.txt_Addres.Enabled = False
        Me.txt_Addres.FillWithMaxInDb = False
        Me.txt_Addres.IsRequired = False
        Me.txt_Addres.Location = New System.Drawing.Point(10, 22)
        Me.txt_Addres.MaxDecimalLength = 2
        Me.txt_Addres.Name = "txt_Addres"
        Me.txt_Addres.ReadOnly = True
        Me.txt_Addres.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Addres.Size = New System.Drawing.Size(364, 23)
        Me.txt_Addres.SpellControl = Nothing
        Me.txt_Addres.TabIndex = 12
        Me.txt_Addres.Title = Nothing
        Me.txt_Addres.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Addres.UseForData = True
        Me.txt_Addres.ValidateCheckExistOnEdit = False
        Me.txt_Addres.Value = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_OpenFile)
        Me.Panel1.Location = New System.Drawing.Point(380, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 28)
        Me.Panel1.TabIndex = 17
        '
        'Btn_OpenFile
        '
        Me.Btn_OpenFile.Location = New System.Drawing.Point(19, 2)
        Me.Btn_OpenFile.Name = "Btn_OpenFile"
        Me.Btn_OpenFile.Size = New System.Drawing.Size(161, 26)
        Me.Btn_OpenFile.TabIndex = 18
        Me.Btn_OpenFile.Text = "انتخاب مسیر فایل ها"
        Me.Btn_OpenFile.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 57)
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(557, 23)
        Me.ProgressBar1.TabIndex = 18
        '
        'txt_Log
        '
        Me.txt_Log.FormattingEnabled = True
        Me.txt_Log.ItemHeight = 16
        Me.txt_Log.Location = New System.Drawing.Point(28, 90)
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.Size = New System.Drawing.Size(518, 180)
        Me.txt_Log.TabIndex = 19
        '
        'Frm_Hzg_OpenFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(596, 408)
        Me.Name = "Frm_Hzg_OpenFile"
        Me.Text = "ورود اطلاعات فایل"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_Addres As CS_Component.TextBox
    Friend WithEvents Btn_OpenFile As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txt_Log As System.Windows.Forms.ListBox
End Class
