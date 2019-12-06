'２０１９年　Davin Alfarizky Putra Basudewa　がこのプロガムを作ってみました
'忘れればのコードには私を連絡してください。

Public Class loginScreen
    Dim con As OleDb.OleDbConnection
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim isMhs = True
            Dim ole As OleDb.OleDbCommand = con.CreateCommand

            Dim user = userText.Text
            Dim password = passwordText.Text

            If rbMhs.Checked And Not user.Contains("admin") Then
                ole.CommandText = "SELECT * FROM userLoginMahasiswa WHERE ID = @1 AND password = @2 "
            ElseIf rbDsn.Checked And Not user.Contains("admin") Then
                isMhs = False
                ole.CommandText = "SELECT * FROM userLoginDosen WHERE ID = @1 AND password = @2 "
            ElseIf user.Contains("admin") Then
                admindashboard.ShowDialog()

            End If




            ole.Parameters.Add(New OleDb.OleDbParameter("@1", user))
            ole.Parameters.Add(New OleDb.OleDbParameter("@2", password))

            Dim reader = ole.ExecuteReader
            If reader.Read Then
                If reader.FieldCount <> 0 Then
                    Dim um As userdata = New userdata
                    um.ID = reader(0).ToString
                    If isMhs Then
                        um.ASS = 2
                        dashboardMhs.users = um
                        dashboardMhs.ShowDialog()
                    Else
                        um.ASS = 1
                        dashboardDsn.users = um
                        dashboardDsn.ShowDialog()
                    End If
                End If
            Else
                MessageBox.Show("User/Password wrong", "Can't login")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = connect()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
