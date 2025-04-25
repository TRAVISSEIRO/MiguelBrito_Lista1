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
    public partial class Form6_MiguelBritoAlves : Form
    {
        double raio = 0;
        double altura = 0;
        double volume = 0;

        public Form6_MiguelBritoAlves()
        {
            InitializeComponent();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double raio = Convert.ToDouble(textBox1.Text);
            double altura = Convert.ToDouble(textBox2.Text);
            double volume = 3.14159*raio*raio*altura;
            textBox3.Text = volume.ToString();
        }

        private void Form6_MiguelBritoAlves_Load(object sender, EventArgs e)
        {

        }
    }
}
