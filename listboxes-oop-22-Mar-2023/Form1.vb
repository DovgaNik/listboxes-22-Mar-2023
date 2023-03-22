Public Class Form1
    Private Sub AddAnItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAnItemToolStripMenuItem.Click
        Dim newItem As String
        newItem = InputBox("Input an item: ", "Add an item")
        newItem = newItem.Trim()
        If newItem <> String.Empty Then
            If ListBox1.FindStringExact(newItem.Trim()) = -1 Then
                ListBox1.Items.Add(newItem)
            Else
                MessageBox.Show("The item is already added")
            End If
        End If
    End Sub
End Class
