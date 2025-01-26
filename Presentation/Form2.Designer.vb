<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        TradeToolStripMenuItem = New ToolStripMenuItem()
        NewTransactionToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TradeToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1187, 28)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TradeToolStripMenuItem
        ' 
        TradeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewTransactionToolStripMenuItem})
        TradeToolStripMenuItem.Name = "TradeToolStripMenuItem"
        TradeToolStripMenuItem.Size = New Size(60, 24)
        TradeToolStripMenuItem.Text = "Trade"
        ' 
        ' NewTransactionToolStripMenuItem
        ' 
        NewTransactionToolStripMenuItem.Name = "NewTransactionToolStripMenuItem"
        NewTransactionToolStripMenuItem.Size = New Size(201, 26)
        NewTransactionToolStripMenuItem.Text = "New Transaction"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(132, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 5
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(134, 322)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 6
        Label2.Text = "Label2"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1187, 628)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Form2"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
