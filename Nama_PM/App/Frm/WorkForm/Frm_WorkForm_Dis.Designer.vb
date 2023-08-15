<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WorkForm_Dis
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.توضیحکارDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmWorkDisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.TextBox2 = New CS_Component.TextBox
        Me.TextBox1 = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pm_WorkDisTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_WorkDisTableAdapter
        Me.Chk_PmWork = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TimeSelect1 = New VB_Component.TimeSelect
        Me.TimeSelect2 = New VB_Component.TimeSelect
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmWorkDisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(485, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(609, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(485, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(732, 375)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.CheckBox1)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect2)
        Me.gbx_Controls.Controls.Add(Me.TimeSelect1)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Chk_PmWork)
        Me.gbx_Controls.Controls.Add(Me.TextBox2)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 473)
        Me.gbx_Controls.Size = New System.Drawing.Size(732, 97)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 417)
        Me.gbx_Btn.Size = New System.Drawing.Size(732, 57)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.کدDataGridViewTextBoxColumn, Me.توضیحکارDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmWorkDisBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(7, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(713, 339)
        Me.DataGridView1.TabIndex = 3
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
        'توضیحکارDataGridViewTextBoxColumn
        '
        Me.توضیحکارDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.توضیحکارDataGridViewTextBoxColumn.DataPropertyName = "توضیح کار"
        Me.توضیحکارDataGridViewTextBoxColumn.HeaderText = "توضیح کار"
        Me.توضیحکارDataGridViewTextBoxColumn.Name = "توضیحکارDataGridViewTextBoxColumn"
        Me.توضیحکارDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmWorkDisBindingSource
        '
        Me.PmWorkDisBindingSource.DataMember = "Pm_WorkDis"
        Me.PmWorkDisBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.CheckExistValueInDb = False
        Me.TextBox2.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox2.CurrencyUnit = "ریال"
        Me.TextBox2.DefaultValue = ""
        Me.TextBox2.Enabled = False
        Me.TextBox2.FillWithMaxInDb = True
        Me.TextBox2.IsRequired = True
        Me.TextBox2.Location = New System.Drawing.Point(646, 24)
        Me.TextBox2.MaxDecimalLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(41, 25)
        Me.TextBox2.SpellControl = Nothing
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Tag = "Code"
        Me.TextBox2.Text = "0"
        Me.TextBox2.Title = Nothing
        Me.TextBox2.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox2.UseForData = True
        Me.TextBox2.ValidateCheckExistOnEdit = False
        Me.TextBox2.Value = 0
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = True
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(210, 23)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(354, 25)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Tag = "Name"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(694, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "کد"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(572, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "توضیح کار"
        '
        'Pm_WorkDisTableAdapter
        '
        Me.Pm_WorkDisTableAdapter.ClearBeforeFill = True
        '
        'Chk_PmWork
        '
        Me.Chk_PmWork.AutoSize = True
        Me.Chk_PmWork.Location = New System.Drawing.Point(35, 25)
        Me.Chk_PmWork.Name = "Chk_PmWork"
        Me.Chk_PmWork.Size = New System.Drawing.Size(169, 22)
        Me.Chk_PmWork.TabIndex = 2
        Me.Chk_PmWork.Tag = "IsPm"
        Me.Chk_PmWork.Text = "اعمال ساعت تشویقی"
        Me.Chk_PmWork.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ساعت تعلق اضافه کاری"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(570, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "مقدار ساعت تشویقی"
        '
        'TimeSelect1
        '
        Me.TimeSelect1.Hour = "00"
        Me.TimeSelect1.HourMaxLen = 4
        Me.TimeSelect1.Location = New System.Drawing.Point(210, 55)
        Me.TimeSelect1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TimeSelect1.Minutes = "00"
        Me.TimeSelect1.Name = "TimeSelect1"
        Me.TimeSelect1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect1.Second = "00"
        Me.TimeSelect1.Size = New System.Drawing.Size(75, 28)
        Me.TimeSelect1.TabIndex = 4
        Me.TimeSelect1.Tag = "FromSat"
        Me.TimeSelect1.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect1.Value = "00:00:00"
        '
        'TimeSelect2
        '
        Me.TimeSelect2.Hour = "00"
        Me.TimeSelect2.HourMaxLen = 4
        Me.TimeSelect2.Location = New System.Drawing.Point(489, 55)
        Me.TimeSelect2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TimeSelect2.Minutes = "00"
        Me.TimeSelect2.Name = "TimeSelect2"
        Me.TimeSelect2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TimeSelect2.Second = "00"
        Me.TimeSelect2.Size = New System.Drawing.Size(75, 28)
        Me.TimeSelect2.TabIndex = 3
        Me.TimeSelect2.Tag = "Duration"
        Me.TimeSelect2.time = System.TimeSpan.Parse("00:00:00")
        Me.TimeSelect2.Value = "00:00:00"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(134, 59)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(68, 22)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Tag = "IsPmMain"
        Me.CheckBox1.Text = "کار PM"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Frm_WorkForm_Dis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(759, 609)
        Me.DataGridView = Me.DataGridView1
        Me.ExecEditOnSelectDatagrideView = True
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_WorkForm_Dis"
        Me.TableName = "Pm_WorkDis"
        Me.Text = "تعریف توضیح کار"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmWorkDisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents TextBox2 As CS_Component.TextBox
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmWorkDisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_WorkDisTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_WorkDisTableAdapter
    Friend WithEvents Chk_PmWork As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TimeSelect1 As VB_Component.TimeSelect
    Friend WithEvents TimeSelect2 As VB_Component.TimeSelect
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
