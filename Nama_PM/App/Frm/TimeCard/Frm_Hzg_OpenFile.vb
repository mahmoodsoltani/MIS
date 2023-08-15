Imports System.IO
Imports System.Threading
Imports Microsoft.Office.Interop.Excel

Public Class Frm_Hzg_OpenFile


    Private Sub Btn_OpenFile_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_OpenFile.Click
        If FolderBrowserDialog1.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
            Return
        End If
        txt_Addres.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Public Sub Convert(ByVal Path As Object)
        Dim PersonalCode As String
        Dim Tarikh As String = ""
        Dim AllWork As String
        Dim BeginTimeExtraWork As String
        Dim EndTimeExtraWork As String
        Dim HolidayExtraWork As String
        Dim Morakhasi As String
        Dim Mamoriyat As String
        Dim Takhir As String
        Dim Tajil As String
        Dim EnterTime1 As String
        Dim ExitTime1 As String
        Dim EnterTime2 As String
        Dim ExitTime2 As String
        Dim EnterTime3 As String
        Dim ExitTime3 As String
        Dim Status As String
        Dim Srl_Update As Integer
        'Dim CodeHazine As Integer = -1
        'Dim MahalMamoriyat As Integer = -1
        Dim BeforeRegister As Integer = 0
        Dim Register As Integer = 0
        Dim ErrorRegister As Integer = 0
        Dim NoPersonel As Integer = 0
        Dim AllExist As Boolean = False

        Dim ExlFile As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
        ExlFile.Visible = False
        ExlFile.UserControl = True
        Dim IsExist As Boolean = False
        Dim oldCI As System.Globalization.CultureInfo = _
            System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = _
            New System.Globalization.CultureInfo("en-US")
        Dim FileList As String()
        Dim TempFile As String
        If CStr(Path) <> "" And Directory.Exists(CStr(Path)) Then
            Try
                FileList = Directory.GetFiles(CStr(Path))
                UpdateProgressBar(0, FileList.Length)
                ' ProgressBar1.Maximum = FileList.Length
                For Each TempFile In FileList
                    AllExist = True
                    _DelUpdateProgressBar(ProgressBar1.Value + 1, FileList.Length)
                    PersonalCode = TempFile.Substring(TempFile.LastIndexOf("\") + 1, TempFile.LastIndexOf(".") - TempFile.LastIndexOf("\") - 1)
                    If PersonalCode.Contains("~$") Then
                        Continue For
                    End If
                    PersonalCode = BaseDataObject.DataAccess.ExecScalar("Select srl from Pm_Ashkhas where PersonalCode=" + IIf(PersonalCode Is Nothing, -1, PersonalCode))
                    If Not PersonalCode Is Nothing And (TempFile.Contains(".XLS") Or TempFile.Contains(".XLSX") Or TempFile.Contains(".xls") Or TempFile.Contains(".xlsx")) Then
                        Try
                            ExlFile.Workbooks.Open(TempFile)
                            BaseDataObject.DataAccess.BeginTransaction()
                            For i As Integer = 2 To CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Rows.Count - 2
                                IsExist = False
                                Dim temp As Microsoft.Office.Interop.Excel.Range

                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 2)
                                If temp.Text.ToString.Contains("جمع ") Then
                                    Exit For
                                End If
                                Tarikh = temp.Text.ToString.Substring(0, temp.Text.ToString.IndexOf("("))
                                If Tarikh = " " Then
                                    Exit For
                                End If
                                If CInt(BaseDataObject.DataAccess.ExecScalar("select count(*) from pm_timecard where Srl_Pm_Ashkhas=" + PersonalCode + " and Tarikh='" + Tarikh + "'")) > 0 Then
                                    Srl_Update = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from pm_timecard where Srl_Pm_Ashkhas=" + PersonalCode + " and Tarikh='" + Tarikh + "'"))
                                    IsExist = True
                                Else
                                    AllExist = False
                                End If
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 3)
                                AllWork = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 4)
                                BeginTimeExtraWork = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 5)
                                EndTimeExtraWork = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 6)
                                HolidayExtraWork = CalHoliday(SetTimeFormat(temp.Text))
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 7)
                                Morakhasi = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 8)
                                Mamoriyat = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 9)
                                Takhir = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 10)
                                Tajil = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 12)
                                EnterTime1 = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 13)
                                ExitTime1 = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 14)
                                EnterTime2 = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 15)
                                ExitTime2 = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 16)
                                EnterTime3 = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 17)
                                ExitTime3 = SetTimeFormat(temp.Text)
                                temp = CType(ExlFile.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Cells(i, 18)
                                Status = temp.Text

                                If Not IsExist Then
                                    BaseDataObject.DataAccess.ExecQuery("Insert Into Pm_TimeCard Values(" + PersonalCode + ",'" + Tarikh + "','" + AllWork + "','" + BeginTimeExtraWork + "','" + EndTimeExtraWork + "','" + HolidayExtraWork + "','" + Morakhasi + "','" + Mamoriyat + "','" + Takhir + "','" + Tajil + "','" + EnterTime1 + "','" + ExitTime1 + "','" + EnterTime2 + "','" + ExitTime2 + "','" + EnterTime3 + "','" + ExitTime3 + "','" + Status + "',NULL,NULL,'" + Setting.Now + "'," + Setting.Srl_User.ToString() + ",NULL,NULL,NULL,null)")
                                Else
                                    BaseDataObject.DataAccess.ExecQuery("update Pm_TimeCard set Srl_Pm_ashkhas=" + PersonalCode + " , Tarikh='" + Tarikh + "' , AllWork='" + AllWork + "' , BeginTimeExtraWork='" + BeginTimeExtraWork + "' , EndTimeExtraWork='" + EndTimeExtraWork + "' , HolidayExtraWork='" + HolidayExtraWork + "' , Morakhasi='" + Morakhasi + "' , Mamoriyat='" + Mamoriyat + "', Takhir= '" + Takhir + "' , Tajil='" + Tajil + "' , EnterTime1='" + EnterTime1 + "' , ExitTime1='" + ExitTime1 + "' , EnterTime2='" + EnterTime2 + "' , ExitTime2 ='" + ExitTime2 + "' , EnterTime3 ='" + EnterTime3 + "' , ExitTime3 ='" + ExitTime3 + "' , Status='" + Status + "' , SubmitDate='" + Setting.Now + "' , Srl_SubmitUser=" + Setting.Srl_User.ToString() + " where srl=" + Srl_Update.ToString())
                                End If
                            Next
                            BaseDataObject.DataAccess.Commit()
                            ExlFile.Application.ActiveWindow.Close()
                            If Not AllExist Then
                                Register = Register + 1
                                _DelUpdateTxt("اطلاعات فایل " + TempFile.Substring(TempFile.LastIndexOf("\") + 1) + "با موفقیت بازخوانی شد", False)
                            Else
                                BeforeRegister = BeforeRegister + 1
                                _DelUpdateTxt("اطلاعات برای فایل " + TempFile.Substring(TempFile.LastIndexOf("\") + 1) + "در تاریخ " + Tarikh + "   قبلا ثبت شده است و بروز شد", False)
                            End If
                        Catch
                            ErrorRegister = ErrorRegister + 1
                            BaseDataObject.DataAccess.RollBack()
                            ExlFile.Application.ActiveWindow.Close()
                            _DelUpdateTxt("خطا در بازخوانی اطلاعات فایل " + TempFile.Substring(TempFile.LastIndexOf("\") + 1), False)
                        End Try
                    Else
                        If PersonalCode Is Nothing Then
                            NoPersonel = NoPersonel + 1
                            _DelUpdateTxt("برای فایل " + TempFile.Substring(TempFile.LastIndexOf("\") + 1) + " پرسنلی پیدا نشد", False)
                        Else
                            _DelUpdateTxt("فرمت فایل " + TempFile.Substring(TempFile.LastIndexOf("\") + 1) + " درست نیست", False)
                        End If
                    End If

                Next
                MessageBox.Show("اطلاعات با موفقیت بازخوانی شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _DelUpdateTxt("عملیات با موفقیت انجام شد ", False)
                _DelUpdateTxt("=================================================== ", False)
                _DelUpdateTxt("تعداد " + Register.ToString() + " فایل با موفقیت بازخوانی شد", False)
                _DelUpdateTxt("تعداد " + ErrorRegister.ToString() + " فایل با موفقیت بازخوانی نشد", False)
                _DelUpdateTxt("تعداد " + BeforeRegister.ToString() + " فایل قبلا در سیستم ثبت شده بود", False)
                _DelUpdateTxt("برای " + NoPersonel.ToString() + " فایل پرسنل پیدا نشد", False)
                EnsureProcessKilled(New IntPtr(CType(ExlFile.Parent.Hwnd, Integer)), ExlFile.Caption)
            Catch ex As Exception
                MessageBoxFa.Show("خطا در بازخوانی اطلاعات فایل", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                _DelUpdateTxt("خطا در بازخوانی اطلاعات   ", False)
                '    btn_Save.Focus()
                EnsureProcessKilled(New IntPtr(CType(ExlFile.Parent.Hwnd, Integer)), ExlFile.Caption)
            End Try
        Else
            MessageBoxFa.Show("مسیر انتخابی اشتباه است", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Thread.Abort()
        End If
        Thread.Abort()
    End Sub
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        Thread.Start(txt_Addres.Text)
    End Sub
    Public Function SetTimeFormat(ByVal Input As String) As String
        If Input.Length = 8 Then
            Return Input.Substring(0, 5)
        End If
        If Input.IndexOf(":") > -1 Then
            If Input.Substring(0, Input.IndexOf(":")).Length = 1 Then
                Input = "0" + Input
            End If
        End If
        If Input.Length = 5 Then
            Return Input
        Else
            Return "00:00"
        End If
    End Function
    Public Function CalHoliday(ByVal Input As String) As String
        Dim i As Integer = (CInt(Input.Substring(0, 2)) * 60 + CInt(Input.Substring(3, 2))) * Setting.HolidayZarib.PropValue
        Return IIf((i \ 60).ToString().Length = 1, "0" + (i \ 60).ToString(), (i \ 60).ToString()) + ":" + IIf((i Mod 60).ToString().Length = 1, "0" + (i Mod 60).ToString(), (i Mod 60).ToString())
    End Function
    Private Sub txt_Addres_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Addres.TextChanged

    End Sub
    Declare Function EndTask Lib "user32.dll" (ByVal hWnd As IntPtr) As Integer
    Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" _
           (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Declare Function GetWindowThreadProcessId Lib "user32.dll" _
           (ByVal hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    Declare Function SetLastError Lib "kernel32.dll" (ByVal dwErrCode As Integer) As IntPtr


    Public Sub EnsureProcessKilled(ByVal MainWindowHandle As IntPtr, ByVal Caption As String)
        If IntPtr.Equals(MainWindowHandle, IntPtr.Zero) Then _
      MainWindowHandle = FindWindow(Nothing, Caption)
        If IntPtr.Equals(MainWindowHandle, IntPtr.Zero) Then _
      Exit Sub ' at this point, presume the window has been closed.
        Dim iRes, iProcID As Integer
        iRes = GetWindowThreadProcessId(MainWindowHandle, iProcID)
        If iProcID = 0 Then ' can’t get Process ID
            If EndTask(MainWindowHandle) <> 0 Then Exit Sub ' success
            Throw New ApplicationException("Failed to close.")
        End If
        Dim proc As System.Diagnostics.Process
        proc = System.Diagnostics.Process.GetProcessById(iProcID)
        proc.CloseMainWindow()
        proc.Refresh()
        If proc.HasExited Then Exit Sub
        proc.Kill()
    End Sub
    Private Thread As New System.Threading.Thread(AddressOf Convert)
    Private Delegate Sub DelUpdateProgressBar(ByVal Value As Integer, ByVal Max As Integer)
    Private _DelUpdateProgressBar As New DelUpdateProgressBar(AddressOf UpdateProgressBar)

    Private Sub UpdateProgressBar(ByVal Value As Integer, ByVal Max As Integer)
        If ProgressBar1.InvokeRequired Then
            Me.ProgressBar1.BeginInvoke(New DelUpdateProgressBar(AddressOf UpdateProgressBar), Value, Max)
        Else
            ProgressBar1.Maximum = CInt(Max) 'Set the Max Value for the Progress bar
            ProgressBar1.Value = CInt(Value) 'Set the Current Value
        End If
    End Sub

    Private Delegate Sub DelUpdateTxt(ByVal Value As String, ByVal Isdel As Boolean)
    Private _DelUpdateTxt As New DelUpdateTxt(AddressOf Updatetxt)
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
End Class