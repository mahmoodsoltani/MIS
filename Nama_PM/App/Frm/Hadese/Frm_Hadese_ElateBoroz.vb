Public Class Frm_Hadese_ElateBoroz

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Hadese_ElatTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_Elat)
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        Return MyBase.Save(DoClearForm)
    End Function
End Class