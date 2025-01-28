<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        lblVersion = New Label()
        PanelBase = New Panel()
        Panel_Main = New Panel()
        tstMain = New ToolStrip()
        tsbMain = New ToolStripSplitButton()
        DepositToolStripMenuItem = New ToolStripMenuItem()
        NewDepositToolStripMenuItem = New ToolStripMenuItem()
        DepositManagementsToolStripMenuItem = New ToolStripMenuItem()
        tsbNewTransaction = New ToolStripMenuItem()
        CreateNewToolStripMenuItem = New ToolStripMenuItem()
        EmptyTransactionToolStripMenuItem = New ToolStripMenuItem()
        DavideTadrossToolStripMenuItem = New ToolStripMenuItem()
        ClosePendingToolStripMenuItem = New ToolStripMenuItem()
        TransactionManagementsToolStripMenuItem = New ToolStripMenuItem()
        tsbPaidCommission = New ToolStripMenuItem()
        PaidCommissionsToolStripMenuItem = New ToolStripMenuItem()
        CommissionManagemetsToolStripMenuItem = New ToolStripMenuItem()
        tsbCryptocurrencies = New ToolStripMenuItem()
        ToolStripSplitButton1 = New ToolStripSplitButton()
        tsbNewProviders = New ToolStripMenuItem()
        ProviderManagementsToolStripMenuItem = New ToolStripMenuItem()
        tsbAgents = New ToolStripSplitButton()
        tsbNewAgent = New ToolStripMenuItem()
        tsbUsersMain = New ToolStripSplitButton()
        UserManagementsToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        lblMainHeader = New Label()
        lblTotalDailyTranches = New Label()
        lblPendingTransactions = New Label()
        lblPendingCommissions = New Label()
        btnClose = New Button()
        btnHide = New Button()
        PanelBase.SuspendLayout()
        tstMain.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblVersion
        ' 
        lblVersion.Anchor = AnchorStyles.None
        lblVersion.AutoSize = True
        lblVersion.BackColor = Color.Transparent
        lblVersion.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        lblVersion.ForeColor = Color.SteelBlue
        lblVersion.Location = New Point(11, 1047)
        lblVersion.Margin = New Padding(2, 0, 2, 0)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(51, 20)
        lblVersion.TabIndex = 0
        lblVersion.Text = "Label1"
        ' 
        ' PanelBase
        ' 
        PanelBase.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelBase.AutoScroll = True
        PanelBase.BackColor = Color.Transparent
        PanelBase.BorderStyle = BorderStyle.FixedSingle
        PanelBase.Controls.Add(Panel_Main)
        PanelBase.Controls.Add(tstMain)
        PanelBase.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        PanelBase.Location = New Point(6, 152)
        PanelBase.Margin = New Padding(2, 3, 2, 3)
        PanelBase.Name = "PanelBase"
        PanelBase.Size = New Size(1450, 892)
        PanelBase.TabIndex = 1
        ' 
        ' Panel_Main
        ' 
        Panel_Main.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel_Main.AutoScroll = True
        Panel_Main.BackColor = SystemColors.Control
        Panel_Main.Location = New Point(4, 36)
        Panel_Main.Margin = New Padding(2, 3, 2, 3)
        Panel_Main.Name = "Panel_Main"
        Panel_Main.Size = New Size(1438, 845)
        Panel_Main.TabIndex = 1
        ' 
        ' tstMain
        ' 
        tstMain.BackColor = Color.MidnightBlue
        tstMain.Dock = DockStyle.None
        tstMain.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        tstMain.GripStyle = ToolStripGripStyle.Hidden
        tstMain.ImageScalingSize = New Size(32, 32)
        tstMain.ImeMode = ImeMode.NoControl
        tstMain.Items.AddRange(New ToolStripItem() {tsbMain, ToolStripSplitButton1, tsbAgents, tsbUsersMain})
        tstMain.Location = New Point(0, 0)
        tstMain.Margin = New Padding(2, 3, 2, 3)
        tstMain.Name = "tstMain"
        tstMain.Size = New Size(380, 35)
        tstMain.TabIndex = 0
        tstMain.Text = " "
        ' 
        ' tsbMain
        ' 
        tsbMain.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbMain.DropDownItems.AddRange(New ToolStripItem() {DepositToolStripMenuItem, tsbNewTransaction, tsbPaidCommission, tsbCryptocurrencies})
        tsbMain.ForeColor = Color.White
        tsbMain.Image = CType(resources.GetObject("tsbMain.Image"), Image)
        tsbMain.ImageTransparentColor = Color.Magenta
        tsbMain.Name = "tsbMain"
        tsbMain.Size = New Size(98, 32)
        tsbMain.Text = "Trading"
        ' 
        ' DepositToolStripMenuItem
        ' 
        DepositToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewDepositToolStripMenuItem, DepositManagementsToolStripMenuItem})
        DepositToolStripMenuItem.Name = "DepositToolStripMenuItem"
        DepositToolStripMenuItem.Size = New Size(243, 32)
        DepositToolStripMenuItem.Text = "Deposit"
        ' 
        ' NewDepositToolStripMenuItem
        ' 
        NewDepositToolStripMenuItem.Name = "NewDepositToolStripMenuItem"
        NewDepositToolStripMenuItem.Size = New Size(291, 32)
        NewDepositToolStripMenuItem.Text = "New Deposit"
        ' 
        ' DepositManagementsToolStripMenuItem
        ' 
        DepositManagementsToolStripMenuItem.Name = "DepositManagementsToolStripMenuItem"
        DepositManagementsToolStripMenuItem.Size = New Size(291, 32)
        DepositManagementsToolStripMenuItem.Text = "Deposit Managements"
        ' 
        ' tsbNewTransaction
        ' 
        tsbNewTransaction.DropDownItems.AddRange(New ToolStripItem() {CreateNewToolStripMenuItem, ClosePendingToolStripMenuItem, TransactionManagementsToolStripMenuItem})
        tsbNewTransaction.Name = "tsbNewTransaction"
        tsbNewTransaction.Size = New Size(243, 32)
        tsbNewTransaction.Text = "Transactions"
        ' 
        ' CreateNewToolStripMenuItem
        ' 
        CreateNewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EmptyTransactionToolStripMenuItem, DavideTadrossToolStripMenuItem})
        CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem"
        CreateNewToolStripMenuItem.Size = New Size(337, 32)
        CreateNewToolStripMenuItem.Text = "Create New"
        ' 
        ' EmptyTransactionToolStripMenuItem
        ' 
        EmptyTransactionToolStripMenuItem.Name = "EmptyTransactionToolStripMenuItem"
        EmptyTransactionToolStripMenuItem.Size = New Size(259, 32)
        EmptyTransactionToolStripMenuItem.Text = "Empty Transaction"
        ' 
        ' DavideTadrossToolStripMenuItem
        ' 
        DavideTadrossToolStripMenuItem.Name = "DavideTadrossToolStripMenuItem"
        DavideTadrossToolStripMenuItem.Size = New Size(259, 32)
        DavideTadrossToolStripMenuItem.Text = "Davide-Tadross"
        ' 
        ' ClosePendingToolStripMenuItem
        ' 
        ClosePendingToolStripMenuItem.Name = "ClosePendingToolStripMenuItem"
        ClosePendingToolStripMenuItem.Size = New Size(337, 32)
        ClosePendingToolStripMenuItem.Text = "Close Pending Transactions"
        ' 
        ' TransactionManagementsToolStripMenuItem
        ' 
        TransactionManagementsToolStripMenuItem.Name = "TransactionManagementsToolStripMenuItem"
        TransactionManagementsToolStripMenuItem.Size = New Size(337, 32)
        TransactionManagementsToolStripMenuItem.Text = "Transaction Managements"
        ' 
        ' tsbPaidCommission
        ' 
        tsbPaidCommission.DropDownItems.AddRange(New ToolStripItem() {PaidCommissionsToolStripMenuItem, CommissionManagemetsToolStripMenuItem})
        tsbPaidCommission.Name = "tsbPaidCommission"
        tsbPaidCommission.Size = New Size(243, 32)
        tsbPaidCommission.Text = "Commissions"
        ' 
        ' PaidCommissionsToolStripMenuItem
        ' 
        PaidCommissionsToolStripMenuItem.Name = "PaidCommissionsToolStripMenuItem"
        PaidCommissionsToolStripMenuItem.Size = New Size(321, 32)
        PaidCommissionsToolStripMenuItem.Text = "Paid Commissions"
        ' 
        ' CommissionManagemetsToolStripMenuItem
        ' 
        CommissionManagemetsToolStripMenuItem.Name = "CommissionManagemetsToolStripMenuItem"
        CommissionManagemetsToolStripMenuItem.Size = New Size(321, 32)
        CommissionManagemetsToolStripMenuItem.Text = "Commission Managemets"
        ' 
        ' tsbCryptocurrencies
        ' 
        tsbCryptocurrencies.Name = "tsbCryptocurrencies"
        tsbCryptocurrencies.Size = New Size(243, 32)
        tsbCryptocurrencies.Text = "Cryptocurrencies"
        ' 
        ' ToolStripSplitButton1
        ' 
        ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripSplitButton1.DropDownItems.AddRange(New ToolStripItem() {tsbNewProviders, ProviderManagementsToolStripMenuItem})
        ToolStripSplitButton1.ForeColor = Color.White
        ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), Image)
        ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        ToolStripSplitButton1.Size = New Size(111, 32)
        ToolStripSplitButton1.Text = "Providers"
        ' 
        ' tsbNewProviders
        ' 
        tsbNewProviders.Name = "tsbNewProviders"
        tsbNewProviders.Size = New Size(298, 32)
        tsbNewProviders.Text = "New Providers"
        ' 
        ' ProviderManagementsToolStripMenuItem
        ' 
        ProviderManagementsToolStripMenuItem.Name = "ProviderManagementsToolStripMenuItem"
        ProviderManagementsToolStripMenuItem.Size = New Size(298, 32)
        ProviderManagementsToolStripMenuItem.Text = "Provider Managements"
        ' 
        ' tsbAgents
        ' 
        tsbAgents.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbAgents.DropDownItems.AddRange(New ToolStripItem() {tsbNewAgent})
        tsbAgents.ForeColor = Color.White
        tsbAgents.Image = CType(resources.GetObject("tsbAgents.Image"), Image)
        tsbAgents.ImageTransparentColor = Color.Magenta
        tsbAgents.Name = "tsbAgents"
        tsbAgents.Size = New Size(90, 32)
        tsbAgents.Text = "Agents"
        ' 
        ' tsbNewAgent
        ' 
        tsbNewAgent.BackgroundImageLayout = ImageLayout.Stretch
        tsbNewAgent.Name = "tsbNewAgent"
        tsbNewAgent.Size = New Size(188, 32)
        tsbNewAgent.Text = "NewAgent"
        ' 
        ' tsbUsersMain
        ' 
        tsbUsersMain.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbUsersMain.DropDownItems.AddRange(New ToolStripItem() {UserManagementsToolStripMenuItem})
        tsbUsersMain.ForeColor = Color.White
        tsbUsersMain.Image = CType(resources.GetObject("tsbUsersMain.Image"), Image)
        tsbUsersMain.ImageTransparentColor = Color.Magenta
        tsbUsersMain.Name = "tsbUsersMain"
        tsbUsersMain.Size = New Size(78, 32)
        tsbUsersMain.Text = "Users"
        ' 
        ' UserManagementsToolStripMenuItem
        ' 
        UserManagementsToolStripMenuItem.Name = "UserManagementsToolStripMenuItem"
        UserManagementsToolStripMenuItem.Size = New Size(265, 32)
        UserManagementsToolStripMenuItem.Text = "User Managements"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLight
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 12)
        PictureBox1.Margin = New Padding(2, 3, 2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' lblMainHeader
        ' 
        lblMainHeader.AutoSize = True
        lblMainHeader.BackColor = Color.Transparent
        lblMainHeader.Font = New Font("Segoe UI", 30F, FontStyle.Italic)
        lblMainHeader.ForeColor = SystemColors.ButtonFace
        lblMainHeader.Location = New Point(390, 29)
        lblMainHeader.Name = "lblMainHeader"
        lblMainHeader.Size = New Size(184, 67)
        lblMainHeader.TabIndex = 3
        lblMainHeader.Text = "Header"
        ' 
        ' lblTotalDailyTranches
        ' 
        lblTotalDailyTranches.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalDailyTranches.AutoSize = True
        lblTotalDailyTranches.BackColor = Color.Transparent
        lblTotalDailyTranches.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        lblTotalDailyTranches.ForeColor = Color.WhiteSmoke
        lblTotalDailyTranches.Location = New Point(899, 128)
        lblTotalDailyTranches.Name = "lblTotalDailyTranches"
        lblTotalDailyTranches.Size = New Size(106, 20)
        lblTotalDailyTranches.TabIndex = 4
        lblTotalDailyTranches.Text = "Total Tranches:"
        ' 
        ' lblPendingTransactions
        ' 
        lblPendingTransactions.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPendingTransactions.AutoSize = True
        lblPendingTransactions.BackColor = Color.Transparent
        lblPendingTransactions.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        lblPendingTransactions.ForeColor = Color.WhiteSmoke
        lblPendingTransactions.Location = New Point(1050, 128)
        lblPendingTransactions.Name = "lblPendingTransactions"
        lblPendingTransactions.Size = New Size(149, 20)
        lblPendingTransactions.TabIndex = 6
        lblPendingTransactions.Text = "Pending Transactions:"
        ' 
        ' lblPendingCommissions
        ' 
        lblPendingCommissions.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPendingCommissions.AutoSize = True
        lblPendingCommissions.BackColor = Color.Transparent
        lblPendingCommissions.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        lblPendingCommissions.ForeColor = Color.WhiteSmoke
        lblPendingCommissions.Location = New Point(1243, 128)
        lblPendingCommissions.Name = "lblPendingCommissions"
        lblPendingCommissions.Size = New Size(154, 20)
        lblPendingCommissions.TabIndex = 9
        lblPendingCommissions.Text = "Pending Commissions:"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.FlatAppearance.BorderColor = Color.MediumBlue
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.CornflowerBlue
        btnClose.Location = New Point(1426, 5)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(28, 27)
        btnClose.TabIndex = 10
        btnClose.Text = "X"
        btnClose.TextAlign = ContentAlignment.TopCenter
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnHide
        ' 
        btnHide.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnHide.BackColor = Color.Transparent
        btnHide.FlatAppearance.BorderColor = Color.MediumBlue
        btnHide.FlatStyle = FlatStyle.Flat
        btnHide.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnHide.ForeColor = Color.CornflowerBlue
        btnHide.Location = New Point(1387, 5)
        btnHide.Name = "btnHide"
        btnHide.Size = New Size(28, 27)
        btnHide.TabIndex = 11
        btnHide.Text = "="
        btnHide.TextAlign = ContentAlignment.TopCenter
        btnHide.UseVisualStyleBackColor = False
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1460, 1075)
        Controls.Add(lblVersion)
        Controls.Add(btnHide)
        Controls.Add(btnClose)
        Controls.Add(lblPendingCommissions)
        Controls.Add(lblMainHeader)
        Controls.Add(lblTotalDailyTranches)
        Controls.Add(lblPendingTransactions)
        Controls.Add(PictureBox1)
        Controls.Add(PanelBase)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 3, 2, 3)
        MaximizeBox = False
        MaximumSize = New Size(1460, 1151)
        MinimumSize = New Size(1460, 1027)
        Name = "Main"
        StartPosition = FormStartPosition.CenterParent
        PanelBase.ResumeLayout(False)
        PanelBase.PerformLayout()
        tstMain.ResumeLayout(False)
        tstMain.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblVersion As Label
    Friend WithEvents PanelBase As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tstMain As ToolStrip
    Friend WithEvents tsbMain As ToolStripSplitButton
    Friend WithEvents tsbNewTransaction As ToolStripMenuItem
    Friend WithEvents tsbCryptocurrencies As ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents tsbNewProviders As ToolStripMenuItem
    Friend WithEvents tsbAgents As ToolStripSplitButton
    Friend WithEvents tsbNewAgent As ToolStripMenuItem
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents tsbPaidCommission As ToolStripMenuItem
    Friend WithEvents lblMainHeader As Label
    Friend WithEvents lblTotalDailyTranches As Label
    Friend WithEvents lblPendingTransactions As Label
    Friend WithEvents lblPendingCommissions As Label
    Friend WithEvents CreateNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClosePendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionManagementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaidCommissionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewDepositToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositManagementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommissionManagemetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DavideTadrossToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmptyTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbUsersMain As ToolStripSplitButton
    Friend WithEvents UserManagementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClose As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents ProviderManagementsToolStripMenuItem As ToolStripMenuItem
End Class
