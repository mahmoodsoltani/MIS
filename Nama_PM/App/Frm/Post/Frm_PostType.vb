Public Class Frm_Posttype

    Public Overrides Sub LoadDataGridView()
        Me.Pm_PostTypeTableAdapter1.Fill(Me.Ds_Pm1.Pm_PostType)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        Me.Pm_PostTypeTableAdapter1.Fill(Me.Ds_Pm1.Pm_PostType)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_PostTip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_PostType' table. You can move, or remove it, as needed.
        ' Me.Pm_PostTypeTableAdapter1.Fill(Me.Ds_Pm1.Pm_PostType)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_PostType' table. You can move, or remove it, as needed.
        ' Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub
End Class