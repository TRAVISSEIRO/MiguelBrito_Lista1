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
    public partial class Form21_MiguelBritoAlves : Form
    {
        public Form21_MiguelBritoAlves()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
          
            textBox4.Text = "";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(textBox1.Text);
            string sobreN = Convert.ToString(textBox2.Text);

            textBox4.Text = nome + " " + sobreN;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
