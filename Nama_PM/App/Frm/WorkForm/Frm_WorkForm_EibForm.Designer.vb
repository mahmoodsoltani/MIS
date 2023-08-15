<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_WorkForm_EibForm
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
        Me.شمارهفرمنقصDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخفرمنقصDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmWorkFormEibFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_FormeNaghs = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_TarikhNaghs = New CS_Component.TextBox
        Me.Pm_WorkForm_EibFormTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_WorkForm_EibFormTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmWorkFormEibFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_Delete.Location = New System.Drawing.Point(193, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(440, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Enabled = False
        Me.btn_Edit.Location = New System.Drawing.Point(316, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(563, 352)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.txt_TarikhNaghs)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.txt_FormeNaghs)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 453)
        Me.gbx_Controls.Size = New System.Drawing.Size(563, 57)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 392)
        Me.gbx_Btn.Size = New System.Drawing.Size(563, 60)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.شمارهفرمنقصDataGridViewTextBoxColumn, Me.تاریخفرمنقصDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmWorkFormEibFormBindingSource
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
        Me.DataGridView1.Size = New System.Drawing.Size(557, 328)
        Me.DataGridView1.TabIndex = 0
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهفرمنقصDataGridViewTextBoxColumn
        '
        Me.شمارهفرمنقصDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.شمارهفرمنقصDataGridViewTextBoxColumn.DataPropertyName = "شماره فرم نقص"
        Me.شمارهفرمنقصDataGridViewTextBoxColumn.HeaderText = "شماره فرم نقص"
        Me.شمارهفرمنقصDataGridViewTextBoxColumn.Name = "شمارهفرمنقصDataGridViewTextBoxColumn"
        Me.شمارهفرمنقصDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخفرمنقصDataGridViewTextBoxColumn
        '
        Me.تاریخفرمنقصDataGridViewTextBoxColumn.DataPropertyName = "تاریخ فرم نقص"
        Me.تاریخفرمنقصDataGridViewTextBoxColumn.HeaderText = "تاریخ فرم نقص"
        Me.تاریخفرمنقصDataGridViewTextBoxColumn.Name = "تاریخفرمنقصDataGridViewTextBoxColumn"
        Me.تاریخفرمنقصDataGridViewTextBoxColumn.ReadOnly = True
        Me.تاریخفرمنقصDataGridViewTextBoxColumn.Width = 300
        '
        'PmWorkFormEibFormBindingSource
        '
        Me.PmWorkFormEibFormBindingSource.DataMember = "Pm_WorkForm_EibForm"
        Me.PmWorkFormEibFormBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(433, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شماره فرم نقص"
        '
        'txt_FormeNaghs
        '
        Me.txt_FormeNaghs.CheckExistValueInDb = False
        Me.txt_FormeNaghs.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FormeNaghs.CurrencyUnit = "ریال"
        Me.txt_FormeNaghs.DefaultValue = ""
        Me.txt_FormeNaghs.FillWithMaxInDb = False
        Me.txt_FormeNaghs.IsRequired = False
        Me.txt_FormeNaghs.Location = New System.Drawing.Point(312, 21)
        Me.txt_FormeNaghs.MaxDecimalLength = 2
        Me.txt_FormeNaghs.Name = "txt_FormeNaghs"
        Me.txt_FormeNaghs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_FormeNaghs.Size = New System.Drawing.Size(114, 25)
        Me.txt_FormeNaghs.SpellControl = Nothing
        Me.txt_FormeNaghs.TabIndex = 0
        Me.txt_FormeNaghs.Tag = "EibFormNo"
        Me.txt_FormeNaghs.Text = "0"
        Me.txt_FormeNaghs.Title = Nothing
        Me.txt_FormeNaghs.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_FormeNaghs.UseForData = True
        Me.txt_FormeNaghs.ValidateCheckExistOnEdit = False
        Me.txt_FormeNaghs.Value = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "تاریخ فرم نقص"
        '
        'txt_TarikhNaghs
        '
        Me.txt_TarikhNaghs.CheckExistValueInDb = False
        Me.txt_TarikhNaghs.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhNaghs.CurrencyUnit = "ریال"
        Me.txt_TarikhNaghs.DefaultValue = ""
        Me.txt_TarikhNaghs.FillWithMaxInDb = False
        Me.txt_TarikhNaghs.IsRequired = False
        Me.txt_TarikhNaghs.Location = New System.Drawing.Point(23, 21)
        Me.txt_TarikhNaghs.MaxDecimalLength = 2
        Me.txt_TarikhNaghs.Name = "txt_TarikhNaghs"
        Me.txt_TarikhNaghs.Size = New System.Drawing.Size(149, 25)
        Me.txt_TarikhNaghs.SpellControl = Nothing
        Me.txt_TarikhNaghs.TabIndex = 1
        Me.txt_TarikhNaghs.TabStop = False
        Me.txt_TarikhNaghs.Tag = "radife"
        Me.txt_TarikhNaghs.Title = Nothing
        Me.txt_TarikhNaghs.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhNaghs.UseForData = True
        Me.txt_TarikhNaghs.ValidateCheckExistOnEdit = False
        Me.txt_TarikhNaghs.Value = ""
        '
        'Pm_WorkForm_EibFormTableAdapter
        '
        Me.Pm_WorkForm_EibFormTableAdapter.ClearBeforeFill = True
        '
        'Frm_WorkForm_EibForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(591, 552)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_WorkForm_EibForm"
        Me.TableName = "Pm_WorkForm_EibForm"
        Me.Text = "فرم نقص های مربوط به فرم کار"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmWorkFormEibFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents txt_TarikhNaghs As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_FormeNaghs As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PmWorkFormEibFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents Pm_WorkForm_EibFormTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_WorkForm_EibFormTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمنقصDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخفرمنقصDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
