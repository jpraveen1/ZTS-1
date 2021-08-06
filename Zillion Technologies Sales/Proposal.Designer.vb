<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProposal
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadQualificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTheDealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProposal = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblServicesProducts = New System.Windows.Forms.Label()
        Me.lblPropasedPrice = New System.Windows.Forms.Label()
        Me.lblCustomerExpectedPrice = New System.Windows.Forms.Label()
        Me.lblSalesConsultantName = New System.Windows.Forms.Label()
        Me.lblSuccessFail = New System.Windows.Forms.Label()
        Me.cmbCustomerName = New System.Windows.Forms.ComboBox()
        Me.txtPropasalPrice = New System.Windows.Forms.TextBox()
        Me.txtCustomerExpectedPrice = New System.Windows.Forms.TextBox()
        Me.txtSalesConsultantName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lstServiceProducts = New System.Windows.Forms.ListBox()
        Me.cmdSuccessFail = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Panel1.TabIndex = 2
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
        Me.MenuStrip2.TabIndex = 25
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
        Me.DemoToolStripMenuItem.Name = "DemoToolStripMenuItem"
        Me.DemoToolStripMenuItem.Size = New System.Drawing.Size(64, 55)
        Me.DemoToolStripMenuItem.Text = "Demo"
        '
        'NegotiationToolStripMenuItem
        '
        Me.NegotiationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NegotiationToolStripMenuItem.Name = "NegotiationToolStripMenuItem"
        Me.NegotiationToolStripMenuItem.Size = New System.Drawing.Size(89, 55)
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
        'lblProposal
        '
        Me.lblProposal.AutoSize = True
        Me.lblProposal.BackColor = System.Drawing.Color.Transparent
        Me.lblProposal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProposal.Location = New System.Drawing.Point(577, 90)
        Me.lblProposal.Name = "lblProposal"
        Me.lblProposal.Size = New System.Drawing.Size(97, 25)
        Me.lblProposal.TabIndex = 26
        Me.lblProposal.Text = "Proposal"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(392, 142)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(124, 20)
        Me.lblCustomerName.TabIndex = 27
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblServicesProducts
        '
        Me.lblServicesProducts.AutoSize = True
        Me.lblServicesProducts.BackColor = System.Drawing.Color.Transparent
        Me.lblServicesProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicesProducts.Location = New System.Drawing.Point(391, 298)
        Me.lblServicesProducts.Name = "lblServicesProducts"
        Me.lblServicesProducts.Size = New System.Drawing.Size(140, 20)
        Me.lblServicesProducts.TabIndex = 28
        Me.lblServicesProducts.Text = "Services /Products"
        '
        'lblPropasedPrice
        '
        Me.lblPropasedPrice.AutoSize = True
        Me.lblPropasedPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPropasedPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropasedPrice.Location = New System.Drawing.Point(392, 394)
        Me.lblPropasedPrice.Name = "lblPropasedPrice"
        Me.lblPropasedPrice.Size = New System.Drawing.Size(110, 20)
        Me.lblPropasedPrice.TabIndex = 29
        Me.lblPropasedPrice.Text = "Proposal Price"
        '
        'lblCustomerExpectedPrice
        '
        Me.lblCustomerExpectedPrice.AutoSize = True
        Me.lblCustomerExpectedPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerExpectedPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerExpectedPrice.Location = New System.Drawing.Point(392, 446)
        Me.lblCustomerExpectedPrice.Name = "lblCustomerExpectedPrice"
        Me.lblCustomerExpectedPrice.Size = New System.Drawing.Size(188, 20)
        Me.lblCustomerExpectedPrice.TabIndex = 30
        Me.lblCustomerExpectedPrice.Text = "Customer Expected Price"
        '
        'lblSalesConsultantName
        '
        Me.lblSalesConsultantName.AutoSize = True
        Me.lblSalesConsultantName.BackColor = System.Drawing.Color.Transparent
        Me.lblSalesConsultantName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesConsultantName.Location = New System.Drawing.Point(392, 202)
        Me.lblSalesConsultantName.Name = "lblSalesConsultantName"
        Me.lblSalesConsultantName.Size = New System.Drawing.Size(176, 20)
        Me.lblSalesConsultantName.TabIndex = 31
        Me.lblSalesConsultantName.Text = "Sales Consultant Name"
        '
        'lblSuccessFail
        '
        Me.lblSuccessFail.AutoSize = True
        Me.lblSuccessFail.BackColor = System.Drawing.Color.Transparent
        Me.lblSuccessFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuccessFail.Location = New System.Drawing.Point(394, 490)
        Me.lblSuccessFail.Name = "lblSuccessFail"
        Me.lblSuccessFail.Size = New System.Drawing.Size(99, 20)
        Me.lblSuccessFail.TabIndex = 32
        Me.lblSuccessFail.Text = "Success/Fail"
        '
        'cmbCustomerName
        '
        Me.cmbCustomerName.FormattingEnabled = True
        Me.cmbCustomerName.Location = New System.Drawing.Point(638, 147)
        Me.cmbCustomerName.Name = "cmbCustomerName"
        Me.cmbCustomerName.Size = New System.Drawing.Size(313, 21)
        Me.cmbCustomerName.TabIndex = 33
        '
        'txtPropasalPrice
        '
        Me.txtPropasalPrice.Location = New System.Drawing.Point(638, 399)
        Me.txtPropasalPrice.Name = "txtPropasalPrice"
        Me.txtPropasalPrice.Size = New System.Drawing.Size(313, 20)
        Me.txtPropasalPrice.TabIndex = 35
        '
        'txtCustomerExpectedPrice
        '
        Me.txtCustomerExpectedPrice.Location = New System.Drawing.Point(638, 446)
        Me.txtCustomerExpectedPrice.Name = "txtCustomerExpectedPrice"
        Me.txtCustomerExpectedPrice.Size = New System.Drawing.Size(313, 20)
        Me.txtCustomerExpectedPrice.TabIndex = 36
        '
        'txtSalesConsultantName
        '
        Me.txtSalesConsultantName.Location = New System.Drawing.Point(638, 202)
        Me.txtSalesConsultantName.Name = "txtSalesConsultantName"
        Me.txtSalesConsultantName.Size = New System.Drawing.Size(313, 20)
        Me.txtSalesConsultantName.TabIndex = 37
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(609, 545)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 42)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lstServiceProducts
        '
        Me.lstServiceProducts.FormattingEnabled = True
        Me.lstServiceProducts.Location = New System.Drawing.Point(638, 238)
        Me.lstServiceProducts.Name = "lstServiceProducts"
        Me.lstServiceProducts.Size = New System.Drawing.Size(313, 134)
        Me.lstServiceProducts.TabIndex = 40
        '
        'cmdSuccessFail
        '
        Me.cmdSuccessFail.FormattingEnabled = True
        Me.cmdSuccessFail.Items.AddRange(New Object() {"Success", "Fail"})
        Me.cmdSuccessFail.Location = New System.Drawing.Point(638, 492)
        Me.cmdSuccessFail.Name = "cmdSuccessFail"
        Me.cmdSuccessFail.Size = New System.Drawing.Size(313, 21)
        Me.cmdSuccessFail.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(582, 672)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "©ZillionTechnologies Sales Organization"
        '
        'btnSignOut
        '
        Me.btnSignOut.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.signout
        Me.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignOut.Location = New System.Drawing.Point(1290, 7)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(48, 47)
        Me.btnSignOut.TabIndex = 44
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(12, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 31)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "ZSales"
        '
        'frmProposal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.BGimage
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdSuccessFail)
        Me.Controls.Add(Me.lstServiceProducts)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSalesConsultantName)
        Me.Controls.Add(Me.txtCustomerExpectedPrice)
        Me.Controls.Add(Me.txtPropasalPrice)
        Me.Controls.Add(Me.cmbCustomerName)
        Me.Controls.Add(Me.lblSuccessFail)
        Me.Controls.Add(Me.lblSalesConsultantName)
        Me.Controls.Add(Me.lblCustomerExpectedPrice)
        Me.Controls.Add(Me.lblPropasedPrice)
        Me.Controls.Add(Me.lblServicesProducts)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblProposal)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmProposal"
        Me.Text = "Proposal"
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
    Friend WithEvents lblProposal As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblServicesProducts As Label
    Friend WithEvents lblPropasedPrice As Label
    Friend WithEvents lblCustomerExpectedPrice As Label
    Friend WithEvents lblSalesConsultantName As Label
    Friend WithEvents lblSuccessFail As Label
    Friend WithEvents cmbCustomerName As ComboBox
    Friend WithEvents txtPropasalPrice As TextBox
    Friend WithEvents txtCustomerExpectedPrice As TextBox
    Friend WithEvents txtSalesConsultantName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lstServiceProducts As ListBox
    Friend WithEvents cmdSuccessFail As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
