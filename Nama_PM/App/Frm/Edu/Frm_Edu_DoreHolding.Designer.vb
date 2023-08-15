<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Edu_DoreHolding
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
        Me.cmb_Dore = New VB_Component.ComboBox
        Me.PmEduDoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Edu = New Nama_PM.Ds_Edu
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_Presenter = New VB_Component.ComboBox
        Me.PmEduDorePresenterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_Place = New VB_Component.ComboBox
        Me.PmEduDorePlaceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_BeginDate = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_Length = New CS_Component.TextBox
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.PmEduDoreHoldingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox2 = New CS_Component.TextBox
        Me.cmb_Teacher = New VB_Component.ComboBox
        Me.PmEduTeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox5 = New CS_Component.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox4 = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox3 = New CS_Component.TextBox
        Me.insideProvenance = New System.Windows.Forms.RadioButton
        Me.OutsideProvenance = New System.Windows.Forms.RadioButton
        Me.OutsideCountry = New System.Windows.Forms.RadioButton
        Me.Pm_Edu_DorePlaceTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DorePlaceTableAdapter
        Me.Pm_Edu_DorePresenterTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DorePresenterTableAdapter
        Me.Pm_Edu_DoreTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreTableAdapter
        Me.Pm_Edu_DoreHoldingTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreHoldingTableAdapter
        Me.Pm_Edu_TeacherTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_TeacherTableAdapter
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox1 = New CS_Component.TextBox
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عنوانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شروعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پایانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.جلسات = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مدتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مدرسDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.برگزارکنندهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.هزینهآموزشیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.هزینهرفاهیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.هزینهمتفرقهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.هزینهکلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مکانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.PmEduDoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDorePresenterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDorePlaceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDoreHoldingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduTeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(784, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(1031, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(907, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(1154, 371)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.OutsideCountry)
        Me.gbx_Controls.Controls.Add(Me.OutsideProvenance)
        Me.gbx_Controls.Controls.Add(Me.insideProvenance)
        Me.gbx_Controls.Controls.Add(Me.GroupBox1)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.txt_Length)
        Me.gbx_Controls.Controls.Add(Me.Label12)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.TextBox2)
        Me.gbx_Controls.Controls.Add(Me.txt_BeginDate)
        Me.gbx_Controls.Controls.Add(Me.Label7)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.cmb_Teacher)
        Me.gbx_Controls.Controls.Add(Me.cmb_Place)
        Me.gbx_Controls.Controls.Add(Me.cmb_Presenter)
        Me.gbx_Controls.Controls.Add(Me.cmb_Dore)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 477)
        Me.gbx_Controls.Size = New System.Drawing.Size(1154, 197)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(13, 417)
        Me.gbx_Btn.Size = New System.Drawing.Size(1154, 60)
        '
        'cmb_Dore
        '
        Me.cmb_Dore.AutoComplete = True
        Me.cmb_Dore.DataSource = Me.PmEduDoreBindingSource
        Me.cmb_Dore.DisplayMember = "عنوان"
        Me.cmb_Dore.EnterStop = True
        Me.cmb_Dore.FormattingEnabled = True
        Me.cmb_Dore.IsRequired = True
        Me.cmb_Dore.LimitedToList = True
        Me.cmb_Dore.Location = New System.Drawing.Point(282, 21)
        Me.cmb_Dore.Name = "cmb_Dore"
        Me.cmb_Dore.OpenOnFoucus = False
        Me.cmb_Dore.Size = New System.Drawing.Size(683, 26)
        Me.cmb_Dore.TabIndex = 0
        Me.cmb_Dore.Tag = "Srl_Dore"
        Me.cmb_Dore.ValueMember = "Srl"
        '
        'PmEduDoreBindingSource
        '
        Me.PmEduDoreBindingSource.DataMember = "Pm_Edu_Dore"
        Me.PmEduDoreBindingSource.DataSource = Me.Ds_Edu
        '
        'Ds_Edu
        '
        Me.Ds_Edu.DataSetName = "Ds_Edu"
        Me.Ds_Edu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1018, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "نام دوره"
        '
        'cmb_Presenter
        '
        Me.cmb_Presenter.AutoComplete = True
        Me.cmb_Presenter.DataSource = Me.PmEduDorePresenterBindingSource
        Me.cmb_Presenter.DisplayMember = "نام"
        Me.cmb_Presenter.EnterStop = True
        Me.cmb_Presenter.FormattingEnabled = True
        Me.cmb_Presenter.IsRequired = True
        Me.cmb_Presenter.LimitedToList = True
        Me.cmb_Presenter.Location = New System.Drawing.Point(282, 95)
        Me.cmb_Presenter.Name = "cmb_Presenter"
        Me.cmb_Presenter.OpenOnFoucus = False
        Me.cmb_Presenter.Size = New System.Drawing.Size(322, 26)
        Me.cmb_Presenter.TabIndex = 5
        Me.cmb_Presenter.Tag = "Srl_Presenter"
        Me.cmb_Presenter.ValueMember = "Srl"
        '
        'PmEduDorePresenterBindingSource
        '
        Me.PmEduDorePresenterBindingSource.DataMember = "Pm_Edu_DorePresenter"
        Me.PmEduDorePresenterBindingSource.DataSource = Me.Ds_Edu
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(610, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "برگزار کننده"
        '
        'cmb_Place
        '
        Me.cmb_Place.AutoComplete = True
        Me.cmb_Place.DataSource = Me.PmEduDorePlaceBindingSource
        Me.cmb_Place.DisplayMember = "نام"
        Me.cmb_Place.EnterStop = True
        Me.cmb_Place.FormattingEnabled = True
        Me.cmb_Place.IsRequired = True
        Me.cmb_Place.LimitedToList = True
        Me.cmb_Place.Location = New System.Drawing.Point(282, 56)
        Me.cmb_Place.Name = "cmb_Place"
        Me.cmb_Place.OpenOnFoucus = False
        Me.cmb_Place.Size = New System.Drawing.Size(683, 26)
        Me.cmb_Place.TabIndex = 4
        Me.cmb_Place.Tag = "Srl_Place"
        Me.cmb_Place.ValueMember = "Srl"
        '
        'PmEduDorePlaceBindingSource
        '
        Me.PmEduDorePlaceBindingSource.DataMember = "Pm_Edu_DorePlace"
        Me.PmEduDorePlaceBindingSource.DataSource = Me.Ds_Edu
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(986, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "محل برگزاری"
        '
        'txt_BeginDate
        '
        Me.txt_BeginDate.CheckExistValueInDb = False
        Me.txt_BeginDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BeginDate.CurrencyUnit = "ریال"
        Me.txt_BeginDate.DefaultValue = ""
        Me.txt_BeginDate.FillWithMaxInDb = False
        Me.txt_BeginDate.IsRequired = True
        Me.txt_BeginDate.Location = New System.Drawing.Point(15, 25)
        Me.txt_BeginDate.MaxDecimalLength = 2
        Me.txt_BeginDate.Name = "txt_BeginDate"
        Me.txt_BeginDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_BeginDate.Size = New System.Drawing.Size(135, 26)
        Me.txt_BeginDate.SpellControl = Nothing
        Me.txt_BeginDate.TabIndex = 1
        Me.txt_BeginDate.TabStop = False
        Me.txt_BeginDate.Tag = "Startdate"
        Me.txt_BeginDate.Title = Nothing
        Me.txt_BeginDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_BeginDate.UseForData = True
        Me.txt_BeginDate.ValidateCheckExistOnEdit = False
        Me.txt_BeginDate.Value = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "تاریخ شروع"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1007, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "مدت دوره"
        '
        'txt_Length
        '
        Me.txt_Length.CheckExistValueInDb = False
        Me.txt_Length.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Length.CurrencyUnit = "ریال"
        Me.txt_Length.DefaultValue = "0"
        Me.txt_Length.FillWithMaxInDb = False
        Me.txt_Length.IsRequired = True
        Me.txt_Length.Location = New System.Drawing.Point(911, 94)
        Me.txt_Length.MaxDecimalLength = 2
        Me.txt_Length.Name = "txt_Length"
        Me.txt_Length.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Length.Size = New System.Drawing.Size(54, 26)
        Me.txt_Length.SpellControl = Nothing
        Me.txt_Length.TabIndex = 3
        Me.txt_Length.Tag = "Length"
        Me.txt_Length.Text = "120"
        Me.txt_Length.Title = Nothing
        Me.txt_Length.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_Length.UseForData = True
        Me.txt_Length.ValidateCheckExistOnEdit = False
        Me.txt_Length.Value = 120.0!
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.عنوانDataGridViewTextBoxColumn, Me.شروعDataGridViewTextBoxColumn, Me.پایانDataGridViewTextBoxColumn, Me.جلسات, Me.مدتDataGridViewTextBoxColumn, Me.مدرسDataGridViewTextBoxColumn, Me.محلDataGridViewTextBoxColumn, Me.برگزارکنندهDataGridViewTextBoxColumn, Me.هزینهآموزشیDataGridViewTextBoxColumn, Me.هزینهرفاهیDataGridViewTextBoxColumn, Me.هزینهمتفرقهDataGridViewTextBoxColumn, Me.هزینهکلDataGridViewTextBoxColumn, Me.مکانDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmEduDoreHoldingBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1148, 346)
        Me.DataGridView1.TabIndex = 4
        '
        'PmEduDoreHoldingBindingSource
        '
        Me.PmEduDoreHoldingBindingSource.DataMember = "Pm_Edu_DoreHolding"
        Me.PmEduDoreHoldingBindingSource.DataSource = Me.Ds_Edu
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "تاریخ پایان"
        '
        'TextBox2
        '
        Me.TextBox2.CheckExistValueInDb = False
        Me.TextBox2.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox2.CurrencyUnit = "ریال"
        Me.TextBox2.DefaultValue = ""
        Me.TextBox2.FillWithMaxInDb = False
        Me.TextBox2.IsRequired = True
        Me.TextBox2.Location = New System.Drawing.Point(15, 60)
        Me.TextBox2.MaxDecimalLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(135, 26)
        Me.TextBox2.SpellControl = Nothing
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TabStop = False
        Me.TextBox2.Tag = "EndDate"
        Me.TextBox2.Title = Nothing
        Me.TextBox2.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.TextBox2.UseForData = True
        Me.TextBox2.ValidateCheckExistOnEdit = False
        Me.TextBox2.Value = ""
        '
        'cmb_Teacher
        '
        Me.cmb_Teacher.AutoComplete = True
        Me.cmb_Teacher.DataSource = Me.PmEduTeacherBindingSource
        Me.cmb_Teacher.DisplayMember = "نا م و نام خانوادگی"
        Me.cmb_Teacher.EnterStop = True
        Me.cmb_Teacher.FormattingEnabled = True
        Me.cmb_Teacher.IsRequired = False
        Me.cmb_Teacher.LimitedToList = True
        Me.cmb_Teacher.Location = New System.Drawing.Point(15, 95)
        Me.cmb_Teacher.Name = "cmb_Teacher"
        Me.cmb_Teacher.OpenOnFoucus = False
        Me.cmb_Teacher.Size = New System.Drawing.Size(195, 26)
        Me.cmb_Teacher.TabIndex = 6
        Me.cmb_Teacher.Tag = "Srl_teacher"
        Me.cmb_Teacher.ValueMember = "Srl"
        '
        'PmEduTeacherBindingSource
        '
        Me.PmEduTeacherBindingSource.DataMember = "Pm_Edu_Teacher"
        Me.PmEduTeacherBindingSource.DataSource = Me.Ds_Edu
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "مدرس"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(500, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 60)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "هزینه ها (ریال)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(141, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "متفرقه"
        '
        'TextBox5
        '
        Me.TextBox5.CheckExistValueInDb = False
        Me.TextBox5.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox5.CurrencyUnit = "ریال"
        Me.TextBox5.DefaultValue = "0"
        Me.TextBox5.FillWithMaxInDb = False
        Me.TextBox5.IsRequired = False
        Me.TextBox5.Location = New System.Drawing.Point(18, 25)
        Me.TextBox5.MaxDecimalLength = 2
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox5.Size = New System.Drawing.Size(117, 26)
        Me.TextBox5.SpellControl = Nothing
        Me.TextBox5.TabIndex = 2
        Me.TextBox5.Tag = "Other_Price"
        Me.TextBox5.Text = "0"
        Me.TextBox5.Title = Nothing
        Me.TextBox5.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.TextBox5.UseForData = True
        Me.TextBox5.ValidateCheckExistOnEdit = False
        Me.TextBox5.Value = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(318, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "رفاهی"
        '
        'TextBox4
        '
        Me.TextBox4.CheckExistValueInDb = False
        Me.TextBox4.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox4.CurrencyUnit = "ریال"
        Me.TextBox4.DefaultValue = "0"
        Me.TextBox4.FillWithMaxInDb = False
        Me.TextBox4.IsRequired = False
        Me.TextBox4.Location = New System.Drawing.Point(213, 24)
        Me.TextBox4.MaxDecimalLength = 2
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox4.Size = New System.Drawing.Size(99, 26)
        Me.TextBox4.SpellControl = Nothing
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Tag = "Refahi_Price"
        Me.TextBox4.Text = "0"
        Me.TextBox4.Title = Nothing
        Me.TextBox4.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.TextBox4.UseForData = True
        Me.TextBox4.ValidateCheckExistOnEdit = False
        Me.TextBox4.Value = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(502, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "آموزشی"
        '
        'TextBox3
        '
        Me.TextBox3.CheckExistValueInDb = False
        Me.TextBox3.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox3.CurrencyUnit = "ریال"
        Me.TextBox3.DefaultValue = "0"
        Me.TextBox3.FillWithMaxInDb = False
        Me.TextBox3.IsRequired = False
        Me.TextBox3.Location = New System.Drawing.Point(383, 24)
        Me.TextBox3.MaxDecimalLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(104, 26)
        Me.TextBox3.SpellControl = Nothing
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Tag = "Edu_Price"
        Me.TextBox3.Text = "0"
        Me.TextBox3.Title = Nothing
        Me.TextBox3.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.TextBox3.UseForData = True
        Me.TextBox3.ValidateCheckExistOnEdit = False
        Me.TextBox3.Value = 0
        '
        'insideProvenance
        '
        Me.insideProvenance.AutoSize = True
        Me.insideProvenance.Checked = True
        Me.insideProvenance.Location = New System.Drawing.Point(274, 146)
        Me.insideProvenance.Name = "insideProvenance"
        Me.insideProvenance.Size = New System.Drawing.Size(101, 22)
        Me.insideProvenance.TabIndex = 7
        Me.insideProvenance.TabStop = True
        Me.insideProvenance.Text = "داخل استان"
        Me.insideProvenance.UseVisualStyleBackColor = True
        '
        'OutsideProvenance
        '
        Me.OutsideProvenance.AutoSize = True
        Me.OutsideProvenance.Location = New System.Drawing.Point(156, 146)
        Me.OutsideProvenance.Name = "OutsideProvenance"
        Me.OutsideProvenance.Size = New System.Drawing.Size(97, 22)
        Me.OutsideProvenance.TabIndex = 8
        Me.OutsideProvenance.Text = "خارج استان"
        Me.OutsideProvenance.UseVisualStyleBackColor = True
        '
        'OutsideCountry
        '
        Me.OutsideCountry.AutoSize = True
        Me.OutsideCountry.Location = New System.Drawing.Point(38, 146)
        Me.OutsideCountry.Name = "OutsideCountry"
        Me.OutsideCountry.Size = New System.Drawing.Size(94, 22)
        Me.OutsideCountry.TabIndex = 9
        Me.OutsideCountry.Text = "خارج کشور"
        Me.OutsideCountry.UseVisualStyleBackColor = True
        '
        'Pm_Edu_DorePlaceTableAdapter
        '
        Me.Pm_Edu_DorePlaceTableAdapter.ClearBeforeFill = True
        '
        'Pm_Edu_DorePresenterTableAdapter
        '
        Me.Pm_Edu_DorePresenterTableAdapter.ClearBeforeFill = True
        '
        'Pm_Edu_DoreTableAdapter
        '
        Me.Pm_Edu_DoreTableAdapter.ClearBeforeFill = True
        '
        'Pm_Edu_DoreHoldingTableAdapter
        '
        Me.Pm_Edu_DoreHoldingTableAdapter.ClearBeforeFill = True
        '
        'Pm_Edu_TeacherTableAdapter
        '
        Me.Pm_Edu_TeacherTableAdapter.ClearBeforeFill = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(794, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 18)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "تعداد جلسات"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = "1"
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = True
        Me.TextBox1.Location = New System.Drawing.Point(732, 94)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(47, 26)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Tag = "SessionCount"
        Me.TextBox1.Text = "0"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = 0
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        Me.عنوانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'شروعDataGridViewTextBoxColumn
        '
        Me.شروعDataGridViewTextBoxColumn.DataPropertyName = "شروع"
        Me.شروعDataGridViewTextBoxColumn.HeaderText = "شروع"
        Me.شروعDataGridViewTextBoxColumn.Name = "شروعDataGridViewTextBoxColumn"
        Me.شروعDataGridViewTextBoxColumn.ReadOnly = True
        '
        'پایانDataGridViewTextBoxColumn
        '
        Me.پایانDataGridViewTextBoxColumn.DataPropertyName = "پایان"
        Me.پایانDataGridViewTextBoxColumn.HeaderText = "پایان"
        Me.پایانDataGridViewTextBoxColumn.Name = "پایانDataGridViewTextBoxColumn"
        Me.پایانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'جلسات
        '
        Me.جلسات.DataPropertyName = "جلسات"
        Me.جلسات.HeaderText = "جلسات"
        Me.جلسات.Name = "جلسات"
        Me.جلسات.ReadOnly = True
        '
        'مدتDataGridViewTextBoxColumn
        '
        Me.مدتDataGridViewTextBoxColumn.DataPropertyName = "مدت"
        Me.مدتDataGridViewTextBoxColumn.HeaderText = "مدت"
        Me.مدتDataGridViewTextBoxColumn.Name = "مدتDataGridViewTextBoxColumn"
        Me.مدتDataGridViewTextBoxColumn.ReadOnly = True
        Me.مدتDataGridViewTextBoxColumn.Width = 50
        '
        'مدرسDataGridViewTextBoxColumn
        '
        Me.مدرسDataGridViewTextBoxColumn.DataPropertyName = "مدرس"
        Me.مدرسDataGridViewTextBoxColumn.HeaderText = "مدرس"
        Me.مدرسDataGridViewTextBoxColumn.Name = "مدرسDataGridViewTextBoxColumn"
        Me.مدرسDataGridViewTextBoxColumn.ReadOnly = True
        Me.مدرسDataGridViewTextBoxColumn.Visible = False
        '
        'محلDataGridViewTextBoxColumn
        '
        Me.محلDataGridViewTextBoxColumn.DataPropertyName = "محل"
        Me.محلDataGridViewTextBoxColumn.HeaderText = "محل"
        Me.محلDataGridViewTextBoxColumn.Name = "محلDataGridViewTextBoxColumn"
        Me.محلDataGridViewTextBoxColumn.ReadOnly = True
        Me.محلDataGridViewTextBoxColumn.Width = 150
        '
        'برگزارکنندهDataGridViewTextBoxColumn
        '
        Me.برگزارکنندهDataGridViewTextBoxColumn.DataPropertyName = "برگزارکننده"
        Me.برگزارکنندهDataGridViewTextBoxColumn.HeaderText = "برگزارکننده"
        Me.برگزارکنندهDataGridViewTextBoxColumn.Name = "برگزارکنندهDataGridViewTextBoxColumn"
        Me.برگزارکنندهDataGridViewTextBoxColumn.ReadOnly = True
        Me.برگزارکنندهDataGridViewTextBoxColumn.Width = 150
        '
        'هزینهآموزشیDataGridViewTextBoxColumn
        '
        Me.هزینهآموزشیDataGridViewTextBoxColumn.DataPropertyName = "هزینه آموزشی"
        Me.هزینهآموزشیDataGridViewTextBoxColumn.HeaderText = "هزینه آموزشی"
        Me.هزینهآموزشیDataGridViewTextBoxColumn.Name = "هزینهآموزشیDataGridViewTextBoxColumn"
        Me.هزینهآموزشیDataGridViewTextBoxColumn.ReadOnly = True
        Me.هزینهآموزشیDataGridViewTextBoxColumn.Visible = False
        '
        'هزینهرفاهیDataGridViewTextBoxColumn
        '
        Me.هزینهرفاهیDataGridViewTextBoxColumn.DataPropertyName = "هزینه رفاهی"
        Me.هزینهرفاهیDataGridViewTextBoxColumn.HeaderText = "هزینه رفاهی"
        Me.هزینهرفاهیDataGridViewTextBoxColumn.Name = "هزینهرفاهیDataGridViewTextBoxColumn"
        Me.هزینهرفاهیDataGridViewTextBoxColumn.ReadOnly = True
        Me.هزینهرفاهیDataGridViewTextBoxColumn.Visible = False
        '
        'هزینهمتفرقهDataGridViewTextBoxColumn
        '
        Me.هزینهمتفرقهDataGridViewTextBoxColumn.DataPropertyName = "هزینه متفرقه"
        Me.هزینهمتفرقهDataGridViewTextBoxColumn.HeaderText = "هزینه متفرقه"
        Me.هزینهمتفرقهDataGridViewTextBoxColumn.Name = "هزینهمتفرقهDataGridViewTextBoxColumn"
        Me.هزینهمتفرقهDataGridViewTextBoxColumn.ReadOnly = True
        Me.هزینهمتفرقهDataGridViewTextBoxColumn.Visible = False
        '
        'هزینهکلDataGridViewTextBoxColumn
        '
        Me.هزینهکلDataGridViewTextBoxColumn.DataPropertyName = "هزینه کل"
        Me.هزینهکلDataGridViewTextBoxColumn.HeaderText = "هزینه کل"
        Me.هزینهکلDataGridViewTextBoxColumn.Name = "هزینهکلDataGridViewTextBoxColumn"
        Me.هزینهکلDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مکانDataGridViewTextBoxColumn
        '
        Me.مکانDataGridViewTextBoxColumn.DataPropertyName = "مکان"
        Me.مکانDataGridViewTextBoxColumn.HeaderText = "مکان"
        Me.مکانDataGridViewTextBoxColumn.Name = "مکانDataGridViewTextBoxColumn"
        Me.مکانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "..."
        Me.Column1.Image = Global.Nama_PM.My.Resources.Resources.Users_Checked_User_icon__2_
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.ToolTipText = "لیست افراد"
        Me.Column1.Width = 25
        '
        'Frm_Edu_DoreHolding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1182, 705)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Edu_DoreHolding"
        Me.TableName = "Pm_Edu_DoreHolding"
        Me.Text = "ثبت دوره های آموزشی"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.PmEduDoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDorePresenterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDorePlaceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDoreHoldingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduTeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Place As VB_Component.ComboBox
    Friend WithEvents cmb_Presenter As VB_Component.ComboBox
    Friend WithEvents cmb_Dore As VB_Component.ComboBox
    Friend WithEvents txt_Length As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_BeginDate As CS_Component.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents TextBox2 As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Ds_Edu As Nama_PM.Ds_Edu
    Friend WithEvents PmEduDorePlaceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DorePlaceTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DorePlaceTableAdapter
    Friend WithEvents PmEduDorePresenterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DorePresenterTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DorePresenterTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_Teacher As VB_Component.ComboBox
    Friend WithEvents PmEduDoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DoreTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreTableAdapter
    Friend WithEvents OutsideCountry As System.Windows.Forms.RadioButton
    Friend WithEvents OutsideProvenance As System.Windows.Forms.RadioButton
    Friend WithEvents insideProvenance As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As CS_Component.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As CS_Component.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As CS_Component.TextBox
    Friend WithEvents PmEduDoreHoldingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DoreHoldingTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreHoldingTableAdapter
    Friend WithEvents PmEduTeacherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_TeacherTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_TeacherTableAdapter
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شروعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پایانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents جلسات As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مدتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مدرسDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents برگزارکنندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents هزینهآموزشیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents هزینهرفاهیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents هزینهمتفرقهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents هزینهکلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مکانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewImageColumn
End Class
