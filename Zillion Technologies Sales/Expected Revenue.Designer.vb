<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpectedRevenue
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadQualificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTheDealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.cmbSalesConsultantName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(74, 55)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'LeadToolStripMenuItem1
        '
        Me.LeadToolStripMenuItem1.Name = "LeadToolStripMenuItem1"
        Me.LeadToolStripMenuItem1.Size = New System.Drawing.Size(163, 55)
        Me.LeadToolStripMenuItem1.Text = "Lead Generation"
        '
        'LeadQualificationToolStripMenuItem
        '
        Me.LeadQualificationToolStripMenuItem.Name = "LeadQualificationToolStripMenuItem"
        Me.LeadQualificationToolStripMenuItem.Size = New System.Drawing.Size(154, 55)
        Me.LeadQualificationToolStripMenuItem.Text = "Qualified Leads"
        '
        'DemoToolStripMenuItem
        '
        Me.DemoToolStripMenuItem.Name = "DemoToolStripMenuItem"
        Me.DemoToolStripMenuItem.Size = New System.Drawing.Size(74, 55)
        Me.DemoToolStripMenuItem.Text = "Demo"
        '
        'NegotiationToolStripMenuItem
        '
        Me.NegotiationToolStripMenuItem.Name = "NegotiationToolStripMenuItem"
        Me.NegotiationToolStripMenuItem.Size = New System.Drawing.Size(98, 55)
        Me.NegotiationToolStripMenuItem.Text = "Proposal"
        '
        'CloseTheDealToolStripMenuItem
        '
        Me.CloseTheDealToolStripMenuItem.Name = "CloseTheDealToolStripMenuItem"
        Me.CloseTheDealToolStripMenuItem.Size = New System.Drawing.Size(124, 55)
        Me.CloseTheDealToolStripMenuItem.Text = "Negotiation"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(267, 55)
        Me.SalesReportToolStripMenuItem.Text = "Expected Revenue for Sales"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.logo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 62)
        Me.Panel1.TabIndex = 26
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(203, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(881, 419)
        Me.DataGridView1.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(213, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 39)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Lead Generation Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(415, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 39)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Lead Qualified Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(617, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(205, 39)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Demo Reports"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(821, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(205, 39)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Proposal Report"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1024, 65)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(205, 39)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Negotiation Reports"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(213, 103)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(205, 39)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "Lead start to end Date Report"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cmbSalesConsultantName
        '
        Me.cmbSalesConsultantName.FormattingEnabled = True
        Me.cmbSalesConsultantName.Location = New System.Drawing.Point(292, 148)
        Me.cmbSalesConsultantName.Name = "cmbSalesConsultantName"
        Me.cmbSalesConsultantName.Size = New System.Drawing.Size(157, 21)
        Me.cmbSalesConsultantName.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Sales Consultant Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(582, 672)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "©ZillionTechnologies Sales Organization"
        '
        'btnSignOut
        '
        Me.btnSignOut.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.signout
        Me.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignOut.Location = New System.Drawing.Point(1290, 7)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(48, 47)
        Me.btnSignOut.TabIndex = 38
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
        'frmExpectedRevenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Zillion_Technologies_Sales.My.Resources.Resources.BGimage
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSalesConsultantName)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmExpectedRevenue"
        Me.Text = "Expected Revenue"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LeadQualificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DemoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegotiationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTheDealToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents cmbSalesConsultantName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
