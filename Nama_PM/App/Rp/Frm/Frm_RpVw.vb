Public Class Frm_RpVw

    Public Sub New(ByVal obj As Object, ByVal dt As DataTable)
        InitializeComponent()
        FaReportViewer1.ReportSource = obj
        FaReportViewer1.ReportDataview = dt
    End Sub

    Private Sub Frm_RpVw_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.P And e.Control Then
            FaReportViewer1.btn_Print_Click(Nothing, Nothing)
        End If
    End Sub
End Class