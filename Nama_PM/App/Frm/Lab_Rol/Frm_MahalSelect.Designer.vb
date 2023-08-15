<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MahalSelect
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
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.PmLabRolMahalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Lab_Rol_MahalTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_MahalTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolMahalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 417)
        Me.GroupBox1.Size = New System.Drawing.Size(410, 47)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(125, 15)
        Me.btn_Delete.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(219, 15)
        Me.btn_Edit.Visible = False
        '
        'btn_New
        '
        Me.btn_New.HeaderText = "انتخاب"
        Me.btn_New.Location = New System.Drawing.Point(313, 15)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.Tree_Vw1)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(410, 379)
        '
        'Tree_Vw1
        '
        Me.Tree_Vw1.BackColor = System.Drawing.Color.White
        Me.Tree_Vw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tree_Vw1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tree_Vw1.Location = New System.Drawing.Point(14, 13)
        Me.Tree_Vw1.Name = "Tree_Vw1"
        Me.Tree_Vw1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tree_Vw1.Size = New System.Drawing.Size(387, 360)
        Me.Tree_Vw1.TabIndex = 0
        '
        'Ds_Lab
        '
        Me.Ds_Lab.DataSetName = "Ds_Lab"
        Me.Ds_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmLabRolMahalBindingSource
        '
        Me.PmLabRolMahalBindingSource.DataMember = "Pm_Lab_Rol_Mahal"
        Me.PmLabRolMahalBindingSource.DataSource = Me.Ds_Lab
        '
        'Pm_Lab_Rol_MahalTableAdapter
        '
        Me.Pm_Lab_Rol_MahalTableAdapter.ClearBeforeFill = True
        '
        'Frm_MahalSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 500)
        Me.Name = "Frm_MahalSelect"
        Me.Text = "انتخاب محل تجهیزات"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolMahalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tree_Vw1 As VB_Component.Tree_Vw
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents PmLabRolMahalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_MahalTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_MahalTableAdapter
End Class
