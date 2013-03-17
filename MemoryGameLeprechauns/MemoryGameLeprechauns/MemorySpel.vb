Public Class MemorySpel
    Private KaartIndex As Integer = 0
    Private Xcoordinaat As Integer = 20
    Private Ycoordinaat As Integer = 54


    Private Sub MemorySpel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Do While KaartIndex <> 16
            Dim Kaart As New PictureBox
            With Kaart
                .Location = New Point(Xcoordinaat, Ycoordinaat)
                .Size = New Size(StartScherm.Moeilijkheid.AfbeeldingsgrootteX, StartScherm.Moeilijkheid.AfbeeldingsgrootteY)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Image = My.Resources.TheLeprechaunsCard
                .BackColor = Color.Transparent
            End With
            If Xcoordinaat > 1100 AndAlso Ycoordinaat > 640 Then
                MsgBox("Test")
            ElseIf Xcoordinaat < 1100 Then
                Xcoordinaat += StartScherm.Moeilijkheid.AfbeeldingsgrootteX + 19
            Else : Ycoordinaat += StartScherm.Moeilijkheid.AfbeeldingsgrootteY + StartScherm.Moeilijkheid.ExtraTussenRuimteY
                Xcoordinaat = 20
            End If
            KaartIndex += 1
            Me.Controls.Add(Kaart)

        Loop
    End Sub


    Private Sub ButtonExit_MouseEnter(sender As System.Object, e As System.EventArgs) Handles ButtonExit.MouseEnter
        ButtonExitSelected.Visible = True
        ButtonExit.Visible = False
    End Sub

    Private Sub ButtonExitSelected_MouseLeave(sender As System.Object, e As System.EventArgs) Handles ButtonExitSelected.MouseLeave
        ButtonExit.Visible = True
        ButtonExitSelected.Visible = False

    End Sub
    Private Sub ButtonExitSelected_MouseClick(sender As System.Object, e As System.EventArgs) Handles ButtonExitSelected.MouseClick
        ' Dit stopt het proces van het spel zonder dit bleef het altijd actief in taskmanager en elke keer dat je het opnieuw opende startte het een nieuw process + je kon het programma niet verwijderen.
        Dim processList() As Process
        processList = Process.GetProcessesByName("MemoryGameLeprechauns")
        For Each proc As Process In processList
            proc.Kill()
        Next

        Me.Close()
    End Sub
End Class