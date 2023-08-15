Public Class Frm_Pm_Lab_Rol_Tajhizat


   
    Private Sub Frm_Pm_Lab_Rol_Tajhizat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Tajhiz' table. You can move, or remove it, as needed.
        Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
        'Tree_Vw1.TreeView1.ExpandAll()

        Try
            Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
            If Me.Ds_Lab.Pm_Lab_Rol_Tajhiz.Rows.Count < 1 Then

                Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_Tajhiz")
                dr("Srl_Parent") = 0

                dr("Name") = "تجهیزات"
                Dim i As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            End If

            Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
            Tree_Vw1.Fill(Nothing, Ds_Lab.Pm_Lab_Rol_Tajhiz)
            'Tree_Vw1.TreeView1.ExpandAll()
            'Tree_Vw1.Fill(Ds_Hadese.Pm_Hadese_KhesaratDevice)
            'Tree_Vw1.TreeView1.ExpandAll()
            'If Ds_Hadese.Pm_Hadese_KhesaratDevice.Rows.Count >= 1 Then
            'End If
            txtTajhiz.Text = ""
        Catch ex As Exception
            MessageBox.Show("خطا در نمايش اطلاعات لطفا با مدير سيستم تماس بگيريد")
        End Try
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Tajhiz", Tree_Vw1.SelectedNode.Srl)
            ' dr("Name") = txtTajhiz.Value
            txtTajhiz.Text = dr("Name").ToString

        End If

    End Sub
    Private Sub Tree_Vw1_ExpandNode(ByVal tn As VB_Component.TreeNode) Handles Tree_Vw1.ExpandNode
        Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
        Tree_Vw1.Fill(tn, Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
    End Sub
    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
       
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_Tajhiz")
            dr("Srl_Parent") = Tree_Vw1.SelectedNode.Srl
            dr("Name") = txtTajhiz.Value
            BaseDataObject.DataAccess.Insert(dr, False)
            Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
            Tree_Vw1.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
            Tree_Vw1.TreeView1.ExpandAll()
            txtTajhiz.Text = " "
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        'If Tree_Vw1.TreeView1.Nodes.Count <> 0 Then
        '    MessageBoxFa.Show("لطفا يک دستگاه را انتخاب کنيد")
        '    Return
        'End If
        Dim Edit_TreeNode As System.Windows.Forms.TreeNode = Tree_Vw1.TreeView1.SelectedNode
        'Dim editClick As Integer
        'If editClick = 1 Then

        '    Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Tajhiz", Tree_Vw1.SelectedNode.Srl)

        '    dr("Name") = txtTajhiz.Value
        '    BaseDataObject.DataAccess.Update(dr, 0, False)
        'End If
        'If Not Tree_Vw1.SelectedNode Is Nothing Then
        '    editClick = 1

        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Tajhiz", Tree_Vw1.SelectedNode.Srl)

        'txtTajhiz.Text = dr("Name").ToString
        dr("Name") = txtTajhiz.Value
        BaseDataObject.DataAccess.Update(dr, 0, False)
        txtTajhiz.Text = " "
        'End If
        Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
        Tree_Vw1.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
        Tree_Vw1.TreeView1.ExpandAll()

        'TreeFill()
    End Sub

    Private Sub Del(ByVal Srl As Integer)
        
        Dim ds As DataSet = BaseDataObject.DataAccess.FillDataSet("select * from Pm_Lab_Rol_Tajhiz where srl_parent=" + Srl.ToString())
        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Del(ds.Tables(0).Rows(i)("srl"))
            Next
        End If
        BaseDataObject.DataAccess.ExecQuery("delete from Pm_Lab_Rol_Tajhiz where  srl_parent != 0 And srl=" + Srl.ToString())

    End Sub
    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        'If Not Tree_Vw1.SelectedNode Is Nothing Then
        '    Del(Tree_Vw1.SelectedNode.Srl)
        '    ' TreeFill()
        '    Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
        '    Tree_Vw1.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
        '    Tree_Vw1.TreeView1.ExpandAll()

        'End If
        If Tree_Vw1.SelectedNode.Nodes.Count > 0 Then
            If (MessageBoxFa.Show("این گروه کالا دارای زیر مجموعه است. با حذف آن تمام زیر مجموعه ها نیز حذف می شوند.آیا مایل به ادامه هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                Del(Tree_Vw1.SelectedNode.Srl)
            End If
        ElseIf (MessageBoxFa.Show("آیا مطمئنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            BaseDataObject.DataAccess.ExecQuery("delete from Pm_Lab_Rol_Tajhiz where  srl_parent != 0 And srl=" + Tree_Vw1.SelectedNode.Srl.ToString())
            'BaseDataObject.DataAccess.ExecQuery("delete from Pm_DeviceAttachment where  Srl_Pm_Hadese_KhesaratDevice=" + Tree_Vw1.SelectedNode.Srl.ToString())

        End If
        Tree_Vw1.SelectedNode.Remove()
    End Sub

   

    Private Sub Tree_Vw1_SelectedChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tree_Vw1.SelectedChange
        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Tajhiz", Tree_Vw1.SelectedNode.Srl)

        txtTajhiz.Text = dr("Name").ToString
    End Sub
End Class