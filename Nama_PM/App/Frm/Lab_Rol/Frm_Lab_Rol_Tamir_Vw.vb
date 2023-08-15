Public Class Frm_Lab_Rol_Tamir_Vw

    Private Sub Frm_Lab_Rol_Tamir_Vw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_Lab_Rol_TamiratViewTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_TamiratView)
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_Lab_Rol_Tamir(-2)
        s.ShowDialog()
        Me.Pm_Lab_Rol_TamiratViewTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_TamiratView)
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim s As New Frm_Lab_Rol_Tamir(srl)
        s.ShowDialog()
        Me.Pm_Lab_Rol_TamiratViewTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_TamiratView)
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Delete, False)
            If srl = -1 Then
                Return
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then
                BaseDataObject.DataAccess.Delete("Pm_Lab_Rol_Tamirat_GheteMasrafi", " Srl_Pm_Lab_Rol_Tamirat=" + srl.ToString)
                BaseDataObject.DataAccess.Delete("Pm_Lab_Rol_Tamirat", srl)
                If BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                    Me.Pm_Lab_Rol_TamiratViewTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_TamiratView)
                    Return
                End If
            End If
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            Return
        End If
    End Sub
End Class