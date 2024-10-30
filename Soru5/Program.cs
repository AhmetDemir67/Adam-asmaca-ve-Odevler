using System;

namespace Soru5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("İki polinom giriniz");
                Console.Write("Birinci polinom: ");
                string polinom1 = Console.ReadLine();

                Console.Write("İkinci polinom: ");
                string polinom2 = Console.ReadLine();

                // Kullanıcı 'exit' yazarsa döngüden çık
                if (polinom1.ToLower() == "exit" || polinom2.ToLower() == "exit")
                {
                    break;
                }

                // Örnek olarak, polinomları basitçe boşluklara göre ayırarak kaba bir ayrıştırma yapalım:
                string[] terimler1 = polinom1.Split(' ');
                string[] terimler2 = polinom2.Split(' ');

                // Toplama işlemi
                Console.WriteLine("Toplam:");
                foreach (string terim in terimler1)
                {
                    Console.Write(terim + " ");
                }
                Console.Write("+ ");
                foreach (string terim in terimler2)
                {
                    Console.Write(terim + " ");
                }
                Console.WriteLine();

                // Çıkarma işlemi
                Console.WriteLine("Fark:");
                foreach (string terim in terimler1)
                {
                    Console.Write(terim + " ");
                }
                Console.Write("- ");
                foreach (string terim in terimler2)
                {
                    Console.Write(terim + " ");
                }
                Console.WriteLine();
            }
        }
    }
}