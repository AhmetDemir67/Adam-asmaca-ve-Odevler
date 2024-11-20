using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_SORULARİ
{
    class OKUL_OGRENCİ
    {
    }


    class Okul
    {
        public string Ad;  // Okulun adı
        public List<Ogrenci> Ogrenciler;  // Okulda bulunan öğrenciler listesi

        // Constructor: Okul adı parametre olarak alınır
        public Okul(string ad)
        {
            Ad = ad;  // Okul adı atanır
            Ogrenciler = new List<Ogrenci>();  // Öğrenciler listesi başlatılır
        }

        // Öğrenci oluşturma metodu
        public void OgrenciOlustur()
        {
            // Burada bir öğrenci nesnesi oluşturuluyor ve "ahmet" adlı 20 yaşında bir öğrenci yaratılıyor.
            Ogrenci ogrenci = new Ogrenci("Ahmet", 20);

            // Bu öğrenci okulun öğrenciler listesine eklenmelidir.
            Ogrenciler.Add(ogrenci);

            // Öğrencinin oluşturulduğuna dair mesaj yazdırılır
            Console.WriteLine("Öğrenci oluşturuldu: " + ogrenci.Ad);
        }

        // Okuldaki tüm öğrencileri listeleme metodu
        public void OgrencileriListele()
        {
            Console.WriteLine($"{Ad} Okulu Öğrencileri:");
            foreach (var ogrenci in Ogrenciler)
            {
                Console.WriteLine($"Öğrenci Adı: {ogrenci.Ad}, Yaş: {ogrenci.Yas}");
            }
        }
    }

    class Ogrenci
    {
        public string Ad;  // Öğrencinin adı
        private int yas;   // Öğrencinin yaşı (private)

        // Yas özelliği (get ve set metotlarıyla kontrol edilir)
        public int Yas
        {
            get { return Yas; }  // Yaşı alır
            set { Yas = value; } // Yaşı ayarlar
        }

        // Constructor: Öğrencinin adı ve yaşı parametre olarak alınır
        public Ogrenci(string ad, int yas)
        {
            Ad = ad;  // Öğrencinin adı atanır
            Yas = yas;  // Öğrencinin yaşı atanır
        }

        // Öğrenci bilgilerini yazdıran metod
        public void OgrenciBilgisi()
        {
            Console.WriteLine($"Öğrenci Adı: {Ad}, Yaş: {Yas}");
        }
    }
}

