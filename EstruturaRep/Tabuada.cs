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
    public partial class Tabuada : Form
    {
        int contador = 0, resultado;
        public Tabuada()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(textBox1.Text);
            while (contador <= 10){
                resultado = Numero * contador;
                Resultado.Items.Add(Numero+ " x "+ contador+ " = "+  resultado);
                comboBox1.Items.Add(Numero + " x " + contador + " = " + resultado);
                contador++;
            }

        }

        private void Resultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
