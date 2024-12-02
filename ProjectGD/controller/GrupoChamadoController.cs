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
        public int AdicionarGrupo(string titulo)
        {
            try
            {
                // Cria uma instância da classe de conexão
                conn conexaoDB = new conn();
                using (MySqlConnection conexao = conexaoDB.GetConnection())
                {
                    conexao.Open(); // Abre a conexão com o banco de dados

                    // Comando SQL para inserir o grupo e pegar o ID gerado
                    string query = "INSERT INTO grupo_chamados (Titulo) VALUES (@Titulo); SELECT LAST_INSERT_ID();";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        // Adiciona o parâmetro para evitar SQL Injection
                        comando.Parameters.AddWithValue("@Titulo", titulo);

                        // Executa o comando e retorna o ID gerado
                        int idGerado = Convert.ToInt32(comando.ExecuteScalar());
                        return idGerado; // Retorna o ID do novo grupo
                    }
                }
            }
            catch (Exception ex)
            {
                // Log ou exibição de erros
                Console.WriteLine($"Erro ao adicionar grupo: {ex.Message}");
                MessageBox.Show($"Erro ao adicionar grupo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Retorna -1 em caso de falha
            }
        }
    }
}

