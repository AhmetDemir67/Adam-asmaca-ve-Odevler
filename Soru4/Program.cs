using System;
using System.Collections.Generic;

class Soru4
{
    static void Main()
    {
        // Kullanıcıdan bir matematiksel ifade al
        Console.WriteLine("Bir matematiksel ifade girin (örneğin: 3 + 4 * 2 / (1 - 5) ^ 2 ^ 3):");
        string ifade = Console.ReadLine();

        try
        {
            // İfade hesaplanır ve sonuç gösterilir
            double sonuc = HesaplaVeGoster(ifade);
            Console.WriteLine($"Sonuç: {sonuc}");
        }
        catch (Exception ex)
        {
            // Hata durumunda hata mesajı göster
            Console.WriteLine($"Hata: {ex.Message}");
        }
        Console.Read(); // Programın kapanmaması için bekle
    }

    // İfadenin hesaplanmasını sağlar ve sonucu döndürür
    static double HesaplaVeGoster(string ifade)
    {
        var postfix = InfixToPostfix(ifade); // İfadenin infix notasyondan postfix notasyona çevrilmesi
        return PostfixiDeğerlendir(postfix); // Postfix ifadeyi değerlendirip sonucu döndür
    }

    // Infix notasyonunu postfix notasyonuna çevirir
    static Queue<string> InfixToPostfix(string ifade)
    {
        var çıktı = new Queue<string>(); // Sonuç için bir kuyruk oluştur
        var operatörYıgını = new Stack<string>(); // Operatörler için bir yığın oluştur
        string[] tokenler = ifade.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // İfadeyi parçalara ayır

        // Her bir token için döngü
        foreach (var token in tokenler)
        {
            if (double.TryParse(token, out _)) // Eğer token bir sayıysa
            {
                çıktı.Enqueue(token); // Sayıyı kuyruğa ekle
            }
            else if (token == "(")
            {
                operatörYıgını.Push(token); // Açık parantezi yığına ekle
            }
            else if (token == ")")
            {
                // Kapalı parantez için, açık paranteze kadar işle
                while (operatörYıgını.Count > 0 && operatörYıgını.Peek() != "(")
                {
                    çıktı.Enqueue(operatörYıgını.Pop()); // Yığındaki operatörleri kuyruğa ekle
                }
                // Eşleşmeyen parantez hatası kontrolü
                if (operatörYıgını.Count == 0) throw new InvalidOperationException("Eşleşmeyen parantez hatası.");
                operatörYıgını.Pop(); // Açık parantezi çıkar
            }
            else // Operatör
            {
                // Operatör önceliğine göre yığındaki operatörleri kuyruğa ekle
                while (operatörYıgını.Count > 0 && Öncelik(operatörYıgını.Peek()) >= Öncelik(token))
                {
                    çıktı.Enqueue(operatörYıgını.Pop());
                }
                operatörYıgını.Push(token); // Yeni operatörü yığına ekle
            }
        }

        // Yığındaki kalan operatörleri kuyruğa ekle
        while (operatörYıgını.Count > 0)
        {
            çıktı.Enqueue(operatörYıgını.Pop());
        }

        return çıktı; // Postfix notasyonunu döndür
    }

    // Postfix ifadeyi değerlendirir ve sonucu döndürür
    static double PostfixiDeğerlendir(Queue<string> postfix)
    {
        var yıgın = new Stack<double>(); // Sonuçları saklamak için bir yığın oluştur

        while (postfix.Count > 0)
        {
            var token = postfix.Dequeue(); // Postfix ifadedeki bir token al
            if (double.TryParse(token, out double sayı)) // Eğer token bir sayıysa
            {
                yıgın.Push(sayı); // Sayıyı yığına ekle
                Console.WriteLine($"Yığına eklendi: {sayı}"); // Ekleme işlemi
            }
            else
            {
                // Yeterli operand yoksa hata fırlat
                if (yıgın.Count < 2)
                {
                    throw new InvalidOperationException("Yeterli operand yok. Lütfen ifadenizi kontrol edin.");
                }
                double ikinciSayı = yıgın.Pop(); // Yığından ikinci sayıyı al
                double birinciSayı = yıgın.Pop(); // Yığından birinci sayıyı al
                double sonuç = 0;

                // Operatöre göre işlem yap
                switch (token)
                {
                    case "+":
                        sonuç = birinciSayı + ikinciSayı;
                        break;
                    case "-":
                        sonuç = birinciSayı - ikinciSayı;
                        break;
                    case "*":
                        sonuç = birinciSayı * ikinciSayı;
                        break;
                    case "/":
                        if (ikinciSayı == 0) throw new DivideByZeroException("Bölme hatası: Sıfıra bölme.");
                        sonuç = birinciSayı / ikinciSayı;
                        break;
                    case "^":
                        sonuç = Math.Pow(birinciSayı, ikinciSayı); // Üst alma
                        break;
                }

                yıgın.Push(sonuç); // Hesaplanan sonucu yığına ekle
                Console.WriteLine($"İşlem: {birinciSayı} {token} {ikinciSayı} = {sonuç}"); // İşlem detayını yazdır
            }
        }

        // Yığından sonucu al
        if (yıgın.Count != 1) throw new InvalidOperationException("Geçersiz ifade: Sonuç yok.");

        return yıgın.Pop(); // Sonucu döndür
    }

    // Operatör önceliğini belirler
    static int Öncelik(string operatör)
    {
        switch (operatör)
        {
            case "^": return 3; // Üst alma en yüksek öncelik
            case "*":
            case "/": return 2; // Çarpma ve bölme ikinci öncelik
            case "+":
            case "-": return 1; // Toplama ve çıkarma en düşük öncelik
            default: return 0; // Geçersiz operatör
        }
    }
}
