Public Class Frm_Rp_Amo_View

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If

        Dim Srl_AShkhas As Integer = -1
        If Not chk_Name.Checked Then
            Srl_AShkhas = Cmb_Name.SelectedValue
        End If

        Dim DoreType As Integer = -1
        If Not chk_Type.Checked Then
            DoreType = cmb_Type.SelectedValue
        End If

        Dim DoreName As Integer = -1
        If Not chk_DoreName.Checked Then
            DoreName = cmb_DoreName.SelectedValue
        End If

        Dim Modat As Integer = -1
        If Not chk_Modat.Checked Then
            Modat = txt_Modat.Value
        End If

        Dim ZamanDore As Integer = -1
        If Not chk_Zaman.Checked Then
            ZamanDore = cmb_Zaman.SelectedValue
        End If

        Dim Vahed As Integer = -1
        If Not chk_Vahed.Checked Then
            Vahed = cmb_VAhed.SelectedValue
        End If

        Dim Moasese As Integer = -1
        If Not chk_moasese.Checked Then
            Moasese = cmb_Moasese.SelectedValue
        End If

        Dim Mahal As Integer = -1
        If Not chk_MahalBArgozary.Checked Then
            Mahal = Cmb_MahalBArgozary.SelectedValue
        End If

        Pm_Amo_DoreTableAdapter.FillByAllSearch(Ds_Amozesh.Pm_Amo_Dore, Srl_AShkhas, Vahed, _
                                                DoreName, Moasese, Mahal, DoreType, ZamanDore, Modat, FromDate, ToDate)
        lbl_Record.Text = "تعداد رکورد :"
        lbl_Record.Text += Ds_Amozesh.Pm_Amo_Dore.Rows.Count.ToString
    End Sub

    Private Sub Frm_Rp_Amo_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_Amo_MahaleBargozaryTableAdapter.Fill(Me.Ds_Amozesh.Pm_Amo_MahaleBargozary)
        Me.Pm_Amo_MoaseseAmozeshiTableAdapter.Fill(Me.Ds_Amozesh.Pm_Amo_MoaseseAmozeshi)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_Amo_ZamanDoreTableAdapter.Fill(Me.Ds_Amozesh.Pm_Amo_ZamanDore)
        Me.Pm_Amo_DoreNameTableAdapter.Fill(Me.Ds_Amozesh.Pm_Amo_DoreName)
        Me.Pm_Amo_DoreTypeTableAdapter.Fill(Me.Ds_Amozesh.Pm_Amo_DoreType)
        Me.Pm_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Ashkhas)
    End Sub

    Private Sub chk_Name_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Name.CheckedChanged
        Cmb_Name.Enabled = Not chk_Name.Checked
    End Sub

    Private Sub chk_Type_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Type.CheckedChanged
        cmb_Type.Enabled = Not chk_Type.Checked
    End Sub

    Private Sub chk_DoreName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DoreName.CheckedChanged
        cmb_DoreName.Enabled = Not chk_DoreName.Checked
    End Sub

    Private Sub chk_Modat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Modat.CheckedChanged
        txt_Modat.Enabled = Not chk_Modat.Checked
    End Sub

    Private Sub chk_Zaman_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Zaman.CheckedChanged
        cmb_Zaman.Enabled = Not chk_Zaman.Checked
    End Sub

    Private Sub chk_Vahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Vahed.CheckedChanged
        cmb_VAhed.Enabled = Not chk_Vahed.Checked
    End Sub

    Private Sub chk_allday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allday.CheckedChanged
        txt_FromDate.Enabled = Not chk_allday.Checked
        txt_ToDate.Enabled = Not chk_allday.Checked
    End Sub

    Private Sub chk_moasese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_moasese.CheckedChanged
        cmb_Moasese.Enabled = Not chk_moasese.Checked
    End Sub

    Private Sub chk_MahalBArgozary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_MahalBArgozary.CheckedChanged
        Cmb_MahalBArgozary.Enabled = Not chk_MahalBArgozary.Checked
    End Sub

    Private Sub Btn_PrintDore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PrintDore.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If

        Dim dt As New Ds_Amozesh.Rp_Amo_DoreDataTable
        Dim da As New Ds_AmozeshTableAdapters.Rp_Amo_DoreTableAdapter

        da.Fill(dt, srl)
        Dim rp As New Rp_Amo_Dore
        Dim dt1 As DataTable = dt
        rp.SetDataSource(dt1)
        Dim frm_rp As New Frm_RpVw(rp, dt1)
        frm_rp.ShowDialog()
    End Sub

    Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_print.Click
        Dim rp As New Rp_Amo_PrintAll

        Dim dt As DataTable = Ds_Amozesh.Pm_Amo_Dore
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()
    End Sub

    Private Sub cmb_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Type.SelectedIndexChanged
        Me.Pm_Amo_DoreNameTableAdapter.FillBy(Me.Ds_Amozesh.Pm_Amo_DoreName, cmb_DoreName.SelectedValue)
    End Sub
End Class