<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTransaction
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
        tcTransactionsDetails = New TabControl()
        tpTransactions = New TabPage()
        Label1 = New Label()
        PanelTransactionLines = New Panel()
        gbLines = New GroupBox()
        gpTransaction_L3 = New GroupBox()
        txtDailyTadrosDisbursment = New TextBox()
        lblDailyTadrossGross = New Label()
        Label4 = New Label()
        txtNet_L33 = New TextBox()
        Label30 = New Label()
        txtGrossD_L33 = New TextBox()
        Label32 = New Label()
        txtCurrency_L33 = New TextBox()
        Label25 = New Label()
        txtNet_L32 = New TextBox()
        Label26 = New Label()
        txtGrossDailyTadrossDisbursment = New TextBox()
        Label27 = New Label()
        txtGrossD_L32 = New TextBox()
        Label28 = New Label()
        txtCurrency_L32 = New TextBox()
        Label20 = New Label()
        Label21 = New Label()
        txtNet_L31 = New TextBox()
        Label22 = New Label()
        txtTadrossIncome = New TextBox()
        lblPercentageTadross = New Label()
        txtGrossD_L31 = New TextBox()
        Label24 = New Label()
        txtCurrency_L31 = New TextBox()
        txtProvider_L3 = New TextBox()
        gpTransaction_L2 = New GroupBox()
        Label15 = New Label()
        Label16 = New Label()
        txtNet_L2 = New TextBox()
        Label17 = New Label()
        txtGas_L2 = New TextBox()
        Label18 = New Label()
        txtGrossD_L2 = New TextBox()
        Label19 = New Label()
        txtCurrency_L2 = New TextBox()
        txtProvider_L2 = New TextBox()
        gpTransaction_L1 = New GroupBox()
        Label10 = New Label()
        Label11 = New Label()
        txtNet_L1 = New TextBox()
        Label12 = New Label()
        txtGas_L1 = New TextBox()
        Label13 = New Label()
        txtGrossD_L1 = New TextBox()
        Label14 = New Label()
        txtCurrency_L1 = New TextBox()
        txtProvider_L1 = New TextBox()
        tpCommissions = New TabPage()
        gbCommissions = New GroupBox()
        dgvCommissions = New DataGridView()
        gbTransaction = New GroupBox()
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
        txtCurrency_C2C_USDT = New TextBox()
        Label33 = New Label()
        txtGross_C2C_USDT = New TextBox()
        Label29 = New Label()
        txtCurrency_C2C_BTC = New TextBox()
        txtGross_C2C_BTC = New TextBox()
        txtCurrency_PAG_USDT = New TextBox()
        Label6 = New Label()
        txtGross_PAG_USDT = New TextBox()
        Label5 = New Label()
        txtCurrency_PAG_BTC = New TextBox()
        txtGross_PAG_BTC = New TextBox()
        txtCurrency_Charity = New TextBox()
        Label37 = New Label()
        txtGross_Charity = New TextBox()
        Label36 = New Label()
        txtCurrency_IGL_USDT = New TextBox()
        Label35 = New Label()
        txtGross_IGL_USDT = New TextBox()
        Label34 = New Label()
        txtCurrency_IGL_BTC = New TextBox()
        txtGross_IGL_BTC = New TextBox()
        txtCurrency_Triangle = New TextBox()
        Label43 = New Label()
        txtGross_Triangle = New TextBox()
        Label42 = New Label()
        txtCurrency_Lumley = New TextBox()
        Label41 = New Label()
        txtGross_Lumley = New TextBox()
        Label40 = New Label()
        Label54 = New Label()
        txtNet_C2C_USDT = New TextBox()
        txtNet_C2C_BTC = New TextBox()
        Label52 = New Label()
        txtNet_PAG_USDT = New TextBox()
        txtNet_PAG_BTC = New TextBox()
        Label50 = New Label()
        txtNet_Charity = New TextBox()
        Label49 = New Label()
        txtNet_IGL_USDT = New TextBox()
        txtNet_IGL_BTC = New TextBox()
        Label47 = New Label()
        txtNet_Triangle = New TextBox()
        Label46 = New Label()
        txtNet_Lumley = New TextBox()
        txtCurrency_Fendly = New TextBox()
        Label60 = New Label()
        txtGross_Fendly = New TextBox()
        Label59 = New Label()
        txtCurrency_Crisci = New TextBox()
        Label58 = New Label()
        txtGross_Crisci = New TextBox()
        Label57 = New Label()
        Label56 = New Label()
        txtNet_Fendly = New TextBox()
        Label55 = New Label()
        txtNet_Crisci = New TextBox()
        txtAgent_C2C_USDT = New TextBox()
        Label71 = New Label()
        txtAgent_C2C_BTC = New TextBox()
        txtAgent_PAG_USDT = New TextBox()
        Label69 = New Label()
        txtAgent_PAG_BTC = New TextBox()
        txtAgent_Charity = New TextBox()
        Label67 = New Label()
        txtAgent_IGL_USDT = New TextBox()
        txtAgent_IGL_BTC = New TextBox()
        txtAgent_Triangle = New TextBox()
        Label64 = New Label()
        txtAgent_Lumley = New TextBox()
        Label63 = New Label()
        txtAgent_Fendly = New TextBox()
        Label62 = New Label()
        txtAgent_Crisci = New TextBox()
        Label61 = New Label()
        Label2 = New Label()
        tcTransactionsDetails.SuspendLayout()
        tpTransactions.SuspendLayout()
        PanelTransactionLines.SuspendLayout()
        gbLines.SuspendLayout()
        gpTransaction_L3.SuspendLayout()
        gpTransaction_L2.SuspendLayout()
        gpTransaction_L1.SuspendLayout()
        tpCommissions.SuspendLayout()
        gbCommissions.SuspendLayout()
        CType(dgvCommissions, ComponentModel.ISupportInitialize).BeginInit()
        gbTransaction.SuspendLayout()
        SuspendLayout()
        ' 
        ' tcTransactionsDetails
        ' 
        tcTransactionsDetails.Controls.Add(tpTransactions)
        tcTransactionsDetails.Controls.Add(tpCommissions)
        tcTransactionsDetails.Font = New Font("Segoe UI", 11F)
        tcTransactionsDetails.Location = New Point(8, 252)
        tcTransactionsDetails.Margin = New Padding(2, 1, 2, 1)
        tcTransactionsDetails.Name = "tcTransactionsDetails"
        tcTransactionsDetails.SelectedIndex = 0
        tcTransactionsDetails.Size = New Size(1405, 608)
        tcTransactionsDetails.TabIndex = 0
        ' 
        ' tpTransactions
        ' 
        tpTransactions.Controls.Add(Label1)
        tpTransactions.Controls.Add(PanelTransactionLines)
        tpTransactions.Font = New Font("Segoe UI", 9F)
        tpTransactions.Location = New Point(4, 34)
        tpTransactions.Margin = New Padding(2, 1, 2, 1)
        tpTransactions.Name = "tpTransactions"
        tpTransactions.Padding = New Padding(2, 1, 2, 1)
        tpTransactions.Size = New Size(1397, 570)
        tpTransactions.TabIndex = 0
        tpTransactions.Text = "Transactions"
        tpTransactions.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 50F)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(304, -34)
        Label1.Name = "Label1"
        Label1.Size = New Size(759, 112)
        Label1.TabIndex = 14
        Label1.Text = "Under construction"
        ' 
        ' PanelTransactionLines
        ' 
        PanelTransactionLines.Controls.Add(gbLines)
        PanelTransactionLines.Location = New Point(13, 4)
        PanelTransactionLines.Name = "PanelTransactionLines"
        PanelTransactionLines.Size = New Size(1372, 562)
        PanelTransactionLines.TabIndex = 4
        ' 
        ' gbLines
        ' 
        gbLines.Controls.Add(gpTransaction_L3)
        gbLines.Controls.Add(gpTransaction_L2)
        gbLines.Controls.Add(gpTransaction_L1)
        gbLines.Location = New Point(11, 8)
        gbLines.Margin = New Padding(2, 1, 2, 1)
        gbLines.Name = "gbLines"
        gbLines.Padding = New Padding(2, 1, 2, 1)
        gbLines.Size = New Size(1352, 545)
        gbLines.TabIndex = 3
        gbLines.TabStop = False
        ' 
        ' gpTransaction_L3
        ' 
        gpTransaction_L3.Controls.Add(txtDailyTadrosDisbursment)
        gpTransaction_L3.Controls.Add(lblDailyTadrossGross)
        gpTransaction_L3.Controls.Add(Label4)
        gpTransaction_L3.Controls.Add(txtNet_L33)
        gpTransaction_L3.Controls.Add(Label30)
        gpTransaction_L3.Controls.Add(txtGrossD_L33)
        gpTransaction_L3.Controls.Add(Label32)
        gpTransaction_L3.Controls.Add(txtCurrency_L33)
        gpTransaction_L3.Controls.Add(Label25)
        gpTransaction_L3.Controls.Add(txtNet_L32)
        gpTransaction_L3.Controls.Add(Label26)
        gpTransaction_L3.Controls.Add(txtGrossDailyTadrossDisbursment)
        gpTransaction_L3.Controls.Add(Label27)
        gpTransaction_L3.Controls.Add(txtGrossD_L32)
        gpTransaction_L3.Controls.Add(Label28)
        gpTransaction_L3.Controls.Add(txtCurrency_L32)
        gpTransaction_L3.Controls.Add(Label20)
        gpTransaction_L3.Controls.Add(Label21)
        gpTransaction_L3.Controls.Add(txtNet_L31)
        gpTransaction_L3.Controls.Add(Label22)
        gpTransaction_L3.Controls.Add(txtTadrossIncome)
        gpTransaction_L3.Controls.Add(lblPercentageTadross)
        gpTransaction_L3.Controls.Add(txtGrossD_L31)
        gpTransaction_L3.Controls.Add(Label24)
        gpTransaction_L3.Controls.Add(txtCurrency_L31)
        gpTransaction_L3.Controls.Add(txtProvider_L3)
        gpTransaction_L3.Location = New Point(13, 299)
        gpTransaction_L3.Margin = New Padding(2, 1, 2, 1)
        gpTransaction_L3.Name = "gpTransaction_L3"
        gpTransaction_L3.Padding = New Padding(2, 1, 2, 1)
        gpTransaction_L3.Size = New Size(1310, 236)
        gpTransaction_L3.TabIndex = 13
        gpTransaction_L3.TabStop = False
        gpTransaction_L3.Text = "Line 3"
        ' 
        ' txtDailyTadrosDisbursment
        ' 
        txtDailyTadrosDisbursment.BackColor = SystemColors.HighlightText
        txtDailyTadrosDisbursment.BorderStyle = BorderStyle.FixedSingle
        txtDailyTadrosDisbursment.Font = New Font("Segoe UI", 10.125F)
        txtDailyTadrosDisbursment.Location = New Point(438, 33)
        txtDailyTadrosDisbursment.Margin = New Padding(2, 1, 2, 1)
        txtDailyTadrosDisbursment.Name = "txtDailyTadrosDisbursment"
        txtDailyTadrosDisbursment.Size = New Size(230, 30)
        txtDailyTadrosDisbursment.TabIndex = 45
        txtDailyTadrosDisbursment.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblDailyTadrossGross
        ' 
        lblDailyTadrossGross.AutoSize = True
        lblDailyTadrossGross.Location = New Point(305, 37)
        lblDailyTadrossGross.Margin = New Padding(2, 0, 2, 0)
        lblDailyTadrossGross.Name = "lblDailyTadrossGross"
        lblDailyTadrossGross.Size = New Size(133, 20)
        lblDailyTadrossGross.TabIndex = 44
        lblDailyTadrossGross.Text = "Daily Disbursment:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 194)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 20)
        Label4.TabIndex = 43
        Label4.Text = "Currency:"
        ' 
        ' txtNet_L33
        ' 
        txtNet_L33.BackColor = SystemColors.HighlightText
        txtNet_L33.BorderStyle = BorderStyle.FixedSingle
        txtNet_L33.Font = New Font("Segoe UI", 10.125F)
        txtNet_L33.ForeColor = Color.OrangeRed
        txtNet_L33.Location = New Point(1036, 189)
        txtNet_L33.Margin = New Padding(2, 1, 2, 1)
        txtNet_L33.Name = "txtNet_L33"
        txtNet_L33.Size = New Size(250, 30)
        txtNet_L33.TabIndex = 41
        txtNet_L33.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.ForeColor = Color.OrangeRed
        Label30.Location = New Point(858, 194)
        Label30.Margin = New Padding(2, 0, 2, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(168, 20)
        Label30.TabIndex = 40
        Label30.Text = "Total Net Disbursement:"
        ' 
        ' txtGrossD_L33
        ' 
        txtGrossD_L33.BackColor = SystemColors.HighlightText
        txtGrossD_L33.BorderStyle = BorderStyle.FixedSingle
        txtGrossD_L33.Font = New Font("Segoe UI", 10.125F)
        txtGrossD_L33.Location = New Point(478, 189)
        txtGrossD_L33.Margin = New Padding(2, 1, 2, 1)
        txtGrossD_L33.Name = "txtGrossD_L33"
        txtGrossD_L33.Size = New Size(250, 30)
        txtGrossD_L33.TabIndex = 37
        txtGrossD_L33.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(326, 194)
        Label32.Margin = New Padding(2, 0, 2, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(143, 20)
        Label32.TabIndex = 36
        Label32.Text = "Gross Disbursement:"
        ' 
        ' txtCurrency_L33
        ' 
        txtCurrency_L33.BackColor = SystemColors.HighlightText
        txtCurrency_L33.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_L33.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_L33.Location = New Point(93, 189)
        txtCurrency_L33.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_L33.Name = "txtCurrency_L33"
        txtCurrency_L33.Size = New Size(97, 30)
        txtCurrency_L33.TabIndex = 35
        txtCurrency_L33.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(15, 154)
        Label25.Margin = New Padding(2, 0, 2, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(69, 20)
        Label25.TabIndex = 34
        Label25.Text = "Currency:"
        ' 
        ' txtNet_L32
        ' 
        txtNet_L32.BackColor = SystemColors.HighlightText
        txtNet_L32.BorderStyle = BorderStyle.FixedSingle
        txtNet_L32.Font = New Font("Segoe UI", 10.125F)
        txtNet_L32.ForeColor = Color.OrangeRed
        txtNet_L32.Location = New Point(1036, 149)
        txtNet_L32.Margin = New Padding(2, 1, 2, 1)
        txtNet_L32.Name = "txtNet_L32"
        txtNet_L32.Size = New Size(250, 30)
        txtNet_L32.TabIndex = 33
        txtNet_L32.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.ForeColor = Color.OrangeRed
        Label26.Location = New Point(858, 154)
        Label26.Margin = New Padding(2, 0, 2, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(168, 20)
        Label26.TabIndex = 32
        Label26.Text = "Total Net Disbursement:"
        ' 
        ' txtGrossDailyTadrossDisbursment
        ' 
        txtGrossDailyTadrossDisbursment.BackColor = SystemColors.HighlightText
        txtGrossDailyTadrossDisbursment.BorderStyle = BorderStyle.FixedSingle
        txtGrossDailyTadrossDisbursment.Font = New Font("Segoe UI", 10.125F)
        txtGrossDailyTadrossDisbursment.Location = New Point(1036, 33)
        txtGrossDailyTadrossDisbursment.Margin = New Padding(2, 1, 2, 1)
        txtGrossDailyTadrossDisbursment.Name = "txtGrossDailyTadrossDisbursment"
        txtGrossDailyTadrossDisbursment.Size = New Size(250, 30)
        txtGrossDailyTadrossDisbursment.TabIndex = 31
        txtGrossDailyTadrossDisbursment.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(864, 37)
        Label27.Margin = New Padding(2, 0, 2, 0)
        Label27.Name = "Label27"
        Label27.Size = New Size(173, 20)
        Label27.TabIndex = 30
        Label27.Text = "Gross Daily Disbursment:"
        ' 
        ' txtGrossD_L32
        ' 
        txtGrossD_L32.BackColor = SystemColors.HighlightText
        txtGrossD_L32.BorderStyle = BorderStyle.FixedSingle
        txtGrossD_L32.Font = New Font("Segoe UI", 10.125F)
        txtGrossD_L32.Location = New Point(478, 149)
        txtGrossD_L32.Margin = New Padding(2, 1, 2, 1)
        txtGrossD_L32.Name = "txtGrossD_L32"
        txtGrossD_L32.Size = New Size(250, 30)
        txtGrossD_L32.TabIndex = 29
        txtGrossD_L32.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(326, 154)
        Label28.Margin = New Padding(2, 0, 2, 0)
        Label28.Name = "Label28"
        Label28.Size = New Size(143, 20)
        Label28.TabIndex = 28
        Label28.Text = "Gross Disbursement:"
        ' 
        ' txtCurrency_L32
        ' 
        txtCurrency_L32.BackColor = SystemColors.HighlightText
        txtCurrency_L32.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_L32.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_L32.Location = New Point(93, 149)
        txtCurrency_L32.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_L32.Name = "txtCurrency_L32"
        txtCurrency_L32.Size = New Size(97, 30)
        txtCurrency_L32.TabIndex = 27
        txtCurrency_L32.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(15, 37)
        Label20.Margin = New Padding(2, 0, 2, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(67, 20)
        Label20.TabIndex = 26
        Label20.Text = "Provider:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(15, 115)
        Label21.Margin = New Padding(2, 0, 2, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(69, 20)
        Label21.TabIndex = 25
        Label21.Text = "Currency:"
        ' 
        ' txtNet_L31
        ' 
        txtNet_L31.BackColor = SystemColors.HighlightText
        txtNet_L31.BorderStyle = BorderStyle.FixedSingle
        txtNet_L31.Font = New Font("Segoe UI", 10.125F)
        txtNet_L31.ForeColor = Color.OrangeRed
        txtNet_L31.Location = New Point(1036, 110)
        txtNet_L31.Margin = New Padding(2, 1, 2, 1)
        txtNet_L31.Name = "txtNet_L31"
        txtNet_L31.Size = New Size(250, 30)
        txtNet_L31.TabIndex = 24
        txtNet_L31.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.ForeColor = Color.OrangeRed
        Label22.Location = New Point(858, 115)
        Label22.Margin = New Padding(2, 0, 2, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(168, 20)
        Label22.TabIndex = 23
        Label22.Text = "Total Net Disbursement:"
        ' 
        ' txtTadrossIncome
        ' 
        txtTadrossIncome.BackColor = SystemColors.HighlightText
        txtTadrossIncome.BorderStyle = BorderStyle.FixedSingle
        txtTadrossIncome.Font = New Font("Segoe UI", 10.125F)
        txtTadrossIncome.Location = New Point(754, 33)
        txtTadrossIncome.Margin = New Padding(2, 1, 2, 1)
        txtTadrossIncome.Name = "txtTadrossIncome"
        txtTadrossIncome.Size = New Size(97, 30)
        txtTadrossIncome.TabIndex = 22
        txtTadrossIncome.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblPercentageTadross
        ' 
        lblPercentageTadross.AutoSize = True
        lblPercentageTadross.Location = New Point(677, 37)
        lblPercentageTadross.Margin = New Padding(2, 0, 2, 0)
        lblPercentageTadross.Name = "lblPercentageTadross"
        lblPercentageTadross.Size = New Size(77, 20)
        lblPercentageTadross.TabIndex = 21
        lblPercentageTadross.Text = "% Income:"
        ' 
        ' txtGrossD_L31
        ' 
        txtGrossD_L31.BackColor = SystemColors.HighlightText
        txtGrossD_L31.BorderStyle = BorderStyle.FixedSingle
        txtGrossD_L31.Font = New Font("Segoe UI", 10.125F)
        txtGrossD_L31.Location = New Point(478, 110)
        txtGrossD_L31.Margin = New Padding(2, 1, 2, 1)
        txtGrossD_L31.Name = "txtGrossD_L31"
        txtGrossD_L31.Size = New Size(250, 30)
        txtGrossD_L31.TabIndex = 20
        txtGrossD_L31.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(326, 115)
        Label24.Margin = New Padding(2, 0, 2, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(143, 20)
        Label24.TabIndex = 19
        Label24.Text = "Gross Disbursement:"
        ' 
        ' txtCurrency_L31
        ' 
        txtCurrency_L31.BackColor = SystemColors.HighlightText
        txtCurrency_L31.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_L31.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_L31.Location = New Point(93, 110)
        txtCurrency_L31.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_L31.Name = "txtCurrency_L31"
        txtCurrency_L31.Size = New Size(97, 30)
        txtCurrency_L31.TabIndex = 18
        txtCurrency_L31.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtProvider_L3
        ' 
        txtProvider_L3.BackColor = SystemColors.HighlightText
        txtProvider_L3.BorderStyle = BorderStyle.FixedSingle
        txtProvider_L3.Font = New Font("Segoe UI", 10.125F)
        txtProvider_L3.Location = New Point(93, 33)
        txtProvider_L3.Margin = New Padding(2, 1, 2, 1)
        txtProvider_L3.Name = "txtProvider_L3"
        txtProvider_L3.Size = New Size(197, 30)
        txtProvider_L3.TabIndex = 17
        txtProvider_L3.TextAlign = HorizontalAlignment.Right
        ' 
        ' gpTransaction_L2
        ' 
        gpTransaction_L2.Controls.Add(Label15)
        gpTransaction_L2.Controls.Add(Label16)
        gpTransaction_L2.Controls.Add(txtNet_L2)
        gpTransaction_L2.Controls.Add(Label17)
        gpTransaction_L2.Controls.Add(txtGas_L2)
        gpTransaction_L2.Controls.Add(Label18)
        gpTransaction_L2.Controls.Add(txtGrossD_L2)
        gpTransaction_L2.Controls.Add(Label19)
        gpTransaction_L2.Controls.Add(txtCurrency_L2)
        gpTransaction_L2.Controls.Add(txtProvider_L2)
        gpTransaction_L2.Location = New Point(13, 159)
        gpTransaction_L2.Margin = New Padding(2, 1, 2, 1)
        gpTransaction_L2.Name = "gpTransaction_L2"
        gpTransaction_L2.Padding = New Padding(2, 1, 2, 1)
        gpTransaction_L2.Size = New Size(1309, 120)
        gpTransaction_L2.TabIndex = 12
        gpTransaction_L2.TabStop = False
        gpTransaction_L2.Text = "Line 2"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(16, 33)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 20)
        Label15.TabIndex = 26
        Label15.Text = "Provider:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(562, 34)
        Label16.Margin = New Padding(2, 0, 2, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(69, 20)
        Label16.TabIndex = 25
        Label16.Text = "Currency:"
        ' 
        ' txtNet_L2
        ' 
        txtNet_L2.BackColor = SystemColors.HighlightText
        txtNet_L2.BorderStyle = BorderStyle.FixedSingle
        txtNet_L2.Font = New Font("Segoe UI", 10.125F)
        txtNet_L2.Location = New Point(1036, 69)
        txtNet_L2.Margin = New Padding(2, 1, 2, 1)
        txtNet_L2.Name = "txtNet_L2"
        txtNet_L2.Size = New Size(250, 30)
        txtNet_L2.TabIndex = 24
        txtNet_L2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(896, 76)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(131, 20)
        Label17.TabIndex = 23
        Label17.Text = "Net Disbursement:"
        ' 
        ' txtGas_L2
        ' 
        txtGas_L2.BackColor = SystemColors.HighlightText
        txtGas_L2.BorderStyle = BorderStyle.FixedSingle
        txtGas_L2.Font = New Font("Segoe UI", 10.125F)
        txtGas_L2.Location = New Point(639, 71)
        txtGas_L2.Margin = New Padding(2, 1, 2, 1)
        txtGas_L2.Name = "txtGas_L2"
        txtGas_L2.Size = New Size(97, 30)
        txtGas_L2.TabIndex = 22
        txtGas_L2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(568, 75)
        Label18.Margin = New Padding(2, 0, 2, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(63, 20)
        Label18.TabIndex = 21
        Label18.Text = "Gas Fee:"
        ' 
        ' txtGrossD_L2
        ' 
        txtGrossD_L2.BackColor = SystemColors.HighlightText
        txtGrossD_L2.BorderStyle = BorderStyle.FixedSingle
        txtGrossD_L2.Font = New Font("Segoe UI", 10.125F)
        txtGrossD_L2.Location = New Point(161, 71)
        txtGrossD_L2.Margin = New Padding(2, 1, 2, 1)
        txtGrossD_L2.Name = "txtGrossD_L2"
        txtGrossD_L2.Size = New Size(231, 30)
        txtGrossD_L2.TabIndex = 20
        txtGrossD_L2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(14, 76)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(143, 20)
        Label19.TabIndex = 19
        Label19.Text = "Gross Disbursement:"
        ' 
        ' txtCurrency_L2
        ' 
        txtCurrency_L2.BackColor = SystemColors.HighlightText
        txtCurrency_L2.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_L2.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_L2.Location = New Point(639, 29)
        txtCurrency_L2.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_L2.Name = "txtCurrency_L2"
        txtCurrency_L2.Size = New Size(97, 30)
        txtCurrency_L2.TabIndex = 18
        txtCurrency_L2.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtProvider_L2
        ' 
        txtProvider_L2.BackColor = SystemColors.HighlightText
        txtProvider_L2.BorderStyle = BorderStyle.FixedSingle
        txtProvider_L2.Font = New Font("Segoe UI", 10.125F)
        txtProvider_L2.Location = New Point(161, 29)
        txtProvider_L2.Margin = New Padding(2, 1, 2, 1)
        txtProvider_L2.Name = "txtProvider_L2"
        txtProvider_L2.Size = New Size(229, 30)
        txtProvider_L2.TabIndex = 17
        txtProvider_L2.TextAlign = HorizontalAlignment.Right
        ' 
        ' gpTransaction_L1
        ' 
        gpTransaction_L1.Controls.Add(Label10)
        gpTransaction_L1.Controls.Add(Label11)
        gpTransaction_L1.Controls.Add(txtNet_L1)
        gpTransaction_L1.Controls.Add(Label12)
        gpTransaction_L1.Controls.Add(txtGas_L1)
        gpTransaction_L1.Controls.Add(Label13)
        gpTransaction_L1.Controls.Add(txtGrossD_L1)
        gpTransaction_L1.Controls.Add(Label14)
        gpTransaction_L1.Controls.Add(txtCurrency_L1)
        gpTransaction_L1.Controls.Add(txtProvider_L1)
        gpTransaction_L1.Location = New Point(11, 25)
        gpTransaction_L1.Margin = New Padding(2, 1, 2, 1)
        gpTransaction_L1.Name = "gpTransaction_L1"
        gpTransaction_L1.Padding = New Padding(2, 1, 2, 1)
        gpTransaction_L1.Size = New Size(1310, 115)
        gpTransaction_L1.TabIndex = 11
        gpTransaction_L1.TabStop = False
        gpTransaction_L1.Text = "Line 1"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(15, 31)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 20)
        Label10.TabIndex = 26
        Label10.Text = "Provider:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(570, 32)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 20)
        Label11.TabIndex = 25
        Label11.Text = "Currency:"
        ' 
        ' txtNet_L1
        ' 
        txtNet_L1.BackColor = SystemColors.HighlightText
        txtNet_L1.BorderStyle = BorderStyle.FixedSingle
        txtNet_L1.Font = New Font("Segoe UI", 10.125F)
        txtNet_L1.Location = New Point(1036, 67)
        txtNet_L1.Margin = New Padding(2, 1, 2, 1)
        txtNet_L1.Name = "txtNet_L1"
        txtNet_L1.Size = New Size(250, 30)
        txtNet_L1.TabIndex = 24
        txtNet_L1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(896, 72)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(131, 20)
        Label12.TabIndex = 23
        Label12.Text = "Net Disbursement:"
        ' 
        ' txtGas_L1
        ' 
        txtGas_L1.BackColor = SystemColors.HighlightText
        txtGas_L1.BorderStyle = BorderStyle.FixedSingle
        txtGas_L1.Font = New Font("Segoe UI", 10.125F)
        txtGas_L1.Location = New Point(647, 68)
        txtGas_L1.Margin = New Padding(2, 1, 2, 1)
        txtGas_L1.Name = "txtGas_L1"
        txtGas_L1.Size = New Size(97, 30)
        txtGas_L1.TabIndex = 22
        txtGas_L1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(575, 74)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(63, 20)
        Label13.TabIndex = 21
        Label13.Text = "Gas Fee:"
        ' 
        ' txtGrossD_L1
        ' 
        txtGrossD_L1.BackColor = SystemColors.HighlightText
        txtGrossD_L1.BorderStyle = BorderStyle.FixedSingle
        txtGrossD_L1.Font = New Font("Segoe UI", 10.125F)
        txtGrossD_L1.Location = New Point(161, 69)
        txtGrossD_L1.Margin = New Padding(2, 1, 2, 1)
        txtGrossD_L1.Name = "txtGrossD_L1"
        txtGrossD_L1.Size = New Size(234, 30)
        txtGrossD_L1.TabIndex = 20
        txtGrossD_L1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(14, 73)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(143, 20)
        Label14.TabIndex = 19
        Label14.Text = "Gross Disbursement:"
        ' 
        ' txtCurrency_L1
        ' 
        txtCurrency_L1.BackColor = SystemColors.HighlightText
        txtCurrency_L1.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_L1.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_L1.Location = New Point(647, 27)
        txtCurrency_L1.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_L1.Name = "txtCurrency_L1"
        txtCurrency_L1.Size = New Size(97, 30)
        txtCurrency_L1.TabIndex = 18
        txtCurrency_L1.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtProvider_L1
        ' 
        txtProvider_L1.BackColor = SystemColors.HighlightText
        txtProvider_L1.BorderStyle = BorderStyle.FixedSingle
        txtProvider_L1.Font = New Font("Segoe UI", 10.125F)
        txtProvider_L1.Location = New Point(161, 28)
        txtProvider_L1.Margin = New Padding(2, 1, 2, 1)
        txtProvider_L1.Name = "txtProvider_L1"
        txtProvider_L1.Size = New Size(232, 30)
        txtProvider_L1.TabIndex = 17
        txtProvider_L1.TextAlign = HorizontalAlignment.Right
        ' 
        ' tpCommissions
        ' 
        tpCommissions.Controls.Add(gbCommissions)
        tpCommissions.Location = New Point(4, 34)
        tpCommissions.Name = "tpCommissions"
        tpCommissions.Size = New Size(1397, 570)
        tpCommissions.TabIndex = 2
        tpCommissions.Text = "Commissions"
        tpCommissions.UseVisualStyleBackColor = True
        ' 
        ' gbCommissions
        ' 
        gbCommissions.Controls.Add(dgvCommissions)
        gbCommissions.Location = New Point(29, 9)
        gbCommissions.Margin = New Padding(2, 1, 2, 1)
        gbCommissions.Name = "gbCommissions"
        gbCommissions.Padding = New Padding(2, 1, 2, 1)
        gbCommissions.Size = New Size(1336, 541)
        gbCommissions.TabIndex = 1
        gbCommissions.TabStop = False
        ' 
        ' dgvCommissions
        ' 
        dgvCommissions.BackgroundColor = SystemColors.ControlLightLight
        dgvCommissions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCommissions.Location = New Point(12, 29)
        dgvCommissions.Name = "dgvCommissions"
        dgvCommissions.RowHeadersWidth = 51
        dgvCommissions.Size = New Size(1311, 445)
        dgvCommissions.TabIndex = 0
        ' 
        ' gbTransaction
        ' 
        gbTransaction.BackColor = Color.Lavender
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
        gbTransaction.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbTransaction.Location = New Point(20, 13)
        gbTransaction.Margin = New Padding(2, 1, 2, 1)
        gbTransaction.Name = "gbTransaction"
        gbTransaction.Padding = New Padding(2, 1, 2, 1)
        gbTransaction.Size = New Size(1390, 237)
        gbTransaction.TabIndex = 3
        gbTransaction.TabStop = False
        gbTransaction.Tag = ""
        gbTransaction.Text = "Transaction"
        ' 
        ' btnNewCurrency
        ' 
        btnNewCurrency.Location = New Point(516, 142)
        btnNewCurrency.Name = "btnNewCurrency"
        btnNewCurrency.Size = New Size(30, 35)
        btnNewCurrency.TabIndex = 19
        btnNewCurrency.Text = "+"
        btnNewCurrency.UseVisualStyleBackColor = True
        ' 
        ' cmbProvider_T
        ' 
        cmbProvider_T.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProvider_T.FormattingEnabled = True
        cmbProvider_T.Location = New Point(160, 102)
        cmbProvider_T.Name = "cmbProvider_T"
        cmbProvider_T.Size = New Size(338, 31)
        cmbProvider_T.TabIndex = 18
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(1191, 174)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(178, 44)
        btnSave.TabIndex = 17
        btnSave.Text = "Create Transaction"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(1191, 117)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(178, 44)
        btnCalculate.TabIndex = 16
        btnCalculate.Text = "Re-Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1191, 59)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(178, 44)
        btnClear.TabIndex = 15
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
        dtpTransactionDate_T.Location = New Point(793, 58)
        dtpTransactionDate_T.Margin = New Padding(2, 1, 2, 1)
        dtpTransactionDate_T.Name = "dtpTransactionDate_T"
        dtpTransactionDate_T.Size = New Size(289, 34)
        dtpTransactionDate_T.TabIndex = 14
        ' 
        ' lblTranches
        ' 
        lblTranches.AutoSize = True
        lblTranches.Font = New Font("Segoe UI", 10.125F)
        lblTranches.Location = New Point(585, 190)
        lblTranches.Margin = New Padding(2, 0, 2, 0)
        lblTranches.Name = "lblTranches"
        lblTranches.Size = New Size(155, 23)
        lblTranches.TabIndex = 13
        lblTranches.Text = "Tranches Executed:"
        ' 
        ' lblNumberOfBTC
        ' 
        lblNumberOfBTC.AutoSize = True
        lblNumberOfBTC.Font = New Font("Segoe UI", 10.125F)
        lblNumberOfBTC.Location = New Point(585, 148)
        lblNumberOfBTC.Margin = New Padding(2, 0, 2, 0)
        lblNumberOfBTC.Name = "lblNumberOfBTC"
        lblNumberOfBTC.Size = New Size(130, 23)
        lblNumberOfBTC.TabIndex = 12
        lblNumberOfBTC.Text = "Number of BTC:"
        ' 
        ' lblFinalSwapTranchePrice
        ' 
        lblFinalSwapTranchePrice.AutoSize = True
        lblFinalSwapTranchePrice.Font = New Font("Segoe UI", 10.125F)
        lblFinalSwapTranchePrice.Location = New Point(585, 105)
        lblFinalSwapTranchePrice.Margin = New Padding(2, 0, 2, 0)
        lblFinalSwapTranchePrice.Name = "lblFinalSwapTranchePrice"
        lblFinalSwapTranchePrice.Size = New Size(201, 23)
        lblFinalSwapTranchePrice.TabIndex = 11
        lblFinalSwapTranchePrice.Text = "Final Swap Tranche Price:"
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 10.125F)
        lblTransactionDate.Location = New Point(585, 64)
        lblTransactionDate.Margin = New Padding(2, 0, 2, 0)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(142, 23)
        lblTransactionDate.TabIndex = 10
        lblTransactionDate.Text = "Transaction Date:"
        ' 
        ' lblCurrency_T
        ' 
        lblCurrency_T.AutoSize = True
        lblCurrency_T.Font = New Font("Segoe UI", 10.125F)
        lblCurrency_T.Location = New Point(36, 143)
        lblCurrency_T.Margin = New Padding(2, 0, 2, 0)
        lblCurrency_T.Name = "lblCurrency_T"
        lblCurrency_T.Size = New Size(82, 23)
        lblCurrency_T.TabIndex = 9
        lblCurrency_T.Text = "Currency:"
        ' 
        ' lblProvider_T
        ' 
        lblProvider_T.AutoSize = True
        lblProvider_T.Font = New Font("Segoe UI", 10.125F)
        lblProvider_T.Location = New Point(36, 105)
        lblProvider_T.Margin = New Padding(2, 0, 2, 0)
        lblProvider_T.Name = "lblProvider_T"
        lblProvider_T.Size = New Size(77, 23)
        lblProvider_T.TabIndex = 8
        lblProvider_T.Text = "Provider:"
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        lblTransactionID.Font = New Font("Segoe UI", 10.125F)
        lblTransactionID.Location = New Point(36, 63)
        lblTransactionID.Margin = New Padding(2, 0, 2, 0)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(118, 23)
        lblTransactionID.TabIndex = 7
        lblTransactionID.Text = "TransactionID:"
        ' 
        ' txtTranchesExecute_T
        ' 
        txtTranchesExecute_T.BackColor = SystemColors.HighlightText
        txtTranchesExecute_T.BorderStyle = BorderStyle.FixedSingle
        txtTranchesExecute_T.Font = New Font("Segoe UI", 10.125F)
        txtTranchesExecute_T.Location = New Point(791, 185)
        txtTranchesExecute_T.Margin = New Padding(2, 1, 2, 1)
        txtTranchesExecute_T.Name = "txtTranchesExecute_T"
        txtTranchesExecute_T.Size = New Size(289, 30)
        txtTranchesExecute_T.TabIndex = 6
        txtTranchesExecute_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtumberofBTC_T
        ' 
        txtumberofBTC_T.BackColor = SystemColors.HighlightText
        txtumberofBTC_T.BorderStyle = BorderStyle.FixedSingle
        txtumberofBTC_T.Font = New Font("Segoe UI", 10.125F)
        txtumberofBTC_T.Location = New Point(793, 142)
        txtumberofBTC_T.Margin = New Padding(2, 1, 2, 1)
        txtumberofBTC_T.Name = "txtumberofBTC_T"
        txtumberofBTC_T.Size = New Size(288, 30)
        txtumberofBTC_T.TabIndex = 5
        txtumberofBTC_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtFinalSwapTranchePrice_T
        ' 
        txtFinalSwapTranchePrice_T.BackColor = SystemColors.HighlightText
        txtFinalSwapTranchePrice_T.BorderStyle = BorderStyle.FixedSingle
        txtFinalSwapTranchePrice_T.Font = New Font("Segoe UI", 10.125F)
        txtFinalSwapTranchePrice_T.Location = New Point(793, 101)
        txtFinalSwapTranchePrice_T.Margin = New Padding(2, 1, 2, 1)
        txtFinalSwapTranchePrice_T.Name = "txtFinalSwapTranchePrice_T"
        txtFinalSwapTranchePrice_T.Size = New Size(288, 30)
        txtFinalSwapTranchePrice_T.TabIndex = 4
        txtFinalSwapTranchePrice_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTransactionID_T
        ' 
        txtTransactionID_T.BackColor = SystemColors.HighlightText
        txtTransactionID_T.BorderStyle = BorderStyle.FixedSingle
        txtTransactionID_T.Font = New Font("Segoe UI", 10.125F)
        txtTransactionID_T.Location = New Point(160, 59)
        txtTransactionID_T.Margin = New Padding(2, 1, 2, 1)
        txtTransactionID_T.Name = "txtTransactionID_T"
        txtTransactionID_T.ReadOnly = True
        txtTransactionID_T.Size = New Size(338, 30)
        txtTransactionID_T.TabIndex = 2
        txtTransactionID_T.TextAlign = HorizontalAlignment.Right
        ' 
        ' cmbCurrency_T
        ' 
        cmbCurrency_T.BackColor = SystemColors.HighlightText
        cmbCurrency_T.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency_T.FlatStyle = FlatStyle.System
        cmbCurrency_T.Font = New Font("Segoe UI", 10.125F)
        cmbCurrency_T.FormattingEnabled = True
        cmbCurrency_T.Location = New Point(160, 143)
        cmbCurrency_T.Margin = New Padding(2, 1, 2, 1)
        cmbCurrency_T.Name = "cmbCurrency_T"
        cmbCurrency_T.Size = New Size(338, 31)
        cmbCurrency_T.TabIndex = 1
        ' 
        ' txtCurrency_C2C_USDT
        ' 
        txtCurrency_C2C_USDT.AcceptsReturn = True
        txtCurrency_C2C_USDT.BackColor = SystemColors.HighlightText
        txtCurrency_C2C_USDT.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_C2C_USDT.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_C2C_USDT.Location = New Point(347, 65)
        txtCurrency_C2C_USDT.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_C2C_USDT.Name = "txtCurrency_C2C_USDT"
        txtCurrency_C2C_USDT.Size = New Size(97, 30)
        txtCurrency_C2C_USDT.TabIndex = 44
        txtCurrency_C2C_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(462, 69)
        Label33.Margin = New Padding(2, 0, 2, 0)
        Label33.Name = "Label33"
        Label33.Size = New Size(143, 20)
        Label33.TabIndex = 45
        ' 
        ' txtGross_C2C_USDT
        ' 
        txtGross_C2C_USDT.BackColor = SystemColors.HighlightText
        txtGross_C2C_USDT.BorderStyle = BorderStyle.FixedSingle
        txtGross_C2C_USDT.Font = New Font("Segoe UI", 10.125F)
        txtGross_C2C_USDT.Location = New Point(665, 65)
        txtGross_C2C_USDT.Margin = New Padding(2, 1, 2, 1)
        txtGross_C2C_USDT.Name = "txtGross_C2C_USDT"
        txtGross_C2C_USDT.Size = New Size(205, 30)
        txtGross_C2C_USDT.TabIndex = 46
        txtGross_C2C_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(255, 69)
        Label29.Margin = New Padding(2, 0, 2, 0)
        Label29.Name = "Label29"
        Label29.Size = New Size(69, 20)
        Label29.TabIndex = 47
        ' 
        ' txtCurrency_C2C_BTC
        ' 
        txtCurrency_C2C_BTC.BackColor = SystemColors.HighlightText
        txtCurrency_C2C_BTC.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_C2C_BTC.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_C2C_BTC.Location = New Point(347, 108)
        txtCurrency_C2C_BTC.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_C2C_BTC.Name = "txtCurrency_C2C_BTC"
        txtCurrency_C2C_BTC.Size = New Size(97, 30)
        txtCurrency_C2C_BTC.TabIndex = 48
        txtCurrency_C2C_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtGross_C2C_BTC
        ' 
        txtGross_C2C_BTC.BackColor = SystemColors.HighlightText
        txtGross_C2C_BTC.BorderStyle = BorderStyle.FixedSingle
        txtGross_C2C_BTC.Font = New Font("Segoe UI", 10.125F)
        txtGross_C2C_BTC.Location = New Point(665, 108)
        txtGross_C2C_BTC.Margin = New Padding(2, 1, 2, 1)
        txtGross_C2C_BTC.Name = "txtGross_C2C_BTC"
        txtGross_C2C_BTC.Size = New Size(205, 30)
        txtGross_C2C_BTC.TabIndex = 50
        txtGross_C2C_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtCurrency_PAG_USDT
        ' 
        txtCurrency_PAG_USDT.BackColor = SystemColors.HighlightText
        txtCurrency_PAG_USDT.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_PAG_USDT.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_PAG_USDT.Location = New Point(347, 149)
        txtCurrency_PAG_USDT.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_PAG_USDT.Name = "txtCurrency_PAG_USDT"
        txtCurrency_PAG_USDT.Size = New Size(97, 30)
        txtCurrency_PAG_USDT.TabIndex = 52
        txtCurrency_PAG_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(462, 149)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 20)
        Label6.TabIndex = 53
        ' 
        ' txtGross_PAG_USDT
        ' 
        txtGross_PAG_USDT.BackColor = SystemColors.HighlightText
        txtGross_PAG_USDT.BorderStyle = BorderStyle.FixedSingle
        txtGross_PAG_USDT.Font = New Font("Segoe UI", 10.125F)
        txtGross_PAG_USDT.Location = New Point(665, 149)
        txtGross_PAG_USDT.Margin = New Padding(2, 1, 2, 1)
        txtGross_PAG_USDT.Name = "txtGross_PAG_USDT"
        txtGross_PAG_USDT.Size = New Size(205, 30)
        txtGross_PAG_USDT.TabIndex = 54
        txtGross_PAG_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(255, 149)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 55
        ' 
        ' txtCurrency_PAG_BTC
        ' 
        txtCurrency_PAG_BTC.BackColor = SystemColors.HighlightText
        txtCurrency_PAG_BTC.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_PAG_BTC.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_PAG_BTC.Location = New Point(347, 188)
        txtCurrency_PAG_BTC.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_PAG_BTC.Name = "txtCurrency_PAG_BTC"
        txtCurrency_PAG_BTC.Size = New Size(97, 30)
        txtCurrency_PAG_BTC.TabIndex = 56
        txtCurrency_PAG_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtGross_PAG_BTC
        ' 
        txtGross_PAG_BTC.BackColor = SystemColors.HighlightText
        txtGross_PAG_BTC.BorderStyle = BorderStyle.FixedSingle
        txtGross_PAG_BTC.Font = New Font("Segoe UI", 10.125F)
        txtGross_PAG_BTC.Location = New Point(665, 191)
        txtGross_PAG_BTC.Margin = New Padding(2, 1, 2, 1)
        txtGross_PAG_BTC.Name = "txtGross_PAG_BTC"
        txtGross_PAG_BTC.Size = New Size(205, 30)
        txtGross_PAG_BTC.TabIndex = 58
        txtGross_PAG_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtCurrency_Charity
        ' 
        txtCurrency_Charity.BackColor = SystemColors.HighlightText
        txtCurrency_Charity.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_Charity.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_Charity.Location = New Point(347, 229)
        txtCurrency_Charity.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_Charity.Name = "txtCurrency_Charity"
        txtCurrency_Charity.Size = New Size(97, 30)
        txtCurrency_Charity.TabIndex = 60
        txtCurrency_Charity.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(462, 231)
        Label37.Margin = New Padding(2, 0, 2, 0)
        Label37.Name = "Label37"
        Label37.Size = New Size(143, 20)
        Label37.TabIndex = 61
        ' 
        ' txtGross_Charity
        ' 
        txtGross_Charity.BackColor = SystemColors.HighlightText
        txtGross_Charity.BorderStyle = BorderStyle.FixedSingle
        txtGross_Charity.Font = New Font("Segoe UI", 10.125F)
        txtGross_Charity.Location = New Point(665, 229)
        txtGross_Charity.Margin = New Padding(2, 1, 2, 1)
        txtGross_Charity.Name = "txtGross_Charity"
        txtGross_Charity.Size = New Size(205, 30)
        txtGross_Charity.TabIndex = 62
        txtGross_Charity.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Location = New Point(255, 231)
        Label36.Margin = New Padding(2, 0, 2, 0)
        Label36.Name = "Label36"
        Label36.Size = New Size(69, 20)
        Label36.TabIndex = 63
        ' 
        ' txtCurrency_IGL_USDT
        ' 
        txtCurrency_IGL_USDT.BackColor = SystemColors.HighlightText
        txtCurrency_IGL_USDT.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_IGL_USDT.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_IGL_USDT.Location = New Point(347, 272)
        txtCurrency_IGL_USDT.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_IGL_USDT.Name = "txtCurrency_IGL_USDT"
        txtCurrency_IGL_USDT.Size = New Size(97, 30)
        txtCurrency_IGL_USDT.TabIndex = 64
        txtCurrency_IGL_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Location = New Point(462, 272)
        Label35.Margin = New Padding(2, 0, 2, 0)
        Label35.Name = "Label35"
        Label35.Size = New Size(143, 20)
        Label35.TabIndex = 65
        ' 
        ' txtGross_IGL_USDT
        ' 
        txtGross_IGL_USDT.BackColor = SystemColors.HighlightText
        txtGross_IGL_USDT.BorderStyle = BorderStyle.FixedSingle
        txtGross_IGL_USDT.Font = New Font("Segoe UI", 10.125F)
        txtGross_IGL_USDT.Location = New Point(665, 272)
        txtGross_IGL_USDT.Margin = New Padding(2, 1, 2, 1)
        txtGross_IGL_USDT.Name = "txtGross_IGL_USDT"
        txtGross_IGL_USDT.Size = New Size(205, 30)
        txtGross_IGL_USDT.TabIndex = 66
        txtGross_IGL_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Location = New Point(255, 272)
        Label34.Margin = New Padding(2, 0, 2, 0)
        Label34.Name = "Label34"
        Label34.Size = New Size(69, 20)
        Label34.TabIndex = 67
        ' 
        ' txtCurrency_IGL_BTC
        ' 
        txtCurrency_IGL_BTC.BackColor = SystemColors.HighlightText
        txtCurrency_IGL_BTC.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_IGL_BTC.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_IGL_BTC.Location = New Point(347, 315)
        txtCurrency_IGL_BTC.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_IGL_BTC.Name = "txtCurrency_IGL_BTC"
        txtCurrency_IGL_BTC.Size = New Size(97, 30)
        txtCurrency_IGL_BTC.TabIndex = 68
        txtCurrency_IGL_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtGross_IGL_BTC
        ' 
        txtGross_IGL_BTC.BackColor = SystemColors.HighlightText
        txtGross_IGL_BTC.BorderStyle = BorderStyle.FixedSingle
        txtGross_IGL_BTC.Font = New Font("Segoe UI", 10.125F)
        txtGross_IGL_BTC.Location = New Point(665, 317)
        txtGross_IGL_BTC.Margin = New Padding(2, 1, 2, 1)
        txtGross_IGL_BTC.Name = "txtGross_IGL_BTC"
        txtGross_IGL_BTC.Size = New Size(205, 30)
        txtGross_IGL_BTC.TabIndex = 70
        txtGross_IGL_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtCurrency_Triangle
        ' 
        txtCurrency_Triangle.BackColor = SystemColors.HighlightText
        txtCurrency_Triangle.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_Triangle.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_Triangle.Location = New Point(347, 357)
        txtCurrency_Triangle.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_Triangle.Name = "txtCurrency_Triangle"
        txtCurrency_Triangle.Size = New Size(97, 30)
        txtCurrency_Triangle.TabIndex = 72
        txtCurrency_Triangle.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Location = New Point(462, 357)
        Label43.Margin = New Padding(2, 0, 2, 0)
        Label43.Name = "Label43"
        Label43.Size = New Size(143, 20)
        Label43.TabIndex = 73
        ' 
        ' txtGross_Triangle
        ' 
        txtGross_Triangle.BackColor = SystemColors.HighlightText
        txtGross_Triangle.BorderStyle = BorderStyle.FixedSingle
        txtGross_Triangle.Font = New Font("Segoe UI", 10.125F)
        txtGross_Triangle.Location = New Point(665, 357)
        txtGross_Triangle.Margin = New Padding(2, 1, 2, 1)
        txtGross_Triangle.Name = "txtGross_Triangle"
        txtGross_Triangle.Size = New Size(205, 30)
        txtGross_Triangle.TabIndex = 74
        txtGross_Triangle.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Location = New Point(255, 357)
        Label42.Margin = New Padding(2, 0, 2, 0)
        Label42.Name = "Label42"
        Label42.Size = New Size(69, 20)
        Label42.TabIndex = 75
        ' 
        ' txtCurrency_Lumley
        ' 
        txtCurrency_Lumley.BackColor = SystemColors.HighlightText
        txtCurrency_Lumley.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_Lumley.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_Lumley.Location = New Point(347, 399)
        txtCurrency_Lumley.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_Lumley.Name = "txtCurrency_Lumley"
        txtCurrency_Lumley.Size = New Size(97, 30)
        txtCurrency_Lumley.TabIndex = 76
        txtCurrency_Lumley.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Location = New Point(462, 399)
        Label41.Margin = New Padding(2, 0, 2, 0)
        Label41.Name = "Label41"
        Label41.Size = New Size(143, 20)
        Label41.TabIndex = 77
        ' 
        ' txtGross_Lumley
        ' 
        txtGross_Lumley.BackColor = SystemColors.HighlightText
        txtGross_Lumley.BorderStyle = BorderStyle.FixedSingle
        txtGross_Lumley.Font = New Font("Segoe UI", 10.125F)
        txtGross_Lumley.Location = New Point(665, 399)
        txtGross_Lumley.Margin = New Padding(2, 1, 2, 1)
        txtGross_Lumley.Name = "txtGross_Lumley"
        txtGross_Lumley.Size = New Size(205, 30)
        txtGross_Lumley.TabIndex = 78
        txtGross_Lumley.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Location = New Point(255, 399)
        Label40.Margin = New Padding(2, 0, 2, 0)
        Label40.Name = "Label40"
        Label40.Size = New Size(69, 20)
        Label40.TabIndex = 79
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Location = New Point(915, 69)
        Label54.Margin = New Padding(2, 0, 2, 0)
        Label54.Name = "Label54"
        Label54.Size = New Size(140, 20)
        Label54.TabIndex = 80
        ' 
        ' txtNet_C2C_USDT
        ' 
        txtNet_C2C_USDT.BackColor = SystemColors.HighlightText
        txtNet_C2C_USDT.BorderStyle = BorderStyle.FixedSingle
        txtNet_C2C_USDT.Font = New Font("Segoe UI", 10.125F)
        txtNet_C2C_USDT.Location = New Point(1110, 65)
        txtNet_C2C_USDT.Margin = New Padding(2, 1, 2, 1)
        txtNet_C2C_USDT.Name = "txtNet_C2C_USDT"
        txtNet_C2C_USDT.Size = New Size(205, 30)
        txtNet_C2C_USDT.TabIndex = 81
        txtNet_C2C_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtNet_C2C_BTC
        ' 
        txtNet_C2C_BTC.BackColor = SystemColors.HighlightText
        txtNet_C2C_BTC.BorderStyle = BorderStyle.FixedSingle
        txtNet_C2C_BTC.Font = New Font("Segoe UI", 10.125F)
        txtNet_C2C_BTC.Location = New Point(1110, 108)
        txtNet_C2C_BTC.Margin = New Padding(2, 1, 2, 1)
        txtNet_C2C_BTC.Name = "txtNet_C2C_BTC"
        txtNet_C2C_BTC.Size = New Size(205, 30)
        txtNet_C2C_BTC.TabIndex = 83
        txtNet_C2C_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Location = New Point(915, 149)
        Label52.Margin = New Padding(2, 0, 2, 0)
        Label52.Name = "Label52"
        Label52.Size = New Size(140, 20)
        Label52.TabIndex = 84
        ' 
        ' txtNet_PAG_USDT
        ' 
        txtNet_PAG_USDT.BackColor = SystemColors.HighlightText
        txtNet_PAG_USDT.BorderStyle = BorderStyle.FixedSingle
        txtNet_PAG_USDT.Font = New Font("Segoe UI", 10.125F)
        txtNet_PAG_USDT.Location = New Point(1110, 149)
        txtNet_PAG_USDT.Margin = New Padding(2, 1, 2, 1)
        txtNet_PAG_USDT.Name = "txtNet_PAG_USDT"
        txtNet_PAG_USDT.Size = New Size(205, 30)
        txtNet_PAG_USDT.TabIndex = 85
        txtNet_PAG_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtNet_PAG_BTC
        ' 
        txtNet_PAG_BTC.BackColor = SystemColors.HighlightText
        txtNet_PAG_BTC.BorderStyle = BorderStyle.FixedSingle
        txtNet_PAG_BTC.Font = New Font("Segoe UI", 10.125F)
        txtNet_PAG_BTC.Location = New Point(1110, 191)
        txtNet_PAG_BTC.Margin = New Padding(2, 1, 2, 1)
        txtNet_PAG_BTC.Name = "txtNet_PAG_BTC"
        txtNet_PAG_BTC.Size = New Size(205, 30)
        txtNet_PAG_BTC.TabIndex = 87
        txtNet_PAG_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Location = New Point(915, 231)
        Label50.Margin = New Padding(2, 0, 2, 0)
        Label50.Name = "Label50"
        Label50.Size = New Size(140, 20)
        Label50.TabIndex = 88
        ' 
        ' txtNet_Charity
        ' 
        txtNet_Charity.BackColor = SystemColors.HighlightText
        txtNet_Charity.BorderStyle = BorderStyle.FixedSingle
        txtNet_Charity.Font = New Font("Segoe UI", 10.125F)
        txtNet_Charity.Location = New Point(1110, 229)
        txtNet_Charity.Margin = New Padding(2, 1, 2, 1)
        txtNet_Charity.Name = "txtNet_Charity"
        txtNet_Charity.Size = New Size(205, 30)
        txtNet_Charity.TabIndex = 89
        txtNet_Charity.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Location = New Point(915, 272)
        Label49.Margin = New Padding(2, 0, 2, 0)
        Label49.Name = "Label49"
        Label49.Size = New Size(140, 20)
        Label49.TabIndex = 90
        ' 
        ' txtNet_IGL_USDT
        ' 
        txtNet_IGL_USDT.BackColor = SystemColors.HighlightText
        txtNet_IGL_USDT.BorderStyle = BorderStyle.FixedSingle
        txtNet_IGL_USDT.Font = New Font("Segoe UI", 10.125F)
        txtNet_IGL_USDT.Location = New Point(1110, 272)
        txtNet_IGL_USDT.Margin = New Padding(2, 1, 2, 1)
        txtNet_IGL_USDT.Name = "txtNet_IGL_USDT"
        txtNet_IGL_USDT.Size = New Size(205, 30)
        txtNet_IGL_USDT.TabIndex = 91
        txtNet_IGL_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtNet_IGL_BTC
        ' 
        txtNet_IGL_BTC.BackColor = SystemColors.HighlightText
        txtNet_IGL_BTC.BorderStyle = BorderStyle.FixedSingle
        txtNet_IGL_BTC.Font = New Font("Segoe UI", 10.125F)
        txtNet_IGL_BTC.Location = New Point(1110, 317)
        txtNet_IGL_BTC.Margin = New Padding(2, 1, 2, 1)
        txtNet_IGL_BTC.Name = "txtNet_IGL_BTC"
        txtNet_IGL_BTC.Size = New Size(205, 30)
        txtNet_IGL_BTC.TabIndex = 93
        txtNet_IGL_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Location = New Point(915, 357)
        Label47.Margin = New Padding(2, 0, 2, 0)
        Label47.Name = "Label47"
        Label47.Size = New Size(140, 20)
        Label47.TabIndex = 94
        ' 
        ' txtNet_Triangle
        ' 
        txtNet_Triangle.BackColor = SystemColors.HighlightText
        txtNet_Triangle.BorderStyle = BorderStyle.FixedSingle
        txtNet_Triangle.Font = New Font("Segoe UI", 10.125F)
        txtNet_Triangle.Location = New Point(1110, 357)
        txtNet_Triangle.Margin = New Padding(2, 1, 2, 1)
        txtNet_Triangle.Name = "txtNet_Triangle"
        txtNet_Triangle.Size = New Size(205, 30)
        txtNet_Triangle.TabIndex = 95
        txtNet_Triangle.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Location = New Point(915, 399)
        Label46.Margin = New Padding(2, 0, 2, 0)
        Label46.Name = "Label46"
        Label46.Size = New Size(140, 20)
        Label46.TabIndex = 96
        ' 
        ' txtNet_Lumley
        ' 
        txtNet_Lumley.BackColor = SystemColors.HighlightText
        txtNet_Lumley.BorderStyle = BorderStyle.FixedSingle
        txtNet_Lumley.Font = New Font("Segoe UI", 10.125F)
        txtNet_Lumley.Location = New Point(1110, 399)
        txtNet_Lumley.Margin = New Padding(2, 1, 2, 1)
        txtNet_Lumley.Name = "txtNet_Lumley"
        txtNet_Lumley.Size = New Size(205, 30)
        txtNet_Lumley.TabIndex = 97
        txtNet_Lumley.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtCurrency_Fendly
        ' 
        txtCurrency_Fendly.BackColor = SystemColors.HighlightText
        txtCurrency_Fendly.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_Fendly.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_Fendly.Location = New Point(347, 445)
        txtCurrency_Fendly.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_Fendly.Name = "txtCurrency_Fendly"
        txtCurrency_Fendly.Size = New Size(97, 30)
        txtCurrency_Fendly.TabIndex = 98
        txtCurrency_Fendly.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label60
        ' 
        Label60.AutoSize = True
        Label60.Location = New Point(462, 445)
        Label60.Margin = New Padding(2, 0, 2, 0)
        Label60.Name = "Label60"
        Label60.Size = New Size(143, 20)
        Label60.TabIndex = 99
        ' 
        ' txtGross_Fendly
        ' 
        txtGross_Fendly.BackColor = SystemColors.HighlightText
        txtGross_Fendly.BorderStyle = BorderStyle.FixedSingle
        txtGross_Fendly.Font = New Font("Segoe UI", 10.125F)
        txtGross_Fendly.Location = New Point(665, 445)
        txtGross_Fendly.Margin = New Padding(2, 1, 2, 1)
        txtGross_Fendly.Name = "txtGross_Fendly"
        txtGross_Fendly.Size = New Size(205, 30)
        txtGross_Fendly.TabIndex = 100
        txtGross_Fendly.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label59
        ' 
        Label59.AutoSize = True
        Label59.Location = New Point(255, 445)
        Label59.Margin = New Padding(2, 0, 2, 0)
        Label59.Name = "Label59"
        Label59.Size = New Size(69, 20)
        Label59.TabIndex = 101
        ' 
        ' txtCurrency_Crisci
        ' 
        txtCurrency_Crisci.BackColor = SystemColors.HighlightText
        txtCurrency_Crisci.BorderStyle = BorderStyle.FixedSingle
        txtCurrency_Crisci.Font = New Font("Segoe UI", 10.125F)
        txtCurrency_Crisci.Location = New Point(347, 488)
        txtCurrency_Crisci.Margin = New Padding(2, 1, 2, 1)
        txtCurrency_Crisci.Name = "txtCurrency_Crisci"
        txtCurrency_Crisci.Size = New Size(97, 30)
        txtCurrency_Crisci.TabIndex = 102
        txtCurrency_Crisci.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Location = New Point(462, 488)
        Label58.Margin = New Padding(2, 0, 2, 0)
        Label58.Name = "Label58"
        Label58.Size = New Size(143, 20)
        Label58.TabIndex = 103
        ' 
        ' txtGross_Crisci
        ' 
        txtGross_Crisci.BackColor = SystemColors.HighlightText
        txtGross_Crisci.BorderStyle = BorderStyle.FixedSingle
        txtGross_Crisci.Font = New Font("Segoe UI", 10.125F)
        txtGross_Crisci.Location = New Point(665, 488)
        txtGross_Crisci.Margin = New Padding(2, 1, 2, 1)
        txtGross_Crisci.Name = "txtGross_Crisci"
        txtGross_Crisci.Size = New Size(205, 30)
        txtGross_Crisci.TabIndex = 104
        txtGross_Crisci.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label57
        ' 
        Label57.AutoSize = True
        Label57.Location = New Point(255, 488)
        Label57.Margin = New Padding(2, 0, 2, 0)
        Label57.Name = "Label57"
        Label57.Size = New Size(69, 20)
        Label57.TabIndex = 105
        ' 
        ' Label56
        ' 
        Label56.AutoSize = True
        Label56.Location = New Point(915, 445)
        Label56.Margin = New Padding(2, 0, 2, 0)
        Label56.Name = "Label56"
        Label56.Size = New Size(140, 20)
        Label56.TabIndex = 106
        ' 
        ' txtNet_Fendly
        ' 
        txtNet_Fendly.BackColor = SystemColors.HighlightText
        txtNet_Fendly.BorderStyle = BorderStyle.FixedSingle
        txtNet_Fendly.Font = New Font("Segoe UI", 10.125F)
        txtNet_Fendly.Location = New Point(1110, 445)
        txtNet_Fendly.Margin = New Padding(2, 1, 2, 1)
        txtNet_Fendly.Name = "txtNet_Fendly"
        txtNet_Fendly.Size = New Size(205, 30)
        txtNet_Fendly.TabIndex = 107
        txtNet_Fendly.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label55
        ' 
        Label55.AutoSize = True
        Label55.Location = New Point(915, 488)
        Label55.Margin = New Padding(2, 0, 2, 0)
        Label55.Name = "Label55"
        Label55.Size = New Size(140, 20)
        Label55.TabIndex = 108
        ' 
        ' txtNet_Crisci
        ' 
        txtNet_Crisci.BackColor = SystemColors.HighlightText
        txtNet_Crisci.BorderStyle = BorderStyle.FixedSingle
        txtNet_Crisci.Font = New Font("Segoe UI", 10.125F)
        txtNet_Crisci.Location = New Point(1110, 488)
        txtNet_Crisci.Margin = New Padding(2, 1, 2, 1)
        txtNet_Crisci.Name = "txtNet_Crisci"
        txtNet_Crisci.Size = New Size(205, 30)
        txtNet_Crisci.TabIndex = 109
        txtNet_Crisci.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAgent_C2C_USDT
        ' 
        txtAgent_C2C_USDT.BackColor = SystemColors.HighlightText
        txtAgent_C2C_USDT.BorderStyle = BorderStyle.FixedSingle
        txtAgent_C2C_USDT.Font = New Font("Segoe UI", 10.125F)
        txtAgent_C2C_USDT.Location = New Point(83, 65)
        txtAgent_C2C_USDT.Margin = New Padding(2, 1, 2, 1)
        txtAgent_C2C_USDT.Name = "txtAgent_C2C_USDT"
        txtAgent_C2C_USDT.ReadOnly = True
        txtAgent_C2C_USDT.Size = New Size(157, 30)
        txtAgent_C2C_USDT.TabIndex = 110
        txtAgent_C2C_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label71
        ' 
        Label71.AutoSize = True
        Label71.Location = New Point(15, 69)
        Label71.Margin = New Padding(2, 0, 2, 0)
        Label71.Name = "Label71"
        Label71.Size = New Size(52, 20)
        Label71.TabIndex = 111
        ' 
        ' txtAgent_C2C_BTC
        ' 
        txtAgent_C2C_BTC.BackColor = SystemColors.HighlightText
        txtAgent_C2C_BTC.BorderStyle = BorderStyle.FixedSingle
        txtAgent_C2C_BTC.Font = New Font("Segoe UI", 10.125F)
        txtAgent_C2C_BTC.Location = New Point(83, 108)
        txtAgent_C2C_BTC.Margin = New Padding(2, 1, 2, 1)
        txtAgent_C2C_BTC.Name = "txtAgent_C2C_BTC"
        txtAgent_C2C_BTC.ReadOnly = True
        txtAgent_C2C_BTC.Size = New Size(157, 30)
        txtAgent_C2C_BTC.TabIndex = 112
        txtAgent_C2C_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAgent_PAG_USDT
        ' 
        txtAgent_PAG_USDT.BackColor = SystemColors.HighlightText
        txtAgent_PAG_USDT.BorderStyle = BorderStyle.FixedSingle
        txtAgent_PAG_USDT.Font = New Font("Segoe UI", 10.125F)
        txtAgent_PAG_USDT.Location = New Point(83, 149)
        txtAgent_PAG_USDT.Margin = New Padding(2, 1, 2, 1)
        txtAgent_PAG_USDT.Name = "txtAgent_PAG_USDT"
        txtAgent_PAG_USDT.ReadOnly = True
        txtAgent_PAG_USDT.Size = New Size(157, 30)
        txtAgent_PAG_USDT.TabIndex = 114
        txtAgent_PAG_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label69
        ' 
        Label69.AutoSize = True
        Label69.Location = New Point(15, 149)
        Label69.Margin = New Padding(2, 0, 2, 0)
        Label69.Name = "Label69"
        Label69.Size = New Size(52, 20)
        Label69.TabIndex = 115
        ' 
        ' txtAgent_PAG_BTC
        ' 
        txtAgent_PAG_BTC.BackColor = SystemColors.HighlightText
        txtAgent_PAG_BTC.BorderStyle = BorderStyle.FixedSingle
        txtAgent_PAG_BTC.Font = New Font("Segoe UI", 10.125F)
        txtAgent_PAG_BTC.Location = New Point(83, 188)
        txtAgent_PAG_BTC.Margin = New Padding(2, 1, 2, 1)
        txtAgent_PAG_BTC.Name = "txtAgent_PAG_BTC"
        txtAgent_PAG_BTC.ReadOnly = True
        txtAgent_PAG_BTC.Size = New Size(157, 30)
        txtAgent_PAG_BTC.TabIndex = 116
        txtAgent_PAG_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAgent_Charity
        ' 
        txtAgent_Charity.BackColor = SystemColors.HighlightText
        txtAgent_Charity.BorderStyle = BorderStyle.FixedSingle
        txtAgent_Charity.Font = New Font("Segoe UI", 10.125F)
        txtAgent_Charity.Location = New Point(83, 229)
        txtAgent_Charity.Margin = New Padding(2, 1, 2, 1)
        txtAgent_Charity.Name = "txtAgent_Charity"
        txtAgent_Charity.ReadOnly = True
        txtAgent_Charity.Size = New Size(157, 30)
        txtAgent_Charity.TabIndex = 118
        txtAgent_Charity.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label67
        ' 
        Label67.AutoSize = True
        Label67.Location = New Point(15, 231)
        Label67.Margin = New Padding(2, 0, 2, 0)
        Label67.Name = "Label67"
        Label67.Size = New Size(52, 20)
        Label67.TabIndex = 119
        ' 
        ' txtAgent_IGL_USDT
        ' 
        txtAgent_IGL_USDT.BackColor = SystemColors.HighlightText
        txtAgent_IGL_USDT.BorderStyle = BorderStyle.FixedSingle
        txtAgent_IGL_USDT.Font = New Font("Segoe UI", 10.125F)
        txtAgent_IGL_USDT.Location = New Point(83, 272)
        txtAgent_IGL_USDT.Margin = New Padding(2, 1, 2, 1)
        txtAgent_IGL_USDT.Name = "txtAgent_IGL_USDT"
        txtAgent_IGL_USDT.ReadOnly = True
        txtAgent_IGL_USDT.Size = New Size(157, 30)
        txtAgent_IGL_USDT.TabIndex = 120
        txtAgent_IGL_USDT.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAgent_IGL_BTC
        ' 
        txtAgent_IGL_BTC.BackColor = SystemColors.HighlightText
        txtAgent_IGL_BTC.BorderStyle = BorderStyle.FixedSingle
        txtAgent_IGL_BTC.Font = New Font("Segoe UI", 10.125F)
        txtAgent_IGL_BTC.Location = New Point(83, 315)
        txtAgent_IGL_BTC.Margin = New Padding(2, 1, 2, 1)
        txtAgent_IGL_BTC.Name = "txtAgent_IGL_BTC"
        txtAgent_IGL_BTC.ReadOnly = True
        txtAgent_IGL_BTC.Size = New Size(157, 30)
        txtAgent_IGL_BTC.TabIndex = 122
        txtAgent_IGL_BTC.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAgent_Triangle
        ' 
        txtAgent_Triangle.BackColor = SystemColors.HighlightText
        txtAgent_Triangle.BorderStyle = BorderStyle.FixedSingle
        txtAgent_Triangle.Font = New Font("Segoe UI", 10.125F)
        txtAgent_Triangle.Location = New Point(83, 357)
        txtAgent_Triangle.Margin = New Padding(2, 1, 2, 1)
        txtAgent_Triangle.Name = "txtAgent_Triangle"
        txtAgent_Triangle.ReadOnly = True
        txtAgent_Triangle.Size = New Size(157, 30)
        txtAgent_Triangle.TabIndex = 124
        txtAgent_Triangle.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label64
        ' 
        Label64.AutoSize = True
        Label64.Location = New Point(15, 275)
        Label64.Margin = New Padding(2, 0, 2, 0)
        Label64.Name = "Label64"
        Label64.Size = New Size(52, 20)
        Label64.TabIndex = 125
        ' 
        ' txtAgent_Lumley
        ' 
        txtAgent_Lumley.BackColor = SystemColors.HighlightText
        txtAgent_Lumley.BorderStyle = BorderStyle.FixedSingle
        txtAgent_Lumley.Font = New Font("Segoe UI", 10.125F)
        txtAgent_Lumley.Location = New Point(83, 399)
        txtAgent_Lumley.Margin = New Padding(2, 1, 2, 1)
        txtAgent_Lumley.Name = "txtAgent_Lumley"
        txtAgent_Lumley.ReadOnly = True
        txtAgent_Lumley.Size = New Size(157, 30)
        txtAgent_Lumley.TabIndex = 126
        txtAgent_Lumley.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label63
        ' 
        Label63.AutoSize = True
        Label63.Location = New Point(15, 361)
        Label63.Margin = New Padding(2, 0, 2, 0)
        Label63.Name = "Label63"
        Label63.Size = New Size(52, 20)
        Label63.TabIndex = 127
        ' 
        ' txtAgent_Fendly
        ' 
        txtAgent_Fendly.BackColor = SystemColors.HighlightText
        txtAgent_Fendly.BorderStyle = BorderStyle.FixedSingle
        txtAgent_Fendly.Font = New Font("Segoe UI", 10.125F)
        txtAgent_Fendly.Location = New Point(83, 445)
        txtAgent_Fendly.Margin = New Padding(2, 1, 2, 1)
        txtAgent_Fendly.Name = "txtAgent_Fendly"
        txtAgent_Fendly.ReadOnly = True
        txtAgent_Fendly.Size = New Size(157, 30)
        txtAgent_Fendly.TabIndex = 128
        txtAgent_Fendly.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label62
        ' 
        Label62.AutoSize = True
        Label62.Location = New Point(15, 445)
        Label62.Margin = New Padding(2, 0, 2, 0)
        Label62.Name = "Label62"
        Label62.Size = New Size(52, 20)
        Label62.TabIndex = 129
        ' 
        ' txtAgent_Crisci
        ' 
        txtAgent_Crisci.BackColor = SystemColors.HighlightText
        txtAgent_Crisci.BorderStyle = BorderStyle.FixedSingle
        txtAgent_Crisci.Font = New Font("Segoe UI", 10.125F)
        txtAgent_Crisci.Location = New Point(83, 488)
        txtAgent_Crisci.Margin = New Padding(2, 1, 2, 1)
        txtAgent_Crisci.Name = "txtAgent_Crisci"
        txtAgent_Crisci.ReadOnly = True
        txtAgent_Crisci.Size = New Size(157, 30)
        txtAgent_Crisci.TabIndex = 130
        txtAgent_Crisci.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label61
        ' 
        Label61.AutoSize = True
        Label61.Location = New Point(15, 488)
        Label61.Margin = New Padding(2, 0, 2, 0)
        Label61.Name = "Label61"
        Label61.Size = New Size(52, 20)
        Label61.TabIndex = 131
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 402)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 132
        ' 
        ' NewTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 888)
        Controls.Add(gbTransaction)
        Controls.Add(tcTransactionsDetails)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 1, 2, 1)
        MinimizeBox = False
        Name = "NewTransaction"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "NewTransaction"
        tcTransactionsDetails.ResumeLayout(False)
        tpTransactions.ResumeLayout(False)
        tpTransactions.PerformLayout()
        PanelTransactionLines.ResumeLayout(False)
        gbLines.ResumeLayout(False)
        gpTransaction_L3.ResumeLayout(False)
        gpTransaction_L3.PerformLayout()
        gpTransaction_L2.ResumeLayout(False)
        gpTransaction_L2.PerformLayout()
        gpTransaction_L1.ResumeLayout(False)
        gpTransaction_L1.PerformLayout()
        tpCommissions.ResumeLayout(False)
        gbCommissions.ResumeLayout(False)
        CType(dgvCommissions, ComponentModel.ISupportInitialize).EndInit()
        gbTransaction.ResumeLayout(False)
        gbTransaction.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tcTransactionsDetails As TabControl
    Friend WithEvents tpTransactions As TabPage
    Friend WithEvents gbLines As GroupBox
    Friend WithEvents gpTransaction_L3 As GroupBox
    Friend WithEvents txtNet_L33 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtGrossD_L33 As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtCurrency_L33 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtNet_L32 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtGrossDailyTadrossDisbursment As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtGrossD_L32 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtCurrency_L32 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNet_L31 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtTadrossIncome As TextBox
    Friend WithEvents lblPercentageTadross As Label
    Friend WithEvents txtGrossD_L31 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtCurrency_L31 As TextBox
    Friend WithEvents txtProvider_L3 As TextBox
    Friend WithEvents gpTransaction_L2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNet_L2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtGas_L2 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtGrossD_L2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCurrency_L2 As TextBox
    Friend WithEvents txtProvider_L2 As TextBox
    Friend WithEvents gpTransaction_L1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNet_L1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtGas_L1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtGrossD_L1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCurrency_L1 As TextBox
    Friend WithEvents txtProvider_L1 As TextBox
    Friend WithEvents gbTransaction As GroupBox
    Friend WithEvents dtpTransactionDate_T As DateTimePicker
    Friend WithEvents lblNumberOfBTC As Label
    Friend WithEvents lblFinalSwapTranchePrice As Label
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents lblCurrency_T As Label
    Friend WithEvents lblProvider_T As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents txtumberofBTC_T As TextBox
    Friend WithEvents txtFinalSwapTranchePrice_T As TextBox
    Friend WithEvents txtTransactionID_T As TextBox
    Friend WithEvents cmbCurrency_T As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbProvider_T As ComboBox
    Friend WithEvents tpCommissions As TabPage
    Friend WithEvents gbCommissions As GroupBox
    Friend WithEvents dgvCommissions As DataGridView
    Friend WithEvents lblTranches As Label
    Friend WithEvents txtTranchesExecute_T As TextBox
    Friend WithEvents txtCurrency_C2C_USDT As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtGross_C2C_USDT As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtCurrency_C2C_BTC As TextBox
    Friend WithEvents txtGross_C2C_BTC As TextBox
    Friend WithEvents txtCurrency_PAG_USDT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGross_PAG_USDT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCurrency_PAG_BTC As TextBox
    Friend WithEvents txtGross_PAG_BTC As TextBox
    Friend WithEvents txtCurrency_Charity As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtGross_Charity As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtCurrency_IGL_USDT As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtGross_IGL_USDT As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtCurrency_IGL_BTC As TextBox
    Friend WithEvents txtGross_IGL_BTC As TextBox
    Friend WithEvents txtCurrency_Triangle As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtGross_Triangle As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtCurrency_Lumley As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents txtGross_Lumley As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents txtNet_C2C_USDT As TextBox
    Friend WithEvents txtNet_C2C_BTC As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txtNet_PAG_USDT As TextBox
    Friend WithEvents txtNet_PAG_BTC As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txtNet_Charity As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents txtNet_IGL_USDT As TextBox
    Friend WithEvents txtNet_IGL_BTC As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtNet_Triangle As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtNet_Lumley As TextBox
    Friend WithEvents txtCurrency_Fendly As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents txtGross_Fendly As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents txtCurrency_Crisci As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents txtGross_Crisci As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents txtNet_Fendly As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txtNet_Crisci As TextBox
    Friend WithEvents txtAgent_C2C_USDT As TextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents txtAgent_C2C_BTC As TextBox
    Friend WithEvents txtAgent_PAG_USDT As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents txtAgent_PAG_BTC As TextBox
    Friend WithEvents txtAgent_Charity As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents txtAgent_IGL_USDT As TextBox
    Friend WithEvents txtAgent_IGL_BTC As TextBox
    Friend WithEvents txtAgent_Triangle As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents txtAgent_Lumley As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents txtAgent_Fendly As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents txtAgent_Crisci As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDailyTadrosDisbursment As TextBox
    Friend WithEvents lblDailyTadrossGross As Label
    Friend WithEvents PanelTransactionLines As Panel
    Friend WithEvents btnNewCurrency As Button
    Friend WithEvents Label1 As Label
End Class
