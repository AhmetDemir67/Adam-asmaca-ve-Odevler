using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Asmaca1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıya bir hak sayısı belirttik.
            int kalanHak = 10;
            // bir dizi oluşturarak kullanıcının karşısına gelecek rastgele kelimeleri belirledik.
            string[] kelimeler = { "madrid", "barcelona", "fulham", "liverpool", "porto", "benfica", "juventus", "arsenal", "chelsea", "psv" };

            // random sınıfı ile rastgele seçtirdik
            Random ran = new Random();
            string rastKelime = kelimeler[ran.Next(kelimeler.Length)];

            // oyun ve kategori mesajı verdik.
            Console.WriteLine("Adam asmaca oyununa hoşgeldiniz.");
            Console.WriteLine("kategoriniz futbol takımları.");

            // kullanıcının tahmin ettiği harfleri tutmak için liste.
            List<char> tahminEdilen = new List<char>();

            while (kalanHak > 0)
            {
                // tahmin edilecek kelimeyi boşluklarla gösterttik.
                Console.Write("Kelime: ");
                foreach (char harf in rastKelime)
                {
                    if (tahminEdilen.Contains(harf))
                    {
                        Console.Write(harf + " ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();

                // Kullanıcıdan bir harf tahmini aldık
                Console.Write("Bir harf tahmin edin: ");
                char tahmin = Console.ReadLine()[0];

                //  kullanıcının tahmin ettiği harf listeye eklenir
                tahminEdilen.Add(tahmin);

                // Eğer tahmin doğruysa kontrol edilir
                bool dogruTahmin = false;
                foreach (char harf in rastKelime)
                {
                    if (harf == tahmin)
                    {
                        dogruTahmin = true;
                        break;
                    }
                }

                if (!dogruTahmin)
                {
                    kalanHak--;
                    Console.WriteLine("Yanlış tahmin! Kalan tahmin: " + kalanHak);
                }

                // kelimenin tüm harfleri doğru tahmin edilmişse oyun biter.
                bool oyunBitti = true;
                foreach (char harf in rastKelime)
                {
                    if (!tahminEdilen.Contains(harf))
                    {
                        oyunBitti = false;
                        break;
                    }
                }

                // oyun bitiş mesajlarını gösterdik.

                if (oyunBitti)
                {
                    Console.WriteLine("Tebrikler, oyunu kazandınız!");
                    break;
                }
            }
            if (kalanHak == 0)
            {
                Console.WriteLine("Üzgünüz, oyunu kaybettiniz. Kelime: " + rastKelime);
            }
            Console.Read();
        }
    }
}
