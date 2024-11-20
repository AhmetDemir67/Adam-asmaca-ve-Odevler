using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_SORULARİ
{
    class EBEVEYN_COCUK
    {
    }
    class Ebeveyn
    {
        public string Ad;  // Ebeveynin adı
        public int Yas;    // Ebeveynin yaşı
        public List<Cocuk> Cocuklar;  // Ebeveynin çocukları

        // Constructor: Ebeveynin adı ve yaşı parametre olarak alınır
        public Ebeveyn(string ad, int yas)
        {
            Ad = ad;  // Ebeveynin adını atar
            Yas = yas;  // Ebeveynin yaşını atar
            Cocuklar = new List<Cocuk>();  // Çocuklar listesi başlatılır
        }

        // Çocuk ekleme metodu
        public void CocukEkle(Cocuk cocuk)
        {
            // Yeni çocuk listeye eklenir
            Cocuklar.Add(cocuk);
            Console.WriteLine($"{cocuk.Ad} adlı çocuk {Ad} adlı ebeveynine eklenmiştir.");
        }
    }

    class Cocuk
    {
        public string Ad;  // Çocuğun adı
        public int Yas;    // Çocuğun yaşı
        public Ebeveyn Ebeveyn;  // Çocuğun ebeveyni

        // Constructor: Çocuğun adı ve yaşı parametre olarak alınır
        public Cocuk(string ad, int yas)
        {
            Ad = ad;  // Çocuğun adını atar
            Yas = yas;  // Çocuğun yaşını atar
        }

        // Ebeveyn atama metodu
        public void EbeveynAtama(Ebeveyn ebeveyn)
        {
            Ebeveyn = ebeveyn;  // Çocuğa ebeveyn atanır
            Console.WriteLine($"{Ad} adlı çocuk {ebeveyn.Ad} adlı ebeveynine atanmıştır.");
        }
    }

}
