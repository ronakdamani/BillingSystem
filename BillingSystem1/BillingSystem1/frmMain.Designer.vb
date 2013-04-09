<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageCompanySetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageProductStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutPOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSales1 = New System.Windows.Forms.ToolStripButton
        Me.btnSales2 = New System.Windows.Forms.ToolStripButton
        Me.btnSales3 = New System.Windows.Forms.ToolStripButton
        Me.btnSales4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.lbllogoff = New System.Windows.Forms.ToolStripLabel
        Me.lblDate = New System.Windows.Forms.ToolStripLabel
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ProductSetupToolStripMenuItem, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePaToolStripMenuItem, Me.LogOffToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.ToolStripMenuItem1.Text = "Admin"
        '
        'ChangePaToolStripMenuItem
        '
        Me.ChangePaToolStripMenuItem.Name = "ChangePaToolStripMenuItem"
        Me.ChangePaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePaToolStripMenuItem.Text = "Change Password"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogOffToolStripMenuItem.Text = "Log off"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageCompanySetupToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.ShowShortcutKeys = False
        Me.FileMenu.Size = New System.Drawing.Size(101, 20)
        Me.FileMenu.Text = "CompanySetup"
        '
        'ManageCompanySetupToolStripMenuItem
        '
        Me.ManageCompanySetupToolStripMenuItem.Image = CType(resources.GetObject("ManageCompanySetupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageCompanySetupToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.ManageCompanySetupToolStripMenuItem.Name = "ManageCompanySetupToolStripMenuItem"
        Me.ManageCompanySetupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ManageCompanySetupToolStripMenuItem.ShowShortcutKeys = False
        Me.ManageCompanySetupToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ManageCompanySetupToolStripMenuItem.Text = "Manage CompanySetup"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(192, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ProductSetupToolStripMenuItem
        '
        Me.ProductSetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductToolStripMenuItem, Me.ManageProductStockToolStripMenuItem})
        Me.ProductSetupToolStripMenuItem.Name = "ProductSetupToolStripMenuItem"
        Me.ProductSetupToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ProductSetupToolStripMenuItem.Text = "ProductSetup"
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AddProductToolStripMenuItem.Text = "Add Product"
        '
        'ManageProductStockToolStripMenuItem
        '
        Me.ManageProductStockToolStripMenuItem.Name = "ManageProductStockToolStripMenuItem"
        Me.ManageProductStockToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ManageProductStockToolStripMenuItem.Text = "Manage Product Stock"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutPOSToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutPOSToolStripMenuItem
        '
        Me.AboutPOSToolStripMenuItem.Name = "AboutPOSToolStripMenuItem"
        Me.AboutPOSToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutPOSToolStripMenuItem.Text = "About POS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSales1, Me.btnSales2, Me.btnSales3, Me.btnSales4, Me.ToolStripSeparator1, Me.lbllogoff, Me.lblDate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(624, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSales1
        '
        Me.btnSales1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSales1.Image = CType(resources.GetObject("btnSales1.Image"), System.Drawing.Image)
        Me.btnSales1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSales1.Name = "btnSales1"
        Me.btnSales1.Size = New System.Drawing.Size(23, 22)
        Me.btnSales1.Text = "SalesScreen1"
        '
        'btnSales2
        '
        Me.btnSales2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSales2.Image = CType(resources.GetObject("btnSales2.Image"), System.Drawing.Image)
        Me.btnSales2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSales2.Name = "btnSales2"
        Me.btnSales2.Size = New System.Drawing.Size(23, 22)
        Me.btnSales2.Text = "Sales Screen 2"
        '
        'btnSales3
        '
        Me.btnSales3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSales3.Image = CType(resources.GetObject("btnSales3.Image"), System.Drawing.Image)
        Me.btnSales3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSales3.Name = "btnSales3"
        Me.btnSales3.Size = New System.Drawing.Size(23, 22)
        Me.btnSales3.Text = "Sales Screen 3"
        '
        'btnSales4
        '
        Me.btnSales4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSales4.Image = CType(resources.GetObject("btnSales4.Image"), System.Drawing.Image)
        Me.btnSales4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSales4.Name = "btnSales4"
        Me.btnSales4.Size = New System.Drawing.Size(23, 22)
        Me.btnSales4.Text = "Sales Screen 4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lbllogoff
        '
        Me.lbllogoff.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbllogoff.Name = "lbllogoff"
        Me.lbllogoff.Size = New System.Drawing.Size(47, 22)
        Me.lbllogoff.Text = "Log Off"
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(34, 22)
        Me.lblDate.Text = "Date:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 444)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageCompanySetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageProductStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutPOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSales1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSales2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSales3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSales4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lbllogoff As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripLabel

End Class
