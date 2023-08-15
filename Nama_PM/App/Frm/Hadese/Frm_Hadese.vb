Public Class Frm_Hadese

    Dim Srl_Pm_Hadese As Integer = -1

    Public Sub New(ByVal Srl_Pm_Hadese As Integer)
        InitializeComponent()
        Me.Srl_Pm_Hadese = Srl_Pm_Hadese
        
    End Sub

    Private Sub Frm_Hadese_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pm_Hadese_KhesaratTableAdapter.Fill(Ds_Hadese.Pm_Hadese_Khesarat, Srl_Pm_Hadese)
        Pm_Hadese_PishnahadTableAdapter.Fill(Ds_Hadese.Pm_Hadese_Pishnahad, Srl_Pm_Hadese)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_Hadese_AmalkardSystemTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_AmalkardSystem)
        Me.Pm_Hadese_KhesaratTypeTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratType)
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_LineTableAdapter.Fill(Me.Ds_Pm.Pm_Line, -1)
        Me.Pm_Hadese_SharayetBorozTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_SharayetBoroz)
        Me.Pm_Hadese_ElatTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_Elat)
        'Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, -1)
        chk_AllVahed.Checked = True

        If Srl_Pm_Hadese = -2 Then
            Txt_ReportNo.Value = getMaxOfWorkFormNo()
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("Pm_Hadese", Srl_Pm_Hadese)

            Txt_ReportNo.Value = dr("ReportNo")
            ts_Sat.Value = dr("Sat")
            txt_Tarikh.Value = dr("Tarikh")
            ComboBox3.SelectedValue = dr("Srl_PM_Hadese_Elat")
            ComboBox1.SelectedValue = dr("Srl_Pm_Hadese_SharayetBoroz")
            cmb_PmPost.SelectedValue = dr("Srl_Pm_Post")
            cmb_Pm_Line.SelectedValue = dr("Srl_Pm_Line")
            If cmb_Pm_Line.SelectedValue Is Nothing Then
                rbt_Line.Checked = False
                RadioButton1.Checked = True
            Else
                rbt_Line.Checked = True
                RadioButton1.Checked = False
            End If
            txt_Kelidi.Value = dr("Kelidi")
            txt_SharhHadese.Value = dr("SharhHadese")
            txt_EghdamatAvalie.Value = dr("EghdamatAvalie")
            chk_GostareshHadese.Checked = dr("GostareshHadese")
            txt_ElatGostareshHadese.Value = dr("ElatGostareshHadese")
            cmb_Pm_Hadese_Amalkard.SelectedValue = dr("Srl_Pm_Hadese_Amalkard")
            cmb_Pm_Group.SelectedValue = dr("Srl_Pm_Group")
            cmb_VAhed.SelectedValue = dr("Srl_Pm_Vahed")
            txt_NatijeBarasi.Value = dr("NatijeBarasi")
            txt_DastorModir.Value = dr("DastorModir")
        End If
        chk_GostareshHadese_CheckedChanged(Nothing, Nothing)
    End Sub

    Function getMaxOfWorkFormNo() As Integer
        getMaxOfWorkFormNo = BaseDataObject.DataAccess.ExecScalar("select isnull(max(ReportNo),0)+1 from Pm_Hadese")
    End Function

    Private Sub btn_SelectDEvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectDEvice.Click
        If cmb_PmPost.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا پست را مشخص نمائید")
            cmb_PmPost.Focus()
            Return
        End If
        Dim s As New Frm_DeviceSelect(cmb_PmPost.SelectedValue)
        s.ShowDialog()

        If Not s.SelectedDevice Is Nothing Then
            txt_DeviceKhesaratName.Value = s.SelectedDevice.Text
            txt_Srl_DeviceKhesarat.Text = s.SelectedDevice.Srl
        End If
    End Sub

    Function GetDevice() As DataTable
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, cmb_PmPost.SelectedValue)
        Return Ds_Hadese.Pm_Hadese_KhesaratDevice
    End Function

    Private Sub chk_GostareshHadese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_GostareshHadese.CheckedChanged
        txt_ElatGostareshHadese.Enabled = chk_GostareshHadese.Checked
    End Sub

    Private Sub btn_Add_DEvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_DEvice.Click
        If txt_DeviceKhesaratName.Value = "" And RadioButton1.Checked = True Then
            MessageBoxFa.Show("لطفا يک دستگاه را انتخاب کنيد")
            Return
        End If
        Dim drInsert As DataRow = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.NewRow

        drInsert(0) = txt_DeviceKhesaratName.Value
        drInsert(1) = cmb_Device.Text
        drInsert(2) = tbox_ZamaneKhamoshi.Value
        drInsert(3) = txt_Hour.Text + ":" + txt_Min.Text
        If RadioButton1.Checked = True Then
            drInsert(4) = txt_Srl_DeviceKhesarat.Value
            'Else
            '    drInsert(4) = ""
        End If
        drInsert(5) = cmb_Device.SelectedValue

        DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.Rows.Add(drInsert)
        DataGridView1.Refresh()
        txt_Min.Value = "00"
        txt_Hour.Value = "00"
        tbox_ZamaneKhamoshi.Value = 0
        txt_DeviceKhesaratName.Value = ""
    End Sub

    Private Sub btn_Remove_Device_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove_Device.Click
        Try
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Delete( _
        DataGridView1.CurrentRow.Index)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Add_Pishnahad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Pishnahad.Click
        If txt_PishnahadEslahi.Value = "" Then
            MessageBoxFa.Show("لطفا يک پيشنهاد را وارد کنيد")
            Return
        End If
        Dim drInsert As DataRow = DirectCast(DirectCast(DataGridView3.DataSource, BindingSource).List, DataView).Table.NewRow

        drInsert(0) = txt_PishnahadEslahi.Value

        DirectCast(DirectCast(DataGridView3.DataSource, BindingSource).List, DataView).Table.Rows.Add(drInsert)
        DataGridView1.Refresh()
        txt_PishnahadEslahi.Value = ""
    End Sub

    Private Sub btn_Remove_Pishnahad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove_Pishnahad.Click
        Try
            DirectCast(DirectCast(DataGridView3.DataSource, BindingSource).List, DataView).Delete( _
        DataGridView3.CurrentRow.Index)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If Txt_ReportNo.Value.ToString = "" Then
            MessageBoxFa.Show("لطفا شماره فرم را پر کنيد")
            Txt_ReportNo.Focus()
            Return
        End If

        'If cmb_Pm_Group.SelectedValue Is Nothing Then
        '    MessageBoxFa.Show("لطفا يک گروه را انتخاب کنيد")
        '    cmb_Pm_Group.Focus()
        '    Return
        'End If

        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Hadese")
        dr("ReportNo") = Txt_ReportNo.Value
        dr("Sat") = PublicFunction.GetSaat(ts_Sat.time)
        dr("Tarikh") = txt_Tarikh.Value
        dr("Srl_PM_Hadese_Elat") = ComboBox3.SelectedValue
        dr("Srl_Pm_Hadese_SharayetBoroz") = ComboBox1.SelectedValue
        dr("Kelidi") = txt_Kelidi.Value
        dr("SharhHadese") = txt_SharhHadese.Value
        dr("EghdamatAvalie") = txt_EghdamatAvalie.Value
        dr("GostareshHadese") = chk_GostareshHadese.Checked
        dr("ElatGostareshHadese") = txt_ElatGostareshHadese.Value
        dr("Srl_Pm_Hadese_Amalkard") = cmb_Pm_Hadese_Amalkard.SelectedValue
        If Not cmb_Pm_Group.SelectedValue Is Nothing Then
            dr("Srl_Pm_Group") = cmb_Pm_Group.SelectedValue
        End If
        dr("Srl_Pm_Vahed") = cmb_VAhed.SelectedValue
        dr("NatijeBarasi") = txt_NatijeBarasi.Value
        dr("DastorModir") = txt_DastorModir.Value
        dr("Srl_SubmitUser") = Setting.Srl_User
        dr("SubmitDate") = Setting.Now

        If RadioButton1.Checked = True Then
            dr("Srl_Pm_Post") = cmb_PmPost.SelectedValue
        Else
            dr("Srl_Pm_Line") = cmb_Pm_Line.SelectedValue
        End If


        BaseDataObject.DataAccess.BeginTransaction()

        If Srl_Pm_Hadese <> -2 And Srl_Pm_Hadese <> -1 Then
            dr("srl") = Srl_Pm_Hadese

            If Not BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If

            If Not BaseDataObject.DataAccess.Delete("Pm_Hadese_Pishnahad", " Srl_Pm_Hadese=" + Srl_Pm_Hadese.ToString) Or _
                 Not BaseDataObject.DataAccess.Delete("Pm_Hadese_Khesarat", " Srl_Pm_Hadese=" + Srl_Pm_Hadese.ToString) Then
                MessageBoxFa.Show("خطا در ثبت اطلاعات")
                BaseDataObject.DataAccess.RollBack()
                Return
            End If

            For Each dtg As DataGridViewRow In DataGridView1.Rows
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Hadese_Khesarat")
                dr_details("Srl_Pm_Hadese") = Srl_Pm_Hadese
                dr_details("Srl_Pm_Hadese_KhesaratDevice") = dtg.Cells("Srl_Pm_Hadese_KhesaratDevice").Value
                dr_details("Srl_Pm_Hadese_KhesaratType") = dtg.Cells("Srl_Pm_Hadese_KhesaratType").Value
                dr_details("KhamoshiValue") = dtg.Cells(2).Value
                dr_details("ModateKhoroj") = dtg.Cells(3).Value
                If Not BaseDataObject.DataAccess.Insert(dr_details, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next

            For Each dtg As DataGridViewRow In DataGridView3.Rows
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Hadese_Pishnahad")
                dr_details("Srl_Pm_Hadese") = Srl_Pm_Hadese
                dr_details("pishnahad") = dtg.Cells(0).Value
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
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Hadese_Khesarat")
                dr_details("Srl_Pm_Hadese") = Srl_Maseter
                dr_details("Srl_Pm_Hadese_KhesaratDevice") = dtg.Cells("Srl_Pm_Hadese_KhesaratDevice").Value
                dr_details("Srl_Pm_Hadese_KhesaratType") = dtg.Cells("Srl_Pm_Hadese_KhesaratType").Value
                dr_details("KhamoshiValue") = dtg.Cells(2).Value
                dr_details("ModateKhoroj") = dtg.Cells(3).Value
                If Not BaseDataObject.DataAccess.Insert(dr_details, False) Then
                    MessageBoxFa.Show("خطا در ثبت اطلاعات")
                    BaseDataObject.DataAccess.RollBack()
                    Return
                End If
            Next

            For Each dtg As DataGridViewRow In DataGridView3.Rows
                Dim dr_details As DataRow = BaseDataObject.DataAccess.NewRow("Pm_Hadese_Pishnahad")
                dr_details("Srl_Pm_Hadese") = Srl_Maseter
                dr_details("pishnahad") = dtg.Cells(0).Value
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
            cmb_VAhed.Enabled = True

            'txt_ModateKhoroj.Text = "___/__"
            Pm_Hadese_KhesaratTableAdapter.Fill(Ds_Hadese.Pm_Hadese_Khesarat, -2)
            Pm_Hadese_PishnahadTableAdapter.Fill(Ds_Hadese.Pm_Hadese_Pishnahad, -2)
        End If
    End Sub

    Public Overrides Sub ClearForm()
        MyBase.ClearForm()
        Txt_ReportNo.Value = getMaxOfWorkFormNo()
        Srl_Pm_Hadese = -1

    End Sub

    Private Sub chk_AllVahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllVahed.CheckedChanged
        cmb_VAhed.Enabled = chk_AllVahed.Checked
        If chk_AllVahed.Checked Then
            Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, cmb_VAhed.SelectedValue)
        Else
            Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, -1)
        End If
    End Sub

    Private Sub cmb_VAhed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_VAhed.SelectedIndexChanged
        Ds_Pm.Pm_FindGroup.Rows.Clear()
        Me.Ds_Pm.Pm_Group.Rows.Clear()
        If cmb_VAhed.SelectedValue > -1 Then
            Pm_FindGroupTableAdapter.Fill(Me.Ds_Pm.Pm_FindGroup, cmb_PmPost.SelectedValue, cmb_VAhed.SelectedValue)
            cmb_Pm_Group.DataSource = Me.Ds_Pm.Pm_FindGroup
            If Ds_Pm.Pm_FindGroup.Rows.Count <= 0 Then
                Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, cmb_VAhed.SelectedValue)
                cmb_Pm_Group.DataSource = Me.Ds_Pm.Pm_Group
            End If
        End If
    End Sub

    Private Sub cmb_PmPost_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PmPost.SelectedIndexChanged
        Dim temp As Object
        temp = BaseDataObject.DataAccess.ExecScalar("select name from Pm_PostDetails ,pm_posttype where pm_posttype.srl=srl_pm_posttype and Srl_Pm_Post =" + IIf(cmb_PmPost.SelectedValue Is Nothing, -1, cmb_PmPost.SelectedValue).ToString())
        If Not temp Is Nothing Then
            lb_Posttype.Text = temp.ToString()
        Else
            lb_Posttype.Text = ""
        End If
        Try
            Ds_Pm.Pm_FindGroup.Rows.Clear()
            Me.Ds_Pm.Pm_Group.Rows.Clear()
            If cmb_VAhed.SelectedValue > -1 Then
                Dim Srl_Post As Integer = IIf(cmb_PmPost.SelectedValue Is Nothing, -1, cmb_PmPost.SelectedValue)
                Dim srl_Vahed As Integer = IIf(cmb_VAhed.SelectedValue Is Nothing, -1, cmb_VAhed.SelectedValue)
                Pm_FindGroupTableAdapter.Fill(Me.Ds_Pm.Pm_FindGroup, Srl_Post, srl_Vahed)
                cmb_Pm_Group.DataSource = Me.Ds_Pm.Pm_FindGroup
                If Ds_Pm.Pm_FindGroup.Rows.Count <= 0 Then
                    Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, cmb_VAhed.SelectedValue)
                    cmb_Pm_Group.DataSource = Me.Ds_Pm.Pm_Group
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub btn_Before_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Before.Click
        If Txt_ReportNo.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(False)
                End If
            Else
                NextOrBeforeForm(False)
            End If
        End If
    End Sub
    Private Sub btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Next.Click
        If Txt_ReportNo.Value <> "" Then
            If (FormState = FormStates.Edit) Then
                If (MessageBox.Show("آیا مایلید از ویرایش فرم جاری خارج شوید؟") = System.Windows.Forms.DialogResult.Yes) Then
                    NextOrBeforeForm(True)
                End If
            Else
                NextOrBeforeForm(True)
            End If
        End If
    End Sub
    Public Sub NextOrBeforeForm(ByVal Flag As Boolean)
        Dim FrmNo As Integer
        If Flag Then
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_Hadese where ReportNo >" + Txt_ReportNo.Value + " Order by ReportNo"))
        Else
            FrmNo = CInt(BaseDataObject.DataAccess.ExecScalar("select top 1 srl from Pm_Hadese where ReportNo <" + Txt_ReportNo.Value + " Order by ReportNo desc"))
        End If
        If FrmNo > 0 Then
            Srl_Pm_Hadese = FrmNo
            Me.Frm_Hadese_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_SHow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SHow.Click

        Dim Number As String = Txt_ReportNo.Value
        ClearForm()
        Txt_ReportNo.Value = Number
        Srl_Pm_Hadese = CInt(BaseDataObject.DataAccess.ExecScalar("select srl from Pm_Hadese where ReportNo =" + Number))
        If Srl_Pm_Hadese = 0 Then
            MessageBox.Show("موردي يافت نشد")
            Return
        End If
        Frm_Hadese_Load(Nothing, Nothing)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        ClearForm()
    End Sub


    Private Sub rbt_Line_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Line.CheckedChanged
        If rbt_Line.Checked = True Then
            cmb_PmPost.Enabled = False
            cmb_Pm_Line.Enabled = True
            btn_SelectDEvice.Enabled = False
            txt_DeviceKhesaratName.Enabled = False
            
        Else
            cmb_PmPost.Enabled = True
            cmb_Pm_Line.Enabled = False
            btn_SelectDEvice.Enabled = True
            txt_DeviceKhesaratName.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            cmb_PmPost.Enabled = True
            cmb_Pm_Line.Enabled = False
            btn_SelectDEvice.Enabled = True
            txt_DeviceKhesaratName.Enabled = True
        Else
            cmb_PmPost.Enabled = False
            cmb_Pm_Line.Enabled = True
            btn_SelectDEvice.Enabled = False
            txt_DeviceKhesaratName.Enabled = False

        End If
    End Sub
End Class
