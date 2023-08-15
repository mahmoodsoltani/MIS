Public Class Frm_Distance

    Public Overrides Sub LoadDataGridView()
        Me.Pm_DistanceTableAdapter.Fill(Me.Ds_Pm.Pm_Distance)
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.PM_Post)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If lk_from.Result Is Nothing Or lk_To.Result Is Nothing Then
            Return False
        End If
        Dim SrlFrom As String
        Dim SrlTo As String
        Dim FS As FormStates = Me.FormState
        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Select * from Pm_distance where Srl_Post1=" + lk_from.Result(0).ToString() + " And Srl_Post2=" + lk_To.Result(0).ToString())
        Dim Rdistance As DataRow
        If Not dr Is Nothing And FormState <> FormStates.Edit Then
            MessageBoxFa.Show("این فاصله قبلا ثبت شده است")
            Return False
        End If
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Rdistance = DataObject.DataRow
        SrlFrom = lk_from.Result(0).ToString()
        SrlTo = lk_To.Result(0).ToString()
        MyBase.Save(DoClearForm)
        dr = BaseDataObject.DataAccess.GetRow("Select * from Pm_distance where Srl_Post2=" + SrlFrom + " And Srl_Post1=" + SrlTo)
        If dr Is Nothing And FS <> FormStates.Edit Then
            Rdistance("Srl_Post2") = SrlFrom
            Rdistance("Srl_Post1") = SrlTo
            BaseDataObject.DataAccess.Insert(Rdistance, False)
        ElseIf Not dr Is Nothing And FS = FormStates.Edit Then
            Rdistance("Srl") = dr("Srl")
            Rdistance("Srl_Post2") = SrlFrom
            Rdistance("Srl_Post1") = SrlTo
            BaseDataObject.DataAccess.Update(Rdistance, 0, False)
        End If
        LoadDataGridView()
        Return True
    End Function

    Private Sub Frm_Distance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_DistanceTableAdapter.Fill(Me.Ds_Pm.Pm_Distance)
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
    End Sub
End Class