Public Class Frm_Post_Pishnahad

    Dim Srl_Post As Integer
    Dim Srl_Device As Integer
    Public Sub New(ByVal Srl_Post As Integer)
        InitializeComponent()
        Me.Srl_Post = Srl_Post

    End Sub
    Public Sub New(ByVal Srl_Post As Integer, ByVal Srl_Device As Integer)
        InitializeComponent()
        Me.Srl_Post = Srl_Post
        Me.Srl_Device = Srl_Device
    End Sub
    'Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
    '    'MyBase.DataObject.DataRow("Srl_Post") = Srl_Post

    '    MyBase.Save(False)
    '    txt_Desc.Value = ""
    '    txt_tarikh.Value = Setting.TarikheJary
    '    'cmb_Tajhiz.SelectedValue = Srl_Device

    'End Function

    Public Overrides Sub LoadDataGridView()
        If Srl_Device <= 0 Then
            Srl_Device = -1
        End If
        Dim Fromdate As String = IIf(chk_AllDate.Checked, "", txt_FromDate.Value)
        Dim todate As String = IIf(chk_AllDate.Checked, "", txt_ToDate.Value)
        If rb_All.Checked Then
            Pm_Post_PishnahdTableAdapter.Fill(Ds_Pm.Pm_Post_Pishnahd, -1, -1, Fromdate, todate, -1, -1, -1, "", -1)
        ElseIf rb_Post.Checked Then
            Pm_Post_PishnahdTableAdapter.Fill(Ds_Pm.Pm_Post_Pishnahd, Srl_Post, -1, Fromdate, todate, -1, -1, -1, "", -1)
        ElseIf rb_Tajhiz.Checked Then
            If Srl_Device = -1 Then
                MessageBox.Show("لطفا تجهیز را انتخاب نمائید")
                rb_All.Checked = True
                btn_SelectTajhiz.Focus()
                Return
            End If
            Pm_Post_PishnahdTableAdapter.Fill(Ds_Pm.Pm_Post_Pishnahd, -1, Srl_Device, Fromdate, todate, -1, -1, -1, "", -1)
        End If
        MyBase.LoadDataGridView()
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If Srl_Device = -1 Then
            MessageBox.Show("لطفا تجهیز را انتخاب نمائید")
            btn_SelectTajhiz.Focus()
            Return False
        End If
        DataObject.DataRow("Srl_Device") = Srl_Device
        Return MyBase.Save(DoClearForm)
    End Function
    Public Overrides Function Edit() As Boolean
        Try
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("select Pm_Hadese_KhesaratDevice.srl,srl_Pm_Post from Pm_Hadese_KhesaratDevice JOIN Pm_Post_Pishnahd on Pm_Hadese_KhesaratDevice.srl = Srl_Device  where Pm_Post_Pishnahd. srl=" + DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
            'cmb_Post.SelectedValue = dr("Srl_Pm_Post")
            MyBase.Edit()
            txt_TajhizNameForSave.Text = DataGridView1.SelectedRows(0).Cells(6).Value
            Srl_Device = dr("srl")
            Return True
        Catch
            Return False
        End Try
        Return MyBase.Edit()
    End Function
    Private Sub Frm_Post_Pishnahad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rb_All.Checked = True
        txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_ToDate.Value = Setting.TarikheJary
        chk_AllDate.Checked = True
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Ashkhas)
        Me.Pm_RecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_RecomendationSubject)
        Me.Pm_SubRecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_SubRecomendationSubject, cmb_RecomSubject.SelectedValue)
        Srl_Post = cmb_Post.SelectedValue
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Hadese.Pm_Hadese_KhesaratDevice, Srl_Post)
        If Not Srl_Device = -1 Then
            txt_TajhizNameForSave.Value = GetDeviceName(Srl_Device)
        End If
        LoadDataGridView()
    End Sub

    Public Function GetDeviceName(ByVal srl_Device As Integer) As String
        Return BaseDataObject.DataAccess.ExecScalar("Select CAse when Pm_DescriptableTajhiz is null then " & _
                                                                            " Pm_hadese_KhesaratDevice.Name " & _
                                                                             " Else" & _
                                                                             " pm_descriptabletajhiz.name() " & _
                                                                             " end as نام" & _
                                                                             " from Pm_hadese_KhesaratDevice LEFT JOIN pm_descriptableTajhiz on " & _
                                                                             " pm_descriptableTajhiz.srl = pm_descriptabletajhiz " & _
                                                                             " where(Pm_hadese_KhesaratDevice.Srl = " + srl_Device.ToString()).ToString()

    End Function

    Private Sub rb_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_All.CheckedChanged
        If rb_All.Checked Then
            LoadDataGridView()

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Post.CheckedChanged
        If rb_Post.Checked Then
            LoadDataGridView()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Tajhiz.CheckedChanged
        If rb_Tajhiz.Checked Then
            LoadDataGridView()

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Post.SelectedIndexChanged
        Srl_Post = cmb_Post.SelectedValue
        txt_TajhizNameForSave.Value = ""
        Srl_Device = -1
        If rb_Post.Checked Then
            LoadDataGridView()
        End If
    End Sub



    Private Sub cmb_RecomSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_RecomSubject.SelectedIndexChanged
        Me.Pm_SubRecomendationSubjectTableAdapter.Fill(Me.Ds_Pm.Pm_SubRecomendationSubject, cmb_RecomSubject.SelectedValue)
    End Sub

    Private Sub chk_AllDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllDate.CheckedChanged
        txt_FromDate.Enabled = Not chk_AllDate.Checked
        txt_ToDate.Enabled = Not chk_AllDate.Checked
        LoadDataGridView()
    End Sub



    Private Sub txt_ToDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ToDate.TextChanged

    End Sub

    Private Sub txt_FromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ToDate.ValueChanged, txt_FromDate.ValueChanged
        LoadDataGridView()
    End Sub

    Private Sub btn_SelectTajhiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SelectTajhiz.Click
        If cmb_Post.SelectedValue Is Nothing Then
            MessageBoxFa.Show("لطفا پست را مشخص نمائید")
            cmb_Post.Focus()
            Return
        End If
        Dim s As New Frm_DeviceSelect(cmb_Post.SelectedValue)
        s.ShowDialog()
        If Not s.SelectedDevice Is Nothing Then
            txt_TajhizNameForSave.Value = s.SelectedDevice.Text
            Srl_Device = s.SelectedDevice.Srl
        End If
    End Sub

    Private Sub txt_TajhizNameForSave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TajhizNameForSave.TextChanged

    End Sub
End Class