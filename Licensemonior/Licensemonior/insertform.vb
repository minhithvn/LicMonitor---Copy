Imports System.Data.SqlClient

Module insertform
    Public con As New SqlConnection("Data Source=Minh\SQLEXPRESS;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=sa")
    Public cmd As New Data.SqlClient.SqlCommand
End Module
