Public Class Frm_PmProgram

    Dim Srl_Pm_Tajhiz As Integer = -1
    Dim srl_pm_Post As Integer = -1
    Dim EnableCMB As Boolean = False

    Public Sub New(ByVal srl_Tajhiz As Integer, ByVal Srl_Post As Integer, ByVal Enablecmb As Boolean)
        InitializeComponent()
        Srl_Pm_Tajhiz = srl_Tajhiz
        srl_pm_Post = Srl_Post
        Me.EnableCMB = Enablecmb
    End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Pm.Pm_Hadese_KhesaratDevice, srl_pm_Post)
        Me.Pm_PmProgramTableAdapter.Fill(Me.Ds_Pm.Pm_PmProgram, Srl_Pm_Tajhiz, -1, "", "", "", "", 0)
        cmb_Tajhiz.SelectedValue = Srl_Pm_Tajhiz
        cmb_Post.SelectedValue = srl_pm_Post
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If Me.FormState = FormStates.Edit Then
            Dim srl_edit As Integer = CInt(BaseDataObject.DataAccess.ExecScalar(""))
        End If
        DataObject.DataRow("Srl_Pm_Hadese_KhesaratDevice") = Srl_Pm_Tajhiz
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_Group_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_CancelCauseTableAdapter.Fill(Me.Ds_Pm.Pm_CancelCause)

        Dim row As DataRow = Ds_Pm.Pm_CancelCause.NewRow()
        row("نام") = "انتخاب دلیل کنسلی"
        Ds_Pm.Pm_CancelCause.Rows.InsertAt(row, 0)
        LoadDataGridView()

        cmb_Post.Enabled = EnableCMB
        cmb_Tajhiz.Enabled = EnableCMB
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Post.SelectedIndexChanged
        If cmb_Post.SelectedValue Is Nothing Then
            Return
        End If
        If EnableCMB Then
            srl_pm_Post = cmb_Post.SelectedValue
            Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Pm.Pm_Hadese_KhesaratDevice, srl_pm_Post)
            Srl_Pm_Tajhiz = cmb_Tajhiz.SelectedValue
            Me.Pm_PmProgramTableAdapter.Fill(Me.Ds_Pm.Pm_PmProgram, Srl_Pm_Tajhiz, -1, "", "", "", "", 0)
        End If

    End Sub

    Private Sub cmb_Tajhiz_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Tajhiz.SelectedIndexChanged
        If Not cmb_Tajhiz.SelectedValue Is Nothing Then
            Return
        End If
        If EnableCMB Then
            Srl_Pm_Tajhiz = cmb_Tajhiz.SelectedValue
            Me.Pm_PmProgramTableAdapter.Fill(Me.Ds_Pm.Pm_PmProgram, Srl_Pm_Tajhiz, -1, "", "", "", "", 0)
        End If

    End Sub
End Class