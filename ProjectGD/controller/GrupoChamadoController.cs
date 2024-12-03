using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ProjectX.controller
{
    public class GrupoChamadoController
    {
        public int AdicionarGrupo(string titulo)
        {
            try
            {
                conn conexaoDB = new conn();
                using (MySqlConnection conexao = conexaoDB.GetConnection())
                {
                    conexao.Open();
                    string query = "INSERT INTO grupo_chamados (titulo) VALUES (@Titulo); SELECT LAST_INSERT_ID();";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Titulo", titulo);

                        return Convert.ToInt32(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar grupo: {ex.Message}");
                return -1;
            }
        }

        public List<GrupoChamado> ObterTodosGrupos()
        {
            List<GrupoChamado> grupos = new List<GrupoChamado>();

            try
            {
                conn conexaoDB = new conn();
                using (MySqlConnection conexao = conexaoDB.GetConnection())
                {
                    conexao.Open();
                    string query = "SELECT id, titulo FROM grupo_chamados";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                grupos.Add(new GrupoChamado
                                {
                                    Id = reader.GetInt32("id"),
                                    Titulo = reader.GetString("titulo")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter grupos: {ex.Message}");
            }

            return grupos;
        }
    }

    public class GrupoChamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
    }
}
