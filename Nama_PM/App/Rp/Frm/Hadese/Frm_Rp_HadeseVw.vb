Public Class Frm_Rp_HadeseVw

    Private Sub Frm_RpHadeseVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
        Me.Pm_Hadese_ElatTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_Elat)
        Me.Pm_Hadese_AmalkardSystemTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_AmalkardSystem)
        Me.Pm_Hadese_SharayetBorozTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_SharayetBoroz)
        Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, -1)
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If

        Dim reportNo As String = -1
        If Not chk_ReportNo.Checked Then
            reportNo = txt_ReportNo.Value
        End If

        Dim elat As Integer = -1
        If Not Chk_Elat.Checked Then
            elat = cmb_Elat.SelectedValue
        End If

        Dim Mahal As Integer = -1
        If Not chk_Mahal.Checked Then
            Mahal = cmb_Mahal.SelectedValue
        End If

        Dim Line As Integer = -1
        If Not chk_Line.Checked Then
            Line = cmb_Line.SelectedValue
        End If

        Dim SharhHadese As String = -1
        If Not chk_SHarhHadese.Checked Then
            SharhHadese = "%" + txt_SHarhHadese.Value + "%"
        End If

        Dim EghdamateAvalie As String = -1
        If Not chk_EghdamatAvalie.Checked Then
            EghdamateAvalie = "%" + txt_EghdamatAvalie.Value + "%"
        End If

        Dim Natije As String = -1
        If Not chk_NatijeBarasi.Checked Then
            Natije = "%" + txt_NatijeBarasi.Value + "%"
        End If

        Dim kelidi As String = -1
        If Not chk_KalamatKelidi.Checked Then
            kelidi = "%" + txt_KalamatKelidi.Value + "%"
        End If

        Dim elatgostaresh As String = -1
        If Not chk_ElatGostaresh.Checked Then
            elatgostaresh = "%" + txt_ElatGostaresh.Value + "%"
        End If

        Dim dastormodir As String = -1
        If Not chk_DastorModir.Checked Then
            dastormodir = "%" + txt_DastorModir.Value + "%"
        End If

        Dim Sharayeteboroz As Integer = -1
        If Not chk_SharayeteBoroz.Checked Then
            Sharayeteboroz = cmb_SharayeteBoroz.SelectedValue
        End If

        Dim group As Integer = -1
        If Not chk_Group.Checked Then
            group = cmb_Group.SelectedValue
        End If

        Dim amalkard As Integer = -1
        If Not chk_AmalKArdSystemHefazati.Checked Then
            amalkard = cmb_AmalKArdSystemHefazati.SelectedValue
        End If
        Me.Pm_HadeseTableAdapter.FillBySearchOption(Me.Ds_Hadese.Pm_Hadese, reportNo, FromDate, ToDate, elat _
                                                    , Sharayeteboroz, Mahal, Line, kelidi _
                                                    , SharhHadese, EghdamateAvalie, elatgostaresh, amalkard _
                                                    , group, Natije, dastormodir)
        lbl_Record.Text = "تعداد رکورد :"
        lbl_Record.Text += Me.Ds_Hadese.Pm_Hadese.Rows.Count.ToString
    End Sub

    Private Sub chk_ReportNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ReportNo.CheckedChanged
        txt_ReportNo.Enabled = Not chk_ReportNo.Checked
    End Sub

    Private Sub Chk_Elat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Elat.CheckedChanged
        cmb_Elat.Enabled = Not Chk_Elat.Checked
    End Sub

    Private Sub chk_allday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allday.CheckedChanged
        txt_FromDate.Enabled = Not chk_allday.Checked
        txt_ToDate.Enabled = Not chk_allday.Checked
    End Sub

    Private Sub chk_Mahal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Mahal.CheckedChanged
        cmb_Mahal.Enabled = Not chk_Mahal.Checked
        If Not chk_Mahal.Checked And Not chk_Line.Checked Then
            MessageBoxFa.Show("پست و خط راهمزمان نمیتوان انتخاب کرد")
            If Not chk_Mahal.Checked Then
                chk_Mahal.Checked = True
            End If
            Return
        End If
    End Sub

    Private Sub chk_Line_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Line.CheckedChanged
        cmb_Line.Enabled = Not chk_Line.Checked
        If Not chk_Mahal.Checked And Not chk_Line.Checked Then
            MessageBoxFa.Show("پست و خط راهمزمان نمیتوان انتخاب کرد")
            If Not chk_Line.Checked Then
                chk_Line.Checked = True
            End If
            Return
        End If
    End Sub


    Private Sub chk_SHarhHadese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SHarhHadese.CheckedChanged
        txt_SHarhHadese.Enabled = Not chk_SHarhHadese.Checked
    End Sub

    Private Sub chk_EghdamatAvalie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_EghdamatAvalie.CheckedChanged
        txt_EghdamatAvalie.Enabled = Not chk_EghdamatAvalie.Checked
    End Sub

    Private Sub chk_NatijeBarasi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_NatijeBarasi.CheckedChanged
        txt_NatijeBarasi.Enabled = Not chk_NatijeBarasi.Checked
    End Sub

    Private Sub chk_KalamatKelidi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_KalamatKelidi.CheckedChanged
        txt_KalamatKelidi.Enabled = Not chk_KalamatKelidi.Checked
    End Sub

    Private Sub chk_ElatGostaresh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ElatGostaresh.CheckedChanged
        txt_ElatGostaresh.Enabled = Not chk_ElatGostaresh.Checked
    End Sub

    Private Sub chk_DastorModir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DastorModir.CheckedChanged
        txt_DastorModir.Enabled = Not chk_DastorModir.Checked
    End Sub

    Private Sub chk_SharayeteBoroz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SharayeteBoroz.CheckedChanged
        cmb_SharayeteBoroz.Enabled = Not chk_SharayeteBoroz.Checked
    End Sub

    Private Sub chk_Group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Group.CheckedChanged
        cmb_Group.Enabled = Not chk_Group.Checked
    End Sub

    Private Sub chk_AmalKArdSystemHefazati_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AmalKArdSystemHefazati.CheckedChanged
        cmb_AmalKArdSystemHefazati.Enabled = Not chk_AmalKArdSystemHefazati.Checked
    End Sub

    Private Sub Btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim s As New Frm_Hadese(srl)
        s.ShowDialog()
        Me.Pm_HadeseTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese)
    End Sub

    Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_print.Click
        Dim rp As New Rp_Hadese
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Try
            Rp_HadeseTableAdapter.Fill(Ds_Hadese.Rp_Hadese, srl)
        Catch ex As Exception
        End Try
        Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable( _
        Rp_HadeseTableAdapter.Adapter.SelectCommand.CommandText.Replace("@Srl", srl.ToString))
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()
    End Sub

    Private Sub Btn_PrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PrintAll.Click
        Dim rp As New Rp_Hadese_PrintAll

        Dim dt As DataTable = Ds_Hadese.Pm_Hadese
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()
    End Sub

   
End Class