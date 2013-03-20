Public Class BackgroundSong
    'Om bepaalde redenen waren was de enigste oplossing om een appart form te maken voor de muziek 
    'Dit form is er enkel om er voor te zorgen dat eerst de intro wordt gespeeld en als die intro is afgelopen het andere deel van de muziek afspeeld en het blijft loopen tot het programma wordt afgesloten.
    'Dit form blijft heel de tijd actief tot men het programma afsluit maar is niet zichtbaar.



    Private introseconden As Integer = 0

    Private Sub BackgroundSong_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load ' wanneer het programma opstart, start ook de intro (het eerste deel) en start de introtimer
        IntroTimer.Start()
        My.Computer.Audio.Play(My.Resources.Leprechaun_Song_Intro, AudioPlayMode.Background)

    End Sub

    Private Sub IntroTimer_Tick(sender As System.Object, e As System.EventArgs) Handles IntroTimer.Tick
        introseconden += 1 'Per keer dat de timer tikt neemt de variabele introseconden met 1 toe wanneer het 125 bedraagt stopt de intro en speelt het 2de deel in een loop
        If introseconden > 125 Then
            IntroTimer.Stop()
            My.Computer.Audio.Play(My.Resources.Leprechaun_Song_Loop, AudioPlayMode.BackgroundLoop)
        End If

    End Sub
End Class