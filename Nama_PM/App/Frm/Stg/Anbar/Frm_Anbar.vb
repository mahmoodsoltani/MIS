Public Class Frm_Anbar

    Dim TreeToUpdate As VB_Component.TreeNode
    Dim UpdateMode As Boolean

    Dim Srl As Integer
    Dim Srl_Parent As Integer

    Public Sub New(ByVal TreeToUpdate As VB_Component.TreeNode, ByVal UpdateMode As Boolean)
        InitializeComponent()

        Me.TreeToUpdate = TreeToUpdate
        Me.UpdateMode = UpdateMode

        If UpdateMode Then
            FormState = FormStates.Edit
            Dim dr_load As DataRow = BaseDataObject.DataAccess.GetRow("Stg_Anbar", TreeToUpdate.Srl)
            Txt_Name.Value = dr_load("Name")
            Txt_Adress.Value = dr_load("Adress")
            Txt_tel.Value = dr_load("Tel")
            Txt_Dis.Value = dr_load("Dis")
            Txt_Code.Value = dr_load("Code")
            If Not dr_load("CanEdit") Is DBNull.Value Then
                Chk_CanEdit.Checked = dr_load("CanEdit")
            End If
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If Not ValidateAllValue(Me) Then
            Return
        End If

        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Stg_Anbar")
        dr("Srl_Parent") = Srl
        'dr("Srl_Company") = Setting.CompanyInfo.Srl
        dr("Name") = Txt_Name.Value
        dr("Tel") = Txt_tel.Value
        dr("Dis") = Txt_Dis.Value
        dr("Adress") = Txt_Adress.Value
        dr("Code") = Txt_Code.Value
        dr("CanEdit") = Chk_CanEdit.Checked

        If UpdateMode Then
            dr("srl") = TreeToUpdate.Srl
            dr("Srl_Parent") = TreeToUpdate.Srl_Parent
            BaseDataObject.DataAccess.Update(dr, 0)
        Else
            dr("Srl_Parent") = TreeToUpdate.Srl
            BaseDataObject.DataAccess.Insert(dr, False)
        End If
        Close()
    End Sub

End Class