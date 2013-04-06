<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSetup
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
        Me.lblAddProduct = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.txtProductName = New System.Windows.Forms.TextBox
        Me.lblProductCost = New System.Windows.Forms.Label
        Me.txtProductCost = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.txtUpdateProductCost = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbProductName = New System.Windows.Forms.ComboBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.grpManageProduct = New System.Windows.Forms.GroupBox
        Me.grpManageProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddProduct
        '
        Me.lblAddProduct.AutoSize = True
        Me.lblAddProduct.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddProduct.Location = New System.Drawing.Point(85, 30)
        Me.lblAddProduct.Name = "lblAddProduct"
        Me.lblAddProduct.Size = New System.Drawing.Size(85, 20)
        Me.lblAddProduct.TabIndex = 0
        Me.lblAddProduct.Text = "Add Product"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(23, 66)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(114, 16)
        Me.lblProductName.TabIndex = 1
        Me.lblProductName.Text = "Product Name :"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(135, 63)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(114, 22)
        Me.txtProductName.TabIndex = 2
        '
        'lblProductCost
        '
        Me.lblProductCost.AutoSize = True
        Me.lblProductCost.Location = New System.Drawing.Point(23, 97)
        Me.lblProductCost.Name = "lblProductCost"
        Me.lblProductCost.Size = New System.Drawing.Size(104, 16)
        Me.lblProductCost.TabIndex = 3
        Me.lblProductCost.Text = "Product Cost :"
        '
        'txtProductCost
        '
        Me.txtProductCost.Location = New System.Drawing.Point(135, 97)
        Me.txtProductCost.Name = "txtProductCost"
        Me.txtProductCost.Size = New System.Drawing.Size(114, 22)
        Me.txtProductCost.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(26, 133)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(17, 303)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtUpdateProductCost
        '
        Me.txtUpdateProductCost.Location = New System.Drawing.Point(126, 267)
        Me.txtUpdateProductCost.Name = "txtUpdateProductCost"
        Me.txtUpdateProductCost.Size = New System.Drawing.Size(114, 22)
        Me.txtUpdateProductCost.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Product Cost :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Product Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Update Product"
        '
        'cmbProductName
        '
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(126, 236)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(114, 24)
        Me.cmbProductName.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(110, 303)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(135, 133)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(206, 303)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'grpManageProduct
        '
        Me.grpManageProduct.Controls.Add(Me.btnSave)
        Me.grpManageProduct.Controls.Add(Me.lblAddProduct)
        Me.grpManageProduct.Controls.Add(Me.lblProductName)
        Me.grpManageProduct.Controls.Add(Me.btnDelete)
        Me.grpManageProduct.Controls.Add(Me.txtProductName)
        Me.grpManageProduct.Controls.Add(Me.lblProductCost)
        Me.grpManageProduct.Controls.Add(Me.txtProductCost)
        Me.grpManageProduct.Controls.Add(Me.btnReset)
        Me.grpManageProduct.Controls.Add(Me.Label3)
        Me.grpManageProduct.Controls.Add(Me.cmbProductName)
        Me.grpManageProduct.Controls.Add(Me.Label2)
        Me.grpManageProduct.Controls.Add(Me.btnRefresh)
        Me.grpManageProduct.Controls.Add(Me.Label1)
        Me.grpManageProduct.Controls.Add(Me.btnUpdate)
        Me.grpManageProduct.Controls.Add(Me.txtUpdateProductCost)
        Me.grpManageProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpManageProduct.Location = New System.Drawing.Point(21, 21)
        Me.grpManageProduct.Name = "grpManageProduct"
        Me.grpManageProduct.Size = New System.Drawing.Size(292, 356)
        Me.grpManageProduct.TabIndex = 22
        Me.grpManageProduct.TabStop = False
        Me.grpManageProduct.Text = "Manage Product"
        '
        'ProductSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 405)
        Me.Controls.Add(Me.grpManageProduct)
        Me.Name = "ProductSetup"
        Me.Text = "ProductSetup"
        Me.grpManageProduct.ResumeLayout(False)
        Me.grpManageProduct.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAddProduct As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents lblProductCost As System.Windows.Forms.Label
    Friend WithEvents txtProductCost As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtUpdateProductCost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents grpManageProduct As System.Windows.Forms.GroupBox
End Class
