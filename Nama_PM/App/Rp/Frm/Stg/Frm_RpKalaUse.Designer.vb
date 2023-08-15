<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpKalaUse
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
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PM_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.RpPmKalaUseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_Pm_KalaUseTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_Pm_KalaUseTableAdapter
        Me.pl_Date = New System.Windows.Forms.Panel
        Me.txt_FromDate = New CS_Component.TextBox
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chk_AllGroup = New System.Windows.Forms.CheckBox
        Me.chk_AllPost = New System.Windows.Forms.CheckBox
        Me.chk_AllKala = New System.Windows.Forms.CheckBox
        Me.chk_AllWorkFormNo = New System.Windows.Forms.CheckBox
        Me.chk_Date = New System.Windows.Forms.CheckBox
        Me.txt_WorkFormNo = New CS_Component.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_RozeHafte = New System.Windows.Forms.Label
        Me.cmb_Post = New VB_Component.ComboBox
        Me.cmb_Group = New VB_Component.ComboBox
        Me.KalaSelectManager2 = New Nama_PM.KalaSelectManager
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpPmKalaUseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_Date.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 302)
        Me.gbx_Buttons.Size = New System.Drawing.Size(577, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش"
        Me.btn_Save.Location = New System.Drawing.Point(473, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.pl_Date)
        Me.gbx_Fields.Controls.Add(Me.chk_AllGroup)
        Me.gbx_Fields.Controls.Add(Me.chk_AllPost)
        Me.gbx_Fields.Controls.Add(Me.chk_AllKala)
        Me.gbx_Fields.Controls.Add(Me.chk_AllWorkFormNo)
        Me.gbx_Fields.Controls.Add(Me.chk_Date)
        Me.gbx_Fields.Controls.Add(Me.txt_WorkFormNo)
        Me.gbx_Fields.Controls.Add(Me.Label6)
        Me.gbx_Fields.Controls.Add(Me.Label5)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.lbl_RozeHafte)
        Me.gbx_Fields.Controls.Add(Me.cmb_Post)
        Me.gbx_Fields.Controls.Add(Me.cmb_Group)
        Me.gbx_Fields.Controls.Add(Me.KalaSelectManager2)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(578, 262)
        Me.gbx_Fields.Text = "فیلتر بر اساس"
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "PM_Post"
        Me.BindingSource3.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "Pm_Group"
        Me.BindingSource4.DataSource = Me.Ds_Pm
        '
        'PM_PostTableAdapter
        '
        Me.PM_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RpPmKalaUseBindingSource
        '
        Me.RpPmKalaUseBindingSource.DataMember = "Rp_Pm_KalaUse"
        Me.RpPmKalaUseBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_Pm_KalaUseTableAdapter
        '
        Me.Rp_Pm_KalaUseTableAdapter.ClearBeforeFill = True
        '
        'pl_Date
        '
        Me.pl_Date.Controls.Add(Me.txt_FromDate)
        Me.pl_Date.Controls.Add(Me.txt_ToDate)
        Me.pl_Date.Controls.Add(Me.Label1)
        Me.pl_Date.Location = New System.Drawing.Point(76, 24)
        Me.pl_Date.Name = "pl_Date"
        Me.pl_Date.Size = New System.Drawing.Size(351, 39)
        Me.pl_Date.TabIndex = 163
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(202, 7)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(143, 25)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 141
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
        Me.txt_ToDate.Location = New System.Drawing.Point(9, 7)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(143, 25)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 141
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = ""
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 18)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "تا"
        '
        'chk_AllGroup
        '
        Me.chk_AllGroup.AutoSize = True
        Me.chk_AllGroup.Checked = True
        Me.chk_AllGroup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_AllGroup.Location = New System.Drawing.Point(12, 127)
        Me.chk_AllGroup.Name = "chk_AllGroup"
        Me.chk_AllGroup.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllGroup.TabIndex = 158
        Me.chk_AllGroup.Text = "همه"
        Me.chk_AllGroup.UseVisualStyleBackColor = True
        '
        'chk_AllPost
        '
        Me.chk_AllPost.AutoSize = True
        Me.chk_AllPost.Checked = True
        Me.chk_AllPost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_AllPost.Location = New System.Drawing.Point(12, 82)
        Me.chk_AllPost.Name = "chk_AllPost"
        Me.chk_AllPost.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllPost.TabIndex = 157
        Me.chk_AllPost.Text = "همه"
        Me.chk_AllPost.UseVisualStyleBackColor = True
        '
        'chk_AllKala
        '
        Me.chk_AllKala.AutoSize = True
        Me.chk_AllKala.Checked = True
        Me.chk_AllKala.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_AllKala.Location = New System.Drawing.Point(13, 215)
        Me.chk_AllKala.Name = "chk_AllKala"
        Me.chk_AllKala.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllKala.TabIndex = 159
        Me.chk_AllKala.Text = "همه"
        Me.chk_AllKala.UseVisualStyleBackColor = True
        '
        'chk_AllWorkFormNo
        '
        Me.chk_AllWorkFormNo.AutoSize = True
        Me.chk_AllWorkFormNo.Checked = True
        Me.chk_AllWorkFormNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_AllWorkFormNo.Location = New System.Drawing.Point(13, 170)
        Me.chk_AllWorkFormNo.Name = "chk_AllWorkFormNo"
        Me.chk_AllWorkFormNo.Size = New System.Drawing.Size(55, 22)
        Me.chk_AllWorkFormNo.TabIndex = 161
        Me.chk_AllWorkFormNo.Text = "همه"
        Me.chk_AllWorkFormNo.UseVisualStyleBackColor = True
        '
        'chk_Date
        '
        Me.chk_Date.AutoSize = True
        Me.chk_Date.Checked = True
        Me.chk_Date.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Date.Location = New System.Drawing.Point(11, 39)
        Me.chk_Date.Name = "chk_Date"
        Me.chk_Date.Size = New System.Drawing.Size(55, 22)
        Me.chk_Date.TabIndex = 160
        Me.chk_Date.Text = "همه"
        Me.chk_Date.UseVisualStyleBackColor = True
        '
        'txt_WorkFormNo
        '
        Me.txt_WorkFormNo.CheckExistValueInDb = True
        Me.txt_WorkFormNo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_WorkFormNo.CurrencyUnit = "ریال"
        Me.txt_WorkFormNo.DefaultValue = ""
        Me.txt_WorkFormNo.FillWithMaxInDb = False
        Me.txt_WorkFormNo.IsRequired = True
        Me.txt_WorkFormNo.Location = New System.Drawing.Point(318, 170)
        Me.txt_WorkFormNo.MaxDecimalLength = 2
        Me.txt_WorkFormNo.Name = "txt_WorkFormNo"
        Me.txt_WorkFormNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_WorkFormNo.Size = New System.Drawing.Size(108, 25)
        Me.txt_WorkFormNo.SpellControl = Nothing
        Me.txt_WorkFormNo.TabIndex = 156
        Me.txt_WorkFormNo.Tag = ""
        Me.txt_WorkFormNo.Title = Nothing
        Me.txt_WorkFormNo.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_WorkFormNo.UseForData = True
        Me.txt_WorkFormNo.ValidateCheckExistOnEdit = False
        Me.txt_WorkFormNo.Value = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(431, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 18)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "مصرف توسط گروه :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(431, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 18)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "مصرف در پست :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(431, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "کالا :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(431, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "شماره فرم کار :"
        '
        'lbl_RozeHafte
        '
        Me.lbl_RozeHafte.AutoSize = True
        Me.lbl_RozeHafte.Location = New System.Drawing.Point(431, 36)
        Me.lbl_RozeHafte.Name = "lbl_RozeHafte"
        Me.lbl_RozeHafte.Size = New System.Drawing.Size(60, 18)
        Me.lbl_RozeHafte.TabIndex = 154
        Me.lbl_RozeHafte.Text = "تاریخ : از"
        '
        'cmb_Post
        '
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.BindingSource3
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = True
        Me.cmb_Post.Location = New System.Drawing.Point(83, 78)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = True
        Me.cmb_Post.Size = New System.Drawing.Size(342, 26)
        Me.cmb_Post.TabIndex = 149
        Me.cmb_Post.ValueMember = "Srl"
        '
        'cmb_Group
        '
        Me.cmb_Group.AutoComplete = True
        Me.cmb_Group.DataSource = Me.BindingSource4
        Me.cmb_Group.DisplayMember = "نام"
        Me.cmb_Group.EnterStop = True
        Me.cmb_Group.FormattingEnabled = True
        Me.cmb_Group.IsRequired = False
        Me.cmb_Group.LimitedToList = True
        Me.cmb_Group.Location = New System.Drawing.Point(83, 123)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.OpenOnFoucus = True
        Me.cmb_Group.Size = New System.Drawing.Size(342, 26)
        Me.cmb_Group.TabIndex = 150
        Me.cmb_Group.ValueMember = "Srl"
        '
        'KalaSelectManager2
        '
        Me.KalaSelectManager2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KalaSelectManager2.Location = New System.Drawing.Point(83, 216)
        Me.KalaSelectManager2.Name = "KalaSelectManager2"
        Me.KalaSelectManager2.Result = Nothing
        Me.KalaSelectManager2.SelectQueryMode = Nama_PM.KalaSelectManager.QueryMode.SelectKala
        Me.KalaSelectManager2.Size = New System.Drawing.Size(342, 26)
        Me.KalaSelectManager2.TabIndex = 164
        '
        'Frm_RpKalaUse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(604, 390)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_RpKalaUse"
        Me.Text = "گزارش کالای مصرفی"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpPmKalaUseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_Date.ResumeLayout(False)
        Me.pl_Date.PerformLayout()
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
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PM_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.PM_PostTableAdapter
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents RpPmKalaUseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_Pm_KalaUseTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_Pm_KalaUseTableAdapter
    Friend WithEvents pl_Date As System.Windows.Forms.Panel
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KalaSelectManager2 As KalaSelectManager
    Friend WithEvents chk_AllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllPost As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllKala As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AllWorkFormNo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Date As System.Windows.Forms.CheckBox
    Friend WithEvents txt_WorkFormNo As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_RozeHafte As System.Windows.Forms.Label
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents cmb_Group As VB_Component.ComboBox
End Class
