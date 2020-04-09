using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacoRepeticaoNumerosInteiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            //Limpa a ListBox
            lstNumeros.Items.Clear();

            //Declaração da Variável controladora do laço
            int i;

            for(i = 0; i <= 100; i++)
            {
                //Acrescenta o valor da variável i a ListBox
                lstNumeros.Items.Add(i);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //Limpar a ListBox
            lstNumeros.Items.Clear();

            //Declaração da variável controladora do laço
            int i = 1;

            while(i <= 100)
            {
                //Acrescenta o valor da variável i a ListBox
                lstNumeros.Items.Add(i);

                //Incrementa a variável controladora
                i++;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            //Limpa a ListBox
            lstNumeros.Items.Clear();

            //Declaração da variável controladora do laço
            int i = 1;

            do
            {
                //Acrescenta o valor da variável i a ListBox
                lstNumeros.Items.Add(i);

                //Incrementa a variável controladora
                i++;

            } while (i <= 100);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa a ListBox
            lstNumeros.Items.Clear();
        }
    }
}
