using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncaoParametrosValorRef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Implementação das Sub-rotinas
        void PorValor(double varA, double varB)
        {
            //Altera o valor das variáveis locais que são passados por valor, não altera o valor original das variáveis do BtnValor
            //Essas alterações só são validas dentro deste escopo
            varA = varA * 2;
            varB = varB * 5;
        }

        void PorReferencia(ref double varA, ref double VarB)
        {
            //Altera o valor das variáveis que são passadas por referência e altera os valores das variáveis originais do btnRef
            varA = varA * 2;
            VarB = VarB * 5;
        }

        void LimparControles()
        {
            //Limpa os textos dos TextBox
            txtResA.Clear();
            txtResB.Clear();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis originais
            double varA, varB;

            //Entrada de dados
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //Chamada do procedimento PorValor() passando os parâmetros por valor
            PorValor(varA, varB);

            //Chama o procedimento LimparControles()
            LimparControles();

            //Saida de dados para verificar se não houve alteração no valor da variável original
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis originais
            double varA, varB;

            //Entrada de dados
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //Chama o procedimento PorReferencia() passando os parâmetros por referência
            PorReferencia(ref varA, ref varB);

            //Chama o procedimento LimparControles()
            LimparControles();

            //Saída de dados  para verificar se não houve alteração no valor da variável original
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }
    }
}
