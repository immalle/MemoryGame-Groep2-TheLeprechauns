Public Class StartScherm

    Public Structure MoeilijkheidStructure
        Public Naam As String
        Public AantalKaarten As Integer
        Public AfbeeldingsgrootteX As Integer
        Public AfbeeldingsgrootteY As Integer
        Public ExtraTussenruimteX As Integer
        Public ExtraTussenRuimteY As Integer
        Public StartwaardeX As Integer
        Public startwaardeY As Integer
        Public Xcoordinaat As Integer
        Public Ycoordinaat As Integer
        Public uitersteX As Integer
        Public uitersteY As Integer
    End Structure

    Public Moeilijkheid As MoeilijkheidStructure

    Private Sub ButtonEasy_MouseEnter(sender As Object, e As System.EventArgs) Handles ButtonEasy.MouseEnter
        ButtonEasySelected.Visible = True
        ButtonEasy.Visible = False
    End Sub
    Private Sub ButtonEasySelected_MouseLeave(sender As Object, e As System.EventArgs) Handles ButtonEasySelected.MouseLeave
        ButtonEasy.Visible = True
        ButtonEasySelected.Visible = False
    End Sub
    Private Sub ButtonEasySelected_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ButtonEasySelected.MouseClick

        Moeilijkheid.Naam = "Easy"
        Moeilijkheid.AantalKaarten = 15
        Moeilijkheid.AfbeeldingsgrootteX = 150
        Moeilijkheid.AfbeeldingsgrootteY = 200
        Moeilijkheid.ExtraTussenruimteX = 19
        Moeilijkheid.ExtraTussenRuimteY = 10
        Moeilijkheid.StartwaardeX = 250
        Moeilijkheid.startwaardeY = 110
        Moeilijkheid.Xcoordinaat = 250
        Moeilijkheid.Ycoordinaat = 110
        Moeilijkheid.uitersteX = 900
        Moeilijkheid.uitersteY = 640
        MemorySpel.Show()
        MemorySpel.Focus()
        Me.Hide()
    End Sub



    Private Sub ButtonMedium_MouseEnter(sender As Object, e As System.EventArgs) Handles ButtonMedium.MouseEnter
        ButtonMediumSelected.Visible = True
        ButtonMedium.Visible = False
    End Sub
    Private Sub ButtonMediumSelected_MouseLeave(sender As Object, e As System.EventArgs) Handles ButtonMediumSelected.MouseLeave
        ButtonMedium.Visible = True
        ButtonMediumSelected.Visible = False
    End Sub
    Private Sub ButtonMediumSelected_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ButtonMediumSelected.MouseClick

        Moeilijkheid.Naam = "Medium"

        Moeilijkheid.AantalKaarten = 32
        Moeilijkheid.AfbeeldingsgrootteX = 110
        Moeilijkheid.AfbeeldingsgrootteY = 160
        Moeilijkheid.ExtraTussenruimteX = 19
        Moeilijkheid.ExtraTussenRuimteY = 10
        Moeilijkheid.StartwaardeX = 150
        Moeilijkheid.startwaardeY = 80
        Moeilijkheid.Xcoordinaat = 150
        Moeilijkheid.Ycoordinaat = 80
        Moeilijkheid.uitersteX = 1000
        Moeilijkheid.uitersteY = 640

        MemorySpel.Show()
        MemorySpel.Focus()
        Me.Hide()

    End Sub



    Private Sub ButtonHard_MouseEnter(sender As Object, e As System.EventArgs) Handles ButtonHard.MouseEnter
        ButtonHardSelected.Visible = True
        ButtonHard.Visible = False
    End Sub
    Private Sub ButtonHardSelected_MouseLeave(sender As Object, e As System.EventArgs) Handles ButtonHardSelected.MouseLeave
        ButtonHard.Visible = True
        ButtonHardSelected.Visible = False
    End Sub
    Private Sub ButtonHardSelected_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ButtonHardSelected.MouseClick

        Moeilijkheid.Naam = "Hard"
        
        Moeilijkheid.AantalKaarten = 72
        Moeilijkheid.AfbeeldingsgrootteX = 75
        Moeilijkheid.AfbeeldingsgrootteY = 100
        Moeilijkheid.ExtraTussenruimteX = 19
        Moeilijkheid.ExtraTussenRuimteY = 10
        Moeilijkheid.StartwaardeX = 80
        Moeilijkheid.startwaardeY = 80
        Moeilijkheid.Xcoordinaat = 80
        Moeilijkheid.Ycoordinaat = 80
        Moeilijkheid.uitersteX = 1100
        Moeilijkheid.uitersteY = 640
        MemorySpel.Show()
        MemorySpel.Focus()
        Me.Hide()

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