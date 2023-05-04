Public Class Formutama
    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DataMakananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataMakananToolStripMenuItem.Click
        Formdtmakan.Show()
        Me.Hide()
    End Sub

    Private Sub DataBahanBakuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBahanBakuToolStripMenuItem.Click
        Formdtbahan.Show()
        Me.Hide()
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPelangganToolStripMenuItem.Click
        Formdtcustomer.Show()
        Me.Hide()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        Transaksi_Penjualan.Show()
        Me.Hide()
    End Sub
End Class