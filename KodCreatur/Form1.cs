using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodCreatur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string donustur1(string a)
        {
            string b;
            b = a.ToLower();
            return b;
        }

        private string donustur2(string a)
        {
            string b;
            b = a[0].ToString().ToUpper();
            for (int i = 1; i < a.Length; i++)
            {
                b += a[i];
            }
            return b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(this.donustur1(textBox1.Text));
            listBox2.Items.Add(comboBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox2.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = listBox1.Items.Count, i;
            for (i = 0; i < a; i++)
            {
                richTextBox1.Text += "private "+listBox2.Items[i].ToString()+" "+listBox1.Items[i].ToString()+";\n";
            }
            string b;
            richTextBox1.Text += "\n\n";
            for ( i = 0; i < a; i++)
            {
                b = listBox1.Items[i].ToString();
                richTextBox1.Text += "public "+listBox2.Items[i].ToString()+" "+donustur2(b)+"\n{get{return "+b+";}\nset{"+b+"=value;}\n}\n";
            }
        }

    }
}
