Imports System.Net.Mail
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SendButtonClick(sender As Object, e As EventArgs) Handles SendButton.Click

        OutlookMailer()

    End Sub

    Private Function OutlookMailer() As Boolean
        Try
            Dim email As New MailMessage
            email.To.Add(ReceiveBox.Text)
            email.From = New MailAddress(SenderBox.Text)
            email.Subject = SubjectBox.Text
            email.IsBodyHtml = True
            email.Body = BodyBox.Text

            ' 587 is the default port for Outlook and many other email systems.

            Dim client As New System.Net.Mail.SmtpClient(HostBox.Text, 587)
            email.Priority = MailPriority.Normal
            client.EnableSsl = True
            client.UseDefaultCredentials = False
            Dim cred As New System.Net.NetworkCredential(SenderBox.Text, PassBox.Text)
            client.Credentials = cred
            client.DeliveryMethod = SmtpDeliveryMethod.Network
            client.SendAsync(email, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub BodyBox_TextChanged(sender As Object, e As EventArgs) Handles BodyBox.TextChanged

    End Sub
End Class
