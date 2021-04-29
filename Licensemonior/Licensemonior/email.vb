Imports System.Net.Mail
Public Class email
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Text = "Đang gửi mail ...."
        Dim MyMailMessage As New MailMessage()
        MyMailMessage.From = New MailAddress(TextBox1.Text.ToString)
        MyMailMessage.To.Add(TextBox3.Text.ToString)
        MyMailMessage.Subject = TextBox2.Text.ToString
        MyMailMessage.Body = RichTextBox1.Text.ToString
        Dim SMTPServer As New SmtpClient(TextBox4.Text.ToString.Trim)
        SMTPServer.Port = TextBox5.Text
        SMTPServer.Credentials = New System.Net.NetworkCredential(TextBox6.Text.ToString.Trim, TextBox7.Text.ToString.Trim)
        SMTPServer.EnableSsl = True
        Try
            SMTPServer.Send(MyMailMessage)
            MessageBox.Show("Chờ tin và kiểm tra hộp thư đến nhé " & TextBox3.Text)
            Me.Cursor = Cursors.Arrow
            Me.Text = "Đã gửi xong"
        Catch ex As SmtpException
            MessageBox.Show(ex.Message)
            Me.Cursor = Cursors.Arrow
            Me.Text = "Không gửi được mail"
        End Try
        Me.Close()
    End Sub
End Class