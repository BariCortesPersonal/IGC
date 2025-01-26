<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagements
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
        dgvUsers = New DataGridView()
        bdUserManagements = New GroupBox()
        btnUpdateUser = New Button()
        Button2 = New Button()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        dtpEndDate = New DateTimePicker()
        dtpStartDate = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        TextBox9 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        TextBox7 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        bdUserManagements.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvUsers
        ' 
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Location = New Point(12, 520)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.Size = New Size(995, 613)
        dgvUsers.TabIndex = 0
        ' 
        ' bdUserManagements
        ' 
        bdUserManagements.BackColor = Color.Lavender
        bdUserManagements.Controls.Add(btnUpdateUser)
        bdUserManagements.Controls.Add(Button2)
        bdUserManagements.Controls.Add(Button1)
        bdUserManagements.Controls.Add(CheckBox1)
        bdUserManagements.Controls.Add(dtpEndDate)
        bdUserManagements.Controls.Add(dtpStartDate)
        bdUserManagements.Controls.Add(ComboBox1)
        bdUserManagements.Controls.Add(Label9)
        bdUserManagements.Controls.Add(TextBox9)
        bdUserManagements.Controls.Add(Label8)
        bdUserManagements.Controls.Add(Label7)
        bdUserManagements.Controls.Add(TextBox7)
        bdUserManagements.Controls.Add(Label6)
        bdUserManagements.Controls.Add(Label5)
        bdUserManagements.Controls.Add(Label4)
        bdUserManagements.Controls.Add(TextBox4)
        bdUserManagements.Controls.Add(Label3)
        bdUserManagements.Controls.Add(TextBox3)
        bdUserManagements.Controls.Add(Label2)
        bdUserManagements.Controls.Add(TextBox2)
        bdUserManagements.Controls.Add(Label1)
        bdUserManagements.Controls.Add(TextBox1)
        bdUserManagements.Location = New Point(13, 10)
        bdUserManagements.Name = "bdUserManagements"
        bdUserManagements.Size = New Size(994, 493)
        bdUserManagements.TabIndex = 1
        bdUserManagements.TabStop = False
        bdUserManagements.Text = "Users Managements"
        ' 
        ' btnUpdateUser
        ' 
        btnUpdateUser.Location = New Point(814, 321)
        btnUpdateUser.Name = "btnUpdateUser"
        btnUpdateUser.Size = New Size(157, 36)
        btnUpdateUser.TabIndex = 24
        btnUpdateUser.Text = "Update User"
        btnUpdateUser.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(814, 372)
        Button2.Name = "Button2"
        Button2.Size = New Size(157, 36)
        Button2.TabIndex = 23
        Button2.Text = "Enabled User"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(814, 423)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 36)
        Button1.TabIndex = 22
        Button1.Text = "Desable User"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(536, 433)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 21
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Location = New Point(266, 431)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(250, 27)
        dtpEndDate.TabIndex = 20
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Location = New Point(266, 385)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(250, 27)
        dtpStartDate.TabIndex = 19
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(266, 342)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(315, 28)
        ComboBox1.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(42, 260)
        Label9.Name = "Label9"
        Label9.Size = New Size(168, 20)
        Label9.TabIndex = 17
        Label9.Text = " Second Phone Number:"
        ' 
        ' TextBox9
        ' 
        TextBox9.BorderStyle = BorderStyle.FixedSingle
        TextBox9.Location = New Point(266, 257)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(317, 27)
        TextBox9.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(42, 434)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 20)
        Label8.TabIndex = 15
        Label8.Text = " End Date:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(42, 214)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 20)
        Label7.TabIndex = 13
        Label7.Text = " Phone Number:"
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Location = New Point(266, 211)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(317, 27)
        TextBox7.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(42, 390)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 20)
        Label6.TabIndex = 11
        Label6.Text = " Start Date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 347)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 9
        Label5.Text = " Roll:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 304)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 7
        Label4.Text = " User ID:"
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(266, 301)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(317, 27)
        TextBox4.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 5
        Label3.Text = " Email:"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(266, 165)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(317, 27)
        TextBox3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 3
        Label2.Text = " Lasr Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(266, 126)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(317, 27)
        TextBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 1
        Label1.Text = " First Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(266, 82)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(317, 27)
        TextBox1.TabIndex = 0
        ' 
        ' frmUserManagements
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1410, 1157)
        Controls.Add(bdUserManagements)
        Controls.Add(dgvUsers)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmUserManagements"
        Text = "frmUserManagements"
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        bdUserManagements.ResumeLayout(False)
        bdUserManagements.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents bdUserManagements As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents btnUpdateUser As Button
End Class
