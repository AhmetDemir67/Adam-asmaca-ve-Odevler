using System;
using System.Collections.Generic;

class Soru7
{
    static bool AsalMi(int sayi) // Asal sayı kontrolü
    {
        if (sayi <= 1) return false;
        if (sayi <= 3) return true;
        if (sayi % 2 == 0 || sayi % 3 == 0) return false;

        for (int i = 5; i * i <= sayi; i += 6)
        {
            if (sayi % i == 0 || sayi % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }

    static bool GecerliHareketMi(int x, int y, int satirSayisi, int sutunSayisi)
    {
        // Kapı koşulunu kontrol et
        return x >= 0 && x < satirSayisi && y >= 0 && y < sutunSayisi &&
               AsalMi(x % 10) && AsalMi(x / 10) &&
               AsalMi(y % 10) && AsalMi(y / 10) &&
               (x + y) % (x * y) == 0;
    }

    static bool DerinlikIlkAramaylaYolBul(int[][] labirent, int x, int y, int satirSayisi, int sutunSayisi, List<string> yol)
    {
        if (x == satirSayisi - 1 && y == sutunSayisi - 1)
        {
            // Hedefe ulaşıldı
            return true;
        }

        if (GecerliHareketMi(x, y, satirSayisi, sutunSayisi))
        {
            yol.Add($"({x}, {y})");
            labirent[x][y] = -1; // Ziyaretildiğini işaretle

            // Sağ, aşağı, sol, yukarı sırasıyla kontrol et
            if (DerinlikIlkAramaylaYolBul(labirent, x + 1, y, satirSayisi, sutunSayisi, yol) ||
                DerinlikIlkAramaylaYolBul(labirent, x, y + 1, satirSayisi, sutunSayisi, yol) ||
                DerinlikIlkAramaylaYolBul(labirent, x - 1, y, satirSayisi, sutunSayisi, yol) ||
                DerinlikIlkAramaylaYolBul(labirent, x, y - 1, satirSayisi, sutunSayisi, yol))
            {
                return true;
            }

            yol.RemoveAt(yol.Count - 1); // Yol değilse geri al
        }
        return false;
    }

    static void Main()
    {
        // Labirent boyutlarını kullanıcıdan al
        Console.Write("Labirentin satır sayısını girin: ");
        int satirSayisi = int.Parse(Console.ReadLine());
        Console.Write("Labirentin sütun sayısını girin: ");
        int sutunSayisi = int.Parse(Console.ReadLine());

        // Labirent matrisi oluştur
        int[][] labirent = new int[satirSayisi][];
        for (int i = 0; i < satirSayisi; i++)
        {
            labirent[i] = new int[sutunSayisi];
        }

        List<string> yol = new List<string>();
        if (DerinlikIlkAramaylaYolBul(labirent, 0, 0, satirSayisi, sutunSayisi, yol))
        {
            Console.WriteLine("Yol bulundu:");
            foreach (var adım in yol)
            {
                Console.WriteLine(adım);
            }
        }
        else
        {
            Console.WriteLine("Şehir kayboldu!");
        }
        Console.Read();
    }
}