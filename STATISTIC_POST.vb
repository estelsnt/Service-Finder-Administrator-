Imports MySql.Data.MySqlClient
Public Class STATISTIC_POST
    Public server As String
    Public port As String
    Public userid As String
    Public password As String
    Public database As String
    Public stat As Integer
    Dim conn As MySqlConnection
    Dim cnstr As String = "server=sql608.main-hosting.eu; User ID=u305527491_ServiceFinder; password=ServiceFinder1234; database=u305527491_ServiceFinder"
    'Dim cnstr As String = "data source =  localhost; user id = root; database = sfa;"
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Public Sub Percategory()
        Chart1.Series("Number of Post").Points.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT categoryName FROM servicecategory  GROUP BY serviceCategoryID "
            cmd = New MySqlCommand(sql, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                If reader.GetString(0).ToString = "--Others--" Then

                Else
                    Guna2ComboBox1.Items.Add(reader.GetString(0))
                End If

            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Chart1.Series("Number of Post").Points.Clear()
        Guna2ComboBox1.Items.Clear()
        If ComboBox1.SelectedItem = "SERVICE POSTED" Then
            Chart1.Series("Number of Post").Points.Clear()
            Guna2ComboBox1.Enabled = True
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT count(servicecategory.servicecategoryid),servicecategory.categoryName FROM serviceposting LEFT JOIN service on serviceposting.serviceID = service.serviceID LEFT JOIN servicecategory ON servicecategory.servicecategoryID = service.servicecategoryID GROUP BY servicecategory.servicecategoryid;"
                cmd = New MySqlCommand(sql, conn)
                reader = cmd.ExecuteReader
                While reader.Read
                    Chart1.Series("Number of Post").Points.AddXY(reader.GetString(1).ToString, reader.GetString(0).ToString)
                    Guna2ComboBox1.Items.Add(reader.GetString(1))
                End While
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "FINDING SERVICE" Then
            Chart1.Series("Number of Post").Points.Clear()
            Guna2ComboBox1.Enabled = True
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT count(servicecategory.servicecategoryid),servicecategory.categoryName FROM serviceorder LEFT JOIN service on serviceorder.serviceID = service.serviceID LEFT JOIN servicecategory ON servicecategory.servicecategoryID = service.servicecategoryID GROUP BY servicecategory.servicecategoryid;"
                cmd = New MySqlCommand(sql, conn)
                reader = cmd.ExecuteReader
                While reader.Read
                    Chart1.Series("Number of Post").Points.AddXY(reader.GetString(1).ToString, reader.GetString(0).ToString)
                    Guna2ComboBox1.Items.Add(reader.GetString(1))
                End While
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Guna2PictureBox3.Visible = False
        Guna2HtmlLabel4.Visible = False
    End Sub
    Private Sub STATISTISC_POSTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        STATISTICS.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Call PROCESS_VERIFICATION.allrecords()
        PROCESS_VERIFICATION.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        categories.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Post.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Call PROCESS_VERIFICATION.allrecords()
        PROCESS_VERIFICATION.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        categories.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Post.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        LOGIN_ADMIN.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        STATISTICS.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        MESSAGES.Show()
        Me.Close()
    End Sub
    Dim servicecategoryID As Integer


    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Guna2PictureBox3.Visible = True
        Guna2HtmlLabel4.Visible = True
        Call BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Guna2PictureBox3.Visible = True
        Guna2HtmlLabel4.Visible = True
        Call BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Chart1.Series("Number of Post").Points.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT servicecategoryID FROM servicecategory WHERE categoryName = '" + Guna2ComboBox1.SelectedItem + "'"
            cmd = New MySqlCommand(sql, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                servicecategoryID = reader.GetString(0)
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If ComboBox1.SelectedItem = "SERVICE POSTED" Then
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT count(service.serviceID),service.serviceName  FROM serviceposting LEFT JOIN service on serviceposting.serviceID = service.serviceID LEFT JOIN servicecategory ON servicecategory.servicecategoryID = service.servicecategoryID WHERE servicecategory.servicecategoryID = '" + servicecategoryID.ToString + "' GROUP BY service.serviceID"
                cmd = New MySqlCommand(sql, conn)
                reader = cmd.ExecuteReader
                While reader.Read
                    Chart1.Series("Number of Post").Points.AddXY(reader.GetString(1).ToString, reader.GetString(0).ToString)

                End While
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "FINDING SERVICE" Then
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT count(service.serviceID),service.serviceName FROM serviceorder LEFT JOIN service on serviceorder.serviceID = service.serviceID LEFT JOIN servicecategory ON servicecategory.servicecategoryID = service.servicecategoryID WHERE servicecategory.servicecategoryID = '" + servicecategoryID.ToString + "' GROUP BY service.serviceID;"
                cmd = New MySqlCommand(sql, conn)
                reader = cmd.ExecuteReader
                While reader.Read
                    Chart1.Series("Number of Post").Points.AddXY(reader.GetString(1).ToString, reader.GetString(0).ToString)
                End While
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("PLEASE CHOOSE WHAT KIND OF POST FIRST.")
        End If
        Guna2PictureBox3.Visible = False
        Guna2HtmlLabel4.Visible = False
    End Sub
End Class