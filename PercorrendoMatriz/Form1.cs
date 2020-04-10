using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercorrendoMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            //Limpa a ListBox
            lstMatriz.Items.Clear();

            //Declaração das variáveis
            int nLinhas, nColunas;

            nLinhas = Convert.ToInt32(txtLinhas.Text);
            nColunas = Convert.ToInt32(txtColunas.Text);

            int linha, coluna;


            //Dimensão da Matriz
            int[,] numeros = new int[nLinhas, nColunas];

            for(linha = 0; linha < nLinhas; linha++)
            {
                for(coluna = 0; coluna < nColunas; coluna++)
                {
                    //Atribui o valor de linha * coluna
                    numeros[linha, coluna] = linha * coluna;
                }
            }

            if(nLinhas > 30 || nColunas > 30)
            {
                MessageBox.Show("O máximo de linhas ou colunas permitido é de 30!", "Matriz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLinhas.Clear();
                txtColunas.Clear();
                txtLinhas.Focus();
            }
            else
            {
                //Exibindo os valores no ListBox através de uma Iteração
                for (linha = 0; linha < nLinhas; linha++)
                {
                    for (coluna = 0; coluna < nColunas; coluna++)
                    {
                        lstMatriz.Items.Add("Elemento [" + linha + "," + coluna + "] = " + numeros[linha, coluna]);
                    }
                }
            }   
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstMatriz.Items.Clear();
        }
    }
}
