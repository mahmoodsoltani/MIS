Public Class Frm_Con_StatusStatementMazad
    Private Srl_workform As Integer
    Private Srl_statusStatement As Integer
    Private srl_vahed As Integer
    Private IsHoliday = False
    Private doevent = True
    Private srl_contract As Integer
    Private srl_post As String
    Private IsRegister As Boolean = False

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        Me.Pm_Con_SourceTableAdapter.Fill(Me.Ds_Con.Pm_Con_Source)
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)
        srl_contract = cmb_Contract.SelectedValue
        doevent = False
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        If Srl_statusStatement > 0 Then
            Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, -1, Me.Srl_statusStatement, 2)
            Rb_NoWorkForm.Checked = True
        ElseIf Srl_workform > 0 Then
            Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, Me.Srl_workform, -1, 2)
            Rb_WorkForm.Checked = True
        End If
        If Me.Ds_Con.pm_con_statusStatementItem.Rows.Count > 0 Then
            Dim row As DataRow = Me.Ds_Con.pm_con_statusStatementItem.Rows(0)
            cmb_Contract.SelectedValue = CInt(row("srl_contract"))
            cmb_source.SelectedValue = CInt(row("srl_source"))
            txt_SSPM.Text = row("SSPM").ToString()
        Else
            txt_SSPM.Text = ""
        End If
        If Srl_statusStatement > 0 Then
            CheckRegister(Srl_statusStatement)
        ElseIf Srl_workform > 0 Then
            CheckRegister(Srl_workform)
        End If
        If Me.Srl_workform > 0 Then
            doevent = False
            btn_AddSS.Visible = False
            btn_EditSS.Visible = False
            doevent = True
            Me.Pm_con_WorkformTableAdapter.Fill(Me.Ds_Con.pm_con_Workform, -1, Me.Srl_workform)
            If Not Me.Ds_Con.pm_con_Workform Is Nothing And Me.Ds_Con.pm_con_Workform.Rows.Count > 0 Then
                Dim dr As DataRow = Me.Ds_Con.pm_con_Workform.Rows(0)
                txt_Number.Text = dr("شماره").ToString()
                txt_Date.Value = dr("تاریخ").ToString()
                txt_Group.Text = dr("نام گروه").ToString()
                txt_unit.Text = dr("نام واحد").ToString()
                srl_post = dr("srl_pm_post").ToString()
                txt_post.Text = dr("نام پست").ToString()
                srl_vahed = CInt(dr("Srl_pm_Vahed").ToString())
                txt_FactorPrice.Text = BaseDataObject.DataAccess.ExecScalar("select isnull(factorprice,0) from pm_workform_master where srl=" + Srl_workform.ToString())
                Srl_workform = dr("srl")
                cmb_code.Focus()
            End If
        ElseIf Me.Srl_statusStatement > 0 Then
            doevent = False
            doevent = True
            Me.Pm_Con_StatusStatementTableAdapter1.Fill(Me.Ds_Con.Pm_Con_StatusStatement, -1, Me.Srl_statusStatement)
            If Not Me.Ds_Con.Pm_Con_StatusStatement Is Nothing And Me.Ds_Con.Pm_Con_StatusStatement.Rows.Count > 0 Then
                Dim dr As DataRow = Me.Ds_Con.Pm_Con_StatusStatement.Rows(0)
                txt_Number.Text = dr("شماره").ToString()
                txt_Date.Value = dr("تاریخ").ToString()
                txt_Group.Text = dr("نام گروه").ToString()
                txt_unit.Text = dr("نام واحد").ToString()
                srl_post = dr("srl_post").ToString()

                txt_post.Text = dr("نام پست").ToString()
                If Not IsDBNull(dr("srl_post")) Then
                    txt_post.Text = dr("نام پست").ToString()
                    PostOrKhat.Text = "پست"
                End If
                If Not IsDBNull(dr("srl_line")) Then
                    txt_post.Text = dr("نام خط").ToString()
                    PostOrKhat.Text = "خط"
                End If
                srl_vahed = CInt(dr("Srl_Vahed").ToString())
                Srl_statusStatement = dr("srl")
                txt_FactorPrice.Text = BaseDataObject.DataAccess.ExecScalar("select isnull(factorprice,0) from Pm_Con_StatusStatement where srl=" + Srl_statusStatement.ToString())

                cmb_code.Focus()
            End If
        Else
            Rb_WorkForm.Checked = True
            btn_AddSS.Visible = False
            btn_EditSS.Visible = False
            txt_Number.Focus()
        End If
        If Not cmb_Contract.SelectedValue Is Nothing Then
            Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, srl_vahed, cmb_Contract.SelectedValue, 2)
        End If
        'Me.Pm_con_ContractItemsTarikhTableAdapter.Fill(Me.Ds_Con.pm_con_ContractItemsTarikh, txt_Date.Value, srl_vahed, False)
        CalcZarib()
        CalcAmount()
        doevent = True
    End Sub
    Public Sub CheckRegister(ByVal FrmNo As Integer)

        Dim month As String = ""
        Dim year As String = ""
        Dim srl_contract As Integer = cmb_Contract.SelectedValue
        Dim srl_source As Integer = cmb_source.SelectedValue
        Dim srl_vahed As Integer = -1
        Dim sstype As Integer = 1
        Dim Srl_Pm_PostType As Integer = -1

        If Rb_WorkForm.Checked Then
            Me.Pm_con_WorkformTableAdapter.Fill(Me.Ds_Con.pm_con_Workform, -1, FrmNo)
            If Not Me.Ds_Con.pm_con_Workform Is Nothing And Me.Ds_Con.pm_con_Workform.Rows.Count > 0 Then
                Dim dr As DataRow = Me.Ds_Con.pm_con_Workform.Rows(0)
                month = CInt(dr("تاریخ").ToString().Substring(5, 2))
                year = dr("تاریخ").ToString().Substring(0, 4)
                srl_vahed = CInt(dr("srl_pm_vahed"))
                Srl_Pm_PostType = CInt(BaseDataObject.DataAccess.ExecScalar("select Srl_Pm_PostType from Pm_PostDetails where Srl_Pm_Post= " + dr("srl_pm_post").ToString()))
            End If
        Else
            Me.Pm_Con_StatusStatementTableAdapter1.Fill(Me.Ds_Con.Pm_Con_StatusStatement, -1, FrmNo)
            If Not Me.Ds_Con.Pm_Con_StatusStatement Is Nothing And Me.Ds_Con.Pm_Con_StatusStatement.Rows.Count > 0 Then
                Dim dr As DataRow = Me.Ds_Con.Pm_Con_StatusStatement.Rows(0)
                month = CInt(dr("تاریخ").ToString().Substring(5, 2))
                year = dr("تاریخ").ToString().Substring(0, 4)
                srl_vahed = CInt(dr("srl_vahed"))
                If Not IsDBNull(dr("srl_post")) Then
                    Srl_Pm_PostType = CInt(BaseDataObject.DataAccess.ExecScalar("select isnull(Srl_Pm_PostType,1) from Pm_PostDetails where Srl_Pm_Post= " + dr("srl_post").ToString()))
                End If
                If Not IsDBNull(dr("srl_line")) Then
                    Srl_Pm_PostType = CInt(BaseDataObject.DataAccess.ExecScalar("select Srl_Pm_PostType from Pm_line where Srl= " + dr("srl_line").ToString()))
                End If
            End If
        End If
        Dim query As String = "select * from pm_con_monthreport where " & _
        "[MONTH]=" + month + " and [year]=" + year + " and Srl_Pm_PostType =" + Srl_Pm_PostType.ToString() & _
        " and Srl_Pm_Vahed =" + srl_vahed.ToString() + " and Srl_Pm_Con_source =" + srl_source.ToString() + " and Srl_Con_Contract =" + srl_contract.ToString() & _
        " and srl_statusstatementtype =" + sstype.ToString()
        Dim newdr As DataRow = BaseDataObject.DataAccess.GetRow(query)
        If Not newdr Is Nothing AndAlso newdr("srl").ToString() <> "" Then
            IsRegister = True
            MessageBoxFa.Show("امکان ویرایش و یا اضافه کردن آیتم جدید برای این صورت وضعیت وجود ندارد")
            btn_Add.Enabled = False
        Else
            btn_Add.Enabled = True
            IsRegister = False
        End If
    End Sub
    Public Sub New(ByVal srl_workform As Integer, ByVal srl_statusstatement As Integer)

        InitializeComponent()
        Me.Srl_workform = srl_workform
        Me.Srl_statusStatement = srl_statusstatement


    End Sub
    Public Overrides Sub LoadDataGridView()
        Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, Me.Srl_workform, -1, 2)
        Me.Pm_Con_SourceTableAdapter.Fill(Me.Ds_Con.Pm_Con_Source)

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)

        If Not DataGridView1.SelectedCells Is Nothing Then
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
                If IsRegister Then
                    MessageBoxFa.Show("امکان ویرایش وجود ندارد")
                    Return
                End If
                If e.ColumnIndex = 16 Then

                    BaseDataObject.DataAccess.ExecQuery("update pm_con_statusstatementitem set Amount = Amount+1 ,confirm_price=(confirm_Amount+1)*price, confirm_Amount = confirm_Amount+1 where srl = " + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
                ElseIf e.ColumnIndex = 17 Then
                    If CDbl(DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()) < 1 Then
                        BaseDataObject.DataAccess.ExecQuery("delete from pm_con_statusstatementitem where srl = " + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
                    Else
                        BaseDataObject.DataAccess.ExecQuery("update pm_con_statusstatementitem set Amount = Amount-1 ,confirm_price=(confirm_Amount-1)*price, confirm_Amount = confirm_Amount-1 where srl = " + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString() + " delete from pm_con_statusstatementitem where Amount=0")
                    End If
                ElseIf e.ColumnIndex = 18 Then
                    BaseDataObject.DataAccess.ExecQuery("delete from pm_con_statusstatementitem where srl = " + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())

                End If
                If Srl_statusStatement <> -1 Then
                    Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, -1, Me.Srl_statusStatement, 2)
                ElseIf Srl_workform <> -1 Then
                    Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, Me.Srl_workform, -1, 2)
                End If
                cmb_code.Focus()
                CalcAmount()
                CalcZarib()
            End If
        End If
    End Sub
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        If cmb_code.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا یک آیتم را انتخاب نمائید")
            cmb_code.Focus()
            Return
        End If
        If txt_Amount.Text = "" Then
            MessageBoxFa.Show("لطفا تعداد را مشخص نمائید")
            txt_Amount.Focus()
            Return
        End If
        Dim result() As DataRow = Me.Ds_Con.pm_con_statusStatementItem.Select("کد='" + cmb_code.Text.ToString() + "'")
        If Not result Is Nothing And result.Length > 0 Then
            result(0).Item("تعداد") = CDbl(result(0).Item("تعداد")) + CDbl(txt_Amount.Text)
            If Srl_statusStatement > 0 Then
                BaseDataObject.DataAccess.ExecQuery("update pm_con_statusstatementitem set amount = " + result(0).Item("تعداد").ToString() + " ,confirm_amount= " + result(0).Item("تعداد").ToString() + " , confirm_price= round(price*" + result(0).Item("تعداد").ToString() + ",0) , description='" + txt_Description.Text + "' where Srl_StatusStatement=" + Srl_statusStatement.ToString() + " and srl_contractItem=" + cmb_code.SelectedValue.ToString())
                Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, -1, Me.Srl_statusStatement, 2)
            ElseIf Srl_workform > 0 Then
                BaseDataObject.DataAccess.ExecQuery("update pm_con_statusstatementitem set amount = " + result(0).Item("تعداد").ToString() + " ,confirm_amount= " + result(0).Item("تعداد").ToString() + " , confirm_price= round(price*" + result(0).Item("تعداد").ToString() + ",0)  , description='" + txt_Description.Text + "' where Srl_workform_master=" + Srl_workform.ToString() + " and srl_contractItem=" + cmb_code.SelectedValue.ToString())
                Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, Srl_workform, -1, 2)


            End If
            CalcZarib()
            CalcAmount()

            Return
        End If

        If Rb_WorkForm.Checked Then
            If Me.Srl_workform < 1 Then
                MessageBoxFa.Show("فرم کار انتخاب نشده است!")
                Return
            Else
                Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("pm_con_statusstatementitem")
                dr("Srl_workform_master") = Srl_workform
                dr("srl_contractItem") = cmb_code.SelectedValue
                dr("Amount") = txt_Amount.Text
                dr("is_confirme") = 1
                dr("Is_Holiday") = IsHoliday
                dr("is_cancle") = 0
                dr("Is_Beforecancle") = 0
                dr("Is_Night") = 0
                dr("Description") = txt_Description.Text
                dr("srl_source") = cmb_source.SelectedValue
                dr("SSPM") = txt_SSPM.Text
                dr("Price") = BaseDataObject.DataAccess.ExecScalar("select isnull(Price,0) from Pm_Con_ContractItems where srl= " + cmb_code.SelectedValue.ToString())
                dr("calcprice") = dr("Price")
                dr("confirm_price") = dr("Price") * dr("Amount")
                dr("Confirm_Amount") = dr("Amount")
                BaseDataObject.DataAccess.Insert(dr, False)
                Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, Me.Srl_workform, -1, 2)
                txt_Description.Text = ""
                cmb_code.Focus()
            End If
        Else
            If Me.Srl_statusStatement < 1 Then
                MessageBoxFa.Show("صورت وضعیت انتخاب نشده است!")
                Return
            Else
                Dim dr1 As DataRow = BaseDataObject.DataAccess.NewRow("pm_con_statusstatementitem")
                dr1("Srl_StatusStatement") = Srl_statusStatement
                dr1("srl_contractItem") = cmb_code.SelectedValue
                dr1("Amount") = txt_Amount.Text
                dr1("is_confirme") = 1
                dr1("Is_Holiday") = IsHoliday
                dr1("is_cancle") = 0
                dr1("Is_Beforecancle") = 0
                dr1("Is_Night") = 0
                dr1("Description") = txt_Description.Text
                dr1("srl_source") = cmb_source.SelectedValue
                dr1("SSPM") = txt_SSPM.Text
                dr1("Price") = BaseDataObject.DataAccess.ExecScalar("select isnull(Price,0) from Pm_Con_ContractItems where srl= " + cmb_code.SelectedValue.ToString())
                dr1("calcprice") = dr1("Price")
                dr1("confirm_price") = dr1("Price") * dr1("Amount")
                dr1("Confirm_Amount") = dr1("Amount")
                BaseDataObject.DataAccess.Insert(dr1, False)
                Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, -1, Me.Srl_statusStatement, 2)
                cmb_code.Focus()
            End If

        End If
        CalcAmount()
        CalcZarib()
    End Sub
    Private Sub btn_Before_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Before.Click
        If txt_Number.Value <> "" Then
            NextOrBeforeForm(False)
        Else
            If Rb_WorkForm.Checked Then
                MessageBox.Show("شماره فرم کار را وارد نمائید")
            Else
                MessageBox.Show("شماره صورت وضعیت را وارد نمائید")
            End If
            txt_Number.Focus()
        End If
    End Sub
    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click
        If txt_Number.Value <> "" Then
            NextOrBeforeForm(True)
        Else
            If Rb_WorkForm.Checked Then
                MessageBox.Show("شماره فرم کار را وارد نمائید")
            Else
                MessageBox.Show("شماره صورت وضعیت را وارد نمائید")
            End If
            txt_Number.Focus()
        End If
    End Sub
    Public Sub NextOrBeforeForm(ByVal Flag As Boolean)
        doevent = False
        Dim FrmNo As Integer
        If Flag Then
            If Rb_WorkForm.Checked Then
                FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_WorkForm_Master where cast(No as int) >" + txt_Number.Value + " Order by no "))
            Else
                FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_con_statusStatement where cast(Number as int) >" + txt_Number.Value + " Order by Number "))
            End If
        Else
            If Rb_WorkForm.Checked Then
                FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_WorkForm_Master where cast(No as int) <" + txt_Number.Value + " Order by no desc"))
            Else
                FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_con_statusStatement where cast(Number as int) <" + txt_Number.Value + " Order by Number desc"))
            End If
        End If
        If FrmNo > 0 Then
            If Rb_WorkForm.Checked Then
                Me.Srl_workform = FrmNo
                Me.Pm_con_WorkformTableAdapter.Fill(Me.Ds_Con.pm_con_Workform, -1, Me.Srl_workform)
                If Not Me.Ds_Con.pm_con_Workform Is Nothing And Me.Ds_Con.pm_con_Workform.Rows.Count > 0 Then
                    Dim dr As DataRow = Me.Ds_Con.pm_con_Workform.Rows(0)
                    txt_Number.Text = dr("شماره").ToString()
                    txt_Date.Value = dr("تاریخ").ToString()
                    txt_Group.Text = dr("نام گروه").ToString()
                    txt_unit.Text = dr("نام واحد").ToString()
                    srl_vahed = CInt(dr("srl_pm_vahed"))
                    srl_post = dr("srl_pm_post").ToString()
                    txt_post.Text = dr("نام پست").ToString()
                    Srl_workform = CInt(dr("srl"))
                    txt_FactorPrice.Text = BaseDataObject.DataAccess.ExecScalar("select isnull(factorprice,0) from pm_workform_master where srl=" + Srl_workform.ToString())
                    Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, Me.Srl_workform, -1, 2)
                    If Me.Ds_Con.pm_con_statusStatementItem.Rows.Count > 0 Then
                        Dim row As DataRow = Me.Ds_Con.pm_con_statusStatementItem.Rows(0)
                        cmb_Contract.SelectedValue = CInt(row("srl_contract"))
                        cmb_source.SelectedValue = CInt(row("srl_source"))
                        txt_SSPM.Text = row("SSPM").ToString()
                    Else
                        txt_SSPM.Text = ""
                    End If
                    cmb_code.Focus()

                End If
            Else
                Me.Srl_statusStatement = FrmNo
                Me.Pm_Con_StatusStatementTableAdapter1.Fill(Me.Ds_Con.Pm_Con_StatusStatement, -1, Me.Srl_statusStatement)
                If Not Me.Ds_Con.Pm_Con_StatusStatement Is Nothing And Me.Ds_Con.Pm_Con_StatusStatement.Rows.Count > 0 Then
                    Dim dr As DataRow = Me.Ds_Con.Pm_Con_StatusStatement.Rows(0)
                    txt_Number.Text = dr("شماره").ToString()
                    txt_Date.Value = dr("تاریخ").ToString()
                    txt_Group.Text = dr("نام گروه").ToString()
                    txt_unit.Text = dr("نام واحد").ToString()
                    srl_post = dr("srl_post").ToString()
                    If Not IsDBNull(dr("srl_post")) Then
                        txt_post.Text = dr("نام پست").ToString()
                        PostOrKhat.Text = "پست"
                    End If
                    If Not IsDBNull(dr("srl_line")) Then
                        txt_post.Text = dr("نام خط").ToString()
                        PostOrKhat.Text = "خط"
                    End If
                    Srl_statusStatement = dr("srl")
                    txt_FactorPrice.Text = BaseDataObject.DataAccess.ExecScalar("select isnull(factorprice,0) from Pm_Con_StatusStatement where srl=" + Srl_statusStatement.ToString())
                    srl_vahed = CInt(dr("srl_vahed"))
                    Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, -1, Me.Srl_statusStatement, 2)
                    If Me.Ds_Con.pm_con_statusStatementItem.Rows.Count > 0 Then
                        Dim row As DataRow = Me.Ds_Con.pm_con_statusStatementItem.Rows(0)
                        cmb_Contract.SelectedValue = CInt(row("srl_contract"))
                        cmb_source.SelectedValue = CInt(row("srl_source"))
                        txt_SSPM.Text = row("SSPM").ToString()
                    Else
                        txt_SSPM.Text = ""
                    End If
                    cmb_code.Focus()
                End If

            End If
            If Not cmb_Contract.SelectedValue Is Nothing Then
                Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, srl_vahed, cmb_Contract.SelectedValue, 2)
            End If
            'Me.Pm_con_ContractItemsTarikhTableAdapter.Fill(Me.Ds_Con.pm_con_ContractItemsTarikh, txt_Date.Value, srl_vahed, False)
            CheckRegister(FrmNo)
        Else
            MessageBox.Show("موردي يافت نشد")
        End If
        doevent = True
        CalcAmount()
        CalcZarib()
    End Sub
    Private Sub Rb_WorkForm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_WorkForm.CheckedChanged
        If doevent Then
            Srl_statusStatement = 0
            Srl_workform = 0
            btn_AddSS.Visible = Rb_NoWorkForm.Checked
            btn_EditSS.Visible = Rb_NoWorkForm.Checked
            txt_Group.Text = ""
            txt_Date.Text = ""
            txt_post.Text = ""
            txt_unit.Text = ""
            txt_Number.Text = ""
            txt_SSPM.Text = ""
            txt_FactorPrice.Text = "0"

            If Not cmb_Contract.SelectedValue Is Nothing Then
                Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, srl_vahed, cmb_Contract.SelectedValue, 2)
            End If
            'Me.Pm_con_ContractItemsTarikhTableAdapter.Fill(Me.Ds_Con.pm_con_ContractItemsTarikh, VB_Component.FarsiDateFun.Now(), srl_vahed, False)
            Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, -2, -2, 2)
        End If
    End Sub
    Private Sub txt_Date_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Date.TextChanged, txt_Date.ValueChanged
        If PublicFunction.IsHoliday(txt_Date.Value, 2) Then
            lb_Holiday.Text = "تعطیل"
            IsHoliday = True
        Else
            lb_Holiday.Text = ""
            IsHoliday = False
        End If
    End Sub
    Private Sub UpdateOmoor()
        If srl_post <> "" Then
            lb_omoor.Text = "امور: " + BaseDataObject.DataAccess.ExecScalar("select isnull(name,'-')as name from Pm_PostDetails left join Pm_PostType on Srl_Pm_PostType = Pm_PostType .Srl where Srl_Pm_Post =" + srl_post)
        Else
            lb_omoor.Text = "امور:-"
        End If
    End Sub
    Public Sub btn_SearchWorkForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SearchWorkForm.Click
        Try
            doevent = False
            If txt_Number.Text <> "" Then
                If Rb_WorkForm.Checked Then
                    Me.Pm_con_WorkformTableAdapter.Fill(Me.Ds_Con.pm_con_Workform, txt_Number.Text, -1)
                    If Not Me.Ds_Con.pm_con_Workform Is Nothing And Me.Ds_Con.pm_con_Workform.Rows.Count > 0 Then
                        Dim dr1 As DataRow = Me.Ds_Con.pm_con_Workform.Rows(0)

                        Dim dr As DataRow = Me.Ds_Con.pm_con_Workform.Rows(0)
                        'CheckRegister(CInt(dr("srl")))
                        txt_Number.Text = dr("شماره").ToString()
                        txt_Date.Value = dr("تاریخ").ToString()
                        txt_Group.Text = dr("نام گروه").ToString()
                        txt_unit.Text = dr("نام واحد").ToString()
                        srl_vahed = CInt(dr("srl_pm_vahed"))
                        srl_post = dr("srl_pm_post").ToString()
                        Srl_workform = dr("srl")
                        txt_post.Text = dr("نام پست").ToString()
                        txt_FactorPrice.Text = BaseDataObject.DataAccess.ExecScalar("select isnull(factorprice,0) from pm_workform_master where srl=" + Srl_workform.ToString())
                        Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, Me.Srl_workform, -1, 2)
                        If Me.Ds_Con.pm_con_statusStatementItem.Rows.Count > 0 Then
                            Dim row As DataRow = Me.Ds_Con.pm_con_statusStatementItem.Rows(0)
                            cmb_Contract.SelectedValue = CInt(row("srl_contract"))
                            cmb_source.SelectedValue = CInt(row("srl_source"))
                            txt_SSPM.Text = row("SSPM").ToString()
                        Else
                            txt_SSPM.Text = ""
                        End If
                        cmb_code.Focus()
                        CheckRegister(CInt(dr1("srl")))
                    Else
                        MessageBoxFa.Show("فرم کاری با این شماره پیدا نشد")
                        Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, -1, 0, 2)

                        txt_Group.Text = ""
                        txt_unit.Text = ""
                        txt_post.Text = ""
                        txt_SSPM.Text = ""
                        Srl_workform = -1
                        txt_Number.Focus()

                    End If
                Else
                    Me.Pm_Con_StatusStatementTableAdapter1.Fill(Me.Ds_Con.Pm_Con_StatusStatement, CInt(txt_Number.Text), -1)
                    If Not Me.Ds_Con.Pm_Con_StatusStatement Is Nothing And Me.Ds_Con.Pm_Con_StatusStatement.Rows.Count > 0 Then
                        Dim dr1 As DataRow = Me.Ds_Con.Pm_Con_StatusStatement.Rows(0)

                        Dim dr As DataRow = Me.Ds_Con.Pm_Con_StatusStatement.Rows(0)
                        txt_Number.Text = dr("شماره").ToString()
                        txt_Date.Value = dr("تاریخ").ToString()
                        txt_Group.Text = dr("نام گروه").ToString()
                        txt_unit.Text = dr("نام واحد").ToString()
                        txt_post.Text = dr("نام پست").ToString()
                        srl_vahed = CInt(dr("srl_vahed"))
                        srl_post = dr("srl_post").ToString()
                        If Not IsDBNull(dr("srl_post")) Then
                            txt_post.Text = dr("نام پست").ToString()
                            PostOrKhat.Text = "پست"
                        End If
                        If Not IsDBNull(dr("srl_line")) Then
                            txt_post.Text = dr("نام خط").ToString()
                            PostOrKhat.Text = "خط"
                        End If
                        Srl_statusStatement = dr("srl")
                        txt_FactorPrice.Text = BaseDataObject.DataAccess.ExecScalar("select isnull(factorprice,0) from Pm_Con_StatusStatement where srl=" + Srl_statusStatement.ToString())
                        Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, -1, Me.Srl_statusStatement, 2)
                        If Me.Ds_Con.pm_con_statusStatementItem.Rows.Count > 0 Then
                            Dim row As DataRow = Me.Ds_Con.pm_con_statusStatementItem.Rows(0)
                            cmb_Contract.SelectedValue = CInt(row("srl_contract"))
                            cmb_source.SelectedValue = CInt(row("srl_source"))
                            txt_SSPM.Text = row("SSPM").ToString()
                        Else
                            txt_SSPM.Text = ""
                        End If
                        cmb_code.Focus()
                        CheckRegister(CInt(dr1("srl")))
                    Else
                        MessageBoxFa.Show("صورت وضعیتی با این شماره وجود ندارد شما می توانید صورت وضعیت جدیدی ثبت نمائید")
                        Me.Pm_con_statusStatementTableAdapter.Fill(Me.Ds_Con.pm_con_statusStatementItem, -1, 0, 2)

                        Srl_statusStatement = -1
                        txt_Group.Text = ""
                        txt_unit.Text = ""
                        txt_post.Text = ""
                        txt_SSPM.Text = ""
                        txt_Number.Focus()
                    End If
                End If
            Else
                MessageBoxFa.Show("لطفا شماره را وارد نمائید")
            End If
            If Not cmb_Contract.SelectedValue Is Nothing Then
                Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, srl_vahed, cmb_Contract.SelectedValue, 2)
            End If
            'Me.Pm_con_ContractItemsTarikhTableAdapter.Fill(Me.Ds_Con.pm_con_ContractItemsTarikh, txt_Date.Value, srl_vahed, False)
            doevent = True
            CalcZarib()
            CalcAmount()
            UpdateOmoor()
        Catch
            MessageBoxFa.Show("موردی یافت نشد")
        End Try

    End Sub
    Private Sub Frm_Con_StatusStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Con.Pm_Con_Contract' table. You can move, or remove it, as needed.
        Me.Pm_Con_ContractTableAdapter.Fill(Me.Ds_Con.Pm_Con_Contract)

        Me.WorkForm_MasterTableAdapter.Fill(Me.Ds_Pm.WorkForm_Master)

    End Sub
    Private Sub btn_AddSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddSS.Click
        Dim f As New Frm_Con_AddStatusStatement(Me)
        f.ShowDialog()
    End Sub
    Private Sub CalcZarib()
        Dim sum As Double = 0
        Dim sumConfirm As Double = 0
        For Each dr As DataRow In Me.Ds_Con.pm_con_statusStatementItem.Rows
            sum += Math.Truncate(CInt(dr("قیمت")) * CDbl(dr("تعداد")))
            sumConfirm += Math.Truncate(CInt(dr("Confirm_Price")))
        Next
        txt_all.Text = sum.ToString()
        txt_AllConfirm.Text = sumConfirm.ToString()
        txt_FactorPrice_Leave(Nothing, Nothing)
    End Sub
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub Pl_WorkForm_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Pl_WorkForm.Paint

    End Sub
    Private Sub txt_post_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_post.TextChanged
        If srl_post <> "" Then
            lb_omoor.Text = "امور: " + BaseDataObject.DataAccess.ExecScalar("select isnull(name,'-')as name from Pm_PostDetails left join Pm_PostType on Srl_Pm_PostType = Pm_PostType .Srl where Srl_Pm_Post =" + srl_post)
        Else
            lb_omoor.Text = "امور:-"
        End If
    End Sub
    Private Sub CalcAmount()
        Me.Pm_Con_UsedItemTableAdapter.Fill(Me.Ds_Con.Pm_Con_UsedItem, cmb_code.SelectedValue)
        If Me.Ds_Con.Pm_Con_UsedItem.Rows.Count > 0 Then
            lb_amount.Text = Me.Ds_Con.Pm_Con_UsedItem.Rows(0)(1).ToString + "/" + Me.Ds_Con.Pm_Con_UsedItem.Rows(0)(0).ToString

        End If
    End Sub
    Private Sub cmb_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_code.SelectedIndexChanged
        'Dim query As String = "select isnull(Amount,0) as amount  from Pm_Con_ContractItems right join Pm_Con_Contract on Srl_Contract = Pm_Con_Contract .srl and StartDate<'" + VB_Component.FarsiDateFun.Now() + "' and EndDate>'" + VB_Component.FarsiDateFun.Now() + "' and Srl_Item=" + cmb_code.SelectedValue.ToString()
        'lb_amount.Text = BaseDataObject.DataAccess.ExecScalar(query)
        CalcAmount()
    End Sub
    Private Sub txt_Number_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Number.KeyDown
        If e.KeyCode = 13 Then
            btn_SearchWorkForm_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        If chk_all.Checked Then
            If Not cmb_Contract.SelectedValue Is Nothing Then
                Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, -1, cmb_Contract.SelectedValue, 2)
            End If
            'Me.Pm_con_ContractItemsTarikhTableAdapter.Fill(Me.Ds_Con.pm_con_ContractItemsTarikh, txt_Date.Value, -1, False)
        Else
            If Not cmb_Contract.SelectedValue Is Nothing Then
                Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, srl_vahed, cmb_Contract.SelectedValue, 2)
            End If
            ' Me.Pm_con_ContractItemsTarikhTableAdapter.Fill(Me.Ds_Con.pm_con_ContractItemsTarikh, txt_Date.Value, srl_vahed, False)
        End If

    End Sub
    Private Sub Rb_NoWorkForm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_NoWorkForm.CheckedChanged

    End Sub
    Private Sub cmb_source_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_source.SelectedIndexChanged
        Dim where As String = ""
        If Srl_workform > 0 Then
            where = " srl_workform_master=" + Srl_workform.ToString()
        ElseIf Srl_statusStatement > 0 Then
            where = " srl_statusstatement=" + Srl_statusStatement.ToString()
        Else
            Return
        End If
        BaseDataObject.DataAccess.ExecQuery("update Pm_Con_StatusStatementItem set srl_source=" + cmb_source.SelectedValue.ToString() + " where " + where)
    End Sub
    Private Sub btn_EditSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EditSS.Click
        If Srl_statusStatement > 0 Then
            Dim s As New Frm_Con_AddStatusStatement(Me, Srl_statusStatement)
            s.ShowDialog()
        End If
    End Sub
    Private Sub cmb_Contract_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Contract.SelectedIndexChanged
        If doevent Then
            If DataGridView1.Rows.Count > 0 Then
                If MessageBoxFa.Show("برای این صورت وضعیت قبلا در یک قرارداد دیگر آیتم ثبت شده است. با تغییر قرارداد این آیتم ها حذف می شوند. آیا مایل به ادامه هستید؟", "هشدار", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    If Srl_statusStatement > 0 Then
                        BaseDataObject.DataAccess.ExecQuery("delete from  pm_con_statusstatementitem where Srl_StatusStatement=" + Srl_statusStatement.ToString() + " and srl_contractItem=" + cmb_code.SelectedValue.ToString())
                    ElseIf Srl_workform > 0 Then
                        BaseDataObject.DataAccess.ExecQuery("delete from pm_con_statusstatementitem  where Srl_workform_master=" + Srl_workform.ToString() + " and srl_contractItem=" + cmb_code.SelectedValue.ToString())
                    End If
                    CalcAmount()
                    CalcZarib()
                    srl_contract = cmb_Contract.SelectedValue

                End If
                doevent = False
                cmb_Contract.SelectedValue = srl_contract
                doevent = True
            End If
        End If
        If Not cmb_Contract.SelectedValue Is Nothing Then
            Me.Pm_Con_ContractItemsTableAdapter.Fill(Me.Ds_Con.Pm_Con_ContractItems, srl_vahed, cmb_Contract.SelectedValue, 2)
        End If
    End Sub
    Private Sub DataGridView1_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
        If e.ColumnIndex = 6 Or e.ColumnIndex = 7 And e.RowIndex >= 0 Then
            DataGridView1.EndEdit()
            If DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString() = "" Then
                DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0
            End If
            If DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString() = "" Then
                DataGridView1.Rows(e.RowIndex).Cells(7).Value = 0
            End If
            If e.ColumnIndex = 6 Then
                DataGridView1.Rows(e.RowIndex).Cells(7).Value = Math.Truncate(CDbl(DataGridView1.Rows(e.RowIndex).Cells(6).Value) * CDbl(DataGridView1.Rows(e.RowIndex).Cells(4).Value))
            End If
            If e.ColumnIndex = 7 Then
                DataGridView1.Rows(e.RowIndex).Cells(6).Value = Math.Round(CDbl(DataGridView1.Rows(e.RowIndex).Cells(7).Value) / CDbl(DataGridView1.Rows(e.RowIndex).Cells(4).Value), 2)
            End If
            BaseDataObject.DataAccess.ExecQuery("update Pm_Con_StatusStatementitem set confirm_price= " + DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString() + " , confirm_amount=" + DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString() + " where srl = " + DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
            CalcZarib()
        Else
            DataGridView1.CancelEdit()
        End If
    End Sub
    Private Sub txt_FactorPrice_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FactorPrice.Leave
        If Not doevent Then
            Return
        End If
        Try
            If txt_all.Text = "" Or txt_FactorPrice.Text = "" Then
                Return
            End If
            If CDbl(txt_all.Value) < CDbl(txt_FactorPrice.Value) Then
                MessageBoxFa.Show("مبلغ فاکتور نمی تواند از مبلغ کل صورت وضعیت بیشتر باشد")
                txt_FactorPrice.Focus()
                Return
            End If
            Dim percentage As Double
            If CDbl(txt_all.Value) > 0 Then
                percentage = Math.Round(CDbl(txt_FactorPrice.Value) * 100 / CDbl(txt_all.Value), 2)
            End If
            Dim query As String
            If Srl_statusStatement > 0 Then
                query = "update pm_con_statusstatement set FactorPrice=" + txt_FactorPrice.Value.ToString() + " where srl=" + Srl_statusStatement.ToString()
                query += " update pm_con_statusstatementitem set FactorPercentage=" + percentage.ToString() + " where srl_StatusStatement=" + Srl_statusStatement.ToString()
            ElseIf Srl_workform > 0 Then
                query = "update pm_workform_master set FactorPrice=" + txt_FactorPrice.Value.ToString() + " where srl=" + Srl_workform.ToString()
                query += " update pm_con_statusstatementitem set FactorPercentage=" + percentage.ToString() + " where Srl_workform_master=" + Srl_workform.ToString()
            Else
                Return
            End If
            BaseDataObject.DataAccess.ExecQuery(query)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_SSPM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SSPM.TextChanged
        If Not doevent Then
            Return
        End If
        If IsRegister Then
            MessageBoxFa.Show("امکان ویرایش وجود ندارد")
            Return
        End If
        Dim where As String = ""
        If Srl_workform > 0 Then
            where = "srl_workform_master=" + Srl_workform.ToString()
        ElseIf Srl_statusStatement > 0 Then
            where = "srl_statusstatement=" + Srl_statusStatement.ToString()
        Else
            Return
        End If
        BaseDataObject.DataAccess.ExecQuery("update Pm_Con_StatusStatementItem set SSPM='" + txt_SSPM.Text + "' where " + where)
    End Sub
End Class