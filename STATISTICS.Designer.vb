<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class STATISTICS
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(STATISTICS))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button11 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button9 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button10 = New Guna.UI2.WinForms.Guna2Button()
        Me.ComboBox3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(777, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "CITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(539, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "PROVINCE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(218, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "REGION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(563, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 23
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
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.IsClustered = True
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.Area3DStyle.PointGapDepth = 150
        ChartArea2.Area3DStyle.WallWidth = 10
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = 60
        ChartArea2.AxisX.LabelStyle.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisX.LabelStyle.Interval = 1.0R
        ChartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight
        ChartArea2.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No
        ChartArea2.AxisY.Interval = 5.0R
        ChartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.BackColor = System.Drawing.Color.White
        ChartArea2.BackImage = "C:\Users\Administrator\Downloads\C9B7CD1C-C78F-460E-B6F9-E0F47CD86DCA.jpeg"
        ChartArea2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left
        ChartArea2.BorderColor = System.Drawing.Color.White
        ChartArea2.IsSameFontSizeForAllAxes = True
        ChartArea2.Name = "ChartArea1"
        ChartArea2.ShadowColor = System.Drawing.Color.White
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Default
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(211, 130)
        Me.Chart1.Name = "Chart1"
        Series5.ChartArea = "ChartArea1"
        Series5.CustomProperties = "PointWidth=1"
        Series5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series5.IsValueShownAsLabel = True
        Series5.LabelBackColor = System.Drawing.Color.LightCyan
        Series5.Legend = "Legend1"
        Series5.Name = "NUMBER OF CLIENTS"
        Series5.YValuesPerPoint = 4
        Series6.ChartArea = "ChartArea1"
        Series6.CustomProperties = "PointWidth=1"
        Series6.EmptyPointStyle.AxisLabel = "NO DATA"
        Series6.EmptyPointStyle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series6.IsValueShownAsLabel = True
        Series6.LabelBackColor = System.Drawing.Color.LightCyan
        Series6.Legend = "Legend1"
        Series6.LegendText = "NUMBER OF VERIFIED USER"
        Series6.Name = "NUMBER OF VERIFIED USER"
        Series6.YValuesPerPoint = 4
        Series7.ChartArea = "ChartArea1"
        Series7.CustomProperties = "PointWidth=1"
        Series7.EmptyPointStyle.AxisLabel = "NO DATA"
        Series7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series7.IsValueShownAsLabel = True
        Series7.LabelBackColor = System.Drawing.Color.LightCyan
        Series7.Legend = "Legend1"
        Series7.Name = "DENIED USERS"
        Series7.YValuesPerPoint = 4
        Series8.ChartArea = "ChartArea1"
        Series8.CustomProperties = "PointWidth=1"
        Series8.EmptyPointStyle.AxisLabel = "NO DATA"
        Series8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series8.IsValueShownAsLabel = True
        Series8.LabelBackColor = System.Drawing.Color.LightCyan
        Series8.Legend = "Legend1"
        Series8.Name = "NOT YET REVIEWED"
        Series8.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Size = New System.Drawing.Size(990, 561)
        Me.Chart1.TabIndex = 33
        Me.Chart1.Text = "Chart1"
        Title2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top
        Title2.Font = New System.Drawing.Font("Rockwell", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.ShadowColor = System.Drawing.Color.White
        Title2.Text = "USERS STATISTICS"
        Title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart1.Titles.Add(Title2)
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2GroupBox1.BorderThickness = 0
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button11)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button6)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button5)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 0
        Me.Guna2GroupBox1.ShadowDecoration.Depth = 50
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(209, 691)
        Me.Guna2GroupBox1.TabIndex = 51
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
        Me.Guna2Button11.Image = Global.SERVICE_FINDER.My.Resources.Resources.message_2_128
        Me.Guna2Button11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button11.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button11.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button11.Location = New System.Drawing.Point(1, 335)
        Me.Guna2Button11.Name = "Guna2Button11"
        Me.Guna2Button11.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button11.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button11.ShadowDecoration.Depth = 50
        Me.Guna2Button11.ShadowDecoration.Enabled = True
        Me.Guna2Button11.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button11.Size = New System.Drawing.Size(219, 38)
        Me.Guna2Button11.TabIndex = 6
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
        'Guna2Button6
        '
        Me.Guna2Button6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button6.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button6.Image = CType(resources.GetObject("Guna2Button6.Image"), System.Drawing.Image)
        Me.Guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button6.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.Guna2Button6.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button6.Location = New System.Drawing.Point(0, 653)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button6.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.Guna2Button6.ShadowDecoration.Depth = 50
        Me.Guna2Button6.ShadowDecoration.Enabled = True
        Me.Guna2Button6.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button6.Size = New System.Drawing.Size(209, 38)
        Me.Guna2Button6.TabIndex = 0
        Me.Guna2Button6.Text = "Logout Admin"
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
        Me.Guna2Button5.Location = New System.Drawing.Point(0, 291)
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
        Me.Guna2Button4.Location = New System.Drawing.Point(1, 247)
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button9)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button10)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, -6)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Depth = 50
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1201, 60)
        Me.Guna2Panel1.TabIndex = 52
        '
        'Guna2Button9
        '
        Me.Guna2Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button9.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Button9.DisabledState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button9.DisabledState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2Button9.Enabled = False
        Me.Guna2Button9.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Button9.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button9.ForeColor = System.Drawing.Color.White
        Me.Guna2Button9.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button9.Image = CType(resources.GetObject("Guna2Button9.Image"), System.Drawing.Image)
        Me.Guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button9.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button9.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button9.Location = New System.Drawing.Point(353, 7)
        Me.Guna2Button9.Name = "Guna2Button9"
        Me.Guna2Button9.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button9.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button9.ShadowDecoration.Depth = 50
        Me.Guna2Button9.ShadowDecoration.Enabled = True
        Me.Guna2Button9.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.Guna2Button9.Size = New System.Drawing.Size(249, 46)
        Me.Guna2Button9.TabIndex = 56
        Me.Guna2Button9.Text = "Users Statistics"
        '
        'Guna2Button10
        '
        Me.Guna2Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button10.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2Button10.DisabledState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button10.DisabledState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.Guna2Button10.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2Button10.Font = New System.Drawing.Font("Rockwell", 10.0!)
        Me.Guna2Button10.ForeColor = System.Drawing.Color.White
        Me.Guna2Button10.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button10.Image = CType(resources.GetObject("Guna2Button10.Image"), System.Drawing.Image)
        Me.Guna2Button10.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button10.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.Guna2Button10.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button10.Location = New System.Drawing.Point(598, 7)
        Me.Guna2Button10.Name = "Guna2Button10"
        Me.Guna2Button10.ShadowDecoration.BorderRadius = 0
        Me.Guna2Button10.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2Button10.ShadowDecoration.Depth = 50
        Me.Guna2Button10.ShadowDecoration.Enabled = True
        Me.Guna2Button10.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Button10.Size = New System.Drawing.Size(249, 46)
        Me.Guna2Button10.TabIndex = 57
        Me.Guna2Button10.Text = "Posts Statistics"
        '
        'ComboBox3
        '
        Me.ComboBox3.AllowDrop = True
        Me.ComboBox3.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox3.DropDownHeight = 200
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.DropDownWidth = 50
        Me.ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox3.ForeColor = System.Drawing.Color.Black
        Me.ComboBox3.IntegralHeight = False
        Me.ComboBox3.ItemHeight = 30
        Me.ComboBox3.ItemsAppearance.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(781, 67)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(240, 36)
        Me.ComboBox3.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.AllowDrop = True
        Me.ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox2.DropDownHeight = 200
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.IntegralHeight = False
        Me.ComboBox2.ItemHeight = 30
        Me.ComboBox2.ItemsAppearance.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(543, 67)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(232, 36)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownHeight = 200
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.ItemHeight = 30
        Me.ComboBox1.ItemsAppearance.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(218, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(319, 36)
        Me.ComboBox1.TabIndex = 0
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(1027, 67)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(82, 54)
        Me.Guna2ImageButton1.TabIndex = 53
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'BackgroundWorker3
        '
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Meiryo UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(548, 430)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(127, 27)
        Me.Guna2HtmlLabel7.TabIndex = 73
        Me.Guna2HtmlLabel7.Text = "Please Wait"
        Me.Guna2HtmlLabel7.Visible = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.SERVICE_FINDER.My.Resources.Resources.output_onlinegiftools
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(507, 260)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(199, 170)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 72
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.Visible = False
        '
        'BackgroundWorker4
        '
        '
        'STATISTICS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1201, 691)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "STATISTICS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ComboBox3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button9 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button10 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button11 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
End Class
