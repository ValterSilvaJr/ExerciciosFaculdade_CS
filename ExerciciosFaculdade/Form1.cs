using System;
using System.Windows.Forms;

namespace ExerciciosFaculdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World " + txtNome.Text + '!');
        }
    }
}
