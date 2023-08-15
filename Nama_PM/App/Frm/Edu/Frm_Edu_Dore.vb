Public Class Frm_Edu_Dore

    Private Sub Frm_Amo_DoreName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Dore' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DoreTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Dore)
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Dore' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DoreTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Dore)
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_DoreType' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DoreTypeTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreType)
    End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_DoreTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Dore)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim frm As New Frm_Edu_DoreJob(DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer))
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btn_extractImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_extractImage.Click
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim path As String = FolderBrowserDialog1.SelectedPath
            If path <> "" Then
                If (Not System.IO.Directory.Exists(path + "\ImageBackUp")) Then
                    System.IO.Directory.CreateDirectory(path + "\ImageBackUp")
                End If
                For i As Integer = 0 To 450
                    Dim _from As Integer = i * 10
                    Dim _to As Integer = (i + 1) * 10
                    'Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable("pm_amo_dore", " srl between " + (i * 100).ToString() + " and +"((i + 1) * 100).ToString())
                    Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable("pm_amo_dore", " srl between " + _from.ToString() + " and " + _to.ToString())
                    For Each dr As DataRow In dt.Rows
                        If Not dr("srl") Is DBNull.Value And Not dr("image") Is DBNull.Value Then
                            Dim imageData As Byte() = dr("image")
                            Dim newImage As Image = Nothing
                            If Not imageData Is Nothing Then
                                Using ms As New System.IO.MemoryStream(imageData, 0, imageData.Length)
                                    ms.Write(imageData, 0, imageData.Length)
                                    newImage = Image.FromStream(ms, True)
                                    ms.Close()
                                End Using
                            End If
                            If Not newImage Is Nothing Then
                                Dim SaveImage As New Bitmap(newImage)
                                If SaveImage.Width <> 128 And SaveImage.Height <> 128 Then
                                    SaveImage.Save(path + "\ImageBackUp\_" + dr("srl").ToString() + ".jpg")
                                End If

                            End If

                        End If
                    Next
                Next
            End If
        End If
    End Sub
End Class