Public Class Browserr


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" And Not TextBox2.Text = "" Then
            WebBrowser1.Url = New Uri("http://www.google.com/search?q=" + TextBox2.Text)
        ElseIf TextBox2.Text = "" And Not TextBox1.Text = "" Then
            Try
                WebBrowser1.Url = New Uri(TextBox1.Text)
            Catch ex As Exception
                MsgBox("Please check your url again", MsgBoxStyle.Exclamation, "Url Invalid!")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub Browserr_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        keylog.TopMost = True
        keylog.Focus()
        Timer1.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Browserr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        'TextBox1.Text = WebBrowser1.Url.ToString
        Me.WindowState = FormWindowState.Maximized
        If TextBox1.Focused = True Then
            TextBox2.Text = ""
        ElseIf TextBox2.Focused = True Then
            TextBox1.Text = ""
        End If

        ToolTip1.SetToolTip(Me.TextBox1, "Masukan Url")
        ToolTip1.SetToolTip(Me.TextBox2, "Google Search....")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class