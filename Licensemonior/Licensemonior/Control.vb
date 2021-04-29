Imports System.Data.SqlClient
Imports System.Data
Imports System.IO.Directory
Imports Microsoft.Office.Interop.Excel

Public Class Form1


    Private Sub ThêmMớiDữLiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmMớiDữLiệuToolStripMenuItem.Click
        new1.Show()
    End Sub

    Private Sub TìmKiếmDữLiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmDữLiệuToolStripMenuItem.Click
        timkiem.Show()
    End Sub

    Private Sub XóaDữLiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaDữLiệuToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub XuấtCơSởDữLiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtCơSởDữLiệuToolStripMenuItem.Click

        'Initialize the objects before use
        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim command As New SqlClient.SqlCommand
        Dim datatableMain As New System.Data.DataTable()
        Dim connection As New SqlClient.SqlConnection

        'Assign your connection string to connection object
        connection.ConnectionString = "Data Source=Minh\SQLEXPRESS;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=sa"
        command.Connection = connection
        command.CommandType = CommandType.Text
        'You can use any command select
        command.CommandText = "Select * from Incedent"
        dataAdapter.SelectCommand = command


        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                'This section help you if your language is not English.
                System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
                Dim oExcel As Microsoft.Office.Interop.Excel.Application
                Dim oBook As Microsoft.Office.Interop.Excel.Workbook
                Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add(Type.Missing)
                oSheet = oBook.Worksheets(1)

                Dim dc As System.Data.DataColumn
                Dim dr As System.Data.DataRow
                Dim colIndex As Integer = 0
                Dim rowIndex As Integer = 0

                'Fill data to datatable
                connection.Open()
                dataAdapter.Fill(datatableMain)
                connection.Close()


                'Export the Columns to excel file
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(1, colIndex) = dc.ColumnName
                Next

                'Export the rows to excel file
                For Each dr In datatableMain.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In datatableMain.Columns
                        colIndex = colIndex + 1
                        oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Next
                Next

                'Set final path
                Dim fileName As String = "\Incident" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
                'txtPath.Text = finalPath
                oSheet.Columns.AutoFit()
                'Save file in final path
                oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

                'Release the objects
                ReleaseObject(oSheet)
                oBook.Close(False, Type.Missing, Type.Missing)
                ReleaseObject(oBook)
                oExcel.Quit()
                ReleaseObject(oExcel)
                'Some time Office application does not quit after automation: 
                'so i am calling GC.Collect method.
                GC.Collect()

                MessageBox.Show("Đã xuất bản thành công")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub ThiếtLậpCàiĐặtEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThiếtLậpCàiĐặtEmailToolStripMenuItem.Click
        Dim ExcelConnection As New SqlConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=example.xls;Extended Properties=""Excel 12.0 Xml;HDR=Yes""")
        ExcelConnection.Open()

        Dim expr As String = "SELECT * FROM [Sheet1$]"
        Dim objCmdSelect As SqlCommand = New SqlCommand(expr, ExcelConnection)
        Dim objDR As SqlDataReader

        Dim SQLconn As New SqlConnection()
        Dim ConnString As String = "Data Source=Minh\SQLEXPRESS;Initial Catalog=Test;Persist Security Info=True;User ID=sa;Password=sa"
        SQLconn.ConnectionString = ConnString
        SQLconn.Open()


        Using bulkCopy As SqlBulkCopy = New SqlBulkCopy(SQLconn)
            bulkCopy.DestinationTableName = "emp"

            Try
                objDR = objCmdSelect.ExecuteReader
                bulkCopy.WriteToServer(objDR)
                objDR.Close()
                SQLconn.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using


    End Sub
End Class