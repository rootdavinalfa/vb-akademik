Public Class lihatNilai
    Public datas As userdata
    Private con As OleDb.OleDbConnection
    Private ds As DataSet
    Private Sub lihatNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet
        con = connect()
        dgvNilai.Rows.Clear()
        dgvNilai.Columns.Clear()
        initDGV()
    End Sub
    Private Sub initDGV()
        dgvNilai.Columns.Clear()
        dgvNilai.Rows.Clear()
        dgvNilai.Columns.Add("cmk", "Kode MK")
        dgvNilai.Columns.Add("nmk", "Mata Kuliah")
        dgvNilai.Columns.Add("ndosen", "Dosen")
        dgvNilai.Columns.Add("nh", "Nilai Harian")
        dgvNilai.Columns.Add("nt", "Nilai Ulangan")
        dgvNilai.Columns.Add("nu", "Nilai Tugas")
        dgvNilai.Columns.Add("pre", "Predikat")
    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        initDGV()
        ds.Clear()
        Dim smt = txtSmt.Text
        Try
            Dim sql = "SELECT krs.mahasiswa, matakuliahList.MataKuliah, dosenList.Nama, matakuliahList.idMataKuliah, krs.status, krs.idpengajar, krs.nilaiHarian, krs.nilaiUlangan, nilaiTugas
                        FROM(matakuliahList INNER JOIN (dosenList INNER JOIN pengajar On dosenList.NID = pengajar.dosen) On matakuliahList.idMataKuliah = pengajar.idMK) 
                        INNER Join krs ON pengajar.idPengajar = krs.idpengajar
                        WHERE(((krs.mahasiswa) =@1) And ((krs.status)='ACC') AND ((krs.semester)=@2));"
            Dim ole = con.CreateCommand()
            ole.CommandText = sql
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", CInt(smt)))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim mk = ds.Tables(0).Rows(i).Item(3)
                Dim nmk = ds.Tables(0).Rows(i).Item(1)
                Dim dsn = ds.Tables(0).Rows(i).Item(2)
                Dim kel = ds.Tables(0).Rows(i).Item(0)
                Dim nh = ds.Tables(0).Rows(i).Item(6)
                Dim nu = ds.Tables(0).Rows(i).Item(7)
                Dim nt = ds.Tables(0).Rows(i).Item(8)
                Dim predicate = makePredicate(nh, nu, nt)

                dgvNilai.Rows.Add(mk, nmk, dsn, nh, nu, nt, predicate)
            Next
            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("Data tidak ditemukan!")
            End If

            dgvNilai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function makePredicate(harian As Double, ulangan As Double, tugas As Double) As String
        Dim mean As Double = (harian + ulangan + tugas) / 3
        If mean >= 85 Then
            Return "A"
        ElseIf mean < 85 And mean >= 75 Then
            Return "B"
        ElseIf mean < 75 And mean >= 65 Then
            Return "C"
        ElseIf mean < 65 And mean >= 45 Then
            Return "D"
        Else
            Return "E"
        End If

    End Function

    Private Sub dgvNilai_RowsDefaultCellStyleChanged(sender As Object, e As EventArgs) Handles dgvNilai.RowsDefaultCellStyleChanged

    End Sub

    Private Sub dgvNilai_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvNilai.CellFormatting
        For Each row As DataGridViewRow In dgvNilai.Rows
            row.DefaultCellStyle.Font = New Font("Arial", 15.0F, GraphicsUnit.Pixel)
            'Jika predikat D atau E maka berwarna merah
            If row.Cells("pre").Value = "D" Or row.Cells("pre").Value = "E" Then
                row.DefaultCellStyle.ForeColor = Color.White
                row.DefaultCellStyle.BackColor = Color.Red
                'Jika predikat C maka berwarna kuning
            ElseIf row.Cells("pre").Value = "C" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow
                'Jika predikat A atau B maka berwarna hijau
            ElseIf row.Cells("pre").Value = "A" Or row.Cells("pre").Value = "B" Then
                row.DefaultCellStyle.ForeColor = Color.White
                row.DefaultCellStyle.BackColor = Color.Green
            End If
        Next
    End Sub
End Class