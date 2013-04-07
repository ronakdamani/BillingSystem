Public Class changepwd

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim pwd, npwd, cpwd As String
        pwd = txtpwd.Text
        npwd = txtnpwd.Text
        cpwd = txtcpwd.Text


        Dim da As BillingSystemTableAdapters.CompanySetupTableAdapter = Nothing
        da = New BillingSystemTableAdapters.CompanySetupTableAdapter

        Dim dt As DataTable = da.GetData()

        For Each row As DataRow In dt.Rows

            If pwd = row.Item("C_Password").ToString() Then
                If txtcpwd.Text = txtnpwd.Text And txtcpwd.Text <> "" And txtnpwd.Text <> "" Then
                    da.UpdatePassword(txtcpwd.Text)
                    MessageBox.Show("Updated Successfully", "Password Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()

                Else
                    MsgBox("Enter New Password Data Correctly", MsgBoxStyle.OkOnly)
                End If
            Else
                MessageBox.Show("Please Enter Correct Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
        
    End Sub
    Private Sub changepwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnpwd.Enabled = False
        txtcpwd.Enabled = False
    End Sub

    Private Sub txtpwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpwd.TextChanged
        Dim da As BillingSystemTableAdapters.CompanySetupTableAdapter = Nothing
        da = New BillingSystemTableAdapters.CompanySetupTableAdapter

        Dim dt As DataTable = da.GetData()

        For Each row As DataRow In dt.Rows

            If txtpwd.Text = row.Item("C_Password").ToString() Then
                txtcpwd.Enabled = True
                txtnpwd.Enabled = True
            Else
                txtcpwd.Enabled = False
                txtnpwd.Enabled = False

            End If
        Next

    End Sub
End Class