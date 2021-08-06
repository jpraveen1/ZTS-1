<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQualifiedLead
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadQualificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTheDealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbCustomerName = New System.Windows.Forms.ComboBox()
        Me.txtItSalesConsultantName = New System.Windows.Forms.TextBox()
        Me.lblSalesConsultantName = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lstProductName = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpLeadQualifiedDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.logo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 62)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(577, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Qualified Leads"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.BGimage
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.LeadToolStripMenuItem1, Me.LeadQualificationToolStripMenuItem, Me.DemoToolStripMenuItem, Me.NegotiationToolStripMenuItem, Me.CloseTheDealToolStripMenuItem, Me.SalesReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(305, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1012, 59)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(64, 55)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'LeadToolStripMenuItem1
        '
        Me.LeadToolStripMenuItem1.Name = "LeadToolStripMenuItem1"
        Me.LeadToolStripMenuItem1.Size = New System.Drawing.Size(136, 55)
        Me.LeadToolStripMenuItem1.Text = "Lead Generation"
        '
        'LeadQualificationToolStripMenuItem
        '
        Me.LeadQualificationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeadQualificationToolStripMenuItem.Name = "LeadQualificationToolStripMenuItem"
        Me.LeadQualificationToolStripMenuItem.Size = New System.Drawing.Size(140, 55)
        Me.LeadQualificationToolStripMenuItem.Text = "Qualified Leads"
        '
        'DemoToolStripMenuItem
        '
        Me.DemoToolStripMenuItem.Name = "DemoToolStripMenuItem"
        Me.DemoToolStripMenuItem.Size = New System.Drawing.Size(64, 55)
        Me.DemoToolStripMenuItem.Text = "Demo"
        '
        'NegotiationToolStripMenuItem
        '
        Me.NegotiationToolStripMenuItem.Name = "NegotiationToolStripMenuItem"
        Me.NegotiationToolStripMenuItem.Size = New System.Drawing.Size(83, 55)
        Me.NegotiationToolStripMenuItem.Text = "Proposal"
        '
        'CloseTheDealToolStripMenuItem
        '
        Me.CloseTheDealToolStripMenuItem.Name = "CloseTheDealToolStripMenuItem"
        Me.CloseTheDealToolStripMenuItem.Size = New System.Drawing.Size(104, 55)
        Me.CloseTheDealToolStripMenuItem.Text = "Negotiation"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(211, 55)
        Me.SalesReportToolStripMenuItem.Text = "Expected Revenue for Sales"
        '
        'cmbCustomerName
        '
        Me.cmbCustomerName.FormattingEnabled = True
        Me.cmbCustomerName.Location = New System.Drawing.Point(542, 142)
        Me.cmbCustomerName.Name = "cmbCustomerName"
        Me.cmbCustomerName.Size = New System.Drawing.Size(270, 21)
        Me.cmbCustomerName.TabIndex = 29
        '
        'txtItSalesConsultantName
        '
        Me.txtItSalesConsultantName.Location = New System.Drawing.Point(542, 299)
        Me.txtItSalesConsultantName.Name = "txtItSalesConsultantName"
        Me.txtItSalesConsultantName.Size = New System.Drawing.Size(270, 20)
        Me.txtItSalesConsultantName.TabIndex = 28
        '
        'lblSalesConsultantName
        '
        Me.lblSalesConsultantName.AutoSize = True
        Me.lblSalesConsultantName.BackColor = System.Drawing.Color.Transparent
        Me.lblSalesConsultantName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesConsultantName.Location = New System.Drawing.Point(348, 299)
        Me.lblSalesConsultantName.Name = "lblSalesConsultantName"
        Me.lblSalesConsultantName.Size = New System.Drawing.Size(190, 20)
        Me.lblSalesConsultantName.TabIndex = 25
        Me.lblSalesConsultantName.Text = "It Sales Consultant Name"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(348, 232)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(110, 20)
        Me.lblProductName.TabIndex = 24
        Me.lblProductName.Text = "Product Name"
        '
        'lstProductName
        '
        Me.lstProductName.FormattingEnabled = True
        Me.lstProductName.Location = New System.Drawing.Point(542, 183)
        Me.lstProductName.Name = "lstProductName"
        Me.lstProductName.Size = New System.Drawing.Size(270, 108)
        Me.lstProductName.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(348, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Demo"})
        Me.cmbStatus.Location = New System.Drawing.Point(542, 346)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(270, 21)
        Me.cmbStatus.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(348, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Lead Qualified Date"
        '
        'dtpLeadQualifiedDate
        '
        Me.dtpLeadQualifiedDate.Location = New System.Drawing.Point(542, 383)
        Me.dtpLeadQualifiedDate.Name = "dtpLeadQualifiedDate"
        Me.dtpLeadQualifiedDate.Size = New System.Drawing.Size(270, 20)
        Me.dtpLeadQualifiedDate.TabIndex = 38
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Snow
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(479, 433)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 35)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(582, 672)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "©ZillionTechnologies Sales Organization"
        '
        'btnSignOut
        '
        Me.btnSignOut.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.signout
        Me.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignOut.Location = New System.Drawing.Point(1290, 7)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(48, 47)
        Me.btnSignOut.TabIndex = 42
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 15)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "®"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(12, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 31)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "ZSales"
        '
        'frmQualifiedLead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.BGimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpLeadQualifiedDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstProductName)
        Me.Controls.Add(Me.cmbCustomerName)
        Me.Controls.Add(Me.txtItSalesConsultantName)
        Me.Controls.Add(Me.lblSalesConsultantName)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmQualifiedLead"
        Me.Text = "Initiate_Contact"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LeadQualificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DemoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegotiationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTheDealToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbCustomerName As ComboBox
    Friend WithEvents txtItSalesConsultantName As TextBox
    Friend WithEvents lblSalesConsultantName As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lstProductName As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpLeadQualifiedDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
