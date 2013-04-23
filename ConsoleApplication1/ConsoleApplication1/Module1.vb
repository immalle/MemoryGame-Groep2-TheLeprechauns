Module Module1
    Structure Vaccinatie
        Dim datum As DateTime
        Dim naam As String
    End Structure

    Property Vaccinaties As List(Of Vaccinatie)

    Class Dier
        Property Naam As String

        Overridable Sub MaakGeluid()
            Console.WriteLine("<STILTE>")
        End Sub
    End Class

    Class Hond
        Inherits Dier

        Overrides Sub MaakGeluid()
            Console.WriteLine("Waf")
        End Sub
    End Class



    Class Kat
        Inherits Dier
        Overrides Sub MaakGeluid()
            Console.WriteLine("Miauw")
        End Sub
    End Class


    Class Olifant
        Inherits Dier
        Overrides Sub MaakGeluid()
            Console.WriteLine("Toet")
        End Sub
    End Class

    Sub TestPolymorfisme(d As Dier)
        Console.WriteLine(d.Naam)
        d.MaakGeluid()
    End Sub

    Sub DierToonVaccinaties()

    End Sub

    Sub Main()
        Dim kat1 As New Kat
        Dim hond1 As New Hond
        Dim olifant1 As New Olifant
        Dim olifant2 As New Olifant
        hond1.Naam = "Jef"
        olifant1.Naam = "Davy"
        kat1.MaakGeluid()
        hond1.MaakGeluid()
        olifant1.MaakGeluid()
        olifant2.MaakGeluid()

        TestPolymorfisme(hond1)

        TestPolymorfisme(olifant1)
    End Sub



End Module
