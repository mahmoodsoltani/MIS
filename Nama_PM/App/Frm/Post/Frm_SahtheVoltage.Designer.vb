<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SatheVoltage
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
        Me.Txt_Code = New CS_Component.TextBox
        Me.Txt_Voltage = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmSathevoltageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_SathevoltageTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_SathevoltageTableAdapter
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سطحولتاژDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSathevoltageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(184, 16)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(400, 16)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(292, 16)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(12, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(508, 366)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Controls.Controls.Add(Me.Txt_Code)
        Me.gbx_Controls.Controls.Add(Me.Txt_Voltage)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(12, 461)
        Me.gbx_Controls.Size = New System.Drawing.Size(508, 101)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Btn.Location = New System.Drawing.Point(12, 408)
        Me.gbx_Btn.Size = New System.Drawing.Size(508, 53)
        '
        'Txt_Code
        '
        Me.Txt_Code.CheckExistValueInDb = False
        Me.Txt_Code.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Code.CurrencyUnit = "ریال"
        Me.Txt_Code.DefaultValue = ""
        Me.Txt_Code.Enabled = False
        Me.Txt_Code.FillWithMaxInDb = True
        Me.Txt_Code.IsRequired = True
        Me.Txt_Code.Location = New System.Drawing.Point(288, 62)
        Me.Txt_Code.MaxDecimalLength = 2
        Me.Txt_Code.Name = "Txt_Code"
        Me.Txt_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Code.Size = New System.Drawing.Size(131, 23)
        Me.Txt_Code.SpellControl = Nothing
        Me.Txt_Code.TabIndex = 9
        Me.Txt_Code.Tag = "Code"
        Me.Txt_Code.Text = "0"
        Me.Txt_Code.Title = Nothing
        Me.Txt_Code.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.Txt_Code.UseForData = True
        Me.Txt_Code.ValidateCheckExistOnEdit = False
        Me.Txt_Code.Value = 0
        '
        'Txt_Voltage
        '
        Me.Txt_Voltage.CheckExistValueInDb = True
        Me.Txt_Voltage.ColorOnFocus = System.Drawing.Color.Yellow
        Me.Txt_Voltage.CurrencyUnit = "ریال"
        Me.Txt_Voltage.DefaultValue = ""
        Me.Txt_Voltage.FillWithMaxInDb = False
        Me.Txt_Voltage.IsRequired = False
        Me.Txt_Voltage.Location = New System.Drawing.Point(48, 32)
        Me.Txt_Voltage.MaxDecimalLength = 2
        Me.Txt_Voltage.Name = "Txt_Voltage"
        Me.Txt_Voltage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Voltage.Size = New System.Drawing.Size(371, 23)
        Me.Txt_Voltage.SpellControl = Nothing
        Me.Txt_Voltage.TabIndex = 8
        Me.Txt_Voltage.Tag = "Voltage"
        Me.Txt_Voltage.Title = Nothing
        Me.Txt_Voltage.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.Txt_Voltage.UseForData = True
        Me.Txt_Voltage.ValidateCheckExistOnEdit = False
        Me.Txt_Voltage.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(427, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "کد"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(427, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "سطح ولتاژ"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.کدDataGridViewTextBoxColumn, Me.سطحولتاژDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmSathevoltageBindingSource
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
        Me.DataGridView1.Size = New System.Drawing.Size(502, 344)
        Me.DataGridView1.TabIndex = 4
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmSathevoltageBindingSource
        '
        Me.PmSathevoltageBindingSource.DataMember = "Pm_Sathevoltage"
        Me.PmSathevoltageBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_SathevoltageTableAdapter
        '
        Me.Pm_SathevoltageTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
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
        'سطحولتاژDataGridViewTextBoxColumn
        '
        Me.سطحولتاژDataGridViewTextBoxColumn.DataPropertyName = "سطح ولتاژ"
        Me.سطحولتاژDataGridViewTextBoxColumn.HeaderText = "سطح ولتاژ"
        Me.سطحولتاژDataGridViewTextBoxColumn.Name = "سطحولتاژDataGridViewTextBoxColumn"
        Me.سطحولتاژDataGridViewTextBoxColumn.ReadOnly = True
        Me.سطحولتاژDataGridViewTextBoxColumn.Width = 375
        '
        'Frm_SatheVoltage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 598)
        Me.Name = "Frm_SatheVoltage"
        Me.TableName = "Pm_Sathevoltage"
        Me.Text = "سطح ولتاژ"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSathevoltageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Code As CS_Component.TextBox
    Friend WithEvents Txt_Voltage As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmSathevoltageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_SathevoltageTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_SathevoltageTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سطحولتاژDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
