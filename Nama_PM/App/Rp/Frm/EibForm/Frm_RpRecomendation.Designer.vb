<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpRecomendation
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
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmHadeseKhesaratDeviceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.PmSubRecomendationSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PmRecomendationSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_RecomendationSubjectTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_RecomendationSubjectTableAdapter
        Me.Pm_SubRecomendationSubjectTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_SubRecomendationSubjectTableAdapter
        Me.Pm_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.PmHadeseKhesaratDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Hadese_KhesaratDeviceTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
        Me.Pm_Hadese_KhesaratDeviceTableAdapter1 = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
        Me.PmPostPishnahdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Post_PishnahdTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_Post_PishnahdTableAdapter
        Me.txt_FromDate = New CS_Component.TextBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.chk_AllDate = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_RecomSubject = New VB_Component.ComboBox
        Me.cmb_SubRecom = New VB_Component.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_Ashkhas = New VB_Component.ComboBox
        Me.cmb_Post = New VB_Component.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Desc = New CS_Component.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_Vahde = New VB_Component.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_SelectTajhiz = New System.Windows.Forms.Button
        Me.txt_TajhizNameForSave = New CS_Component.TextBox
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSubRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostPishnahdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 324)
        Me.gbx_Buttons.Size = New System.Drawing.Size(625, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(521, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.GroupBox2)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(626, 284)
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "Pm_Vahed"
        Me.BindingSource3.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmHadeseKhesaratDeviceBindingSource1
        '
        Me.PmHadeseKhesaratDeviceBindingSource1.DataMember = "Pm_Hadese_KhesaratDevice"
        Me.PmHadeseKhesaratDeviceBindingSource1.DataSource = Me.Ds_Hadese
        '
        'Ds_Hadese
        '
        Me.Ds_Hadese.DataSetName = "Ds_Hadese"
        Me.Ds_Hadese.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "Pm_Post"
        Me.BindingSource4.DataSource = Me.Ds_Pm
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
        'PmSubRecomendationSubjectBindingSource
        '
        Me.PmSubRecomendationSubjectBindingSource.DataMember = "Pm_SubRecomendationSubject"
        Me.PmSubRecomendationSubjectBindingSource.DataSource = Me.Ds_Pm
        '
        'PmRecomendationSubjectBindingSource
        '
        Me.PmRecomendationSubjectBindingSource.DataMember = "Pm_RecomendationSubject"
        Me.PmRecomendationSubjectBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_RecomendationSubjectTableAdapter
        '
        Me.Pm_RecomendationSubjectTableAdapter.ClearBeforeFill = True
        '
        'Pm_SubRecomendationSubjectTableAdapter
        '
        Me.Pm_SubRecomendationSubjectTableAdapter.ClearBeforeFill = True
        '
        'Pm_AshkhasTableAdapter
        '
        Me.Pm_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'PmHadeseKhesaratDeviceBindingSource
        '
        Me.PmHadeseKhesaratDeviceBindingSource.DataMember = "Pm_Hadese_KhesaratDevice"
        Me.PmHadeseKhesaratDeviceBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_Hadese_KhesaratDeviceTableAdapter
        '
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.ClearBeforeFill = True
        '
        'Pm_Hadese_KhesaratDeviceTableAdapter1
        '
        Me.Pm_Hadese_KhesaratDeviceTableAdapter1.ClearBeforeFill = True
        '
        'PmPostPishnahdBindingSource
        '
        Me.PmPostPishnahdBindingSource.DataMember = "Pm_Post_Pishnahd"
        Me.PmPostPishnahdBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_Post_PishnahdTableAdapter
        '
        Me.Pm_Post_PishnahdTableAdapter.ClearBeforeFill = True
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(311, 34)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(143, 25)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 1
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
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(78, 34)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(143, 25)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 2
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = ""
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(460, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 18)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "تاریخ پیشنهاد: از"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(227, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 18)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "تا"
        '
        'chk_AllDate
        '
        Me.chk_AllDate.AutoSize = True
        Me.chk_AllDate.Location = New System.Drawing.Point(9, 36)
        Me.chk_AllDate.Name = "chk_AllDate"
        Me.chk_AllDate.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllDate.TabIndex = 146
        Me.chk_AllDate.Text = "همه"
        Me.chk_AllDate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(510, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "موضوع"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 151
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
        Me.cmb_RecomSubject.Location = New System.Drawing.Point(310, 73)
        Me.cmb_RecomSubject.Name = "cmb_RecomSubject"
        Me.cmb_RecomSubject.OpenOnFoucus = False
        Me.cmb_RecomSubject.Size = New System.Drawing.Size(194, 26)
        Me.cmb_RecomSubject.TabIndex = 148
        Me.cmb_RecomSubject.Tag = "Srl_RecomSubject"
        Me.cmb_RecomSubject.ValueMember = "Srl"
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
        Me.cmb_SubRecom.Location = New System.Drawing.Point(8, 73)
        Me.cmb_SubRecom.Name = "cmb_SubRecom"
        Me.cmb_SubRecom.OpenOnFoucus = False
        Me.cmb_SubRecom.Size = New System.Drawing.Size(194, 26)
        Me.cmb_SubRecom.TabIndex = 149
        Me.cmb_SubRecom.Tag = "Srl_SubRecomSubject"
        Me.cmb_SubRecom.ValueMember = "Srl"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "پیشنهاد دهنده"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(510, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "پست"
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
        Me.cmb_Ashkhas.Location = New System.Drawing.Point(310, 117)
        Me.cmb_Ashkhas.Name = "cmb_Ashkhas"
        Me.cmb_Ashkhas.OpenOnFoucus = False
        Me.cmb_Ashkhas.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Ashkhas.TabIndex = 218
        Me.cmb_Ashkhas.Tag = "Srl_Pm_Ashkhas"
        Me.cmb_Ashkhas.ValueMember = "Srl"
        '
        'cmb_Post
        '
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.BindingSource4
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = True
        Me.cmb_Post.Location = New System.Drawing.Point(310, 157)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Post.TabIndex = 221
        Me.cmb_Post.Tag = "Srl_Post"
        Me.cmb_Post.ValueMember = "Srl"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(510, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 18)
        Me.Label5.TabIndex = 223
        Me.Label5.Text = "شرح پیشنهاد"
        '
        'txt_Desc
        '
        Me.txt_Desc.CheckExistValueInDb = False
        Me.txt_Desc.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Desc.CurrencyUnit = "ریال"
        Me.txt_Desc.DefaultValue = ""
        Me.txt_Desc.FillWithMaxInDb = False
        Me.txt_Desc.IsRequired = False
        Me.txt_Desc.Location = New System.Drawing.Point(9, 194)
        Me.txt_Desc.MaxDecimalLength = 2
        Me.txt_Desc.Multiline = True
        Me.txt_Desc.Name = "txt_Desc"
        Me.txt_Desc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Desc.Size = New System.Drawing.Size(495, 53)
        Me.txt_Desc.SpellControl = Nothing
        Me.txt_Desc.TabIndex = 222
        Me.txt_Desc.Tag = "Pishnahad"
        Me.txt_Desc.Title = Nothing
        Me.txt_Desc.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Desc.UseForData = True
        Me.txt_Desc.ValidateCheckExistOnEdit = False
        Me.txt_Desc.Value = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 18)
        Me.Label7.TabIndex = 226
        Me.Label7.Text = "واحد"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(207, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 227
        Me.Label6.Text = "تجهیز"
        '
        'cmb_Vahde
        '
        Me.cmb_Vahde.AutoComplete = True
        Me.cmb_Vahde.DataSource = Me.BindingSource3
        Me.cmb_Vahde.DisplayMember = "نام واحد"
        Me.cmb_Vahde.EnterStop = True
        Me.cmb_Vahde.FormattingEnabled = True
        Me.cmb_Vahde.IsRequired = False
        Me.cmb_Vahde.LimitedToList = True
        Me.cmb_Vahde.Location = New System.Drawing.Point(8, 117)
        Me.cmb_Vahde.Name = "cmb_Vahde"
        Me.cmb_Vahde.OpenOnFoucus = False
        Me.cmb_Vahde.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Vahde.TabIndex = 225
        Me.cmb_Vahde.Tag = "Srl_Vahed"
        Me.cmb_Vahde.ValueMember = "Srl"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_SelectTajhiz)
        Me.GroupBox2.Controls.Add(Me.txt_TajhizNameForSave)
        Me.GroupBox2.Controls.Add(Me.cmb_Vahde)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_Desc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmb_Post)
        Me.GroupBox2.Controls.Add(Me.cmb_Ashkhas)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_SubRecom)
        Me.GroupBox2.Controls.Add(Me.cmb_RecomSubject)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chk_AllDate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_ToDate)
        Me.GroupBox2.Controls.Add(Me.txt_FromDate)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(620, 260)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "فیلتر بر اساس"
        '
        'btn_SelectTajhiz
        '
        Me.btn_SelectTajhiz.Location = New System.Drawing.Point(9, 153)
        Me.btn_SelectTajhiz.Name = "btn_SelectTajhiz"
        Me.btn_SelectTajhiz.Size = New System.Drawing.Size(31, 25)
        Me.btn_SelectTajhiz.TabIndex = 229
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
        Me.txt_TajhizNameForSave.Location = New System.Drawing.Point(44, 153)
        Me.txt_TajhizNameForSave.MaxDecimalLength = 2
        Me.txt_TajhizNameForSave.Name = "txt_TajhizNameForSave"
        Me.txt_TajhizNameForSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TajhizNameForSave.Size = New System.Drawing.Size(157, 25)
        Me.txt_TajhizNameForSave.SpellControl = Nothing
        Me.txt_TajhizNameForSave.TabIndex = 228
        Me.txt_TajhizNameForSave.Tag = ""
        Me.txt_TajhizNameForSave.Title = Nothing
        Me.txt_TajhizNameForSave.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_TajhizNameForSave.UseForData = True
        Me.txt_TajhizNameForSave.ValidateCheckExistOnEdit = False
        Me.txt_TajhizNameForSave.Value = ""
        '
        'Frm_RpRecomendation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(652, 412)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpRecomendation"
        Me.Text = "گزارش فرم نقص"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSubRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmRecomendationSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostPishnahdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Names As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibFormMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibFormMasterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmRecomendationSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_RecomendationSubjectTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_RecomendationSubjectTableAdapter
    Friend WithEvents PmSubRecomendationSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_SubRecomendationSubjectTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_SubRecomendationSubjectTableAdapter
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents PmAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_AshkhasTableAdapter
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter1 As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents PmPostPishnahdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Post_PishnahdTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_Post_PishnahdTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Vahde As VB_Component.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Desc As CS_Component.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents cmb_Ashkhas As VB_Component.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_SubRecom As VB_Component.ComboBox
    Friend WithEvents cmb_RecomSubject As VB_Component.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_AllDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents btn_SelectTajhiz As System.Windows.Forms.Button
    Friend WithEvents txt_TajhizNameForSave As CS_Component.TextBox
End Class
