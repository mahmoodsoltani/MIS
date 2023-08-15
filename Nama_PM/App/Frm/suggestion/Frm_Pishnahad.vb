Public Class Frm_Pishnahad
    Dim Srl_Post As Integer
    Dim SrlDevice As Integer
    Dim Srl_Pm_Pishnahad As Integer

    Public Sub New(ByVal Srl_Pm_Pishnahad As Integer)
        InitializeComponent()
        Me.Srl_Pm_Pishnahad = Srl_Pm_Pishnahad
    End Sub
    Private Sub Frm_Pishnahad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Sender' table. You can move, or remove it, as needed.
        Me.Pm_SenderTableAdapter.Fill(Me.Ds_Pm.Pm_Sender)
        txt_NoForm.Focus()
        rbt_Post.Checked = True
        cmb_Post.Enabled = True
        cmb_Line.Enabled = False
        'rb_All.Checked = True
        CheckBox1.Checked = True
        GroupBox1.Enabled = False
        'txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        'txt_ToDate.Value = Setting.TarikheJary
        'chk_AllDate.Checked = True
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        'Me.Pm_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Ashkhas)
        Me.Pm_RecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_RecomendationSubject)
        'Me.Pm_SubRecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_SubRecomendationSubject, cmb_RecomSubject.SelectedValue)
        Srl_Post = cmb_Post.SelectedValue
        'Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, Srl_Post)
        'If Not Srl_Device = -1 Then
        '    txt_TajhizNameForSave.Value = GetDeviceName(Srl_Device)
        'End If
        'LoadDataGridView()
        txt_NoForm.Focus()

        If Srl_Pm_Pishnahad = -2 Then
            txt_No.Value = getMaxOfNo()
            If txt_No.Value = 1 Then
                txt_No.Value = 1001
            End If
            txt_TarikhSabt.Value = Setting.TarikheJary
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Post_Pishnahd", Srl_Pm_Pishnahad)

            txt_No.Value = dr("No")
            txt_NoForm.Value = dr("No_Form")
            txt_tarikh.Value = dr("Tarikh")
            cmb_Post.SelectedValue = dr("Srl_Post")
            cmb_Line.SelectedValue = dr("Srl_Line")
            cmb_Vahde.SelectedValue = dr("Srl_Vahed")
            cmb_Sender.SelectedValue = dr("Srl_Sender")
            txt_PTime.Value = dr("PTime")
            cmb_RecomSubject.SelectedValue = dr("Srl_RecomSubject")
            'cmb_SubRecom.SelectedValue = dr("Srl_SubRecomSubject")
            txt_Sub.Value = dr("SubRecomSubject")
            txt_Sug.Value = dr("Pishnahad")
            txt_TarikhSabt.Value = Setting.TarikheJary

            If cmb_Post.SelectedValue Is Nothing Then
                txt_TajhizNameForSave.Value = ""
                Srl_Device.Text = -1
                rbt_Line.Checked = True
            Else
                Srl_Device.Value = dr("Srl_Device")
                Dim drT As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_Hadese_KhesaratDevice where srl=" + Srl_Device.Value.ToString)
                If Not dr Is Nothing Then
                    txt_TajhizNameForSave.Value = drT("Name")

                End If
                rbt_Post.Checked = True
            End If
            txt_TarikhDo.Value = dr("Tarikh_Do")
            txt_NoFormDo.Value = dr("No_FormDo")
            txt_Dis.Value = dr("Dis_AnjamKar")


            'rbt_Do.Checked = IIf(dr("is_Do") Is DBNull.Value, False, True)
            If Not dr("is_Do") Is DBNull.Value Then
                rbt_Do.Checked = IIf(dr("is_Do") = 1, True, False)
                If rbt_Do.Checked = True Then
                    rbt_NotDo.Checked = False
                Else
                    rbt_NotDo.Checked = True
                End If

            End If


            'rbt_NotDo.Checked = IIf(dr("is_NotDo") Is DBNull.Value, True, False)
            'If rbt_NotDo.Checked = True Then
            '    rbt_Do.Checked = False
            'End If

            If txt_TarikhDo.Value.ToString = "" Or txt_Dis.Value.ToString = "" Then
                CheckBox1.Checked = True
                GroupBox1.Enabled = False
            Else
                CheckBox1.Checked = False
                GroupBox1.Enabled = True
            End If
            End If
            'TODO: This line of code loads data into the 'Ds_Pm.Pm_RecomendationSubject' table. You can move, or remove it, as needed.
            'Me.Pm_RecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_RecomendationSubject)
            'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.

            'TODO: This line of code loads data into the 'Ds_Pm.Pm_Post' table. You can move, or remove it, as needed.


    End Sub

    Function getMaxOfNo() As Integer
        getMaxOfNo = BaseDataObject.DataAccess.ExecScalar("select isnull(max(no),0)+1 from Pm_Post_Pishnahd")
    End Function
   
    Private Sub cmb_RecomSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_RecomSubject.SelectedIndexChanged
        'Me.Pm_RecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_RecomendationSubject)
        'Me.Pm_SubRecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_SubRecomendationSubject, cmb_RecomSubject.SelectedValue)
    End Sub

    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        If rbt_Post.Checked = False Then
            MessageBoxFa.Show("لطفا پست را انتخاب کنید")
            rbt_Post.Checked = True
            cmb_Post.Focus()
            Return
        End If

        If cmb_Post.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا پست را مشخص نمائید")
            cmb_Post.Focus()
            Return
        End If

        Dim s As New Frm_DeviceSelect(cmb_Post.SelectedValue)
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_TajhizNameForSave.Value = s.SelectedDevice.Text
            Srl_Device.Text = s.SelectedDevice.Srl
        End If
    End Sub

    Private Sub rbt_Post_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Post.CheckedChanged
        If rbt_Post.Checked = True Then
            cmb_Post.Enabled = True
            cmb_Line.Enabled = False
        Else
            cmb_Post.Enabled = False
            cmb_Line.Enabled = True
        End If
    End Sub

    Private Sub rbt_Line_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Line.CheckedChanged
        If rbt_Line.Checked = True Then
            cmb_Post.Enabled = False
            cmb_Line.Enabled = True
        Else
            cmb_Post.Enabled = True
            cmb_Line.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then


            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If txt_NoForm.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا شماره را پر کنيد")
            txt_NoForm.Focus()
            Return
        End If

        If txt_tarikh.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا تاریخ را وارد کنيد")
            txt_tarikh.Focus()
            Return
        End If

        If Srl_Pm_Pishnahad <> -2 Then
            'dr("Srl") = Srl_Pm_Pishnahad
            If (BaseDataObject.DataAccess.ExistNum("Pm_Post_Pishnahd", "No", txt_No.Value, "Srl<>" + Srl_Pm_Pishnahad.ToString) > 0) Then
                MessageBoxFa.Show("شماره فرم تکراري است")
                txt_No.Focus()
                Return
            End If
            'Else
            '    If (BaseDataObject.DataAccess.ExistNum("Pm_Post_Pishnahd", "No", txt_No.Value) > 0) Then
            '        MessageBoxFa.Show("شماره فرم تکراري است")
            '        txt_No.Focus()
            '        Return
            '    End If
        End If
        If rbt_Post.Checked = True And txt_TajhizNameForSave.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا تجهیز را مشخص کنید")
            btn_SelectTajhiz.Focus()
            Return
        End If

        If txt_Sug.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا شرح پیشنهاد را پر کنيد")
            txt_Sug.Focus()
            Return
        End If

        If CheckBox1.Checked = False Then
            If txt_TarikhDo.Value.ToString = "" Then
                MessageBoxFa.Show("لطفا تاریخ انجام را وارد کنيد")
                txt_TarikhDo.Focus()
                Return
            End If
            If txt_NoFormDo.Value.ToString = "" Then
                MessageBoxFa.Show("لطفا شماره فرم یا شماره نامه را وارد کنيد")
                txt_NoFormDo.Focus()
                Return
            End If
            If txt_Dis.Value.ToString = "" Then
                MessageBoxFa.Show("لطفا شرح کارهای انجام شده را وارد کنید")
                txt_Dis.Focus()
                Return
            End If
            If txt_PTime.Value.ToString = "" Then
                MessageBoxFa.Show("لطفا بازه مجاز انجام کار را وارد کنید")
                txt_PTime.Focus()
                Return
            End If

        End If
        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Post_Pishnahd")
        dr("Tarikh_Sabt") = txt_TarikhSabt.Value
        dr("No") = txt_No.Value
        dr("PTime") = txt_PTime.Value
        dr("Tarikh_Do") = txt_TarikhDo.Value
        dr("Tarikh") = txt_tarikh.Value
        dr("No_Form") = txt_NoForm.Value
        dr("No_FormDo") = txt_NoFormDo.Value
        dr("Srl_RecomSubject") = cmb_RecomSubject.SelectedValue
        dr("Srl_Sender") = cmb_Sender.SelectedValue

        dr("Srl_Vahed") = cmb_Vahde.SelectedValue
        dr("Pishnahad") = txt_Sug.Value
        dr("Dis_AnjamKar") = txt_Dis.Value
        If rbt_Post.Checked = True Then
            dr("Srl_Device") = Srl_Device.Value
        End If


        'If cmb_SubRecom.SelectedValue Is Nothing Then
        '    MessageBoxFa.Show("لطفا زیرموضوع را مشخص کنيد")
        '    cmb_SubRecom.Focus()
        '    Return
        'End If
        'dr("Srl_SubRecomSubject") = cmb_SubRecom.SelectedValue
        dr("SubRecomSubject") = txt_Sub.Value

        If rbt_Post.Checked = True Then
            If cmb_Post.SelectedValue Is Nothing Then
                MessageBoxFa.Show("لطفا پست را مشخص کنيد")
            End If

            dr("Srl_Post") = cmb_Post.SelectedValue
            'dr("Srl_Line") =

        End If

        If rbt_Line.Checked = True Then
            If cmb_Line.SelectedValue Is Nothing Then
                MessageBoxFa.Show("لطفا خط را مشخص کنيد")
            End If
            dr("Srl_Line") = cmb_Line.SelectedValue
            'dr("Srl_Post") = ""

        End If

        If rbt_Do.Checked = True Then
            dr("is_Do") = 1
            dr("is_NotDo") = 0
        End If
        If rbt_NotDo.Checked = True Then
            dr("is_Do") = 0
            dr("is_NotDo") = 1
        End If
        If CheckBox1.Checked Then
            dr("Status") = 0
        Else
            If rbt_Do.Checked = True Then
                dr("Status") = 1
            ElseIf rbt_NotDo.Checked = True Then
                dr("Status") = 0
            End If
        End If
        BaseDataObject.DataAccess.BeginTransaction()
       

        If Srl_Pm_Pishnahad <> -2 Then
            dr("srl") = Srl_Pm_Pishnahad

            If Not BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If
            If Not BaseDataObject.DataAccess.Delete("Pm_Post_Pishnahd", " Srl=" + Srl_Pm_Pishnahad.ToString) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If
        End If
        Dim Srl_Pishnahad As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
        If Srl_Pishnahad = -1 Then
            MessageBoxFa.Show("خطا در ثبت اطلاعات")
            BaseDataObject.DataAccess.RollBack()
            Return
        End If


        If Not BaseDataObject.DataAccess.Commit Then
            MessageBoxFa.Show("ثبت اطلاعات با مشكل مواجه شد")
        Else

            MessageBoxFa.Show("اطلاعات با موفقیت ثبت شد")
            ClearForm1()
            txt_NoForm.Focus()
            txt_No.Value = getMaxOfNo()

        End If
    End Sub

    Private Sub ClearForm1()

        txt_NoForm.Focus()
        rbt_Post.Checked = True
        cmb_Post.Enabled = True
        cmb_Line.Enabled = False

        CheckBox1.Checked = True
        GroupBox1.Enabled = False

        txt_NoForm.Value = ""
        txt_tarikh.Clear()
        cmb_Post.SelectedValue = -1
        cmb_Line.SelectedValue = -1
        cmb_Vahde.SelectedValue = -1
        cmb_RecomSubject.SelectedValue = -1
        cmb_SubRecom.SelectedValue = -1
        cmb_Sender.SelectedValue = -1
        txt_Sug.Value = ""
        txt_TarikhDo.Clear()
        txt_NoFormDo.Value = ""
        txt_Dis.Value = ""
        rbt_Do.Checked = False
        rbt_NotDo.Checked = False
        txt_TajhizNameForSave.Value = ""
        Srl_Device.Text = -1
        txt_PTime.Value = ""
        txt_Sub.Value = ""

        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)

        Me.Pm_RecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_RecomendationSubject)
        Me.Pm_SubRecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_SubRecomendationSubject, cmb_RecomSubject.SelectedValue)
        Srl_Post = cmb_Post.SelectedValue

        If Srl_Pm_Pishnahad = -2 Then
            txt_No.Value = getMaxOfNo()
            If txt_No.Value = 1 Then
                txt_No.Value = 1001
            End If
            txt_TarikhSabt.Value = Setting.TarikheJary
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Post_Pishnahd", Srl_Pm_Pishnahad)

        End If
    End Sub

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click

    End Sub

    Private Sub btn_SHow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SHow.Click
        Dim Number As String = txt_No.Value
        txt_No.Value = Number
        Srl_Pm_Pishnahad = CInt(BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_Post_Pishnahd where Pm_Post_Pishnahd.No ='" + Number + "'"))
        If Srl_Pm_Pishnahad = 0 Then
            MessageBox.Show("موردي يافت نشد")
            Return
        End If
        initialForm(Srl_Pm_Pishnahad)
        Frm_Pishnahad_Load(Nothing, Nothing)
    End Sub

    Public Sub initialForm(ByVal Srl_Pm_Pishnahad As Integer)
        Me.Srl_Pm_Pishnahad = Srl_Pm_Pishnahad
        'cmb_PmWorkDis_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    
End Class