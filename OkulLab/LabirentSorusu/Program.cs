using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirentSorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] labirint = {
                    { 1, 0, 1, 1 },
                    { 1, 1, 0, 1 },
                    { 0, 1, 0, 1 },
                    { 1, 1, 1, 1 }
                               };

            int enKisaYol = Labirent.EnKisaYol(labirint);

            if (enKisaYol == -1)
            {
                Console.WriteLine("Yol Yok");
            }
            else
            {
                Console.WriteLine("En kısa yol: " + enKisaYol + " adım");
            }
            Console.Read();
        }
    }
}
