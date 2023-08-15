Public Class Frm_Dakal

    Private srl_line As Integer = -1
    Public Overrides Sub LoadDataGridView()
        Me.Pm_Line_DakalTableAdapter1.Fill(Me._Ds_Line_2.Pm_Line_Dakal, srl_line)

        MyBase.LoadDataGridView()
    End Sub
    Public Sub New(ByVal srl_Line As Integer)
        InitializeComponent()
        Me.srl_line = srl_Line
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        If srl_line < 1 Then
            MessageBoxFa.Show("خطا در ذخیره سازی لطفا دوباره تلاش نمائید", "خطا", MessageBoxButtons.OK)
            Return False
        End If
        DataObject.DataRow("SubmitDate") = Setting.Now
        DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        DataObject.DataRow("Srl_Line") = srl_line
        Return MyBase.Save(DoClearForm)
    End Function

    Private Sub Frm_Post_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Ds_Line_2.Pm_Line_MaghareProvider' table. You can move, or remove it, as needed.
        Me.Pm_Line_MaghareProviderTableAdapter1.Fill(Me._Ds_Line_2.Pm_Line_MaghareProvider)
        'TODO: This line of code loads data into the '_Ds_Line_2.Pm_Line_MaghareType' table. You can move, or remove it, as needed.
        Me.Pm_Line_MaghareTypeTableAdapter1.Fill(Me._Ds_Line_2.Pm_Line_MaghareType)
        'TODO: This line of code loads data into the '_Ds_Line_2.Pm_Line_MaghareChain' table. You can move, or remove it, as needed.
        Me.Pm_Line_MaghareChainTableAdapter1.Fill(Me._Ds_Line_2.Pm_Line_MaghareChain)
        'TODO: This line of code loads data into the '_Ds_Line_2.Pm_Line_DakalModel' table. You can move, or remove it, as needed.
        Me.Pm_Line_DakalModelTableAdapter.Fill(Me._Ds_Line_2.Pm_Line_DakalModel)
        'TODO: This line of code loads data into the '_Ds_Line_2.Pm_Line_DakalProvider' table. You can move, or remove it, as needed.
        Me.Pm_Line_DakalProviderTableAdapter1.Fill(Me._Ds_Line_2.Pm_Line_DakalProvider)
        'TODO: This line of code loads data into the '_Ds_Line_2.Pm_Line_DakalCode' table. You can move, or remove it, as needed.
        Me.Pm_Line_DakalCodeTableAdapter1.Fill(Me._Ds_Line_2.Pm_Line_DakalCode)
        'TODO: This line of code loads data into the '_Ds_Line_2.Pm_Line_DakalType' table. You can move, or remove it, as needed.
        Me.Pm_Line_DakalTypeTableAdapter1.Fill(Me._Ds_Line_2.Pm_Line_DakalType)
        'TODO: This line of code loads data into the '_Ds_Line_2.Pm_Line_DakalStructure' table. You can move, or remove it, as needed.
        Me.Pm_Line_DakalStructureTableAdapter1.Fill(Me._Ds_Line_2.Pm_Line_DakalStructure)
        Me.Pm_Line_DakalTableAdapter1.Fill(Me._Ds_Line_2.Pm_Line_Dakal, srl_line)
        Me.Text = "تعریف دکل های خط " + BaseDataObject.DataAccess.ExecScalar("select name from pm_line where srl=" + srl_line.ToString())
    End Sub


End Class