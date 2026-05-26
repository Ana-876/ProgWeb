using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRep
{
    public partial class Listagem_cs : Form
    {
        int contador, resultado;
        public Listagem_cs()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int posicao = Convert.ToInt32(textBox1.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int limite = Convert.ToInt32(textBox2.Text);
            for (contador=0; contador<=limite; contador++)
            {
                resultado = resultado + contador;
            }
        }
    }
}
