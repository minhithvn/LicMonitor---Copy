Imports System.Data.SqlClient


Public Class Login

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer
        a = MsgBox(" Bạn thực sự muốn thoát?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "License monitoring!")
        If a = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Data Source=MINH\SQLEXPRESS;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=sa")
        'Dim command As New SqlCommand("Select * from dbo.login where username=@username and password=@password", connection)
        Dim command As New SqlCommand("Select * from login where username=@username and password=@password", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = t1.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = t2.Text

        Dim adpater As New SqlDataAdapter(command)
        Dim table As New DataTable
        adpater.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Sai tên đăng nhâp hoặc sai mật khẩu", vbOKOnly + vbExclamation, "Thông báo")
        Else
            MsgBox("Chào mừng bạn, " & t1.Text)
            Me.Hide()
            Form1.Show()
            t2.Text = ""
        End If

    End Sub

   

    Private Sub t2_KeyDown(sender As Object, e As KeyEventArgs) Handles t2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub t1_KeyDown(sender As Object, e As KeyEventArgs) Handles t1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://newsystemvietnam.com")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        email.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            t2.UseSystemPasswordChar = False
        Else
            t2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t2.UseSystemPasswordChar = True
    End Sub

    Private Sub t1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged

    End Sub
End Class
