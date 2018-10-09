Public Class AvailableBooks
    Private Sub AvailableBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookfindthis("SELECT COUNT(*) FROM `bookdetails`WHERE status= 'Available'")
        Dim book = GetCount()
        lblNst.Text = book

    End Sub

    Private Sub AvailableBooks_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bookfindthis("SELECT `acconmber`, `author`,`title`,`publication`, `price`, `edition`, `volume` FROM `bookdetails` WHERE status= 'Available'")
        LoadData(AvailableBook, "books")

    End Sub
End Class