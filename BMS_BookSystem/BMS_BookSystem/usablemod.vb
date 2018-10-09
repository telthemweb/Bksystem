Module usablemod

    Public Sub LoadData(ByVal obj As Object, ByVal param As String)
        Try

            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "studentList"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7), dReader(8), dReader(9), dReader(10), dReader(11), dReader(12))
                    Loop

                Case "bookList"


                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6))
                    Loop

                Case "books"


                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6))
                    Loop



                Case "issued"

                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7), dReader(8), dReader(9), dReader(10))
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub fillTable(ByVal dtgrd As Object, ByVal design As String)
        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            dtgrd.DataSource = publictable

            Select Case design


                Case "defaults"
                    dtgrd.Columns(0).Visible = False
                    dtgrd.Columns(1).Visible = False
                    dtgrd.Columns(2).Visible = False


            End Select

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

End Module
