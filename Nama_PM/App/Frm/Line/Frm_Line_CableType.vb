Public Class Frm_Line_CableType


    Public Overrides Sub LoadDataGridView()
        Me.Pm_Line_CableTypeTableAdapter.Fill(Me._Ds_Line_.Pm_Line_CableType)

        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_Vahed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Ds_Line_.Pm_Line_CableType' table. You can move, or remove it, as needed.
        Me.Pm_Line_CableTypeTableAdapter.Fill(Me._Ds_Line_.Pm_Line_CableType)
        'TODO: This line of code loads data into the '_Ds_Line_.Pm_Line_DakalCode' table. You can move, or remove it, as needed.
    End Sub

End Class