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
    public partial class Form7_MiguelBritoAlves : Form
    {
        double tvg = 0;
        double VM = 0;
        double distancia = 0;
        double litros = 0;
        public Form7_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void Form7_MiguelBritoAlves_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double tvg = Convert.ToDouble(textBox1);
            double VM = Convert.ToDouble(textBox2);

            double distancia = tvg * VM;
            double litros = distancia / 12;

            textBox3.Text = VM.ToString();
            textBox4.Text = distancia.ToString();
            textBox5.Text = distancia.ToString();
            textBox6.Text = litros.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
