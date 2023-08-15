Public Class Frm_SmsVw

    Public Sub New()
        InitializeComponent()
    End Sub
    Dim datasourceDT As DataTable
 
    Public Overrides Sub LoadDataGridView()
        Dim Srl_Reciever As Integer = -1
        Dim Srl_sender As Integer = -1
        Dim srl_post = -1
        Dim FromDate As String = ""
        Dim ToDate As String = ""

        If Not chk_AllDate.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If

        If Not chk_AllReciever.Checked Then
            Srl_Reciever = cmb_Reciever.SelectedValue
        End If
        If Not chk_allPost.Checked Then
            srl_post = cmb_Post.SelectedValue
        End If
        If Not Chk_AllSender.Checked Then
            Srl_sender = cmb_Sender.SelectedValue
        End If
        Me.Pm_SmsTableAdapter.Fill(Ds_Rp.Pm_Sms, FromDate, ToDate, Srl_Reciever, srl_post, Srl_sender)
        MyBase.LoadDataGridView()
    End Sub


    Private Sub Frm_EibFormVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Pm_Ashkhas' table. You can move, or remove it, as needed.
        Me.Pm_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Ashkhas)
   

        chk_AllReciever.Checked = True
        Chk_AllSender.Checked = True
        chk_AllDate.Checked = True
        chk_allPost.Checked = True
        txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_ToDate.Value = Setting.TarikheJary
        Me.Pm_AshkhasTableAdapter.Fill(Ds_Ashkhas.Pm_Ashkhas)

    End Sub

 
    Public Overrides Function Delete() As Boolean
        'If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
        '    Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        '    If srl = -1 Then
        '        Return False
        '    End If
        '    If BaseDataObject.DataAccess.BeginTransaction() Then
        '        BaseDataObject.DataAccess.Delete("Pm_EibFormDetails", " Srl_Pm_EibFormMaster=" + srl.ToString())
        '        BaseDataObject.DataAccess.Delete("Pm_EibFormPeiro", " Srl_Pm_EibFormMaster=" + srl.ToString())
        '        BaseDataObject.DataAccess.Delete("Pm_EibFormMaster", srl)
        '        BaseDataObject.DataAccess.Delete("Pm_eibFormAttachment", " Srl_Pm_EibFormMaster=" + srl.ToString())

        '        If BaseDataObject.DataAccess.Commit() Then
        '            MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
        '            LoadDataGridView()
        '            Return True
        '        End If
        '    End If
        '    MessageBoxFa.Show("اشکال در حذف اطلاعات")
        '    Return False
        'End If
    End Function

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
      

    End Sub

    Private Sub txt_FromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ToDate.ValueChanged, txt_FromDate.ValueChanged
        LoadDataGridView()
    End Sub

    Private Sub chk_AllDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllSender.CheckedChanged, chk_AllReciever.CheckedChanged, chk_AllDate.CheckedChanged
        txt_FromDate.Enabled = Not chk_AllDate.Checked
        txt_ToDate.Enabled = Not chk_AllDate.Checked
        LoadDataGridView()
    End Sub

    Private Sub cmb_Post_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Sender.SelectedIndexChanged, cmb_Reciever.SelectedIndexChanged, cmb_Post.SelectedIndexChanged
        LoadDataGridView()
    End Sub

    Private Sub chk_allPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allPost.CheckedChanged
        cmb_Post.Enabled = Not chk_allPost.Checked
        LoadDataGridView()
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        If Ds_Rp.Pm_Sms.Rows.Count > 0 Then

            Dim rp As New Rp_sms
            rp.SetDataSource(Ds_Rp.Pm_Sms.DataSet)
            rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
            Dim frm_rp As New Frm_RpVw(rp, Ds_Rp.Pm_Sms)
            frm_rp.ShowDialog()
        End If
    End Sub
End Class