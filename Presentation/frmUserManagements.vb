



Imports BusinessLogic
Imports Entity
Imports System.Globalization
Imports Presentation.GlobalVariables
Public Class frmUserManagements
    Private Sub frmUserManagements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = vWidth - 20
        Call FormatContlos()
        Call LoadUsers()
    End Sub



    Private Sub FormatContlos()
        Me.dtpStartDate.Format = DateTimePickerFormat.Custom
        Me.dtpStartDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpEndDate.Format = DateTimePickerFormat.Custom
        Me.dtpEndDate.CustomFormat = "yyyy-MM-dd"
    End Sub


    Private Sub LoadUsers()

        Dim BusinessLogic As New cnUser
        Me.dgvUsers.DataSource = BusinessLogic.GelistUsersd().Tables("User")
        If dgvUsers.RowCount > 1 Then
            Call FormatUsers()
        Else
            dgvUsers.DataSource = Nothing
        End If

    End Sub


    Private Sub FormatUsers()
        If dgvUsers.RowCount > 1 Then

            With Me.dgvUsers
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .Rows(0).Selected = False

                .Columns(0).Visible = False
                .Columns(1).Visible = True
                .Columns(1).HeaderText = "First Name"
                .Columns(1).Width = 160
                .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .Columns(2).Visible = True
                .Columns(2).HeaderText = "Last Name"
                .Columns(2).Width = 160
                .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(3).Visible = False

                .Columns(4).Visible = True
                .Columns(4).HeaderText = "Phone Number"
                .Columns(4).Width = 130
                .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(5).Visible = True
                .Columns(5).HeaderText = "Secondary Phone"
                .Columns(5).Width = 130
                .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(6).Visible = True
                .Columns(6).HeaderText = "Email"
                .Columns(6).Width = 250
                .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(7).Visible = True
                .Columns(7).HeaderText = "Roll"
                .Columns(7).Width = 90
                .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(8).Visible = True
                .Columns(8).HeaderText = "User ID"
                .Columns(8).Width = 100
                .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(9).Visible = False
                .Columns(10).Visible = True
                .Columns(10).HeaderText = "Start Date"
                .Columns(10).Width = 100
                .Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns(11).Visible = True
                .Columns(11).HeaderText = "End Date"
                .Columns(11).Width = 100
                .Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(12).Visible = False
            End With
        Else
            dgvUsers.DataSource = Nothing
        End If

    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvUsers.CellFormatting
        If e.RowIndex < Me.dgvUsers.RowCount - 1 Then
            Dim dgvRow As DataGridViewRow = Me.dgvUsers.Rows(e.RowIndex)
            ' If CInt(dgvRow.Cells("Active").Value) = True Then

            dgvRow.DefaultCellStyle.ForeColor = Color.Red


        End If

        ' End If
    End Sub

    Private Sub bdUserManagements_Enter(sender As Object, e As EventArgs) Handles bdUserManagements.Enter

    End Sub
End Class