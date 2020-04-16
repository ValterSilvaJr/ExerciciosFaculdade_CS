using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoACRRentalCar
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria um novo forumlário
            Form frmCadastroClientes = new frmCadastroCliente();

            //Define quem é o pai dessa janela
            frmCadastroClientes.MdiParent = this;

            //Exibe o formulário
            frmCadastroClientes.Show();
        }
    }
}
