<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Edu_Evaluation
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
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.srl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.بد25DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.متوسط50DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.خوب75DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.عالی100DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PmEduEvaluationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Edu = New Nama_PM.Ds_Edu
        Me.Pm_Edu_EvaluationTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_EvaluationTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduEvaluationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srl, Me.TitleDataGridViewTextBoxColumn, Me.بد25DataGridViewTextBoxColumn, Me.متوسط50DataGridViewTextBoxColumn, Me.خوب75DataGridViewTextBoxColumn, Me.عالی100DataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmEduEvaluationBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(6, 57)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(658, 236)
        Me.DataGridView1.TabIndex = 5
        '
        'srl
        '
        Me.srl.DataPropertyName = "srl"
        Me.srl.HeaderText = "srl"
        Me.srl.Name = "srl"
        Me.srl.ReadOnly = True
        Me.srl.Visible = False
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "عنوان سوال"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'بد25DataGridViewTextBoxColumn
        '
        Me.بد25DataGridViewTextBoxColumn.DataPropertyName = "بد(25)"
        Me.بد25DataGridViewTextBoxColumn.HeaderText = "بد(25)"
        Me.بد25DataGridViewTextBoxColumn.Name = "بد25DataGridViewTextBoxColumn"
        Me.بد25DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.بد25DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.بد25DataGridViewTextBoxColumn.Width = 70
        '
        'متوسط50DataGridViewTextBoxColumn
        '
        Me.متوسط50DataGridViewTextBoxColumn.DataPropertyName = "متوسط(50)"
        Me.متوسط50DataGridViewTextBoxColumn.HeaderText = "متوسط(50)"
        Me.متوسط50DataGridViewTextBoxColumn.Name = "متوسط50DataGridViewTextBoxColumn"
        Me.متوسط50DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.متوسط50DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.متوسط50DataGridViewTextBoxColumn.Width = 80
        '
        'خوب75DataGridViewTextBoxColumn
        '
        Me.خوب75DataGridViewTextBoxColumn.DataPropertyName = "خوب(75)"
        Me.خوب75DataGridViewTextBoxColumn.HeaderText = "خوب(75)"
        Me.خوب75DataGridViewTextBoxColumn.Name = "خوب75DataGridViewTextBoxColumn"
        Me.خوب75DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.خوب75DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.خوب75DataGridViewTextBoxColumn.Width = 70
        '
        'عالی100DataGridViewTextBoxColumn
        '
        Me.عالی100DataGridViewTextBoxColumn.DataPropertyName = "عالی(100)"
        Me.عالی100DataGridViewTextBoxColumn.HeaderText = "عالی(100)"
        Me.عالی100DataGridViewTextBoxColumn.Name = "عالی100DataGridViewTextBoxColumn"
        Me.عالی100DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.عالی100DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.عالی100DataGridViewTextBoxColumn.Width = 75
        '
        'PmEduEvaluationBindingSource
        '
        Me.PmEduEvaluationBindingSource.DataMember = "Pm_Edu_Evaluation"
        Me.PmEduEvaluationBindingSource.DataSource = Me.Ds_Edu
        '
        'Ds_Edu
        '
        Me.Ds_Edu.DataSetName = "Ds_Edu"
        Me.Ds_Edu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_Edu_EvaluationTableAdapter
        '
        Me.Pm_Edu_EvaluationTableAdapter.ClearBeforeFill = True
        '
        'Frm_Edu_Evaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 322)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Frm_Edu_Evaluation"
        Me.Text = "ارزیابی"
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduEvaluationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents PmEduEvaluationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Edu As Nama_PM.Ds_Edu
    Friend WithEvents Pm_Edu_EvaluationTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_EvaluationTableAdapter
    Friend WithEvents srl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents بد25DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents متوسط50DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents خوب75DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents عالی100DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
