Public Class Frm_Con_MonthReportConfirmPrice
    Public Srl_MonthReport As Integer
    Public Frm As Frm_Con_MonthReport
    Public Sub New(ByVal Srl_MonthReport As Integer, ByVal f As Frm_Con_MonthReport)
        Me.Srl_MonthReport = Srl_MonthReport
        Me.Frm = f
        InitializeComponent()
    End Sub

    Private Sub Frm_Con_ContactItemsVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_con_MonthReportGrouupConfirmPriceTableAdapter.Fill(Me.Ds_Con.Pm_con_MonthReportGrouupConfirmPrice, Srl_MonthReport)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Vahed' table. You can move, or remove it, as needed.
    End Sub
    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 3 Then
            BaseDataObject.DataAccess.ExecQuery("update pm_con_monthreportgroupconfirmprice set confirm_price=" + DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() + " where srl=" + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
        End If
    End Sub

    Private Sub Frm_Con_MonthReportConfirmPrice_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim sum As Long = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            sum += Convert.ToInt64(DataGridView1.Rows(i).Cells(3).Value)
        Next
        Frm.txt_ConfirmPrice.Text = sum.ToString()
    End Sub
End Class