Public Class IssuedBooks

    Private Sub IssuedBooks_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bookfindthis("SELECT `id` ,`fullName`,`class`,`address`, `ssnb`, `title`, `date_borrowed`, `date_returned`, `numOfDays`, `status`,`processed_by` FROM `borrowed`")
        LoadData(issuedGrid, "issued")
    End Sub

    Private Sub issuedGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles issuedGrid.CellClick
        bookfindthis("SELECT * FROM `borrowed` WHERE `id`='" & issuedGrid.CurrentRow.Cells(0).Value & "'")
        LoadSingleResult("IssueBook")
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        BorrowingBook.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Return_book.Show()
        Me.Hide()
    End Sub

    Private Sub IssuedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class