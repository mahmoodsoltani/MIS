Public Class Frm_EibType

    Public Overrides Sub LoadDataGridView()
        Me.Pm_EibTypeTableAdapter.Fill(Me.Ds_Pm.Pm_EibType)
        Me.Pm_ImportantPercentTableAdapter.Fill(Me.Ds_Pm.Pm_ImportantPercent)
        txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        MyBase.LoadDataGridView()
        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If Not DataGridView1.Rows(i).Cells(4).Value Is DBNull.Value Then
        '        DataGridView1.Rows(i).Cells(5).Style.BackColor = System.Drawing.Color.FromArgb(DataGridView1.Rows(i).Cells(4).Value)
        '    End If
        'Next
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_EibType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_EibTypeTableAdapter.Fill(Me.Ds_Pm.Pm_EibType)
        txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
    End Sub
End Class