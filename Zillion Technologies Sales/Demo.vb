Imports System.Data.SqlClient

Public Class Demo

    Private Sub Demo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionstring As String
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader



        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select CustomerName from leadinitiatestatus where status='Demo' group by CustomerName")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbPotentialCustomerName.Items.Add(dr("CustomerName"))
        End While


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
        Me.Show()

    End Sub

    Private Sub cmbPotentialCustomerName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPotentialCustomerName.SelectedValueChanged


        Dim cmd As SqlCommand
        Dim connectionstring As String
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        con = New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT SalesConsultant FROM LeadInitiateStatus where CustomerName = '" & cmbPotentialCustomerName.Text & "' "

        da.SelectCommand = cmd
        dr = cmd.ExecuteReader()
        dr.Read()

        txtSaleConsultantName.Text = dr("SalesConsultant")

    End Sub

    Private Sub btnDemoMeetingSchedule_Click(sender As Object, e As EventArgs) Handles btnDemoMeetingSchedule.Click

        Dim cmd As New SqlCommand
        Dim connectionstring As String
        Dim con As SqlConnection


        Dim CN As String = cmbPotentialCustomerName.Text
        Dim SCN As String = txtSaleConsultantName.Text
        Dim SDate As Date = dtpMemoMeet.Value

        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        con = New SqlConnection(connectionstring)
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "insert into DemoSchedule values ('" & CN & "', '" & SCN & "','" & SDate & "')"

        cmd.ExecuteNonQuery()
        MsgBox("Meeting is Scheduled")

        cmbPotentialCustomerName.ResetText()
        txtSaleConsultantName.Text = ""
        dtpMemoMeet.ResetText()


    End Sub

    Private Sub NegotiationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegotiationToolStripMenuItem.Click
        frmProposal.Show()
        Me.Hide()

    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        frmExpectedRevenue.Show()
        Me.Hide()

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