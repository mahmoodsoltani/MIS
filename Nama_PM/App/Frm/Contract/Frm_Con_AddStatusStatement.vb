Public Class Frm_Con_AddStatusStatement
    Dim Frm As Frm_Con_StatusStatement
    Dim FrmMazad As Frm_Con_StatusStatementMazad
    Dim Srl_Edit As Integer = -1
    Public Sub New()
        Srl_Edit = -1
        InitializeComponent()
        Me.Frm = Nothing
        Me.FrmMazad = Nothing
    End Sub
    Public Sub New(ByVal f As Frm_Con_StatusStatement, Optional ByVal srl As Integer = -1)
        Srl_Edit = srl
        InitializeComponent()
        Me.Frm = f
    End Sub
    Public Sub New(ByVal f As Frm_Con_StatusStatementMazad, Optional ByVal srl As Integer = -1)

        InitializeComponent()
        Me.FrmMazad = f
        Me.Srl_Edit = srl
    End Sub
    Public Sub New(ByVal srl As Integer)

        InitializeComponent()
        Me.Srl_Edit = srl
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            'If txt_SSNumber.Text = "" Then
            '    MessageBoxFa.Show("شماره صورت وضعیت را مشخص نمائید", "هشدار", MessageBoxButtons.OK)
            '    txt_SSNumber.Focus()
            '    Return
            'End If
            If Srl_Edit = -1 Then
                If CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(count(*),0) from pm_con_statusstatement where number='" + txt_SSNumber.Text + "'")) > 0 Then
                    MessageBoxFa.Show("شماره صورت وضعیت تکراری است", "هشدار")
                    txt_SSNumber.Focus()
                    Return
                End If
                Dim FindNumber As String
                If Cmb_vahed.SelectedValue = 76 Or Cmb_vahed.SelectedValue = 104 Or Cmb_vahed.SelectedValue = 105 Then
                    FindNumber = BaseDataObject.DataAccess.ExecScalar("select number from Pm_Con_StatusStatement  where Tarikh='" + txt_tarikh.Value + "' and Srl_vahed =" + Cmb_vahed.SelectedValue.ToString() + " and Srl_group=" + cmb_Group.SelectedValue.ToString() + " and Srl_line = " + cmb_Line.SelectedValue.ToString())
                Else
                    FindNumber = BaseDataObject.DataAccess.ExecScalar("select number from Pm_Con_StatusStatement  where Tarikh='" + txt_tarikh.Value + "' and Srl_vahed =" + Cmb_vahed.SelectedValue.ToString() + " and Srl_group=" + cmb_Group.SelectedValue.ToString() + " and Srl_post = " + Cmb_Post.SelectedValue.ToString())
                End If
                If Not FindNumber Is Nothing Then
                    If Not Frm Is Nothing Or Not FrmMazad Is Nothing Then
                        If MessageBoxFa.Show("صورت وضعیت شماره " + FindNumber + " با اطلاعات داده شده موجود است! آیا میخواهید با آن ادامه دهید؟", "هشدار", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                            If Frm Is Nothing Then
                                FrmMazad.txt_Number.Text = FindNumber
                                FrmMazad.btn_SearchWorkForm_Click(Nothing, Nothing)
                                Me.Close()
                            Else
                                Frm.txt_Number.Text = FindNumber
                                Frm.btn_SearchWorkForm_Click(Nothing, Nothing)
                                Me.Close()
                            End If
                            Return
                        Else
                            txt_tarikh.Focus()
                            Return
                        End If
                    Else
                        MessageBoxFa.Show("با این اطلاعات قبلا صورت وضعیت شماره " + FindNumber + " ثبت شده است")
                        txt_SSNumber.Focus()
                        Return
                    End If

                End If
                Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_con_statusStatement")
                BaseDataObject.DataAccess.BeginTransaction()
                Dim n As String = BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(number),0) from Pm_Con_StatusStatement")
                dr("Number") = (CInt(n) + 1).ToString()
                'dr("Number") = txt_Number.Text
                dr("SSNumber") = txt_SSNumber.Text
                dr("Tarikh") = txt_tarikh.Value

                dr("Srl_vahed") = Cmb_vahed.SelectedValue
                dr("Srl_Group") = cmb_Group.SelectedValue
                dr("Description") = txt_Description.Text
                If txt_DeviceSrl.Value <> "" Then
                    dr("srl_device") = txt_DeviceSrl.Value
                    dr("DeviceName") = txt_DeviceName.Value
                Else
                    dr("srl_device") = DBNull.Value
                    dr("DeviceName") = DBNull.Value
                End If
                dr("Srl_hazineCode") = cmb_HazineCode.SelectedValue
                dr("Description") = txt_Description.Text
                If Cmb_vahed.SelectedValue = 76 Or Cmb_vahed.SelectedValue = 104 Or Cmb_vahed.SelectedValue = 105 Or Cmb_vahed.SelectedValue = 114 Then
                    dr("srl_line") = cmb_Line.SelectedValue
                Else
                    dr("Srl_post") = Cmb_Post.SelectedValue
                End If
                BaseDataObject.DataAccess.BeginTransaction()
                Dim Srl_Statusstatement As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
                'If Not BaseDataObject.DataAccess.Insert(dr, False) Then
                '    MessageBoxFa.Show("خطا در ذخیره سازی. لطفا مجدد تلاش نمائید")
                'End If
                For Each dtg As DataGridViewRow In DGV_Person.Rows
                    Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_con_StatusStatementDetail")
                    dr_details("srl_StatusStatement") = Srl_Statusstatement
                    dr_details("Srl_Ashkhas") = dtg.Cells(0).Value
                    dr_details("Weight") = dtg.Cells(2).Value

                    dr_details("Srl_SubmitUser") = Setting.Srl_User
                    dr_details("SubmitDate") = Setting.Now
                    If Not BaseDataObject.DataAccess.Insert(dr_details, False) Then
                        MessageBoxFa.Show("خطا در ثبت اطلاعات")
                        BaseDataObject.DataAccess.RollBack()
                        Return
                    End If
                Next
                If Not BaseDataObject.DataAccess.Commit Then
                    MessageBoxFa.Show("ثبت اطلاعات با مشكل مواجه شد")
                    'BaseDataObject.DataAccess.RollBack()
                Else


                    If Not Frm Is Nothing Then
                        Frm.txt_Number.Text = dr("Number")
                        Frm.btn_SearchWorkForm_Click(Nothing, Nothing)
                    ElseIf Not FrmMazad Is Nothing Then
                        FrmMazad.txt_Number.Text = dr("Number")
                        FrmMazad.btn_SearchWorkForm_Click(Nothing, Nothing)
                    End If
                    Me.Close()
                End If
            Else
                Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("pm_con_statusstatement", Srl_Edit)
                dr("Tarikh") = txt_tarikh.Value
                dr("SSNumber") = txt_SSNumber.Value
                Dim isholiday As Boolean = PublicFunction.IsHoliday(txt_tarikh.Value, 2)
                BaseDataObject.DataAccess.ExecQuery("Update pm_con_statusstatementitem set is_holiday=" + CInt(isholiday).ToString() + " where srl_statusstatement=" + Srl_Edit.ToString())
                dr("Srl_vahed") = Cmb_vahed.SelectedValue
                dr("Srl_Group") = cmb_Group.SelectedValue
                dr("Description") = txt_Description.Text
                If txt_DeviceSrl.Value <> "" Then
                    dr("srl_device") = txt_DeviceSrl.Value
                    dr("DeviceName") = txt_DeviceName.Value
                Else
                    dr("srl_device") = DBNull.Value
                    dr("DeviceName") = DBNull.Value

                End If
                dr("Srl_hazineCode") = cmb_HazineCode.SelectedValue
                If Cmb_vahed.SelectedValue = 76 Or Cmb_vahed.SelectedValue = 104 Or Cmb_vahed.SelectedValue = 105 Or Cmb_vahed.SelectedValue = 114 Then
                    dr("srl_line") = cmb_Line.SelectedValue
                Else
                    dr("Srl_post") = Cmb_Post.SelectedValue
                End If
                BaseDataObject.DataAccess.BeginTransaction()
                If Not BaseDataObject.DataAccess.Update(dr, 0) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
                BaseDataObject.DataAccess.ExecQuery("delete from Pm_con_StatusStatementDetail where srl_statusstatement=" + Srl_Edit.ToString())
                For Each dtg As DataGridViewRow In DGV_Person.Rows
                    Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_con_StatusStatementDetail")
                    dr_details("srl_StatusStatement") = Srl_Edit
                    dr_details("Srl_Ashkhas") = dtg.Cells(0).Value
                    dr_details("Weight") = dtg.Cells(2).Value

                    dr_details("Srl_SubmitUser") = Setting.Srl_User
                    dr_details("SubmitDate") = Setting.Now
                    If Not BaseDataObject.DataAccess.Insert(dr_details, False) Then
                        MessageBoxFa.Show("خطا در ثبت اطلاعات")
                        BaseDataObject.DataAccess.RollBack()
                        Return
                    End If
                Next
                If Not BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
                If Not Frm Is Nothing Then
                    Frm.txt_Number.Text = dr("Number")
                    Frm.btn_SearchWorkForm_Click(Nothing, Nothing)
                ElseIf Not FrmMazad Is Nothing Then
                    FrmMazad.txt_Number.Text = dr("Number")
                    FrmMazad.btn_SearchWorkForm_Click(Nothing, Nothing)
                End If
                Me.Close()
            End If
        Catch ex As Exception
            BaseDataObject.DataAccess.RollBack()
        End Try

    End Sub

    Private Sub Frm_RpNafarSatGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
           Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        Me.Pm_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Ashkhas)
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_HazineCodeTableAdapter.Fill(Me.Ds_Pm.Pm_HazineCode, 1)
        If Me.Ds_Pm.Pm_Vahed.Rows.Count > 0 Then
            Cmb_vahed.SelectedIndex = 0
        End If

        Try
            cmb_HazineCode.SelectedValue = Setting.Default_Code_Hazine.PropValue
        Catch ex As Exception
        End Try
        Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, Cmb_vahed.SelectedValue)
        cmb_Group_SelectedIndexChanged(Nothing, Nothing)
        If Srl_Edit = -1 Then
            Dim n As String = BaseDataObject.DataAccess.ExecScalar("select isnull(MAX(number),0) from Pm_Con_StatusStatement")
            txt_Number.Text = (CInt(n) + 1).ToString()
            If Cmb_vahed.SelectedValue = 76 Or Cmb_vahed.SelectedValue = 104 Or Cmb_vahed.SelectedValue = 105 Or Cmb_vahed.SelectedValue = 114 Then
                cmb_Line.Visible = True
                Cmb_Post.Visible = False
            Else
                Cmb_Post.Visible = True
                cmb_Line.Visible = False
            End If
            txt_tarikh.Value = Setting.TarikheJary
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("pm_con_statusstatement", Srl_Edit)
            If Not dr Is Nothing Then
                txt_Number.Text = dr("number")
                txt_SSNumber.Text = dr("ssnumber")
                txt_tarikh.Value = dr("Tarikh")
                txt_DeviceSrl.Value = dr("Srl_device")
                txt_DeviceName.Value = dr("DeviceName")
                If Not txt_DeviceSrl.Value Is Nothing AndAlso txt_DeviceSrl.Text <> "" Then
                    txt_DeviceName.Text = BaseDataObject.DataAccess.ExecScalar("select pm_tajhizname.name from pm_tajhizname join Pm_Hadese_KhesaratDevice on srl_pm_tajhizname=pm_tajhizname.srl where Pm_Hadese_KhesaratDevice.srl =" + txt_DeviceSrl.Text)
                End If
                cmb_HazineCode.SelectedValue = dr("Srl_hazinecode")
                Cmb_vahed.SelectedValue = dr("srl_vahed")
                If Cmb_vahed.SelectedValue = 76 Or Cmb_vahed.SelectedValue = 104 Or Cmb_vahed.SelectedValue = 105 Or Cmb_vahed.SelectedValue = 114 Then
                    cmb_Line.Visible = True
                    Cmb_Post.Visible = False
                    cmb_Line.SelectedValue = dr("srl_line")
                Else
                    Cmb_Post.Visible = True
                    cmb_Line.Visible = False
                    Cmb_Post.SelectedValue = dr("srl_post")
                End If
                txt_Description.Text = dr("description")
                cmb_Group.SelectedValue = dr("srl_group")
                DGV_Person.Rows.Clear()
                Me.Pm_con_StatusStatementDetailTableAdapter.Fill(Me.Ds_Con.Pm_con_StatusStatementDetail, Srl_Edit)
                If Not Me.Ds_Con.Pm_con_StatusStatementDetail Is Nothing Then
                    For Each dr1 As DataRow In Me.Ds_Con.Pm_con_StatusStatementDetail.Rows
                        Dim i As Integer = DGV_Person.Rows.Add()
                        DGV_Person.Rows(i).Cells(0).Value = dr1(0)
                        DGV_Person.Rows(i).Cells(1).Value = dr1(1)
                        DGV_Person.Rows(i).Cells(2).Value = dr1(2)
                    Next
                End If
            End If
        End If
    End Sub
   

    Private Sub Cmb_Vahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_vahed.SelectedIndexChanged
        If Not Cmb_vahed.SelectedValue Is Nothing Then
            Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, Cmb_vahed.SelectedValue.ToString)
            cmb_Group_SelectedIndexChanged(Nothing, Nothing)
            If Cmb_vahed.SelectedValue = 76 Or Cmb_vahed.SelectedValue = 104 Or Cmb_vahed.SelectedValue = 105 Or Cmb_vahed.SelectedValue = 114 Then
                PostOrKhat.Text = "خط"
                Cmb_Post.Visible = False
                cmb_Line.Visible = True
                Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
            Else
                PostOrKhat.Text = "پست"
                Cmb_Post.Visible = True
                cmb_Line.Visible = False
            End If

        End If
    End Sub

    Private Sub cmb_Group_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Group.SelectedIndexChanged
        If cmb_Group.SelectedValue Is Nothing Then
            Return
        End If
        Pm_GroupMemberTableAdapter.Fill(Ds_Pm.Pm_GroupMember, cmb_Group.SelectedValue.ToString, Nothing)
        DGV_Person.Rows.Clear()

        For Each dr As DataRow In Ds_Pm.Pm_GroupMember
            Dim i As Integer = DGV_Person.Rows.Add()
            DGV_Person.Rows(i).Cells(0).Value = dr(5)
            DGV_Person.Rows(i).Cells(1).Value = dr(2)
            DGV_Person.Rows(i).Cells(2).Value = dr(6)
        Next
    End Sub

    Private Sub Add_Person_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Person.Click
        For Each dr As DataGridViewRow In DGV_Person.Rows
            If dr.Cells(0).Value = cmb_Ashkhas.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DGV_Person.Rows.Add()
        DGV_Person.Rows(i).Cells(0).Value = cmb_Ashkhas.SelectedValue
        DGV_Person.Rows(i).Cells(1).Value = cmb_Ashkhas.Text
        DGV_Person.Rows(i).Cells(2).Value = BaseDataObject.DataAccess.ExecScalar("select isnull(weight,0) from pm_ashkhas where srl=" + cmb_Ashkhas.SelectedValue.ToString())
    End Sub

    Private Sub Del_Person_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del_Person.Click
        If Not DGV_Person.CurrentRow Is Nothing And DGV_Person.Rows.Count >= 1 Then
            DGV_Person.Rows.RemoveAt(DGV_Person.CurrentRow.Index)
        End If
    End Sub

    Private Sub btn_SelectDEvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectDEvice.Click
        If Not Cmb_Post.SelectedValue Is Nothing AndAlso Cmb_Post.SelectedValue > 1 Then
            Dim s As New Frm_DeviceSelect(Cmb_Post.SelectedValue)
            If s.ShowDialog() = DialogResult.Cancel Then
                Return
            End If
            If Not s.SelectedDevice Is Nothing Then
                txt_DeviceName.Value = s.SelectedDevice.Text
                txt_DeviceSrl.Value = s.SelectedDevice.Srl
            End If
        End If
    End Sub
End Class