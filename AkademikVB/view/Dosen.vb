Public Class Dosen
    Private con As OleDb.OleDbConnection
    Private ds As DataSet
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Dosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        ds = New DataSet

        tampil()
    End Sub

    Private Sub tampil()
        Try
            Dim sqls = "SELECT * from dosenList"

            Dim ole = con.CreateCommand()
            ole.CommandText = sqls
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True

        Catch ex As Exception

        End Try
    End Sub
End Class