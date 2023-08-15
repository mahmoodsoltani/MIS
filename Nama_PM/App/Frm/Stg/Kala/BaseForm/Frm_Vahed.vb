Public Class Frm_VahedV

    Public Overrides Sub LoadDataGridView()
        ' Me.Stg_VahedTableAdapter.Fill(Me.Ds_Kala.Stg_Vahed)
        MyBase.LoadDataGridView()
    End Sub

    Private Sub Frm_VahedV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Stg_VahedTableAdapter.Fill(Me.Ds_Kala.Stg_Vahed)
    End Sub
End Class