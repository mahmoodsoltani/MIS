Imports Microsoft.Office.Interop.Excel
Public Class Frm_Con_Non_MonthReportVw

   
    Private Sub Frm_WorkFormVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_MonthTableAdapter.Fill(Me.Ds_Con.Pm_Month)
        Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        Me.Pm_Con_SourceTableAdapter.Fill(Me.Ds_Con.Pm_Con_Source)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        txt_year.Text = Setting.TarikheJary.Substring(0, 4)
        DataGridView1.Columns(2).DefaultCellStyle.Format = "#,###"
    End Sub

    Private Sub PostOrKhat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Vahed.CheckedChanged
        DGV_Vahed.Enabled = Not chk_Vahed.Checked
    End Sub
    Private Sub chk_Omoor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Omoor.CheckedChanged
        DGV_Omoor.Enabled = Not chk_Omoor.Checked
    End Sub
    Private Sub chk_Source_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Source.CheckedChanged
        DGV_Source.Enabled = Not chk_Source.Checked
    End Sub

    Private Sub chk_Month_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Month.CheckedChanged
        DGV_Month.Enabled = Not chk_Month.Checked
    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        UpdateDGV()
        'Try

        '    For i As Integer = 0 To DataGridView1.RowCount - 1
        '        Dim j As Long = Convert.ToInt64(DataGridView1.Rows(i).Cells(10).Value) - Convert.ToInt64(DataGridView1.Rows(i).Cells(11).Value)
        '        If j <> 0 Then
        '            DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.Red
        '        Else
        '            DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.Green

        '        End If
        '    Next
        '    'DataGridView1.Columns(8).DefaultCellStyle.Format = "N0"
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub UpdateDGV()
        Dim srl_contract As String = "-1"
        Dim srl_vahed As String = "-1"
        Dim srl_Source As String = "-1"
        Dim srl_omoor As String = "-1"
        Dim srl_Month As String = "-1"
        Dim sstype As String = -1
        Dim _year As Integer = -1
        Try
            _year = txt_year.Value
        Catch ex As Exception
            _year = -1
        End Try
        DGV_Vahed.EndEdit()
        DGV_Contract.EndEdit()
        DGV_Omoor.EndEdit()
        DGV_Source.EndEdit()
        DGV_Month.EndEdit()
        If rb_pm.Checked Then
            sstype = 1
        ElseIf rb_Mazad.Checked Then
            sstype = 2
        End If
        If Not chk_Vahed.Checked Then
            For Each dr As DataGridViewRow In DGV_Vahed.Rows
                If dr.Cells(0).Value Then
                    srl_vahed = srl_vahed + "," + dr.Cells(1).Value.ToString()
                End If
            Next
            srl_vahed = srl_vahed + ",-1"
        End If
        If Not chk_allContract.Checked Then
            For Each dr As DataGridViewRow In DGV_Contract.Rows
                If dr.Cells(0).Value Then
                    srl_contract = srl_contract + "," + dr.Cells(1).Value.ToString()
                End If
            Next
            srl_contract = srl_contract + ",-1"
        End If
        If Not chk_Omoor.Checked Then
            For Each dr As DataGridViewRow In DGV_Omoor.Rows
                If dr.Cells(0).Value Then
                    srl_omoor = srl_omoor + "," + dr.Cells(1).Value.ToString()
                End If
            Next
            srl_omoor = srl_omoor + ",-1"
        End If
        If Not chk_Source.Checked Then
            For Each dr As DataGridViewRow In DGV_Source.Rows
                If dr.Cells(0).Value Then
                    srl_Source = srl_Source + "," + dr.Cells(1).Value.ToString()
                End If
            Next
            srl_Source = srl_Source + ",-1"
        End If
        If Not chk_Month.Checked Then
            For Each dr As DataGridViewRow In DGV_Month.Rows
                If dr.Cells(0).Value Then
                    srl_Month = srl_Month + "," + dr.Cells(1).Value.ToString()
                End If
            Next
            srl_Month = srl_Month + ",-1"
        End If
        Me.Pm_Con_Non_MonthReportTableAdapter.Fill(Me.Ds_Con.Pm_Con_Non_MonthReport, srl_Month, srl_omoor, srl_vahed, sstype, _year, srl_Source, srl_contract)
        Dim sum As Long = 0
        For i As Integer = 0 To Me.Ds_Con.Pm_Con_Non_MonthReport.Rows.Count - 1
            sum += Convert.ToInt64(Me.Ds_Con.Pm_Con_Non_MonthReport.Rows(i)(2)) * Me.Ds_Con.Pm_Con_Non_MonthReport.Rows(i)(1)
        Next
        txt_sum.Text= sum.ToString()
    End Sub

    Private Sub chk_allContract_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allContract.CheckedChanged
        DGV_Contract.Enabled = Not chk_allContract.Checked()

    End Sub
End Class