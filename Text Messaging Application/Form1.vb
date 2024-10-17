Public Class TextMessageApplication
    Private Sub TextMessageApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Lbldear.Text = "Dear " & txtrcv.Text & ","
        lblfrom.Text = txtsender.Text
        lblmsg.Text = txtmsg.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblmsg.Font = New Font(lblmsg.Font, FontStyle.Bold)
        Lbldear.Font = New Font(Lbldear.Font, FontStyle.Bold)
        lblfrom.Font = New Font(lblfrom.Font, FontStyle.Bold)
        lblsinc.Font = New Font(lblsinc.Font, FontStyle.Bold)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblmsg.Font = New Font(lblmsg.Font, FontStyle.Italic)
        Lbldear.Font = New Font(Lbldear.Font, FontStyle.Italic)
        lblfrom.Font = New Font(lblfrom.Font, FontStyle.Italic)
        lblsinc.Font = New Font(lblsinc.Font, FontStyle.Italic)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblmsg.Font = New Font(lblmsg.Font, FontStyle.Underline)
        Lbldear.Font = New Font(Lbldear.Font, FontStyle.Underline)
        lblfrom.Font = New Font(lblfrom.Font, FontStyle.Underline)
        lblsinc.Font = New Font(lblsinc.Font, FontStyle.Underline)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblmsg.Font = New Font(lblmsg.Font, FontStyle.Strikeout)
        Lbldear.Font = New Font(Lbldear.Font, FontStyle.Strikeout)
        lblfrom.Font = New Font(lblfrom.Font, FontStyle.Strikeout)
        lblsinc.Font = New Font(lblsinc.Font, FontStyle.Strikeout)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lblmsg.TextAlign = ContentAlignment.TopLeft
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lblmsg.TextAlign = ContentAlignment.TopRight
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lblmsg.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Lbldear.ForeColor = Color.Red
        lblmsg.ForeColor = Color.Red
        lblsinc.ForeColor = Color.Red
        lblfrom.ForeColor = Color.Red
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Lbldear.ForeColor = Color.Yellow
        lblmsg.ForeColor = Color.Yellow
        lblsinc.ForeColor = Color.Yellow
        lblfrom.ForeColor = Color.Yellow
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Lbldear.ForeColor = Color.Blue
        lblmsg.ForeColor = Color.Blue
        lblsinc.ForeColor = Color.Blue
        lblfrom.ForeColor = Color.Blue
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Lbldear.ForeColor = Color.Green
        lblmsg.ForeColor = Color.Green
        lblsinc.ForeColor = Color.Green
        lblfrom.ForeColor = Color.Green
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Lbldear.BackColor = Color.Red
        lblmsg.BackColor = Color.Red
        lblsinc.BackColor = Color.Red
        lblfrom.BackColor = Color.Red
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Lbldear.BackColor = Color.Yellow
        lblmsg.BackColor = Color.Yellow
        lblsinc.BackColor = Color.Yellow
        lblfrom.BackColor = Color.Yellow
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Lbldear.BackColor = Color.Blue
        lblmsg.BackColor = Color.Blue
        lblsinc.BackColor = Color.Blue
        lblfrom.BackColor = Color.Blue

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Lbldear.BackColor = Color.Green
        lblmsg.BackColor = Color.Green
        lblsinc.BackColor = Color.Green
        lblfrom.BackColor = Color.Green
    End Sub
End Class
