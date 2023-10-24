Imports MySql.Data.MySqlClient
Public Class FormDataKas
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
            Query = "Select * from t_kas_bulanan"
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
            Query = "Select anggota_kode from t_anggota"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sanggota_kode = READER.GetString("anggota_kode")
                cbak.Items.Add(sanggota_kode)
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Sub teksaktif()
        tb_k.Enabled = True
        cbak.Enabled = True
        dt.Enabled = True
        tb_np.Enabled = True
        tbpk.Enabled = True
        tb_kt.Enabled = True
    End Sub

    Sub teksnonaktif()
        tb_k.Enabled = True
        cbak.Enabled = False
        dt.Enabled = False
        tb_np.Enabled = False
        tbpk.Enabled = False
        tb_kt.Enabled = False
    End Sub

    Sub kosongteks()
        tb_k.Text = ""
        cbak.Text = ""
        dt.Text = ""
        tb_np.Text = ""
        tbpk.Text = ""
        tb_kt.Text = ""

    End Sub

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub KASKRIDATARUNABRANGLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KASKRIDATARUNABRANGLORToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub KELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub dgvw1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvw1.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Tampil.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * from t_kas_bulanan"
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

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from t_kas_bulanan where kas_bulanan_kode='" & tb_k.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data KAS Berhasil Dihapus")
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

    Private Sub ANGGOTAKRIDATARUNAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ANGGOTAKRIDATARUNAToolStripMenuItem1.Click
        FormDataAnggota.Show()
        Me.Hide()
    End Sub

    Private Sub FormDataKas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbatampil()
    End Sub

    Private Sub Ubah_Click(sender As Object, e As EventArgs) Handles Ubah.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update t_kas_bulanan set kas_bulanan_kode='" & tb_k.Text & "', anggota_kode='" & cbak.Text & "', tanggal_kas='" & dt.Text & "', nominalpembayaran_kas='" & tb_np.Text & "', pembayaran_kas_anggota='" & tbpk.Text & "', keterangan='" & tb_kt.Text & "' where kas_bulanan_kode='" & tb_k.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Kas Bulanan Berhasil Diubah")
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

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;user=root;password=;database=kas_branglor"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into t_kas_bulanan (kas_bulanan_kode, anggota_kode, tanggal_kas, nominalpembayaran_kas, pembayaran_kas_anggota, keterangan) value ('" & tb_k.Text & "', '" & cbak.Text & "', '" & dt.Text & "', '" & tb_np.Text & "', '" & tbpk.Text & "', '" & tb_kt.Text & "')"

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

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        kosongteks()
        teksaktif()
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        Form2Aboutvb.Show()
        Me.Hide()
    End Sub
End Class