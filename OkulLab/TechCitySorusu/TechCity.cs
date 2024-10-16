using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCity_Sorusu
{
    internal class TechCity
    {
        public static int Rescue(int[,] grid, List<(int, int)> robots)
        {
            int satirlar = grid.GetLength(0);  //satır sayısı
            int sutunlar = grid.GetLength(1);  //sutün sayısı
            bool[,] visited = new bool[satirlar, sutunlar];     //ziyaret edilen hücreleri tutmak için  
            HashSet<(int, int)> rescuedNodes = new HashSet<(int, int)>(); //kurtarılan düğümleri tutmak için

            foreach (var robot in robots)
            {
                DFS(grid, visited, rescuedNodes, robot.Item1, robot.Item2); // her robot için DFS metodu çalıştır.
            }

            return rescuedNodes.Count;  // düğüm sayısını döndür
        }

        private static void DFS(int[,] grid, bool[,] visited, HashSet<(int, int)> rescuedNodes, int satir, int sutün)

        // rescuedNodes kurtarılan düğümleri saklamak için
        // visited ziyaret edilenleri tutmak için

        {

            // Eğer konum geçersizse veya ziyaret edilmişse veya hasarlıysa geri dön
            if (satir < 0 || sutün < 0 || satir >= grid.GetLength(0) || sutün >= grid.GetLength(1) || visited[satir, sutün] || grid[satir, sutün] == 0)
            {
                return;
            }

            // ziyaret edilmiş olarak işaretle
            visited[satir, sutün] = true;
            // kurtarılan düğümlere ekle 
            rescuedNodes.Add((satir, sutün));

            // komşu hücreleri ziyaret et
            DFS(grid, visited, rescuedNodes, satir - 1, sutün); // Üste
            DFS(grid, visited, rescuedNodes, satir + 1, sutün); // Alta
            DFS(grid, visited, rescuedNodes, satir, sutün - 1); // Sola
            DFS(grid, visited, rescuedNodes, satir, sutün + 1); // Sağa
        }
    }
}
