<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accountant
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        ToolStrip1 = New ToolStrip()
        ToolStripButton2 = New ToolStripButton()
        ToolStripButton3 = New ToolStripButton()
        ToolStripButton4 = New ToolStripButton()
        Panel3 = New Panel()
        Panel2.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Desktop
        Panel1.Location = New Point(98, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(3, 1017)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ToolStrip1)
        Panel2.Location = New Point(1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(97, 1017)
        Panel2.TabIndex = 1
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.Fill
        ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton2, ToolStripButton3, ToolStripButton4})
        ToolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(97, 1017)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.AutoSize = False
        ToolStripButton2.BackgroundImageLayout = ImageLayout.Center
        ToolStripButton2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripButton2.Image = My.Resources.Resources.invetorylogo2
        ToolStripButton2.ImageScaling = ToolStripItemImageScaling.None
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(73, 80)
        ToolStripButton2.Text = "Inventory"
        ToolStripButton2.TextAlign = ContentAlignment.BottomCenter
        ToolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.AutoSize = False
        ToolStripButton3.BackgroundImageLayout = ImageLayout.Center
        ToolStripButton3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripButton3.Image = My.Resources.Resources.CategoryIcon1
        ToolStripButton3.ImageScaling = ToolStripItemImageScaling.None
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(73, 80)
        ToolStripButton3.Text = "Category"
        ToolStripButton3.TextAlign = ContentAlignment.BottomCenter
        ToolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripButton4
        ' 
        ToolStripButton4.AutoSize = False
        ToolStripButton4.BackgroundImageLayout = ImageLayout.Center
        ToolStripButton4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripButton4.ForeColor = SystemColors.ControlText
        ToolStripButton4.Image = My.Resources.Resources.reports1
        ToolStripButton4.ImageScaling = ToolStripItemImageScaling.None
        ToolStripButton4.ImageTransparentColor = Color.Magenta
        ToolStripButton4.Name = "ToolStripButton4"
        ToolStripButton4.Size = New Size(70, 85)
        ToolStripButton4.Text = "Reports"
        ToolStripButton4.TextAlign = ContentAlignment.BottomCenter
        ToolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.Location = New Point(101, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1466, 1017)
        Panel3.TabIndex = 2
        ' 
        ' Accountant
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Accountant"
        Text = "POS | Main"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Panel3 As Panel
End Class
