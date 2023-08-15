Public Class Frm_WorkForm_Edit
    Dim _Ts_Sum_NafarSat As New TimeSpan
    Dim _Ts_Sum_EzafeKareFormKar As New TimeSpan
    Dim _Ts_Sum_EzafeKarTaradod As New TimeSpan
    Dim Srl_EditedUser As String = "-1"
    Dim _dr_details As DataRow = Nothing
    Dim EditedByUser As Boolean
    Dim isTatil As Boolean = False
    Dim isExtraTatil As Boolean = False
    Public Property dr_details() As DataRow
        Get
            Return _dr_details
        End Get
        Set(ByVal value As DataRow)
            _dr_details = value
        End Set
    End Property
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            btn_Save_Click(Nothing, Nothing)
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub
    Public Sub New(ByVal TarikhSabt As String, _
                    ByVal WorkFormNo As String, ByVal WorkFormTarikh As String, _
                    ByVal Srl_EditedUser As String, ByVal Srl_CodeHazine As Integer, _
                    ByVal Srl_PostFrom As Integer, ByVal Srl_PostTo As Integer, _
                    ByVal Srl_Vahed As Integer, ByVal dr_details As DataRow, ByVal EditedByUser As Boolean, _
                    ByVal beginwork As TimeSpan, ByVal Endwork As TimeSpan, ByVal WorkDis As String, _
                    ByVal TardodeYEtarfe As Boolean, _
                    ByVal TardodeDotarfe As Boolean, _
                    ByVal TardodeBargashttarfe As Boolean)
        InitializeComponent()

        Me.Pm_WorkDisTableAdapter.Fill(Me.Ds_Pm.Pm_WorkDis)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_HazineCodeTableAdapter.Fill(Me.Ds_Pm.Pm_HazineCode, 1)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        ' txt_no.Value = No
        txt_Tarikh.Value = TarikhSabt
        txt_FromKarNo.Value = WorkFormNo
        txt_FormKarTarikh.Value = WorkFormTarikh
        Me.Srl_EditedUser = Srl_EditedUser
        Me.EditedByUser = EditedByUser

        If Srl_EditedUser <> "-1" Then
            cmb_Ashkhas.OpenOnFoucus = False
            cmb_Ashkhas.SelectedValue = Srl_EditedUser
        Else
            For Each Obj As Control In gbx_Fields.Controls
                If Not TypeOf Obj Is LookupBox Then
                    Obj.Enabled = False
                End If
            Next
            cmb_Ashkhas.Enabled = True
        End If

        If EditedByUser Then
            cmb_HazineCode.SelectedValue = dr_details("Srl_HazineCode")
            Cmb_PostFrom.SelectedValue = dr_details("Srl_Pm_Post_From")
            Cmb_PostTo.SelectedValue = dr_details("Srl_Pm_Post_To")
            cmb_Vahed.SelectedValue = dr_details("Srl_Pm_Vahed")
            txt_WorkDis.Value = dr_details("WorkFormDis")
            txt_dis.Value = dr_details("Dis")
            ts_BeginWork.Value = dr_details("BeginWorkSat")
            ts_EndWork.Value = dr_details("EndWorkSat")
            ts_ZamaneKhroj.Value = dr_details("KhorojSat")

            If dr_details("TardodeDotarfe") = 1 Then
                Rbtn_Yektarafe.Checked = True
            ElseIf dr_details("TardodeDotarfe") = 2 Then
                rbtn_Dotarafe.Checked = True
            Else
                rbtn_taradodBargasht.Checked = True
            End If

            'rbtn_Dotarafe.Checked = CType(dr_details("TardodeDotarfe"), Boolean)
            rbtn_HamanRoz.Checked = CType(dr_details("HarkatHamanRoz"), Boolean)
            txt_dis.Value = dr_details("Dis")
            txt_WorkDis.Value = dr_details("WorkFormDis")
        Else
            cmb_HazineCode.SelectedValue = Srl_CodeHazine
            Cmb_PostFrom.SelectedValue = Srl_PostFrom
            Cmb_PostTo.SelectedValue = Srl_PostTo
            cmb_Vahed.SelectedValue = Srl_Vahed
            ts_BeginWork.time = beginwork
            ts_EndWork.time = Endwork
            txt_WorkDis.Value = WorkDis

            rbtn_Dotarafe.Checked = TardodeDotarfe
            rbtn_taradodBargasht.Checked = TardodeBargashttarfe
            Rbtn_Yektarafe.Checked = TardodeYEtarfe
        End If
        btn_Cal_Click(Nothing, Nothing)
    End Sub
    Private Sub btn_Cal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cal.Click
        _Ts_Sum_NafarSat = New TimeSpan
        _Ts_Sum_EzafeKareFormKar = New TimeSpan
        _Ts_Sum_EzafeKarTaradod = New TimeSpan

        Ts_NafarSat.time = New TimeSpan
        ts_EzafeKareFormKar.time = New TimeSpan
        ts_EzafeKarTaradod.time = New TimeSpan
        isExtraTatil = False
        '####################################hazf shode 24-12-93
        'If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", txt_FormKarTarikh.Value) > 0) Then
        '    isTatil = True
        '    NewCalcHolyDay(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0))
        '    calcTaradod(True)
        'Else
        '    isTatil = False
        '    Dim chk As Object = BaseDataObject.DataAccess.ExecScalar("select ispm from pm_workdis where srl=" + cmb_PmWorkDis.SelectedValue.ToString)

        '    If CType(chk, Boolean) = True Then
        '        If ts_BeginWork.time.Hours < 8 Then
        '            Add_EzafeKareFormKar(New TimeSpan(1, 0, 0))
        '        End If
        '    End If
        '    NewCalc(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0))
        '    calcTaradod(False)
        'End If
        '##################################ta inja hazf shode
        '-------------------------------------ezafe shode 24-12-93
        If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", txt_FormKarTarikh.Value) > 0) Then
            isTatil = True
            Dim temp As String = PublicFunction.GetDeyOfWeek(txt_FormKarTarikh.Value.ToString())
            If Not temp.Contains("جمع") And Not temp.Contains("پنج") Then
                isExtraTatil = True
            End If
            NewCalcHolyDay(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0))
            calcTaradod(True)
        Else
            isTatil = False
            If cmb_PmWorkDis.SelectedValue Is Nothing Then
                Return
            End If

            Dim dr_WorkForm_Dis As DataRow = BaseDataObject.DataAccess.GetRow("select * from pm_workdis where srl=" + cmb_PmWorkDis.SelectedValue.ToString)
            If CType(dr_WorkForm_Dis("IsPm"), Boolean) = True Then

                Dim begin_Temp As New TimeSelect
                begin_Temp.Value = dr_WorkForm_Dis("FromSat").ToString

                Dim Duration_Temp As New TimeSelect
                Duration_Temp.Value = dr_WorkForm_Dis("Duration").ToString

                If ts_BeginWork.time.ToString < begin_Temp.Value Then
                    Add_EzafeKareFormKar(New TimeSpan(Duration_Temp.Hour, Duration_Temp.Minutes, 0))
                End If
            End If
            If CType(dr_WorkForm_Dis("IsPmmain"), Boolean) = True Then
                Dim temp As New TimeSpan
                temp = ts_EndWork.time.Subtract(ts_BeginWork.time)
                Dim t As Integer = temp.Hours * 60 + temp.Minutes
                If 360 <= t Then
                    NewCalc(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0), False)
                Else
                    NewCalc(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0), True)
                End If
            Else
                NewCalc(False, New TimeSpan(0, 0, 0), New TimeSpan(0, 0, 0), False)
            End If
            calcTaradod(False)
        End If
        '---------------------------------------------------tainja ezafe shode 24-12-93
        'calc nafar sa@
        Dim result1 As New TimeSpan
        result1 = ts_EndWork.time.Subtract(ts_BeginWork.time)
        Add_Sum_NafarSat(result1)

        btn_Save.Focus()

    End Sub
    Function GetMazadEzafeKar() As String
        Dim sampleTimspan As New TimeSpan(0, 0, 0)

        If isTatil Then
            Dim tstemp_total As New TimeSpan( _
            Integer.Parse(PublicFunction.GetHour(Setting.MazadEzafekar_HolyDay.PropValue.ToString())), _
            Integer.Parse(PublicFunction.GetMin(Setting.MazadEzafekar_HolyDay.PropValue.ToString())), 0)

            Dim MazadEzafekar_HolyDay As TimeSpan = _Ts_Sum_EzafeKareFormKar.Add(_Ts_Sum_EzafeKarTaradod).Subtract(tstemp_total)
            If MazadEzafekar_HolyDay > sampleTimspan Then
                Return PublicFunction.GetSaat(MazadEzafekar_HolyDay)
            End If
        Else
            Dim tstemp_total As New TimeSpan( _
            Integer.Parse(PublicFunction.GetHour(Setting.MazadEzafekar_Normal.PropValue.ToString())), _
            Integer.Parse(PublicFunction.GetMin(Setting.MazadEzafekar_Normal.PropValue.ToString())), 0)

            Dim MazadEzafekar_Normal As TimeSpan = _Ts_Sum_EzafeKareFormKar.Add(_Ts_Sum_EzafeKarTaradod).Subtract(tstemp_total)
            If MazadEzafekar_Normal > sampleTimspan Then
                Return PublicFunction.GetSaat(MazadEzafekar_Normal)
            End If
        End If
        Return "00:00"
    End Function
    Sub calcTaradod(ByVal IsHollyDay As Boolean)
        Dim h As Double = CDbl((txt_Distance.Value) * 60 / Setting.EzafeKarTaradodBound.PropValue)

        'If txt_Distance.Value <> 0 And _
        '   txt_Distance.Value > (Setting.MaxTaradodBound.PropValue) Then
        If txt_Distance.Value > (Setting.MaxTaradodBound.PropValue) Then
            Dim srl_DayOfWeek As Integer = GetDayeOfWeek(CInt(PublicFunction.GetDAte(txt_FormKarTarikh.Value.ToString).DayOfWeek))

            Dim Ts_beginWorkOnThisDAte As New TimeSelect

            Dim obj As Object = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(fromsat,'00:00:00')  FROM dbo.Pm_WorkForm_Formula " & _
    " WHERE  Srl_DayOfWeak=" + srl_DayOfWeek.ToString + " and IsTaradod=1 and ImportantSat=1 " + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString)

            If obj Is Nothing Then
                Ts_beginWorkOnThisDAte.Value = "00:00:00"
            Else
                Ts_beginWorkOnThisDAte.Value = obj.ToString
            End If

            Dim tmp_ordeJadid As TimeSpan = ts_BeginWork.time.Subtract(New TimeSpan(0, CInt(h), 0))

            If Ts_beginWorkOnThisDAte.time < tmp_ordeJadid Then
                'etefaghi dar in halat nemiofte
                ts_ZamaneKhroj.Value = tmp_ordeJadid.ToString
                If rbtn_taradodBargasht.Checked Then
                    ts_ZamaneKhroj.Value = ts_EndWork.Value
                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                ElseIf rbtn_Dotarafe.Checked Then
                    'ts_ZamaneKhroj.Value = ts_EndWork.Value
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_ZamaneKhroj.time, ts_BeginWork.time)
                    Else
                        NewCalc(True, ts_ZamaneKhroj.time, ts_BeginWork.time, False)
                    End If

                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    If tmp.Days > 0 Then
                        tmp = New TimeSpan(23, 59, 0)
                    End If
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                ElseIf Rbtn_Yektarafe.Checked Then
                    'ts_ZamaneKhroj.Value = "16:00:00"
                    'Dim prevDate As String = FindPreviosDate()

                    If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", txt_FormKarTarikh.Value) > 0) Then
                        NewCalcHolyDay(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)), txt_FormKarTarikh.Value)
                    Else
                        NewCalc(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)), False)
                    End If
                    ''az zaman khoroj ta shoro to formol 

                    ''ts_ZamaneKhroj.Value = ts_EndWork.Value
                    ''Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    ''If IsHollyDay Then
                    ''    NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    ''Else
                    ''    NewCalc(True, ts_EndWork.time, tmp)
                    ''End If
                    '_Ts_Sum_EzafeKarTaradod = New TimeSpan(0, 0, 0)
                    'Add_Sum_EzafeKarTaradod(_Ts_Sum_EzafeKarTaradod)
                End If
            Else
                'dar in halat sate ezafe kar dar sa@ ghanonie kar nist 
                rbtn_RozeGhabl.Checked = True

                If rbtn_Dotarafe.Checked Then
                    ts_ZamaneKhroj.Value = "16:00:00"

                    'chon 16 roze ghable bayad tarikh roze ghabl dar biad va ba oon mohasebe taradod anjam beshe
                    Dim prevDate As String = FindPreviosDate()

                    'mohasebe az zamane khoroj
                    Dim tmp2 As TimeSpan = ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0))
                    If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", prevDate) > 0) Then
                        NewCalcHolyDay(True, ts_ZamaneKhroj.time, tmp2, prevDate)
                    Else
                        NewCalc(True, ts_ZamaneKhroj.time, tmp2, True, prevDate)
                    End If

                    'mohasebe az zamane payane kar
                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                ElseIf Rbtn_Yektarafe.Checked Then
                    ts_ZamaneKhroj.Value = "16:00:00"
                    'Dim tmp As TimeSpan = ts_EndWork.time.Add(New TinemimeSpan(0, CInt(h), 0))
                    'NewCalc(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)))

                    'chon 16 roze ghable bayad tarikh roze ghabl dar biad va ba oon mohasebe taradod anjam beshe
                    Dim prevDate As String = FindPreviosDate()

                    If (BaseDataObject.DataAccess.ExistNum("Pm_Taghvim", "Tarikh", prevDate) > 0) Then
                        NewCalcHolyDay(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)), prevDate)
                    Else
                        NewCalc(True, ts_ZamaneKhroj.time, ts_ZamaneKhroj.time.Add(New TimeSpan(0, CInt(h), 0)), False, prevDate)
                    End If

                ElseIf rbtn_taradodBargasht.Checked Then
                    ts_ZamaneKhroj.Value = ts_EndWork.Value
                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                End If
            End If
        Else
            If rbtn_Dotarafe.Checked Or Rbtn_Yektarafe.Checked Then
                ts_ZamaneKhroj.time = ts_BeginWork.time.Subtract(New TimeSpan(0, CInt(h), 0))
                If IsHollyDay Then
                    NewCalcHolyDay(True, ts_ZamaneKhroj.time, ts_BeginWork.time)
                Else
                    NewCalc(True, ts_ZamaneKhroj.time, ts_BeginWork.time, False)
                End If

                If rbtn_Dotarafe.Checked Then
                    Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))

                    If IsHollyDay Then
                        NewCalcHolyDay(True, ts_EndWork.time, tmp)
                    Else
                        NewCalc(True, ts_EndWork.time, tmp, False)
                    End If
                End If
            ElseIf rbtn_taradodBargasht.Checked Then
                ts_ZamaneKhroj.Value = ts_EndWork.Value
                Dim tmp As TimeSpan = ts_EndWork.time.Add(New TimeSpan(0, CInt(h), 0))
                If IsHollyDay Then
                    NewCalcHolyDay(True, ts_EndWork.time, tmp)
                Else
                    NewCalc(True, ts_EndWork.time, tmp, False)
                End If
            End If
        End If
    End Sub
    Function FindPreviosDate() As String
        Dim tmp_roze_ghable_tarikh As String = txt_FormKarTarikh.Value
        Dim tmp_roz As String = tmp_roze_ghable_tarikh.Remove(0, tmp_roze_ghable_tarikh.Length - 2)
        Dim tmp_Mah As String = tmp_roze_ghable_tarikh.Remove(0, tmp_roze_ghable_tarikh.Length - 5)
        Dim tmp_sal As String = tmp_roze_ghable_tarikh.Remove(4, tmp_roze_ghable_tarikh.Length - 4)
        tmp_Mah = tmp_Mah.Remove(2, 3)
        Dim roz_int As Integer = CType(tmp_roz, Integer) - 1
        If roz_int = 0 Then
            If CType(tmp_Mah, Integer) = 1 Then
                roz_int = 29
                tmp_Mah = "12"
                tmp_sal = CType(tmp_sal, Integer)
            ElseIf CType(tmp_Mah, Integer) < 7 Then
                tmp_Mah = CType(tmp_Mah, Integer) - 1
                tmp_Mah = tmp_Mah.PadLeft(2, "0")
                roz_int = 31
            ElseIf CType(tmp_Mah, Integer) > 6 Then
                tmp_Mah = CType(tmp_Mah, Integer) - 1
                tmp_Mah = tmp_Mah.PadLeft(2, "0")
                roz_int = 30
            End If
        End If
        Dim result_tarikh As String = tmp_sal + "/" + tmp_Mah + "/" + roz_int.ToString.PadLeft(2, "0")
        Return result_tarikh
    End Function
    Sub NewCalc(ByVal IsTaradod As Boolean, ByVal _BeginWork As TimeSpan, ByVal _EndWork As TimeSpan, ByVal IsNoPm As Boolean, Optional ByVal tarikh As String = "")

        Dim BeginWork As New TimeSpan
        Dim EndWork As New TimeSpan
        Dim WorkOnThisTarikh As String = ""

        If tarikh = "" Then
            WorkOnThisTarikh = txt_FormKarTarikh.Value
        Else
            WorkOnThisTarikh = tarikh
        End If

        If _BeginWork.ToString <> "00:00:00" And _EndWork.ToString <> "00:00:00" Then
            BeginWork = _BeginWork
            EndWork = _EndWork
        Else
            BeginWork = ts_BeginWork.time
            EndWork = ts_EndWork.time
        End If

        Dim tmp_Ezafekar As New TimeSpan
        Dim srl_DayOfWeek As Integer = GetDayeOfWeek(CInt(PublicFunction.GetDAte(WorkOnThisTarikh).DayOfWeek))

        Dim S_Taradod As String = 0

        If IsTaradod Then
            S_Taradod = "1"
        Else
            S_Taradod = "0"
        End If

        Dim MaxEndOfWorkOnThisDayeTmp As String = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(Max(tosat),'00:00:00') FROM dbo.Pm_WorkForm_Formula " & _
            " WHERE  Srl_DayOfWeak=" + srl_DayOfWeek.ToString + " and IsTaradod=" + S_Taradod & _
            " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString)
        If MaxEndOfWorkOnThisDayeTmp = "00:00:00" Then
            If IsTaradod Then
                MessageBoxFa.Show("براي اين روز فرمول تردد تعريف نشده")
            Else
                MessageBoxFa.Show("براي اين روز فرمول اضافه کار تعريف نشده")
            End If
            Return
        End If

        Dim ts As New TimeSelect
        ts.Value = MaxEndOfWorkOnThisDayeTmp
        Dim MaxEndOfWorkOnThisDaye As TimeSpan = ts.time

        Dim drOnThisDaye As DataRow = BaseDataObject.DataAccess.GetRow("SELECT * FROM dbo.Pm_WorkForm_Formula " & _
" WHERE    (toSat > '" + BeginWork.ToString + "' and Srl_DayOfWeak=" + srl_DayOfWeek.ToString & _
 " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString + ") ORDER BY FromSat")

        If drOnThisDaye Is Nothing Then
            If IsTaradod Then
                MessageBoxFa.Show("براي ساعت شروع اين روز فرمول تردد تعريف نشده")
            Else
                MessageBoxFa.Show("براي ساعت شروع اين روز فرمول اضافه کار تعريف نشده")
            End If
            Return
        End If

        Do
            Dim ts_endThisRow As New TimeSelect
            ts_endThisRow.Value = drOnThisDaye("toSat").ToString
            Dim tmp_Sub As New TimeSpan

            If ts_endThisRow.Value.ToString > EndWork.ToString Then
                tmp_Sub = EndWork.Subtract(BeginWork)
            Else
                tmp_Sub = ts_endThisRow.time.Subtract(BeginWork)
            End If

            Dim result As New TimeSpan
            Dim tmp_min As Integer = (tmp_Sub.Minutes * CDbl(drOnThisDaye("Zarib").ToString))
            result = result.Add(New TimeSpan(0, tmp_min, 0))
            tmp_min = (tmp_Sub.Hours * 60 * CDbl(drOnThisDaye("Zarib").ToString))
            result = result.Add(New TimeSpan(0, tmp_min, 0))

            If IsTaradod Then
                Add_Sum_EzafeKarTaradod(result)
            ElseIf (Not IsNoPm Or (IsNoPm And Not CType(drOnThisDaye("ImportantSat"), Boolean))) Then
                Add_EzafeKareFormKar(result)
            End If

            BeginWork = ts_endThisRow.time

            If (drOnThisDaye("ToSat").ToString >= EndWork.ToString) Then
                Exit Do
            End If

            drOnThisDaye = BaseDataObject.DataAccess.GetRow("SELECT * FROM dbo.Pm_WorkForm_Formula " & _
" WHERE    (toSat > '" + BeginWork.ToString + "' and Srl_DayOfWeak=" + srl_DayOfWeek.ToString & _
 " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString + ") ORDER BY FromSat")

        Loop While True
    End Sub
 
 
 
    Sub NewCalcHolyDay(ByVal IsTaradod As Boolean, ByVal _BeginWork As TimeSpan, ByVal _EndWork As TimeSpan, Optional ByVal tarikh As String = "")
        'If cmb_cancelCuse.SelectedValue > 0 Then
        '    Dim temp As New TimeSpan(8, 0, 0)
        '    Add_EzafeKareFormKar(temp)
        '    Return
        'End If
        If tarikh <> "" Then
            Dim temp As String = PublicFunction.GetDeyOfWeek(tarikh)
            If Not temp.Contains("جمع") And Not temp.Contains("پنج") Then
                isExtraTatil = True
            End If
        End If

        Dim BeginWork As New TimeSpan
        Dim EndWork As New TimeSpan

        Dim WorkOnThisTarikh As String = ""

        If tarikh = "" Then
            WorkOnThisTarikh = txt_FormKarTarikh.Value
        Else
            WorkOnThisTarikh = tarikh
        End If

        If _BeginWork.ToString <> "00:00:00" And _EndWork.ToString <> "00:00:00" Then
            BeginWork = _BeginWork
            EndWork = _EndWork
        Else
            BeginWork = ts_BeginWork.time
            EndWork = ts_EndWork.time
        End If

        Dim tmp_Ezafekar As New TimeSpan
        Dim srl_DayOfWeek As Integer = GetDayeOfWeek(CInt(PublicFunction.GetDAte(WorkOnThisTarikh).DayOfWeek))

        Dim S_Taradod As String = 0

        If IsTaradod Then
            S_Taradod = "1"
        Else
            S_Taradod = "0"
        End If

        Dim MaxEndOfWorkOnThisDayeTmp As String = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(Max(tosat),'00:00:00') FROM dbo.Pm_WorkForm_Formula " & _
" WHERE  Srl_DayOfWeak=" + srl_DayOfWeek.ToString + " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString)
        If MaxEndOfWorkOnThisDayeTmp = "00:00:00" Then
            If IsTaradod Then
                MessageBoxFa.Show("براي اين روز فرمول تردد تعريف نشده")
            Else
                MessageBoxFa.Show("براي اين روز فرمول اضافه کار تعريف نشده")
            End If
            Return
        End If

        Dim ts As New TimeSelect
        ts.Value = MaxEndOfWorkOnThisDayeTmp
        Dim MaxEndOfWorkOnThisDaye As TimeSpan = ts.time

        Dim drOnThisDaye As DataRow = BaseDataObject.DataAccess.GetRow("SELECT * FROM dbo.Pm_WorkForm_Formula " & _
" WHERE    (toSat > '" + BeginWork.ToString + "' and Srl_DayOfWeak=" + srl_DayOfWeek.ToString & _
 " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString + ") ORDER BY FromSat")

        If drOnThisDaye Is Nothing Then
            If IsTaradod Then
                MessageBoxFa.Show("براي ساعت شروع اين روز فرمول تردد تعريف نشده")
            Else
                MessageBoxFa.Show("براي ساعت شروع اين روز فرمول اضافه کار تعريف نشده")
            End If
            Return
        End If

        Do
            Dim ts_endThisRow As New TimeSelect
            ts_endThisRow.Value = drOnThisDaye("toSat").ToString
            Dim tmp_Sub As New TimeSpan

            If ts_endThisRow.Value.ToString > EndWork.ToString Then
                tmp_Sub = EndWork.Subtract(BeginWork)
            Else
                tmp_Sub = ts_endThisRow.time.Subtract(BeginWork)
            End If

            Dim result As New TimeSpan

            If Not isExtraTatil Then
                Dim tmp_min As Integer = (tmp_Sub.Minutes * CDbl(drOnThisDaye("Zarib").ToString))
                result = result.Add(New TimeSpan(0, tmp_min, 0))
                tmp_min = (tmp_Sub.Hours * 60 * CDbl(drOnThisDaye("Zarib").ToString))
                result = result.Add(New TimeSpan(0, tmp_min, 0))
            Else
                Dim tmp_min As Integer = (tmp_Sub.Minutes * Setting.HolidayZarib.PropValue)
                result = result.Add(New TimeSpan(0, tmp_min, 0))
                tmp_min = (tmp_Sub.Hours * 60 * Setting.HolidayZarib.PropValue)
                result = result.Add(New TimeSpan(0, tmp_min, 0))
            End If
            If IsTaradod Then
                Add_Sum_EzafeKarTaradod(result)
            Else
                Add_EzafeKareFormKar(result)
            End If

            BeginWork = ts_endThisRow.time

            If (drOnThisDaye("ToSat").ToString >= EndWork.ToString) Then
                Exit Do
            End If

            drOnThisDaye = BaseDataObject.DataAccess.GetRow("SELECT * FROM dbo.Pm_WorkForm_Formula " & _
" WHERE    (toSat > '" + BeginWork.ToString + "' and Srl_DayOfWeak=" + srl_DayOfWeek.ToString & _
 " and IsTaradod=" + S_Taradod + " and Srl_Pm_WorkForm_Formula_Profile=" + Srl_WorkForm_Profile.ToString + ") ORDER BY FromSat")

        Loop While True
    End Sub
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        dr_details = BaseDataObject.DataAccess.NewRow("Pm_WorkFrom_Detail")
        dr_details("Srl_Pm_Post_From") = Cmb_PostFrom.SelectedValue
        dr_details("Srl_Pm_Post_To") = Cmb_PostTo.SelectedValue
        dr_details("Srl_Pm_Vahed") = cmb_Vahed.SelectedValue
        dr_details("Srl_Pm_WorkDis") = cmb_PmWorkDis.SelectedValue
        dr_details("Srl_HazineCode") = cmb_HazineCode.SelectedValue
        dr_details("WorkFormDis") = txt_WorkDis.Value
        dr_details("Dis") = txt_dis.Value
        dr_details("SatKAr") = GetSaat(_Ts_Sum_NafarSat)
        dr_details("EzafeKAr") = GetSaat(_Ts_Sum_EzafeKareFormKar)
        dr_details("EzafeKarTaradod") = GetSaat(_Ts_Sum_EzafeKarTaradod)
        dr_details("HarkatHamanRoz") = rbtn_HamanRoz.Checked

        If Rbtn_Yektarafe.Checked Then
            dr_details("TardodeDotarfe") = 1
        ElseIf rbtn_Dotarafe.Checked Then
            dr_details("TardodeDotarfe") = 2
        Else
            dr_details("TardodeDotarfe") = 3
        End If

        'dr_details("TardodeDotarfe") = rbtn_Dotarafe.Checked
        dr_details("BeginWorkSat") = ts_BeginWork.time.ToString
        dr_details("EndWorkSat") = ts_EndWork.time.ToString
        dr_details("KhorojSat") = ts_ZamaneKhroj.time.ToString
        dr_details("MazadEzafeKar") = GetMazadEzafeKar()
        Close()
    End Sub
    Function GetSaat(ByVal t As TimeSpan) As String
        Dim H As String = t.ToString.Substring(0, t.ToString.IndexOf(":"))
        Dim M As String = t.ToString.Substring(t.ToString.IndexOf(":") + 1, 2)
        Return H + ":" + M
    End Function
    Sub Add_Sum_NafarSat(ByVal t As TimeSpan)
        _Ts_Sum_NafarSat = _Ts_Sum_NafarSat.Add(t)
        Ts_NafarSat.ResetResult()
        Ts_NafarSat.time = _Ts_Sum_NafarSat
    End Sub
    Sub Add_Sum_EzafeKarTaradod(ByVal t As TimeSpan)
        _Ts_Sum_EzafeKarTaradod = _Ts_Sum_EzafeKarTaradod.Add(t)
        ts_EzafeKarTaradod.ResetResult()
        ts_EzafeKarTaradod.time = _Ts_Sum_EzafeKarTaradod
    End Sub
    Sub Add_EzafeKareFormKar(ByVal t As TimeSpan)
        _Ts_Sum_EzafeKareFormKar = _Ts_Sum_EzafeKareFormKar.Add(t)
        ts_EzafeKareFormKar.ResetResult()
        ts_EzafeKareFormKar.time = _Ts_Sum_EzafeKareFormKar
    End Sub
    Function GetDayeOfWeek(ByVal i As Integer) As Integer
        Select Case i
            Case 0 'yeshanbe
                Return 2
            Case 1 ' 2shanbe
                Return 3
            Case 2 ' 3 shanbe
                Return 4
            Case 3 '4 shanbe
                Return 5
            Case 4 '5 shanbe
                Return 6
            Case 5 'jome
                Return 7
            Case 6 'shanbe
                Return 1
        End Select
    End Function
    Private Sub Cmb_PostTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_PostTo.SelectedIndexChanged
        SetDistance()
    End Sub
    Private Sub Cmb_PostFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_PostFrom.SelectedIndexChanged
        SetDistance()
    End Sub
    Sub SetDistance()
        If Cmb_PostFrom.SelectedValue Is Nothing Or Cmb_PostTo.SelectedValue Is Nothing Then
            Return
        End If
        Dim obj As Object = getDistance()
        If obj Is Nothing Then
            txt_Distance.Value = 0
        Else
            txt_Distance.Value = obj
        End If
    End Sub
    Function getDistance() As Object
        Try
            Return BaseDataObject.DataAccess.ExecScalar("select Distance from Pm_Distance where Srl_Post1=" _
                                                                          + Cmb_PostFrom.SelectedValue.ToString + " and Srl_Post2=" + Cmb_PostTo.SelectedValue.ToString)
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
        End Try
        Return Nothing
    End Function
    Private Sub Frm_WorkForm_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        SetDistance()
        cmb_Ashkhas.Focus()
    End Sub
    Public Function GetLookUpName() As String
        Return cmb_Ashkhas.Text
    End Function
    Dim Srl_WorkForm_Profile As Integer = 1
    Private Sub txt_Tarikh_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Tarikh.ValueChanged
        If txt_FormKarTarikh.Value.ToString.Length = 10 Then
            lbl_RozeHafte.Text = PublicFunction.GetDeyOfWeek(txt_FormKarTarikh.Value.ToString)
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_WorkForm_Formula_Profile", _
            "BeginDate<'" + txt_FormKarTarikh.Value.ToString + "' and EndDate>'" & _
                    txt_FormKarTarikh.Value.ToString + "' and Active=1 and Srl<>1")
            If dr Is Nothing Then
                txt_ProfileTarikh.Text = "در اين بازه زماني پروفايلي تعريف نشده"
                Srl_WorkForm_Profile = 1
            Else
                txt_ProfileTarikh.Text = dr("Name").ToString
                Srl_WorkForm_Profile = dr("Srl")
            End If
        End If
    End Sub
End Class