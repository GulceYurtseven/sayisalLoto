using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayısalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
          private void button1_Click(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            int[] sayiDizi = new int[6];
            string[] sayi = new string[6];
            Label[] labels = new Label[6];
            TextBox[] textBoxes = new TextBox[6];
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            labels[5] = label6;
            textBoxes[0] = textBox1;
            textBoxes[1] = textBox2;
            textBoxes[2] = textBox3;
            textBoxes[3] = textBox4;
            textBoxes[4] = textBox5;
            textBoxes[5] = textBox6;

            int i, count = 0;
            for(i = 0; i < 6; i++)
            {
               sayiDizi[i] = rand.Next(0,9);
               sayi[i]=sayiDizi[i].ToString();
               labels[i].Text = sayi[i];
             }
            for (i = 0; i < 6; i++)
            {
                if (textBoxes[i].Text == labels[i].Text)
                {
                    count++;
                    
                }
            }
            label7.Text = count.ToString();
            if (count == 6)
            {
                label9.Text = "BRAV000 75.000.000.000 ₺ KAZANDINIZ!";
                pictureBox1.Visible = true;
            }
            if(count==5 || count == 4)
            {
                label9.Text = " ödülünüz 5000₺";
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            if (count == 3 || count == 2 || count == 1)
            {
                label9.Text = "ödülünüz 10₺ :)";
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;

            }

        }

        
    }
}
