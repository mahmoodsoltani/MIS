<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ShowWorkForm
    Inherits VB_Component.BaseForm

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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدهزینهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلفعالیتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ساعتشروعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ساعتپایانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.فاصلهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مجموعاضافهکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeCardWorkFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.TimeCard_WorkFormTableAdapter = New Nama_PM.Ds_RpTableAdapters.TimeCard_WorkFormTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeCardWorkFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.شمارهDataGridViewTextBoxColumn, Me.کدهزینهDataGridViewTextBoxColumn, Me.محلفعالیتDataGridViewTextBoxColumn, Me.ساعتشروعDataGridViewTextBoxColumn, Me.ساعتپایانDataGridViewTextBoxColumn, Me.فاصلهDataGridViewTextBoxColumn, Me.مجموعاضافهکارDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TimeCardWorkFormBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(6, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(718, 207)
        Me.DataGridView1.TabIndex = 5
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.Width = 90
        '
        'کدهزینهDataGridViewTextBoxColumn
        '
        Me.کدهزینهDataGridViewTextBoxColumn.DataPropertyName = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.HeaderText = "کد هزینه"
        Me.کدهزینهDataGridViewTextBoxColumn.Name = "کدهزینهDataGridViewTextBoxColumn"
        Me.کدهزینهDataGridViewTextBoxColumn.Width = 90
        '
        'محلفعالیتDataGridViewTextBoxColumn
        '
        Me.محلفعالیتDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.محلفعالیتDataGridViewTextBoxColumn.DataPropertyName = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.HeaderText = "محل فعالیت"
        Me.محلفعالیتDataGridViewTextBoxColumn.Name = "محلفعالیتDataGridViewTextBoxColumn"
        '
        'ساعتشروعDataGridViewTextBoxColumn
        '
        Me.ساعتشروعDataGridViewTextBoxColumn.DataPropertyName = "ساعت شروع"
        Me.ساعتشروعDataGridViewTextBoxColumn.HeaderText = "ساعت شروع"
        Me.ساعتشروعDataGridViewTextBoxColumn.Name = "ساعتشروعDataGridViewTextBoxColumn"
        Me.ساعتشروعDataGridViewTextBoxColumn.Width = 80
        '
        'ساعتپایانDataGridViewTextBoxColumn
        '
        Me.ساعتپایانDataGridViewTextBoxColumn.DataPropertyName = "ساعت پایان"
        Me.ساعتپایانDataGridViewTextBoxColumn.HeaderText = "ساعت پایان"
        Me.ساعتپایانDataGridViewTextBoxColumn.Name = "ساعتپایانDataGridViewTextBoxColumn"
        Me.ساعتپایانDataGridViewTextBoxColumn.Width = 80
        '
        'فاصلهDataGridViewTextBoxColumn
        '
        Me.فاصلهDataGridViewTextBoxColumn.DataPropertyName = "فاصله"
        Me.فاصلهDataGridViewTextBoxColumn.HeaderText = "فاصله"
        Me.فاصلهDataGridViewTextBoxColumn.Name = "فاصلهDataGridViewTextBoxColumn"
        Me.فاصلهDataGridViewTextBoxColumn.Width = 90
        '
        'مجموعاضافهکارDataGridViewTextBoxColumn
        '
        Me.مجموعاضافهکارDataGridViewTextBoxColumn.DataPropertyName = "مجموع اضافه کار"
        Me.مجموعاضافهکارDataGridViewTextBoxColumn.HeaderText = "مجموع اضافه کار"
        Me.مجموعاضافهکارDataGridViewTextBoxColumn.Name = "مجموعاضافهکارDataGridViewTextBoxColumn"
        Me.مجموعاضافهکارDataGridViewTextBoxColumn.ReadOnly = True
        Me.مجموعاضافهکارDataGridViewTextBoxColumn.Width = 90
        '
        'TimeCardWorkFormBindingSource
        '
        Me.TimeCardWorkFormBindingSource.DataMember = "TimeCard_WorkForm"
        Me.TimeCardWorkFormBindingSource.DataSource = Me.Ds_Rp
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimeCard_WorkFormTableAdapter
        '
        Me.TimeCard_WorkFormTableAdapter.ClearBeforeFill = True
        '
        'Frm_ShowWorkForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 293)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Frm_ShowWorkForm"
        Me.Text = "نمایش فرم کار ها"
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeCardWorkFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeginWorkSatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndWorkSatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumextraworkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدهزینهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلفعالیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساعتشروعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ساعتپایانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فاصلهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مجموعاضافهکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeCardWorkFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents TimeCard_WorkFormTableAdapter As Nama_PM.Ds_RpTableAdapters.TimeCard_WorkFormTableAdapter
End Class
