Public Class Form1


    Private Sub ANGGOTAKRIDATARUNAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ANGGOTAKRIDATARUNAToolStripMenuItem.Click
        FormDataAnggota.Show()
        Me.Hide()
    End Sub

    Private Sub KASBULANANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KASBULANANToolStripMenuItem.Click
        FormDataKas.Show()
        Me.Hide()
    End Sub

    Private Sub KELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        Form2Aboutvb.Show()
        Me.Hide()

    End Sub

    Private Sub INPUTDATAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INPUTDATAToolStripMenuItem.Click

    End Sub
End Class
