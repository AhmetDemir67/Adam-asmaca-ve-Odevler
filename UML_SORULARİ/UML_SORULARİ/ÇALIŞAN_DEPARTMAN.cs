using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_SORULARİ
{
    class ÇALIŞAN_DEPARTMAN
    {
    }
    class Calisan
    {
        // Çalışanın adı, pozisyonu ve bağlı olduğu departman
        public string Ad { get; set; }  // Çalışanın adı
        public string Pozisyon { get; set; }  // Çalışanın pozisyonu
        public Departman Departman { get; set; }  // Çalışanın bağlı olduğu departman (Departman nesnesi)

        // Departman atama metodu
        public void DepartmanAtama(Departman departman)
        {
            Departman = departman;  // Parametre olarak gelen departman nesnesi, Calisan nesnesine atanır
        }

        // Çalışanın bilgilerini ekrana yazdırma metodu
        public void CalisaniGoster()
        {
            // Çalışanın adı ve pozisyonunu yazdırıyoruz
            Console.WriteLine("Çalışan Adı: " + Ad);
            Console.WriteLine($"Pozisyon: {Pozisyon}");

            // Eğer departman atanmışsa, departman bilgilerini yazdırıyoruz
            if (Departman != null)
            {
                Console.WriteLine($"Departman: {Departman.Ad}");  // Departman adı
                Console.WriteLine($"Lokasyon: {Departman.Lokasyon}");  // Departman lokasyonu
            }
            else
            {
                // Departman atanmadıysa, bu durumu bildiriyoruz
                Console.WriteLine("Departman atanmadı.");
            }
        }
    }

    class Departman
    {
        // Departman adı ve lokasyonu
        public string Ad { get; set; }  // Departmanın adı
        public string Lokasyon { get; set; }  // Departmanın lokasyonu

        // Constructor: Departman nesnesi oluşturulurken ad ve lokasyon parametreleri alınır
        public Departman(string ad, string lokasyon)
        {
            Ad = ad;  // Departman adı atanır
            Lokasyon = lokasyon;  // Departman lokasyonu atanır
        }
    }
}
