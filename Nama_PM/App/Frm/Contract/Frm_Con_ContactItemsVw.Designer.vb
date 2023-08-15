<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_ContactItemsVw
    Inherits BaseForm_View

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
        Me.cmb_Vahed = New VB_Component.ComboBox
        Me.PmConVahedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.Label3 = New System.Windows.Forms.Label
        Me.Pm_Con_VahedTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_VahedTableAdapter
        Me.PmConContractItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_ContractItemsTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractItemsTableAdapter
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عنوانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مقدارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.قیمتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.دورهزمانیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConVahedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 368)
        Me.GroupBox1.Size = New System.Drawing.Size(736, 47)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(451, 15)
        Me.btn_Delete.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(545, 15)
        Me.btn_Edit.Visible = False
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(639, 15)
        Me.btn_New.Visible = False
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.Label3)
        Me.gbx_DataGridView.Controls.Add(Me.cmb_Vahed)
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(736, 330)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.کدDataGridViewTextBoxColumn, Me.عنوانDataGridViewTextBoxColumn, Me.مقدارDataGridViewTextBoxColumn, Me.قیمتDataGridViewTextBoxColumn, Me.دورهزمانیDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmConContractItemsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 48)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(730, 279)
        Me.DataGridView1.TabIndex = 3
        '
        'cmb_Vahed
        '
        Me.cmb_Vahed.AutoComplete = True
        Me.cmb_Vahed.DataSource = Me.PmConVahedBindingSource
        Me.cmb_Vahed.DisplayMember = "نام"
        Me.cmb_Vahed.EnterStop = True
        Me.cmb_Vahed.FormattingEnabled = True
        Me.cmb_Vahed.IsRequired = False
        Me.cmb_Vahed.LimitedToList = True
        Me.cmb_Vahed.Location = New System.Drawing.Point(448, 18)
        Me.cmb_Vahed.Name = "cmb_Vahed"
        Me.cmb_Vahed.OpenOnFoucus = True
        Me.cmb_Vahed.Size = New System.Drawing.Size(209, 24)
        Me.cmb_Vahed.TabIndex = 24
        Me.cmb_Vahed.Tag = "srl_vahed"
        Me.cmb_Vahed.ValueMember = "srl_vahed"
        '
        'PmConVahedBindingSource
        '
        Me.PmConVahedBindingSource.DataMember = "Pm_Con_Vahed"
        Me.PmConVahedBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(698, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "واحد"
        '
        'Pm_Con_VahedTableAdapter
        '
        Me.Pm_Con_VahedTableAdapter.ClearBeforeFill = True
        '
        'PmConContractItemsBindingSource
        '
        Me.PmConContractItemsBindingSource.DataMember = "Pm_Con_ContractItems"
        Me.PmConContractItemsBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_ContractItemsTableAdapter
        '
        Me.Pm_Con_ContractItemsTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'کدDataGridViewTextBoxColumn
        '
        Me.کدDataGridViewTextBoxColumn.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn.Name = "کدDataGridViewTextBoxColumn"
        Me.کدDataGridViewTextBoxColumn.ReadOnly = True
        '
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        Me.عنوانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'مقدارDataGridViewTextBoxColumn
        '
        Me.مقدارDataGridViewTextBoxColumn.DataPropertyName = "مقدار"
        Me.مقدارDataGridViewTextBoxColumn.HeaderText = "مقدار"
        Me.مقدارDataGridViewTextBoxColumn.Name = "مقدارDataGridViewTextBoxColumn"
        '
        'قیمتDataGridViewTextBoxColumn
        '
        Me.قیمتDataGridViewTextBoxColumn.DataPropertyName = "قیمت"
        Me.قیمتDataGridViewTextBoxColumn.HeaderText = "قیمت"
        Me.قیمتDataGridViewTextBoxColumn.Name = "قیمتDataGridViewTextBoxColumn"
        '
        'دورهزمانیDataGridViewTextBoxColumn
        '
        Me.دورهزمانیDataGridViewTextBoxColumn.DataPropertyName = "دوره زمانی"
        Me.دورهزمانیDataGridViewTextBoxColumn.HeaderText = "دوره زمانی"
        Me.دورهزمانیDataGridViewTextBoxColumn.Name = "دورهزمانیDataGridViewTextBoxColumn"
        '
        'Frm_Con_ContactItemsVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 451)
        Me.Name = "Frm_Con_ContactItemsVw"
        Me.Text = "تعداد و مبلغ آیتم های قرارداد"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.gbx_DataGridView.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConVahedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_Vahed As VB_Component.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_VahedTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_VahedTableAdapter
    Friend WithEvents PmConContractItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractItemsTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractItemsTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مقدارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قیمتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents دورهزمانیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
