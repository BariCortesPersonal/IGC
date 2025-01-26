
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.IdentityModel.Protocols




Public Class Conecction
    Dim connection As SqlConnection

    Public Function conect() As SqlConnection
        connection = New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
        Return connection
    End Function
End Class
