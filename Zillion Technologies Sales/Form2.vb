Imports System.Data.SqlClient
Imports System.Text

Public Class frmLeadGeneration
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionstring As String
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader

        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * FROM LeadOwner"
        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbleadOwner.Items.Add(dr("Lead Owner"))
        End While

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim connectionstring As String

        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)

        'con.Open()

        For i As Integer = 0 To chlServicesInquiry.CheckedItems.Count - 1

            Dim cmd1 As New SqlCommand("insert into LeadInfo ( LeadOwner,CustName,EmailId,PhoneNumber,Products,EnquireDate,Interested,Company)values (@LeadOwner,@CustName,@EmailId,@PhoneNumber,@Products,@EnquireDate,@Interested,@Company)", con)


            cmd1.Parameters.AddWithValue("@LeadOwner", cmbleadOwner.SelectedItem)
            cmd1.Parameters.AddWithValue("@CustName", txtCusomerName.Text)
            cmd1.Parameters.AddWithValue("@EmailId", txEmailID.Text)
            cmd1.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
            cmd1.Parameters.AddWithValue("@Products", chlServicesInquiry.CheckedItems(i))
            cmd1.Parameters.AddWithValue("@EnquireDate", dtpEnquireDate.Value)
            cmd1.Parameters.AddWithValue("@Interested", clbInterested.SelectedItem)
            cmd1.Parameters.AddWithValue("@Company", txtCompany.Text)

            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
        Next
        MessageBox.Show("Record Inserted")
        cmbleadOwner.ResetText()
        txtCusomerName.Text = ""
        txEmailID.Text = ""
        txtPhoneNumber.Text = ""
        'chlServicesInquiry.Items.Clear()
        dtpEnquireDate.ResetText()
        'clbInterested.Items. ""
        'clbInterested.ResetText()
        txtCompany.Text = ""


    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        frmHomePage.Show()
    End Sub

    Private Sub LeadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LeadToolStripMenuItem1.Click
        Me.Show()

    End Sub

    Private Sub LeadQualificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeadQualificationToolStripMenuItem.Click
        frmQualifiedLead.Show()
        Me.Hide()

    End Sub

    Private Sub IniitialContactToolStripMenuItem_Click(sender As Object, e As EventArgs)

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
        frmExpectedRevenue.Show()
        Me.Hide()

    End Sub



    Private Sub btnSignOut_MouseHover_1(sender As Object, e As EventArgs) Handles btnSignOut.MouseHover
        ToolTip1.Show("ZSales 
 Sales Representative
 Sireesha", btnSignOut)
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        End
    End Sub

    Private Sub btnSignOut_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSignOut.MouseClick
        ToolTip1.Show("Sign Out", btnSignOut)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class