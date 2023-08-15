<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Distance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.TextBox1 = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lk_To = New CS_Component.LookupBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.lk_from = New CS_Component.LookupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.PM_PostTableAdapter
        Me.PmDistanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_DistanceTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_DistanceTableAdapter
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مبداDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.مقصدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.فاصلهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmDistanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(128, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(375, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(252, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(499, 347)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.lk_from)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.lk_To)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 448)
        Me.gbx_Controls.Size = New System.Drawing.Size(499, 133)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 389)
        Me.gbx_Btn.Size = New System.Drawing.Size(499, 57)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.مبداDataGridViewTextBoxColumn, Me.مقصدDataGridViewTextBoxColumn, Me.فاصلهDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmDistanceBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(493, 323)
        Me.DataGridView1.TabIndex = 1
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = True
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(336, 94)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(98, 25)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Tag = "Distance"
        Me.TextBox1.Text = "0"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(444, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "فاصله"
        '
        'lk_To
        '
        Me.lk_To.CodeBoxWidth = 0
        Me.lk_To.CodeField = "کد"
        Me.lk_To.DataAccess = Nothing
        Me.lk_To.DataFields = Nothing
        Me.lk_To.DataMode = CS_Component.LookupDataMode.UseDataTable
        Me.lk_To.DataSource = Me.PmPostBindingSource
        Me.lk_To.DefaultSearchField = "نام پست"
        Me.lk_To.DisplayCodeBox = False
        Me.lk_To.DisplayField = "نام پست"
        Me.lk_To.Filter = ""
        Me.lk_To.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lk_To.HiddenFields = "0,5,4"
        Me.lk_To.Location = New System.Drawing.Point(21, 58)
        Me.lk_To.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lk_To.Name = "lk_To"
        Me.lk_To.Result = Nothing
        Me.lk_To.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lk_To.Size = New System.Drawing.Size(413, 29)
        Me.lk_To.TabIndex = 7
        Me.lk_To.TableName = Nothing
        Me.lk_To.Tag = "Srl_Post2"
        Me.lk_To.ValueField = "Srl"
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(444, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "مبدا"
        '
        'lk_from
        '
        Me.lk_from.CodeBoxWidth = 0
        Me.lk_from.CodeField = "کد"
        Me.lk_from.DataAccess = Nothing
        Me.lk_from.DataFields = Nothing
        Me.lk_from.DataMode = CS_Component.LookupDataMode.UseDataTable
        Me.lk_from.DataSource = Me.PmPostBindingSource
        Me.lk_from.DefaultSearchField = "نام پست"
        Me.lk_from.DisplayCodeBox = False
        Me.lk_from.DisplayField = "نام پست"
        Me.lk_from.Filter = ""
        Me.lk_from.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lk_from.HiddenFields = "0,5,4"
        Me.lk_from.Location = New System.Drawing.Point(21, 25)
        Me.lk_from.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lk_from.Name = "lk_from"
        Me.lk_from.Result = Nothing
        Me.lk_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lk_from.Size = New System.Drawing.Size(413, 29)
        Me.lk_from.TabIndex = 7
        Me.lk_from.TableName = Nothing
        Me.lk_from.Tag = "Srl_Post1"
        Me.lk_from.ValueField = "Srl"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "مقصد"
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'PmDistanceBindingSource
        '
        Me.PmDistanceBindingSource.DataMember = "Pm_Distance"
        Me.PmDistanceBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_DistanceTableAdapter
        '
        Me.Pm_DistanceTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'مبداDataGridViewTextBoxColumn
        '
        Me.مبداDataGridViewTextBoxColumn.DataPropertyName = "مبدا"
        Me.مبداDataGridViewTextBoxColumn.HeaderText = "مبدا"
        Me.مبداDataGridViewTextBoxColumn.Name = "مبداDataGridViewTextBoxColumn"
        Me.مبداDataGridViewTextBoxColumn.ReadOnly = True
        Me.مبداDataGridViewTextBoxColumn.Width = 150
        '
        'مقصدDataGridViewTextBoxColumn
        '
        Me.مقصدDataGridViewTextBoxColumn.DataPropertyName = "مقصد"
        Me.مقصدDataGridViewTextBoxColumn.HeaderText = "مقصد"
        Me.مقصدDataGridViewTextBoxColumn.Name = "مقصدDataGridViewTextBoxColumn"
        Me.مقصدDataGridViewTextBoxColumn.ReadOnly = True
        Me.مقصدDataGridViewTextBoxColumn.Width = 150
        '
        'فاصلهDataGridViewTextBoxColumn
        '
        Me.فاصلهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.فاصلهDataGridViewTextBoxColumn.DataPropertyName = "فاصله"
        Me.فاصلهDataGridViewTextBoxColumn.HeaderText = "فاصله"
        Me.فاصلهDataGridViewTextBoxColumn.Name = "فاصلهDataGridViewTextBoxColumn"
        Me.فاصلهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Frm_Distance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(526, 618)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Distance"
        Me.TableName = "Pm_Distance"
        Me.Text = "تعریف فاصله"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmDistanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lk_To As CS_Component.LookupBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents lk_from As CS_Component.LookupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents PmDistanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_DistanceTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_DistanceTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مبداDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents مقصدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فاصلهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
