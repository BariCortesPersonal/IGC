<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCommission
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
        gbComissions = New GroupBox()
        cmbAgent = New ComboBox()
        cmbCurrency = New ComboBox()
        btnSave = New Button()
        btnCalculate = New Button()
        btnClear = New Button()
        dtpCommissionDate = New DateTimePicker()
        Label7 = New Label()
        lblNumberOfBTC = New Label()
        lblFinalSwapTranchePrice = New Label()
        lblTransactionDate = New Label()
        Label3 = New Label()
        lblProvider_T = New Label()
        Label1 = New Label()
        txtCommissionNet = New TextBox()
        txtCommissionGas = New TextBox()
        txtCommissionGross = New TextBox()
        txtCommissionID = New TextBox()
        dgvCommissions = New DataGridView()
        gbComissions.SuspendLayout()
        CType(dgvCommissions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbComissions
        ' 
        gbComissions.BackColor = Color.Lavender
        gbComissions.Controls.Add(cmbAgent)
        gbComissions.Controls.Add(cmbCurrency)
        gbComissions.Controls.Add(btnSave)
        gbComissions.Controls.Add(btnCalculate)
        gbComissions.Controls.Add(btnClear)
        gbComissions.Controls.Add(dtpCommissionDate)
        gbComissions.Controls.Add(Label7)
        gbComissions.Controls.Add(lblNumberOfBTC)
        gbComissions.Controls.Add(lblFinalSwapTranchePrice)
        gbComissions.Controls.Add(lblTransactionDate)
        gbComissions.Controls.Add(Label3)
        gbComissions.Controls.Add(lblProvider_T)
        gbComissions.Controls.Add(Label1)
        gbComissions.Controls.Add(txtCommissionNet)
        gbComissions.Controls.Add(txtCommissionGas)
        gbComissions.Controls.Add(txtCommissionGross)
        gbComissions.Controls.Add(txtCommissionID)
        gbComissions.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        gbComissions.Location = New Point(4, 14)
        gbComissions.Margin = New Padding(2, 1, 2, 1)
        gbComissions.Name = "gbComissions"
        gbComissions.Padding = New Padding(2, 1, 2, 1)
        gbComissions.Size = New Size(999, 369)
        gbComissions.TabIndex = 4
        gbComissions.TabStop = False
        gbComissions.Tag = ""
        gbComissions.Text = "Commissions"
        ' 
        ' cmbAgent
        ' 
        cmbAgent.FormattingEnabled = True
        cmbAgent.Location = New Point(333, 102)
        cmbAgent.Name = "cmbAgent"
        cmbAgent.Size = New Size(338, 36)
        cmbAgent.TabIndex = 2
        ' 
        ' cmbCurrency
        ' 
        cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency.FlatStyle = FlatStyle.System
        cmbCurrency.FormattingEnabled = True
        cmbCurrency.Location = New Point(333, 143)
        cmbCurrency.Name = "cmbCurrency"
        cmbCurrency.Size = New Size(338, 36)
        cmbCurrency.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        btnSave.Location = New Point(823, 305)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(152, 44)
        btnSave.TabIndex = 17
        btnSave.Text = "Save Commission"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        btnCalculate.Location = New Point(823, 248)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(152, 44)
        btnCalculate.TabIndex = 16
        btnCalculate.Text = "Re-Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        btnClear.Location = New Point(823, 190)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(152, 44)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear Data"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dtpCommissionDate
        ' 
        dtpCommissionDate.CalendarFont = New Font("Segoe UI", 12F)
        dtpCommissionDate.Font = New Font("Segoe UI", 12F)
        dtpCommissionDate.Format = DateTimePickerFormat.Custom
        dtpCommissionDate.Location = New Point(333, 189)
        dtpCommissionDate.Margin = New Padding(2, 1, 2, 1)
        dtpCommissionDate.Name = "dtpCommissionDate"
        dtpCommissionDate.Size = New Size(338, 34)
        dtpCommissionDate.TabIndex = 4
        dtpCommissionDate.Value = New Date(2024, 12, 14, 14, 10, 24, 0)
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label7.Location = New Point(35, 322)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(219, 23)
        Label7.TabIndex = 13
        Label7.Text = "Net DisbursEments Amount:"
        ' 
        ' lblNumberOfBTC
        ' 
        lblNumberOfBTC.AutoSize = True
        lblNumberOfBTC.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblNumberOfBTC.Location = New Point(35, 280)
        lblNumberOfBTC.Margin = New Padding(2, 0, 2, 0)
        lblNumberOfBTC.Name = "lblNumberOfBTC"
        lblNumberOfBTC.Size = New Size(71, 23)
        lblNumberOfBTC.TabIndex = 12
        lblNumberOfBTC.Text = "Gas Fee:"
        ' 
        ' lblFinalSwapTranchePrice
        ' 
        lblFinalSwapTranchePrice.AutoSize = True
        lblFinalSwapTranchePrice.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblFinalSwapTranchePrice.Location = New Point(35, 237)
        lblFinalSwapTranchePrice.Margin = New Padding(2, 0, 2, 0)
        lblFinalSwapTranchePrice.Name = "lblFinalSwapTranchePrice"
        lblFinalSwapTranchePrice.Size = New Size(233, 23)
        lblFinalSwapTranchePrice.TabIndex = 11
        lblFinalSwapTranchePrice.Text = "Gross DisbursEments Amount:"
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblTransactionDate.Location = New Point(35, 196)
        lblTransactionDate.Margin = New Padding(2, 0, 2, 0)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(140, 23)
        lblTransactionDate.TabIndex = 10
        lblTransactionDate.Text = "Transaction Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label3.Location = New Point(35, 146)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 23)
        Label3.TabIndex = 9
        Label3.Text = "Currency:"
        ' 
        ' lblProvider_T
        ' 
        lblProvider_T.AutoSize = True
        lblProvider_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblProvider_T.Location = New Point(35, 108)
        lblProvider_T.Margin = New Padding(2, 0, 2, 0)
        lblProvider_T.Name = "lblProvider_T"
        lblProvider_T.Size = New Size(58, 23)
        lblProvider_T.TabIndex = 8
        lblProvider_T.Text = "Agent:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label1.Location = New Point(35, 66)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 23)
        Label1.TabIndex = 7
        Label1.Text = "CommissionID:"
        ' 
        ' txtCommissionNet
        ' 
        txtCommissionNet.BackColor = SystemColors.HighlightText
        txtCommissionNet.BorderStyle = BorderStyle.FixedSingle
        txtCommissionNet.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        txtCommissionNet.Location = New Point(331, 316)
        txtCommissionNet.Margin = New Padding(2, 1, 2, 1)
        txtCommissionNet.Name = "txtCommissionNet"
        txtCommissionNet.Size = New Size(338, 30)
        txtCommissionNet.TabIndex = 7
        txtCommissionNet.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtCommissionGas
        ' 
        txtCommissionGas.BackColor = SystemColors.HighlightText
        txtCommissionGas.BorderStyle = BorderStyle.FixedSingle
        txtCommissionGas.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        txtCommissionGas.Location = New Point(470, 273)
        txtCommissionGas.Margin = New Padding(2, 1, 2, 1)
        txtCommissionGas.Name = "txtCommissionGas"
        txtCommissionGas.Size = New Size(200, 30)
        txtCommissionGas.TabIndex = 6
        txtCommissionGas.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtCommissionGross
        ' 
        txtCommissionGross.BackColor = SystemColors.HighlightText
        txtCommissionGross.BorderStyle = BorderStyle.FixedSingle
        txtCommissionGross.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        txtCommissionGross.Location = New Point(333, 232)
        txtCommissionGross.Margin = New Padding(2, 1, 2, 1)
        txtCommissionGross.Name = "txtCommissionGross"
        txtCommissionGross.Size = New Size(337, 30)
        txtCommissionGross.TabIndex = 5
        txtCommissionGross.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtCommissionID
        ' 
        txtCommissionID.BackColor = SystemColors.HighlightText
        txtCommissionID.BorderStyle = BorderStyle.FixedSingle
        txtCommissionID.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtCommissionID.Location = New Point(333, 59)
        txtCommissionID.Margin = New Padding(2, 1, 2, 1)
        txtCommissionID.Name = "txtCommissionID"
        txtCommissionID.ReadOnly = True
        txtCommissionID.Size = New Size(338, 30)
        txtCommissionID.TabIndex = 1
        txtCommissionID.TextAlign = HorizontalAlignment.Right
        ' 
        ' dgvCommissions
        ' 
        dgvCommissions.BackgroundColor = SystemColors.ControlLightLight
        dgvCommissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCommissions.Location = New Point(8, 395)
        dgvCommissions.Name = "dgvCommissions"
        dgvCommissions.RowHeadersWidth = 51
        dgvCommissions.Size = New Size(995, 678)
        dgvCommissions.TabIndex = 5
        ' 
        ' NewCommission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1088, 1128)
        Controls.Add(dgvCommissions)
        Controls.Add(gbComissions)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewCommission"
        ShowIcon = False
        Text = "NewCommission"
        gbComissions.ResumeLayout(False)
        gbComissions.PerformLayout()
        CType(dgvCommissions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbComissions As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNumberOfBTC As Label
    Friend WithEvents lblFinalSwapTranchePrice As Label
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblProvider_T As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCommissionNet As TextBox
    Friend WithEvents txtCommissionGas As TextBox
    Friend WithEvents txtCommissionGross As TextBox
    Friend WithEvents txtCommissionID As TextBox
    Friend WithEvents dgvCommissions As DataGridView
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents cmbAgent As ComboBox
    Friend WithEvents dtpCommissionDate As DateTimePicker
End Class
