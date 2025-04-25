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
    public partial class Form8_MiguelBritoAlves : Form
    {
        double numA = 0;
        double numB = 0;
        double numC = 0;
        double numD = 0;
        public Form8_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void Form8_MiguelBritoAlves_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             double numA = Convert.ToDouble(textBox1.Text);
             double numB = Convert.ToDouble(textBox2.Text);

            double numC = numA;
            double numD = numB;
            numB = numC;
            numA = numD;

            textBox3.Text = numC.ToString();
            textBox4.Text = numD.ToString();
            textBox5.Text = numA.ToString();
            textBox6.Text = numB.ToString();

        }
    }
}
