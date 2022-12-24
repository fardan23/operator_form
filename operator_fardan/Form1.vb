Public Class Form1
    Public nilai1, nilai2, hasil As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        nilai1 = TextBox1.Text
        nilai2 = TextBox2.Text
        hasil = (nilai1 + nilai2)

        TextBox3.Text = hasil
    End Sub

    Private Sub btnkurang_Click(sender As Object, e As EventArgs) Handles btnkurang.Click
        nilai1 = TextBox1.Text
        nilai2 = TextBox2.Text
        hasil = (nilai1 - nilai2)

        TextBox3.Text = hasil
    End Sub

    Private Sub btnkali_Click(sender As Object, e As EventArgs) Handles btnkali.Click
        nilai1 = TextBox1.Text
        nilai2 = TextBox2.Text
        hasil = (nilai1 * nilai2)

        TextBox3.Text = hasil
    End Sub

    Private Sub btnbagi_Click(sender As Object, e As EventArgs) Handles btnbagi.Click
        nilai1 = TextBox1.Text
        nilai2 = TextBox2.Text
        hasil = (nilai1 / nilai2)

        TextBox3.Text = hasil
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Dim pesan As String
        pesan = MsgBox("Kamu nanya kenapa aku keluar?", vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
            Close()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
