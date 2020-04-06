using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variáveis
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void BtnInteiros_Click(object sender, EventArgs e)
        {
            /*Declaração das variáveis*/
            int a, b, soma;

            /*Entrada de dados*/
            a = Int32.Parse(txtA.Text);
            b = Int32.Parse(txtB.Text);

            /*Processamento*/
            soma = a + b;

            /*Saida de dados*/
            txtResultado.Text = soma.ToString();
        }

        private void BtnReais_Click(object sender, EventArgs e)
        {
            /*Declaração das variáveis*/
            double a, b, soma;

            /*Entrada de dados*/
            a = Convert.ToDouble(txtA.Text);
            b = double.Parse(txtB.Text);

            /*Processamento*/
            soma = a + b;

            /*Saída de dados*/
            txtResultado.Text = soma.ToString();

        }
    }
}
