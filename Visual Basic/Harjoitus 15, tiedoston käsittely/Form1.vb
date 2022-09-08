Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Tiedostojen käsittely(tekstitiedosto)

        'määrittely:
        'Dim kirjoittaja as system.io.streamwriter

        'kirjoittaminen

        'Kijroittaja = my.computer.filesystem.opentexfilewriter("yhteystiedot.txt, false)

        'Kirjoittamisen lopetus:
        'kirjoittaja.close()


        'Tarvitset käyttöliittymään 3 tekstikenttää, nimet näet ytllä', yhden painonapin. jonka nimi myös yllä.
        'Ohjelmalistaus kopioidaan painonapin click aliohjelmaan.


        'Määritellään tarvittavat muuttujat 

        Dim enimi, snimi, sposti As String

        'Määritellään I/O -muuttuja 

        Dim kirjoittaja As System.IO.StreamWriter

        'Luetan tekstikentistä arvot muuttujiin 

        enimi = TextBox1.Text

        snimi = TextBox2.Text

        sposti = TextBox3.Text


        'Ohjelma avaa UUDEN tiedoston Yhteystiedot.txt 

        'Tiedostolle ei anneta polkua (path) -> Tiedosto tallentuu oletuskansioon 

        'Samalla tiedosto avataan 

        kirjoittaja = My.Computer.FileSystem.OpenTextFileWriter("Yhteystiedot.txt", False)

        'Kirjoitetaan käyttäjän antamat yhteystiedot 

        kirjoittaja.WriteLine(enimi)

        kirjoittaja.WriteLine(snimi)

        kirjoittaja.WriteLine(sposti)

        'Suljetaan tiedosto 

        kirjoittaja.Close()

        MsgBox("Ja seuraavaksi: etsi tiedosto!")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim rivi As String

        Dim lukija As System.IO.StreamReader

        MsgBox("Ohjelma olettaa, että Yhteystiedot.txt -niminen tiedosto löytyy oletuskansiosta")

        'Käynnistää lukija 

        lukija = My.Computer.FileSystem.OpenTextFileReader("Yhteystiedot.txt")

        'Luetaan tiedostoa rivi kerrallaan 

        Do While Not lukija.EndOfStream

            rivi = lukija.ReadLine()

            MsgBox(rivi)

        Loop

        'Suljetaan tiedosto 

        lukija.Close()


    End Sub
End Class
