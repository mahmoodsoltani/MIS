<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WorkForm_kargozini
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.chk_Group = New System.Windows.Forms.CheckBox
        Me.PMPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_mahalFaliat = New VB_Component.ComboBox
        Me.PMPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_AllVahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HafteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmWorkDisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmHazineCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_MahalFaliat = New System.Windows.Forms.CheckBox
        Me.Cmb_Group = New VB_Component.ComboBox
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chk_AllVahed = New System.Windows.Forms.CheckBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chk_allday = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_Record = New System.Windows.Forms.Label
        Me.Btn_ٍExcel = New CS_Component.Btn
        Me.Btn_Search = New CS_Component.Btn
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.RpWorkFormKargoziniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_Ozv = New System.Windows.Forms.CheckBox
        Me.cmb_ozv = New VB_Component.ComboBox
        Me.AccAshkhasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PMPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HafteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmWorkDisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpWorkFormKargoziniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 476)
        Me.gbx_Buttons.Size = New System.Drawing.Size(102, 18)
        Me.gbx_Buttons.Visible = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(6, -9)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(-2, -12)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Fields.Controls.Add(Me.chk_Ozv)
        Me.gbx_Fields.Controls.Add(Me.cmb_ozv)
        Me.gbx_Fields.Controls.Add(Me.DataGridView1)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.chk_Group)
        Me.gbx_Fields.Controls.Add(Me.cmb_mahalFaliat)
        Me.gbx_Fields.Controls.Add(Me.cmb_AllVahed)
        Me.gbx_Fields.Controls.Add(Me.chk_MahalFaliat)
        Me.gbx_Fields.Controls.Add(Me.Cmb_Group)
        Me.gbx_Fields.Controls.Add(Me.Chk_AllVahed)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.chk_allday)
        Me.gbx_Fields.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbx_Fields.Location = New System.Drawing.Point(6, 35)
        Me.gbx_Fields.Size = New System.Drawing.Size(833, 467)
        Me.gbx_Fields.TabIndex = 0
        '
        'chk_Group
        '
        Me.chk_Group.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Group.AutoSize = True
        Me.chk_Group.Checked = True
        Me.chk_Group.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Group.Location = New System.Drawing.Point(405, 55)
        Me.chk_Group.Name = "chk_Group"
        Me.chk_Group.Size = New System.Drawing.Size(68, 22)
        Me.chk_Group.TabIndex = 8
        Me.chk_Group.Text = "گروهها"
        Me.chk_Group.UseVisualStyleBackColor = True
        '
        'PMPostBindingSource1
        '
        Me.PMPostBindingSource1.DataMember = "PM_Post"
        '
        'cmb_mahalFaliat
        '
        Me.cmb_mahalFaliat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_mahalFaliat.AutoComplete = True
        Me.cmb_mahalFaliat.DataSource = Me.PMPostBindingSource
        Me.cmb_mahalFaliat.DisplayMember = "نام پست"
        Me.cmb_mahalFaliat.Enabled = False
        Me.cmb_mahalFaliat.EnterStop = True
        Me.cmb_mahalFaliat.FormattingEnabled = True
        Me.cmb_mahalFaliat.IsRequired = False
        Me.cmb_mahalFaliat.LimitedToList = True
        Me.cmb_mahalFaliat.Location = New System.Drawing.Point(510, 21)
        Me.cmb_mahalFaliat.Name = "cmb_mahalFaliat"
        Me.cmb_mahalFaliat.OpenOnFoucus = True
        Me.cmb_mahalFaliat.Size = New System.Drawing.Size(170, 26)
        Me.cmb_mahalFaliat.TabIndex = 1
        Me.cmb_mahalFaliat.ValueMember = "Srl"
        '
        'PMPostBindingSource
        '
        Me.PMPostBindingSource.DataMember = "PM_Post"
        '
        'cmb_AllVahed
        '
        Me.cmb_AllVahed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_AllVahed.AutoComplete = True
        Me.cmb_AllVahed.DataSource = Me.PmVahedBindingSource
        Me.cmb_AllVahed.DisplayMember = "نام واحد"
        Me.cmb_AllVahed.Enabled = False
        Me.cmb_AllVahed.EnterStop = True
        Me.cmb_AllVahed.FormattingEnabled = True
        Me.cmb_AllVahed.IsRequired = False
        Me.cmb_AllVahed.LimitedToList = True
        Me.cmb_AllVahed.Location = New System.Drawing.Point(214, 21)
        Me.cmb_AllVahed.Name = "cmb_AllVahed"
        Me.cmb_AllVahed.OpenOnFoucus = True
        Me.cmb_AllVahed.Size = New System.Drawing.Size(170, 26)
        Me.cmb_AllVahed.TabIndex = 3
        Me.cmb_AllVahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        '
        'HafteBindingSource
        '
        Me.HafteBindingSource.DataMember = "Hafte"
        '
        'PmWorkDisBindingSource
        '
        Me.PmWorkDisBindingSource.DataMember = "Pm_WorkDis"
        '
        'PmHazineCodeBindingSource
        '
        Me.PmHazineCodeBindingSource.DataMember = "Pm_HazineCode"
        '
        'AccAshkhasBindingSource
        '
        Me.AccAshkhasBindingSource.DataMember = "Acc_Ashkhas"
        '
        'chk_MahalFaliat
        '
        Me.chk_MahalFaliat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_MahalFaliat.AutoSize = True
        Me.chk_MahalFaliat.Checked = True
        Me.chk_MahalFaliat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_MahalFaliat.Location = New System.Drawing.Point(698, 25)
        Me.chk_MahalFaliat.Name = "chk_MahalFaliat"
        Me.chk_MahalFaliat.Size = New System.Drawing.Size(101, 22)
        Me.chk_MahalFaliat.TabIndex = 0
        Me.chk_MahalFaliat.Text = "محل فعالیت"
        Me.chk_MahalFaliat.UseVisualStyleBackColor = True
        '
        'Cmb_Group
        '
        Me.Cmb_Group.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmb_Group.AutoComplete = True
        Me.Cmb_Group.DataSource = Me.PmGroupBindingSource
        Me.Cmb_Group.DisplayMember = "نام"
        Me.Cmb_Group.Enabled = False
        Me.Cmb_Group.EnterStop = True
        Me.Cmb_Group.FormattingEnabled = True
        Me.Cmb_Group.IsRequired = False
        Me.Cmb_Group.LimitedToList = True
        Me.Cmb_Group.Location = New System.Drawing.Point(214, 53)
        Me.Cmb_Group.Name = "Cmb_Group"
        Me.Cmb_Group.OpenOnFoucus = True
        Me.Cmb_Group.Size = New System.Drawing.Size(170, 26)
        Me.Cmb_Group.TabIndex = 9
        Me.Cmb_Group.ValueMember = "Srl"
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        '
        'Chk_AllVahed
        '
        Me.Chk_AllVahed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Chk_AllVahed.AutoSize = True
        Me.Chk_AllVahed.Checked = True
        Me.Chk_AllVahed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_AllVahed.Location = New System.Drawing.Point(404, 23)
        Me.Chk_AllVahed.Name = "Chk_AllVahed"
        Me.Chk_AllVahed.Size = New System.Drawing.Size(69, 22)
        Me.Chk_AllVahed.TabIndex = 2
        Me.Chk_AllVahed.Text = "واحدها"
        Me.Chk_AllVahed.UseVisualStyleBackColor = True
        '
        'txt_ToDate
        '
        Me.txt_ToDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.Enabled = False
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(214, 85)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(154, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 16
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'txt_FromDate
        '
        Me.txt_FromDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.Enabled = False
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(511, 85)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(154, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 15
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(460, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 18)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "تا"
        '
        'chk_allday
        '
        Me.chk_allday.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_allday.AutoSize = True
        Me.chk_allday.Checked = True
        Me.chk_allday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_allday.Location = New System.Drawing.Point(730, 89)
        Me.chk_allday.Name = "chk_allday"
        Me.chk_allday.Size = New System.Drawing.Size(69, 22)
        Me.chk_allday.TabIndex = 14
        Me.chk_allday.Text = "تاریخ از"
        Me.chk_allday.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_Record)
        Me.Panel1.Controls.Add(Me.Btn_ٍExcel)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Location = New System.Drawing.Point(19, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 36)
        Me.Panel1.TabIndex = 21
        '
        'lbl_Record
        '
        Me.lbl_Record.AutoSize = True
        Me.lbl_Record.Location = New System.Drawing.Point(30, 12)
        Me.lbl_Record.Name = "lbl_Record"
        Me.lbl_Record.Size = New System.Drawing.Size(74, 18)
        Me.lbl_Record.TabIndex = 161
        Me.lbl_Record.Text = "تعداد رکورد"
        '
        'Btn_ٍExcel
        '
        Me.Btn_ٍExcel.BackColor = System.Drawing.Color.Transparent
        Me.Btn_ٍExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ٍExcel.HeaderText = "خروجی اکسل"
        Me.Btn_ٍExcel.Location = New System.Drawing.Point(547, 4)
        Me.Btn_ٍExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_ٍExcel.Name = "Btn_ٍExcel"
        Me.Btn_ٍExcel.Size = New System.Drawing.Size(114, 26)
        Me.Btn_ٍExcel.TabIndex = 160
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.HeaderText = "جستجو"
        Me.Btn_Search.Location = New System.Drawing.Point(669, 4)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(93, 26)
        Me.Btn_Search.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.RpWorkFormKargoziniBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(827, 301)
        Me.DataGridView1.TabIndex = 167
        '
        'RpWorkFormKargoziniBindingSource
        '
        Me.RpWorkFormKargoziniBindingSource.DataMember = "Rp_WorkForm_Kargozini"
        '
        'chk_Ozv
        '
        Me.chk_Ozv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Ozv.AutoSize = True
        Me.chk_Ozv.Checked = True
        Me.chk_Ozv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Ozv.Location = New System.Drawing.Point(743, 57)
        Me.chk_Ozv.Name = "chk_Ozv"
        Me.chk_Ozv.Size = New System.Drawing.Size(56, 22)
        Me.chk_Ozv.TabIndex = 168
        Me.chk_Ozv.Text = "عضو"
        Me.chk_Ozv.UseVisualStyleBackColor = True
        '
        'cmb_ozv
        '
        Me.cmb_ozv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_ozv.AutoComplete = True
        Me.cmb_ozv.DataSource = Me.AccAshkhasBindingSource1
        Me.cmb_ozv.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_ozv.Enabled = False
        Me.cmb_ozv.EnterStop = True
        Me.cmb_ozv.FormattingEnabled = True
        Me.cmb_ozv.IsRequired = False
        Me.cmb_ozv.LimitedToList = True
        Me.cmb_ozv.Location = New System.Drawing.Point(511, 55)
        Me.cmb_ozv.Name = "cmb_ozv"
        Me.cmb_ozv.OpenOnFoucus = True
        Me.cmb_ozv.Size = New System.Drawing.Size(170, 26)
        Me.cmb_ozv.TabIndex = 169
        Me.cmb_ozv.ValueMember = "Srl"
        '
        'AccAshkhasBindingSource1
        '
        Me.AccAshkhasBindingSource1.DataMember = "Acc_Ashkhas"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Report"
        Me.SaveFileDialog1.Filter = "*.xls|*.xlsx"
        '
        'Frm_WorkForm_kargozini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(846, 531)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_WorkForm_kargozini"
        Me.Text = "گزارش فرم کار  برای کارآموزی"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PMPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HafteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmWorkDisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpWorkFormKargoziniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_Group As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_mahalFaliat As VB_Component.ComboBox
    Friend WithEvents cmb_AllVahed As VB_Component.ComboBox
    Friend WithEvents chk_MahalFaliat As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_Group As VB_Component.ComboBox
    Friend WithEvents Chk_AllVahed As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_allday As System.Windows.Forms.CheckBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PM_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.PM_PostTableAdapter
    Friend WithEvents PMPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Btn_Search As CS_Component.Btn
    Friend WithEvents PmWorkDisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_WorkDisTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_WorkDisTableAdapter
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents PmHazineCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_HazineCodeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents chk_Ozv As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_ozv As VB_Component.ComboBox
    Friend WithEvents Btn_ٍExcel As CS_Component.Btn
    Friend WithEvents AccAshkhasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HafteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HafteTableAdapter As Nama_PM.Ds_PmTableAdapters.HafteTableAdapter
    Friend WithEvents تعدادنفراتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نفرساعتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_Record As System.Windows.Forms.Label
    Friend WithEvents Ds_Rp1 As Nama_PM.Ds_Rp
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RpWorkFormKargoziniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_WorkForm_KargoziniTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_WorkForm_KargoziniTableAdapter
    Friend WithEvents پرسنلیکدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامونامخانوادگیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مبداحرکتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلفعالیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساعتشروعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساعتپایانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مسافتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
