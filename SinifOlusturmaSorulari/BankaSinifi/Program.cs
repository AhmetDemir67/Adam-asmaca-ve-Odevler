using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaSorusu
{

    class Banka
    {

        static void Main(string[] args)
        {
            // Yeni bir banka hesabı oluşturuluyor: Hesap numarası ve başlangıç bakiyesi belirleniyor.
            Banka hesap = new Banka("TR365373563", 10000);

            // Hesap numarası ve başlangıç bakiyesi ekrana yazdırılıyor.
            Console.WriteLine($"Hesap Numarası: {hesap.HesapNO}, Başlangıç Bakiye: {hesap.bakiye} TL");

            // Para yatırma işlemi
            hesap.paraYatır(5000);

            // Para çekme işlemi
            hesap.paraCek(2000);

            // Yetersiz bakiye nedeniyle başarısız bir para çekme işlemi
            hesap.paraCek(250000);


            Console.Read();
        }

        // Hesap numarasını temsil eden özellik 
        public string HesapNO { get; private set; }

        // Bakiye değişkeni: Hesap bakiyesi private erişime sahip
        private decimal Bakiye;

        // Yapıcı metod (Constructor): Hesap numarası ve bakiye ile yeni bir Banka nesnesi oluşturuluyor.
        public Banka(string HesapNo, decimal bakiye)
        {
            HesapNO = HesapNo;  // Hesap numarasını alır ve HesapNO özelliğine atar.
            Bakiye = bakiye;  // Başlangıç bakiyesini alır ve Bakiye değişkenine atar.
        }

        // Bakiyeyi okuma özelliği: Sadece bakiye okunabilir, dışarıdan değiştirilemez.
        public decimal bakiye
        {
            get { return Bakiye; }  // Bakiye özelliği sadece "get" ile okunabilir.
        }

        // Para yatırma işlemi: Hesaba para yatırmak için kullanılan metod.
        public void paraYatır(decimal miktar)
        {
            if (miktar < 0)  // Eğer yatırılacak miktar negatifse işlem geçersizdir.
            {
                Console.WriteLine("geçersiz işlem.");  // Geçersiz işlem mesajı yazdırılır.
            }
            else
            {
                Bakiye += miktar;  // Yatırılan miktar bakiyeye eklenir.
                Console.WriteLine($"{miktar} TL Hesabınıza para yatırıldı. ");  // İşlem başarılı mesajı.
                Console.WriteLine("Güncel bakiyeniz:" + Bakiye);  // Güncel bakiye ekrana yazdırılır.
            }
        }

        // Para çekme işlemi: Hesaptan para çekmek için kullanılan metod.
        public void paraCek(decimal miktar)
        {
            if (miktar < 0)  // Eğer çekilecek miktar negatifse işlem geçersizdir.
            {
                Console.WriteLine("geçersiz işlem.");  // Geçersiz işlem mesajı yazdırılır.
            }
            else if (miktar > Bakiye)  // Eğer çekilecek miktar bakiyeden fazla ise
            {
                Console.WriteLine("yeterli bakiye yok.");  // Yetersiz bakiye mesajı yazdırılır.
            }
            else
            {
                Bakiye -= miktar;  // Çekilen miktar bakiyeden düşülür.
                Console.WriteLine($"{miktar} TL Hesabınızdan para çekildi.");  // İşlem başarılı mesajı.
                Console.WriteLine("Güncel Bakiyeniz:" + Bakiye);  // Güncel bakiye ekrana yazdırılır.
            }
        }
    }
}
