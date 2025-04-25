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
    public partial class Form12_MiguelBritoAlves : Form
    {
        
        public Form12_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form12_MiguelBritoAlves_Load(object sender, EventArgs e)
        {
            double numA = Convert.ToDouble(textBox1.Text);
            double numB = Convert.ToDouble(textBox3.Text);
            double numC = 0;
            double numD = 0;

            
           
            numC = numA + numB;
            textBox2.Text = numC.ToString();

            numD = Math.Pow(numC, 2); 
            textBox4.Text= numD.ToString();
        }
    }
}
