Public Class Frm_RpWorkForm

    Private Sub Frm_RpWorkForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HafteTableAdapter.Fill(Me.Ds_Pm.Hafte)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        Me.Pm_HazineCodeTableAdapter.Fill(Me.Ds_Pm.Pm_HazineCode, -1)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_WorkDisTableAdapter.Fill(Me.Ds_Pm.Pm_WorkDis)
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, -1)
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If

        Dim MahalFaliat As Integer = -1
        If Not chk_MahalFaliat.Checked Then
            MahalFaliat = cmb_mahalFaliat.SelectedValue
        End If

        Dim mabdaHarkat As Integer = -1
        If Not chk_mabdaHarkat.Checked Then
            mabdaHarkat = cmb_mabdaHarkat.SelectedValue
        End If

        Dim MozoKar As Integer = -1
        If Not chk_MozoKar.Checked Then
            MozoKar = cmb_MozoKar.SelectedValue
        End If

        Dim WotkFormNo As Integer = -1
        If Not chk_WotkFormNo.Checked Then
            WotkFormNo = txt_WotkFormNo.Value
        End If

        Dim AyameHafte As Integer = -1
        If Not chk_Roz.Checked Then
            AyameHafte = cmb_roz.SelectedValue
        End If

        Dim AllVahed As Integer = -1
        If Not Chk_AllVahed.Checked Then
            AllVahed = cmb_AllVahed.SelectedValue
        End If

        Dim Gorup As Integer = -1
        If Not chk_Group.Checked Then
            Gorup = Cmb_Group.SelectedValue
        End If

        Dim Sarparast As Integer = -1
        If Not chk_Sarparast.Checked Then
            Sarparast = Cmb_Sarparast.SelectedValue
        End If

        Dim HazineCode As Integer = -1
        If Not chk_HazineCode.Checked Then
            HazineCode = cmb_HazineCode.SelectedValue
        End If

        Dim WorkDis As String = "-1"
        If Not chk_WorkDis.Checked Then
            WorkDis = txt_WorkDis.Value
        End If

        Dim f As New Frm_Wait
        Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)

        Try
            If t.IsAlive Then
                t.Abort()
            End If
            t.Start()
        Catch ex As Exception
            MessageBoxFa.Show("Please try again")
        End Try
        
        If chk_Ozv.Checked Then
            Try
                Rp_WorkFormMasterSearchTableAdapter.Fill(Ds_Rp.Rp_WorkFormMasterSearch, MahalFaliat, mabdaHarkat, Gorup _
                                                             , AllVahed, MozoKar, HazineCode, WotkFormNo, FromDate _
                                                             , ToDate, Sarparast, AyameHafte, "%" + txt_WorkDis.Value + "%")
                DataGridView1.Refresh()

                lbl_Record.Text = "تعداد رکورد :"
                lbl_Record.Text += Ds_Rp.Rp_WorkFormMasterSearch.Rows.Count.ToString
                DataGridView1.DataSource = Ds_Rp.Rp_WorkFormMasterSearch
            Catch ex As Exception
                MessageBoxFa.Show(ex.Message)
                If t.IsAlive Then
                    t.Abort()
                End If
                MessageBoxFa.Show("لطفا دامنه جستجو را کمتر کنيد")
            Finally
                If t.IsAlive Then
                    t.Abort()
                End If
            End Try
        Else
            'If chk_allday.Checked Then
            '    MessageBoxFa.Show("لطفا دامنه جستجو را کمتر کنيد")
            '    Return
            'End If
            Try
                Dim dt As DataTable = loadByAShkhas2()
                DataGridView1.DataSource = dt

                'Rp_WorkFormMasterTableAdapter.Fill(Ds_Rp.Rp_WorkFormMaster, MahalFaliat, mabdaHarkat, Gorup _
                '                                             , AllVahed, MozoKar, HazineCode, WotkFormNo, FromDate _
                '                                             , ToDate, Sarparast, AyameHafte, cmb_ozv.SelectedValue)

                lbl_Record.Text = "تعداد رکورد :"
                lbl_Record.Text += dt.Rows.Count.ToString
            Catch ex As Exception
                MessageBoxFa.Show(ex.Message)
                If t.IsAlive Then
                    t.Abort()
                End If
                MessageBoxFa.Show("لطفا دامنه جستجو را کمتر کنيد")
            Finally
                If t.IsAlive Then
                    t.Abort()
                End If
            End Try
        End If
    End Sub

    Sub loadByAShkhas()
        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If

        Dim MahalFaliat As Integer = -1
        If Not chk_MahalFaliat.Checked Then
            MahalFaliat = cmb_mahalFaliat.SelectedValue
        End If

        Dim mabdaHarkat As Integer = -1
        If Not chk_mabdaHarkat.Checked Then
            mabdaHarkat = cmb_mabdaHarkat.SelectedValue
        End If

        Dim MozoKar As Integer = -1
        If Not chk_MozoKar.Checked Then
            MozoKar = cmb_MozoKar.SelectedValue
        End If

        Dim WotkFormNo As Integer = -1
        If Not chk_WotkFormNo.Checked Then
            WotkFormNo = txt_WotkFormNo.Value
        End If

        Dim AyameHafte As Integer = -1
        If Not chk_Roz.Checked Then
            AyameHafte = cmb_roz.SelectedValue
        End If

        Dim AllVahed As Integer = -1
        If Not Chk_AllVahed.Checked Then
            AllVahed = cmb_AllVahed.SelectedValue
        End If

        Dim Gorup As Integer = -1
        If Not chk_Group.Checked Then
            Gorup = Cmb_Group.SelectedValue
        End If

        Dim Sarparast As Integer = -1
        If Not chk_Sarparast.Checked Then
            Sarparast = Cmb_Sarparast.SelectedValue
        End If

        Dim HazineCode As Integer = -1
        If Not chk_HazineCode.Checked Then
            HazineCode = cmb_HazineCode.SelectedValue
        End If

        'Dim WorkDis As String = "-1"
        'If Not chk_WorkDis.Checked Then
        '    WotkFormNo = txt_WorkDis.Value
        'End If

        'Rp_WorkFormMasterTableAdapter.FillByAshkhas(Ds_Rp.Rp_WorkFormMaster, MahalFaliat, mabdaHarkat, Gorup _
        '                                 , AllVahed, MozoKar, HazineCode, WotkFormNo, FromDate _
        '                                 , ToDate, Sarparast, AyameHafte, cmb_ozv.SelectedValue)
    End Sub

    Function loadByAShkhas2() As DataTable

        Dim whereclus As String = " Where "

        If Not chk_allday.Checked Then
            whereclus += "(Pm_WorkForm_Master.WorkFormTarikh  >= '" + txt_FromDate.Value.ToString + "') AND  (Pm_WorkForm_Master.WorkFormTarikh  <= '" + txt_ToDate.Value.ToString + "') AND "
        End If

        If Not chk_mabdaHarkat.Checked Then
            whereclus += "(Pm_WorkForm_Master.Srl_Pm_Post_To = " + cmb_mabdaHarkat.SelectedValue.ToString + ")  AND  "
        End If

        If Not chk_MahalFaliat.Checked Then
            whereclus += "(Pm_WorkForm_Master.Srl_Pm_Post_From =  " + cmb_mahalFaliat.SelectedValue.ToString + ") AND "
        End If

        If Not chk_MozoKar.Checked Then
            whereclus += "(Pm_WorkForm_Master.Srl_Pm_WorkDis = " + cmb_MozoKar.SelectedValue.ToString + ") AND "
        End If

        If Not chk_WotkFormNo.Checked Then
            whereclus += "(Pm_WorkForm_Master.No = " + txt_WotkFormNo.Value + ") AND  "
        End If

        If Not chk_Roz.Checked Then
            whereclus += "  (dbo.Pm_WorkForm_Master.srl_dayofweek =" + cmb_roz.SelectedValue.ToString + ") AND "
        End If

        If Not Chk_AllVahed.Checked Then
            whereclus += "(Pm_WorkForm_Master.Srl_Pm_Vahed = " + cmb_AllVahed.SelectedValue.ToString + ") AND "
        End If

        If Not chk_Group.Checked Then
            whereclus += "(Pm_WorkForm_Master.Srl_Pm_Group = " + Cmb_Group.SelectedValue.ToString + " ) AND "
        End If

        If Not chk_Sarparast.Checked Then
            whereclus += "(Pm_WorkForm_Master.Srl_Pm_Ashkhas_Sarparast=" + Cmb_Sarparast.SelectedValue.ToString + ") AND "
        End If

        If Not chk_HazineCode.Checked Then
            whereclus += "(Pm_WorkForm_Master.Srl_HazineCode = " + cmb_HazineCode.SelectedValue.ToString + ") AND "
        End If

        'If Not chk_Ozv.Checked Then
        '    whereclus += " (dbo.Pm_WorkFrom_Detail.Srl_Pm_Ashkhas = " + cmb_ozv.SelectedValue.ToString + ") AND  "
        'End If

        'Dim WorkDis As String = "-1"
        'If Not chk_WorkDis.Checked Then
        '    WotkFormNo = txt_WorkDis.Value
        'End If

        If whereclus = " Where " Then
            whereclus = ""
        Else
            whereclus = whereclus.Remove(whereclus.Length - 5, 5)
        End If
        Dim query As String = "SELECT    distinct  TOP (100) PERCENT dbo.Pm_WorkForm_Master.Srl, dbo.Pm_WorkForm_Master.No AS شماره, dbo.Pm_WorkForm_Master.Tarikh AS تاریخ, " & _
    "                  dbo.Pm_WorkForm_Master.WorkFormNo AS [شماره فرم کار], dbo.Pm_WorkForm_Master.WorkFormTarikh AS [تاریخ فرم کار], Pm_WorkFormDetails.عضو, " & _
   "                   ISNULL(dbo.Pm_Ashkhas.Name, '') + ' ' + ISNULL(dbo.Pm_Ashkhas.Family, '') AS سرپرست, dbo.Pm_Post.Name AS مبدا, Pm_Post_1.Name AS مقصد,  " & _
  "                    dbo.Pm_Group.Name AS گروه,dbo.GetWrokFormGroupOzv(dbo.Pm_WorkForm_Master.Srl) AS [اعضا], dbo.Pm_Vahed.Name AS واحد, ISNULL(dbo.Pm_WorkDis.Name, 'ثبت نشده') AS [توضیح کار], dbo.Pm_HazineCode.Code AS [کد هزینه],  " & _
 "                     dbo.Pm_HazineCode.Sharh AS [نام پروژه], dbo.Pm_WorkForm_Master.WorkFormDis  AS [شرح کار], dbo.Pm_WorkForm_Master.Srl_Pm_Ashkhas_Sarparast " & _
"FROM         dbo.Pm_HazineCode RIGHT OUTER JOIN " & _
                "      dbo.Pm_WorkDis RIGHT OUTER JOIN " & _
                 "     dbo.Pm_WorkForm_Master INNER JOIN " & _
               "       dbo.Pm_Post ON dbo.Pm_WorkForm_Master.Srl_Pm_Post_From = dbo.Pm_Post.Srl INNER JOIN " & _
              "        dbo.Pm_Post AS Pm_Post_1 ON dbo.Pm_WorkForm_Master.Srl_Pm_Post_To = Pm_Post_1.Srl INNER JOIN " & _
             "             (SELECT     dbo.Pm_WorkFrom_Detail.Srl_Pm_WorkForm_Master, dbo.Pm_WorkFrom_Detail.Srl_Pm_Ashkhas, " & _
            "                                       Pm_Ashkhas_1.Name + ' ' + Pm_Ashkhas_1.Family AS عضو " & _
           "                  FROM         dbo.Pm_Ashkhas AS Pm_Ashkhas_1 INNER JOIN " & _
          "                                         dbo.Pm_WorkFrom_Detail ON Pm_Ashkhas_1.Srl = dbo.Pm_WorkFrom_Detail.Srl_Pm_Ashkhas " & _
         "                    WHERE     (dbo.Pm_WorkFrom_Detail.Srl_Pm_Ashkhas = " + cmb_ozv.SelectedValue.ToString + ")) AS Pm_WorkFormDetails ON  " & _
       "               dbo.Pm_WorkForm_Master.Srl = Pm_WorkFormDetails.Srl_Pm_WorkForm_Master LEFT OUTER JOIN " & _
      "                dbo.Pm_Ashkhas ON dbo.Pm_WorkForm_Master.Srl_Pm_Ashkhas_Sarparast = dbo.Pm_Ashkhas.Srl ON  " & _
     "                 dbo.Pm_WorkDis.Srl = dbo.Pm_WorkForm_Master.Srl_Pm_WorkDis LEFT OUTER JOIN " & _
    "                  dbo.Pm_Group ON dbo.Pm_WorkForm_Master.Srl_Pm_Group = dbo.Pm_Group.Srl ON  " & _
   "                   dbo.Pm_HazineCode.Srl = dbo.Pm_WorkForm_Master.Srl_HazineCode LEFT OUTER JOIN " & _
  "                    dbo.Pm_Vahed ON dbo.Pm_WorkForm_Master.Srl_Pm_Vahed = dbo.Pm_Vahed.Srl LEFT OUTER JOIN" & _
  "                    dbo.Pm_WorkFrom_Detail ON dbo.Pm_WorkFrom_Detail.Srl_Pm_WorkForm_Master = dbo.Pm_WorkForm_Master.Srl " & _
   whereclus + " ORDER BY dbo.Pm_WorkForm_Master.Srl DESC"
        Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable(query)
        Return dt
    End Function

    Private Sub chk_MahalFaliat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_MahalFaliat.CheckedChanged
        cmb_mahalFaliat.Enabled = Not chk_MahalFaliat.Checked
    End Sub

    Private Sub chk_mabdaHarkat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mabdaHarkat.CheckedChanged
        cmb_mabdaHarkat.Enabled = Not chk_mabdaHarkat.Checked
    End Sub

    Private Sub chk_MozoKar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_MozoKar.CheckedChanged
        cmb_MozoKar.Enabled = Not chk_MozoKar.Checked
    End Sub

    Private Sub chk_WotkFormNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_WotkFormNo.CheckedChanged
        txt_WotkFormNo.Enabled = Not chk_WotkFormNo.Checked
    End Sub

    Private Sub Chk_AllVahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllVahed.CheckedChanged
        cmb_AllVahed.Enabled = Not Chk_AllVahed.Checked
    End Sub

    Private Sub chk_Group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Group.CheckedChanged
        Cmb_Group.Enabled = Not chk_Group.Checked
    End Sub

    Private Sub chk_Sarparast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Sarparast.CheckedChanged
        Cmb_Sarparast.Enabled = Not chk_Sarparast.Checked
    End Sub

    Private Sub chk_HazineCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_HazineCode.CheckedChanged
        cmb_HazineCode.Enabled = Not chk_HazineCode.Checked
    End Sub

    Private Sub chk_WorkDis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_WorkDis.CheckedChanged
        txt_WorkDis.Enabled = Not chk_WorkDis.Checked
    End Sub

    Private Sub chk_allday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allday.CheckedChanged
        txt_FromDate.Enabled = Not chk_allday.Checked
        txt_ToDate.Enabled = Not chk_allday.Checked
    End Sub

    Private Sub Btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim s As New Frm_WorkForm(srl)
        s.ShowDialog()
    End Sub

    Private Sub chk_Roz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Roz.CheckedChanged
        cmb_roz.Enabled = Not chk_Roz.Checked
    End Sub

    Private Sub chk_Ozv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Ozv.CheckedChanged
        cmb_ozv.Enabled = Not chk_Ozv.Checked
    End Sub

    Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_print.Click
        Dim f As New Frm_Wait
        Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)
        t.Start()

        Dim rp As New Rp_WorkFormGozareshHaftegi


        rp.SetDataSource(DirectCast(DataGridView1.DataSource, DataTable))
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
        Dim frm_rp As New Frm_RpVw(rp, DirectCast(DataGridView1.DataSource, DataTable))
        If t.IsAlive Then
            t.Abort()
        End If

        frm_rp.ShowDialog()
    End Sub

    Private Sub Btn_Rp_Kholase_FormKar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Rp_Kholase_FormKar.Click
        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If

        Dim MahalFaliat As Integer = -1
        If Not chk_MahalFaliat.Checked Then
            MahalFaliat = cmb_mahalFaliat.SelectedValue
        End If

        Dim mabdaHarkat As Integer = -1
        If Not chk_mabdaHarkat.Checked Then
            mabdaHarkat = cmb_mabdaHarkat.SelectedValue
        End If

        Dim MozoKar As Integer = -1
        If Not chk_MozoKar.Checked Then
            MozoKar = cmb_MozoKar.SelectedValue
        End If

        Dim WotkFormNo As Integer = -1
        If Not chk_WotkFormNo.Checked Then
            WotkFormNo = txt_WotkFormNo.Value
        End If

        Dim AllVahed As Integer = -1
        If Not Chk_AllVahed.Checked Then
            AllVahed = cmb_AllVahed.SelectedValue
        End If

        Dim Gorup As Integer = -1
        If Not chk_Group.Checked Then
            Gorup = Cmb_Group.SelectedValue
        End If

        Dim Sarparast As Integer = -1
        If Not chk_Sarparast.Checked Then
            Sarparast = Cmb_Sarparast.SelectedValue
        End If

        Dim HazineCode As Integer = -1
        If Not chk_HazineCode.Checked Then
            HazineCode = cmb_HazineCode.SelectedValue
        End If

        Dim WorkDis As String = "-1"
        If Not chk_WorkDis.Checked Then
            WotkFormNo = txt_WorkDis.Value
        End If

        Rp_KholaseWorkFormTableAdapter.Fill(Ds_Rp.Rp_KholaseWorkForm, MahalFaliat, mabdaHarkat, Gorup _
                                           , AllVahed, MozoKar, HazineCode, WotkFormNo, FromDate _
                                           , ToDate, Sarparast)
        Dim s As New Frm_Rp_KholaseWorkForm(Ds_Rp.Rp_KholaseWorkForm)
        s.ShowDialog()
    End Sub

    Private Sub cmb_AllVahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_AllVahed.SelectedIndexChanged
        Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, cmb_AllVahed.SelectedValue)
    End Sub
End Class