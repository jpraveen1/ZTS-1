<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLeadGeneration
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
        Me.lblLeadInformation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chlServicesInquiry = New System.Windows.Forms.CheckedListBox()
        Me.txtCusomerName = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txEmailID = New System.Windows.Forms.TextBox()
        Me.lblEmailId = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clbInterested = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEnquireDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadQualificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTheDealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl = New System.Windows.Forms.Label()
        Me.cmbleadOwner = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbLeadSource = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLeadInformation
        '
        Me.lblLeadInformation.AutoSize = True
        Me.lblLeadInformation.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblLeadInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLeadInformation.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeadInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLeadInformation.Location = New System.Drawing.Point(554, 68)
        Me.lblLeadInformation.Name = "lblLeadInformation"
        Me.lblLeadInformation.Size = New System.Drawing.Size(213, 36)
        Me.lblLeadInformation.TabIndex = 0
        Me.lblLeadInformation.Text = "Lead Generation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Products"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Name"
        '
        'chlServicesInquiry
        '
        Me.chlServicesInquiry.CheckOnClick = True
        Me.chlServicesInquiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chlServicesInquiry.FormattingEnabled = True
        Me.chlServicesInquiry.Items.AddRange(New Object() {"Digital Transformation", "Cybersecurity", "dotz-Zillion ERP Solutions", "Zillion ERP Solutions", "AI Cyber Risk Engine", "neasaa"})
        Me.chlServicesInquiry.Location = New System.Drawing.Point(625, 310)
        Me.chlServicesInquiry.Name = "chlServicesInquiry"
        Me.chlServicesInquiry.Size = New System.Drawing.Size(228, 130)
        Me.chlServicesInquiry.TabIndex = 7
        '
        'txtCusomerName
        '
        Me.txtCusomerName.Location = New System.Drawing.Point(625, 190)
        Me.txtCusomerName.Name = "txtCusomerName"
        Me.txtCusomerName.Size = New System.Drawing.Size(228, 20)
        Me.txtCusomerName.TabIndex = 8
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(515, 623)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 28)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txEmailID
        '
        Me.txEmailID.Location = New System.Drawing.Point(625, 238)
        Me.txEmailID.Name = "txEmailID"
        Me.txEmailID.Size = New System.Drawing.Size(228, 20)
        Me.txEmailID.TabIndex = 12
        '
        'lblEmailId
        '
        Me.lblEmailId.AutoSize = True
        Me.lblEmailId.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailId.Location = New System.Drawing.Point(396, 238)
        Me.lblEmailId.Name = "lblEmailId"
        Me.lblEmailId.Size = New System.Drawing.Size(79, 24)
        Me.lblEmailId.TabIndex = 11
        Me.lblEmailId.Text = "Email ID"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(625, 275)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(228, 20)
        Me.txtPhoneNumber.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(396, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 499)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Shown Interest"
        '
        'clbInterested
        '
        Me.clbInterested.CheckOnClick = True
        Me.clbInterested.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbInterested.FormattingEnabled = True
        Me.clbInterested.Items.AddRange(New Object() {"Yes", "No"})
        Me.clbInterested.Location = New System.Drawing.Point(625, 487)
        Me.clbInterested.Name = "clbInterested"
        Me.clbInterested.Size = New System.Drawing.Size(63, 46)
        Me.clbInterested.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(396, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Enquire Date"
        '
        'dtpEnquireDate
        '
        Me.dtpEnquireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnquireDate.Location = New System.Drawing.Point(625, 446)
        Me.dtpEnquireDate.Name = "dtpEnquireDate"
        Me.dtpEnquireDate.Size = New System.Drawing.Size(228, 20)
        Me.dtpEnquireDate.TabIndex = 18
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(396, 549)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(91, 24)
        Me.lblCompany.TabIndex = 19
        Me.lblCompany.Text = "Company"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(625, 548)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(228, 20)
        Me.txtCompany.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.LeadToolStripMenuItem1, Me.LeadQualificationToolStripMenuItem, Me.DemoToolStripMenuItem, Me.NegotiationToolStripMenuItem, Me.CloseTheDealToolStripMenuItem, Me.SalesReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(305, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(878, 59)
        Me.MenuStrip1.TabIndex = 22
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
        Me.LeadToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeadToolStripMenuItem1.Name = "LeadToolStripMenuItem1"
        Me.LeadToolStripMenuItem1.Size = New System.Drawing.Size(147, 55)
        Me.LeadToolStripMenuItem1.Text = "Lead Generation"
        '
        'LeadQualificationToolStripMenuItem
        '
        Me.LeadQualificationToolStripMenuItem.Name = "LeadQualificationToolStripMenuItem"
        Me.LeadQualificationToolStripMenuItem.Size = New System.Drawing.Size(129, 55)
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
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(392, 142)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(149, 24)
        Me.lbl.TabIndex = 23
        Me.lbl.Text = "Sales Consultant"
        '
        'cmbleadOwner
        '
        Me.cmbleadOwner.FormattingEnabled = True
        Me.cmbleadOwner.Location = New System.Drawing.Point(625, 142)
        Me.cmbleadOwner.Name = "cmbleadOwner"
        Me.cmbleadOwner.Size = New System.Drawing.Size(228, 21)
        Me.cmbleadOwner.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(401, 583)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Lead Source"
        '
        'cmbLeadSource
        '
        Me.cmbLeadSource.FormattingEnabled = True
        Me.cmbLeadSource.Items.AddRange(New Object() {"Newspaper", "Call", "Paper Ads", "Online Ads", "Referral", ""})
        Me.cmbLeadSource.Location = New System.Drawing.Point(625, 575)
        Me.cmbLeadSource.Name = "cmbLeadSource"
        Me.cmbLeadSource.Size = New System.Drawing.Size(228, 21)
        Me.cmbLeadSource.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(1043, 727)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "©ZillionTechnologies Sales Organization"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(56, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 31)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "ZSales"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(149, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 15)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "®"
        '
        'btnSignOut
        '
        Me.btnSignOut.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.signout
        Me.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignOut.Location = New System.Drawing.Point(1290, 7)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(48, 47)
        Me.btnSignOut.TabIndex = 32
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'frmLeadGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1265, 749)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbLeadSource)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbleadOwner)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.dtpEnquireDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clbInterested)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txEmailID)
        Me.Controls.Add(Me.lblEmailId)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtCusomerName)
        Me.Controls.Add(Me.chlServicesInquiry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLeadInformation)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLeadGeneration"
        Me.Text = "Lead Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLeadInformation As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chlServicesInquiry As CheckedListBox
    Friend WithEvents txtCusomerName As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txEmailID As TextBox
    Friend WithEvents lblEmailId As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents clbInterested As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpEnquireDate As DateTimePicker
    Friend WithEvents lblCompany As Label
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LeadQualificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DemoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegotiationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTheDealToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl As Label
    Friend WithEvents cmbleadOwner As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbLeadSource As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
