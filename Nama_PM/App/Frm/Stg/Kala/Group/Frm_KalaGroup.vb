Public Class Frm_KalaGroup

    Private Sub Frm_KalaGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.StatusStrip1.Items.Add("F2 جدید")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("F3 جستجو")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("F4 وبرايش")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("Del حذف")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("Ctrl انتخاب جدول")
        Dim dt As DataTable = PublicFunction.GetKalaGroup
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            Tree_Vw1.LoadTreeView(BaseDataObject.DataAccess, PublicFunction.GetKalaGroup, MyBase.TableName)
            Tree_Vw1.TreeView1.ExpandAll()
        End If
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            Dim s As New Frm_KalaGroupAdd(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False)
            s.ShowDialog()
            Tree_Vw1.Fill(PublicFunction.GetKalaGroup)
            Tree_Vw1.TreeView1.ExpandAll()
        Else
            MessageBoxFa.Show("لطفا یک گروه کالا را انتخاب کنید")
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim Edit_TreeNode As System.Windows.Forms.TreeNode = Tree_Vw1.TreeView1.SelectedNode
        Dim s As New Frm_KalaGroupAdd(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True)
        s.ShowDialog()
        Tree_Vw1.Fill(PublicFunction.GetKalaGroup)
        Tree_Vw1.TreeView1.ExpandAll()
        Tree_Vw1.TreeView1.SelectedNode = Edit_TreeNode
    End Sub

    Private Sub Del(ByVal Srl As Integer)
        Dim ds As DataSet = BaseDataObject.DataAccess.FillDataSet("select * from Stg_kalagroup where srl_parent=" + Srl.ToString())
        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Del(ds.Tables(0).Rows(i)("srl"))
                i = i + 1
            Next
        End If
        BaseDataObject.DataAccess.ExecQuery("delete from Stg_kalagroup where srl=" + Srl.ToString())
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If Tree_Vw1.SelectedNode.Nodes.Count > 0 Then
            If (MessageBoxFa.Show("این گروه کالا دارای زیر مجموعه است. با حذف آن تمام زیر مجموعه ها نیز حذف می شوند.آیا مایل به ادامه هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                'Tree_Vw1.DeleteSelectedNode()
                Del(Tree_Vw1.SelectedNode.Srl)
            End If
        ElseIf (MessageBoxFa.Show("آیا مطمئنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            BaseDataObject.DataAccess.ExecQuery("delete from Stg_kalagroup where srl=" + Tree_Vw1.SelectedNode.Srl.ToString)
        End If
        Tree_Vw1.Fill(PublicFunction.GetKalaGroup)
        Tree_Vw1.TreeView1.ExpandAll()
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            btn_New_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
        ElseIf e.KeyCode = Keys.F4 Then
            Btn_Edit_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Delete Then
            If Not Tree_Vw1.SelectedNode Is Nothing Then
                btn_Delete_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.ControlKey Then
            Tree_Vw1.Focus()
        End If
    End Sub

End Class