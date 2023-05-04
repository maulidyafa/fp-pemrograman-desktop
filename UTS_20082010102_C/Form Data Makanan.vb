Public Class Formdtmakan

    Dim datamkn(,) As String
    Dim nmmakan() As String = {"California Pizza", "New York Pizza", "Pepperoni Pizza", "Greek Pizza", "Neapolitan Pizza"}
    Dim str As String

    Private Sub Formdtmakan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim datamkn(100, 3)
    End Sub

    Private Sub btn_inputnm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_inputnm.Click
        str = ""
        For i As Integer = 0 To nmmakan.GetUpperBound(0)
            comb_namamkn.Items.Add(nmmakan(i))
        Next
    End Sub

    Private Sub comb_namamkn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comb_namamkn.SelectedIndexChanged
        str = ""
        Select Case comb_namamkn.Text
            Case "California Pizza"
                txt_idmkn.Text = "A100"
            Case "New York Pizza"
                txt_idmkn.Text = "A101"
            Case "Pepperoni Pizza"
                txt_idmkn.Text = "A102"
            Case "Greek Pizza"
                txt_idmkn.Text = "A103"
            Case "Neapolitan Pizza"
                txt_idmkn.Text = "A104"
        End Select
    End Sub

    Dim i As Integer


    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        datamkn(i, 0) = txt_idmkn.Text
        datamkn(i, 1) = comb_namamkn.Text
        datamkn(i, 2) = txt_jum.Text
        datamkn(i, 3) = txt_harga.Text
        i += 1
        ListView1.Items.Clear()

        For k As Integer = 0 To datamkn.GetUpperBound(0)
            ListView1.Items.Add(datamkn(k, 0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(datamkn(k, 1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(datamkn(k, 2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(datamkn(k, 3))
        Next
        txt_idmkn.Text = ""
        comb_namamkn.Text = ""
        txt_jum.Text = ""
        txt_harga.Text = ""
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        formutama.Show()
        Me.Hide()
    End Sub
End Class