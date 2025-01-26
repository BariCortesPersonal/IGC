
Imports Entity
Imports BusinessLogic
Imports Presentation.GlobalVariables

Public Class Form2




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize
        Me.WindowState = FormWindowState.Maximized
        '  Me.Panel_Main.AutoScroll = True
        '  Me.tstMain.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize
        ' Me.tstMain.Focus()


        vWidth = Me.Width - 10
        vHeight = Me.Height - 170

        'Me.Panel1.Width = vWidth - 3


    End Sub


End Class