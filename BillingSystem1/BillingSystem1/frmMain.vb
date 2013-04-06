Imports System.Windows.Forms

Public Class frmMain

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    
    Private Sub ManageCompanySetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageCompanySetupToolStripMenuItem.Click

        ' Create a new instance of the child form.
        Dim CompanySetup As New CompanySetup
        ' Make it a child of this MDI form before showing it.
        CompanySetup.MdiParent = Me

        CompanySetup.Text = "Company Details"

        CompanySetup.Show()

        CompanySetup.btnSave.Visible = True
        CompanySetup.btnReset.Visible = True

    End Sub

    Private Sub ViewCompanySetupStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCompanySetupStripMenuItem1.Click

        ' Create a new instance of the child form.
        Dim CompanySetup As New CompanySetup
        ' Make it a child of this MDI form before showing it.
        CompanySetup.MdiParent = Me

        CompanySetup.Text = "Company Details"

        CompanySetup.Show()

        Dim da As BillingSystemTableAdapters.CompanySetupTableAdapter = Nothing
        da = New BillingSystemTableAdapters.CompanySetupTableAdapter

        Dim dt As DataTable = da.GetData()

        For Each row As DataRow In dt.Rows

            CompanySetup.txtAddress.Enabled = False
            CompanySetup.txtLogo.Enabled = False
            CompanySetup.txtEmailId.Enabled = False
            CompanySetup.txtMobileNo.Enabled = False
            CompanySetup.txtWebSite.Enabled = False

            CompanySetup.txtAddress.Text = row.Item("C_Address")
            CompanySetup.txtEmailId.Text = row.Item("C_EmailId")
            CompanySetup.txtLogo.Text = row.Item("C_LogoPath")
            CompanySetup.txtMobileNo.Text = row.Item("C_PNo")
            CompanySetup.txtWebSite.Text = row.Item("C_WebSite")

            CompanySetup.btnSave.Visible = False
            CompanySetup.btnReset.Visible = False

        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub AddProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductToolStripMenuItem.Click

        Dim ProductSetup As New ProductSetup
        ' Make it a child of this MDI form before showing it.
        ProductSetup.MdiParent = Me

        ProductSetup.Text = "Product Details"

        ProductSetup.Show()

    End Sub

    Private Sub ManageProductStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageProductStockToolStripMenuItem.Click

        Dim ProductStock As New ProductStock
        ' Make it a child of this MDI form before showing it.
        ProductStock.MdiParent = Me

        ProductStock.Text = "Product Details"

        ProductStock.Show()

    End Sub
End Class
