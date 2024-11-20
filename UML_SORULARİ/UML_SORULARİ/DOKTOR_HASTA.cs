using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_SORULARİ
{
    class DOKTOR_HASTA
    {
    }

    class Doktor
    {
        public string Ad;  // Doktorun adı
        public string Brans;  // Doktorun branşı
        public List<Hasta> Hastalar;  // Doktorun kabul ettiği hastalar

        // Constructor: Doktor adı ve branşı parametre olarak alır
        public Doktor(string ad, string brans)
        {
            Ad = ad;  // Doktorun adını atar
            Brans = brans;  // Doktorun branşını atar
            Hastalar = new List<Hasta>();  // Hastalar listesi başlatılır
        }

        // Hasta ekleme metodu
        public void HastaEkle(Hasta hasta)
        {
            // Eğer hasta daha önce eklenmemişse, listeye eklenir
            if (!Hastalar.Contains(hasta))
            {
                Hastalar.Add(hasta);
                // Hasta kabulü ile ilgili mesaj yazdırılır
                Console.WriteLine($"{hasta.Ad} adlı hasta, Dr. {Ad} tarafından kabul edildi.");
            }
            else
            {
                Console.WriteLine($"{hasta.Ad} adlı hasta zaten kabul edilmiştir.");
            }
        }
    }

    class Hasta
    {
        public string Ad;  // Hastanın adı
        public string TcNo;  // Hastanın TC kimlik numarası
        public Doktor Doktor;  // Hasta hangi doktora atanmış

        // Constructor: Hasta adı ve TC numarası parametre olarak alır
        public Hasta(string ad, string tcno)
        {
            Ad = ad;  // Hastanın adını atar
            TcNo = tcno;  // Hastanın TC kimlik numarasını atar
        }

        // Doktor atama metodu
        public void DoktorAtama(Doktor doktor)
        {
            Doktor = doktor;  // Hastaya doktor atanır
                              // Doktorla ilgili muayene mesajı yazdırılır
            Console.WriteLine($"{Ad} adlı hasta Dr. {doktor.Ad} ile muayene olacaktır.");
        }
    }
}
