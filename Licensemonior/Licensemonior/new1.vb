
Public Class new1

    'Dim connection As New SqlConnection("Data Source=AESRV\SQLEXPRESS;Initial Catalog=KINTONE;Persist Security Info=True;User ID=sa;Password=123456a@")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim insertquery As String = "INSERT INTO lic(id, area, customername, pic, thirdparty, ProductName, productid, description, licensetype, quality, target, firstlicfrom, firstlicto, lastrenewalto, lastrenewalfrom, exprirydate, TOS, model, HWspec, HWmonitor, Layout, warranty, OS, SWversion, SWlanguage, servicepack, hotfix, hwswlist, reminddate, remarks1, remarks2, remarks3) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox10.Text & "','" & TextBox31.Text & "','" & TextBox34.Text & "','" & TextBox35.Text & "','" & DateTimePicker1.Text.ToString & "','" & DateTimePicker2.Text.ToString & "','" & DateTimePicker3.Text.ToString & "','" & DateTimePicker4.Text.ToString & "','" & DateTimePicker5.Text.ToString & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox20.Text & "','" & TextBox32.Text & "','" & TextBox36.Text & "','" & TextBox21.Text & "','" & TextBox22.Text & "','" & TextBox24.Text & "','" & TextBox25.Text & "','" & TextBox26.Text & "','" & TextBox27.Text & "','" & TextBox28.Text & "','" & TextBox29.Text & "','" & TextBox30.Text & "','" & TextBox32.Text & "')"
        'chayquery(insertquery)
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT INTO incedent VALUES(convert(date,'" & DateTimePicker1.Value & "',103),'" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.SelectedItem & "','" & TextBox6.Text & "','" & TextBox7.Text & "',convert(date,'" & DateTimePicker2.Value & "',103),'" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),convert(date,'" & DateTimePicker2.Value & "',103))"
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Thêm thành công rồi nha")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (con.State = ConnectionState.Open) Then con.Close()
        End Try

    End Sub

    Private Sub button3_click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "update incedent set date =convert(Date,'" & DateTimePicker1.Value & "',103),no = '" & TextBox1.Text & "',cus = '" & TextBox2.Text & "',IP ='" & TextBox3.Text & "',doI = '" & TextBox4.Text & "',model = '" & TextBox5.Text & "',kindsp = '" & ComboBox1.SelectedItem & "',cause = '" & TextBox6.Text & "',doc = '" & TextBox7.Text & "',date1 = convert(date,'" & DateTimePicker2.Value & "',103),name ='" & TextBox8.Text & "',action = '" & TextBox9.Text & "',koa= '" & TextBox10.Text & "' where no= '" & TextBox1.Text & "'"
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("đã sửa thành công")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (con.State = ConnectionState.Open) Then con.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "DELETE FROM incedent WHERE id= " & TextBox1.Text
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Đã xóa thành công, giời cứu")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (con.State = ConnectionState.Open) Then con.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'TextBox1.Text = ""
        'TextBox2.Text = ""
        'TextBox3.Text = ""
        'TextBox4.Text = ""
        'TextBox5.Text = ""


    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub new1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class