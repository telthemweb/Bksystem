Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If btnLogin.Text = "Click Here  to Login" Then
            btnLogin.Text = "Login"
            gLoginForm.Visible = True
            lblError.Visible = False
        End If
        If txtUser.Text = "" Then
            lblError.Text = "Username is required Please"
            lblError.Visible = True
        ElseIf txtPass.Text = "" Then
            lblError.Text = "Password is required Please"
            lblError.Visible = True

        Else
            sql = "SELECT * FROM `useraccount` WHERE `username`='" & txtUser.Text & "' AND `password`='" & txtPass.Text & "' "
            bookfindthis(sql)

            If GetNumRows() = 1 Then
                MsgBox("Logged in Successfully", MsgBoxStyle.Information)
                LoadSingleResult("login")
                txtPass.Text = ""
                txtUser.Text = ""

            Else
                lblError.Text = "Username or Passwrord is not correct, Please try again!!"
                lblError.Visible = True
                txtPass.Text = ""
                txtUser.Text = ""

            End If
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gLoginForm.Visible = False
        btnLogin.Text = "Click Here  to Login"
    End Sub
End Class