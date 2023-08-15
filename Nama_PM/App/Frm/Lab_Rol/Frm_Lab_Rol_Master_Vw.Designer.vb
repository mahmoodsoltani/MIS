<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Lab_Rol_Master_Vw
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
        Me.Srl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامتجهیزDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مسئولتعمیرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmLabRolMasterVwBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامتجهیزDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmLabRolMasterVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Lab_Rol_Master_VwTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_Master_VwTableAdapter
        Me.PmLabRolTamiratViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Lab_Rol_TamiratViewTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TamiratViewTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolMasterVwBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolMasterVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolTamiratViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 496)
        Me.GroupBox1.Size = New System.Drawing.Size(628, 47)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(343, 15)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(437, 15)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(531, 15)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(628, 458)
        '
        'DataGridView1
        '
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Srl, Me.شمارهDataGridViewTextBoxColumn2, Me.نامتجهیزDataGridViewTextBoxColumn1, Me.تاریخورودتجهیزDataGridViewTextBoxColumn1, Me.مسئولتعمیرDataGridViewTextBoxColumn, Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn1})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmLabRolMasterVwBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 13)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(619, 439)
        Me.DataGridView1.TabIndex = 0
        '
        'Srl
        '
        Me.Srl.DataPropertyName = "Srl"
        Me.Srl.HeaderText = "Srl"
        Me.Srl.Name = "Srl"
        Me.Srl.ReadOnly = True
        Me.Srl.Visible = False
        '
        'شمارهDataGridViewTextBoxColumn2
        '
        Me.شمارهDataGridViewTextBoxColumn2.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn2.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn2.Name = "شمارهDataGridViewTextBoxColumn2"
        '
        'نامتجهیزDataGridViewTextBoxColumn1
        '
        Me.نامتجهیزDataGridViewTextBoxColumn1.DataPropertyName = "نام تجهیز"
        Me.نامتجهیزDataGridViewTextBoxColumn1.HeaderText = "نام تجهیز"
        Me.نامتجهیزDataGridViewTextBoxColumn1.Name = "نامتجهیزDataGridViewTextBoxColumn1"
        Me.نامتجهیزDataGridViewTextBoxColumn1.Width = 130
        '
        'تاریخورودتجهیزDataGridViewTextBoxColumn1
        '
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn1.DataPropertyName = "تاریخ ورود تجهیز"
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn1.HeaderText = "تاریخ ورود تجهیز"
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn1.Name = "تاریخورودتجهیزDataGridViewTextBoxColumn1"
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn1.Width = 120
        '
        'مسئولتعمیرDataGridViewTextBoxColumn
        '
        Me.مسئولتعمیرDataGridViewTextBoxColumn.DataPropertyName = "مسئول تعمیر"
        Me.مسئولتعمیرDataGridViewTextBoxColumn.HeaderText = "مسئول تعمیر"
        Me.مسئولتعمیرDataGridViewTextBoxColumn.Name = "مسئولتعمیرDataGridViewTextBoxColumn"
        Me.مسئولتعمیرDataGridViewTextBoxColumn.Width = 130
        '
        'محلاستفادهازتجهیزDataGridViewTextBoxColumn1
        '
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn1.DataPropertyName = "محل استفاده از تجهیز"
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn1.HeaderText = "محل استفاده"
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn1.Name = "محلاستفادهازتجهیزDataGridViewTextBoxColumn1"
        '
        'PmLabRolMasterVwBindingSource1
        '
        Me.PmLabRolMasterVwBindingSource1.DataMember = "Pm_Lab_Rol_Master_Vw"
        Me.PmLabRolMasterVwBindingSource1.DataSource = Me.Ds_Lab
        '
        'Ds_Lab
        '
        Me.Ds_Lab.DataSetName = "Ds_Lab"
        Me.Ds_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        '
        'شمارهDataGridViewTextBoxColumn1
        '
        Me.شمارهDataGridViewTextBoxColumn1.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn1.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn1.Name = "شمارهDataGridViewTextBoxColumn1"
        Me.شمارهDataGridViewTextBoxColumn1.Width = 120
        '
        'نامتجهیزDataGridViewTextBoxColumn
        '
        Me.نامتجهیزDataGridViewTextBoxColumn.DataPropertyName = "نام تجهیز"
        Me.نامتجهیزDataGridViewTextBoxColumn.HeaderText = "نام تجهیز"
        Me.نامتجهیزDataGridViewTextBoxColumn.Name = "نامتجهیزDataGridViewTextBoxColumn"
        Me.نامتجهیزDataGridViewTextBoxColumn.Width = 150
        '
        'تاریخورودتجهیزDataGridViewTextBoxColumn
        '
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn.DataPropertyName = "تاریخ ورود تجهیز"
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn.HeaderText = "تاریخ ورود تجهیز"
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn.Name = "تاریخورودتجهیزDataGridViewTextBoxColumn"
        Me.تاریخورودتجهیزDataGridViewTextBoxColumn.Width = 150
        '
        'محلاستفادهازتجهیزDataGridViewTextBoxColumn
        '
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn.DataPropertyName = "محل استفاده از تجهیز"
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn.HeaderText = "محل استفاده از تجهیز"
        Me.محلاستفادهازتجهیزDataGridViewTextBoxColumn.Name = "محلاستفادهازتجهیزDataGridViewTextBoxColumn"
        '
        'PmLabRolMasterVwBindingSource
        '
        Me.PmLabRolMasterVwBindingSource.DataMember = "Pm_Lab_Rol_Master_Vw"
        Me.PmLabRolMasterVwBindingSource.DataSource = Me.Ds_Lab
        '
        'Pm_Lab_Rol_Master_VwTableAdapter
        '
        Me.Pm_Lab_Rol_Master_VwTableAdapter.ClearBeforeFill = True
        '
        'PmLabRolTamiratViewBindingSource
        '
        Me.PmLabRolTamiratViewBindingSource.DataMember = "Pm_Lab_Rol_TamiratView"
        Me.PmLabRolTamiratViewBindingSource.DataSource = Me.Ds_Lab
        '
        'Pm_Lab_Rol_TamiratViewTableAdapter
        '
        Me.Pm_Lab_Rol_TamiratViewTableAdapter.ClearBeforeFill = True
        '
        'Frm_Lab_Rol_Master_Vw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 579)
        Me.Name = "Frm_Lab_Rol_Master_Vw"
        Me.Text = "نمایش تعمیرات انجام شده"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolMasterVwBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolMasterVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolTamiratViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents PmLabRolMasterVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_Master_VwTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_Master_VwTableAdapter
    Friend WithEvents PmLabRolTamiratViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_TamiratViewTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TamiratViewTableAdapter
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmLabRolMasterVwBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents شمارهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامتجهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخورودتجهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلاستفادهازتجهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Srl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامتجهیزDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخورودتجهیزDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مسئولتعمیرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلاستفادهازتجهیزDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
