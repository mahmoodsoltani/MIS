Public Class Frm_WorkForm_EibForm


    Dim dt As Ds_Pm.Pm_WorkForm_EibFormDataTable
    Dim Srl_Master As Integer

    Public Sub New(ByVal dt As Ds_Pm.Pm_WorkForm_EibFormDataTable, ByVal Srl_master As Integer)
        InitializeComponent()
        If Not dt Is Nothing Then
            DataGridView1.DataSource = dt
            Me.dt = dt
        End If
        Me.Srl_Master = Srl_master
    End Sub

    Public Function GetDataTable() As DataTable
        Try
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If txt_FormeNaghs.Value = "" Then
            MessageBoxFa.Show("لطفا شماره فرم نقص را وارد نمائید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_FormeNaghs.Focus()
            Return False
        End If

        For Each Temp_dr As DataRow In dt.Rows
            If Not Temp_dr.RowState = DataRowState.Deleted Then
                If Temp_dr(1) = txt_FormeNaghs.Value And Temp_dr(2) = txt_TarikhNaghs.Value Then
                    MessageBoxFa.Show("این فرم نقص تکراری است")
                    txt_FormeNaghs.Focus()
                    Return False
                End If
            End If
        Next

        Dim dr As DataRow = dt.NewRow
        dr(1) = txt_FormeNaghs.Value
        dr(2) = txt_TarikhNaghs.Value
        dt.Rows.Add(dr)
        DataGridView1.DataSource = dt

        txt_FormeNaghs.Focus()
        'Return True
    End Function

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If Not MessageBoxFa.Show("با حذف ردیف فرم نقص مربوطه در سیستم حذف خواهد شد", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.OK Then
            Return
        End If
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBoxFa.Show("لطفا یک ردیف را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If




        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            Try
                Dim i As Integer = DataGridView1.CurrentRow.Index
                i = i - 1
                If i < 0 Then
                    i = 0
                End If
                If Not Srl_Master = -1 Then
                    BaseDataObject.DataAccess.Delete("Pm_EibFormDetails", "Srl_Pm_EibFormMaster in (select Srl from Pm_EibFormMaster where OrginalEibFormNumber='" + dt.Rows(i)(1).ToString() + "' AND OriginalEibFormDate='" + dt.Rows(i)(2).ToString() + "')")
                    BaseDataObject.DataAccess.Delete("Pm_EibFormPeiro", "Srl_Pm_EibFormMaster in (select Srl from Pm_EibFormMaster where OrginalEibFormNumber='" + dt.Rows(i)(1).ToString() + "' AND OriginalEibFormDate='" + dt.Rows(i)(2).ToString() + "')")
                    BaseDataObject.DataAccess.Delete("Pm_EibFormMaster", "OrginalEibFormNumber='" + dt.Rows(i)(1).ToString() + "' AND OriginalEibFormDate='" + dt.Rows(i)(2).ToString() + "'")
                    BaseDataObject.DataAccess.Delete("Pm_workform_EibForm", "EibFormDate='" + dt.Rows(i)(2).ToString() + "' AND EibFormNo='" + dt.Rows(i)(1).ToString() + "'")
                End If
                dt.Rows(DataGridView1.CurrentRow.Index).Delete()
                DataGridView1.DataSource = dt
                'DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(1)
                DataGridView1.CurrentRow.Selected = True
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class