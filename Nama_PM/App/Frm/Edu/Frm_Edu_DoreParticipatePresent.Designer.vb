<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Edu_DoreParticipatePresent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Edu_DoreParticipatePresent))
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlDoreParticipateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.زمانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.توضیحاتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmEduDoreParticipatePresentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Edu = New Nama_PM.Ds_Edu
        Me.TextBox3 = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pm_Edu_DoreParticipatePresentTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreParticipatePresentTableAdapter
        Me.txt_Date = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New CS_Component.TextBox
        Me.btn_Before = New System.Windows.Forms.PictureBox
        Me.btn_Next = New System.Windows.Forms.PictureBox
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDoreParticipatePresentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(138, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "F2 اضافه کردن"
        Me.btn_new.Location = New System.Drawing.Point(387, 18)
        Me.btn_new.Size = New System.Drawing.Size(135, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(262, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.btn_Before)
        Me.gbx_GridViewList.Controls.Add(Me.btn_Next)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(528, 197)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.txt_Date)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.TextBox3)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 300)
        Me.gbx_Controls.Size = New System.Drawing.Size(528, 108)
        Me.gbx_Controls.TabIndex = 1
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 243)
        Me.gbx_Btn.Size = New System.Drawing.Size(528, 60)
        Me.gbx_Btn.TabIndex = 0
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.SrlDoreParticipateDataGridViewTextBoxColumn, Me.تاریخDataGridViewTextBoxColumn, Me.زمانDataGridViewTextBoxColumn, Me.توضیحاتDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmEduDoreParticipatePresentBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 51)
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
        Me.DataGridView1.Size = New System.Drawing.Size(522, 143)
        Me.DataGridView1.TabIndex = 0
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'SrlDoreParticipateDataGridViewTextBoxColumn
        '
        Me.SrlDoreParticipateDataGridViewTextBoxColumn.DataPropertyName = "Srl_Dore_Participate"
        Me.SrlDoreParticipateDataGridViewTextBoxColumn.HeaderText = "Srl_Dore_Participate"
        Me.SrlDoreParticipateDataGridViewTextBoxColumn.Name = "SrlDoreParticipateDataGridViewTextBoxColumn"
        Me.SrlDoreParticipateDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDoreParticipateDataGridViewTextBoxColumn.Visible = False
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        Me.تاریخDataGridViewTextBoxColumn.ReadOnly = True
        Me.تاریخDataGridViewTextBoxColumn.Width = 120
        '
        'زمانDataGridViewTextBoxColumn
        '
        Me.زمانDataGridViewTextBoxColumn.DataPropertyName = "زمان"
        Me.زمانDataGridViewTextBoxColumn.HeaderText = "زمان"
        Me.زمانDataGridViewTextBoxColumn.Name = "زمانDataGridViewTextBoxColumn"
        Me.زمانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'توضیحاتDataGridViewTextBoxColumn
        '
        Me.توضیحاتDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.توضیحاتDataGridViewTextBoxColumn.DataPropertyName = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.HeaderText = "توضیحات"
        Me.توضیحاتDataGridViewTextBoxColumn.Name = "توضیحاتDataGridViewTextBoxColumn"
        Me.توضیحاتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmEduDoreParticipatePresentBindingSource
        '
        Me.PmEduDoreParticipatePresentBindingSource.DataMember = "Pm_Edu_DoreParticipatePresent"
        Me.PmEduDoreParticipatePresentBindingSource.DataSource = Me.Ds_Edu
        '
        'Ds_Edu
        '
        Me.Ds_Edu.DataSetName = "Ds_Edu"
        Me.Ds_Edu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox3
        '
        Me.TextBox3.CheckExistValueInDb = True
        Me.TextBox3.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox3.CurrencyUnit = "ریال"
        Me.TextBox3.DefaultValue = ""
        Me.TextBox3.FillWithMaxInDb = False
        Me.TextBox3.IsRequired = False
        Me.TextBox3.Location = New System.Drawing.Point(80, 25)
        Me.TextBox3.MaxDecimalLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(71, 26)
        Me.TextBox3.SpellControl = Nothing
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Tag = "PresentTime"
        Me.TextBox3.Title = Nothing
        Me.TextBox3.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.TextBox3.UseForData = True
        Me.TextBox3.ValidateCheckExistOnEdit = False
        Me.TextBox3.Value = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "دقیقه"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "مدت شرکت:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(462, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(36, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "تاریخ"
        '
        'Pm_Edu_DoreParticipatePresentTableAdapter
        '
        Me.Pm_Edu_DoreParticipatePresentTableAdapter.ClearBeforeFill = True
        '
        'txt_Date
        '
        Me.txt_Date.CheckExistValueInDb = False
        Me.txt_Date.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Date.CurrencyUnit = "ریال"
        Me.txt_Date.DefaultValue = ""
        Me.txt_Date.FillWithMaxInDb = False
        Me.txt_Date.IsRequired = True
        Me.txt_Date.Location = New System.Drawing.Point(295, 25)
        Me.txt_Date.MaxDecimalLength = 2
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Date.Size = New System.Drawing.Size(132, 26)
        Me.txt_Date.SpellControl = Nothing
        Me.txt_Date.TabIndex = 0
        Me.txt_Date.TabStop = False
        Me.txt_Date.Tag = "Tarikh"
        Me.txt_Date.Title = Nothing
        Me.txt_Date.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_Date.UseForData = True
        Me.txt_Date.ValidateCheckExistOnEdit = False
        Me.txt_Date.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(436, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "توضیحات"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = True
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(31, 66)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(396, 26)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Tag = "Description"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'btn_Before
        '
        Me.btn_Before.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Before.Image = CType(resources.GetObject("btn_Before.Image"), System.Drawing.Image)
        Me.btn_Before.Location = New System.Drawing.Point(48, 16)
        Me.btn_Before.Name = "btn_Before"
        Me.btn_Before.Size = New System.Drawing.Size(30, 29)
        Me.btn_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Before.TabIndex = 14
        Me.btn_Before.TabStop = False
        '
        'btn_Next
        '
        Me.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next.Image = CType(resources.GetObject("btn_Next.Image"), System.Drawing.Image)
        Me.btn_Next.Location = New System.Drawing.Point(10, 17)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(32, 28)
        Me.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Next.TabIndex = 13
        Me.btn_Next.TabStop = False
        '
        'Frm_Edu_DoreParticipatePresent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(556, 447)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Edu_DoreParticipatePresent"
        Me.TableName = "Pm_Edu_DoreParticipatePresent"
        Me.Text = "ثبت روزهای حضور"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDoreParticipatePresentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents TextBox3 As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlDoreParticipateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents زمانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmEduDoreParticipatePresentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Edu As Nama_PM.Ds_Edu
    Friend WithEvents Pm_Edu_DoreParticipatePresentTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreParticipatePresentTableAdapter
    Friend WithEvents txt_Date As CS_Component.TextBox
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Before As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Next As System.Windows.Forms.PictureBox
End Class
