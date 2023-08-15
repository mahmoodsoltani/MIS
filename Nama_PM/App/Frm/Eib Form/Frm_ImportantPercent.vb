Public Class Frm_ImportantPercent

    Public Overrides Sub LoadDataGridView()
        Me.Pm_ImportantPercentTableAdapter.Fill(Me.Ds_Pm.Pm_ImportantPercent)
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If Not DataGridView1.Rows(i).Cells(3).Value Is DBNull.Value Then
                DataGridView1.Rows(i).Cells(4).Style.BackColor = System.Drawing.Color.FromArgb(DataGridView1.Rows(i).Cells(3).Value)
                DataGridView1.Rows(i).Cells(4).Style.ForeColor = System.Drawing.Color.FromArgb(DataGridView1.Rows(i).Cells(3).Value)
            End If
        Next
        ' MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow(2) = PColor.BackColor.ToArgb()
        DataObject.DataRow("red") = PColor.BackColor.R
        DataObject.DataRow("blue") = PColor.BackColor.B
        DataObject.DataRow("green") = PColor.BackColor.G
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_PostTip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)

    End Sub

    Private Sub PColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PColor.Click
        If SelectColor.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PColor.BackColor = SelectColor.Color
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        PColor.BackColor = System.Drawing.Color.FromArgb(DataGridView1.SelectedRows(0).Cells(3).Value)
        MyBase.Edit()
    End Sub
    Public Overrides Sub ClearForm()
        PColor.BackColor = Color.White
        MyBase.ClearForm()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
    End Sub
End Class