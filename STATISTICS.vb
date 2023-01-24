Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Imports System.Data
Imports System.Windows.Forms.DataVisualization.Charting

Public Class STATISTICS

    Dim conn As New MySqlConnection
    Dim cnstr As String = "server=sql608.main-hosting.eu; User ID=u305527491_ServiceFinder; password=ServiceFinder1234; database=u305527491_ServiceFinder"
    'Dim cnstr1 As String = "data source =  localhost; user id = root; database = sfa;"
    Dim cmd As MySqlCommand
    Dim cmd1 As MySqlCommand
    Dim READER As MySqlDataReader
    Dim sql1 As String 'for nested queries
    Dim con As MySqlConnection 'for nested queries
    Dim cmd2 As MySqlCommand 'for nested queries
    Dim reader1 As MySqlDataReader 'for nested queries
    Dim regdesc As String
    'Buttons
    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        STATISTIC_POST.Show()
        Me.Close()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Call PROCESS_VERIFICATION.allrecords()
        PROCESS_VERIFICATION.Show()
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
    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        MESSAGES.Show()
        Me.Close()
    End Sub
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click

        LOGIN_ADMIN.Show()
        Me.Close()
    End Sub

    'Buttons


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT useraddress.regCode, refregion.regDesc, COUNT(useraddress.userID) AS 'registerd users', SUM(IF(users.verified = 'TRUE', 1, 0)) AS 'verified users', SUM(IF(userverification.verified = 'FALSE', 1, 0)) AS 'pending', SUM(IF(userverification.verified = 'DENIED', 1, 0)) AS 'denied' FROM useraddress JOIN refregion ON refregion.regCode = useraddress.regCode JOIN users ON users.userID = useraddress.userID LEFT JOIN userverification ON userverification.userID = users.userID GROUP BY useraddress.regCode;"
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read

                If READER.GetString("regDesc") = "REGION I (ILOCOS REGION)" Then
                    regdesc = "REGION I"
                ElseIf READER.GetString("regDesc") = "REGION II (CAGAYAN VALLEY)" Then
                    regdesc = "REGION II"
                ElseIf READER.GetString("regDesc") = "REGION III (CENTRAL LUZON)" Then
                    regdesc = "REGION III"
                ElseIf READER.GetString("regDesc") = "REGION IV-A (CALABARZON)" Then
                    regdesc = "REGION IV-A"
                ElseIf READER.GetString("regDesc") = "REGION IV-B (MIMAROPA)" Then
                    regdesc = "REGION IV-B"
                ElseIf READER.GetString("regDesc") = "REGION V (BICOL REGION)" Then
                    regdesc = "REGION V"
                ElseIf READER.GetString("regDesc") = "REGION VI (WESTERN VISAYAS)" Then
                    regdesc = "REGION VI"
                ElseIf READER.GetString("regDesc") = "REGION VII (CENTRAL VISAYAS)" Then
                    regdesc = "REGION VII"
                ElseIf READER.GetString("regDesc") = "REGION VIII (EASTERN VISAYAS)" Then
                    regdesc = "REGION VIII"
                ElseIf READER.GetString("regDesc") = "REGION IX (ZAMBOANGA PENINSULA)" Then
                    regdesc = "REGION IX"
                ElseIf READER.GetString("regDesc") = "REGION X (NORTHERN MINDANAO)" Then
                    regdesc = "REGION X"
                ElseIf READER.GetString("regDesc") = "REGION XI (DAVAO REGION)" Then
                    regdesc = "REGION XI"
                ElseIf READER.GetString("regDesc") = "REGION XII (SOCCSKSARGEN)" Then
                    regdesc = "REGION XII"
                ElseIf READER.GetString("regDesc") = "NATIONAL CAPITAL REGION (NCR)" Then
                    regdesc = "NCR"
                ElseIf READER.GetString("regDesc") = "CORDILLERA ADMINISTRATIVE REGION (CAR)" Then
                    regdesc = "CAR"
                ElseIf READER.GetString("regDesc") = "AUTONOMOUS REGION IN MUSLIM MINDANAO (ARMM)" Then
                    regdesc = "ARMM"
                ElseIf READER.GetString("regDesc") = "REGION XIII (Caraga)" Then
                    regdesc = "REGION XIII"
                End If
                Chart1.Series("NUMBER OF CLIENTS").Points.AddXY(regdesc, READER.GetString(2))
                Chart1.Series("NUMBER OF VERIFIED USER").Points.AddXY(regdesc, READER.GetString(3))
                Chart1.Series("DENIED USERS").Points.AddXY(regdesc, READER.GetString(4))
                Chart1.Series("NOT YET REVIEWED").Points.AddXY(regdesc, READER.GetString(5))
                ComboBox1.Items.Add(READER.GetString(1))
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Guna2HtmlLabel7.Visible = False
        Guna2PictureBox2.Visible = False
    End Sub
    Private Sub STATISTICS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Guna2HtmlLabel7.Visible = True
        Guna2PictureBox2.Visible = True
        BackgroundWorker1.RunWorkerAsync()

        'test

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Guna2HtmlLabel7.Visible = True
        Guna2PictureBox2.Visible = True
        BackgroundWorker2.RunWorkerAsync()
        ComboBox2.Items.Clear()
        Chart1.Series("NUMBER OF CLIENTS").Points.Clear()
        Chart1.Series("NUMBER OF VERIFIED USER").Points.Clear()
        Chart1.Series("DENIED USERS").Points.Clear()
        Chart1.Series("NOT YET REVIEWED").Points.Clear()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Guna2HtmlLabel7.Visible = True
        Guna2PictureBox2.Visible = True
        BackgroundWorker3.RunWorkerAsync()


    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Guna2HtmlLabel7.Visible = True
        Guna2PictureBox2.Visible = True
        BackgroundWorker4.RunWorkerAsync()


        'Call grpbybrgy()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Guna2HtmlLabel7.Visible = True
        Guna2PictureBox2.Visible = True
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        Chart1.Series("NUMBER OF CLIENTS").Points.Clear()
        Chart1.Series("NUMBER OF VERIFIED USER").Points.Clear()
        Chart1.Series("DENIED USERS").Points.Clear()
        Chart1.Series("NOT YET REVIEWED").Points.Clear()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

























    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim teregcode As String
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = " SELECT regCode FROM refregion WHERE regDEsc = '" + ComboBox1.SelectedItem.ToString + "' "
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                teregcode = READER.GetString(0)
            End While
            conn.Close()
        Catch ex As Exception

        End Try
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT useraddress.provCode, refprovince.provDesc, COUNT(useraddress.userID) AS 'registerd users', SUM(IF(users.verified = 'TRUE', 1, 0)) AS 'verified users', SUM(IF(userverification.verified = 'FALSE', 1, 0)) AS 'pending', SUM(IF(userverification.verified = 'DENIED', 1, 0)) AS 'denied' FROM useraddress JOIN refprovince ON refprovince.provCode = useraddress.provCode JOIN users ON users.userID = useraddress.userID LEFT JOIN userverification ON userverification.userID = users.userID WHERE useraddress.regCode = '" + teregcode + "' GROUP BY useraddress.provCode;"
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                Chart1.Series("NUMBER OF CLIENTS").Points.AddXY(READER.GetString(1), READER.GetString(2))
                Chart1.Series("NUMBER OF VERIFIED USER").Points.AddXY(READER.GetString(1), READER.GetString(3))
                Chart1.Series("DENIED USERS").Points.AddXY(READER.GetString(1), READER.GetString(4))
                Chart1.Series("NOT YET REVIEWED").Points.AddXY(READER.GetString(1), READER.GetString(5))
                ComboBox2.Items.Add(READER.GetString(1))
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ComboBox3.Items.Clear()
        Guna2HtmlLabel7.Visible = False
        Guna2PictureBox2.Visible = False
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork

        Dim teregcode As String
        Chart1.Series("NUMBER OF CLIENTS").Points.Clear()
        Chart1.Series("NUMBER OF VERIFIED USER").Points.Clear()
        Chart1.Series("DENIED USERS").Points.Clear()
        Chart1.Series("NOT YET REVIEWED").Points.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = " SELECT citymunCode FROM refcitymun WHERE citymunDesc = '" + ComboBox3.SelectedItem.ToString + "' "
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                teregcode = READER.GetString(0)
            End While
            conn.Close()
        Catch ex As Exception

        End Try
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT useraddress.brgyCode, refbrgy.brgyDesc, COUNT(useraddress.userID) AS 'registerd users', SUM(IF(users.verified = 'TRUE', 1, 0)) AS 'verified users', SUM(IF(userverification.verified = 'FALSE', 1, 0)) AS 'pending', SUM(IF(userverification.verified = 'DENIED', 1, 0)) AS 'denied' FROM useraddress JOIN refbrgy ON refbrgy.brgyCode = useraddress.brgyCode JOIN users ON users.userID = useraddress.userID LEFT JOIN userverification ON userverification.userID = users.userID WHERE useraddress.citymunCode = '" + teregcode + "'GROUP BY useraddress.brgyCode;"
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                Chart1.Series("NUMBER OF CLIENTS").Points.AddXY(READER.GetString(1), READER.GetString(2))
                Chart1.Series("NUMBER OF VERIFIED USER").Points.AddXY(READER.GetString(1), READER.GetString(3))
                Chart1.Series("DENIED USERS").Points.AddXY(READER.GetString(1), READER.GetString(4))
                Chart1.Series("NOT YET REVIEWED").Points.AddXY(READER.GetString(1), READER.GetString(5))

            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Guna2HtmlLabel7.Visible = False
        Guna2PictureBox2.Visible = False
    End Sub

    Dim sql As String
    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Dim teregcode As String

        ComboBox3.Items.Clear()
        Chart1.Series("NUMBER OF CLIENTS").Points.Clear()
        Chart1.Series("NUMBER OF VERIFIED USER").Points.Clear()
        Chart1.Series("DENIED USERS").Points.Clear()
        Chart1.Series("NOT YET REVIEWED").Points.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = " SELECT provCode FROM refprovince WHERE provDesc = '" + ComboBox2.SelectedItem.ToString + "' "
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                teregcode = READER.GetString(0)
            End While
            conn.Close()
        Catch ex As Exception

        End Try
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT useraddress.citymunCode, refcitymun.citymunDesc, COUNT(useraddress.userID) AS 'registerd users', SUM(IF(users.verified = 'TRUE', 1, 0)) AS 'verified users', SUM(IF(userverification.verified = 'FALSE', 1, 0)) AS 'pending', SUM(IF(userverification.verified = 'DENIED', 1, 0)) AS 'denied' FROM useraddress JOIN refcitymun ON refcitymun.citymunCode = useraddress.citymunCode JOIN users ON users.userID = useraddress.userID LEFT JOIN userverification ON userverification.userID = users.userID WHERE useraddress.provCode = '" + teregcode + "'GROUP BY useraddress.citymunCode;"
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                Chart1.Series("NUMBER OF CLIENTS").Points.AddXY(READER.GetString(1), READER.GetString(2))
                Chart1.Series("NUMBER OF VERIFIED USER").Points.AddXY(READER.GetString(1), READER.GetString(3))
                Chart1.Series("DENIED USERS").Points.AddXY(READER.GetString(1), READER.GetString(4))
                Chart1.Series("NOT YET REVIEWED").Points.AddXY(READER.GetString(1), READER.GetString(5))
                ComboBox3.Items.Add(READER.GetString(1))
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Guna2HtmlLabel7.Visible = False
        Guna2PictureBox2.Visible = False
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class
