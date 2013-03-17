Public Class BackgroundSong
    Private introseconden As Integer = 0
    Private Sub BackgroundSong_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        IntroTimer.Start()
        My.Computer.Audio.Play(My.Resources.Leprechaun_Song_Intro, AudioPlayMode.Background)

    End Sub

    Private Sub IntroTimer_Tick(sender As System.Object, e As System.EventArgs) Handles IntroTimer.Tick
        introseconden += 1
        If introseconden > 125 Then
            IntroTimer.Stop()
            My.Computer.Audio.Play(My.Resources.Leprechaun_Song_Loop, AudioPlayMode.BackgroundLoop)
        End If

    End Sub
End Class