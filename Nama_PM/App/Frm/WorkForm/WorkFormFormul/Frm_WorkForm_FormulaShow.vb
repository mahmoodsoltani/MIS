Public Class Frm_WorkForm_FormulaShow
    Dim temp_container As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Dim ht As Hashtable = New Hashtable()
    Dim IsTaradod As Boolean
    Dim Srl_WorkForm_Profile As Integer

    Public Sub New(ByVal IsTaradod As Boolean, ByVal Srl_WorkForm_Profile As Integer)
        InitializeComponent()
        Me.IsTaradod = IsTaradod
        Me.Srl_WorkForm_Profile = Srl_WorkForm_Profile
        If IsTaradod Then
            Me.Text += " - اضافه کار تردد"
        End If
    End Sub

    Private Sub Frm_WorkForm_formulaShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub InsertColor(ByVal Zarib As Double)
        If Not ht Is Nothing And Not ht.ContainsKey(Zarib) Then
            ht.Add(Zarib, GetColor(ht.Count))
            DirectCast(Me.Pl_Print.Controls("HLB_" + ht.Count.ToString()), Label).BackColor = DirectCast((ht(Zarib)), Color)
            DirectCast(Me.Pl_Print.Controls("HLB_" + ht.Count.ToString()), Label).Visible = True
            DirectCast(Me.Pl_Print.Controls("HLB_" + ht.Count.ToString()), Label).Text = Zarib
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each c As Control In Me.Controls
            If c.Name = "" Then
                c.Dispose()
            End If
        Next
        temp_container = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.Pl_Print.Controls.Add(temp_container)
        ' If Not ComboBox1.SelectedValue Is Nothing Then
        If True Then
            Dim Sa, Su, Mo, Tu, We, Th, Fr As Boolean

            Dim S_Taradod As String = 0

            If IsTaradod Then
                S_Taradod = "1"
            Else
                S_Taradod = "0"
            End If

            'Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable("select * from Pm_WorkForm_Formula where Srl_Pm_WorkType=" + ComboBox1.SelectedValue.ToString())
            Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable("select * from Pm_WorkForm_Formula where IsTaradod=" & _
                                  S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString + " order by zarib")
            Dim StartTime As Integer
            Dim EndTime As Integer
            Dim Zarib As Double
            If Not dt Is Nothing Then
                For Each dr As DataRow In dt.Rows
                    StartTime = 52 + (CInt(dr("FromSat").ToString().Substring(0, dr("FromSat").ToString().IndexOf(":"))) * 30 + CInt(dr("FromSat").ToString().Substring(dr("FromSat").ToString().IndexOf(":") + 1, 2)) / 2)
                    EndTime = 52 + (CInt(dr("ToSat").ToString().Substring(0, dr("ToSat").ToString().IndexOf(":"))) * 30 + CInt(dr("ToSat").ToString().Substring(dr("ToSat").ToString().IndexOf(":") + 1, 2)) / 2)
                    If Not dr("Zarib") Is DBNull.Value Then
                        Zarib = CDbl(dr("Zarib").ToString())
                    Else
                        Zarib = 0.0
                    End If
                    InsertColor(Zarib)
                    Select Case dr("Srl_DayOfWeak").ToString()
                        Case "1"
                            If Not Sa Then
                                pl_Sat.Location = New System.Drawing.Point(StartTime, pl_Sat.Location.Y)
                                pl_Sat.Size = New System.Drawing.Size(EndTime - StartTime, pl_Sat.Size.Height)
                                pl_Sat.FillColor = DirectCast((ht(Zarib)), Color)
                                Sa = True
                            Else
                                AddControl(StartTime, pl_Sat.Location.Y, EndTime - StartTime, pl_Sat.Size.Height, Zarib)
                            End If
                        Case "2"
                            If Not Su Then
                                pl_Sun.Location = New System.Drawing.Point(StartTime, pl_Sun.Location.Y)
                                pl_Sun.Size = New System.Drawing.Size(EndTime - StartTime, pl_Sun.Size.Height)
                                pl_Sun.FillColor = DirectCast((ht(Zarib)), Color)
                                Su = True
                            Else
                                AddControl(StartTime, pl_Sun.Location.Y, EndTime - StartTime, pl_Sun.Size.Height, Zarib)
                            End If
                        Case "3"
                            If Not Mo Then
                                pl_Mon.Location = New System.Drawing.Point(StartTime, pl_Mon.Location.Y)
                                pl_Mon.Size = New System.Drawing.Size(EndTime - StartTime, pl_Mon.Size.Height)
                                pl_Mon.FillColor = DirectCast((ht(Zarib)), Color)
                                Mo = True
                            Else
                                AddControl(StartTime, pl_Mon.Location.Y, EndTime - StartTime, pl_Mon.Size.Height, Zarib)
                            End If
                        Case "4"
                            If Not Tu Then
                                pl_thu.Location = New System.Drawing.Point(StartTime, pl_thu.Location.Y)
                                pl_thu.Size = New System.Drawing.Size(EndTime - StartTime, pl_thu.Size.Height)
                                pl_thu.FillColor = DirectCast((ht(Zarib)), Color)
                                Tu = True
                            Else
                                AddControl(StartTime, pl_thu.Location.Y, EndTime - StartTime, pl_thu.Size.Height, Zarib)
                            End If
                        Case "5"
                            If Not We Then
                                pl_wed.Location = New System.Drawing.Point(StartTime, pl_wed.Location.Y)
                                pl_wed.Size = New System.Drawing.Size(EndTime - StartTime, pl_wed.Size.Height)
                                pl_wed.FillColor = DirectCast((ht(Zarib)), Color)
                                We = True
                            Else
                                AddControl(StartTime, pl_wed.Location.Y, EndTime - StartTime, pl_wed.Size.Height, Zarib)
                            End If
                        Case "6"
                            If Not Th Then
                                pl_ther.Location = New System.Drawing.Point(StartTime, pl_ther.Location.Y)
                                pl_ther.Size = New System.Drawing.Size(EndTime - StartTime, pl_ther.Size.Height)
                                pl_ther.FillColor = DirectCast((ht(Zarib)), Color)
                                Th = True
                            Else
                                AddControl(StartTime, pl_ther.Location.Y, EndTime - StartTime, pl_ther.Size.Height, Zarib)
                            End If
                        Case "7"
                            If Not Fr Then
                                pl_fri.Location = New System.Drawing.Point(StartTime, pl_fri.Location.Y)
                                pl_fri.Size = New System.Drawing.Size(EndTime - StartTime, pl_fri.Size.Height)
                                pl_fri.FillColor = DirectCast((ht(Zarib)), Color)
                                Fr = True
                            Else
                                AddControl(StartTime, pl_fri.Location.Y, EndTime - StartTime, pl_fri.Size.Height, Zarib)
                            End If

                    End Select
                Next
                pl_Sat.Visible = Sa
                pl_Sun.Visible = Su
                pl_Mon.Visible = Mo
                pl_thu.Visible = Tu
                pl_wed.Visible = We
                pl_ther.Visible = Th
                pl_fri.Visible = Fr
            End If
        End If

    End Sub

    Public Sub AddControl(ByVal X As Integer, ByVal Y As Integer, ByVal W As Integer, ByVal H As Integer, ByVal Zarib As Double)
        Dim p As New Microsoft.VisualBasic.PowerPacks.RectangleShape(X, Y, W, H)
        p.FillColor = DirectCast((ht(Zarib)), Color)
        p.FillStyle = PowerPacks.FillStyle.Solid
        temp_container.Shapes.Add(p)
    End Sub

    Public Function GetColor(ByVal Index As Integer) As Color
        Select Case Index
            Case 1
                Return Color.Red
            Case 2
                Return Color.Yellow
            Case 3
                Return Color.Blue
            Case 4
                Return Color.Green
            Case 5
                Return Color.YellowGreen
            Case 6
                Return Color.Violet
            Case 7
                Return Color.SkyBlue
            Case 8
                Return Color.Gray
            Case 9
                Return Color.DarkBlue
            Case 10
                Return Color.Violet
            Case 11
                Return Color.DarkViolet
            Case 0
                Return Color.Gray
        End Select
    End Function

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer = Pl_Print.Location.X
        Dim y As Integer = Pl_Print.Location.Y
        Dim width As Integer = Pl_Print.Size.Width
        Dim height As Integer = Pl_Print.Size.Height

        Dim bounds As New Rectangle(x, y, width, height)

        Dim img As New Bitmap(width, height)

        Pl_Print.DrawToBitmap(img, bounds)
        Dim p As New Point(100, 100)
        e.PageSettings.Landscape = True
        img.RotateFlip(RotateFlipType.Rotate270FlipNone)
        e.Graphics.DrawImage(img, p)
    End Sub

    Private Sub Btn_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Print.Click
        Btn_Print.Visible = False
        PrintDocument1.PrinterSettings.DefaultPageSettings.Landscape = False
        PrintDocument1.Print()
        Btn_Print.Visible = True
    End Sub
End Class