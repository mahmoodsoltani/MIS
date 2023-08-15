<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_MonthReportConfirmPrice
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مبلغارسالیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مبلغتائیدشدهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmconMonthReportGrouupConfirmPriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.Pm_con_MonthReportGrouupConfirmPriceTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_con_MonthReportGrouupConfirmPriceTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmconMonthReportGrouupConfirmPriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 368)
        Me.GroupBox1.Size = New System.Drawing.Size(526, 47)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.HeaderText = "بازگشت"
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(241, 15)
        Me.btn_Delete.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(335, 15)
        Me.btn_Edit.Visible = False
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(429, 15)
        Me.btn_New.Visible = False
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(526, 330)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.نامگروهDataGridViewTextBoxColumn, Me.مبلغارسالیDataGridViewTextBoxColumn, Me.مبلغتائیدشدهDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmconMonthReportGrouupConfirmPriceBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(520, 308)
        Me.DataGridView1.TabIndex = 3
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
        '
        'مبلغارسالیDataGridViewTextBoxColumn
        '
        Me.مبلغارسالیDataGridViewTextBoxColumn.DataPropertyName = "مبلغ ارسالی"
        Me.مبلغارسالیDataGridViewTextBoxColumn.HeaderText = "مبلغ ارسالی"
        Me.مبلغارسالیDataGridViewTextBoxColumn.Name = "مبلغارسالیDataGridViewTextBoxColumn"
        '
        'مبلغتائیدشدهDataGridViewTextBoxColumn
        '
        Me.مبلغتائیدشدهDataGridViewTextBoxColumn.DataPropertyName = "مبلغ تائید شده"
        Me.مبلغتائیدشدهDataGridViewTextBoxColumn.HeaderText = "مبلغ تائید شده"
        Me.مبلغتائیدشدهDataGridViewTextBoxColumn.Name = "مبلغتائیدشدهDataGridViewTextBoxColumn"
        '
        'PmconMonthReportGrouupConfirmPriceBindingSource
        '
        Me.PmconMonthReportGrouupConfirmPriceBindingSource.DataMember = "Pm_con_MonthReportGrouupConfirmPrice"
        Me.PmconMonthReportGrouupConfirmPriceBindingSource.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_con_MonthReportGrouupConfirmPriceTableAdapter
        '
        Me.Pm_con_MonthReportGrouupConfirmPriceTableAdapter.ClearBeforeFill = True
        '
        'Frm_Con_MonthReportConfirmPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 451)
        Me.Name = "Frm_Con_MonthReportConfirmPrice"
        Me.Text = "مبلغ تائید شده برای هر گروه"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmconMonthReportGrouupConfirmPriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مبلغارسالیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مبلغتائیدشدهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmconMonthReportGrouupConfirmPriceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents Pm_con_MonthReportGrouupConfirmPriceTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_con_MonthReportGrouupConfirmPriceTableAdapter
End Class
