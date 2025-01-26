<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrency
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
        GroupBox1 = New GroupBox()
        dgvCurrency = New DataGridView()
        txtCurrencyDefaultValue = New TextBox()
        txtCurrencyName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnClear = New Button()
        btnSave = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(dgvCurrency, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvCurrency)
        GroupBox1.Controls.Add(txtCurrencyDefaultValue)
        GroupBox1.Controls.Add(txtCurrencyName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(19, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(419, 442)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "New Currency"
        ' 
        ' dgvCurrency
        ' 
        dgvCurrency.BackgroundColor = Color.White
        dgvCurrency.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCurrency.Location = New Point(66, 141)
        dgvCurrency.Name = "dgvCurrency"
        dgvCurrency.RowHeadersWidth = 51
        dgvCurrency.Size = New Size(286, 279)
        dgvCurrency.TabIndex = 1
        ' 
        ' txtCurrencyDefaultValue
        ' 
        txtCurrencyDefaultValue.BorderStyle = BorderStyle.FixedSingle
        txtCurrencyDefaultValue.Location = New Point(163, 95)
        txtCurrencyDefaultValue.Name = "txtCurrencyDefaultValue"
        txtCurrencyDefaultValue.Size = New Size(189, 27)
        txtCurrencyDefaultValue.TabIndex = 3
        ' 
        ' txtCurrencyName
        ' 
        txtCurrencyName.BorderStyle = BorderStyle.FixedSingle
        txtCurrencyName.Location = New Point(163, 49)
        txtCurrencyName.Name = "txtCurrencyName"
        txtCurrencyName.Size = New Size(189, 27)
        txtCurrencyName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 1
        Label2.Text = "Default Value:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(490, 340)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(131, 52)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(490, 402)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(131, 52)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cryptocurrency
        PictureBox1.Location = New Point(465, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(183, 179)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' frmCurrency
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(674, 500)
        Controls.Add(PictureBox1)
        Controls.Add(btnSave)
        Controls.Add(btnClear)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(685, 540)
        MinimumSize = New Size(674, 500)
        Name = "frmCurrency"
        Text = "Currency"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvCurrency, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCurrencyDefaultValue As TextBox
    Friend WithEvents txtCurrencyName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCurrency As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
