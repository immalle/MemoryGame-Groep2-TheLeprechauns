Public Class Splashscreen

    Private SplashscreenIndex As Single = 0

    Private Sub Splashscreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BackColor = Color.White
        TransparencyKey = BackColor
        splashscreentimer.start()
    End Sub

    Private Sub Splashscreentimer_Tick(sender As System.Object, e As System.EventArgs) Handles Splashscreentimer.Tick
        SplashscreenIndex += 1
        If SplashscreenIndex > 1 Then
            Me.Hide()
            StartScherm.Show()
            StartScherm.Focus()
            Splashscreentimer.Stop()
        End If

    End Sub

    Private Sub Splashscreenlogo_Click(sender As System.Object, e As System.EventArgs) Handles Splashscreenlogo.Click

    End Sub
End Class
