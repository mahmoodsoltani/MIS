Public Class Frm_Con_GroupWeight




    Private Sub Frm_Con_VahedWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)

        Dim query As String = "insert into pm_con_groupweight " & _
     "select Pm_Group.srl,Pm_Con_Contract .srl,1 as weight," + Setting.Srl_User.ToString() + ",'" + DateTime.Now.ToString() + "' from  Pm_Group , Pm_Con_Contract  where " & _
     "convert(nvarchar,Pm_Group.srl)+'_'+convert(nvarchar,Pm_Con_Contract .srl) not in( " & _
     "select convert(nvarchar,srl_group) +'_'+ convert(nvarchar, srl_contract) from pm_con_groupweight" & _
    " ) and Pm_Con_Contract.srl=" + cmb_contract.SelectedValue.ToString() + " and srl_pm_vahed =" + cmb_vahed.SelectedValue.ToString()
        BaseDataObject.DataAccess.ExecQuery(query)

        If Not cmb_contract.SelectedValue Is Nothing And Not cmb_vahed.SelectedValue Is Nothing Then
            If cmb_contract.SelectedValue > 0 And cmb_vahed.SelectedValue > 0 Then
                Me.Pm_Con_GroupWeightTableAdapter.Fill(Me.Ds_Con.Pm_Con_GroupWeight, -1, cmb_contract.SelectedValue, cmb_vahed.SelectedValue)
            End If
        End If
    End Sub

    Private Sub cmb_source_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_contract.SelectedIndexChanged, cmb_vahed.SelectedIndexChanged
        If Not cmb_contract.SelectedValue Is Nothing And Not cmb_vahed.SelectedValue Is Nothing Then
            If cmb_contract.SelectedValue > 0 And cmb_vahed.SelectedValue > 0 Then
                Dim query As String = "insert into pm_con_groupweight " & _
                        "select Pm_Group.srl,Pm_Con_Contract .srl,1 as weight," + Setting.Srl_User.ToString() + ",'" + DateTime.Now.ToString() + "' from  Pm_Group , Pm_Con_Contract  where " & _
                        "convert(nvarchar,Pm_Group.srl)+'_'+convert(nvarchar,Pm_Con_Contract .srl) not in( " & _
                        "select convert(nvarchar,srl_group) +'_'+ convert(nvarchar, srl_contract) from pm_con_groupweight" & _
                       " ) and Pm_Con_Contract.srl=" + cmb_contract.SelectedValue.ToString() + " and srl_pm_vahed =" + cmb_vahed.SelectedValue.ToString()
                BaseDataObject.DataAccess.ExecQuery(query)
                Me.Pm_Con_GroupWeightTableAdapter.Fill(Me.Ds_Con.Pm_Con_GroupWeight, -1, cmb_contract.SelectedValue, cmb_vahed.SelectedValue)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellChange(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim row As Integer
        Dim col As Integer
        row = e.RowIndex
        col = e.ColumnIndex
        If col = 4 Then
            BaseDataObject.DataAccess.ExecQuery("update pm_con_Groupweight set weight=" + DataGridView1.Rows(row).Cells(4).Value.ToString() + " where srl=" + DataGridView1.Rows(row).Cells(0).Value.ToString())
            Return
        End If
    End Sub
End Class