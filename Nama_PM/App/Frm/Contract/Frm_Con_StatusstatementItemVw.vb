Public Class Frm_Con_StatusstatementItemVw
    Public Srl_source As Integer
    Public Srl_omoor As Integer
    Public Srl_Vahed As Integer
    Public Srl_contract As Integer
    Public Year As Integer
    Public Month As Integer
    Public Type As Integer

    Public Sub New(ByVal srl_omoor As Integer, ByVal srl_source As Integer, ByVal srl_vahed As Integer, ByVal year As Integer, ByVal month As Integer, ByVal type As Integer, ByVal srl_contract As Integer)
        Me.Srl_source = srl_source
        If srl_omoor < 1 Then
            Me.Srl_omoor = -1
        Else
            Me.Srl_omoor = srl_omoor
        End If
        Me.Srl_Vahed = srl_vahed
        Me.Srl_contract = srl_contract
        Me.Month = month
        Me.Year = year
        Me.Type = type

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Frm_RpHadeseVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Dim tarikh As String
        If Month < 10 Then
            tarikh = Year.ToString() + "/0" + Month.ToString() + "/" + "01"
        Else
            tarikh = Year.ToString() + "/" + Month.ToString() + "/" + "01"

        End If
        Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, Srl_Vahed, Srl_contract, Type)
        Pm_Con_StatusstatementItemVwTableAdapter.Fill(Ds_Con.Pm_Con_StatusstatementItemVw, Srl_Vahed, Srl_source, Srl_omoor, Year, Month, Type, "-1", "-1", -1, -1, -1, Srl_contract)
        lbl_Record.Text = "تعداد رکورد : " + Me.Ds_Con.Pm_Con_StatusstatementItemVw.Rows.Count.ToString
        Me.Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, Srl_Vahed)
        CalcAllSum()
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If


        Dim Srl_Post As Integer = -1
        If Not chk_Post.Checked Then
            Srl_Post = cmb_Post.SelectedValue
        End If
        Dim srl_Group As Integer = -1
        If Not chk_Group.Checked Then
            srl_Group = cmb_Group.SelectedValue
        End If

        Dim Srl_Item As Integer = -1
        If Not chk_Item.Checked Then
            Srl_Item = cmb_Item.SelectedValue
        End If
        Pm_Con_StatusStatementItemVwTableAdapter.Fill(Ds_Con.Pm_Con_StatusstatementItemVw, Srl_Vahed, Srl_source, Srl_omoor, Year, Month, Type, FromDate, ToDate, Srl_Post, srl_Group, Srl_Item, Srl_contract)
        lbl_Record.Text = "تعداد رکورد : " + Me.Ds_Con.Pm_Con_StatusstatementItemVw.Rows.Count.ToString
        CalcAllSum()
    End Sub

    Private Sub chk_allday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allday.CheckedChanged
        txt_FromDate.Enabled = Not chk_allday.Checked
        txt_ToDate.Enabled = Not chk_allday.Checked
    End Sub

    Private Sub chk_Mahal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Post.CheckedChanged
        cmb_Post.Enabled = Not chk_Post.Checked
    End Sub
    Private Sub chk_Group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Item.CheckedChanged
        cmb_Item.Enabled = Not chk_Item.Checked
    End Sub


    Private Sub CalcAllSum()
        Dim sum As Integer = 0
        Try
            For Each dr As DataRow In Ds_Con.Pm_Con_StatusstatementItemVw.Rows
                sum += CInt(dr("کل"))
            Next
            txt_Sum.Text = sum.tostring()
        Catch ex As Exception
            txt_Sum.Text = "0"
        End Try
    End Sub
    Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim rp As New Rp_Hadese
        'Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        'If srl = -1 Then
        '    Return
        'End If
        'Try
        '    Rp_HadeseTableAdapter.Fill(Ds_Hadese.Rp_Hadese, srl)
        'Catch ex As Exception
        'End Try
        'Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable( _
        'Rp_HadeseTableAdapter.Adapter.SelectCommand.CommandText.Replace("@Srl", srl.ToString))
        'rp.SetDataSource(dt)
        'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        'Dim frm_rp As New Frm_RpVw(rp, dt)
        'frm_rp.ShowDialog()
    End Sub

    Private Sub Btn_PrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_PrintAll.Click
        'Dim rp As New Rp_Hadese_PrintAll

        'Dim dt As DataTable = Ds_Hadese.Pm_Hadese
        'rp.SetDataSource(dt)
        'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        'Dim frm_rp As New Frm_RpVw(rp, dt)
        'frm_rp.ShowDialog()
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmb_Post_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Post.SelectedIndexChanged
    End Sub

    Private Sub chk_Group_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Group.CheckedChanged
        cmb_Group.Enabled = Not chk_Group.Checked
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        Dim srl_WorkForm As Integer = -1
        Dim srl_stausStatement As Integer = -1
        If e.RowIndex = -1 Then
            Return
        End If
        If Not senderGrid.Rows(e.RowIndex).Cells(9).Value.GetType() Is GetType(DBNull) Then
            srl_WorkForm = DirectCast(senderGrid.Rows(e.RowIndex).Cells(9).Value, Integer)
        Else
            srl_stausStatement = DirectCast(senderGrid.Rows(e.RowIndex).Cells(20).Value, Integer)
        End If
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            '  Dim Itemstype As Integer = BaseDataObject.DataAccess.ExecScalar("select isnull(sstype,0) from pm_con_item where srl=" + senderGrid.Rows(e.RowIndex).Cells(11).Value.ToString())
            If senderGrid.Rows(e.RowIndex).Cells(36).Value.ToString() = 1 Then
                Dim frm As New Frm_Con_StatusStatement(srl_WorkForm, srl_stausStatement)
                frm.ShowDialog()
            Else
                Dim frm As New Frm_Con_StatusStatementMazad(srl_WorkForm, srl_stausStatement)
                frm.ShowDialog()
            End If

        End If
    End Sub

    Private Sub cmb_Group_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Group.SelectedIndexChanged

    End Sub
End Class