Public Class Accountant
    Public Sub LoadStockList()
        Dim Stocks As New productList()
        Stocks.TopLevel = False
        Stocks.Parent = Me.Panel3
        Stocks.Dock = DockStyle.Fill
        Stocks.Show()

    End Sub

    Public Sub LoadCategoryList()
        Dim Category As New CategoryForm()
        Category.TopLevel = False
        Category.Parent = Me.Panel3
        Category.Dock = DockStyle.Fill
        Category.Show()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        LoadStockList()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

    End Sub
End Class