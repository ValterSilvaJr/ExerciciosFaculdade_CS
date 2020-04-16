using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoACRRentalCar
{
    public partial class frmConsultaCliente : Form
    {
        //Declaração de uma variável (objeto) do tipo frmCadastroClientes
        frmCadastroCliente frmCliente;

        //Passa por parâmetro o form frmCadastroClientes para o construtor
        public frmConsultaCliente(frmCadastroCliente frmCliente)
        {
            //Variável da classe = parâmetro do construtor
            this.frmCliente = frmCliente;
            InitializeComponent();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            string sqlQuery;
            sqlQuery = "SELECT id_cliente, nome, cpf, data_nasc FROM cliente ORDER BY nome";

            SqlConnection conexaoCliente = Conexao.getConnection();

            //Declaração de um DataAdapter para exibição dos dados
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, conexaoCliente);

            //Declaração de um DataTable para a criação da view
            DataTable dt = new DataTable();

            try
            {
                //Chama o método Fill() do DataAdapter passando como parâmetro o DataTable
                dta.Fill(dt);

                //Configura a fonte de dados no DataGridView
                dgvCliente.DataSource = dt;

                //Altera a cor das linhas alternadas do grid
                dgvCliente.RowsDefaultCellStyle.BackColor = Color.White;
                dgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                //Cria as colunas no DataGridView e coloca o texto do nome das colunas
                dgvCliente.Columns[0].HeaderCell.Value = "Código do Cliente";
                dgvCliente.Columns[1].HeaderCell.Value = "Nome";
                dgvCliente.Columns[2].HeaderCell.Value = "CPF";
                dgvCliente.Columns[3].HeaderCell.Value = "Dt. Nasc.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao listar clientes " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if(conexaoCliente != null)
                {
                    conexaoCliente.Close();
                }
            }
        }
    }
}
