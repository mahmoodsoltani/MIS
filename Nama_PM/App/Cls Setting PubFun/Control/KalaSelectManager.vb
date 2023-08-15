Imports System.ComponentModel

<DefaultEvent("FinalizeResult")> _
Public Class KalaSelectManager
    Public Event FinalizeResult As EventHandler
    Private _Dr As DataRow
    Private _SelectQueryMode As QueryMode = QueryMode.SelectWithPrice
    Dim lk As New VB_Component.LookUpButton
    Dim QueryString_SelectWithPrice_LK As String = "SELECT   dbo.Stg_Kala.Srl, dbo.Stg_Kala.BarcodeCode as [کد], dbo.Stg_Kala.Name as [نام],Stg_KalaGroup.Name as [گروه کالا], isnull(dbo.Stg_KalaPrice.FroshPrice,0) [قيمت فروش]" & _
                                                                              ",isUserPrice FROM   dbo.Stg_Kala INNER JOIN  Stg_KalaGroup on Stg_KalaGroup.Srl = Stg_Kala.Srl_Stg_KalaGroup   LEFT OUTER JOIN dbo.Stg_KalaPrice ON dbo.Stg_Kala.Srl = dbo.Stg_KalaPrice.Srl_Stg_Kala" & _
                                                                              " WHERE     dbo.Stg_KalaPrice.Active = 1  "
    Dim QueryString_SelectWithPrice As String = QueryString_SelectWithPrice_LK + " AND (dbo.Stg_Kala.BarcodeCode = '@@@@@@')"

    Dim QueryString_SelectKala_LK As String = "SELECT     dbo.Stg_Kala.Srl, dbo.Stg_Kala.BarcodeCode AS کد, dbo.Stg_Kala.Name AS نام,Stg_KalaGroup.Name as [گروه کالا], dbo.Stg_Sazande.Name AS سازنده " & _
                                            " FROM dbo.Stg_Kala INNER JOIN  Stg_KalaGroup on Stg_KalaGroup.Srl = Stg_Kala.Srl_Stg_KalaGroup   LEFT OUTER JOIN dbo.Stg_Sazande ON dbo.Stg_Kala.Srl_Stg_Sazande = dbo.Stg_Sazande.Srl  where 1=1"
    Dim QueryString_SelectKala As String = QueryString_SelectKala_LK + " And dbo.Stg_Kala.BarcodeCode = '@@@@@@' "

    Dim QueryString_SelectKala_Like As String = "SELECT     dbo.Stg_Kala.Srl, dbo.Stg_Kala.BarcodeCode AS کد, dbo.Stg_Kala.Name AS نام,Stg_KalaGroup.Name as [گروه کالا], dbo.Stg_Sazande.Name AS سازنده " & _
                                        " FROM dbo.Stg_Kala INNER JOIN  Stg_KalaGroup on Stg_KalaGroup.Srl = Stg_Kala.Srl_Stg_KalaGroup   INNER JOIN dbo.Stg_Sazande ON dbo.Stg_Kala.Srl_Stg_Sazande = dbo.Stg_Sazande.Srl  WHERE  dbo.Stg_Kala.BarcodeCode like '%@@@@@@%' "


    Public WriteOnly Property Barcode() As String
        Set(ByVal value As String)
            If SelectQueryMode = QueryMode.SelectWithPrice Then
                _Dr = BaseDataObject.DataAccess.GetRow(QueryString_SelectWithPrice.Replace("@@@@@@", value))
                If Result Is Nothing Then
                    txt_KalaName.Value = "موردي يافت نشد"
                    txt_Barcode.Focus()
                    Return
                End If
                If Result("قيمت فروش") = 0 Then
                    If Result("isUserPrice") = False Then
                        MessageBoxFa.Show("قيمت اين کالا تعريف نشده")
                    End If
                End If
                txt_KalaName.Value = Result("نام")
                txt_Barcode.Value = Result("کد")
                txt_Barcode.Focus()
            ElseIf SelectQueryMode = QueryMode.SelectKala Then
                _Dr = BaseDataObject.DataAccess.GetRow(QueryString_SelectKala.Replace("@@@@@@", value))
                If Result Is Nothing Then  
                    txt_KalaName.Value = "موردي يافت نشد"
                    txt_Barcode.Value = ""
                    txt_Barcode.Focus()
                    Return
                Else
                    txt_Barcode.Value = value
                    txt_KalaName.Value = Result("نام")
                    txt_Barcode.Focus()
                End If
            End If
        End Set
    End Property

    Public Property Result() As DataRow
        Get
            Return _Dr
        End Get
        Set(ByVal value As DataRow)
            _Dr = value
        End Set
    End Property

    Enum QueryMode
        SelectWithPrice = 1
        SelectKala = 2
    End Enum

    Public Property SelectQueryMode() As QueryMode
        Get
            Return _SelectQueryMode
        End Get
        Set(ByVal value As QueryMode)
            _SelectQueryMode = value
        End Set
    End Property

    Private Sub txt_Barcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Barcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If _Dr Is Nothing Then
                If SelectQueryMode = QueryMode.SelectWithPrice Then
                    _Dr = BaseDataObject.DataAccess.GetRow(QueryString_SelectWithPrice.Replace("@@@@@@", txt_Barcode.Value))
                    If Result Is Nothing Then
                        txt_KalaName.Value = "موردي يافت نشد"
                        txt_Barcode.Focus()
                        Return
                    End If
                    If Result("قيمت فروش") = 0 Then
                        If Result("isUserPrice") = False Then
                            MessageBoxFa.Show("قيمت اين کالا تعريف نشده")
                            Return
                        End If
                    End If
                    txt_KalaName.Value = Result("نام")
                    RaiseEvent FinalizeResult(sender, e)
                ElseIf SelectQueryMode = QueryMode.SelectKala Then
                    _Dr = BaseDataObject.DataAccess.GetRow(QueryString_SelectKala.Replace("@@@@@@", txt_Barcode.Value))
                    If Result Is Nothing Then
                        _Dr = BaseDataObject.DataAccess.GetRow(QueryString_SelectKala_Like.Replace("@@@@@@", txt_Barcode.Value))
                        If Result Is Nothing Then
                            txt_KalaName.Value = "موردي يافت نشد"
                            txt_Barcode.Focus()
                            Return
                        Else
                            txt_KalaName.Value = Result("نام")
                            txt_Barcode.Value = Result("کد")
                            RaiseEvent FinalizeResult(sender, e)
                        End If
                    Else
                        txt_KalaName.Value = Result("نام")
                        RaiseEvent FinalizeResult(sender, e)
                    End If
                End If
            Else
                RaiseEvent FinalizeResult(sender, e)
            End If
        End If
    End Sub

    Public Sub ResetResult()
        RemoveHandler txt_Barcode.KeyDown, New KeyEventHandler(AddressOf txt_Barcode_KeyDown)
        txt_Barcode.Value = ""
        txt_KalaName.Value = ""
        _Dr = Nothing
        lk.ResetResult()
        AddHandler txt_Barcode.KeyDown, New KeyEventHandler(AddressOf txt_Barcode_KeyDown)
    End Sub

    Private Sub Btn_Select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Select.Click
        If SelectQueryMode = QueryMode.SelectWithPrice Then
            lk.LoadLookUp(BaseDataObject.DataAccess.GetDataTable(QueryString_SelectWithPrice_LK), 0, 1, "انتخاب کالا", False)
            lk.ShowLookUPForm(2, "")
        ElseIf SelectQueryMode = QueryMode.SelectKala Then
            lk.LoadLookUp(BaseDataObject.DataAccess.GetDataTable(QueryString_SelectKala_LK), 0, 1, "انتخاب کالا", False)
            lk.ShowLookUPForm(2, "")
        End If

        If Not lk.Result Is Nothing Then
            Barcode = lk.Result(1)
            RaiseEvent FinalizeResult(sender, e)
        End If
    End Sub

    Private Sub txt_Barcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Barcode.TextChanged
        If txt_Barcode.Value = "" Then
            ResetResult()
        End If
    End Sub

    Private Sub KalaSelectManager_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.PageUp Then
            Btn_Select_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub KalaSelectManager_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = CType(ChrW(Keys.PageUp), Char) Then
            Btn_Select_Click(Nothing, Nothing)
        End If
    End Sub
End Class
