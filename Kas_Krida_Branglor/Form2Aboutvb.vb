Public Class Form2Aboutvb
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click, Label8.Click, Label9.Click

    End Sub

    Private Sub KASKRIDATARUNABRANGLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KASKRIDATARUNABRANGLORToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub KELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ANGGOTAKRIDATARUNAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ANGGOTAKRIDATARUNAToolStripMenuItem.Click
        FormDataAnggota.Show()
        Me.Hide()
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click

    End Sub

    Private Sub KASBULANANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KASBULANANToolStripMenuItem.Click
        FormDataKas.Show()
        Me.Hide()
    End Sub
End Class