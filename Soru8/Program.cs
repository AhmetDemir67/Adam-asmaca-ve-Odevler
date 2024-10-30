using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifreleme
{
    class Program
    {
        // Fibonacci serisinin n'inci elemanını hesaplayan metot
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n; // 0 veya 1 için doğrudan değerleri döndür

            int a = 0, b = 1, temp; // İlk iki Fibonacci sayısı
            // n'e kadar olan Fibonacci sayısını hesapla
            for (int i = 2; i <= n; i++)
            {
                temp = a + b; // Yeni Fibonacci sayısını hesapla
                a = b; // Önceki iki sayıyı güncelle
                b = temp;
            }
            return b; // n'inci Fibonacci sayısını döndür
        }

        // Bir sayının asal olup olmadığını kontrol eden metot
        static bool IsPrime(int sayi)
        {
            if (sayi <= 1) return false; // 1 ve daha küçük sayılar asal değildir
            // Sayının asal olup olmadığını kontrol et
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false; // Eğer böleni varsa asal değildir
            }
            return true; // Asal ise true döndür
        }

        // Şifreli mesajı çözen metot
        static string MesajıÇöz(string şifreliMesaj)
        {
            string orijinalMesaj = ""; // Çözülen orijinal mesajı saklamak için boş bir string

            // Şifreli mesajın her bir karakteri için döngü
            for (int i = 0; i < şifreliMesaj.Length; i++)
            {
                int pozisyon = i + 1; // Pozisyon 1'den başlar

                int şifreliAscii = (int)şifreliMesaj[i]; // Şifreli karakterin ASCII değerini al

                int orijinalAscii = şifreliAscii; // Başlangıçta orijinal ASCII değerini şifreli değer olarak ayarla

                // İlk iki karakter için orijinal değer değişmez
                if (i == 0 || i == 1)
                    orijinalAscii = şifreliAscii;

                else if (i == 2)
                    orijinalAscii += 100; // Üçüncü karakter için 100 ekle

                // Fibonacci değerini al
                int fib = Fibonacci(pozisyon);

                // Orijinal ASCII değerini elde et
                orijinalAscii /= fib; // ASCII değerini Fibonacci sayısına böl

                // Orijinal karakteri elde et ve orijinal mesaja ekle
                orijinalMesaj += (char)orijinalAscii;
            }

            return orijinalMesaj; // Çözülen orijinal mesajı döndür
        }

        static void Main()
        {
            // Kullanıcıdan şifreli mesajı alma
            Console.Write("Lütfen şifrelenmiş kelimeyi girin(Şifreleme işlemi sadece büyük harfler Kullanılarak oluşmuştur, maks 3 harf olabilir ve 3.harf 'R' den sonraki harfler olabilir): ");
            string şifreliMesaj = Console.ReadLine(); // Kullanıcının girdiği şifreli kelime

            // Çözümleme işlemi
            string orijinalMesaj = MesajıÇöz(şifreliMesaj);

            // Sonucu ekrana yazdır
            Console.WriteLine("Orijinal Mesaj: " + orijinalMesaj);

            Console.Read(); 
        }
    }
}
