using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hamurgerci_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "cesit1")
            {
                pictureBox1.ImageLocation = "cesit1.png" ;
            }
            else if(comboBox1.Text == "cesit2")
            {
                pictureBox1.ImageLocation = "cesit2.jpg";
            }
            else if(comboBox1.Text == "cesit3")
            {
                pictureBox1.ImageLocation = "cesit3.jpg";
            }
        }
        int a = 0;
        int fiyat = 0;

        private void temizle()
        {
            comboBox1.Text = "";
            textBox1.Clear();
            ortaboyut.Checked = false;
            buyukboyut.Checked = false;
            kingboyut.Checked = false;
            numericUpDown1.Value = 0;
            chhardal.Checked = false;
            chkivircik.Checked = false;
            chpeynir.Checked = false;
            chtursu.Checked = false;
            chdomates.Checked = false;
            chacisos.Checked = false;
            fiyat = 0;
        }

        int domates = 1, tursu = 1, acısos = 1, peynir = 1, hardal = 1, kıvırcık = 1;

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinden Emin Misin ?","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listView1.Items.Clear();
                a = 0;
            }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Veriyi Silmek İstiyor Musun ?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
            if (listView1.SelectedIndices.Count > 0) //Secili satır varmı yokmu kontrol ediliyor.
            listView1.Items.RemoveAt(listView1.SelectedItems[0].Index); //Seçili satırın index i ni yakalayarak satırı sildik.
            a = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int adet = Convert.ToInt32(numericUpDown1.Value);
          
            if(comboBox1.Text == "cesit1")
            {
                if(ortaboyut.Checked == true)
                {
                    fiyat = 20 * adet;
                }
                else if(buyukboyut.Checked == true)
                {
                    fiyat = 30 * adet;
                }
                else if(kingboyut.Checked == true)
                {
                    fiyat = 40 * adet;
                }
            }
            else if(comboBox1.Text == "cesit2")
            {
                if (ortaboyut.Checked == true)
                {
                    fiyat = 25 * adet;
                }
                else if (buyukboyut.Checked == true)
                {
                    fiyat = 35 * adet;
                }
                else if (kingboyut.Checked == true)
                {
                    fiyat = 45 * adet;
                }
            }
            else if (comboBox1.Text == "cesit3")
            {
                if (ortaboyut.Checked == true)
                {
                    fiyat = 30 * adet;
                }
                else if (buyukboyut.Checked == true)
                {
                    fiyat = 40 * adet;
                }
                else if (kingboyut.Checked == true)
                {
                    fiyat = 50 * adet;
                }
            }

            if(chdomates.Checked == true)
            {
                fiyat += domates;
            }
            if(chtursu.Checked == true)
            {
                fiyat += tursu;
            }
            if (chacisos.Checked == true) 
            {
                fiyat += acısos;
            }
            if (chpeynir.Checked == true)
            {
                fiyat += peynir;
            }
            if (chhardal.Checked == true)
            {
                fiyat += hardal;
            }
            if(chkivircik.Checked == true)
            {
                fiyat += kıvırcık;
            }
           



            listView1.Items.Add(textBox1.Text);
            listView1.Items[a].SubItems.Add(comboBox1.Text);
            listView1.Items[a].SubItems.Add(numericUpDown1.Text);
            listView1.Items[a].SubItems.Add(fiyat.ToString());

            a++;

            temizle();
        }
    }
}
