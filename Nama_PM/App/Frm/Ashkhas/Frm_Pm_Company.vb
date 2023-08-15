Public Class Frm_Pm_Company
    Public Overrides Sub LoadDataGridView()
        Me.Pm_CompanyTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Company)
    End Sub
    'Private Sub Frm_Pm_Company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: This line of code loads data into the 'Ds_Ashkhas.Pm_Company' table. You can move, or remove it, as needed.
    '    Me.Pm_CompanyTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Company)

    'End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("Company") = txt_Name.Text

        Return MyBase.Save(DoClearForm)
    End Function


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Frm_Pm_Company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Pm_Company' table. You can move, or remove it, as needed.
        Me.Pm_CompanyTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Company)

    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

    End Sub
End Class