using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri
{

    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir Kisi nesnesi oluşturuluyor. Bu nesne, bir kişinin bilgilerini tutuyor.

            Kisi kisi = new Kisi("Ahmet", "Demir", "537 495 19 03");

            // KisiBilgisi metodunu çağırarak, kişiye ait bilgileri ekrana yazdırıyoruz.
            Console.WriteLine(kisi.KisiBilgisi());

            Console.Read();
        }
    }

    // Kisi sınıfı: Kişiye ait bilgileri tutar (Ad, Soyad, Telefon Numarası).
    class Kisi
    {
        // Kişinin adı, soyadı ve telefon numarasını tutan değişkenler (properties).
        public string Ad, Soyad, TelNO;

        // Yapıcı metod (Constructor): Kişi nesnesi oluşturulduğunda, ad, soyad ve telefon numarası parametre olarak verilir.
        public Kisi(string ad, string soyad, string telno)
        {
            Ad = ad;           // Verilen ad, Ad değişkenine atanır.
            Soyad = soyad;     // Verilen soyad, Soyad değişkenine atanır.
            TelNO = telno;     // Verilen telefon numarası, TelNO değişkenine atanır.
        }

        // KisiBilgisi metodu: Kişinin bilgilerini formatlanmış bir şekilde döndürür.
        public string KisiBilgisi()
        {
            // Kişinin adı, soyadı ve telefon numarasını içeren bir string döndürülür.
            return $"{Ad} {Soyad}, Telefon: {TelNO}";
        }
    }
}
