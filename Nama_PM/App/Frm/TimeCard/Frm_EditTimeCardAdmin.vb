Public Class Frm_EditTimeCardAdmin
    Public Hour As Integer = 0
    Public EzafeKar As String
    Public IsEdit As Boolean = False
    Public Min As Integer = 0
    Public ISChanged As Boolean = False
    Public UpdateGrid As Boolean = False
    Public ShowNewDar As Boolean = False
    Public TempCopy As String = ""
    Public CopyColumn As Integer = -1
    Public CanLoad As Boolean = True
    Public IsUserEdit = False
    Public IsAdminEdit = False
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.F4 Then
                Dim f As New Frm_RpExtraWork(cmb_Ashkhas.SelectedValue, txt_BeginDate.Value, txt_EndDate.Value)
                f.ShowDialog()
            ElseIf e.KeyCode = Keys.F5 Then
                Dim f As New Frm_CodeHazine
                f.ShowDialog()
            ElseIf e.KeyCode = Keys.F6 Then
                ShowNewDar = Not ShowNewDar
                NewDay()
            ElseIf e.KeyCode = Keys.F7 Then
                If Btn_ViewSave.Enabled Then
                    Btn_ViewSave_Click(Nothing, Nothing)
                End If
            ElseIf e.KeyCode = Keys.Back Then
                If DataGridView1 Is Me.ActiveControl Then
                    If DataGridView1.SelectedCells(0).ColumnIndex = 3 Or DataGridView1.SelectedCells(0).ColumnIndex = 4 Then
                        DataGridView1.CurrentRow.Cells(DataGridView1.SelectedCells(0).ColumnIndex).Value = ""
                    End If
                End If
            ElseIf e.KeyCode = Keys.C And e.Modifiers = Keys.Control Then
                If DataGridView1 Is Me.ActiveControl Then
                    TempCopy = DataGridView1.CurrentRow.Cells(DataGridView1.SelectedCells(0).ColumnIndex).Value
                    CopyColumn = DataGridView1.SelectedCells(0).ColumnIndex
                End If
            ElseIf e.KeyCode = Keys.V And e.Modifiers = Keys.Control Then
                If TempCopy <> "" Then
                    If CopyColumn = DataGridView1.SelectedCells(0).ColumnIndex Then
                        DataGridView1.CurrentRow.Cells(DataGridView1.SelectedCells(0).ColumnIndex).Value = TempCopy
                        If HappenChanged() Then
                            lb_IsChanged.ForeColor = Color.Red
                            lb_IsChanged.Text = "جدول دارای تغییرات است"
                            Btn_ViewSave.Enabled = True
                            ISChanged = True
                        End If
                    Else
                        MessageBoxFa.Show("لطفا مقدار مورد نظر را به همان ستون اولیه انتقال دهید ")
                    End If
                End If
            Else
                MyBase.OnKeyDown(e)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub NewDay()
        If ShowNewDar Then
            gbx_Controls.Visible = True
            gbx_GridViewList.Height = Me.Height - gbx_Btn.Height - StatusStrip1.Height - gbx_Controls.Height - 20
            DataGridView1.Height = Me.Height - gbx_Btn.Height - StatusStrip1.Height - gbx_Controls.Height - 120
            gbx_Btn.Location = New Drawing.Point(gbx_Btn.Location.X, StatusStrip1.Location.Y - gbx_Btn.Height - gbx_Controls.Height - 10)
            btn_Delete.Enabled = True
            btn_Edit.Enabled = True
            btn_new.Enabled = True

        Else
            gbx_Btn.Location = New Drawing.Point(gbx_Btn.Location.X, Me.Height - gbx_Btn.Height - StatusStrip1.Height - 10)
            gbx_Controls.Visible = False
            gbx_GridViewList.Height = Me.Height - gbx_Btn.Height - StatusStrip1.Height - 40
            DataGridView1.Height = gbx_GridViewList.Height - 100
            btn_Delete.Enabled = False
            btn_Edit.Enabled = False
            btn_new.Enabled = False

        End If
    End Sub

    Public Function GetHour(ByVal Time As String) As Integer
        Try
            Return CInt(Time.Substring(0, Time.IndexOf(":")))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetMin(ByVal Time As String) As Integer
        Try
            Return CInt(Time.Substring(Time.IndexOf(":") + 1, 2))
        Catch
            Try
                Return CInt(Time.Substring(Time.IndexOf(":") + 1, 1))
            Catch
            End Try
        End Try
        Return 0
    End Function

    Public Function IsDateValid() As Boolean
        Dim dt As FarsiDateFun
        Try

            dt = New FarsiDateFun(txt_BeginDate.Value.ToString().Substring(0, txt_BeginDate.Value.ToString().IndexOf("/")), txt_BeginDate.Value.ToString().Substring(txt_BeginDate.Value.ToString().IndexOf("/") + 1, 2), txt_BeginDate.Value.ToString().Substring(txt_BeginDate.Value.ToString().LastIndexOf("/") + 1))
        Catch ex As Exception
            MessageBoxFa.Show("تاریخ شروع نامعتبر است")
            txt_BeginDate.Focus()
            Return False
        End Try
        Try
            dt = New FarsiDateFun(txt_EndDate.Value.ToString().Substring(0, txt_EndDate.Value.ToString().IndexOf("/")), txt_EndDate.Value.ToString().Substring(txt_EndDate.Value.ToString().IndexOf("/") + 1, 2), txt_EndDate.Value.ToString().Substring(txt_EndDate.Value.ToString().LastIndexOf("/") + 1))
        Catch ex As Exception
            MessageBoxFa.Show("تاریخ پایان نامعتبر است")
            txt_EndDate.Focus()
            Return False
        End Try
        Return True
    End Function

    Public Sub SetRowColor()
        Hour = 0
        Min = 0
        EzafeKar = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If CInt(BaseDataObject.DataAccess.ExecScalar("select ISNULL(Count(*),0) from pm_Taghvim where type in (2,3) and tarikh='" + DataGridView1.Rows(i).Cells(2).Value + "'")) > 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Silver
            End If
            If CInt(BaseDataObject.DataAccess.ExecScalar("Select ISNULL(Count(*),0) from Pm_WorkFrom_Detail where srl_Pm_ashkhas=" + cmb_Ashkhas.SelectedValue.ToString + " and WorkFormTarikh='" + DataGridView1.Rows(i).Cells(2).Value.ToString() + "'")) Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                'Try
                '    TimeCard_WorkFormTableAdapter.Fill(Ds_Rp.TimeCard_WorkForm, cmb_Ashkhas.SelectedValue, DataGridView1.Rows(i).Cells(2).Value.ToString())
                '    If Not Ds_Rp.TimeCard_WorkForm Is Nothing Then
                '        DataGridView1.Rows(i).Cells(3).Value = Ds_Rp.TimeCard_WorkForm.Rows(0).Item(0).ToString()
                '        DataGridView1.Rows(i).Cells(4).Value = Ds_Rp.TimeCard_WorkForm.Rows(0).Item(1).ToString()
                '        DataGridView1.Rows(i).Cells(5).Value = Ds_Rp.TimeCard_WorkForm.Rows(0).Item(2).ToString()
                '        DataGridView1.Rows(i).Cells(6).Value = Ds_Rp.TimeCard_WorkForm.Rows(0).Item(3).ToString()
                '        DataGridView1.Rows(i).Cells(10).Value = Ds_Rp.TimeCard_WorkForm.Rows(0).Item(4).ToString()
                '    End If
                '    DataGridView1.Rows(i).ReadOnly = True
                '    Dim f As New Font("tahoma", 10, FontStyle.Bold)
                '    DataGridView1.Rows(i).DefaultCellStyle.Font = f

                'Catch
                'End Try
            End If
            Hour = Hour + GetHour(DataGridView1.Rows(i).Cells(10).Value.ToString()) '' + GetHour(DataGridView1.Rows(i).Cells(9).Value.ToString()) + GetHour(DataGridView1.Rows(i).Cells(10).Value.ToString())
            Min = Min + GetMin(DataGridView1.Rows(i).Cells(10).Value.ToString()) '' + GetMin(DataGridView1.Rows(i).Cells(9).Value.ToString()) + GetMin(DataGridView1.Rows(i).Cells(10).Value.ToString())
        Next
        lb_Sum.Text = ((Hour + (Min \ 60))).ToString + ":" + (Min Mod 60).ToString()


        'lb_kol.Text = BaseDataObject.DataAccess.ExecScalar("exec Rp_SumExtraWork '" + cmb_Ashkhas.SelectedValue + "','" + txt_BeginDate.Value + "','" + txt_EndDate.Value + "'".ToString())
        lb_kol.Text = BaseDataObject.DataAccess.ExecScalar("exec Rp_SumExtraWork '" + cmb_Ashkhas.SelectedValue.ToString() + "','" + txt_BeginDate.Value + "','" + txt_EndDate.Value + "'")
        ISChanged = False
        lb_IsChanged.ForeColor = Color.Green
        lb_IsChanged.Text = "جدول بروز است"
        'Try
        '    txt_PersonCode.Text = cmb_Ashkhas.SelectedValue(2)
        'Catch ex As Exception
        '    txt_PersonCode.Text = ""
        'End Try
    End Sub
    Public Sub Persmision()
        'If Setting.Srl_User = cmb_Ashkhas.SelectedValue And cmb_Ashkhas.Items.Count > 1 Then
        '    If Not IsAdminEdit And Not IsUserEdit Then
        '        For i As Integer = 0 To DataGridView1.ColumnCount - 1
        '            DataGridView1.Columns(i).ReadOnly = True
        '        Next
        '        btn_Save.Visible = False
        '        Lb_Permision.Visible = True
        '    Else
        '        For i As Integer = 0 To DataGridView1.ColumnCount - 2
        '            If Not Ds_TimeCard.Pm_timeCard.Columns(i).ReadOnly Then
        '                DataGridView1.Columns(i).ReadOnly = False
        '            End If
        '        Next
        '        btn_Save.Visible = True
        '        Lb_Permision.Visible = False
        '    End If
        'ElseIf Setting.Srl_User = cmb_Ashkhas.SelectedValue And cmb_Ashkhas.Items.Count = 1 Then
        If Setting.Srl_User = cmb_Ashkhas.SelectedValue Then
            If Not IsUserEdit Then
                For i As Integer = 0 To DataGridView1.ColumnCount - 2
                    DataGridView1.Columns(i).ReadOnly = True
                Next
                btn_Save.Visible = False
                Lb_Permision.Visible = True
            Else
                For i As Integer = 1 To DataGridView1.ColumnCount - 3
                    If Not Ds_TimeCard.Pm_timeCard.Columns(i).ReadOnly Then
                        DataGridView1.Columns(i).ReadOnly = False
                    End If
                Next
                btn_Save.Visible = True
                Lb_Permision.Visible = False
            End If

        Else
            If Not IsAdminEdit Then
                For i As Integer = 0 To DataGridView1.ColumnCount - 2
                    DataGridView1.Columns(i).ReadOnly = True
                Next
                btn_Save.Visible = False
                Lb_Permision.Visible = True
            Else
                For i As Integer = 1 To DataGridView1.ColumnCount - 3
                    If Not Ds_TimeCard.Pm_timeCard.Columns(i).ReadOnly Then
                        DataGridView1.Columns(i).ReadOnly = False
                    End If
                Next
                btn_Save.Visible = True
                Lb_Permision.Visible = False
            End If
        End If
    End Sub
    Public Overrides Sub LoadDataGridView()
        If CanLoad Then
            If Not cmb_Ashkhas.SelectedValue Is Nothing Then
                If IsDateValid() Then
                    Pm_timeCardTableAdapter.Fill(Ds_TimeCard.Pm_timeCard, cmb_Ashkhas.SelectedValue, txt_BeginDate.Value, txt_EndDate.Value, -1)
                    If UpdateGrid Then
                        InsertMisRow()
                        Pm_timeCardTableAdapter.Fill(Ds_TimeCard.Pm_timeCard, cmb_Ashkhas.SelectedValue, txt_BeginDate.Value, txt_EndDate.Value, -1)
                    End If
                    SetRowColor()
                    UpdateGrid = False
                End If
            Else
                Pm_timeCardTableAdapter.Fill(Ds_TimeCard.Pm_timeCard, -1, txt_BeginDate.Value, txt_EndDate.Value, -1)
            End If
        End If
        For Each dr As DataGridViewRow In DataGridView1.Rows

            If dr.DefaultCellStyle.BackColor = Color.Pink Then

                'If dr.Cells(4).Value = "" Then
                dr.Cells(3).Value = BaseDataObject.DataAccess.ExecScalar("select code from Pm_HazineCode where Srl in (select srl_HazineCode from PM_WorkFrom_Detail where Srl_Pm_Ashkhas = '" + cmb_Ashkhas.SelectedValue.ToString() + "' And WorkFormTarikh = '" + dr.Cells(2).Value + "') ").ToString()
            End If
        Next

         Persmision()
    End Sub

    Public Sub InsertMisRow()
        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_TimeCard")
        Dim _Date As New FarsiDateFun(txt_BeginDate.Value.ToString().Substring(0, txt_BeginDate.Value.ToString().IndexOf("/")), txt_BeginDate.Value.ToString().Substring(txt_BeginDate.Value.ToString().IndexOf("/") + 1, 2), txt_BeginDate.Value.ToString().Substring(txt_BeginDate.Value.ToString().LastIndexOf("/") + 1))
        Dim _EndDate As New FarsiDateFun(txt_EndDate.Value.ToString().Substring(0, txt_EndDate.Value.ToString().IndexOf("/")), txt_EndDate.Value.ToString().Substring(txt_EndDate.Value.ToString().IndexOf("/") + 1, 2), txt_EndDate.Value.ToString().Substring(txt_EndDate.Value.ToString().LastIndexOf("/") + 1))
        Dim RowIndex As Integer = 0
        While Not _Date Is Nothing And Not _EndDate Is Nothing And _Date.Date < _EndDate.AddDays(1).Date
            If RowIndex <= Ds_TimeCard.Pm_timeCard.Rows.Count - 1 Then
                If Ds_TimeCard.Pm_timeCard.Rows(RowIndex)(2).ToString() = _Date.Date.ToString() Then
                    _Date = _Date.AddDays(1)
                    RowIndex = RowIndex + 1
                    Continue While
                End If
            End If
            dr("Srl_Pm_ashkhas") = cmb_Ashkhas.SelectedValue.ToString
            dr("Tarikh") = _Date
            dr("Srl_SubmitUser") = Setting.Srl_User.ToString()
            dr("SubmitDate") = Setting.Now
            dr("BeginTimeExtraWork") = "00:00"
            dr("EndTimeExtraWork") = "00:00"
            dr("HolidayExtraWork") = "00:00"
            dr("EnterTime1") = "00:00"
            dr("ExitTime1") = "00:00"
            dr("MissionExtraWork") = "00:00"
            If BaseDataObject.DataAccess.GetDataTable("select * from pm_timeCard where srl_Pm_Ashkhas=" + cmb_Ashkhas.SelectedValue.ToString + " and Tarikh='" + _Date.Date + "'").Rows.Count < 1 Then
                BaseDataObject.DataAccess.Insert(dr, False)
            End If
            _Date = _Date.AddDays(1)
        End While
    End Sub

    Public Function NextRow(ByVal Row As Integer, ByVal e As System.Windows.Forms.KeyEventArgs) As Integer
        If e.KeyCode = Keys.Up And Row > 0 Then
            Return Row - 1
        End If
        If e.KeyCode = Keys.Down And Row < DataGridView1.RowCount - 1 Then
            Return Row + 1
        End If
        Return Row
    End Function

    Public Function NextCol(ByVal Col As Integer, ByVal e As System.Windows.Forms.KeyEventArgs) As Integer
        If e.KeyCode = Keys.Left And Col < DataGridView1.ColumnCount - 1 Then
            While Col < DataGridView1.ColumnCount - 1 And Not DataGridView1.Columns(Col + 1).Visible
                Col = Col + 1
            End While
        End If
        If e.KeyCode = Keys.Right And Col > 0 Then
            While Col > 0 And Not DataGridView1.Columns(Col - 1).Visible
                Col = Col - 1
            End While
        End If
        Return Col
    End Function

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean

    End Function

    Public Overrides Sub ClearForm()
        For Each c As Control In gbx_Controls.Controls
            If c.Name = "lk_Ashkhas" Or c.Name = "txt_BeginDate" Or c.Name = "txt_EndDate" Then
                Continue For
            ElseIf (TypeOf (c) Is Tbox) Then
                CType(c, Tbox).Clear()
                CType(c, Tbox).Modified = False
            ElseIf (TypeOf (c) Is CS_Component.TextBox) Then
                CType(c, CS_Component.TextBox).Clear()
                CType(c, CS_Component.TextBox).Modified = False
            ElseIf (TypeOf (c) Is VB_Component.ComboBox) Then
                If CType(c, VB_Component.ComboBox).Items.Count > 0 Then
                    CType(c, VB_Component.ComboBox).SelectedIndex = 0
                End If
            ElseIf (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Checked = False
            ElseIf (TypeOf (c) Is LookUpButton) Then
                CType(c, LookUpButton).ResetResult()
            ElseIf (TypeOf (c) Is LookupBox) Then
                'CType(C, LookupBox).ResetResult()
            ElseIf (TypeOf (c) Is PictureGetter) Then
                CType(c, PictureGetter).Image = Nothing
            ElseIf TypeOf (c) Is Label And Not c.Tag Is Nothing Then
                CType(c, Label).Text = ""
            ElseIf TypeOf (c) Is TimeSelect And Not c.Tag Is Nothing Then
                CType(c, TimeSelect).Value = "00:00"
            End If
        Next
    End Sub

    Private Sub Frm_Vahed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Setting.AdminEditEndDate.PropValue.ToString() = "" Or Setting.AdminEditStartDate.PropValue.ToString() = "" Or Setting.UserEditEndDate.PropValue.ToString() = "" Or Setting.UserEditStartDate.PropValue.ToString() = "" Or Setting.ReportEndDate.PropValue.ToString() = "" Or Setting.ReportStartDate.PropValue.ToString() = "" Then
            MessageBoxFa.Show("به منظور تنظیم بازه ویرایش با مدیر سیستم تماس بگیرید")
            Me.Close()
            Return
        End If
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Pm_Ashkhas' table. You can move, or remove it, as needed.
        If Setting.TarikheJary >= Setting.AdminEditStartDate.PropValue.ToString() And Setting.TarikheJary <= Setting.AdminEditEndDate.PropValue.ToString() Then
            IsAdminEdit = True
        End If
        If Setting.TarikheJary >= Setting.UserEditStartDate.PropValue.ToString() And Setting.TarikheJary <= Setting.UserEditEndDate.PropValue.ToString() Then
            IsUserEdit = True
        End If
        Me.Pm_AshkhasWithAdminTableAdapter.Fill(Me.Ds_Ashkhas.Pm_AshkhasWithAdmin, Setting.Srl_User)

        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            DataGridView1.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        Me.Pm_HazineCodeTableAdapter.Fill(Me.Ds_Pm.Pm_HazineCode, 1)
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        If Setting.ReportStartDate.PropValue.ToString() <> "" And Setting.ReportEndDate.PropValue.ToString() <> "" Then
            txt_BeginDate.Value = Setting.ReportStartDate.PropValue.ToString()
            txt_EndDate.Value = Setting.ReportEndDate.PropValue.ToString()
        End If
        LoadDataGridView()

    End Sub

    Private Sub lk_Ashkhas_Selected(ByVal sender As System.Object, ByVal e As System.Data.DataRow)
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

    Public Function CalHoliday(ByVal Start As String, ByVal EndTime As String, ByVal isHoliday As Boolean) As String
        Dim i As Integer = ((CInt(EndTime.Substring(0, 2)) * 60 + CInt(EndTime.Substring(3, 2))) - (CInt(Start.Substring(0, 2)) * 60 + CInt(Start.Substring(3, 2)))) * IIf(isHoliday, Setting.HolidayZarib.PropValue, 1)
        If i > 0 Then
            Return IIf((i \ 60).ToString().Length = 1, "0" + (i \ 60).ToString(), (i \ 60).ToString()) + ":" + IIf((i Mod 60).ToString().Length = 1, "0" + (i Mod 60).ToString(), (i Mod 60).ToString())
        Else
            Return "00:00"
        End If
    End Function

    Private Function HappenChanged() As Boolean
        Try
            For i As Integer = 0 To DataGridView1.Columns.Count
                If DataGridView1.CurrentRow.Cells(i).FormattedValue <> DataGridView1.CurrentRow.Cells(i).EditedFormattedValue Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub DataGridView1_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
        If HappenChanged() Then
            lb_IsChanged.ForeColor = Color.Red
            lb_IsChanged.Text = "جدول دارای تغییرات است"
            Btn_ViewSave.Enabled = True
            ISChanged = True
            Dim IsHoliday As Boolean = IIf(CInt(BaseDataObject.DataAccess.ExecScalar("select ISNULL(Count(*),0) from pm_Taghvim where type in (2,3) and tarikh='" + DataGridView1.CurrentRow.Cells(2).Value + "'")) > 0, True, False)
            Try
                If Not DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).EditType.ToString() = "System.Windows.Forms.DataGridViewComboBoxEditingControl" Then
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue
                End If
                Try
                    If IsHoliday And e.ColumnIndex <> 10 Then
                        DataGridView1.CurrentRow.Cells(10).Value = CalHoliday(SetTimeFormat(DataGridView1.CurrentRow.Cells(5).EditedFormattedValue), SetTimeFormat(DataGridView1.CurrentRow.Cells(6).EditedFormattedValue), IsHoliday)
                    End If
                Catch ex As Exception

                End Try
                Btn_ViewSave_Click(Nothing, Nothing)
            Catch
            End Try
        ElseIf Not ISChanged Then
            lb_IsChanged.ForeColor = Color.Green
            lb_IsChanged.Text = "جدول بروز است"
        End If

    End Sub

    Private Sub DataGridView1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyUp

    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        Try

            ''RemoveHandler Me.DataGridView1.CellLeave, AddressOf Me.DataGridView1_CellLeave
            'Col = NextCol(Col, e)
            'Row = NextRow(Row, e)
            'DataGridView1.CurrentCell = DataGridView1(Col, Row)
            ''AddHandler Me.DataGridView1.CellLeave, AddressOf DataGridView1_CellLeave
        Catch
        End Try
    End Sub

    Private Sub Btn_ViewSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_EndDate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateGrid = True
        LoadDataGridView()


    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadDataGridView()
    End Sub



    Private Sub Btn_ViewSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ViewSave.Click
        Dim Hour As Integer = 0
        Dim Min As Integer = 0
        Dim EzafeKar As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            Hour = Hour + GetHour(DataGridView1.Rows(i).Cells(10).Value.ToString()) '' + GetHour(DataGridView1.Rows(i).Cells(9).Value.ToString()) + GetHour(DataGridView1.Rows(i).Cells(10).Value.ToString())
            Min = Min + GetMin(DataGridView1.Rows(i).Cells(10).Value.ToString()) '' + GetMin(DataGridView1.Rows(i).Cells(9).Value.ToString()) + GetMin(DataGridView1.Rows(i).Cells(10).Value.ToString())
        Next
        lb_Sum.Text = ((Hour + (Min \ 60))).ToString + ":" + (Min Mod 60).ToString()

        lb_kol.Text = BaseDataObject.DataAccess.ExecScalar("exec Rp_SumExtraWork '" + cmb_Ashkhas.SelectedValue.ToString() + "','" + txt_BeginDate.Value + "','" + txt_EndDate.Value + "'")
        'lb_kol.Text = EzafeKar.ToString()
    End Sub

    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateGrid = True
        LoadDataGridView()
    End Sub

   
    Private Sub DataGridView1_CellChange(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.CellChange
        Dim row As Integer
        Dim col As Integer
        row = DataGridView1.CurrentCell.RowIndex
        col = DataGridView1.CurrentCell.ColumnIndex
        If e.KeyCode = Keys.Enter Then
            If col = 10 And row < DataGridView1.RowCount - 1 Then
                DataGridView1.CurrentCell = DataGridView1.Item(col, row + 1)
                Return
            End If
        End If
        If col = DataGridView1.ColumnCount - 1 And row = DataGridView1.RowCount - 1 Then
            Return
        End If
        If e.KeyCode = Keys.Enter Then
            If col = DataGridView1.ColumnCount - 1 Then
                col = 0
                row = row + 1
            End If
            col = col + 1
            While Not DataGridView1.Columns(col).Visible
                If col = DataGridView1.ColumnCount - 1 Then
                    col = 0
                    row = row + 1
                End If
                col = col + 1
            End While
            If row = DataGridView1.RowCount Then
                Return
            End If
            DataGridView1.CurrentCell = DataGridView1.Item(col, row)
        End If
        'If col = 3 Then
        '    DataGridView1.Rows(row).Cells(4).Value = BaseDataObject.DataAccess.ExecScalar("select Sharh from Pm_HazineCode where code = '" + DataGridView1.Rows(row).Cells(3).EditedFormattedValue + "'")
        'End If
    End Sub
    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        Return
    End Sub
    Private Sub DataGridView1_ColumnHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseDoubleClick
        Return
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).DefaultCellStyle.BackColor = Color.Pink And DataGridView1.CurrentCell.ColumnIndex = 22 Then

            Dim f As New Frm_ShowWorkForm(cmb_Ashkhas.SelectedValue.ToString(), DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value.ToString())
            f.ShowDialog()
        End If
    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        Dim row As Integer
        Dim col As Integer
        row = DataGridView1.CurrentCell.RowIndex
        col = DataGridView1.CurrentCell.ColumnIndex
        If col = 3 Then
            DataGridView1.Rows(row).Cells(4).Value = BaseDataObject.DataAccess.ExecScalar("select Sharh from Pm_HazineCode where code = '" + DataGridView1.Rows(row).Cells(3).EditedFormattedValue + "'")
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim EndTimeExtraWork As String
        Dim HolidayExtraWork As String
        Dim IsHoliday As Boolean = False
        Dim BeginTimeExtraWork As String
        Dim code As String = ""
        Dim post As String = ""
        Dim Query As String = ""
        Try
            For Each dr As DataGridViewRow In DataGridView1.Rows
                IsHoliday = IIf(CInt(BaseDataObject.DataAccess.ExecScalar("select ISNULL(Count(*),0) from pm_Taghvim where type in (2,3) and tarikh='" + dr.Cells(2).Value + "'")) > 0, True, False)
                BeginTimeExtraWork = "00:00"
                If IsHoliday Then
                    EndTimeExtraWork = "00:00"
                    If (dr.Cells(10).EditedFormattedValue.ToString().Length > 5) Then

                        HolidayExtraWork = dr.Cells(10).EditedFormattedValue.ToString().Substring(0, 5)
                    Else
                        HolidayExtraWork = dr.Cells(10).EditedFormattedValue.ToString()
                    End If
                Else
                    If (dr.Cells(10).EditedFormattedValue.ToString().Length > 5) Then
                        EndTimeExtraWork = dr.Cells(10).EditedFormattedValue.ToString().Substring(0, 5)
                    Else
                        EndTimeExtraWork = dr.Cells(10).EditedFormattedValue.ToString()

                    End If
                    HolidayExtraWork = "00:00"
                End If
                BaseDataObject.DataAccess.BeginTransaction()
                If Not dr Is Nothing Then
                    code = BaseDataObject.DataAccess.ExecScalar("select srl from pm_hazinecode where code='" + dr.Cells(3).EditedFormattedValue.ToString() + "'")
                    post = BaseDataObject.DataAccess.ExecScalar("select srl from Pm_Post where Name='" + dr.Cells(4).EditedFormattedValue.ToString() + "'")
                    Query = "Update Pm_TimeCard set BeginTimeExtraWork='" + BeginTimeExtraWork + "', " & _
                                                        "EndTimeExtraWork='" + EndTimeExtraWork + "'," & _
                                                        "HolidayExtraWork='" + HolidayExtraWork + "'," & _
                                                        "EnterTime1='" + dr.Cells(5).EditedFormattedValue + "'," & _
                                                        "ExitTime1='" + dr.Cells(6).EditedFormattedValue + "'" & _
                                                        ", MissionExtraWork='" + dr.Cells(21).EditedFormattedValue + "'" & _
                                                        ", ActivityPlace='" + dr.Cells(4).EditedFormattedValue + "'" & _
                                                          ", CodeHazine='" + dr.Cells(3).EditedFormattedValue + "'" & _
                                                          ", Srl_Pm_CodeHaizne=" + IIf(code Is Nothing, -1, code).ToString & _
                                                        " where Srl = " + dr.Cells(0).Value.ToString()

                    'If BaseDataObject.DataAccess.ExecQuery(Query) Then
                    '    MessageBoxFa.Show("اطلاعات با موفقیت ذخیره شد")
                    'Else
                    '    MessageBoxFa.Show("خطا در ذخیره سازی اطلاعات")
                    'End If
                    If Not BaseDataObject.DataAccess.ExecQuery(Query) Then
                        BaseDataObject.DataAccess.RollBack()
                        MessageBoxFa.Show("خطا در ذخیره سازی اطلاعات")
                    End If
                End If
            Next
            BaseDataObject.DataAccess.Commit()
            MessageBoxFa.Show("اطلاعات با موفقیت ذخیره شد")
            lb_IsChanged.ForeColor = Color.Green
            lb_IsChanged.Text = "جدول بروز است"
            ISChanged = False
            UpdateGrid = False
            LoadDataGridView()
        Catch
            BaseDataObject.DataAccess.RollBack()
            MessageBoxFa.Show("خطا در ذخیره سازی اطلاعات")
        End Try
    End Sub

    Private Sub cmb_Ashkhas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Ashkhas.SelectedIndexChanged
      
        LoadDataGridView()
    End Sub

  

    Private Sub txt_BeginDate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_EndDate.Leave, txt_BeginDate.Leave
        LoadDataGridView()
    End Sub

  

    Private Sub txt_BeginDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BeginDate.TextChanged

    End Sub
End Class