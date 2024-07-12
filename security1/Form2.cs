using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace security1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alpha = "ABCDEFGHIGKLMNOPQRSTUVWXYZ";
            string pl = textBox1.Text.ToUpper();
            string k = textBox2.Text.ToUpper();
            bool ktr = true;
            for (int i = 0; i < k.Length; i++)
            {
                if (!alpha.Contains(k[i]))
                {
                    ktr = false;
                    break;
                }
            }
            if (ktr)
            {
                while (pl.Length > k.Length)
                    k += k;
                for (int j = 0; j < pl.Length; j++)
                {
                    int x = (alpha.IndexOf(pl[j]) + alpha.IndexOf(k[j])) % 26;
                    textBox3.Text += alpha[x];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string alpha = "ABCDEFGHIGKLMNOPQRSTUVWXYZ";
            string pl = textBox3.Text.ToUpper();
            string k = textBox2.Text.ToUpper();
            bool ktr = true;
            for (int i = 0; i < k.Length; i++)
            {
                if (!alpha.Contains(k[i]))
                {
                    ktr = false;
                    break;
                }
            }
            if (ktr)
            {
                while (pl.Length > k.Length)
                    k += k;
                for (int j = 0; j < pl.Length; j++)
                {
                    int x = (alpha.IndexOf(pl[j]) - alpha.IndexOf(k[j])) % 26;
                    textBox4.Text += alpha[x];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }
    }
}
