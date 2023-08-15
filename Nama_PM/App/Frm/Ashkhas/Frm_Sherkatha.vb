Public Class Frm_Sherkatha
    Private Sub Frm_Sherkatha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM Pm_sherkat ")
        If txt_Code.Value = 0 Then
            txt_Code.Value = 1
        End If
        If txt_eshterak.Value < 1 Then
            txt_eshterak.Value = 0
        End If
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        MyBase.DataObject.DataRow("Srl_Acc_Ashkhas_Onvan") = 1
        'MyBase.DataObject.DataRow("Srl_Company") = Setting.CompanyInfo.Srl
        MyBase.DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        MyBase.DataObject.DataRow("SubmitDate") = Setting.Now
        Return MyBase.Save(DoClearForm)
    End Function

    Public Overrides Sub ClearForm()
        MyBase.ClearForm()
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM Pm_sherkat ")
    End Sub

    Public Overrides Sub LoadDataGridView()
        Pm_SherkatTableAdapter.Fill(Ds_Ashkhas.Pm_Sherkat, -1)
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM Pm_sherkat ")
        MyBase.LoadDataGridView()
    End Sub
End Class