Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '1
        'Palindromissa kirjaimet ovat samat alusta loppuun ja lopusta alkuun.
        'Välilyönteihin ei oteta kantaa, eli ne voivat olla missä tahansa ja silti kyse on palindromista.
        'Tee ohjelma, joka tutkii, onko annettu teksti palindromi.
        'Toteuta palindromia tutkiva algoritmi funktiossa.
        'Funktio palauttaa pelkästään tiedon siitä, oliko annettu teksti palindromi vai ei.
        'zippaa ja mailaa palautus 5.9.2022 oli valmis tai ei

        'Valmismuuttujalla
        '     If TextBox3.Text = StrReverse(TextBox3.Text) Then

        'MsgBox("Tämä oli palindromi")

        ' Else
        '  MsgBox("Tämä ei ollut palindromi")
        ' End If

        TextBox3.Text = jotain(TextBox3.Text)

    End Sub
    Function jotain(input)

        Dim testWord As String
        Dim takaper As String
        Dim i As Integer
        Dim max As Integer

        testWord = input
        'Poistetaan isot kirjaimet ja välit
        '   max = Len(input) - 1
        '  For i = 0 To max
        '  testWord = Mid(input, i, 1)
        '  If testWord <> " " Then
        '           testWord = input & LCase(testWord)
        '   End If
        '   Next


        'takapaerin 
        max = Len(input)
        For i = max To 1 Step -1
            takaper = takaper & Mid(testWord, i, 1)
        Next

        'Verrataan
        If testWord = takaper Then
            MsgBox("Sana on palindrome")
        Else
            MsgBox("Ei ole palindrome")
        End If

    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '2
        'Tutki merkkijonofunktioita lisää.
        'Tutkimisen jälkeen tee ohjelma, joka pyytää käyttäjältä etu- ja sukunimeä yhteen tekstilaatikkoon.
        'Valitettavasti käyttäjä tekee virheen ja kirjoittaa jommankumman tai molemmat pienellä kirjaimella.
        'Ohjelman pitää korjata tilanne ja muuttaa alkukirjaimet isoiksi.
        'Käytä kahta tekstilaatikkoa, toisessa näkyy käyttäjän kirjoittama
        'ja toisessa ohjelman korjaama versio.

        TextBox2.Text = teksti(TextBox1.Text)
    End Sub
    Function teksti(Text1 As String) As String
        Dim i As Long, iso As Boolean

        teksti = LCase(Text1)
        For i = 1 To Len(teksti)
            Select Case Mid$(teksti, i, 1)
                Case "a" To "z"
                    If Not iso Then
                        Mid$(teksti, i, 1) = UCase(Mid$(teksti, i, 1))
                        iso = True
                    End If
                Case Else
                    iso = False
            End Select
        Next

        'Bug: miksi osa tupla SS kirjaimista tulee isolla?

    End Function
End Class
