Public Class productList
    Private Sub LoadProduct()
        Dim productForm As New product()
        productForm.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadProduct()
    End Sub
End Class