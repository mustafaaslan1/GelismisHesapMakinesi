using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelişmişHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Hesap makinesini kullanmadan önce 'Nasıl Kullanılır?' kısmını okumanız tavsiye edilir.","UYARI",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        int secim = 0;
        double s1, s2,sonuc;
        string isaret;
        private List<string> geçmiş = new List<string>();

        private void İslemler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "+")
            {
                s1 = double.Parse(textBox1.Text);
                secim = 1;
                textBox1.Text = "0";
            }

            else if (btn.Text == "-")
            {
                s1 = double.Parse(textBox1.Text);
                secim = 2;
                textBox1.Text = "0";
            }
            else if (btn.Text == "/")
            {
                s1 = double.Parse(textBox1.Text);
                secim = 3;
                textBox1.Text = "0";
            }
            else if (btn.Text == "*")
            {
                s1 = double.Parse(textBox1.Text);
                secim = 4;
                textBox1.Text = "0";
            }
            if (btn.Text == "EBOB")
            {
                string[] girilendeger = textBox1.Text.Split(',');
                if (girilendeger.Length != 2)
                {
                    MessageBox.Show("Lütfen virgülle ayrılmış iki sayı giriniz.");
                    return;

                }

                double s1 = Convert.ToInt32(girilendeger[0]);
                double s2 = Convert.ToInt32(girilendeger[1]);
                int ebob = 0;
                for (int i = 1; i <= s1 && i <= s2; i++)
                {
                    if (s1 % i == 0 && s2 % i == 0)
                    {
                        ebob = i;
                    }
                }
                textBox1.Text = $"Ebob = {ebob}";
                label1.Text = $"Ebob = {girilendeger[0]}, {girilendeger[1]}";
                string isaret = ebob == 1 ? "" : " ve";
                geçmiş.Add($"{s1} ve {s2} için EBOB = {ebob}");
                label3.Text = $"{RomanRakamlariYazdir(ebob)}";
            }
            else if (btn.Text == "EKOK")
            {
                string[] girilendeger = textBox1.Text.Split(',');
                if (girilendeger.Length != 2)
                {
                    MessageBox.Show("Lütfen virgülle ayrılmış iki sayı giriniz.");
                    return;
                }

                int s1 = Convert.ToInt32(girilendeger[0]);
                int s2 = Convert.ToInt32(girilendeger[1]);
                int max = Math.Max(s1, s2);
                int ekok = 0;

                for (int i = max; ; i += max)
                {
                    if (i % s1 == 0 && i % s2 == 0)
                    {
                        ekok = i;
                        break;
                    }
                }

                textBox1.Text = $"Ekok = {ekok}";
                label1.Text = $"Ekok = {girilendeger[0]}, {girilendeger[1]}";
                geçmiş.Add($"{s1} ve {s2} için EKOK = {ekok}");
                label3.Text = $"{RomanRakamlariYazdir(ekok)}";
            }
            else if (btn.Text == "x²")
            {
                double kare = Convert.ToDouble(textBox1.Text);
                double s1 = Convert.ToDouble(textBox1.Text);
                kare = Math.Pow(kare, 2);
                textBox1.Text = Convert.ToString(kare);
                string isaret = ("²");
                geçmiş.Add($"{s1}{isaret} = {textBox1.Text}");
                label3.Text = $"{RomanRakamlariYazdir(double.Parse(textBox1.Text))}";

            }
            else if (btn.Text == "x³")
            {
                double küp = Convert.ToDouble(textBox1.Text);
                double s1 = Convert.ToDouble(textBox1.Text);
                küp = Math.Pow(küp, 3);
                textBox1.Text = Convert.ToString(küp);
                string isaret = ("³");
                geçmiş.Add($"{s1}{isaret} = {textBox1.Text}");
                label3.Text = $"{RomanRakamlariYazdir(double.Parse(textBox1.Text))}";
            }
            else if (btn.Text == "1/x")
            {
                double.TryParse(textBox1.Text, out s1);
                label1.Text = "1/" + s1;
                if (s1 != 0) textBox1.Text = (1 / s1).ToString();
                else label1.Text = "HATA";
                string isaret = ("1/");
                geçmiş.Add($"{isaret}{s1} = {textBox1.Text}");
                label3.Text = $"{RomanRakamlariYazdir(double.Parse(textBox1.Text))}";
            }
            else if (btn.Text == "Mod")
            {
                secim = 6;
                if (s1 != 0)
                {

                    double sayi;
                    double.TryParse(textBox1.Text, out sayi);
                    if (sayi == 0) label1.Text = "HATA";
                    else textBox1.Text = (s1 % sayi).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                isaret = btn.Text;
                label1.Text = s1 + " " + isaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "√")
            {
                isaret = "√";
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Sqrt(s1).ToString();
                label1.Text = "√" + s1;
                geçmiş.Add($"{isaret}{s1} = {textBox1.Text}");

            }
            else if (btn.Text == "Üs")
            {
                secim = 5;
                double.TryParse(textBox1.Text, out s1);
                isaret = btn.Text;
                label1.Text = s1 + "^";
                textBox1.Text = "0";
            }
            else if (btn.Text == "C")
            {
                s1 = 0;
                s2 = 0;
                isaret = "";
                textBox1.Text = "0";
                label1.Text = "";
                label3.Text = "";
                label5.Text = "";
            }
            else if (btn.Text == "<")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";

                }

            }
            else if (btn.Text == "PI")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.PI.ToString();
                label1.Text = "PI";
            }
            else if (btn.Text == "n!")
            {
                double sayi;
                double fakt = 1;
                string isaret = ("!");
                double.TryParse(textBox1.Text, out sayi);
                try
                {
                    for (int i = 1; i <= sayi; i++)
                    {
                        fakt = fakt * i;
                    }
                    if (fakt.ToString() == "Infinity")
                    {
                        label1.Text = "Hata"; textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text = fakt.ToString();
                        label1.Text = sayi + "!";
                        geçmiş.Add($"{sayi}{isaret} = {textBox1.Text}");
                    }
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                    textBox1.Text = "0";
                    geçmiş.Add($"{sayi}{isaret} = {textBox1.Text}");
                }

            }
            else if (btn.Text == "±")
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    double currentNumber = double.Parse(textBox1.Text);
                    textBox1.Text = (-currentNumber).ToString();
                }
            }
            if (btn.Text == "=")
            {
                s2 = double.Parse(textBox1.Text);

                switch (secim)
                {
                    case 1:
                        sonuc = s1 + s2;
                        isaret = "+";
                        break;

                    case 2:
                        sonuc = s1 - s2;
                        isaret = "-";
                        break;

                    case 3:
                        if (s2 == 0)
                        {
                            label1.Text = "∞";
                            isaret = "/";
                        }
                        else
                        {
                            sonuc = s1 / s2;
                            isaret = "/";
                        }
                        break;

                    case 4: 
                        sonuc = s1 * s2;
                        isaret = "*";
                        break;

                    case 5:
                        sonuc = Math.Pow(s1, s2);
                        isaret = "^";
                        break;

                    case 6:
                        if (s2 == 0) label1.Text = "HATA";
                        else
                        {
                            sonuc = s1 % s2;
                            isaret = "Mod";
                        }
                        break;

                    default:
                        break;
                }

                textBox1.Text = sonuc.ToString();
                geçmiş.Add($"{s1} {isaret} {s2} = {textBox1.Text}");
                label3.Text = $"{RomanRakamlariYazdir(double.Parse(textBox1.Text))}";
                label5.Text = s1.ToString() + isaret + s2.ToString() + "=";
                secim = 0;
            }

        }
        private void Rakamlar(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text != "0")
            {
                textBox1.Text += btn.Text;
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += btn.Text;
            }
        }

        private void btnGeçmiş_Click(object sender, EventArgs e)
        {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(geçmiş.ToArray());      
        }
        private string RomanRakamlariYazdir(double sayi)
        {
            if (sayi < 1 || sayi > 3999)
            {
                return "Geçersiz sayı!";
            }

            string[] binler = { "", "M", "MM", "MMM" };
            string[] yuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] onlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] birler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            int binlerBasamagi = (int)(sayi / 1000);
            int yuzlerBasamagi = (int)((sayi % 1000) / 100);
            int onlarBasamagi = (int)((sayi % 100) / 10);
            int birlerBasamagi = (int)(sayi % 10);

            return binler[binlerBasamagi] + yuzler[yuzlerBasamagi] + onlar[onlarBasamagi] + birler[birlerBasamagi];

            
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            btnGeçmiş.Visible = false;
            groupBox2.Size = new System.Drawing.Size(272,108);
            textBox1.Size = new System.Drawing.Size(260, 80);
            this.Width = 310;
            this.Height = 500;

        }

        private void gelişmişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox4.Visible = true;
            btnGeçmiş.Visible = true;
            groupBox2.Size = new System.Drawing.Size(420, 110);
            textBox1.Size = new System.Drawing.Size(410,80);
            this.Width = 678;
            this.Height = 550;

        }

        private void nasılKullanılırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesap makinesini kullanırken uyulması gereken kurallar aşağıdadır.\n\n" +
                " - Görünüm kısmından Standart yaparsanız Standart hesap makinesine erişebilirsiniz.\n\n" +
                " - Standart hesap makinesi iken Görünüm kısmından Gelişmiş'e tıklarsanız Gelişmiş hesap makinesine erişebilirsiniz.\n\n" +
                " 1- Hesaplama yaptıktan sonra 'C' Tuşuna tıklarsanız hesap makinesi sıfırlanmış olacaktır.\n\n" +
                " 2- '<' Butonuna tıklarsanız son yazmış olduğunuz sayıyı silecektir.\n\n" +
                " 3- Faktöriyel hesaplaması yapmak istediğinizde önce sayıyı girip sonra faktöriyel işaretine tıklayabilirsiniz.\n\n" +
                " 4- Köklü sayı hesaplaması yapmak istediğiniz zaman önce sayıya tıklayıp ardından kök işaretine tıklayınız.\n\n" +
                " 5- Pi sayısını hesaplamak istiyorsanız sadece 'Pİ' ikonuna tıklamanız yeterlidir." +
                " NOT : Kare ve küp işlemlerinde = 'e basmanıza gerek yoktur. Sayı seçip kare veya kök tuşuna bastığınızda sonucu görebilirsiniz.\n\n" +
                " NOT : Yaptığınız işlemler kaydedilmektedir, Geçmiş butonuna tıklarsanız yaptığınız işlemleri görebilirsiniz.\n\n", "Gelişmiş Hesap Makinesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 

        private void btnVirgül_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") < 1)
            {
                textBox1.Text += ",";
            }

        }

        }
}
