<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        txtdesc = New TextBox()
        Label1 = New Label()
        txtcatname = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        DataGridView2 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(txtdesc)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtcatname)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(54, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(708, 243)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Details"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(360, 164)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 42)
        Button2.TabIndex = 45
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(218, 164)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 42)
        Button1.TabIndex = 44
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtdesc
        ' 
        txtdesc.Location = New Point(218, 119)
        txtdesc.Name = "txtdesc"
        txtdesc.Size = New Size(361, 27)
        txtdesc.TabIndex = 43
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(85, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 28)
        Label1.TabIndex = 42
        Label1.Text = "Description :"
        ' 
        ' txtcatname
        ' 
        txtcatname.Location = New Point(218, 72)
        txtcatname.Name = "txtcatname"
        txtcatname.Size = New Size(361, 27)
        txtcatname.TabIndex = 41
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(46, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 28)
        Label2.TabIndex = 40
        Label2.Text = "Category Name :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DataGridView2)
        GroupBox2.Location = New Point(54, 306)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(708, 326)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "List"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DataGridView2.Location = New Point(17, 26)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(674, 294)
        DataGridView2.TabIndex = 32
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Category Name"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Description"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' CategoryForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(837, 643)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CategoryForm"
        Text = "Category"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcatname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class