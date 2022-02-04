using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        PizzaLinkedListListed MyPizza = new PizzaLinkedListListed();
        PizzaLinkedListListed MyPizzaBoyutu = new PizzaLinkedListListed();
        int butonatıklanmasayısı = 0;
        int hesap = 0;
        
        
        private void SiparisAl_Click(object sender, EventArgs e)
        {
            if (MilanoPizza.Checked)
            {
                
                if (Orta.Checked)
                {
                    MyPizza.pushback(MilanoPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25 + 5;
                    MyPizzaBoyutu.pushback(Convert.ToString(Orta.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Orta.Checked = false;
                    
                }
                

                else if(Büyük.Checked)
                {
                    MyPizza.pushback(MilanoPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25 + 10;
                    MyPizzaBoyutu.pushback(Convert.ToString(Büyük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Büyük.Checked = false;
                }
                
                else if(Küçük.Checked)
                {
                    MyPizza.pushback(MilanoPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25;
                    MyPizzaBoyutu.pushback(Convert.ToString(Küçük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Küçük.Checked = false;
                }
                MyPizza.PrintLinkedList(Siparişler);
                MyPizzaBoyutu.PrintLinkedList(Boyutu);
                MilanoPizza.Checked = false;
                

            }

            else if (GennaroPizza.Checked)
            {
                if (Orta.Checked)
                {
                    MyPizza.pushback(GennaroPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 26 + 5;
                    MyPizzaBoyutu.pushback(Convert.ToString(Orta.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Orta.Checked = false;
                }
                else if (Büyük.Checked)
                {
                    MyPizza.pushback(GennaroPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 26 + 10;
                    MyPizzaBoyutu.pushback(Convert.ToString(Büyük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Büyük.Checked = false;
                }
                else if (Küçük.Checked)
                {
                    MyPizza.pushback(GennaroPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 26;
                    MyPizzaBoyutu.pushback(Convert.ToString(Küçük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Küçük.Checked = false;
                }
                
                MyPizza.PrintLinkedList(Siparişler);
                MyPizzaBoyutu.PrintLinkedList(Boyutu);
                GennaroPizza.Checked = false;
                
               

            }

            else if (AcısızSucukluPizza.Checked)
            {
                if (Orta.Checked)
                {
                    MyPizza.pushback(AcısızSucukluPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25 + 5;
                    MyPizzaBoyutu.pushback(Convert.ToString(Orta.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Orta.Checked = false;
                }
                else if (Büyük.Checked)
                {
                    MyPizza.pushback(AcısızSucukluPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25 + 10;
                    MyPizzaBoyutu.pushback(Convert.ToString(Büyük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Büyük.Checked = false;
                }
                else if (Küçük.Checked)
                {
                    MyPizza.pushback(AcısızSucukluPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25;
                    MyPizzaBoyutu.pushback(Convert.ToString(Küçük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Küçük.Checked = false;
                }
                MyPizza.PrintLinkedList(Siparişler);
                MyPizzaBoyutu.PrintLinkedList(Boyutu);
                AcısızSucukluPizza.Checked = false;
                
            }
            else if (MevsimSebzeliPizza.Checked)
            {
                
                if (Orta.Checked)
                {

                    MyPizza.pushback(MevsimSebzeliPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25 + 5;
                    MyPizzaBoyutu.pushback(Convert.ToString(Orta.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Orta.Checked = false;
                }
                else if (Büyük.Checked)
                {

                    MyPizza.pushback(MevsimSebzeliPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25 + 10;
                    MyPizzaBoyutu.pushback(Convert.ToString(Büyük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Büyük.Checked = false;
                }
                else if (Küçük.Checked)
                {

                    MyPizza.pushback(MevsimSebzeliPizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25;
                    MyPizzaBoyutu.pushback(Convert.ToString(Küçük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Küçük.Checked = false;
                }
                MyPizza.PrintLinkedList(Siparişler);
                MyPizzaBoyutu.PrintLinkedList(Boyutu);
                MevsimSebzeliPizza.Checked = false;
                

            }
            else if (WhitePizza.Checked)
            {
                if (Orta.Checked)
                {

                    MyPizza.pushback(WhitePizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25 + 5;
                    MyPizzaBoyutu.pushback(Convert.ToString(Orta.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Orta.Checked = false;
                }
                else if (Büyük.Checked)
                {

                    MyPizza.pushback(WhitePizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25 + 10;
                    MyPizzaBoyutu.pushback(Convert.ToString(Büyük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Büyük.Checked = false;
                }
                else if (Küçük.Checked)
                {

                    MyPizza.pushback(WhitePizza.Text);
                    butonatıklanmasayısı++;
                    hesap = 25;
                    MyPizzaBoyutu.pushback(Convert.ToString(Küçük.Text));
                    MessageBox.Show(Convert.ToString(butonatıklanmasayısı) + " numaralı sipariş onaylandı.Borcunuz :" + Convert.ToString(hesap) + " TL'dir.");
                    Küçük.Checked = false;
                }

                MyPizza.PrintLinkedList(Siparişler);
                MyPizzaBoyutu.PrintLinkedList(Boyutu);
                WhitePizza.Checked = false;
                

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Interval =120000;
            timer1.Enabled = true;
            if(MyPizza.first!=null)
            {
                timer1.Start();
            }
        }

        private void İptalButonu_Click(object sender, EventArgs e)//Butona basıldığında sipariş iptal edilecek
        {
            string a = Convert.ToString(Siparişler.SelectedItem);
            MyPizza.RemoveData(a);
            string b = Convert.ToString(Boyutu.SelectedItem);//basarken iki listboxdaki eş şeylere de tıklanmalı
            MyPizzaBoyutu.RemoveData(b);
            MessageBox.Show(a + " siparişi iptal edildi.");
            MyPizza.PrintLinkedList(Siparişler);
            MyPizzaBoyutu.PrintLinkedList(Boyutu);
            
        }

        private void timer1_Tick(object sender, EventArgs e)//her 60 saniyede bir sipariş hazır olcak şekilde kuruldu.
        {
            if (MyPizza.first != null)
            {
                MessageBox.Show(Convert.ToString(MyPizza.first.PizzaData) + Convert.ToString(MyPizzaBoyutu.first.PizzaData) + " sipariş hazır.");
                MyPizza.RemoveFromFirst();
                MyPizza.PrintLinkedList(Siparişler);
                MyPizzaBoyutu.RemoveFromFirst();
                MyPizzaBoyutu.PrintLinkedList(Boyutu);
            }


            
        }

        private void MilanoPizza_CheckedChanged(object sender, EventArgs e)
        {
            GennaroPizza.Enabled = false;
            WhitePizza.Enabled = false;
            AcısızSucukluPizza.Enabled = false;
            MevsimSebzeliPizza.Enabled = false;
            if (MilanoPizza.Checked == false)
            {
                GennaroPizza.Enabled = true;
                WhitePizza.Enabled = true;
                AcısızSucukluPizza.Enabled = true;
                MevsimSebzeliPizza.Enabled = true;
            }
        }

        private void GennaroPizza_CheckedChanged(object sender, EventArgs e)
        {
            MilanoPizza.Enabled = false;
            WhitePizza.Enabled = false;
            AcısızSucukluPizza.Enabled = false;
            MevsimSebzeliPizza.Enabled = false;
            if (GennaroPizza.Checked == false)
            {
                MilanoPizza.Enabled = true;
                WhitePizza.Enabled = true;
                AcısızSucukluPizza.Enabled = true;
                MevsimSebzeliPizza.Enabled = true;
            }
        }

        private void AcısızSucukluPizza_CheckedChanged(object sender, EventArgs e)
        {
            MilanoPizza.Enabled = false;
            WhitePizza.Enabled = false;
            GennaroPizza.Enabled = false;
            MevsimSebzeliPizza.Enabled = false;
            if (AcısızSucukluPizza.Checked == false)
            {
                MilanoPizza.Enabled = true;
                WhitePizza.Enabled = true;
                GennaroPizza.Enabled = true;
                MevsimSebzeliPizza.Enabled = true;
            }
        }

        private void MevsimSebzeliPizza_CheckedChanged(object sender, EventArgs e)
        {
            MilanoPizza.Enabled = false;
            WhitePizza.Enabled = false;
            GennaroPizza.Enabled = false;
            AcısızSucukluPizza.Enabled = false;
            if (MevsimSebzeliPizza.Checked == false)
            {
                MilanoPizza.Enabled = true;
                WhitePizza.Enabled = true;
                GennaroPizza.Enabled = true;
                AcısızSucukluPizza.Enabled = true;
            }
        }

        private void WhitePizza_CheckedChanged(object sender, EventArgs e)
        {
            MilanoPizza.Enabled = false;
            MevsimSebzeliPizza.Enabled = false;
            GennaroPizza.Enabled = false;
            AcısızSucukluPizza.Enabled = false;
            if (WhitePizza.Checked == false)
            {
                MilanoPizza.Enabled = true;
                MevsimSebzeliPizza.Enabled = true;
                GennaroPizza.Enabled = true;
                AcısızSucukluPizza.Enabled = true;
            }
        }

        private void Küçük_CheckedChanged(object sender, EventArgs e)
        {
            Orta.Enabled = false;
            Büyük.Enabled = false;
            if(Küçük.Checked==false)
            {
                Orta.Enabled = true;
                Büyük.Enabled = true;
            }
        }

        private void Orta_CheckedChanged(object sender, EventArgs e)
        {
            Küçük.Enabled = false;
            Büyük.Enabled = false;
            if (Orta.Checked == false)
            {
                Küçük.Enabled = true;
                Büyük.Enabled = true;
            }
        }

        private void Büyük_CheckedChanged(object sender, EventArgs e)
        {
            Orta.Enabled = false;
            Küçük.Enabled = false;
            if (Büyük.Checked == false)
            {
                Orta.Enabled = true;
                Küçük.Enabled = true;
            }
        }
    }
}
