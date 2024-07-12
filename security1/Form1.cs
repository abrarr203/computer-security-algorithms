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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace security1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            if(textBox1.Text  != "" && textBox2.Text != "")
            {
                int key = int.Parse(textBox2.Text);
                if(key >= 0 && key <= 26)
                {
                    char[] buffer = textBox1.Text.ToCharArray();
                    for(int i = 0; i < buffer.Length; i++)
                    {
                        if (Regex.IsMatch(buffer[i].ToString(), "[a-zA-Z]"))
                        {
                            char letter = (char)(buffer[i] + key);
                            if (char.IsUpper(buffer[i]) && letter > 'Z')
                                letter = (char)(letter - 26);
                            else if (char.IsLower(buffer[i]) && letter > 'z')
                                letter = (char)(letter - 26);
                            textBox3.Text += letter.ToString();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                int key = int.Parse(textBox2.Text);
                if (key >= 0 && key <= 26)
                {
                    char[] buffer = textBox3.Text.ToCharArray();
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        if (Regex.IsMatch(buffer[i].ToString(), "[a-zA-Z]"))
                        {
                            char letter = (char)(buffer[i] - key);
                            if(char.IsUpper(buffer[i]) && letter < 'A')
                                letter = (char)(letter + 26);
                            else if (char.IsLower(buffer[i]) && letter < 'a')
                                letter = (char)(letter + 26);
                            textBox4.Text += letter.ToString();
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = string.Empty;
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                int key = int.Parse(textBox6.Text);
                if (key >= 0 && key <= 36)
                {
                    char[] buffer = textBox5.Text.ToCharArray();
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        if (Regex.IsMatch(buffer[i].ToString(), "[ا-ي]"))
                        {
                            char letter = (char)(buffer[i] + key);
                            if (letter > 'ي')
                            {
                                letter = (char)(letter - 36);
                            }
                            textBox7.Text += letter.ToString();
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox8.Text = string.Empty;
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                int key = int.Parse(textBox6.Text);
                if (key >= 0 && key <= 36)
                {
                    char[] buffer = textBox7.Text.ToCharArray();
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        if (Regex.IsMatch(buffer[i].ToString(), "[ا-ي]"))
                        {
                            char letter = (char)(buffer[i] - key);
                            if (letter < 'ا')
                            {
                                letter = (char)(letter + 36);
                            }
                            textBox8.Text += letter.ToString();
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}