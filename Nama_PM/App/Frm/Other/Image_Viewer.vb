Public Class Image_Viewer

    Private Sub Image_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(ByVal im As System.Drawing.Image)
        InitializeComponent()
        PictureViewer1.ImageControl1.Image = im
    End Sub
End Class