Public Class mkBay
    Dim con As OleDb.OleDbConnection
    Private Sub mkBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        initListFakultas()
        initInputFakultas()
    End Sub

    Private Sub initDGVMK()
        dgvMKList.Rows.Clear()
        dgvMKList.Columns.Clear()
        dgvMKList.Columns.Add("nmk", "Kode MK")
        dgvMKList.Columns.Add("matak", "Mata Kuliah")
        dgvMKList.Columns.Add("smt", "Semester")
        dgvMKList.EditMode = False
    End Sub

    Private Sub initDGVDosen()
        dgvDosen.Rows.Clear()
        dgvDosen.Columns.Clear()
        dgvDosen.Columns.Add("npeng", "ID Pengajar")
        dgvDosen.Columns.Add("nid", "NID")
        dgvDosen.Columns.Add("dosen", "Nama Dosen")
        dgvDosen.Columns.Add("klp", "Kelompok")
        dgvDosen.EditMode = False
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            initDGVMK()
            Dim dss = New DataSet
            Dim sql = "SELECT matakuliahList.idMataKuliah, matakuliahList.MataKuliah, matakuliahList.semester, matakuliahList.idFakultas, matakuliahList.idJurusan
                        FROM matakuliahList
                        WHERE (((matakuliahList.idFakultas)=@1) AND ((matakuliahList.idJurusan)=@2));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", listFakultas.SelectedValue))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", listProdi.SelectedValue))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            For i = 0 To dss.Tables(0).Rows.Count - 1
                Dim nmk = dss.Tables(0).Rows(i).Item(0)
                Dim nama = dss.Tables(0).Rows(i).Item(1)
                Dim smt = dss.Tables(0).Rows(i).Item(2)

                dgvMKList.Rows.Add(nmk, nama, smt)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvMKList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMKList.CellDoubleClick
        Dim idmk = dgvMKList.CurrentRow.Cells(0).Value.ToString
        Try
            initDGVDosen()
            Dim dss = New DataSet
            Dim sql = "SELECT pengajar.idPengajar, dosenList.NID, dosenList.Nama, pengajar.kelompok, pengajar.idMK
                        FROM dosenList INNER JOIN pengajar ON dosenList.NID = pengajar.dosen
                        WHERE (((pengajar.idMK)=@1));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", idmk))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            For i = 0 To dss.Tables(0).Rows.Count - 1
                Dim png = dss.Tables(0).Rows(i).Item(0)
                Dim nid = dss.Tables(0).Rows(i).Item(1)
                Dim nama = dss.Tables(0).Rows(i).Item(2)
                Dim kel = dss.Tables(0).Rows(i).Item(3)

                dgvDosen.Rows.Add(png, nid, nama, kel)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim Generator As System.Random = New System.Random()
        Dim indexx = GetRandom(Generator, 1000, 9999)
        Dim generateNim = String.Format("0{0}0{1}00{2}", inputFakultas.SelectedValue, inputProdi.SelectedValue, indexx)
        lblIDMK.Text = generateNim
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If inputNamaMK.Text.Count <> 0 And inputSemester.Text.Count <> 0 Then
            Try
                Dim Sql = "INSERT INTO mataKuliahList( idMataKuliah, MataKuliah, idFakultas, idJurusan,semester ) VALUES(@1,@2,@3,@4,@5);"
                Dim ole = con.CreateCommand()
                ole.CommandText = Sql
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", lblIDMK.Text))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", inputNamaMK.Text))
                ole.Parameters.Add(New OleDb.OleDbParameter("@3", Convert.ToInt32(inputFakultas.SelectedValue)))
                ole.Parameters.Add(New OleDb.OleDbParameter("@4", Convert.ToInt32(inputProdi.SelectedValue)))
                ole.Parameters.Add(New OleDb.OleDbParameter("@5", Convert.ToInt32(inputSemester.Text)))
                If ole.ExecuteNonQuery() Then
                    MsgBox("Data created!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf inputNamaMK.Text.Count = 0 And inputSemester.Text.Count <> 0 Then
            MsgBox("Masukkan Nama MK!")
        ElseIf inputSemester.Text.Count = 0 And inputNamaMK.Text.Count <> 0 Then
            MsgBox("Masukkan Semester!")
        Else
            MsgBox("Pastikan nama,fakultas,prodi,semester dan sudah generate idmk!")
        End If
    End Sub

    Private Sub btnPengajar_Click(sender As Object, e As EventArgs) Handles btnPengajar.Click
        pengajar.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            For Each dgr As DataGridViewRow In dgvMKList.Rows
                If Not dgr.IsNewRow Then
                    Dim sql = "UPDATE (SELECT * FROM matakuliahList) SET MataKuliah = @1, Semester = @2 WHERE (idMataKuliah = @3);"
                    Dim ole = con.CreateCommand()
                    ole.CommandText = sql
                    ole.Parameters.Add(New OleDb.OleDbParameter("@1", dgr.Cells(1).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@2", dgr.Cells(2).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@3", dgr.Cells(0).Value.ToString))
                    ole.ExecuteNonQuery()
                    'Console.WriteLine(dgr.Cells(0).Value.ToString + "::" + dgr.Cells(1).Value.ToString + "::" + dgr.Cells(2).Value.ToString)
                End If


            Next
            MessageBox.Show("Data Updated!")
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan")
        End Try
    End Sub
End Class