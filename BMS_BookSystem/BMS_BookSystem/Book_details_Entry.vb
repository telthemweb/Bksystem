Public Class Book_details_Entry
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnEntry.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAuthor.Clear()
        txtbkT.Clear()
        txtCopies.Clear()
        txtEdit.Clear()
        txtPubl.Clear()
        txtPurch.ResetText()

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click




        If btnReg.Text = "Save Book" Then

            bookfindthis("SELECT COUNT(*) FROM `bookdetails` WHERE `acconmber`='" & txtssn.Text & "'")

            If GetCount() > 0 Then
                MsgBox("Please Book SSNB is already exist Please!")
                lblError.Text = "No New Book has been added!"
                lblError.Visible = True
            Else


                If txtssn.Text = "" Then
                    MsgBox("Reg Number is Required!", MsgBoxStyle.Critical)
                ElseIf txtAuthor.Text = "" Then
                    MsgBox("Auther is Required!", MsgBoxStyle.Critical)
                ElseIf txtbkT.Text = "" Then
                    MsgBox("Title is Required!", MsgBoxStyle.Critical)
                ElseIf txtPubl.Text = "" Then
                    MsgBox("Publication is Required!", MsgBoxStyle.Critical)
                ElseIf txtEdit.Text = "" Then
                    MsgBox("Edition is Required!", MsgBoxStyle.Critical)
                ElseIf txtCopies.Text = "" Then
                    MsgBox("Number of Copies is Required!", MsgBoxStyle.Critical)
                ElseIf txtVolume.Text = "" Then
                    MsgBox("Volume is Required!", MsgBoxStyle.Critical)
                ElseIf txtDOB.Text = "" Then
                    MsgBox("Date of Publication is Required!", MsgBoxStyle.Critical)
                ElseIf txtPurch.Text = "" Then
                    MsgBox("Price of book is Required!", MsgBoxStyle.Critical)


                Else
                    'cmd.Parameters.AddWithValue("@studimg", arrImage)
                    issucess = book_insert("INSERT INTO `bookdetails` (`acconmber`, `author`, `title`,`publication`, " &
                           " `edition`, `numberofCopies`, `volume`, `date_purchased`, `price`) " &
                           " VALUES ('" & txtssn.Text & "','" & txtAuthor.Text & "', '" & txtbkT.Text & "', '" & txtPubl.Text & "', '" & txtEdit.Text & "', '" & txtCopies.Text & "', " &
                           " '" & txtVolume.Text & "', '" & txtDOB.Text & "', '" & txtPurch.Text & "');")


                    If issucess = True Then
                        MsgBox("New Book has been added successfully!")
                        BookList.Show()
                        Me.Hide()


                    End If



                End If



            End If

        ElseIf btnReg.Text = "Update Book" Then

            If txtssn.Text = "" Then
                MsgBox("Reg Number is Required!", MsgBoxStyle.Critical)
            ElseIf txtAuthor.Text = "" Then
                MsgBox("Auther is Required!", MsgBoxStyle.Critical)
            ElseIf txtbkT.Text = "" Then
                MsgBox("Title is Required!", MsgBoxStyle.Critical)
            ElseIf txtPubl.Text = "" Then
                MsgBox("Publication is Required!", MsgBoxStyle.Critical)
            ElseIf txtEdit.Text = "" Then
                MsgBox("Edition is Required!", MsgBoxStyle.Critical)
            ElseIf txtCopies.Text = "" Then
                MsgBox("Number of Copies is Required!", MsgBoxStyle.Critical)
            ElseIf txtVolume.Text = "" Then
                MsgBox("Volume is Required!", MsgBoxStyle.Critical)
            ElseIf txtDOB.Text = "" Then
                MsgBox("Date of Publication is Required!", MsgBoxStyle.Critical)
            ElseIf txtPurch.Text = "" Then
                MsgBox("Price of book is Required!", MsgBoxStyle.Critical)
            Else
                issucess = book_insert("UPDATE `bookdetails` SET `author`='" & txtAuthor.Text & "',`title`= '" & txtbkT.Text & "',`publication`='" & txtPubl.Text & "',`edition`= '" & txtEdit.Text & "',`numberofCopies`=  '" & txtCopies.Text & "'," &
                                       "`volume`='" & txtVolume.Text & "',`date_purchased`= '" & txtDOB.Text & "',`price`='" & txtPurch.Text & "' WHERE `acconmber`='" & txtssn.Text & "'")

                If issucess = True Then
                    MsgBox("Book has been updated successfully!", MsgBoxStyle.Information)
                    BookList.Show()
                    Me.Hide()
                    txtAuthor.Clear()
                    txtbkT.Clear()
                    txtCopies.Clear()
                    txtEdit.Clear()
                    txtPubl.Clear()
                    txtPurch.ResetText()
                Else
                    lblError.Text = "No Book has been updated!"
                    lblError.Visible = True
                    txtAuthor.Clear()
                    txtbkT.Clear()
                    txtCopies.Clear()
                    txtEdit.Clear()
                    txtPubl.Clear()
                    txtPurch.ResetText()
                End If

            End If


        End If


    End Sub


    Private Sub Book_details_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEntry.Text = Main_Page.btnLogout.Text
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

    End Sub
End Class