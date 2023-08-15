<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Post_Pishnahad
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.موضوعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.زیرموضوعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پیشنهادDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پیشنهاددهندهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تجهیزDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.واحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmPostPishnahdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.txt_Desc = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_tarikh = New CS_Component.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_Ashkhas = New VB_Component.ComboBox
        Me.PmAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.Label9 = New System.Windows.Forms.Label
        Me.Pm_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
        Me.Pm_Post_PishnahdTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_Post_PishnahdTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_RecomSubject = New VB_Component.ComboBox
        Me.PmRecomendationSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_SubRecom = New VB_Component.ComboBox
        Me.PmSubRecomendationSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.PmHadeseKhesaratDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_Vahde = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_RecomendationSubjectTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_RecomendationSubjectTableAdapter
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_Hadese_KhesaratDeviceTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
        Me.Pm_SubRecomendationSubjectTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_SubRecomendationSubjectTableAdapter
        Me.rb_All = New System.Windows.Forms.RadioButton
        Me.rb_Tajhiz = New System.Windows.Forms.RadioButton
        Me.rb_Post = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_FromDate = New CS_Component.TextBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.chk_AllDate = New System.Windows.Forms.CheckBox
        Me.btn_SelectTajhiz = New System.Windows.Forms.Button
        Me.txt_TajhizNameForSave = New CS_Component.TextBox
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostPishnahdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSubRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(344, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(591, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(467, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.chk_AllDate)
        Me.gbx_GridViewList.Controls.Add(Me.rb_Tajhiz)
        Me.gbx_GridViewList.Controls.Add(Me.rb_Post)
        Me.gbx_GridViewList.Controls.Add(Me.rb_All)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Controls.Add(Me.txt_ToDate)
        Me.gbx_GridViewList.Controls.Add(Me.txt_FromDate)
        Me.gbx_GridViewList.Controls.Add(Me.Label10)
        Me.gbx_GridViewList.Controls.Add(Me.Label8)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 36)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(714, 301)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.btn_SelectTajhiz)
        Me.gbx_Controls.Controls.Add(Me.txt_TajhizNameForSave)
        Me.gbx_Controls.Controls.Add(Me.cmb_Post)
        Me.gbx_Controls.Controls.Add(Me.cmb_SubRecom)
        Me.gbx_Controls.Controls.Add(Me.cmb_RecomSubject)
        Me.gbx_Controls.Controls.Add(Me.cmb_Vahde)
        Me.gbx_Controls.Controls.Add(Me.cmb_Ashkhas)
        Me.gbx_Controls.Controls.Add(Me.Label7)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.txt_tarikh)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.txt_Desc)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 401)
        Me.gbx_Controls.Size = New System.Drawing.Size(714, 216)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 335)
        Me.gbx_Btn.Size = New System.Drawing.Size(714, 60)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.موضوعDataGridViewTextBoxColumn, Me.زیرموضوعDataGridViewTextBoxColumn, Me.پیشنهادDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.پیشنهاددهندهDataGridViewTextBoxColumn, Me.تجهیزDataGridViewTextBoxColumn, Me.پستDataGridViewTextBoxColumn, Me.واحدDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmPostPishnahdBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(708, 214)
        Me.DataGridView1.TabIndex = 0
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'موضوعDataGridViewTextBoxColumn
        '
        Me.موضوعDataGridViewTextBoxColumn.DataPropertyName = "موضوع"
        Me.موضوعDataGridViewTextBoxColumn.HeaderText = "موضوع"
        Me.موضوعDataGridViewTextBoxColumn.Name = "موضوعDataGridViewTextBoxColumn"
        Me.موضوعDataGridViewTextBoxColumn.ReadOnly = True
        '
        'زیرموضوعDataGridViewTextBoxColumn
        '
        Me.زیرموضوعDataGridViewTextBoxColumn.DataPropertyName = "زیر موضوع"
        Me.زیرموضوعDataGridViewTextBoxColumn.HeaderText = "زیر موضوع"
        Me.زیرموضوعDataGridViewTextBoxColumn.Name = "زیرموضوعDataGridViewTextBoxColumn"
        Me.زیرموضوعDataGridViewTextBoxColumn.ReadOnly = True
        '
        'پیشنهادDataGridViewTextBoxColumn
        '
        Me.پیشنهادDataGridViewTextBoxColumn.DataPropertyName = "پیشنهاد"
        Me.پیشنهادDataGridViewTextBoxColumn.HeaderText = "پیشنهاد"
        Me.پیشنهادDataGridViewTextBoxColumn.Name = "پیشنهادDataGridViewTextBoxColumn"
        Me.پیشنهادDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'پیشنهاددهندهDataGridViewTextBoxColumn
        '
        Me.پیشنهاددهندهDataGridViewTextBoxColumn.DataPropertyName = "پیشنهاد دهنده"
        Me.پیشنهاددهندهDataGridViewTextBoxColumn.HeaderText = "پیشنهاد دهنده"
        Me.پیشنهاددهندهDataGridViewTextBoxColumn.Name = "پیشنهاددهندهDataGridViewTextBoxColumn"
        Me.پیشنهاددهندهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تجهیزDataGridViewTextBoxColumn
        '
        Me.تجهیزDataGridViewTextBoxColumn.DataPropertyName = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn.HeaderText = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn.Name = "تجهیزDataGridViewTextBoxColumn"
        Me.تجهیزDataGridViewTextBoxColumn.ReadOnly = True
        '
        'پستDataGridViewTextBoxColumn
        '
        Me.پستDataGridViewTextBoxColumn.DataPropertyName = "پست"
        Me.پستDataGridViewTextBoxColumn.HeaderText = "پست"
        Me.پستDataGridViewTextBoxColumn.Name = "پستDataGridViewTextBoxColumn"
        Me.پستDataGridViewTextBoxColumn.ReadOnly = True
        '
        'واحدDataGridViewTextBoxColumn
        '
        Me.واحدDataGridViewTextBoxColumn.DataPropertyName = "واحد"
        Me.واحدDataGridViewTextBoxColumn.HeaderText = "واحد"
        Me.واحدDataGridViewTextBoxColumn.Name = "واحدDataGridViewTextBoxColumn"
        Me.واحدDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmPostPishnahdBindingSource
        '
        Me.PmPostPishnahdBindingSource.DataMember = "Pm_Post_Pishnahd"
        Me.PmPostPishnahdBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_Desc
        '
        Me.txt_Desc.CheckExistValueInDb = False
        Me.txt_Desc.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Desc.CurrencyUnit = "ریال"
        Me.txt_Desc.DefaultValue = ""
        Me.txt_Desc.FillWithMaxInDb = False
        Me.txt_Desc.IsRequired = False
        Me.txt_Desc.Location = New System.Drawing.Point(7, 81)
        Me.txt_Desc.MaxDecimalLength = 2
        Me.txt_Desc.Multiline = True
        Me.txt_Desc.Name = "txt_Desc"
        Me.txt_Desc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Desc.Size = New System.Drawing.Size(589, 53)
        Me.txt_Desc.SpellControl = Nothing
        Me.txt_Desc.TabIndex = 4
        Me.txt_Desc.Tag = "Pishnahad"
        Me.txt_Desc.Title = Nothing
        Me.txt_Desc.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Desc.UseForData = True
        Me.txt_Desc.ValidateCheckExistOnEdit = False
        Me.txt_Desc.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(601, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "شرح پیشنهاد"
        '
        'txt_tarikh
        '
        Me.txt_tarikh.CheckExistValueInDb = False
        Me.txt_tarikh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_tarikh.CurrencyUnit = "ریال"
        Me.txt_tarikh.DefaultValue = ""
        Me.txt_tarikh.FillWithMaxInDb = False
        Me.txt_tarikh.IsRequired = False
        Me.txt_tarikh.Location = New System.Drawing.Point(136, 49)
        Me.txt_tarikh.MaxDecimalLength = 2
        Me.txt_tarikh.Name = "txt_tarikh"
        Me.txt_tarikh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_tarikh.Size = New System.Drawing.Size(155, 26)
        Me.txt_tarikh.SpellControl = Nothing
        Me.txt_tarikh.TabIndex = 3
        Me.txt_tarikh.TabStop = False
        Me.txt_tarikh.Tag = "Tarikh"
        Me.txt_tarikh.Title = Nothing
        Me.txt_tarikh.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_tarikh.UseForData = True
        Me.txt_tarikh.ValidateCheckExistOnEdit = False
        Me.txt_tarikh.Value = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "تاریخ"
        '
        'cmb_Ashkhas
        '
        Me.cmb_Ashkhas.AutoComplete = True
        Me.cmb_Ashkhas.DataSource = Me.PmAshkhasBindingSource
        Me.cmb_Ashkhas.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Ashkhas.EnterStop = True
        Me.cmb_Ashkhas.FormattingEnabled = True
        Me.cmb_Ashkhas.IsRequired = False
        Me.cmb_Ashkhas.LimitedToList = True
        Me.cmb_Ashkhas.Location = New System.Drawing.Point(401, 49)
        Me.cmb_Ashkhas.Name = "cmb_Ashkhas"
        Me.cmb_Ashkhas.OpenOnFoucus = False
        Me.cmb_Ashkhas.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Ashkhas.TabIndex = 2
        Me.cmb_Ashkhas.Tag = "Srl_Pm_Ashkhas"
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
        Me.Label9.Location = New System.Drawing.Point(601, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 18)
        Me.Label9.TabIndex = 216
        Me.Label9.Text = "پیشنهاد دهنده"
        '
        'Pm_AshkhasTableAdapter
        '
        Me.Pm_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'Pm_Post_PishnahdTableAdapter
        '
        Me.Pm_Post_PishnahdTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(601, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "موضوع"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "زیر موضوع"
        '
        'cmb_RecomSubject
        '
        Me.cmb_RecomSubject.AutoComplete = True
        Me.cmb_RecomSubject.DataSource = Me.PmRecomendationSubjectBindingSource
        Me.cmb_RecomSubject.DisplayMember = "نام"
        Me.cmb_RecomSubject.EnterStop = True
        Me.cmb_RecomSubject.FormattingEnabled = True
        Me.cmb_RecomSubject.IsRequired = False
        Me.cmb_RecomSubject.LimitedToList = True
        Me.cmb_RecomSubject.Location = New System.Drawing.Point(401, 18)
        Me.cmb_RecomSubject.Name = "cmb_RecomSubject"
        Me.cmb_RecomSubject.OpenOnFoucus = False
        Me.cmb_RecomSubject.Size = New System.Drawing.Size(194, 26)
        Me.cmb_RecomSubject.TabIndex = 0
        Me.cmb_RecomSubject.Tag = "Srl_RecomSubject"
        Me.cmb_RecomSubject.ValueMember = "Srl"
        '
        'PmRecomendationSubjectBindingSource
        '
        Me.PmRecomendationSubjectBindingSource.DataMember = "Pm_RecomendationSubject"
        Me.PmRecomendationSubjectBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_SubRecom
        '
        Me.cmb_SubRecom.AutoComplete = True
        Me.cmb_SubRecom.DataSource = Me.PmSubRecomendationSubjectBindingSource
        Me.cmb_SubRecom.DisplayMember = "نام"
        Me.cmb_SubRecom.EnterStop = True
        Me.cmb_SubRecom.FormattingEnabled = True
        Me.cmb_SubRecom.IsRequired = False
        Me.cmb_SubRecom.LimitedToList = True
        Me.cmb_SubRecom.Location = New System.Drawing.Point(97, 18)
        Me.cmb_SubRecom.Name = "cmb_SubRecom"
        Me.cmb_SubRecom.OpenOnFoucus = False
        Me.cmb_SubRecom.Size = New System.Drawing.Size(194, 26)
        Me.cmb_SubRecom.TabIndex = 1
        Me.cmb_SubRecom.Tag = "Srl_SubRecomSubject"
        Me.cmb_SubRecom.ValueMember = "Srl"
        '
        'PmSubRecomendationSubjectBindingSource
        '
        Me.PmSubRecomendationSubjectBindingSource.DataMember = "Pm_SubRecomendationSubject"
        Me.PmSubRecomendationSubjectBindingSource.DataSource = Me.Ds_Pm
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(601, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "واحد"
        '
        'PmHadeseKhesaratDeviceBindingSource
        '
        Me.PmHadeseKhesaratDeviceBindingSource.DataMember = "Pm_Hadese_KhesaratDevice"
        Me.PmHadeseKhesaratDeviceBindingSource.DataSource = Me.Ds_Hadese
        '
        'Ds_Hadese
        '
        Me.Ds_Hadese.DataSetName = "Ds_Hadese"
        Me.Ds_Hadese.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 216
        Me.Label5.Text = "تجهیز"
        '
        'cmb_Vahde
        '
        Me.cmb_Vahde.AutoComplete = True
        Me.cmb_Vahde.DataSource = Me.PmVahedBindingSource
        Me.cmb_Vahde.DisplayMember = "نام واحد"
        Me.cmb_Vahde.EnterStop = True
        Me.cmb_Vahde.FormattingEnabled = True
        Me.cmb_Vahde.IsRequired = False
        Me.cmb_Vahde.LimitedToList = True
        Me.cmb_Vahde.Location = New System.Drawing.Point(402, 172)
        Me.cmb_Vahde.Name = "cmb_Vahde"
        Me.cmb_Vahde.OpenOnFoucus = False
        Me.cmb_Vahde.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Vahde.TabIndex = 7
        Me.cmb_Vahde.Tag = "Srl_Vahed"
        Me.cmb_Vahde.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_RecomendationSubjectTableAdapter
        '
        Me.Pm_RecomendationSubjectTableAdapter.ClearBeforeFill = True
        '
        'cmb_Post
        '
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PmPostBindingSource
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = True
        Me.cmb_Post.Location = New System.Drawing.Point(402, 140)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Post.TabIndex = 5
        Me.cmb_Post.Tag = "Srl_Post"
        Me.cmb_Post.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(602, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 18)
        Me.Label7.TabIndex = 216
        Me.Label7.Text = "پست"
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_KhesaratDeviceTableAdapter
        '
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.ClearBeforeFill = True
        '
        'Pm_SubRecomendationSubjectTableAdapter
        '
        Me.Pm_SubRecomendationSubjectTableAdapter.ClearBeforeFill = True
        '
        'rb_All
        '
        Me.rb_All.AutoSize = True
        Me.rb_All.Checked = True
        Me.rb_All.Location = New System.Drawing.Point(200, 20)
        Me.rb_All.Name = "rb_All"
        Me.rb_All.Size = New System.Drawing.Size(122, 22)
        Me.rb_All.TabIndex = 2
        Me.rb_All.TabStop = True
        Me.rb_All.Text = "تمام پیشنهادات"
        Me.rb_All.UseVisualStyleBackColor = True
        '
        'rb_Tajhiz
        '
        Me.rb_Tajhiz.AutoSize = True
        Me.rb_Tajhiz.Location = New System.Drawing.Point(538, 20)
        Me.rb_Tajhiz.Name = "rb_Tajhiz"
        Me.rb_Tajhiz.Size = New System.Drawing.Size(159, 22)
        Me.rb_Tajhiz.TabIndex = 0
        Me.rb_Tajhiz.Text = "فقط پیشنهادات تجهیز"
        Me.rb_Tajhiz.UseVisualStyleBackColor = True
        '
        'rb_Post
        '
        Me.rb_Post.AutoSize = True
        Me.rb_Post.Location = New System.Drawing.Point(344, 20)
        Me.rb_Post.Name = "rb_Post"
        Me.rb_Post.Size = New System.Drawing.Size(160, 22)
        Me.rb_Post.TabIndex = 1
        Me.rb_Post.Text = "فقط پیشنهادات پست"
        Me.rb_Post.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(580, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "پیشنهادات از تاریخ"
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = False
        Me.txt_FromDate.Location = New System.Drawing.Point(422, 53)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(155, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 3
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = ""
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = False
        Me.txt_ToDate.Location = New System.Drawing.Point(210, 53)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(155, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 4
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = ""
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(371, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 18)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "از تاریخ"
        '
        'chk_AllDate
        '
        Me.chk_AllDate.AutoSize = True
        Me.chk_AllDate.Location = New System.Drawing.Point(97, 57)
        Me.chk_AllDate.Name = "chk_AllDate"
        Me.chk_AllDate.Size = New System.Drawing.Size(105, 22)
        Me.chk_AllDate.TabIndex = 5
        Me.chk_AllDate.Text = "تمام تاریخ ها"
        Me.chk_AllDate.UseVisualStyleBackColor = True
        '
        'btn_SelectTajhiz
        '
        Me.btn_SelectTajhiz.Location = New System.Drawing.Point(52, 143)
        Me.btn_SelectTajhiz.Name = "btn_SelectTajhiz"
        Me.btn_SelectTajhiz.Size = New System.Drawing.Size(40, 25)
        Me.btn_SelectTajhiz.TabIndex = 219
        Me.btn_SelectTajhiz.Text = "..."
        Me.btn_SelectTajhiz.UseVisualStyleBackColor = True
        '
        'txt_TajhizNameForSave
        '
        Me.txt_TajhizNameForSave.CheckExistValueInDb = False
        Me.txt_TajhizNameForSave.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TajhizNameForSave.CurrencyUnit = "ریال"
        Me.txt_TajhizNameForSave.DefaultValue = ""
        Me.txt_TajhizNameForSave.Enabled = False
        Me.txt_TajhizNameForSave.FillWithMaxInDb = False
        Me.txt_TajhizNameForSave.IsRequired = False
        Me.txt_TajhizNameForSave.Location = New System.Drawing.Point(97, 143)
        Me.txt_TajhizNameForSave.MaxDecimalLength = 2
        Me.txt_TajhizNameForSave.Name = "txt_TajhizNameForSave"
        Me.txt_TajhizNameForSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TajhizNameForSave.Size = New System.Drawing.Size(194, 26)
        Me.txt_TajhizNameForSave.SpellControl = Nothing
        Me.txt_TajhizNameForSave.TabIndex = 6
        Me.txt_TajhizNameForSave.Tag = ""
        Me.txt_TajhizNameForSave.Title = Nothing
        Me.txt_TajhizNameForSave.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TajhizNameForSave.UseForData = True
        Me.txt_TajhizNameForSave.ValidateCheckExistOnEdit = False
        Me.txt_TajhizNameForSave.Value = ""
        '
        'Frm_Post_Pishnahad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(742, 651)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Post_Pishnahad"
        Me.TableName = "Pm_Post_Pishnahd"
        Me.Text = "پیشنهادات پست"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostPishnahdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSubRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents txt_Desc As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_tarikh As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_Ashkhas As VB_Component.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents PmAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents موضوعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents زیرموضوعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پیشنهادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پیشنهاددهندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تجهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmPostPishnahdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents cmb_RecomSubject As VB_Component.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pm_Post_PishnahdTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_Post_PishnahdTableAdapter
    Friend WithEvents cmb_SubRecom As VB_Component.ComboBox
    Friend WithEvents cmb_Vahde As VB_Component.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PmRecomendationSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_RecomendationSubjectTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_RecomendationSubjectTableAdapter
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents PmSubRecomendationSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_SubRecomendationSubjectTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_SubRecomendationSubjectTableAdapter
    Friend WithEvents rb_Tajhiz As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Post As System.Windows.Forms.RadioButton
    Friend WithEvents rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents chk_AllDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_SelectTajhiz As System.Windows.Forms.Button
    Friend WithEvents txt_TajhizNameForSave As CS_Component.TextBox
End Class
