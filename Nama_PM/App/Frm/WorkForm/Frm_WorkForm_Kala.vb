Public Class Frm_WorkForm_Kala

    Dim dt As Ds_Pm.Pm_WorkForm_KalaDataTable

    Public Sub New(ByVal dt As Ds_Pm.Pm_WorkForm_KalaDataTable)
        InitializeComponent()
        If Not dt Is Nothing Then
            DataGridView1.DataSource = dt
            Me.dt = dt
        End If
    End Sub

    Public Function GetDataTable() As DataTable
        Try
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If KalaSelectManager2.Result Is Nothing Then
            MessageBoxFa.Show("لطفا کالا را انتخاب نمائید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            KalaSelectManager2.Btn_Select.Focus()
            Return False
        End If

        For Each Temp_dr As DataRow In dt.Rows
            If Temp_dr(2) = KalaSelectManager2.Result(2).ToString() Then
                MessageBoxFa.Show("این کالا تکراری است")
                KalaSelectManager2.Btn_Select.Focus()
                Return False
            End If
        Next
        If txt_tedad.Value = 0 Then
            MessageBoxFa.Show("لطفا تعداد را وارد نمائید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_tedad.Focus()
            Return False
        End If

        Dim dr As DataRow = dt.NewRow
        dr(1) = KalaSelectManager2.Result(0).ToString()
        dr(2) = KalaSelectManager2.Result(2).ToString()
        dr(3) = txt_tedad.Value
        dt.Rows.Add(dr)
        DataGridView1.DataSource = dt

        ClearForm()
        KalaSelectManager2.Btn_Select.Focus()
        KalaSelectManager2.ResetResult()
        Return True
    End Function

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBoxFa.Show("لطفا یک ردیف را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            Try
                Dim i As Integer = DataGridView1.CurrentRow.Index
                i = i - 1
                If i < 0 Then
                    i = 0
                End If
                dt.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
                DataGridView1.DataSource = dt
                'DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(1)
                DataGridView1.CurrentRow.Selected = True
            Catch ex As Exception
            End Try
        End If
    End Sub

End Class