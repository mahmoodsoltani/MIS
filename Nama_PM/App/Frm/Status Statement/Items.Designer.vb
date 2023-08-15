<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
    Inherits BaseForm_Layer

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txt_Code = New CS_Component.TextBox
        Me.Txt_Sub = New CS_Component.TextBox
        Me.Txt_Price = New CS_Component.TextBox
        Me.Txt_Total = New CS_Component.TextBox
        Me.cmb_Vahed = New VB_Component.ComboBox
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Cmb_Voltage = New VB_Component.ComboBox
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(361, 16)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(577, 16)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(469, 16)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(685, 461)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Controls.Controls.Add(Me.Cmb_Voltage)
        Me.gbx_Controls.Controls.Add(Me.Label7)
        Me.gbx_Controls.Controls.Add(Me.Button1)
        Me.gbx_Controls.Controls.Add(Me.cmb_Vahed)
        Me.gbx_Controls.Controls.Add(Me.Txt_Total)
        Me.gbx_Controls.Controls.Add(Me.Txt_Price)
        Me.gbx_Controls.Controls.Add(Me.Txt_Sub)
        Me.gbx_Controls.Controls.Add(Me.Txt_Code)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(12, 547)
        Me.gbx_Controls.Size = New System.Drawing.Size(685, 166)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Btn.Location = New System.Drawing.Point(12, 489)
        Me.gbx_Btn.Size = New System.Drawing.Size(685, 58)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(630, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "واحد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "موضوع سرویس"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "کدسرویس"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(626, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "تعداد کل"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "سهم هر گروه"
        '
        'Txt_Code
        '
        Me.Txt_Code.CheckExistValueInDb = False
        Me.Txt_Code.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Code.CurrencyUnit = "ریال"
        Me.Txt_Code.DefaultValue = ""
        Me.Txt_Code.FillWithMaxInDb = False
        Me.Txt_Code.IsRequired = False
        Me.Txt_Code.Location = New System.Drawing.Point(300, 33)
        Me.Txt_Code.MaxDecimalLength = 2
        Me.Txt_Code.Name = "Txt_Code"
        Me.Txt_Code.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Code.Size = New System.Drawing.Size(84, 23)
        Me.Txt_Code.SpellControl = Nothing
        Me.Txt_Code.TabIndex = 6
        Me.Txt_Code.Tag = "Sharh"
        Me.Txt_Code.Title = Nothing
        Me.Txt_Code.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.Txt_Code.UseForData = True
        Me.Txt_Code.ValidateCheckExistOnEdit = False
        Me.Txt_Code.Value = ""
        '
        'Txt_Sub
        '
        Me.Txt_Sub.CheckExistValueInDb = False
        Me.Txt_Sub.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Sub.CurrencyUnit = "ریال"
        Me.Txt_Sub.DefaultValue = ""
        Me.Txt_Sub.FillWithMaxInDb = False
        Me.Txt_Sub.IsRequired = False
        Me.Txt_Sub.Location = New System.Drawing.Point(8, 33)
        Me.Txt_Sub.MaxDecimalLength = 2
        Me.Txt_Sub.Name = "Txt_Sub"
        Me.Txt_Sub.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Sub.Size = New System.Drawing.Size(172, 23)
        Me.Txt_Sub.SpellControl = Nothing
        Me.Txt_Sub.TabIndex = 7
        Me.Txt_Sub.Tag = "Sharh"
        Me.Txt_Sub.Title = Nothing
        Me.Txt_Sub.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.Txt_Sub.UseForData = True
        Me.Txt_Sub.ValidateCheckExistOnEdit = False
        Me.Txt_Sub.Value = ""
        '
        'Txt_Price
        '
        Me.Txt_Price.CheckExistValueInDb = False
        Me.Txt_Price.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Price.CurrencyUnit = "ریال"
        Me.Txt_Price.DefaultValue = ""
        Me.Txt_Price.FillWithMaxInDb = False
        Me.Txt_Price.IsRequired = False
        Me.Txt_Price.Location = New System.Drawing.Point(475, 76)
        Me.Txt_Price.MaxDecimalLength = 2
        Me.Txt_Price.Name = "Txt_Price"
        Me.Txt_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Price.Size = New System.Drawing.Size(149, 23)
        Me.Txt_Price.SpellControl = Nothing
        Me.Txt_Price.TabIndex = 8
        Me.Txt_Price.Tag = "Sharh"
        Me.Txt_Price.Text = "0"
        Me.Txt_Price.Title = Nothing
        Me.Txt_Price.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.Txt_Price.UseForData = True
        Me.Txt_Price.ValidateCheckExistOnEdit = False
        Me.Txt_Price.Value = 0
        '
        'Txt_Total
        '
        Me.Txt_Total.CheckExistValueInDb = False
        Me.Txt_Total.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Total.CurrencyUnit = "ریال"
        Me.Txt_Total.DefaultValue = ""
        Me.Txt_Total.FillWithMaxInDb = False
        Me.Txt_Total.IsRequired = False
        Me.Txt_Total.Location = New System.Drawing.Point(475, 117)
        Me.Txt_Total.MaxDecimalLength = 2
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Total.Size = New System.Drawing.Size(149, 23)
        Me.Txt_Total.SpellControl = Nothing
        Me.Txt_Total.TabIndex = 9
        Me.Txt_Total.Tag = "Sharh"
        Me.Txt_Total.Text = "0"
        Me.Txt_Total.Title = Nothing
        Me.Txt_Total.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.Txt_Total.UseForData = True
        Me.Txt_Total.ValidateCheckExistOnEdit = False
        Me.Txt_Total.Value = 0
        '
        'cmb_Vahed
        '
        Me.cmb_Vahed.AllowDrop = True
        Me.cmb_Vahed.AutoComplete = True
        Me.cmb_Vahed.DisplayMember = "نام واحد"
        Me.cmb_Vahed.EnterStop = True
        Me.cmb_Vahed.FormattingEnabled = True
        Me.cmb_Vahed.IsRequired = False
        Me.cmb_Vahed.LimitedToList = False
        Me.cmb_Vahed.Location = New System.Drawing.Point(475, 33)
        Me.cmb_Vahed.Name = "cmb_Vahed"
        Me.cmb_Vahed.OpenOnFoucus = False
        Me.cmb_Vahed.Size = New System.Drawing.Size(149, 24)
        Me.cmb_Vahed.TabIndex = 11
        Me.cmb_Vahed.Tag = "Srl_Pm_vahed"
        Me.cmb_Vahed.ValueMember = "Srl"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(679, 439)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "انتخاب"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(626, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "قیمت"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(390, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "سطح ولتاژ"
        '
        'Cmb_Voltage
        '
        Me.Cmb_Voltage.AllowDrop = True
        Me.Cmb_Voltage.AutoComplete = True
        Me.Cmb_Voltage.DisplayMember = "نام واحد"
        Me.Cmb_Voltage.EnterStop = True
        Me.Cmb_Voltage.FormattingEnabled = True
        Me.Cmb_Voltage.IsRequired = False
        Me.Cmb_Voltage.LimitedToList = False
        Me.Cmb_Voltage.Location = New System.Drawing.Point(263, 76)
        Me.Cmb_Voltage.Name = "Cmb_Voltage"
        Me.Cmb_Voltage.OpenOnFoucus = False
        Me.Cmb_Voltage.Size = New System.Drawing.Size(121, 24)
        Me.Cmb_Voltage.TabIndex = 14
        Me.Cmb_Voltage.Tag = "Srl_Pm_vahed"
        Me.Cmb_Voltage.ValueMember = "Srl"
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 745)
        Me.Name = "Items"
        Me.Text = "ثبت آیتم های قرارداد"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Total As CS_Component.TextBox
    Friend WithEvents Txt_Price As CS_Component.TextBox
    Friend WithEvents Txt_Sub As CS_Component.TextBox
    Friend WithEvents Txt_Code As CS_Component.TextBox
    Friend WithEvents cmb_Vahed As VB_Component.ComboBox
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Voltage As VB_Component.ComboBox
End Class
