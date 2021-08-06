Imports System.Data.SqlClient

Public Class frmQualifiedLead

    Private Sub frmQualifiedLead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionstring As String
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader

        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select CustName FROM LeadInfo where interested= 'Yes' group by CustName")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbCustomerName.Items.Add(dr("CustName"))
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
        Me.Show()

    End Sub



    Private Sub cmbCustomerName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCustomerName.SelectedValueChanged

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
        cmd.CommandText = "SELECT Products,LeadOwner FROM LeadInfo where CustName = '" & cmbCustomerName.Text & "' "
        ' cmd.CommandText = "SELECT Products FROM LeadInfo where CustName = '" & cmbCustomerName.Text & "' "

        da.SelectCommand = cmd
        dr = cmd.ExecuteReader()
        Dim txt As String
        Dim i As Integer
        Do While dr.Read
            txt = dr.Item(0).ToString
            For i = 1 To dr.FieldCount - 1
                txt &= vbTab & dr.Item(i).ToString
            Next i
            lstProductName.Items.Add(txt)
            txtItSalesConsultantName.Text = (dr("LeadOwner"))
        Loop

    End Sub

    Private Sub DemoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemoToolStripMenuItem.Click
        Demo.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As SqlCommand
        Dim connetionString As String
        Dim con As SqlConnection
        Dim CN As String = cmbCustomerName.Text
        Dim SCN As String = txtItSalesConsultantName.Text
        Dim S As String = cmbStatus.Text
        Dim D As Date = dtpLeadQualifiedDate.Value


        connetionString = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        con = New SqlConnection(connetionString)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "insert into LeadInitiateStatus values ('" & CN & "','" & SCN & "','" & S & "','" & D & "')"

        cmd.ExecuteNonQuery()
        MsgBox("Record inserted successfully")

        cmbCustomerName.ResetText()
        txtItSalesConsultantName.Text = ""
        txtItSalesConsultantName.Text = ""
        cmbStatus.ResetText()
        dtpLeadQualifiedDate.ResetText()


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



    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        End
    End Sub

    Private Sub btnSignOut_MouseHover(sender As Object, e As EventArgs) Handles btnSignOut.MouseHover
        ToolTip1.Show("ZSales 
 Sales Representative
 Sireesha", btnSignOut)
    End Sub
End Class