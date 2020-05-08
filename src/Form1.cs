using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace webproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate(open.FileName);
                this.WindowState = FormWindowState.Maximized;
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            string otvet="";
            if (x > 1 || y > 1 || x < -1 || y < -1)
            {
                otvet = "ne prinadlejit";
            }
            else if (Math.Pow(x, 2) < Math.Abs(y) && Math.Pow(y, 2) < Math.Abs(x))
            {
                otvet = "prinadlejit";
            }
            else if (Math.Pow(x, 2) == Math.Abs(y) || Math.Pow(y, 2) == Math.Abs(x))
            {
                otvet = "na granice";
            }
            MessageBox.Show(otvet);
            toolStripStatusLabel2.Text = otvet;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cheese = "Владислав Поваляев ПКсп-116";
            MessageBox.Show(cheese);
        }
    }
}
