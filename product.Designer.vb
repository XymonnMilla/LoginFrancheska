<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class product
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
        btnsave = New Button()
        Label2 = New Label()
        txtmarkup = New TextBox()
        Label9 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        txtDescription = New TextBox()
        Label4 = New Label()
        txtitemname = New TextBox()
        txtQuantity = New TextBox()
        Label8 = New Label()
        Label6 = New Label()
        txtUnitPrice = New TextBox()
        Label7 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        txtBoxItemCode = New TextBox()
        CheckBox1 = New CheckBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnsave
        ' 
        btnsave.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsave.Location = New Point(713, 667)
        btnsave.Margin = New Padding(4, 5, 4, 5)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(164, 53)
        btnsave.TabIndex = 12
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 25)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(263, 39)
        Label2.TabIndex = 36
        Label2.Text = "Product Details"
        ' 
        ' txtmarkup
        ' 
        txtmarkup.BackColor = SystemColors.HighlightText
        txtmarkup.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtmarkup.Location = New Point(568, 514)
        txtmarkup.Margin = New Padding(4, 5, 4, 5)
        txtmarkup.Name = "txtmarkup"
        txtmarkup.Size = New Size(260, 26)
        txtmarkup.TabIndex = 7
        txtmarkup.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(564, 489)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(138, 20)
        Label9.TabIndex = 9
        Label9.Text = "Mark up Price :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(288, 325)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 20)
        Label1.TabIndex = 8
        Label1.Text = "Category :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(292, 349)
        ComboBox1.Margin = New Padding(4, 5, 4, 5)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(536, 28)
        ComboBox1.TabIndex = 3
        ' 
        ' txtDescription
        ' 
        txtDescription.BackColor = SystemColors.HighlightText
        txtDescription.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescription.Location = New Point(292, 222)
        txtDescription.Margin = New Padding(4, 5, 4, 5)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(536, 81)
        txtDescription.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(288, 197)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 20)
        Label4.TabIndex = 0
        Label4.Text = "Description :"
        ' 
        ' txtitemname
        ' 
        txtitemname.BackColor = SystemColors.HighlightText
        txtitemname.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtitemname.Location = New Point(292, 149)
        txtitemname.Margin = New Padding(4, 5, 4, 5)
        txtitemname.Name = "txtitemname"
        txtitemname.Size = New Size(536, 26)
        txtitemname.TabIndex = 1
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BackColor = SystemColors.HighlightText
        txtQuantity.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQuantity.Location = New Point(568, 434)
        txtQuantity.Margin = New Padding(4, 5, 4, 5)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(260, 26)
        txtQuantity.TabIndex = 5
        txtQuantity.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(288, 118)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 20)
        Label8.TabIndex = 0
        Label8.Text = "Product Name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(564, 405)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 20)
        Label6.TabIndex = 0
        Label6.Text = "Quantity :"
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.BackColor = SystemColors.HighlightText
        txtUnitPrice.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUnitPrice.Location = New Point(292, 514)
        txtUnitPrice.Margin = New Padding(4, 5, 4, 5)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.Size = New Size(239, 26)
        txtUnitPrice.TabIndex = 6
        txtUnitPrice.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(288, 489)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 20)
        Label7.TabIndex = 0
        Label7.Text = "Unit Price :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(33, 118)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 20)
        Label3.TabIndex = 0
        Label3.Text = "Product Code:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(txtBoxItemCode)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtmarkup)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(txtDescription)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtitemname)
        GroupBox1.Controls.Add(txtQuantity)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtUnitPrice)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(16, 18)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(861, 639)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' txtBoxItemCode
        ' 
        txtBoxItemCode.Location = New Point(29, 149)
        txtBoxItemCode.Name = "txtBoxItemCode"
        txtBoxItemCode.Size = New Size(186, 27)
        txtBoxItemCode.TabIndex = 37
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(288, 418)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.RightToLeft = RightToLeft.Yes
        CheckBox1.Size = New Size(105, 24)
        CheckBox1.TabIndex = 38
        CheckBox1.Text = "On Hand"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(292, 558)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 20)
        Label5.TabIndex = 39
        Label5.Text = "Reorder Level:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.HighlightText
        TextBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(292, 583)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(239, 26)
        TextBox1.TabIndex = 40
        TextBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' product
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(895, 738)
        Controls.Add(btnsave)
        Controls.Add(GroupBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "product"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Stocks"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents btnsave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmarkup As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtitemname As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBoxItemCode As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
End Class
