Public Class Frm_SatheVoltage
    Public Overrides Sub LoadDataGridView()
        Me.Pm_SathevoltageTableAdapter.Fill(Me.Ds_Pm.Pm_Sathevoltage)
        Txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        Me.Pm_SathevoltageTableAdapter.Fill(Me.Ds_Pm.Pm_Sathevoltage)
        MyBase.LoadDataGridView()
    End Sub
    Private Sub Frm_SatheVoltage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Sathevoltage' table. You can move, or remove it, as needed.
        Me.Pm_SathevoltageTableAdapter.Fill(Me.Ds_Pm.Pm_Sathevoltage)
        Txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
       
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
   
    End Sub
End Class