using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraçKiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir KiralikArac nesnesi oluşturuluyor.

            KiralikArac arac = new KiralikArac("34ERR911", 700);

            // Araç bilgileri ekrana yazdırılıyor: Plaka, günlük ücret ve müsaitlik durumu.
            Console.WriteLine($"Araç Plakası: {arac.plaka}, Günlük Ücret: {arac.gunlukUcret} TL, Müsait: {arac.musaitMİ}");

            // Aracın kiralanması işlemi yapılır.
            arac.AraciKirala();  // İlk kiralama işlemi.
            arac.AraciKirala();  // İkinci kiralama işlemi, ancak araç zaten kiralandı.

            // Aracın teslim edilmesi işlemi yapılır.
            arac.AraciTeslimEt();  // İlk teslimat işlemi.
            arac.AraciTeslimEt();  // İkinci teslimat işlemi, ancak araç zaten teslim alınmış.


            Console.Read();
        }
    }

    // KiralikArac sınıfı: Kiralık araçlara ait bilgileri ve işlemleri tutar.
    class KiralikArac
    {
        // Araç plakasını tutan değişken 
        public string plaka;

        // Araç günlük ücretini tutan değişken 
        public decimal gunlukUcret;

        // Araç müsaitlik durumunu tutan değişken (true: müsait, false: kiralanmış).
        public bool musaitMİ;

        // Yapıcı metod (Constructor): Araç nesnesi oluşturulduğunda plaka ve ücret bilgisi alınır.
        public KiralikArac(string Plaka, decimal GunlukUcret)
        {
            plaka = Plaka;           // Araç plakasını alır ve plaka değişkenine atar.
            gunlukUcret = GunlukUcret;  // Araç günlük ücretini alır ve gunlukUcret değişkenine atar.
            musaitMİ = true;         // Başlangıçta araç müsaittir.
        }

        // AraciKirala metodu: Aracın kiralanması işlemini gerçekleştirir.
        public void AraciKirala()
        {
            // Eğer araç müsaitse (musaitMİ == true), araç kiralanır.
            if (musaitMİ)
            {
                Console.WriteLine(plaka + " plakalı araç kiralandı.");
                musaitMİ = false;  // Araç artık müsait değil (kiralandı).
            }
            else
            {
                Console.WriteLine("Araba müşteride, şu anda kiralanamıyor.");
            }
        }

        // AraciTeslimEt metodu: Araç teslim alındığında kullanılacak metoddur.
        public void AraciTeslimEt()
        {
            // Eğer araç kiralandıysa (musaitMİ == false), araç teslim alınır.
            if (!musaitMİ)
            {
                Console.WriteLine(plaka + " plakalı araç teslim alındı.");
                musaitMİ = true;  // Araç teslim alındı ve tekrar müsait durumda.
            }
            else
            {
                Console.WriteLine("Araç zaten bizde, teslim edilmedi.");
            }
        }
    }
}
