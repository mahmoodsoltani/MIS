Public Class Frm_UserAshkhas

    Private Sub Frm_UserAshkhas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Sec_UserTableAdapter.Fill(Me.Ds_Security.sec_User)
        lk_Ashkhas.LoadLookUp(BaseDataObject.DataAccess.GetDataTable("SELECT Srl, Code AS کد, Name+' '+Family AS نام,PersonalCode as [کد پرسنلی] FROM dbo.Pm_Ashkhas"), 1, 2, "انتخاب مشتري", False)
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Close()
    End Sub

    Dim dr As DataRow

    Private Sub btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ok.Click
        If (lk_Ashkhas.Result Is Nothing) Then
            MessageBoxFa.Show("شخص مورد نظر را انتخاب کنید.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If
        dr = VB_Component.BaseDataObject.DataAccess.GetRow("sec_User", ComboBox1.SelectedValue)        
        dr("Srl_Acc_Ashkhas") = lk_Ashkhas.Result("Srl")
        VB_Component.BaseDataObject.DataAccess.Update(dr, 0)
        MessageBoxFa.Show("تغییرات مورد نظر انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class