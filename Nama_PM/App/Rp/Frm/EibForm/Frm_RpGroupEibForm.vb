Public Class Frm_RpGeoupEibForm

    Private Sub Frm_RpExtraWork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Pm_EibTypeTableAdapter.Fill(Me.Ds_Pm.Pm_EibType)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_GroupTableAdapter.Fill(Me.Ds_Pm.Pm_Group, -1)
        chk_AllFilter.Checked = True
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary
        Me.rb_Group.Checked = True
        Me.rb_Fixed.Checked = True
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim filter As String = ""
        Dim ShowP As Integer = IIf(chk_Peiro.Checked, -1, 0)

        If Not chk_AllFilter.Checked Then
            For Each dr As DataGridViewRow In DGV_Filter.Rows
                Try
                    filter = filter + dr.Cells(0).Value.ToString() + ","
                Catch
                End Try
            Next
            filter = filter + "-1"
        Else
            filter = "-1"
        End If
        If rb_Group.Checked Then
            'Dim rp As New Rp_FormNaghsDiagram
            'Me.Frm_RpEibGraphTableAdapter.Fill(Me.Ds_Rp.Frm_RpEibGraph, txt_FromDate.Value, txt_ToDate.Value)
            'If rb_NoFixed.Checked Then
            '    Ds_Rp.Frm_RpEibGraph.DefaultView.Sort = "[رفع نشده] desc"
            'ElseIf rb_Fixed.Checked Then
            '    Ds_Rp.Frm_RpEibGraph.DefaultView.Sort = "[رفع شده] desc"
            'End If
            'rp.SetDataSource(Me.Ds_Rp.Frm_RpEibGraph.DefaultView)
            'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
            'rp.SetParameterValue(rp.Parameter_FromDate.ParameterFieldName, txt_FromDate.Value)
            'rp.SetParameterValue(rp.Parameter_ToDate.ParameterFieldName, txt_ToDate.Value)
            'rp.SetParameterValue(rp.Parameter_BaseOn.ParameterFieldName, "گروه ها")
            Dim frm_rp As Frm_RpEibGraph
            If rb_NoFixed.Checked Then
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "Nofix", 1, filter, ShowP)
            ElseIf rb_Fixed.Checked Then
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "fix", 1, filter, ShowP)
            Else
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "", 1, filter, ShowP)
            End If
            frm_rp.ShowDialog()

        ElseIf rb_Vahed.Checked Then
            'Dim rp As New Rp_FormNaghsVahedDiagram
            'Me.Rp_VahedEibFormTableAdapter.Fill(Me.Ds_Rp.Rp_VahedEibForm, txt_FromDate.Value, txt_ToDate.Value)
            'If rb_NoFixed.Checked Then
            '    Ds_Rp.Rp_VahedEibForm.DefaultView.Sort = "[رفع نشده] desc"
            'ElseIf rb_Fixed.Checked Then
            '    Ds_Rp.Rp_VahedEibForm.DefaultView.Sort = "[رفع شده] desc"
            'End If
            'rp.SetDataSource(Me.Ds_Rp.Rp_VahedEibForm.DefaultView)
            'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
            'rp.SetParameterValue(rp.Parameter_FromDate.ParameterFieldName, txt_FromDate.Value)
            'rp.SetParameterValue(rp.Parameter_ToDate.ParameterFieldName, txt_ToDate.Value)
            'rp.SetParameterValue(rp.Parameter_BaseOn.ParameterFieldName, "واحد ها")
            'Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Rp.Rp_VahedEibForm.DataSet.Tables("0"))
            'frm_rp.ShowDialog()
            Dim frm_rp As Frm_RpEibGraph
            If rb_NoFixed.Checked Then
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "Nofix", 2, filter, ShowP)
            ElseIf rb_Fixed.Checked Then
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "fix", 2, filter, ShowP)
            Else
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "", 2, filter, ShowP)
            End If
            frm_rp.ShowDialog()
        ElseIf rb_eib.Checked Then
            'Dim rp As New Rp_FormNaghseibDiagram
            'Me.Rp_EibTypeEibFormTableAdapter.Fill(Me.Ds_Rp.Rp_EibTypeEibForm, txt_FromDate.Value, txt_ToDate.Value)
            'If rb_NoFixed.Checked Then
            '    Ds_Rp.Rp_EibTypeEibForm.DefaultView.Sort = "[رفع نشده] desc"
            'ElseIf rb_Fixed.Checked Then
            '    Ds_Rp.Rp_EibTypeEibForm.DefaultView.Sort = "[رفع شده] desc"
            'End If
            'rp.SetDataSource(Me.Ds_Rp.Rp_EibTypeEibForm.DefaultView)
            'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
            'rp.SetParameterValue(rp.Parameter_FromDate.ParameterFieldName, txt_FromDate.Value)
            'rp.SetParameterValue(rp.Parameter_ToDate.ParameterFieldName, txt_ToDate.Value)
            'rp.SetParameterValue(rp.Parameter_BaseOn.ParameterFieldName, "عیب ها")
            'Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Rp.Rp_EibTypeEibForm.DataSet.Tables("0"))
            'frm_rp.ShowDialog()
            Dim frm_rp As Frm_RpEibGraph
            If rb_NoFixed.Checked Then
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "Nofix", 3, filter, ShowP)
            ElseIf rb_Fixed.Checked Then
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "fix", 3, filter, ShowP)
            Else
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "", 3, filter, ShowP)
            End If
            frm_rp.ShowDialog()
        ElseIf rb_Post.Checked Then
            'Dim rp As New Rp_FormNaghsPostDiagram
            'Me.Rp_PostEibformTableAdapter.Fill(Me.Ds_Rp.Rp_PostEibform, txt_FromDate.Value, txt_ToDate.Value)
            'If rb_NoFixed.Checked Then
            '    Ds_Rp.Rp_PostEibform.DefaultView.Sort = "[رفع نشده] desc"
            'ElseIf rb_Fixed.Checked Then
            '    Ds_Rp.Rp_PostEibform.DefaultView.Sort = "[رفع شده] desc"
            'End If
            'rp.SetDataSource(Me.Ds_Rp.Rp_PostEibform.DefaultView)
            'rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
            'rp.SetParameterValue(rp.Parameter_FromDate.ParameterFieldName, txt_FromDate.Value)
            'rp.SetParameterValue(rp.Parameter_ToDate.ParameterFieldName, txt_ToDate.Value)
            'rp.SetParameterValue(rp.Parameter_BaseOn.ParameterFieldName, "پست ها")
            'Dim frm_rp As New Frm_RpVw(rp, Me.Ds_Rp.Rp_PostEibform.DataSet.Tables("0"))
            'frm_rp.ShowDialog()
            Dim frm_rp As Frm_RpEibGraph
            If rb_NoFixed.Checked Then
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "Nofix", 4, filter, ShowP)
            ElseIf rb_Fixed.Checked Then
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "fix", 4, filter, ShowP)
            Else
                frm_rp = New Frm_RpEibGraph(txt_FromDate.Value, txt_ToDate.Value, "", 4, filter, ShowP)
            End If
            frm_rp.ShowDialog()
        End If
    End Sub


    Private Sub rb_Group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Vahed.CheckedChanged, rb_Post.CheckedChanged, rb_Group.CheckedChanged, rb_eib.CheckedChanged
        If rb_Group.Checked Then
            txt_Filter.Text = "گروه"
            cmb_Filter.DataSource = Ds_Pm.Pm_Group
            Me.NameCol.HeaderText = "نام گروه"
            Me.cmb_Filter.DisplayMember = "نام"
            DGV_Filter.Rows.Clear()
        ElseIf rb_Post.Checked Then
            txt_Filter.Text = "پست"
            cmb_Filter.DataSource = Ds_Pm.Pm_Post
            Me.NameCol.HeaderText = "نام پست"
            Me.cmb_Filter.DisplayMember = "نام پست"
            DGV_Filter.Rows.Clear()

        ElseIf rb_Vahed.Checked Then
            txt_Filter.Text = "واحد"
            cmb_Filter.DataSource = Ds_Pm.Pm_Vahed
            Me.NameCol.HeaderText = "نام واحد"
            Me.cmb_Filter.DisplayMember = "نام واحد"
            DGV_Filter.Rows.Clear()

        Else
            txt_Filter.Text = "نوع عیب"
            cmb_Filter.DataSource = Ds_Pm.Pm_EibType
            Me.NameCol.HeaderText = "نوع عیب"
            Me.cmb_Filter.DisplayMember = "نام"

            DGV_Filter.Rows.Clear()

        End If
    End Sub


    Private Sub Post_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Add.Click
        For Each dr As DataGridViewRow In DGV_Filter.Rows
            If dr.Cells(0).Value = cmb_Filter.SelectedValue Then
                Return
            End If
        Next
        Dim i As Integer = DGV_Filter.Rows.Add()
        DGV_Filter.Rows(i).Cells(0).Value = cmb_Filter.SelectedValue
        DGV_Filter.Rows(i).Cells(1).Value = cmb_Filter.Text
    End Sub

    Private Sub Post_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Post_Del.Click
        If Not DGV_Filter.CurrentRow Is Nothing And DGV_Filter.Rows.Count >= 1 Then
            DGV_Filter.Rows.RemoveAt(DGV_Filter.CurrentRow.Index)
        End If
    End Sub

    Private Sub chk_AllFilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllFilter.CheckedChanged, chk_Peiro.CheckedChanged
        cmb_Filter.Enabled = Not chk_AllFilter.Checked
        DGV_Filter.Enabled = Not chk_AllFilter.Checked
        Post_Del.Enabled = Not chk_AllFilter.Checked
        Post_Add.Enabled = Not chk_AllFilter.Checked
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim st As String = ""
        Dim ds = New DataSet()
        Dim dt As New DataTable()
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim filter As String = ""
            Dim ShowP As Integer = IIf(chk_Peiro.Checked, -1, 0)

            If Not chk_AllFilter.Checked Then
                For Each dr As DataGridViewRow In DGV_Filter.Rows
                    Try
                        filter = filter + dr.Cells(0).Value.ToString() + ","
                    Catch
                    End Try
                Next
                filter = filter + "-1"
            Else
                filter = "-1"
            End If

            If rb_Group.Checked Then
                Rp_GroupEibFormTableAdapter.Fill(Me.Ds_Rp.Rp_GroupEibForm, txt_FromDate.Value, ShowP, txt_ToDate.Value, filter)
                dt = Me.Ds_Rp.Rp_GroupEibForm
            ElseIf rb_Post.Checked Then
                Rp_PostEibformTableAdapter.Fill(Me.Ds_Rp.Rp_PostEibform, txt_FromDate.Value, ShowP, txt_ToDate.Value, filter)
                dt = Me.Ds_Rp.Rp_PostEibform
            ElseIf rb_Vahed.Checked Then
                Rp_VahedEibFormTableAdapter.Fill(Me.Ds_Rp.Rp_VahedEibForm, txt_FromDate.Value, ShowP, txt_ToDate.Value, filter)
                dt = Me.Ds_Rp.Rp_VahedEibForm
            Else
                Rp_EibTypeEibFormTableAdapter.Fill(Me.Ds_Rp.Rp_EibTypeEibForm, txt_FromDate.Value, ShowP, txt_ToDate.Value, filter)
                dt = Me.Ds_Rp.Rp_EibTypeEibForm
            End If
        End If
        PublicFunction.ExportToExcel(SaveFileDialog1.FileName, dt, "test", st)
    End Sub
End Class