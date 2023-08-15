Public Class Frm_Lab_Rol_Mahal

    Private Sub Frm_Lab_Rol_Mahal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Mahal' table. You can move, or remove it, as needed.
        Me.Pm_Lab_Rol_MahalTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
        'Tree_Vw1.TreeView1.ExpandAll()

        'Try
        Me.Pm_Lab_Rol_MahalTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
        If Me.Ds_Lab.Pm_Lab_Rol_Mahal.Rows.Count < 1 Then

            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_Mahal")
            dr("Srl_Parent") = 0

            dr("Name") = "..."
            Dim i As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
        End If

        Me.Pm_Lab_Rol_MahalTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
        Tree_Vw1.Fill(Nothing, Ds_Lab.Pm_Lab_Rol_Mahal)
        'Tree_Vw1.TreeView1.ExpandAll()
        'Tree_Vw1.Fill(Ds_Hadese.Pm_Hadese_KhesaratDevice)
        'Tree_Vw1.TreeView1.ExpandAll()
        'If Ds_Hadese.Pm_Hadese_KhesaratDevice.Rows.Count >= 1 Then
        'End If

        'Catch ex As Exception
        '    MessageBox.Show("خطا در نمايش اطلاعات لطفا با مدير سيستم تماس بگيريد")
        'End Try
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Mahal", Tree_Vw1.SelectedNode.Srl)
            ' dr("Name") = txtTajhiz.Value
            txtMahal.Text = dr("Name").ToString

        End If

    End Sub
    Private Sub Tree_Vw1_ExpandNode(ByVal tn As VB_Component.TreeNode) Handles Tree_Vw1.ExpandNode
        Me.Pm_Lab_Rol_MahalTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
        Tree_Vw1.Fill(tn, Me.Ds_Lab.Pm_Lab_Rol_Mahal)
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_Mahal")
            dr("Srl_Parent") = Tree_Vw1.SelectedNode.Srl
            dr("Name") = txtMahal.Value
            BaseDataObject.DataAccess.Insert(dr, False)
            Me.Pm_Lab_Rol_MahalTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
            Tree_Vw1.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
            Tree_Vw1.TreeView1.ExpandAll()
            txtMahal.Text = " "
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim Edit_TreeNode As System.Windows.Forms.TreeNode = Tree_Vw1.TreeView1.SelectedNode

        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Mahal", Tree_Vw1.SelectedNode.Srl)


        dr("Name") = txtMahal.Value
        BaseDataObject.DataAccess.Update(dr, 0, False)
        txtMahal.Text = " "
        'End If
        Me.Pm_Lab_Rol_MahalTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
        Tree_Vw1.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
        Tree_Vw1.TreeView1.ExpandAll()
    End Sub
    Private Sub Del(ByVal Srl As Integer)

        Dim ds As DataSet = BaseDataObject.DataAccess.FillDataSet("select * from Pm_Lab_Rol_Mahal where srl_parent=" + Srl.ToString())
        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Del(ds.Tables(0).Rows(i)("srl"))
            Next
        End If
        BaseDataObject.DataAccess.ExecQuery("delete from Pm_Lab_Rol_Mahal where  srl_parent != 0 And srl=" + Srl.ToString())

    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If Tree_Vw1.SelectedNode.Nodes.Count > 0 Then
            If (MessageBoxFa.Show("این گروه کالا دارای زیر مجموعه است. با حذف آن تمام زیر مجموعه ها نیز حذف می شوند.آیا مایل به ادامه هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                Del(Tree_Vw1.SelectedNode.Srl)
            End If
        ElseIf (MessageBoxFa.Show("آیا مطمئنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            BaseDataObject.DataAccess.ExecQuery("delete from Pm_Lab_Rol_Mahal where  srl_parent != 0 And srl=" + Tree_Vw1.SelectedNode.Srl.ToString())
            'BaseDataObject.DataAccess.ExecQuery("delete from Pm_DeviceAttachment where  Srl_Pm_Hadese_KhesaratDevice=" + Tree_Vw1.SelectedNode.Srl.ToString())

        End If
        Tree_Vw1.SelectedNode.Remove()
    End Sub

    Private Sub Tree_Vw1_SelectedChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tree_Vw1.SelectedChange
        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Mahal", Tree_Vw1.SelectedNode.Srl)

        txtMahal.Text = dr("Name").ToString
    End Sub
End Class