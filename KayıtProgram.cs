using OkulIK.Interface;
using System;
using System.Collections;
using System.Diagnostics;

namespace OkulIK
{
    //İlgili İnterfaceler Programa kayıt edildi.
    public class KayıtProgram :  IOgrenci, IOgretimGorevlisi, IIdare, IDersler, IOgrenciDersler, IOgrenciis
    {
        public int OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarih { get; set; }
        public Enumlar.Bolumler Bolum { get; set; }
        public string Sınıfı { get; set; }
        public int NotOrtalamasi { get; set; }
        public int KimlikNo { get; set; }
        public Enumlar.Gorevi Gorev { get; set; }
        public int DersNo { get; set; }
        public string Acıklama { get; set; }
        IOgrenci IOgrenciDersler.OgrenciNo { get; set; }
        IOgretimGorevlisi IDersler.OgretimGorevlisi { get; set; }

        static void Main(string[] args)
        {

            ArrayList a = new ArrayList(); //Menu olusturuldu.
        basa:
            Console.WriteLine(".......Ogrenci Kayit Sistemi.......");
            Console.WriteLine("...................................");
            Console.WriteLine("Yapacaginiz islemi seciniz.........");
            Console.WriteLine("1-Ogrenci Kayit Ekleme");
            Console.WriteLine("2-Ogrenci Kayit Silme");
            Console.WriteLine("3-Ogrenci Kayit Goruntuleme");
            Console.WriteLine("4-Diziyi ters cevir");
            Console.WriteLine("5-Kayit Kontrol");
            Console.WriteLine("6-Diziyi sirala");
            Console.WriteLine("7-Personel Kayıt Ekleme");
            Console.WriteLine("8-Personel Kayıt Silme");
            Console.WriteLine("9-Personel Kayıt Goruntuleme");
            Console.WriteLine("10-Idari Personel Kayıt Ekleme");
            Console.WriteLine("11-Idari Personel Kayıt Silme");
            Console.WriteLine("12-Idari Personel Kayıt Goruntuleme");
            Console.WriteLine("13-Ogretim Gorevlisi Kayit Ekleme");
            Console.WriteLine("14-Ogretim Gorevlisi Kayit Silme");
            Console.WriteLine("15-Ogretim Gorevlisi Kayit Goruntuleme");
            Console.WriteLine("16-Ders Kayit Ekleme");
            Console.WriteLine("17-Ders Kayit Silme");
            Console.WriteLine("18-Ders Kayit Goruntuleme");
            Console.WriteLine("19-Tum kayitlari sil!");
            Console.WriteLine("20-Ogrenci Kayit Cikis");
            Console.WriteLine("...................................");
            Console.WriteLine(" ");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)//Menuyu yaptıktan sonra switch case ile ilgili alanları ayarlıyorum.
            {
                case 1:
                    Console.WriteLine(" ");
                    Console.WriteLine("Ogrenci Kayit Ekleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit yapacaginiz ogrenci sayisini giriniz :");
                    int sayi = int.Parse(s: Console.ReadLine());
                    for (int i = 0; i < sayi; i++)
                    {
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogrencinin OgrenciNo giriniz :", i + 1);
                        string ogrencino = Console.ReadLine();
                        a.Add(ogrencino);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogrencinin Adini giriniz :", i + 2);
                        string ad = Console.ReadLine();
                        a.Add(ad);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogrencinin Soyadini giriniz :", i + 3);
                        string soyad = Console.ReadLine();
                        a.Add(soyad);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogrencinin DogumTarihi giriniz :", i + 4);
                        string dogumtarihi = Console.ReadLine();
                        a.Add(dogumtarihi);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogrencinin Bolumu giriniz :", i + 5);
                        string bolumu = Console.ReadLine();
                        a.Add(bolumu);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogrencinin Sinifi giriniz :", i + 6);
                        string sinifi = Console.ReadLine();
                        a.Add(sinifi);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogrencinin NotOrtalamasi giriniz :", i + 7);
                        string notortalamasi = Console.ReadLine();
                        a.Add(notortalamasi);

                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit ekleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 2:
                    Console.WriteLine(" ");
                    Console.WriteLine("Ogrenci Kayit Silme Ekranina Hosgeldiniz...");
                    foreach (object gecici in a)
                    {
                        Console.WriteLine(gecici);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kaydini sileceğiniz ogrencinin adini soyleyiniz");

                    string silme = Console.ReadLine();
                    a.Remove(silme);

                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit silme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 3:
                    Console.WriteLine(" ");
                    Console.WriteLine("Ogrenci Kayit Goruntuleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    foreach (object gecici in a)
                    {
                        Console.WriteLine(gecici);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit goruntuleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 20: break;

                case 4:
                    Console.WriteLine(" "); //Bilgiler gecici oldugu icin kayit yaptiktan sonra ters cevirme isleme yapılmalı.
                    Console.WriteLine("Kayitlari ters cevirme islemi");
                    a.Reverse();
                    foreach (object gecici in a)
                    {
                        Console.WriteLine(gecici);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit ters cevirme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 5:
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit kontrol islemi");
                    Console.Write("Kontrol etmek istediginiz kayidin adini giriniz : ");
                    string kontrol = Console.ReadLine();
                    //Girilen isimler dizide var ise kontrol mekanizması olarak if else ayraçlarını kullandım.
                    if (a.Contains(kontrol) == true)
                    {
                        Console.WriteLine("Kayit dizide mevcut...");
                    }
                    else
                    {
                        Console.WriteLine("Kayit dizide mevcut degil...");
                    }
                    Console.WriteLine("Press Enter...");
                    Console.ReadLine();
                    goto basa;

                case 6:
                    Console.WriteLine(" ");
                    Console.WriteLine("Diziyi siralama islemi");
                    a.Sort();
                    foreach (object gecici in a)
                    {
                        Console.WriteLine(gecici);
                    }
                    Console.WriteLine("Press Enter...");
                    Console.ReadLine();
                    goto basa;
                //Her yeni case'te birbirlerinden farklı değişkenler atıyorum bunun sebebi herhangi bir tuşun birden fazla işlevi görmemesi içindir.
                case 7:
                    Console.WriteLine(" ");
                    Console.WriteLine("Personel Kayit Ekleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit yapacaginiz Personel sayisini giriniz :");
                    int sayi2 = int.Parse(s: Console.ReadLine());
                    for (int i = 0; i < sayi2; i++)
                    {
                        Console.WriteLine(" ");
                        Console.Write("{0} Personelin KimlikNo giriniz :", i + 1);
                        string kimlikno = Console.ReadLine();
                        a.Add(kimlikno);
                        Console.WriteLine(" ");
                        Console.Write("{0} Personelin Adini giriniz :", i + 2);
                        string ad2 = Console.ReadLine();
                        a.Add(ad2);
                        Console.WriteLine(" ");
                        Console.Write("{0} Personelin Soyadini giriniz :", i + 3);
                        string soyad2 = Console.ReadLine();
                        a.Add(soyad2);
                        Console.WriteLine(" ");
                        Console.Write("{0} Personelin DogumTarihi giriniz :", i + 4);
                        string dogumtarihi2 = Console.ReadLine();
                        a.Add(dogumtarihi2);
                        Console.WriteLine(" ");
                        Console.Write("{0} Personelin Departmani giriniz :", i + 5);
                        string departmani = Console.ReadLine();
                        a.Add(departmani);
                        Console.WriteLine(" ");
                        Console.Write("{0} Personelin Gorevi giriniz :", i + 6);
                        string gorevi = Console.ReadLine();
                        a.Add(gorevi);
                        Console.WriteLine(" ");
                        Console.Write("{0} Personelin BaslamaTarihi giriniz :", i + 7);
                        string baslamatarihi = Console.ReadLine();
                        a.Add(baslamatarihi);

                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit ekleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 8:
                    Console.WriteLine(" ");
                    Console.WriteLine("Personel Kayit Silme Ekranina Hosgeldiniz...");
                    foreach (object gecici1 in a)
                    {
                        Console.WriteLine(gecici1);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kaydini sileceğiniz Personel adini soyleyiniz");

                    string silme1 = Console.ReadLine();
                    a.Remove(silme1);

                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit silme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 9:
                    Console.WriteLine(" ");
                    Console.WriteLine("Personel Kayit Goruntuleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    foreach (object gecici1 in a)
                    {
                        Console.WriteLine(gecici1);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit goruntuleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 10:
                    Console.WriteLine(" ");
                    Console.WriteLine("Idari Personel Kayit Ekleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit yapacaginiz Idari Personel sayisini giriniz :");
                    int sayi3 = int.Parse(s: Console.ReadLine());
                    for (int i = 0; i < sayi3; i++)
                    {
                        Console.WriteLine(" ");
                        Console.Write("{0} Idari Personelin KimlikNo giriniz :", i + 1);
                        string kimlikno2 = Console.ReadLine();
                        a.Add(kimlikno2);
                        Console.WriteLine(" ");
                        Console.Write("{0} Idari Personelin Adini giriniz :", i + 2);
                        string ad3 = Console.ReadLine();
                        a.Add(ad3);
                        Console.WriteLine(" ");
                        Console.Write("{0} Idari Personelin Soyadini giriniz :", i + 3);
                        string soyad3 = Console.ReadLine();
                        a.Add(soyad3);
                        Console.WriteLine(" ");
                        Console.Write("{0} Idari Personelin DogumTarihi giriniz :", i + 4);
                        string dogumtarihi2 = Console.ReadLine();
                        a.Add(dogumtarihi2);
                        Console.WriteLine(" ");
                        Console.Write("{0} Idari Personel Gorevi giriniz :", i + 5);
                        string gorevi2 = Console.ReadLine();
                        a.Add(gorevi2);

                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit ekleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 11:
                    Console.WriteLine(" ");
                    Console.WriteLine("Idari Personel Kayit Silme Ekranina Hosgeldiniz...");
                    foreach (object gecici2 in a)
                    {
                        Console.WriteLine(gecici2);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kaydini sileceğiniz Personel adini soyleyiniz");

                    string silme2 = Console.ReadLine();
                    a.Remove(silme2);

                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit silme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 12:
                    Console.WriteLine(" ");
                    Console.WriteLine("Idari Personel Kayit Goruntuleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    foreach (object gecici2 in a)
                    {
                        Console.WriteLine(gecici2);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit goruntuleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 13:
                    Console.WriteLine(" ");
                    Console.WriteLine("Ogretim Gorevlisi Kayit Ekleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit yapacaginiz Ogretim Gorevlisi sayisini giriniz :");
                    int sayi4 = int.Parse(s: Console.ReadLine());
                    for (int i = 0; i < sayi4; i++)
                    {
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogretim Gorevlisi KimlikNo giriniz :", i + 1);
                        string kimlikno3 = Console.ReadLine();
                        a.Add(kimlikno3);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogretim Gorevlisi Adini giriniz :", i + 2);
                        string ad4 = Console.ReadLine();
                        a.Add(ad4);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogretim Gorevlisi Soyadini giriniz :", i + 3);
                        string soyad2 = Console.ReadLine();
                        a.Add(soyad2);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogretim Gorevlisi DogumTarihi giriniz :", i + 4);
                        string dogumtarihi3 = Console.ReadLine();
                        a.Add(dogumtarihi3);
                        Console.WriteLine(" ");
                        Console.Write("{0} Ogretim Gorevlisi Gorevi giriniz :", i + 5);
                        string gorev3 = Console.ReadLine();
                        a.Add(gorev3);

                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit ekleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 14:
                    Console.WriteLine(" ");
                    Console.WriteLine("Ogretim Gorevlisi Kayit Silme Ekranina Hosgeldiniz...");
                    foreach (object gecici3 in a)
                    {
                        Console.WriteLine(gecici3);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kaydini sileceğiniz Ogretim Gorevlisi adini soyleyiniz");

                    string silme3 = Console.ReadLine();
                    a.Remove(silme3);

                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit silme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 15:
                    Console.WriteLine(" ");
                    Console.WriteLine("Ogretim Gorevlisi Kayit Goruntuleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    foreach (object gecici3 in a)
                    {
                        Console.WriteLine(gecici3);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit goruntuleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 16:
                    Console.WriteLine(" ");
                    Console.WriteLine("Ders Kayit Ekleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit yapacaginiz Ders sayisini giriniz :");
                    int sayi5 = int.Parse(s: Console.ReadLine());
                    for (int i = 0; i < sayi5; i++)
                    {
                        Console.WriteLine(" ");
                        Console.Write("{0} Dersin DersNo giriniz :", i + 1);
                        string dersno = Console.ReadLine();
                        a.Add(dersno);
                        Console.WriteLine(" ");
                        Console.Write("{0} Dersin Adini giriniz :", i + 2);
                        string ad5 = Console.ReadLine();
                        a.Add(ad5);
                        Console.WriteLine(" ");
                        Console.Write("{0} Dersin Aciklamasi giriniz :", i + 3);
                        string aciklama = Console.ReadLine();
                        a.Add(aciklama);
                        Console.WriteLine(" ");
                        Console.Write("{0} Dersin Ogretim Gorevlisi giriniz :", i + 4);
                        string ogretimgorevlisi = Console.ReadLine();
                        a.Add(ogretimgorevlisi);

                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit ekleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 17:
                    Console.WriteLine(" ");
                    Console.WriteLine("Ders Kayit Silme Ekranina Hosgeldiniz...");
                    foreach (object gecici4 in a)
                    {
                        Console.WriteLine(gecici4);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kaydini sileceğiniz Dersin adini soyleyiniz");

                    string silme4 = Console.ReadLine();
                    a.Remove(silme4);

                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit silme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 18:
                    Console.WriteLine(" ");
                    Console.WriteLine("Ders Kayit Goruntuleme Ekranina Hosgeldiniz...");
                    Console.WriteLine(" ");
                    foreach (object gecici4 in a)
                    {
                        Console.WriteLine(gecici4);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Kayit goruntuleme islemi basariyla tamamlanmistir...Press Enter");
                    Console.ReadLine();
                    goto basa;

                case 19:
                    Console.WriteLine(" ");
                    Console.WriteLine("Tum dizi silindi!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press Enter...");
                    Console.ReadLine();
                    a.Clear();
                    goto basa;

                default:

                    Console.WriteLine("Lutfen 1 ile 19 arasinda bir numara giriniz!");
                    goto basa;
            }
        }
    }
}



