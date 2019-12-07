Public Class dashboardAdmin
    Public users As userdata
    Private con As OleDb.OleDbConnection
    Private Sub dashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub Initialize()
        Try
            con = connect()
            Dim sqls = "SELECT userLoginAdmin.ID, adminList.Nama
                        FROM adminList INNER JOIN userLoginAdmin ON adminList.ID = userLoginAdmin.ID
                        WHERE (((userLoginAdmin.ID)=@1));
                        "

            Dim ole As OleDb.OleDbCommand = con.CreateCommand
            ole.CommandText = sqls
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", users.ID))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                If reader.FieldCount <> 0 Then
                    lblWelcome.Text = "Welcome," + reader(1)
                    users.Name = reader(1).ToString
                End If
            Else
                Application.Exit()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
    End Sub

    Private Sub btnMhs_Click(sender As Object, e As EventArgs) Handles btnMhs.Click
        mahasiswaBay.ShowDialog()
    End Sub

    Private Sub btnMK_Click(sender As Object, e As EventArgs) Handles btnMK.Click
        mkBay.ShowDialog()
    End Sub

    Private Sub btnDosen_Click(sender As Object, e As EventArgs) Handles btnDosen.Click
        dosenBay.ShowDialog()
    End Sub
End Class