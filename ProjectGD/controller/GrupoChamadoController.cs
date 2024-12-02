using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ProjectX.controller
{
    public class GrupoChamadoController
    {
        public bool AdicionarGrupo(string titulo)
        {
            try
            {
                // Cria uma instância da classe de conexão
                conn conexaoDB = new conn();
                using (MySqlConnection conexao = conexaoDB.GetConnection())
                {
                    conexao.Open(); // Abre a conexão com o banco de dados

                    // Comando SQL para inserir o título
                    string query = "INSERT INTO grupo_chamados (Titulo) VALUES (@Titulo)";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        // Adiciona o parâmetro para evitar SQL Injection
                        comando.Parameters.AddWithValue("@Titulo", titulo);
                        comando.ExecuteNonQuery(); // Executa o comando SQL
                    }
                }

                return true; // Indica sucesso
            }
            catch (Exception ex)
            {
                // Log ou exibição de erros
                Console.WriteLine($"Erro ao adicionar grupo: {ex.Message}");
                return false; // Indica falha
            }
        }
    }
}


