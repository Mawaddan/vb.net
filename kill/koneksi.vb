Imports System.Data.SqlClient
Module Module1
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public ds As DataSet
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public str As String
    Sub koneksi()
        str = "Data Source=DESKTOP-MPAQ4RB\SQLEXPRESS;Initial Catalog=kill;Integrated Security=True"
        conn = New SqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If
    End Sub
End Module