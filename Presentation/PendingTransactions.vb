



Imports BusinessLogic
Imports Entity
Imports System.Globalization
Imports Presentation.GlobalVariables
Public Class frmPendingTransactions
    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = vWidth - 20
        Call FormatControls()
        Me.dtpTransactionDate.Format = DateTimePickerFormat.Custom
        Me.dtpTransactionDate.CustomFormat = "yyyy-MM-dd"
        '' Call LoadPendingTransctions()
    End Sub


    Private Sub FormatControls()

        Me.dtpTransactionDate.DropDownAlign = LeftRightAlignment.Right
        Me.txtNet.TextAlign = HorizontalAlignment.Right
        Me.txtGross.TextAlign = HorizontalAlignment.Right
        Me.txtGas.TextAlign = HorizontalAlignment.Right
        Me.txtTotalTranches.TextAlign = HorizontalAlignment.Right
        Me.cmbProvider.Focus()
        Call Clear(gpTransaction)
        Call DisableControlls(gpTransaction)
        Call GetTransaction_ID()
        Me.txtGas.Text = 0

    End Sub

    Private Sub cmbProvider_Click(sender As Object, e As EventArgs) Handles cmbProvider.Click
        cmbCurrency.DataSource = Nothing
        cmbCurrency.DataBindings.Clear()
        cmbCurrency.Items.Clear()
    End Sub

    Private Sub txtGas_TextChanged(sender As Object, e As EventArgs) Handles txtGas.TextChanged
        If Len(Me.txtGas.Text) > 0 And Len(Me.txtGross.Text) > 0 _
              And Len(Me.cmbCurrency.Text.ToString) > 0 Then
            Call CalculatePendingTransactions()
        End If
    End Sub

    Private Sub txtGas_Click(sender As Object, e As EventArgs) Handles txtGas.Click
        If Me.txtGas.Enabled = True Then
            txtGas.Text = ""
        End If
    End Sub

    Private Sub txtGas_MouseLeave(sender As Object, e As EventArgs) Handles txtGas.MouseLeave
        If Me.txtGas.Text = "" Then
            Me.txtGas.Text = 0
        End If
    End Sub


    Private Sub cmbProvider_T_DropDown(sender As Object, e As EventArgs) Handles cmbProvider.DropDown
        cmbProvider.DataSource = Nothing
        cmbProvider.Items.Clear()
        cmbCurrency.DataSource = Nothing
        cmbCurrency.DataBindings.Clear()
        cmbCurrency.Items.Clear()

        Dim BusinessLogic As New cnProviders
        cmbProvider.DataSource = BusinessLogic.GetlistProvidersPendingTransactions.Tables("Provider")
        cmbProvider.ValueMember = "Provider_ID"
        cmbProvider.DisplayMember = "Full_Name"

    End Sub

    Private Sub cmbProvider_T_TextChanged(sender As Object, e As EventArgs) Handles cmbProvider.SelectionChangeCommitted
        cmbCurrency.Enabled = True
        cmbCurrency.Focus()
    End Sub

    Private Sub cmbCurrency_T_DropDown(sender As Object, e As EventArgs) Handles cmbCurrency.DropDown
        cmbCurrency.DataSource = Nothing
        cmbCurrency.DataBindings.Clear()
        cmbCurrency.Items.Clear()
        Dim par As New ceProvider
        par.Provider = LTrim(RTrim(Me.cmbProvider.SelectedValue))
        Dim BusinessLogic As New BusinessLogic.cnCurrency
        cmbCurrency.DataSource = BusinessLogic.GetFilterCurrencyPendingTransaction(par).Tables("Currency")
        cmbCurrency.ValueMember = "Currency_ID"
        cmbCurrency.DisplayMember = "Currency_Name"
    End Sub


    Private Sub lblTransactionDate_Click(sender As Object, e As EventArgs) Handles lblTransactionDate.DoubleClick
        Me.dtpTransactionDate.Enabled = True
    End Sub

    Private Sub cmbCurrency_T_TextChanged(sender As Object, e As EventArgs) Handles cmbCurrency.SelectionChangeCommitted
        Call LoadPendingTransctions()
        ' Me.gbTransaction.Focus()
    End Sub

    Private Sub txtGas_L1_TextChanged(sender As Object, e As EventArgs) Handles txtGas.TextChanged
        If Len(Me.txtGas.Text) > 0 And Len(Me.txtGross.Text) > 0 _
              And Len(Me.cmbCurrency.Text.ToString) > 0 Then
            Call CalculatePendingTransactions()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Call CalculatePendingTransactions()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.txtGas.Text > 0 Then
            Call ClosePendingTransactions()
            'Call FormatControls()
            Call FinishCloseTransaction()
        End If
    End Sub

    Sub FinishCloseTransaction()
        Dim ans As Integer
        ans = MsgBox("Do you want close another transaction?", MsgBoxStyle.YesNo, "")
        If ans = MsgBoxResult.Yes Then
            Call FormatControls()
        Else
            Me.Close()
            Main.lblMainHeader.Text = Nothing
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call FormatControls()
        Call GetTransaction_ID()
        Me.cmbProvider.Focus()
    End Sub


    Private Sub ClosePendingTransactions()

        Dim par As New ceTransaction
        par.TransactionID = LTrim(RTrim(Me.txtTransactionID.Text))
        par.ProviderID = LTrim(RTrim(Me.cmbProvider.SelectedValue.ToString))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency.SelectedValue))
        par.TransactionDate = LTrim(RTrim(Me.dtpTransactionDate.Value.ToString("yyyy-MM-dd")))
        par.Gross_Disbursement_Amou = (RTrim(Me.txtGross.Text))
        par.GasFee = LTrim(RTrim(Me.txtGas.Text))
        par.Net_Disbursement_Amount = LTrim(RTrim(Me.txtNet.Text))
        par.User = LTrim(RTrim(Environment.UserName))

        Dim dtTransactions As New DataTable
        dtTransactions.Columns.Add("TransactionID", GetType(String))
        dtTransactions.Columns.Add("TransactionLineID", GetType(String))
        Dim Dr As DataRow

        For i = 0 To ((Me.gvPendingTransactions.Rows.Count) - 1)
            Dr = dtTransactions.NewRow
            Dr("TransactionID") = gvPendingTransactions.Item(1, i).Value.ToString
            Dr("TransactionLineID") = gvPendingTransactions.Item(0, i).Value.ToString
            dtTransactions.Rows.Add(Dr)
        Next
        par.dtTransactionsLine = dtTransactions

        Dim BusinessLogic As New BusinessLogic.cnTransaction
        BusinessLogic.GetClosePendingsTransactions(par)

    End Sub


    Private Sub GetTransaction_ID()
        Dim Obj As New ceID
        Dim ds As New DataTable
        Dim BusinessLogic As New BusinessLogic.cnNewID
        ds = BusinessLogic.GetID().Tables("ID")
        Me.txtTransactionID.Text = ds.Rows(0).Item(0).ToString()
    End Sub



    Private Sub LoadPendingTransctions()

        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
        Dim par As New ceTransaction
        Dim BusinessLogic As New cnTransaction

        par.ProviderID = LTrim(RTrim(Me.cmbProvider.SelectedValue))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency.SelectedValue))
        par.TransactionDate = LTrim(RTrim(Me.dtpTransactionDate.Value.ToString("yyyy-MM-dd")))
        Me.gvPendingTransactions.DataSource = BusinessLogic.GetListPendingsTransactions(par).Tables("PendingTransactions")
        If gvPendingTransactions.RowCount > 1 Then
            Call FormatPendingTransactions()
            Call CalculatePendingTransactions()
        Else
            gvPendingTransactions.DataSource = Nothing
        End If
    End Sub


    Private Sub CalculatePendingTransactions()
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
        Dim totalA As Double = 0
        Dim totalB As Double = 0
        Dim abc As Integer = gvPendingTransactions.RowCount - 1
        Dim abcd As String = gvPendingTransactions.Rows(abc).Cells(5).Value
        For Each fila As DataGridViewRow In Me.gvPendingTransactions.Rows
            If fila.Cells("Gross_Disbursement_Amount").Value Is Nothing Then
                Me.txtGross.Text = 0
                Me.txtNet.Text = 0
                Exit Sub
            ElseIf fila.Cells("Transaction_Status").Value = "Pending" Then
                totalA += Convert.ToDecimal(fila.Cells("Gross_Disbursement_Amount").Value)
                totalB += Convert.ToDecimal(fila.Cells("Nets_Disbursements_Amount").Value)
            End If
        Next
        Me.txtGross.Text = Math.Round(totalA, 3)
        Me.txtNet.Text = Math.Round(totalA - Me.txtGas.Text, 3)
        Me.txtTotalTranches.Text = abcd

    End Sub



    Private Sub FormatPendingTransactions()
        If gvPendingTransactions.RowCount > 1 Then

            With Me.gvPendingTransactions
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .Rows(0).Selected = False

                .Columns(0).Visible = False
                .Columns(1).Visible = False

                .Columns(2).Visible = True
                .Columns(2).HeaderText = "Provider"
                .Columns(2).Width = 278
                .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns(3).Visible = True
                .Columns(3).HeaderText = "Currency"
                .Columns(3).Width = 150
                .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(4).Visible = True
                .Columns(4).HeaderText = "Transaction Date"
                .Columns(4).Width = 160
                .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(5).Visible = True
                .Columns(5).HeaderText = "Tranche"
                .Columns(5).Width = 90
                .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(6).Visible = True
                .Columns(6).HeaderText = "Gross Disbursement Amount"
                .Columns(6).Width = 220
                .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(7).Visible = True
                .Columns(7).HeaderText = "Net Disbursements Amount"
                .Columns(7).Width = 220
                .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(8).Visible = True
                .Columns(8).HeaderText = "Status"
                .Columns(8).Width = 100
                .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
        Else
            gvPendingTransactions.DataSource = Nothing
        End If
    End Sub



    Private Sub DisableControlls(ByVal c1 As Control)
        For Each c As Control In c1.Controls

            If TypeOf c Is TextBox Then
                If c.Name = "txtGas" Then
                    c.Enabled = True
                    c.BackColor = Color.LightSteelBlue
                Else
                    c.Enabled = False
                    c.BackColor = Color.WhiteSmoke
                End If

                Clear(c)
            End If

            If TypeOf c Is ComboBox Then
                If c.Name = "cmbProvider" Then
                    c.Enabled = True
                Else
                    c.Enabled = False
                End If
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

    End Sub
    Sub Clear(ByVal c1 As Control)

        For Each c As Control In c1.Controls
            If TypeOf c Is TextBox Then
                If c.Name = "txtGas" Then
                    c.Text = 0
                Else
                    c.Text = ""
                End If
            Else
                Clear(c)
            End If

            If TypeOf c Is ComboBox Then
                c.Text = ""
            Else
                Clear(c)
            End If
            If TypeOf c Is DateTimePicker Then
                c.Text = Date.Today
            Else
                Clear(c)
            End If
            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Checked = False
            Else
                Clear(c)
            End If
            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Checked = False
            Else
                Clear(c)
            End If
            If TypeOf c Is MaskedTextBox Then
                c.Text = ""
            Else
                Clear(c)
            End If
        Next
        cmbProvider.DataSource = Nothing
        cmbProvider.Items.Clear()
        cmbCurrency.DataSource = Nothing
        cmbCurrency.DataBindings.Clear()
        cmbCurrency.Items.Clear()
        gvPendingTransactions.DataSource = Nothing

    End Sub


End Class