Public Class ShowSiswa
    Public datas As userdata
    Private con As OleDb.OleDbConnection
    Private ds, dss As DataSet
    Private Sub ShowSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet
        dss = New DataSet
        con = connect()
        dgvSiswa.Rows.Clear()
        dgvSiswa.Columns.Clear()
        initDGV()
        initCombo()
        'initSiswa()
    End Sub

    Private Sub initCombo()
        Try
            dss.Clear()
            Dim sql = "SELECT pengajar.dosen, matakuliahList.idMataKuliah, matakuliahList.MataKuliah, matakuliahList.semester
                        FROM matakuliahList INNER JOIN pengajar ON matakuliahList.idMataKuliah = pengajar.idMK
                        WHERE (((pengajar.dosen)=@1));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With pickMK
                .DataSource = dss.Tables(0)
                .ValueMember = "idMataKuliah"
                .DisplayMember = "MataKuliah"
            End With
            initSiswa()

            AddHandler pickMK.SelectedIndexChanged, AddressOf PickMK_SelectedIndexChanged
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initSiswa()
        Try
            initDGV()
            Dim idmk = pickMK.SelectedValue.ToString
            ds.Clear()
            Dim sql = "SELECT mahasiswaList.NIM, mahasiswaList.Nama, matakuliahList.idMataKuliah, matakuliahList.MataKuliah, mahasiswaList.Semester, pengajar.dosen
                       FROM mahasiswaList INNER JOIN ((matakuliahList INNER JOIN pengajar ON matakuliahList.idMataKuliah = pengajar.idMK) INNER JOIN krs ON pengajar.idPengajar = krs.idpengajar) ON mahasiswaList.NIM = krs.mahasiswa
                       WHERE (((pengajar.dosen)=@1)) AND ((matakuliahList.idMataKuliah)=@2);"
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", idmk))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim cmk = ds.Tables(0).Rows(i).Item(2)
                Dim nmk = ds.Tables(0).Rows(i).Item(3)
                Dim nim = ds.Tables(0).Rows(i).Item(0)
                Dim nama = ds.Tables(0).Rows(i).Item(1)
                Dim smt = ds.Tables(0).Rows(i).Item(4)

                dgvSiswa.Rows.Add(cmk, nmk, nim, nama, smt)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initDGV()
        dgvSiswa.Rows.Clear()
        dgvSiswa.Columns.Clear()
        dgvSiswa.Columns.Add("cmk", "Kode MK")
        dgvSiswa.Columns.Add("nmk", "Mata Kuliah")
        dgvSiswa.Columns.Add("nim", "NIM")
        dgvSiswa.Columns.Add("namaha", "Mahasiswa")
        dgvSiswa.Columns.Add("smt", "Semester")
    End Sub

    Private Sub PickMK_SelectedIndexChanged(sender As Object, e As EventArgs)
        If pickMK.Items.Count > 0 Then
            initSiswa()
        End If
    End Sub
End Class