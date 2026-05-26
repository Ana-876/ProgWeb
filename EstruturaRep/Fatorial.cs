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
        int contador = 1, fatorial;
        public Fatorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(textBox1.Text);
            while (contador <= fatorial)
            {
                fatorial = fatorial * contador;
                MessageBox.Show(fatorial + " x " + contador + " = " + fatorial);
                contador++;
            }
        }
    }
}
