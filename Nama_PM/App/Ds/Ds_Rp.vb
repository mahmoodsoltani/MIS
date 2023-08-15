

Partial Public Class Ds_Rp
    Partial Class Rp_PishnahadDataTable

        Private Sub Rp_PishnahadDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.پیشنهادColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class Pm_SmsDataTable

        Private Sub Pm_SmsDataTable_Pm_SmsRowChanging(ByVal sender As System.Object, ByVal e As Pm_SmsRowChangeEvent) Handles Me.Pm_SmsRowChanging

        End Sub

    End Class

    Partial Class Rp_SummaryStatusstatementExtraWorkDataTable

    End Class

End Class
