Public Class Frm_RpEibForm

    Private Sub Frm_RpEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_EibTypeTableAdapter.Fill(Me.Ds_Pm.Pm_EibType)
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.PM_Post)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)

        txt_EibFormFromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_EibFormToDate.Value = Setting.TarikheJary
        txt_refFromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_refToDate.Value = Setting.TarikheJary
        For Each chk As System.Windows.Forms.Control In GroupBox2.Controls
            If TypeOf chk Is CheckBox Then
                DirectCast(chk, CheckBox).Checked = True
            End If
        Next
    End Sub

    Private Sub Post_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Add.Click
        For Each dr As DataGridViewRow In DGV_Post.Rows
            If dr.Cells(0).Value = cmb_Post.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DGV_Post.Rows.Add()
        DGV_Post.Rows(i).Cells(0).Value = cmb_Post.SelectedValue
        DGV_Post.Rows(i).Cells(1).Value = cmb_Post.Text
    End Sub

    Private Sub Eib_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eib_Add.Click
        For Each dr As DataGridViewRow In DGV_EibType.Rows
            If dr.Cells(0).Value = cmb_EibType.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DGV_EibType.Rows.Add()
        DGV_EibType.Rows(i).Cells(0).Value = cmb_EibType.SelectedValue
        DGV_EibType.Rows(i).Cells(1).Value = cmb_EibType.Text
    End Sub

    Private Sub Post_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Del.Click

        If Not DGV_Post.CurrentRow Is Nothing And DGV_Post.Rows.Count > 1 Then
            DGV_Post.Rows.RemoveAt(DGV_Post.CurrentRow.Index)
        End If
    End Sub

    Private Sub Eib_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eib_Del.Click
        If Not DGV_EibType.CurrentRow Is Nothing And DGV_EibType.Rows.Count > 1 Then
            DGV_EibType.Rows.RemoveAt(DGV_EibType.CurrentRow.Index)
        End If
    End Sub

    Private Sub chk_AllPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllPost.CheckedChanged
        cmb_Post.Enabled = Not chk_AllPost.Checked
        DGV_Post.Enabled = Not chk_AllPost.Checked
        Post_Del.Enabled = Not chk_AllPost.Checked
        Post_Add.Enabled = Not chk_AllPost.Checked
    End Sub

    Private Sub chk_AllEib_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllEib.CheckedChanged
        cmb_EibType.Enabled = Not chk_AllEib.Checked
        DGV_EibType.Enabled = Not chk_AllEib.Checked
        Eib_Del.Enabled = Not chk_AllEib.Checked
        Eib_Add.Enabled = Not chk_AllEib.Checked
    End Sub

    Private Sub chk_AllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllGroup.CheckedChanged
        cmb_Group.Enabled = Not chk_AllGroup.Checked
    End Sub

    Private Sub chk_AllVahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllVahed.CheckedChanged
        Cmb_Vahed.Enabled = Not chk_AllVahed.Checked
    End Sub

    Private Sub chk_AllEibFormNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllEibFormNo.CheckedChanged
        txt_eibFormNo.Enabled = Not chk_AllEibFormNo.Checked
    End Sub

    Private Sub chk_AllRefDdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllRefDdate.CheckedChanged
        txt_refFromDate.Enabled = Not chk_AllRefDdate.Checked
        txt_refToDate.Enabled = Not chk_AllRefDdate.Checked
    End Sub

    Private Sub chk_AllEibFomDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllEibFomDate.CheckedChanged, CheckBox7.CheckedChanged, CheckBox6.CheckedChanged, CheckBox5.CheckedChanged, CheckBox4.CheckedChanged, CheckBox3.CheckedChanged, CheckBox2.CheckedChanged, CheckBox1.CheckedChanged
        txt_EibFormFromDate.Enabled = Not chk_AllEibFomDate.Checked
        txt_EibFormToDate.Enabled = Not chk_AllEibFomDate.Checked
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim EibFormFromDate As String = ""
        Dim EibFormToDate As String = ""
        Dim EibRefFromDate As String = ""
        Dim EibReftoDate As String = ""
        Dim EibFromNo As String = ""
        Dim EibFormState As Integer = 0
        Dim Vahed As Integer = -1
        Dim Group As Integer = -1
        Dim Post As String = ""
        Dim EibType As String = ""

        If rb_NotFix.Checked Then
            EibFormState = -1
        ElseIf rb_Fix.Checked Then
            EibFormState = 1
        End If
        If chk_AllPost.Checked Then
            Post = "-1"
        Else
            For Each dr As DataGridViewRow In DGV_Post.Rows
                Try
                    Post = Post + dr.Cells(0).Value.ToString() + ","
                Catch
                End Try
            Next
            Post = Post + "-1"
        End If
        If chk_AllEib.Checked Then
            EibType = "-1"
        Else
            For Each dr As DataGridViewRow In DGV_EibType.Rows
                Try
                    EibType = EibType + dr.Cells(0).Value.ToString() + ","
                Catch
                End Try
            Next
            EibType = EibType + "-1"
        End If
        If chk_AllEibFomDate.Checked Then
            EibFormFromDate = "-1"
            EibFormToDate = "-1"
        Else
            EibFormFromDate = txt_EibFormFromDate.Value
            EibFormToDate = txt_EibFormToDate.Value
        End If
        If chk_AllRefDdate.Checked Then
            EibRefFromDate = "-1"
            EibReftoDate = "-1"
        Else
            EibRefFromDate = txt_refFromDate.Value
            EibReftoDate = txt_refToDate.Value
        End If
        If chk_AllVahed.Checked Then
            Vahed = -1
        Else
            Vahed = cmb_Vahed.SelectedValue
        End If
        If chk_AllGroup.Checked Then
            Group = -1
        Else
            Group = cmb_Group.SelectedValue
        End If

        Dim rp As New Rp_EibFom
        Rp_EibFormTableAdapter.Fill(Ds_Rp.Rp_EibForm, Post, Group, Vahed, EibFormFromDate, EibFormToDate, EibRefFromDate, EibReftoDate, EibType, EibFormState)
        Dim dt As DataTable = Ds_Rp.Rp_EibForm
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        rp.SetParameterValue(rp.Parameter_Vahed.ParameterFieldName, IIf(Vahed = -1, "-", cmb_Vahed.Text))
        rp.SetParameterValue(rp.Parameter_Group.ParameterFieldName, IIf(Group = -1, "-", cmb_Group.Text))
        rp.SetParameterValue(rp.Parameter_Post.ParameterFieldName, IIf(Post.Split(",").Length <> 2, "-", DGV_Post.Rows(0).Cells(1).Value))
        rp.SetParameterValue(rp.Parameter_EibType.ParameterFieldName, IIf(EibType.Split(",").Length <> 2, "-", DGV_EibType.Rows(0).Cells(1).Value))
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()

    End Sub

End Class