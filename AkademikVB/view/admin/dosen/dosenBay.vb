Public Class dosenBay
    Dim con As OleDb.OleDbConnection
    Private Sub dosenBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
        initInputFakultas()
        refresh()
    End Sub

    Private Sub initDGV()
        dgvDosen.Rows.Clear()
        dgvDosen.Columns.Clear()
        dgvDosen.Columns.Add("nim", "NID")
        dgvDosen.Columns.Add("namaha", "Nama")
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

    Private Sub inputFakultas_Selected(sender As Object, e As EventArgs)
        If inputFakultas.Items.Count > 0 Then
            initInputProdi()
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim Generator As System.Random = New System.Random()
        Dim lastYear = DateTime.Now.ToString("yy")
        Dim indexx = GetRandom(Generator, 1, 999)
        Dim generateNim = String.Format("0{0}0{1}{2}{3}1", inputFakultas.SelectedValue, inputProdi.SelectedValue, lastYear, indexx)
        lblNID.Text = generateNim
    End Sub
    Private Sub refresh()
        Try
            initDGV()
            Dim dss = New DataSet
            Dim sql = "SELECT NID,Nama FROM dosenList;
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(dss)
            For i = 0 To dss.Tables(0).Rows.Count - 1
                Dim nid = dss.Tables(0).Rows(i).Item(0)
                Dim nama = dss.Tables(0).Rows(i).Item(1)

                dgvDosen.Rows.Add(nid, nama)
            Next
            dgvDosen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refresh()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If inputNama.Text.Count <> 0 Then
            Try
                Dim Sql = "INSERT INTO dosenList( NID, Nama) VALUES(@1,@2);"
                Dim ole = con.CreateCommand()
                ole.CommandText = Sql
                ole.Parameters.Add(New OleDb.OleDbParameter("@1", lblNID.Text))
                ole.Parameters.Add(New OleDb.OleDbParameter("@2", inputNama.Text))
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
            Dim Sql = "INSERT INTO userLoginDosen([ID],[password]) VALUES(@1,@2);"
            Dim ole = con.CreateCommand
            ole.CommandText = Sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", lblNID.Text))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", password))
            If ole.ExecuteNonQuery() Then
                MessageBox.Show("Data Created!")
                refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            For Each dgr As DataGridViewRow In dgvDosen.Rows
                If Not dgr.IsNewRow Then
                    Dim sql = "UPDATE (SELECT * FROM dosenList) SET Nama = @1 WHERE (NID = @2);"
                    Dim ole = con.CreateCommand()
                    ole.CommandText = sql
                    ole.Parameters.Add(New OleDb.OleDbParameter("@1", dgr.Cells(1).Value.ToString))
                    ole.Parameters.Add(New OleDb.OleDbParameter("@2", dgr.Cells(0).Value.ToString))
                    ole.ExecuteReader()
                End If

            Next
            MsgBox("Data Updated")
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan")
        End Try
    End Sub
End Class