using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifre_Oluşturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] zorluk;

        private void button1_Click(object sender, EventArgs e)
        {
         
            int sifre;
            string karakter = "";

            Random rastgele = new Random();
            if (CmbZorluk.SelectedIndex >= 0)
            {
                switch (CmbZorluk.SelectedIndex)
                {
                    
                    case 0: zorluk = new int[] { 65, 90 }; break;
                    
                    case 1: zorluk = new int[] { 97, 122 }; break;
                    
                    case 2: zorluk = new int[] { 48, 57 }; break;
                    
                    case 3: zorluk = new int[] { 33, 64 }; break;
                    
                    case 4: zorluk = new int[] { 58, 122 }; break;
                    
                    case 5: zorluk = new int[] { 33, 122 }; break;
                }

                for (int i = 0; i < NudSifreKarakterAdet.Value; i++)
                {
                    sifre = rastgele.Next(zorluk[0], zorluk[1]); 
                    karakter += Convert.ToChar(sifre).ToString();
                }
                    txt_olusan_sfire.Text = karakter;
            }
            else
            {
                MessageBox.Show("Zorluk seçmelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
