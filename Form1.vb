Public Class Form1

    ' Login button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = Username_entry.Text
        Dim password As String = Password_entry.Text

        If username = "chelsea" AndAlso password = "1234321" Then
            MessageBox.Show("Login successful! Proceeding to the main ticketing screen...")

            ' Show Form2 (main ticketing screen)
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials. Please try again.")
        End If
    End Sub

    ' Clear button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Username_entry.Text = String.Empty
        Password_entry.Text = String.Empty
    End Sub

    ' Exit button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    ' Username field behavior
    Private Sub Username_entry_Enter(sender As Object, e As EventArgs) Handles Username_entry.Enter
        If Username_entry.Text = "Username" Then
            Username_entry.Text = ""
            Username_entry.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Username_entry_Leave(sender As Object, e As EventArgs) Handles Username_entry.Leave
        If String.IsNullOrWhiteSpace(Username_entry.Text) Then
            Username_entry.Text = "Username"
            Username_entry.ForeColor = Color.Gray
        End If
    End Sub

    ' Password field behavior
    Private Sub Password_entry_Enter(sender As Object, e As EventArgs) Handles Password_entry.Enter
        If Password_entry.Text = "Password" Then
            Password_entry.Text = ""
            Password_entry.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Password_entry_Leave(sender As Object, e As EventArgs) Handles Password_entry.Leave
        If String.IsNullOrWhiteSpace(Password_entry.Text) Then
            Password_entry.Text = "Password"
            Password_entry.ForeColor = Color.Gray
        End If
    End Sub

End Class
