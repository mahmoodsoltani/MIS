Public Class Frm_Rp_Tamirat

   

    Private Sub Frm_Rp_Tamirat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Lab1.Pm_Lab_Rol_Master_Vw' table. You can move, or remove it, as needed.
        Me.Pm_Lab_Rol_Master_VwTableAdapter.Fill(Me.Ds_Lab1.Pm_Lab_Rol_Master_Vw)
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Masool_Tamir' table. You can move, or remove it, as needed.
        Me.Pm_Lab_Rol_Masool_TamirTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Masool_Tamir)
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Device_Sazande' table. You can move, or remove it, as needed.
        Me.Pm_Device_SazandeTableAdapter.Fill(Me.Ds_Lab.Pm_Device_Sazande)
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Master_Vw' table. You can move, or remove it, as needed.
        'Me.Pm_Lab_Rol_Master_VwTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Master_Vw)
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_TamiratView' table. You can move, or remove it, as needed.
        'Me.Pm_Lab_Rol_TamiratViewTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_TamiratView)

    End Sub




  
    Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_print.Click
        Dim rp As New Lab

        rp.SetDataSource(Ds_Lab.Pm_Lab_Rol_Master_Vw.DataSet)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Lab.Pm_Lab_Rol_Master_Vw.DataSet.Tables("0"))
        frm_rp.ShowDialog()
    End Sub

   
    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        Dim test As New Frm_Rp_Lab_Tamir
        test.ShowDialog()
    End Sub

    Private Sub chk_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_No.CheckedChanged
        txt_No.Enabled = Not chk_No.Checked
    End Sub
    Private Sub chk_No_Barcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_No_Barcode.CheckedChanged
        txt_No_Barcode.Enabled = Not chk_No_Barcode.Checked
    End Sub
    Private Sub chk_Serial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Serial.CheckedChanged
        txt_serial.Enabled = Not chk_Serial.Checked
    End Sub

    Private Sub chk_Device_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Sazande.CheckedChanged
        cmb_Sazande.Enabled = Not chk_Sazande.Checked
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        cmb_Masool.Enabled = Not CheckBox4.Checked
    End Sub

    Private Sub chk_SatheaAhamiat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SatheaAhamiat.CheckedChanged
        btn_SelectDEvice.Enabled = Not chk_SatheaAhamiat.Checked
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Button1.Enabled = Not CheckBox3.Checked
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        Button2.Enabled = Not CheckBox5.Checked
    End Sub

    Private Sub chk_TarikhSabt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TarikhSabt.CheckedChanged
        txt_TarikhSabtFrom.Enabled = Not chk_TarikhSabt.Checked
        txt_TarikhSabtTo.Enabled = Not chk_TarikhSabt.Checked

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        txt_TarikhVorodFrom.Enabled = Not CheckBox1.Checked
        txt_TarikhVorodTo.Enabled = Not CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        txt_TarikhKhorojFrom.Enabled = Not CheckBox2.Checked
        txt_TarikhKhorojTo.Enabled = Not CheckBox2.Checked

    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click

        Dim SabtDateFrom As String = "-1"
        Dim SabtDateTo As String = "-1"
        If Not chk_TarikhSabt.Checked Then
            SabtDateFrom = txt_TarikhSabtFrom.Value
            SabtDateTo = txt_TarikhSabtTo.Value
        End If

        Dim VorodDateFrom As String = "-1"
        Dim VorodDateTo As String = "-1"
        If Not CheckBox1.Checked Then
            VorodDateFrom = txt_TarikhVorodFrom.Value
            VorodDateTo = txt_TarikhVorodTo.Value
        End If

        Dim KhorojDateFrom As String = "-1"
        Dim KhorojDateTo As String = "-1"
        If Not CheckBox2.Checked Then
            KhorojDateFrom = txt_TarikhKhorojFrom.Value
            KhorojDateTo = txt_TarikhKhorojTo.Value
        End If


        Dim Sazande As Integer = -1
        If Not chk_Sazande.Checked Then
            Sazande = cmb_Sazande.SelectedValue
        End If

        Dim Masool_Tamir As Integer = -1
        If Not CheckBox4.Checked Then
            Masool_Tamir = cmb_Masool.SelectedValue
        End If

        Dim No As String = "-1"
        If Not chk_No.Checked Then
            No = txt_No.Value
        End If

        Dim No_Barcode As String = "-1"
        If Not chk_No_Barcode.Checked Then
            No_Barcode = txt_No_Barcode.Value
        End If

        Dim Serial As String = "-1"
        If Not chk_Serial.Checked Then
            Serial = txt_serial.Value
        End If

        Dim Device As Integer = -1
        If Not chk_SatheaAhamiat.Checked Then
            Device = srl_Device.Text
        End If

        Dim Mahal_Nasb As Integer = -1
        If Not CheckBox3.Checked Then
            Mahal_Nasb = srl_Nasb.Text
        End If

        Dim Mahal_Bahre As Integer = -1
        If Not CheckBox5.Checked Then
            Mahal_Bahre = srl_Bahre.Text
        End If


        Pm_Lab_Rol_Master_VwTableAdapter.FillBySeach(Me.Ds_Lab.Pm_Lab_Rol_Master_Vw, No, No_Barcode, Serial, Sazande, Device, Masool_Tamir, Mahal_Nasb, -1, VorodDateFrom, VorodDateTo, KhorojDateFrom, KhorojDateTo, SabtDateFrom, SabtDateTo)

        lbl_Record.Text = "تعداد رکورد :"
        lbl_Record.Text += Ds_Lab.Pm_Lab_Rol_Master_Vw.Rows.Count.ToString
    End Sub

    Private Sub btn_SelectDEvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectDEvice.Click

        Dim TreeV As New Frm_TajhizSelect

        If TreeV.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Not TreeV.selectedSubject Is Nothing Then
                txt_Device.Value = TreeV.selectedSubject.Text
                srl_Device.Text = TreeV.selectedSubject.Srl
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim TreeV1 As New Frm_MahalSelect
        If TreeV1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Not TreeV1.selectedSubject1 Is Nothing Then
                txt_Nasb.Value = TreeV1.selectedSubject1.Text
                srl_Nasb.Text = TreeV1.selectedSubject1.Srl
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim TreeV2 As New Frm_MahalSelect
        If TreeV2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Not TreeV2.selectedSubject1 Is Nothing Then
                txt_Bahre.Value = TreeV2.selectedSubject2.Text
                srl_Bahre.Text = TreeV2.selectedSubject2.Srl
            End If
        End If
    End Sub

    Private Sub txt_TarikhVorodFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TarikhVorodFrom.TextChanged

    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Frm_Lab_Rol_Master.share = 5
        Dim s As New Frm_Lab_Rol_Master(srl)
        s.ShowDialog()

        Me.Pm_Lab_Rol_Master_VwTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Master_Vw)
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Delete, False)
            If srl = -1 Then
                Return
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then
                BaseDataObject.DataAccess.Delete("Pm_Lab_Rol_SharheKar", " Srl_Master=" + srl.ToString)
                BaseDataObject.DataAccess.Delete("Pm_Lab_Rol_Master", srl)
                If BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                    Me.Pm_Lab_Rol_Master_VwTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Master_Vw)
                    Return
                End If
            End If
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            Return
        End If
    End Sub

   
    
End Class