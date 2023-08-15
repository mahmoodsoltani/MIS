<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_SaghfeKar
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lk_Ashkhas = New CS_Component.LookupBox
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Acc_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_PrintAll = New System.Windows.Forms.Button
        Me.Btn_print2 = New CS_Component.Btn
        Me.Btn_Search = New CS_Component.Btn
        Me.DataGridView2 = New CS_Component.DataGridView
        Me.موضوعکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مجموعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RpWorkFormWorkDisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سقفاضاقهکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نفرساعتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکارترددDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عضوگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.روزهفتهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RpSaghfeKarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_SaghfeKarTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_SaghfeKarTableAdapter
        Me.Rp_WorkFormWorkDisTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_WorkFormWorkDisTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpWorkFormWorkDisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpSaghfeKarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(12, 478)
        Me.gbx_Buttons.Size = New System.Drawing.Size(33, 50)
        Me.gbx_Buttons.Visible = False
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(-58, 17)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.DataGridView2)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Controls.Add(Me.DataGridView1)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Controls.Add(Me.lk_Ashkhas)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Size = New System.Drawing.Size(941, 486)
        '
        'lk_Ashkhas
        '
        Me.lk_Ashkhas.CodeBoxWidth = 0
        Me.lk_Ashkhas.CodeField = "کد"
        Me.lk_Ashkhas.DataAccess = Nothing
        Me.lk_Ashkhas.DataFields = Nothing
        Me.lk_Ashkhas.DataMode = CS_Component.LookupDataMode.UseDataTable
        Me.lk_Ashkhas.DataSource = Me.AccAshkhasBindingSource
        Me.lk_Ashkhas.DefaultSearchField = "نام و نام خانوادگی"
        Me.lk_Ashkhas.DisplayCodeBox = False
        Me.lk_Ashkhas.DisplayField = "نام و نام خانوادگی"
        Me.lk_Ashkhas.Filter = ""
        Me.lk_Ashkhas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lk_Ashkhas.HiddenFields = Nothing
        Me.lk_Ashkhas.Location = New System.Drawing.Point(621, 22)
        Me.lk_Ashkhas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lk_Ashkhas.Name = "lk_Ashkhas"
        Me.lk_Ashkhas.Result = Nothing
        Me.lk_Ashkhas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lk_Ashkhas.Size = New System.Drawing.Size(278, 26)
        Me.lk_Ashkhas.TabIndex = 11
        Me.lk_Ashkhas.TableName = Nothing
        Me.lk_Ashkhas.ValueField = "Srl"
        '
        'AccAshkhasBindingSource
        '
        Me.AccAshkhasBindingSource.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(905, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "نام"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "تا تاریخ"
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(212, 24)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(148, 23)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 14
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(571, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "از تاریخ"
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(412, 24)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(148, 23)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 13
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Acc_AshkhasTableAdapter
        '
        Me.Acc_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.شمارهفرمکارDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.سقفاضاقهکارDataGridViewTextBoxColumn, Me.نفرساعتDataGridViewTextBoxColumn, Me.اضافهکارDataGridViewTextBoxColumn, Me.اضافهکارترددDataGridViewTextBoxColumn, Me.عضوگروهDataGridViewTextBoxColumn, Me.نامگروهDataGridViewTextBoxColumn, Me.روزهفتهDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.RpSaghfeKarBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(298, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(633, 411)
        Me.DataGridView1.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_PrintAll)
        Me.Panel1.Controls.Add(Me.Btn_print2)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Location = New System.Drawing.Point(9, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 54)
        Me.Panel1.TabIndex = 20
        '
        'btn_PrintAll
        '
        Me.btn_PrintAll.Location = New System.Drawing.Point(45, 29)
        Me.btn_PrintAll.Name = "btn_PrintAll"
        Me.btn_PrintAll.Size = New System.Drawing.Size(115, 24)
        Me.btn_PrintAll.TabIndex = 2
        Me.btn_PrintAll.Text = "گزارش کلی"
        Me.btn_PrintAll.UseVisualStyleBackColor = True
        '
        'Btn_print2
        '
        Me.Btn_print2.BackColor = System.Drawing.Color.Transparent
        Me.Btn_print2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_print2.HeaderText = "چاپ"
        Me.Btn_print2.Location = New System.Drawing.Point(5, 3)
        Me.Btn_print2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_print2.Name = "Btn_print2"
        Me.Btn_print2.Size = New System.Drawing.Size(93, 26)
        Me.Btn_print2.TabIndex = 1
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.HeaderText = "جستجو"
        Me.Btn_Search.Location = New System.Drawing.Point(102, 3)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(93, 26)
        Me.Btn_Search.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.موضوعکارDataGridViewTextBoxColumn, Me.مجموعDataGridViewTextBoxColumn})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2.DataSource = Me.RpWorkFormWorkDisBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Location = New System.Drawing.Point(11, 69)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.RowHeadersWidth = 30
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(279, 409)
        Me.DataGridView2.TabIndex = 21
        '
        'موضوعکارDataGridViewTextBoxColumn
        '
        Me.موضوعکارDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.موضوعکارDataGridViewTextBoxColumn.DataPropertyName = "موضوع کار"
        Me.موضوعکارDataGridViewTextBoxColumn.HeaderText = "موضوع کار"
        Me.موضوعکارDataGridViewTextBoxColumn.Name = "موضوعکارDataGridViewTextBoxColumn"
        Me.موضوعکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مجموعDataGridViewTextBoxColumn
        '
        Me.مجموعDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.مجموعDataGridViewTextBoxColumn.DataPropertyName = "مجموع"
        Me.مجموعDataGridViewTextBoxColumn.HeaderText = "مجموع"
        Me.مجموعDataGridViewTextBoxColumn.Name = "مجموعDataGridViewTextBoxColumn"
        Me.مجموعDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RpWorkFormWorkDisBindingSource
        '
        Me.RpWorkFormWorkDisBindingSource.DataMember = "Rp_WorkFormWorkDis"
        Me.RpWorkFormWorkDisBindingSource.DataSource = Me.Ds_Rp
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهفرمکارDataGridViewTextBoxColumn
        '
        Me.شمارهفرمکارDataGridViewTextBoxColumn.DataPropertyName = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.HeaderText = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.Name = "شمارهفرمکارDataGridViewTextBoxColumn"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'سقفاضاقهکارDataGridViewTextBoxColumn
        '
        Me.سقفاضاقهکارDataGridViewTextBoxColumn.DataPropertyName = "سقف اضاقه کار"
        Me.سقفاضاقهکارDataGridViewTextBoxColumn.HeaderText = "سقف اضاقه کار"
        Me.سقفاضاقهکارDataGridViewTextBoxColumn.Name = "سقفاضاقهکارDataGridViewTextBoxColumn"
        Me.سقفاضاقهکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نفرساعتDataGridViewTextBoxColumn
        '
        Me.نفرساعتDataGridViewTextBoxColumn.DataPropertyName = "نفر ساعت"
        Me.نفرساعتDataGridViewTextBoxColumn.HeaderText = "نفر ساعت"
        Me.نفرساعتDataGridViewTextBoxColumn.Name = "نفرساعتDataGridViewTextBoxColumn"
        Me.نفرساعتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'اضافهکارDataGridViewTextBoxColumn
        '
        Me.اضافهکارDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار"
        Me.اضافهکارDataGridViewTextBoxColumn.HeaderText = "اضافه کار"
        Me.اضافهکارDataGridViewTextBoxColumn.Name = "اضافهکارDataGridViewTextBoxColumn"
        Me.اضافهکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'اضافهکارترددDataGridViewTextBoxColumn
        '
        Me.اضافهکارترددDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار تردد"
        Me.اضافهکارترددDataGridViewTextBoxColumn.HeaderText = "اضافه کار تردد"
        Me.اضافهکارترددDataGridViewTextBoxColumn.Name = "اضافهکارترددDataGridViewTextBoxColumn"
        Me.اضافهکارترددDataGridViewTextBoxColumn.ReadOnly = True
        '
        'عضوگروهDataGridViewTextBoxColumn
        '
        Me.عضوگروهDataGridViewTextBoxColumn.DataPropertyName = "عضو گروه"
        Me.عضوگروهDataGridViewTextBoxColumn.HeaderText = "عضو گروه"
        Me.عضوگروهDataGridViewTextBoxColumn.Name = "عضوگروهDataGridViewTextBoxColumn"
        Me.عضوگروهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        Me.نامگروهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'روزهفتهDataGridViewTextBoxColumn
        '
        Me.روزهفتهDataGridViewTextBoxColumn.DataPropertyName = "روز هفته"
        Me.روزهفتهDataGridViewTextBoxColumn.HeaderText = "روز هفته"
        Me.روزهفتهDataGridViewTextBoxColumn.Name = "روزهفتهDataGridViewTextBoxColumn"
        Me.روزهفتهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RpSaghfeKarBindingSource
        '
        Me.RpSaghfeKarBindingSource.DataMember = "Rp_SaghfeKar"
        Me.RpSaghfeKarBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_SaghfeKarTableAdapter
        '
        Me.Rp_SaghfeKarTableAdapter.ClearBeforeFill = True
        '
        'Rp_WorkFormWorkDisTableAdapter
        '
        Me.Rp_WorkFormWorkDisTableAdapter.ClearBeforeFill = True
        '
        'Frm_Rp_SaghfeKar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(965, 564)
        Me.Name = "Frm_Rp_SaghfeKar"
        Me.Text = "گزارش سقف کار"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpWorkFormWorkDisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpSaghfeKarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lk_Ashkhas As CS_Component.LookupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents DataGridView2 As CS_Component.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_print2 As CS_Component.Btn
    Friend WithEvents Btn_Search As CS_Component.Btn
    Friend WithEvents btn_PrintAll As System.Windows.Forms.Button
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents RpSaghfeKarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_SaghfeKarTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_SaghfeKarTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سقفاضاقهکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نفرساعتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکارترددDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عضوگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents روزهفتهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents موضوعکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مجموعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RpWorkFormWorkDisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_WorkFormWorkDisTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_WorkFormWorkDisTableAdapter
End Class
