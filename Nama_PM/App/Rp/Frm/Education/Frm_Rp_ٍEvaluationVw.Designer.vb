<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_ٍEvaluationVw
    Inherits BaseForm

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Rb_Dore = New System.Windows.Forms.RadioButton
        Me.Rb_Teacher = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.rb_outside = New System.Windows.Forms.RadioButton
        Me.rb_outsideprovinence = New System.Windows.Forms.RadioButton
        Me.rb_insideProvinence = New System.Windows.Forms.RadioButton
        Me.Chk_Ashakhs = New System.Windows.Forms.CheckBox
        Me.cmb_Ashkhas = New VB_Component.ComboBox
        Me.PmAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.chk_Location = New System.Windows.Forms.CheckBox
        Me.chk_Teacher = New System.Windows.Forms.CheckBox
        Me.cmb_Teacher = New VB_Component.ComboBox
        Me.PmEduTeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Edu = New Nama_PM.Ds_Edu
        Me.cmb_Place = New VB_Component.ComboBox
        Me.PmEduDorePlaceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_Mahal = New System.Windows.Forms.CheckBox
        Me.cmb_Presenter = New VB_Component.ComboBox
        Me.PmEduDorePresenterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_Presenter = New System.Windows.Forms.CheckBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chk_allday = New System.Windows.Forms.CheckBox
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_PrintAll = New CS_Component.Btn
        Me.lbl_Record = New System.Windows.Forms.Label
        Me.Btn_Search = New CS_Component.Btn
        Me.Pm_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
        Me.Pm_Edu_DorePlaceTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DorePlaceTableAdapter
        Me.Pm_Edu_DorePresenterTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DorePresenterTableAdapter
        Me.Pm_Edu_TeacherTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_TeacherTableAdapter
        Me.RpDoreEvaluationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_DoreEvaluationTableAdapter = New Nama_PM.Ds_EduTableAdapters.Rp_DoreEvaluationTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduTeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDorePlaceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDorePresenterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RpDoreEvaluationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rb_outside)
        Me.GroupBox1.Controls.Add(Me.rb_outsideprovinence)
        Me.GroupBox1.Controls.Add(Me.rb_insideProvinence)
        Me.GroupBox1.Controls.Add(Me.Chk_Ashakhs)
        Me.GroupBox1.Controls.Add(Me.cmb_Ashkhas)
        Me.GroupBox1.Controls.Add(Me.chk_Location)
        Me.GroupBox1.Controls.Add(Me.chk_Teacher)
        Me.GroupBox1.Controls.Add(Me.cmb_Teacher)
        Me.GroupBox1.Controls.Add(Me.cmb_Place)
        Me.GroupBox1.Controls.Add(Me.chk_Mahal)
        Me.GroupBox1.Controls.Add(Me.cmb_Presenter)
        Me.GroupBox1.Controls.Add(Me.chk_Presenter)
        Me.GroupBox1.Controls.Add(Me.txt_ToDate)
        Me.GroupBox1.Controls.Add(Me.txt_FromDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chk_allday)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(987, 585)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Rb_Dore)
        Me.Panel2.Controls.Add(Me.Rb_Teacher)
        Me.Panel2.Location = New System.Drawing.Point(660, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 34)
        Me.Panel2.TabIndex = 199
        '
        'Rb_Dore
        '
        Me.Rb_Dore.AutoSize = True
        Me.Rb_Dore.Checked = True
        Me.Rb_Dore.Location = New System.Drawing.Point(131, 9)
        Me.Rb_Dore.Name = "Rb_Dore"
        Me.Rb_Dore.Size = New System.Drawing.Size(51, 22)
        Me.Rb_Dore.TabIndex = 197
        Me.Rb_Dore.TabStop = True
        Me.Rb_Dore.Text = "دوره"
        Me.Rb_Dore.UseVisualStyleBackColor = True
        '
        'Rb_Teacher
        '
        Me.Rb_Teacher.AutoSize = True
        Me.Rb_Teacher.Location = New System.Drawing.Point(28, 9)
        Me.Rb_Teacher.Name = "Rb_Teacher"
        Me.Rb_Teacher.Size = New System.Drawing.Size(61, 22)
        Me.Rb_Teacher.TabIndex = 197
        Me.Rb_Teacher.Text = "استاد"
        Me.Rb_Teacher.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(915, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "بر اساس"
        '
        'rb_outside
        '
        Me.rb_outside.AutoSize = True
        Me.rb_outside.Location = New System.Drawing.Point(517, 187)
        Me.rb_outside.Name = "rb_outside"
        Me.rb_outside.Size = New System.Drawing.Size(94, 22)
        Me.rb_outside.TabIndex = 196
        Me.rb_outside.Text = "خارج کشور"
        Me.rb_outside.UseVisualStyleBackColor = True
        '
        'rb_outsideprovinence
        '
        Me.rb_outsideprovinence.AutoSize = True
        Me.rb_outsideprovinence.Location = New System.Drawing.Point(635, 187)
        Me.rb_outsideprovinence.Name = "rb_outsideprovinence"
        Me.rb_outsideprovinence.Size = New System.Drawing.Size(97, 22)
        Me.rb_outsideprovinence.TabIndex = 196
        Me.rb_outsideprovinence.Text = "خارج استان"
        Me.rb_outsideprovinence.UseVisualStyleBackColor = True
        '
        'rb_insideProvinence
        '
        Me.rb_insideProvinence.AutoSize = True
        Me.rb_insideProvinence.Checked = True
        Me.rb_insideProvinence.Location = New System.Drawing.Point(753, 187)
        Me.rb_insideProvinence.Name = "rb_insideProvinence"
        Me.rb_insideProvinence.Size = New System.Drawing.Size(97, 22)
        Me.rb_insideProvinence.TabIndex = 196
        Me.rb_insideProvinence.TabStop = True
        Me.rb_insideProvinence.Text = "درون استان"
        Me.rb_insideProvinence.UseVisualStyleBackColor = True
        '
        'Chk_Ashakhs
        '
        Me.Chk_Ashakhs.AutoSize = True
        Me.Chk_Ashakhs.Checked = True
        Me.Chk_Ashakhs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Ashakhs.Location = New System.Drawing.Point(469, 145)
        Me.Chk_Ashakhs.Name = "Chk_Ashakhs"
        Me.Chk_Ashakhs.Size = New System.Drawing.Size(68, 22)
        Me.Chk_Ashakhs.TabIndex = 195
        Me.Chk_Ashakhs.Text = "نام فرد"
        Me.Chk_Ashakhs.UseVisualStyleBackColor = True
        '
        'cmb_Ashkhas
        '
        Me.cmb_Ashkhas.AutoComplete = True
        Me.cmb_Ashkhas.DataSource = Me.PmAshkhasBindingSource
        Me.cmb_Ashkhas.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Ashkhas.Enabled = False
        Me.cmb_Ashkhas.EnterStop = True
        Me.cmb_Ashkhas.FormattingEnabled = True
        Me.cmb_Ashkhas.IsRequired = False
        Me.cmb_Ashkhas.LimitedToList = True
        Me.cmb_Ashkhas.Location = New System.Drawing.Point(119, 145)
        Me.cmb_Ashkhas.Name = "cmb_Ashkhas"
        Me.cmb_Ashkhas.OpenOnFoucus = True
        Me.cmb_Ashkhas.Size = New System.Drawing.Size(265, 26)
        Me.cmb_Ashkhas.TabIndex = 194
        Me.cmb_Ashkhas.ValueMember = "Srl"
        '
        'PmAshkhasBindingSource
        '
        Me.PmAshkhasBindingSource.DataMember = "Pm_Ashkhas"
        Me.PmAshkhasBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_Location
        '
        Me.chk_Location.AutoSize = True
        Me.chk_Location.Checked = True
        Me.chk_Location.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Location.Location = New System.Drawing.Point(902, 187)
        Me.chk_Location.Name = "chk_Location"
        Me.chk_Location.Size = New System.Drawing.Size(74, 22)
        Me.chk_Location.TabIndex = 195
        Me.chk_Location.Text = "موقعیت"
        Me.chk_Location.UseVisualStyleBackColor = True
        '
        'chk_Teacher
        '
        Me.chk_Teacher.AutoSize = True
        Me.chk_Teacher.Checked = True
        Me.chk_Teacher.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Teacher.Location = New System.Drawing.Point(881, 145)
        Me.chk_Teacher.Name = "chk_Teacher"
        Me.chk_Teacher.Size = New System.Drawing.Size(96, 22)
        Me.chk_Teacher.TabIndex = 195
        Me.chk_Teacher.Text = "مدرس دوره"
        Me.chk_Teacher.UseVisualStyleBackColor = True
        '
        'cmb_Teacher
        '
        Me.cmb_Teacher.AutoComplete = True
        Me.cmb_Teacher.DataSource = Me.PmEduTeacherBindingSource
        Me.cmb_Teacher.DisplayMember = "نا م و نام خانوادگی"
        Me.cmb_Teacher.Enabled = False
        Me.cmb_Teacher.EnterStop = True
        Me.cmb_Teacher.FormattingEnabled = True
        Me.cmb_Teacher.IsRequired = False
        Me.cmb_Teacher.LimitedToList = True
        Me.cmb_Teacher.Location = New System.Drawing.Point(580, 145)
        Me.cmb_Teacher.Name = "cmb_Teacher"
        Me.cmb_Teacher.OpenOnFoucus = True
        Me.cmb_Teacher.Size = New System.Drawing.Size(267, 26)
        Me.cmb_Teacher.TabIndex = 194
        Me.cmb_Teacher.ValueMember = "Srl"
        '
        'PmEduTeacherBindingSource
        '
        Me.PmEduTeacherBindingSource.DataMember = "Pm_Edu_Teacher"
        Me.PmEduTeacherBindingSource.DataSource = Me.Ds_Edu
        '
        'Ds_Edu
        '
        Me.Ds_Edu.DataSetName = "Ds_Edu"
        Me.Ds_Edu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_Place
        '
        Me.cmb_Place.AutoComplete = True
        Me.cmb_Place.DataSource = Me.PmEduDorePlaceBindingSource
        Me.cmb_Place.DisplayMember = "نام"
        Me.cmb_Place.Enabled = False
        Me.cmb_Place.EnterStop = True
        Me.cmb_Place.FormattingEnabled = True
        Me.cmb_Place.IsRequired = False
        Me.cmb_Place.LimitedToList = True
        Me.cmb_Place.Location = New System.Drawing.Point(580, 108)
        Me.cmb_Place.Name = "cmb_Place"
        Me.cmb_Place.OpenOnFoucus = True
        Me.cmb_Place.Size = New System.Drawing.Size(265, 26)
        Me.cmb_Place.TabIndex = 186
        Me.cmb_Place.ValueMember = "Srl"
        '
        'PmEduDorePlaceBindingSource
        '
        Me.PmEduDorePlaceBindingSource.DataMember = "Pm_Edu_DorePlace"
        Me.PmEduDorePlaceBindingSource.DataSource = Me.Ds_Edu
        '
        'chk_Mahal
        '
        Me.chk_Mahal.AutoSize = True
        Me.chk_Mahal.Checked = True
        Me.chk_Mahal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Mahal.Location = New System.Drawing.Point(871, 108)
        Me.chk_Mahal.Name = "chk_Mahal"
        Me.chk_Mahal.Size = New System.Drawing.Size(106, 22)
        Me.chk_Mahal.TabIndex = 185
        Me.chk_Mahal.Text = "محل برگزاری"
        Me.chk_Mahal.UseVisualStyleBackColor = True
        '
        'cmb_Presenter
        '
        Me.cmb_Presenter.AutoComplete = True
        Me.cmb_Presenter.DataSource = Me.PmEduDorePresenterBindingSource
        Me.cmb_Presenter.DisplayMember = "نام"
        Me.cmb_Presenter.Enabled = False
        Me.cmb_Presenter.EnterStop = True
        Me.cmb_Presenter.FormattingEnabled = True
        Me.cmb_Presenter.IsRequired = False
        Me.cmb_Presenter.LimitedToList = True
        Me.cmb_Presenter.Location = New System.Drawing.Point(119, 108)
        Me.cmb_Presenter.Name = "cmb_Presenter"
        Me.cmb_Presenter.OpenOnFoucus = True
        Me.cmb_Presenter.Size = New System.Drawing.Size(265, 26)
        Me.cmb_Presenter.TabIndex = 186
        Me.cmb_Presenter.ValueMember = "Srl"
        '
        'PmEduDorePresenterBindingSource
        '
        Me.PmEduDorePresenterBindingSource.DataMember = "Pm_Edu_DorePresenter"
        Me.PmEduDorePresenterBindingSource.DataSource = Me.Ds_Edu
        '
        'chk_Presenter
        '
        Me.chk_Presenter.AutoSize = True
        Me.chk_Presenter.Checked = True
        Me.chk_Presenter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Presenter.Location = New System.Drawing.Point(390, 110)
        Me.chk_Presenter.Name = "chk_Presenter"
        Me.chk_Presenter.Size = New System.Drawing.Size(147, 22)
        Me.chk_Presenter.TabIndex = 185
        Me.chk_Presenter.Text = "سازمان برگزار کننده"
        Me.chk_Presenter.UseVisualStyleBackColor = True
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.Enabled = False
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(354, 63)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(154, 25)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 179
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
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.Enabled = False
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(691, 66)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(154, 25)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 178
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
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(517, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 182
        Me.Label2.Text = "تا تاریخ"
        '
        'chk_allday
        '
        Me.chk_allday.AutoSize = True
        Me.chk_allday.Checked = True
        Me.chk_allday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_allday.Location = New System.Drawing.Point(858, 66)
        Me.chk_allday.Name = "chk_allday"
        Me.chk_allday.Size = New System.Drawing.Size(119, 22)
        Me.chk_allday.TabIndex = 177
        Me.chk_allday.Text = "تاریخ برگزاری از"
        Me.chk_allday.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.0!)
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(981, 325)
        Me.DataGridView1.TabIndex = 176
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Btn_PrintAll)
        Me.Panel1.Controls.Add(Me.lbl_Record)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Location = New System.Drawing.Point(10, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 36)
        Me.Panel1.TabIndex = 175
        '
        'Btn_PrintAll
        '
        Me.Btn_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.Btn_PrintAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_PrintAll.HeaderText = "چاپ"
        Me.Btn_PrintAll.Location = New System.Drawing.Point(722, 3)
        Me.Btn_PrintAll.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Btn_PrintAll.Name = "Btn_PrintAll"
        Me.Btn_PrintAll.Size = New System.Drawing.Size(103, 29)
        Me.Btn_PrintAll.TabIndex = 162
        '
        'lbl_Record
        '
        Me.lbl_Record.AutoSize = True
        Me.lbl_Record.Location = New System.Drawing.Point(99, 8)
        Me.lbl_Record.Name = "lbl_Record"
        Me.lbl_Record.Size = New System.Drawing.Size(74, 18)
        Me.lbl_Record.TabIndex = 161
        Me.lbl_Record.Text = "تعداد رکورد"
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.HeaderText = "جستجو"
        Me.Btn_Search.Location = New System.Drawing.Point(835, 3)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(115, 29)
        Me.Btn_Search.TabIndex = 0
        '
        'Pm_AshkhasTableAdapter
        '
        Me.Pm_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'Pm_Edu_DorePlaceTableAdapter
        '
        Me.Pm_Edu_DorePlaceTableAdapter.ClearBeforeFill = True
        '
        'Pm_Edu_DorePresenterTableAdapter
        '
        Me.Pm_Edu_DorePresenterTableAdapter.ClearBeforeFill = True
        '
        'Pm_Edu_TeacherTableAdapter
        '
        Me.Pm_Edu_TeacherTableAdapter.ClearBeforeFill = True
        '
        'RpDoreEvaluationBindingSource
        '
        Me.RpDoreEvaluationBindingSource.DataMember = "Rp_DoreEvaluation"
        Me.RpDoreEvaluationBindingSource.DataSource = Me.Ds_Edu
        '
        'Rp_DoreEvaluationTableAdapter
        '
        Me.Rp_DoreEvaluationTableAdapter.ClearBeforeFill = True
        '
        'Frm_Rp_ٍEvaluationVw
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1005, 655)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Name = "Frm_Rp_ٍEvaluationVw"
        Me.Text = "گزارش دوره"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduTeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDorePlaceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDorePresenterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RpDoreEvaluationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_allday As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Record As System.Windows.Forms.Label
    Friend WithEvents Btn_Search As CS_Component.Btn
    Friend WithEvents cmb_Place As VB_Component.ComboBox
    Friend WithEvents chk_Mahal As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Presenter As VB_Component.ComboBox
    Friend WithEvents chk_Presenter As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Teacher As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Teacher As VB_Component.ComboBox
    Friend WithEvents Btn_PrintAll As CS_Component.Btn
    Friend WithEvents Chk_Ashakhs As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Ashkhas As VB_Component.ComboBox
    Friend WithEvents Ds_Edu As Nama_PM.Ds_Edu
    Friend WithEvents PmEduDorePlaceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DorePlaceTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DorePlaceTableAdapter
    Friend WithEvents PmEduDorePresenterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DorePresenterTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DorePresenterTableAdapter
    Friend WithEvents PmEduTeacherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_TeacherTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_TeacherTableAdapter
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents PmAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents rb_outside As System.Windows.Forms.RadioButton
    Friend WithEvents rb_outsideprovinence As System.Windows.Forms.RadioButton
    Friend WithEvents rb_insideProvinence As System.Windows.Forms.RadioButton
    Friend WithEvents chk_Location As System.Windows.Forms.CheckBox
    Friend WithEvents Rb_Teacher As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Dore As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RpDoreEvaluationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_DoreEvaluationTableAdapter As Nama_PM.Ds_EduTableAdapters.Rp_DoreEvaluationTableAdapter
End Class
