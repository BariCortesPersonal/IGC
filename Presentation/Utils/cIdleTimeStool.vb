


Option Strict On

Imports System.Runtime.InteropServices
Public Class cIdleTimeStool
    Public Structure LASTINPUTINFO
        Public cbSize As UInteger
        Public dwTime As UInteger
    End Structure

    'API call that let us detect any keyboard and/or mouse activity
    <DllImport("user32.dll")>
    Private Shared Function GetLastInputInfo(ByRef plii As LASTINPUTINFO) As Boolean
    End Function

    'Returns the time since last user activity
    Public Function GetInactiveTime() As Nullable(Of TimeSpan)
        Dim info As LASTINPUTINFO = New LASTINPUTINFO
        info.cbSize = CUInt(Marshal.SizeOf(info))
        If (GetLastInputInfo(info)) Then
            Return TimeSpan.FromMilliseconds(Environment.TickCount - info.dwTime)
        Else
            Return Nothing
        End If
    End Function

    Public Function IsFormOpen(ByVal frm As Form) As Boolean
        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class