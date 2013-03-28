Public Class LOL
    Private index As Integer
    Private x As New Random

    Private Sub LOL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BackColor = Color.White
        TransparencyKey = BackColor
        TimerIndexLOL.Start()
        My.Computer.Audio.Play(My.Resources.Dr__Dre____Still_D_R_E__faster, AudioPlayMode.BackgroundLoop)

    End Sub

End Class