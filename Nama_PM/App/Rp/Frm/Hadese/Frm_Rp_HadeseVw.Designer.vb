<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_HadeseVw
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
        Me.cmb_Line = New VB_Component.ComboBox
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.chk_Line = New System.Windows.Forms.CheckBox
        Me.txt_EghdamatAvalie = New CS_Component.TextBox
        Me.chk_EghdamatAvalie = New System.Windows.Forms.CheckBox
        Me.chk_Group = New System.Windows.Forms.CheckBox
        Me.cmb_Group = New VB_Component.ComboBox
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_AmalKArdSystemHefazati = New VB_Component.ComboBox
        Me.PmHadeseAmalkardSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.chk_AmalKArdSystemHefazati = New System.Windows.Forms.CheckBox
        Me.cmb_Mahal = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_Mahal = New System.Windows.Forms.CheckBox
        Me.cmb_SharayeteBoroz = New VB_Component.ComboBox
        Me.PmHadeseSharayetBorozBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_SharayeteBoroz = New System.Windows.Forms.CheckBox
        Me.cmb_Elat = New VB_Component.ComboBox
        Me.PmHadeseElatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chk_Elat = New System.Windows.Forms.CheckBox
        Me.chk_ReportNo = New System.Windows.Forms.CheckBox
        Me.txt_ReportNo = New CS_Component.TextBox
        Me.txt_ElatGostaresh = New CS_Component.TextBox
        Me.chk_ElatGostaresh = New System.Windows.Forms.CheckBox
        Me.txt_KalamatKelidi = New CS_Component.TextBox
        Me.chk_KalamatKelidi = New System.Windows.Forms.CheckBox
        Me.txt_NatijeBarasi = New CS_Component.TextBox
        Me.txt_DastorModir = New CS_Component.TextBox
        Me.chk_NatijeBarasi = New System.Windows.Forms.CheckBox
        Me.chk_DastorModir = New System.Windows.Forms.CheckBox
        Me.txt_SHarhHadese = New CS_Component.TextBox
        Me.chk_SHarhHadese = New System.Windows.Forms.CheckBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chk_allday = New System.Windows.Forms.CheckBox
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.PmHadeseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_PrintAll = New CS_Component.Btn
        Me.lbl_Record = New System.Windows.Forms.Label
        Me.Btn_print = New CS_Component.Btn
        Me.Btn_Edit = New CS_Component.Btn
        Me.Btn_Search = New CS_Component.Btn
        Me.Pm_HadeseTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_HadeseTableAdapter
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.RpHadeseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_HadeseTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Rp_HadeseTableAdapter
        Me.Pm_Hadese_SharayetBorozTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_SharayetBorozTableAdapter
        Me.Pm_Hadese_AmalkardSystemTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_AmalkardSystemTableAdapter
        Me.Pm_Hadese_ElatTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_ElatTableAdapter
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهگزارشDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلوقوعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهگزارشDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلوقوعDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامخطDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.علتبروزحادثهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ثبتکنندهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseAmalkardSystemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseSharayetBorozBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseElatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RpHadeseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmb_Line)
        Me.GroupBox1.Controls.Add(Me.chk_Line)
        Me.GroupBox1.Controls.Add(Me.txt_EghdamatAvalie)
        Me.GroupBox1.Controls.Add(Me.chk_EghdamatAvalie)
        Me.GroupBox1.Controls.Add(Me.chk_Group)
        Me.GroupBox1.Controls.Add(Me.cmb_Group)
        Me.GroupBox1.Controls.Add(Me.cmb_AmalKArdSystemHefazati)
        Me.GroupBox1.Controls.Add(Me.chk_AmalKArdSystemHefazati)
        Me.GroupBox1.Controls.Add(Me.cmb_Mahal)
        Me.GroupBox1.Controls.Add(Me.chk_Mahal)
        Me.GroupBox1.Controls.Add(Me.cmb_SharayeteBoroz)
        Me.GroupBox1.Controls.Add(Me.chk_SharayeteBoroz)
        Me.GroupBox1.Controls.Add(Me.cmb_Elat)
        Me.GroupBox1.Controls.Add(Me.Chk_Elat)
        Me.GroupBox1.Controls.Add(Me.chk_ReportNo)
        Me.GroupBox1.Controls.Add(Me.txt_ReportNo)
        Me.GroupBox1.Controls.Add(Me.txt_ElatGostaresh)
        Me.GroupBox1.Controls.Add(Me.chk_ElatGostaresh)
        Me.GroupBox1.Controls.Add(Me.txt_KalamatKelidi)
        Me.GroupBox1.Controls.Add(Me.chk_KalamatKelidi)
        Me.GroupBox1.Controls.Add(Me.txt_NatijeBarasi)
        Me.GroupBox1.Controls.Add(Me.txt_DastorModir)
        Me.GroupBox1.Controls.Add(Me.chk_NatijeBarasi)
        Me.GroupBox1.Controls.Add(Me.chk_DastorModir)
        Me.GroupBox1.Controls.Add(Me.txt_SHarhHadese)
        Me.GroupBox1.Controls.Add(Me.chk_SHarhHadese)
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
        'cmb_Line
        '
        Me.cmb_Line.AutoComplete = True
        Me.cmb_Line.DataSource = Me.PmLineBindingSource
        Me.cmb_Line.DisplayMember = "نام"
        Me.cmb_Line.Enabled = False
        Me.cmb_Line.EnterStop = True
        Me.cmb_Line.FormattingEnabled = True
        Me.cmb_Line.IsRequired = False
        Me.cmb_Line.LimitedToList = True
        Me.cmb_Line.Location = New System.Drawing.Point(11, 56)
        Me.cmb_Line.Name = "cmb_Line"
        Me.cmb_Line.OpenOnFoucus = True
        Me.cmb_Line.Size = New System.Drawing.Size(170, 26)
        Me.cmb_Line.TabIndex = 199
        Me.cmb_Line.ValueMember = "Srl"
        '
        'PmLineBindingSource
        '
        Me.PmLineBindingSource.DataMember = "Pm_Line"
        Me.PmLineBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_Line
        '
        Me.chk_Line.AutoSize = True
        Me.chk_Line.Checked = True
        Me.chk_Line.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Line.Location = New System.Drawing.Point(187, 58)
        Me.chk_Line.Name = "chk_Line"
        Me.chk_Line.Size = New System.Drawing.Size(118, 22)
        Me.chk_Line.TabIndex = 198
        Me.chk_Line.Text = "خط حادثه دیده"
        Me.chk_Line.UseVisualStyleBackColor = True
        '
        'txt_EghdamatAvalie
        '
        Me.txt_EghdamatAvalie.CheckExistValueInDb = True
        Me.txt_EghdamatAvalie.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_EghdamatAvalie.CurrencyUnit = "ریال"
        Me.txt_EghdamatAvalie.DefaultValue = ""
        Me.txt_EghdamatAvalie.Enabled = False
        Me.txt_EghdamatAvalie.FillWithMaxInDb = False
        Me.txt_EghdamatAvalie.IsRequired = True
        Me.txt_EghdamatAvalie.Location = New System.Drawing.Point(512, 189)
        Me.txt_EghdamatAvalie.MaxDecimalLength = 2
        Me.txt_EghdamatAvalie.Multiline = True
        Me.txt_EghdamatAvalie.Name = "txt_EghdamatAvalie"
        Me.txt_EghdamatAvalie.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_EghdamatAvalie.Size = New System.Drawing.Size(360, 54)
        Me.txt_EghdamatAvalie.SpellControl = Nothing
        Me.txt_EghdamatAvalie.TabIndex = 197
        Me.txt_EghdamatAvalie.Tag = ""
        Me.txt_EghdamatAvalie.Title = Nothing
        Me.txt_EghdamatAvalie.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_EghdamatAvalie.UseForData = True
        Me.txt_EghdamatAvalie.ValidateCheckExistOnEdit = False
        Me.txt_EghdamatAvalie.Value = ""
        '
        'chk_EghdamatAvalie
        '
        Me.chk_EghdamatAvalie.AutoSize = True
        Me.chk_EghdamatAvalie.Checked = True
        Me.chk_EghdamatAvalie.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_EghdamatAvalie.Location = New System.Drawing.Point(871, 204)
        Me.chk_EghdamatAvalie.Name = "chk_EghdamatAvalie"
        Me.chk_EghdamatAvalie.Size = New System.Drawing.Size(106, 22)
        Me.chk_EghdamatAvalie.TabIndex = 196
        Me.chk_EghdamatAvalie.Text = "اقدامات اولیه"
        Me.chk_EghdamatAvalie.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chk_EghdamatAvalie.UseVisualStyleBackColor = True
        '
        'chk_Group
        '
        Me.chk_Group.AutoSize = True
        Me.chk_Group.Checked = True
        Me.chk_Group.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Group.Location = New System.Drawing.Point(581, 98)
        Me.chk_Group.Name = "chk_Group"
        Me.chk_Group.Size = New System.Drawing.Size(108, 22)
        Me.chk_Group.TabIndex = 195
        Me.chk_Group.Text = "ارجاع به گروه"
        Me.chk_Group.UseVisualStyleBackColor = True
        '
        'cmb_Group
        '
        Me.cmb_Group.AutoComplete = True
        Me.cmb_Group.DataSource = Me.PmGroupBindingSource
        Me.cmb_Group.DisplayMember = "نام"
        Me.cmb_Group.Enabled = False
        Me.cmb_Group.EnterStop = True
        Me.cmb_Group.FormattingEnabled = True
        Me.cmb_Group.IsRequired = False
        Me.cmb_Group.LimitedToList = True
        Me.cmb_Group.Location = New System.Drawing.Point(417, 95)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.OpenOnFoucus = True
        Me.cmb_Group.Size = New System.Drawing.Size(158, 26)
        Me.cmb_Group.TabIndex = 194
        Me.cmb_Group.ValueMember = "Srl"
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_AmalKArdSystemHefazati
        '
        Me.cmb_AmalKArdSystemHefazati.AutoComplete = True
        Me.cmb_AmalKArdSystemHefazati.DataSource = Me.PmHadeseAmalkardSystemBindingSource
        Me.cmb_AmalKArdSystemHefazati.DisplayMember = "عملکرد سیستم"
        Me.cmb_AmalKArdSystemHefazati.Enabled = False
        Me.cmb_AmalKArdSystemHefazati.EnterStop = True
        Me.cmb_AmalKArdSystemHefazati.FormattingEnabled = True
        Me.cmb_AmalKArdSystemHefazati.IsRequired = False
        Me.cmb_AmalKArdSystemHefazati.LimitedToList = True
        Me.cmb_AmalKArdSystemHefazati.Location = New System.Drawing.Point(11, 91)
        Me.cmb_AmalKArdSystemHefazati.Name = "cmb_AmalKArdSystemHefazati"
        Me.cmb_AmalKArdSystemHefazati.OpenOnFoucus = True
        Me.cmb_AmalKArdSystemHefazati.Size = New System.Drawing.Size(170, 26)
        Me.cmb_AmalKArdSystemHefazati.TabIndex = 193
        Me.cmb_AmalKArdSystemHefazati.ValueMember = "Srl"
        '
        'PmHadeseAmalkardSystemBindingSource
        '
        Me.PmHadeseAmalkardSystemBindingSource.DataMember = "Pm_Hadese_AmalkardSystem"
        Me.PmHadeseAmalkardSystemBindingSource.DataSource = Me.Ds_Hadese
        '
        'Ds_Hadese
        '
        Me.Ds_Hadese.DataSetName = "Ds_Hadese"
        Me.Ds_Hadese.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chk_AmalKArdSystemHefazati
        '
        Me.chk_AmalKArdSystemHefazati.AutoSize = True
        Me.chk_AmalKArdSystemHefazati.Checked = True
        Me.chk_AmalKArdSystemHefazati.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_AmalKArdSystemHefazati.Location = New System.Drawing.Point(187, 95)
        Me.chk_AmalKArdSystemHefazati.Name = "chk_AmalKArdSystemHefazati"
        Me.chk_AmalKArdSystemHefazati.Size = New System.Drawing.Size(184, 22)
        Me.chk_AmalKArdSystemHefazati.TabIndex = 192
        Me.chk_AmalKArdSystemHefazati.Text = "عملکرد سیستم حفاظتی"
        Me.chk_AmalKArdSystemHefazati.UseVisualStyleBackColor = True
        '
        'cmb_Mahal
        '
        Me.cmb_Mahal.AutoComplete = True
        Me.cmb_Mahal.DataSource = Me.PmPostBindingSource
        Me.cmb_Mahal.DisplayMember = "نام پست"
        Me.cmb_Mahal.Enabled = False
        Me.cmb_Mahal.EnterStop = True
        Me.cmb_Mahal.FormattingEnabled = True
        Me.cmb_Mahal.IsRequired = False
        Me.cmb_Mahal.LimitedToList = True
        Me.cmb_Mahal.Location = New System.Drawing.Point(10, 24)
        Me.cmb_Mahal.Name = "cmb_Mahal"
        Me.cmb_Mahal.OpenOnFoucus = True
        Me.cmb_Mahal.Size = New System.Drawing.Size(171, 26)
        Me.cmb_Mahal.TabIndex = 186
        Me.cmb_Mahal.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'chk_Mahal
        '
        Me.chk_Mahal.AutoSize = True
        Me.chk_Mahal.Checked = True
        Me.chk_Mahal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Mahal.Location = New System.Drawing.Point(187, 27)
        Me.chk_Mahal.Name = "chk_Mahal"
        Me.chk_Mahal.Size = New System.Drawing.Size(95, 22)
        Me.chk_Mahal.TabIndex = 185
        Me.chk_Mahal.Text = "محل حادثه"
        Me.chk_Mahal.UseVisualStyleBackColor = True
        '
        'cmb_SharayeteBoroz
        '
        Me.cmb_SharayeteBoroz.AutoComplete = True
        Me.cmb_SharayeteBoroz.DataSource = Me.PmHadeseSharayetBorozBindingSource
        Me.cmb_SharayeteBoroz.DisplayMember = "شرایط بروز حادثه"
        Me.cmb_SharayeteBoroz.Enabled = False
        Me.cmb_SharayeteBoroz.EnterStop = True
        Me.cmb_SharayeteBoroz.FormattingEnabled = True
        Me.cmb_SharayeteBoroz.IsRequired = False
        Me.cmb_SharayeteBoroz.LimitedToList = True
        Me.cmb_SharayeteBoroz.Location = New System.Drawing.Point(714, 98)
        Me.cmb_SharayeteBoroz.Name = "cmb_SharayeteBoroz"
        Me.cmb_SharayeteBoroz.OpenOnFoucus = True
        Me.cmb_SharayeteBoroz.Size = New System.Drawing.Size(158, 26)
        Me.cmb_SharayeteBoroz.TabIndex = 186
        Me.cmb_SharayeteBoroz.ValueMember = "Srl"
        '
        'PmHadeseSharayetBorozBindingSource
        '
        Me.PmHadeseSharayetBorozBindingSource.DataMember = "Pm_Hadese_SharayetBoroz"
        Me.PmHadeseSharayetBorozBindingSource.DataSource = Me.Ds_Hadese
        '
        'chk_SharayeteBoroz
        '
        Me.chk_SharayeteBoroz.AutoSize = True
        Me.chk_SharayeteBoroz.Checked = True
        Me.chk_SharayeteBoroz.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SharayeteBoroz.Location = New System.Drawing.Point(884, 101)
        Me.chk_SharayeteBoroz.Name = "chk_SharayeteBoroz"
        Me.chk_SharayeteBoroz.Size = New System.Drawing.Size(93, 22)
        Me.chk_SharayeteBoroz.TabIndex = 185
        Me.chk_SharayeteBoroz.Text = "شرایط بروز"
        Me.chk_SharayeteBoroz.UseVisualStyleBackColor = True
        '
        'cmb_Elat
        '
        Me.cmb_Elat.AutoComplete = True
        Me.cmb_Elat.DataSource = Me.PmHadeseElatBindingSource
        Me.cmb_Elat.DisplayMember = "علت حادثه"
        Me.cmb_Elat.Enabled = False
        Me.cmb_Elat.EnterStop = True
        Me.cmb_Elat.FormattingEnabled = True
        Me.cmb_Elat.IsRequired = False
        Me.cmb_Elat.LimitedToList = True
        Me.cmb_Elat.Location = New System.Drawing.Point(518, 32)
        Me.cmb_Elat.Name = "cmb_Elat"
        Me.cmb_Elat.OpenOnFoucus = True
        Me.cmb_Elat.Size = New System.Drawing.Size(154, 26)
        Me.cmb_Elat.TabIndex = 186
        Me.cmb_Elat.ValueMember = "Srl"
        '
        'PmHadeseElatBindingSource
        '
        Me.PmHadeseElatBindingSource.DataMember = "Pm_Hadese_Elat"
        Me.PmHadeseElatBindingSource.DataSource = Me.Ds_Hadese
        '
        'Chk_Elat
        '
        Me.Chk_Elat.AutoSize = True
        Me.Chk_Elat.Checked = True
        Me.Chk_Elat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_Elat.Location = New System.Drawing.Point(678, 35)
        Me.Chk_Elat.Name = "Chk_Elat"
        Me.Chk_Elat.Size = New System.Drawing.Size(55, 22)
        Me.Chk_Elat.TabIndex = 185
        Me.Chk_Elat.Text = "علت"
        Me.Chk_Elat.UseVisualStyleBackColor = True
        '
        'chk_ReportNo
        '
        Me.chk_ReportNo.AutoSize = True
        Me.chk_ReportNo.Checked = True
        Me.chk_ReportNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_ReportNo.Location = New System.Drawing.Point(908, 36)
        Me.chk_ReportNo.Name = "chk_ReportNo"
        Me.chk_ReportNo.Size = New System.Drawing.Size(67, 22)
        Me.chk_ReportNo.TabIndex = 183
        Me.chk_ReportNo.Text = "شماره"
        Me.chk_ReportNo.UseVisualStyleBackColor = True
        '
        'txt_ReportNo
        '
        Me.txt_ReportNo.CheckExistValueInDb = True
        Me.txt_ReportNo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ReportNo.CurrencyUnit = "ریال"
        Me.txt_ReportNo.DefaultValue = ""
        Me.txt_ReportNo.Enabled = False
        Me.txt_ReportNo.FillWithMaxInDb = False
        Me.txt_ReportNo.IsRequired = True
        Me.txt_ReportNo.Location = New System.Drawing.Point(746, 33)
        Me.txt_ReportNo.MaxDecimalLength = 2
        Me.txt_ReportNo.Name = "txt_ReportNo"
        Me.txt_ReportNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ReportNo.Size = New System.Drawing.Size(154, 25)
        Me.txt_ReportNo.SpellControl = Nothing
        Me.txt_ReportNo.TabIndex = 184
        Me.txt_ReportNo.Tag = ""
        Me.txt_ReportNo.Title = Nothing
        Me.txt_ReportNo.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ReportNo.UseForData = True
        Me.txt_ReportNo.ValidateCheckExistOnEdit = False
        Me.txt_ReportNo.Value = ""
        '
        'txt_ElatGostaresh
        '
        Me.txt_ElatGostaresh.CheckExistValueInDb = True
        Me.txt_ElatGostaresh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ElatGostaresh.CurrencyUnit = "ریال"
        Me.txt_ElatGostaresh.DefaultValue = ""
        Me.txt_ElatGostaresh.Enabled = False
        Me.txt_ElatGostaresh.FillWithMaxInDb = False
        Me.txt_ElatGostaresh.IsRequired = True
        Me.txt_ElatGostaresh.Location = New System.Drawing.Point(11, 216)
        Me.txt_ElatGostaresh.MaxDecimalLength = 2
        Me.txt_ElatGostaresh.Multiline = True
        Me.txt_ElatGostaresh.Name = "txt_ElatGostaresh"
        Me.txt_ElatGostaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ElatGostaresh.Size = New System.Drawing.Size(338, 24)
        Me.txt_ElatGostaresh.SpellControl = Nothing
        Me.txt_ElatGostaresh.TabIndex = 181
        Me.txt_ElatGostaresh.Tag = ""
        Me.txt_ElatGostaresh.Title = Nothing
        Me.txt_ElatGostaresh.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_ElatGostaresh.UseForData = True
        Me.txt_ElatGostaresh.ValidateCheckExistOnEdit = False
        Me.txt_ElatGostaresh.Value = ""
        '
        'chk_ElatGostaresh
        '
        Me.chk_ElatGostaresh.AutoSize = True
        Me.chk_ElatGostaresh.Checked = True
        Me.chk_ElatGostaresh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_ElatGostaresh.Location = New System.Drawing.Point(355, 216)
        Me.chk_ElatGostaresh.Name = "chk_ElatGostaresh"
        Me.chk_ElatGostaresh.Size = New System.Drawing.Size(151, 22)
        Me.chk_ElatGostaresh.TabIndex = 180
        Me.chk_ElatGostaresh.Text = "علت گسترش حادثه"
        Me.chk_ElatGostaresh.UseVisualStyleBackColor = True
        '
        'txt_KalamatKelidi
        '
        Me.txt_KalamatKelidi.CheckExistValueInDb = True
        Me.txt_KalamatKelidi.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_KalamatKelidi.CurrencyUnit = "ریال"
        Me.txt_KalamatKelidi.DefaultValue = ""
        Me.txt_KalamatKelidi.Enabled = False
        Me.txt_KalamatKelidi.FillWithMaxInDb = False
        Me.txt_KalamatKelidi.IsRequired = True
        Me.txt_KalamatKelidi.Location = New System.Drawing.Point(11, 156)
        Me.txt_KalamatKelidi.MaxDecimalLength = 2
        Me.txt_KalamatKelidi.Multiline = True
        Me.txt_KalamatKelidi.Name = "txt_KalamatKelidi"
        Me.txt_KalamatKelidi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_KalamatKelidi.Size = New System.Drawing.Size(338, 24)
        Me.txt_KalamatKelidi.SpellControl = Nothing
        Me.txt_KalamatKelidi.TabIndex = 181
        Me.txt_KalamatKelidi.Tag = ""
        Me.txt_KalamatKelidi.Title = Nothing
        Me.txt_KalamatKelidi.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_KalamatKelidi.UseForData = True
        Me.txt_KalamatKelidi.ValidateCheckExistOnEdit = False
        Me.txt_KalamatKelidi.Value = ""
        '
        'chk_KalamatKelidi
        '
        Me.chk_KalamatKelidi.AutoSize = True
        Me.chk_KalamatKelidi.Checked = True
        Me.chk_KalamatKelidi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_KalamatKelidi.Location = New System.Drawing.Point(354, 161)
        Me.chk_KalamatKelidi.Name = "chk_KalamatKelidi"
        Me.chk_KalamatKelidi.Size = New System.Drawing.Size(107, 22)
        Me.chk_KalamatKelidi.TabIndex = 180
        Me.chk_KalamatKelidi.Text = "کلمات کلیدی"
        Me.chk_KalamatKelidi.UseVisualStyleBackColor = True
        '
        'txt_NatijeBarasi
        '
        Me.txt_NatijeBarasi.CheckExistValueInDb = True
        Me.txt_NatijeBarasi.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_NatijeBarasi.CurrencyUnit = "ریال"
        Me.txt_NatijeBarasi.DefaultValue = ""
        Me.txt_NatijeBarasi.Enabled = False
        Me.txt_NatijeBarasi.FillWithMaxInDb = False
        Me.txt_NatijeBarasi.IsRequired = True
        Me.txt_NatijeBarasi.Location = New System.Drawing.Point(11, 126)
        Me.txt_NatijeBarasi.MaxDecimalLength = 2
        Me.txt_NatijeBarasi.Multiline = True
        Me.txt_NatijeBarasi.Name = "txt_NatijeBarasi"
        Me.txt_NatijeBarasi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_NatijeBarasi.Size = New System.Drawing.Size(338, 24)
        Me.txt_NatijeBarasi.SpellControl = Nothing
        Me.txt_NatijeBarasi.TabIndex = 181
        Me.txt_NatijeBarasi.Tag = ""
        Me.txt_NatijeBarasi.Title = Nothing
        Me.txt_NatijeBarasi.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_NatijeBarasi.UseForData = True
        Me.txt_NatijeBarasi.ValidateCheckExistOnEdit = False
        Me.txt_NatijeBarasi.Value = ""
        '
        'txt_DastorModir
        '
        Me.txt_DastorModir.CheckExistValueInDb = True
        Me.txt_DastorModir.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DastorModir.CurrencyUnit = "ریال"
        Me.txt_DastorModir.DefaultValue = ""
        Me.txt_DastorModir.Enabled = False
        Me.txt_DastorModir.FillWithMaxInDb = False
        Me.txt_DastorModir.IsRequired = True
        Me.txt_DastorModir.Location = New System.Drawing.Point(11, 186)
        Me.txt_DastorModir.MaxDecimalLength = 2
        Me.txt_DastorModir.Multiline = True
        Me.txt_DastorModir.Name = "txt_DastorModir"
        Me.txt_DastorModir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DastorModir.Size = New System.Drawing.Size(338, 24)
        Me.txt_DastorModir.SpellControl = Nothing
        Me.txt_DastorModir.TabIndex = 181
        Me.txt_DastorModir.Tag = ""
        Me.txt_DastorModir.Title = Nothing
        Me.txt_DastorModir.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DastorModir.UseForData = True
        Me.txt_DastorModir.ValidateCheckExistOnEdit = False
        Me.txt_DastorModir.Value = ""
        '
        'chk_NatijeBarasi
        '
        Me.chk_NatijeBarasi.AutoSize = True
        Me.chk_NatijeBarasi.Checked = True
        Me.chk_NatijeBarasi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_NatijeBarasi.Location = New System.Drawing.Point(354, 132)
        Me.chk_NatijeBarasi.Name = "chk_NatijeBarasi"
        Me.chk_NatijeBarasi.Size = New System.Drawing.Size(110, 22)
        Me.chk_NatijeBarasi.TabIndex = 180
        Me.chk_NatijeBarasi.Text = "نتیجه بررسی"
        Me.chk_NatijeBarasi.UseVisualStyleBackColor = True
        '
        'chk_DastorModir
        '
        Me.chk_DastorModir.AutoSize = True
        Me.chk_DastorModir.Checked = True
        Me.chk_DastorModir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_DastorModir.Location = New System.Drawing.Point(357, 189)
        Me.chk_DastorModir.Name = "chk_DastorModir"
        Me.chk_DastorModir.Size = New System.Drawing.Size(97, 22)
        Me.chk_DastorModir.TabIndex = 180
        Me.chk_DastorModir.Text = "دستور مدیر"
        Me.chk_DastorModir.UseVisualStyleBackColor = True
        '
        'txt_SHarhHadese
        '
        Me.txt_SHarhHadese.CheckExistValueInDb = True
        Me.txt_SHarhHadese.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SHarhHadese.CurrencyUnit = "ریال"
        Me.txt_SHarhHadese.DefaultValue = ""
        Me.txt_SHarhHadese.Enabled = False
        Me.txt_SHarhHadese.FillWithMaxInDb = False
        Me.txt_SHarhHadese.IsRequired = True
        Me.txt_SHarhHadese.Location = New System.Drawing.Point(512, 132)
        Me.txt_SHarhHadese.MaxDecimalLength = 2
        Me.txt_SHarhHadese.Multiline = True
        Me.txt_SHarhHadese.Name = "txt_SHarhHadese"
        Me.txt_SHarhHadese.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SHarhHadese.Size = New System.Drawing.Size(360, 51)
        Me.txt_SHarhHadese.SpellControl = Nothing
        Me.txt_SHarhHadese.TabIndex = 181
        Me.txt_SHarhHadese.Tag = ""
        Me.txt_SHarhHadese.Title = Nothing
        Me.txt_SHarhHadese.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SHarhHadese.UseForData = True
        Me.txt_SHarhHadese.ValidateCheckExistOnEdit = False
        Me.txt_SHarhHadese.Value = ""
        '
        'chk_SHarhHadese
        '
        Me.chk_SHarhHadese.AutoSize = True
        Me.chk_SHarhHadese.Checked = True
        Me.chk_SHarhHadese.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SHarhHadese.Location = New System.Drawing.Point(879, 147)
        Me.chk_SHarhHadese.Name = "chk_SHarhHadese"
        Me.chk_SHarhHadese.Size = New System.Drawing.Size(96, 22)
        Me.chk_SHarhHadese.TabIndex = 180
        Me.chk_SHarhHadese.Text = "شرح حادثه"
        Me.chk_SHarhHadese.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_SHarhHadese.UseVisualStyleBackColor = True
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
        Me.txt_ToDate.Location = New System.Drawing.Point(518, 64)
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
        Me.txt_FromDate.Location = New System.Drawing.Point(746, 65)
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
        Me.Label2.Location = New System.Drawing.Point(678, 64)
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
        Me.chk_allday.Location = New System.Drawing.Point(906, 67)
        Me.chk_allday.Name = "chk_allday"
        Me.chk_allday.Size = New System.Drawing.Size(69, 22)
        Me.chk_allday.TabIndex = 177
        Me.chk_allday.Text = "تاریخ از"
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
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn1, Me.شمارهگزارشDataGridViewTextBoxColumn1, Me.تاریخDataGridViewTextBoxColumn1, Me.محلوقوعDataGridViewTextBoxColumn1, Me.نامخطDataGridViewTextBoxColumn, Me.علتبروزحادثهDataGridViewTextBoxColumn, Me.نامگروهDataGridViewTextBoxColumn, Me.ثبتکنندهDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmHadeseBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 291)
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
        Me.DataGridView1.Size = New System.Drawing.Size(981, 291)
        Me.DataGridView1.TabIndex = 176
        '
        'PmHadeseBindingSource
        '
        Me.PmHadeseBindingSource.DataMember = "Pm_Hadese"
        Me.PmHadeseBindingSource.DataSource = Me.Ds_Hadese
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Btn_PrintAll)
        Me.Panel1.Controls.Add(Me.lbl_Record)
        Me.Panel1.Controls.Add(Me.Btn_print)
        Me.Panel1.Controls.Add(Me.Btn_Edit)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Location = New System.Drawing.Point(10, 249)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 36)
        Me.Panel1.TabIndex = 175
        '
        'Btn_PrintAll
        '
        Me.Btn_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.Btn_PrintAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_PrintAll.HeaderText = "چاپ"
        Me.Btn_PrintAll.Location = New System.Drawing.Point(396, 4)
        Me.Btn_PrintAll.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_PrintAll.Name = "Btn_PrintAll"
        Me.Btn_PrintAll.Size = New System.Drawing.Size(130, 26)
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
        'Btn_print
        '
        Me.Btn_print.BackColor = System.Drawing.Color.Transparent
        Me.Btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_print.HeaderText = "چاپ گزارش حادثه"
        Me.Btn_print.Location = New System.Drawing.Point(538, 4)
        Me.Btn_print.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_print.Name = "Btn_print"
        Me.Btn_print.Size = New System.Drawing.Size(130, 26)
        Me.Btn_print.TabIndex = 160
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Edit.HeaderText = "ویرایش فرم حادثه"
        Me.Btn_Edit.Location = New System.Drawing.Point(680, 4)
        Me.Btn_Edit.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(130, 26)
        Me.Btn_Edit.TabIndex = 159
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.HeaderText = "جستجو"
        Me.Btn_Search.Location = New System.Drawing.Point(822, 4)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(130, 26)
        Me.Btn_Search.TabIndex = 0
        '
        'Pm_HadeseTableAdapter
        '
        Me.Pm_HadeseTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'RpHadeseBindingSource
        '
        Me.RpHadeseBindingSource.DataMember = "Rp_Hadese"
        Me.RpHadeseBindingSource.DataSource = Me.Ds_Hadese
        '
        'Rp_HadeseTableAdapter
        '
        Me.Rp_HadeseTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_SharayetBorozTableAdapter
        '
        Me.Pm_Hadese_SharayetBorozTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_AmalkardSystemTableAdapter
        '
        Me.Pm_Hadese_AmalkardSystemTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_ElatTableAdapter
        '
        Me.Pm_Hadese_ElatTableAdapter.ClearBeforeFill = True
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهگزارشDataGridViewTextBoxColumn
        '
        Me.شمارهگزارشDataGridViewTextBoxColumn.DataPropertyName = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn.HeaderText = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn.Name = "شمارهگزارشDataGridViewTextBoxColumn"
        Me.شمارهگزارشDataGridViewTextBoxColumn.Width = 130
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.Width = 130
        '
        'محلوقوعDataGridViewTextBoxColumn
        '
        Me.محلوقوعDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.محلوقوعDataGridViewTextBoxColumn.DataPropertyName = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn.HeaderText = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn.Name = "محلوقوعDataGridViewTextBoxColumn"
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn1.Visible = False
        '
        'شمارهگزارشDataGridViewTextBoxColumn1
        '
        Me.شمارهگزارشDataGridViewTextBoxColumn1.DataPropertyName = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn1.HeaderText = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn1.Name = "شمارهگزارشDataGridViewTextBoxColumn1"
        Me.شمارهگزارشDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'تاریخDataGridViewTextBoxColumn1
        '
        Me.تاریخDataGridViewTextBoxColumn1.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn1.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn1.Name = "تاریخDataGridViewTextBoxColumn1"
        Me.تاریخDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'محلوقوعDataGridViewTextBoxColumn1
        '
        Me.محلوقوعDataGridViewTextBoxColumn1.DataPropertyName = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn1.HeaderText = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn1.Name = "محلوقوعDataGridViewTextBoxColumn1"
        Me.محلوقوعDataGridViewTextBoxColumn1.ReadOnly = True
        Me.محلوقوعDataGridViewTextBoxColumn1.Width = 150
        '
        'نامخطDataGridViewTextBoxColumn
        '
        Me.نامخطDataGridViewTextBoxColumn.DataPropertyName = "نام خط"
        Me.نامخطDataGridViewTextBoxColumn.HeaderText = "نام خط"
        Me.نامخطDataGridViewTextBoxColumn.Name = "نامخطDataGridViewTextBoxColumn"
        Me.نامخطDataGridViewTextBoxColumn.ReadOnly = True
        Me.نامخطDataGridViewTextBoxColumn.Width = 150
        '
        'علتبروزحادثهDataGridViewTextBoxColumn
        '
        Me.علتبروزحادثهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.علتبروزحادثهDataGridViewTextBoxColumn.DataPropertyName = "علت بروز حادثه"
        Me.علتبروزحادثهDataGridViewTextBoxColumn.HeaderText = "علت بروز حادثه"
        Me.علتبروزحادثهDataGridViewTextBoxColumn.Name = "علتبروزحادثهDataGridViewTextBoxColumn"
        Me.علتبروزحادثهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        Me.نامگروهDataGridViewTextBoxColumn.ReadOnly = True
        Me.نامگروهDataGridViewTextBoxColumn.Width = 150
        '
        'ثبتکنندهDataGridViewTextBoxColumn
        '
        Me.ثبتکنندهDataGridViewTextBoxColumn.DataPropertyName = "ثبت کننده"
        Me.ثبتکنندهDataGridViewTextBoxColumn.HeaderText = "ثبت کننده"
        Me.ثبتکنندهDataGridViewTextBoxColumn.Name = "ثبتکنندهDataGridViewTextBoxColumn"
        Me.ثبتکنندهDataGridViewTextBoxColumn.ReadOnly = True
        Me.ثبتکنندهDataGridViewTextBoxColumn.Visible = False
        '
        'Frm_Rp_HadeseVw
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1005, 655)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Name = "Frm_Rp_HadeseVw"
        Me.Text = "گزارش حادثه"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseAmalkardSystemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseSharayetBorozBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseElatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RpHadeseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents PmHadeseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_HadeseTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_HadeseTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_allday As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Record As System.Windows.Forms.Label
    Friend WithEvents Btn_print As CS_Component.Btn
    Friend WithEvents Btn_Edit As CS_Component.Btn
    Friend WithEvents Btn_Search As CS_Component.Btn
    Friend WithEvents chk_ReportNo As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ReportNo As CS_Component.TextBox
    Friend WithEvents cmb_Mahal As VB_Component.ComboBox
    Friend WithEvents chk_Mahal As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_SharayeteBoroz As VB_Component.ComboBox
    Friend WithEvents chk_SharayeteBoroz As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Elat As VB_Component.ComboBox
    Friend WithEvents Chk_Elat As System.Windows.Forms.CheckBox
    Friend WithEvents txt_KalamatKelidi As CS_Component.TextBox
    Friend WithEvents chk_KalamatKelidi As System.Windows.Forms.CheckBox
    Friend WithEvents txt_SHarhHadese As CS_Component.TextBox
    Friend WithEvents chk_SHarhHadese As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ElatGostaresh As CS_Component.TextBox
    Friend WithEvents chk_ElatGostaresh As System.Windows.Forms.CheckBox
    Friend WithEvents txt_NatijeBarasi As CS_Component.TextBox
    Friend WithEvents txt_DastorModir As CS_Component.TextBox
    Friend WithEvents chk_NatijeBarasi As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DastorModir As System.Windows.Forms.CheckBox
    Friend WithEvents txt_EghdamatAvalie As CS_Component.TextBox
    Friend WithEvents chk_EghdamatAvalie As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Group As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Group As VB_Component.ComboBox
    Friend WithEvents cmb_AmalKArdSystemHefazati As VB_Component.ComboBox
    Friend WithEvents chk_AmalKArdSystemHefazati As System.Windows.Forms.CheckBox
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents RpHadeseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_HadeseTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Rp_HadeseTableAdapter
    Friend WithEvents PmHadeseSharayetBorozBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_SharayetBorozTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_SharayetBorozTableAdapter
    Friend WithEvents PmHadeseAmalkardSystemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_AmalkardSystemTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_AmalkardSystemTableAdapter
    Friend WithEvents PmHadeseElatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_ElatTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_ElatTableAdapter
    Friend WithEvents Btn_PrintAll As CS_Component.Btn
    Friend WithEvents cmb_Line As VB_Component.ComboBox
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chk_Line As System.Windows.Forms.CheckBox
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهگزارشDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلوقوعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهگزارشDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلوقوعDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامخطDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents علتبروزحادثهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ثبتکنندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
