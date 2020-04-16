using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Inclui o namespace  para o banco SQL Server
using System.Data.SqlClient;

namespace ProjetoACRRentalCar
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        //Sub-rotina para ativação dos controles
        private void Habilitar()
        {
            //Desabilita o txtCodigo
            txtCodigo.Enabled = false;

            //Habilita os demais campos
            txtNome.Enabled = true;
            mskCPF.Enabled = true;
            mskDtNasc.Enabled = true;
        }

        private void Desabilitar()
        {
            //Desabilita o txtCodigo
            txtCodigo.Enabled = false;
            
            //Habilita os demais campos
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            mskDtNasc.Enabled = false;
        }

        private void LimparControles()
        {
            //Desabilita o txtCodigo
            txtCodigo.Enabled = false;

            //Limpa os campos de TextBox
            txtNome.Clear();
            mskCPF.Clear();
            mskDtNasc.Clear();

            //Coloca o foco no mskCPF
            mskCPF.Focus();
        }

        //Função para validação dos campos de entrada
        private bool ValidarDados()
        {
            //Se não for digitado nenhum cpf ou se for inválido
            if (string.IsNullOrEmpty(mskCPF.Text))
            {
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCPF.Clear();
                mskCPF.Focus();

                return false;
            }

            DateTime auxData;
            
            //Se não for digitada nenhuma data ou se for inválida
            if(!(DateTime.TryParse(mskDtNasc.Text, out auxData)))
            {
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDtNasc.Clear();
                mskDtNasc.Focus();

                return false;
            }

            //Se não for digitado nenhum nome
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtNome.Focus();

                return false;
            }

            //Se todas as validações estiverem OK
            return true;
        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            //Chama a função para ativar os controles
            Habilitar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                //se txtCodigo não estiver vazio, significa que já foi consultado
                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um novo registro?",
                                    "ACR Rental Car", 
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimparControles();
                    return;
                }
            }

            if (!ValidarDados())
            {
                return;
            }

            //Variável para guardar as instruções de conexão ao banco de dados
            string sqlQuery;

            //Cria a conexão com o banco de dados
            SqlConnection conexaoCliente = Conexao.getConnection();

            //Cria a instrução sql parâmetizada
            sqlQuery = "INSERT INTO cliente(nome, data_nasc, cpf) VALUES(@nome, @data_nasc, @cpf)";

            //Tratamento de exceções
            try
            {
                //Abre a conexão com o banco de dados
                conexaoCliente.Open();

                /*Cria um objeto do tipo sqlCommand:
                 * Recebe dois parâmetros, sendo o primeiro a instrução SQL(sqlQuery) seguido da conexão com o banco de dados (conexaoCliente)
                 */
                SqlCommand cmd = new SqlCommand(sqlQuery, conexaoCliente);

                //Definição e inclusão dos parâmetros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCPF.Text));

                //Executa os comandos
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente incluído com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparControles();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //Fecha a conexão com o banco de dados
                if(conexaoCliente != null)
                {
                    conexaoCliente.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja alterar clicando no botão consultar",
                                "ACR Rental Car",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarDados())
            {
                return;
            }

            //Variável para guardar as instruções de conexão ao banco de dados
            string sqlQuery;

            //Cria a conexão com o banco de dados
            SqlConnection conexaoCliente = Conexao.getConnection();

            //Cria a instrução sql parâmetizada
            sqlQuery = "UPDATE cliente set nome = @nome, data_nasc = @data_nasc, cpf = @cpf WHERE id_cliente = @id_cliente";

            //Tratamento de exceções
            try
            {
                //Abre a conexão com o banco de dados
                conexaoCliente.Open();

                /*Cria um objeto do tipo sqlCommand:
                 * Recebe dois parâmetros, sendo o primeiro a instrução SQL(sqlQuery) seguido da conexão com o banco de dados (conexaoCliente)
                 */
                SqlCommand cmd = new SqlCommand(sqlQuery, conexaoCliente);

                //Definição e inclusão dos parâmetros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCPF.Text));
                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                //Executa os comandos
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao alterar cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //Fecha a conexão com o banco de dados
                if (conexaoCliente != null)
                {
                    conexaoCliente.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja excluir clicando no botão consultar",
                                "ACR Rental Car",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;               
            }

            //Solicita confirmação de exclusão de cliente
            if(MessageBox.Show("Deseja excluir permanentemente o registro?", 
                                "ACR Rental Car", 
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Variável para guardar as instruções de conexão ao banco de dados
                string sqlQuery;

                //Cria a conexão com o banco de dados
                SqlConnection conexaoCliente = Conexao.getConnection();

                //Cria a instrução sql parâmetizada
                sqlQuery = "DELETE FROM cliente WHERE id_cliente = @id_cliente";

                //Tratamento de exceções
                try
                {
                    //Abre a conexão com o banco de dados
                    conexaoCliente.Open();

                    /*Cria um objeto do tipo sqlCommand:
                     * Recebe dois parâmetros, sendo o primeiro a instrução SQL(sqlQuery) seguido da conexão com o banco de dados (conexaoCliente)
                     */
                    SqlCommand cmd = new SqlCommand(sqlQuery, conexaoCliente);

                    //Definição e inclusão dos parâmetros
                    cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                    //Executa os comandos
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluído com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao excluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    //Fecha a conexão com o banco de dados
                    if (conexaoCliente != null)
                    {
                        conexaoCliente.Close();
                    }
                }
            }            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Form frm = new frmConsultaCliente(this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
