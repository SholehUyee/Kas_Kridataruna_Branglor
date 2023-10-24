<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2Aboutvb
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2Aboutvb))
        MenuStrip1 = New MenuStrip()
        KASKRIDATARUNABRANGLORToolStripMenuItem = New ToolStripMenuItem()
        INPUTDATAToolStripMenuItem = New ToolStripMenuItem()
        ANGGOTAKRIDATARUNAToolStripMenuItem = New ToolStripMenuItem()
        KASBULANANToolStripMenuItem = New ToolStripMenuItem()
        ABOUTToolStripMenuItem = New ToolStripMenuItem()
        KELUARToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {KASKRIDATARUNABRANGLORToolStripMenuItem, INPUTDATAToolStripMenuItem, ABOUTToolStripMenuItem, KELUARToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 2, 0, 2)
        MenuStrip1.Size = New Size(1256, 30)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
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
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(22, 52)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 99)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(131, 102)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(787, 43)
        Label2.TabIndex = 18
        Label2.Text = "KAS RUTIN KRIDATARUNA BRANGLOR MANCASAN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(131, 59)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 43)
        Label1.TabIndex = 19
        Label1.Text = "ABOUT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Location = New Point(70, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(859, 24)
        Label3.TabIndex = 21
        Label3.Text = "Program untuk memudahkan kridataruna atau muda - mudi dukuh branglor, mancasan, dalam hal mendata kas rutin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Location = New Point(70, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(654, 24)
        Label4.TabIndex = 21
        Label4.Text = "setiap pertemuan rapat kridataruna branglor, dalam program terdiri dari pengolahan data "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Location = New Point(70, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(473, 24)
        Label5.TabIndex = 21
        Label5.Text = "anggota kridataruna dan pengolahan data kas bulanan anggota."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Location = New Point(70, 266)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 24)
        Label6.TabIndex = 21
        Label6.Text = "Dibuat Oleh : "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Location = New Point(207, 266)
        Label7.Name = "Label7"
        Label7.Size = New Size(135, 24)
        Label7.TabIndex = 21
        Label7.Text = "ILHAM SHOLEH"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Location = New Point(207, 301)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 24)
        Label8.TabIndex = 21
        Label8.Text = "190103013"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Location = New Point(207, 336)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 24)
        Label9.TabIndex = 21
        Label9.Text = "TI-19A1"
        ' 
        ' Form2Aboutvb
        ' 
        AutoScaleDimensions = New SizeF(10F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(1256, 689)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form2Aboutvb"
        Text = "Form2Aboutvb"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KASKRIDATARUNABRANGLORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INPUTDATAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ANGGOTAKRIDATARUNAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KASBULANANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
