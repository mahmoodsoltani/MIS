Public Class Frm_Post
    Private Edit_CurrentIndex As Integer

    Public Overrides Sub LoadDataGridView()
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_PostmodelTableAdapter.Fill(Me.Ds_Pm.Pm_Postmodel)
        txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        Me.Pm_PostTipTableAdapter.Fill(Me.Ds_Pm.Pm_PostTip)
        MyBase.LoadDataGridView()
        Btn_Report.Enabled = True
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If Edit_CurrentIndex > 0 Then
            Dim dr_Post As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Post", Edit_CurrentIndex)
            dr_Post("SubmitDate") = Setting.Now
            dr_Post("Srl_SubmitUser") = Setting.Srl_User
            dr_Post("Code") = txt_Code.Value
            dr_Post("Name") = txt_Name.Value
            BaseDataObject.DataAccess.BeginTransaction()
            Try
                If BaseDataObject.DataAccess.Update(dr_Post, 0, False) Then
                    BaseDataObject.DataAccess.Delete("Pm_PostDetails", "Srl_Pm_Post=" + Edit_CurrentIndex.ToString())
                    Dim dr_PostDetails As DataRow = BaseDataObject.DataAccess.NewRow("Pm_PostDetails")
                    dr_PostDetails("Srl_Pm_Post") = Edit_CurrentIndex
                    dr_PostDetails("Srl_Pm_PostTip") = IIf(lkb_Tip.SelectedValue Is Nothing, DBNull.Value, lkb_Tip.SelectedValue)
                    dr_PostDetails("Srl_Pm_PostType") = IIf(lkb_Type.SelectedValue Is Nothing, DBNull.Value, lkb_Type.SelectedValue)
                    dr_PostDetails("Srl_Pm_PostModel") = IIf(lkb_Tajhiz.SelectedValue Is Nothing, DBNull.Value, lkb_Tajhiz.SelectedValue)
                    dr_PostDetails("SatheVoltaj") = txt_SathVoltaj.Value.ToString().Trim()
                    dr_PostDetails("SalBahrebardari") = txt_SaleBahrebardari.Value.ToString().Trim()
                    dr_PostDetails("Transformator") = txt_Transformator.Value.ToString().Trim()
                    dr_PostDetails("Automasion") = txt_Otomasion.Value.ToString().Trim()
                    dr_PostDetails("Rele") = txt_Rele.Value.ToString().Trim()
                    dr_PostDetails("Zarfiyat_MVA") = txt_ZMVA.Value.ToString().Trim()
                    dr_PostDetails("Zarfiyat_Count") = txt_ZCount.Value.ToString().Trim()
                    dr_PostDetails("IsMission") = IIf(Chk_IsMission.Checked, 1, 0)

                    If Not BaseDataObject.DataAccess.Insert(dr_PostDetails, True) Then
                        BaseDataObject.DataAccess.RollBack()
                        Return False
                    Else
                        BaseDataObject.DataAccess.Commit()
                    End If
                Else
                    BaseDataObject.DataAccess.RollBack()
                    MessageBoxFa.Show("اشکال در بروزرسانی اطلاعات")
                    Return False
                End If
            Catch
                BaseDataObject.DataAccess.RollBack()
                MessageBoxFa.Show("اشکال در بروزرسانی اطلاعات")
                Return False
            End Try
        Else

            Dim dr_Post As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Post")
            dr_Post("SubmitDate") = Setting.Now
            dr_Post("Srl_SubmitUser") = Setting.Srl_User
            dr_Post("Code") = txt_Code.Value
            dr_Post("Name") = txt_Name.Value
            BaseDataObject.DataAccess.BeginTransaction()
            Try
                Dim Srl_Post = BaseDataObject.DataAccess.InsertWithLastId(dr_Post, False)
                If Srl_Post > 0 Then
                    Dim dr_PostDetails As DataRow = BaseDataObject.DataAccess.NewRow("Pm_PostDetails")
                    dr_PostDetails("Srl_Pm_Post") = Srl_Post
                    dr_PostDetails("Srl_Pm_PostTip") = IIf(lkb_Tip.SelectedValue Is Nothing, DBNull.Value, lkb_Tip.SelectedValue)
                    dr_PostDetails("Srl_Pm_PostModel") = IIf(lkb_Tajhiz.SelectedValue Is Nothing, DBNull.Value, lkb_Tajhiz.SelectedValue)
                    dr_PostDetails("Srl_Pm_PostType") = IIf(lkb_Type.SelectedValue Is Nothing, DBNull.Value, lkb_Type.SelectedValue)
                    dr_PostDetails("SatheVoltaj") = txt_SathVoltaj.Value.ToString().Trim()
                    dr_PostDetails("SalBahrebardari") = txt_SaleBahrebardari.Value.ToString().Trim()
                    dr_PostDetails("Transformator") = txt_Transformator.Value.ToString().Trim()
                    dr_PostDetails("Automasion") = txt_Otomasion.Value.ToString().Trim()
                    dr_PostDetails("Rele") = txt_Rele.Value.ToString().Trim()
                    dr_PostDetails("Zarfiyat_MVA") = txt_ZMVA.Value.ToString().Trim()
                    dr_PostDetails("Zarfiyat_Count") = txt_ZCount.Value.ToString().Trim()
                    dr_PostDetails("IsMission") = IIf(Chk_IsMission.Checked, 1, 0)

                    If Not BaseDataObject.DataAccess.Insert(dr_PostDetails, True) Then
                        BaseDataObject.DataAccess.RollBack()
                        Return False
                    Else
                        BaseDataObject.DataAccess.Commit()
                    End If
                Else
                    BaseDataObject.DataAccess.RollBack()
                    MessageBoxFa.Show("اشکال در ثبت اطلاعات")
                    Return False
                End If
            Catch
                BaseDataObject.DataAccess.RollBack()
                MessageBoxFa.Show("اشکال در ثبت اطلاعات")
                Return False
            End Try
        End If
        ' Dim row As Integer = DataGridView1.SelectedRows(0).Index
        LoadDataGridView()
        ClearForm()
        'DataGridView1.Rows(row).Cells(0).Selected = True
        Return True
    End Function

    Public Overrides Sub ClearForm()
        txt_Name.Value = ""
        txt_Otomasion.Value = ""
        txt_Rele.Value = ""
        txt_SaleBahrebardari.Value = ""
        txt_SathVoltaj.Value = ""
        txt_Transformator.Value = ""
        txt_ZCount.Value = ""
        txt_ZMVA.Value = ""
        lkb_Tajhiz.SelectedIndex = -1
        lkb_Tip.SelectedIndex = -1
        lkb_Type.SelectedIndex = -1
        Chk_IsMission.Checked = False
        txt_Name.Focus()
    End Sub

    Private Sub Frm_Post_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_PostType' table. You can move, or remove it, as needed.
        Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        Me.Pm_PostmodelTableAdapter.Fill(Me.Ds_Pm.Pm_Postmodel)
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub

    Private Sub Btn_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Report.Click
        Dim rp As New Rp_Post
        rp.SetDataSource(Me.Ds_Pm.Pm_Post.DataSet)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
        Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Pm.Pm_Post.DataSet.Tables("0"))
        frm_rp.ShowDialog()
    End Sub

    Public Overrides Function Edit() As Boolean
        Edit_CurrentIndex = FindSrl(DataGridView1, FindSerialPromtType.Edit, False, True, True)
        If Edit_CurrentIndex = -1 Then
            Return False
        End If

        btn_Edit.Enabled = False
        DataGridView1.Enabled = False
        btn_Delete.Enabled = False
        Btn_Report.Enabled = False

        txt_Code.Value = DataGridView1.CurrentRow.Cells(1).Value
        txt_Name.Value = DataGridView1.CurrentRow.Cells(2).Value
        'lkb_Tajhiz.SelectedValue = DataGridView1.CurrentRow.Cells(3)
        'lkb_Tip.SelectedValue = DataGridView1.CurrentRow.Cells(4)
        txt_SathVoltaj.Value = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        txt_SaleBahrebardari.Value = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        txt_Transformator.Value = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        txt_Otomasion.Value = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        txt_Rele.Value = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        txt_ZMVA.Value = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        txt_ZCount.Value = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        lkb_Tajhiz.SelectedValue = DataGridView1.CurrentRow.Cells(14).Value
        lkb_Tip.SelectedValue = DataGridView1.CurrentRow.Cells(13).Value
        Chk_IsMission.Checked = IIf(DataGridView1.CurrentRow.Cells(15).Value Is DBNull.Value, False, DataGridView1.CurrentRow.Cells(15).Value)
        lkb_Type.SelectedValue = DataGridView1.CurrentRow.Cells(17).Value


    End Function

    Public Overrides Function Edit(ByVal srl_toEdit As Integer) As Boolean
    End Function

   
End Class