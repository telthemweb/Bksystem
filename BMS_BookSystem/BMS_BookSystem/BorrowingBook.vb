Public Class BorrowingBook
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            bookfindthis("SELECT * FROM `bookdetails` WHERE `acconmber`='" & txtSearch.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtssn.Text = dReader("acconmber")
                txtAuthor.Text = dReader("author")
                txtbkT.Text = dReader("title")
                txtSearch.Text = ""
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim ts As TimeSpan = DateTimePicker1.Value.Date - DateTime.Today.Date
        Dim totals As Integer = ts.Days
        txtN.Text = totals.ToString()
        If Val(txtN.Text) < 0 Then
            txtN.Text = 0
        End If
        DateTimePicker2.Text = DateTimePicker1.Value.Date
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            bookfindthis("SELECT * FROM student_details WHERE regNumber = '" & txtSearch2.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtReg.Text = dReader("regNumber")
                txtFullN.Text = dReader("name") & " " & dReader("surname")
                txtAddress.Text = dReader("address")
                cboClass.Text = dReader("class")
                cboGender.Text = dReader("gender")
                txtSearch2.Text = ""

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub BorrowingBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLogout.Text = Main_Page.btnLogout.Text
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click

        'Save Borrower
        If btnReg.Text = "Save Borrower" Then
            sql = "SELECT * FROM `borrowed` WHERE `ssnb`='" & txtssn.Text & "' "
            bookfindthis(sql)

            If GetNumRows() = 1 Then
                MsgBox("This book has been borrowed ", MsgBoxStyle.Critical)
            Else

                issucess = book_insert("INSERT INTO `borrowed` (`regNumber`, `fullName`, `gender`, `class`,`address`, " &
                         " `ssnb`, `author`, `title`, `date_returned`,  `numOfDays`,  `processed_by`) " &
                         " VALUES ('" & txtReg.Text & "','" & txtFullN.Text & "','" & cboGender.Text & "', '" & cboClass.Text & "', '" & txtAddress.Text & "', '" & txtssn.Text & "', '" & txtAuthor.Text & "', " &
                         " '" & txtbkT.Text & "',  '" & DateTimePicker2.Text & "', '" & txtN.Text & "', '" & lblLogout.Text & "');")
                If issucess = True Then
                    MsgBox("You have Issued book to '" & txtFullN.Text & "'  successfully! Book will be return on  '" & DateTimePicker2.Text & "'", MsgBoxStyle.Information)
                    book_insert("UPDATE bookdetails SET status= 'Unvailable' WHERE acconmber='" & txtssn.Text & "'")
                Else
                    lblError.Text = "No Book has been issued to '" & txtFullN.Text & "'!"
                End If
            End If


        ElseIf btnReg.Text = "Return" Then
            issucess = book_insert("UPDATE `borrowed` SET `regNumber`='" & txtReg.Text & "',`fullName`= '" & txtFullN.Text & "',`gender`='" & cboGender.Text & "',`class`= '" & cboClass.Text & "',`address`=  '" & txtAddress.Text & "'," &
                                       "`ssnb`='" & txtssn.Text & "',`author`= '" & txtAuthor.Text & "',`date_borrowed`='" & DateTimePicker2.Text & "' ,`date_returned`='" & DateTimePicker2.Text & "',`numOfDays`='" & txtN.Text & "', status='returned' WHERE `ssnb`='" & txtssn.Text & "'")
            If issucess = True Then
                MsgBox("Book has been returned!", MsgBoxStyle.Information)

            End If
        End If


    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Me.Close()
    End Sub
End Class