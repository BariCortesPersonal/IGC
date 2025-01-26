
Imports Entity
Imports BusinessLogic
Imports System.Globalization
Imports Presentation.GlobalVariables
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.IO
Imports Windows.Win32.UI.Input



Public Class frmEmptyTransactions_Old



    Private Sub frmTransactions_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = vWidth
        Me.Height = vHeight - 20

        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.dtpTransactionDate_T.Format = DateTimePickerFormat.Custom
        Me.dtpTransactionDate_T.CustomFormat = "yyyy-MM-dd"
        Call FormatControls()
        MsgBox(vWidth)
    End Sub



    Private Sub FormatControls()
        Me.dtpTransactionDate_T.DropDownAlign = LeftRightAlignment.Right
        Me.txtTransactionID_T.TextAlign = HorizontalAlignment.Right
        Me.txtFinalSwapTranchePrice_T.TextAlign = HorizontalAlignment.Right
        Me.txtumberofBTC_T.TextAlign = HorizontalAlignment.Right
        Me.txtTranchesExecute_T.TextAlign = HorizontalAlignment.Right
        Me.cmbProvider_T.Focus()

        Call Clear(gbTransaction)
        Call Clear(PanelTransactionLines)
        Call Clear(gbCommissions)
        Call DisableControlls(gbTransaction)
        Call DisableControlls(PanelTransactionLines)
        Call DisableControlls(gbCommissions)
        Call GetTransaction_ID()

        Me.dgvTransactionLine.DataSource = Nothing
        Me.dgvCommissions.DataSource = Nothing

        Me.dgvTransactionLine.Enabled = True
        Me.chbGassFee.Enabled = True
        Me.chbGassFee.Checked = False
    End Sub


    Private Sub GetTransaction_ID()
        Dim Obj As New ceID
        Dim ds As New DataTable
        Dim BusinessLogic As New BusinessLogic.cnNewID
        ds = BusinessLogic.GetID().Tables("ID")
        Me.txtTransactionID_T.Text = ds.Rows(0).Item(0).ToString()
    End Sub



    Private Sub LoadForms()
        GetTrancheNumber()
    End Sub



    Private Sub GetTrancheNumber()
        Dim ds As New DataTable
        Dim par As New ceTransaction
        par.ProviderID = LTrim(RTrim(Me.cmbProvider_T.SelectedValue))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency_T.SelectedValue))
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        ds = BusinessLogic.GetTrancheID(par).Tables("Tranche")
        Me.txtTranchesExecute_T.Text = ds.Rows(0).Item(0).ToString()
    End Sub


    Private Sub CalculateTransaction()

        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
        Dim ds As New DataTable
        Dim par As New ceTransaction
        par.ProviderID = LTrim(RTrim(Me.cmbProvider_T.Text.ToString))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency_T.Text.ToString))
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        ds = BusinessLogic.GetTransactionDefaultValues(par).Tables("Transaction")
        Me.txtumberofBTC_T.Text = ds.Rows(0).Item("Total_Currency").ToString()
        Me.txtFinalSwapTranchePrice_T.Text = ds.Rows(0).Item("FinalSwapTranchePrice").ToString()
    End Sub

    Private Sub CalculateTransactionLine()
        If Me.txtGas.Text = Nothing Then
            Me.txtGas.Text = "0.000"
        End If

        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
        Dim ds As New DataTable
        Dim par As New ceTransaction
        par.ProviderID = LTrim(RTrim(Me.cmbProvider_L.Text.ToString))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency_L.Text.ToString))
        par.Final_Swap_Tranche_Price = LTrim(RTrim(Me.txtFinalSwapTranchePrice_T.Text.ToString))
        par.Number_of_BTC = LTrim(RTrim(Me.txtumberofBTC_T.Text.ToString))
        par.GasFee = Me.txtGas.Text
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        ds = BusinessLogic.GetTransactionLineDefaultValues(par).Tables("Transaction")

        Me.txtGrossD.Text = ds.Rows(0).Item("GrossDisbursement").ToString()
        Me.txtNet.Text = ds.Rows(0).Item("NetDisbursement").ToString()

    End Sub


    Private Sub CalculateCommission()

        If Me.txtGass_C.Text = Nothing Then
            Me.txtGass_C.Text = "0.000"
        End If

        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
        Dim ds As New DataTable
        Dim par As New ceTransaction
        par.ProviderID = LTrim(RTrim(Me.cmbAgent_C.Text.ToString))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency_C.Text.ToString))
        par.Final_Swap_Tranche_Price = LTrim(RTrim(Me.txtFinalSwapTranchePrice_T.Text.ToString))
        par.Number_of_BTC = LTrim(RTrim(Me.txtumberofBTC_T.Text.ToString))
        par.GasFee = Me.txtGass_C.Text

        Dim BusinessLogic As New BusinessLogic.cnCommissions
        ds = BusinessLogic.GetCommissionDefaultValues(par).Tables("Commission")

        Me.txtGrossD_C.Text = ds.Rows(0).Item("GrossDisbursement").ToString()
        Me.txtNet_C.Text = ds.Rows(0).Item("NetDisbursement").ToString()

    End Sub




    ''' ////   Buttons  /////

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call FormatControls()
        Call GetTransaction_ID()
        Me.cmbProvider_T.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewCurrency.Click
        frmCurrency.FormBorderStyle = FormBorderStyle.Fixed3D
        frmCurrency.Location = New Point(250, 300)
        frmCurrency.Dock = DockStyle.Fill
        frmCurrency.ShowDialog()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim t_line As Integer
        Dim t_com As Integer

        If Me.dgvTransactionLine.Rows.Count = 0 Then
            t_line = MsgBox("You are creating a transaction without any associated lines. Do you want to continue?", MsgBoxStyle.YesNo, "")
            If t_line = MsgBoxResult.Yes Then

                If Me.dgvCommissions.Rows.Count = 0 Then
                    t_com = MsgBox("You are creating a transaction without any Commission. Do you want to continue?", MsgBoxStyle.YesNo, "")
                    If t_com = MsgBoxResult.Yes Then
                        Call AddNewTransaction()
                        Call AddNewTransactionLines()
                        Call AddNewCommissions()
                    Else
                        Exit Sub
                    End If
                Else
                    Call AddNewTransaction()
                    Call AddNewTransactionLines()
                    Call AddNewCommissions()
                End If

            Else
                Exit Sub
            End If
        Else

            If Me.dgvCommissions.Rows.Count = 0 Then
                t_com = MsgBox("You are creating a transaction without any Commission. Do you want to continue?", MsgBoxStyle.YesNo, "")
                If t_com = MsgBoxResult.Yes Then
                    Call AddNewTransaction()
                    Call AddNewTransactionLines()
                    Call AddNewCommissions()
                Else
                    Exit Sub
                End If
            Else
                Call AddNewTransaction()
                Call AddNewTransactionLines()
                Call AddNewCommissions()
            End If

        End If
        Call FinishNewTransaction()
    End Sub

    Private Sub btnCreateLine_Click(sender As Object, e As EventArgs) Handles btnCreateLine.Click
        Call TransactionLineCheckValues()
    End Sub

    Private Sub btnClearLine_Click(sender As Object, e As EventArgs) Handles btnClearLine.Click
        Call Clear(PanelTransactionLines)
        Call DisableControlls(PanelTransactionLines)
        cmbProvider_L.Enabled = True
    End Sub


    Private Sub BbtnClear_C_Click(sender As Object, e As EventArgs) Handles btnClear_C.Click
        Call Clear(gbCommissions)
        Call DisableControlls(gbCommissions)
        cmbAgent_C.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Call CommissionCheckValues()
    End Sub



    ''' ///  Buttons End  ////






    '''///   Contrlos  ////
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
        cmbCurrency_T.DataSource = Nothing
        cmbCurrency_T.DataBindings.Clear()
        cmbCurrency_T.Items.Clear()
        Dim BusinessLogic As New cnCurrency
        cmbCurrency_T.DataSource = BusinessLogic.GetCurrency.Tables("Currency")
        cmbCurrency_T.ValueMember = "Currency_ID"
        cmbCurrency_T.DisplayMember = "Currency_Name"
    End Sub


    Private Sub cmbCurrency_T_TextChanged(sender As Object, e As EventArgs) Handles cmbCurrency_T.SelectionChangeCommitted
        LoadForms()
        gbTransaction.Focus()
        Call CalculateTransaction()
        Me.txtFinalSwapTranchePrice_T.Enabled = True
        Me.txtFinalSwapTranchePrice_T.BackColor = Color.LightSteelBlue
        Me.cmbProvider_L.Enabled = True
        Me.cmbAgent_C.Enabled = True
    End Sub


    Private Sub cmbProvider_L_DropDown(sender As Object, e As EventArgs) Handles cmbProvider_L.DropDown
        cmbProvider_L.DataSource = Nothing
        cmbProvider_L.Items.Clear()
        cmbCurrency_L.DataSource = Nothing
        cmbCurrency_L.DataBindings.Clear()
        cmbCurrency_L.Items.Clear()
        Call Clear(PanelTransactionLines)

        Dim BusinessLogic As New cnProviders
        cmbProvider_L.DataSource = BusinessLogic.GetProvider.Tables("Provider")
        cmbProvider_L.ValueMember = "Provider_ID"
        cmbProvider_L.DisplayMember = "Full_Name"
    End Sub

    Private Sub cmbProvider_L_TextChanged(sender As Object, e As EventArgs) Handles cmbProvider_L.SelectionChangeCommitted
        cmbCurrency_L.Enabled = True
        cmbCurrency_L.Focus()
    End Sub

    Private Sub cmbCurrency_L_DropDown(sender As Object, e As EventArgs) Handles cmbCurrency_L.DropDown
        cmbCurrency_L.DataSource = Nothing
        cmbCurrency_L.DataBindings.Clear()
        cmbCurrency_L.Items.Clear()
        Dim BusinessLogic As New cnCurrency
        cmbCurrency_L.DataSource = BusinessLogic.GetCurrency.Tables("Currency")
        cmbCurrency_L.ValueMember = "Currency_ID"
        cmbCurrency_L.DisplayMember = "Currency_Name"
    End Sub



    Private Sub cmbCurrency_L_TextChanged(sender As Object, e As EventArgs) Handles cmbCurrency_L.SelectionChangeCommitted
        Me.txtGas.Enabled = True
        Me.txtGas.BackColor = Color.LightSteelBlue
        Me.chbGassFee.Enabled = True
        Call CalculateTransactionLine()
    End Sub



    Private Sub cmbAgent_C_DropDown(sender As Object, e As EventArgs) Handles cmbAgent_C.DropDown
        cmbAgent_C.DataSource = Nothing
        cmbAgent_C.Items.Clear()
        cmbCurrency_C.DataSource = Nothing
        cmbCurrency_C.DataBindings.Clear()
        cmbCurrency_C.Items.Clear()

        Dim BusinessLogic As New BusinessLogic.cnAgent
        cmbAgent_C.DataSource = BusinessLogic.GetAgent.Tables("Agent")
        cmbAgent_C.ValueMember = "Agent_ID"
        cmbAgent_C.DisplayMember = "Full_Name"
    End Sub

    Private Sub cmbAgent_C_TextChanged(sender As Object, e As EventArgs) Handles cmbAgent_C.SelectionChangeCommitted
        cmbCurrency_C.Enabled = True
        cmbCurrency_C.Focus()
    End Sub

    Private Sub cmbCurrency_C_DropDown(sender As Object, e As EventArgs) Handles cmbCurrency_C.DropDown
        cmbCurrency_C.DataSource = Nothing
        cmbCurrency_C.DataBindings.Clear()
        cmbCurrency_C.Items.Clear()
        Dim BusinessLogic As New cnCurrency
        cmbCurrency_C.DataSource = BusinessLogic.GetCurrency.Tables("Currency")
        cmbCurrency_C.ValueMember = "Currency_ID"
        cmbCurrency_C.DisplayMember = "Currency_Name"
    End Sub



    Private Sub cmbCurrency_C_TextChanged(sender As Object, e As EventArgs) Handles cmbCurrency_C.SelectionChangeCommitted
        Me.txtGrossD_C.Enabled = True
        Me.txtNet_C.Enabled = True
        Me.chbGassFee_C.Enabled = True
        Me.chbGassFee_C.Checked = True

        Call CalculateCommission()
    End Sub

    'Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblGass_C.DoubleClick
    '    Me.txtGass_C.BackColor = Color.LightSteelBlue
    '    Me.txtGass_C.Enabled = True
    'End Sub


    Private Sub txtGrossD_Click(sender As Object, e As EventArgs) Handles txtGrossD.Click
        If Me.txtGrossD.Enabled = True Then
            txtGrossD.Text = ""
        End If
    End Sub

    Private Sub txtGrossD_MouseLeave(sender As Object, e As EventArgs) Handles txtGrossD.MouseLeave
        If Me.txtGrossD.Text = "" Then
            txtGrossD.Text = "0.000"
        End If
    End Sub

    Private Sub txtGas_Click(sender As Object, e As EventArgs) Handles txtGas.Click
        If Me.txtGas.Enabled = True Then
            txtGas.Text = ""
        End If
    End Sub

    Private Sub txtGas_MouseLeave(sender As Object, e As EventArgs) Handles txtGas.MouseLeave
        If Me.txtGas.Text = "" Then
            txtGas.Text = "0.000"
        End If
    End Sub

    Private Sub txtNet_Click(sender As Object, e As EventArgs) Handles txtNet.Click
        If Me.txtNet.Enabled = True Then
            txtNet.Text = ""
        End If
    End Sub

    Private Sub txtNet_MouseLeave(sender As Object, e As EventArgs) Handles txtNet.MouseLeave
        If Me.txtNet.Text = "" Then
            txtNet.Text = "0.000"
        End If
    End Sub


    Private Sub txtFinalSwapTranchePrice_T_Click(sender As Object, e As EventArgs) Handles txtFinalSwapTranchePrice_T.Click
        If Me.txtFinalSwapTranchePrice_T.Enabled = True Then
            txtFinalSwapTranchePrice_T.Text = ""
        End If
    End Sub

    Private Sub txtFinalSwapTranchePrice_T_MouseLeave(sender As Object, e As EventArgs) Handles txtFinalSwapTranchePrice_T.MouseLeave
        If Me.txtFinalSwapTranchePrice_T.Text = "" Then
            txtFinalSwapTranchePrice_T.Text = "0.000"
        End If
        If Not IsNumeric(txtFinalSwapTranchePrice_T.Text) Then
            txtFinalSwapTranchePrice_T.Text = "0.000"
        End If
    End Sub

    Private Sub txtumberofBTC_TT_Click(sender As Object, e As EventArgs) Handles txtumberofBTC_T.Click
        If Me.txtumberofBTC_T.Enabled = True Then
            txtumberofBTC_T.Text = ""
        End If
    End Sub

    Private Sub txtumberofBTC_T_MouseLeave(sender As Object, e As EventArgs) Handles txtumberofBTC_T.MouseLeave
        If Me.txtumberofBTC_T.Text = "" Then
            txtumberofBTC_T.Text = 0
        End If
        If Not IsNumeric(txtumberofBTC_T.Text) Then
            txtumberofBTC_T.Text = "40"
        End If
    End Sub


    Private Sub txtNet_C_Click(sender As Object, e As EventArgs) Handles txtNet_C.Click
        If Me.txtNet_C.Enabled = True Then
            txtNet_C.Text = ""
        End If
    End Sub

    Private Sub txtNet_C_MouseLeave(sender As Object, e As EventArgs) Handles txtNet_C.MouseLeave
        If Me.txtNet_C.Text = "" Then
            txtNet_C.Text = "0.000"
        End If
        If Not IsNumeric(txtNet_C.Text) Then
            txtNet_C.Text = "0.000"
        End If
    End Sub


    Private Sub txtGrossD_C_Click(sender As Object, e As EventArgs) Handles txtGrossD_C.Click
        If Me.txtGrossD_C.Enabled = True Then
            txtGrossD_C.Text = ""
        End If
    End Sub

    Private Sub txtGrossD_C_MouseLeave(sender As Object, e As EventArgs) Handles txtGrossD_C.MouseLeave
        If Me.txtGrossD_C.Text = "" Then
            txtGrossD_C.Text = "0.000"
        End If
        If Not IsNumeric(txtGrossD_C.Text) Then
            txtGrossD_C.Text = "0.000"
        End If
    End Sub


    Private Sub txtGass_C_Click(sender As Object, e As EventArgs) Handles txtGass_C.Click
        If Me.txtGass_C.Enabled = True Then
            txtGass_C.Text = ""
        End If
    End Sub

    Private Sub txtGass_C_MouseLeave(sender As Object, e As EventArgs) Handles txtGass_C.MouseLeave
        If Me.txtGass_C.Text = "" Then
            txtGass_C.Text = "0.000"
        End If
        If Not IsNumeric(txtGass_C.Text) Then
            txtGass_C.Text = "0.000"
        End If

    End Sub



    Private Sub lblFinalSwapTranchePrice_Click_1(sender As Object, e As EventArgs) Handles lblFinalSwapTranchePrice.Click
        txtFinalSwapTranchePrice_T.Enabled = True
    End Sub

    Private Sub txtFinalSwapTranchePrice_T_TextChanged(sender As Object, e As EventArgs) Handles txtFinalSwapTranchePrice_T.TextChanged
        If Len(txtFinalSwapTranchePrice_T.Text) > 0 Then
            If Not IsNumeric(txtFinalSwapTranchePrice_T.Text) Then
                txtFinalSwapTranchePrice_T.Text = "0.000"
            End If
        End If

        If Len(Me.txtFinalSwapTranchePrice_T.Text) > 0 And Len(Me.txtumberofBTC_T.Text) > 0 And Len(Me.cmbProvider_L.Text) > 0 And Len(Me.cmbCurrency_L.Text) > 0 _
             And Len(Me.txtGrossD.Text) > 0 And Len(Me.txtGas.Text) > 0 And (Len(Me.txtNet.Text) > 0 Or Me.chbGassFee.Checked = True) Then
            Call CalculateTransactionLine()
        End If

        If Len(Me.txtFinalSwapTranchePrice_T.Text) > 0 And Len(Me.txtumberofBTC_T.Text) > 0 And Len(Me.cmbAgent_C.Text) > 0 And Len(Me.cmbCurrency_C.Text) > 0 _
             And Len(Me.txtGrossD_C.Text) > 0 And Len(Me.txtGass_C.Text) > 0 And (Len(Me.txtNet_C.Text) > 0 Or Me.chbGassFee_C.Checked = True) Then
            Call CalculateCommission()
        End If

    End Sub

    Private Sub lblNumberOfBTC_Click(sender As Object, e As EventArgs) Handles lblNumberOfBTC.Click
        txtumberofBTC_T.Enabled = True
    End Sub

    Private Sub txtumberofBTC_T_TextChanged(sender As Object, e As EventArgs) Handles txtumberofBTC_T.TextChanged
        If Len(Me.txtumberofBTC_T.Text) > 0 Then
            If Not IsNumeric(txtumberofBTC_T.Text) Then
                txtumberofBTC_T.Text = "0"
            End If
        End If

        If Len(Me.txtFinalSwapTranchePrice_T.Text) > 0 And Len(Me.txtumberofBTC_T.Text) > 0 And Len(Me.cmbProvider_L.Text) > 0 And Len(Me.cmbCurrency_L.Text) > 0 _
            And Len(Me.txtGrossD.Text) > 0 And Len(Me.txtGas.Text) > 0 And (Len(Me.txtNet.Text) > 0 Or Me.chbGassFee.Checked = True) Then
            Call CalculateTransactionLine()
        End If

        If Len(Me.txtFinalSwapTranchePrice_T.Text) > 0 And Len(Me.txtumberofBTC_T.Text) > 0 And Len(Me.cmbAgent_C.Text) > 0 And Len(Me.cmbCurrency_C.Text) > 0 _
             And Len(Me.txtGrossD_C.Text) > 0 And Len(Me.txtGass_C.Text) > 0 And (Len(Me.txtNet_C.Text) > 0 Or Me.chbGassFee_C.Checked = True) Then
            Call CalculateCommission()
        End If

    End Sub



    Private Sub lblTransactionDate_Click(sender As Object, e As EventArgs) Handles lblTransactionDate.Click
        dtpTransactionDate_T.Enabled = True
    End Sub

    Private Sub chbGassFee_C_CheckedChanged(sender As Object, e As EventArgs) Handles chbGassFee_C.CheckedChanged
        If chbGassFee_C.Checked = True Then
            Me.txtGass_C.Enabled = False
            Me.txtGass_C.Text = "0.000"
        Else
            Me.txtGass_C.Text = "0.000"
            Me.txtGass_C.Enabled = True
        End If
    End Sub

    Private Sub chbGassFee_CheckedChanged(sender As Object, e As EventArgs) Handles chbGassFee.CheckedChanged
        If chbGassFee.Checked = True Then
            Me.txtGas.Enabled = False
            Me.txtGas.Text = "0.000"
        Else
            Me.txtGas.Text = "0.000"
            Me.txtGas.Enabled = True
        End If
    End Sub

    Private Sub txtGas_TextChanged(sender As Object, e As EventArgs) Handles txtGas.TextChanged
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
        If Len(Me.txtGas.Text) > 0 And Me.txtGas.Text > "0.000" Then
            Me.txtNet.Text = Math.Round(Me.txtGrossD.Text - txtGas.Text, 3)
        End If
    End Sub

    ''' ///   Controls End   ///


    Private Sub AddNewTransaction()

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

    Private Sub AddNewTransactionLines()
        Dim dtTransactionLine As New DataTable
        Dim par As New ceTransaction
        dtTransactionLine = dgvTransactionLine.DataSource
        par.dtTransactionsLine = dtTransactionLine
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        BusinessLogic.NewTransactionLine(par)
    End Sub

    Private Sub AddNewCommissions()
        Dim par As New ceCommissions
        Dim dtCommissionLine As New DataTable
        dtCommissionLine = dgvCommissions.DataSource
        par.dtCommissionLine = dtCommissionLine
        Dim BusinessLogic As New BusinessLogic.cnCommissions
        BusinessLogic.GetAddNewCommissions(par)
    End Sub


    Sub FinishCommission()
        Dim ans As Integer
        ans = MsgBox("Do you want add another Commission?", MsgBoxStyle.YesNo, "")
        If ans = MsgBoxResult.Yes Then
            For Each c As Control In gbCommissions.Controls
                If TypeOf c Is TextBox Then
                    c.Text = Nothing
                End If
                If TypeOf c Is ComboBox Then
                    c.Text = Nothing
                End If
            Next
            cmbAgent_C.Enabled = True
            chbGassFee_C.Enabled = True
            chbGassFee_C.Checked = False
            Me.txtGrossD_C.Text = "0.000"
            Me.txtNet_C.Text = "0.000"
            Me.txtGass_C.Text = "0.000"
        Else
            Me.dgvCommissions.Enabled = False
        End If
    End Sub




    Sub FinishTransactionLine()
        Dim ans As Integer
        ans = MsgBox("Do you want add another transaction Line?", MsgBoxStyle.YesNo, "")
        If ans = MsgBoxResult.Yes Then
            For Each c As Control In PanelTransactionLines.Controls
                If TypeOf c Is TextBox Then
                    c.Text = Nothing
                End If
                If TypeOf c Is ComboBox Then
                    c.Text = Nothing
                End If
            Next
            cmbProvider_L.Enabled = True
            chbGassFee.Enabled = True
            chbGassFee.Checked = False
            Me.txtGrossD.Text = "0.000"
            Me.txtNet.Text = "0.000"
            Me.txtGas.Text = "0.000"
        Else
            Me.dgvTransactionLine.Enabled = False
        End If
    End Sub


    Private Sub TransactionLineCheckValues()

        If Len(LTrim(RTrim(Me.cmbProvider_L.Text.ToString))) > 0 Then
            If Len(LTrim(RTrim(Me.cmbCurrency_L.Text.ToString))) > 0 Then
                If chbGassFee.Checked = False And txtGas.Text > 0 Or chbGassFee.Checked = True Then
                    If txtGrossD.Text > 0 Then
                        If txtNet.Text > 0 Then
                            If Me.txtFinalSwapTranchePrice_T.Text > 0 Then
                                If Me.txtumberofBTC_T.Text > 0 Then

                                    Dim strCount As Int128 = 0
                                    For i = 0 To Me.dgvTransactionLine.Rows.Count - 1
                                        If Me.dgvTransactionLine.Item("ProviderID", i).Value.ToString() = Me.cmbProvider_L.Text _
                                              And Me.dgvTransactionLine.Item("CurrencyID", i).Value.ToString() = Me.cmbCurrency_L.Text Then
                                            strCount = strCount + 1
                                        End If
                                    Next
                                    If strCount = 0 Then
                                        Call InsertTransactionLine()
                                        Call Clear(PanelTransactionLines)
                                        Call DisableControlls(PanelTransactionLines)
                                        cmbProvider_L.Enabled = True
                                    Else
                                        MsgBox("That transaction already exists. In the same Tranche, two transactions cannot be created to the same Provider with the same Currency.")
                                        Exit Sub
                                    End If

                                Else
                                    MsgBox("You need to add a correct Number of BTC. The value ​​don't be zero on Empty")
                                End If
                            Else
                                MsgBox("You need to add a correct Final Swap Tranche Price . The value ​​don't be zero on Empty")
                            End If
                        Else
                            MsgBox("You need to add a correct Net Disbursement. The value ​​don't be zero")
                        End If
                    Else
                        MsgBox("You need to add a correct Gross Disbursement. The value ​​don't be zero")
                    End If
                Else
                    MsgBox("You need to add a correct Gas Fee. The value ​​don't be zero")
                End If
            Else
                MsgBox("You need select a correct Currency")
            End If
        Else
            MsgBox("You need select a correct Provider")
        End If
    End Sub


    Private Sub CommissionCheckValues()

        If Len(LTrim(RTrim(Me.cmbAgent_C.Text.ToString))) > 0 Then
            If Len(LTrim(RTrim(Me.cmbCurrency_C.Text.ToString))) > 0 Then
                If chbGassFee_C.Checked = False And txtGass_C.Text > 0 Or chbGassFee_C.Checked = True Then
                    If txtGrossD_C.Text > 0 Then
                        If txtNet_C.Text > 0 Then
                            If Me.txtFinalSwapTranchePrice_T.Text > 0 Then
                                If Me.txtumberofBTC_T.Text > 0 Then


                                    Dim strCount As Int128 = 0
                                    For i = 0 To Me.dgvCommissions.Rows.Count - 1
                                        If Me.dgvCommissions.Item("Agent", i).Value.ToString() = Me.cmbAgent_C.Text _
                                              And Me.dgvCommissions.Item("Currency", i).Value.ToString() = Me.cmbCurrency_C.Text Then
                                            strCount = strCount + 1
                                        End If
                                    Next
                                    If strCount = 0 Then
                                        Call InsertCommission()
                                        Call Clear(gbCommissions)
                                        Call DisableControlls(gbCommissions)
                                        cmbAgent_C.Enabled = True
                                    Else
                                        MsgBox("That Commission already exists. In the same Tranche, two Commissions cannot be created to the same Provider with the same Currency.")
                                        Exit Sub
                                    End If

                                Else
                                    MsgBox("You need to add a correct Number of BTC. The value ​​don't be zero on Empty")
                                End If
                            Else
                                MsgBox("You need to add a correct Final Swap Tranche Price . The value ​​don't be zero on Empty")
                            End If
                        Else
                            MsgBox("You need to add a correct Net Disbursement. The value ​​don't be zero")
                        End If
                    Else
                        MsgBox("You need to add a correct Gross Disbursement. The value ​​don't be zero")
                    End If
                Else
                    MsgBox("You need to add a correct Gas Fee. The value ​​don't be zero")
                End If
            Else
                MsgBox("You need select a correct Currency")
            End If
        Else
            MsgBox("You need select a correct Agent")
        End If
    End Sub




    Private Sub InsertTransactionLine()
        Dim par As New ceTransaction
        Dim dtTransactionLine As New DataTable
        Dim Dr As DataRow

        If Me.dgvTransactionLine.Rows.Count > 0 Then
            dtTransactionLine = dgvTransactionLine.DataSource
        Else
            dtTransactionLine.Columns.Add("Transaction_ID", GetType(String))
            dtTransactionLine.Columns.Add("ProviderID", GetType(String))
            dtTransactionLine.Columns.Add("CurrencyID", GetType(String))
            dtTransactionLine.Columns.Add("TransactionDate", GetType(String))
            dtTransactionLine.Columns.Add("Gross_Disbursement_Amount", GetType(String))
            dtTransactionLine.Columns.Add("Net_Disbursement_Amount", GetType(String))
            dtTransactionLine.Columns.Add("Gass_Fee", GetType(String))
            dtTransactionLine.Columns.Add("Tranches_Executed", GetType(String))
            dtTransactionLine.Columns.Add("Transaction_Status", GetType(String))
            dtTransactionLine.Columns.Add("Income", GetType(String))
            dtTransactionLine.Columns.Add("DailyDisbursment", GetType(String))
        End If

        Dr = dtTransactionLine.NewRow
        Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
        Dr("ProviderID") = LTrim(RTrim(Me.cmbProvider_L.Text.ToString))
        Dr("CurrencyID") = LTrim(RTrim(Me.cmbCurrency_L.Text.ToString))
        Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Value.ToString("yyyy-MM-dd")))
        Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGrossD.Text.ToString))
        Dr("Net_Disbursement_Amount") = LTrim(RTrim(Me.txtNet.Text.ToString))
        If chbGassFee.Checked = True Then
            Dr("Gass_Fee") = "0.000"
        Else
            Dr("Gass_Fee") = LTrim(RTrim(Me.txtGas.Text.ToString))
        End If
        Dr("Tranches_Executed") = LTrim(RTrim(Me.txtTranchesExecute_T.Text.ToString))
        If chbGassFee.Checked = True Then
            Dr("Transaction_Status") = "Pending"
        Else
            Dr("Transaction_Status") = "Paid"
        End If
        Dr("Income") = Nothing
        Dr("DailyDisbursment") = Nothing
        dtTransactionLine.Rows.Add(Dr)

        dgvTransactionLine.DataSource = dtTransactionLine
        Call FormatTransactions()
        'par.dtTransactionsLine = dtTransactionLine
        'Dim BusinessLogic As New BusinessLogic.cnTransaction
        'BusinessLogic.NewTransactionLine(par)
    End Sub


    Private Sub FormatTransactions()
        If dgvTransactionLine.RowCount > 1 Then

            With Me.dgvTransactionLine
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .Rows(0).Selected = False

                .Columns(0).Visible = False
                .Columns(1).Visible = True
                .Columns(1).HeaderText = "Provider"
                .Columns(1).Width = 230
                .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns(2).Visible = True
                .Columns(2).HeaderText = "Currency"
                .Columns(2).Width = 130
                .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(3).Visible = True
                .Columns(3).HeaderText = "Transaction Date"
                .Columns(3).Width = 120
                .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(4).Visible = True
                .Columns(4).HeaderText = "Gross Disbursement Amount"
                .Columns(4).Width = 200
                .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(5).Visible = True
                .Columns(5).HeaderText = "Net Disbursement Amount"
                .Columns(5).Width = 200
                .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(6).Visible = True
                .Columns(6).HeaderText = "Gass Fee"
                .Columns(6).Width = 100
                .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(7).Visible = True
                .Columns(7).HeaderText = "Tranches Executed"
                .Columns(7).Width = 90
                .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(8).Visible = True
                .Columns(8).HeaderText = "Transaction Status"
                .Columns(8).Width = 120
                .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(9).Visible = False
                .Columns(10).Visible = False
            End With
        Else
            dgvTransactionLine.DataSource = Nothing
        End If
    End Sub


    Sub FinishNewTransaction()
        Dim ans As Integer
        ans = MsgBox("Do you want create another transaction?", MsgBoxStyle.YesNo, "")
        If ans = MsgBoxResult.Yes Then
            Call FormatControls()
            Call GetTransaction_ID()
        Else
            Me.Close()
            Main.lblMainHeader.Text = Nothing
        End If
        Call RecalculateHeaders()
    End Sub

    Private Sub RecalculateHeaders()
        Call Main.GetWeeklyTransactonsNumbers()
        Call Main.GetPendingTransactonsNumbers()
    End Sub


    Private Sub InsertCommission()
        Dim par As New ceCommissions
        Dim dtCommissionLine As New DataTable
        Dim Dr As DataRow


        If Me.dgvCommissions.Rows.Count > 0 Then
            dtCommissionLine = dgvCommissions.DataSource
        Else
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
        End If

        Dr = dtCommissionLine.NewRow
        Dr("Transaction_ID") = LTrim(RTrim(Me.txtTransactionID_T.Text.ToString))
        Dr("Agent") = LTrim(RTrim(Me.cmbAgent_C.Text.ToString))
        Dr("Currency") = LTrim(RTrim(Me.cmbCurrency_C.Text.ToString))
        Dr("TransactionDate") = LTrim(RTrim(Me.dtpTransactionDate_T.Text.ToString))
        Dr("Gross_Disbursement_Amount") = LTrim(RTrim(Me.txtGrossD_C.Text.ToString))
        Dr("Net_Disbursement_Amount") = LTrim(RTrim(Me.txtNet_C.Text.ToString))
        If chbGassFee_C.Checked = True Then
            Dr("Gass_Fee") = "0.000"
        Else
            Dr("Gass_Fee") = LTrim(RTrim(Me.txtGas.Text.ToString))
        End If
        Dr("Tranches_Executed") = LTrim(RTrim(Me.txtTranchesExecute_T.Text.ToString))
        If chbGassFee_C.Checked = True Then
            Dr("Commission_Status") = "Pending"
        Else
            Dr("Commission_Status") = "Paid"
        End If
        Dr("Income") = Nothing
        Dr("DailyDisbursment") = Nothing
        dtCommissionLine.Rows.Add(Dr)

        dgvCommissions.DataSource = dtCommissionLine
        Call FormatCommissions()

    End Sub



    Private Sub FormatCommissions()
        With Me.dgvCommissions
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .Rows(0).Selected = False
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Agents"
            .Columns(1).Width = 230
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).Visible = True
            .Columns(2).HeaderText = "Currency"
            .Columns(2).Width = 130
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).Visible = True
            .Columns(3).HeaderText = "Transaction Date"
            .Columns(3).Width = 120
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).Visible = True
            .Columns(4).HeaderText = "Gross Disbursement Amount"
            .Columns(4).Width = 200
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).Visible = True
            .Columns(5).HeaderText = "Net Disbursement Amount"
            .Columns(5).Width = 200
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).Visible = True
            .Columns(6).HeaderText = "Gass Fee"
            .Columns(6).Width = 100
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).Visible = True
            .Columns(7).HeaderText = "Tranches Executed"
            .Columns(7).Width = 90
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).Visible = True
            .Columns(8).HeaderText = "Commission Status"
            .Columns(8).Width = 120
            .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).Visible = False
            .Columns(10).Visible = False
        End With

    End Sub



    Private Sub DisableControlls(ByVal c1 As Control)
        For Each c As Control In c1.Controls

            If TypeOf c Is TextBox Then
                If c.Name = "txtGas1" Then
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
        'Me.gbCommissions.Visible = True
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
                If c.Name = "txtFinalSwapTranchePrice_T" Or c.Name = "txtGrossD" Or c.Name = "txtGas" _
                   Or c.Name = "txtNet" Or c.Name = "txtGrossD_C" Or c.Name = "txtGass_C" Or c.Name = "txtNet_C" Then
                    c.Text = "0.000"
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


End Class