using System;
using System.Collections.Generic;
using System.Linq;

namespace Soru6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Başlangıç ve bitiş yıllarını belirle
            int baslangicYili = 2000;
            int bitisYili = 3000;

            // Belirtilen aralıktaki geçerli tarihleri bul
            List<string> gecerliTarihler = BulGecerliTarihler(baslangicYili, bitisYili);

            // Geçerli tarihleri ekrana yazdır
            foreach (string tarih in gecerliTarihler)
            {
                Console.WriteLine(tarih);
            }
            Console.Read();
     }

        // Belirtilen yıl aralığındaki geçerli tarihleri bulan fonksiyon
        static List<string> BulGecerliTarihler(int baslangicYili, int bitisYili)
        {
            // Geçerli tarihleri tutacak bir liste oluştur
            List<string> gecerliTarihler = new List<string>();

            // Belirtilen yıl aralığında tüm tarihleri kontrol et
            for (int yil = baslangicYili; yil <= bitisYili; yil++)
            {
                for (int ay = 1; ay <= 12; ay++)
                {
                    for (int gun = 1; gun <= DateTime.DaysInMonth(yil, ay); gun++)
                    {
                        // Eğer tarih geçerli ise listeye ekle
                        if (IsGecerliTarih(gun, ay, yil) && new DateTime(yil, ay, gun) >= DateTime.Now)
                        {
                            gecerliTarihler.Add($"{gun}-{ay}-{yil}");
                        }
                    }
                }
            }

            return gecerliTarihler;
        }

        // Bir tarihin geçerli olup olmadığını kontrol eden fonksiyon
        static bool IsGecerliTarih(int gun, int ay, int yil)
        {
            // Asal sayı kontrolü
            bool isAsal = true;
            for (int i = 2; i <= Math.Sqrt(gun); i++)
            {
                if (gun % i == 0)
                {
                    isAsal = false;
                    break;
                }
            }

            // Ay basamaklarının toplamı kontrolü
            int ayBasamaklarToplami = ay.ToString().Sum(c => c - '0');

            // Yıl rakamları toplamı kontrolü
            int yilRakamlariToplami = yil.ToString().Sum(c => c - '0');

            // Tüm koşullar sağlanıyorsa true döndür
            return isAsal && ayBasamaklarToplami % 2 == 0 && yilRakamlariToplami < yil / 4;
        }
    }
}