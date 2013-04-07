<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepwd
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtpwd = New System.Windows.Forms.TextBox
        Me.txtnpwd = New System.Windows.Forms.TextBox
        Me.txtcpwd = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Current Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Your New Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm Your New Password :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 22)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(208, 21)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(146, 20)
        Me.txtpwd.TabIndex = 4
        '
        'txtnpwd
        '
        Me.txtnpwd.Location = New System.Drawing.Point(208, 54)
        Me.txtnpwd.Name = "txtnpwd"
        Me.txtnpwd.Size = New System.Drawing.Size(146, 20)
        Me.txtnpwd.TabIndex = 5
        '
        'txtcpwd
        '
        Me.txtcpwd.Location = New System.Drawing.Point(208, 86)
        Me.txtcpwd.Name = "txtcpwd"
        Me.txtcpwd.Size = New System.Drawing.Size(146, 20)
        Me.txtcpwd.TabIndex = 6
        '
        'changepwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 153)
        Me.Controls.Add(Me.txtcpwd)
        Me.Controls.Add(Me.txtnpwd)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "changepwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtnpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtcpwd As System.Windows.Forms.TextBox
End Class
