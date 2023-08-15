Public Class Frm_Hadese_KhesaratType

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Hadese_KhesaratTypeTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratType)
    End Sub

    Private Sub Frm_Hadese_KhesaratType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_Hadese_KhesaratTypeTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratType)
    End Sub
End Class