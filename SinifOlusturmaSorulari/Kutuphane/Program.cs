using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{

    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir Kutuphane nesnesi oluşturuluyor.
            Kutuphane kutuphane = new Kutuphane();

            // Kütüphaneye kitap ekleniyor.
            kutuphane.KitapEkle("1984");  // '1984' adlı kitap ekleniyor.
            kutuphane.KitapEkle("Savaş ve Barış");  // 'Savaş ve Barış' adlı kitap ekleniyor.

            // Kütüphanedeki kitaplar listeye dökülüyor.
            kutuphane.KitaplariListele();

            Console.Read();
        }

        // Kutuphane sınıfı: Kütüphane işlemleri (kitap ekleme, listeleme) yapılır.
        class Kutuphane
        {
            // Kitapları tutmak için bir liste (List<string>) kullanılır.
            private List<string> kitaplar;

            // Yapıcı metot (Constructor): Kutuphane nesnesi oluşturulduğunda kitaplar listesi başlatılır.
            public Kutuphane()
            {
                kitaplar = new List<string>(); // Kitap listesi boş olarak başlatılır.
            }

            // Kitap ekleme metodu: Kütüphaneye yeni bir kitap ekler.
            public void KitapEkle(string yeniKitap)
            {
                kitaplar.Add(yeniKitap);  // Yeni kitap listeye eklenir.
                Console.WriteLine($"Kütüphaneye eklendi: {yeniKitap}");  // Kitap eklenince ekranda bilgi verilir.
            }

            // Kitapları listeleme metodu: Kütüphanedeki tüm kitapları ekrana yazdırır.
            public void KitaplariListele()
            {
                Console.WriteLine("Kütüphanedeki Kitaplar:");
                foreach (var kitap in kitaplar)  // Kitaplar listesinde döngü ile tüm kitaplar yazdırılır.
                {
                    Console.WriteLine(kitap);  // Her bir kitabın adı ekrana yazdırılır.
                }
            }
        }
    }
}
