<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pm_Lab_Rol_Tajhizat
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
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.PmLabRolTajhizBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Lab_Rol_TajhizTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TajhizTableAdapter
        Me.Tree_Vw1 = New VB_Component.Tree_Vw
        Me.txtTajhiz = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolTajhizBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(13, 370)
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
        Me.gbx_DataGridView.Size = New System.Drawing.Size(554, 334)
        '
        'Ds_Lab
        '
        Me.Ds_Lab.DataSetName = "Ds_Lab"
        Me.Ds_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmLabRolTajhizBindingSource
        '
        Me.PmLabRolTajhizBindingSource.DataMember = "Pm_Lab_Rol_Tajhiz"
        Me.PmLabRolTajhizBindingSource.DataSource = Me.Ds_Lab
        '
        'Pm_Lab_Rol_TajhizTableAdapter
        '
        Me.Pm_Lab_Rol_TajhizTableAdapter.ClearBeforeFill = True
        '
        'Tree_Vw1
        '
        Me.Tree_Vw1.BackColor = System.Drawing.Color.White
        Me.Tree_Vw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tree_Vw1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tree_Vw1.Location = New System.Drawing.Point(6, 19)
        Me.Tree_Vw1.Name = "Tree_Vw1"
        Me.Tree_Vw1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tree_Vw1.Size = New System.Drawing.Size(542, 309)
        Me.Tree_Vw1.TabIndex = 0
        '
        'txtTajhiz
        '
        Me.txtTajhiz.CheckExistValueInDb = False
        Me.txtTajhiz.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txtTajhiz.CurrencyUnit = "ریال"
        Me.txtTajhiz.DefaultValue = ""
        Me.txtTajhiz.FillWithMaxInDb = False
        Me.txtTajhiz.IsRequired = False
        Me.txtTajhiz.Location = New System.Drawing.Point(260, 431)
        Me.txtTajhiz.MaxDecimalLength = 2
        Me.txtTajhiz.Name = "txtTajhiz"
        Me.txtTajhiz.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTajhiz.Size = New System.Drawing.Size(144, 23)
        Me.txtTajhiz.SpellControl = Nothing
        Me.txtTajhiz.TabIndex = 5
        Me.txtTajhiz.Title = Nothing
        Me.txtTajhiz.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txtTajhiz.UseForData = True
        Me.txtTajhiz.ValidateCheckExistOnEdit = False
        Me.txtTajhiz.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(410, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "تجهیز مورد نظر را وارد کنید"
        '
        'Frm_Pm_Lab_Rol_Tajhizat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTajhiz)
        Me.Name = "Frm_Pm_Lab_Rol_Tajhizat"
        Me.TableName = "Pm_Lab_Rol_Tajhiz"
        Me.Text = "تجهیزات"
        Me.Controls.SetChildIndex(Me.txtTajhiz, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.gbx_DataGridView, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolTajhizBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents PmLabRolTajhizBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_TajhizTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TajhizTableAdapter
    Friend WithEvents Tree_Vw1 As VB_Component.Tree_Vw
    Friend WithEvents txtTajhiz As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
