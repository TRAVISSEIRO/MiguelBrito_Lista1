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
    
        public partial class Form11_MiguelBritoAlves : Form
    {   
        double num1 = 0;
        public Form11_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
        }

        private void Form11_MiguelBritoAlves_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            double r = Convert.ToDouble(textBox1.Text);
            double Quadrado = 0;
            double cubo = 0;

            Quadrado = Math.Pow(r, 2);
            textBox2.Text= Quadrado.ToString();
            cubo = Math.Pow(r, 3);
            textBox4.Text= cubo.ToString();
            

        }
    }
}
