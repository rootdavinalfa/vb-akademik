Public Class dashboardMhs
    Private con As OleDb.OleDbConnection
    Public users As userdata
    Private Sub DashboardMhs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub initialize()
        Try
            con = connect()
            Dim Sql = "SELECT jurusanList.NamaJurusan, fakultasList.NamaFakultas, mahasiswaList.Nama, mahasiswaList.Semester, mahasiswaList.Kelompok, mahasiswaList.Fakultas, mahasiswaList.Jurusan
                    FROM (fakultasList INNER JOIN jurusanList ON fakultasList.idFakultas = jurusanList.idFakultas) INNER JOIN mahasiswaList ON (jurusanList.idJurusan = mahasiswaList.Jurusan) AND (fakultasList.idFakultas = mahasiswaList.Fakultas)
                    WHERE (((mahasiswaList.NIM)=@1));
                    "
            Dim ole As OleDb.OleDbCommand = con.CreateCommand
            ole.CommandText = Sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", users.ID))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                If reader.FieldCount <> 0 Then
                    lblWelcome.Text = "Welcome," + reader(2)
                    lblID.Text = users.ID
                    lblClass.Text = String.Format("{0} @ Fakultas {1} Semester {2}", reader(0), reader(1), reader(3))
                    users.Name = reader(2).ToString
                    users.Semester = IIf(Convert.IsDBNull(reader(3)), 0, reader(3))
                    users.Kelompok = IIf(Convert.IsDBNull(reader(4)), 0, reader(4))
                    users.Fakultas = IIf(Convert.IsDBNull(reader(5)), 0, reader(5))
                    users.Jurusan = IIf(Convert.IsDBNull(reader(6)), 0, reader(6))
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

    Private Sub BtnShowKRS_Click(sender As Object, e As EventArgs) Handles btnShowKRS.Click
        showKRS.datas = users
        showKRS.ShowDialog()
    End Sub

    Private Sub BtnCreateKRS_Click(sender As Object, e As EventArgs) Handles btnCreateKRS.Click
        createKRS.datas = users
        createKRS.ShowDialog()
    End Sub


    'PUBLIC
    Public Function isKRSAvailable() As Boolean
        Try
            Dim sqls = "SELECT krs.mahasiswa, krs.status, krs.semester
                        FROM krs
                        WHERE (((krs.mahasiswa)=@1) AND ((krs.status)='ACC') AND ((krs.semester)=@2));
                    "
            Dim ole As OleDb.OleDbCommand = con.CreateCommand
            ole.CommandText = sqls
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", users.ID))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", users.Semester))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return False
    End Function

    Private Sub btnNilai_Click(sender As Object, e As EventArgs) Handles btnNilai.Click
        lihatNilai.datas = users
        lihatNilai.ShowDialog()
    End Sub
End Class