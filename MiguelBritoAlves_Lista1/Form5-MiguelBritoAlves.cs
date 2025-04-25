using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiguelBritoAlves_Lista1
{
    public partial class Form5_MiguelBritoAlves : Form
    {
        double celsius = 0;
        double farhe = 0;
        public Form5_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double farhe = Convert.ToDouble(textBox1.Text);
            double celsius = (farhe - 32)*(5/9);
            textBox2.Text = farhe.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form5_MiguelBritoAlves_Load(object sender, EventArgs e)
        {

        }
    }
}
