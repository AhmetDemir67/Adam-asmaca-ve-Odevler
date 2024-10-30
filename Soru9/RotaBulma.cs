using System;

public class AsteroidMadenciligi
{
    public static int MinimumEnerjiYoluBul(int[,] enerjiMatrisi)
    {
        int satirSayisi = enerjiMatrisi.GetLength(0);
        int sutunSayisi = enerjiMatrisi.GetLength(1);

        // Minimum enerji matrisi oluşturma
        int[,] minEnerji = new int[satirSayisi, sutunSayisi];
        minEnerji[0, 0] = enerjiMatrisi[0, 0];

        // İlk satır ve ilk sütunu doldurma
        for (int i = 1; i < satirSayisi; i++)
        {
            minEnerji[i, 0] = minEnerji[i - 1, 0] + enerjiMatrisi[i, 0];
        }
        for (int j = 1; j < sutunSayisi; j++)
        {
            minEnerji[0, j] = minEnerji[0, j - 1] + enerjiMatrisi[0, j];
        }

        // Diğer hücrelerin minimum enerjilerini hesaplama
        for (int i = 1; i < satirSayisi; i++)
        {
            for (int j = 1; j < sutunSayisi; j++)
            {
                minEnerji[i, j] = enerjiMatrisi[i, j] + Math.Min(
                    minEnerji[i - 1, j],
                    Math.Min(minEnerji[i, j - 1], minEnerji[i - 1, j - 1]));
            }
        }

        return minEnerji[satirSayisi - 1, sutunSayisi - 1];
    }
}