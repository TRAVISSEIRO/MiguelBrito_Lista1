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
    public partial class Form13_MiguelBritoAlves : Form
    {
        double numA = 0;
        double numB = 0;
        double soma = 0;

        public Form13_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form13_MiguelBritoAlves_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            numA = Convert.ToDouble(textBox1.Text);
            numB = Convert.ToDouble(textBox3.Text);

            numA = 0;
            textBox4.Text = numA.ToString();
            numB = 0;
            textBox5.Text = numB.ToString();

            numA = 0;
            textBox2.Text = soma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
