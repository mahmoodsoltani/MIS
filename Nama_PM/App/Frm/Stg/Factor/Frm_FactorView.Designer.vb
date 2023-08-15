<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_FactorView
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.StgFactorMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Kala = New Nama_PM.Ds_Kala
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مشتریDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخثبتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_report = New CS_Component.Btn
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مشتریDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخثبتDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نوعثبتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_ToDate = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Chb_date = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_FromDate = New CS_Component.TextBox
        Me.Stg_FactorMasterTableAdapter = New Nama_PM.Ds_KalaTableAdapters.Stg_FactorMasterTableAdapter
        Me.RpFactorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_FactorTableAdapter = New Nama_PM.Ds_KalaTableAdapters.Rp_FactorTableAdapter
        Me.SrlDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مشتریDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخثبتDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهفاکتورخریدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StgFactorMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Kala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RpFactorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 485)
        Me.GroupBox1.Size = New System.Drawing.Size(849, 53)
        Me.GroupBox1.Controls.SetChildIndex(Me.Panel1, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_New, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Cancel, 0)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(16, 16)
        Me.btn_Cancel.Size = New System.Drawing.Size(99, 29)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(523, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(101, 29)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(631, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(101, 29)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(738, 17)
        Me.btn_New.Size = New System.Drawing.Size(101, 29)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.txt_FromDate)
        Me.gbx_DataGridView.Controls.Add(Me.txt_ToDate)
        Me.gbx_DataGridView.Controls.Add(Me.Chb_date)
        Me.gbx_DataGridView.Controls.Add(Me.Label1)
        Me.gbx_DataGridView.Controls.Add(Me.Label4)
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Location = New System.Drawing.Point(14, 40)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(849, 442)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn2, Me.شمارهDataGridViewTextBoxColumn2, Me.مشتریDataGridViewTextBoxColumn2, Me.تاریخثبتDataGridViewTextBoxColumn2, Me.شمارهفاکتورخریدDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.StgFactorMasterBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(7, 60)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(837, 369)
        Me.DataGridView1.TabIndex = 0
        '
        'StgFactorMasterBindingSource
        '
        Me.StgFactorMasterBindingSource.DataMember = "Stg_FactorMaster"
        Me.StgFactorMasterBindingSource.DataSource = Me.Ds_Kala
        '
        'Ds_Kala
        '
        Me.Ds_Kala.DataSetName = "Ds_Kala"
        Me.Ds_Kala.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره فاکتور"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.ReadOnly = True
        Me.شمارهDataGridViewTextBoxColumn.Width = 130
        '
        'مشتریDataGridViewTextBoxColumn
        '
        Me.مشتریDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.مشتریDataGridViewTextBoxColumn.DataPropertyName = "مشتری"
        Me.مشتریDataGridViewTextBoxColumn.HeaderText = "مشتری"
        Me.مشتریDataGridViewTextBoxColumn.Name = "مشتریDataGridViewTextBoxColumn"
        Me.مشتریDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخثبتDataGridViewTextBoxColumn
        '
        Me.تاریخثبتDataGridViewTextBoxColumn.DataPropertyName = "تاریخ ثبت"
        Me.تاریخثبتDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت"
        Me.تاریخثبتDataGridViewTextBoxColumn.Name = "تاریخثبتDataGridViewTextBoxColumn"
        Me.تاریخثبتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_report)
        Me.Panel1.Location = New System.Drawing.Point(354, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 33)
        Me.Panel1.TabIndex = 4
        '
        'Btn_report
        '
        Me.Btn_report.BackColor = System.Drawing.Color.Transparent
        Me.Btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_report.HeaderText = "گزارش"
        Me.Btn_report.Location = New System.Drawing.Point(53, 1)
        Me.Btn_report.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_report.Name = "Btn_report"
        Me.Btn_report.Size = New System.Drawing.Size(106, 29)
        Me.Btn_report.TabIndex = 0
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        '
        'شمارهDataGridViewTextBoxColumn1
        '
        Me.شمارهDataGridViewTextBoxColumn1.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn1.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn1.Name = "شمارهDataGridViewTextBoxColumn1"
        '
        'مشتریDataGridViewTextBoxColumn1
        '
        Me.مشتریDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.مشتریDataGridViewTextBoxColumn1.DataPropertyName = "مشتری"
        Me.مشتریDataGridViewTextBoxColumn1.HeaderText = "مشتری"
        Me.مشتریDataGridViewTextBoxColumn1.Name = "مشتریDataGridViewTextBoxColumn1"
        '
        'تاریخثبتDataGridViewTextBoxColumn1
        '
        Me.تاریخثبتDataGridViewTextBoxColumn1.DataPropertyName = "تاریخ ثبت"
        Me.تاریخثبتDataGridViewTextBoxColumn1.HeaderText = "تاریخ فاکتور"
        Me.تاریخثبتDataGridViewTextBoxColumn1.Name = "تاریخثبتDataGridViewTextBoxColumn1"
        '
        'نوعثبتDataGridViewTextBoxColumn
        '
        Me.نوعثبتDataGridViewTextBoxColumn.DataPropertyName = "نوع ثبت"
        Me.نوعثبتDataGridViewTextBoxColumn.HeaderText = "نوع ثبت"
        Me.نوعثبتDataGridViewTextBoxColumn.Name = "نوعثبتDataGridViewTextBoxColumn"
        Me.نوعثبتDataGridViewTextBoxColumn.Visible = False
        Me.نوعثبتDataGridViewTextBoxColumn.Width = 120
        '
        'txt_ToDate
        '
        Me.txt_ToDate.CheckExistValueInDb = False
        Me.txt_ToDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ToDate.CurrencyUnit = "ریال"
        Me.txt_ToDate.DefaultValue = ""
        Me.txt_ToDate.FillWithMaxInDb = False
        Me.txt_ToDate.IsRequired = False
        Me.txt_ToDate.Location = New System.Drawing.Point(35, 22)
        Me.txt_ToDate.MaxDecimalLength = 2
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.Size = New System.Drawing.Size(156, 25)
        Me.txt_ToDate.SpellControl = Nothing
        Me.txt_ToDate.TabIndex = 14
        Me.txt_ToDate.TabStop = False
        Me.txt_ToDate.Tag = ""
        Me.txt_ToDate.Title = Nothing
        Me.txt_ToDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_ToDate.UseForData = True
        Me.txt_ToDate.ValidateCheckExistOnEdit = False
        Me.txt_ToDate.Value = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "تا تاریخ"
        '
        'Chb_date
        '
        Me.Chb_date.AutoSize = True
        Me.Chb_date.Location = New System.Drawing.Point(694, 25)
        Me.Chb_date.Name = "Chb_date"
        Me.Chb_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Chb_date.Size = New System.Drawing.Size(105, 22)
        Me.Chb_date.TabIndex = 16
        Me.Chb_date.Text = "تمام تاریخ ها"
        Me.Chb_date.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(417, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "از تاریخ"
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CheckExistValueInDb = False
        Me.txt_FromDate.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromDate.CurrencyUnit = "ریال"
        Me.txt_FromDate.DefaultValue = ""
        Me.txt_FromDate.FillWithMaxInDb = False
        Me.txt_FromDate.IsRequired = False
        Me.txt_FromDate.Location = New System.Drawing.Point(256, 21)
        Me.txt_FromDate.MaxDecimalLength = 2
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.Size = New System.Drawing.Size(142, 25)
        Me.txt_FromDate.SpellControl = Nothing
        Me.txt_FromDate.TabIndex = 14
        Me.txt_FromDate.TabStop = False
        Me.txt_FromDate.Tag = ""
        Me.txt_FromDate.Title = Nothing
        Me.txt_FromDate.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FromDate.UseForData = True
        Me.txt_FromDate.ValidateCheckExistOnEdit = False
        Me.txt_FromDate.Value = ""
        '
        'Stg_FactorMasterTableAdapter
        '
        Me.Stg_FactorMasterTableAdapter.ClearBeforeFill = True
        '
        'RpFactorBindingSource
        '
        Me.RpFactorBindingSource.DataMember = "Rp_Factor"
        Me.RpFactorBindingSource.DataSource = Me.Ds_Kala
        '
        'Rp_FactorTableAdapter
        '
        Me.Rp_FactorTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn2
        '
        Me.SrlDataGridViewTextBoxColumn2.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn2.Name = "SrlDataGridViewTextBoxColumn2"
        Me.SrlDataGridViewTextBoxColumn2.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn2.Visible = False
        '
        'شمارهDataGridViewTextBoxColumn2
        '
        Me.شمارهDataGridViewTextBoxColumn2.DataPropertyName = "شماره"
        DataGridViewCellStyle2.Format = "N0"
        Me.شمارهDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.شمارهDataGridViewTextBoxColumn2.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn2.Name = "شمارهDataGridViewTextBoxColumn2"
        Me.شمارهDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'مشتریDataGridViewTextBoxColumn2
        '
        Me.مشتریDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.مشتریDataGridViewTextBoxColumn2.DataPropertyName = "مشتری"
        Me.مشتریDataGridViewTextBoxColumn2.HeaderText = "مشتری"
        Me.مشتریDataGridViewTextBoxColumn2.Name = "مشتریDataGridViewTextBoxColumn2"
        Me.مشتریDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'تاریخثبتDataGridViewTextBoxColumn2
        '
        Me.تاریخثبتDataGridViewTextBoxColumn2.DataPropertyName = "تاریخ ثبت"
        Me.تاریخثبتDataGridViewTextBoxColumn2.HeaderText = "تاریخ ثبت"
        Me.تاریخثبتDataGridViewTextBoxColumn2.Name = "تاریخثبتDataGridViewTextBoxColumn2"
        Me.تاریخثبتDataGridViewTextBoxColumn2.ReadOnly = True
        Me.تاریخثبتDataGridViewTextBoxColumn2.Width = 150
        '
        'شمارهفاکتورخریدDataGridViewTextBoxColumn
        '
        Me.شمارهفاکتورخریدDataGridViewTextBoxColumn.DataPropertyName = "شماره فاکتور خرید"
        Me.شمارهفاکتورخریدDataGridViewTextBoxColumn.HeaderText = "شماره فاکتور خرید"
        Me.شمارهفاکتورخریدDataGridViewTextBoxColumn.Name = "شمارهفاکتورخریدDataGridViewTextBoxColumn"
        Me.شمارهفاکتورخریدDataGridViewTextBoxColumn.ReadOnly = True
        Me.شمارهفاکتورخریدDataGridViewTextBoxColumn.Width = 150
        '
        'Frm_FactorView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(877, 578)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Name = "Frm_FactorView"
        Me.Text = "مشاهده فاکتورها"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.gbx_DataGridView.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StgFactorMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Kala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RpFactorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مشتریDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخثبتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_report As CS_Component.Btn
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مشتریDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخثبتDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوعثبتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chb_date As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ToDate As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_FromDate As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StgFactorMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Kala As Nama_PM.Ds_Kala
    Friend WithEvents Stg_FactorMasterTableAdapter As Nama_PM.Ds_KalaTableAdapters.Stg_FactorMasterTableAdapter
    Friend WithEvents RpFactorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_FactorTableAdapter As Nama_PM.Ds_KalaTableAdapters.Rp_FactorTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مشتریDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخثبتDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفاکتورخریدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
