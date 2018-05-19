Imports MySql.Data.MySqlClient

Module dbconnection
    Public conn As New MySqlConnection

    Public Sub connect(ByVal server As String, ByVal user As String, ByVal password As String, ByVal database As String)
        If conn.State = ConnectionState.Closed Then
            Dim connString As String = "server=" & server & ";user=" & user & ";password=" & password & ";database=" & database
            Try
                conn.ConnectionString = connString
                conn.Open()
            Catch ex As MySqlException
                MsgBox(ex.Message)
                End
            End Try
        End If
    End Sub

    Public Sub disconnect()
        Try
            conn.Close()
        Catch ex As MySqlException
        End Try
    End Sub
End Module
