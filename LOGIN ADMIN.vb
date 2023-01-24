Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.IO
Imports System.Diagnostics.Eventing

Public Class LOGIN_ADMIN

    Public Sub statinactive()
        Dim con As New MySqlConnection(cnstr)
        Try
            con.Open()
            Dim sql As String = "UPDATE adminstatus SET activestatus = 'Inactive' WHERE statusID = 1"
            cmd = New MySqlCommand(sql, con)
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                'MsgBox("Admin Status is Inactive")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub
    Public Sub statactive()
        Dim con As New MySqlConnection(cnstr)
        Try
            con.Open()
            Dim sql As String = "UPDATE adminstatus SET activestatus = 'Active' WHERE statusID = 1"
            cmd = New MySqlCommand(sql, con)
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Admin Status is Active")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub
    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        If Guna2TextBox2.Text = "alsace" And Guna2TextBox1.Text = "alsace" Then
            MsgBox("Welcome Alsace!")
            Me.Hide()
            STATISTICS.Show()
        ElseIf Guna2TextBox2.Text = "khate" And Guna2TextBox1.Text = "khate" Then
            MsgBox("Welcome Khate Mariane!")
            Me.Hide()
            STATISTICS.Show()
        ElseIf Guna2TextBox2.Text = "peralta" And Guna2TextBox1.Text = "peralta" Then
            MsgBox("Welcome John Estel!")
            Me.Hide()
            STATISTICS.Show()
        ElseIf Guna2TextBox2.Text = "angeles" And Guna2TextBox1.Text = "angeles" Then
            MsgBox("Welcome Angeles!")
            Me.Hide()
            STATISTICS.Show()
        ElseIf Guna2TextBox2.Text = "gabriel" And Guna2TextBox1.Text = "gabriel" Then
            MsgBox("Welcome Gabriel!")
            Me.Hide()
            STATISTICS.Show()
        Else
            MsgBox("SORRY THE USERNAME AND PASSWORD IS NOT CORRECT")
        End If
        Guna2TextBox1.Clear()
        Guna2TextBox2.Clear()
    End Sub



    Dim availableserialport As String
    Dim cnstr As String = "server=sql608.main-hosting.eu; User ID=u305527491_ServiceFinder; password=ServiceFinder1234; database=u305527491_ServiceFinder"
    ' Dim cnstr1 As String = "data source =  localhost; user id = root; database = sfa;"
    Public Shared comport As String
    Dim gsmport As String
    Dim cmd As MySqlCommand
    Private Sub LOGIN_ADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Try
                SerialPort1.PortName = sp
                SerialPort1.BaudRate = 9600
                SerialPort1.Open()
                SerialPort1.WriteLine("hrtbt1")
                System.Threading.Thread.Sleep(2000)
                Dim r = SerialPort1.ReadExisting()
                If r.Contains("hrtbt2") Then
                    comport = sp
                    SerialPort1.Close()
                Else
                    MsgBox("NO RFID")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SerialPort1.Close()
        Next
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Try
                With SerialPort1
                    ''Serial Port Configuration
                    .PortName = sp 'THIS PORT IS CHANGABLE. YOU MUST TO CHECK YOURS!
                    .BaudRate = 9600
                    .ReadTimeout = 1000
                    .ReadBufferSize = 1000
                    .WriteTimeout = 1000
                    .WriteBufferSize = 1000
                    .Parity = Parity.None
                    .StopBits = StopBits.One
                    .DataBits = 8
                    .Handshake = Handshake.None
                    .RtsEnable = True
                    .Open()
                    SerialPort1.Write("ATI" & Chr(13))
                    Thread.Sleep(1000)
                    If SerialPort1.ReadExisting().Contains("SIM800") Then
                        gsmport = sp
                        SerialPort1.Close()
                    Else
                        MsgBox("NO GSM MODULE")
                    End If
                End With
                ' MsgBox("kaconnect sa port")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SerialPort1.Close()
        Next
        If gsmport = "" Then
            MsgBox("There is no GSM device connected")
        End If
        If comport = "" Then
            MsgBox("There is no RFID SCANNER connected")
        Else
            Timer1.Start()
        End If
        'MsgBox(availableserialport)
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Public CODE As String
    Public CONTACT As String
    Dim returnStr As String = ""

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim conn As New MySqlConnection
            Dim conn1 As MySqlConnection
            Dim cnstr As String = "server=sql608.main-hosting.eu; User ID=u305527491_ServiceFinder; password=ServiceFinder1234; database=u305527491_ServiceFinder"
            'Dim cnstr As String = "server=db4free.net;Port=3306; User ID=sfa1database; password=12345678; database=sfa1database" ' Dim cnstr As String = "data source =  localhost; user id = root; database = sfa;"
            'Dim cnstr As String = "data source =  localhost; user id = root; database = sfa;"
            Dim result2
            Dim cmd As MySqlCommand
            Dim cmd1 As MySqlCommand
            Dim reader As MySqlDataReader
            While 1
                For Each sp As String In My.Computer.Ports.SerialPortNames
                    Try
                        With SerialPort1
                            ''Serial Port Configuration
                            .PortName = sp 'THIS PORT IS CHANGABLE. YOU MUST TO CHECK YOURS!
                            .BaudRate = 9600
                            .ReadTimeout = 1000
                            .ReadBufferSize = 1000
                            .WriteTimeout = 1000
                            .WriteBufferSize = 1000
                            .Parity = Parity.None
                            .StopBits = StopBits.One
                            .DataBits = 8
                            .Handshake = Handshake.None
                            .RtsEnable = True
                            .Open()
                            SerialPort1.Write("ATI" & Chr(13))
                            Thread.Sleep(1000)
                            If SerialPort1.ReadExisting().Contains("SIM800") Then
                                gsmport = sp
                            End If
                        End With
                        ' MsgBox("kaconnect sa port")
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    End Try
                Next
                Thread.Sleep(4000)
                '  MsgBox("RUNNING NA")
                Try
                    ' MsgBox("RUNNING NA11")
                    conn = New MySqlConnection(cnstr)
                    conn.Open()
                    Dim sql As String = "Select * FROM otp WHERE isSent = 'FALSE'"
                    cmd = New MySqlCommand(sql, conn)
                    reader = cmd.ExecuteReader
                    While reader.Read
                        'MsgBox(reader.GetString(0).ToString)
                        'MsgBox("CONNECTED NA")
                        CODE = reader.GetString("otpCode").ToString
                        CONTACT = reader.GetString("contactNumber").ToString
                        'CONNECTING TO SMS MODULE
                        Try
                            Try
                                With SerialPort1
                                    ''Serial Port Configuration
                                    .PortName = gsmport 'THIS PORT IS CHANGABLE. YOU MUST TO CHECK YOURS!
                                    .BaudRate = 9600
                                    .ReadTimeout = 1000
                                    .ReadBufferSize = 1000
                                    .WriteTimeout = 1000
                                    .WriteBufferSize = 1000
                                    .Parity = Parity.None
                                    .StopBits = StopBits.One
                                    .DataBits = 8
                                    .Handshake = Handshake.None
                                    .RtsEnable = True
                                    .Open()
                                End With
                                ' MsgBox("kaconnect sa port")
                            Catch ex As Exception
                                ' MsgBox("dito di nakaconnect")
                            End Try

                            Try
                                SerialPort1.Write("AT+CMGF=1" & Chr(13))
                                Thread.Sleep(3000)
                                SerialPort1.Write("AT+CMGS=" & Chr(34) & CONTACT & Chr(34) & Chr(13))
                                Thread.Sleep(3000)
                                'Sleep 2 milliseconds before execute the second line
                                If reader.GetString("requestType").ToString = "OTP" Then
                                    SerialPort1.Write("OTP: " + CODE & Chr(26))

                                    ' MsgBox("NAKUKUHA OTP")
                                ElseIf reader.GetString("requestType").ToString = "PASS" Then
                                    SerialPort1.Write("PASSWORD: " + CODE & Chr(26))
                                ElseIf reader.GetString("requestType").ToString = "VREQUEST" Then
                                    SerialPort1.Write("YOUR VERIFICATION REQUEST IS: " + CODE & Chr(26))
                                End If
                                Thread.Sleep(3000)

                                returnStr = ""

                                Dim Incoming As String = SerialPort1.ReadLine()
                                Do
                                    Incoming = SerialPort1.ReadLine()
                                    If Incoming Is Nothing Then
                                        Exit Do
                                    Else
                                        returnStr = returnStr + Incoming & vbCrLf
                                    End If
                                Loop


                                'MsgBox("message: 1" + returnStr)
                            Catch ex As Exception
                                'MsgBox("message: 2" + returnStr)
                            End Try

                            ' MsgBox("THE RESULT IS: " + result2)
                            If returnStr.Contains("OK") Then
                                'MsgBox("OK NA")
                                result2 = "OK"
                            ElseIf returnStr.Contains("ERROR") Then
                                'MsgBox("hindi okay")
                                result2 = "ERROR"
                            End If

                            If result2 = "ERROR" Then
                                MsgBox("Message Not Sent")
                            ElseIf result2 = "OK" Then
                                MsgBox("Message Sent")
                                Try
                                    conn1 = New MySqlConnection(cnstr)
                                    conn1.Open()
                                    Dim sql1 As String = "UPDATE `otp` SET `isSent`='TRUE' WHERE otpID = '" + reader.GetString(0) + "'"
                                    cmd1 = New MySqlCommand(sql1, conn1)
                                    Dim i As Integer = cmd1.ExecuteNonQuery

                                    If i > 0 Then
                                        'MessageBox.Show("OTP set to true")
                                    Else
                                        'MessageBox.Show("USER VERIFICATION IS NOT DENIED")
                                    End If
                                Catch ex As Exception

                                    'MsgBox("ex.message")
                                End Try
                            Else
                                ' MsgBox("ayaw makuha")
                            End If
                        Catch ex As Exception
                            '  MsgBox("ano kaya problema")
                        End Try
                    End While
                    SerialPort1.Close()
                Catch ex As Exception

                End Try
            End While
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Dim result As String
    Private Sub LOGIN_ADMIN_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Call statinactive()
    End Sub

    Private Sub LOGIN_ADMIN_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Call statinactive()
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Guna2Button8_Click(sender, e)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Timer1.Stop()
        SerialPort1.Close()
        registeradmin.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel1.MouseHover
        LinkLabel1.LinkColor = Color.Blue
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        LinkLabel1.LinkColor = Color.White
    End Sub

    Private Sub rfid_TextChanged(sender As Object, e As EventArgs) Handles rfid.TextChanged
        If rfid.TextLength > 0 Then
            Dim rfidnumber As String = rfid.Text
            Try
                Dim conn4 As MySqlConnection
                conn4 = New MySqlConnection(cnstr)
                conn4.Open()
                Dim sql4 As String = "Select * FROM adminrfid WHERE RFID = '" + rfidnumber + "'"
                Dim cmd4 As MySqlCommand
                cmd4 = New MySqlCommand(sql4, conn4)
                Dim reader4 As MySqlDataReader
                reader4 = cmd4.ExecuteReader
                If reader4.Read Then
                    MsgBox("WELCOME " + reader4.GetString("Name"))
                    Timer1.Stop()
                    SerialPort1.Close()
                    rfid.Text = ""

                    Me.Hide()
                    STATISTICS.Show()
                Else
                    MsgBox("RFID NOT RECOGNIZED " + rfidnumber)
                    rfid.Text = ""
                End If

            Catch ex As Exception

            End Try
        Else

        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        rfid.Focus()
        rfid.Clear()
    End Sub

    Private Sub Guna2TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2TextBox2.MouseLeave, Guna2TextBox1.MouseLeave
        rfid.Clear()
        rfid.Focus()
    End Sub
    Public Shared reading = ""
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If SerialPort1.IsOpen Then
                Dim r = SerialPort1.ReadExisting()                      'read serial for string starts with s and ends with e
                If r <> "" Then                                         'take the string inside as UID of rfid swiped
                    Dim s As String = r.Substring(r.IndexOf("s") + 1, r.IndexOf("e") - 1)
                    rfid.Text = s
                    reading = s
                    SerialPort1.DiscardInBuffer()
                End If
            Else
                SerialPort1.Open()
            End If
        Catch ex As Exception
            Timer1.Stop()
        End Try
    End Sub
End Class