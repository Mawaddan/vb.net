Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        cmd = New SqlCommand("select * from login where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("login failed")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        Else
            Me.Visible = True
            form2.show
            Me.Hide()

        End If



    End Sub
End Class
