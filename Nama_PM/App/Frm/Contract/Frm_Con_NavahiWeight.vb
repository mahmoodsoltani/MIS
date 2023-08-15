Public Class Frm_Con_NavahiWeight




    Private Sub Frm_Con_VahedWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Contract' table. You can move, or remove it, as needed.
        Dim query As String = "insert into pm_con_navahiweight " & _
"select Pm_Con_Contract .srl,Pm_PostType.srl,1 as weight ," + Setting.Srl_User.ToString() + ",'" + DateTime.Now.ToShortDateString() + "' from  Pm_PostType  , Pm_Con_Contract  where " & _
"convert(nvarchar,Pm_PostType.srl)+'_'+convert(nvarchar,Pm_Con_Contract .srl) not in( " & _
"select convert(nvarchar,srl_post_type) +'_'+ convert(nvarchar, srl_contract) from pm_con_navahiweight)"
        BaseDataObject.DataAccess.ExecQuery(query)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        If Not cmb_source.SelectedValue Is Nothing Then
            If cmb_source.SelectedValue > 0 Then
                Me.Pm_Con_NavahiWeightTableAdapter.Fill(Me.Ds_Con.Pm_Con_NavahiWeight, cmb_source.SelectedValue)
            End If
        End If
    End Sub

    Private Sub cmb_source_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_source.SelectedIndexChanged
        If Not cmb_source.SelectedValue Is Nothing Then
            If cmb_source.SelectedValue > 0 Then
                Me.Pm_Con_NavahiWeightTableAdapter.Fill(Me.Ds_Con.Pm_Con_NavahiWeight, cmb_source.SelectedValue)
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
            BaseDataObject.DataAccess.ExecQuery("update pm_con_navahiweight set weight=" + DataGridView1.Rows(row).Cells(4).Value.ToString() + " where srl=" + DataGridView1.Rows(row).Cells(0).Value.ToString())
            Return
        End If
    End Sub
End Class