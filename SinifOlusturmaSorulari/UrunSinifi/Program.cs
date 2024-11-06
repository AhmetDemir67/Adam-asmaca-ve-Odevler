using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanliProgramlama
{

    class Program
    {
        static void Main(string[] args)
        {
            // Urun sınıfından bir nesne oluşturuluyor.
            // "Bilgisayar" adında bir ürün ve 50000 TL fiyatı atanıyor.
            Urun nesne1 = new Urun("Bilgisayar", 50000);

            // Nesneye 30'luk bir indirim atanıyor.
            nesne1.Indirim = 30;

            // İndirimli fiyat hesaplanıyor ve ekrana yazdırılıyor.
            Console.WriteLine("Bilgisayarın indirimli fiyatı: " + nesne1.IndirimliFiyat());

            Console.Read();
        }
    }

    // Urun sınıfı: Ürünle ilgili işlemleri yapar.
    public class Urun
    {
        // Özellikler 
        public string Ad { get; set; }      // Ürünün adı
        public decimal Fiyat { get; set; }   // Ürünün fiyatı 

        // İndirim oranını tutan özel alan 
        private decimal indirim;

        // İndirim özelliği için get/set metotları
        // İndirim oranını 0 ile 50 arasında sınırlar.
        public decimal Indirim
        {
            get { return indirim; }  // İndirim değerini alır.
            set
            {
                // İndirim değeri negatifse 0 yapılır.
                if (value < 0)
                {
                    indirim = 0;
                }
                // İndirim değeri 50'den büyükse 50 yapılır.
                else if (value > 50)
                {
                    indirim = 50;
                }
                // Diğer durumlarda verilen değeri kabul eder.
                else
                {
                    indirim = value;
                }
            }
        }

        // Yapıcı metod (Constructor): Urun nesnesi oluşturulduğunda çalışır.
        public Urun(string ad, decimal fiyat)
        {
            Ad = ad;      // Ürünün adı atanır.
            Fiyat = fiyat; // Ürünün fiyatı atanır.
            Indirim = 0;   // Başlangıçta indirim oranı 0'dır.
        }

        // İndirimli fiyat hesaplama metodu
        public decimal IndirimliFiyat()
        {
            // İndirimli fiyat hesaplanır: 
            // Fiyat - (Fiyat * (Indirim / 100))
            return Fiyat - (Fiyat * (Indirim / 100));
        }
    }
}
