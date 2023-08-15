Public Class Frm_Rp_SaghfeKar

    Private Sub Frm_Rp_SaghfeKar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_ToDate.Value = Setting.TarikheJary
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        Dim i As Integer = -1
        If Not lk_Ashkhas.Result Is Nothing Then
            i = Integer.Parse(lk_Ashkhas.Result(0).ToString)
        End If
        DataGridView1.DataSource = GetSaghfKarDT()
        'Rp_SaghfeKarTableAdapter.Fill(Ds_Rp.Rp_SaghfeKar, i, _
        '                            IIf(txt_FromDate.Value = "", "-1", txt_FromDate.Value), _
        '                            IIf(txt_ToDate.Value = "", "-1", txt_ToDate.Value))
        Rp_WorkFormWorkDisTableAdapter.Fill(Ds_Rp.Rp_WorkFormWorkDis, i, _
                                            IIf(txt_FromDate.Value = "", "-1", txt_FromDate.Value), _
                                            IIf(txt_ToDate.Value = "", "-1", txt_ToDate.Value))

    End Sub

    Function GetSaghfKarDT() As DataTable
        Dim i As Integer = -1
        If Not lk_Ashkhas.Result Is Nothing Then
            i = Integer.Parse(lk_Ashkhas.Result(0).ToString)
        End If
        Dim dt As DataTable

        Try
            If i = -1 Then
                dt = BaseDataObject.DataAccess.GetDataTable("SELECT     dbo.Pm_WorkForm_Master.Srl, dbo.Pm_WorkForm_Master.No AS [شماره فرم کار], dbo.Pm_WorkForm_Master.WorkFormTarikh AS تاریخ, " & _
                      "dbo.Pm_WorkFrom_Detail.MazadEzafeKar AS [سقف اضاقه کار], dbo.Pm_WorkFrom_Detail.SatKAr AS [نفر ساعت], dbo.Pm_WorkFrom_Detail.EzafeKAr AS [اضافه کار], " & _
                      "dbo.Pm_WorkFrom_Detail.EzafeKarTaradod AS [اضافه کار تردد], dbo.Pm_Ashkhas.Name + ' ' + dbo.Pm_Ashkhas.Family AS [عضو گروه], dbo.Pm_Group.Name AS [نام گروه], " & _
                       "dbo.Hafte.Text AS [روز هفته] FROM         dbo.Pm_WorkForm_Master INNER JOIN " & _
                     " dbo.Pm_WorkFrom_Detail ON dbo.Pm_WorkForm_Master.Srl = dbo.Pm_WorkFrom_Detail.Srl_Pm_WorkForm_Master LEFT OUTER JOIN " & _
                   "   dbo.Hafte ON dbo.Pm_WorkForm_Master.srl_dayofweek = dbo.Hafte.srl LEFT OUTER JOIN " & _
                   "   dbo.Pm_Ashkhas ON dbo.Pm_WorkFrom_Detail.Srl_Pm_Ashkhas = dbo.Pm_Ashkhas.Srl LEFT OUTER JOIN " & _
                   "   dbo.Pm_Group ON dbo.Pm_WorkFrom_Detail.Srl_Pm_Group = dbo.Pm_Group.Srl " & _
"WHERE     (dbo.Pm_WorkForm_Master.WorkFormTarikh >='" + txt_FromDate.Value + "') " & _
"AND (dbo.Pm_WorkForm_Master.WorkFormTarikh <='" + txt_ToDate.Value + "')")
            Else
                dt = BaseDataObject.DataAccess.GetDataTable("SELECT     dbo.Pm_WorkForm_Master.Srl, dbo.Pm_WorkForm_Master.No AS [شماره فرم کار], dbo.Pm_WorkForm_Master.WorkFormTarikh AS تاریخ, " & _
                      "dbo.Pm_WorkFrom_Detail.MazadEzafeKar AS [سقف اضاقه کار], dbo.Pm_WorkFrom_Detail.SatKAr AS [نفر ساعت], dbo.Pm_WorkFrom_Detail.EzafeKAr AS [اضافه کار], " & _
                      "dbo.Pm_WorkFrom_Detail.EzafeKarTaradod AS [اضافه کار تردد], dbo.Pm_Ashkhas.Name + ' ' + dbo.Pm_Ashkhas.Family AS [عضو گروه], dbo.Pm_Group.Name AS [نام گروه], " & _
                       "dbo.Hafte.Text AS [روز هفته] FROM         dbo.Pm_WorkForm_Master INNER JOIN " & _
                     " dbo.Pm_WorkFrom_Detail ON dbo.Pm_WorkForm_Master.Srl = dbo.Pm_WorkFrom_Detail.Srl_Pm_WorkForm_Master LEFT OUTER JOIN " & _
                   "   dbo.Hafte ON dbo.Pm_WorkForm_Master.srl_dayofweek = dbo.Hafte.srl LEFT OUTER JOIN " & _
                   "   dbo.Pm_Ashkhas ON dbo.Pm_WorkFrom_Detail.Srl_Pm_Ashkhas = dbo.Pm_Ashkhas.Srl LEFT OUTER JOIN " & _
                   "   dbo.Pm_Group ON dbo.Pm_WorkFrom_Detail.Srl_Pm_Group = dbo.Pm_Group.Srl " & _
"WHERE     (dbo.Pm_WorkFrom_Detail.Srl_Pm_Ashkhas = " + i.ToString + ") AND  (dbo.Pm_WorkForm_Master.WorkFormTarikh >='" + txt_FromDate.Value + "') " & _
"AND (dbo.Pm_WorkForm_Master.WorkFormTarikh <='" + txt_ToDate.Value + "')")
            End If
            Return dt
        Catch ex As Exception
            MessageBoxFa.Show("لطفا دامنه جستجو را کمتر کنيد")
        End Try
        Return Nothing
    End Function

    Private Sub Btn_print2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_print2.Click
        Dim rp As New Rp_SaghfeKAr
        rp.SetDataSource(GetSaghfKarDT)
        'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
        Dim frm_rp As New Frm_RpVw(rp, Ds_Rp.Rp_SaghfeKar.DataSet.Tables("0"))
        frm_rp.ShowDialog()
    End Sub

    Private Sub btn_PrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PrintAll.Click

        Dim f As New Frm_Wait
        Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)
        t.Start()

        Dim rp As New Rp_SaghfeKar_Total

        Dim da As New Ds_RpTableAdapters.Rp_SaghfKarTotalTableAdapter
        Dim dt As New Ds_Rp.Rp_SaghfKarTotalDataTable

        da.Fill(dt, txt_FromDate.Value, txt_ToDate.Value)

        Dim dtt As DataTable = dt.DefaultView.Table
        rp.SetDataSource(dtt)
        rp.SetParameterValue(rp.Parameter_aztarikh.ParameterFieldName, txt_FromDate.Value)
        rp.SetParameterValue(rp.Parameter_tatarikh.ParameterFieldName, txt_ToDate.Value)
        Dim frm_rp As New Frm_RpVw(rp, dtt)
        If t.IsAlive Then
            t.Abort()
        End If

        frm_rp.ShowDialog()
    End Sub
End Class