Public Class Frm_Lab_Rol_Tamir

    Dim Srl_Pm_Lab_Roliaj As Integer
    Dim checkDeviceNameNow As Boolean = False

    Public Sub New(ByVal Srl_Pm_Lab_Roliaj As Integer)
        InitializeComponent()
        Me.Srl_Pm_Lab_Roliaj = Srl_Pm_Lab_Roliaj
    End Sub

    Private Sub Frm_Lab_Rol_Tamir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_Lab_Rol_GhatatMasrafiTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_GhatatMasrafi)
        Me.Pm_Lab_Rol_ElateVorodTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_ElateVorod)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        Me.Pm_Lab_Rol_SatheAhamniatTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_SatheAhamniat)
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Pm_Lab_Rol_Tamirat_GhateMasrafiTableAdapter.Fill(Ds_Lab.Pm_Lab_Rol_Tamirat_GhateMasrafi, Srl_Pm_Lab_Roliaj)
        txt_No.Focus()
        If Srl_Pm_Lab_Roliaj = -2 Then
            txt_No.Value = getMaxOfWorkFormNo()
            txt_TarikhSabt.Value = Setting.TarikheJary
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Lab_Rol_Tamirat", Srl_Pm_Lab_Roliaj)

            cmb_PmPost.SelectedValue = dr("Srl_Pm_Post")
            checkDeviceNameNow = True
            txt_Srl_DeviceKhesarat.Value = dr("Srl_Pm_Hadese_KhesaratDevice")
            cmb_SatheaAhamiat.SelectedValue = dr("Srl_Pm_Lab_Rol_SatheAhamniat")
            cmb_Elat.SelectedValue = dr("Srl_Pm_Lab_Rol_ElateVorod")
            cmb_Tavasot.SelectedValue = dr("Srl_Acc_Ashkhas_Tavasot")
            txt_No.Value = dr("No")
            txt_NafarSat.Value = dr("NafarSAt")
            txt_TarikhSabt.Value = dr("SabtDate")
            txt_TarikhVorod.Value = dr("VorodDate")
            txt_TarikhVorodBaze.Value = dr("VorodDateBound")
            txt_TarikhTamir.Value = dr("TamirDate")
            txt_tarikhTamirBaze.Value = dr("TamirDateBound")
            txt_TarikhTahvil.Value = dr("TahvilDate")
            txt_Dis.Value = dr("dis")
            cmb_TahvilePerson.SelectedValue = dr("Srl_Acc_Ashkhas_Tahvil")
        End If
    End Sub

    Function getMaxOfWorkFormNo() As Integer
        getMaxOfWorkFormNo = BaseDataObject.DataAccess.ExecScalar("select isnull(max(no),0)+1 from Pm_Lab_Rol_Tamirat")
    End Function

    Private Sub btn_SelectDEvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectDEvice.Click
        Dim s As New Frm_DeviceSelect(cmb_PmPost.SelectedValue)
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_DeviceKhesaratName.Value = s.SelectedDevice.Text
            txt_Srl_DeviceKhesarat.Text = s.SelectedDevice.Srl
            cmb_SatheaAhamiat.Focus()
        End If
    End Sub

    Function GetDevice() As DataTable
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_PmPost.SelectedValue)
        Return Ds_Hadese.Pm_Hadese_KhesaratDevice
    End Function

    Private Sub btn_Add_DEvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_DEvice.Click
        If txt_DeviceKhesaratName.Value = "" Then
            MessageBoxFa.Show("لطفا يک دستگاه را انتخاب کنيد")
            Return
        End If

        Dim drInsert As DataRow = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.NewRow

        drInsert(0) = cmb_Device.SelectedValue
        drInsert(1) = cmb_Device.Text
        drInsert(2) = tbox_Tedad.Text

        Try
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.Rows.Add(drInsert)
        Catch ex As ConstraintException
            MessageBoxFa.Show("قطعه موجود است")
        End Try
        DataGridView1.Refresh()
    End Sub

    Private Sub btn_Remove_Device_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove_Device.Click
        Try
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Delete( _
        DataGridView1.CurrentRow.Index)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If txt_No.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا شماره فرم را پر کنيد")
            txt_No.Focus()
            Return
        End If

        If txt_Srl_DeviceKhesarat.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا يک دستگاه را انتخاب کنيد")
            txt_Srl_DeviceKhesarat.Focus()
            Return
        End If

        If Srl_Pm_Lab_Roliaj <> -2 Then
            If (BaseDataObject.DataAccess.ExistNum("Pm_Lab_Rol_Tamirat", "No", txt_No.Value _
                 , "Srl<>" + Srl_Pm_Lab_Roliaj.ToString) > 0) Then
                MessageBoxFa.Show("شماره فرم تکراري است")
                txt_No.Focus()
                Return
            End If
        Else
            If (BaseDataObject.DataAccess.ExistNum("Pm_Lab_Rol_Tamirat", "No", txt_No.Value) > 0) Then
                MessageBoxFa.Show("شماره فرم تکراري است")
                txt_No.Focus()
                Return
            End If
        End If

        If txt_TarikhTamir.Value <> "" And txt_tarikhTamirBaze.Value <> "" Then
            If txt_TarikhTamir.Value > txt_tarikhTamirBaze.Value Then
                MessageBoxFa.Show("بازه زماني از تاريخ اوليه بزرگتر است")
                txt_tarikhTamirBaze.Focus()
                Return
            End If
        End If

        If txt_TarikhVorod.Value <> "" And txt_TarikhVorodBaze.Value <> "" Then
            If txt_TarikhVorod.Value > txt_TarikhVorodBaze.Value Then
                MessageBoxFa.Show("بازه زماني از تاريخ اوليه بزرگتر است")
                txt_TarikhVorodBaze.Focus()
                Return
            End If
        End If

        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_Tamirat")
        dr("Srl_Pm_Post") = cmb_PmPost.SelectedValue
        dr("Srl_Pm_Hadese_KhesaratDevice") = txt_Srl_DeviceKhesarat.Value
        dr("Srl_Pm_Lab_Rol_SatheAhamniat") = cmb_SatheaAhamiat.SelectedValue
        dr("Srl_Acc_Ashkhas_Tavasot") = cmb_Tavasot.SelectedValue
        dr("Srl_Pm_Lab_Rol_ElateVorod") = cmb_Elat.SelectedValue
        dr("No") = txt_No.Value
        dr("NafarSAt") = IIf(txt_NafarSat.Value = "", 0, txt_NafarSat.Value)
        dr("SabtDate") = txt_TarikhSabt.Value

        dr("VorodDate") = txt_TarikhVorod.Value
        dr("VorodDateBound") = txt_TarikhVorodBaze.Value

        dr("TamirDate") = txt_TarikhTamir.Value
        dr("TamirDateBound") = txt_tarikhTamirBaze.Value

        dr("TahvilDate") = txt_TarikhTahvil.Value
        dr("Dis") = txt_Dis.Value

        dr("Srl_Acc_Ashkhas_Tahvil") = cmb_TahvilePerson.SelectedValue

        dr("Srl_SubmitUser") = Setting.Srl_User
        dr("SubmitDate") = Setting.Now

        BaseDataObject.DataAccess.BeginTransaction()

        If Srl_Pm_Lab_Roliaj <> -2 Then
            dr("srl") = Srl_Pm_Lab_Roliaj

            If Not BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If

            If Not BaseDataObject.DataAccess.Delete("Pm_Lab_Rol_Tamirat_GheteMasrafi", " Srl_Pm_Lab_Rol_Tamirat=" + Srl_Pm_Lab_Roliaj.ToString) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If

            For Each dtg As DataGridViewRow In DataGridView1.Rows
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_Tamirat_GheteMasrafi")
                dr_details("Srl_Pm_Lab_Rol_Tamirat") = Srl_Pm_Lab_Roliaj
                dr_details("Pm_Lab_Rol_GhatatMasrafi") = dtg.Cells(0).Value
                dr_details("tedad") = dtg.Cells(2).Value
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
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Lab_Rol_Tamirat_GheteMasrafi")
                dr_details("Srl_Pm_Lab_Rol_Tamirat") = Srl_Maseter
                dr_details("Pm_Lab_Rol_GhatatMasrafi") = dtg.Cells(0).Value
                dr_details("tedad") = dtg.Cells(2).Value
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
            Pm_Lab_Rol_Tamirat_GhateMasrafiTableAdapter.Fill(Ds_Lab.Pm_Lab_Rol_Tamirat_GhateMasrafi, Srl_Pm_Lab_Roliaj)
            txt_No.Value = getMaxOfWorkFormNo()
            txt_NafarSat.Value = 0
        End If
    End Sub
    Public Overrides Sub ClearForm()
        For Each dr As System.Windows.Forms.DataGridViewRow In DataGridView1.Rows
            DataGridView1.Rows.Remove(dr)

        Next
        MyBase.ClearForm()
    End Sub
    Private Sub txt_Srl_DeviceKhesarat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Srl_DeviceKhesarat.TextChanged
        If checkDeviceNameNow Then
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select * from Pm_Hadese_KhesaratDevice where srl=" + txt_Srl_DeviceKhesarat.Value.ToString)
            If Not dr Is Nothing Then
                txt_DeviceKhesaratName.Value = dr("Name")
                checkDeviceNameNow = False
            End If
        End If
    End Sub

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
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_Lab_Rol_Tamirat where Pm_Lab_Rol_Tamirat.No >" + txt_No.Value + " Order by Pm_Lab_Rol_Tamirat.no"))
        Else
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_Lab_Rol_Tamirat where Pm_Lab_Rol_Tamirat.no <" + txt_No.Value + " Order by Pm_Lab_Rol_Tamirat.no desc"))
        End If
        If FrmNo > 0 Then
            ClearForm()
            Srl_Pm_Lab_Roliaj = FrmNo
            Me.Frm_Lab_Rol_Tamir_Load(Nothing, Nothing)
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

        Dim Number As String = txt_No.Value
        'ClearForm()
        txt_No.Value = Number
        Srl_Pm_Lab_Roliaj = CInt(BaseDataObject.DataAccess.ExecScalar("select srl from Pm_Lab_Rol_Tamirat where Pm_Lab_Rol_Tamirat.no ='" + Number + "'"))
        If Srl_Pm_Lab_Roliaj = 0 Then
            MessageBox.Show("موردي يافت نشد")
            Return
        End If
        Frm_Lab_Rol_Tamir_Load(Nothing, Nothing)
    End Sub

    Private Sub txt_TarikhSabt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_DeviceKhesaratName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DeviceKhesaratName.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class