Imports System.IO

Public Class Form1

    Private Sub browseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseButton.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog
        ofd.ShowDialog()
        locationTextBox.Text = ofd.FileName
    End Sub

    Private Sub showButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showButton.Click
        Try
            Dim tr As TextReader = New StreamReader(locationTextBox.Text)
            Try
                displayTextBox.Text = tr.ReadToEnd
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                tr.Close()
            End Try
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("Sorry, the file does not exist.")
        Catch ex As System.UnauthorizedAccessException
            MessageBox.Show("Sorry, you lack sufficient privileges.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
