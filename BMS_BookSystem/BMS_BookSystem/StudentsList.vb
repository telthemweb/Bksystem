Public Class StudentsList

    Private Sub StudentsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookfindthis("SELECT COUNT(*) FROM `student_details` ORDER BY `regNumber`")
        Dim kl = GetCount()
        lblNst.Text = kl

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Student_Registration.Show()
        Me.Hide()
    End Sub
    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

        statusAdmin.Text = Main_Page.btnLogout.Text
    End Sub


    Private Sub studentGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentGrid.CellClick
        bookfindthis("SELECT * FROM `student_details` WHERE `regNumber`='" & studentGrid.CurrentRow.Cells(0).Value & "'")
        LoadSingleResult("student")
    End Sub

    Private Sub StudentsList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bookfindthis("SELECT `regNumber`, `name`,`surname`,`dateOfBirth`, `gender`, `nationality`, `class`, `term`, `address`, `fatherName`,`occupation`,`phone`,`date_registered` FROM `student_details`")
        LoadData(studentGrid, "studentList")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try

            bookfindthis("SELECT * FROM `student_details` WHERE `regNumber`='" & txtSearch.Text & "' Or `name`='" & txtSearch.Text & "' Or `surname`='" & txtSearch.Text & "'")
            LoadData(studentGrid, "studentList")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
End Class