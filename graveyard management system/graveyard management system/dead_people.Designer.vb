<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dead_people
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepresenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeadPeopleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dod = New System.Windows.Forms.DateTimePicker()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.sname = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Registration = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.RepresenterToolStripMenuItem, Me.DeadPeopleToolStripMenuItem, Me.RegistrantsToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.dod)
        Me.Panel1.Controls.Add(Me.dob)
        Me.Panel1.Controls.Add(Me.sname)
        Me.Panel1.Controls.Add(Me.fname)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Registration)
        Me.Panel1.Location = New System.Drawing.Point(388, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 341)
        Me.Panel1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Female", "Male"})
        Me.ComboBox1.Location = New System.Drawing.Point(163, 209)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.Text = "Select Gender"
        '
        'dod
        '
        Me.dod.Location = New System.Drawing.Point(163, 164)
        Me.dod.Name = "dod"
        Me.dod.Size = New System.Drawing.Size(196, 20)
        Me.dod.TabIndex = 13
        '
        'dob
        '
        Me.dob.Location = New System.Drawing.Point(163, 119)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(196, 20)
        Me.dob.TabIndex = 12
        '
        'sname
        '
        Me.sname.Location = New System.Drawing.Point(163, 76)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(196, 20)
        Me.sname.TabIndex = 8
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(163, 50)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(196, 20)
        Me.fname.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(163, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Death"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Second Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Registration
        '
        Me.Registration.AutoSize = True
        Me.Registration.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registration.Location = New System.Drawing.Point(139, 12)
        Me.Registration.Name = "Registration"
        Me.Registration.Size = New System.Drawing.Size(223, 24)
        Me.Registration.TabIndex = 0
        Me.Registration.Text = "Dead People Registration"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(360, 341)
        Me.DataGridView1.TabIndex = 4
        '
        'dead_people
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.graveyard_management_system.My.Resources.Resources.heaven
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "dead_people"
        Me.Text = "dead_people"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepresenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeadPeopleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents dod As DateTimePicker
    Friend WithEvents dob As DateTimePicker
    Friend WithEvents sname As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Registration As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
