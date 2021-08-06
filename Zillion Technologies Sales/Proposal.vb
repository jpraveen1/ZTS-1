Imports System.Data.SqlClient

Public Class frmProposal
    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

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
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtSalesConsultantName.TextChanged

    End Sub

    Private Sub frmProposal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionstring As String
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader

        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select CustomerName FROM DemoSchedule  group by CustomerName")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbCustomerName.Items.Add(dr("CustomerName"))
            'txtSalesConsultantName.Text = dr("SalesConsultant")
        End While

    End Sub

    Private Sub cmbCustomerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomerName.SelectedIndexChanged


        Dim connectionstring As String
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader

        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select SalesConsultant FROM DemoSchedule")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()

            'cmbCustomerName.Items.Add(dr("CustomerName"))
            txtSalesConsultantName.Text = dr("SalesConsultant")
        End While
        con.Close()

        con.Open()


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select Products FROM LeadInfo where LeadOwner='" & txtSalesConsultantName.Text & "'")

        da.SelectCommand = cmd
        dr = cmd.ExecuteReader()

        Dim txt As String
        Dim i As Integer
        Do While dr.Read
            txt = dr.Item(0).ToString
            For i = 1 To dr.FieldCount - 1
                txt &= vbTab & dr.Item(i).ToString
            Next i
            lstServiceProducts.Items.Add(txt)

        Loop
        con.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As SqlCommand
        Dim connetionString As String
        Dim con As SqlConnection
        Dim CN As String = cmbCustomerName.Text
        Dim SCN As String = txtSalesConsultantName.Text
        Dim PPrice As Int64 = txtPropasalPrice.Text
        Dim CExpPrice As Int64 = txtCustomerExpectedPrice.Text
        'Dim SuccessFail As String = txtSuccessFail.Text
        Dim SuccesFail As String = cmdSuccessFail.Text


        connetionString = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZT;server=DESKTOP-OR87V3L"
        con = New SqlConnection(connetionString)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "insert into Proposal values ('" & CN & "','" & SCN & "','" & PPrice & "','" & CExpPrice & "','" & SuccesFail & "')"

        cmd.ExecuteNonQuery()
        MsgBox("Record inserted successfully")

        cmbCustomerName.ResetText()
        txtSalesConsultantName.ResetText()
        lstServiceProducts.ResetText()
        txtPropasalPrice.Text = ""
        txtCustomerExpectedPrice.Text = ""
        cmdSuccessFail.ResetText()






    End Sub

    Private Sub txtSuccessFail_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CloseTheDealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTheDealToolStripMenuItem.Click
        negotiation.Show()
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