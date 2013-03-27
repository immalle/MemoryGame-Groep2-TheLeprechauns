Public Class LOL
    Private index As Integer
    Private x As New Random

    Private Sub LOL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BackColor = Color.White
        TransparencyKey = BackColor
        TimerIndexLOL.Start()
        My.Computer.Audio.Play(My.Resources.Dr__Dre____Still_D_R_E__faster, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub TimerIndexLOL_Tick(sender As System.Object, e As System.EventArgs) Handles TimerIndexLOL.Tick
        index += 1
        If index Mod 2 = 0 Then
            PictureBoxLOL.Visible = True
        Else : PictureBoxLOL.Visible = False
        End If
        Dim randomx As Integer = x.Next(10, 1100)
        Dim randomy As Integer = x.Next(12, 445)
        PictureBoxLOL.Location = New Point(randomx, randomy)
    End Sub
End Class