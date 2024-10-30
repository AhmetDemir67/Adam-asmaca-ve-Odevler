using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdOyunu
{
    public partial class Form1 : Form
    {
        // random: Rastgele sayı üretmek için kullanılır. Boruların konumları rastgele belirlenirken bu nesne kullanılır.
        Random random = new Random();


        // boruHızı: Boruların ekranda sola doğru hareket etme hızını belirler.
        // gravity: Kuşun yerçekimi etkisi altında aşağı doğru hareket etme hızını belirler.
        // score: Oyuncunun puanını tutar.
        int boruHızı = 6;
        int gravity = 3;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        // Oyun döngüsü. Belirli aralıklarla tetiklenir ve oyunun her karesi için yapılması gereken işlemleri içerir.

        private void gameTimerEvent(object sender, EventArgs e)
        {
            // Kuşu yerçekimi etkisi altında aşağı doğru hareket ettirir.
            flappyBird.Top += gravity;

            // Tüm boruları sola doğru hareket ettirir.
            BoruAlt.Left -= boruHızı;
            BoruUst.Left -= boruHızı;
            BoruAlt2.Left -= boruHızı;
            BoruUst2.Left -= boruHızı;
            BoruAlt3.Left -= boruHızı;
            BoruUst3.Left -= boruHızı;
            BoruAlt4.Left -= boruHızı;
            BoruUst4.Left -= boruHızı;
            BoruAlt5.Left -= boruHızı;
            BoruUst5.Left -= boruHızı;

            ScoreText.Text = Convert.ToString(score);

            // Borular ekranın solundan çıkarsa tekrar sağa taşır ve skoru artırır.
            if (BoruUst.Left < -50)
            {
                BoruUst.Left = 800;

            }

            if (BoruAlt.Left < -50)
            {
                BoruAlt.Left = 800;
                score++;
            }

            if (BoruUst2.Left < -50)
            {
                BoruUst2.Left = 800;

            }

            if (BoruAlt2.Left < -50)
            {
                BoruAlt2.Left = 800;
                score++;

            }

            if (BoruUst3.Left < -50)
            {
                BoruUst3.Left = 800;

            }

            if (BoruAlt3.Left < -50)
            {
                BoruAlt3.Left = 800;
                score++;
            }

            if (BoruUst4.Left < -50)
            {
                BoruUst4.Left = 800;

            }

            if (BoruAlt4.Left < -50)
            {
                BoruAlt4.Left = 800;
                score++;
            }

            if (BoruUst5.Left < -50)
            {
                BoruUst5.Left = 800;

            }

            if (BoruAlt5.Left < -50)
            {
                BoruAlt5.Left = 800;
                score++;
            }



            // Kuşun borulara veya zemine çarpıp çarpmadığını kontrol eder.

            if (flappyBird.Bounds.IntersectsWith(BoruAlt.Bounds) || flappyBird.Bounds.IntersectsWith(BoruUst.Bounds) || flappyBird.Bounds.IntersectsWith(Zemin.Bounds)
                || flappyBird.Bounds.IntersectsWith(BoruAlt2.Bounds) || flappyBird.Bounds.IntersectsWith(BoruUst2.Bounds) || flappyBird.Bounds.IntersectsWith(BoruAlt3.Bounds) || flappyBird.Bounds.IntersectsWith(BoruUst3.Bounds)
                || flappyBird.Bounds.IntersectsWith(BoruAlt4.Bounds) || flappyBird.Bounds.IntersectsWith(BoruUst4.Bounds) || flappyBird.Bounds.IntersectsWith(BoruUst5.Bounds) || flappyBird.Bounds.IntersectsWith(BoruAlt.Bounds))
            {
                // Oyunu bitirir.
                endGame();
            }
            /* if (score > 5)
                 boruHızı = 10;
             if (score > 12)
                 boruHızı = 15;
             if (score > 25)
                 boruHızı = 25;
             if (score > 100)
                 boruHızı = 50;*/



        }


        // Boşluk tuşuna basıldığında tetiklenir. Kuşu yukarı doğru sıçratır.
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -8;     // Yerçekimi etkisi geçici olarak azaltılır.
        }

        // Boşluk tuşu bırakıldığında tetiklenir. Kuşun normal hareketine devam etmesini sağlar.
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 3;    // Yerçekimi etkisi eski haline getirilir.
        }

        // Oyun bittiğinde çağrılır. Oyunu durdurur ve sonucu gösterir.
        private void endGame()
        {
            gameTimer.Stop();
            ScoreText.Text = "SKORUNUZ:" + score;
            //MessageBox.Show("SKORUNUZ:" + score);
        }






    }
}