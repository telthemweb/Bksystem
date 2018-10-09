Public Class Student_Registration
    Private Sub TimerCownd_Tick(sender As Object, e As EventArgs) Handles TimerCownd.Tick
        lblTime.Text = TimeOfDay
        TimerCownd.Enabled = True
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Hide()
        Main_Page.GroupLogs.Visible = True
    End Sub

    Private Sub GpMain_Enter(sender As Object, e As EventArgs) Handles GpMain.Enter

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear all textbox for new student to be added
        txtReg.Clear()
        txtFname.Clear()
        txtSurname.Clear()
        txtDOB.ResetText()
        cboGender.ResetText()
        cboClass.ResetText()
        cboTerm.ResetText()
        txtNational.Clear()
        txtAddress.Clear()
        txtFather.Clear()
        txtOcpy.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        If btnReg.Text = "Register" Then
            bookfindthis("SELECT COUNT(*) FROM `student_details` WHERE `regNumber`='" & txtReg.Text & "'")
            If GetCount() > 0 Then
                MsgBox("Reg Number already exist Please try something new!")
                lblError.Text = "No student has been added!"
                lblError.Visible = True
            Else
                If txtReg.Text = "" Then
                    MsgBox("Reg Number is Required!")
                ElseIf txtFname.Text = "" Then
                    MsgBox("Name is Required!")
                ElseIf txtSurname.Text = "" Then
                    MsgBox("Surname is Required!")
                ElseIf txtAddress.Text = "" Then
                    MsgBox("Address is Required!")
                ElseIf txtNational.Text = "" Then
                    MsgBox("Nationality is Required!")
                ElseIf txtFather.Text = "" Then
                    MsgBox("Father's name is Required!")
                ElseIf txtOcpy.Text = "" Then
                    MsgBox("Occupation is Required!")
                ElseIf txtDOB.Text = "" Then
                    MsgBox("Date of Birth is Required!")
                ElseIf txtPhone.Text = "" Then
                    MsgBox("Phone Number is Required!")
                ElseIf cboClass.Text = "" Then
                    MsgBox("Please select class!")
                ElseIf cboGender.Text = "" Then
                    MsgBox("Please select gender!")
                ElseIf cboTerm.Text = "" Then
                    MsgBox("Please select School Term!")
                Else
                    issucess = book_insert("INSERT INTO `student_details` (`regNumber`, `name`, `surname`,`dateOfBirth`, " &
                           " `gender`, `nationality`, `class`, `term`, `address`, `fatherName`, `occupation`, `phone`) " &
                           " VALUES ('" & txtReg.Text & "','" & txtFname.Text & "', '" & txtSurname.Text & "', '" & txtDOB.Text & "', '" & cboGender.Text & "', '" & txtNational.Text & "', " &
                           " '" & cboClass.Text & "', '" & cboTerm.Text & "', '" & txtAddress.Text & "', '" & txtFather.Text & "', '" & txtOcpy.Text & "', '" & txtPhone.Text & "');")

                    If issucess = True Then
                        MsgBox("New student has been added successfully!")
                        StudentsList.Show()
                        Me.Hide()


                    End If
                End If
            End If

        ElseIf btnReg.Text = "Update" Then
            If txtReg.Text = "" Then
                MsgBox("Reg Number is Required!")
            ElseIf txtFname.Text = "" Then
                MsgBox("Name is Required!")
            ElseIf txtSurname.Text = "" Then
                MsgBox("Surname is Required!")
            ElseIf txtAddress.Text = "" Then
                MsgBox("Address is Required!")
            ElseIf txtNational.Text = "" Then
                MsgBox("Nationality is Required!")
            ElseIf txtFather.Text = "" Then
                MsgBox("Father's name is Required!")
            ElseIf txtOcpy.Text = "" Then
                MsgBox("Occupation is Required!")
            ElseIf txtDOB.Text = "" Then
                MsgBox("Date of Birth is Required!")
            ElseIf txtPhone.Text = "" Then
                MsgBox("Phone Number is Required!")
            ElseIf cboClass.Text = "" Then
                MsgBox("Please select class!")
            ElseIf cboGender.Text = "" Then
                MsgBox("Please select gender!")
            ElseIf cboTerm.Text = "" Then
                MsgBox("Please select School Term!")

            Else
                issucess = book_insert("UPDATE `student_details` SET `name`='" & txtFname.Text & "',`surname`= '" & txtSurname.Text & "',`dateOfBirth`='" & txtDOB.Text & "',`gender`= '" & cboGender.Text & "',`nationality`=  '" & txtNational.Text & "'," &
                                       "`class`='" & cboClass.Text & "',`term`= '" & cboTerm.Text & "',`address`='" & txtAddress.Text & "',`fatherName`=  '" & txtFather.Text & "', `occupation`='" & txtOcpy.Text & "',`phone`='" & txtPhone.Text & "' WHERE `regNumber`='" & txtReg.Text & "'")

                If issucess = True Then
                    MsgBox("Student has been updated successfully!", MsgBoxStyle.Information)
                    StudentsList.Show()
                    Me.Hide()
                    txtReg.Clear()
                    txtFname.Clear()
                    txtSurname.Clear()
                    txtDOB.ResetText()
                    cboGender.ResetText()
                    cboClass.ResetText()
                    cboTerm.ResetText()
                    txtNational.Clear()
                    txtAddress.Clear()
                    txtFather.Clear()
                    txtOcpy.Clear()
                    txtPhone.Clear()
                Else
                    lblError.Text = "No student has been updated!"
                    lblError.Visible = True

                    txtReg.Clear()
                    txtFname.Clear()
                    txtSurname.Clear()
                    txtDOB.ResetText()
                    cboGender.ResetText()
                    cboClass.ResetText()
                    cboTerm.ResetText()
                    txtNational.Clear()
                    txtAddress.Clear()
                    txtFather.Clear()
                    txtOcpy.Clear()
                    txtPhone.Clear()
                End If
            End If

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class