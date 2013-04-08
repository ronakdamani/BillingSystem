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
        If btnSave.Text = "Edit" Then
            txtLogo.Enabled = True
            txtAddress.Enabled = True
            txtEmailId.Enabled = True
            txtMobileNo.Enabled = True
            txtWebSite.Enabled = True
            btnSave.Text = "Save"
            btnReset.Enabled = True
        ElseIf btnSave.Text = "Save" Then

            Dim da As BillingSystemTableAdapters.CompanySetupTableAdapter
            da = New BillingSystemTableAdapters.CompanySetupTableAdapter
            Dim saved As Integer = 1
            da.UpdateCompanyDetails(txtLogo.Text, txtAddress.Text, txtEmailId.Text, txtMobileNo.Text, txtWebSite.Text)
            MessageBox.Show("Updated Successfully", "Company Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Text = "Edit"
            txtAddress.Enabled = False
            txtLogo.Enabled = False
            txtEmailId.Enabled = False
            txtMobileNo.Enabled = False
            txtWebSite.Enabled = False
            btnReset.Enabled = False
        End If


    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtLogo.Text = ""
        txtAddress.Text = ""
        txtEmailId.Text = ""
        txtMobileNo.Text = ""
        txtWebSite.Text = ""

    End Sub

    Private Sub CompanySetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim da As BillingSystemTableAdapters.CompanySetupTableAdapter = Nothing
        da = New BillingSystemTableAdapters.CompanySetupTableAdapter

        Dim dt As DataTable = da.GetData()

        For Each row As DataRow In dt.Rows

            txtAddress.Enabled = False
            txtLogo.Enabled = False
            txtEmailId.Enabled = False
            txtMobileNo.Enabled = False
            txtWebSite.Enabled = False

            txtAddress.Text = row.Item("C_Address")
            txtEmailId.Text = row.Item("C_EmailId")
            txtLogo.Text = row.Item("C_LogoPath")
            txtMobileNo.Text = row.Item("C_PNo")
            txtWebSite.Text = row.Item("C_WebSite")



        Next

        txtLogo.Enabled = False
        txtAddress.Enabled = False
        txtEmailId.Enabled = False
        txtMobileNo.Enabled = False
        txtWebSite.Enabled = False
        btnSave.Text = "Edit"
        btnReset.Enabled = False
    End Sub
End Class