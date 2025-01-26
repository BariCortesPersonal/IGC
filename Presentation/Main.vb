

Imports Entity
Imports BusinessLogic
Imports Presentation.GlobalVariables

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblVersion.Text = "Version 1.0 @IGC Managments System  "

        Me.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize
        Me.WindowState = FormWindowState.Maximized
        Me.Panel_Main.AutoScroll = True
        Me.tstMain.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize
        Me.tstMain.Focus()

        Call FormatForm()
        Call GetWeeklyTransactonsNumbers()
        Call GetPendingTransactonsNumbers()

        Me.DepositToolStripMenuItem.Visible = False
        Me.DavideTadrossToolStripMenuItem.Visible = False


    End Sub

    Private Sub FrmMainPlatform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub FormatForm()

        If vUser_Roll = "Trader" Then
            Me.TransactionManagementsToolStripMenuItem.Enabled = False
            Me.CommissionManagemetsToolStripMenuItem.Enabled = False
            Me.tsbUsersMain.Enabled = False
        End If

        Me.lblMainHeader.Visible = False
        Me.lblMainHeader.Text = Nothing

        vWidth = Me.Width - 10
        vHeight = Me.Height - 160

        Me.Panel_Main.Width = vWidth - 3
        Me.PanelBase.Width = vWidth
        Me.Panel_Main.Height = vHeight - 32
        Me.PanelBase.Height = vHeight
        Me.lblVersion.Location = New Point(5, Me.Height - 40)
        '  Me.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Image.gif")
    End Sub

    Public Sub GetWeeklyTransactonsNumbers()
        Dim ds As New DataTable
        Dim par As New ceTransaction
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        ds = BusinessLogic.GetTotalDailyTransactions().Tables("TotalWeekly")
        Me.lblTotalDailyTranches.Text = Nothing
        If ds.Rows.Count > 0 Then
            Me.lblTotalDailyTranches.Text = ("Total Transactions:" & "  " & ds.Rows(0).Item(0).ToString())
        Else
            Me.lblTotalDailyTranches.Text = ("Total Transactions:" & "  " & 0)

        End If

    End Sub


    Public Sub GetPendingTransactonsNumbers()
        Dim ds As New DataTable
        Dim par As New ceTransaction
        Dim BusinessLogic As New BusinessLogic.cnTransaction
        ds = BusinessLogic.GetPendingsDailyTransactions().Tables("TotalPending")
        Me.lblPendingTransactions.Text = Nothing
        Me.lblPendingCommissions.Text = Nothing
        If ds.Rows.Count > 0 Then
            Me.lblPendingTransactions.Text = ("Pending Transactions:" & "  " & ds.Rows(0).Item(0).ToString())
            Me.lblPendingCommissions.Text = ("Pending Commissions:" & "  " & ds.Rows(0).Item(1).ToString())
        Else
            Me.lblPendingTransactions.Text = ("Pending Transactions:" & "  " & 0)
            Me.lblPendingCommissions.Text = ("Pending Commissions:" & "  " & 0)
        End If

        If ds.Rows.Count > 0 Then
            If ds.Rows(0).Item(0).ToString() > 0 Then
                Me.lblPendingTransactions.ForeColor = Color.Red
            Else
                Me.lblPendingTransactions.ForeColor = Color.WhiteSmoke
            End If
            If ds.Rows(0).Item(1).ToString() > 0 Then
                Me.lblPendingCommissions.ForeColor = Color.Red
            Else
                Me.lblPendingCommissions.ForeColor = Color.WhiteSmoke
            End If
        End If


    End Sub

    Private Sub tsbNewProviders_Click(sender As Object, e As EventArgs) Handles tsbNewProviders.Click
        Dim frmProviders As New frmProviders
        NewTransaction.Close()
        Me.lblMainHeader.Text = "New Provider"
        Me.lblMainHeader.ForeColor = Color.WhiteSmoke
        Me.lblMainHeader.Visible = True

        If Panel_Main.Controls.Count = 0 Then
            frmProviders.TopLevel = False
            frmProviders.FormBorderStyle = FormBorderStyle.None
            frmProviders.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmProviders)
            frmProviders.Show()
        Else
            Panel_Main.Controls.Clear()
            frmProviders.TopLevel = False
            frmProviders.FormBorderStyle = FormBorderStyle.None
            frmProviders.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmProviders)
            frmProviders.Show()
        End If
    End Sub

    Private Sub ProviderManagementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProviderManagementsToolStripMenuItem.Click

    End Sub



    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tstMain.ItemClicked
        Call FormatForm()
    End Sub


    Private Sub CreateNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewToolStripMenuItem.DoubleClick

        NewTransaction.Close()
        Me.lblMainHeader.Text = "Transactions"
        Me.lblMainHeader.ForeColor = Color.WhiteSmoke
        Me.lblMainHeader.Visible = True

        If Panel_Main.Controls.Count = 0 Then
            frmEmptyTransactions.TopLevel = False
            frmEmptyTransactions.FormBorderStyle = FormBorderStyle.None
            frmEmptyTransactions.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmEmptyTransactions)
            frmEmptyTransactions.Show()
        Else
            Panel_Main.Controls.Clear()
            frmEmptyTransactions.TopLevel = False
            frmEmptyTransactions.FormBorderStyle = FormBorderStyle.None
            frmEmptyTransactions.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmEmptyTransactions)
            frmEmptyTransactions.Show()
        End If
    End Sub

    Private Sub DavideTadrossToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DavideTadrossToolStripMenuItem.Click

        NewTransaction.Close()
        Me.lblMainHeader.Text = "Transactions Davide-Tadross"
        Me.lblMainHeader.ForeColor = Color.WhiteSmoke
        Me.lblMainHeader.Visible = True

        If Panel_Main.Controls.Count = 0 Then
            NewTransaction.TopLevel = False
            NewTransaction.FormBorderStyle = FormBorderStyle.None
            NewTransaction.Dock = DockStyle.None
            Panel_Main.Controls.Add(NewTransaction)
            NewTransaction.Show()
        Else
            Panel_Main.Controls.Clear()
            NewTransaction.TopLevel = False
            NewTransaction.FormBorderStyle = FormBorderStyle.None
            NewTransaction.Dock = DockStyle.None
            Panel_Main.Controls.Add(NewTransaction)
            NewTransaction.Show()
        End If
    End Sub

    Private Sub EmptyTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmptyTransactionToolStripMenuItem.Click

        NewTransaction.Close()
        Me.lblMainHeader.Text = "Transactions"
        Me.lblMainHeader.ForeColor = Color.WhiteSmoke
        Me.lblMainHeader.Visible = True

        If Panel_Main.Controls.Count = 0 Then
            frmEmptyTransactions.TopLevel = False
            frmEmptyTransactions.FormBorderStyle = FormBorderStyle.None
            frmEmptyTransactions.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmEmptyTransactions)
            frmEmptyTransactions.Show()
        Else
            Panel_Main.Controls.Clear()
            frmEmptyTransactions.TopLevel = False
            frmEmptyTransactions.FormBorderStyle = FormBorderStyle.None
            frmEmptyTransactions.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmEmptyTransactions)
            frmEmptyTransactions.Show()
        End If
    End Sub

    Private Sub ClosePendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosePendingToolStripMenuItem.Click

        NewTransaction.Close()
        Me.lblMainHeader.Text = "Pending Transactions"
        Me.lblMainHeader.ForeColor = Color.WhiteSmoke
        Me.lblMainHeader.Visible = True

        If Panel_Main.Controls.Count = 0 Then
            frmPendingTransactions.TopLevel = False
            frmPendingTransactions.FormBorderStyle = FormBorderStyle.None
            frmPendingTransactions.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmPendingTransactions)
            frmPendingTransactions.Show()
        Else
            Panel_Main.Controls.Clear()
            frmPendingTransactions.TopLevel = False
            frmPendingTransactions.FormBorderStyle = FormBorderStyle.None
            frmPendingTransactions.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmPendingTransactions)
            frmPendingTransactions.Show()
        End If
    End Sub

    Private Sub PaidCommissionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaidCommissionsToolStripMenuItem.Click

        Me.lblMainHeader.Text = "Commissions"
        Me.lblMainHeader.ForeColor = Color.WhiteSmoke
        Me.lblMainHeader.Visible = True
        NewCommission.TopLevel = False
        If Panel_Main.Controls.Count = 0 Then
            NewCommission.TopLevel = False
            NewCommission.FormBorderStyle = FormBorderStyle.None
            NewCommission.Dock = DockStyle.None
            Panel_Main.Controls.Add(NewCommission)
            NewCommission.Show()
        Else
            Panel_Main.Controls.Clear()
            NewCommission.TopLevel = False
            NewCommission.FormBorderStyle = FormBorderStyle.None
            NewCommission.Dock = DockStyle.None
            Panel_Main.Controls.Add(NewCommission)
            NewCommission.Show()
        End If
    End Sub


    Private Sub TransactionManagementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionManagementsToolStripMenuItem.Click
        NewTransaction.Close()
        frmPendingTransactions.Close()
        Me.lblMainHeader.Text = "Modify Transactions"
        Me.lblMainHeader.ForeColor = Color.WhiteSmoke
        Me.lblMainHeader.Visible = True

        If Panel_Main.Controls.Count = 0 Then
            frmTransactionsManagements.TopLevel = False
            frmTransactionsManagements.FormBorderStyle = FormBorderStyle.None
            frmTransactionsManagements.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmTransactionsManagements)
            frmTransactionsManagements.Show()
        Else
            Panel_Main.Controls.Clear()
            frmTransactionsManagements.TopLevel = False
            frmTransactionsManagements.FormBorderStyle = FormBorderStyle.None
            frmTransactionsManagements.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmTransactionsManagements)
            frmTransactionsManagements.Show()
        End If
    End Sub



    Private Sub UserManagementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagementsToolStripMenuItem.Click
        NewTransaction.Close()
        frmPendingTransactions.Close()
        Me.lblMainHeader.Text = "Users Managements"
        Me.lblMainHeader.ForeColor = Color.WhiteSmoke
        Me.lblMainHeader.Visible = True

        If Panel_Main.Controls.Count = 0 Then
            frmUserManagements.TopLevel = False
            frmUserManagements.FormBorderStyle = FormBorderStyle.None
            frmUserManagements.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmUserManagements)
            frmUserManagements.Show()
        Else
            Panel_Main.Controls.Clear()
            frmUserManagements.TopLevel = False
            frmUserManagements.FormBorderStyle = FormBorderStyle.None
            frmUserManagements.Dock = DockStyle.None
            Panel_Main.Controls.Add(frmUserManagements)
            frmUserManagements.Show()
        End If
    End Sub

    Private Sub NewDepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDepositToolStripMenuItem.Click

        'Form2.Close()
        'Me.lblMainHeader.Text = "Transactions"
        'Me.lblMainHeader.ForeColor = Color.WhiteSmoke
        'Me.lblMainHeader.Visible = True

        'If Panel_Main.Controls.Count = 0 Then
        '    Form2.TopLevel = False
        '    Form2.FormBorderStyle = FormBorderStyle.None
        '    Form2.Dock = DockStyle.None
        '    Panel_Main.Controls.Add(Form2)
        '    Form2.Show()
        'Else
        '    Panel_Main.Controls.Clear()
        'Form2.TopLevel = False
        '    Form2.FormBorderStyle = FormBorderStyle.None
        '    Form2.Dock = DockStyle.None
        '    Panel_Main.Controls.Add(Form2) 
        'End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class