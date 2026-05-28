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
    public partial class Fibonacci : Form
    {
        int primeiro = 0, segundo = 1, i = 0;
       
        public Fibonacci()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int limite = Convert.ToInt32(textBox1.Text);

            while (i <= limite)
            {

                Resposta.Items.Add(primeiro);
                int terceiro = primeiro + segundo;
                primeiro = segundo;
                segundo = terceiro;
                i++;

                
            }
            
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci tela4 = new Fibonacci();
            tela4.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listagem_cs tela2 = new Listagem_cs();
            tela2.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabuada tela1 = new Tabuada();
            tela1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {

        }

        private void fatorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fatorial tela5 = new Fatorial();
            tela5.Show();
        }

        
        private void intervaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intervalo tela3 = new Intervalo();
            tela3.Show();
        }

       
    }
}
