using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncaoMaiorNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaração e implementação da função, retorna o valor do maior número.
        int VerificaMaior(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            return num2;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            int a, b;

            //Entrada de dados
            a = Convert.ToInt32(txtA.Text);
            b = Int32.Parse(txtB.Text);

            //Chamando a função verificadora do maior número e passando os argumentos
            txtMaior.Text = VerificaMaior(a, b).ToString();
        }

        //Procedimento para limpar os campos dos TextBox, não retorna valor
        void LimparControles()
        {
            //Limpa o conteúdo dos controles
            txtA.Clear();
            txtB.Clear();
            txtMaior.Clear();
            txtA.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Chama o procedimento LimparControles
            LimparControles();
        }
    }
}
