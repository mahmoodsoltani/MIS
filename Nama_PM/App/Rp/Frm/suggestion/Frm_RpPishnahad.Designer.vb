<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpPishnahad
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
        Me.rbt_Line = New System.Windows.Forms.RadioButton
        Me.rbt_Post = New System.Windows.Forms.RadioButton
        Me.cmb_Line = New VB_Component.ComboBox
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_TarikhSabtTo = New CS_Component.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chk_TarikhSabt = New System.Windows.Forms.CheckBox
        Me.txt_TarikhSabtFrom = New CS_Component.TextBox
        Me.chkb_pl = New System.Windows.Forms.CheckBox
        Me.Srl_Device = New CS_Component.TextBox
        Me.btn_SelectTajhiz = New System.Windows.Forms.Button
        Me.txt_TajhizNameForSave = New CS_Component.TextBox
        Me.chkb_Device = New System.Windows.Forms.CheckBox
        Me.chkb_Subject = New System.Windows.Forms.CheckBox
        Me.cmb_RecomSubject = New VB_Component.ComboBox
        Me.PmRecomendationSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkb_Vahed = New System.Windows.Forms.CheckBox
        Me.cmb_Vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Btn1 = New CS_Component.Btn
        Me.btn_Edit = New CS_Component.Btn
        Me.btn_Delete = New CS_Component.Btn
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Srl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.موضوع = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.واحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.خطDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.بازهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پیشنهادDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RpPishnahadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_RecomendationSubjectTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_RecomendationSubjectTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_All = New System.Windows.Forms.RadioButton
        Me.rb_Fix = New System.Windows.Forms.RadioButton
        Me.rb_NotFix = New System.Windows.Forms.RadioButton
        Me.Rp_PishnahadTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_PishnahadTableAdapter
        Me.lbl_Record = New System.Windows.Forms.Label
        Me.cmb_Sender = New VB_Component.ComboBox
        Me.chkb_Sender = New System.Windows.Forms.CheckBox
        Me.PmSenderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_SenderTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_SenderTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpPishnahadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PmSenderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.BackColor = System.Drawing.SystemColors.Info
        Me.gbx_Buttons.Controls.Add(Me.lbl_Record)
        Me.gbx_Buttons.Location = New System.Drawing.Point(9, 186)
        Me.gbx_Buttons.Size = New System.Drawing.Size(880, 41)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Cancel, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Save, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.lbl_Record, 0)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(688, 9)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "جستجو"
        Me.btn_Save.Location = New System.Drawing.Point(777, 9)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Fields.Controls.Add(Me.cmb_Sender)
        Me.gbx_Fields.Controls.Add(Me.chkb_Sender)
        Me.gbx_Fields.Controls.Add(Me.GroupBox1)
        Me.gbx_Fields.Controls.Add(Me.cmb_Vahed)
        Me.gbx_Fields.Controls.Add(Me.chkb_Vahed)
        Me.gbx_Fields.Controls.Add(Me.cmb_RecomSubject)
        Me.gbx_Fields.Controls.Add(Me.chkb_Subject)
        Me.gbx_Fields.Controls.Add(Me.chkb_Device)
        Me.gbx_Fields.Controls.Add(Me.Srl_Device)
        Me.gbx_Fields.Controls.Add(Me.btn_SelectTajhiz)
        Me.gbx_Fields.Controls.Add(Me.txt_TajhizNameForSave)
        Me.gbx_Fields.Controls.Add(Me.chkb_pl)
        Me.gbx_Fields.Controls.Add(Me.txt_TarikhSabtTo)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.chk_TarikhSabt)
        Me.gbx_Fields.Controls.Add(Me.txt_TarikhSabtFrom)
        Me.gbx_Fields.Controls.Add(Me.rbt_Line)
        Me.gbx_Fields.Controls.Add(Me.rbt_Post)
        Me.gbx_Fields.Controls.Add(Me.cmb_Line)
        Me.gbx_Fields.Controls.Add(Me.cmb_Post)
        Me.gbx_Fields.Location = New System.Drawing.Point(12, 35)
        Me.gbx_Fields.Size = New System.Drawing.Size(880, 146)
        '
        'rbt_Line
        '
        Me.rbt_Line.AutoSize = True
        Me.rbt_Line.Enabled = False
        Me.rbt_Line.Location = New System.Drawing.Point(790, 117)
        Me.rbt_Line.Name = "rbt_Line"
        Me.rbt_Line.Size = New System.Drawing.Size(44, 20)
        Me.rbt_Line.TabIndex = 228
        Me.rbt_Line.TabStop = True
        Me.rbt_Line.Text = "خط"
        Me.rbt_Line.UseVisualStyleBackColor = True
        '
        'rbt_Post
        '
        Me.rbt_Post.AutoSize = True
        Me.rbt_Post.Enabled = False
        Me.rbt_Post.Location = New System.Drawing.Point(778, 90)
        Me.rbt_Post.Name = "rbt_Post"
        Me.rbt_Post.Size = New System.Drawing.Size(56, 20)
        Me.rbt_Post.TabIndex = 225
        Me.rbt_Post.TabStop = True
        Me.rbt_Post.Text = "پست"
        Me.rbt_Post.UseVisualStyleBackColor = True
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
        Me.cmb_Line.Location = New System.Drawing.Point(609, 115)
        Me.cmb_Line.Name = "cmb_Line"
        Me.cmb_Line.OpenOnFoucus = False
        Me.cmb_Line.Size = New System.Drawing.Size(169, 24)
        Me.cmb_Line.TabIndex = 227
        Me.cmb_Line.Tag = "Srl_Line"
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
        'cmb_Post
        '
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PmPostBindingSource
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.Enabled = False
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = True
        Me.cmb_Post.Location = New System.Drawing.Point(609, 84)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(169, 24)
        Me.cmb_Post.TabIndex = 226
        Me.cmb_Post.Tag = "Srl_Post"
        Me.cmb_Post.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'txt_TarikhSabtTo
        '
        Me.txt_TarikhSabtTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhSabtTo.CheckExistValueInDb = False
        Me.txt_TarikhSabtTo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhSabtTo.CurrencyUnit = "ریال"
        Me.txt_TarikhSabtTo.DefaultValue = ""
        Me.txt_TarikhSabtTo.Enabled = False
        Me.txt_TarikhSabtTo.FillWithMaxInDb = False
        Me.txt_TarikhSabtTo.IsRequired = True
        Me.txt_TarikhSabtTo.Location = New System.Drawing.Point(471, 22)
        Me.txt_TarikhSabtTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TarikhSabtTo.MaxDecimalLength = 2
        Me.txt_TarikhSabtTo.Name = "txt_TarikhSabtTo"
        Me.txt_TarikhSabtTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhSabtTo.Size = New System.Drawing.Size(143, 23)
        Me.txt_TarikhSabtTo.SpellControl = Nothing
        Me.txt_TarikhSabtTo.TabIndex = 231
        Me.txt_TarikhSabtTo.TabStop = False
        Me.txt_TarikhSabtTo.Tag = ""
        Me.txt_TarikhSabtTo.Title = Nothing
        Me.txt_TarikhSabtTo.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhSabtTo.UseForData = True
        Me.txt_TarikhSabtTo.ValidateCheckExistOnEdit = False
        Me.txt_TarikhSabtTo.Value = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(620, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 232
        Me.Label3.Text = "تا"
        '
        'chk_TarikhSabt
        '
        Me.chk_TarikhSabt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_TarikhSabt.AutoSize = True
        Me.chk_TarikhSabt.Checked = True
        Me.chk_TarikhSabt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_TarikhSabt.Location = New System.Drawing.Point(793, 27)
        Me.chk_TarikhSabt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_TarikhSabt.Name = "chk_TarikhSabt"
        Me.chk_TarikhSabt.Size = New System.Drawing.Size(57, 20)
        Me.chk_TarikhSabt.TabIndex = 230
        Me.chk_TarikhSabt.Text = "تاریخ "
        Me.chk_TarikhSabt.UseVisualStyleBackColor = True
        '
        'txt_TarikhSabtFrom
        '
        Me.txt_TarikhSabtFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhSabtFrom.CheckExistValueInDb = False
        Me.txt_TarikhSabtFrom.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhSabtFrom.CurrencyUnit = "ریال"
        Me.txt_TarikhSabtFrom.DefaultValue = ""
        Me.txt_TarikhSabtFrom.Enabled = False
        Me.txt_TarikhSabtFrom.FillWithMaxInDb = False
        Me.txt_TarikhSabtFrom.IsRequired = True
        Me.txt_TarikhSabtFrom.Location = New System.Drawing.Point(642, 23)
        Me.txt_TarikhSabtFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TarikhSabtFrom.MaxDecimalLength = 2
        Me.txt_TarikhSabtFrom.Name = "txt_TarikhSabtFrom"
        Me.txt_TarikhSabtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhSabtFrom.Size = New System.Drawing.Size(136, 23)
        Me.txt_TarikhSabtFrom.SpellControl = Nothing
        Me.txt_TarikhSabtFrom.TabIndex = 229
        Me.txt_TarikhSabtFrom.TabStop = False
        Me.txt_TarikhSabtFrom.Tag = ""
        Me.txt_TarikhSabtFrom.Title = Nothing
        Me.txt_TarikhSabtFrom.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhSabtFrom.UseForData = True
        Me.txt_TarikhSabtFrom.ValidateCheckExistOnEdit = False
        Me.txt_TarikhSabtFrom.Value = ""
        '
        'chkb_pl
        '
        Me.chkb_pl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkb_pl.AutoSize = True
        Me.chkb_pl.Checked = True
        Me.chkb_pl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkb_pl.Location = New System.Drawing.Point(837, 104)
        Me.chkb_pl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkb_pl.Name = "chkb_pl"
        Me.chkb_pl.Size = New System.Drawing.Size(15, 14)
        Me.chkb_pl.TabIndex = 233
        Me.chkb_pl.UseVisualStyleBackColor = True
        '
        'Srl_Device
        '
        Me.Srl_Device.CheckExistValueInDb = False
        Me.Srl_Device.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Srl_Device.CurrencyUnit = "ریال"
        Me.Srl_Device.DefaultValue = ""
        Me.Srl_Device.Enabled = False
        Me.Srl_Device.FillWithMaxInDb = False
        Me.Srl_Device.IsRequired = False
        Me.Srl_Device.Location = New System.Drawing.Point(538, 58)
        Me.Srl_Device.MaxDecimalLength = 2
        Me.Srl_Device.Name = "Srl_Device"
        Me.Srl_Device.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Srl_Device.Size = New System.Drawing.Size(10, 23)
        Me.Srl_Device.SpellControl = Nothing
        Me.Srl_Device.TabIndex = 237
        Me.Srl_Device.Tag = ""
        Me.Srl_Device.Title = Nothing
        Me.Srl_Device.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.Srl_Device.UseForData = True
        Me.Srl_Device.ValidateCheckExistOnEdit = False
        Me.Srl_Device.Value = ""
        Me.Srl_Device.Visible = False
        '
        'btn_SelectTajhiz
        '
        Me.btn_SelectTajhiz.Location = New System.Drawing.Point(554, 56)
        Me.btn_SelectTajhiz.Name = "btn_SelectTajhiz"
        Me.btn_SelectTajhiz.Size = New System.Drawing.Size(49, 25)
        Me.btn_SelectTajhiz.TabIndex = 234
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
        Me.txt_TajhizNameForSave.Location = New System.Drawing.Point(609, 55)
        Me.txt_TajhizNameForSave.MaxDecimalLength = 2
        Me.txt_TajhizNameForSave.Name = "txt_TajhizNameForSave"
        Me.txt_TajhizNameForSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TajhizNameForSave.Size = New System.Drawing.Size(169, 23)
        Me.txt_TajhizNameForSave.SpellControl = Nothing
        Me.txt_TajhizNameForSave.TabIndex = 235
        Me.txt_TajhizNameForSave.Tag = ""
        Me.txt_TajhizNameForSave.Title = Nothing
        Me.txt_TajhizNameForSave.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TajhizNameForSave.UseForData = True
        Me.txt_TajhizNameForSave.ValidateCheckExistOnEdit = False
        Me.txt_TajhizNameForSave.Value = ""
        '
        'chkb_Device
        '
        Me.chkb_Device.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkb_Device.AutoSize = True
        Me.chkb_Device.Checked = True
        Me.chkb_Device.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkb_Device.Location = New System.Drawing.Point(795, 57)
        Me.chkb_Device.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkb_Device.Name = "chkb_Device"
        Me.chkb_Device.Size = New System.Drawing.Size(57, 20)
        Me.chkb_Device.TabIndex = 238
        Me.chkb_Device.Text = "تجهیز"
        Me.chkb_Device.UseVisualStyleBackColor = True
        '
        'chkb_Subject
        '
        Me.chkb_Subject.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkb_Subject.AutoSize = True
        Me.chkb_Subject.Checked = True
        Me.chkb_Subject.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkb_Subject.Location = New System.Drawing.Point(421, 89)
        Me.chkb_Subject.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkb_Subject.Name = "chkb_Subject"
        Me.chkb_Subject.Size = New System.Drawing.Size(64, 20)
        Me.chkb_Subject.TabIndex = 239
        Me.chkb_Subject.Text = "موضوع"
        Me.chkb_Subject.UseVisualStyleBackColor = True
        '
        'cmb_RecomSubject
        '
        Me.cmb_RecomSubject.AutoComplete = True
        Me.cmb_RecomSubject.DataSource = Me.PmRecomendationSubjectBindingSource
        Me.cmb_RecomSubject.DisplayMember = "نام"
        Me.cmb_RecomSubject.Enabled = False
        Me.cmb_RecomSubject.EnterStop = True
        Me.cmb_RecomSubject.FormattingEnabled = True
        Me.cmb_RecomSubject.IsRequired = False
        Me.cmb_RecomSubject.LimitedToList = True
        Me.cmb_RecomSubject.Location = New System.Drawing.Point(233, 87)
        Me.cmb_RecomSubject.Name = "cmb_RecomSubject"
        Me.cmb_RecomSubject.OpenOnFoucus = False
        Me.cmb_RecomSubject.Size = New System.Drawing.Size(181, 24)
        Me.cmb_RecomSubject.TabIndex = 240
        Me.cmb_RecomSubject.Tag = "Srl_RecomSubject"
        Me.cmb_RecomSubject.ValueMember = "Srl"
        '
        'PmRecomendationSubjectBindingSource
        '
        Me.PmRecomendationSubjectBindingSource.DataMember = "Pm_RecomendationSubject"
        Me.PmRecomendationSubjectBindingSource.DataSource = Me.Ds_Pm
        '
        'chkb_Vahed
        '
        Me.chkb_Vahed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkb_Vahed.AutoSize = True
        Me.chkb_Vahed.Checked = True
        Me.chkb_Vahed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkb_Vahed.Location = New System.Drawing.Point(434, 62)
        Me.chkb_Vahed.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkb_Vahed.Name = "chkb_Vahed"
        Me.chkb_Vahed.Size = New System.Drawing.Size(51, 20)
        Me.chkb_Vahed.TabIndex = 241
        Me.chkb_Vahed.Text = "واحد"
        Me.chkb_Vahed.UseVisualStyleBackColor = True
        '
        'cmb_Vahed
        '
        Me.cmb_Vahed.AutoComplete = True
        Me.cmb_Vahed.DataSource = Me.PmVahedBindingSource
        Me.cmb_Vahed.DisplayMember = "نام واحد"
        Me.cmb_Vahed.Enabled = False
        Me.cmb_Vahed.EnterStop = True
        Me.cmb_Vahed.FormattingEnabled = True
        Me.cmb_Vahed.IsRequired = False
        Me.cmb_Vahed.LimitedToList = True
        Me.cmb_Vahed.Location = New System.Drawing.Point(233, 58)
        Me.cmb_Vahed.Name = "cmb_Vahed"
        Me.cmb_Vahed.OpenOnFoucus = False
        Me.cmb_Vahed.Size = New System.Drawing.Size(181, 24)
        Me.cmb_Vahed.TabIndex = 242
        Me.cmb_Vahed.Tag = "Srl_RecomSubject"
        Me.cmb_Vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Info
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Btn1)
        Me.Panel3.Controls.Add(Me.btn_Edit)
        Me.Panel3.Controls.Add(Me.btn_Delete)
        Me.Panel3.Location = New System.Drawing.Point(9, 411)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(880, 36)
        Me.Panel3.TabIndex = 182
        '
        'Btn1
        '
        Me.Btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn1.BackColor = System.Drawing.Color.Transparent
        Me.Btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1.HeaderText = "چاپ"
        Me.Btn1.Location = New System.Drawing.Point(776, 5)
        Me.Btn1.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(80, 26)
        Me.Btn1.TabIndex = 161
        '
        'btn_Edit
        '
        Me.btn_Edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Edit.HeaderText = "ویرایش"
        Me.btn_Edit.Location = New System.Drawing.Point(507, 5)
        Me.btn_Edit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(79, 26)
        Me.btn_Edit.TabIndex = 0
        Me.btn_Edit.Visible = False
        '
        'btn_Delete
        '
        Me.btn_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Delete.HeaderText = "حذف"
        Me.btn_Delete.Location = New System.Drawing.Point(595, 5)
        Me.btn_Delete.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(81, 26)
        Me.btn_Delete.TabIndex = 160
        Me.btn_Delete.Visible = False
        '
        'DataGridView1
        '
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Srl, Me.شمارهDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.شمارهفرمDataGridViewTextBoxColumn, Me.موضوع, Me.واحدDataGridViewTextBoxColumn, Me.پستDataGridViewTextBoxColumn, Me.خطDataGridViewTextBoxColumn, Me.بازهDataGridViewTextBoxColumn, Me.پیشنهادDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.RpPishnahadBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(9, 228)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(880, 181)
        Me.DataGridView1.TabIndex = 251
        '
        'Srl
        '
        Me.Srl.DataPropertyName = "Srl"
        Me.Srl.HeaderText = "Srl"
        Me.Srl.Name = "Srl"
        Me.Srl.ReadOnly = True
        Me.Srl.Visible = False
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.Width = 50
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.Width = 80
        '
        'شمارهفرمDataGridViewTextBoxColumn
        '
        Me.شمارهفرمDataGridViewTextBoxColumn.DataPropertyName = "شماره فرم"
        Me.شمارهفرمDataGridViewTextBoxColumn.HeaderText = "شماره فرم"
        Me.شمارهفرمDataGridViewTextBoxColumn.Name = "شمارهفرمDataGridViewTextBoxColumn"
        Me.شمارهفرمDataGridViewTextBoxColumn.Width = 90
        '
        'موضوع
        '
        Me.موضوع.DataPropertyName = "موضوع"
        Me.موضوع.HeaderText = "موضوع"
        Me.موضوع.Name = "موضوع"
        Me.موضوع.Width = 90
        '
        'واحدDataGridViewTextBoxColumn
        '
        Me.واحدDataGridViewTextBoxColumn.DataPropertyName = "واحد"
        Me.واحدDataGridViewTextBoxColumn.HeaderText = "واحد"
        Me.واحدDataGridViewTextBoxColumn.Name = "واحدDataGridViewTextBoxColumn"
        Me.واحدDataGridViewTextBoxColumn.Width = 90
        '
        'پستDataGridViewTextBoxColumn
        '
        Me.پستDataGridViewTextBoxColumn.DataPropertyName = "پست"
        Me.پستDataGridViewTextBoxColumn.HeaderText = "پست"
        Me.پستDataGridViewTextBoxColumn.Name = "پستDataGridViewTextBoxColumn"
        '
        'خطDataGridViewTextBoxColumn
        '
        Me.خطDataGridViewTextBoxColumn.DataPropertyName = "خط"
        Me.خطDataGridViewTextBoxColumn.HeaderText = "خط"
        Me.خطDataGridViewTextBoxColumn.Name = "خطDataGridViewTextBoxColumn"
        '
        'بازهDataGridViewTextBoxColumn
        '
        Me.بازهDataGridViewTextBoxColumn.DataPropertyName = "بازه"
        Me.بازهDataGridViewTextBoxColumn.HeaderText = "بازه"
        Me.بازهDataGridViewTextBoxColumn.Name = "بازهDataGridViewTextBoxColumn"
        Me.بازهDataGridViewTextBoxColumn.Width = 50
        '
        'پیشنهادDataGridViewTextBoxColumn
        '
        Me.پیشنهادDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.پیشنهادDataGridViewTextBoxColumn.DataPropertyName = "پیشنهاد"
        Me.پیشنهادDataGridViewTextBoxColumn.HeaderText = "پیشنهاد"
        Me.پیشنهادDataGridViewTextBoxColumn.Name = "پیشنهادDataGridViewTextBoxColumn"
        '
        'RpPishnahadBindingSource
        '
        Me.RpPishnahadBindingSource.DataMember = "Rp_Pishnahad"
        Me.RpPishnahadBindingSource.DataSource = Me.Ds_Rp
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_RecomendationSubjectTableAdapter
        '
        Me.Pm_RecomendationSubjectTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_All)
        Me.GroupBox1.Controls.Add(Me.rb_Fix)
        Me.GroupBox1.Controls.Add(Me.rb_NotFix)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 111)
        Me.GroupBox1.TabIndex = 243
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "وضعیت"
        '
        'rb_All
        '
        Me.rb_All.AutoSize = True
        Me.rb_All.Checked = True
        Me.rb_All.Location = New System.Drawing.Point(32, 26)
        Me.rb_All.Name = "rb_All"
        Me.rb_All.Size = New System.Drawing.Size(89, 20)
        Me.rb_All.TabIndex = 15
        Me.rb_All.TabStop = True
        Me.rb_All.Text = "تمام فرم ها"
        Me.rb_All.UseVisualStyleBackColor = True
        '
        'rb_Fix
        '
        Me.rb_Fix.AutoSize = True
        Me.rb_Fix.Location = New System.Drawing.Point(37, 50)
        Me.rb_Fix.Name = "rb_Fix"
        Me.rb_Fix.Size = New System.Drawing.Size(84, 20)
        Me.rb_Fix.TabIndex = 16
        Me.rb_Fix.Text = "انجام شده"
        Me.rb_Fix.UseVisualStyleBackColor = True
        '
        'rb_NotFix
        '
        Me.rb_NotFix.AutoSize = True
        Me.rb_NotFix.Location = New System.Drawing.Point(33, 78)
        Me.rb_NotFix.Name = "rb_NotFix"
        Me.rb_NotFix.Size = New System.Drawing.Size(89, 20)
        Me.rb_NotFix.TabIndex = 17
        Me.rb_NotFix.Text = "انجام نشده"
        Me.rb_NotFix.UseVisualStyleBackColor = True
        '
        'Rp_PishnahadTableAdapter
        '
        Me.Rp_PishnahadTableAdapter.ClearBeforeFill = True
        '
        'lbl_Record
        '
        Me.lbl_Record.AutoSize = True
        Me.lbl_Record.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_Record.Location = New System.Drawing.Point(114, 17)
        Me.lbl_Record.Name = "lbl_Record"
        Me.lbl_Record.Size = New System.Drawing.Size(79, 18)
        Me.lbl_Record.TabIndex = 162
        Me.lbl_Record.Text = "تعداد رکورد:"
        '
        'cmb_Sender
        '
        Me.cmb_Sender.AutoComplete = True
        Me.cmb_Sender.DataSource = Me.PmSenderBindingSource
        Me.cmb_Sender.DisplayMember = "Name"
        Me.cmb_Sender.Enabled = False
        Me.cmb_Sender.EnterStop = True
        Me.cmb_Sender.FormattingEnabled = True
        Me.cmb_Sender.IsRequired = False
        Me.cmb_Sender.LimitedToList = True
        Me.cmb_Sender.Location = New System.Drawing.Point(233, 116)
        Me.cmb_Sender.Name = "cmb_Sender"
        Me.cmb_Sender.OpenOnFoucus = False
        Me.cmb_Sender.Size = New System.Drawing.Size(181, 24)
        Me.cmb_Sender.TabIndex = 245
        Me.cmb_Sender.Tag = "Srl_Sender"
        Me.cmb_Sender.ValueMember = "Srl"
        '
        'chkb_Sender
        '
        Me.chkb_Sender.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkb_Sender.AutoSize = True
        Me.chkb_Sender.Checked = True
        Me.chkb_Sender.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkb_Sender.Location = New System.Drawing.Point(412, 119)
        Me.chkb_Sender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkb_Sender.Name = "chkb_Sender"
        Me.chkb_Sender.Size = New System.Drawing.Size(73, 20)
        Me.chkb_Sender.TabIndex = 244
        Me.chkb_Sender.Text = "فرستنده"
        Me.chkb_Sender.UseVisualStyleBackColor = True
        '
        'PmSenderBindingSource
        '
        Me.PmSenderBindingSource.DataMember = "Pm_Sender"
        Me.PmSenderBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_SenderTableAdapter
        '
        Me.Pm_SenderTableAdapter.ClearBeforeFill = True
        '
        'Frm_RpPishnahad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(904, 480)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Frm_RpPishnahad"
        Me.Text = "گزارش مصوبات"
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.gbx_Buttons, 0)
        Me.Controls.SetChildIndex(Me.gbx_Fields, 0)
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Buttons.PerformLayout()
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpPishnahadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PmSenderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbt_Line As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Post As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_Line As VB_Component.ComboBox
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents chkb_pl As System.Windows.Forms.CheckBox
    Friend WithEvents txt_TarikhSabtTo As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chk_TarikhSabt As System.Windows.Forms.CheckBox
    Friend WithEvents txt_TarikhSabtFrom As CS_Component.TextBox
    Friend WithEvents chkb_Device As System.Windows.Forms.CheckBox
    Friend WithEvents Srl_Device As CS_Component.TextBox
    Friend WithEvents btn_SelectTajhiz As System.Windows.Forms.Button
    Friend WithEvents txt_TajhizNameForSave As CS_Component.TextBox
    Friend WithEvents chkb_Subject As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_RecomSubject As VB_Component.ComboBox
    Friend WithEvents cmb_Vahed As VB_Component.ComboBox
    Friend WithEvents chkb_Vahed As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_Edit As CS_Component.Btn
    Friend WithEvents btn_Delete As CS_Component.Btn
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Btn1 As CS_Component.Btn
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmRecomendationSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_RecomendationSubjectTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_RecomendationSubjectTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Fix As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NotFix As System.Windows.Forms.RadioButton
    Friend WithEvents RpPishnahadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents Rp_PishnahadTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_PishnahadTableAdapter
    Friend WithEvents lbl_Record As System.Windows.Forms.Label
    Friend WithEvents Srl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents موضوع As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents خطDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents بازهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پیشنهادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_Sender As VB_Component.ComboBox
    Friend WithEvents chkb_Sender As System.Windows.Forms.CheckBox
    Friend WithEvents PmSenderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_SenderTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_SenderTableAdapter
End Class
