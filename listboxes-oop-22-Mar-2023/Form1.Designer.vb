<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAnItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAnItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSelectedItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveEverytingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApproxSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApproxSearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdititngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"milk", "bread", "butter", "eggs", "chocholate", "tomatoes", "water"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(403, 424)
        Me.ListBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionsToolStripMenuItem, Me.EdititngToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(406, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAnItemToolStripMenuItem, Me.RemoveAnItemToolStripMenuItem, Me.RemoveSelectedItemsToolStripMenuItem, Me.RemoveEverytingToolStripMenuItem, Me.ApproxSearchToolStripMenuItem, Me.ApproxSearchToolStripMenuItem1})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ActionsToolStripMenuItem.Text = "Actions"
        '
        'AddAnItemToolStripMenuItem
        '
        Me.AddAnItemToolStripMenuItem.Name = "AddAnItemToolStripMenuItem"
        Me.AddAnItemToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.AddAnItemToolStripMenuItem.Text = "Add an item"
        '
        'RemoveAnItemToolStripMenuItem
        '
        Me.RemoveAnItemToolStripMenuItem.Name = "RemoveAnItemToolStripMenuItem"
        Me.RemoveAnItemToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.RemoveAnItemToolStripMenuItem.Text = "Remove an item"
        '
        'RemoveSelectedItemsToolStripMenuItem
        '
        Me.RemoveSelectedItemsToolStripMenuItem.Name = "RemoveSelectedItemsToolStripMenuItem"
        Me.RemoveSelectedItemsToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.RemoveSelectedItemsToolStripMenuItem.Text = "Remove selected items"
        '
        'RemoveEverytingToolStripMenuItem
        '
        Me.RemoveEverytingToolStripMenuItem.Name = "RemoveEverytingToolStripMenuItem"
        Me.RemoveEverytingToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.RemoveEverytingToolStripMenuItem.Text = "Remove everyting"
        '
        'ApproxSearchToolStripMenuItem
        '
        Me.ApproxSearchToolStripMenuItem.Name = "ApproxSearchToolStripMenuItem"
        Me.ApproxSearchToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.ApproxSearchToolStripMenuItem.Text = "Exact search"
        '
        'ApproxSearchToolStripMenuItem1
        '
        Me.ApproxSearchToolStripMenuItem1.Name = "ApproxSearchToolStripMenuItem1"
        Me.ApproxSearchToolStripMenuItem1.Size = New System.Drawing.Size(245, 26)
        Me.ApproxSearchToolStripMenuItem1.Text = "Approx search"
        '
        'EdititngToolStripMenuItem
        '
        Me.EdititngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.EdititngToolStripMenuItem.Name = "EdititngToolStripMenuItem"
        Me.EdititngToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.EdititngToolStripMenuItem.Text = "Edititng"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ActionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAnItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveAnItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveSelectedItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveEverytingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApproxSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApproxSearchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EdititngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
End Class
