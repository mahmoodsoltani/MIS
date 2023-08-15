Public Class Frm_Lab_Rol_MasooleTamir
    Public Overrides Sub LoadDataGridView()
        Me.Pm_Lab_Rol_Masool_TamirTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Masool_Tamir)
    End Sub
    'Private Sub Frm_Lab_Rol_MasooleTamir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    '    'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Masool_Tamir' table. You can move, or remove it, as needed.
    '    Me.Pm_Lab_Rol_Masool_TamirTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Masool_Tamir)
    'End Sub



    'Private Sub Frm_Lab_Rol_MasooleTamir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Masool_Tamir' table. You can move, or remove it, as needed.
    '    Me.Pm_Lab_Rol_Masool_TamirTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Masool_Tamir)
    '    'TODO: This line of code loads data into the 'Ds_Lab.Pm_Lab_Rol_Masool_Tamir' table. You can move, or remove it, as needed.
    '    'Me.Pm_Lab_Rol_Masool_TamirTableAdapter.Fill(Me.Ds_Lab.Pm_Lab_Rol_Masool_Tamir)

    'End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("Name") = txt_DeviceName.Text

        Return MyBase.Save(DoClearForm)
    End Function

   
    
End Class