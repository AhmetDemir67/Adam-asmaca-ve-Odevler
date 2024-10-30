namespace FlappyBirdOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreText = new System.Windows.Forms.Label();
            this.BoruUst3 = new System.Windows.Forms.PictureBox();
            this.BoruAlt3 = new System.Windows.Forms.PictureBox();
            this.BoruAlt2 = new System.Windows.Forms.PictureBox();
            this.BoruUst2 = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.BoruUst5 = new System.Windows.Forms.PictureBox();
            this.BoruUst4 = new System.Windows.Forms.PictureBox();
            this.BoruAlt5 = new System.Windows.Forms.PictureBox();
            this.BoruAlt4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt4)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScoreText.Location = new System.Drawing.Point(24, 553);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(36, 38);
            this.ScoreText.TabIndex = 9;
            this.ScoreText.Text = "0";
            // 
            // BoruUst3
            // 
            this.BoruUst3.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.BoruUst3.Location = new System.Drawing.Point(879, -3);
            this.BoruUst3.Name = "BoruUst3";
            this.BoruUst3.Size = new System.Drawing.Size(100, 211);
            this.BoruUst3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst3.TabIndex = 8;
            this.BoruUst3.TabStop = false;
            // 
            // BoruAlt3
            // 
            this.BoruAlt3.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.BoruAlt3.Location = new System.Drawing.Point(879, 349);
            this.BoruAlt3.Name = "BoruAlt3";
            this.BoruAlt3.Size = new System.Drawing.Size(100, 161);
            this.BoruAlt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt3.TabIndex = 7;
            this.BoruAlt3.TabStop = false;
            // 
            // BoruAlt2
            // 
            this.BoruAlt2.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.BoruAlt2.Location = new System.Drawing.Point(666, 415);
            this.BoruAlt2.Name = "BoruAlt2";
            this.BoruAlt2.Size = new System.Drawing.Size(100, 95);
            this.BoruAlt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt2.TabIndex = 6;
            this.BoruAlt2.TabStop = false;
//            this.BoruAlt2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BoruUst2
            // 
            this.BoruUst2.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.BoruUst2.Location = new System.Drawing.Point(666, -3);
            this.BoruUst2.Name = "BoruUst2";
            this.BoruUst2.Size = new System.Drawing.Size(100, 229);
            this.BoruUst2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst2.TabIndex = 5;
            this.BoruUst2.TabStop = false;
//            this.BoruUst2.Click += new System.EventHandler(this.BoruUst2_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBirdGame.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(116, 200);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(61, 58);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.Zemin.Location = new System.Drawing.Point(1, 507);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(1459, 102);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 3;
            this.Zemin.TabStop = false;
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.BoruAlt.Location = new System.Drawing.Point(446, 349);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(100, 161);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 2;
            this.BoruAlt.TabStop = false;
            // 
            // BoruUst
            // 
            this.BoruUst.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.BoruUst.Location = new System.Drawing.Point(446, -3);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(100, 129);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 0;
            this.BoruUst.TabStop = false;
            // 
            // BoruUst5
            // 
            this.BoruUst5.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.BoruUst5.Location = new System.Drawing.Point(1310, -3);
            this.BoruUst5.Name = "BoruUst5";
            this.BoruUst5.Size = new System.Drawing.Size(100, 196);
            this.BoruUst5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst5.TabIndex = 10;
            this.BoruUst5.TabStop = false;
            // 
            // BoruUst4
            // 
            this.BoruUst4.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.BoruUst4.Location = new System.Drawing.Point(1115, -3);
            this.BoruUst4.Name = "BoruUst4";
            this.BoruUst4.Size = new System.Drawing.Size(100, 283);
            this.BoruUst4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst4.TabIndex = 11;
            this.BoruUst4.TabStop = false;
            // 
            // BoruAlt5
            // 
            this.BoruAlt5.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.BoruAlt5.Location = new System.Drawing.Point(1310, 366);
            this.BoruAlt5.Name = "BoruAlt5";
            this.BoruAlt5.Size = new System.Drawing.Size(100, 144);
            this.BoruAlt5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt5.TabIndex = 12;
            this.BoruAlt5.TabStop = false;
            // 
            // BoruAlt4
            // 
            this.BoruAlt4.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.BoruAlt4.Location = new System.Drawing.Point(1115, 452);
            this.BoruAlt4.Name = "BoruAlt4";
            this.BoruAlt4.Size = new System.Drawing.Size(100, 58);
            this.BoruAlt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt4.TabIndex = 13;
            this.BoruAlt4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1458, 611);
            this.Controls.Add(this.BoruAlt4);
            this.Controls.Add(this.BoruAlt5);
            this.Controls.Add(this.BoruUst4);
            this.Controls.Add(this.BoruUst5);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.BoruUst3);
            this.Controls.Add(this.BoruAlt3);
            this.Controls.Add(this.BoruAlt2);
            this.Controls.Add(this.BoruUst2);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.BoruUst);
            this.Name = "Form1";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox BoruUst2;
        private System.Windows.Forms.PictureBox BoruAlt2;
        private System.Windows.Forms.PictureBox BoruAlt3;
        private System.Windows.Forms.PictureBox BoruUst3;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.PictureBox BoruUst5;
        private System.Windows.Forms.PictureBox BoruUst4;
        private System.Windows.Forms.PictureBox BoruAlt5;
        private System.Windows.Forms.PictureBox BoruAlt4;
    }
}

