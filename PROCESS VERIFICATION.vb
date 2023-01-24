Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Drawing.Imaging
Public Class PROCESS_VERIFICATION
    Dim conn As MySqlConnection
    Dim r As Integer
    Public server As String
    Public port As String
    Public userid As String
    Public password As String
    Public database As String
    Public stat As Integer
    Dim cnstr As String = "server=sql608.main-hosting.eu; User ID=u305527491_ServiceFinder; password=ServiceFinder1234; database=u305527491_ServiceFinder"
    ' Dim cnstr1 As String = "data source =  localhost; user id = root; database = sfa;"

    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim itemcol(99) As String
    Dim msg As String
    Dim res As String = "FALSE"

    Public Sub allrecords()
        Dim r As Integer
        Dim c As Integer
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * FROM userverification"
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
    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        'table for requesting for verification

        If ComboBox1.Text = "FOR VERIFICATION" Then
            button1.Enabled = True
            button2.Enabled = True

            ListView1.Items.Clear()
            Dim c As Integer
            ListView1.Items.Clear()
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT * FROM userverification Where verified = 'FALSE' "
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

            'table for VERIFIED
        ElseIf ComboBox1.Text = "VERIFIED" Then
            Dim c As Integer
            Dim r As Integer
            ListView1.Items.Clear()
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT * FROM userverification Where verified = 'TRUE' "
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
            button1.Enabled = False
            button2.Enabled = False

        ElseIf ComboBox1.Text = "ALL REQUEST RECORDS" Then
            button1.Enabled = False
            button2.Enabled = False
            Dim r As Integer
            Dim c As Integer
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT * FROM userverification"
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

        ElseIf ComboBox1.Text = "DENIED" Then
            Dim c As Integer
            ListView1.Items.Clear()
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT * FROM userverification Where verified = 'DENIED'"
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
        ComboBox1.Enabled = True
        Guna2PictureBox2.Visible = False
        Guna2HtmlLabel7.Visible = False
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'table for requesting for verification
        lname.Text = ""
        fname.Text = ""
        mname.Text = ""
        cnumber.Text = ""
        PictureBox1.Image = SERVICE_FINDER.My.Resources.Resources.id_card
        PictureBox2.Image = SERVICE_FINDER.My.Resources.Resources.id_card
        PictureBox3.Image = SERVICE_FINDER.My.Resources.Resources.pngaaa_com_5315331
        Guna2PictureBox2.Visible = True
        Guna2HtmlLabel7.Visible = True
        ListView1.Items.Clear()
        ComboBox1.Enabled = False
        BackgroundWorker2.RunWorkerAsync()

    End Sub
    Public Sub allrecords1()
        Dim c As Integer
        Dim r As Integer
        ListView1.Items.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * FROM userverification"
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

    End Sub
    Public Sub tr()
        Dim c As Integer
        Dim r As Integer
        ListView1.Items.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * FROM userverification Where verified = 'TRUE' "
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

    End Sub
    Public Sub fal()

        Dim c As Integer
        ListView1.Items.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * FROM userverification Where verified = 'FALSE' "
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

    End Sub
    Public Sub denied()
        Dim c As Integer
        ListView1.Items.Clear()
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * FROM userverification Where verified = 'DENIED'"
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

    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        ListView1.Items.Clear()
        Try
            Dim c As Integer
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "SELECT * FROM userverification ORDER By verified DESC"
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
        ComboBox1.Enabled = True
        Guna2PictureBox2.Visible = False
        Guna2HtmlLabel7.Visible = False
    End Sub
    Private Sub PROCESS_VERIFICATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button1.Enabled = False
        button2.Enabled = False
        CheckForIllegalCrossThreadCalls = False
        Guna2PictureBox2.Visible = True
        Guna2HtmlLabel7.Visible = True
        ComboBox1.Enabled = False
        BackgroundWorker1.RunWorkerAsync()

    End Sub
    Dim tempId As String
    Dim tempuservid As String
    Dim id1, id2 As String
    Dim txtsourcecode As String
    Dim tempverified As String
    Dim tempprofpic As String
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        PictureBox1.Image = SERVICE_FINDER.My.Resources.Resources.id_card

        PictureBox2.Image = SERVICE_FINDER.My.Resources.Resources.id_card
        If ListView1.SelectedItems.Count > 0 Then
            tempuservid = ListView1.Items(ListView1.SelectedIndices(0)).Text
            tempId = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "SELECT lastName,firstName,middleName,contactNumber,picture from users where userID = '" & tempId & "'  "
                cmd = New MySqlCommand(sql, conn)
                Dim myreader As MySqlDataReader = cmd.ExecuteReader
                While myreader.Read
                    lname.Text = myreader.GetValue(0).ToString
                    fname.Text = myreader.GetValue(1).ToString
                    mname.Text = myreader.GetValue(2).ToString
                    cnumber.Text = myreader.GetValue(3).ToString
                    tempprofpic = myreader.GetValue(4)
                End While

                If tempprofpic.Contains("jpeg") Then
                    PictureBox3.Image = Base64ToImage(tempprofpic.Replace("data:image/jpeg;base64,", ""))
                ElseIf tempprofpic.Contains("jpg") Then
                    PictureBox3.Image = Base64ToImage(tempprofpic.Replace("data:image/jpg;base64,", ""))
                ElseIf tempprofpic.Contains("png") Then
                    PictureBox3.Image = Base64ToImage(tempprofpic.Replace("data:image/png;base64,", ""))
                ElseIf tempprofpic.Contains("gif") Then
                    PictureBox3.Image = Base64ToImage(tempprofpic.Replace("data:image/gif;base64,", ""))

                End If

                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sqlas As String = "SELECT id1,id2 FROM userverification where userVerificationID = '" + tempuservid + "'"
                cmd = New MySqlCommand(sqlas, conn)
                Dim reader1 As MySqlDataReader = cmd.ExecuteReader
                While reader1.Read
                    id1 = reader1.GetValue(0)
                    id2 = reader1.GetValue(1)
                End While

                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If id1 = "../images/id-card.png" Then
                PictureBox1.Image = SERVICE_FINDER.My.Resources.Resources.id_card
            ElseIf id1.Contains("jpeg") Then
                PictureBox1.Image = Base64ToImage(id1.Replace("data:image/jpeg;base64,", ""))
            ElseIf id1.Contains("jpg") Then
                PictureBox1.Image = Base64ToImage(id1.Replace("data:image/jpg;base64,", ""))
            ElseIf id1.Contains("png") Then
                PictureBox1.Image = Base64ToImage(id1.Replace("data:image/png;base64,", ""))
            ElseIf id1.Contains("gif") Then
                PictureBox1.Image = Base64ToImage(id1.Replace("data:image/gif;base64,", ""))

            End If

            If id2 = "../images/id-card.png" Then
                PictureBox2.Image = SERVICE_FINDER.My.Resources.Resources.id_card
            ElseIf id2.Contains("jpeg") Then
                PictureBox2.Image = Base64ToImage(id2.Replace("data:image/jpeg;base64,", ""))
            ElseIf id1.Contains("jpg") Then
                PictureBox2.Image = Base64ToImage(id2.Replace("data:image/jpg;base64,", ""))
            ElseIf id2.Contains("png") Then
                PictureBox2.Image = Base64ToImage(id2.Replace("data:image/png;base64,", ""))
            ElseIf id2.Contains("gif") Then
                PictureBox2.Image = Base64ToImage(id2.Replace("data:image/gif;base64,", ""))

            End If




            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sqla As String = "SELECT verified from userverification where userID= '" & tempId & "'"
                cmd = New MySqlCommand(sqla, conn)
                Dim myreaderr As MySqlDataReader = cmd.ExecuteReader

                While myreaderr.Read
                    tempverified = myreaderr.GetValue(0).ToString
                End While
                If tempverified = "TRUE" Then
                    Button1.Enabled = False
                    Button2.Enabled = False
                ElseIf tempverified = "FALSE" Then
                    Button1.Enabled = True
                    Button2.Enabled = True
                ElseIf tempverified = "DENIED" Then
                    Button1.Enabled = False
                    Button2.Enabled = False
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel2.BringToFront()
        Panel3.SendToBack()

        popupimage.Image = PictureBox1.Image
    End Sub

    Private Sub BACK_Click(sender As Object, e As EventArgs) Handles BACK.Click

        Panel2.SendToBack()
        Panel3.BringToFront()
        popupimage.Image = SERVICE_FINDER.My.Resources.Resources.id_card
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel2.BringToFront()
        Panel3.SendToBack()
        popupimage.Image = PictureBox2.Image
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PictureBox1.Image = SERVICE_FINDER.My.Resources.Resources.id_card
        PictureBox2.Image = SERVICE_FINDER.My.Resources.Resources.id_card
        Dim result As DialogResult = MessageBox.Show("CONFIRM VERIFICATION?", "ADMIN", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "UPDATE userverification SET verified = 'TRUE' WHERE userID = '" + tempId + "'"
                cmd = New MySqlCommand(sql, conn)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    sql = "update users set verified = 'TRUE' WHERE userID = '" + tempId + "'"
                    cmd = New MySqlCommand(sql, conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MessageBox.Show("USER HAS BEEN VERIFIED")
                    End If


                    'CONNECTING TO SMS MODULE

                    ' With SerialPort1
                    ''Serial Port Configuration
                    '.PortName = "COM4" 'THIS PORT IS CHANGABLE. YOU MUST TO CHECK YOURS!
                    '.BaudRate = 9600
                    '.ReadTimeout = 1000
                    '.ReadBufferSize = 1000
                    '.WriteTimeout = 1000
                    '.WriteBufferSize = 1000
                    '.Parity = Parity.None
                    '.StopBits = StopBits.One
                    '.DataBits = 8
                    '.Handshake = Handshake.None
                    ''.RtsEnable = True
                    '.Open()
                    'End With
                    'BackgroundWorker1.RunWorkerAsync()
                    msg = "VERIFIED"
                Else

                End If

            Catch ex As Exception

            End Try

        ElseIf result = DialogResult.No Then


        End If
        conn.Close()


        If ComboBox1.SelectedItem = "VERIFIED" Then
            Call tr()

        ElseIf ComboBox1.SelectedItem = "DENIED" Then
            Call denied()
        ElseIf ComboBox1.SelectedItem = "FOR VERIFICATION" Then
            Call fal()
        ElseIf ComboBox1.SelectedItem = "ALL REQUEST RECORDS" Then
            Call allrecords1()
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        PictureBox1.Image = SERVICE_FINDER.My.Resources.Resources.id_card
        PictureBox2.Image = SERVICE_FINDER.My.Resources.Resources.id_card
        Try
            conn = New MySqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "UPDATE userverification  SET verified = 'DENIED' WHERE userID = '" + tempId + "' "
            cmd = New MySqlCommand(sql, conn)
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                sql = "update users set verified = 'DENIED' WHERE userID = '" + tempId + "'"
                cmd = New MySqlCommand(sql, conn)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("USER VERIFICATION HAS BEEN DENIED")
                Else
                    MessageBox.Show("USER VERIFICATION IS NOT DENIED")
                End If


                'CONNECTING TO SMS MODULE

                ' With SerialPort1
                ''Serial Port Configuration
                '.PortName = "COM4" 'THIS PORT IS CHANGABLE. YOU MUST TO CHECK YOURS!
                '.BaudRate = 9600
                '.ReadTimeout = 1000
                '.ReadBufferSize = 1000
                '.WriteTimeout = 1000
                '.WriteBufferSize = 1000
                '.Parity = Parity.None
                '.StopBits = StopBits.One
                '.DataBits = 8
                '.Handshake = Handshake.None
                ''.RtsEnable = True
                '.Open()
                'End With
                'BackgroundWorker1.RunWorkerAsync()
                msg = "DENIED"
            Else

            End If

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cnumber_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Public Sub closings()
        ComboBox1.Text = ""
        ListView1.Items.Clear()
        PictureBox3.Image = Nothing
        mname.Clear()
        cnumber.Clear()
        lname.Clear()
        fname.Clear()
        PictureBox1.Image = SERVICE_FINDER.My.Resources.Resources.id_card
        PictureBox2.Image = SERVICE_FINDER.My.Resources.Resources.id_card
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        Call closings()
        STATISTICS.Show()
        Me.Close()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Call closings()
        categories.Show()
        Me.Close()
    End Sub
    Dim img As System.Drawing.Image

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Call closings()
        Post.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Call closings()
        STATISTICS.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Call closings()
        categories.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Call closings()
        Post.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click

        LOGIN_ADMIN.Show()
        Me.Close()
    End Sub

    Private Sub fname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim result As DialogResult = MessageBox.Show("CONFIRM VERIFICATION?", "ADMIN", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "UPDATE userverification SET verified = 'TRUE' WHERE userID = '" + tempId + "'"
                cmd = New MySqlCommand(sql, conn)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    sql = "update users set verified = 'TRUE' WHERE userID = '" + tempId + "'"
                    cmd = New MySqlCommand(sql, conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        'MessageBox.Show("USER HAS BEEN VERIFIED")

                        Dim connn As MySqlConnection = New MySqlConnection(cnstr)
                        connn.Open()
                        Dim sqly As String = "INSERT INTO `otp`( `otpCode`, `contactNumber`, `otpDateTime`, `isSent`, `requestType`) VALUES (@otpCode,@contactNumber,@otpDateTime,@isSent,@requestType)"
                        Dim cmdy As MySqlCommand
                        cmdy = New MySqlCommand(sqly, connn)
                        cmdy.Parameters.AddWithValue("@otpCode", "VERIFIED")
                        cmdy.Parameters.AddWithValue("@contactNumber", cnumber.Text)
                        cmdy.Parameters.AddWithValue("@otpDateTime", DateAndTime.Now)
                        cmdy.Parameters.AddWithValue("@isSent", "FALSE")
                        cmdy.Parameters.AddWithValue("@requestType", "VREQUEST")
                        Dim iy As Integer = cmdy.ExecuteNonQuery
                        If iy > 0 Then
                            MsgBox("VERIFICATION REQUEST VERIFIED", MsgBoxStyle.OkOnly)
                            ComboBox1.Enabled = False
                            BackgroundWorker2.RunWorkerAsync()
                        Else
                            'MsgBox("THE DATA IS NOT RECORDER")
                        End If
                        connn.Close()
                    End If
                    fname.Text = ""
                    mname.Text = ""
                    lname.Text = ""
                    cnumber.Text = ""
                    PictureBox1.Image = SERVICE_FINDER.My.Resources.Resources.id_card
                    PictureBox2.Image = SERVICE_FINDER.My.Resources.Resources.id_card
                    PictureBox3.Image = SERVICE_FINDER.My.Resources.Resources.pngaaa_com_5315331
                Else

                End If

            Catch ex As Exception

            End Try

        ElseIf result = DialogResult.No Then

        End If
        conn.Close()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles button2.Click

        Dim result As DialogResult = MessageBox.Show("CONFIRM NOT VERIFY?", "ADMIN", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql As String = "UPDATE userverification  SET verified = 'DENIED' WHERE userID = '" + tempId + "' "
                cmd = New MySqlCommand(sql, conn)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    sql = "update users set verified = 'DENIED' WHERE userID = '" + tempId + "'"
                    cmd = New MySqlCommand(sql, conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then

                        Dim connn As MySqlConnection = New MySqlConnection(cnstr)
                        connn.Open()
                        Dim sqly As String = "INSERT INTO `otp`( `otpCode`, `contactNumber`, `otpDateTime`, `isSent`, `requestType`) VALUES (@otpCode,@contactNumber,@otpDateTime,@isSent,@requestType)"
                        Dim cmdy As MySqlCommand
                        cmdy = New MySqlCommand(sqly, connn)
                        cmdy.Parameters.AddWithValue("@otpCode", "DENIED")
                        cmdy.Parameters.AddWithValue("@contactNumber", cnumber.Text)
                        cmdy.Parameters.AddWithValue("@otpDateTime", DateAndTime.Now)
                        cmdy.Parameters.AddWithValue("@isSent", "FALSE")
                        cmdy.Parameters.AddWithValue("@requestType", "VREQUEST")
                        Dim iy As Integer = cmdy.ExecuteNonQuery
                        If iy > 0 Then
                            MsgBox("VERIFICATION REQUEST DENIED", MsgBoxStyle.OkOnly)
                            ComboBox1.Enabled = False
                            BackgroundWorker2.RunWorkerAsync()
                        Else
                            'MsgBox("THE DATA IS NOT RECORDER")
                        End If
                        connn.Close()
                    Else
                        'MessageBox.Show("USER VERIFICATION IS NOT DENIED")
                    End If

                Else

                End If
                lname.Text = ""
                fname.Text = ""
                mname.Text = ""
                cnumber.Text = ""
                PictureBox1.Image = SERVICE_FINDER.My.Resources.Resources.id_card
                PictureBox2.Image = SERVICE_FINDER.My.Resources.Resources.id_card
                PictureBox3.Image = SERVICE_FINDER.My.Resources.Resources.pngaaa_com_5315331
            Catch ex As Exception

            End Try
            conn.Close()
        End If


    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        MESSAGES.Show()
        Me.Close()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

    End Sub

    Function Base64ToImage(ByVal base64string As String) As System.Drawing.Image

        Try

            Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
            Dim b64 As String = base64string.Replace(" ", "+")
            Dim b() As Byte

            'Converts the base64 encoded msg to image data
            b = Convert.FromBase64String(b64)
            MS = New System.IO.MemoryStream(b)

            'creates image
            img = System.Drawing.Image.FromStream(MS)


        Catch ex As Exception

        End Try 'Setup image and get data stream together
        Return img
    End Function



End Class