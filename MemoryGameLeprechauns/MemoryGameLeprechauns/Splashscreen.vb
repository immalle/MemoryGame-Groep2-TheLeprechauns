﻿Public Class Splashscreen

    Private SplashscreenIndex As Single = 0

    Private Sub Splashscreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BackColor = Color.White
        TransparencyKey = BackColor
        splashscreentimer.start()
    End Sub

    Private Sub Splashscreentimer_Tick(sender As System.Object, e As System.EventArgs) Handles Splashscreentimer.Tick
        SplashscreenIndex += 1
        If SplashscreenIndex > 1 Then

            StartScherm.Show()
            StartScherm.Focus()
            Me.Hide()
            Splashscreentimer.Stop()
        End If

    End Sub

   
End Class
