Imports System.IO
Imports System.Data.OleDb
Imports System.Threading
Imports Microsoft.Office.Interop.Excel

Public Class ConvertDB
    Declare Function EndTask Lib "user32.dll" (ByVal hWnd As IntPtr) As Integer
    Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    Declare Function SetLastError Lib "kernel32.dll" (ByVal dwErrCode As Integer) As IntPtr
    Private Thread As New System.Threading.Thread(AddressOf Convert)
    Private Delegate Sub DelUpdateProgressBar(ByVal Value As Integer, ByVal Max As Integer)
    Private _DelUpdateProgressBar As New DelUpdateProgressBar(AddressOf UpdateProgressBar)
    Private Delegate Sub DelUpdateTxt(ByVal Value As String, ByVal Isdel As Boolean)
    Private _DelUpdateTxt As New DelUpdateTxt(AddressOf Updatetxt)
    Dim OLDBCon As OleDb.OleDbConnection

    Public Sub Convert(ByVal Path As Object)
        If txt_Addres.Value = "" Then
            MessageBoxFa.Show("لطفا فایل مورد نظر را انتخاب فرمائید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OLDBCon = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + OpenFileDialog1.FileName + ";User Id=admin;Password=;")
        If Not OLDBCon.State = ConnectionState.Open Then
            OLDBCon.Open()
        End If

        Dim ds2 As New DataSet()
        Dim da As New OleDbDataAdapter("select count(*) from jnags", OLDBCon)
        Dim countTotal As Integer = 0

        If Chk_EibForm.Checked Then
            da.Fill(ds2)
            countTotal = ds2.Tables(0).Rows(0)(0)
        End If

        If chk_WrokForm.Checked Then
            ds2.Clear()
            da = New OleDbDataAdapter("select count(*) from formkar", OLDBCon)
            da.Fill(ds2)
            countTotal += ds2.Tables(0).Rows(0)(0)
        End If

        If chk_Holiday.Checked Then
            ds2.Clear()
            da = New OleDbDataAdapter("select count(*) from date1 where d4='تعطيل'", OLDBCon)
            da.Fill(ds2)
            countTotal += ds2.Tables(0).Rows(0)(0)
        End If

        If chk_TimeCard.Checked Then
            ds2.Clear()
            da = New OleDbDataAdapter("select count(*) from setad", OLDBCon)
            da.Fill(ds2)
            countTotal += ds2.Tables(0).Rows(0)(0)
        End If

        If countTotal > 0 Then
            _DelUpdateProgressBar(0, countTotal)
        End If

        If chk_Holiday.Checked Then
            _DelUpdateTxt("شروع انتقال اطلاعات روزهای تعطیل", False)
            _DelUpdateTxt(vbNewLine + "===========================================", False)
            _DelUpdateTxt(vbNewLine + "Please Wait....", False)
            ConvertHoliday()
            _DelUpdateTxt(vbNewLine + "===========================================", False)
        End If
        If Chk_EibForm.Checked Then
            _DelUpdateTxt(vbNewLine + "شروع انتقال اطلاعات فرم نقص", False)
            _DelUpdateTxt(vbNewLine + "===========================================", False)
            _DelUpdateTxt(vbNewLine + "Please Wait....", False)
            ConvertEibForm()
            _DelUpdateTxt(vbNewLine + "===========================================", False)
        End If

        If chk_TimeCard.Checked Then
            _DelUpdateTxt(vbNewLine + "شروع انتقال اطلاعات تایم کارت", False)
            _DelUpdateTxt(vbNewLine + "===========================================", False)
            _DelUpdateTxt(vbNewLine + "Please Wait....", False)
            ConvertTimeCard()
            _DelUpdateTxt(vbNewLine + "===========================================", False)
        End If


        If chk_WrokForm.Checked Then
            _DelUpdateTxt(vbNewLine + "شروع انتقال اطلاعات فرم کار", False)
            _DelUpdateTxt(vbNewLine + "===========================================", False)
            _DelUpdateTxt(vbNewLine + "Please Wait....", False)
            _DelUpdateTxt(vbNewLine + "===========================================", False)
            ConvertWorkForm()
        End If
        _DelUpdateProgressBar(ProgressBar1.Maximum, ProgressBar1.Maximum)

        Thread.Abort()
    End Sub

    Public Function ConvertEibForm() As Boolean
        Dim Srl_EibMaster As Integer
        Dim NoConvertCount As Integer = 0
        Dim ExistCount As Integer = 0
        ' Dim Srl_eibFormPeiro As Integer
        If Not OLDBCon.State = ConnectionState.Open Then
            OLDBCon.Open()
        End If

        Dim dt As New OleDbDataAdapter("select * from jnags", OLDBCon)
        Dim ds As New DataSet()
        dt.Fill(ds)

        Dim Counter As Integer = 0
        Dim IsExistDt As System.Data.DataTable
        Dim EibForm As DataRow = BaseDataObject.DataAccess.NewRow("Pm_eibFormMaster")
        Dim Eibtype As DataRow = BaseDataObject.DataAccess.NewRow("Pm_eibFormDetails")
        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For Each dr As DataRow In ds.Tables(0).Rows
                Try

                    EibForm = BaseDataObject.DataAccess.NewRow("Pm_eibFormMaster")
                    IsExistDt = BaseDataObject.DataAccess.GetDataTable("select * from pm_eibFormMaster where (EibFormNumber=" + dr("radif").ToString() + ") OR (OriginalEibFormDate='" + dr("tfn").ToString() + "' and OrginalEibFormNumber='" + dr("sfn").ToString() + "' and Srl_Pm_Post=" + FindPost(dr("Post").ToString()).ToString() + ")")
                    If ProgressBar1.Value + 1 <= ProgressBar1.Maximum Then
                        _DelUpdateProgressBar(ProgressBar1.Value + 1, ProgressBar1.Maximum)
                    End If
                    If IsExistDt.Rows.Count > 0 Then
                        ExistCount = ExistCount + 1
                        Continue For
                    End If
                    Counter = Counter + 1
                    'EibForm("EibFormNumber") = BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(Eibformnumber)+1,1) from Pm_EibFormMaster ")
                    EibForm("EibFormNumber") = dr("radif").ToString()
                    If Not dr("ndate").ToString().Contains("_") Then
                        EibForm("EibFormDate") = dr("ndate").ToString()
                    End If
                    EibForm("OrginalEibFormNumber") = dr("sfn").ToString()
                    If Not dr("tfn").ToString().Contains("_") Then
                        EibForm("OriginalEibFormDate") = dr("tfn").ToString()
                    End If
                    EibForm("Srl_Pm_Post") = FindPost(dr("Post").ToString())
                    If Not dr("te").ToString().Contains("_") Then
                        EibForm("ReferenceDate") = dr("te").ToString()
                    End If
                    EibForm("Srl_Pm_Vahed") = FindVahed(dr("ev").ToString())
                    EibForm("Srl_Pm_Group") = FindGroup(dr("ngroup").ToString())
                    If Not dr("td").ToString().Contains("_") Then
                        EibForm("Receptiondate") = dr("td").ToString()
                    End If
                    EibForm("WorkFormNumber") = dr("sfk").ToString()
                    If Not dr("tr").ToString().Contains("_") Then
                        EibForm("EibFixdate") = dr("tr").ToString()
                    End If
                    EibForm("Workdis") = CurrectStr(dr("sk").ToString())
                    Srl_EibMaster = BaseDataObject.DataAccess.InsertWithLastId(EibForm, False)
                    If Srl_EibMaster > 0 Then
                        If Not dr("nn1") Is DBNull.Value And dr("nn1") <> "" Then
                            Eibtype("Srl_Pm_EibFormMaster") = Srl_EibMaster
                            Eibtype("Srl_Pm_EibType") = FindEibType(dr("nn1"))
                            Eibtype("EibDis") = CurrectStr(dr("shn1").ToString())
                            BaseDataObject.DataAccess.Insert(Eibtype, False)
                        End If
                        If Not dr("nn2") Is DBNull.Value And dr("nn2") <> "" Then
                            Eibtype("Srl_Pm_EibFormMaster") = Srl_EibMaster
                            Eibtype("Srl_Pm_EibType") = FindEibType(dr("nn2"))
                            Eibtype("EibDis") = CurrectStr(dr("shn2").ToString())
                            BaseDataObject.DataAccess.Insert(Eibtype, False)
                        End If
                        If Not dr("nn3") Is DBNull.Value And dr("nn3") <> "" Then
                            Eibtype("Srl_Pm_EibFormMaster") = Srl_EibMaster
                            Eibtype("Srl_Pm_EibType") = FindEibType(dr("nn3"))
                            Eibtype("EibDis") = CurrectStr(dr("shn3").ToString())
                            BaseDataObject.DataAccess.Insert(Eibtype, False)
                        End If

                    End If
                Catch ex As Exception
                    NoConvertCount = NoConvertCount + 1
                End Try
            Next
            _DelUpdateTxt("تعداد " + Counter.ToString() + "فرم نقص با موفقیت انتقال داده شد", False)
            _DelUpdateTxt("تعداد " + NoConvertCount.ToString() + "فرم نقص با موفقیت انتقال داده نشد", False)
            _DelUpdateTxt("تعداد " + ExistCount.ToString() + "فرم نقص تکراری در سیستم", False)
            '_DelUpdateProgressBar(ProgressBar1.Maximum, ProgressBar1.Maximum)
        End If
    End Function

    Public Function ConvertHoliday() As Boolean
        Try
            If Not OLDBCon.State = ConnectionState.Open Then
                OLDBCon.Open()
            End If

            Dim da As New OleDbDataAdapter("select * from date1 where d4='تعطيل'", OLDBCon)
            Dim ds As New DataSet()
            da.Fill(ds)

            Dim Counter As Integer = 0
            Dim IsExistDt As System.Data.DataTable
            Dim Holiday As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Taghvim")
            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    If ProgressBar1.Value + 1 <= ProgressBar1.Maximum Then
                        _DelUpdateProgressBar(ProgressBar1.Value + 1, ProgressBar1.Maximum)
                    End If
                    IsExistDt = BaseDataObject.DataAccess.GetDataTable("select * from Pm_Taghvim where Tarikh='" + dr("d1").ToString() + "'")
                    If IsExistDt.Rows.Count > 0 Then
                        Continue For
                    End If
                    Counter = Counter + 1
                    'EibForm("EibFormNumber") = BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(Eibformnumber)+1,1) from Pm_EibFormMaster ")
                    Holiday("type") = 2
                    Holiday("Tarikh") = dr("d1").ToString()

                    BaseDataObject.DataAccess.Insert(Holiday, False)
                Next
                _DelUpdateTxt("تعداد " + Counter.ToString() + "روز تعطیل با موفقیت ثبت شد", False)
            End If
        Catch

        End Try
    End Function

    Public Function ConvertTimeCard() As Boolean
        Try
            If Not OLDBCon.State = ConnectionState.Open Then
                OLDBCon.Open()
            End If

            Dim da As New OleDbDataAdapter("select * from setad", OLDBCon)
            Dim ds As New DataSet()
            da.Fill(ds)

            Dim IsHoliday As Integer
            Dim Counter As Integer = 0
            Dim IsExistDt As System.Data.DataTable
            Dim TimeCard As DataRow = BaseDataObject.DataAccess.NewRow("Pm_TimeCard")
            If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
                For Each dr As DataRow In ds.Tables(0).Rows
                    TimeCard = BaseDataObject.DataAccess.NewRow("Pm_TimeCard")

                    If ProgressBar1.Value + 1 <= ProgressBar1.Maximum Then
                        _DelUpdateProgressBar(ProgressBar1.Value + 1, ProgressBar1.Maximum)
                    End If
                    IsExistDt = BaseDataObject.DataAccess.GetDataTable("select * from pm_TimeCard where Tarikh='" + dr("tr").ToString() + "' and Srl_Pm_Ashkhas=" + GetAshkhasSrl(dr("name").ToString()).ToString())
                    If IsExistDt.Rows.Count > 0 Then
                        Continue For
                    End If
                    Counter = Counter + 1
                    'EibForm("EibFormNumber") = BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(Eibformnumber)+1,1) from Pm_EibFormMaster ")
                    TimeCard("Srl_Pm_ashkhas") = GetAshkhasSrl(dr("name").ToString())
                    TimeCard("Tarikh") = dr("tr").ToString()
                    TimeCard("EnterTime1") = SetTimeFormat(dr("tin").ToString())
                    TimeCard("ExitTime1") = SetTimeFormat(dr("tout").ToString())
                    'TimeCard("Srl_Pm_Post") = FindPost(dr("np").ToString())
                    TimeCard("Srl_Pm_CodeHaizne") = GetHazoneCodeSrl(dr("kh").ToString())
                    IsHoliday = BaseDataObject.DataAccess.ExecScalar("select ISNULL(Count(*),0) from Pm_taghvim where tarikh='" + dr("tr").ToString() + "'")
                    If IsHoliday > 0 Then
                        TimeCard("HolidayExtraWork") = SetTimeFormat(dr("ef").ToString())
                        TimeCard("BeginTimeExtraWork") = "00:00:00"
                    Else
                        TimeCard("BeginTimeExtraWork") = SetTimeFormat(dr("ef").ToString())
                        TimeCard("HolidayExtraWork") = "00:00:00"
                    End If
                    BaseDataObject.DataAccess.Insert(TimeCard, False)
                Next
                _DelUpdateTxt("تعداد " + Counter.ToString() + "تایم کارت با موفقیت انتقال داده شد", False)
            End If
        Catch
        End Try
    End Function

    Public Function ConvertWorkForm() As Boolean
        If Not OLDBCon.State = ConnectionState.Open Then
            OLDBCon.Open()
        End If

        Dim da As New OleDbDataAdapter("select * from formkar", OLDBCon)
        Dim ds As New DataSet()
        da.Fill(ds)

        Dim Counter As Integer = 0
        Dim IsExistDt As System.Data.DataTable

        Dim WrokFormMaster As DataRow = BaseDataObject.DataAccess.NewRow("Pm_WorkForm_Master")
        Dim WrokFormDetails As DataRow = BaseDataObject.DataAccess.NewRow("Pm_WorkFrom_Detail")

        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For Each dr As DataRow In ds.Tables(0).Rows
                If ProgressBar1.Value + 1 <= ProgressBar1.Maximum Then
                    _DelUpdateProgressBar(ProgressBar1.Value + 1, ProgressBar1.Maximum)
                End If
                IsExistDt = BaseDataObject.DataAccess.GetDataTable("select * from Pm_WorkForm_Master where No=" + dr("radif").ToString)

                If IsExistDt.Rows.Count > 0 Then
                    Continue For
                End If
                Counter = Counter + 1

                Dim da_temp_fromOskolCode As New OleDbDataAdapter("select * from formkar where radif=" + dr("radif").ToString, OLDBCon)
                Dim ds_temp_fromOskolCode As New DataSet()
                da_temp_fromOskolCode.Fill(ds_temp_fromOskolCode)

                Dim dr_Sarparast As DataRow = ds_temp_fromOskolCode.Tables(0).Rows(0)
                For Each dr_Exist As DataRow In ds_temp_fromOskolCode.Tables(0).Rows
                    If Not dr_Exist("og1") Is DBNull.Value Then
                        dr_Sarparast = dr_Exist
                        Exit For
                    End If
                Next

                WrokFormMaster("Srl_Pm_Post_From") = FindPost(dr_Sarparast("np").ToString())
                WrokFormMaster("Srl_Pm_Post_To") = FindPost(dr_Sarparast("Mabda").ToString())
                WrokFormMaster("Srl_Pm_Group") = FindGroup("گروه پيش فرض")
                WrokFormMaster("Srl_Pm_Vahed") = FindVahed(dr_Sarparast("nv").ToString())
                WrokFormMaster("Srl_Pm_WorkDis") = GetWorkDisSrl(dr_Sarparast("mk").ToString())
                WrokFormMaster("Srl_HazineCode") = GetHazoneCodeSrl(dr_Sarparast("kh").ToString())
                WrokFormMaster("No") = dr_Sarparast("radif")
                WrokFormMaster("Tarikh") = dr_Sarparast("d1")
                WrokFormMaster("WorkFormNo") = dr_Sarparast("sfk")
                WrokFormMaster("WorkFormDis") = CurrectStr(dr_Sarparast("sk").ToString())
                WrokFormMaster("Dis") = dr_Sarparast("mo")
                WrokFormMaster("WorkFormTarikh") = dr_Sarparast("tfk")
                If dr_Sarparast("tstart") Is DBNull.Value Then
                    WrokFormMaster("BeginWorkSat") = "00:00"
                Else
                    WrokFormMaster("BeginWorkSat") = StandardTime(dr_Sarparast("tstart"))
                End If
                If dr_Sarparast("tend") Is DBNull.Value Then
                    WrokFormMaster("EndWorkSat") = "00:00"
                Else
                    WrokFormMaster("EndWorkSat") = StandardTime(dr_Sarparast("tend"))
                End If
                If dr_Sarparast("tout") Is DBNull.Value Then
                    WrokFormMaster("KhorojSat") = "00:00"
                Else
                    WrokFormMaster("KhorojSat") = StandardTime(dr_Sarparast("tout"))
                End If
                WrokFormMaster("TardodeDotarfe") = dr_Sarparast("bm")
                WrokFormMaster("HarkatHamanRoz") = True

                If Not dr_Sarparast("og1") Is DBNull.Value Then
                    WrokFormMaster("Srl_Pm_Ashkhas_Sarparast") = GetAshkhasSrl(dr_Sarparast("og1"))
                ElseIf Not dr_Sarparast("og2") Is DBNull.Value Then
                    WrokFormMaster("Srl_Pm_Ashkhas_Sarparast") = GetAshkhasSrl(dr_Sarparast("og2"))
                ElseIf Not dr_Sarparast("og3") Is DBNull.Value Then
                    WrokFormMaster("Srl_Pm_Ashkhas_Sarparast") = GetAshkhasSrl(dr_Sarparast("og3"))
                ElseIf Not dr_Sarparast("og4") Is DBNull.Value Then
                    WrokFormMaster("Srl_Pm_Ashkhas_Sarparast") = GetAshkhasSrl(dr_Sarparast("og4"))
                ElseIf Not dr_Sarparast("og5") Is DBNull.Value Then
                    WrokFormMaster("Srl_Pm_Ashkhas_Sarparast") = GetAshkhasSrl(dr_Sarparast("og5"))
                ElseIf Not dr_Sarparast("og6") Is DBNull.Value Then
                    WrokFormMaster("Srl_Pm_Ashkhas_Sarparast") = GetAshkhasSrl(dr_Sarparast("og6"))
                End If

                WrokFormMaster("srl_dayofweek") = GetDaySrl(dr_Sarparast("roz").ToString)

                Dim srl_WorkFormMaster As Integer = BaseDataObject.DataAccess.InsertWithLastId(WrokFormMaster, False)
                If srl_WorkFormMaster = -1 Then
                    _DelUpdateTxt(vbNewLine + " خطا در ثبت اطلاعات فرم کار به شماره " + dr("radif").ToString, False)
                End If

                For Each dr_Exist As DataRow In ds_temp_fromOskolCode.Tables(0).Rows
                    WrokFormDetails = BaseDataObject.DataAccess.NewRow("Pm_WorkFrom_Detail")
                    WrokFormDetails("Srl_Pm_WorkForm_Master") = srl_WorkFormMaster
                    If Not dr_Exist("og1") Is DBNull.Value Then
                        WrokFormDetails("Srl_Pm_Ashkhas") = GetAshkhasSrl(dr_Exist("og1"))
                    ElseIf Not dr_Exist("og2") Is DBNull.Value Then
                        WrokFormDetails("Srl_Pm_Ashkhas") = GetAshkhasSrl(dr_Exist("og2"))
                    ElseIf Not dr_Exist("og3") Is DBNull.Value Then
                        WrokFormDetails("Srl_Pm_Ashkhas") = GetAshkhasSrl(dr_Exist("og3"))
                    ElseIf Not dr_Exist("og4") Is DBNull.Value Then
                        WrokFormDetails("Srl_Pm_Ashkhas") = GetAshkhasSrl(dr_Exist("og4"))
                    ElseIf Not dr_Exist("og5") Is DBNull.Value Then
                        WrokFormDetails("Srl_Pm_Ashkhas") = GetAshkhasSrl(dr_Exist("og5"))
                    ElseIf Not dr_Exist("og6") Is DBNull.Value Then
                        WrokFormDetails("Srl_Pm_Ashkhas") = GetAshkhasSrl(dr_Exist("og6"))
                    End If

                    WrokFormDetails("Srl_Pm_Post_From") = FindPost(dr_Exist("np").ToString())
                    WrokFormDetails("Srl_Pm_Post_To") = FindPost(dr_Exist("Mabda").ToString())
                    WrokFormDetails("Srl_Pm_Group") = FindGroup("گروه پيش فرض")
                    WrokFormDetails("Srl_Pm_Vahed") = FindVahed(dr_Exist("nv").ToString())
                    WrokFormDetails("Srl_Pm_WorkDis") = GetWorkDisSrl(dr_Exist("mk").ToString())
                    WrokFormDetails("Srl_HazineCode") = GetHazoneCodeSrl(dr_Exist("kh").ToString())
                    WrokFormDetails("WorkFormNo") = dr_Exist("sfk")
                    WrokFormDetails("WorkFormDis") = CurrectStr(dr_Exist("sk").ToString())
                    WrokFormDetails("Dis") = CurrectStr(dr_Exist("mo").ToString())
                    WrokFormDetails("MazadEzafeKar") = "00:00"
                    WrokFormDetails("WorkFormTarikh") = dr_Exist("tfk")
                    If dr_Sarparast("tstart") Is DBNull.Value Then
                        WrokFormDetails("BeginWorkSat") = "00:00"
                    Else
                        WrokFormDetails("BeginWorkSat") = StandardTime(dr_Sarparast("tstart"))
                    End If
                    If dr_Sarparast("tend") Is DBNull.Value Then
                        WrokFormDetails("EndWorkSat") = "00:00"
                    Else
                        WrokFormDetails("EndWorkSat") = StandardTime(dr_Sarparast("tend"))
                    End If
                    If dr_Sarparast("tout") Is DBNull.Value Then
                        WrokFormDetails("KhorojSat") = "00:00"
                    Else
                        WrokFormDetails("KhorojSat") = StandardTime(dr_Sarparast("tout"))
                    End If
                    WrokFormDetails("SatKAr") = StandardTimeSatKar(dr_Exist("nff"))
                    WrokFormDetails("EzafeKAr") = StandardTime(dr_Exist("ef").ToString)
                    WrokFormDetails("EzafeKarTaradod") = StandardTime(dr_Exist("et"))
                    WrokFormDetails("TardodeDotarfe") = dr_Exist("bm")
                    WrokFormDetails("HarkatHamanRoz") = True
                    WrokFormDetails("UserChanged") = False

                    If Not BaseDataObject.DataAccess.Insert(WrokFormDetails, False) Then
                        _DelUpdateTxt(vbNewLine + " خطا در ثبت اطلاعات فرم کار به شماره " + dr("radif").ToString, False)
                    End If
                Next
            Next
            _DelUpdateTxt("تعداد " + Counter.ToString() + "فرم کار با موفقیت انتقال داده شد", False)
            _DelUpdateProgressBar(ProgressBar1.Maximum, ProgressBar1.Maximum)
        End If

    End Function

    Function StandardTimeSatKar(ByVal sat As String) As String
        Dim res As String = ""
        If sat.Length = 1 Then
            res = "0" + sat + ":00"
        ElseIf sat.Length = 2 Then
            res = sat + ":00"
            'ElseIf sat.Length = 4 Then
            '    If Not sat.Contains(".") Then
            '        Return sat.Insert(2, ":")
            '    End If
        Else
            sat = sat.ToString.Replace(" ", "").Replace(".", ":")
            Dim h As String = sat.Substring(0, sat.IndexOf(":"))
            Dim m As String = sat.Substring(sat.IndexOf(":") + 1, sat.Length - h.Length - 1)
            h = h.PadLeft(2, "0")
            m = m.PadLeft(2, "0")
            Dim resu As Integer = (CInt(m) * 60) / 100
            m = resu.ToString.PadLeft(2, "0")
            res = h + ":" + m
        End If
        Return res.Replace("-", "0")
    End Function

    Function StandardTime(ByVal sat As String) As String
        Dim res As String = ""
        If sat.Length = 1 Then
            res = "0" + sat + ":00"
        ElseIf sat.Length = 2 Then
            res = sat + ":00"
        ElseIf sat.Length = 4 Then
            res = sat.Insert(2, ":")
        Else
            sat = sat.ToString.Replace(" ", "").Replace(".", ":")
            Dim h As String = sat.Substring(0, sat.IndexOf(":"))
            Dim m As String = sat.Substring(sat.IndexOf(":") + 1, sat.Length - h.Length - 1)
            h = h.PadLeft(2, "0")
            m = m.PadLeft(2, "0")
            res = h + ":" + m
        End If
        Return res.Replace("-", "0")
    End Function

    Function GetAshkhasSrl(ByVal Name As String) As Integer
        Name = Name.Replace("ی", "ي").Replace("ك", "ک")
        Dim FName As String = ""
        Dim LName As String = ""

        If Not Name.Contains("-") Then
            LName = Name
        Else
            FName = Name.Remove(0, Name.IndexOf("-"))
            FName = FName.TrimEnd.Replace("- ", "")
            LName = Name.Replace(FName, "").Replace("- ", "").Trim
        End If

        Dim Srl_WorkDis As Object
        Srl_WorkDis = BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_Ashkhas where name=N'" _
                                                           + FName + "' and Family=N'" + LName + "'")
        If Not Srl_WorkDis Is Nothing Then
            Return CInt(Srl_WorkDis)
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Ashkhas")
            dr("Name") = FName
            dr("Family") = LName
            dr("IsActive") = True
            dr("code") = BaseDataObject.DataAccess.FindMax("Pm_Ashkhas", "Code")
            dr("Srl_SubmitUser") = Setting.Srl_User
            dr("SubmitDate") = Setting.Now
            dr.Table.Columns.Remove("Image")
            Return BaseDataObject.DataAccess.InsertWithLastId(dr, False)
        End If
    End Function

    Function GetHazoneCodeSrl(ByVal Code As String) As Integer
        'Name = Name.Replace("ك", "ک").Replace("ي", "ی").Replace("ی", "ئ")

        Dim Srl_CodeHazine As Integer
        Srl_CodeHazine = BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_HazineCode where Code='" + Code + "'")
        If Srl_CodeHazine > 0 Then
            Return Srl_CodeHazine
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_HazineCode")
            dr("Sharh") = ""
            dr("Code") = Code
            dr("IsActive") = True
            dr("Srl_SubmitUser") = Setting.Srl_User
            dr("SubmitDate") = Setting.Now
            Return BaseDataObject.DataAccess.InsertWithLastId(dr, False)
        End If
    End Function

    Function GetWorkDisSrl(ByVal Name As String) As Integer
        Name = Name.Replace("ی", "ي").Replace("ك", "ک")
        Dim Srl_WorkDis As Integer
        Srl_WorkDis = BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_WorkDis where name=N'" + Name + "'")
        If Srl_WorkDis > 0 Then
            Return Srl_WorkDis
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_WorkDis")
            dr("name") = Name
            dr("code") = BaseDataObject.DataAccess.FindMax("Pm_WorkDis", "Code")
            dr("IsPM") = False
            dr("Srl_SubmitUser") = Setting.Srl_User
            dr("SubmitDate") = Setting.Now

            Return BaseDataObject.DataAccess.InsertWithLastId(dr, False)
        End If
    End Function

    Function GetDaySrl(ByVal Name As String) As Integer
        Select Case Name
            Case "شنبه"
                Return 1
            Case "يک شنبه"
                Return 2
            Case "دو شتبه"
                Return 3
            Case "سه شنبه"
                Return 4
            Case "چهار شنبه"
                Return 5
            Case "پنج شنبه"
                Return 6
            Case "جمعه"
                Return 7
        End Select
    End Function

    Public Function FindPost(ByVal InputName As String) As Integer
        If InputName <> "" And Not InputName Is DBNull.Value Then
            Dim Name As String = InputName
            Dim srl_post As Integer
            Name = Name.Replace("ی", "ي").Replace("ك", "ک")
            srl_post = BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_post where name=N'" + Name + "'")
            If srl_post > 0 Then
                Return srl_post
            Else
                'If InputName = "چاهگ" Then
                '    Name = "چاهک"
                'ElseIf InputName = "جلکه رخ" Then
                '    Name = "جلگه رخ"
                'ElseIf InputName = "خواجه ربيع - مدولار" Then
                '    Name = "خواجه ربيع مدولار"
                'End If
                srl_post = BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_post where name=N'" + Name + "'")
                If srl_post > 0 Then
                    Return srl_post
                Else
                    Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Post")
                    dr("name") = Name
                    dr("code") = BaseDataObject.DataAccess.FindMax("Pm_Post", "Code")
                    dr("Srl_SubmitUser") = Setting.Srl_User
                    dr("SubmitDate") = Setting.Now
                    Return BaseDataObject.DataAccess.InsertWithLastId(dr, False)
                End If
            End If
        End If
    End Function

    Public Function FindEibType(ByVal InputName As String) As Integer
        If InputName <> "" And Not InputName Is DBNull.Value Then
            Dim Name As String = InputName
            Dim srl_EibType As Integer
            Name = Name.Replace("ی", "ي").Replace("ك", "ک")
            srl_EibType = BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_EibType where name=N'" + Name.Trim() + "'")
            If srl_EibType > 0 Then
                Return srl_EibType
            Else
                Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_EibType")
                dr("name") = Name
                dr("code") = BaseDataObject.DataAccess.FindMax("Pm_EibType", "Code")
                dr("Srl_SubmitUser") = Setting.Srl_User
                dr("SubmitDate") = Setting.Now
                Return BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            End If
        End If
    End Function

    Public Function FindVahed(ByVal InputName As String) As Integer
        If InputName <> "" And Not InputName Is DBNull.Value Then
            Dim Name As String = InputName.Trim()
            Dim srl_Vahed As Integer
            Name = Name.Replace("ی", "ي").Replace("ك", "ک")
            srl_Vahed = BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_Vahed where name=N'" + Name + "'")
            If srl_Vahed > 0 Then
                Return srl_Vahed
            Else
                Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Vahed")
                dr("name") = Name
                dr("code") = BaseDataObject.DataAccess.FindMax("Pm_Vahed", "Code")
                dr("Srl_SubmitUser") = Setting.Srl_User
                dr("SubmitDate") = Setting.Now
                Return BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            End If
        End If
    End Function

    Public Function FindGroup(ByVal InputName As String) As Integer
        If InputName <> "" And Not InputName Is DBNull.Value Then

            Dim Name As String = InputName.Trim()
            Dim srl_Group As Integer
            Name = Name.Replace("ی", "ي").Replace("ك", "ک")
            srl_Group = BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_Group where name=N'" + Name + "'")
            If srl_Group > 0 Then
                Return srl_Group
            Else
                Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Group")
                dr("name") = Name
                dr("code") = BaseDataObject.DataAccess.FindMax("Pm_Group", "Code")
                dr("Srl_SubmitUser") = Setting.Srl_User
                dr("SubmitDate") = Setting.Now
                Return BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            End If
        End If
    End Function

    Public Function CurrectStr(ByVal InputStr As String)
        Return InputStr.Replace("ك", "ک").Replace("ي", "ی")
    End Function

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            Thread.Start(txt_Addres.Text)
        Catch
            Thread = New System.Threading.Thread(AddressOf Convert)
            Thread.Start(txt_Addres.Text)
        End Try
    End Sub

    Public Function SetTimeFormat(ByVal Input As String) As String
        If Input.Contains("_") Then
            Return "00:00:00"
        End If
        If Input.Length = 8 Then
            Return Input
        End If
        If Input.IndexOf(":") > -1 Then
            If Input.Substring(0, Input.IndexOf(":")).Length = 1 Then
                Input = "0" + Input
            End If
        End If
        If Input.Length = 5 Then
            Return Input + ":00"
        Else
            Return "00:00:00"
        End If
    End Function

    Public Function CalHoliday(ByVal Input As String) As String
        Dim i As Integer = (CInt(Input.Substring(0, 2)) * 60 + CInt(Input.Substring(3, 2))) * Setting.HolidayZarib.PropValue
        Return IIf((i \ 60).ToString().Length = 1, "0" + (i \ 60).ToString(), (i \ 60).ToString()) + ":" + IIf((i Mod 60).ToString().Length = 1, "0" + (i Mod 60).ToString(), (i Mod 60).ToString()) + ":00"
    End Function

    Private Sub UpdateProgressBar(ByVal Value As Integer, ByVal Max As Integer)
        If ProgressBar1.InvokeRequired Then
            Me.ProgressBar1.BeginInvoke(New DelUpdateProgressBar(AddressOf UpdateProgressBar), Value, Max)
        Else
            ProgressBar1.Maximum = CInt(Max) 'Set the Max Value for the Progress bar
            ProgressBar1.Value = CInt(Value) 'Set the Current Value
        End If
    End Sub

    Private Sub Updatetxt(ByVal Value As String, ByVal Isdel As Boolean)
        If txt_Log.InvokeRequired Then
            Me.txt_Log.BeginInvoke(New DelUpdateTxt(AddressOf Updatetxt), Value, Isdel)
        Else
            If CBool(Isdel) Then
                txt_Log.Items.Clear()
            End If
            txt_Log.Items.Add(CStr(Value))
        End If
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        If Thread.IsAlive Then
            Thread.Abort()
        End If
    End Sub

    Private Sub ConvertDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenFileDialog1.InitialDirectory = Directory.GetCurrentDirectory()
        OpenFileDialog1.Filter = "Access Files ( *.mdb )| *.mdb"
    End Sub

    Private Sub Btn_Brows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Brows.Click
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
            Return
        End If
        txt_Addres.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub lnk_DdeeteWorkForm_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_DdeeteWorkForm.LinkClicked
        If MessageBox.Show("آیا مایلید تمام اطلاعات فرم کار حذف شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            BaseDataObject.DataAccess.Delete("Pm_WorkFrom_Detail", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_WorkForm_Master", "Srl>0")
            MessageBoxFa.Show("Finshed!")
        End If
    End Sub

    Private Sub lnk_DeleteFormNaghs_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_DeleteFormNaghs.LinkClicked
        If MessageBox.Show("آیا مایلید تمام اطلاعات فرم نقص حذف شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            BaseDataObject.DataAccess.Delete("Pm_EibFormDetails", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_EibFormMaster", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_EibFormPeiro", "Srl>0")
            MessageBoxFa.Show("Finshed!")
        End If

    End Sub

    Private Sub lnk_DeleteTimecard_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_DeleteTimecard.LinkClicked
        If MessageBox.Show("آیا مایلید تمام اطلاعات تایم کارت حذف شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            BaseDataObject.DataAccess.Delete("pm_TimeCard", "Srl>0")
            MessageBoxFa.Show("Finshed!")
        End If
    End Sub

    Private Sub chk_TimeCard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TimeCard.CheckedChanged
        If chk_TimeCard.Checked Then
            chk_Holiday.Checked = True
        End If
    End Sub

    Private Sub chk_Holiday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Holiday.CheckedChanged
        If Not chk_Holiday.Checked Then
            chk_TimeCard.Checked = False
        End If
    End Sub

    Private Sub llb_DeleteAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llb_DeleteAll.LinkClicked
        If MessageBox.Show("آیا مایلید کل پایگاه داده خذف شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            BaseDataObject.DataAccess.Delete("pm_TimeCard", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_Group", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_Distance", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_WorkForm_NoSeq", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_EibFormDetails", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_EibFormPeiro", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_TimeCard", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_WorkForm_EibForm", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_WorkForm_KalaMasrafi", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_WorkForm_Formula", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_TimeCardType", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_EibType", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_PostToGroup", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_Ashkhas", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_EibFormMaster", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_Device", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_WorkForm_Master", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_WorkFrom_Detail", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_Vahed", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_WorkDis", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_HazineCode", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_GroupMember", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_Post", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_Post_Group", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_PostDetails", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_PostTajhiz", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_Project", "Srl>0")
            BaseDataObject.DataAccess.Delete("Pm_DeviceType", "Srl>0")
            MessageBoxFa.Show("Finshed!")

        End If

    End Sub
End Class