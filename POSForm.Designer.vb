<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POSForm
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel4 = New Panel()
        GroupBox3 = New GroupBox()
        txtChange = New TextBox()
        txtAmountRecieve = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox2 = New GroupBox()
        TxtTotalDue = New TextBox()
        txtTax = New TextBox()
        txtdiscount = New TextBox()
        txtSubtotal1 = New TextBox()
        Label19 = New Label()
        Label14 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        txtcustomer = New TextBox()
        txtOR = New TextBox()
        txtinvoice = New TextBox()
        Label7 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Timer1 = New Timer(components)
        ToolTip1 = New ToolTip(components)
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnFind = New Button()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        txtsubtotal = New TextBox()
        Label13 = New Label()
        txttotalPrice = New TextBox()
        Label6 = New Label()
        txtprice = New TextBox()
        Label5 = New Label()
        txtdescription = New TextBox()
        Label2 = New Label()
        txtqty = New TextBox()
        Label4 = New Label()
        txtitemname = New TextBox()
        Label8 = New Label()
        txtItemCode = New TextBox()
        Label3 = New Label()
        dtgItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        ToolStrip1 = New ToolStrip()
        tsSave = New ToolStripButton()
        tsPayment = New ToolStripButton()
        tsNew = New ToolStripButton()
        tsRemove = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        LBLCASHIER = New ToolStripLabel()
        ToolStripSeparator2 = New ToolStripSeparator()
        ToolStripLabel2 = New ToolStripLabel()
        lbldate = New ToolStripLabel()
        ToolStripSeparator3 = New ToolStripSeparator()
        ToolStripLabel3 = New ToolStripLabel()
        lbltime = New ToolStripLabel()
        Panel4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dtgItems, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(GroupBox3)
        Panel4.Controls.Add(GroupBox2)
        Panel4.Location = New Point(881, 138)
        Panel4.Margin = New Padding(4, 5, 4, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(565, 676)
        Panel4.TabIndex = 39
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(txtChange)
        GroupBox3.Controls.Add(txtAmountRecieve)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.ForeColor = Color.Black
        GroupBox3.Location = New Point(17, 306)
        GroupBox3.Margin = New Padding(4, 5, 4, 5)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 5, 4, 5)
        GroupBox3.Size = New Size(541, 231)
        GroupBox3.TabIndex = 29
        GroupBox3.TabStop = False
        ' 
        ' txtChange
        ' 
        txtChange.BackColor = SystemColors.HighlightText
        txtChange.Enabled = False
        txtChange.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtChange.ForeColor = SystemColors.ActiveCaptionText
        txtChange.Location = New Point(275, 126)
        txtChange.Margin = New Padding(4, 5, 4, 5)
        txtChange.Name = "txtChange"
        txtChange.Size = New Size(257, 53)
        txtChange.TabIndex = 42
        txtChange.Text = "0.00"
        txtChange.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtAmountRecieve
        ' 
        txtAmountRecieve.BackColor = SystemColors.HighlightText
        txtAmountRecieve.Font = New Font("Microsoft Sans Serif", 26.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmountRecieve.ForeColor = SystemColors.ActiveCaptionText
        txtAmountRecieve.Location = New Point(275, 45)
        txtAmountRecieve.Margin = New Padding(4, 5, 4, 5)
        txtAmountRecieve.Name = "txtAmountRecieve"
        txtAmountRecieve.Size = New Size(257, 57)
        txtAmountRecieve.TabIndex = 41
        txtAmountRecieve.Text = "0.00"
        txtAmountRecieve.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(24, 51)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(224, 29)
        Label11.TabIndex = 20
        Label11.Text = "Amount Received:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(140, 146)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(117, 29)
        Label12.TabIndex = 21
        Label12.Text = "Change :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(TxtTotalDue)
        GroupBox2.Controls.Add(txtTax)
        GroupBox2.Controls.Add(txtdiscount)
        GroupBox2.Controls.Add(txtSubtotal1)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(17, 18)
        GroupBox2.Margin = New Padding(4, 5, 4, 5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 5, 4, 5)
        GroupBox2.Size = New Size(541, 278)
        GroupBox2.TabIndex = 38
        GroupBox2.TabStop = False
        ' 
        ' TxtTotalDue
        ' 
        TxtTotalDue.BackColor = SystemColors.HighlightText
        TxtTotalDue.Enabled = False
        TxtTotalDue.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtTotalDue.ForeColor = SystemColors.ActiveCaptionText
        TxtTotalDue.Location = New Point(237, 195)
        TxtTotalDue.Margin = New Padding(4, 5, 4, 5)
        TxtTotalDue.Name = "TxtTotalDue"
        TxtTotalDue.Size = New Size(295, 37)
        TxtTotalDue.TabIndex = 40
        TxtTotalDue.Text = "0.00"
        TxtTotalDue.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtTax
        ' 
        txtTax.BackColor = SystemColors.HighlightText
        txtTax.Enabled = False
        txtTax.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTax.ForeColor = SystemColors.ActiveCaptionText
        txtTax.Location = New Point(237, 132)
        txtTax.Margin = New Padding(4, 5, 4, 5)
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(295, 37)
        txtTax.TabIndex = 39
        txtTax.Text = "0.00"
        txtTax.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtdiscount
        ' 
        txtdiscount.BackColor = SystemColors.HighlightText
        txtdiscount.Enabled = False
        txtdiscount.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtdiscount.ForeColor = SystemColors.ActiveCaptionText
        txtdiscount.Location = New Point(237, 74)
        txtdiscount.Margin = New Padding(4, 5, 4, 5)
        txtdiscount.Name = "txtdiscount"
        txtdiscount.Size = New Size(295, 37)
        txtdiscount.TabIndex = 38
        txtdiscount.Text = "0.00"
        txtdiscount.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtSubtotal1
        ' 
        txtSubtotal1.BackColor = SystemColors.HighlightText
        txtSubtotal1.Enabled = False
        txtSubtotal1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSubtotal1.ForeColor = SystemColors.ActiveCaptionText
        txtSubtotal1.Location = New Point(237, 18)
        txtSubtotal1.Margin = New Padding(4, 5, 4, 5)
        txtSubtotal1.Name = "txtSubtotal1"
        txtSubtotal1.Size = New Size(295, 37)
        txtSubtotal1.TabIndex = 37
        txtSubtotal1.Text = "0.00"
        txtSubtotal1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(31, 137)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(143, 31)
        Label19.TabIndex = 23
        Label19.Text = "12% TAX :"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(28, 28)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(145, 31)
        Label14.TabIndex = 22
        Label14.Text = "Sub Total :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(28, 83)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(197, 31)
        Label9.TabIndex = 18
        Label9.Text = "10% Discount :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(31, 200)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(147, 31)
        Label10.TabIndex = 19
        Label10.Text = "Total Due :"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1446, 126)
        Label1.TabIndex = 9
        Label1.Text = "Francheska Cosmetics POS System"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(txtcustomer)
        GroupBox1.Controls.Add(txtOR)
        GroupBox1.Controls.Add(txtinvoice)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.ForeColor = SystemColors.ControlLightLight
        GroupBox1.Location = New Point(881, 129)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(565, 15)
        GroupBox1.TabIndex = 37
        GroupBox1.TabStop = False
        ' 
        ' txtcustomer
        ' 
        txtcustomer.BackColor = SystemColors.ControlLight
        txtcustomer.Enabled = False
        txtcustomer.Font = New Font("Microsoft Sans Serif", 8.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtcustomer.Location = New Point(131, 98)
        txtcustomer.Margin = New Padding(4, 5, 4, 5)
        txtcustomer.Name = "txtcustomer"
        txtcustomer.Size = New Size(419, 23)
        txtcustomer.TabIndex = 39
        ' 
        ' txtOR
        ' 
        txtOR.BackColor = SystemColors.ControlLight
        txtOR.Enabled = False
        txtOR.Font = New Font("Microsoft Sans Serif", 8.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtOR.Location = New Point(131, 58)
        txtOR.Margin = New Padding(4, 5, 4, 5)
        txtOR.Name = "txtOR"
        txtOR.Size = New Size(419, 23)
        txtOR.TabIndex = 38
        ' 
        ' txtinvoice
        ' 
        txtinvoice.BackColor = SystemColors.ControlLight
        txtinvoice.Enabled = False
        txtinvoice.Font = New Font("Microsoft Sans Serif", 8.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtinvoice.Location = New Point(131, 18)
        txtinvoice.Margin = New Padding(4, 5, 4, 5)
        txtinvoice.Name = "txtinvoice"
        txtinvoice.Size = New Size(419, 23)
        txtinvoice.TabIndex = 37
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 8.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(15, 103)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 17)
        Label7.TabIndex = 17
        Label7.Text = "Customer: "
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 8.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(15, 23)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(99, 17)
        Label15.TabIndex = 23
        Label15.Text = "Invoice No. :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 8.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = SystemColors.ActiveCaptionText
        Label16.Location = New Point(20, 63)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(71, 17)
        Label16.TabIndex = 24
        Label16.Text = "OR No. :"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1448, 128)
        Panel1.TabIndex = 35
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnFind)
        Panel2.Controls.Add(CheckBox2)
        Panel2.Controls.Add(CheckBox1)
        Panel2.Controls.Add(txtsubtotal)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(txttotalPrice)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(txtprice)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtdescription)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtqty)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtitemname)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(txtItemCode)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(dtgItems)
        Panel2.ForeColor = Color.Black
        Panel2.Location = New Point(0, 152)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(870, 662)
        Panel2.TabIndex = 36
        ' 
        ' btnFind
        ' 
        btnFind.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFind.Location = New Point(369, 18)
        btnFind.Margin = New Padding(4, 5, 4, 5)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(81, 40)
        btnFind.TabIndex = 39
        btnFind.Text = "Find"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox2.ForeColor = Color.Black
        CheckBox2.Location = New Point(19, 612)
        CheckBox2.Margin = New Padding(4, 5, 4, 5)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(116, 29)
        CheckBox2.TabIndex = 38
        CheckBox2.Text = "Add TAX"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.Black
        CheckBox1.Location = New Point(19, 577)
        CheckBox1.Margin = New Padding(4, 5, 4, 5)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(157, 29)
        CheckBox1.TabIndex = 37
        CheckBox1.Text = "Less Discount"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' txtsubtotal
        ' 
        txtsubtotal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtsubtotal.BackColor = SystemColors.ControlLightLight
        txtsubtotal.Enabled = False
        txtsubtotal.Font = New Font("Microsoft Sans Serif", 36.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtsubtotal.ForeColor = SystemColors.ActiveCaptionText
        txtsubtotal.Location = New Point(409, 562)
        txtsubtotal.Margin = New Padding(4, 5, 4, 5)
        txtsubtotal.Name = "txtsubtotal"
        txtsubtotal.Size = New Size(453, 75)
        txtsubtotal.TabIndex = 36
        txtsubtotal.Text = "0.00"
        txtsubtotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(199, 597)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(198, 42)
        Label13.TabIndex = 35
        Label13.Text = "Sub Total :"
        ' 
        ' txttotalPrice
        ' 
        txttotalPrice.BackColor = SystemColors.HighlightText
        txttotalPrice.Enabled = False
        txttotalPrice.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txttotalPrice.Location = New Point(623, 58)
        txttotalPrice.Margin = New Padding(4, 5, 4, 5)
        txttotalPrice.Name = "txttotalPrice"
        txttotalPrice.Size = New Size(219, 26)
        txttotalPrice.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(508, 66)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 20)
        Label6.TabIndex = 27
        Label6.Text = "Total Price:"
        ' 
        ' txtprice
        ' 
        txtprice.BackColor = SystemColors.HighlightText
        txtprice.Enabled = False
        txtprice.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtprice.Location = New Point(328, 66)
        txtprice.Margin = New Padding(4, 5, 4, 5)
        txtprice.Name = "txtprice"
        txtprice.Size = New Size(171, 26)
        txtprice.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(251, 69)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 25
        Label5.Text = "Price :"
        ' 
        ' txtdescription
        ' 
        txtdescription.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtdescription.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtdescription.BackColor = SystemColors.HighlightText
        txtdescription.Enabled = False
        txtdescription.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtdescription.Location = New Point(97, 103)
        txtdescription.Margin = New Padding(4, 5, 4, 5)
        txtdescription.Name = "txtdescription"
        txtdescription.Size = New Size(744, 26)
        txtdescription.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(4, 103)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 23
        Label2.Text = "Confirm :"
        ' 
        ' txtqty
        ' 
        txtqty.BackColor = SystemColors.HighlightText
        txtqty.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtqty.Location = New Point(97, 66)
        txtqty.Margin = New Padding(4, 5, 4, 5)
        txtqty.Name = "txtqty"
        txtqty.Size = New Size(144, 26)
        txtqty.TabIndex = 10
        txtqty.Text = "1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(21, 58)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 24)
        Label4.TabIndex = 9
        Label4.Text = "Qty."
        ' 
        ' txtitemname
        ' 
        txtitemname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtitemname.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtitemname.BackColor = SystemColors.HighlightText
        txtitemname.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtitemname.Location = New Point(97, 23)
        txtitemname.Margin = New Padding(4, 5, 4, 5)
        txtitemname.Name = "txtitemname"
        txtitemname.Size = New Size(264, 26)
        txtitemname.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(8, 23)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 20)
        Label8.TabIndex = 7
        Label8.Text = "Product :"
        ' 
        ' txtItemCode
        ' 
        txtItemCode.BackColor = SystemColors.HighlightText
        txtItemCode.Enabled = False
        txtItemCode.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtItemCode.Location = New Point(623, 18)
        txtItemCode.Margin = New Padding(4, 5, 4, 5)
        txtItemCode.Name = "txtItemCode"
        txtItemCode.Size = New Size(219, 26)
        txtItemCode.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(480, 23)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 20)
        Label3.TabIndex = 2
        Label3.Text = "Product Code :"
        ' 
        ' dtgItems
        ' 
        dtgItems.AllowUserToAddRows = False
        dtgItems.AllowUserToDeleteRows = False
        dtgItems.AllowUserToOrderColumns = True
        dtgItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtgItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dtgItems.Location = New Point(4, 149)
        dtgItems.Margin = New Padding(4, 5, 4, 5)
        dtgItems.Name = "dtgItems"
        dtgItems.ReadOnly = True
        dtgItems.RowHeadersVisible = False
        dtgItems.RowHeadersWidth = 51
        dtgItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgItems.Size = New Size(860, 409)
        dtgItems.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Item Code"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Description"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 230
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight
        Column3.DefaultCellStyle = DataGridViewCellStyle4
        Column3.HeaderText = "QTY."
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 60
        ' 
        ' Column4
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight
        Column4.DefaultCellStyle = DataGridViewCellStyle5
        Column4.HeaderText = "Price"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight
        Column5.DefaultCellStyle = DataGridViewCellStyle6
        Column5.HeaderText = "Total"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 150
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.Bottom
        ToolStrip1.Font = New Font("Segoe UI", 12.0F)
        ToolStrip1.ImageScalingSize = New Size(50, 50)
        ToolStrip1.Items.AddRange(New ToolStripItem() {tsSave, tsPayment, tsNew, tsRemove, ToolStripSeparator1, LBLCASHIER, ToolStripSeparator2, ToolStripLabel2, lbldate, ToolStripSeparator3, ToolStripLabel3, lbltime})
        ToolStrip1.Location = New Point(0, 820)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1448, 31)
        ToolStrip1.TabIndex = 40
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' tsSave
        ' 
        tsSave.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsSave.ImageTransparentColor = Color.Magenta
        tsSave.Name = "tsSave"
        tsSave.Size = New Size(29, 28)
        tsSave.Text = "Save"
        ' 
        ' tsPayment
        ' 
        tsPayment.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsPayment.ImageTransparentColor = Color.Magenta
        tsPayment.Name = "tsPayment"
        tsPayment.Size = New Size(29, 28)
        tsPayment.Text = "Recieve Payment"
        ' 
        ' tsNew
        ' 
        tsNew.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsNew.ImageTransparentColor = Color.Magenta
        tsNew.Name = "tsNew"
        tsNew.Size = New Size(29, 28)
        tsNew.Text = "New"
        ' 
        ' tsRemove
        ' 
        tsRemove.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsRemove.ImageTransparentColor = Color.Magenta
        tsRemove.Name = "tsRemove"
        tsRemove.Size = New Size(29, 28)
        tsRemove.Text = "Void"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 31)
        ' 
        ' LBLCASHIER
        ' 
        LBLCASHIER.Name = "LBLCASHIER"
        LBLCASHIER.Size = New Size(60, 28)
        LBLCASHIER.Text = "None"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 31)
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(62, 28)
        ToolStripLabel2.Text = "Date :"
        ' 
        ' lbldate
        ' 
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(126, 28)
        lbldate.Text = "mm/dd/yyyy"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 31)
        ' 
        ' ToolStripLabel3
        ' 
        ToolStripLabel3.Name = "ToolStripLabel3"
        ToolStripLabel3.Size = New Size(63, 28)
        ToolStripLabel3.Text = "Time :"
        ' 
        ' lbltime
        ' 
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(92, 28)
        lbltime.Text = "hh:mm:ss"
        ' 
        ' POSForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1448, 851)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(ToolStrip1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "POSForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POS"
        Panel4.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dtgItems, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents txtAmountRecieve As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcustomer As TextBox
    Friend WithEvents txtOR As TextBox
    Friend WithEvents txtinvoice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtTotalDue As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents txtSubtotal1 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFind As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txttotalPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtitemname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgItems As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsSave As ToolStripButton
    Friend WithEvents tsNew As ToolStripButton
    Friend WithEvents tsPayment As ToolStripButton
    Friend WithEvents tsRemove As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LBLCASHIER As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lbldate As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents lbltime As ToolStripLabel
End Class
