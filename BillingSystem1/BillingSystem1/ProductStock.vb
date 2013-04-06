Public Class ProductStock

    Dim count As Integer = 0

   
    Private Sub ProductStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtNoOfItems2.Visible = False
        txtProductCost2.Visible = False
        txtNoOfItems3.Visible = False
        txtProductCost3.Visible = False
        txtNoOfItems4.Visible = False
        txtProductCost4.Visible = False
        btnAdd2.Visible = False
        btnAdd3.Visible = False

        LoadProductDetails()

        count = 0
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

            ComboBox1.Items.Add(oItem)
            ComboBox2.Items.Add(oItem)
            ComboBox3.Items.Add(oItem)
            ComboBox4.Items.Add(oItem)
        Next

    End Sub

    Friend Class ComboItem
        Friend Text As String = ""
        Friend Value As Object = Nothing
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    
    Private Sub txtNoOfItems1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoOfItems1.KeyDown

        If e.KeyCode = Keys.Enter Then
            CalculateTotalCost(1)
        End If

    End Sub

    Public Sub CalculateTotalCost(ByVal i As Integer)

        Dim productId As Object = CType(ComboBox1.SelectedItem, ComboItem).Value
        Dim cost As Integer

        Dim da As BillingSystemTableAdapters.ProductsTableAdapter = Nothing
        da = New BillingSystemTableAdapters.ProductsTableAdapter

        Dim tblProducts As DataTable = da.GetDataBy3(productId)

        For Each row As DataRow In tblProducts.Rows
            cost = CInt(row.Item("Pcost"))
        Next

        If i = 1 Then
            txtProductCost1.Text = cost * CInt(txtNoOfItems1.Text)
        ElseIf i = 2 Then
            txtProductCost2.Text = cost * CInt(txtNoOfItems1.Text)
        ElseIf i = 3 Then
            txtProductCost3.Text = cost * CInt(txtNoOfItems1.Text)
        Else
            txtProductCost4.Text = cost * CInt(txtNoOfItems1.Text)
        End If

    End Sub

    Private Sub txtNoOfItems2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoOfItems2.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalculateTotalCost(2)
        End If
    End Sub

    Private Sub txtNoOfItems3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoOfItems3.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalculateTotalCost(3)
        End If
    End Sub

    Private Sub txtNoOfItems4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoOfItems4.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalculateTotalCost(4)
        End If
    End Sub

    Private Sub btnAdd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd1.Click
        txtNoOfItems2.Visible = True
        txtProductCost2.Visible = True
        btnAdd2.Visible = True
        count = count + 1
    End Sub

    Private Sub btnAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd2.Click
        txtNoOfItems3.Visible = True
        txtProductCost3.Visible = True
        btnAdd3.Visible = True
        count = count + 1
    End Sub

    Private Sub btnAdd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd3.Click
        txtNoOfItems4.Visible = True
        txtProductCost4.Visible = True
        count = count + 1
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadProductDetails()
    End Sub

    Private Sub btnSaveStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveStock.Click

        Dim da As BillingSystemTableAdapters.ProductStockTableAdapter = Nothing
        da = New BillingSystemTableAdapters.ProductStockTableAdapter

        For i As Integer = 1 To count

            Dim receiptNumber As Integer = da.GetMaxtReceiptNumber()
            If i = 1 Then
                da.InsertProductStock(receiptNumber, CType(ComboBox1.SelectedItem, ComboItem).Value, txtNoOfItems1.Text, txtProductCost1.Text, DateTime.Now)
            ElseIf i = 2 Then
                da.InsertProductStock(receiptNumber, CType(ComboBox2.SelectedItem, ComboItem).Value, txtNoOfItems2.Text, txtProductCost2.Text, DateTime.Now)
            ElseIf i = 3 Then
                da.InsertProductStock(receiptNumber, CType(ComboBox3.SelectedItem, ComboItem).Value, txtNoOfItems3.Text, txtProductCost3.Text, DateTime.Now)
            Else
                da.InsertProductStock(receiptNumber, CType(ComboBox4.SelectedItem, ComboItem).Value, txtNoOfItems4.Text, txtProductCost4.Text, DateTime.Now)
            End If

        Next i

    End Sub
End Class