


Imports Entity
Imports BusinessLogic
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.IO

Public Class NewTransaction


    Public connection As New OleDbConnection
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDbDataReader
    Public vCalculate As Integer = 0
    Public vClear As Integer = 0

    Private Sub NewTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        '  Me.ClientSize = New System.Drawing.Size(1300, 1000)
        Me.dtpTransactionDate_T.Format = DateTimePickerFormat.Custom
        Me.dtpTransactionDate_T.CustomFormat = "yyyy-MM-dd"

        Call FormatControls()

    End Sub




    Private Sub FormatControls()
        'Me.lblFinalSwapTranchePrice.Text = "Final Swap Tranche Price:"
        'Me.lblNumberOfBTC.Text = "Number of BTC:"
        'Me.lblTranches.Text = "Tranches Executed:"
        Me.dtpTransactionDate_T.DropDownAlign = LeftRightAlignment.Right
        Me.txtTransactionID_T.TextAlign = HorizontalAlignment.Right
        Me.txtFinalSwapTranchePrice_T.TextAlign = HorizontalAlignment.Right
        Me.txtumberofBTC_T.TextAlign = HorizontalAlignment.Right
        Me.txtTranchesExecute_T.TextAlign = HorizontalAlignment.Right
        Me.cmbProvider_T.Focus()


        Call Clear(gbTransaction)
        Call Clear(gpTransaction_L1)
        Call Clear(gpTransaction_L2)
        Call Clear(gpTransaction_L3)
        Call Clear(tpCommissions)

        Call DisableControlls(Me.gbTransaction)
        Call DisableControlls(Me.gpTransaction_L1)
        Call DisableControlls(Me.gpTransaction_L2)
        Call DisableControlls(Me.gpTransaction_L3)

        Call HideControlls(Me.gbLines)
        Call HideControlls(Me.tpCommissions)
        Call GetTransaction_ID()

    End Sub


    Private Sub lblFinalSwapTranchePrice_Click_1(sender As Object, e As EventArgs) Handles lblFinalSwapTranchePrice.Click
        txtFinalSwapTranchePrice_T.Enabled = True
    End Sub

    Private Sub lblNumberOfBTC_Click(sender As Object, e As EventArgs) Handles lblNumberOfBTC.Click
        txtumberofBTC_T.Enabled = True
    End Sub

    Private Sub lblTransactionDate_Click(sender As Object, e As EventArgs) Handles lblTransactionDate.Click
        dtpTransactionDate_T.Enabled = True
    End Sub


    'Private Sub dtpTransactionDate_T_TextChanged(sender As Object, e As EventArgs) Handles dtpTransactionDate_T.ValueChanged
    'If Me.cmbProvider_T.Text = "TADROSS" Then

    'End If
    'End Sub



    Private Sub cmbProvider_T_DropDown(sender As Object, e As EventArgs) Handles cmbProvider_T.DropDown
        cmbProvider_T.DataSource = Nothing
        cmbProvider_T.Items.Clear()
        cmbCurrency_T.DataSource = Nothing
        cmbCurrency_T.DataBindings.Clear()
        cmbCurrency_T.Items.Clear()

        Dim BusinessLogic As New cnProviders
        cmbProvider_T.DataSource = BusinessLogic.GetProvider.Tables("Provider")
        cmbProvider_T.ValueMember = "Provider_ID"
        cmbProvider_T.DisplayMember = "Full_Name"
    End Sub

    Private Sub cmbProvider_T_TextChanged(sender As Object, e As EventArgs) Handles cmbProvider_T.SelectionChangeCommitted
        cmbCurrency_T.Enabled = True
        cmbCurrency_T.Focus()
    End Sub

    Private Sub cmbCurrency_T_DropDown(sender As Object, e As EventArgs) Handles cmbCurrency_T.DropDown
        Me.cmbCurrency_T.DataSource = Nothing
        Me.cmbCurrency_T.DataBindings.Clear()
        Me.cmbCurrency_T.Items.Clear()
        Dim BusinessLogic As New BusinessLogic.cnCurrency
        Me.cmbCurrency_T.DataSource = BusinessLogic.GetCurrency().Tables("Currency")
        Me.cmbCurrency_T.ValueMember = "Currency_ID"
        Me.cmbCurrency_T.DisplayMember = "Currency_Name"
    End Sub



    Private Sub cmbCurrency_T_TextChanged(sender As Object, e As EventArgs) Handles cmbCurrency_T.SelectionChangeCommitted
        Call LoadForms()
        Me.gbTransaction.Focus()
    End Sub

    Private Sub CalculateValues()
        Call CalculateTransaction()
        Call CalculateCommissions()
    End Sub
    Private Sub LoadForms()

        If Me.cmbProvider_T.Text.ToString = "DAVIDE" And Me.cmbCurrency_T.Text.ToString = "BTC" Then

            If Me.PanelTransactionLines.Controls.Count > 0 Then
                Me.PanelTransactionLines.Controls.Clear()
            End If

            Call VisibleControlls(Me.gbTransaction)
            Call VisibleControlls(Me.gbLines)
            Call VisibleControlls(Me.gbCommissions)
            Me.PanelTransactionLines.Controls.Add(gbLines)
            gbLines.Show()
            Call DavideForm()

            'ElseIf Me.cmbProvider_T.Text.ToString = "TADROSS" Then

            '    Me.PanelTransactionLines.Visible = True
            '    If Me.PanelTransactionLines.Controls.Count = 0 Then
            '        frmTransactions.TopLevel = False
            '        frmTransactions.FormBorderStyle = FormBorderStyle.None
            '        frmTransactions.Dock = DockStyle.None
            '        Me.PanelTransactionLines.Controls.Add(frmTransactions)
            '        frmTransactions.Show()
            '    Else
            '        Me.PanelTransactionLines.Controls.Clear()
            '        frmTransactions.TopLevel = False
            '        frmTransactions.FormBorderStyle = FormBorderStyle.None
            '        frmTransactions.Dock = DockStyle.None
            '        Me.PanelTransactionLines.Controls.Add(frmTransactions)
            '        frmTransactions.Show()
            '    End If

            '    For Each c As Control In gbTransaction.Controls
            '        If TypeOf c Is TextBox Then
            '            If c.Name = "txtTransactionID_T" Then
            '                c.Visible = True
            '            Else
            '                c.Visible = False
            '            End If
            '        End If
            '        If TypeOf c Is Label Then
            '            If c.Name = "lblFinalSwapTranchePrice" Or c.Name = "lblNumberOfBTC" Or c.Name = "lblTranches" Then
            '                c.Visible = False
            '            Else
            '                c.Visible = True
            '            End If
            '        End If
            '    Next

        ElseIf Me.cmbProvider_T.Text.ToString <> "DAVIDE" And Me.cmbProvider_T.Text.ToString <> Nothing Then

            Me.PanelTransactionLines.Visible = True
            If Me.PanelTransactionLines.Controls.Count = 0 Then
                frmEmptyTransactions.TopLevel = False
                frmEmptyTransactions.FormBorderStyle = FormBorderStyle.None
                frmEmptyTransactions.Dock = DockStyle.None
                Me.PanelTransactionLines.Controls.Add(frmEmptyTransactions)
                frmEmptyTransactions.Show()
            Else
                Me.PanelTransactionLines.Controls.Clear()
                frmEmptyTransactions.TopLevel = False
                frmEmptyTransactions.FormBorderStyle = FormBorderStyle.None
                frmEmptyTransactions.Dock = DockStyle.None
                Me.PanelTransactionLines.Controls.Add(frmEmptyTransactions)
                frmEmptyTransactions.Show()
            End If

        Else   ''''''''''''''''''''''''''''''''''''''' AQUI HAY QUE CREAR UN FORM VIRGEN 

            Call DisableControlls(Me.gbLines)
            Call DisableControlls(Me.tpCommissions)
            Call HideControlls(Me.gbLines)
            Call HideControlls(Me.tpCommissions)

        End If
    End Sub




    Private Sub DavideForm()

        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
        Call GetTrancheNumber()
        Me.txtFinalSwapTranchePrice_T.Text = GlobalVariables.vDavide_Final_Swap_Tranche_Price
        Me.txtumberofBTC_T.Text = GlobalVariables.vDavide_txtumber_of_BTC
        Me.txtTadrossIncome.Text = GlobalVariables.vTadross_Income
        Me.txtDailyTadrosDisbursment.Text = Math.Round(GlobalVariables.vTadross_Daily_Disbursment, 2)
        Me.txtGrossDailyTadrossDisbursment.Text = Math.Round(((GlobalVariables.vTadross_Daily_Disbursment * GlobalVariables.vTadross_Income) / 8), 2)

        Me.txtProvider_L1.Text = "DAVIDE"
        Me.txtCurrency_L1.Text = "USDT"
        Me.txtGas_L1.Text = 0
        Me.txtGrossD_L1.Text = (GlobalVariables.vDavide_Final_Swap_Tranche_Price * GlobalVariables.vDavide_txtumber_of_BTC)
        Me.txtNet_L1.Text = (GlobalVariables.vDavide_Final_Swap_Tranche_Price * GlobalVariables.vDavide_txtumber_of_BTC) - Me.txtGas_L1.Text

        Me.txtProvider_L2.Text = "DAVIDE MANDATES"
        Me.txtCurrency_L2.Text = "BTC"
        Me.txtGrossD_L2.Text = 10
        Me.txtGas_L2.Text = 0
        Me.txtGrossD_L2.Text = Me.txtGrossD_L2.Text
        Me.txtNet_L2.Text = Me.txtGrossD_L2.Text - Me.txtGas_L2.Text

        Me.txtProvider_L3.Text = "TADROSS"
        Me.txtCurrency_L31.Text = "USD"
        Me.txtCurrency_L32.Text = "USDT"
        Me.txtCurrency_L33.Text = "BTC"
        Call CalculateValues()
    End Sub

    Private Sub LoadTransactions()

    End Sub
    Private Sub CalculateTransaction()

        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
        If Me.cmbProvider_T.Text = "DAVIDE" Then
            If Me.cmbCurrency_T.Text = "BTC" Then
                If Len(Me.txtumberofBTC_T.Text.ToString) > 0 Then

                    Dim ds As New DataTable
                    Dim par As New ceTransaction
                    par.TransactionDate = LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))
                    Dim BusinessLogic As New BusinessLogic.cnTransaction
                    ds = BusinessLogic.GetTadrossWeeklyNet(par).Tables("TotalTadrossGross")

                    Me.txtGrossD_L1.Text = (Me.txtFinalSwapTranchePrice_T.Text * Me.txtumberofBTC_T.Text)
                    Me.txtNet_L1.Text = ((Me.txtFinalSwapTranchePrice_T.Text * Me.txtumberofBTC_T.Text) - Me.txtGas_L1.Text)

                    Me.txtGrossD_L2.Text = Me.txtGrossD_L2.Text
                    Me.txtNet_L2.Text = (Me.txtGrossD_L2.Text - Me.txtGas_L2.Text)

                    Me.txtGrossD_L31.Text = Math.Round((Me.txtGrossDailyTadrossDisbursment.Text / 3), 3)
                    Me.txtGrossD_L32.Text = Math.Round((Me.txtGrossDailyTadrossDisbursment.Text / 3), 3)
                    Me.txtGrossD_L33.Text = Math.Round(((Me.txtGrossDailyTadrossDisbursment.Text / 3)) / Me.txtFinalSwapTranchePrice_T.Text, 3)

                    If ds.Rows.Count > 0 Then
                        Dim NumberOfTimes As Int32 = 2
                        For i As Int32 = 0 To NumberOfTimes
                            Select Case ds.Rows(i).Item(0).ToString()
                                Case "USD"
                                    Me.txtNet_L31.Text = ds.Rows(i).Item(2).ToString()
                                Case "USDT"
                                    Me.txtNet_L32.Text = ds.Rows(i).Item(2).ToString()
                                Case "BTC"
                                    Me.txtNet_L33.Text = ds.Rows(i).Item(2).ToString()
                                    Exit Select
                            End Select
                        Next i
                    Else
                        Me.txtNet_L31.Text = Me.txtGrossD_L31.Text
                        Me.txtNet_L32.Text = Me.txtGrossD_L32.Text
                        Me.txtNet_L33.Text = Me.txtGrossD_L33.Text
                    End If


                End If
            End If
        End If
    End Sub

    Private Sub GetTransaction_ID()
        Dim Obj As New ceID
        Dim ds As New DataTable
        Dim BusinessLogic As New BusinessLogic.cnNewID
        ds = BusinessLogic.GetID().Tables("ID")
        Me.txtTransactionID_T.Text = ds.Rows(0).Item(0).ToString()
    End Sub

    'Private Sub GetTranche_ID()
    '    Dim Obj As New ceID
    '    Dim ds As New DataTable
    '    Dim BusinessLogic As New BusinessLogic.cnNewID
    '    ds = BusinessLogic.GetID().Tables("ID")
    '    Me.txtTransactionID_T.Text = ds.Rows(0).Item(0).ToString()
    'End Sub

    Private Sub GetTrancheNumber()
        Dim ds As New DataTable
        Dim par As New ceTransaction
        par.ProviderID = LTrim(RTrim(Me.cmbProvider_T.SelectedValue))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency_T.SelectedValue))
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        ds = BusinessLogic.GetTrancheID(par).Tables("Tranche")
        Me.txtTranchesExecute_T.Text = ds.Rows(0).Item(0).ToString()
    End Sub

    Private Sub txtFinalSwapTranchePrice_T_DoubleClick(sender As Object, e As EventArgs) Handles lblFinalSwapTranchePrice.DoubleClick
        Me.txtFinalSwapTranchePrice_T.Enabled = True
        Me.txtFinalSwapTranchePrice_T.BackColor = Color.LightSteelBlue

    End Sub

    Private Sub lblDailyTadrossGross_Click(sender As Object, e As EventArgs) Handles lblDailyTadrossGross.Click
        Me.txtDailyTadrosDisbursment.Enabled = True
        Me.txtDailyTadrosDisbursment.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub txtumberofBTC_T_DoubleClick(sender As Object, e As EventArgs) Handles lblNumberOfBTC.DoubleClick
        Me.txtumberofBTC_T.Enabled = True
        Me.txtumberofBTC_T.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub txtPercentageTadross_DoubleClick(sender As Object, e As EventArgs) Handles lblPercentageTadross.DoubleClick
        Me.txtTadrossIncome.Enabled = True
        Me.txtTadrossIncome.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub cmbProvider_T_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvider_T.Click
        Call FormatControls()
    End Sub

    Private Sub txtGas_L1_TextChanged(sender As Object, e As EventArgs) Handles txtGas_L1.TextChanged
        If Len(Me.txtGas_L1.Text) > 0 And Len(Me.txtFinalSwapTranchePrice_T.Text) > 0 _
              And Len(Me.txtumberofBTC_T.Text.ToString) > 0 Then
            Call CalculateValues()
        End If
    End Sub

    Private Sub txtGas_L1_Click(sender As Object, e As EventArgs) Handles txtGas_L1.Click
        If Me.txtGas_L1.Enabled = True Then
            txtGas_L1.Text = ""
        End If
    End Sub

    Private Sub txtGas_L1_MouseLeave(sender As Object, e As EventArgs) Handles txtGas_L1.MouseLeave
        If Me.txtGas_L1.Text = "" Then
            txtGas_L1.Text = 0
        End If
    End Sub

    Private Sub txtGas_L2_TextChanged(sender As Object, e As EventArgs) Handles txtGas_L2.TextChanged
        If Len(Me.txtGas_L2.Text) > 0 And Len(Me.txtFinalSwapTranchePrice_T.Text) > 0 Then
            Call CalculateValues()
        End If
    End Sub


    Private Sub txtGas_L2_Click(sender As Object, e As EventArgs) Handles txtGas_L2.Click
        If Me.txtGas_L2.Enabled = True Then
            txtGas_L2.Text = ""
        End If
    End Sub

    Private Sub txtGas_L2_MouseLeave(sender As Object, e As EventArgs) Handles txtGas_L2.MouseLeave
        If Me.txtGas_L2.Text = "" Then
            txtGas_L2.Text = 0
        End If
    End Sub

    Private Sub txtFinalSwapTranchePrice_T_TextChanged(sender As Object, e As EventArgs) Handles txtFinalSwapTranchePrice_T.TextChanged
        If Len(Me.txtGas_L1.Text) > 0 And Len(Me.txtGas_L2.Text) > 0 And Len(Me.txtFinalSwapTranchePrice_T.Text) > 0 Then
            Call CalculateValues()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewCurrency.Click
        frmCurrency.FormBorderStyle = FormBorderStyle.Fixed3D
        frmCurrency.Location = New Point(250, 300)
        frmCurrency.Dock = DockStyle.Fill
        frmCurrency.ShowDialog()
    End Sub



    Private Sub CalculateCommissions()
        'retraso = 5000 + GetTickCount
        'While retraso >= GetTickCount
        '    frmProcess.Show()
        '    Application.DoEvents()
        'End While
        If Len(LTrim(RTrim(Me.txtFinalSwapTranchePrice_T.Text.ToString))) > 0 Then
            If Len(LTrim(RTrim(Me.txtumberofBTC_T.Text.ToString))) > 0 Then
                If Len(LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))) > 0 Then

                    Dim par As New ceCommissions
                    Dim BusinessLogic As New cnCommissions

                    par.Final_Swap_Tranche_Price = LTrim(RTrim(Me.txtFinalSwapTranchePrice_T.Text))
                    par.Number_of_BTC = LTrim(RTrim(Me.txtumberofBTC_T.Text))
                    par.TransactionDate = LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))
                    par.BLUE_TRIANGLES_LTD = GlobalVariables.vBLUE_TRIANGLES_LTD
                    par.JOHN_LUMLEY = GlobalVariables.vJOHN_LUMLEY
                    par.RYAN_FENDLY = GlobalVariables.vRYAN_FENDLY
                    par.ANTHONY_CRISCI = GlobalVariables.vANTHONY_CRISCI

                    Me.dgvCommissions.DataSource = BusinessLogic.CalculateTransactionCommission(par).Tables("Commissions")
                    Call FormatCommissions()

                End If
            End If
        End If

    End Sub

    Private Sub FormatCommissions()
        With Me.dgvCommissions
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .Rows(0).Selected = False
            .Columns(0).Visible = True
            .Columns(0).HeaderText = "Agents"
            .Columns(0).Width = 280
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).Visible = True
            .Columns(1).HeaderText = "Currency"
            .Columns(1).Width = 150
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).Visible = True
            .Columns(2).HeaderText = "Transaction Date"
            .Columns(2).Width = 190
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = True
            .Columns(5).HeaderText = "Gross Disbursement Amount"
            .Columns(5).Width = 260
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).Visible = True
            .Columns(6).HeaderText = "Total Gross Disbursement Amount"
            .Columns(6).Width = 260
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).Visible = False

        End With

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call FormatControls()
        Call GetTransaction_ID()
        Me.cmbProvider_T.Focus()
    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Call CalculateValues()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call NewTransaction()
        Call TransactionLine()
        Call CommissionLine()
        'Call FormatControls()
        'Call GetTransaction_ID()
        Call FinishNewTransaction()
    End Sub

    Sub FinishNewTransaction()
        Dim ans As Integer
        ans = MsgBox("Do you want create another transaction?", MsgBoxStyle.YesNo, "")
        If ans = MsgBoxResult.Yes Then
            Call FormatControls()
            Call GetTransaction_ID()
        Else
            Me.Close()
        End If
    End Sub


    Private Sub NewTransaction()

        Dim par As New ceTransaction
        par.TransactionID = LTrim(RTrim(Me.txtTransactionID_T.Text))
        par.ProviderID = LTrim(RTrim(Me.cmbProvider_T.SelectedValue.ToString))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency_T.SelectedValue))
        par.TransactionDate = LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))
        par.Final_Swap_Tranche_Price = (RTrim(Me.txtFinalSwapTranchePrice_T.Text))
        par.Number_of_BTC = LTrim(RTrim(Me.txtumberofBTC_T.Text))
        par.TrancheID = LTrim(RTrim(Me.txtTranchesExecute_T.Text))
        par.User = LTrim(RTrim(Environment.UserName))
        par.TransactioType = "Debit"
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        BusinessLogic.NewTransaction(par)

    End Sub



    'Private Sub CreditTransaction(ByVal par As ceTransaction)
    '    Call TransactionLine()
    'End Sub



    Private Sub TransactionLine()
        Dim par As New ceTransaction

        Dim dtTransactionLine As New DataTable
        dtTransactionLine.Columns.Add("Transaction_ID", GetType(String))
        dtTransactionLine.Columns.Add("ProviderID", GetType(String))
        dtTransactionLine.Columns.Add("CurrencyID", GetType(String))
        dtTransactionLine.Columns.Add("TransactionDate", GetType(String))
        dtTransactionLine.Columns.Add("Gross_Disbursement_Amount", GetType(String))
        dtTransactionLine.Columns.Add("Net_Disbursement_Amount", GetType(String))
        dtTransactionLine.Columns.Add("Gass_Fee", GetType(String))
        dtTransactionLine.Columns.Add("Tranches_Executed", GetType(String))
        ' dtTransactionLine.Columns.Add("TransactioType", GetType(String))
        dtTransactionLine.Columns.Add("Transaction_Status", GetType(String))
        dtTransactionLine.Columns.Add("Income", GetType(String))
        dtTransactionLine.Columns.Add("DailyDisbursment", GetType(String))
        Dim Dr As DataRow

        Dr = dtTransactionLine.NewRow
        Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
        Dr("ProviderID") = LTrim(RTrim(Me.txtProvider_L1.Text.ToString))
        Dr("CurrencyID") = LTrim(RTrim(Me.txtCurrency_L1.Text.ToString))
        Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))
        Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGrossD_L1.Text.ToString))
        Dr("Net_Disbursement_Amount") = LTrim(RTrim(Me.txtNet_L1.Text.ToString))
        Dr("Gass_Fee") = LTrim(RTrim(Me.txtGas_L1.Text.ToString))
        Dr("Tranches_Executed") = LTrim(RTrim(Me.txtTranchesExecute_T.Text.ToString))
        ' Dr("TransactioType") = "Credit"
        Dr("Transaction_Status") = "Paid"
        Dr("Income") = Nothing
        Dr("DailyDisbursment") = Nothing
        dtTransactionLine.Rows.Add(Dr)


        Dr = dtTransactionLine.NewRow
        Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
        Dr("ProviderID") = LTrim(RTrim(Me.txtProvider_L2.Text.ToString))
        Dr("CurrencyID") = LTrim(RTrim(Me.txtCurrency_L2.Text.ToString))
        Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))
        Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGrossD_L2.Text.ToString))
        Dr("Net_Disbursement_Amount") = LTrim(RTrim(Me.txtNet_L2.Text.ToString))
        Dr("Gass_Fee") = LTrim(RTrim(Me.txtGas_L2.Text.ToString))
        Dr("Tranches_Executed") = LTrim(RTrim(Me.txtTranchesExecute_T.Text.ToString))
        ' Dr("TransactioType") = "Credit"
        Dr("Transaction_Status") = "Paid"
        Dr("Income") = Nothing
        Dr("DailyDisbursment") = Nothing
        dtTransactionLine.Rows.Add(Dr)


        'TADROS USD 
        Dr = dtTransactionLine.NewRow
        Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
        Dr("ProviderID") = LTrim(RTrim(Me.txtProvider_L3.Text.ToString))
        Dr("CurrencyID") = LTrim(RTrim(Me.txtCurrency_L31.Text.ToString))
        Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))
        Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGrossD_L31.Text.ToString))
        Dr("Net_Disbursement_Amount") = LTrim(RTrim(Me.txtNet_L31.Text.ToString))
        Dr("Gass_Fee") = "0"
        Dr("Tranches_Executed") = LTrim(RTrim(Me.txtTranchesExecute_T.Text.ToString))
        '  Dr("TransactioType") = "Credit"
        Dr("Transaction_Status") = "Pending"
        Dr("Income") = LTrim(RTrim(Me.txtTadrossIncome.Text))
        Dr("DailyDisbursment") = LTrim(RTrim(Me.txtGrossDailyTadrossDisbursment.Text.ToString))
        dtTransactionLine.Rows.Add(Dr)

        'TADROS USDT 
        Dr = dtTransactionLine.NewRow
        Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
        Dr("ProviderID") = LTrim(RTrim(Me.txtProvider_L3.Text.ToString))
        Dr("CurrencyID") = LTrim(RTrim(Me.txtCurrency_L32.Text.ToString))
        Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))
        Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGrossD_L32.Text.ToString))
        Dr("Net_Disbursement_Amount") = LTrim(RTrim(Me.txtNet_L32.Text.ToString))
        Dr("Gass_Fee") = "0"
        Dr("Tranches_Executed") = LTrim(RTrim(Me.txtTranchesExecute_T.Text.ToString))
        '  Dr("TransactioType") = "Credit"
        Dr("Transaction_Status") = "Pending"
        Dr("Income") = LTrim(RTrim(Me.txtTadrossIncome.Text.ToString))
        Dr("DailyDisbursment") = LTrim(RTrim(Me.txtGrossDailyTadrossDisbursment.Text.ToString))
        dtTransactionLine.Rows.Add(Dr)

        'TADROS BTC
        Dr = dtTransactionLine.NewRow
        Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
        Dr("ProviderID") = LTrim(RTrim(Me.txtProvider_L3.Text.ToString))
        Dr("CurrencyID") = LTrim(RTrim(Me.txtCurrency_L33.Text.ToString))
        Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))
        Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGrossD_L33.Text.ToString))
        Dr("Net_Disbursement_Amount") = LTrim(RTrim(Me.txtNet_L33.Text.ToString))
        Dr("Gass_Fee") = "0"
        Dr("Tranches_Executed") = LTrim(RTrim(Me.txtTranchesExecute_T.Text.ToString))
        '  Dr("TransactioType") = "Credit"
        Dr("Transaction_Status") = "Pending"
        Dr("Income") = LTrim(RTrim(Me.txtTadrossIncome.Text.ToString))
        Dr("DailyDisbursment") = LTrim(RTrim(Me.txtGrossDailyTadrossDisbursment.Text.ToString))
        dtTransactionLine.Rows.Add(Dr)

        par.dtTransactionsLine = dtTransactionLine
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        BusinessLogic.NewTransactionLine(par)
    End Sub

    Private Sub CommissionLine()
        Dim par As New ceCommissions
        Dim dtCommissionLine As New DataTable

        dtCommissionLine.Columns.Add("Transaction_ID", GetType(String))
        dtCommissionLine.Columns.Add("Agent", GetType(String))
        dtCommissionLine.Columns.Add("Currency", GetType(String))
        dtCommissionLine.Columns.Add("TransactionDate", GetType(String))
        dtCommissionLine.Columns.Add("Gross_Disbursement_Amount", GetType(String))
        dtCommissionLine.Columns.Add("Net_Disbursement_Amount", GetType(String))
        dtCommissionLine.Columns.Add("Gass_Fee", GetType(String))
        dtCommissionLine.Columns.Add("Tranches_Executed", GetType(String))
        dtCommissionLine.Columns.Add("Commission_Status", GetType(String))
        dtCommissionLine.Columns.Add("Income", GetType(String))
        dtCommissionLine.Columns.Add("DailyDisbursment", GetType(String))
        Dim r As DataRow

        For i = 0 To Me.dgvCommissions.Rows.Count - 1
            r = dtCommissionLine.NewRow
            r("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
            r("Agent") = dgvCommissions.Item(0, i).Value.ToString
            r("Currency") = dgvCommissions.Item(1, i).Value.ToString
            r("TransactionDate") = dgvCommissions.Item(2, i).Value.ToString
            r("Gross_Disbursement_Amount") = dgvCommissions.Item(5, i).Value.ToString
            r("Net_Disbursement_Amount") = Nothing
            r("Gass_Fee") = Nothing
            r("Tranches_Executed") = LTrim(RTrim(Me.txtTranchesExecute_T.Text.ToString))
            r("Commission_Status") = "Pending"
            r("Income") = Nothing
            r("DailyDisbursment") = Nothing
            dtCommissionLine.Rows.Add(r)
        Next

        par.dtCommissionLine = dtCommissionLine
        Dim BusinessLogic As New BusinessLogic.cnCommissions
        BusinessLogic.GetAddNewCommissions(par)

    End Sub




    ''''' Format and Clean Controls

    Private Sub EnabledCombobox(ByVal c1 As Control)
        For Each c As Control In c1.Controls
            If TypeOf c Is ComboBox Then
                c1.Enabled = True
            Else
                Clear(c)
            End If
        Next
    End Sub


    Private Sub DisableControlls(ByVal c1 As Control)
        For Each c As Control In c1.Controls

            If TypeOf c Is TextBox Then
                If c.Name = "txtGas_L1" Or c.Name = "txtGas_L2" Or c.Name = "txtGas_L32" Or c.Name = "txtGas_L33" Then
                    c.Enabled = True
                    c.BackColor = Color.LightSteelBlue
                Else
                    c.Enabled = False
                    c.BackColor = Color.WhiteSmoke
                End If
                Clear(c)
            End If

            If TypeOf c Is ComboBox Then
                If c.Name = "cmbProvider_T" Then
                    c.Enabled = True
                Else
                    c.Enabled = False
                End If
            Else
                Clear(c)
            End If

            If TypeOf c Is DataGridView Then
                c.Enabled = False
            Else
                Clear(c)
            End If

            If TypeOf c Is DateTimePicker Then
                c.Enabled = False
            Else
                Clear(c)
            End If

            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Enabled = False
            Else
                Clear(c)
            End If

            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Enabled = False
            Else
                Clear(c)
            End If

            If TypeOf c Is MaskedTextBox Then
                c.Enabled = False
            Else
                Clear(c)
            End If

        Next
        'For Each c As Control In gbCommissions.Controls
        '    If TypeOf c Is TextBox Then
        '        c.Enabled = False
        '    End If
        '    If TypeOf c Is Label Then
        '        c.Enabled = False
        '    End If
        'Next

    End Sub


    Private Sub HideControlls(ByVal c1 As Control)
        For Each c As Control In c1.Controls

            If TypeOf c Is TextBox Then
                c.Visible = False
            Else
                Clear(c)
            End If

            If TypeOf c Is DataGridView Then
                c.Visible = False
            Else
                Clear(c)
            End If

            If TypeOf c Is ComboBox Then
                c.Visible = False
            Else
                Clear(c)
            End If

            If TypeOf c Is DateTimePicker Then
                c.Visible = False
            Else
                Clear(c)
            End If

            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Visible = False
            Else
                Clear(c)
            End If

            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Visible = False
            Else
                Clear(c)
            End If

            If TypeOf c Is MaskedTextBox Then
                c.Visible = False
            Else
                Clear(c)
            End If

            If TypeOf c Is Button Then
                c.Visible = False
            Else
                Clear(c)
            End If

            If TypeOf c Is Button Then
                c.Visible = False
            Else
                Clear(c)
            End If

            If TypeOf c Is GroupBox Then
                c.Visible = False
            Else
                Clear(c)
            End If
        Next
    End Sub

    Private Sub VisibleControlls(ByVal c1 As Control)
        For Each c As Control In c1.Controls

            If TypeOf c Is TextBox Then
                c.Visible = True
            End If

            If TypeOf c Is ComboBox Then
                c.Visible = True
            End If

            If TypeOf c Is DataGridView Then
                c.Visible = True
            End If


            If TypeOf c Is DateTimePicker Then
                c.Visible = True
            End If


            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Visible = True
            End If


            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Visible = True
            End If


            If TypeOf c Is MaskedTextBox Then
                c.Visible = True
            End If

            If TypeOf c Is Button Then
                c.Visible = True
            End If

            If TypeOf c Is GroupBox Then
                c.Visible = True
            End If
        Next
        Me.gbCommissions.Visible = True
    End Sub


    Private Sub EnableControlls(ByVal c1 As Control)

        For Each c As Control In c1.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = True
            Else
                Clear(c)
            End If

            If TypeOf c Is ComboBox Then
                c.Enabled = True
            Else
                Clear(c)
            End If


            If TypeOf c Is DataGridView Then
                c.Enabled = True
            Else
                Clear(c)
            End If

            If TypeOf c Is DateTimePicker Then
                c.Enabled = True
            Else
                Clear(c)
            End If


            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Enabled = True
            Else
                Clear(c)
            End If


            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Enabled = True
            Else
                Clear(c)
            End If


            If TypeOf c Is MaskedTextBox Then
                c.Enabled = True
            Else
                Clear(c)
            End If

        Next

    End Sub

    Sub Clear(ByVal c1 As Control)

        For Each c As Control In c1.Controls
            If TypeOf c Is TextBox Then
                If c.Name = "txtGrossD_L31" Or c.Name = "txtGrossD_L32" Or c.Name = "txtGrossD_L33" Or c.Name = "txtNet_L31" _
                   Or c.Name = "txtNet_L32" Or c.Name = "txtNet_L33" Or c.Name = "txtGas_L1" Or c.Name = "txtGas_L2" Or c.Name = "txtGrossD_L1" Or c.Name = "txtGrossD_L2" Then
                    c.Text = 0
                Else
                    c.Text = Nothing
                End If

            End If
            If TypeOf c Is ComboBox Then
                c.Text = Nothing

            End If

            If TypeOf c Is DateTimePicker Then
                c.Text = Date.Today

            End If
            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Checked = False

            End If
            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Checked = False

            End If
            If TypeOf c Is MaskedTextBox Then
                c.Text = ""

            End If

        Next
    End Sub












    'Private Sub CommissionLineOld()

    '    Dim par As New ceCommissions
    '    Dim dtCommissionLine As New DataTable

    '    dtCommissionLine.Columns.Add("Transaction_ID", GetType(String))
    '    dtCommissionLine.Columns.Add("Agent", GetType(String))
    '    dtCommissionLine.Columns.Add("Currency", GetType(String))
    '    dtCommissionLine.Columns.Add("TransactionDate", GetType(String))
    '    dtCommissionLine.Columns.Add("Gross_Disbursement_Amount", GetType(String))
    '    dtCommissionLine.Columns.Add("Net_Disbursement_Amount", GetType(String))
    '    dtCommissionLine.Columns.Add("Gass_Fee", GetType(String))
    '    dtCommissionLine.Columns.Add("Commission_Status", GetType(String))
    '    Dim Dr As DataRow


    '    'C2C USDT 
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_C2C_USDT.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_C2C_USDT.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_C2C_USDT.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)
    '    'C2C BTC
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_C2C_BTC.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_C2C_BTC.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_C2C_BTC.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)

    '    'PAG USDT
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_PAG_USDT.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_PAG_USDT.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_PAG_USDT.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)
    '    'PAG BTC
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_PAG_BTC.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_PAG_BTC.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_PAG_BTC.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)


    '    'IGL USDT
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_IGL_USDT.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_IGL_USDT.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_IGL_USDT.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)
    '    'IGLBTC
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_IGL_BTC.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_IGL_BTC.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_IGL_BTC.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)

    '    'Charity USDT
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_Charity.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_Charity.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_Charity.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)


    '    'Blue Triangles LTD USDT
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_Triangle.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_Triangle.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_Triangle.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)

    '    'John Lumley USDT
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_Lumley.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_Lumley.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_Lumley.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)

    '    'Ryan Fendly USDT
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_Fendly.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_Fendly.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_Fendly.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)

    '    'Anthony Crisci USDT
    '    Dr = dtCommissionLine.NewRow
    '    Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
    '    Dr("Agent") = LTrim(RTrim(Me.txtAgent_Crisci.Text.ToString))
    '    Dr("Currency") = LTrim(RTrim(Me.txtCurrency_Crisci.Text.ToString))
    '    Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
    '    Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGross_Crisci.Text.ToString))
    '    Dr("Net_Disbursement_Amount") = Nothing
    '    Dr("Gass_Fee") = Nothing
    '    Dr("Commission_Status") = "Pending"
    '    dtCommissionLine.Rows.Add(Dr)

    '    par.dtCommissionLine = dtCommissionLine
    '    Dim BusinessLogic As New BusinessLogic.cnCommissions
    '    BusinessLogic.NewTransactionLine(par)

    'End Sub





End Class