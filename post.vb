Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.IO
Public Class Post
    Dim conn As New MySqlConnection
    Dim cnstr As String = "server=sql608.main-hosting.eu; User ID=u305527491_ServiceFinder; password=ServiceFinder1234; database=u305527491_ServiceFinder"
    Public server As String
    Public port As String
    Public userid As String
    Public password As String
    Public database As String
    Public stat As Integer
    Dim cmd As MySqlCommand
    Dim READER As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim itemcol(99) As String
    Dim con1 As MySqlConnection
    Dim cmd1 As MySqlCommand
    Dim sql1 As String
    Dim r As Integer
    Dim c As Integer
    Dim res As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListView1.Items.Clear()
        Guna2PictureBox2.Visible = True
        BackgroundWorker1.RunWorkerAsync()


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If ComboBox1.SelectedItem = "Posting Service" Then

            ListView1.Columns(2).Width = 154
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT CONCAT(users.firstname,' ' , users.lastname) , service.servicename,pricing,description,servicePostDateTime FROM serviceposting LEFT OUTER JOIN service ON serviceposting.serviceID = service.serviceID LEFT OUTER JOIN users on serviceposting.userID = users.userid ORDER BY service.servicename ASC;"
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
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "Finding Service" Then
            ListView1.Columns(2).Width = 0
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT CONCAT(users.firstname,' ' , users.lastname) , service.servicename,serviceDescription,description,serviceorder.serviceOrderDateTime FROM serviceorder LEFT OUTER JOIN service ON serviceorder.serviceID = service.serviceID LEFT OUTER JOIN users ON serviceorder.userID = users.userid ORDER BY service.servicename ASC;"
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
                MsgBox(ex.Message)
            End Try
        End If
        Guna2PictureBox2.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        STATISTICS.Show()
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
    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        MESSAGES.Show()
        Me.Close()
    End Sub
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click

        LOGIN_ADMIN.Show()
        Me.Close()
    End Sub

    Private Sub Post_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Threading.Thread.CurrentThread.ApartmentState = Threading.ApartmentState.STA

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class