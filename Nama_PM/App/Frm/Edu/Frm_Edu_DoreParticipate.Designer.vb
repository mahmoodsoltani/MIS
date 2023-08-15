<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Edu_DoreParticipate
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
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Ds_Edu = New Nama_PM.Ds_Edu
        Me.cmb_Ashkhas = New VB_Component.ComboBox
        Me.PmAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.Label9 = New System.Windows.Forms.Label
        Me.Pm_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
        Me.TextBox3 = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New CS_Component.TextBox
        Me.chk_EduRegister = New System.Windows.Forms.CheckBox
        Me.chk_CompanyRegister = New System.Windows.Forms.CheckBox
        Me.txt_FormKarTarikh = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.srl_ashkhas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامونامخانوادگیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مدتشرکتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نمرهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مدرک = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.اموزش = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.شرکت = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PmEduDoreHoldingtitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmEduDoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Edu_DoreTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreTableAdapter
        Me.Pm_Edu_DoreHoldingtitleTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreHoldingtitleTableAdapter
        Me.chk_Certificate = New System.Windows.Forms.CheckBox
        Me.PmEduDoreParticipationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Edu_DoreParticipationTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreParticipationTableAdapter
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامونامخانوادگیDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مدتشرکتDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نمرهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مدرکDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.اموزشDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.شرکتDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.تاریخصورتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlashkhasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EvaluationFormDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDoreHoldingtitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDoreParticipationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(598, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "F2 اضافه کردن"
        Me.btn_new.Location = New System.Drawing.Point(847, 18)
        Me.btn_new.Size = New System.Drawing.Size(135, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(722, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(988, 360)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.txt_FormKarTarikh)
        Me.gbx_Controls.Controls.Add(Me.chk_CompanyRegister)
        Me.gbx_Controls.Controls.Add(Me.chk_Certificate)
        Me.gbx_Controls.Controls.Add(Me.chk_EduRegister)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.TextBox3)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.cmb_Ashkhas)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 461)
        Me.gbx_Controls.Size = New System.Drawing.Size(988, 87)
        Me.gbx_Controls.TabIndex = 1
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 406)
        Me.gbx_Btn.Size = New System.Drawing.Size(988, 60)
        Me.gbx_Btn.TabIndex = 0
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.شمارهDataGridViewTextBoxColumn, Me.نامونامخانوادگیDataGridViewTextBoxColumn1, Me.مدتشرکتDataGridViewTextBoxColumn1, Me.نمرهDataGridViewTextBoxColumn1, Me.مدرکDataGridViewCheckBoxColumn, Me.اموزشDataGridViewCheckBoxColumn, Me.شرکتDataGridViewCheckBoxColumn, Me.تاریخصورتDataGridViewTextBoxColumn, Me.SrlashkhasDataGridViewTextBoxColumn, Me.EvaluationFormDataGridViewTextBoxColumn, Me.SrlDataGridViewTextBoxColumn2})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmEduDoreParticipationBindingSource
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
        Me.DataGridView1.Size = New System.Drawing.Size(982, 335)
        Me.DataGridView1.TabIndex = 0
        '
        'Ds_Edu
        '
        Me.Ds_Edu.DataSetName = "Ds_Edu"
        Me.Ds_Edu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_Ashkhas
        '
        Me.cmb_Ashkhas.AutoComplete = True
        Me.cmb_Ashkhas.DataSource = Me.PmAshkhasBindingSource
        Me.cmb_Ashkhas.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Ashkhas.EnterStop = True
        Me.cmb_Ashkhas.FormattingEnabled = True
        Me.cmb_Ashkhas.IsRequired = True
        Me.cmb_Ashkhas.LimitedToList = True
        Me.cmb_Ashkhas.Location = New System.Drawing.Point(486, 19)
        Me.cmb_Ashkhas.Name = "cmb_Ashkhas"
        Me.cmb_Ashkhas.OpenOnFoucus = True
        Me.cmb_Ashkhas.Size = New System.Drawing.Size(353, 26)
        Me.cmb_Ashkhas.TabIndex = 1
        Me.cmb_Ashkhas.Tag = "Srl_Ashkhas"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(847, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "نام و نام خانوادگی:"
        '
        'Pm_AshkhasTableAdapter
        '
        Me.Pm_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'TextBox3
        '
        Me.TextBox3.CheckExistValueInDb = False
        Me.TextBox3.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox3.CurrencyUnit = "ریال"
        Me.TextBox3.DefaultValue = ""
        Me.TextBox3.FillWithMaxInDb = False
        Me.TextBox3.IsRequired = False
        Me.TextBox3.Location = New System.Drawing.Point(768, 55)
        Me.TextBox3.MaxDecimalLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(71, 26)
        Me.TextBox3.SpellControl = Nothing
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Tag = "ParticipationTime"
        Me.TextBox3.Title = Nothing
        Me.TextBox3.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox3.UseForData = True
        Me.TextBox3.ValidateCheckExistOnEdit = False
        Me.TextBox3.Value = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(721, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "دقیقه"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(847, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "مدت شرکت:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(667, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "نمره:"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(598, 55)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(63, 26)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Tag = "grade"
        Me.TextBox1.Text = "0"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = 0.0!
        '
        'chk_EduRegister
        '
        Me.chk_EduRegister.AutoSize = True
        Me.chk_EduRegister.Location = New System.Drawing.Point(308, 54)
        Me.chk_EduRegister.Name = "chk_EduRegister"
        Me.chk_EduRegister.Size = New System.Drawing.Size(97, 22)
        Me.chk_EduRegister.TabIndex = 29
        Me.chk_EduRegister.Tag = "EducationRegister"
        Me.chk_EduRegister.Text = "ثبت آموزش"
        Me.chk_EduRegister.UseVisualStyleBackColor = True
        '
        'chk_CompanyRegister
        '
        Me.chk_CompanyRegister.AutoSize = True
        Me.chk_CompanyRegister.Location = New System.Drawing.Point(121, 54)
        Me.chk_CompanyRegister.Name = "chk_CompanyRegister"
        Me.chk_CompanyRegister.Size = New System.Drawing.Size(158, 22)
        Me.chk_CompanyRegister.TabIndex = 29
        Me.chk_CompanyRegister.Tag = "CompanyRegister"
        Me.chk_CompanyRegister.Text = "معرفی توسط شرکت"
        Me.chk_CompanyRegister.UseVisualStyleBackColor = True
        '
        'txt_FormKarTarikh
        '
        Me.txt_FormKarTarikh.CheckExistValueInDb = False
        Me.txt_FormKarTarikh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FormKarTarikh.CurrencyUnit = "ریال"
        Me.txt_FormKarTarikh.DefaultValue = ""
        Me.txt_FormKarTarikh.FillWithMaxInDb = False
        Me.txt_FormKarTarikh.IsRequired = False
        Me.txt_FormKarTarikh.Location = New System.Drawing.Point(126, 19)
        Me.txt_FormKarTarikh.MaxDecimalLength = 2
        Me.txt_FormKarTarikh.Name = "txt_FormKarTarikh"
        Me.txt_FormKarTarikh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FormKarTarikh.Size = New System.Drawing.Size(145, 26)
        Me.txt_FormKarTarikh.SpellControl = Nothing
        Me.txt_FormKarTarikh.TabIndex = 30
        Me.txt_FormKarTarikh.TabStop = False
        Me.txt_FormKarTarikh.Tag = "StatusStatementDate"
        Me.txt_FormKarTarikh.Title = Nothing
        Me.txt_FormKarTarikh.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FormKarTarikh.UseForData = True
        Me.txt_FormKarTarikh.ValidateCheckExistOnEdit = False
        Me.txt_FormKarTarikh.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "تاریخ صورت وضعیت:"
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'srl_ashkhas
        '
        Me.srl_ashkhas.DataPropertyName = "srl_ashkhas"
        Me.srl_ashkhas.HeaderText = "srl_ashkhas"
        Me.srl_ashkhas.Name = "srl_ashkhas"
        Me.srl_ashkhas.Visible = False
        '
        'نامونامخانوادگیDataGridViewTextBoxColumn
        '
        Me.نامونامخانوادگیDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامونامخانوادگیDataGridViewTextBoxColumn.DataPropertyName = "نام و نام خانوادگی"
        Me.نامونامخانوادگیDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی"
        Me.نامونامخانوادگیDataGridViewTextBoxColumn.Name = "نامونامخانوادگیDataGridViewTextBoxColumn"
        '
        'مدتشرکتDataGridViewTextBoxColumn
        '
        Me.مدتشرکتDataGridViewTextBoxColumn.DataPropertyName = "مدت شرکت"
        Me.مدتشرکتDataGridViewTextBoxColumn.HeaderText = "مدت شرکت"
        Me.مدتشرکتDataGridViewTextBoxColumn.Name = "مدتشرکتDataGridViewTextBoxColumn"
        '
        'نمرهDataGridViewTextBoxColumn
        '
        Me.نمرهDataGridViewTextBoxColumn.DataPropertyName = "نمره"
        Me.نمرهDataGridViewTextBoxColumn.HeaderText = "نمره"
        Me.نمرهDataGridViewTextBoxColumn.Name = "نمرهDataGridViewTextBoxColumn"
        '
        'مدرک
        '
        Me.مدرک.DataPropertyName = "مدرک"
        Me.مدرک.HeaderText = "مدرک"
        Me.مدرک.Name = "مدرک"
        '
        'اموزش
        '
        Me.اموزش.DataPropertyName = "اموزش"
        Me.اموزش.HeaderText = "اموزش"
        Me.اموزش.Name = "اموزش"
        '
        'شرکت
        '
        Me.شرکت.DataPropertyName = "شرکت"
        Me.شرکت.HeaderText = "شرکت"
        Me.شرکت.Name = "شرکت"
        '
        'PmEduDoreHoldingtitleBindingSource
        '
        Me.PmEduDoreHoldingtitleBindingSource.DataMember = "Pm_Edu_DoreHoldingtitle"
        Me.PmEduDoreHoldingtitleBindingSource.DataSource = Me.Ds_Edu
        '
        'PmEduDoreBindingSource
        '
        Me.PmEduDoreBindingSource.DataMember = "Pm_Edu_Dore"
        Me.PmEduDoreBindingSource.DataSource = Me.Ds_Edu
        '
        'Pm_Edu_DoreTableAdapter
        '
        Me.Pm_Edu_DoreTableAdapter.ClearBeforeFill = True
        '
        'Pm_Edu_DoreHoldingtitleTableAdapter
        '
        Me.Pm_Edu_DoreHoldingtitleTableAdapter.ClearBeforeFill = True
        '
        'chk_Certificate
        '
        Me.chk_Certificate.AutoSize = True
        Me.chk_Certificate.Location = New System.Drawing.Point(432, 55)
        Me.chk_Certificate.Name = "chk_Certificate"
        Me.chk_Certificate.Size = New System.Drawing.Size(62, 22)
        Me.chk_Certificate.TabIndex = 29
        Me.chk_Certificate.Tag = "HaveSertificate"
        Me.chk_Certificate.Text = "مدرک"
        Me.chk_Certificate.UseVisualStyleBackColor = True
        '
        'PmEduDoreParticipationBindingSource
        '
        Me.PmEduDoreParticipationBindingSource.DataMember = "Pm_Edu_DoreParticipation"
        Me.PmEduDoreParticipationBindingSource.DataSource = Me.Ds_Edu
        '
        'Pm_Edu_DoreParticipationTableAdapter
        '
        Me.Pm_Edu_DoreParticipationTableAdapter.ClearBeforeFill = True
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامونامخانوادگیDataGridViewTextBoxColumn1
        '
        Me.نامونامخانوادگیDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامونامخانوادگیDataGridViewTextBoxColumn1.DataPropertyName = "نام و نام خانوادگی"
        Me.نامونامخانوادگیDataGridViewTextBoxColumn1.HeaderText = "نام و نام خانوادگی"
        Me.نامونامخانوادگیDataGridViewTextBoxColumn1.Name = "نامونامخانوادگیDataGridViewTextBoxColumn1"
        Me.نامونامخانوادگیDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'مدتشرکتDataGridViewTextBoxColumn1
        '
        Me.مدتشرکتDataGridViewTextBoxColumn1.DataPropertyName = "مدت شرکت"
        Me.مدتشرکتDataGridViewTextBoxColumn1.HeaderText = "مدت شرکت"
        Me.مدتشرکتDataGridViewTextBoxColumn1.Name = "مدتشرکتDataGridViewTextBoxColumn1"
        Me.مدتشرکتDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نمرهDataGridViewTextBoxColumn1
        '
        Me.نمرهDataGridViewTextBoxColumn1.DataPropertyName = "نمره"
        Me.نمرهDataGridViewTextBoxColumn1.HeaderText = "نمره"
        Me.نمرهDataGridViewTextBoxColumn1.Name = "نمرهDataGridViewTextBoxColumn1"
        Me.نمرهDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'مدرکDataGridViewCheckBoxColumn
        '
        Me.مدرکDataGridViewCheckBoxColumn.DataPropertyName = "مدرک"
        Me.مدرکDataGridViewCheckBoxColumn.HeaderText = "مدرک"
        Me.مدرکDataGridViewCheckBoxColumn.Name = "مدرکDataGridViewCheckBoxColumn"
        Me.مدرکDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'اموزشDataGridViewCheckBoxColumn
        '
        Me.اموزشDataGridViewCheckBoxColumn.DataPropertyName = "اموزش"
        Me.اموزشDataGridViewCheckBoxColumn.HeaderText = "اموزش"
        Me.اموزشDataGridViewCheckBoxColumn.Name = "اموزشDataGridViewCheckBoxColumn"
        Me.اموزشDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'شرکتDataGridViewCheckBoxColumn
        '
        Me.شرکتDataGridViewCheckBoxColumn.DataPropertyName = "شرکت"
        Me.شرکتDataGridViewCheckBoxColumn.HeaderText = "شرکت"
        Me.شرکتDataGridViewCheckBoxColumn.Name = "شرکتDataGridViewCheckBoxColumn"
        Me.شرکتDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'تاریخصورتDataGridViewTextBoxColumn
        '
        Me.تاریخصورتDataGridViewTextBoxColumn.DataPropertyName = "تاریخ صورت "
        Me.تاریخصورتDataGridViewTextBoxColumn.HeaderText = "تاریخ صورت "
        Me.تاریخصورتDataGridViewTextBoxColumn.Name = "تاریخصورتDataGridViewTextBoxColumn"
        Me.تاریخصورتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SrlashkhasDataGridViewTextBoxColumn
        '
        Me.SrlashkhasDataGridViewTextBoxColumn.DataPropertyName = "srl_ashkhas"
        Me.SrlashkhasDataGridViewTextBoxColumn.HeaderText = "srl_ashkhas"
        Me.SrlashkhasDataGridViewTextBoxColumn.Name = "SrlashkhasDataGridViewTextBoxColumn"
        Me.SrlashkhasDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlashkhasDataGridViewTextBoxColumn.Visible = False
        '
        'EvaluationFormDataGridViewTextBoxColumn
        '
        Me.EvaluationFormDataGridViewTextBoxColumn.DataPropertyName = "EvaluationForm"
        Me.EvaluationFormDataGridViewTextBoxColumn.HeaderText = "EvaluationForm"
        Me.EvaluationFormDataGridViewTextBoxColumn.Name = "EvaluationFormDataGridViewTextBoxColumn"
        Me.EvaluationFormDataGridViewTextBoxColumn.ReadOnly = True
        Me.EvaluationFormDataGridViewTextBoxColumn.Visible = False
        '
        'SrlDataGridViewTextBoxColumn2
        '
        Me.SrlDataGridViewTextBoxColumn2.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn2.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn2.Name = "SrlDataGridViewTextBoxColumn2"
        Me.SrlDataGridViewTextBoxColumn2.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn2.Visible = False
        '
        'Frm_Edu_DoreParticipate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1016, 585)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Edu_DoreParticipate"
        Me.TableName = "Pm_Edu_DoreParticipation"
        Me.Text = "افراد شرکت کننده در دوره "
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDoreHoldingtitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDoreParticipationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_Ashkhas As VB_Component.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents PmAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents TextBox3 As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ds_Edu As Nama_PM.Ds_Edu
    Friend WithEvents chk_CompanyRegister As System.Windows.Forms.CheckBox
    Friend WithEvents chk_EduRegister As System.Windows.Forms.CheckBox
    Friend WithEvents txt_FormKarTarikh As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents srl_ashkhas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامونامخانوادگیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مدتشرکتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نمرهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مدرک As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents اموزش As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents شرکت As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PmEduDoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DoreTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreTableAdapter
    Friend WithEvents PmEduDoreHoldingtitleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DoreHoldingtitleTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreHoldingtitleTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_Certificate As System.Windows.Forms.CheckBox
    Friend WithEvents SrlNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامونامخانوادگیDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مدتشرکتDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نمرهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مدرکDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents اموزشDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents شرکتDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents تاریخصورتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlashkhasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvaluationFormDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmEduDoreParticipationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DoreParticipationTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreParticipationTableAdapter
End Class
