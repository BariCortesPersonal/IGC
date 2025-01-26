<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserManagement))
        pnRessetPassword = New Panel()
        Label4 = New Label()
        txtRestartEmail = New TextBox()
        Label3 = New Label()
        txtRestartNewPassword_2 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtRestartNewPassword = New TextBox()
        txtRestartUserID = New TextBox()
        pnRequestAccess = New Panel()
        Label11 = New Label()
        txtNewUserPassword_2 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        txtNewUserPassword = New TextBox()
        txtNewUserID = New TextBox()
        Label8 = New Label()
        txtNewUserPhone = New TextBox()
        Label7 = New Label()
        txtNewUserLastName = New TextBox()
        Label5 = New Label()
        txtNewUserEmail = New TextBox()
        Label6 = New Label()
        txtNewUserFirstName = New TextBox()
        PictureBox1 = New PictureBox()
        btnRequest = New Button()
        Button1 = New Button()
        pnRessetPassword.SuspendLayout()
        pnRequestAccess.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnRessetPassword
        ' 
        pnRessetPassword.Controls.Add(Label4)
        pnRessetPassword.Controls.Add(txtRestartEmail)
        pnRessetPassword.Controls.Add(Label3)
        pnRessetPassword.Controls.Add(txtRestartNewPassword_2)
        pnRessetPassword.Controls.Add(Label2)
        pnRessetPassword.Controls.Add(Label1)
        pnRessetPassword.Controls.Add(txtRestartNewPassword)
        pnRessetPassword.Controls.Add(txtRestartUserID)
        pnRessetPassword.Location = New Point(404, 99)
        pnRessetPassword.Name = "pnRessetPassword"
        pnRessetPassword.Size = New Size(640, 213)
        pnRessetPassword.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(48, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 23)
        Label4.TabIndex = 11
        Label4.Text = "Email:"
        ' 
        ' txtRestartEmail
        ' 
        txtRestartEmail.BorderStyle = BorderStyle.FixedSingle
        txtRestartEmail.Location = New Point(270, 70)
        txtRestartEmail.Name = "txtRestartEmail"
        txtRestartEmail.Size = New Size(330, 27)
        txtRestartEmail.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(48, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 23)
        Label3.TabIndex = 9
        Label3.Text = "Re-Enter New Password:"
        ' 
        ' txtRestartNewPassword_2
        ' 
        txtRestartNewPassword_2.BorderStyle = BorderStyle.FixedSingle
        txtRestartNewPassword_2.Location = New Point(270, 149)
        txtRestartNewPassword_2.Name = "txtRestartNewPassword_2"
        txtRestartNewPassword_2.Size = New Size(330, 27)
        txtRestartNewPassword_2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(48, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 23)
        Label2.TabIndex = 7
        Label2.Text = "New Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(48, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 23)
        Label1.TabIndex = 6
        Label1.Text = "User ID:"
        ' 
        ' txtRestartNewPassword
        ' 
        txtRestartNewPassword.BorderStyle = BorderStyle.FixedSingle
        txtRestartNewPassword.Location = New Point(270, 110)
        txtRestartNewPassword.Name = "txtRestartNewPassword"
        txtRestartNewPassword.Size = New Size(330, 27)
        txtRestartNewPassword.TabIndex = 3
        ' 
        ' txtRestartUserID
        ' 
        txtRestartUserID.AcceptsReturn = True
        txtRestartUserID.BorderStyle = BorderStyle.FixedSingle
        txtRestartUserID.Location = New Point(270, 30)
        txtRestartUserID.Name = "txtRestartUserID"
        txtRestartUserID.Size = New Size(239, 27)
        txtRestartUserID.TabIndex = 1
        ' 
        ' pnRequestAccess
        ' 
        pnRequestAccess.Controls.Add(Label11)
        pnRequestAccess.Controls.Add(txtNewUserPassword_2)
        pnRequestAccess.Controls.Add(Label9)
        pnRequestAccess.Controls.Add(Label10)
        pnRequestAccess.Controls.Add(txtNewUserPassword)
        pnRequestAccess.Controls.Add(txtNewUserID)
        pnRequestAccess.Controls.Add(Label8)
        pnRequestAccess.Controls.Add(txtNewUserPhone)
        pnRequestAccess.Controls.Add(Label7)
        pnRequestAccess.Controls.Add(txtNewUserLastName)
        pnRequestAccess.Controls.Add(Label5)
        pnRequestAccess.Controls.Add(txtNewUserEmail)
        pnRequestAccess.Controls.Add(Label6)
        pnRequestAccess.Controls.Add(txtNewUserFirstName)
        pnRequestAccess.Location = New Point(404, 333)
        pnRequestAccess.Name = "pnRequestAccess"
        pnRequestAccess.Size = New Size(640, 341)
        pnRequestAccess.TabIndex = 44
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F)
        Label11.Location = New Point(48, 294)
        Label11.Name = "Label11"
        Label11.Size = New Size(155, 23)
        Label11.TabIndex = 25
        Label11.Text = "Re-Enter Password:"
        ' 
        ' txtNewUserPassword_2
        ' 
        txtNewUserPassword_2.BorderStyle = BorderStyle.FixedSingle
        txtNewUserPassword_2.Location = New Point(266, 290)
        txtNewUserPassword_2.Name = "txtNewUserPassword_2"
        txtNewUserPassword_2.Size = New Size(330, 27)
        txtNewUserPassword_2.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F)
        Label9.Location = New Point(48, 253)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 23)
        Label9.TabIndex = 23
        Label9.Text = "Password:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F)
        Label10.Location = New Point(48, 215)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 23)
        Label10.TabIndex = 22
        Label10.Text = "User ID:"
        ' 
        ' txtNewUserPassword
        ' 
        txtNewUserPassword.BorderStyle = BorderStyle.FixedSingle
        txtNewUserPassword.Location = New Point(266, 249)
        txtNewUserPassword.Name = "txtNewUserPassword"
        txtNewUserPassword.Size = New Size(330, 27)
        txtNewUserPassword.TabIndex = 17
        ' 
        ' txtNewUserID
        ' 
        txtNewUserID.BorderStyle = BorderStyle.FixedSingle
        txtNewUserID.Location = New Point(266, 211)
        txtNewUserID.Name = "txtNewUserID"
        txtNewUserID.Size = New Size(330, 27)
        txtNewUserID.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.Location = New Point(48, 144)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 23)
        Label8.TabIndex = 19
        Label8.Text = "Phone Number:"
        ' 
        ' txtNewUserPhone
        ' 
        txtNewUserPhone.BorderStyle = BorderStyle.FixedSingle
        txtNewUserPhone.Location = New Point(266, 141)
        txtNewUserPhone.Name = "txtNewUserPhone"
        txtNewUserPhone.Size = New Size(239, 27)
        txtNewUserPhone.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(48, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 23)
        Label7.TabIndex = 17
        Label7.Text = "Last Name:"
        ' 
        ' txtNewUserLastName
        ' 
        txtNewUserLastName.BorderStyle = BorderStyle.FixedSingle
        txtNewUserLastName.Location = New Point(266, 67)
        txtNewUserLastName.Name = "txtNewUserLastName"
        txtNewUserLastName.Size = New Size(239, 27)
        txtNewUserLastName.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(48, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 23)
        Label5.TabIndex = 15
        Label5.Text = "Email:"
        ' 
        ' txtNewUserEmail
        ' 
        txtNewUserEmail.BorderStyle = BorderStyle.FixedSingle
        txtNewUserEmail.Location = New Point(266, 104)
        txtNewUserEmail.Name = "txtNewUserEmail"
        txtNewUserEmail.Size = New Size(330, 27)
        txtNewUserEmail.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(48, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 23)
        Label6.TabIndex = 13
        Label6.Text = "First Name:"
        ' 
        ' txtNewUserFirstName
        ' 
        txtNewUserFirstName.BorderStyle = BorderStyle.FixedSingle
        txtNewUserFirstName.Location = New Point(266, 32)
        txtNewUserFirstName.Name = "txtNewUserFirstName"
        txtNewUserFirstName.Size = New Size(239, 27)
        txtNewUserFirstName.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(34, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(283, 276)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' btnRequest
        ' 
        btnRequest.Location = New Point(871, 691)
        btnRequest.Name = "btnRequest"
        btnRequest.Size = New Size(173, 47)
        btnRequest.TabIndex = 10
        btnRequest.Text = "Request"
        btnRequest.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(674, 691)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 47)
        Button1.TabIndex = 11
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmUserManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1071, 755)
        Controls.Add(Button1)
        Controls.Add(btnRequest)
        Controls.Add(PictureBox1)
        Controls.Add(pnRequestAccess)
        Controls.Add(pnRessetPassword)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmUserManagement"
        Text = "frmUserManagement"
        pnRessetPassword.ResumeLayout(False)
        pnRessetPassword.PerformLayout()
        pnRequestAccess.ResumeLayout(False)
        pnRequestAccess.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnRessetPassword As Panel
    Friend WithEvents pnRequestAccess As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRequest As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRestartNewPassword As TextBox
    Friend WithEvents txtRestartUserID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRestartNewPassword_2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRestartEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNewUserEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNewUserFirstName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNewUserPhone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNewUserLastName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNewUserPassword As TextBox
    Friend WithEvents txtNewUserID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNewUserPassword_2 As TextBox
End Class
