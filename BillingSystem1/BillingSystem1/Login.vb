Public Class Login

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim da As BillingSystemTableAdapters.CompanySetupTableAdapter = Nothing
        da = New BillingSystemTableAdapters.CompanySetupTableAdapter

        Dim dt As DataTable = da.GetData()

        For Each row As DataRow In dt.Rows

            If txtPassword.Text = row.Item("C_Password").ToString() Then

                frmMain.Show()
                Me.Hide()

            Else
                MessageBox.Show("Please Enter Correct Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Next

    End Sub

    Private Sub btnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePassword.Click

        If txtNewPassword.Text <> "" Then
            Dim da As BillingSystemTableAdapters.CompanySetupTableAdapter = Nothing
            da = New BillingSystemTableAdapters.CompanySetupTableAdapter

            da.UpdatePassword(txtNewPassword.Text)
            MessageBox.Show("Updated Successfully", "Password Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnChangePassword.Visible = False
            btnLogin.Enabled = True
            txtNewPassword.Visible = False
            txtPassword.Text = ""
            lblPassword.Text = "Enter password"
            lblNewPassword.Visible = False
            CheckBox1.Checked = False
            CheckBox1.Enabled = True
            txtPassword.Enabled = True
        Else
            MessageBox.Show("Please Enter Valid Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
    
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            Dim da As BillingSystemTableAdapters.CompanySetupTableAdapter = Nothing
            da = New BillingSystemTableAdapters.CompanySetupTableAdapter

            Dim dt As DataTable = da.GetData()

            For Each row As DataRow In dt.Rows

                If txtPassword.Text = row.Item("C_Password").ToString() Then
                    btnChangePassword.Visible = True
                    txtPassword.Enabled = False
                    txtNewPassword.Visible = True
                    txtNewPassword.Text = ""
                    lblNewPassword.Visible = True
                    btnLogin.Enabled = False
                    CheckBox1.Enabled = False
                Else
                    MessageBox.Show("Please Enter correct password and check again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CheckBox1.Checked = False
                End If
            Next

        End If
    End Sub
End Class
