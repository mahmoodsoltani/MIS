<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Template
    Inherits BaseForm_View

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
        Me.Tree_Vw1 = New VB_Component.Tree_Vw
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.PmPostTemplateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_PostTemplateTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTemplateTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostTemplateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 424)
        Me.GroupBox1.Size = New System.Drawing.Size(632, 47)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(347, 15)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(441, 15)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(535, 15)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.Tree_Vw1)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(632, 396)
        '
        'Tree_Vw1
        '
        Me.Tree_Vw1.BackColor = System.Drawing.Color.White
        Me.Tree_Vw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tree_Vw1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Tree_Vw1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tree_Vw1.Location = New System.Drawing.Point(3, 19)
        Me.Tree_Vw1.Name = "Tree_Vw1"
        Me.Tree_Vw1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tree_Vw1.Size = New System.Drawing.Size(626, 371)
        Me.Tree_Vw1.TabIndex = 3
        Me.Tree_Vw1.TabStop = False
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmPostTemplateBindingSource
        '
        Me.PmPostTemplateBindingSource.DataMember = "Pm_PostTemplate"
        Me.PmPostTemplateBindingSource.DataSource = Me.Ds_Pm
        '
        'Pm_PostTemplateTableAdapter
        '
        Me.Pm_PostTemplateTableAdapter.ClearBeforeFill = True
        '
        'Frm_Template
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(656, 507)
        Me.GoOnUpDown = False
        Me.Name = "Frm_Template"
        Me.TableName = "Pm_Hadese_KhesaratDevice"
        Me.Text = "نمایش تجهیزات مربوط به پست"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostTemplateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tree_Vw1 As VB_Component.Tree_Vw
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostTemplateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTemplateTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTemplateTableAdapter
End Class
