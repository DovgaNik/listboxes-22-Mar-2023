Public Class Form1
    Private Sub AddAnItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAnItemToolStripMenuItem.Click
        Dim newItem As String
        newItem = InputBox("Input an item: ", "Add an item")
        ListBox1.Items.Add(newItem)
    End Sub
End Class
