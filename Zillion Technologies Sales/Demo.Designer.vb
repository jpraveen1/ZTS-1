<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Demo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadQualificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTheDealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPotentialCustomerName = New System.Windows.Forms.ComboBox()
        Me.txtSaleConsultantName = New System.Windows.Forms.TextBox()
        Me.dtpMemoMeet = New System.Windows.Forms.DateTimePicker()
        Me.btnDemoMeetingSchedule = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.logo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 62)
        Me.Panel1.TabIndex = 1
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip2.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.BGimage
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.LeadToolStripMenuItem1, Me.LeadQualificationToolStripMenuItem, Me.DemoToolStripMenuItem, Me.NegotiationToolStripMenuItem, Me.CloseTheDealToolStripMenuItem, Me.SalesReportToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(305, 9)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1012, 59)
        Me.MenuStrip2.TabIndex = 24
        Me.MenuStrip2.Text = "MenuStrip1"
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
        Me.LeadQualificationToolStripMenuItem.Name = "LeadQualificationToolStripMenuItem"
        Me.LeadQualificationToolStripMenuItem.Size = New System.Drawing.Size(129, 55)
        Me.LeadQualificationToolStripMenuItem.Text = "Qualified Leads"
        '
        'DemoToolStripMenuItem
        '
        Me.DemoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DemoToolStripMenuItem.Name = "DemoToolStripMenuItem"
        Me.DemoToolStripMenuItem.Size = New System.Drawing.Size(68, 55)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(577, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Demo "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Potential Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(393, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Meeting DateTime"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(393, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Sale Consultant Name"
        '
        'cmbPotentialCustomerName
        '
        Me.cmbPotentialCustomerName.FormattingEnabled = True
        Me.cmbPotentialCustomerName.Location = New System.Drawing.Point(635, 144)
        Me.cmbPotentialCustomerName.Name = "cmbPotentialCustomerName"
        Me.cmbPotentialCustomerName.Size = New System.Drawing.Size(215, 21)
        Me.cmbPotentialCustomerName.TabIndex = 30
        '
        'txtSaleConsultantName
        '
        Me.txtSaleConsultantName.Location = New System.Drawing.Point(635, 180)
        Me.txtSaleConsultantName.Name = "txtSaleConsultantName"
        Me.txtSaleConsultantName.Size = New System.Drawing.Size(215, 20)
        Me.txtSaleConsultantName.TabIndex = 31
        '
        'dtpMemoMeet
        '
        Me.dtpMemoMeet.Location = New System.Drawing.Point(635, 216)
        Me.dtpMemoMeet.Name = "dtpMemoMeet"
        Me.dtpMemoMeet.Size = New System.Drawing.Size(215, 20)
        Me.dtpMemoMeet.TabIndex = 32
        '
        'btnDemoMeetingSchedule
        '
        Me.btnDemoMeetingSchedule.BackColor = System.Drawing.Color.White
        Me.btnDemoMeetingSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemoMeetingSchedule.Location = New System.Drawing.Point(544, 274)
        Me.btnDemoMeetingSchedule.Name = "btnDemoMeetingSchedule"
        Me.btnDemoMeetingSchedule.Size = New System.Drawing.Size(200, 39)
        Me.btnDemoMeetingSchedule.TabIndex = 33
        Me.btnDemoMeetingSchedule.Text = "Demo Meeting Schedule"
        Me.btnDemoMeetingSchedule.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(582, 672)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "©ZillionTechnologies Sales Organization"
        '
        'btnSignOut
        '
        Me.btnSignOut.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.signout
        Me.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignOut.Location = New System.Drawing.Point(1286, 12)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(48, 47)
        Me.btnSignOut.TabIndex = 36
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 15)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "®"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(12, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 31)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "ZSales"
        '
        'Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.BGimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDemoMeetingSchedule)
        Me.Controls.Add(Me.dtpMemoMeet)
        Me.Controls.Add(Me.txtSaleConsultantName)
        Me.Controls.Add(Me.cmbPotentialCustomerName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Demo"
        Me.Text = "Demo"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LeadQualificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DemoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegotiationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTheDealToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPotentialCustomerName As ComboBox
    Friend WithEvents txtSaleConsultantName As TextBox
    Friend WithEvents dtpMemoMeet As DateTimePicker
    Friend WithEvents btnDemoMeetingSchedule As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
End Class
