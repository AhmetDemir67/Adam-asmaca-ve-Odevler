using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_SORULARİ
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // EV-ODA

    class EV
    {
        public string Ad;  // Evin adı
        public List<Oda> Odalar;  // Evin içindeki odaların listesi

        // Constructor: Evin adını alır ve Odalar listesi başlatılır
        public EV(string ad)
        {
            Ad = ad;  // Evin adını atar
            Odalar = new List<Oda>();  // Odalar listesi başlatılır
        }

        // Oda ekleme metodu
        public void OdaEkle(Oda oda)
        {
            // Yeni oda listeye eklenir
            Odalar.Add(oda);
            Console.WriteLine($"{oda.Tip} tipi {oda.Boyut} boyutundaki oda, {Ad} evine eklendi.");
        }

        // Evdeki odaları listeleme metodu
        public void OdalariListele()
        {
            Console.WriteLine($"{Ad} Evindeki Odalar:");
            foreach (var oda in Odalar)
            {
                Console.WriteLine($"Tip: {oda.Tip}, Boyut: {oda.Boyut}");
            }
        }
    }

    class Oda
    {
        public string Boyut;  // Odanın boyutu
        public string Tip;    // Odanın tipi (örneğin, yatak odası, oturma odası, vb.)

        // Constructor: Odanın boyutunu ve tipini parametre olarak alır
        public Oda(string boyut, string tip)
        {
            Boyut = boyut;  // Odanın boyutunu atar
            Tip = tip;      // Odanın tipini atar
        }
    }

    // ŞİRKET-ÇALIŞAN 2

    class Sirket
    {
        public string Ad;  // Şirketin adı
        public List<Calisan3> Calisanlar;  // Şirketteki çalışanların listesi

        // Constructor: Şirketin adı alınarak şirket oluşturulur
        public Sirket(string ad)
        {
            Ad = ad;  // Şirketin adını atar
            Calisanlar = new List<Calisan3>();  // Çalışanlar listesi başlatılır
        }

        // Çalışan ekleme metodu
        public void CalisanEkle(Calisan3 calisan3)
        {
            // Yeni çalışan listeye eklenir
            Calisanlar.Add(calisan3);
            Console.WriteLine($"{calisan3.Ad} adlı çalışan {Ad} şirketine eklendi.");
        }

        // Şirketteki tüm çalışanları listeleme metodu
        public void CalisanlariListele()
        {
            Console.WriteLine($"{Ad} Şirketindeki Çalışanlar:");
            foreach (var calisan in Calisanlar)
            {
                calisan.CalisanBilgisi();  // Her çalışanın bilgileri yazdırılır
            }
        }
    }

    class Calisan3
    {
        public string Ad;  // Çalışanın adı
        public string Pozisyon;  // Çalışanın pozisyonu

        // Constructor: Çalışanın adı ve pozisyonu alınarak çalışan oluşturulur
        public Calisan3(string ad, string pozisyon)
        {
            Ad = ad;  // Çalışanın adını atar
            Pozisyon = pozisyon;  // Çalışanın pozisyonunu atar
        }

        // Çalışan bilgilerini yazdıran metod
        public void CalisanBilgisi()
        {
            Console.WriteLine($"Çalışan Adı: {Ad}, Pozisyon: {Pozisyon}");
        }
    }

    // KÜTÜPHANE KİTAP
    class Kutuphane
    {
        public string Ad;  // Kütüphanenin adı
        public List<Kitap3> Kitaplar;  // Kütüphanedeki kitapların listesi

        // Constructor: Kütüphane adı parametre olarak alınır
        public Kutuphane(string ad)
        {
            Ad = ad;  // Kütüphanenin adını atar
            Kitaplar = new List<Kitap3>();  // Kitaplar listesi başlatılır
        }

        // Kitap ekleme metodu
        public void KitapEkle(Kitap3 kitap3)
        {
            // Yeni kitap listeye eklenir
            Kitaplar.Add(kitap3);
            Console.WriteLine($"Kitap: {kitap3.Baslik}, Yazar: {kitap3.Yazar} kütüphaneye eklendi.");
        }

        // Kütüphanedeki kitapları listeleme metodu
        public void KitaplariListele()
        {
            Console.WriteLine($"{Ad} Kütüphanesindeki Kitaplar:");
            foreach (var kitap in Kitaplar)
            {
                Console.WriteLine($"Başlık: {kitap.Baslik}, Yazar: {kitap.Yazar}");
            }
        }
    }

    class Kitap3
    {
        public string Baslik;  // Kitabın başlığı
        public string Yazar;   // Kitabın yazarı

        // Constructor: Kitabın başlığı ve yazarı parametre olarak alınır
        public Kitap3(string baslik, string yazar)
        {
            Baslik = baslik;  // Kitabın başlığını atar
            Yazar = yazar;    // Kitabın yazarını atar
        }
    }

    // BİLGİSAYAR -İŞLEMCİ

    class Bilgisayar
    {
        public string Model;  // Bilgisayarın model adı
        public Islemci Islemci;  // Bilgisayarın işlemcisi (Islemci sınıfından bir nesne)

        // Constructor: Bilgisayar modeli belirleniyor
        public Bilgisayar(string model)
        {
            Model = model;  // Model adı atanıyor
        }

        // İşlemci oluşturma metodu
        public void IslemciOlustur(int cekirdek, int frekans)
        {
            // İşlemci zaten varsa oluşturulmaz
            if (Islemci != null)
            {
                Console.WriteLine("İşlemci zaten oluşturulmuş.");
            }
            else
            {
                // İşlemci nesnesi oluşturuluyor
                Islemci = new Islemci(cekirdek, frekans);
                Console.WriteLine("İşlemci oluşturuldu.");
            }
        }

        // Bilgisayar bilgilerini yazdırma metodu
        public void BilgisayarBilgisi()
        {
            Console.WriteLine($"Bilgisayar Modeli: {Model}");
            if (Islemci != null)
            {
                Islemci.IslemciBilgisi();  // İşlemci bilgilerini yazdır
            }
            else
            {
                Console.WriteLine("İşlemci henüz oluşturulmadı.");
            }
        }
    }

    class Islemci
    {
        public int Cekirdekler;  // İşlemcinin çekirdek sayısı
        public int Frekans;  // İşlemcinin frekansı (GHz cinsinden)

        // Constructor: İşlemci çekirdek sayısı ve frekansı belirleniyor
        public Islemci(int cekirdekler, int frekans)
        {
            Cekirdekler = cekirdekler;  // Çekirdek sayısı atanıyor
            Frekans = frekans;  // Frekans değeri atanıyor
        }

        // İşlemci bilgilerini yazdıran metod
        public void IslemciBilgisi()
        {
            Console.WriteLine($"Çekirdek Sayısı: {Cekirdekler}, Frekans: {Frekans} GHz");
        }
    }

    // OTOMOBİL-MOTOR

    class Otomobil
    {
        public string Marka;  // Otomobilin markası
        public Motor Motor;  // Otomobilin motoru (Motor sınıfından bir nesne)

        // Constructor: Otomobilin marka adı belirleniyor
        public Otomobil(string marka)
        {
            Marka = marka;  // Marka adı atanıyor
        }

        // Motor oluşturma metodu
        public void MotorOlustur()
        {
            // Motor nesnesi oluşturuluyor ve Otomobil sınıfındaki Motor özelliğine atama yapılıyor
            Motor = new Motor(2000, "Benzin");
            Console.WriteLine("Motor oluşturuldu.");
        }

        // Otomobil bilgilerini yazdırma metodu
        public void OtomobilBilgisi()
        {
            Console.WriteLine($"Otomobil Markası: {Marka}");
            if (Motor != null)
            {
                Motor.MotorBilgisi();  // Motor bilgilerini yazdır
            }
            else
            {
                Console.WriteLine("Motor henüz oluşturulmadı.");
            }
        }
    }

    class Motor
    {
        public int Guc;  // Motorun gücü (HP cinsinden)
        public string Tip;  // Motor tipi (Benzin, Dizel, Elektrik vb.)

        // Constructor: Motorun gücü ve tipi belirleniyor
        public Motor(int guc, string tip)
        {
            Guc = guc;  // Motor gücü atanıyor
            Tip = tip;  // Motor tipi atanıyor
        }

        // Motor bilgilerini yazdıran metod
        public void MotorBilgisi()
        {
            Console.WriteLine($"Motor Gücü: {Guc} HP, Motor Tipi: {Tip}");
        }
    }






}
