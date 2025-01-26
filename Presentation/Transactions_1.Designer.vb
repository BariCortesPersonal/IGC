<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactions_1
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        btnNewCurrency = New Button()
        cmbProvider_T = New ComboBox()
        btnSave = New Button()
        btnCalculate = New Button()
        btnClear = New Button()
        dtpTransactionDate_T = New DateTimePicker()
        lblTranches = New Label()
        lblNumberOfBTC = New Label()
        lblFinalSwapTranchePrice = New Label()
        lblTransactionDate = New Label()
        lblCurrency_T = New Label()
        lblProvider_T = New Label()
        lblTransactionID = New Label()
        txtTranchesExecute_T = New TextBox()
        txtumberofBTC_T = New TextBox()
        txtFinalSwapTranchePrice_T = New TextBox()
        txtTransactionID_T = New TextBox()
        cmbCurrency_T = New ComboBox()
        tcTransactionsDetails = New TabControl()
        tpTransactions = New TabPage()
        tpCommissions = New TabPage()
        gbCommissions = New GroupBox()
        Label9 = New Label()
        chbGassFee_C = New CheckBox()
        Button1 = New Button()
        btnClear_C = New Button()
        Button3 = New Button()
        Label4 = New Label()
        cmbCurrency_C = New ComboBox()
        cmbAgent_C = New ComboBox()
        Label5 = New Label()
        txtNet_C = New TextBox()
        Label6 = New Label()
        txtGass_C = New TextBox()
        lblGass_C = New Label()
        txtGrossD_C = New TextBox()
        Label8 = New Label()
        dgvCommissions = New DataGridView()
        dgvTransactionLine = New DataGridView()
        Label19 = New Label()
        txtGrossD = New TextBox()
        lblGass_T = New Label()
        txtGas = New TextBox()
        Label17 = New Label()
        txtNet = New TextBox()
        Label1 = New Label()
        cmbProvider_L = New ComboBox()
        cmbCurrency_L = New ComboBox()
        Label2 = New Label()
        btnCalculateLine = New Button()
        btnClearLine = New Button()
        btnCreateLine = New Button()
        Label3 = New Label()
        chbGassFee = New CheckBox()
        PanelTransactionLines = New Panel()
        GroupBox1.SuspendLayout()
        tcTransactionsDetails.SuspendLayout()
        tpTransactions.SuspendLayout()
        tpCommissions.SuspendLayout()
        gbCommissions.SuspendLayout()
        CType(dgvCommissions, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTransactionLine, ComponentModel.ISupportInitialize).BeginInit()
        PanelTransactionLines.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnNewCurrency)
        GroupBox1.Controls.Add(cmbProvider_T)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(btnCalculate)
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(dtpTransactionDate_T)
        GroupBox1.Controls.Add(lblTranches)
        GroupBox1.Controls.Add(lblNumberOfBTC)
        GroupBox1.Controls.Add(lblFinalSwapTranchePrice)
        GroupBox1.Controls.Add(lblTransactionDate)
        GroupBox1.Controls.Add(lblCurrency_T)
        GroupBox1.Controls.Add(lblProvider_T)
        GroupBox1.Controls.Add(lblTransactionID)
        GroupBox1.Controls.Add(txtTranchesExecute_T)
        GroupBox1.Controls.Add(txtumberofBTC_T)
        GroupBox1.Controls.Add(txtFinalSwapTranchePrice_T)
        GroupBox1.Controls.Add(txtTransactionID_T)
        GroupBox1.Controls.Add(cmbCurrency_T)
        GroupBox1.Location = New Point(12, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1035, 432)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Transaction"
        ' 
        ' btnNewCurrency
        ' 
        btnNewCurrency.Location = New Point(682, 188)
        btnNewCurrency.Name = "btnNewCurrency"
        btnNewCurrency.Size = New Size(30, 35)
        btnNewCurrency.TabIndex = 37
        btnNewCurrency.Text = "+"
        btnNewCurrency.UseVisualStyleBackColor = True
        ' 
        ' cmbProvider_T
        ' 
        cmbProvider_T.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProvider_T.FormattingEnabled = True
        cmbProvider_T.Location = New Point(326, 146)
        cmbProvider_T.Name = "cmbProvider_T"
        cmbProvider_T.Size = New Size(338, 28)
        cmbProvider_T.TabIndex = 36
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(832, 366)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(178, 44)
        btnSave.TabIndex = 35
        btnSave.Text = "Create Transaction"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(832, 309)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(178, 44)
        btnCalculate.TabIndex = 34
        btnCalculate.Text = "Re-Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(832, 251)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(178, 44)
        btnClear.TabIndex = 33
        btnClear.Text = "Clear Data"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dtpTransactionDate_T
        ' 
        dtpTransactionDate_T.CalendarFont = New Font("Segoe UI", 12F)
        dtpTransactionDate_T.CalendarTitleBackColor = SystemColors.ActiveCaptionText
        dtpTransactionDate_T.CalendarTitleForeColor = SystemColors.ActiveCaption
        dtpTransactionDate_T.DropDownAlign = LeftRightAlignment.Right
        dtpTransactionDate_T.Font = New Font("Segoe UI", 12F)
        dtpTransactionDate_T.Format = DateTimePickerFormat.Short
        dtpTransactionDate_T.Location = New Point(328, 237)
        dtpTransactionDate_T.Margin = New Padding(2, 1, 2, 1)
        dtpTransactionDate_T.Name = "dtpTransactionDate_T"
        dtpTransactionDate_T.Size = New Size(336, 34)
        dtpTransactionDate_T.TabIndex = 32
        ' 
        ' lblTranches
        ' 
        lblTranches.AutoSize = True
        lblTranches.Font = New Font("Segoe UI", 10.125F)
        lblTranches.Location = New Point(31, 380)
        lblTranches.Margin = New Padding(2, 0, 2, 0)
        lblTranches.Name = "lblTranches"
        lblTranches.Size = New Size(155, 23)
        lblTranches.TabIndex = 31
        lblTranches.Text = "Tranches Executed:"
        ' 
        ' lblNumberOfBTC
        ' 
        lblNumberOfBTC.AutoSize = True
        lblNumberOfBTC.Font = New Font("Segoe UI", 10.125F)
        lblNumberOfBTC.Location = New Point(31, 336)
        lblNumberOfBTC.Margin = New Padding(2, 0, 2, 0)
        lblNumberOfBTC.Name = "lblNumberOfBTC"
        lblNumberOfBTC.Size = New Size(123, 23)
        lblNumberOfBTC.TabIndex = 30
        lblNumberOfBTC.Text = "Total Currency:"
        ' 
        ' lblFinalSwapTranchePrice
        ' 
        lblFinalSwapTranchePrice.AutoSize = True
        lblFinalSwapTranchePrice.Font = New Font("Segoe UI", 10.125F)
        lblFinalSwapTranchePrice.Location = New Point(31, 289)
        lblFinalSwapTranchePrice.Margin = New Padding(2, 0, 2, 0)
        lblFinalSwapTranchePrice.Name = "lblFinalSwapTranchePrice"
        lblFinalSwapTranchePrice.Size = New Size(201, 23)
        lblFinalSwapTranchePrice.TabIndex = 29
        lblFinalSwapTranchePrice.Text = "Final Swap Tranche Price:"
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 10.125F)
        lblTransactionDate.Location = New Point(31, 241)
        lblTransactionDate.Margin = New Padding(2, 0, 2, 0)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(142, 23)
        lblTransactionDate.TabIndex = 28
        lblTransactionDate.Text = "Transaction Date:"
        ' 
        ' lblCurrency_T
        ' 
        lblCurrency_T.AutoSize = True
        lblCurrency_T.Font = New Font("Segoe UI", 10.125F)
        lblCurrency_T.Location = New Point(31, 191)
        lblCurrency_T.Margin = New Padding(2, 0, 2, 0)
        lblCurrency_T.Name = "lblCurrency_T"
        lblCurrency_T.Size = New Size(82, 23)
        lblCurrency_T.TabIndex = 27
        lblCurrency_T.Text = "Currency:"
        ' 
        ' lblProvider_T
        ' 
        lblProvider_T.AutoSize = True
        lblProvider_T.Font = New Font("Segoe UI", 10.125F)
        lblProvider_T.Location = New Point(31, 151)
        lblProvider_T.Margin = New Padding(2, 0, 2, 0)
        lblProvider_T.Name = "lblProvider_T"
        lblProvider_T.Size = New Size(77, 23)
        lblProvider_T.TabIndex = 26
        lblProvider_T.Text = "Provider:"
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        lblTransactionID.Font = New Font("Segoe UI", 10.125F)
        lblTransactionID.Location = New Point(31, 81)
        lblTransactionID.Margin = New Padding(2, 0, 2, 0)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(118, 23)
        lblTransactionID.TabIndex = 25
        lblTransactionID.Text = "TransactionID:"
        ' 
        ' txtTranchesExecute_T
        ' 
        txtTranchesExecute_T.BackColor = SystemColors.HighlightText
        txtTranchesExecute_T.BorderStyle = BorderStyle.FixedSingle
        txtTranchesExecute_T.Font = New Font("Segoe UI", 10.125F)
        txtTranchesExecute_T.Location = New Point(326, 377)
        txtTranchesExecute_T.Margin = New Padding(2, 1, 2, 1)
        txtTranchesExecute_T.Name = "txtTranchesExecute_T"
        txtTranchesExecute_T.Size = New Size(336, 30)
        txtTranchesExecute_T.TabIndex = 24
        txtTranchesExecute_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtumberofBTC_T
        ' 
        txtumberofBTC_T.BackColor = SystemColors.HighlightText
        txtumberofBTC_T.BorderStyle = BorderStyle.FixedSingle
        txtumberofBTC_T.Font = New Font("Segoe UI", 10.125F)
        txtumberofBTC_T.Location = New Point(328, 332)
        txtumberofBTC_T.Margin = New Padding(2, 1, 2, 1)
        txtumberofBTC_T.Name = "txtumberofBTC_T"
        txtumberofBTC_T.Size = New Size(335, 30)
        txtumberofBTC_T.TabIndex = 23
        txtumberofBTC_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtFinalSwapTranchePrice_T
        ' 
        txtFinalSwapTranchePrice_T.BackColor = SystemColors.HighlightText
        txtFinalSwapTranchePrice_T.BorderStyle = BorderStyle.FixedSingle
        txtFinalSwapTranchePrice_T.Font = New Font("Segoe UI", 10.125F)
        txtFinalSwapTranchePrice_T.Location = New Point(328, 286)
        txtFinalSwapTranchePrice_T.Margin = New Padding(2, 1, 2, 1)
        txtFinalSwapTranchePrice_T.Name = "txtFinalSwapTranchePrice_T"
        txtFinalSwapTranchePrice_T.Size = New Size(335, 30)
        txtFinalSwapTranchePrice_T.TabIndex = 22
        txtFinalSwapTranchePrice_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTransactionID_T
        ' 
        txtTransactionID_T.BackColor = SystemColors.HighlightText
        txtTransactionID_T.BorderStyle = BorderStyle.FixedSingle
        txtTransactionID_T.Font = New Font("Segoe UI", 10.125F)
        txtTransactionID_T.Location = New Point(326, 79)
        txtTransactionID_T.Margin = New Padding(2, 1, 2, 1)
        txtTransactionID_T.Name = "txtTransactionID_T"
        txtTransactionID_T.ReadOnly = True
        txtTransactionID_T.Size = New Size(338, 30)
        txtTransactionID_T.TabIndex = 21
        txtTransactionID_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' cmbCurrency_T
        ' 
        cmbCurrency_T.BackColor = SystemColors.HighlightText
        cmbCurrency_T.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency_T.FlatStyle = FlatStyle.System
        cmbCurrency_T.Font = New Font("Segoe UI", 10.125F)
        cmbCurrency_T.FormattingEnabled = True
        cmbCurrency_T.Location = New Point(326, 189)
        cmbCurrency_T.Margin = New Padding(2, 1, 2, 1)
        cmbCurrency_T.Name = "cmbCurrency_T"
        cmbCurrency_T.Size = New Size(338, 31)
        cmbCurrency_T.TabIndex = 20
        ' 
        ' tcTransactionsDetails
        ' 
        tcTransactionsDetails.Controls.Add(tpTransactions)
        tcTransactionsDetails.Controls.Add(tpCommissions)
        tcTransactionsDetails.Font = New Font("Segoe UI", 9F)
        tcTransactionsDetails.Location = New Point(12, 460)
        tcTransactionsDetails.Margin = New Padding(2, 1, 2, 1)
        tcTransactionsDetails.Name = "tcTransactionsDetails"
        tcTransactionsDetails.SelectedIndex = 0
        tcTransactionsDetails.Size = New Size(1035, 754)
        tcTransactionsDetails.TabIndex = 10
        ' 
        ' tpTransactions
        ' 
        tpTransactions.Controls.Add(PanelTransactionLines)
        tpTransactions.Font = New Font("Segoe UI", 9F)
        tpTransactions.Location = New Point(4, 29)
        tpTransactions.Margin = New Padding(2, 1, 2, 1)
        tpTransactions.Name = "tpTransactions"
        tpTransactions.Padding = New Padding(2, 1, 2, 1)
        tpTransactions.Size = New Size(1027, 721)
        tpTransactions.TabIndex = 0
        tpTransactions.Text = "Transaction Lines"
        tpTransactions.UseVisualStyleBackColor = True
        ' 
        ' tpCommissions
        ' 
        tpCommissions.Controls.Add(gbCommissions)
        tpCommissions.Location = New Point(4, 29)
        tpCommissions.Name = "tpCommissions"
        tpCommissions.Size = New Size(1027, 721)
        tpCommissions.TabIndex = 2
        tpCommissions.Text = "Commissions"
        tpCommissions.UseVisualStyleBackColor = True
        ' 
        ' gbCommissions
        ' 
        gbCommissions.Controls.Add(Label9)
        gbCommissions.Controls.Add(chbGassFee_C)
        gbCommissions.Controls.Add(Button1)
        gbCommissions.Controls.Add(btnClear_C)
        gbCommissions.Controls.Add(Button3)
        gbCommissions.Controls.Add(Label4)
        gbCommissions.Controls.Add(cmbCurrency_C)
        gbCommissions.Controls.Add(cmbAgent_C)
        gbCommissions.Controls.Add(Label5)
        gbCommissions.Controls.Add(txtNet_C)
        gbCommissions.Controls.Add(Label6)
        gbCommissions.Controls.Add(txtGass_C)
        gbCommissions.Controls.Add(lblGass_C)
        gbCommissions.Controls.Add(txtGrossD_C)
        gbCommissions.Controls.Add(Label8)
        gbCommissions.Controls.Add(dgvCommissions)
        gbCommissions.Location = New Point(9, 5)
        gbCommissions.Margin = New Padding(2, 1, 2, 1)
        gbCommissions.Name = "gbCommissions"
        gbCommissions.Padding = New Padding(2, 1, 2, 1)
        gbCommissions.Size = New Size(991, 704)
        gbCommissions.TabIndex = 1
        gbCommissions.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8F)
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(1403, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(376, 19)
        Label9.TabIndex = 56
        Label9.Text = "You must add the commissions associated with this tranche."
        ' 
        ' chbGassFee_C
        ' 
        chbGassFee_C.AutoSize = True
        chbGassFee_C.Font = New Font("Segoe UI", 10F)
        chbGassFee_C.Location = New Point(555, 177)
        chbGassFee_C.Name = "chbGassFee_C"
        chbGassFee_C.Size = New Size(94, 27)
        chbGassFee_C.TabIndex = 55
        chbGassFee_C.Text = "Pending"
        chbGassFee_C.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F)
        Button1.Location = New Point(253, 269)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 29)
        Button1.TabIndex = 54
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnClear_C
        ' 
        btnClear_C.Font = New Font("Segoe UI", 9F)
        btnClear_C.Location = New Point(135, 268)
        btnClear_C.Name = "btnClear_C"
        btnClear_C.Size = New Size(102, 29)
        btnClear_C.TabIndex = 53
        btnClear_C.Text = "Clear"
        btnClear_C.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9F)
        Button3.Location = New Point(17, 268)
        Button3.Name = "Button3"
        Button3.Size = New Size(102, 29)
        Button3.TabIndex = 52
        Button3.Text = "Calculate"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.125F)
        Label4.Location = New Point(31, 88)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 23)
        Label4.TabIndex = 51
        Label4.Text = "Currency:"
        ' 
        ' cmbCurrency_C
        ' 
        cmbCurrency_C.BackColor = SystemColors.HighlightText
        cmbCurrency_C.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency_C.FlatStyle = FlatStyle.System
        cmbCurrency_C.Font = New Font("Segoe UI", 10.125F)
        cmbCurrency_C.FormattingEnabled = True
        cmbCurrency_C.Location = New Point(316, 87)
        cmbCurrency_C.Margin = New Padding(2, 1, 2, 1)
        cmbCurrency_C.Name = "cmbCurrency_C"
        cmbCurrency_C.Size = New Size(338, 31)
        cmbCurrency_C.TabIndex = 12
        ' 
        ' cmbAgent_C
        ' 
        cmbAgent_C.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAgent_C.FormattingEnabled = True
        cmbAgent_C.Location = New Point(316, 46)
        cmbAgent_C.Name = "cmbAgent_C"
        cmbAgent_C.Size = New Size(338, 28)
        cmbAgent_C.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.125F)
        Label5.Location = New Point(31, 45)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 23)
        Label5.TabIndex = 48
        Label5.Text = "Agent:"
        ' 
        ' txtNet_C
        ' 
        txtNet_C.BackColor = SystemColors.HighlightText
        txtNet_C.BorderStyle = BorderStyle.FixedSingle
        txtNet_C.Font = New Font("Segoe UI", 10.125F)
        txtNet_C.Location = New Point(316, 219)
        txtNet_C.Margin = New Padding(2, 1, 2, 1)
        txtNet_C.Name = "txtNet_C"
        txtNet_C.Size = New Size(336, 30)
        txtNet_C.TabIndex = 15
        txtNet_C.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(31, 225)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 23)
        Label6.TabIndex = 46
        Label6.Text = "Net Disbursement:"
        ' 
        ' txtGass_C
        ' 
        txtGass_C.BackColor = SystemColors.HighlightText
        txtGass_C.BorderStyle = BorderStyle.FixedSingle
        txtGass_C.Font = New Font("Segoe UI", 10.125F)
        txtGass_C.Location = New Point(316, 175)
        txtGass_C.Margin = New Padding(2, 1, 2, 1)
        txtGass_C.Name = "txtGass_C"
        txtGass_C.Size = New Size(183, 30)
        txtGass_C.TabIndex = 14
        txtGass_C.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblGass_C
        ' 
        lblGass_C.AutoSize = True
        lblGass_C.Font = New Font("Segoe UI", 10F)
        lblGass_C.Location = New Point(31, 177)
        lblGass_C.Margin = New Padding(2, 0, 2, 0)
        lblGass_C.Name = "lblGass_C"
        lblGass_C.Size = New Size(73, 23)
        lblGass_C.TabIndex = 44
        lblGass_C.Text = "Gas Fee:"
        ' 
        ' txtGrossD_C
        ' 
        txtGrossD_C.AcceptsReturn = True
        txtGrossD_C.BackColor = SystemColors.HighlightText
        txtGrossD_C.BorderStyle = BorderStyle.FixedSingle
        txtGrossD_C.Font = New Font("Segoe UI", 10.125F)
        txtGrossD_C.Location = New Point(316, 134)
        txtGrossD_C.Margin = New Padding(2, 1, 2, 1)
        txtGrossD_C.Name = "txtGrossD_C"
        txtGrossD_C.Size = New Size(338, 30)
        txtGrossD_C.TabIndex = 13
        txtGrossD_C.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.Location = New Point(31, 134)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(166, 23)
        Label8.TabIndex = 42
        Label8.Text = "Gross Disbursement:"
        ' 
        ' dgvCommissions
        ' 
        dgvCommissions.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvCommissions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvCommissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvCommissions.DefaultCellStyle = DataGridViewCellStyle5
        dgvCommissions.Location = New Point(10, 312)
        dgvCommissions.Name = "dgvCommissions"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvCommissions.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvCommissions.RowHeadersWidth = 51
        dgvCommissions.Size = New Size(968, 388)
        dgvCommissions.TabIndex = 0
        ' 
        ' dgvTransactionLine
        ' 
        dgvTransactionLine.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTransactionLine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTransactionLine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvTransactionLine.DefaultCellStyle = DataGridViewCellStyle2
        dgvTransactionLine.Location = New Point(10, 312)
        dgvTransactionLine.Name = "dgvTransactionLine"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvTransactionLine.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvTransactionLine.RowHeadersWidth = 51
        dgvTransactionLine.Size = New Size(990, 388)
        dgvTransactionLine.TabIndex = 0
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 10F)
        Label19.Location = New Point(31, 130)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(166, 23)
        Label19.TabIndex = 25
        Label19.Text = "Gross Disbursement:"
        ' 
        ' txtGrossD
        ' 
        txtGrossD.BackColor = SystemColors.HighlightText
        txtGrossD.BorderStyle = BorderStyle.FixedSingle
        txtGrossD.Font = New Font("Segoe UI", 10.125F)
        txtGrossD.Location = New Point(320, 129)
        txtGrossD.Margin = New Padding(2, 1, 2, 1)
        txtGrossD.Name = "txtGrossD"
        txtGrossD.Size = New Size(335, 30)
        txtGrossD.TabIndex = 3
        txtGrossD.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblGass_T
        ' 
        lblGass_T.AutoSize = True
        lblGass_T.Font = New Font("Segoe UI", 10F)
        lblGass_T.Location = New Point(31, 174)
        lblGass_T.Margin = New Padding(2, 0, 2, 0)
        lblGass_T.Name = "lblGass_T"
        lblGass_T.Size = New Size(73, 23)
        lblGass_T.TabIndex = 27
        lblGass_T.Text = "Gas Fee:"
        ' 
        ' txtGas
        ' 
        txtGas.BackColor = SystemColors.HighlightText
        txtGas.BorderStyle = BorderStyle.FixedSingle
        txtGas.Font = New Font("Segoe UI", 10.125F)
        txtGas.Location = New Point(320, 171)
        txtGas.Margin = New Padding(2, 1, 2, 1)
        txtGas.Name = "txtGas"
        txtGas.Size = New Size(159, 30)
        txtGas.TabIndex = 4
        txtGas.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 10F)
        Label17.Location = New Point(31, 222)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(152, 23)
        Label17.TabIndex = 29
        Label17.Text = "Net Disbursement:"
        ' 
        ' txtNet
        ' 
        txtNet.BackColor = SystemColors.HighlightText
        txtNet.BorderStyle = BorderStyle.FixedSingle
        txtNet.Font = New Font("Segoe UI", 10.125F)
        txtNet.Location = New Point(320, 217)
        txtNet.Margin = New Padding(2, 1, 2, 1)
        txtNet.Name = "txtNet"
        txtNet.Size = New Size(333, 30)
        txtNet.TabIndex = 5
        txtNet.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.125F)
        Label1.Location = New Point(31, 40)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 23)
        Label1.TabIndex = 31
        Label1.Text = "Provider:"
        ' 
        ' cmbProvider_L
        ' 
        cmbProvider_L.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProvider_L.Font = New Font("Segoe UI", 10F)
        cmbProvider_L.FormattingEnabled = True
        cmbProvider_L.Location = New Point(320, 39)
        cmbProvider_L.Name = "cmbProvider_L"
        cmbProvider_L.Size = New Size(333, 31)
        cmbProvider_L.TabIndex = 1
        ' 
        ' cmbCurrency_L
        ' 
        cmbCurrency_L.BackColor = SystemColors.HighlightText
        cmbCurrency_L.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency_L.FlatStyle = FlatStyle.System
        cmbCurrency_L.Font = New Font("Segoe UI", 10.125F)
        cmbCurrency_L.FormattingEnabled = True
        cmbCurrency_L.Location = New Point(320, 80)
        cmbCurrency_L.Margin = New Padding(2, 1, 2, 1)
        cmbCurrency_L.Name = "cmbCurrency_L"
        cmbCurrency_L.Size = New Size(333, 31)
        cmbCurrency_L.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.125F)
        Label2.Location = New Point(31, 83)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 23)
        Label2.TabIndex = 34
        Label2.Text = "Currency:"
        ' 
        ' btnCalculateLine
        ' 
        btnCalculateLine.Location = New Point(18, 271)
        btnCalculateLine.Name = "btnCalculateLine"
        btnCalculateLine.Size = New Size(102, 29)
        btnCalculateLine.TabIndex = 37
        btnCalculateLine.Text = "Calculate"
        btnCalculateLine.UseVisualStyleBackColor = True
        ' 
        ' btnClearLine
        ' 
        btnClearLine.Location = New Point(136, 271)
        btnClearLine.Name = "btnClearLine"
        btnClearLine.Size = New Size(102, 29)
        btnClearLine.TabIndex = 38
        btnClearLine.Text = "Clear"
        btnClearLine.UseVisualStyleBackColor = True
        ' 
        ' btnCreateLine
        ' 
        btnCreateLine.Location = New Point(253, 271)
        btnCreateLine.Name = "btnCreateLine"
        btnCreateLine.Size = New Size(102, 29)
        btnCreateLine.TabIndex = 39
        btnCreateLine.Text = "Add"
        btnCreateLine.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8F)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(1452, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(372, 19)
        Label3.TabIndex = 40
        Label3.Text = "You must add the transactions associated with this tranche."
        ' 
        ' chbGassFee
        ' 
        chbGassFee.AutoSize = True
        chbGassFee.Font = New Font("Segoe UI", 10F)
        chbGassFee.Location = New Point(558, 172)
        chbGassFee.Name = "chbGassFee"
        chbGassFee.Size = New Size(94, 27)
        chbGassFee.TabIndex = 41
        chbGassFee.Text = "Pending"
        chbGassFee.UseVisualStyleBackColor = True
        ' 
        ' PanelTransactionLines
        ' 
        PanelTransactionLines.Controls.Add(chbGassFee)
        PanelTransactionLines.Controls.Add(Label3)
        PanelTransactionLines.Controls.Add(btnCreateLine)
        PanelTransactionLines.Controls.Add(btnClearLine)
        PanelTransactionLines.Controls.Add(btnCalculateLine)
        PanelTransactionLines.Controls.Add(Label2)
        PanelTransactionLines.Controls.Add(cmbCurrency_L)
        PanelTransactionLines.Controls.Add(cmbProvider_L)
        PanelTransactionLines.Controls.Add(Label1)
        PanelTransactionLines.Controls.Add(txtNet)
        PanelTransactionLines.Controls.Add(Label17)
        PanelTransactionLines.Controls.Add(txtGas)
        PanelTransactionLines.Controls.Add(lblGass_T)
        PanelTransactionLines.Controls.Add(txtGrossD)
        PanelTransactionLines.Controls.Add(Label19)
        PanelTransactionLines.Controls.Add(dgvTransactionLine)
        PanelTransactionLines.Location = New Point(5, 7)
        PanelTransactionLines.Name = "PanelTransactionLines"
        PanelTransactionLines.Size = New Size(1014, 710)
        PanelTransactionLines.TabIndex = 222
        ' 
        ' frmTransactions_1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(1200, 1222)
        Controls.Add(tcTransactionsDetails)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmTransactions_1"
        Opacity = 0.1R
        Text = "Transactions_1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        tcTransactionsDetails.ResumeLayout(False)
        tpTransactions.ResumeLayout(False)
        tpCommissions.ResumeLayout(False)
        gbCommissions.ResumeLayout(False)
        gbCommissions.PerformLayout()
        CType(dgvCommissions, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTransactionLine, ComponentModel.ISupportInitialize).EndInit()
        PanelTransactionLines.ResumeLayout(False)
        PanelTransactionLines.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNewCurrency As Button
    Friend WithEvents cmbProvider_T As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dtpTransactionDate_T As DateTimePicker
    Friend WithEvents lblTranches As Label
    Friend WithEvents lblNumberOfBTC As Label
    Friend WithEvents lblFinalSwapTranchePrice As Label
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents lblCurrency_T As Label
    Friend WithEvents lblProvider_T As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents txtTranchesExecute_T As TextBox
    Friend WithEvents txtumberofBTC_T As TextBox
    Friend WithEvents txtFinalSwapTranchePrice_T As TextBox
    Friend WithEvents txtTransactionID_T As TextBox
    Friend WithEvents cmbCurrency_T As ComboBox
    Friend WithEvents tcTransactionsDetails As TabControl
    Friend WithEvents tpTransactions As TabPage
    Friend WithEvents tpCommissions As TabPage
    Friend WithEvents gbCommissions As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chbGassFee_C As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClear_C As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCurrency_C As ComboBox
    Friend WithEvents cmbAgent_C As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNet_C As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGass_C As TextBox
    Friend WithEvents lblGass_C As Label
    Friend WithEvents txtGrossD_C As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvCommissions As DataGridView
    Friend WithEvents PanelTransactionLines As Panel
    Friend WithEvents chbGassFee As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCreateLine As Button
    Friend WithEvents btnClearLine As Button
    Friend WithEvents btnCalculateLine As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCurrency_L As ComboBox
    Friend WithEvents cmbProvider_L As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNet As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtGas As TextBox
    Friend WithEvents lblGass_T As Label
    Friend WithEvents txtGrossD As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents dgvTransactionLine As DataGridView
End Class
