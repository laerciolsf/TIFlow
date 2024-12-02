using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.controller
{
    public class ChamadoController
    {
        public bool AdicionarChamado(TimeSpan horaInicio, TimeSpan horaFinal, string descricao, int idGrupoChamado)
        {
            try
            {
                // Cria uma instância da classe de conexão
                conn conexaoDB = new conn();
                using (MySqlConnection conexao = conexaoDB.GetConnection())
                {
                    conexao.Open(); // Abre a conexão com o banco de dados

                    // Comando SQL para inserir o chamado
                    string query = "INSERT INTO Chamados (hora_inicio, hora_final, descricao, id_grupo_chamado) " +
                                   "VALUES (@HoraInicio, @HoraFinal, @Descricao, @IdGrupoChamado)";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        // Adiciona os parâmetros para evitar SQL Injection
                        comando.Parameters.AddWithValue("@HoraInicio", horaInicio);
                        comando.Parameters.AddWithValue("@HoraFinal", horaFinal);
                        comando.Parameters.AddWithValue("@Descricao", descricao);
                        comando.Parameters.AddWithValue("@IdGrupoChamado", idGrupoChamado);

                        comando.ExecuteNonQuery(); // Executa o comando SQL
                    }
                }

                return true; // Indica sucesso
            }
            catch (Exception ex)
            {
                // Log ou exibição de erros
                Console.WriteLine($"Erro ao adicionar chamado: {ex.Message}");
                return false; // Indica falha
            }
        }
    }
}
