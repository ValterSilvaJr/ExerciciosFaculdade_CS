using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            int x, y;

            //Entrada de dados, converte o texto do textbox para int
            x = Convert.ToInt32(txtX.Text);
            y = ++x;

            //Saída de dados
            MessageBox.Show("Y = " + y + " X = " + x, "Incremento pré-fixado");
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            int x, y;

            //Entrada de dados, converte o texto do textbox para int
            x = Int32.Parse(txtX.Text);
            y = x++;

            //Saída de dados
            MessageBox.Show("Y = " + y + " X = " + x, "Pós_fixado");
        }
    }
}
