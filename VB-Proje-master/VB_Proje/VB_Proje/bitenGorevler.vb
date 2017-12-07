Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class bitenGorevler
    Class Rapor
        Protected tarih As Date
        Protected personelBilgisi As String
        Protected gorevAdi As String
        Protected aciklama As String
        Protected gorevTuru As String
        Protected birim As String
        Protected baslangicTarihi As String
        Protected bitisTarihi As String
        Public Sub raporOlustur(ByVal gun As Boolean, ByVal hafta As Boolean, ByVal ay As Boolean, ByVal personel As String)
            If gun <> False Then
                Dim baglanti As New SqlConnection("Data Source=10.40.125.46;User ID=Deneme;Password=123456;")
                baglanti.Open()
                Dim comm As New SqlCommand("SELECT Ad,Soyad,GorevAdı,GorevAciklaması,GorevTuru,GorevBirimi,BaslangicTarihi,BitisTarihi FROM Personeller,Gorevler Where Gorevler Date(BitisTarihi) = CURDATE()", baglanti)
                Dim adaptor As New SqlDataAdapter(comm)
                Dim table As New DataTable
                adaptor.Fill(table)
                For i = 0 To table.Rows.Count - 1
                    If String.Compare(personel, table.Rows(i).Item(0).ToString + table.Rows(i).Item(1)) = 0 Then
                        personelBilgisi = table.Rows(i).Item(0).ToString + table.Rows(i).Item(1)
                        gorevAdi = table.Rows(i).Item(2).ToString
                        aciklama = table.Rows(i).Item(3).ToString
                        gorevTuru = table.Rows(i).Item(4).ToString
                        birim = table.Rows(i).Item(5).ToString
                        baslangicTarihi = table.Rows(i).Item(6).ToString
                        bitisTarihi = table.Rows(i).Item(7).ToString
                    End If
                Next

                Dim raporAdi As String = personel + ".doc"
                Dim strFile As String = raporAdi
                Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
                    sw.WriteLine(Date.Today.ToString("G"))
                    sw.WriteLine(personelBilgisi)
                    sw.WriteLine(gorevAdi)
                    sw.WriteLine(aciklama)
                    sw.WriteLine(gorevTuru)
                    sw.WriteLine(birim)
                    sw.WriteLine(baslangicTarihi)
                    sw.WriteLine(bitisTarihi)
                End Using
            End If
            If hafta <> False Then
                Dim baglanti As New SqlConnection("Data Source=10.40.125.46;User ID=Deneme;Password=123456;")
                baglanti.Open()
                Dim comm As New SqlCommand("SELECT Ad,Soyad,GorevAdı,GorevAciklaması,GorevTuru,GorevBirimi,BaslangicTarihi,BitisTarihi FROM Personeller,Gorevler WHERE YEARWEEK(BitisTarihi) = YEARWEEK(CURRENT_DATE)", baglanti)
                Dim adaptor As New SqlDataAdapter(comm)
                Dim table As New DataTable
                adaptor.Fill(table)
                For i = 0 To table.Rows.Count - 1
                    If String.Compare(personel, table.Rows(i).Item(0).ToString + table.Rows(i).Item(1)) = 0 Then
                        personelBilgisi = table.Rows(i).Item(0).ToString + table.Rows(i).Item(1)
                        gorevAdi = table.Rows(i).Item(2).ToString
                        aciklama = table.Rows(i).Item(3).ToString
                        gorevTuru = table.Rows(i).Item(4).ToString
                        birim = table.Rows(i).Item(5).ToString
                        baslangicTarihi = table.Rows(i).Item(6).ToString
                        bitisTarihi = table.Rows(i).Item(7).ToString
                    End If
                Next
                Dim raporAdi As String = personel + ".doc"
                Dim strFile As String = raporAdi
                Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
                    sw.WriteLine(Date.Today.ToString("G"))
                    sw.WriteLine(personelBilgisi)
                    sw.WriteLine(gorevAdi)
                    sw.WriteLine(aciklama)
                    sw.WriteLine(gorevTuru)
                    sw.WriteLine(birim)
                    sw.WriteLine(baslangicTarihi)
                    sw.WriteLine(bitisTarihi)
                End Using
            End If
            If ay <> False Then
                Dim baglanti As New SqlConnection("Data Source=10.40.125.46;User ID=Deneme;Password=123456;")
                baglanti.Open()
                Dim comm As New SqlCommand("SELECT Ad,Soyad,GorevAdı,GorevAciklaması,GorevTuru,GorevBirimi,BaslangicTarihi,BitisTarihi FROM Personeller,Gorevler BitisTarihi >= DATE_SUB(CURDATE(), INTERVAL 1 MONTH) ", baglanti)
                Dim adaptor As New SqlDataAdapter(comm)
                Dim table As New DataTable
                adaptor.Fill(table)
                For i = 0 To table.Rows.Count - 1
                    If String.Compare(personel, table.Rows(i).Item(0).ToString + table.Rows(i).Item(1)) = 0 Then
                        personelBilgisi = table.Rows(i).Item(0).ToString + table.Rows(i).Item(1)
                        gorevAdi = table.Rows(i).Item(2).ToString
                        aciklama = table.Rows(i).Item(3).ToString
                        gorevTuru = table.Rows(i).Item(4).ToString
                        birim = table.Rows(i).Item(5).ToString
                        baslangicTarihi = table.Rows(i).Item(6).ToString
                        bitisTarihi = table.Rows(i).Item(7).ToString
                    End If
                Next
                Dim raporAdi As String = personel + ".doc"
                Dim trFile As String = raporAdi
                Using rw As New StreamWriter(File.Open(trFile, FileMode.OpenOrCreate))
                    rw.WriteLine(Date.Today.ToString("G"))
                    rw.WriteLine(personelBilgisi)
                    rw.WriteLine(gorevAdi)
                    rw.WriteLine(aciklama)
                    rw.WriteLine(gorevTuru)
                    rw.WriteLine(birim)
                    rw.WriteLine(baslangicTarihi)
                    rw.WriteLine(bitisTarihi)
                End Using
            End If
        End Sub
    End Class

    Private Sub bitenGorevler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_rapor_Click(sender As Object, e As EventArgs) Handles btn_rapor.Click
        Dim a As New Rapor
        Dim personel As String = lb_bitenGorevler.SelectedItem
        a.raporOlustur(CheckBox1.Checked, CheckBox2.Checked, CheckBox3.Checked, personel)
    End Sub

    Private Sub cb_personel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_bitenGorevler.SelectedIndexChanged
        Dim personel As String
        personel = lb_bitenGorevler.SelectedIndex
        Dim baglanti As New SqlConnection("Data Source=10.40.125.46;User ID=Deneme;Password=123456;")
        baglanti.Open()
        Dim bitirilenGorevSayisi As Integer = 0
        Dim comm As New SqlCommand("SELECT Ad,Soyad,GorevAdı,GorevAciklaması,GorevTuru,GorevBirimi,BaslangicTarihi,BitisTarihi FROM Personeller,Gorevler WHERE BitisTarihi IS NOT NULL", baglanti)
        Dim adaptor As New SqlDataAdapter(comm)
        Dim table As New DataTable
        adaptor.Fill(table)
        For i = 0 To table.Rows.Count - 1
            If String.Compare(personel, table.Rows(i).Item(0).ToString + table.Rows(i).Item(1)) = 0 Then
                lb_bitenGorevler.Text = table.Rows(i).Item(2).ToString
            End If
        Next
    End Sub

End Class