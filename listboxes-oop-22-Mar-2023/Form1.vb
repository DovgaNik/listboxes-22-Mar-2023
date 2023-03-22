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

    Private Sub RemoveAnItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAnItemToolStripMenuItem.Click

        Dim selIndex As Integer
        selIndex = ListBox1.SelectedIndex

        If selIndex = -1 Then
            MessageBox.Show("You have not selected anything")
        Else
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If

    End Sub

    Private Sub RemoveSelectedItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedItemsToolStripMenuItem.Click

        Dim index As Integer
        For index = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.GetSelected(index) Then
                ListBox1.Items.RemoveAt(index)
            End If
        Next

    End Sub

    Private Sub RemoveEverytingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveEverytingToolStripMenuItem.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure", "Remove all", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then ListBox1.Items.Clear()
    End Sub
End Class
