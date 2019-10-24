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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnGirisBilgisiKontrolu_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";

            string result = "";
            if(username == txtDeger1.Text) // admin=>true
            {
                if(password == txtDeger2.Text) // 123
                {
                    result = "Tebrikler!!!";
                }
                else
                {
                    result = "Şifreniz yanlış\nAnne sütü önemli";
                }
            }
            else
            {
                result = "Kullanıcı adınız yanlış\nYine başarısızlık!!!";
            }
            MessageBox.Show(result);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";

            string result = "";

            if (txtDeger1.Text == username && txtDeger2.Text == password)
            {
                result = "Tebrikler!!!";
            }
            else
            {
                result = "Kullanıcı adınız yanlış\nYine başarısızlık!!!";
            }
            MessageBox.Show(result);
        }

        private void BtnNotKontrolu_Click(object sender, EventArgs e)
        {
            double not = double.Parse(txtDeger1.Text);

            string result = "";

            if (not >= 0 && not < 30)
            {
                result = "FF Aldınız"; //eğer kod satırın sadece 1 tane ise {} kullanmana gerek yok.
            }
            else if (not >= 30 && not < 50)
            {
                result = "DD Aldınız";
            }
            else if (not >= 50 && not < 70)
            {
                result = "BB Aldınız";
            }
            else if (not >= 70 && not <= 100)
            {
                result = "AA Aldınız";
            }
            else
            {
                result = "Geçerli bir aralık giriniz";
            }
            MessageBox.Show(result);

            //KISA YOL
            if (not >= 0 && not <= 100)
            {
                if (not <= 30) { result = "FF Aldınız"; }
                else if (not <= 50) { result = "DD Aldınız"; }
                else if (not <= 70) { result = "BB Aldınız"; }
                else { result = "AA Aldınız"; }
            }
            else
                result = "Geçerli bir aralık giriniz";
            MessageBox.Show(result);
        }

        private void BtnMarketKontrolu_Click(object sender, EventArgs e)
        {
            string Urun = txtDeger1.Text.ToLower(); //ToLower() => hepsini küçük harfe çevirir.

            string mesaj = "Bu ürün ";
            
            if (Urun == "domates" || Urun == "biber" || Urun == "patlican")
            {
                mesaj += "Sebze Reyonunda";
            }
            else if (Urun == "diş macunu" || Urun == "parfüm" || Urun == "şampuan")
            {
                mesaj += "Kozmetik Reyonunda";
            }
            else if (Urun == "cep telefonu" || Urun == "bilgisayar" || Urun == "ses sistemi")
            {
                mesaj += "Teknoloji Reyonunda";
            }
            else
            {
                mesaj +=  "bizde yok";
            }
            MessageBox.Show(mesaj);
        }
    }
}
