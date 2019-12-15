Public Class krsBay
    Dim con As OleDb.OleDbConnection
    Private Sub inputNIM_KeyDown(sender As Object, e As KeyEventArgs) Handles inputNIM.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchNim()
        End If
    End Sub
    Private Sub initDGV()
        dgvKrs.Rows.Clear()
        dgvKrs.Columns.Clear()
        dgvKrs.Columns.Add("nmk", "Kode MK")
        dgvKrs.Columns.Add("matak", "Mata Kuliah")
        dgvKrs.Columns.Add("smt", "Semester")
        dgvKrs.Columns.Add("sts", "Status")
        dgvKrs.EditMode = False
    End Sub
    Private Sub FetchNim()
        Try
            Dim sql = "SELECT mahasiswaList.Nama, mahasiswaList.Semester, fakultasList.NamaFakultas, jurusanList.NamaJurusan, mahasiswaList.NIM
                        FROM (fakultasList INNER JOIN jurusanList ON fakultasList.idFakultas = jurusanList.idFakultas) INNER JOIN mahasiswaList ON (jurusanList.idJurusan = mahasiswaList.Jurusan) AND (fakultasList.idFakultas = mahasiswaList.Fakultas)
                        WHERE (((mahasiswaList.NIM)=@1));
                        "
            Dim nim = inputNIM.Text.ToString
            Dim ole = con.CreateCommand
            ole.CommandText = sql
            Console.WriteLine(nim)
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", nim))
            Dim reader = ole.ExecuteReader()
            If reader.Read And reader.HasRows Then
                textName.Text = reader.Item(0).ToString
                textSemester.Text = reader.Item(1).ToString
                textFakultas.Text = reader.Item(2).ToString
                textProdi.Text = reader.Item(3).ToString
                fillDGV()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fillDGV()
        Try
            initDGV()
            Dim dss = New DataSet
            Dim sql = "SELECT matakuliahList.idMataKuliah, matakuliahList.MataKuliah, krs.semester, krs.status, mahasiswaList.NIM
                        FROM (matakuliahList INNER JOIN pengajar ON matakuliahList.idMataKuliah = pengajar.idMK) INNER JOIN (mahasiswaList INNER JOIN krs ON mahasiswaList.NIM = krs.mahasiswa) ON pengajar.idPengajar = krs.idpengajar
                        WHERE (((krs.semester)=@1) AND ((mahasiswaList.NIM)=@2));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", Convert.ToInt32(textSemester.Text.ToString)))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", inputNIM.Text.ToString))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            For i = 0 To dss.Tables(0).Rows.Count - 1
                Dim nmk = dss.Tables(0).Rows(i).Item(0)
                Dim nama = dss.Tables(0).Rows(i).Item(1)
                Dim smt = dss.Tables(0).Rows(i).Item(2)
                Dim status = dss.Tables(0).Rows(i).Item(3)

                dgvKrs.Rows.Add(nmk, nama, smt, status)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub krsBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            For Each dgr As DataGridViewRow In dgvKrs.Rows
                If Not dgr.IsNewRow Then
                    'This query is fast fix bug for 1909 Office 2016 Access bug.Please consider to changing back
                    'to default query when bugs is fixed
                    Dim sql = "UPDATE (SELECT * FROM krs) SET status=@1 WHERE (mahasiswa = @2 AND semester = @3);"
                    Dim ole = con.CreateCommand()
                    ole.CommandText = sql
                    ole.Parameters.Add(New OleDb.OleDbParameter("@1", "ACC"))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@2", inputNIM.Text.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@2", dgr.Cells(2).Value.ToString))
                    ole.ExecuteNonQuery()
                    'Console.WriteLine(dgr.Cells(0).Value.ToString + "::" + dgr.Cells(5).Value.ToString)
                End If
            Next
            MessageBox.Show("Data Updated!")
            fillDGV()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class