<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepresenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeadPeopleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "About Us"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(583, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "We are company that serve people to bury their loved ones "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(761, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "in peace without making long time movement and consume less time because "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(439, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "you will be able to make reservation of grave"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.RepresenterToolStripMenuItem, Me.DeadPeopleToolStripMenuItem, Me.RegistrantsToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'RepresenterToolStripMenuItem
        '
        Me.RepresenterToolStripMenuItem.Name = "RepresenterToolStripMenuItem"
        Me.RepresenterToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.RepresenterToolStripMenuItem.Text = "Representer"
        '
        'DeadPeopleToolStripMenuItem
        '
        Me.DeadPeopleToolStripMenuItem.Name = "DeadPeopleToolStripMenuItem"
        Me.DeadPeopleToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.DeadPeopleToolStripMenuItem.Text = "Dead People"
        '
        'RegistrantsToolStripMenuItem
        '
        Me.RegistrantsToolStripMenuItem.Name = "RegistrantsToolStripMenuItem"
        Me.RegistrantsToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.RegistrantsToolStripMenuItem.Text = "Registrants"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "about"
        Me.Text = "about"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepresenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeadPeopleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
End Class
