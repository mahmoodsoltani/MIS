Public Class Frm_DeviceSelectWithPost
    Dim srl_Post As Integer = -1
    Public SelectedDevice As VB_Component.TreeNode
    Sub New()

        InitializeComponent()
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Not Tree_Vw1.SelectedNode Is Nothing Then
                btn_New_Click(Nothing, Nothing)
            End If
        End If
        MyBase.OnKeyDown(e)
    End Sub
    Private Sub Tree_Vw1_ExpandNode(ByVal tn As VB_Component.TreeNode) Handles Tree_Vw1.ExpandNode
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, srl_Post)
        Tree_Vw1.Fill(tn, Me.Ds_Hadese.Pm_Hadese_KhesaratDevice)
    End Sub

    Private Sub Frm_DeviceSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        If cmb_Filter.SelectedValue > -1 Then
            srl_Post = cmb_Filter.SelectedValue
        End If
        LoadTV()

    End Sub
    Private Sub LoadTV()
        Tree_Vw1.Clear()
        Try
            Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, srl_Post)
            If Me.Ds_Hadese.Pm_Hadese_KhesaratDevice.Rows.Count < 1 Then
                Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Hadese_KhesaratDevice")
                dr("Srl_Parent") = 0
                dr("Srl_Pm_Post") = srl_Post
                dr("Name") = "دستگاههاي پست"
                Dim i As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            End If
            Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, srl_Post)
            Tree_Vw1.Fill(Nothing, Ds_Hadese.Pm_Hadese_KhesaratDevice)
            Tree_Vw1.TreeView1.SelectedNode = Tree_Vw1.TreeView1.Nodes(0)
            'Tree_Vw1.TreeView1.Focus()
            'Tree_Vw1.TreeView1.Select()
        Catch ex As Exception
            MessageBox.Show("خطا در نمايش اطلاعات لطفا با مدير سيستم تماس بگيريد")
        End Try
    End Sub
    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            SelectedDevice = Tree_Vw1.SelectedNode
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            MessageBoxFa.Show("لطفا  دستگاه مورد نظر را انتخاب نمائید")
        End If
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmb_Filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Filter.SelectedIndexChanged
        srl_Post = cmb_Filter.SelectedValue
        LoadTV()
    End Sub
End Class

