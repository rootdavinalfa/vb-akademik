Public Class dashboardDsn
    Public users As userdata
    Private con As OleDb.OleDbConnection
    Private Sub DashboardDsn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialize()
    End Sub
    Private Sub initialize()
        Try
            con = connect()
            Dim sqlS = "SELECT dosenList.NID, dosenList.Nama
                    FROM dosenList
                    WHERE (((dosenList.NID)=@1));
                    "
            Dim ole As OleDb.OleDbCommand = con.CreateCommand
            ole.CommandText = sqlS
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

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub

    Private Sub BtnShowMahasiswa_Click(sender As Object, e As EventArgs) Handles btnShowMahasiswa.Click
        ShowSiswa.datas = users
        ShowSiswa.ShowDialog()
    End Sub

    Private Sub BtnShowMK_Click(sender As Object, e As EventArgs) Handles btnShowMK.Click
        ShowNgajar.datas = users
        ShowNgajar.ShowDialog()
    End Sub
End Class