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
    public partial class Form19_MiguelBritoAlves : Form
    {
        public Form19_MiguelBritoAlves()
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
            textBox6.Text = "";
                }

        private void Form19_MiguelBritoAlves_Load(object sender, EventArgs e)
        { string ultimosDigitosAno;
            string dia = Convert.ToString(textBox3.Text); 
            string mes = Convert.ToString(textBox2.Text);
            ultimosDigitosAno = Convert.ToString(textBox1.Text).Substring(2);
           


            string ddmmaa = dia + "/" + mes + "/" + ultimosDigitosAno;

            textBox6.Text = ddmmaa.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
