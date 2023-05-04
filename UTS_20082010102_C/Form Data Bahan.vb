Public Class Formdtbahan

    Dim databhn(,) As String
    Dim namabhn() As String = {"Telur", "Keju", "Sosis", "Jamur", "Tepung"}
    Dim str As String

    Private Sub Formdtbahan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim databhn(100, 3)
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        Formutama.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btn_inputbhn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_inputbhn.Click
        str = ""
        For i As Integer = 0 To namabhn.GetUpperBound(0)
            comb_namabhn.Items.Add(namabhn(i))
        Next
    End Sub

    Private Sub comb_namabhn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comb_namabhn.SelectedIndexChanged
        str = ""
        Select Case comb_namabhn.Text
            Case "Telur"
                txt_idbahan.Text = "B001"
            Case "Keju"
                txt_idbahan.Text = "B002"
            Case "Sosis"
                txt_idbahan.Text = "B003"
            Case "Jamur"
                txt_idbahan.Text = "B004"
            Case "Tepung"
                txt_idbahan.Text = "B005"
        End Select
    End Sub
    Dim i As Integer

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        databhn(i, 0) = txt_idbahan.Text
        databhn(i, 1) = comb_namabhn.Text
        databhn(i, 2) = txt_jumlah.Text
        databhn(i, 3) = txt_hargabhn.Text
        i += 1
        ListViewbahan.Items.Clear()

        For k As Integer = 0 To databhn.GetUpperBound(0)
            ListViewbahan.Items.Add(databhn(k, 0))
            ListViewbahan.Items(ListViewbahan.Items.Count - 1).SubItems.Add(databhn(k, 1))
            ListViewbahan.Items(ListViewbahan.Items.Count - 1).SubItems.Add(databhn(k, 2))
            ListViewbahan.Items(ListViewbahan.Items.Count - 1).SubItems.Add(databhn(k, 3))
        Next
        txt_idbahan.Text = ""
        comb_namabhn.Text = ""
        txt_jumlah.Text = ""
        txt_hargabhn.Text = ""
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class