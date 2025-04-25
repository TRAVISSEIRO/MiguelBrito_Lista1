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
    public partial class Form20_MiguelBritoAlves : Form
    {
        public Form20_MiguelBritoAlves()
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
            textBox4.Text = "";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
             string ultimosDigitosAno = Convert.ToString(textBox1.Text).Substring(2);
            string semestre = Convert.ToString(textBox2.Text);
            string Ordem  = Convert.ToString(textBox3.Text);
            string AASDDD = ultimosDigitosAno + "" + semestre + "" + Ordem;

            textBox4.Text = AASDDD.ToString();

           
        }
    }
}
