
Imports System.Data.SqlClient
Public Class frmHomePage
    Dim connectionstring As String
    Dim con As SqlConnection
    Dim cmd As SqlCommand




    Private Sub frmHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim Dr As SqlDataReader
        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        con = New SqlConnection(connectionstring)

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text


        cmd.CommandText = "Select * from Login where  UserName = '" & txtUserName.Text & "' and  password='" & txtPassword.Text & "' "
        Dr = cmd.ExecuteReader

            If Dr.Read Then
                MsgBox("Valid User")
            frmLeadGeneration.Show()
            Me.Hide()
        Else
            MsgBox("Invalid User")

        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmLeadGeneration.Show()
        Me.Hide()

    End Sub

    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnSignOut_MouseHover(sender As Object, e As EventArgs)

    End Sub
End Class
