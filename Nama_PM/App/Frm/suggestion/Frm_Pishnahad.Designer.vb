<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pishnahad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Pishnahad))
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_Sub = New CS_Component.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_PTime = New CS_Component.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Srl_Device = New CS_Component.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbt_Line = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.rbt_Post = New System.Windows.Forms.RadioButton
        Me.txt_tarikh = New CS_Component.TextBox
        Me.cmb_Line = New VB_Component.ComboBox
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_NoForm = New CS_Component.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_SelectTajhiz = New System.Windows.Forms.Button
        Me.txt_Sug = New CS_Component.TextBox
        Me.txt_TajhizNameForSave = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_SubRecom = New VB_Component.ComboBox
        Me.PmSubRecomendationSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_RecomSubject = New VB_Component.ComboBox
        Me.PmRecomendationSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Vahde = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Dis = New CS_Component.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbt_NotDo = New System.Windows.Forms.RadioButton
        Me.rbt_Do = New System.Windows.Forms.RadioButton
        Me.txt_NoFormDo = New CS_Component.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_TarikhDo = New CS_Component.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_SHow = New System.Windows.Forms.PictureBox
        Me.btn_Before = New System.Windows.Forms.PictureBox
        Me.btn_Next = New System.Windows.Forms.PictureBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_TarikhSabt = New CS_Component.TextBox
        Me.txt_No = New CS_Component.TextBox
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_RecomendationSubjectTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_RecomendationSubjectTableAdapter
        Me.Pm_SubRecomendationSubjectTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_SubRecomendationSubjectTableAdapter
        Me.PmPishnahdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmb_Sender = New VB_Component.ComboBox
        Me.PmSenderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_SenderTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_SenderTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSubRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_SHow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPishnahdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSenderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(12, 595)
        Me.gbx_Buttons.Size = New System.Drawing.Size(832, 57)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(18, 22)
        Me.btn_Cancel.TabIndex = 500
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(734, 22)
        Me.btn_Save.TabIndex = 20
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Location = New System.Drawing.Point(33, 142)
        Me.gbx_Fields.Size = New System.Drawing.Size(10, 17)
        Me.gbx_Fields.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(609, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 16)
        Me.Label13.TabIndex = 226
        Me.Label13.Text = "شرح کارهای انجام شده"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmb_Sender)
        Me.GroupBox2.Controls.Add(Me.txt_Sub)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_PTime)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Srl_Device)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.rbt_Line)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.rbt_Post)
        Me.GroupBox2.Controls.Add(Me.txt_tarikh)
        Me.GroupBox2.Controls.Add(Me.cmb_Line)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_NoForm)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_SelectTajhiz)
        Me.GroupBox2.Controls.Add(Me.txt_Sug)
        Me.GroupBox2.Controls.Add(Me.txt_TajhizNameForSave)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmb_Post)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_SubRecom)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmb_RecomSubject)
        Me.GroupBox2.Controls.Add(Me.cmb_Vahde)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(793, 255)
        Me.GroupBox2.TabIndex = 229
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "اطلاعات ورودی"
        '
        'txt_Sub
        '
        Me.txt_Sub.CheckExistValueInDb = False
        Me.txt_Sub.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Sub.CurrencyUnit = "ریال"
        Me.txt_Sub.DefaultValue = ""
        Me.txt_Sub.FillWithMaxInDb = False
        Me.txt_Sub.IsRequired = False
        Me.txt_Sub.Location = New System.Drawing.Point(136, 82)
        Me.txt_Sub.MaxDecimalLength = 2
        Me.txt_Sub.Multiline = True
        Me.txt_Sub.Name = "txt_Sub"
        Me.txt_Sub.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Sub.Size = New System.Drawing.Size(193, 26)
        Me.txt_Sub.SpellControl = Nothing
        Me.txt_Sub.TabIndex = 4
        Me.txt_Sub.Tag = "SubRecomSubject"
        Me.txt_Sub.Title = Nothing
        Me.txt_Sub.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Sub.UseForData = True
        Me.txt_Sub.ValidateCheckExistOnEdit = False
        Me.txt_Sub.Value = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(252, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 16)
        Me.Label8.TabIndex = 228
        Me.Label8.Text = "روز"
        '
        'txt_PTime
        '
        Me.txt_PTime.CheckExistValueInDb = False
        Me.txt_PTime.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_PTime.CurrencyUnit = "ریال"
        Me.txt_PTime.DefaultValue = ""
        Me.txt_PTime.FillWithMaxInDb = False
        Me.txt_PTime.IsRequired = False
        Me.txt_PTime.Location = New System.Drawing.Point(278, 138)
        Me.txt_PTime.MaxDecimalLength = 2
        Me.txt_PTime.Name = "txt_PTime"
        Me.txt_PTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_PTime.Size = New System.Drawing.Size(50, 23)
        Me.txt_PTime.SpellControl = Nothing
        Me.txt_PTime.TabIndex = 227
        Me.txt_PTime.Tag = ""
        Me.txt_PTime.Title = Nothing
        Me.txt_PTime.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_PTime.UseForData = True
        Me.txt_PTime.ValidateCheckExistOnEdit = False
        Me.txt_PTime.Value = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(334, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 226
        Me.Label7.Text = "بازه انجام"
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
        Me.Srl_Device.Location = New System.Drawing.Point(434, 115)
        Me.Srl_Device.MaxDecimalLength = 2
        Me.Srl_Device.Name = "Srl_Device"
        Me.Srl_Device.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Srl_Device.Size = New System.Drawing.Size(11, 23)
        Me.Srl_Device.SpellControl = Nothing
        Me.Srl_Device.TabIndex = 225
        Me.Srl_Device.Tag = ""
        Me.Srl_Device.Title = Nothing
        Me.Srl_Device.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.Srl_Device.UseForData = True
        Me.Srl_Device.ValidateCheckExistOnEdit = False
        Me.Srl_Device.Value = ""
        Me.Srl_Device.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(658, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 216
        Me.Label9.Text = "شماره فرم"
        '
        'rbt_Line
        '
        Me.rbt_Line.AutoSize = True
        Me.rbt_Line.Location = New System.Drawing.Point(671, 84)
        Me.rbt_Line.Name = "rbt_Line"
        Me.rbt_Line.Size = New System.Drawing.Size(44, 20)
        Me.rbt_Line.TabIndex = 224
        Me.rbt_Line.TabStop = True
        Me.rbt_Line.Text = "خط"
        Me.rbt_Line.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "تاریخ دریافت"
        '
        'rbt_Post
        '
        Me.rbt_Post.AutoSize = True
        Me.rbt_Post.Location = New System.Drawing.Point(658, 58)
        Me.rbt_Post.Name = "rbt_Post"
        Me.rbt_Post.Size = New System.Drawing.Size(56, 20)
        Me.rbt_Post.TabIndex = 2
        Me.rbt_Post.TabStop = True
        Me.rbt_Post.Text = "پست"
        Me.rbt_Post.UseVisualStyleBackColor = True
        '
        'txt_tarikh
        '
        Me.txt_tarikh.CheckExistValueInDb = False
        Me.txt_tarikh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_tarikh.CurrencyUnit = "ریال"
        Me.txt_tarikh.DefaultValue = ""
        Me.txt_tarikh.FillWithMaxInDb = False
        Me.txt_tarikh.IsRequired = False
        Me.txt_tarikh.Location = New System.Drawing.Point(173, 28)
        Me.txt_tarikh.MaxDecimalLength = 2
        Me.txt_tarikh.Name = "txt_tarikh"
        Me.txt_tarikh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_tarikh.Size = New System.Drawing.Size(155, 23)
        Me.txt_tarikh.SpellControl = Nothing
        Me.txt_tarikh.TabIndex = 1
        Me.txt_tarikh.TabStop = False
        Me.txt_tarikh.Tag = "Tarikh"
        Me.txt_tarikh.Title = Nothing
        Me.txt_tarikh.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_tarikh.UseForData = True
        Me.txt_tarikh.ValidateCheckExistOnEdit = False
        Me.txt_tarikh.Value = ""
        '
        'cmb_Line
        '
        Me.cmb_Line.AutoComplete = True
        Me.cmb_Line.DataSource = Me.PmLineBindingSource
        Me.cmb_Line.DisplayMember = "نام"
        Me.cmb_Line.EnterStop = True
        Me.cmb_Line.FormattingEnabled = True
        Me.cmb_Line.IsRequired = False
        Me.cmb_Line.LimitedToList = True
        Me.cmb_Line.Location = New System.Drawing.Point(463, 82)
        Me.cmb_Line.Name = "cmb_Line"
        Me.cmb_Line.OpenOnFoucus = False
        Me.cmb_Line.Size = New System.Drawing.Size(194, 24)
        Me.cmb_Line.TabIndex = 221
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "موضوع"
        '
        'txt_NoForm
        '
        Me.txt_NoForm.CheckExistValueInDb = False
        Me.txt_NoForm.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_NoForm.CurrencyUnit = "ریال"
        Me.txt_NoForm.DefaultValue = ""
        Me.txt_NoForm.FillWithMaxInDb = False
        Me.txt_NoForm.IsRequired = False
        Me.txt_NoForm.Location = New System.Drawing.Point(463, 24)
        Me.txt_NoForm.MaxDecimalLength = 2
        Me.txt_NoForm.Multiline = True
        Me.txt_NoForm.Name = "txt_NoForm"
        Me.txt_NoForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_NoForm.Size = New System.Drawing.Size(193, 26)
        Me.txt_NoForm.SpellControl = Nothing
        Me.txt_NoForm.TabIndex = 0
        Me.txt_NoForm.Tag = "No"
        Me.txt_NoForm.Title = Nothing
        Me.txt_NoForm.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_NoForm.UseForData = True
        Me.txt_NoForm.ValidateCheckExistOnEdit = False
        Me.txt_NoForm.Value = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "زیر موضوع"
        '
        'btn_SelectTajhiz
        '
        Me.btn_SelectTajhiz.Location = New System.Drawing.Point(421, 137)
        Me.btn_SelectTajhiz.Name = "btn_SelectTajhiz"
        Me.btn_SelectTajhiz.Size = New System.Drawing.Size(40, 25)
        Me.btn_SelectTajhiz.TabIndex = 6
        Me.btn_SelectTajhiz.Text = "..."
        Me.btn_SelectTajhiz.UseVisualStyleBackColor = True
        '
        'txt_Sug
        '
        Me.txt_Sug.CheckExistValueInDb = False
        Me.txt_Sug.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Sug.CurrencyUnit = "ریال"
        Me.txt_Sug.DefaultValue = ""
        Me.txt_Sug.FillWithMaxInDb = False
        Me.txt_Sug.IsRequired = False
        Me.txt_Sug.Location = New System.Drawing.Point(15, 165)
        Me.txt_Sug.MaxDecimalLength = 2
        Me.txt_Sug.Multiline = True
        Me.txt_Sug.Name = "txt_Sug"
        Me.txt_Sug.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Sug.Size = New System.Drawing.Size(643, 84)
        Me.txt_Sug.SpellControl = Nothing
        Me.txt_Sug.TabIndex = 8
        Me.txt_Sug.Tag = "Pishnahad"
        Me.txt_Sug.Title = Nothing
        Me.txt_Sug.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Sug.UseForData = True
        Me.txt_Sug.ValidateCheckExistOnEdit = False
        Me.txt_Sug.Value = ""
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
        Me.txt_TajhizNameForSave.Location = New System.Drawing.Point(463, 138)
        Me.txt_TajhizNameForSave.MaxDecimalLength = 2
        Me.txt_TajhizNameForSave.Name = "txt_TajhizNameForSave"
        Me.txt_TajhizNameForSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TajhizNameForSave.Size = New System.Drawing.Size(195, 23)
        Me.txt_TajhizNameForSave.SpellControl = Nothing
        Me.txt_TajhizNameForSave.TabIndex = 7
        Me.txt_TajhizNameForSave.Tag = ""
        Me.txt_TajhizNameForSave.Title = Nothing
        Me.txt_TajhizNameForSave.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TajhizNameForSave.UseForData = True
        Me.txt_TajhizNameForSave.ValidateCheckExistOnEdit = False
        Me.txt_TajhizNameForSave.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(659, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "شرح پیشنهاد"
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
        Me.cmb_Post.Location = New System.Drawing.Point(463, 54)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(193, 24)
        Me.cmb_Post.TabIndex = 220
        Me.cmb_Post.Tag = "Srl_Post"
        Me.cmb_Post.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(663, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "واحد"
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
        Me.cmb_SubRecom.Location = New System.Drawing.Point(41, 54)
        Me.cmb_SubRecom.Name = "cmb_SubRecom"
        Me.cmb_SubRecom.OpenOnFoucus = False
        Me.cmb_SubRecom.Size = New System.Drawing.Size(10, 24)
        Me.cmb_SubRecom.TabIndex = 229
        Me.cmb_SubRecom.Tag = "Srl_SubRecomSubject"
        Me.cmb_SubRecom.ValueMember = "Srl"
        Me.cmb_SubRecom.Visible = False
        '
        'PmSubRecomendationSubjectBindingSource
        '
        Me.PmSubRecomendationSubjectBindingSource.DataMember = "Pm_SubRecomendationSubject"
        Me.PmSubRecomendationSubjectBindingSource.DataSource = Me.Ds_Pm
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(663, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 216
        Me.Label5.Text = "تجهیز"
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
        Me.cmb_RecomSubject.Location = New System.Drawing.Point(135, 55)
        Me.cmb_RecomSubject.Name = "cmb_RecomSubject"
        Me.cmb_RecomSubject.OpenOnFoucus = False
        Me.cmb_RecomSubject.Size = New System.Drawing.Size(194, 24)
        Me.cmb_RecomSubject.TabIndex = 3
        Me.cmb_RecomSubject.Tag = "Srl_RecomSubject"
        Me.cmb_RecomSubject.ValueMember = "Srl"
        '
        'PmRecomendationSubjectBindingSource
        '
        Me.PmRecomendationSubjectBindingSource.DataMember = "Pm_RecomendationSubject"
        Me.PmRecomendationSubjectBindingSource.DataSource = Me.Ds_Pm
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
        Me.cmb_Vahde.Location = New System.Drawing.Point(463, 111)
        Me.cmb_Vahde.Name = "cmb_Vahde"
        Me.cmb_Vahde.OpenOnFoucus = False
        Me.cmb_Vahde.Size = New System.Drawing.Size(194, 24)
        Me.cmb_Vahde.TabIndex = 5
        Me.cmb_Vahde.Tag = "Srl_Vahed"
        Me.cmb_Vahde.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'txt_Dis
        '
        Me.txt_Dis.CheckExistValueInDb = False
        Me.txt_Dis.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Dis.CurrencyUnit = "ریال"
        Me.txt_Dis.DefaultValue = ""
        Me.txt_Dis.FillWithMaxInDb = False
        Me.txt_Dis.IsRequired = False
        Me.txt_Dis.Location = New System.Drawing.Point(26, 86)
        Me.txt_Dis.MaxDecimalLength = 2
        Me.txt_Dis.Multiline = True
        Me.txt_Dis.Name = "txt_Dis"
        Me.txt_Dis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Dis.Size = New System.Drawing.Size(578, 117)
        Me.txt_Dis.SpellControl = Nothing
        Me.txt_Dis.TabIndex = 12
        Me.txt_Dis.Tag = "Dis"
        Me.txt_Dis.Title = Nothing
        Me.txt_Dis.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Dis.UseForData = True
        Me.txt_Dis.ValidateCheckExistOnEdit = False
        Me.txt_Dis.Value = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_Dis)
        Me.GroupBox1.Controls.Add(Me.rbt_NotDo)
        Me.GroupBox1.Controls.Add(Me.rbt_Do)
        Me.GroupBox1.Controls.Add(Me.txt_NoFormDo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_TarikhDo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 382)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 216)
        Me.GroupBox1.TabIndex = 228
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "    کارهای انجام شده"
        '
        'rbt_NotDo
        '
        Me.rbt_NotDo.AutoSize = True
        Me.rbt_NotDo.Font = New System.Drawing.Font("Tahoma", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rbt_NotDo.Location = New System.Drawing.Point(168, 55)
        Me.rbt_NotDo.Name = "rbt_NotDo"
        Me.rbt_NotDo.Size = New System.Drawing.Size(200, 20)
        Me.rbt_NotDo.TabIndex = 224
        Me.rbt_NotDo.TabStop = True
        Me.rbt_NotDo.Text = "قسمتی از کار انجام شده است."
        Me.rbt_NotDo.UseVisualStyleBackColor = True
        '
        'rbt_Do
        '
        Me.rbt_Do.AutoSize = True
        Me.rbt_Do.Font = New System.Drawing.Font("Tahoma", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rbt_Do.Location = New System.Drawing.Point(161, 32)
        Me.rbt_Do.Name = "rbt_Do"
        Me.rbt_Do.Size = New System.Drawing.Size(208, 20)
        Me.rbt_Do.TabIndex = 13
        Me.rbt_Do.TabStop = True
        Me.rbt_Do.Text = "کار به طور کامل انجام شده است."
        Me.rbt_Do.UseVisualStyleBackColor = True
        '
        'txt_NoFormDo
        '
        Me.txt_NoFormDo.CheckExistValueInDb = False
        Me.txt_NoFormDo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_NoFormDo.CurrencyUnit = "ریال"
        Me.txt_NoFormDo.DefaultValue = ""
        Me.txt_NoFormDo.FillWithMaxInDb = False
        Me.txt_NoFormDo.IsRequired = False
        Me.txt_NoFormDo.Location = New System.Drawing.Point(445, 55)
        Me.txt_NoFormDo.MaxDecimalLength = 2
        Me.txt_NoFormDo.Multiline = True
        Me.txt_NoFormDo.Name = "txt_NoFormDo"
        Me.txt_NoFormDo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_NoFormDo.Size = New System.Drawing.Size(158, 26)
        Me.txt_NoFormDo.SpellControl = Nothing
        Me.txt_NoFormDo.TabIndex = 11
        Me.txt_NoFormDo.Tag = "Pishnahad"
        Me.txt_NoFormDo.Title = Nothing
        Me.txt_NoFormDo.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_NoFormDo.UseForData = True
        Me.txt_NoFormDo.ValidateCheckExistOnEdit = False
        Me.txt_NoFormDo.Value = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(609, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 16)
        Me.Label12.TabIndex = 221
        Me.Label12.Text = "شماره فرم/شماره نامه"
        '
        'txt_TarikhDo
        '
        Me.txt_TarikhDo.CheckExistValueInDb = False
        Me.txt_TarikhDo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhDo.CurrencyUnit = "ریال"
        Me.txt_TarikhDo.DefaultValue = ""
        Me.txt_TarikhDo.FillWithMaxInDb = False
        Me.txt_TarikhDo.IsRequired = False
        Me.txt_TarikhDo.Location = New System.Drawing.Point(445, 28)
        Me.txt_TarikhDo.MaxDecimalLength = 2
        Me.txt_TarikhDo.Name = "txt_TarikhDo"
        Me.txt_TarikhDo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhDo.Size = New System.Drawing.Size(159, 23)
        Me.txt_TarikhDo.SpellControl = Nothing
        Me.txt_TarikhDo.TabIndex = 10
        Me.txt_TarikhDo.TabStop = False
        Me.txt_TarikhDo.Tag = "Tarikh_Do"
        Me.txt_TarikhDo.Title = Nothing
        Me.txt_TarikhDo.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhDo.UseForData = True
        Me.txt_TarikhDo.ValidateCheckExistOnEdit = False
        Me.txt_TarikhDo.Value = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(610, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "تاریخ انجام کار"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_SHow)
        Me.Panel2.Controls.Add(Me.btn_Before)
        Me.Panel2.Controls.Add(Me.btn_Next)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txt_TarikhSabt)
        Me.Panel2.Controls.Add(Me.txt_No)
        Me.Panel2.Location = New System.Drawing.Point(33, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(791, 40)
        Me.Panel2.TabIndex = 227
        '
        'btn_SHow
        '
        Me.btn_SHow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SHow.Image = CType(resources.GetObject("btn_SHow.Image"), System.Drawing.Image)
        Me.btn_SHow.Location = New System.Drawing.Point(546, 2)
        Me.btn_SHow.Name = "btn_SHow"
        Me.btn_SHow.Size = New System.Drawing.Size(32, 30)
        Me.btn_SHow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SHow.TabIndex = 144
        Me.btn_SHow.TabStop = False
        '
        'btn_Before
        '
        Me.btn_Before.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Before.Image = CType(resources.GetObject("btn_Before.Image"), System.Drawing.Image)
        Me.btn_Before.Location = New System.Drawing.Point(510, 3)
        Me.btn_Before.Name = "btn_Before"
        Me.btn_Before.Size = New System.Drawing.Size(30, 29)
        Me.btn_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Before.TabIndex = 143
        Me.btn_Before.TabStop = False
        Me.btn_Before.Visible = False
        '
        'btn_Next
        '
        Me.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next.Image = CType(resources.GetObject("btn_Next.Image"), System.Drawing.Image)
        Me.btn_Next.Location = New System.Drawing.Point(471, 3)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(32, 28)
        Me.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Next.TabIndex = 142
        Me.btn_Next.TabStop = False
        Me.btn_Next.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(738, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 17)
        Me.Label16.TabIndex = 141
        Me.Label16.Text = "شماره"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(178, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 17)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "تاریخ ثبت"
        '
        'txt_TarikhSabt
        '
        Me.txt_TarikhSabt.CheckExistValueInDb = False
        Me.txt_TarikhSabt.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhSabt.CurrencyUnit = "ریال"
        Me.txt_TarikhSabt.DefaultValue = ""
        Me.txt_TarikhSabt.FillWithMaxInDb = False
        Me.txt_TarikhSabt.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_TarikhSabt.IsRequired = True
        Me.txt_TarikhSabt.Location = New System.Drawing.Point(20, 6)
        Me.txt_TarikhSabt.MaxDecimalLength = 2
        Me.txt_TarikhSabt.Name = "txt_TarikhSabt"
        Me.txt_TarikhSabt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhSabt.Size = New System.Drawing.Size(138, 24)
        Me.txt_TarikhSabt.SpellControl = Nothing
        Me.txt_TarikhSabt.TabIndex = 1001
        Me.txt_TarikhSabt.TabStop = False
        Me.txt_TarikhSabt.Tag = ""
        Me.txt_TarikhSabt.Title = Nothing
        Me.txt_TarikhSabt.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhSabt.UseForData = True
        Me.txt_TarikhSabt.ValidateCheckExistOnEdit = False
        Me.txt_TarikhSabt.Value = ""
        '
        'txt_No
        '
        Me.txt_No.CheckExistValueInDb = False
        Me.txt_No.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_No.CurrencyUnit = "ریال"
        Me.txt_No.DefaultValue = ""
        Me.txt_No.FillWithMaxInDb = False
        Me.txt_No.IsRequired = True
        Me.txt_No.Location = New System.Drawing.Point(586, 5)
        Me.txt_No.MaxDecimalLength = 2
        Me.txt_No.Name = "txt_No"
        Me.txt_No.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_No.Size = New System.Drawing.Size(150, 23)
        Me.txt_No.SpellControl = Nothing
        Me.txt_No.TabIndex = 1000
        Me.txt_No.Tag = ""
        Me.txt_No.Title = Nothing
        Me.txt_No.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_No.UseForData = True
        Me.txt_No.ValidateCheckExistOnEdit = False
        Me.txt_No.Value = ""
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_RecomendationSubjectTableAdapter
        '
        Me.Pm_RecomendationSubjectTableAdapter.ClearBeforeFill = True
        '
        'Pm_SubRecomendationSubjectTableAdapter
        '
        Me.Pm_SubRecomendationSubjectTableAdapter.ClearBeforeFill = True
        '
        'PmPishnahdBindingSource
        '
        Me.PmPishnahdBindingSource.DataMember = "Pm_Pishnahd"
        Me.PmPishnahdBindingSource.DataSource = Me.Ds_Pm
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(829, 382)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(334, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 231
        Me.Label10.Text = "فرستنده"
        '
        'cmb_Sender
        '
        Me.cmb_Sender.AutoComplete = True
        Me.cmb_Sender.DataSource = Me.PmSenderBindingSource
        Me.cmb_Sender.DisplayMember = "Name"
        Me.cmb_Sender.EnterStop = True
        Me.cmb_Sender.FormattingEnabled = True
        Me.cmb_Sender.IsRequired = False
        Me.cmb_Sender.LimitedToList = True
        Me.cmb_Sender.Location = New System.Drawing.Point(136, 111)
        Me.cmb_Sender.Name = "cmb_Sender"
        Me.cmb_Sender.OpenOnFoucus = False
        Me.cmb_Sender.Size = New System.Drawing.Size(194, 24)
        Me.cmb_Sender.TabIndex = 230
        Me.cmb_Sender.Tag = "Srl_Sender"
        Me.cmb_Sender.ValueMember = "Srl"
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
        'Frm_Pishnahad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(856, 688)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Pishnahad"
        Me.Text = "ثبت پیشنهادات"
        Me.Controls.SetChildIndex(Me.gbx_Fields, 0)
        Me.Controls.SetChildIndex(Me.gbx_Buttons, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.gbx_Buttons.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSubRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_SHow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPishnahdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSenderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Srl_Device As CS_Component.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbt_Line As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbt_Post As System.Windows.Forms.RadioButton
    Friend WithEvents txt_tarikh As CS_Component.TextBox
    Friend WithEvents cmb_Line As VB_Component.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_NoForm As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_SelectTajhiz As System.Windows.Forms.Button
    Friend WithEvents txt_Sug As CS_Component.TextBox
    Friend WithEvents txt_TajhizNameForSave As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_SubRecom As VB_Component.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_RecomSubject As VB_Component.ComboBox
    Friend WithEvents cmb_Vahde As VB_Component.ComboBox
    Friend WithEvents txt_Dis As CS_Component.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_NotDo As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Do As System.Windows.Forms.RadioButton
    Friend WithEvents txt_NoFormDo As CS_Component.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_TarikhDo As CS_Component.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_SHow As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Before As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Next As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_TarikhSabt As CS_Component.TextBox
    Friend WithEvents txt_No As CS_Component.TextBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmRecomendationSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_RecomendationSubjectTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_RecomendationSubjectTableAdapter
    Friend WithEvents PmSubRecomendationSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_SubRecomendationSubjectTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_SubRecomendationSubjectTableAdapter
    Friend WithEvents PmPishnahdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_PTime As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Sub As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_Sender As VB_Component.ComboBox
    Friend WithEvents PmSenderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_SenderTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_SenderTableAdapter
End Class