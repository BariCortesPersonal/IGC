

Imports System.Configuration
Imports Entity
Imports BusinessLogic
Imports Presentation.GlobalVariables



Public Class frmUserAccess


    ReadOnly MyloadedForm As New cIdleTimeStool


    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.btnRequest.Text = "Request" Then
            Me.lblUserManagemets.Text = "User Access Request"
        ElseIf Me.btnRequest.Text = "Restart" Then
            Me.lblUserManagemets.Text = "User Restart Password"
        End If

        Me.txtNewUserPassword.MaxLength = 25
        Me.txtNewUserPassword.PasswordChar = "*"c
        Me.txtNewUserPassword_2.MaxLength = 25
        Me.txtNewUserPassword_2.PasswordChar = "*"c

        Me.txtRestartNewPassword.MaxLength = 25
        Me.txtRestartNewPassword.PasswordChar = "*"c
        Me.txtRestartNewPassword_2.MaxLength = 25
        Me.txtRestartNewPassword_2.PasswordChar = "*"c

    End Sub


    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click

        If Me.btnRequest.Text = "Restart" Then

            If Len(Me.txtRestartUserID.Text) > 0 And Len(Me.txtRestartEmail.Text) > 0 And Len(Me.txtRestartNewPassword.Text) > 0 _
                And Len(txtRestartNewPassword_2.Text) > 0 Then

                If txtRestartNewPassword.Text = txtRestartNewPassword_2.Text Then
                    Call ResetPassword()
                Else
                    MsgBox("Passwords have  match to restart the Password ")
                End If
            Else
                MsgBox("To restart the Password all fields must be filled in")
            End If

        ElseIf Me.btnRequest.Text = "Request" Then

            If Len(Me.txtNewUserFirstName.Text) > 0 And Len(Me.txtNewUserLastName.Text) > 0 And Len(Me.txtNewUserEmail.Text) > 0 _
                And Len(Me.txtNewUserPhone.Text) > 0 And Len(Me.txtNewUserID.Text) > 0 And Len(txtNewUserPassword.Text) > 0 And Len(Me.txtNewUserPassword_2.Text) > 0 Then

                If Me.txtNewUserPassword.Text = Me.txtNewUserPassword_2.Text Then
                    Call RequestAccess()
                Else
                    MsgBox("Passwords have  match to request access")
                End If

            Else
                MsgBox("To request access all fields must be filled in")
            End If


        End If



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Close()
        Me.Close()
    End Sub

    Private Sub RequestAccess()

        Dim par As New ceUser
        Dim businessLogic As New cnUser
        par.FirstName = Me.txtNewUserFirstName.Text
        par.LastName = Me.txtNewUserLastName.Text
        par.UserID = Me.txtNewUserID.Text
        par.Password = Me.txtNewUserPassword.Text
        par.Email = Me.txtNewUserEmail.Text
        par.Phone = Me.txtNewUserPhone.Text
        businessLogic.GetRequestAccess(par)
        MsgBox("An access request has been created. The App Administrator will evaluate it and will take a decision.", MsgBoxStyle.OkOnly, "")
        Me.Close()
        frmLogin.Close()

    End Sub

    Private Sub ResetPassword()

        Dim par As New ceUser
        Dim businessLogic As New cnUser
        par.UserID = Me.txtRestartUserID.Text
        par.Password = Me.txtRestartNewPassword.Text
        par.Email = Me.txtRestartEmail.Text
        businessLogic.GetRestartUserPassword(par)
        MsgBox("Your Password was successfully modified", MsgBoxStyle.OkOnly, "")
        Me.Close()
        frmLogin.Close()
    End Sub




End Class