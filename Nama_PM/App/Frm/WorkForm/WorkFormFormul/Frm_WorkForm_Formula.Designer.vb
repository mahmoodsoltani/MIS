<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WorkForm_Formula
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
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پروفایل = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.روزهفتهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ضریبDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ازساعتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاساعتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعکارکردDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsTaradodDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.بازهشروعDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PmWorkFormFormulaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New CS_Component.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chk_BazeZamaniNotImportant = New System.Windows.Forms.CheckBox
        Me.cmb_Day = New VB_Component.ComboBox
        Me.PmDayOfWeekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmWorkTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ts_ToSat = New VB_Component.TimeSelect
        Me.ts_FromSat = New VB_Component.TimeSelect
        Me.Pm_DayOfWeekTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_DayOfWeekTableAdapter
        Me.Pm_WorkTypeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_WorkTypeTableAdapter
        Me.pnl_TimeToTime = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_ShowFormul = New CS_Component.Btn
        Me.Pm_WorkForm_FormulaTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_WorkForm_FormulaTableAdapter
        Me.Cmb_Profile = New VB_Component.ComboBox
        Me.PmWorkFormFormulaProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New VB_Component.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Pm_WorkForm_Formula_ProfileTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_WorkForm_Formula_ProfileTableAdapter
        Me.Chk_Profile = New System.Windows.Forms.CheckBox
        Me.chk_DayOfWeek = New System.Windows.Forms.CheckBox
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmWorkFormFormulaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmDayOfWeekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmWorkTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_TimeToTime.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PmWorkFormFormulaProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(596, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(719, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(596, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 39)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(843, 361)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.chk_DayOfWeek)
        Me.gbx_Controls.Controls.Add(Me.Chk_Profile)
        Me.gbx_Controls.Controls.Add(Me.pnl_TimeToTime)
        Me.gbx_Controls.Controls.Add(Me.Cmb_Profile)
        Me.gbx_Controls.Controls.Add(Me.cmb_Day)
        Me.gbx_Controls.Controls.Add(Me.chk_BazeZamaniNotImportant)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 472)
        Me.gbx_Controls.Size = New System.Drawing.Size(843, 125)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Controls.Add(Me.Label8)
        Me.gbx_Btn.Controls.Add(Me.ComboBox3)
        Me.gbx_Btn.Controls.Add(Me.Panel1)
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 406)
        Me.gbx_Btn.Size = New System.Drawing.Size(843, 60)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Panel1, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.ComboBox3, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Label8, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_new, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Cancel, 0)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.پروفایل, Me.روزهفتهDataGridViewTextBoxColumn, Me.ضریبDataGridViewTextBoxColumn, Me.ازساعتDataGridViewTextBoxColumn, Me.تاساعتDataGridViewTextBoxColumn, Me.نوعکارکردDataGridViewTextBoxColumn, Me.IsTaradodDataGridViewCheckBoxColumn, Me.بازهشروعDataGridViewCheckBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmWorkFormFormulaBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.DataGridView1.Size = New System.Drawing.Size(833, 313)
        Me.DataGridView1.TabIndex = 0
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        Me.SrlDataGridViewTextBoxColumn.Width = 180
        '
        'پروفایل
        '
        Me.پروفایل.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.پروفایل.DataPropertyName = "پروفایل"
        Me.پروفایل.HeaderText = "پروفایل"
        Me.پروفایل.Name = "پروفایل"
        Me.پروفایل.ReadOnly = True
        '
        'روزهفتهDataGridViewTextBoxColumn
        '
        Me.روزهفتهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.روزهفتهDataGridViewTextBoxColumn.DataPropertyName = "روز هفته"
        Me.روزهفتهDataGridViewTextBoxColumn.HeaderText = "روز هفته"
        Me.روزهفتهDataGridViewTextBoxColumn.Name = "روزهفتهDataGridViewTextBoxColumn"
        Me.روزهفتهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ضریبDataGridViewTextBoxColumn
        '
        Me.ضریبDataGridViewTextBoxColumn.DataPropertyName = "ضریب"
        Me.ضریبDataGridViewTextBoxColumn.HeaderText = "ضریب"
        Me.ضریبDataGridViewTextBoxColumn.Name = "ضریبDataGridViewTextBoxColumn"
        Me.ضریبDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ازساعتDataGridViewTextBoxColumn
        '
        Me.ازساعتDataGridViewTextBoxColumn.DataPropertyName = "از ساعت"
        Me.ازساعتDataGridViewTextBoxColumn.HeaderText = "از ساعت"
        Me.ازساعتDataGridViewTextBoxColumn.Name = "ازساعتDataGridViewTextBoxColumn"
        Me.ازساعتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاساعتDataGridViewTextBoxColumn
        '
        Me.تاساعتDataGridViewTextBoxColumn.DataPropertyName = "تا ساعت"
        Me.تاساعتDataGridViewTextBoxColumn.HeaderText = "تا ساعت"
        Me.تاساعتDataGridViewTextBoxColumn.Name = "تاساعتDataGridViewTextBoxColumn"
        Me.تاساعتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نوعکارکردDataGridViewTextBoxColumn
        '
        Me.نوعکارکردDataGridViewTextBoxColumn.DataPropertyName = "نوع کارکرد"
        Me.نوعکارکردDataGridViewTextBoxColumn.HeaderText = "نوع کارکرد"
        Me.نوعکارکردDataGridViewTextBoxColumn.Name = "نوعکارکردDataGridViewTextBoxColumn"
        Me.نوعکارکردDataGridViewTextBoxColumn.ReadOnly = True
        Me.نوعکارکردDataGridViewTextBoxColumn.Visible = False
        '
        'IsTaradodDataGridViewCheckBoxColumn
        '
        Me.IsTaradodDataGridViewCheckBoxColumn.DataPropertyName = "IsTaradod"
        Me.IsTaradodDataGridViewCheckBoxColumn.HeaderText = "IsTaradod"
        Me.IsTaradodDataGridViewCheckBoxColumn.Name = "IsTaradodDataGridViewCheckBoxColumn"
        Me.IsTaradodDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsTaradodDataGridViewCheckBoxColumn.Visible = False
        '
        'بازهشروعDataGridViewCheckBoxColumn
        '
        Me.بازهشروعDataGridViewCheckBoxColumn.DataPropertyName = "بازه شروع"
        Me.بازهشروعDataGridViewCheckBoxColumn.HeaderText = "بازه شروع"
        Me.بازهشروعDataGridViewCheckBoxColumn.Name = "بازهشروعDataGridViewCheckBoxColumn"
        Me.بازهشروعDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PmWorkFormFormulaBindingSource
        '
        Me.PmWorkFormFormulaBindingSource.DataMember = "Pm_WorkForm_Formula"
        Me.PmWorkFormFormulaBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ضریب"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = "0"
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = True
        Me.TextBox1.Location = New System.Drawing.Point(146, 35)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(50, 26)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Tag = "Zarib"
        Me.TextBox1.Text = "0"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "از ساعت"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "تا ساعت"
        '
        'chk_BazeZamaniNotImportant
        '
        Me.chk_BazeZamaniNotImportant.AutoSize = True
        Me.chk_BazeZamaniNotImportant.Location = New System.Drawing.Point(132, 86)
        Me.chk_BazeZamaniNotImportant.Name = "chk_BazeZamaniNotImportant"
        Me.chk_BazeZamaniNotImportant.Size = New System.Drawing.Size(133, 22)
        Me.chk_BazeZamaniNotImportant.TabIndex = 4
        Me.chk_BazeZamaniNotImportant.Tag = "ImportantSat"
        Me.chk_BazeZamaniNotImportant.Text = "بازه شروع فعالیت"
        Me.chk_BazeZamaniNotImportant.UseVisualStyleBackColor = True
        '
        'cmb_Day
        '
        Me.cmb_Day.AutoComplete = True
        Me.cmb_Day.DataSource = Me.PmDayOfWeekBindingSource
        Me.cmb_Day.DisplayMember = "روز هفته"
        Me.cmb_Day.EnterStop = True
        Me.cmb_Day.FormattingEnabled = True
        Me.cmb_Day.IsRequired = False
        Me.cmb_Day.LimitedToList = True
        Me.cmb_Day.Location = New System.Drawing.Point(269, 35)
        Me.cmb_Day.Name = "cmb_Day"
        Me.cmb_Day.OpenOnFoucus = False
        Me.cmb_Day.Size = New System.Drawing.Size(155, 26)
        Me.cmb_Day.TabIndex = 1
        Me.cmb_Day.Tag = "Srl_DayOfWeak"
        Me.cmb_Day.ValueMember = "Srl"
        '
        'PmDayOfWeekBindingSource
        '
        Me.PmDayOfWeekBindingSource.DataMember = "Pm_DayOfWeek"
        Me.PmDayOfWeekBindingSource.DataSource = Me.Ds_Pm
        '
        'PmWorkTypeBindingSource
        '
        Me.PmWorkTypeBindingSource.DataMember = "Pm_WorkType"
        Me.PmWorkTypeBindingSource.DataSource = Me.Ds_Pm
        '
        'ts_ToSat
        '
        Me.ts_ToSat.Hour = "00"
        Me.ts_ToSat.HourMaxLen = 4
        Me.ts_ToSat.Location = New System.Drawing.Point(31, 5)
        Me.ts_ToSat.Margin = New System.Windows.Forms.Padding(4)
        Me.ts_ToSat.Minutes = "00"
        Me.ts_ToSat.Name = "ts_ToSat"
        Me.ts_ToSat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_ToSat.Second = "00"
        Me.ts_ToSat.Size = New System.Drawing.Size(77, 28)
        Me.ts_ToSat.TabIndex = 1
        Me.ts_ToSat.Tag = "ToSat"
        Me.ts_ToSat.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_ToSat.Value = "00:00:00"
        '
        'ts_FromSat
        '
        Me.ts_FromSat.Hour = "00"
        Me.ts_FromSat.HourMaxLen = 4
        Me.ts_FromSat.Location = New System.Drawing.Point(222, 6)
        Me.ts_FromSat.Margin = New System.Windows.Forms.Padding(4)
        Me.ts_FromSat.Minutes = "00"
        Me.ts_FromSat.Name = "ts_FromSat"
        Me.ts_FromSat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ts_FromSat.Second = "00"
        Me.ts_FromSat.Size = New System.Drawing.Size(77, 28)
        Me.ts_FromSat.TabIndex = 0
        Me.ts_FromSat.Tag = "FromSat"
        Me.ts_FromSat.time = System.TimeSpan.Parse("00:00:00")
        Me.ts_FromSat.Value = "00:00:00"
        '
        'Pm_DayOfWeekTableAdapter
        '
        Me.Pm_DayOfWeekTableAdapter.ClearBeforeFill = True
        '
        'Pm_WorkTypeTableAdapter
        '
        Me.Pm_WorkTypeTableAdapter.ClearBeforeFill = True
        '
        'pnl_TimeToTime
        '
        Me.pnl_TimeToTime.Controls.Add(Me.ts_ToSat)
        Me.pnl_TimeToTime.Controls.Add(Me.ts_FromSat)
        Me.pnl_TimeToTime.Controls.Add(Me.Label3)
        Me.pnl_TimeToTime.Controls.Add(Me.Label4)
        Me.pnl_TimeToTime.Location = New System.Drawing.Point(291, 70)
        Me.pnl_TimeToTime.Name = "pnl_TimeToTime"
        Me.pnl_TimeToTime.Size = New System.Drawing.Size(385, 38)
        Me.pnl_TimeToTime.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_ShowFormul)
        Me.Panel1.Location = New System.Drawing.Point(472, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(118, 40)
        Me.Panel1.TabIndex = 4
        '
        'Btn_ShowFormul
        '
        Me.Btn_ShowFormul.BackColor = System.Drawing.Color.Transparent
        Me.Btn_ShowFormul.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ShowFormul.HeaderText = "مشاهده فرمول"
        Me.Btn_ShowFormul.Location = New System.Drawing.Point(4, 4)
        Me.Btn_ShowFormul.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_ShowFormul.Name = "Btn_ShowFormul"
        Me.Btn_ShowFormul.Size = New System.Drawing.Size(112, 30)
        Me.Btn_ShowFormul.TabIndex = 0
        '
        'Pm_WorkForm_FormulaTableAdapter
        '
        Me.Pm_WorkForm_FormulaTableAdapter.ClearBeforeFill = True
        '
        'Cmb_Profile
        '
        Me.Cmb_Profile.AutoComplete = True
        Me.Cmb_Profile.DataSource = Me.PmWorkFormFormulaProfileBindingSource
        Me.Cmb_Profile.DisplayMember = "نام"
        Me.Cmb_Profile.EnterStop = True
        Me.Cmb_Profile.FormattingEnabled = True
        Me.Cmb_Profile.IsRequired = False
        Me.Cmb_Profile.LimitedToList = True
        Me.Cmb_Profile.Location = New System.Drawing.Point(516, 35)
        Me.Cmb_Profile.Name = "Cmb_Profile"
        Me.Cmb_Profile.OpenOnFoucus = False
        Me.Cmb_Profile.Size = New System.Drawing.Size(155, 26)
        Me.Cmb_Profile.TabIndex = 0
        Me.Cmb_Profile.Tag = "Srl_Pm_WorkForm_Formula_Profile"
        Me.Cmb_Profile.ValueMember = "Srl"
        '
        'PmWorkFormFormulaProfileBindingSource
        '
        Me.PmWorkFormFormulaProfileBindingSource.DataMember = "Pm_WorkForm_Formula_Profile"
        Me.PmWorkFormFormulaProfileBindingSource.DataSource = Me.Ds_Pm
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoComplete = True
        Me.ComboBox3.DataSource = Me.PmWorkTypeBindingSource
        Me.ComboBox3.DisplayMember = "نوع"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.EnterStop = True
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.IsRequired = False
        Me.ComboBox3.LimitedToList = True
        Me.ComboBox3.Location = New System.Drawing.Point(146, 24)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.OpenOnFoucus = False
        Me.ComboBox3.Size = New System.Drawing.Size(10, 26)
        Me.ComboBox3.TabIndex = 2
        Me.ComboBox3.Tag = "Srl_Pm_WorkType"
        Me.ComboBox3.ValueMember = "Srl"
        Me.ComboBox3.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(162, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "نوع کارکرد"
        Me.Label8.Visible = False
        '
        'Pm_WorkForm_Formula_ProfileTableAdapter
        '
        Me.Pm_WorkForm_Formula_ProfileTableAdapter.ClearBeforeFill = True
        '
        'Chk_Profile
        '
        Me.Chk_Profile.AutoSize = True
        Me.Chk_Profile.Location = New System.Drawing.Point(677, 38)
        Me.Chk_Profile.Name = "Chk_Profile"
        Me.Chk_Profile.Size = New System.Drawing.Size(68, 22)
        Me.Chk_Profile.TabIndex = 11
        Me.Chk_Profile.Text = "پروفایل"
        Me.Chk_Profile.UseVisualStyleBackColor = True
        '
        'chk_DayOfWeek
        '
        Me.chk_DayOfWeek.AutoSize = True
        Me.chk_DayOfWeek.Location = New System.Drawing.Point(430, 37)
        Me.chk_DayOfWeek.Name = "chk_DayOfWeek"
        Me.chk_DayOfWeek.Size = New System.Drawing.Size(80, 22)
        Me.chk_DayOfWeek.TabIndex = 12
        Me.chk_DayOfWeek.Text = "روز هفته"
        Me.chk_DayOfWeek.UseVisualStyleBackColor = True
        '
        'Frm_WorkForm_Formula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(870, 633)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_WorkForm_Formula"
        Me.TableName = "Pm_WorkForm_Formula"
        Me.Text = "ایجاد فرمول محاسبه فرم کار"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        Me.gbx_Btn.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmWorkFormFormulaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmDayOfWeekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmWorkTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_TimeToTime.ResumeLayout(False)
        Me.pnl_TimeToTime.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PmWorkFormFormulaProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_BazeZamaniNotImportant As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_Day As VB_Component.ComboBox
    Friend WithEvents ts_FromSat As VB_Component.TimeSelect
    Friend WithEvents ts_ToSat As VB_Component.TimeSelect
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmDayOfWeekBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_DayOfWeekTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_DayOfWeekTableAdapter
    Friend WithEvents PmWorkTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_WorkTypeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_WorkTypeTableAdapter
    Friend WithEvents pnl_TimeToTime As System.Windows.Forms.Panel
    Friend WithEvents مدلپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شرحکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_ShowFormul As CS_Component.Btn
    Friend WithEvents PmWorkFormFormulaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_WorkForm_FormulaTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_WorkForm_FormulaTableAdapter
    Friend WithEvents Cmb_Profile As VB_Component.ComboBox
    Friend WithEvents ComboBox3 As VB_Component.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PmWorkFormFormulaProfileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_WorkForm_Formula_ProfileTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_WorkForm_Formula_ProfileTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پروفایل As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents روزهفتهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ضریبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ازساعتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاساعتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعکارکردDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsTaradodDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents بازهشروعDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Chk_Profile As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DayOfWeek As System.Windows.Forms.CheckBox
End Class
