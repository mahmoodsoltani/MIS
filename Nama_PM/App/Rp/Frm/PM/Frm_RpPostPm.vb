Public Class Frm_RpPostPm
    Dim Srl_Pm_Tajhiz_ForSave As Integer = -1
    Private Sub Frm_RpExtraWork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Hadese.test' table. You can move, or remove it, as needed.
        Me.TestTableAdapter.Fill(Me.Ds_Hadese.test)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter1.Fill(Me.Ds_Pm1.Pm_Post)

        chk_AllFilter.Checked = True
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary

        Me.rb_all.Checked = True
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim filter As String = ""


        If (Not chk_AllFilter.Checked And rb_Post.Checked) Or (rb_Tajhiz.Checked And Not chk_allTajhiz.Checked) Then
            For Each dr As DataGridViewRow In DGV_Filter.Rows
                Try
                    filter = filter + dr.Cells(0).Value.ToString() + ","
                Catch
                End Try
            Next
            filter = filter + "-1"
        Else
            filter = ""
        End If

        Dim frm_rp As Frm_RpPostPMGraph
        Dim rp_type As Integer = -1
        If rb_Post.Checked Then
            rp_type = 0
        Else
            rp_type = 1
        End If

        If rb_Do.Checked Then
            frm_rp = New Frm_RpPostPMGraph(txt_FromDate.Value, txt_ToDate.Value, filter, 1, filter, rp_type)
        ElseIf rb_Cancle.Checked Then
            frm_rp = New Frm_RpPostPMGraph(txt_FromDate.Value, txt_ToDate.Value, filter, 2, filter, rp_type)
        ElseIf rb_donDo.Checked Then
            frm_rp = New Frm_RpPostPMGraph(txt_FromDate.Value, txt_ToDate.Value, filter, 3, filter, rp_type)
        Else
            frm_rp = New Frm_RpPostPMGraph(txt_FromDate.Value, txt_ToDate.Value, filter, 4, filter, rp_type)
        End If
        frm_rp.ShowDialog()

    End Sub



    Private Sub Post_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Add.Click
        For Each dr As DataGridViewRow In DGV_Filter.Rows
            If dr.Cells(0).Value = cmb_Filter.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DGV_Filter.Rows.Add()
        DGV_Filter.Rows(i).Cells(0).Value = cmb_Filter.SelectedValue
        DGV_Filter.Rows(i).Cells(1).Value = cmb_Filter.Text
    End Sub

    Private Sub Post_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Del.Click, btn_del.Click
        If Not DGV_Filter.CurrentRow Is Nothing And DGV_Filter.Rows.Count >= 1 Then
            DGV_Filter.Rows.RemoveAt(DGV_Filter.CurrentRow.Index)
        End If
    End Sub

    Private Sub chk_AllFilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllFilter.CheckedChanged
        cmb_Filter.Enabled = Not chk_AllFilter.Checked
        DGV_Filter.Enabled = Not chk_AllFilter.Checked
        Post_Del.Enabled = Not chk_AllFilter.Checked
        Post_Add.Enabled = Not chk_AllFilter.Checked
    End Sub

    Private Sub rb_Post_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Post.CheckedChanged
        pl_Post.Visible = rb_Post.Checked
        pl_Tajhiz.Visible = Not rb_Post.Checked
        DGV_Filter.Rows.Clear()
        If rb_Post.Checked Then
            Me.NameCol.HeaderText = "نام پست"
        Else
            Me.NameCol.HeaderText = "نام تجهیز"
        End If
    End Sub

    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        Dim s As New Frm_DeviceSelectWithPost()
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_TajhizNameForSave.Value = s.SelectedDevice.Text
            Srl_Pm_Tajhiz_ForSave = s.SelectedDevice.Srl
            btn_add.Focus()
        End If
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If Srl_Pm_Tajhiz_ForSave <> -1 Then
            For Each dr As DataGridViewRow In DGV_Filter.Rows
                If dr.Cells(0).Value = Srl_Pm_Tajhiz_ForSave Then
                    Return
                End If
            Next
            Dim i As Integer = DGV_Filter.Rows.Add()
            DGV_Filter.Rows(i).Cells(0).Value = Srl_Pm_Tajhiz_ForSave
            DGV_Filter.Rows(i).Cells(1).Value = txt_TajhizNameForSave.Value
        End If
    End Sub

    Private Sub chk_allTajhiz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allTajhiz.CheckedChanged
        txt_TajhizNameForSave.Enabled = Not chk_allTajhiz.Checked
        DGV_Filter.Enabled = Not chk_allTajhiz.Checked
        btn_add.Enabled = Not chk_allTajhiz.Checked
        btn_del.Enabled = Not chk_allTajhiz.Checked
        btn_SelectTajhiz.Enabled = Not chk_allTajhiz.Checked

    End Sub
End Class