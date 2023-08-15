<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pm_Company
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
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.txt_Name = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شرکتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_CompanyTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Pm_CompanyTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_Delete.Location = New System.Drawing.Point(223, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(78, 28)
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "ذخيره"
        Me.btn_new.Location = New System.Drawing.Point(400, 18)
        Me.btn_new.Size = New System.Drawing.Size(81, 28)
        '
        'btn_Edit
        '
        Me.btn_Edit.HeaderText = " ویرایش"
        Me.btn_Edit.Location = New System.Drawing.Point(307, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(87, 28)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(500, 229)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Controls.Controls.Add(Me.txt_Name)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(12, 307)
        Me.gbx_Controls.Size = New System.Drawing.Size(500, 70)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbx_Btn.Location = New System.Drawing.Point(12, 257)
        Me.gbx_Btn.Size = New System.Drawing.Size(500, 53)
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_Name
        '
        Me.txt_Name.CheckExistValueInDb = False
        Me.txt_Name.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Name.CurrencyUnit = "ریال"
        Me.txt_Name.DefaultValue = ""
        Me.txt_Name.FillWithMaxInDb = False
        Me.txt_Name.IsRequired = False
        Me.txt_Name.Location = New System.Drawing.Point(235, 25)
        Me.txt_Name.MaxDecimalLength = 2
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Name.Size = New System.Drawing.Size(168, 23)
        Me.txt_Name.SpellControl = Nothing
        Me.txt_Name.TabIndex = 9
        Me.txt_Name.Tag = "Company"
        Me.txt_Name.Title = Nothing
        Me.txt_Name.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Name.UseForData = True
        Me.txt_Name.ValidateCheckExistOnEdit = False
        Me.txt_Name.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(413, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "نام شرکت"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.کدDataGridViewTextBoxColumn, Me.شرکتDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmCompanyBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(6, 13)
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
        Me.DataGridView1.Size = New System.Drawing.Size(488, 210)
        Me.DataGridView1.TabIndex = 0
        '
        'کدDataGridViewTextBoxColumn
        '
        Me.کدDataGridViewTextBoxColumn.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn.Name = "کدDataGridViewTextBoxColumn"
        Me.کدDataGridViewTextBoxColumn.ReadOnly = True
        Me.کدDataGridViewTextBoxColumn.Visible = False
        '
        'شرکتDataGridViewTextBoxColumn
        '
        Me.شرکتDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.شرکتDataGridViewTextBoxColumn.DataPropertyName = "شرکت"
        Me.شرکتDataGridViewTextBoxColumn.HeaderText = "شرکت"
        Me.شرکتDataGridViewTextBoxColumn.Name = "شرکتDataGridViewTextBoxColumn"
        Me.شرکتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmCompanyBindingSource
        '
        Me.PmCompanyBindingSource.DataMember = "Pm_Company"
        Me.PmCompanyBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'Pm_CompanyTableAdapter
        '
        Me.Pm_CompanyTableAdapter.ClearBeforeFill = True
        '
        'Frm_Pm_Company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 413)
        Me.DataGridView = Me.DataGridView1
        Me.Name = "Frm_Pm_Company"
        Me.TableName = "Pm_Company"
        Me.Text = "شرکت ها"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Name As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents PmCompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_CompanyTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Pm_CompanyTableAdapter
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شرکتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
