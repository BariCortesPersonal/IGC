<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProviders
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
        Panel1 = New Panel()
        pnProviders = New Panel()
        Label11 = New Label()
        dgvProvider = New DataGridView()
        pnProviderDetails = New Panel()
        dtpEnd = New DateTimePicker()
        dtpStart = New DateTimePicker()
        Label9 = New Label()
        Label5 = New Label()
        btnClear = New Button()
        btnDeleteProvider = New Button()
        btnAddProvider = New Button()
        mtxtPhone2 = New MaskedTextBox()
        mtxtPhone = New MaskedTextBox()
        Label10 = New Label()
        Label6 = New Label()
        txtRate = New TextBox()
        Label7 = New Label()
        txtEmail = New TextBox()
        Label8 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtLast_Name = New TextBox()
        Label2 = New Label()
        txtFist_Name = New TextBox()
        Label1 = New Label()
        txtProvider_ID = New TextBox()
        Panel1.SuspendLayout()
        pnProviders.SuspendLayout()
        CType(dgvProvider, ComponentModel.ISupportInitialize).BeginInit()
        pnProviderDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lavender
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(pnProviders)
        Panel1.Location = New Point(19, 485)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1033, 647)
        Panel1.TabIndex = 0
        ' 
        ' pnProviders
        ' 
        pnProviders.BackColor = Color.White
        pnProviders.BorderStyle = BorderStyle.FixedSingle
        pnProviders.Controls.Add(Label11)
        pnProviders.Controls.Add(dgvProvider)
        pnProviders.Location = New Point(4, 5)
        pnProviders.Name = "pnProviders"
        pnProviders.Padding = New Padding(2)
        pnProviders.Size = New Size(1022, 634)
        pnProviders.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(20, 22)
        Label11.Name = "Label11"
        Label11.Size = New Size(122, 28)
        Label11.TabIndex = 1
        Label11.Text = "Provider List:"
        ' 
        ' dgvProvider
        ' 
        dgvProvider.BackgroundColor = Color.White
        dgvProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProvider.Location = New Point(18, 76)
        dgvProvider.Name = "dgvProvider"
        dgvProvider.RowHeadersWidth = 51
        dgvProvider.Size = New Size(987, 539)
        dgvProvider.TabIndex = 0
        ' 
        ' pnProviderDetails
        ' 
        pnProviderDetails.BackColor = Color.Lavender
        pnProviderDetails.BorderStyle = BorderStyle.FixedSingle
        pnProviderDetails.Controls.Add(dtpEnd)
        pnProviderDetails.Controls.Add(dtpStart)
        pnProviderDetails.Controls.Add(Label9)
        pnProviderDetails.Controls.Add(Label5)
        pnProviderDetails.Controls.Add(btnClear)
        pnProviderDetails.Controls.Add(btnDeleteProvider)
        pnProviderDetails.Controls.Add(btnAddProvider)
        pnProviderDetails.Controls.Add(mtxtPhone2)
        pnProviderDetails.Controls.Add(mtxtPhone)
        pnProviderDetails.Controls.Add(Label10)
        pnProviderDetails.Controls.Add(Label6)
        pnProviderDetails.Controls.Add(txtRate)
        pnProviderDetails.Controls.Add(Label7)
        pnProviderDetails.Controls.Add(txtEmail)
        pnProviderDetails.Controls.Add(Label8)
        pnProviderDetails.Controls.Add(Label4)
        pnProviderDetails.Controls.Add(Label3)
        pnProviderDetails.Controls.Add(txtLast_Name)
        pnProviderDetails.Controls.Add(Label2)
        pnProviderDetails.Controls.Add(txtFist_Name)
        pnProviderDetails.Controls.Add(Label1)
        pnProviderDetails.Controls.Add(txtProvider_ID)
        pnProviderDetails.Location = New Point(19, 28)
        pnProviderDetails.Name = "pnProviderDetails"
        pnProviderDetails.Size = New Size(1025, 446)
        pnProviderDetails.TabIndex = 1
        ' 
        ' dtpEnd
        ' 
        dtpEnd.CalendarFont = New Font("Segoe UI", 12F)
        dtpEnd.CalendarForeColor = Color.Black
        dtpEnd.CalendarTitleBackColor = SystemColors.ActiveCaptionText
        dtpEnd.CalendarTitleForeColor = SystemColors.ActiveCaption
        dtpEnd.DropDownAlign = LeftRightAlignment.Right
        dtpEnd.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpEnd.Format = DateTimePickerFormat.Short
        dtpEnd.Location = New Point(768, 193)
        dtpEnd.Margin = New Padding(2, 1, 2, 1)
        dtpEnd.Name = "dtpEnd"
        dtpEnd.Size = New Size(217, 30)
        dtpEnd.TabIndex = 27
        ' 
        ' dtpStart
        ' 
        dtpStart.CalendarFont = New Font("Segoe UI", 12F)
        dtpStart.CalendarForeColor = Color.Black
        dtpStart.CalendarTitleBackColor = SystemColors.ActiveCaptionText
        dtpStart.CalendarTitleForeColor = SystemColors.ActiveCaption
        dtpStart.DropDownAlign = LeftRightAlignment.Right
        dtpStart.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpStart.Format = DateTimePickerFormat.Short
        dtpStart.Location = New Point(768, 149)
        dtpStart.Margin = New Padding(2, 1, 2, 1)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(217, 30)
        dtpStart.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label9.Location = New Point(595, 200)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 23)
        Label9.TabIndex = 25
        Label9.Text = "Contract End :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label5.Location = New Point(595, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 23)
        Label5.TabIndex = 24
        Label5.Text = "Contract Start:"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(823, 337)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(162, 38)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear Data"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteProvider
        ' 
        btnDeleteProvider.ForeColor = Color.Red
        btnDeleteProvider.Location = New Point(823, 386)
        btnDeleteProvider.Name = "btnDeleteProvider"
        btnDeleteProvider.Size = New Size(162, 38)
        btnDeleteProvider.TabIndex = 21
        btnDeleteProvider.Text = "Delete Provider"
        btnDeleteProvider.UseVisualStyleBackColor = True
        ' 
        ' btnAddProvider
        ' 
        btnAddProvider.Location = New Point(823, 290)
        btnAddProvider.Name = "btnAddProvider"
        btnAddProvider.Size = New Size(162, 38)
        btnAddProvider.TabIndex = 20
        btnAddProvider.Text = "Add/Update"
        btnAddProvider.UseVisualStyleBackColor = True
        ' 
        ' mtxtPhone2
        ' 
        mtxtPhone2.BorderStyle = BorderStyle.FixedSingle
        mtxtPhone2.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        mtxtPhone2.Location = New Point(387, 290)
        mtxtPhone2.Mask = "000-000-0000"
        mtxtPhone2.Name = "mtxtPhone2"
        mtxtPhone2.Size = New Size(149, 27)
        mtxtPhone2.TabIndex = 19
        mtxtPhone2.TextAlign = HorizontalAlignment.Right
        ' 
        ' mtxtPhone
        ' 
        mtxtPhone.BorderStyle = BorderStyle.FixedSingle
        mtxtPhone.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        mtxtPhone.Location = New Point(387, 243)
        mtxtPhone.Mask = "000-000-0000"
        mtxtPhone.Name = "mtxtPhone"
        mtxtPhone.Size = New Size(149, 27)
        mtxtPhone.TabIndex = 18
        mtxtPhone.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(12, 6)
        Label10.Name = "Label10"
        Label10.Size = New Size(148, 25)
        Label10.TabIndex = 17
        Label10.Text = "Providers Details:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label6.Location = New Point(81, 388)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 23)
        Label6.TabIndex = 13
        Label6.Text = "Rate:"
        ' 
        ' txtRate
        ' 
        txtRate.BorderStyle = BorderStyle.FixedSingle
        txtRate.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        txtRate.Location = New Point(387, 385)
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(149, 27)
        txtRate.TabIndex = 12
        txtRate.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label7.Location = New Point(81, 343)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 23)
        Label7.TabIndex = 11
        Label7.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        txtEmail.Location = New Point(245, 340)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(291, 27)
        txtEmail.TabIndex = 10
        txtEmail.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Lavender
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label8.Location = New Point(81, 297)
        Label8.Name = "Label8"
        Label8.Size = New Size(141, 23)
        Label8.TabIndex = 9
        Label8.Text = "Secondary_Phone:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label4.Location = New Point(81, 250)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 23)
        Label4.TabIndex = 7
        Label4.Text = "Phone:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label3.Location = New Point(81, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 23)
        Label3.TabIndex = 5
        Label3.Text = "Last_Name"
        ' 
        ' txtLast_Name
        ' 
        txtLast_Name.BorderStyle = BorderStyle.FixedSingle
        txtLast_Name.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        txtLast_Name.Location = New Point(245, 201)
        txtLast_Name.Name = "txtLast_Name"
        txtLast_Name.Size = New Size(291, 27)
        txtLast_Name.TabIndex = 4
        txtLast_Name.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label2.Location = New Point(81, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 23)
        Label2.TabIndex = 3
        Label2.Text = "Fist_Name:"
        ' 
        ' txtFist_Name
        ' 
        txtFist_Name.BorderStyle = BorderStyle.FixedSingle
        txtFist_Name.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        txtFist_Name.Location = New Point(245, 156)
        txtFist_Name.Name = "txtFist_Name"
        txtFist_Name.Size = New Size(291, 27)
        txtFist_Name.TabIndex = 2
        txtFist_Name.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label1.Location = New Point(81, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 23)
        Label1.TabIndex = 1
        Label1.Text = "Provider_ID:"
        ' 
        ' txtProvider_ID
        ' 
        txtProvider_ID.BorderStyle = BorderStyle.FixedSingle
        txtProvider_ID.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        txtProvider_ID.Location = New Point(245, 82)
        txtProvider_ID.Name = "txtProvider_ID"
        txtProvider_ID.Size = New Size(291, 27)
        txtProvider_ID.TabIndex = 0
        txtProvider_ID.TextAlign = HorizontalAlignment.Right
        ' 
        ' frmProviders
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(1129, 1222)
        Controls.Add(pnProviderDetails)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmProviders"
        Text = "frmProviders"
        Panel1.ResumeLayout(False)
        pnProviders.ResumeLayout(False)
        pnProviders.PerformLayout()
        CType(dgvProvider, ComponentModel.ISupportInitialize).EndInit()
        pnProviderDetails.ResumeLayout(False)
        pnProviderDetails.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnProviders As Panel
    Friend WithEvents dgvProvider As DataGridView
    Friend WithEvents pnProviderDetails As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFist_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProvider_ID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLast_Name As TextBox
    Friend WithEvents mtxtPhone As MaskedTextBox
    Friend WithEvents mtxtPhone2 As MaskedTextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDeleteProvider As Button
    Friend WithEvents btnAddProvider As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Label11 As Label
End Class
