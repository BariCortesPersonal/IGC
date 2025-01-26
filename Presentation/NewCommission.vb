



Imports Entity
Imports BusinessLogic
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports Presentation.GlobalVariables
Public Class NewCommission

    Private Sub gbTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = vWidth - 20
        Call FormatControls()
        Me.dtpCommissionDate.Format = DateTimePickerFormat.Custom
        Me.dtpCommissionDate.CustomFormat = "yyyy-MM-dd"

        Dim ms As New ceMessage
    End Sub

    Private Sub FormatControls()
        Call Clear(gbComissions)
        Call DisableControlls(gbComissions)
        Call GetCommission_ID()
    End Sub


    Private Sub Handles_DropDown(sender As Object, e As EventArgs) Handles cmbAgent.DropDown
        cmbAgent.DataSource = Nothing
        cmbAgent.DataBindings.Clear()
        cmbAgent.Items.Clear()
        cmbCurrency.DataSource = Nothing
        cmbCurrency.DataBindings.Clear()
        cmbCurrency.Items.Clear()
        Dim BusinessLogic As New BusinessLogic.cnAgent
        cmbAgent.DataSource = BusinessLogic.GetAgent.Tables("Agent")
        cmbAgent.ValueMember = "Agent_ID"
        cmbAgent.DisplayMember = "Full_Name"
    End Sub

    Private Sub cmbProvider_T_TextChanged(sender As Object, e As EventArgs) Handles cmbAgent.SelectionChangeCommitted
        cmbCurrency.Enabled = True
        cmbCurrency.Focus()
    End Sub

    Private Sub cmbAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgent.Click
        Call FormatControls()
    End Sub

    Private Sub cmbCurrency_T_DropDown(sender As Object, e As EventArgs) Handles cmbCurrency.DropDown
        cmbCurrency.DataSource = Nothing
        cmbCurrency.DataBindings.Clear()
        cmbCurrency.Items.Clear()
        Dim par As New ceAgent
        par.Agent = LTrim(RTrim(Me.cmbAgent.SelectedValue))
        Dim BusinessLogic As New BusinessLogic.cnCurrency
        cmbCurrency.DataSource = BusinessLogic.GetFilterCurrency(par).Tables("Currency")
        cmbCurrency.ValueMember = "Currency_ID"
        cmbCurrency.DisplayMember = "Currency_Name"
    End Sub

    Private Sub cmbCurrency_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCurrency.SelectionChangeCommitted
        Me.txtCommissionGas.Text = 0
        Call ListCommissions()
        If dgvCommissions.RowCount > 1 Then
            Call FormatCommissions()
            Call CalculateCommission()
        Else
            dgvCommissions.DataSource = Nothing
        End If
    End Sub



    Private Sub ListCommissions()
        Dim ds As New DataTable
        Dim par As New ceCommissions
        par.AgentID = LTrim(RTrim(Me.cmbAgent.SelectedValue))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency.SelectedValue))
        par.TransactionDate = LTrim(RTrim(Me.dtpCommissionDate.Value.ToString("yyyy-MM-dd")))
        Dim BusinessLogic As New BusinessLogic.cnCommissions
        ds = BusinessLogic.GetCommissions(par).Tables("Commissions")
        Me.dgvCommissions.DataSource = ds
    End Sub

    Private Sub FormatCommissions()
        With Me.dgvCommissions
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .Rows(0).Selected = False
            .Columns(0).Visible = True
            .Columns(0).HeaderText = "Agents"
            .Columns(0).Width = 220
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).Visible = True
            .Columns(1).HeaderText = "Currency"
            .Columns(1).Width = 100
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).Visible = True
            .Columns(2).HeaderText = "Commission_Gross_Disbursement"
            .Columns(2).Width = 203
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).Visible = True
            .Columns(3).HeaderText = "Status"
            .Columns(3).Width = 100
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).Visible = True
            .Columns(4).HeaderText = "Transaction Date"
            .Columns(4).Width = 130
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).Visible = True
            .Columns(5).HeaderText = "Tranche"
            .Columns(5).Width = 90
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).Visible = True
            .Columns(6).HeaderText = "Final Swap Tranche Price"
            .Columns(6).Width = 200
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).Visible = True
            .Columns(7).HeaderText = "Total BTC"
            .Columns(7).Width = 140
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).Visible = True
        End With

    End Sub


    Private Sub txtCommissionGas_TextChanged(sender As Object, e As EventArgs) Handles txtCommissionGas.TextChanged
        If Len(Me.txtCommissionGas.Text) > 0 And Len(Me.txtCommissionGross.Text) > 0 Then
            Call CalculateCommission()
        End If
    End Sub
    Private Sub ttxtCommissionGas_TextChanged(sender As Object, e As EventArgs) Handles txtCommissionGas.Click
        If Me.txtCommissionGas.Enabled = True Then
            txtCommissionGas.Text = ""
        End If
    End Sub

    Private Sub txtCommissionGas_MouseLeave(sender As Object, e As EventArgs) Handles txtCommissionGas.MouseLeave
        If Me.txtCommissionGas.Text = "" Then
            txtCommissionGas.Text = 0
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Call CalculateCommission()
    End Sub

    Private Sub cmbAgent_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbAgent.SelectedIndexChanged
        '  Call FormatControlls()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.txtCommissionGas.Text > 0 Then
            Call ClosePendingCommissions()
            'Call FormatControls()
            Call FinishCloseCommissions()
        End If
    End Sub

    Sub FinishCloseCommissions()
        Dim ans As Integer
        ans = MsgBox("Do you want close another commissionn?", MsgBoxStyle.YesNo, "")
        If ans = MsgBoxResult.Yes Then
            Call FormatControls()
        Else
            Me.Close()
            Main.lblMainHeader.Text = Nothing
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call FormatControls()
        Call GetCommission_ID()
        Me.cmbAgent.Focus()
    End Sub

    Private Sub lblTransactionDate_Click(sender As Object, e As EventArgs) Handles lblTransactionDate.Click
        Me.dtpCommissionDate.Enabled = True
    End Sub



    '''Private Sub NewCommission()

    '''    Dim par As New ceCommissions
    '''    par.CommissionID = LTrim(RTrim(Me.txtCommissionID.Text))
    '''    par.AgentID = LTrim(RTrim(Me.cmbAgent.SelectedValue.ToString))
    '''    par.CurrencyID = LTrim(RTrim(Me.cmbCurrency.SelectedValue))
    '''    par.TransactionDate = LTrim(RTrim(Me.dtpCommissionDate.Text))
    '''    par.Gross_Disbursement_Amout = (RTrim(Me.txtCommissionGross.Text))
    '''    par.GasFee = LTrim(RTrim(Me.txtCommissionGas.Text))
    '''    par.Net_Disbursement_Amount = LTrim(RTrim(Me.txtCommissionNet.Text))
    '''    Dim BusinessLogic As New BusinessLogic.cnCommissions
    '''    '  BusinessLogic.NewTransaction(par)

    '''End Sub

    Private Sub ClosePendingCommissions()

        Dim par As New ceCommissions
        par.CommissionID = LTrim(RTrim(Me.txtCommissionID.Text))
        par.AgentID = LTrim(RTrim(Me.cmbAgent.SelectedValue.ToString))
        par.CurrencyID = LTrim(RTrim(Me.cmbCurrency.SelectedValue))
        par.TransactionDate = LTrim(RTrim(Me.dtpCommissionDate.Value.ToString("yyyy-MM-dd")))
        par.Gross_Disbursement_Amout = (RTrim(Me.txtCommissionGross.Text))
        par.GasFee = LTrim(RTrim(Me.txtCommissionGas.Text))
        par.Net_Disbursement_Amount = LTrim(RTrim(Me.txtCommissionNet.Text))
        par.User = LTrim(RTrim(Environment.UserName))
        Dim dtCommissions As New DataTable
        dtCommissions.Columns.Add("CommissionID", GetType(String))
        dtCommissions.Columns.Add("CommissionLineID", GetType(String))
        Dim Dr As DataRow

        For i = 0 To ((Me.dgvCommissions.Rows.Count) - 1)
            Dr = dtCommissions.NewRow
            Dr("CommissionID") = LTrim(RTrim(Me.txtCommissionID.Text.ToString))
            Dr("CommissionLineID") = dgvCommissions.Item(8, i).Value.ToString
            dtCommissions.Rows.Add(Dr)
        Next
        par.dtCommissionLine = dtCommissions

        Dim BusinessLogic As New BusinessLogic.cnCommissions
        BusinessLogic.GetClosePendingCommissions(par)

    End Sub

    Private Sub GetCommission_ID()
        Dim Obj As New ceID
        Dim ds As New DataTable
        Dim BusinessLogic As New BusinessLogic.cnNewID
        ds = BusinessLogic.GetID().Tables("ID")
        Me.txtCommissionID.Text = ds.Rows(0).Item(0).ToString()
    End Sub


    Private Sub CalculateCommission()
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US")
        Dim totalA As Double = 0
        Dim totalB As Double = 0
        For Each fila As DataGridViewRow In Me.dgvCommissions.Rows
            If fila.Cells("Commission_Gross_Disbursement").Value Is Nothing Then
                Me.txtCommissionGross.Text = 0
                Exit Sub
            ElseIf fila.Cells("Status").Value = "Pending" Then
                totalA += Convert.ToDecimal(fila.Cells("Commission_Gross_Disbursement").Value)
            End If
        Next
        Me.txtCommissionGross.Text = Math.Round(totalA, 3)
        Me.txtCommissionNet.Text = Math.Round(Me.txtCommissionGross.Text - Me.txtCommissionGas.Text, 3)

    End Sub




    Private Sub DisableControlls(ByVal c1 As Control)
        For Each c As Control In c1.Controls

            If TypeOf c Is TextBox Then
                If c.Name = "txtCommissionGas" Then
                    c.Enabled = True
                    c.BackColor = Color.LightSteelBlue
                Else
                    c.Enabled = False
                    c.BackColor = Color.WhiteSmoke
                End If

                Clear(c)
            End If

            If TypeOf c Is ComboBox Then
                If c.Name = "cmbAgent" Then
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
                If c.Name = "txtCommissionGas" Then
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
        Me.dgvCommissions.DataSource = Nothing
        Me.dgvCommissions.Refresh()
        Me.cmbCurrency.DataSource = Nothing
        Me.cmbCurrency.DataBindings.Clear()
        Me.cmbCurrency.Items.Clear()
        Me.dgvCommissions.DataSource = Nothing
    End Sub


End Class