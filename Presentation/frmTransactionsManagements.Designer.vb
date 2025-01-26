<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionsManagements
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label1 = New Label()
        dgvTransactionLine = New DataGridView()
        dgvTransactions = New DataGridView()
        TabPage2 = New TabPage()
        DataGridView2 = New DataGridView()
        gbTransactionManagements = New GroupBox()
        ckbAllDates = New CheckBox()
        dtpTransactionDate = New DateTimePicker()
        lblTransactionDate = New Label()
        lblCurrency_T = New Label()
        cmbCurrency = New ComboBox()
        cmbProvider = New ComboBox()
        lblProvider_T = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvTransactionLine, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        gbTransactionManagements.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 179)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1386, 650)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(dgvTransactionLine)
        TabPage1.Controls.Add(dgvTransactions)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1378, 617)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Transactions"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 50F)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(366, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(759, 112)
        Label1.TabIndex = 2
        Label1.Text = "Under construction"
        ' 
        ' dgvTransactionLine
        ' 
        dgvTransactionLine.BackgroundColor = Color.White
        dgvTransactionLine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactionLine.Location = New Point(6, 322)
        dgvTransactionLine.Name = "dgvTransactionLine"
        dgvTransactionLine.RowHeadersWidth = 51
        dgvTransactionLine.Size = New Size(1366, 289)
        dgvTransactionLine.TabIndex = 1
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.BackgroundColor = Color.White
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Location = New Point(6, 6)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.RowHeadersWidth = 51
        dgvTransactions.Size = New Size(1366, 282)
        dgvTransactions.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(DataGridView2)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1378, 617)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Commissions"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(6, 6)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(1366, 559)
        DataGridView2.TabIndex = 0
        ' 
        ' gbTransactionManagements
        ' 
        gbTransactionManagements.BackColor = Color.Lavender
        gbTransactionManagements.Controls.Add(ckbAllDates)
        gbTransactionManagements.Controls.Add(dtpTransactionDate)
        gbTransactionManagements.Controls.Add(lblTransactionDate)
        gbTransactionManagements.Controls.Add(lblCurrency_T)
        gbTransactionManagements.Controls.Add(cmbCurrency)
        gbTransactionManagements.Controls.Add(cmbProvider)
        gbTransactionManagements.Controls.Add(lblProvider_T)
        gbTransactionManagements.Location = New Point(12, 7)
        gbTransactionManagements.Name = "gbTransactionManagements"
        gbTransactionManagements.Size = New Size(1376, 166)
        gbTransactionManagements.TabIndex = 1
        gbTransactionManagements.TabStop = False
        ' 
        ' ckbAllDates
        ' 
        ckbAllDates.AutoSize = True
        ckbAllDates.Location = New Point(390, 128)
        ckbAllDates.Name = "ckbAllDates"
        ckbAllDates.Size = New Size(49, 24)
        ckbAllDates.TabIndex = 31
        ckbAllDates.Text = "All"
        ckbAllDates.UseVisualStyleBackColor = True
        ' 
        ' dtpTransactionDate
        ' 
        dtpTransactionDate.CalendarFont = New Font("Segoe UI", 12F)
        dtpTransactionDate.CalendarTitleBackColor = SystemColors.ActiveCaptionText
        dtpTransactionDate.CalendarTitleForeColor = SystemColors.ActiveCaption
        dtpTransactionDate.DropDownAlign = LeftRightAlignment.Right
        dtpTransactionDate.Font = New Font("Segoe UI", 12F)
        dtpTransactionDate.Format = DateTimePickerFormat.Short
        dtpTransactionDate.Location = New Point(191, 121)
        dtpTransactionDate.Margin = New Padding(2, 1, 2, 1)
        dtpTransactionDate.Name = "dtpTransactionDate"
        dtpTransactionDate.Size = New Size(177, 34)
        dtpTransactionDate.TabIndex = 30
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 10.125F)
        lblTransactionDate.Location = New Point(19, 127)
        lblTransactionDate.Margin = New Padding(2, 0, 2, 0)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(142, 23)
        lblTransactionDate.TabIndex = 29
        lblTransactionDate.Text = "Transaction Date:"
        ' 
        ' lblCurrency_T
        ' 
        lblCurrency_T.AutoSize = True
        lblCurrency_T.Font = New Font("Segoe UI", 10.125F)
        lblCurrency_T.Location = New Point(19, 70)
        lblCurrency_T.Margin = New Padding(2, 0, 2, 0)
        lblCurrency_T.Name = "lblCurrency_T"
        lblCurrency_T.Size = New Size(82, 23)
        lblCurrency_T.TabIndex = 28
        lblCurrency_T.Text = "Currency:"
        ' 
        ' cmbCurrency
        ' 
        cmbCurrency.BackColor = SystemColors.HighlightText
        cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency.FlatStyle = FlatStyle.System
        cmbCurrency.Font = New Font("Segoe UI", 10.125F)
        cmbCurrency.FormattingEnabled = True
        cmbCurrency.Location = New Point(143, 70)
        cmbCurrency.Margin = New Padding(2, 1, 2, 1)
        cmbCurrency.Name = "cmbCurrency"
        cmbCurrency.Size = New Size(289, 31)
        cmbCurrency.TabIndex = 27
        ' 
        ' cmbProvider
        ' 
        cmbProvider.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProvider.FormattingEnabled = True
        cmbProvider.Location = New Point(143, 23)
        cmbProvider.Name = "cmbProvider"
        cmbProvider.Size = New Size(289, 28)
        cmbProvider.TabIndex = 26
        ' 
        ' lblProvider_T
        ' 
        lblProvider_T.AutoSize = True
        lblProvider_T.Font = New Font("Segoe UI", 10.125F)
        lblProvider_T.Location = New Point(19, 26)
        lblProvider_T.Margin = New Padding(2, 0, 2, 0)
        lblProvider_T.Name = "lblProvider_T"
        lblProvider_T.Size = New Size(77, 23)
        lblProvider_T.TabIndex = 25
        lblProvider_T.Text = "Provider:"
        ' 
        ' frmTransactionsManagements
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1410, 841)
        Controls.Add(gbTransactionManagements)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmTransactionsManagements"
        Text = "frmTransactionsManagements"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvTransactionLine, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        gbTransactionManagements.ResumeLayout(False)
        gbTransactionManagements.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents gbTransactionManagements As GroupBox
    Friend WithEvents dtpTransactionDate As DateTimePicker
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents lblCurrency_T As Label
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents cmbProvider As ComboBox
    Friend WithEvents lblProvider_T As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents dgvTransactionLine As DataGridView
    Friend WithEvents ckbAllDates As CheckBox
    Friend WithEvents Label1 As Label
End Class
