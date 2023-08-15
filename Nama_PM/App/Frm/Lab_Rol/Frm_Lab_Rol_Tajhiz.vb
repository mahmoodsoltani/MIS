Public Class Frm_Lab_Rol_Tajhiz

    Private Sub Frm_Lab_Rol_Tajhiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Tajhiz' table. You can move, or remove it, as needed.
        Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
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
            Tree_Vw1.TreeView1.ExpandAll()
            'Tree_Vw1.Fill(Ds_Hadese.Pm_Hadese_KhesaratDevice)
            'Tree_Vw1.TreeView1.ExpandAll()
            'If Ds_Hadese.Pm_Hadese_KhesaratDevice.Rows.Count >= 1 Then
            'End If
            txtName.Text = ""
        Catch ex As Exception
            MessageBox.Show("خطا در نمايش اطلاعات لطفا با مدير سيستم تماس بگيريد")
        End Try
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_Tajhiz")
            dr("Srl_Parent") = Tree_Vw1.SelectedNode.Srl
            dr("Name") = txtName.Value
            BaseDataObject.DataAccess.Insert(dr, False)
            Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
            Tree_Vw1.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
            Tree_Vw1.TreeView1.ExpandAll()
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Tajhiz", Tree_Vw1.SelectedNode.Srl)
            dr("Name") = txtName.Value

            BaseDataObject.DataAccess.Update(dr, 0, False)
        End If
        Me.Pm_Lab_Rol_TajhizTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
        Tree_Vw1.Fill(Me.Ds_Lab.Pm_Lab_Rol_Tajhiz)
        Tree_Vw1.TreeView1.ExpandAll()
        'TreeFill()
    End Sub

    Private Sub Del(ByVal Srl As Integer)
        Dim ds As DataSet = BaseDataObject.DataAccess.FillDataSet("SELECT * FROM Pm_Lab_Rol_TAjhiz where srl_Parent=" + Srl.ToString)
        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Del(ds.Tables(0).Rows(i)("Srl"))

            Next
        End If
        BaseDataObject.DataAccess.ExecQuery("DELETE FROM Pm_Lab_Rol_Tajhiz WHERE Srl_Parent !=0 AND Srl+" + Srl.ToString)
    End Sub
    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            Del(Tree_Vw1.SelectedNode.Srl)
            ' TreeFill()
        End If
    End Sub
End Class