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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void TxtKitapSiparis_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(txtKitap.Text);//bunu try catch ile yap "elli" yazılamasın.
            int birimFiyat = 5;
            double ödemenizGerekenTutar;
            int toplamTutar;
            if (adet < 20)
            {
                toplamTutar = adet * birimFiyat;
                ödemenizGerekenTutar = toplamTutar * 0.95;
                MessageBox.Show("Toplam sipariş adediniz : " + adet);
                MessageBox.Show("Birim fiyatı : " + birimFiyat);
                MessageBox.Show("Toplam tutar : " + toplamTutar);
                MessageBox.Show("0 ile 20 arasında yapılan indirim oranı : %5 " );
                MessageBox.Show("Ödemeniz gereken tutar : " + ödemenizGerekenTutar);
            }
            else if (adet >= 20 && adet < 50)
            {
                toplamTutar = adet * birimFiyat;
                ödemenizGerekenTutar = toplamTutar * 0.90;
                MessageBox.Show("Toplam sipariş adediniz : " + adet);
                MessageBox.Show("Birim fiyatı : " + birimFiyat);
                MessageBox.Show("Toplam tutar : " + toplamTutar);
                MessageBox.Show("20 ile 50 arasında yapılan indirim oranı : %10 ");
                MessageBox.Show("Ödemeniz gereken tutar : " + ödemenizGerekenTutar);
            }
            else if (adet >= 50 && adet <= 100)
            {
                toplamTutar = adet * birimFiyat;
                ödemenizGerekenTutar = toplamTutar * 0.85;
                MessageBox.Show("Toplam sipariş adediniz : " + adet);
                MessageBox.Show("Birim fiyatı : " + birimFiyat);
                MessageBox.Show("Toplam tutar : " + toplamTutar);
                MessageBox.Show("50 ile 100 arasında yapılan indirim oranı : %15 ");
                MessageBox.Show("Ödemeniz gereken tutar : " + ödemenizGerekenTutar);
            }
            else
            {
                toplamTutar = adet * birimFiyat;
                ödemenizGerekenTutar = toplamTutar * 0.75;
                MessageBox.Show("Toplam sipariş adediniz : " + adet);
                MessageBox.Show("Birim fiyatı : " + birimFiyat);
                MessageBox.Show("Toplam tutar : " + toplamTutar);
                MessageBox.Show("100'den fazlaysa yapılan indirim oranı : %25 ");
                MessageBox.Show("Ödemeniz gereken tutar : " + ödemenizGerekenTutar);
            }
        }
    }
}
