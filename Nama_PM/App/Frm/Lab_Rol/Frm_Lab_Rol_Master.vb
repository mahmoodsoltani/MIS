Public Class Frm_Lab_Rol_Master
    Public Shared share As Integer
    Dim Srl_Pm_Lab_Roliaj As Integer
    Dim Srl_Tajhiz As Integer
    Dim Srl_Mahal As Integer
    Dim Srl_Mahal1 As Integer
    Dim checkDeviceNameNow As Boolean = False
    Dim checkMahalNow As Boolean = False
    Dim checkMahal1Now As Boolean = False


    Public Sub New(ByVal Srl_Pm_Lab_Roliaj As Integer)
        InitializeComponent()
        Me.Srl_Pm_Lab_Roliaj = Srl_Pm_Lab_Roliaj
    End Sub

    Private Sub Frm_Lab_Rol_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Master' table. You can move, or remove it, as needed.
        Me.Pm_Lab_Rol_MasterTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Master, -1)
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_SharheKar' table. You can move, or remove it, as needed.
     
        Me.Pm_Lab_Rol_SharheKarTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_SharheKar, Srl_Pm_Lab_Roliaj)
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Masool_Tamir' table. You can move, or remove it, as needed.
        Me.Pm_Lab_Rol_Masool_TamirTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Masool_Tamir)
        'TODO: This line of code loads data into the 'Ds_Lab.Pm_Device_Sazande' table. You can move, or remove it, as needed.
        Me.Pm_Device_SazandeTableAdapter.Fill(Me.Ds_Lab.Pm_Device_Sazande)
        If Srl_Pm_Lab_Roliaj = -2 Then
           

            txt_No.Value = getMaxOfNo()
            If txt_No.Value = 1 Then
                txt_No.Value = 1001
            End If


            txt_TarikhSabt.Value = Setting.TarikheJary
        Else

            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Master", Srl_Pm_Lab_Roliaj)


            txt_No.Value = dr("No")
            txt_TarikhSabt.Value = dr("SabtDate")
            txt_TarikhVorod.Value = dr("VorodDate")
            txt_KhorojDate.Value = dr("KhorojDate")
            txtD.Value = dr("Dis")
            checkDeviceNameNow = True
            txtSelect_Srl.Value = dr("Srl_Pm_Lab_Rol_Tajhiz")

            checkMahalNow = True
            txtSelectMahal_Srl.Value = dr("Srl_Pm_Lab_Rol_Mahal_Nasb")

            checkMahal1Now = True
            txtSelectNasb_Srl.Value = dr("Srl_Pm_Lab_Rol_Mahal_bahre")

            cmb_Sazande.SelectedValue = dr("Srl_Pm_Device_Sazande")
            txtBarcode.Value = dr("No_Barcode")
            txtPelak.Value = dr("Pelak_Amval")
            txt_Girande.Value = dr("TahvilGirande")
            txt_Tahvildahande.Value = dr("TahvilDahande")
            txtEib.Value = dr("Eib")
            txtD.Value = dr("Dis")
            txt_TahvildahandeNo.Value = dr("TahvildahandeNo")
            cmb_Sazande.SelectedValue = dr("Srl_Pm_Device_Sazande")
            cmb_Masool.SelectedValue = dr("Srl_Pm_Lab_Rol_Masool_Tamir")
            Srl_Tajhiz = dr("Srl_Pm_Lab_Rol_Tajhiz")
            Srl_Mahal = dr("Srl_Pm_Lab_Rol_Mahal_Nasb")
            Srl_Mahal1 = dr("Srl_Pm_Lab_Rol_Mahal_Bahre")
            If txtSelectNasb_Srl.Value = -1 Then
                txtSelectNasb.Text = ""
                txt_KhorojDate.Text = ""
                txt_KhorojDate.Clear()
                txt_Girande.Text = ""
                txtD.Text = ""
                txtSelectNasb.Text = ""
                CheckBox3.CheckState = CheckState.Checked
            End If
        End If

        If txtEib.Value <> "" Or cmb_Masool.Text <> "" Or txtSelectNasb.Text <> "" Then
            CheckBox2.CheckState = CheckState.Unchecked
        Else
            CheckBox2.CheckState = CheckState.Checked
        End If

        If txt_Girande.Value <> "" Or txtD.Value <> "" Then
            CheckBox3.CheckState = CheckState.Unchecked
        Else
            CheckBox3.CheckState = CheckState.Checked
        End If


    End Sub
   
    'Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
    '    Return MyBase.Save()
    'End Function
    'Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
    '    Me.DataObject.DataRow()
    'End Function

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
    Function getMaxOfNo() As Integer
        getMaxOfNo = BaseDataObject.DataAccess.ExecScalar("select isnull(max(no),0)+1 from Pm_Lab_Rol_Master")
    End Function
    Private Sub btn_Before_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Before.Click
        If txt_No.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(False)
                End If
            Else
                NextOrBeforeForm(False)
            End If
        End If
    End Sub
    Private Sub NextOrBeforeForm(ByVal Direction As Boolean)
        Dim FrmNo As Integer
        If Direction Then
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_Lab_Rol_Master where Pm_Lab_Rol_Master.No >" + txt_No.Value + " Order by Pm_Lab_Rol_Master.no"))
        Else
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_Lab_Rol_Master where Pm_Lab_Rol_Master.No <" + txt_No.Value + " Order by Pm_Lab_Rol_Master.no desc"))
        End If
        If FrmNo > 0 Then
            ClearForm()
            Srl_Pm_Lab_Roliaj = FrmNo
            Me.Frm_Lab_Rol_Master_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click
        If txt_No.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(True)
                End If
            Else
                NextOrBeforeForm(True)
            End If
        End If
    End Sub

   
    Private Sub btn_SHow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SHow.Click
        'ClearForm()
        Dim Number As String = txt_No.Value
        'ClearForm()
        txt_No.Value = Number
        Srl_Pm_Lab_Roliaj = CInt(BaseDataObject.DataAccess.ExecScalar("select Srl from Pm_Lab_Rol_Master where Pm_Lab_Rol_Master.No ='" + Number + "'"))
        If Srl_Pm_Lab_Roliaj = 0 Then
            MessageBox.Show("موردي يافت نشد")
            Return
        End If
        Frm_Lab_Rol_Master_Load(Nothing, Nothing)
    End Sub
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If txt_No.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا شماره فرم را پر کنيد")
            txt_No.Focus()
            Return
        End If
        If txtSelect_Srl.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا يک دستگاه را انتخاب کنيد")
            btn_SelectTajhiz.Focus()
            Return
        End If
        If txtSelectMahal_Srl.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا محل استفاده دستگاه را مشخص کنيد")
            btn_SelectMahal.Focus()
            Return
        End If
        If Srl_Pm_Lab_Roliaj <> -2 Then
            If (BaseDataObject.DataAccess.ExistNum("Pm_Lab_Rol_Master", "No", txt_No.Value , "Srl<>" + Srl_Pm_Lab_Roliaj.ToString) > 0) Then
                MessageBoxFa.Show("شماره فرم تکراري است")
                txt_No.Focus()
                Return
            End If
        Else
            If (BaseDataObject.DataAccess.ExistNum("Pm_Lab_Rol_Master", "No", txt_No.Value) > 0) Then
                MessageBoxFa.Show("شماره فرم تکراري است")
                txt_No.Focus()
                Return
            End If
        End If
        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_Master")
        dr("No") = txt_No.Value
        dr("SubmitDate") = Setting.Now
        dr("SabtDate") = txt_TarikhSabt.Value
        dr("Srl_SubmitUser") = Setting.Srl_User
        dr("No_Barcode") = txtBarcode.Value
        dr("Pelak_Amval") = txtPelak.Value
        dr("VorodDate") = txt_TarikhVorod.Value
        dr("KhorojDate") = txt_KhorojDate.Value
        dr("TahvilGirande") = txt_Girande.Value
        dr("TahvilDahande") = txt_Tahvildahande.Value
        dr("Eib") = txtEib.Value
        dr("Dis") = txtD.Value
        dr("TahvildahandeNo") = txt_TahvildahandeNo.Value
        dr("Srl_Pm_Device_Sazande") = cmb_Sazande.SelectedValue
        dr("Srl_Pm_Lab_Rol_Masool_Tamir") = cmb_Masool.SelectedValue
        dr("Srl_Pm_Lab_Rol_Tajhiz") = txtSelect_Srl.Value
        dr("Srl_Pm_Lab_Rol_Mahal_Nasb") = txtSelectMahal_Srl.Value
        'dr("Srl_Pm_Lab_Rol_Mahal_Bahre") = txtSelectNasb_Srl.Value


        If CheckBox3.CheckState = CheckState.Unchecked Then
            If txtSelectNasb_Srl.Value.ToString = "" Then
                MessageBoxFa.Show("لطفا محل نصب دستگاه را مشخص کنيد")
                btn_SelectMahaleNasb.Focus()
                Return
            Else
                dr("Srl_Pm_Lab_Rol_Mahal_Bahre") = txtSelectNasb_Srl.Value
            End If
        Else
            dr("Srl_Pm_Lab_Rol_Mahal_Bahre") = -1


        End If

        BaseDataObject.DataAccess.BeginTransaction()
        If Srl_Pm_Lab_Roliaj <> -2 Then
            dr("srl") = Srl_Pm_Lab_Roliaj

            If Not BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If
            If Not BaseDataObject.DataAccess.Delete("Pm_Lab_Rol_SharheKar", " Srl_Master=" + Srl_Pm_Lab_Roliaj.ToString) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If



            For Each dtg As DataGridViewRow In DataGridView1.Rows
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_SharheKar")
                dr_details("Srl_Master") = Srl_Pm_Lab_Roliaj
                dr_details("Srl") = dtg.Cells(0).Value
                dr_details("Date") = dtg.Cells(1).Value
                dr_details("Dis") = dtg.Cells(2).Value
                If Not BaseDataObject.DataAccess.Insert(dr_details, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next

        Else

            Dim Srl_Maseter As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            If Srl_Maseter = -1 Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If
            For Each dtg As DataGridViewRow In DataGridView1.Rows
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_SharheKar")
                dr_details("Srl_Master") = Srl_Maseter
                dr_details("Srl") = dtg.Cells(0).Value
                dr_details("Date") = dtg.Cells(1).Value
                dr_details("Dis") = dtg.Cells(2).Value
                If Not BaseDataObject.DataAccess.Insert(dr_details, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next

        End If

        If Not BaseDataObject.DataAccess.Commit Then
            MessageBoxFa.Show("ثبت اطلاعات با مشكل مواجه شد")
        Else

            MessageBoxFa.Show("اطلاعات با موفقیت ثبت شد")
            ClearForm()


            Pm_Lab_Rol_SharheKarTableAdapter.Fill(Ds_Lab.Pm_Lab_Rol_SharheKar, -2)
            txt_No.Value = getMaxOfWorkFormNo()
            txt_TarikhSabt.Value = Setting.TarikheJary

            CheckBox2.CheckState = CheckState.Checked

            CheckBox3.CheckState = CheckState.Checked

        End If

    End Sub
    Public Overrides Sub ClearForm()
        For Each dr As System.Windows.Forms.DataGridViewRow In DataGridView1.Rows
            DataGridView1.Rows.Remove(dr)

        Next
        MyBase.ClearForm()
    End Sub
    Function getMaxOfWorkFormNo() As Integer
        getMaxOfWorkFormNo = BaseDataObject.DataAccess.ExecScalar("select isnull(max(no),0)+1 from Pm_Lab_Rol_Master")
    End Function

    
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        If txtDis.Value = "" Then
            MessageBoxFa.Show("لطفا شرح کار را بنویسید")
            Return
        End If

        Dim drInsert As DataRow = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.NewRow

        drInsert(1) = txtDate.Value.ToString

        drInsert(2) = txtDis.Text


        Try
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.Rows.Add(drInsert)
        Catch ex As ConstraintException
            MessageBoxFa.Show("خطا")
        End Try
        DataGridView1.Refresh()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Me.GroupBox2.Enabled = False
        End If
        If Not CheckBox2.Checked Then
            Me.GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Me.GroupBox3.Enabled = False
        End If
        If Not CheckBox3.Checked Then
            Me.GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub btn_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove.Click
        Try
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Delete( _
        DataGridView1.CurrentRow.Index)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD.TextChanged

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Masool.SelectedIndexChanged
3:
    End Sub

    Private Sub Panel2_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub txt_TarikhVorod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TarikhVorod.TextChanged

    End Sub

    Private Sub Label15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        Dim f As New Frm_TajhizSelect
        If f.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Not f.selectedSubject Is Nothing Then
                txtSelect.Value = f.selectedSubject.Text
                txtSelect_Srl.Text = f.selectedSubject.Srl
                cmb_Sazande.Focus()
            End If
        End If
    End Sub
  

    Private Sub btn_SelectMahal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectMahal.Click
        Dim f As New Frm_MahalSelect
        If f.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Not f.selectedSubject1 Is Nothing Then
                txtSelectMahal.Value = f.selectedSubject1.Text
                txtSelectMahal_Srl.Text = f.selectedSubject1.Srl
                txt_TarikhVorod.Focus()
            End If
        End If
    End Sub

    Private Sub btn_SelectMahaleNasb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectMahaleNasb.Click
        Dim f As New Frm_MahalSelect
        If f.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Not f.selectedSubject2 Is Nothing Then
                txtSelectNasb.Value = f.selectedSubject2.Text
                txtSelectNasb_Srl.Text = f.selectedSubject2.Srl
                txt_KhorojDate.Focus()
            End If
        End If
    End Sub

   

    'Private Sub txtSelect_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSelect.TextChanged
    '    If checkDeviceNameNow Then
    '        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_Lab_Rol_Tajhiz where srl=" + txtSelect.Value.ToString)
    '        If Not dr Is Nothing Then
    '            txtSelect.Value = dr("Name")
    '            checkDeviceNameNow = False
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSelectMahal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSelectMahal.TextChanged
    '    If checkMahalNow Then
    '        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_Lab_Rol_Mahal where srl=" + txtSelectMahal.Value.ToString)
    '        If Not dr Is Nothing Then
    '            txtSelectMahal.Value = dr("Name")
    '            checkMahalNow = False
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSelectNasb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSelectNasb.TextChanged
    '    If checkMahal1Now Then
    '        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_Lab_Rol_Mahal where srl=" + txtSelectNasb.Value.ToString)
    '        If Not dr Is Nothing Then
    '            txtSelectNasb.Value = dr("Name")
    '            checkMahal1Now = False
    '        End If
    '    End If
    'End Sub

    
    Private Sub txtSelect_Srl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSelect_Srl.TextChanged
        If checkDeviceNameNow Then
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_Lab_Rol_Tajhiz where srl=" + txtSelect_Srl.Value.ToString)
            If Not dr Is Nothing Then
                txtSelect.Value = dr("Name")
                checkDeviceNameNow = False
            End If
        End If
    End Sub

    Private Sub txtSelectMahal_Srl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSelectMahal_Srl.TextChanged
        If checkMahalNow Then
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_Lab_Rol_Mahal where srl=" + txtSelectMahal_Srl.Value.ToString)
            If Not dr Is Nothing Then
                txtSelectMahal.Value = dr("Name")
                checkMahalNow = False
            End If
        End If
    End Sub

    Private Sub txtSelectNasb_Srl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSelectNasb_Srl.TextChanged
        If checkMahal1Now Then
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_Lab_Rol_Mahal where srl=" + txtSelectNasb_Srl.Value.ToString)
            If Not dr Is Nothing Then
                txtSelectNasb.Value = dr("Name")
                checkMahal1Now = False
            End If
        End If
    End Sub

    Private Sub txt_No_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_No.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New Frm_Lab_Rol_Tamir_Vw
        f.ShowDialog()
    End Sub

    
    Private Sub cmb_Sazande_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sazande.SelectedIndexChanged

    End Sub
End Class