
Imports System.Data
Imports DataAccess
Imports Entity


Public Class cnNewID
    Dim objID As New dao_ID

    Public Function GetID() As DataSet
        Return objID.listID()
    End Function


End Class
