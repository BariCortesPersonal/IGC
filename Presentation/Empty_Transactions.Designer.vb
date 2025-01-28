<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmptyTransactions
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
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        gbTransaction = New GroupBox()
        Label7 = New Label()
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
        PanelTransactionLines = New Panel()
        dgvTransactionLine = New DataGridView()
        chbGassFee = New CheckBox()
        Label3 = New Label()
        btnCreateLine = New Button()
        btnClearLine = New Button()
        btnCalculateLine = New Button()
        Label2 = New Label()
        cmbCurrency_L = New ComboBox()
        cmbProvider_L = New ComboBox()
        Label1 = New Label()
        txtNet = New TextBox()
        Label17 = New Label()
        txtGas = New TextBox()
        lblGass_T = New Label()
        txtGrossD = New TextBox()
        Label19 = New Label()
        tpCommissions = New TabPage()
        pnCommissions = New Panel()
        dgvCommissions = New DataGridView()
        Label9 = New Label()
        chbGassFee_C = New CheckBox()
        btnAddCommission = New Button()
        btnClear_C = New Button()
        Button3 = New Button()
        Label4 = New Label()
        cmbCurrency_C = New ComboBox()
        cmbAgent_C = New ComboBox()
        Label5 = New Label()
        txtNet_C = New TextBox()
        lblNet_C = New Label()
        txtGass_C = New TextBox()
        lblGass_C = New Label()
        txtGrossD_C = New TextBox()
        lblGross_C = New Label()
        gbTransaction.SuspendLayout()
        tcTransactionsDetails.SuspendLayout()
        tpTransactions.SuspendLayout()
        PanelTransactionLines.SuspendLayout()
        CType(dgvTransactionLine, ComponentModel.ISupportInitialize).BeginInit()
        tpCommissions.SuspendLayout()
        pnCommissions.SuspendLayout()
        CType(dgvCommissions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbTransaction
        ' 
        gbTransaction.BackColor = Color.Lavender
        gbTransaction.Controls.Add(Label7)
        gbTransaction.Controls.Add(btnNewCurrency)
        gbTransaction.Controls.Add(cmbProvider_T)
        gbTransaction.Controls.Add(btnSave)
        gbTransaction.Controls.Add(btnCalculate)
        gbTransaction.Controls.Add(btnClear)
        gbTransaction.Controls.Add(dtpTransactionDate_T)
        gbTransaction.Controls.Add(lblTranches)
        gbTransaction.Controls.Add(lblNumberOfBTC)
        gbTransaction.Controls.Add(lblFinalSwapTranchePrice)
        gbTransaction.Controls.Add(lblTransactionDate)
        gbTransaction.Controls.Add(lblCurrency_T)
        gbTransaction.Controls.Add(lblProvider_T)
        gbTransaction.Controls.Add(lblTransactionID)
        gbTransaction.Controls.Add(txtTranchesExecute_T)
        gbTransaction.Controls.Add(txtumberofBTC_T)
        gbTransaction.Controls.Add(txtFinalSwapTranchePrice_T)
        gbTransaction.Controls.Add(txtTransactionID_T)
        gbTransaction.Controls.Add(cmbCurrency_T)
        gbTransaction.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        gbTransaction.Location = New Point(12, 32)
        gbTransaction.Margin = New Padding(2, 1, 2, 1)
        gbTransaction.Name = "gbTransaction"
        gbTransaction.Padding = New Padding(2, 1, 2, 1)
        gbTransaction.Size = New Size(1031, 392)
        gbTransaction.TabIndex = 8
        gbTransaction.TabStop = False
        gbTransaction.Tag = ""
        gbTransaction.Text = "Transaction"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlDarkDark
        Label7.Location = New Point(680, 166)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 17)
        Label7.TabIndex = 20
        Label7.Text = "Add New Currency"
        ' 
        ' btnNewCurrency
        ' 
        btnNewCurrency.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnNewCurrency.Location = New Point(645, 159)
        btnNewCurrency.Name = "btnNewCurrency"
        btnNewCurrency.Size = New Size(30, 30)
        btnNewCurrency.TabIndex = 19
        btnNewCurrency.Text = "+"
        btnNewCurrency.UseVisualStyleBackColor = True
        ' 
        ' cmbProvider_T
        ' 
        cmbProvider_T.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProvider_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cmbProvider_T.ForeColor = Color.Black
        cmbProvider_T.FormattingEnabled = True
        cmbProvider_T.Location = New Point(280, 117)
        cmbProvider_T.Name = "cmbProvider_T"
        cmbProvider_T.Size = New Size(338, 31)
        cmbProvider_T.TabIndex = 18
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(842, 338)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(165, 41)
        btnSave.TabIndex = 17
        btnSave.Text = "Create Transaction"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        btnCalculate.ForeColor = Color.Black
        btnCalculate.Location = New Point(842, 281)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(165, 41)
        btnCalculate.TabIndex = 16
        btnCalculate.Text = "Re-Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(842, 223)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(165, 41)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear Data"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dtpTransactionDate_T
        ' 
        dtpTransactionDate_T.CalendarFont = New Font("Segoe UI", 12F)
        dtpTransactionDate_T.CalendarForeColor = Color.Black
        dtpTransactionDate_T.CalendarTitleBackColor = SystemColors.ActiveCaptionText
        dtpTransactionDate_T.CalendarTitleForeColor = SystemColors.ActiveCaption
        dtpTransactionDate_T.DropDownAlign = LeftRightAlignment.Right
        dtpTransactionDate_T.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpTransactionDate_T.Format = DateTimePickerFormat.Short
        dtpTransactionDate_T.Location = New Point(282, 210)
        dtpTransactionDate_T.Margin = New Padding(2, 1, 2, 1)
        dtpTransactionDate_T.Name = "dtpTransactionDate_T"
        dtpTransactionDate_T.Size = New Size(336, 34)
        dtpTransactionDate_T.TabIndex = 14
        ' 
        ' lblTranches
        ' 
        lblTranches.AutoSize = True
        lblTranches.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblTranches.ForeColor = Color.Black
        lblTranches.Location = New Point(35, 348)
        lblTranches.Margin = New Padding(2, 0, 2, 0)
        lblTranches.Name = "lblTranches"
        lblTranches.Size = New Size(147, 23)
        lblTranches.TabIndex = 13
        lblTranches.Text = "Tranches Executed:"
        ' 
        ' lblNumberOfBTC
        ' 
        lblNumberOfBTC.AutoSize = True
        lblNumberOfBTC.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblNumberOfBTC.ForeColor = Color.Black
        lblNumberOfBTC.Location = New Point(35, 304)
        lblNumberOfBTC.Margin = New Padding(2, 0, 2, 0)
        lblNumberOfBTC.Name = "lblNumberOfBTC"
        lblNumberOfBTC.Size = New Size(121, 23)
        lblNumberOfBTC.TabIndex = 12
        lblNumberOfBTC.Text = "Total Currency:"
        ' 
        ' lblFinalSwapTranchePrice
        ' 
        lblFinalSwapTranchePrice.AutoSize = True
        lblFinalSwapTranchePrice.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblFinalSwapTranchePrice.ForeColor = Color.Black
        lblFinalSwapTranchePrice.Location = New Point(35, 258)
        lblFinalSwapTranchePrice.Margin = New Padding(2, 0, 2, 0)
        lblFinalSwapTranchePrice.Name = "lblFinalSwapTranchePrice"
        lblFinalSwapTranchePrice.Size = New Size(195, 23)
        lblFinalSwapTranchePrice.TabIndex = 11
        lblFinalSwapTranchePrice.Text = "Final Swap Tranche Price:"
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblTransactionDate.ForeColor = Color.Black
        lblTransactionDate.Location = New Point(35, 214)
        lblTransactionDate.Margin = New Padding(2, 0, 2, 0)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(140, 23)
        lblTransactionDate.TabIndex = 10
        lblTransactionDate.Text = "Transaction Date:"
        ' 
        ' lblCurrency_T
        ' 
        lblCurrency_T.AutoSize = True
        lblCurrency_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblCurrency_T.ForeColor = Color.Black
        lblCurrency_T.Location = New Point(35, 160)
        lblCurrency_T.Margin = New Padding(2, 0, 2, 0)
        lblCurrency_T.Name = "lblCurrency_T"
        lblCurrency_T.Size = New Size(79, 23)
        lblCurrency_T.TabIndex = 9
        lblCurrency_T.Text = "Currency:"
        ' 
        ' lblProvider_T
        ' 
        lblProvider_T.AutoSize = True
        lblProvider_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblProvider_T.ForeColor = Color.Black
        lblProvider_T.Location = New Point(35, 118)
        lblProvider_T.Margin = New Padding(2, 0, 2, 0)
        lblProvider_T.Name = "lblProvider_T"
        lblProvider_T.Size = New Size(74, 23)
        lblProvider_T.TabIndex = 8
        lblProvider_T.Text = "Provider:"
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        lblTransactionID.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblTransactionID.ForeColor = Color.Black
        lblTransactionID.Location = New Point(35, 54)
        lblTransactionID.Margin = New Padding(2, 0, 2, 0)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(117, 23)
        lblTransactionID.TabIndex = 7
        lblTransactionID.Text = "TransactionID:"
        ' 
        ' txtTranchesExecute_T
        ' 
        txtTranchesExecute_T.BackColor = SystemColors.HighlightText
        txtTranchesExecute_T.BorderStyle = BorderStyle.FixedSingle
        txtTranchesExecute_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        txtTranchesExecute_T.Location = New Point(280, 350)
        txtTranchesExecute_T.Margin = New Padding(2, 1, 2, 1)
        txtTranchesExecute_T.Name = "txtTranchesExecute_T"
        txtTranchesExecute_T.Size = New Size(336, 30)
        txtTranchesExecute_T.TabIndex = 4
        txtTranchesExecute_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtumberofBTC_T
        ' 
        txtumberofBTC_T.BackColor = SystemColors.HighlightText
        txtumberofBTC_T.BorderStyle = BorderStyle.FixedSingle
        txtumberofBTC_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        txtumberofBTC_T.Location = New Point(282, 305)
        txtumberofBTC_T.Margin = New Padding(2, 1, 2, 1)
        txtumberofBTC_T.Name = "txtumberofBTC_T"
        txtumberofBTC_T.Size = New Size(335, 30)
        txtumberofBTC_T.TabIndex = 3
        txtumberofBTC_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtFinalSwapTranchePrice_T
        ' 
        txtFinalSwapTranchePrice_T.BackColor = SystemColors.HighlightText
        txtFinalSwapTranchePrice_T.BorderStyle = BorderStyle.FixedSingle
        txtFinalSwapTranchePrice_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        txtFinalSwapTranchePrice_T.Location = New Point(282, 259)
        txtFinalSwapTranchePrice_T.Margin = New Padding(2, 1, 2, 1)
        txtFinalSwapTranchePrice_T.Name = "txtFinalSwapTranchePrice_T"
        txtFinalSwapTranchePrice_T.Size = New Size(335, 30)
        txtFinalSwapTranchePrice_T.TabIndex = 2
        txtFinalSwapTranchePrice_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTransactionID_T
        ' 
        txtTransactionID_T.BackColor = SystemColors.HighlightText
        txtTransactionID_T.BorderStyle = BorderStyle.FixedSingle
        txtTransactionID_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtTransactionID_T.Location = New Point(280, 52)
        txtTransactionID_T.Margin = New Padding(2, 1, 2, 1)
        txtTransactionID_T.Name = "txtTransactionID_T"
        txtTransactionID_T.ReadOnly = True
        txtTransactionID_T.Size = New Size(338, 30)
        txtTransactionID_T.TabIndex = 1
        txtTransactionID_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' cmbCurrency_T
        ' 
        cmbCurrency_T.BackColor = SystemColors.HighlightText
        cmbCurrency_T.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency_T.FlatStyle = FlatStyle.System
        cmbCurrency_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cmbCurrency_T.ForeColor = Color.Black
        cmbCurrency_T.FormattingEnabled = True
        cmbCurrency_T.Location = New Point(280, 162)
        cmbCurrency_T.Margin = New Padding(2, 1, 2, 1)
        cmbCurrency_T.Name = "cmbCurrency_T"
        cmbCurrency_T.Size = New Size(338, 31)
        cmbCurrency_T.TabIndex = 1
        ' 
        ' tcTransactionsDetails
        ' 
        tcTransactionsDetails.Controls.Add(tpTransactions)
        tcTransactionsDetails.Controls.Add(tpCommissions)
        tcTransactionsDetails.Font = New Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        tcTransactionsDetails.Location = New Point(12, 431)
        tcTransactionsDetails.Margin = New Padding(2, 1, 2, 1)
        tcTransactionsDetails.Name = "tcTransactionsDetails"
        tcTransactionsDetails.SelectedIndex = 0
        tcTransactionsDetails.Size = New Size(1035, 693)
        tcTransactionsDetails.TabIndex = 9
        ' 
        ' tpTransactions
        ' 
        tpTransactions.BackColor = Color.Lavender
        tpTransactions.Controls.Add(PanelTransactionLines)
        tpTransactions.Font = New Font("Segoe UI", 9F)
        tpTransactions.Location = New Point(4, 34)
        tpTransactions.Margin = New Padding(2, 1, 2, 1)
        tpTransactions.Name = "tpTransactions"
        tpTransactions.Padding = New Padding(2, 1, 2, 1)
        tpTransactions.Size = New Size(1027, 655)
        tpTransactions.TabIndex = 0
        tpTransactions.Text = "Transaction Lines"
        ' 
        ' PanelTransactionLines
        ' 
        PanelTransactionLines.BackColor = Color.White
        PanelTransactionLines.Controls.Add(dgvTransactionLine)
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
        PanelTransactionLines.Location = New Point(6, 4)
        PanelTransactionLines.Name = "PanelTransactionLines"
        PanelTransactionLines.Size = New Size(1016, 645)
        PanelTransactionLines.TabIndex = 222
        ' 
        ' dgvTransactionLine
        ' 
        dgvTransactionLine.BackgroundColor = Color.White
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Control
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.Black
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvTransactionLine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvTransactionLine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Window
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.Black
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvTransactionLine.DefaultCellStyle = DataGridViewCellStyle9
        dgvTransactionLine.Location = New Point(10, 314)
        dgvTransactionLine.Name = "dgvTransactionLine"
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = SystemColors.Control
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle10.ForeColor = Color.Black
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        dgvTransactionLine.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        dgvTransactionLine.RowHeadersWidth = 51
        dgvTransactionLine.Size = New Size(995, 323)
        dgvTransactionLine.TabIndex = 0
        ' 
        ' chbGassFee
        ' 
        chbGassFee.AutoSize = True
        chbGassFee.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chbGassFee.Location = New Point(398, 173)
        chbGassFee.Name = "chbGassFee"
        chbGassFee.Size = New Size(92, 27)
        chbGassFee.TabIndex = 41
        chbGassFee.Text = "Pending"
        chbGassFee.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(667, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(337, 17)
        Label3.TabIndex = 40
        Label3.Text = "You must add the transactions associated with this tranche."
        ' 
        ' btnCreateLine
        ' 
        btnCreateLine.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        btnCreateLine.ForeColor = Color.Black
        btnCreateLine.Location = New Point(253, 271)
        btnCreateLine.Name = "btnCreateLine"
        btnCreateLine.Size = New Size(102, 29)
        btnCreateLine.TabIndex = 39
        btnCreateLine.Text = "Add"
        btnCreateLine.UseVisualStyleBackColor = True
        ' 
        ' btnClearLine
        ' 
        btnClearLine.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        btnClearLine.ForeColor = Color.Black
        btnClearLine.Location = New Point(136, 271)
        btnClearLine.Name = "btnClearLine"
        btnClearLine.Size = New Size(102, 29)
        btnClearLine.TabIndex = 38
        btnClearLine.Text = "Clear"
        btnClearLine.UseVisualStyleBackColor = True
        ' 
        ' btnCalculateLine
        ' 
        btnCalculateLine.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        btnCalculateLine.ForeColor = Color.Black
        btnCalculateLine.Location = New Point(18, 271)
        btnCalculateLine.Name = "btnCalculateLine"
        btnCalculateLine.Size = New Size(102, 29)
        btnCalculateLine.TabIndex = 37
        btnCalculateLine.Text = "Calculate"
        btnCalculateLine.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(32, 83)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 34
        Label2.Text = "Currency:"
        ' 
        ' cmbCurrency_L
        ' 
        cmbCurrency_L.BackColor = SystemColors.HighlightText
        cmbCurrency_L.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency_L.FlatStyle = FlatStyle.System
        cmbCurrency_L.Font = New Font("Segoe UI", 10.125F)
        cmbCurrency_L.FormattingEnabled = True
        cmbCurrency_L.Location = New Point(205, 80)
        cmbCurrency_L.Margin = New Padding(2, 1, 2, 1)
        cmbCurrency_L.Name = "cmbCurrency_L"
        cmbCurrency_L.Size = New Size(285, 31)
        cmbCurrency_L.TabIndex = 2
        ' 
        ' cmbProvider_L
        ' 
        cmbProvider_L.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProvider_L.Font = New Font("Segoe UI", 10F)
        cmbProvider_L.FormattingEnabled = True
        cmbProvider_L.Location = New Point(205, 39)
        cmbProvider_L.Name = "cmbProvider_L"
        cmbProvider_L.Size = New Size(285, 31)
        cmbProvider_L.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(32, 41)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 23)
        Label1.TabIndex = 31
        Label1.Text = "Provider:"
        ' 
        ' txtNet
        ' 
        txtNet.BackColor = SystemColors.HighlightText
        txtNet.BorderStyle = BorderStyle.FixedSingle
        txtNet.Font = New Font("Segoe UI", 10.125F)
        txtNet.Location = New Point(205, 215)
        txtNet.Margin = New Padding(2, 1, 2, 1)
        txtNet.Name = "txtNet"
        txtNet.Size = New Size(285, 30)
        txtNet.TabIndex = 5
        txtNet.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(32, 219)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(147, 23)
        Label17.TabIndex = 29
        Label17.Text = "Net Disbursement:"
        ' 
        ' txtGas
        ' 
        txtGas.BackColor = SystemColors.HighlightText
        txtGas.BorderStyle = BorderStyle.FixedSingle
        txtGas.Font = New Font("Segoe UI", 10.125F)
        txtGas.Location = New Point(205, 171)
        txtGas.Margin = New Padding(2, 1, 2, 1)
        txtGas.Name = "txtGas"
        txtGas.Size = New Size(159, 30)
        txtGas.TabIndex = 4
        txtGas.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblGass_T
        ' 
        lblGass_T.AutoSize = True
        lblGass_T.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblGass_T.ForeColor = Color.Black
        lblGass_T.Location = New Point(32, 174)
        lblGass_T.Margin = New Padding(2, 0, 2, 0)
        lblGass_T.Name = "lblGass_T"
        lblGass_T.Size = New Size(71, 23)
        lblGass_T.TabIndex = 27
        lblGass_T.Text = "Gas Fee:"
        ' 
        ' txtGrossD
        ' 
        txtGrossD.BackColor = SystemColors.HighlightText
        txtGrossD.BorderStyle = BorderStyle.FixedSingle
        txtGrossD.Font = New Font("Segoe UI", 10.125F)
        txtGrossD.Location = New Point(205, 129)
        txtGrossD.Margin = New Padding(2, 1, 2, 1)
        txtGrossD.Name = "txtGrossD"
        txtGrossD.Size = New Size(287, 30)
        txtGrossD.TabIndex = 3
        txtGrossD.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(32, 132)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(161, 23)
        Label19.TabIndex = 25
        Label19.Text = "Gross Disbursement:"
        ' 
        ' tpCommissions
        ' 
        tpCommissions.BackColor = Color.Lavender
        tpCommissions.Controls.Add(pnCommissions)
        tpCommissions.Location = New Point(4, 34)
        tpCommissions.Name = "tpCommissions"
        tpCommissions.Size = New Size(1027, 655)
        tpCommissions.TabIndex = 2
        tpCommissions.Text = "Commissions"
        ' 
        ' pnCommissions
        ' 
        pnCommissions.BackColor = Color.White
        pnCommissions.Controls.Add(dgvCommissions)
        pnCommissions.Controls.Add(Label9)
        pnCommissions.Controls.Add(chbGassFee_C)
        pnCommissions.Controls.Add(btnAddCommission)
        pnCommissions.Controls.Add(btnClear_C)
        pnCommissions.Controls.Add(Button3)
        pnCommissions.Controls.Add(Label4)
        pnCommissions.Controls.Add(cmbCurrency_C)
        pnCommissions.Controls.Add(cmbAgent_C)
        pnCommissions.Controls.Add(Label5)
        pnCommissions.Controls.Add(txtNet_C)
        pnCommissions.Controls.Add(lblNet_C)
        pnCommissions.Controls.Add(txtGass_C)
        pnCommissions.Controls.Add(lblGass_C)
        pnCommissions.Controls.Add(txtGrossD_C)
        pnCommissions.Controls.Add(lblGross_C)
        pnCommissions.Location = New Point(4, 3)
        pnCommissions.Name = "pnCommissions"
        pnCommissions.Size = New Size(1018, 645)
        pnCommissions.TabIndex = 0
        ' 
        ' dgvCommissions
        ' 
        dgvCommissions.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvCommissions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvCommissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvCommissions.DefaultCellStyle = DataGridViewCellStyle7
        dgvCommissions.Location = New Point(10, 314)
        dgvCommissions.Name = "dgvCommissions"
        dgvCommissions.RowHeadersWidth = 51
        dgvCommissions.Size = New Size(995, 323)
        dgvCommissions.TabIndex = 57
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(669, 4)
        Label9.Name = "Label9"
        Label9.Size = New Size(340, 17)
        Label9.TabIndex = 72
        Label9.Text = "You must add the commissions associated with this tranche."
        ' 
        ' chbGassFee_C
        ' 
        chbGassFee_C.AutoSize = True
        chbGassFee_C.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chbGassFee_C.ForeColor = Color.Black
        chbGassFee_C.Location = New Point(332, 174)
        chbGassFee_C.Name = "chbGassFee_C"
        chbGassFee_C.Size = New Size(92, 27)
        chbGassFee_C.TabIndex = 71
        chbGassFee_C.Text = "Pending"
        chbGassFee_C.UseVisualStyleBackColor = True
        ' 
        ' btnAddCommission
        ' 
        btnAddCommission.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        btnAddCommission.ForeColor = Color.Black
        btnAddCommission.Location = New Point(254, 272)
        btnAddCommission.Name = "btnAddCommission"
        btnAddCommission.Size = New Size(102, 29)
        btnAddCommission.TabIndex = 70
        btnAddCommission.Text = "Add"
        btnAddCommission.UseVisualStyleBackColor = True
        ' 
        ' btnClear_C
        ' 
        btnClear_C.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        btnClear_C.ForeColor = Color.Black
        btnClear_C.Location = New Point(136, 271)
        btnClear_C.Name = "btnClear_C"
        btnClear_C.Size = New Size(102, 29)
        btnClear_C.TabIndex = 69
        btnClear_C.Text = "Clear"
        btnClear_C.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(18, 271)
        Button3.Name = "Button3"
        Button3.Size = New Size(102, 29)
        Button3.TabIndex = 68
        Button3.Text = "Calculate"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(32, 84)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 23)
        Label4.TabIndex = 67
        Label4.Text = "Currency:"
        ' 
        ' cmbCurrency_C
        ' 
        cmbCurrency_C.BackColor = SystemColors.HighlightText
        cmbCurrency_C.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency_C.FlatStyle = FlatStyle.System
        cmbCurrency_C.Font = New Font("Segoe UI", 10.125F)
        cmbCurrency_C.ForeColor = Color.Black
        cmbCurrency_C.FormattingEnabled = True
        cmbCurrency_C.Location = New Point(152, 81)
        cmbCurrency_C.Margin = New Padding(2, 1, 2, 1)
        cmbCurrency_C.Name = "cmbCurrency_C"
        cmbCurrency_C.Size = New Size(338, 31)
        cmbCurrency_C.TabIndex = 59
        ' 
        ' cmbAgent_C
        ' 
        cmbAgent_C.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAgent_C.ForeColor = Color.Black
        cmbAgent_C.FormattingEnabled = True
        cmbAgent_C.Location = New Point(152, 40)
        cmbAgent_C.Name = "cmbAgent_C"
        cmbAgent_C.Size = New Size(338, 33)
        cmbAgent_C.TabIndex = 58
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(32, 41)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 23)
        Label5.TabIndex = 66
        Label5.Text = "Agent:"
        ' 
        ' txtNet_C
        ' 
        txtNet_C.BackColor = SystemColors.HighlightText
        txtNet_C.BorderStyle = BorderStyle.FixedSingle
        txtNet_C.Font = New Font("Segoe UI", 10.125F)
        txtNet_C.Location = New Point(206, 214)
        txtNet_C.Margin = New Padding(2, 1, 2, 1)
        txtNet_C.Name = "txtNet_C"
        txtNet_C.Size = New Size(250, 30)
        txtNet_C.TabIndex = 62
        txtNet_C.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblNet_C
        ' 
        lblNet_C.AutoSize = True
        lblNet_C.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblNet_C.ForeColor = Color.Black
        lblNet_C.Location = New Point(32, 221)
        lblNet_C.Margin = New Padding(2, 0, 2, 0)
        lblNet_C.Name = "lblNet_C"
        lblNet_C.Size = New Size(147, 23)
        lblNet_C.TabIndex = 65
        lblNet_C.Text = "Net Disbursement:"
        ' 
        ' txtGass_C
        ' 
        txtGass_C.BackColor = SystemColors.HighlightText
        txtGass_C.BorderStyle = BorderStyle.FixedSingle
        txtGass_C.Font = New Font("Segoe UI", 10.125F)
        txtGass_C.Location = New Point(206, 170)
        txtGass_C.Margin = New Padding(2, 1, 2, 1)
        txtGass_C.Name = "txtGass_C"
        txtGass_C.Size = New Size(97, 30)
        txtGass_C.TabIndex = 61
        txtGass_C.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblGass_C
        ' 
        lblGass_C.AutoSize = True
        lblGass_C.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblGass_C.ForeColor = Color.Black
        lblGass_C.Location = New Point(32, 173)
        lblGass_C.Margin = New Padding(2, 0, 2, 0)
        lblGass_C.Name = "lblGass_C"
        lblGass_C.Size = New Size(71, 23)
        lblGass_C.TabIndex = 64
        lblGass_C.Text = "Gas Fee:"
        ' 
        ' txtGrossD_C
        ' 
        txtGrossD_C.AcceptsReturn = True
        txtGrossD_C.BackColor = SystemColors.HighlightText
        txtGrossD_C.BorderStyle = BorderStyle.FixedSingle
        txtGrossD_C.Font = New Font("Segoe UI", 10.125F)
        txtGrossD_C.Location = New Point(206, 129)
        txtGrossD_C.Margin = New Padding(2, 1, 2, 1)
        txtGrossD_C.Name = "txtGrossD_C"
        txtGrossD_C.Size = New Size(252, 30)
        txtGrossD_C.TabIndex = 60
        txtGrossD_C.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblGross_C
        ' 
        lblGross_C.AutoSize = True
        lblGross_C.Font = New Font("Segoe UI", 10.2F, FontStyle.Italic)
        lblGross_C.ForeColor = Color.Black
        lblGross_C.Location = New Point(32, 130)
        lblGross_C.Margin = New Padding(2, 0, 2, 0)
        lblGross_C.Name = "lblGross_C"
        lblGross_C.Size = New Size(161, 23)
        lblGross_C.TabIndex = 63
        lblGross_C.Text = "Gross Disbursement:"
        ' 
        ' frmEmptyTransactions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(1129, 1222)
        Controls.Add(tcTransactionsDetails)
        Controls.Add(gbTransaction)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEmptyTransactions"
        Text = "Transactions_1"
        gbTransaction.ResumeLayout(False)
        gbTransaction.PerformLayout()
        tcTransactionsDetails.ResumeLayout(False)
        tpTransactions.ResumeLayout(False)
        PanelTransactionLines.ResumeLayout(False)
        PanelTransactionLines.PerformLayout()
        CType(dgvTransactionLine, ComponentModel.ISupportInitialize).EndInit()
        tpCommissions.ResumeLayout(False)
        pnCommissions.ResumeLayout(False)
        pnCommissions.PerformLayout()
        CType(dgvCommissions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents gbTransaction As GroupBox
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
    Friend WithEvents PanelTransactionLines As Panel
    Friend WithEvents dgvTransactionLine As DataGridView
    Friend WithEvents tpCommissions As TabPage
    Friend WithEvents txtNet As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtGas As TextBox
    Friend WithEvents lblGass_T As Label
    Friend WithEvents txtGrossD As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCurrency_L As ComboBox
    Friend WithEvents cmbProvider_L As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClearLine As Button
    Friend WithEvents btnCalculateLine As Button
    Friend WithEvents btnCreateLine As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents chbGassFee As CheckBox
    Friend WithEvents pnCommissions As Panel
    Friend WithEvents dgvCommissions As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents chbGassFee_C As CheckBox
    Friend WithEvents btnAddCommission As Button
    Friend WithEvents btnClear_C As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCurrency_C As ComboBox
    Friend WithEvents cmbAgent_C As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNet_C As TextBox
    Friend WithEvents lblNet_C As Label
    Friend WithEvents txtGass_C As TextBox
    Friend WithEvents lblGass_C As Label
    Friend WithEvents txtGrossD_C As TextBox
    Friend WithEvents lblGross_C As Label
    Friend WithEvents Label7 As Label
End Class
