Public Class Frm_RpDevice

    Private Sub Frm_RpEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each chk As Control In Me.gbx_Fields.Controls
            If (TypeOf chk Is CheckBox) Then
                DirectCast(chk, CheckBox).Checked = True
            End If
        Next
        For Each chk As Control In Me.Tab_Tajhiz.SelectedTab.Controls
            If (TypeOf chk Is CheckBox) Then
                DirectCast(chk, CheckBox).Checked = True
            End If
        Next
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_Device_SazandeTableAdapter.Fill(Me.Ds_Lab.Pm_Device_Sazande)
        Me.Pm_TajhizNameTableAdapter.Fill(Me.Ds_Pm.Pm_TajhizName)
    End Sub
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim srl_post As Integer = IIf(chk_AllPost.Checked, -1, cmb_Post.SelectedValue)
        Dim model As String = IIf(chk_AllModel.Checked, "", txt_Model.Value)
        Dim Dispatching As String = IIf(chk_AllDispatch.Checked, "", txt_DispatchCode.Value)
        Dim startMade As String = IIf(chk_AllMadeDate.Checked, "", txt_StartMade.Value)
        Dim endmade As String = IIf(chk_AllMadeDate.Checked, "", txt_EndMade.Value)
        Dim startUti As String = IIf(chk_AllUtilizationDate.Checked, "", txt_StartUti.Value)
        Dim endUti As String = IIf(chk_AllUtilizationDate.Checked, "", txt_EndUti.Value)
        Dim serial As String = IIf(chk_AllSerial.Checked, "", txt_Serial.Value)
        Dim Srl_Sazande As Integer = IIf(chk_allSazande.Checked, -1, cmb_Sazande.SelectedValue)

        If Tab_Tajhiz.SelectedIndex = 1 Then
            Dim CT As String = IIf(chk_AllRCT.Checked, "", txt_ReleCT.Value)
            Dim VT As String = IIf(chk_AllRVT.Checked, "", txt_ReleVT.Value)
            Dim RName As String = IIf(Chk_AllRNme.Checked, "", txt_ReleName.Value)
            Dim Order As String = IIf(chk_AllROrder.Checked, "", txt_ReleOrderCode.Value)
            Dim rp As New Rp_Rele
            Rp_ReleTableAdapter.Fill(Ds_Rp.Rp_Rele, RName, Order, CT, VT, srl_post, Srl_Sazande, model, startMade, endmade, startUti, endUti, Dispatching, serial)
            Dim dt As DataTable = Ds_Rp.Rp_Rele
            rp.SetDataSource(dt)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()
        ElseIf Tab_Tajhiz.SelectedIndex = 0 Then
            Dim OrderCode As String = IIf(chk_allOrderCode.Checked, "", txt_OrderCode.Value)
            Dim TName As Integer = IIf(chk_AllName.Checked, -1, cmb_TajhizName.SelectedValue)
            Dim SubDevice As Integer = IIf(chk_SubDevice.Checked, 1, -1)

            Dim rp As New Rp_Tajhiz
            Rp_TajhizTableAdapter.Fill(Ds_Rp.Rp_Tajhiz, TName, OrderCode, "", srl_post, Srl_Sazande, model, startMade, endmade, startUti, endUti, Dispatching, serial, SubDevice)
            Dim dt As DataTable = Ds_Rp.Rp_Tajhiz
            rp.SetDataSource(dt)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()
        ElseIf Tab_Tajhiz.SelectedIndex = 2 Then
            Dim TgName As String = IIf(chk_AllTgName.Checked, "", txt_TGName.Value)
            Dim Vector As String = IIf(chk_AllTGVectorGroup.Checked, "", txt_TGVectore.Value)
            Dim VoltajConvert As String = IIf(chk_AllTGVotajConvert.Checked, "", txt_TGVotaj.Value)
            Dim JaryanConvert As String = IIf(chk_AllTGJaryanConvert.Checked, "", txt_TGJaryan.Value)
            Dim Ampendase As String = IIf(chk_AllTGAmpedanse.Checked, "", txt_TGampedance.Value)
            Dim Freaunce As String = IIf(chk_AllTGFerequenc.Checked, "", txt_TGFrequncy.Value)
            Dim Colling As String = IIf(chk_AllTGCooler.Checked, "", txt_TGColling.Value)
            Dim Volume As String = IIf(chk_AllTGValume.Checked, "", txt_TGVolume.Value)
            Dim Bill As String = IIf(chk_AllTGBill.Checked, "", txt_TGBill.Value)
            Dim TapChange As String = IIf(chk_AllTGTapChange.Checked, "", txt_TGtapConvert.Value)
            Dim TapPlace As String = IIf(chk_AllTGTapPlace.Checked, "", txt_TGTapPlace.Value)
            Dim rp As New Rp_TranseGhodrat
            Rp_TranseGhodratTableAdapter.Fill(Ds_Rp.Rp_TranseGhodrat, Colling, Volume, Vector, VoltajConvert, TapChange, TapPlace, JaryanConvert, Bill, Ampendase, Freaunce, TgName, srl_post, Srl_Sazande, model, startMade, endmade, startUti, endUti, Dispatching, serial)
            Dim dt As DataTable = Ds_Rp.Rp_TranseGhodrat
            rp.SetDataSource(dt)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()
        ElseIf Tab_Tajhiz.SelectedIndex = 3 Then
            Dim tavan As String = IIf(chk_AllBGTavan.Checked, "", txt_BGTavan.Value)
            Dim Jaryan As String = IIf(chk_AllBGJaryan.Checked, "", txt_BGJaryan.Value)
            Dim BGName As String = IIf(chk_AllBGName.Checked, "", txt_BGName.Value)
            Dim Voltaj As String = IIf(chk_AllBGVoltaj.Checked, "", txt_BGVoltaj.Value)
            Dim JSC As String = IIf(chk_AllBGSC.Checked, "", txt_BGJaryanSC.Value)
            Dim BGClass As String = IIf(chk_AllBGClass.Checked, "", txt_BGClass.Value)

            Dim rp As New Rp_Barghgir
            Rp_BarghgirTableAdapter.Fill(Ds_Rp.Rp_Barghgir, tavan, Jaryan, Voltaj, JSC, BGClass, BGName, srl_post, Srl_Sazande, model, startMade, endmade, startUti, endUti, Dispatching, serial)
            Dim dt As DataTable = Ds_Rp.Rp_Barghgir
            rp.SetDataSource(dt)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()
        ElseIf Tab_Tajhiz.SelectedIndex = 4 Then
            Dim Voltaj As String = IIf(chk_AllSexVoltaj.Checked, "", txt_SexVoltage.Value)
            Dim Jaryan As String = IIf(chk_AllSexJaryan.Checked, "", txt_SexJaryan.Value)
            Dim SEXName As String = IIf(chk_AllSexName.Checked, "", txt_SexName.Value)
            Dim maxJaryan As String = IIf(chk_AllSexMaxJaryan.Checked, "", txt_SexMaxJaryan.Value)
            Dim SEXSC As String = IIf(chk_AllSexSC.Checked, "", txt_SexJaryanSC.Value)
            Dim UtiVoltaje As String = IIf(chk_AllsexUtiVoltaj.Checked, "", txt_sexUtilizationVoltaje.Value)

            Dim rp As New Rp_Sexioner
            Rp_SexionerTableAdapter.Fill(Ds_Rp.Rp_Sexioner, Jaryan, Voltaj, SEXSC, maxJaryan, UtiVoltaje, SEXName, srl_post, Srl_Sazande, model, startMade, endmade, startUti, endUti, Dispatching, serial)
            Dim dt As DataTable = Ds_Rp.Rp_Sexioner
            rp.SetDataSource(dt)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()
        ElseIf Tab_Tajhiz.SelectedIndex = 5 Then
            Dim VoltajN As String = IIf(chk_AllBRVoltajN.Checked, "", txt_BRVotajN.Value)
            Dim JaryanN As String = IIf(chk_AllBRJaryanN.Checked, "", txt_BRJaryanN.Value)
            Dim BrName As String = IIf(chk_ALLBRName.Checked, "", txt_BrName.Value)
            Dim maxJaryan As String = IIf(chk_AllBRMaxJaryan.Checked, "", txt_BRMaxJaryan.Value)
            Dim maxVoltaj As String = IIf(chk_AllBRMaxVoltaj.Checked, "", txt_BRMaxVoltaje.Value)
            Dim BrSC As String = IIf(chk_AllBRSC.Checked, "", txt_BRJaryanSC.Value)
            Dim Connect As String = IIf(chk_AllBRConnect.Checked, "", txt_BrConnect.Value)
            Dim DisConnect As String = IIf(chk_AllBRDisconnect.Checked, "", txt_BRDisconnect.Value)
            Dim Bill As String = IIf(chk_AllBRBill.Checked, "", txt_BrBill.Value)
            Dim Mekanizm As String = IIf(chk_AllBRMekanizm.Checked, "", txt_BRMekanism.Value)
            Dim TurnOff As String = IIf(chk_AllBRTurnoff.Checked, "", txt_BRTurnOff.Value)

            Dim rp As New Rp_Breaker
            Rp_BreakerTableAdapter.Fill(Ds_Rp.Rp_Breaker, JaryanN, VoltajN, BrSC, maxJaryan, maxVoltaj, Connect, DisConnect, Bill, Mekanizm, TurnOff, BrName, srl_post, Srl_Sazande, model, startMade, endmade, startUti, endUti, Dispatching, serial)
            Dim dt As DataTable = Ds_Rp.Rp_Breaker
            rp.SetDataSource(dt)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()

        ElseIf Tab_Tajhiz.SelectedIndex = 6 Then
            Dim TranseType As Integer
            If RB_TJ.Checked Then
                TranseType = 7
            ElseIf Rb_TV.Checked Then
                TranseType = 6
            ElseIf Rb_Both.Checked Then
                TranseType = 0
            End If
            Dim TrName As String = IIf(chk_AllTrName.Checked, "", txt_TrName.Value)

            Dim CoreNumber As String = IIf(chk_ALLTrCoreNumber.Checked, "", txt_TrCoreNumber.Value)
            Dim CoreConvert As String = IIf(chk_AllTVJCoreConvert.Checked, "", txt_TVJCoreConvert.Value)
            Dim CoreClass As String = IIf(chk_AllTVJClass.Checked, "", txt_TVJCoreClass.Value)
            Dim maxVoltaj As String = IIf(chk_AllTVJMaxVoltaj.Checked, "", txt_TVJMaxVoltage.Value)
            Dim maxJaryan As String = IIf(chk_AllTVJMaxJaryan.Checked, "", txt_TVJMaxJaryan.Value)
            Dim Bill As String = IIf(chk_AllTVJBill.Checked, "", txt_TVJbill.Value)
            

            Dim rp As New Rp_Transe
            Rp_TeranseTableAdapter.Fill(Ds_Rp.Rp_Teranse, TranseType, maxJaryan, maxVoltaj, CoreNumber, CoreConvert, Bill, CoreClass, TrName, srl_post, Srl_Sazande, model, startMade, endmade, startUti, endUti, Dispatching, serial)
            Dim dt As DataTable = Ds_Rp.Rp_Teranse
            rp.SetDataSource(dt)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()
        ElseIf Tab_Tajhiz.SelectedIndex = 7 Then

            Dim CableName As String = IIf(chk_AllCAbleNAme.Checked, "", txt_CableName.Value)

            Dim CableMaghta As String = IIf(chk_AllCMaghta.Checked, "", txt_CMaghta.Value)
            Dim Voltaj As String = IIf(chk_AllCSatheVoltaj.Checked, "", txt_CVoltaj.Value)
            Dim ValidJaryan As String = IIf(chk_AllCJaryan.Checked, "", txt_CValidJaryan.Value)
            
            Dim rp As New Rp_Cable
            Rp_CableTableAdapter.Fill(Ds_Rp.Rp_Cable, ValidJaryan, Voltaj, CableMaghta, CableName, srl_post, Srl_Sazande, model, startMade, endmade, startUti, endUti, Dispatching, serial)
            Dim dt As DataTable = Ds_Rp.Rp_Cable
            rp.SetDataSource(dt)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()
        End If


    End Sub

    Private Sub EnableTajhiz()
        cmb_Post.Enabled = Not chk_AllPost.Checked
        cmb_TajhizName.Enabled = Not chk_AllName.Checked
        txt_EndMade.Enabled = Not chk_AllMadeDate.Checked
        txt_StartMade.Enabled = Not chk_AllMadeDate.Checked
        txt_EndUti.Enabled = Not chk_AllUtilizationDate.Checked
        txt_StartUti.Enabled = Not chk_AllUtilizationDate.Checked
        txt_DispatchCode.Enabled = Not chk_AllDispatch.Checked
        txt_Serial.Enabled = Not chk_AllSerial.Checked
        txt_OrderCode.Enabled = Not chk_allOrderCode.Checked
        txt_Model.Enabled = Not chk_AllModel.Checked
        cmb_Sazande.Enabled = Not chk_allSazande.Checked
    End Sub
    Private Sub EnableAllTajhiz()
        txt_OrderCode.Enabled = Not chk_allOrderCode.Checked
        cmb_TajhizName.Enabled = Not chk_AllName.Checked
    End Sub
    Private Sub EnableRele()
        txt_ReleCT.Enabled = Not chk_AllRCT.Checked
        txt_ReleName.Enabled = Not Chk_AllRNme.Checked
        txt_ReleOrderCode.Enabled = Not chk_AllROrder.Checked
        txt_ReleVT.Enabled = Not chk_AllRVT.Checked
    End Sub
    Private Sub EnableBarghGir()
        txt_BGName.Enabled = Not chk_AllBGName.Checked
        txt_BGClass.Enabled = Not chk_AllBGClass.Checked
        txt_BGJaryan.Enabled = Not chk_AllBGJaryan.Checked
        txt_BGJaryanSC.Enabled = Not chk_AllBGSC.Checked
        txt_BGTavan.Enabled = Not chk_AllBGTavan.Checked
        txt_BGVoltaj.Enabled = chk_AllBGVoltaj.Checked
    End Sub
    Private Sub EnableSexioner()
        txt_SexName.Enabled = Not chk_AllSexName.Checked
        txt_SexJaryan.Enabled = Not chk_AllSexJaryan.Checked
        txt_SexJaryanSC.Enabled = Not chk_AllSexSC.Checked
        txt_SexMaxJaryan.Enabled = Not chk_AllSexMaxJaryan.Checked
        txt_sexUtilizationVoltaje.Enabled = Not chk_AllsexUtiVoltaj.Checked
        txt_SexVoltage.Enabled = Not chk_AllSexVoltaj.Checked

    End Sub
    Private Sub EnableTG()
        txt_TGName.Enabled = Not chk_AllTgName.Checked
        txt_TGampedance.Enabled = Not chk_AllTGAmpedanse.Checked
        txt_TGBill.Enabled = Not chk_AllTGBill.Checked
        txt_TGColling.Enabled = Not chk_AllTGCooler.Checked
        txt_TGFrequncy.Enabled = Not chk_AllTGFerequenc.Checked
        txt_TGJaryan.Enabled = Not chk_AllTGJaryanConvert.Checked
        txt_TGVectore.Enabled = Not chk_AllTGVectorGroup.Checked
        txt_TGVolume.Enabled = Not chk_AllTGValume.Checked
        txt_TGtapConvert.Enabled = Not chk_AllTGTapChange.Checked
        txt_TGTapPlace.Enabled = Not chk_AllTGTapPlace.Checked
        txt_TGVotaj.Enabled = Not chk_AllTGVotajConvert.Checked

    End Sub
    Private Sub EnableBreaker()
        txt_BrName.Enabled = Not chk_ALLBRName.Checked
        txt_BrBill.Enabled = Not chk_AllBRBill.Checked
        txt_BrConnect.Enabled = Not chk_AllBRConnect.Checked
        txt_BRDisconnect.Enabled = Not chk_AllBRDisconnect.Checked
        txt_BRJaryanN.Enabled = Not chk_AllBRJaryanN.Checked
        txt_BRMaxJaryan.Enabled = Not chk_AllBRMaxJaryan.Checked
        txt_BRJaryanSC.Enabled = Not chk_AllBRSC.Checked
        txt_BRMaxVoltaje.Enabled = Not chk_AllBRMaxVoltaj.Checked
        txt_BRMekanism.Enabled = Not chk_AllBRMekanizm.Checked
        txt_BRTurnOff.Enabled = Not chk_AllBRTurnoff.Checked
        txt_BRVotajN.Enabled = Not chk_AllBRVoltajN.Checked
    End Sub
    Private Sub EnableTrans()
        txt_TrName.Enabled = chk_AllTrName.Checked
        txt_TVJbill.Enabled = Not chk_AllTVJBill.Checked
        txt_TVJCoreClass.Enabled = Not chk_AllTVJClass.Checked
        txt_TVJCoreConvert.Enabled = Not chk_AllTVJCoreConvert.Checked
        txt_TVJMaxJaryan.Enabled = Not chk_AllTVJMaxJaryan.Checked
        txt_TVJMaxVoltage.Enabled = Not chk_AllTVJMaxVoltaj.Checked
    End Sub
    Private Sub EnableCable()
        txt_CableName.Enabled = chk_AllCAbleNAme.Checked
        txt_CMaghta.Enabled = Not chk_AllCMaghta.Checked
        txt_CValidJaryan.Enabled = Not chk_AllCJaryan.Checked
        txt_CVoltaj.Enabled = Not chk_AllCSatheVoltaj.Checked
    End Sub
    Private Sub Tab_Tajhiz_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Tajhiz.SelectedIndexChanged
        For Each chk As Control In Me.Tab_Tajhiz.SelectedTab.Controls
            If (TypeOf chk Is CheckBox) Then
                DirectCast(chk, CheckBox).Checked = True
            End If
            If (TypeOf chk Is CS_Component.TextBox) Then
                DirectCast(chk, CS_Component.TextBox).Value = ""
            End If
        Next
    End Sub
    Private Sub chk_AllPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllPost.CheckedChanged, chk_AllUtilizationDate.CheckedChanged, chk_AllSerial.CheckedChanged, chk_allSazande.CheckedChanged, chk_AllModel.CheckedChanged, chk_AllMadeDate.CheckedChanged, chk_AllDispatch.CheckedChanged
        EnableTajhiz()
    End Sub
    Private Sub chk_AllName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllName.CheckedChanged, chk_allOrderCode.CheckedChanged
        EnableAllTajhiz()
    End Sub
    Private Sub Chk_AllRNme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllRNme.CheckedChanged, chk_AllRVT.CheckedChanged, chk_AllROrder.CheckedChanged, chk_AllRCT.CheckedChanged
        EnableRele()
    End Sub
    Private Sub chk_AllTGVectorGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllTGVectorGroup.CheckedChanged, chk_AllTGVotajConvert.CheckedChanged, chk_AllTGValume.CheckedChanged, chk_AllTGTapPlace.CheckedChanged, chk_AllTGJaryanConvert.CheckedChanged, chk_AllTGFerequenc.CheckedChanged, chk_AllTGCooler.CheckedChanged, chk_AllTGBill.CheckedChanged, chk_AllTGAmpedanse.CheckedChanged, chk_AllTgName.CheckedChanged
        EnableTG()
    End Sub
    Private Sub chk_AllBGVoltaj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllBGVoltaj.CheckedChanged, chk_AllBGTavan.CheckedChanged, chk_AllBGSC.CheckedChanged, chk_AllBGJaryan.CheckedChanged, chk_AllBGClass.CheckedChanged, chk_AllBGName.CheckedChanged
        EnableBarghGir()
    End Sub
    Private Sub chk_AllSexVoltaj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllSexVoltaj.CheckedChanged, chk_AllsexUtiVoltaj.CheckedChanged, chk_AllSexSC.CheckedChanged, chk_AllSexMaxJaryan.CheckedChanged, chk_AllSexJaryan.CheckedChanged, chk_AllSexName.CheckedChanged
        EnableSexioner()
    End Sub
    Private Sub chk_AllBRTurnoff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllBRTurnoff.CheckedChanged, chk_AllBRVoltajN.CheckedChanged, chk_AllBRSC.CheckedChanged, chk_AllBRMekanizm.CheckedChanged, chk_AllBRMaxVoltaj.CheckedChanged, chk_AllBRMaxJaryan.CheckedChanged, chk_AllBRJaryanN.CheckedChanged, chk_AllBRDisconnect.CheckedChanged, chk_AllBRConnect.CheckedChanged, chk_AllBRBill.CheckedChanged, chk_ALLBRName.CheckedChanged
        EnableBreaker()
    End Sub
    Private Sub chk_AllTVJCoreConvert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllTVJCoreConvert.CheckedChanged, chk_AllTVJMaxVoltaj.CheckedChanged, chk_AllTVJMaxJaryan.CheckedChanged, chk_AllTVJClass.CheckedChanged, chk_AllTVJBill.CheckedChanged, chk_AllTrName.CheckedChanged, chk_ALLTrCoreNumber.CheckedChanged
        EnableTrans()
    End Sub
    Private Sub chk_AllCJaryan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllCJaryan.CheckedChanged, chk_AllCSatheVoltaj.CheckedChanged, chk_AllCMaghta.CheckedChanged, chk_AllCAbleNAme.CheckedChanged
        EnableCable()
    End Sub
End Class