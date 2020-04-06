using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalComposta
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
            double nota1, nota2, nota3, media;

            //Entrada de dados
            nota1 = double.Parse(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);

            //Processamento dos dados
            media = (nota1 + nota2 + nota3) / 3;

            //Exibe a média no lblMedia
            lblMedia.Text = media.ToString();

            //Verificação da situação do aluno
            if(media >= 7)
            {
                //Se a condição for verdadeira
                lblSituacao.Text = "Aluno Aprovado!!";
            }
            else
            {
                //Se a condição for falsa
                lblSituacao.Text = "Aluno Reprovado!!";
            }
        }
    }
}
