Public Class Frm_Sender

    
    Public Overrides Sub LoadDataGridView()
        Me.Pm_SenderTableAdapter.Fill(Me.Ds_Pm.Pm_Sender)
    End Sub

   

    Private Sub Frm_Sender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Sender' table. You can move, or remove it, as needed.
        Me.Pm_SenderTableAdapter.Fill(Me.Ds_Pm.Pm_Sender)

    End Sub
    'Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
    '    DataObject.DataRow("Name") = txt_Sender.Text
    '    Return MyBase.Save(DoClearForm)
    'End Function

 
End Class