Public Class MemorySpel
    Private KaartIndex As Integer = 0

    Private Sub MemorySpel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        KaartenLeggen()
    End Sub


    Public Sub KaartenLeggen()
        Do While KaartIndex <> StartScherm.Moeilijkheid.AantalKaarten
            Dim Kaart As New PictureBox

            With Kaart
                .Location = New Point(StartScherm.Moeilijkheid.Xcoordinaat, StartScherm.Moeilijkheid.Ycoordinaat)
                .Size = New Size(StartScherm.Moeilijkheid.AfbeeldingsgrootteX, StartScherm.Moeilijkheid.AfbeeldingsgrootteY)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Image = My.Resources.TheLeprechaunsCard
                .BackColor = Color.Transparent
            End With
            If StartScherm.Moeilijkheid.Xcoordinaat > StartScherm.Moeilijkheid.uitersteX AndAlso StartScherm.Moeilijkheid.Ycoordinaat > StartScherm.Moeilijkheid.uitersteY Then
                MsgBox("Test")
            ElseIf StartScherm.Moeilijkheid.Xcoordinaat < StartScherm.Moeilijkheid.uitersteX Then
                StartScherm.Moeilijkheid.Xcoordinaat += StartScherm.Moeilijkheid.AfbeeldingsgrootteX + StartScherm.Moeilijkheid.ExtraTussenruimteX
            Else : StartScherm.Moeilijkheid.Ycoordinaat += StartScherm.Moeilijkheid.AfbeeldingsgrootteY + StartScherm.Moeilijkheid.ExtraTussenRuimteY
                StartScherm.Moeilijkheid.Xcoordinaat = StartScherm.Moeilijkheid.StartwaardeX
            End If
            AddHandler Kaart.MouseEnter, AddressOf LabelOnMouseEnterEventHandler
            AddHandler Kaart.MouseLeave, AddressOf LabelOnMouseLeaveEventHandler
            KaartIndex += 1
            Me.Controls.Add(Kaart)

        Loop
    End Sub


    Private Sub LabelOnMouseEnterEventHandler(sender As PictureBox, e As System.EventArgs)
        sender.Image = My.Resources.TheLeprechaunsCardSelected
    End Sub
    Private Sub LabelOnMouseLeaveEventHandler(sender As PictureBox, e As System.EventArgs)
        sender.Image = My.Resources.TheLeprechaunsCard
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

    Private Sub ButtonMenu_MouseEnter(sender As System.Object, e As System.EventArgs) Handles ButtonMenu.MouseEnter
        ButtonMenuSelected.Visible = True
        ButtonMenu.Visible = False
    End Sub

    Private Sub ButtonMenu_MouseLeave(sender As System.Object, e As System.EventArgs) Handles ButtonMenuSelected.MouseLeave
        ButtonMenu.Visible = True
        ButtonMenuSelected.Visible = False
    End Sub

    Private Sub ButtonMenu_MouseClick(sender As System.Object, e As System.EventArgs) Handles ButtonMenuSelected.MouseClick
        StartScherm.Show()
        Me.Close()

    End Sub
End Class