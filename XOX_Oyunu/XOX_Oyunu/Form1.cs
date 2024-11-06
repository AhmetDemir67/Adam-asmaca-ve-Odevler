using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX_Oyunu
{
    public partial class Form1 : Form
    {
        // Form açıldığında ilk başta yapılacak işlemleri burada belirliyoruz
        public Form1()
        {
            InitializeComponent();
        }

        // Buton tıklama olayını ele alan metot
        private void Butonlar(object sender, EventArgs e)
        {
            // Gönderilen nesneyi Button türüne dönüştürüyoruz
            Button button = sender as Button;

            // Eğer label1'de "X" varsa, X sırası demektir
            if (label1.Text == "X")
            {
                // Butona "X" yazıyoruz
                button.Text = "X";

                // Etiketin yazısını güncelliyoruz
                label2.Text = "Sıradaki:";

                // Butonun arka plan rengini yeşil yapıyoruz 
                button.BackColor = Color.Green;

                // Butonu devre dışı bırakıyoruz, tekrar tıklanmasın
                button.Enabled = false;

                // Şimdi sırası O'ya geçsin
                label1.Text = "O";
            }
            else
            {
                // O'nun sırası
                button.Text = "O";
                label2.Text = "Sıradaki:";
                button.BackColor = Color.Red; // O'nun rengi kırmızı
                button.Enabled = false; // Buton artık tıklanamaz
                label1.Text = "X"; // Şimdi X'in sırası
            }

            // Kazanma Kontrolü - X
            // X'in kazandığı her durumu kontrol ediyoruz
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("OYUNU X KAZANDI.");
                endGame(); // Oyunu bitiriyoruz
                
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("OYUNU X KAZANDI.");
                endGame();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("OYUNU X KAZANDI.");
                endGame();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("OYUNU X KAZANDI.");
                endGame();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("OYUNU X KAZANDI.");
                endGame();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("OYUNU X KAZANDI.");
                endGame();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("OYUNU X KAZANDI.");
                endGame();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("OYUNU X KAZANDI.");
                endGame();
            }

            // Kazanma Kontrolü - O
            // O'nun kazandığı her durumu kontrol ediyoruz
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("OYUNU O KAZANDI");
                endGame();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("OYUNU O KAZANDI");
                endGame();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("OYUNU O KAZANDI");
                endGame();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("OYUNU O KAZANDI");
                endGame();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("OYUNU O KAZANDI");
                endGame();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("OYUNU O KAZANDI");
                endGame();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("OYUNU O KAZANDI");
                endGame();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("OYUNU O KAZANDI");
                endGame();
            }

            // Beraberlik Kontrolü
            // Eğer bütün kutular dolmuşsa ve kazanan yoksa oyun berabere demektir
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("OYUN BERABERE");
                button.BackColor = DefaultBackColor;
                endGame();
            }
        }

        // Formda bulunan çıkış butonuna tıklanınca uygulama kapatılır
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Oyunu bitiren metot
        void endGame()
        {
            // Tüm butonlardaki yazıları temizliyoruz
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

           

            // Tüm butonları tekrar etkin hale getiriyoruz
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

     
        }

        // Form yüklendiğinde kullanıcıya hangi sembolü oynayacağı soruluyor
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
