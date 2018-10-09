Public Class Return_book
    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Dim BookTitle = IssuedBooks.issuedGrid.CurrentRow.Cells(5).Value
        penalty.book_title = BookTitle
        penalty.student_name = IssuedBooks.issuedGrid.CurrentRow.Cells(1).Value

        Dim OverLappedRentDays As Integer = 0
        Dim RentExpiration As Date = CDate(IssuedBooks.issuedGrid.CurrentRow.Cells(7).Value)
        Dim OverLappedPenalty As Integer = 100
        Dim TotalOverLappedPenalty As Integer = 0

        OverLappedRentDays = Date.Now.Day - RentExpiration.Day
        TotalOverLappedPenalty = OverLappedRentDays * OverLappedPenalty
        If OverLappedRentDays > 0 Then
            MessageBox.Show(BookTitle & " has exceeded " & OverLappedRentDays & " days." & vbNewLine &
                "As a result there is a penalty every day that it exceeds from the book expiration date.", "Kotwa High School Library", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

        End If
        issucess = book_insert("UPDATE `borrowed` SET `regNumber`='" & txtReg.Text & "',`fullName`= '" & txtFullN.Text & "',`gender`='" & cboGender.Text & "',`class`= '" & cboClass.Text & "',`address`=  '" & txtAddress.Text & "'," &
                                      "`ssnb`='" & txtssn.Text & "',`author`= '" & txtAuthor.Text & "',`date_returned`='" & dptReturned.Text & "', status='returned' WHERE `ssnb`='" & txtssn.Text & "'")
        If issucess = True Then
            MsgBox("Book has been returned!", MsgBoxStyle.Information)
            book_insert("UPDATE bookdetails SET status= 'Available' WHERE acconmber='" & txtssn.Text & "'")
            book_delete("DELETE From borrowed  Where ssnb='" & txtssn.Text & "'")

        End If
    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            bookfindthis("SELECT * FROM `borrowed` WHERE `ssnb`='" & txtSearch.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtssn.Text = dReader("ssnb")
                txtAuthor.Text = dReader("author")
                txtbkT.Text = dReader("title")
                dtpBorrowed.Text = dReader("date_borrowed")
                lblstatus.Text = dReader("status")
                dptReturned.Text = dReader("date_returned")
                txtReg.Text = dReader("regNumber")
                txtFullN.Text = dReader("fullName")
                txtAddress.Text = dReader("address")
                cboClass.Text = dReader("class")
                cboGender.Text = dReader("gender")
                lblstatus.Visible = True
                txtSearch.Text = ""
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class