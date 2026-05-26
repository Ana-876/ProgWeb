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
    public partial class Intervalo : Form
    {
        int contador = 1, fatorial;
        public Intervalo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(textBox1.Text);
            while (contador <= )
            {
                fatorial = fatorial * contador;
                Resultado.Items.Add(fatorial+ " x "+ contador+ " = "+ fatorial);
                comboBox1.Items.Add(fatorial);
                contador++;
            }

        }
    }
}
