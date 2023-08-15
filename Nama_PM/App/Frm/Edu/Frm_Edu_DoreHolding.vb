Public Class Frm_Edu_DoreHolding

    Private Sub Frm_Amo_DoreSubmit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Teacher' table. You can move, or remove it, as needed.
        Me.Pm_Edu_TeacherTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Teacher)
        Dim dr As DataRow = Me.Ds_Edu.Pm_Edu_Teacher.NewRow()
        dr("srl") = -1
        dr("نا م و نام خانوادگی") = "انتخاب کنید"
        Me.Ds_Edu.Pm_Edu_Teacher.Rows.InsertAt(dr, 0)
        cmb_Teacher.SelectedIndex = 0

        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_DoreHolding' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DoreHoldingTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreHolding)
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_Dore' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DoreTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_Dore)
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_DorePresenter' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DorePresenterTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DorePresenter)
        Dim dr2 As DataRow = Me.Ds_Edu.Pm_Edu_DorePresenter.NewRow()
        dr2("srl") = -1
        dr2("نام") = "انتخاب کنید"

        Me.Ds_Edu.Pm_Edu_DorePresenter.Rows.InsertAt(dr2, 0)
        cmb_Presenter.SelectedIndex = 0

        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_DorePlace' table. You can move, or remove it, as needed.
        Me.Pm_Edu_DorePlaceTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DorePlace)
        Dim dr3 As DataRow = Me.Ds_Edu.Pm_Edu_DorePlace.NewRow()
        dr3("srl") = -1
        dr3("نام") = "انتخاب کنید"
        Me.Ds_Edu.Pm_Edu_DorePlace.Rows.InsertAt(dr3, 0)
        cmb_Place.SelectedIndex = 0

    End Sub

    Public Overrides Sub LoadDataGridView()
        Me.Pm_Edu_DoreHoldingTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_DoreHolding)
    End Sub
    Protected Overrides Sub SetData(ByVal Control As System.Windows.Forms.Control)
        MyBase.SetData(Control)
        Dim place As Integer = BaseDataObject.DataAccess.ExecScalar("select place from Pm_Edu_DoreHolding where srl =  " + DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
        Dim Len As Double = BaseDataObject.DataAccess.ExecScalar("select Length from Pm_Edu_DoreHolding where srl =  " + DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
        txt_Length.Value = Len.ToString()
        If place = 1 Then
            insideProvenance.Checked = True
        ElseIf place = 2 Then
            OutsideProvenance.Checked = True
        Else
            OutsideCountry.Checked = True

        End If
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If insideProvenance.Checked Then
            DataObject.DataRow("Place") = 1
        ElseIf OutsideProvenance.Checked Then
            DataObject.DataRow("Place") = 2
        Else
            DataObject.DataRow("Place") = 3
        End If
        Dim a As Boolean
        a = MyBase.Save(DoClearForm)
        Return a
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Dore.SelectedIndexChanged
        If Not cmb_Dore.SelectedValue Is Nothing Then
            txt_Length.Text = BaseDataObject.DataAccess.ExecScalar("select length from pm_Edu_dore where srl =" + cmb_Dore.SelectedValue.ToString()).ToString()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn And e.RowIndex >= 0 Then
            Dim frm As New Frm_Edu_DoreParticipate(DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer))
            frm.ShowDialog()
        End If
    End Sub


  
End Class