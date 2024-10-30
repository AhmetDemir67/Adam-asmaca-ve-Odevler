using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boş bir tam sayı listesi oluşturulur
            List<int> sayilar = new List<int>();

            // Kullanıcıdan sayılar alınıp listeye eklenir
            Console.WriteLine("Lütfen tam sayılar giriniz (Çıkmak için 0):");
            int sayi;
            while (true)
            {
                sayi = int.Parse(Console.ReadLine());
                if (sayi == 0)
                    break;
                sayilar.Add(sayi);
            }

            // Listedeki sayılar küçükten büyüğe sıralanır
            sayilar.Sort();
            Console.WriteLine("Sıralı dizi: " + string.Join(", ", sayilar));

            // Kullanıcıdan aranacak sayı alınır
            Console.Write("Aranacak sayıyı giriniz: ");
            int aranacakSayi = int.Parse(Console.ReadLine());

            // İkili arama ile sayının listede olup olmadığı kontrol edilir
            bool bulundu = BinarySearch(sayilar, aranacakSayi);

            // Sonuç ekrana yazdırılır
            if (bulundu)
                Console.WriteLine("{0} sayısı dizide bulundu.", aranacakSayi);
            else
                Console.WriteLine("{0} sayısı dizide bulunamadı.", aranacakSayi);

            Console.Read();
        }

        // İkili arama algoritması
        static bool BinarySearch(List<int> dizi, int aranacakSayi)
        {
            // Arama aralığının başlangıcı ve sonu belirlenir
            int baslangic = 0;
            int bitis = dizi.Count - 1;

            // Arama aralığı boşalana kadar devam edilir
            while (baslangic <= bitis)
            {
                // Orta nokta hesaplanır
                int orta = (baslangic + bitis) / 2;

                // Aranacak sayı orta noktadaki sayıya eşitse bulundu demektir
                if (dizi[orta] == aranacakSayi)
                    return true;
                // Aranacak sayı orta noktadaki sayıdan büyükse sağ yarıda aramaya devam edilir
                else if (dizi[orta] < aranacakSayi)
                    baslangic = orta + 1;
                // Aranacak sayı orta noktadaki sayıdan küçükse sol yarıda aramaya devam edilir
                else
                    bitis = orta - 1;
            }

            // Sayı bulunamadıysa false döndürülür
            return false;
        }
    }
}