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
        // Método para adicionar chamado
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

        // Método para recuperar os chamados por grupo
        public List<Chamado> ObterChamadosPorGrupo(int idGrupoChamado)
        {
            List<Chamado> chamados = new List<Chamado>();

            try
            {
                // Cria uma instância da classe de conexão
                conn conexaoDB = new conn();
                using (MySqlConnection conexao = conexaoDB.GetConnection())
                {
                    conexao.Open(); // Abre a conexão com o banco de dados

                    // Comando SQL para recuperar os chamados com base no ID do grupo
                    string query = "SELECT id, hora_inicio, hora_final, descricao FROM Chamados WHERE id_grupo_chamado = @idGrupoChamado";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@idGrupoChamado", idGrupoChamado);

                        // Executa a consulta e lê os dados
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Chamado chamado = new Chamado
                                {
                                    Id = reader.GetInt32("id"),
                                    HoraInicio = reader.GetTimeSpan("hora_inicio"),
                                    HoraFinal = reader.GetTimeSpan("hora_final"),
                                    Descricao = reader.GetString("descricao")
                                };
                                chamados.Add(chamado);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe erro caso algo dê errado
                Console.WriteLine($"Erro ao obter chamados: {ex.Message}");
            }

            return chamados;
        }

        // Método para buscar um chamado específico por ID
        public Chamado ObterChamadoPorId(int idChamado)
        {
            Chamado chamado = null;

            try
            {
                // Cria uma instância da classe de conexão
                conn conexaoDB = new conn();
                using (MySqlConnection conexao = conexaoDB.GetConnection())
                {
                    conexao.Open(); // Abre a conexão com o banco de dados

                    // Comando SQL para recuperar o chamado específico
                    string query = "SELECT id, hora_inicio, hora_final, descricao FROM Chamados WHERE id = @idChamado";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@idChamado", idChamado);

                        // Executa a consulta e lê o resultado
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read()) // Se encontrar o chamado com o ID fornecido
                            {
                                chamado = new Chamado
                                {
                                    Id = reader.GetInt32("id"),
                                    HoraInicio = reader.GetTimeSpan("hora_inicio"),
                                    HoraFinal = reader.GetTimeSpan("hora_final"),
                                    Descricao = reader.GetString("descricao")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe erro caso algo dê errado
                Console.WriteLine($"Erro ao obter chamado por ID: {ex.Message}");
            }

            return chamado;
        }
    }

    // Classe para representar o chamado
    public class Chamado
    {
        public int Id { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFinal { get; set; }
        public string Descricao { get; set; }
    }
}
