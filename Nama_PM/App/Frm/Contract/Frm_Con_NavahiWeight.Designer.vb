<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_NavahiWeight
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.lb_Holiday = New System.Windows.Forms.Label
        Me.txt_all = New CS_Component.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmb_source = New VB_Component.ComboBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.PmConNavahiWeightBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_NavahiWeightTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_NavahiWeightTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPosttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlcontractDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ناحیهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ضریبDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConNavahiWeightBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(2120, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        Me.btn_Delete.Visible = False
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(2367, 17)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        Me.btn_new.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(2243, 17)
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
        Me.gbx_GridViewList.Size = New System.Drawing.Size(426, 391)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controls.Controls.Add(Me.cmb_source)
        Me.gbx_Controls.Controls.Add(Me.Label10)
        Me.gbx_Controls.Controls.Add(Me.lb_Holiday)
        Me.gbx_Controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbx_Controls.Location = New System.Drawing.Point(6, 57)
        Me.gbx_Controls.Size = New System.Drawing.Size(426, 61)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbx_Btn.Location = New System.Drawing.Point(6, 397)
        Me.gbx_Btn.Size = New System.Drawing.Size(426, 51)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.SrlPosttypeDataGridViewTextBoxColumn, Me.SrlcontractDataGridViewTextBoxColumn, Me.ناحیهDataGridViewTextBoxColumn, Me.ضریبDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmConNavahiWeightBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(3, 67)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(417, 281)
        Me.DataGridView1.TabIndex = 5
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
        Me.Label10.Size = New System.Drawing.Size(91, 18)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "انتخاب قرارداد"
        '
        'cmb_source
        '
        Me.cmb_source.AutoComplete = True
        Me.cmb_source.DataSource = Me.PmConContractBindingSource
        Me.cmb_source.DisplayMember = "عنوان"
        Me.cmb_source.EnterStop = True
        Me.cmb_source.FormattingEnabled = True
        Me.cmb_source.IsRequired = False
        Me.cmb_source.LimitedToList = True
        Me.cmb_source.Location = New System.Drawing.Point(60, 19)
        Me.cmb_source.Name = "cmb_source"
        Me.cmb_source.OpenOnFoucus = False
        Me.cmb_source.Size = New System.Drawing.Size(263, 26)
        Me.cmb_source.TabIndex = 0
        Me.cmb_source.ValueMember = "Srl"
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
        'PmConNavahiWeightBindingSource
        '
        Me.PmConNavahiWeightBindingSource.DataMember = "Pm_Con_NavahiWeight"
        Me.PmConNavahiWeightBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_NavahiWeightTableAdapter
        '
        Me.Pm_Con_NavahiWeightTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "srl"
        Me.DataGridViewTextBoxColumn1.HeaderText = "srl"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'SrlPosttypeDataGridViewTextBoxColumn
        '
        Me.SrlPosttypeDataGridViewTextBoxColumn.DataPropertyName = "srl_Post_type"
        Me.SrlPosttypeDataGridViewTextBoxColumn.HeaderText = "srl_Post_type"
        Me.SrlPosttypeDataGridViewTextBoxColumn.Name = "SrlPosttypeDataGridViewTextBoxColumn"
        Me.SrlPosttypeDataGridViewTextBoxColumn.Visible = False
        '
        'SrlcontractDataGridViewTextBoxColumn
        '
        Me.SrlcontractDataGridViewTextBoxColumn.DataPropertyName = "srl_contract"
        Me.SrlcontractDataGridViewTextBoxColumn.HeaderText = "srl_contract"
        Me.SrlcontractDataGridViewTextBoxColumn.Name = "SrlcontractDataGridViewTextBoxColumn"
        Me.SrlcontractDataGridViewTextBoxColumn.Visible = False
        '
        'ناحیهDataGridViewTextBoxColumn
        '
        Me.ناحیهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ناحیهDataGridViewTextBoxColumn.DataPropertyName = "ناحیه"
        Me.ناحیهDataGridViewTextBoxColumn.HeaderText = "ناحیه"
        Me.ناحیهDataGridViewTextBoxColumn.Name = "ناحیهDataGridViewTextBoxColumn"
        '
        'ضریبDataGridViewTextBoxColumn
        '
        Me.ضریبDataGridViewTextBoxColumn.DataPropertyName = "ضریب"
        Me.ضریبDataGridViewTextBoxColumn.HeaderText = "ضریب"
        Me.ضریبDataGridViewTextBoxColumn.Name = "ضریبDataGridViewTextBoxColumn"
        '
        'Frm_Con_NavahiWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(439, 477)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_NavahiWeight"
        Me.TableName = "pm_Con_statusstatement"
        Me.Text = "تعریف ظریب مناطق بر اساس قرارداد"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConNavahiWeightBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmb_source As VB_Component.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPosttypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlcontractDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ناحیهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ضریبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmConNavahiWeightBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_NavahiWeightTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_NavahiWeightTableAdapter
End Class
