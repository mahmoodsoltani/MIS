Public Class Frm_Device
    Private IRTCopy As Boolean = False

    Private Sub Frm_Hadese_Device_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.StatusStrip1.Items.Add("F1 رله-F2 ترانس قدرت-F3 برقگیر-F4 سکسیونر-F5 بریکر-F6 ترانس ولتاژ-F7 ترانس جریان-F8 کابل")

        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        'Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_Post.SelectedValue)
        'Tree_Vw1.LoadTreeView(BaseDataObject.DataAccess, Ds_Hadese.Pm_Hadese_KhesaratDevice, MyBase.TableName)
        'Tree_Vw1.TreeView1.ExpandAll()
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            NewTajhiz(1)
        ElseIf e.KeyCode = Keys.F2 Then
            NewTajhiz(2)
        ElseIf e.KeyCode = Keys.F3 Then
            NewTajhiz(3)
        ElseIf e.KeyCode = Keys.F4 Then
            NewTajhiz(4)
        ElseIf e.KeyCode = Keys.F5 Then
            NewTajhiz(5)
        ElseIf e.KeyCode = Keys.F6 Then
            NewTajhiz(6)
        ElseIf e.KeyCode = Keys.F7 Then
            NewTajhiz(7)
        ElseIf e.KeyCode = Keys.F8 Then
            NewTajhiz(8)
        ElseIf e.KeyCode = Keys.F10 Then
            Rb_Barghgir.Checked = False
            Rb_Breaker.Checked = False
            Rb_Cable.Checked = False
            rb_rele.Checked = False
            Rb_Sexioner.Checked = False
            Rb_TGhodrat.Checked = False
            Rb_TJaryan.Checked = False
            Rb_TVotaje.Checked = False
            NewTajhiz(9)
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim ChangeNode As VB_Component.TreeNode
        Dim Type As Integer = 0
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            If rb_rele.Checked Then
                Type = 1
            ElseIf Rb_TGhodrat.Checked Then
                Type = 2
            ElseIf Rb_Barghgir.Checked Then
                Type = 3
            ElseIf Rb_Sexioner.Checked Then
                Type = 4
            ElseIf Rb_Breaker.Checked Then
                Type = 5
            ElseIf Rb_TVotaje.Checked Then
                Type = 6
            ElseIf Rb_TJaryan.Checked Then
                Type = 7
            ElseIf Rb_Cable.Checked Then
                Type = 8
            End If
            Select Case Type
                Case 1
                    Dim frm As New Frm_Rele(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False, cmb_Post.SelectedValue)
                    ChangeNode = frm.ShowDialog("")
                Case 2
                    Dim frm As New Frm_TranseGhodrat(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False, cmb_Post.SelectedValue)
                    ChangeNode = frm.ShowDialog("")
                Case 3
                    Dim frm As New Frm_BarghGir(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False, cmb_Post.SelectedValue)
                    ChangeNode = frm.ShowDialog("")
                Case 4
                    Dim frm As New Frm_Sexioner(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False, cmb_Post.SelectedValue)
                    ChangeNode = frm.ShowDialog("")
                Case 5
                    Dim frm As New Frm_Breaker(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False, cmb_Post.SelectedValue)
                    ChangeNode = frm.ShowDialog("")
                Case 6
                    Dim frm As New Frm_TranseVoltaj(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False, cmb_Post.SelectedValue, 1)
                    ChangeNode = frm.ShowDialog("")
                Case 7
                    Dim frm As New Frm_TranseVoltaj(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False, cmb_Post.SelectedValue, 0)
                    ChangeNode = frm.ShowDialog("")
                Case 8
                    Dim frm As New Frm_Cable(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False, cmb_Post.SelectedValue)
                    ChangeNode = frm.ShowDialog("")
                Case Else
                    Dim s As New Frm_Device_add(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), False, cmb_Post.SelectedValue)
                    ChangeNode = s.ShowDialog("")
            End Select
            If Not ChangeNode.Text = "" Then
                Tree_Vw1.SelectedNode.Nodes.Add(ChangeNode)
                'Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_Post.SelectedValue)
                'Tree_Vw1.Fill(Ds_Hadese.Pm_Hadese_KhesaratDevice)
                If Not Tree_Vw1.SelectedNode.IsExpanded Then
                    Tree_Vw1.SelectedNode.Expand()
                End If
            End If
        Else
            If Tree_Vw1.TreeView1.Nodes.Count <> 0 Then
                MessageBoxFa.Show("لطفا يک دستگاه را انتخاب کنيد")
                Return
            End If

            'Dim stemp As New VB_Component.TreeNode("دستگاههاي پست")
            'stemp.Srl_Parent = 0
            'stemp.Srl = i
            'stemp.IsRootNode = True

            'Dim s As New Frm_Device_add(stemp, False, cmb_Post.SelectedValue)
            's.ShowDialog()
            'Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_Post.SelectedValue)
            'Tree_Vw1.Fill(Ds_Hadese.Pm_Hadese_KhesaratDevice)
            'Tree_Vw1.TreeView1.ExpandAll()
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim ChangeNode As VB_Component.TreeNode
        If Tree_Vw1.SelectedNode Is Nothing Then
            MessageBoxFa.Show("لطفا یک نود را انتخاب کنید")
            Return
        End If
        Dim Edit_TreeNode As System.Windows.Forms.TreeNode = Tree_Vw1.TreeView1.SelectedNode

        Dim Type As Integer = BaseDataObject.DataAccess.ExecScalar("select isnull(Pm_DescriptableTajhiz,0) from Pm_Hadese_KhesaratDevice  where srl = " + Tree_Vw1.SelectedNode.Srl.ToString())
        Select Case Type
            Case 1
                Dim frm As New Frm_Rele(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True, cmb_Post.SelectedValue)
                ChangeNode = frm.ShowDialog("")
            Case 2
                Dim frm As New Frm_TranseGhodrat(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True, cmb_Post.SelectedValue)
                ChangeNode = frm.ShowDialog("")
            Case 3
                Dim frm As New Frm_BarghGir(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True, cmb_Post.SelectedValue)
                ChangeNode = frm.ShowDialog("")
            Case 4
                Dim frm As New Frm_Sexioner(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True, cmb_Post.SelectedValue)
                ChangeNode = frm.ShowDialog("")
            Case 5
                Dim frm As New Frm_Breaker(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True, cmb_Post.SelectedValue)
                ChangeNode = frm.ShowDialog("")
            Case 6
                Dim frm As New Frm_TranseVoltaj(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True, cmb_Post.SelectedValue, 1)
                ChangeNode = frm.ShowDialog("")
            Case 7
                Dim frm As New Frm_TranseVoltaj(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True, cmb_Post.SelectedValue, 0)
                ChangeNode = frm.ShowDialog("")
            Case 8
                Dim frm As New Frm_Cable(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True, cmb_Post.SelectedValue)
                ChangeNode = frm.ShowDialog("")
            Case Else
                Dim s As New Frm_Device_add(CType(Tree_Vw1.SelectedNode, VB_Component.TreeNode), True, cmb_Post.SelectedValue)
                ChangeNode = s.ShowDialog("")
        End Select

        If ChangeNode.Text <> "" Then
            Tree_Vw1.SelectedNode.Text = ChangeNode.Text
        End If
        If Not Tree_Vw1.SelectedNode.IsExpanded Then
            Tree_Vw1.SelectedNode.Expand()
        End If

        'Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_Post.SelectedValue)
        'Tree_Vw1.Fill(Ds_Hadese.Pm_Hadese_KhesaratDevice)
        'Tree_Vw1.TreeView1.ExpandAll()
        'Tree_Vw1.TreeView1.SelectedNode = Edit_TreeNode
    End Sub

    Private Sub Del(ByVal Srl As Integer)
        Dim ds As DataSet = BaseDataObject.DataAccess.FillDataSet("select * from Pm_Hadese_KhesaratDevice where srl_parent=" + Srl.ToString())
        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Del(ds.Tables(0).Rows(i)("srl"))
            Next
        End If
        BaseDataObject.DataAccess.ExecQuery("delete from Pm_Hadese_KhesaratDevice where  srl_parent != 0 And srl=" + Srl.ToString())
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If Tree_Vw1.SelectedNode Is Nothing Then
            MessageBoxFa.Show("لطفا یک نود را انتخاب نمائید")
            Return
        End If
        If Tree_Vw1.SelectedNode.Nodes.Count > 0 Then
            If (MessageBoxFa.Show("این گروه کالا دارای زیر مجموعه است. با حذف آن تمام زیر مجموعه ها نیز حذف می شوند.آیا مایل به ادامه هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                Del(Tree_Vw1.SelectedNode.Srl)
            End If
        ElseIf (MessageBoxFa.Show("آیا مطمئنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            BaseDataObject.DataAccess.ExecQuery("delete from Pm_Hadese_KhesaratDevice where  srl_parent != 0 And srl=" + Tree_Vw1.SelectedNode.Srl.ToString())
            BaseDataObject.DataAccess.ExecQuery("delete from Pm_DeviceAttachment where  Srl_Pm_Hadese_KhesaratDevice=" + Tree_Vw1.SelectedNode.Srl.ToString())

        End If
        Tree_Vw1.SelectedNode.Remove()
        'Me.Ds_Hadese.Pm_Hadese_KhesaratDevice.Clear()
        'Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_Post.SelectedValue)
        'Tree_Vw1.Fill(Ds_Hadese.Pm_Hadese_KhesaratDevice)
        'Tree_Vw1.TreeView1.ExpandAll()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Post.SelectedIndexChanged
        Tree_Vw1.Clear()
        Try
            Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_Post.SelectedValue)
            If Me.Ds_Hadese.Pm_Hadese_KhesaratDevice.Rows.Count < 1 Then
                Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Hadese_KhesaratDevice")
                dr("Srl_Parent") = 0
                dr("Srl_Pm_Post") = cmb_Post.SelectedValue
                dr("Name") = "دستگاههاي پست"
                Dim i As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            End If

            Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_Post.SelectedValue)

            Tree_Vw1.Fill(Nothing, Ds_Hadese.Pm_Hadese_KhesaratDevice)
            'Tree_Vw1.Fill(Ds_Hadese.Pm_Hadese_KhesaratDevice)
            'Tree_Vw1.TreeView1.ExpandAll()
            'If Ds_Hadese.Pm_Hadese_KhesaratDevice.Rows.Count >= 1 Then
            'End If
            lb_Type.Text = ""
        Catch ex As Exception
            MessageBox.Show("خطا در نمايش اطلاعات لطفا با مدير سيستم تماس بگيريد")
        End Try
    End Sub

    Function GetAddress(ByVal Srl As Integer) As String
        Return BaseDataObject.DataAccess.ExecScalar("select dbo.Fn_TraceTreeName_Down(" + Srl.ToString + ")")
    End Function

    Private Sub Tree_Vw1_SelectedChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tree_Vw1.SelectedChange
        Try
            Dim dr As DataRow
            Dim Type As Integer = BaseDataObject.DataAccess.ExecScalar("select isnull(Pm_DescriptableTajhiz,0) from Pm_Hadese_KhesaratDevice  where srl = " + Tree_Vw1.SelectedNode.Srl.ToString())
            Select Case Type
                Case 1
                    dr = BaseDataObject.DataAccess.GetRow("pm_rele", Tree_Vw1.SelectedNode.Srl)
                    Lbl_DEviceNAme.Text = GetAddress(Tree_Vw1.SelectedNode.Srl)
                    lb_Type.Text = "رله"
                Case 2
                    dr = BaseDataObject.DataAccess.GetRow("pm_teranseGhodrat", Tree_Vw1.SelectedNode.Srl)
                    Lbl_DEviceNAme.Text = GetAddress(Tree_Vw1.SelectedNode.Srl)
                    lb_Type.Text = "ترانس قدرت"
                Case 3
                    dr = BaseDataObject.DataAccess.GetRow("pm_BarghGir", Tree_Vw1.SelectedNode.Srl)
                    Lbl_DEviceNAme.Text = GetAddress(Tree_Vw1.SelectedNode.Srl)
                    lb_Type.Text = "برقگیر"
                Case 4
                    dr = BaseDataObject.DataAccess.GetRow("pm_Sexioner", Tree_Vw1.SelectedNode.Srl)
                    Lbl_DEviceNAme.Text = GetAddress(Tree_Vw1.SelectedNode.Srl)
                    lb_Type.Text = "سکسیونر"
                Case 5
                    dr = BaseDataObject.DataAccess.GetRow("pm_Breaker", Tree_Vw1.SelectedNode.Srl)
                    Lbl_DEviceNAme.Text = GetAddress(Tree_Vw1.SelectedNode.Srl)
                    lb_Type.Text = "بریکر"
                Case 6
                    dr = BaseDataObject.DataAccess.GetRow("Pm_teranseVoltaj", Tree_Vw1.SelectedNode.Srl)
                    Lbl_DEviceNAme.Text = GetAddress(Tree_Vw1.SelectedNode.Srl)
                    lb_Type.Text = "ترانس ولتاژ"
                Case 7
                    dr = BaseDataObject.DataAccess.GetRow("Pm_teranseVoltaj", Tree_Vw1.SelectedNode.Srl)
                    Lbl_DEviceNAme.Text = GetAddress(Tree_Vw1.SelectedNode.Srl)
                    lb_Type.Text = "ترانس جریان"
                Case 8
                    dr = BaseDataObject.DataAccess.GetRow("Pm_Cable", Tree_Vw1.SelectedNode.Srl)
                    Lbl_DEviceNAme.Text = GetAddress(Tree_Vw1.SelectedNode.Srl)
                    lb_Type.Text = "کابل و سرکابل"
                Case Else
                    dr = BaseDataObject.DataAccess.GetRow("Pm_Hadese_KhesaratDevice", Tree_Vw1.SelectedNode.Srl)
                    Lbl_DEviceNAme.Text = GetAddress(Tree_Vw1.SelectedNode.Srl)
                    lb_Type.Text = "تجهیزات"
            End Select

            txt_DeviceName.Text = dr("Name").ToString
            If dr("Srl_Pm_Device_Sazande").ToString = "" Then
                txt_Model.Text = "تعريف نشده"
            Else
                txt_Model.Text = dr("Model")
            End If

            If dr("Srl_Pm_Device_Sazande").ToString = "" Then
                txt_Sazande.Text = "تعريف نشده"
            Else
                txt_Sazande.Text = BaseDataObject.DataAccess.ExecScalar("select text from Pm_Device_Sazande where srl=" + dr("Srl_Pm_Device_Sazande").ToString).ToString
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btn_pishnahad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pishnahad.Click
        If Tree_Vw1.SelectedNode Is Nothing Then
            If MessageBoxFa.Show("دستگاهی انتخاب نشده است آیا می خواهید برای پست پیشنهاد ثبت نمائید؟", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim s As New Frm_Post_Pishnahad(cmb_Post.SelectedValue, -1)
                s.ShowDialog()
            End If
        Else
            Dim s As New Frm_Post_Pishnahad(cmb_Post.SelectedValue, Tree_Vw1.SelectedNode.Srl)
            s.ShowDialog()
        End If
    End Sub

    Private Sub Btn_WorkForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_WorkForm.Click
        Dim s As New Frm_WorkFormVw(cmb_Post.SelectedValue)
        s.ShowDialog()
    End Sub

    Private Sub Btn_EibForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EibForm.Click
        Dim s As New Frm_EibFormVw(cmb_Post.SelectedValue)
        s.ShowDialog()
    End Sub

    Private Sub اضافهکردنبرنامهPMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافهکردنبرنامهPMToolStripMenuItem.Click
        If Tree_Vw1.SelectedNode Is Nothing Then
            Return
        End If
        Dim s As New Frm_PmWithDevice(cmb_Post.SelectedValue, Tree_Vw1.SelectedNode.Srl)
        s.ShowDialog()
    End Sub

    Private Sub کپیToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles کپیToolStripMenuItem.Click
        If Tree_Vw1.SelectedNode Is Nothing Then
            Return
        Else
            Clipboard.SetText(Tree_Vw1.SelectedNode.Srl)
            IRTCopy = True
        End If
    End Sub

    Private Sub CopyAndPase(ByVal Copysrl As Integer, ByVal PasetSrl As Integer, ByRef newnode As VB_Component.TreeNode)
        Dim tempnode As New VB_Component.TreeNode("")
        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Hadese_KhesaratDevice", Copysrl)
        dr.Table.Columns(0).AutoIncrement = True
        Dim primaryKey(0) As DataColumn
        primaryKey(0) = dr.Table.Columns(0)
        dr.Table.PrimaryKey = primaryKey
        dr("srl_Parent") = PasetSrl
        dr("Srl_Pm_Post") = cmb_Post.SelectedValue
        dr("CopyType") = 1

        Dim paste As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
        tempnode.Srl = paste
        tempnode.Srl_Parent = PasetSrl
        tempnode.Text = dr("name").ToString()
        If tempnode.Text = "" Then
            tempnode.Text = BaseDataObject.DataAccess.ExecScalar("select name from pm_tajhizname where srl=" + dr("srl_Pm_tajhizname").ToString())
        End If
        If newnode Is Nothing Then
            newnode = New VB_Component.TreeNode(dr("name").ToString())
            newnode = tempnode
        Else
            newnode.Nodes.Add(tempnode)
        End If

        Dim ds As DataSet = BaseDataObject.DataAccess.FillDataSet("select * from Pm_Hadese_KhesaratDevice where (CopyType!=1 or CopyType is null)and srl_parent=" + Copysrl.ToString())
        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                CopyAndPase(ds.Tables(0).Rows(i)(0), paste, tempnode)
            Next
        End If
    End Sub

    Private Sub چسباندنToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles چسباندنToolStripMenuItem.Click
        Try
            Dim NewNode As VB_Component.TreeNode

            If Not Clipboard.GetText() Is Nothing And Not Tree_Vw1.SelectedNode Is Nothing And IRTCopy Then
                CopyAndPase(Convert.ToInt32(Clipboard.GetText()), Tree_Vw1.SelectedNode.Srl, NewNode)
                BaseDataObject.DataAccess.ExecQuery("update Pm_Hadese_KhesaratDevice set CopyType=0")
                Tree_Vw1.SelectedNode.Nodes.Add(NewNode)
            Else
                If Clipboard.GetText Is Nothing Or Clipboard.GetText = "" Then
                    MessageBoxFa.Show("لطفا قسمت مورد نظر برای کپی را مشخص نمائید")
                End If
            End If
            'Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_Post.SelectedValue)

            'Tree_Vw1.Fill(Ds_Hadese.Pm_Hadese_KhesaratDevice)

0:          'Tree_Vw1.TreeView1.ExpandAll()
        Catch
            MessageBoxFa.Show("لطفا قسمت مورد نظر برای کپی را مشخص نمائید")
        End Try
    End Sub

    Private Sub حذفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفToolStripMenuItem.Click
        btn_Delete_Click(Nothing, Nothing)
    End Sub

    Private Sub تجهیزاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تجهیزاتToolStripMenuItem.Click
        Rb_Barghgir.Checked = False
        Rb_Breaker.Checked = False
        Rb_Cable.Checked = False
        rb_rele.Checked = False
        Rb_Sexioner.Checked = False
        Rb_TGhodrat.Checked = False
        Rb_TJaryan.Checked = False
        Rb_TVotaje.Checked = False
        btn_New_Click(Nothing, Nothing)
    End Sub

    Private Sub NewTajhiz(ByVal type As Integer)
        If Tree_Vw1.SelectedNode Is Nothing Then
            MessageBoxFa.Show("لطفا یک نود را انتخاب نمائید")
            Return
        End If

        If type = 1 Then
            rb_rele.Checked = True
        ElseIf type = 2 Then
            Rb_TGhodrat.Checked = True
        ElseIf type = 3 Then
            Rb_Barghgir.Checked = True
        ElseIf type = 4 Then
            Rb_Sexioner.Checked = True
        ElseIf type = 5 Then
            Rb_Breaker.Checked = True
        ElseIf type = 6 Then
            Rb_TVotaje.Checked = True
        ElseIf type = 7 Then
            Rb_TJaryan.Checked = True
        ElseIf type = 8 Then
            Rb_Cable.Checked = True
        End If

        btn_New_Click(Nothing, Nothing)
        If type = 1 Then
            rb_rele.Checked = False
        ElseIf type = 2 Then
            Rb_TGhodrat.Checked = False
        ElseIf type = 3 Then
            Rb_Barghgir.Checked = False
        ElseIf type = 4 Then
            Rb_Sexioner.Checked = False
        ElseIf type = 5 Then
            Rb_Breaker.Checked = False
        ElseIf type = 6 Then
            Rb_TVotaje.Checked = False
        ElseIf type = 7 Then
            Rb_TJaryan.Checked = False
        ElseIf type = 8 Then
            Rb_Cable.Checked = False
        End If
    End Sub

    Private Sub رلهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles رلهToolStripMenuItem.Click
        NewTajhiz(1)
    End Sub

    Private Sub ترانسقدرتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ترانسقدرتToolStripMenuItem.Click
        NewTajhiz(2)
    End Sub

    Private Sub برقگیرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles برقگیرToolStripMenuItem.Click
        NewTajhiz(3)
    End Sub

    Private Sub بریکرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بریکرToolStripMenuItem.Click
        NewTajhiz(4)
    End Sub

    Private Sub بریکرToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بریکرToolStripMenuItem1.Click
        NewTajhiz(5)
    End Sub

    Private Sub ترانسولتاژToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ترانسولتاژToolStripMenuItem.Click
        NewTajhiz(6)
    End Sub

    Private Sub ترانسجریانToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ترانسجریانToolStripMenuItem.Click
        NewTajhiz(7)
    End Sub

    Private Sub کابلوسرکابلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles کابلوسرکابلToolStripMenuItem.Click
        NewTajhiz(8)
    End Sub

    Private Sub Tree_Vw1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tree_Vw1.KeyDown
        If e.KeyCode = Keys.C And e.Modifiers = Keys.Control Then
            کپیToolStripMenuItem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ویرایشToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ویرایشToolStripMenuItem.Click
        btn_Edit_Click(Nothing, Nothing)
    End Sub

    Private Sub Tree_Vw1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tree_Vw1.Click

    End Sub

    Private Sub Rb_Cable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_TVotaje.CheckedChanged, Rb_TJaryan.CheckedChanged, Rb_TGhodrat.CheckedChanged, Rb_Sexioner.CheckedChanged, rb_rele.CheckedChanged, Rb_Cable.CheckedChanged, Rb_Breaker.CheckedChanged, Rb_Barghgir.CheckedChanged

    End Sub

    Private Sub Tree_Vw1_ExpandNode(ByVal tn As VB_Component.TreeNode) Handles Tree_Vw1.ExpandNode
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_Post.SelectedValue)
        Tree_Vw1.Fill(tn, Me.Ds_Hadese.Pm_Hadese_KhesaratDevice)
    End Sub

    Private Sub اضافهکردنفایلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافهکردنفایلToolStripMenuItem.Click
        If Tree_Vw1.SelectedNode Is Nothing Then
            MessageBoxFa.Show("لطفا یک دستگاه را انتخاب نمائید")
            Return
        End If
        Dim s As New Frm_Attachment(Tree_Vw1.SelectedNode.Srl)
        s.ShowDialog()
    End Sub

    Private Sub Tree_Vw1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tree_Vw1.Load

    End Sub
End Class

