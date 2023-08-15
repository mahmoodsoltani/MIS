Public Class Frm_RpNafarSatGroupGraph
    Public Sub New(ByVal begindate As String, ByVal enddate As String, ByVal selectedGroup As Integer)
        InitializeComponent()
        Dim rp As New Rp_NafarSatProject
        Rp_NafarSatGroupTableAdapter.Fill(Me.Ds_Rp.Rp_NafarSatGroup, begindate, enddate, selectedGroup)

        'For Each dr As DataRow In Ds_Rp.Rp_NafarSatProject
        '    dr("Time") = New TimeSpan(0, 0, Double.Parse(dr("SumS").ToString))
        'Next

        'rp.SetDataSource(Me.Ds_Rp.Rp_NafarSatProject.DataSet)
        'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
        'Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Rp.Rp_NafarSatProject.DataSet.Tables("0"))
        'frm_rp.ShowDialog()
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
        'If RpType = 1 Then
        '    i = Me.Ds_Rp.Rp_GroupEibForm.Rows.Count
        'ElseIf RpType = 2 Then
        '    i = Me.Ds_Rp.Rp_VahedEibForm.Rows.Count
        'ElseIf RpType = 3 Then
        '    i = Me.Ds_Rp.Rp_EibTypeEibForm.Rows.Count
        'ElseIf RpType = 4 Then
        '    i = Me.Ds_Rp.Rp_PostEibform.Rows.Count
        'End If
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
End Class