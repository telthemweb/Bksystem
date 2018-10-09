Public Class frmSplash
    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashTimer.Enabled = True
        pillar.Visible = True
        lblWait.Visible = True
    End Sub

    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        pillar.Increment(+1)
        If pillar.Value = 100 Then
            splashTimer.Stop()
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class
