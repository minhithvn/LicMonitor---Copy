Imports System.Data.SqlClient


Public Class timkiem
    Dim connection1 As New SqlConnection("Data Source=Minh\SQLEXPRESS;Initial Catalog=Test;Persist Security Info=True;User ID=sa;Password=sa")

    Public Sub loc(value As String)
        Dim search As String = "SELECT * From incedent WHERE CONCAT(date,no,cus,IP) like '%" & TextBox1.Text & "%'"
        Dim command As New SqlCommand(search, connection1)
        Dim adpater As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adpater.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        loc("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loc(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim headers = (From header As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter("1.txt")
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
        End Using
        Process.Start("1.txt")
    End Sub
End Class