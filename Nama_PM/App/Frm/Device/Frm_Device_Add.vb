Public Class Frm_Device_add

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
        Me.Pm_Device_SazandeTableAdapter1.Fill(Me.Ds_Lab1.Pm_Device_Sazande)
        Me.TreeToUpdate = TreeToUpdate
        Me.UpdateMode = UpdateMode
        Me.srl_post = srl_post
        Me.Pm_TajhizNameTableAdapter.Fill(Me.Ds_Pm.Pm_TajhizName)
        If UpdateMode Then
            FormState = FormStates.Edit
            Dim dr_load As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Hadese_KhesaratDevice", TreeToUpdate.Srl)
            cmb_Sazande.SelectedValue = dr_load("Srl_Pm_Device_Sazande")
            If Not dr_load("srl_Pm_TajhizName") Is DBNull.Value Then
                cmb_TajhizName.SelectedValue = dr_load("srl_Pm_TajhizName")
            End If
            'txt_DeviceName.Value = dr_load("Name")
            txt_MadeDate.Value = dr_load("MadeDate")
            txt_Model.Value = dr_load("Model")
            txt_serial.Value = dr_load("SerialNumber")
            txt_distpaching.Value = dr_load("DispatchingCode")
            txt_Order.Value = dr_load("OrderCode")
            txt_Utilization.Value = dr_load("UtilizationDate")

            Try
                If dr_load("Srl_Pm_Device_Sazande") <> "" Then
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
        If cmb_TajhizName.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا نام را وارد نمائید")
            cmb_TajhizName.Focus()
            Return
        End If
        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Hadese_KhesaratDevice")
        'dr("Name") = txt_DeviceName.Value
        dr("Srl_Pm_TajhizName") = cmb_TajhizName.SelectedValue
        dr("MadeDate") = txt_MadeDate.Value
        dr("Model") = txt_Model.Value
        dr("Srl_Pm_Post") = srl_post
        dr("Srl_Pm_Device_Sazande") = IIf(cmb_Sazande.SelectedValue Is Nothing, DBNull.Value, cmb_Sazande.SelectedValue)

        dr("SerialNumber") = txt_serial.Value
        dr("DispatchingCode") = txt_distpaching.Value
        dr("OrderCode") = txt_Order.Value
        dr("UtilizationDate") = txt_Utilization.Value
        dr("SubmitDate") = Setting.Now
        dr("Srl_SubmitUser") = Setting.Srl_User



        dr.Item("Srl_Parent") = TreeToUpdate.Srl_Parent


        If UpdateMode Then
            dr("srl") = TreeToUpdate.Srl
            dr("Srl_Parent") = TreeToUpdate.Srl_Parent
            ReturnTreeNode = TreeToUpdate
            ReturnTreeNode.Text = BaseDataObject.DataAccess.ExecScalar("select name from pm_tajhizname where srl=" + cmb_TajhizName.SelectedValue.ToString())
            If BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBoxFa.Show("اطلاعات با موفقیت بروزرسانی شد")
            Else
                MessageBoxFa.Show("مشکل در بروزرسانی اطلاعات")
            End If
        Else
            dr("Srl_Parent") = TreeToUpdate.Srl
            ReturnTreeNode.Srl = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            ReturnTreeNode.Srl_Parent = TreeToUpdate.Srl
            ReturnTreeNode.Text = BaseDataObject.DataAccess.ExecScalar("select name from pm_tajhizname where srl=" + cmb_TajhizName.SelectedValue.ToString())
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

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Dim s As New Frm_DeviceName()
        s.ShowDialog()
        Me.Pm_TajhizNameTableAdapter.Fill(Me.Ds_Pm.Pm_TajhizName)

    End Sub
End Class