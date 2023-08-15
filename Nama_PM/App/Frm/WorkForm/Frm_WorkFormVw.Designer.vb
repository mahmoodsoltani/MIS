<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WorkFormVw
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
        Me.WorkFormMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.WorkForm_MasterTableAdapter = New Nama_PM.Ds_PmTableAdapters.WorkForm_MasterTableAdapter
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدهزینهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.واحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ثبتکنندهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پست = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkFormMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(14, 405)
        Me.GroupBox1.Size = New System.Drawing.Size(857, 53)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(16, 16)
        Me.btn_Cancel.Size = New System.Drawing.Size(99, 29)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(531, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(101, 29)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(639, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(101, 29)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(746, 17)
        Me.btn_New.Size = New System.Drawing.Size(101, 29)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Location = New System.Drawing.Point(14, 40)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(857, 362)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.شمارهفرمکارDataGridViewTextBoxColumn, Me.کدهزینهDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.واحدDataGridViewTextBoxColumn, Me.نامگروهDataGridViewTextBoxColumn, Me.پستDataGridViewTextBoxColumn, Me.ثبتکنندهDataGridViewTextBoxColumn, Me.پست, Me.Column1, Me.Column2})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.WorkFormMasterBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(11, 18)
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
        Me.DataGridView1.Size = New System.Drawing.Size(836, 331)
        Me.DataGridView1.TabIndex = 0
        '
        'WorkFormMasterBindingSource
        '
        Me.WorkFormMasterBindingSource.DataMember = "WorkForm_Master"
        Me.WorkFormMasterBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkForm_MasterTableAdapter
        '
        Me.WorkForm_MasterTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهفرمکارDataGridViewTextBoxColumn
        '
        Me.شمارهفرمکارDataGridViewTextBoxColumn.DataPropertyName = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.HeaderText = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.Name = "شمارهفرمکارDataGridViewTextBoxColumn"
        Me.شمارهفرمکارDataGridViewTextBoxColumn.ReadOnly = True
        Me.شمارهفرمکارDataGridViewTextBoxColumn.Width = 110
        '
        'کدهزینهDataGridViewTextBoxColumn
        '
        Me.کدهزینهDataGridViewTextBoxColumn.DataPropertyName = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.HeaderText = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.Name = "کدهزینهDataGridViewTextBoxColumn"
        Me.کدهزینهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'واحدDataGridViewTextBoxColumn
        '
        Me.واحدDataGridViewTextBoxColumn.DataPropertyName = "واحد"
        Me.واحدDataGridViewTextBoxColumn.HeaderText = "واحد"
        Me.واحدDataGridViewTextBoxColumn.Name = "واحدDataGridViewTextBoxColumn"
        Me.واحدDataGridViewTextBoxColumn.ReadOnly = True
        Me.واحدDataGridViewTextBoxColumn.Width = 120
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        Me.نامگروهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'پستDataGridViewTextBoxColumn
        '
        Me.پستDataGridViewTextBoxColumn.DataPropertyName = "پست"
        Me.پستDataGridViewTextBoxColumn.HeaderText = "پست"
        Me.پستDataGridViewTextBoxColumn.Name = "پستDataGridViewTextBoxColumn"
        Me.پستDataGridViewTextBoxColumn.ReadOnly = True
        Me.پستDataGridViewTextBoxColumn.Width = 120
        '
        'ثبتکنندهDataGridViewTextBoxColumn
        '
        Me.ثبتکنندهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ثبتکنندهDataGridViewTextBoxColumn.DataPropertyName = "ثبت کننده"
        Me.ثبتکنندهDataGridViewTextBoxColumn.HeaderText = "ثبت کننده"
        Me.ثبتکنندهDataGridViewTextBoxColumn.Name = "ثبتکنندهDataGridViewTextBoxColumn"
        Me.ثبتکنندهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'پست
        '
        Me.پست.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.پست.DataPropertyName = "پست"
        Me.پست.HeaderText = "پست"
        Me.پست.Name = "پست"
        Me.پست.ReadOnly = True
        Me.پست.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "..."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.ToolTipText = "PM"
        Me.Column1.Width = 25
        '
        'Column2
        '
        Me.Column2.HeaderText = "..."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.ToolTipText = "کارمازاد"
        Me.Column2.Width = 25
        '
        'Frm_WorkFormVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(884, 498)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_WorkFormVw"
        Me.Text = "نمایش فرم کار"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkFormMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents WorkFormMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkForm_MasterTableAdapter As Nama_PM.Ds_PmTableAdapters.WorkForm_MasterTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدهزینهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ثبتکنندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پست As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
End Class
