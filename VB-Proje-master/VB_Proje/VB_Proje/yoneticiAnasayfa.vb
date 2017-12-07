Public Class yoneticiAnasayfa
    Private Sub btn_bitenGorevler_Click(sender As Object, e As EventArgs) Handles btn_bitenGorevler.Click, btn_cikis.Click
        bitenGorevler.Show()
    End Sub

    Private Sub btn_personelBilgisi_Click(sender As Object, e As EventArgs) Handles btn_personelBilgisi.Click
        personelBilgileri.Show()
    End Sub
End Class