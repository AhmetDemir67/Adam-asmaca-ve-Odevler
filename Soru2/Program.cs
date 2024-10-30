using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boş bir tam sayı listesi oluşturulur
            List<int> dizi = new List<int>();
            int sayi, toplam = 0;
            double ortalama;

            // Kullanıcıdan sürekli sayı girişi istenir
            while (true)
            {
                Console.WriteLine("Lütfen pozitif tam sayılar girin (Çıkmak için 0):");
                sayi = Convert.ToInt32(Console.ReadLine());

                // Girilen sayı 0 ise döngüden çıkılır
                if (sayi == 0)
                    break;

                // Girilen sayı pozitifse listeye eklenir, değilse hata mesajı verilir
                if (sayi > 0)
                    dizi.Add(sayi);
                else
                    Console.WriteLine("Lütfen POZİTİF tam sayılar girin.");
            }

            // Listedeki sayılar küçükten büyüğe sıralanır
            dizi.Sort();

            // Tüm sayılar toplanır
            foreach (int i in dizi)
            {
                toplam += i;
            }

            // Ortalama hesaplanır
            ortalama = (double)toplam / dizi.Count;

            // Medyan hesaplanır (çift veya tek elemanlı listeye göre)
            int ortaIndex = dizi.Count / 2;
            double medyan = dizi.Count % 2 == 0
                ? (dizi[ortaIndex - 1] + dizi[ortaIndex]) / 2.0
                : dizi[ortaIndex];

            // Sonuçlar ekrana yazdırılır
            Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);
            Console.WriteLine("Girilen sayıların medyanı: " + medyan);

            Console.Read();
        }
    }
}