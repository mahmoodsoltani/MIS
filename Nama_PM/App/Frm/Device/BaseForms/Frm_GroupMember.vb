Public Class Frm_GroupMember

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        Else
            Me.Pm_GroupMemberTableAdapter.Fill(Me.Ds_Pm.Pm_GroupMember, DataGridView1.CurrentRow.Cells(0).Value, Nothing)

        End If
    End Sub
    Public Overrides Function Edit() As Boolean
        Return MyBase.Edit()
    End Function
    Public Overrides Function Edit(ByVal srl_toEdit As Integer) As Boolean
        Return MyBase.Edit(srl_toEdit)
    End Function
    Public Overrides Sub LoadDataGridView()
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        DataGridView1_SelectionChanged(Nothing, Nothing)
        MyBase.LoadDataGridView()
    End Sub
    Public Overrides Function Delete() As Boolean
        If DataGridView2.CurrentRow Is Nothing Then
            MessageBoxFa.Show("لطفا برای حذف یک عضو را انتخاب کنید", , MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If MessageBoxFa.Show("آیا مطمئنید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            BaseDataObject.DataAccess.ExecQuery("delete from pm_GroupMember where srl = " + DataGridView2.CurrentRow.Cells(0).Value.ToString())
            DataGridView1_SelectionChanged(Nothing, Nothing)
        End If
    End Function
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        Dim row As Integer = DataGridView1.CurrentRow.Index
        If Cmb_SrlAshkhas.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا فرد عضو را انتخاب کنید")
            Cmb_SrlAshkhas.Focus()
            Return False
        End If
        If Not (FormState = FormStates.Edit) And BaseDataObject.DataAccess.ExecScalar("Select Count(*) from PM_GroupMember where Srl_Pm_Group=" + DataGridView1.CurrentRow.Cells(0).Value.ToString() + " And IsPrimary=1") > 0 And chk_IsPrimary.Checked Then
            MessageBoxFa.Show("قبلا برای این گروه سرپرست انتخاب شده است")
            chk_IsPrimary.Focus()
            Return False
        End If
        If Not (FormState = FormStates.Edit) And CInt(BaseDataObject.DataAccess.ExecScalar("Select Count(*) from PM_GroupMember Where  Srl_Pm_Group=" + DataGridView1.CurrentRow.Cells(0).Value.ToString() + " And Srl_Acc_Ashkhas=" + Cmb_SrlAshkhas.SelectedValue.ToString())) > 0 Then
            MessageBoxFa.Show("قبلا این عضو انتخاب شده است")
            Cmb_SrlAshkhas.Focus()
            Return False
        End If

        If DataGridView1.CurrentRow Is Nothing Then
            MessageBoxFa.Show("لطفا گروه مورد نظر را انتخاب کنید")
            Return False
        End If
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        DataObject.DataRow("Srl_Pm_Group") = DataGridView1.CurrentRow.Cells(0).Value
        'DataObject.DataRow("Srl_Acc_Ashkhas") = LookupBox1.Result(0)
        'DataObject.DataRow("IsPrimary") = chk_IsPrimary.Checked
        'BaseDataObject.DataAccess.Insert(DataObject.DataRow, False)

        MyBase.Save(True)
        Cmb_SrlAshkhas.SelectedValue = -1
        chk_IsPrimary.Checked = False
        DataGridView1.CurrentCell = DataGridView1.Rows(row).Cells(1)
        Me.Pm_GroupMemberTableAdapter.Fill(Me.Ds_Pm.Pm_GroupMember, DataGridView1.CurrentRow.Cells(0).Value, Nothing)

        Return True
    End Function


End Class