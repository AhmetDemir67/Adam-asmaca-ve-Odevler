using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCity_Sorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = { { 1, 0, 1 }, { 1, 1, 0 }, { 1, 1, 1 } };
            List<(int, int)> robots = new List<(int, int)> { (0, 0), (2, 2) };

            int rescuedNodes = TechCity.Rescue(grid, robots);
            Console.WriteLine("Kurtarılan düğüm sayısı: " + rescuedNodes);

            Console.Read();

        }
    }
}
