Public Class Frm_Template

    Private Sub Frm_Hadese_Device_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_PostTemplateTableAdapter.Fill(Me.Ds_Pm.Pm_PostTemplate)
        Tree_Vw1.Fill(Ds_Pm.Pm_PostTemplate)
        Tree_Vw1.TreeView1.ExpandAll()
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            Dim s As New Frm_Template_add(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False)
            s.ShowDialog()
            Me.Pm_PostTemplateTableAdapter.Fill(Me.Ds_Pm.Pm_PostTemplate)
            Tree_Vw1.Fill(Ds_Pm.Pm_PostTemplate)
            Tree_Vw1.TreeView1.ExpandAll()
        Else
            If Tree_Vw1.TreeView1.Nodes.Count <> 0 Then
                MessageBoxFa.Show("لطفا يک دستگاه را انتخاب کنيد")
                Return
            End If
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("pm_posttemplate")
            dr("Srl_parent") = 0
            dr("Srl_SubmitUser") = Setting.Srl_User
            dr("SubmitDate") = Setting.Now

            dr("name") = "قالب پست"

            Dim i As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            Dim stemp As New VB_Component.TreeNode("قالب پست ها")
            stemp.Srl_Parent = 0
            stemp.Srl = i
            stemp.IsRootNode = True

            Dim s As New Frm_Template_add(stemp, False)
            s.ShowDialog()
            Me.Pm_PostTemplateTableAdapter.Fill(Me.Ds_Pm.Pm_PostTemplate)
            Tree_Vw1.Fill(Ds_Pm.Pm_PostTemplate)
            Tree_Vw1.TreeView1.ExpandAll()
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim Edit_TreeNode As System.Windows.Forms.TreeNode = Tree_Vw1.TreeView1.SelectedNode
        Dim s As New Frm_Template_add(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True)
        s.ShowDialog()
        Me.Pm_PostTemplateTableAdapter.Fill(Me.Ds_Pm.Pm_PostTemplate)
        Tree_Vw1.Fill(Ds_Pm.Pm_PostTemplate)
        Tree_Vw1.TreeView1.ExpandAll()
        Tree_Vw1.TreeView1.SelectedNode = Edit_TreeNode
    End Sub

    Private Sub Del(ByVal Srl As Integer)
        Dim ds As DataSet = BaseDataObject.DataAccess.FillDataSet("select * from pm_postTemplate where srl_parent=" + Srl.ToString())
        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Del(ds.Tables(0).Rows(i)("srl"))
                i = i + 1
            Next
        End If
        BaseDataObject.DataAccess.ExecQuery("delete from pm_postTemplate where srl=" + Srl.ToString())
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If Tree_Vw1.SelectedNode.Nodes.Count > 0 Then
            If (MessageBoxFa.Show("این ریز قالب دارای زیر مجموعه است. با حذف آن تمام زیر مجموعه ها نیز حذف می شوند.آیا مایل به ادامه هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                'Tree_Vw1.DeleteSelectedNode()
                Del(Tree_Vw1.SelectedNode.Srl)
            End If
        ElseIf (MessageBoxFa.Show("آیا مطمئنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            BaseDataObject.DataAccess.ExecQuery("delete from pm_postTemplate where srl=" + Tree_Vw1.SelectedNode.Srl.ToString)
        End If
        Me.Pm_PostTemplateTableAdapter.Fill(Me.Ds_Pm.Pm_PostTemplate)
        Tree_Vw1.Fill(Ds_Pm.Pm_PostTemplate)
        Tree_Vw1.TreeView1.ExpandAll()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tree_Vw1.Clear()
        Try
            Me.Pm_PostTemplateTableAdapter.Fill(Me.Ds_Pm.Pm_PostTemplate)
            If Ds_Pm.Pm_PostTemplate.Rows.Count >= 1 Then
                Tree_Vw1.Fill(Ds_Pm.Pm_PostTemplate)
                Tree_Vw1.TreeView1.ExpandAll()
            End If
        Catch ex As Exception
            MessageBox.Show("خطا در نمايش اطلاعات لطفا با مدير سيستم تماس بگيريد")
        End Try
    End Sub



End Class