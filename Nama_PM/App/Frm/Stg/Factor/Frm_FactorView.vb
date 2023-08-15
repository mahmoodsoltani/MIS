Public Class Frm_FactorView

    Public Overrides Sub LoadDataGridView()
        If Not Chb_date.Checked Then
            Stg_FactorMasterTableAdapter.Fill(Ds_Kala.Stg_FactorMaster, Setting.FactorTypes.Kharid, -1, txt_FromDate.Value, txt_ToDate.Value)
        Else
            Stg_FactorMasterTableAdapter.Fill(Ds_Kala.Stg_FactorMaster, Setting.FactorTypes.Kharid, -1, txt_FromDate.Value, "")
        End If
        'MyBase.LoadDataGridView()
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click

        Dim s As New Frm_FactorSubmit(-1)
        s.ShowDialog()
        LoadDataGridView()
    End Sub

    Private Sub rbtn_FactorKharid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadDataGridView()
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As String = FindSrl(DataGridView1, VB_Component.FindSerialPromtType.Edit, True, True, )
        If srl = -1 Then
            Return
        End If
        Dim s As New Frm_FactorSubmit(srl)
        s.ShowDialog()
        LoadDataGridView()
    End Sub

    Private Sub Btn_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_report.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim rp As New Rp_FactorKharid
        Rp_FactorTableAdapter.Fill(Ds_Kala.Rp_Factor, srl)
        Dim dt As DataTable = Ds_Kala.Rp_Factor
        rp.SetDataSource(dt)
        rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.FaReportViewer1.ReportDataview = dt
        frm_rp.ShowDialog()

    End Sub

    Private Sub rbtn_FactorFrosh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadDataGridView()
    End Sub
    Public Overrides Function Delete() As Boolean
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)

        If srl = -1 Then
            Return False
        End If
        'If MessageBoxFa.Show("آیا با حذف اطلاعات موافقید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
        '    Return False
        'End If
        BaseDataObject.DataAccess.ExecQuery("update stg_kalaprice set Srl_Stg_FactorMaster=-1,Srl_Stg_FactorDetails=-1 where Srl_Stg_FactorMaster=" + srl.ToString)
        BaseDataObject.DataAccess.Delete("Stg_AnbarKala", "Srl_Stg_FactorMaster=" + srl.ToString)
        'BaseDataObject.DataAccess.Delete("Acc_SanadDetails", "Srl_TypeTable=" + Integer.Parse(Setting.TypeTable.Factor).ToString + " and Srl_FromTable=" + srl.ToString)
        BaseDataObject.DataAccess.Delete("Stg_FactorDetails", "Srl_Stg_FactorMaster=" + srl.ToString)
        BaseDataObject.DataAccess.Delete("Stg_FactorMaster", srl)
        MessageBoxFa.Show("اطلاعات فاکتور حذف شد")
        LoadDataGridView()
    End Function


    Private Sub Frm_FactorView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        txt_ToDate.Value = Setting.TarikheJary
        Chb_date.Checked = False
    End Sub

    Private Sub Chb_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chb_date.CheckedChanged
        LoadDataGridView()
    End Sub
    Private Sub txt_ToDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ToDate.ValueChanged, txt_FromDate.ValueChanged
        LoadDataGridView()
    End Sub
End Class