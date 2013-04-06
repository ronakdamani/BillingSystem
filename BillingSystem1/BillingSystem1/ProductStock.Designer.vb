<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductStock
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
        Me.lblProductName = New System.Windows.Forms.Label
        Me.lblProductCost = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtProductCost1 = New System.Windows.Forms.TextBox
        Me.txtNoOfItems1 = New System.Windows.Forms.TextBox
        Me.btnAdd1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnSaveStock = New System.Windows.Forms.Button
        Me.txtNoOfItems4 = New System.Windows.Forms.TextBox
        Me.txtProductCost4 = New System.Windows.Forms.TextBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.btnAdd3 = New System.Windows.Forms.Button
        Me.txtNoOfItems3 = New System.Windows.Forms.TextBox
        Me.txtProductCost3 = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.btnAdd2 = New System.Windows.Forms.Button
        Me.txtNoOfItems2 = New System.Windows.Forms.TextBox
        Me.txtProductCost2 = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(13, 29)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(106, 16)
        Me.lblProductName.TabIndex = 2
        Me.lblProductName.Text = "Product Name"
        '
        'lblProductCost
        '
        Me.lblProductCost.AutoSize = True
        Me.lblProductCost.Location = New System.Drawing.Point(283, 29)
        Me.lblProductCost.Name = "lblProductCost"
        Me.lblProductCost.Size = New System.Drawing.Size(39, 16)
        Me.lblProductCost.TabIndex = 4
        Me.lblProductCost.Text = "Cost"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No of Items"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox1.TabIndex = 15
        '
        'txtProductCost1
        '
        Me.txtProductCost1.Location = New System.Drawing.Point(286, 62)
        Me.txtProductCost1.Name = "txtProductCost1"
        Me.txtProductCost1.Size = New System.Drawing.Size(77, 22)
        Me.txtProductCost1.TabIndex = 16
        '
        'txtNoOfItems1
        '
        Me.txtNoOfItems1.Location = New System.Drawing.Point(166, 62)
        Me.txtNoOfItems1.Name = "txtNoOfItems1"
        Me.txtNoOfItems1.Size = New System.Drawing.Size(95, 22)
        Me.txtNoOfItems1.TabIndex = 17
        '
        'btnAdd1
        '
        Me.btnAdd1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1.Location = New System.Drawing.Point(369, 62)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(32, 23)
        Me.btnAdd1.TabIndex = 18
        Me.btnAdd1.Text = "+"
        Me.btnAdd1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnSaveStock)
        Me.GroupBox1.Controls.Add(Me.txtNoOfItems4)
        Me.GroupBox1.Controls.Add(Me.txtProductCost4)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.btnAdd3)
        Me.GroupBox1.Controls.Add(Me.txtNoOfItems3)
        Me.GroupBox1.Controls.Add(Me.txtProductCost3)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.btnAdd2)
        Me.GroupBox1.Controls.Add(Me.txtNoOfItems2)
        Me.GroupBox1.Controls.Add(Me.txtProductCost2)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.btnAdd1)
        Me.GroupBox1.Controls.Add(Me.lblProductName)
        Me.GroupBox1.Controls.Add(Me.txtNoOfItems1)
        Me.GroupBox1.Controls.Add(Me.lblProductCost)
        Me.GroupBox1.Controls.Add(Me.txtProductCost1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 277)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Details"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(382, 230)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 26)
        Me.btnRefresh.TabIndex = 31
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSaveStock
        '
        Me.btnSaveStock.Location = New System.Drawing.Point(286, 230)
        Me.btnSaveStock.Name = "btnSaveStock"
        Me.btnSaveStock.Size = New System.Drawing.Size(90, 26)
        Me.btnSaveStock.TabIndex = 30
        Me.btnSaveStock.Text = "Save"
        Me.btnSaveStock.UseVisualStyleBackColor = True
        '
        'txtNoOfItems4
        '
        Me.txtNoOfItems4.Location = New System.Drawing.Point(166, 188)
        Me.txtNoOfItems4.Name = "txtNoOfItems4"
        Me.txtNoOfItems4.Size = New System.Drawing.Size(95, 22)
        Me.txtNoOfItems4.TabIndex = 29
        Me.txtNoOfItems4.Visible = False
        '
        'txtProductCost4
        '
        Me.txtProductCost4.Location = New System.Drawing.Point(286, 186)
        Me.txtProductCost4.Name = "txtProductCost4"
        Me.txtProductCost4.Size = New System.Drawing.Size(77, 22)
        Me.txtProductCost4.TabIndex = 28
        Me.txtProductCost4.Visible = False
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(16, 186)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox4.TabIndex = 27
        '
        'btnAdd3
        '
        Me.btnAdd3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd3.Location = New System.Drawing.Point(369, 142)
        Me.btnAdd3.Name = "btnAdd3"
        Me.btnAdd3.Size = New System.Drawing.Size(32, 23)
        Me.btnAdd3.TabIndex = 26
        Me.btnAdd3.Text = "+"
        Me.btnAdd3.UseVisualStyleBackColor = True
        Me.btnAdd3.Visible = False
        '
        'txtNoOfItems3
        '
        Me.txtNoOfItems3.Location = New System.Drawing.Point(166, 143)
        Me.txtNoOfItems3.Name = "txtNoOfItems3"
        Me.txtNoOfItems3.Size = New System.Drawing.Size(95, 22)
        Me.txtNoOfItems3.TabIndex = 25
        Me.txtNoOfItems3.Visible = False
        '
        'txtProductCost3
        '
        Me.txtProductCost3.Location = New System.Drawing.Point(286, 142)
        Me.txtProductCost3.Name = "txtProductCost3"
        Me.txtProductCost3.Size = New System.Drawing.Size(77, 22)
        Me.txtProductCost3.TabIndex = 24
        Me.txtProductCost3.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(16, 141)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox3.TabIndex = 23
        '
        'btnAdd2
        '
        Me.btnAdd2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd2.Location = New System.Drawing.Point(369, 99)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(32, 26)
        Me.btnAdd2.TabIndex = 22
        Me.btnAdd2.Text = "+"
        Me.btnAdd2.UseVisualStyleBackColor = True
        Me.btnAdd2.Visible = False
        '
        'txtNoOfItems2
        '
        Me.txtNoOfItems2.Location = New System.Drawing.Point(166, 98)
        Me.txtNoOfItems2.Name = "txtNoOfItems2"
        Me.txtNoOfItems2.Size = New System.Drawing.Size(95, 22)
        Me.txtNoOfItems2.TabIndex = 21
        Me.txtNoOfItems2.Visible = False
        '
        'txtProductCost2
        '
        Me.txtProductCost2.Location = New System.Drawing.Point(286, 100)
        Me.txtProductCost2.Name = "txtProductCost2"
        Me.txtProductCost2.Size = New System.Drawing.Size(77, 22)
        Me.txtProductCost2.TabIndex = 20
        Me.txtProductCost2.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(16, 100)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox2.TabIndex = 19
        '
        'ProductStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 333)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ProductStock"
        Me.Text = "ProductStock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblProductCost As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtProductCost1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOfItems1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoOfItems4 As System.Windows.Forms.TextBox
    Friend WithEvents txtProductCost4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd3 As System.Windows.Forms.Button
    Friend WithEvents txtNoOfItems3 As System.Windows.Forms.TextBox
    Friend WithEvents txtProductCost3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd2 As System.Windows.Forms.Button
    Friend WithEvents txtNoOfItems2 As System.Windows.Forms.TextBox
    Friend WithEvents txtProductCost2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveStock As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
