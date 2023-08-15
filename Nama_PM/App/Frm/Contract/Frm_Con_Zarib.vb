
Public Class Frm_Con_Zarib

    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_con_ContratZarib' table. You can move, or remove it, as needed.
        Me.Pm_con_ContratZaribTableAdapter.Fill(Me.Ds_Con.Pm_con_ContratZarib)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_ContratcZarib' table. You can move, or remove it, as needed.
        Me.Pm_con_ContratZaribTableAdapter.Fill(Me.Ds_Con.Pm_con_ContratZarib)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_ContractZarib' table. You can move, or remove it, as needed.
        Me.Pm_Con_Contract1TableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract1)
    End Sub
    Public Overrides Sub LoadDataGridView()
        Me.Pm_con_ContratZaribTableAdapter.Fill(Me.Ds_Con.Pm_con_ContratZarib)

    End Sub

End Class