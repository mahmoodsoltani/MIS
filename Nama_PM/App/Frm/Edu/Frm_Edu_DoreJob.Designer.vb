<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Edu_DoreJob
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
        Me.srl_job = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.عنوانDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmEduDoreJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Edu = New Nama_PM.Ds_Edu
        Me.cmb_TahvilePerson = New VB_Component.ComboBox
        Me.PmEduJobTitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.Pm_Edu_JobTitleTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_JobTitleTableAdapter
        Me.Pm_Edu_DoreJobTableAdapter = New Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreJobTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduDoreJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmEduJobTitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(136, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "F2 اضافه کردن"
        Me.btn_new.Location = New System.Drawing.Point(394, 18)
        Me.btn_new.Size = New System.Drawing.Size(135, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(259, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(535, 285)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.cmb_TahvilePerson)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 397)
        Me.gbx_Controls.Size = New System.Drawing.Size(535, 55)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 331)
        Me.gbx_Btn.Size = New System.Drawing.Size(535, 60)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.srl_job, Me.عنوانDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmEduDoreJobBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
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
        Me.DataGridView1.Size = New System.Drawing.Size(529, 260)
        Me.DataGridView1.TabIndex = 5
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'srl_job
        '
        Me.srl_job.DataPropertyName = "srl_job"
        Me.srl_job.HeaderText = "srl_job"
        Me.srl_job.Name = "srl_job"
        Me.srl_job.ReadOnly = True
        Me.srl_job.Visible = False
        '
        'عنوانDataGridViewTextBoxColumn
        '
        Me.عنوانDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.عنوانDataGridViewTextBoxColumn.DataPropertyName = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.HeaderText = "عنوان"
        Me.عنوانDataGridViewTextBoxColumn.Name = "عنوانDataGridViewTextBoxColumn"
        Me.عنوانDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmEduDoreJobBindingSource
        '
        Me.PmEduDoreJobBindingSource.DataMember = "Pm_Edu_DoreJob"
        Me.PmEduDoreJobBindingSource.DataSource = Me.Ds_Edu
        '
        'Ds_Edu
        '
        Me.Ds_Edu.DataSetName = "Ds_Edu"
        Me.Ds_Edu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_TahvilePerson
        '
        Me.cmb_TahvilePerson.AutoComplete = True
        Me.cmb_TahvilePerson.DataSource = Me.PmEduJobTitleBindingSource
        Me.cmb_TahvilePerson.DisplayMember = "عنوان"
        Me.cmb_TahvilePerson.EnterStop = True
        Me.cmb_TahvilePerson.FormattingEnabled = True
        Me.cmb_TahvilePerson.IsRequired = True
        Me.cmb_TahvilePerson.LimitedToList = True
        Me.cmb_TahvilePerson.Location = New System.Drawing.Point(60, 19)
        Me.cmb_TahvilePerson.Name = "cmb_TahvilePerson"
        Me.cmb_TahvilePerson.OpenOnFoucus = False
        Me.cmb_TahvilePerson.Size = New System.Drawing.Size(338, 26)
        Me.cmb_TahvilePerson.TabIndex = 3
        Me.cmb_TahvilePerson.Tag = "Srl_job"
        Me.cmb_TahvilePerson.ValueMember = "Srl"
        '
        'PmEduJobTitleBindingSource
        '
        Me.PmEduJobTitleBindingSource.DataMember = "Pm_Edu_JobTitle"
        Me.PmEduJobTitleBindingSource.DataSource = Me.Ds_Edu
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(406, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "عنوان شغلی"
        '
        'Pm_Edu_JobTitleTableAdapter
        '
        Me.Pm_Edu_JobTitleTableAdapter.ClearBeforeFill = True
        '
        'Pm_Edu_DoreJobTableAdapter
        '
        Me.Pm_Edu_DoreJobTableAdapter.ClearBeforeFill = True
        '
        'Frm_Edu_DoreJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(563, 491)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Edu_DoreJob"
        Me.TableName = "Pm_Edu_DoreJob"
        Me.Text = "عناوین شغلی مربوط به دوره "
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduDoreJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Edu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmEduJobTitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_TahvilePerson As VB_Component.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Ds_Edu As Nama_PM.Ds_Edu
    Friend WithEvents PmEduJobTitleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_JobTitleTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_JobTitleTableAdapter
    Friend WithEvents PmEduDoreJobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Edu_DoreJobTableAdapter As Nama_PM.Ds_EduTableAdapters.Pm_Edu_DoreJobTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents srl_job As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
