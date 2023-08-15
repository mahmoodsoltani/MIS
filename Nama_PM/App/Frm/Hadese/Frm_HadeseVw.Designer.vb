<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_HadeseVw
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
        Me.PmHadeseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهگزارشDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلوقوعDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.علتبروزحادثهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pm_HadeseTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_HadeseTableAdapter
        Me.PmHadeseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهگزارشDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلوقوعDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهگزارشDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.محلوقوعDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامخطDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.علتبروزحادثهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ثبتکنندهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(14, 510)
        Me.GroupBox1.Size = New System.Drawing.Size(970, 53)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(16, 16)
        Me.btn_Cancel.Size = New System.Drawing.Size(99, 29)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(645, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(101, 29)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(752, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(101, 29)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(859, 17)
        Me.btn_New.Size = New System.Drawing.Size(101, 29)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Location = New System.Drawing.Point(14, 40)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(970, 467)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn2, Me.شمارهگزارشDataGridViewTextBoxColumn2, Me.تاریخDataGridViewTextBoxColumn2, Me.محلوقوعDataGridViewTextBoxColumn2, Me.نامخطDataGridViewTextBoxColumn, Me.علتبروزحادثهDataGridViewTextBoxColumn1, Me.نامگروهDataGridViewTextBoxColumn1, Me.ثبتکنندهDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmHadeseBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!)
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(964, 442)
        Me.DataGridView1.TabIndex = 3
        '
        'PmHadeseBindingSource
        '
        Me.PmHadeseBindingSource.DataMember = "Pm_Hadese"
        Me.PmHadeseBindingSource.DataSource = Me.Ds_Hadese
        '
        'Ds_Hadese
        '
        Me.Ds_Hadese.DataSetName = "Ds_Hadese"
        Me.Ds_Hadese.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهگزارشDataGridViewTextBoxColumn
        '
        Me.شمارهگزارشDataGridViewTextBoxColumn.DataPropertyName = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn.HeaderText = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn.Name = "شمارهگزارشDataGridViewTextBoxColumn"
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        '
        'محلوقوعDataGridViewTextBoxColumn
        '
        Me.محلوقوعDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.محلوقوعDataGridViewTextBoxColumn.DataPropertyName = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn.HeaderText = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn.Name = "محلوقوعDataGridViewTextBoxColumn"
        '
        'علتبروزحادثهDataGridViewTextBoxColumn
        '
        Me.علتبروزحادثهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.علتبروزحادثهDataGridViewTextBoxColumn.DataPropertyName = "علت بروز حادثه"
        Me.علتبروزحادثهDataGridViewTextBoxColumn.HeaderText = "علت بروز حادثه"
        Me.علتبروزحادثهDataGridViewTextBoxColumn.Name = "علتبروزحادثهDataGridViewTextBoxColumn"
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        '
        'Pm_HadeseTableAdapter
        '
        Me.Pm_HadeseTableAdapter.ClearBeforeFill = True
        '
        'PmHadeseBindingSource1
        '
        Me.PmHadeseBindingSource1.DataMember = "Pm_Hadese"
        Me.PmHadeseBindingSource1.DataSource = Me.Ds_Hadese
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.Visible = False
        '
        'شمارهگزارشDataGridViewTextBoxColumn1
        '
        Me.شمارهگزارشDataGridViewTextBoxColumn1.DataPropertyName = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn1.HeaderText = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn1.Name = "شمارهگزارشDataGridViewTextBoxColumn1"
        '
        'تاریخDataGridViewTextBoxColumn1
        '
        Me.تاریخDataGridViewTextBoxColumn1.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn1.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn1.Name = "تاریخDataGridViewTextBoxColumn1"
        '
        'محلوقوعDataGridViewTextBoxColumn1
        '
        Me.محلوقوعDataGridViewTextBoxColumn1.DataPropertyName = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn1.HeaderText = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn1.Name = "محلوقوعDataGridViewTextBoxColumn1"
        '
        'SrlDataGridViewTextBoxColumn2
        '
        Me.SrlDataGridViewTextBoxColumn2.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.Name = "SrlDataGridViewTextBoxColumn2"
        Me.SrlDataGridViewTextBoxColumn2.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn2.Visible = False
        '
        'شمارهگزارشDataGridViewTextBoxColumn2
        '
        Me.شمارهگزارشDataGridViewTextBoxColumn2.DataPropertyName = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn2.HeaderText = "شماره گزارش"
        Me.شمارهگزارشDataGridViewTextBoxColumn2.Name = "شمارهگزارشDataGridViewTextBoxColumn2"
        Me.شمارهگزارشDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'تاریخDataGridViewTextBoxColumn2
        '
        Me.تاریخDataGridViewTextBoxColumn2.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn2.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn2.Name = "تاریخDataGridViewTextBoxColumn2"
        Me.تاریخDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'محلوقوعDataGridViewTextBoxColumn2
        '
        Me.محلوقوعDataGridViewTextBoxColumn2.DataPropertyName = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn2.HeaderText = "محل وقوع"
        Me.محلوقوعDataGridViewTextBoxColumn2.Name = "محلوقوعDataGridViewTextBoxColumn2"
        Me.محلوقوعDataGridViewTextBoxColumn2.ReadOnly = True
        Me.محلوقوعDataGridViewTextBoxColumn2.Width = 120
        '
        'نامخطDataGridViewTextBoxColumn
        '
        Me.نامخطDataGridViewTextBoxColumn.DataPropertyName = "نام خط"
        Me.نامخطDataGridViewTextBoxColumn.HeaderText = "نام خط"
        Me.نامخطDataGridViewTextBoxColumn.Name = "نامخطDataGridViewTextBoxColumn"
        Me.نامخطDataGridViewTextBoxColumn.ReadOnly = True
        Me.نامخطDataGridViewTextBoxColumn.Width = 150
        '
        'علتبروزحادثهDataGridViewTextBoxColumn1
        '
        Me.علتبروزحادثهDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.علتبروزحادثهDataGridViewTextBoxColumn1.DataPropertyName = "علت بروز حادثه"
        Me.علتبروزحادثهDataGridViewTextBoxColumn1.HeaderText = "علت بروز حادثه"
        Me.علتبروزحادثهDataGridViewTextBoxColumn1.Name = "علتبروزحادثهDataGridViewTextBoxColumn1"
        Me.علتبروزحادثهDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامگروهDataGridViewTextBoxColumn1
        '
        Me.نامگروهDataGridViewTextBoxColumn1.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn1.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn1.Name = "نامگروهDataGridViewTextBoxColumn1"
        Me.نامگروهDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ثبتکنندهDataGridViewTextBoxColumn
        '
        Me.ثبتکنندهDataGridViewTextBoxColumn.DataPropertyName = "ثبت کننده"
        Me.ثبتکنندهDataGridViewTextBoxColumn.HeaderText = "ثبت کننده"
        Me.ثبتکنندهDataGridViewTextBoxColumn.Name = "ثبتکنندهDataGridViewTextBoxColumn"
        Me.ثبتکنندهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_HadeseVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(998, 603)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Name = "Frm_HadeseVw"
        Me.Text = "مشاهده فرم حادثه"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهگزارشDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلوقوعDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents علتبروزحادثهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents PmHadeseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_HadeseTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_HadeseTableAdapter
    Friend WithEvents PmHadeseBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهگزارشDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلوقوعDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهگزارشDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents محلوقوعDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامخطDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents علتبروزحادثهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ثبتکنندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
