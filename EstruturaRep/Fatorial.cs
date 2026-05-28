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
    public partial class Fatorial : Form
    {
        int contador = 1;
        string texto;
        public Fatorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fatorial = Convert.ToInt32(textBox1.Text);
            int numero = 1;
            if (fatorial == 0)
            {
                MessageBox.Show("O fatorial de 0 é 1");
            }
            else if(fatorial < 0){
                MessageBox.Show("Fatorial de números negativos não existe");
            }
            else
            {
                while (contador <= fatorial)
                {
                    texto += contador;
                    if (contador < fatorial)
                    {
                        texto += " x ";
                    }
                    numero = numero * contador;
                    contador++;
                }
                MessageBox.Show(texto + " = " + numero);
            }
        }
        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabuada tela1 = new Tabuada();
            tela1.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listagem_cs tela2 = new Listagem_cs();
            tela2.Show();
        }

        private void intervaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intervalo tela3 = new Intervalo();
            tela3.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci tela4 = new Fibonacci();
            tela4.Show();
        }

        private void fatorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fatorial tela5 = new Fatorial();
            tela5.Show();
        }

    }
}
