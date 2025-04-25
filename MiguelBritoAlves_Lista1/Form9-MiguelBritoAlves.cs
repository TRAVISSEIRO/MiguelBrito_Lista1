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
    public partial class Form9_MiguelBritoAlves : Form
    {
        double numA = 0;
        double numB = 0;
        double numC = 0;
        double numD = 0;
        double numCalc = 0;

        public Form9_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void Form9_MiguelBritoAlves_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numA = Convert.ToDouble(textBox13.Text);
            numB = Convert.ToDouble(textBox14.Text);
            numC = Convert.ToDouble(textBox15.Text);
            numD = Convert.ToDouble(textBox16.Text);

            numCalc = numA + numB;
            textBox1.Text = numCalc.ToString();
            numCalc = numA + numC;
            textBox7.Text = numCalc.ToString();
            numCalc = numA + numD;
            textBox2.Text = numCalc.ToString();
            numCalc = numB + numC;
            textBox8.Text = numCalc.ToString();
            numCalc = numB + numD;
            textBox10.Text = numCalc.ToString();
            numCalc = numC + numD;
            textBox9.Text = numCalc.ToString();

            numCalc = numA * numB;
            textBox3.Text = numCalc.ToString();
            numCalc = numA * numC;
            textBox5.Text = numCalc.ToString();
            numCalc = numA * numD;
            textBox4.Text = numCalc.ToString();
            numCalc = numB * numC;
            textBox6.Text = numCalc.ToString();
            numCalc = numB * numD;
            textBox12.Text = numCalc.ToString();
            numCalc = numC * numD;
            textBox11.Text = numCalc.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
