<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_KholaseWorkForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخفرمکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلفعالیتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکارترددDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ساعتشروعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ساعتپایانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.جمعاضافهکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RpKholaseWorkFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.Rp_KholaseWorkFormTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_KholaseWorkFormTableAdapter
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شماره = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفرمکارDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخفرمکارDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلفعالیتDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ساعتشروعDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ساعتپایانDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.جمعاضافهکارDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اضافهکارترددDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpKholaseWorkFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(12, 527)
        Me.gbx_Buttons.Size = New System.Drawing.Size(864, 50)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "چاپ"
        Me.btn_Save.Location = New System.Drawing.Point(773, 17)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.DataGridView1)
        Me.gbx_Fields.Size = New System.Drawing.Size(864, 489)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn1, Me.شماره, Me.شمارهفرمکارDataGridViewTextBoxColumn1, Me.تاریخفرمکارDataGridViewTextBoxColumn1, Me.محلفعالیتDataGridViewTextBoxColumn1, Me.ساعتشروعDataGridViewTextBoxColumn1, Me.ساعتپایانDataGridViewTextBoxColumn1, Me.جمعاضافهکارDataGridViewTextBoxColumn1, Me.اضافهکارترددDataGridViewTextBoxColumn1})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.RpKholaseWorkFormBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(858, 467)
        Me.DataGridView1.TabIndex = 0
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
        '
        'تاریخفرمکارDataGridViewTextBoxColumn
        '
        Me.تاریخفرمکارDataGridViewTextBoxColumn.DataPropertyName = "تاریخ فرم کار"
        Me.تاریخفرمکارDataGridViewTextBoxColumn.HeaderText = "تاریخ فرم کار"
        Me.تاریخفرمکارDataGridViewTextBoxColumn.Name = "تاریخفرمکارDataGridViewTextBoxColumn"
        Me.تاریخفرمکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'محلفعالیتDataGridViewTextBoxColumn
        '
        Me.محلفعالیتDataGridViewTextBoxColumn.DataPropertyName = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.HeaderText = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.Name = "محلفعالیتDataGridViewTextBoxColumn"
        Me.محلفعالیتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'اضافهکارDataGridViewTextBoxColumn
        '
        Me.اضافهکارDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار"
        Me.اضافهکارDataGridViewTextBoxColumn.HeaderText = "اضافه کار"
        Me.اضافهکارDataGridViewTextBoxColumn.Name = "اضافهکارDataGridViewTextBoxColumn"
        Me.اضافهکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'اضافهکارترددDataGridViewTextBoxColumn
        '
        Me.اضافهکارترددDataGridViewTextBoxColumn.DataPropertyName = "اضافه کار تردد"
        Me.اضافهکارترددDataGridViewTextBoxColumn.HeaderText = "اضافه کار تردد"
        Me.اضافهکارترددDataGridViewTextBoxColumn.Name = "اضافهکارترددDataGridViewTextBoxColumn"
        Me.اضافهکارترددDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ساعتشروعDataGridViewTextBoxColumn
        '
        Me.ساعتشروعDataGridViewTextBoxColumn.DataPropertyName = "ساعت شروع"
        Me.ساعتشروعDataGridViewTextBoxColumn.HeaderText = "ساعت شروع"
        Me.ساعتشروعDataGridViewTextBoxColumn.Name = "ساعتشروعDataGridViewTextBoxColumn"
        Me.ساعتشروعDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ساعتپایانDataGridViewTextBoxColumn
        '
        Me.ساعتپایانDataGridViewTextBoxColumn.DataPropertyName = "ساعت پایان"
        Me.ساعتپایانDataGridViewTextBoxColumn.HeaderText = "ساعت پایان"
        Me.ساعتپایانDataGridViewTextBoxColumn.Name = "ساعتپایانDataGridViewTextBoxColumn"
        Me.ساعتپایانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'جمعاضافهکارDataGridViewTextBoxColumn
        '
        Me.جمعاضافهکارDataGridViewTextBoxColumn.DataPropertyName = "جمع اضافه کار"
        Me.جمعاضافهکارDataGridViewTextBoxColumn.HeaderText = "جمع اضافه کار"
        Me.جمعاضافهکارDataGridViewTextBoxColumn.Name = "جمعاضافهکارDataGridViewTextBoxColumn"
        Me.جمعاضافهکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RpKholaseWorkFormBindingSource
        '
        Me.RpKholaseWorkFormBindingSource.DataMember = "Rp_KholaseWorkForm"
        Me.RpKholaseWorkFormBindingSource.DataSource = Me.Ds_Rp
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rp_KholaseWorkFormTableAdapter
        '
        Me.Rp_KholaseWorkFormTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn1.Visible = False
        '
        'شماره
        '
        Me.شماره.DataPropertyName = "شماره"
        Me.شماره.HeaderText = "شماره"
        Me.شماره.Name = "شماره"
        Me.شماره.ReadOnly = True
        '
        'شمارهفرمکارDataGridViewTextBoxColumn1
        '
        Me.شمارهفرمکارDataGridViewTextBoxColumn1.DataPropertyName = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn1.HeaderText = "شماره فرم کار"
        Me.شمارهفرمکارDataGridViewTextBoxColumn1.Name = "شمارهفرمکارDataGridViewTextBoxColumn1"
        Me.شمارهفرمکارDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'تاریخفرمکارDataGridViewTextBoxColumn1
        '
        Me.تاریخفرمکارDataGridViewTextBoxColumn1.DataPropertyName = "تاریخ فرم کار"
        Me.تاریخفرمکارDataGridViewTextBoxColumn1.HeaderText = "تاریخ فرم کار"
        Me.تاریخفرمکارDataGridViewTextBoxColumn1.Name = "تاریخفرمکارDataGridViewTextBoxColumn1"
        Me.تاریخفرمکارDataGridViewTextBoxColumn1.ReadOnly = True
        Me.تاریخفرمکارDataGridViewTextBoxColumn1.Width = 110
        '
        'محلفعالیتDataGridViewTextBoxColumn1
        '
        Me.محلفعالیتDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.محلفعالیتDataGridViewTextBoxColumn1.DataPropertyName = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn1.HeaderText = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn1.Name = "محلفعالیتDataGridViewTextBoxColumn1"
        Me.محلفعالیتDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ساعتشروعDataGridViewTextBoxColumn1
        '
        Me.ساعتشروعDataGridViewTextBoxColumn1.DataPropertyName = "ساعت شروع"
        Me.ساعتشروعDataGridViewTextBoxColumn1.HeaderText = "ساعت شروع"
        Me.ساعتشروعDataGridViewTextBoxColumn1.Name = "ساعتشروعDataGridViewTextBoxColumn1"
        Me.ساعتشروعDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ساعتپایانDataGridViewTextBoxColumn1
        '
        Me.ساعتپایانDataGridViewTextBoxColumn1.DataPropertyName = "ساعت پایان"
        Me.ساعتپایانDataGridViewTextBoxColumn1.HeaderText = "ساعت پایان"
        Me.ساعتپایانDataGridViewTextBoxColumn1.Name = "ساعتپایانDataGridViewTextBoxColumn1"
        Me.ساعتپایانDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'جمعاضافهکارDataGridViewTextBoxColumn1
        '
        Me.جمعاضافهکارDataGridViewTextBoxColumn1.DataPropertyName = "جمع اضافه کار"
        Me.جمعاضافهکارDataGridViewTextBoxColumn1.HeaderText = "جمع اضافه کار"
        Me.جمعاضافهکارDataGridViewTextBoxColumn1.Name = "جمعاضافهکارDataGridViewTextBoxColumn1"
        Me.جمعاضافهکارDataGridViewTextBoxColumn1.ReadOnly = True
        Me.جمعاضافهکارDataGridViewTextBoxColumn1.Width = 110
        '
        'اضافهکارترددDataGridViewTextBoxColumn1
        '
        Me.اضافهکارترددDataGridViewTextBoxColumn1.DataPropertyName = "اضافه کار تردد"
        Me.اضافهکارترددDataGridViewTextBoxColumn1.HeaderText = "اضافه کار تردد"
        Me.اضافهکارترددDataGridViewTextBoxColumn1.Name = "اضافهکارترددDataGridViewTextBoxColumn1"
        Me.اضافهکارترددDataGridViewTextBoxColumn1.ReadOnly = True
        Me.اضافهکارترددDataGridViewTextBoxColumn1.Width = 110
        '
        'Frm_Rp_KholaseWorkForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 613)
        Me.Name = "Frm_Rp_KholaseWorkForm"
        Me.Text = "گزارش  خلاصه فرم کار"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpKholaseWorkFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخفرمکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلفعالیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکارترددDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساعتشروعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساعتپایانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents جمعاضافهکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RpKholaseWorkFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents Rp_KholaseWorkFormTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_KholaseWorkFormTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شماره As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمکارDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخفرمکارDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلفعالیتDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساعتشروعDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساعتپایانDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents جمعاضافهکارDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اضافهکارترددDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
