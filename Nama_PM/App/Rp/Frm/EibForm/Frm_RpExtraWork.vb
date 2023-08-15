Imports System.IO
Public Class Frm_RpExtraWork
    Dim loadOption As Boolean = False
    Dim Person As Integer
    Dim Fromdate As String
    Dim Todate As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal Person As Integer, ByVal Fromdate As String, ByVal ToDate As String)
        InitializeComponent()
        loadOption = True
        Me.Person = Person
        Me.Fromdate = Fromdate
        Me.Todate = ToDate
    End Sub

    Private Sub Frm_RpExtraWork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Ashkhas1.Pm_Company' table. You can move, or remove it, as needed.
        Me.Pm_CompanyTableAdapter.Fill(Me.Ds_Ashkhas1.Pm_Company)
        'TODO: This line of code loads data into the 'Ds_Ashkhas1.Acc_Ashkhas' table. You can move, or remove it, as needed.
        Me.Acc_AshkhasTableAdapter1.Fill(Me.Ds_Ashkhas1.Acc_Ashkhas)
        'TODO: This line of code loads data into the 'Ds_Ashkhas1.Pm_AshkhasAzarakhsh' table. You can move, or remove it, as needed.
        Me.Pm_AshkhasAzarakhshTableAdapter1.Fill(Me.Ds_Ashkhas1.Pm_AshkhasAzarakhsh)
        'TODO: This line of code loads data into the 'Ds_Ashkhas1.Pm_AshkhasFanavaran' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        'Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        'Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        If loadOption Then
            cmb_Ashkhas.SelectedValue = Me.Person
            Me.txt_FromDate.Value = Me.Fromdate
            Me.txt_ToDate.Value = Me.Todate
            Add_Person_Click(Nothing, Nothing)

           
        Else
            Dim Month As Integer = CInt(Setting.TarikheJary.Substring(5, 2)) - 1
            Month = IIf(Month = 0, 12, Month)
            Me.txt_FromDate.Value = Setting.TarikheJary.Remove(5) + IIf(Month.ToString().Length = 1, "0" + Month.ToString(), Month.ToString()) + "/01"
            Me.txt_ToDate.Value = Setting.TarikheJary.Remove(5) + IIf(Month.ToString().Length = 1, "0" + Month.ToString(), Month.ToString()) + "/31"
        End If
        Me.rb_Mashroh.Checked = True
        Me.chk_AllPerson.Checked = True


    End Sub
    Public Function CurrectTime(ByVal st As String) As String
        Try
            Dim hour As String = st.Substring(0, st.IndexOf(":"))
            If hour.Length = 1 Then
                hour = "0" + hour
            End If
            Dim min As String = st.Substring(st.IndexOf(":") + 1)
            If min.Length = 1 Then
                min = "0" + min
            End If
            Return hour + ":" + min
        Catch
            Return "00:00"
        End Try
    End Function

    Public Function AddTime(ByVal Start As String, ByVal EndTime As String) As String
        Try
            'Start = CurrectTime(Start)
            'EndTime = CurrectTime(EndTime)
            Dim i As Integer = ((CInt(EndTime.Substring(0, EndTime.IndexOf(":"))) * 60 + CInt(EndTime.Substring(EndTime.IndexOf(":") + 1))) + (CInt(Start.Substring(0, Start.IndexOf(":"))) * 60 + CInt(Start.Substring(Start.IndexOf(":") + 1))))
            If i > 0 Then
                Return IIf((i \ 60).ToString().Length = 1, "0" + (i \ 60).ToString(), (i \ 60).ToString()) + ":" + IIf((i Mod 60).ToString().Length = 1, "0" + (i Mod 60).ToString(), (i Mod 60).ToString())
            Else
                Return "00:00"
            End If
        Catch ex As Exception
            Return "00:00"
        End Try
    End Function

    Public Function AddTime2(ByVal Start As String, ByVal EndTime As String) As String
        Dim i As Integer = ((CInt(EndTime.Substring(0, EndTime.IndexOf(":"))) * 60 + CInt(EndTime.Substring(EndTime.IndexOf(":")))) + (CInt(Start.Substring(0, Start.IndexOf(":"))) * 60 + CInt(Start.Substring(Start.IndexOf(":"), 2))))
        If i > 0 Then
            Return IIf((i \ 60).ToString().Length = 1, "0" + (i \ 60).ToString(), (i \ 60).ToString()) + ":" + IIf((i Mod 60).ToString().Length = 1, "0" + (i Mod 60).ToString(), (i Mod 60).ToString()) + ":00"
        Else
            Return "00:00:00"
        End If
    End Function

    Public Function SetTimeFormat(ByVal Input As String) As String
        If Input = "" Then
            Return "00:00"
        End If
        If Input.Length = 8 Then
            Return Input.Substring(0, 5)
        End If
        If Input.IndexOf(":") > -1 Then
            If Input.Substring(0, Input.IndexOf(":")).Length = 1 Then
                Input = "0" + Input
            End If
        End If
        If Input.Substring(Input.IndexOf(":") + 1).Length < 2 Then
            Input = Input.Substring(0, Input.IndexOf(":")) + ":" + "0" + Input.Substring(Input.IndexOf(":") + 1)
        End If
        If Input.Length = 5 Then
            Return Input
        Else
            Return "00:00"
        End If
    End Function

    Public Function RemoveZero(ByVal Inputdt As DataTable) As DataTable
        For i As Integer = 0 To Inputdt.Rows.Count - 1
            If Not i < Inputdt.Rows.Count Then
                Return Inputdt
            End If
            If (Inputdt.Rows(i)(11).ToString() = "0:0" Or Inputdt.Rows(i)(11).ToString() = "00:00" Or Inputdt.Rows(i)(11).ToString() = "00:00:00") And (Inputdt.Rows(i)(12).ToString() = "0:0" Or Inputdt.Rows(i)(12).ToString() = "00:00" Or Inputdt.Rows(i)(12).ToString() = "00:00:00") Then
                Inputdt.Rows.RemoveAt(i)
                i = i - 1
            End If
        Next
        Return Inputdt
    End Function
    Public Function RemoveZeroHazine(ByVal Inputdt As DataTable) As DataTable
        'For i As Integer = 0 To Inputdt.Rows.Count - 1
        '    If Not i < Inputdt.Rows.Count Then
        '        Return Inputdt
        '    End If
        '    If Inputdt.Rows(i)(5).ToString() = "0:0" Then
        '        Inputdt.Rows.RemoveAt(i)
        '        i = i - 1
        '    End If
        'Next
        Return Inputdt
    End Function

    Public Function MergDate(ByVal Inputdt As DataTable) As DataTable
        Dim MergedDr As DataRow
        Dim preTarikh As String = ""
        Dim PrePerson As String = ""
        Dim Person As String = ""
        Dim Tarikh As String = ""

        Dim Merged As Boolean = False
        Dim Predr As DataRow = Nothing
        Dim dt As New DataTable
        dt = Inputdt.Clone()
        For Each dr As DataRow In Inputdt.Rows
            Tarikh = dr(0).ToString()
            Person = dr(1).ToString()
            If Tarikh = preTarikh And Person = PrePerson Then
                Merged = True
                MergedDr(5) = IIf(MergedDr(5).ToString().Length > 0, MergedDr(5).ToString() + IIf(dr(5).ToString().Length > 0, "_ " + dr(5).ToString(), ""), dr(5).ToString())
                MergedDr(6) = IIf(MergedDr(6).ToString().Length > 0, MergedDr(6).ToString() + IIf(dr(6).ToString().Length > 0, "_ " + dr(6).ToString(), ""), dr(6).ToString())
                MergedDr(4) = IIf(MergedDr(4).ToString().Length > 0, MergedDr(4).ToString() + IIf(dr(4).ToString().Length > 0, "_ " + dr(4).ToString(), ""), dr(4).ToString())
                MergedDr(7) = IIf(MergedDr(7).ToString().Length > 0, MergedDr(7).ToString() + IIf(dr(7).ToString().Length > 0, "_ " + dr(7).ToString(), ""), dr(7).ToString())
                MergedDr(8) = AddTime(MergedDr(8).ToString(), dr(8).ToString())
                MergedDr(9) = AddTime(SetTimeFormat(MergedDr(9).ToString()), SetTimeFormat(dr(9).ToString()))
                MergedDr(10) = AddTime(SetTimeFormat(MergedDr(10).ToString()), SetTimeFormat(dr(10).ToString()))
                MergedDr(11) = AddTime(SetTimeFormat(MergedDr(11).ToString()), SetTimeFormat(dr(11).ToString()))
                MergedDr(12) = AddTime(SetTimeFormat(MergedDr(12).ToString()), SetTimeFormat(dr(12).ToString()))
                Continue For
            Else
                If Not Predr Is Nothing And Not Merged Then
                    dt.ImportRow(Predr)
                End If
                preTarikh = Tarikh
                PrePerson = Person
                If Not Merged Then
                    Predr = dr
                    MergedDr = dr
                Else
                    Predr = dr
                    Merged = False
                    dt.ImportRow(MergedDr)
                    MergedDr = dr
                End If
            End If
        Next
        If Not Predr Is Nothing And Not Merged Then
            dt.ImportRow(Predr)
        End If
        If Merged Then
            dt.ImportRow(MergedDr)
        End If
        Return dt
    End Function

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If Not chk_AllPerson.Checked And DGV_Person.RowCount < 1 Then
            MessageBox.Show("لطفا شخص مورد نظر را انتخاب کنید", "", MessageBoxButtons.OK)
            Return
        End If

        Dim Person As String = ""
        Dim Company As Integer = -1
        Company = Cmb_Company.SelectedValue
        If chk_AllPerson.Checked Then
            Person = "-1"
        Else
            For Each dr As DataGridViewRow In DGV_Person.Rows
                Try
                    Person = Person + dr.Cells(0).Value.ToString() + ","
                Catch
                End Try
            Next
            Person = Person + "-1"
        End If
        Dim rp
        If rb_Accounting.Checked Then
            rp = New Rp_MultiExtraWork

        Else
            rp = New Rp_MultiExtraWorkmashrih
        End If
        Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable("exec Rp_MultiEzafeKar '" + Person + "','" + txt_FromDate.Value + "','" + txt_ToDate.Value + "'," + Company.ToString())
        If rb_Accounting.Checked Then
            dt = MergDate(dt)
        Else
            dt = RemoveZero(dt)
        End If
        If rb_Accounting.Checked Then
            Dim dt1 As DataTable = BaseDataObject.DataAccess.GetDataTable("exec Rp_HazineCodeEzafeKar '" + Person + "','" + txt_FromDate.Value + "','" + txt_ToDate.Value + "'," + Company.ToString()).Copy()
            ' RemoveZeroHazine(dt1)
            rp.Subreports(0).SetDataSource(dt1)

        End If
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        rp.SetParameterValue(rp.Parameter_ToDate.ParameterFieldName, txt_ToDate.Value)
        rp.SetParameterValue(rp.Parameter_FromDate.ParameterFieldName, txt_FromDate.Value)
       
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()
    End Sub
   
  

    Private Sub chk_AllPerson_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllPerson.CheckedChanged
        cmb_Ashkhas.Enabled = Not chk_AllPerson.Checked
        Add_Person.Enabled = Not chk_AllPerson.Checked
        Del_Person.Enabled = Not chk_AllPerson.Checked

            Me.Pm_AshkhasWithCompanyTableAdapter.Fill(Me.Ds_Ashkhas1.Pm_AshkhasWithCompany, Cmb_Company.SelectedValue)
    End Sub

 


    Private Sub Post_Person_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del_Person.Click
        If Not DGV_Person.CurrentRow Is Nothing And DGV_Person.Rows.Count >= 1 Then
            DGV_Person.Rows.RemoveAt(DGV_Person.CurrentRow.Index)
        End If
    End Sub

   

    Private Sub Add_Person_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Person.Click
        For Each dr As DataGridViewRow In DGV_Person.Rows
            If dr.Cells(0).Value = cmb_Ashkhas.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DGV_Person.Rows.Add()
        DGV_Person.Rows(i).Cells(0).Value = cmb_Ashkhas.SelectedValue
        DGV_Person.Rows(i).Cells(1).Value = cmb_Ashkhas.Text
    End Sub

   

    Private Sub btn_File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_File.Click
        If Not chk_AllPerson.Checked And DGV_Person.RowCount < 1 Then
            MessageBox.Show("لطفا شخص مورد نظر را انتخاب کنید", "", MessageBoxButtons.OK)
            Return
        End If
        Dim Person As String = ""
        Dim Company As Integer = -1
        Company = Cmb_Company.SelectedValue
        If chk_AllPerson.Checked Then
            Person = "-1"
        Else
            For Each dr As DataGridViewRow In DGV_Person.Rows
                Try
                    Person = Person + dr.Cells(0).Value.ToString() + ","
                Catch
                End Try
            Next
            Person = Person + "-1"
        End If
        Dim rp
        If rb_Accounting.Checked Then
            rp = New Rp_MultiExtraWork
        Else
            MessageBoxFa.Show("لطفا گزارش حسابداری را انتخاب نمائید.")
            rb_Accounting.Focus()
            Return
        End If
        Dim dt1 As DataTable = BaseDataObject.DataAccess.GetDataTable("exec Rp_HazineCodeEzafeKar '" + Person + "','" + txt_FromDate.Value + "','" + txt_ToDate.Value + "'," + Company.ToString()).Copy()
        ' RemoveZeroHazine(dt1)
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim sw As StreamWriter = New StreamWriter(FolderBrowserDialog1.SelectedPath + "\\Report.txt")
            Dim temp As String = ""
            For Each dr As DataRow In dt1.Rows
                temp = dr(2).ToString() + "," + dr(4).ToString() + "," + dr(3).ToString() + "," + dr(5).ToString()
                sw.WriteLine(temp)
            Next
            sw.Close()
            MessageBoxFa.Show("فایل با موفقیت ذخیره گردید")
        Else
            Return
        End If

    End Sub



    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Pm_AshkhasTableAdapter.FillBy(Me.Ds_Ashkhas.Pm_Ashkhas)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

   




    Private Sub Chk_AllCompany_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllCompany.CheckedChanged
        Cmb_Company.Enabled = Not Chk_AllCompany.Checked
        If (Chk_AllCompany.Checked) Then
            Me.Pm_AshkhasWithCompanyTableAdapter.Fill(Me.Ds_Ashkhas1.Pm_AshkhasWithCompany, -1)

        End If
    End Sub

    Private Sub Cmb_Company_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Company.SelectedIndexChanged
        Me.Pm_AshkhasWithCompanyTableAdapter.Fill(Me.Ds_Ashkhas1.Pm_AshkhasWithCompany, Cmb_Company.SelectedValue)
    End Sub
End Class
