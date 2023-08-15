Imports Microsoft.Office.Interop.Excel
Imports System.IO
Public Class Frm_Line
    Private Edit_CurrentIndex As Integer

    Public Overrides Sub LoadDataGridView()
        Me.Pm_LineTableAdapter.Fill(Ds_Pm.Pm_Line, -1)
        MyBase.LoadDataGridView()
    End Sub

    Private Sub Frm_Post_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Ds_Line_.Pm_Line_FibrType' table. You can move, or remove it, as needed.
        Me.Pm_Line_FibrTypeTableAdapter.Fill(Me._Ds_Line_.Pm_Line_FibrType)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_PostType' table. You can move, or remove it, as needed.
        Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        Me.Pm_Line_DakalStructureTableAdapter.Fill(Me._Ds_Line_.Pm_Line_DakalStructure)
        Me.Pm_Line_GardTypeTableAdapter.Fill(Me._Ds_Line_.Pm_Line_GardType)
        Me.Pm_Line_MaghareTypeTableAdapter.Fill(Me._Ds_Line_.Pm_Line_MaghareType)
        Me.Pm_Line_HadiTypeTableAdapter.Fill(Me._Ds_Line_.Pm_Line_HadiType)
        Me.Pm_Line_VoltageTableAdapter.Fill(Me._Ds_Line_.Pm_Line_Voltage)
        Me.Pm_PostTypeTableAdapter.Fill(Me.Ds_Pm.Pm_PostType)
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, 76)
    End Sub




    Private Sub txt_SathVoltaj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim f As New Frm_Dakal(CInt(senderGrid.Rows(e.RowIndex).Cells(0).Value))
            f.ShowDialog()
        End If
    End Sub

    Private Sub Convert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Convert.Click
        'Dim path As String = ""
        'If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    If OpenFileDialog1.FileName.Contains("~$") Then
        '        Return
        '    End If
        '    If OpenFileDialog1.FileName <> "" Then
        '        path = OpenFileDialog1.FileName
        '    Else
        '        Return
        '    End If
        'End If
        'Dim ExlFile As Microsoft.Office.Interop.Excel.Application
        'ExlFile = New Microsoft.Office.Interop.Excel.Application
        'ExlFile.Visible = False
        'ExlFile.Workbooks.Open(path)
        'Dim sheet As Microsoft.Office.Interop.Excel.Worksheet = CType(ExlFile.Sheets("sheet1"), Microsoft.Office.Interop.Excel.Worksheet)
        'Dim used_range As Microsoft.Office.Interop.Excel.Range = sheet.UsedRange
        'Dim max_row As Integer = used_range.Rows.Count
        'Dim max_col As Integer = used_range.Columns.Count
        'Dim values As Object(,) = CType(used_range.Value2, Object(,))
        'Dim duplicate = 0
        'Dim added = 0
        'For row As Integer = 2 To max_row
        '    Dim row_values As Object() = New Object(max_col - 1) {}
        '    If values(row, 1) <> "" Then
        '        Dim voltage As String = values(row, 3)
        '        Dim code As String = values(row, 2)
        '        Dim name As String = values(row, 1)
        '        If CInt(BaseDataObject.DataAccess.ExecScalar("select count(*) from pm_line where name =N'" + name + "'")) > 0 Then
        '            duplicate = duplicate + 1
        '            Continue For
        '        Else
        '            Dim srl_voltage = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(srl,0) from pm_line_voltage where name='" + voltage + "'"))
        '            If srl_voltage < 1 Then
        '                BaseDataObject.DataAccess.ExecQuery("insert into pm_line_voltage (name) values('" + voltage + "')")
        '                srl_voltage = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(srl,0) from pm_line_voltage where name='" + voltage + "'"))
        '            End If
        '            Dim query As String = "insert into pm_line (code,name,srl_voltage)values('" + code + "',N'" + name + "'," + srl_voltage.ToString() + ")"
        '            query = query + "update Pm_Line set DakalCount   = 0 where DakalCount is null" & _
        '                            " update Pm_Line set CycleCount    = 0 where CycleCount is null" & _
        '                            " update Pm_Line set HadiCount    = 0 where HadiCount is null" & _
        '                            " update Pm_Line set GardCount    = 0 where GardCount is null" & _
        '                            " update Pm_Line set MaghareCount    = 0 where MaghareCount is null" & _
        '                            " update Pm_Line set LatisTowerCount     = 0 where LatisTowerCount is null " & _
        '                            " update Pm_Line set TelescopTowerCount     = 0 where TelescopTowerCount is null"
        '            BaseDataObject.DataAccess.ExecQuery(query)
        '            added = added + 1
        '        End If
        '    End If
        'Next
        'MessageBoxFa.Show("تعداد " + added.ToString() + " خط با موفقیت اضافه گردیدو تعداد " + duplicate.ToString() + " خط تکراری بود", "", MessageBoxButtons.OK)
        'LoadDataGridView()
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class