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
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageCompanySetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewCompanySetupStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageProductStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.FileMenu, Me.ProductSetupToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageCompanySetupToolStripMenuItem, Me.ToolStripSeparator3, Me.ViewCompanySetupStripMenuItem1, Me.ToolStripSeparator4, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
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
        'ViewCompanySetupStripMenuItem1
        '
        Me.ViewCompanySetupStripMenuItem1.Name = "ViewCompanySetupStripMenuItem1"
        Me.ViewCompanySetupStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.ViewCompanySetupStripMenuItem1.Text = "View CompanySetup"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(192, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(192, 6)
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewCompanySetupStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageCompanySetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageProductStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
