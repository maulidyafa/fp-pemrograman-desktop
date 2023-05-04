Public Class Formdtcustomer

    Dim datacust(,) As String

    Private Sub Formdtcustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim datacust(100, 4)
    End Sub
    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        formutama.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Dim i As Integer
    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        datacust(i, 0) = txt_idcust.Text
        datacust(i, 1) = txt_namacust.Text
        If RadioButton1.Checked = True Then
            datacust(i, 2) = "Laki-Laki"
        Else
            datacust(i, 2) = "Perempuan"
        End If
        datacust(i, 3) = txt_telp.Text
        datacust(i, 4) = txt_alamat.Text
        i += 1
        ListViewCust.Items.Clear()

        For k As Integer = 0 To datacust.GetUpperBound(0)
            ListViewCust.Items.Add(datacust(k, 0))
            ListViewCust.Items(ListViewCust.Items.Count - 1).SubItems.Add(datacust(k, 1))
            ListViewCust.Items(ListViewCust.Items.Count - 1).SubItems.Add(datacust(k, 2))
            ListViewCust.Items(ListViewCust.Items.Count - 1).SubItems.Add(datacust(k, 3))
            ListViewCust.Items(ListViewCust.Items.Count - 1).SubItems.Add(datacust(k, 4))
        Next
        'Membersihkan data inputan
        txt_idcust.Text = ""
        txt_namacust.Text = ""
        RadioButton1.Checked = 0
        RadioButton2.Checked = 0
        txt_telp.Text = ""
        txt_alamat.Text = ""
    End Sub
End Class