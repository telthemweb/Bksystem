Public Class BookList
    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statusAdmin.Text = Main_Page.btnLogout.Text
    End Sub

    Private Sub GridBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridBooks.CellClick
        bookfindthis("SELECT * FROM `bookdetails` WHERE `acconmber`='" & GridBooks.CurrentRow.Cells(0).Value & "'")
        LoadSingleResult("BookAddition")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Book_details_Entry.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try

            bookfindthis("SELECT * FROM `bookdetails` WHERE `acconmber`='" & txtSearch.Text & "' Or `title`='" & txtSearch.Text & "' Or `author`='" & txtSearch.Text & "'")
            LoadData(GridBooks, "bookList")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub BookList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bookfindthis("SELECT `acconmber`, `author`,`title`,`publication`, `edition`, `date_purchased`, `price` FROM `bookdetails`")
        LoadData(GridBooks, "bookList")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AvailableBooks.Show()
        Me.Hide()
    End Sub
End Class