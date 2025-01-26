
Imports Entity
Imports BusinessLogic
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.IO


Public Class frmCurrency
    Private Sub Currency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FormatControls()
        Call GetCurrencyByName()
    End Sub

    Private Sub FormatControls()
        Me.txtCurrencyName.Text = Nothing
        Me.txtCurrencyName.TextAlign = HorizontalAlignment.Right
        Me.txtCurrencyDefaultValue.Text = 0
        Me.txtCurrencyName.CharacterCasing = CharacterCasing.Upper
        Me.txtCurrencyDefaultValue.TextAlign = HorizontalAlignment.Right
        Me.txtCurrencyName.Focus()
    End Sub

    Private Sub GetCurrencyByName()
        Dim par As New ceCurrency
        par.CurrencyName = LTrim(RTrim(Me.txtCurrencyName.Text))
        Dim ds As New DataTable
        Dim BusinessLogic As New BusinessLogic.cnCurrency
        Me.dgvCurrency.DataSource = BusinessLogic.GetFilterCurrencyByName(par).Tables("Currency")
        If dgvCurrency.RowCount > 0 Then
            Call FormatCurrency()
        Else
            dgvCurrency.DataSource = Nothing
        End If

    End Sub


    Private Sub FormatCurrency()
        With Me.dgvCurrency
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .Rows(0).Selected = False
            .Columns(0).Visible = True
            .Columns(0).HeaderText = "Currency"
            .Columns(0).Width = 250
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvCurrency.RowCount > 0 Then
            For i = 0 To ((Me.dgvCurrency.Rows.Count) - 1)
                MsgBox(dgvCurrency.Item(0, i).Value.ToString)
                MsgBox(Me.txtCurrencyName.Text)
                If dgvCurrency.Item(0, i).Value.ToString = Me.txtCurrencyName.Text Then
                    MessageBox.Show("The Currency you are trying to create already exists")
                    Exit Sub
                Else
                    Call CreateNewCurrency()
                End If
            Next
        Else
            Call CreateNewCurrency()
        End If

    End Sub


    Private Sub CreateNewCurrency()
        Dim par As New ceCurrency
        par.CurrencyName = LTrim(RTrim(Me.txtCurrencyName.Text))
        Dim BusinessLogic As New BusinessLogic.cnCurrency
        BusinessLogic.GetCreateNewCurrency(par)
        '  Me.txtCurrencyName.Text = Nothing
        Call FinishNewCurrency()
    End Sub


    Private Sub txtCurrencyName_TextChanged(sender As Object, e As EventArgs) Handles txtCurrencyName.TextChanged
        Call GetCurrencyByName()
    End Sub


    Sub FinishNewCurrency()
        Dim ans As Integer
        ans = MsgBox("Do you want create another currency?", MsgBoxStyle.YesNo, "")

        If ans = MsgBoxResult.Yes Then
            FormatControls()
        Else
            Me.Close()
        End If
    End Sub

End Class