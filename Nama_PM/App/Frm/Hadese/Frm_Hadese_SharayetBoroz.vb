Public Class Frm_Hadese_SharayetBoroz

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Hadese_SharayetBorozTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_SharayetBoroz)
    End Sub

    Private Sub Frm_Hadese_SharayetBoroz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_Hadese_SharayetBorozTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_SharayetBoroz)
    End Sub
End Class