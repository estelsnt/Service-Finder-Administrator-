Imports Guna.UI2.WinForms
Imports System.Reflection.Emit
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Threading
Public Class registeradmin
    Dim conn As New MySqlConnection
    Dim cnstr As String = "server=sql608.main-hosting.eu; User ID=u305527491_ServiceFinder; password=ServiceFinder1234; database=u305527491_ServiceFinder"

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2TextBox1.Text = "" Then
            MsgBox("Invalid RFID NUMBER")
        Else
            Try
                conn = New MySqlConnection(cnstr)
                conn.Open()
                Dim sql1 As String = "INSERT INTO adminrfid (RFID,Name) VALUES (@RFID,@Name)"
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(sql1, conn)
                cmd.Parameters.AddWithValue("@RFID", Guna2TextBox1.Text)
                cmd.Parameters.AddWithValue("@Name", Guna2TextBox2.Text)
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("ADMIN ADDED")
                    systempassword.Clear()
                    Guna2TextBox1.Clear()
                    Guna2TextBox2.Clear()
                    Guna2GroupBox1.Visible = False
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("CAN'T ADD ADMIN: " + ex.Message)
            End Try
        End If

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If systempassword.Text = "ADMIN123456789" Then
            Guna2GroupBox1.Visible = False
        Else
            MsgBox("NOT")
        End If
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        systempassword.Clear()
        Guna2TextBox1.Clear()
        Guna2TextBox2.Clear()
        Guna2GroupBox1.Visible = False
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Not Valid")
            End If
        End If
    End Sub
    Dim comport As String
    Private Sub registeradmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LOGIN_ADMIN.comport = "" Then
            MsgBox("No RFID device connected")
            Me.Close()
        End If
        SerialPort1.PortName = LOGIN_ADMIN.comport
        SerialPort1.BaudRate = 9600
        Timer1.Start()

        LOGIN_ADMIN.Enabled = False
    End Sub

    Private Sub registeradmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        SerialPort1.Close()
        LOGIN_ADMIN.SerialPort1.PortName = LOGIN_ADMIN.comport
        LOGIN_ADMIN.SerialPort1.BaudRate = 9600
        LOGIN_ADMIN.Timer1.Start()
        LOGIN_ADMIN.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Guna2TextBox1.Text = "" Then
            Try
                If SerialPort1.IsOpen Then

                    Dim r = SerialPort1.ReadExisting()                      'read serial for string starts with s and ends with e
                    If r <> "" Then                                         'take the string inside as UID of rfid swiped
                        Dim s As String = r.Substring(r.IndexOf("s") + 1, r.IndexOf("e") - 1)
                        Guna2TextBox1.Text = s
                        SerialPort1.DiscardInBuffer()
                    End If
                Else
                    SerialPort1.Open()
                End If
            Catch ex As Exception
                Guna2TextBox1.Text = ex.Message
                Timer1.Stop()
            End Try
        End If
    End Sub

    Private Sub registeradmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Timer1.Stop()
        SerialPort1.Close()
        LOGIN_ADMIN.Show()
    End Sub
End Class