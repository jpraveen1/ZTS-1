Imports System.Data.SqlClient

Public Class frmExpectedRevenue
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from leadinfo "

        da.SelectCommand = cmd

        DA.Fill(DT)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from LeadInitiateStatus "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from DemoSchedule "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from Proposal "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from Negotiation "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        frmHomePage.Show()
        Me.Hide()

    End Sub

    Private Sub LeadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LeadToolStripMenuItem1.Click
        frmLeadGeneration.Show()
        Me.Hide()


    End Sub

    Private Sub LeadQualificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeadQualificationToolStripMenuItem.Click
        frmQualifiedLead.Show()
        Me.Hide()

    End Sub

    Private Sub DemoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemoToolStripMenuItem.Click
        Demo.Show()
        Me.Hide()

    End Sub

    Private Sub NegotiationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegotiationToolStripMenuItem.Click
        frmProposal.Show()
        Me.Hide()

    End Sub

    Private Sub CloseTheDealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTheDealToolStripMenuItem.Click
        negotiation.Show()
        Me.Hide()


    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT  ;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select a.EnquireDate,a.CustName,a.Products,b.ClosingDate from   LeadInfo as a inner join  Negotiation as b on b.SalesConsultant= '" & cmbSalesConsultantName.Text & "' "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub frmExpectedRevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionstring As String
        Dim cmd As New SqlCommand
        'Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader



        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select * FROM LeadOwner")
        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbSalesConsultantName.Items.Add(dr("Lead Owner"))
        End While
    End Sub

    Private Sub btnSignOut_MouseHover(sender As Object, e As EventArgs) Handles btnSignOut.MouseHover
        ToolTip1.Show("ZSales 
 Sales Representative
 Sireesha", btnSignOut)
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        End
    End Sub
End Class