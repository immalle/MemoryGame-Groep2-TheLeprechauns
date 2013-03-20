Public Class MemorySpel
    Private KaartIndex As Integer = 0
    Private afbeeldingenlijst As New List(Of Image)
    Private Afbeeldingenlijst2 As New List(Of Image)
    Private PicboxTaglijst As New List(Of Integer)
    Private clickindex As Integer = 0
    Private x As New Random()
    Private kaartenlijst As New List(Of PictureBox)
    Private KaartenTimerIndex As Integer
    Private KaartenGeklikt As Integer = 0


    Private Sub MemorySpel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        KaartenLeggen()
        Importafbeeldingen()


        For Each PictureBox In kaartenlijst
            If clickindex Mod 2 = 0 Then
                Dim random As Integer = x.Next(1, afbeeldingenlijst.Count)
                PictureBox.BackgroundImage = afbeeldingenlijst(random)
                PictureBox.Image = My.Resources.TheLeprechaunsCard
                afbeeldingenlijst.RemoveAt(random)
                clickindex += 1

            Else : Dim random As Integer = x.Next(1, Afbeeldingenlijst2.Count)
                PictureBox.BackgroundImage = Afbeeldingenlijst2(random)
                PictureBox.Image = My.Resources.TheLeprechaunsCard
                Afbeeldingenlijst2.RemoveAt(random)
                clickindex += 1

            End If
        Next


    End Sub


    Public Sub KaartenLeggen()
        Do While KaartIndex <> StartScherm.Moeilijkheid.AantalKaarten
            Dim Kaart As New PictureBox

            With Kaart
                .Location = New Point(StartScherm.Moeilijkheid.Xcoordinaat, StartScherm.Moeilijkheid.Ycoordinaat)
                .Size = New Size(StartScherm.Moeilijkheid.AfbeeldingsgrootteX, StartScherm.Moeilijkheid.AfbeeldingsgrootteY)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BackgroundImage = My.Resources.TheLeprechaunsCard
                .BackgroundImageLayout = ImageLayout.Stretch
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
            AddHandler Kaart.MouseClick, AddressOf LabelOnMouseClickEventHandler
            KaartIndex += 1
            Kaart.Tag = 0
            kaartenlijst.Add(Kaart)
            PicboxTaglijst.Add(Kaart.Tag)

            Me.Controls.Add(Kaart)

        Loop
    End Sub

    Sub Importafbeeldingen()
        For i = 0 To StartScherm.Moeilijkheid.AantalKaarten / 2
            afbeeldingenlijst.Add(Image.FromFile("D:\5I\Yves_Bos\SoftOntwikkeling\MemoryGame-Groep2-TheLeprechauns\Rescources\Afbeeldingen\afb" & i & ".jpg"))
        Next
        For i = 0 To StartScherm.Moeilijkheid.AantalKaarten / 2
            Afbeeldingenlijst2.Add(Image.FromFile("D:\5I\Yves_Bos\SoftOntwikkeling\MemoryGame-Groep2-TheLeprechauns\Rescources\Afbeeldingen\afb" & i & ".jpg"))

        Next
    End Sub


    Private Sub LabelOnMouseClickEventHandler(sender As PictureBox, e As System.EventArgs)
        If KaartenGeklikt < 2 Then
            KaartenTimer.Start()
            KaartenGeklikt += 1
            sender.Image = sender.BackgroundImage
            sender.BackgroundImage = My.Resources.TheLeprechaunsCard
        End If




    End Sub


    Private Sub LabelOnMouseEnterEventHandler(sender As PictureBox, e As System.EventArgs)

    End Sub
    Private Sub LabelOnMouseLeaveEventHandler(sender As PictureBox, e As System.EventArgs)

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

    Private Sub KaartenTimer_Tick(sender As System.Object, e As System.EventArgs) Handles KaartenTimer.Tick
        If KaartenGeklikt = 2 Then
            KaartenTimerIndex += 1
            If KaartenGeklikt = 3 Then
                KaartenGeklikt = 0
            End If
        End If
    End Sub
End Class