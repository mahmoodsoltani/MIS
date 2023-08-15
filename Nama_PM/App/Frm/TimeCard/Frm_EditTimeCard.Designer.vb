<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EditTimeCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EditTimeCard))
        Me.PMPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label1 = New System.Windows.Forms.Label
        Me.PmAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_BeginDate = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_Date = New CS_Component.TextBox
        Me.TimeSelect1 = New VB_Component.TimeSelect
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_EndDate = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TimeSelect2 = New VB_Component.TimeSelect
        Me.TimeSelect3 = New VB_Component.TimeSelect
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TimeSelect4 = New VB_Component.TimeSelect
        Me.TimeSelect5 = New VB_Component.TimeSelect
        Me.TimeSelect6 = New VB_Component.TimeSelect
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TimeSelect7 = New VB_Component.TimeSelect
        Me.TimeSelect8 = New VB_Component.TimeSelect
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TimeSelect9 = New VB_Component.TimeSelect
        Me.TimeSelect10 = New VB_Component.TimeSelect
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TimeSelect12 = New VB_Component.TimeSelect
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TimeSelect13 = New VB_Component.TimeSelect
        Me.TimeSelect14 = New VB_Component.TimeSelect
        Me.TextBox1 = New CS_Component.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.PmHazineCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PM_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.TimeSelect11 = New VB_Component.TimeSelect
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmashkhasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدهزینهDataGridViewTextBoxColumn = New VB_Component.ComboBoxColumn
        Me.محلفعالیتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ورودDataGridViewTextBoxColumn = New VB_Component.TimeColumn
        Me.خروجDataGridViewTextBoxColumn = New VB_Component.TimeColumn
        Me.کارکردDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn = New VB_Component.TimeColumn
        Me.مرخصیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ماموریتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاخیرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تعجیلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ورود1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.خروج1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ورود2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.خروج2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.وضعیتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تعطیلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ماموریتفرمکارDataGridViewTextBoxColumn = New VB_Component.TimeColumn
        Me.تعطیل = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmtimeCardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_TimeCard = New Nama_PM.Ds_TimeCard
        Me.PmPostBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_HazineCodeTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
        Me.Pm_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
        Me.Label22 = New System.Windows.Forms.Label
        Me.lb_Sum = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_ViewSave = New System.Windows.Forms.Button
        Me.lb_IsChanged = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txt_Number = New CS_Component.TextBox
        Me.Btn_SaveNumber = New System.Windows.Forms.Button
        Me.TextBox2 = New CS_Component.TextBox
        Me.RpTimeCardBasedNumberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_TimeCardBasedNumberTableAdapter = New Nama_PM.Ds_TimeCardTableAdapters.Rp_TimeCardBasedNumberTableAdapter
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.Acc_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
        Me.cmb_Ashkhas = New VB_Component.ComboBox
        Me.AccAshkhasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_PersonCode = New CS_Component.TextBox
        Me.btn_show = New System.Windows.Forms.Button
        Me.btn_Refresh = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_Before = New System.Windows.Forms.PictureBox
        Me.btn_Next = New System.Windows.Forms.PictureBox
        Me.Pm_timeCardTableAdapter = New Nama_PM.Ds_TimeCardTableAdapters.Pm_timeCardTableAdapter
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.TimeCardWorkFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeCard_WorkFormTableAdapter = New Nama_PM.Ds_RpTableAdapters.TimeCard_WorkFormTableAdapter
        Me.cmb_HazineCode = New VB_Component.ComboBox
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmtimeCardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_TimeCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RpTimeCardBasedNumberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Refresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeCardWorkFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(522, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "F2 ذخيره روز جدید"
        Me.btn_new.Location = New System.Drawing.Point(769, 17)
        Me.btn_new.Size = New System.Drawing.Size(154, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(646, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.btn_Refresh)
        Me.gbx_GridViewList.Controls.Add(Me.PictureBox1)
        Me.gbx_GridViewList.Controls.Add(Me.btn_show)
        Me.gbx_GridViewList.Controls.Add(Me.btn_Before)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_Ashkhas)
        Me.gbx_GridViewList.Controls.Add(Me.btn_Next)
        Me.gbx_GridViewList.Controls.Add(Me.Btn_SaveNumber)
        Me.gbx_GridViewList.Controls.Add(Me.txt_PersonCode)
        Me.gbx_GridViewList.Controls.Add(Me.txt_Number)
        Me.gbx_GridViewList.Controls.Add(Me.txt_EndDate)
        Me.gbx_GridViewList.Controls.Add(Me.txt_BeginDate)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Controls.Add(Me.lb_Sum)
        Me.gbx_GridViewList.Controls.Add(Me.Label22)
        Me.gbx_GridViewList.Controls.Add(Me.Label7)
        Me.gbx_GridViewList.Controls.Add(Me.Label5)
        Me.gbx_GridViewList.Controls.Add(Me.Label23)
        Me.gbx_GridViewList.Controls.Add(Me.Label4)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(929, 381)
        Me.gbx_GridViewList.TabIndex = 0
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.cmb_HazineCode)
        Me.gbx_Controls.Controls.Add(Me.TextBox2)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect8)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect12)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect14)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect10)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect6)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect11)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect7)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect3)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect13)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect9)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect5)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect2)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect4)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect1)
        Me.gbx_Controls.Controls.Add(Me.txt_Date)
        Me.gbx_Controls.Controls.Add(Me.Label13)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.Label16)
        Me.gbx_Controls.Controls.Add(Me.Label19)
        Me.gbx_Controls.Controls.Add(Me.Label18)
        Me.gbx_Controls.Controls.Add(Me.Label14)
        Me.gbx_Controls.Controls.Add(Me.Label11)
        Me.gbx_Controls.Controls.Add(Me.Label8)
        Me.gbx_Controls.Controls.Add(Me.Label12)
        Me.gbx_Controls.Controls.Add(Me.Label10)
        Me.gbx_Controls.Controls.Add(Me.Label15)
        Me.gbx_Controls.Controls.Add(Me.Label17)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label21)
        Me.gbx_Controls.Controls.Add(Me.Label20)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 484)
        Me.gbx_Controls.Size = New System.Drawing.Size(929, 210)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Controls.Add(Me.Panel1)
        Me.gbx_Btn.Controls.Add(Me.lb_IsChanged)
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 424)
        Me.gbx_Btn.Size = New System.Drawing.Size(929, 57)
        Me.gbx_Btn.Controls.SetChildIndex(Me.lb_IsChanged, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Panel1, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_new, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Cancel, 0)
        '
        'PMPostBindingSource
        '
        Me.PMPostBindingSource.DataMember = "PM_Post"
        Me.PMPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "اضافه کار اول وقت"
        '
        'PmAshkhasBindingSource
        '
        Me.PmAshkhasBindingSource.DataMember = "Pm_Ashkhas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(883, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "نام"
        '
        'txt_BeginDate
        '
        Me.txt_BeginDate.CheckExistValueInDb = False
        Me.txt_BeginDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_BeginDate.CurrencyUnit = "ریال"
        Me.txt_BeginDate.DefaultValue = ""
        Me.txt_BeginDate.FillWithMaxInDb = False
        Me.txt_BeginDate.IsRequired = True
        Me.txt_BeginDate.Location = New System.Drawing.Point(379, 58)
        Me.txt_BeginDate.MaxDecimalLength = 2
        Me.txt_BeginDate.Name = "txt_BeginDate"
        Me.txt_BeginDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_BeginDate.Size = New System.Drawing.Size(135, 25)
        Me.txt_BeginDate.SpellControl = Nothing
        Me.txt_BeginDate.TabIndex = 4
        Me.txt_BeginDate.TabStop = False
        Me.txt_BeginDate.Tag = ""
        Me.txt_BeginDate.Title = Nothing
        Me.txt_BeginDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_BeginDate.UseForData = True
        Me.txt_BeginDate.ValidateCheckExistOnEdit = False
        Me.txt_BeginDate.Value = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(520, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "از تاریخ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(852, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "تاریخ"
        '
        'txt_Date
        '
        Me.txt_Date.CheckExistValueInDb = False
        Me.txt_Date.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Date.CurrencyUnit = "ریال"
        Me.txt_Date.DefaultValue = ""
        Me.txt_Date.FillWithMaxInDb = False
        Me.txt_Date.IsRequired = True
        Me.txt_Date.Location = New System.Drawing.Point(697, 25)
        Me.txt_Date.MaxDecimalLength = 2
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Date.Size = New System.Drawing.Size(148, 25)
        Me.txt_Date.SpellControl = Nothing
        Me.txt_Date.TabIndex = 0
        Me.txt_Date.TabStop = False
        Me.txt_Date.Tag = "Tarikh"
        Me.txt_Date.Title = Nothing
        Me.txt_Date.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_Date.UseForData = True
        Me.txt_Date.ValidateCheckExistOnEdit = False
        Me.txt_Date.Value = ""
        '
        'TimeSelect1
        '
        Me.TimeSelect1.Hour = "0"
        Me.TimeSelect1.HourMaxLen = 2
        Me.TimeSelect1.Location = New System.Drawing.Point(516, 25)
        Me.TimeSelect1.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect1.Minutes = "0"
        Me.TimeSelect1.Name = "TimeSelect1"
        Me.TimeSelect1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect1.Second = "00"
        Me.TimeSelect1.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect1.TabIndex = 1
        Me.TimeSelect1.Tag = "AllWork"
        Me.TimeSelect1.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect1.Value = "00:00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(624, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "کل کارکرد"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(363, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "تا"
        '
        'txt_EndDate
        '
        Me.txt_EndDate.CheckExistValueInDb = False
        Me.txt_EndDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EndDate.CurrencyUnit = "ریال"
        Me.txt_EndDate.DefaultValue = ""
        Me.txt_EndDate.FillWithMaxInDb = False
        Me.txt_EndDate.IsRequired = True
        Me.txt_EndDate.Location = New System.Drawing.Point(226, 58)
        Me.txt_EndDate.MaxDecimalLength = 2
        Me.txt_EndDate.Name = "txt_EndDate"
        Me.txt_EndDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_EndDate.Size = New System.Drawing.Size(135, 25)
        Me.txt_EndDate.SpellControl = Nothing
        Me.txt_EndDate.TabIndex = 5
        Me.txt_EndDate.TabStop = False
        Me.txt_EndDate.Tag = ""
        Me.txt_EndDate.Title = Nothing
        Me.txt_EndDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_EndDate.UseForData = True
        Me.txt_EndDate.ValidateCheckExistOnEdit = False
        Me.txt_EndDate.Value = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(126, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "اضافه کار آخر وقت"
        '
        'TimeSelect2
        '
        Me.TimeSelect2.Hour = "0"
        Me.TimeSelect2.HourMaxLen = 2
        Me.TimeSelect2.Location = New System.Drawing.Point(267, 56)
        Me.TimeSelect2.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect2.Minutes = "0"
        Me.TimeSelect2.Name = "TimeSelect2"
        Me.TimeSelect2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect2.Second = "00"
        Me.TimeSelect2.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect2.TabIndex = 5
        Me.TimeSelect2.Tag = "BeginTimeExtraWork"
        Me.TimeSelect2.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect2.Value = "00:00"
        '
        'TimeSelect3
        '
        Me.TimeSelect3.Hour = "0"
        Me.TimeSelect3.HourMaxLen = 2
        Me.TimeSelect3.Location = New System.Drawing.Point(18, 56)
        Me.TimeSelect3.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect3.Minutes = "0"
        Me.TimeSelect3.Name = "TimeSelect3"
        Me.TimeSelect3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect3.Second = "00"
        Me.TimeSelect3.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect3.TabIndex = 6
        Me.TimeSelect3.Tag = "EndTimeExtraWork"
        Me.TimeSelect3.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect3.Value = "00:00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(867, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "مرخصی"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(624, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 18)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "اضافه کار روز تعطیل"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(624, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 18)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "ماموریت"
        '
        'TimeSelect4
        '
        Me.TimeSelect4.Hour = "0"
        Me.TimeSelect4.HourMaxLen = 2
        Me.TimeSelect4.Location = New System.Drawing.Point(516, 60)
        Me.TimeSelect4.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect4.Minutes = "0"
        Me.TimeSelect4.Name = "TimeSelect4"
        Me.TimeSelect4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect4.Second = "00"
        Me.TimeSelect4.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect4.TabIndex = 4
        Me.TimeSelect4.Tag = "HolidayExtraWork"
        Me.TimeSelect4.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect4.Value = "00:00"
        '
        'TimeSelect5
        '
        Me.TimeSelect5.Hour = "0"
        Me.TimeSelect5.HourMaxLen = 2
        Me.TimeSelect5.Location = New System.Drawing.Point(769, 93)
        Me.TimeSelect5.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect5.Minutes = "0"
        Me.TimeSelect5.Name = "TimeSelect5"
        Me.TimeSelect5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect5.Second = "00"
        Me.TimeSelect5.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect5.TabIndex = 7
        Me.TimeSelect5.Tag = "Morakhasi"
        Me.TimeSelect5.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect5.Value = "00:00"
        '
        'TimeSelect6
        '
        Me.TimeSelect6.Hour = "0"
        Me.TimeSelect6.HourMaxLen = 2
        Me.TimeSelect6.Location = New System.Drawing.Point(516, 93)
        Me.TimeSelect6.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect6.Minutes = "0"
        Me.TimeSelect6.Name = "TimeSelect6"
        Me.TimeSelect6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect6.Second = "00"
        Me.TimeSelect6.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect6.TabIndex = 8
        Me.TimeSelect6.Tag = "Mamoriyat"
        Me.TimeSelect6.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect6.Value = "00:00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(375, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 18)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "تاخیر"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(126, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 18)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "تعجیل"
        '
        'TimeSelect7
        '
        Me.TimeSelect7.Hour = "0"
        Me.TimeSelect7.HourMaxLen = 2
        Me.TimeSelect7.Location = New System.Drawing.Point(267, 93)
        Me.TimeSelect7.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect7.Minutes = "0"
        Me.TimeSelect7.Name = "TimeSelect7"
        Me.TimeSelect7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect7.Second = "00"
        Me.TimeSelect7.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect7.TabIndex = 9
        Me.TimeSelect7.Tag = "Takhir"
        Me.TimeSelect7.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect7.Value = "00:00"
        '
        'TimeSelect8
        '
        Me.TimeSelect8.Hour = "0"
        Me.TimeSelect8.HourMaxLen = 2
        Me.TimeSelect8.Location = New System.Drawing.Point(18, 93)
        Me.TimeSelect8.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect8.Minutes = "0"
        Me.TimeSelect8.Name = "TimeSelect8"
        Me.TimeSelect8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect8.Second = "00"
        Me.TimeSelect8.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect8.TabIndex = 10
        Me.TimeSelect8.Tag = "Tajil"
        Me.TimeSelect8.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect8.Value = "00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(867, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ورود1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(624, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 18)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "خروج1"
        '
        'TimeSelect9
        '
        Me.TimeSelect9.Hour = "0"
        Me.TimeSelect9.HourMaxLen = 2
        Me.TimeSelect9.Location = New System.Drawing.Point(769, 127)
        Me.TimeSelect9.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect9.Minutes = "0"
        Me.TimeSelect9.Name = "TimeSelect9"
        Me.TimeSelect9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect9.Second = "00"
        Me.TimeSelect9.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect9.TabIndex = 11
        Me.TimeSelect9.Tag = "EnterTime1"
        Me.TimeSelect9.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect9.Value = "00:00"
        '
        'TimeSelect10
        '
        Me.TimeSelect10.Hour = "0"
        Me.TimeSelect10.HourMaxLen = 2
        Me.TimeSelect10.Location = New System.Drawing.Point(516, 127)
        Me.TimeSelect10.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect10.Minutes = "0"
        Me.TimeSelect10.Name = "TimeSelect10"
        Me.TimeSelect10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect10.Second = "00"
        Me.TimeSelect10.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect10.TabIndex = 12
        Me.TimeSelect10.Tag = "ExitTime1"
        Me.TimeSelect10.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect10.Value = "00:00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(375, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 18)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "ورود2"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(126, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 18)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "خروج2"
        '
        'TimeSelect12
        '
        Me.TimeSelect12.Hour = "0"
        Me.TimeSelect12.HourMaxLen = 2
        Me.TimeSelect12.Location = New System.Drawing.Point(18, 130)
        Me.TimeSelect12.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect12.Minutes = "0"
        Me.TimeSelect12.Name = "TimeSelect12"
        Me.TimeSelect12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect12.Second = "00"
        Me.TimeSelect12.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect12.TabIndex = 14
        Me.TimeSelect12.Tag = "ExitTime2"
        Me.TimeSelect12.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect12.Value = "00:00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(867, 165)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 18)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "ورود3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(624, 165)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 18)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "خروج3"
        '
        'TimeSelect13
        '
        Me.TimeSelect13.Hour = "0"
        Me.TimeSelect13.HourMaxLen = 2
        Me.TimeSelect13.Location = New System.Drawing.Point(769, 162)
        Me.TimeSelect13.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect13.Minutes = "0"
        Me.TimeSelect13.Name = "TimeSelect13"
        Me.TimeSelect13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect13.Second = "00"
        Me.TimeSelect13.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect13.TabIndex = 15
        Me.TimeSelect13.Tag = "EnterTime3"
        Me.TimeSelect13.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect13.Value = "00:00"
        '
        'TimeSelect14
        '
        Me.TimeSelect14.Hour = "0"
        Me.TimeSelect14.HourMaxLen = 2
        Me.TimeSelect14.Location = New System.Drawing.Point(516, 162)
        Me.TimeSelect14.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect14.Minutes = "0"
        Me.TimeSelect14.Name = "TimeSelect14"
        Me.TimeSelect14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect14.Second = "00"
        Me.TimeSelect14.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect14.TabIndex = 16
        Me.TimeSelect14.Tag = "ExitTime3"
        Me.TimeSelect14.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect14.Value = "00:00"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(267, 165)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Tag = "Status"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(375, 168)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 18)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "وضعیت"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(403, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 18)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "محل ماموریت"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(184, 27)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 18)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "کد هزینه"
        '
        'PmHazineCodeBindingSource
        '
        Me.PmHazineCodeBindingSource.DataMember = "Pm_HazineCode"
        Me.PmHazineCodeBindingSource.DataSource = Me.Ds_Pm
        '
        'PM_PostTableAdapter
        '
        Me.PM_PostTableAdapter.ClearBeforeFill = True
        '
        'TimeSelect11
        '
        Me.TimeSelect11.Hour = "0"
        Me.TimeSelect11.HourMaxLen = 2
        Me.TimeSelect11.Location = New System.Drawing.Point(267, 127)
        Me.TimeSelect11.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeSelect11.Minutes = "0"
        Me.TimeSelect11.Name = "TimeSelect11"
        Me.TimeSelect11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect11.Second = "00"
        Me.TimeSelect11.Size = New System.Drawing.Size(74, 25)
        Me.TimeSelect11.TabIndex = 13
        Me.TimeSelect11.Tag = "EnterTime2"
        Me.TimeSelect11.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect11.Value = "00:00"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.SrlPmashkhasDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.کدهزینهDataGridViewTextBoxColumn, Me.محلفعالیتDataGridViewTextBoxColumn, Me.ورودDataGridViewTextBoxColumn, Me.خروجDataGridViewTextBoxColumn, Me.کارکردDataGridViewTextBoxColumn, Me.اضافهکاراولوقتDataGridViewTextBoxColumn, Me.اضافهکارآخروقتDataGridViewTextBoxColumn, Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn, Me.مرخصیDataGridViewTextBoxColumn, Me.ماموریتDataGridViewTextBoxColumn, Me.تاخیرDataGridViewTextBoxColumn, Me.تعجیلDataGridViewTextBoxColumn, Me.ورود1DataGridViewTextBoxColumn, Me.خروج1DataGridViewTextBoxColumn, Me.ورود2DataGridViewTextBoxColumn, Me.خروج2DataGridViewTextBoxColumn, Me.وضعیتDataGridViewTextBoxColumn, Me.تعطیلDataGridViewTextBoxColumn, Me.ماموریتفرمکارDataGridViewTextBoxColumn, Me.تعطیل})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmtimeCardBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(18, 90)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(900, 288)
        Me.DataGridView1.TabIndex = 6
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'SrlPmashkhasDataGridViewTextBoxColumn
        '
        Me.SrlPmashkhasDataGridViewTextBoxColumn.DataPropertyName = "Srl_Pm_ashkhas"
        Me.SrlPmashkhasDataGridViewTextBoxColumn.HeaderText = "Srl_Pm_ashkhas"
        Me.SrlPmashkhasDataGridViewTextBoxColumn.Name = "SrlPmashkhasDataGridViewTextBoxColumn"
        Me.SrlPmashkhasDataGridViewTextBoxColumn.Visible = False
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        '
        'کدهزینهDataGridViewTextBoxColumn
        '
        Me.کدهزینهDataGridViewTextBoxColumn.DataPropertyName = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.DataSource = Me.PmHazineCodeBindingSource
        Me.کدهزینهDataGridViewTextBoxColumn.DisplayMember = "کد"
        Me.کدهزینهDataGridViewTextBoxColumn.HeaderText = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.Name = "کدهزینهDataGridViewTextBoxColumn"
        Me.کدهزینهDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.کدهزینهDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.کدهزینهDataGridViewTextBoxColumn.ValueMember = "کد"
        Me.کدهزینهDataGridViewTextBoxColumn.Width = 120
        '
        'محلفعالیتDataGridViewTextBoxColumn
        '
        Me.محلفعالیتDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.محلفعالیتDataGridViewTextBoxColumn.DataPropertyName = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.HeaderText = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.Name = "محلفعالیتDataGridViewTextBoxColumn"
        Me.محلفعالیتDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ورودDataGridViewTextBoxColumn
        '
        Me.ورودDataGridViewTextBoxColumn.DataPropertyName = "ورود"
        Me.ورودDataGridViewTextBoxColumn.HeaderText = "ورود"
        Me.ورودDataGridViewTextBoxColumn.Name = "ورودDataGridViewTextBoxColumn"
        Me.ورودDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ورودDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'خروجDataGridViewTextBoxColumn
        '
        Me.خروجDataGridViewTextBoxColumn.DataPropertyName = "خروج"
        Me.خروجDataGridViewTextBoxColumn.HeaderText = "خروج"
        Me.خروجDataGridViewTextBoxColumn.Name = "خروجDataGridViewTextBoxColumn"
        Me.خروجDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.خروجDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'کارکردDataGridViewTextBoxColumn
        '
        Me.کارکردDataGridViewTextBoxColumn.DataPropertyName = "کارکرد"
        Me.کارکردDataGridViewTextBoxColumn.HeaderText = "کارکرد"
        Me.کارکردDataGridViewTextBoxColumn.Name = "کارکردDataGridViewTextBoxColumn"
        Me.کارکردDataGridViewTextBoxColumn.Visible = False
        '
        'اضافهکاراولوقتDataGridViewTextBoxColumn
        '
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار اول وقت"
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn.HeaderText = "اضافه کار اول وقت"
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn.Name = "اضافهکاراولوقتDataGridViewTextBoxColumn"
        Me.اضافهکاراولوقتDataGridViewTextBoxColumn.Visible = False
        '
        'اضافهکارآخروقتDataGridViewTextBoxColumn
        '
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار آخر وقت"
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn.HeaderText = "اضافه کار آخر وقت"
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn.Name = "اضافهکارآخروقتDataGridViewTextBoxColumn"
        Me.اضافهکارآخروقتDataGridViewTextBoxColumn.Visible = False
        '
        'اضافهکارروزتعطیلDataGridViewTextBoxColumn
        '
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار روز تعطیل"
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.HeaderText = "اضافه کار"
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.Name = "اضافهکارروزتعطیلDataGridViewTextBoxColumn"
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.اضافهکارروزتعطیلDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'مرخصیDataGridViewTextBoxColumn
        '
        Me.مرخصیDataGridViewTextBoxColumn.DataPropertyName = "مرخصی"
        Me.مرخصیDataGridViewTextBoxColumn.HeaderText = "مرخصی"
        Me.مرخصیDataGridViewTextBoxColumn.Name = "مرخصیDataGridViewTextBoxColumn"
        Me.مرخصیDataGridViewTextBoxColumn.Visible = False
        '
        'ماموریتDataGridViewTextBoxColumn
        '
        Me.ماموریتDataGridViewTextBoxColumn.DataPropertyName = "ماموریت"
        Me.ماموریتDataGridViewTextBoxColumn.HeaderText = "ماموریت"
        Me.ماموریتDataGridViewTextBoxColumn.Name = "ماموریتDataGridViewTextBoxColumn"
        Me.ماموریتDataGridViewTextBoxColumn.Visible = False
        '
        'تاخیرDataGridViewTextBoxColumn
        '
        Me.تاخیرDataGridViewTextBoxColumn.DataPropertyName = "تاخیر"
        Me.تاخیرDataGridViewTextBoxColumn.HeaderText = "تاخیر"
        Me.تاخیرDataGridViewTextBoxColumn.Name = "تاخیرDataGridViewTextBoxColumn"
        Me.تاخیرDataGridViewTextBoxColumn.Visible = False
        '
        'تعجیلDataGridViewTextBoxColumn
        '
        Me.تعجیلDataGridViewTextBoxColumn.DataPropertyName = "تعجیل"
        Me.تعجیلDataGridViewTextBoxColumn.HeaderText = "تعجیل"
        Me.تعجیلDataGridViewTextBoxColumn.Name = "تعجیلDataGridViewTextBoxColumn"
        Me.تعجیلDataGridViewTextBoxColumn.Visible = False
        '
        'ورود1DataGridViewTextBoxColumn
        '
        Me.ورود1DataGridViewTextBoxColumn.DataPropertyName = "ورود1"
        Me.ورود1DataGridViewTextBoxColumn.HeaderText = "ورود1"
        Me.ورود1DataGridViewTextBoxColumn.Name = "ورود1DataGridViewTextBoxColumn"
        Me.ورود1DataGridViewTextBoxColumn.Visible = False
        '
        'خروج1DataGridViewTextBoxColumn
        '
        Me.خروج1DataGridViewTextBoxColumn.DataPropertyName = "خروج1"
        Me.خروج1DataGridViewTextBoxColumn.HeaderText = "خروج1"
        Me.خروج1DataGridViewTextBoxColumn.Name = "خروج1DataGridViewTextBoxColumn"
        Me.خروج1DataGridViewTextBoxColumn.Visible = False
        '
        'ورود2DataGridViewTextBoxColumn
        '
        Me.ورود2DataGridViewTextBoxColumn.DataPropertyName = "ورود2"
        Me.ورود2DataGridViewTextBoxColumn.HeaderText = "ورود2"
        Me.ورود2DataGridViewTextBoxColumn.Name = "ورود2DataGridViewTextBoxColumn"
        Me.ورود2DataGridViewTextBoxColumn.Visible = False
        '
        'خروج2DataGridViewTextBoxColumn
        '
        Me.خروج2DataGridViewTextBoxColumn.DataPropertyName = "خروج2"
        Me.خروج2DataGridViewTextBoxColumn.HeaderText = "خروج2"
        Me.خروج2DataGridViewTextBoxColumn.Name = "خروج2DataGridViewTextBoxColumn"
        Me.خروج2DataGridViewTextBoxColumn.Visible = False
        '
        'وضعیتDataGridViewTextBoxColumn
        '
        Me.وضعیتDataGridViewTextBoxColumn.DataPropertyName = "وضعیت"
        Me.وضعیتDataGridViewTextBoxColumn.HeaderText = "وضعیت"
        Me.وضعیتDataGridViewTextBoxColumn.Name = "وضعیتDataGridViewTextBoxColumn"
        Me.وضعیتDataGridViewTextBoxColumn.Visible = False
        '
        'تعطیلDataGridViewTextBoxColumn
        '
        Me.تعطیلDataGridViewTextBoxColumn.DataPropertyName = "تعطیل"
        Me.تعطیلDataGridViewTextBoxColumn.HeaderText = "تعطیل"
        Me.تعطیلDataGridViewTextBoxColumn.Name = "تعطیلDataGridViewTextBoxColumn"
        Me.تعطیلDataGridViewTextBoxColumn.ReadOnly = True
        Me.تعطیلDataGridViewTextBoxColumn.Visible = False
        '
        'ماموریتفرمکارDataGridViewTextBoxColumn
        '
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.DataPropertyName = "ماموریت فرم کار"
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.HeaderText = "ماموریت"
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.Name = "ماموریتفرمکارDataGridViewTextBoxColumn"
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ماموریتفرمکارDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'تعطیل
        '
        Me.تعطیل.DataPropertyName = "تعطیل"
        Me.تعطیل.HeaderText = "ت"
        Me.تعطیل.Name = "تعطیل"
        Me.تعطیل.ReadOnly = True
        Me.تعطیل.Width = 30
        '
        'PmtimeCardBindingSource
        '
        Me.PmtimeCardBindingSource.DataMember = "Pm_timeCard"
        Me.PmtimeCardBindingSource.DataSource = Me.Ds_TimeCard
        '
        'Ds_TimeCard
        '
        Me.Ds_TimeCard.DataSetName = "Ds_TimeCard"
        Me.Ds_TimeCard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmPostBindingSource1
        '
        Me.PmPostBindingSource1.DataMember = "Pm_Post"
        Me.PmPostBindingSource1.DataSource = Me.Ds_Pm
        '
        'Pm_HazineCodeTableAdapter
        '
        Me.Pm_HazineCodeTableAdapter.ClearBeforeFill = True
        '
        'Pm_AshkhasTableAdapter
        '
        Me.Pm_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(79, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 18)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "جمع کل:"
        '
        'lb_Sum
        '
        Me.lb_Sum.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lb_Sum.ForeColor = System.Drawing.Color.Green
        Me.lb_Sum.Location = New System.Drawing.Point(6, 60)
        Me.lb_Sum.Name = "lb_Sum"
        Me.lb_Sum.Size = New System.Drawing.Size(71, 18)
        Me.lb_Sum.TabIndex = 3
        Me.lb_Sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Btn_ViewSave)
        Me.Panel1.Location = New System.Drawing.Point(385, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(134, 33)
        Me.Panel1.TabIndex = 4
        '
        'Btn_ViewSave
        '
        Me.Btn_ViewSave.Location = New System.Drawing.Point(3, 3)
        Me.Btn_ViewSave.Name = "Btn_ViewSave"
        Me.Btn_ViewSave.Size = New System.Drawing.Size(127, 30)
        Me.Btn_ViewSave.TabIndex = 0
        Me.Btn_ViewSave.Text = "محاسبه مجدد"
        Me.Btn_ViewSave.UseVisualStyleBackColor = True
        '
        'lb_IsChanged
        '
        Me.lb_IsChanged.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_IsChanged.Location = New System.Drawing.Point(102, 26)
        Me.lb_IsChanged.Name = "lb_IsChanged"
        Me.lb_IsChanged.Size = New System.Drawing.Size(239, 18)
        Me.lb_IsChanged.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(873, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 18)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "شماره"
        '
        'txt_Number
        '
        Me.txt_Number.CheckExistValueInDb = False
        Me.txt_Number.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Number.CurrencyUnit = "ریال"
        Me.txt_Number.DefaultValue = ""
        Me.txt_Number.FillWithMaxInDb = False
        Me.txt_Number.IsRequired = False
        Me.txt_Number.Location = New System.Drawing.Point(798, 24)
        Me.txt_Number.MaxDecimalLength = 2
        Me.txt_Number.Name = "txt_Number"
        Me.txt_Number.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Number.Size = New System.Drawing.Size(69, 25)
        Me.txt_Number.SpellControl = Nothing
        Me.txt_Number.TabIndex = 0
        Me.txt_Number.Tag = "Status"
        Me.txt_Number.Text = "0"
        Me.txt_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Number.Title = Nothing
        Me.txt_Number.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Number.UseForData = True
        Me.txt_Number.ValidateCheckExistOnEdit = False
        Me.txt_Number.Value = 0
        '
        'Btn_SaveNumber
        '
        Me.Btn_SaveNumber.Location = New System.Drawing.Point(522, 21)
        Me.Btn_SaveNumber.Name = "Btn_SaveNumber"
        Me.Btn_SaveNumber.Size = New System.Drawing.Size(104, 26)
        Me.Btn_SaveNumber.TabIndex = 2
        Me.Btn_SaveNumber.Text = "ذخیره شماره"
        Me.Btn_SaveNumber.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.CheckExistValueInDb = False
        Me.TextBox2.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox2.CurrencyUnit = "ریال"
        Me.TextBox2.DefaultValue = ""
        Me.TextBox2.FillWithMaxInDb = False
        Me.TextBox2.IsRequired = False
        Me.TextBox2.Location = New System.Drawing.Point(267, 27)
        Me.TextBox2.MaxDecimalLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(128, 25)
        Me.TextBox2.SpellControl = Nothing
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Tag = "ActivityPlace"
        Me.TextBox2.Title = Nothing
        Me.TextBox2.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox2.UseForData = True
        Me.TextBox2.ValidateCheckExistOnEdit = False
        Me.TextBox2.Value = ""
        '
        'RpTimeCardBasedNumberBindingSource
        '
        Me.RpTimeCardBasedNumberBindingSource.DataMember = "Rp_TimeCardBasedNumber"
        Me.RpTimeCardBasedNumberBindingSource.DataSource = Me.Ds_TimeCard
        '
        'Rp_TimeCardBasedNumberTableAdapter
        '
        Me.Rp_TimeCardBasedNumberTableAdapter.ClearBeforeFill = True
        '
        'AccAshkhasBindingSource
        '
        Me.AccAshkhasBindingSource.DataMember = "Acc_Ashkhas"
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Acc_AshkhasTableAdapter
        '
        Me.Acc_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'cmb_Ashkhas
        '
        Me.cmb_Ashkhas.AutoComplete = True
        Me.cmb_Ashkhas.DataSource = Me.AccAshkhasBindingSource1
        Me.cmb_Ashkhas.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Ashkhas.EnterStop = True
        Me.cmb_Ashkhas.FormattingEnabled = True
        Me.cmb_Ashkhas.IsRequired = False
        Me.cmb_Ashkhas.LimitedToList = True
        Me.cmb_Ashkhas.Location = New System.Drawing.Point(647, 58)
        Me.cmb_Ashkhas.Name = "cmb_Ashkhas"
        Me.cmb_Ashkhas.OpenOnFoucus = False
        Me.cmb_Ashkhas.Size = New System.Drawing.Size(220, 26)
        Me.cmb_Ashkhas.TabIndex = 7
        Me.cmb_Ashkhas.ValueMember = "Srl"
        '
        'AccAshkhasBindingSource1
        '
        Me.AccAshkhasBindingSource1.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource1.DataSource = Me.Ds_Ashkhas
        '
        'txt_PersonCode
        '
        Me.txt_PersonCode.CheckExistValueInDb = False
        Me.txt_PersonCode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_PersonCode.CurrencyUnit = "ریال"
        Me.txt_PersonCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccAshkhasBindingSource1, "کد پرسنلی", True))
        Me.txt_PersonCode.DefaultValue = ""
        Me.txt_PersonCode.FillWithMaxInDb = False
        Me.txt_PersonCode.IsRequired = False
        Me.txt_PersonCode.Location = New System.Drawing.Point(576, 58)
        Me.txt_PersonCode.MaxDecimalLength = 2
        Me.txt_PersonCode.Name = "txt_PersonCode"
        Me.txt_PersonCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_PersonCode.Size = New System.Drawing.Size(69, 25)
        Me.txt_PersonCode.SpellControl = Nothing
        Me.txt_PersonCode.TabIndex = 0
        Me.txt_PersonCode.Tag = ""
        Me.txt_PersonCode.Text = "0"
        Me.txt_PersonCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_PersonCode.Title = Nothing
        Me.txt_PersonCode.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_PersonCode.UseForData = True
        Me.txt_PersonCode.ValidateCheckExistOnEdit = False
        Me.txt_PersonCode.Value = 0
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(148, 58)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(75, 26)
        Me.btn_show.TabIndex = 8
        Me.btn_show.Text = "نمایش"
        Me.btn_show.UseVisualStyleBackColor = True
        '
        'btn_Refresh
        '
        Me.btn_Refresh.BackgroundImage = Global.Nama_PM.My.Resources.Resources.refresh
        Me.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Refresh.Location = New System.Drawing.Point(717, 20)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(32, 29)
        Me.btn_Refresh.TabIndex = 124
        Me.btn_Refresh.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(755, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        '
        'btn_Before
        '
        Me.btn_Before.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Before.Image = CType(resources.GetObject("btn_Before.Image"), System.Drawing.Image)
        Me.btn_Before.Location = New System.Drawing.Point(681, 20)
        Me.btn_Before.Name = "btn_Before"
        Me.btn_Before.Size = New System.Drawing.Size(30, 29)
        Me.btn_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Before.TabIndex = 122
        Me.btn_Before.TabStop = False
        '
        'btn_Next
        '
        Me.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next.Image = CType(resources.GetObject("btn_Next.Image"), System.Drawing.Image)
        Me.btn_Next.Location = New System.Drawing.Point(643, 21)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(32, 28)
        Me.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Next.TabIndex = 121
        Me.btn_Next.TabStop = False
        '
        'Pm_timeCardTableAdapter
        '
        Me.Pm_timeCardTableAdapter.ClearBeforeFill = True
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimeCardWorkFormBindingSource
        '
        Me.TimeCardWorkFormBindingSource.DataMember = "TimeCard_WorkForm"
        Me.TimeCardWorkFormBindingSource.DataSource = Me.Ds_Rp
        '
        'TimeCard_WorkFormTableAdapter
        '
        Me.TimeCard_WorkFormTableAdapter.ClearBeforeFill = True
        '
        'cmb_HazineCode
        '
        Me.cmb_HazineCode.AutoComplete = True
        Me.cmb_HazineCode.DataSource = Me.PmHazineCodeBindingSource
        Me.cmb_HazineCode.DisplayMember = "کد"
        Me.cmb_HazineCode.EnterStop = True
        Me.cmb_HazineCode.FormattingEnabled = True
        Me.cmb_HazineCode.IsRequired = False
        Me.cmb_HazineCode.LimitedToList = True
        Me.cmb_HazineCode.Location = New System.Drawing.Point(16, 25)
        Me.cmb_HazineCode.Name = "cmb_HazineCode"
        Me.cmb_HazineCode.OpenOnFoucus = True
        Me.cmb_HazineCode.Size = New System.Drawing.Size(152, 26)
        Me.cmb_HazineCode.TabIndex = 18
        Me.cmb_HazineCode.Tag = "Srl_Pm_CodeHaizne"
        Me.cmb_HazineCode.ValueMember = "Srl"
        '
        'Frm_EditTimeCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 726)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_EditTimeCard"
        Me.TableName = "Pm_TimeCard"
        Me.Text = "ویرایش اطلاعات تایم کارت"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.PMPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHazineCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmtimeCardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_TimeCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RpTimeCardBasedNumberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Refresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeCardWorkFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_BeginDate As CS_Component.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Date As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TimeSelect1 As VB_Component.TimeSelect
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_EndDate As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TimeSelect8 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect6 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect7 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect3 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect5 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect2 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect4 As VB_Component.TimeSelect
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TimeSelect12 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect14 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect10 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect13 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect9 As VB_Component.TimeSelect
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Ds_TimeCard As Nama_PM.Ds_TimeCard
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TimeSelect11 As VB_Component.TimeSelect
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents PmHazineCodeBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents اضافهکارآخروقتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TsCol As New VB_Component.TimeColumn
    Friend WithEvents PmAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents lb_Sum As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_ViewSave As System.Windows.Forms.Button
    Friend WithEvents lb_IsChanged As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Btn_SaveNumber As System.Windows.Forms.Button
    Friend WithEvents txt_Number As CS_Component.TextBox
    Friend WithEvents RpTimeCardBasedNumberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_TimeCardBasedNumberTableAdapter As Nama_PM.Ds_TimeCardTableAdapters.Rp_TimeCardBasedNumberTableAdapter
    Friend WithEvents TextBox2 As CS_Component.TextBox
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents cmb_Ashkhas As VB_Component.ComboBox
    Friend WithEvents AccAshkhasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txt_PersonCode As CS_Component.TextBox
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents btn_Refresh As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Before As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Next As System.Windows.Forms.PictureBox
    Friend WithEvents PmtimeCardBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_timeCardTableAdapter As Nama_PM.Ds_TimeCardTableAdapters.Pm_timeCardTableAdapter
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents TimeCardWorkFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TimeCard_WorkFormTableAdapter As Nama_PM.Ds_RpTableAdapters.TimeCard_WorkFormTableAdapter
    Private WithEvents PM_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Private WithEvents Pm_HazineCodeTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_HazineCodeTableAdapter
    Friend WithEvents PmPostBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmashkhasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدهزینهDataGridViewTextBoxColumn As VB_Component.ComboBoxColumn
    Friend WithEvents محلفعالیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ورودDataGridViewTextBoxColumn As VB_Component.TimeColumn
    Friend WithEvents خروجDataGridViewTextBoxColumn As VB_Component.TimeColumn
    Friend WithEvents کارکردDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکاراولوقتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکارآخروقتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکارروزتعطیلDataGridViewTextBoxColumn As VB_Component.TimeColumn
    Friend WithEvents مرخصیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ماموریتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاخیرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعجیلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ورود1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents خروج1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ورود2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents خروج2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents وضعیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعطیلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ماموریتفرمکارDataGridViewTextBoxColumn As VB_Component.TimeColumn
    Friend WithEvents تعطیل As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_HazineCode As VB_Component.ComboBox

End Class
