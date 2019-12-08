Public Class listKelompok
    Dim con As OleDb.OleDbConnection
    Private Sub listKelompok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        rbNotHave.Checked = True
        refresh()
    End Sub

    Private Sub initDGV()
        dgvMhs.Rows.Clear()
        dgvMhs.Columns.Clear()
        dgvMhs.Columns.Add("nim", "NIM")
        dgvMhs.Columns.Add("namaha", "Mahasiswa")
        dgvMhs.Columns.Add("smt", "Semester")
        dgvMhs.Columns.Add("fakult", "Fakultas")
        dgvMhs.Columns.Add("jurusa", "Jurusan")
        dgvMhs.Columns.Add("klp", "Kelompok")
    End Sub

    Private Sub fillMHSNotHave()
        Try
            initDGV()
            Dim ds = New DataSet
            Dim sql = "SELECT mahasiswaList.Kelompok, mahasiswaList.NIM, mahasiswaList.Nama, mahasiswaList.Semester, fakultasList.NamaFakultas, jurusanList.NamaJurusan, mahasiswaList.Kelompok
                        FROM (fakultasList 
                        INNER JOIN jurusanList ON fakultasList.idFakultas = jurusanList.idFakultas) 
                        INNER JOIN mahasiswaList ON (jurusanList.idJurusan = mahasiswaList.Jurusan) AND (fakultasList.idFakultas = mahasiswaList.Fakultas)
                        WHERE (((mahasiswaList.Kelompok)=@1));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", 0))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim nim = ds.Tables(0).Rows(i).Item(1)
                Dim nama = ds.Tables(0).Rows(i).Item(2)
                Dim smt = ds.Tables(0).Rows(i).Item(3)
                Dim fakult = ds.Tables(0).Rows(i).Item(4)
                Dim jur = ds.Tables(0).Rows(i).Item(5)
                Dim klp = ds.Tables(0).Rows(i).Item(6)

                dgvMhs.Rows.Add(nim, nama, smt, fakult, jur, klp)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub fillMHSUpdate()
        Try
            initDGV()
            Dim ds = New DataSet
            Dim sql = "SELECT mahasiswaList.Kelompok, mahasiswaList.NIM, mahasiswaList.Nama, mahasiswaList.Semester, fakultasList.NamaFakultas, jurusanList.NamaJurusan, mahasiswaList.Kelompok
                        FROM (fakultasList 
                        INNER JOIN jurusanList ON fakultasList.idFakultas = jurusanList.idFakultas) 
                        INNER JOIN mahasiswaList ON (jurusanList.idJurusan = mahasiswaList.Jurusan) AND (fakultasList.idFakultas = mahasiswaList.Fakultas)
                        WHERE NOT (((mahasiswaList.Kelompok)=0));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim nim = ds.Tables(0).Rows(i).Item(1)
                Dim nama = ds.Tables(0).Rows(i).Item(2)
                Dim smt = ds.Tables(0).Rows(i).Item(3)
                Dim fakult = ds.Tables(0).Rows(i).Item(4)
                Dim jur = ds.Tables(0).Rows(i).Item(5)
                Dim klp = ds.Tables(0).Rows(i).Item(6)

                dgvMhs.Rows.Add(nim, nama, smt, fakult, jur, klp)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub refresh()
        If rbNotHave.Checked Then
            fillMHSNotHave()
        ElseIf rbGantiKelompok.Checked Then
            fillMHSUpdate()

        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh()
    End Sub

    Private Sub rbNotHave_CheckedChanged(sender As Object, e As EventArgs) Handles rbNotHave.CheckedChanged
        refresh()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            For Each dgr As DataGridViewRow In dgvMhs.Rows
                If Not dgr.IsNewRow Then
                    'This query is fast fix bug for 1909 Office 2016 Access bug.Please consider to changing back
                    'to default query when bugs is fixed
                    Dim sql = "UPDATE (SELECT * FROM mahasiswaList) SET Kelompok=@1 WHERE (NIM = @2);"
                    Dim ole = con.CreateCommand()
                    ole.CommandText = sql
                    ole.Parameters.Add(New OleDb.OleDbParameter("@1", Convert.ToInt32(dgr.Cells(5).Value)))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@2", dgr.Cells(0).Value.ToString))
                    ole.ExecuteNonQuery()
                    'Console.WriteLine(dgr.Cells(0).Value.ToString + "::" + dgr.Cells(5).Value.ToString)
                End If


            Next
            MessageBox.Show("Data Updated!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class