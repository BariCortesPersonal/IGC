
Imports System.Configuration
Imports Entity
Imports BusinessLogic
Imports Presentation.GlobalVariables

Public Class frmLogin

    ReadOnly MyloadedForm As New cIdleTimeStool



    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtUser.Text = Environment.UserName
        Me.txtPassword.MaxLength = 25
        Me.txtPassword.PasswordChar = "*"c
        Me.txtUser.Focus()
        Me.LkLblForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lkLblRequestAccess.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline

        Me.txtUser.Text = "Admin"
        Me.txtPassword.Text = "@Crypto2025"

    End Sub


    Function GetUserName() As String
        Return Me.txtUser.Text
    End Function

    Function GetPassword() As String
        Return Me.txtPassword.Text
    End Function


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If MyloadedForm.IsFormOpen(Main) = False Then
            Me.Close()
        Else
            Dim logout = MessageBox.Show("If you close the system now, all the unsaved information will be lost. Continue?", "System Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If logout = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                txtPassword.Focus()
            End If
        End If

    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If GetUserName() <> Nothing And GetPassword() <> Nothing Then
            Call Login()
        Else
            MessageBox.Show("The User/Password can not be Null", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub Login()

        Dim par As New ceUser
        Dim User As New ceUser
        Dim ds As New DataTable
        Dim businessLogic As New cnUser
        par.UserID = GetUserName()
        par.Password = GetPassword()
        ds = businessLogic.GetUserRoll(par).Tables("User")
        User.UserRoll = ds.Rows(0).Item(0).ToString()
        If MyloadedForm.IsFormOpen(Main) = False Then
            If LTrim(RTrim(User.UserRoll)) = "NOUSER" Then
                MessageBox.Show("Invalid User/Password credentials", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Text = Nothing
                txtUser.Focus()
            Else
                vUser_Roll = ds.Rows(0).Item(0).ToString()
                vUser_ID = ds.Rows(0).Item(1).ToString()
                Me.Hide()
                Main.Show()
            End If
        End If

    End Sub


    Private Sub lkLblRequestAccess_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkLblRequestAccess.LinkClicked

        If MyloadedForm.IsFormOpen(frmUserAccess) = False Then
            Me.Hide()
            frmUserAccess.pnRessetPassword.Enabled = False
            frmUserAccess.pnRessetPassword.Visible = False
            frmUserAccess.btnRequest.Text = "Request"
            frmUserAccess.Show()
        End If

    End Sub

    Private Sub LkLblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LkLblForgotPassword.LinkClicked

        If MyloadedForm.IsFormOpen(frmUserAccess) = False Then
            Me.Hide()
            frmUserAccess.pnRequestAccess.Enabled = False
            frmUserAccess.pnRequestAccess.Visible = False
            frmUserAccess.btnRequest.Text = "Restart"
            frmUserAccess.Show()
        End If

    End Sub





End Class