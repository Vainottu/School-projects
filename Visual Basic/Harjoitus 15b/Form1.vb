Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim kirjoittaja As System.IO.StreamWriter
        Dim teksti As String

        teksti = TextBox1.Text

        kirjoittaja = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\jalop\Desktop\test\teksti.txt", False)
        kirjoittaja.WriteLine(teksti)
        kirjoittaja.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim lukija As System.IO.StreamReader
        Dim teksti As String

        lukija = My.Computer.FileSystem.OpenTextFileReader("C:\Users\jalop\Desktop\test\teksti.txt")

        teksti = lukija.ReadLine()
        lukija.Close()

        MsgBox("Kirjoitit tiedostoon: " & teksti)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim lisateksti As String
        lisateksti = TextBox2.Text
        Dim lukija As System.IO.StreamWriter


        lukija = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\jalop\Desktop\test\teksti.txt", True)
        lukija.WriteLine(lisateksti)
        lukija.Close()

    End Sub
End Class
