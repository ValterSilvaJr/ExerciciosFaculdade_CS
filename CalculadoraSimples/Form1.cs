using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha o programa
            Application.Exit();
            //ou
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa o contéudo do TextBox
            txtTotal.Clear();
            txtX.Clear();
            txtY.Clear();

            //Coloca o foco no TextBox X
            txtX.Focus();

            //Deixa a opção somar selecionada
            rdbSomar.Checked = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            double x, y, total;

            //Verifica se o que foi digitado na TextBox X é um número ou se está vazia
            if(double.TryParse(txtX.Text, out x) == false)
            {
                MessageBox.Show("Informe um número válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Limpa a TextBox X 
                txtX.Clear();

                //Coloca o foco na TextBox X
                txtX.Focus();

                //Sai da sub-rotina, não executa o código que está abaixo
                return;
            }

            //Verifica se o que foi digitado na TextBox Y é um número ou se está vazia
            if (double.TryParse(txtY.Text, out y) == false)
            {
                MessageBox.Show("Informe um número válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpa a TextBox Y 
                txtY.Clear();

                //Coloca o foco na TextBox Y
                txtY.Focus();

                //Sai da sub-rotina, não executa o código que está abaixo
                return;
            }

            //Processamento, testa na estrutura condicional qual RadioButton está selecionado
            if(rdbSomar.Checked == true)
            {
                total = x + y;
                
            }
            else if(rdbSubtrair.Checked)
            {
                total = x - y;
            }
            else if(rdbMultiplicar.Checked)
            {
                total = x * y;
            }
            else
            {
                //Faz a verificação se a divisão está sendo feita por 0
                if(y == 0)
                {
                    txtTotal.Text = "Divisão por zero";

                    //Sai dá sub-rotina, não executa o código abaixo
                    return;
                }

                total = x / y;
            }

            //Exibi o resultado da operação no TextBox Total
            txtTotal.Text = total.ToString();
        }
    }
}
