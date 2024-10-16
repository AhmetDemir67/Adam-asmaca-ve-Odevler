using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayıya kadar olan asal toplam 

            Console.Write("Bir sayı girin: ");              //kullanıcıdan bir sayı girişi aldık 
            int n = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;                  // son çıktı olan toplam değişkeni oluşturduk

            for (int sayi = 2; sayi <= n; sayi++)           // 0 ve 1 asal olmadığı için 2 den başlayıp girilen sayıya kadar dönen for döngüsü oluşturduk.
            {
                bool asalMi = true;          // döngüye giren sayıların asal olup olamdığını belirlemek için bool değişkeni

                for (int i = 2; i < sayi; i++)  // 2 den kendinden bir eksiğe kadar bölünebiliyor mu kontrol döngüsü
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;       // eğer bölünüyorsa bool değişkeni false döner ve o sayıyı almaz 
                        break;
                    }
                }

                if (asalMi)   // döngü bittikten sonra true olanları toplam değişkenine ekler 
                {
                    toplam += sayi;
                }
            }

            Console.WriteLine("1 ile " + n + " arasındaki asal sayıların toplamı: " + toplam);   // sonucun yazdırılması

            Console.Read();
        }
    }
}
