Imports Entity
Imports BusinessLogic
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.IO

Public Class frmTransactionsManagements


    Private Sub frmTransactionsManagements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormatControls()
    End Sub


    Private Sub FormatControls()

        Me.dtpTransactionDate.DropDownAlign = LeftRightAlignment.Right
        Call Clear(gbTransactionManagements)
        Call DisableControlls(gbTransactionManagements)
        Me.cmbProvider.Focus()

    End Sub

    Private Sub cmbProvider_Click(sender As Object, e As EventArgs) Handles cmbProvider.Click
        cmbCurrency.DataSource = Nothing
        cmbCurrency.DataBindings.Clear()
        cmbCurrency.Items.Clear()
    End Sub

    Private Sub cmbProvider_T_DropDown(sender As Object, e As EventArgs) Handles cmbProvider.DropDown
        cmbProvider.DataSource = Nothing
        cmbProvider.Items.Clear()
        cmbCurrency.DataSource = Nothing
        cmbCurrency.DataBindings.Clear()
        cmbCurrency.Items.Clear()

        Dim BusinessLogic As New cnProviders
        cmbProvider.DataSource = BusinessLogic.GetProvider.Tables("Provider")
        cmbProvider.ValueMember = "Provider_ID"
        cmbProvider.DisplayMember = "Full_Name"

    End Sub

    Private Sub cmbProvider_TextChanged(sender As Object, e As EventArgs) Handles cmbProvider.SelectionChangeCommitted
        cmbCurrency.Enabled = True
        cmbCurrency.Focus()
        Call GetFilterTransactions()
    End Sub

    Private Sub cmbCurrency_DropDown(sender As Object, e As EventArgs) Handles cmbCurrency.DropDown
        Me.cmbCurrency.DataSource = Nothing
        Me.cmbCurrency.DataBindings.Clear()
        Me.cmbCurrency.Items.Clear()
        Dim BusinessLogic As New BusinessLogic.cnCurrency
        Me.cmbCurrency.DataSource = BusinessLogic.GetCurrency().Tables("Currency")
        Me.cmbCurrency.ValueMember = "Currency_ID"
        Me.cmbCurrency.DisplayMember = "Currency_Name"
    End Sub

    Private Sub cmbCurrency_TextChanged(sender As Object, e As EventArgs) Handles cmbCurrency.SelectionChangeCommitted
        cmbCurrency.Enabled = True
        cmbCurrency.Focus()
        Call GetFilterTransactions()
    End Sub


    Private Sub dtpTransactionDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpTransactionDate.ValueChanged
        Call GetFilterTransactions()
    End Sub


    Private Sub dgvTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellContentClick

    End Sub


    Private Sub GetFilterTransactions()

        Dim par As New ceTransaction
        par.ProviderID = LTrim(RTrim(Me.cmbProvider.SelectedValue))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency.SelectedValue))
        If ckbAllDates.Checked = True Then
            par.TransactionDate = Nothing
        Else
            par.TransactionDate = LTrim(RTrim(Me.dtpTransactionDate.Value.ToString("yyyy-MM-dd")))
        End If

        Dim ds As New DataTable
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        Me.dgvTransactions.DataSource = BusinessLogic.GetFilterTransactions(par).Tables("Transaction")

        If dgvTransactions.RowCount > 0 Then
            Call FormatTransactions()
        Else
            dgvTransactions.DataSource = Nothing
        End If

    End Sub


    Private Sub FormatTransactions()
        If dgvTransactions.RowCount > 1 Then

            With Me.dgvTransactions
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .Rows(0).Selected = False

                .Columns(0).Visible = False
                .Columns(1).Visible = True
                .Columns(1).HeaderText = "Transaction Date"
                .Columns(1).Width = 130
                .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(2).Visible = True
                .Columns(2).HeaderText = "Transaction Type"
                .Columns(2).Width = 140
                .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(3).Visible = True
                .Columns(3).HeaderText = "Provider"
                .Columns(3).Width = 330
                .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(4).Visible = True
                .Columns(4).HeaderText = "Currency"
                .Columns(4).Width = 100
                .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(5).Visible = True
                .Columns(5).HeaderText = "Final Swap Tranche Price"
                .Columns(5).Width = 200
                .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(6).Visible = True
                .Columns(6).HeaderText = "Gass Fee"
                .Columns(6).Width = 90
                .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(7).Visible = True
                .Columns(7).HeaderText = "Number of BTC"
                .Columns(7).Width = 120
                .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(8).Visible = True
                .Columns(8).HeaderText = "Tranches Executed"
                .Columns(8).Width = 80
                .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With
        Else
            dgvTransactions.DataSource = Nothing
        End If
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
                If c.Name = "txtGrossD_L31" Then
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

    Private Sub DisableControlls(ByVal c1 As Control)
        For Each c As Control In c1.Controls

            If TypeOf c Is TextBox Then
                If c.Name = "txtGas_L1" Then
                    c.Enabled = True
                    c.BackColor = Color.LightSteelBlue
                Else
                    c.Enabled = False
                    c.BackColor = Color.WhiteSmoke
                End If
                Clear(c)
            End If

            If TypeOf c Is ComboBox Then
                If c.Name = "cmbProvider" Or c.Name = "cmbCurrency" Then
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

                If c.Name = "dtpTransactionDate" Then
                    c.Enabled = True
                Else
                    c.Enabled = False
                End If
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

    Private Sub ckbAllDates_CheckedChanged(sender As Object, e As EventArgs) Handles ckbAllDates.CheckedChanged
        If ckbAllDates.Checked = True Then
            dtpTransactionDate.Enabled = False
        Else
            dtpTransactionDate.Enabled = True
        End If
    End Sub


End Class