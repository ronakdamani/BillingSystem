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

    End Class
