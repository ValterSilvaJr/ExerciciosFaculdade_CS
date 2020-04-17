using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Definição dos namespaces usados no projeto para o SQL SERVER
using System.Data;
using System.Data.SqlClient;

namespace ProjetoACRRentalCar
{
    public class Conexao
    {
        //Método para criar a conexão com o banco de dados
        public static SqlConnection getConnection()
        {
            //Cria um objeto (variável cnn) do tipo SqlConnection e configura a String de conexão
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
                                                    Initial Catalog=DB_RENTALCAR;
                                                    Integrated Security=True;
                                                    Pooling=False");

            //Retorna a conexão com o banco dados quando este método for chamado
            return cnn;
        }

        public class MySQL
        {
            static string sqlServer = @"CAMINHO DO SERVIDOR";
            public static SqlConnection getConnection()
            {
                SqlConnection cnn = new SqlConnection(sqlServer);
                return cnn;
            }
        }

        public class SQLServer
        {
            public static SqlConnection getConnection()
            {
                SqlConnection cnn = new SqlConnection(@"CAMINHO DO SERVIDOR");
                return cnn;
            }
        }

        public class OracleServer
        {
            public static SqlConnection getConnection()
            {
                SqlConnection cnn = new SqlConnection(@"CAMINHO DO SERVIDOR");
                return cnn;
            }
        }
    }
}
