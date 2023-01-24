<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class STATISTICS_POSTS
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(STATISTICS_POSTS))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button11 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Gainsboro
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.Maroon
        Me.Chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        Me.Chart1.BorderSkin.BorderWidth = 2
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.PointDepth = 30
        ChartArea1.Area3DStyle.PointGapDepth = 30
        ChartArea1.Area3DStyle.WallWidth = 10
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.LabelStyle.Angle = 50
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.Interval = 1.0R
        ChartArea1.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight
        ChartArea1.AxisY.Interval = 4.0R
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(2, 78)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "PointWidth=0.7"
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = System.Drawing.Color.LightCyan
        Series1.LabelBorderColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Number of Post"
        Series1.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(971, 538)
        Me.Chart1.TabIndex = 46
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Title1"
        Title1.Text = "POSTS"
        Me.Chart1.Titles.Add(Title1)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel3.Controls.Add(Me.Guna2ComboBox1)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Chart1)
        Me.Panel3.Location = New System.Drawing.Point(216, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(985, 622)
        Me.Panel3.TabIndex = 49
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(264, 45)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(165, 22)
        Me.Guna2HtmlLabel3.TabIndex = 62
        Me.Guna2HtmlLabel3.Text = "CHOOSE CATEGORY"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.Enabled = False
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.ItemsAppearance.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(258, 3)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(236, 36)
        Me.Guna2ComboBox1.TabIndex = 61
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(9, 45)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(116, 22)
        Me.Guna2HtmlLabel2.TabIndex = 60
        Me.Guna2HtmlLabel2.Text = "TYPE OF POST"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.ItemHeight = 30
        Me.ComboBox1.Items.AddRange(New Object() {"SERVICE POSTED", "FINDING SERVICE"})
        Me.ComboBox1.ItemsAppearance.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.Location = New System.Drawing.Point(3, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 36)
        Me.ComboBox1.TabIndex = 57
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2GroupBox1.BorderThickness = 0
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button11)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button6)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button5)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 0
        Me.Guna2GroupBox1.ShadowDecoration.Depth = 50
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(209, 719)
        Me.Guna2GroupBox1.TabIndex = 52
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2GroupBox1.TextOffset = New System.Drawing.Point(0, 10)
        '
        'Guna2Button11
        '
        Me.Guna2Button11.BackColor = System.Drawing.Color.White
        Me.Guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button11.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button11.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button11.ForeColor = System.Drawing.Color.White
        Me.Guna2Button11.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button11.Image = CType(resources.GetObject("Guna2Button11.Image"), System.Drawing.Image)
        Me.Guna2Button11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button11.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button11.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button11.Location = New System.Drawing.Point(0, 337)
        Me.Guna2Button11.Name = "Guna2Button11"
        Me.Guna2Button11.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button11.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button11.ShadowDecoration.Depth = 50
        Me.Guna2Button11.ShadowDecoration.Enabled = True
        Me.Guna2Button11.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button11.Size = New System.Drawing.Size(219, 38)
        Me.Guna2Button11.TabIndex = 5
        Me.Guna2Button11.Text = "Messages"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(56, 84)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(92, 73)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(25, 22)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(149, 35)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "Dashboard"
        '
        'Guna2Button6
        '
        Me.Guna2Button6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button6.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button6.Image = CType(resources.GetObject("Guna2Button6.Image"), System.Drawing.Image)
        Me.Guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button6.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.Guna2Button6.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button6.Location = New System.Drawing.Point(0, 681)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button6.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.Guna2Button6.ShadowDecoration.Depth = 50
        Me.Guna2Button6.ShadowDecoration.Enabled = True
        Me.Guna2Button6.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button6.Size = New System.Drawing.Size(221, 38)
        Me.Guna2Button6.TabIndex = 0
        Me.Guna2Button6.Text = "Logout Admin"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.BackColor = System.Drawing.Color.White
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button5.Image = CType(resources.GetObject("Guna2Button5.Image"), System.Drawing.Image)
        Me.Guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button5.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button5.Location = New System.Drawing.Point(-1, 293)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button5.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button5.ShadowDecoration.Depth = 50
        Me.Guna2Button5.ShadowDecoration.Enabled = True
        Me.Guna2Button5.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button5.Size = New System.Drawing.Size(219, 38)
        Me.Guna2Button5.TabIndex = 0
        Me.Guna2Button5.Text = "Posts"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BackColor = System.Drawing.Color.White
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button4.Image = CType(resources.GetObject("Guna2Button4.Image"), System.Drawing.Image)
        Me.Guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button4.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button4.Location = New System.Drawing.Point(0, 249)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button4.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button4.ShadowDecoration.Depth = 50
        Me.Guna2Button4.ShadowDecoration.Enabled = True
        Me.Guna2Button4.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button4.Size = New System.Drawing.Size(219, 38)
        Me.Guna2Button4.TabIndex = 0
        Me.Guna2Button4.Text = "Categories / Services"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.White
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button2.Location = New System.Drawing.Point(-1, 205)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button2.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button2.ShadowDecoration.Depth = 50
        Me.Guna2Button2.ShadowDecoration.Enabled = True
        Me.Guna2Button2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button2.Size = New System.Drawing.Size(219, 38)
        Me.Guna2Button2.TabIndex = 0
        Me.Guna2Button2.Text = "Verification Requests"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.White
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.DisabledState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2Button1.Enabled = False
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 161)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button1.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button1.ShadowDecoration.Depth = 50
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button1.Size = New System.Drawing.Size(219, 38)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Statistics"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button7)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button8)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Depth = 50
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Panel2.Size = New System.Drawing.Size(1201, 60)
        Me.Guna2Panel2.TabIndex = 53
        '
        'Guna2Button7
        '
        Me.Guna2Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.DisabledState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2Button7.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button7.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button7.Image = CType(resources.GetObject("Guna2Button7.Image"), System.Drawing.Image)
        Me.Guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button7.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button7.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button7.Location = New System.Drawing.Point(353, 0)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button7.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button7.ShadowDecoration.Depth = 50
        Me.Guna2Button7.ShadowDecoration.Enabled = True
        Me.Guna2Button7.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2Button7.Size = New System.Drawing.Size(249, 53)
        Me.Guna2Button7.TabIndex = 54
        Me.Guna2Button7.Text = "Users Statistics"
        '
        'Guna2Button8
        '
        Me.Guna2Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button8.DisabledState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.Guna2Button8.Enabled = False
        Me.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Button8.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button8.ForeColor = System.Drawing.Color.White
        Me.Guna2Button8.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button8.Image = CType(resources.GetObject("Guna2Button8.Image"), System.Drawing.Image)
        Me.Guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button8.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button8.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button8.Location = New System.Drawing.Point(598, 0)
        Me.Guna2Button8.Name = "Guna2Button8"
        Me.Guna2Button8.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button8.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button8.ShadowDecoration.Depth = 50
        Me.Guna2Button8.ShadowDecoration.Enabled = True
        Me.Guna2Button8.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Button8.Size = New System.Drawing.Size(249, 53)
        Me.Guna2Button8.TabIndex = 55
        Me.Guna2Button8.Text = "Posts Statistics"
        '
        'STATISTISC_POSTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1201, 719)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "STATISTISC_POSTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STATISTISC_POSTS"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button11 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
End Class
