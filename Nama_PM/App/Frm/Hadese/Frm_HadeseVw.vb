Public Class Frm_HadeseVw

    Private Sub Frm_HadeseVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Hadese.Pm_Hadese' table. You can move, or remove it, as needed.
        Me.Pm_HadeseTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese)
        Me.Pm_HadeseTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese)
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_Hadese(-2)
        s.ShowDialog()
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim s As New Frm_Hadese(srl)
        s.ShowDialog()
        Me.Pm_HadeseTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese)
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
            If srl = -1 Then
                Return
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then
                BaseDataObject.DataAccess.Delete("Pm_Hadese_Pishnahad", " Srl_Pm_Hadese=" + srl.ToString)
                BaseDataObject.DataAccess.Delete("Pm_Hadese_Khesarat", " Srl_Pm_Hadese=" + srl.ToString)
                BaseDataObject.DataAccess.Delete("Pm_Hadese", srl)
                If BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                    Me.Pm_HadeseTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese)
                    Return
                End If
            End If
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            Return
        End If
    End Sub
End Class