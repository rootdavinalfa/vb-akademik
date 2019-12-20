'２０１９年　Davin Alfarizky Putra Basudewa,Syahrul Febrianto　がこのプロガムを作ってみました
'忘れればのコードには私たちを連絡してください。
Public Class createKRS
    Public datas As userdata
    Private con As OleDb.OleDbConnection
    Private ds As DataSet
    Private Sub CreateKRS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet
        con = connect()
        lblKrsInfo.Text = String.Format("Semester {0}  @ Kelompok {1}", datas.Semester, datas.Kelompok)
        dgvAvail.Rows.Clear()
        dgvAvail.Columns.Clear()
        dgvPicked.Rows.Clear()
        dgvPicked.Columns.Clear()
        initDGV()
        If dashboardMhs.isKRSAvailable() Then
            MessageBox.Show("Anda sudah membuat KRS! Tidak dapat membuat KRS kembali")
            Me.Close()
        Else
            If isReqAvailable() Then
                dgvAvail.Enabled = False
                initReq()
            Else
                dgvAvail.Enabled = True
                initKrs()
            End If
        End If
    End Sub
    Private Sub initDGV()
        'DGV Available
        dgvAvail.Columns.Add("cmk", "Kode MK")
        dgvAvail.Columns.Add("nmk", "Mata Kuliah")
        dgvAvail.Columns.Add("ndosen", "Dosen")
        dgvAvail.Columns.Add("ckelompok", "Semester")
        'DGV Picked
        dgvPicked.Columns.Add("cmk", "Kode MK")
        dgvPicked.Columns.Add("nmk", "Mata Kuliah")
        dgvPicked.Columns.Add("ndosen", "Dosen")
    End Sub
    Private Sub initReq()
        ds.Clear()
        Try
            Dim sqls = "SELECT krs.mahasiswa, matakuliahList.MataKuliah, dosenList.Nama, matakuliahList.idMataKuliah, krs.status, krs.idpengajar
                        FROM (matakuliahList INNER JOIN (dosenList INNER JOIN pengajar ON dosenList.NID = pengajar.dosen) ON matakuliahList.idMataKuliah = pengajar.idMK) 
                        INNER JOIN krs ON pengajar.idPengajar = krs.idpengajar
                        WHERE (((krs.mahasiswa)=@1) AND ((krs.status)='REQ'));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sqls
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim mk = ds.Tables(0).Rows(i).Item(3)
                Dim nmk = ds.Tables(0).Rows(i).Item(1)
                Dim dsn = ds.Tables(0).Rows(i).Item(2)

                dgvPicked.Rows.Add(mk, nmk, dsn)
            Next
            dgvPicked.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initKrs()
        ds.Clear()
        Try
            Dim Sqls = "SELECT matakuliahList.semester, matakuliahList.MataKuliah, dosenList.Nama, pengajar.idMK, pengajar.dosen, pengajar.idPengajar
                FROM matakuliahList INNER JOIN (dosenList INNER JOIN pengajar ON dosenList.NID = pengajar.dosen) ON matakuliahList.idMataKuliah = pengajar.idMK
                WHERE (((pengajar.kelompok)=@1 AND matakuliahList.semester = @2));
                "
            Console.WriteLine(datas.Name)
            Dim ole = con.CreateCommand()
            ole.CommandText = Sqls
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.Kelompok))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", datas.Semester))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim mk = ds.Tables(0).Rows(i).Item(3)
                Dim nmk = ds.Tables(0).Rows(i).Item(1)
                Dim dsn = ds.Tables(0).Rows(i).Item(2)
                Dim kel = ds.Tables(0).Rows(i).Item(0)

                dgvAvail.Rows.Add(mk, nmk, dsn, kel)
            Next
            If ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Matakuliah untuk anda tidak ada,harap hubungi admin untuk informasi lebih lanjut!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Close()
            End If
            dgvAvail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DgvAvail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvail.CellDoubleClick
        Dim i = e.RowIndex
        Dim mk = ds.Tables(0).Rows(i).Item(3)
        Dim nmk = ds.Tables(0).Rows(i).Item(1)
        Dim dsn = ds.Tables(0).Rows(i).Item(2)
        dgvPicked.Rows.Add(mk, nmk, dsn)
    End Sub

    Private Sub DgvPicked_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPicked.CellDoubleClick
        Dim i = e.RowIndex
        If dgvPicked.Rows.Count > 1 Then
            dgvPicked.Rows.RemoveAt(i)
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvAvail.Rows.Clear()
        ds.Clear()
        initKrs()
    End Sub

    Private Sub BtnApplyKrs_Click(sender As Object, e As EventArgs) Handles btnApplyKrs.Click
        If dgvAvail.Enabled Then
            Dim complete = 0
            For i = 0 To dgvPicked.Rows.Count - 2
                Dim mhs = datas.ID
                Dim idpengajar = ds.Tables(0).Rows(i).Item(5)
                Dim status = "REQ"
                Dim semester = datas.Semester
                Try
                    Dim Sqls = "INSERT INTO krs(mahasiswa,idpengajar,status,semester) 
                            VALUES (@1,@2,@3,@4)"
                    Dim ole As OleDb.OleDbCommand = con.CreateCommand
                    ole.CommandText = Sqls
                    ole.Parameters.Add(New OleDb.OleDbParameter("@1", mhs))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@2", idpengajar))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@3", status))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@4", semester))
                    ole.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            Next
            MsgBox("Berhasil membuat KRS!")
            dgvAvail.Rows.Clear()
            dgvAvail.Columns.Clear()
        Else
            MessageBox.Show("Anda masih merequest KRS,silahkan hubungi akademik untuk reset")
        End If

    End Sub



    Private Function isReqAvailable() As Boolean
        Try
            Dim sqls = "SELECT krs.mahasiswa, krs.status, krs.semester
                        FROM krs
                        WHERE (((krs.mahasiswa)=@1) AND ((krs.status)='REQ') AND ((krs.semester)=@2));
                    "
            Dim ole As OleDb.OleDbCommand = con.CreateCommand
            ole.CommandText = sqls
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", datas.Semester))
            Dim reader = ole.ExecuteReader
            If reader.Read Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return False
    End Function

    Private Sub lblKrsInfo_Click(sender As Object, e As EventArgs) Handles lblKrsInfo.Click

    End Sub
End Class