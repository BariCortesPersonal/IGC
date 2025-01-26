




Imports Entity
Imports BusinessLogic
Imports System.Globalization
Imports Presentation.GlobalVariables
Imports System.Security.Cryptography
Imports System.Data.OleDb
Imports System.IO
Imports Windows.Win32.UI.Input


Public Class frmProviders




    Private Sub frmProviders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = vWidth - 20

        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.dtpStart.Format = DateTimePickerFormat.Custom
        Me.dtpStart.CustomFormat = "yyyy-MM-dd"
        Me.dtpEnd.Format = DateTimePickerFormat.Custom
        Me.dtpEnd.CustomFormat = "yyyy-MM-dd"
        Call FormatControls()
        Call GetProvider_ID()
        Call LoadProviders()
    End Sub



    Private Sub FormatControls()
        Me.txtProvider_ID.TextAlign = LeftRightAlignment.Right
        Me.txtFist_Name.TextAlign = HorizontalAlignment.Right
        Me.txtFist_Name.CharacterCasing = CharacterCasing.Upper
        Me.txtLast_Name.TextAlign = HorizontalAlignment.Right
        Me.txtLast_Name.CharacterCasing = CharacterCasing.Upper
        Me.txtEmail.TextAlign = HorizontalAlignment.Right
        Me.txtEmail.CharacterCasing = CharacterCasing.Upper
        Me.txtRate.TextAlign = HorizontalAlignment.Right
        Call Clear(pnProviderDetails)
        Me.txtProvider_ID.Enabled = False
        Me.dgvProvider.DataSource = Nothing
        If vUser_Roll = "Admin" Then
            Me.btnDeleteProvider.Enabled = True
        Else
            Me.btnDeleteProvider.Enabled = False
        End If
        Me.txtFist_Name.Focus()
    End Sub


    Private Sub GetProvider_ID()
        Dim Obj As New ceID
        Dim ds As New DataTable
        Dim BusinessLogic As New BusinessLogic.cnNewID
        ds = BusinessLogic.GetID().Tables("ID")
        Me.txtProvider_ID.Text = ds.Rows(0).Item(0).ToString()
    End Sub

    Private Sub txtFist_Name_TextChanged(sender As Object, e As EventArgs) Handles txtFist_Name.TextChanged
        Call FilterProviders()
    End Sub



    Private Sub LoadProviders()
        Dim ds As New DataTable
        Dim par As New ceProvider
        Me.dgvProvider.DataSource = Nothing
        Dim BusinessLogic As New BusinessLogic.cnProviders
        ds = BusinessLogic.GetlistProviders(par).Tables("Providers")
        Me.dgvProvider.DataSource = ds
        Call FormatProvider()
    End Sub

    Private Sub FilterProviders()
        Dim ds As New DataTable
        Dim par As New ceProvider
        Me.dgvProvider.DataSource = Nothing
        par.First_Name = LTrim(RTrim(Me.txtFist_Name.Text))
        par.Last_Name = LTrim(RTrim(Me.txtLast_Name.Text))
        par.Phone = IIf(IsNumeric(LTrim(RTrim(Replace(Me.mtxtPhone.Text, "-", "")))), LTrim(RTrim(Replace(Me.mtxtPhone.Text, "-", ""))), "")
        par.Phone2 = IIf(IsNumeric(LTrim(RTrim(Replace(Me.mtxtPhone2.Text, "-", "")))), LTrim(RTrim(Replace(Me.mtxtPhone2.Text, "-", ""))), "")
        par.Email = LTrim(RTrim(Me.txtEmail.Text))
        Dim BusinessLogic As New BusinessLogic.cnProviders
        ds = BusinessLogic.GetFilterProviders(par).Tables("Providers")
        Me.dgvProvider.DataSource = ds
        Call FormatProvider()
    End Sub


    Private Sub FormatProvider()
        If Me.dgvProvider.RowCount > 0 Then

            With Me.dgvProvider
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .Rows(0).Selected = False

                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False

                .Columns(3).Visible = True
                .Columns(3).HeaderText = "Provider Name"
                .Columns(3).Width = 200
                .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(4).Visible = True
                .Columns(4).HeaderText = "Phone"
                .Columns(4).Width = 180
                .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(5).Visible = True
                .Columns(5).HeaderText = "Secondary Phone"
                .Columns(5).Width = 180
                .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(6).Visible = True
                .Columns(6).HeaderText = "Email"
                .Columns(6).Width = 200
                .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(7).Visible = True
                .Columns(7).HeaderText = "Rate"
                .Columns(7).Width = 100
                .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
        Else
            Me.dgvProvider.DataSource = Nothing
        End If
    End Sub


    Private Sub dgvProvider_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProvider.CellClick
        If dgvProvider.SelectedCells.Count <> 0 Then
            Me.txtProvider_ID.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(0).ToString
            Me.txtFist_Name.Text = IIf(Len(dgvProvider.Rows(e.RowIndex).DataBoundItem(1).ToString) > 0, dgvProvider.Rows(e.RowIndex).DataBoundItem(1).ToString, dgvProvider.Rows(e.RowIndex).DataBoundItem(3).ToString)
            Me.txtLast_Name.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(2).ToString
            Me.mtxtPhone.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(4).ToString
            Me.mtxtPhone2.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(5).ToString
            Me.txtEmail.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(6).ToString
            Me.txtRate.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(6).ToString
        End If

    End Sub

    Private Sub btnAddProvider_Click(sender As Object, e As EventArgs) Handles btnAddProvider.Click
        If Len(Me.txtProvider_ID.Text) > 0 Then
            If Len(Me.txtFist_Name.Text) > 0 Then
                Call Create_Update_Provider()
            Else
                MsgBox("The First Name field cannot be empty.")
            End If
        End If
        'Me.txtFist_Name.Text = IIf(Len(dgvProvider.Rows(e.RowIndex).DataBoundItem(1).ToString) > 0, dgvProvider.Rows(e.RowIndex).DataBoundItem(1).ToString, dgvProvider.Rows(e.RowIndex).DataBoundItem(3).ToString)
        'Me.txtLast_Name.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(2).ToString
        'Me.mtxtPhone.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(4).ToString
        'Me.mtxtPhone2.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(5).ToString
        'Me.txtEmail.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(6).ToString
        'Me.txtRate.Text = dgvProvider.Rows(e.RowIndex).DataBoundItem(6).ToString
    End Sub


    Private Sub Create_Update_Provider()
        Dim par As New ceProvider
        Dim parUser As New ceUser
        par.Provider_ID = Me.txtProvider_ID.Text
        par.First_Name = Me.txtFist_Name.Text
        par.Last_Name = Me.txtLast_Name.Text
        par.Phone = Me.mtxtPhone.Text
        par.Phone2 = Me.mtxtPhone2.Text
        par.Email = Me.txtEmail.Text
        par.Rate = Me.txtRate.Text
        parUser.UserID = vUser_ID
        Dim BusinessLogic As New BusinessLogic.cnProviders
        BusinessLogic.GetAddProviders(par, parUser)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Clear(pnProviderDetails)
        Me.dgvProvider.DataSource = Nothing
        Call LoadProviders()
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



    Private Sub DisableControlls(ByVal c1 As Control)

        For Each c As Control In c1.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = False
            Else
                Clear(c)
            End If

            If TypeOf c Is ComboBox Then
                c.Enabled = False
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

    End Sub



    Sub Clear(ByVal c1 As Control)

        For Each c As Control In c1.Controls
            If TypeOf c Is TextBox Then
                c.Text = Nothing
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
                c.Text = Nothing
            End If
        Next

    End Sub


End Class