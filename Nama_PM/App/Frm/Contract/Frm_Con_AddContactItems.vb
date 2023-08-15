Public Class Frm_Con_AddContactItems
    Public ContractSrl As Integer
    Public Sub New(ByVal contractSrl As Integer)
        Me.ContractSrl = contractSrl
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Frm_Con_ContactItemsVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_Con_VahedTableAdapter.Fill(Me.Ds_Con.Pm_Con_Vahed)
        cmb_Vahed.SelectedIndex = 1

    End Sub


    Public Function NextRow(ByVal Row As Integer, ByVal e As System.Windows.Forms.KeyEventArgs) As Integer
        If e.KeyCode = Keys.Up And Row > 0 Then
            Return Row - 1
        End If
        If e.KeyCode = Keys.Down And Row < DataGridView1.RowCount - 1 Then
            Return Row + 1
        End If
        Return Row
    End Function

    Public Function NextCol(ByVal Col As Integer, ByVal e As System.Windows.Forms.KeyEventArgs) As Integer
        If e.KeyCode = Keys.Left And Col < DataGridView1.ColumnCount - 1 Then
            While Col < DataGridView1.ColumnCount - 1 And Not DataGridView1.Columns(Col + 1).Visible
                Col = Col + 1
            End While
        End If
        If e.KeyCode = Keys.Right And Col > 0 Then
            While Col > 0 And Not DataGridView1.Columns(Col - 1).Visible
                Col = Col - 1
            End While
        End If
        Return Col
    End Function

    Private Sub DataGridView1_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
        If e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Then
            If DataGridView1.CurrentCell.FormattedValue <> DataGridView1.CurrentCell.EditedFormattedValue Then
                Dim srl As String = DataGridView1.CurrentRow.Cells(0).FormattedValue.ToString()
                Dim query As String = "Update pm_Con_Contractitems set "
                query += "   price =" + DataGridView1.CurrentRow.Cells(4).EditedFormattedValue.ToString()
                query += " , amount=" + DataGridView1.CurrentRow.Cells(3).EditedFormattedValue.ToString()
                query += " , period=" + DataGridView1.CurrentRow.Cells(5).EditedFormattedValue.ToString()
                query += " where srl=" + srl.ToString()
                BaseDataObject.DataAccess.ExecQuery(query)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellChange(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.CellChange
        Dim row As Integer
        Dim col As Integer
        row = DataGridView1.CurrentCell.RowIndex
        col = DataGridView1.CurrentCell.ColumnIndex
        If e.KeyCode = Keys.Enter Then
            If col = DataGridView1.ColumnCount - 1 And row = DataGridView1.RowCount - 1 Then
                Return
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If col = DataGridView1.ColumnCount - 1 Then
                col = 3
                row = row + 1

            Else
                col = col + 1
            End If
            If row = DataGridView1.RowCount Then
                Return
            End If
            DataGridView1.CurrentCell = DataGridView1.Item(col, row)
        End If
    End Sub
End Class