Public Class Frm_Rp_Lab_Tamir

    Private Sub Frm_Rp_Lab_Tamir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        Me.Pm_Lab_Rol_ElateVorodTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_ElateVorod)
        Me.Pm_Lab_Rol_SatheAhamniatTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_SatheAhamniat)
        Me.Pm_Lab_Rol_GhatatMasrafiTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_GhatatMasrafi)
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        Dim TarikhTamirFrom As String = "-1"
        Dim TarikhTamirTo As String = "-1"
        If Not chk_TarikhTamir.Checked Then
            TarikhTamirFrom = txt_TarikhTamirFrom.Value
            TarikhTamirTo = txt_TarikhTamirTo.Value
        End If

        Dim TarikhTahvilFrom As String = "-1"
        Dim TarikhTahvilTo As String = "-1"
        If Not chk_TarikhTahvil.Checked Then
            TarikhTahvilFrom = txt_TarikhTahvilfrom.Value
            TarikhTahvilTo = txt_TarikhTahvilTo.Value
        End If

        Dim TarikhVorodFrom As String = "-1"
        Dim TarikhVorodTo As String = "-1"
        If Not chk_TarikhVorod.Checked Then
            TarikhVorodFrom = txt_TarikhVorodFrom.Value
            TarikhVorodTo = txt_TarikhVorodTo.Value
        End If

        Dim TarikhSabtFrom As String = "-1"
        Dim TarikhSabtTo As String = "-1"
        If Not chk_TarikhSabt.Checked Then
            TarikhSabtFrom = txt_TarikhSabtFrom.Value
            TarikhSabtTo = txt_TarikhSabtTo.Value
        End If

        Dim NafarSat As String = "-1"
        If Not chk_NafarSat.Checked Then
            NafarSat = txt_NafarSat.Value
        End If

        Dim Dis As String = "-1"
        If Not chk_Dis.Checked Then
            Dis = txt_Dis.Value
        End If

        Dim No As String = "-1"
        If Not chk_No.Checked Then
            No = txt_No.Value
        End If

        Dim Device As Integer = -1
        If Not chk_Device.Checked Then
            Device = cmb_Device.SelectedValue
        End If

        Dim SatheaAhamiat As Integer = -1
        If Not chk_SatheaAhamiat.Checked Then
            SatheaAhamiat = cmb_SatheaAhamiat.SelectedValue
        End If

        Dim Elat As Integer = -1
        If Not chk_Elat.Checked Then
            Elat = cmb_Elat.SelectedValue
        End If

        Dim TahvilePerson As Integer = -1
        If Not chk_TahvilePerson.Checked Then
            TahvilePerson = cmb_TahvilePerson.SelectedValue
        End If

        Dim PmPost As Integer = -1
        If Not chk_PmPost.Checked Then
            PmPost = cmb_PmPost.SelectedValue
        End If

        Dim Tavasot As Integer = -1
        If Not chk_Tavasot.Checked Then
            Tavasot = cmb_Tavasot.SelectedValue
        End If

        Dim DeviceKhesaratName As Integer = -1
        If Not chk_DeviceKhesaratName.Checked Then
            DeviceKhesaratName = txt_Srl_DeviceKhesarat.Value
        End If

        Me.Pm_Lab_Rol_TamiratViewTableAdapter.FillBySearchOption(Me.Ds_Lab.Pm_Lab_Rol_TamiratView, PmPost, _
                                                                 DeviceKhesaratName, SatheaAhamiat, Tavasot, Elat, _
                                                                 No, NafarSat, TarikhVorodFrom, TarikhVorodTo, _
                                                                 TarikhTamirFrom, TarikhTamirTo, _
                                                                 TarikhTahvilFrom, TarikhTahvilTo, TarikhSabtTo, _
                                                                 TarikhSabtTo, Device,TahvilePerson, Dis)
        lbl_Record.Text = "تعداد رکورد :"
        lbl_Record.Text += Ds_Lab.Pm_Lab_Rol_TamiratView.Rows.Count.ToString
    End Sub

    Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_print.Click
        Dim rp As New Rp_Lab_Rol_Search

        rp.SetDataSource(Ds_Lab.Pm_Lab_Rol_TamiratView.DataSet)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Lab.Pm_Lab_Rol_TamiratView.DataSet.Tables("0"))
        frm_rp.ShowDialog()
    End Sub

    Function GetDevice() As DataTable
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_PmPost.SelectedValue)
        Return Ds_Hadese.Pm_Hadese_KhesaratDevice
    End Function

    Private Sub btn_SelectDEvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectDEvice.Click
        Try
            Dim Tv As New Tree_Vw_Select(GetDevice)
            If Tv.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                Return
            End If
            If Not Tv.Result Is Nothing Then
                txt_DeviceKhesaratName.Value = Tv.Result.Text
                txt_Srl_DeviceKhesarat.Text = Tv.Result.Srl
                cmb_SatheaAhamiat.Focus()
            End If
        Catch ex As Exception
            MessageBoxFa.Show("در پست انتخاب شده دستگاهي ثبت نشده")
        End Try
    End Sub

    Private Sub chk_DeviceKhesaratName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DeviceKhesaratName.CheckedChanged
        chk_PmPost.Checked = chk_DeviceKhesaratName.Checked
        btn_SelectDEvice.Enabled = Not chk_DeviceKhesaratName.Checked
    End Sub

    Private Sub chk_Device_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Device.CheckedChanged
        cmb_Device.Enabled = Not chk_Device.Checked
    End Sub

    Private Sub chk_SatheaAhamiat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SatheaAhamiat.CheckedChanged
        cmb_SatheaAhamiat.Enabled = Not chk_SatheaAhamiat.Checked
    End Sub

    Private Sub chk_Elat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Elat.CheckedChanged
        cmb_Elat.Enabled = Not chk_Elat.Checked
    End Sub

    Private Sub chk_TahvilePerson_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TahvilePerson.CheckedChanged
        cmb_TahvilePerson.Enabled = Not chk_TahvilePerson.Checked
    End Sub

    Private Sub chk_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_No.CheckedChanged
        txt_No.Enabled = Not chk_No.Checked
    End Sub

    Private Sub chk_PmPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PmPost.CheckedChanged
        cmb_PmPost.Enabled = Not chk_PmPost.Checked
    End Sub

    Private Sub chk_Tavasot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Tavasot.CheckedChanged
        cmb_Tavasot.Enabled = Not chk_Tavasot.Checked
    End Sub

    Private Sub chk_NafarSat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_NafarSat.CheckedChanged
        txt_NafarSat.Enabled = Not chk_NafarSat.Checked
    End Sub

    Private Sub chk_Dis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Dis.CheckedChanged
        txt_Dis.Enabled = Not chk_Dis.Checked
    End Sub

    Private Sub chk_TarikhTamir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TarikhTamir.CheckedChanged
        txt_TarikhTamirFrom.Enabled = Not chk_TarikhTamir.Checked
        txt_TarikhTamirTo.Enabled = Not chk_TarikhTamir.Checked
    End Sub

    Private Sub chk_TarikhTahvil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TarikhTahvil.CheckedChanged
        txt_TarikhTahvilfrom.Enabled = Not chk_TarikhTahvil.Checked
        txt_TarikhTahvilTo.Enabled = Not chk_TarikhTahvil.Checked
    End Sub

    Private Sub chk_TarikhVorod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TarikhVorod.CheckedChanged
        txt_TarikhVorodFrom.Enabled = Not chk_TarikhVorod.Checked
        txt_TarikhVorodTo.Enabled = Not chk_TarikhVorod.Checked
    End Sub

    Private Sub chk_TarikhSabt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TarikhSabt.CheckedChanged
        txt_TarikhSabtFrom.Enabled = Not chk_TarikhSabt.Checked
        txt_TarikhSabtTo.Enabled = Not chk_TarikhSabt.Checked
    End Sub

    Private Sub cmb_PmPost_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PmPost.SelectedIndexChanged
        txt_Srl_DeviceKhesarat.Value = ""
        txt_DeviceKhesaratName.Value = ""
    End Sub
End Class