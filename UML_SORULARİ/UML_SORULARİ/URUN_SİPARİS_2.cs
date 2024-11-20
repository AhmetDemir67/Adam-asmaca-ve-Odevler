using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_SORULARİ
{
    class URUN_SİPARİS_2
    {
    }

    // ÜRÜN SİPARİŞ
    class Urun
    {
        public string Ad;  // Ürünün adı
        private int _fiyat;  // Ürünün fiyatı, private olarak tanımlandı

        // Fiyat özelliği (getter ve setter)
        public int Fiyat
        {
            get { return _fiyat; }  // Fiyat değerini almak için getter
            set { _fiyat = value; }  // Fiyat değerini değiştirmek için setter
        }

        // Ürün bilgilerini set eden metod
        public void UrunBilgisi(string ad, int fiyat)
        {
            Ad = ad;  // Ürünün adını alır ve Ad özelliğine atar
            Fiyat = fiyat;  // Ürünün fiyatını alır ve Fiyat özelliğine atar
        }
    }

    class Siparis
    {
        public DateTime Tarih { get; set; }  // Sipariş tarihi
        public decimal Toplam { get; set; }  // Siparişin toplam tutarı

        // Sipariş sınıfı constructor'ı
        public Siparis(DateTime tarih, decimal toplam)
        {
            Tarih = tarih;  // Sipariş tarihini parametre olarak alır ve Tarih özelliğine atar
            Toplam = toplam;  // Siparişin toplam tutarını parametre olarak alır ve Toplam özelliğine atar
        }
    }

    // MÜŞTERİ SİPARİŞ

    class Urun2
    {
        public string Ad { get; set; }  // Ürünün adı
        public string Telefon { get; set; }  // Ürünle ilgili telefon numarası

        // Constructor: Ürün adı ve telefon numarası parametre olarak alınıyor
        public Urun2(string ad, string telefon)
        {
            Ad = ad;  // Ürünün adını Ad özelliğine atar
            Telefon = telefon;  // Ürünle ilgili telefon numarasını Telefon özelliğine atar
        }

        // Sipariş verme metodu
        public void SiparisVer(Siparis2 siparis2)
        {
            // Siparişin verildiğini bildiren mesaj yazdırılır
            Console.WriteLine($"{Ad} ürünü için sipariş verildi.");
            // Siparişin bilgilerini gösteren metod çağrılır
            siparis2.SiparisBilgisi();
        }
    }

    class Siparis2
    {
        public DateTime Tarih { get; set; }  // Siparişin tarihi
        public string Durum { get; set; }  // Siparişin durumu (örn. "Hazırlanıyor", "Teslim Edildi")

        // Constructor: Sipariş tarihi ve durumu parametre olarak alınır
        public Siparis2(DateTime tarih, string durum)
        {
            Tarih = tarih;  // Sipariş tarihini Tarih özelliğine atar
            Durum = durum;  // Siparişin durumunu Durum özelliğine atar
        }

        // Sipariş bilgilerini yazdıran metod
        public void SiparisBilgisi()
        {
            // Sipariş tarihi ve durumu ekrana yazdırılır
            Console.WriteLine($"Sipariş Tarihi: {Tarih.ToShortDateString()}");
            Console.WriteLine($"Durum: {Durum}");
        }
    }
}
