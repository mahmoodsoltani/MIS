<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Image_Viewer
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
        Me.PictureViewer1 = New VB_Component.PictureViewer
        Me.SuspendLayout()
        '
        'PictureViewer1
        '
        Me.PictureViewer1.BackColor = System.Drawing.Color.White
        Me.PictureViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureViewer1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PictureViewer1.Location = New System.Drawing.Point(6, 57)
        Me.PictureViewer1.Name = "PictureViewer1"
        Me.PictureViewer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PictureViewer1.Size = New System.Drawing.Size(846, 506)
        Me.PictureViewer1.TabIndex = 5
        '
        'Image_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 592)
        Me.Controls.Add(Me.PictureViewer1)
        Me.Name = "Image_Viewer"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.PictureViewer1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureViewer1 As VB_Component.PictureViewer
End Class
