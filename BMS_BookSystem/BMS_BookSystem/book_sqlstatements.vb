'Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Module book_sqlstatements
    Public Sub bookfindthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub LoadSingleResult(ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "student"
                    Do While dReader.Read = True
                        With Student_Registration
                            .txtReg.Text = dReader("regNumber")
                            .txtReg.Enabled = False
                            .txtFname.Text = dReader("name")
                            .txtSurname.Text = dReader("surname")
                            .txtDOB.Text = dReader("dateOfBirth")
                            .cboGender.Text = dReader("gender")
                            .txtNational.Text = dReader("nationality")
                            .cboClass.Text = dReader("class")
                            .cboTerm.Text = dReader("term")
                            .txtAddress.Text = dReader("address")
                            .txtFather.Text = dReader("fatherName")
                            .txtOcpy.Text = dReader("occupation")
                            .txtPhone.Text = dReader("phone")
                            .lblbanner.Text = "Update Student Details"
                            .Show()
                            .btnReg.Enabled = True
                            .btnReg.Text = "Update"
                            .btnExit.Text = "Delete student"
                            .btnExit.Visible = True

                        End With
                    Loop
                Case "login"
                    Do While dReader.Read = True

                        ACCOUNT_NAME = dReader("name") & " " & dReader("surname")
                        ACCOUNT_USERNAME = dReader("username")
                        ACCOUNT_TYPE = dReader("userType")
                        Main_Page.Show()
                        Main_Page.btnLogout.Text = ACCOUNT_NAME
                        Main_Page.lblAvtar.Text = ACCOUNT_TYPE
                        Login.Hide()
                    Loop
                Case "BookAddition"


                    Do While dReader.Read = True
                        With Book_details_Entry
                            .txtssn.Text = dReader("acconmber")
                            .txtssn.Enabled = False
                            .txtAuthor.Text = dReader("author")
                            .txtbkT.Text = dReader("title")
                            .txtPubl.Text = dReader("publication")
                            .txtEdit.Text = dReader("edition")
                            .txtCopies.Text = dReader("numberofCopies")
                            .txtVolume.Text = dReader("volume")
                            .txtDOB.Text = dReader("date_purchased")
                            .txtPurch.Text = dReader("price")
                            .Show()
                            .btnReg.Enabled = True
                            .btnReg.Text = "Update Book"
                            .lblSubject.Text = "Update  Book"
                            .btnDel.Visible = True
                            .btnExt.Visible = True
                        End With
                    Loop

                Case "IssueBook"

                    Do While dReader.Read = True
                        With BorrowingBook
                            .txtssn.Text = dReader("ssnb")
                            .txtAuthor.Text = dReader("author")
                            .txtbkT.Text = dReader("title")
                            .txtReg.Text = dReader("regNumber")
                            .txtFullN.Text = dReader("name") & " " & dReader("surname")
                            .txtAddress.Text = dReader("address")
                            .cboClass.Text = dReader("class")
                            .cboGender.Text = dReader("gender")
                            .Show()
                            .btnReg.Enabled = True
                            .btnReg.Text = "Return  Book"
                            .lblbanner.Text = "Return  Book"
                        End With
                    Loop

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub


End Module

