Public Class Frm_DarkhasteKarVw

    Dim srl_pm_Post As Integer = -1
    Dim What As Integer = -1
    Dim peyvaste As String = "پیوسته"
    Dim naPeyvaste As String = "ناپیوسته"


    Private Sub Frm_DarkhasteKarVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm2.Pm_Post' table. You can move, or remove it, as needed.
        Me.Pm_PostTableAdapter1.Fill(Me.Ds_Pm2.Pm_Post)
        'TODO: This line of code loads data into the 'Ds_Pm1.Pm_Post' table. You can move, or remove it, as needed.

        Me.Pm_DarkhasteKarVwTableAdapter2.Fill(Me.Ds_Pm2.Pm_DarkhasteKarVw, "", "", "", "", -1, -1)
        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Rows(i).Cells(15).Value = 1 Then
        '        'DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(15)
        '        'DataGridView1.CurrentCell.Style.BackColor = Color.Black
        '        'DataGridView1.Rows(i).Cells(15).Style.BackColor = Color.Black
        '        DataGridView1.Rows(i).Cells(15).Value = peyvaste
        '        'ElseIf DataGridView1.Rows(i).Cells(15).Value = 2 Then
        '        '    DataGridView1.Rows(i).Cells(15).Value = "ناپیوسته"
        '    End If
        'Next


        colors()

        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Rows(i).Cells(1).Value = 1 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b5f5ad")
        '    ElseIf DataGridView1.Rows(i).Cells(1).Value = 2 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f4a3a1")
        '        System.Drawing.ColorTranslator.FromHtml("#b5f5ad")
        '    ElseIf DataGridView1.Rows(i).Cells(1).Value = 3 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFA500")

        '    End If
        'Next
        lbl_Record.Text = "تعداد رکورد : "
        lbl_Record.Text += DataGridView1.Rows.Count().ToString()

    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Public Overrides Sub LoadDataGridView()
        ' Me.Pm_Hadese_KhesaratDeviceTableAdapter.Fill(Me.Ds_Pm.Pm_Hadese_KhesaratDevice, srl_pm_Post)
        Dim StartSabt_Date As String = IIf(chk_AllDate.Checked, txt_StartPmDate.Value, "")
        Dim EndSabt_Date As String = IIf(chk_AllDate.Checked, txt_EndPmdate.Value, "")
        Dim Start_Date As String = IIf(chk_AllExecDate.Checked, txt_StartExeDate.Value, "")
        Dim End_Date As String = IIf(chk_AllExecDate.Checked, txt_EndExecDate.Value, "")
        Dim Srl_Post As Integer = IIf(Chk_AllPost.Checked, cmb_Post.SelectedValue, -1)

        If Rb_All.Checked Then
            What = -1
        ElseIf rb_Execute.Checked Then
            What = 1
        ElseIf Rb_NoExecute.Checked Then
            What = 2
        ElseIf Rb_Cancle.checked Then
            What = 3
        ElseIf rb_NoStatus.Checked Then
            What = 0

        End If
        Me.Pm_DarkhasteKarVwTableAdapter2.Fill(Me.Ds_Pm2.Pm_DarkhasteKarVw, StartSabt_Date, EndSabt_Date, Start_Date, End_Date, Srl_Post, What)
        MyBase.LoadDataGridView()
        lbl_Record.Text = "تعداد رکورد :"
        lbl_Record.Text += DataGridView1.Rows.Count().ToString()
        colors()
        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Rows(i).Cells(1).Value = 1 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b5f5ad")
        '    ElseIf DataGridView1.Rows(i).Cells(1).Value = 2 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f4a3a1")
        '        System.Drawing.ColorTranslator.FromHtml("#b5f5ad")
        '    ElseIf DataGridView1.Rows(i).Cells(1).Value = 3 Then
        '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFA500")

        '    End If
        'Next
    End Sub

    
    Private Sub chk_AllDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllDate.CheckedChanged
        txt_StartPmDate.Enabled = chk_AllDate.Checked
        txt_EndPmdate.Enabled = chk_AllDate.Checked
        LoadDataGridView()
    End Sub

    Private Sub chk_AllExecDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllExecDate.CheckedChanged
        txt_StartExeDate.Enabled = chk_AllExecDate.Checked
        txt_EndExecDate.Enabled = chk_AllExecDate.Checked
        LoadDataGridView()
    End Sub

    Private Sub Chk_AllPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllPost.CheckedChanged
        cmb_Post.Enabled = Chk_AllPost.Checked
        LoadDataGridView()
    End Sub

    Private Sub txt_StartPmDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_StartPmDate.ValueChanged
        LoadDataGridView()
    End Sub

    Private Sub txt_EndPmdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_EndPmdate.ValueChanged
        LoadDataGridView()
    End Sub

    Private Sub txt_StartExeDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_StartExeDate.ValueChanged
        LoadDataGridView()
    End Sub

    Private Sub txt_EndExecDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_EndExecDate.TextChanged
        LoadDataGridView()
    End Sub

    Private Sub cmb_Post_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Post.SelectedIndexChanged
        If cmb_Post.SelectedValue Is Nothing Then
            Return
        End If
        LoadDataGridView()
    End Sub

    Private Sub Rb_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_All.CheckedChanged
        LoadDataGridView()
    End Sub

    Private Sub rb_Execute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Execute.CheckedChanged
        LoadDataGridView()
    End Sub
    Private Sub Rb_NoExecute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_NoExecute.CheckedChanged
        LoadDataGridView()
    End Sub
    Private Sub Rb_Cancle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_Cancle.CheckedChanged
        LoadDataGridView()
    End Sub

    Private Sub rb_NoStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_NoStatus.CheckedChanged
        LoadDataGridView()
    End Sub


   

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_DarkhasteKar(-2)
        s.ShowDialog()
        Me.Pm_PostTableAdapter1.Fill(Me.Ds_Pm2.Pm_Post)
        LoadDataGridView()
        'Me.Pm_DarkhasteKarVwTableAdapter2.Fill(Me.Ds_Pm2.Pm_DarkhasteKarVw, "", "", "", "", -1, -1)
        colors()
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim SrlDarkhast As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If SrlDarkhast = -1 Then
            Return
        End If
        
        Dim s As New Frm_DarkhasteKar(SrlDarkhast)
        s.ShowDialog()
        'Me.Pm_DarkhasteKarVwTableAdapter2.Fill(Me.Ds_Pm2.Pm_DarkhasteKarVw, "", "", "", "", -1, -1)
        LoadDataGridView()
        colors()
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If MessageBoxFa.Show("آیا از حذف اطلاعات مطمئنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srlDarkhast As Integer = FindSrl(DataGridView1, FindSerialPromtType.Delete, False)
            If srlDarkhast = -1 Then
                Return
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then

                BaseDataObject.DataAccess.Delete("Pm_DarkhasteKar", srlDarkhast)
                If BaseDataObject.DataAccess.Commit() Then
                    MessageBoxFa.Show("اطلاعات با موفقیت حذف شد")
                    Me.Pm_DarkhasteKarVwTableAdapter2.Fill(Me.Ds_Pm2.Pm_DarkhasteKarVw, "", "", "", "", -1, -1)
                    Return
                    colors()
                End If
            End If
            MessageBoxFa.Show("اشکال در حذف اطلاعات")
            Return
        End If
    End Sub

    Private Sub colors()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(1).Value = 1 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b5f5ad")
            ElseIf DataGridView1.Rows(i).Cells(1).Value = 2 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f4a3a1")
                System.Drawing.ColorTranslator.FromHtml("#b5f5ad")
            ElseIf DataGridView1.Rows(i).Cells(1).Value = 3 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFA500")

            End If
        Next
    End Sub

    
   
    Private Sub txt_EndExecDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_EndExecDate.ValueChanged
        LoadDataGridView()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim st As String = ""
        Dim ds = New DataSet()
        Dim dt As New DataTable()
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim filter As String = ""

            LoadDataGridView()

            dt = Me.Ds_Pm2.Pm_DarkhasteKarVw

        End If
        PublicFunction.ExportToExcel(SaveFileDialog1.FileName, dt, "test", st)
    End Sub

    Private Sub StatusTaeedCancel()
        Dim statusTC As String = ""
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(1).Value = 1 Then
                statusTC = "تایید"
            ElseIf DataGridView1.Rows(i).Cells(1).Value = 2 Then
                statusTC = "کنسل"
            ElseIf DataGridView1.Rows(i).Cells(1).Value = 3 Then
                statusTC = "ابطال"
            Else : statusTC = "نامشخص"
            End If
        Next
    End Sub
    Private Sub rp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rp.Click
        'Dim StartSabt_Date As String = IIf(chk_AllDate.Checked, txt_StartPmDate.Value, "")
        'Dim EndSabt_Date As String = IIf(chk_AllDate.Checked, txt_EndPmdate.Value, "")
        'Dim Start_Date As String = IIf(chk_AllExecDate.Checked, txt_StartExeDate.Value, "")
        'Dim End_Date As String = IIf(chk_AllExecDate.Checked, txt_EndExecDate.Value, "")
        'Dim Srl_Post As Integer = IIf(Chk_AllPost.Checked, cmb_Post.SelectedValue, -1)

        'If Rb_All.Checked Then
        '    What = -1
        'ElseIf rb_Execute.Checked Then
        '    What = 1
        'ElseIf Rb_NoExecute.Checked Then
        '    What = 2
        'ElseIf Rb_Cancle.Checked Then
        '    What = 3
        'ElseIf rb_NoStatus.Checked Then
        '    What = 0

        'End If
        'Me.Pm_DarkhasteKarVwTableAdapter2.Fill(Me.Ds_Pm2.Pm_DarkhasteKarVw, StartSabt_Date, EndSabt_Date, Start_Date, End_Date, Srl_Post, What)
        'Dim statusTC As String = ""
        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Rows(i).Cells(1).Value = 1 Then
        '        statusTC = "تایید"
        '    ElseIf DataGridView1.Rows(i).Cells(1).Value = 2 Then
        '        statusTC = "کنسل"
        '    ElseIf DataGridView1.Rows(i).Cells(1).Value = 3 Then
        '        statusTC = "ابطال"
        '    Else : statusTC = "نامشخص"
        '    End If
        'Next

        Dim rpd As New DarkhasteKarVw

        Dim dt As New DataTable()

        rpd.SetDataSource(Ds_Pm2.Pm_DarkhasteKarVw.DataSet)
        rpd.SetParameterValue(rpd.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary.ToString())
        'rpd.SetParameterValue(rpd.Parameter_status.ParameterFieldName, statusTC)
        Dim frm_rpd As New Frm_RpVw(rpd, Me.Ds_Pm2.Pm_DarkhasteKarVw.DataSet.Tables("0"))
        frm_rpd.ShowDialog()
    End Sub
End Class