<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Lal_Rol_GhatateMasrafi
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
        Me.txt_DeviceName = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.قطعاتمصرفیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmLabRolGhatatMasrafiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.Pm_Lab_Rol_GhatatMasrafiTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_GhatatMasrafiTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolGhatatMasrafiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(230, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(477, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(354, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(598, 363)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.txt_DeviceName)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 463)
        Me.gbx_Controls.Size = New System.Drawing.Size(598, 54)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 403)
        Me.gbx_Btn.Size = New System.Drawing.Size(598, 60)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.قطعاتمصرفیDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmLabRolGhatatMasrafiBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 20)
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
        Me.DataGridView1.Size = New System.Drawing.Size(577, 331)
        Me.DataGridView1.TabIndex = 2
        '
        'txt_DeviceName
        '
        Me.txt_DeviceName.CheckExistValueInDb = False
        Me.txt_DeviceName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeviceName.CurrencyUnit = "ریال"
        Me.txt_DeviceName.DefaultValue = ""
        Me.txt_DeviceName.FillWithMaxInDb = False
        Me.txt_DeviceName.IsRequired = False
        Me.txt_DeviceName.Location = New System.Drawing.Point(11, 19)
        Me.txt_DeviceName.MaxDecimalLength = 2
        Me.txt_DeviceName.Name = "txt_DeviceName"
        Me.txt_DeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceName.Size = New System.Drawing.Size(504, 26)
        Me.txt_DeviceName.SpellControl = Nothing
        Me.txt_DeviceName.TabIndex = 5
        Me.txt_DeviceName.Tag = "text"
        Me.txt_DeviceName.Title = Nothing
        Me.txt_DeviceName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeviceName.UseForData = True
        Me.txt_DeviceName.ValidateCheckExistOnEdit = False
        Me.txt_DeviceName.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(521, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "نام قطعه"
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'قطعاتمصرفیDataGridViewTextBoxColumn
        '
        Me.قطعاتمصرفیDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.قطعاتمصرفیDataGridViewTextBoxColumn.DataPropertyName = "قطعات مصرفی"
        Me.قطعاتمصرفیDataGridViewTextBoxColumn.HeaderText = "قطعات مصرفی"
        Me.قطعاتمصرفیDataGridViewTextBoxColumn.Name = "قطعاتمصرفیDataGridViewTextBoxColumn"
        Me.قطعاتمصرفیDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmLabRolGhatatMasrafiBindingSource
        '
        Me.PmLabRolGhatatMasrafiBindingSource.DataMember = "Pm_Lab_Rol_GhatatMasrafi"
        Me.PmLabRolGhatatMasrafiBindingSource.DataSource = Me.Ds_Lab
        '
        'Ds_Lab
        '
        Me.Ds_Lab.DataSetName = "Ds_Lab"
        Me.Ds_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_Lab_Rol_GhatatMasrafiTableAdapter
        '
        Me.Pm_Lab_Rol_GhatatMasrafiTableAdapter.ClearBeforeFill = True
        '
        'Frm_Lal_Rol_GhatateMasrafi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(626, 550)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Lal_Rol_GhatateMasrafi"
        Me.TableName = "Pm_Lab_Rol_GhatatMasrafi"
        Me.Text = "قطعات مصرفی"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolGhatatMasrafiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents txt_DeviceName As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents PmLabRolGhatatMasrafiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_GhatatMasrafiTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_GhatatMasrafiTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قطعاتمصرفیDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
