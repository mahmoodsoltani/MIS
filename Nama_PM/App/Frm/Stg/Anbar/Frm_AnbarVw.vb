Public Class Frm_AnbarVw

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_Anbar(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False)
        s.ShowDialog()
        Tree_Vw1.Fill(PublicFunction.GetAnbar)
        Tree_Vw1.TreeView1.ExpandAll()
    End Sub

    Private Sub Frm_AnbarVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tree_Vw1.LoadTreeView(BaseDataObject.DataAccess, PublicFunction.GetAnbar, MyBase.TableName)
        Tree_Vw1.TreeView1.ExpandAll()
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim s As New Frm_Anbar(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True)
        s.ShowDialog()
        Tree_Vw1.Fill(PublicFunction.GetAnbar)
        Tree_Vw1.TreeView1.ExpandAll()
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Dim CanEdit As Boolean = BaseDataObject.DataAccess.ExecScalar("select CanEdit from Stg_Anbar where srl=" + Tree_Vw1.SelectedNode.Srl.ToString)
        If CanEdit Then
            MessageBoxFa.Show("این انبار را نمیتوانید حذف کنید")
        Else
            Tree_Vw1.DeleteSelectedNode()
        End If

    End Sub

End Class