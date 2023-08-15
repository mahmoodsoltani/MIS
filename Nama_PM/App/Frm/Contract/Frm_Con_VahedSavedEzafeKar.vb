Public Class Frm_Con_VahedSavedEzafeKar




    Private Sub Frm_Con_VahedWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String = "insert into pm_con_saveezafekar " & _
                      "select Pm_Vahed.srl,0 as percentage,Pm_con_Contract.srl,null,null  from  pm_vahed , Pm_Con_Contract  where " & _
                      "convert(nvarchar,Pm_Vahed.srl)+'_'+convert(nvarchar,Pm_Con_Contract .srl) not in( " & _
                      "select convert(nvarchar,srl_vahed) +'_'+ convert(nvarchar, srl_contract) from pm_con_saveezafekar)"

        BaseDataObject.DataAccess.ExecQuery(query)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        If Not cmb_source.SelectedValue Is Nothing Then
            If cmb_source.SelectedValue > 0 Then
                Me.Pm_Con_SaveEzafekarTableAdapter.Fill(Me.Ds_Con.Pm_Con_SaveEzafekar, cmb_source.SelectedValue)
            End If
        End If
    End Sub

    Private Sub cmb_source_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_source.SelectedIndexChanged
        If Not cmb_source.SelectedValue Is Nothing Then
            If cmb_source.SelectedValue > 0 Then

                Me.Pm_Con_SaveEzafekarTableAdapter.Fill(Me.Ds_Con.Pm_Con_SaveEzafekar, cmb_source.SelectedValue)

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
        If col = 2 Then
            BaseDataObject.DataAccess.ExecQuery("update pm_con_saveezafekar set percentage=" + DataGridView1.Rows(row).Cells(2).Value.ToString() + " where srl=" + DataGridView1.Rows(row).Cells(0).Value.ToString())
            Return
        End If
    End Sub
End Class