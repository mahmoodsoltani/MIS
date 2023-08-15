<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_GroupWeight
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlcontractDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شاخصوزنیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmConGroupWeightBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.lb_Holiday = New System.Windows.Forms.Label
        Me.txt_all = New CS_Component.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmb_contract = New VB_Component.ComboBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.Pm_Con_GroupWeightTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_GroupWeightTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_vahed = New VB_Component.ComboBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConGroupWeightBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(1910, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        Me.btn_Delete.Visible = False
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(2157, 17)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        Me.btn_new.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(2033, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Controls.Add(Me.Label15)
        Me.gbx_GridViewList.Controls.Add(Me.txt_all)
        Me.gbx_GridViewList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_GridViewList.Location = New System.Drawing.Point(6, 57)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(426, 433)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controls.Controls.Add(Me.cmb_vahed)
        Me.gbx_Controls.Controls.Add(Me.cmb_contract)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.Label10)
        Me.gbx_Controls.Controls.Add(Me.lb_Holiday)
        Me.gbx_Controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbx_Controls.Location = New System.Drawing.Point(6, 57)
        Me.gbx_Controls.Size = New System.Drawing.Size(426, 94)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbx_Btn.Location = New System.Drawing.Point(6, 439)
        Me.gbx_Btn.Size = New System.Drawing.Size(426, 51)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.SrlGroupDataGridViewTextBoxColumn, Me.SrlcontractDataGridViewTextBoxColumn, Me.نامگروهDataGridViewTextBoxColumn, Me.شاخصوزنیDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmConGroupWeightBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(5, 100)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(417, 281)
        Me.DataGridView1.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "srl"
        Me.DataGridViewTextBoxColumn1.HeaderText = "srl"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'SrlGroupDataGridViewTextBoxColumn
        '
        Me.SrlGroupDataGridViewTextBoxColumn.DataPropertyName = "srl_Group"
        Me.SrlGroupDataGridViewTextBoxColumn.HeaderText = "srl_Group"
        Me.SrlGroupDataGridViewTextBoxColumn.Name = "SrlGroupDataGridViewTextBoxColumn"
        Me.SrlGroupDataGridViewTextBoxColumn.Visible = False
        '
        'SrlcontractDataGridViewTextBoxColumn
        '
        Me.SrlcontractDataGridViewTextBoxColumn.DataPropertyName = "srl_contract"
        Me.SrlcontractDataGridViewTextBoxColumn.HeaderText = "srl_contract"
        Me.SrlcontractDataGridViewTextBoxColumn.Name = "SrlcontractDataGridViewTextBoxColumn"
        Me.SrlcontractDataGridViewTextBoxColumn.Visible = False
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        '
        'شاخصوزنیDataGridViewTextBoxColumn
        '
        Me.شاخصوزنیDataGridViewTextBoxColumn.DataPropertyName = "شاخص وزنی"
        Me.شاخصوزنیDataGridViewTextBoxColumn.HeaderText = "شاخص وزنی"
        Me.شاخصوزنیDataGridViewTextBoxColumn.Name = "شاخصوزنیDataGridViewTextBoxColumn"
        '
        'PmConGroupWeightBindingSource
        '
        Me.PmConGroupWeightBindingSource.DataMember = "Pm_Con_GroupWeight"
        Me.PmConGroupWeightBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lb_Holiday
        '
        Me.lb_Holiday.AutoSize = True
        Me.lb_Holiday.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lb_Holiday.ForeColor = System.Drawing.Color.Red
        Me.lb_Holiday.Location = New System.Drawing.Point(47, 15)
        Me.lb_Holiday.Name = "lb_Holiday"
        Me.lb_Holiday.Size = New System.Drawing.Size(0, 18)
        Me.lb_Holiday.TabIndex = 129
        '
        'txt_all
        '
        Me.txt_all.CheckExistValueInDb = True
        Me.txt_all.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_all.CurrencyUnit = "ریال"
        Me.txt_all.DefaultValue = ""
        Me.txt_all.Enabled = False
        Me.txt_all.FillWithMaxInDb = False
        Me.txt_all.IsRequired = True
        Me.txt_all.Location = New System.Drawing.Point(12, 511)
        Me.txt_all.MaxDecimalLength = 2
        Me.txt_all.Name = "txt_all"
        Me.txt_all.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_all.Size = New System.Drawing.Size(114, 26)
        Me.txt_all.SpellControl = Nothing
        Me.txt_all.TabIndex = 2
        Me.txt_all.Tag = "title"
        Me.txt_all.Text = "1"
        Me.txt_all.Title = Nothing
        Me.txt_all.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_all.UseForData = True
        Me.txt_all.ValidateCheckExistOnEdit = False
        Me.txt_all.Value = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(128, 514)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 18)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "جمع نهایی:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(326, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 18)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "قرارداد"
        '
        'cmb_contract
        '
        Me.cmb_contract.AutoComplete = True
        Me.cmb_contract.DataSource = Me.PmConContractBindingSource
        Me.cmb_contract.DisplayMember = "عنوان"
        Me.cmb_contract.EnterStop = True
        Me.cmb_contract.FormattingEnabled = True
        Me.cmb_contract.IsRequired = False
        Me.cmb_contract.LimitedToList = True
        Me.cmb_contract.Location = New System.Drawing.Point(60, 19)
        Me.cmb_contract.Name = "cmb_contract"
        Me.cmb_contract.OpenOnFoucus = False
        Me.cmb_contract.Size = New System.Drawing.Size(263, 26)
        Me.cmb_contract.TabIndex = 0
        Me.cmb_contract.ValueMember = "Srl"
        '
        'PmConContractBindingSource
        '
        Me.PmConContractBindingSource.DataMember = "Pm_Con_Contract"
        Me.PmConContractBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_ContractTableAdapter
        '
        Me.Pm_Con_ContractTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_GroupWeightTableAdapter
        '
        Me.Pm_Con_GroupWeightTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 18)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "واحد"
        '
        'cmb_vahed
        '
        Me.cmb_vahed.AutoComplete = True
        Me.cmb_vahed.DataSource = Me.BindingSource1
        Me.cmb_vahed.DisplayMember = "نام واحد"
        Me.cmb_vahed.EnterStop = True
        Me.cmb_vahed.FormattingEnabled = True
        Me.cmb_vahed.IsRequired = False
        Me.cmb_vahed.LimitedToList = True
        Me.cmb_vahed.Location = New System.Drawing.Point(60, 53)
        Me.cmb_vahed.Name = "cmb_vahed"
        Me.cmb_vahed.OpenOnFoucus = False
        Me.cmb_vahed.Size = New System.Drawing.Size(263, 26)
        Me.cmb_vahed.TabIndex = 1
        Me.cmb_vahed.ValueMember = "Srl"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Pm_Vahed"
        Me.BindingSource1.DataSource = Me.Ds_Pm
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
        'Frm_Con_GroupWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(439, 519)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_GroupWeight"
        Me.TableName = "pm_Con_statusstatement"
        Me.Text = "تعریف شاخص گروه ها بر مبنای قرارداد"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConGroupWeightBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents PmconstatusStatementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmconContractItemsTarikhBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmconWorkformBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعدادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قیمتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تائیدDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lb_Holiday As System.Windows.Forms.Label
    Friend WithEvents txt_all As CS_Component.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_contract As VB_Component.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlcontractDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شاخصوزنیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmConGroupWeightBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmb_vahed As VB_Component.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pm_Con_GroupWeightTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_GroupWeightTableAdapter
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
End Class
