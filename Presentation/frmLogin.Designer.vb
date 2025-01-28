<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        txtUser = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnCancel = New Button()
        btnLogin = New Button()
        LkLblForgotPassword = New LinkLabel()
        lkLblRequestAccess = New LinkLabel()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUser
        ' 
        txtUser.BorderStyle = BorderStyle.FixedSingle
        txtUser.Location = New Point(410, 157)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(330, 27)
        txtUser.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(410, 207)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(330, 27)
        txtPassword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(317, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 23)
        Label1.TabIndex = 2
        Label1.Text = "User ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(317, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 23)
        Label2.TabIndex = 3
        Label2.Text = "Password:"
        ' 
        ' btnCancel
        ' 
        btnCancel.ForeColor = Color.Red
        btnCancel.Location = New Point(497, 252)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(114, 40)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(626, 252)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(114, 40)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' LkLblForgotPassword
        ' 
        LkLblForgotPassword.AutoSize = True
        LkLblForgotPassword.Location = New Point(417, 322)
        LkLblForgotPassword.Name = "LkLblForgotPassword"
        LkLblForgotPassword.Size = New Size(160, 20)
        LkLblForgotPassword.TabIndex = 6
        LkLblForgotPassword.TabStop = True
        LkLblForgotPassword.Text = "Forgot your password?"
        ' 
        ' lkLblRequestAccess
        ' 
        lkLblRequestAccess.AutoSize = True
        lkLblRequestAccess.Location = New Point(419, 356)
        lkLblRequestAccess.Name = "lkLblRequestAccess"
        lkLblRequestAccess.Size = New Size(108, 20)
        lkLblRequestAccess.TabIndex = 7
        lkLblRequestAccess.TabStop = True
        lkLblRequestAccess.Text = "Request access"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.login
        PictureBox1.Location = New Point(27, 145)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(210, 230)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 36F)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(267, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(281, 81)
        Label3.TabIndex = 9
        Label3.Text = "Welcome"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(lkLblRequestAccess)
        Controls.Add(LkLblForgotPassword)
        Controls.Add(btnLogin)
        Controls.Add(btnCancel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents LkLblForgotPassword As LinkLabel
    Friend WithEvents lkLblRequestAccess As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
