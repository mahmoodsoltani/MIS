Public Class Frm_Template_add


    Dim TreeToUpdate As VB_Component.TreeNode
    Dim UpdateMode As Boolean

    Public Sub New(ByVal TreeToUpdate As VB_Component.TreeNode, ByVal UpdateMode As Boolean)
        InitializeComponent()

        Me.TreeToUpdate = TreeToUpdate
        Me.UpdateMode = UpdateMode

        If UpdateMode Then
            FormState = FormStates.Edit
            Dim dr_load As DataRow = BaseDataObject.DataAccess.GetRow("Pm_PostTemplate", TreeToUpdate.Srl)
            txt_TemplateTitle.Value = dr_load("title")
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If Not ValidateAllValue(Me) Then
            Return
        End If

        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_PostTemplate")
        dr("name") = txt_TemplateTitle.Value
        dr("Srl_SubmitUser") = Setting.Srl_User
        dr("SubmitDate") = Setting.Now

        dr.Item("Srl_Parent") = TreeToUpdate.Srl_Parent

        If UpdateMode Then
            dr("srl") = TreeToUpdate.Srl
            dr("Srl_Parent") = TreeToUpdate.Srl_Parent
            If BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBoxFa.Show("اطلاعات با موفقیت بروزرسانی شد")
            Else
                MessageBoxFa.Show("مشکل در بروزرسانی اطلاعات")
            End If
        Else
            dr("Srl_Parent") = TreeToUpdate.Srl

            If BaseDataObject.DataAccess.Insert(dr, False) Then
                MessageBoxFa.Show("اطلاعات با موفقیت ذخیره شد")
            Else
                MessageBoxFa.Show("مشکل در ذخیره اطلاعات")
            End If
        End If
        Close()
    End Sub

    Private Sub Frm_Device_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 

    End Sub
End Class