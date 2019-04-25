Public Class Login

    Dim attempts As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String
        username = txtUsername.Text
        password = txtPassword.Text
        attempts += 1

        If txtUsername.Text = "" Then
            MessageBox.Show("Please Enter Username")
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please Enter Password")
        End If

        If username = "R1711773" And password = "MALVERN" Then

            MessageBox.Show("LOGIN  SUCCESSFUL  ", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


        Else
            MessageBox.Show("Invalid Username Or Password, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("You have " & attempts & " out of 3 attempts", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If

        If attempts = 3 Then
            MessageBox.Show("Max attempts, I will now close", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("This program will now close, are you sure", "Close The Program?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class