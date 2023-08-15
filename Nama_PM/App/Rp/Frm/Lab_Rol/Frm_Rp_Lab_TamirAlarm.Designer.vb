<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_Lab_TamirAlarm
    Inherits BaseForm

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
        Me.rbtn_TahvilBound = New System.Windows.Forms.RadioButton
        Me.rbtn_TamirEmpty = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_Edit = New System.Windows.Forms.Button
        Me.btn_Search = New System.Windows.Forms.Button
        Me.rbtn_TahvilEmpty = New System.Windows.Forms.RadioButton
        Me.rbtn_TAmirBound = New System.Windows.Forms.RadioButton
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامقطعهDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پستDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سطحاهمیتDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.علتورودDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخورودDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.بازهتعمیرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریختعمیرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.بازهتحویلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریختحویلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmLabRolTamiratViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامقطعهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سطحاهمیتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.علتورودDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخثبتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Pm_Lab_Rol_TamiratViewTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TamiratViewTableAdapter
        Me.btn_Report = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolTamiratViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtn_TahvilBound
        '
        Me.rbtn_TahvilBound.AutoSize = True
        Me.rbtn_TahvilBound.Location = New System.Drawing.Point(577, 41)
        Me.rbtn_TahvilBound.Name = "rbtn_TahvilBound"
        Me.rbtn_TahvilBound.Size = New System.Drawing.Size(287, 22)
        Me.rbtn_TahvilBound.TabIndex = 6
        Me.rbtn_TahvilBound.TabStop = True
        Me.rbtn_TahvilBound.Text = "فرم هایی که بازه زمانی تحویل آنها گذشته"
        Me.rbtn_TahvilBound.UseVisualStyleBackColor = True
        '
        'rbtn_TamirEmpty
        '
        Me.rbtn_TamirEmpty.AutoSize = True
        Me.rbtn_TamirEmpty.Location = New System.Drawing.Point(384, 10)
        Me.rbtn_TamirEmpty.Name = "rbtn_TamirEmpty"
        Me.rbtn_TamirEmpty.Size = New System.Drawing.Size(173, 22)
        Me.rbtn_TamirEmpty.TabIndex = 7
        Me.rbtn_TamirEmpty.TabStop = True
        Me.rbtn_TamirEmpty.Text = "فرمهای بدون تاریخ تعمیر"
        Me.rbtn_TamirEmpty.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_Report)
        Me.Panel2.Controls.Add(Me.btn_Edit)
        Me.Panel2.Controls.Add(Me.btn_Search)
        Me.Panel2.Controls.Add(Me.rbtn_TahvilEmpty)
        Me.Panel2.Controls.Add(Me.rbtn_TamirEmpty)
        Me.Panel2.Controls.Add(Me.rbtn_TAmirBound)
        Me.Panel2.Controls.Add(Me.rbtn_TahvilBound)
        Me.Panel2.Location = New System.Drawing.Point(9, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1015, 82)
        Me.Panel2.TabIndex = 9
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(16, 41)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(101, 27)
        Me.btn_Edit.TabIndex = 11
        Me.btn_Edit.Text = "ویرایش"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_Search
        '
        Me.btn_Search.Location = New System.Drawing.Point(16, 8)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(101, 27)
        Me.btn_Search.TabIndex = 8
        Me.btn_Search.Text = "جستجو"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'rbtn_TahvilEmpty
        '
        Me.rbtn_TahvilEmpty.AutoSize = True
        Me.rbtn_TahvilEmpty.Location = New System.Drawing.Point(379, 41)
        Me.rbtn_TahvilEmpty.Name = "rbtn_TahvilEmpty"
        Me.rbtn_TahvilEmpty.Size = New System.Drawing.Size(178, 22)
        Me.rbtn_TahvilEmpty.TabIndex = 7
        Me.rbtn_TahvilEmpty.TabStop = True
        Me.rbtn_TahvilEmpty.Text = "فرمهای بدون تاریخ تحویل"
        Me.rbtn_TahvilEmpty.UseVisualStyleBackColor = True
        '
        'rbtn_TAmirBound
        '
        Me.rbtn_TAmirBound.AutoSize = True
        Me.rbtn_TAmirBound.Location = New System.Drawing.Point(582, 13)
        Me.rbtn_TAmirBound.Name = "rbtn_TAmirBound"
        Me.rbtn_TAmirBound.Size = New System.Drawing.Size(282, 22)
        Me.rbtn_TAmirBound.TabIndex = 6
        Me.rbtn_TAmirBound.TabStop = True
        Me.rbtn_TAmirBound.Text = "فرم هایی که بازه زمانی تعمیر آنها گذشته"
        Me.rbtn_TAmirBound.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn1, Me.شمارهDataGridViewTextBoxColumn1, Me.نامقطعهDataGridViewTextBoxColumn1, Me.پستDataGridViewTextBoxColumn1, Me.سطحاهمیتDataGridViewTextBoxColumn1, Me.علتورودDataGridViewTextBoxColumn1, Me.تاریخورودDataGridViewTextBoxColumn, Me.بازهتعمیرDataGridViewTextBoxColumn, Me.تاریختعمیرDataGridViewTextBoxColumn, Me.بازهتحویلDataGridViewTextBoxColumn, Me.تاریختحویلDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmLabRolTamiratViewBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(6, 130)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1018, 406)
        Me.DataGridView1.TabIndex = 10
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn1.Visible = False
        '
        'شمارهDataGridViewTextBoxColumn1
        '
        Me.شمارهDataGridViewTextBoxColumn1.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn1.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn1.Name = "شمارهDataGridViewTextBoxColumn1"
        Me.شمارهDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'نامقطعهDataGridViewTextBoxColumn1
        '
        Me.نامقطعهDataGridViewTextBoxColumn1.DataPropertyName = "نام قطعه"
        Me.نامقطعهDataGridViewTextBoxColumn1.HeaderText = "نام قطعه"
        Me.نامقطعهDataGridViewTextBoxColumn1.Name = "نامقطعهDataGridViewTextBoxColumn1"
        Me.نامقطعهDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'پستDataGridViewTextBoxColumn1
        '
        Me.پستDataGridViewTextBoxColumn1.DataPropertyName = "پست"
        Me.پستDataGridViewTextBoxColumn1.HeaderText = "پست"
        Me.پستDataGridViewTextBoxColumn1.Name = "پستDataGridViewTextBoxColumn1"
        Me.پستDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'سطحاهمیتDataGridViewTextBoxColumn1
        '
        Me.سطحاهمیتDataGridViewTextBoxColumn1.DataPropertyName = "سطح اهمیت"
        Me.سطحاهمیتDataGridViewTextBoxColumn1.HeaderText = "سطح اهمیت"
        Me.سطحاهمیتDataGridViewTextBoxColumn1.Name = "سطحاهمیتDataGridViewTextBoxColumn1"
        Me.سطحاهمیتDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'علتورودDataGridViewTextBoxColumn1
        '
        Me.علتورودDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.علتورودDataGridViewTextBoxColumn1.DataPropertyName = "علت ورود"
        Me.علتورودDataGridViewTextBoxColumn1.HeaderText = "علت ورود"
        Me.علتورودDataGridViewTextBoxColumn1.Name = "علتورودDataGridViewTextBoxColumn1"
        Me.علتورودDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'تاریخورودDataGridViewTextBoxColumn
        '
        Me.تاریخورودDataGridViewTextBoxColumn.DataPropertyName = "تاریخ ورود"
        Me.تاریخورودDataGridViewTextBoxColumn.HeaderText = "تاریخ ورود"
        Me.تاریخورودDataGridViewTextBoxColumn.Name = "تاریخورودDataGridViewTextBoxColumn"
        Me.تاریخورودDataGridViewTextBoxColumn.ReadOnly = True
        '
        'بازهتعمیرDataGridViewTextBoxColumn
        '
        Me.بازهتعمیرDataGridViewTextBoxColumn.DataPropertyName = "بازه تعمیر"
        Me.بازهتعمیرDataGridViewTextBoxColumn.HeaderText = "بازه تعمیر"
        Me.بازهتعمیرDataGridViewTextBoxColumn.Name = "بازهتعمیرDataGridViewTextBoxColumn"
        Me.بازهتعمیرDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریختعمیرDataGridViewTextBoxColumn
        '
        Me.تاریختعمیرDataGridViewTextBoxColumn.DataPropertyName = "تاریخ تعمیر"
        Me.تاریختعمیرDataGridViewTextBoxColumn.HeaderText = "تاریخ تعمیر"
        Me.تاریختعمیرDataGridViewTextBoxColumn.Name = "تاریختعمیرDataGridViewTextBoxColumn"
        Me.تاریختعمیرDataGridViewTextBoxColumn.ReadOnly = True
        '
        'بازهتحویلDataGridViewTextBoxColumn
        '
        Me.بازهتحویلDataGridViewTextBoxColumn.DataPropertyName = "بازه تحویل"
        Me.بازهتحویلDataGridViewTextBoxColumn.HeaderText = "بازه تحویل"
        Me.بازهتحویلDataGridViewTextBoxColumn.Name = "بازهتحویلDataGridViewTextBoxColumn"
        Me.بازهتحویلDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریختحویلDataGridViewTextBoxColumn
        '
        Me.تاریختحویلDataGridViewTextBoxColumn.DataPropertyName = "تاریخ تحویل"
        Me.تاریختحویلDataGridViewTextBoxColumn.HeaderText = "تاریخ تحویل"
        Me.تاریختحویلDataGridViewTextBoxColumn.Name = "تاریختحویلDataGridViewTextBoxColumn"
        Me.تاریختحویلDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmLabRolTamiratViewBindingSource
        '
        Me.PmLabRolTamiratViewBindingSource.DataMember = "Pm_Lab_Rol_TamiratView"
        Me.PmLabRolTamiratViewBindingSource.DataSource = Me.Ds_Lab
        '
        'Ds_Lab
        '
        Me.Ds_Lab.DataSetName = "Ds_Lab"
        Me.Ds_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامقطعهDataGridViewTextBoxColumn
        '
        Me.نامقطعهDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.نامقطعهDataGridViewTextBoxColumn.DataPropertyName = "نام قطعه"
        Me.نامقطعهDataGridViewTextBoxColumn.HeaderText = "نام قطعه"
        Me.نامقطعهDataGridViewTextBoxColumn.Name = "نامقطعهDataGridViewTextBoxColumn"
        Me.نامقطعهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'پستDataGridViewTextBoxColumn
        '
        Me.پستDataGridViewTextBoxColumn.DataPropertyName = "پست"
        Me.پستDataGridViewTextBoxColumn.HeaderText = "پست"
        Me.پستDataGridViewTextBoxColumn.Name = "پستDataGridViewTextBoxColumn"
        Me.پستDataGridViewTextBoxColumn.ReadOnly = True
        '
        'سطحاهمیتDataGridViewTextBoxColumn
        '
        Me.سطحاهمیتDataGridViewTextBoxColumn.DataPropertyName = "سطح اهمیت"
        Me.سطحاهمیتDataGridViewTextBoxColumn.HeaderText = "سطح اهمیت"
        Me.سطحاهمیتDataGridViewTextBoxColumn.Name = "سطحاهمیتDataGridViewTextBoxColumn"
        Me.سطحاهمیتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'علتورودDataGridViewTextBoxColumn
        '
        Me.علتورودDataGridViewTextBoxColumn.DataPropertyName = "علت ورود"
        Me.علتورودDataGridViewTextBoxColumn.HeaderText = "علت ورود"
        Me.علتورودDataGridViewTextBoxColumn.Name = "علتورودDataGridViewTextBoxColumn"
        Me.علتورودDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخثبتDataGridViewTextBoxColumn
        '
        Me.تاریخثبتDataGridViewTextBoxColumn.DataPropertyName = "تاریخ ثبت"
        Me.تاریخثبتDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت"
        Me.تاریخثبتDataGridViewTextBoxColumn.Name = "تاریخثبتDataGridViewTextBoxColumn"
        Me.تاریخثبتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "تاریخ تعمیر"
        Me.DataGridViewTextBoxColumn1.HeaderText = "تاریخ تعمیر"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Pm_Lab_Rol_TamiratViewTableAdapter
        '
        Me.Pm_Lab_Rol_TamiratViewTableAdapter.ClearBeforeFill = True
        '
        'btn_Report
        '
        Me.btn_Report.Location = New System.Drawing.Point(123, 41)
        Me.btn_Report.Name = "btn_Report"
        Me.btn_Report.Size = New System.Drawing.Size(101, 27)
        Me.btn_Report.TabIndex = 12
        Me.btn_Report.Text = "چاپ"
        Me.btn_Report.UseVisualStyleBackColor = True
        '
        'Frm_Rp_Lab_TamirAlarm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1034, 565)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Rp_Lab_TamirAlarm"
        Me.Text = "گزارش هشدار تعمیر"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolTamiratViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtn_TahvilBound As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_TamirEmpty As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents rbtn_TAmirBound As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_TahvilEmpty As System.Windows.Forms.RadioButton
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامقطعهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سطحاهمیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents علتورودDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخثبتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents PmLabRolTamiratViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_TamiratViewTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TamiratViewTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامقطعهDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پستDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سطحاهمیتDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents علتورودDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخورودDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents بازهتعمیرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریختعمیرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents بازهتحویلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریختحویلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Report As System.Windows.Forms.Button
End Class
