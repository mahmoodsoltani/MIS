<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SummaryRpStatusStatementExtraWork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SummaryRpStatusStatementExtraWork))
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.ComboBox1 = New VB_Component.ComboBox
        Me.PmCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.PmSherkatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_SherkatTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_SherkatTableAdapter
        Me.Pm_CompanyTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_CompanyTableAdapter
        Me.btn_Report = New CS_Component.Btn
        Me.cmb_Vahed = New VB_Component.ComboBox
        Me.PmVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.cmb_Group = New VB_Component.ComboBox
        Me.PmGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_Vahed = New System.Windows.Forms.CheckBox
        Me.chk_Group = New System.Windows.Forms.CheckBox
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.RpSummaryStatusstatementExtraWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_SummaryStatusstatementExtraWorkTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_SummaryStatusstatementExtraWorkTableAdapter
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSherkatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpSummaryStatusstatementExtraWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Controls.Add(Me.btn_Report)
        Me.gbx_Buttons.Controls.Add(Me.ComboBox1)
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 133)
        Me.gbx_Buttons.Size = New System.Drawing.Size(488, 53)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Save, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Cancel, 0)
        Me.gbx_Buttons.Controls.SetChildIndex(Me.btn_Report, 0)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 26)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "گزارش آذرخش"
        Me.btn_Save.Image = CType(resources.GetObject("btn_Save.Image"), System.Drawing.Bitmap)
        Me.btn_Save.Location = New System.Drawing.Point(174, 60)
        Me.btn_Save.Size = New System.Drawing.Size(162, 29)
        Me.btn_Save.Visible = False
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.chk_Group)
        Me.gbx_Fields.Controls.Add(Me.chk_Vahed)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.cmb_Group)
        Me.gbx_Fields.Controls.Add(Me.cmb_Vahed)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(488, 92)
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = True
        Me.txt_FromDate.Location = New System.Drawing.Point(274, 22)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FromDate.Size = New System.Drawing.Size(148, 26)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 0
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = "FactorDate"
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(428, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 18)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "از تاریخ"
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = True
        Me.txt_ToDate.Location = New System.Drawing.Point(40, 22)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_ToDate.Size = New System.Drawing.Size(148, 26)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 1
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = "FactorDate"
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "تا تاریخ"
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoComplete = True
        Me.ComboBox1.DataSource = Me.PmCompanyBindingSource
        Me.ComboBox1.DisplayMember = "شرکت"
        Me.ComboBox1.EnterStop = True
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IsRequired = False
        Me.ComboBox1.LimitedToList = True
        Me.ComboBox1.Location = New System.Drawing.Point(268, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.OpenOnFoucus = False
        Me.ComboBox1.Size = New System.Drawing.Size(207, 26)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Tag = ""
        Me.ComboBox1.ValueMember = "کد"
        '
        'PmCompanyBindingSource
        '
        Me.PmCompanyBindingSource.DataMember = "Pm_Company"
        Me.PmCompanyBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmSherkatBindingSource
        '
        Me.PmSherkatBindingSource.DataMember = "Pm_Sherkat"
        Me.PmSherkatBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Pm_SherkatTableAdapter
        '
        Me.Pm_SherkatTableAdapter.ClearBeforeFill = True
        '
        'Pm_CompanyTableAdapter
        '
        Me.Pm_CompanyTableAdapter.ClearBeforeFill = True
        '
        'btn_Report
        '
        Me.btn_Report.BackColor = System.Drawing.Color.Transparent
        Me.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Report.HeaderText = "گزارش"
        Me.btn_Report.Location = New System.Drawing.Point(146, 18)
        Me.btn_Report.Margin = New System.Windows.Forms.Padding(10, 14, 10, 14)
        Me.btn_Report.Name = "btn_Report"
        Me.btn_Report.Size = New System.Drawing.Size(94, 27)
        Me.btn_Report.TabIndex = 5
        '
        'cmb_Vahed
        '
        Me.cmb_Vahed.AutoComplete = True
        Me.cmb_Vahed.DataSource = Me.PmVahedBindingSource
        Me.cmb_Vahed.DisplayMember = "نام واحد"
        Me.cmb_Vahed.EnterStop = True
        Me.cmb_Vahed.FormattingEnabled = True
        Me.cmb_Vahed.IsRequired = False
        Me.cmb_Vahed.LimitedToList = True
        Me.cmb_Vahed.Location = New System.Drawing.Point(253, 54)
        Me.cmb_Vahed.Name = "cmb_Vahed"
        Me.cmb_Vahed.OpenOnFoucus = False
        Me.cmb_Vahed.Size = New System.Drawing.Size(169, 26)
        Me.cmb_Vahed.TabIndex = 4
        Me.cmb_Vahed.Tag = ""
        Me.cmb_Vahed.ValueMember = "Srl"
        '
        'PmVahedBindingSource
        '
        Me.PmVahedBindingSource.DataMember = "Pm_Vahed"
        Me.PmVahedBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'cmb_Group
        '
        Me.cmb_Group.AutoComplete = True
        Me.cmb_Group.DataSource = Me.PmGroupBindingSource
        Me.cmb_Group.DisplayMember = "نام"
        Me.cmb_Group.EnterStop = True
        Me.cmb_Group.FormattingEnabled = True
        Me.cmb_Group.IsRequired = False
        Me.cmb_Group.LimitedToList = True
        Me.cmb_Group.Location = New System.Drawing.Point(11, 56)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.OpenOnFoucus = False
        Me.cmb_Group.Size = New System.Drawing.Size(177, 26)
        Me.cmb_Group.TabIndex = 4
        Me.cmb_Group.Tag = ""
        Me.cmb_Group.ValueMember = "Srl"
        '
        'PmGroupBindingSource
        '
        Me.PmGroupBindingSource.DataMember = "Pm_Group"
        Me.PmGroupBindingSource.DataSource = Me.Ds_Pm
        '
        'chk_Vahed
        '
        Me.chk_Vahed.AutoSize = True
        Me.chk_Vahed.Location = New System.Drawing.Point(422, 56)
        Me.chk_Vahed.Name = "chk_Vahed"
        Me.chk_Vahed.Size = New System.Drawing.Size(55, 22)
        Me.chk_Vahed.TabIndex = 9
        Me.chk_Vahed.Text = "واحد"
        Me.chk_Vahed.UseVisualStyleBackColor = True
        '
        'chk_Group
        '
        Me.chk_Group.AutoSize = True
        Me.chk_Group.Location = New System.Drawing.Point(194, 58)
        Me.chk_Group.Name = "chk_Group"
        Me.chk_Group.Size = New System.Drawing.Size(53, 22)
        Me.chk_Group.TabIndex = 9
        Me.chk_Group.Text = "گروه"
        Me.chk_Group.UseVisualStyleBackColor = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'RpSummaryStatusstatementExtraWorkBindingSource
        '
        Me.RpSummaryStatusstatementExtraWorkBindingSource.DataMember = "Rp_SummaryStatusstatementExtraWork"
        Me.RpSummaryStatusstatementExtraWorkBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_SummaryStatusstatementExtraWorkTableAdapter
        '
        Me.Rp_SummaryStatusstatementExtraWorkTableAdapter.ClearBeforeFill = True
        '
        'Frm_SummaryRpStatusStatementExtraWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(513, 226)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_SummaryRpStatusStatementExtraWork"
        Me.Text = "گزارش خلاصه اضافه کار بر مبنای کارمزدی"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSherkatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpSummaryStatusstatementExtraWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents ComboBox1 As VB_Component.ComboBox
    Friend WithEvents PmSherkatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents Pm_SherkatTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_SherkatTableAdapter
    Friend WithEvents PmCompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_CompanyTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_CompanyTableAdapter
    Friend WithEvents btn_Report As CS_Component.Btn
    Friend WithEvents cmb_Vahed As VB_Component.ComboBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents chk_Group As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Vahed As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Group As VB_Component.ComboBox
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents RpSummaryStatusstatementExtraWorkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_SummaryStatusstatementExtraWorkTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_SummaryStatusstatementExtraWorkTableAdapter
End Class
