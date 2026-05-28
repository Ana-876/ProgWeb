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

namespace EstruturaRep
{
    public partial class Intervalo : Form
    {
        int contador = 1, fatorial;
       
        public Intervalo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int inicial = Convert.ToInt32(textBox2.Text);
            int final = Convert.ToInt32(textBox3.Text);
            int incr = Convert.ToInt32(textBox4.Text);
            
            while (inicial <= final)
            {
                Resultado.Items.Add(inicial);
                comboBox1.Items.Add(inicial);
                inicial = incr + inicial;
                
            }
            
            
        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void intervaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intervalo tela3 = new Intervalo();
            tela3.Show();
        }

        private void fatorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fatorial tela5 = new Fatorial();
            tela5.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listagem_cs tela2 = new Listagem_cs();
            tela2.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci tela4 = new Fibonacci();
            tela4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resultado.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabuada tela1 = new Tabuada();
            tela1.Show();
        }

       
    }
}
