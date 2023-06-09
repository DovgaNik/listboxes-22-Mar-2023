﻿Imports System.DirectoryServices.ActiveDirectory

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

    Private Sub ExactSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApproxSearchToolStripMenuItem.Click
        ListBox1.ClearSelected()
        Dim searchItem As String
        searchItem = InputBox("What are you searching for?", "Exact search")
        searchItem = searchItem.Trim()
        If searchItem = Nothing Then Exit Sub
        Dim searchRes = ListBox1.FindStringExact(searchItem)
        If searchRes <> -1 Then
            'MessageBox.Show("The item is on the list")
            ListBox1.SelectedIndex = searchRes
        Else
            MessageBox.Show("The item is not on the list")
        End If
    End Sub

    Private Sub ApproxSearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ApproxSearchToolStripMenuItem1.Click
        ListBox1.ClearSelected()
        Dim searchItem As String
        searchItem = InputBox("What are you searching for?", "Approx search")
        searchItem = searchItem.Trim()
        Dim count As Integer = 0
        If searchItem = Nothing Then Exit Sub
        Dim index As Integer
        For index = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(index).ToString.Contains(searchItem) Then
                ListBox1.SetSelected(index, True)
                count += 1
            End If
        Next

        If count = 0 Then
            MessageBox.Show("No item matches the search", "Error")
        End If

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim index As Integer
        index = ListBox1.SelectedIndex

        If ListBox1.SelectedItems.Count <> 1 Then
            MessageBox.Show("Please, select only one item")
            Exit Sub
        End If

        If index <> -1 Then
            ListBox1.Items(index) = InputBox("Edit the item", "Editor", ListBox1.Items(index))
        Else
            MessageBox.Show("Errorrrrrrr: you have not selected anything")
        End If

    End Sub

    Private Sub InvertSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertSelectionToolStripMenuItem.Click
        Dim index As Integer

        For index = 0 To ListBox1.Items.Count - 1
            ListBox1.SetSelected(index, Not ListBox1.GetSelected(index))
        Next

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ListBox1.ClearSelected()
    End Sub
End Class
