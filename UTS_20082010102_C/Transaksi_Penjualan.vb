Public Class Transaksi_Penjualan

    Dim transaksi(,) As String
    Dim nmmakan() As String = {"California Pizza", "New York Pizza", "Pepperoni Pizza", "Greek Pizza", "Neapolitan Pizza"}
    Dim str As String

    Private Sub Transaksi_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim transaksi(100, 5)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        formutama.Show()
        Me.Hide()
    End Sub

    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        str = ""
        For i As Integer = 0 To nmmakan.GetUpperBound(0)
            comb_namamkn.Items.Add(nmmakan(i))
        Next
    End Sub

    Dim harga As Integer

    Private Sub comb_namamkn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comb_namamkn.SelectedIndexChanged
        str = ""
        If comb_namamkn.Text = "California Pizza" Then
            harga = 150000
        ElseIf comb_namamkn.Text = "New York Pizza" Then
            harga = 120000
        ElseIf comb_namamkn.Text = "Pepperoni Pizza" Then
            harga = 90000
        ElseIf comb_namamkn.Text = "Greek Pizza" Then
            harga = 100000
        ElseIf comb_namamkn.Text = "Neapolitan Pizza" Then
            harga = 200000
        End If
    End Sub

    Dim toping As Integer

    Private Sub btn_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            toping = 10000
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            toping = 10000
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = True Then
            toping = 10000
        ElseIf CheckBox1.Checked And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            toping = 20000
        ElseIf CheckBox1.Checked And CheckBox3.Checked = True And CheckBox2.Checked = False Then
            toping = 20000
        ElseIf CheckBox2.Checked And CheckBox3.Checked = True And CheckBox1.Checked = False Then
            toping = 20000
        Else : CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True
            toping = 30000
        End If
    End Sub

    Private Sub btn_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hitung.Click
        txt_total.Text = (harga + toping) * txt_jumbeli.Text
    End Sub

    Private Sub btn_bayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bayar.Click
        txt_kembalian.Text = Val(txt_bayar.Text) - Val(txt_total.Text)
    End Sub

    Dim i As Integer

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        transaksi(i, 0) = txt_nota.Text
        transaksi(i, 1) = txt_tanggal.Text
        transaksi(i, 2) = comb_namamkn.Text
        If CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            transaksi(i, 3) = "Keju"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            transaksi(i, 3) = "Jamur"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = True Then
            transaksi(i, 3) = "Sosis"
        ElseIf CheckBox1.Checked And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            transaksi(i, 3) = "Keju, Jamur"
        ElseIf CheckBox1.Checked And CheckBox3.Checked = True And CheckBox2.Checked = False Then
            transaksi(i, 3) = "Keju, Sosis"
        ElseIf CheckBox2.Checked And CheckBox3.Checked = True And CheckBox1.Checked = False Then
            transaksi(i, 3) = "Jamur, Sosis"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            transaksi(i, 3) = "Keju, Jamur, Sosis"
        End If
        transaksi(i, 4) = txt_jumbeli.Text
        transaksi(i, 5) = txt_total.Text
        i += 1
        ListView1.Items.Clear()

        For k As Integer = 0 To transaksi.GetUpperBound(0)
            ListView1.Items.Add(transaksi(k, 0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(transaksi(k, 1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(transaksi(k, 2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(transaksi(k, 3))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(transaksi(k, 4))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(transaksi(k, 5))
        Next
        txt_nota.Text = ""
        txt_tanggal.Text = ""
        comb_namamkn.Text = ""
        CheckBox1.Checked = 0
        CheckBox2.Checked = 0
        CheckBox3.Checked = 0
        txt_jumbeli.Text = ""
        txt_total.Text = ""
        txt_bayar.Text = ""
        txt_kembalian.Text = ""
    End Sub
End Class