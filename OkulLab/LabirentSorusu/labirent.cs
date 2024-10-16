using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirentSorusu
{

    using System;
    using System.Collections.Generic;

    public class Labirent
    {
        public static int EnKisaYol(int[,] labirint)
        {
            int N = labirint.GetLength(0);

            // Ziyaret edilen yerleri tutmak için bir bool matrisi oluşturduk.
            bool[,] ziyaretEdildi = new bool[N, N];

            // Kuyrukta tutmak için bir Queue kullanıyoruz
            Queue<(int, int)> kuyruk = new Queue<(int, int)>();

            // Başlangıç noktasını kuyruğa ekledik ve ziyaret edildiğini işaretledik
            kuyruk.Enqueue((0, 0));
            ziyaretEdildi[0, 0] = true;

            // 4 yöne hareket etmek için kullanılacak diziler
            int[] satirHareketleri = { -1, 1, 0, 0 };
            int[] sutunHareketleri = { 0, 0, 1, -1 };

            int adımSayısı = 0;

            while (kuyruk.Count > 0)
            {
                int boyut = kuyruk.Count;

                for (int i = 0; i < boyut; i++)
                {
                    (int satir, int sutun) = kuyruk.Dequeue();

                    // Hedefe ulaşıldıldığında adım sayısını döndür
                    if (satir == N - 1 && sutun == N - 1)
                    {
                        return adımSayısı;
                    }

                    // Komşu hücreleri incele
                    for (int j = 0; j < 4; j++)
                    {
                        int yeniSatir = satir + satirHareketleri[j];
                        int yeniSutun = sutun + sutunHareketleri[j];

                        // Eğer yeni hücre geçilebilir ve daha önce ziyaret edilmediyse
                        if (yeniSatir >= 0 && yeniSatir < N && yeniSutun >= 0 && yeniSutun < N
                            && labirint[yeniSatir, yeniSutun] == 1 && !ziyaretEdildi[yeniSatir, yeniSutun])
                        {
                            kuyruk.Enqueue((yeniSatir, yeniSutun));
                            ziyaretEdildi[yeniSatir, yeniSutun] = true;
                        }
                    }
                }
                adımSayısı++;
            }

            // Eğer buraya ulaşıldıysa yol yok demektir
            return -1;
        }
    }
}
