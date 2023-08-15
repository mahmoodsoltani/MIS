Imports System.Drawing.Printing

Public Class Frm_RpPostPMGraph
    Dim Sdate As String
    Dim EDate As String
    Dim Post As String
    Private printingPageIndex As Integer = 0
    Dim sortType As Integer = 0
    Dim tajhiz As String = ""
    Dim RP As Integer
   

    Public Sub New(ByVal startDate As String, ByVal EndDate As String, ByVal post As String, ByVal sort As Integer, ByVal tajhiz As String, ByVal Rp As Integer)
        InitializeComponent()
        Sdate = startDate
        EDate = EndDate
        Me.Post = post
        sortType = sort
        Me.tajhiz = tajhiz
        Me.RP = Rp
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Chart1.Titles(0).BackImage = Application.StartupPath + "\LOGO.PNG"
        Chart1.Series(0)("LabelStyle") = "Bottom"
        Chart1.Series(1)("LabelStyle") = "Bottom"
        Chart1.Series(2)("LabelStyle") = "Bottom"
        pl_Color1.BackColor = Color.Blue
        pl_Color2.BackColor = Color.Green
        Pl_Color3.BackColor = Color.Red
        pl_color_4.BackColor = Color.Yellow
        Chart1.ChartAreas("CA1").AxisX.ScrollBar.IsPositionedInside = False
        Chart1.ChartAreas("CA1").AxisX.ScrollBar.ButtonStyle = DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll
        Chart1.ChartAreas("CA1").AxisX.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.VariableCount

        If RP = 0 Then
            Pm_PostPmTableAdapter.Fill(Me.Ds_Rp.Pm_PostPm, Sdate, EDate, Post)
            Select Case sortType
                Case 1
                    Ds_Rp.Pm_PostPm.DefaultView.Sort = "[انجام شده] desc"
                Case 2
                    Ds_Rp.Pm_PostPm.DefaultView.Sort = "[کنسل شده] desc"
                Case 3
                    Ds_Rp.Pm_PostPm.DefaultView.Sort = "[انجام نشده] desc"
                Case 4
                    Ds_Rp.Pm_PostPm.DefaultView.Sort = "[کل] desc"
            End Select
            Chart1.DataSource = Me.Ds_Rp.Pm_PostPm.DefaultView
            Chart1.Titles(0).Text = "                                                                                                          شرکت آذرخش انتقال نیرو \n" & _
                                    "                                                                                                                گزارش برنامه پی ام \n" & _
                                    "                                                                                                                   بر اساس پست \n" & _
                                    "        تاریخ گزارش :" + Setting.TarikheJary + "                                                                                        گزارش از تاریخ " + Sdate + " تا " + EDate

        Else
            Chart1.ChartAreas("CA1").AxisX.Title = "تجهیز"
            Rp_TajhizPmTableAdapter.Fill(Me.Ds_Rp.Rp_TajhizPm, Sdate, EDate, tajhiz)
            Select Case sortType
                Case 1
                    Me.Ds_Rp.Rp_TajhizPm.DefaultView.Sort = "[انجام شده] desc"
                Case 2
                    Me.Ds_Rp.Rp_TajhizPm.DefaultView.Sort = "[کنسل شده] desc"
                Case 3
                    Me.Ds_Rp.Rp_TajhizPm.DefaultView.Sort = "[انجام نشده] desc"
                Case 4
                    Me.Ds_Rp.Rp_TajhizPm.DefaultView.Sort = "[کل] desc"
            End Select
            Chart1.DataSource = Me.Ds_Rp.Rp_TajhizPm.DefaultView
            Chart1.Titles(0).Text = "                                                                                                          شرکت آذرخش انتقال نیرو \n" & _
                                   "                                                                                                                گزارش برناهه پی ام \n" & _
                                   "                                                                                                                   بر اساس تجهیزات \n" & _
                                   "        تاریخ گزارش :" + Setting.TarikheJary + "                                                                                        گزارش از تاریخ " + Sdate + " تا " + EDate

        End If
        txt_ColumnN.Value = 20
    End Sub



    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer = Chart1.Location.X
        Dim y As Integer = Chart1.Location.Y
        Dim width As Integer = Chart1.Size.Width
        Dim height As Integer = Chart1.Size.Height

        Dim bounds As New Rectangle(x, y, width + 20, height + 60)
        Dim img As New Bitmap(width + 20, height + 60)
        Chart1.ChartAreas("CA1").AxisX.ScrollBar.Enabled = False
        Chart1.DrawToBitmap(img, bounds)
        Chart1.ChartAreas("CA1").AxisX.ScrollBar.Enabled = True
        Dim p As New Point(10, 10)
        e.PageSettings.Landscape = True
        img.RotateFlip(RotateFlipType.Rotate270FlipNone)
        e.Graphics.DrawImage(img, p)
    End Sub

    Private Sub txt_ColumnN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ColumnN.TextChanged
        If txt_ColumnN.Value > 0 Then
            Chart1.ChartAreas("CA1").AxisX.ScaleView.Zoom(0, txt_ColumnN.Value + 0.5)
        End If
    End Sub

    Private Sub txt_RowInterval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RowInterval.TextChanged
        If txt_RowInterval.Value > 0 Then
            Chart1.ChartAreas("CA1").AxisY.MajorGrid.Interval = txt_RowInterval.Value
        End If
    End Sub

    Private Sub Chart1_AxisScrollBarClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.ScrollBarEventArgs) Handles Chart1.AxisScrollBarClicked
        Chart1.ChartAreas("CA1").AxisX.LabelStyle.Enabled = True
    End Sub

    Private Sub pl_Color1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pl_Color1.Click
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pl_Color1.BackColor = ColorDialog1.Color
            Chart1.Series(0).Color = ColorDialog1.Color
        End If
    End Sub

    Private Sub pl_Color2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pl_Color2.Click
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pl_Color2.BackColor = ColorDialog1.Color
            Chart1.Series(1).Color = ColorDialog1.Color
        End If
    End Sub

    Private Sub btn_Print_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Print_All.Click
        PrintDocument1.PrinterSettings.DefaultPageSettings.Landscape = True
        Dim count As Double = 0
        Dim i As Integer = 0

        i = Me.Ds_Rp.Pm_PostPm.Rows.Count

        While count <= i + 0.5
            Chart1.ChartAreas("CA1").AxisX.ScaleView.Zoom(count, count + txt_ColumnN.Value + 0.5)
            'Chart1.ChartAreas("CA1").AxisX.ScaleView.Scroll(count)
            count += txt_ColumnN.Value
            PrintDocument1.Print()
        End While
        txt_ColumnN.Value = txt_ColumnN.Value + 1
        txt_ColumnN.Value = txt_ColumnN.Value - 1
    End Sub

    Private Sub btn_Print_This_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Print_This.Click
        PrintDocument1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintDocument1.Print()
        txt_ColumnN.Value = txt_ColumnN.Value
    End Sub

    Private Sub Pl_Color3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pl_Color3.Click
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Pl_Color3.BackColor = ColorDialog1.Color
            Chart1.Series(2).Color = ColorDialog1.Color
        End If
    End Sub

    Private Sub pl_color_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pl_color_4.Click
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pl_color_4.BackColor = ColorDialog1.Color
            Chart1.Series(3).Color = ColorDialog1.Color
        End If
    End Sub
End Class