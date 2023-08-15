Imports Excel = Microsoft.Office.Interop.Excel
Public Class Frm_Khat_Import
    Dim MyExcelProcessId As Integer
    Public ExlFile As Microsoft.Office.Interop.Excel.Application
    Dim dic_dakalStructure As New Dictionary(Of String, Integer)
    Dim dic_DakalType As New Dictionary(Of String, Integer)
    Dim dic_DakalCode As New Dictionary(Of String, Integer)
    Dim dic_DakalProvider As New Dictionary(Of String, Integer)
    Dim dic_DakalModel As New Dictionary(Of String, Integer)
    Dim dic_Magharetype As New Dictionary(Of String, Integer)
    Dim dic_MaghareProvider As New Dictionary(Of String, Integer)
    Dim dic_MaghareChain As New Dictionary(Of String, Integer)
    Dim dic_fibrtype As New Dictionary(Of String, Integer)
    Dim dicExcel As New Dictionary(Of Integer, Integer)
    Private Srl_con As Integer
    Private Sub Frm_Khat_Import_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Create_Dic(dic_dakalStructure, "pm_line_dakalstructure")
        Create_Dic(dic_DakalType, "pm_line_dakaltype")
        Create_Dic(dic_DakalCode, "pm_line_dakalcode")
        Create_Dic(dic_DakalProvider, "pm_line_dakalprovider")
        Create_Dic(dic_DakalModel, "pm_line_dakalmodel")
        Create_Dic(dic_Magharetype, "pm_line_Magharetype")
        Create_Dic(dic_MaghareProvider, "pm_line_MaghareProvider")
        Create_Dic(dic_MaghareChain, "pm_line_MaghareChain")
        Create_Dic(dic_fibrtype, "pm_line_fibrtype")
    End Sub
    Private Sub Create_Dic(ByVal dic As Dictionary(Of String, Integer), ByVal Tname As String)
        Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable(Tname, "")
        If Not dt Is Nothing Then
            For Each row As DataRow In dt.Rows
                dic.Add(row("name").ToString(), CInt(row("srl").ToString()))
            Next

        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txt_unit.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        ProgressBar1.Value = 1
        If txt_unit.Text = "" Then
            MessageBoxFa.Show("لطفا مسیر فایل های ورودی را انتخاب نمائید", "هشدار", MessageBoxButtons.OK)
            Return False
        End If
        If Not IO.Directory.Exists(txt_unit.Text) Then
            MessageBoxFa.Show("مسیر انتخابی اشتباه است", "هشدار", MessageBoxButtons.OK)
            Return False
        End If
        If IO.Directory.GetFiles(txt_unit.Value).Length = 0 Then
            MessageBoxFa.Show("مسیر انتخابی فاقد فایل است", "هشدار", MessageBoxButtons.OK)
            Return False
        End If
        Dim files() = IO.Directory.GetFiles(txt_unit.Value)
        Dim hasExcel = False
        Dim imported As Integer = 0
        Dim notimported As Integer = 0
        ProgressBar1.Minimum = 0
        Dim filecount = 0
        For Each s As String In files
            Dim extension = IO.Path.GetExtension(s)

            If (extension = ".xlsx" Or extension = ".xls") And (Not s.Contains("$")) Then
                filecount = filecount + 1
            End If
        Next
        ProgressBar1.Maximum = filecount
        Dim Line_Notfound As String = ""
        For Each s As String In files
            Dim extension = IO.Path.GetExtension(s)
            If (extension = ".xlsx" Or extension = ".xls") And (Not s.Contains("$")) Then
                CheckForExistingExcellProcesses()
                Dim xlApp As Excel.Application
                Dim xlWorkBook As Excel.Workbook
                Dim xlWorkSheet As Excel.Worksheet
                '"اطلاعات اصلی خط"
                xlApp = New Excel.ApplicationClass
                xlWorkBook = xlApp.Workbooks.Open(s)
                xlWorkSheet = xlWorkBook.Worksheets("sheet1")
                Dim linename = xlWorkSheet.Cells(2, 2).value
                Dim dr = BaseDataObject.DataAccess.GetRow("pm_line", "code='" + linename.ToString() + "'")
                GetTheExcelProcessIdThatUsedByThisInstance()
                If Not dr Is Nothing Then
                    imported = imported + 1
                    dr("name") = xlWorkSheet.Cells(2, 3).value
                    Label2.Text = "خط " + xlWorkSheet.Cells(2, 3).value
                    Dim srl_voltage = BaseDataObject.DataAccess.ExecScalar("select srl from Pm_Line_Voltage where Name='" + xlWorkSheet.Cells(2, 4).value.ToString() + "'")
                    If Not srl_voltage Is Nothing Then
                        dr("srl_voltage") = srl_voltage
                    Else
                        Dim dr_voltage = BaseDataObject.DataAccess.NewRow("Pm_Line_Voltage")
                        dr_voltage("name") = xlWorkSheet.Cells(2, 4).value
                        dr("srl_voltage") = BaseDataObject.DataAccess.InsertWithLastId(dr_voltage, False)

                    End If
                    dr("CreateDate") = xlWorkSheet.Cells(2, 5).value
                    dr("Linelength") = xlWorkSheet.Cells(2, 6).value
                    dr("CycleCount") = xlWorkSheet.Cells(2, 7).value
                    dr("DakalCount") = xlWorkSheet.Cells(2, 8).value
                    Dim srl_haditype = BaseDataObject.DataAccess.ExecScalar("select srl from Pm_Line_HadiType where Name='" + xlWorkSheet.Cells(2, 9).value.ToString() + "'")
                    If Not srl_haditype Is Nothing Then
                        dr("Srl_HadiType") = srl_haditype
                    Else
                        Dim dr_hadi = BaseDataObject.DataAccess.NewRow("Pm_Line_HadiType")
                        dr_hadi("name") = xlWorkSheet.Cells(2, 9).value
                        dr("Srl_HadiType") = BaseDataObject.DataAccess.InsertWithLastId(dr_hadi, False)
                    End If
                    dr("HadiCount") = xlWorkSheet.Cells(2, 10).value
                    dr("GardCount") = xlWorkSheet.Cells(2, 11).value
                    Dim srl_gardtype = BaseDataObject.DataAccess.ExecScalar("select srl from Pm_Line_GardType where Name='" + xlWorkSheet.Cells(2, 12).value.ToString() + "'")
                    If Not srl_haditype Is Nothing Then
                        dr("Srl_GardType") = srl_haditype
                    Else
                        Dim dr_gard = BaseDataObject.DataAccess.NewRow("Pm_Line_GardType")
                        dr_gard("name") = xlWorkSheet.Cells(2, 12).value
                        dr("Srl_GardType") = BaseDataObject.DataAccess.InsertWithLastId(dr_gard, False)
                    End If
                    dr("HasFibre") = xlWorkSheet.Cells(2, 13).value
                    dr("Srl_fibrType") = IIf(Not xlWorkSheet.Cells(2, 14).value Is Nothing, GetOrAdd(dic_fibrtype, "Pm_Line_fibrtype", xlWorkSheet.Cells(2, 14).value.ToString()), DBNull.Value)
                    dr("LatisTowerCount") = xlWorkSheet.Cells(2, 15).value
                    dr("TelescopTowerCount") = xlWorkSheet.Cells(2, 16).value
                    dr("TelescopTowerCount") = xlWorkSheet.Cells(2, 16).value
                    dr("tircount") = xlWorkSheet.Cells(2, 17).value
                    dr("AviziTowerCount") = xlWorkSheet.Cells(2, 18).value
                    dr("KesheshiTowerCount") = xlWorkSheet.Cells(2, 19).value
                    dr("Srl_MaghareType") = IIf(Not xlWorkSheet.Cells(2, 20).value Is Nothing, GetOrAdd(dic_Magharetype, "Pm_Line_Magharetype", xlWorkSheet.Cells(2, 20).value.ToString()), DBNull.Value)

                    dr("MaghareCount") = xlWorkSheet.Cells(2, 21).value
                    dr("Intersection_Line") = xlWorkSheet.Cells(2, 22).value
                    dr("Intersection_Line20") = xlWorkSheet.Cells(2, 23).value
                    dr("Intersection_Road") = xlWorkSheet.Cells(2, 24).value
                    dr("Intersection_Industrial") = xlWorkSheet.Cells(2, 25).value
                    dr("Intersection_Residential") = xlWorkSheet.Cells(2, 26).value
                    dr("Intersection_Forest") = xlWorkSheet.Cells(2, 27).value
                    dr("Intersection_Military") = xlWorkSheet.Cells(2, 28).value
                    dr("Inside_Post") = xlWorkSheet.Cells(2, 29).value
                    dr("Inside_Urban") = xlWorkSheet.Cells(2, 30).value
                    dr("Inside_Flood") = xlWorkSheet.Cells(2, 31).value
                    dr("Inside_Mountain") = xlWorkSheet.Cells(2, 32).value
                    dr("Inside_Agriculture") = xlWorkSheet.Cells(2, 33).value
                    dr("Bosh_Intalation") = xlWorkSheet.Cells(2, 34).value
                    dr("Gooy_Instalation") = xlWorkSheet.Cells(2, 35).value
                    dr("Spacer_Instalation") = xlWorkSheet.Cells(2, 36).value
                    BaseDataObject.DataAccess.Update(dr, 0, False)

                    'اطلاعات دکل های خط
                    Dim sheet As Microsoft.Office.Interop.Excel.Worksheet = xlWorkBook.Worksheets("sheet2")
                    Dim used_range As Microsoft.Office.Interop.Excel.Range = sheet.UsedRange
                    Dim max_row As Integer = used_range.Rows.Count
                    Dim max_col As Integer = used_range.Columns.Count
                    BaseDataObject.DataAccess.Delete("pm_line_dakal", "srl_line=" + dr("srl").ToString())
                    For _row As Integer = 2 To max_row
                        Dim dakalrow = BaseDataObject.DataAccess.NewRow("pm_line_dakal")
                        dakalrow("Srl_Line") = dr("srl")
                        Try
                            Dim number As Integer = CInt(used_range.Cells(_row, 1).value.ToString())
                            Label3.Text = "انتقال اطلاعات دکل شماره " + number.ToString()
                            dakalrow("Number") = IIf(used_range.Cells(_row, 1).value Is Nothing, 0, used_range.Cells(_row, 1).value)
                            dakalrow("NextSpan") = IIf(used_range.Cells(_row, 2).value Is Nothing, 0, used_range.Cells(_row, 2).value)
                            dakalrow("Longitude") = IIf(used_range.Cells(_row, 3).value Is Nothing, 0, used_range.Cells(_row, 3).value)
                            dakalrow("Latitude") = IIf(used_range.Cells(_row, 4).value Is Nothing, 0, used_range.Cells(_row, 4).value)
                            dakalrow("CyrcleCount") = IIf(used_range.Cells(_row, 5).value Is Nothing, 0, used_range.Cells(_row, 5).value)
                            dakalrow("Srl_DakalStructure") = IIf(Not used_range.Cells(_row, 6).value Is Nothing, GetOrAdd(dic_dakalStructure, "Pm_Line_DakalStructure", used_range.Cells(_row, 6).value), DBNull.Value)
                            dakalrow("Srl_DakalType") = IIf(Not used_range.Cells(_row, 7).value Is Nothing, GetOrAdd(dic_DakalType, "Pm_Line_Dakaltype", used_range.Cells(_row, 7).value), DBNull.Value)
                            dakalrow("Srl_DakalCode") = IIf(Not used_range.Cells(_row, 8).value Is Nothing, GetOrAdd(dic_DakalCode, "Pm_Line_DakalCode", used_range.Cells(_row, 8).value), DBNull.Value)
                            dakalrow("Srl_DakalProvider") = IIf(Not used_range.Cells(_row, 9).value Is Nothing, GetOrAdd(dic_DakalProvider, "Pm_Line_Dakalprovider", used_range.Cells(_row, 9).value), DBNull.Value)
                            dakalrow("Srl_DakalModel") = IIf(Not used_range.Cells(_row, 10).value Is Nothing, GetOrAdd(dic_DakalModel, "Pm_Line_DakalModel", used_range.Cells(_row, 10).value), DBNull.Value)
                            dakalrow("DownHeight") = IIf(used_range.Cells(_row, 11).value Is Nothing, DBNull.Value, used_range.Cells(_row, 11).value)
                            dakalrow("ExtraBody") = IIf(used_range.Cells(_row, 12).value Is Nothing, DBNull.Value, used_range.Cells(_row, 12).value)
                            dakalrow("ExtraLag1") = IIf(used_range.Cells(_row, 13).value Is Nothing, DBNull.Value, used_range.Cells(_row, 13).value)
                            dakalrow("ExtraLag2") = IIf(used_range.Cells(_row, 14).value Is Nothing, DBNull.Value, used_range.Cells(_row, 14).value)
                            dakalrow("ExtraLag3") = IIf(used_range.Cells(_row, 15).value Is Nothing, DBNull.Value, used_range.Cells(_row, 15).value)
                            dakalrow("ExtraLag4") = IIf(used_range.Cells(_row, 16).value Is Nothing, DBNull.Value, used_range.Cells(_row, 16).value)
                            dakalrow("ChainCount") = IIf(used_range.Cells(_row, 17).value Is Nothing, DBNull.Value, used_range.Cells(_row, 17).value)
                            dakalrow("Srl_MaghareChain") = IIf(Not used_range.Cells(_row, 18).value Is Nothing, GetOrAdd(dic_MaghareChain, "Pm_Line_MaghareChain", used_range.Cells(_row, 18).value), DBNull.Value)
                            dakalrow("MaghareCountPerstringChain") = IIf(used_range.Cells(_row, 19).value Is Nothing, DBNull.Value, used_range.Cells(_row, 19).value)
                            dakalrow("MaghareCountPerChain") = IIf(used_range.Cells(_row, 20).value Is Nothing, DBNull.Value, used_range.Cells(_row, 20).value)
                            dakalrow("ApproximateMaghareCount") = IIf(used_range.Cells(_row, 21).value Is Nothing, DBNull.Value, used_range.Cells(_row, 21).value)
                            dakalrow("srl_Magharetype") = IIf(Not used_range.Cells(_row, 22).value Is Nothing, GetOrAdd(dic_Magharetype, "Pm_Line_Magharetype", used_range.Cells(_row, 22).value), DBNull.Value)
                            dakalrow("Srl_MaghareProvider") = IIf(Not used_range.Cells(_row, 23).value Is Nothing, GetOrAdd(dic_MaghareProvider, "Pm_Line_MaghareProvider", used_range.Cells(_row, 23).value), DBNull.Value)
                            dakalrow("MaghareClass") = IIf(used_range.Cells(_row, 24).value Is Nothing, 0, used_range.Cells(_row, 24).value)
                            dakalrow("MaghareCreateYear") = IIf(used_range.Cells(_row, 25).value Is Nothing, 0, used_range.Cells(_row, 25).value)
                            dakalrow("Is_Postarea") = IIf(used_range.Cells(_row, 26).value Is Nothing, 0, used_range.Cells(_row, 26).value)
                            dakalrow("Is_River") = IIf(used_range.Cells(_row, 27).value Is Nothing, 0, used_range.Cells(_row, 27).value)
                            dakalrow("Is_Montaine") = IIf(used_range.Cells(_row, 28).value Is Nothing, 0, used_range.Cells(_row, 28).value)
                            dakalrow("Is_Flat") = IIf(used_range.Cells(_row, 29).value Is Nothing, 0, used_range.Cells(_row, 29).value)
                            dakalrow("Is_CityArea") = IIf(used_range.Cells(_row, 30).value Is Nothing, 0, used_range.Cells(_row, 30).value)
                            dakalrow("Is_Road") = IIf(used_range.Cells(_row, 31).value Is Nothing, 0, used_range.Cells(_row, 31).value)
                            dakalrow("Is_20KW") = IIf(used_range.Cells(_row, 32).value Is Nothing, 0, used_range.Cells(_row, 32).value)
                            dakalrow("Is_Road") = IIf(used_range.Cells(_row, 33).value Is Nothing, 0, used_range.Cells(_row, 33).value)
                            dakalrow("Is_TransmitLine") = IIf(used_range.Cells(_row, 34).value Is Nothing, 0, used_range.Cells(_row, 34).value)
                            dakalrow("Is_resedential") = IIf(used_range.Cells(_row, 35).value Is Nothing, 0, used_range.Cells(_row, 35).value)
                            dakalrow("Is_Industrial") = IIf(used_range.Cells(_row, 36).value Is Nothing, 0, used_range.Cells(_row, 36).value)
                            dakalrow("Is_Forest") = IIf(used_range.Cells(_row, 37).value Is Nothing, 0, used_range.Cells(_row, 37).value)
                            dakalrow("Is_Military") = IIf(used_range.Cells(_row, 38).value Is Nothing, 0, used_range.Cells(_row, 38).value)
                            dakalrow("Is_MiddleBush") = IIf(used_range.Cells(_row, 39).value Is Nothing, 0, used_range.Cells(_row, 39).value)
                            dakalrow("Is_Alarm") = IIf(used_range.Cells(_row, 40).value Is Nothing, 0, used_range.Cells(_row, 40).value)
                            dakalrow("Is_Spacer") = IIf(used_range.Cells(_row, 41).value Is Nothing, 0, used_range.Cells(_row, 41).value)
                            dakalrow("Submitdate") = Now.Date
                            dakalrow("Srl_SubmitUser") = Setting.Srl_User
                            BaseDataObject.DataAccess.InsertWithLastId(dakalrow, False)

                        Catch ex As Exception
                            Exit For
                        End Try
                    Next

                    If ProgressBar1.Value < ProgressBar1.Maximum Then
                        ProgressBar1.PerformStep()
                    End If
                    KillExcelProcessThatUsedByThisInstance()
                Else
                    Line_Notfound = linename.ToString() + "," + Line_Notfound
                    notimported = notimported + 1
                    If ProgressBar1.Value < ProgressBar1.Maximum Then
                        ProgressBar1.PerformStep()
                    End If
                    KillExcelProcessThatUsedByThisInstance()
                End If
            Else
                    If Not s.Contains("$") Then
                        notimported = notimported + 1
                    End If
            End If
        Next
        MessageBoxFa.Show("اطلاعات  " + imported.ToString() + " خط منتقل گردید و اطلاعات " + notimported.ToString() + " خط منتقل نگردید.", "پیغام", MessageBoxButtons.OK)
        MessageBoxFa.Show("خطوط " + Line_Notfound.ToCharArray() + " در سیستم پیدا نشد")
    End Function
    Private Sub CheckForExistingExcellProcesses()
        dicExcel.Clear()
        Dim AllProcess() = Process.GetProcessesByName("excel")
        For Each p As Process In AllProcess
            dicExcel.Add(p.Id, 1)
        Next
    End Sub
    Private Sub KillExcelProcessThatUsedByThisInstance()
        Dim AllProcesses As Process() = Process.GetProcessesByName("excel")

        For Each ExcelProcess As Process In AllProcesses

            If ExcelProcess.Id = MyExcelProcessId Then
                ExcelProcess.Kill()
                Exit For
            End If
        Next

        AllProcesses = Nothing
    End Sub
    Private Sub GetTheExcelProcessIdThatUsedByThisInstance()
        Dim AllProcesses As Process() = Process.GetProcessesByName("excel")

        For Each ExcelProcess As Process In AllProcesses
            If dicExcel Is Nothing Then Return

            If dicExcel.ContainsKey(ExcelProcess.Id) = False Then
                MyExcelProcessId = ExcelProcess.Id
                Exit For
            End If
        Next

        AllProcesses = Nothing
    End Sub
    Private Function GetOrAdd(ByVal dic As Dictionary(Of String, Integer), ByVal tablename As String, ByVal name As String) As Integer
        If Not dic.ContainsKey(name) Then
            Dim dr = BaseDataObject.DataAccess.NewRow(tablename)
            dr("name") = name
            dic.Add(name, BaseDataObject.DataAccess.InsertWithLastId(dr, False))
        End If
        Return dic(name)

    End Function




End Class