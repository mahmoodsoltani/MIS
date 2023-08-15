Public Class Frm_SelectPmProgram
    Public Selected_Srl As Integer
    Public pm_date As String
    Dim DatagridSource As DataTable
    Sub New(ByVal dt As DataTable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        DatagridSource = dt

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Frm_SelectPmProgram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = DatagridSource
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Selected_Srl = -1
    End Sub
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            If Not DataGridView1.SelectedRows Is Nothing Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    Selected_Srl = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
                    pm_date = DataGridView1.SelectedRows(0).Cells(1).Value
                    Me.Close()
                End If
            Else
                MessageBoxFa.Show("لطفا یک ردیف را انتخاب نمائید")

            End If
        Catch
            Selected_Srl = -1
            pm_date = ""
            Me.Close()
        End Try
    End Sub
End Class
