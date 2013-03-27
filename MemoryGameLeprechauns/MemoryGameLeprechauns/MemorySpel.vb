Public Class MemorySpel


    Private kaartenTimerIndex As Integer = 0
    Private aantalkaarten As Integer = StartScherm.Moeilijkheid.AantalKaarten - 2
    Private kaartenGeklikt As Integer = 0
    Private tijdindex As Double
    Private scoreindex As Integer = 10
    Private foutindex As Integer = 1
    Private kaarttaginex As Integer = 0
    Private afbeeldingenlijst As New List(Of Image)
    Private afbeeldingenlijst2 As New List(Of Image)
    Private kaartenlijst As New List(Of PictureBox)
    Private gekliktekaartenlijst As New List(Of PictureBox)
    Private x As New Random()


    Private Sub MemorySpel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        KaartenLeggen()
        Importafbeeldingen()
        ToewijzenAfbeeldingen()
        TimerTijd.Start()
        MoeilijkheidsLabel.Text = StartScherm.Moeilijkheid.Naam
    End Sub

    Public Sub KaartenLeggen()

        Dim kaartIndex As Integer = 0
        Do While kaartIndex <> StartScherm.Moeilijkheid.AantalKaarten

            Dim Kaart As New PictureBox

            With Kaart
                .Location = New Point(StartScherm.Moeilijkheid.Xcoordinaat, StartScherm.Moeilijkheid.Ycoordinaat)
                .Size = New Size(StartScherm.Moeilijkheid.AfbeeldingsgrootteX, StartScherm.Moeilijkheid.AfbeeldingsgrootteY)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BackgroundImage = My.Resources.TheLeprechaunsCard
                .BackgroundImageLayout = ImageLayout.Stretch
                .BackColor = Color.Transparent

            End With

            If StartScherm.Moeilijkheid.Xcoordinaat < StartScherm.Moeilijkheid.uitersteX Then
                StartScherm.Moeilijkheid.Xcoordinaat += StartScherm.Moeilijkheid.AfbeeldingsgrootteX + StartScherm.Moeilijkheid.ExtraTussenruimteX
            Else : StartScherm.Moeilijkheid.Ycoordinaat += StartScherm.Moeilijkheid.AfbeeldingsgrootteY + StartScherm.Moeilijkheid.ExtraTussenRuimteY
                StartScherm.Moeilijkheid.Xcoordinaat = StartScherm.Moeilijkheid.StartwaardeX
            End If

            AddHandler Kaart.MouseEnter, AddressOf KaartOnMouseEnterEventHandler
            AddHandler Kaart.MouseLeave, AddressOf KaartOnMouseLeaveEventHandler
            AddHandler Kaart.MouseClick, AddressOf KaartOnMouseClickEventHandler

            kaartIndex += 1
            kaarttaginex += 1
            Kaart.Tag = kaarttaginex
            kaartenlijst.Add(Kaart)
            Me.Controls.Add(Kaart)

        Loop
    End Sub

    Sub Importafbeeldingen()
        For i = 0 To StartScherm.Moeilijkheid.AantalKaarten / 2
            afbeeldingenlijst.Add(Image.FromFile(StartScherm.AfbeeldingenPad.Text & "\afb" & i & ".jpg"))
            afbeeldingenlijst(i).Tag = i
        Next
        For i = 0 To StartScherm.Moeilijkheid.AantalKaarten / 2
            afbeeldingenlijst2.Add(Image.FromFile(StartScherm.AfbeeldingenPad.Text & "\afb" & i & ".jpg"))
            afbeeldingenlijst2(i).Tag = i
        Next
    End Sub

    Private Sub ToewijzenAfbeeldingen()
        Dim clickindex As Integer = 0
        For Each PictureBox In kaartenlijst
            If clickindex Mod 2 = 0 Then
                Dim random As Integer = x.Next(1, afbeeldingenlijst.Count)
                PictureBox.BackgroundImage = afbeeldingenlijst(random)
                PictureBox.Image = My.Resources.TheLeprechaunsCard
                afbeeldingenlijst.RemoveAt(random)
                clickindex += 1

            Else : Dim random As Integer = x.Next(1, afbeeldingenlijst2.Count)
                PictureBox.BackgroundImage = afbeeldingenlijst2(random)
                PictureBox.Image = My.Resources.TheLeprechaunsCard
                afbeeldingenlijst2.RemoveAt(random)
                clickindex += 1
            End If
        Next
    End Sub

    'Alle EventHandlers:

    Private Sub KaartOnMouseClickEventHandler(sender As PictureBox, e As System.EventArgs)
        If gekliktekaartenlijst.Count = 0 Then
            If kaartenGeklikt < 2 Then
                kaartenGeklikt += 1
                gekliktekaartenlijst.Add(sender)
                sender.Image = sender.BackgroundImage
                sender.BackgroundImage = My.Resources.TheLeprechaunsCard
                If kaartenGeklikt = 2 Then
                    KaartenTimer.Start()
                End If
            End If
        ElseIf gekliktekaartenlijst.Count > 0 Then
            If gekliktekaartenlijst(0).Tag = sender.Tag Then

            Else : If kaartenGeklikt < 2 Then
                    kaartenGeklikt += 1
                    gekliktekaartenlijst.Add(sender)
                    sender.Image = sender.BackgroundImage
                    sender.BackgroundImage = My.Resources.TheLeprechaunsCard
                    If kaartenGeklikt = 2 Then
                        KaartenTimer.Start()
                    End If


                End If
        End If
        End If
    End Sub
    Private Sub KaartOnMouseEnterEventHandler(sender As PictureBox, e As System.EventArgs)
        'Voorlopig nog niets
    End Sub
    Private Sub KaartOnMouseLeaveEventHandler(sender As PictureBox, e As System.EventArgs)
        'Voorlopig nog niets
    End Sub
    Private Sub ButtonExit_MouseEnter(sender As System.Object, e As System.EventArgs) Handles ButtonExit.MouseEnter
        ButtonExitSelected.Visible = True
        ButtonExit.Visible = False
    End Sub
    Private Sub ButtonExitSelected_MouseLeave(sender As System.Object, e As System.EventArgs) Handles ButtonExitSelected.MouseLeave
        ButtonExit.Visible = True
        ButtonExitSelected.Visible = False

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
        HighScores.Show()

    End Sub
    Private Sub KaartenTimer_Tick(sender As System.Object, e As System.EventArgs) Handles KaartenTimer.Tick
        If aantalkaarten = 0 Then
            KaartenTimer.Stop()
            For Each PictureBox In kaartenlijst
                Me.Controls.Remove(PictureBox)
            Next
            TimerTijd.Stop()
            MsgBox("You won!")


        End If
        kaartenTimerIndex += 1
        If gekliktekaartenlijst(0).Image.Tag = gekliktekaartenlijst(1).Image.Tag Then


            If scoreindex <> 0 Then
                ScoreLabel.Text += scoreindex
                aantalkaarten -= 2
                scoreindex = scoreindex - 10

            End If
            Me.Controls.Remove(gekliktekaartenlijst(1))
            Me.Controls.Remove(gekliktekaartenlijst(0))
        Else : If foutindex <> 0 Then
                FoutenLabel.Text += foutindex
                foutindex = foutindex - 1
            End If
        End If

        If kaartenTimerIndex = 1 Then
            For Each PictureBox In gekliktekaartenlijst
                PictureBox.BackgroundImage = PictureBox.Image
                PictureBox.Image = My.Resources.TheLeprechaunsCard

            Next
            kaartenGeklikt = 0
            gekliktekaartenlijst.RemoveAt(1)
            gekliktekaartenlijst.RemoveAt(0)

            KaartenTimer.Stop()
            kaartenTimerIndex = 0
            scoreindex = 10
            foutindex = 1
        End If
    End Sub
    Private Sub ButtonExitSelected_MouseClick(sender As System.Object, e As System.EventArgs) Handles ButtonExitSelected.MouseClick
        Me.Close()
        BackgroundSong.Close()
        StartScherm.Close()
        Splashscreen.Close()
        LOL.Close()
    End Sub

    Private Sub TimerTijd_Tick(sender As System.Object, e As System.EventArgs) Handles TimerTijd.Tick
        tijdindex += 0.02
        TijdLabel.Text = Math.Round(tijdindex, 2)
    End Sub

    Private Sub LOLlbl_Click(sender As System.Object, e As System.EventArgs) Handles LOLlbl.Click
        LOL.Show()
        LOL.Focus()
        BackgroundSong.Close()
    End Sub
End Class