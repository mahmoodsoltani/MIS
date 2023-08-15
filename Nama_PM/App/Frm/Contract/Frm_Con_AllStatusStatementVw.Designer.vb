<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_AllStatusStatementVw
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
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.PmConAllStatusStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامواحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامپستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامخطDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatementtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlvahedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlpostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrllineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConAllStatusStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(14, 405)
        Me.GroupBox1.Size = New System.Drawing.Size(913, 53)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(16, 16)
        Me.btn_Cancel.Size = New System.Drawing.Size(99, 29)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(587, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(101, 29)
        Me.btn_Delete.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(695, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(101, 29)
        Me.btn_Edit.Visible = False
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(802, 17)
        Me.btn_New.Size = New System.Drawing.Size(101, 29)
        Me.btn_New.Visible = False
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Location = New System.Drawing.Point(14, 40)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(913, 362)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.شمارهDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.نامواحدDataGridViewTextBoxColumn, Me.نامپستDataGridViewTextBoxColumn, Me.نامگروهDataGridViewTextBoxColumn, Me.نامخطDataGridViewTextBoxColumn, Me.StatementtypeDataGridViewTextBoxColumn, Me.SrlvahedDataGridViewTextBoxColumn, Me.SrlgroupDataGridViewTextBoxColumn, Me.SrlpostDataGridViewTextBoxColumn, Me.SrllineDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmConAllStatusStatementBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(907, 337)
        Me.DataGridView1.TabIndex = 0
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmConAllStatusStatementBindingSource
        '
        Me.PmConAllStatusStatementBindingSource.DataMember = "Pm_Con_AllStatusStatement"
        Me.PmConAllStatusStatementBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_AllStatusStatementTableAdapter
        '
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامواحدDataGridViewTextBoxColumn
        '
        Me.نامواحدDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامواحدDataGridViewTextBoxColumn.DataPropertyName = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.HeaderText = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.Name = "نامواحدDataGridViewTextBoxColumn"
        Me.نامواحدDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامپستDataGridViewTextBoxColumn
        '
        Me.نامپستDataGridViewTextBoxColumn.DataPropertyName = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.HeaderText = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.Name = "نامپستDataGridViewTextBoxColumn"
        Me.نامپستDataGridViewTextBoxColumn.ReadOnly = True
        Me.نامپستDataGridViewTextBoxColumn.Width = 150
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        Me.نامگروهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامخطDataGridViewTextBoxColumn
        '
        Me.نامخطDataGridViewTextBoxColumn.DataPropertyName = "نام خط"
        Me.نامخطDataGridViewTextBoxColumn.HeaderText = "نام خط"
        Me.نامخطDataGridViewTextBoxColumn.Name = "نامخطDataGridViewTextBoxColumn"
        Me.نامخطDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatementtypeDataGridViewTextBoxColumn
        '
        Me.StatementtypeDataGridViewTextBoxColumn.DataPropertyName = "Statementtype"
        Me.StatementtypeDataGridViewTextBoxColumn.HeaderText = "نوع"
        Me.StatementtypeDataGridViewTextBoxColumn.Name = "StatementtypeDataGridViewTextBoxColumn"
        Me.StatementtypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SrlvahedDataGridViewTextBoxColumn
        '
        Me.SrlvahedDataGridViewTextBoxColumn.DataPropertyName = "Srl_vahed"
        Me.SrlvahedDataGridViewTextBoxColumn.HeaderText = "Srl_vahed"
        Me.SrlvahedDataGridViewTextBoxColumn.Name = "SrlvahedDataGridViewTextBoxColumn"
        Me.SrlvahedDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlvahedDataGridViewTextBoxColumn.Visible = False
        '
        'SrlgroupDataGridViewTextBoxColumn
        '
        Me.SrlgroupDataGridViewTextBoxColumn.DataPropertyName = "Srl_group"
        Me.SrlgroupDataGridViewTextBoxColumn.HeaderText = "Srl_group"
        Me.SrlgroupDataGridViewTextBoxColumn.Name = "SrlgroupDataGridViewTextBoxColumn"
        Me.SrlgroupDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlgroupDataGridViewTextBoxColumn.Visible = False
        '
        'SrlpostDataGridViewTextBoxColumn
        '
        Me.SrlpostDataGridViewTextBoxColumn.DataPropertyName = "srl_post"
        Me.SrlpostDataGridViewTextBoxColumn.HeaderText = "srl_post"
        Me.SrlpostDataGridViewTextBoxColumn.Name = "SrlpostDataGridViewTextBoxColumn"
        Me.SrlpostDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlpostDataGridViewTextBoxColumn.Visible = False
        '
        'SrllineDataGridViewTextBoxColumn
        '
        Me.SrllineDataGridViewTextBoxColumn.DataPropertyName = "srl_line"
        Me.SrllineDataGridViewTextBoxColumn.HeaderText = "srl_line"
        Me.SrllineDataGridViewTextBoxColumn.Name = "SrllineDataGridViewTextBoxColumn"
        Me.SrllineDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrllineDataGridViewTextBoxColumn.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "..."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 25
        '
        'Frm_Con_AllStatusStatementVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(940, 498)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_AllStatusStatementVw"
        Me.Text = "نمایش فرم کار"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConAllStatusStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConAllStatusStatementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامخطDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatementtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlvahedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlgroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlpostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrllineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
End Class
