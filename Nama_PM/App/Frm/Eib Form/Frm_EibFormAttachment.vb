Imports System.IO
Public Class Frm_EibFormAttachment
    Dim srl_EibForm As Integer

    Sub New(ByVal srl_EibForm As Integer)
        InitializeComponent()
        Me.srl_EibForm = srl_EibForm
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        Try
            If txt_Name.Value = "" Then
                MessageBoxFa.Show("لطفا برای فایل نام را وارد نمائید")
                txt_Name.Focus()
                Return False
            End If
            If Not File.Exists(txt_File.Value) Then
                MessageBoxFa.Show("لطفا مسیر فایل را معتبر وارد نمائید")
                btn_Brows.Focus()
                Return False
            End If
            Dim fi As FileInfo = New FileInfo(txt_File.Value)
            DataObject.DataRow("Extension") = fi.Extension
            DataObject.DataRow("File_Content") = ReadFile(txt_File.Value)
            DataObject.DataRow("Srl_Pm_EibFormMaster") = srl_EibForm
            DataObject.DataRow("SubmitDate") = Setting.Now
            DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
            MyBase.Save()
            LoadDataGridView()
        Catch
            MessageBox.Show("خطا در ذخیره سازی فایل")
        End Try
    End Function
    Function ReadFile(ByVal sPath As String) As Byte()
        Dim data As Byte()
        Dim fi As FileInfo = New FileInfo(sPath)
        Dim numBytes As Integer = fi.Length
        Dim fs As FileStream = New FileStream(sPath, FileMode.Open, FileAccess.Read)
        Dim br As BinaryReader = New BinaryReader(fs)
        data = br.ReadBytes(numBytes)
        Return data
    End Function
    Public Overrides Sub LoadDataGridView()
        Me.Pm_EibFormAttachmentTableAdapter.Fill(Me.Ds_Pm.Pm_EibFormAttachment, srl_EibForm)
        MyBase.LoadDataGridView()
    End Sub
    Private Sub Frm_PostTip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub


    Public Overrides Function Edit() As Boolean

    End Function


    Private Sub btn_Brows_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Brows.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Not OpenFileDialog1.FileName = "" And File.Exists(OpenFileDialog1.FileName) Then
                Dim di As FileInfo = New FileInfo(OpenFileDialog1.FileName)
                If di.Length > 2048000 Then
                    MessageBoxFa.Show("حداکثر سایز باید 2 مگابایت باشد")
                Else
                    txt_File.Value = OpenFileDialog1.FileName
                End If
            End If
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        If Not DataGridView1.SelectedRows Is Nothing Then
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                If Not File.Exists(Directory.GetCurrentDirectory + "\\temp" + DataGridView1.SelectedRows(0).Cells(4).Value.ToString()) Then
                    File.Create(Directory.GetCurrentDirectory + "\\temp" + DataGridView1.SelectedRows(0).Cells(4).Value.ToString())
                End If
                Dim temp As String = SaveFileDialog1.FileName
                If temp.LastIndexOf(".") >= 0 Then
                    temp = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.LastIndexOf("."), SaveFileDialog1.FileName.Length - SaveFileDialog1.FileName.LastIndexOf("."))
                End If
                File.WriteAllBytes(temp + DataGridView1.SelectedRows(0).Cells(4).Value.ToString(), CType(DataGridView1.SelectedRows(0).Cells(3).Value, Byte()))

                Process.Start(temp + DataGridView1.SelectedRows(0).Cells(4).Value.ToString())
            End If
        End If
    End Sub
End Class