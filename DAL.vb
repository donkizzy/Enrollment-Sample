Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class DAL
    Dim _BLL As New BLL
    Dim con As SqlConnection
    Dim adapter As SqlDataAdapter
    Dim command As New SqlCommand
    Dim SqlHelper As New SqlHelper


#Region "CONNECTION STRINGS"
    Public Sub New()
        con = New SqlConnection(ConnectionString.Live_ConnectionString())
    End Sub

#End Region

#Region "GLOBAL METHOD"

    Public Function FINGERPRINT_INSERT(ByVal SUB_AGENT_NUMBER As String, ByVal TEMPLATE As String, ByVal SUB_AGENT_FIRST_NAME As String, ByVal SUB_AGENT_LAST_NAME As String,
                                       ByVal AGENCY_NUMBER As String, ByVal SUB_AGENT_GENDER As String, ByVal ACTION_TYPE As String) As DataSet
        Try
            Dim params() As SqlParameter = {New SqlParameter("@SUB_AGENT_NUMBER", SUB_AGENT_NUMBER),
                                            New SqlParameter("@TEMPLATE", TEMPLATE),
                                            New SqlParameter("@SUB_AGENT_FIRST_NAME", SUB_AGENT_FIRST_NAME),
                                            New SqlParameter("@SUB_AGENT_LAST_NAME", SUB_AGENT_LAST_NAME),
                                            New SqlParameter("@AGENCY_NUMBER", AGENCY_NUMBER),
                                            New SqlParameter("@SUB_AGENT_GENDER", SUB_AGENT_GENDER),
                                            New SqlParameter("@ACTION_TYPE", ACTION_TYPE)}
            Return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "DETAILS_INSERT", params)
            'name of the table coming from the DB
        Catch ex As Exception
            BLL.WriteLog(ex.Message & ":" & ex.StackTrace)
            Return Nothing
        End Try
    End Function

    Public Function TXN_PENDING_PAYMENT_UPDATE(ByVal TXN_ID As Integer, ByVal Location As String, ByVal Session_ID As String) As DataSet
        Try
            Dim params() As SqlParameter = {New SqlParameter("@SESSION_ID", Session_ID),
                                            New SqlParameter("@TXN_ID", TXN_ID),
                                            New SqlParameter("@LOCATION", Location)}
            Return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "TXN_PENDING_PAYMENT_UPDATE", params)
        Catch ex As Exception
            BLL.WriteLog(ex.Message + "@::" + ex.StackTrace)
            Return Nothing
        End Try
    End Function
  
 
#End Region





End Class


