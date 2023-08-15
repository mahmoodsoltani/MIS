Public Class Frm_ShowWorkForm
    Public Sub New(ByVal Srl_Ashkhas As String, ByVal Tarikh As String)


        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        TimeCard_WorkFormTableAdapter.Fill(Ds_Rp.TimeCard_WorkForm, Srl_Ashkhas, Tarikh)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Frm_ShowWorkForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class