Public Class listKelas
    Dim con As OleDb.OleDbConnection
    Private Sub listKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbNotHave.Checked = True
        btnIN.Enabled = True
        btnOUT.Enabled = False
        AddHandler rbIsiKelas.CheckedChanged, AddressOf rbIsiKelas_CheckedChanged
    End Sub


    Private Sub initDGV()
        dgvMhs.Rows.Clear()
        dgvMhs.Columns.Clear()
        dgvMhs.Columns.Add("nim", "NIM")
        dgvMhs.Columns.Add("namaha", "Mahasiswa")
        dgvMhs.Columns.Add("fakult", "Fakultas")
        dgvMhs.Columns.Add("jurusa", "Jurusan")
        dgvMhs.Columns.Add("smt", "Semester")
    End Sub

    Private Sub fillMHSNotAvail()
        Try
            'Dim ds = New DataSet
            'Dim sql = ""
            'Dim ole = con.CreateCommand()
            'ole.CommandText = sql
            'ole.Parameters.Add(New OleDb.OleDbParameter("@1", datas.ID))
            'ole.Parameters.Add(New OleDb.OleDbParameter("@2", idmk))
            'Dim da As New OleDb.OleDbDataAdapter(ole)
            'da.Fill(ds)
            'For i = 0 To ds.Tables(0).Rows.Count - 1
            '    Dim cmk = ds.Tables(0).Rows(i).Item(2)
            '    Dim nmk = ds.Tables(0).Rows(i).Item(3)
            '    Dim nim = ds.Tables(0).Rows(i).Item(0)
            '    Dim nama = ds.Tables(0).Rows(i).Item(1)
            '    Dim smt = ds.Tables(0).Rows(i).Item(4)

            '    dgvSiswa.Rows.Add(cmk, nmk, nim, nama, smt)
            'Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub rbIsiKelas_CheckedChanged(sender As Object, e As EventArgs)
        If rbIsiKelas.Checked Then
            btnIN.Enabled = False
            btnOUT.Enabled = True
        Else
            btnIN.Enabled = True
            btnOUT.Enabled = False
        End If
    End Sub
End Class