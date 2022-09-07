Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Tee ohjelma, joka kysyy kääyttäjältä 3 lukua ja kaksi enmistäistä lasketaan yhteen ja niiden summasta vähennetään kolmas luku

        ' Määritellään tarvittavat muuttujat
        Dim luku1 As Integer
        Dim luku2 As Integer
        Dim luku3 As Integer
        Dim tulos As Integer


        'Pyydetään käyttäjältä ensimäinen luku
        luku1 = InputBox("Anna ensimäinen luku")
        luku2 = InputBox("Anna toinen luku")
        luku3 = InputBox("Anna kolmas luku")


        'Lasketaan tulos
        tulos = luku1 + luku2 - luku3

        'ver 2, Kerrotaan käyttäjälle yhteenlaskun tulos tekstillä
        MsgBox("Lukujen summa on " & tulos)

    End Sub


End Class
