
Public Class Frm_FactorSubmit
    Dim Factor_Type As Setting.FactorTypes = Setting.FactorTypes.Kharid
    Dim Edit_CurrentIndex As Integer = -1
    Dim Srl_FactorMaster As Integer = -1
    Dim LoadReport As Boolean = False
    Dim stringError As String = "خطا در ثبت اطلاعات"

    Public Sub New(ByVal Srl_FactorMaster As Integer)
        InitializeComponent()
        'lbl_FacNoKharid.Visible = False
        'txt_FActorNoKhaird.Visible = False
        'Cmb_Anbar.Visible = False
        'Lbl_Anbar.Visible = False
        Panel_Kharid.Visible = False
        Me.Size = New System.Drawing.Size(957, 637)
        Me.Factor_Type = Factor_Type
        Stg_AnbarTableAdapter.Fill(Ds_Kala.Stg_Anbar, -1)
        Me.Srl_FactorMaster = Srl_FactorMaster
    End Sub

    Private Sub Frm_FactorSubmit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Btn_history.Enabled = False
        'Btn_PriceRegister.Enabled = False
        Pm_SherkatTableAdapter.Fill(Ds_Ashkhas.Pm_Sherkat, -1)

        MyBase.StatusStrip1.Items.Add("F2 دخيره")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("F3 جستجو")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("F4 وبرايش")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("F6 ذخيره و گزارش")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("Del حذف")
        MyBase.StatusStrip1.Items.Add("-")
        MyBase.StatusStrip1.Items.Add("Ctrl انتخاب جدول")

        txt_Jam.TabStop = False
        txt_FactorNo.TabStop = False
        txt_JamKol.TabStop = False

        txt_FatorDate.Value = Setting.TarikheJary

        If Srl_FactorMaster <> -1 Then
            txt_FactorNo.ReadOnly = True
            Dim dr_Master As DataRow = BaseDataObject.DataAccess.GetRow("Stg_FactorMaster", "Srl=" + Srl_FactorMaster.ToString)
            If (dr_Master Is Nothing) Then
                Me.Close()
                Return
            End If
            lk_Sherkat.LoadByValue(dr_Master("Acc_Coding_Ashkhas"))
            txt_FactorNo.Value = dr_Master("FactorNo")
            txt_FatorDate.Value = dr_Master("FactorDate")
            txt_Dis.Value = dr_Master("Dis")
            txt_FActorNoKhaird.Value = dr_Master("FacNoKharid")
            Stg_FactorDetailsTableAdapter.Fill(Ds_Kala.Stg_FactorDetails, Srl_FactorMaster)
            calSum()
            ReSortRadif()
            'SumMaliat_Avarez()
        Else
            txt_FactorNo.Value = PublicFunction.GetMaxOfFactorNoInThisFactorType(2)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            btn_Save_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
        ElseIf e.KeyCode = Keys.F4 Then
            Btn_Edit_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Delete Then
            If DataGridView1.Focused Then
                Btn_Del_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.ControlKey Then
            DataGridView1.Focus()
        ElseIf e.KeyCode = Keys.F6 Then
            LoadReport = True
            btn_Save_Click(Nothing, Nothing)
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        'If lk_Ashkhas.Result Is Nothing Then
        Dim SanadSharh As String = ""
        If lk_Sherkat.Result Is Nothing Then
            MessageBoxFa.Show("لطفا يك شرکت را انتخاب كنيد")
            lk_Sherkat.Focus()
            Return
        End If
        If DataGridView1.RowCount = 0 Then
            MessageBoxFa.Show("هيج رديفي براي فاكتور ثبت نشده")
            Return
        End If

        Dim dt_detail As DataTable = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table
        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Stg_FactorMaster")
        If dr Is Nothing Then
            MessageBoxFa.Show(stringError)
            Return
        End If
        dr("Srl_Stg_FacType") = CType(Factor_Type, Integer)
        'dr("Srl_Stg_FacSaderatType") = Setting.FactorSaderatType.KharidDakheli
        'dr("Srl_Stg_FacSubmitStatus") = Setting.FactorSubmitStatus.SabtShode
        'dr("Srl_Stg_FacFrom") = CType(Setting.FactorFrom.Local, Integer)
        If Not lk_Sherkat.Result Is Nothing Then
            dr("Acc_Coding_Ashkhas") = lk_Sherkat.Result(0)
        End If
        If (Srl_FactorMaster <> -1) Then
            dr("FactorNo") = txt_FactorNo.Value
        Else
            dr("FactorNo") = PublicFunction.GetMaxOfFactorNoInThisFactorType(2)
        End If
        dr("FactorDate") = txt_FatorDate.Value
        dr("Dis") = txt_Dis.Value
        dr("Naghdi") = False
        dr("FacNoKharid") = txt_FActorNoKhaird.Value
        'dr("Srl_Years") = Setting.SaleMalyInfo.Srl
        'dr("Srl_Company") = Setting.CompanyInfo.Srl
        dr("Srl_SubmitUser") = Setting.Srl_User
        dr("SubmitDate") = Setting.Now
        'If Me.Factor_Type = Setting.FactorTypes.Kharid Then
        '    SanadSharh = "سند اتومات فاکتور خرید شماره : " + txt_FActorNoKhaird.Value.ToString + " - تاریخ : " + txt_FatorDate.Value + "- " + Shakhs_Select.Shakhs_Name
        'End If
        If (Srl_FactorMaster <> -1) Then
            Dim SelRow As New Integer
            dr("Srl") = Srl_FactorMaster
            While Not PublicFunction.BeginTransaction
            End While
            If BaseDataObject.DataAccess.Update(dr, 0) Then
                BaseDataObject.DataAccess.Delete("Stg_FactorDetails", "Srl_Stg_FactorMaster=" + Srl_FactorMaster.ToString)
                BaseDataObject.DataAccess.Delete("Stg_AnbarKala", "Srl_Stg_FactorMaster=" + Srl_FactorMaster.ToString)
                Dim dr_Factor_Detail As DataRow = BaseDataObject.DataAccess.NewRow("Stg_FactorDetails")
                Dim dr_Anbar_Mojodi As DataRow = BaseDataObject.DataAccess.NewRow("Stg_AnbarKala")
                Dim dr_det As DataRow = dt_detail.NewRow
                dr_Factor_Detail("Srl_Stg_FactorMaster") = Srl_FactorMaster

                For Each dr_det In dt_detail.Rows
                    If dr_det.RowState = DataRowState.Deleted Then
                        Continue For
                    End If
                    dr_Factor_Detail("Srl_Stg_Kala") = dr_det("Srl_Stg_Kala")
                    dr_Factor_Detail("Srl_Stg_Anbar") = dr_det("Srl_Stg_Anbar")
                    dr_Factor_Detail("Count") = dr_det("تعداد").ToString.Replace(" ", "")
                    dr_Factor_Detail("Price") = dr_det("قیمت")
                    dr_Factor_Detail("Takhfif") = dr_det("تخفیف")
                    dr_Factor_Detail("Tolid") = dr_det("تولید")
                    dr_Factor_Detail("ExpDate") = dr_det("انقضاء")
                    dr_Factor_Detail("SubmitDate") = Setting.Now
                    Dim Srl_FactorDetail As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr_Factor_Detail, False)
                    If Srl_FactorDetail = -1 Then
                        MessageBoxFa.Show(stringError)
                        Return
                    End If
                    dr_Anbar_Mojodi("Srl_Stg_FactorMaster") = Srl_FactorMaster
                    dr_Anbar_Mojodi("Srl_Stg_Kala") = dr_det("Srl_Stg_Kala")
                    dr_Anbar_Mojodi("Srl_Stg_Anbar") = dr_det("Srl_Stg_Anbar")
                    dr_Anbar_Mojodi("Floor") = 1
                    dr_Anbar_Mojodi("Row") = 1
                    dr_Anbar_Mojodi("ExpDate") = dr_det("انقضاء")
                    dr_Anbar_Mojodi("Srl_Stg_AnbarKala_Transfer") = DBNull.Value
                    dr_Anbar_Mojodi("TransferDate") = Setting.TarikheJary
                    dr_Anbar_Mojodi("Srl_SubmitUser") = Setting.Srl_User
                    dr_Anbar_Mojodi("SubmitDate") = Setting.Now
                    dr_Anbar_Mojodi("Srl_Stg_AnbarTypeTransfer") = Setting.AnbarTypeTransfer.FactorKharid
                    dr_Anbar_Mojodi("Count") = dr_det("تعداد")
                    If Not PublicFunction.InsertKalaPrice(dr_det("Srl_Stg_Kala"), Srl_FactorMaster, Srl_FactorDetail, -1) Then
                        MessageBox.Show("error on submit price")
                    End If

                    If Not BaseDataObject.DataAccess.Insert(dr_Anbar_Mojodi, False) Then
                        MessageBoxFa.Show(stringError)
                        Return
                    End If
                Next
            End If
        Else
            While Not PublicFunction.BeginTransaction
            End While
            Srl_FactorMaster = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            If Srl_FactorMaster = -1 Then
                MessageBoxFa.Show(stringError)
                Return
            End If
            If Srl_FactorMaster <> -1 Then
                Dim dr_Factor_Detail As DataRow = BaseDataObject.DataAccess.NewRow("Stg_FactorDetails")
                Dim dr_Anbar_Mojodi As DataRow = BaseDataObject.DataAccess.NewRow("Stg_AnbarKala")
                Dim dr_det As DataRow = dt_detail.NewRow
                dr_Factor_Detail("Srl_Stg_FactorMaster") = Srl_FactorMaster
                For Each dr_det In dt_detail.Rows
                    dr_Factor_Detail("Srl_Stg_Kala") = dr_det("Srl_Stg_Kala")
                    dr_Factor_Detail("Srl_Stg_Anbar") = dr_det("Srl_Stg_Anbar")
                    dr_Factor_Detail("Count") = dr_det("تعداد")
                    dr_Factor_Detail("Price") = dr_det("قیمت")
                    dr_Factor_Detail("Takhfif") = dr_det("تخفیف")
                    dr_Factor_Detail("ExpDate") = dr_det("انقضاء")
                    dr_Factor_Detail("Tolid") = dr_det("تولید")
                    dr_Factor_Detail("SubmitDate") = Setting.Now
                    Dim Srl_FactorDetail As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr_Factor_Detail, False)
                    If Srl_FactorDetail = -1 Then
                        MessageBoxFa.Show(stringError)
                        Return
                    End If
                    dr_Anbar_Mojodi("Srl_Stg_FactorMaster") = Srl_FactorMaster
                    dr_Anbar_Mojodi("Srl_Stg_Kala") = dr_det("Srl_Stg_Kala")
                    dr_Anbar_Mojodi("Srl_Stg_Anbar") = dr_det("Srl_Stg_Anbar")
                    dr_Anbar_Mojodi("Floor") = 1
                    dr_Anbar_Mojodi("Row") = 1
                    dr_Anbar_Mojodi("ExpDate") = dr_det("انقضاء")
                    dr_Anbar_Mojodi("Srl_Stg_AnbarKala_Transfer") = DBNull.Value
                    dr_Anbar_Mojodi("TransferDate") = Setting.TarikheJary
                    dr_Anbar_Mojodi("Srl_SubmitUser") = Setting.Srl_User
                    dr_Anbar_Mojodi("SubmitDate") = Setting.Now
                    dr_Anbar_Mojodi("Srl_Stg_AnbarTypeTransfer") = Setting.AnbarTypeTransfer.FactorKharid
                    dr_Anbar_Mojodi("Count") = dr_det("تعداد")
                    If Not PublicFunction.InsertKalaPrice(dr_det("Srl_Stg_Kala"), Srl_FactorMaster, Srl_FactorDetail, -1) Then
                        MessageBox.Show("error on submit price")
                    End If
                    If Not BaseDataObject.DataAccess.Insert(dr_Anbar_Mojodi, False) Then
                        MessageBoxFa.Show(stringError)
                        Return
                    End If
                Next
            End If
        End If

        If Not BaseDataObject.DataAccess.Commit Then
            MessageBoxFa.Show("ثبت اطلاعات با مشكل مواجه شد")
        Else
            MessageBoxFa.Show("اطلاعات ثبت شد")
        End If
        ShowRepoert()
        ClearFormData()
    End Sub

    Public Sub ShowRepoert()
        'If LoadReport Then
        '    Dim rp As New Rp_FactorKharid
        '    Rp_FactorTableAdapter.Fill(Ds_Factor.Rp_Factor, Srl_FactorMaster)
        '    Dim dt As DataTable = Ds_Factor.Rp_Factor
        '    rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
        '    rp.SetDataSource(dt)
        '    Dim frm_rp As New Frm_RpVw(rp)
        '    frm_rp.ShowDialog()
        'End If
    End Sub

    Sub ClearFormData()
        Me.Stg_FactorDetailsTableAdapter.Fill(Ds_Kala.Stg_FactorDetails, -1)
        Edit_CurrentIndex = -1
        KalaSelectManager1.ResetResult()
        txt_FActorNoKhaird.Value = txt_FActorNoKhaird.DefaultValue
        txt_Gheimat.Value = txt_Gheimat.DefaultValue
        txt_KalaNo.Value = txt_Gheimat.DefaultValue
        txt_JamKol.Text = 0
        Srl_FactorMaster = -1
        txt_FactorNo.Value = PublicFunction.GetMaxOfFactorNoInThisFactorType(Factor_Type)
        txt_ExpDate.Value = ""
        LoadReport = False
    End Sub

    Private Sub Btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click

        If KalaSelectManager1.Result Is Nothing Then
            MessageBoxFa.Show("لطفا يك کالا را انتخاب كنيد")
            KalaSelectManager1.Focus()
            Return
        End If

        If txt_Gheimat.Value = 0 Then
            MessageBoxFa.Show("لطفا قيمت را وارد کنبد")
            txt_Gheimat.Focus()
            Return
        End If

        'If txt_ExpDate.Value = "" Then
        '    MessageBoxFa.Show("لطفا تاريخ انقضا را وارد کنبد")
        '    txt_ExpDate.Focus()
        '    Return
        'End If

        If txt_Takhfif.Value > txt_Jam.Value Then
            MessageBoxFa.Show("مبلغ تخفيف از مبلغ کل بيشتر است")
            txt_Takhfif.Focus()
            Return
        End If
        If Edit_CurrentIndex <> -1 Then
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("کد کالا") = KalaSelectManager1.Result("کد")
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("نام کالا") = KalaSelectManager1.Result("نام")
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("تعداد") = txt_KalaNo.Value
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("واحد") = txt_Vahed.Value
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("قیمت") = txt_Gheimat.Value
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("جمع") = txt_Jam.Value
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
           , DataView).Table.Rows(Edit_CurrentIndex).Item("تخفیف") = txt_Takhfif.Value
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("انقضاء") = txt_ExpDate.Value
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("تولید") = txt_TolidDate.Value
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("انبار") = Cmb_Anbar.Text
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("مالیات") = 0
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("عوارض") = 0
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("Srl_Stg_FactorMaster") = 0
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("Srl_Stg_Kala") = KalaSelectManager1.Result("Srl")
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("Srl_Stg_Anbar") = Cmb_Anbar.SelectedValue
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("Sr_Stg_Vahed_Faree") = 0
            If DataGridView1.Rows.Count > 0 Then
                'DataGridView1.FirstDisplayedScrollingRowIndex = Edit_CurrentIndex
                DataGridView1.Rows(Edit_CurrentIndex).Selected = True
            End If
            Btn_Edit.Enabled = True
            DataGridView1.Enabled = True
            Btn_Del.Enabled = True
        Else
            Dim dr As DataRow = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.NewRow
            'If DataGridView1.RowCount = 0 Then
            '    dr(DirectCast(DirectCast(DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table, System.Data.DataTable).Columns(0), System.Data.DataColumn).ColumnName) = 1
            'Else
            '    dr(0) = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            '    , DataView).Table.Compute("Max(" + DirectCast(DirectCast(DirectCast(DirectCast( _
            '                              DataGridView1.DataSource, BindingSource).List, DataView).Table,  _
            '                              System.Data.DataTable).Columns(0), System.Data.DataColumn).ColumnName + ")", "").ToString + 1
            'End If

            dr("کد کالا") = KalaSelectManager1.Result("کد")
            dr("نام کالا") = KalaSelectManager1.Result("نام")
            dr("تعداد") = txt_KalaNo.Value
            dr("واحد") = txt_Vahed.Value
            dr("قیمت") = txt_Gheimat.Value
            dr("جمع") = txt_Jam.Text
            dr("تخفیف") = txt_Takhfif.Value
            dr("تولید") = txt_TolidDate.Value
            dr("انقضاء") = txt_ExpDate.Value
            dr("انبار") = Cmb_Anbar.Text
            dr("مالیات") = 0
            dr("عوارض") = 0
            dr("Srl_Stg_FactorMaster") = 0
            dr("Srl_Stg_Kala") = KalaSelectManager1.Result("Srl")
            dr("Srl_Stg_Anbar") = Cmb_Anbar.SelectedValue
            dr("Sr_Stg_Vahed_Faree") = 0

            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.Rows.Add(dr)
            If DataGridView1.Rows.Count > 0 Then
                DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            End If
        End If
        ReSortRadif()
        calSum()
        ClrearAfterAdd()
    End Sub

    Private Sub calSum()
        If DataGridView1.RowCount > 0 Then

            txt_JamKol.Value = String.Format("{0:N0}", Double.Parse(DirectCast(DirectCast(DataGridView1.DataSource,  _
                                        BindingSource).List, DataView).Table.Compute("sum(جمع)", "")))
            'If Factor_Type = Setting.FactorTypes.Kharid Then
            '    txt_JameTAkhfif.Value = String.Format("{0:N0}", Double.Parse(DirectCast(DirectCast(DataGridView1.DataSource,  _
            '                                                       BindingSource).List, DataView).Table.Compute("sum(تخفیف)", "")))
            'ElseIf Factor_Type = Setting.FactorTypes.BargashtForosh And Lbl_EshterakSrl.Text <> -1 Then
            '    txt_JameTAkhfif.Value = String.Format("{0:N0}", (Double.Parse(DirectCast(DirectCast(DataGridView1.DataSource,  _
            '                                                   BindingSource).List, DataView).Table.Compute("sum(جمع)", "")) * Setting.Darsade_Takhfife_Moshtarakin) / 100)
            'Else
            '    txt_JameTAkhfif.Value = 0
            'End If
            'txt_Baghimande.Value = txt_JamKol.Value - txt_JameTAkhfif.Value
            'txt_JamKol.Value = String.Format("{0:N0}", Double.Parse(DirectCast(DirectCast(DataGridView1.DataSource,  _
            '                                                     BindingSource).List, DataView).Table.Compute("sum(جمع)", "")))
            'txt_JameTAkhfif.Value = String.Format("{0:N0}", Int64.Parse(DirectCast(DirectCast(DataGridView1.DataSource,  _
            '                                                    BindingSource).List, DataView).Table.Compute("sum(تخفیف)", "")))
        End If
    End Sub

    Private Sub ReSortRadif()
        Application.DoEvents()
        Dim count As Integer = 1
        Try
            For i As Integer = 0 To DataGridView1.RowCount
                DataGridView1.Rows(i).Cells(0).Value = count
                count += 1
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Del.Click
        Edit_CurrentIndex = FindSrl(DataGridView1, FindSerialPromtType.Delete, False, True, True)
        If Edit_CurrentIndex = -1 Then
            Return
        End If

        DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Delete( _
        DataGridView1.CurrentRow.Index)
        ReSortRadif()
        calSum()
    End Sub

    Private Sub Btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click
        Edit_CurrentIndex = FindSrl(DataGridView1, FindSerialPromtType.Edit, False, True, True)
        If Edit_CurrentIndex = -1 Then
            Return
        End If
        Edit_CurrentIndex = DataGridView1.CurrentRow.Index
        KalaSelectManager1.Barcode = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txt_KalaNo.Value = DataGridView1.CurrentRow.Cells(3).Value.ToString.Replace(" ", "")
        txt_Gheimat.Value = DataGridView1.CurrentRow.Cells(5).Value.ToString.Replace(" ", "")
        'txt_Takhfif.Value = DataGridView1.CurrentRow.Cells(6).Value.ToString.Replace(" ", "")
        Cmb_Anbar.SelectedValue = DataGridView1.CurrentRow.Cells(18).Value.ToString.Replace(" ", "")
        'txt_TolidDate.Value = DataGridView1.CurrentRow.Cells(8).Value.ToString.Replace(" ", "")
        'txt_ExpDate.Value = DataGridView1.CurrentRow.Cells(9).Value.ToString.Replace(" ", "")

        Application.DoEvents()
        'lk_Kala.Focus()
        Btn_Edit.Enabled = False
        DataGridView1.Enabled = False
        Btn_Del.Enabled = False
    End Sub

    Private Sub txt_ExpDate_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ExpDate.Leave
        'Btn_Add_Click(Nothing, Nothing)
        Btn_Add.Focus()
    End Sub

    Public Sub ClrearAfterAdd()
        KalaSelectManager1.ResetResult()
        'Btn_PriceRegister.Enabled = False
        'Btn_history.Enabled = False
        txt_KalaNo.Value = txt_KalaNo.DefaultValue
        txt_Gheimat.Value = txt_Gheimat.DefaultValue
        txt_Jam.Value = 0
        txt_TakhfifDarsad.Value = 0
        txt_Takhfif.Value = txt_Takhfif.DefaultValue
        txt_ExpDate.Value = ""
        txt_TolidDate.Value = ""
        KalaSelectManager1.Focus()
        Edit_CurrentIndex = -1
    End Sub

    Public Sub CallSumForEachItem()
        If txt_Gheimat.Text = "" Or txt_KalaNo.Text = "" Then
            Return
        End If
        If txt_Takhfif.Text = "" Then
            txt_Jam.Value = (CType(txt_Gheimat.Value, Single) * CType(txt_KalaNo.Value, Single))
        Else
            txt_Jam.Value = (CType(txt_Gheimat.Value, Single) * CType(txt_KalaNo.Value, Single)) - CType(txt_Takhfif.Value, Single)
        End If
    End Sub

    Private Sub txt_Gheimat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Gheimat.Leave
        txt_Jam.Value = CType(txt_Gheimat.Value, Single) * CType(txt_KalaNo.Value, Single)
    End Sub

    Private Sub txt_TakhfifDarsad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TakhfifDarsad.Leave
        txt_Takhfif.Value = (CType(txt_Gheimat.Value, Single) * CType(txt_KalaNo.Value, Single) * CType(txt_TakhfifDarsad.Value, Single)) / 100
        txt_Jam.Value = (CType(txt_Gheimat.Value, Single) * CType(txt_KalaNo.Value, Single)) - CType(txt_Takhfif.Value, Single)
    End Sub

    Private Sub txt_Takhfif_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Takhfif.Leave, txt_TakhfifDarsad.TextChanged, txt_KalaNo.TextChanged, txt_Gheimat.TextChanged
        CallSumForEachItem()
    End Sub
   
    Private Sub txt_KalaNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_KalaNo.Leave
        CallSumForEachItem()
    End Sub
End Class