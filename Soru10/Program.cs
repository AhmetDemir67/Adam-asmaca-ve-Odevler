using System;
using System.Collections.Generic;

class Soru10
{
    static void Main()
    {
        List<int> sayilar = new List<int> { 3, 5, 2, 8 };
        List<string> operatörler = new List<string> { "+", "-", "*", "/" };

        List<string> sonuçlar = new List<string>();
        GeçerliİfadeleriBul(sayilar, operatörler, "", sonuçlar);

        foreach (var sonuç in sonuçlar)
        {
            Console.WriteLine(sonuç);
        }
    }

    static void GeçerliİfadeleriBul(List<int> sayilar, List<string> operatörler, string mevcutİfade, List<string> sonuçlar)
    {
        if (!string.IsNullOrEmpty(mevcutİfade))
        {
            try
            {
                double değerlendirmeSonucu = Değerlendir(mevcutİfade);
                if (değerlendirmeSonucu > 0)
                {
                    sonuçlar.Add(mevcutİfade);
                }
            }
            catch (Exception ex)
            {
                // Hatalı ifadeleri yoksay
                Console.WriteLine($"Hata: {ex.Message} - İfade: {mevcutİfade}");
            }
        }

        for (int i = 0; i < sayilar.Count; i++)
        {
            int sayı = sayilar[i];

            // Sayıyı ekle
            if (mevcutİfade.Length == 0 || (mevcutİfade.Length > 0 && OperatörMı(mevcutİfade[mevcutİfade.Length - 1])))
            {
                GeçerliİfadeleriBul(sayilar, operatörler, mevcutİfade + sayı, sonuçlar);
            }

            // Operatörleri ekle
            foreach (var operatör in operatörler)
            {
                if (mevcutİfade.Length > 0 && !OperatörMı(mevcutİfade[mevcutİfade.Length - 1]))
                {
                    GeçerliİfadeleriBul(sayilar, operatörler, mevcutİfade + operatör + sayı, sonuçlar);
                }
            }
        }
    }

    static bool OperatörMı(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/';
    }

    static double Değerlendir(string ifade)
    {
        // İfade geçerli mi kontrol et
        if (string.IsNullOrWhiteSpace(ifade) || OperatörMı(ifade[ifade.Length - 1]))
        {
            throw new InvalidOperationException("Geçersiz ifade.");
        }

        // DataTable kullanarak ifadeyi değerlendir
        try
        {
            var dataTable = new System.Data.DataTable();
            return Convert.ToDouble(dataTable.Compute(ifade, string.Empty));
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"İfade değerlendirilemedi: {ex.Message}");
        }
    }
}
