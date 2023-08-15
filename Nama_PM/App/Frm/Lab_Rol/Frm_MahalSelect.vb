Public Class Frm_MahalSelect
    Public selectedSubject1 As VB_Component.TreeNode
    Public selectedSubject2 As VB_Component.TreeNode

    Private Sub Tree_Vw1_ExpandNode(ByVal tn As VB_Component.TreeNode) Handles Tree_Vw1.ExpandNode
        Me.Pm_Lab_Rol_MahalTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
        Tree_Vw1.Fill(tn, Me.Ds_Lab.Pm_Lab_Rol_Mahal)
    End Sub

    Private Sub Frm_MahalSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Mahal' table. You can move, or remove it, as needed.
        Me.Pm_Lab_Rol_MahalTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Mahal)
        Tree_Vw1.Fill(Nothing, Ds_Lab.Pm_Lab_Rol_Mahal)
        'Tree_Vw1.TreeView1.ExpandAll()

    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        If Not Tree_Vw1.SelectedNode Is Nothing Then
            selectedSubject1 = Tree_Vw1.SelectedNode
            selectedSubject2 = Tree_Vw1.SelectedNode

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class