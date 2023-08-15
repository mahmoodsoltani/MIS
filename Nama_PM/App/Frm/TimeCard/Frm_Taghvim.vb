Public Class Frm_Taghvim
    Dim _ShowMonth As Integer
    Dim _ShowYear As Integer
    Dim _ShowDay As Integer
    Dim _Week As Integer = 1
    Dim _Lb As Label
    Dim Months As String() = {"فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"}

    Private Function Farsi(ByVal Input As String) As String
        Return Input.Replace("0", "۰").Replace("1", "۱").Replace("2", "۲").Replace("3", "۳").Replace("4", "۴").Replace("5", "۵").Replace("6", "۶").Replace("7", "۷").Replace("8", "۸").Replace("9", "۹")
    End Function

    Private Sub Frm_Taghvim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HideAll()
        txt_Today.Text += " " + Farsi(Setting.TarikheJary)
        LB_DATE.Text = Setting.TarikheJary
        LoadBoard()
    End Sub

    Public Sub HideAll()
        For i As Integer = 1 To 7
            Calender.Controls("lb_1" + i.ToString()).Visible = False
            Calender.Controls("lb_5" + i.ToString()).Visible = False
            Calender.Controls("lb_6" + i.ToString()).Visible = False
        Next
    End Sub

    Public Sub LoadBoard()
        Dim CurDay As FarsiDays
        Dim Firstday As DateTime
        Dim Pc As New System.Globalization.PersianCalendar()
        _ShowYear = CInt(LB_DATE.Text.Substring(0, 4))
        _ShowMonth = CInt(LB_DATE.Text.Substring(5, 2))
        _ShowDay = CInt(LB_DATE.Text.Substring(8, 2))

        lb_MonthName.Text = Months(_ShowMonth - 1) + " " + Farsi(_ShowYear.ToString())
        Dim CurrentDate As DateTime = Pc.ToDateTime(_ShowYear, _ShowMonth, _ShowDay, 0, 0, 0, 0)

        If (Pc.GetDayOfMonth(CurrentDate) <> 1) Then
            Firstday = Pc.ToDateTime(_ShowYear, _ShowMonth, 1, 0, 0, 0, 0)
        Else
            Firstday = CurrentDate
        End If
        Select Case Firstday.DayOfWeek
            Case DayOfWeek.Saturday : CurDay = FarsiDays.Saturday
            Case DayOfWeek.Sunday : CurDay = FarsiDays.Sunday
            Case DayOfWeek.Monday : CurDay = FarsiDays.Monday
            Case DayOfWeek.Tuesday : CurDay = FarsiDays.Tuesday
            Case DayOfWeek.Wednesday : CurDay = FarsiDays.Wednesday
            Case DayOfWeek.Thursday : CurDay = FarsiDays.Thursday
            Case DayOfWeek.Friday : CurDay = FarsiDays.Friday
        End Select
        _Week = 1
        For i As Integer = 1 To Pc.GetDaysInMonth(_ShowYear, _ShowMonth)
            DrawDay(CurDay, i, (i = _ShowDay))
            CurDay = CType(CInt(CurDay) + 1, FarsiDays)
            If CurDay > FarsiDays.Friday Then
                CurDay = FarsiDays.Saturday
            End If
        Next
    End Sub

    Public Sub DrawDay(ByVal CurDay As FarsiDays, ByVal i As Integer, ByVal IsToday As Boolean)
        If _Week = 1 Or _Week = 6 Or _Week = 5 Then
            DirectCast(Calender.Controls("lb_" + _Week.ToString() + (CInt(CurDay) + 1).ToString()), Label).Visible = True
        End If
        DirectCast(Calender.Controls("lb_" + _Week.ToString() + (CInt(CurDay) + 1).ToString()), Label).Text = i.ToString()
        DirectCast(Calender.Controls("lb_" + _Week.ToString() + (CInt(CurDay) + 1).ToString()), Label).BackColor = Color.White

        Dim Count As Integer = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(count(*),0) from Pm_Taghvim where tarikh='" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(i < 10, "0" + i.ToString(), i.ToString()) + "'"))
        If CurDay = FarsiDays.Friday And Count < 1 Then
            BaseDataObject.DataAccess.ExecQuery("Insert Into Pm_Taghvim values('" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(i < 10, "0" + i.ToString(), i.ToString()) + "',2)")
        End If

        Count = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(count(*),0) from Pm_Taghvim where type=2 AND tarikh='" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(i < 10, "0" + i.ToString(), i.ToString()) + "'"))
        If Count > 0 Then
            DirectCast(Calender.Controls("lb_" + _Week.ToString() + (CInt(CurDay) + 1).ToString()), Label).BackColor = Color.Yellow
        End If

        Count = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(count(*),0) from Pm_Taghvim where type=3 AND tarikh='" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(i < 10, "0" + i.ToString(), i.ToString()) + "'"))
        If Count > 0 Then
            DirectCast(Calender.Controls("lb_" + _Week.ToString() + (CInt(CurDay) + 1).ToString()), Label).BackColor = Color.LightGreen
        End If

        If _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(i < 10, "0" + i.ToString(), i.ToString()) = Setting.TarikheJary Then
            DirectCast(Calender.Controls("lb_" + _Week.ToString() + (CInt(CurDay) + 1).ToString()), Label).ForeColor = Color.Red
        Else
            DirectCast(Calender.Controls("lb_" + _Week.ToString() + (CInt(CurDay) + 1).ToString()), Label).ForeColor = Color.MidnightBlue
        End If

        If CurDay = FarsiDays.Friday Then
            _Week = _Week + 1
        End If
    End Sub

    Private Sub lb_67_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_67.DoubleClick, lb_66.DoubleClick, lb_65.DoubleClick, lb_64.DoubleClick, lb_63.DoubleClick, lb_62.DoubleClick, lb_61.DoubleClick, lb_57.DoubleClick, lb_56.DoubleClick, lb_55.DoubleClick, lb_54.DoubleClick, lb_53.DoubleClick, lb_52.DoubleClick, lb_51.DoubleClick, lb_47.DoubleClick, lb_46.DoubleClick, lb_45.DoubleClick, lb_44.DoubleClick, lb_43.DoubleClick, lb_42.DoubleClick, lb_41.DoubleClick, lb_37.DoubleClick, lb_36.DoubleClick, lb_35.DoubleClick, lb_34.DoubleClick, lb_33.DoubleClick, lb_32.DoubleClick, lb_31.DoubleClick, lb_27.DoubleClick, lb_26.DoubleClick, lb_25.DoubleClick, lb_24.DoubleClick, lb_23.DoubleClick, lb_22.DoubleClick, lb_21.DoubleClick, lb_17.DoubleClick, lb_16.DoubleClick, lb_15.DoubleClick, lb_14.DoubleClick, lb_13.DoubleClick, lb_12.DoubleClick, lb_11.DoubleClick
        'Dim Count As Integer = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(count(*),0) from Pm_Taghvim where tarikh='" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(DirectCast(sender, Label).Text.Length < 2, "0" + DirectCast(sender, Label).Text, DirectCast(sender, Label).Text) + "'"))
        'If Count = 0 Then
        '    DirectCast(sender, Label).BackColor = Color.Yellow
        '    BaseDataObject.DataAccess.ExecQuery("Insert Into Pm_Taghvim values('" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(DirectCast(sender, Label).Text.Length < 2, "0" + DirectCast(sender, Label).Text, DirectCast(sender, Label).Text) + "')")
        'Else
        '    DirectCast(sender, Label).BackColor = Color.White
        '    BaseDataObject.DataAccess.ExecQuery("delete from Pm_Taghvim where tarikh='" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(DirectCast(sender, Label).Text.Length < 2, "0" + DirectCast(sender, Label).Text, DirectCast(sender, Label).Text) + "'")
        'End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Today.Click, Label1.Click
        For Each c As Control In Calender.Controls
            If TypeOf (c) Is Label Then
                DirectCast(c, Label).BackColor = Color.White
            End If
        Next
        HideAll()
        LB_DATE.Text = Setting.TarikheJary
        LoadBoard()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        HideAll()
        _ShowYear = CInt(LB_DATE.Text.Substring(0, 4))
        _ShowMonth = CInt(LB_DATE.Text.Substring(5, 2))
        _ShowDay = CInt(LB_DATE.Text.Substring(8, 2))

        _ShowMonth = _ShowMonth + 1
        If _ShowMonth > 12 Then
            _ShowMonth = 1
            _ShowYear = _ShowYear + 1
        End If
        LB_DATE.Text = _ShowYear.ToString() + "/" + IIf(_ShowMonth > 9, _ShowMonth.ToString(), "0" + _ShowMonth.ToString()) + "/" + IIf(_ShowDay > 9, _ShowDay.ToString(), "0" + _ShowDay.ToString())
        For Each c As Control In Calender.Controls
            If TypeOf (c) Is Label Then
                DirectCast(c, Label).BackColor = Color.White
            End If
        Next
        LoadBoard()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        HideAll()
        _ShowYear = CInt(LB_DATE.Text.Substring(0, 4))
        _ShowMonth = CInt(LB_DATE.Text.Substring(5, 2))
        _ShowDay = CInt(LB_DATE.Text.Substring(8, 2))

        _ShowMonth = _ShowMonth - 1
        If _ShowMonth < 1 Then
            _ShowMonth = 12
            _ShowYear = _ShowYear - 1
        End If
        LB_DATE.Text = _ShowYear.ToString() + "/" + IIf(_ShowMonth > 9, _ShowMonth.ToString(), "0" + _ShowMonth.ToString()) + "/" + IIf(_ShowDay > 9, _ShowDay.ToString(), "0" + _ShowDay.ToString())
        For Each c As Control In Calender.Controls
            If TypeOf (c) Is Label Then
                DirectCast(c, Label).BackColor = Color.White
            End If
        Next
        LoadBoard()
    End Sub

    Private Sub lb_11_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_11.MouseDown, lb_67.MouseDown, lb_66.MouseDown, lb_65.MouseDown, lb_64.MouseDown, lb_63.MouseDown, lb_62.MouseDown, lb_61.MouseDown, lb_57.MouseDown, lb_56.MouseDown, lb_55.MouseDown, lb_54.MouseDown, lb_53.MouseDown, lb_52.MouseDown, lb_51.MouseDown, lb_47.MouseDown, lb_46.MouseDown, lb_45.MouseDown, lb_44.MouseDown, lb_43.MouseDown, lb_42.MouseDown, lb_41.MouseDown, lb_37.MouseDown, lb_36.MouseDown, lb_35.MouseDown, lb_34.MouseDown, lb_33.MouseDown, lb_32.MouseDown, lb_31.MouseDown, lb_27.MouseDown, lb_26.MouseDown, lb_25.MouseDown, lb_24.MouseDown, lb_23.MouseDown, lb_22.MouseDown, lb_21.MouseDown, lb_17.MouseDown, lb_16.MouseDown, lb_15.MouseDown, lb_14.MouseDown, lb_13.MouseDown, lb_12.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right And TypeOf (sender) Is Label Then
            _Lb = DirectCast(sender, Label)
            LeftMenu.Show(sender, e.Location)
        End If
    End Sub

    Private Sub Free_Day_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Free_Day.Click
        _Lb.BackColor = Color.White
        BaseDataObject.DataAccess.ExecQuery("delete from Pm_Taghvim where tarikh='" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(_Lb.Text.Length < 2, "0" + _Lb.Text, _Lb.Text) + "'")
    End Sub

    Private Sub Rasmi_Holiday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rasmi_Holiday.Click
        _Lb.BackColor = Color.Yellow
        BaseDataObject.DataAccess.ExecQuery("delete from Pm_Taghvim where tarikh='" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(_Lb.Text.Length < 2, "0" + _Lb.Text, _Lb.Text) + "'")
        BaseDataObject.DataAccess.ExecQuery("Insert Into Pm_Taghvim values('" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(_Lb.Text.Length < 2, "0" + _Lb.Text, _Lb.Text) + "',2)")
    End Sub

    Private Sub Edari_Holiday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edari_Holiday.Click
        _Lb.BackColor = Color.LightGreen
        BaseDataObject.DataAccess.ExecQuery("delete from Pm_Taghvim where tarikh='" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(_Lb.Text.Length < 2, "0" + _Lb.Text, _Lb.Text) + "'")
        BaseDataObject.DataAccess.ExecQuery("Insert Into Pm_Taghvim values('" + _ShowYear.ToString() + "/" + IIf(_ShowMonth < 10, "0" + _ShowMonth.ToString(), _ShowMonth.ToString()) + "/" + IIf(_Lb.Text.Length < 2, "0" + _Lb.Text, _Lb.Text) + "',3)")
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class