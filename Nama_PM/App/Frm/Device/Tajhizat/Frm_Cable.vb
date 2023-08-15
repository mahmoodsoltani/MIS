Public Class Frm_Cable

    Dim TreeToUpdate As VB_Component.TreeNode
    Dim UpdateMode As Boolean
    Dim srl_post As Integer
    Dim ReturnTreeNode As VB_Component.TreeNode
    Public Overloads Function ShowDialog(ByVal temp As String) As VB_Component.TreeNode
        ReturnTreeNode = New VB_Component.TreeNode("")
        Me.ShowDialog()
        Return ReturnTreeNode
    End Function
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            btn_Save_Click(Nothing, Nothing)
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub
    Public Sub New(ByVal TreeToUpdate As VB_Component.TreeNode, ByVal UpdateMode As Boolean, ByVal srl_post As Integer)
        InitializeComponent()

        Me.Pm_DescriptableTajhizTableAdapter.Fill(Me.Ds_Pm.Pm_DescriptableTajhiz)
        Me.Pm_Device_SazandeTableAdapter1.Fill(Me.Ds_Lab1.Pm_Device_Sazande)

        Me.TreeToUpdate = TreeToUpdate
        Me.UpdateMode = UpdateMode
        Me.srl_post = srl_post

        If UpdateMode Then
            FormState = FormStates.Edit
            Dim dr_load As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Hadese_KhesaratDevice", TreeToUpdate.Srl)
            'cmb_Sazande.SelectedValue = dr_load("Srl_Pm_Device_Sazande")

            txt_DeviceName.Value = dr_load("Name")
            txt_MadeDate.Value = dr_load("MadeDate")
            txt_Model.Value = dr_load("Model")
            txt_serial.Value = dr_load("SerialNumber")
            txt_ValidJaryan.Value = dr_load("ValidJaryan")
            txt_Voltaj.Value = dr_load("Voltaj")
            txt_Maghta.Value = dr_load("CableMaghta")
            txt_Utilization.Value = dr_load("UtilizationDate")

            Try
                If dr_load("Srl_Pm_Device_Sazande") > 0 Then
                    cmb_Sazande.SelectedValue = dr_load("Srl_Pm_Device_Sazande")
                End If
            Catch ex As Exception
                cmb_Sazande.SelectedValue = dr_load("Srl_Pm_Device_Sazande")
            End Try
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If Not ValidateAllValue(Me) Then
            Return
        End If
        If txt_DeviceName.Value = "" Then
            MessageBoxFa.Show("لطفا نام را وارد نمائید")
            txt_DeviceName.Focus()
            Return
        End If
        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Hadese_KhesaratDevice")
        dr("Name") = txt_DeviceName.Value
        dr("MadeDate") = txt_MadeDate.Value
        dr("Model") = txt_Model.Value
        dr("Srl_Pm_Post") = srl_post
        dr("Srl_Pm_Device_Sazande") = cmb_Sazande.SelectedValue
        dr("SerialNumber") = txt_serial.Value
        dr("ValidJaryan") = txt_ValidJaryan.Value
        dr("Voltaj") = txt_Voltaj.Value
        dr("CableMaghta") = txt_Maghta.Value
        dr("UtilizationDate") = txt_Utilization.Value
        dr("SubmitDate") = Setting.Now
        dr("Srl_SubmitUser") = Setting.Srl_User
        dr("Pm_DescriptableTajhiz") = 8

        dr.Item("Srl_Parent") = TreeToUpdate.Srl_Parent

        If UpdateMode Then
            dr("srl") = TreeToUpdate.Srl
            dr("Srl_Parent") = TreeToUpdate.Srl_Parent
            ReturnTreeNode = TreeToUpdate
            ReturnTreeNode.Text = txt_DeviceName.Value
            If BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBoxFa.Show("اطلاعات با موفقیت بروزرسانی شد")
            Else
                MessageBoxFa.Show("مشکل در بروزرسانی اطلاعات")
            End If
        Else
            dr("Srl_Parent") = TreeToUpdate.Srl
            ReturnTreeNode.Srl = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            ReturnTreeNode.Srl_Parent = TreeToUpdate.Srl
            ReturnTreeNode.Text = txt_DeviceName.Value
            If Not ReturnTreeNode.Srl = -1 Then
                MessageBoxFa.Show("اطلاعات با موفقیت ذخیره شد")
            Else
                MessageBoxFa.Show("مشکل در ذخیره اطلاعات")
            End If
        End If
        Close()
    End Sub

    Private Sub Frm_Device_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.StatusStrip1.Items.Add("F2  ذخیره ")
    End Sub
End Class