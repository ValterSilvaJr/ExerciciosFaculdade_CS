using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercorrendoVetores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            int i, num;
            
            //Variável que irá receber o tamanho do vetor do TextBox
            num = Convert.ToInt32(txtNum.Text);

            //Declarando e inicializando um vetor
            int[] vetor = new int[num];
      
            //Limpa a ListBox
            lstNumeros.Items.Clear();
            lstNumeros2.Items.Clear();

            //Condicional se a quantidade de números for maior que 1000 não entrará na sub-rotina
            if(num > 1000)
            {
                MessageBox.Show("O Limite de números é 1000", "Vetores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            else
            {
                //Se as condições forem atendidas o código abaixo será executado
                
                for (i = 0; i < num; i++)
                {
                    vetor[i] = i;
                    lstNumeros.Items.Add("Vetor Índice [" + i + "] = " + vetor[i]);
                }

                foreach(int j in vetor)
                {
                    lstNumeros2.Items.Add("Vetor Índice [" + j + "] = " + j);
                }
            }
        }
    }
}
