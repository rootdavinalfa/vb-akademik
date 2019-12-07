Public Class mahasiswaBay
    Dim con As OleDb.OleDbConnection
    Private Sub mahasiswaBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub
    Private Sub Initialize()
        Try
            con = connect()
            initListFakultas()
            initInputFakultas()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initListFakultas()
        Try
            Dim dss = New DataSet
            Dim sqlListFakultas = "SELECT fakultasList.idFakultas, fakultasList.NamaFakultas
                                   FROM fakultasList;
                                   "
            Dim ole = con.CreateCommand()
            ole.CommandText = sqlListFakultas
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With listFakultas
                .DataSource = dss.Tables(0)
                .ValueMember = "idFakultas"
                .DisplayMember = "NamaFakultas"
            End With

            AddHandler listFakultas.SelectedIndexChanged, AddressOf listFakultas_Selected
            initListProdi()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initInputFakultas()
        Try
            Dim dss = New DataSet
            Dim sqlListFakultas = "SELECT fakultasList.idFakultas, fakultasList.NamaFakultas
                                   FROM fakultasList;
                                   "
            Dim ole = con.CreateCommand()
            ole.CommandText = sqlListFakultas
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With inputFakultas
                .DataSource = dss.Tables(0)
                .ValueMember = "idFakultas"
                .DisplayMember = "NamaFakultas"
            End With

            AddHandler inputFakultas.SelectedIndexChanged, AddressOf inputFakultas_Selected
            initInputProdi()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initListProdi()
        Try
            Dim dss = New DataSet
            Dim sqlListFakultas = "SELECT jurusanList.idFakultas, jurusanList.idJurusan, jurusanList.NamaJurusan
                                   FROM jurusanList
                                   WHERE (((jurusanList.idFakultas)=@1));
                                   "
            Dim ole = con.CreateCommand()
            ole.CommandText = sqlListFakultas
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", listFakultas.SelectedValue))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With listProdi
                .DataSource = dss.Tables(0)
                .ValueMember = "idJurusan"
                .DisplayMember = "NamaJurusan"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initInputProdi()
        Try
            Dim dss = New DataSet
            Dim sqlListFakultas = "SELECT jurusanList.idFakultas, jurusanList.idJurusan, jurusanList.NamaJurusan
                                   FROM jurusanList
                                   WHERE (((jurusanList.idFakultas)=@1));
                                   "
            Dim ole = con.CreateCommand()
            ole.CommandText = sqlListFakultas
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", inputFakultas.SelectedValue))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With inputProdi
                .DataSource = dss.Tables(0)
                .ValueMember = "idJurusan"
                .DisplayMember = "NamaJurusan"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Event listFakultas
    Private Sub listFakultas_Selected(sender As Object, e As EventArgs)
        If listFakultas.Items.Count > 0 Then
            initListProdi()
        End If
    End Sub

    Private Sub inputFakultas_Selected(sender As Object, e As EventArgs)
        If inputFakultas.Items.Count > 0 Then
            initInputProdi()
        End If
    End Sub

    Private Sub btnKelas_Click(sender As Object, e As EventArgs) Handles btnKelas.Click
        listKelas.ShowDialog()
    End Sub
    Private Sub initDGV()
        dgvListMahasiswa.Rows.Clear()
        dgvListMahasiswa.Columns.Clear()
        dgvListMahasiswa.Columns.Add("nim", "NIM")
        dgvListMahasiswa.Columns.Add("namaha", "Mahasiswa")
        dgvListMahasiswa.Columns.Add("smt", "Semester")
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            initDGV()
            Dim dss = New DataSet
            Dim sql = "SELECT fakultasList.idFakultas, jurusanList.idJurusan, mahasiswaList.NIM, mahasiswaList.Nama, mahasiswaList.Semester
                        FROM fakultasList 
                        INNER JOIN (jurusanList 
                        INNER JOIN mahasiswaList ON jurusanList.idJurusan = mahasiswaList.Jurusan) ON (fakultasList.idFakultas = jurusanList.idFakultas) AND (fakultasList.idFakultas = mahasiswaList.Fakultas)
                        WHERE (((fakultasList.idFakultas)=@1) AND ((jurusanList.idJurusan)=@2));

                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", listFakultas.SelectedValue))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", listProdi.SelectedValue))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            For i = 0 To dss.Tables(0).Rows.Count - 1
                Dim nim = dss.Tables(0).Rows(i).Item(2)
                Dim nama = dss.Tables(0).Rows(i).Item(3)
                Dim smt = dss.Tables(0).Rows(i).Item(4)

                dgvListMahasiswa.Rows.Add(nim, nama, smt)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerateNim_Click(sender As Object, e As EventArgs) Handles btnGenerateNim.Click
        Dim Generator As System.Random = New System.Random()
        Dim lastYear = DateTime.Now.ToString("yy")
        Dim indexx = GetRandom(Generator, 1, 1000)
        Dim generateNim = String.Format("0{0}0{1}{2}{3}2", inputFakultas.SelectedValue, inputProdi.SelectedValue, lastYear, indexx)
        lblNim.Text = generateNim
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If inputNama.Text.Count <> 0 Then
            Try
                Dim Sql = "INSERT INTO mahasiswaList( NIM, Nama, Fakultas, Jurusan ) VALUES(@1,@2,@3,@4);"
                Dim ole = con.CreateCommand()
                ole.CommandText = Sql
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", lblNim.Text))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", inputNama.Text))
                ole.Parameters.Add(New OleDb.OleDbParameter("@3", Convert.ToInt32(inputFakultas.SelectedValue)))
                ole.Parameters.Add(New OleDb.OleDbParameter("@4", Convert.ToInt32(inputProdi.SelectedValue)))
                If ole.ExecuteNonQuery() Then
                    insertPassword()
                End If
            Catch ex As OleDb.OleDbException
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Nama perlu diisi kemudian generate nim")
        End If
    End Sub
    Private Sub insertPassword()
        Try
            Dim password As String = "123"
            Dim Sql = "INSERT INTO userLoginMahasiswa([ID],[password]) VALUES(@1,@2);"
            Dim ole = con.CreateCommand
            ole.CommandText = Sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", lblNim.Text))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", password))
            ole.ExecuteNonQuery()
            MessageBox.Show("Data Created!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class