Imports System.Data.SqlClient
Imports GsmComm.GsmCommunication

Public Class Setting

#Region "Shared Variable"
    Public Shared CompanyInfo As Integer = -1
    Public Shared SaleMalyInfo As Integer = -1
    Public Shared ConnectionString As String = ""
    Public Shared ServerName As String = ""
    Public Shared TarikheJary As String = ""
    Public Shared Srl_User As Integer = -1
    Public Shared UserName As String = ""
    Public Shared ClientIpAddress As String = ""
    Public Shared GSMCom As GsmCommMain
    Public Shared Signal As Integer = -1
    Public Shared PortName As String = ""

#End Region

    Public Shared ReadOnly Property Now() As Date
        Get
            Return BaseDataObject.DataAccess.ExecScalar("SELECT  GETDATE()")
        End Get
    End Property

#Region "Setting Object"
    Public Shared MazadEzafekar_Normal As New SettingNode
    Public Shared MazadEzafekar_HolyDay As New SettingNode
    Public Shared HolidayZarib As New SettingNode
    Public Shared HolidayStatusStatementZarib As New SettingNode
    Public Shared CancleStatusStatementZarib As New SettingNode
    Public Shared CancleStatusStatementZarib_WorkForm As New SettingNode
    Public Shared NightWorkStatusStatementZarib As New SettingNode
    Public Shared EzafeKarTaradodBound As New SettingNode
    Public Shared MaxTaradodBound As New SettingNode
    Public Shared DarsadEzafeKarAlalhesab As New SettingNode
    Public Shared ModirMesage As New SettingNode
    Public Shared MainLogo As New SettingNode
    Public Shared ReportLogo As New SettingNode
    Public Shared Sms_Template As New SettingNode
    Public Shared Use_Sms_Template As New SettingNode
    Public Shared Default_Code_Hazine As New SettingNode
    Public Shared Mojaz_Date As New SettingNode
    Public Shared Mojaz_Date_Edit As New SettingNode
    ''New Add For Edit Time Card
    Public Shared ReportStartDate As New SettingNode
    Public Shared ReportEndDate As New SettingNode
    Public Shared UserEditStartDate As New SettingNode
    Public Shared UserEditEndDate As New SettingNode
    Public Shared AdminEditStartDate As New SettingNode
    Public Shared AdminEditEndDate As New SettingNode
#End Region

#Region "Enum"
    Public Enum ColorForZarib
        salam = 2
    End Enum

    Public Enum WorkType
        Movazaf = 1
        EzafeKar = 2
    End Enum

    Public Enum Hzg_Type
        Mamoli = 0
        Morakhasi = 1
        Mamoriat = 2
    End Enum

    Enum AnbarTypeTransfer
        FactorKharid = 1
        HavaleAnbar = 2
        FactorFrosh = 3
        Zayeat = 4
        Kosorat = 5
        MojodiAvalie = 6
        AnbarGardani = 7
        Bargasht_Kharid = 8
        Bargasht_Frosh = 9
    End Enum

    Enum FactorTypes
        Forosh = 1
        Kharid = 2
        BargashtForosh = 3
        BargashtKharid = 4
    End Enum
#End Region

#Region "Form Object"
    Public Shared Frm_Ashkhas_obj As Frm_Ashkhas
    Public Shared Frm_Sherkat_obj As Frm_Sherkatha
    Public Shared Frm_Vahed_obj As Frm_Vahed
    Public Shared Frm_Group_obj As Frm_Group
    Public Shared Frm_GroupMember_obj As Frm_GroupMember
    Public Shared Frm_PostTip_obj As Frm_Post_Tip
    Public Shared Frm_Post_obj As Frm_Post
    Public Shared Frm_DeviceEib_obj As Frm_EibType
    Public Shared Frm_FixEibDis_obj As Frm_FixEibDis
    Public Shared Frm_PostModel_obj As Frm_Post_Model
    Public Shared Frm_Distance_obj As Frm_Distance
    Public Shared Frm_WorkDis_obj As Frm_WorkForm_Dis
    Public Shared Frm_WorkForm_obj As Frm_WorkForm
    Public Shared Frm_WorkForm_Formula_Normal_obj As Frm_WorkForm_Formula
    Public Shared Frm_WorkForm_Formula_Taradod_obj As Frm_WorkForm_Formula
    Public Shared Frm_WorkForm_FormulaShow_obj As Frm_WorkForm_FormulaShow
    Public Shared Frm_EibForm_obj As Frm_EibForm
    'Public Shared Frm_Hzg_OpenFile_obj As Frm_Hzg_OpenFile
    Public Shared Frm_EibFormVw_obj As Frm_SmsVw
#End Region

End Class
