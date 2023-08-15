Public Class Frm_RpPishnahad

    Private Sub Frm_RpPishnahad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Sender' table. You can move, or remove it, as needed.
        Me.Pm_SenderTableAdapter.Fill(Me.Ds_Pm.Pm_Sender)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_RecomendationSubject' table. You can move, or remove it, as needed.
        Me.Pm_RecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_RecomendationSubject)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)


    End Sub

    Private Sub chk_TarikhSabt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TarikhSabt.CheckedChanged
        txt_TarikhSabtFrom.Enabled = Not chk_TarikhSabt.Checked
        txt_TarikhSabtTo.Enabled = Not chk_TarikhSabt.Checked
    End Sub

    Private Sub chkb_Device_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkb_Device.CheckedChanged
        txt_TajhizNameForSave.Enabled = Not chkb_Device.Checked

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

    Private Sub chkb_Vahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkb_Vahed.CheckedChanged
        cmb_Vahed.Enabled = Not chkb_Vahed.Checked
    End Sub

    Private Sub chkb_Subject_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkb_Subject.CheckedChanged
        cmb_RecomSubject.Enabled = Not chkb_Subject.Checked
    End Sub
    Private Sub chkb_pl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkb_pl.CheckedChanged
        rbt_Post.Enabled = Not chkb_pl.Checked
        cmb_Post.Enabled = Not chkb_pl.Checked
        rbt_Line.Enabled = Not chkb_pl.Checked
        cmb_Line.Enabled = Not chkb_pl.Checked
        rbt_Post.Checked = Not chkb_pl.Checked
        'rbt_Line.Checked = False
        'cmb_Line.Enabled = False
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

    
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        Dim Tarikh_To As String = ""
        Dim Tarikh_From As String = ""
        If Not chk_TarikhSabt.Checked Then
            Tarikh_From = txt_TarikhSabtFrom.Value
            Tarikh_To = txt_TarikhSabtTo.Value
        End If

        Dim Device As Integer = -1
        If Not chkb_Device.Checked Then
            Device = Srl_Device.Text
        End If

        Dim Vahed As Integer = -1
        If Not chkb_Vahed.Checked Then
            Vahed = cmb_Vahed.SelectedValue
        End If

        Dim Senderr As Integer = -1
        If Not chkb_Sender.Checked Then
            Senderr = cmb_Sender.SelectedValue
        End If

        Dim Subject As Integer = -1
        If Not chkb_Subject.Checked Then
            Subject = cmb_RecomSubject.SelectedValue
        End If

        Dim Post As Integer = -1
        Dim Line As Integer = -1
        If Not chkb_pl.Checked Then
            If rbt_Post.Checked Then
                Post = cmb_Post.SelectedValue
            Else
                Line = cmb_Line.SelectedValue
            End If
        End If

        Dim Status As Integer = -1
        If rb_Fix.Checked Then
            Status = 1
        ElseIf rb_NotFix.Checked Then
            Status = 0
        End If
        Rp_PishnahadTableAdapter.Fill(Me.Ds_Rp.Rp_Pishnahad, Post, Line, Device, Tarikh_From, Tarikh_To, Subject, "", Vahed, Senderr, Status)
        lbl_Record.Text = "تعداد رکورد :"
        lbl_Record.Text += Ds_Rp.Rp_Pishnahad.Rows.Count.ToString()
        Dim dt As DataTable = Ds_Rp.Rp_Pishnahad
        IsExpire(dt)

    End Sub

    Private Sub IsExpire(ByRef dt As DataTable)
        Dim SabtDate As String = ""
        Dim JaryDate As String = ""
        Dim sabt As FarsiDateFun
        Dim Jary As FarsiDateFun
        Dim baze As Double
        Dim dif As Integer
        Dim expireDate As String = ""
        Dim expireDateE As String = ""
        Dim expire As FarsiDateFun

        For Each dr As DataRow In dt.Rows

            If Not dr(1) Is DBNull.Value Then
                SabtDate = dr(1).ToString()
            End If
            If Not dr(8) Is DBNull.Value Then
                baze = dr(8).ToString()
            Else
                Continue For
            End If
            If Not SabtDate Is DBNull.Value Then
                If SabtDate <> "" Then
                    sabt = New FarsiDateFun(SabtDate.Substring(0, 4), SabtDate.Substring(5, 2), SabtDate.Substring(8))
                Else
                    sabt = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
                End If
            Else
                sabt = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
            End If
            Jary = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
            'dif = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(Jary), VB_Component.FarsiDateFun.F2E(sabt))
            expireDate = DateAdd(DateInterval.Day, baze, VB_Component.FarsiDateFun.F2E(sabt))
            expireDateE = VB_Component.FarsiDateFun.E2F(expireDate)
            expire = New FarsiDateFun(expireDateE.Substring(0, 4), expireDateE.Substring(5, 2), expireDateE.Substring(8))
            dif = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(Jary), VB_Component.FarsiDateFun.F2E(expire))
            'If Not dr(20) Is DBNull.Value Then
            '    If Not dr(20).ToString() = "" And dr(7) <> "" Then
            '        'dr(19) = dr(19).ToString() + "*" + (dif - dr(20)).ToString()
            '        'If dif > dr(20).ToString() Then
            '        dr(20) = dr(20).ToString() - dif
            '        'Else
            '        '  dr(20) = 0
            '        ' End If
            '    Else
            '        dr(20) = 0
            '    End If


            'End If
            dr(17) = dif
        Next
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        'Frm_Lab_Rol_Master.share = 5
        Dim s As New Frm_Pishnahad(srl)
        s.ShowDialog()
        Rp_PishnahadTableAdapter.Fill(Me.Ds_Rp.Rp_Pishnahad, -1, -1, -1, "", "", -1, "", -1, -1, -1)

    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        Dim rp As New Rp_Mosavabat

        rp.SetDataSource(Ds_Rp.Rp_Pishnahad.DataSet)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Rp.Rp_Pishnahad.DataSet.Tables("0"))
        frm_rp.ShowDialog()
    End Sub

 
End Class