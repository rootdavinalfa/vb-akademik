'２０１９年　Davin Alfarizky Putra Basudewa,Syahrul Febrianto　がこのプロガムを作ってみました
'忘れればのコードには私たちを連絡してください。
Public Class showKRS
    Public datas As userdata
    Private con As OleDb.OleDbConnection
    Private ds As New DataSet
    Private Sub ShowKRS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet
        con = connect()
        lblSmtKelompok.Text = String.Format("Semester {0}  @ Kelompok {1}", datas.Semester, datas.Kelompok)
        krsDGV.Rows.Clear()
        krsDGV.Columns.Clear()
        initDGV()
        If dashboardMhs.isKRSAvailable() Then
            initShowKRS()
        Else
            MessageBox.Show("Anda belum membuat KRS! Silahkan Membuat KRS pada menu yang disediakan!")
            Me.Close()
        End If
    End Sub
    Private Sub initShowKRS()
        ds.Clear()
        Try
            Dim Sqls = "SELECT krs.mahasiswa, matakuliahList.MataKuliah, dosenList.Nama, matakuliahList.idMataKuliah, krs.status, krs.idpengajar
                        FROM (matakuliahList INNER JOIN (dosenList INNER JOIN pengajar ON dosenList.NID = pengajar.dosen) ON matakuliahList.idMataKuliah = pengajar.idMK) 
                        INNER JOIN krs ON pengajar.idPengajar = krs.idpengajar
                        WHERE (((krs.mahasiswa)=@1) AND ((krs.status)='ACC') AND ((krs.semester)=@2));
                        "
            Dim ole = con.CreateCommand()
            ole.CommandText = Sqls
            ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", datas.Semester))
            Dim da As New OleDb.OleDbDataAdapter(ole)
            da.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim mk = ds.Tables(0).Rows(i).Item(3)
                Dim nmk = ds.Tables(0).Rows(i).Item(1)
                Dim dsn = ds.Tables(0).Rows(i).Item(2)
                Dim kel = ds.Tables(0).Rows(i).Item(0)

                krsDGV.Rows.Add(mk, nmk, dsn)
            Next
            krsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub initDGV()
        'DGV ShowKRS
        krsDGV.Columns.Add("cmk", "Kode MK")
        krsDGV.Columns.Add("nmk", "Mata Kuliah")
        krsDGV.Columns.Add("ndosen", "Dosen")
    End Sub
End Class