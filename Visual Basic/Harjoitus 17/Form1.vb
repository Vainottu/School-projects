Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Movetostart()
    End Sub
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        'Koordinaatit
        Label1.Text = e.X
        Label2.Text = e.Y
    End Sub
    '  Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
    'Static mouseposX As Single, mouseposY As Single

    'Hiiri siirtäää laatikkon

    ' If e.Button = 0 Then
    '        mouseposX = e.X
    '         mouseposY = e.Y
    'Else
    '       PictureBox1.Left = PictureBox1.Left + (e.X - mouseposX)
    '       PictureBox1.Top = PictureBox1.Top + (e.Y - mouseposY)
    '   End If


    '    End Sub
    Private Sub PictureBox6_mouseenter(sender As Object, e As EventArgs) Handles Maali.MouseEnter
        'Kun pääsee maaliin

        If PictureBox1.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            Playsound()
            MsgBox("Voitit pelin")
            Label20.Text = Label20.Text + 1

            Movetostart()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'säännöt nappi
        MsgBox("Pelin idea on simppeli. Vie hiiri perille saakka. Montako pistettä sinä saat kerättyä")
    End Sub

    Private Sub Wall(sender As Object, e As EventArgs) Handles Label4.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter
        'seinät(labelit) johon törmätään
        Label20.Text = 0
        Form2.Show()
    End Sub
    Private Sub Movetostart()
        'lähtöpiste määrittely
        Dim start = PictureBox1.Location()
        start.Offset(10, 10)
        Cursor.Position = PointToScreen(start)
    End Sub
    'Jekkujekku
    Sub Playsound()
        My.Computer.Audio.Play("sound1.wav")
    End Sub

End Class
