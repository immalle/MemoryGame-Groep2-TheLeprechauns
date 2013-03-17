Public Class StartScherm

    Public Structure MoeilijkheidStructure
        Public Naam As String
        Public AfbeeldingenBreedte As Integer
        Public AfbeeldingenHoogte As Integer
        Public Afbeeldinggrootte As Size
    End Structure


    Private Sub ButtonEasy_MouseEnter(sender As Object, e As System.EventArgs) Handles ButtonEasy.MouseEnter
        ButtonEasySelected.Visible = True
        ButtonEasy.Visible = False
    End Sub
    Private Sub ButtonEasySelected_MouseLeave(sender As Object, e As System.EventArgs) Handles ButtonEasySelected.MouseLeave
        ButtonEasy.Visible = True
        ButtonEasySelected.Visible = False
    End Sub
    Private Sub ButtonEasySelected_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ButtonEasySelected.MouseClick
        Dim Moeilijkheid As MoeilijkheidStructure
        Moeilijkheid.Naam = "Easy"
        Moeilijkheid.AfbeeldingenHoogte = 4
        Moeilijkheid.AfbeeldingenBreedte = 4
        Moeilijkheid.Afbeeldinggrootte = New Size(50, 100)
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
        Dim Moeilijkheid As MoeilijkheidStructure
        Moeilijkheid.Naam = "Medium"
        Moeilijkheid.AfbeeldingenHoogte = 8
        Moeilijkheid.AfbeeldingenBreedte = 8
        Moeilijkheid.Afbeeldinggrootte = New Size(30, 60)
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
        Dim Moeilijkheid As MoeilijkheidStructure
        Moeilijkheid.Naam = "Hard"
        Moeilijkheid.AfbeeldingenHoogte = 14
        Moeilijkheid.AfbeeldingenBreedte = 14
        Moeilijkheid.Afbeeldinggrootte = New Size(25, 50)
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