namespace PizzaHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SiparisAl = new System.Windows.Forms.Button();
            this.MilanoPizza = new System.Windows.Forms.CheckBox();
            this.WhitePizza = new System.Windows.Forms.CheckBox();
            this.MevsimSebzeliPizza = new System.Windows.Forms.CheckBox();
            this.AcısızSucukluPizza = new System.Windows.Forms.CheckBox();
            this.GennaroPizza = new System.Windows.Forms.CheckBox();
            this.İptalButonu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WhitePara = new System.Windows.Forms.Label();
            this.GennaroPizzaPara = new System.Windows.Forms.Label();
            this.AcısızPara = new System.Windows.Forms.Label();
            this.MevsimPara = new System.Windows.Forms.Label();
            this.MilanoPizzaPara = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Siparişler = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Boyutu = new System.Windows.Forms.ListBox();
            this.Ortaboy = new System.Windows.Forms.PictureBox();
            this.Büyükboy = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Küçük = new System.Windows.Forms.CheckBox();
            this.Büyük = new System.Windows.Forms.CheckBox();
            this.Orta = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ortaboy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Büyükboy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1453, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SiparisAl
            // 
            this.SiparisAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SiparisAl.BackgroundImage")));
            this.SiparisAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SiparisAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SiparisAl.Location = new System.Drawing.Point(990, 443);
            this.SiparisAl.Name = "SiparisAl";
            this.SiparisAl.Size = new System.Drawing.Size(182, 77);
            this.SiparisAl.TabIndex = 1;
            this.SiparisAl.Text = "SİPARİŞİ ONAYLA";
            this.SiparisAl.UseVisualStyleBackColor = true;
            this.SiparisAl.Click += new System.EventHandler(this.SiparisAl_Click);
            // 
            // MilanoPizza
            // 
            this.MilanoPizza.Location = new System.Drawing.Point(6, 31);
            this.MilanoPizza.Name = "MilanoPizza";
            this.MilanoPizza.Size = new System.Drawing.Size(147, 25);
            this.MilanoPizza.TabIndex = 2;
            this.MilanoPizza.Text = "Milano Pizza";
            this.MilanoPizza.UseVisualStyleBackColor = true;
            this.MilanoPizza.CheckedChanged += new System.EventHandler(this.MilanoPizza_CheckedChanged);
            // 
            // WhitePizza
            // 
            this.WhitePizza.Location = new System.Drawing.Point(6, 155);
            this.WhitePizza.Name = "WhitePizza";
            this.WhitePizza.Size = new System.Drawing.Size(154, 25);
            this.WhitePizza.TabIndex = 3;
            this.WhitePizza.Text = "White Pizza";
            this.WhitePizza.UseVisualStyleBackColor = true;
            this.WhitePizza.CheckedChanged += new System.EventHandler(this.WhitePizza_CheckedChanged);
            // 
            // MevsimSebzeliPizza
            // 
            this.MevsimSebzeliPizza.Location = new System.Drawing.Point(6, 124);
            this.MevsimSebzeliPizza.Name = "MevsimSebzeliPizza";
            this.MevsimSebzeliPizza.Size = new System.Drawing.Size(209, 25);
            this.MevsimSebzeliPizza.TabIndex = 4;
            this.MevsimSebzeliPizza.Text = "Mevsim Sebzeli Pizza";
            this.MevsimSebzeliPizza.UseVisualStyleBackColor = true;
            this.MevsimSebzeliPizza.CheckedChanged += new System.EventHandler(this.MevsimSebzeliPizza_CheckedChanged);
            // 
            // AcısızSucukluPizza
            // 
            this.AcısızSucukluPizza.Location = new System.Drawing.Point(6, 93);
            this.AcısızSucukluPizza.Name = "AcısızSucukluPizza";
            this.AcısızSucukluPizza.Size = new System.Drawing.Size(195, 25);
            this.AcısızSucukluPizza.TabIndex = 5;
            this.AcısızSucukluPizza.Text = "Acısız Sucuklu Pizza";
            this.AcısızSucukluPizza.UseVisualStyleBackColor = true;
            this.AcısızSucukluPizza.CheckedChanged += new System.EventHandler(this.AcısızSucukluPizza_CheckedChanged);
            // 
            // GennaroPizza
            // 
            this.GennaroPizza.Location = new System.Drawing.Point(6, 62);
            this.GennaroPizza.Name = "GennaroPizza";
            this.GennaroPizza.Size = new System.Drawing.Size(147, 25);
            this.GennaroPizza.TabIndex = 6;
            this.GennaroPizza.Text = "Gennaro Pizza";
            this.GennaroPizza.UseVisualStyleBackColor = true;
            this.GennaroPizza.CheckedChanged += new System.EventHandler(this.GennaroPizza_CheckedChanged);
            // 
            // İptalButonu
            // 
            this.İptalButonu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("İptalButonu.BackgroundImage")));
            this.İptalButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.İptalButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İptalButonu.Location = new System.Drawing.Point(1231, 443);
            this.İptalButonu.Name = "İptalButonu";
            this.İptalButonu.Size = new System.Drawing.Size(182, 77);
            this.İptalButonu.TabIndex = 7;
            this.İptalButonu.Text = "SİPARİŞ İPTAL ET";
            this.İptalButonu.UseVisualStyleBackColor = true;
            this.İptalButonu.Click += new System.EventHandler(this.İptalButonu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.WhitePara);
            this.groupBox1.Controls.Add(this.GennaroPizzaPara);
            this.groupBox1.Controls.Add(this.AcısızPara);
            this.groupBox1.Controls.Add(this.MevsimPara);
            this.groupBox1.Controls.Add(this.MilanoPizzaPara);
            this.groupBox1.Controls.Add(this.MilanoPizza);
            this.groupBox1.Controls.Add(this.GennaroPizza);
            this.groupBox1.Controls.Add(this.AcısızSucukluPizza);
            this.groupBox1.Controls.Add(this.WhitePizza);
            this.groupBox1.Controls.Add(this.MevsimSebzeliPizza);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 288);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Çeşitleri";
            // 
            // WhitePara
            // 
            this.WhitePara.AutoSize = true;
            this.WhitePara.Location = new System.Drawing.Point(175, 160);
            this.WhitePara.Name = "WhitePara";
            this.WhitePara.Size = new System.Drawing.Size(54, 20);
            this.WhitePara.TabIndex = 11;
            this.WhitePara.Text = "25 TL";
            // 
            // GennaroPizzaPara
            // 
            this.GennaroPizzaPara.AutoSize = true;
            this.GennaroPizzaPara.Location = new System.Drawing.Point(158, 62);
            this.GennaroPizzaPara.Name = "GennaroPizzaPara";
            this.GennaroPizzaPara.Size = new System.Drawing.Size(54, 20);
            this.GennaroPizzaPara.TabIndex = 10;
            this.GennaroPizzaPara.Text = "26 TL";
            // 
            // AcısızPara
            // 
            this.AcısızPara.AutoSize = true;
            this.AcısızPara.Location = new System.Drawing.Point(207, 94);
            this.AcısızPara.Name = "AcısızPara";
            this.AcısızPara.Size = new System.Drawing.Size(54, 20);
            this.AcısızPara.TabIndex = 9;
            this.AcısızPara.Text = "25 TL";
            // 
            // MevsimPara
            // 
            this.MevsimPara.AutoSize = true;
            this.MevsimPara.Location = new System.Drawing.Point(221, 125);
            this.MevsimPara.Name = "MevsimPara";
            this.MevsimPara.Size = new System.Drawing.Size(54, 20);
            this.MevsimPara.TabIndex = 8;
            this.MevsimPara.Text = "25 TL";
            // 
            // MilanoPizzaPara
            // 
            this.MilanoPizzaPara.AutoSize = true;
            this.MilanoPizzaPara.Location = new System.Drawing.Point(158, 31);
            this.MilanoPizzaPara.Name = "MilanoPizzaPara";
            this.MilanoPizzaPara.Size = new System.Drawing.Size(54, 20);
            this.MilanoPizzaPara.TabIndex = 7;
            this.MilanoPizzaPara.Text = "25 TL";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Brush Script MT", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(522, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 50);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "LITTLE PIZZA HOUSE";
            // 
            // Siparişler
            // 
            this.Siparişler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Siparişler.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Siparişler.FormattingEnabled = true;
            this.Siparişler.ItemHeight = 28;
            this.Siparişler.Location = new System.Drawing.Point(0, 359);
            this.Siparişler.Name = "Siparişler";
            this.Siparişler.Size = new System.Drawing.Size(288, 284);
            this.Siparişler.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Boyutu
            // 
            this.Boyutu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Boyutu.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Boyutu.FormattingEnabled = true;
            this.Boyutu.ItemHeight = 28;
            this.Boyutu.Location = new System.Drawing.Point(273, 359);
            this.Boyutu.MultiColumn = true;
            this.Boyutu.Name = "Boyutu";
            this.Boyutu.Size = new System.Drawing.Size(288, 284);
            this.Boyutu.TabIndex = 12;
            // 
            // Ortaboy
            // 
            this.Ortaboy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ortaboy.Image = ((System.Drawing.Image)(resources.GetObject("Ortaboy.Image")));
            this.Ortaboy.Location = new System.Drawing.Point(1289, 135);
            this.Ortaboy.Name = "Ortaboy";
            this.Ortaboy.Size = new System.Drawing.Size(132, 116);
            this.Ortaboy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ortaboy.TabIndex = 15;
            this.Ortaboy.TabStop = false;
            this.Ortaboy.Tag = "";
            // 
            // Büyükboy
            // 
            this.Büyükboy.Image = ((System.Drawing.Image)(resources.GetObject("Büyükboy.Image")));
            this.Büyükboy.Location = new System.Drawing.Point(1151, 252);
            this.Büyükboy.Name = "Büyükboy";
            this.Büyükboy.Size = new System.Drawing.Size(134, 122);
            this.Büyükboy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Büyükboy.TabIndex = 16;
            this.Büyükboy.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(1151, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 26);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Büyük Boy +10 TL";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(1288, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 26);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "Orta Boy +5 TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hazırlanmakta olan siparişler";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.Küçük);
            this.groupBox2.Controls.Add(this.Büyük);
            this.groupBox2.Controls.Add(this.Orta);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1067, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 132);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boyutlar";
            // 
            // Küçük
            // 
            this.Küçük.AutoSize = true;
            this.Küçük.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Küçük.Location = new System.Drawing.Point(7, 29);
            this.Küçük.Name = "Küçük";
            this.Küçük.Size = new System.Drawing.Size(117, 24);
            this.Küçük.TabIndex = 2;
            this.Küçük.Text = "Küçük Boy ";
            this.Küçük.UseVisualStyleBackColor = false;
            this.Küçük.CheckedChanged += new System.EventHandler(this.Küçük_CheckedChanged);
            // 
            // Büyük
            // 
            this.Büyük.AutoSize = true;
            this.Büyük.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Büyük.Location = new System.Drawing.Point(7, 93);
            this.Büyük.Name = "Büyük";
            this.Büyük.Size = new System.Drawing.Size(112, 24);
            this.Büyük.TabIndex = 1;
            this.Büyük.Text = "Büyük Boy";
            this.Büyük.UseVisualStyleBackColor = false;
            this.Büyük.CheckedChanged += new System.EventHandler(this.Büyük_CheckedChanged);
            // 
            // Orta
            // 
            this.Orta.AutoSize = true;
            this.Orta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Orta.Location = new System.Drawing.Point(7, 59);
            this.Orta.Name = "Orta";
            this.Orta.Size = new System.Drawing.Size(103, 24);
            this.Orta.TabIndex = 0;
            this.Orta.Text = "Orta Boy ";
            this.Orta.UseVisualStyleBackColor = false;
            this.Orta.CheckedChanged += new System.EventHandler(this.Orta_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Büyükboy);
            this.Controls.Add(this.Ortaboy);
            this.Controls.Add(this.Boyutu);
            this.Controls.Add(this.Siparişler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.İptalButonu);
            this.Controls.Add(this.SiparisAl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Little Pizza House";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ortaboy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Büyükboy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SiparisAl;
        private System.Windows.Forms.CheckBox MilanoPizza;
        private System.Windows.Forms.CheckBox WhitePizza;
        private System.Windows.Forms.CheckBox MevsimSebzeliPizza;
        private System.Windows.Forms.CheckBox AcısızSucukluPizza;
        private System.Windows.Forms.CheckBox GennaroPizza;
        private System.Windows.Forms.Button İptalButonu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Siparişler;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label WhitePara;
        private System.Windows.Forms.Label GennaroPizzaPara;
        private System.Windows.Forms.Label AcısızPara;
        private System.Windows.Forms.Label MevsimPara;
        private System.Windows.Forms.Label MilanoPizzaPara;
        private System.Windows.Forms.ListBox Boyutu;
        private System.Windows.Forms.PictureBox Ortaboy;
        private System.Windows.Forms.PictureBox Büyükboy;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Büyük;
        private System.Windows.Forms.CheckBox Orta;
        private System.Windows.Forms.CheckBox Küçük;
    }
}

