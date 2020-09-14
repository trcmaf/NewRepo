Public Class Form1
    Dim t As Timer

    Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        t = New System.Windows.Forms.Timer
        t.Interval = 1000

        AddHandler t.Tick, AddressOf Me.t_Tick
        t.Start()
    End Sub

    Private Sub t_Tick(ByVal sender As Object, ByVal e As EventArgs)
        ProgressBar1.Value += 10
        If ProgressBar1.Value = 100 Then
            t.Stop()
        End If
    End Sub
End Class
