Public Class Frm_Sazande

    Public Overrides Sub LoadDataGridView()
        Me.Stg_SazandeTableAdapter.Fill(Me.Ds_Kala.Stg_Sazande)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("barcode") = BaseDataObject.DataAccess.FindMax("Stg_Sazande", "barcode")
        Return MyBase.Save(DoClearForm)
    End Function

End Class