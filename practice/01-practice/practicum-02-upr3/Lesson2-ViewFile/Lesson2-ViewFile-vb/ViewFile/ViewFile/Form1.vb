Imports System.IO

Public Class Form1

    Private Sub browseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseButton.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog
        ofd.ShowDialog()
        locationTextBox.Text = ofd.FileName
    End Sub

    Private Sub showButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showButton.Click
        Dim tr As TextReader = New StreamReader(locationTextBox.Text)
        displayTextBox.Text = tr.ReadToEnd
    End Sub
End Class
