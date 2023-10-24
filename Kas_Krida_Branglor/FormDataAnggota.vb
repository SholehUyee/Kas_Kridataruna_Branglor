Imports MySql.Data.MySqlClient
Public Class FormDataAnggota
    Private Sub load_table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from t_anggota"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bSource.DataSource = dbdataset
            dgvw1.DataSource = bSource
            SDA.Update(dbdataset)

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Sub cbatampil()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select statusanggota_kode from t_statusanggota"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sstatusanggota_kode = READER.GetString("statusanggota_kode")
                cb_sa.Items.Add(sstatusanggota_kode)
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Sub cbjktampil()
        cbjk.Items.Add("Laki - Laki")
        cbjk.Items.Add("Perempuan")
    End Sub

    Sub teksaktif()
        tb_a.Enabled = True
        cb_sa.Enabled = True
        tbnama.Enabled = True
        cbjk.Enabled = True
        tbno.Enabled = True
    End Sub

    Sub kosongteks()
        tb_a.Text = ""
        cb_sa.Text = ""
        tbnama.Text = ""
        cbjk.Text = ""
        tbno.Text = ""
    End Sub


    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub KELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub KASKRIDATARUNABRANGLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KASKRIDATARUNABRANGLORToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into t_anggota (anggota_kode, statusanggota_kode, nama_anggota, jenis_kelamin, no_hp) values ('" & tb_a.Text & "','" & cb_sa.Text & "','" & tbnama.Text & "','" & cbjk.Text & "','" & tbno.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Anggota Berhasil Ditambahkan")
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        load_table()
        teksaktif()
    End Sub


    Private Sub KASBULANANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KASBULANANToolStripMenuItem.Click
        FormDataKas.Show()
        Me.Hide()
    End Sub

    Private Sub Ubah_Click(sender As Object, e As EventArgs) Handles Ubah.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update t_anggota set anggota_kode='" & tb_a.Text & "', statusanggota_kode='" & cb_sa.Text & "', nama_anggota='" & tbnama.Text & "', jenis_kelamin='" & cbjk.Text & "', no_hp='" & tbno.Text & "' where anggota_kode='" & tb_a.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Anggota Berhasil Diubah")
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        load_table()
        teksaktif()
        kosongteks()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from t_anggota where anggota_kode='" & tb_a.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Anggota Berhasil Dihapus")
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        load_table()
        teksaktif()
        kosongteks()
    End Sub

    Private Sub FormDataAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbatampil()
        cbjktampil()

    End Sub

    Private Sub Tampil_Click(sender As Object, e As EventArgs) Handles Tampil.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from t_anggota"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bSource.DataSource = dbdataset
            dgvw1.DataSource = bSource
            SDA.Update(dbdataset)

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        teksaktif()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        kosongteks()
        teksaktif()
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        Form2Aboutvb.Show()
        Me.Hide()
    End Sub
End Class