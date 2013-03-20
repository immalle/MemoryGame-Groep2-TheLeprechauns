Public Class MemorySpel
    Private KaartIndex As Integer = 0
    Private afbeeldingenlijst As New List(Of Image)
    Private Afbeeldingenlijst2 As New List(Of Image)
    Private PicboxTaglijst As New List(Of Integer)
    Private clickindex As Integer = 0
    Private x As New Random
    Private randommax As Integer = 8
    Private randommax2 As Integer = 8
    Private tagindex1 As Integer = 100
    Private tagindex2 As Integer = 200


    Private Sub MemorySpel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        KaartenLeggen()
        Importafbeeldingen()
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

            PicboxTaglijst.Add(Kaart.Tag)

            Me.Controls.Add(Kaart)

        Loop
    End Sub

    Sub Importafbeeldingen()
        For i = 0 To StartScherm.Moeilijkheid.AantalKaarten / 2
            afbeeldingenlijst.Add(Image.FromFile("C:\Users\Yves\Documents\GitHub\MemoryGame-Groep2-TheLeprechauns\Rescources\Afbeeldingen\afb" & i & ".jpg"))
        Next
        For i = 0 To StartScherm.Moeilijkheid.AantalKaarten / 2
            Afbeeldingenlijst2.Add(Image.FromFile("C:\Users\Yves\Documents\GitHub\MemoryGame-Groep2-TheLeprechauns\Rescources\Afbeeldingen\afb" & i & ".jpg"))
        Next
    End Sub


    Private Sub LabelOnMouseClickEventHandler(sender As PictureBox, e As System.EventArgs)
        clickindex += 1


        If sender.Tag = 0 Then

            If clickindex Mod 2 = 0 Then
                Dim random As Integer = x.Next(1, afbeeldingenlijst.Count)
                sender.Image = afbeeldingenlijst(random)
                afbeeldingenlijst.RemoveAt(random)

                sender.Tag = tagindex1
                tagindex1 += 1



            Else
               


                Dim random2 As Integer = x.Next(1, Afbeeldingenlijst2.Count)
                    sender.Image = Afbeeldingenlijst2(random2)
                    Afbeeldingenlijst2.RemoveAt(random2)

                    sender.Tag = tagindex2
                    tagindex2 += 1
                End If




        Else : sender.Image = sender.BackgroundImage



        End If

    End Sub


    Private Sub LabelOnMouseEnterEventHandler(sender As PictureBox, e As System.EventArgs)

    End Sub
    Private Sub LabelOnMouseLeaveEventHandler(sender As PictureBox, e As System.EventArgs)
        sender.BackgroundImage = sender.Image
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