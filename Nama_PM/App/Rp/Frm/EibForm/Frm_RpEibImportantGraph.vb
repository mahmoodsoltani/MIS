Imports System.Drawing.Printing

Public Class Frm_RpEibImportantGraph
    Dim Sdate As String
    Dim EDate As String
    Dim SortType As String
    Private printingPageIndex As Integer = 0
    Dim Filter As String
    Dim RpType As Integer
    Dim ShowPeiro As Integer

    Public Sub New(ByVal startDate As String, ByVal EndDate As String, ByVal Sort As String, ByVal Type As Integer, ByVal p_Filter As String, ByVal ShowP As Integer)
        InitializeComponent()
        Sdate = startDate
        EDate = EndDate
        SortType = Sort
        RpType = Type
        Filter = p_Filter
        ShowPeiro = ShowP
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_ImportantPercent' table. You can move, or remove it, as needed.
        Me.Pm_ImportantPercentTableAdapter.Fill(Me.Ds_Pm.Pm_ImportantPercent)
        Dim counter As Integer = 0
        'For Each dr As DataRow In Me.Ds_Pm.Pm_ImportantPercent.Rows
        '    Chart1.Series.Add(dr(2).ToString())
        '    Chart1.Series(counter)("LabelStyle") = "Bottom"
        'Next
        Chart1.Series(0)("LabelStyle") = "Bottom"
        Chart1.Titles(0).BackImage = Application.StartupPath + "\LOGO.PNG"
        Chart1.ChartAreas("CA1").AxisX.ScrollBar.IsPositionedInside = False
        Chart1.ChartAreas("CA1").AxisX.ScrollBar.ButtonStyle = DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll
        Chart1.ChartAreas("CA1").AxisX.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.VariableCount
        'pl_Color1.BackColor = Color.Blue
        'pl_Color2.BackColor = Color.Red
        'Pl_Color3.BackColor = Color.Green

        If RpType = 1 Then
            Rp_GroupEibFormTableAdapter.Fill(Me.Ds_Rp.Rp_GroupEibForm, Sdate, ShowPeiro, EDate, Filter)
            If SortType = "Nofix" Then
                Ds_Rp.Rp_GroupEibForm.DefaultView.Sort = "[رفع نشده] desc"
            ElseIf SortType = "fix" Then
                Ds_Rp.Rp_GroupEibForm.DefaultView.Sort = "[رفع شده] desc"
            End If
            Chart1.DataSource = Me.Ds_Rp.Rp_GroupEibForm.DefaultView
            Chart1.Titles(0).Text = "                                                                                                          شرکت آذرخش انتقال نیرو \n" & _
                                    "                                                                                                                گزارش فرم نقص های \n" & _
                                    "                                                                                                                   بر اساس گروه \n" & _
                                    "        تاریخ گزارش :" + Setting.TarikheJary + "                                                                                        گزارش از تاریخ " + Sdate + " تا " + EDate
        ElseIf RpType = 2 Then
            Chart1.ChartAreas("CA1").AxisX.Title = "واحد"
            Rp_VahedEibFormTableAdapter.Fill(Me.Ds_Rp.Rp_VahedEibForm, Sdate, ShowPeiro, EDate, Filter)
            If SortType = "Nofix" Then
                Ds_Rp.Rp_VahedEibForm.DefaultView.Sort = "[رفع نشده] desc"
            ElseIf SortType = "fix" Then
                Ds_Rp.Rp_VahedEibForm.DefaultView.Sort = "[رفع شده] desc"
            End If
            Chart1.DataSource = Me.Ds_Rp.Rp_VahedEibForm.DefaultView
            Chart1.Titles(0).Text = "                                                                                                          شرکت آذرخش انتقال نیرو \n" & _
                                    "                                                                                                                گزارش فرم نقص های \n" & _
                                    "                                                                                                                   بر اساس واحد\n" & _
                                    "        تاریخ گزارش :" + Setting.TarikheJary + "                                                                                        گزارش از تاریخ " + Sdate + " تا " + EDate
        ElseIf RpType = 3 Then
            Chart1.ChartAreas("CA1").AxisX.Title = "نوع عیب"
            Rp_EibTypeEibFormTableAdapter.Fill(Me.Ds_Rp.Rp_EibTypeEibForm, Sdate, ShowPeiro, EDate, Filter)
            If SortType = "Nofix" Then
                Ds_Rp.Rp_EibTypeEibForm.DefaultView.Sort = "[رفع نشده] desc"
            ElseIf SortType = "fix" Then
                Ds_Rp.Rp_EibTypeEibForm.DefaultView.Sort = "[رفع شده] desc"
            End If
            Chart1.DataSource = Me.Ds_Rp.Rp_EibTypeEibForm.DefaultView
            Chart1.Titles(0).Text = "                                                                                                          شرکت آذرخش انتقال نیرو \n" & _
                                    "                                                                                                                گزارش فرم نقص های \n" & _
                                    "                                                                                                                   بر اساس نوع عیب\n" & _
                                    "        تاریخ گزارش :" + Setting.TarikheJary + "                                                                                        گزارش از تاریخ " + Sdate + " تا " + EDate
        ElseIf RpType = 4 Then
            Chart1.ChartAreas("CA1").AxisX.Title = "پست"
            Rp_PostEibformTableAdapter.Fill(Me.Ds_Rp.Rp_PostEibform, Sdate, ShowPeiro, EDate, Filter)
            If SortType = "Nofix" Then
                Ds_Rp.Rp_PostEibform.DefaultView.Sort = "[رفع نشده] desc"
            ElseIf SortType = "fix" Then
                Ds_Rp.Rp_PostEibform.DefaultView.Sort = "[رفع شده] desc"
            End If
            Chart1.DataSource = Me.Ds_Rp.Rp_PostEibform.DefaultView
            Chart1.Titles(0).Text = "                                                                                                          شرکت آذرخش انتقال نیرو \n" & _
                                    "                                                                                                                گزارش فرم نقص های \n" & _
                                    "                                                                                                                    بر اساس پست \n" & _
                                    "        تاریخ گزارش :" + Setting.TarikheJary + "                                                                                        گزارش از تاریخ " + Sdate + " تا " + EDate

        End If

        txt_ColumnN.Value = 20
    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click
        'PrintDocument1.PrinterSettings.DefaultPageSettings.Landscape = True
        'Dim count As Integer = 0
        'Dim i As Integer = Me.Ds_Rp.Rp_GroupEibForm.Rows.Count
        'While count <= i
        '    Chart1.ChartAreas("CA1").AxisX.ScaleView.Zoom(count, count + 7.5)
        '    count += 7
        '    PrintDocument1.Print()
        'End While
        '' Page index
        'Dim printingPageIndex As Integer = 0
        'Chart1.Printing.PrintDocument = New PrintDocument()
        'AddHandler Chart1.Printing.PrintDocument.PrintPage, AddressOf pd_PrintPage
        'Chart1.Printing.PrintPreview()
    End Sub

    'Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
    '    ev.HasMorePages = True
    '    ' Calculate chart position rectangle
    '    Dim chartPosition As New Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y, chart1.Size.Width, chart1.Size.Height)
    '    Dim chartWidthScale As Single = CSng(ev.MarginBounds.Width) / CSng(chartPosition.Width)
    '    Dim chartHeightScale As Single = CSng(ev.MarginBounds.Height) / CSng(chartPosition.Height)
    '    chartPosition.Width = CInt(chartPosition.Width * Math.Min(chartWidthScale, chartHeightScale))
    '    chartPosition.Height = CInt(chartPosition.Height * Math.Min(chartWidthScale, chartHeightScale))
    '    If Double.IsNaN(Chart1.ChartAreas("CA1").AxisX.ScaleView.Position) Then
    '        ' Reset page index
    '        printingPageIndex = 0

    '        ' Set view
    '        Chart1.ChartAreas("CA1").AxisX.ScaleView.Position = Chart1.ChartAreas("CA1").AxisX.Minimum
    '        Chart1.ChartAreas("CA1").AxisX.ScaleView.Size = 7
    '    End If

    '    ' Set chart title
    '    'Chart1.Title = "Chart Page Number " + printingPageIndex.ToString()

    '    ' Draw chart on the printer graphisc
    '    Chart1.Printing.PrintPaint(ev.Graphics, chartPosition)

    '    ' Scroll to the next view (2 months)
    '    Dim currentPosition As Double = Chart1.ChartAreas("CA1").AxisX.ScaleView.Position
    '    Chart1.ChartAreas("CA1").AxisX.ScaleView.Scroll(DataVisualization.Charting.ScrollType.LargeIncrement)

    '    ' Check if position was scrolled
    '    If currentPosition >= (Chart1.ChartAreas("CA1").AxisX.ScaleView.Position - 1.0) Then
    '        ' No more pages
    '        ev.HasMorePages = False

    '        ' Restore view state
    '        Chart1.ChartAreas("CA1").AxisX.ScaleView.Position = Double.NaN
    '        Chart1.ChartAreas("CA1").AxisX.ScaleView.Size = Double.NaN

    '        ' Remove chart title
    '        ' chart1.Title = ""
    '    End If
    'End Sub

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
        If RpType = 1 Then
            i = Me.Ds_Rp.Rp_GroupEibForm.Rows.Count
        ElseIf RpType = 2 Then
            i = Me.Ds_Rp.Rp_VahedEibForm.Rows.Count
        ElseIf RpType = 3 Then
            i = Me.Ds_Rp.Rp_EibTypeEibForm.Rows.Count
        ElseIf RpType = 4 Then
            i = Me.Ds_Rp.Rp_PostEibform.Rows.Count
        End If
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
End Class