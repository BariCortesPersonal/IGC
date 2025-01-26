<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactions
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
        gpTransaction = New GroupBox()
        btnSave = New Button()
        btnCalculate = New Button()
        btnClear = New Button()
        dtpTransactionDate = New DateTimePicker()
        lblTransactionDate = New Label()
        cmbProvider = New ComboBox()
        lblCurrency_T = New Label()
        lblProvider_T = New Label()
        cmbCurrency = New ComboBox()
        lblTransactionID = New Label()
        txtTransactionID = New TextBox()
        txtTotalTranches = New TextBox()
        Label1 = New Label()
        txtNet = New TextBox()
        Label12 = New Label()
        txtGas = New TextBox()
        Label13 = New Label()
        txtGross = New TextBox()
        Label14 = New Label()
        gvPendingTransactions = New DataGridView()
        gpTransaction.SuspendLayout()
        CType(gvPendingTransactions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gpTransaction
        ' 
        gpTransaction.BackColor = Color.Lavender
        gpTransaction.Controls.Add(btnSave)
        gpTransaction.Controls.Add(btnCalculate)
        gpTransaction.Controls.Add(btnClear)
        gpTransaction.Controls.Add(dtpTransactionDate)
        gpTransaction.Controls.Add(lblTransactionDate)
        gpTransaction.Controls.Add(cmbProvider)
        gpTransaction.Controls.Add(lblCurrency_T)
        gpTransaction.Controls.Add(lblProvider_T)
        gpTransaction.Controls.Add(cmbCurrency)
        gpTransaction.Controls.Add(lblTransactionID)
        gpTransaction.Controls.Add(txtTransactionID)
        gpTransaction.Controls.Add(txtTotalTranches)
        gpTransaction.Controls.Add(Label1)
        gpTransaction.Controls.Add(txtNet)
        gpTransaction.Controls.Add(Label12)
        gpTransaction.Controls.Add(txtGas)
        gpTransaction.Controls.Add(Label13)
        gpTransaction.Controls.Add(txtGross)
        gpTransaction.Controls.Add(Label14)
        gpTransaction.Location = New Point(16, 32)
        gpTransaction.Margin = New Padding(2, 1, 2, 1)
        gpTransaction.Name = "gpTransaction"
        gpTransaction.Padding = New Padding(2, 1, 2, 1)
        gpTransaction.Size = New Size(1396, 250)
        gpTransaction.TabIndex = 22
        gpTransaction.TabStop = False
        gpTransaction.Text = "  Pending Transaction"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(1231, 135)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(152, 44)
        btnSave.TabIndex = 37
        btnSave.Text = "Close Transaction"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(1231, 78)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(152, 44)
        btnCalculate.TabIndex = 36
        btnCalculate.Text = "Re-Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1231, 20)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(152, 44)
        btnClear.TabIndex = 35
        btnClear.Text = "Clear Data"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dtpTransactionDate
        ' 
        dtpTransactionDate.CalendarFont = New Font("Segoe UI", 12F)
        dtpTransactionDate.CalendarTitleBackColor = SystemColors.ActiveCaptionText
        dtpTransactionDate.CalendarTitleForeColor = SystemColors.ActiveCaption
        dtpTransactionDate.DropDownAlign = LeftRightAlignment.Right
        dtpTransactionDate.Font = New Font("Segoe UI", 12F)
        dtpTransactionDate.Format = DateTimePickerFormat.Short
        dtpTransactionDate.Location = New Point(670, 122)
        dtpTransactionDate.Margin = New Padding(2, 1, 2, 1)
        dtpTransactionDate.Name = "dtpTransactionDate"
        dtpTransactionDate.Size = New Size(289, 34)
        dtpTransactionDate.TabIndex = 34
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 10.125F)
        lblTransactionDate.Location = New Point(502, 125)
        lblTransactionDate.Margin = New Padding(2, 0, 2, 0)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(142, 23)
        lblTransactionDate.TabIndex = 33
        lblTransactionDate.Text = "Transaction Date:"
        ' 
        ' cmbProvider
        ' 
        cmbProvider.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProvider.FormattingEnabled = True
        cmbProvider.ItemHeight = 20
        cmbProvider.Location = New Point(137, 84)
        cmbProvider.Name = "cmbProvider"
        cmbProvider.Size = New Size(338, 28)
        cmbProvider.TabIndex = 32
        ' 
        ' lblCurrency_T
        ' 
        lblCurrency_T.AutoSize = True
        lblCurrency_T.Font = New Font("Segoe UI", 10.125F)
        lblCurrency_T.Location = New Point(13, 125)
        lblCurrency_T.Margin = New Padding(2, 0, 2, 0)
        lblCurrency_T.Name = "lblCurrency_T"
        lblCurrency_T.Size = New Size(82, 23)
        lblCurrency_T.TabIndex = 31
        lblCurrency_T.Text = "Currency:"
        ' 
        ' lblProvider_T
        ' 
        lblProvider_T.AutoSize = True
        lblProvider_T.Font = New Font("Segoe UI", 10.125F)
        lblProvider_T.Location = New Point(13, 87)
        lblProvider_T.Margin = New Padding(2, 0, 2, 0)
        lblProvider_T.Name = "lblProvider_T"
        lblProvider_T.Size = New Size(77, 23)
        lblProvider_T.TabIndex = 30
        lblProvider_T.Text = "Provider:"
        ' 
        ' cmbCurrency
        ' 
        cmbCurrency.BackColor = SystemColors.HighlightText
        cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency.FlatStyle = FlatStyle.System
        cmbCurrency.Font = New Font("Segoe UI", 10.125F)
        cmbCurrency.FormattingEnabled = True
        cmbCurrency.ItemHeight = 23
        cmbCurrency.Location = New Point(137, 125)
        cmbCurrency.Margin = New Padding(2, 1, 2, 1)
        cmbCurrency.Name = "cmbCurrency"
        cmbCurrency.Size = New Size(338, 31)
        cmbCurrency.TabIndex = 29
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        lblTransactionID.Font = New Font("Segoe UI", 10.125F)
        lblTransactionID.Location = New Point(13, 50)
        lblTransactionID.Margin = New Padding(2, 0, 2, 0)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(118, 23)
        lblTransactionID.TabIndex = 28
        lblTransactionID.Text = "TransactionID:"
        ' 
        ' txtTransactionID
        ' 
        txtTransactionID.BackColor = SystemColors.HighlightText
        txtTransactionID.BorderStyle = BorderStyle.FixedSingle
        txtTransactionID.Font = New Font("Segoe UI", 10.125F)
        txtTransactionID.Location = New Point(137, 46)
        txtTransactionID.Margin = New Padding(2, 1, 2, 1)
        txtTransactionID.Name = "txtTransactionID"
        txtTransactionID.ReadOnly = True
        txtTransactionID.Size = New Size(338, 30)
        txtTransactionID.TabIndex = 1
        txtTransactionID.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTotalTranches
        ' 
        txtTotalTranches.BorderStyle = BorderStyle.FixedSingle
        txtTotalTranches.Location = New Point(137, 206)
        txtTotalTranches.Name = "txtTotalTranches"
        txtTotalTranches.Size = New Size(102, 27)
        txtTotalTranches.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 20)
        Label1.TabIndex = 25
        Label1.Text = "Total Tranches:"
        ' 
        ' txtNet
        ' 
        txtNet.BackColor = SystemColors.HighlightText
        txtNet.BorderStyle = BorderStyle.FixedSingle
        txtNet.Font = New Font("Segoe UI", 10.125F)
        txtNet.Location = New Point(964, 204)
        txtNet.Margin = New Padding(2, 1, 2, 1)
        txtNet.Name = "txtNet"
        txtNet.Size = New Size(250, 30)
        txtNet.TabIndex = 7
        txtNet.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(823, 207)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(131, 20)
        Label12.TabIndex = 23
        Label12.Text = "Net Disbursement:"
        ' 
        ' txtGas
        ' 
        txtGas.BackColor = SystemColors.HighlightText
        txtGas.BorderStyle = BorderStyle.FixedSingle
        txtGas.Font = New Font("Segoe UI", 10.125F)
        txtGas.Location = New Point(717, 205)
        txtGas.Margin = New Padding(2, 1, 2, 1)
        txtGas.Name = "txtGas"
        txtGas.Size = New Size(97, 30)
        txtGas.TabIndex = 6
        txtGas.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(644, 209)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(63, 20)
        Label13.TabIndex = 21
        Label13.Text = "Gas Fee:"
        ' 
        ' txtGross
        ' 
        txtGross.BackColor = SystemColors.HighlightText
        txtGross.BorderStyle = BorderStyle.FixedSingle
        txtGross.Font = New Font("Segoe UI", 10.125F)
        txtGross.Location = New Point(399, 206)
        txtGross.Margin = New Padding(2, 1, 2, 1)
        txtGross.Name = "txtGross"
        txtGross.Size = New Size(234, 30)
        txtGross.TabIndex = 5
        txtGross.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(251, 208)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(143, 20)
        Label14.TabIndex = 19
        Label14.Text = "Gross Disbursement:"
        ' 
        ' gvPendingTransactions
        ' 
        gvPendingTransactions.BackgroundColor = Color.White
        gvPendingTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gvPendingTransactions.Location = New Point(16, 301)
        gvPendingTransactions.Name = "gvPendingTransactions"
        gvPendingTransactions.RowHeadersWidth = 51
        gvPendingTransactions.Size = New Size(1396, 368)
        gvPendingTransactions.TabIndex = 13
        ' 
        ' frmTransactions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1428, 681)
        Controls.Add(gvPendingTransactions)
        Controls.Add(gpTransaction)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmTransactions"
        Text = "Transactions"
        gpTransaction.ResumeLayout(False)
        gpTransaction.PerformLayout()
        CType(gvPendingTransactions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gpTransaction As GroupBox
    Friend WithEvents txtNet As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtGas As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtGross As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents gvPendingTransactions As DataGridView
    Friend WithEvents txtTotalTranches As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents txtTransactionID As TextBox
    Friend WithEvents cmbProvider As ComboBox
    Friend WithEvents lblCurrency_T As Label
    Friend WithEvents lblProvider_T As Label
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents dtpTransactionDate As DateTimePicker
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
