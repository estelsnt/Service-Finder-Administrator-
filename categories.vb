Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Threading
Public Class categories
    Public server As String
    Public port As String
    Public userid As String
    Public password As String
    Public database As String
    Public stat As Integer
    Dim conn As New MySqlConnection
    Dim cnstr As String = "server=sql608.main-hosting.eu; User ID=u305527491_ServiceFinder; password=ServiceFinder1234; database=u305527491_ServiceFinder"
    'Dim cnstr1 As String = "data source =  localhost; user id = root; database = sfa;"
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim itemcol(99) As String
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        STATISTICS.Show()
        Me.Close()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Category.Text.Length < 5 Then
            MsgBox("The category name is invalid")
            Category.Clear()
        Else

            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql1 As String = "INSERT INTO servicecategory (categoryName) VALUES (@categoryName)"
                cmd = New MySqlCommand(sql1, conn)
                cmd.Parameters.AddWithValue("@categoryName", Category.Text)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("CATEGORY IS ADDED")
                    MsgBox("PLEASE ADD SERVICE TO THE CATEGORY: " + Category.Text)
                    Label4.Text = Category.Text
                    Guna2GroupBox3.Visible = True
                    ListView2.Visible = False
                    Label33.Visible = False
                    Guna2GroupBox2.Visible = False
                    Try
                        conn = New MySqlConnection(cnstr)
                        conn.Open()
                        Dim sql As String = "SELECT serviceCategoryID FROM servicecategory where categoryName =  '" + Label4.Text + "'  "
                        cmd = New MySqlCommand(sql, conn)
                        Dim myreader As MySqlDataReader = cmd.ExecuteReader
                        While myreader.Read
                            tempservicecategoryid = myreader.GetString("servicecategoryID")
                        End While
                        conn.Close()
                    Catch ex As Exception

                    End Try

                    Guna2GroupBox3.Enabled = True
                Else
                    MsgBox("CATEGORY CAN'T BE ADDED")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("CATEGORY CAN'T BE ADDED BECAUSE: " + ex.Message)
            End Try

        End If

    End Sub
    Dim tempservicecategoryid As Integer
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ServiceName.Text.Length < 4 Or ServiceDescription.Text.Length < 4 Then
            MsgBox("The category name is invalid")
            ServiceName.Clear()
            ServiceDescription.Clear()
        Else

            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "INSERT INTO service (serviceCategoryID,serviceName,serviceDescription) VALUES (@serviceCategoryID,@serviceName,@serviceDescription)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@serviceCategoryID", tempservicecategoryid)
                cmd.Parameters.AddWithValue("@serviceName", ServiceName.Text)
                cmd.Parameters.AddWithValue("@serviceDescription", ServiceDescription.Text)
                Dim j As Integer = cmd.ExecuteNonQuery
                If j > 0 Then
                    MsgBox("SERVICE HAS BEEN ADDED")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Service Can't Be Added" + ex.Message)
            End Try
            Dim result As DialogResult = MessageBox.Show("ADD MORE SERVICE?", "SYSTEM", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ServiceName.Text = ""
                ServiceDescription.Text = ""
            ElseIf result = DialogResult.No Then
                Category.Clear()
                ServiceName.Clear()
                ServiceDescription.Clear()
                ListView2.Visible = True
                Label4.Text = "Category Name"
                Label33.Visible = True
                Guna2GroupBox3.Visible = False
                Guna2GroupBox2.Visible = True
                Guna2HtmlLabel4.Visible = True
                Guna2PictureBox3.Visible = True
                BackgroundWorker1.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT serviceCategoryID FROM servicecategory where categoryName =  '" + ComboBox1.SelectedItem + "'  "
            cmd = New MySqlCommand(sql, conn)
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            While myreader.Read
                tempservicecategoryid = myreader.GetString("servicecategoryID")
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox3.Enabled = True
        TextBox2.Enabled = True
        Label6.Text = ComboBox1.SelectedItem
        Panel6.Enabled = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Call PROCESS_VERIFICATION.allrecords()
        PROCESS_VERIFICATION.Show()
        Me.Close()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Post.Show()
        Me.Close()
    End Sub
    Private Sub categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False
        Call quee1()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


        Guna2GroupBox2.Enabled = True
        Call quee1()

    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox3.TextLength < 4 Or TextBox2.TextLength < 4 Then
            MsgBox("Please enter valid data")
            TextBox3.Clear()
            TextBox2.Clear()

        Else
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "INSERT INTO service (serviceCategoryID,serviceName,serviceDescription) VALUES (@serviceCategoryID,@serviceName,@serviceDescription)"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@serviceCategoryID", tempservicecategoryid)
                cmd.Parameters.AddWithValue("@serviceName", TextBox3.Text)
                cmd.Parameters.AddWithValue("@serviceDescription", TextBox2.Text)
                Dim j As Integer = cmd.ExecuteNonQuery
                If j > 0 Then
                    MsgBox("SERVICE HAS BEEN ADDED")
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Service Cant't Be Added Error: " + ex.Message)
            End Try
            Dim result As DialogResult = MessageBox.Show("ADD MORE SERVICE?", "SYSTEM", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                TextBox2.Text = ""
                TextBox3.Text = ""
            ElseIf result = DialogResult.No Then
                ComboBox1.SelectedIndex = -1
                Label6.Text = "Category Name"
                TextBox2.Clear()
                TextBox3.Clear()
                Panel6.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Call quee()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Label10.Text = ListView1.Items(ListView1.SelectedIndices(0)).Text
        End If
        Panel3.Enabled = True
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If newcategory.Text.Length < 5 Then
            newcategory.Clear()
            MsgBox("Data is invalid")
        Else
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "UPDATE servicecategory SET categoryName = '" + newcategory.Text + "' WHERE categoryName = '" + Label10.Text + "'"
                cmd = New MySqlCommand(sql, conn)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("CATEGORY NAME UPDATED")
                End If
                Call quee()
                conn.Close()
            Catch ex As Exception
                MsgBox("Changes are not valid!! error: " + ex.Message)
            End Try
            newcategory.Clear()
            Label10.Text = "Category"
            Panel3.Enabled = False
        End If
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        newcategory.Clear()
        Label10.Text = "Category"
        Panel3.Enabled = False
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Guna2GroupBox3.Visible = False
        ListView2.Visible = True
        Label33.Visible = True
        Guna2GroupBox2.Visible = True

        Guna2GroupBox3.Enabled = False
        ServiceName.Text = ""
        Label4.Text = ""
        Category.Clear()
        ServiceDescription.Text = ""
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.BackColor = Color.Black
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.BackColor = Color.Transparent
    End Sub
    Dim tempserviceid1 As String
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label11.Text = "Service Id"
        Panel11.Enabled = False
        TextBox4.Clear()
        TextBox1.Clear()
        Label29.Text = ComboBox2.SelectedItem
        ComboBox3.Items.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "Select servicecategoryID  FROM servicecategory WHERE categoryName = '" + Label29.Text + "' "
            cmd = New MySqlCommand(sql, conn)
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            While myreader.Read
                tempserviceid1 = myreader.GetString("servicecategoryID")
                Try
                    conn = New MySqlConnection(cnstr)
                    conn.Open()
                    Dim Sql1 As String = "SELECT serviceID,serviceName FROM service WHERE serviceCategoryID = '" + tempserviceid1 + "'"
                    cmd = New MySqlCommand(Sql1, conn)
                    Dim myreader1 As MySqlDataReader = cmd.ExecuteReader
                    While myreader1.Read
                        ComboBox3.Items.Add(myreader1.GetString("serviceName"))
                    End While
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Dim tempserviceID As String
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        TextBox4.Enabled = True
        TextBox1.Enabled = True
        Panel11.Enabled = True
        Try
            Dim ttext As String = ComboBox3.SelectedItem
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql1 As String = "SELECT serviceID FROM service WHERE serviceName = '" + ttext + "' "
            cmd = New MySqlCommand(sql1, conn)
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            While myreader.Read
                tempserviceID = myreader.GetString("serviceID")
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * FROM service WHERE serviceID = '" + tempserviceID + "' "
            cmd = New MySqlCommand(sql, conn)
            Dim myreader1 As MySqlDataReader = cmd.ExecuteReader
            While myreader1.Read
                Label11.Text = myreader1.GetString("serviceID")
                TextBox4.Text = myreader1.GetString("serviceName")
                TextBox1.Text = myreader1.GetString("serviceDescription")

            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox4.Text.Length < 4 Or TextBox1.Text.Length < 4 Then
            MsgBox("Please enter valid data")
        Else
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "UPDATE service SET serviceName = '" + TextBox4.Text + "' , serviceDescription = '" + TextBox1.Text + "'  WHERE serviceID = '" + Label11.Text + "'"
                cmd = New MySqlCommand(sql, conn)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("SERVICE DETAILS UPDATED")
                    Panel11.Enabled = False
                    Label29.Text = "Category Name"
                    Label11.Text = "Service ID"
                    TextBox4.Clear()
                    TextBox1.Clear()
                    ComboBox3.Items.Clear()
                    ComboBox3.Text = ""
                    ComboBox2.SelectedIndex = -1
                End If

                conn.Close()

            Catch ex As Exception
                MsgBox("Changes are not valid. error: " + ex.Message)
            End Try


        End If

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Post.Show()
        Me.Close()
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Call PROCESS_VERIFICATION.allrecords()
        PROCESS_VERIFICATION.Show()
        Me.Close()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        STATISTICS.Show()
        Me.Close()
    End Sub
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
        LOGIN_ADMIN.Show()
        Me.Close()
    End Sub
    Private Sub ServiceTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ServiceTabControl.SelectedIndexChanged
        ServiceTabControl.Enabled = False
        BackgroundWorker4.RunWorkerAsync()
    End Sub
    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        ServiceTabControl.Enabled = False
        BackgroundWorker3.RunWorkerAsync()
    End Sub
    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        CategoryTabControl.SendToBack()
        ServiceTabControl.BringToFront()
        Guna2Button8.FillColor = Guna2Button4.FillColor
        Guna2Button7.FillColor = Guna2Button2.FillColor
        ComboBox1.Items.Clear()
        ComboBox3.Items.Clear()
        Label29.Text = "Category Name"
        Label11.Text = "Service ID"
        TextBox4.Clear()
        TextBox1.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT categoryName FROM servicecategory "
            cmd = New MySqlCommand(sql, conn)
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            While myreader.Read
                ComboBox1.Items.Add(myreader.GetString("categoryName"))
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ComboBox2.Items.Clear()
        Label6.Text = "Category Name"
        TextBox2.Clear()
        TextBox3.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT categoryName FROM servicecategory "
            cmd = New MySqlCommand(sql, conn)
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            While myreader.Read
                ComboBox2.Items.Add(myreader.GetString("categoryName"))
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ServiceTabControl.Enabled = True
    End Sub
    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Guna2Button7.FillColor = Guna2Button4.FillColor
        Guna2Button8.FillColor = Guna2Button2.FillColor
        ServiceTabControl.SendToBack()
        CategoryTabControl.BringToFront()
        Guna2HtmlLabel4.BringToFront()
        Guna2PictureBox3.BringToFront()
        Guna2HtmlLabel2.BringToFront()
        Guna2PictureBox2.BringToFront()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        Category.Clear()
        ServiceName.Clear()
        ServiceDescription.Clear()
        Guna2GroupBox3.Enabled = False
        Label4.Text = "Category Name"
        Guna2GroupBox2.Enabled = True
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs)
        Category.Clear()
        ServiceName.Clear()
        ServiceDescription.Clear()
        Guna2GroupBox3.Enabled = False
        Label4.Text = "Category Name"
        Guna2GroupBox2.Enabled = True
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        MESSAGES.Show()
        Me.Close()
    End Sub

    Public r As Integer
    Public c As Integer
    Public Sub quee1()
        Guna2HtmlLabel4.Visible = True
        Guna2PictureBox3.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CategoryTabControl.Enabled = False
        ListView2.Items.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT categoryName FROM servicecategory ORDER BY categoryName ASC"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcol(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lvitems As New ListViewItem(itemcol)
                ListView2.Items.Add(lvitems)
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Guna2HtmlLabel4.Visible = False
        CategoryTabControl.Enabled = True
        Guna2PictureBox3.Visible = False
    End Sub
    Public Sub quee()
        Guna2PictureBox2.Visible = True
        Guna2HtmlLabel2.Visible = True
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        CategoryTabControl.Enabled = False
        ListView1.Items.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT categoryName FROM servicecategory where serviceCategoryID <> 1 ORDER BY categoryName ASC"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcol(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lvitems As New ListViewItem(itemcol)
                ListView1.Items.Add(lvitems)
            Next
            conn.Close()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Guna2PictureBox2.Visible = False
        Guna2HtmlLabel2.Visible = False
        CategoryTabControl.Enabled = True
    End Sub
    Private Sub CategoryTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryTabControl.SelectedIndexChanged
        If CategoryTabControl.SelectedTab Is TabPage1 Then
            BackgroundWorker2.CancelAsync()
            BackgroundWorker1.CancelAsync()
            Call quee1()
        ElseIf CategoryTabControl.SelectedTab Is TabPage2 Then
            BackgroundWorker1.CancelAsync()
            BackgroundWorker2.CancelAsync()
            Call quee()
        End If
    End Sub

    Private Sub Guna2Button6_Click_1(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        LOGIN_ADMIN.Show()
        Me.Close()
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        If ServiceTabControl.SelectedTab Is TabPage3 Then
            ComboBox1.Items.Clear()
            ComboBox1.ResetText()
            ComboBox3.Items.Clear()

            Label29.Text = "Category Name"
            Label11.Text = "Service ID"
            TextBox4.Clear()
            TextBox1.Clear()
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT categoryName FROM servicecategory "
                cmd = New MySqlCommand(sql, conn)
                Dim myreader As MySqlDataReader = cmd.ExecuteReader
                While myreader.Read
                    ComboBox1.Items.Add(myreader.GetString("categoryName"))
                End While
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ServiceTabControl.SelectedTab Is TabPage4 Then
            ComboBox1.Items.Clear()
            ComboBox1.ResetText()
            ComboBox2.Items.Clear()
            ComboBox2.ResetText()
            ComboBox3.Items.Clear()

            Label6.Text = "Category Name"
            TextBox2.Clear()
            TextBox3.Clear()
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT categoryName FROM servicecategory "
                cmd = New MySqlCommand(sql, conn)
                Dim myreader As MySqlDataReader = cmd.ExecuteReader
                While myreader.Read
                    ComboBox2.Items.Add(myreader.GetString("categoryName"))
                End While
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        ServiceTabControl.Enabled = True
    End Sub


End Class