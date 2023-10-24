<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataAnggota
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormDataAnggota))
        dgvw1 = New DataGridView()
        GroupBox2 = New GroupBox()
        Tampil = New Button()
        Hapus = New Button()
        Ubah = New Button()
        GroupBox1 = New GroupBox()
        cbjk = New ComboBox()
        tbno = New TextBox()
        tbnama = New TextBox()
        cb_sa = New ComboBox()
        tb_a = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox3 = New GroupBox()
        Tambah = New Button()
        Button3 = New Button()
        KASKRIDATARUNABRANGLORToolStripMenuItem = New ToolStripMenuItem()
        INPUTDATAToolStripMenuItem = New ToolStripMenuItem()
        ANGGOTAKRIDATARUNAToolStripMenuItem = New ToolStripMenuItem()
        KASBULANANToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1 = New MenuStrip()
        ABOUTToolStripMenuItem = New ToolStripMenuItem()
        KELUARToolStripMenuItem = New ToolStripMenuItem()
        CType(dgvw1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvw1
        ' 
        dgvw1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvw1.Location = New Point(636, 224)
        dgvw1.Name = "dgvw1"
        dgvw1.RowHeadersWidth = 51
        dgvw1.RowTemplate.Height = 29
        dgvw1.Size = New Size(725, 392)
        dgvw1.TabIndex = 15
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Tampil)
        GroupBox2.Controls.Add(Hapus)
        GroupBox2.Controls.Add(Ubah)
        GroupBox2.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(31, 519)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(339, 97)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Tombol Operasi"
        ' 
        ' Tampil
        ' 
        Tampil.Location = New Point(228, 43)
        Tampil.Name = "Tampil"
        Tampil.Size = New Size(94, 32)
        Tampil.TabIndex = 2
        Tampil.Text = "Tampil"
        Tampil.UseVisualStyleBackColor = True
        ' 
        ' Hapus
        ' 
        Hapus.Location = New Point(13, 43)
        Hapus.Name = "Hapus"
        Hapus.Size = New Size(94, 32)
        Hapus.TabIndex = 1
        Hapus.Text = "Hapus"
        Hapus.UseVisualStyleBackColor = True
        ' 
        ' Ubah
        ' 
        Ubah.Location = New Point(122, 43)
        Ubah.Name = "Ubah"
        Ubah.Size = New Size(94, 32)
        Ubah.TabIndex = 0
        Ubah.Text = "Ubah"
        Ubah.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbjk)
        GroupBox1.Controls.Add(tbno)
        GroupBox1.Controls.Add(tbnama)
        GroupBox1.Controls.Add(cb_sa)
        GroupBox1.Controls.Add(tb_a)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(31, 212)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(579, 279)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Entri"
        ' 
        ' cbjk
        ' 
        cbjk.FormattingEnabled = True
        cbjk.Location = New Point(265, 172)
        cbjk.Name = "cbjk"
        cbjk.Size = New Size(293, 32)
        cbjk.TabIndex = 4
        ' 
        ' tbno
        ' 
        tbno.Location = New Point(265, 222)
        tbno.Name = "tbno"
        tbno.Size = New Size(293, 30)
        tbno.TabIndex = 5
        ' 
        ' tbnama
        ' 
        tbnama.Location = New Point(265, 126)
        tbnama.Name = "tbnama"
        tbnama.Size = New Size(293, 30)
        tbnama.TabIndex = 3
        ' 
        ' cb_sa
        ' 
        cb_sa.FormattingEnabled = True
        cb_sa.Location = New Point(265, 77)
        cb_sa.Name = "cb_sa"
        cb_sa.Size = New Size(293, 32)
        cb_sa.TabIndex = 2
        ' 
        ' tb_a
        ' 
        tb_a.Location = New Point(265, 34)
        tb_a.MaxLength = 3
        tb_a.Name = "tb_a"
        tb_a.PlaceholderText = "A1"
        tb_a.Size = New Size(46, 30)
        tb_a.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(8, 226)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 27)
        Label7.TabIndex = 0
        Label7.Text = "No Hp"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(7, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 27)
        Label6.TabIndex = 0
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(7, 129)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 27)
        Label5.TabIndex = 0
        Label5.Text = "Nama Anggota"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(8, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(184, 27)
        Label4.TabIndex = 0
        Label4.Text = "Status Anggota Kode"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(222, 174)
        Label12.Name = "Label12"
        Label12.Size = New Size(17, 27)
        Label12.TabIndex = 0
        Label12.Text = ":"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(223, 224)
        Label11.Name = "Label11"
        Label11.Size = New Size(17, 27)
        Label11.TabIndex = 0
        Label11.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(222, 127)
        Label10.Name = "Label10"
        Label10.Size = New Size(17, 27)
        Label10.TabIndex = 0
        Label10.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(223, 78)
        Label8.Name = "Label8"
        Label8.Size = New Size(17, 27)
        Label8.TabIndex = 0
        Label8.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(223, 36)
        Label9.Name = "Label9"
        Label9.Size = New Size(17, 27)
        Label9.TabIndex = 0
        Label9.Text = ":"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(8, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 27)
        Label3.TabIndex = 0
        Label3.Text = "Anggota Kode"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(19, 52)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 99)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(128, 102)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(787, 43)
        Label2.TabIndex = 10
        Label2.Text = "KAS RUTIN KRIDATARUNA BRANGLOR MANCASAN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(128, 59)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(368, 43)
        Label1.TabIndex = 11
        Label1.Text = "INPUT DATA ANGGOTA"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Tambah)
        GroupBox3.Controls.Add(Button3)
        GroupBox3.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(376, 519)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(234, 97)
        GroupBox3.TabIndex = 14
        GroupBox3.TabStop = False
        GroupBox3.Text = "Tombol Tambah"
        ' 
        ' Tambah
        ' 
        Tambah.Location = New Point(16, 43)
        Tambah.Name = "Tambah"
        Tambah.Size = New Size(94, 32)
        Tambah.TabIndex = 1
        Tambah.Text = "Tambah"
        Tambah.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(126, 43)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 32)
        Button3.TabIndex = 0
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' KASKRIDATARUNABRANGLORToolStripMenuItem
        ' 
        KASKRIDATARUNABRANGLORToolStripMenuItem.Name = "KASKRIDATARUNABRANGLORToolStripMenuItem"
        KASKRIDATARUNABRANGLORToolStripMenuItem.Size = New Size(235, 26)
        KASKRIDATARUNABRANGLORToolStripMenuItem.Text = "KAS KRIDATARUNA BRANGLOR"
        ' 
        ' INPUTDATAToolStripMenuItem
        ' 
        INPUTDATAToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ANGGOTAKRIDATARUNAToolStripMenuItem, KASBULANANToolStripMenuItem})
        INPUTDATAToolStripMenuItem.Name = "INPUTDATAToolStripMenuItem"
        INPUTDATAToolStripMenuItem.Size = New Size(120, 26)
        INPUTDATAToolStripMenuItem.Text = "MODIFY DATA"
        ' 
        ' ANGGOTAKRIDATARUNAToolStripMenuItem
        ' 
        ANGGOTAKRIDATARUNAToolStripMenuItem.Name = "ANGGOTAKRIDATARUNAToolStripMenuItem"
        ANGGOTAKRIDATARUNAToolStripMenuItem.Size = New Size(266, 26)
        ANGGOTAKRIDATARUNAToolStripMenuItem.Text = "ANGGOTA KRIDATARUNA"
        ' 
        ' KASBULANANToolStripMenuItem
        ' 
        KASBULANANToolStripMenuItem.Name = "KASBULANANToolStripMenuItem"
        KASBULANANToolStripMenuItem.Size = New Size(266, 26)
        KASBULANANToolStripMenuItem.Text = "KAS BULANAN"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {KASKRIDATARUNABRANGLORToolStripMenuItem, INPUTDATAToolStripMenuItem, ABOUTToolStripMenuItem, KELUARToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 2, 0, 2)
        MenuStrip1.Size = New Size(1400, 30)
        MenuStrip1.TabIndex = 16
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ABOUTToolStripMenuItem
        ' 
        ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        ABOUTToolStripMenuItem.Size = New Size(72, 26)
        ABOUTToolStripMenuItem.Text = "ABOUT"
        ' 
        ' KELUARToolStripMenuItem
        ' 
        KELUARToolStripMenuItem.Name = "KELUARToolStripMenuItem"
        KELUARToolStripMenuItem.Size = New Size(79, 26)
        KELUARToolStripMenuItem.Text = "KELUAR"
        ' 
        ' FormDataAnggota
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(1400, 682)
        Controls.Add(MenuStrip1)
        Controls.Add(dgvw1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormDataAnggota"
        Text = "FormDataAnggota"
        CType(dgvw1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvw1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbno As TextBox
    Friend WithEvents tbnama As TextBox
    Friend WithEvents cb_sa As ComboBox
    Friend WithEvents tb_a As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Ubah As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Tambah As Button
    Friend WithEvents cbjk As ComboBox
    Friend WithEvents KASKRIDATARUNABRANGLORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INPUTDATAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ANGGOTAKRIDATARUNAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KASBULANANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Hapus As Button
    Friend WithEvents Tampil As Button
    Friend WithEvents KELUARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
End Class
