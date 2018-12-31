Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports System.Configuration 'JUST ADDED'
Imports System.Linq
Imports System.Web


Public Class SqlHelper
    Dim _BLL As New BLL
#Region "CONNECTION STRINGS"

    Public Function ExecuteNonQuery(ConnectionString As SqlConnection, CommandType As CommandType, commandText As String, ParamArray params As SqlParameter()) As Integer

        Try
            Dim cmd As New SqlCommand(commandText, ConnectionString)
            cmd.CommandType = CommandType
            cmd.CommandTimeout = 0
            cmd.Parameters.AddRange(params)
            ConnectionString.Open()
            Return cmd.ExecuteNonQuery
        Catch ex As Exception
            BLL.WriteLog(ex.Message + "::@" + ex.StackTrace)
            Return Nothing
        Finally
            ConnectionString.Close()
        End Try
    End Function

    Public Function ExecuteScalar(ConnectionString As SqlConnection, CommandType As CommandType, commandText As String, ParamArray params As SqlParameter()) As Object

        Try
            Dim cmd As New SqlCommand(commandText, ConnectionString)
            cmd.CommandType = CommandType
            cmd.CommandTimeout = 0
            cmd.Parameters.AddRange(params)
            ConnectionString.Open()
            Return cmd.ExecuteScalar
        Catch ex As Exception
            BLL.WriteLog(ex.Message + "::@" + ex.StackTrace)
            Return Nothing
        Finally
            ConnectionString.Close()
        End Try
    End Function

    Public Function ExecuteReader(ConnectionString As SqlConnection, CommandType As CommandType, commandText As String, ParamArray params As SqlParameter()) As SqlDataReader

        Try
            Dim cmd As New SqlCommand(commandText, ConnectionString)
            cmd.CommandType = CommandType
            cmd.CommandTimeout = 0
            cmd.Parameters.AddRange(params)
            ConnectionString.Open()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return reader
        Catch ex As Exception
            BLL.WriteLog(ex.Message + "::@" + ex.StackTrace)
            Return Nothing
        Finally
            ConnectionString.Close()
        End Try
    End Function

    Public Function ExecuteDataset(ConnectionString As SqlConnection, CommandType As CommandType, commandText As String, ParamArray commandParameter As SqlParameter()) As DataSet
        Try
            Dim cmd As New SqlCommand(commandText, ConnectionString)
            cmd.CommandType = CommandType
            cmd.CommandTimeout = 0
            cmd.Parameters.AddRange(commandParameter)
            ConnectionString.Open()
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            myAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            BLL.WriteLog(ex.Message + "::@" + ex.StackTrace)
            Return Nothing
        Finally
            ConnectionString.Close()
        End Try
    End Function


#End Region
End Class
