using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stirng_Metodlari_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime1 = textBox1.Text; // kelimeyi aldık
            label4.Text = kelime1.ToLower(); // metodumuzla tüm harflerini küçük yapıp yazdırdık.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kelime2 = textBox2.Text;

            label5.Text = kelime2.ToUpper(); // metodumuzla tüm harfleri büyük yaptık.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kelime3 = textBox3.Text; // kelimemizi aldık.

            int a = int.Parse(textBox4.Text); // sileceğimiz başlangıç değerini belirledik.

            int b = int.Parse(textBox5.Text); // başlangıçtan itibaren kaç karakter silecez bunu belirledik.

            label11.Text = kelime3.Remove(a,b); // ve metodumuz ile silme işlemini yapıp geri kalan kısmı yazdırdık.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool durum; // boolean tipinde değişkenimizi tanımladık.

            string kelime4 = textBox6.Text; // ilk kelime

            string kelime5 = textBox8.Text; // ikinci kelime

            durum = kelime4.Equals(kelime5); // karşılaştırma işlemi 1. kullanım
             
            durum = string.Equals(kelime4,kelime5); // karşılaştırma işlemi 2. kullanım

            if (durum == true)
            {
                label13.Text = "Kelimeler Aynıdır.";

            }

            else
                label13.Text = "Kelimeler farklıdır.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool durum2; // boolean tipinde değişkenimizi tanımladık.

            string kelime6 = "Ncfkr"; // Metin içinde arayacağımız kelime.

            string kelime7 = textBox7.Text; // Arama yapılacak Metin
              
            durum2 = kelime7.StartsWith(kelime6); // ilk kelimemize baktığımız metodumuzun kullanımı.

            if (durum2==true) // eğer istediğimiz kelime ile başlarsa olmasını istediğimiz ifade
            {
                label16.Text = "Metin istediğiniz kelime ile başlıyor.";
            }

            else // değilse gerekleşecek ifade.
            {
                label16.Text = "Metin istediğiniz kelime ile başlamıyor.";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool durum3; // boolean tipinde değişkenimizi tanımladık.

            string kelime8 = "Ncfkr"; // Metin içinde arayacağımız kelime.

            string kelime9 = textBox9.Text; // Arama yapılacak Metin

            durum3 = kelime9.EndsWith(kelime8); // Son kelimemize baktığımız metodumuzun kullanımı.

            if (durum3 == true) // eğer istediğimiz kelime ile başlarsa olmasını istediğimiz ifade
            {
                label24.Text = "Metin istediğiniz kelime ile bitiyor.";
            }

            else // değilse gerekleşecek ifade.
            {
                label24.Text = "Metin istediğiniz kelime ile bitmiyor.";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string kelime10 = "Murat  Ncfkr"; // İçine kelime yerleştirceğimiz kelimemiz.

            string kelime11 = textBox10.Text; // eklemek istediğimiz kelimemiz.

            label29.Text = kelime10.Insert(6,kelime11); // ekleme işlemimiz.
        }
    }
}
