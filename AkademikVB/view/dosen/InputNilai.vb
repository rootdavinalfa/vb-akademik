Public Class InputNilai
    Dim con As OleDb.OleDbConnection
    Public datas As userdata
    Private Sub InputNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        initComboMataKuliah()

    End Sub
    Private Sub initDgvNilai()
        dgvNilai.Rows.Clear()
        dgvNilai.Columns.Clear()
        dgvNilai.Columns.Add("niM", "NIM")
        dgvNilai.Columns.Add("namaMaha", "Nama Mahasiswa")
        dgvNilai.Columns.Add("smt", "Semester")
        dgvNilai.Columns.Add("n1", "Nilai Harian")
        dgvNilai.Columns.Add("n2", "Nilai Tugas")
        dgvNilai.Columns.Add("n3", "Nilai Ulangan")
        dgvNilai.EditMode = False
    End Sub
    Private Sub initComboMataKuliah()
        Try
            Dim dss = New DataSet
            Dim sql = "SELECT pengajar.dosen, matakuliahList.idMataKuliah, matakuliahList.MataKuliah, matakuliahList.semester
                        FROM matakuliahList INNER JOIN pengajar ON matakuliahList.idMataKuliah = pengajar.idMK
                        GROUP BY pengajar.dosen, matakuliahList.idMataKuliah, matakuliahList.MataKuliah, matakuliahList.semester
                        HAVING (((pengajar.dosen)=@1));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With cbMataKuliah
                .DataSource = dss.Tables(0)
                .ValueMember = "idMataKuliah"
                .DisplayMember = "MataKuliah"
            End With
            If dss.Tables(0).Rows.Count = 0 Then
                Close()
            Else
                initComboKelompok()
                AddHandler cbMataKuliah.SelectedIndexChanged, AddressOf mk_SelectedItem
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub initComboKelompok()
        Try
            Dim dss = New DataSet
            Dim sql = "SELECT pengajar.kelompok, pengajar.dosen, pengajar.idMK
                        FROM pengajar
                        WHERE (((pengajar.dosen)=@1) AND ((pengajar.idMK)=@2));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", cbMataKuliah.SelectedValue.ToString))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With cbKelompok
                .DataSource = dss.Tables(0)
                .ValueMember = "kelompok"
                .DisplayMember = "kelompok"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mk_SelectedItem(sender As Object, e As EventArgs)
        If cbMataKuliah.Items.Count > 0 Then
            initComboKelompok()
        End If
    End Sub

    Private Sub buttonLapor_Click(sender As Object, e As EventArgs) Handles buttonLapor.Click
        Try
            For Each dgr As DataGridViewRow In dgvNilai.Rows
                If Not dgr.IsNewRow Then
                    Console.WriteLine(dgr.Cells(3).Value.ToString + "::" + dgr.Cells(5).Value.ToString + "::" + datas.IDPengajar.ToString)
                    'This query is fast fix bug for 1909 Office 2016 Access bug.Please consider to changing back
                    'to default query when bugs is fixed
                    Dim sql = "UPDATE (SELECT * FROM krs) SET nilaiHarian=@1,nilaiTugas=@2,nilaiUlangan=@3 WHERE (mahasiswa = @4 AND idPengajar = @5);"
                    Dim ole = con.CreateCommand()
                    ole.CommandText = sql
                    ole.Parameters.Add(New OleDb.OleDbParameter("@1", dgr.Cells(3).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@2", dgr.Cells(4).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@3", dgr.Cells(5).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@4", dgr.Cells(0).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@5", datas.IDPengajar))
                    ole.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Data Updated!")
            fillDGVNilai()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub buttonShow_Click(sender As Object, e As EventArgs) Handles buttonShow.Click
        fillDGVNilai()
    End Sub
    Private Sub fillDGVNilai()
        Try
            Dim ds = New DataSet
            initDgvNilai()
            Dim sql = "SELECT mahasiswaList.NIM, mahasiswaList.Nama, mahasiswaList.Semester, krs.nilaiHarian, krs.nilaiTugas, krs.nilaiUlangan, pengajar.dosen, pengajar.idMK, pengajar.kelompok, pengajar.idPengajar, krs.status
                        FROM pengajar INNER JOIN (mahasiswaList INNER JOIN krs ON mahasiswaList.NIM = krs.mahasiswa) ON pengajar.idPengajar = krs.idpengajar
                        WHERE (((pengajar.dosen)=@1) AND ((pengajar.idMK)=@2) AND ((pengajar.kelompok)=@3) AND ((krs.status)='ACC'));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", cbMataKuliah.SelectedValue.ToString))
            ole.Parameters.Add(New OleDb.OleDbParameter("@3", cbKelompok.SelectedValue.ToString))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim nim = ds.Tables(0).Rows(i).Item(0)
                Dim nama = ds.Tables(0).Rows(i).Item(1)
                Dim semester = ds.Tables(0).Rows(i).Item(2)
                Dim nilaiHarian = ds.Tables(0).Rows(i).Item(3)
                Dim nilaiTugas = ds.Tables(0).Rows(i).Item(4)
                Dim nilaiUlangan = ds.Tables(0).Rows(i).Item(5)
                datas.IDPengajar = ds.Tables(0).Rows(i).Item(9)
                dgvNilai.Rows.Add(nim, nama, semester, nilaiHarian, nilaiTugas, nilaiUlangan)
            Next
            dgvNilai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class