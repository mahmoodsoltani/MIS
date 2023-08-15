Public Class Frm_DarkhasteKar
    Dim Srl_Tajhiz As Integer
    Dim Srl_Pm_DarkhasteKar As Integer

    Public Sub New(ByVal Srl_Pm_DarkhasteKar As Integer)
        InitializeComponent()
        Me.Srl_Pm_DarkhasteKar = Srl_Pm_DarkhasteKar
    End Sub
    Private Sub Frm_DarkhasteKar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Acc_Ashkhas' table. You can move, or remove it, as needed.
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.cmb_Sarparast.DataSource = Me.AccAshkhasBindingSource
        Me.cmb_Sarparast.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Sarparast.ValueMember = "Srl"

        txt_NoSamak.Focus()
        If Srl_Pm_DarkhasteKar = -2 Then


            txtNo.Value = getMaxOfNo()
            If txtNo.Value = 1 Then
                txtNo.Value = 1001
            End If


            Txt_Tarikh_Sabt.Value = Setting.TarikheJary
        Else

            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_DarkhasteKar", Srl_Pm_DarkhasteKar)


            txtNo.Value = dr("No")
            Txt_Tarikh_Sabt.Value = dr("Tarikh_Sabt")
            txt_NoSamak.Value = dr("No_Samak")
            'txt_KhorojDate.Value = dr("KhorojDate")
            'txtD.Value = dr("Dis")
            'checkDeviceNameNow = True
            txt_SrlTajhiz.Value = dr("Srl_TajhizForKar")
            Dim drT As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_Hadese_KhesaratDevice where srl=" + txt_SrlTajhiz.Value.ToString)
            If Not dr Is Nothing Then
                txt_Tajhiz.Value = drT("Name")

            End If
            cmb_Post.SelectedValue = dr("Srl_Post")
            cmb_Vahed.SelectedValue = dr("Srl_Vahed")
            cmb_Group.SelectedValue = dr("Srl_Group")
            cmb_Sarparast.SelectedValue = dr("Srl_Sarparast")

            txt_Sharh.Value = dr("Sharh_Kar")
            txt_DateFrom.Value = dr("Tarikh_From")
            txt_DateTo.Value = dr("Tarikh_To")
            txt_Begin.Value = dr("Time_From")
            txt_End.Value = dr("Time_To")
            txt_Tozih.Value = dr("Tozih")
            chk_Status.Checked = IIf(dr("Status") Is DBNull.Value, False, dr("Status"))
            If chk_Status.Checked = False Then
                Panel7.Enabled = True
                If dr("Taeed_Cancel") = 1 Then
                    rbtn_Taeed.Checked = True
                ElseIf dr("Taeed_Cancel") = 2 Then
                    rbtn_Cancel.Checked = True
                ElseIf dr("Taeed_Cancel") = 3 Then
                    rbtn_Ebtal.Checked = True
                End If

            ElseIf chk_Status.Checked = True Then
                Panel7.Enabled = False

            End If

            If dr("Peyvaste") = 1 Then
                rbtn_Peyvaste.Checked = True
            Else
                rbtn_NaPeyvaste.Checked = True
            End If

            If dr("Khamooshi") = 1 Then
                rbtn_khamooshi.Checked = True
            Else
                rbtn_BedooneKhamooshi.Checked = True
            End If
        End If

    End Sub

    Function getMaxOfNo() As Integer
        getMaxOfNo = BaseDataObject.DataAccess.ExecScalar("select isnull(max(no),0)+1 from Pm_DarkhasteKar")
    End Function
    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        If cmb_Post.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا پست را مشخص نمائید")
            cmb_Post.Focus()
            Return
        End If
       
        Dim s As New Frm_DeviceSelect(cmb_Post.SelectedValue)
        s.ShowDialog()

        If Not s.SelectedDevice Is Nothing Then
            txt_Tajhiz.Value = s.SelectedDevice.Text
            txt_SrlTajhiz.Text = s.SelectedDevice.Srl
        End If

        txt_Sharh.Focus()
    End Sub


    Private Sub cmb_Group_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Group.SelectedIndexChanged
        Try
            If cmb_Group.SelectedValue Is Nothing Then
                Return
            End If
            Pm_GroupMemberTableAdapter.Fill(Ds_Pm.Pm_GroupMember, cmb_Group.SelectedValue.ToString, Nothing)
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmb_Vahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Vahed.SelectedIndexChanged
        Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, cmb_Vahed.SelectedValue)

    End Sub

    Private Sub chk_AllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllPerson.CheckedChanged
        If chk_AllPerson.Checked Then
            Me.cmb_Sarparast.DataSource = Me.AccAshkhasBindingSource
            Me.cmb_Sarparast.DisplayMember = "نام و نام خانوادگی"
            Me.cmb_Sarparast.ValueMember = "Srl"
        Else
            Me.cmb_Sarparast.DataSource = Me.PmGroupMemberBindingSource
            Me.cmb_Sarparast.DisplayMember = "نام"
            Me.cmb_Sarparast.ValueMember = "Srl"
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        If chk_Status.Checked = False Then
            Panel7.Enabled = True
        ElseIf chk_Status.Checked = True Then
            Panel7.Enabled = False
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If txt_NoSamak.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا شماره را پر کنيد")
            txt_NoSamak.Focus()
            Return
        End If
        If txt_SrlTajhiz.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا تجهیز را مشخص کنید")
            btn_SelectTajhiz.Focus()
            Return
        End If
        If txt_Sharh.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا شرح کار را وارد کنيد")
            txt_Sharh.Focus()
            Return
        End If
        If txt_DateFrom.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا تاریخ شروع را وارد کنيد")
            txt_DateFrom.Focus()
            Return
        End If
        If txt_DateTo.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا تاریخ پایان را وارد کنيد")
            txt_DateTo.Focus()
            Return
        End If
        If txt_Begin.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا ساعت شروع را وارد کنيد")
            txt_Begin.Focus()
            Return
        End If
        If txt_End.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا ساعت پایان را وارد کنيد")
            txt_End.Focus()
            Return
        End If

       

        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_DarkhasteKar")
        dr("No") = txtNo.Value
        'dr("SubmitDate") = Setting.Now
        dr("Tarikh_Sabt") = Txt_Tarikh_Sabt.Value
        dr("Srl_SubmitUser") = Setting.Srl_User
        dr("Srl_Post") = cmb_Post.SelectedValue
        dr("Srl_Sarparast") = cmb_Sarparast.SelectedValue

        If cmb_Sarparast.SelectedValue = "1534" Then
            dr("Srl_Vahed") = "-1"
            dr("Srl_Group") = "-1"
        Else
            dr("Srl_Vahed") = cmb_Vahed.SelectedValue
            dr("Srl_Group") = cmb_Group.SelectedValue
        End If

        dr("Srl_TajhizForKar") = txt_SrlTajhiz.Value
        dr("Sharh_Kar") = txt_Sharh.Value
        dr("Tozih") = txt_Tozih.Value
        dr("No_Samak") = txt_NoSamak.Value
        dr("Tarikh_From") = txt_DateFrom.Value
        dr("Tarikh_To") = txt_DateTo.Value
        dr("Time_From") = txt_Begin.Value
        dr("Time_To") = txt_End.Value
        dr("Status") = chk_Status.Checked

        If rbtn_Peyvaste.Checked Then
            dr("Peyvaste") = 1
            dr("peyvasteT") = "پیوسته"
        ElseIf rbtn_NaPeyvaste.Checked Then
            dr("Peyvaste") = 2
            dr("peyvasteT") = "ناپیوسته"
        End If

        If rbtn_khamooshi.Checked Then
            dr("Khamooshi") = 1
            dr("khamooshiT") = "خاموشی"

        ElseIf rbtn_BedooneKhamooshi.Checked Then
            dr("Khamooshi") = 2
            dr("khamooshiT") = "برقدار"
        End If

        If chk_Status.Checked Then
            dr("Taeed_Cancel") = 0
        Else
            If rbtn_Taeed.Checked Then
                dr("Taeed_Cancel") = 1
            ElseIf rbtn_Cancel.Checked Then
                dr("Taeed_Cancel") = 2
            ElseIf rbtn_Ebtal.Checked Then
                dr("Taeed_Cancel") = 3
            End If
        End If

        If Srl_Pm_DarkhasteKar <> -2 Then
            dr("Srl") = Srl_Pm_DarkhasteKar
            If (BaseDataObject.DataAccess.ExistNum("Pm_DarkhasteKar", "No", txtNo.Value, "Srl<>" + Srl_Pm_DarkhasteKar.ToString) > 0) Then
                MessageBoxFa.Show("شماره فرم تکراري است")
                txtNo.Focus()
                Return
            End If
        Else
            If (BaseDataObject.DataAccess.ExistNum("Pm_DarkhasteKar", "No", txtNo.Value) > 0) Then
                MessageBoxFa.Show("شماره فرم تکراري است")
                txtNo.Focus()
                Return
            End If
        End If

        BaseDataObject.DataAccess.BeginTransaction()
        If Srl_Pm_DarkhasteKar = -2 Then
            'dr("No") = BaseDataObject.DataAccess.ExecScalar("select isnull(max(No),0)+1 from Pm_DarkhasteKar")
        End If
        If Srl_Pm_DarkhasteKar <> -2 Then
            dr("srl") = Srl_Pm_DarkhasteKar

            If Not BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If
            If Not BaseDataObject.DataAccess.Delete("Pm_DarkhasteKar", " Srl=" + Srl_Pm_DarkhasteKar.ToString) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If
        End If
        Dim Srl_Darkhast As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
        If Srl_Darkhast = -1 Then
            MessageBoxFa.Show("خطا در ثبت اطلاعات")
            BaseDataObject.DataAccess.RollBack()
            Return
        End If


        If Not BaseDataObject.DataAccess.Commit Then
            MessageBoxFa.Show("ثبت اطلاعات با مشكل مواجه شد")
        Else

            MessageBoxFa.Show("اطلاعات با موفقیت ثبت شد")
            ClearForm1()

            txt_NoSamak.Focus()
            txtNo.Value = getMaxOfWorkFormNo()
            Txt_Tarikh_Sabt.Value = Setting.TarikheJary
            chk_Status.Enabled = True
            rbtn_Taeed.Checked = True
            rbtn_Peyvaste.Checked = True
            rbtn_khamooshi.Checked = True

            'CheckBox3.CheckState = CheckState.Checked

        End If

    End Sub

    Function getMaxOfWorkFormNo() As Integer
        getMaxOfWorkFormNo = BaseDataObject.DataAccess.ExecScalar("select isnull(max(no),0)+1 from Pm_DarkhasteKar")
    End Function

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim Number As String = txtNo.Value
        'ClearForm()
        txtNo.Value = Number
        Srl_Pm_DarkhasteKar = CInt(BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_DarkhasteKar where Pm_DarkhasteKar.No ='" + Number + "'"))
        If Srl_Pm_DarkhasteKar = 0 Then
            MessageBox.Show("موردي يافت نشد")
            Return
        End If
        initialForm(Srl_Pm_DarkhasteKar)
        Frm_DarkhasteKar_Load(Nothing, Nothing)
    End Sub

    Public Sub initialForm(ByVal Srl_Pm_DarkhasteKar As Integer)
        Me.Srl_Pm_DarkhasteKar = Srl_Pm_DarkhasteKar
        'cmb_PmWorkDis_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If txtNo.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(False)
                End If
            Else
                NextOrBeforeForm(False)
            End If
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If txtNo.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(True)
                End If
            Else
                NextOrBeforeForm(True)
            End If
        End If
    End Sub

    Private Sub NextOrBeforeForm(ByVal Direction As Boolean)
        Dim FrmNo As Integer
        If Direction Then
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_DarkhasteKar where Pm_DarkhasteKar.No >" + txtNo.Value + " Order by Pm_DarkhasteKar.no"))
        Else
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_DarkhasteKar where Pm_DarkhasteKar.No <" + txtNo.Value + " Order by Pm_DarkhasteKar.no desc"))
        End If
        If FrmNo > 0 Then
            ClearForm()
            Srl_Pm_DarkhasteKar = FrmNo
            Me.Frm_DarkhasteKar_Load(Nothing, Nothing)
        End If
    End Sub
    Private Sub ClearForm1()
        txt_No.Value = getMaxOfNo()
        If txt_No.Value = 1 Then
            txt_No.Value = 1001
        End If


        Txt_Tarikh_Sabt.Value = Setting.TarikheJary
        txt_NoSamak.Value = ""
        'txt_KhorojDate.Value = dr("KhorojDate")
        'txtD.Value = dr("Dis")
        'checkDeviceNameNow = True
        txt_SrlTajhiz.Value = ""
        txt_Tajhiz.Value = ""
        txt_SrlTajhiz.Value = -1
        cmb_Post.SelectedValue = -1
        cmb_Vahed.SelectedValue = -1
        cmb_Group.SelectedValue = -1
        cmb_Sarparast.SelectedValue = -1


        txt_Sharh.Value = ""
        txt_DateFrom.Clear()
        txt_DateTo.Clear()
        txt_Begin.Value = ""
        txt_End.Value = ""
        txt_Tozih.Value = ""
        chk_Status.Checked = True

        If chk_Status.Checked = True Then
            Panel7.Enabled = False
        End If
    End Sub


    Private Sub txt_DateTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DateTo.TextChanged
        txt_Begin.Focus()
    End Sub

    Private Sub cmb_Sarparast_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sarparast.SelectedIndexChanged
        If cmb_Sarparast.SelectedValue = "1534" Then
            cmb_Vahed.Enabled = False
            cmb_Group.Enabled = False
            cmb_Vahed.SelectedValue = "-1"
            cmb_Group.SelectedValue = "-1"
        Else
            cmb_Vahed.Enabled = True
            cmb_Group.Enabled = True
        End If
    End Sub
End Class