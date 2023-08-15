Public Class Frm_KalaGroupAdd
    Dim TreeToUpdate As VB_Component.TreeNode
    Dim UpdateMode As Boolean

    Public Sub New(ByVal TreeToUpdate As VB_Component.TreeNode, ByVal UpdateMode As Boolean)
        InitializeComponent()

        Me.TreeToUpdate = TreeToUpdate
        Me.UpdateMode = UpdateMode
        If Not UpdateMode Then
            txt_Code.Value = 1 + BaseDataObject.DataAccess.ExecScalar("select Max(cast(Code as int) )from Stg_KalaGroup ")
        End If
        If UpdateMode Then
            FormState = FormStates.Edit
            Dim dr_load As DataRow = BaseDataObject.DataAccess.GetRow("Stg_KalaGroup", TreeToUpdate.Srl)
            txt_Code.Value = dr_load("Code")
            txt_Name.Value = dr_load("Name")
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If Not ValidateAllValue(Me) Then
            Return
        End If

        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("stg_KalaGroup")
        'dr("Srl_Company") = Setting.CompanyInfo.Srl
        dr("Code") = txt_Code.Value
        dr("Name") = txt_Name.Value

        dr.Item("Srl_Parent") = TreeToUpdate.Srl_Parent
        If Not UpdateMode And BaseDataObject.DataAccess.GetDataTable("select * from stg_KalaGroup where srl_Parent = " + TreeToUpdate.Srl.ToString() + " and Code='" + txt_Code.Value.ToString() + "'").Rows.Count > 0 Then
            MessageBoxFa.Show("کد مورد نظر تکراری است")
            Return
            'ElseIf UpdateMode And BaseDataObject.DataAccess.GetDataTable("select * from stg_KalaGroup where Srl = " + TreeToUpdate.Srl.ToString() + " and Code='" + txt_Code.Value.ToString() + "'").Rows.Count > 0 Then
            '    MessageBoxFa.Show("کد مورد نظر تکراری است")
            '    Return
        End If
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

End Class