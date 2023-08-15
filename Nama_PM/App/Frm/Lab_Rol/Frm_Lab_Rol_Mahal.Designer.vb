<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Lab_Rol_Mahal
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
        Me.txtMahal = New CS_Component.TextBox
        Me.Tree_Vw1 = New VB_Component.Tree_Vw
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.PmLabRolMahalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Lab_Rol_MahalTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_MahalTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolMahalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 378)
        '
        'btn_Delete
        '
        '
        'btn_Edit
        '
        '
        'btn_New
        '
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.Tree_Vw1)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(554, 336)
        '
        'txtMahal
        '
        Me.txtMahal.CheckExistValueInDb = False
        Me.txtMahal.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txtMahal.CurrencyUnit = "ریال"
        Me.txtMahal.DefaultValue = ""
        Me.txtMahal.FillWithMaxInDb = False
        Me.txtMahal.IsRequired = False
        Me.txtMahal.Location = New System.Drawing.Point(232, 436)
        Me.txtMahal.MaxDecimalLength = 2
        Me.txtMahal.Name = "txtMahal"
        Me.txtMahal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMahal.Size = New System.Drawing.Size(163, 23)
        Me.txtMahal.SpellControl = Nothing
        Me.txtMahal.TabIndex = 5
        Me.txtMahal.Title = Nothing
        Me.txtMahal.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txtMahal.UseForData = True
        Me.txtMahal.ValidateCheckExistOnEdit = False
        Me.txtMahal.Value = ""
        '
        'Tree_Vw1
        '
        Me.Tree_Vw1.BackColor = System.Drawing.Color.White
        Me.Tree_Vw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tree_Vw1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tree_Vw1.Location = New System.Drawing.Point(6, 13)
        Me.Tree_Vw1.Name = "Tree_Vw1"
        Me.Tree_Vw1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tree_Vw1.Size = New System.Drawing.Size(542, 317)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(401, 438)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "محل نصب تجهیز را وارد کنید"
        '
        'Frm_Lab_Rol_Mahal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMahal)
        Me.Name = "Frm_Lab_Rol_Mahal"
        Me.Text = "محل نصب و بهره برداری تجهیزات"
        Me.Controls.SetChildIndex(Me.txtMahal, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.gbx_DataGridView, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolMahalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMahal As CS_Component.TextBox
    Friend WithEvents Tree_Vw1 As VB_Component.Tree_Vw
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents PmLabRolMahalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_MahalTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_MahalTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
