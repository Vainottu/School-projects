Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Tee ohjelma joka kääntää merkkijonon merkit päinvastaiseen järjestykseen seuraavasti:
        'tietokone > teitoenok
        'vastaavasti: tuomas > outsam
        'Ohjelmassa pitää tutkia merkkijonon pituuden parillisuus/parittomuus ja sen perusteella
        'käsitellä merkkijonoa.  parittomassa tapauksessa keskimäisin merkki jää samaksi
        'apuna int functio, joka palauttaa parametrina saamansa luvun kokonaisosat.
        'esim int(2.5) > funktio palauttaa arvon 2. vastaavasti
        'int(3) > funktio palauttaa arvon 3

        'parillisuuden/parittoman testaus: 
        'if luku - int(luku) = 0 then
        '"luku on parillinen"
        'else
        '"luku on pariton"

        Dim teksti, out, i As Integer
        Dim etuosa, takaosa As String
        Dim parillinen As Boolean

        teksti = Len(txtinput.Text)
        out = Len(txtinput.Text)

        etuosa = ""
        takaosa = ""

        If teksti - Int(teksti / 2) = 0 Then
            parillinen = True
        Else
            parillinen = False
        End If

        If parillinen = True Then
            For i = (teksti / 2) To 1 Step -1
                etuosa = etuosa + Mid(txtinput.Text, i, 1)
            Next i

            For i = teksti To (teksti / 2) Step -1
                takaosa = takaosa + Mid(txtinput.Text, i, 1)
            Next i
            txtoutput.Text = etuosa + takaosa
        End If

        If parillinen = False Then
            For i = Int(teksti / 2) To 1 Step -1
                etuosa = etuosa + Mid(txtinput.Text, i, 1)
            Next i

            For i = teksti To Int(teksti / 2) Step -1
                takaosa = takaosa + Mid(txtinput.Text, i, 1)
            Next i
            txtoutput.Text = etuosa + takaosa

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Tee 3 eri ohjelmaa, joissa pyörittelet merkkijonoja "sinne ja tänne" 
        'muuta annettua alkuperäistä merkkijonoa jonkin logiikan mukaan.
        'esim järjestyksen vaihto  että kaksitavuisessa sanassa tavut ovat väärässä järjestyksessä


        'TAKAPERIN
        Dim toinenteksti, teksti As String
        Dim pituus As String
        Dim i As Integer

        teksti = TextBox3.Text
        pituus = Len(TextBox3.Text)

        For i = pituus To 1 Step -1
            toinenteksti = toinenteksti + Mid(TextBox3.Text, i, 1)
        Next
        TextBox4.Text = toinenteksti
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Sana kopioidaan kahteen kertaan, ja kopioitu liitetään sanan eteen, takaperin.
        'Mitään järkeähän näissä ei ole. Myyntiin, tyhmiltä rahat pois
        Dim testisana As String
        Dim pituustest As String
        Dim i As Integer
        Dim eka, toka As String

        testisana = TextBox5.Text
        pituustest = Len(TextBox5.Text)

        For i = pituustest To 1 Step -1
            eka = eka + Mid(TextBox5.Text, i, 1)
        Next
        For i = 1 To pituustest Step 1
            toka = toka + Mid(TextBox5.Text, i, 1)
        Next
        TextBox6.Text = eka & toka

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Dim i As Integer
        Dim tayte, taytekaks, taytekolme As Boolean
        Dim pituus, sana, sanakaks As String


        If Ananas.Checked Then
            ListBox1.Items.Add("Ananas")
        Else
        End If
        If pepperoni.Checked Then
            ListBox1.Items.Add("Pepperoni")
        Else
        End If
        If käsikarva.Checked Then
            ListBox1.Items.Add("Lisämausteet")
        Else
        End If

        sana = omavalinta.Text
        sanakaks = omavalinta.Text
        pituus = 0
        pituus = pituus + Len(omavalinta.Text)

        For i = pituus To 1 Step -1
            sanakaks = sanakaks + Mid(omavalinta.Text, i, 1)
        Next
        ListBox1.Items.Add(sana)
        MsgBox("Lisäämäsi täyte oli: " & sana)
        MsgBox("Ees taas vaarilla oli saari: " & sanakaks)



    End Sub

End Class
