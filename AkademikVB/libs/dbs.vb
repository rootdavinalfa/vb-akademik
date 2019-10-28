Module dbs
    Public Function connect() As OleDb.OleDbConnection
        Try
            Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\akademik.accdb;
Persist Security Info=False;"
            con.Open()
            Return con

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error coy !")
            Application.Exit()
        End Try
        Return Nothing
    End Function


End Module
