using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enerji matrisini tanımla
            int[,] enerjiMatrisi =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Minimum enerjiyi hesapla
            int minimumEnerji = AsteroidMadenciligi.MinimumEnerjiYoluBul(enerjiMatrisi);

            // Sonucu yazdır
            Console.WriteLine("Minimum enerji: " + minimumEnerji);

            Console.Read();
        }
    }
}