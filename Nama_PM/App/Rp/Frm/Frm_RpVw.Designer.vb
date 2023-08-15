<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpVw
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
        Me.FaReportViewer1 = New VB_Component.FaReportViewer
        Me.SuspendLayout()
        '
        'FaReportViewer1
        '
        Me.FaReportViewer1.BackColor = System.Drawing.Color.White
        Me.FaReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FaReportViewer1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FaReportViewer1.Location = New System.Drawing.Point(6, 57)
        Me.FaReportViewer1.Name = "FaReportViewer1"
        Me.FaReportViewer1.ReportDataview = Nothing
        Me.FaReportViewer1.ReportSource = Nothing
        Me.FaReportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FaReportViewer1.ShowFilterOption = True
        Me.FaReportViewer1.ShowSortOption = True
        Me.FaReportViewer1.Size = New System.Drawing.Size(744, 444)
        Me.FaReportViewer1.TabIndex = 4
        '
        'Frm_RpVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 530)
        Me.Controls.Add(Me.FaReportViewer1)
        Me.Name = "Frm_RpVw"
        Me.Text = "نمایش گزارش"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.FaReportViewer1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FaReportViewer1 As VB_Component.FaReportViewer
End Class
