Public Class Frm_WorkForm_kargozini

    Private Sub Frm_RpWorkForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HafteTableAdapter.Fill(Me.Ds_Pm.Hafte)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        Me.Pm_HazineCodeTableAdapter.Fill(Me.Ds_Pm.Pm_HazineCode, 1)
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        Me.Pm_WorkDisTableAdapter.Fill(Me.Ds_Pm.Pm_WorkDis)
        Me.PM_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Pm_GroupTableAdapter.Fill(Ds_Pm.Pm_Group, -1)
        Me.txt_FromDate.Value = Setting.TarikheJary.Remove(8) + "01"
        Me.txt_ToDate.Value = Setting.TarikheJary
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        Dim FromDate As String = "-1"
        Dim ToDate As String = "-1"
        If Not chk_allday.Checked Then
            FromDate = txt_FromDate.Value
            ToDate = txt_ToDate.Value
        End If

        Dim MahalFaliat As Integer = -1
        If Not chk_MahalFaliat.Checked Then
            MahalFaliat = cmb_mahalFaliat.SelectedValue
        End If


        Dim AllVahed As Integer = -1
        If Not Chk_AllVahed.Checked Then
            AllVahed = cmb_AllVahed.SelectedValue
        End If

        Dim Srl_Ashkhas As Integer = -1
        If Not chk_Ozv.Checked Then
            Srl_Ashkhas = cmb_ozv.SelectedValue
        End If

        Dim Gorup As Integer = -1
        If Not chk_Group.Checked Then
            Gorup = Cmb_Group.SelectedValue
        End If


        Dim f As New Frm_Wait
        Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)

        Try
            If t.IsAlive Then
                t.Abort()
            End If
            t.Start()
        Catch ex As Exception
            MessageBoxFa.Show("لطفا دوباره تلاش نمائید.")
        End Try


        Try
            Rp_WorkForm_KargoziniTableAdapter.Fill(Ds_Rp1.Rp_WorkForm_Kargozini, MahalFaliat, Gorup, AllVahed _
                                                     , FromDate, ToDate, Srl_Ashkhas)
            DataGridView1.Refresh()

            lbl_Record.Text = "تعداد رکورد :"
            lbl_Record.Text += Ds_Rp1.Rp_WorkForm_Kargozini.Rows.Count.ToString
            DataGridView1.DataSource = Ds_Rp1.Rp_WorkForm_Kargozini
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
            If t.IsAlive Then
                t.Abort()
            End If
            MessageBoxFa.Show("لطفا دامنه جستجو را کمتر کنيد")
        Finally
            If t.IsAlive Then
                t.Abort()
            End If
        End Try

    End Sub




    Private Sub chk_MahalFaliat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_MahalFaliat.CheckedChanged
        cmb_mahalFaliat.Enabled = Not chk_MahalFaliat.Checked
    End Sub


    Private Sub Chk_AllVahed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_AllVahed.CheckedChanged
        cmb_AllVahed.Enabled = Not Chk_AllVahed.Checked
    End Sub

    Private Sub chk_Group_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Group.CheckedChanged
        Cmb_Group.Enabled = Not chk_Group.Checked
    End Sub

    Private Sub chk_allday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_allday.CheckedChanged
        txt_FromDate.Enabled = Not chk_allday.Checked
        txt_ToDate.Enabled = Not chk_allday.Checked
    End Sub

    Private Sub chk_Ozv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Ozv.CheckedChanged
        cmb_ozv.Enabled = Not chk_Ozv.Checked
    End Sub

    ''Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ٍExcel.Click
    'Dim f As New Frm_Wait
    'Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)
    '    t.Start()

    'Dim rp As New Rp_WorkFormGozareshHaftegi

    '    rp.SetDataSource(DirectCast(DataGridView1.DataSource, DataTable).DefaultView)
    '    rp.SetParameterValue(rp.Parameter_tarikhGozaresh.ParameterFieldName, Setting.TarikheJary)
    'Dim frm_rp As New Frm_RpVw(rp, DirectCast(DataGridView1.DataSource, DataTable))
    '    If t.IsAlive Then
    '        t.Abort()
    '    End If

    '    frm_rp.ShowDialog()
    'End Sub

    Private Sub Btn_ٍExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ٍExcel.Click
        Dim f As New Frm_Wait
        Dim t As New System.Threading.Thread(AddressOf f.ShowDialog)
        If DataGridView1.RowCount = 0 Then
            MessageBoxFa.Show("برای ذخیره فایل باید جستجوی شما خروجی داشته باشد")
            Return
        Else
            Try
                If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    t.Start()
                    DatatableToExcel(Ds_Rp1.Rp_WorkForm_Kargozini, SaveFileDialog1.FileName)
                    If t.IsAlive Then
                        t.Abort()
                    End If
                    MessageBoxFa.Show("اطلاعات با موفقیت ذخیره گردید")
                    Dim xlsApp As Microsoft.Office.Interop.Excel.Application = Nothing
                    Dim xlsWorkBooks As Microsoft.Office.Interop.Excel.Workbooks = Nothing
                    Dim xlsWB As Microsoft.Office.Interop.Excel.Workbook = Nothing
                    Try


                        xlsApp = New Microsoft.Office.Interop.Excel.Application()
                        xlsApp.Visible = True
                        xlsWorkBooks = xlsApp.Workbooks
                        xlsWB = xlsWorkBooks.Open(SaveFileDialog1.FileName)

                    Catch ex As Exception

                    Finally



                    End Try

                End If
            Catch ex As Exception
                If t.IsAlive Then
                    t.Abort()
                End If
                MessageBoxFa.Show(ex.Message)
                MessageBoxFa.Show("اشکال در ذخیره سازی. لطفا دوباره تلاش فرمائید.")
            End Try
        End If
    End Sub

    Private Sub DatatableToExcel(ByVal dtTemp As DataTable, ByVal FilePath As String)

        Dim _excel As New Microsoft.Office.Interop.Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim newCulture As System.Globalization.CultureInfo
        Dim OldCulture As System.Globalization.CultureInfo


        OldCulture = System.Threading.Thread.CurrentThread.CurrentCulture
        'newCulture = New System.Globalization.CultureInfo(_excel.LanguageSettings.LanguageID(2))
        System.Threading.Thread.CurrentThread.CurrentCulture = newCulture


        _excel.DefaultSheetDirection = Microsoft.Office.Interop.Excel.Constants.xlRTL
        wBook = _excel.Workbooks.Add()

        wSheet = wBook.ActiveSheet()



        Dim dt As System.Data.DataTable = dtTemp

        Dim dc As System.Data.DataColumn

        Dim dr As System.Data.DataRow

        Dim colIndex As Integer = 0

        Dim rowIndex As Integer = 0



        For Each dc In dt.Columns

            colIndex = colIndex + 1

            _excel.Cells(1, colIndex) = dc.ColumnName

        Next



        For Each dr In dt.Rows

            rowIndex = rowIndex + 1

            colIndex = 0

            For Each dc In dt.Columns

                colIndex = colIndex + 1

                _excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

            Next

        Next



        wSheet.Columns.AutoFit()

        Dim strFileName As String = FilePath

        If System.IO.File.Exists(strFileName) Then

            System.IO.File.Delete(strFileName)

        End If



        wBook.SaveAs(strFileName)

        wBook.Close()

        _excel.Quit()

    End Sub

End Class