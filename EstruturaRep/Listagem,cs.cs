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
          
            int limite = Convert.ToInt32(textBox2.Text);
            contador = 1;
            while (contador <=limite)
            {
                Resultado.Items.Add(contador);
                comboBox1.Items.Add(contador);
                contador++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int limite = Convert.ToInt32(textBox2.Text);
            contador = 1;
            do
            {
                Resultado.Items.Add(contador);
                comboBox1.Items.Add(contador);
                contador++;
                
            }
            while (contador <= limite);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicao = Convert.ToInt32(textBox1.Text);
            if (posicao >= 0 && posicao < Resultado.Items.Count)
            {

                Resultado.Items.Add("Posição: "+ Resultado.Items[posicao]);
                comboBox1.Items.Add("Posição: "+ Resultado.Items[posicao]);
            }
            else
            {
                MessageBox.Show("Posição inválida. A posição deve ser maior ou igual a 0 e menor que o número de items");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resultado.Items.Clear();
            comboBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            int limite = Convert.ToInt32(textBox2.Text);
            for (contador = 1; contador <= limite; contador++)
            {
                Resultado.Items.Add(contador);
                comboBox1.Items.Add(contador);
            }
        }
         

        private void intervaloToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Intervalo tela3 = new Intervalo();
            tela3.Show();
        }

        private void fibonacciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Fibonacci tela4 = new Fibonacci();
            tela4.Show();
        }

        private void listagemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Listagem_cs tela2 = new Listagem_cs();
            tela2.Show();
        }

        private void tabuadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Tabuada tela1 = new Tabuada();
            tela1.Show();
        }

        private void fatorialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Fatorial tela5 = new Fatorial();
            tela5.Show();
        }

        

    }
    }

