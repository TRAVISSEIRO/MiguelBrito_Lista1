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
    public partial class Form18_MiguelBritoAlves : Form
    {
        public Form18_MiguelBritoAlves()
        {
            InitializeComponent();
        }
        

            

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox6.Text = "";
        }

        private void Form18_MiguelBritoAlves_Load(object sender, EventArgs e)
        {
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
                double salario = Convert.ToDouble(textBox1.Text);
                double Salarioliquido;

            Salarioliquido = salario - ((salario / 100) * 15);
           
            textBox6.Text = Salarioliquido.ToString();
        }
    }
}
