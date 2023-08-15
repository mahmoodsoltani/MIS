Public Class Frm_RpPmCancle
    Dim Srl_Pm_Tajhiz_ForSave As Integer = -1
    Private Sub Frm_RpExtraWork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_CancelCause' table. You can move, or remove it, as needed.
        Me.Pm_CancelCauseTableAdapter.Fill(Me.Ds_Pm1.Pm_CancelCause)
        'TODO: This line of code loads data into the 'Ds_Hadese.test' table. You can move, or remove it, as needed.
        Me.TestTableAdapter.Fill(Me.Ds_Hadese.test)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter1.Fill(Me.Ds_Pm1.Pm_Post)

        chk_AllFilter.Checked = True
        chk_allCanlce.Checked = True
        chk_allTajhiz.Checked = True
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim Post As String = "-1"
        Dim Cancle As String = "-2"
        Dim tajhiz As String = "-1"
        If (Not chk_AllFilter.Checked) Then
            For Each dr As DataGridViewRow In DGV_Filter.Rows
                Try
                    Post = Post + "," + dr.Cells(0).Value.ToString()
                Catch
                End Try
            Next
        End If
        If (Not chk_allCanlce.Checked) Then
            For Each dr As DataGridViewRow In DataGridView2.Rows
                Try
                    Cancle = Cancle + "," + dr.Cells(0).Value.ToString()
                Catch
                End Try
            Next
        End If

        If (Not chk_allTajhiz.Checked) Then
            For Each dr As DataGridViewRow In DataGridView1.Rows
                Try
                    tajhiz = tajhiz + "," + dr.Cells(0).Value.ToString()
                Catch
                End Try
            Next
        End If
        Dim rp As New Rp_PmCancleCause
        Rp_PmCancleTableAdapter.Fill(Ds_Rp2.Rp_PmCancle, txt_FromDate.Value, txt_ToDate.Value, tajhiz, Post, Cancle)
        Dim dt As DataTable = Ds_Rp2.Rp_PmCancle
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()
    End Sub



    Private Sub Post_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Add.Click
        For Each dr As DataGridViewRow In DGV_Filter.Rows
            If dr.Cells(0).Value = cmb_Post.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DGV_Filter.Rows.Add()
        DGV_Filter.Rows(i).Cells(0).Value = cmb_Post.SelectedValue
        DGV_Filter.Rows(i).Cells(1).Value = cmb_Post.Text
    End Sub

    Private Sub Post_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Del.Click
        If Not DGV_Filter.CurrentRow Is Nothing And DGV_Filter.Rows.Count >= 1 Then
            DGV_Filter.Rows.RemoveAt(DGV_Filter.CurrentRow.Index)
        End If
    End Sub

    Private Sub chk_AllFilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllFilter.CheckedChanged
        cmb_Post.Enabled = Not chk_AllFilter.Checked
        DGV_Filter.Enabled = Not chk_AllFilter.Checked
        Post_Del.Enabled = Not chk_AllFilter.Checked
        Post_Add.Enabled = Not chk_AllFilter.Checked
    End Sub



    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        Dim s As New Frm_DeviceSelectWithPost()
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_TajhizNameForSave.Value = s.SelectedDevice.Text
            Srl_Pm_Tajhiz_ForSave = s.SelectedDevice.Srl
            btn_addTajhiz.Focus()
        End If
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addTajhiz.Click
        If Srl_Pm_Tajhiz_ForSave <> -1 Then
            For Each dr As DataGridViewRow In DataGridView1.Rows
                If dr.Cells(0).Value = Srl_Pm_Tajhiz_ForSave Then
                    Return
                End If
            Next
            Dim i As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells(0).Value = Srl_Pm_Tajhiz_ForSave
            DataGridView1.Rows(i).Cells(1).Value = txt_TajhizNameForSave.Value
        End If
    End Sub

    Private Sub chk_allTajhiz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allTajhiz.CheckedChanged
        txt_TajhizNameForSave.Enabled = Not chk_allTajhiz.Checked
        DGV_Filter.Enabled = Not chk_allTajhiz.Checked
        btn_addTajhiz.Enabled = Not chk_allTajhiz.Checked
        btn_delTajhiz.Enabled = Not chk_allTajhiz.Checked
        btn_SelectTajhiz.Enabled = Not chk_allTajhiz.Checked

    End Sub

    Private Sub btn_AddCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddCancle.Click
        For Each dr As DataGridViewRow In DataGridView2.Rows
            If dr.Cells(0).Value = cmb_CancleCause.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DataGridView2.Rows.Add()
        DataGridView2.Rows(i).Cells(0).Value = cmb_CancleCause.SelectedValue
        DataGridView2.Rows(i).Cells(1).Value = cmb_CancleCause.Text
    End Sub

    Private Sub btn_delTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delTajhiz.Click
        If Not DataGridView1.CurrentRow Is Nothing And DataGridView1.Rows.Count >= 1 Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        End If

    End Sub

    Private Sub btn_DelCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelCancle.Click
        If Not DataGridView2.CurrentRow Is Nothing And DataGridView2.Rows.Count >= 1 Then
            DataGridView2.Rows.RemoveAt(DataGridView2.CurrentRow.Index)
        End If
    End Sub

    Private Sub chk_allCanlce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allCanlce.CheckedChanged
        cmb_CancleCause.Enabled = Not chk_allCanlce.Checked
        DataGridView2.Enabled = Not chk_allCanlce.Checked
        btn_AddCancle.Enabled = Not chk_allCanlce.Checked
        btn_DelCancle.Enabled = Not chk_allCanlce.Checked
    End Sub
End Class