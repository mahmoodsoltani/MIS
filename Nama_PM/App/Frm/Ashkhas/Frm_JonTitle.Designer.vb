<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_JobTitle
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
        Me.txt_Name = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.PmEduJobTitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Edu = New Nama_PM.Ds_Edu
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_code = New CS_Component.TextBox
        Me.Pm_Edu_JobTitleTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_JobTitleTableAdapter
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عنوانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عضوتوانیرDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduJobTitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(6, 18)
        Me.btn_Cancel.Size = New System.Drawing.Size(98, 28)
        Me.btn_Cancel.Visible = False
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(254, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(78, 28)
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "ذخيره"
        Me.btn_new.Location = New System.Drawing.Point(431, 18)
        Me.btn_new.Size = New System.Drawing.Size(81, 28)
        '
        'btn_Edit
        '
        Me.btn_Edit.HeaderText = " ویرایش"
        Me.btn_Edit.Location = New System.Drawing.Point(338, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(87, 28)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(531, 225)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Controls.Controls.Add(Me.CheckBox1)
        Me.gbx_Controls.Controls.Add(Me.txt_code)
        Me.gbx_Controls.Controls.Add(Me.txt_Name)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(12, 314)
        Me.gbx_Controls.Size = New System.Drawing.Size(531, 97)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Btn.Location = New System.Drawing.Point(12, 261)
        Me.gbx_Btn.Size = New System.Drawing.Size(531, 53)
        '
        'txt_Name
        '
        Me.txt_Name.CheckExistValueInDb = True
        Me.txt_Name.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Name.CurrencyUnit = "ریال"
        Me.txt_Name.DefaultValue = ""
        Me.txt_Name.FillWithMaxInDb = False
        Me.txt_Name.IsRequired = True
        Me.txt_Name.Location = New System.Drawing.Point(6, 22)
        Me.txt_Name.MaxDecimalLength = 2
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Name.Size = New System.Drawing.Size(266, 23)
        Me.txt_Name.SpellControl = Nothing
        Me.txt_Name.TabIndex = 1
        Me.txt_Name.Tag = "name"
        Me.txt_Name.Title = Nothing
        Me.txt_Name.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Name.UseForData = True
        Me.txt_Name.ValidateCheckExistOnEdit = True
        Me.txt_Name.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "عنوان شغلی"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.کدDataGridViewTextBoxColumn, Me.عنوانDataGridViewTextBoxColumn, Me.عضوتوانیرDataGridViewCheckBoxColumn, Me.Column1})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmEduJobTitleBindingSource
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
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(525, 203)
        Me.DataGridView1.TabIndex = 0
        '
        'PmEduJobTitleBindingSource
        '
        Me.PmEduJobTitleBindingSource.DataMember = "Pm_Edu_JobTitle"
        Me.PmEduJobTitleBindingSource.DataSource = Me.Ds_Edu
        '
        'Ds_Edu
        '
        Me.Ds_Edu.DataSetName = "Ds_Edu"
        Me.Ds_Edu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(443, 53)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 20)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Tag = "Is_Tavanir"
        Me.CheckBox1.Text = "عضو توانیر"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(434, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "کد عنوان شغلی"
        '
        'txt_code
        '
        Me.txt_code.CheckExistValueInDb = True
        Me.txt_code.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_code.CurrencyUnit = "ریال"
        Me.txt_code.DefaultValue = ""
        Me.txt_code.FillWithMaxInDb = False
        Me.txt_code.IsRequired = True
        Me.txt_code.Location = New System.Drawing.Point(362, 22)
        Me.txt_code.MaxDecimalLength = 2
        Me.txt_code.Name = "txt_code"
        Me.txt_code.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_code.Size = New System.Drawing.Size(69, 23)
        Me.txt_code.SpellControl = Nothing
        Me.txt_code.TabIndex = 2
        Me.txt_code.Tag = "code"
        Me.txt_code.Title = Nothing
        Me.txt_code.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_code.UseForData = True
        Me.txt_code.ValidateCheckExistOnEdit = False
        Me.txt_code.Value = ""
        '
        'Pm_Edu_JobTitleTableAdapter
        '
        Me.Pm_Edu_JobTitleTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
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
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        Me.عنوانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'عضوتوانیرDataGridViewCheckBoxColumn
        '
        Me.عضوتوانیرDataGridViewCheckBoxColumn.DataPropertyName = "عضو توانیر"
        Me.عضوتوانیرDataGridViewCheckBoxColumn.HeaderText = "عضو توانیر"
        Me.عضوتوانیرDataGridViewCheckBoxColumn.Name = "عضوتوانیرDataGridViewCheckBoxColumn"
        Me.عضوتوانیرDataGridViewCheckBoxColumn.ReadOnly = True
        Me.عضوتوانیرDataGridViewCheckBoxColumn.Width = 70
        '
        'Column1
        '
        Me.Column1.HeaderText = "..."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 25
        '
        'Frm_JobTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 447)
        Me.DataGridView = Me.DataGridView1
        Me.Name = "Frm_JobTitle"
        Me.TableName = "Pm_Edu_JobTitle"
        Me.Text = "عناوین شغلی"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduJobTitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Name As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_code As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ds_Edu As Nama_PM.Ds_Edu
    Friend WithEvents PmEduJobTitleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_JobTitleTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_JobTitleTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عضوتوانیرDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
End Class
