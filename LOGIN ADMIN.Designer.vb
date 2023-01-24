<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN_ADMIN
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN_ADMIN))
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.rfid = New System.Windows.Forms.TextBox()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("MS Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(40, 35)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(213, 29)
        Me.Guna2HtmlLabel3.TabIndex = 10
        Me.Guna2HtmlLabel3.Text = "SERVICE FINDER"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderRadius = 50
        Me.Guna2GroupBox2.BorderThickness = 3
        Me.Guna2GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Button5)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Button8)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox2.Controls.Add(Me.PictureBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.PictureBox2)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("MS Gothic", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(435, 152)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.BorderRadius = 50
        Me.Guna2GroupBox2.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2GroupBox2.ShadowDecoration.Depth = 50
        Me.Guna2GroupBox2.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(368, 414)
        Me.Guna2GroupBox2.TabIndex = 6
        Me.Guna2GroupBox2.Text = "Login Admin"
        Me.Guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2GroupBox2.TextOffset = New System.Drawing.Point(0, 46)
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(212, 378)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(47, 20)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Here"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(88, 376)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(127, 22)
        Me.Guna2HtmlLabel2.TabIndex = 12
        Me.Guna2HtmlLabel2.Text = "Register admin"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.BorderRadius = 10
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.DisabledState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button5.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button5.Location = New System.Drawing.Point(49, 328)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.BorderRadius = 10
        Me.Guna2Button5.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button5.ShadowDecoration.Depth = 50
        Me.Guna2Button5.ShadowDecoration.Enabled = True
        Me.Guna2Button5.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Button5.Size = New System.Drawing.Size(278, 38)
        Me.Guna2Button5.TabIndex = 11
        Me.Guna2Button5.Text = "Tap RFID for automatic login"
        '
        'Guna2Button8
        '
        Me.Guna2Button8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button8.BorderRadius = 10
        Me.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button8.DisabledState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2Button8.ForeColor = System.Drawing.Color.White
        Me.Guna2Button8.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button8.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button8.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button8.Location = New System.Drawing.Point(77, 251)
        Me.Guna2Button8.Name = "Guna2Button8"
        Me.Guna2Button8.ShadowDecoration.BorderRadius = 10
        Me.Guna2Button8.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button8.ShadowDecoration.Depth = 50
        Me.Guna2Button8.ShadowDecoration.Enabled = True
        Me.Guna2Button8.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Button8.Size = New System.Drawing.Size(219, 38)
        Me.Guna2Button8.TabIndex = 2
        Me.Guna2Button8.Text = "LOGIN"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Lucida Bright", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(159, 289)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(32, 33)
        Me.Guna2HtmlLabel1.TabIndex = 9
        Me.Guna2HtmlLabel1.Text = "or"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = Global.SERVICE_FINDER.My.Resources.Resources.Computer_Icons_User_profile__avatar_transparent_background_PNG_clipart
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 176)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ErrorImage = Global.SERVICE_FINDER.My.Resources.Resources.Computer_Icons_User_profile__avatar_transparent_background_PNG_clipart
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(49, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BackgroundImage = CType(resources.GetObject("Guna2TextBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.BorderThickness = 0
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.CustomizableEdges.BottomLeft = False
        Me.Guna2TextBox1.CustomizableEdges.TopRight = False
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.Guna2TextBox1.HoverState.FillColor = System.Drawing.Color.Teal
        Me.Guna2TextBox1.Location = New System.Drawing.Point(102, 182)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.PlaceholderText = "Password"
        Me.Guna2TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.BorderRadius = 10
        Me.Guna2TextBox1.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2TextBox1.ShadowDecoration.CustomizableEdges.BottomLeft = False
        Me.Guna2TextBox1.ShadowDecoration.CustomizableEdges.BottomRight = False
        Me.Guna2TextBox1.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.Guna2TextBox1.ShadowDecoration.CustomizableEdges.TopRight = False
        Me.Guna2TextBox1.ShadowDecoration.Depth = 100
        Me.Guna2TextBox1.ShadowDecoration.Enabled = True
        Me.Guna2TextBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2TextBox1.Size = New System.Drawing.Size(220, 37)
        Me.Guna2TextBox1.TabIndex = 1
        Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(5, 0)
        Me.Guna2TextBox1.UseSystemPasswordChar = True
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Guna2TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox2.BorderThickness = 0
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.CustomizableEdges.BottomLeft = False
        Me.Guna2TextBox2.CustomizableEdges.TopRight = False
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.Guna2TextBox2.HoverState.FillColor = System.Drawing.Color.Teal
        Me.Guna2TextBox2.Location = New System.Drawing.Point(102, 127)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.White
        Me.Guna2TextBox2.PlaceholderText = "Username"
        Me.Guna2TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.BorderRadius = 0
        Me.Guna2TextBox2.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2TextBox2.ShadowDecoration.CustomizableEdges.BottomLeft = False
        Me.Guna2TextBox2.ShadowDecoration.CustomizableEdges.BottomRight = False
        Me.Guna2TextBox2.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.Guna2TextBox2.ShadowDecoration.CustomizableEdges.TopRight = False
        Me.Guna2TextBox2.ShadowDecoration.Depth = 100
        Me.Guna2TextBox2.ShadowDecoration.Enabled = True
        Me.Guna2TextBox2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2TextBox2.Size = New System.Drawing.Size(220, 37)
        Me.Guna2TextBox2.TabIndex = 0
        Me.Guna2TextBox2.TextOffset = New System.Drawing.Point(5, 0)
        '
        'BackgroundWorker1
        '
        '
        'rfid
        '
        Me.rfid.Location = New System.Drawing.Point(162, 421)
        Me.rfid.Name = "rfid"
        Me.rfid.Size = New System.Drawing.Size(100, 20)
        Me.rfid.TabIndex = 11
        Me.rfid.Visible = False
        '
        'Timer1
        '
        '
        'LOGIN_ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1201, 691)
        Me.Controls.Add(Me.rfid)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LOGIN_ADMIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator"
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents rfid As TextBox
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
End Class
