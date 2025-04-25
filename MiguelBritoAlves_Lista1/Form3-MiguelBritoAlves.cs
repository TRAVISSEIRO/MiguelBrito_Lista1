using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiguelBritoAlves_Lista1
{
    public partial class Form3_MiguelBritoAlves : Form
    {
        double HT = 0;
        double VH = 0;
        double PD = 0;
        double TD = 0;
        double sb = 0;
        double SL = 0;
        public Form3_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void Form3_MiguelBritoAlves_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double HT = Convert.ToDouble(textBox1.Text);
            double VH = Convert.ToDouble(textBox1.Text);
            double PD = Convert.ToDouble(textBox1.Text);
            double sb = HT * VH;
            double TD = (PD/100)*sb;
            double SL = sb - TD;

            textBox4.Text = TD.ToString();
            textBox5.Text = sb.ToString();
            textBox6.Text = SL.ToString();
            textBox7.Text = HT.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        }
    }
}
