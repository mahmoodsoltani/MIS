Public Class Frm_Rp_KholaseWorkForm

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim f As New Frm_Wait
        Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)
        t.Start()

        Dim rp As New Rp_KholaseWorkForm

        rp.SetDataSource(DirectCast(DataGridView1.DataSource, DataTable).DefaultView)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
        Dim frm_rp As New Frm_RpVw(rp, DirectCast(DataGridView1.DataSource, DataTable))
        If t.IsAlive Then
            t.Abort()
        End If

        frm_rp.ShowDialog()
    End Sub


    Public Sub New(ByVal src As Ds_Rp.Rp_KholaseWorkFormDataTable)
        InitializeComponent()
        DataGridView1.DataSource = src
    End Sub
End Class