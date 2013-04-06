Public Class ProductSetup

    Private Sub ProductSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadProductDetails()
    End Sub
    Public Sub LoadProductDetails()

        Dim oItem As ComboItem = Nothing

        Dim da As BillingSystemTableAdapters.ProductsTableAdapter = Nothing
        da = New BillingSystemTableAdapters.ProductsTableAdapter

        Dim tblProducts As DataTable = da.GetData()

        For Each row As DataRow In tblProducts.Rows
            oItem = New ComboItem
            oItem.Text = row("Pname").ToString()
            oItem.Value = row("Pid")

            cmbProductName.Items.Add(oItem)
        Next

    End Sub

    Friend Class ComboItem
        Friend Text As String = ""
        Friend Value As Object = Nothing
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtProductName.Text <> "" And txtProductCost.Text <> "" Then
            Dim da As BillingSystemTableAdapters.ProductsTableAdapter = Nothing
            da = New BillingSystemTableAdapters.ProductsTableAdapter
            da.InsertProduct(txtProductName.Text, txtProductCost.Text)
            MessageBox.Show("Saved Successfully", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Enter Product Details", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtProductCost.Text = ""
        txtProductName.Text = ""
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If cmbProductName.Text <> "" Then
            Dim da As BillingSystemTableAdapters.ProductsTableAdapter = Nothing
            da = New BillingSystemTableAdapters.ProductsTableAdapter
            da.UpdateProduct(txtUpdateProductCost.Text, CType(cmbProductName.SelectedItem, ComboItem).Value)
        Else
            MessageBox.Show("Enter Product Details", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If cmbProductName.Text <> "" Then
            Dim da As BillingSystemTableAdapters.ProductsTableAdapter = Nothing
            da = New BillingSystemTableAdapters.ProductsTableAdapter
            da.DeleteProduct(CType(cmbProductName.SelectedItem, ComboItem).Value)
        Else
            MessageBox.Show("Enter Product Details", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged
        Dim productId As Object = CType(cmbProductName.SelectedItem, ComboItem).Value

        Dim da As BillingSystemTableAdapters.ProductsTableAdapter = Nothing
        da = New BillingSystemTableAdapters.ProductsTableAdapter

        Dim tblProducts As DataTable = da.GetDataBy3(productId)

        For Each row As DataRow In tblProducts.Rows
            txtUpdateProductCost.Text = row.Item("Pcost").ToString()
        Next

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadProductDetails()
    End Sub
End Class