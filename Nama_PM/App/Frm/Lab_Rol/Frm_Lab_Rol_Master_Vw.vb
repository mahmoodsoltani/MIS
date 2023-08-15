Public Class Frm_Lab_Rol_Master_Vw

    Private Sub Frm_Lab_Rol_Master_Vw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_Lab_Rol_Master_VwTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Master_Vw)

    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_Lab_Rol_Master(-2)
        s.ShowDialog()
        Me.Pm_Lab_Rol_Master_VwTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Master_Vw)
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Frm_Lab_Rol_Master.share = 5
        Dim s As New Frm_Lab_Rol_Master(srl)
        s.ShowDialog()
        
        Me.Pm_Lab_Rol_Master_VwTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Master_Vw)
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Delete, False)
            If srl = -1 Then
                Return
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then
                BaseDataObject.DataAccess.Delete("Pm_Lab_Rol_SharheKar", " Srl_Master=" + srl.ToString)
                BaseDataObject.DataAccess.Delete("Pm_Lab_Rol_Master", srl)
                If BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                    Me.Pm_Lab_Rol_Master_VwTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Master_Vw)
                    Return
                End If
            End If
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            Return
        End If
    End Sub
End Class