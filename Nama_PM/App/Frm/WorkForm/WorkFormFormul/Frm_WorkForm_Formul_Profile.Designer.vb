<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WorkForm_Formul_Profile
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
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ازتاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاتاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.فعالDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PmWorkFormFormulaProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_FromKarNo = New CS_Component.TextBox
        Me.txt_FormKarTarikh = New CS_Component.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New CS_Component.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Pm_WorkForm_Formula_ProfileTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_WorkForm_Formula_ProfileTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmWorkFormFormulaProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_Delete.Location = New System.Drawing.Point(176, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(423, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(299, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(546, 207)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.CheckBox1)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.txt_FormKarTarikh)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.Label7)
        Me.gbx_Controls.Controls.Add(Me.txt_FromKarNo)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 307)
        Me.gbx_Controls.Size = New System.Drawing.Size(546, 119)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 247)
        Me.gbx_Btn.Size = New System.Drawing.Size(546, 60)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.نامDataGridViewTextBoxColumn, Me.ازتاریخDataGridViewTextBoxColumn, Me.تاتاریخDataGridViewTextBoxColumn, Me.فعالDataGridViewCheckBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmWorkFormFormulaProfileBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(7, 20)
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
        Me.DataGridView1.Size = New System.Drawing.Size(533, 181)
        Me.DataGridView1.TabIndex = 0
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامDataGridViewTextBoxColumn
        '
        Me.نامDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامDataGridViewTextBoxColumn.DataPropertyName = "نام"
        Me.نامDataGridViewTextBoxColumn.HeaderText = "نام"
        Me.نامDataGridViewTextBoxColumn.Name = "نامDataGridViewTextBoxColumn"
        Me.نامDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ازتاریخDataGridViewTextBoxColumn
        '
        Me.ازتاریخDataGridViewTextBoxColumn.DataPropertyName = "از تاریخ"
        Me.ازتاریخDataGridViewTextBoxColumn.HeaderText = "از تاریخ"
        Me.ازتاریخDataGridViewTextBoxColumn.Name = "ازتاریخDataGridViewTextBoxColumn"
        Me.ازتاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاتاریخDataGridViewTextBoxColumn
        '
        Me.تاتاریخDataGridViewTextBoxColumn.DataPropertyName = "تا تاریخ"
        Me.تاتاریخDataGridViewTextBoxColumn.HeaderText = "تا تاریخ"
        Me.تاتاریخDataGridViewTextBoxColumn.Name = "تاتاریخDataGridViewTextBoxColumn"
        Me.تاتاریخDataGridViewTextBoxColumn.ReadOnly = True
        '
        'فعالDataGridViewCheckBoxColumn
        '
        Me.فعالDataGridViewCheckBoxColumn.DataPropertyName = "فعال"
        Me.فعالDataGridViewCheckBoxColumn.HeaderText = "فعال"
        Me.فعالDataGridViewCheckBoxColumn.Name = "فعالDataGridViewCheckBoxColumn"
        Me.فعالDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PmWorkFormFormulaProfileBindingSource
        '
        Me.PmWorkFormFormulaProfileBindingSource.DataMember = "Pm_WorkForm_Formula_Profile"
        Me.PmWorkFormFormulaProfileBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(445, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "نام پروفایل"
        '
        'txt_FromKarNo
        '
        Me.txt_FromKarNo.CheckExistValueInDb = True
        Me.txt_FromKarNo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FromKarNo.CurrencyUnit = "ریال"
        Me.txt_FromKarNo.DefaultValue = ""
        Me.txt_FromKarNo.FillWithMaxInDb = False
        Me.txt_FromKarNo.IsRequired = True
        Me.txt_FromKarNo.Location = New System.Drawing.Point(270, 36)
        Me.txt_FromKarNo.MaxDecimalLength = 2
        Me.txt_FromKarNo.Name = "txt_FromKarNo"
        Me.txt_FromKarNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_FromKarNo.Size = New System.Drawing.Size(169, 26)
        Me.txt_FromKarNo.SpellControl = Nothing
        Me.txt_FromKarNo.TabIndex = 0
        Me.txt_FromKarNo.Tag = "Name"
        Me.txt_FromKarNo.Title = Nothing
        Me.txt_FromKarNo.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_FromKarNo.UseForData = True
        Me.txt_FromKarNo.ValidateCheckExistOnEdit = False
        Me.txt_FromKarNo.Value = ""
        '
        'txt_FormKarTarikh
        '
        Me.txt_FormKarTarikh.CheckExistValueInDb = False
        Me.txt_FormKarTarikh.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FormKarTarikh.CurrencyUnit = "ریال"
        Me.txt_FormKarTarikh.DefaultValue = ""
        Me.txt_FormKarTarikh.FillWithMaxInDb = False
        Me.txt_FormKarTarikh.IsRequired = True
        Me.txt_FormKarTarikh.Location = New System.Drawing.Point(270, 68)
        Me.txt_FormKarTarikh.MaxDecimalLength = 2
        Me.txt_FormKarTarikh.Name = "txt_FormKarTarikh"
        Me.txt_FormKarTarikh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FormKarTarikh.Size = New System.Drawing.Size(169, 26)
        Me.txt_FormKarTarikh.SpellControl = Nothing
        Me.txt_FormKarTarikh.TabIndex = 1
        Me.txt_FormKarTarikh.TabStop = False
        Me.txt_FormKarTarikh.Tag = "BeginDAte"
        Me.txt_FormKarTarikh.Title = Nothing
        Me.txt_FormKarTarikh.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_FormKarTarikh.UseForData = True
        Me.txt_FormKarTarikh.ValidateCheckExistOnEdit = False
        Me.txt_FormKarTarikh.Value = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(445, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "از تاریخ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "تا تاریخ"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = True
        Me.TextBox1.Location = New System.Drawing.Point(29, 68)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(169, 26)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TabStop = False
        Me.TextBox1.Tag = "EndDate"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(144, 38)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(54, 22)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Tag = "Active"
        Me.CheckBox1.Text = "فعال"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Pm_WorkForm_Formula_ProfileTableAdapter
        '
        Me.Pm_WorkForm_Formula_ProfileTableAdapter.ClearBeforeFill = True
        '
        'Frm_WorkForm_Formul_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(570, 458)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_WorkForm_Formul_Profile"
        Me.TableName = "Pm_WorkForm_Formula_Profile"
        Me.Text = "پروفایل فرمول تردد"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmWorkFormFormulaProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_FromKarNo As CS_Component.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_FormKarTarikh As CS_Component.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmWorkFormFormulaProfileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_WorkForm_Formula_ProfileTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_WorkForm_Formula_ProfileTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ازتاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاتاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents فعالDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
