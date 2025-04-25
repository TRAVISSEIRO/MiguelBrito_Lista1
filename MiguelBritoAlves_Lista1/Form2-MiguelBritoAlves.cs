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
    public partial class Form2_MiguelBritoAlves : Form
    {
        int num1 = 0;
        int num2 = 0;
        int soma = 0;
        public Form2_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void Form2_MiguelBritoAlves_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int soma = num1 + num2;
            textBox6.Text = soma.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit
                ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
        }
    }
}
