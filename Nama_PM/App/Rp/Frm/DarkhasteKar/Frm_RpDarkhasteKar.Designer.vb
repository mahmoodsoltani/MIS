<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpDarkhasteKar
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.srl_Device = New CS_Component.TextBox
        Me.btn_SelectTajhiz = New System.Windows.Forms.Button
        Me.txt_Tajhiz = New CS_Component.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_NoStatus = New System.Windows.Forms.RadioButton
        Me.Rb_Cancle = New System.Windows.Forms.RadioButton
        Me.Rb_NoExecute = New System.Windows.Forms.RadioButton
        Me.rb_Execute = New System.Windows.Forms.RadioButton
        Me.rb_All = New System.Windows.Forms.RadioButton
        Me.cmb_Sarparast = New VB_Component.ComboBox
        Me.PmGroupMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Group = New VB_Component.ComboBox
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chk_AllTajhiz = New System.Windows.Forms.CheckBox
        Me.chk_AllSarparast = New System.Windows.Forms.CheckBox
        Me.chk_AllPost = New System.Windows.Forms.CheckBox
        Me.chk_AllGroup = New System.Windows.Forms.CheckBox
        Me.chk_AllVahed = New System.Windows.Forms.CheckBox
        Me.chk_AllNo = New System.Windows.Forms.CheckBox
        Me.chk_AllRegisterDate = New System.Windows.Forms.CheckBox
        Me.chk_AllDate = New System.Windows.Forms.CheckBox
        Me.txt_No = New CS_Component.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_RozeHafte = New System.Windows.Forms.Label
        Me.txt_RegisterToDate = New CS_Component.TextBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.txt_RegistreFromDate = New CS_Component.TextBox
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_GroupMemberTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupMemberTableAdapter
        Me.txt_SrlTajhiz = New CS_Component.TextBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PmGroupMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Buttons.Location = New System.Drawing.Point(12, 372)
        Me.gbx_Buttons.Size = New System.Drawing.Size(805, 50)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(701, 17)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Fields.Controls.Add(Me.GroupBox2)
        Me.gbx_Fields.Size = New System.Drawing.Size(805, 334)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_SrlTajhiz)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.srl_Device)
        Me.GroupBox2.Controls.Add(Me.btn_SelectTajhiz)
        Me.GroupBox2.Controls.Add(Me.txt_Tajhiz)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.cmb_Sarparast)
        Me.GroupBox2.Controls.Add(Me.cmb_Post)
        Me.GroupBox2.Controls.Add(Me.cmb_Group)
        Me.GroupBox2.Controls.Add(Me.cmb_Vahed)
        Me.GroupBox2.Controls.Add(Me.Chk_AllTajhiz)
        Me.GroupBox2.Controls.Add(Me.chk_AllSarparast)
        Me.GroupBox2.Controls.Add(Me.chk_AllPost)
        Me.GroupBox2.Controls.Add(Me.chk_AllGroup)
        Me.GroupBox2.Controls.Add(Me.chk_AllVahed)
        Me.GroupBox2.Controls.Add(Me.chk_AllNo)
        Me.GroupBox2.Controls.Add(Me.chk_AllRegisterDate)
        Me.GroupBox2.Controls.Add(Me.chk_AllDate)
        Me.GroupBox2.Controls.Add(Me.txt_No)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lbl_RozeHafte)
        Me.GroupBox2.Controls.Add(Me.txt_RegisterToDate)
        Me.GroupBox2.Controls.Add(Me.txt_ToDate)
        Me.GroupBox2.Controls.Add(Me.txt_RegistreFromDate)
        Me.GroupBox2.Controls.Add(Me.txt_FromDate)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(799, 312)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "فیلتر بر اساس"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton6)
        Me.GroupBox4.Location = New System.Drawing.Point(25, 121)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(113, 83)
        Me.GroupBox4.TabIndex = 150
        Me.GroupBox4.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(44, 52)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 20)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.Text = "برقدار"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(21, 34)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 20)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.Text = "خاموشی"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Location = New System.Drawing.Point(10, 16)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(89, 20)
        Me.RadioButton6.TabIndex = 12
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "تمام فرم ها"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(113, 89)
        Me.GroupBox3.TabIndex = 149
        Me.GroupBox3.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(15, 51)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(84, 20)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.Text = "غیرپیوسته"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(33, 33)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(66, 20)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.Text = "پیوسته"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(10, 16)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(89, 20)
        Me.RadioButton5.TabIndex = 12
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "تمام فرم ها"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'srl_Device
        '
        Me.srl_Device.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.srl_Device.CheckExistValueInDb = False
        Me.srl_Device.ColorOnFocus = System.Drawing.Color.Yellow
        Me.srl_Device.CurrencyUnit = "ریال"
        Me.srl_Device.DefaultValue = ""
        Me.srl_Device.Enabled = False
        Me.srl_Device.FillWithMaxInDb = False
        Me.srl_Device.ForeColor = System.Drawing.SystemColors.Info
        Me.srl_Device.IsRequired = True
        Me.srl_Device.Location = New System.Drawing.Point(-19, 202)
        Me.srl_Device.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.srl_Device.MaxDecimalLength = 2
        Me.srl_Device.Name = "srl_Device"
        Me.srl_Device.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.srl_Device.Size = New System.Drawing.Size(10, 23)
        Me.srl_Device.SpellControl = Nothing
        Me.srl_Device.TabIndex = 254
        Me.srl_Device.Tag = ""
        Me.srl_Device.Title = Nothing
        Me.srl_Device.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.srl_Device.UseForData = True
        Me.srl_Device.ValidateCheckExistOnEdit = False
        Me.srl_Device.Value = ""
        Me.srl_Device.Visible = False
        '
        'btn_SelectTajhiz
        '
        Me.btn_SelectTajhiz.Location = New System.Drawing.Point(10, 223)
        Me.btn_SelectTajhiz.Name = "btn_SelectTajhiz"
        Me.btn_SelectTajhiz.Size = New System.Drawing.Size(31, 25)
        Me.btn_SelectTajhiz.TabIndex = 1004
        Me.btn_SelectTajhiz.Text = "..."
        Me.btn_SelectTajhiz.UseVisualStyleBackColor = True
        '
        'txt_Tajhiz
        '
        Me.txt_Tajhiz.CheckExistValueInDb = False
        Me.txt_Tajhiz.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Tajhiz.CurrencyUnit = "ریال"
        Me.txt_Tajhiz.DefaultValue = ""
        Me.txt_Tajhiz.Enabled = False
        Me.txt_Tajhiz.FillWithMaxInDb = False
        Me.txt_Tajhiz.IsRequired = False
        Me.txt_Tajhiz.Location = New System.Drawing.Point(47, 224)
        Me.txt_Tajhiz.MaxDecimalLength = 2
        Me.txt_Tajhiz.Name = "txt_Tajhiz"
        Me.txt_Tajhiz.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Tajhiz.Size = New System.Drawing.Size(150, 23)
        Me.txt_Tajhiz.SpellControl = Nothing
        Me.txt_Tajhiz.TabIndex = 1005
        Me.txt_Tajhiz.Tag = ""
        Me.txt_Tajhiz.Title = Nothing
        Me.txt_Tajhiz.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Tajhiz.UseForData = True
        Me.txt_Tajhiz.ValidateCheckExistOnEdit = False
        Me.txt_Tajhiz.Value = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_NoStatus)
        Me.GroupBox1.Controls.Add(Me.Rb_Cancle)
        Me.GroupBox1.Controls.Add(Me.Rb_NoExecute)
        Me.GroupBox1.Controls.Add(Me.rb_Execute)
        Me.GroupBox1.Controls.Add(Me.rb_All)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 177)
        Me.GroupBox1.TabIndex = 148
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "وضعیت "
        '
        'rb_NoStatus
        '
        Me.rb_NoStatus.AutoSize = True
        Me.rb_NoStatus.Location = New System.Drawing.Point(18, 125)
        Me.rb_NoStatus.Name = "rb_NoStatus"
        Me.rb_NoStatus.Size = New System.Drawing.Size(121, 20)
        Me.rb_NoStatus.TabIndex = 16
        Me.rb_NoStatus.TabStop = True
        Me.rb_NoStatus.Text = "وضعیت نامشخص"
        Me.rb_NoStatus.UseVisualStyleBackColor = True
        '
        'Rb_Cancle
        '
        Me.Rb_Cancle.AutoSize = True
        Me.Rb_Cancle.Location = New System.Drawing.Point(55, 100)
        Me.Rb_Cancle.Name = "Rb_Cancle"
        Me.Rb_Cancle.Size = New System.Drawing.Size(84, 20)
        Me.Rb_Cancle.TabIndex = 15
        Me.Rb_Cancle.Text = "ابطال شده"
        Me.Rb_Cancle.UseVisualStyleBackColor = True
        '
        'Rb_NoExecute
        '
        Me.Rb_NoExecute.AutoSize = True
        Me.Rb_NoExecute.Location = New System.Drawing.Point(49, 76)
        Me.Rb_NoExecute.Name = "Rb_NoExecute"
        Me.Rb_NoExecute.Size = New System.Drawing.Size(90, 20)
        Me.Rb_NoExecute.TabIndex = 13
        Me.Rb_NoExecute.Text = "کنسل شده"
        Me.Rb_NoExecute.UseVisualStyleBackColor = True
        '
        'rb_Execute
        '
        Me.rb_Execute.AutoSize = True
        Me.rb_Execute.Location = New System.Drawing.Point(59, 53)
        Me.rb_Execute.Name = "rb_Execute"
        Me.rb_Execute.Size = New System.Drawing.Size(80, 20)
        Me.rb_Execute.TabIndex = 14
        Me.rb_Execute.Text = "تایید شده"
        Me.rb_Execute.UseVisualStyleBackColor = True
        '
        'rb_All
        '
        Me.rb_All.AutoSize = True
        Me.rb_All.Checked = True
        Me.rb_All.Location = New System.Drawing.Point(50, 29)
        Me.rb_All.Name = "rb_All"
        Me.rb_All.Size = New System.Drawing.Size(89, 20)
        Me.rb_All.TabIndex = 12
        Me.rb_All.TabStop = True
        Me.rb_All.Text = "تمام فرم ها"
        Me.rb_All.UseVisualStyleBackColor = True
        '
        'cmb_Sarparast
        '
        Me.cmb_Sarparast.AllowDrop = True
        Me.cmb_Sarparast.AutoComplete = True
        Me.cmb_Sarparast.DataSource = Me.PmGroupMemberBindingSource
        Me.cmb_Sarparast.DisplayMember = "نام"
        Me.cmb_Sarparast.EnterStop = True
        Me.cmb_Sarparast.FormattingEnabled = True
        Me.cmb_Sarparast.IsRequired = False
        Me.cmb_Sarparast.LimitedToList = False
        Me.cmb_Sarparast.Location = New System.Drawing.Point(379, 224)
        Me.cmb_Sarparast.Name = "cmb_Sarparast"
        Me.cmb_Sarparast.OpenOnFoucus = False
        Me.cmb_Sarparast.Size = New System.Drawing.Size(305, 24)
        Me.cmb_Sarparast.TabIndex = 9
        Me.cmb_Sarparast.ValueMember = "Srl"
        '
        'PmGroupMemberBindingSource
        '
        Me.PmGroupMemberBindingSource.DataMember = "Pm_GroupMember"
        Me.PmGroupMemberBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_Post
        '
        Me.cmb_Post.AllowDrop = True
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PmPostBindingSource
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = False
        Me.cmb_Post.Location = New System.Drawing.Point(379, 194)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(305, 24)
        Me.cmb_Post.TabIndex = 9
        Me.cmb_Post.ValueMember = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_Group
        '
        Me.cmb_Group.AllowDrop = True
        Me.cmb_Group.AutoComplete = True
        Me.cmb_Group.DataSource = Me.PmGroupBindingSource
        Me.cmb_Group.DisplayMember = "نام"
        Me.cmb_Group.EnterStop = True
        Me.cmb_Group.FormattingEnabled = True
        Me.cmb_Group.IsRequired = False
        Me.cmb_Group.LimitedToList = False
        Me.cmb_Group.Location = New System.Drawing.Point(379, 164)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.OpenOnFoucus = False
        Me.cmb_Group.Size = New System.Drawing.Size(305, 24)
        Me.cmb_Group.TabIndex = 9
        Me.cmb_Group.ValueMember = "Srl"
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'cmb_Vahed
        '
        Me.cmb_Vahed.AllowDrop = True
        Me.cmb_Vahed.AutoComplete = True
        Me.cmb_Vahed.DataSource = Me.PmVahedBindingSource
        Me.cmb_Vahed.DisplayMember = "نام واحد"
        Me.cmb_Vahed.EnterStop = True
        Me.cmb_Vahed.FormattingEnabled = True
        Me.cmb_Vahed.IsRequired = False
        Me.cmb_Vahed.LimitedToList = False
        Me.cmb_Vahed.Location = New System.Drawing.Point(379, 134)
        Me.cmb_Vahed.Name = "cmb_Vahed"
        Me.cmb_Vahed.OpenOnFoucus = False
        Me.cmb_Vahed.Size = New System.Drawing.Size(305, 24)
        Me.cmb_Vahed.TabIndex = 8
        Me.cmb_Vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'Chk_AllTajhiz
        '
        Me.Chk_AllTajhiz.AutoSize = True
        Me.Chk_AllTajhiz.Location = New System.Drawing.Point(203, 228)
        Me.Chk_AllTajhiz.Name = "Chk_AllTajhiz"
        Me.Chk_AllTajhiz.Size = New System.Drawing.Size(99, 20)
        Me.Chk_AllTajhiz.TabIndex = 146
        Me.Chk_AllTajhiz.Text = "همه تجهیزات"
        Me.Chk_AllTajhiz.UseVisualStyleBackColor = True
        '
        'chk_AllSarparast
        '
        Me.chk_AllSarparast.AutoSize = True
        Me.chk_AllSarparast.Location = New System.Drawing.Point(322, 226)
        Me.chk_AllSarparast.Name = "chk_AllSarparast"
        Me.chk_AllSarparast.Size = New System.Drawing.Size(51, 20)
        Me.chk_AllSarparast.TabIndex = 146
        Me.chk_AllSarparast.Text = "همه"
        Me.chk_AllSarparast.UseVisualStyleBackColor = True
        '
        'chk_AllPost
        '
        Me.chk_AllPost.AutoSize = True
        Me.chk_AllPost.Location = New System.Drawing.Point(321, 198)
        Me.chk_AllPost.Name = "chk_AllPost"
        Me.chk_AllPost.Size = New System.Drawing.Size(51, 20)
        Me.chk_AllPost.TabIndex = 146
        Me.chk_AllPost.Text = "همه"
        Me.chk_AllPost.UseVisualStyleBackColor = True
        '
        'chk_AllGroup
        '
        Me.chk_AllGroup.AutoSize = True
        Me.chk_AllGroup.Location = New System.Drawing.Point(321, 168)
        Me.chk_AllGroup.Name = "chk_AllGroup"
        Me.chk_AllGroup.Size = New System.Drawing.Size(51, 20)
        Me.chk_AllGroup.TabIndex = 146
        Me.chk_AllGroup.Text = "همه"
        Me.chk_AllGroup.UseVisualStyleBackColor = True
        '
        'chk_AllVahed
        '
        Me.chk_AllVahed.AutoSize = True
        Me.chk_AllVahed.Location = New System.Drawing.Point(321, 137)
        Me.chk_AllVahed.Name = "chk_AllVahed"
        Me.chk_AllVahed.Size = New System.Drawing.Size(51, 20)
        Me.chk_AllVahed.TabIndex = 146
        Me.chk_AllVahed.Text = "همه"
        Me.chk_AllVahed.UseVisualStyleBackColor = True
        '
        'chk_AllNo
        '
        Me.chk_AllNo.AutoSize = True
        Me.chk_AllNo.Location = New System.Drawing.Point(321, 103)
        Me.chk_AllNo.Name = "chk_AllNo"
        Me.chk_AllNo.Size = New System.Drawing.Size(51, 20)
        Me.chk_AllNo.TabIndex = 146
        Me.chk_AllNo.Text = "همه"
        Me.chk_AllNo.UseVisualStyleBackColor = True
        '
        'chk_AllRegisterDate
        '
        Me.chk_AllRegisterDate.AutoSize = True
        Me.chk_AllRegisterDate.Location = New System.Drawing.Point(321, 41)
        Me.chk_AllRegisterDate.Name = "chk_AllRegisterDate"
        Me.chk_AllRegisterDate.Size = New System.Drawing.Size(51, 20)
        Me.chk_AllRegisterDate.TabIndex = 146
        Me.chk_AllRegisterDate.Text = "همه"
        Me.chk_AllRegisterDate.UseVisualStyleBackColor = True
        '
        'chk_AllDate
        '
        Me.chk_AllDate.AutoSize = True
        Me.chk_AllDate.Location = New System.Drawing.Point(321, 74)
        Me.chk_AllDate.Name = "chk_AllDate"
        Me.chk_AllDate.Size = New System.Drawing.Size(51, 20)
        Me.chk_AllDate.TabIndex = 146
        Me.chk_AllDate.Text = "همه"
        Me.chk_AllDate.UseVisualStyleBackColor = True
        '
        'txt_No
        '
        Me.txt_No.CheckExistValueInDb = True
        Me.txt_No.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_No.CurrencyUnit = "ریال"
        Me.txt_No.DefaultValue = ""
        Me.txt_No.FillWithMaxInDb = False
        Me.txt_No.IsRequired = True
        Me.txt_No.Location = New System.Drawing.Point(541, 103)
        Me.txt_No.MaxDecimalLength = 2
        Me.txt_No.Name = "txt_No"
        Me.txt_No.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_No.Size = New System.Drawing.Size(143, 23)
        Me.txt_No.SpellControl = Nothing
        Me.txt_No.TabIndex = 7
        Me.txt_No.Tag = ""
        Me.txt_No.Title = Nothing
        Me.txt_No.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_No.UseForData = True
        Me.txt_No.ValidateCheckExistOnEdit = False
        Me.txt_No.Value = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(525, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "تا"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(525, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "تا"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(691, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "سرپرست:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(691, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = " پست :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(690, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = " گروه:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(690, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = " واحد:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(690, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "شماره سامک:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(690, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "تاریخ ثبت: از"
        '
        'lbl_RozeHafte
        '
        Me.lbl_RozeHafte.AutoSize = True
        Me.lbl_RozeHafte.Location = New System.Drawing.Point(690, 78)
        Me.lbl_RozeHafte.Name = "lbl_RozeHafte"
        Me.lbl_RozeHafte.Size = New System.Drawing.Size(102, 16)
        Me.lbl_RozeHafte.TabIndex = 143
        Me.lbl_RozeHafte.Text = "تاریخ انجام کار: از"
        '
        'txt_RegisterToDate
        '
        Me.txt_RegisterToDate.CheckExistValueInDb = False
        Me.txt_RegisterToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_RegisterToDate.CurrencyUnit = "ریال"
        Me.txt_RegisterToDate.DefaultValue = ""
        Me.txt_RegisterToDate.FillWithMaxInDb = False
        Me.txt_RegisterToDate.IsRequired = True
        Me.txt_RegisterToDate.Location = New System.Drawing.Point(379, 38)
        Me.txt_RegisterToDate.MaxDecimalLength = 2
        Me.txt_RegisterToDate.Name = "txt_RegisterToDate"
        Me.txt_RegisterToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_RegisterToDate.Size = New System.Drawing.Size(143, 23)
        Me.txt_RegisterToDate.SpellControl = Nothing
        Me.txt_RegisterToDate.TabIndex = 2
        Me.txt_RegisterToDate.TabStop = False
        Me.txt_RegisterToDate.Tag = ""
        Me.txt_RegisterToDate.Title = Nothing
        Me.txt_RegisterToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_RegisterToDate.UseForData = True
        Me.txt_RegisterToDate.ValidateCheckExistOnEdit = False
        Me.txt_RegisterToDate.Value = ""
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(379, 73)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(143, 23)
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
        'txt_RegistreFromDate
        '
        Me.txt_RegistreFromDate.CheckExistValueInDb = False
        Me.txt_RegistreFromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_RegistreFromDate.CurrencyUnit = "ریال"
        Me.txt_RegistreFromDate.DefaultValue = ""
        Me.txt_RegistreFromDate.FillWithMaxInDb = False
        Me.txt_RegistreFromDate.IsRequired = True
        Me.txt_RegistreFromDate.Location = New System.Drawing.Point(541, 38)
        Me.txt_RegistreFromDate.MaxDecimalLength = 2
        Me.txt_RegistreFromDate.Name = "txt_RegistreFromDate"
        Me.txt_RegistreFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_RegistreFromDate.Size = New System.Drawing.Size(143, 23)
        Me.txt_RegistreFromDate.SpellControl = Nothing
        Me.txt_RegistreFromDate.TabIndex = 1
        Me.txt_RegistreFromDate.TabStop = False
        Me.txt_RegistreFromDate.Tag = ""
        Me.txt_RegistreFromDate.Title = Nothing
        Me.txt_RegistreFromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_RegistreFromDate.UseForData = True
        Me.txt_RegistreFromDate.ValidateCheckExistOnEdit = False
        Me.txt_RegistreFromDate.Value = ""
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(541, 71)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(143, 23)
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
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupMemberTableAdapter
        '
        Me.Pm_GroupMemberTableAdapter.ClearBeforeFill = True
        '
        'txt_SrlTajhiz
        '
        Me.txt_SrlTajhiz.CheckExistValueInDb = False
        Me.txt_SrlTajhiz.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SrlTajhiz.CurrencyUnit = "ریال"
        Me.txt_SrlTajhiz.DefaultValue = ""
        Me.txt_SrlTajhiz.FillWithMaxInDb = False
        Me.txt_SrlTajhiz.IsRequired = True
        Me.txt_SrlTajhiz.Location = New System.Drawing.Point(0, 225)
        Me.txt_SrlTajhiz.MaxDecimalLength = 2
        Me.txt_SrlTajhiz.Name = "txt_SrlTajhiz"
        Me.txt_SrlTajhiz.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SrlTajhiz.Size = New System.Drawing.Size(10, 23)
        Me.txt_SrlTajhiz.SpellControl = Nothing
        Me.txt_SrlTajhiz.TabIndex = 1006
        Me.txt_SrlTajhiz.Tag = ""
        Me.txt_SrlTajhiz.Title = Nothing
        Me.txt_SrlTajhiz.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_SrlTajhiz.UseForData = True
        Me.txt_SrlTajhiz.ValidateCheckExistOnEdit = False
        Me.txt_SrlTajhiz.Value = ""
        Me.txt_SrlTajhiz.Visible = False
        '
        'Frm_RpDarkhasteKar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 458)
        Me.Name = "Frm_RpDarkhasteKar"
        Me.Text = "گزارش درخواست کار"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PmGroupMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_SelectTajhiz As System.Windows.Forms.Button
    Friend WithEvents txt_Tajhiz As CS_Component.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_All As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_Sarparast As VB_Component.ComboBox
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents cmb_Group As VB_Component.ComboBox
    Friend WithEvents cmb_Vahed As VB_Component.ComboBox
    Friend WithEvents Chk_AllTajhiz As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllSarparast As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllPost As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllVahed As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllNo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllRegisterDate As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllDate As System.Windows.Forms.CheckBox
    Friend WithEvents txt_No As CS_Component.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_RozeHafte As System.Windows.Forms.Label
    Friend WithEvents txt_RegisterToDate As CS_Component.TextBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_RegistreFromDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents rb_NoStatus As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Cancle As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_NoExecute As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Execute As System.Windows.Forms.RadioButton
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmGroupMemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupMemberTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupMemberTableAdapter
    Friend WithEvents srl_Device As CS_Component.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents txt_SrlTajhiz As CS_Component.TextBox
End Class
