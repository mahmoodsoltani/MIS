Public Class Frm_Con_VahedWeight


 
   
    Private Sub Frm_Con_VahedWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Contract' table. You can move, or remove it, as needed.
        Dim query As String = "insert into pm_con_vahedweight " & _
                      "select Pm_Vahed.srl,Pm_Con_Contract .srl,1 as weight from  pm_vahed , Pm_Con_Contract  where " & _
                      "convert(nvarchar,Pm_Vahed.srl)+'_'+convert(nvarchar,Pm_Con_Contract .srl) not in( " & _
                      "select convert(nvarchar,srl_vahed) +'_'+ convert(nvarchar, srl_contract) from pm_con_vahedweight)"

        BaseDataObject.DataAccess.ExecQuery(query)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Contract' table. You can move, or remove it, as needed.
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        If Not cmb_source.SelectedValue Is Nothing Then
            If cmb_source.SelectedValue > 0 Then

                Me.Pm_con_vahedWeightTableAdapter.Fill(Me.Ds_Con.Pm_con_vahedWeight, -1, cmb_source.SelectedValue)
            End If
        End If
    End Sub

    Private Sub cmb_source_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_source.SelectedIndexChanged
        If Not cmb_source.SelectedValue Is Nothing Then
            If cmb_source.SelectedValue > 0 Then

                Me.Pm_con_vahedWeightTableAdapter.Fill(Me.Ds_Con.Pm_con_vahedWeight, -1, cmb_source.SelectedValue)
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
            BaseDataObject.DataAccess.ExecQuery("update pm_con_vahedweight set weight=" + DataGridView1.Rows(row).Cells(4).Value.ToString() + " where srl=" + DataGridView1.Rows(row).Cells(0).Value.ToString())
            Return
        End If
    End Sub
End Class