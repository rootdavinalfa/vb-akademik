Public Class pengajar
    Dim con As OleDb.OleDbConnection
    Private Sub pengajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        initInputMK()
        initListPengajar()
        initListDosen()
        initListMK()
        listDosen.Enabled = False
        listMK.Enabled = False
    End Sub

    Private Sub initListPengajar()
        Try
            initDGVPengajar()
            Dim dss = New DataSet
            Dim sql = "SELECT pengajar.idPengajar, matakuliahList.MataKuliah
                        FROM matakuliahList 
                        INNER JOIN pengajar ON matakuliahList.idMataKuliah = pengajar.idMK;
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            For i = 0 To dss.Tables(0).Rows.Count - 1
                Dim peng = dss.Tables(0).Rows(i).Item(0)
                Dim matak = dss.Tables(0).Rows(i).Item(1)

                dgvPengajar.Rows.Add(peng, matak)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub initInputMK()
        Try
            Dim dss = New DataSet
            Dim sqlListFakultas = "SELECT idMataKuliah,MataKuliah FROM matakuliahlist;
                                   "
            Dim ole = con.CreateCommand()
            ole.CommandText = sqlListFakultas
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With inputMK
                .DataSource = dss.Tables(0)
                .ValueMember = "idMataKuliah"
                .DisplayMember = "MataKuliah"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initListDosen()
        Try
            Dim dss = New DataSet
            Dim sqlListFakultas = "SELECT NID,Nama FROM dosenList;
                                   "
            Dim ole = con.CreateCommand()
            ole.CommandText = sqlListFakultas
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With listDosen
                .DataSource = dss.Tables(0)
                .ValueMember = "NID"
                .DisplayMember = "Nama"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initListMK()
        Try
            Dim dss = New DataSet
            Dim sqlListFakultas = "SELECT idMataKuliah,MataKuliah FROM matakuliahlist;
                                   "
            Dim ole = con.CreateCommand()
            ole.CommandText = sqlListFakultas
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            With listMK
                .DataSource = dss.Tables(0)
                .ValueMember = "idMataKuliah"
                .DisplayMember = "MataKuliah"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Function lastIdPengajar() As Integer
        Try
            Dim sql = "SELECT top 1 idPengajar FROM pengajar ORDER BY idPengajar DESC"
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            Dim reader = ole.ExecuteReader
            reader.Read()
            Dim lastId = reader.Item("idPengajar") + 1
            Return lastId
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub initDGVPengajar()
        dgvPengajar.Rows.Clear()
        dgvPengajar.Columns.Clear()
        dgvPengajar.Columns.Add("peng", "Kode Pengajar")
        dgvPengajar.Columns.Add("matak", "Mata Kuliah")
        dgvPengajar.EditMode = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        initListPengajar()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If inputKelompok.Text.Count <> 0 Then
            Try
                Dim idpengajar = lastIdPengajar()
                Dim sql = "INSERT INTO pengajar(idPengajar,kelompok,idMK) VALUES(@1,@2,@3);"
                Dim ole = con.CreateCommand
                ole.CommandText = sql
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", idpengajar))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", CInt(inputKelompok.Text)))
                ole.Parameters.Add(New OleDb.OleDbParameter("@3", inputMK.SelectedValue.ToString))
                If ole.ExecuteNonQuery() Then
                    MsgBox("Data created!")
                    initListPengajar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Isi kelompok dengan angka lalu masukkan pilih mk!")
        End If
    End Sub

    Private Sub dgvPengajar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPengajar.CellDoubleClick
        Try
            Dim sql = "SELECT pengajar.kelompok, matakuliahList.idMataKuliah, dosenList.NID, pengajar.idPengajar
                        FROM matakuliahList INNER JOIN (dosenList 
                        RIGHT JOIN pengajar ON dosenList.NID = pengajar.dosen) ON matakuliahList.idMataKuliah = pengajar.idMK
                        WHERE (((pengajar.idPengajar)=@1));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", dgvPengajar.CurrentRow.Cells(0).Value))
            Dim reader = ole.ExecuteReader
            If reader.Read() Then
                Console.WriteLine(reader.Item("NID"))
                listMK.Enabled = True
                listDosen.Enabled = True
                listDosen.SelectedValue = reader.Item("NID")
                listMK.SelectedValue = reader.Item("idMataKuliah")
                textKelompok.Text = reader.Item("kelompok")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim mkCNT = listMK.Text.Count
        Dim dsnCNT = listDosen.Text.Count
        Console.WriteLine(CStr(mkCNT) + "::" + listMK.SelectedText)
        If mkCNT <> 0 And dsnCNT <> 0 And textKelompok.Text.Count Then
            Try
                Dim sql = "UPDATE (SELECT * FROM pengajar) SET dosen=@1,idMK = @2,kelompok = @3 WHERE (idPengajar = @4);"
                Dim ole = con.CreateCommand()
                ole.CommandText = sql
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", listDosen.SelectedValue))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", listMK.SelectedValue))
                ole.Parameters.Add(New OleDb.OleDbParameter("@3", textKelompok.Text))
                ole.Parameters.Add(New OleDb.OleDbParameter("@4", dgvPengajar.CurrentRow.Cells(0).Value))
                If ole.ExecuteNonQuery() Then
                    MsgBox("Update Success!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Select MK,Dosen dan masukkan Kelompok kemudian update!")
        End If
    End Sub
End Class