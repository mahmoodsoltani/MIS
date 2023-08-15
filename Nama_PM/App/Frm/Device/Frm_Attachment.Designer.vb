<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Attachment
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
        Me.txt_File = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_Brows = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Name = New CS_Component.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New CS_Component.TextBox
        Me.PmDeviceAttachmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Pm_DeviceAttachmentTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_DeviceAttachmentTableAdapter
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.توضیحاتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FileContentDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
        Me.extension = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmDeviceAttachmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_Delete.Location = New System.Drawing.Point(135, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(86, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(394, 18)
        Me.btn_new.Size = New System.Drawing.Size(105, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.HeaderText = "دریافت و مشاهده"
        Me.btn_Edit.Location = New System.Drawing.Point(227, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(161, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(505, 332)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.btn_Brows)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.txt_Name)
        Me.gbx_Controls.Controls.Add(Me.txt_File)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 432)
        Me.gbx_Controls.Size = New System.Drawing.Size(505, 134)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 375)
        Me.gbx_Btn.Size = New System.Drawing.Size(505, 57)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.نامDataGridViewTextBoxColumn, Me.توضیحاتDataGridViewTextBoxColumn, Me.FileContentDataGridViewImageColumn, Me.extension})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmDeviceAttachmentBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 21)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(499, 308)
        Me.DataGridView1.TabIndex = 3
        '
        'txt_File
        '
        Me.txt_File.CheckExistValueInDb = True
        Me.txt_File.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_File.CurrencyUnit = "ریال"
        Me.txt_File.DefaultValue = ""
        Me.txt_File.FillWithMaxInDb = False
        Me.txt_File.IsRequired = False
        Me.txt_File.Location = New System.Drawing.Point(51, 17)
        Me.txt_File.MaxDecimalLength = 2
        Me.txt_File.Name = "txt_File"
        Me.txt_File.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_File.Size = New System.Drawing.Size(359, 25)
        Me.txt_File.SpellControl = Nothing
        Me.txt_File.TabIndex = 0
        Me.txt_File.Tag = ""
        Me.txt_File.Title = Nothing
        Me.txt_File.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_File.UseForData = True
        Me.txt_File.ValidateCheckExistOnEdit = False
        Me.txt_File.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(416, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "انتخاب فایل"
        '
        'btn_Brows
        '
        Me.btn_Brows.Location = New System.Drawing.Point(7, 18)
        Me.btn_Brows.Name = "btn_Brows"
        Me.btn_Brows.Size = New System.Drawing.Size(39, 25)
        Me.btn_Brows.TabIndex = 1
        Me.btn_Brows.Text = "..."
        Me.btn_Brows.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "نام"
        '
        'txt_Name
        '
        Me.txt_Name.CheckExistValueInDb = True
        Me.txt_Name.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Name.CurrencyUnit = "ریال"
        Me.txt_Name.DefaultValue = ""
        Me.txt_Name.FillWithMaxInDb = False
        Me.txt_Name.IsRequired = False
        Me.txt_Name.Location = New System.Drawing.Point(215, 48)
        Me.txt_Name.MaxDecimalLength = 2
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Name.Size = New System.Drawing.Size(195, 25)
        Me.txt_Name.SpellControl = Nothing
        Me.txt_Name.TabIndex = 2
        Me.txt_Name.Tag = "Name"
        Me.txt_Name.Title = Nothing
        Me.txt_Name.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Name.UseForData = True
        Me.txt_Name.ValidateCheckExistOnEdit = False
        Me.txt_Name.Value = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(416, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "توضیحات"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = True
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(7, 77)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(403, 51)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Tag = "Description"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'PmDeviceAttachmentBindingSource
        '
        Me.PmDeviceAttachmentBindingSource.DataMember = "Pm_DeviceAttachment"
        Me.PmDeviceAttachmentBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_DeviceAttachmentTableAdapter
        '
        Me.Pm_DeviceAttachmentTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'نامDataGridViewTextBoxColumn
        '
        Me.نامDataGridViewTextBoxColumn.DataPropertyName = "نام"
        Me.نامDataGridViewTextBoxColumn.HeaderText = "نام"
        Me.نامDataGridViewTextBoxColumn.Name = "نامDataGridViewTextBoxColumn"
        Me.نامDataGridViewTextBoxColumn.Width = 200
        '
        'توضیحاتDataGridViewTextBoxColumn
        '
        Me.توضیحاتDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.توضیحاتDataGridViewTextBoxColumn.DataPropertyName = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.Name = "توضیحاتDataGridViewTextBoxColumn"
        '
        'FileContentDataGridViewImageColumn
        '
        Me.FileContentDataGridViewImageColumn.DataPropertyName = "File_Content"
        Me.FileContentDataGridViewImageColumn.HeaderText = "File_Content"
        Me.FileContentDataGridViewImageColumn.Name = "FileContentDataGridViewImageColumn"
        Me.FileContentDataGridViewImageColumn.Visible = False
        '
        'extension
        '
        Me.extension.DataPropertyName = "extension"
        Me.extension.HeaderText = "extension"
        Me.extension.Name = "extension"
        Me.extension.Visible = False
        '
        'Frm_Attachment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(532, 598)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Attachment"
        Me.StatusStrip1 = Nothing
        Me.TableName = "pm_DeviceAttachment"
        Me.Text = "اضافه کردن مدارک"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmDeviceAttachmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents txt_File As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NameOffile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Brows As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_Name As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PmDeviceAttachmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Pm_DeviceAttachmentTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_DeviceAttachmentTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileContentDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents extension As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
