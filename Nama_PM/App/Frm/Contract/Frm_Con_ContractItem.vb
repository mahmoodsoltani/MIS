Public Class Frm_Con_ContractItem
    Private srl_contract As Integer
    Private doevent As Boolean = True
    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_Con_ItemTableAdapter.Fill(Me.Ds_Con.Pm_Con_Item, -1, -1)
        Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, cmb_vahed.SelectedValue, cmb_Contract.SelectedValue, -1)
        srl_contract = cmb_Contract.SelectedValue
    End Sub
    Private Sub cmb_Contract_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Contract.SelectedIndexChanged, cmb_vahed.SelectedIndexChanged
        If doevent Then
            Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, cmb_vahed.SelectedValue, cmb_Contract.SelectedValue, -1)
            srl_contract = cmb_Contract.SelectedValue
        End If
    End Sub
    Public Overrides Sub LoadDataGridView()
        Dim t As Integer = -1
        If Rb_PM.Checked Then
            t = 1
        ElseIf Rb_Mazad.Checked Then
            t = 2
        End If
        Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, cmb_vahed.SelectedValue, cmb_Contract.SelectedValue, t)
    End Sub
    'Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
    '    doevent = False
    '    MyBase.OnKeyDown(e)
    '    If e.KeyCode = Keys.Escape And Me.FormState = FormStates.Edit Then

    '        cmb_Contract.SelectedValue = srl_contract
    '        Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, -1, cmb_Contract.SelectedValue)

    '    End If
    '    If e.KeyCode = Keys.Menu And Me.FormState = FormStates.NewRecord Then

    '        cmb_Contract.SelectedValue = srl_contract
    '        Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, -1, cmb_Contract.SelectedValue)

    '    End If
    '    doevent = True
    'End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If Me.FormState <> FormStates.Edit Then

            If CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(count(*),0) from pm_con_contractitems where srl_contract=" + cmb_Contract.SelectedValue.ToString + " and srl_item=" + cmb_item.SelectedValue.ToString())) > 0 Then
                MessageBoxFa.Show("این آیتم برای این قرارداد قبلا ثبت شده است!", "هشدار", MessageBoxButtons.OK)
                cmb_code.Focus()
                Return False
            End If
        End If
        MyBase.DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        MyBase.DataObject.DataRow("SubmitDate") = Setting.Now
        MyBase.DataObject.DataRow("srl_contract") = cmb_Contract.SelectedValue
        doevent = False
        MyBase.Save(True)
        txt_period.Text = 0
        txt_amount.Text = 0
        txt_price.Text = 0
        cmb_Contract.SelectedValue = srl_contract
        Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, -1, cmb_Contract.SelectedValue, -1)
        doevent = True
        Return True
    End Function
    Public Overrides Function Save() As Boolean
       
    End Function

    Private Sub Rb_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_All.CheckedChanged
        LoadDataGridView()
    End Sub

    Private Sub Rb_PM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_PM.CheckedChanged
        LoadDataGridView()
    End Sub
End Class