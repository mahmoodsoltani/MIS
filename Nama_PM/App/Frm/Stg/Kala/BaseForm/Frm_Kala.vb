Public Class Frm_Kala
    Dim srl_KalaPriceEdit As String = -1
    Dim srl_kala As Integer = -1
    Dim OrginalStateOfGheimat As Boolean = False

    'Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
    '    'If e.KeyCode = Keys.F7 Then
    '    '    Dim s As New Frm_FactorSearch
    '    '    VB_Component.Windows.InsertForm(System.Reflection.Assembly.GetExecutingAssembly, Me, s, Nothing)
    '    'ElseIf e.KeyCode = Keys.Enter Then
    '    '    If Me.ActiveControl.Name = TextBox3.Name Then
    '    '        GetLastGheimatOnEdit()
    '    '    End If
    '    'End If
    '    'MyBase.OnKeyDown(e)
    'End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Stg_AnbarTableAdapter.Fill(Me.Ds_Kala.Stg_Anbar, -1)
        Me.Pm_KalaTableAdapter.Fill(Me.Ds_Kala.Pm_Kala, -1, 2)
        Me.Stg_VahedTableAdapter.Fill(Me.Ds_Kala.Stg_Vahed)
        Me.Stg_KalaPricingMethodTableAdapter.Fill(Me.Ds_Kala.Stg_KalaPricingMethod)
        Me.Pm_SazandeTableAdapter.Fill(Me.Ds_Pm.Pm_Sazande)

        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        MyBase.DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        MyBase.DataObject.DataRow("SubmitDate") = Setting.Now
        ' MyBase.DataObject.DataRow("Srl_Company") = Setting.CompanyInfo.Srl

        If Not MyBase.Save(False) Then
            Return False
        End If

        txt_KalaGroup.Value = ""
        Txt_SrlKalaGroup.Value = -1

        If FormState <> FormStates.Edit Then
            PublicFunction.InsertKalaPrice(MyBase.DataObject.DataRow("Srl"), -1, -1, txt_DefultPrice.Value)
        ElseIf FormState = FormStates.Edit Then
            BaseDataObject.DataAccess.ExecQuery("update Stg_KalaPrice set FroshPrice=" + txt_DefultPrice.Value.ToString + " where srl=" + srl_KalaPriceEdit.ToString)
            srl_KalaPriceEdit = -1
            FormState = FormStates.NewRecord
        End If

        If txt_MojodiAvalie.Value <> 0 Then
            Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("Stg_AnbarKala")
            dr("Srl_Stg_FactorMaster") = -1
            dr("Srl_Stg_Kala") = MyBase.DataObject.DataRow("Srl")
            dr("Srl_Stg_AnbarTypeTransfer") = Setting.AnbarTypeTransfer.MojodiAvalie
            dr("Count") = txt_MojodiAvalie.Value
            dr("Floor") = 1
            dr("row") = 1
            dr("TolidDate") = DBNull.Value
            dr("ExpDate") = DBNull.Value
            dr("Srl_Stg_AnbarKala_Transfer") = DBNull.Value
            dr("TransferDate") = Setting.TarikheJary
            dr("Srl_SubmitUser") = Setting.Srl_User
            dr("SubmitDate") = Setting.Now

            If chk_AllAnbar.Checked Then
                For Each obj As Object In cmb_Anbar.Items
                    dr("Srl_Stg_Anbar") = obj(0)
                    If Not BaseDataObject.DataAccess.Insert(dr, False) Then
                        MessageBox.Show("خطا در ثبت موجودي اوليه")
                        Return False
                    End If
                Next
            Else
                dr("Srl_Stg_Anbar") = cmb_Anbar.SelectedValue
                If Not BaseDataObject.DataAccess.Insert(dr, False) Then
                    MessageBox.Show("خطا در ثبت موجودي اوليه")
                    Return False
                End If
            End If
            'Dim i As Integer = BaseDataObject.DataAccess.ExecScalar("SELECT     SUM(Count) FROM  dbo.Stg_AnbarKala WHERE     (Srl_Stg_Kala = " + MyBase.DataObject.DataRow("Srl").ToString + ") AND (Srl_Stg_Anbar = 2)")
            'MessageBoxFa.Show("موجودي جديد ثبت شد تعداد :" + i.ToString)
        End If

        ClearForm()
        Return True
    End Function

    Public Overrides Function Edit() As Boolean
        MyBase.Edit()
        GetLastGheimatOnEdit()
    End Function

    Private Sub Frm_Kala_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Stg_SazandeTableAdapter.Fill(Me.Ds_Kala.Stg_Sazande)
        txt_KalaGroup.TabStop = False
        If srl_kala <> -1 Then
            DataGridView1.Enabled = False
            MyBase.Edit(srl_kala)
        End If

        txt_MojodiAvalie.Value = 0
        OrginalStateOfGheimat = txt_DefultPrice.Enabled
    End Sub

    Public Overrides Function Delete() As Boolean
        If MessageBox.Show("با حذف این کالا تمامی اطلاعات وابسته به آن نیز حذف می شود! آیا مایل به ادامه عملیات هستید؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Return MyBase.Delete()
        End If
    End Function

    Private Sub btn_selectGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_selectGroup.Click
        Dim dt As DataTable = PublicFunction.GetKalaGroup
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            Dim Tv As New Tree_Vw_Select(PublicFunction.GetKalaGroup)
            If Tv.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                Return
            End If
            If Not Tv.Result Is Nothing Then
                txt_KalaGroup.Value = Tv.Result.Text
                Txt_SrlKalaGroup.Text = Tv.Result.Srl
            End If
            txt_DefultPrice.Focus()
        End If
    End Sub

    Private Sub Txt_SrlKalaGroup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_SrlKalaGroup.TextChanged
        If Txt_SrlKalaGroup.Value <> -1 Then
            txt_KalaGroup.Value = BaseDataObject.DataAccess.ExecScalar("select Name from Stg_KalaGroup where srl=" + Txt_SrlKalaGroup.Value.ToString())
        End If
    End Sub

    Sub GetLastGheimatOnEdit()
        Dim Dr As DataRow = BaseDataObject.DataAccess.GetRow("stg_Kala", "BarcodeCode='" + TextBox3.Value + "'")
        If Not Dr Is Nothing Then
            DataObject.DataRow = Dr
            Dim drtest As DataRow = BaseDataObject.DataAccess.GetRow("select srl,FroshPrice from stg_kalaprice where srl_stg_kala=" + Dr(0).ToString() + " and active=1")
            If Not drtest Is Nothing Then
                txt_DefultPrice.Value = drtest("FroshPrice")
                srl_KalaPriceEdit = drtest("srl")
            End If
            Me.FormState = FormStates.Edit
        End If
    End Sub

    Public Sub New(ByVal srl_kala As Integer)
        InitializeComponent()
        Me.srl_kala = srl_kala
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

End Class