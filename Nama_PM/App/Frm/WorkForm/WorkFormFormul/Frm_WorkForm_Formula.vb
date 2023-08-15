Public Class Frm_WorkForm_Formula

    Dim IsTaradod As Boolean
    Public Sub New(ByVal IsTaradod As Boolean)
        InitializeComponent()

        If IsTaradod Then
            Me.Text += " - اضافه کار تردد"
        End If
        Me.IsTaradod = IsTaradod
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If Not chk_BazeZamaniNotImportant.Checked And (ts_FromSat.Value > ts_ToSat.Value Or ts_FromSat.Value = ts_ToSat.Value) Then
            MessageBoxFa.Show("بازه زمانی اشتباه انتخاب شده است")
            ts_FromSat.Focus()
            Return False
        End If

        Dim S_Taradod As String = 0

        If IsTaradod Then
            S_Taradod = "1"
        Else
            S_Taradod = "0"
        End If

        Dim Query As String = "select isnull(COUNT(*),0) from Pm_WorkForm_Formula " & _
"where Srl_Pm_WorkType=" + ComboBox3.SelectedValue.ToString & _
" And  Srl_DayOfWeak=" + cmb_Day.SelectedValue.ToString & _
" And  Srl_Pm_WorkForm_Formula_Profile=" + Cmb_Profile.SelectedValue.ToString + " and " & _
"(ToSat>'@@@' And  FromSat<'&&&') and IsTaradod=" + S_Taradod

        Query = Query.Replace("@@@", ts_FromSat.Value)
        Query = Query.Replace("&&&", ts_ToSat.Value)

        DataObject.DataRow("IsTaradod") = IsTaradod

        If CInt(BaseDataObject.DataAccess.ExecScalar(Query)) > 0 Then
            MessageBoxFa.Show("این بازه زمانی با بازه زمانی دیگری همپوشانی دارد")
            ts_FromSat.Focus()
            Return False
        End If
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Public Overrides Sub LoadDataGridView()
        Try
            Dim day As Integer = -1
            If chk_DayOfWeek.Checked Then
                day = cmb_Day.SelectedValue
            End If

            Dim prifile As Integer = -1
            If Chk_Profile.Checked Then
                prifile = Cmb_Profile.SelectedValue
            End If

            Pm_WorkForm_FormulaTableAdapter.Fill(Me.Ds_Pm.Pm_WorkForm_Formula, IsTaradod, prifile, day)
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
        End Try
        MyBase.LoadDataGridView()
    End Sub

    Private Sub Frm_WorkForm_Formula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_WorkForm_Formula_ProfileTableAdapter.Fill(Me.Ds_Pm.Pm_WorkForm_Formula_Profile)
        Try
            Me.Pm_WorkForm_FormulaTableAdapter.Fill(Me.Ds_Pm.Pm_WorkForm_Formula, IsTaradod, -1, -1)
            Me.Pm_WorkTypeTableAdapter.Fill(Me.Ds_Pm.Pm_WorkType)
            Me.Pm_DayOfWeekTableAdapter.Fill(Me.Ds_Pm.Pm_DayOfWeek)
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
        End Try
    End Sub

    'Private Sub chk_BazeZamaniNotImportant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_BazeZamaniNotImportant.CheckedChanged
    '    If chk_BazeZamaniNotImportant.Checked Then
    '        pnl_TimeToTime.Enabled = False
    '    Else
    '        pnl_TimeToTime.Enabled = True
    '    End If
    'End Sub

    Private Sub Btn_ShowFormul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ShowFormul.Click
        If Chk_Profile.Checked Then
            Dim s As New Frm_WorkForm_FormulaShow(IsTaradod, Cmb_Profile.SelectedValue)
            s.ShowDialog()
        Else
            Dim s As New Frm_WorkForm_FormulaShow(IsTaradod, 1)
            s.ShowDialog()
        End If
        
    End Sub

    Private Sub Chk_Profile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Profile.CheckedChanged
        LoadDataGridView()
    End Sub

    Private Sub Cmb_Profile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Profile.SelectedIndexChanged
        If Chk_Profile.Checked Then
            LoadDataGridView()
        End If
    End Sub

    Private Sub chk_DayOfWeek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DayOfWeek.CheckedChanged
        LoadDataGridView()
    End Sub

    Private Sub cmb_Day_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Day.SelectedIndexChanged
        If chk_DayOfWeek.Checked Then
            LoadDataGridView()
        End If
    End Sub
End Class