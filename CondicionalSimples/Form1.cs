using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Declarando a variável média
            double media;

            //Variável média recebe o valor digitado na textbox
            //Convert.ToDouble, converte o valor digitado na textbox para double
            media = Convert.ToDouble(txtMedia.Text); // ou media = double.Parse(txtMedia.Text);

            //Testa a condição se a média for maior ou igual a 7
            //Se a condição for verdadeira a mensagem é exibida, caso contrário, não acontece nada
            if(media >= 7.0)
            {
                MessageBox.Show("Aluno Aprovado!!!", "Média");
            }
        }
    }
}
