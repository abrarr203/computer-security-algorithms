using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace security1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBox2.Text);
            string pl = textBox1.Text;
            if(k > 1 && k < pl.Length)
            {
                List<string> list = new List<string>();
                for(int i = 0; i < k; i++) {
                    list.Add("");
                }
                int index = 0;
                foreach(var i in pl)
                {
                    if (index == k)
                    {
                        index = 0;
                    }
                    list[index] += i;
                    index++;
                }
                foreach(var i in list)
                {
                    textBox3.Text += i;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBox2.Text);
            List<List<int>> list = new List<List<int>>();
            for(int i = 0;i < k;i++)
            {
                list.Add(new List<int>());
            }
            int num = 0;
            string c = textBox3.Text;
            for (int i = 0;i < c.Length ; i++)
            {
                list[num].Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }
    }
}
