Imports System.Net.Mail

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim servidorsmtp As New SmtpClient()
            Dim email As New MailMessage()
            servidorsmtp.Credentials = New _
                Net.NetworkCredential("piscinasegura306@gmail.com", "ps123456")

            servidorsmtp.Port = 25
            servidorsmtp.Host = "smtp.gmail.com"
            servidorsmtp.EnableSsl = True

            email = New MailMessage
            email.From = New MailAddress("piscinasegura306@gmail.com")
            email.To.Add("daniellelima@gea.inatel.br")
            email.Subject = "Piscina Segura"
            email.Body = "Sua piscina foi invadida!"
            servidorsmtp.Send(email)
            MsgBox("Email Enviado!")
        Catch ex As Exception
            MsgBox("ERRO!")
        End Try

    End Sub
End Class
