Imports System.IO.Ports
Imports System.Threading
Public Class Frm_setting

    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_HazineCode' table. You can move, or remove it, as needed.
        Me.Pm_HazineCodeTableAdapter.Fill(Me.Ds_Pm.Pm_HazineCode, 1)
        txt_HolidayZarib.Value = Double.Parse(Setting.HolidayZarib.PropValue)

        'txt_HolidayStatusStatement .Value = Double.Parse(Setting.HolidayStatusStatementZarib.PropValue)
        'txt_CanlceStatusStatement_WorkForm.Value = Double.Parse(Setting.CancleStatusStatementZarib_WorkForm.PropValue)
        'txt_CanleStatusStatement.Value = Double.Parse(Setting.CancleStatusStatementZarib.PropValue)
        'txt_NightWorkStatusStatement.Value = Double.Parse(Setting.NightWorkStatusStatementZarib.PropValue)
        txt_ZaribAlal.Value = Double.Parse(Setting.DarsadEzafeKarAlalhesab.PropValue)
        txt_ZaribeMasafat.Value = Double.Parse(Setting.EzafeKarTaradodBound.PropValue)
        txt_MaxTaradodBound.Value = Double.Parse(Setting.MaxTaradodBound.PropValue)
        txt_MojazDate.Value = Double.Parse(Setting.Mojaz_Date.PropValue)
        txt_MojazDateEdit.Value = Double.Parse(Setting.Mojaz_Date_Edit.PropValue)
        txt_ModirMessage.Value = Setting.ModirMesage.PropValue
        cmb_HazineCode.SelectedValue = Setting.Default_Code_Hazine.PropValue
        pg_MainLogo.Image = Setting.MainLogo.PropImage
        'pg_ReportLogo.Image = Setting.ReportLogo.PropImage
        ts_SAghfeEzafekarHolyDAy.Value = Setting.MazadEzafekar_HolyDay.PropValue.ToString() + ":00"
        ts_SAghfeEzafekarNormal.Value = Setting.MazadEzafekar_Normal.PropValue.ToString() + ":00"
        txt_SmsTemplate.Value = Setting.Sms_Template.PropValue.ToString()
        ''New Add For Edit Time Card
        txt_StartReport.Value = Setting.ReportStartDate.PropValue.ToString()
        txt_EndReport.Value = Setting.ReportEndDate.PropValue.ToString()
        txt_PeronelStart.Value = Setting.UserEditStartDate.PropValue.ToString()
        txt_PersonelEnd.Value = Setting.UserEditEndDate.PropValue.ToString()
        txt_AdminStart.Value = Setting.AdminEditStartDate.PropValue.ToString()
        txt_AdminEnd.Value = Setting.AdminEditEndDate.PropValue.ToString()

        Try
            chk_UseTemplate.Checked = Setting.Use_Sms_Template.PropValue.ToString()
        Catch ex As Exception
            chk_UseTemplate.Checked = False

        End Try
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        'Setting.CancleStatusStatementZarib.UpdateSetting(txt_CanleStatusStatement.Text)
        'Setting.CancleStatusStatementZarib_WorkForm.UpdateSetting(txt_CanlceStatusStatement_WorkForm.Text)
        'Setting.HolidayStatusStatementZarib.UpdateSetting(txt_HolidayStatusStatement.Text)
        'Setting.NightWorkStatusStatementZarib.UpdateSetting(txt_NightWorkStatusStatement.Text)
        Setting.DarsadEzafeKarAlalhesab.UpdateSetting(txt_ZaribAlal.Value)

        Setting.HolidayZarib.UpdateSetting(txt_HolidayZarib.Value)
        Setting.EzafeKarTaradodBound.UpdateSetting(txt_ZaribeMasafat.Value)
        Setting.Mojaz_Date.UpdateSetting(txt_MojazDate.Value)
        Setting.Mojaz_Date_Edit.UpdateSetting(txt_MojazDateEdit.Value)
        Setting.MaxTaradodBound.UpdateSetting(txt_MaxTaradodBound.Value)
        Setting.ModirMesage.UpdateSetting(txt_ModirMessage.Value)
        Setting.MainLogo.UpdateSetting(pg_MainLogo.Image)
        'Setting.ReportLogo.UpdateSetting(pg_ReportLogo.Image)
        Setting.MazadEzafekar_HolyDay.UpdateSetting(PublicFunction.GetSaat(ts_SAghfeEzafekarHolyDAy.time))
        Setting.MazadEzafekar_Normal.UpdateSetting(PublicFunction.GetSaat(ts_SAghfeEzafekarNormal.time))
        Setting.Sms_Template.UpdateSetting(txt_SmsTemplate.Value)
        Setting.Use_Sms_Template.UpdateSetting(chk_UseTemplate.Checked)
        Setting.Default_Code_Hazine.UpdateSetting(cmb_HazineCode.SelectedValue)
        ''New Add For Edit Time Card
        Setting.ReportStartDate.UpdateSetting(txt_StartReport.Value)
        Setting.ReportEndDate.UpdateSetting(txt_EndReport.Value)
        Setting.UserEditStartDate.UpdateSetting(txt_PeronelStart.Value)
        Setting.UserEditEndDate.UpdateSetting(txt_PersonelEnd.Value)
        Setting.AdminEditStartDate.UpdateSetting(txt_AdminStart.Value)
        Setting.AdminEditEndDate.UpdateSetting(txt_AdminEnd.Value)

        SplashScreen1.Load_Setting()
        Application.DoEvents()
        Close()
    End Sub

    Private Sub Tab_Control_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles Tab_Control.Selected
        PublicFunction.CheckGSMModem()
        If Setting.Signal > 0 Then
            lb_Info.Text = "اتصال با مودم از طریق پورت " + Setting.PortName + " برقرار است"
            Dim sp As New SerialPort(Setting.PortName, 115200)
            sp.DtrEnable = True
            sp.RtsEnable = True
            sp.Open()
            sp.Write("at+cusd=1,""*141*1#""" & Convert.ToString(sp.NewLine))
            Dim temp As String = ""
            For i As Integer = 0 To 50
                Thread.Sleep(100)
                temp += sp.ReadExisting()
                If temp.IndexOf("Rial") >= 0 Then
                    Exit For
                End If
            Next
            If temp.IndexOf("Rial") >= 0 Then
                lb_Sharj.Text = "میزان شارژ فعلی شما : " + temp.Substring(temp.IndexOf("felie:") + 6, temp.IndexOf("Rial") - temp.IndexOf("felie:") - 6) + " ریال می باشد"
            Else
                lb_Sharj.Text = "خطا در ارسال دستور"
            End If
        Else
            lb_Sharj.Text = "مودم فعال نیست"
            lb_Info.Text = "مودم فعال نیست"
        End If
    End Sub

    Private Sub chk_UseTemplate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_UseTemplate.CheckedChanged

    End Sub

End Class