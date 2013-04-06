Public Class CompanySetup

    Private Sub btnLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogo.Click

        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            txtLogo.Text = FileName
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim da As BillingSystemTableAdapters.CompanySetupTableAdapter
        da = New BillingSystemTableAdapters.CompanySetupTableAdapter

        da.UpdateCompanyDetails(txtLogo.Text, txtAddress.Text, txtEmailId.Text, txtMobileNo.Text, txtWebSite.Text)
        MessageBox.Show("Updated Successfully", "Company Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtLogo.Text = ""
        txtAddress.Text = ""
        txtEmailId.Text = ""
        txtMobileNo.Text = ""
        txtWebSite.Text = ""

    End Sub
End Class