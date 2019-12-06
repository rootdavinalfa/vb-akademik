Public Class ShowNgajar
    Public datas As userdata
    Private con As OleDb.OleDbConnection
    Private ds As DataSet
    Private Sub ShowNgajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        ds = New DataSet
        dgvMKNgajar.Rows.Clear()
        dgvMKNgajar.Columns.Clear()
        initialize()
    End Sub

    Private Sub initialize()
        initDGC()
        Try
            Dim sqls = "SELECT matakuliahList.idMataKuliah, matakuliahList.MataKuliah, fakultasList.NamaFakultas, jurusanList.NamaJurusan, pengajar.dosen
                        FROM ((fakultasList INNER JOIN jurusanList ON fakultasList.idFakultas = jurusanList.idFakultas) INNER JOIN matakuliahList ON (jurusanList.idJurusan = matakuliahList.idJurusan) AND (fakultasList.idFakultas = matakuliahList.idFakultas)) INNER JOIN pengajar ON matakuliahList.idMataKuliah = pengajar.idMK
                        WHERE (((pengajar.dosen)=@1));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sqls
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim idmk = ds.Tables(0).Rows(i).Item(0)
                Dim nmk = ds.Tables(0).Rows(i).Item(1)
                Dim nf = ds.Tables(0).Rows(i).Item(2)
                Dim nj = ds.Tables(0).Rows(i).Item(3)
                dgvMKNgajar.Rows.Add(idmk, nmk, nf, nj)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initDGC()
        'DGV MKNgajar
        dgvMKNgajar.Columns.Add("cmk", "Kode MK")
        dgvMKNgajar.Columns.Add("nmk", "Mata Kuliah")
        dgvMKNgajar.Columns.Add("ndosen", "Fakultas")
        dgvMKNgajar.Columns.Add("ckelompok", "Jurusan")
    End Sub

    Private Sub dgvMKNgajar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMKNgajar.CellContentClick

    End Sub
End Class