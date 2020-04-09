using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Preenche o ComboBox com os sabores de Pizza
            cboSabores.Items.Add("Mussarela");
            cboSabores.Items.Add("Palmito");
            cboSabores.Items.Add("Atum");
            cboSabores.Items.Add("Calabresa");

            //Seleciona o item da lista que tem o índice = 0, o primeiro da lista
            cboSabores.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Seleciona o item da lista que tem o índice = 0, o primeiro da lista
            cboSabores.SelectedIndex = 0;

            //Coloca o cursos no ComboBox
            cboSabores.Focus();

            //Deixa os CheckBox sem seleção
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            //Deixa o RadionButton rdpSemBorda selecionado
            rdbSemBorda.Checked = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            string strSabor;

            //Variável para concatenar os textos
            string strPedido = null;

            //Variável que receber o texto do ComboBox
            strSabor = cboSabores.Text;

            /*
             * Verifica se tem algum item do ComboBox selecionado por meio da propriedade Text
             * Se o texto for nulo ou vazio emite uma mensagem ao usuário e coloca do foco do cursor no cboSabores
             */
            if (string.IsNullOrEmpty(cboSabores.Text))
            {
                MessageBox.Show("Selecione um sabor de Pizza", "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSabores.Focus();
                return;
            }
            
            //Estrutura Switch para a seleção dos sabores de Pizza, a variável strPedido recebe o texto de strSabor
            switch(strSabor)
            {
                case "Mussarela":
                    strPedido = "Mussarela";
                    break;
                case "Palmito":
                    strPedido = "Palmito";
                    break;
                case "Atum":
                    strPedido = "Atum";
                    break;
                case "Calabresa":
                    strPedido = "Calabresa";
                    break;
            }

            /*
             * Neste caso pode-se ter até dois selecionados, um ou nenhum;
             * Concatena o texto de strPedido com a String definida;
             * Verifica se o CheckBox está selecionado.
             */
            if(chkAzeitona.Checked)
            {
                //Concatena o texto de strPedido com a String definida
                strPedido = strPedido + " com Azeitonas";
            }
            if (chkCebola.Checked)
            {
                strPedido = strPedido + " com Cebola";
            }

            //Verifica se o RadionButton está selecionado
            if (rdbComBorda.Checked)
            {
                strPedido = strPedido + " com Borda Recheada";
            }
            else
            {
                strPedido = strPedido + " sem Borda";
            }

            //Exibe a mensagem com a formação do pedido
            MessageBox.Show(strPedido, "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
