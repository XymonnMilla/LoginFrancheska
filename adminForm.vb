Public Class adminForm
    Private Sub LoadPOSForm()
        Dim POSForm As New POSForm()
        POSForm.TopLevel = False
        POSForm.Parent = Me.Panel3
        POSForm.Dock = DockStyle.Fill
        POSForm.Show()
    End Sub
    Private Sub LoadInventoryForm()
        Dim invForm As New productList()
        invForm.TopLevel = False
        invForm.Parent = Me.Panel3
        invForm.Dock = DockStyle.Fill
        invForm.Show()
    End Sub
    Private Sub LoadCategoryForm()
        Dim categoryForm As New CategoryForm()
        categoryForm.TopLevel = False
        categoryForm.Parent = Me.Panel3
        categoryForm.Dock = DockStyle.Fill
        categoryForm.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        LoadPOSForm()
    End Sub
    Private Sub adminForm_Resize(sender As Object, e As EventArgs)
        Panel3.Width = Me.ClientSize.Width - Panel2.Width - Panel1.Width
        Panel3.Height = Me.ClientSize.Height
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        LoadInventoryForm()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        LoadCategoryForm()
    End Sub
End Class