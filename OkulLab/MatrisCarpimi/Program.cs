using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_Carpimlari
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("matris carpım boyutunu girin:");    // kullanıcıdan matrislerin kaça kaç olmasını istedik.
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matris1 = new int[n, n];         // 1. matrisin çok boyutlu dizisi
            int[,] matris2 = new int[n, n];         // 2. matrisin çok boyutlu dizisi

            int[,] carpim = new int[n, n];          // matrisleri çarpmak için carpim dizisi


            Console.WriteLine("matris1 elemanlarını girin.");
            for (int i = 0; i < n; i++)     // matris1 in elemanlarını kullanıcıdan aldık 
            {
                for (int j = 0; j < n; j++)
                {
                    matris1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("matris2 elemanlarını girin.");
            for (int i = 0; i < n; i++)           // matris2 nin elemanlarını kullanıcıdan aldık
            {
                for (int j = 0; j < n; j++)
                {
                    matris2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < n; i++)       // matrislerin carpım işlemi 
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        carpim[i, j] += matris1[i, k] * matris2[k, j];
                    }
                }
            }

            Console.WriteLine("carpım sonuc");    // sonuçları yazdırdık
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(carpim[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
