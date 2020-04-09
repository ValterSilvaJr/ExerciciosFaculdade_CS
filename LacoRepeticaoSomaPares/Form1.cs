using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacoRepeticaoSomaPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            int i, num, soma = 0;

            //Entrada de dados - atribui a num o valor do txtNum
            num = Convert.ToInt32(txtNum.Text);

            //Inicializa o laço em 1, testa a condição de parada e incrementa a variável de controle i
            for(i = 1; i <= num; i++)
            {
                //Verifica se i é par
                if(i % 2 == 0)
                {
                    //Faz o somatório dos números pares
                    soma = soma + i;
                }
            }
            //Apresenta os valores do txtSoma
            txtSoma.Text = soma.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa os TextBox
            txtNum.Clear();
            txtSoma.Clear();

            //Coloca o foco no txtNum
            txtNum.Focus();
        }
    }
}
