using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarPatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Limpar os itens adicionados no ComboBox
            cboAnimais.Items.Clear();

            //Adiciona itens ao ComboBox por meio do método Add()
            cboAnimais.Items.Add("Cachorro");
            cboAnimais.Items.Add("Cavalo");
            cboAnimais.Items.Add("Gato");
            cboAnimais.Items.Add("Centopeia");
            cboAnimais.Items.Add("Cobra");
            cboAnimais.Items.Add("Pássaro");
        }

        private void btnPatas_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            string strAnimal;

            //A variável strAnimal irá receber o valor atual do ComboBox
            strAnimal = cboAnimais.Text;

            //Instrução de seleção
            switch (strAnimal)
            {
                case "Cavalo":
                    pctAnimais.Load("cavalo.jpg");
                    MessageBox.Show("Este Animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Gato":
                    pctAnimais.Load("gato.jpg");
                    MessageBox.Show("Este Animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cachorro":
                    pctAnimais.Load("cachorro.jpg");
                    MessageBox.Show("Este Animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Centopeia":
                    pctAnimais.Load("centopeia.jpg");
                    MessageBox.Show("Este Animal tem 100 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Cobra":
                    pctAnimais.Load("cobra.jpg");
                    MessageBox.Show("Este Animal não tem patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Pássaro":
                    pctAnimais.Load("passaro.jpg");
                    MessageBox.Show("Este Animal tem 2 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    pctAnimais.ResetText();
                    MessageBox.Show("Selecione um Animal", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
