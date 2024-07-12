using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace security1
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }
        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz# ";

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                string pl = textBox1.Text;
                string k = textBox2.Text;
                bool km = true;
                for (int i = 0; i < k.Length; i++)
                {
                    if (!alpha.Contains(k[i]))
                    {
                        km = false;
                        break;
                    }
                }
                if (km)
                {
                    while (k.Length < pl.Length)
                        k += k;
                    int indx = 0;
                    for (int i = 0; i < pl.Length; i++)
                    {

                        if (alpha.Contains(pl[i]) && pl[i] != '#' && pl[i] != ' ')
                        {
                            int f = (alpha.IndexOf(char.ToUpper(pl[i])) + alpha.IndexOf(char.ToUpper(k[i - indx]))) % alpha.Length;
                            char newChar = char.IsUpper(pl[i]) ? alpha[f] : char.ToLower(alpha[f]);
                            textBox3.Text += newChar;
                        }
                        else if (pl[i] == ' ')
                        {
                            textBox3.Text += ' ';
                            indx++;
                        }
                        else if (pl[i] == '#')
                        {
                            textBox3.Text += '#';
                            indx++;
                        }
                        else
                        {
                            textBox3.Text += pl[i];
                            indx++;
                        }
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                string pl = textBox3.Text;
                string k = textBox2.Text;
                bool km = true;
                for (int i = 0; i < k.Length; i++)
                {
                    if (!alpha.Contains(k[i]))
                    {
                        km = false;
                        break;
                    }
                }
                if (km)
                {
                    while (k.Length < pl.Length)
                        k += k;
                    int indx = 0;
                    for (int i = 0; i < pl.Length; i++)
                    {
                        if (alpha.Contains(pl[i]) && pl[i] != '#' && pl[i] != ' ')
                        {
                            int f = (alpha.IndexOf(char.ToUpper(pl[i])) - alpha.IndexOf(char.ToUpper(k[i - indx]))) % alpha.Length;
                            char newChar = char.IsUpper(pl[i]) ? alpha[f] : char.ToLower(alpha[f]);
                            textBox4.Text += newChar;
                        }
                        else if (pl[i] == ' ')
                        {
                            textBox4.Text += ' ';
                            indx++;
                        }
                        else if (pl[i] == '#')
                        {
                            textBox4.Text += '#';
                            indx++;
                        }
                        else
                        {
                            textBox4.Text += pl[i];
                            indx++;
                        }

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }
    }
}

