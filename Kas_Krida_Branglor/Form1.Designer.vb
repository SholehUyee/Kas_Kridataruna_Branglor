<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        KASKRIDATARUNABRANGLORToolStripMenuItem = New ToolStripMenuItem()
        INPUTDATAToolStripMenuItem = New ToolStripMenuItem()
        ANGGOTAKRIDATARUNAToolStripMenuItem = New ToolStripMenuItem()
        KASBULANANToolStripMenuItem = New ToolStripMenuItem()
        ABOUTToolStripMenuItem = New ToolStripMenuItem()
        KELUARToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
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
        MenuStrip1.TabIndex = 12
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(402, 547)
        Label2.Name = "Label2"
        Label2.Size = New Size(414, 46)
        Label2.TabIndex = 10
        Label2.Text = "BRANGLOR MANCASAN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(377, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(463, 46)
        Label1.TabIndex = 11
        Label1.Text = "KAS RUTIN KRIDATARUNA "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(452, 192)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(321, 324)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(1256, 689)
        Controls.Add(MenuStrip1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As ToolStripMenuItem
End Class
