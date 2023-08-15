<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Lab_Rol_Tajhiz
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
        Me.Tree_Vw1 = New VB_Component.Tree_Vw
        Me.txtName = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.Pm_Lab_Rol_TajhizTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TajhizTableAdapter
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Delete
        '
        '
        'btn_new
        '
        '
        'btn_Edit
        '
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.Tree_Vw1)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(625, 240)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.txtName)
        Me.gbx_Controls.Location = New System.Drawing.Point(12, 327)
        Me.gbx_Controls.Size = New System.Drawing.Size(625, 50)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(12, 274)
        '
        'Tree_Vw1
        '
        Me.Tree_Vw1.BackColor = System.Drawing.Color.White
        Me.Tree_Vw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tree_Vw1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tree_Vw1.Location = New System.Drawing.Point(6, 19)
        Me.Tree_Vw1.Name = "Tree_Vw1"
        Me.Tree_Vw1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tree_Vw1.Size = New System.Drawing.Size(613, 213)
        Me.Tree_Vw1.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.CheckExistValueInDb = False
        Me.txtName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txtName.CurrencyUnit = "ریال"
        Me.txtName.DefaultValue = ""
        Me.txtName.FillWithMaxInDb = False
        Me.txtName.IsRequired = False
        Me.txtName.Location = New System.Drawing.Point(292, 13)
        Me.txtName.MaxDecimalLength = 2
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtName.Size = New System.Drawing.Size(154, 23)
        Me.txtName.SpellControl = Nothing
        Me.txtName.TabIndex = 0
        Me.txtName.Title = Nothing
        Me.txtName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txtName.UseForData = True
        Me.txtName.ValidateCheckExistOnEdit = False
        Me.txtName.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(452, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "تجهیز مورد نظر را وارد کنید"
        '
        'Ds_Lab
        '
        Me.Ds_Lab.DataSetName = "Ds_Lab"
        Me.Ds_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_Lab_Rol_TajhizTableAdapter
        '
        Me.Pm_Lab_Rol_TajhizTableAdapter.ClearBeforeFill = True
        '
        'Frm_Lab_Rol_Tajhiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 413)
        Me.Name = "Frm_Lab_Rol_Tajhiz"
        Me.TableName = "Pm_Lab_Rol_Tajhiz"
        Me.Text = "تجهیزات"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tree_Vw1 As VB_Component.Tree_Vw
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents PmLabRolTajhizBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_TajhizTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TajhizTableAdapter
    Friend WithEvents txtName As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
