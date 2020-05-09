using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BosMethod();
            int gelen_sonuc = Method();
            int[] elemanlar = new int[] { 12, 4, 8 };
            Array.Sort(elemanlar);
            int index = Array.IndexOf(elemanlar, 12); // Değeri indexe döndürür(Mantık).
            MessageBox.Show(elemanlar[index].ToString());
            // rnd.Next(5,15) // Yine bir değişkene eşitenmelidir. Değeri ona döndürür.
        }

        void BosMethod() // Geriye değer döndürmeyen method tanımlamasıdır.
        {
            int sonuc = 4 + 4;
        }

        int Method()
        {
            int sonuc = 4 + 4;
            return sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Temel 4 işlemi yapan bir method yazınız.
            int a = Hesap(4,3, '+');
            int b = Hesap(6, 3, '*');
            int c = Hesap(20, 2, '/');
            MessageBox.Show(a.ToString());
            MessageBox.Show(b.ToString());
            MessageBox.Show(c.ToString());
        }

        int Hesap(int sayi1, int sayi2, char islem)
        {
            int sonuc = 0;
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    MessageBox.Show("Geçerli bir işlem seçiniz.");
                    break;
            }
            return sonuc;
        }
    }
}
// Methodlar geriye değer dönen ve geriye değer dönmeyen olarak ikiye ayrılır.
// Geriye değer dönmeyen methodlar void anahtar kelimesi ile belirtilir.
// Geriye değer dönmeyen methodlar ise void harici herşeydir.
// Bir methodu geriye değer döndürebilmek için bir veritipi yazılır.
// Geriye değer dönen method tanımı: 
// <method dönüş tipi> <method ismi> (<varsa parametre tanımı>)
// {
//     <method gövdesi>
// }
// Method tipi geri değer döndürüyorsa return anahtar kelimesi kullanılır.
// Geri değer döndüren methodlar sadece tek bir değer dönerler.
// Methodun geri dönüş tipi ne ise return o tipte bir değer döndürmelidir.
// String ise örneğin: return = "xyz"; , int ise örneğin: return = 3;