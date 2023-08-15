Public Class Frm_Con_Item

    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_StatusStatementType' table. You can move, or remove it, as needed.
        Me.Pm_Con_StatusStatementTypeTableAdapter.Fill(Me.Ds_Con.Pm_Con_StatusStatementType)
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Unit' table. You can move, or remove it, as needed.
        Me.Pm_Con_UnitTableAdapter.Fill(Me.Ds_Con.Pm_Con_Unit)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
    End Sub

    Public Overrides Sub LoadDataGridView()
        Dim type As Integer
        If Rb_All.Checked Then
            Me.Pm_con_AllItemTableAdapter.Fill(Me.Ds_Con.pm_con_AllItem, -1)
            DataGridView1.DataSource = Me.Ds_Con.pm_con_AllItem
        Else
            If Rb_PM.Checked Then
                type = 1
            Else
                type = 0
            End If
            Me.Pm_Con_ItemTableAdapter.Fill(Me.Ds_Con.Pm_Con_Item, -1, type)
            DataGridView1.DataSource = Me.Ds_Con.Pm_Con_Item
        End If
    End Sub

    
    Private Sub Rb_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_All.CheckedChanged, Rb_PM.CheckedChanged, Rb_Mazad.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        LoadDataGridView()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class