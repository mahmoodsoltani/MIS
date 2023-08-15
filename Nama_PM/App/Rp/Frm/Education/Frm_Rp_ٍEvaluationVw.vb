Public Class Frm_Rp_ٍEvaluationVw

    Private Sub Frm_RpHadeseVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Ashkhas)
        Me.Pm_Edu_TeacherTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Teacher)
        Me.Pm_Edu_DorePresenterTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DorePresenter)
        Me.Pm_Edu_DorePlaceTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DorePlace)

    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If


        Dim Place As Integer = -1
        If Not chk_Mahal.Checked Then
            Place = cmb_Place.SelectedValue
        End If

        Dim Presenter As Integer = -1
        If Not chk_Presenter.Checked Then
            Presenter = cmb_Presenter.SelectedValue
        End If

        Dim Teacher As Integer = -1
        If Not chk_Teacher.Checked Then
            Teacher = cmb_Teacher.SelectedValue
        End If

        Dim Ashkhas As Integer = -1
        If Not Chk_Ashakhs.Checked Then
            Ashkhas = cmb_Ashkhas.SelectedValue
        End If
        Dim Location As Integer = -1
        If Not chk_Location.Checked Then
            If rb_insideProvinence.Checked Then
                Location = 1
            ElseIf rb_outsideprovinence.Checked Then
                Location = 2
            Else
                Location = 3
            End If
        End If
        Dim type As Integer = 2
        If Rb_Teacher.Checked Then
            type = 1
        End If
        Dim sum As Integer = 0
        Me.Rp_DoreEvaluationTableAdapter.Fill(Me.Ds_Edu.Rp_DoreEvaluation, type, FromDate, ToDate, Place, Presenter, Teacher, Location)
        If Not Ds_Edu.Rp_DoreEvaluation.Columns.Contains("کل") Then
            Ds_Edu.Rp_DoreEvaluation.Columns.Add("کل")
        End If
        For i As Integer = 0 To Ds_Edu.Rp_DoreEvaluation.Rows.Count - 1
            sum = 0
            For j As Integer = 1 To Ds_Edu.Rp_DoreEvaluation.Columns.Count - 2
                sum += CInt(Ds_Edu.Rp_DoreEvaluation(i)(j))
            Next
            Ds_Edu.Rp_DoreEvaluation(i)(Ds_Edu.Rp_DoreEvaluation.Columns.Count - 1) = Math.Round(sum / (Ds_Edu.Rp_DoreEvaluation.Columns.Count - 2), 0)
        Next
        DataGridView1.DataSource = Me.Ds_Edu.Rp_DoreEvaluation
        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        lbl_Record.Text = "تعداد رکورد: " + Me.Ds_Edu.Rp_DoreEvaluation.Rows.Count.ToString
    End Sub

    Private Sub chk_allday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allday.CheckedChanged
        txt_FromDate.Enabled = Not chk_allday.Checked
        txt_ToDate.Enabled = Not chk_allday.Checked
    End Sub

    Private Sub chk_Mahal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Mahal.CheckedChanged
        cmb_Place.Enabled = Not chk_Mahal.Checked
    End Sub


    Private Sub chk_SharayeteBoroz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Presenter.CheckedChanged
        cmb_Presenter.Enabled = Not chk_Presenter.Checked
    End Sub

    Private Sub chk_Group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Teacher.CheckedChanged
        cmb_Teacher.Enabled = Not chk_Teacher.Checked
    End Sub
    Private Sub Chk_Ashakhs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Ashakhs.CheckedChanged
        cmb_Ashkhas.Enabled = Not Chk_Ashakhs.Checked
    End Sub


    Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim rp As New Rp_Hadese
        'Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        'If srl = -1 Then
        '    Return
        'End If
        'Try
        '    Rp_HadeseTableAdapter.Fill(Ds_Hadese.Rp_Hadese, srl)
        'Catch ex As Exception
        'End Try
        'Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable( _
        'Rp_HadeseTableAdapter.Adapter.SelectCommand.CommandText.Replace("@Srl", srl.ToString))
        'rp.SetDataSource(dt)
        'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        'Dim frm_rp As New Frm_RpVw(rp, dt)
        'frm_rp.ShowDialog()
    End Sub

    Private Sub Btn_PrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PrintAll.Click
        'Dim rp As New Rp_Hadese_PrintAll

        'Dim dt As DataTable = Ds_Hadese.Pm_Hadese
        'rp.SetDataSource(dt)
        'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        'Dim frm_rp As New Frm_RpVw(rp, dt)
        'frm_rp.ShowDialog()
    End Sub


    Private Sub cmb_Presenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Presenter.SelectedIndexChanged

    End Sub

    Private Sub chk_Location_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Location.CheckedChanged
        rb_insideProvinence.Enabled = Not chk_Location.Checked
        rb_outside.Enabled = Not chk_Location.Checked
        rb_outsideprovinence.Enabled = Not chk_Location.Checked
    End Sub
End Class