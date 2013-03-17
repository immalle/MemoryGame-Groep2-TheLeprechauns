Public Class StartScherm



    Private Sub ButtonEasy_MouseEnter(sender As Object, e As System.EventArgs) Handles ButtonEasy.MouseEnter
        ButtonEasySelected.Visible = True
        ButtonEasy.Visible = False
    End Sub
    Private Sub ButtonEasySelected_MouseLeave(sender As Object, e As System.EventArgs) Handles ButtonEasySelected.MouseLeave
        ButtonEasy.Visible = True
        ButtonEasySelected.Visible = False
    End Sub
    Private Sub ButtonEasySelected_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ButtonEasySelected.MouseClick
        'Momenteel nog niets
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
        'Momenteel nog niets
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
        'Momenteel nog niets
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