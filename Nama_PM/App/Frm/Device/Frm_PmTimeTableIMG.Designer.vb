<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PmTimeTableIMG
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
        Me.txt_File = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_Brows = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_Month = New VB_Component.ComboBox
        Me.cmb_Year = New VB_Component.ComboBox
        Me.cmb_SearchYear = New VB_Component.ComboBox
        Me.cmb_searchMonth = New VB_Component.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PmPmTimeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Pm_PmTimeTableTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PmTimeTableTableAdapter
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ماهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سالDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExtensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.file_Content = New System.Windows.Forms.DataGridViewImageColumn
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPmTimeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbx_GridViewList.Controls.Add(Me.cmb_SearchYear)
        Me.gbx_GridViewList.Controls.Add(Me.cmb_searchMonth)
        Me.gbx_GridViewList.Controls.Add(Me.Label4)
        Me.gbx_GridViewList.Controls.Add(Me.Label5)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(505, 416)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.cmb_Year)
        Me.gbx_Controls.Controls.Add(Me.cmb_Month)
        Me.gbx_Controls.Controls.Add(Me.btn_Brows)
        Me.gbx_Controls.Controls.Add(Me.txt_File)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 516)
        Me.gbx_Controls.Size = New System.Drawing.Size(505, 134)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 459)
        Me.gbx_Btn.Size = New System.Drawing.Size(505, 57)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.ماهDataGridViewTextBoxColumn, Me.سالDataGridViewTextBoxColumn, Me.ExtensionDataGridViewTextBoxColumn, Me.file_Content})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmPmTimeTableBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 67)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(499, 346)
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
        Me.txt_File.Location = New System.Drawing.Point(47, 67)
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
        Me.Label1.Location = New System.Drawing.Point(412, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "انتخاب فایل"
        '
        'btn_Brows
        '
        Me.btn_Brows.Location = New System.Drawing.Point(3, 68)
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
        Me.Label2.Location = New System.Drawing.Point(412, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ماه"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "سال"
        '
        'cmb_Month
        '
        Me.cmb_Month.AutoComplete = True
        Me.cmb_Month.DisplayMember = "سازندگان"
        Me.cmb_Month.EnterStop = True
        Me.cmb_Month.FormattingEnabled = True
        Me.cmb_Month.IsRequired = False
        Me.cmb_Month.Items.AddRange(New Object() {"", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"})
        Me.cmb_Month.LimitedToList = True
        Me.cmb_Month.Location = New System.Drawing.Point(263, 24)
        Me.cmb_Month.Name = "cmb_Month"
        Me.cmb_Month.OpenOnFoucus = True
        Me.cmb_Month.Size = New System.Drawing.Size(143, 26)
        Me.cmb_Month.TabIndex = 7
        Me.cmb_Month.Tag = "Month"
        Me.cmb_Month.ValueMember = "Srl"
        '
        'cmb_Year
        '
        Me.cmb_Year.AutoComplete = True
        Me.cmb_Year.DisplayMember = "سازندگان"
        Me.cmb_Year.EnterStop = True
        Me.cmb_Year.FormattingEnabled = True
        Me.cmb_Year.IsRequired = False
        Me.cmb_Year.Items.AddRange(New Object() {"", "1380", "1381", "1382", "1383", "1384", "1385", "1386", "1387", "1388", "1389", "1390", "1391", "1392", "1393", "1394", "1395", "1396", "1397", "1398", "1399", "1400"})
        Me.cmb_Year.LimitedToList = True
        Me.cmb_Year.Location = New System.Drawing.Point(50, 24)
        Me.cmb_Year.Name = "cmb_Year"
        Me.cmb_Year.OpenOnFoucus = True
        Me.cmb_Year.Size = New System.Drawing.Size(143, 26)
        Me.cmb_Year.TabIndex = 7
        Me.cmb_Year.Tag = "Year"
        Me.cmb_Year.ValueMember = "Srl"
        '
        'cmb_SearchYear
        '
        Me.cmb_SearchYear.AutoComplete = True
        Me.cmb_SearchYear.DisplayMember = "سازندگان"
        Me.cmb_SearchYear.EnterStop = True
        Me.cmb_SearchYear.FormattingEnabled = True
        Me.cmb_SearchYear.IsRequired = False
        Me.cmb_SearchYear.Items.AddRange(New Object() {"", "1380", "1381", "1382", "1383", "1384", "1385", "1386", "1387", "1388", "1389", "1390", "1391", "1392", "1393", "1394", "1395", "1396", "1397", "1398", "1399", "1400"})
        Me.cmb_SearchYear.LimitedToList = True
        Me.cmb_SearchYear.Location = New System.Drawing.Point(64, 24)
        Me.cmb_SearchYear.Name = "cmb_SearchYear"
        Me.cmb_SearchYear.OpenOnFoucus = True
        Me.cmb_SearchYear.Size = New System.Drawing.Size(143, 26)
        Me.cmb_SearchYear.TabIndex = 10
        Me.cmb_SearchYear.Tag = "Year"
        Me.cmb_SearchYear.ValueMember = "Srl"
        '
        'cmb_searchMonth
        '
        Me.cmb_searchMonth.AutoComplete = True
        Me.cmb_searchMonth.DisplayMember = "سازندگان"
        Me.cmb_searchMonth.EnterStop = True
        Me.cmb_searchMonth.FormattingEnabled = True
        Me.cmb_searchMonth.IsRequired = False
        Me.cmb_searchMonth.Items.AddRange(New Object() {"", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"})
        Me.cmb_searchMonth.LimitedToList = True
        Me.cmb_searchMonth.Location = New System.Drawing.Point(277, 24)
        Me.cmb_searchMonth.Name = "cmb_searchMonth"
        Me.cmb_searchMonth.OpenOnFoucus = True
        Me.cmb_searchMonth.Size = New System.Drawing.Size(143, 26)
        Me.cmb_searchMonth.TabIndex = 11
        Me.cmb_searchMonth.Tag = "Month"
        Me.cmb_searchMonth.ValueMember = "Srl"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "سال"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(426, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ماه"
        '
        'PmPmTimeTableBindingSource
        '
        Me.PmPmTimeTableBindingSource.DataMember = "Pm_PmTimeTable"
        Me.PmPmTimeTableBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_PmTimeTableTableAdapter
        '
        Me.Pm_PmTimeTableTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'ماهDataGridViewTextBoxColumn
        '
        Me.ماهDataGridViewTextBoxColumn.DataPropertyName = "ماه"
        Me.ماهDataGridViewTextBoxColumn.HeaderText = "ماه"
        Me.ماهDataGridViewTextBoxColumn.Name = "ماهDataGridViewTextBoxColumn"
        Me.ماهDataGridViewTextBoxColumn.Width = 120
        '
        'سالDataGridViewTextBoxColumn
        '
        Me.سالDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.سالDataGridViewTextBoxColumn.DataPropertyName = "سال"
        Me.سالDataGridViewTextBoxColumn.HeaderText = "سال"
        Me.سالDataGridViewTextBoxColumn.Name = "سالDataGridViewTextBoxColumn"
        Me.سالDataGridViewTextBoxColumn.Width = 120
        '
        'ExtensionDataGridViewTextBoxColumn
        '
        Me.ExtensionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ExtensionDataGridViewTextBoxColumn.DataPropertyName = "Extension"
        Me.ExtensionDataGridViewTextBoxColumn.HeaderText = "پسوند فایل"
        Me.ExtensionDataGridViewTextBoxColumn.Name = "ExtensionDataGridViewTextBoxColumn"
        '
        'file_Content
        '
        Me.file_Content.DataPropertyName = "file_Content"
        Me.file_Content.HeaderText = "file_Content"
        Me.file_Content.Name = "file_Content"
        Me.file_Content.Visible = False
        '
        'Frm_PmTimeTableIMG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(532, 682)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_PmTimeTableIMG"
        Me.StatusStrip1 = Nothing
        Me.TableName = "Pm_PmTimeTable"
        Me.Text = "وارد کردن فایل برنامه ریزی پی ام"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPmTimeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Month As VB_Component.ComboBox
    Friend WithEvents cmb_Year As VB_Component.ComboBox
    Friend WithEvents cmb_SearchYear As VB_Component.ComboBox
    Friend WithEvents cmb_searchMonth As VB_Component.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PmPmTimeTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_PmTimeTableTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PmTimeTableTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ماهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سالDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExtensionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents file_Content As System.Windows.Forms.DataGridViewImageColumn
End Class
