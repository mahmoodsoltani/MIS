Public Class Frm_Rp_MonthReportDetail

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim srl_contract As Integer = -1
        Dim srl_vahed As Integer = -1
        Dim srl_Source As Integer = -1
        Dim srl_omoor As Integer = -1
        Dim srl_Month As Integer = -1
        Dim year As String = "-1"
        Dim sstype As Integer = -1
        Dim status As Integer = 1
        If rb_AllStatus.Checked Then
            status = 1
        ElseIf rb_NoConfirm.Checked Then
            status = 2
        ElseIf rb_NoErp.Checked Then
            status = 3
        ElseIf rb_ERP.Checked Then
            status = 4
        End If
        If rb_pm.Checked Then
            sstype = 1
        ElseIf rb_Mazad.Checked Then
            sstype = 2
        End If
        If Not chk_contract.Checked Then
            srl_contract = cmb_Contract.SelectedValue
        End If
        If Not chk_vahed.Checked Then
            srl_vahed = cmb_vahed.SelectedValue
        End If
        If Not chk_Omoor.Checked Then
            srl_omoor = cmb_omoor.SelectedValue
        End If
        If Not chk_source.Checked Then
            srl_Source = cmb_source.SelectedValue
        End If
        If Not chk_Month.Checked Then
            srl_Month = cmb_month.SelectedValue
        End If
        If Not chk_Month.Checked Then
            srl_Month = cmb_month.SelectedValue
        End If
        If Not chk_year.Checked Then
            year = txt_year.Text
        End If
        Dim sort As String = ""
        If cmb_Sort1.Text <> "" Then
            sort = cmb_Sort1.Text
        End If
        If cmb_sort2.Text <> "" Then
            If sort <> "" Then
                sort = sort + "," + cmb_sort2.Text
            Else
                sort = cmb_sort2.Text
            End If
        End If
        If cmb_sort3.Text <> "" Then
            If sort <> "" Then
                sort = sort + "," + cmb_sort3.Text
            Else
                sort = cmb_sort3.Text
            End If
        End If
        Dim GroupByName As String = " "
        If rb_NoGroup.Checked Then
            sort = sort.Replace("دوره", "Month")
            Me.Pm_Con_MonthReport_DetailTableAdapter.Fill(Me.Ds_Con.Pm_Con_MonthReport_Detail, srl_Month, CInt(year), srl_contract, srl_vahed, sstype, srl_Source, srl_omoor, status)
            Dim rp As New Rp_MonthReport_Detail()
            Dim dt As DataTable = Ds_Con.Pm_Con_MonthReport_Detail
            dt.DefaultView.Sort = sort
            dt = dt.DefaultView.ToTable()
            rp.SetDataSource(dt)
           
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()
        Else
            Me.Pm_Con_MonthReport_DetailTableAdapter.Fill(Me.Ds_Con.Pm_Con_MonthReport_Detail, srl_Month, CInt(year), srl_contract, srl_vahed, sstype, srl_Source, srl_omoor, status)
            Dim rp As New Rp_MonthReport_Detail_Group()
            Dim dt As DataTable = Ds_Con.Pm_Con_MonthReport_Detail
            
            Dim FieldDef As CrystalDecisions.CrystalReports.Engine.FieldDefinition
            If rb_VahedGroup.Checked Then
                FieldDef = rp.Database.Tables.Item(0).Fields.Item("نام واحد")
                dt.DefaultView.Sort = "نام واحد"
                dt = dt.DefaultView.ToTable()
                GroupByName = "گروه بندی بر اساس واحد"
            ElseIf rb_omoorGroup.Checked Then
                FieldDef = rp.Database.Tables.Item(0).Fields.Item("گروه")
                dt.DefaultView.Sort = "گروه"
                dt = dt.DefaultView.ToTable()
                GroupByName = "گروه بندی بر اساس  منبع و امور"
            ElseIf rb_MonthGroup.Checked Then
                FieldDef = rp.Database.Tables.Item(0).Fields.Item("دوره")
                'dt.DefaultView.Sort = "Month"
                'dt = dt.DefaultView.ToTable()
                GroupByName = "گروه بندی بر اساس ماه"
            End If
            rp.SetDataSource(dt)

            rp.DataDefinition.Groups.Item(0).ConditionField = FieldDef
            rp.SetParameterValue(rp.Parameter_GroupBy.ParameterFieldName, GroupByName)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
            Dim frm_rp As New Frm_RpVw(rp, dt)
            frm_rp.ShowDialog()
            End If
    End Sub


    Private Sub chk_contract_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_contract.CheckedChanged
        cmb_Contract.Enabled = Not chk_contract.Checked
    End Sub

    Private Sub chk_vahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_vahed.CheckedChanged
        cmb_vahed.Enabled = Not chk_vahed.Checked
    End Sub

    Private Sub chk_source_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_source.CheckedChanged
        cmb_source.Enabled = Not chk_source.Checked
    End Sub

    Private Sub chk_Omoor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Omoor.CheckedChanged
        cmb_omoor.Enabled = Not chk_Omoor.Checked
    End Sub

    Private Sub chk_year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_year.CheckedChanged
        txt_year.Enabled = Not chk_year.Checked
    End Sub

    Private Sub chk_Month_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Month.CheckedChanged
        cmb_month.Enabled = Not chk_Month.Checked
    End Sub

    Private Sub Frm_Rp_MonthReportDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Month' table. You can move, or remove it, as needed.
        Me.Pm_MonthTableAdapter.Fill(Me.Ds_Con.Pm_Month)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_PostType' table. You can move, or remove it, as needed.
        Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Source' table. You can move, or remove it, as needed.
        Me.Pm_Con_SourceTableAdapter.Fill(Me.Ds_Con.Pm_Con_Source)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Contract' table. You can move, or remove it, as needed.
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)

    End Sub

End Class