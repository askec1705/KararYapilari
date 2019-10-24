using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text == "admin")
            {
                MessageBox.Show("Tebrikler giriş yaptınız");
            } // true
            else
            {
                MessageBox.Show("Ne kadar zor olabilir ?");
            } // false
        }

        private void BtnNotKontrolu_Click(object sender, EventArgs e)
        {
            double not = double.Parse(txtDeger.Text);
            if(not < 0)
            {
                MessageBox.Show("0'dan küçük not girişi yapamazsınız!");
            }
            else if (not > 100)
            {
                MessageBox.Show("100'den büyük not girişi yapamazsınız!");
            }
            else
            {
                MessageBox.Show("Notunuz : " + not);
            }
        }

        private void BtnTekCiftKontrolu_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtDeger.Text);
            if((sayi % 2) == 1)
            {
                MessageBox.Show("Sayi tektir");
            }
            else
            {
                MessageBox.Show("Sayi çifttir");
            }
        }

        private void BtnDegerKontrolu_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text.Length >= 8)
            {
                MessageBox.Show("Kayıt onaylandı");
            }
            else
            {
                MessageBox.Show("Daha uzun bir şifre giriniz");
            }
        }
    }
}
