using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrisin boyutunu giriniz (N): ");  // kullanıcıdan matris boyutu aldık.
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[N, N];     // n'e n çok boyutlu bir matris adlı dizi oluşturduk.

            int satirBaslangıc = 0, sutunBaslangıc = 0;           // satır ve sutün nun değişkenlerini oluşturduk
            int satırSonu = N - 1, sutunSonu = N - 1;

            //matrise yazılacak sayıları tutar
            int num = 1;

            while (satirBaslangıc <= satırSonu && sutunBaslangıc <= sutunSonu)
            {
                // Dıştan içe yazdırdığımız için ilk olarak üst satırı yazdırdık.
                for (int i = sutunBaslangıc; i <= sutunSonu; i++)
                {
                    matris[satirBaslangıc, i] = num++;
                }
                satirBaslangıc++;

                // Sağ sütun yazdırdık
                for (int i = satirBaslangıc; i <= satırSonu; i++)
                {
                    matris[i, sutunSonu] = num++;
                }
                sutunSonu--;

                // Alt satır yazdırdık
                if (satirBaslangıc <= satırSonu)
                {
                    for (int i = sutunSonu; i >= sutunBaslangıc; i--)
                    {
                        matris[satırSonu, i] = num++;
                    }
                    satırSonu--;
                }

                // Sol sütun yazdırdık
                if (sutunBaslangıc <= sutunSonu)
                {
                    for (int i = satırSonu; i >= satirBaslangıc; i--)
                    {
                        matris[i, sutunBaslangıc] = num++;
                    }
                    sutunBaslangıc++;
                }
            }

            // Matrisi ekrana yazdırdık
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matris[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}