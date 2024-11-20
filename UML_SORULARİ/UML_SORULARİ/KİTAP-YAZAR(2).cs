using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_SORULARİ
{
    class KİTAP_YAZAR_2_
    {
    }

    // KİTAP YAZAR
    class Yazar
    {
        // Yazarın adı, ülke bilgisi ve yazdığı kitaplar
        public string Ad { get; set; }  // Yazarın adı
        public string Ulke { get; set; } // Yazarın yaşadığı ülke
        public List<Kitap> Kitaplar { get; set; }  // Yazarın yazdığı kitaplar listesi

        // Constructor: Yazar nesnesi oluşturulurken adı ve ülke bilgisi alınır
        public Yazar(string ad, string ulke)
        {
            Ad = ad;  // Yazarın adı parametre olarak alınır ve sınıfın Ad özelliğine atanır
            Ulke = ulke;  // Yazarın ülke bilgisi parametre olarak alınır ve sınıfın Ulke özelliğine atanır
            Kitaplar = new List<Kitap>();  // Kitaplar listesi başlatılır
        }

        // Kitap ekleme metodu
        public void KitapEkle(Kitap kitap)
        {
            // Eğer kitaplar listesi null ise, yeni bir liste oluşturuluyor
            if (Kitaplar == null)
            {
                Kitaplar = new List<Kitap>();
            }
            // Yeni kitabı kitaplar listesine ekliyoruz
            Kitaplar.Add(kitap);
        }

        // Yazarı ve kitaplarını ekrana yazdırma metodu
        public void YazariGoster()
        {
            // Yazarın adı ve ülkesini yazdırıyoruz
            Console.WriteLine($"Yazar Adı: {Ad}");
            Console.WriteLine($"Ülke: {Ulke}");
            Console.WriteLine("Kitapları:");

            // Eğer yazarın kitapları varsa, her kitabın başlığını ve ISBN numarasını yazdırıyoruz
            foreach (var kitap in Kitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik} (ISBN: {kitap.ISBN})");
            }
        }
    }

    class Kitap
    {
        // Kitabın başlığı ve ISBN numarası
        public string Baslik { get; set; }  // Kitabın başlığı
        public string ISBN { get; set; }  // Kitabın ISBN numarası (Uluslararası standart kitap numarası)

        // Constructor: Kitap nesnesi oluşturulurken başlık ve ISBN numarası parametre olarak alınır
        public Kitap(string baslik, string isbn)
        {
            Baslik = baslik;  // Kitabın başlığı parametre olarak alınır ve sınıfın Baslik özelliğine atanır
            ISBN = isbn;  // Kitabın ISBN numarası parametre olarak alınır ve sınıfın ISBN özelliğine atanır
        }
    }

    // KİTAP YAZAR 2 
    public class Yazar2
    {
        // Yazarın özellikleri
        public string Ad { get; set; }  // Yazarın adı
        public string Ulke { get; set; } // Yazarın yaşadığı ülke
        private List<Kitap2> Kitaplar2 { get; set; }  // Yazarın yazdığı kitaplar listesi (private)

        // Constructor: Yazar2 sınıfı için parametreli bir kurucu metod
        public Yazar2(string ad, string ulke)
        {
            Ad = ad;          // Yazarın adı parametre olarak alınır ve sınıfın Ad özelliğine atanır
            Ulke = ulke;      // Yazarın ülke bilgisi parametre olarak alınır ve sınıfın Ulke özelliğine atanır
            Kitaplar2 = new List<Kitap2>();  // Kitaplar2 listesi başlatılır, başlangıçta boş bir liste olur
        }

        // Kitap ekleme metodu
        public void KitapEkle2(Kitap2 kitap2)
        {
            Kitaplar2.Add(kitap2);  // Parametre olarak gelen kitap2 nesnesi, Kitaplar2 listesine eklenir
        }

        // Yazarın kitaplarını dışarıya göstermek için bir getter metodu
        public List<Kitap2> GetKitaplar()
        {
            return Kitaplar2;  // Kitaplar2 listesini döndürür, böylece dışarıdan kitaplara erişilebilir
        }
    }

    public class Kitap2
    {
        // Kitap sınıfının özellikleri
        public string Baslik { get; set; }  // Kitabın başlığı
        public DateTime YayinTarihi { get; set; } // Kitabın yayın tarihi
        public Yazar2 Yazar2 { get; set; }  // Kitabın yazarı (Yazar2 sınıfından bir referans)

        // Constructor: Kitap2 sınıfı için parametreli bir kurucu metod
        public Kitap2(string baslik, DateTime yayinTarihi)
        {
            Baslik = baslik;            // Kitabın başlığı parametre olarak alınır ve sınıfın Baslik özelliğine atanır
            YayinTarihi = yayinTarihi;  // Kitabın yayın tarihi parametre olarak alınır ve sınıfın YayinTarihi özelliğine atanır
        }

        // Yazar atama metodu
        public void YazarAta(Yazar2 yazar2)
        {
            this.Yazar2 = yazar2;  // Parametre olarak gelen yazar2 nesnesi, Kitap2 sınıfındaki Yazar2 özelliğine atanır
        }
    }

}
