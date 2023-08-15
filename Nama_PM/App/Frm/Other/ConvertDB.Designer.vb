<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertDB
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
        Me.Btn_Brows = New CS_Component.Btn
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.txt_Log = New System.Windows.Forms.ListBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.chk_WrokForm = New System.Windows.Forms.CheckBox
        Me.Chk_EibForm = New System.Windows.Forms.CheckBox
        Me.lnk_DdeeteWorkForm = New System.Windows.Forms.LinkLabel
        Me.lnk_DeleteFormNaghs = New System.Windows.Forms.LinkLabel
        Me.chk_TimeCard = New System.Windows.Forms.CheckBox
        Me.lnk_DeleteTimecard = New System.Windows.Forms.LinkLabel
        Me.chk_Holiday = New System.Windows.Forms.CheckBox
        Me.llb_DeleteAll = New System.Windows.Forms.LinkLabel
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(12, 385)
        Me.gbx_Buttons.Size = New System.Drawing.Size(572, 50)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.HeaderText = "خروج"
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "شروع به روز رسانی"
        Me.btn_Save.Location = New System.Drawing.Point(408, 17)
        Me.btn_Save.Size = New System.Drawing.Size(153, 26)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.llb_DeleteAll)
        Me.gbx_Fields.Controls.Add(Me.lnk_DeleteTimecard)
        Me.gbx_Fields.Controls.Add(Me.lnk_DeleteFormNaghs)
        Me.gbx_Fields.Controls.Add(Me.lnk_DdeeteWorkForm)
        Me.gbx_Fields.Controls.Add(Me.chk_Holiday)
        Me.gbx_Fields.Controls.Add(Me.chk_TimeCard)
        Me.gbx_Fields.Controls.Add(Me.Chk_EibForm)
        Me.gbx_Fields.Controls.Add(Me.chk_WrokForm)
        Me.gbx_Fields.Controls.Add(Me.txt_Log)
        Me.gbx_Fields.Controls.Add(Me.ProgressBar1)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.txt_Addres)
        Me.gbx_Fields.Size = New System.Drawing.Size(572, 347)
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
        Me.txt_Addres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Addres.Title = Nothing
        Me.txt_Addres.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Addres.UseForData = True
        Me.txt_Addres.ValidateCheckExistOnEdit = False
        Me.txt_Addres.Value = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_Brows)
        Me.Panel1.Location = New System.Drawing.Point(380, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 34)
        Me.Panel1.TabIndex = 17
        '
        'Btn_Brows
        '
        Me.Btn_Brows.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Brows.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Brows.HeaderText = "انتخاب مسیر بانک قبلی"
        Me.Btn_Brows.Location = New System.Drawing.Point(17, 2)
        Me.Btn_Brows.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Brows.Name = "Btn_Brows"
        Me.Btn_Brows.Size = New System.Drawing.Size(152, 25)
        Me.Btn_Brows.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 147)
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(557, 23)
        Me.ProgressBar1.TabIndex = 18
        '
        'txt_Log
        '
        Me.txt_Log.FormattingEnabled = True
        Me.txt_Log.ItemHeight = 16
        Me.txt_Log.Location = New System.Drawing.Point(24, 176)
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.Size = New System.Drawing.Size(518, 164)
        Me.txt_Log.TabIndex = 19
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Microsoft Access File|*.mdb|All files|*.*"
        '
        'chk_WrokForm
        '
        Me.chk_WrokForm.AutoSize = True
        Me.chk_WrokForm.Checked = True
        Me.chk_WrokForm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_WrokForm.Location = New System.Drawing.Point(368, 66)
        Me.chk_WrokForm.Name = "chk_WrokForm"
        Me.chk_WrokForm.Size = New System.Drawing.Size(147, 20)
        Me.chk_WrokForm.TabIndex = 20
        Me.chk_WrokForm.Text = "انتقال اطلاعات فرم کار"
        Me.chk_WrokForm.UseVisualStyleBackColor = True
        '
        'Chk_EibForm
        '
        Me.Chk_EibForm.AutoSize = True
        Me.Chk_EibForm.Checked = True
        Me.Chk_EibForm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_EibForm.Location = New System.Drawing.Point(357, 92)
        Me.Chk_EibForm.Name = "Chk_EibForm"
        Me.Chk_EibForm.Size = New System.Drawing.Size(158, 20)
        Me.Chk_EibForm.TabIndex = 20
        Me.Chk_EibForm.Text = "انتقال اطلاعات فرم نقص"
        Me.Chk_EibForm.UseVisualStyleBackColor = True
        '
        'lnk_DdeeteWorkForm
        '
        Me.lnk_DdeeteWorkForm.AutoSize = True
        Me.lnk_DdeeteWorkForm.Location = New System.Drawing.Point(10, 57)
        Me.lnk_DdeeteWorkForm.Name = "lnk_DdeeteWorkForm"
        Me.lnk_DdeeteWorkForm.Size = New System.Drawing.Size(124, 16)
        Me.lnk_DdeeteWorkForm.TabIndex = 21
        Me.lnk_DdeeteWorkForm.TabStop = True
        Me.lnk_DdeeteWorkForm.Text = "حذف اطلاعات فرم کار"
        '
        'lnk_DeleteFormNaghs
        '
        Me.lnk_DeleteFormNaghs.AutoSize = True
        Me.lnk_DeleteFormNaghs.Location = New System.Drawing.Point(10, 81)
        Me.lnk_DeleteFormNaghs.Name = "lnk_DeleteFormNaghs"
        Me.lnk_DeleteFormNaghs.Size = New System.Drawing.Size(135, 16)
        Me.lnk_DeleteFormNaghs.TabIndex = 21
        Me.lnk_DeleteFormNaghs.TabStop = True
        Me.lnk_DeleteFormNaghs.Text = "حذف اطلاعات فرم نقص"
        '
        'chk_TimeCard
        '
        Me.chk_TimeCard.AutoSize = True
        Me.chk_TimeCard.Checked = True
        Me.chk_TimeCard.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_TimeCard.Location = New System.Drawing.Point(178, 66)
        Me.chk_TimeCard.Name = "chk_TimeCard"
        Me.chk_TimeCard.Size = New System.Drawing.Size(161, 20)
        Me.chk_TimeCard.TabIndex = 20
        Me.chk_TimeCard.Text = "انتقال اطلاعات تایم کارت"
        Me.chk_TimeCard.UseVisualStyleBackColor = True
        '
        'lnk_DeleteTimecard
        '
        Me.lnk_DeleteTimecard.AutoSize = True
        Me.lnk_DeleteTimecard.Location = New System.Drawing.Point(10, 105)
        Me.lnk_DeleteTimecard.Name = "lnk_DeleteTimecard"
        Me.lnk_DeleteTimecard.Size = New System.Drawing.Size(138, 16)
        Me.lnk_DeleteTimecard.TabIndex = 21
        Me.lnk_DeleteTimecard.TabStop = True
        Me.lnk_DeleteTimecard.Text = "حذف اطلاعات تایم کارت"
        '
        'chk_Holiday
        '
        Me.chk_Holiday.AutoSize = True
        Me.chk_Holiday.Checked = True
        Me.chk_Holiday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Holiday.Location = New System.Drawing.Point(154, 92)
        Me.chk_Holiday.Name = "chk_Holiday"
        Me.chk_Holiday.Size = New System.Drawing.Size(186, 20)
        Me.chk_Holiday.TabIndex = 20
        Me.chk_Holiday.Text = "انتقال اطلاعات روزهای تعطیل"
        Me.chk_Holiday.UseVisualStyleBackColor = True
        '
        'llb_DeleteAll
        '
        Me.llb_DeleteAll.AutoSize = True
        Me.llb_DeleteAll.Location = New System.Drawing.Point(10, 128)
        Me.llb_DeleteAll.Name = "llb_DeleteAll"
        Me.llb_DeleteAll.Size = New System.Drawing.Size(126, 16)
        Me.llb_DeleteAll.TabIndex = 21
        Me.llb_DeleteAll.TabStop = True
        Me.llb_DeleteAll.Text = "خالی کردن پایگاه داده"
        '
        'ConvertDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(596, 471)
        Me.Name = "ConvertDB"
        Me.Text = "انتقال اطلاعات Ver 90-05-02"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_Addres As CS_Component.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txt_Log As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Btn_Brows As CS_Component.Btn
    Friend WithEvents Chk_EibForm As System.Windows.Forms.CheckBox
    Friend WithEvents chk_WrokForm As System.Windows.Forms.CheckBox
    Friend WithEvents lnk_DdeeteWorkForm As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_DeleteFormNaghs As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk_DeleteTimecard As System.Windows.Forms.LinkLabel
    Friend WithEvents chk_TimeCard As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Holiday As System.Windows.Forms.CheckBox
    Friend WithEvents llb_DeleteAll As System.Windows.Forms.LinkLabel
End Class
