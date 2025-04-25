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
    
    public partial class Form10_MiguelBritoAlves : Form
    { 
        double Altura = 0;
        double Largura = 0;
        double comprimento = 0;
        double volume = 0;

        public Form10_MiguelBritoAlves()
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

        private void Form10_MiguelBritoAlves_Load(object sender, EventArgs e)
        {
            Altura = Convert.ToDouble(textBox1.Text);
            Largura = Convert.ToDouble(textBox2.Text);
            comprimento = Convert.ToDouble(textBox3.Text);

            volume = Altura * comprimento * Largura;

            textBox4.Text = volume.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
