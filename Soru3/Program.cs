using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boş bir tam sayı listesi oluşturulur
            List<int> dizi = new List<int>();
            int sayi;

            // Kullanıcıdan sürekli sayı girişi istenir
            while (true)
            {
                Console.WriteLine("Lütfen tam sayılar girin (Çıkmak için 0):");
                sayi = Convert.ToInt32(Console.ReadLine());

                // Girilen sayı 0 ise döngüden çıkılır
                if (sayi == 0)
                    break;

                // Girilen sayı 0 değilse listeye eklenir
                dizi.Add(sayi);
            }

            // Ardı ardına gelen artan sayıları bulma
            int baslangic = 0;
            for (int i = 1; i < dizi.Count; i++)
            {
                // Eğer iki eleman arasındaki fark 1'den farklıysa
                if (dizi[i] - dizi[i - 1] != 1)
                {
                    // ve aradığımız dizi birden fazla eleman içeriyorsa
                    if (i - baslangic > 1)
                    {
                        // bulunan aralığı ekrana yazdır
                        Console.WriteLine($"{dizi[baslangic]} - {dizi[i - 1]}");
                    }
                    // Yeni bir artan diziye başlanabileceği ihtimaline karşı başlangıç indeksini güncelle
                    baslangic = i;
                }
            }

            // Listenin sonuna kadar uzanan bir artan dizi var mı kontrol et
            if (dizi.Count - baslangic > 1)
            {
                Console.WriteLine($"{dizi[baslangic]} - {dizi[dizi.Count - 1]}");
            }

            Console.Read();
        }
    }
}